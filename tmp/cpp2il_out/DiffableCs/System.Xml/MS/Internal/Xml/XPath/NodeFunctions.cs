namespace MS.Internal.Xml.XPath;

internal sealed class NodeFunctions : ValueQuery
{
	private Query _arg; //Field offset: 0x18
	private FunctionType _funcType; //Field offset: 0x20
	private XsltContext _xsltContext; //Field offset: 0x28

	public virtual XPathResultType StaticType
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		 get { } //Length: 113
	}

	[CalledBy(Type = typeof(QueryBuilder), Member = "ProcessFilter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Filter), "MS.Internal.Xml.XPath.QueryBuilder+Flags", typeof(Props&)}, ReturnType = typeof(Query))]
	[CalledBy(Type = typeof(QueryBuilder), Member = "ProcessFunction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Function), typeof(Props&)}, ReturnType = typeof(Query))]
	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public NodeFunctions(FunctionType funcType, Query arg) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Query), Member = "Clone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Query)}, ReturnType = typeof(Query))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public virtual XPathNodeIterator Clone() { }

	[CallerCount(Count = 0)]
	[ContainsInvalidInstructions]
	public virtual object Evaluate(XPathNodeIterator context) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	private XPathNavigator EvaluateArg(XPathNodeIterator context) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public virtual XPathResultType get_StaticType() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public virtual void SetXsltContext(XsltContext context) { }

}

