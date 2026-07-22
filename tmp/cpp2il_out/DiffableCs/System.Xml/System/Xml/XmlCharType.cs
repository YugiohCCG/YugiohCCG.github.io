namespace System.Xml;

internal struct XmlCharType
{
	private static object s_Lock; //Field offset: 0x0
	private static Byte[] s_CharProperties; //Field offset: 0x8
	internal Byte[] charProperties; //Field offset: 0x0

	public static XmlCharType Instance
	{
		[CallerCount(Count = 29)]
		[Calls(Type = typeof(XmlCharType), Member = "InitInstance", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		 get { } //Length: 121
	}

	private static object StaticLock
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		private get { } //Length: 146
	}

	[CallerCount(Count = 5)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	private XmlCharType(Byte[] charProperties) { }

	[CalledBy(Type = typeof(CharEntityEncoderFallbackBuffer), Member = "Fallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(char), typeof(int)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(CharEntityEncoderFallbackBuffer), Member = "SurrogateCharToUtf32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(char)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(XmlEncodedRawTextWriter), Member = "WriteSurrogateCharEntity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(char)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlEncodedRawTextWriterIndent), Member = "WriteSurrogateCharEntity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(char)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextEncoder), Member = "WriteSurrogateCharEntity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(char)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlUtf8RawTextWriter), Member = "WriteSurrogateCharEntity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(char)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlUtf8RawTextWriter), Member = "EncodeSurrogate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(Char*), typeof(Byte*)}, ReturnType = typeof(Byte*))]
	[CalledBy(Type = typeof(XmlUtf8RawTextWriterIndent), Member = "WriteSurrogateCharEntity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(char)}, ReturnType = typeof(void))]
	[CallerCount(Count = 8)]
	internal static int CombineSurrogateChar(int lowChar, int highChar) { }

	[CallerCount(Count = 29)]
	[Calls(Type = typeof(XmlCharType), Member = "InitInstance", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public static XmlCharType get_Instance() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private static object get_StaticLock() { }

	[CalledBy(Type = typeof(XmlCharType), Member = "get_Instance", ReturnType = typeof(XmlCharType))]
	[CalledBy(Type = typeof(XmlComplianceUtil), Member = "NonCDataNormalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(Thread), Member = "MemoryBarrier", ReturnType = typeof(void))]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 29)]
	private static void InitInstance() { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	private static bool InRange(int value, int start, int end) { }

	[CalledBy(Type = typeof(XmlEncodedRawTextWriter), Member = "WriteCharEntity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseRootLevelWhitespace", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseNumericCharRefInline", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool), typeof(StringBuilder), typeof(Int32&), typeof(EntityType&)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(XmlUtf8RawTextWriter), Member = "WriteCharEntity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	public bool IsCharData(char ch) { }

	[CallerCount(Count = 13)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public static bool IsDigit(char ch) { }

	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseAttributeValueSlow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(char), "System.Xml.XmlTextReaderImpl+NodeData"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseAttributeValueChunk", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseNumericCharRefInline", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool), typeof(StringBuilder), typeof(Int32&), typeof(EntityType&)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "SkipUntil", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseCDataOrComment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNodeType), typeof(Int32&), typeof(Int32&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParsePIValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&), typeof(Int32&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&), typeof(Int32&), typeof(Int32&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DtdParser), Member = "ScanCondSection3", ReturnType = "System.Xml.DtdParser+Token")]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ReadValueChunk", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(XmlTextEncoder), Member = "WriteRawWithSurrogateChecking", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextEncoder), Member = "Write", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextEncoder), Member = "WriteSurrogateCharEntity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(char)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextEncoder), Member = "Write", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextEncoder), Member = "WriteSurrogateChar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(char)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlEncodedRawTextWriter), Member = "ValidateContentChars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSqlBinaryReader), Member = "CheckText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(XmlNodeType))]
	[CalledBy(Type = typeof(XmlUtf8RawTextWriter), Member = "ValidateContentChars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DtdParser), Member = "ScanLiteral", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Xml.DtdParser+LiteralType"}, ReturnType = "System.Xml.DtdParser+Token")]
	[CallerCount(Count = 19)]
	[ContainsUnimplementedInstructions]
	internal static bool IsHighSurrogate(int ch) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	public bool IsLetter(char ch) { }

	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&), typeof(Int32&), typeof(Int32&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseAttributeValueChunk", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseNumericCharRefInline", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool), typeof(StringBuilder), typeof(Int32&), typeof(EntityType&)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "SkipUntil", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseCDataOrComment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNodeType), typeof(Int32&), typeof(Int32&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParsePIValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&), typeof(Int32&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DtdParser), Member = "ScanCondSection3", ReturnType = "System.Xml.DtdParser+Token")]
	[CalledBy(Type = typeof(XmlUtf8RawTextWriter), Member = "ValidateContentChars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseAttributeValueSlow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(char), "System.Xml.XmlTextReaderImpl+NodeData"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextEncoder), Member = "Write", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextEncoder), Member = "WriteSurrogateCharEntity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(char)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextEncoder), Member = "Write", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextEncoder), Member = "WriteSurrogateChar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(char)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlEncodedRawTextWriter), Member = "ValidateContentChars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSqlBinaryReader), Member = "CheckText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(XmlNodeType))]
	[CalledBy(Type = typeof(XmlTextEncoder), Member = "WriteRawWithSurrogateChecking", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DtdParser), Member = "ScanLiteral", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Xml.DtdParser+LiteralType"}, ReturnType = "System.Xml.DtdParser+Token")]
	[CallerCount(Count = 20)]
	[ContainsUnimplementedInstructions]
	internal static bool IsLowSurrogate(int ch) { }

	[CalledBy(Type = typeof(XmlConvert), Member = "EncodeName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool), typeof(bool)}, ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	public bool IsNameCharXml4e(char ch) { }

	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseXmlDeclaration", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DtdParser), Member = "ScanCondSection1", ReturnType = "System.Xml.DtdParser+Token")]
	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	public bool IsNameSingleChar(char ch) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	public bool IsNCNameCharXml4e(char ch) { }

	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseUnexpectedToken", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(DtdParser), Member = "ParseUnexpectedToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(XPathScanner), Member = "ScanName", ReturnType = typeof(string))]
	[CallerCount(Count = 6)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	public bool IsNCNameSingleChar(char ch) { }

	[CalledBy(Type = typeof(XmlWellFormedWriter), Member = "WriteDocType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DtdParser), Member = "InitializeFreeFloatingDtd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(string), typeof(string), typeof(IDtdParserAdapter)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[CallsUnknownMethods(Count = 2)]
	internal int IsOnlyCharData(string str) { }

	[CalledBy(Type = typeof(XmlDeclaration), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(XmlDocument)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlDeclaration), Member = "set_InnerText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlDeclaration), Member = "IsValidXmlVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[CallsUnknownMethods(Count = 1)]
	internal static bool IsOnlyDigits(string str, int startPos, int len) { }

	[CalledBy(Type = typeof(XmlAutoDetectWriter), Member = "WriteCData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlAutoDetectWriter), Member = "WriteString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlAutoDetectWriter), Member = "WriteRaw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlAutoDetectWriter), Member = "TextBlockCreatesWriter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XmlEncodedRawTextWriter), Member = "ValidateContentChars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextWriter), Member = "WriteWhitespace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlUtf8RawTextWriter), Member = "ValidateContentChars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlWellFormedWriter), Member = "WriteWhitespace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlCharacterData), Member = "CheckOnData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Parser), Member = "ParseReaderNode", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XmlSchemaValidator), Member = "ValidateText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(XmlValueGetter)}, ReturnType = typeof(void))]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	internal bool IsOnlyWhitespace(string str) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[CallsUnknownMethods(Count = 2)]
	internal int IsOnlyWhitespaceWithPos(string str) { }

	[CalledBy(Type = typeof(XmlCharType), Member = "IsPublicId", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public bool IsPubidChar(char ch) { }

	[CalledBy(Type = typeof(XmlWellFormedWriter), Member = "WriteDocType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DtdParser), Member = "InitializeFreeFloatingDtd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(string), typeof(string), typeof(IDtdParserAdapter)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DtdParser), Member = "ParseExternalId", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Xml.DtdParser+Token", "System.Xml.DtdParser+Token", typeof(String&), typeof(String&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(XmlCharType), Member = "IsPubidChar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	internal int IsPublicId(string str) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	public bool IsStartNCNameCharXml4e(char ch) { }

	[CalledBy(Type = typeof(XPathScanner), Member = "NextLex", ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	public bool IsStartNCNameSingleChar(char ch) { }

	[CalledBy(Type = typeof(XmlTextEncoder), Member = "WriteCharEntity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlEncodedRawTextWriter), Member = "WriteAttributeTextBlock", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(Char*)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlEncodedRawTextWriter), Member = "WriteElementTextBlock", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(Char*)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlEncodedRawTextWriter), Member = "RawText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(Char*)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlEncodedRawTextWriter), Member = "WriteRawWithCharChecking", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(Char*)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlEncodedRawTextWriter), Member = "WriteCommentOrPi", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlEncodedRawTextWriter), Member = "WriteCDataSection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlEncodedRawTextWriter), Member = "EncodeChar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*&), typeof(Char*), typeof(Char*&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlUtf8RawTextWriter), Member = "CharToUTF8", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*&), typeof(Char*), typeof(Byte*&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlUtf8RawTextWriter), Member = "WriteAttributeTextBlock", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(Char*)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlUtf8RawTextWriter), Member = "WriteElementTextBlock", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(Char*)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlUtf8RawTextWriter), Member = "RawText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(Char*)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlUtf8RawTextWriter), Member = "WriteRawWithCharChecking", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(Char*)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlUtf8RawTextWriter), Member = "WriteCommentOrPi", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlUtf8RawTextWriter), Member = "WriteCDataSection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlUtf8RawTextWriter), Member = "EncodeChar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*&), typeof(Char*), typeof(Byte*&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 16)]
	[ContainsUnimplementedInstructions]
	internal static bool IsSurrogate(int ch) { }

	[CalledBy(Type = typeof(XmlEncodedRawTextWriter), Member = "ValidateContentChars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlUtf8RawTextWriter), Member = "ValidateContentChars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	internal bool IsTextChar(char ch) { }

	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseEndElement", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&), typeof(Int32&), typeof(Int32&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseDoctypeDecl", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "IncrementalRead", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseAttributeValueChunk", ReturnType = typeof(bool))]
	[CalledBy(Type = "System.Xml.XmlWellFormedWriter+AttributeValueCache", Member = "Trim", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DtdParser), Member = "GetToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = "System.Xml.DtdParser+Token")]
	[CalledBy(Type = typeof(StringFunctions), Member = "Normalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XPathNodeIterator)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(XPathScanner), Member = "SkipSpace", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XPathScanner), Member = "NextLex", ReturnType = typeof(bool))]
	[CallerCount(Count = 16)]
	[CallsUnknownMethods(Count = 2)]
	public bool IsWhiteSpace(char ch) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[CallsUnknownMethods(Count = 2)]
	private static void SetProperties(Byte[] chProps, string ranges, byte value) { }

	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseNumericCharRefInline", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool), typeof(StringBuilder), typeof(Int32&), typeof(EntityType&)}, ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	internal static void SplitSurrogateChar(int combinedChar, out char lowChar, out char highChar) { }

}

