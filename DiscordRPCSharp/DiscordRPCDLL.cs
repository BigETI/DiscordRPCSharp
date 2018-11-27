using System.Runtime.InteropServices;

/// <summary>
/// Discord RPC sharp namespace
/// </summary>
namespace DiscordRPCSharp
{
    /// <summary>
    /// Discord RPC DLL class
    /// </summary>
    internal static class DiscordRPCDLL
    {
        /// <summary>
        /// Initialize
        /// </summary>
        /// <param name="applicationID">Application ID</param>
        /// <param name="handlers">Handlers</param>
        /// <param name="autoRegister">Auto register</param>
        /// <param name="optionalSteamID">Optional Steam ID</param>
        [DllImport("discord-rpc", EntryPoint = "Discord_Initialize", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Initialize(string applicationID, ref DiscordRPCCallbacks handlers, bool autoRegister, string optionalSteamID);

        /// <summary>
        /// Shutdown
        /// </summary>
        [DllImport("discord-rpc", EntryPoint = "Discord_Shutdown", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Shutdown();

        /// <summary>
        /// Run callbacks
        /// </summary>
        [DllImport("discord-rpc", EntryPoint = "Discord_RunCallbacks", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void RunCallbacks();

        /// <summary>
        /// Update presence native
        /// </summary>
        /// <param name="presence"></param>
        [DllImport("discord-rpc", EntryPoint = "Discord_UpdatePresence", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void UpdatePresenceNative(ref DiscordRichPresenceData presence);

        /// <summary>
        /// Clear presence
        /// </summary>
        [DllImport("discord-rpc", EntryPoint = "Discord_ClearPresence", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void ClearPresence();

        /// <summary>
        /// Respond
        /// </summary>
        /// <param name="userID">User ID</param>
        /// <param name="reply">Reply</param>
        [DllImport("discord-rpc", EntryPoint = "Discord_Respond", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Respond(string userID, EReply reply);

        /// <summary>
        /// Update handlers
        /// </summary>
        /// <param name="handlers">Handlers</param>
        [DllImport("discord-rpc", EntryPoint = "Discord_UpdateHandlers", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void UpdateHandlers(ref DiscordRPCCallbacks handlers);
    }
}
