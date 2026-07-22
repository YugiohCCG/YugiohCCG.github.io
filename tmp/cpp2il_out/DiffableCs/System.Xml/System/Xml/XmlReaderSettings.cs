namespace System.Xml;

public sealed class XmlReaderSettings
{
	private static Nullable<Boolean> s_enableLegacyXmlSettings; //Field offset: 0x0
	private bool useAsync; //Field offset: 0x10
	private XmlNameTable nameTable; //Field offset: 0x18
	private XmlResolver xmlResolver; //Field offset: 0x20
	private int lineNumberOffset; //Field offset: 0x28
	private int linePositionOffset; //Field offset: 0x2C
	private ConformanceLevel conformanceLevel; //Field offset: 0x30
	private bool checkCharacters; //Field offset: 0x34
	private long maxCharactersInDocument; //Field offset: 0x38
	private long maxCharactersFromEntities; //Field offset: 0x40
	private bool ignoreWhitespace; //Field offset: 0x48
	private bool ignorePIs; //Field offset: 0x49
	private bool ignoreComments; //Field offset: 0x4A
	private DtdProcessing dtdProcessing; //Field offset: 0x4C
	private ValidationType validationType; //Field offset: 0x50
	private XmlSchemaValidationFlags validationFlags; //Field offset: 0x54
	private XmlSchemaSet schemas; //Field offset: 0x58
	private ValidationEventHandler valEventHandler; //Field offset: 0x60
	private bool closeInput; //Field offset: 0x68
	private bool isReadOnly; //Field offset: 0x69
	[CompilerGenerated]
	private bool <IsXmlResolverSet>k__BackingField; //Field offset: 0x6A

