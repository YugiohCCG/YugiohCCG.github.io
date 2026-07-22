namespace MS.Internal.Xml.XPath;

internal sealed class ParentQuery : CacheAxisQuery
{

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CacheAxisQuery), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Query), typeof(string), typeof(string), typeof(XPathNodeType)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	public ParentQuery(Query qyInput, string Name, string Prefix, XPathNodeType Type) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CacheAxisQuery), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CacheAxisQuery)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	private ParentQuery(ParentQuery other) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CacheAxisQuery), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CacheAxisQuery)}, ReturnType = typeof(void))]
	public virtual XPathNodeIterator Clone() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CacheAxisQuery), Member = "Evaluate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XPathNodeIterator)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(Query), Member = "Insert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<System.Xml.XPath.XPathNavigator>), typeof(XPathNavigator)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	public virtual object Evaluate(XPathNodeIterator context) { }

}

