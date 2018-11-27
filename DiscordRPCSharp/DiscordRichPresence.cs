using System;
using System.Runtime.InteropServices;
using System.Text;

/// <summary>
/// Discord RPC Sharp namespace
/// </summary>
namespace DiscordRPCSharp
{
    /// <summary>
    /// Discord Rich Presence class
    /// </summary>
    public static class DiscordRichPresence
    {
        /// <summary>
        /// Discord Rich Presence data
        /// </summary>
        private static DiscordRichPresenceData discordRichPresenceData;

        /// <summary>
        /// Is initialized
        /// </summary>
        private static bool isInitialized;

        /// <summary>
        /// Discord RPC callbacks
        /// </summary>
        private static DiscordRPCCallbacks discordRPCCallbacks;

        /// <summary>
        /// State
        /// </summary>
        private static string state;

        /// <summary>
        /// Details
        /// </summary>
        /// <remarks>Maximal 128 bytes</remarks>
        private static string details;

        /// <summary>
        /// Start timestamp
        /// </summary>
        private static long startTimestamp;

        /// <summary>
        /// End timestamp
        /// </summary>
        private static long endTimestamp;

        /// <summary>
        /// Large image key
        /// </summary>
        private static string largeImageKey;

        /// <summary>
        /// Large image text
        /// </summary>
        private static string largeImageText;

        /// <summary>
        /// Small image key
        /// </summary>
        private static string smallImageKey;

        /// <summary>
        /// Small image text
        /// </summary>
        private static string smallImageText;

        /// <summary>
        /// Party ID
        /// </summary>
        private static string partyID;

        /// <summary>
        /// Party size
        /// </summary>
        private static int partySize;

        /// <summary>
        /// Party maximal
        /// </summary>
        private static int partyMax;

        /// <summary>
        /// Match secret
        /// </summary>
        private static string matchSecret;

        /// <summary>
        /// Join secret
        /// </summary>
        private static string joinSecret;

        /// <summary>
        /// Spectate secret
        /// </summary>
        private static string spectateSecret;

        /// <summary>
        /// Instance
        /// </summary>
        private static bool instance;

        /// <summary>
        /// Is initialized
        /// </summary>
        public static bool IsInitialized
        {
            get
            {
                return isInitialized;
            }
        }

        /// <summary>
        /// State
        /// </summary>
        public static string State
        {
            get
            {
                return state;
            }
            set
            {
                if ((value != null) && (state != value))
                {
                    state = value;
                    Delete(ref discordRichPresenceData.state);
                    discordRichPresenceData.state = NewString(state, 128);
                    UpdatePresence();
                }
            }
        }

        /// <summary>
        /// Details
        /// </summary>
        public static string Details
        {
            get
            {
                return details;
            }
            set
            {
                if ((value != null) && (details != value))
                {
                    details = value;
                    Delete(ref discordRichPresenceData.details);
                    discordRichPresenceData.details = NewString(state, 128);
                    UpdatePresence();
                }
            }
        }

        /// <summary>
        /// Start timestamp
        /// </summary>
        public static long StartTimestamp
        {
            get
            {
                return startTimestamp;
            }
            set
            {
                if (startTimestamp != value)
                {
                    startTimestamp = value;
                    UpdatePresence();
                }
            }
        }

        /// <summary>
        /// End timestamp
        /// </summary>
        public static long EndTimestamp
        {
            get
            {
                return endTimestamp;
            }
            set
            {
                if (endTimestamp != value)
                {
                    endTimestamp = value;
                    UpdatePresence();
                }
            }
        }

        /// <summary>
        /// Large image key
        /// </summary>
        public static string LargeImageKey
        {
            get
            {
                return largeImageKey;
            }
            set
            {
                if ((value != null) && (largeImageKey != value))
                {
                    largeImageKey = value;
                    Delete(ref discordRichPresenceData.largeImageKey);
                    discordRichPresenceData.largeImageKey = NewString(state, 32);
                    UpdatePresence();
                }
            }
        }

        /// <summary>
        /// Large image text
        /// </summary>
        public static string LargeImageText
        {
            get
            {
                return largeImageText;
            }
            set
            {
                if ((value != null) && (largeImageText != value))
                {
                    largeImageText = value;
                    Delete(ref discordRichPresenceData.largeImageText);
                    discordRichPresenceData.largeImageText = NewString(state, 128);
                    UpdatePresence();
                }
            }
        }

        /// <summary>
        /// Small image key
        /// </summary>
        public static string SmallImageKey
        {
            get
            {
                return smallImageKey;
            }
            set
            {
                if ((value != null) && (smallImageKey != value))
                {
                    smallImageKey = value;
                    Delete(ref discordRichPresenceData.smallImageKey);
                    discordRichPresenceData.smallImageKey = NewString(state, 32);
                    UpdatePresence();
                }
            }
        }

        /// <summary>
        /// Small image text
        /// </summary>
        public static string SmallImageText
        {
            get
            {
                return smallImageText;
            }
            set
            {
                if ((value != null) && (smallImageText != value))
                {
                    smallImageText = value;
                    Delete(ref discordRichPresenceData.smallImageText);
                    discordRichPresenceData.smallImageText = NewString(state, 128);
                    UpdatePresence();
                }
            }
        }

