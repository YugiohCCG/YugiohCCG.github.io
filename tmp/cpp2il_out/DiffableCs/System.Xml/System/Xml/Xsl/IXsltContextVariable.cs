namespace System.Xml.Xsl;

public interface IXsltContextVariable
{

	public XPathResultType VariableType
	{
		 get { } //Length: 0
	}

	public object Evaluate(XsltContext xsltContext) { }

	public XPathResultType get_VariableType() { }

}

