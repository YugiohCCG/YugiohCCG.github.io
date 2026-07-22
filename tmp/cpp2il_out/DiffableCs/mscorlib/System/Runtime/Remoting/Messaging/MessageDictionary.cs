namespace System.Runtime.Remoting.Messaging;

[DefaultMember("Item")]
internal class MessageDictionary : IDictionary, ICollection, IEnumerable
{
	private class DictionaryEnumerator : IDictionaryEnumerator, IEnumerator
	{
		private MessageDictionary _methodDictionary; //Field offset: 0x10
		private IDictionaryEnumerator _hashtableEnum; //Field offset: 0x18
		private int _posMethod; //Field offset: 0x20

		public override object Current
		{
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(DictionaryEnumerator), Member = "get_Entry", ReturnType = typeof(DictionaryEntry))]
			 get { } //Length: 84
		}

		public override DictionaryEntry Entry
		{
			[CalledBy(Type = typeof(DictionaryEnumerator), Member = "get_Current", ReturnType = typeof(object))]
			[CalledBy(Type = typeof(DictionaryEnumerator), Member = "get_Key", ReturnType = typeof(object))]
			[CalledBy(Type = typeof(DictionaryEnumerator), Member = "get_Value", ReturnType = typeof(object))]
			[CallerCount(Count = 3)]
			[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
			[CallsDeduplicatedMethods(Count = 3)]
			[CallsUnknownMethods(Count = 7)]
			 get { } //Length: 419
		}

		public override object Key
		{
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(DictionaryEnumerator), Member = "get_Entry", ReturnType = typeof(DictionaryEntry))]
			 get { } //Length: 28
		}

		public override object Value
		{
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(DictionaryEnumerator), Member = "get_Entry", ReturnType = typeof(DictionaryEntry))]
			 get { } //Length: 29
		}

		[CalledBy(Type = typeof(MessageDictionary), Member = "System.Collections.IEnumerable.GetEnumerator", ReturnType = typeof(IEnumerator))]
		[CalledBy(Type = typeof(MessageDictionary), Member = "GetEnumerator", ReturnType = typeof(IDictionaryEnumerator))]
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 4)]
		public DictionaryEnumerator(MessageDictionary methodDictionary) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(DictionaryEnumerator), Member = "get_Entry", ReturnType = typeof(DictionaryEntry))]
		public override object get_Current() { }

		[CalledBy(Type = typeof(DictionaryEnumerator), Member = "get_Current", ReturnType = typeof(object))]
		[CalledBy(Type = typeof(DictionaryEnumerator), Member = "get_Key", ReturnType = typeof(object))]
		[CalledBy(Type = typeof(DictionaryEnumerator), Member = "get_Value", ReturnType = typeof(object))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 7)]
		public override DictionaryEntry get_Entry() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(DictionaryEnumerator), Member = "get_Entry", ReturnType = typeof(DictionaryEntry))]
		public override object get_Key() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(DictionaryEnumerator), Member = "get_Entry", ReturnType = typeof(DictionaryEntry))]
		public override object get_Value() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(MessageDictionary), Member = "IsOverridenKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 4)]
		public override bool MoveNext() { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		public override void Reset() { }

	}

	private IDictionary _internalProperties; //Field offset: 0x10
	protected IMethodMessage _message; //Field offset: 0x18
	private String[] _methodKeys; //Field offset: 0x20
	private bool _ownProperties; //Field offset: 0x28

	public override int Count
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		 get { } //Length: 106
	}

	internal IDictionary InternalDictionary
	{
		[CalledBy(Type = typeof(CADMessageBase), Member = "MarshalProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IDictionary), typeof(ArrayList&)}, ReturnType = typeof(int))]
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		internal get { } //Length: 162
	}

	public override bool IsFixedSize
	{
		[CallerCount(Count = 271)]
		[DeduplicatedMethod]
		 get { } //Length: 3
	}

	public override bool IsReadOnly
	{
		[CallerCount(Count = 271)]
		[DeduplicatedMethod]
		 get { } //Length: 3
	}

	public override bool IsSynchronized
	{
		[CallerCount(Count = 271)]
		[DeduplicatedMethod]
		 get { } //Length: 3
	}

	public override object Item
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 4)]
		 get { } //Length: 264
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 5)]
		[DeduplicatedMethod]
		 set { } //Length: 331
	}

	public override ICollection Keys
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ArrayList), Member = ".ctor", ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 5)]
		[CallsUnknownMethods(Count = 16)]
		 get { } //Length: 915
	}

	public String[] MethodKeys
	{
		[CallerCount(Count = 10)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 set { } //Length: 13
	}

	public override object SyncRoot
	{
		[CallerCount(Count = 2063)]
		[DeduplicatedMethod]
		 get { } //Length: 4
	}

	public override ICollection Values
	{
		[CalledBy(Type = typeof(MessageDictionary), Member = "CopyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(ArrayList), Member = ".ctor", ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 6)]
		[CallsUnknownMethods(Count = 17)]
		 get { } //Length: 977
	}

	[CallerCount(Count = 7)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public MessageDictionary(IMethodMessage message) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 5)]
	[DeduplicatedMethod]
	public override void Add(object key, object value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Hashtable), Member = ".ctor", ReturnType = typeof(void))]
	protected override IDictionary AllocInternalProperties() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public override void Clear() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	public override bool Contains(object key) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MessageDictionary), Member = "get_Values", ReturnType = typeof(ICollection))]
	[CallsUnknownMethods(Count = 2)]
	public override void CopyTo(Array array, int index) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public override int get_Count() { }

	[CalledBy(Type = typeof(CADMessageBase), Member = "MarshalProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IDictionary), typeof(ArrayList&)}, ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	internal IDictionary get_InternalDictionary() { }

	[CallerCount(Count = 271)]
	[DeduplicatedMethod]
	public override bool get_IsFixedSize() { }

	[CallerCount(Count = 271)]
	[DeduplicatedMethod]
	public override bool get_IsReadOnly() { }

	[CallerCount(Count = 271)]
	[DeduplicatedMethod]
	public override bool get_IsSynchronized() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	public override object get_Item(object key) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ArrayList), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 16)]
	public override ICollection get_Keys() { }

	[CallerCount(Count = 2063)]
	[DeduplicatedMethod]
	public override object get_SyncRoot() { }

	[CalledBy(Type = typeof(MessageDictionary), Member = "CopyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ArrayList), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 17)]
	public override ICollection get_Values() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DictionaryEnumerator), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MessageDictionary)}, ReturnType = typeof(void))]
	public override IDictionaryEnumerator GetEnumerator() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public IDictionary GetInternalProperties() { }

	[CalledBy(Type = typeof(ConstructionCallDictionary), Member = "GetMethodProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(object))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallsUnknownMethods(Count = 17)]
	protected override object GetMethodProperty(string key) { }

	[CalledBy(Type = typeof(CADMessageBase), Member = "MarshalProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IDictionary), typeof(ArrayList&)}, ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	internal bool HasUserData() { }

	[CalledBy(Type = typeof(DictionaryEnumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private bool IsOverridenKey(string key) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 8)]
	public override void Remove(object key) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 5)]
	[DeduplicatedMethod]
	public override void set_Item(object key, object value) { }

	[CallerCount(Count = 10)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public void set_MethodKeys(String[] value) { }

	[CalledBy(Type = typeof(ConstructionCallDictionary), Member = "SetMethodProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallsUnknownMethods(Count = 7)]
	protected override void SetMethodProperty(string key, object value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DictionaryEnumerator), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MessageDictionary)}, ReturnType = typeof(void))]
	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

