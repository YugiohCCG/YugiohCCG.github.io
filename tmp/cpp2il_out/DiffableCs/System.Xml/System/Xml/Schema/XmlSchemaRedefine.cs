namespace System.Xml.Schema;

public class XmlSchemaRedefine : XmlSchemaExternal
{
	private XmlSchemaObjectCollection items; //Field offset: 0x68
	private XmlSchemaObjectTable attributeGroups; //Field offset: 0x70
	private XmlSchemaObjectTable types; //Field offset: 0x78
	private XmlSchemaObjectTable groups; //Field offset: 0x80

	[XmlIgnore]
	public XmlSchemaObjectTable AttributeGroups
	{
		[CallerCount(Count = 9)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	[XmlIgnore]
	public XmlSchemaObjectTable Groups
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 8
	}

	[XmlElement("annotation", typeof(XmlSchemaAnnotation))]
	[XmlElement("complexType", typeof(XmlSchemaComplexType))]
	[XmlElement("group", typeof(XmlSchemaGroup))]
	[XmlElement("simpleType", typeof(XmlSchemaSimpleType))]
	[XmlElement("attributeGroup", typeof(XmlSchemaAttributeGroup))]
	public XmlSchemaObjectCollection Items
	{
		[CallerCount(Count = 22)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	[XmlIgnore]
	public XmlSchemaObjectTable SchemaTypes
	{
		[CallerCount(Count = 7)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	[CalledBy(Type = typeof(XsdBuilder), Member = "InitRedefine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XsdBuilder), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(XmlSchemaObjectTable), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	public XmlSchemaRedefine() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlSchemaObjectCollection), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaObject)}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 1)]
	internal virtual void AddAnnotation(XmlSchemaAnnotation annotation) { }

	[CallerCount(Count = 9)]
	[DeduplicatedMethod]
	public XmlSchemaObjectTable get_AttributeGroups() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public XmlSchemaObjectTable get_Groups() { }

	[CallerCount(Count = 22)]
	[DeduplicatedMethod]
	public XmlSchemaObjectCollection get_Items() { }

	[CallerCount(Count = 7)]
	[DeduplicatedMethod]
	public XmlSchemaObjectTable get_SchemaTypes() { }

}

