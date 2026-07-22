namespace MS.Internal.Xml.XPath;

internal class PreSiblingQuery : CacheAxisQuery
{

	public virtual QueryProps Properties
	{
		[CallerCount(Count = 3)]
		[DeduplicatedMethod]
		 get { } //Length: 6
	}

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CacheAxisQuery), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Query), typeof(string), typeof(string), typeof(XPathNodeType)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	public PreSiblingQuery(Query qyInput, string name, string prefix, XPathNodeType typeTest) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CacheAxisQuery), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CacheAxisQuery)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	protected PreSiblingQuery(PreSiblingQuery other) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CacheAxisQuery), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CacheAxisQuery)}, ReturnType = typeof(void))]
	public virtual XPathNodeIterator Clone() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CacheAxisQuery), Member = "Evaluate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XPathNodeIterator)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(System.Collections.Generic.Stack`1<System.Object>), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Stack`1<System.Object>), Member = "Pop", ReturnType = typeof(object))]
	[Calls(Type = typeof(PreSiblingQuery), Member = "NotVisited", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XPathNavigator), typeof(System.Collections.Generic.List`1<System.Xml.XPath.XPathNavigator>)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Query), Member = "Insert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<System.Xml.XPath.XPathNavigator>), typeof(XPathNavigator)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 12)]
	[CallsUnknownMethods(Count = 2)]
	public virtual object Evaluate(XPathNodeIterator context) { }

	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	public virtual QueryProps get_Properties() { }

	[CalledBy(Type = typeof(PreSiblingQuery), Member = "Evaluate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XPathNodeIterator)}, ReturnType = typeof(object))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 2)]
	private static bool NotVisited(XPathNavigator nav, List<XPathNavigator> parentStk) { }

}

