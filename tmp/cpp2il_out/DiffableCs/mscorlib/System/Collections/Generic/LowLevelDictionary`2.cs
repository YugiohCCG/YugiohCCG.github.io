namespace System.Collections.Generic;

[DefaultMember("Item")]
internal class LowLevelDictionary
{
	private sealed class DefaultComparer : IEqualityComparer<T>
	{

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public DefaultComparer`1() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		public override bool Equals(T x, T y) { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public override int GetHashCode(T obj) { }

	}

	private sealed class Entry
	{
		public TKey _key; //Field offset: 0x0
		public TValue _value; //Field offset: 0x0
		public Entry<TKey, TValue> _next; //Field offset: 0x0

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public Entry() { }

	}

	private Entry<TKey, TValue>[] _buckets; //Field offset: 0x0
	private int _numEntries; //Field offset: 0x0
	private int _version; //Field offset: 0x0
	private IEqualityComparer<TKey> _comparer; //Field offset: 0x0

	public TKey Item
	{
		[CalledBy(Type = typeof(DebuggerSupport), Member = "AddToActiveTasksNonInlined", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(LowLevelDictionary`2), Member = "UncheckedAdd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue"}, ReturnType = "System.Collections.Generic.LowLevelDictionary`2<TKey, TValue>+Entry<TKey, TValue>")]
		[CallsUnknownMethods(Count = 7)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		 set { } //Length: 332
	}

	[CalledBy(Type = typeof(DebuggerSupport), Member = ".cctor", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	[DeduplicatedMethod]
	public LowLevelDictionary`2() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	public LowLevelDictionary`2(int capacity, IEqualityComparer<TKey> comparer) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public void Clear(int capacity = 17) { }

	[CalledBy(Type = typeof(LowLevelDictionary`2), Member = "UncheckedAdd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue"}, ReturnType = "System.Collections.Generic.LowLevelDictionary`2<TKey, TValue>+Entry<TKey, TValue>")]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 11)]
	[DeduplicatedMethod]
	private void ExpandBuckets() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 6)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	private Entry<TKey, TValue> Find(TKey key) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	private int GetBucket(TKey key, int numBuckets = 0) { }

	[CalledBy(Type = typeof(DebuggerSupport), Member = "RemoveFromActiveTasksNonInlined", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 8)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public bool Remove(TKey key) { }

	[CalledBy(Type = typeof(DebuggerSupport), Member = "AddToActiveTasksNonInlined", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(LowLevelDictionary`2), Member = "UncheckedAdd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue"}, ReturnType = "System.Collections.Generic.LowLevelDictionary`2<TKey, TValue>+Entry<TKey, TValue>")]
	[CallsUnknownMethods(Count = 7)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public void set_Item(TKey key, TValue value) { }

	[CalledBy(Type = typeof(LowLevelDictionary`2), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue"}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(LowLevelDictionary`2), Member = "ExpandBuckets", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 8)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	private Entry<TKey, TValue> UncheckedAdd(TKey key, TValue value) { }

}

