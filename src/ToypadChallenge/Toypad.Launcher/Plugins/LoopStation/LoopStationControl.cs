

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
            _device = new WaveOutEvent();


            _mixProvider = new LoopMixProvider(@"D:\Sounds\Summer House Anthems - ACID WAV\Kit_04_A# (124) Chemistry\PL_SHA_Kit_04_Kick_124.wav");
            _mixProvider.Add(@"D:\Sounds\Summer House Anthems - ACID WAV\Kit_04_A# (124) Chemistry\PL_SHA_Kit_04_Clap_124.wav");
            _mixProvider.Add(@"D:\Sounds\Summer House Anthems - ACID WAV\Kit_04_A# (124) Chemistry\Dry\PL_SHA_Kit_04_Break_Piano_124_A#_Dry.wav");
            _device.Init(_mixProvider);

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
        }

        private void cmbPresets_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnDeletePreset.Enabled = cmbPresets.SelectedItem != null;
        }

        private void btnNewPreset_Click(object sender, EventArgs e)
        {
            using (NewPresetDialog dialog = new NewPresetDialog())
            {
                dialog.tbName.Text = "new preset";
                if (dialog.ShowDialog(this) == DialogResult.OK)
                {

                }
            }
        }
    }
}
