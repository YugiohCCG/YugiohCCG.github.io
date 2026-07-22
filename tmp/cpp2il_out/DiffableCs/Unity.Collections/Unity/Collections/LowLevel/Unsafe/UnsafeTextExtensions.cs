namespace Unity.Collections.LowLevel.Unsafe;

[Extension]
internal static class UnsafeTextExtensions
{

	[CallerCount(Count = 0)]
	[Extension]
	public static UnsafeList<Byte>& AsUnsafeListOfBytes(ref UnsafeText text) { }

	[CallerCount(Count = 0)]
	[Extension]
	public static UnsafeList<Byte> AsUnsafeListOfBytesRO(UnsafeText text) { }

}

