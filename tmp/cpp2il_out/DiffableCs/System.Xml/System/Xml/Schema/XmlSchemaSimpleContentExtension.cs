namespace System.Xml.Schema;

public class XmlSchemaSimpleContentExtension : XmlSchemaContent
{
	private XmlSchemaObjectCollection attributes; //Field offset: 0x50
	private XmlSchemaAnyAttribute anyAttribute; //Field offset: 0x58
	private XmlQualifiedName baseTypeName; //Field offset: 0x60

	[XmlElement("anyAttribute")]
	public XmlSchemaAnyAttribute AnyAttribute
	{
		[CallerCount(Count = 10)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 set { } //Length: 13
	}

	[XmlElement("attributeGroup", typeof(XmlSchemaAttributeGroupRef))]
	[XmlElement("attribute", typeof(XmlSchemaAttribute))]
	public XmlSchemaObjectCollection Attributes
	{
		[CallerCount(Count = 16)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	[XmlAttribute("base")]
	public XmlQualifiedName BaseTypeName
	{
		[CallerCount(Count = 84)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CalledBy(Type = typeof(XmlSchemaInference), Member = "InferElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaElement), typeof(bool), typeof(XmlSchema)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XmlSchemaInference), Member = "ProcessAttributes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaElement&), typeof(XmlSchemaType), typeof(bool), typeof(XmlSchema)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XmlSchemaComplexType), Member = "Clone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchema)}, ReturnType = typeof(XmlSchemaObject))]
		[CalledBy(Type = typeof(XsdBuilder), Member = "BuildSimpleContentExtension_Base", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XsdBuilder), typeof(string)}, ReturnType = typeof(void))]
		[CallerCount(Count = 9)]
		[Calls(Type = typeof(XmlQualifiedName), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName), typeof(XmlQualifiedName)}, ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 2)]
		 set { } //Length: 160
	}

	[CalledBy(Type = typeof(XmlSchemaInference), Member = "InferElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaElement), typeof(bool), typeof(XmlSchema)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSchemaInference), Member = "ProcessAttributes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaElement&), typeof(XmlSchemaType), typeof(bool), typeof(XmlSchema)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XsdBuilder), Member = "InitSimpleContentExtension", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XsdBuilder), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public XmlSchemaSimpleContentExtension() { }

	[CallerCount(Count = 10)]
	[DeduplicatedMethod]
	public XmlSchemaAnyAttribute get_AnyAttribute() { }

	[CallerCount(Count = 16)]
	[DeduplicatedMethod]
	public XmlSchemaObjectCollection get_Attributes() { }

	[CallerCount(Count = 84)]
	[DeduplicatedMethod]
	public XmlQualifiedName get_BaseTypeName() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public void set_AnyAttribute(XmlSchemaAnyAttribute value) { }

	[CalledBy(Type = typeof(XmlSchemaInference), Member = "InferElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaElement), typeof(bool), typeof(XmlSchema)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSchemaInference), Member = "ProcessAttributes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaElement&), typeof(XmlSchemaType), typeof(bool), typeof(XmlSchema)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSchemaComplexType), Member = "Clone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchema)}, ReturnType = typeof(XmlSchemaObject))]
	[CalledBy(Type = typeof(XsdBuilder), Member = "BuildSimpleContentExtension_Base", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XsdBuilder), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(XmlQualifiedName), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName), typeof(XmlQualifiedName)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 2)]
	public void set_BaseTypeName(XmlQualifiedName value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	internal void SetAttributes(XmlSchemaObjectCollection newAttributes) { }

}

