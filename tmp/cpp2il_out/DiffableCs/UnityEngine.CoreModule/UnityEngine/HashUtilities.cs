namespace UnityEngine;

public static class HashUtilities
{

	[CalledBy(Type = "UnityEngine.Rendering.CoreUnsafeUtils", Member = "CombineHashes", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue", "TGetter"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), "System.Void*", "UnityEngine.Hash128*"}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SpookyHash), Member = "Hash", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(ulong), typeof(UInt64*), typeof(UInt64*)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public static void AppendHash(ref Hash128 inHash, ref Hash128 outHash) { }

}

