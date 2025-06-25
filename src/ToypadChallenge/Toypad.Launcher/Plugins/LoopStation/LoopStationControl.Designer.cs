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
            button1 = new Button();
            button2 = new Button();
            cmbPresets = new ComboBox();
            btnNewPreset = new Button();
            btnDeletePreset = new Button();
            btnEditPreset = new Button();
            lblPreset = new Label();
            grpPlayer = new GroupBox();
            grpPlayer.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(243, 62);
            button1.Name = "button1";
            button1.Size = new Size(150, 46);
            button1.TabIndex = 0;
            button1.Text = "Play";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(399, 62);
            button2.Name = "button2";
            button2.Size = new Size(150, 46);
            button2.TabIndex = 1;
            button2.Text = "Stop";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // cmbPresets
            // 
            cmbPresets.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPresets.FormattingEnabled = true;
            cmbPresets.Location = new Point(114, 20);
            cmbPresets.Name = "cmbPresets";
            cmbPresets.Size = new Size(368, 40);
            cmbPresets.TabIndex = 2;
            cmbPresets.SelectedIndexChanged += cmbPresets_SelectedIndexChanged;
            // 
            // btnNewPreset
            // 
            btnNewPreset.Location = new Point(497, 16);
            btnNewPreset.Name = "btnNewPreset";
            btnNewPreset.Size = new Size(103, 46);
            btnNewPreset.TabIndex = 3;
            btnNewPreset.Text = "New";
            btnNewPreset.UseVisualStyleBackColor = true;
            btnNewPreset.Click += btnNewPreset_Click;
            // 
            // btnDeletePreset
            // 
            btnDeletePreset.Enabled = false;
            btnDeletePreset.Location = new Point(740, 16);
            btnDeletePreset.Name = "btnDeletePreset";
            btnDeletePreset.Size = new Size(131, 46);
            btnDeletePreset.TabIndex = 4;
            btnDeletePreset.Text = "Delete";
            btnDeletePreset.UseVisualStyleBackColor = true;
            btnDeletePreset.Click += btnDeletePreset_Click;
            // 
            // btnEditPreset
            // 
            btnEditPreset.Enabled = false;
            btnEditPreset.Location = new Point(606, 16);
            btnEditPreset.Name = "btnEditPreset";
            btnEditPreset.Size = new Size(128, 46);
            btnEditPreset.TabIndex = 5;
            btnEditPreset.Text = "Edit";
            btnEditPreset.UseVisualStyleBackColor = true;
            btnEditPreset.Click += btnEditPreset_Click;
            // 
            // lblPreset
            // 
            lblPreset.AutoSize = true;
            lblPreset.Location = new Point(29, 23);
            lblPreset.Name = "lblPreset";
            lblPreset.Size = new Size(79, 32);
            lblPreset.TabIndex = 6;
            lblPreset.Text = "Preset";
            // 
            // grpPlayer
            // 
            grpPlayer.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            grpPlayer.Controls.Add(button1);
            grpPlayer.Controls.Add(button2);
            grpPlayer.Location = new Point(3, 77);
            grpPlayer.Name = "grpPlayer";
            grpPlayer.Size = new Size(1398, 724);
            grpPlayer.TabIndex = 7;
            grpPlayer.TabStop = false;
            grpPlayer.Text = "Player";
            // 
            // LoopStationControl
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(grpPlayer);
            Controls.Add(lblPreset);
            Controls.Add(btnEditPreset);
            Controls.Add(btnDeletePreset);
            Controls.Add(btnNewPreset);
            Controls.Add(cmbPresets);
            Name = "LoopStationControl";
            Size = new Size(1404, 804);
            grpPlayer.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private ComboBox cmbPresets;
        private Button btnNewPreset;
        private Button btnDeletePreset;
        private Button btnEditPreset;
        private Label lblPreset;
        private GroupBox grpPlayer;
    }
}
