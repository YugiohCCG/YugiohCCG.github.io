namespace System.Xml.Xsl;

public interface IXsltContextFunction
{

	public XPathResultType ReturnType
	{
		 get { } //Length: 0
	}

	public XPathResultType get_ReturnType() { }

	public object Invoke(XsltContext xsltContext, Object[] args, XPathNavigator docContext) { }

}

