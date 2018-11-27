using System;
using System.Runtime.InteropServices;

/// <summary>
/// Discord RPC Sharp namespace
/// </summary>
namespace DiscordRPCSharp
{
    /// <summary>
    /// Discord Rich Presence data structure
    /// </summary>
    [Serializable, StructLayout(LayoutKind.Sequential)]
    internal struct DiscordRichPresenceData
    {
        /// <summary>
        /// State
        /// </summary>
        /// <remarks>Maximal 128 bytes</remarks>
        public IntPtr state;

        /// <summary>
        /// Details
        /// </summary>
        /// <remarks>Maximal 128 bytes</remarks>
        public IntPtr details;

        /// <summary>
        /// Start timestamp
        /// </summary>
        public long startTimestamp;

        /// <summary>
        /// End timestamp
        /// </summary>
        public long endTimestamp;

        /// <summary>
        /// Large umage key
        /// </summary>
        /// <remarks>Maximal 32 bytes</remarks>
        public IntPtr largeImageKey;

        /// <summary>
        /// Large image text
        /// </summary>
        /// <remarks>Maximal 128 bytes</remarks>
        public IntPtr largeImageText;

        /// <summary>
        /// Small image key
        /// </summary>
        /// <remarks>Maximal 32 bytes</remarks>
        public IntPtr smallImageKey;

        /// <summary>
        /// Small image text
        /// </summary>
        /// <remarks>Maximal 128 bytes</remarks>
        public IntPtr smallImageText;

        /// <summary>
        /// Party ID
        /// </summary>
        /// <remarks>Maximal 128 bytes</remarks>
        public IntPtr partyID;

        /// <summary>
        /// Party size
        /// </summary>
        public int partySize;

        /// <summary>
        /// Party maximal
        /// </summary>
        public int partyMax;

        /// <summary>
        /// Match secret
        /// </summary>
        /// <remarks>Maximal 128 bytes</remarks>
        public IntPtr matchSecret;

        /// <summary>
        /// Join secret
        /// </summary>
        /// <remarks>Maximal 128 bytes</remarks>
        public IntPtr joinSecret;

        /// <summary>
        /// Spectate secret
        /// </summary>
        /// <remarks>Maximal 128 bytes</remarks>
        public IntPtr spectateSecret;

        /// <summary>
        /// Instance
        /// </summary>
        public bool instance;
    }
}
