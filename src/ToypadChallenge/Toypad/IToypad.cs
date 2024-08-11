using System.ComponentModel;
using System.Drawing;

namespace Toypad
{
    /// <summary>
    /// Represents a toypad
    /// </summary>
    public interface IToypad : INotifyPropertyChanged, IDisposable
    {
        /// <summary>
        /// Gets the color of the left panel
        /// </summary>
        public Color LeftPanel { get; }

        /// <summary>
        /// Gets the color of the center panel
        /// </summary>
        public Color CenterPanel { get; }

        /// <summary>
        /// Gets the color of the right panel
        /// </summary>
        public Color RightPanel { get; }

        /// <summary>
        /// Collection of all present tags
        /// </summary>
        public IReadOnlyCollection<Tag> Tags { get; }

        /// <summary>
        /// Event for added tags
        /// </summary>
        event EventHandler<Tag>? TagAdded;

        /// <summary>
        /// Event for removed tags
        /// </summary>
        event EventHandler<Tag>? TagRemoved;
    }
}
