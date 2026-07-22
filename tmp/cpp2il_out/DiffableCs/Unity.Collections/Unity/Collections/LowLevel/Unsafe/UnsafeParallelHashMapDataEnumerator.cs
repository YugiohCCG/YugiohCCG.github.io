namespace Unity.Collections.LowLevel.Unsafe;

internal struct UnsafeParallelHashMapDataEnumerator
{
	[NativeDisableUnsafePtrRestriction]
	internal UnsafeParallelHashMapData* m_Buffer; //Field offset: 0x0
	internal int m_Index; //Field offset: 0x8
	internal int m_BucketIndex; //Field offset: 0xC
	internal int m_NextIndex; //Field offset: 0x10

	[CallerCount(Count = 20)]
	[DeduplicatedMethod]
	internal UnsafeParallelHashMapDataEnumerator(UnsafeParallelHashMapData* data) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	internal KeyValue<TKey, TValue> GetCurrent() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 9)]
	[DeduplicatedMethod]
	internal TKey GetCurrentKey() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	internal bool MoveNext() { }

	[CallerCount(Count = 8)]
	[DeduplicatedMethod]
	internal void Reset() { }

}

