using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SharpPcap;
using SharpPcap.LibPcap;

namespace SynatecProfinetApp
{
    public partial class Form1 : Form
    {
        private ICaptureDevice _device;
        private bool _captureActive = false;  // Track capture status manually (since CaptureStopped is not in 5.2.0)

        public Form1()
        {
            InitializeComponent();
            this.TopMost = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Get capture devices
            var devices = CaptureDeviceList.Instance;
            if (devices.Count < 1)
            {
                MessageBox.Show("No capture devices found. Make sure Npcap is installed.");
                return;
            }

            // For simplicity, pick the first device
            _device = devices[0];

            // Hook up the older signature event
            _device.OnPacketArrival += new PacketArrivalEventHandler(OnPacketArrival);
        }

        private void btnStartCapture_Click(object sender, EventArgs e)
        {
            try
            {
                _device.Open(DeviceMode.Promiscuous, 1000);
                
                // If Profinet uses EtherType 0x8892, you might do:
                _device.Filter = "ether proto 0x8892"; 
                
                //_device.Filter = "";

                _device.StartCapture();
                _captureActive = true;

                btnStartCapture.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error starting capture: " + ex.Message);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_device != null && _captureActive)
            {
                try
                {
                    _device.StopCapture();
                    _device.Close();
                }
                catch
                {
                    // Could log or ignore
                }
                finally
                {
                    _captureActive = false;
                }
            }
        }

        /// <summary>
        /// Packet arrival event handler using older SharpPcap signature (5.x).
        /// </summary>
        private void OnPacketArrival(object sender, CaptureEventArgs e)
        {
            var rawPacket = e.Packet.Data;
            if (rawPacket == null || rawPacket.Length < 100)
                return;

            // Offsets below are adapted from your Lua plugin
            int payloadStartOffSet = 26;
            int typeOffset = payloadStartOffSet + 8;
            int incOutLifeBitOff = typeOffset + 6;
            int desLineStpOff = payloadStartOffSet + 15;
            int errorCodeOff = payloadStartOffSet + 16;

            // Station Interface
            string knr = SafeExtractString(rawPacket, payloadStartOffSet, 8);  // 8 bytes for KNR
            string type = SafeExtractString(rawPacket, typeOffset, 6);         // 6 bytes for Type

            bool incoming = (rawPacket[incOutLifeBitOff] & 0x01) != 0;
            bool outgoing = (rawPacket[incOutLifeBitOff] & 0x02) != 0;
            bool lifebit = (rawPacket[incOutLifeBitOff] & 0x04) != 0;

            byte errorCode = rawPacket[errorCodeOff];

            // Workplan Interface
            int wrkPlanB0Offset = 79; // ID Spindle 1
            int wrkPlanB1Offset = wrkPlanB0Offset + 1; // ID Spindle 2

            byte spindle1ID = 0;
            byte spindle2ID = 0;
            if (wrkPlanB1Offset < rawPacket.Length)
            {
                spindle1ID = rawPacket[wrkPlanB0Offset];
                spindle2ID = rawPacket[wrkPlanB1Offset];
            }

            // Screwdriver Interface
            // Using your example offset: errorCodeOffset + 17 + 6 => 16 +17 +6 => 39 from payloadStartOffSet
            int screwDriver1Offset = errorCodeOff + 17 + 6;
            int screwDriver2Offset = screwDriver1Offset + 5 + 2;

            // Spindle 1
            if (screwDriver1Offset + 2 < rawPacket.Length)
            {
                byte spindle1Pos = rawPacket[screwDriver1Offset];        // position
                byte spindle1Cmd = rawPacket[screwDriver1Offset + 2];    // start, resultOk, resultNok, etc.

                bool spindle1Start = (spindle1Cmd & 0x01) != 0;
                bool spindle1ResultOk = (spindle1Cmd & 0x10) != 0;
                bool spindle1ResultNok = (spindle1Cmd & 0x20) != 0;
                bool spindle1WorkDone = (spindle1Cmd & 0x40) != 0;

                // Update UI safely
                this.Invoke((MethodInvoker)delegate
                {
                    txtSpindle1Position.Text = spindle1Pos.ToString();
                    chkSpindle1Start.Checked = spindle1Start;
                    chkSpindle1OK.Checked = spindle1ResultOk;
                    chkSpindle1NOK.Checked = spindle1ResultNok;
                    chkSpindle1Done.Checked = spindle1WorkDone;
                });
            }

            // Spindle 2
            if (screwDriver2Offset + 2 < rawPacket.Length)
            {
                byte spindle2Pos = rawPacket[screwDriver2Offset];      // position
                byte spindle2Cmd = rawPacket[screwDriver2Offset + 2];  // start, resultOk, etc.

                bool spindle2Start = (spindle2Cmd & 0x01) != 0;
                bool spindle2ResultOk = (spindle2Cmd & 0x10) != 0;
                bool spindle2ResultNok = (spindle2Cmd & 0x20) != 0;
                bool spindle2WorkDone = (spindle2Cmd & 0x40) != 0;

                // Update UI safely
                this.Invoke((MethodInvoker)delegate
                {
                    txtSpindle2Position.Text = spindle2Pos.ToString();
                    chkSpindle2Start.Checked = spindle2Start;
                    chkSpindle2OK.Checked = spindle2ResultOk;
                    chkSpindle2NOK.Checked = spindle2ResultNok;
                    chkSpindle2Done.Checked = spindle2WorkDone;
                });
            }

            // Finally, update Station/Workplan fields
            this.Invoke((MethodInvoker)delegate
            {
                txtKNR.Text = knr;
                txtType.Text = type;
                chkIncoming.Checked = incoming;
                chkOutgoing.Checked = outgoing;
                chkLifebit.Checked = lifebit;
                txtErrorCode.Text = "0x" + errorCode.ToString("X2");

                txtSpindle1ID.Text = spindle1ID.ToString();
                txtSpindle2ID.Text = spindle2ID.ToString();
            });
        }

        // Helper method to safely extract ASCII text from a buffer
        private string SafeExtractString(byte[] buffer, int offset, int length)
        {
            if (offset + length > buffer.Length)
                return string.Empty;

            return Encoding.ASCII.GetString(buffer, offset, length).TrimEnd('\0', ' ');
        }

    }
}