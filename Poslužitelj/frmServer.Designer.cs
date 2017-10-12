namespace Poslužitelj
{
    partial class frmServer
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmServer));
            this.displayBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPortNumber = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.ClientValidation = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCert = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.txtcertName = new System.Windows.Forms.TextBox();
            this.chckPort = new System.Windows.Forms.CheckBox();
            this.chckName = new System.Windows.Forms.CheckBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // displayBox
            // 
            this.displayBox.BackColor = System.Drawing.SystemColors.Window;
            this.displayBox.Location = new System.Drawing.Point(340, 12);
            this.displayBox.Multiline = true;
            this.displayBox.Name = "displayBox";
            this.displayBox.ReadOnly = true;
            this.displayBox.Size = new System.Drawing.Size(527, 358);
            this.displayBox.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(126, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Web Server";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Port Number:";
            // 
            // txtPortNumber
            // 
            this.txtPortNumber.Location = new System.Drawing.Point(184, 72);
            this.txtPortNumber.Name = "txtPortNumber";
            this.txtPortNumber.Size = new System.Drawing.Size(97, 22);
            this.txtPortNumber.TabIndex = 1;
            this.toolTip1.SetToolTip(this.txtPortNumber, resources.GetString("txtPortNumber.ToolTip"));
            this.txtPortNumber.Click += new System.EventHandler(this.TxtPortNumber_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(774, 380);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(93, 30);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "Start Server";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // ClientValidation
            // 
            this.ClientValidation.DisplayMember = "0";
            this.ClientValidation.FormattingEnabled = true;
            this.ClientValidation.Items.AddRange(new object[] {
            "No",
            "Yes"});
            this.ClientValidation.Location = new System.Drawing.Point(184, 108);
            this.ClientValidation.Name = "ClientValidation";
            this.ClientValidation.Size = new System.Drawing.Size(97, 24);
            this.ClientValidation.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Client Validation:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Load certificate:";
            this.label4.Visible = false;
            // 
            // txtCert
            // 
            this.txtCert.BackColor = System.Drawing.SystemColors.Window;
            this.txtCert.Location = new System.Drawing.Point(184, 217);
            this.txtCert.Name = "txtCert";
            this.txtCert.Size = new System.Drawing.Size(97, 24);
            this.txtCert.TabIndex = 10;
            this.txtCert.Text = "Browse";
            this.txtCert.UseVisualStyleBackColor = false;
            this.txtCert.Visible = false;
            this.txtCert.Click += new System.EventHandler(this.TxtCert_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(15, 154);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(266, 57);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Load server certificate from:";
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
            this.radioButton2.CheckedChanged += new System.EventHandler(this.RadioButton2_CheckedChanged);
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
            this.radioButton1.CheckedChanged += new System.EventHandler(this.RadioButton1_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 221);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Certificate Name:";
            this.label5.Visible = false;
            // 
            // txtcertName
            // 
            this.txtcertName.Location = new System.Drawing.Point(184, 217);
            this.txtcertName.Name = "txtcertName";
            this.txtcertName.Size = new System.Drawing.Size(97, 22);
            this.txtcertName.TabIndex = 13;
            this.toolTip1.SetToolTip(this.txtcertName, "Enter the name of the server certificate that will be sent to the client for veri" +
        "fication.\r\nCertificate format must be *.cer, postfix must be included in the nam" +
        "e\r\n(example:  certificateName.cer)\r\n");
            this.txtcertName.Visible = false;
            this.txtcertName.Click += new System.EventHandler(this.txtcertName_Click);
            // 
            // chckPort
            // 
            this.chckPort.AutoSize = true;
            this.chckPort.Location = new System.Drawing.Point(297, 76);
            this.chckPort.Name = "chckPort";
            this.chckPort.Size = new System.Drawing.Size(18, 17);
            this.chckPort.TabIndex = 14;
            this.chckPort.UseVisualStyleBackColor = true;
            this.chckPort.CheckedChanged += new System.EventHandler(this.ChckPort_CheckedChanged);
            // 
            // chckName
            // 
            this.chckName.AutoSize = true;
            this.chckName.Location = new System.Drawing.Point(297, 220);
            this.chckName.Name = "chckName";
            this.chckName.Size = new System.Drawing.Size(18, 17);
            this.chckName.TabIndex = 15;
            this.chckName.UseVisualStyleBackColor = true;
            this.chckName.Visible = false;
            this.chckName.CheckedChanged += new System.EventHandler(this.ChckName_CheckedChanged);
            // 
            // frmServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 422);
            this.Controls.Add(this.chckName);
            this.Controls.Add(this.chckPort);
            this.Controls.Add(this.txtcertName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtCert);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ClientValidation);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.txtPortNumber);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.displayBox);
            this.Name = "frmServer";
            this.Text = "Server";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox displayBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPortNumber;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.ComboBox ClientValidation;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button txtCert;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtcertName;
        private System.Windows.Forms.CheckBox chckPort;
        private System.Windows.Forms.CheckBox chckName;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

