

using NAudio.Wave;

namespace Toypad.Launcher.Plugins.LoopStation
{
    public partial class LoopStationControl : UserControl
    {
        private LoopStationConfiguration _configuration;

        private readonly WaveOutEvent _device;

        private readonly LoopMixProvider _mixProvider;

        public LoopStationControl()
        {
            //_device = new WaveOutEvent();

            //_mixProvider = new LoopMixProvider(@"D:\Sounds\Summer House Anthems - ACID WAV\Kit_04_A# (124) Chemistry\PL_SHA_Kit_04_Kick_124.wav");
            //_mixProvider.Add(@"D:\Sounds\Summer House Anthems - ACID WAV\Kit_04_A# (124) Chemistry\PL_SHA_Kit_04_Clap_124.wav");
            //_mixProvider.Add(@"D:\Sounds\Summer House Anthems - ACID WAV\Kit_04_A# (124) Chemistry\Dry\PL_SHA_Kit_04_Break_Piano_124_A#_Dry.wav");
            //_device.Init(_mixProvider);

            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // _controller.Play();
            _device.Play();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // _controller.Stop();
            _device.Stop();
        }

        public void SetConfiguration(LoopStationConfiguration configuration)
        {
            _configuration = configuration;

            cmbPresets.DisplayMember = nameof(LoopStationConfiguration.LoopStationPreset.Name);
            cmbPresets.Items.Clear();
            foreach (var preset in _configuration.Presets)
            {
                cmbPresets.Items.Add(preset);
            }

            // Preselect one
            if (_configuration.SelectedPreset.HasValue)
            {
                var preset = _configuration.Presets.FirstOrDefault(p => p.Id == _configuration.SelectedPreset.Value);
                if (preset is null)
                {
                    // Preset does not exist anymore. Remove preselection
                    _configuration.SelectedPreset = null;
                }
                else
                {
                    // Set preset
                    cmbPresets.SelectedItem = preset;
                }
            }
        }

        private void cmbPresets_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnDeletePreset.Enabled = cmbPresets.SelectedItem != null;
            btnEditPreset.Enabled = cmbPresets.SelectedItem != null;

            var preset = cmbPresets.SelectedItem as LoopStationConfiguration.LoopStationPreset;
            _configuration.SelectedPreset = preset?.Id;
            if (preset is null)
            {
                // TODO: Unload stuff
            }
            else
            {
                // TODO: Load stuff
            }
        }

        private void btnNewPreset_Click(object sender, EventArgs e)
        {
            using NewPresetDialog dialog = new NewPresetDialog();
            if (dialog.ShowDialog(this) == DialogResult.OK)
            {
                var preset = new LoopStationConfiguration.LoopStationPreset()
                {
                    Id = Guid.NewGuid(),
                    Name = dialog.tbName.Text,
                    Samples = new List<LoopStationConfiguration.LoopStationSample>()
                };

                if (dialog.lblFolder.Enabled)
                {
                    // Scan for files
                    var directory = new DirectoryInfo(dialog.lblFolder.Text);
                    foreach (var file in directory.GetFiles("*.wav", SearchOption.AllDirectories))
                    {
                        preset.Samples.Add(new LoopStationConfiguration.LoopStationSample
                        {
                            Filename = file.FullName
                        });
                    }
                }

                _configuration.Presets.Add(preset);
                cmbPresets.Items.Add(preset);
                cmbPresets.SelectedItem = preset;
            }
        }

        private void btnDeletePreset_Click(object sender, EventArgs e)
        {
            if (cmbPresets.SelectedItem is LoopStationConfiguration.LoopStationPreset preset)
            {
                // Unselect
                cmbPresets.SelectedItem = null;

                // Remove from set
                cmbPresets.Items.Remove(preset);
                _configuration.Presets.Remove(preset);
            }
        }
    }
}
