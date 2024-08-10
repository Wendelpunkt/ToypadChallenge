namespace ToypadChallenge.Plugins.Visualizer
{
    partial class TagControl
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
            indexLabel = new Label();
            uidLabel = new Label();
            indexContent = new Label();
            uidContent = new Label();
            nameLabel = new Label();
            nameContent = new Label();
            SuspendLayout();
            // 
            // indexLabel
            // 
            indexLabel.AutoSize = true;
            indexLabel.ForeColor = Color.White;
            indexLabel.Location = new Point(10, 10);
            indexLabel.Name = "indexLabel";
            indexLabel.Size = new Size(36, 15);
            indexLabel.TabIndex = 0;
            indexLabel.Text = "Index";
            // 
            // uidLabel
            // 
            uidLabel.AutoSize = true;
            uidLabel.ForeColor = Color.White;
            uidLabel.Location = new Point(10, 30);
            uidLabel.Name = "uidLabel";
            uidLabel.Size = new Size(26, 15);
            uidLabel.TabIndex = 1;
            uidLabel.Text = "UID";
            // 
            // indexContent
            // 
            indexContent.AutoSize = true;
            indexContent.ForeColor = Color.White;
            indexContent.Location = new Point(70, 10);
            indexContent.Name = "indexContent";
            indexContent.Size = new Size(44, 15);
            indexContent.TabIndex = 2;
            indexContent.Text = "[Index]";
            // 
            // uidContent
            // 
            uidContent.AutoSize = true;
            uidContent.ForeColor = Color.White;
            uidContent.Location = new Point(70, 30);
            uidContent.Name = "uidContent";
            uidContent.Size = new Size(34, 15);
            uidContent.TabIndex = 3;
            uidContent.Text = "[UID]";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.ForeColor = Color.White;
            nameLabel.Location = new Point(10, 50);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(39, 15);
            nameLabel.TabIndex = 4;
            nameLabel.Text = "Name";
            // 
            // nameContent
            // 
            nameContent.AutoSize = true;
            nameContent.ForeColor = Color.White;
            nameContent.Location = new Point(70, 50);
            nameContent.Name = "nameContent";
            nameContent.Size = new Size(47, 15);
            nameContent.TabIndex = 5;
            nameContent.Text = "[Name]";
            // 
            // TagControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.MenuHighlight;
            Controls.Add(nameContent);
            Controls.Add(nameLabel);
            Controls.Add(uidContent);
            Controls.Add(indexContent);
            Controls.Add(uidLabel);
            Controls.Add(indexLabel);
            Margin = new Padding(10);
            Name = "TagControl";
            Size = new Size(233, 79);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label indexLabel;
        private Label uidLabel;
        private Label indexContent;
        private Label uidContent;
        private Label nameLabel;
        private Label nameContent;
    }
}
