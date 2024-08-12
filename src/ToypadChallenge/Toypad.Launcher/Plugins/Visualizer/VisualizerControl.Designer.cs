namespace Toypad.Launcher.Plugins.Visualizer
{
    partial class VisualizerControl
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
            layoutGrid = new TableLayoutPanel();
            leftPanel = new Panel();
            leftFlow = new FlowLayoutPanel();
            centerContainer = new Panel();
            centerPanel = new Panel();
            centerFlow = new FlowLayoutPanel();
            colorPanel = new GroupBox();
            fadeCycleTextbox = new NumericUpDown();
            fadeTimeTextbox = new NumericUpDown();
            flashCyclesTextbox = new NumericUpDown();
            flashOffTextbox = new NumericUpDown();
            flashOnTextbox = new NumericUpDown();
            label2 = new Label();
            label1 = new Label();
            setColorLabel = new Label();
            fadeColorPanel = new Panel();
            flashColorPanel = new Panel();
            padPicker = new ComboBox();
            setColorPanel = new Panel();
            fadeButton = new Button();
            flashButton = new Button();
            setColorButton = new Button();
            rightPanel = new Panel();
            rightFlow = new FlowLayoutPanel();
            colorDialog = new ColorDialog();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            layoutGrid.SuspendLayout();
            leftPanel.SuspendLayout();
            centerContainer.SuspendLayout();
            centerPanel.SuspendLayout();
            colorPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)fadeCycleTextbox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fadeTimeTextbox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)flashCyclesTextbox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)flashOffTextbox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)flashOnTextbox).BeginInit();
            rightPanel.SuspendLayout();
            SuspendLayout();
            // 
            // layoutGrid
            // 
            layoutGrid.ColumnCount = 3;
            layoutGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            layoutGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            layoutGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            layoutGrid.Controls.Add(leftPanel, 0, 0);
            layoutGrid.Controls.Add(centerContainer, 1, 0);
            layoutGrid.Controls.Add(rightPanel, 2, 0);
            layoutGrid.Dock = DockStyle.Fill;
            layoutGrid.Location = new Point(0, 0);
            layoutGrid.Margin = new Padding(0);
            layoutGrid.Name = "layoutGrid";
            layoutGrid.RowCount = 1;
            layoutGrid.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            layoutGrid.Size = new Size(1072, 564);
            layoutGrid.TabIndex = 0;
            // 
            // leftPanel
            // 
            leftPanel.BackColor = SystemColors.ActiveCaption;
            leftPanel.BorderStyle = BorderStyle.FixedSingle;
            leftPanel.Controls.Add(leftFlow);
            leftPanel.Dock = DockStyle.Fill;
            leftPanel.Location = new Point(10, 10);
            leftPanel.Margin = new Padding(10);
            leftPanel.Name = "leftPanel";
            leftPanel.Size = new Size(337, 544);
            leftPanel.TabIndex = 0;
            // 
            // leftFlow
            // 
            leftFlow.Dock = DockStyle.Fill;
            leftFlow.FlowDirection = FlowDirection.TopDown;
            leftFlow.Location = new Point(0, 0);
            leftFlow.Name = "leftFlow";
            leftFlow.Size = new Size(335, 542);
            leftFlow.TabIndex = 0;
            leftFlow.WrapContents = false;
            // 
            // centerContainer
            // 
            centerContainer.BackColor = SystemColors.Control;
            centerContainer.Controls.Add(centerPanel);
            centerContainer.Controls.Add(colorPanel);
            centerContainer.Dock = DockStyle.Fill;
            centerContainer.Location = new Point(367, 10);
            centerContainer.Margin = new Padding(10);
            centerContainer.Name = "centerContainer";
            centerContainer.Size = new Size(337, 544);
            centerContainer.TabIndex = 1;
            // 
            // centerPanel
            // 
            centerPanel.BackColor = SystemColors.ActiveCaption;
            centerPanel.BorderStyle = BorderStyle.FixedSingle;
            centerPanel.Controls.Add(centerFlow);
            centerPanel.Dock = DockStyle.Fill;
            centerPanel.Location = new Point(0, 0);
            centerPanel.Name = "centerPanel";
            centerPanel.Size = new Size(337, 325);
            centerPanel.TabIndex = 0;
            // 
            // centerFlow
            // 
            centerFlow.Dock = DockStyle.Fill;
            centerFlow.FlowDirection = FlowDirection.TopDown;
            centerFlow.Location = new Point(0, 0);
            centerFlow.Name = "centerFlow";
            centerFlow.Size = new Size(335, 323);
            centerFlow.TabIndex = 0;
            centerFlow.WrapContents = false;
            // 
            // colorPanel
            // 
            colorPanel.Controls.Add(label8);
            colorPanel.Controls.Add(label7);
            colorPanel.Controls.Add(label6);
            colorPanel.Controls.Add(label5);
            colorPanel.Controls.Add(label4);
            colorPanel.Controls.Add(label3);
            colorPanel.Controls.Add(fadeCycleTextbox);
            colorPanel.Controls.Add(fadeTimeTextbox);
            colorPanel.Controls.Add(flashCyclesTextbox);
            colorPanel.Controls.Add(flashOffTextbox);
            colorPanel.Controls.Add(flashOnTextbox);
            colorPanel.Controls.Add(label2);
            colorPanel.Controls.Add(label1);
            colorPanel.Controls.Add(setColorLabel);
            colorPanel.Controls.Add(fadeColorPanel);
            colorPanel.Controls.Add(flashColorPanel);
            colorPanel.Controls.Add(padPicker);
            colorPanel.Controls.Add(setColorPanel);
            colorPanel.Controls.Add(fadeButton);
            colorPanel.Controls.Add(flashButton);
            colorPanel.Controls.Add(setColorButton);
            colorPanel.Dock = DockStyle.Bottom;
            colorPanel.Location = new Point(0, 325);
            colorPanel.Name = "colorPanel";
            colorPanel.Size = new Size(337, 219);
            colorPanel.TabIndex = 1;
            colorPanel.TabStop = false;
            colorPanel.Text = "Set color";
            // 
            // fadeCycleTextbox
            // 
            fadeCycleTextbox.Location = new Point(285, 183);
            fadeCycleTextbox.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            fadeCycleTextbox.Name = "fadeCycleTextbox";
            fadeCycleTextbox.Size = new Size(46, 23);
            fadeCycleTextbox.TabIndex = 12;
            fadeCycleTextbox.Value = new decimal(new int[] { 4, 0, 0, 0 });
            // 
            // fadeTimeTextbox
            // 
            fadeTimeTextbox.Location = new Point(285, 154);
            fadeTimeTextbox.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            fadeTimeTextbox.Name = "fadeTimeTextbox";
            fadeTimeTextbox.Size = new Size(46, 23);
            fadeTimeTextbox.TabIndex = 11;
            fadeTimeTextbox.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // flashCyclesTextbox
            // 
            flashCyclesTextbox.Location = new Point(285, 125);
            flashCyclesTextbox.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            flashCyclesTextbox.Name = "flashCyclesTextbox";
            flashCyclesTextbox.Size = new Size(46, 23);
            flashCyclesTextbox.TabIndex = 10;
            flashCyclesTextbox.Value = new decimal(new int[] { 4, 0, 0, 0 });
            // 
            // flashOffTextbox
            // 
            flashOffTextbox.Location = new Point(285, 96);
            flashOffTextbox.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            flashOffTextbox.Name = "flashOffTextbox";
            flashOffTextbox.Size = new Size(46, 23);
            flashOffTextbox.TabIndex = 9;
            flashOffTextbox.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // flashOnTextbox
            // 
            flashOnTextbox.Location = new Point(206, 96);
            flashOnTextbox.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            flashOnTextbox.Name = "flashOnTextbox";
            flashOnTextbox.Size = new Size(46, 23);
            flashOnTextbox.TabIndex = 8;
            flashOnTextbox.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 158);
            label2.Name = "label2";
            label2.Size = new Size(32, 15);
            label2.TabIndex = 7;
            label2.Text = "Fade";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 100);
            label1.Name = "label1";
            label1.Size = new Size(34, 15);
            label1.TabIndex = 6;
            label1.Text = "Flash";
            // 
            // setColorLabel
            // 
            setColorLabel.AutoSize = true;
            setColorLabel.Location = new Point(6, 71);
            setColorLabel.Name = "setColorLabel";
            setColorLabel.Size = new Size(63, 15);
            setColorLabel.TabIndex = 5;
            setColorLabel.Text = "Solid color";
            // 
            // fadeColorPanel
            // 
            fadeColorPanel.BackColor = Color.Black;
            fadeColorPanel.BorderStyle = BorderStyle.FixedSingle;
            fadeColorPanel.Location = new Point(75, 158);
            fadeColorPanel.Name = "fadeColorPanel";
            fadeColorPanel.Size = new Size(16, 16);
            fadeColorPanel.TabIndex = 4;
            fadeColorPanel.Click += fadeColorPanel_Click;
            // 
            // flashColorPanel
            // 
            flashColorPanel.BackColor = Color.Black;
            flashColorPanel.BorderStyle = BorderStyle.FixedSingle;
            flashColorPanel.Location = new Point(75, 100);
            flashColorPanel.Name = "flashColorPanel";
            flashColorPanel.Size = new Size(16, 16);
            flashColorPanel.TabIndex = 4;
            flashColorPanel.Click += flashColorPanel_Click;
            // 
            // padPicker
            // 
            padPicker.DropDownStyle = ComboBoxStyle.DropDownList;
            padPicker.FormattingEnabled = true;
            padPicker.Location = new Point(97, 22);
            padPicker.Name = "padPicker";
            padPicker.Size = new Size(121, 23);
            padPicker.TabIndex = 4;
            // 
            // setColorPanel
            // 
            setColorPanel.BackColor = Color.Black;
            setColorPanel.BorderStyle = BorderStyle.FixedSingle;
            setColorPanel.Location = new Point(75, 71);
            setColorPanel.Name = "setColorPanel";
            setColorPanel.Size = new Size(16, 16);
            setColorPanel.TabIndex = 3;
            setColorPanel.Click += setPanel_Click;
            // 
            // fadeButton
            // 
            fadeButton.Location = new Point(97, 156);
            fadeButton.Name = "fadeButton";
            fadeButton.Size = new Size(75, 23);
            fadeButton.TabIndex = 2;
            fadeButton.Text = "Fade";
            fadeButton.UseVisualStyleBackColor = true;
            fadeButton.Click += fadeButton_Click;
            // 
            // flashButton
            // 
            flashButton.Location = new Point(97, 96);
            flashButton.Name = "flashButton";
            flashButton.Size = new Size(75, 23);
            flashButton.TabIndex = 1;
            flashButton.Text = "Flash";
            flashButton.UseVisualStyleBackColor = true;
            flashButton.Click += flashButton_Click;
            // 
            // setColorButton
            // 
            setColorButton.Location = new Point(97, 67);
            setColorButton.Name = "setColorButton";
            setColorButton.Size = new Size(75, 23);
            setColorButton.TabIndex = 0;
            setColorButton.Text = "Set";
            setColorButton.UseVisualStyleBackColor = true;
            setColorButton.Click += setColorButton_Click;
            // 
            // rightPanel
            // 
            rightPanel.BackColor = SystemColors.ActiveCaption;
            rightPanel.BorderStyle = BorderStyle.FixedSingle;
            rightPanel.Controls.Add(rightFlow);
            rightPanel.Dock = DockStyle.Fill;
            rightPanel.Location = new Point(724, 10);
            rightPanel.Margin = new Padding(10);
            rightPanel.Name = "rightPanel";
            rightPanel.Size = new Size(338, 544);
            rightPanel.TabIndex = 2;
            // 
            // rightFlow
            // 
            rightFlow.Dock = DockStyle.Fill;
            rightFlow.FlowDirection = FlowDirection.TopDown;
            rightFlow.Location = new Point(0, 0);
            rightFlow.Name = "rightFlow";
            rightFlow.Size = new Size(336, 542);
            rightFlow.TabIndex = 0;
            rightFlow.WrapContents = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 25);
            label3.Name = "label3";
            label3.Size = new Size(62, 15);
            label3.TabIndex = 13;
            label3.Text = "Target pad";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(178, 101);
            label4.Name = "label4";
            label4.Size = new Size(23, 15);
            label4.TabIndex = 14;
            label4.Text = "On";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(258, 100);
            label5.Name = "label5";
            label5.Size = new Size(24, 15);
            label5.TabIndex = 15;
            label5.Text = "Off";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(238, 127);
            label6.Name = "label6";
            label6.Size = new Size(41, 15);
            label6.TabIndex = 16;
            label6.Text = "Cycles";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(246, 156);
            label7.Name = "label7";
            label7.Size = new Size(33, 15);
            label7.TabIndex = 17;
            label7.Text = "Time";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(238, 185);
            label8.Name = "label8";
            label8.Size = new Size(41, 15);
            label8.TabIndex = 18;
            label8.Text = "Cycles";
            // 
            // VisualizerControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(layoutGrid);
            Name = "VisualizerControl";
            Size = new Size(1072, 564);
            layoutGrid.ResumeLayout(false);
            leftPanel.ResumeLayout(false);
            centerContainer.ResumeLayout(false);
            centerPanel.ResumeLayout(false);
            colorPanel.ResumeLayout(false);
            colorPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)fadeCycleTextbox).EndInit();
            ((System.ComponentModel.ISupportInitialize)fadeTimeTextbox).EndInit();
            ((System.ComponentModel.ISupportInitialize)flashCyclesTextbox).EndInit();
            ((System.ComponentModel.ISupportInitialize)flashOffTextbox).EndInit();
            ((System.ComponentModel.ISupportInitialize)flashOnTextbox).EndInit();
            rightPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel layoutGrid;
        private Panel leftPanel;
        private Panel centerContainer;
        private Panel rightPanel;
        private FlowLayoutPanel leftFlow;
        private FlowLayoutPanel centerFlow;
        private FlowLayoutPanel rightFlow;
        private Panel centerPanel;
        private GroupBox colorPanel;
        private Button setColorButton;
        private Panel setColorPanel;
        private Button fadeButton;
        private Button flashButton;
        private ColorDialog colorDialog;
        private ComboBox padPicker;
        private Label label2;
        private Label label1;
        private Label setColorLabel;
        private Panel fadeColorPanel;
        private Panel flashColorPanel;
        private NumericUpDown flashCyclesTextbox;
        private NumericUpDown flashOffTextbox;
        private NumericUpDown flashOnTextbox;
        private NumericUpDown fadeCycleTextbox;
        private NumericUpDown fadeTimeTextbox;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
    }
}
