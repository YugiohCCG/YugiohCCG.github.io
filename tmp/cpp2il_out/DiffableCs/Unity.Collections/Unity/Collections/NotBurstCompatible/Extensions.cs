namespace Unity.Collections.NotBurstCompatible;

[Extension]
public static class Extensions
{

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	[ExcludeFromBurstCompatTesting("Takes managed array")]
	[Extension]
	public static void CopyFromNBC(NativeList<T> list, T[] array) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AllocatorHandle), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Allocator)}, ReturnType = typeof(AllocatorHandle))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[ExcludeFromBurstCompatTesting("Returns managed array")]
	[Extension]
	public static T[] ToArray(NativeHashSet<T> set) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AllocatorHandle), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Allocator)}, ReturnType = typeof(AllocatorHandle))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[ExcludeFromBurstCompatTesting("Returns managed array")]
	[Extension]
	public static T[] ToArray(NativeParallelHashSet<T> set) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[ExcludeFromBurstCompatTesting("Returns managed array")]
	[Extension]
	public static T[] ToArrayNBC(NativeList<T> list) { }

}

