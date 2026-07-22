namespace Unity.Collections;

[GenerateTestsForBurstCompatibility]
[NativeContainer]
internal struct NativeHashMapDispose
{
	[NativeDisableUnsafePtrRestriction]
	internal UnsafeHashMap<Int32, Int32>* m_HashMapData; //Field offset: 0x0
	internal AllocatorHandle m_Allocator; //Field offset: 0x8

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(HashMapHelper`1), Member = "Free", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Collections.LowLevel.Unsafe.HashMapHelper`1<TKey>*"}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	internal void Dispose() { }

}

