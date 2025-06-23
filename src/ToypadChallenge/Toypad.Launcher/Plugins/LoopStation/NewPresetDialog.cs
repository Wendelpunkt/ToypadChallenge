using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Toypad.Launcher.Plugins.LoopStation
{
    public partial class NewPresetDialog : Form
    {
        public NewPresetDialog()
        {
            InitializeComponent();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog.ShowDialog(this) == DialogResult.OK)
            {
                lblFolder.Text = folderBrowserDialog.SelectedPath;
            }
        }
    }
}
