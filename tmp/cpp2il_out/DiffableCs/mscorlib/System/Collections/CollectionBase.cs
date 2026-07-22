namespace System.Collections;

public abstract class CollectionBase : IList, ICollection, IEnumerable
{
	private ArrayList _list; //Field offset: 0x10

	public override int Count
	{
		[CallerCount(Count = 244)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 39
	}

	protected ArrayList InnerList
	{
		[CallerCount(Count = 106)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	protected IList List
	{
		[CallerCount(Count = 2063)]
		[DeduplicatedMethod]
		 get { } //Length: 4
	}

	private override bool System.Collections.ICollection.IsSynchronized
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		private get { } //Length: 39
	}

	private override object System.Collections.ICollection.SyncRoot
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		private get { } //Length: 39
	}

	private override bool System.Collections.IList.IsFixedSize
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		private get { } //Length: 39
	}

	private override bool System.Collections.IList.IsReadOnly
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		private get { } //Length: 39
	}

	private override object System.Collections.IList.Item
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 6)]
		private get { } //Length: 186
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 7)]
		[CallsUnknownMethods(Count = 10)]
		private set { } //Length: 431
	}

	[CallerCount(Count = 47)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	protected CollectionBase() { }

	[CalledBy(Type = "System.Xml.Serialization.XmlAttributes", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ICustomAttributeProvider)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Xml.Schema.XmlSchemaInference", Member = "FindMatchingElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), "System.Xml.XmlReader", "System.Xml.Schema.XmlSchemaComplexType", typeof(Int32&), typeof(Boolean&), "System.Xml.Schema.XmlSchema", typeof(bool)}, ReturnType = "System.Xml.Schema.XmlSchemaElement")]
	[CalledBy(Type = "System.Xml.Schema.XmlSchemaInference", Member = "MoveAttributes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Xml.Schema.XmlSchemaComplexType", "System.Xml.Schema.XmlSchemaSimpleContentExtension", typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Security.Cryptography.X509Certificates.X509ChainImplMono", Member = "Reset", ReturnType = typeof(void))]
	[CalledBy(Type = "System.Security.Cryptography.X509Certificates.X509Store", Member = "get_Certificates", ReturnType = "System.Security.Cryptography.X509Certificates.X509Certificate2Collection")]
	[CalledBy(Type = "System.Security.Cryptography.X509Certificates.X509Store", Member = "Close", ReturnType = typeof(void))]
	[CalledBy(Type = "System.Security.Cryptography.X509Certificates.X509Store", Member = "Dispose", ReturnType = typeof(void))]
	[CalledBy(Type = "Mono.Security.X509.PKCS12", Member = "get_Certificates", ReturnType = "Mono.Security.X509.X509CertificateCollection")]
	[CalledBy(Type = "Mono.Security.X509.X509Chain", Member = "Reset", ReturnType = typeof(void))]
	[CallerCount(Count = 15)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	public override void Clear() { }

	[CallerCount(Count = 244)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public override int get_Count() { }

	[CallerCount(Count = 106)]
	[DeduplicatedMethod]
	protected ArrayList get_InnerList() { }

	[CallerCount(Count = 2063)]
	[DeduplicatedMethod]
	protected IList get_List() { }

	[CallerCount(Count = 8)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public override IEnumerator GetEnumerator() { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	protected override void OnClear() { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	protected override void OnClearComplete() { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	protected override void OnInsert(int index, object value) { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	protected override void OnInsertComplete(int index, object value) { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	protected override void OnRemove(int index, object value) { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	protected override void OnRemoveComplete(int index, object value) { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	protected override void OnSet(int index, object oldValue, object newValue) { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	protected override void OnSetComplete(int index, object oldValue, object newValue) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	protected override void OnValidate(object value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 10)]
	public override void RemoveAt(int index) { }

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	private override void System.Collections.ICollection.CopyTo(Array array, int index) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	private override bool System.Collections.ICollection.get_IsSynchronized() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	private override object System.Collections.ICollection.get_SyncRoot() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 5)]
	private override int System.Collections.IList.Add(object value) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	private override bool System.Collections.IList.Contains(object value) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	private override bool System.Collections.IList.get_IsFixedSize() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private override bool System.Collections.IList.get_IsReadOnly() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 6)]
	private override object System.Collections.IList.get_Item(int index) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	private override int System.Collections.IList.IndexOf(object value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 10)]
	private override void System.Collections.IList.Insert(int index, object value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 9)]
	private override void System.Collections.IList.Remove(object value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 10)]
	private override void System.Collections.IList.set_Item(int index, object value) { }

}

