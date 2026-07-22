namespace UnityEngine.Rendering;

internal static class MemoryUtilities
{

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnsafeUtility), Member = "Free", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(Allocator)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	public static void Free(T* p, Allocator allocator) { }

	[CalledBy(Type = typeof(PrefixSumDrawsAndInstances), Member = "Execute", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnsafeUtility), Member = "AlignOf", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(int))]
	[Calls(Type = typeof(UnsafeUtility), Member = "Malloc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(int), typeof(Allocator)}, ReturnType = typeof(Void*))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public static T* Malloc(int count, Allocator allocator) { }

}

