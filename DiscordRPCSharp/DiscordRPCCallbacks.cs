/// <summary>
/// Discord RPC Sharp namespace
/// </summary>
namespace DiscordRPCSharp
{
    /// <summary>
    /// Discord RPC event handler structure
    /// </summary>
    internal struct DiscordRPCCallbacks
    {
        /// <summary>
        /// On ready
        /// </summary>
        public ReadyDelegate onReady;

        /// <summary>
        /// On disconnected
        /// </summary>
        public DisconnectedDelegate onDisconnected;

        /// <summary>
        /// On error
        /// </summary>
        public ErrorDelegate onError;

        /// <summary>
        /// On join
        /// </summary>
        public JoinDelegate onJoin;

        /// <summary>
        /// On spectate
        /// </summary>
        public SpectateDelegate onSpectate;

        /// <summary>
        /// On request
        /// </summary>
        public RequestDelegate onRequest;
    }
}
