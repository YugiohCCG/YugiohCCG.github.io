namespace System.Xml;

[EditorBrowsable(EditorBrowsableState::Never (1))]
public class XmlTextReader : XmlReader, IXmlLineInfo, IXmlNamespaceResolver
{
	private XmlTextReaderImpl impl; //Field offset: 0x10

	public virtual int AttributeCount
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 39
	}

	public virtual string BaseURI
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 39
	}

	public virtual bool CanReadValueChunk
	{
		[CallerCount(Count = 271)]
		[DeduplicatedMethod]
		 get { } //Length: 3
	}

	public virtual bool CanResolveEntity
	{
		[CallerCount(Count = 23)]
		[DeduplicatedMethod]
		 get { } //Length: 3
	}

	public virtual int Depth
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 39
	}

	internal virtual IDtdInfo DtdInfo
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		internal get { } //Length: 39
	}

	public EntityHandling EntityHandling
	{
		[CalledBy(Type = typeof(XmlDocument), Member = "SetupReader", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlTextReader)}, ReturnType = typeof(XmlTextReader))]
		[CalledBy(Type = typeof(XmlDocument), Member = "LoadXml", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(XmlTextReaderImpl), Member = "set_EntityHandling", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EntityHandling)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		 set { } //Length: 30
	}

	public virtual bool EOF
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 39
	}

	internal XmlTextReaderImpl Impl
	{
		[CallerCount(Count = 106)]
		[DeduplicatedMethod]
		internal get { } //Length: 5
	}

	public virtual bool IsDefault
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 39
	}

	public virtual bool IsEmptyElement
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 39
	}

	public override int LineNumber
	{
		[CalledBy(Type = typeof(XmlSerializationReader), Member = "UnknownAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(XmlAttribute), typeof(string)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XmlSerializationReader), Member = "UnknownElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(XmlElement), typeof(string)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XmlSerializationReader), Member = "OnUnknownNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNode), typeof(object), typeof(string)}, ReturnType = typeof(void))]
		[CallerCount(Count = 5)]
		[Calls(Type = typeof(XmlTextReaderImpl), Member = "get_LineNumber", ReturnType = typeof(int))]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 29
	}

	public override int LinePosition
	{
		[CalledBy(Type = typeof(XmlSerializationReader), Member = "UnknownAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(XmlAttribute), typeof(string)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XmlSerializationReader), Member = "UnknownElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(XmlElement), typeof(string)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XmlSerializationReader), Member = "OnUnknownNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNode), typeof(object), typeof(string)}, ReturnType = typeof(void))]
		[CallerCount(Count = 5)]
		[Calls(Type = typeof(XmlTextReaderImpl), Member = "get_LinePosition", ReturnType = typeof(int))]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 29
	}

	public virtual string LocalName
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 39
	}

	public virtual string Name
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 39
	}

	internal virtual XmlNamespaceManager NamespaceManager
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		internal get { } //Length: 39
	}

	public bool Namespaces
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 30
	}

	public virtual string NamespaceURI
	{
		[CallerCount(Count = 12)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 39
	}

	public virtual XmlNameTable NameTable
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 39
	}

	public virtual XmlNodeType NodeType
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 39
	}

	public bool Normalization
	{
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 30
		[CalledBy(Type = typeof(XmlSerializer), Member = "Deserialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextReader)}, ReturnType = typeof(object))]
		[CalledBy(Type = "System.Data.DataSet", Member = "System.Xml.Serialization.IXmlSerializable.ReadXml", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlReader)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(XmlTextReaderImpl), Member = "set_Normalization", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		 set { } //Length: 30
	}

	public virtual string Prefix
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 39
	}

	public virtual char QuoteChar
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 39
	}

	public virtual ReadState ReadState
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 39
	}

	public virtual string Value
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 39
	}

	public WhitespaceHandling WhitespaceHandling
	{
		[CalledBy(Type = typeof(XmlSerializer), Member = "Deserialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextReader)}, ReturnType = typeof(object))]
		[CalledBy(Type = "System.Data.DataSet", Member = "ReadXmlSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlReader), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = "System.Data.DataSet", Member = "ReadXml", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlReader), typeof(bool)}, ReturnType = "System.Data.XmlReadMode")]
		[CalledBy(Type = "System.Data.DataSet", Member = "ReadXml", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlReader), "System.Data.XmlReadMode", typeof(bool)}, ReturnType = "System.Data.XmlReadMode")]
		[CalledBy(Type = "System.Data.DataTable", Member = "ReadXml", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlReader), "System.Data.XmlReadMode", typeof(bool)}, ReturnType = "System.Data.XmlReadMode")]
		[CallerCount(Count = 5)]
		[Calls(Type = typeof(XmlTextReaderImpl), Member = "set_WhitespaceHandling", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WhitespaceHandling)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		 set { } //Length: 30
	}

	public virtual string XmlLang
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 39
	}

	public XmlResolver XmlResolver
	{
		[CalledBy(Type = typeof(XmlDocument), Member = "SetupReader", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlTextReader)}, ReturnType = typeof(XmlTextReader))]
		[CalledBy(Type = typeof(XmlDocument), Member = "LoadXml", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(SchemaCollectionPreprocessor), Member = "LoadExternals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchema), typeof(XmlSchemaCollection)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XdrValidator), Member = "LoadSchemaFromLocation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(XmlTextReaderImpl), Member = "set_XmlResolver", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlResolver)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		 set { } //Length: 30
	}

	public virtual XmlSpace XmlSpace
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 39
	}

	internal bool XmlValidatingReaderCompatibilityMode
	{
		[CalledBy(Type = typeof(XmlDocument), Member = "SetupReader", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlTextReader)}, ReturnType = typeof(XmlTextReader))]
		[CalledBy(Type = typeof(XmlDocument), Member = "LoadXml", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(XmlTextReaderImpl), Member = "set_XmlValidatingReaderCompatibilityMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 6)]
		[CallsUnknownMethods(Count = 15)]
		internal set { } //Length: 1130
	}

	[CalledBy(Type = "System.Data.DataSet", Member = "System.Xml.Serialization.IXmlSerializable.GetSchema", ReturnType = typeof(XmlSchema))]
	[CalledBy(Type = "System.Data.DataTable", Member = "GetSchema", ReturnType = typeof(XmlSchema))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public XmlTextReader(Stream input) { }

	[CalledBy(Type = typeof(SchemaCollectionPreprocessor), Member = "LoadExternals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchema), typeof(XmlSchemaCollection)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XdrBuilder), Member = "LoadSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XdrValidator), Member = "LoadSchemaFromLocation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XsdValidator), Member = "LoadSchemaFromLocation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Stream), typeof(XmlNameTable)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public XmlTextReader(string url, Stream input, XmlNameTable nt) { }

	[CallerCount(Count = 23)]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextReader)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public XmlTextReader(TextReader input) { }

	[CalledBy(Type = typeof(XmlDocument), Member = "LoadXml", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextReader), typeof(XmlNameTable)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public XmlTextReader(TextReader input, XmlNameTable nt) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public virtual void Close() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public virtual int get_AttributeCount() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public virtual string get_BaseURI() { }

	[CallerCount(Count = 271)]
	[DeduplicatedMethod]
	public virtual bool get_CanReadValueChunk() { }

	[CallerCount(Count = 23)]
	[DeduplicatedMethod]
	public virtual bool get_CanResolveEntity() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public virtual int get_Depth() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	internal virtual IDtdInfo get_DtdInfo() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public virtual bool get_EOF() { }

	[CallerCount(Count = 106)]
	[DeduplicatedMethod]
	internal XmlTextReaderImpl get_Impl() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public virtual bool get_IsDefault() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public virtual bool get_IsEmptyElement() { }

	[CalledBy(Type = typeof(XmlSerializationReader), Member = "UnknownAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(XmlAttribute), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSerializationReader), Member = "UnknownElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(XmlElement), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSerializationReader), Member = "OnUnknownNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNode), typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "get_LineNumber", ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 1)]
	public override int get_LineNumber() { }

	[CalledBy(Type = typeof(XmlSerializationReader), Member = "UnknownAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(XmlAttribute), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSerializationReader), Member = "UnknownElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(XmlElement), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSerializationReader), Member = "OnUnknownNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNode), typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "get_LinePosition", ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 1)]
	public override int get_LinePosition() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public virtual string get_LocalName() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public virtual string get_Name() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	internal virtual XmlNamespaceManager get_NamespaceManager() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public bool get_Namespaces() { }

	[CallerCount(Count = 12)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public virtual string get_NamespaceURI() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public virtual XmlNameTable get_NameTable() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public virtual XmlNodeType get_NodeType() { }

	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public bool get_Normalization() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public virtual string get_Prefix() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public virtual char get_QuoteChar() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public virtual ReadState get_ReadState() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public virtual string get_Value() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public virtual string get_XmlLang() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public virtual XmlSpace get_XmlSpace() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public virtual string GetAttribute(int i) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public virtual string GetAttribute(string localName, string namespaceURI) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public virtual string GetAttribute(string name) { }

	[CallerCount(Count = 23)]
	[DeduplicatedMethod]
	public override bool HasLineInfo() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public virtual string LookupNamespace(string prefix) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public virtual void MoveToAttribute(int i) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public virtual bool MoveToAttribute(string name) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public virtual bool MoveToElement() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public virtual bool MoveToFirstAttribute() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public virtual bool MoveToNextAttribute() { }

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public virtual bool Read() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public virtual bool ReadAttributeValue() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "MoveOffEntityReference", ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlReader), Member = "ReadString", ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 1)]
	public virtual string ReadString() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public virtual void ResolveEntity() { }

	[CalledBy(Type = typeof(XmlDocument), Member = "SetupReader", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlTextReader)}, ReturnType = typeof(XmlTextReader))]
	[CalledBy(Type = typeof(XmlDocument), Member = "LoadXml", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "set_EntityHandling", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EntityHandling)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void set_EntityHandling(EntityHandling value) { }

	[CalledBy(Type = typeof(XmlSerializer), Member = "Deserialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextReader)}, ReturnType = typeof(object))]
	[CalledBy(Type = "System.Data.DataSet", Member = "System.Xml.Serialization.IXmlSerializable.ReadXml", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlReader)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "set_Normalization", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void set_Normalization(bool value) { }

	[CalledBy(Type = typeof(XmlSerializer), Member = "Deserialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextReader)}, ReturnType = typeof(object))]
	[CalledBy(Type = "System.Data.DataSet", Member = "ReadXmlSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlReader), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Data.DataSet", Member = "ReadXml", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlReader), typeof(bool)}, ReturnType = "System.Data.XmlReadMode")]
	[CalledBy(Type = "System.Data.DataSet", Member = "ReadXml", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlReader), "System.Data.XmlReadMode", typeof(bool)}, ReturnType = "System.Data.XmlReadMode")]
	[CalledBy(Type = "System.Data.DataTable", Member = "ReadXml", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlReader), "System.Data.XmlReadMode", typeof(bool)}, ReturnType = "System.Data.XmlReadMode")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "set_WhitespaceHandling", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WhitespaceHandling)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void set_WhitespaceHandling(WhitespaceHandling value) { }

	[CalledBy(Type = typeof(XmlDocument), Member = "SetupReader", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlTextReader)}, ReturnType = typeof(XmlTextReader))]
	[CalledBy(Type = typeof(XmlDocument), Member = "LoadXml", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SchemaCollectionPreprocessor), Member = "LoadExternals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchema), typeof(XmlSchemaCollection)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XdrValidator), Member = "LoadSchemaFromLocation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "set_XmlResolver", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlResolver)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void set_XmlResolver(XmlResolver value) { }

	[CalledBy(Type = typeof(XmlDocument), Member = "SetupReader", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlTextReader)}, ReturnType = typeof(XmlTextReader))]
	[CalledBy(Type = typeof(XmlDocument), Member = "LoadXml", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "set_XmlValidatingReaderCompatibilityMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 15)]
	internal void set_XmlValidatingReaderCompatibilityMode(bool value) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public virtual void Skip() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private override IDictionary<String, String> System.Xml.IXmlNamespaceResolver.GetNamespacesInScope(XmlNamespaceScope scope) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	private override string System.Xml.IXmlNamespaceResolver.LookupNamespace(string prefix) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private override string System.Xml.IXmlNamespaceResolver.LookupPrefix(string namespaceName) { }

}

