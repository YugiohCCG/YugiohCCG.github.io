namespace System.Xml;

[DefaultMember("Item")]
internal class XsdCachingReader : XmlReader, IXmlLineInfo
{
	private enum CachingReaderState
	{
		None = 0,
		Init = 1,
		Record = 2,
		Replay = 3,
		ReaderClosed = 4,
		Error = 5,
	}

	private XmlReader coreReader; //Field offset: 0x10
	private XmlNameTable coreReaderNameTable; //Field offset: 0x18
	private ValidatingReaderNodeData[] contentEvents; //Field offset: 0x20
	private ValidatingReaderNodeData[] attributeEvents; //Field offset: 0x28
	private ValidatingReaderNodeData cachedNode; //Field offset: 0x30
	private CachingReaderState cacheState; //Field offset: 0x38
	private int contentIndex; //Field offset: 0x3C
	private int attributeCount; //Field offset: 0x40
	private bool returnOriginalStringValues; //Field offset: 0x44
	private CachingEventHandler cacheHandler; //Field offset: 0x48
	private int currentAttrIndex; //Field offset: 0x50
	private int currentContentIndex; //Field offset: 0x54
	private bool readAhead; //Field offset: 0x58
	private IXmlLineInfo lineInfo; //Field offset: 0x60
	private ValidatingReaderNodeData textNode; //Field offset: 0x68

	public virtual int AttributeCount
	{
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 4
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
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 26
	}

