namespace System.Xml;

internal class XsdValidatingReader : XmlReader, IXmlSchemaInfo, IXmlLineInfo, IXmlNamespaceResolver
{
	private enum ValidatingReaderState
	{
		None = 0,
		Init = 1,
		Read = 2,
		OnDefaultAttribute = -1,
		OnReadAttributeValue = -2,
		OnAttribute = 3,
		ClearAttributes = 4,
		ParseInlineSchema = 5,
		ReadAhead = 6,
		OnReadBinaryContent = 7,
		ReaderClosed = 8,
		EOF = 9,
		Error = 10,
	}

	private static Type TypeOfString; //Field offset: 0x0
	private XmlReader coreReader; //Field offset: 0x10
	private IXmlNamespaceResolver coreReaderNSResolver; //Field offset: 0x18
	private IXmlNamespaceResolver thisNSResolver; //Field offset: 0x20
	private XmlSchemaValidator validator; //Field offset: 0x28
	private XmlResolver xmlResolver; //Field offset: 0x30
	private ValidationEventHandler validationEvent; //Field offset: 0x38
	private ValidatingReaderState validationState; //Field offset: 0x40
	private XmlValueGetter valueGetter; //Field offset: 0x48
	private XmlNamespaceManager nsManager; //Field offset: 0x50
	private bool manageNamespaces; //Field offset: 0x58
	private bool processInlineSchema; //Field offset: 0x59
	private bool replayCache; //Field offset: 0x5A
	private ValidatingReaderNodeData cachedNode; //Field offset: 0x60
	private AttributePSVIInfo attributePSVI; //Field offset: 0x68
	private int attributeCount; //Field offset: 0x70
	private int coreReaderAttributeCount; //Field offset: 0x74
	private int currentAttrIndex; //Field offset: 0x78
	private AttributePSVIInfo[] attributePSVINodes; //Field offset: 0x80
	private ArrayList defaultAttributes; //Field offset: 0x88
	private Parser inlineSchemaParser; //Field offset: 0x90
	private object atomicValue; //Field offset: 0x98
	private XmlSchemaInfo xmlSchemaInfo; //Field offset: 0xA0
	private string originalAtomicValueString; //Field offset: 0xA8
	private XmlNameTable coreReaderNameTable; //Field offset: 0xB0
	private XsdCachingReader cachingReader; //Field offset: 0xB8
	private ValidatingReaderNodeData textNode; //Field offset: 0xC0
	private string NsXmlNs; //Field offset: 0xC8
	private string NsXs; //Field offset: 0xD0
	private string NsXsi; //Field offset: 0xD8
	private string XsiType; //Field offset: 0xE0
	private string XsiNil; //Field offset: 0xE8
	private string XsdSchema; //Field offset: 0xF0
	private string XsiSchemaLocation; //Field offset: 0xF8
	private string XsiNoNamespaceSchemaLocation; //Field offset: 0x100
	private XmlCharType xmlCharType; //Field offset: 0x108
	private IXmlLineInfo lineInfo; //Field offset: 0x110
	private ReadContentAsBinaryHelper readBinaryHelper; //Field offset: 0x118
	private ValidatingReaderState savedState; //Field offset: 0x120

	public virtual int AttributeCount
	{
		[CallerCount(Count = 3)]
		[DeduplicatedMethod]
		 get { } //Length: 4
	}

