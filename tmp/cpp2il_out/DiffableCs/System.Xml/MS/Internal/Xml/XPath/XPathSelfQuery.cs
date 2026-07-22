namespace MS.Internal.Xml.XPath;

internal sealed class XPathSelfQuery : BaseAxisQuery
{

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public XPathSelfQuery(Query qyInput, string Name, string Prefix, XPathNodeType Type) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private XPathSelfQuery(XPathSelfQuery other) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public virtual XPathNavigator Advance() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public virtual XPathNodeIterator Clone() { }

}

