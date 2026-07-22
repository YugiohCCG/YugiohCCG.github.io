namespace MS.Internal.Xml.XPath;

internal sealed class DocumentOrderQuery : CacheOutputQuery
{

	[CallerCount(Count = 7)]
	[Calls(Type = typeof(CacheOutputQuery), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Query)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	public DocumentOrderQuery(Query qyParent) { }

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CacheOutputQuery), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CacheOutputQuery)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	private DocumentOrderQuery(DocumentOrderQuery other) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CacheOutputQuery), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CacheOutputQuery)}, ReturnType = typeof(void))]
	public virtual XPathNodeIterator Clone() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CacheOutputQuery), Member = "Evaluate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XPathNodeIterator)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(Query), Member = "Insert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<System.Xml.XPath.XPathNavigator>), typeof(XPathNavigator)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public virtual object Evaluate(XPathNodeIterator context) { }

}

