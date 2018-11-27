using System.Runtime.InteropServices;

/// <summary>
/// Discord RPC Sharp namespace
/// </summary>
namespace DiscordRPCSharp
{
    /// <summary>
    /// Spectate delegate
    /// </summary>
    /// <param name="secret">Secret</param>
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void SpectateDelegate(string secret);
}
