namespace MS.Internal.Xml.XPath;

internal sealed class UnionExpr : Query
{
	internal Query qy1; //Field offset: 0x18
	internal Query qy2; //Field offset: 0x20
	private bool _advance1; //Field offset: 0x28
	private bool _advance2; //Field offset: 0x29
	private XPathNavigator _currentNode; //Field offset: 0x30
	private XPathNavigator _nextNode; //Field offset: 0x38

	public virtual XPathNavigator Current
	{
		[CallerCount(Count = 62)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public virtual int CurrentPosition
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		 get { } //Length: 62
	}

	public virtual XPathResultType StaticType
	{
		[CallerCount(Count = 6)]
		[DeduplicatedMethod]
		 get { } //Length: 6
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public UnionExpr(Query query1, Query query2) { }

	[CalledBy(Type = typeof(UnionExpr), Member = "Clone", ReturnType = typeof(XPathNodeIterator))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 7)]
	private UnionExpr(UnionExpr other) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Query), Member = "CompareNodes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XPathNavigator), typeof(XPathNavigator)}, ReturnType = typeof(XmlNodeOrder))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 9)]
	public virtual XPathNavigator Advance() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnionExpr), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnionExpr)}, ReturnType = typeof(void))]
	public virtual XPathNodeIterator Clone() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public virtual object Evaluate(XPathNodeIterator context) { }

	[CallerCount(Count = 62)]
	[DeduplicatedMethod]
	public virtual XPathNavigator get_Current() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public virtual int get_CurrentPosition() { }

	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	public virtual XPathResultType get_StaticType() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private XPathNavigator ProcessAfterPosition(XPathNavigator res1, XPathNavigator res2) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private XPathNavigator ProcessBeforePosition(XPathNavigator res1, XPathNavigator res2) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private XPathNavigator ProcessSamePosition(XPathNavigator result) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public virtual void Reset() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public virtual void SetXsltContext(XsltContext xsltContext) { }

}

