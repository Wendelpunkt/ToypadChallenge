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
