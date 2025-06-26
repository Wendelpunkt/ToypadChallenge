namespace Toypad.Launcher.Plugins.LoopStation
{
    partial class LoopStationControl
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
            btnPlay = new Button();
            cmbPresets = new ComboBox();
            btnNewPreset = new Button();
            btnDeletePreset = new Button();
            btnEditPreset = new Button();
            lblPreset = new Label();
            listTracks = new ListView();
            SuspendLayout();
            // 
            // btnPlay
            // 
            btnPlay.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnPlay.Location = new Point(689, 8);
            btnPlay.Margin = new Padding(2, 1, 2, 1);
            btnPlay.Name = "btnPlay";
            btnPlay.Size = new Size(64, 22);
            btnPlay.TabIndex = 0;
            btnPlay.Text = "Play";
            btnPlay.UseVisualStyleBackColor = true;
            btnPlay.Click += btnPlay_Click;
            // 
            // cmbPresets
            // 
            cmbPresets.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPresets.FormattingEnabled = true;
            cmbPresets.Location = new Point(61, 9);
            cmbPresets.Margin = new Padding(2, 1, 2, 1);
            cmbPresets.Name = "cmbPresets";
            cmbPresets.Size = new Size(200, 23);
            cmbPresets.TabIndex = 2;
            cmbPresets.SelectedIndexChanged += cmbPresets_SelectedIndexChanged;
            // 
            // btnNewPreset
            // 
            btnNewPreset.Location = new Point(268, 8);
            btnNewPreset.Margin = new Padding(2, 1, 2, 1);
            btnNewPreset.Name = "btnNewPreset";
            btnNewPreset.Size = new Size(55, 22);
            btnNewPreset.TabIndex = 3;
            btnNewPreset.Text = "New";
            btnNewPreset.UseVisualStyleBackColor = true;
            btnNewPreset.Click += btnNewPreset_Click;
            // 
            // btnDeletePreset
            // 
            btnDeletePreset.Enabled = false;
            btnDeletePreset.Location = new Point(398, 8);
            btnDeletePreset.Margin = new Padding(2, 1, 2, 1);
            btnDeletePreset.Name = "btnDeletePreset";
            btnDeletePreset.Size = new Size(71, 22);
            btnDeletePreset.TabIndex = 4;
            btnDeletePreset.Text = "Delete";
            btnDeletePreset.UseVisualStyleBackColor = true;
            btnDeletePreset.Click += btnDeletePreset_Click;
            // 
            // btnEditPreset
            // 
            btnEditPreset.Enabled = false;
            btnEditPreset.Location = new Point(326, 8);
            btnEditPreset.Margin = new Padding(2, 1, 2, 1);
            btnEditPreset.Name = "btnEditPreset";
            btnEditPreset.Size = new Size(69, 22);
            btnEditPreset.TabIndex = 5;
            btnEditPreset.Text = "Edit";
            btnEditPreset.UseVisualStyleBackColor = true;
            btnEditPreset.Click += btnEditPreset_Click;
            // 
            // lblPreset
            // 
            lblPreset.AutoSize = true;
            lblPreset.Location = new Point(16, 11);
            lblPreset.Margin = new Padding(2, 0, 2, 0);
            lblPreset.Name = "lblPreset";
            lblPreset.Size = new Size(39, 15);
            lblPreset.TabIndex = 6;
            lblPreset.Text = "Preset";
            // 
            // listTracks
            // 
            listTracks.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listTracks.Location = new Point(3, 37);
            listTracks.MultiSelect = false;
            listTracks.Name = "listTracks";
            listTracks.Size = new Size(750, 337);
            listTracks.TabIndex = 1;
            listTracks.UseCompatibleStateImageBehavior = false;
            listTracks.View = View.List;
            // 
            // LoopStationControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(listTracks);
            Controls.Add(btnPlay);
            Controls.Add(lblPreset);
            Controls.Add(btnEditPreset);
            Controls.Add(btnDeletePreset);
            Controls.Add(btnNewPreset);
            Controls.Add(cmbPresets);
            Margin = new Padding(2, 1, 2, 1);
            Name = "LoopStationControl";
            Size = new Size(756, 377);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnPlay;
        private ComboBox cmbPresets;
        private Button btnNewPreset;
        private Button btnDeletePreset;
        private Button btnEditPreset;
        private Label lblPreset;
        private ListView listTracks;
    }
}