	public virtual bool EOF
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 52
	}

	public virtual bool IsDefault
	{
		[CallerCount(Count = 271)]
		[DeduplicatedMethod]
		 get { } //Length: 3
	}

	public virtual bool IsEmptyElement
	{
		[CallerCount(Count = 271)]
		[DeduplicatedMethod]
		 get { } //Length: 3
	}

	public virtual string LocalName
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 27
	}

	public virtual string Name
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ValidatingReaderNodeData), Member = "GetAtomizedNameWPrefix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNameTable)}, ReturnType = typeof(string))]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 37
	}

	public virtual string NamespaceURI
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 27
	}

	public virtual XmlNameTable NameTable
	{
		[CallerCount(Count = 31)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public virtual XmlNodeType NodeType
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 26
	}

	public virtual string Prefix
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 27
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

	public virtual XmlReaderSettings Settings
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 39
	}

	private override int System.Xml.IXmlLineInfo.LineNumber
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		private get { } //Length: 26
	}

	private override int System.Xml.IXmlLineInfo.LinePosition
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		private get { } //Length: 26
	}

	public virtual string Value
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 42
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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XsdCachingReader), Member = "Init", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	internal XsdCachingReader(XmlReader reader, IXmlLineInfo lineInfo, CachingEventHandler handlerMethod) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ValidatingReaderNodeData), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNodeType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ValidatingReaderNodeData), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNodeType)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 7)]
	private ValidatingReaderNodeData AddAttribute(int attIndex) { }

	[CalledBy(Type = typeof(XsdCachingReader), Member = "Init", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XsdCachingReader), Member = "RecordTextNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(ValidatingReaderNodeData))]
	[CalledBy(Type = typeof(XsdCachingReader), Member = "SwitchTextNodeAndEndElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XsdCachingReader), Member = "RecordEndElementNode", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XsdValidatingReader), Member = "ProcessEndElementEvent", ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ValidatingReaderNodeData), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNodeType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ValidatingReaderNodeData), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNodeType)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 7)]
	private ValidatingReaderNodeData AddContent(XmlNodeType nodeType) { }

	[CallerCount(Count = 0)]
	private void ClearAttributesInfo() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public virtual void Close() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ValidatingReaderNodeData), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNodeType)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	private ValidatingReaderNodeData CreateDummyTextNode(string attributeValue, int depth) { }

	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	public virtual int get_AttributeCount() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public virtual string get_BaseURI() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public virtual int get_Depth() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public virtual bool get_EOF() { }

	[CallerCount(Count = 271)]
	[DeduplicatedMethod]
	public virtual bool get_IsDefault() { }

	[CallerCount(Count = 271)]
	[DeduplicatedMethod]
	public virtual bool get_IsEmptyElement() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public virtual string get_LocalName() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ValidatingReaderNodeData), Member = "GetAtomizedNameWPrefix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNameTable)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 1)]
	public virtual string get_Name() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public virtual string get_NamespaceURI() { }

	[CallerCount(Count = 31)]
	[DeduplicatedMethod]
	public virtual XmlNameTable get_NameTable() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public virtual XmlNodeType get_NodeType() { }

	[CallerCount(Count = 0)]
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
	[DeduplicatedMethod]
	public virtual ReadState get_ReadState() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public virtual XmlReaderSettings get_Settings() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
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
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 6)]
	public virtual string GetAttribute(int i) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 2)]
	public virtual string GetAttribute(string name, string namespaceURI) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(XsdCachingReader), Member = "GetAttributeIndexWithPrefix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(XsdCachingReader), Member = "GetAttributeIndexWithoutPrefix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 2)]
	public virtual string GetAttribute(string name) { }

	[CalledBy(Type = typeof(XsdCachingReader), Member = "GetAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(XsdCachingReader), Member = "MoveToAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	private int GetAttributeIndexWithoutPrefix(string name) { }

	[CalledBy(Type = typeof(XsdCachingReader), Member = "GetAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(XsdCachingReader), Member = "MoveToAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ValidatingReaderNodeData), Member = "GetAtomizedNameWPrefix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNameTable)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	private int GetAttributeIndexWithPrefix(string name) { }

	[CallerCount(Count = 106)]
	[DeduplicatedMethod]
	internal XmlReader GetCoreReader() { }

	[CallerCount(Count = 84)]
	[DeduplicatedMethod]
	internal IXmlLineInfo GetLineInfo() { }

	[CalledBy(Type = typeof(XsdCachingReader), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlReader), typeof(IXmlLineInfo), typeof(CachingEventHandler)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XsdCachingReader), Member = "Reset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlReader)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XsdValidatingReader), Member = "GetCachingReader", ReturnType = typeof(XsdCachingReader))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(XsdCachingReader), Member = "AddContent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNodeType)}, ReturnType = typeof(ValidatingReaderNodeData))]
	[Calls(Type = typeof(ValidatingReaderNodeData), Member = "SetItemData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ValidatingReaderNodeData), Member = "SetLineInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IXmlLineInfo)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XsdCachingReader), Member = "RecordAttributes", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 3)]
	private void Init() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public virtual string LookupNamespace(string prefix) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 7)]
	public virtual void MoveToAttribute(int i) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(XsdCachingReader), Member = "GetAttributeIndexWithPrefix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(XsdCachingReader), Member = "GetAttributeIndexWithoutPrefix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 3)]
	public virtual bool MoveToAttribute(string name) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public virtual bool MoveToElement() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 3)]
	public virtual bool MoveToFirstAttribute() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 3)]
	public virtual bool MoveToNextAttribute() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsInvalidInstructions]
	public virtual bool Read() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ValidatingReaderNodeData), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNodeType)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	public virtual bool ReadAttributeValue() { }

	[CalledBy(Type = typeof(XsdCachingReader), Member = "Init", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ValidatingReaderNodeData), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNodeType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ValidatingReaderNodeData), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNodeType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ValidatingReaderNodeData), Member = "SetItemData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ValidatingReaderNodeData), Member = "SetLineInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IXmlLineInfo)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallsUnknownMethods(Count = 8)]
	private void RecordAttributes() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XsdCachingReader), Member = "AddContent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNodeType)}, ReturnType = typeof(ValidatingReaderNodeData))]
	[Calls(Type = typeof(ValidatingReaderNodeData), Member = "SetItemData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ValidatingReaderNodeData), Member = "SetLineInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IXmlLineInfo)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 2)]
	internal void RecordEndElementNode() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XsdCachingReader), Member = "AddContent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNodeType)}, ReturnType = typeof(ValidatingReaderNodeData))]
	[Calls(Type = typeof(ValidatingReaderNodeData), Member = "SetItemData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ValidatingReaderNodeData), Member = "SetLineInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	internal ValidatingReaderNodeData RecordTextNode(string textValue, string originalStringValue, int depth, int lineNo, int linePos) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XsdCachingReader), Member = "Init", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	internal void Reset(XmlReader reader) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public virtual void ResolveEntity() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	internal void SetToReplayMode() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 1)]
	public virtual void Skip() { }

	[CalledBy(Type = typeof(XsdValidatingReader), Member = "ReadAheadForMemberType", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XsdValidatingReader), Member = "GetIsDefault", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(XsdCachingReader), Member = "AddContent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNodeType)}, ReturnType = typeof(ValidatingReaderNodeData))]
	[Calls(Type = typeof(ValidatingReaderNodeData), Member = "SetItemData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ValidatingReaderNodeData), Member = "SetLineInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 10)]
	internal void SwitchTextNodeAndEndElement(string textValue, string originalStringValue) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private override int System.Xml.IXmlLineInfo.get_LineNumber() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private override int System.Xml.IXmlLineInfo.get_LinePosition() { }

	[CallerCount(Count = 23)]
	[DeduplicatedMethod]
	private override bool System.Xml.IXmlLineInfo.HasLineInfo() { }

}

