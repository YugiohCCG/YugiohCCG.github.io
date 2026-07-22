namespace MS.Internal.Xml.XPath;

internal sealed class FunctionQuery : ExtensionQuery
{
	private IList<Query> _args; //Field offset: 0x38
	private IXsltContextFunction _function; //Field offset: 0x40

	public virtual XPathResultType StaticType
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 78
	}

	[CalledBy(Type = typeof(QueryBuilder), Member = "ProcessFunction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Function), typeof(Props&)}, ReturnType = typeof(Query))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public FunctionQuery(string prefix, string name, List<Query> args) { }

	[CalledBy(Type = typeof(FunctionQuery), Member = "Clone", ReturnType = typeof(XPathNodeIterator))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Query), Member = "Clone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XPathNodeIterator)}, ReturnType = typeof(XPathNodeIterator))]
	[Calls(Type = typeof(Query), Member = "Clone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Query)}, ReturnType = typeof(Query))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 17)]
	private FunctionQuery(FunctionQuery other) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FunctionQuery), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FunctionQuery)}, ReturnType = typeof(void))]
	public virtual XPathNodeIterator Clone() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XPathSelectionIterator), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XPathNavigator), typeof(Query)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ExtensionQuery), Member = "ProcessResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(XPathException), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(XPathException))]
	[Calls(Type = typeof(ExtensionQuery), Member = "get_QName", ReturnType = typeof(string))]
	[Calls(Type = typeof(XPathException), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(Exception)}, ReturnType = typeof(XPathException))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 24)]
	public virtual object Evaluate(XPathNodeIterator nodeIterator) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public virtual XPathResultType get_StaticType() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ExtensionQuery), Member = "get_QName", ReturnType = typeof(string))]
	[Calls(Type = typeof(XPathException), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(XPathException))]
	[Calls(Type = typeof(XPathException), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(XPathException))]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 22)]
	public virtual void SetXsltContext(XsltContext context) { }

}

