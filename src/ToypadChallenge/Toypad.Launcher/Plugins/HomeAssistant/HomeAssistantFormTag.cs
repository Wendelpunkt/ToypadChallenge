namespace Toypad.Launcher.Plugins.HomeAssistant
{
    public partial class HomeAssistantFormTag : Form
    {
        public HomeAssistantFormTag(HomeAssistantTag tag)
        {
            InitializeComponent();

            if(tag != null)
            {
                tbHomeAssistantEntityName.Text = tag.Entity;
                tbHomeAssistantTagUID.Text = tag.UID;

                if(tag.Type == "Automation")
                {
                    rbAutomation.Checked = true;
                    rbScript.Checked = false;
                }
                else
                {
                    rbAutomation.Checked = false;
                    rbScript.Checked = true;
                }

                pnlLeft.BackColor = tag.Left;
                pnlCenter.BackColor = tag.Center;
                pnlRight.BackColor = tag.Right;

                btnSave.Text = "Edit Tag";
            }
        }

        private void InitializeComponent()
        {
            btnSave = new Button();
            tbHomeAssistantEntityName = new TextBox();
            lbHomeAssistantEntityName = new Label();
            label1 = new Label();
            rbAutomation = new RadioButton();
            rbScript = new RadioButton();
            tbHomeAssistantTagUID = new TextBox();
            lbHomeAssistantTagUID = new Label();
            lbPadColors = new Label();
            colorDialog1 = new ColorDialog();
            pnlLeft = new Panel();
            label3 = new Label();
            panel2 = new Panel();
            label2 = new Label();
            label4 = new Label();
            pnlCenter = new Panel();
            label5 = new Label();
            panel4 = new Panel();
            label6 = new Label();
            pnlRight = new Panel();
            label7 = new Label();
            panel6 = new Panel();
            pnlLeft.SuspendLayout();
            pnlCenter.SuspendLayout();
            pnlRight.SuspendLayout();
            SuspendLayout();
            // 
            // btnSave
            // 
            btnSave.Location = new Point(133, 169);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(292, 23);
            btnSave.TabIndex = 0;
            btnSave.Text = "Add Tag";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // tbHomeAssistantEntityName
            // 
            tbHomeAssistantEntityName.Location = new Point(133, 37);
            tbHomeAssistantEntityName.Name = "tbHomeAssistantEntityName";
            tbHomeAssistantEntityName.Size = new Size(292, 23);
            tbHomeAssistantEntityName.TabIndex = 9;
            // 
            // lbHomeAssistantEntityName
            // 
            lbHomeAssistantEntityName.Location = new Point(14, 37);
            lbHomeAssistantEntityName.Name = "lbHomeAssistantEntityName";
            lbHomeAssistantEntityName.Size = new Size(113, 23);
            lbHomeAssistantEntityName.TabIndex = 8;
            lbHomeAssistantEntityName.Text = "Entity Name:";
            lbHomeAssistantEntityName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            label1.Location = new Point(14, 8);
            label1.Name = "label1";
            label1.Size = new Size(113, 23);
            label1.TabIndex = 10;
            label1.Text = "Entity Type:";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // rbAutomation
            // 
            rbAutomation.AutoSize = true;
            rbAutomation.Checked = true;
            rbAutomation.Location = new Point(133, 12);
            rbAutomation.Name = "rbAutomation";
            rbAutomation.Size = new Size(89, 19);
            rbAutomation.TabIndex = 11;
            rbAutomation.TabStop = true;
            rbAutomation.Text = "Automation";
            rbAutomation.UseVisualStyleBackColor = true;
            // 
            // rbScript
            // 
            rbScript.AutoSize = true;
            rbScript.Location = new Point(245, 12);
            rbScript.Name = "rbScript";
            rbScript.Size = new Size(55, 19);
            rbScript.TabIndex = 12;
            rbScript.Text = "Script";
            rbScript.UseVisualStyleBackColor = true;
            // 
            // tbHomeAssistantTagUID
            // 
            tbHomeAssistantTagUID.Location = new Point(133, 66);
            tbHomeAssistantTagUID.Name = "tbHomeAssistantTagUID";
            tbHomeAssistantTagUID.Size = new Size(292, 23);
            tbHomeAssistantTagUID.TabIndex = 14;
            // 
            // lbHomeAssistantTagUID
            // 
            lbHomeAssistantTagUID.Location = new Point(14, 66);
            lbHomeAssistantTagUID.Name = "lbHomeAssistantTagUID";
            lbHomeAssistantTagUID.Size = new Size(113, 23);
            lbHomeAssistantTagUID.TabIndex = 13;
            lbHomeAssistantTagUID.Text = "Tag UID:";
            lbHomeAssistantTagUID.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lbPadColors
            // 
            lbPadColors.Location = new Point(14, 100);
            lbPadColors.Name = "lbPadColors";
            lbPadColors.Size = new Size(113, 23);
            lbPadColors.TabIndex = 15;
            lbPadColors.Text = "Pad Colors:";
            lbPadColors.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pnlLeft
            // 
            pnlLeft.BorderStyle = BorderStyle.FixedSingle;
            pnlLeft.Controls.Add(label3);
            pnlLeft.Controls.Add(panel2);
            pnlLeft.Cursor = Cursors.Hand;
            pnlLeft.Location = new Point(133, 124);
            pnlLeft.Name = "pnlLeft";
            pnlLeft.Size = new Size(54, 24);
            pnlLeft.TabIndex = 16;
            pnlLeft.Click += pnlLeft_Click;
            // 
            // label3
            // 
            label3.Location = new Point(81, -12);
            label3.Name = "label3";
            label3.Size = new Size(54, 10);
            label3.TabIndex = 19;
            label3.Text = "Left";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            panel2.Location = new Point(81, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(54, 10);
            panel2.TabIndex = 18;
            // 
            // label2
            // 
            label2.Cursor = Cursors.Hand;
            label2.Location = new Point(133, 100);
            label2.Name = "label2";
            label2.Size = new Size(54, 23);
            label2.TabIndex = 17;
            label2.Text = "Left";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            label2.Click += pnlLeft_Click;
            // 
            // label4
            // 
            label4.Cursor = Cursors.Hand;
            label4.Location = new Point(254, 100);
            label4.Name = "label4";
            label4.Size = new Size(54, 23);
            label4.TabIndex = 21;
            label4.Text = "Center";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            label4.Click += pnlCenter_Click;
            // 
            // pnlCenter
            // 
            pnlCenter.BorderStyle = BorderStyle.FixedSingle;
            pnlCenter.Controls.Add(label5);
            pnlCenter.Controls.Add(panel4);
            pnlCenter.Cursor = Cursors.Hand;
            pnlCenter.Location = new Point(254, 124);
            pnlCenter.Name = "pnlCenter";
            pnlCenter.Size = new Size(54, 24);
            pnlCenter.TabIndex = 20;
            pnlCenter.Click += pnlCenter_Click;
            // 
            // label5
            // 
            label5.Location = new Point(81, -12);
            label5.Name = "label5";
            label5.Size = new Size(54, 10);
            label5.TabIndex = 19;
            label5.Text = "Left";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel4
            // 
            panel4.Location = new Point(81, 12);
            panel4.Name = "panel4";
            panel4.Size = new Size(54, 10);
            panel4.TabIndex = 18;
            // 
            // label6
            // 
            label6.Cursor = Cursors.Hand;
            label6.Location = new Point(371, 100);
            label6.Name = "label6";
            label6.Size = new Size(54, 24);
            label6.TabIndex = 23;
            label6.Text = "Right";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            label6.Click += pnlRight_Click;
            // 
            // pnlRight
            // 
            pnlRight.BorderStyle = BorderStyle.FixedSingle;
            pnlRight.Controls.Add(label7);
            pnlRight.Controls.Add(panel6);
            pnlRight.Cursor = Cursors.Hand;
            pnlRight.Location = new Point(371, 124);
            pnlRight.Name = "pnlRight";
            pnlRight.Size = new Size(54, 25);
            pnlRight.TabIndex = 22;
            pnlRight.Click += pnlRight_Click;
            // 
            // label7
            // 
            label7.Location = new Point(81, -12);
            label7.Name = "label7";
            label7.Size = new Size(54, 10);
            label7.TabIndex = 19;
            label7.Text = "Left";
            label7.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel6
            // 
            panel6.Location = new Point(81, 12);
            panel6.Name = "panel6";
            panel6.Size = new Size(54, 10);
            panel6.TabIndex = 18;
            // 
            // HomeAssistantFormTag
            // 
            ClientSize = new Size(441, 207);
            Controls.Add(label6);
            Controls.Add(pnlRight);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(pnlCenter);
            Controls.Add(pnlLeft);
            Controls.Add(lbPadColors);
            Controls.Add(tbHomeAssistantTagUID);
            Controls.Add(lbHomeAssistantTagUID);
            Controls.Add(rbScript);
            Controls.Add(rbAutomation);
            Controls.Add(label1);
            Controls.Add(tbHomeAssistantEntityName);
            Controls.Add(lbHomeAssistantEntityName);
            Controls.Add(btnSave);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "HomeAssistantFormTag";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            TopMost = true;
            Load += HomeAssistantFormTag_Load;
            pnlLeft.ResumeLayout(false);
            pnlCenter.ResumeLayout(false);
            pnlRight.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        private void pnlLeft_Click(object? sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            pnlLeft.BackColor = colorDialog1.Color;
        }

        private void pnlCenter_Click(object? sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            pnlCenter.BackColor = colorDialog1.Color;
        }

        private void pnlRight_Click(object? sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            pnlRight.BackColor = colorDialog1.Color;
        }

        private void HomeAssistantFormTag_Load(object? sender, EventArgs e)
        {
            this.Tag = null;
        }

        private void btnSave_Click(object? sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(tbHomeAssistantEntityName.Text) && !string.IsNullOrWhiteSpace(tbHomeAssistantTagUID.Text))
            {
                var type = rbAutomation.Checked ? "Automation" : "Script";
                this.Tag = new HomeAssistantTag { Type = type, Entity = tbHomeAssistantEntityName.Text, UID = tbHomeAssistantTagUID.Text, Left = pnlLeft.BackColor, Center = pnlCenter.BackColor, Right = pnlRight.BackColor };
            }
            else
            {
                this.Tag = null;
            }

            this.Close();
        }

        public TextBox tbHomeAssistantEntityName;
        private Label lbHomeAssistantEntityName;
        private Label label1;
        private RadioButton rbAutomation;
        private RadioButton rbScript;
        public TextBox tbHomeAssistantTagUID;
        private Label lbHomeAssistantTagUID;
        private Label lbPadColors;
        private ColorDialog colorDialog1;
        private Panel pnlLeft;
        private Label label3;
        private Panel panel2;
        private Label label2;
        private Label label4;
        private Panel pnlCenter;
        private Label label5;
        private Panel panel4;
        private Label label6;
        private Panel pnlRight;
        private Label label7;
        private Panel panel6;
        private Button btnSave;
    }
}
