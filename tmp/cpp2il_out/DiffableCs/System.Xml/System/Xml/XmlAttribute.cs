namespace System.Xml;

public class XmlAttribute : XmlNode
{
	private XmlName name; //Field offset: 0x18
	private XmlLinkedNode lastChild; //Field offset: 0x20

	public virtual string BaseURI
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 107
	}

	public virtual string InnerText
	{
		[CalledBy(Type = typeof(XmlUnspecifiedAttribute), Member = "set_InnerText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(XmlAttribute), Member = "PrepareOwnerElementInElementIdAttrMap", ReturnType = typeof(bool))]
		[Calls(Type = typeof(XmlNode), Member = "set_InnerText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(XmlNode), Member = "get_InnerText", ReturnType = typeof(string))]
		[Calls(Type = typeof(XmlAttribute), Member = "ResetOwnerElementInElementIdAttrMap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		 set { } //Length: 109
	}

	public virtual string InnerXml
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(XmlLoader), Member = "LoadInnerXmlAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlAttribute), typeof(string)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		 set { } //Length: 135
	}

	internal virtual bool IsContainer
	{
		[CallerCount(Count = 23)]
		[DeduplicatedMethod]
		internal get { } //Length: 3
	}

	internal bool IsNamespace
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		internal get { } //Length: 50
	}

	internal virtual XmlLinkedNode LastNode
	{
		[CallerCount(Count = 12)]
		[DeduplicatedMethod]
		internal get { } //Length: 5
		[CallerCount(Count = 10)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		internal set { } //Length: 13
	}

	public virtual string LocalName
	{
		[CallerCount(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 27
	}

	internal int LocalNameHash
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		internal get { } //Length: 26
	}

	public virtual string Name
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(XmlName), Member = "get_Name", ReturnType = typeof(string))]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 29
	}

	public virtual string NamespaceURI
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 27
	}

	public virtual XmlNodeType NodeType
	{
		[CallerCount(Count = 8)]
		[DeduplicatedMethod]
		 get { } //Length: 6
	}

	public virtual XmlDocument OwnerDocument
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 27
	}

	public override XmlElement OwnerElement
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 114
	}

	public virtual XmlNode ParentNode
	{
		[CallerCount(Count = 182)]
		[DeduplicatedMethod]
		 get { } //Length: 3
	}

	public virtual string Prefix
	{
		[CallerCount(Count = 21)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 27
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(XmlDocument), Member = "AddAttrXmlName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(IXmlSchemaInfo)}, ReturnType = typeof(XmlName))]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 2)]
		 set { } //Length: 163
	}

	public virtual IXmlSchemaInfo SchemaInfo
	{
		[CallerCount(Count = 31)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public override bool Specified
	{
		[CallerCount(Count = 23)]
		[DeduplicatedMethod]
		 get { } //Length: 3
	}

	public virtual string Value
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 17
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		 set { } //Length: 17
	}

	internal virtual string XmlLang
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 1)]
		internal get { } //Length: 107
	}

	internal XmlName XmlName
	{
		[CallerCount(Count = 31)]
		[DeduplicatedMethod]
		internal get { } //Length: 5
		[CallerCount(Count = 9)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		internal set { } //Length: 13
	}

	internal virtual XmlSpace XmlSpace
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 1)]
		internal get { } //Length: 90
	}

	internal virtual string XPLocalName
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		internal get { } //Length: 131
	}

	internal virtual XPathNodeType XPNodeType
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		internal get { } //Length: 61
	}

	[CalledBy(Type = typeof(XmlDocument), Member = "CreateAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(XmlAttribute))]
	[CalledBy(Type = typeof(XmlDocument), Member = "get_NamespaceXml", ReturnType = typeof(XmlAttribute))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(XmlNode), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlDocument)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlDocument), Member = "CheckName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	internal XmlAttribute(XmlName name, XmlDocument doc) { }

	[CalledBy(Type = typeof(XmlLoader), Member = "LoadAttributeNodeDirect", ReturnType = typeof(XmlAttribute))]
	[CalledBy(Type = typeof(XmlUnspecifiedAttribute), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(XmlDocument)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XsdBuilder), Member = "ProcessAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(XmlDocument), Member = "AddAttrXmlName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(IXmlSchemaInfo)}, ReturnType = typeof(XmlName))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsInvalidInstructions]
	protected private XmlAttribute(string prefix, string localName, string namespaceURI, XmlDocument doc) { }

	[CalledBy(Type = typeof(XmlUnspecifiedAttribute), Member = "AppendChild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNode)}, ReturnType = typeof(XmlNode))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(XmlAttribute), Member = "PrepareOwnerElementInElementIdAttrMap", ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlNode), Member = "AppendChild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNode)}, ReturnType = typeof(XmlNode))]
	[Calls(Type = typeof(XmlAttribute), Member = "ResetOwnerElementInElementIdAttrMap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	public virtual XmlNode AppendChild(XmlNode newChild) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlDocument), Member = "GetInsertEventArgsForLoad", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNode), typeof(XmlNode)}, ReturnType = typeof(XmlNodeChangedEventArgs))]
	[Calls(Type = typeof(XmlNode), Member = "NestTextNodes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNode), typeof(XmlNode)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 7)]
	internal virtual XmlNode AppendChildForLoad(XmlNode newChild, XmlDocument doc) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 1)]
	public virtual XmlNode CloneNode(bool deep) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	public virtual string get_BaseURI() { }

	[CallerCount(Count = 23)]
	[DeduplicatedMethod]
	internal virtual bool get_IsContainer() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	internal bool get_IsNamespace() { }

	[CallerCount(Count = 12)]
	[DeduplicatedMethod]
	internal virtual XmlLinkedNode get_LastNode() { }

	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public virtual string get_LocalName() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	internal int get_LocalNameHash() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlName), Member = "get_Name", ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 1)]
	public virtual string get_Name() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public virtual string get_NamespaceURI() { }

	[CallerCount(Count = 8)]
	[DeduplicatedMethod]
	public virtual XmlNodeType get_NodeType() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public virtual XmlDocument get_OwnerDocument() { }

	[CallerCount(Count = 0)]
	public override XmlElement get_OwnerElement() { }

	[CallerCount(Count = 182)]
	[DeduplicatedMethod]
	public virtual XmlNode get_ParentNode() { }

	[CallerCount(Count = 21)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public virtual string get_Prefix() { }

	[CallerCount(Count = 31)]
	[DeduplicatedMethod]
	public virtual IXmlSchemaInfo get_SchemaInfo() { }

	[CallerCount(Count = 23)]
	[DeduplicatedMethod]
	public override bool get_Specified() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public virtual string get_Value() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	internal virtual string get_XmlLang() { }

	[CallerCount(Count = 31)]
	[DeduplicatedMethod]
	internal XmlName get_XmlName() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	internal virtual XmlSpace get_XmlSpace() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	internal virtual string get_XPLocalName() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	internal virtual XPathNodeType get_XPNodeType() { }

	[CalledBy(Type = typeof(XmlUnspecifiedAttribute), Member = "InsertAfter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNode), typeof(XmlNode)}, ReturnType = typeof(XmlNode))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(XmlAttribute), Member = "PrepareOwnerElementInElementIdAttrMap", ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlNode), Member = "InsertAfter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNode), typeof(XmlNode)}, ReturnType = typeof(XmlNode))]
	[Calls(Type = typeof(XmlAttribute), Member = "ResetOwnerElementInElementIdAttrMap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	public virtual XmlNode InsertAfter(XmlNode newChild, XmlNode refChild) { }

	[CalledBy(Type = typeof(XmlUnspecifiedAttribute), Member = "InsertBefore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNode), typeof(XmlNode)}, ReturnType = typeof(XmlNode))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(XmlAttribute), Member = "PrepareOwnerElementInElementIdAttrMap", ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlNode), Member = "InsertBefore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNode), typeof(XmlNode)}, ReturnType = typeof(XmlNode))]
	[Calls(Type = typeof(XmlAttribute), Member = "ResetOwnerElementInElementIdAttrMap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	public virtual XmlNode InsertBefore(XmlNode newChild, XmlNode refChild) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	internal virtual bool IsValidChildType(XmlNodeType type) { }

	[CalledBy(Type = typeof(XmlAttribute), Member = "set_InnerText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlAttribute), Member = "InsertBefore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNode), typeof(XmlNode)}, ReturnType = typeof(XmlNode))]
	[CalledBy(Type = typeof(XmlAttribute), Member = "InsertAfter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNode), typeof(XmlNode)}, ReturnType = typeof(XmlNode))]
	[CalledBy(Type = typeof(XmlAttribute), Member = "RemoveChild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNode)}, ReturnType = typeof(XmlNode))]
	[CalledBy(Type = typeof(XmlAttribute), Member = "PrependChild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNode)}, ReturnType = typeof(XmlNode))]
	[CalledBy(Type = typeof(XmlAttribute), Member = "AppendChild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNode)}, ReturnType = typeof(XmlNode))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(XmlDocument), Member = "GetIDInfoByElement_", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlName)}, ReturnType = typeof(XmlName))]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 1)]
	internal bool PrepareOwnerElementInElementIdAttrMap() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlAttribute), Member = "PrepareOwnerElementInElementIdAttrMap", ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlNode), Member = "PrependChild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNode)}, ReturnType = typeof(XmlNode))]
	[Calls(Type = typeof(XmlAttribute), Member = "ResetOwnerElementInElementIdAttrMap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	public virtual XmlNode PrependChild(XmlNode newChild) { }

	[CalledBy(Type = typeof(XmlUnspecifiedAttribute), Member = "RemoveChild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNode)}, ReturnType = typeof(XmlNode))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(XmlAttribute), Member = "PrepareOwnerElementInElementIdAttrMap", ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlNode), Member = "RemoveChild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNode)}, ReturnType = typeof(XmlNode))]
	[Calls(Type = typeof(XmlAttribute), Member = "ResetOwnerElementInElementIdAttrMap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	public virtual XmlNode RemoveChild(XmlNode oldChild) { }

	[CalledBy(Type = typeof(XmlAttribute), Member = "set_InnerText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlAttribute), Member = "InsertBefore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNode), typeof(XmlNode)}, ReturnType = typeof(XmlNode))]
	[CalledBy(Type = typeof(XmlAttribute), Member = "InsertAfter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNode), typeof(XmlNode)}, ReturnType = typeof(XmlNode))]
	[CalledBy(Type = typeof(XmlAttribute), Member = "RemoveChild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNode)}, ReturnType = typeof(XmlNode))]
	[CalledBy(Type = typeof(XmlAttribute), Member = "PrependChild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNode)}, ReturnType = typeof(XmlNode))]
	[CalledBy(Type = typeof(XmlAttribute), Member = "AppendChild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNode)}, ReturnType = typeof(XmlNode))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(XmlDocument), Member = "RemoveElementWithId", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(XmlElement)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlDocument), Member = "AddElementWithId", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(XmlElement)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	internal void ResetOwnerElementInElementIdAttrMap(string oldInnerText) { }

	[CalledBy(Type = typeof(XmlUnspecifiedAttribute), Member = "set_InnerText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(XmlAttribute), Member = "PrepareOwnerElementInElementIdAttrMap", ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlNode), Member = "set_InnerText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlNode), Member = "get_InnerText", ReturnType = typeof(string))]
	[Calls(Type = typeof(XmlAttribute), Member = "ResetOwnerElementInElementIdAttrMap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	public virtual void set_InnerText(string value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlLoader), Member = "LoadInnerXmlAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlAttribute), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public virtual void set_InnerXml(string value) { }

	[CallerCount(Count = 10)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	internal virtual void set_LastNode(XmlLinkedNode value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlDocument), Member = "AddAttrXmlName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(IXmlSchemaInfo)}, ReturnType = typeof(XmlName))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	public virtual void set_Prefix(string value) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public virtual void set_Value(string value) { }

	[CallerCount(Count = 9)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	internal void set_XmlName(XmlName value) { }

	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	internal virtual void SetParent(XmlNode node) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[DeduplicatedMethod]
	public virtual void WriteContentTo(XmlWriter w) { }

	[CalledBy(Type = typeof(XmlUnspecifiedAttribute), Member = "WriteTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlWriter)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 1)]
	public virtual void WriteTo(XmlWriter w) { }

}

