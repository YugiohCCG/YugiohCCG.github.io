namespace Unity.Collections.LowLevel.Unsafe;

[DebuggerTypeProxy(typeof(UnsafeHashMapDebuggerTypeProxy`2))]
[DefaultMember("Item")]
[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int), typeof(int)})]
public struct UnsafeHashMap : INativeDisposable, IDisposable, IEnumerable<KVPair`2<TKey, TValue>>, IEnumerable
{
	internal struct Enumerator : IEnumerator<KVPair`2<TKey, TValue>>, IEnumerator, IDisposable
	{
		internal Enumerator<TKey> m_Enumerator; //Field offset: 0x0

		public override KVPair<TKey, TValue> Current
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
		public override KVPair<TKey, TValue> get_Current() { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		public override bool MoveNext() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		public override void Reset() { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 3)]
		[DeduplicatedMethod]
		private override object System.Collections.IEnumerator.get_Current() { }

	}

	[DefaultMember("Item")]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int), typeof(int)})]
	internal struct ReadOnly : IEnumerable<KVPair`2<TKey, TValue>>, IEnumerable
	{
		[NativeDisableUnsafePtrRestriction]
		internal HashMapHelper<TKey> m_Data; //Field offset: 0x0

		public int Capacity
		{
			[CallerCount(Count = 9)]
			[DeduplicatedMethod]
			[IsReadOnly]
			 get { } //Length: 4
		}

		public int Count
		{
			[CallerCount(Count = 2)]
			[DeduplicatedMethod]
			[IsReadOnly]
			 get { } //Length: 4
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
			[CallsUnknownMethods(Count = 2)]
			[ContainsUnimplementedInstructions]
			[DeduplicatedMethod]
			[IsReadOnly]
			 get { } //Length: 86
		}

		public TValue Item
		{
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(HashMapHelper`1), Member = "TryGetValue", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue&"}, ReturnType = typeof(bool))]
			[CallsUnknownMethods(Count = 1)]
			[DeduplicatedMethod]
			[IsReadOnly]
			 get { } //Length: 110
		}

		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		internal ReadOnly(ref HashMapHelper<TKey>& data) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(HashMapHelper`1), Member = "Find", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = typeof(int))]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		[IsReadOnly]
		public bool ContainsKey(TKey key) { }

		[CallerCount(Count = 9)]
		[DeduplicatedMethod]
		[IsReadOnly]
		public int get_Capacity() { }

		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		[IsReadOnly]
		public int get_Count() { }

		[CallerCount(Count = 5)]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		[IsReadOnly]
		public bool get_IsCreated() { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		[IsReadOnly]
		public bool get_IsEmpty() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(HashMapHelper`1), Member = "TryGetValue", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue&"}, ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[IsReadOnly]
		public TValue get_Item(TKey key) { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[IsReadOnly]
		public Enumerator<TKey, TValue> GetEnumerator() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(HashMapHelper`1), Member = "GetKeyArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AllocatorHandle)}, ReturnType = "Unity.Collections.NativeArray`1<TKey>")]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[IsReadOnly]
		public NativeArray<TKey> GetKeyArray(AllocatorHandle allocator) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(HashMapHelper`1), Member = "GetKeyValueArrays", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AllocatorHandle)}, ReturnType = "Unity.Collections.NativeKeyValueArrays`2<TKey, TValue>")]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[IsReadOnly]
		public NativeKeyValueArrays<TKey, TValue> GetKeyValueArrays(AllocatorHandle allocator) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(HashMapHelper`1), Member = "GetValueArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AllocatorHandle)}, ReturnType = "Unity.Collections.NativeArray`1<TValue>")]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[IsReadOnly]
		public NativeArray<TValue> GetValueArray(AllocatorHandle allocator) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(NotImplementedException), Member = ".ctor", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		private override IEnumerator<KVPair`2<TKey, TValue>> System.Collections.Generic.IEnumerable<Unity.Collections.KVPair<TKey,TValue>>.GetEnumerator() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(NotImplementedException), Member = ".ctor", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(HashMapHelper`1), Member = "TryGetValue", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue&"}, ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[IsReadOnly]
		public bool TryGetValue(TKey key, out TValue item) { }

	}

	public const int MaxCapacity = 536870912; //Field offset: 0x0
	[NativeDisableUnsafePtrRestriction]
	internal HashMapHelper<TKey> m_Data; //Field offset: 0x0

	public int Capacity
	{
		[CallerCount(Count = 9)]
		[DeduplicatedMethod]
		[IsReadOnly]
		 get { } //Length: 4
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(HashMapHelper`1), Member = "Resize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 set { } //Length: 67
	}

	public int Count
	{
		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		[IsReadOnly]
		 get { } //Length: 4
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
		[CallsUnknownMethods(Count = 2)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		[IsReadOnly]
		 get { } //Length: 86
	}

	public TValue Item
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(HashMapHelper`1), Member = "TryGetValue", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue&"}, ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 88
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(HashMapHelper`1), Member = "Find", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = typeof(int))]
		[CallsUnknownMethods(Count = 4)]
		[DeduplicatedMethod]
		 set { } //Length: 171
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(HashMapHelper`1), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(AllocatorHandle)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public UnsafeHashMap`2(int initialCapacity, AllocatorHandle allocator) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(HashMapHelper`1), Member = "TryAdd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey&"}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	public void Add(TKey key, TValue item) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public ReadOnly<TKey, TValue> AsReadOnly() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(HashMapHelper`1), Member = "Clear", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public void Clear() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(HashMapHelper`1), Member = "Find", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public bool ContainsKey(TKey key) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(HashMapHelper`1), Member = "Dispose", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	public override void Dispose() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(IJobExtensions), Member = "Schedule", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnsafeDisposeJob)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnsafeDisposeJob), typeof(JobHandle)}, ReturnType = typeof(JobHandle))]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public override JobHandle Dispose(JobHandle inputDeps) { }

	[CallerCount(Count = 9)]
	[DeduplicatedMethod]
	[IsReadOnly]
	public int get_Capacity() { }

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	[IsReadOnly]
	public int get_Count() { }

	[CallerCount(Count = 5)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[IsReadOnly]
	public bool get_IsCreated() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[IsReadOnly]
	public bool get_IsEmpty() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(HashMapHelper`1), Member = "TryGetValue", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue&"}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public TValue get_Item(TKey key) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public Enumerator<TKey, TValue> GetEnumerator() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(HashMapHelper`1), Member = "GetKeyArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AllocatorHandle)}, ReturnType = "Unity.Collections.NativeArray`1<TKey>")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public NativeArray<TKey> GetKeyArray(AllocatorHandle allocator) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(HashMapHelper`1), Member = "GetKeyValueArrays", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AllocatorHandle)}, ReturnType = "Unity.Collections.NativeKeyValueArrays`2<TKey, TValue>")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public NativeKeyValueArrays<TKey, TValue> GetKeyValueArrays(AllocatorHandle allocator) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(HashMapHelper`1), Member = "GetValueArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AllocatorHandle)}, ReturnType = "Unity.Collections.NativeArray`1<TValue>")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public NativeArray<TValue> GetValueArray(AllocatorHandle allocator) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(HashMapHelper`1), Member = "TryRemove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public bool Remove(TKey key) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(HashMapHelper`1), Member = "Resize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public void set_Capacity(int value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(HashMapHelper`1), Member = "Find", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 4)]
	[DeduplicatedMethod]
	public void set_Item(TKey key, TValue value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NotImplementedException), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	private override IEnumerator<KVPair`2<TKey, TValue>> System.Collections.Generic.IEnumerable<Unity.Collections.KVPair<TKey,TValue>>.GetEnumerator() { }

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
	private void ThrowKeyAlreadyAdded(TKey key) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	[Conditional("UNITY_DOTS_DEBUG")]
	[DeduplicatedMethod]
	private void ThrowKeyNotPresent(TKey key) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(HashMapHelper`1), Member = "TrimExcess", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public void TrimExcess() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(HashMapHelper`1), Member = "TryAdd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey&"}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public bool TryAdd(TKey key, TValue item) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(HashMapHelper`1), Member = "TryGetValue", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue&"}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public bool TryGetValue(TKey key, out TValue item) { }

}

