namespace System.Xml.XPath;

public abstract class XPathExpression
{

	[CallerCount(Count = 2180)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	internal XPathExpression() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(QueryBuilder), Member = "Build", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Boolean&)}, ReturnType = typeof(Query))]
	[Calls(Type = typeof(CompiledXpathExpr), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Query), typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static XPathExpression Compile(string xpath) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(QueryBuilder), Member = "Build", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Boolean&)}, ReturnType = typeof(Query))]
	[Calls(Type = typeof(CompiledXpathExpr), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Query), typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public static XPathExpression Compile(string xpath, IXmlNamespaceResolver nsResolver) { }

	public abstract void SetContext(XmlNamespaceManager nsManager) { }

	public abstract void SetContext(IXmlNamespaceResolver nsResolver) { }

}

