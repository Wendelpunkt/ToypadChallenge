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
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(520, 86);
            button1.Name = "button1";
            button1.Size = new Size(150, 46);
            button1.TabIndex = 0;
            button1.Text = "Play";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(689, 86);
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
            cmbPresets.Location = new Point(163, 224);
            cmbPresets.Name = "cmbPresets";
            cmbPresets.Size = new Size(242, 40);
            cmbPresets.TabIndex = 2;
            cmbPresets.SelectedIndexChanged += cmbPresets_SelectedIndexChanged;
            // 
            // btnNewPreset
            // 
            btnNewPreset.Location = new Point(420, 220);
            btnNewPreset.Name = "btnNewPreset";
            btnNewPreset.Size = new Size(150, 46);
            btnNewPreset.TabIndex = 3;
            btnNewPreset.Text = "New";
            btnNewPreset.UseVisualStyleBackColor = true;
            btnNewPreset.Click += btnNewPreset_Click;
            // 
            // btnDeletePreset
            // 
            btnDeletePreset.Enabled = false;
            btnDeletePreset.Location = new Point(587, 220);
            btnDeletePreset.Name = "btnDeletePreset";
            btnDeletePreset.Size = new Size(150, 46);
            btnDeletePreset.TabIndex = 4;
            btnDeletePreset.Text = "Delete";
            btnDeletePreset.UseVisualStyleBackColor = true;
            // 
            // LoopStationControl
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnDeletePreset);
            Controls.Add(btnNewPreset);
            Controls.Add(cmbPresets);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "LoopStationControl";
            Size = new Size(1404, 804);
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private ComboBox cmbPresets;
        private Button btnNewPreset;
        private Button btnDeletePreset;
    }
}
