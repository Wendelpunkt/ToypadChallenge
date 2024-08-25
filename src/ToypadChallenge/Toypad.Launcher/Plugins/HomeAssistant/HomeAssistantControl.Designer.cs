namespace Toypad.Launcher.Plugins.HomeAssistant
{
    partial class HomeAssistantControl
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
            tbHomeAssistantToken = new TextBox();
            lbHomeAssistantToken = new Label();
            tbHomeAssistantURL = new TextBox();
            lbHomeAssistantURL = new Label();
            lbTags = new ListBox();
            label1 = new Label();
            btnAdd = new Button();
            btnRemove = new Button();
            btnEditTag = new Button();
            SuspendLayout();
            // 
            // tbHomeAssistantToken
            // 
            tbHomeAssistantToken.Location = new Point(147, 57);
            tbHomeAssistantToken.Name = "tbHomeAssistantToken";
            tbHomeAssistantToken.Size = new Size(450, 23);
            tbHomeAssistantToken.TabIndex = 9;
            // 
            // lbHomeAssistantToken
            // 
            lbHomeAssistantToken.Location = new Point(28, 57);
            lbHomeAssistantToken.Name = "lbHomeAssistantToken";
            lbHomeAssistantToken.Size = new Size(113, 23);
            lbHomeAssistantToken.TabIndex = 8;
            lbHomeAssistantToken.Text = "Home Assis. Token:";
            lbHomeAssistantToken.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tbHomeAssistantURL
            // 
            tbHomeAssistantURL.Location = new Point(147, 28);
            tbHomeAssistantURL.Name = "tbHomeAssistantURL";
            tbHomeAssistantURL.Size = new Size(450, 23);
            tbHomeAssistantURL.TabIndex = 7;
            // 
            // lbHomeAssistantURL
            // 
            lbHomeAssistantURL.Location = new Point(28, 28);
            lbHomeAssistantURL.Name = "lbHomeAssistantURL";
            lbHomeAssistantURL.Size = new Size(113, 23);
            lbHomeAssistantURL.TabIndex = 6;
            lbHomeAssistantURL.Text = "Home Assis. URL:";
            lbHomeAssistantURL.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lbTags
            // 
            lbTags.FormattingEnabled = true;
            lbTags.ItemHeight = 15;
            lbTags.Location = new Point(147, 101);
            lbTags.Name = "lbTags";
            lbTags.Size = new Size(450, 169);
            lbTags.TabIndex = 10;
            // 
            // label1
            // 
            label1.Location = new Point(28, 101);
            label1.Name = "label1";
            label1.Size = new Size(113, 23);
            label1.TabIndex = 11;
            label1.Text = "Saved Tags:";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(147, 276);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(264, 23);
            btnAdd.TabIndex = 12;
            btnAdd.Text = "Add Tag";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnRemove
            // 
            btnRemove.Location = new Point(510, 276);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(87, 23);
            btnRemove.TabIndex = 13;
            btnRemove.Text = "Remove Tag";
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += btnRemove_Click;
            // 
            // btnEditTag
            // 
            btnEditTag.Location = new Point(417, 276);
            btnEditTag.Name = "btnEditTag";
            btnEditTag.Size = new Size(87, 23);
            btnEditTag.TabIndex = 14;
            btnEditTag.Text = "Edit Tag";
            btnEditTag.UseVisualStyleBackColor = true;
            btnEditTag.Click += btnEditTag_Click;
            // 
            // HomeAssistantControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnEditTag);
            Controls.Add(btnRemove);
            Controls.Add(btnAdd);
            Controls.Add(label1);
            Controls.Add(lbTags);
            Controls.Add(tbHomeAssistantToken);
            Controls.Add(lbHomeAssistantToken);
            Controls.Add(tbHomeAssistantURL);
            Controls.Add(lbHomeAssistantURL);
            Name = "HomeAssistantControl";
            Size = new Size(624, 321);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public TextBox tbHomeAssistantToken;
        private Label lbHomeAssistantToken;
        public TextBox tbHomeAssistantURL;
        private Label lbHomeAssistantURL;
        private ListBox lbTags;
        private Label label1;
        private Button btnAdd;
        private Button btnRemove;
        private Button btnEditTag;
    }
}
