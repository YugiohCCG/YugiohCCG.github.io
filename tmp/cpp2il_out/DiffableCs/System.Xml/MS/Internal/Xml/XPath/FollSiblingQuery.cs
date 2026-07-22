namespace MS.Internal.Xml.XPath;

internal sealed class FollSiblingQuery : BaseAxisQuery
{
	private ClonableStack<XPathNavigator> _elementStk; //Field offset: 0x58
	private List<XPathNavigator> _parentStk; //Field offset: 0x60
	private XPathNavigator _nextInput; //Field offset: 0x68

	[CalledBy(Type = typeof(QueryBuilder), Member = "ProcessAxis", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Axis), "MS.Internal.Xml.XPath.QueryBuilder+Flags", typeof(Props&)}, ReturnType = typeof(Query))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ClonableStack`1), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 7)]
	[ContainsUnimplementedInstructions]
	public FollSiblingQuery(Query qyInput, string name, string prefix, XPathNodeType type) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Query), Member = "Clone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Query)}, ReturnType = typeof(Query))]
	[Calls(Type = typeof(MS.Internal.Xml.XPath.ClonableStack`1<System.Object>), Member = "Clone", ReturnType = typeof(MS.Internal.Xml.XPath.ClonableStack`1<System.Object>))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Query), Member = "Clone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XPathNavigator)}, ReturnType = typeof(XPathNavigator))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 9)]
	private FollSiblingQuery(FollSiblingQuery other) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FollSiblingQuery), Member = "FetchInput", ReturnType = typeof(XPathNavigator))]
	[Calls(Type = typeof(MS.Internal.Xml.XPath.ClonableStack`1<System.Object>), Member = "Pop", ReturnType = typeof(object))]
	[Calls(Type = typeof(MS.Internal.Xml.XPath.ClonableStack`1<System.Object>), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 7)]
	public virtual XPathNavigator Advance() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Query), Member = "Clone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Query)}, ReturnType = typeof(Query))]
	[Calls(Type = typeof(MS.Internal.Xml.XPath.ClonableStack`1<System.Object>), Member = "Clone", ReturnType = typeof(MS.Internal.Xml.XPath.ClonableStack`1<System.Object>))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Query), Member = "Clone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XPathNavigator)}, ReturnType = typeof(XPathNavigator))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 9)]
	public virtual XPathNodeIterator Clone() { }

	[CalledBy(Type = typeof(FollSiblingQuery), Member = "Advance", ReturnType = typeof(XPathNavigator))]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 2)]
	private XPathNavigator FetchInput() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public virtual void Reset() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 2)]
	private bool Visited(XPathNavigator nav) { }

}

