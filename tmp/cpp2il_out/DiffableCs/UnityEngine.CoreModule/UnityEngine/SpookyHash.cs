namespace UnityEngine;

internal static class SpookyHash
{
	private struct U
	{
		public Byte* p8; //Field offset: 0x0
		public UInt32* p32; //Field offset: 0x0
		public UInt64* p64; //Field offset: 0x0
		public ulong i; //Field offset: 0x0

		[CallerCount(Count = 26)]
		[DeduplicatedMethod]
		public U(UInt16* p8) { }

	}


	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SpookyHash), Member = "EndPartial", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64&), typeof(UInt64&), typeof(UInt64&), typeof(UInt64&), typeof(UInt64&), typeof(UInt64&), typeof(UInt64&), typeof(UInt64&), typeof(UInt64&), typeof(UInt64&), typeof(UInt64&), typeof(UInt64&)}, ReturnType = typeof(void))]
	private static void End(UInt64* data, ref ulong h0, ref ulong h1, ref ulong h2, ref ulong h3, ref ulong h4, ref ulong h5, ref ulong h6, ref ulong h7, ref ulong h8, ref ulong h9, ref ulong h10, ref ulong h11) { }

	[CalledBy(Type = typeof(SpookyHash), Member = "Hash", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(ulong), typeof(UInt64*), typeof(UInt64*)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SpookyHash), Member = "End", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64*), typeof(UInt64&), typeof(UInt64&), typeof(UInt64&), typeof(UInt64&), typeof(UInt64&), typeof(UInt64&), typeof(UInt64&), typeof(UInt64&), typeof(UInt64&), typeof(UInt64&), typeof(UInt64&), typeof(UInt64&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	private static void EndPartial(ref ulong h0, ref ulong h1, ref ulong h2, ref ulong h3, ref ulong h4, ref ulong h5, ref ulong h6, ref ulong h7, ref ulong h8, ref ulong h9, ref ulong h10, ref ulong h11) { }

	[CalledBy(Type = typeof(HashUtilities), Member = "AppendHash", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Hash128&), typeof(Hash128&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(HashUnsafeUtilities), Member = "ComputeHash128", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(ulong), typeof(UInt64*), typeof(UInt64*)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(HashUnsafeUtilities), Member = "ComputeHash128", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(ulong), typeof(Hash128*)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UnsafeUtility), Member = "MemCpy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(Void*), typeof(long)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UnsafeUtility), Member = "MemSet", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(byte), typeof(long)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SpookyHash), Member = "EndPartial", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64&), typeof(UInt64&), typeof(UInt64&), typeof(UInt64&), typeof(UInt64&), typeof(UInt64&), typeof(UInt64&), typeof(UInt64&), typeof(UInt64&), typeof(UInt64&), typeof(UInt64&), typeof(UInt64&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SpookyHash), Member = "Short", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(ulong), typeof(UInt64*), typeof(UInt64*)}, ReturnType = typeof(void))]
	[ContainsUnimplementedInstructions]
	public static void Hash(Void* message, ulong length, UInt64* hash1, UInt64* hash2) { }

	[CallerCount(Count = 0)]
	private static void Mix(UInt64* data, ref ulong s0, ref ulong s1, ref ulong s2, ref ulong s3, ref ulong s4, ref ulong s5, ref ulong s6, ref ulong s7, ref ulong s8, ref ulong s9, ref ulong s10, ref ulong s11) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	private static void Rot64(ref ulong x, int k) { }

	[CalledBy(Type = typeof(SpookyHash), Member = "Hash", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(ulong), typeof(UInt64*), typeof(UInt64*)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnsafeUtility), Member = "MemCpy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(Void*), typeof(long)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	private static void Short(Void* message, ulong length, UInt64* hash1, UInt64* hash2) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	private static void ShortEnd(ref ulong h0, ref ulong h1, ref ulong h2, ref ulong h3) { }

	[CallerCount(Count = 0)]
	private static void ShortMix(ref ulong h0, ref ulong h1, ref ulong h2, ref ulong h3) { }

}

