using System;

/// <summary>
/// Discord RPC Sharp namespace
/// </summary>
namespace DiscordRPCSharp
{
    /// <summary>
    /// User data
    /// </summary>
    [Serializable]
    public struct UserData
    {
        /// <summary>
        /// User ID
        /// </summary>
        public string userID;

        /// <summary>
        /// Username
        /// </summary>
        public string username;

        /// <summary>
        /// Discriminator
        /// </summary>
        public string discriminator;

        /// <summary>
        /// Avatar
        /// </summary>
        public string avatar;
    }
}
