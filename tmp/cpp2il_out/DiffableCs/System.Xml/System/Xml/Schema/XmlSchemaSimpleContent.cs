namespace System.Xml.Schema;

public class XmlSchemaSimpleContent : XmlSchemaContentModel
{
	private XmlSchemaContent content; //Field offset: 0x50

	[XmlElement("extension", typeof(XmlSchemaSimpleContentExtension))]
	[XmlElement("restriction", typeof(XmlSchemaSimpleContentRestriction))]
	public virtual XmlSchemaContent Content
	{
		[CallerCount(Count = 16)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 set { } //Length: 13
	}

	[CallerCount(Count = 162)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public XmlSchemaSimpleContent() { }

	[CallerCount(Count = 16)]
	[DeduplicatedMethod]
	public virtual XmlSchemaContent get_Content() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public virtual void set_Content(XmlSchemaContent value) { }

}

