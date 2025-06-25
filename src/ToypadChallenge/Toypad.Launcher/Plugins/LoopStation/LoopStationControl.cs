

using NAudio.Wave;

namespace Toypad.Launcher.Plugins.LoopStation
{
    public partial class LoopStationControl : UserControl
    {
        private LoopStationConfiguration _configuration;

        private IToypad _toypad;

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

        public void SetToypad(IToypad toypad)
        {
            _toypad = toypad;
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
            using var newDialog = new NewPresetDialog();
            if (newDialog.ShowDialog(this) == DialogResult.OK)
            {
                var preset = new LoopStationConfiguration.LoopStationPreset
                {
                    Id = Guid.NewGuid(),
                    Name = newDialog.tbName.Text,
                    Samples = new List<LoopStationConfiguration.LoopStationSample>()
                };

                if (newDialog.lblFolder.Enabled)
                {
                    // Scan for files
                    var directory = new DirectoryInfo(newDialog.lblFolder.Text);
                    foreach (var file in directory.GetFiles("*.wav", SearchOption.AllDirectories))
                    {
                        preset.Samples.Add(new LoopStationConfiguration.LoopStationSample
                        {
                            Name = file.Name,
                            Filename = file.FullName,
                            Pad = Pad.None,
                            Token = null,
                        });
                    }
                }

                // Open up editor for changing imported stuff
                using (var editDialog = new EditPresetDialog(_toypad, preset))
                {
                    if (editDialog.ShowDialog() != DialogResult.OK)
                    {
                        // If the editor was cancelled, stop here
                        return;
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

        private void btnEditPreset_Click(object sender, EventArgs e)
        {
            if (cmbPresets.SelectedItem is LoopStationConfiguration.LoopStationPreset preset)
            {
                using (EditPresetDialog dialog = new EditPresetDialog(_toypad, preset))
                {
                    if (dialog.ShowDialog(this) == DialogResult.OK)
                    {
                        // TODO: Apply
                    }
                }
            }
        }
    }
}
