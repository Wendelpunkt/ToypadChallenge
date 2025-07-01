

using NAudio.Wave;

namespace Toypad.Launcher.Plugins.LoopStation
{
    public partial class LoopStationControl : UserControl
    {
        private LoopStationConfiguration? _configuration;

        private IToypad? _toypad;

        public LoopStationControl()
        {
            InitializeComponent();
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
            _toypad.TagAdded += ToypadOnTagAdded;
            _toypad.TagRemoved += ToypadOnTagRemoved;
        }

        private void ToypadOnTagRemoved(object? sender, Tag e)
        {
            UpdateTags();
        }

        private void ToypadOnTagAdded(object? sender, Tag e)
        {
            UpdateTags();
        }

        private void UpdateTags()
        {
            var tags = _toypad.Tags.ToArray();

            switch (_toypad.Tags.Count(t => t.Pad == Pad.Center))
            {
                case 1:
                    _toypad.SetColor(Pad.Center, Color.LightGreen);
                    break;
                default:
                    _toypad.SetColor(Pad.Center, Color.Black);
                    break;
            }

            switch (_toypad.Tags.Count(t => t.Pad == Pad.Left))
            {
                case 1:
                    _toypad.SetColor(Pad.Left, Color.LightGreen);
                    break;
                case 2:
                    _toypad.SetColor(Pad.Left, Color.Yellow);
                    break;
                case 3:
                    _toypad.SetColor(Pad.Left, Color.Red);
                    break;
                case 4:
                    _toypad.SetColor(Pad.Left, Color.Purple);
                    break;
                default:
                    _toypad.SetColor(Pad.Left, Color.Black);
                    break;
            }

            switch (_toypad.Tags.Count(t => t.Pad == Pad.Right))
            {
                case 1:
                    _toypad.SetColor(Pad.Right, Color.LightGreen);
                    break;
                case 2:
                    _toypad.SetColor(Pad.Right, Color.Yellow);
                    break;
                case 3:
                    _toypad.SetColor(Pad.Right, Color.Red);
                    break;
                case 4:
                    _toypad.SetColor(Pad.Right, Color.Purple);
                    break;
                default:
                    _toypad.SetColor(Pad.Right, Color.Black);
                    break;
            }

            Invoke(() =>
            {
                foreach (ListViewItem item in listTracks.Items)
                {
                    if (item.Tag is LoopTrack track)
                    {
                        var tag = tags.FirstOrDefault(t => t.Pad == track.Pad && t.Uid.SequenceEqual(track.Token));
                        track.NextCycleActive = tag is not null;

                        // Set color
                        if (track.IsActive)
                        {
                            if (track.NextCycleActive)
                            {
                                // Track was playing and will be playing in next loop
                                item.BackColor = Color.LawnGreen;
                            }
                            else
                            {
                                // Track is playing but not anymore in next loop
                                item.BackColor = Color.Orange;
                            }
                        }
                        else
                        {
                            if (track.NextCycleActive)
                            {
                                // Track is not playing yet but in the next loop
                                item.BackColor = Color.Yellow;
                            }
                            else
                            {
                                // Track is silent in both loops
                                item.BackColor = Color.White;
                            }
                        }
                    }
                }
            });
        }

        private void cmbPresets_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnDeletePreset.Enabled = cmbPresets.SelectedItem != null;
            btnEditPreset.Enabled = cmbPresets.SelectedItem != null;

            var preset = cmbPresets.SelectedItem as LoopStationConfiguration.LoopStationPreset;
            if (_configuration is not null)
            {
                _configuration.SelectedPreset = preset?.Id;
            }

            if (preset is null)
            {
                RemovePreset();
            }
            else
            {
                InitPreset(preset);
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

                _configuration?.Presets.Add(preset);

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
                RemovePreset();

                // Remove from set
                cmbPresets.Items.Remove(preset);
                _configuration?.Presets.Remove(preset);
            }
        }

        private void btnEditPreset_Click(object sender, EventArgs e)
        {
            if (cmbPresets.SelectedItem is LoopStationConfiguration.LoopStationPreset preset)
            {
                Stop();
                using (EditPresetDialog dialog = new EditPresetDialog(_toypad, preset))
                {
                    if (dialog.ShowDialog(this) == DialogResult.OK)
                    {
                        cmbPresets.Items.Remove(preset);
                        cmbPresets.Items.Add(preset);
                        cmbPresets.SelectedItem = preset;
                    }
                }
            }
        }

        private WaveOutEvent? _device;

        private LoopMixProvider? _mixProvider;

        private void InitPreset(LoopStationConfiguration.LoopStationPreset preset)
        {
            RemovePreset();

            var samples = preset.Samples.Where(s => s.Pad != Pad.None && s.Token != null).ToArray();

            if (!samples.Any())
            {
                return;
            }

            _device = new WaveOutEvent();

            // Initial sample
            var track = LoopMixProvider.CreateTrack(samples[0]);

            listTracks.Items.Clear();
            listTracks.Items.Add(new ListViewItem
            {
                Text = track.Name,
                Tag = track
            });

            _mixProvider = new LoopMixProvider(track);

            for (var i = 1; i < samples.Length; i++)
            {
                track = _mixProvider.Add(samples[i]);
                listTracks.Items.Add(new ListViewItem
                {
                    Text = track.Name,
                    Tag = track
                });
            }

            _mixProvider.LoopReached += MixProviderOnLoopReached;

            _device.Init(_mixProvider);
        }

        private void Play()
        {
            if (_device is null)
            {
                return;
            }

            _device.Play();
            btnPlay.BackColor = Color.Chartreuse;
        }

        private void Stop()
        {
            if (_device is null)
            {
                return;
            }

            _device.Stop();
            btnPlay.BackColor = btnNewPreset.BackColor;
        }

        private void RemovePreset()
        {
            if (_mixProvider != null)
            {
                _mixProvider.LoopReached -= MixProviderOnLoopReached;
            }

            if (_device is not null)
            {
                Stop();
                _device.Dispose();
                _device = null;
            }

            listTracks.Items.Clear();
        }

        private void MixProviderOnLoopReached()
        {
            Invoke(UpdateTags);
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            if (_device is null)
            {
                return;
            }

            if (_device.PlaybackState == PlaybackState.Playing)
            {
                Stop();
            }
            else
            {
                Play();
            }
        }
    }
}
