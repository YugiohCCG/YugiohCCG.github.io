namespace System.Runtime.CompilerServices;

internal static class Unsafe
{

	[CallerCount(Count = 7)]
	[DeduplicatedMethod]
	public static T Add(ref T source, int elementOffset) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public static T Add(ref T source, IntPtr elementOffset) { }

	[CallerCount(Count = 68)]
	[DeduplicatedMethod]
	public static Void* Add(Void* source, int elementOffset) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	internal static T AddByteOffset(ref T source, ulong byteOffset) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public static T AddByteOffset(ref T source, IntPtr byteOffset) { }

	[CallerCount(Count = 1987)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public static bool AreSame(ref T left, ref T right) { }

	[CallerCount(Count = 2063)]
	[DeduplicatedMethod]
	public static T As(object o) { }

	[CallerCount(Count = 2063)]
	[DeduplicatedMethod]
	public static TTo As(ref TFrom source) { }

	[CallerCount(Count = 2063)]
	[DeduplicatedMethod]
	public static Void* AsPointer(ref T value) { }

	[CallerCount(Count = 2063)]
	[DeduplicatedMethod]
	public static T AsRef(in T source) { }

	[CallerCount(Count = 2063)]
	[DeduplicatedMethod]
	public static T AsRef(Void* source) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public static void InitBlockUnaligned(ref byte startAddress, byte value, uint byteCount) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public static bool IsAddressLessThan(ref T left, ref T right) { }

	[CallerCount(Count = 18)]
	[DeduplicatedMethod]
	public static T Read(Void* source) { }

	[CallerCount(Count = 18)]
	[DeduplicatedMethod]
	public static T ReadUnaligned(ref byte source) { }

	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	public static int SizeOf() { }

	[CallerCount(Count = 11)]
	[DeduplicatedMethod]
	public static void WriteUnaligned(ref byte destination, T value) { }

}

