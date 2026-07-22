namespace System.Xml;

[DebuggerDisplay("{debuggerDisplayProxy}")]
[DebuggerDisplay("{debuggerDisplayProxy}")]
[DefaultMember("Item")]
public abstract class XmlReader : IDisposable
{
	private static uint IsTextualNodeBitmap; //Field offset: 0x0
	private static uint CanReadContentAsBitmap; //Field offset: 0x4
	private static uint HasValueBitmap; //Field offset: 0x8

	public abstract int AttributeCount
	{
		 get { } //Length: 0
	}

	public abstract string BaseURI
	{
		 get { } //Length: 0
	}

	public override bool CanReadValueChunk
	{
		[CallerCount(Count = 271)]
		[DeduplicatedMethod]
		 get { } //Length: 3
	}

	public override bool CanResolveEntity
	{
		[CallerCount(Count = 271)]
		[DeduplicatedMethod]
		 get { } //Length: 3
	}

	public abstract int Depth
	{
		 get { } //Length: 0
	}

	internal override IDtdInfo DtdInfo
	{
		[CallerCount(Count = 182)]
		[DeduplicatedMethod]
		internal get { } //Length: 3
	}

	public abstract bool EOF
	{
		 get { } //Length: 0
	}

	public override bool HasAttributes
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		 get { } //Length: 30
	}

	public override bool IsDefault
	{
		[CallerCount(Count = 271)]
		[DeduplicatedMethod]
		 get { } //Length: 3
	}

	internal bool IsDefaultInternal
	{
		[CalledBy(Type = typeof(XmlWriter), Member = "WriteAttributes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlReader), typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		internal get { } //Length: 124
	}

	public abstract bool IsEmptyElement
	{
		 get { } //Length: 0
	}

	public abstract string LocalName
	{
		 get { } //Length: 0
	}

	public override string Name
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
		[CallsDeduplicatedMethods(Count = 6)]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 244
	}

	internal override XmlNamespaceManager NamespaceManager
	{
		[CallerCount(Count = 182)]
		[DeduplicatedMethod]
		internal get { } //Length: 3
	}

	public abstract string NamespaceURI
	{
		 get { } //Length: 0
	}

	public abstract XmlNameTable NameTable
	{
		 get { } //Length: 0
	}

	public abstract XmlNodeType NodeType
	{
		 get { } //Length: 0
	}

	public abstract string Prefix
	{
		 get { } //Length: 0
	}

	public override char QuoteChar
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 6
	}

	public abstract ReadState ReadState
	{
		 get { } //Length: 0
	}

	public override IXmlSchemaInfo SchemaInfo
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 57
	}

	public override XmlReaderSettings Settings
	{
		[CallerCount(Count = 182)]
		[DeduplicatedMethod]
		 get { } //Length: 3
	}

	public abstract string Value
	{
		 get { } //Length: 0
	}

	public override Type ValueType
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
		[DeduplicatedMethod]
		 get { } //Length: 50
	}

	public override string XmlLang
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 18
	}

	public override XmlSpace XmlSpace
	{
		[CallerCount(Count = 182)]
		[DeduplicatedMethod]
		 get { } //Length: 3
	}

	[CallerCount(Count = 0)]
	private static XmlReader() { }

	[CallerCount(Count = 2180)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	protected XmlReader() { }

	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "InitStreamInput", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(string), typeof(Stream), typeof(Byte[]), typeof(int), typeof(Encoding)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	internal static int CalcBufferSize(Stream input) { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	public override void Close() { }

	[CalledBy(Type = typeof(Preprocessor), Member = "LoadExternals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchema)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(XmlReaderSettings), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextReader), typeof(XmlReaderSettings), typeof(string), typeof(XmlParserContext)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlReaderSettings), Member = "AddValidation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlReader)}, ReturnType = typeof(XmlReader))]
	[Calls(Type = typeof(XmlAsyncCheckReader), Member = "CreateAsyncCheckWrapper", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlReader)}, ReturnType = typeof(XmlAsyncCheckReader))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	public static XmlReader Create(TextReader input, XmlReaderSettings settings, string baseUri) { }

	[CalledBy(Type = typeof(Preprocessor), Member = "LoadExternals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchema)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSchemaValidator), Member = "LoadSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(XmlReaderSettings), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(Uri), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(Uri)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(Byte[]), typeof(int), typeof(XmlReaderSettings), typeof(Uri), typeof(string), typeof(XmlParserContext), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlReaderSettings), Member = "AddValidation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlReader)}, ReturnType = typeof(XmlReader))]
	[Calls(Type = typeof(XmlAsyncCheckReader), Member = "CreateAsyncCheckWrapper", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlReader)}, ReturnType = typeof(XmlAsyncCheckReader))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 6)]
	public static XmlReader Create(Stream input, XmlReaderSettings settings, string baseUri) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlReaderSettings), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSqlBinaryReader), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(Byte[]), typeof(int), typeof(string), typeof(bool), typeof(XmlReaderSettings)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(Byte[]), typeof(int), typeof(XmlReaderSettings), typeof(Uri), typeof(string), typeof(XmlParserContext), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlReaderSettings), Member = "AddValidation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlReader)}, ReturnType = typeof(XmlReader))]
	[Calls(Type = typeof(XmlAsyncCheckReader), Member = "CreateAsyncCheckWrapper", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlReader)}, ReturnType = typeof(XmlAsyncCheckReader))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 11)]
	internal static XmlReader CreateSqlReader(Stream input, XmlReaderSettings settings, XmlParserContext inputContext) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlTextWriter), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextWriter)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextWriter), Member = "set_Namespaces", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlValidatingReader), Member = "get_Namespaces", ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	private XmlWriter CreateWriterForInnerOuterXml(StringWriter sw) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public override void Dispose() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	protected override void Dispose(bool disposing) { }

	public abstract int get_AttributeCount() { }

	public abstract string get_BaseURI() { }

	[CallerCount(Count = 271)]
	[DeduplicatedMethod]
	public override bool get_CanReadValueChunk() { }

	[CallerCount(Count = 271)]
	[DeduplicatedMethod]
	public override bool get_CanResolveEntity() { }

	public abstract int get_Depth() { }

	[CallerCount(Count = 182)]
	[DeduplicatedMethod]
	internal override IDtdInfo get_DtdInfo() { }

	public abstract bool get_EOF() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public override bool get_HasAttributes() { }

	[CallerCount(Count = 271)]
	[DeduplicatedMethod]
	public override bool get_IsDefault() { }

	[CalledBy(Type = typeof(XmlWriter), Member = "WriteAttributes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlReader), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	internal bool get_IsDefaultInternal() { }

	public abstract bool get_IsEmptyElement() { }

	public abstract string get_LocalName() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 1)]
	public override string get_Name() { }

	[CallerCount(Count = 182)]
	[DeduplicatedMethod]
	internal override XmlNamespaceManager get_NamespaceManager() { }

	public abstract string get_NamespaceURI() { }

	public abstract XmlNameTable get_NameTable() { }

	public abstract XmlNodeType get_NodeType() { }

	public abstract string get_Prefix() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public override char get_QuoteChar() { }

	public abstract ReadState get_ReadState() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public override IXmlSchemaInfo get_SchemaInfo() { }

	[CallerCount(Count = 182)]
	[DeduplicatedMethod]
	public override XmlReaderSettings get_Settings() { }

	public abstract string get_Value() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[DeduplicatedMethod]
	public override Type get_ValueType() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public override string get_XmlLang() { }

	[CallerCount(Count = 182)]
	[DeduplicatedMethod]
	public override XmlSpace get_XmlSpace() { }

	public abstract string GetAttribute(int i) { }

	public abstract string GetAttribute(string name, string namespaceURI) { }

	public abstract string GetAttribute(string name) { }

	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ReadValueChunk", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[ContainsUnimplementedInstructions]
	internal static bool HasValueInternal(XmlNodeType nodeType) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 5)]
	public override bool IsStartElement(string localname, string ns) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	internal static bool IsTextualNode(XmlNodeType nodeType) { }

	public abstract string LookupNamespace(string prefix) { }

	public abstract bool MoveToAttribute(string name) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 4)]
	public override void MoveToAttribute(int i) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	public override XmlNodeType MoveToContent() { }

	public abstract bool MoveToElement() { }

	public abstract bool MoveToFirstAttribute() { }

	public abstract bool MoveToNextAttribute() { }

	public abstract bool Read() { }

	public abstract bool ReadAttributeValue() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Enum), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(XmlException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(IXmlLineInfo)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[]), typeof(IXmlLineInfo)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 26)]
	[EditorBrowsable(EditorBrowsableState::Never (1))]
	public override string ReadElementString() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Enum), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(XmlException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(IXmlLineInfo)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 9)]
	public override void ReadEndElement() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(StringWriter), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextWriter), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextWriter)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlValidatingReader), Member = "get_Namespaces", ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlTextWriter), Member = "set_Namespaces", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextWriter), Member = "set_QuoteChar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlReader), Member = "WriteNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlWriter), typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 18)]
	[CallsUnknownMethods(Count = 7)]
	public override string ReadInnerXml() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Enum), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(XmlException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(IXmlLineInfo)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 9)]
	public override void ReadStartElement() { }

	[CalledBy(Type = typeof(XmlTextReader), Member = "ReadString", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ReadString", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(XmlValidatingReaderImpl), Member = "ReadString", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(XmlNodeReader), Member = "ReadString", ReturnType = typeof(string))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallsUnknownMethods(Count = 4)]
	[EditorBrowsable(EditorBrowsableState::Never (1))]
	public override string ReadString() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public override int ReadValueChunk(Char[] buffer, int index, int count) { }

	public abstract void ResolveEntity() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlTextWriter), Member = "set_Namespaces", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlValidatingReader), Member = "get_Namespaces", ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	private void SetNamespacesFlag(XmlTextWriter xtw) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 9)]
	public override void Skip() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 8)]
	private bool SkipSubtree() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallsUnknownMethods(Count = 1)]
	private void WriteAttributeValue(XmlWriter xtw) { }

	[CalledBy(Type = typeof(XmlReader), Member = "ReadInnerXml", ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(XmlTextWriter), Member = "set_QuoteChar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 34)]
	[CallsUnknownMethods(Count = 5)]
	private void WriteNode(XmlWriter xtw, bool defattr) { }

}