	public bool Async
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(XmlReaderSettings), Member = "CheckReadOnly", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		 set { } //Length: 77
	}

	public bool CheckCharacters
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CalledBy(Type = typeof(XmlSqlBinaryReader), Member = "get_Settings", ReturnType = typeof(XmlReaderSettings))]
		[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "get_Settings", ReturnType = typeof(XmlReaderSettings))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(XmlReaderSettings), Member = "CheckReadOnly", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		 set { } //Length: 77
	}

	public bool CloseInput
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CalledBy(Type = typeof(XmlSqlBinaryReader), Member = "get_Settings", ReturnType = typeof(XmlReaderSettings))]
		[CalledBy(Type = typeof(Preprocessor), Member = "LoadExternals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchema)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XmlSchemaValidator), Member = "LoadSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
		[CalledBy(Type = "System.Data.SqlTypes.SqlXml", Member = ".cctor", ReturnType = typeof(void))]
		[CallerCount(Count = 5)]
		[Calls(Type = typeof(XmlReaderSettings), Member = "CheckReadOnly", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		 set { } //Length: 77
	}

	public ConformanceLevel ConformanceLevel
	{
		[CallerCount(Count = 3)]
		[DeduplicatedMethod]
		 get { } //Length: 4
		[CalledBy(Type = typeof(XmlSqlBinaryReader), Member = "get_Settings", ReturnType = typeof(XmlReaderSettings))]
		[CalledBy(Type = typeof(XmlSqlBinaryReader), Member = "ImplReadXmlText", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "get_Settings", ReturnType = typeof(XmlReaderSettings))]
		[CalledBy(Type = "System.Data.SqlTypes.SqlXml", Member = ".cctor", ReturnType = typeof(void))]
		[CallerCount(Count = 5)]
		[Calls(Type = typeof(XmlReaderSettings), Member = "CheckReadOnly", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 4)]
		 set { } //Length: 152
	}

	public DtdProcessing DtdProcessing
	{
		[CallerCount(Count = 8)]
		[DeduplicatedMethod]
		 get { } //Length: 4
		[CalledBy(Type = typeof(XmlSqlBinaryReader), Member = "get_Settings", ReturnType = typeof(XmlReaderSettings))]
		[CalledBy(Type = typeof(XmlSqlBinaryReader), Member = "ImplReadXmlText", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "get_Settings", ReturnType = typeof(XmlReaderSettings))]
		[CalledBy(Type = typeof(XsdValidatingReader), Member = "SetupValidator", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlReaderSettings), typeof(XmlReader), typeof(XmlSchemaObject)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XmlSchemaSet), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNameTable)}, ReturnType = typeof(void))]
		[CallerCount(Count = 5)]
		[Calls(Type = typeof(XmlReaderSettings), Member = "CheckReadOnly", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 4)]
		 set { } //Length: 152
	}

	public bool IgnoreComments
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CalledBy(Type = typeof(XmlSqlBinaryReader), Member = "get_Settings", ReturnType = typeof(XmlReaderSettings))]
		[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "get_Settings", ReturnType = typeof(XmlReaderSettings))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(XmlReaderSettings), Member = "CheckReadOnly", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		 set { } //Length: 77
	}

	public bool IgnoreProcessingInstructions
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CalledBy(Type = typeof(XmlSqlBinaryReader), Member = "get_Settings", ReturnType = typeof(XmlReaderSettings))]
		[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "get_Settings", ReturnType = typeof(XmlReaderSettings))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(XmlReaderSettings), Member = "CheckReadOnly", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		 set { } //Length: 77
	}

	public bool IgnoreWhitespace
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CalledBy(Type = typeof(XmlSqlBinaryReader), Member = "get_Settings", ReturnType = typeof(XmlReaderSettings))]
		[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "get_Settings", ReturnType = typeof(XmlReaderSettings))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(XmlReaderSettings), Member = "CheckReadOnly", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		 set { } //Length: 77
	}

	internal bool IsXmlResolverSet
	{
		[CallerCount(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		internal get { } //Length: 5
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		internal set { } //Length: 4
	}

	public int LineNumberOffset
	{
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 4
		[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "get_Settings", ReturnType = typeof(XmlReaderSettings))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(XmlReaderSettings), Member = "CheckReadOnly", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		 set { } //Length: 75
	}

	public int LinePositionOffset
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 4
		[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "get_Settings", ReturnType = typeof(XmlReaderSettings))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(XmlReaderSettings), Member = "CheckReadOnly", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		 set { } //Length: 75
	}

	public long MaxCharactersFromEntities
	{
		[CallerCount(Count = 12)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "get_Settings", ReturnType = typeof(XmlReaderSettings))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(XmlReaderSettings), Member = "CheckReadOnly", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 4)]
		 set { } //Length: 154
	}

	public long MaxCharactersInDocument
	{
		[CallerCount(Count = 38)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "get_Settings", ReturnType = typeof(XmlReaderSettings))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(XmlReaderSettings), Member = "CheckReadOnly", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 4)]
		 set { } //Length: 154
	}

	public XmlNameTable NameTable
	{
		[CallerCount(Count = 31)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CalledBy(Type = typeof(XmlSqlBinaryReader), Member = "get_Settings", ReturnType = typeof(XmlReaderSettings))]
		[CalledBy(Type = typeof(XmlSqlBinaryReader), Member = "ImplReadXmlText", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "get_Settings", ReturnType = typeof(XmlReaderSettings))]
		[CalledBy(Type = typeof(XmlSchemaSet), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNameTable)}, ReturnType = typeof(void))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(XmlReaderSettings), Member = "CheckReadOnly", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		 set { } //Length: 88
	}

	internal bool ReadOnly
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		internal set { } //Length: 4
	}

	public XmlSchemaSet Schemas
	{
		[CalledBy(Type = typeof(XsdValidatingReader), Member = "SetupValidator", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlReaderSettings), typeof(XmlReader), typeof(XmlSchemaObject)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XmlLoader), Member = "Load", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlDocument), typeof(XmlReader), typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(XmlSchemaSet), Member = ".ctor", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 105
		[CalledBy(Type = typeof(XsdValidatingReader), Member = "get_Settings", ReturnType = typeof(XmlReaderSettings))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(XmlReaderSettings), Member = "CheckReadOnly", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		 set { } //Length: 88
	}

	public XmlSchemaValidationFlags ValidationFlags
	{
		[CallerCount(Count = 14)]
		[DeduplicatedMethod]
		 get { } //Length: 4
		[CalledBy(Type = typeof(XmlValidatingReaderImpl), Member = "get_Settings", ReturnType = typeof(XmlReaderSettings))]
		[CalledBy(Type = typeof(XsdValidatingReader), Member = "get_Settings", ReturnType = typeof(XmlReaderSettings))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(XmlReaderSettings), Member = "CheckReadOnly", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 4)]
		 set { } //Length: 152
	}

	public ValidationType ValidationType
	{
		[CallerCount(Count = 7)]
		[DeduplicatedMethod]
		 get { } //Length: 4
		[CalledBy(Type = typeof(XmlValidatingReaderImpl), Member = "get_Settings", ReturnType = typeof(XmlReaderSettings))]
		[CalledBy(Type = typeof(XsdValidatingReader), Member = "get_Settings", ReturnType = typeof(XmlReaderSettings))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(XmlReaderSettings), Member = "CheckReadOnly", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 4)]
		 set { } //Length: 152
	}

	public XmlResolver XmlResolver
	{
		[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "get_Settings", ReturnType = typeof(XmlReaderSettings))]
		[CalledBy(Type = typeof(Preprocessor), Member = "LoadExternals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchema)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XmlSchemaSet), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNameTable)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XmlSchemaSet), Member = "set_XmlResolver", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlResolver)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XmlSchemaValidator), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNameTable), typeof(XmlSchemaSet), typeof(IXmlNamespaceResolver), typeof(XmlSchemaValidationFlags)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XmlSchemaValidator), Member = "LoadSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
		[CallerCount(Count = 7)]
		[Calls(Type = typeof(XmlReaderSettings), Member = "CheckReadOnly", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		 set { } //Length: 93
	}

	[CalledBy(Type = typeof(XmlSqlBinaryReader), Member = "get_Settings", ReturnType = typeof(XmlReaderSettings))]
	[CalledBy(Type = typeof(XmlAsyncCheckReader), Member = "get_Settings", ReturnType = typeof(XmlReaderSettings))]
	[CalledBy(Type = typeof(XmlReader), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(XmlReaderSettings), typeof(string)}, ReturnType = typeof(XmlReader))]
	[CalledBy(Type = typeof(XmlReader), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextReader), typeof(XmlReaderSettings), typeof(string)}, ReturnType = typeof(XmlReader))]
	[CalledBy(Type = typeof(XmlReader), Member = "CreateSqlReader", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(XmlReaderSettings), typeof(XmlParserContext)}, ReturnType = typeof(XmlReader))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "get_Settings", ReturnType = typeof(XmlReaderSettings))]
	[CalledBy(Type = typeof(XmlValidatingReaderImpl), Member = "get_Settings", ReturnType = typeof(XmlReaderSettings))]
	[CalledBy(Type = typeof(XsdValidatingReader), Member = "get_Settings", ReturnType = typeof(XmlReaderSettings))]
	[CalledBy(Type = typeof(XmlSchemaSet), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNameTable)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Data.SqlTypes.SqlXml", Member = ".cctor", ReturnType = typeof(void))]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(XmlReaderSettings), Member = "EnableLegacyXmlSettings", ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public XmlReaderSettings() { }

	[CalledBy(Type = typeof(XmlReader), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(XmlReaderSettings), typeof(string)}, ReturnType = typeof(XmlReader))]
	[CalledBy(Type = typeof(XmlReader), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextReader), typeof(XmlReaderSettings), typeof(string)}, ReturnType = typeof(XmlReader))]
	[CalledBy(Type = typeof(XmlReader), Member = "CreateSqlReader", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(XmlReaderSettings), typeof(XmlParserContext)}, ReturnType = typeof(XmlReader))]
	[CalledBy(Type = typeof(XmlReaderSettings), Member = "CreateReader", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(Uri), typeof(string), typeof(XmlParserContext)}, ReturnType = typeof(XmlReader))]
	[CalledBy(Type = typeof(XmlReaderSettings), Member = "CreateReader", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextReader), typeof(string), typeof(XmlParserContext)}, ReturnType = typeof(XmlReader))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(XmlValidatingReaderImpl), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlReader), typeof(ValidationEventHandler), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlReaderSettings), Member = "EnableLegacyXmlSettings", ReturnType = typeof(bool))]
	[Calls(Type = typeof(XsdValidatingReader), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlReader), typeof(XmlResolver), typeof(XmlReaderSettings)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	internal XmlReader AddValidation(XmlReader reader) { }

	[CalledBy(Type = typeof(XmlAsyncCheckReader), Member = "get_Settings", ReturnType = typeof(XmlReaderSettings))]
	[CalledBy(Type = typeof(XmlReaderSettings), Member = "set_Schemas", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaSet)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlReaderSettings), Member = "set_ValidationFlags", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaValidationFlags)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlReaderSettings), Member = "set_ValidationType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ValidationType)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlReaderSettings), Member = "set_CloseInput", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlReaderSettings), Member = "set_DtdProcessing", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DtdProcessing)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlReaderSettings), Member = "set_IgnoreComments", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlReaderSettings), Member = "set_IgnoreWhitespace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlReaderSettings), Member = "set_MaxCharactersFromEntities", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlReaderSettings), Member = "set_IgnoreProcessingInstructions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlReaderSettings), Member = "set_CheckCharacters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlReaderSettings), Member = "set_ConformanceLevel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ConformanceLevel)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlReaderSettings), Member = "set_LinePositionOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlReaderSettings), Member = "set_LineNumberOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlReaderSettings), Member = "set_XmlResolver", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlResolver)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlReaderSettings), Member = "set_NameTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNameTable)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlReaderSettings), Member = "set_Async", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlReaderSettings), Member = "set_MaxCharactersInDocument", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(void))]
	[CallerCount(Count = 18)]
	[Calls(Type = typeof(XmlException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 7)]
	private void CheckReadOnly(string propertyName) { }

	[CalledBy(Type = typeof(XmlValidatingReaderImpl), Member = "get_Settings", ReturnType = typeof(XmlReaderSettings))]
	[CalledBy(Type = typeof(XsdValidatingReader), Member = "get_Settings", ReturnType = typeof(XmlReaderSettings))]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public XmlReaderSettings Clone() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private static XmlResolver CreateDefaultResolver() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlValidatingReaderImpl), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlReader), typeof(ValidationEventHandler), typeof(bool)}, ReturnType = typeof(void))]
	[ContainsUnimplementedInstructions]
	private XmlValidatingReaderImpl CreateDtdValidatingReader(XmlReader baseReader) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextReader), typeof(XmlReaderSettings), typeof(string), typeof(XmlParserContext)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlReaderSettings), Member = "AddValidation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlReader)}, ReturnType = typeof(XmlReader))]
	[Calls(Type = typeof(XmlAsyncCheckReader), Member = "CreateAsyncCheckWrapper", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlReader)}, ReturnType = typeof(XmlAsyncCheckReader))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	internal XmlReader CreateReader(TextReader input, string baseUriString, XmlParserContext inputContext) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Uri), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(Uri)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(Byte[]), typeof(int), typeof(XmlReaderSettings), typeof(Uri), typeof(string), typeof(XmlParserContext), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlReaderSettings), Member = "AddValidation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlReader)}, ReturnType = typeof(XmlReader))]
	[Calls(Type = typeof(XmlAsyncCheckReader), Member = "CreateAsyncCheckWrapper", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlReader)}, ReturnType = typeof(XmlAsyncCheckReader))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	internal XmlReader CreateReader(Stream input, Uri baseUri, string baseUriString, XmlParserContext inputContext) { }

	[CalledBy(Type = typeof(XmlReaderSettings), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlReaderSettings), Member = "Initialize", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlReaderSettings), Member = "Initialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlResolver)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlReaderSettings), Member = "AddValidation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlReader)}, ReturnType = typeof(XmlReader))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNameTable)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "get_Settings", ReturnType = typeof(XmlReaderSettings))]
	[CalledBy(Type = typeof(XmlValidatingReaderImpl), Member = "GetResolver", ReturnType = typeof(XmlResolver))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(Nullable`1), Member = "get_Value", ReturnType = "T")]
	[CallsDeduplicatedMethods(Count = 2)]
	internal static bool EnableLegacyXmlSettings() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public bool get_Async() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public bool get_CheckCharacters() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public bool get_CloseInput() { }

	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	public ConformanceLevel get_ConformanceLevel() { }

	[CallerCount(Count = 8)]
	[DeduplicatedMethod]
	public DtdProcessing get_DtdProcessing() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public bool get_IgnoreComments() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public bool get_IgnoreProcessingInstructions() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public bool get_IgnoreWhitespace() { }

	[CallerCount(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	internal bool get_IsXmlResolverSet() { }

	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	public int get_LineNumberOffset() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public int get_LinePositionOffset() { }

	[CallerCount(Count = 12)]
	[DeduplicatedMethod]
	public long get_MaxCharactersFromEntities() { }

	[CallerCount(Count = 38)]
	[DeduplicatedMethod]
	public long get_MaxCharactersInDocument() { }

	[CallerCount(Count = 31)]
	[DeduplicatedMethod]
	public XmlNameTable get_NameTable() { }

	[CalledBy(Type = typeof(XsdValidatingReader), Member = "SetupValidator", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlReaderSettings), typeof(XmlReader), typeof(XmlSchemaObject)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlLoader), Member = "Load", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlDocument), typeof(XmlReader), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(XmlSchemaSet), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public XmlSchemaSet get_Schemas() { }

	[CallerCount(Count = 14)]
	[DeduplicatedMethod]
	public XmlSchemaValidationFlags get_ValidationFlags() { }

	[CallerCount(Count = 7)]
	[DeduplicatedMethod]
	public ValidationType get_ValidationType() { }

	[CallerCount(Count = 84)]
	[DeduplicatedMethod]
	internal ValidationEventHandler GetEventHandler() { }

	[CallerCount(Count = 12)]
	[DeduplicatedMethod]
	internal XmlResolver GetXmlResolver() { }

	[CalledBy(Type = typeof(XmlSchemaSet), Member = "PreprocessSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchema&), typeof(string)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XmlSchemaSet), Member = "ParseSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(XmlReader)}, ReturnType = typeof(XmlSchema))]
	[CalledBy(Type = typeof(XmlSchemaSet), Member = "GetResolver", ReturnType = typeof(XmlResolver))]
	[CalledBy(Type = typeof(XmlSchemaValidator), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNameTable), typeof(XmlSchemaSet), typeof(IXmlNamespaceResolver), typeof(XmlSchemaValidationFlags)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 1)]
	internal XmlResolver GetXmlResolver_CheckConfig() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlReaderSettings), Member = "EnableLegacyXmlSettings", ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private void Initialize(XmlResolver resolver) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlReaderSettings), Member = "EnableLegacyXmlSettings", ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private void Initialize() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlReaderSettings), Member = "CheckReadOnly", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	public void set_Async(bool value) { }

	[CalledBy(Type = typeof(XmlSqlBinaryReader), Member = "get_Settings", ReturnType = typeof(XmlReaderSettings))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "get_Settings", ReturnType = typeof(XmlReaderSettings))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(XmlReaderSettings), Member = "CheckReadOnly", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	public void set_CheckCharacters(bool value) { }

	[CalledBy(Type = typeof(XmlSqlBinaryReader), Member = "get_Settings", ReturnType = typeof(XmlReaderSettings))]
	[CalledBy(Type = typeof(Preprocessor), Member = "LoadExternals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchema)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSchemaValidator), Member = "LoadSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Data.SqlTypes.SqlXml", Member = ".cctor", ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(XmlReaderSettings), Member = "CheckReadOnly", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	public void set_CloseInput(bool value) { }

	[CalledBy(Type = typeof(XmlSqlBinaryReader), Member = "get_Settings", ReturnType = typeof(XmlReaderSettings))]
	[CalledBy(Type = typeof(XmlSqlBinaryReader), Member = "ImplReadXmlText", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "get_Settings", ReturnType = typeof(XmlReaderSettings))]
	[CalledBy(Type = "System.Data.SqlTypes.SqlXml", Member = ".cctor", ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(XmlReaderSettings), Member = "CheckReadOnly", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	public void set_ConformanceLevel(ConformanceLevel value) { }

	[CalledBy(Type = typeof(XmlSqlBinaryReader), Member = "get_Settings", ReturnType = typeof(XmlReaderSettings))]
	[CalledBy(Type = typeof(XmlSqlBinaryReader), Member = "ImplReadXmlText", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "get_Settings", ReturnType = typeof(XmlReaderSettings))]
	[CalledBy(Type = typeof(XsdValidatingReader), Member = "SetupValidator", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlReaderSettings), typeof(XmlReader), typeof(XmlSchemaObject)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSchemaSet), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNameTable)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(XmlReaderSettings), Member = "CheckReadOnly", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	public void set_DtdProcessing(DtdProcessing value) { }

	[CalledBy(Type = typeof(XmlSqlBinaryReader), Member = "get_Settings", ReturnType = typeof(XmlReaderSettings))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "get_Settings", ReturnType = typeof(XmlReaderSettings))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(XmlReaderSettings), Member = "CheckReadOnly", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	public void set_IgnoreComments(bool value) { }

	[CalledBy(Type = typeof(XmlSqlBinaryReader), Member = "get_Settings", ReturnType = typeof(XmlReaderSettings))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "get_Settings", ReturnType = typeof(XmlReaderSettings))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(XmlReaderSettings), Member = "CheckReadOnly", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	public void set_IgnoreProcessingInstructions(bool value) { }

	[CalledBy(Type = typeof(XmlSqlBinaryReader), Member = "get_Settings", ReturnType = typeof(XmlReaderSettings))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "get_Settings", ReturnType = typeof(XmlReaderSettings))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(XmlReaderSettings), Member = "CheckReadOnly", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	public void set_IgnoreWhitespace(bool value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	internal void set_IsXmlResolverSet(bool value) { }

	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "get_Settings", ReturnType = typeof(XmlReaderSettings))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(XmlReaderSettings), Member = "CheckReadOnly", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	public void set_LineNumberOffset(int value) { }

	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "get_Settings", ReturnType = typeof(XmlReaderSettings))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(XmlReaderSettings), Member = "CheckReadOnly", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	public void set_LinePositionOffset(int value) { }

	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "get_Settings", ReturnType = typeof(XmlReaderSettings))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(XmlReaderSettings), Member = "CheckReadOnly", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	public void set_MaxCharactersFromEntities(long value) { }

	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "get_Settings", ReturnType = typeof(XmlReaderSettings))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(XmlReaderSettings), Member = "CheckReadOnly", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	public void set_MaxCharactersInDocument(long value) { }

	[CalledBy(Type = typeof(XmlSqlBinaryReader), Member = "get_Settings", ReturnType = typeof(XmlReaderSettings))]
	[CalledBy(Type = typeof(XmlSqlBinaryReader), Member = "ImplReadXmlText", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "get_Settings", ReturnType = typeof(XmlReaderSettings))]
	[CalledBy(Type = typeof(XmlSchemaSet), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNameTable)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(XmlReaderSettings), Member = "CheckReadOnly", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void set_NameTable(XmlNameTable value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	internal void set_ReadOnly(bool value) { }

	[CalledBy(Type = typeof(XsdValidatingReader), Member = "get_Settings", ReturnType = typeof(XmlReaderSettings))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(XmlReaderSettings), Member = "CheckReadOnly", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void set_Schemas(XmlSchemaSet value) { }

	[CalledBy(Type = typeof(XmlValidatingReaderImpl), Member = "get_Settings", ReturnType = typeof(XmlReaderSettings))]
	[CalledBy(Type = typeof(XsdValidatingReader), Member = "get_Settings", ReturnType = typeof(XmlReaderSettings))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(XmlReaderSettings), Member = "CheckReadOnly", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	public void set_ValidationFlags(XmlSchemaValidationFlags value) { }

	[CalledBy(Type = typeof(XmlValidatingReaderImpl), Member = "get_Settings", ReturnType = typeof(XmlReaderSettings))]
	[CalledBy(Type = typeof(XsdValidatingReader), Member = "get_Settings", ReturnType = typeof(XmlReaderSettings))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(XmlReaderSettings), Member = "CheckReadOnly", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	public void set_ValidationType(ValidationType value) { }

	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "get_Settings", ReturnType = typeof(XmlReaderSettings))]
	[CalledBy(Type = typeof(Preprocessor), Member = "LoadExternals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchema)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSchemaSet), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNameTable)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSchemaSet), Member = "set_XmlResolver", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlResolver)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSchemaValidator), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNameTable), typeof(XmlSchemaSet), typeof(IXmlNamespaceResolver), typeof(XmlSchemaValidationFlags)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSchemaValidator), Member = "LoadSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(XmlReaderSettings), Member = "CheckReadOnly", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void set_XmlResolver(XmlResolver value) { }

}

