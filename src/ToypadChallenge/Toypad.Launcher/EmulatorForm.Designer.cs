namespace Toypad.Launcher
{
    partial class EmulatorForm
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
            leftPanel = new Panel();
            rightPanel = new Panel();
            centerPanel = new Panel();
            SuspendLayout();
            // 
            // leftPanel
            // 
            leftPanel.BorderStyle = BorderStyle.FixedSingle;
            leftPanel.Location = new Point(57, 93);
            leftPanel.Name = "leftPanel";
            leftPanel.Size = new Size(102, 218);
            leftPanel.TabIndex = 0;
            // 
            // rightPanel
            // 
            rightPanel.BorderStyle = BorderStyle.FixedSingle;
            rightPanel.Location = new Point(273, 93);
            rightPanel.Name = "rightPanel";
            rightPanel.Size = new Size(102, 218);
            rightPanel.TabIndex = 1;
            // 
            // centerPanel
            // 
            centerPanel.BorderStyle = BorderStyle.FixedSingle;
            centerPanel.Location = new Point(165, 93);
            centerPanel.Name = "centerPanel";
            centerPanel.Size = new Size(102, 109);
            centerPanel.TabIndex = 1;
            // 
            // EmulatorForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(centerPanel);
            Controls.Add(rightPanel);
            Controls.Add(leftPanel);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "EmulatorForm";
            ShowIcon = false;
            ShowInTaskbar = false;
            Text = "Toypad Emulator";
            TopMost = true;
            ResumeLayout(false);
        }

        #endregion

        private Panel leftPanel;
        private Panel rightPanel;
        private Panel centerPanel;
    }
}