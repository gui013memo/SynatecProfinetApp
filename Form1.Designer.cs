namespace SynatecProfinetApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.btnStartCapture = new System.Windows.Forms.Button();
            this.grpStation = new System.Windows.Forms.GroupBox();
            this.txtErrorCode = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.chkLifebit = new System.Windows.Forms.CheckBox();
            this.chkOutgoing = new System.Windows.Forms.CheckBox();
            this.chkIncoming = new System.Windows.Forms.CheckBox();
            this.txtType = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtKNR = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grpWorkplan = new System.Windows.Forms.GroupBox();
            this.txtSpindle2ID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSpindle1ID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.grpScrewdriver = new System.Windows.Forms.GroupBox();
            this.grpSpindle2 = new System.Windows.Forms.GroupBox();
            this.chkSpindle2Done = new System.Windows.Forms.CheckBox();
            this.chkSpindle2NOK = new System.Windows.Forms.CheckBox();
            this.chkSpindle2OK = new System.Windows.Forms.CheckBox();
            this.chkSpindle2Start = new System.Windows.Forms.CheckBox();
            this.txtSpindle2Position = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.grpSpindle1 = new System.Windows.Forms.GroupBox();
            this.chkSpindle1Done = new System.Windows.Forms.CheckBox();
            this.chkSpindle1NOK = new System.Windows.Forms.CheckBox();
            this.chkSpindle1OK = new System.Windows.Forms.CheckBox();
            this.chkSpindle1Start = new System.Windows.Forms.CheckBox();
            this.txtSpindle1Position = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.grpStation.SuspendLayout();
            this.grpWorkplan.SuspendLayout();
            this.grpScrewdriver.SuspendLayout();
            this.grpSpindle2.SuspendLayout();
            this.grpSpindle1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnStartCapture
            // 
            this.btnStartCapture.BackColor = System.Drawing.Color.Green;
            this.btnStartCapture.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartCapture.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnStartCapture.Location = new System.Drawing.Point(13, 493);
            this.btnStartCapture.Margin = new System.Windows.Forms.Padding(4);
            this.btnStartCapture.Name = "btnStartCapture";
            this.btnStartCapture.Size = new System.Drawing.Size(659, 124);
            this.btnStartCapture.TabIndex = 0;
            this.btnStartCapture.Text = "Start Capture";
            this.btnStartCapture.UseVisualStyleBackColor = false;
            this.btnStartCapture.Click += new System.EventHandler(this.btnStartCapture_Click);
            // 
            // grpStation
            // 
            this.grpStation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.grpStation.Controls.Add(this.txtErrorCode);
            this.grpStation.Controls.Add(this.label5);
            this.grpStation.Controls.Add(this.chkLifebit);
            this.grpStation.Controls.Add(this.chkOutgoing);
            this.grpStation.Controls.Add(this.chkIncoming);
            this.grpStation.Controls.Add(this.txtType);
            this.grpStation.Controls.Add(this.label2);
            this.grpStation.Controls.Add(this.txtKNR);
            this.grpStation.Controls.Add(this.label1);
            this.grpStation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpStation.Location = new System.Drawing.Point(13, 13);
            this.grpStation.Margin = new System.Windows.Forms.Padding(4);
            this.grpStation.Name = "grpStation";
            this.grpStation.Padding = new System.Windows.Forms.Padding(4);
            this.grpStation.Size = new System.Drawing.Size(659, 162);
            this.grpStation.TabIndex = 1;
            this.grpStation.TabStop = false;
            this.grpStation.Text = "Station Interface";
            // 
            // txtErrorCode
            // 
            this.txtErrorCode.BackColor = System.Drawing.Color.White;
            this.txtErrorCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtErrorCode.Location = new System.Drawing.Point(573, 52);
            this.txtErrorCode.Margin = new System.Windows.Forms.Padding(4);
            this.txtErrorCode.Name = "txtErrorCode";
            this.txtErrorCode.ReadOnly = true;
            this.txtErrorCode.Size = new System.Drawing.Size(64, 34);
            this.txtErrorCode.TabIndex = 8;
            this.txtErrorCode.Text = "0000";
            this.txtErrorCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(543, 23);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 25);
            this.label5.TabIndex = 7;
            this.label5.Text = "ErrorCode:";
            // 
            // chkLifebit
            // 
            this.chkLifebit.AutoSize = true;
            this.chkLifebit.Location = new System.Drawing.Point(412, 125);
            this.chkLifebit.Margin = new System.Windows.Forms.Padding(4);
            this.chkLifebit.Name = "chkLifebit";
            this.chkLifebit.Size = new System.Drawing.Size(85, 29);
            this.chkLifebit.TabIndex = 6;
            this.chkLifebit.Text = "Lifebit";
            this.chkLifebit.UseVisualStyleBackColor = true;
            // 
            // chkOutgoing
            // 
            this.chkOutgoing.AutoSize = true;
            this.chkOutgoing.Location = new System.Drawing.Point(283, 125);
            this.chkOutgoing.Margin = new System.Windows.Forms.Padding(4);
            this.chkOutgoing.Name = "chkOutgoing";
            this.chkOutgoing.Size = new System.Drawing.Size(114, 29);
            this.chkOutgoing.TabIndex = 5;
            this.chkOutgoing.Text = "Outgoing";
            this.chkOutgoing.UseVisualStyleBackColor = true;
            // 
            // chkIncoming
            // 
            this.chkIncoming.AutoSize = true;
            this.chkIncoming.Location = new System.Drawing.Point(154, 125);
            this.chkIncoming.Margin = new System.Windows.Forms.Padding(4);
            this.chkIncoming.Name = "chkIncoming";
            this.chkIncoming.Size = new System.Drawing.Size(113, 29);
            this.chkIncoming.TabIndex = 4;
            this.chkIncoming.Text = "Incoming";
            this.chkIncoming.UseVisualStyleBackColor = true;
            // 
            // txtType
            // 
            this.txtType.BackColor = System.Drawing.Color.White;
            this.txtType.Location = new System.Drawing.Point(274, 87);
            this.txtType.Margin = new System.Windows.Forms.Padding(4);
            this.txtType.Name = "txtType";
            this.txtType.ReadOnly = true;
            this.txtType.Size = new System.Drawing.Size(123, 30);
            this.txtType.TabIndex = 3;
            this.txtType.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(204, 92);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Type:";
            // 
            // txtKNR
            // 
            this.txtKNR.BackColor = System.Drawing.Color.White;
            this.txtKNR.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKNR.Location = new System.Drawing.Point(193, 26);
            this.txtKNR.Margin = new System.Windows.Forms.Padding(4);
            this.txtKNR.Name = "txtKNR";
            this.txtKNR.ReadOnly = true;
            this.txtKNR.Size = new System.Drawing.Size(269, 53);
            this.txtKNR.TabIndex = 1;
            this.txtKNR.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(78, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "KNR:";
            // 
            // grpWorkplan
            // 
            this.grpWorkplan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.grpWorkplan.Controls.Add(this.txtSpindle2ID);
            this.grpWorkplan.Controls.Add(this.label4);
            this.grpWorkplan.Controls.Add(this.txtSpindle1ID);
            this.grpWorkplan.Controls.Add(this.label3);
            this.grpWorkplan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpWorkplan.Location = new System.Drawing.Point(13, 197);
            this.grpWorkplan.Margin = new System.Windows.Forms.Padding(4);
            this.grpWorkplan.Name = "grpWorkplan";
            this.grpWorkplan.Padding = new System.Windows.Forms.Padding(4);
            this.grpWorkplan.Size = new System.Drawing.Size(659, 92);
            this.grpWorkplan.TabIndex = 2;
            this.grpWorkplan.TabStop = false;
            this.grpWorkplan.Text = "Workplan Interface";
            // 
            // txtSpindle2ID
            // 
            this.txtSpindle2ID.BackColor = System.Drawing.Color.White;
            this.txtSpindle2ID.Location = new System.Drawing.Point(434, 54);
            this.txtSpindle2ID.Margin = new System.Windows.Forms.Padding(4);
            this.txtSpindle2ID.Name = "txtSpindle2ID";
            this.txtSpindle2ID.ReadOnly = true;
            this.txtSpindle2ID.Size = new System.Drawing.Size(123, 30);
            this.txtSpindle2ID.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(407, 27);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(170, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "Spindle 2 ID Sent:";
            // 
            // txtSpindle1ID
            // 
            this.txtSpindle1ID.BackColor = System.Drawing.Color.White;
            this.txtSpindle1ID.Location = new System.Drawing.Point(118, 54);
            this.txtSpindle1ID.Margin = new System.Windows.Forms.Padding(4);
            this.txtSpindle1ID.Name = "txtSpindle1ID";
            this.txtSpindle1ID.ReadOnly = true;
            this.txtSpindle1ID.Size = new System.Drawing.Size(117, 30);
            this.txtSpindle1ID.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(87, 27);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Spindle 1 ID Sent:";
            // 
            // grpScrewdriver
            // 
            this.grpScrewdriver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grpScrewdriver.Controls.Add(this.grpSpindle2);
            this.grpScrewdriver.Controls.Add(this.grpSpindle1);
            this.grpScrewdriver.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpScrewdriver.Location = new System.Drawing.Point(13, 297);
            this.grpScrewdriver.Margin = new System.Windows.Forms.Padding(4);
            this.grpScrewdriver.Name = "grpScrewdriver";
            this.grpScrewdriver.Padding = new System.Windows.Forms.Padding(4);
            this.grpScrewdriver.Size = new System.Drawing.Size(659, 188);
            this.grpScrewdriver.TabIndex = 3;
            this.grpScrewdriver.TabStop = false;
            this.grpScrewdriver.Text = "ScrewDriver Interface";
            // 
            // grpSpindle2
            // 
            this.grpSpindle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.grpSpindle2.Controls.Add(this.chkSpindle2Done);
            this.grpSpindle2.Controls.Add(this.chkSpindle2NOK);
            this.grpSpindle2.Controls.Add(this.chkSpindle2OK);
            this.grpSpindle2.Controls.Add(this.chkSpindle2Start);
            this.grpSpindle2.Controls.Add(this.txtSpindle2Position);
            this.grpSpindle2.Controls.Add(this.label7);
            this.grpSpindle2.Location = new System.Drawing.Point(331, 23);
            this.grpSpindle2.Margin = new System.Windows.Forms.Padding(4);
            this.grpSpindle2.Name = "grpSpindle2";
            this.grpSpindle2.Padding = new System.Windows.Forms.Padding(4);
            this.grpSpindle2.Size = new System.Drawing.Size(320, 157);
            this.grpSpindle2.TabIndex = 1;
            this.grpSpindle2.TabStop = false;
            this.grpSpindle2.Text = "Spindle 2";
            // 
            // chkSpindle2Done
            // 
            this.chkSpindle2Done.AutoSize = true;
            this.chkSpindle2Done.Location = new System.Drawing.Point(13, 128);
            this.chkSpindle2Done.Margin = new System.Windows.Forms.Padding(4);
            this.chkSpindle2Done.Name = "chkSpindle2Done";
            this.chkSpindle2Done.Size = new System.Drawing.Size(81, 29);
            this.chkSpindle2Done.TabIndex = 5;
            this.chkSpindle2Done.Text = "Done";
            this.chkSpindle2Done.UseVisualStyleBackColor = true;
            // 
            // chkSpindle2NOK
            // 
            this.chkSpindle2NOK.AutoSize = true;
            this.chkSpindle2NOK.Location = new System.Drawing.Point(129, 100);
            this.chkSpindle2NOK.Margin = new System.Windows.Forms.Padding(4);
            this.chkSpindle2NOK.Name = "chkSpindle2NOK";
            this.chkSpindle2NOK.Size = new System.Drawing.Size(78, 29);
            this.chkSpindle2NOK.TabIndex = 4;
            this.chkSpindle2NOK.Text = "NOK";
            this.chkSpindle2NOK.UseVisualStyleBackColor = true;
            // 
            // chkSpindle2OK
            // 
            this.chkSpindle2OK.AutoSize = true;
            this.chkSpindle2OK.Location = new System.Drawing.Point(129, 128);
            this.chkSpindle2OK.Margin = new System.Windows.Forms.Padding(4);
            this.chkSpindle2OK.Name = "chkSpindle2OK";
            this.chkSpindle2OK.Size = new System.Drawing.Size(64, 29);
            this.chkSpindle2OK.TabIndex = 3;
            this.chkSpindle2OK.Text = "OK";
            this.chkSpindle2OK.UseVisualStyleBackColor = true;
            // 
            // chkSpindle2Start
            // 
            this.chkSpindle2Start.AutoSize = true;
            this.chkSpindle2Start.Location = new System.Drawing.Point(13, 99);
            this.chkSpindle2Start.Margin = new System.Windows.Forms.Padding(4);
            this.chkSpindle2Start.Name = "chkSpindle2Start";
            this.chkSpindle2Start.Size = new System.Drawing.Size(75, 29);
            this.chkSpindle2Start.TabIndex = 2;
            this.chkSpindle2Start.Text = "Start";
            this.chkSpindle2Start.UseVisualStyleBackColor = true;
            // 
            // txtSpindle2Position
            // 
            this.txtSpindle2Position.BackColor = System.Drawing.Color.Black;
            this.txtSpindle2Position.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSpindle2Position.ForeColor = System.Drawing.Color.White;
            this.txtSpindle2Position.Location = new System.Drawing.Point(132, 58);
            this.txtSpindle2Position.Margin = new System.Windows.Forms.Padding(4);
            this.txtSpindle2Position.Name = "txtSpindle2Position";
            this.txtSpindle2Position.ReadOnly = true;
            this.txtSpindle2Position.Size = new System.Drawing.Size(75, 34);
            this.txtSpindle2Position.TabIndex = 1;
            this.txtSpindle2Position.Text = "0";
            this.txtSpindle2Position.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(46, 27);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(245, 35);
            this.label7.TabIndex = 0;
            this.label7.Text = "Position sent by PLC:";
            // 
            // grpSpindle1
            // 
            this.grpSpindle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.grpSpindle1.Controls.Add(this.txtSpindle1Position);
            this.grpSpindle1.Controls.Add(this.chkSpindle1Done);
            this.grpSpindle1.Controls.Add(this.chkSpindle1NOK);
            this.grpSpindle1.Controls.Add(this.chkSpindle1OK);
            this.grpSpindle1.Controls.Add(this.chkSpindle1Start);
            this.grpSpindle1.Controls.Add(this.label6);
            this.grpSpindle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpSpindle1.Location = new System.Drawing.Point(8, 23);
            this.grpSpindle1.Margin = new System.Windows.Forms.Padding(4);
            this.grpSpindle1.Name = "grpSpindle1";
            this.grpSpindle1.Padding = new System.Windows.Forms.Padding(4);
            this.grpSpindle1.Size = new System.Drawing.Size(315, 157);
            this.grpSpindle1.TabIndex = 0;
            this.grpSpindle1.TabStop = false;
            this.grpSpindle1.Text = "Spindle 1";
            // 
            // chkSpindle1Done
            // 
            this.chkSpindle1Done.AutoSize = true;
            this.chkSpindle1Done.Location = new System.Drawing.Point(12, 128);
            this.chkSpindle1Done.Margin = new System.Windows.Forms.Padding(4);
            this.chkSpindle1Done.Name = "chkSpindle1Done";
            this.chkSpindle1Done.Size = new System.Drawing.Size(81, 29);
            this.chkSpindle1Done.TabIndex = 5;
            this.chkSpindle1Done.Text = "Done";
            this.chkSpindle1Done.UseVisualStyleBackColor = true;
            // 
            // chkSpindle1NOK
            // 
            this.chkSpindle1NOK.AutoSize = true;
            this.chkSpindle1NOK.Location = new System.Drawing.Point(127, 100);
            this.chkSpindle1NOK.Margin = new System.Windows.Forms.Padding(4);
            this.chkSpindle1NOK.Name = "chkSpindle1NOK";
            this.chkSpindle1NOK.Size = new System.Drawing.Size(78, 29);
            this.chkSpindle1NOK.TabIndex = 4;
            this.chkSpindle1NOK.Text = "NOK";
            this.chkSpindle1NOK.UseVisualStyleBackColor = true;
            // 
            // chkSpindle1OK
            // 
            this.chkSpindle1OK.AutoSize = true;
            this.chkSpindle1OK.Location = new System.Drawing.Point(127, 128);
            this.chkSpindle1OK.Margin = new System.Windows.Forms.Padding(4);
            this.chkSpindle1OK.Name = "chkSpindle1OK";
            this.chkSpindle1OK.Size = new System.Drawing.Size(64, 29);
            this.chkSpindle1OK.TabIndex = 3;
            this.chkSpindle1OK.Text = "OK";
            this.chkSpindle1OK.UseVisualStyleBackColor = true;
            // 
            // chkSpindle1Start
            // 
            this.chkSpindle1Start.AutoSize = true;
            this.chkSpindle1Start.Location = new System.Drawing.Point(11, 99);
            this.chkSpindle1Start.Margin = new System.Windows.Forms.Padding(4);
            this.chkSpindle1Start.Name = "chkSpindle1Start";
            this.chkSpindle1Start.Size = new System.Drawing.Size(75, 29);
            this.chkSpindle1Start.TabIndex = 2;
            this.chkSpindle1Start.Text = "Start";
            this.chkSpindle1Start.UseVisualStyleBackColor = true;
            // 
            // txtSpindle1Position
            // 
            this.txtSpindle1Position.BackColor = System.Drawing.Color.Black;
            this.txtSpindle1Position.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSpindle1Position.ForeColor = System.Drawing.Color.White;
            this.txtSpindle1Position.Location = new System.Drawing.Point(110, 58);
            this.txtSpindle1Position.Margin = new System.Windows.Forms.Padding(4);
            this.txtSpindle1Position.Name = "txtSpindle1Position";
            this.txtSpindle1Position.ReadOnly = true;
            this.txtSpindle1Position.Size = new System.Drawing.Size(75, 34);
            this.txtSpindle1Position.TabIndex = 1;
            this.txtSpindle1Position.Text = "0";
            this.txtSpindle1Position.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(21, 27);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(273, 42);
            this.label6.TabIndex = 0;
            this.label6.Text = "Position sent by PLC:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 630);
            this.Controls.Add(this.grpScrewdriver);
            this.Controls.Add(this.grpWorkplan);
            this.Controls.Add(this.grpStation);
            this.Controls.Add(this.btnStartCapture);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Synatec Profinet Monitor - by Application Center Brazil";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpStation.ResumeLayout(false);
            this.grpStation.PerformLayout();
            this.grpWorkplan.ResumeLayout(false);
            this.grpWorkplan.PerformLayout();
            this.grpScrewdriver.ResumeLayout(false);
            this.grpSpindle2.ResumeLayout(false);
            this.grpSpindle2.PerformLayout();
            this.grpSpindle1.ResumeLayout(false);
            this.grpSpindle1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnStartCapture;
        private System.Windows.Forms.GroupBox grpStation;
        private System.Windows.Forms.TextBox txtErrorCode;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox chkLifebit;
        private System.Windows.Forms.CheckBox chkOutgoing;
        private System.Windows.Forms.CheckBox chkIncoming;
        private System.Windows.Forms.TextBox txtType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtKNR;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpWorkplan;
        private System.Windows.Forms.TextBox txtSpindle2ID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSpindle1ID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox grpScrewdriver;
        private System.Windows.Forms.GroupBox grpSpindle2;
        private System.Windows.Forms.CheckBox chkSpindle2Done;
        private System.Windows.Forms.CheckBox chkSpindle2NOK;
        private System.Windows.Forms.CheckBox chkSpindle2OK;
        private System.Windows.Forms.CheckBox chkSpindle2Start;
        private System.Windows.Forms.TextBox txtSpindle2Position;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox grpSpindle1;
        private System.Windows.Forms.CheckBox chkSpindle1Done;
        private System.Windows.Forms.CheckBox chkSpindle1NOK;
        private System.Windows.Forms.CheckBox chkSpindle1OK;
        private System.Windows.Forms.CheckBox chkSpindle1Start;
        private System.Windows.Forms.TextBox txtSpindle1Position;
        private System.Windows.Forms.Label label6;
    }
}
