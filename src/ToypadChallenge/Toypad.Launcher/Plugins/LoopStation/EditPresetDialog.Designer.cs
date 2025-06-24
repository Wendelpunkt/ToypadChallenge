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
            btnAdd = new Button();
            grpSamples = new GroupBox();
            btnRemove = new Button();
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
            listSamples.Location = new Point(24, 50);
            listSamples.Name = "listSamples";
            listSamples.Size = new Size(1270, 621);
            listSamples.TabIndex = 4;
            listSamples.UseCompatibleStateImageBehavior = false;
            listSamples.View = View.List;
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
            // 
            // grpSamples
            // 
            grpSamples.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
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
            // btnRemove
            // 
            btnRemove.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnRemove.Location = new Point(988, 677);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(150, 46);
            btnRemove.TabIndex = 6;
            btnRemove.Text = "Remove";
            btnRemove.UseVisualStyleBackColor = true;
            // 
            // EditPresetDialog
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
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
    }
}