namespace Unity.Collections.LowLevel.Unsafe;

[DebuggerDisplay("Count = {Count()}, Capacity = {Capacity}, IsCreated = {IsCreated}, IsEmpty = {IsEmpty}")]
[DebuggerTypeProxy(typeof(UnsafeParallelHashMapDebuggerTypeProxy`2))]
[DefaultMember("Item")]
[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int), typeof(int)})]
public struct UnsafeParallelHashMap : INativeDisposable, IDisposable, IEnumerable<KeyValue`2<TKey, TValue>>, IEnumerable
{
	internal struct Enumerator : IEnumerator<KeyValue`2<TKey, TValue>>, IEnumerator, IDisposable
	{
		internal UnsafeParallelHashMapDataEnumerator m_Enumerator; //Field offset: 0x0

		public override KeyValue<TKey, TValue> Current
		{
			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			[DeduplicatedMethod]
			 get { } //Length: 79
		}

		private override object System.Collections.IEnumerator.Current
		{
			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 3)]
			[DeduplicatedMethod]
			private get { } //Length: 153
		}

		[CallerCount(Count = 13327)]
		[DeduplicatedMethod]
		public override void Dispose() { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		public override KeyValue<TKey, TValue> get_Current() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UnsafeParallelHashMapData), Member = "MoveNextSearch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnsafeParallelHashMapData*), typeof(Int32&), typeof(Int32&), typeof(Int32&)}, ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		public override bool MoveNext() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public override void Reset() { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 3)]
		[DeduplicatedMethod]
		private override object System.Collections.IEnumerator.get_Current() { }

	}

	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int), typeof(int)})]
	internal struct ParallelWriter
	{
		[NativeDisableUnsafePtrRestriction]
		internal UnsafeParallelHashMapData* m_Buffer; //Field offset: 0x0
		[NativeSetThreadIndex]
		internal int m_ThreadIndex; //Field offset: 0x0

		public int Capacity
		{
			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			[DeduplicatedMethod]
			[IsReadOnly]
			 get { } //Length: 25
		}

		public int ThreadIndex
		{
			[CallerCount(Count = 28)]
			[DeduplicatedMethod]
			 get { } //Length: 4
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UnsafeParallelHashMapBase`2), Member = "TryAddAtomic", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnsafeParallelHashMapData*), "TKey", "TValue", typeof(int)}, ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		public void Add(TKey key, TValue item) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UnsafeParallelHashMapBase`2), Member = "TryAddAtomic", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnsafeParallelHashMapData*), "TKey", "TValue", typeof(int)}, ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		public void Add(TKey key, TValue item, int threadIndexOverride) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[IsReadOnly]
		public int get_Capacity() { }

		[CallerCount(Count = 28)]
		[DeduplicatedMethod]
		public int get_ThreadIndex() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UnsafeParallelHashMapBase`2), Member = "TryAddAtomic", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnsafeParallelHashMapData*), "TKey", "TValue", typeof(int)}, ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		public bool TryAdd(TKey key, TValue item) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UnsafeParallelHashMapBase`2), Member = "TryAddAtomic", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnsafeParallelHashMapData*), "TKey", "TValue", typeof(int)}, ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		public bool TryAdd(TKey key, TValue item, int threadIndexOverride) { }

	}

	[DebuggerDisplay("Count = {m_HashMapData.Count()}, Capacity = {m_HashMapData.Capacity}, IsCreated = {m_HashMapData.IsCreated}, IsEmpty = {IsEmpty}")]
	[DefaultMember("Item")]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int), typeof(int)})]
	internal struct ReadOnly : IEnumerable<KeyValue`2<TKey, TValue>>, IEnumerable
	{
		internal UnsafeParallelHashMap<TKey, TValue> m_HashMapData; //Field offset: 0x0

		public int Capacity
		{
			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 2)]
			[DeduplicatedMethod]
			[IsReadOnly]
			 get { } //Length: 49
		}

		public bool IsCreated
		{
			[CallerCount(Count = 5)]
			[CallsUnknownMethods(Count = 1)]
			[ContainsUnimplementedInstructions]
			[DeduplicatedMethod]
			[IsReadOnly]
			 get { } //Length: 40
		}

		public bool IsEmpty
		{
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(UnsafeParallelHashMapData), Member = "IsEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnsafeParallelHashMapData*)}, ReturnType = typeof(bool))]
			[CallsUnknownMethods(Count = 4)]
			[DeduplicatedMethod]
			[IsReadOnly]
			 get { } //Length: 161
		}

		public TValue Item
		{
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(UnsafeParallelHashMap`2), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue&"}, ReturnType = typeof(bool))]
			[CallsUnknownMethods(Count = 1)]
			[DeduplicatedMethod]
			[IsReadOnly]
			 get { } //Length: 142
		}

		[CallerCount(Count = 9)]
		[DeduplicatedMethod]
		internal ReadOnly(UnsafeParallelHashMap<TKey, TValue> hashMapData) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UnsafeParallelHashMap`2), Member = "ContainsKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[IsReadOnly]
		public bool ContainsKey(TKey key) { }

		[CallerCount(Count = 2)]
		[Calls(Type = typeof(UnsafeParallelHashMap`2), Member = "Count", ReturnType = typeof(int))]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[IsReadOnly]
		public int Count() { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		[IsReadOnly]
		public int get_Capacity() { }

		[CallerCount(Count = 5)]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		[IsReadOnly]
		public bool get_IsCreated() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UnsafeParallelHashMapData), Member = "IsEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnsafeParallelHashMapData*)}, ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 4)]
		[DeduplicatedMethod]
		[IsReadOnly]
		public bool get_IsEmpty() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UnsafeParallelHashMap`2), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue&"}, ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[IsReadOnly]
		public TValue get_Item(TKey key) { }

		[CallerCount(Count = 4)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[IsReadOnly]
		public Enumerator<TKey, TValue> GetEnumerator() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UnsafeParallelHashMap`2), Member = "GetKeyArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AllocatorHandle)}, ReturnType = "Unity.Collections.NativeArray`1<TKey>")]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[IsReadOnly]
		public NativeArray<TKey> GetKeyArray(AllocatorHandle allocator) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UnsafeParallelHashMap`2), Member = "GetKeyValueArrays", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AllocatorHandle)}, ReturnType = "Unity.Collections.NativeKeyValueArrays`2<TKey, TValue>")]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[IsReadOnly]
		public NativeKeyValueArrays<TKey, TValue> GetKeyValueArrays(AllocatorHandle allocator) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UnsafeParallelHashMap`2), Member = "GetValueArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AllocatorHandle)}, ReturnType = "Unity.Collections.NativeArray`1<TValue>")]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[IsReadOnly]
		public NativeArray<TValue> GetValueArray(AllocatorHandle allocator) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(NotImplementedException), Member = ".ctor", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		private override IEnumerator<KeyValue`2<TKey, TValue>> System.Collections.Generic.IEnumerable<Unity.Collections.LowLevel.Unsafe.KeyValue<TKey,TValue>>.GetEnumerator() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(NotImplementedException), Member = ".ctor", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 5)]
		[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
		[Conditional("UNITY_DOTS_DEBUG")]
		[DeduplicatedMethod]
		[IsReadOnly]
		private void ThrowKeyNotPresent(TKey key) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UnsafeParallelHashMap`2), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue&"}, ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[IsReadOnly]
		public bool TryGetValue(TKey key, out TValue item) { }

	}

	public const int MaxCapacity = 1073741823; //Field offset: 0x0
	internal AllocatorHandle m_AllocatorLabel; //Field offset: 0x0
	[NativeDisableUnsafePtrRestriction]
	internal UnsafeParallelHashMapData* m_Buffer; //Field offset: 0x0

	public int Capacity
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[IsReadOnly]
		 get { } //Length: 25
		[CalledBy(Type = typeof(NativeParallelHashMap`2), Member = "set_Capacity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(UnsafeParallelHashMapData), Member = "GetBucketSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(long))]
		[Calls(Type = typeof(UnsafeParallelHashMapData), Member = "ReallocateHashMap", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnsafeParallelHashMapData*), typeof(int), typeof(long), typeof(AllocatorHandle)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 set { } //Length: 101
	}

	public bool IsCreated
	{
		[CallerCount(Count = 19)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		[IsReadOnly]
		 get { } //Length: 8
	}

	public bool IsEmpty
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UnsafeParallelHashMapData), Member = "IsEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnsafeParallelHashMapData*)}, ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[IsReadOnly]
		 get { } //Length: 56
	}

	public TValue Item
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UnsafeParallelHashMapBase`2), Member = "TryGetFirstValueAtomic", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnsafeParallelHashMapData*), "TKey", "TValue&", "Unity.Collections.NativeParallelMultiHashMapIterator`1<TKey>&"}, ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		 get { } //Length: 224
		[CalledBy(Type = typeof(NativeParallelHashMap`2), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue"}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(UnsafeParallelHashMapBase`2), Member = "TryGetFirstValueAtomic", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnsafeParallelHashMapData*), "TKey", "TValue&", "Unity.Collections.NativeParallelMultiHashMapIterator`1<TKey>&"}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(UnsafeParallelHashMapBase`2), Member = "TryAdd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnsafeParallelHashMapData*), "TKey", "TValue", typeof(bool), typeof(AllocatorHandle)}, ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 5)]
		[DeduplicatedMethod]
		 set { } //Length: 381
	}

	[CalledBy(Type = typeof(NativeParallelHashMap`2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(AllocatorHandle)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnsafeParallelHashMapData), Member = "AllocateHashMap", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(long), typeof(AllocatorHandle), typeof(UnsafeParallelHashMapData*&)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	public UnsafeParallelHashMap`2(int capacity, AllocatorHandle allocator) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnsafeParallelHashMapBase`2), Member = "TryAdd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnsafeParallelHashMapData*), "TKey", "TValue", typeof(bool), typeof(AllocatorHandle)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public void Add(TKey key, TValue item) { }

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public ParallelWriter<TKey, TValue> AsParallelWriter() { }

	[CallerCount(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public ReadOnly<TKey, TValue> AsReadOnly() { }

	[CalledBy(Type = typeof(NativeParallelHashMap`2), Member = "Clear", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnsafeUtility), Member = "MemSet", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(byte), typeof(long)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(JobsUtility), Member = "get_ThreadIndexCount", ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public void Clear() { }

	[CalledBy(Type = typeof(ReadOnly), Member = "ContainsKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(NativeParallelHashMap`2), Member = "ContainsKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ReadOnly), Member = "ContainsKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = typeof(bool))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UnsafeParallelHashMapBase`2), Member = "TryGetFirstValueAtomic", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnsafeParallelHashMapData*), "TKey", "TValue&", "Unity.Collections.NativeParallelMultiHashMapIterator`1<TKey>&"}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public bool ContainsKey(TKey key) { }

	[CalledBy(Type = typeof(ReadOnly), Member = "Count", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(NativeParallelHashMap`2), Member = "Count", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(ReadOnly), Member = "Count", ReturnType = typeof(int))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UnsafeParallelHashMapData), Member = "GetCount", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnsafeParallelHashMapData*)}, ReturnType = typeof(int))]
	[DeduplicatedMethod]
	[IsReadOnly]
	public int Count() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(IJobExtensions), Member = "Schedule", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnsafeParallelHashMapDisposeJob)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnsafeParallelHashMapDisposeJob), typeof(JobHandle)}, ReturnType = typeof(JobHandle))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public override JobHandle Dispose(JobHandle inputDeps) { }

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnsafeParallelHashMapData), Member = "DeallocateHashMap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnsafeParallelHashMapData*), typeof(AllocatorHandle)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public override void Dispose() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[IsReadOnly]
	public int get_Capacity() { }

	[CallerCount(Count = 19)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[IsReadOnly]
	public bool get_IsCreated() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnsafeParallelHashMapData), Member = "IsEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnsafeParallelHashMapData*)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[IsReadOnly]
	public bool get_IsEmpty() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnsafeParallelHashMapBase`2), Member = "TryGetFirstValueAtomic", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnsafeParallelHashMapData*), "TKey", "TValue&", "Unity.Collections.NativeParallelMultiHashMapIterator`1<TKey>&"}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public TValue get_Item(TKey key) { }

	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public Enumerator<TKey, TValue> GetEnumerator() { }

	[CalledBy(Type = typeof(ReadOnly), Member = "GetKeyArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AllocatorHandle)}, ReturnType = "Unity.Collections.NativeArray`1<TKey>")]
	[CalledBy(Type = typeof(NativeParallelHashMap`2), Member = "GetKeyArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AllocatorHandle)}, ReturnType = "Unity.Collections.NativeArray`1<TKey>")]
	[CalledBy(Type = typeof(ReadOnly), Member = "GetKeyArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AllocatorHandle)}, ReturnType = "Unity.Collections.NativeArray`1<TKey>")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UnsafeParallelHashMapData), Member = "GetCount", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnsafeParallelHashMapData*)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CollectionHelper), Member = "CreateNativeArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.DrawKey"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(AllocatorHandle), typeof(NativeArrayOptions)}, ReturnType = typeof(Unity.Collections.NativeArray`1<UnityEngine.Rendering.DrawKey>))]
	[Calls(Type = typeof(UnsafeParallelHashMapData), Member = "GetKeyArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnsafeParallelHashMapData*), "Unity.Collections.NativeArray`1<TKey>"}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public NativeArray<TKey> GetKeyArray(AllocatorHandle allocator) { }

	[CalledBy(Type = typeof(ReadOnly), Member = "GetKeyValueArrays", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AllocatorHandle)}, ReturnType = "Unity.Collections.NativeKeyValueArrays`2<TKey, TValue>")]
	[CalledBy(Type = typeof(NativeParallelHashMap`2), Member = "GetKeyValueArrays", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AllocatorHandle)}, ReturnType = "Unity.Collections.NativeKeyValueArrays`2<TKey, TValue>")]
	[CalledBy(Type = typeof(ReadOnly), Member = "GetKeyValueArrays", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AllocatorHandle)}, ReturnType = "Unity.Collections.NativeKeyValueArrays`2<TKey, TValue>")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UnsafeParallelHashMapData), Member = "GetCount", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnsafeParallelHashMapData*)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(NativeKeyValueArrays`2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(AllocatorHandle), typeof(NativeArrayOptions)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UnsafeParallelHashMapData), Member = "GetKeyValueArrays", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnsafeParallelHashMapData*), "Unity.Collections.NativeKeyValueArrays`2<TKey, TValue>"}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public NativeKeyValueArrays<TKey, TValue> GetKeyValueArrays(AllocatorHandle allocator) { }

	[CalledBy(Type = typeof(ReadOnly), Member = "GetValueArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AllocatorHandle)}, ReturnType = "Unity.Collections.NativeArray`1<TValue>")]
	[CalledBy(Type = typeof(NativeParallelHashMap`2), Member = "GetValueArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AllocatorHandle)}, ReturnType = "Unity.Collections.NativeArray`1<TValue>")]
	[CalledBy(Type = typeof(ReadOnly), Member = "GetValueArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AllocatorHandle)}, ReturnType = "Unity.Collections.NativeArray`1<TValue>")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UnsafeParallelHashMapData), Member = "GetCount", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnsafeParallelHashMapData*)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CollectionHelper), Member = "CreateNativeArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(AllocatorHandle), typeof(NativeArrayOptions)}, ReturnType = "Unity.Collections.NativeArray`1<T>")]
	[Calls(Type = typeof(UnsafeParallelHashMapData), Member = "GetValueArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnsafeParallelHashMapData*), typeof(Unity.Collections.NativeArray`1<System.Int32>)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public NativeArray<TValue> GetValueArray(AllocatorHandle allocator) { }

	[CalledBy(Type = typeof(NativeParallelHashMap`2), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnsafeParallelHashMapBase`2), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnsafeParallelHashMapData*), "TKey", typeof(bool)}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public bool Remove(TKey key) { }

	[CalledBy(Type = typeof(NativeParallelHashMap`2), Member = "set_Capacity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnsafeParallelHashMapData), Member = "GetBucketSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(long))]
	[Calls(Type = typeof(UnsafeParallelHashMapData), Member = "ReallocateHashMap", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnsafeParallelHashMapData*), typeof(int), typeof(long), typeof(AllocatorHandle)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public void set_Capacity(int value) { }

	[CalledBy(Type = typeof(NativeParallelHashMap`2), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue"}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnsafeParallelHashMapBase`2), Member = "TryGetFirstValueAtomic", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnsafeParallelHashMapData*), "TKey", "TValue&", "Unity.Collections.NativeParallelMultiHashMapIterator`1<TKey>&"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(UnsafeParallelHashMapBase`2), Member = "TryAdd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnsafeParallelHashMapData*), "TKey", "TValue", typeof(bool), typeof(AllocatorHandle)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 5)]
	[DeduplicatedMethod]
	public void set_Item(TKey key, TValue value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NotImplementedException), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	private override IEnumerator<KeyValue`2<TKey, TValue>> System.Collections.Generic.IEnumerable<Unity.Collections.LowLevel.Unsafe.KeyValue<TKey,TValue>>.GetEnumerator() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NotImplementedException), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 9)]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	[Conditional("UNITY_DOTS_DEBUG")]
	[DeduplicatedMethod]
	private void ThrowAtMaxCapacity() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	[Conditional("UNITY_DOTS_DEBUG")]
	[DeduplicatedMethod]
	internal static void ThrowKeyAlreadyAdded(in TKey key) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnsafeParallelHashMapBase`2), Member = "TryAdd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnsafeParallelHashMapData*), "TKey", "TValue", typeof(bool), typeof(AllocatorHandle)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public bool TryAdd(TKey key, TValue item) { }

	[CalledBy(Type = typeof(ReadOnly), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue&"}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ReadOnly), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = "TValue")]
	[CalledBy(Type = typeof(NativeParallelHashMap`2), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue&"}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(NativeParallelHashMap`2), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = "TValue")]
	[CalledBy(Type = typeof(ReadOnly), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue&"}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ReadOnly), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = "TValue")]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(UnsafeParallelHashMapBase`2), Member = "TryGetFirstValueAtomic", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnsafeParallelHashMapData*), "TKey", "TValue&", "Unity.Collections.NativeParallelMultiHashMapIterator`1<TKey>&"}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public bool TryGetValue(TKey key, out TValue item) { }

}

