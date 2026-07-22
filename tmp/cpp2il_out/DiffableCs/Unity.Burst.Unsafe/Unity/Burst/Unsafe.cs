namespace Unity.Burst;

internal static class Unsafe
{

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[NonVersionable]
	public static T Add(ref T source, IntPtr elementOffset) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[NonVersionable]
	public static Void* Add(Void* source, int elementOffset) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[NonVersionable]
	public static T Add(ref T source, int elementOffset) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[NonVersionable]
	public static T AddByteOffset(ref T source, IntPtr byteOffset) { }

	[CallerCount(Count = 1987)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[NonVersionable]
	public static bool AreSame(ref T left, ref T right) { }

	[CallerCount(Count = 2063)]
	[DeduplicatedMethod]
	[NonVersionable]
	public static TTo As(ref TFrom source) { }

	[CallerCount(Count = 2063)]
	[DeduplicatedMethod]
	[NonVersionable]
	public static T As(object o) { }

	[CallerCount(Count = 2063)]
	[DeduplicatedMethod]
	[NonVersionable]
	public static Void* AsPointer(ref T value) { }

	[CallerCount(Count = 2063)]
	[DeduplicatedMethod]
	[NonVersionable]
	public static T AsRef(ref T source) { }

	[CallerCount(Count = 2063)]
	[DeduplicatedMethod]
	[NonVersionable]
	public static T AsRef(Void* source) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[NonVersionable]
	public static IntPtr ByteOffset(ref T origin, ref T target) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 6)]
	[DeduplicatedMethod]
	[NonVersionable]
	public static void Copy(Void* destination, ref T source) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 6)]
	[DeduplicatedMethod]
	[NonVersionable]
	public static void Copy(ref T destination, Void* source) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[NonVersionable]
	public static void CopyBlock(Void* destination, Void* source, uint byteCount) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[NonVersionable]
	public static void CopyBlock(ref byte destination, ref byte source, uint byteCount) { }

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
	public static void InitBlock(Void* startAddress, byte value, uint byteCount) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[NonVersionable]
	public static void InitBlock(ref byte startAddress, byte value, uint byteCount) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[NonVersionable]
	public static void InitBlockUnaligned(Void* startAddress, byte value, uint byteCount) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[NonVersionable]
	public static void InitBlockUnaligned(ref byte startAddress, byte value, uint byteCount) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[NonVersionable]
	public static bool IsAddressGreaterThan(ref T left, ref T right) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[NonVersionable]
	public static bool IsAddressLessThan(ref T left, ref T right) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 4)]
	[DeduplicatedMethod]
	[NonVersionable]
	public static T Read(Void* source) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 4)]
	[DeduplicatedMethod]
	[NonVersionable]
	public static T ReadUnaligned(ref byte source) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 4)]
	[DeduplicatedMethod]
	[NonVersionable]
	public static T ReadUnaligned(Void* source) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[NonVersionable]
	public static int SizeOf() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[NonVersionable]
	public static T Subtract(ref T source, int elementOffset) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[NonVersionable]
	public static Void* Subtract(Void* source, int elementOffset) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[NonVersionable]
	public static T Subtract(ref T source, IntPtr elementOffset) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[NonVersionable]
	public static T SubtractByteOffset(ref T source, IntPtr byteOffset) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 4)]
	[DeduplicatedMethod]
	[NonVersionable]
	public static T Unbox(object box) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(Vector`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[Calls(Type = typeof(Vector`1), Member = "ScalarEquals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", "T"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Vector`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 22)]
	[CallsUnknownMethods(Count = 192)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[NonVersionable]
	public static void Write(Void* destination, T value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(Vector`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[Calls(Type = typeof(Vector`1), Member = "ScalarEquals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", "T"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Vector`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 22)]
	[CallsUnknownMethods(Count = 192)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[NonVersionable]
	public static void WriteUnaligned(ref byte destination, T value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(Vector`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[Calls(Type = typeof(Vector`1), Member = "ScalarEquals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", "T"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Vector`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 22)]
	[CallsUnknownMethods(Count = 192)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[NonVersionable]
	public static void WriteUnaligned(Void* destination, T value) { }

}

