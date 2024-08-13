namespace Toypad.Launcher
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
            programMenuItem = new ToolStripMenuItem();
            closeMenuItem = new ToolStripMenuItem();
            emulatorButton = new ToolStripMenuItem();
            pluginsMenuItem = new ToolStripMenuItem();
            createPluginMenuItem = new ToolStripMenuItem();
            removePluginMenuItem = new ToolStripMenuItem();
            tabControl = new TabControl();
            mainMenu.SuspendLayout();
            SuspendLayout();
            // 
            // mainMenu
            // 
            mainMenu.Items.AddRange(new ToolStripItem[] { programMenuItem, emulatorButton, pluginsMenuItem });
            mainMenu.Location = new Point(0, 0);
            mainMenu.Name = "mainMenu";
            mainMenu.Size = new Size(1184, 24);
            mainMenu.TabIndex = 0;
            mainMenu.Text = "menuStrip1";
            // 
            // programMenuItem
            // 
            programMenuItem.DropDownItems.AddRange(new ToolStripItem[] { closeMenuItem });
            programMenuItem.Name = "programMenuItem";
            programMenuItem.Size = new Size(65, 20);
            programMenuItem.Text = "Program";
            // 
            // closeMenuItem
            // 
            closeMenuItem.Name = "closeMenuItem";
            closeMenuItem.Size = new Size(103, 22);
            closeMenuItem.Text = "Close";
            closeMenuItem.Click += closeToolStripMenuItem_Click;
            // 
            // emulatorButton
            // 
            emulatorButton.Alignment = ToolStripItemAlignment.Right;
            emulatorButton.BackColor = Color.FromArgb(192, 64, 0);
            emulatorButton.Name = "emulatorButton";
            emulatorButton.Size = new Size(67, 20);
            emulatorButton.Text = "Emulator";
            emulatorButton.Click += emulatorButton_Click;
            // 
            // pluginsMenuItem
            // 
            pluginsMenuItem.DropDownItems.AddRange(new ToolStripItem[] { createPluginMenuItem, removePluginMenuItem });
            pluginsMenuItem.Name = "pluginsMenuItem";
            pluginsMenuItem.Size = new Size(58, 20);
            pluginsMenuItem.Text = "Plugins";
            // 
            // createPluginMenuItem
            // 
            createPluginMenuItem.Name = "createPluginMenuItem";
            createPluginMenuItem.Size = new Size(180, 22);
            createPluginMenuItem.Text = "Create";
            // 
            // removePluginMenuItem
            // 
            removePluginMenuItem.Enabled = false;
            removePluginMenuItem.Name = "removePluginMenuItem";
            removePluginMenuItem.Size = new Size(180, 22);
            removePluginMenuItem.Text = "Remove";
            removePluginMenuItem.Click += removePluginMenuItem_Click;
            // 
            // tabControl
            // 
            tabControl.Dock = DockStyle.Fill;
            tabControl.Location = new Point(0, 24);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(1184, 577);
            tabControl.TabIndex = 1;
            tabControl.SelectedIndexChanged += tabControl_SelectedIndexChanged;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1184, 601);
            Controls.Add(tabControl);
            Controls.Add(mainMenu);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = mainMenu;
            MinimumSize = new Size(1200, 640);
            Name = "MainForm";
            Text = "LEGO Toypad Launcher";
            mainMenu.ResumeLayout(false);
            mainMenu.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip mainMenu;
        private ToolStripMenuItem programMenuItem;
        private ToolStripMenuItem closeMenuItem;
        private ToolStripMenuItem emulatorButton;
        private TabControl tabControl;
        private ToolStripMenuItem pluginsMenuItem;
        private ToolStripMenuItem createPluginMenuItem;
        private ToolStripMenuItem removePluginMenuItem;
    }
}
