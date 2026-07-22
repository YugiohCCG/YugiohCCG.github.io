namespace MS.Internal.Xml.XPath;

internal class ChildrenQuery : BaseAxisQuery
{
	private XPathNodeIterator _iterator; //Field offset: 0x58

	[CalledBy(Type = typeof(QueryBuilder), Member = "ProcessAxis", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Axis), "MS.Internal.Xml.XPath.QueryBuilder+Flags", typeof(Props&)}, ReturnType = typeof(Query))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	[ContainsUnimplementedInstructions]
	public ChildrenQuery(Query qyInput, string name, string prefix, XPathNodeType type) { }

	[CalledBy(Type = typeof(CacheChildrenQuery), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CacheChildrenQuery)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CacheChildrenQuery), Member = "Clone", ReturnType = typeof(XPathNodeIterator))]
	[CalledBy(Type = typeof(ChildrenQuery), Member = "Clone", ReturnType = typeof(XPathNodeIterator))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Query), Member = "Clone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Query)}, ReturnType = typeof(Query))]
	[Calls(Type = typeof(Query), Member = "Clone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XPathNodeIterator)}, ReturnType = typeof(XPathNodeIterator))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 8)]
	protected ChildrenQuery(ChildrenQuery other) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(IteratorFilter), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XPathNodeIterator), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 3)]
	public virtual XPathNavigator Advance() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ChildrenQuery), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ChildrenQuery)}, ReturnType = typeof(void))]
	public virtual XPathNodeIterator Clone() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public virtual void Reset() { }

}

