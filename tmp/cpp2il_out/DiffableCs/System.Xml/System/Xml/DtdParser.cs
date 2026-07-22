namespace System.Xml;

internal class DtdParser : IDtdParser
{
	private enum LiteralType
	{
		AttributeValue = 0,
		EntityReplText = 1,
		SystemOrPublicID = 2,
	}

	private class ParseElementOnlyContent_LocalFrame
	{
		public int startParenEntityId; //Field offset: 0x10
		public Token parsingSchema; //Field offset: 0x14

		[CalledBy(Type = typeof(DtdParser), Member = "ParseElementOnlyContent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParticleContentValidator), typeof(int)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		public ParseElementOnlyContent_LocalFrame(int startParentEntityIdParam) { }

	}

	private enum ScanningFunction
	{
		SubsetContent = 0,
		Name = 1,
		QName = 2,
		Nmtoken = 3,
		Doctype1 = 4,
		Doctype2 = 5,
		Element1 = 6,
		Element2 = 7,
		Element3 = 8,
		Element4 = 9,
		Element5 = 10,
		Element6 = 11,
		Element7 = 12,
		Attlist1 = 13,
		Attlist2 = 14,
		Attlist3 = 15,
		Attlist4 = 16,
		Attlist5 = 17,
		Attlist6 = 18,
		Attlist7 = 19,
		Entity1 = 20,
		Entity2 = 21,
		Entity3 = 22,
		Notation1 = 23,
		CondSection1 = 24,
		CondSection2 = 25,
		CondSection3 = 26,
		Literal = 27,
		SystemId = 28,
		PublicId1 = 29,
		PublicId2 = 30,
		ClosingTag = 31,
		ParamEntitySpace = 32,
		None = 33,
	}

	private enum Token
	{
		CDATA = 0,
		ID = 1,
		IDREF = 2,
		IDREFS = 3,
		ENTITY = 4,
		ENTITIES = 5,
		NMTOKEN = 6,
		NMTOKENS = 7,
		NOTATION = 8,
		None = 9,
		PERef = 10,
		AttlistDecl = 11,
		ElementDecl = 12,
		EntityDecl = 13,
		NotationDecl = 14,
		Comment = 15,
		PI = 16,
		CondSectionStart = 17,
		CondSectionEnd = 18,
		Eof = 19,
		REQUIRED = 20,
		IMPLIED = 21,
		FIXED = 22,
		QName = 23,
		Name = 24,
		Nmtoken = 25,
		Quote = 26,
		LeftParen = 27,
		RightParen = 28,
		GreaterThan = 29,
		Or = 30,
		LeftBracket = 31,
		RightBracket = 32,
		PUBLIC = 33,
		SYSTEM = 34,
		Literal = 35,
		DOCTYPE = 36,
		NData = 37,
		Percent = 38,
		Star = 39,
		QMark = 40,
		Plus = 41,
		PCDATA = 42,
		Comma = 43,
		ANY = 44,
		EMPTY = 45,
		IGNORE = 46,
		INCLUDE = 47,
	}

	private class UndeclaredNotation
	{
		internal string name; //Field offset: 0x10
		internal int lineNo; //Field offset: 0x18
		internal int linePos; //Field offset: 0x1C
		internal UndeclaredNotation next; //Field offset: 0x20

		[CalledBy(Type = typeof(DtdParser), Member = "AddUndeclaredNotation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		internal UndeclaredNotation(string name, int lineNo, int linePos) { }

	}

	private IDtdParserAdapter readerAdapter; //Field offset: 0x10
	private IDtdParserAdapterWithValidation readerAdapterWithValidation; //Field offset: 0x18
	private XmlNameTable nameTable; //Field offset: 0x20
	private SchemaInfo schemaInfo; //Field offset: 0x28
	private XmlCharType xmlCharType; //Field offset: 0x30
	private string systemId; //Field offset: 0x38
	private string publicId; //Field offset: 0x40
	private bool normalize; //Field offset: 0x48
	private bool validate; //Field offset: 0x49
	private bool supportNamespaces; //Field offset: 0x4A
	private bool v1Compat; //Field offset: 0x4B
	private Char[] chars; //Field offset: 0x50
	private int charsUsed; //Field offset: 0x58
	private int curPos; //Field offset: 0x5C
	private ScanningFunction scanningFunction; //Field offset: 0x60
	private ScanningFunction nextScaningFunction; //Field offset: 0x64
	private ScanningFunction savedScanningFunction; //Field offset: 0x68
	private bool whitespaceSeen; //Field offset: 0x6C
	private int tokenStartPos; //Field offset: 0x70
	private int colonPos; //Field offset: 0x74
	private StringBuilder internalSubsetValueSb; //Field offset: 0x78
	private int externalEntitiesDepth; //Field offset: 0x80
	private int currentEntityId; //Field offset: 0x84
	private bool freeFloatingDtd; //Field offset: 0x88
	private bool hasFreeFloatingInternalSubset; //Field offset: 0x89
	private StringBuilder stringBuilder; //Field offset: 0x90
	private int condSectionDepth; //Field offset: 0x98
	private LineInfo literalLineInfo; //Field offset: 0x9C
	private char literalQuoteChar; //Field offset: 0xA4
	private string documentBaseUri; //Field offset: 0xA8
	private string externalDtdBaseUri; //Field offset: 0xB0
	private Dictionary<String, UndeclaredNotation> undeclaredNotations; //Field offset: 0xB8
	private Int32[] condSectionEntityIds; //Field offset: 0xC0

	private string BaseUriStr
	{
		[CalledBy(Type = typeof(DtdParser), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DtdParser), Member = "ParseAttlistType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SchemaAttDef), typeof(SchemaElementDecl), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DtdParser), Member = "ParseEntityDecl", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DtdParser), Member = "SendValidationEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(XmlSeverityType), typeof(string), typeof(string)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DtdParser), Member = "SendValidationEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSeverityType), typeof(string), typeof(string)}, ReturnType = typeof(void))]
		[CallerCount(Count = 6)]
		[Calls(Type = typeof(Uri), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(Uri)}, ReturnType = typeof(bool))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		private get { } //Length: 174
	}

	private bool IgnoreEntityReferences
	{
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		private get { } //Length: 8
	}

	private int LineNo
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		private get { } //Length: 73
	}

	private int LinePos
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		private get { } //Length: 81
	}

	private bool Normalize
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		private get { } //Length: 5
	}

	private bool ParsingInternalSubset
	{
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		private get { } //Length: 11
	}

	private bool ParsingTopLevelMarkup
	{
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		private get { } //Length: 26
	}

	private bool SaveInternalSubsetValue
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		[ContainsUnimplementedInstructions]
		private get { } //Length: 94
	}

