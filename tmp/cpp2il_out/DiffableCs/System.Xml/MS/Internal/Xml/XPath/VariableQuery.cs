namespace MS.Internal.Xml.XPath;

internal sealed class VariableQuery : ExtensionQuery
{
	private IXsltContextVariable _variable; //Field offset: 0x38

	public virtual XPathResultType StaticType
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Query), Member = "GetXPathType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(XPathResultType))]
		[CallsDeduplicatedMethods(Count = 1)]
		 get { } //Length: 95
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ExtensionQuery), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	public VariableQuery(string name, string prefix) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ExtensionQuery), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExtensionQuery)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	private VariableQuery(VariableQuery other) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ExtensionQuery), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExtensionQuery)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	public virtual XPathNodeIterator Clone() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ExtensionQuery), Member = "ProcessResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(XPathException), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(XPathException))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	public virtual object Evaluate(XPathNodeIterator nodeIterator) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Query), Member = "GetXPathType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(XPathResultType))]
	[CallsDeduplicatedMethods(Count = 1)]
	public virtual XPathResultType get_StaticType() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ExtensionQuery), Member = "get_QName", ReturnType = typeof(string))]
	[Calls(Type = typeof(XPathException), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(XPathException))]
	[Calls(Type = typeof(XPathException), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(XPathException))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 9)]
	public virtual void SetXsltContext(XsltContext context) { }

}

