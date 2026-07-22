namespace MS.Internal.Xml.XPath;

internal sealed class PrecedingQuery : BaseAxisQuery
{
	private XPathNodeIterator _workIterator; //Field offset: 0x58
	private ClonableStack<XPathNavigator> _ancestorStk; //Field offset: 0x60

	public virtual QueryProps Properties
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		 get { } //Length: 19
	}

	[CalledBy(Type = typeof(QueryBuilder), Member = "ProcessAxis", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Axis), "MS.Internal.Xml.XPath.QueryBuilder+Flags", typeof(Props&)}, ReturnType = typeof(Query))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ClonableStack`1), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	[ContainsUnimplementedInstructions]
	public PrecedingQuery(Query qyInput, string name, string prefix, XPathNodeType typeTest) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Query), Member = "Clone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Query)}, ReturnType = typeof(Query))]
	[Calls(Type = typeof(Query), Member = "Clone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XPathNodeIterator)}, ReturnType = typeof(XPathNodeIterator))]
	[Calls(Type = typeof(MS.Internal.Xml.XPath.ClonableStack`1<System.Object>), Member = "Clone", ReturnType = typeof(MS.Internal.Xml.XPath.ClonableStack`1<System.Object>))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 8)]
	private PrecedingQuery(PrecedingQuery other) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MS.Internal.Xml.XPath.ClonableStack`1<System.Object>), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MS.Internal.Xml.XPath.ClonableStack`1<System.Object>), Member = "Peek", ReturnType = typeof(object))]
	[Calls(Type = typeof(MS.Internal.Xml.XPath.ClonableStack`1<System.Object>), Member = "Pop", ReturnType = typeof(object))]
	[CallsDeduplicatedMethods(Count = 14)]
	[CallsUnknownMethods(Count = 5)]
	public virtual XPathNavigator Advance() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Query), Member = "Clone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Query)}, ReturnType = typeof(Query))]
	[Calls(Type = typeof(Query), Member = "Clone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XPathNodeIterator)}, ReturnType = typeof(XPathNodeIterator))]
	[Calls(Type = typeof(MS.Internal.Xml.XPath.ClonableStack`1<System.Object>), Member = "Clone", ReturnType = typeof(MS.Internal.Xml.XPath.ClonableStack`1<System.Object>))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 8)]
	public virtual XPathNodeIterator Clone() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public virtual QueryProps get_Properties() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public virtual void Reset() { }

}

