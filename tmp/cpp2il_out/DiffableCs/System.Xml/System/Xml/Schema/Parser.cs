namespace System.Xml.Schema;

internal sealed class Parser
{
	private SchemaType schemaType; //Field offset: 0x10
	private XmlNameTable nameTable; //Field offset: 0x18
	private SchemaNames schemaNames; //Field offset: 0x20
	private ValidationEventHandler eventHandler; //Field offset: 0x28
	private XmlNamespaceManager namespaceManager; //Field offset: 0x30
	private XmlReader reader; //Field offset: 0x38
	private PositionInfo positionInfo; //Field offset: 0x40
	private bool isProcessNamespaces; //Field offset: 0x48
	private int schemaXmlDepth; //Field offset: 0x4C
	private int markupDepth; //Field offset: 0x50
	private SchemaBuilder builder; //Field offset: 0x58
	private XmlSchema schema; //Field offset: 0x60
	private SchemaInfo xdrSchema; //Field offset: 0x68
	private XmlResolver xmlResolver; //Field offset: 0x70
	private XmlDocument dummyDocument; //Field offset: 0x78
	private bool processMarkup; //Field offset: 0x80
	private XmlNode parentNode; //Field offset: 0x88
	private XmlNamespaceManager annotationNSManager; //Field offset: 0x90
	private string xmlns; //Field offset: 0x98
	private XmlCharType xmlCharType; //Field offset: 0xA0

