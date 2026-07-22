namespace System.Xml;

public class XmlNodeReader : XmlReader, IXmlNamespaceResolver
{
	private XmlNodeReaderNavigator readerNav; //Field offset: 0x10
	private XmlNodeType nodeType; //Field offset: 0x18
	private int curDepth; //Field offset: 0x1C
	private ReadState readState; //Field offset: 0x20
	private bool fEOF; //Field offset: 0x24
	private bool bResolveEntity; //Field offset: 0x25
	private bool bStartFromDocument; //Field offset: 0x26
	private bool bInReadBinary; //Field offset: 0x27
	private ReadContentAsBinaryHelper readBinaryHelper; //Field offset: 0x28

	public virtual int AttributeCount
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(XmlNodeReaderNavigator), Member = "get_AttributeCount", ReturnType = typeof(int))]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 48
	}

	public virtual string BaseURI
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 48
	}

	public virtual bool CanResolveEntity
	{
		[CallerCount(Count = 23)]
		[DeduplicatedMethod]
		 get { } //Length: 3
	}

	public virtual int Depth
	{
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 4
	}

	internal virtual IDtdInfo DtdInfo
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		internal get { } //Length: 36
	}

	public virtual bool EOF
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 14
	}

	public virtual bool HasAttributes
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		 get { } //Length: 30
	}

	public virtual bool IsDefault
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 2)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 209
	}

	public virtual bool IsEmptyElement
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(XmlNodeReaderNavigator), Member = "get_IsEmptyElement", ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 42
	}

	public virtual string LocalName
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[ContainsInvalidInstructions]
		 get { } //Length: 92
	}

	public virtual string Name
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(XmlNodeReaderNavigator), Member = "get_Name", ReturnType = typeof(string))]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 57
	}

	public virtual string NamespaceURI
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 76
	}

	public virtual XmlNameTable NameTable
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 27
	}

	public virtual XmlNodeType NodeType
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 13
	}

	public virtual string Prefix
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 76
	}

	public virtual ReadState ReadState
	{
		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		 get { } //Length: 4
	}

	public virtual IXmlSchemaInfo SchemaInfo
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 61
	}

	public virtual string Value
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(XmlNodeReaderNavigator), Member = "get_Value", ReturnType = typeof(string))]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 57
	}

	public virtual string XmlLang
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 76
	}

	public virtual XmlSpace XmlSpace
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 61
	}

	[CalledBy(Type = "System.Data.XmlIgnoreNamespaceReader", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlDocument), "System.String[]"}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(XmlNodeReaderNavigator), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNode)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	public XmlNodeReader(XmlNode node) { }

	[CallerCount(Count = 0)]
	public virtual void Close() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ReadContentAsBinaryHelper), Member = "Finish", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private void FinishReadBinary() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlNodeReaderNavigator), Member = "get_AttributeCount", ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 1)]
	public virtual int get_AttributeCount() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public virtual string get_BaseURI() { }

	[CallerCount(Count = 23)]
	[DeduplicatedMethod]
	public virtual bool get_CanResolveEntity() { }

	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	public virtual int get_Depth() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	internal virtual IDtdInfo get_DtdInfo() { }

	[CallerCount(Count = 0)]
	public virtual bool get_EOF() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public virtual bool get_HasAttributes() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	public virtual bool get_IsDefault() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlNodeReaderNavigator), Member = "get_IsEmptyElement", ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	public virtual bool get_IsEmptyElement() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsInvalidInstructions]
	public virtual string get_LocalName() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlNodeReaderNavigator), Member = "get_Name", ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 1)]
	public virtual string get_Name() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public virtual string get_NamespaceURI() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public virtual XmlNameTable get_NameTable() { }

	[CallerCount(Count = 0)]
	public virtual XmlNodeType get_NodeType() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public virtual string get_Prefix() { }

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public virtual ReadState get_ReadState() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public virtual IXmlSchemaInfo get_SchemaInfo() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlNodeReaderNavigator), Member = "get_Value", ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 1)]
	public virtual string get_Value() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public virtual string get_XmlLang() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public virtual XmlSpace get_XmlSpace() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlNodeReaderNavigator), Member = "GetAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 1)]
	public virtual string GetAttribute(string name, string namespaceURI) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlNodeReaderNavigator), Member = "GetAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 1)]
	public virtual string GetAttribute(string name) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlNodeReaderNavigator), Member = "GetAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	public virtual string GetAttribute(int attributeIndex) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	internal bool IsInReadingStates() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlNodeReaderNavigator), Member = "LookupNamespace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 1)]
	public virtual string LookupNamespace(string prefix) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlNodeReaderNavigator), Member = "ResetMove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&), typeof(XmlNodeType&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlNodeReaderNavigator), Member = "MoveToAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ReadContentAsBinaryHelper), Member = "Finish", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	public virtual bool MoveToAttribute(string name) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlNodeReaderNavigator), Member = "ResetMove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&), typeof(XmlNodeType&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlNodeReaderNavigator), Member = "MoveToAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ReadContentAsBinaryHelper), Member = "Finish", ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlNodeReaderNavigator), Member = "RollBackMove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 14)]
	[ContainsUnimplementedInstructions]
	public virtual void MoveToAttribute(int attributeIndex) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlNodeReaderNavigator), Member = "ResetToAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ReadContentAsBinaryHelper), Member = "Finish", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	[ContainsUnimplementedInstructions]
	public virtual bool MoveToElement() { }

	[CalledBy(Type = "System.Data.XmlIgnoreNamespaceReader", Member = "MoveToFirstAttribute", ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(XmlNodeReaderNavigator), Member = "ResetMove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&), typeof(XmlNodeType&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlNodeReaderNavigator), Member = "MoveToAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ReadContentAsBinaryHelper), Member = "Finish", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	public virtual bool MoveToFirstAttribute() { }

	[CalledBy(Type = "System.Data.XmlIgnoreNamespaceReader", Member = "MoveToNextAttribute", ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(XmlNodeReaderNavigator), Member = "ResetToAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlNodeReaderNavigator), Member = "MoveToNextAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ReadContentAsBinaryHelper), Member = "Finish", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	public virtual bool MoveToNextAttribute() { }

	[CalledBy(Type = typeof(XmlNodeReader), Member = "Read", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XmlNodeReader), Member = "Skip", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ReadContentAsBinaryHelper), Member = "Finish", ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlNodeReaderNavigator), Member = "ResetMove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&), typeof(XmlNodeType&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlNodeReader), Member = "ReadNextNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private bool Read(bool fSkipChildren) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlNodeReader), Member = "Read", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(bool))]
	public virtual bool Read() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlNodeReaderNavigator), Member = "ReadAttributeValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&), typeof(Boolean&), typeof(XmlNodeType&)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	public virtual bool ReadAttributeValue() { }

	[CalledBy(Type = typeof(XmlNodeReader), Member = "ReadForward", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(XmlNodeReaderNavigator), Member = "get_IsEmptyElement", ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private bool ReadAtZeroLevel(bool fSkipChildren) { }

	[CalledBy(Type = typeof(XmlNodeReader), Member = "ReadNextNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(XmlNodeReader), Member = "ReadAtZeroLevel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlNodeReaderNavigator), Member = "get_NodeType", ReturnType = typeof(XmlNodeType))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	private bool ReadForward(bool fSkipChildren) { }

	[CalledBy(Type = typeof(XmlNodeReader), Member = "Read", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(XmlNodeReaderNavigator), Member = "get_NodeType", ReturnType = typeof(XmlNodeType))]
	[Calls(Type = typeof(XmlNodeReaderNavigator), Member = "get_IsEmptyElement", ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlNodeReaderNavigator), Member = "MoveToFirstChild", ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlNodeReader), Member = "ReadForward", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	private bool ReadNextNode(bool fSkipChildren) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlReader), Member = "ReadString", ReturnType = typeof(string))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	public virtual string ReadString() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlNodeReaderNavigator), Member = "ResetMove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&), typeof(XmlNodeType&)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private void ReSetReadingMarks() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public virtual void ResolveEntity() { }

	[CallerCount(Count = 0)]
	private void SetEndOfFile() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlNodeReader), Member = "Read", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(bool))]
	public virtual void Skip() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlNodeReaderNavigator), Member = "GetNamespacesInScope", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNamespaceScope)}, ReturnType = typeof(System.Collections.Generic.IDictionary`2<System.String, System.String>))]
	[CallsUnknownMethods(Count = 1)]
	private override IDictionary<String, String> System.Xml.IXmlNamespaceResolver.GetNamespacesInScope(XmlNamespaceScope scope) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlNodeReaderNavigator), Member = "LookupNamespace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 1)]
	private override string System.Xml.IXmlNamespaceResolver.LookupNamespace(string prefix) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlNodeReaderNavigator), Member = "LookupPrefix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 1)]
	private override string System.Xml.IXmlNamespaceResolver.LookupPrefix(string namespaceName) { }

}

