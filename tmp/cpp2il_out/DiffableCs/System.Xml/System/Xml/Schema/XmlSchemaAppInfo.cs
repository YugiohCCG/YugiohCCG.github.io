namespace System.Xml.Schema;

public class XmlSchemaAppInfo : XmlSchemaObject
{
	private string source; //Field offset: 0x38
	private XmlNode[] markup; //Field offset: 0x40

	[XmlAnyElement]
	[XmlText]
	public XmlNode[] Markup
	{
		[CallerCount(Count = 12)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 set { } //Length: 13
	}

	[XmlAttribute("source", DataType = "anyURI")]
	public string Source
	{
		[CallerCount(Count = 3)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 set { } //Length: 13
	}

	[CallerCount(Count = 2180)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public XmlSchemaAppInfo() { }

	[CallerCount(Count = 12)]
	[DeduplicatedMethod]
	public XmlNode[] get_Markup() { }

	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public void set_Markup(XmlNode[] value) { }

	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public void set_Source(string value) { }

}

