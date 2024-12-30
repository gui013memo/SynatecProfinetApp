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

        bool timerstate = false;

        public Form1()
        {
            InitializeComponent();
            this.TopMost = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var devices = CaptureDeviceList.Instance;
            if (devices.Count < 1)
            {
                MessageBox.Show("No capture devices found. Make sure Npcap is installed.");
                return;
            }

            if (secondDeviceCheckBox.Checked)
                _device = devices[1];
            else
                _device = devices[0];

            _device.OnPacketArrival += new PacketArrivalEventHandler(OnPacketArrival);
        }

        private void btnStartCapture_Click(object sender, EventArgs e)
        {
            try
            {
                _device.Open(DeviceMode.Promiscuous, 1000);

                _device.Filter = "ether proto 0x8892";

                //_device.Filter = "";

                _device.StartCapture();

                if (timer1.Enabled)
                {
                    timer1.Stop();
                    secondDeviceCheckBox.Enabled = false;
                    btnStartCapture.Text = "START CAPTURE";
                    btnStartCapture.BackColor = Color.Green;
                    btnStartCapture.ForeColor = Color.White;
                    timerstate = false;

                    if (_device != null)
                    {

                        _device.StopCapture();
                        _device.Close();

                    }
                }
                else
                {
                    timer1.Start();
                    secondDeviceCheckBox.Enabled = true;
                    btnStartCapture.Text = "STOP CAPTURE";
                }



            }
            catch (Exception ex)
            {
                MessageBox.Show("Error starting capture: " + ex.Message);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_device != null)
            {

                _device.StopCapture();
                _device.Close();

            }
        }

        /// <summary>
        /// Packet arrival event handler using older SharpPcap signature (5.x).
        /// </summary>
        private void OnPacketArrival(object sender, CaptureEventArgs e)
        {
            var rawPacket = e.Packet.Data;
            if (rawPacket == null)
                return;

            string sourceMacPrefix = string.Format(
            "{0:x2}:{1:x2}:{2:x2}",
            rawPacket[6],  // first byte of source MAC
            rawPacket[7],  // second byte
            rawPacket[8]   // third byte
            );


            int payloadStartOffSet = 26;
            int wrkPlanB0Offset = 79;

            // Synatec Master PC
            if (sourceMacPrefix == "00:03:2d")
            {

                payloadStartOffSet += 3;
                wrkPlanB0Offset += 3;
            }


            // Station Interface
            int typeOffset = payloadStartOffSet + 8;
            int incOutLifeBitOff = typeOffset + 6;
            int errorCodeOff = payloadStartOffSet + 16;

            // Workplan Interface
            int wrkPlanB1Offset = wrkPlanB0Offset + 1;

            // -- Continue parsing as normal --

            // Station Interface fields
            string knr = SafeExtractString(rawPacket, payloadStartOffSet, 8);
            string type = SafeExtractString(rawPacket, typeOffset, 6);

            bool incoming = (rawPacket[incOutLifeBitOff] & 0x01) != 0;
            bool outgoing = (rawPacket[incOutLifeBitOff] & 0x02) != 0;
            bool lifebit = (rawPacket[incOutLifeBitOff] & 0x04) != 0;

            byte errorCode = rawPacket[errorCodeOff];

            // Workplan IDs (spindle1ID, spindle2ID)
            byte spindle1ID = 0;
            byte spindle2ID = 0;
            if (wrkPlanB1Offset + 1 < rawPacket.Length)
            {
                spindle1ID = rawPacket[wrkPlanB0Offset];
                spindle2ID = rawPacket[wrkPlanB1Offset];
            }

            // Screwdriver offset logic
            //  In your Lua code, you do: 
            //  local screwDriver1OffSet = errorCodeOffset + 17 + 6
            //  That’s 16 +17 +6 => 39 from the original base, 
            //  but if payloadStartOffSet changed, we want to keep it relative to errorCodeOff
            int screwDriver1Offset = errorCodeOff + 17 + 6;
            int screwDriver2Offset = screwDriver1Offset + 5 + 2;

            // Spindle 1
            if (screwDriver1Offset + 2 < rawPacket.Length)
            {
                byte spindle1Pos = rawPacket[screwDriver1Offset];
                byte spindle1Cmd = rawPacket[screwDriver1Offset + 2];

                bool spindle1Start = (spindle1Cmd & 0x01) != 0;
                bool spindle1ResultOk = (spindle1Cmd & 0x10) != 0;
                bool spindle1ResultNok = (spindle1Cmd & 0x20) != 0;
                bool spindle1WorkDone = (spindle1Cmd & 0x40) != 0;

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
                byte spindle2Pos = rawPacket[screwDriver2Offset];
                byte spindle2Cmd = rawPacket[screwDriver2Offset + 2];

                bool spindle2Start = (spindle2Cmd & 0x01) != 0;
                bool spindle2ResultOk = (spindle2Cmd & 0x10) != 0;
                bool spindle2ResultNok = (spindle2Cmd & 0x20) != 0;
                bool spindle2WorkDone = (spindle2Cmd & 0x40) != 0;

                this.Invoke((MethodInvoker)delegate
                {
                    txtSpindle2Position.Text = spindle2Pos.ToString();
                    chkSpindle2Start.Checked = spindle2Start;
                    chkSpindle2OK.Checked = spindle2ResultOk;
                    chkSpindle2NOK.Checked = spindle2ResultNok;
                    chkSpindle2Done.Checked = spindle2WorkDone;
                });
            }

            // Finally, update UI for Station/Workplan fields
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

        private void timer1_Tick(object sender, EventArgs e)
        {

            if (timerstate)
            {
                btnStartCapture.BackColor = Color.Gold;
                btnStartCapture.ForeColor = Color.Black;
                timerstate = false;
            }
            else
            {
                btnStartCapture.BackColor = Color.White;
                btnStartCapture.ForeColor = Color.Black;
                timerstate = true;
            }



        }
    }
}