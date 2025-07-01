namespace Toypad.Launcher.Plugins.LoopStation
{
    partial class EditPresetDialog
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
            lblName = new Label();
            btnOk = new Button();
            btnCancel = new Button();
            tbName = new TextBox();
            listSamples = new ListView();
            colName = new ColumnHeader();
            colFile = new ColumnHeader();
            colToken = new ColumnHeader();
            btnAdd = new Button();
            grpSamples = new GroupBox();
            btnPlay = new Button();
            btnUnlearn = new Button();
            btnLearn = new Button();
            btnRemove = new Button();
            openFileDialog = new OpenFileDialog();
            colDuration = new ColumnHeader();
            grpSamples.SuspendLayout();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(12, 15);
            lblName.Name = "lblName";
            lblName.Size = new Size(78, 32);
            lblName.TabIndex = 0;
            lblName.Text = "Name";
            // 
            // btnOk
            // 
            btnOk.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnOk.DialogResult = DialogResult.OK;
            btnOk.Location = new Point(1019, 805);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(150, 46);
            btnOk.TabIndex = 1;
            btnOk.Text = "OK";
            btnOk.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancel.DialogResult = DialogResult.Cancel;
            btnCancel.Location = new Point(1175, 805);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(150, 46);
            btnCancel.TabIndex = 2;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // tbName
            // 
            tbName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbName.Location = new Point(151, 12);
            tbName.Name = "tbName";
            tbName.Size = new Size(862, 39);
            tbName.TabIndex = 3;
            // 
            // listSamples
            // 
            listSamples.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listSamples.Columns.AddRange(new ColumnHeader[] { colName, colFile, colToken, colDuration });
            listSamples.FullRowSelect = true;
            listSamples.Location = new Point(24, 50);
            listSamples.Name = "listSamples";
            listSamples.Size = new Size(1270, 621);
            listSamples.TabIndex = 4;
            listSamples.UseCompatibleStateImageBehavior = false;
            listSamples.View = View.Details;
            listSamples.SelectedIndexChanged += listSamples_SelectedIndexChanged;
            // 
            // colName
            // 
            colName.Text = "Name";
            colName.Width = 350;
            // 
            // colFile
            // 
            colFile.Text = "File";
            colFile.Width = 500;
            // 
            // colToken
            // 
            colToken.Text = "Token";
            colToken.Width = 140;
            // 
            // btnAdd
            // 
            btnAdd.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnAdd.Location = new Point(1144, 677);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(150, 46);
            btnAdd.TabIndex = 5;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // grpSamples
            // 
            grpSamples.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            grpSamples.Controls.Add(btnPlay);
            grpSamples.Controls.Add(btnUnlearn);
            grpSamples.Controls.Add(btnLearn);
            grpSamples.Controls.Add(btnRemove);
            grpSamples.Controls.Add(listSamples);
            grpSamples.Controls.Add(btnAdd);
            grpSamples.Location = new Point(12, 57);
            grpSamples.Name = "grpSamples";
            grpSamples.Size = new Size(1313, 742);
            grpSamples.TabIndex = 6;
            grpSamples.TabStop = false;
            grpSamples.Text = "Samples";
            // 
            // btnPlay
            // 
            btnPlay.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnPlay.Enabled = false;
            btnPlay.Location = new Point(24, 677);
            btnPlay.Name = "btnPlay";
            btnPlay.Size = new Size(150, 46);
            btnPlay.TabIndex = 9;
            btnPlay.Text = "Play";
            btnPlay.UseVisualStyleBackColor = true;
            btnPlay.Click += btnPlay_Click;
            // 
            // btnUnlearn
            // 
            btnUnlearn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnUnlearn.Enabled = false;
            btnUnlearn.Location = new Point(676, 677);
            btnUnlearn.Name = "btnUnlearn";
            btnUnlearn.Size = new Size(150, 46);
            btnUnlearn.TabIndex = 8;
            btnUnlearn.Text = "Unbind";
            btnUnlearn.UseVisualStyleBackColor = true;
            btnUnlearn.Click += btnUnlearn_Click;
            // 
            // btnLearn
            // 
            btnLearn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnLearn.Enabled = false;
            btnLearn.Location = new Point(832, 677);
            btnLearn.Name = "btnLearn";
            btnLearn.Size = new Size(150, 46);
            btnLearn.TabIndex = 7;
            btnLearn.Text = "Learn";
            btnLearn.UseVisualStyleBackColor = true;
            btnLearn.Click += btnLearn_Click;
            // 
            // btnRemove
            // 
            btnRemove.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnRemove.Enabled = false;
            btnRemove.Location = new Point(988, 677);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(150, 46);
            btnRemove.TabIndex = 6;
            btnRemove.Text = "Remove";
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += btnRemove_Click;
            // 
            // openFileDialog
            // 
            openFileDialog.Filter = "WAV|*.wav";
            openFileDialog.Multiselect = true;
            // 
            // colDuration
            // 
            colDuration.Text = "Duration";
            colDuration.Width = 100;
            // 
            // EditPresetDialog
            // 
            AcceptButton = btnOk;
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancel;
            ClientSize = new Size(1337, 863);
            Controls.Add(grpSamples);
            Controls.Add(tbName);
            Controls.Add(btnCancel);
            Controls.Add(btnOk);
            Controls.Add(lblName);
            Name = "EditPresetDialog";
            ShowIcon = false;
            ShowInTaskbar = false;
            Text = "Edit Preset";
            FormClosing += EditPresetDialog_FormClosing;
            grpSamples.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblName;
        private Button btnOk;
        private Button btnCancel;
        private TextBox tbName;
        private ListView listSamples;
        private Button btnAdd;
        private GroupBox grpSamples;
        private Button btnRemove;
        private ColumnHeader colName;
        private ColumnHeader colFile;
        private ColumnHeader colToken;
        private Button btnLearn;
        private Button btnUnlearn;
        private OpenFileDialog openFileDialog;
        private Button btnPlay;
        private ColumnHeader colDuration;
    }
}