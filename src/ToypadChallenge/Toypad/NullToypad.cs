using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Drawing;

namespace Toypad
{
    /// <summary>
    /// Dummy implementation of the toypad which just do nothing
    /// </summary>
    public sealed class NullToypad : IToypad
    {
        /// <inheritdoc />
        public Color LeftColor { get; } = Color.Black;

        /// <inheritdoc />
        public Color CenterColor { get; } = Color.Black;

        /// <inheritdoc />
        public Color RightColor { get; } = Color.Black;

        /// <inheritdoc />
        public void Dispose()
        {
            // Nothing to dispose
        }

        /// <inheritdoc />
        public void SetColor(Pad pad, Color color)
        {
            // Do nothing here
        }

        /// <inheritdoc />
        public void FlashColor(Pad pad, Color color, byte onPhase, byte offPhase, byte cycles)
        {
            // Do nothing here
        }

        /// <inheritdoc />
        public void FadeColor(Pad pad, Color color, byte time, byte cycles)
        {
            // Do nothing here
        }

        /// <inheritdoc />
        public IReadOnlyCollection<Tag> Tags => ReadOnlyCollection<Tag>.Empty;

        /// <inheritdoc />
        public event PropertyChangedEventHandler? PropertyChanged;

        /// <inheritdoc />
        public event EventHandler<Tag>? TagAdded;
        
        /// <inheritdoc />
        public event EventHandler<Tag>? TagRemoved;
    }
}
