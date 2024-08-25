using System.ComponentModel;

namespace Toypad.Launcher.Plugins.HomeAssistant
{
    public class HomeAssistantTag
    {
        public String Type { get; set; }
        public String Entity { get; set; }
        public String UID { get; set; }

        public Color Left { get; set; }
        public Color Center { get; set; }
        public Color Right { get; set; }

        public override string ToString()
        {
            return UID + " - " + Entity + " - " + Type;
        }
    }

    public sealed class HomeAssistantConfiguration : IConfiguration
    {
        public String HomeAssistantURL { get; set; }

        public String HomeAssistantToken { get; set; }

        public BindingList<HomeAssistantTag> HomeAssistantTags { get; set; }
    }
}
