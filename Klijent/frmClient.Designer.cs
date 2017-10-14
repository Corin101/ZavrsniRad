namespace Klijent
{
    partial class frmClient
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.displayBox = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPortNumber = new System.Windows.Forms.TextBox();
            this.txtServerName = new System.Windows.Forms.TextBox();
            this.txtServerCertName = new System.Windows.Forms.TextBox();
            this.chckName = new System.Windows.Forms.CheckBox();
            this.txtcertName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.txtCert = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.chckPort = new System.Windows.Forms.CheckBox();
            this.chckServerName = new System.Windows.Forms.CheckBox();
            this.chckServerCertName = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMsgToServer = new System.Windows.Forms.TextBox();
            this.btnEndChat = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // displayBox
            // 
            this.displayBox.Location = new System.Drawing.Point(330, 12);
            this.displayBox.Multiline = true;
            this.displayBox.Name = "displayBox";
            this.displayBox.Size = new System.Drawing.Size(537, 354);
            this.displayBox.TabIndex = 0;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(774, 380);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(93, 30);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Start Client";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(135, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Client";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Server Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Server Certificate Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Port Number:";
            // 
            // txtPortNumber
            // 
            this.txtPortNumber.Location = new System.Drawing.Point(175, 87);
            this.txtPortNumber.Name = "txtPortNumber";
            this.txtPortNumber.Size = new System.Drawing.Size(97, 22);
            this.txtPortNumber.TabIndex = 6;
            // 
            // txtServerName
            // 
            this.txtServerName.Location = new System.Drawing.Point(175, 118);
            this.txtServerName.Name = "txtServerName";
            this.txtServerName.Size = new System.Drawing.Size(97, 22);
            this.txtServerName.TabIndex = 7;
            // 
            // txtServerCertName
            // 
            this.txtServerCertName.Location = new System.Drawing.Point(175, 150);
            this.txtServerCertName.Name = "txtServerCertName";
            this.txtServerCertName.Size = new System.Drawing.Size(97, 22);
            this.txtServerCertName.TabIndex = 8;
            // 
            // chckName
            // 
            this.chckName.AutoSize = true;
            this.chckName.Location = new System.Drawing.Point(292, 256);
            this.chckName.Name = "chckName";
            this.chckName.Size = new System.Drawing.Size(18, 17);
            this.chckName.TabIndex = 21;
            this.chckName.UseVisualStyleBackColor = true;
            this.chckName.Visible = false;
            this.chckName.CheckedChanged += new System.EventHandler(this.chckName_CheckedChanged);
            // 
            // txtcertName
            // 
            this.txtcertName.Location = new System.Drawing.Point(181, 252);
            this.txtcertName.Name = "txtcertName";
            this.txtcertName.Size = new System.Drawing.Size(91, 22);
            this.txtcertName.TabIndex = 20;
            this.txtcertName.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 256);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 17);
            this.label5.TabIndex = 19;
            this.label5.Text = "Certificate Name:";
            this.label5.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(12, 189);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(260, 57);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Load client certificate from:";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(151, 21);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(63, 21);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Store";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(38, 21);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(51, 21);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "File";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // txtCert
            // 
            this.txtCert.BackColor = System.Drawing.SystemColors.Window;
            this.txtCert.Location = new System.Drawing.Point(181, 252);
            this.txtCert.Name = "txtCert";
            this.txtCert.Size = new System.Drawing.Size(91, 24);
            this.txtCert.TabIndex = 17;
            this.txtCert.Text = "Browse";
            this.txtCert.UseVisualStyleBackColor = false;
            this.txtCert.Visible = false;
            this.txtCert.Click += new System.EventHandler(this.txtCert_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 256);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 17);
            this.label6.TabIndex = 16;
            this.label6.Text = "Load certificate:";
            this.label6.Visible = false;
            // 
            // chckPort
            // 
            this.chckPort.AutoSize = true;
            this.chckPort.Location = new System.Drawing.Point(292, 90);
            this.chckPort.Name = "chckPort";
            this.chckPort.Size = new System.Drawing.Size(18, 17);
            this.chckPort.TabIndex = 22;
            this.chckPort.UseVisualStyleBackColor = true;
            this.chckPort.CheckedChanged += new System.EventHandler(this.chckPort_CheckedChanged);
            // 
            // chckServerName
            // 
            this.chckServerName.AutoSize = true;
            this.chckServerName.Location = new System.Drawing.Point(292, 121);
            this.chckServerName.Name = "chckServerName";
            this.chckServerName.Size = new System.Drawing.Size(18, 17);
            this.chckServerName.TabIndex = 23;
            this.chckServerName.UseVisualStyleBackColor = true;
            this.chckServerName.CheckedChanged += new System.EventHandler(this.chckServerName_CheckedChanged);
            // 
            // chckServerCertName
            // 
            this.chckServerCertName.AutoSize = true;
            this.chckServerCertName.Location = new System.Drawing.Point(292, 153);
            this.chckServerCertName.Name = "chckServerCertName";
            this.chckServerCertName.Size = new System.Drawing.Size(18, 17);
            this.chckServerCertName.TabIndex = 24;
            this.chckServerCertName.UseVisualStyleBackColor = true;
            this.chckServerCertName.CheckedChanged += new System.EventHandler(this.chckServerCertName_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(60, 312);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(166, 17);
            this.label7.TabIndex = 25;
            this.label7.Text = "Send message to server:";
            this.label7.Visible = false;
            // 
            // txtMsgToServer
            // 
            this.txtMsgToServer.Location = new System.Drawing.Point(12, 342);
            this.txtMsgToServer.Name = "txtMsgToServer";
            this.txtMsgToServer.Size = new System.Drawing.Size(298, 22);
            this.txtMsgToServer.TabIndex = 26;
            this.txtMsgToServer.Visible = false;
            this.txtMsgToServer.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtMsgToServer_KeyUp);
            // 
            // btnEndChat
            // 
            this.btnEndChat.Location = new System.Drawing.Point(660, 380);
            this.btnEndChat.Name = "btnEndChat";
            this.btnEndChat.Size = new System.Drawing.Size(93, 30);
            this.btnEndChat.TabIndex = 27;
            this.btnEndChat.Text = "End Client";
            this.btnEndChat.UseVisualStyleBackColor = true;
            this.btnEndChat.Visible = false;
            this.btnEndChat.Click += new System.EventHandler(this.btnEndChat_Click);
            // 
            // frmClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 422);
            this.Controls.Add(this.btnEndChat);
            this.Controls.Add(this.txtMsgToServer);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.chckServerCertName);
            this.Controls.Add(this.chckServerName);
            this.Controls.Add(this.chckPort);
            this.Controls.Add(this.chckName);
            this.Controls.Add(this.txtcertName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtCert);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtServerCertName);
            this.Controls.Add(this.txtServerName);
            this.Controls.Add(this.txtPortNumber);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.displayBox);
            this.Name = "frmClient";
            this.Text = "Client";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox displayBox;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPortNumber;
        private System.Windows.Forms.TextBox txtServerName;
        private System.Windows.Forms.TextBox txtServerCertName;
        private System.Windows.Forms.CheckBox chckName;
        private System.Windows.Forms.TextBox txtcertName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Button txtCert;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox chckPort;
        private System.Windows.Forms.CheckBox chckServerName;
        private System.Windows.Forms.CheckBox chckServerCertName;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox txtMsgToServer;
        private System.Windows.Forms.Button btnEndChat;
    }
}

