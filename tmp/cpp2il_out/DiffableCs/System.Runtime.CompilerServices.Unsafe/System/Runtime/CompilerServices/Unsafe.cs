namespace System.Runtime.CompilerServices;

public static class Unsafe
{

	[CallerCount(Count = 2063)]
	[DeduplicatedMethod]
	[NonVersionable]
	public static TTo As(ref TFrom source) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[NonVersionable]
	public static void CopyBlockUnaligned(Void* destination, Void* source, uint byteCount) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[NonVersionable]
	public static void CopyBlockUnaligned(ref byte destination, ref byte source, uint byteCount) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[NonVersionable]
	public static void InitBlockUnaligned(Void* startAddress, byte value, uint byteCount) { }

	[CallerCount(Count = 173)]
	[DeduplicatedMethod]
	[NonVersionable]
	public static T ReadUnaligned(Void* source) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[NonVersionable]
	public static int SizeOf() { }

	[CallerCount(Count = 26)]
	[DeduplicatedMethod]
	[NonVersionable]
	public static void WriteUnaligned(Void* destination, T value) { }

}

