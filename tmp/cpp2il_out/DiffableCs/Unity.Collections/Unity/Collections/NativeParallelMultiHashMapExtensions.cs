namespace Unity.Collections;

[Extension]
[GenerateTestsForBurstCompatibility]
public static class NativeParallelMultiHashMapExtensions
{

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	[DeduplicatedMethod]
	[Extension]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int), typeof(int), typeof(AllocatorHandle)})]
	internal static void Initialize(ref NativeParallelMultiHashMap<TKey, TValue>& container, int capacity, ref U allocator) { }

}

