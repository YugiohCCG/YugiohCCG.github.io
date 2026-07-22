namespace UnityEngine;

public static class HashUnsafeUtilities
{

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SpookyHash), Member = "Hash", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(ulong), typeof(UInt64*), typeof(UInt64*)}, ReturnType = typeof(void))]
	public static void ComputeHash128(Void* data, ulong dataSize, UInt64* hash1, UInt64* hash2) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SpookyHash), Member = "Hash", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(ulong), typeof(UInt64*), typeof(UInt64*)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public static void ComputeHash128(Void* data, ulong dataSize, Hash128* hash) { }

}

