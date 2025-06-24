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
                btnClean.Enabled = true;
                lblFolder.Enabled = true;
                lblFolder.Text = folderBrowserDialog.SelectedPath;
            }
        }

        private void tbName_TextChanged(object sender, EventArgs e)
        {
            btnOk.Enabled = !string.IsNullOrWhiteSpace(tbName.Text);
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            btnClean.Enabled = false;
            lblFolder.Enabled = false;
            lblFolder.Text = "No import";
        }
    }
}
