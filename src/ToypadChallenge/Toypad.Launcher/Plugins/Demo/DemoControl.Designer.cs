namespace Toypad.Launcher.Plugins.Demo
{
    partial class DemoControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            messageTextBox = new TextBox();
            blinkButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(94, 51);
            label1.Name = "label1";
            label1.Size = new Size(76, 15);
            label1.TabIndex = 0;
            label1.Text = "Demo Plugin";
            // 
            // messageTextBox
            // 
            messageTextBox.Location = new Point(94, 69);
            messageTextBox.Name = "messageTextBox";
            messageTextBox.Size = new Size(204, 23);
            messageTextBox.TabIndex = 1;
            // 
            // blinkButton
            // 
            blinkButton.Location = new Point(118, 170);
            blinkButton.Name = "blinkButton";
            blinkButton.Size = new Size(75, 23);
            blinkButton.TabIndex = 2;
            blinkButton.Text = "Blink!";
            blinkButton.UseVisualStyleBackColor = true;
            blinkButton.Click += blinkButton_Click;
            // 
            // DemoControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(blinkButton);
            Controls.Add(messageTextBox);
            Controls.Add(label1);
            Name = "DemoControl";
            Size = new Size(534, 374);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        public TextBox messageTextBox;
        private Button blinkButton;
    }
}
