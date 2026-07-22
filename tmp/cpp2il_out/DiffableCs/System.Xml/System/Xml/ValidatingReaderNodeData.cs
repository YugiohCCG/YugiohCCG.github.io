namespace System.Xml;

internal class ValidatingReaderNodeData
{
	private string localName; //Field offset: 0x10
	private string namespaceUri; //Field offset: 0x18
	private string prefix; //Field offset: 0x20
	private string nameWPrefix; //Field offset: 0x28
	private string rawValue; //Field offset: 0x30
	private string originalStringValue; //Field offset: 0x38
	private int depth; //Field offset: 0x40
	private AttributePSVIInfo attributePSVIInfo; //Field offset: 0x48
	private XmlNodeType nodeType; //Field offset: 0x50
	private int lineNo; //Field offset: 0x54
	private int linePos; //Field offset: 0x58

	public AttributePSVIInfo AttInfo
	{
		[CallerCount(Count = 10)]
		[DeduplicatedMethod]
		 get { } //Length: 254
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 set { } //Length: 13
	}

	public int Depth
	{
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 4
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	public int LineNumber
	{
		[CallerCount(Count = 14)]
		[DeduplicatedMethod]
		 get { } //Length: 4
	}

	public int LinePosition
	{
		[CallerCount(Count = 3)]
		[DeduplicatedMethod]
		 get { } //Length: 4
	}

	public string LocalName
	{
		[CallerCount(Count = 106)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 set { } //Length: 13
	}

	public string Namespace
	{
		[CallerCount(Count = 31)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 9)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 set { } //Length: 13
	}

	public XmlNodeType NodeType
	{
		[CallerCount(Count = 7)]
		[DeduplicatedMethod]
		 get { } //Length: 4
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	public string OriginalStringValue
	{
		[CallerCount(Count = 38)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public string Prefix
	{
		[CallerCount(Count = 12)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 10)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 set { } //Length: 13
	}

	public string RawValue
	{
		[CallerCount(Count = 62)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 set { } //Length: 13
	}

	[CalledBy(Type = typeof(XmlSchemaValidator), Member = "GetUnspecifiedDefaultAttributes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ArrayList), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ValidatingReaderNodeData), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNodeType)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	public ValidatingReaderNodeData() { }

	[CalledBy(Type = typeof(XsdCachingReader), Member = "ReadAttributeValue", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XsdCachingReader), Member = "AddAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(ValidatingReaderNodeData))]
	[CalledBy(Type = typeof(XsdCachingReader), Member = "AddContent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNodeType)}, ReturnType = typeof(ValidatingReaderNodeData))]
	[CalledBy(Type = typeof(XsdCachingReader), Member = "RecordAttributes", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XsdCachingReader), Member = "CreateDummyTextNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(ValidatingReaderNodeData))]
	[CalledBy(Type = typeof(XsdValidatingReader), Member = "ReadAttributeValue", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XsdValidatingReader), Member = "CreateDummyTextNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(ValidatingReaderNodeData))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(ValidatingReaderNodeData), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNodeType)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	public ValidatingReaderNodeData(XmlNodeType nodeType) { }

	[CalledBy(Type = typeof(ValidatingReaderNodeData), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ValidatingReaderNodeData), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNodeType)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XsdCachingReader), Member = "AddAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(ValidatingReaderNodeData))]
	[CalledBy(Type = typeof(XsdCachingReader), Member = "AddContent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNodeType)}, ReturnType = typeof(ValidatingReaderNodeData))]
	[CalledBy(Type = typeof(XsdCachingReader), Member = "RecordAttributes", ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(AttributePSVIInfo), Member = "Reset", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	internal void Clear(XmlNodeType nodeType) { }

	[CallerCount(Count = 10)]
	[DeduplicatedMethod]
	public AttributePSVIInfo get_AttInfo() { }

	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	public int get_Depth() { }

	[CallerCount(Count = 14)]
	[DeduplicatedMethod]
	public int get_LineNumber() { }

	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	public int get_LinePosition() { }

	[CallerCount(Count = 106)]
	[DeduplicatedMethod]
	public string get_LocalName() { }

	[CallerCount(Count = 31)]
	[DeduplicatedMethod]
	public string get_Namespace() { }

	[CallerCount(Count = 7)]
	[DeduplicatedMethod]
	public XmlNodeType get_NodeType() { }

	[CallerCount(Count = 38)]
	[DeduplicatedMethod]
	public string get_OriginalStringValue() { }

	[CallerCount(Count = 12)]
	[DeduplicatedMethod]
	public string get_Prefix() { }

	[CallerCount(Count = 62)]
	[DeduplicatedMethod]
	public string get_RawValue() { }

	[CalledBy(Type = typeof(XsdCachingReader), Member = "get_Name", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(XsdCachingReader), Member = "GetAttributeIndexWithPrefix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public string GetAtomizedNameWPrefix(XmlNameTable nameTable) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public void set_AttInfo(AttributePSVIInfo value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void set_Depth(int value) { }

	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public void set_LocalName(string value) { }

	[CallerCount(Count = 9)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public void set_Namespace(string value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void set_NodeType(XmlNodeType value) { }

	[CallerCount(Count = 10)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public void set_Prefix(string value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public void set_RawValue(string value) { }

	[CalledBy(Type = typeof(XsdCachingReader), Member = "Init", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XsdCachingReader), Member = "RecordEndElementNode", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XsdCachingReader), Member = "RecordAttributes", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XsdValidatingReader), Member = "ProcessEndElementEvent", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[CallsUnknownMethods(Count = 4)]
	internal void SetItemData(string localName, string prefix, string ns, int depth) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	internal void SetItemData(string value) { }

	[CalledBy(Type = typeof(XsdCachingReader), Member = "RecordTextNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(ValidatingReaderNodeData))]
	[CalledBy(Type = typeof(XsdCachingReader), Member = "SwitchTextNodeAndEndElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XsdValidatingReader), Member = "ProcessEndElementEvent", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	internal void SetItemData(string value, string originalStringValue) { }

	[CalledBy(Type = typeof(XsdCachingReader), Member = "RecordTextNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(ValidatingReaderNodeData))]
	[CalledBy(Type = typeof(XsdCachingReader), Member = "SwitchTextNodeAndEndElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XsdValidatingReader), Member = "ProcessEndElementEvent", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	internal void SetLineInfo(int lineNo, int linePos) { }

	[CalledBy(Type = typeof(XsdCachingReader), Member = "Init", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XsdCachingReader), Member = "RecordEndElementNode", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XsdCachingReader), Member = "RecordAttributes", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XsdValidatingReader), Member = "ProcessEndElementEvent", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[CallsUnknownMethods(Count = 2)]
	internal void SetLineInfo(IXmlLineInfo lineInfo) { }

}