        /// <summary>
        /// Party ID
        /// </summary>
        public static string PartyID
        {
            get
            {
                return partyID;
            }
            set
            {
                if ((value != null) && (partyID != value))
                {
                    partyID = value;
                    Delete(ref discordRichPresenceData.partyID);
                    discordRichPresenceData.partyID = NewString(state, 128);
                    UpdatePresence();
                }
            }
        }

        /// <summary>
        /// Party size
        /// </summary>
        public static int PartySize
        {
            get
            {
                return partySize;
            }
            set
            {
                if (partySize != value)
                {
                    partySize = value;
                    UpdatePresence();
                }
            }
        }

        /// <summary>
        /// Party maximal
        /// </summary>
        public static int PartyMax
        {
            get
            {
                return partyMax;
            }
            set
            {
                if (partyMax != value)
                {
                    partyMax = value;
                    UpdatePresence();
                }
            }
        }

        /// <summary>
        /// Match secret
        /// </summary>
        public static string MatchSecret
        {
            get
            {
                return matchSecret;
            }
            set
            {
                if ((value != null) && (matchSecret != value))
                {
                    matchSecret = value;
                    Delete(ref discordRichPresenceData.matchSecret);
                    discordRichPresenceData.matchSecret = NewString(state, 128);
                    UpdatePresence();
                }
            }
        }

        /// <summary>
        /// Join secret
        /// </summary>
        public static string JoinSecret
        {
            get
            {
                return joinSecret;
            }
            set
            {
                if ((value != null) && (joinSecret != value))
                {
                    joinSecret = value;
                    Delete(ref discordRichPresenceData.joinSecret);
                    discordRichPresenceData.joinSecret = NewString(state, 128);
                    UpdatePresence();
                }
            }
        }

        /// <summary>
        /// Spectate secret
        /// </summary>
        /// <remarks>Maximal 128 bytes</remarks>
        public static string SpectateSecret
        {
            get
            {
                return spectateSecret;
            }
            set
            {
                if ((value != null) && (spectateSecret != value))
                {
                    spectateSecret = value;
                    Delete(ref discordRichPresenceData.spectateSecret);
                    discordRichPresenceData.spectateSecret = NewString(state, 128);
                    UpdatePresence();
                }
            }
        }

        /// <summary>
        /// Instance
        /// </summary>
        public static bool Instance
        {
            get
            {
                return instance;
            }
            set
            {
                if (instance != value)
                {
                    instance = value;
                    UpdatePresence();
                }
            }
        }

        /// <summary>
        /// On ready
        /// </summary>
        public static ReadyDelegate OnReady
        {
            get
            {
                return (isInitialized ? null : discordRPCCallbacks.onReady);
            }
            set
            {
                if (isInitialized && (discordRPCCallbacks.onReady != value))
                {
                    discordRPCCallbacks.onReady = value;
                    UpdateCallbacks();
                }
            }
        }

        /// <summary>
        /// On disconnected
        /// </summary>
        public static DisconnectedDelegate OnDisconnected
        {
            get
            {
                return (isInitialized ? null : discordRPCCallbacks.onDisconnected);
            }
            set
            {
                if (isInitialized && (discordRPCCallbacks.onDisconnected != value))
                {
                    discordRPCCallbacks.onDisconnected = value;
                    UpdateCallbacks();
                }
            }
        }

        /// <summary>
        /// On error
        /// </summary>
        public static ErrorDelegate OnError
        {
            get
            {
                return (isInitialized ? null : discordRPCCallbacks.onError);
            }
            set
            {
                if (isInitialized && (discordRPCCallbacks.onError != value))
                {
                    discordRPCCallbacks.onError = value;
                    UpdateCallbacks();
                }
            }
        }

        /// <summary>
        /// On join
        /// </summary>
        public static JoinDelegate OnJoin
        {
            get
            {
                return (isInitialized ? null : discordRPCCallbacks.onJoin);
            }
            set
            {
                if (isInitialized && (discordRPCCallbacks.onJoin != value))
                {
                    discordRPCCallbacks.onJoin = value;
                    UpdateCallbacks();
                }
            }
        }

        /// <summary>
        /// On spectate
        /// </summary>
        public static SpectateDelegate OnSpectate
        {
            get
            {
                return (isInitialized ? null : discordRPCCallbacks.onSpectate);
            }
            set
            {
                if (isInitialized && (discordRPCCallbacks.onSpectate != value))
                {
                    discordRPCCallbacks.onSpectate = value;
                    UpdateCallbacks();
                }
            }
        }

        /// <summary>
        /// On spectate
        /// </summary>
        public static RequestDelegate OnRequest
        {
            get
            {
                return (isInitialized ? null : discordRPCCallbacks.onRequest);
            }
            set
            {
                if (isInitialized && (discordRPCCallbacks.onRequest != value))
                {
                    discordRPCCallbacks.onRequest = value;
                    UpdateCallbacks();
                }
            }
        }