	private bool SupportNamespaces
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		private get { } //Length: 5
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlCharType), Member = "get_Instance", ReturnType = typeof(XmlCharType))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	private DtdParser() { }

	[CalledBy(Type = typeof(DtdParser), Member = "ParseAttlistType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SchemaAttDef), typeof(SchemaElementDecl), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DtdParser), Member = "ParseEntityDecl", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(UndeclaredNotation), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 6)]
	private void AddUndeclaredNotation(string notationName) { }

	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseDtd", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseDtdFromParserContext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlValidatingReaderImpl), Member = "Read", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XmlValidatingReaderImpl), Member = "ParseDtdFromParserContext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlLoader), Member = "ParseDocumentType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlDocumentType), typeof(bool), typeof(XmlResolver)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlLoader), Member = "CreateInnerXmlReader", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(XmlNodeType), typeof(XmlParserContext), typeof(XmlDocument)}, ReturnType = typeof(XmlReader))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(XmlCharType), Member = "get_Instance", ReturnType = typeof(XmlCharType))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	internal static IDtdParser Create() { }

	[CalledBy(Type = typeof(DtdParser), Member = "GetToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(Token))]
	[CalledBy(Type = typeof(DtdParser), Member = "ScanDoctype1", ReturnType = typeof(Token))]
	[CalledBy(Type = typeof(DtdParser), Member = "ScanNotation1", ReturnType = typeof(Token))]
	[CalledBy(Type = typeof(DtdParser), Member = "ScanEntity2", ReturnType = typeof(Token))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(DtdParser), Member = "ReadData", ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 2)]
	private bool EatPublicKeyword() { }

	[CalledBy(Type = typeof(DtdParser), Member = "GetToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(Token))]
	[CalledBy(Type = typeof(DtdParser), Member = "ScanDoctype1", ReturnType = typeof(Token))]
	[CalledBy(Type = typeof(DtdParser), Member = "ScanNotation1", ReturnType = typeof(Token))]
	[CalledBy(Type = typeof(DtdParser), Member = "ScanEntity2", ReturnType = typeof(Token))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(DtdParser), Member = "ReadData", ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 2)]
	private bool EatSystemKeyword() { }

	[CalledBy(Type = typeof(DtdParser), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DtdParser), Member = "ParseAttlistType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SchemaAttDef), typeof(SchemaElementDecl), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DtdParser), Member = "ParseEntityDecl", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DtdParser), Member = "SendValidationEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(XmlSeverityType), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DtdParser), Member = "SendValidationEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSeverityType), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(Uri), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(Uri)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private string get_BaseUriStr() { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	private bool get_IgnoreEntityReferences() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private int get_LineNo() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private int get_LinePos() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	private bool get_Normalize() { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	private bool get_ParsingInternalSubset() { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	private bool get_ParsingTopLevelMarkup() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	private bool get_SaveInternalSubsetValue() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	private bool get_SupportNamespaces() { }

	[CalledBy(Type = typeof(DtdParser), Member = "ParseInDocumentDtd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DtdParser), Member = "ParseAttlistDecl", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DtdParser), Member = "ParseElementDecl", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DtdParser), Member = "ParseElementOnlyContent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParticleContentValidator), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DtdParser), Member = "ParseElementMixedContent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParticleContentValidator), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DtdParser), Member = "ParseEntityDecl", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DtdParser), Member = "ParseNotationDecl", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DtdParser), Member = "ScanEntityName", ReturnType = typeof(XmlQualifiedName))]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(string), Member = "CreateString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(DtdParser), Member = "Throw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlQualifiedName), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlQualifiedName), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	private XmlQualifiedName GetNameQualified(bool canHavePrefix) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "CreateString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[DeduplicatedMethod]
	private string GetNameString() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "CreateString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[DeduplicatedMethod]
	private string GetNmtokenString() { }

	[CalledBy(Type = typeof(DtdParser), Member = "ParseInDocumentDtd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DtdParser), Member = "ParseCondSection", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DtdParser), Member = "ParseNotationDecl", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DtdParser), Member = "ParseEntityDecl", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DtdParser), Member = "ParseElementMixedContent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParticleContentValidator), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DtdParser), Member = "ParseHowMany", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParticleContentValidator)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DtdParser), Member = "ParseExternalId", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Token), typeof(Token), typeof(String&), typeof(String&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DtdParser), Member = "ParseElementDecl", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DtdParser), Member = "ParseAttlistDefault", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SchemaAttDef), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DtdParser), Member = "ParseAttlistType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SchemaAttDef), typeof(SchemaElementDecl), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DtdParser), Member = "ParseAttlistDecl", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DtdParser), Member = "ParseSubset", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DtdParser), Member = "ParseElementOnlyContent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParticleContentValidator), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 48)]
	[Calls(Type = typeof(DtdParser), Member = "EatPublicKeyword", ReturnType = typeof(bool))]
	[Calls(Type = typeof(DtdParser), Member = "ScanElement1", ReturnType = typeof(Token))]
	[Calls(Type = typeof(DtdParser), Member = "ScanElement2", ReturnType = typeof(Token))]
	[Calls(Type = typeof(DtdParser), Member = "ThrowUnexpectedToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DtdParser), Member = "ScanAttlist2", ReturnType = typeof(Token))]
	[Calls(Type = typeof(DtdParser), Member = "ReadData", ReturnType = typeof(int))]
	[Calls(Type = typeof(DtdParser), Member = "ScanLiteral", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LiteralType)}, ReturnType = typeof(Token))]
	[Calls(Type = typeof(DtdParser), Member = "ScanCondSection1", ReturnType = typeof(Token))]
	[Calls(Type = typeof(DtdParser), Member = "ScanCondSection3", ReturnType = typeof(Token))]
	[Calls(Type = typeof(DtdParser), Member = "EatSystemKeyword", ReturnType = typeof(bool))]
	[Calls(Type = typeof(DtdParser), Member = "ScanAttlist6", ReturnType = typeof(Token))]
	[Calls(Type = typeof(DtdParser), Member = "ScanNmtoken", ReturnType = typeof(void))]
	[Calls(Type = typeof(DtdParser), Member = "SaveParsingBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DtdParser), Member = "ScanSubsetContent", ReturnType = typeof(Token))]
	[Calls(Type = typeof(DtdParser), Member = "ParseUnexpectedToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(DtdParser), Member = "Throw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DtdParser), Member = "HandleEntityEnd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DtdParser), Member = "LoadParsingBuffer", ReturnType = typeof(void))]
	[Calls(Type = typeof(DtdParser), Member = "Throw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string), typeof(String[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlException), Member = "BuildCharExceptionArgs", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(String[]))]
	[Calls(Type = typeof(DtdParser), Member = "HandleEntityReference", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DtdParser), Member = "ScanEntityName", ReturnType = typeof(XmlQualifiedName))]
	[Calls(Type = typeof(XmlCharType), Member = "IsWhiteSpace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DtdParser), Member = "ScanQName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 10)]
	private Token GetToken(bool needWhiteSpace) { }

	[CalledBy(Type = typeof(DtdParser), Member = "ParseAttlistDefault", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SchemaAttDef), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DtdParser), Member = "ParseEntityDecl", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DtdParser), Member = "ParseExternalId", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Token), typeof(Token), typeof(String&), typeof(String&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(string), Member = "CreateString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	private string GetValue() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "CreateString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(DtdParser), Member = "StripSpaces", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	private string GetValueWithStrippedSpaces() { }

	[CalledBy(Type = typeof(DtdParser), Member = "GetToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(Token))]
	[CalledBy(Type = typeof(DtdParser), Member = "ScanLiteral", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LiteralType)}, ReturnType = typeof(Token))]
	[CalledBy(Type = typeof(DtdParser), Member = "ScanCondSection3", ReturnType = typeof(Token))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(DtdParser), Member = "SaveParsingBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DtdParser), Member = "LoadParsingBuffer", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private bool HandleEntityEnd(bool inLiteral) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DtdParser), Member = "ScanEntityName", ReturnType = typeof(XmlQualifiedName))]
	[Calls(Type = typeof(DtdParser), Member = "HandleEntityReference", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
	private bool HandleEntityReference(bool paramEntity, bool inLiteral, bool inAttribute) { }

	[CalledBy(Type = typeof(DtdParser), Member = "GetToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(Token))]
	[CalledBy(Type = typeof(DtdParser), Member = "ScanLiteral", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LiteralType)}, ReturnType = typeof(Token))]
	[CalledBy(Type = typeof(DtdParser), Member = "HandleEntityReference", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(DtdParser), Member = "SaveParsingBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DtdParser), Member = "Throw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DtdParser), Member = "VerifyEntityReference", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(SchemaEntity))]
	[Calls(Type = typeof(DtdParser), Member = "LoadParsingBuffer", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private bool HandleEntityReference(XmlQualifiedName entityName, bool paramEntity, bool inLiteral, bool inAttribute) { }

	[CalledBy(Type = typeof(DtdParser), Member = "InitializeFreeFloatingDtd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(string), typeof(string), typeof(IDtdParserAdapter)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DtdParser), Member = "System.Xml.IDtdParser.ParseInternalDtd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IDtdParserAdapter), typeof(bool)}, ReturnType = typeof(IDtdInfo))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(SchemaInfo), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(Uri), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(Uri)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 17)]
	private void Initialize(IDtdParserAdapter readerAdapter) { }

	[CalledBy(Type = typeof(DtdParser), Member = "System.Xml.IDtdParser.ParseFreeFloatingDtd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(string), typeof(string), typeof(IDtdParserAdapter)}, ReturnType = typeof(IDtdInfo))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DtdParser), Member = "Initialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IDtdParserAdapter)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlConvert), Member = "VerifyName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(XmlQualifiedName), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlQualifiedName), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlCharType), Member = "IsOnlyCharData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(DtdParser), Member = "ThrowInvalidChar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlCharType), Member = "IsPublicId", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Uri), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(Uri)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlConvert), Member = "CreateInvalidNameArgumentException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(ArgumentException))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 12)]
	private void InitializeFreeFloatingDtd(string baseUri, string docTypeName, string publicId, string systemId, string internalSubset, IDtdParserAdapter adapter) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	private bool IsAttributeValueType(Token token) { }

	[CallerCount(Count = 25)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	private void LoadParsingBuffer() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DtdParser), Member = "Throw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	private void OnUnexpectedError() { }

	[CalledBy(Type = typeof(DtdParser), Member = "System.Xml.IDtdParser.ParseInternalDtd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IDtdParserAdapter), typeof(bool)}, ReturnType = typeof(IDtdInfo))]
	[CalledBy(Type = typeof(DtdParser), Member = "System.Xml.IDtdParser.ParseFreeFloatingDtd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(string), typeof(string), typeof(IDtdParserAdapter)}, ReturnType = typeof(IDtdInfo))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(DtdParser), Member = "ParseInDocumentDtd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DtdParser), Member = "LoadParsingBuffer", ReturnType = typeof(void))]
	[Calls(Type = typeof(DtdParser), Member = "ParseSubset", ReturnType = typeof(void))]
	[Calls(Type = typeof(DtdParser), Member = "SaveParsingBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DtdParser), Member = "ParseExternalSubset", ReturnType = typeof(void))]
	[Calls(Type = typeof(SchemaInfo), Member = "Finish", ReturnType = typeof(void))]
	[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(DtdParser), Member = "get_BaseUriStr", ReturnType = typeof(string))]
	[Calls(Type = typeof(XmlSchemaException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DtdParser), Member = "SendValidationEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSeverityType), typeof(XmlSchemaException)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 3)]
	private void Parse(bool saveInternalSubset) { }

	[CalledBy(Type = typeof(DtdParser), Member = "ParseSubset", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DtdParser), Member = "ParseAttlistType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SchemaAttDef), typeof(SchemaElementDecl), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Trim", ReturnType = typeof(string))]
	[Calls(Type = typeof(SchemaAttDef), Member = "CheckXmlSpace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IValidationEventHandling)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DtdParser), Member = "Throw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SchemaAttDef), Member = "get_TokenizedType", ReturnType = typeof(XmlTokenizedType))]
	[Calls(Type = typeof(string), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(SchemaDeclBase), Member = "get_Prefix", ReturnType = typeof(string))]
	[Calls(Type = typeof(DtdParser), Member = "ParseAttlistDefault", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SchemaAttDef), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SchemaElementDecl), Member = "GetAttDef", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName)}, ReturnType = typeof(SchemaAttDef))]
	[Calls(Type = typeof(SchemaElementDecl), Member = "AddAttDef", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SchemaAttDef)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SchemaAttDef), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SchemaElementDecl), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DtdParser), Member = "GetNameQualified", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(XmlQualifiedName))]
	[Calls(Type = typeof(DtdParser), Member = "GetToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(Token))]
	[Calls(Type = typeof(DtdParser), Member = "Throw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 5)]
	[ContainsUnimplementedInstructions]
	private void ParseAttlistDecl() { }

	[CalledBy(Type = typeof(DtdParser), Member = "ParseAttlistDecl", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DtdParser), Member = "GetToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(Token))]
	[Calls(Type = typeof(DtdParser), Member = "Throw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DtdParser), Member = "SendValidationEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(XmlSeverityType), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SchemaAttDef), Member = "get_TokenizedType", ReturnType = typeof(XmlTokenizedType))]
	[Calls(Type = typeof(DtdParser), Member = "GetValue", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "CreateString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(DtdParser), Member = "StripSpaces", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(DtdValidator), Member = "SetDefaultTypedValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SchemaAttDef), typeof(IDtdParserAdapter)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	private void ParseAttlistDefault(SchemaAttDef attrDef, bool ignoreErrors) { }

	[CalledBy(Type = typeof(DtdParser), Member = "ParseAttlistDecl", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DtdParser), Member = "Throw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DtdParser), Member = "AddUndeclaredNotation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Dictionary`2), Member = "ContainsKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(SchemaInfo), Member = "get_Notations", ReturnType = typeof(System.Collections.Generic.Dictionary`2<System.String, System.Xml.Schema.SchemaNotation>))]
	[Calls(Type = typeof(DtdParser), Member = "SendValidationEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(XmlSeverityType), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DtdParser), Member = "SendValidationEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSeverityType), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SchemaElementDecl), Member = "GetAttDef", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName)}, ReturnType = typeof(SchemaAttDef))]
	[Calls(Type = typeof(DtdParser), Member = "SendValidationEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSeverityType), typeof(XmlSchemaException)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSchemaException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DtdParser), Member = "get_BaseUriStr", ReturnType = typeof(string))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(SchemaDeclBase), Member = "AddValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "CreateString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(XmlSchemaType), Member = "GetBuiltInSimpleType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlTypeCode)}, ReturnType = typeof(XmlSchemaSimpleType))]
	[Calls(Type = typeof(SchemaAttDef), Member = "set_TokenizedType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlTokenizedType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DtdParser), Member = "GetToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(Token))]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 7)]
	private void ParseAttlistType(SchemaAttDef attrDef, SchemaElementDecl elementDecl, bool ignoreErrors) { }

	[CalledBy(Type = typeof(DtdParser), Member = "ParseSubset", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DtdParser), Member = "SaveParsingBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(DtdParser), Member = "SendValidationEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSeverityType), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DtdParser), Member = "LoadParsingBuffer", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 12)]
	private void ParseComment() { }

	[CalledBy(Type = typeof(DtdParser), Member = "ParseSubset", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DtdParser), Member = "GetToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(Token))]
	[Calls(Type = typeof(DtdParser), Member = "SendValidationEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(XmlSeverityType), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DtdParser), Member = "Throw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	private void ParseCondSection() { }

	[CalledBy(Type = typeof(DtdParser), Member = "ParseSubset", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "CreateString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ParticleContentValidator), Member = "Finish", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(ContentValidator))]
	[Calls(Type = typeof(DtdParser), Member = "ParseElementOnlyContent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParticleContentValidator), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ParticleContentValidator), Member = "OpenGroup", ReturnType = typeof(void))]
	[Calls(Type = typeof(ParticleContentValidator), Member = "Start", ReturnType = typeof(void))]
	[Calls(Type = typeof(ParticleContentValidator), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaContentType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DtdParser), Member = "SendValidationEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(XmlSeverityType), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DtdParser), Member = "ParseElementMixedContent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParticleContentValidator), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(SchemaElementDecl), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DtdParser), Member = "GetNameQualified", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(XmlQualifiedName))]
	[Calls(Type = typeof(DtdParser), Member = "GetToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(Token))]
	[Calls(Type = typeof(DtdParser), Member = "Throw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DtdParser), Member = "ThrowUnexpectedToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	private void ParseElementDecl() { }

	[CalledBy(Type = typeof(DtdParser), Member = "ParseElementDecl", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DtdParser), Member = "GetToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(Token))]
	[Calls(Type = typeof(ParticleContentValidator), Member = "AddChoice", ReturnType = typeof(void))]
	[Calls(Type = typeof(DtdParser), Member = "SendValidationEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(XmlSeverityType), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DtdParser), Member = "GetNameQualified", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(XmlQualifiedName))]
	[Calls(Type = typeof(ParticleContentValidator), Member = "Exists", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DtdParser), Member = "SendValidationEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSeverityType), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ParticleContentValidator), Member = "AddName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DtdParser), Member = "Throw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ParticleContentValidator), Member = "CloseGroup", ReturnType = typeof(void))]
	[Calls(Type = typeof(DtdParser), Member = "ThrowUnexpectedToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ParticleContentValidator), Member = "AddStar", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private void ParseElementMixedContent(ParticleContentValidator pcv, int startParenEntityId) { }

	[CalledBy(Type = typeof(DtdParser), Member = "ParseElementDecl", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ParticleContentValidator), Member = "AddChoice", ReturnType = typeof(void))]
	[Calls(Type = typeof(ParticleContentValidator), Member = "AddSequence", ReturnType = typeof(void))]
	[Calls(Type = typeof(DtdParser), Member = "SendValidationEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(XmlSeverityType), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ParticleContentValidator), Member = "CloseGroup", ReturnType = typeof(void))]
	[Calls(Type = typeof(Stack`1), Member = "Peek", ReturnType = "T")]
	[Calls(Type = typeof(System.Collections.Generic.Stack`1<System.Object>), Member = "Pop", ReturnType = typeof(object))]
	[Calls(Type = typeof(DtdParser), Member = "Throw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ParticleContentValidator), Member = "OpenGroup", ReturnType = typeof(void))]
	[Calls(Type = typeof(ParticleContentValidator), Member = "AddStar", ReturnType = typeof(void))]
	[Calls(Type = typeof(ParticleContentValidator), Member = "AddQMark", ReturnType = typeof(void))]
	[Calls(Type = typeof(ParticleContentValidator), Member = "AddPlus", ReturnType = typeof(void))]
	[Calls(Type = typeof(ParticleContentValidator), Member = "AddName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DtdParser), Member = "GetNameQualified", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(XmlQualifiedName))]
	[Calls(Type = typeof(DtdParser), Member = "GetToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(Token))]
	[Calls(Type = typeof(System.Collections.Generic.Stack`1<System.Object>), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ParseElementOnlyContent_LocalFrame), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void ParseElementOnlyContent(ParticleContentValidator pcv, int startParenEntityId) { }

	[CalledBy(Type = typeof(DtdParser), Member = "ParseSubset", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SchemaInfo), Member = "get_ParameterEntities", ReturnType = typeof(System.Collections.Generic.Dictionary`2<System.Xml.XmlQualifiedName, System.Xml.Schema.SchemaEntity>))]
	[Calls(Type = typeof(SchemaInfo), Member = "get_Notations", ReturnType = typeof(System.Collections.Generic.Dictionary`2<System.String, System.Xml.Schema.SchemaNotation>))]
	[Calls(Type = typeof(DtdParser), Member = "Throw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DtdParser), Member = "ThrowUnexpectedToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SchemaEntity), Member = "set_Url", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DtdParser), Member = "ParseExternalId", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Token), typeof(Token), typeof(String&), typeof(String&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Dictionary`2), Member = "ContainsKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DtdParser), Member = "AddUndeclaredNotation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SchemaInfo), Member = "get_GeneralEntities", ReturnType = typeof(System.Collections.Generic.Dictionary`2<System.Xml.XmlQualifiedName, System.Xml.Schema.SchemaEntity>))]
	[Calls(Type = typeof(DtdParser), Member = "get_BaseUriStr", ReturnType = typeof(string))]
	[Calls(Type = typeof(SchemaEntity), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DtdParser), Member = "GetNameQualified", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(XmlQualifiedName))]
	[Calls(Type = typeof(DtdParser), Member = "GetToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(Token))]
	[Calls(Type = typeof(SchemaEntity), Member = "set_Text", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DtdParser), Member = "GetValue", ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 5)]
	[ContainsUnimplementedInstructions]
	private void ParseEntityDecl() { }

	[CalledBy(Type = typeof(DtdParser), Member = "ParseInDocumentDtd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DtdParser), Member = "ParseEntityDecl", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DtdParser), Member = "ParseNotationDecl", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(DtdParser), Member = "GetToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(Token))]
	[Calls(Type = typeof(DtdParser), Member = "ThrowUnexpectedToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DtdParser), Member = "GetValue", ReturnType = typeof(string))]
	[Calls(Type = typeof(XmlCharType), Member = "IsPublicId", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(XmlException), Member = "BuildCharExceptionArgs", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(String[]))]
	[Calls(Type = typeof(DtdParser), Member = "Throw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string), typeof(String[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "CreateString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(DtdParser), Member = "Throw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 14)]
	private void ParseExternalId(Token idTokenType, Token declType, out string publicId, out string systemId) { }

	[CalledBy(Type = typeof(DtdParser), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DtdParser), Member = "ParseInDocumentDtd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DtdParser), Member = "ParseFreeFloatingDtd", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Uri), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(Uri)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DtdParser), Member = "LoadParsingBuffer", ReturnType = typeof(void))]
	[Calls(Type = typeof(DtdParser), Member = "ParseSubset", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	private void ParseExternalSubset() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DtdParser), Member = "LoadParsingBuffer", ReturnType = typeof(void))]
	[Calls(Type = typeof(DtdParser), Member = "ParseSubset", ReturnType = typeof(void))]
	[Calls(Type = typeof(DtdParser), Member = "SaveParsingBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DtdParser), Member = "ParseExternalSubset", ReturnType = typeof(void))]
	private void ParseFreeFloatingDtd() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DtdParser), Member = "GetToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(Token))]
	[Calls(Type = typeof(ParticleContentValidator), Member = "AddPlus", ReturnType = typeof(void))]
	[Calls(Type = typeof(ParticleContentValidator), Member = "AddQMark", ReturnType = typeof(void))]
	[Calls(Type = typeof(ParticleContentValidator), Member = "AddStar", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private void ParseHowMany(ParticleContentValidator pcv) { }

	[CalledBy(Type = typeof(DtdParser), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DtdParser), Member = "LoadParsingBuffer", ReturnType = typeof(void))]
	[Calls(Type = typeof(DtdParser), Member = "GetToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(Token))]
	[Calls(Type = typeof(DtdParser), Member = "Throw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DtdParser), Member = "GetNameQualified", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(XmlQualifiedName))]
	[Calls(Type = typeof(DtdParser), Member = "ParseExternalId", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Token), typeof(Token), typeof(String&), typeof(String&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DtdParser), Member = "SaveParsingBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(DtdParser), Member = "ParseSubset", ReturnType = typeof(void))]
	[Calls(Type = typeof(DtdParser), Member = "ParseExternalSubset", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	private void ParseInDocumentDtd(bool saveInternalSubset) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DtdParser), Member = "ParseSubset", ReturnType = typeof(void))]
	private void ParseInternalSubset() { }

	[CalledBy(Type = typeof(DtdParser), Member = "ParseSubset", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DtdParser), Member = "GetToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(Token))]
	[Calls(Type = typeof(DtdParser), Member = "Throw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DtdParser), Member = "GetNameQualified", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(XmlQualifiedName))]
	[Calls(Type = typeof(SchemaInfo), Member = "get_Notations", ReturnType = typeof(System.Collections.Generic.Dictionary`2<System.String, System.Xml.Schema.SchemaNotation>))]
	[Calls(Type = typeof(Dictionary`2), Member = "ContainsKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DtdParser), Member = "SendValidationEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(XmlSeverityType), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DtdParser), Member = "ParseExternalId", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Token), typeof(Token), typeof(String&), typeof(String&)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private void ParseNotationDecl() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DtdParser), Member = "SaveParsingBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DtdParser), Member = "LoadParsingBuffer", ReturnType = typeof(void))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(StringBuilder))]
	[CallsUnknownMethods(Count = 4)]
	private void ParsePI() { }

	[CalledBy(Type = typeof(DtdParser), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DtdParser), Member = "ParseInDocumentDtd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DtdParser), Member = "ParseFreeFloatingDtd", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DtdParser), Member = "ParseInternalSubset", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DtdParser), Member = "ParseExternalSubset", ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(DtdParser), Member = "ThrowUnexpectedToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DtdParser), Member = "SendValidationEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(XmlSeverityType), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DtdParser), Member = "ParseCondSection", ReturnType = typeof(void))]
	[Calls(Type = typeof(DtdParser), Member = "Throw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(DtdParser), Member = "LoadParsingBuffer", ReturnType = typeof(void))]
	[Calls(Type = typeof(DtdParser), Member = "ParseNotationDecl", ReturnType = typeof(void))]
	[Calls(Type = typeof(DtdParser), Member = "ParseComment", ReturnType = typeof(void))]
	[Calls(Type = typeof(DtdParser), Member = "ParseEntityDecl", ReturnType = typeof(void))]
	[Calls(Type = typeof(DtdParser), Member = "ParseElementDecl", ReturnType = typeof(void))]
	[Calls(Type = typeof(DtdParser), Member = "ParseAttlistDecl", ReturnType = typeof(void))]
	[Calls(Type = typeof(DtdParser), Member = "GetToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(Token))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(StringBuilder))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 14)]
	private void ParseSubset() { }

	[CalledBy(Type = typeof(DtdParser), Member = "GetToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(Token))]
	[CalledBy(Type = typeof(DtdParser), Member = "ScanAttlist1", ReturnType = typeof(Token))]
	[CalledBy(Type = typeof(DtdParser), Member = "ThrowUnexpectedToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(XmlCharType), Member = "IsNCNameSingleChar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "CreateString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 2)]
	private string ParseUnexpectedToken(int startPos) { }

	[CalledBy(Type = typeof(DtdParser), Member = "GetToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(Token))]
	[CalledBy(Type = typeof(DtdParser), Member = "ScanEntity3", ReturnType = typeof(Token))]
	[CalledBy(Type = typeof(DtdParser), Member = "ScanQName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DtdParser), Member = "ReadDataInName", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DtdParser), Member = "EatPublicKeyword", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DtdParser), Member = "EatSystemKeyword", ReturnType = typeof(bool))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(DtdParser), Member = "SaveParsingBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DtdParser), Member = "LoadParsingBuffer", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	private int ReadData() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DtdParser), Member = "ReadData", ReturnType = typeof(int))]
	[ContainsUnimplementedInstructions]
	private bool ReadDataInName() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DtdParser), Member = "SaveParsingBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	private void SaveParsingBuffer() { }

	[CalledBy(Type = typeof(DtdParser), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DtdParser), Member = "HandleEntityEnd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DtdParser), Member = "HandleEntityReference", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DtdParser), Member = "SaveParsingBuffer", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DtdParser), Member = "ReadData", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(DtdParser), Member = "ScanNmtoken", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DtdParser), Member = "ScanCondSection3", ReturnType = typeof(Token))]
	[CalledBy(Type = typeof(DtdParser), Member = "ScanCondSection1", ReturnType = typeof(Token))]
	[CalledBy(Type = typeof(DtdParser), Member = "ScanLiteral", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LiteralType)}, ReturnType = typeof(Token))]
	[CalledBy(Type = typeof(DtdParser), Member = "ScanAttlist6", ReturnType = typeof(Token))]
	[CalledBy(Type = typeof(DtdParser), Member = "ScanElement2", ReturnType = typeof(Token))]
	[CalledBy(Type = typeof(DtdParser), Member = "ScanElement1", ReturnType = typeof(Token))]
	[CalledBy(Type = typeof(DtdParser), Member = "ScanSubsetContent", ReturnType = typeof(Token))]
	[CalledBy(Type = typeof(DtdParser), Member = "GetToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(Token))]
	[CalledBy(Type = typeof(DtdParser), Member = "ParsePI", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DtdParser), Member = "ParseComment", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DtdParser), Member = "ParseFreeFloatingDtd", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DtdParser), Member = "ParseInDocumentDtd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DtdParser), Member = "ScanAttlist2", ReturnType = typeof(Token))]
	[CallerCount(Count = 24)]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(StringBuilder))]
	[CallsUnknownMethods(Count = 4)]
	private void SaveParsingBuffer(int internalSubsetValueEndPos) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DtdParser), Member = "ParseUnexpectedToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(DtdParser), Member = "Throw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DtdParser), Member = "ScanQName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	private Token ScanAttlist1() { }

	[CalledBy(Type = typeof(DtdParser), Member = "GetToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(Token))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DtdParser), Member = "Throw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DtdParser), Member = "SaveParsingBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DtdParser), Member = "LoadParsingBuffer", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	private Token ScanAttlist2() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DtdParser), Member = "ThrowUnexpectedToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	private Token ScanAttlist3() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DtdParser), Member = "ThrowUnexpectedToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	private Token ScanAttlist4() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DtdParser), Member = "ThrowUnexpectedToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	private Token ScanAttlist5() { }

	[CalledBy(Type = typeof(DtdParser), Member = "GetToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(Token))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DtdParser), Member = "Throw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DtdParser), Member = "SaveParsingBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DtdParser), Member = "LoadParsingBuffer", ReturnType = typeof(void))]
	[Calls(Type = typeof(DtdParser), Member = "ScanLiteral", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LiteralType)}, ReturnType = typeof(Token))]
	[CallsUnknownMethods(Count = 3)]
	private Token ScanAttlist6() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DtdParser), Member = "ThrowUnexpectedToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DtdParser), Member = "ScanLiteral", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LiteralType)}, ReturnType = typeof(Token))]
	[CallsUnknownMethods(Count = 2)]
	private Token ScanAttlist7() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DtdParser), Member = "ThrowUnexpectedToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	private Token ScanClosingTag() { }

	[CalledBy(Type = typeof(DtdParser), Member = "GetToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(Token))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DtdParser), Member = "Throw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DtdParser), Member = "SaveParsingBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DtdParser), Member = "LoadParsingBuffer", ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlCharType), Member = "IsNameSingleChar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 3)]
	private Token ScanCondSection1() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DtdParser), Member = "ThrowUnexpectedToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	private Token ScanCondSection2() { }

	[CalledBy(Type = typeof(DtdParser), Member = "GetToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(Token))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(XmlCharType), Member = "IsHighSurrogate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlCharType), Member = "IsLowSurrogate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DtdParser), Member = "SaveParsingBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DtdParser), Member = "LoadParsingBuffer", ReturnType = typeof(void))]
	[Calls(Type = typeof(DtdParser), Member = "HandleEntityEnd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DtdParser), Member = "Throw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlException), Member = "BuildCharExceptionArgs", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(String[]))]
	[Calls(Type = typeof(DtdParser), Member = "Throw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string), typeof(String[])}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 6)]
	private Token ScanCondSection3() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DtdParser), Member = "EatSystemKeyword", ReturnType = typeof(bool))]
	[Calls(Type = typeof(DtdParser), Member = "Throw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DtdParser), Member = "EatPublicKeyword", ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 2)]
	private Token ScanDoctype1() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DtdParser), Member = "Throw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	private Token ScanDoctype2() { }

	[CalledBy(Type = typeof(DtdParser), Member = "GetToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(Token))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DtdParser), Member = "Throw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DtdParser), Member = "SaveParsingBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DtdParser), Member = "LoadParsingBuffer", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	private Token ScanElement1() { }

	[CalledBy(Type = typeof(DtdParser), Member = "GetToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(Token))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DtdParser), Member = "SaveParsingBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DtdParser), Member = "LoadParsingBuffer", ReturnType = typeof(void))]
	[Calls(Type = typeof(DtdParser), Member = "Throw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	private Token ScanElement2() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DtdParser), Member = "ScanQName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	private Token ScanElement3() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DtdParser), Member = "Throw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	private Token ScanElement4() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DtdParser), Member = "Throw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	private Token ScanElement5() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DtdParser), Member = "ThrowUnexpectedToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	private Token ScanElement6() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private Token ScanElement7() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DtdParser), Member = "ScanQName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	private Token ScanEntity1() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DtdParser), Member = "EatPublicKeyword", ReturnType = typeof(bool))]
	[Calls(Type = typeof(DtdParser), Member = "Throw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DtdParser), Member = "EatSystemKeyword", ReturnType = typeof(bool))]
	[Calls(Type = typeof(DtdParser), Member = "ScanLiteral", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LiteralType)}, ReturnType = typeof(Token))]
	[CallsUnknownMethods(Count = 2)]
	private Token ScanEntity2() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DtdParser), Member = "ReadData", ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 2)]
	private Token ScanEntity3() { }

	[CalledBy(Type = typeof(DtdParser), Member = "GetToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(Token))]
	[CalledBy(Type = typeof(DtdParser), Member = "ScanLiteral", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LiteralType)}, ReturnType = typeof(Token))]
	[CalledBy(Type = typeof(DtdParser), Member = "HandleEntityReference", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(DtdParser), Member = "ScanQName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DtdParser), Member = "Throw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DtdParser), Member = "ThrowUnexpectedToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DtdParser), Member = "GetNameQualified", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(XmlQualifiedName))]
	[CallsUnknownMethods(Count = 3)]
	private XmlQualifiedName ScanEntityName() { }

	[CalledBy(Type = typeof(DtdParser), Member = "GetToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(Token))]
	[CalledBy(Type = typeof(DtdParser), Member = "ScanAttlist6", ReturnType = typeof(Token))]
	[CalledBy(Type = typeof(DtdParser), Member = "ScanAttlist7", ReturnType = typeof(Token))]
	[CalledBy(Type = typeof(DtdParser), Member = "ScanSystemId", ReturnType = typeof(Token))]
	[CalledBy(Type = typeof(DtdParser), Member = "ScanEntity2", ReturnType = typeof(Token))]
	[CalledBy(Type = typeof(DtdParser), Member = "ScanPublicId1", ReturnType = typeof(Token))]
	[CalledBy(Type = typeof(DtdParser), Member = "ScanPublicId2", ReturnType = typeof(Token))]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(DtdParser), Member = "LoadParsingBuffer", ReturnType = typeof(void))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(SchemaInfo), Member = "get_GeneralEntities", ReturnType = typeof(System.Collections.Generic.Dictionary`2<System.Xml.XmlQualifiedName, System.Xml.Schema.SchemaEntity>))]
	[Calls(Type = typeof(XmlCharType), Member = "IsLowSurrogate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlQualifiedName), Member = "get_IsEmpty", ReturnType = typeof(bool))]
	[Calls(Type = typeof(DtdParser), Member = "Throw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DtdParser), Member = "SaveParsingBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DtdParser), Member = "HandleEntityReference", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlCharType), Member = "IsHighSurrogate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlException), Member = "BuildCharExceptionArgs", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(String[]))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(DtdParser), Member = "Throw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string), typeof(String[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlException), Member = "BuildCharExceptionArgs", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(char)}, ReturnType = typeof(String[]))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(StringBuilder), Member = "set_Length", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DtdParser), Member = "ScanEntityName", ReturnType = typeof(XmlQualifiedName))]
	[Calls(Type = typeof(DtdParser), Member = "HandleEntityEnd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallsUnknownMethods(Count = 19)]
	[ContainsUnimplementedInstructions]
	private Token ScanLiteral(LiteralType literalType) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DtdParser), Member = "ScanQName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	private void ScanName() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DtdParser), Member = "ScanQName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	private Token ScanNameExpected() { }

	[CalledBy(Type = typeof(DtdParser), Member = "GetToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(Token))]
	[CalledBy(Type = typeof(DtdParser), Member = "ScanNmtokenExpected", ReturnType = typeof(Token))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(DtdParser), Member = "SaveParsingBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DtdParser), Member = "LoadParsingBuffer", ReturnType = typeof(void))]
	[Calls(Type = typeof(DtdParser), Member = "Throw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlException), Member = "BuildCharExceptionArgs", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(String[]))]
	[Calls(Type = typeof(DtdParser), Member = "Throw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string), typeof(String[])}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	private void ScanNmtoken() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DtdParser), Member = "ScanNmtoken", ReturnType = typeof(void))]
	private Token ScanNmtokenExpected() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DtdParser), Member = "EatPublicKeyword", ReturnType = typeof(bool))]
	[Calls(Type = typeof(DtdParser), Member = "Throw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DtdParser), Member = "EatSystemKeyword", ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 2)]
	private Token ScanNotation1() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DtdParser), Member = "ThrowUnexpectedToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DtdParser), Member = "ScanLiteral", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LiteralType)}, ReturnType = typeof(Token))]
	[CallsUnknownMethods(Count = 2)]
	private Token ScanPublicId1() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DtdParser), Member = "ScanLiteral", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LiteralType)}, ReturnType = typeof(Token))]
	[CallsUnknownMethods(Count = 2)]
	private Token ScanPublicId2() { }

	[CalledBy(Type = typeof(DtdParser), Member = "GetToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(Token))]
	[CalledBy(Type = typeof(DtdParser), Member = "ScanNameExpected", ReturnType = typeof(Token))]
	[CalledBy(Type = typeof(DtdParser), Member = "ScanQNameExpected", ReturnType = typeof(Token))]
	[CalledBy(Type = typeof(DtdParser), Member = "ScanElement3", ReturnType = typeof(Token))]
	[CalledBy(Type = typeof(DtdParser), Member = "ScanAttlist1", ReturnType = typeof(Token))]
	[CalledBy(Type = typeof(DtdParser), Member = "ScanEntityName", ReturnType = typeof(XmlQualifiedName))]
	[CalledBy(Type = typeof(DtdParser), Member = "ScanEntity1", ReturnType = typeof(Token))]
	[CalledBy(Type = typeof(DtdParser), Member = "ScanName", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DtdParser), Member = "ScanQName", ReturnType = typeof(void))]
	[CallerCount(Count = 13)]
	[Calls(Type = typeof(XmlException), Member = "BuildCharExceptionArgs", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(String[]))]
	[Calls(Type = typeof(DtdParser), Member = "Throw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string), typeof(String[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DtdParser), Member = "ReadData", ReturnType = typeof(int))]
	[Calls(Type = typeof(DtdParser), Member = "Throw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlException), Member = "BuildCharExceptionArgs", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(char)}, ReturnType = typeof(String[]))]
	[CallsUnknownMethods(Count = 2)]
	private void ScanQName(bool isQName) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DtdParser), Member = "ScanQName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	private void ScanQName() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DtdParser), Member = "ScanQName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	private Token ScanQNameExpected() { }

	[CalledBy(Type = typeof(DtdParser), Member = "GetToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(Token))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DtdParser), Member = "Throw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DtdParser), Member = "SaveParsingBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DtdParser), Member = "LoadParsingBuffer", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	private Token ScanSubsetContent() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DtdParser), Member = "ThrowUnexpectedToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DtdParser), Member = "ScanLiteral", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LiteralType)}, ReturnType = typeof(Token))]
	[CallsUnknownMethods(Count = 2)]
	private Token ScanSystemId() { }

	[CalledBy(Type = typeof(DtdParser), Member = "ParseAttlistType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SchemaAttDef), typeof(SchemaElementDecl), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DtdParser), Member = "ParseElementMixedContent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParticleContentValidator), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DtdParser), Member = "ParseComment", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(DtdParser), Member = "get_BaseUriStr", ReturnType = typeof(string))]
	[Calls(Type = typeof(XmlSchemaException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[ContainsInvalidInstructions]
	private void SendValidationEvent(XmlSeverityType severity, string code, string arg) { }

	[CalledBy(Type = typeof(DtdParser), Member = "ParseSubset", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DtdParser), Member = "ParseAttlistType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SchemaAttDef), typeof(SchemaElementDecl), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DtdParser), Member = "ParseAttlistDefault", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SchemaAttDef), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DtdParser), Member = "ParseElementDecl", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DtdParser), Member = "ParseElementOnlyContent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParticleContentValidator), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DtdParser), Member = "ParseElementMixedContent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParticleContentValidator), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DtdParser), Member = "ParseNotationDecl", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DtdParser), Member = "ParseCondSection", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DtdParser), Member = "VerifyEntityReference", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(SchemaEntity))]
	[CallerCount(Count = 15)]
	[Calls(Type = typeof(DtdParser), Member = "get_BaseUriStr", ReturnType = typeof(string))]
	[Calls(Type = typeof(XmlSchemaException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DtdParser), Member = "SendValidationEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSeverityType), typeof(XmlSchemaException)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	private void SendValidationEvent(int pos, XmlSeverityType severity, string code, string arg) { }

	[CalledBy(Type = typeof(DtdParser), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DtdParser), Member = "ParseAttlistType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SchemaAttDef), typeof(SchemaElementDecl), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DtdParser), Member = "SendValidationEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(XmlSeverityType), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private void SendValidationEvent(XmlSeverityType severity, XmlSchemaException e) { }

	[CalledBy(Type = typeof(DtdParser), Member = "ParseAttlistDefault", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SchemaAttDef), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DtdParser), Member = "GetValueWithStrippedSpaces", ReturnType = typeof(string))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	internal static string StripSpaces(string value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DtdParser), Member = "InitializeFreeFloatingDtd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(string), typeof(string), typeof(IDtdParserAdapter)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DtdParser), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	private override IDtdInfo System.Xml.IDtdParser.ParseFreeFloatingDtd(string baseUri, string docTypeName, string publicId, string systemId, string internalSubset, IDtdParserAdapter adapter) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DtdParser), Member = "Initialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IDtdParserAdapter)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DtdParser), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	private override IDtdInfo System.Xml.IDtdParser.ParseInternalDtd(IDtdParserAdapter adapter, bool saveInternalSubset) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DtdParser), Member = "Throw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	private void Throw(int curPos, string res) { }

	[CallerCount(Count = 93)]
	[Calls(Type = typeof(Uri), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(Uri)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(int), typeof(int), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	private void Throw(int curPos, string res, string arg) { }

	[CalledBy(Type = typeof(DtdParser), Member = "ParseExternalId", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Token), typeof(Token), typeof(String&), typeof(String&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DtdParser), Member = "GetToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(Token))]
	[CalledBy(Type = typeof(DtdParser), Member = "ScanLiteral", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LiteralType)}, ReturnType = typeof(Token))]
	[CalledBy(Type = typeof(DtdParser), Member = "ScanCondSection3", ReturnType = typeof(Token))]
	[CalledBy(Type = typeof(DtdParser), Member = "ScanQName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DtdParser), Member = "ScanNmtoken", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DtdParser), Member = "ThrowInvalidChar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DtdParser), Member = "ThrowInvalidChar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DtdParser), Member = "ThrowUnexpectedToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 12)]
	[Calls(Type = typeof(Uri), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(Uri)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[]), typeof(int), typeof(int), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	private void Throw(int curPos, string res, String[] args) { }

	[CalledBy(Type = typeof(DtdParser), Member = "ParseAttlistDecl", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DtdParser), Member = "ParseExternalId", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Token), typeof(Token), typeof(String&), typeof(String&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DtdParser), Member = "ScanEntityName", ReturnType = typeof(XmlQualifiedName))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(Uri), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(Uri)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(int), typeof(int), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private void Throw(string res, string arg, int lineNo, int linePos) { }

	[CalledBy(Type = typeof(DtdParser), Member = "InitializeFreeFloatingDtd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(string), typeof(string), typeof(IDtdParserAdapter)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(XmlException), Member = "BuildCharExceptionArgs", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(String[]))]
	[Calls(Type = typeof(DtdParser), Member = "Throw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string), typeof(String[])}, ReturnType = typeof(void))]
	private void ThrowInvalidChar(int pos, string data, int invCharPos) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlException), Member = "BuildCharExceptionArgs", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(String[]))]
	[Calls(Type = typeof(DtdParser), Member = "Throw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string), typeof(String[])}, ReturnType = typeof(void))]
	private void ThrowInvalidChar(Char[] data, int length, int invCharPos) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DtdParser), Member = "ThrowUnexpectedToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	private void ThrowUnexpectedToken(int pos, string expectedToken) { }

	[CalledBy(Type = typeof(DtdParser), Member = "ParseSubset", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DtdParser), Member = "ThrowUnexpectedToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DtdParser), Member = "ScanCondSection2", ReturnType = typeof(Token))]
	[CalledBy(Type = typeof(DtdParser), Member = "ScanPublicId1", ReturnType = typeof(Token))]
	[CalledBy(Type = typeof(DtdParser), Member = "ScanSystemId", ReturnType = typeof(Token))]
	[CalledBy(Type = typeof(DtdParser), Member = "ScanEntityName", ReturnType = typeof(XmlQualifiedName))]
	[CalledBy(Type = typeof(DtdParser), Member = "ScanAttlist7", ReturnType = typeof(Token))]
	[CalledBy(Type = typeof(DtdParser), Member = "ScanAttlist4", ReturnType = typeof(Token))]
	[CalledBy(Type = typeof(DtdParser), Member = "ScanAttlist5", ReturnType = typeof(Token))]
	[CalledBy(Type = typeof(DtdParser), Member = "ScanElement6", ReturnType = typeof(Token))]
	[CalledBy(Type = typeof(DtdParser), Member = "ScanClosingTag", ReturnType = typeof(Token))]
	[CalledBy(Type = typeof(DtdParser), Member = "GetToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(Token))]
	[CalledBy(Type = typeof(DtdParser), Member = "ParseExternalId", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Token), typeof(Token), typeof(String&), typeof(String&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DtdParser), Member = "ParseEntityDecl", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DtdParser), Member = "ParseElementMixedContent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParticleContentValidator), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DtdParser), Member = "ParseElementDecl", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DtdParser), Member = "ScanAttlist3", ReturnType = typeof(Token))]
	[CallerCount(Count = 24)]
	[Calls(Type = typeof(DtdParser), Member = "Throw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string), typeof(String[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DtdParser), Member = "ParseUnexpectedToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 7)]
	private void ThrowUnexpectedToken(int pos, string expectedToken1, string expectedToken2) { }

	[CalledBy(Type = typeof(DtdParser), Member = "HandleEntityReference", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SchemaInfo), Member = "get_GeneralEntities", ReturnType = typeof(System.Collections.Generic.Dictionary`2<System.Xml.XmlQualifiedName, System.Xml.Schema.SchemaEntity>))]
	[Calls(Type = typeof(SchemaInfo), Member = "get_ParameterEntities", ReturnType = typeof(System.Collections.Generic.Dictionary`2<System.Xml.XmlQualifiedName, System.Xml.Schema.SchemaEntity>))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlQualifiedName), Member = "get_IsEmpty", ReturnType = typeof(bool))]
	[Calls(Type = typeof(DtdParser), Member = "Throw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DtdParser), Member = "SendValidationEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(XmlSeverityType), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private SchemaEntity VerifyEntityReference(XmlQualifiedName entityName, bool paramEntity, bool mustBeDeclared, bool inAttribute) { }

}

