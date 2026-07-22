namespace MS.Internal.Xml.XPath;

internal sealed class NumericExpr : ValueQuery
{
	private Op _op; //Field offset: 0x18
	private Query _opnd1; //Field offset: 0x20
	private Query _opnd2; //Field offset: 0x28

	public virtual XPathResultType StaticType
	{
		[CallerCount(Count = 182)]
		[DeduplicatedMethod]
		 get { } //Length: 3
	}

	[CalledBy(Type = typeof(QueryBuilder), Member = "ProcessOperator", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Operator), typeof(Props&)}, ReturnType = typeof(Query))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 5)]
	public NumericExpr(Op op, Query opnd1, Query opnd2) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Query), Member = "Clone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Query)}, ReturnType = typeof(Query))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	private NumericExpr(NumericExpr other) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Query), Member = "Clone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Query)}, ReturnType = typeof(Query))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public virtual XPathNodeIterator Clone() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlConvert), Member = "ToXPathDouble", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(double))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	public virtual object Evaluate(XPathNodeIterator nodeIterator) { }

	[CallerCount(Count = 182)]
	[DeduplicatedMethod]
	public virtual XPathResultType get_StaticType() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private static double GetValue(Op op, double n1, double n2) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public virtual void SetXsltContext(XsltContext context) { }

}

