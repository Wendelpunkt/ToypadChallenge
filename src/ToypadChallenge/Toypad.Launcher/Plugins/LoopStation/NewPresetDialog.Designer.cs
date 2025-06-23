namespace Toypad.Launcher.Plugins.LoopStation
{
    partial class NewPresetDialog
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
            btnOk = new Button();
            btnCancel = new Button();
            folderBrowserDialog = new FolderBrowserDialog();
            label1 = new Label();
            lblSource = new Label();
            lblFolder = new Label();
            tbName = new TextBox();
            btnBrowse = new Button();
            SuspendLayout();
            // 
            // btnOk
            // 
            btnOk.Enabled = false;
            btnOk.Location = new Point(620, 378);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(150, 46);
            btnOk.TabIndex = 0;
            btnOk.Text = "Ok";
            btnOk.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(451, 378);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(150, 46);
            btnCancel.TabIndex = 1;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 47);
            label1.Name = "label1";
            label1.Size = new Size(78, 32);
            label1.TabIndex = 2;
            label1.Text = "Name";
            // 
            // lblSource
            // 
            lblSource.AutoSize = true;
            lblSource.Location = new Point(34, 116);
            lblSource.Name = "lblSource";
            lblSource.Size = new Size(87, 32);
            lblSource.TabIndex = 3;
            lblSource.Text = "Source";
            // 
            // lblFolder
            // 
            lblFolder.AutoSize = true;
            lblFolder.Location = new Point(146, 116);
            lblFolder.Name = "lblFolder";
            lblFolder.Size = new Size(78, 32);
            lblFolder.TabIndex = 4;
            lblFolder.Text = "label3";
            // 
            // tbName
            // 
            tbName.Location = new Point(128, 44);
            tbName.Name = "tbName";
            tbName.Size = new Size(407, 39);
            tbName.TabIndex = 5;
            // 
            // btnBrowse
            // 
            btnBrowse.Location = new Point(620, 116);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.Size = new Size(150, 46);
            btnBrowse.TabIndex = 6;
            btnBrowse.Text = "...";
            btnBrowse.UseVisualStyleBackColor = true;
            btnBrowse.Click += btnBrowse_Click;
            // 
            // NewPresetDialog
            // 
            AcceptButton = btnOk;
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancel;
            ClientSize = new Size(800, 450);
            Controls.Add(btnBrowse);
            Controls.Add(tbName);
            Controls.Add(lblFolder);
            Controls.Add(lblSource);
            Controls.Add(label1);
            Controls.Add(btnCancel);
            Controls.Add(btnOk);
            Name = "NewPresetDialog";
            Text = "Preset";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnOk;
        private Button btnCancel;
        private FolderBrowserDialog folderBrowserDialog;
        private Label label1;
        private Label lblSource;
        private Button btnBrowse;
        public Label lblFolder;
        public TextBox tbName;
    }
}