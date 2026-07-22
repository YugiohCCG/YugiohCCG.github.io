namespace Unity.Collections;

[Extension]
public static class ListExtensions
{

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	[Extension]
	public static void RemoveAtSwapBack(List<T> list, int index) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	[DeduplicatedMethod]
	[Extension]
	public static bool RemoveSwapBack(List<T> list, T value) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	[Extension]
	public static bool RemoveSwapBack(List<T> list, Predicate<T> matcher) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	[Extension]
	public static NativeArray<T> ToNativeArray(List<T> list, AllocatorHandle allocator) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	[Extension]
	public static NativeList<T> ToNativeList(List<T> list, AllocatorHandle allocator) { }

}

