namespace Mono.Nat;

internal static class BufferHelpers
{
	private const int Size = 8192; //Field offset: 0x0

	[CalledBy(Type = "Mono.Nat.Upnp.UpnpNatDevice+<DecodeMessageFromResponse>d__24", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	internal static void Release(Byte[] buffer) { }

	[CalledBy(Type = "Mono.Nat.Upnp.UpnpNatDevice+<DecodeMessageFromResponse>d__24", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	internal static Byte[] Rent() { }

}

