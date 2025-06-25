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
    public partial class EditPresetDialog : Form
    {
        private readonly LoopStationConfiguration.LoopStationPreset _preset;

        public EditPresetDialog()
        {
            _preset = new LoopStationConfiguration.LoopStationPreset
            {
                Id = Guid.NewGuid(),
                Name = "New preset",
                Samples = new List<LoopStationConfiguration.LoopStationSample>()
            };

            InitializeComponent();
            ApplyFromPreset();
        }

        public EditPresetDialog(LoopStationConfiguration.LoopStationPreset preset)
        {
            _preset = preset;

            InitializeComponent();
            ApplyFromPreset();
        }

        private void ApplyFromPreset()
        {
            tbName.Text = _preset.Name;

            listSamples.Items.Clear();
            foreach (var sample in _preset.Samples)
            {
                listSamples.Items.Add(new ListViewItem
                {
                    Text = sample.Filename,
                    Tag = sample
                });
            }
        }
    }
}
