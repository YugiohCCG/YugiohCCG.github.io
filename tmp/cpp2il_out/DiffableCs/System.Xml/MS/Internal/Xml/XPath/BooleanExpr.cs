namespace MS.Internal.Xml.XPath;

internal sealed class BooleanExpr : ValueQuery
{
	private Query _opnd1; //Field offset: 0x18
	private Query _opnd2; //Field offset: 0x20
	private bool _isOr; //Field offset: 0x28

	public virtual XPathResultType StaticType
	{
		[CallerCount(Count = 8)]
		[DeduplicatedMethod]
		 get { } //Length: 6
	}

	[CalledBy(Type = typeof(QueryBuilder), Member = "ProcessFilter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Filter), "MS.Internal.Xml.XPath.QueryBuilder+Flags", typeof(Props&)}, ReturnType = typeof(Query))]
	[CalledBy(Type = typeof(QueryBuilder), Member = "ProcessOperator", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Operator), typeof(Props&)}, ReturnType = typeof(Query))]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 5)]
	[ContainsUnimplementedInstructions]
	public BooleanExpr(Op op, Query opnd1, Query opnd2) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Query), Member = "Clone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Query)}, ReturnType = typeof(Query))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private BooleanExpr(BooleanExpr other) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Query), Member = "Clone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Query)}, ReturnType = typeof(Query))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public virtual XPathNodeIterator Clone() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public virtual object Evaluate(XPathNodeIterator nodeIterator) { }

	[CallerCount(Count = 8)]
	[DeduplicatedMethod]
	public virtual XPathResultType get_StaticType() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public virtual void SetXsltContext(XsltContext context) { }

}

