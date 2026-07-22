namespace System.Xml.Schema;

[DefaultMember("Item")]
[Obsolete("Use System.Xml.Schema.XmlSchemaSet for schema compilation and validation. https://go.microsoft.com/fwlink/?linkid=14202")]
public sealed class XmlSchemaCollection : ICollection, IEnumerable
{
	private Hashtable collection; //Field offset: 0x10
	private XmlNameTable nameTable; //Field offset: 0x18
	private SchemaNames schemaNames; //Field offset: 0x20
	private ReaderWriterLock wLock; //Field offset: 0x28
	private int timeout; //Field offset: 0x30
	private bool isThreadSafe; //Field offset: 0x34
	private ValidationEventHandler validationEventHandler; //Field offset: 0x38
	private XmlResolver xmlResolver; //Field offset: 0x40

	public int Count
	{
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 39
	}

	internal ValidationEventHandler EventHandler
	{
		[CallerCount(Count = 38)]
		[DeduplicatedMethod]
		internal get { } //Length: 5
		[CallerCount(Count = 3)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		internal set { } //Length: 13
	}

	public XmlSchema Item
	{
		[CalledBy(Type = typeof(SchemaCollectionPreprocessor), Member = "LoadExternals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchema), typeof(XmlSchemaCollection)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		 get { } //Length: 160
	}

	public XmlNameTable NameTable
	{
		[CallerCount(Count = 31)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	private override int System.Collections.ICollection.Count
	{
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		private get { } //Length: 39
	}

	private override bool System.Collections.ICollection.IsSynchronized
	{
		[CallerCount(Count = 23)]
		[DeduplicatedMethod]
		private get { } //Length: 3
	}

	private override object System.Collections.ICollection.SyncRoot
	{
		[CallerCount(Count = 2063)]
		[DeduplicatedMethod]
		private get { } //Length: 4
	}

	internal XmlResolver XmlResolver
	{
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		internal set { } //Length: 13
	}

	[CalledBy(Type = typeof(XmlValidatingReaderImpl), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlReader), typeof(ValidationEventHandler), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Hashtable), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(Hashtable), Member = "Synchronized", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Hashtable)}, ReturnType = typeof(Hashtable))]
	[Calls(Type = typeof(XmlReaderSection), Member = "CreateDefaultResolver", ReturnType = typeof(XmlResolver))]
	[Calls(Type = typeof(ReaderWriterLock), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 8)]
	public XmlSchemaCollection(XmlNameTable nametable) { }

	[CalledBy(Type = typeof(XmlSchemaCollection), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(SchemaInfo), typeof(XmlSchema), typeof(bool)}, ReturnType = typeof(XmlSchema))]
	[CalledBy(Type = typeof(XmlSchemaCollection), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(SchemaInfo), typeof(XmlSchema), typeof(bool), typeof(XmlResolver)}, ReturnType = typeof(XmlSchema))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ReaderWriterLock), Member = "AcquireWriterLock", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ReaderWriterLock), Member = "ReleaseWriterLock", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 6)]
	private void Add(string ns, XmlSchemaCollectionNode node) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlSchema), Member = "CompileSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaCollection), typeof(XmlResolver), typeof(SchemaInfo), typeof(string), typeof(ValidationEventHandler), typeof(XmlNameTable), typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlSchemaCollection), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(XmlSchemaCollectionNode)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	private XmlSchema Add(string ns, SchemaInfo schemaInfo, XmlSchema schema, bool compile, XmlResolver resolver) { }

	[CalledBy(Type = typeof(XdrValidator), Member = "ProcessInlineSchema", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XdrValidator), Member = "LoadSchemaFromLocation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XsdValidator), Member = "ProcessInlineSchema", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XsdValidator), Member = "LoadSchemaFromLocation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(XmlSchema), Member = "CompileSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaCollection), typeof(XmlResolver), typeof(SchemaInfo), typeof(string), typeof(ValidationEventHandler), typeof(XmlNameTable), typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlSchemaCollection), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(XmlSchemaCollectionNode)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	internal XmlSchema Add(string ns, SchemaInfo schemaInfo, XmlSchema schema, bool compile) { }

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public int get_Count() { }

	[CallerCount(Count = 38)]
	[DeduplicatedMethod]
	internal ValidationEventHandler get_EventHandler() { }

	[CalledBy(Type = typeof(SchemaCollectionPreprocessor), Member = "LoadExternals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchema), typeof(XmlSchemaCollection)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public XmlSchema get_Item(string ns) { }

	[CallerCount(Count = 31)]
	[DeduplicatedMethod]
	public XmlNameTable get_NameTable() { }

	[CalledBy(Type = typeof(AutoValidator), Member = "DetectValidationType", ReturnType = typeof(ValidationType))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public XmlSchemaCollectionEnumerator GetEnumerator() { }

	[CalledBy(Type = typeof(XsdValidator), Member = "LoadSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	internal SchemaInfo GetSchemaInfo(string ns) { }

	[CalledBy(Type = typeof(BaseValidator), Member = "get_SchemaNames", ReturnType = typeof(SchemaNames))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SchemaNames), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNameTable)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	internal SchemaNames GetSchemaNames(XmlNameTable nt) { }

	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	internal void set_EventHandler(ValidationEventHandler value) { }

	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	internal void set_XmlResolver(XmlResolver value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlSchemaCollectionEnumerator), Member = "get_Current", ReturnType = typeof(XmlSchema))]
	[Calls(Type = typeof(Array), Member = "SetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 15)]
	private override void System.Collections.ICollection.CopyTo(Array array, int index) { }

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	private override int System.Collections.ICollection.get_Count() { }

	[CallerCount(Count = 23)]
	[DeduplicatedMethod]
	private override bool System.Collections.ICollection.get_IsSynchronized() { }

	[CallerCount(Count = 2063)]
	[DeduplicatedMethod]
	private override object System.Collections.ICollection.get_SyncRoot() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

