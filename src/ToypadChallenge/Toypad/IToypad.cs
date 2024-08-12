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
        Color LeftColor { get; }

        /// <summary>
        /// Gets the color of the center panel
        /// </summary>
        Color CenterColor { get; }

        /// <summary>
        /// Gets the color of the right panel
        /// </summary>
        Color RightColor { get; }

        /// <summary>
        /// Sets the color of a pad
        /// </summary>
        /// <param name="pad">target pads</param>
        /// <param name="color">color to set</param>
        void SetColor(Pad pad, Color color);

        /// <summary>
        /// Flashes with the given color
        /// </summary>
        /// <param name="pad">target pads</param>
        /// <param name="color">color to flash</param>
        /// <param name="onPhase">length of the on phase in ticks</param>
        /// <param name="offPhase">length of the off phase in ticks</param>
        /// <param name="cycles">number of color changes (even numbers end up in the original color, uneven numbers end with the flash color)</param>
        void FlashColor(Pad pad, Color color, byte onPhase, byte offPhase, byte cycles);

        /// <summary>
        /// Fades to the given color
        /// </summary>
        /// <param name="pad">target pads</param>
        /// <param name="color">target color</param>
        /// <param name="time">time to fade</param>
        /// <param name="cycles">number of color changes (even numbers end up in the original color, uneven numbers end with the flash color)</param>
        void FadeColor(Pad pad, Color color, byte time, byte cycles);

        /// <summary>
        /// Collection of all present tags
        /// </summary>
        IReadOnlyCollection<Tag> Tags { get; }

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
