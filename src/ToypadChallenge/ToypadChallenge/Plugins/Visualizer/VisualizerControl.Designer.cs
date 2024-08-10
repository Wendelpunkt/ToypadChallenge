namespace ToypadChallenge.Plugins.Visualizer
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
            centerPanel = new Panel();
            centerFlow = new FlowLayoutPanel();
            rightPanel = new Panel();
            rightFlow = new FlowLayoutPanel();
            layoutGrid.SuspendLayout();
            leftPanel.SuspendLayout();
            centerPanel.SuspendLayout();
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
            layoutGrid.Controls.Add(centerPanel, 1, 0);
            layoutGrid.Controls.Add(rightPanel, 2, 0);
            layoutGrid.Dock = DockStyle.Fill;
            layoutGrid.Location = new Point(0, 0);
            layoutGrid.Margin = new Padding(0);
            layoutGrid.Name = "layoutGrid";
            layoutGrid.RowCount = 1;
            layoutGrid.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            layoutGrid.Size = new Size(1072, 214);
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
            leftPanel.Size = new Size(337, 194);
            leftPanel.TabIndex = 0;
            // 
            // leftFlow
            // 
            leftFlow.Dock = DockStyle.Fill;
            leftFlow.FlowDirection = FlowDirection.TopDown;
            leftFlow.Location = new Point(0, 0);
            leftFlow.Name = "leftFlow";
            leftFlow.Size = new Size(335, 192);
            leftFlow.TabIndex = 0;
            leftFlow.WrapContents = false;
            // 
            // centerPanel
            // 
            centerPanel.BackColor = SystemColors.ActiveCaption;
            centerPanel.BorderStyle = BorderStyle.FixedSingle;
            centerPanel.Controls.Add(centerFlow);
            centerPanel.Dock = DockStyle.Fill;
            centerPanel.Location = new Point(367, 10);
            centerPanel.Margin = new Padding(10);
            centerPanel.Name = "centerPanel";
            centerPanel.Size = new Size(337, 194);
            centerPanel.TabIndex = 1;
            // 
            // centerFlow
            // 
            centerFlow.Dock = DockStyle.Fill;
            centerFlow.FlowDirection = FlowDirection.TopDown;
            centerFlow.Location = new Point(0, 0);
            centerFlow.Name = "centerFlow";
            centerFlow.Size = new Size(335, 192);
            centerFlow.TabIndex = 0;
            centerFlow.WrapContents = false;
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
            rightPanel.Size = new Size(338, 194);
            rightPanel.TabIndex = 2;
            // 
            // rightFlow
            // 
            rightFlow.Dock = DockStyle.Fill;
            rightFlow.FlowDirection = FlowDirection.TopDown;
            rightFlow.Location = new Point(0, 0);
            rightFlow.Name = "rightFlow";
            rightFlow.Size = new Size(336, 192);
            rightFlow.TabIndex = 0;
            rightFlow.WrapContents = false;
            // 
            // VisualizerControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(layoutGrid);
            Name = "VisualizerControl";
            Size = new Size(1072, 214);
            layoutGrid.ResumeLayout(false);
            leftPanel.ResumeLayout(false);
            centerPanel.ResumeLayout(false);
            rightPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel layoutGrid;
        private Panel leftPanel;
        private Panel centerPanel;
        private Panel rightPanel;
        private FlowLayoutPanel leftFlow;
        private FlowLayoutPanel centerFlow;
        private FlowLayoutPanel rightFlow;
    }
}
