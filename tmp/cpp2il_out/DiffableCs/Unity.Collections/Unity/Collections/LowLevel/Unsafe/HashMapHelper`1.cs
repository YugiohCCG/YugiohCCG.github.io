namespace Unity.Collections.LowLevel.Unsafe;

[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int)})]
internal struct HashMapHelper
{
	public struct Enumerator
	{
		[NativeDisableUnsafePtrRestriction]
		internal HashMapHelper<TKey>* m_Data; //Field offset: 0x0
		internal int m_Index; //Field offset: 0x0
		internal int m_BucketIndex; //Field offset: 0x0
		internal int m_NextIndex; //Field offset: 0x0

		[CallerCount(Count = 20)]
		[DeduplicatedMethod]
		internal Enumerator(HashMapHelper<TKey>* data) { }

		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		internal KVPair<TKey, TValue> GetCurrent() { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		internal TKey GetCurrentKey() { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		internal bool MoveNext() { }

		[CallerCount(Count = 8)]
		[DeduplicatedMethod]
		internal void Reset() { }

	}

	internal const int kMinCapacity = 256; //Field offset: 0x0
	internal const int kMaxCapacity = 536870912; //Field offset: 0x0
	[NativeDisableUnsafePtrRestriction]
	internal Byte* Ptr; //Field offset: 0x0
	[NativeDisableUnsafePtrRestriction]
	internal TKey* Keys; //Field offset: 0x0
	[NativeDisableUnsafePtrRestriction]
	internal Int32* Next; //Field offset: 0x0
	[NativeDisableUnsafePtrRestriction]
	internal Int32* Buckets; //Field offset: 0x0
	internal int Count; //Field offset: 0x0
	internal int Capacity; //Field offset: 0x0
	internal int Log2MinGrowth; //Field offset: 0x0
	internal int BucketCapacity; //Field offset: 0x0
	internal int AllocatedIndex; //Field offset: 0x0
	internal int FirstFreeIdx; //Field offset: 0x0
	internal int SizeOfTValue; //Field offset: 0x0
	internal AllocatorHandle Allocator; //Field offset: 0x0

	internal bool IsCreated
	{
		[CallerCount(Count = 19)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		[IsReadOnly]
		internal get { } //Length: 8
	}

	internal bool IsEmpty
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		[IsReadOnly]
		internal get { } //Length: 54
	}

	[CalledBy(Type = typeof(NativeHashMap`2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(AllocatorHandle)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NativeHashSet`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(AllocatorHandle)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Unmanaged), Member = "Allocate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(int), typeof(AllocatorHandle)}, ReturnType = typeof(Void*))]
	[Calls(Type = typeof(HashMapHelper`1), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(AllocatorHandle)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	internal static HashMapHelper<TKey>* Alloc(int capacity, int sizeOfValueT, int minGrowth, AllocatorHandle allocator) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	internal int CalcCapacityCeilPow2(int capacity) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	internal static long CalculateDataSize(int capacity, int bucketCapacity, int sizeOfTValue, out long outKeyOffset, out long outNextOffset, out long outBucketOffset) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	[Conditional("UNITY_DOTS_DEBUG")]
	[DeduplicatedMethod]
	private static void CheckCapacity(int capacity) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	[Conditional("UNITY_DOTS_DEBUG")]
	[DeduplicatedMethod]
	private void CheckIndexOutOfBounds(int idx) { }

	[CalledBy(Type = typeof(NativeHashMap`2), Member = "Clear", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NativeHashSet`1), Member = "Clear", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UnsafeHashMap`2), Member = "Clear", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UnsafeUtility), Member = "MemSet", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(byte), typeof(long)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	internal void Clear() { }

	[CalledBy(Type = typeof(UnsafeHashMap`2), Member = "Dispose", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Unmanaged), Member = "Free", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(AllocatorHandle)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	internal void Dispose() { }

	[CalledBy(Type = typeof(ReadOnly), Member = "ContainsKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(NativeHashMap`2), Member = "ContainsKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(NativeHashMap`2), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ReadOnly), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(NativeHashSet`1), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(HashMapHelper`1), Member = "TryGetValue", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue&"}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ReadOnly), Member = "ContainsKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(UnsafeHashMap`2), Member = "ContainsKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(UnsafeHashMap`2), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue"}, ReturnType = typeof(void))]
	[CallerCount(Count = 9)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	[DeduplicatedMethod]
	internal int Find(TKey key) { }

	[CalledBy(Type = typeof(NativeHashMapDispose), Member = "Dispose", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NativeHashMapDisposeJob), Member = "Execute", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NativeHashMap`2), Member = "Dispose", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NativeHashSet`1), Member = "Dispose", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Unmanaged), Member = "Free", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(AllocatorHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Unmanaged), Member = "Free", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T*", typeof(AllocatorHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	[DeduplicatedMethod]
	internal static void Free(HashMapHelper<TKey>* data) { }

	[CallerCount(Count = 19)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[IsReadOnly]
	internal bool get_IsCreated() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[IsReadOnly]
	internal bool get_IsEmpty() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	private int GetBucket(in TKey key) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	internal static int GetBucketSize(int capacity) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[IsReadOnly]
	internal int GetCount() { }

	[CalledBy(Type = typeof(ReadOnly), Member = "GetKeyArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AllocatorHandle)}, ReturnType = "Unity.Collections.NativeArray`1<TKey>")]
	[CalledBy(Type = typeof(NativeHashMap`2), Member = "GetKeyArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AllocatorHandle)}, ReturnType = "Unity.Collections.NativeArray`1<TKey>")]
	[CalledBy(Type = typeof(ReadOnly), Member = "ToNativeArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AllocatorHandle)}, ReturnType = "Unity.Collections.NativeArray`1<T>")]
	[CalledBy(Type = typeof(NativeHashSet`1), Member = "ToNativeArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AllocatorHandle)}, ReturnType = "Unity.Collections.NativeArray`1<T>")]
	[CalledBy(Type = typeof(ReadOnly), Member = "GetKeyArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AllocatorHandle)}, ReturnType = "Unity.Collections.NativeArray`1<TKey>")]
	[CalledBy(Type = typeof(UnsafeHashMap`2), Member = "GetKeyArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AllocatorHandle)}, ReturnType = "Unity.Collections.NativeArray`1<TKey>")]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CollectionHelper), Member = "CreateNativeArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(AllocatorHandle), typeof(NativeArrayOptions)}, ReturnType = "Unity.Collections.NativeArray`1<T>")]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	internal NativeArray<TKey> GetKeyArray(AllocatorHandle allocator) { }

	[CalledBy(Type = typeof(ReadOnly), Member = "GetKeyValueArrays", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AllocatorHandle)}, ReturnType = "Unity.Collections.NativeKeyValueArrays`2<TKey, TValue>")]
	[CalledBy(Type = typeof(NativeHashMap`2), Member = "GetKeyValueArrays", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AllocatorHandle)}, ReturnType = "Unity.Collections.NativeKeyValueArrays`2<TKey, TValue>")]
	[CalledBy(Type = typeof(ReadOnly), Member = "GetKeyValueArrays", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AllocatorHandle)}, ReturnType = "Unity.Collections.NativeKeyValueArrays`2<TKey, TValue>")]
	[CalledBy(Type = typeof(UnsafeHashMap`2), Member = "GetKeyValueArrays", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AllocatorHandle)}, ReturnType = "Unity.Collections.NativeKeyValueArrays`2<TKey, TValue>")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(NativeKeyValueArrays`2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(AllocatorHandle), typeof(NativeArrayOptions)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int)})]
	internal NativeKeyValueArrays<TKey, TValue> GetKeyValueArrays(AllocatorHandle allocator) { }

	[CalledBy(Type = typeof(ReadOnly), Member = "GetValueArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AllocatorHandle)}, ReturnType = "Unity.Collections.NativeArray`1<TValue>")]
	[CalledBy(Type = typeof(NativeHashMap`2), Member = "GetValueArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AllocatorHandle)}, ReturnType = "Unity.Collections.NativeArray`1<TValue>")]
	[CalledBy(Type = typeof(ReadOnly), Member = "GetValueArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AllocatorHandle)}, ReturnType = "Unity.Collections.NativeArray`1<TValue>")]
	[CalledBy(Type = typeof(UnsafeHashMap`2), Member = "GetValueArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AllocatorHandle)}, ReturnType = "Unity.Collections.NativeArray`1<TValue>")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CollectionHelper), Member = "CreateNativeArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(AllocatorHandle), typeof(NativeArrayOptions)}, ReturnType = "Unity.Collections.NativeArray`1<T>")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int)})]
	internal NativeArray<TValue> GetValueArray(AllocatorHandle allocator) { }

	[CalledBy(Type = typeof(HashMapHelper`1), Member = "Alloc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(AllocatorHandle)}, ReturnType = "Unity.Collections.LowLevel.Unsafe.HashMapHelper`1<TKey>*")]
	[CalledBy(Type = typeof(UnsafeHashMap`2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(AllocatorHandle)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Unmanaged), Member = "Allocate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(int), typeof(AllocatorHandle)}, ReturnType = typeof(Void*))]
	[Calls(Type = typeof(UnsafeUtility), Member = "MemSet", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(byte), typeof(long)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	internal void Init(int capacity, int sizeOfValueT, int minGrowth, AllocatorHandle allocator) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	internal bool MoveNext(ref int bucketIndex, ref int nextIndex, out int index) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	internal bool MoveNextSearch(ref int bucketIndex, ref int nextIndex, out int index) { }

	[CalledBy(Type = typeof(NativeHashMap`2), Member = "set_Capacity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NativeHashSet`1), Member = "set_Capacity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UnsafeHashMap`2), Member = "set_Capacity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(HashMapHelper`1), Member = "ResizeExact", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	internal void Resize(int newCapacity) { }

	[CalledBy(Type = typeof(HashMapHelper`1), Member = "Resize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(HashMapHelper`1), Member = "TrimExcess", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Unmanaged), Member = "Allocate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(int), typeof(AllocatorHandle)}, ReturnType = typeof(Void*))]
	[Calls(Type = typeof(UnsafeUtility), Member = "MemSet", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(byte), typeof(long)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(HashMapHelper`1), Member = "TryAdd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey&"}, ReturnType = typeof(int))]
	[Calls(Type = typeof(UnsafeUtility), Member = "MemCpy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(Void*), typeof(long)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Unmanaged), Member = "Free", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(AllocatorHandle)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	internal void ResizeExact(int newCapacity, int newBucketCapacity) { }

	[CalledBy(Type = typeof(NativeHashMap`2), Member = "TrimExcess", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NativeHashSet`1), Member = "TrimExcess", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UnsafeHashMap`2), Member = "TrimExcess", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(HashMapHelper`1), Member = "ResizeExact", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	internal void TrimExcess() { }

	[CalledBy(Type = typeof(NativeHashMap`2), Member = "TryAdd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue"}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(NativeHashMap`2), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NativeHashSet`1), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(HashMapHelper`1), Member = "ResizeExact", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UnsafeHashMap`2), Member = "TryAdd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue"}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(UnsafeHashMap`2), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue"}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 8)]
	[DeduplicatedMethod]
	internal int TryAdd(in TKey key) { }

	[CalledBy(Type = typeof(ReadOnly), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue&"}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ReadOnly), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = "TValue")]
	[CalledBy(Type = typeof(NativeHashMap`2), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue&"}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(NativeHashMap`2), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = "TValue")]
	[CalledBy(Type = typeof(ReadOnly), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue&"}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ReadOnly), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = "TValue")]
	[CalledBy(Type = typeof(UnsafeHashMap`2), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue&"}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(UnsafeHashMap`2), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = "TValue")]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(HashMapHelper`1), Member = "Find", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int)})]
	internal bool TryGetValue(TKey key, out TValue item) { }

	[CalledBy(Type = typeof(NativeHashMap`2), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(NativeHashSet`1), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(UnsafeHashMap`2), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = typeof(bool))]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	[DeduplicatedMethod]
	internal int TryRemove(TKey key) { }

}