        /// <summary>
        /// New string
        /// </summary>
        /// <param name="str">String</param>
        /// <param name="maxBytes">Maximal bytes</param>
        /// <returns>Pointer to newly allocated string if successful, otherwise "IntPtr.Zero"</returns>
        private static IntPtr NewString(string str, int maxBytes)
        {
            IntPtr ret = IntPtr.Zero;
            if (isInitialized && (str != null) && (maxBytes > 1U))
            {
                try
                {
                    byte[] bytes = Encoding.UTF8.GetBytes(str);
                    int alloc_size = Math.Min(bytes.Length + 1, maxBytes);
                    ret = Marshal.AllocHGlobal(alloc_size);
                    if (ret != IntPtr.Zero)
                    {
                        Marshal.Copy(bytes, 0, ret, alloc_size - 1);
                        Marshal.WriteByte(ret, alloc_size - 1, 0);
                    }
                }
                catch (Exception e)
                {
                    Console.Error.WriteLine(e);
                }
            }
            return ret;
        }

        /// <summary>
        /// Free memory
        /// </summary>
        /// <param name="pointer">Pointer</param>
        private static void Delete(ref IntPtr pointer)
        {
            if (pointer != IntPtr.Zero)
            {
                Marshal.FreeHGlobal(pointer);
                pointer = IntPtr.Zero;
            }
        }

        /// <summary>
        /// Initialize
        /// </summary>
        /// <param name="applicationID">Application ID</param>
        /// <param name="autoRegister">Auto register</param>
        public static void Initialize(string applicationID, bool autoRegister)
        {
            Initialize(applicationID, autoRegister, null);
        }

        /// <summary>
        /// Initialize
        /// </summary>
        /// <param name="applicationID">Application ID</param>
        /// <param name="autoRegister">Auto register</param>
        /// <param name="optionalSteamID">Optional Steam ID</param>
        public static void Initialize(string applicationID, bool autoRegister, string optionalSteamID)
        {
            if ((!isInitialized) && (applicationID != null))
            {
                discordRPCCallbacks = new DiscordRPCCallbacks();
                try
                {
                    DiscordRPCDLL.Initialize(applicationID, ref discordRPCCallbacks, autoRegister, optionalSteamID);
                    isInitialized = true;
                    UpdatePresence();
                }
                catch (Exception e)
                {
                    Console.Error.WriteLine(e);
                }
            }
        }

        /// <summary>
        /// SHutdown
        /// </summary>
        public static void Shutdown()
        {
            if (isInitialized)
            {
                Delete(ref discordRichPresenceData.state);
                Delete(ref discordRichPresenceData.details);
                Delete(ref discordRichPresenceData.largeImageKey);
                Delete(ref discordRichPresenceData.largeImageText);
                Delete(ref discordRichPresenceData.smallImageKey);
                Delete(ref discordRichPresenceData.smallImageText);
                Delete(ref discordRichPresenceData.partyID);
                Delete(ref discordRichPresenceData.matchSecret);
                Delete(ref discordRichPresenceData.joinSecret);
                Delete(ref discordRichPresenceData.spectateSecret);
                try
                {
                    DiscordRPCDLL.Shutdown();
                }
                catch (Exception e)
                {
                    Console.Error.WriteLine(e);
                }
            }
        }

        /// <summary>
        /// Update presence
        /// </summary>
        private static void UpdatePresence()
        {
            if (isInitialized)
            {
                try
                {
                    DiscordRPCDLL.UpdatePresenceNative(ref discordRichPresenceData);
                }
                catch (Exception e)
                {
                    Console.Error.WriteLine(e);
                }
            }
        }

        /// <summary>
        /// Run callbacks
        /// </summary>
        public static void RunCallbacks()
        {
            if (isInitialized)
            {
                try
                {
                    DiscordRPCDLL.RunCallbacks();
                }
                catch (Exception e)
                {
                    Console.Error.WriteLine(e);
                }
            }
        }

        /// <summary>
        /// Clear presence
        /// </summary>
        public static void ClearPresence()
        {
            if (isInitialized)
            {
                try
                {
                    DiscordRPCDLL.ClearPresence();
                }
                catch (Exception e)
                {
                    Console.Error.WriteLine(e);
                }
            }
        }

        /// <summary>
        /// Respond
        /// </summary>
        /// <param name="userID">User ID</param>
        /// <param name="reply">Reply</param>
        public static void Respond(string userID, EReply reply)
        {
            if ((userID != null) && isInitialized)
            {
                try
                {
                    DiscordRPCDLL.Respond(userID, reply);
                }
                catch (Exception e)
                {
                    Console.Error.WriteLine(e);
                }
            }
        }

        /// <summary>
        /// Update callbacks
        /// </summary>
        private static void UpdateCallbacks()
        {
            try
            {
                DiscordRPCDLL.UpdateHandlers(ref discordRPCCallbacks);
            }
            catch (Exception e)
            {
                Console.Error.WriteLine(e);
            }
        }
    }
}
