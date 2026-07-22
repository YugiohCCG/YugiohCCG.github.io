namespace System.Runtime;

public static class RuntimeImports
{

	[CalledBy(Type = typeof(Number), Member = "DoubleToNumber", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double), typeof(int), typeof(NumberBuffer&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	internal static void _ecvt_s(Byte* buffer, int sizeInBytes, double value, int count, Int32* dec, Int32* sign) { }

	[CalledBy(Type = typeof(Buffer), Member = "MemoryCopy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(Void*), typeof(long), typeof(long)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Buffer), Member = "Memmove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(Byte*), typeof(uint)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	internal static void Memmove(Byte* dest, Byte* src, uint len) { }

	[CalledBy(Type = typeof(Buffer), Member = "Memmove", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", "T&", typeof(ulong)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	internal static void Memmove_wbarrier(Byte* dest, Byte* src, uint len, IntPtr type_handle) { }

	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	internal static void RhZeroMemory(ref byte b, ulong byteLength) { }

	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	private static void ZeroMemory(Void* p, uint byteLength) { }

}

