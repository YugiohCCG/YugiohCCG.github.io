namespace Newtonsoft.Json.Converters;

[Nullable(0)]
[NullableContext(2)]
internal class XTextWrapper : XObjectWrapper
{

	public virtual IXmlNode ParentNode
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(XObject), Member = "get_Parent", ReturnType = typeof(XElement))]
		[Calls(Type = typeof(XTextWrapper), Member = "get_Text", ReturnType = typeof(XText))]
		[Calls(Type = typeof(XContainerWrapper), Member = "WrapNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XObject)}, ReturnType = typeof(IXmlNode))]
		[CallsUnknownMethods(Count = 2)]
		 get { } //Length: 162
	}

	[Nullable(1)]
	private XText Text
	{
		[CalledBy(Type = typeof(XTextWrapper), Member = "get_ParentNode", ReturnType = typeof(IXmlNode))]
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[NullableContext(1)]
		private get { } //Length: 107
	}

	public virtual string Value
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		 get { } //Length: 117
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(XText), Member = "set_Value", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 2)]
		 set { } //Length: 161
	}

	[CallerCount(Count = 98)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[NullableContext(1)]
	public XTextWrapper(XText text) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XObject), Member = "get_Parent", ReturnType = typeof(XElement))]
	[Calls(Type = typeof(XTextWrapper), Member = "get_Text", ReturnType = typeof(XText))]
	[Calls(Type = typeof(XContainerWrapper), Member = "WrapNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XObject)}, ReturnType = typeof(IXmlNode))]
	[CallsUnknownMethods(Count = 2)]
	public virtual IXmlNode get_ParentNode() { }

	[CalledBy(Type = typeof(XTextWrapper), Member = "get_ParentNode", ReturnType = typeof(IXmlNode))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[NullableContext(1)]
	private XText get_Text() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public virtual string get_Value() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XText), Member = "set_Value", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	public virtual void set_Value(string value) { }

}

