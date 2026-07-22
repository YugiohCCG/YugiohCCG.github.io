namespace System.Xml.Xsl;

public abstract class XsltContext : XmlNamespaceManager
{

	public abstract bool Whitespace
	{
		 get { } //Length: 0
	}

	[CallerCount(Count = 162)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	internal XsltContext(bool dummy) { }

	public abstract bool get_Whitespace() { }

	public abstract bool PreserveWhitespace(XPathNavigator node) { }

	public abstract IXsltContextFunction ResolveFunction(string prefix, string name, XPathResultType[] ArgTypes) { }

	public abstract IXsltContextVariable ResolveVariable(string prefix, string name) { }

}

