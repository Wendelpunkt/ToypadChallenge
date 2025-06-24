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
            btnClean = new Button();
            SuspendLayout();
            // 
            // btnOk
            // 
            btnOk.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnOk.DialogResult = DialogResult.OK;
            btnOk.Location = new Point(597, 128);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(150, 46);
            btnOk.TabIndex = 0;
            btnOk.Text = "Ok";
            btnOk.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancel.DialogResult = DialogResult.Cancel;
            btnCancel.Location = new Point(441, 128);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(150, 46);
            btnCancel.TabIndex = 1;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 15);
            label1.Name = "label1";
            label1.Size = new Size(78, 32);
            label1.TabIndex = 2;
            label1.Text = "Name";
            // 
            // lblSource
            // 
            lblSource.AutoSize = true;
            lblSource.Location = new Point(12, 64);
            lblSource.Name = "lblSource";
            lblSource.Size = new Size(85, 32);
            lblSource.TabIndex = 3;
            lblSource.Text = "Import";
            // 
            // lblFolder
            // 
            lblFolder.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblFolder.Enabled = false;
            lblFolder.Location = new Point(114, 64);
            lblFolder.Name = "lblFolder";
            lblFolder.Size = new Size(477, 32);
            lblFolder.TabIndex = 4;
            lblFolder.Text = "No import";
            // 
            // tbName
            // 
            tbName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbName.Location = new Point(114, 12);
            tbName.Name = "tbName";
            tbName.Size = new Size(633, 39);
            tbName.TabIndex = 5;
            tbName.Text = "New Preset";
            tbName.TextChanged += tbName_TextChanged;
            // 
            // btnBrowse
            // 
            btnBrowse.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnBrowse.Location = new Point(601, 57);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.Size = new Size(70, 46);
            btnBrowse.TabIndex = 6;
            btnBrowse.Text = "...";
            btnBrowse.UseVisualStyleBackColor = true;
            btnBrowse.Click += btnBrowse_Click;
            // 
            // btnClean
            // 
            btnClean.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClean.Enabled = false;
            btnClean.Location = new Point(677, 57);
            btnClean.Name = "btnClean";
            btnClean.Size = new Size(70, 46);
            btnClean.TabIndex = 7;
            btnClean.Text = "X";
            btnClean.UseVisualStyleBackColor = true;
            btnClean.Click += btnClean_Click;
            // 
            // NewPresetDialog
            // 
            AcceptButton = btnOk;
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancel;
            ClientSize = new Size(759, 186);
            Controls.Add(btnClean);
            Controls.Add(btnBrowse);
            Controls.Add(tbName);
            Controls.Add(lblFolder);
            Controls.Add(lblSource);
            Controls.Add(label1);
            Controls.Add(btnCancel);
            Controls.Add(btnOk);
            Name = "NewPresetDialog";
            ShowIcon = false;
            ShowInTaskbar = false;
            Text = "New Preset";
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
        private Button btnClean;
    }
}