namespace System.Xml.Schema;

public class XmlSchemaAttribute : XmlSchemaAnnotated
{
	private string defaultValue; //Field offset: 0x50
	private string fixedValue; //Field offset: 0x58
	private string name; //Field offset: 0x60
	private XmlSchemaForm form; //Field offset: 0x68
	private XmlSchemaUse use; //Field offset: 0x6C
	private XmlQualifiedName refName; //Field offset: 0x70
	private XmlQualifiedName typeName; //Field offset: 0x78
	private XmlQualifiedName qualifiedName; //Field offset: 0x80
	private XmlSchemaSimpleType type; //Field offset: 0x88
	private XmlSchemaSimpleType attributeType; //Field offset: 0x90
	private SchemaAttDef attDef; //Field offset: 0x98

	internal SchemaAttDef AttDef
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		internal get { } //Length: 8
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		internal set { } //Length: 19
	}

	[XmlIgnore]
	public XmlSchemaSimpleType AttributeSchemaType
	{
		[CallerCount(Count = 57)]
		[DeduplicatedMethod]
		 get { } //Length: 8
	}

	[XmlIgnore]
	internal XmlSchemaDatatype Datatype
	{
		[CalledBy(Type = typeof(SchemaCollectionCompiler), Member = "CompileComplexType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaComplexType)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		internal get { } //Length: 25
	}

	[DefaultValue(null)]
	[XmlAttribute("default")]
	public string DefaultValue
	{
		[CallerCount(Count = 16)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 set { } //Length: 13
	}

	[DefaultValue(null)]
	[XmlAttribute("fixed")]
	public string FixedValue
	{
		[CallerCount(Count = 10)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 set { } //Length: 13
	}

	[DefaultValue(XmlSchemaForm::None (0))]
	[XmlAttribute("form")]
	public XmlSchemaForm Form
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 4
		[CallerCount(Count = 10)]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	[XmlAttribute("name")]
	public string Name
	{
		[CallerCount(Count = 84)]
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
		[CallerCount(Count = 84)]
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
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 8
	}

	[XmlAttribute("ref")]
	public XmlQualifiedName RefName
	{
		[CallerCount(Count = 9)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CalledBy(Type = typeof(XmlSchemaInference), Member = "AddAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(string), typeof(bool), typeof(XmlSchema), typeof(XmlSchemaObjectCollection), typeof(XmlSchemaObjectTable)}, ReturnType = typeof(XmlSchemaAttribute))]
		[CalledBy(Type = typeof(Preprocessor), Member = "GetBuildInSchema", ReturnType = typeof(XmlSchema))]
		[CalledBy(Type = typeof(XsdBuilder), Member = "BuildAttribute_Ref", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XsdBuilder), typeof(string)}, ReturnType = typeof(void))]
		[CallerCount(Count = 6)]
		[Calls(Type = typeof(XmlQualifiedName), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName), typeof(XmlQualifiedName)}, ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 2)]
		 set { } //Length: 160
	}

	[XmlElement("simpleType")]
	public XmlSchemaSimpleType SchemaType
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 8
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 set { } //Length: 19
	}

	[XmlAttribute("type")]
	public XmlQualifiedName SchemaTypeName
	{
		[CallerCount(Count = 7)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CalledBy(Type = typeof(XmlSchemaInference), Member = "AddAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(string), typeof(bool), typeof(XmlSchema), typeof(XmlSchemaObjectCollection), typeof(XmlSchemaObjectTable)}, ReturnType = typeof(XmlSchemaAttribute))]
		[CalledBy(Type = typeof(Preprocessor), Member = "GetBuildInSchema", ReturnType = typeof(XmlSchema))]
		[CalledBy(Type = typeof(XsdBuilder), Member = "BuildAttribute_Type", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XsdBuilder), typeof(string)}, ReturnType = typeof(void))]
		[CallerCount(Count = 7)]
		[Calls(Type = typeof(XmlQualifiedName), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName), typeof(XmlQualifiedName)}, ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 2)]
		 set { } //Length: 160
	}

	[DefaultValue(XmlSchemaUse::None (0))]
	[XmlAttribute("use")]
	public XmlSchemaUse Use
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 4
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	[CalledBy(Type = typeof(XmlSchemaInference), Member = "AddAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(string), typeof(bool), typeof(XmlSchema), typeof(XmlSchemaObjectCollection), typeof(XmlSchemaObjectTable)}, ReturnType = typeof(XmlSchemaAttribute))]
	[CalledBy(Type = typeof(Preprocessor), Member = "GetBuildInSchema", ReturnType = typeof(XmlSchema))]
	[CalledBy(Type = typeof(XsdBuilder), Member = "InitAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XsdBuilder), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 11)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public XmlSchemaAttribute() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlQualifiedName), Member = "Clone", ReturnType = typeof(XmlQualifiedName))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	internal virtual XmlSchemaObject Clone() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	internal SchemaAttDef get_AttDef() { }

	[CallerCount(Count = 57)]
	[DeduplicatedMethod]
	public XmlSchemaSimpleType get_AttributeSchemaType() { }

	[CalledBy(Type = typeof(SchemaCollectionCompiler), Member = "CompileComplexType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaComplexType)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	internal XmlSchemaDatatype get_Datatype() { }

	[CallerCount(Count = 16)]
	[DeduplicatedMethod]
	public string get_DefaultValue() { }

	[CallerCount(Count = 10)]
	[DeduplicatedMethod]
	public string get_FixedValue() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public XmlSchemaForm get_Form() { }

	[CallerCount(Count = 84)]
	[DeduplicatedMethod]
	public string get_Name() { }

	[CallerCount(Count = 84)]
	[DeduplicatedMethod]
	internal virtual string get_NameAttribute() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public XmlQualifiedName get_QualifiedName() { }

	[CallerCount(Count = 9)]
	[DeduplicatedMethod]
	public XmlQualifiedName get_RefName() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public XmlSchemaSimpleType get_SchemaType() { }

	[CallerCount(Count = 7)]
	[DeduplicatedMethod]
	public XmlQualifiedName get_SchemaTypeName() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public XmlSchemaUse get_Use() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	internal void set_AttDef(SchemaAttDef value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public void set_DefaultValue(string value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public void set_FixedValue(string value) { }

	[CallerCount(Count = 10)]
	[DeduplicatedMethod]
	public void set_Form(XmlSchemaForm value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public void set_Name(string value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	internal virtual void set_NameAttribute(string value) { }

	[CalledBy(Type = typeof(XmlSchemaInference), Member = "AddAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(string), typeof(bool), typeof(XmlSchema), typeof(XmlSchemaObjectCollection), typeof(XmlSchemaObjectTable)}, ReturnType = typeof(XmlSchemaAttribute))]
	[CalledBy(Type = typeof(Preprocessor), Member = "GetBuildInSchema", ReturnType = typeof(XmlSchema))]
	[CalledBy(Type = typeof(XsdBuilder), Member = "BuildAttribute_Ref", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XsdBuilder), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(XmlQualifiedName), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName), typeof(XmlQualifiedName)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 2)]
	public void set_RefName(XmlQualifiedName value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public void set_SchemaType(XmlSchemaSimpleType value) { }

	[CalledBy(Type = typeof(XmlSchemaInference), Member = "AddAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(string), typeof(bool), typeof(XmlSchema), typeof(XmlSchemaObjectCollection), typeof(XmlSchemaObjectTable)}, ReturnType = typeof(XmlSchemaAttribute))]
	[CalledBy(Type = typeof(Preprocessor), Member = "GetBuildInSchema", ReturnType = typeof(XmlSchema))]
	[CalledBy(Type = typeof(XsdBuilder), Member = "BuildAttribute_Type", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XsdBuilder), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(XmlQualifiedName), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName), typeof(XmlQualifiedName)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 2)]
	public void set_SchemaTypeName(XmlQualifiedName value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void set_Use(XmlSchemaUse value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	internal void SetAttributeType(XmlSchemaSimpleType value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	internal void SetQualifiedName(XmlQualifiedName value) { }

}

