namespace MS.Internal.Xml.XPath;

internal abstract class DescendantBaseQuery : BaseAxisQuery
{
	protected bool matchSelf; //Field offset: 0x58
	protected bool abbrAxis; //Field offset: 0x59

	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public DescendantBaseQuery(Query qyParent, string Name, string Prefix, XPathNodeType Type, bool matchSelf, bool abbrAxis) { }

	[CalledBy(Type = typeof(DescendantQuery), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DescendantQuery)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DescendantQuery), Member = "Clone", ReturnType = typeof(XPathNodeIterator))]
	[CalledBy(Type = typeof(DescendantOverDescendantQuery), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DescendantOverDescendantQuery)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DescendantOverDescendantQuery), Member = "Clone", ReturnType = typeof(XPathNodeIterator))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Query), Member = "Clone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Query)}, ReturnType = typeof(Query))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	public DescendantBaseQuery(DescendantBaseQuery other) { }

}

