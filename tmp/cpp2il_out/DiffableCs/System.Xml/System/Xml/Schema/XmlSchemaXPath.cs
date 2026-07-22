namespace System.Xml.Schema;

public class XmlSchemaXPath : XmlSchemaAnnotated
{
	private string xpath; //Field offset: 0x50

	[DefaultValue(null)]
	[XmlAttribute("xpath")]
	public string XPath
	{
		[CallerCount(Count = 16)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 set { } //Length: 13
	}

	[CallerCount(Count = 2180)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public XmlSchemaXPath() { }

	[CallerCount(Count = 16)]
	[DeduplicatedMethod]
	public string get_XPath() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public void set_XPath(string value) { }

}

