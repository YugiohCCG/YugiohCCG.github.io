namespace System.Collections.Concurrent;

[DebuggerDisplay("Count = {Count}")]
[DebuggerTypeProxy(typeof(IDictionaryDebugView`2))]
[DefaultMember("Item")]
public class ConcurrentDictionary : IDictionary<TKey, TValue>, ICollection<KeyValuePair`2<TKey, TValue>>, IEnumerable<KeyValuePair`2<TKey, TValue>>, IEnumerable, IDictionary, ICollection, IReadOnlyDictionary<TKey, TValue>, IReadOnlyCollection<KeyValuePair`2<TKey, TValue>>
{
	[CompilerGenerated]
	private sealed class <GetEnumerator>d__35 : IEnumerator<KeyValuePair`2<TKey, TValue>>, IDisposable, IEnumerator
	{
		private int <>1__state; //Field offset: 0x0
		private KeyValuePair<TKey, TValue> <>2__current; //Field offset: 0x0
		public ConcurrentDictionary<TKey, TValue> <>4__this; //Field offset: 0x0
		private Node<TKey, TValue>[] <buckets>5__2; //Field offset: 0x0
		private int <i>5__3; //Field offset: 0x0
		private Node<TKey, TValue> <current>5__4; //Field offset: 0x0

		private override KeyValuePair<TKey, TValue> System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Current
		{
			[CallerCount(Count = 0)]
			[DebuggerHidden]
			[DeduplicatedMethod]
			private get { } //Length: 21
		}

		private override object System.Collections.IEnumerator.Current
		{
			[CallerCount(Count = 0)]
			[DebuggerHidden]
			[DeduplicatedMethod]
			private get { } //Length: 54
		}

		[CallerCount(Count = 36)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		public <GetEnumerator>d__35(int <>1__state) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(KeyValuePair`2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue"}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 9)]
		[DeduplicatedMethod]
		private override bool MoveNext() { }

		[CallerCount(Count = 0)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		private override KeyValuePair<TKey, TValue> System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_Current() { }

		[CallerCount(Count = 0)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		private override object System.Collections.IEnumerator.get_Current() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 2)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		private override void System.Collections.IEnumerator.Reset() { }

		[CallerCount(Count = 13327)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		private override void System.IDisposable.Dispose() { }

	}

	private sealed class DictionaryEnumerator : IDictionaryEnumerator, IEnumerator
	{
		private IEnumerator<KeyValuePair`2<TKey, TValue>> _enumerator; //Field offset: 0x0

		public override object Current
		{
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(DictionaryEnumerator), Member = "get_Entry", ReturnType = typeof(DictionaryEntry))]
			[DeduplicatedMethod]
			 get { } //Length: 111
		}

		public override DictionaryEntry Entry
		{
			[CalledBy(Type = typeof(DictionaryEnumerator), Member = "get_Current", ReturnType = typeof(object))]
			[CallerCount(Count = 1)]
			[CallsDeduplicatedMethods(Count = 3)]
			[CallsUnknownMethods(Count = 5)]
			[DeduplicatedMethod]
			 get { } //Length: 401
		}

		public override object Key
		{
			[CallerCount(Count = 0)]
			[CallsDeduplicatedMethods(Count = 1)]
			[CallsUnknownMethods(Count = 3)]
			[DeduplicatedMethod]
			 get { } //Length: 217
		}

		public override object Value
		{
			[CallerCount(Count = 0)]
			[CallsDeduplicatedMethods(Count = 1)]
			[CallsUnknownMethods(Count = 3)]
			[DeduplicatedMethod]
			 get { } //Length: 167
		}

		[CalledBy(Type = typeof(ConcurrentDictionary`2), Member = "System.Collections.IDictionary.GetEnumerator", ReturnType = typeof(IDictionaryEnumerator))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(ConcurrentDictionary`2), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.IEnumerator`1<KeyValuePair`2<TKey, TValue>>")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		internal DictionaryEnumerator(ConcurrentDictionary<TKey, TValue> dictionary) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(DictionaryEnumerator), Member = "get_Entry", ReturnType = typeof(DictionaryEntry))]
		[DeduplicatedMethod]
		public override object get_Current() { }

		[CalledBy(Type = typeof(DictionaryEnumerator), Member = "get_Current", ReturnType = typeof(object))]
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 5)]
		[DeduplicatedMethod]
		public override DictionaryEntry get_Entry() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 3)]
		[DeduplicatedMethod]
		public override object get_Key() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 3)]
		[DeduplicatedMethod]
		public override object get_Value() { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		public override bool MoveNext() { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		public override void Reset() { }

	}

	private sealed class Node
	{
		internal readonly TKey _key; //Field offset: 0x0
		internal TValue _value; //Field offset: 0x0
		internal Node<TKey, TValue> _next; //Field offset: 0x0
		internal readonly int _hashcode; //Field offset: 0x0

		[CalledBy(Type = typeof(ConcurrentDictionary`2), Member = "TryAddInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", typeof(int), "TValue", typeof(bool), typeof(bool), "TValue&"}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(ConcurrentDictionary`2), Member = "GrowTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Concurrent.ConcurrentDictionary`2<TKey, TValue>+Tables<TKey, TValue>"}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 4)]
		[DeduplicatedMethod]
		internal Node(TKey key, TValue value, int hashcode, Node<TKey, TValue> next) { }

	}

	private sealed class Tables
	{
		internal readonly Node<TKey, TValue>[] _buckets; //Field offset: 0x0
		internal readonly Object[] _locks; //Field offset: 0x0
		internal Int32[] _countPerLock; //Field offset: 0x0

		[CalledBy(Type = typeof(ConcurrentDictionary`2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(bool), "System.Collections.Generic.IEqualityComparer`1<TKey>"}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ConcurrentDictionary`2), Member = "Clear", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ConcurrentDictionary`2), Member = "GrowTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Concurrent.ConcurrentDictionary`2<TKey, TValue>+Tables<TKey, TValue>"}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ConcurrentDictionary`2), Member = "OnDeserialized", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StreamingContext)}, ReturnType = typeof(void))]
		[CallerCount(Count = 4)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 4)]
		[DeduplicatedMethod]
		internal Tables(Node<TKey, TValue>[] buckets, Object[] locks, Int32[] countPerLock) { }

	}

	private static readonly bool s_isValueWriteAtomic; //Field offset: 0x0
	private Tables<TKey, TValue> _tables; //Field offset: 0x0
	private IEqualityComparer<TKey> _comparer; //Field offset: 0x0
	private readonly bool _growLockArray; //Field offset: 0x0
	private int _budget; //Field offset: 0x0
	private KeyValuePair<TKey, TValue>[] _serializationArray; //Field offset: 0x0
	private int _serializationConcurrencyLevel; //Field offset: 0x0
	private int _serializationCapacity; //Field offset: 0x0

	public override int Count
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 5)]
		[DeduplicatedMethod]
		 get { } //Length: 177
	}

	private static int DefaultConcurrencyLevel
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(PlatformHelper), Member = "get_ProcessorCount", ReturnType = typeof(int))]
		[DeduplicatedMethod]
		private get { } //Length: 64
	}

	public override TValue Item
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 6)]
		[DeduplicatedMethod]
		 get { } //Length: 192
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ConcurrentDictionary`2), Member = "TryAddInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", typeof(int), "TValue", typeof(bool), typeof(bool), "TValue&"}, ReturnType = typeof(bool))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 3)]
		[DeduplicatedMethod]
		 set { } //Length: 321
	}

	public override ICollection<TKey> Keys
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ConcurrentDictionary`2), Member = "GetKeys", ReturnType = "System.Collections.ObjectModel.ReadOnlyCollection`1<TKey>")]
		[DeduplicatedMethod]
		 get { } //Length: 23
	}

	private override bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.IsReadOnly
	{
		[CallerCount(Count = 271)]
		[DeduplicatedMethod]
		private get { } //Length: 3
	}

	private override IEnumerable<TKey> System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.Keys
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ConcurrentDictionary`2), Member = "GetKeys", ReturnType = "System.Collections.ObjectModel.ReadOnlyCollection`1<TKey>")]
		[DeduplicatedMethod]
		private get { } //Length: 23
	}

	private override IEnumerable<TValue> System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.Values
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ConcurrentDictionary`2), Member = "GetValues", ReturnType = "System.Collections.ObjectModel.ReadOnlyCollection`1<TValue>")]
		[DeduplicatedMethod]
		private get { } //Length: 23
	}

	private override bool System.Collections.ICollection.IsSynchronized
	{
		[CallerCount(Count = 271)]
		[DeduplicatedMethod]
		private get { } //Length: 3
	}

	private override object System.Collections.ICollection.SyncRoot
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		[DeduplicatedMethod]
		private get { } //Length: 73
	}

	private override bool System.Collections.IDictionary.IsFixedSize
	{
		[CallerCount(Count = 271)]
		[DeduplicatedMethod]
		private get { } //Length: 3
	}

	private override bool System.Collections.IDictionary.IsReadOnly
	{
		[CallerCount(Count = 271)]
		[DeduplicatedMethod]
		private get { } //Length: 3
	}

	private override object System.Collections.IDictionary.Item
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 9)]
		[DeduplicatedMethod]
		private get { } //Length: 274
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ConcurrentDictionary`2), Member = "TryAddInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", typeof(int), "TValue", typeof(bool), typeof(bool), "TValue&"}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 22)]
		[DeduplicatedMethod]
		private set { } //Length: 800
	}

	private override ICollection System.Collections.IDictionary.Keys
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ConcurrentDictionary`2), Member = "GetKeys", ReturnType = "System.Collections.ObjectModel.ReadOnlyCollection`1<TKey>")]
		[DeduplicatedMethod]
		private get { } //Length: 23
	}

	private override ICollection System.Collections.IDictionary.Values
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ConcurrentDictionary`2), Member = "GetValues", ReturnType = "System.Collections.ObjectModel.ReadOnlyCollection`1<TValue>")]
		[DeduplicatedMethod]
		private get { } //Length: 23
	}

	public override ICollection<TValue> Values
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ConcurrentDictionary`2), Member = "GetValues", ReturnType = "System.Collections.ObjectModel.ReadOnlyCollection`1<TValue>")]
		[DeduplicatedMethod]
		 get { } //Length: 23
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(Type), Member = "get_IsValueType", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Type), Member = "GetTypeCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(TypeCode))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	private static ConcurrentDictionary`2() { }

	[CalledBy(Type = "Newtonsoft.Json.Utilities.ThreadSafeStore`2", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Func`2<TKey, TValue>"}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PlatformHelper), Member = "get_ProcessorCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(ConcurrentDictionary`2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(bool), "System.Collections.Generic.IEqualityComparer`1<TKey>"}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public ConcurrentDictionary`2() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlatformHelper), Member = "get_ProcessorCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(ConcurrentDictionary`2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(bool), "System.Collections.Generic.IEqualityComparer`1<TKey>"}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public ConcurrentDictionary`2(IEqualityComparer<TKey> comparer) { }

	[CalledBy(Type = typeof(ConcurrentDictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ConcurrentDictionary`2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEqualityComparer`1<TKey>"}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Tables), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Node<TKey, TValue>[]", typeof(Object[]), typeof(Int32[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.EqualityComparer`1<Newtonsoft.Json.Utilities.StructMultiKey`2<System.Object, System.Object>>), Member = "CreateComparer", ReturnType = typeof(System.Collections.Generic.EqualityComparer`1<Newtonsoft.Json.Utilities.StructMultiKey`2<System.Object, System.Object>>))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 29)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	internal ConcurrentDictionary`2(int concurrencyLevel, int capacity, bool growLockArray, IEqualityComparer<TKey> comparer) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ConcurrentDictionary`2), Member = "AcquireLocks", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(Int32&)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	private void AcquireAllLocks(ref int locksAcquired) { }

	[CalledBy(Type = typeof(ConcurrentDictionary`2), Member = "GrowTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Concurrent.ConcurrentDictionary`2<TKey, TValue>+Tables<TKey, TValue>"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ConcurrentDictionary`2), Member = "AcquireAllLocks", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	[DeduplicatedMethod]
	private void AcquireLocks(int fromInclusive, int toExclusive, ref int locksAcquired) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Tables), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Node<TKey, TValue>[]", typeof(Object[]), typeof(Int32[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Math), Member = "Max", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 17)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public override void Clear() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public override bool ContainsKey(TKey key) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	[DeduplicatedMethod]
	private void CopyToEntries(DictionaryEntry[] array, int index) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(KeyValuePair`2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue"}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 10)]
	[DeduplicatedMethod]
	private void CopyToObjects(Object[] array, int index) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(KeyValuePair`2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue"}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 7)]
	[DeduplicatedMethod]
	private void CopyToPairs(KeyValuePair<TKey, TValue>[] array, int index) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 5)]
	[DeduplicatedMethod]
	public override int get_Count() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlatformHelper), Member = "get_ProcessorCount", ReturnType = typeof(int))]
	[DeduplicatedMethod]
	private static int get_DefaultConcurrencyLevel() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 6)]
	[DeduplicatedMethod]
	public override TValue get_Item(TKey key) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ConcurrentDictionary`2), Member = "GetKeys", ReturnType = "System.Collections.ObjectModel.ReadOnlyCollection`1<TKey>")]
	[DeduplicatedMethod]
	public override ICollection<TKey> get_Keys() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ConcurrentDictionary`2), Member = "GetValues", ReturnType = "System.Collections.ObjectModel.ReadOnlyCollection`1<TValue>")]
	[DeduplicatedMethod]
	public override ICollection<TValue> get_Values() { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	private static int GetBucket(int hashcode, int bucketCount) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	private static void GetBucketAndLockNo(int hashcode, out int bucketNo, out int lockNo, int bucketCount, int lockCount) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 7)]
	[DeduplicatedMethod]
	private int GetCountInternal() { }

	[CalledBy(Type = typeof(DictionaryEnumerator), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Concurrent.ConcurrentDictionary`2<TKey, TValue>"}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	[IteratorStateMachine(typeof(<GetEnumerator>d__35))]
	public override IEnumerator<KeyValuePair`2<TKey, TValue>> GetEnumerator() { }

	[CalledBy(Type = typeof(ConcurrentDictionary`2), Member = "get_Keys", ReturnType = "System.Collections.Generic.ICollection`1<TKey>")]
	[CalledBy(Type = typeof(ConcurrentDictionary`2), Member = "System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys", ReturnType = "System.Collections.Generic.IEnumerable`1<TKey>")]
	[CalledBy(Type = typeof(ConcurrentDictionary`2), Member = "System.Collections.IDictionary.get_Keys", ReturnType = typeof(ICollection))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(List`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(OutOfMemoryException), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 19)]
	[DeduplicatedMethod]
	private ReadOnlyCollection<TKey> GetKeys() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ConcurrentDictionary`2), Member = "TryGetValueInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", typeof(int), "TValue&"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ConcurrentDictionary`2), Member = "TryAddInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", typeof(int), "TValue", typeof(bool), typeof(bool), "TValue&"}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	public TValue GetOrAdd(TKey key, TValue value) { }

	[CalledBy(Type = "Newtonsoft.Json.Utilities.ThreadSafeStore`2", Member = "Get", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = "TValue")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ConcurrentDictionary`2), Member = "TryGetValueInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", typeof(int), "TValue&"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ConcurrentDictionary`2), Member = "TryAddInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", typeof(int), "TValue", typeof(bool), typeof(bool), "TValue&"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 6)]
	[DeduplicatedMethod]
	public TValue GetOrAdd(TKey key, Func<TKey, TValue> valueFactory) { }

	[CalledBy(Type = typeof(ConcurrentDictionary`2), Member = "get_Values", ReturnType = "System.Collections.Generic.ICollection`1<TValue>")]
	[CalledBy(Type = typeof(ConcurrentDictionary`2), Member = "System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values", ReturnType = "System.Collections.Generic.IEnumerable`1<TValue>")]
	[CalledBy(Type = typeof(ConcurrentDictionary`2), Member = "System.Collections.IDictionary.get_Values", ReturnType = typeof(ICollection))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(List`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(OutOfMemoryException), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 19)]
	[DeduplicatedMethod]
	private ReadOnlyCollection<TValue> GetValues() { }

	[CalledBy(Type = typeof(ConcurrentDictionary`2), Member = "TryAddInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", typeof(int), "TValue", typeof(bool), typeof(bool), "TValue&"}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ConcurrentDictionary`2), Member = "AcquireLocks", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(Int32&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Node), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue", typeof(int), "System.Collections.Concurrent.ConcurrentDictionary`2<TKey, TValue>+Node<TKey, TValue>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Math), Member = "Max", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Tables), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Node<TKey, TValue>[]", typeof(Object[]), typeof(Int32[])}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 47)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	private void GrowTable(Tables<TKey, TValue> tables) { }

	[CalledBy(Type = typeof(ConcurrentDictionary`2), Member = "OnDeserialized", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StreamingContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ConcurrentDictionary`2), Member = "TryAddInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", typeof(int), "TValue", typeof(bool), typeof(bool), "TValue&"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 19)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	private void InitializeFromCollection(IEnumerable<KeyValuePair`2<TKey, TValue>> collection) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(Type), Member = "get_IsValueType", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Type), Member = "GetTypeCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(TypeCode))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	private static bool IsValueWriteAtomic() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Tables), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Node<TKey, TValue>[]", typeof(Object[]), typeof(Int32[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ConcurrentDictionary`2), Member = "InitializeFromCollection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<KeyValuePair`2<TKey, TValue>>"}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 11)]
	[DeduplicatedMethod]
	[OnDeserialized]
	private void OnDeserialized(StreamingContext context) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[OnSerialized]
	private void OnSerialized(StreamingContext context) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ConcurrentDictionary`2), Member = "ToArray", ReturnType = "System.Collections.Generic.KeyValuePair`2<TKey, TValue>[]")]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	[OnSerializing]
	private void OnSerializing(StreamingContext context) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	private void ReleaseLocks(int fromInclusive, int toExclusive) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ConcurrentDictionary`2), Member = "TryAddInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", typeof(int), "TValue", typeof(bool), typeof(bool), "TValue&"}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	public override void set_Item(TKey key, TValue value) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	private override void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(KeyValuePair<TKey, TValue> keyValuePair) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	private override bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(KeyValuePair<TKey, TValue> keyValuePair) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 23)]
	[DeduplicatedMethod]
	private override void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(KeyValuePair<TKey, TValue>[] array, int index) { }

	[CallerCount(Count = 271)]
	[DeduplicatedMethod]
	private override bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ConcurrentDictionary`2), Member = "TryRemoveInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue&", typeof(bool), "TValue"}, ReturnType = typeof(bool))]
	[DeduplicatedMethod]
	private override bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(KeyValuePair<TKey, TValue> keyValuePair) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ConcurrentDictionary`2), Member = "TryAddInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", typeof(int), "TValue", typeof(bool), typeof(bool), "TValue&"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	[DeduplicatedMethod]
	private override void System.Collections.Generic.IDictionary<TKey,TValue>.Add(TKey key, TValue value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ConcurrentDictionary`2), Member = "TryRemoveInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue&", typeof(bool), "TValue"}, ReturnType = typeof(bool))]
	[DeduplicatedMethod]
	private override bool System.Collections.Generic.IDictionary<TKey,TValue>.Remove(TKey key) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ConcurrentDictionary`2), Member = "GetKeys", ReturnType = "System.Collections.ObjectModel.ReadOnlyCollection`1<TKey>")]
	[DeduplicatedMethod]
	private override IEnumerable<TKey> System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ConcurrentDictionary`2), Member = "GetValues", ReturnType = "System.Collections.ObjectModel.ReadOnlyCollection`1<TValue>")]
	[DeduplicatedMethod]
	private override IEnumerable<TValue> System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(KeyValuePair`2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 48)]
	[DeduplicatedMethod]
	private override void System.Collections.ICollection.CopyTo(Array array, int index) { }

	[CallerCount(Count = 271)]
	[DeduplicatedMethod]
	private override bool System.Collections.ICollection.get_IsSynchronized() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	private override object System.Collections.ICollection.get_SyncRoot() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 20)]
	[DeduplicatedMethod]
	private override void System.Collections.IDictionary.Add(object key, object value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 9)]
	[DeduplicatedMethod]
	private override bool System.Collections.IDictionary.Contains(object key) { }

	[CallerCount(Count = 271)]
	[DeduplicatedMethod]
	private override bool System.Collections.IDictionary.get_IsFixedSize() { }

	[CallerCount(Count = 271)]
	[DeduplicatedMethod]
	private override bool System.Collections.IDictionary.get_IsReadOnly() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 9)]
	[DeduplicatedMethod]
	private override object System.Collections.IDictionary.get_Item(object key) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ConcurrentDictionary`2), Member = "GetKeys", ReturnType = "System.Collections.ObjectModel.ReadOnlyCollection`1<TKey>")]
	[DeduplicatedMethod]
	private override ICollection System.Collections.IDictionary.get_Keys() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ConcurrentDictionary`2), Member = "GetValues", ReturnType = "System.Collections.ObjectModel.ReadOnlyCollection`1<TValue>")]
	[DeduplicatedMethod]
	private override ICollection System.Collections.IDictionary.get_Values() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DictionaryEnumerator), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Concurrent.ConcurrentDictionary`2<TKey, TValue>"}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	private override IDictionaryEnumerator System.Collections.IDictionary.GetEnumerator() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ConcurrentDictionary`2), Member = "TryRemoveInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue&", typeof(bool), "TValue"}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 8)]
	[DeduplicatedMethod]
	private override void System.Collections.IDictionary.Remove(object key) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ConcurrentDictionary`2), Member = "TryAddInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", typeof(int), "TValue", typeof(bool), typeof(bool), "TValue&"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 22)]
	[DeduplicatedMethod]
	private override void System.Collections.IDictionary.set_Item(object key, object value) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SR), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(KeyNotFoundException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	[DeduplicatedMethod]
	private static void ThrowKeyNotFoundException(object key) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	private static void ThrowKeyNullException() { }

	[CalledBy(Type = typeof(ConcurrentDictionary`2), Member = "OnSerializing", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StreamingContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 22)]
	[DeduplicatedMethod]
	public KeyValuePair<TKey, TValue>[] ToArray() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ConcurrentDictionary`2), Member = "TryAddInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", typeof(int), "TValue", typeof(bool), typeof(bool), "TValue&"}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	public bool TryAdd(TKey key, TValue value) { }

	[CalledBy(Type = typeof(ConcurrentDictionary`2), Member = "InitializeFromCollection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<KeyValuePair`2<TKey, TValue>>"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ConcurrentDictionary`2), Member = "TryAdd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue"}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ConcurrentDictionary`2), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ConcurrentDictionary`2), Member = "GetOrAdd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "System.Func`2<TKey, TValue>"}, ReturnType = "TValue")]
	[CalledBy(Type = typeof(ConcurrentDictionary`2), Member = "GetOrAdd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue"}, ReturnType = "TValue")]
	[CalledBy(Type = typeof(ConcurrentDictionary`2), Member = "System.Collections.Generic.IDictionary<TKey,TValue>.Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ConcurrentDictionary`2), Member = "System.Collections.IDictionary.set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Node), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue", typeof(int), "System.Collections.Concurrent.ConcurrentDictionary`2<TKey, TValue>+Node<TKey, TValue>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ConcurrentDictionary`2), Member = "GrowTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Concurrent.ConcurrentDictionary`2<TKey, TValue>+Tables<TKey, TValue>"}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 55)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	private bool TryAddInternal(TKey key, int hashcode, TValue value, bool updateIfExists, bool acquireLock, out TValue resultingValue) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ConcurrentDictionary`2), Member = "TryGetValueInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", typeof(int), "TValue&"}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	public override bool TryGetValue(TKey key, out TValue value) { }

	[CalledBy(Type = typeof(ConcurrentDictionary`2), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue&"}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ConcurrentDictionary`2), Member = "GetOrAdd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "System.Func`2<TKey, TValue>"}, ReturnType = "TValue")]
	[CalledBy(Type = typeof(ConcurrentDictionary`2), Member = "GetOrAdd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue"}, ReturnType = "TValue")]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 9)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	private bool TryGetValueInternal(TKey key, int hashcode, out TValue value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ConcurrentDictionary`2), Member = "TryRemoveInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue&", typeof(bool), "TValue"}, ReturnType = typeof(bool))]
	[DeduplicatedMethod]
	public bool TryRemove(TKey key, out TValue value) { }

	[CalledBy(Type = typeof(ConcurrentDictionary`2), Member = "TryRemove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue&"}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ConcurrentDictionary`2), Member = "System.Collections.Generic.IDictionary<TKey,TValue>.Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ConcurrentDictionary`2), Member = "System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.KeyValuePair`2<TKey, TValue>"}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ConcurrentDictionary`2), Member = "System.Collections.IDictionary.Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 28)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	private bool TryRemoveInternal(TKey key, out TValue value, bool matchValue, TValue oldValue) { }

}

