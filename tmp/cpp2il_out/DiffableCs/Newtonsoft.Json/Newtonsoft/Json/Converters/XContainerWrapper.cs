namespace Newtonsoft.Json.Converters;

[Nullable(0)]
[NullableContext(1)]
internal class XContainerWrapper : XObjectWrapper
{
	[Nullable(new IL2CPP_TYPE_U1[] {2, 1})]
	private List<IXmlNode> _childNodes; //Field offset: 0x18

	public virtual List<IXmlNode> ChildNodes
	{
		[CalledBy(Type = typeof(XDocumentWrapper), Member = "get_ChildNodes", ReturnType = typeof(System.Collections.Generic.List`1<Newtonsoft.Json.Converters.IXmlNode>))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(XContainerWrapper), Member = "get_Container", ReturnType = typeof(XContainer))]
		[Calls(Type = typeof(XContainer), Member = "Nodes", ReturnType = typeof(System.Collections.Generic.IEnumerable`1<System.Xml.Linq.XNode>))]
		[Calls(Type = typeof(XContainerWrapper), Member = "WrapNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XObject)}, ReturnType = typeof(IXmlNode))]
		[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 15)]
		 get { } //Length: 785
	}

	private XContainer Container
	{
		[CalledBy(Type = typeof(XContainerWrapper), Member = "get_ChildNodes", ReturnType = typeof(System.Collections.Generic.List`1<Newtonsoft.Json.Converters.IXmlNode>))]
		[CalledBy(Type = typeof(XContainerWrapper), Member = "get_ParentNode", ReturnType = typeof(IXmlNode))]
		[CallerCount(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		private get { } //Length: 107
	}

	protected override bool HasChildNodes
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(XContainer), Member = "get_LastNode", ReturnType = typeof(XNode))]
		[CallsUnknownMethods(Count = 2)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 123
	}

	[Nullable(2)]
	public virtual IXmlNode ParentNode
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(XObject), Member = "get_Parent", ReturnType = typeof(XElement))]
		[Calls(Type = typeof(XContainerWrapper), Member = "get_Container", ReturnType = typeof(XContainer))]
		[Calls(Type = typeof(XContainerWrapper), Member = "WrapNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XObject)}, ReturnType = typeof(IXmlNode))]
		[CallsUnknownMethods(Count = 2)]
		[NullableContext(2)]
		 get { } //Length: 162
	}

	[CallerCount(Count = 98)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public XContainerWrapper(XContainer container) { }

	[CalledBy(Type = typeof(XDocumentWrapper), Member = "AppendChild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IXmlNode)}, ReturnType = typeof(IXmlNode))]
	[CalledBy(Type = typeof(XElementWrapper), Member = "AppendChild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IXmlNode)}, ReturnType = typeof(IXmlNode))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(XContainer), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	public virtual IXmlNode AppendChild(IXmlNode newChild) { }

	[CalledBy(Type = typeof(XDocumentWrapper), Member = "get_ChildNodes", ReturnType = typeof(System.Collections.Generic.List`1<Newtonsoft.Json.Converters.IXmlNode>))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(XContainerWrapper), Member = "get_Container", ReturnType = typeof(XContainer))]
	[Calls(Type = typeof(XContainer), Member = "Nodes", ReturnType = typeof(System.Collections.Generic.IEnumerable`1<System.Xml.Linq.XNode>))]
	[Calls(Type = typeof(XContainerWrapper), Member = "WrapNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XObject)}, ReturnType = typeof(IXmlNode))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 15)]
	public virtual List<IXmlNode> get_ChildNodes() { }

	[CalledBy(Type = typeof(XContainerWrapper), Member = "get_ChildNodes", ReturnType = typeof(System.Collections.Generic.List`1<Newtonsoft.Json.Converters.IXmlNode>))]
	[CalledBy(Type = typeof(XContainerWrapper), Member = "get_ParentNode", ReturnType = typeof(IXmlNode))]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	private XContainer get_Container() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XContainer), Member = "get_LastNode", ReturnType = typeof(XNode))]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	protected override bool get_HasChildNodes() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XObject), Member = "get_Parent", ReturnType = typeof(XElement))]
	[Calls(Type = typeof(XContainerWrapper), Member = "get_Container", ReturnType = typeof(XContainer))]
	[Calls(Type = typeof(XContainerWrapper), Member = "WrapNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XObject)}, ReturnType = typeof(IXmlNode))]
	[CallsUnknownMethods(Count = 2)]
	[NullableContext(2)]
	public virtual IXmlNode get_ParentNode() { }

	[CalledBy(Type = typeof(XTextWrapper), Member = "get_ParentNode", ReturnType = typeof(IXmlNode))]
	[CalledBy(Type = typeof(XCommentWrapper), Member = "get_ParentNode", ReturnType = typeof(IXmlNode))]
	[CalledBy(Type = typeof(XContainerWrapper), Member = "get_ChildNodes", ReturnType = typeof(System.Collections.Generic.List`1<Newtonsoft.Json.Converters.IXmlNode>))]
	[CalledBy(Type = typeof(XContainerWrapper), Member = "get_ParentNode", ReturnType = typeof(IXmlNode))]
	[CalledBy(Type = typeof(XAttributeWrapper), Member = "get_ParentNode", ReturnType = typeof(IXmlNode))]
	[CalledBy(Type = typeof(XmlNodeConverter), Member = "WriteJson", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonWriter), typeof(object), typeof(JsonSerializer)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlNodeConverter), Member = "WrapXml", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(IXmlNode))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(XDocumentTypeWrapper), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XDocumentType)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	internal static IXmlNode WrapNode(XObject node) { }

}

