namespace Unity.Collections.LowLevel.Unsafe;

[GenerateTestsForBurstCompatibility]
internal struct UnsafeParallelHashMapData
{
	internal const int kMaxCapacity = 1073741823; //Field offset: 0x0
	private const int kFirstFreeTLSOffset = 64; //Field offset: 0x0
	internal const int IntsPerCacheLine = 16; //Field offset: 0x0
	internal Byte* values; //Field offset: 0x0
	internal Byte* keys; //Field offset: 0x8
	internal Byte* next; //Field offset: 0x10
	internal Byte* buckets; //Field offset: 0x18
	internal int keyCapacity; //Field offset: 0x20
	internal int bucketCapacityMask; //Field offset: 0x24
	internal int allocatedIndexLength; //Field offset: 0x28

	internal Int32* firstFreeTLS
	{
		[CallerCount(Count = 35)]
		[DeduplicatedMethod]
		internal get { } //Length: 5
	}

	[CalledBy(Type = typeof(UnsafeParallelHashMap`2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(AllocatorHandle)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UnsafeParallelMultiHashMap`2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(AllocatorHandle)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(JobsUtility), Member = "get_ThreadIndexCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(Unmanaged), Member = "Allocate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(int), typeof(AllocatorHandle)}, ReturnType = typeof(Void*))]
	[Calls(Type = typeof(CollectionHelper), Member = "Align", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(int)}, ReturnType = typeof(long))]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int), typeof(int)})]
	internal static void AllocateHashMap(int length, long bucketLength, AllocatorHandle label, out UnsafeParallelHashMapData* outBuf) { }

	[CalledBy(Type = typeof(UnsafeParallelHashMapData), Member = "ReallocateHashMap", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnsafeParallelHashMapData*), typeof(int), typeof(long), typeof(AllocatorHandle)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CollectionHelper), Member = "Align", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(int)}, ReturnType = typeof(long))]
	[DeduplicatedMethod]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int), typeof(int)})]
	internal static long CalculateDataSize(int length, long bucketLength, out long keyOffset, out long nextOffset, out long bucketOffset) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	[Conditional("UNITY_DOTS_DEBUG")]
	private static void CheckCapacity(int capacity) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	[Conditional("UNITY_DOTS_DEBUG")]
	private static void CheckHashMapReallocateDoesNotShrink(UnsafeParallelHashMapData* data, int newCapacity) { }

	[CalledBy(Type = typeof(UnsafeParallelHashMap`2), Member = "Dispose", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UnsafeParallelMultiHashMap`2), Member = "Dispose", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Unmanaged), Member = "Free", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(AllocatorHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Unmanaged), Member = "Free", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnsafeParallelHashMapData)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnsafeParallelHashMapData*), typeof(AllocatorHandle)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	internal static void DeallocateHashMap(UnsafeParallelHashMapData* data, AllocatorHandle allocator) { }

	[CallerCount(Count = 35)]
	[DeduplicatedMethod]
	internal Int32* get_firstFreeTLS() { }

	[CalledBy(Type = typeof(NativeParallelHashMapExtensions), Member = "GetUnsafeBucketData", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Collections.NativeParallelHashMap`2<TKey, TValue>"}, ReturnType = typeof(UnsafeParallelHashMapBucketData))]
	[CalledBy(Type = typeof(NativeParallelHashMapExtensions), Member = "GetUnsafeBucketData", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Collections.NativeParallelMultiHashMap`2<TKey, TValue>"}, ReturnType = typeof(UnsafeParallelHashMapBucketData))]
	[CallerCount(Count = 2)]
	internal UnsafeParallelHashMapBucketData GetBucketData() { }

	[CalledBy(Type = typeof(UnsafeParallelHashMapBase`2), Member = "TryAdd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnsafeParallelHashMapData*), "TKey", "TValue", typeof(bool), typeof(AllocatorHandle)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(UnsafeParallelHashMap`2), Member = "set_Capacity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UnsafeParallelMultiHashMap`2), Member = "set_Capacity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	internal static long GetBucketSize(int capacity) { }

	[CalledBy(Type = typeof(UnsafeParallelHashMap`2), Member = "Count", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(UnsafeParallelHashMap`2), Member = "GetKeyArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AllocatorHandle)}, ReturnType = "Unity.Collections.NativeArray`1<TKey>")]
	[CalledBy(Type = typeof(UnsafeParallelHashMap`2), Member = "GetValueArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AllocatorHandle)}, ReturnType = "Unity.Collections.NativeArray`1<TValue>")]
	[CalledBy(Type = typeof(UnsafeParallelHashMap`2), Member = "GetKeyValueArrays", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AllocatorHandle)}, ReturnType = "Unity.Collections.NativeKeyValueArrays`2<TKey, TValue>")]
	[CalledBy(Type = typeof(UnsafeParallelMultiHashMap`2), Member = "Count", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(UnsafeParallelMultiHashMap`2), Member = "GetKeyArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AllocatorHandle)}, ReturnType = "Unity.Collections.NativeArray`1<TKey>")]
	[CalledBy(Type = typeof(UnsafeParallelMultiHashMap`2), Member = "GetValueArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AllocatorHandle)}, ReturnType = "Unity.Collections.NativeArray`1<TValue>")]
	[CalledBy(Type = typeof(UnsafeParallelMultiHashMap`2), Member = "GetKeyValueArrays", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AllocatorHandle)}, ReturnType = "Unity.Collections.NativeKeyValueArrays`2<TKey, TValue>")]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(JobsUtility), Member = "get_ThreadIndexCount", ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 1)]
	internal static int GetCount(UnsafeParallelHashMapData* data) { }

	[CalledBy(Type = typeof(UnsafeParallelHashMap`2), Member = "GetKeyArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AllocatorHandle)}, ReturnType = "Unity.Collections.NativeArray`1<TKey>")]
	[CalledBy(Type = typeof(UnsafeParallelMultiHashMap`2), Member = "GetKeyArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AllocatorHandle)}, ReturnType = "Unity.Collections.NativeArray`1<TKey>")]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int)})]
	internal static void GetKeyArray(UnsafeParallelHashMapData* data, NativeArray<TKey> result) { }

	[CalledBy(Type = typeof(UnsafeParallelHashMap`2), Member = "GetKeyValueArrays", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AllocatorHandle)}, ReturnType = "Unity.Collections.NativeKeyValueArrays`2<TKey, TValue>")]
	[CalledBy(Type = typeof(UnsafeParallelMultiHashMap`2), Member = "GetKeyValueArrays", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AllocatorHandle)}, ReturnType = "Unity.Collections.NativeKeyValueArrays`2<TKey, TValue>")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int), typeof(int)})]
	internal static void GetKeyValueArrays(UnsafeParallelHashMapData* data, NativeKeyValueArrays<TKey, TValue> result) { }

	[CalledBy(Type = typeof(UnsafeParallelMultiHashMap`2), Member = "GetValueArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AllocatorHandle)}, ReturnType = "Unity.Collections.NativeArray`1<TValue>")]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int)})]
	internal static void GetValueArray(UnsafeParallelHashMapData* data, NativeArray<TValue> result) { }

	[CalledBy(Type = typeof(UnsafeParallelHashMapBase`2), Member = "TryAdd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnsafeParallelHashMapData*), "TKey", "TValue", typeof(bool), typeof(AllocatorHandle)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	internal static int GrowCapacity(int capacity) { }

	[CalledBy(Type = typeof(ReadOnly), Member = "get_IsEmpty", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(NativeParallelHashMap`2), Member = "get_IsEmpty", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ReadOnly), Member = "get_IsEmpty", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(NativeParallelMultiHashMap`2), Member = "get_IsEmpty", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ReadOnly), Member = "get_IsEmpty", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(UnsafeParallelHashMap`2), Member = "get_IsEmpty", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ReadOnly), Member = "get_IsEmpty", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(UnsafeParallelMultiHashMap`2), Member = "get_IsEmpty", ReturnType = typeof(bool))]
	[CallerCount(Count = 8)]
	[CallsUnknownMethods(Count = 1)]
	internal static bool IsEmpty(UnsafeParallelHashMapData* data) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	internal static bool MoveNext(UnsafeParallelHashMapData* data, ref int bucketIndex, ref int nextIndex, out int index) { }

	[CalledBy(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(KeyValueEnumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(KeyValueEnumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.Rendering.InstanceCullingBatcher", Member = "Dispose", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.InstanceCullingBatcher", Member = "UpdateInstanceDataBufferLayoutVersion", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.InstanceCullingBatcher", Member = "OnPerformCulling", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BatchRendererGroup), typeof(BatchCullingContext), typeof(BatchCullingOutput), typeof(IntPtr)}, ReturnType = typeof(JobHandle))]
	[CalledBy(Type = "UnityEngine.Rendering.OcclusionCullingCommon", Member = "UpdateOccluderStats", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.DebugRendererBatcherStats"}, ReturnType = typeof(void))]
	[CallerCount(Count = 10)]
	[CallsUnknownMethods(Count = 1)]
	internal static bool MoveNextSearch(UnsafeParallelHashMapData* data, ref int bucketIndex, ref int nextIndex, out int index) { }

	[CalledBy(Type = typeof(UnsafeParallelHashMapBase`2), Member = "TryAdd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnsafeParallelHashMapData*), "TKey", "TValue", typeof(bool), typeof(AllocatorHandle)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(UnsafeParallelHashMap`2), Member = "set_Capacity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UnsafeParallelMultiHashMap`2), Member = "set_Capacity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnsafeParallelHashMapData), Member = "CalculateDataSize", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(long), typeof(Int64&), typeof(Int64&), typeof(Int64&)}, ReturnType = typeof(long))]
	[Calls(Type = typeof(Unmanaged), Member = "Allocate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(int), typeof(AllocatorHandle)}, ReturnType = typeof(Void*))]
	[Calls(Type = typeof(UnsafeUtility), Member = "MemCpy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(Void*), typeof(long)}, ReturnType = typeof(void))]
	[Calls(Type = "UnityEngine.Rendering.DrawKey", Member = "GetHashCode", ReturnType = typeof(int))]
	[Calls(Type = typeof(Unmanaged), Member = "Free", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(AllocatorHandle)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int), typeof(int)})]
	internal static void ReallocateHashMap(UnsafeParallelHashMapData* data, int newCapacity, long newBucketCapacity, AllocatorHandle label) { }

}

