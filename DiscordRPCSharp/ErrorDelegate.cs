using System.Runtime.InteropServices;

/// <summary>
/// Discord RPC Sharp namespace
/// </summary>
namespace DiscordRPCSharp
{
    /// <summary>
    /// Error delegate
    /// </summary>
    /// <param name="errorCode">Error code</param>
    /// <param name="message">Message</param>
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void ErrorDelegate(int errorCode, string message);
}
