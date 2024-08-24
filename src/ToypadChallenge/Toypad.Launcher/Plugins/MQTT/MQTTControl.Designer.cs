namespace Toypad.Launcher.Plugins.MQTT
{
    partial class MQTTControl
    {
        /// <summary> 
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Komponenten-Designer generierter Code

        /// <summary> 
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            lbMQTTHost = new Label();
            tbUID = new TextBox();
            tbMQTTHost = new TextBox();
            tbMQTTPort = new TextBox();
            lbMQTTPort = new Label();
            tbMQTTUsername = new TextBox();
            lbMQTTUsername = new Label();
            tbMQTTPassword = new TextBox();
            lbMQTTPassword = new Label();
            tbMQTTTopic = new TextBox();
            lbMQTTTopic = new Label();
            lbUID = new Label();
            lbMQTTMessageType = new Label();
            cbMessageType = new ComboBox();
            lbInfo = new Label();
            label1 = new Label();
            lbStatus = new Label();
            groupBox1 = new GroupBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // lbMQTTHost
            // 
            lbMQTTHost.Location = new Point(29, 54);
            lbMQTTHost.Name = "lbMQTTHost";
            lbMQTTHost.Size = new Size(113, 23);
            lbMQTTHost.TabIndex = 1;
            lbMQTTHost.Text = "MQTT Host:";
            lbMQTTHost.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tbUID
            // 
            tbUID.Location = new Point(148, 248);
            tbUID.Name = "tbUID";
            tbUID.Size = new Size(292, 23);
            tbUID.TabIndex = 2;
            // 
            // tbMQTTHost
            // 
            tbMQTTHost.Location = new Point(148, 54);
            tbMQTTHost.Name = "tbMQTTHost";
            tbMQTTHost.Size = new Size(292, 23);
            tbMQTTHost.TabIndex = 3;
            // 
            // tbMQTTPort
            // 
            tbMQTTPort.Location = new Point(148, 83);
            tbMQTTPort.Name = "tbMQTTPort";
            tbMQTTPort.Size = new Size(292, 23);
            tbMQTTPort.TabIndex = 5;
            // 
            // lbMQTTPort
            // 
            lbMQTTPort.Location = new Point(29, 83);
            lbMQTTPort.Name = "lbMQTTPort";
            lbMQTTPort.Size = new Size(113, 23);
            lbMQTTPort.TabIndex = 4;
            lbMQTTPort.Text = "MQTT Port:";
            lbMQTTPort.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tbMQTTUsername
            // 
            tbMQTTUsername.Location = new Point(148, 112);
            tbMQTTUsername.Name = "tbMQTTUsername";
            tbMQTTUsername.Size = new Size(292, 23);
            tbMQTTUsername.TabIndex = 7;
            // 
            // lbMQTTUsername
            // 
            lbMQTTUsername.Location = new Point(29, 112);
            lbMQTTUsername.Name = "lbMQTTUsername";
            lbMQTTUsername.Size = new Size(113, 23);
            lbMQTTUsername.TabIndex = 6;
            lbMQTTUsername.Text = "MQTT Username:";
            lbMQTTUsername.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tbMQTTPassword
            // 
            tbMQTTPassword.Location = new Point(148, 141);
            tbMQTTPassword.Name = "tbMQTTPassword";
            tbMQTTPassword.Size = new Size(292, 23);
            tbMQTTPassword.TabIndex = 9;
            // 
            // lbMQTTPassword
            // 
            lbMQTTPassword.Location = new Point(29, 141);
            lbMQTTPassword.Name = "lbMQTTPassword";
            lbMQTTPassword.Size = new Size(113, 23);
            lbMQTTPassword.TabIndex = 8;
            lbMQTTPassword.Text = "MQTT Password:";
            lbMQTTPassword.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tbMQTTTopic
            // 
            tbMQTTTopic.Location = new Point(148, 170);
            tbMQTTTopic.Name = "tbMQTTTopic";
            tbMQTTTopic.Size = new Size(292, 23);
            tbMQTTTopic.TabIndex = 11;
            // 
            // lbMQTTTopic
            // 
            lbMQTTTopic.Location = new Point(29, 170);
            lbMQTTTopic.Name = "lbMQTTTopic";
            lbMQTTTopic.Size = new Size(113, 23);
            lbMQTTTopic.TabIndex = 10;
            lbMQTTTopic.Text = "MQTT Topic:";
            lbMQTTTopic.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lbUID
            // 
            lbUID.Location = new Point(29, 248);
            lbUID.Name = "lbUID";
            lbUID.Size = new Size(113, 23);
            lbUID.TabIndex = 12;
            lbUID.Text = "Last UID:";
            lbUID.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lbMQTTMessageType
            // 
            lbMQTTMessageType.Location = new Point(29, 199);
            lbMQTTMessageType.Name = "lbMQTTMessageType";
            lbMQTTMessageType.Size = new Size(113, 23);
            lbMQTTMessageType.TabIndex = 13;
            lbMQTTMessageType.Text = "Message Type:";
            lbMQTTMessageType.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // cbMessageType
            // 
            cbMessageType.DropDownStyle = ComboBoxStyle.DropDownList;
            cbMessageType.Items.AddRange(new object[] { "Add / Remove JSON", "Only UID when Add" });
            cbMessageType.Location = new Point(148, 199);
            cbMessageType.Name = "cbMessageType";
            cbMessageType.Size = new Size(292, 23);
            cbMessageType.TabIndex = 14;
            // 
            // lbInfo
            // 
            lbInfo.Dock = DockStyle.Fill;
            lbInfo.Location = new Point(3, 19);
            lbInfo.Name = "lbInfo";
            lbInfo.Size = new Size(405, 51);
            lbInfo.TabIndex = 15;
            lbInfo.Text = "MQTT connects automatically after plugin start.\r\nTo change the MQTT Host you need to restart the Toypad-Launcher.";
            // 
            // label1
            // 
            label1.Location = new Point(29, 28);
            label1.Name = "label1";
            label1.Size = new Size(113, 23);
            label1.TabIndex = 16;
            label1.Text = "MQTT Status:";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lbStatus
            // 
            lbStatus.Location = new Point(148, 28);
            lbStatus.Name = "lbStatus";
            lbStatus.Size = new Size(292, 23);
            lbStatus.TabIndex = 17;
            lbStatus.Text = "Disconnected";
            lbStatus.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lbInfo);
            groupBox1.Location = new Point(29, 295);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(411, 73);
            groupBox1.TabIndex = 18;
            groupBox1.TabStop = false;
            groupBox1.Text = "Infobox";
            // 
            // MQTTControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBox1);
            Controls.Add(lbStatus);
            Controls.Add(label1);
            Controls.Add(cbMessageType);
            Controls.Add(lbMQTTMessageType);
            Controls.Add(lbUID);
            Controls.Add(tbMQTTTopic);
            Controls.Add(lbMQTTTopic);
            Controls.Add(tbMQTTPassword);
            Controls.Add(lbMQTTPassword);
            Controls.Add(tbMQTTUsername);
            Controls.Add(lbMQTTUsername);
            Controls.Add(tbMQTTPort);
            Controls.Add(lbMQTTPort);
            Controls.Add(tbMQTTHost);
            Controls.Add(tbUID);
            Controls.Add(lbMQTTHost);
            Name = "MQTTControl";
            Size = new Size(474, 381);
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label lbMQTTHost;
        public TextBox tbUID;
        private Label lbMQTTPort;
        private Label lbMQTTUsername;
        private Label lbMQTTPassword;
        private Label lbMQTTTopic;
        private Label lbUID;
        private Label lbMQTTMessageType;
        public ComboBox cbMessageType;
        public TextBox tbMQTTHost;
        public TextBox tbMQTTPort;
        public TextBox tbMQTTUsername;
        public TextBox tbMQTTPassword;
        public TextBox tbMQTTTopic;
        private Label lbInfo;
        private Label label1;
        private Label lbStatus;
        private GroupBox groupBox1;
    }
}
