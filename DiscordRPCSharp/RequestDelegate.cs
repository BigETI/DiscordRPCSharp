using System.Runtime.InteropServices;

/// <summary>
/// Discord RPC Sharp namespace
/// </summary>
namespace DiscordRPCSharp
{
    /// <summary>
    /// Request delegate
    /// </summary>
    /// <param name="request">Request</param>
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void RequestDelegate(ref UserData request);
}
