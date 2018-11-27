using System.Runtime.InteropServices;

/// <summary>
/// Discord RPC Sharp namespace
/// </summary>
namespace DiscordRPCSharp
{
    /// <summary>
    /// Ready delegate
    /// </summary>
    /// <param name="connectedUser">Connected user</param>
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void ReadyDelegate(ref UserData connectedUser);
}
