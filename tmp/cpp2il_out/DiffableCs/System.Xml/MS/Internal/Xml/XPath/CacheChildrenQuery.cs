namespace MS.Internal.Xml.XPath;

internal sealed class CacheChildrenQuery : ChildrenQuery
{
	private XPathNavigator _nextInput; //Field offset: 0x60
	private ClonableStack<XPathNavigator> _elementStk; //Field offset: 0x68
	private ClonableStack<Int32> _positionStk; //Field offset: 0x70
	private bool _needInput; //Field offset: 0x78

	[CalledBy(Type = typeof(QueryBuilder), Member = "ProcessAxis", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Axis), "MS.Internal.Xml.XPath.QueryBuilder+Flags", typeof(Props&)}, ReturnType = typeof(Query))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ClonableStack`1), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 8)]
	[ContainsUnimplementedInstructions]
	public CacheChildrenQuery(Query qyInput, string name, string prefix, XPathNodeType type) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ChildrenQuery), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ChildrenQuery)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Query), Member = "Clone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XPathNavigator)}, ReturnType = typeof(XPathNavigator))]
	[Calls(Type = typeof(MS.Internal.Xml.XPath.ClonableStack`1<System.Object>), Member = "Clone", ReturnType = typeof(MS.Internal.Xml.XPath.ClonableStack`1<System.Object>))]
	[Calls(Type = typeof(ClonableStack`1), Member = "Clone", ReturnType = "MS.Internal.Xml.XPath.ClonableStack`1<T>")]
	[CallsUnknownMethods(Count = 4)]
	private CacheChildrenQuery(CacheChildrenQuery other) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Query), Member = "CompareNodes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XPathNavigator), typeof(XPathNavigator)}, ReturnType = typeof(XmlNodeOrder))]
	[Calls(Type = typeof(MS.Internal.Xml.XPath.ClonableStack`1<System.Object>), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ClonableStack`1), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MS.Internal.Xml.XPath.ClonableStack`1<System.Object>), Member = "Pop", ReturnType = typeof(object))]
	[Calls(Type = typeof(ClonableStack`1), Member = "Pop", ReturnType = "T")]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallsUnknownMethods(Count = 12)]
	public virtual XPathNavigator Advance() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ChildrenQuery), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ChildrenQuery)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Query), Member = "Clone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XPathNavigator)}, ReturnType = typeof(XPathNavigator))]
	[Calls(Type = typeof(MS.Internal.Xml.XPath.ClonableStack`1<System.Object>), Member = "Clone", ReturnType = typeof(MS.Internal.Xml.XPath.ClonableStack`1<System.Object>))]
	[Calls(Type = typeof(ClonableStack`1), Member = "Clone", ReturnType = "MS.Internal.Xml.XPath.ClonableStack`1<T>")]
	[CallsUnknownMethods(Count = 4)]
	public virtual XPathNodeIterator Clone() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Query), Member = "CompareNodes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XPathNavigator), typeof(XPathNavigator)}, ReturnType = typeof(XmlNodeOrder))]
	[Calls(Type = typeof(MS.Internal.Xml.XPath.ClonableStack`1<System.Object>), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ClonableStack`1), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 5)]
	private bool DecideNextNode() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	private XPathNavigator GetNextInput() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public virtual void Reset() { }

}

