namespace MS.Internal.Xml.XPath;

internal sealed class XPathAncestorQuery : CacheAxisQuery
{
	private bool _matchSelf; //Field offset: 0x60

	public virtual int CurrentPosition
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 65
	}

	public virtual QueryProps Properties
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 19
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CacheAxisQuery), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Query), typeof(string), typeof(string), typeof(XPathNodeType)}, ReturnType = typeof(void))]
	public XPathAncestorQuery(Query qyInput, string name, string prefix, XPathNodeType typeTest, bool matchSelf) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CacheAxisQuery), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CacheAxisQuery)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private XPathAncestorQuery(XPathAncestorQuery other) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CacheAxisQuery), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CacheAxisQuery)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public virtual XPathNodeIterator Clone() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CacheAxisQuery), Member = "Evaluate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XPathNodeIterator)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(Query), Member = "Insert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<System.Xml.XPath.XPathNavigator>), typeof(XPathNavigator)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 1)]
	public virtual object Evaluate(XPathNodeIterator context) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public virtual int get_CurrentPosition() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public virtual QueryProps get_Properties() { }

}

