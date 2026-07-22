namespace System.Xml.Schema;

public abstract class XmlSchemaContentModel : XmlSchemaAnnotated
{

	[XmlIgnore]
	public abstract XmlSchemaContent Content
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	[CallerCount(Count = 2180)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	protected XmlSchemaContentModel() { }

	public abstract XmlSchemaContent get_Content() { }

	public abstract void set_Content(XmlSchemaContent value) { }

}

