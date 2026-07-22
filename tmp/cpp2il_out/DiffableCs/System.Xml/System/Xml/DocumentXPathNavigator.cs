namespace System.Xml;

internal sealed class DocumentXPathNavigator : XPathNavigator, IHasXmlNode
{
	private XmlDocument document; //Field offset: 0x10
	private XmlNode source; //Field offset: 0x18
	private int attributeIndex; //Field offset: 0x20
	private XmlElement namespaceParent; //Field offset: 0x28

	public virtual string BaseURI
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 39
	}

	public virtual string LocalName
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 39
	}

	public virtual string Name
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 5)]
		[CallsUnknownMethods(Count = 2)]
		 get { } //Length: 362
	}

	public virtual string NamespaceURI
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 190
	}

	public virtual XmlNameTable NameTable
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 36
	}

	public virtual XPathNodeType NodeType
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(DocumentXPathNavigator), Member = "PreviousText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNode)}, ReturnType = typeof(XmlNode))]
		[Calls(Type = typeof(DocumentXPathNavigator), Member = "ResetPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNode)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 110
	}

	public virtual string Prefix
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 190
	}

	public virtual IXmlSchemaInfo SchemaInfo
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 39
	}

	public virtual object UnderlyingObject
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(DocumentXPathNavigator), Member = "PreviousText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNode)}, ReturnType = typeof(XmlNode))]
		[Calls(Type = typeof(DocumentXPathNavigator), Member = "ResetPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNode)}, ReturnType = typeof(void))]
		 get { } //Length: 84
	}

	public virtual string Value
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(XmlDocument), Member = "get_DocumentElement", ReturnType = typeof(XmlElement))]
		[Calls(Type = typeof(DocumentXPathNavigator), Member = "PreviousText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNode)}, ReturnType = typeof(XmlNode))]
		[Calls(Type = typeof(DocumentXPathNavigator), Member = "ResetPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNode)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(DocumentXPathNavigator), Member = "NextSibling", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNode)}, ReturnType = typeof(XmlNode))]
		[Calls(Type = typeof(StringBuilder), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(StringBuilder))]
		[CallsDeduplicatedMethods(Count = 8)]
		[CallsUnknownMethods(Count = 2)]
		 get { } //Length: 572
	}

	private string ValueDocument
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(XmlDocument), Member = "get_DocumentElement", ReturnType = typeof(XmlElement))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		private get { } //Length: 76
	}

	private string ValueText
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(DocumentXPathNavigator), Member = "PreviousText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNode)}, ReturnType = typeof(XmlNode))]
		[Calls(Type = typeof(DocumentXPathNavigator), Member = "ResetPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNode)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(DocumentXPathNavigator), Member = "NextSibling", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNode)}, ReturnType = typeof(XmlNode))]
		[Calls(Type = typeof(StringBuilder), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(StringBuilder))]
		[CallsDeduplicatedMethods(Count = 5)]
		[CallsUnknownMethods(Count = 1)]
		private get { } //Length: 360
	}

	public virtual string XmlLang
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 39
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DocumentXPathNavigator), Member = "ResetPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNode)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public DocumentXPathNavigator(XmlDocument document, XmlNode node) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public DocumentXPathNavigator(DocumentXPathNavigator other) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DocumentXPathNavigator), Member = "PreviousText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNode)}, ReturnType = typeof(XmlNode))]
	[Calls(Type = typeof(DocumentXPathNavigator), Member = "ResetPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNode)}, ReturnType = typeof(void))]
	private void CalibrateText() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlAttributeCollection), Member = "get_ItemOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(XmlAttribute))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	private static bool CheckAttributePosition(XmlAttribute attribute, out XmlAttributeCollection attributes, int index) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public virtual XPathNavigator Clone() { }

	[CalledBy(Type = typeof(DocumentXPathNavigator), Member = "ComparePosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XPathNavigator)}, ReturnType = typeof(XmlNodeOrder))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(XmlAttributeCollection), Member = "get_ItemOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(XmlAttribute))]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallsUnknownMethods(Count = 2)]
	private XmlNodeOrder Compare(XmlNode node1, XmlNode node2) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DocumentXPathNavigator), Member = "PreviousText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNode)}, ReturnType = typeof(XmlNode))]
	[Calls(Type = typeof(DocumentXPathNavigator), Member = "ResetPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNode)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DocumentXPathNavigator), Member = "OwnerNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNode)}, ReturnType = typeof(XmlNode))]
	[Calls(Type = typeof(DocumentXPathNavigator), Member = "GetDepth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNode)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(DocumentXPathNavigator), Member = "Compare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNode), typeof(XmlNode)}, ReturnType = typeof(XmlNodeOrder))]
	[Calls(Type = typeof(XPathNavigator), Member = "ComparePosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XPathNavigator)}, ReturnType = typeof(XmlNodeOrder))]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 1)]
	public virtual XmlNodeOrder ComparePosition(XPathNavigator other) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	private XmlNode FirstChild(XmlNode node) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	private XmlNode FirstChildTail(XmlNode child) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public virtual string get_BaseURI() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public virtual string get_LocalName() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 2)]
	public virtual string get_Name() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public virtual string get_NamespaceURI() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public virtual XmlNameTable get_NameTable() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DocumentXPathNavigator), Member = "PreviousText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNode)}, ReturnType = typeof(XmlNode))]
	[Calls(Type = typeof(DocumentXPathNavigator), Member = "ResetPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNode)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public virtual XPathNodeType get_NodeType() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public virtual string get_Prefix() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public virtual IXmlSchemaInfo get_SchemaInfo() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DocumentXPathNavigator), Member = "PreviousText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNode)}, ReturnType = typeof(XmlNode))]
	[Calls(Type = typeof(DocumentXPathNavigator), Member = "ResetPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNode)}, ReturnType = typeof(void))]
	public virtual object get_UnderlyingObject() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlDocument), Member = "get_DocumentElement", ReturnType = typeof(XmlElement))]
	[Calls(Type = typeof(DocumentXPathNavigator), Member = "PreviousText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNode)}, ReturnType = typeof(XmlNode))]
	[Calls(Type = typeof(DocumentXPathNavigator), Member = "ResetPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNode)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DocumentXPathNavigator), Member = "NextSibling", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNode)}, ReturnType = typeof(XmlNode))]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(StringBuilder))]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 2)]
	public virtual string get_Value() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlDocument), Member = "get_DocumentElement", ReturnType = typeof(XmlElement))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private string get_ValueDocument() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DocumentXPathNavigator), Member = "PreviousText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNode)}, ReturnType = typeof(XmlNode))]
	[Calls(Type = typeof(DocumentXPathNavigator), Member = "ResetPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNode)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DocumentXPathNavigator), Member = "NextSibling", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNode)}, ReturnType = typeof(XmlNode))]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(StringBuilder))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 1)]
	private string get_ValueText() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public virtual string get_XmlLang() { }

	[CalledBy(Type = typeof(DocumentXPathNavigator), Member = "ComparePosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XPathNavigator)}, ReturnType = typeof(XmlNodeOrder))]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	private static int GetDepth(XmlNode node) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public virtual bool IsDescendant(XPathNavigator other) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	private static bool IsDescendant(XmlNode top, XmlNode bottom) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DocumentXPathNavigator), Member = "PreviousText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNode)}, ReturnType = typeof(XmlNode))]
	[Calls(Type = typeof(DocumentXPathNavigator), Member = "ResetPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNode)}, ReturnType = typeof(void))]
	[ContainsUnimplementedInstructions]
	public virtual bool IsSamePosition(XPathNavigator other) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	private static bool IsValidChild(XmlNode parent, XmlNode child) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XPathNavigator), Member = "LookupNamespace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public virtual string LookupNamespace(string prefix) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public virtual bool MoveTo(XPathNavigator other) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlAttributeCollection), Member = "get_ItemOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(XmlAttribute))]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 2)]
	public virtual bool MoveToAttribute(string localName, string namespaceURI) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DocumentXPathNavigator), Member = "NextSibling", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNode)}, ReturnType = typeof(XmlNode))]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallsUnknownMethods(Count = 2)]
	public virtual bool MoveToChild(string localName, string namespaceUri) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XPathNavigator), Member = "GetContentKindMask", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XPathNodeType)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(DocumentXPathNavigator), Member = "NextSibling", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNode)}, ReturnType = typeof(XmlNode))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	public virtual bool MoveToChild(XPathNodeType type) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlAttributeCollection), Member = "get_ItemOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(XmlAttribute))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 2)]
	public virtual bool MoveToFirstAttribute() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsInvalidInstructions]
	public virtual bool MoveToFirstChild() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlAttributeCollection), Member = "get_ItemOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(XmlAttribute))]
	[Calls(Type = typeof(DocumentXPathNavigator), Member = "MoveToFirstNamespaceGlobal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlAttributeCollection&), typeof(Int32&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DocumentXPathNavigator), Member = "MoveToNextNamespaceGlobal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlAttributeCollection&), typeof(Int32&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlDocument), Member = "get_NamespaceXml", ReturnType = typeof(XmlAttribute))]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 5)]
	public virtual bool MoveToFirstNamespace(XPathNamespaceScope scope) { }

	[CalledBy(Type = typeof(DocumentXPathNavigator), Member = "MoveToFirstNamespace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XPathNamespaceScope)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(DocumentXPathNavigator), Member = "MoveToFirstNamespaceLocal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlAttributeCollection), typeof(Int32&)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 2)]
	private static bool MoveToFirstNamespaceGlobal(ref XmlAttributeCollection attributes, ref int index) { }

	[CalledBy(Type = typeof(DocumentXPathNavigator), Member = "MoveToFirstNamespaceGlobal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlAttributeCollection&), typeof(Int32&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DocumentXPathNavigator), Member = "MoveToNextNamespaceGlobal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlAttributeCollection&), typeof(Int32&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(XmlAttributeCollection), Member = "get_ItemOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(XmlAttribute))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	private static bool MoveToFirstNamespaceLocal(XmlAttributeCollection attributes, ref int index) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XPathNavigator), Member = "MoveToNonDescendant", ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallsUnknownMethods(Count = 4)]
	public virtual bool MoveToFollowing(string localName, string namespaceUri, XPathNavigator end) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XPathNavigator), Member = "MoveToNonDescendant", ReturnType = typeof(bool))]
	[Calls(Type = typeof(XPathNavigator), Member = "GetContentKindMask", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XPathNodeType)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(DocumentXPathNavigator), Member = "TextEnd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNode)}, ReturnType = typeof(XmlNode))]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 4)]
	[ContainsUnimplementedInstructions]
	public virtual bool MoveToFollowing(XPathNodeType type, XPathNavigator end) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public virtual bool MoveToId(string id) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlDocument), Member = "get_NamespaceXml", ReturnType = typeof(XmlAttribute))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 8)]
	public virtual bool MoveToNamespace(string name) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DocumentXPathNavigator), Member = "NextSibling", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNode)}, ReturnType = typeof(XmlNode))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 1)]
	public virtual bool MoveToNext(string localName, string namespaceUri) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DocumentXPathNavigator), Member = "NextSibling", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNode)}, ReturnType = typeof(XmlNode))]
	[Calls(Type = typeof(DocumentXPathNavigator), Member = "TextEnd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNode)}, ReturnType = typeof(XmlNode))]
	[Calls(Type = typeof(XPathNavigator), Member = "GetContentKindMask", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XPathNodeType)}, ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	public virtual bool MoveToNext(XPathNodeType type) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DocumentXPathNavigator), Member = "NextSibling", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNode)}, ReturnType = typeof(XmlNode))]
	[Calls(Type = typeof(DocumentXPathNavigator), Member = "TextEnd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNode)}, ReturnType = typeof(XmlNode))]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 3)]
	public virtual bool MoveToNext() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlAttributeCollection), Member = "get_ItemOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(XmlAttribute))]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 4)]
	public virtual bool MoveToNextAttribute() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlAttributeCollection), Member = "get_ItemOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(XmlAttribute))]
	[Calls(Type = typeof(DocumentXPathNavigator), Member = "PathHasDuplicateNamespace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlElement), typeof(XmlElement), typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlDocument), Member = "get_NamespaceXml", ReturnType = typeof(XmlAttribute))]
	[CallsDeduplicatedMethods(Count = 30)]
	[CallsUnknownMethods(Count = 7)]
	public virtual bool MoveToNextNamespace(XPathNamespaceScope scope) { }

	[CalledBy(Type = typeof(DocumentXPathNavigator), Member = "MoveToFirstNamespace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XPathNamespaceScope)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DocumentXPathNavigator), Member = "MoveToNextNamespaceLocal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlAttributeCollection), typeof(Int32&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DocumentXPathNavigator), Member = "MoveToFirstNamespaceLocal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlAttributeCollection), typeof(Int32&)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 2)]
	private static bool MoveToNextNamespaceGlobal(ref XmlAttributeCollection attributes, ref int index) { }

	[CalledBy(Type = typeof(DocumentXPathNavigator), Member = "MoveToNextNamespaceGlobal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlAttributeCollection&), typeof(Int32&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(XmlAttributeCollection), Member = "get_ItemOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(XmlAttribute))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private static bool MoveToNextNamespaceLocal(XmlAttributeCollection attributes, ref int index) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 4)]
	public virtual bool MoveToParent() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 3)]
	public virtual void MoveToRoot() { }

	[CalledBy(Type = typeof(DocumentXPathNavigator), Member = "get_Value", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(DocumentXPathNavigator), Member = "get_ValueText", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(DocumentXPathNavigator), Member = "MoveToNext", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DocumentXPathNavigator), Member = "MoveToChild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DocumentXPathNavigator), Member = "MoveToChild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XPathNodeType)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DocumentXPathNavigator), Member = "MoveToNext", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DocumentXPathNavigator), Member = "MoveToNext", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XPathNodeType)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DocumentXPathNavigator), Member = "TextEnd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNode)}, ReturnType = typeof(XmlNode))]
	[CallerCount(Count = 15)]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 1)]
	private XmlNode NextSibling(XmlNode node) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 1)]
	private XmlNode NextSiblingTail(XmlNode node, XmlNode sibling) { }

	[CalledBy(Type = typeof(DocumentXPathNavigator), Member = "ComparePosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XPathNavigator)}, ReturnType = typeof(XmlNodeOrder))]
	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	private static XmlNode OwnerNode(XmlNode node) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	private XmlNode ParentNode(XmlNode node) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	private XmlNode ParentNodeTail(XmlNode parent) { }

	[CalledBy(Type = typeof(DocumentXPathNavigator), Member = "MoveToNextNamespace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XPathNamespaceScope)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	private bool PathHasDuplicateNamespace(XmlElement top, XmlElement bottom, string localName) { }

	[CalledBy(Type = typeof(DocumentXPathNavigator), Member = "get_NodeType", ReturnType = typeof(XPathNodeType))]
	[CalledBy(Type = typeof(DocumentXPathNavigator), Member = "get_Value", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(DocumentXPathNavigator), Member = "get_ValueText", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(DocumentXPathNavigator), Member = "get_UnderlyingObject", ReturnType = typeof(object))]
	[CalledBy(Type = typeof(DocumentXPathNavigator), Member = "IsSamePosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XPathNavigator)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DocumentXPathNavigator), Member = "ComparePosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XPathNavigator)}, ReturnType = typeof(XmlNodeOrder))]
	[CalledBy(Type = typeof(DocumentXPathNavigator), Member = "CalibrateText", ReturnType = typeof(void))]
	[CallerCount(Count = 18)]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 1)]
	private XmlNode PreviousText(XmlNode node) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 1)]
	private XmlNode PreviousTextTail(XmlNode node, XmlNode text) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlAttributeCollection), Member = "get_ItemOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(XmlAttribute))]
	[CallsDeduplicatedMethods(Count = 1)]
	private static bool ResetAttributePosition(XmlAttribute attribute, XmlAttributeCollection attributes, out int index) { }

	[CalledBy(Type = typeof(DocumentXPathNavigator), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlDocument), typeof(XmlNode)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DocumentXPathNavigator), Member = "get_NodeType", ReturnType = typeof(XPathNodeType))]
	[CalledBy(Type = typeof(DocumentXPathNavigator), Member = "get_Value", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(DocumentXPathNavigator), Member = "get_ValueText", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(DocumentXPathNavigator), Member = "get_UnderlyingObject", ReturnType = typeof(object))]
	[CalledBy(Type = typeof(DocumentXPathNavigator), Member = "IsSamePosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XPathNavigator)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DocumentXPathNavigator), Member = "ComparePosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XPathNavigator)}, ReturnType = typeof(XmlNodeOrder))]
	[CalledBy(Type = typeof(DocumentXPathNavigator), Member = "CalibrateText", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlDocument), Member = "CreateNavigator", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNode)}, ReturnType = typeof(XPathNavigator))]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(XmlAttributeCollection), Member = "get_ItemOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(XmlAttribute))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 3)]
	internal void ResetPosition(XmlNode node) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DocumentXPathNodeIterator_ElemDescendants), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DocumentXPathNavigator)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 3)]
	public virtual XPathNodeIterator SelectDescendants(string localName, string namespaceURI, bool matchSelf) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XPathNavigator), Member = "SelectDescendants", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XPathNodeType), typeof(bool)}, ReturnType = typeof(XPathNodeIterator))]
	[Calls(Type = typeof(DocumentXPathNodeIterator_ElemDescendants), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DocumentXPathNavigator)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	public virtual XPathNodeIterator SelectDescendants(XPathNodeType nt, bool includeSelf) { }

	[CallerCount(Count = 31)]
	[DeduplicatedMethod]
	private override XmlNode System.Xml.IHasXmlNode.GetNode() { }

	[CalledBy(Type = typeof(DocumentXPathNavigator), Member = "MoveToNext", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DocumentXPathNavigator), Member = "MoveToFollowing", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XPathNodeType), typeof(XPathNavigator)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DocumentXPathNavigator), Member = "MoveToNext", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XPathNodeType)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(DocumentXPathNavigator), Member = "NextSibling", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNode)}, ReturnType = typeof(XmlNode))]
	[CallsDeduplicatedMethods(Count = 1)]
	private XmlNode TextEnd(XmlNode node) { }

}

