namespace Toypad.Launcher.Emulator
{
    partial class EmulatorForm
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
            leftPanel = new Panel();
            leftFlow = new FlowLayoutPanel();
            rightPanel = new Panel();
            rightFlow = new FlowLayoutPanel();
            centerPanel = new Panel();
            centerFlow = new FlowLayoutPanel();
            toypadPanel = new Panel();
            tagFlow = new FlowLayoutPanel();
            uidTextbox = new TextBox();
            uidLabel = new Label();
            addButton = new Button();
            randomButton = new Button();
            binPanel = new Panel();
            nameTextbox = new TextBox();
            nameLabel = new Label();
            addTagGroupBox = new GroupBox();
            trashLabel = new Label();
            leftPanel.SuspendLayout();
            rightPanel.SuspendLayout();
            centerPanel.SuspendLayout();
            toypadPanel.SuspendLayout();
            binPanel.SuspendLayout();
            addTagGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // leftPanel
            // 
            leftPanel.BackColor = Color.White;
            leftPanel.BorderStyle = BorderStyle.FixedSingle;
            leftPanel.Controls.Add(leftFlow);
            leftPanel.Location = new Point(3, 101);
            leftPanel.Name = "leftPanel";
            leftPanel.Size = new Size(120, 157);
            leftPanel.TabIndex = 0;
            // 
            // leftFlow
            // 
            leftFlow.AllowDrop = true;
            leftFlow.Dock = DockStyle.Fill;
            leftFlow.Location = new Point(0, 0);
            leftFlow.Name = "leftFlow";
            leftFlow.Size = new Size(118, 155);
            leftFlow.TabIndex = 0;
            leftFlow.DragDrop += leftFlow_DragDrop;
            leftFlow.DragEnter += panel_DragEnter;
            // 
            // rightPanel
            // 
            rightPanel.BackColor = Color.White;
            rightPanel.BorderStyle = BorderStyle.FixedSingle;
            rightPanel.Controls.Add(rightFlow);
            rightPanel.Location = new Point(273, 102);
            rightPanel.Name = "rightPanel";
            rightPanel.Size = new Size(120, 156);
            rightPanel.TabIndex = 1;
            // 
            // rightFlow
            // 
            rightFlow.AllowDrop = true;
            rightFlow.Dock = DockStyle.Fill;
            rightFlow.Location = new Point(0, 0);
            rightFlow.Name = "rightFlow";
            rightFlow.Size = new Size(118, 154);
            rightFlow.TabIndex = 0;
            rightFlow.DragDrop += rightFlow_DragDrop;
            rightFlow.DragEnter += panel_DragEnter;
            // 
            // centerPanel
            // 
            centerPanel.BackColor = Color.White;
            centerPanel.BorderStyle = BorderStyle.FixedSingle;
            centerPanel.Controls.Add(centerFlow);
            centerPanel.Location = new Point(138, 42);
            centerPanel.Name = "centerPanel";
            centerPanel.Size = new Size(120, 109);
            centerPanel.TabIndex = 1;
            // 
            // centerFlow
            // 
            centerFlow.AllowDrop = true;
            centerFlow.Dock = DockStyle.Fill;
            centerFlow.Location = new Point(0, 0);
            centerFlow.Name = "centerFlow";
            centerFlow.Size = new Size(118, 107);
            centerFlow.TabIndex = 0;
            centerFlow.DragDrop += centerFlow_DragDrop;
            centerFlow.DragEnter += panel_DragEnter;
            // 
            // toypadPanel
            // 
            toypadPanel.BackColor = SystemColors.ControlDark;
            toypadPanel.BorderStyle = BorderStyle.FixedSingle;
            toypadPanel.Controls.Add(leftPanel);
            toypadPanel.Controls.Add(centerPanel);
            toypadPanel.Controls.Add(rightPanel);
            toypadPanel.Location = new Point(12, 12);
            toypadPanel.Name = "toypadPanel";
            toypadPanel.Size = new Size(398, 265);
            toypadPanel.TabIndex = 2;
            toypadPanel.Paint += toypadPanel_Paint;
            // 
            // tagFlow
            // 
            tagFlow.AllowDrop = true;
            tagFlow.AutoScroll = true;
            tagFlow.BackColor = Color.White;
            tagFlow.BorderStyle = BorderStyle.FixedSingle;
            tagFlow.Location = new Point(499, 12);
            tagFlow.Name = "tagFlow";
            tagFlow.Size = new Size(289, 426);
            tagFlow.TabIndex = 3;
            tagFlow.DragDrop += tagFlow_DragDrop;
            tagFlow.DragEnter += panel_DragEnter;
            // 
            // uidTextbox
            // 
            uidTextbox.Location = new Point(50, 28);
            uidTextbox.Name = "uidTextbox";
            uidTextbox.Size = new Size(208, 23);
            uidTextbox.TabIndex = 4;
            // 
            // uidLabel
            // 
            uidLabel.AutoSize = true;
            uidLabel.Location = new Point(6, 31);
            uidLabel.Name = "uidLabel";
            uidLabel.Size = new Size(26, 15);
            uidLabel.TabIndex = 5;
            uidLabel.Text = "UID";
            // 
            // addButton
            // 
            addButton.Location = new Point(264, 86);
            addButton.Name = "addButton";
            addButton.Size = new Size(75, 23);
            addButton.TabIndex = 6;
            addButton.Text = "Add";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // randomButton
            // 
            randomButton.Location = new Point(264, 27);
            randomButton.Name = "randomButton";
            randomButton.Size = new Size(75, 23);
            randomButton.TabIndex = 7;
            randomButton.Text = "Random";
            randomButton.UseVisualStyleBackColor = true;
            randomButton.Click += randomButton_Click;
            // 
            // binPanel
            // 
            binPanel.AllowDrop = true;
            binPanel.BackColor = Color.Maroon;
            binPanel.Controls.Add(trashLabel);
            binPanel.Location = new Point(426, 161);
            binPanel.Name = "binPanel";
            binPanel.Size = new Size(63, 63);
            binPanel.TabIndex = 8;
            binPanel.DragDrop += binPanel_DragDrop;
            binPanel.DragEnter += panel_DragEnter;
            // 
            // nameTextbox
            // 
            nameTextbox.Location = new Point(50, 57);
            nameTextbox.Name = "nameTextbox";
            nameTextbox.Size = new Size(267, 23);
            nameTextbox.TabIndex = 9;
            nameTextbox.Text = "Unknown";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new Point(6, 60);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(39, 15);
            nameLabel.TabIndex = 10;
            nameLabel.Text = "Name";
            // 
            // addTagGroupBox
            // 
            addTagGroupBox.Controls.Add(uidLabel);
            addTagGroupBox.Controls.Add(nameLabel);
            addTagGroupBox.Controls.Add(uidTextbox);
            addTagGroupBox.Controls.Add(nameTextbox);
            addTagGroupBox.Controls.Add(addButton);
            addTagGroupBox.Controls.Add(randomButton);
            addTagGroupBox.Location = new Point(34, 302);
            addTagGroupBox.Name = "addTagGroupBox";
            addTagGroupBox.Size = new Size(359, 122);
            addTagGroupBox.TabIndex = 11;
            addTagGroupBox.TabStop = false;
            addTagGroupBox.Text = "Add new tag";
            // 
            // trashLabel
            // 
            trashLabel.AutoSize = true;
            trashLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            trashLabel.ForeColor = Color.White;
            trashLabel.Location = new Point(6, 13);
            trashLabel.Name = "trashLabel";
            trashLabel.Size = new Size(54, 37);
            trashLabel.TabIndex = 0;
            trashLabel.Text = "🗑";
            // 
            // EmulatorForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(addTagGroupBox);
            Controls.Add(binPanel);
            Controls.Add(tagFlow);
            Controls.Add(toypadPanel);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "EmulatorForm";
            ShowIcon = false;
            ShowInTaskbar = false;
            Text = "Toypad Emulator";
            TopMost = true;
            leftPanel.ResumeLayout(false);
            rightPanel.ResumeLayout(false);
            centerPanel.ResumeLayout(false);
            toypadPanel.ResumeLayout(false);
            binPanel.ResumeLayout(false);
            binPanel.PerformLayout();
            addTagGroupBox.ResumeLayout(false);
            addTagGroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel leftPanel;
        private Panel rightPanel;
        private Panel centerPanel;
        private Panel toypadPanel;
        private FlowLayoutPanel leftFlow;
        private FlowLayoutPanel rightFlow;
        private FlowLayoutPanel centerFlow;
        private FlowLayoutPanel tagFlow;
        private TextBox uidTextbox;
        private Label uidLabel;
        private Button addButton;
        private Button randomButton;
        private Panel binPanel;
        private TextBox nameTextbox;
        private Label nameLabel;
        private GroupBox addTagGroupBox;
        private Label trashLabel;
    }
}