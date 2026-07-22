namespace Newtonsoft.Json.Converters;

[Nullable(0)]
[NullableContext(1)]
internal class XElementWrapper : XContainerWrapper, IXmlElement, IXmlNode
{
	[Nullable(new IL2CPP_TYPE_U1[] {2, 1})]
	private List<IXmlNode> _attributes; //Field offset: 0x20

	public virtual List<IXmlNode> Attributes
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(XElementWrapper), Member = "get_Element", ReturnType = typeof(XElement))]
		[Calls(Type = typeof(XElement), Member = "get_HasAttributes", ReturnType = typeof(bool))]
		[Calls(Type = typeof(XElementWrapper), Member = "HasImplicitNamespaceAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(XElement), Member = "Attributes", ReturnType = typeof(System.Collections.Generic.IEnumerable`1<System.Xml.Linq.XAttribute>))]
		[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(XName), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(XName))]
		[Calls(Type = typeof(XAttribute), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XName), typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Insert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 6)]
		[CallsUnknownMethods(Count = 17)]
		 get { } //Length: 1090
	}

	private XElement Element
	{
		[CalledBy(Type = typeof(XElementWrapper), Member = "get_Attributes", ReturnType = typeof(System.Collections.Generic.List`1<Newtonsoft.Json.Converters.IXmlNode>))]
		[CalledBy(Type = typeof(XElementWrapper), Member = "HasImplicitNamespaceAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 4)]
		[CallsUnknownMethods(Count = 1)]
		private get { } //Length: 107
	}

	public override bool IsEmpty
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(XElement), Member = "get_IsEmpty", ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 2)]
		 get { } //Length: 116
	}

	[Nullable(2)]
	public virtual string LocalName
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		[NullableContext(2)]
		 get { } //Length: 122
	}

	[Nullable(2)]
	public virtual string NamespaceUri
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		[NullableContext(2)]
		 get { } //Length: 124
	}

	[Nullable(2)]
	public virtual string Value
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(XElement), Member = "get_Value", ReturnType = typeof(string))]
		[CallsUnknownMethods(Count = 2)]
		[NullableContext(2)]
		 get { } //Length: 116
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(XElement), Member = "set_Value", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 2)]
		[NullableContext(2)]
		 set { } //Length: 161
	}

	[CallerCount(Count = 98)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public XElementWrapper(XElement element) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XContainerWrapper), Member = "AppendChild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IXmlNode)}, ReturnType = typeof(IXmlNode))]
	[CallsUnknownMethods(Count = 1)]
	public virtual IXmlNode AppendChild(IXmlNode newChild) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XElementWrapper), Member = "get_Element", ReturnType = typeof(XElement))]
	[Calls(Type = typeof(XElement), Member = "get_HasAttributes", ReturnType = typeof(bool))]
	[Calls(Type = typeof(XElementWrapper), Member = "HasImplicitNamespaceAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(XElement), Member = "Attributes", ReturnType = typeof(System.Collections.Generic.IEnumerable`1<System.Xml.Linq.XAttribute>))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XName), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(XName))]
	[Calls(Type = typeof(XAttribute), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XName), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Insert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 17)]
	public virtual List<IXmlNode> get_Attributes() { }

	[CalledBy(Type = typeof(XElementWrapper), Member = "get_Attributes", ReturnType = typeof(System.Collections.Generic.List`1<Newtonsoft.Json.Converters.IXmlNode>))]
	[CalledBy(Type = typeof(XElementWrapper), Member = "HasImplicitNamespaceAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	private XElement get_Element() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XElement), Member = "get_IsEmpty", ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 2)]
	public override bool get_IsEmpty() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[NullableContext(2)]
	public virtual string get_LocalName() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[NullableContext(2)]
	public virtual string get_NamespaceUri() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XElement), Member = "get_Value", ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 2)]
	[NullableContext(2)]
	public virtual string get_Value() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XNamespace), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(XNamespace))]
	[Calls(Type = typeof(XElement), Member = "GetPrefixOfNamespace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XNamespace)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 2)]
	public override string GetPrefixOfNamespace(string namespaceUri) { }

	[CalledBy(Type = typeof(XElementWrapper), Member = "get_Attributes", ReturnType = typeof(System.Collections.Generic.List`1<Newtonsoft.Json.Converters.IXmlNode>))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(StringUtils), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(XNamespace), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(XNamespace))]
	[Calls(Type = typeof(XElement), Member = "GetPrefixOfNamespace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XNamespace)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(XElementWrapper), Member = "get_Element", ReturnType = typeof(XElement))]
	[Calls(Type = typeof(XElement), Member = "get_HasAttributes", ReturnType = typeof(bool))]
	[Calls(Type = typeof(XElement), Member = "Attributes", ReturnType = typeof(System.Collections.Generic.IEnumerable`1<System.Xml.Linq.XAttribute>))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 14)]
	[ContainsUnimplementedInstructions]
	private bool HasImplicitNamespaceAttribute(string namespaceUri) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XElement), Member = "set_Value", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[NullableContext(2)]
	public virtual void set_Value(string value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XContainer), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	public override void SetAttributeNode(IXmlNode attribute) { }

}

