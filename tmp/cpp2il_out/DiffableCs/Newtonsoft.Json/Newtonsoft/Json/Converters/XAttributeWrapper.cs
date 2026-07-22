namespace Newtonsoft.Json.Converters;

[Nullable(0)]
[NullableContext(2)]
internal class XAttributeWrapper : XObjectWrapper
{

	[Nullable(1)]
	private XAttribute Attribute
	{
		[CalledBy(Type = typeof(XAttributeWrapper), Member = "get_ParentNode", ReturnType = typeof(IXmlNode))]
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[NullableContext(1)]
		private get { } //Length: 107
	}

	public virtual string LocalName
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		 get { } //Length: 122
	}

	public virtual string NamespaceUri
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		 get { } //Length: 124
	}

	public virtual IXmlNode ParentNode
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(XObject), Member = "get_Parent", ReturnType = typeof(XElement))]
		[Calls(Type = typeof(XAttributeWrapper), Member = "get_Attribute", ReturnType = typeof(XAttribute))]
		[Calls(Type = typeof(XContainerWrapper), Member = "WrapNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XObject)}, ReturnType = typeof(IXmlNode))]
		[CallsUnknownMethods(Count = 2)]
		 get { } //Length: 162
	}

	public virtual string Value
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		 get { } //Length: 117
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(XAttribute), Member = "set_Value", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 2)]
		 set { } //Length: 161
	}

	[CallerCount(Count = 98)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[NullableContext(1)]
	public XAttributeWrapper(XAttribute attribute) { }

	[CalledBy(Type = typeof(XAttributeWrapper), Member = "get_ParentNode", ReturnType = typeof(IXmlNode))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[NullableContext(1)]
	private XAttribute get_Attribute() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public virtual string get_LocalName() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public virtual string get_NamespaceUri() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XObject), Member = "get_Parent", ReturnType = typeof(XElement))]
	[Calls(Type = typeof(XAttributeWrapper), Member = "get_Attribute", ReturnType = typeof(XAttribute))]
	[Calls(Type = typeof(XContainerWrapper), Member = "WrapNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XObject)}, ReturnType = typeof(IXmlNode))]
	[CallsUnknownMethods(Count = 2)]
	public virtual IXmlNode get_ParentNode() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public virtual string get_Value() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XAttribute), Member = "set_Value", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	public virtual void set_Value(string value) { }

}

