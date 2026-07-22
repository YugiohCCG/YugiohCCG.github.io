namespace System.Xml.Schema;

public class XmlSchemaNotation : XmlSchemaAnnotated
{
	private string name; //Field offset: 0x50
	private string publicId; //Field offset: 0x58
	private string systemId; //Field offset: 0x60
	private XmlQualifiedName qname; //Field offset: 0x68

	[XmlAttribute("name")]
	public string Name
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
	internal virtual string NameAttribute
	{
		[CallerCount(Count = 16)]
		[DeduplicatedMethod]
		internal get { } //Length: 5
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		internal set { } //Length: 13
	}

	[XmlAttribute("public")]
	public string Public
	{
		[CallerCount(Count = 10)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 set { } //Length: 13
	}

	[XmlIgnore]
	internal XmlQualifiedName QualifiedName
	{
		[CallerCount(Count = 22)]
		[DeduplicatedMethod]
		internal get { } //Length: 5
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		internal set { } //Length: 13
	}

	[XmlAttribute("system")]
	public string System
	{
		[CallerCount(Count = 84)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 set { } //Length: 13
	}

	[CalledBy(Type = typeof(XsdBuilder), Member = "InitNotation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XsdBuilder), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public XmlSchemaNotation() { }

	[CallerCount(Count = 16)]
	[DeduplicatedMethod]
	public string get_Name() { }

	[CallerCount(Count = 16)]
	[DeduplicatedMethod]
	internal virtual string get_NameAttribute() { }

	[CallerCount(Count = 10)]
	[DeduplicatedMethod]
	public string get_Public() { }

	[CallerCount(Count = 22)]
	[DeduplicatedMethod]
	internal XmlQualifiedName get_QualifiedName() { }

	[CallerCount(Count = 84)]
	[DeduplicatedMethod]
	public string get_System() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public void set_Name(string value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	internal virtual void set_NameAttribute(string value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public void set_Public(string value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	internal void set_QualifiedName(XmlQualifiedName value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public void set_System(string value) { }

}

