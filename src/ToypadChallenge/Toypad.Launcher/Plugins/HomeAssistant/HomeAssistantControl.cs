using System.ComponentModel;
using System.Text;

namespace Toypad.Launcher.Plugins.HomeAssistant
{
    public partial class HomeAssistantControl : UserControl
    {
        public HomeAssistantConfiguration _config;
        public IToypad _toypad;
        public BindingList<HomeAssistantTag> _tags = new BindingList<HomeAssistantTag>();
        public String _actTag;

        public HomeAssistantControl()
        {
            InitializeComponent();
        }

        private void PluginInit()
        {

        }

        public void SetToypad(IToypad toypad)
        {
            toypad.TagAdded += ToypadOnTagAdded;
            toypad.TagRemoved += ToypadOnTagRemoved;
            _toypad = toypad;
        }

        private void ToypadOnTagRemoved(object? sender, Tag e)
        {
            _actTag = string.Empty;

            _toypad.SetColor(Pad.Left, Color.Black);
            _toypad.SetColor(Pad.Right, Color.Black);
            _toypad.SetColor(Pad.Center, Color.Black);
        }

        private void ToypadOnTagAdded(object? sender, Tag e)
        {
            _actTag = BitConverter.ToString(e.Uid.ToArray());

            if (_tags != null && _tags.Count > 0)
            {
                var tag = _tags.FirstOrDefault(x => x.UID == _actTag);

                if (tag != null)
                {
                    Post(tag.Entity, tag.Type);

                    _toypad.SetColor(Pad.Left, tag.Left);
                    _toypad.SetColor(Pad.Right, tag.Right);
                    _toypad.SetColor(Pad.Center, tag.Center);
                }
                else
                {
                    _toypad.SetColor(Pad.Left, Color.Red);
                    _toypad.SetColor(Pad.Right, Color.Red);
                    _toypad.SetColor(Pad.Center, Color.Red);

                    Thread.Sleep(800);

                    _toypad.SetColor(Pad.Left, Color.Black);
                    _toypad.SetColor(Pad.Right, Color.Black);
                    _toypad.SetColor(Pad.Center, Color.Black);
                }
            }
        }

        public void SetConfiguration(HomeAssistantConfiguration configuration)
        {
            _config = configuration;
            tbHomeAssistantURL.Text = _config.HomeAssistantURL;
            tbHomeAssistantToken.Text = _config.HomeAssistantToken;
            lbTags.DataSource = _config.HomeAssistantTags;
            _tags = _config.HomeAssistantTags;

            if (_tags == null)
            {
                _tags = new BindingList<HomeAssistantTag>();
            }

            PluginInit();
        }

        /// <summary>
        /// Updates the configuration based on the UI settings
        /// </summary>
        public void UpdateConfiguration(HomeAssistantConfiguration configuration)
        {
            _config = configuration;
            _config.HomeAssistantURL = tbHomeAssistantURL.Text;
            _config.HomeAssistantToken = tbHomeAssistantToken.Text;
            _config.HomeAssistantTags = _tags;
        }

        async public void Post(string scriptname, string scripttype)
        {

            string type = scripttype == "Automation" ? "automation" : "script";
            string typeurl = scripttype == "Automation" ? "automation/trigger" : "script/turn_on";

            string url = _config.HomeAssistantURL + "/api/services/" + typeurl;
            string token = _config.HomeAssistantToken;


            // Entity ID der Automation
            string EntityId = type + "." + scriptname;

            // JSON Daten
            var jsonData = $"{{\"entity_id\": \"{EntityId}\"}}";

            // HTTP Client erstellen
            using (HttpClient client = new HttpClient())
            {
                // Authentifizierungs-Header setzen
                client.DefaultRequestHeaders.Add("Authorization", $"Bearer {token}");
                client.DefaultRequestHeaders.Add("Accept", "application/json");

                // Content erstellen
                var content = new StringContent(jsonData, Encoding.UTF8, "application/json");

                // HTTP POST Request senden
                HttpResponseMessage response = await client.PostAsync(url, content);

                // Antwort prüfen
                if (response.IsSuccessStatusCode)
                {
                    Console.WriteLine("Erfolgreich ausgelöst.");
                }
                else
                {
                    Console.WriteLine($"Fehler: {response.StatusCode}");
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var frm = new HomeAssistantFormTag(null);
            frm.tbHomeAssistantTagUID.Text = _actTag;
            frm.ShowDialog();

            if (frm.Tag != null)
            {
                var tag = frm.Tag as HomeAssistantTag;

                if (tag != null)
                {
                    _tags.Add(tag);
                }
            }

            frm.Dispose();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            var slEntity = lbTags.SelectedItem as HomeAssistantTag;
            if (slEntity != null)
            {
                if (MessageBox.Show("Do you really want to hurt me? *SING* I mean, delete me.. ?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    _tags.Remove(slEntity);
                }
            }
        }

        private void btnEditTag_Click(object sender, EventArgs e)
        {
            var slEntity = lbTags.SelectedItem as HomeAssistantTag;
            if (slEntity != null)
            {
                var frm = new HomeAssistantFormTag(slEntity);
                frm.ShowDialog();

                if (frm.Tag != null)
                {
                    var tag = frm.Tag as HomeAssistantTag;

                    if (tag != null)
                    {
                        _tags.Remove(slEntity);
                        _tags.Add(tag);
                    }
                }
            }
        }
    }
}
