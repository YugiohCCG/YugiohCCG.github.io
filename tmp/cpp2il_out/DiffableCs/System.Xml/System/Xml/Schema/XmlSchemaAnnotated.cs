namespace System.Xml.Schema;

public class XmlSchemaAnnotated : XmlSchemaObject
{
	private string id; //Field offset: 0x38
	private XmlSchemaAnnotation annotation; //Field offset: 0x40
	private XmlAttribute[] moreAttributes; //Field offset: 0x48

	[XmlElement("annotation", typeof(XmlSchemaAnnotation))]
	public XmlSchemaAnnotation Annotation
	{
		[CallerCount(Count = 12)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 set { } //Length: 13
	}

	[XmlAttribute("id", DataType = "ID")]
	public string Id
	{
		[CallerCount(Count = 38)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 3)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 set { } //Length: 13
	}

	[XmlIgnore]
	internal virtual string IdAttribute
	{
		[CallerCount(Count = 38)]
		[DeduplicatedMethod]
		internal get { } //Length: 5
		[CallerCount(Count = 3)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		internal set { } //Length: 13
	}

	[XmlAnyAttribute]
	public XmlAttribute[] UnhandledAttributes
	{
		[CallerCount(Count = 10)]
		[DeduplicatedMethod]
		 get { } //Length: 254
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 set { } //Length: 13
	}

	[CallerCount(Count = 2180)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public XmlSchemaAnnotated() { }

	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	internal virtual void AddAnnotation(XmlSchemaAnnotation annotation) { }

	[CallerCount(Count = 12)]
	[DeduplicatedMethod]
	public XmlSchemaAnnotation get_Annotation() { }

	[CallerCount(Count = 38)]
	[DeduplicatedMethod]
	public string get_Id() { }

	[CallerCount(Count = 38)]
	[DeduplicatedMethod]
	internal virtual string get_IdAttribute() { }

	[CallerCount(Count = 10)]
	[DeduplicatedMethod]
	public XmlAttribute[] get_UnhandledAttributes() { }

	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public void set_Annotation(XmlSchemaAnnotation value) { }

	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public void set_Id(string value) { }

	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	internal virtual void set_IdAttribute(string value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public void set_UnhandledAttributes(XmlAttribute[] value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	internal virtual void SetUnhandledAttributes(XmlAttribute[] moreAttributes) { }

}

