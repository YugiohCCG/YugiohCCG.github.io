namespace Unity.Collections.LowLevel.Unsafe;

[DebuggerTypeProxy(typeof(UnsafeParallelMultiHashMapDebuggerTypeProxy`2))]
[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int), typeof(int)})]
public struct UnsafeParallelMultiHashMap : INativeDisposable, IDisposable, IEnumerable<KeyValue`2<TKey, TValue>>, IEnumerable
{
	internal struct Enumerator : IEnumerator<TValue>, IEnumerator, IDisposable
	{
		internal UnsafeParallelMultiHashMap<TKey, TValue> hashmap; //Field offset: 0x0
		internal TKey key; //Field offset: 0x0
		internal bool isFirst; //Field offset: 0x0
		private TValue value; //Field offset: 0x0
		private NativeParallelMultiHashMapIterator<TKey> iterator; //Field offset: 0x0

		public override TValue Current
		{
			[CallerCount(Count = 7)]
			[DeduplicatedMethod]
			 get { } //Length: 4
		}

		private override object System.Collections.IEnumerator.Current
		{
			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 2)]
			[DeduplicatedMethod]
			private get { } //Length: 94
		}

		[CallerCount(Count = 13327)]
		[DeduplicatedMethod]
		public override void Dispose() { }

		[CallerCount(Count = 7)]
		[DeduplicatedMethod]
		public override TValue get_Current() { }

		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		public Enumerator<TKey, TValue> GetEnumerator() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UnsafeParallelMultiHashMap`2), Member = "TryGetNextValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TValue&", "Unity.Collections.NativeParallelMultiHashMapIterator`1<TKey>&"}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(UnsafeParallelMultiHashMap`2), Member = "TryGetFirstValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue&", "Unity.Collections.NativeParallelMultiHashMapIterator`1<TKey>&"}, ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		public override bool MoveNext() { }

		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		public override void Reset() { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		private override object System.Collections.IEnumerator.get_Current() { }

	}

	internal struct KeyValueEnumerator : IEnumerator<KeyValue`2<TKey, TValue>>, IEnumerator, IDisposable
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

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UnsafeParallelHashMapBase`2), Member = "AddAtomicMulti", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnsafeParallelHashMapData*), "TKey", "TValue", typeof(int)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		public void Add(TKey key, TValue item) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UnsafeParallelHashMapBase`2), Member = "AddAtomicMulti", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnsafeParallelHashMapData*), "TKey", "TValue", typeof(int)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		public void Add(TKey key, TValue item, int threadIndexOverride) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[IsReadOnly]
		public int get_Capacity() { }

	}

	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int), typeof(int)})]
	internal struct ReadOnly : IEnumerable<KeyValue`2<TKey, TValue>>, IEnumerable
	{
		internal UnsafeParallelMultiHashMap<TKey, TValue> m_MultiHashMapData; //Field offset: 0x0

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

		[CallerCount(Count = 9)]
		[DeduplicatedMethod]
		internal ReadOnly(UnsafeParallelMultiHashMap<TKey, TValue> container) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UnsafeParallelMultiHashMap`2), Member = "ContainsKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[IsReadOnly]
		public bool ContainsKey(TKey key) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UnsafeParallelMultiHashMap`2), Member = "Count", ReturnType = typeof(int))]
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

		[CallerCount(Count = 4)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public KeyValueEnumerator<TKey, TValue> GetEnumerator() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UnsafeParallelMultiHashMap`2), Member = "GetKeyArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AllocatorHandle)}, ReturnType = "Unity.Collections.NativeArray`1<TKey>")]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[IsReadOnly]
		public NativeArray<TKey> GetKeyArray(AllocatorHandle allocator) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UnsafeParallelMultiHashMap`2), Member = "GetKeyValueArrays", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AllocatorHandle)}, ReturnType = "Unity.Collections.NativeKeyValueArrays`2<TKey, TValue>")]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[IsReadOnly]
		public NativeKeyValueArrays<TKey, TValue> GetKeyValueArrays(AllocatorHandle allocator) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UnsafeParallelMultiHashMap`2), Member = "GetValueArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AllocatorHandle)}, ReturnType = "Unity.Collections.NativeArray`1<TValue>")]
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
		[Calls(Type = typeof(UnsafeParallelMultiHashMap`2), Member = "TryGetFirstValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue&", "Unity.Collections.NativeParallelMultiHashMapIterator`1<TKey>&"}, ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[IsReadOnly]
		public bool TryGetFirstValue(TKey key, out TValue item, out NativeParallelMultiHashMapIterator<TKey>& it) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UnsafeParallelMultiHashMap`2), Member = "TryGetNextValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TValue&", "Unity.Collections.NativeParallelMultiHashMapIterator`1<TKey>&"}, ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[IsReadOnly]
		public bool TryGetNextValue(out TValue item, ref NativeParallelMultiHashMapIterator<TKey>& it) { }

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

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnsafeParallelHashMapData), Member = "AllocateHashMap", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(long), typeof(AllocatorHandle), typeof(UnsafeParallelHashMapData*&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UnsafeParallelHashMapBase`2), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnsafeParallelHashMapData*)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	public UnsafeParallelMultiHashMap`2(int capacity, AllocatorHandle allocator) { }

	[CalledBy(Type = typeof(NativeParallelMultiHashMap`2), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue"}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnsafeParallelHashMapBase`2), Member = "TryAdd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnsafeParallelHashMapData*), "TKey", "TValue", typeof(bool), typeof(AllocatorHandle)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public void Add(TKey key, TValue item) { }

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public ParallelWriter<TKey, TValue> AsParallelWriter() { }

	[CallerCount(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public ReadOnly<TKey, TValue> AsReadOnly() { }

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnsafeParallelHashMapBase`2), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnsafeParallelHashMapData*)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public void Clear() { }

	[CalledBy(Type = typeof(ReadOnly), Member = "ContainsKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ReadOnly), Member = "ContainsKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnsafeParallelHashMapBase`2), Member = "TryGetFirstValueAtomic", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnsafeParallelHashMapData*), "TKey", "TValue&", "Unity.Collections.NativeParallelMultiHashMapIterator`1<TKey>&"}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	[IsReadOnly]
	public bool ContainsKey(TKey key) { }

	[CalledBy(Type = typeof(ReadOnly), Member = "Count", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(NativeParallelMultiHashMap`2), Member = "Count", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(ReadOnly), Member = "Count", ReturnType = typeof(int))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UnsafeParallelHashMapData), Member = "GetCount", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnsafeParallelHashMapData*)}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[IsReadOnly]
	public int Count() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnsafeParallelHashMapBase`2), Member = "TryGetFirstValueAtomic", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnsafeParallelHashMapData*), "TKey", "TValue&", "Unity.Collections.NativeParallelMultiHashMapIterator`1<TKey>&"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(UnsafeParallelHashMapBase`2), Member = "TryGetNextValueAtomic", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnsafeParallelHashMapData*), "TValue&", "Unity.Collections.NativeParallelMultiHashMapIterator`1<TKey>&"}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 4)]
	[DeduplicatedMethod]
	[IsReadOnly]
	public int CountValuesForKey(TKey key) { }

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

	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public KeyValueEnumerator<TKey, TValue> GetEnumerator() { }

	[CalledBy(Type = typeof(ReadOnly), Member = "GetKeyArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AllocatorHandle)}, ReturnType = "Unity.Collections.NativeArray`1<TKey>")]
	[CalledBy(Type = typeof(NativeParallelMultiHashMap`2), Member = "GetKeyArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AllocatorHandle)}, ReturnType = "Unity.Collections.NativeArray`1<TKey>")]
	[CalledBy(Type = typeof(ReadOnly), Member = "GetKeyArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AllocatorHandle)}, ReturnType = "Unity.Collections.NativeArray`1<TKey>")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UnsafeParallelHashMapData), Member = "GetCount", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnsafeParallelHashMapData*)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CollectionHelper), Member = "CreateNativeArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(AllocatorHandle), typeof(NativeArrayOptions)}, ReturnType = "Unity.Collections.NativeArray`1<T>")]
	[Calls(Type = typeof(UnsafeParallelHashMapData), Member = "GetKeyArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnsafeParallelHashMapData*), "Unity.Collections.NativeArray`1<TKey>"}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	[DeduplicatedMethod]
	[IsReadOnly]
	public NativeArray<TKey> GetKeyArray(AllocatorHandle allocator) { }

	[CalledBy(Type = typeof(ReadOnly), Member = "GetKeyValueArrays", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AllocatorHandle)}, ReturnType = "Unity.Collections.NativeKeyValueArrays`2<TKey, TValue>")]
	[CalledBy(Type = typeof(NativeParallelMultiHashMap`2), Member = "GetKeyValueArrays", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AllocatorHandle)}, ReturnType = "Unity.Collections.NativeKeyValueArrays`2<TKey, TValue>")]
	[CalledBy(Type = typeof(ReadOnly), Member = "GetKeyValueArrays", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AllocatorHandle)}, ReturnType = "Unity.Collections.NativeKeyValueArrays`2<TKey, TValue>")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UnsafeParallelHashMapData), Member = "GetCount", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnsafeParallelHashMapData*)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(NativeKeyValueArrays`2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(AllocatorHandle), typeof(NativeArrayOptions)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UnsafeParallelHashMapData), Member = "GetKeyValueArrays", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnsafeParallelHashMapData*), "Unity.Collections.NativeKeyValueArrays`2<TKey, TValue>"}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	[DeduplicatedMethod]
	[IsReadOnly]
	public NativeKeyValueArrays<TKey, TValue> GetKeyValueArrays(AllocatorHandle allocator) { }

	[CalledBy(Type = typeof(ReadOnly), Member = "GetValueArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AllocatorHandle)}, ReturnType = "Unity.Collections.NativeArray`1<TValue>")]
	[CalledBy(Type = typeof(NativeParallelMultiHashMap`2), Member = "GetValueArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AllocatorHandle)}, ReturnType = "Unity.Collections.NativeArray`1<TValue>")]
	[CalledBy(Type = typeof(ReadOnly), Member = "GetValueArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AllocatorHandle)}, ReturnType = "Unity.Collections.NativeArray`1<TValue>")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UnsafeParallelHashMapData), Member = "GetCount", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnsafeParallelHashMapData*)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CollectionHelper), Member = "CreateNativeArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(AllocatorHandle), typeof(NativeArrayOptions)}, ReturnType = "Unity.Collections.NativeArray`1<T>")]
	[Calls(Type = typeof(UnsafeParallelHashMapData), Member = "GetValueArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnsafeParallelHashMapData*), "Unity.Collections.NativeArray`1<TValue>"}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	[DeduplicatedMethod]
	[IsReadOnly]
	public NativeArray<TValue> GetValueArray(AllocatorHandle allocator) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public Enumerator<TKey, TValue> GetValuesForKey(TKey key) { }

	[CalledBy(Type = typeof(NativeParallelMultiHashMap`2), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Collections.NativeParallelMultiHashMapIterator`1<TKey>"}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnsafeParallelHashMapBase`2), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnsafeParallelHashMapData*), "Unity.Collections.NativeParallelMultiHashMapIterator`1<TKey>"}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public void Remove(NativeParallelMultiHashMapIterator<TKey> it) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	[DeduplicatedMethod]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int)})]
	public void Remove(TKey key, TValueEQ value) { }

	[CalledBy(Type = typeof(NativeParallelMultiHashMap`2), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnsafeParallelHashMapBase`2), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnsafeParallelHashMapData*), "TKey", typeof(bool)}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public int Remove(TKey key) { }

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnsafeParallelHashMapData), Member = "GetBucketSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(long))]
	[Calls(Type = typeof(UnsafeParallelHashMapData), Member = "ReallocateHashMap", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnsafeParallelHashMapData*), typeof(int), typeof(long), typeof(AllocatorHandle)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public void set_Capacity(int value) { }

	[CalledBy(Type = typeof(NativeParallelMultiHashMap`2), Member = "SetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TValue", "Unity.Collections.NativeParallelMultiHashMapIterator`1<TKey>"}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnsafeParallelHashMapBase`2), Member = "SetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnsafeParallelHashMapData*), "Unity.Collections.NativeParallelMultiHashMapIterator`1<TKey>&", "TValue&"}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public bool SetValue(TValue item, NativeParallelMultiHashMapIterator<TKey> it) { }

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

	[CalledBy(Type = typeof(ReadOnly), Member = "TryGetFirstValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue&", "Unity.Collections.NativeParallelMultiHashMapIterator`1<TKey>&"}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(NativeParallelMultiHashMap`2), Member = "TryGetFirstValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue&", "Unity.Collections.NativeParallelMultiHashMapIterator`1<TKey>&"}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(NativeParallelMultiHashMap`2), Member = "ContainsKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(NativeParallelMultiHashMap`2), Member = "CountValuesForKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ReadOnly), Member = "TryGetFirstValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue&", "Unity.Collections.NativeParallelMultiHashMapIterator`1<TKey>&"}, ReturnType = typeof(bool))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(UnsafeParallelHashMapBase`2), Member = "TryGetFirstValueAtomic", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnsafeParallelHashMapData*), "TKey", "TValue&", "Unity.Collections.NativeParallelMultiHashMapIterator`1<TKey>&"}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[IsReadOnly]
	public bool TryGetFirstValue(TKey key, out TValue item, out NativeParallelMultiHashMapIterator<TKey>& it) { }

	[CalledBy(Type = typeof(ReadOnly), Member = "TryGetNextValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TValue&", "Unity.Collections.NativeParallelMultiHashMapIterator`1<TKey>&"}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(NativeParallelMultiHashMap`2), Member = "TryGetNextValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TValue&", "Unity.Collections.NativeParallelMultiHashMapIterator`1<TKey>&"}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(NativeParallelMultiHashMap`2), Member = "CountValuesForKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ReadOnly), Member = "TryGetNextValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TValue&", "Unity.Collections.NativeParallelMultiHashMapIterator`1<TKey>&"}, ReturnType = typeof(bool))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(UnsafeParallelHashMapBase`2), Member = "TryGetNextValueAtomic", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnsafeParallelHashMapData*), "TValue&", "Unity.Collections.NativeParallelMultiHashMapIterator`1<TKey>&"}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[IsReadOnly]
	public bool TryGetNextValue(out TValue item, ref NativeParallelMultiHashMapIterator<TKey>& it) { }

}

