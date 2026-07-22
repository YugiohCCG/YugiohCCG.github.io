namespace System.Xml.Schema;

public class XmlSchemaIdentityConstraint : XmlSchemaAnnotated
{
	private string name; //Field offset: 0x50
	private XmlSchemaXPath selector; //Field offset: 0x58
	private XmlSchemaObjectCollection fields; //Field offset: 0x60
	private XmlQualifiedName qualifiedName; //Field offset: 0x68
	private CompiledIdentityConstraint compiledConstraint; //Field offset: 0x70

	[XmlIgnore]
	internal CompiledIdentityConstraint CompiledConstraint
	{
		[CallerCount(Count = 9)]
		[DeduplicatedMethod]
		internal get { } //Length: 5
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		internal set { } //Length: 13
	}

	[XmlElement("field", typeof(XmlSchemaXPath))]
	public XmlSchemaObjectCollection Fields
	{
		[CallerCount(Count = 84)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

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

	[XmlIgnore]
	public XmlQualifiedName QualifiedName
	{
		[CallerCount(Count = 22)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	[XmlElement("selector", typeof(XmlSchemaXPath))]
	public XmlSchemaXPath Selector
	{
		[CallerCount(Count = 10)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 set { } //Length: 13
	}

	[CalledBy(Type = typeof(XmlSchemaUnique), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSchemaKey), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CollectionBase), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public XmlSchemaIdentityConstraint() { }

	[CallerCount(Count = 9)]
	[DeduplicatedMethod]
	internal CompiledIdentityConstraint get_CompiledConstraint() { }

	[CallerCount(Count = 84)]
	[DeduplicatedMethod]
	public XmlSchemaObjectCollection get_Fields() { }

	[CallerCount(Count = 16)]
	[DeduplicatedMethod]
	public string get_Name() { }

	[CallerCount(Count = 16)]
	[DeduplicatedMethod]
	internal virtual string get_NameAttribute() { }

	[CallerCount(Count = 22)]
	[DeduplicatedMethod]
	public XmlQualifiedName get_QualifiedName() { }

	[CallerCount(Count = 10)]
	[DeduplicatedMethod]
	public XmlSchemaXPath get_Selector() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	internal void set_CompiledConstraint(CompiledIdentityConstraint value) { }

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
	public void set_Selector(XmlSchemaXPath value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	internal void SetQualifiedName(XmlQualifiedName value) { }

}