	public SchemaInfo XdrSchema
	{
		[CallerCount(Count = 22)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	internal XmlResolver XmlResolver
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		internal set { } //Length: 13
	}

	public XmlSchema XmlSchema
	{
		[CallerCount(Count = 84)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	[CalledBy(Type = typeof(XsdValidatingReader), Member = "ProcessElementEvent", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XsdValidator), Member = "LoadSchemaFromLocation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XsdValidator), Member = "ValidateElement", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSchemaSet), Member = "ParseSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(XmlReader)}, ReturnType = typeof(XmlSchema))]
	[CalledBy(Type = typeof(XmlSchema), Member = "Read", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlReader), typeof(ValidationEventHandler)}, ReturnType = typeof(XmlSchema))]
	[CalledBy(Type = typeof(XsdValidator), Member = "Validate", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XdrValidator), Member = "ValidateElement", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XdrBuilder), Member = "LoadSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(SchemaCollectionPreprocessor), Member = "LoadExternals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchema), typeof(XmlSchemaCollection)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Preprocessor), Member = "LoadExternals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchema)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XdrValidator), Member = "LoadSchemaFromLocation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(XmlCharType), Member = "get_Instance", ReturnType = typeof(XmlCharType))]
	[Calls(Type = typeof(XmlReaderSection), Member = "CreateDefaultResolver", ReturnType = typeof(XmlResolver))]
	[Calls(Type = typeof(XmlDocument), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	public Parser(SchemaType schemaType, XmlNameTable nameTable, SchemaNames schemaNames, ValidationEventHandler eventHandler) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 3)]
	private bool CheckSchemaRoot(SchemaType rootType, out string code) { }

	[CalledBy(Type = typeof(Parser), Member = "LoadElementNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(XmlElement))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	private XmlAttribute CreateXmlNsAttribute(string prefix, string value) { }

	[CallerCount(Count = 94)]
	[DeduplicatedMethod]
	public SchemaType FinishParsing() { }

	[CallerCount(Count = 22)]
	[DeduplicatedMethod]
	public SchemaInfo get_XdrSchema() { }

	[CallerCount(Count = 84)]
	[DeduplicatedMethod]
	public XmlSchema get_XmlSchema() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Parser), Member = "LoadEntityReferenceInAttribute", ReturnType = typeof(XmlEntityReference))]
	[Calls(Type = typeof(XmlLoader), Member = "UnexpectedNodeType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNodeType)}, ReturnType = typeof(Exception))]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallsUnknownMethods(Count = 5)]
	private XmlAttribute LoadAttributeNode() { }

	[CalledBy(Type = typeof(Parser), Member = "ProcessAppInfoDocMarkup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(XmlElement), Member = "set_IsEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Parser), Member = "LoadEntityReferenceInAttribute", ReturnType = typeof(XmlEntityReference))]
	[Calls(Type = typeof(XmlAttributeCollection), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlAttribute)}, ReturnType = typeof(XmlAttribute))]
	[Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Parser), Member = "CreateXmlNsAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(XmlAttribute))]
	[Calls(Type = typeof(XmlLoader), Member = "UnexpectedNodeType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNodeType)}, ReturnType = typeof(Exception))]
	[CallsDeduplicatedMethods(Count = 39)]
	[CallsUnknownMethods(Count = 6)]
	private XmlElement LoadElementNode(bool root) { }

	[CalledBy(Type = typeof(Parser), Member = "LoadElementNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(XmlElement))]
	[CalledBy(Type = typeof(Parser), Member = "LoadAttributeNode", ReturnType = typeof(XmlAttribute))]
	[CalledBy(Type = typeof(Parser), Member = "LoadEntityReferenceInAttribute", ReturnType = typeof(XmlEntityReference))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Parser), Member = "LoadEntityReferenceInAttribute", ReturnType = typeof(XmlEntityReference))]
	[Calls(Type = typeof(XmlLoader), Member = "UnexpectedNodeType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNodeType)}, ReturnType = typeof(Exception))]
	[CallsDeduplicatedMethods(Count = 13)]
	[CallsUnknownMethods(Count = 5)]
	private XmlEntityReference LoadEntityReferenceInAttribute() { }

	[CalledBy(Type = typeof(SchemaCollectionPreprocessor), Member = "LoadExternals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchema), typeof(XmlSchemaCollection)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XdrBuilder), Member = "LoadSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XdrValidator), Member = "LoadSchemaFromLocation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSchema), Member = "Read", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlReader), typeof(ValidationEventHandler)}, ReturnType = typeof(XmlSchema))]
	[CalledBy(Type = typeof(XmlSchemaSet), Member = "ParseSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(XmlReader)}, ReturnType = typeof(XmlSchema))]
	[CalledBy(Type = typeof(XsdValidator), Member = "LoadSchemaFromLocation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(Parser), Member = "StartParsing", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlReader), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Parser), Member = "ParseReaderNode", ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public SchemaType Parse(XmlReader reader, string targetNamespace) { }

	[CalledBy(Type = typeof(XsdValidatingReader), Member = "ProcessElementEvent", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XsdValidatingReader), Member = "ProcessInlineSchema", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Parser), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlReader), typeof(string)}, ReturnType = typeof(SchemaType))]
	[CalledBy(Type = typeof(Preprocessor), Member = "LoadExternals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchema)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XdrValidator), Member = "ValidateElement", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XdrValidator), Member = "ProcessInlineSchema", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XsdValidator), Member = "ProcessInlineSchema", ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(XmlCharType), Member = "IsOnlyWhitespace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlNamespaceManager), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNameTable)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Parser), Member = "ProcessAppInfoDocMarkup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 50)]
	[CallsUnknownMethods(Count = 8)]
	[ContainsUnimplementedInstructions]
	public bool ParseReaderNode() { }

	[CalledBy(Type = typeof(Parser), Member = "ParseReaderNode", ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Parser), Member = "LoadElementNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(XmlElement))]
	[CallsDeduplicatedMethods(Count = 18)]
	[CallsUnknownMethods(Count = 3)]
	private void ProcessAppInfoDocMarkup(bool root) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	internal void set_XmlResolver(XmlResolver value) { }

	[CalledBy(Type = typeof(XsdValidatingReader), Member = "ProcessElementEvent", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Parser), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlReader), typeof(string)}, ReturnType = typeof(SchemaType))]
	[CalledBy(Type = typeof(Preprocessor), Member = "LoadExternals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchema)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XdrValidator), Member = "ValidateElement", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XsdValidator), Member = "Validate", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XsdValidator), Member = "ValidateElement", ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(XmlSchemaException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XsdBuilder), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlReader), typeof(XmlNamespaceManager), typeof(XmlSchema), typeof(XmlNameTable), typeof(SchemaNames), typeof(ValidationEventHandler)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Uri), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(UriKind)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSchema), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlNamespaceManager), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNameTable)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SchemaInfo), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(SchemaNames), Member = "SchemaTypeFromRoot", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(SchemaType))]
	[Calls(Type = typeof(PositionInfo), Member = "GetPositionInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(PositionInfo))]
	[Calls(Type = typeof(XdrBuilder), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlReader), typeof(XmlNamespaceManager), typeof(SchemaInfo), typeof(string), typeof(XmlNameTable), typeof(SchemaNames), typeof(ValidationEventHandler)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 23)]
	public void StartParsing(XmlReader reader, string targetNamespace) { }

}

