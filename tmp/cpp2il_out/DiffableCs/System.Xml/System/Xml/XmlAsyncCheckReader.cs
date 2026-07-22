namespace System.Xml;

[DefaultMember("Item")]
internal class XmlAsyncCheckReader : XmlReader
{
	private readonly XmlReader coreReader; //Field offset: 0x10
	private Task lastTask; //Field offset: 0x18

	public virtual int AttributeCount
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(XmlAsyncCheckReader), Member = "CheckAsync", ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 52
	}

	public virtual string BaseURI
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(XmlAsyncCheckReader), Member = "CheckAsync", ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 52
	}

	public virtual bool CanReadValueChunk
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(XmlAsyncCheckReader), Member = "CheckAsync", ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 52
	}

	public virtual bool CanResolveEntity
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(XmlAsyncCheckReader), Member = "CheckAsync", ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 52
	}

	internal XmlReader CoreReader
	{
		[CallerCount(Count = 106)]
		[DeduplicatedMethod]
		internal get { } //Length: 5
	}

	public virtual int Depth
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(XmlAsyncCheckReader), Member = "CheckAsync", ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 52
	}

	internal virtual IDtdInfo DtdInfo
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(XmlAsyncCheckReader), Member = "CheckAsync", ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		internal get { } //Length: 52
	}

	public virtual bool EOF
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(XmlAsyncCheckReader), Member = "CheckAsync", ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 52
	}

	public virtual bool HasAttributes
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(XmlAsyncCheckReader), Member = "CheckAsync", ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 52
	}

	public virtual bool IsDefault
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(XmlAsyncCheckReader), Member = "CheckAsync", ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 52
	}

	public virtual bool IsEmptyElement
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(XmlAsyncCheckReader), Member = "CheckAsync", ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 52
	}

	public virtual string LocalName
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(XmlAsyncCheckReader), Member = "CheckAsync", ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 52
	}

	public virtual string Name
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(XmlAsyncCheckReader), Member = "CheckAsync", ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 52
	}

	internal virtual XmlNamespaceManager NamespaceManager
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(XmlAsyncCheckReader), Member = "CheckAsync", ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		internal get { } //Length: 52
	}

	public virtual string NamespaceURI
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(XmlAsyncCheckReader), Member = "CheckAsync", ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 52
	}

	public virtual XmlNameTable NameTable
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(XmlAsyncCheckReader), Member = "CheckAsync", ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 52
	}

	public virtual XmlNodeType NodeType
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(XmlAsyncCheckReader), Member = "CheckAsync", ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 52
	}

	public virtual string Prefix
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(XmlAsyncCheckReader), Member = "CheckAsync", ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 52
	}

	public virtual char QuoteChar
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(XmlAsyncCheckReader), Member = "CheckAsync", ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 52
	}

	public virtual ReadState ReadState
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(XmlAsyncCheckReader), Member = "CheckAsync", ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 52
	}

	public virtual IXmlSchemaInfo SchemaInfo
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(XmlAsyncCheckReader), Member = "CheckAsync", ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 52
	}

	public virtual XmlReaderSettings Settings
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(XmlReaderSettings), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(XmlReaderSettings), Member = "CheckReadOnly", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 246
	}

	public virtual string Value
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(XmlAsyncCheckReader), Member = "CheckAsync", ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 52
	}

	public virtual Type ValueType
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(XmlAsyncCheckReader), Member = "CheckAsync", ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 52
	}

	public virtual string XmlLang
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(XmlAsyncCheckReader), Member = "CheckAsync", ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 52
	}

	public virtual XmlSpace XmlSpace
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(XmlAsyncCheckReader), Member = "CheckAsync", ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 52
	}

	[CalledBy(Type = typeof(XmlAsyncCheckReader), Member = "CreateAsyncCheckWrapper", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlReader)}, ReturnType = typeof(XmlAsyncCheckReader))]
	[CalledBy(Type = typeof(XmlAsyncCheckReaderWithNS), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlReader)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlAsyncCheckReaderWithLineInfo), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlReader)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlAsyncCheckReaderWithLineInfoNS), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlReader)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public XmlAsyncCheckReader(XmlReader reader) { }

	[CallerCount(Count = 47)]
	[Calls(Type = typeof(Task), Member = "get_IsCompleted", ReturnType = typeof(bool))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	private void CheckAsync() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlAsyncCheckReader), Member = "CheckAsync", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public virtual void Close() { }

	[CalledBy(Type = typeof(XmlReader), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(XmlReaderSettings), typeof(string)}, ReturnType = typeof(XmlReader))]
	[CalledBy(Type = typeof(XmlReader), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextReader), typeof(XmlReaderSettings), typeof(string)}, ReturnType = typeof(XmlReader))]
	[CalledBy(Type = typeof(XmlReader), Member = "CreateSqlReader", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(XmlReaderSettings), typeof(XmlParserContext)}, ReturnType = typeof(XmlReader))]
	[CalledBy(Type = typeof(XmlReaderSettings), Member = "CreateReader", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(Uri), typeof(string), typeof(XmlParserContext)}, ReturnType = typeof(XmlReader))]
	[CalledBy(Type = typeof(XmlReaderSettings), Member = "CreateReader", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextReader), typeof(string), typeof(XmlParserContext)}, ReturnType = typeof(XmlReader))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(XmlAsyncCheckReader), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlReader)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlAsyncCheckReaderWithLineInfo), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlReader)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlAsyncCheckReaderWithLineInfoNS), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlReader)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 13)]
	public static XmlAsyncCheckReader CreateAsyncCheckWrapper(XmlReader reader) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlAsyncCheckReader), Member = "CheckAsync", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	protected virtual void Dispose(bool disposing) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlAsyncCheckReader), Member = "CheckAsync", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public virtual int get_AttributeCount() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlAsyncCheckReader), Member = "CheckAsync", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public virtual string get_BaseURI() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlAsyncCheckReader), Member = "CheckAsync", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public virtual bool get_CanReadValueChunk() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlAsyncCheckReader), Member = "CheckAsync", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public virtual bool get_CanResolveEntity() { }

	[CallerCount(Count = 106)]
	[DeduplicatedMethod]
	internal XmlReader get_CoreReader() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlAsyncCheckReader), Member = "CheckAsync", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public virtual int get_Depth() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlAsyncCheckReader), Member = "CheckAsync", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	internal virtual IDtdInfo get_DtdInfo() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlAsyncCheckReader), Member = "CheckAsync", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public virtual bool get_EOF() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlAsyncCheckReader), Member = "CheckAsync", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public virtual bool get_HasAttributes() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlAsyncCheckReader), Member = "CheckAsync", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public virtual bool get_IsDefault() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlAsyncCheckReader), Member = "CheckAsync", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public virtual bool get_IsEmptyElement() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlAsyncCheckReader), Member = "CheckAsync", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public virtual string get_LocalName() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlAsyncCheckReader), Member = "CheckAsync", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public virtual string get_Name() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlAsyncCheckReader), Member = "CheckAsync", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	internal virtual XmlNamespaceManager get_NamespaceManager() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlAsyncCheckReader), Member = "CheckAsync", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public virtual string get_NamespaceURI() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlAsyncCheckReader), Member = "CheckAsync", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public virtual XmlNameTable get_NameTable() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlAsyncCheckReader), Member = "CheckAsync", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public virtual XmlNodeType get_NodeType() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlAsyncCheckReader), Member = "CheckAsync", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public virtual string get_Prefix() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlAsyncCheckReader), Member = "CheckAsync", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public virtual char get_QuoteChar() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlAsyncCheckReader), Member = "CheckAsync", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public virtual ReadState get_ReadState() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlAsyncCheckReader), Member = "CheckAsync", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public virtual IXmlSchemaInfo get_SchemaInfo() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlReaderSettings), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlReaderSettings), Member = "CheckReadOnly", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public virtual XmlReaderSettings get_Settings() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlAsyncCheckReader), Member = "CheckAsync", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public virtual string get_Value() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlAsyncCheckReader), Member = "CheckAsync", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public virtual Type get_ValueType() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlAsyncCheckReader), Member = "CheckAsync", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public virtual string get_XmlLang() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlAsyncCheckReader), Member = "CheckAsync", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public virtual XmlSpace get_XmlSpace() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlAsyncCheckReader), Member = "CheckAsync", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public virtual string GetAttribute(string name, string namespaceURI) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlAsyncCheckReader), Member = "CheckAsync", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public virtual string GetAttribute(int i) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlAsyncCheckReader), Member = "CheckAsync", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public virtual string GetAttribute(string name) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlAsyncCheckReader), Member = "CheckAsync", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public virtual bool IsStartElement(string localname, string ns) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlAsyncCheckReader), Member = "CheckAsync", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public virtual string LookupNamespace(string prefix) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlAsyncCheckReader), Member = "CheckAsync", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public virtual void MoveToAttribute(int i) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlAsyncCheckReader), Member = "CheckAsync", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public virtual bool MoveToAttribute(string name) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlAsyncCheckReader), Member = "CheckAsync", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public virtual XmlNodeType MoveToContent() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlAsyncCheckReader), Member = "CheckAsync", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public virtual bool MoveToElement() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlAsyncCheckReader), Member = "CheckAsync", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public virtual bool MoveToFirstAttribute() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlAsyncCheckReader), Member = "CheckAsync", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public virtual bool MoveToNextAttribute() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlAsyncCheckReader), Member = "CheckAsync", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public virtual bool Read() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlAsyncCheckReader), Member = "CheckAsync", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public virtual bool ReadAttributeValue() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlAsyncCheckReader), Member = "CheckAsync", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public virtual string ReadElementString() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlAsyncCheckReader), Member = "CheckAsync", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public virtual void ReadEndElement() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlAsyncCheckReader), Member = "CheckAsync", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public virtual string ReadInnerXml() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlAsyncCheckReader), Member = "CheckAsync", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public virtual void ReadStartElement() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlAsyncCheckReader), Member = "CheckAsync", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public virtual string ReadString() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlAsyncCheckReader), Member = "CheckAsync", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public virtual int ReadValueChunk(Char[] buffer, int index, int count) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlAsyncCheckReader), Member = "CheckAsync", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public virtual void ResolveEntity() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlAsyncCheckReader), Member = "CheckAsync", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public virtual void Skip() { }

}

