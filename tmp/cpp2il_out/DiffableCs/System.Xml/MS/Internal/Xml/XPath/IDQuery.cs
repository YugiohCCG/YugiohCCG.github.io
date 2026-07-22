namespace MS.Internal.Xml.XPath;

internal sealed class IDQuery : CacheOutputQuery
{

	[CallerCount(Count = 7)]
	[Calls(Type = typeof(CacheOutputQuery), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Query)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	public IDQuery(Query arg) { }

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CacheOutputQuery), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CacheOutputQuery)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	private IDQuery(IDQuery other) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CacheOutputQuery), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CacheOutputQuery)}, ReturnType = typeof(void))]
	public virtual XPathNodeIterator Clone() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CacheOutputQuery), Member = "Evaluate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XPathNodeIterator)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(Query), Member = "GetXPathType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(XPathResultType))]
	[Calls(Type = typeof(XmlConvert), Member = "SplitString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(String[]))]
	[Calls(Type = typeof(Query), Member = "Insert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<System.Xml.XPath.XPathNavigator>), typeof(XPathNavigator)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(StringFunctions), Member = "toString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(StringFunctions), Member = "toString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallsUnknownMethods(Count = 6)]
	public virtual object Evaluate(XPathNodeIterator context) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlConvert), Member = "SplitString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(String[]))]
	[Calls(Type = typeof(Query), Member = "Insert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<System.Xml.XPath.XPathNavigator>), typeof(XPathNavigator)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void ProcessIds(XPathNavigator contextNode, string val) { }

}

