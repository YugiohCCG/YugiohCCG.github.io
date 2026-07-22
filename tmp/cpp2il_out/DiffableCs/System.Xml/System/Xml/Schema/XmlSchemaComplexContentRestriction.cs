namespace System.Xml.Schema;

public class XmlSchemaComplexContentRestriction : XmlSchemaContent
{
	private XmlSchemaParticle particle; //Field offset: 0x50
	private XmlSchemaObjectCollection attributes; //Field offset: 0x58
	private XmlSchemaAnyAttribute anyAttribute; //Field offset: 0x60
	private XmlQualifiedName baseTypeName; //Field offset: 0x68

	[XmlElement("anyAttribute")]
	public XmlSchemaAnyAttribute AnyAttribute
	{
		[CallerCount(Count = 84)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 set { } //Length: 13
	}

	[XmlElement("attribute", typeof(XmlSchemaAttribute))]
	[XmlElement("attributeGroup", typeof(XmlSchemaAttributeGroupRef))]
	public XmlSchemaObjectCollection Attributes
	{
		[CallerCount(Count = 10)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	[XmlAttribute("base")]
	public XmlQualifiedName BaseTypeName
	{
		[CallerCount(Count = 22)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CalledBy(Type = typeof(XsdBuilder), Member = "BuildComplexContentRestriction_Base", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XsdBuilder), typeof(string)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(XmlQualifiedName), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName), typeof(XmlQualifiedName)}, ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 2)]
		 set { } //Length: 160
	}

	[XmlElement("group", typeof(XmlSchemaGroupRef))]
	[XmlElement("choice", typeof(XmlSchemaChoice))]
	[XmlElement("all", typeof(XmlSchemaAll))]
	[XmlElement("sequence", typeof(XmlSchemaSequence))]
	public XmlSchemaParticle Particle
	{
		[CallerCount(Count = 16)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 set { } //Length: 13
	}

	[CalledBy(Type = typeof(XsdBuilder), Member = "InitComplexContentRestriction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XsdBuilder), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CollectionBase), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public XmlSchemaComplexContentRestriction() { }

	[CallerCount(Count = 84)]
	[DeduplicatedMethod]
	public XmlSchemaAnyAttribute get_AnyAttribute() { }

	[CallerCount(Count = 10)]
	[DeduplicatedMethod]
	public XmlSchemaObjectCollection get_Attributes() { }

	[CallerCount(Count = 22)]
	[DeduplicatedMethod]
	public XmlQualifiedName get_BaseTypeName() { }

	[CallerCount(Count = 16)]
	[DeduplicatedMethod]
	public XmlSchemaParticle get_Particle() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public void set_AnyAttribute(XmlSchemaAnyAttribute value) { }

	[CalledBy(Type = typeof(XsdBuilder), Member = "BuildComplexContentRestriction_Base", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XsdBuilder), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(XmlQualifiedName), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName), typeof(XmlQualifiedName)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 2)]
	public void set_BaseTypeName(XmlQualifiedName value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public void set_Particle(XmlSchemaParticle value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	internal void SetAttributes(XmlSchemaObjectCollection newAttributes) { }

}

