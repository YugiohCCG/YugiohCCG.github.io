namespace Unity.Collections;

[Extension]
[GenerateTestsForBurstCompatibility]
public static class NativeParallelHashMapExtensions
{

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Extension]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int), typeof(int)})]
	public static ValueTuple<NativeArray`1<TKey>, Int32> GetUniqueKeyArray(UnsafeParallelMultiHashMap<TKey, TValue> container, AllocatorHandle allocator) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Extension]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int), typeof(int)})]
	public static ValueTuple<NativeArray`1<TKey>, Int32> GetUniqueKeyArray(NativeParallelMultiHashMap<TKey, TValue> container, AllocatorHandle allocator) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnsafeParallelHashMapData), Member = "GetBucketData", ReturnType = typeof(UnsafeParallelHashMapBucketData))]
	[DeduplicatedMethod]
	[Extension]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int), typeof(int)})]
	public static UnsafeParallelHashMapBucketData GetUnsafeBucketData(NativeParallelHashMap<TKey, TValue> container) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnsafeParallelHashMapData), Member = "GetBucketData", ReturnType = typeof(UnsafeParallelHashMapBucketData))]
	[DeduplicatedMethod]
	[Extension]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int), typeof(int)})]
	public static UnsafeParallelHashMapBucketData GetUnsafeBucketData(NativeParallelMultiHashMap<TKey, TValue> container) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	[DeduplicatedMethod]
	[Extension]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int), typeof(int)})]
	public static void Remove(NativeParallelMultiHashMap<TKey, TValue> container, TKey key, TValue value) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 10)]
	[DeduplicatedMethod]
	[Extension]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int)})]
	public static int Unique(NativeArray<T> array) { }

}

