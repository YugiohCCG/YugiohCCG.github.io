namespace MS.Internal.Xml.XPath;

internal class DescendantQuery : DescendantBaseQuery
{
	private XPathNodeIterator _nodeIterator; //Field offset: 0x60

	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	internal DescendantQuery(Query qyParent, string Name, string Prefix, XPathNodeType Type, bool matchSelf, bool abbrAxis) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DescendantBaseQuery), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DescendantBaseQuery)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Query), Member = "Clone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XPathNodeIterator)}, ReturnType = typeof(XPathNodeIterator))]
	[CallsUnknownMethods(Count = 2)]
	public DescendantQuery(DescendantQuery other) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 6)]
	public virtual XPathNavigator Advance() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DescendantBaseQuery), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DescendantBaseQuery)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Query), Member = "Clone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XPathNodeIterator)}, ReturnType = typeof(XPathNodeIterator))]
	[CallsUnknownMethods(Count = 2)]
	public virtual XPathNodeIterator Clone() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	public virtual void Reset() { }

}

