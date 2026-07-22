namespace System.Xml;

public class XmlElement : XmlLinkedNode
{
	private XmlName name; //Field offset: 0x20
	private XmlAttributeCollection attributes; //Field offset: 0x28
	private XmlLinkedNode lastChild; //Field offset: 0x30

	public virtual XmlAttributeCollection Attributes
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 3)]
		 get { } //Length: 289
	}

	public override bool HasAttributes
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 48
	}

	public virtual string InnerText
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(XmlNode), Member = "get_InnerText", ReturnType = typeof(string))]
		[DeduplicatedMethod]
		 get { } //Length: 7
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(XmlNode), Member = "RemoveAll", ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 6)]
		[CallsUnknownMethods(Count = 1)]
		 set { } //Length: 214
	}

	public virtual string InnerXml
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(XmlNode), Member = "RemoveAll", ReturnType = typeof(void))]
		[Calls(Type = typeof(XmlLoader), Member = "ParsePartialContent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNode), typeof(string), typeof(XmlNodeType)}, ReturnType = typeof(XmlNamespaceManager))]
		[Calls(Type = typeof(XmlLoader), Member = "RemoveDuplicateNamespace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlElement), typeof(XmlNamespaceManager), typeof(bool)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 9)]
		[CallsUnknownMethods(Count = 1)]
		 set { } //Length: 461
	}

	internal virtual bool IsContainer
	{
		[CallerCount(Count = 23)]
		[DeduplicatedMethod]
		internal get { } //Length: 3
	}

	public bool IsEmpty
	{
		[CalledBy(Type = "Newtonsoft.Json.Converters.XmlElementWrapper", Member = "get_IsEmpty", ReturnType = typeof(bool))]
		[CallerCount(Count = 1)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 8
		[CalledBy(Type = typeof(Parser), Member = "LoadElementNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(XmlElement))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(XmlNode), Member = "RemoveAll", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 2)]
		 set { } //Length: 85
	}

	internal virtual XmlLinkedNode LastNode
	{
		[CallerCount(Count = 0)]
		internal get { } //Length: 14
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		internal set { } //Length: 13
	}

	public virtual string LocalName
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 27
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
		 get { } //Length: 27
	}

	public virtual XmlNode NextSibling
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		 get { } //Length: 59
	}

	public virtual XmlNodeType NodeType
	{
		[CallerCount(Count = 9)]
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

	public virtual XmlNode ParentNode
	{
		[CallerCount(Count = 106)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public virtual string Prefix
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 27
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(XmlDocument), Member = "AddXmlName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(IXmlSchemaInfo)}, ReturnType = typeof(XmlName))]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 2)]
		 set { } //Length: 163
	}

	public virtual IXmlSchemaInfo SchemaInfo
	{
		[CallerCount(Count = 12)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	internal XmlName XmlName
	{
		[CallerCount(Count = 12)]
		[DeduplicatedMethod]
		internal get { } //Length: 5
		[CallerCount(Count = 10)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		internal set { } //Length: 13
	}

	internal virtual string XPLocalName
	{
		[CallerCount(Count = 15)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		internal get { } //Length: 17
	}

	internal virtual XPathNodeType XPNodeType
	{
		[CallerCount(Count = 9)]
		[DeduplicatedMethod]
		internal get { } //Length: 6
	}

	[CalledBy(Type = typeof(XmlDocument), Member = "CreateElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(XmlElement))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(XmlDocument), Member = "CheckName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 14)]
	internal XmlElement(XmlName name, bool empty, XmlDocument doc) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlDocument), Member = "AddXmlName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(IXmlSchemaInfo)}, ReturnType = typeof(XmlName))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsInvalidInstructions]
	protected private XmlElement(string prefix, string localName, string namespaceURI, XmlDocument doc) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlDocument), Member = "GetInsertEventArgsForLoad", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNode), typeof(XmlNode)}, ReturnType = typeof(XmlNodeChangedEventArgs))]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 8)]
	internal virtual XmlNode AppendChildForLoad(XmlNode newChild, XmlDocument doc) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlNode), Member = "RemoveAll", ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlAttributeCollection), Member = "InternalAppendAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlAttribute)}, ReturnType = typeof(XmlAttribute))]
	[CallsDeduplicatedMethods(Count = 13)]
	[CallsUnknownMethods(Count = 16)]
	[ContainsUnimplementedInstructions]
	public virtual XmlNode CloneNode(bool deep) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public virtual XmlAttributeCollection get_Attributes() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public override bool get_HasAttributes() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlNode), Member = "get_InnerText", ReturnType = typeof(string))]
	[DeduplicatedMethod]
	public virtual string get_InnerText() { }

	[CallerCount(Count = 23)]
	[DeduplicatedMethod]
	internal virtual bool get_IsContainer() { }

	[CalledBy(Type = "Newtonsoft.Json.Converters.XmlElementWrapper", Member = "get_IsEmpty", ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[ContainsUnimplementedInstructions]
	public bool get_IsEmpty() { }

	[CallerCount(Count = 0)]
	internal virtual XmlLinkedNode get_LastNode() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public virtual string get_LocalName() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlName), Member = "get_Name", ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 1)]
	public virtual string get_Name() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public virtual string get_NamespaceURI() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public virtual XmlNode get_NextSibling() { }

	[CallerCount(Count = 9)]
	[DeduplicatedMethod]
	public virtual XmlNodeType get_NodeType() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public virtual XmlDocument get_OwnerDocument() { }

	[CallerCount(Count = 106)]
	[DeduplicatedMethod]
	public virtual XmlNode get_ParentNode() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public virtual string get_Prefix() { }

	[CallerCount(Count = 12)]
	[DeduplicatedMethod]
	public virtual IXmlSchemaInfo get_SchemaInfo() { }

	[CallerCount(Count = 12)]
	[DeduplicatedMethod]
	internal XmlName get_XmlName() { }

	[CallerCount(Count = 15)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	internal virtual string get_XPLocalName() { }

	[CallerCount(Count = 9)]
	[DeduplicatedMethod]
	internal virtual XPathNodeType get_XPNodeType() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public override string GetAttribute(string name) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public override string GetAttribute(string localName, string namespaceURI) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlAttributeCollection), Member = "get_ItemOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(XmlAttribute))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public override XmlAttribute GetAttributeNode(string name) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlAttributeCollection), Member = "get_ItemOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(XmlAttribute))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public override XmlAttribute GetAttributeNode(string localName, string namespaceURI) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public override bool HasAttribute(string name) { }

	[CallerCount(Count = 0)]
	[ContainsInvalidInstructions]
	[DeduplicatedMethod]
	internal virtual bool IsValidChildType(XmlNodeType type) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlNode), Member = "RemoveAll", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	public virtual void RemoveAll() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlAttributeCollection), Member = "RemoveAll", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public override void RemoveAllAttributes() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlNode), Member = "RemoveAll", ReturnType = typeof(void))]
	internal void RemoveAllChildren() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlNode), Member = "RemoveAll", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 1)]
	public virtual void set_InnerText(string value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlNode), Member = "RemoveAll", ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlLoader), Member = "ParsePartialContent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNode), typeof(string), typeof(XmlNodeType)}, ReturnType = typeof(XmlNamespaceManager))]
	[Calls(Type = typeof(XmlLoader), Member = "RemoveDuplicateNamespace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlElement), typeof(XmlNamespaceManager), typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallsUnknownMethods(Count = 1)]
	public virtual void set_InnerXml(string value) { }

	[CalledBy(Type = typeof(Parser), Member = "LoadElementNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(XmlElement))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(XmlNode), Member = "RemoveAll", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	public void set_IsEmpty(bool value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	internal virtual void set_LastNode(XmlLinkedNode value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlDocument), Member = "AddXmlName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(IXmlSchemaInfo)}, ReturnType = typeof(XmlName))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	public virtual void set_Prefix(string value) { }

	[CallerCount(Count = 10)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	internal void set_XmlName(XmlName value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlAttributeCollection), Member = "InternalAppendAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlAttribute)}, ReturnType = typeof(XmlAttribute))]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 1)]
	public override string SetAttribute(string localName, string namespaceURI, string value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlDocument), Member = "CreateAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(XmlAttribute))]
	[Calls(Type = typeof(XmlAttributeCollection), Member = "InternalAppendAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlAttribute)}, ReturnType = typeof(XmlAttribute))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 1)]
	public override void SetAttribute(string name, string value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlAttributeCollection), Member = "InternalAppendAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlAttribute)}, ReturnType = typeof(XmlAttribute))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	public override XmlAttribute SetAttributeNode(string localName, string namespaceURI) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 6)]
	public override XmlAttribute SetAttributeNode(XmlAttribute newAttr) { }

	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	internal virtual void SetParent(XmlNode node) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[DeduplicatedMethod]
	public virtual void WriteContentTo(XmlWriter w) { }

	[CalledBy(Type = typeof(XmlElement), Member = "WriteTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlWriter)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(XmlElement), Member = "WriteStartElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlWriter)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallsUnknownMethods(Count = 1)]
	private static void WriteElementTo(XmlWriter writer, XmlElement e) { }

	[CalledBy(Type = typeof(XmlElement), Member = "WriteTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlWriter)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlElement), Member = "WriteElementTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlWriter), typeof(XmlElement)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(XmlAttributeCollection), Member = "get_ItemOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(XmlAttribute))]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 1)]
	private void WriteStartElement(XmlWriter w) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(XmlElement), Member = "WriteStartElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlWriter)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlElement), Member = "WriteElementTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlWriter), typeof(XmlElement)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	public virtual void WriteTo(XmlWriter w) { }

}

