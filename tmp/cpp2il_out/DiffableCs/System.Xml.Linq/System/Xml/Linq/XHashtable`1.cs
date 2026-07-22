namespace System.Xml.Linq;

internal sealed class XHashtable
{
	internal sealed class ExtractKeyDelegate : MulticastDelegate
	{

		[CallerCount(Count = 39)]
		[CallsUnknownMethods(Count = 7)]
		[DeduplicatedMethod]
		public ExtractKeyDelegate(object object, IntPtr method) { }

		[CallerCount(Count = 3)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public override string Invoke(TValue value) { }

	}

	private sealed class XHashtableState
	{
		private struct Entry
		{
			public TValue Value; //Field offset: 0x0
			public int HashCode; //Field offset: 0x0
			public int Next; //Field offset: 0x0

		}

		private Int32[] _buckets; //Field offset: 0x0
		private Entry<TValue>[] _entries; //Field offset: 0x0
		private int _numEntries; //Field offset: 0x0
		private ExtractKeyDelegate<TValue> _extractKey; //Field offset: 0x0

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 4)]
		[DeduplicatedMethod]
		public XHashtableState(ExtractKeyDelegate<TValue> extractKey, int capacity) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		private static int ComputeHashCode(string key, int index, int count) { }

		[CalledBy(Type = typeof(XHashtableState), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int), "TValue&"}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(XHashtableState), Member = "TryAdd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TValue", "TValue&"}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(XHashtable`1), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int), "TValue&"}, ReturnType = typeof(bool))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(string), Member = "CompareOrdinal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(string), typeof(int), typeof(int)}, ReturnType = typeof(int))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		private bool FindEntry(int hashCode, string key, int index, int count, ref int entryIndex) { }

		[CalledBy(Type = typeof(XHashtable`1), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, ReturnType = "TValue")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Interlocked), Member = "CompareExchange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&), typeof(int), typeof(int)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(XHashtableState), Member = "TryAdd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TValue", "TValue&"}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(OverflowException), Member = ".ctor", ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 6)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		public XHashtableState<TValue> Resize() { }

		[CalledBy(Type = typeof(XHashtableState), Member = "Resize", ReturnType = "System.Xml.Linq.XHashtable`1<TValue>+XHashtableState<TValue>")]
		[CalledBy(Type = typeof(XHashtable`1), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, ReturnType = "TValue")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
		[Calls(Type = typeof(Interlocked), Member = "Increment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(Thread), Member = "MemoryBarrier", ReturnType = typeof(void))]
		[Calls(Type = typeof(XHashtableState), Member = "FindEntry", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string), typeof(int), typeof(int), typeof(Int32&)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Interlocked), Member = "CompareExchange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&), typeof(int), typeof(int)}, ReturnType = typeof(int))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 5)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		public bool TryAdd(TValue value, out TValue newValue) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
		[Calls(Type = typeof(XHashtableState), Member = "FindEntry", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string), typeof(int), typeof(int), typeof(Int32&)}, ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 3)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		public bool TryGetValue(string key, int index, int count, out TValue value) { }

	}

	private XHashtableState<TValue> _state; //Field offset: 0x0

	[CalledBy(Type = typeof(XNamespace), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XNamespace), Member = "Get", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int)}, ReturnType = typeof(XNamespace))]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	public XHashtable`1(ExtractKeyDelegate<TValue> extractKey, int capacity) { }

	[CalledBy(Type = typeof(XNamespace), Member = "GetName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int)}, ReturnType = typeof(XName))]
	[CalledBy(Type = typeof(XNamespace), Member = "Get", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int)}, ReturnType = typeof(XNamespace))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(XHashtableState), Member = "TryAdd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TValue", "TValue&"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XHashtableState), Member = "Resize", ReturnType = "System.Xml.Linq.XHashtable`1<TValue>+XHashtableState<TValue>")]
	[Calls(Type = typeof(Thread), Member = "MemoryBarrier", ReturnType = typeof(void))]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	[DeduplicatedMethod]
	public TValue Add(TValue value) { }

	[CalledBy(Type = typeof(XNamespace), Member = "GetName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int)}, ReturnType = typeof(XName))]
	[CalledBy(Type = typeof(XNamespace), Member = "Get", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int)}, ReturnType = typeof(XNamespace))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(XHashtableState), Member = "FindEntry", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string), typeof(int), typeof(int), typeof(Int32&)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public bool TryGetValue(string key, int index, int count, out TValue value) { }

}

