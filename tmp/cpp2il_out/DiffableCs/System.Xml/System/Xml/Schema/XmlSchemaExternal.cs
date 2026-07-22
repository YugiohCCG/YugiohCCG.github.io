namespace System.Xml.Schema;

public abstract class XmlSchemaExternal : XmlSchemaObject
{
	private string location; //Field offset: 0x38
	private Uri baseUri; //Field offset: 0x40
	private XmlSchema schema; //Field offset: 0x48
	private string id; //Field offset: 0x50
	private XmlAttribute[] moreAttributes; //Field offset: 0x58
	private Compositor compositor; //Field offset: 0x60

	[XmlIgnore]
	internal Uri BaseUri
	{
		[CallerCount(Count = 12)]
		[DeduplicatedMethod]
		internal get { } //Length: 5
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		internal set { } //Length: 13
	}

	internal Compositor Compositor
	{
		[CallerCount(Count = 3)]
		[DeduplicatedMethod]
		internal get { } //Length: 4
		[CallerCount(Count = 16)]
		[DeduplicatedMethod]
		internal set { } //Length: 4
	}

	[XmlAttribute("id", DataType = "ID")]
	public string Id
	{
		[CallerCount(Count = 16)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 set { } //Length: 13
	}

	[XmlIgnore]
	internal virtual string IdAttribute
	{
		[CallerCount(Count = 16)]
		[DeduplicatedMethod]
		internal get { } //Length: 5
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		internal set { } //Length: 13
	}

	[XmlIgnore]
	public XmlSchema Schema
	{
		[CallerCount(Count = 10)]
		[DeduplicatedMethod]
		 get { } //Length: 254
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 set { } //Length: 13
	}

	[XmlAttribute("schemaLocation", DataType = "anyURI")]
	public string SchemaLocation
	{
		[CallerCount(Count = 38)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 3)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 set { } //Length: 13
	}

	[CallerCount(Count = 2180)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	protected XmlSchemaExternal() { }

	[CallerCount(Count = 12)]
	[DeduplicatedMethod]
	internal Uri get_BaseUri() { }

	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	internal Compositor get_Compositor() { }

	[CallerCount(Count = 16)]
	[DeduplicatedMethod]
	public string get_Id() { }

	[CallerCount(Count = 16)]
	[DeduplicatedMethod]
	internal virtual string get_IdAttribute() { }

	[CallerCount(Count = 10)]
	[DeduplicatedMethod]
	public XmlSchema get_Schema() { }

	[CallerCount(Count = 38)]
	[DeduplicatedMethod]
	public string get_SchemaLocation() { }

	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	internal void set_BaseUri(Uri value) { }

	[CallerCount(Count = 16)]
	[DeduplicatedMethod]
	internal void set_Compositor(Compositor value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public void set_Id(string value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	internal virtual void set_IdAttribute(string value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public void set_Schema(XmlSchema value) { }

	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public void set_SchemaLocation(string value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	internal virtual void SetUnhandledAttributes(XmlAttribute[] moreAttributes) { }

}

