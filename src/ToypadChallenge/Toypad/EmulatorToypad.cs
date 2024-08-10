using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Drawing;

namespace Toypad
{
    public sealed class EmulatorToypad : IToypad
    {
        public void Dispose()
        {
        }

        public Color LeftPanel { get; set; }
        public Color CenterPanel { get; set; }
        public Color RightPanel { get; set; }
        public IReadOnlyCollection<Tag> Tags { get; }

        public event EventHandler<Tag>? TagAdded;
        public event EventHandler<Tag>? TagRemoved;
        public event PropertyChangedEventHandler? PropertyChanged;
    }
}
