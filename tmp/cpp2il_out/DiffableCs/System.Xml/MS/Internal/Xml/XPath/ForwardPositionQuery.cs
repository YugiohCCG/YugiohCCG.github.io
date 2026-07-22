namespace MS.Internal.Xml.XPath;

internal class ForwardPositionQuery : CacheOutputQuery
{

	[CallerCount(Count = 7)]
	[Calls(Type = typeof(CacheOutputQuery), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Query)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	public ForwardPositionQuery(Query input) { }

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CacheOutputQuery), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CacheOutputQuery)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	protected ForwardPositionQuery(ForwardPositionQuery other) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CacheOutputQuery), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CacheOutputQuery)}, ReturnType = typeof(void))]
	public virtual XPathNodeIterator Clone() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CacheOutputQuery), Member = "Evaluate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XPathNodeIterator)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public virtual object Evaluate(XPathNodeIterator context) { }

}

