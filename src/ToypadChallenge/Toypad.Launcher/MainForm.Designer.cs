namespace ToypadChallenge
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            mainMenu = new MenuStrip();
            programToolStripMenuItem = new ToolStripMenuItem();
            pluginItem = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripSeparator();
            closeToolStripMenuItem = new ToolStripMenuItem();
            emulatorButton = new ToolStripMenuItem();
            tabControl1 = new TabControl();
            mainMenu.SuspendLayout();
            SuspendLayout();
            // 
            // mainMenu
            // 
            mainMenu.Items.AddRange(new ToolStripItem[] { programToolStripMenuItem, emulatorButton });
            mainMenu.Location = new Point(0, 0);
            mainMenu.Name = "mainMenu";
            mainMenu.Size = new Size(800, 24);
            mainMenu.TabIndex = 0;
            mainMenu.Text = "menuStrip1";
            // 
            // programToolStripMenuItem
            // 
            programToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { pluginItem, toolStripMenuItem2, closeToolStripMenuItem });
            programToolStripMenuItem.Name = "programToolStripMenuItem";
            programToolStripMenuItem.Size = new Size(65, 20);
            programToolStripMenuItem.Text = "Program";
            // 
            // pluginItem
            // 
            pluginItem.Name = "pluginItem";
            pluginItem.Size = new Size(113, 22);
            pluginItem.Text = "Plugins";
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(110, 6);
            // 
            // closeToolStripMenuItem
            // 
            closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            closeToolStripMenuItem.Size = new Size(113, 22);
            closeToolStripMenuItem.Text = "Close";
            closeToolStripMenuItem.Click += closeToolStripMenuItem_Click;
            // 
            // emulatorButton
            // 
            emulatorButton.Alignment = ToolStripItemAlignment.Right;
            emulatorButton.Name = "emulatorButton";
            emulatorButton.Size = new Size(67, 20);
            emulatorButton.Text = "Emulator";
            emulatorButton.Click += emulatorButton_Click;
            // 
            // tabControl1
            // 
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 24);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(800, 426);
            tabControl1.TabIndex = 1;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Controls.Add(mainMenu);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = mainMenu;
            Name = "MainForm";
            Text = "LEGO Toypad Launcher";
            mainMenu.ResumeLayout(false);
            mainMenu.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip mainMenu;
        private ToolStripMenuItem programToolStripMenuItem;
        private ToolStripMenuItem pluginItem;
        private ToolStripSeparator toolStripMenuItem2;
        private ToolStripMenuItem closeToolStripMenuItem;
        private ToolStripMenuItem emulatorButton;
        private TabControl tabControl1;
    }
}