	private XmlSchemaInfo AttributeSchemaInfo
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		private get { } //Length: 27
	}

	public virtual string BaseURI
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 39
	}

	public virtual int Depth
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 62
	}

	public virtual bool EOF
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 39
	}

	public virtual bool IsDefault
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 52
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
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 84
	}

	public override int LinePosition
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 84
	}

	public virtual string LocalName
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 63
	}

	public virtual string Name
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(XmlSchemaValidator), Member = "GetDefaultAttributePrefix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[])}, ReturnType = typeof(string))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 3)]
		 get { } //Length: 305
	}

	public virtual string NamespaceURI
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 63
	}

	public virtual XmlNameTable NameTable
	{
		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		 get { } //Length: 8
	}

	public virtual XmlNodeType NodeType
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(XmlSchemaValidator), Member = "get_CurrentContentType", ReturnType = typeof(XmlSchemaContentType))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 155
	}

	public virtual string Prefix
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 63
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
		 get { } //Length: 52
	}

	public virtual IXmlSchemaInfo SchemaInfo
	{
		[CallerCount(Count = 2063)]
		[DeduplicatedMethod]
		 get { } //Length: 4
	}

	public virtual XmlReaderSettings Settings
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(XmlReaderSettings), Member = "Clone", ReturnType = typeof(XmlReaderSettings))]
		[Calls(Type = typeof(XmlReaderSettings), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(XmlReaderSettings), Member = "set_Schemas", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaSet)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(XmlReaderSettings), Member = "set_ValidationType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ValidationType)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(XmlReaderSettings), Member = "set_ValidationFlags", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaValidationFlags)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 210
	}

	private override bool System.Xml.Schema.IXmlSchemaInfo.IsDefault
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(XsdValidatingReader), Member = "GetIsDefault", ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		private get { } //Length: 131
	}

	private override bool System.Xml.Schema.IXmlSchemaInfo.IsNil
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		private get { } //Length: 70
	}

	private override XmlSchemaSimpleType System.Xml.Schema.IXmlSchemaInfo.MemberType
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(XmlSchemaInfo), Member = "get_IsUnionType", ReturnType = typeof(bool))]
		[Calls(Type = typeof(XsdValidatingReader), Member = "GetCachingReader", ReturnType = typeof(XsdCachingReader))]
		[Calls(Type = typeof(XsdValidatingReader), Member = "ReadAheadForMemberType", ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 2)]
		private get { } //Length: 424
	}

	private override XmlSchemaAttribute System.Xml.Schema.IXmlSchemaInfo.SchemaAttribute
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		private get { } //Length: 73
	}

	private override XmlSchemaElement System.Xml.Schema.IXmlSchemaInfo.SchemaElement
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		private get { } //Length: 89
	}

	private override XmlSchemaType System.Xml.Schema.IXmlSchemaInfo.SchemaType
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		private get { } //Length: 92
	}

	private override XmlSchemaValidity System.Xml.Schema.IXmlSchemaInfo.Validity
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		private get { } //Length: 155
	}

	public virtual string Value
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 63
	}

	public virtual Type ValueType
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 2)]
		 get { } //Length: 202
	}

	public virtual string XmlLang
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 39
	}

	public virtual XmlSpace XmlSpace
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 39
	}

	[CalledBy(Type = typeof(XsdValidatingReader), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlReader), typeof(XmlResolver), typeof(XmlReaderSettings)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(XmlCharType), Member = "get_Instance", ReturnType = typeof(XmlCharType))]
	[Calls(Type = typeof(XmlNamespaceManager), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNameTable)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XsdValidatingReader), Member = "Init", ReturnType = typeof(void))]
	[Calls(Type = typeof(XsdValidatingReader), Member = "SetupValidator", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlReaderSettings), typeof(XmlReader), typeof(XmlSchemaObject)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 14)]
	[ContainsUnimplementedInstructions]
	internal XsdValidatingReader(XmlReader reader, XmlResolver xmlResolver, XmlReaderSettings readerSettings, XmlSchemaObject partialValidationType) { }

	[CalledBy(Type = typeof(XmlReaderSettings), Member = "AddValidation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlReader)}, ReturnType = typeof(XmlReader))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(XsdValidatingReader), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlReader), typeof(XmlResolver), typeof(XmlReaderSettings), typeof(XmlSchemaObject)}, ReturnType = typeof(void))]
	internal XsdValidatingReader(XmlReader reader, XmlResolver xmlResolver, XmlReaderSettings readerSettings) { }

	[CalledBy(Type = typeof(XsdValidatingReader), Member = "ValidateAttributes", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSchemaInfo), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSchemaInfo), Member = "Clear", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 11)]
	private AttributePSVIInfo AddAttributePSVI(int attIndex) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 3)]
	internal void CachingCallBack(XsdCachingReader cachingReader) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void ClearAttributesInfo() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public virtual void Close() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ValidatingReaderNodeData), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNodeType)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	internal ValidatingReaderNodeData CreateDummyTextNode(string attributeValue, int depth) { }

	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	public virtual int get_AttributeCount() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private XmlSchemaInfo get_AttributeSchemaInfo() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public virtual string get_BaseURI() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public virtual int get_Depth() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public virtual bool get_EOF() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public virtual bool get_IsDefault() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public virtual bool get_IsEmptyElement() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public override int get_LineNumber() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public override int get_LinePosition() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public virtual string get_LocalName() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlSchemaValidator), Member = "GetDefaultAttributePrefix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[])}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public virtual string get_Name() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public virtual string get_NamespaceURI() { }

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public virtual XmlNameTable get_NameTable() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlSchemaValidator), Member = "get_CurrentContentType", ReturnType = typeof(XmlSchemaContentType))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public virtual XmlNodeType get_NodeType() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public virtual string get_Prefix() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public virtual char get_QuoteChar() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public virtual ReadState get_ReadState() { }

	[CallerCount(Count = 2063)]
	[DeduplicatedMethod]
	public virtual IXmlSchemaInfo get_SchemaInfo() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlReaderSettings), Member = "Clone", ReturnType = typeof(XmlReaderSettings))]
	[Calls(Type = typeof(XmlReaderSettings), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlReaderSettings), Member = "set_Schemas", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaSet)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlReaderSettings), Member = "set_ValidationType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ValidationType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlReaderSettings), Member = "set_ValidationFlags", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaValidationFlags)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public virtual XmlReaderSettings get_Settings() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public virtual string get_Value() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public virtual Type get_ValueType() { }

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
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public virtual string GetAttribute(int i) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XsdValidatingReader), Member = "GetDefaultAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(bool)}, ReturnType = typeof(ValidatingReaderNodeData))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	public virtual string GetAttribute(string name, string namespaceURI) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XsdValidatingReader), Member = "GetDefaultAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(ValidatingReaderNodeData))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public virtual string GetAttribute(string name) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	private AttributePSVIInfo GetAttributePSVI(string localName, string ns) { }

	[CalledBy(Type = typeof(XsdValidatingReader), Member = "MoveToAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ValidateNames), Member = "SplitQName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String&), typeof(String&)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 3)]
	private AttributePSVIInfo GetAttributePSVI(string name) { }

	[CalledBy(Type = typeof(XsdValidatingReader), Member = "System.Xml.Schema.IXmlSchemaInfo.get_MemberType", ReturnType = typeof(XmlSchemaSimpleType))]
	[CalledBy(Type = typeof(XsdValidatingReader), Member = "ProcessEndElementEvent", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XsdValidatingReader), Member = "GetIsDefault", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XsdValidatingReader), Member = "GetMemberType", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(XsdCachingReader), Member = "Init", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 13)]
	private XsdCachingReader GetCachingReader() { }

	[CalledBy(Type = typeof(XsdValidatingReader), Member = "GetAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(XsdValidatingReader), Member = "MoveToAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ValidateNames), Member = "SplitQName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String&), typeof(String&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XsdValidatingReader), Member = "GetDefaultAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(bool)}, ReturnType = typeof(ValidatingReaderNodeData))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	private ValidatingReaderNodeData GetDefaultAttribute(string name, bool updatePosition) { }

	[CalledBy(Type = typeof(XsdValidatingReader), Member = "GetAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(XsdValidatingReader), Member = "GetDefaultAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(ValidatingReaderNodeData))]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 2)]
	private ValidatingReaderNodeData GetDefaultAttribute(string attrLocalName, string ns, bool updatePosition) { }

	[CalledBy(Type = typeof(XsdValidatingReader), Member = "System.Xml.Schema.IXmlSchemaInfo.get_IsDefault", ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(XmlSchemaInfo), Member = "get_HasDefaultValue", ReturnType = typeof(bool))]
	[Calls(Type = typeof(XsdValidatingReader), Member = "GetCachingReader", ReturnType = typeof(XsdCachingReader))]
	[Calls(Type = typeof(XmlSchemaInfo), Member = "get_IsUnionType", ReturnType = typeof(bool))]
	[Calls(Type = typeof(XsdValidatingReader), Member = "ReadAheadForMemberType", ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSchemaValidator), Member = "ValidateText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlValueGetter)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSchemaValidator), Member = "ValidateWhitespace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlValueGetter)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSchemaValidator), Member = "ValidateEndElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaInfo)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(XsdValidatingReader), Member = "GetOriginalAtomicValueStringOfElement", ReturnType = typeof(string))]
	[Calls(Type = typeof(XmlSchemaInfo), Member = "get_XmlType", ReturnType = typeof(XmlSchemaType))]
	[Calls(Type = typeof(XmlSchemaType), Member = "get_ValueConverter", ReturnType = typeof(XmlValueConverter))]
	[Calls(Type = typeof(XsdCachingReader), Member = "SwitchTextNodeAndEndElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 5)]
	private void GetIsDefault() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlSchemaInfo), Member = "get_IsUnionType", ReturnType = typeof(bool))]
	[Calls(Type = typeof(XsdValidatingReader), Member = "GetCachingReader", ReturnType = typeof(XsdCachingReader))]
	[Calls(Type = typeof(XsdValidatingReader), Member = "ReadAheadForMemberType", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void GetMemberType() { }

	[CalledBy(Type = typeof(XsdValidatingReader), Member = "ProcessEndElementEvent", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XsdValidatingReader), Member = "ReadAheadForMemberType", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XsdValidatingReader), Member = "GetIsDefault", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(XmlSchemaValidator), Member = "GetConcatenatedValue", ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 1)]
	private string GetOriginalAtomicValueStringOfElement() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	private object GetStringValue() { }

	[CallerCount(Count = 23)]
	[DeduplicatedMethod]
	public override bool HasLineInfo() { }

	[CalledBy(Type = typeof(XsdValidatingReader), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlReader), typeof(XmlResolver), typeof(XmlReaderSettings), typeof(XmlSchemaObject)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ArrayList), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(XmlSchemaInfo), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallsUnknownMethods(Count = 15)]
	private void Init() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	private bool IsXSDRoot(string localName, string ns) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public virtual string LookupNamespace(string prefix) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XsdValidatingReader), Member = "GetDefaultAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(ValidatingReaderNodeData))]
	[Calls(Type = typeof(XsdValidatingReader), Member = "GetAttributePSVI", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(AttributePSVIInfo))]
	[Calls(Type = typeof(ReadContentAsBinaryHelper), Member = "Finish", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public virtual bool MoveToAttribute(string name) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ReadContentAsBinaryHelper), Member = "Finish", ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 10)]
	public virtual void MoveToAttribute(int i) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public virtual bool MoveToElement() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ReadContentAsBinaryHelper), Member = "Finish", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 7)]
	public virtual bool MoveToFirstAttribute() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ReadContentAsBinaryHelper), Member = "Finish", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 6)]
	public virtual bool MoveToNextAttribute() { }

	[CalledBy(Type = typeof(XsdValidatingReader), Member = "ProcessReaderEvent", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(XmlSchemaInfo), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSchemaSet), Member = "GetSchemaNames", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNameTable)}, ReturnType = typeof(SchemaNames))]
	[Calls(Type = typeof(Parser), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SchemaType), typeof(XmlNameTable), typeof(SchemaNames), typeof(ValidationEventHandler)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Parser), Member = "StartParsing", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlReader), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Parser), Member = "ParseReaderNode", ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlSchemaValidator), Member = "ValidateElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(XmlSchemaInfo), typeof(string), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XsdValidatingReader), Member = "ValidateAttributes", ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSchemaValidator), Member = "ValidateEndOfAttributes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaInfo)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XsdValidatingReader), Member = "ProcessEndElementEvent", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 31)]
	[CallsUnknownMethods(Count = 4)]
	private void ProcessElementEvent() { }

	[CalledBy(Type = typeof(XsdValidatingReader), Member = "ProcessReaderEvent", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XsdValidatingReader), Member = "ProcessElementEvent", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(XmlSchemaValidator), Member = "ValidateEndElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaInfo)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(XsdValidatingReader), Member = "GetOriginalAtomicValueStringOfElement", ReturnType = typeof(string))]
	[Calls(Type = typeof(XsdValidatingReader), Member = "GetCachingReader", ReturnType = typeof(XsdCachingReader))]
	[Calls(Type = typeof(XmlSchemaInfo), Member = "get_XmlType", ReturnType = typeof(XmlSchemaType))]
	[Calls(Type = typeof(XmlSchemaType), Member = "get_ValueConverter", ReturnType = typeof(XmlValueConverter))]
	[Calls(Type = typeof(XsdCachingReader), Member = "AddContent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNodeType)}, ReturnType = typeof(ValidatingReaderNodeData))]
	[Calls(Type = typeof(ValidatingReaderNodeData), Member = "SetItemData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ValidatingReaderNodeData), Member = "SetLineInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ValidatingReaderNodeData), Member = "SetItemData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ValidatingReaderNodeData), Member = "SetLineInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IXmlLineInfo)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallsUnknownMethods(Count = 5)]
	private void ProcessEndElementEvent() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Parser), Member = "ParseReaderNode", ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlSchemaValidator), Member = "AddSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchema)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 3)]
	private void ProcessInlineSchema() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XsdValidatingReader), Member = "ProcessElementEvent", ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSchemaValidator), Member = "ValidateText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlValueGetter)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSchemaValidator), Member = "SetDtdSchemaInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IDtdInfo)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSchemaValidator), Member = "ValidateWhitespace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlValueGetter)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XsdValidatingReader), Member = "ProcessEndElementEvent", ReturnType = typeof(void))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 5)]
	private void ProcessReaderEvent() { }

	[CallerCount(Count = 0)]
	[ContainsInvalidInstructions]
	public virtual bool Read() { }

	[CalledBy(Type = typeof(XsdValidatingReader), Member = "System.Xml.Schema.IXmlSchemaInfo.get_MemberType", ReturnType = typeof(XmlSchemaSimpleType))]
	[CalledBy(Type = typeof(XsdValidatingReader), Member = "GetIsDefault", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XsdValidatingReader), Member = "GetMemberType", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(XmlSchemaValidator), Member = "ValidateText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlValueGetter)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSchemaValidator), Member = "ValidateWhitespace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlValueGetter)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSchemaValidator), Member = "ValidateEndElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaInfo)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(XsdValidatingReader), Member = "GetOriginalAtomicValueStringOfElement", ReturnType = typeof(string))]
	[Calls(Type = typeof(XmlSchemaInfo), Member = "get_XmlType", ReturnType = typeof(XmlSchemaType))]
	[Calls(Type = typeof(XmlSchemaType), Member = "get_ValueConverter", ReturnType = typeof(XmlValueConverter))]
	[Calls(Type = typeof(XsdCachingReader), Member = "SwitchTextNodeAndEndElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 5)]
	private void ReadAheadForMemberType() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ReadContentAsBinaryHelper), Member = "Finish", ReturnType = typeof(void))]
	[Calls(Type = typeof(ValidatingReaderNodeData), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNodeType)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	public virtual bool ReadAttributeValue() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public virtual void ResolveEntity() { }

	[CalledBy(Type = typeof(XsdValidatingReader), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlReader), typeof(XmlResolver), typeof(XmlReaderSettings), typeof(XmlSchemaObject)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(XmlReaderSettings), Member = "get_Schemas", ReturnType = typeof(XmlSchemaSet))]
	[Calls(Type = typeof(XmlSchemaValidator), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNameTable), typeof(XmlSchemaSet), typeof(IXmlNamespaceResolver), typeof(XmlSchemaValidationFlags)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlConvert), Member = "ToUri", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Uri))]
	[Calls(Type = typeof(XmlSchemaValidator), Member = "set_SourceUri", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSchemaValidator), Member = "add_ValidationEventHandler", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ValidationEventHandler)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSchemaValidator), Member = "set_LineInfoProvider", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IXmlLineInfo)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSchemaValidator), Member = "get_ProcessSchemaHints", ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlReaderSettings), Member = "set_DtdProcessing", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DtdProcessing)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSchemaValidator), Member = "SetDtdSchemaInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IDtdInfo)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSchemaValidator), Member = "Initialize", ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSchemaValidator), Member = "Initialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaObject)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	private void SetupValidator(XmlReaderSettings readerSettings, XmlReader reader, XmlSchemaObject partialValidationType) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlSchemaInfo), Member = "get_IsUnionType", ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlSchemaValidator), Member = "SkipToEndElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaInfo)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public virtual void Skip() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	private override IDictionary<String, String> System.Xml.IXmlNamespaceResolver.GetNamespacesInScope(XmlNamespaceScope scope) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private override string System.Xml.IXmlNamespaceResolver.LookupNamespace(string prefix) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private override string System.Xml.IXmlNamespaceResolver.LookupPrefix(string namespaceName) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XsdValidatingReader), Member = "GetIsDefault", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	private override bool System.Xml.Schema.IXmlSchemaInfo.get_IsDefault() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private override bool System.Xml.Schema.IXmlSchemaInfo.get_IsNil() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlSchemaInfo), Member = "get_IsUnionType", ReturnType = typeof(bool))]
	[Calls(Type = typeof(XsdValidatingReader), Member = "GetCachingReader", ReturnType = typeof(XsdCachingReader))]
	[Calls(Type = typeof(XsdValidatingReader), Member = "ReadAheadForMemberType", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	private override XmlSchemaSimpleType System.Xml.Schema.IXmlSchemaInfo.get_MemberType() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private override XmlSchemaAttribute System.Xml.Schema.IXmlSchemaInfo.get_SchemaAttribute() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	private override XmlSchemaElement System.Xml.Schema.IXmlSchemaInfo.get_SchemaElement() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private override XmlSchemaType System.Xml.Schema.IXmlSchemaInfo.get_SchemaType() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	private override XmlSchemaValidity System.Xml.Schema.IXmlSchemaInfo.get_Validity() { }

	[CalledBy(Type = typeof(XsdValidatingReader), Member = "ProcessElementEvent", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(XsdValidatingReader), Member = "AddAttributePSVI", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(AttributePSVIInfo))]
	[Calls(Type = typeof(XmlSchemaValidator), Member = "ValidateAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(XmlValueGetter), typeof(XmlSchemaInfo)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(XmlSchemaValidator), Member = "GetUnspecifiedDefaultAttributes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ArrayList), typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 4)]
	[ContainsUnimplementedInstructions]
	private void ValidateAttributes() { }

}

