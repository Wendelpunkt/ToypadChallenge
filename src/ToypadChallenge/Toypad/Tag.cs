using System.Collections.ObjectModel;

namespace Toypad
{
    /// <summary>
    /// Represents a single tag on the pad
    /// </summary>
    public sealed class Tag
    {
        /// <summary>
        /// Current tag index
        /// </summary>
        public int Index { get; }

        /// <summary>
        /// Tag position
        /// </summary>
        public Pad Pad { get; }

        /// <summary>
        /// UID of the tag
        /// </summary>
        public ReadOnlyCollection<byte> Uid { get; }

        /// <summary>
        /// Returns a potential display name
        /// </summary>
        public string DisplayName { get; }

        public Tag(int index, Pad pad, byte[] uid, string displayName = "")
        {
            Index = index;
            Pad = pad;
            Uid = new ReadOnlyCollection<byte>(uid);
            DisplayName = displayName;
        }
    }
}
