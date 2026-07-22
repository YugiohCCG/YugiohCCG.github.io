namespace System.Xml;

internal sealed class XmlSqlBinaryReader : XmlReader, IXmlNamespaceResolver
{
	private struct AttrInfo
	{
		public QName name; //Field offset: 0x0
		public string val; //Field offset: 0x18
		public int contentPos; //Field offset: 0x20
		public int hashCode; //Field offset: 0x24
		public int prevHash; //Field offset: 0x28

		[CallerCount(Count = 0)]
		public void AdjustPosition(int adj) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		public void GetLocalnameAndNamespaceUri(out string localname, out string namespaceUri) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SecureStringHasher), Member = "GetHashCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
		[CallsUnknownMethods(Count = 3)]
		public int GetLocalnameAndNamespaceUriAndHash(SecureStringHasher hasher, out string localname, out string namespaceUri) { }

		[CalledBy(Type = typeof(XmlSqlBinaryReader), Member = "HashCheckForDuplicateAttributes", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 2)]
		public bool MatchHashNS(int hash, string localname, string namespaceUri) { }

		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 2)]
		[DeduplicatedMethod]
		public bool MatchNS(string localname, string namespaceUri) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		public void Set(QName n, string v) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		public void Set(QName n, int pos) { }

	}

	private struct ElemInfo
	{
		public QName name; //Field offset: 0x0
		public string xmlLang; //Field offset: 0x18
		public XmlSpace xmlSpace; //Field offset: 0x20
		public bool xmlspacePreserve; //Field offset: 0x24
		public NamespaceDecl nsdecls; //Field offset: 0x28

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		public NamespaceDecl Clear() { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		public void Set(QName name, bool xmlspacePreserve) { }

	}

	private class NamespaceDecl
	{
		public string prefix; //Field offset: 0x10
		public string uri; //Field offset: 0x18
		public NamespaceDecl scopeLink; //Field offset: 0x20
		public NamespaceDecl prevLink; //Field offset: 0x28
		public int scope; //Field offset: 0x30
		public bool implied; //Field offset: 0x34

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 4)]
		public NamespaceDecl(string prefix, string nsuri, NamespaceDecl nextInScope, NamespaceDecl prevDecl, int scope, bool implied) { }

	}

	private class NestedBinXml
	{
		public SymbolTables symbolTables; //Field offset: 0x10
		public int docState; //Field offset: 0x30
		public NestedBinXml next; //Field offset: 0x38

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		public NestedBinXml(SymbolTables symbolTables, int docState, NestedBinXml next) { }

	}

	public struct QName
	{
		public string prefix; //Field offset: 0x0
		public string localname; //Field offset: 0x8
		public string namespaceUri; //Field offset: 0x10

		[CallerCount(Count = 3)]
		[CallsUnknownMethods(Count = 3)]
		[DeduplicatedMethod]
		public QName(string prefix, string lname, string nsUri) { }

		[CalledBy(Type = typeof(XmlSqlBinaryReader), Member = "PushNamespace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(XmlException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[])}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 11)]
		public void CheckPrefixNS(string prefix, string namespaceUri) { }

		[CalledBy(Type = typeof(XmlSqlBinaryReader), Member = "ReadAttributeValue", ReturnType = typeof(bool))]
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 3)]
		public void Clear() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		public virtual bool Equals(object other) { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		public virtual int GetHashCode() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SecureStringHasher), Member = "GetHashCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
		[CallsUnknownMethods(Count = 1)]
		public int GetNSHashCode(SecureStringHasher hasher) { }

		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 2)]
		[DeduplicatedMethod]
		public bool MatchNs(string lname, string nsUri) { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		public bool MatchPrefix(string prefix, string lname) { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 3)]
		public static bool op_Equality(QName a, QName b) { }

		[CallerCount(Count = 3)]
		[CallsUnknownMethods(Count = 3)]
		[DeduplicatedMethod]
		public void Set(string prefix, string lname, string nsUri) { }

		[CalledBy(Type = typeof(XmlSqlBinaryReader), Member = "ScanAttributes", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XmlSqlBinaryReader), Member = "SimpleCheckForDuplicateAttributes", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XmlSqlBinaryReader), Member = "HashCheckForDuplicateAttributes", ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
		[CallsUnknownMethods(Count = 1)]
		public virtual string ToString() { }

	}

	private enum ScanState
	{
		Doc = 0,
		XmlText = 1,
		Attr = 2,
		AttrVal = 3,
		AttrValPseudoValue = 4,
		Init = 5,
		Error = 6,
		EOF = 7,
		Closed = 8,
	}

	private struct SymbolTables
	{
		public String[] symtable; //Field offset: 0x0
		public int symCount; //Field offset: 0x8
		public QName[] qnametable; //Field offset: 0x10
		public int qnameCount; //Field offset: 0x18

		[CalledBy(Type = typeof(XmlSqlBinaryReader), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(Byte[]), typeof(int), typeof(string), typeof(bool), typeof(XmlReaderSettings)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XmlSqlBinaryReader), Member = "ReadDoc", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(XmlSqlBinaryReader), Member = "ImplReadNest", ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[CallsUnknownMethods(Count = 5)]
		public void Init() { }

	}

	internal static readonly Type TypeOfObject; //Field offset: 0x0
	internal static readonly Type TypeOfString; //Field offset: 0x8
	private static Type[] TokenTypeMap; //Field offset: 0x10
	private static Byte[] XsdKatmaiTimeScaleToValueLengthMap; //Field offset: 0x18
	private static ReadState[] ScanState2ReadState; //Field offset: 0x20
	private Stream inStrm; //Field offset: 0x10
	private Byte[] data; //Field offset: 0x18
	private int pos; //Field offset: 0x20
	private int mark; //Field offset: 0x24
	private int end; //Field offset: 0x28
	private long offset; //Field offset: 0x30
	private bool eof; //Field offset: 0x38
	private bool sniffed; //Field offset: 0x39
	private bool isEmpty; //Field offset: 0x3A
	private int docState; //Field offset: 0x3C
	private SymbolTables symbolTables; //Field offset: 0x40
	private XmlNameTable xnt; //Field offset: 0x60
	private bool xntFromSettings; //Field offset: 0x68
	private string xml; //Field offset: 0x70
	private string xmlns; //Field offset: 0x78
	private string nsxmlns; //Field offset: 0x80
	private string baseUri; //Field offset: 0x88
	private ScanState state; //Field offset: 0x90
	private XmlNodeType nodetype; //Field offset: 0x94
	private BinXmlToken token; //Field offset: 0x98
	private int attrIndex; //Field offset: 0x9C
	private QName qnameOther; //Field offset: 0xA0
	private QName qnameElement; //Field offset: 0xB8
	private XmlNodeType parentNodeType; //Field offset: 0xD0
	private ElemInfo[] elementStack; //Field offset: 0xD8
	private int elemDepth; //Field offset: 0xE0
	private AttrInfo[] attributes; //Field offset: 0xE8
	private Int32[] attrHashTbl; //Field offset: 0xF0
	private int attrCount; //Field offset: 0xF8
	private int posAfterAttrs; //Field offset: 0xFC
	private bool xmlspacePreserve; //Field offset: 0x100
	private int tokLen; //Field offset: 0x104
	private int tokDataPos; //Field offset: 0x108
	private bool hasTypedValue; //Field offset: 0x10C
	private Type valueType; //Field offset: 0x110
	private string stringValue; //Field offset: 0x118
	private Dictionary<String, NamespaceDecl> namespaces; //Field offset: 0x120
	private NestedBinXml prevNameInfo; //Field offset: 0x128
	private XmlReader textXmlReader; //Field offset: 0x130
	private bool closeInput; //Field offset: 0x138
	private bool checkCharacters; //Field offset: 0x139
	private bool ignoreWhitespace; //Field offset: 0x13A
	private bool ignorePIs; //Field offset: 0x13B
	private bool ignoreComments; //Field offset: 0x13C
	private DtdProcessing dtdProcessing; //Field offset: 0x140
	private SecureStringHasher hasher; //Field offset: 0x148
	private XmlCharType xmlCharType; //Field offset: 0x150
	private Encoding unicode; //Field offset: 0x158
	private byte version; //Field offset: 0x160

	public virtual int AttributeCount
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 90
	}

	public virtual string BaseURI
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 8
	}

	public virtual int Depth
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 189
	}

	public virtual bool EOF
	{
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 11
	}

	public virtual bool IsEmptyElement
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 17
	}

	public virtual string LocalName
	{
		[CallerCount(Count = 4)]
		[DeduplicatedMethod]
		 get { } //Length: 8
	}

	public virtual string NamespaceURI
	{
		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		 get { } //Length: 8
	}

	public virtual XmlNameTable NameTable
	{
		[CallerCount(Count = 84)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public virtual XmlNodeType NodeType
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 7
	}

	public virtual string Prefix
	{
		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		 get { } //Length: 8
	}

	public virtual ReadState ReadState
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		 get { } //Length: 117
	}

	public virtual XmlReaderSettings Settings
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(XmlReaderSettings), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(XmlReaderSettings), Member = "set_NameTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNameTable)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(XmlReaderSettings), Member = "set_ConformanceLevel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ConformanceLevel)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(XmlReaderSettings), Member = "set_CheckCharacters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(XmlReaderSettings), Member = "set_IgnoreWhitespace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(XmlReaderSettings), Member = "set_IgnoreProcessingInstructions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(XmlReaderSettings), Member = "set_IgnoreComments", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(XmlReaderSettings), Member = "set_DtdProcessing", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DtdProcessing)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(XmlReaderSettings), Member = "set_CloseInput", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 265
	}

	public virtual string Value
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(XmlSqlBinaryReader), Member = "GetAttributeText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(XmlSqlBinaryReader), Member = "GetString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(XmlSqlBinaryReader), Member = "FillAllowEOF", ReturnType = typeof(bool))]
		[Calls(Type = typeof(StringBuilder), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(StringBuilder))]
		[Calls(Type = typeof(XmlSqlBinaryReader), Member = "ParseText", ReturnType = typeof(string))]
		[Calls(Type = typeof(XmlSqlBinaryReader), Member = "ValueAsString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinXmlToken)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(StringBuilder), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(StringBuilder))]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 6)]
		 get { } //Length: 948
	}

	public virtual Type ValueType
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 8
	}

	public virtual string XmlLang
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		 get { } //Length: 132
	}

	public virtual XmlSpace XmlSpace
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		 get { } //Length: 116
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(RuntimeFieldHandle)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 6)]
	private static XmlSqlBinaryReader() { }

	[CalledBy(Type = typeof(XmlReader), Member = "CreateSqlReader", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(XmlReaderSettings), typeof(XmlParserContext)}, ReturnType = typeof(XmlReader))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Encoding), Member = "get_Unicode", ReturnType = typeof(Encoding))]
	[Calls(Type = typeof(XmlCharType), Member = "get_Instance", ReturnType = typeof(XmlCharType))]
	[Calls(Type = typeof(NameTable), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(SymbolTables), Member = "Init", ReturnType = typeof(void))]
	[Calls(Type = typeof(SecureStringHasher), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEqualityComparer`1<TKey>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSqlBinaryReader), Member = "AddInitNamespace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSqlBinaryReader), Member = "GenerateTokenTypeMap", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 25)]
	[ContainsUnimplementedInstructions]
	public XmlSqlBinaryReader(Stream stream, Byte[] data, int len, string baseUri, bool closeInput, XmlReaderSettings settings) { }

	[CalledBy(Type = typeof(XmlSqlBinaryReader), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(Byte[]), typeof(int), typeof(string), typeof(bool), typeof(XmlReaderSettings)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	private void AddInitNamespace(string prefix, string uri) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlSqlBinaryReader), Member = "ParseText", ReturnType = typeof(string))]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	private void AddName() { }

	[CalledBy(Type = typeof(XmlSqlBinaryReader), Member = "NextToken2", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinXmlToken)}, ReturnType = typeof(BinXmlToken))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(XmlSqlBinaryReader), Member = "ReadNameRef", ReturnType = typeof(int))]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "StartsWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(StringComparison)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(XmlException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[])}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 12)]
	private void AddQName() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlSqlBinaryReader), Member = "GetString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(XmlSqlBinaryReader), Member = "FillAllowEOF", ReturnType = typeof(bool))]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(XmlSqlBinaryReader), Member = "ParseText", ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private string CDATAValue() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlSqlBinaryReader), Member = "ThrowXmlException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[CallsUnknownMethods(Count = 3)]
	private void CheckAllowContent() { }

	[CalledBy(Type = typeof(XmlSqlBinaryReader), Member = "ScanOverValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinXmlToken), typeof(bool), typeof(bool)}, ReturnType = typeof(XmlNodeType))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(XmlCharType), Member = "IsHighSurrogate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlCharType), Member = "IsLowSurrogate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlConvert), Member = "CreateInvalidSurrogatePairException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(char)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(XmlSqlBinaryReader), Member = "ThrowXmlException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(XmlConvert), Member = "CreateInvalidCharException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(char), typeof(ExceptionType)}, ReturnType = typeof(Exception))]
	[CallsUnknownMethods(Count = 13)]
	[ContainsUnimplementedInstructions]
	private XmlNodeType CheckText(bool attr) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	private XmlNodeType CheckTextIsWS() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlSqlBinaryReader), Member = "ThrowXmlException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[CallsUnknownMethods(Count = 3)]
	private void CheckValueTokenBounds() { }

	[CallerCount(Count = 0)]
	private void ClearAttributes() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public virtual void Close() { }

	[CalledBy(Type = typeof(XmlSqlBinaryReader), Member = "SkipExtn", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSqlBinaryReader), Member = "GetXsdKatmaiTokenLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinXmlToken)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(XmlSqlBinaryReader), Member = "ScanOverAnyValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinXmlToken), typeof(bool), typeof(bool)}, ReturnType = typeof(XmlNodeType))]
	[CalledBy(Type = typeof(XmlSqlBinaryReader), Member = "ScanOverValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinXmlToken), typeof(bool), typeof(bool)}, ReturnType = typeof(XmlNodeType))]
	[CalledBy(Type = typeof(XmlSqlBinaryReader), Member = "ImplReadElement", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSqlBinaryReader), Member = "ReadInit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XmlSqlBinaryReader), Member = "ScanText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(XmlSqlBinaryReader), Member = "NextToken2", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinXmlToken)}, ReturnType = typeof(BinXmlToken))]
	[CalledBy(Type = typeof(XmlSqlBinaryReader), Member = "RescanNextToken", ReturnType = typeof(BinXmlToken))]
	[CalledBy(Type = typeof(XmlSqlBinaryReader), Member = "ParseMB32_", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(XmlSqlBinaryReader), Member = "ParseMB32", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(XmlSqlBinaryReader), Member = "ReadUShort", ReturnType = typeof(ushort))]
	[CalledBy(Type = typeof(XmlSqlBinaryReader), Member = "ReadByte", ReturnType = typeof(byte))]
	[CalledBy(Type = typeof(XmlSqlBinaryReader), Member = "ReadNameRef", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(XmlSqlBinaryReader), Member = "ReadQNameRef", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(XmlSqlBinaryReader), Member = "ParseMB64", ReturnType = typeof(int))]
	[CallerCount(Count = 31)]
	[Calls(Type = typeof(XmlSqlBinaryReader), Member = "ThrowXmlException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(XmlSqlBinaryReader), Member = "FillAllowEOF", ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 3)]
	private void Fill(int require) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlSqlBinaryReader), Member = "FillAllowEOF", ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlSqlBinaryReader), Member = "ThrowXmlException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[CallsUnknownMethods(Count = 3)]
	private void Fill_(int require) { }

	[CalledBy(Type = typeof(XmlSqlBinaryReader), Member = "RescanNextToken", ReturnType = typeof(BinXmlToken))]
	[CalledBy(Type = typeof(XmlSqlBinaryReader), Member = "get_Value", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(XmlSqlBinaryReader), Member = "SkipExtn", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSqlBinaryReader), Member = "Fill_", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSqlBinaryReader), Member = "Fill", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSqlBinaryReader), Member = "PeekToken", ReturnType = typeof(BinXmlToken))]
	[CalledBy(Type = typeof(XmlSqlBinaryReader), Member = "ReadToken", ReturnType = typeof(BinXmlToken))]
	[CalledBy(Type = typeof(XmlSqlBinaryReader), Member = "NextToken2", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinXmlToken)}, ReturnType = typeof(BinXmlToken))]
	[CalledBy(Type = typeof(XmlSqlBinaryReader), Member = "CDATAValue", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(XmlSqlBinaryReader), Member = "FinishCDATA", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSqlBinaryReader), Member = "ReadDoc", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XmlSqlBinaryReader), Member = "ScanOverAnyValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinXmlToken), typeof(bool), typeof(bool)}, ReturnType = typeof(XmlNodeType))]
	[CalledBy(Type = typeof(XmlSqlBinaryReader), Member = "GetXsdKatmaiTokenLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinXmlToken)}, ReturnType = typeof(int))]
	[CallerCount(Count = 14)]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	[ContainsUnimplementedInstructions]
	private bool FillAllowEOF() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlSqlBinaryReader), Member = "FillAllowEOF", ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlSqlBinaryReader), Member = "ScanText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(XmlException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 6)]
	private void FinishCDATA() { }

	[CalledBy(Type = typeof(XmlSqlBinaryReader), Member = "ReadDoc", ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 5)]
	private void FinishEndElement() { }

	[CalledBy(Type = typeof(XmlSqlBinaryReader), Member = "ImplReadElement", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(XmlSqlBinaryReader), Member = "GrowAttributes", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 8)]
	private void GenerateImpliedXmlnsAttrs() { }

	[CalledBy(Type = typeof(XmlSqlBinaryReader), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(Byte[]), typeof(int), typeof(string), typeof(bool), typeof(XmlReaderSettings)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[CallsUnknownMethods(Count = 173)]
	private void GenerateTokenTypeMap() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public virtual int get_AttributeCount() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public virtual string get_BaseURI() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public virtual int get_Depth() { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public virtual bool get_EOF() { }

	[CallerCount(Count = 0)]
	public virtual bool get_IsEmptyElement() { }

	[CallerCount(Count = 4)]
	[DeduplicatedMethod]
	public virtual string get_LocalName() { }

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public virtual string get_NamespaceURI() { }

	[CallerCount(Count = 84)]
	[DeduplicatedMethod]
	public virtual XmlNameTable get_NameTable() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public virtual XmlNodeType get_NodeType() { }

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public virtual string get_Prefix() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public virtual ReadState get_ReadState() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlReaderSettings), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlReaderSettings), Member = "set_NameTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNameTable)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlReaderSettings), Member = "set_ConformanceLevel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ConformanceLevel)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlReaderSettings), Member = "set_CheckCharacters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlReaderSettings), Member = "set_IgnoreWhitespace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlReaderSettings), Member = "set_IgnoreProcessingInstructions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlReaderSettings), Member = "set_IgnoreComments", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlReaderSettings), Member = "set_DtdProcessing", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DtdProcessing)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlReaderSettings), Member = "set_CloseInput", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public virtual XmlReaderSettings get_Settings() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlSqlBinaryReader), Member = "GetAttributeText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(XmlSqlBinaryReader), Member = "GetString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(XmlSqlBinaryReader), Member = "FillAllowEOF", ReturnType = typeof(bool))]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(XmlSqlBinaryReader), Member = "ParseText", ReturnType = typeof(string))]
	[Calls(Type = typeof(XmlSqlBinaryReader), Member = "ValueAsString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinXmlToken)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(StringBuilder))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 6)]
	public virtual string get_Value() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public virtual Type get_ValueType() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public virtual string get_XmlLang() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public virtual XmlSpace get_XmlSpace() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlSqlBinaryReader), Member = "GetAttributeText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	public virtual string GetAttribute(int i) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 6)]
	public virtual string GetAttribute(string name, string ns) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlSqlBinaryReader), Member = "LocateAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public virtual string GetAttribute(string name) { }

	[CalledBy(Type = typeof(XmlSqlBinaryReader), Member = "get_Value", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(XmlSqlBinaryReader), Member = "GetAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(XmlSqlBinaryReader), Member = "ScanAttributes", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(XmlSqlBinaryReader), Member = "RescanNextToken", ReturnType = typeof(BinXmlToken))]
	[Calls(Type = typeof(XmlSqlBinaryReader), Member = "ScanOverValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinXmlToken), typeof(bool), typeof(bool)}, ReturnType = typeof(XmlNodeType))]
	[Calls(Type = typeof(XmlSqlBinaryReader), Member = "ValueAsString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinXmlToken)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 5)]
	private string GetAttributeText(int i) { }

	[CalledBy(Type = typeof(XmlSqlBinaryReader), Member = "ValueAsLong", ReturnType = typeof(long))]
	[CalledBy(Type = typeof(XmlSqlBinaryReader), Member = "ValueAsDecimal", ReturnType = typeof(Decimal))]
	[CalledBy(Type = typeof(XmlSqlBinaryReader), Member = "ValueAsDouble", ReturnType = typeof(double))]
	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	private double GetDouble(int offset) { }

	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	private short GetInt16(int pos) { }

	[CallerCount(Count = 4)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	private int GetInt32(int pos) { }

	[CallerCount(Count = 7)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	private long GetInt64(int pos) { }

	[CalledBy(Type = typeof(XmlSqlBinaryReader), Member = "ValueAsLong", ReturnType = typeof(long))]
	[CalledBy(Type = typeof(XmlSqlBinaryReader), Member = "ValueAsDecimal", ReturnType = typeof(Decimal))]
	[CalledBy(Type = typeof(XmlSqlBinaryReader), Member = "ValueAsDouble", ReturnType = typeof(double))]
	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	private float GetSingle(int offset) { }

	[CalledBy(Type = typeof(XmlSqlBinaryReader), Member = "get_Value", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(XmlSqlBinaryReader), Member = "ParseText", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(XmlSqlBinaryReader), Member = "CDATAValue", ReturnType = typeof(string))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(string), Member = "CreateString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(XmlException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[])}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 13)]
	private string GetString(int pos, int cch) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "CreateString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 1)]
	private string GetStringAligned(Byte[] data, int offset, int cch) { }

	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	private ushort GetUInt16(int pos) { }

	[CallerCount(Count = 4)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	private uint GetUInt32(int pos) { }

	[CallerCount(Count = 7)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	private ulong GetUInt64(int pos) { }

	[CalledBy(Type = typeof(XmlSqlBinaryReader), Member = "ReadAttributeValue", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XmlSqlBinaryReader), Member = "ReadDoc", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XmlSqlBinaryReader), Member = "ImplReadData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinXmlToken)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(XmlSqlBinaryReader), Member = "ThrowUnexpectedToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinXmlToken)}, ReturnType = typeof(Exception))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	private Type GetValueType(BinXmlToken token) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlSqlBinaryReader), Member = "FillAllowEOF", ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlSqlBinaryReader), Member = "XsdKatmaiTimeScaleToValueLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(XmlSqlBinaryReader), Member = "Fill", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSqlBinaryReader), Member = "ThrowUnexpectedToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinXmlToken)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(XmlSqlBinaryReader), Member = "ThrowXmlException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[CallsUnknownMethods(Count = 8)]
	private int GetXsdKatmaiTokenLength(BinXmlToken token) { }

	[CalledBy(Type = typeof(XmlSqlBinaryReader), Member = "GenerateImpliedXmlnsAttrs", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSqlBinaryReader), Member = "ScanAttributes", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	private void GrowAttributes() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	private void GrowElements() { }

	[CalledBy(Type = typeof(XmlSqlBinaryReader), Member = "ScanAttributes", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SecureStringHasher), Member = "GetHashCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(AttrInfo), Member = "MatchHashNS", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(QName), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(XmlException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 13)]
	private void HashCheckForDuplicateAttributes() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlSqlBinaryReader), Member = "ScanText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(XmlSqlBinaryReader), Member = "ThrowXmlException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[CallsUnknownMethods(Count = 3)]
	private void ImplReadCDATA() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlSqlBinaryReader), Member = "ScanText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&)}, ReturnType = typeof(int))]
	private void ImplReadComment() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlSqlBinaryReader), Member = "ScanOverValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinXmlToken), typeof(bool), typeof(bool)}, ReturnType = typeof(XmlNodeType))]
	[Calls(Type = typeof(XmlSqlBinaryReader), Member = "NextToken", ReturnType = typeof(BinXmlToken))]
	[Calls(Type = typeof(XmlSqlBinaryReader), Member = "GetValueType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinXmlToken)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(XmlSqlBinaryReader), Member = "ThrowNotSupported", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[CallsUnknownMethods(Count = 5)]
	private void ImplReadData(BinXmlToken tokenType) { }

	[CalledBy(Type = typeof(XmlSqlBinaryReader), Member = "ReadDoc", ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(XmlSqlBinaryReader), Member = "ParseText", ReturnType = typeof(string))]
	[Calls(Type = typeof(XmlSqlBinaryReader), Member = "PeekToken", ReturnType = typeof(BinXmlToken))]
	[Calls(Type = typeof(XmlSqlBinaryReader), Member = "ScanText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(XmlSqlBinaryReader), Member = "ThrowXmlException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 24)]
	private void ImplReadDoctype() { }

	[CalledBy(Type = typeof(XmlSqlBinaryReader), Member = "ReadDoc", ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSqlBinaryReader), Member = "ReadQNameRef", ReturnType = typeof(int))]
	[Calls(Type = typeof(XmlSqlBinaryReader), Member = "PushNamespace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSqlBinaryReader), Member = "NextToken", ReturnType = typeof(BinXmlToken))]
	[Calls(Type = typeof(XmlSqlBinaryReader), Member = "ScanAttributes", ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSqlBinaryReader), Member = "GenerateImpliedXmlnsAttrs", ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSqlBinaryReader), Member = "Fill", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSqlBinaryReader), Member = "ThrowUnexpectedToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinXmlToken)}, ReturnType = typeof(Exception))]
	[CallsUnknownMethods(Count = 10)]
	private void ImplReadElement() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlSqlBinaryReader), Member = "ThrowXmlException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[CallsUnknownMethods(Count = 6)]
	private void ImplReadEndElement() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 3)]
	private void ImplReadEndNest() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SymbolTables), Member = "Init", ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSqlBinaryReader), Member = "ThrowXmlException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	private void ImplReadNest() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlSqlBinaryReader), Member = "ReadNameRef", ReturnType = typeof(int))]
	[Calls(Type = typeof(XmlSqlBinaryReader), Member = "ScanText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&)}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 3)]
	private void ImplReadPI() { }

	[CalledBy(Type = typeof(XmlSqlBinaryReader), Member = "ReadDoc", ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(XmlSqlBinaryReader), Member = "ParseText", ReturnType = typeof(string))]
	[Calls(Type = typeof(XmlNamespaceManager), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNameTable)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlReaderSettings), Member = "set_NameTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNameTable)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlReaderSettings), Member = "set_DtdProcessing", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DtdProcessing)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlReaderSettings), Member = "set_ConformanceLevel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ConformanceLevel)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlParserContext), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNameTable), typeof(XmlNamespaceManager), typeof(string), typeof(XmlSpace)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(XmlParserContext), typeof(XmlReaderSettings)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSqlBinaryReader), Member = "UpdateFromTextReader", ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSqlBinaryReader), Member = "ReadDoc", ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlSqlBinaryReader), Member = "ThrowXmlException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[CallsDeduplicatedMethods(Count = 11)]
	[CallsUnknownMethods(Count = 8)]
	private void ImplReadXmlText() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	private int LocateAttribute(string name, string ns) { }

	[CalledBy(Type = typeof(XmlSqlBinaryReader), Member = "GetAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(XmlSqlBinaryReader), Member = "MoveToAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ValidateNames), Member = "SplitQName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String&), typeof(String&)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	private int LocateAttribute(string name) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object&)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public virtual string LookupNamespace(string prefix) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlSqlBinaryReader), Member = "LocateAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(XmlSqlBinaryReader), Member = "PositionOnAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSqlBinaryReader), Member = "UpdateFromTextReader", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public virtual bool MoveToAttribute(string name) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlSqlBinaryReader), Member = "PositionOnAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSqlBinaryReader), Member = "UpdateFromTextReader", ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	public virtual void MoveToAttribute(int i) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlSqlBinaryReader), Member = "UpdateFromTextReader", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public virtual bool MoveToElement() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlSqlBinaryReader), Member = "PositionOnAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSqlBinaryReader), Member = "UpdateFromTextReader", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public virtual bool MoveToFirstAttribute() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlSqlBinaryReader), Member = "UpdateFromTextReader", ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSqlBinaryReader), Member = "PositionOnAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public virtual bool MoveToNextAttribute() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private void NameFlush() { }

	[CalledBy(Type = typeof(XmlSqlBinaryReader), Member = "PeekNextToken", ReturnType = typeof(BinXmlToken))]
	[CalledBy(Type = typeof(XmlSqlBinaryReader), Member = "ScanAttributes", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSqlBinaryReader), Member = "ReadDoc", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XmlSqlBinaryReader), Member = "ImplReadData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinXmlToken)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSqlBinaryReader), Member = "ImplReadElement", ReturnType = typeof(void))]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(XmlSqlBinaryReader), Member = "ReadToken", ReturnType = typeof(BinXmlToken))]
	[Calls(Type = typeof(XmlSqlBinaryReader), Member = "NextToken2", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinXmlToken)}, ReturnType = typeof(BinXmlToken))]
	[CallsUnknownMethods(Count = 2)]
	private BinXmlToken NextToken() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlSqlBinaryReader), Member = "ReadToken", ReturnType = typeof(BinXmlToken))]
	[CallsUnknownMethods(Count = 2)]
	[ContainsInvalidInstructions]
	private BinXmlToken NextToken1() { }

	[CalledBy(Type = typeof(XmlSqlBinaryReader), Member = "NextToken", ReturnType = typeof(BinXmlToken))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(XmlSqlBinaryReader), Member = "AddQName", ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSqlBinaryReader), Member = "ParseText", ReturnType = typeof(string))]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSqlBinaryReader), Member = "Fill", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSqlBinaryReader), Member = "ParseMB32_", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(XmlSqlBinaryReader), Member = "FillAllowEOF", ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlSqlBinaryReader), Member = "ThrowXmlException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 11)]
	private BinXmlToken NextToken2(BinXmlToken token) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlSqlBinaryReader), Member = "ThrowXmlException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[CallsUnknownMethods(Count = 5)]
	private int ParseMB32(int pos) { }

	[CallerCount(Count = 4)]
	[Calls(Type = typeof(XmlSqlBinaryReader), Member = "Fill", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSqlBinaryReader), Member = "ParseMB32_", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte)}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	private int ParseMB32() { }

	[CalledBy(Type = typeof(XmlSqlBinaryReader), Member = "SkipExtn", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSqlBinaryReader), Member = "ReadQNameRef", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(XmlSqlBinaryReader), Member = "ReadNameRef", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(XmlSqlBinaryReader), Member = "ParseMB32", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(XmlSqlBinaryReader), Member = "ParseMB64", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(XmlSqlBinaryReader), Member = "NextToken2", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinXmlToken)}, ReturnType = typeof(BinXmlToken))]
	[CalledBy(Type = typeof(XmlSqlBinaryReader), Member = "RescanNextToken", ReturnType = typeof(BinXmlToken))]
	[CalledBy(Type = typeof(XmlSqlBinaryReader), Member = "ScanText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(XmlSqlBinaryReader), Member = "ScanOverValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinXmlToken), typeof(bool), typeof(bool)}, ReturnType = typeof(XmlNodeType))]
	[CallerCount(Count = 13)]
	[Calls(Type = typeof(XmlSqlBinaryReader), Member = "Fill", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSqlBinaryReader), Member = "ThrowXmlException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[CallsUnknownMethods(Count = 5)]
	private int ParseMB32_(byte b) { }

	[CallerCount(Count = 4)]
	[Calls(Type = typeof(XmlSqlBinaryReader), Member = "Fill", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSqlBinaryReader), Member = "ParseMB32_", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte)}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	private int ParseMB64() { }

	[CalledBy(Type = typeof(XmlSqlBinaryReader), Member = "get_Value", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(XmlSqlBinaryReader), Member = "AddName", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSqlBinaryReader), Member = "NextToken2", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinXmlToken)}, ReturnType = typeof(BinXmlToken))]
	[CalledBy(Type = typeof(XmlSqlBinaryReader), Member = "ReadInit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XmlSqlBinaryReader), Member = "CDATAValue", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(XmlSqlBinaryReader), Member = "ImplReadDoctype", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSqlBinaryReader), Member = "ImplReadXmlText", ReturnType = typeof(void))]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(XmlSqlBinaryReader), Member = "ScanText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(XmlSqlBinaryReader), Member = "GetString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 1)]
	private string ParseText() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlSqlBinaryReader), Member = "NextToken", ReturnType = typeof(BinXmlToken))]
	private BinXmlToken PeekNextToken() { }

	[CalledBy(Type = typeof(XmlSqlBinaryReader), Member = "ReadInit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XmlSqlBinaryReader), Member = "ImplReadDoctype", ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(XmlSqlBinaryReader), Member = "FillAllowEOF", ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 2)]
	private BinXmlToken PeekToken() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 3)]
	private void PopNamespaces(NamespaceDecl firstInScopeChain) { }

	[CalledBy(Type = typeof(XmlSqlBinaryReader), Member = "MoveToAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XmlSqlBinaryReader), Member = "MoveToAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSqlBinaryReader), Member = "MoveToFirstAttribute", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XmlSqlBinaryReader), Member = "MoveToNextAttribute", ReturnType = typeof(bool))]
	[CallerCount(Count = 4)]
	[CallsUnknownMethods(Count = 5)]
	private void PositionOnAttribute(int i) { }

	[CalledBy(Type = typeof(XmlSqlBinaryReader), Member = "ScanAttributes", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSqlBinaryReader), Member = "ImplReadElement", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(QName), Member = "CheckPrefixNS", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 7)]
	private void PushNamespace(string prefix, string ns, bool implied) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlSqlBinaryReader), Member = "UpdateFromTextReader", ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSqlBinaryReader), Member = "ReadDoc", ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlSqlBinaryReader), Member = "ReadInit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Exception)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 10)]
	public virtual bool Read() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlSqlBinaryReader), Member = "RescanNextToken", ReturnType = typeof(BinXmlToken))]
	[Calls(Type = typeof(XmlSqlBinaryReader), Member = "ScanOverValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinXmlToken), typeof(bool), typeof(bool)}, ReturnType = typeof(XmlNodeType))]
	[Calls(Type = typeof(XmlSqlBinaryReader), Member = "GetValueType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinXmlToken)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(QName), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSqlBinaryReader), Member = "UpdateFromTextReader", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public virtual bool ReadAttributeValue() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlSqlBinaryReader), Member = "Fill", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	private byte ReadByte() { }

	[CalledBy(Type = typeof(XmlSqlBinaryReader), Member = "Read", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XmlSqlBinaryReader), Member = "ReadInit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XmlSqlBinaryReader), Member = "ReadDoc", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XmlSqlBinaryReader), Member = "ImplReadXmlText", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(XmlSqlBinaryReader), Member = "ThrowUnexpectedToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinXmlToken)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(XmlSqlBinaryReader), Member = "ThrowNotSupported", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(XmlException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSqlBinaryReader), Member = "ThrowXmlException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(XmlException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSqlBinaryReader), Member = "ImplReadElement", ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSqlBinaryReader), Member = "ImplReadXmlText", ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSqlBinaryReader), Member = "ReadInit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(SymbolTables), Member = "Init", ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSqlBinaryReader), Member = "GetValueType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinXmlToken)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(XmlSqlBinaryReader), Member = "ScanOverValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinXmlToken), typeof(bool), typeof(bool)}, ReturnType = typeof(XmlNodeType))]
	[Calls(Type = typeof(XmlSqlBinaryReader), Member = "ImplReadDoctype", ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSqlBinaryReader), Member = "ReadNameRef", ReturnType = typeof(int))]
	[Calls(Type = typeof(XmlSqlBinaryReader), Member = "NextToken", ReturnType = typeof(BinXmlToken))]
	[Calls(Type = typeof(XmlSqlBinaryReader), Member = "ScanText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(XmlSqlBinaryReader), Member = "FillAllowEOF", ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlSqlBinaryReader), Member = "FinishEndElement", ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSqlBinaryReader), Member = "ReadDoc", ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 43)]
	private bool ReadDoc() { }

	[CalledBy(Type = typeof(XmlSqlBinaryReader), Member = "Read", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XmlSqlBinaryReader), Member = "ReadDoc", ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(XmlSqlBinaryReader), Member = "Fill", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSqlBinaryReader), Member = "PeekToken", ReturnType = typeof(BinXmlToken))]
	[Calls(Type = typeof(XmlSqlBinaryReader), Member = "ParseText", ReturnType = typeof(string))]
	[Calls(Type = typeof(XmlSqlBinaryReader), Member = "ReadDoc", ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[])}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 32)]
	private bool ReadInit(bool skipXmlDecl) { }

	[CalledBy(Type = typeof(XmlSqlBinaryReader), Member = "AddQName", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSqlBinaryReader), Member = "ReadDoc", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XmlSqlBinaryReader), Member = "ImplReadPI", ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(XmlSqlBinaryReader), Member = "Fill", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSqlBinaryReader), Member = "ParseMB32_", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(XmlException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 6)]
	private int ReadNameRef() { }

	[CalledBy(Type = typeof(XmlSqlBinaryReader), Member = "ScanAttributes", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSqlBinaryReader), Member = "ImplReadElement", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(XmlSqlBinaryReader), Member = "Fill", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSqlBinaryReader), Member = "ParseMB32_", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(XmlException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 6)]
	private int ReadQNameRef() { }

	[CalledBy(Type = typeof(XmlSqlBinaryReader), Member = "NextToken1", ReturnType = typeof(BinXmlToken))]
	[CalledBy(Type = typeof(XmlSqlBinaryReader), Member = "NextToken", ReturnType = typeof(BinXmlToken))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(XmlSqlBinaryReader), Member = "FillAllowEOF", ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 2)]
	private BinXmlToken ReadToken() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlSqlBinaryReader), Member = "Fill", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	private ushort ReadUShort() { }

	[CalledBy(Type = typeof(XmlSqlBinaryReader), Member = "ReadAttributeValue", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XmlSqlBinaryReader), Member = "GetAttributeText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(XmlSqlBinaryReader), Member = "FillAllowEOF", ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlSqlBinaryReader), Member = "Fill", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSqlBinaryReader), Member = "ParseMB32_", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte)}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 8)]
	private BinXmlToken RescanNextToken() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlSqlBinaryReader), Member = "ScanOverValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinXmlToken), typeof(bool), typeof(bool)}, ReturnType = typeof(XmlNodeType))]
	private void ReScanOverValue(BinXmlToken token) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public virtual void ResolveEntity() { }

	[CalledBy(Type = typeof(XmlSqlBinaryReader), Member = "ImplReadElement", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(XmlSqlBinaryReader), Member = "ReadQNameRef", ReturnType = typeof(int))]
	[Calls(Type = typeof(XmlSqlBinaryReader), Member = "NextToken", ReturnType = typeof(BinXmlToken))]
	[Calls(Type = typeof(XmlSqlBinaryReader), Member = "ScanOverValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinXmlToken), typeof(bool), typeof(bool)}, ReturnType = typeof(XmlNodeType))]
	[Calls(Type = typeof(XmlSqlBinaryReader), Member = "ValueAsString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinXmlToken)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(XmlSqlBinaryReader), Member = "PushNamespace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSqlBinaryReader), Member = "GrowAttributes", ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSqlBinaryReader), Member = "GetAttributeText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(XmlSqlBinaryReader), Member = "HashCheckForDuplicateAttributes", ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSqlBinaryReader), Member = "ThrowNotSupported", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(XmlSqlBinaryReader), Member = "ThrowXmlException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(XmlException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(QName), Member = "ToString", ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallsUnknownMethods(Count = 27)]
	[ContainsUnimplementedInstructions]
	private void ScanAttributes() { }

	[CalledBy(Type = typeof(XmlSqlBinaryReader), Member = "ScanOverValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinXmlToken), typeof(bool), typeof(bool)}, ReturnType = typeof(XmlNodeType))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(XmlSqlBinaryReader), Member = "Fill", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSqlBinaryReader), Member = "ValueAsString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinXmlToken)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(XmlConvert), Member = "VerifyCharData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(ExceptionType), typeof(ExceptionType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSqlBinaryReader), Member = "FillAllowEOF", ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlSqlBinaryReader), Member = "XsdKatmaiTimeScaleToValueLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(XmlSqlBinaryReader), Member = "ThrowUnexpectedToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinXmlToken)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(XmlSqlBinaryReader), Member = "ThrowXmlException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 33)]
	[ContainsInvalidInstructions]
	private XmlNodeType ScanOverAnyValue(BinXmlToken token, bool attr, bool checkChars) { }

	[CalledBy(Type = typeof(XmlSqlBinaryReader), Member = "ReadAttributeValue", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XmlSqlBinaryReader), Member = "GetAttributeText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(XmlSqlBinaryReader), Member = "ScanAttributes", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSqlBinaryReader), Member = "ReadDoc", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XmlSqlBinaryReader), Member = "ImplReadData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinXmlToken)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSqlBinaryReader), Member = "ReScanOverValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinXmlToken)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(XmlSqlBinaryReader), Member = "ScanOverAnyValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinXmlToken), typeof(bool), typeof(bool)}, ReturnType = typeof(XmlNodeType))]
	[Calls(Type = typeof(XmlSqlBinaryReader), Member = "Fill", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSqlBinaryReader), Member = "ParseMB32_", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(XmlSqlBinaryReader), Member = "CheckText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(XmlNodeType))]
	[CallsUnknownMethods(Count = 6)]
	[ContainsUnimplementedInstructions]
	private XmlNodeType ScanOverValue(BinXmlToken token, bool attr, bool checkChars) { }

	[CalledBy(Type = typeof(XmlSqlBinaryReader), Member = "ParseText", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(XmlSqlBinaryReader), Member = "FinishCDATA", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSqlBinaryReader), Member = "ReadDoc", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XmlSqlBinaryReader), Member = "ImplReadDoctype", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSqlBinaryReader), Member = "ImplReadPI", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSqlBinaryReader), Member = "ImplReadComment", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSqlBinaryReader), Member = "ImplReadCDATA", ReturnType = typeof(void))]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(XmlSqlBinaryReader), Member = "Fill", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSqlBinaryReader), Member = "ParseMB32_", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte)}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 6)]
	private int ScanText(out int start) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(QName), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(XmlException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 10)]
	private void SimpleCheckForDuplicateAttributes() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlSqlBinaryReader), Member = "Fill", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSqlBinaryReader), Member = "ParseMB32_", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(XmlSqlBinaryReader), Member = "FillAllowEOF", ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlSqlBinaryReader), Member = "ThrowXmlException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[CallsUnknownMethods(Count = 7)]
	private void SkipExtn() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 12)]
	private override IDictionary<String, String> System.Xml.IXmlNamespaceResolver.GetNamespacesInScope(XmlNamespaceScope scope) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 7)]
	private override string System.Xml.IXmlNamespaceResolver.LookupPrefix(string namespaceName) { }

	[CalledBy(Type = typeof(XmlSqlBinaryReader), Member = "ScanAttributes", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSqlBinaryReader), Member = "ReadDoc", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XmlSqlBinaryReader), Member = "ImplReadData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinXmlToken)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	private Exception ThrowNotSupported(string res) { }

	[CalledBy(Type = typeof(XmlSqlBinaryReader), Member = "VerifyVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(BinXmlToken)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSqlBinaryReader), Member = "ReadDoc", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XmlSqlBinaryReader), Member = "ImplReadElement", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSqlBinaryReader), Member = "GetValueType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinXmlToken)}, ReturnType = typeof(Type))]
	[CalledBy(Type = typeof(XmlSqlBinaryReader), Member = "ScanOverAnyValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinXmlToken), typeof(bool), typeof(bool)}, ReturnType = typeof(XmlNodeType))]
	[CalledBy(Type = typeof(XmlSqlBinaryReader), Member = "GetXsdKatmaiTokenLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinXmlToken)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(XmlSqlBinaryReader), Member = "ValueAsLong", ReturnType = typeof(long))]
	[CalledBy(Type = typeof(XmlSqlBinaryReader), Member = "ValueAsULong", ReturnType = typeof(ulong))]
	[CalledBy(Type = typeof(XmlSqlBinaryReader), Member = "ValueAsDecimal", ReturnType = typeof(Decimal))]
	[CalledBy(Type = typeof(XmlSqlBinaryReader), Member = "ValueAsDouble", ReturnType = typeof(double))]
	[CalledBy(Type = typeof(XmlSqlBinaryReader), Member = "ValueAsDateTimeString", ReturnType = typeof(string))]
	[CallerCount(Count = 14)]
	[Calls(Type = typeof(XmlException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[])}, ReturnType = typeof(void))]
	private Exception ThrowUnexpectedToken(BinXmlToken token) { }

	[CallerCount(Count = 28)]
	[Calls(Type = typeof(XmlException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[])}, ReturnType = typeof(void))]
	private Exception ThrowXmlException(string res) { }

	[CalledBy(Type = typeof(XmlSqlBinaryReader), Member = "ScanAttributes", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(XmlException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[])}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	private Exception ThrowXmlException(string res, string arg1, string arg2) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlSqlBinaryReader), Member = "UpdateFromTextReader", ReturnType = typeof(void))]
	private bool UpdateFromTextReader(bool needUpdate) { }

	[CalledBy(Type = typeof(XmlSqlBinaryReader), Member = "MoveToAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XmlSqlBinaryReader), Member = "MoveToAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSqlBinaryReader), Member = "MoveToFirstAttribute", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XmlSqlBinaryReader), Member = "MoveToNextAttribute", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XmlSqlBinaryReader), Member = "MoveToElement", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XmlSqlBinaryReader), Member = "ReadAttributeValue", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XmlSqlBinaryReader), Member = "Read", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XmlSqlBinaryReader), Member = "ImplReadXmlText", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSqlBinaryReader), Member = "UpdateFromTextReader", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 9)]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 5)]
	private void UpdateFromTextReader() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlSqlBinaryReader), Member = "ThrowUnexpectedToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinXmlToken)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(XmlSqlBinaryReader), Member = "ThrowXmlException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(BinXmlDateTime), Member = "XsdDateToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(BinXmlDateTime), Member = "XsdDateTimeToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(BinXmlDateTime), Member = "XsdTimeToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(DateTime), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DateTime), Member = "get_Day", ReturnType = typeof(int))]
	[Calls(Type = typeof(DateTime), Member = "get_Month", ReturnType = typeof(int))]
	[Calls(Type = typeof(DateTime), Member = "get_Year", ReturnType = typeof(int))]
	[Calls(Type = typeof(BinXmlDateTime), Member = "GetFractions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(DateTime), Member = "get_Second", ReturnType = typeof(int))]
	[Calls(Type = typeof(DateTime), Member = "get_Minute", ReturnType = typeof(int))]
	[Calls(Type = typeof(DateTime), Member = "get_Hour", ReturnType = typeof(int))]
	[Calls(Type = typeof(BinXmlDateTime), Member = "XsdKatmaiDateTimeToDateTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int)}, ReturnType = typeof(DateTime))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(BinXmlDateTime), Member = "WriteDate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DateTimeOffset), Member = "get_Minute", ReturnType = typeof(int))]
	[Calls(Type = typeof(DateTimeOffset), Member = "get_Month", ReturnType = typeof(int))]
	[Calls(Type = typeof(DateTimeOffset), Member = "get_Year", ReturnType = typeof(int))]
	[Calls(Type = typeof(BinXmlDateTime), Member = "WriteTimeZone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder), typeof(TimeSpan)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DateTimeOffset), Member = "get_Offset", ReturnType = typeof(TimeSpan))]
	[Calls(Type = typeof(BinXmlDateTime), Member = "WriteTimeFullPrecision", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder), typeof(int), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BinXmlDateTime), Member = "GetFractions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeOffset)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(DateTimeOffset), Member = "get_Second", ReturnType = typeof(int))]
	[Calls(Type = typeof(DateTimeOffset), Member = "get_Day", ReturnType = typeof(int))]
	[Calls(Type = typeof(DateTimeOffset), Member = "get_Hour", ReturnType = typeof(int))]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BinXmlDateTime), Member = "XsdKatmaiDateTimeOffsetToDateTimeOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int)}, ReturnType = typeof(DateTimeOffset))]
	[Calls(Type = typeof(DateTime), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(DateTime), Member = "get_Millisecond", ReturnType = typeof(int))]
	[Calls(Type = typeof(BinXmlDateTime), Member = "SqlDateTimeToDateTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(uint)}, ReturnType = typeof(DateTime))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 16)]
	private string ValueAsDateTimeString() { }

	[CalledBy(Type = typeof(XmlSqlBinaryReader), Member = "ValueAsLong", ReturnType = typeof(long))]
	[CalledBy(Type = typeof(XmlSqlBinaryReader), Member = "ValueAsDouble", ReturnType = typeof(double))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(XmlSqlBinaryReader), Member = "ValueAsULong", ReturnType = typeof(ulong))]
	[Calls(Type = typeof(BinXmlSqlDecimal), Member = "ToDecimal", ReturnType = typeof(Decimal))]
	[Calls(Type = typeof(BinXmlSqlDecimal), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Decimal), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSqlBinaryReader), Member = "ValueAsLong", ReturnType = typeof(long))]
	[Calls(Type = typeof(Decimal), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ulong)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Decimal), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(bool), typeof(byte)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSqlBinaryReader), Member = "ThrowXmlException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(Decimal), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSqlBinaryReader), Member = "GetDouble", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(double))]
	[Calls(Type = typeof(Decimal), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSqlBinaryReader), Member = "GetSingle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(XmlSqlBinaryReader), Member = "ThrowUnexpectedToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinXmlToken)}, ReturnType = typeof(Exception))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 6)]
	[ContainsUnimplementedInstructions]
	private decimal ValueAsDecimal() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlSqlBinaryReader), Member = "GetSingle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(XmlSqlBinaryReader), Member = "GetDouble", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(double))]
	[Calls(Type = typeof(XmlSqlBinaryReader), Member = "ValueAsULong", ReturnType = typeof(ulong))]
	[Calls(Type = typeof(XmlSqlBinaryReader), Member = "ValueAsLong", ReturnType = typeof(long))]
	[Calls(Type = typeof(XmlSqlBinaryReader), Member = "ValueAsDecimal", ReturnType = typeof(Decimal))]
	[Calls(Type = typeof(Decimal), Member = "op_Explicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal)}, ReturnType = typeof(double))]
	[Calls(Type = typeof(XmlSqlBinaryReader), Member = "ThrowXmlException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(XmlSqlBinaryReader), Member = "ThrowUnexpectedToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinXmlToken)}, ReturnType = typeof(Exception))]
	[CallsUnknownMethods(Count = 6)]
	[ContainsUnimplementedInstructions]
	private double ValueAsDouble() { }

	[CalledBy(Type = typeof(XmlSqlBinaryReader), Member = "ValueAsLong", ReturnType = typeof(long))]
	[CalledBy(Type = typeof(XmlSqlBinaryReader), Member = "ValueAsDecimal", ReturnType = typeof(Decimal))]
	[CalledBy(Type = typeof(XmlSqlBinaryReader), Member = "ValueAsDouble", ReturnType = typeof(double))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(XmlSqlBinaryReader), Member = "GetSingle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(XmlSqlBinaryReader), Member = "GetDouble", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(double))]
	[Calls(Type = typeof(XmlSqlBinaryReader), Member = "ValueAsULong", ReturnType = typeof(ulong))]
	[Calls(Type = typeof(XmlSqlBinaryReader), Member = "ValueAsLong", ReturnType = typeof(long))]
	[Calls(Type = typeof(XmlSqlBinaryReader), Member = "ValueAsDecimal", ReturnType = typeof(Decimal))]
	[Calls(Type = typeof(Decimal), Member = "op_Explicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal)}, ReturnType = typeof(double))]
	[Calls(Type = typeof(Decimal), Member = "op_Explicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal)}, ReturnType = typeof(long))]
	[Calls(Type = typeof(XmlSqlBinaryReader), Member = "ThrowXmlException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(XmlSqlBinaryReader), Member = "ThrowUnexpectedToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinXmlToken)}, ReturnType = typeof(Exception))]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 16)]
	[ContainsUnimplementedInstructions]
	private long ValueAsLong() { }

	[CalledBy(Type = typeof(XmlSqlBinaryReader), Member = "get_Value", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(XmlSqlBinaryReader), Member = "GetAttributeText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(XmlSqlBinaryReader), Member = "ScanAttributes", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSqlBinaryReader), Member = "ScanOverAnyValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinXmlToken), typeof(bool), typeof(bool)}, ReturnType = typeof(XmlNodeType))]
	[CallerCount(Count = 4)]
	[ContainsInvalidInstructions]
	private string ValueAsString(BinXmlToken token) { }

	[CalledBy(Type = typeof(XmlSqlBinaryReader), Member = "ValueAsLong", ReturnType = typeof(long))]
	[CalledBy(Type = typeof(XmlSqlBinaryReader), Member = "ValueAsDecimal", ReturnType = typeof(Decimal))]
	[CalledBy(Type = typeof(XmlSqlBinaryReader), Member = "ValueAsDouble", ReturnType = typeof(double))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(XmlSqlBinaryReader), Member = "ThrowXmlException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(XmlSqlBinaryReader), Member = "ThrowUnexpectedToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinXmlToken)}, ReturnType = typeof(Exception))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	private ulong ValueAsULong() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlSqlBinaryReader), Member = "ThrowUnexpectedToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinXmlToken)}, ReturnType = typeof(Exception))]
	[CallsUnknownMethods(Count = 2)]
	private void VerifyVersion(int requiredVersion, BinXmlToken token) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(StringBuilder))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private string XmlDeclValue() { }

	[CalledBy(Type = typeof(XmlSqlBinaryReader), Member = "ScanOverAnyValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinXmlToken), typeof(bool), typeof(bool)}, ReturnType = typeof(XmlNodeType))]
	[CalledBy(Type = typeof(XmlSqlBinaryReader), Member = "GetXsdKatmaiTokenLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinXmlToken)}, ReturnType = typeof(int))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(XmlException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 6)]
	private int XsdKatmaiTimeScaleToValueLength(byte scale) { }

}

