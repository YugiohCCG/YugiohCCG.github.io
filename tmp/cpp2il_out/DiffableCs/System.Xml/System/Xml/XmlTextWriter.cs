namespace System.Xml;

[EditorBrowsable(EditorBrowsableState::Never (1))]
public class XmlTextWriter : XmlWriter
{
	private struct Namespace
	{
		internal string prefix; //Field offset: 0x0
		internal string ns; //Field offset: 0x8
		internal bool declared; //Field offset: 0x10
		internal int prevNsIndex; //Field offset: 0x14

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		internal void Set(string prefix, string ns, bool declared) { }

	}

	private enum NamespaceState
	{
		Uninitialized = 0,
		NotDeclaredButInScope = 1,
		DeclaredButNotWrittenOut = 2,
		DeclaredAndWrittenOut = 3,
	}

	private enum SpecialAttr
	{
		None = 0,
		XmlSpace = 1,
		XmlLang = 2,
		XmlNs = 3,
	}

	private enum State
	{
		Start = 0,
		Prolog = 1,
		PostDTD = 2,
		Element = 3,
		Attribute = 4,
		Content = 5,
		AttrOnly = 6,
		Epilog = 7,
		Error = 8,
		Closed = 9,
	}

	private struct TagInfo
	{
		internal string name; //Field offset: 0x0
		internal string prefix; //Field offset: 0x8
		internal string defaultNs; //Field offset: 0x10
		internal NamespaceState defaultNsState; //Field offset: 0x18
		internal XmlSpace xmlSpace; //Field offset: 0x1C
		internal string xmlLang; //Field offset: 0x20
		internal int prevNsTop; //Field offset: 0x28
		internal int prefixCount; //Field offset: 0x2C
		internal bool mixed; //Field offset: 0x30

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 3)]
		internal void Init(int nsTop) { }

	}

	private enum Token
	{
		PI = 0,
		Doctype = 1,
		Comment = 2,
		CData = 3,
		StartElement = 4,
		EndElement = 5,
		LongEndElement = 6,
		StartAttribute = 7,
		EndAttribute = 8,
		Content = 9,
		Base64 = 10,
		RawData = 11,
		Whitespace = 12,
		Empty = 13,
	}

	private static String[] stateName; //Field offset: 0x0
	private static String[] tokenName; //Field offset: 0x8
	private static readonly State[] stateTableDefault; //Field offset: 0x10
	private static readonly State[] stateTableDocument; //Field offset: 0x18
	private TextWriter textWriter; //Field offset: 0x18
	private XmlTextEncoder xmlEncoder; //Field offset: 0x20
	private Encoding encoding; //Field offset: 0x28
	private Formatting formatting; //Field offset: 0x30
	private bool indented; //Field offset: 0x34
	private int indentation; //Field offset: 0x38
	private char indentChar; //Field offset: 0x3C
	private TagInfo[] stack; //Field offset: 0x40
	private int top; //Field offset: 0x48
	private State[] stateTable; //Field offset: 0x50
	private State currentState; //Field offset: 0x58
	private Token lastToken; //Field offset: 0x5C
	private XmlTextWriterBase64Encoder base64Encoder; //Field offset: 0x60
	private char quoteChar; //Field offset: 0x68
	private char curQuoteChar; //Field offset: 0x6A
	private bool namespaces; //Field offset: 0x6C
	private SpecialAttr specialAttr; //Field offset: 0x70
	private string prefixForXmlNs; //Field offset: 0x78
	private bool flush; //Field offset: 0x80
	private Namespace[] nsStack; //Field offset: 0x88
	private int nsTop; //Field offset: 0x90
	private Dictionary<String, Int32> nsHashtable; //Field offset: 0x98
	private bool useNsHashtable; //Field offset: 0xA0
	private XmlCharType xmlCharType; //Field offset: 0xA8

	public Stream BaseStream
	{
		[CalledBy(Type = "System.Data.XmlTreeGen", Member = "SetPath", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlWriter)}, ReturnType = typeof(void))]
		[CalledBy(Type = "System.Data.DataTextWriter", Member = "get_BaseStream", ReturnType = typeof(Stream))]
		[CallerCount(Count = 3)]
		[CallsDeduplicatedMethods(Count = 1)]
		 get { } //Length: 117
	}

	public Formatting Formatting
	{
		[CalledBy(Type = typeof(XmlSerializer), Member = "Serialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextWriter), typeof(object)}, ReturnType = typeof(void))]
		[CalledBy(Type = "System.Data.DataSet", Member = "SerializeDataSet", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(StreamingContext), "System.Data.SerializationFormat"}, ReturnType = typeof(void))]
		[CalledBy(Type = "System.Data.DataSet", Member = "GetRemotingDiffGram", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Data.DataTable"}, ReturnType = typeof(string))]
		[CalledBy(Type = "System.Data.DataSet", Member = "GetXmlSchemaForRemoting", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Data.DataTable"}, ReturnType = typeof(string))]
		[CalledBy(Type = "System.Data.XmlTreeGen", Member = "SchemaTree", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlDocument), typeof(XmlWriter), "System.Data.DataSet", "System.Data.DataTable", typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 5)]
		[ContainsUnimplementedInstructions]
		 set { } //Length: 13
	}

	public bool Namespaces
	{
		[CalledBy(Type = typeof(XmlReader), Member = "ReadInnerXml", ReturnType = typeof(string))]
		[CalledBy(Type = typeof(XmlReader), Member = "CreateWriterForInnerOuterXml", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringWriter)}, ReturnType = typeof(XmlWriter))]
		[CalledBy(Type = typeof(XmlReader), Member = "SetNamespacesFlag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlTextWriter)}, ReturnType = typeof(void))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 4)]
		 set { } //Length: 123
	}

	public char QuoteChar
	{
		[CalledBy(Type = typeof(XmlReader), Member = "ReadInnerXml", ReturnType = typeof(string))]
		[CalledBy(Type = typeof(XmlReader), Member = "WriteNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlWriter), typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 5)]
		 set { } //Length: 149
	}

	public virtual WriteState WriteState
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 68
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(RuntimeFieldHandle)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 30)]
	private static XmlTextWriter() { }

	[CallerCount(Count = 24)]
	[Calls(Type = typeof(XmlTextWriter), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextEncoder), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextWriter)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public XmlTextWriter(TextWriter w) { }

	[CalledBy(Type = typeof(XmlTextWriter), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(Encoding)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextWriter), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Encoding)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextWriter), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextWriter)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(XmlCharType), Member = "get_Instance", ReturnType = typeof(XmlCharType))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 9)]
	internal XmlTextWriter() { }

	[CalledBy(Type = "System.Data.DataSet", Member = "System.Xml.Serialization.IXmlSerializable.GetSchema", ReturnType = typeof(XmlSchema))]
	[CalledBy(Type = "System.Data.DataTable", Member = "GetSchema", ReturnType = typeof(XmlSchema))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(XmlTextWriter), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(StreamWriter), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StreamWriter), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(Encoding)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextEncoder), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextWriter)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	public XmlTextWriter(Stream w, Encoding encoding) { }

	[CalledBy(Type = "System.Data.XmlTreeGen", Member = "SchemaTree", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlDocument), typeof(XmlWriter), "System.Data.DataSet", "System.Data.DataTable", typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(FileStream), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(FileMode), typeof(FileAccess), typeof(FileShare)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextWriter), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(StreamWriter), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StreamWriter), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(Encoding)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextEncoder), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextWriter)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	public XmlTextWriter(string filename, Encoding encoding) { }

	[CalledBy(Type = typeof(XmlTextWriter), Member = "PushNamespace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(Array), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SecureStringHasher), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEqualityComparer`1<TKey>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextWriter), Member = "AddToNamespaceHashtable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 6)]
	private void AddNamespace(string prefix, string ns, bool declared) { }

	[CalledBy(Type = typeof(XmlTextWriter), Member = "AddNamespace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Dictionary`2), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue&"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Int32>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	private void AddToNamespaceHashtable(int namespaceIndex) { }

	[CalledBy(Type = typeof(XmlTextWriter), Member = "WriteChars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextWriter), Member = "InternalWriteEndElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextWriter), Member = "WriteBinHex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextWriter), Member = "WriteBase64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextWriter), Member = "WriteRaw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextWriter), Member = "WriteRaw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextWriter), Member = "WriteString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextWriter), Member = "WriteWhitespace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextWriter), Member = "WriteCharEntity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextWriter), Member = "WriteSurrogateCharEntity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(char)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextWriter), Member = "WriteProcessingInstruction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextWriter), Member = "WriteComment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextWriter), Member = "WriteCData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextWriter), Member = "WriteEndAttribute", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextWriter), Member = "WriteStartAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextWriter), Member = "WriteStartElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextWriter), Member = "WriteDocType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextWriter), Member = "WriteEntityRef", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 18)]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextWriter), Member = "Indent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextWriter), Member = "WriteEndAttributeQuote", ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextWriter), Member = "WriteEndStartTag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Base64Encoder), Member = "Flush", ReturnType = typeof(void))]
	[Calls(Type = typeof(Res), Member = "GetString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 49)]
	[ContainsUnimplementedInstructions]
	private void AutoComplete(Token token) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Base64Encoder), Member = "Flush", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	private void AutoCompleteAll() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Base64Encoder), Member = "Flush", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	public virtual void Close() { }

	[CalledBy(Type = typeof(XmlTextWriter), Member = "WriteStartElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextWriter), Member = "WriteStartAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextWriter), Member = "LookupPrefix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(XmlTextWriter), Member = "LookupNamespace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private string FindPrefix(string ns) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public virtual void Flush() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Base64Encoder), Member = "Flush", ReturnType = typeof(void))]
	private void FlushEncoders() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(int), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 2)]
	private string GeneratePrefix() { }

	[CalledBy(Type = "System.Data.XmlTreeGen", Member = "SetPath", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlWriter)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Data.DataTextWriter", Member = "get_BaseStream", ReturnType = typeof(Stream))]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	public Stream get_BaseStream() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public virtual WriteState get_WriteState() { }

	[CalledBy(Type = typeof(XmlTextWriter), Member = "WriteEndAttributeQuote", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(XmlTextEncoder), Member = "get_AttributeValue", ReturnType = typeof(string))]
	[Calls(Type = typeof(XmlTextWriter), Member = "VerifyPrefixXml", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextWriter), Member = "PushNamespace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlConvert), Member = "TrimString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Res), Member = "GetString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 11)]
	private void HandleSpecialAttribute() { }

	[CalledBy(Type = typeof(XmlTextWriter), Member = "AutoComplete", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Token)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextWriter), Member = "InternalWriteEndElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	private void Indent(bool beforeEndElement) { }

	[CalledBy(Type = typeof(XmlTextWriter), Member = "WriteEndElement", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextWriter), Member = "WriteFullEndElement", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(XmlTextWriter), Member = "AutoComplete", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Token)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextWriter), Member = "Indent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Int32>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Dictionary`2), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 30)]
	private void InternalWriteEndElement(bool longFormat) { }

	[CalledBy(Type = typeof(XmlTextWriter), Member = "WriteProcessingInstruction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextWriter), Member = "StartDocument", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(XmlTextWriter), Member = "ValidateName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextEncoder), Member = "WriteRawWithSurrogateChecking", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	private void InternalWriteProcessingInstruction(string name, string text) { }

	[CalledBy(Type = typeof(XmlTextWriter), Member = "WriteStartElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextWriter), Member = "WriteStartAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextWriter), Member = "PushNamespace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextWriter), Member = "FindPrefix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Dictionary`2), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue&"}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private int LookupNamespace(string prefix) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Dictionary`2), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue&"}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private int LookupNamespaceInCurrentScope(string prefix) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlTextWriter), Member = "FindPrefix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 6)]
	public virtual string LookupPrefix(string ns) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Int32>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Dictionary`2), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 2)]
	private void PopNamespaces(int indexFrom, int indexTo) { }

	[CalledBy(Type = typeof(XmlTextWriter), Member = "WriteStartElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextWriter), Member = "WriteStartAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextWriter), Member = "HandleSpecialAttribute", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(XmlTextWriter), Member = "LookupNamespace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(XmlTextWriter), Member = "AddNamespace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 11)]
	private void PushNamespace(string prefix, string ns, bool declared) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(Array), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 6)]
	private void PushStack() { }

	[CalledBy(Type = typeof(XmlSerializer), Member = "Serialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextWriter), typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Data.DataSet", Member = "SerializeDataSet", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(StreamingContext), "System.Data.SerializationFormat"}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Data.DataSet", Member = "GetRemotingDiffGram", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Data.DataTable"}, ReturnType = typeof(string))]
	[CalledBy(Type = "System.Data.DataSet", Member = "GetXmlSchemaForRemoting", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Data.DataTable"}, ReturnType = typeof(string))]
	[CalledBy(Type = "System.Data.XmlTreeGen", Member = "SchemaTree", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlDocument), typeof(XmlWriter), "System.Data.DataSet", "System.Data.DataTable", typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[ContainsUnimplementedInstructions]
	public void set_Formatting(Formatting value) { }

	[CalledBy(Type = typeof(XmlReader), Member = "ReadInnerXml", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(XmlReader), Member = "CreateWriterForInnerOuterXml", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringWriter)}, ReturnType = typeof(XmlWriter))]
	[CalledBy(Type = typeof(XmlReader), Member = "SetNamespacesFlag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlTextWriter)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public void set_Namespaces(bool value) { }

	[CalledBy(Type = typeof(XmlReader), Member = "ReadInnerXml", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(XmlReader), Member = "WriteNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlWriter), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	public void set_QuoteChar(char value) { }

	[CalledBy(Type = typeof(XmlTextWriter), Member = "WriteStartDocument", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextWriter), Member = "WriteStartDocument", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(XmlTextWriter), Member = "InternalWriteProcessingInstruction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 9)]
	private void StartDocument(int standalone) { }

	[CalledBy(Type = typeof(XmlTextWriter), Member = "WriteDocType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextWriter), Member = "WriteEntityRef", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextWriter), Member = "InternalWriteProcessingInstruction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(ValidateNames), Member = "IsNameNoNamespaces", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ValidateNames), Member = "ParseNCName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(ValidateNames), Member = "ParseNmtoken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Res), Member = "GetString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 12)]
	private void ValidateName(string name, bool isNCName) { }

	[CalledBy(Type = typeof(XmlTextWriter), Member = "WriteStartElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextWriter), Member = "WriteStartAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextWriter), Member = "HandleSpecialAttribute", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	private void VerifyPrefixXml(string prefix, string ns) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlTextWriter), Member = "AutoComplete", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Token)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Base64Encoder), Member = "Encode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public virtual void WriteBase64(Byte[] buffer, int index, int count) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlTextWriter), Member = "AutoComplete", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Token)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BinHexEncoder), Member = "Encode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int), typeof(XmlWriter)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	public virtual void WriteBinHex(Byte[] buffer, int index, int count) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlTextWriter), Member = "AutoComplete", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Token)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(StringComparison)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(XmlTextEncoder), Member = "WriteRawWithSurrogateChecking", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 9)]
	public virtual void WriteCData(string text) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlTextWriter), Member = "AutoComplete", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Token)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextEncoder), Member = "WriteCharEntity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public virtual void WriteCharEntity(char ch) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlTextWriter), Member = "AutoComplete", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Token)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextEncoder), Member = "Write", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public virtual void WriteChars(Char[] buffer, int index, int count) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(StringComparison)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(XmlTextWriter), Member = "AutoComplete", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Token)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextEncoder), Member = "WriteRawWithSurrogateChecking", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 9)]
	public virtual void WriteComment(string text) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlTextWriter), Member = "ValidateName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextWriter), Member = "AutoComplete", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Token)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 18)]
	[CallsUnknownMethods(Count = 16)]
	public virtual void WriteDocType(string name, string pubid, string sysid, string subset) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlTextWriter), Member = "AutoComplete", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Token)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	public virtual void WriteEndAttribute() { }

	[CalledBy(Type = typeof(XmlTextWriter), Member = "AutoComplete", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Token)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(XmlTextWriter), Member = "HandleSpecialAttribute", ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextEncoder), Member = "EndAttribute", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void WriteEndAttributeQuote() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Base64Encoder), Member = "Flush", ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 11)]
	public virtual void WriteEndDocument() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlTextWriter), Member = "InternalWriteEndElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	public virtual void WriteEndElement() { }

	[CalledBy(Type = typeof(XmlTextWriter), Member = "AutoComplete", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Token)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(XmlTextEncoder), Member = "StartAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextEncoder), Member = "Write", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlTextEncoder), Member = "EndAttribute", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 12)]
	[CallsUnknownMethods(Count = 2)]
	private void WriteEndStartTag(bool empty) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlTextWriter), Member = "ValidateName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextWriter), Member = "AutoComplete", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Token)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextEncoder), Member = "WriteEntityRef", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public virtual void WriteEntityRef(string name) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlTextWriter), Member = "InternalWriteEndElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	public virtual void WriteFullEndElement() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(StringComparison)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(string), Member = "Compare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(StringComparison)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(XmlTextWriter), Member = "AutoComplete", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Token)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextWriter), Member = "InternalWriteProcessingInstruction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 10)]
	public virtual void WriteProcessingInstruction(string name, string text) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlTextWriter), Member = "AutoComplete", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Token)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextEncoder), Member = "WriteRawWithSurrogateChecking", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public virtual void WriteRaw(string data) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlTextWriter), Member = "AutoComplete", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Token)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextEncoder), Member = "WriteRaw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public virtual void WriteRaw(Char[] buffer, int index, int count) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlTextWriter), Member = "AutoComplete", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Token)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlTextEncoder), Member = "StartAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextWriter), Member = "VerifyPrefixXml", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Dictionary`2), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue&"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlTextWriter), Member = "FindPrefix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(int), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(XmlTextWriter), Member = "PushNamespace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextWriter), Member = "LookupNamespace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 19)]
	[CallsUnknownMethods(Count = 37)]
	[ContainsUnimplementedInstructions]
	public virtual void WriteStartAttribute(string prefix, string localName, string ns) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlTextWriter), Member = "StartDocument", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public virtual void WriteStartDocument(bool standalone) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlTextWriter), Member = "StartDocument", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	public virtual void WriteStartDocument() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlTextWriter), Member = "AutoComplete", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Token)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(Array), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextWriter), Member = "VerifyPrefixXml", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextWriter), Member = "PushNamespace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextWriter), Member = "FindPrefix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(XmlTextWriter), Member = "LookupNamespace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 45)]
	public virtual void WriteStartElement(string prefix, string localName, string ns) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlTextWriter), Member = "AutoComplete", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Token)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextEncoder), Member = "Write", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public virtual void WriteString(string text) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlTextWriter), Member = "AutoComplete", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Token)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextEncoder), Member = "WriteSurrogateCharEntity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(char)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public virtual void WriteSurrogateCharEntity(char lowChar, char highChar) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlCharType), Member = "IsOnlyWhitespace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlTextWriter), Member = "AutoComplete", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Token)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextEncoder), Member = "Write", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	public virtual void WriteWhitespace(string ws) { }

}

