namespace System.Xml;

[DebuggerDisplay("{debuggerDisplayProxy}")]
[DefaultMember("Item")]
public abstract class XmlNode : ICloneable, IEnumerable, IXPathNavigable
{
	internal XmlNode parentNode; //Field offset: 0x10

	public override XmlAttributeCollection Attributes
	{
		[CallerCount(Count = 182)]
		[DeduplicatedMethod]
		 get { } //Length: 3
	}

	public override string BaseURI
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(XmlEntityReference), Member = "get_ChildBaseURI", ReturnType = typeof(string))]
		[CallsDeduplicatedMethods(Count = 4)]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 245
	}

	public override XmlNodeList ChildNodes
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		 get { } //Length: 84
	}

	internal XmlDocument Document
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		internal get { } //Length: 146
	}

	public override XmlNode FirstChild
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		 get { } //Length: 39
	}

	public override bool HasChildNodes
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 31
	}

	public override string InnerText
	{
		[CalledBy(Type = typeof(XmlAttribute), Member = "set_InnerText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XmlElement), Member = "get_InnerText", ReturnType = typeof(string))]
		[CalledBy(Type = typeof(XmlEntity), Member = "get_InnerText", ReturnType = typeof(string))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(StringBuilder), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(XmlNode), Member = "AppendChildText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 5)]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 270
		[CalledBy(Type = typeof(XmlAttribute), Member = "set_InnerText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 8)]
		[CallsUnknownMethods(Count = 1)]
		 set { } //Length: 242
	}

	public override string InnerXml
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 4)]
		 set { } //Length: 95
	}

	internal override bool IsContainer
	{
		[CallerCount(Count = 271)]
		[DeduplicatedMethod]
		internal get { } //Length: 3
	}

	public override bool IsReadOnly
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 4)]
		[CallsUnknownMethods(Count = 2)]
		 get { } //Length: 211
	}

	internal override bool IsText
	{
		[CallerCount(Count = 271)]
		[DeduplicatedMethod]
		internal get { } //Length: 3
	}

	public override XmlElement Item
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 5)]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 246
	}

	public override XmlNode LastChild
	{
		[CallerCount(Count = 40)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 17
	}

	internal override XmlLinkedNode LastNode
	{
		[CallerCount(Count = 182)]
		[DeduplicatedMethod]
		internal get { } //Length: 3
		[CallerCount(Count = 13327)]
		[DeduplicatedMethod]
		internal set { } //Length: 3
	}

	public abstract string LocalName
	{
		 get { } //Length: 0
	}

	public abstract string Name
	{
		 get { } //Length: 0
	}

	public override string NamespaceURI
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 18
	}

	public override XmlNode NextSibling
	{
		[CallerCount(Count = 182)]
		[DeduplicatedMethod]
		 get { } //Length: 3
	}

	public abstract XmlNodeType NodeType
	{
		 get { } //Length: 0
	}

	public override XmlDocument OwnerDocument
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 2)]
		 get { } //Length: 184
	}

	public override XmlNode ParentNode
	{
		[CalledBy(Type = typeof(XmlSignificantWhitespace), Member = "get_ParentNode", ReturnType = typeof(XmlNode))]
		[CalledBy(Type = typeof(XmlWhitespace), Member = "get_ParentNode", ReturnType = typeof(XmlNode))]
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 236
	}

	public override string Prefix
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 18
		[CallerCount(Count = 13327)]
		[DeduplicatedMethod]
		 set { } //Length: 3
	}

	public override XmlNode PreviousSibling
	{
		[CallerCount(Count = 182)]
		[DeduplicatedMethod]
		 get { } //Length: 3
	}

	public override XmlNode PreviousText
	{
		[CallerCount(Count = 182)]
		[DeduplicatedMethod]
		 get { } //Length: 3
	}

	public override IXmlSchemaInfo SchemaInfo
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 79
	}

	public override string Value
	{
		[CallerCount(Count = 182)]
		[DeduplicatedMethod]
		 get { } //Length: 3
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[Calls(Type = typeof(Enum), Member = "ToString", ReturnType = typeof(string))]
		[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider), typeof(string), typeof(object)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 9)]
		 set { } //Length: 212
	}

	internal override string XmlLang
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 1)]
		internal get { } //Length: 218
	}

	internal override XmlSpace XmlSpace
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(XmlConvert), Member = "TrimString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
		[CallsDeduplicatedMethods(Count = 5)]
		[CallsUnknownMethods(Count = 1)]
		internal get { } //Length: 372
	}

	internal override string XPLocalName
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		internal get { } //Length: 18
	}

	internal override XPathNodeType XPNodeType
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		internal get { } //Length: 6
	}

	[CallerCount(Count = 2180)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	internal XmlNode() { }

	[CalledBy(Type = typeof(XmlAttribute), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlName), typeof(XmlDocument)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	internal XmlNode(XmlDocument doc) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	internal override void AfterEvent(XmlNodeChangedEventArgs args) { }

	[CalledBy(Type = typeof(XmlNode), Member = "InsertBefore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNode), typeof(XmlNode)}, ReturnType = typeof(XmlNode))]
	[CalledBy(Type = typeof(XmlNode), Member = "InsertAfter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNode), typeof(XmlNode)}, ReturnType = typeof(XmlNode))]
	[CalledBy(Type = typeof(XmlNode), Member = "AppendChild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNode)}, ReturnType = typeof(XmlNode))]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	internal bool AncestorNode(XmlNode node) { }

	[CalledBy(Type = typeof(XmlAttribute), Member = "AppendChild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNode)}, ReturnType = typeof(XmlNode))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(XmlNode), Member = "AncestorNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNode)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 32)]
	[CallsUnknownMethods(Count = 26)]
	public override XmlNode AppendChild(XmlNode newChild) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlDocument), Member = "GetInsertEventArgsForLoad", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNode), typeof(XmlNode)}, ReturnType = typeof(XmlNodeChangedEventArgs))]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 6)]
	internal override XmlNode AppendChildForLoad(XmlNode newChild, XmlDocument doc) { }

	[CalledBy(Type = typeof(XmlNode), Member = "AppendChildText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlNode), Member = "get_InnerText", ReturnType = typeof(string))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(XmlNode), Member = "AppendChildText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(StringBuilder))]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 1)]
	private void AppendChildText(StringBuilder builder) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	internal override void BeforeEvent(XmlNodeChangedEventArgs args) { }

	[CallerCount(Count = 23)]
	[DeduplicatedMethod]
	internal override bool CanInsertAfter(XmlNode newChild, XmlNode refChild) { }

	[CallerCount(Count = 23)]
	[DeduplicatedMethod]
	internal override bool CanInsertBefore(XmlNode newChild, XmlNode refChild) { }

	public abstract XmlNode CloneNode(bool deep) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	internal override void CopyChildren(XmlDocument doc, XmlNode container, bool deep) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	public override XPathNavigator CreateNavigator() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	internal override XmlNode FindChild(XmlNodeType type) { }

	[CallerCount(Count = 182)]
	[DeduplicatedMethod]
	public override XmlAttributeCollection get_Attributes() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlEntityReference), Member = "get_ChildBaseURI", ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	public override string get_BaseURI() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public override XmlNodeList get_ChildNodes() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	internal XmlDocument get_Document() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public override XmlNode get_FirstChild() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public override bool get_HasChildNodes() { }

	[CalledBy(Type = typeof(XmlAttribute), Member = "set_InnerText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlElement), Member = "get_InnerText", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(XmlEntity), Member = "get_InnerText", ReturnType = typeof(string))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlNode), Member = "AppendChildText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 1)]
	public override string get_InnerText() { }

	[CallerCount(Count = 271)]
	[DeduplicatedMethod]
	internal override bool get_IsContainer() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 2)]
	public override bool get_IsReadOnly() { }

	[CallerCount(Count = 271)]
	[DeduplicatedMethod]
	internal override bool get_IsText() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 1)]
	public override XmlElement get_Item(string name) { }

	[CallerCount(Count = 40)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public override XmlNode get_LastChild() { }

	[CallerCount(Count = 182)]
	[DeduplicatedMethod]
	internal override XmlLinkedNode get_LastNode() { }

	public abstract string get_LocalName() { }

	public abstract string get_Name() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public override string get_NamespaceURI() { }

	[CallerCount(Count = 182)]
	[DeduplicatedMethod]
	public override XmlNode get_NextSibling() { }

	public abstract XmlNodeType get_NodeType() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public override XmlDocument get_OwnerDocument() { }

	[CalledBy(Type = typeof(XmlSignificantWhitespace), Member = "get_ParentNode", ReturnType = typeof(XmlNode))]
	[CalledBy(Type = typeof(XmlWhitespace), Member = "get_ParentNode", ReturnType = typeof(XmlNode))]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public override XmlNode get_ParentNode() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public override string get_Prefix() { }

	[CallerCount(Count = 182)]
	[DeduplicatedMethod]
	public override XmlNode get_PreviousSibling() { }

	[CallerCount(Count = 182)]
	[DeduplicatedMethod]
	public override XmlNode get_PreviousText() { }

	[CallerCount(Count = 0)]
	public override IXmlSchemaInfo get_SchemaInfo() { }

	[CallerCount(Count = 182)]
	[DeduplicatedMethod]
	public override string get_Value() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	internal override string get_XmlLang() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlConvert), Member = "TrimString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 1)]
	internal override XmlSpace get_XmlSpace() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	internal override string get_XPLocalName() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	internal override XPathNodeType get_XPNodeType() { }

	[CalledBy(Type = typeof(XmlDocument), Member = "WriteContentTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlWriter)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(XmlChildEnumerator), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNode)}, ReturnType = typeof(void))]
	public IEnumerator GetEnumerator() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 4)]
	internal override XmlNodeChangedEventArgs GetEventArgs(XmlNode node, XmlNode oldParent, XmlNode newParent, string oldValue, string newValue, XmlNodeChangedAction action) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlNode), Member = "GetPrefixOfNamespaceStrict", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	public override string GetPrefixOfNamespace(string namespaceURI) { }

	[CalledBy(Type = typeof(XmlNode), Member = "GetPrefixOfNamespace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(XmlAttributeCollection), Member = "get_ItemOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(XmlAttribute))]
	[CallsDeduplicatedMethods(Count = 24)]
	[CallsUnknownMethods(Count = 4)]
	internal string GetPrefixOfNamespaceStrict(string namespaceURI) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	internal static bool HasReadOnlyParent(XmlNode n) { }

	[CalledBy(Type = typeof(XmlAttribute), Member = "InsertAfter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNode), typeof(XmlNode)}, ReturnType = typeof(XmlNode))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(XmlNode), Member = "AncestorNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNode)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 37)]
	[CallsUnknownMethods(Count = 35)]
	public override XmlNode InsertAfter(XmlNode newChild, XmlNode refChild) { }

	[CalledBy(Type = typeof(XmlAttribute), Member = "InsertBefore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNode), typeof(XmlNode)}, ReturnType = typeof(XmlNode))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(XmlNode), Member = "AncestorNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNode)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 37)]
	[CallsUnknownMethods(Count = 37)]
	public override XmlNode InsertBefore(XmlNode newChild, XmlNode refChild) { }

	[CalledBy(Type = typeof(XmlDocument), Member = "GetElementById", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(XmlElement))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	internal bool IsConnected() { }

	[CallerCount(Count = 271)]
	[DeduplicatedMethod]
	internal override bool IsValidChildType(XmlNodeType type) { }

	[CalledBy(Type = typeof(XmlAttribute), Member = "AppendChildForLoad", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNode), typeof(XmlDocument)}, ReturnType = typeof(XmlNode))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	internal static void NestTextNodes(XmlNode prevNode, XmlNode nextNode) { }

	[CalledBy(Type = typeof(XmlAttribute), Member = "PrependChild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNode)}, ReturnType = typeof(XmlNode))]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	public override XmlNode PrependChild(XmlNode newChild) { }

	[CalledBy(Type = typeof(XmlElement), Member = "CloneNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(XmlNode))]
	[CalledBy(Type = typeof(XmlElement), Member = "set_IsEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlElement), Member = "RemoveAll", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlElement), Member = "RemoveAllChildren", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlElement), Member = "set_InnerXml", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlElement), Member = "set_InnerText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[CallsDeduplicatedMethods(Count = 3)]
	public override void RemoveAll() { }

	[CalledBy(Type = typeof(XmlAttribute), Member = "RemoveChild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNode)}, ReturnType = typeof(XmlNode))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 19)]
	[CallsUnknownMethods(Count = 20)]
	public override XmlNode RemoveChild(XmlNode oldChild) { }

	[CalledBy(Type = "Mono.Nat.Upnp.UpnpSearcher+<ServicesReceived>d__17", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(XPathNodeList), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XPathNodeIterator)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	public XmlNodeList SelectNodes(string xpath, XmlNamespaceManager nsmgr) { }

	[CalledBy(Type = "Mono.Nat.Upnp.ResponseMessage", Member = "Decode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Mono.Nat.Upnp.UpnpNatDevice", typeof(string)}, ReturnType = "Mono.Nat.Upnp.ResponseMessage")]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(XPathNodeList), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XPathNodeIterator)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 1)]
	public XmlNode SelectSingleNode(string xpath, XmlNamespaceManager nsmgr) { }

	[CalledBy(Type = typeof(XmlAttribute), Member = "set_InnerText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 1)]
	public override void set_InnerText(string value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public override void set_InnerXml(string value) { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	internal override void set_LastNode(XmlLinkedNode value) { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	public override void set_Prefix(string value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(Enum), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider), typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 9)]
	public override void set_Value(string value) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	internal override void SetParent(XmlNode node) { }

	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	internal override void SetParentForLoad(XmlNode node) { }

	[CalledBy(Type = typeof(XmlDocument), Member = "CreateAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(XmlAttribute))]
	[CalledBy(Type = typeof(XmlDocument), Member = "CreateElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(XmlElement))]
	[CalledBy(Type = typeof(XmlDocument), Member = "CreateAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(XmlAttribute))]
	[CalledBy(Type = typeof(XmlDocument), Member = "CreateElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(XmlElement))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(string), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 4)]
	internal static void SplitName(string name, out string prefix, out string localName) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlChildEnumerator), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNode)}, ReturnType = typeof(void))]
	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private override object System.ICloneable.Clone() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	internal static void UnnestTextNodes(XmlNode prevNode, XmlNode nextNode) { }

	public abstract void WriteContentTo(XmlWriter w) { }

	public abstract void WriteTo(XmlWriter w) { }

}

