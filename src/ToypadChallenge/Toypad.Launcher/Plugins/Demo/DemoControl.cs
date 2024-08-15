using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Toypad.Launcher.Plugins.Demo
{
    public partial class DemoControl : UserControl
    {
        private IToypad _toypad;

        public DemoControl()
        {
            InitializeComponent();
        }

        public void SetToypad(IToypad toypad)
        {
            _toypad = toypad;
        }

        private void blinkButton_Click(object sender, EventArgs e)
        {
            _toypad.FlashColor(Pad.Left | Pad.Right, Color.BlueViolet, 10, 10, 4);
        }
    }
}
