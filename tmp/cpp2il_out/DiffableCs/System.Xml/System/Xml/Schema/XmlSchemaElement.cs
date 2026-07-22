namespace System.Xml.Schema;

public class XmlSchemaElement : XmlSchemaParticle
{
	private bool isAbstract; //Field offset: 0x78
	private bool hasAbstractAttribute; //Field offset: 0x79
	private bool isNillable; //Field offset: 0x7A
	private bool hasNillableAttribute; //Field offset: 0x7B
	private bool isLocalTypeDerivationChecked; //Field offset: 0x7C
	private XmlSchemaDerivationMethod block; //Field offset: 0x80
	private XmlSchemaDerivationMethod final; //Field offset: 0x84
	private XmlSchemaForm form; //Field offset: 0x88
	private string defaultValue; //Field offset: 0x90
	private string fixedValue; //Field offset: 0x98
	private string name; //Field offset: 0xA0
	private XmlQualifiedName refName; //Field offset: 0xA8
	private XmlQualifiedName substitutionGroup; //Field offset: 0xB0
	private XmlQualifiedName typeName; //Field offset: 0xB8
	private XmlSchemaType type; //Field offset: 0xC0
	private XmlQualifiedName qualifiedName; //Field offset: 0xC8
	private XmlSchemaType elementType; //Field offset: 0xD0
	private XmlSchemaDerivationMethod blockResolved; //Field offset: 0xD8
	private XmlSchemaDerivationMethod finalResolved; //Field offset: 0xDC
	private XmlSchemaObjectCollection constraints; //Field offset: 0xE0
	private SchemaElementDecl elementDecl; //Field offset: 0xE8

	[DefaultValue(XmlSchemaDerivationMethod::None (256))]
	[XmlAttribute("block")]
	public XmlSchemaDerivationMethod Block
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 7
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 set { } //Length: 7
	}

	[XmlIgnore]
	public XmlSchemaDerivationMethod BlockResolved
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 7
	}

	[XmlElement("key", typeof(XmlSchemaKey))]
	[XmlElement("keyref", typeof(XmlSchemaKeyref))]
	[XmlElement("unique", typeof(XmlSchemaUnique))]
	public XmlSchemaObjectCollection Constraints
	{
		[CalledBy(Type = typeof(Preprocessor), Member = "PreprocessElementContent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaElement)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(SchemaCollectionCompiler), Member = "CleanupElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaElement)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(SchemaCollectionCompiler), Member = "CompileElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaElement)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(SchemaCollectionPreprocessor), Member = "PreprocessElementContent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaElement)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Compiler), Member = "CleanupElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaElement)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Compiler), Member = "CompileElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaElement)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XsdBuilder), Member = "InitSimpleType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XsdBuilder), typeof(string)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XsdBuilder), Member = "InitComplexType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XsdBuilder), typeof(string)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XsdBuilder), Member = "InitIdentityConstraint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XsdBuilder), typeof(string)}, ReturnType = typeof(void))]
		[CalledBy(Type = "System.Data.XSDSchema", Member = "InstantiateSimpleTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaElement)}, ReturnType = "System.Data.DataTable")]
		[CalledBy(Type = "System.Data.XSDSchema", Member = "InstantiateTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaElement), typeof(XmlSchemaComplexType), typeof(bool)}, ReturnType = "System.Data.DataTable")]
		[CalledBy(Type = "System.Data.XSDSchema", Member = "HandleDataSet", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaElement), typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 22)]
		[Calls(Type = typeof(CollectionBase), Member = ".ctor", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 117
	}

	[DefaultValue(null)]
	[XmlAttribute("default")]
	public string DefaultValue
	{
		[CallerCount(Count = 57)]
		[DeduplicatedMethod]
		 get { } //Length: 8
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 set { } //Length: 19
	}

	internal SchemaElementDecl ElementDecl
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
	public XmlSchemaType ElementSchemaType
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 8
	}

	[DefaultValue(XmlSchemaDerivationMethod::None (256))]
	[XmlAttribute("final")]
	public XmlSchemaDerivationMethod Final
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 7
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 set { } //Length: 7
	}

	[XmlIgnore]
	public XmlSchemaDerivationMethod FinalResolved
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 7
	}

	[DefaultValue(null)]
	[XmlAttribute("fixed")]
	public string FixedValue
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 8
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 set { } //Length: 19
	}

	[DefaultValue(XmlSchemaForm::None (0))]
	[XmlAttribute("form")]
	public XmlSchemaForm Form
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 7
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 set { } //Length: 7
	}

	[XmlIgnore]
	internal bool HasAbstractAttribute
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		internal get { } //Length: 5
	}

	internal bool HasConstraints
	{
		[CalledBy(Type = typeof(Preprocessor), Member = "PreprocessLocalElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaElement)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(SchemaCollectionCompiler), Member = "CompileElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaElement)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(SchemaCollectionPreprocessor), Member = "PreprocessLocalElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaElement)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Compiler), Member = "CompileElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaElement)}, ReturnType = typeof(void))]
		[CallerCount(Count = 4)]
		[CallsDeduplicatedMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		internal get { } //Length: 45
	}

	[XmlIgnore]
	internal bool HasNillableAttribute
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		internal get { } //Length: 5
	}

	[DefaultValue(False)]
	[XmlAttribute("abstract")]
	public bool IsAbstract
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CalledBy(Type = typeof(XsdBuilder), Member = "BuildElement_Abstract", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XsdBuilder), typeof(string)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		 set { } //Length: 8
	}

	internal bool IsLocalTypeDerivationChecked
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		internal get { } //Length: 5
		[CallerCount(Count = 0)]
		internal set { } //Length: 4
	}

	[DefaultValue(False)]
	[XmlAttribute("nillable")]
	public bool IsNillable
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CalledBy(Type = typeof(XmlSchemaInference), Member = "ProcessAttributes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaElement&), typeof(XmlSchemaType), typeof(bool), typeof(XmlSchema)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XmlSchemaInference), Member = "CreateNewElementforChoice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaElement)}, ReturnType = typeof(XmlSchemaElement))]
		[CalledBy(Type = typeof(XsdBuilder), Member = "BuildElement_Nillable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XsdBuilder), typeof(string)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		 set { } //Length: 8
	}

	[DefaultValue(null)]
	[XmlAttribute("name")]
	public string Name
	{
		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		 get { } //Length: 8
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 set { } //Length: 19
	}

	[XmlIgnore]
	internal virtual string NameAttribute
	{
		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		internal get { } //Length: 8
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		internal set { } //Length: 19
	}

	[XmlIgnore]
	internal virtual string NameString
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		internal get { } //Length: 42
	}

	[XmlIgnore]
	public XmlQualifiedName QualifiedName
	{
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 8
	}

	[XmlAttribute("ref")]
	public XmlQualifiedName RefName
	{
		[CallerCount(Count = 4)]
		[DeduplicatedMethod]
		 get { } //Length: 8
		[CalledBy(Type = typeof(XmlSchemaInference), Member = "AddElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(XmlSchema), typeof(XmlSchemaObjectCollection), typeof(int)}, ReturnType = typeof(XmlSchemaElement))]
		[CalledBy(Type = typeof(XmlSchemaInference), Member = "CreateNewElementforChoice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaElement)}, ReturnType = typeof(XmlSchemaElement))]
		[CalledBy(Type = typeof(XsdBuilder), Member = "BuildElement_Ref", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XsdBuilder), typeof(string)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(XmlQualifiedName), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName), typeof(XmlQualifiedName)}, ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 2)]
		 set { } //Length: 166
	}

	[XmlElement("simpleType", typeof(XmlSchemaSimpleType))]
	[XmlElement("complexType", typeof(XmlSchemaComplexType))]
	public XmlSchemaType SchemaType
	{
		[CallerCount(Count = 2)]
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
		[CallerCount(Count = 17)]
		[DeduplicatedMethod]
		 get { } //Length: 8
		[CalledBy(Type = typeof(XmlSchemaInference), Member = "InferElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaElement), typeof(bool), typeof(XmlSchema)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XmlSchemaInference), Member = "ProcessAttributes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaElement&), typeof(XmlSchemaType), typeof(bool), typeof(XmlSchema)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XmlSchemaInference), Member = "CreateNewElementforChoice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaElement)}, ReturnType = typeof(XmlSchemaElement))]
		[CalledBy(Type = typeof(XmlSchemaValidator), Member = "GetSchemaElement", ReturnType = typeof(XmlSchemaElement))]
		[CalledBy(Type = typeof(XsdBuilder), Member = "BuildElement_Type", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XsdBuilder), typeof(string)}, ReturnType = typeof(void))]
		[CallerCount(Count = 9)]
		[Calls(Type = typeof(XmlQualifiedName), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName), typeof(XmlQualifiedName)}, ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 2)]
		 set { } //Length: 166
	}

	[XmlAttribute("substitutionGroup")]
	public XmlQualifiedName SubstitutionGroup
	{
		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		 get { } //Length: 8
		[CalledBy(Type = typeof(XmlSchemaInference), Member = "CreateNewElementforChoice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaElement)}, ReturnType = typeof(XmlSchemaElement))]
		[CalledBy(Type = typeof(XsdBuilder), Member = "BuildElement_SubstitutionGroup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XsdBuilder), typeof(string)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(XmlQualifiedName), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName), typeof(XmlQualifiedName)}, ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 2)]
		 set { } //Length: 166
	}

	[CalledBy(Type = typeof(XmlSchemaInference), Member = "AddElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(XmlSchema), typeof(XmlSchemaObjectCollection), typeof(int)}, ReturnType = typeof(XmlSchemaElement))]
	[CalledBy(Type = typeof(XmlSchemaInference), Member = "CreateNewElementforChoice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaElement)}, ReturnType = typeof(XmlSchemaElement))]
	[CalledBy(Type = typeof(XsdBuilder), Member = "InitElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XsdBuilder), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(XmlSchemaParticle), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	public XmlSchemaElement() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlSchemaElement), Member = "Clone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchema)}, ReturnType = typeof(XmlSchemaObject))]
	internal virtual XmlSchemaObject Clone() { }

	[CalledBy(Type = typeof(XmlSchema), Member = "DeepClone", ReturnType = typeof(XmlSchema))]
	[CalledBy(Type = typeof(XmlSchemaComplexType), Member = "CloneParticle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaParticle), typeof(XmlSchema)}, ReturnType = typeof(XmlSchemaParticle))]
	[CalledBy(Type = typeof(XmlSchemaElement), Member = "Clone", ReturnType = typeof(XmlSchemaObject))]
	[CalledBy(Type = typeof(XmlSchemaValidator), Member = "GetSchemaElement", ReturnType = typeof(XmlSchemaElement))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(XmlQualifiedName), Member = "Clone", ReturnType = typeof(XmlQualifiedName))]
	[Calls(Type = typeof(XmlSchemaType), Member = "get_QualifiedName", ReturnType = typeof(XmlQualifiedName))]
	[Calls(Type = typeof(XmlQualifiedName), Member = "get_IsEmpty", ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlSchemaComplexType), Member = "Clone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchema)}, ReturnType = typeof(XmlSchemaObject))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 10)]
	internal XmlSchemaObject Clone(XmlSchema parentSchema) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public XmlSchemaDerivationMethod get_Block() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public XmlSchemaDerivationMethod get_BlockResolved() { }

	[CalledBy(Type = typeof(Preprocessor), Member = "PreprocessElementContent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaElement)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SchemaCollectionCompiler), Member = "CleanupElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaElement)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SchemaCollectionCompiler), Member = "CompileElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaElement)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SchemaCollectionPreprocessor), Member = "PreprocessElementContent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaElement)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Compiler), Member = "CleanupElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaElement)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Compiler), Member = "CompileElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaElement)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XsdBuilder), Member = "InitSimpleType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XsdBuilder), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XsdBuilder), Member = "InitComplexType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XsdBuilder), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XsdBuilder), Member = "InitIdentityConstraint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XsdBuilder), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Data.XSDSchema", Member = "InstantiateSimpleTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaElement)}, ReturnType = "System.Data.DataTable")]
	[CalledBy(Type = "System.Data.XSDSchema", Member = "InstantiateTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaElement), typeof(XmlSchemaComplexType), typeof(bool)}, ReturnType = "System.Data.DataTable")]
	[CalledBy(Type = "System.Data.XSDSchema", Member = "HandleDataSet", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaElement), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 22)]
	[Calls(Type = typeof(CollectionBase), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public XmlSchemaObjectCollection get_Constraints() { }

	[CallerCount(Count = 57)]
	[DeduplicatedMethod]
	public string get_DefaultValue() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	internal SchemaElementDecl get_ElementDecl() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public XmlSchemaType get_ElementSchemaType() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public XmlSchemaDerivationMethod get_Final() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public XmlSchemaDerivationMethod get_FinalResolved() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public string get_FixedValue() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public XmlSchemaForm get_Form() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	internal bool get_HasAbstractAttribute() { }

	[CalledBy(Type = typeof(Preprocessor), Member = "PreprocessLocalElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaElement)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SchemaCollectionCompiler), Member = "CompileElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaElement)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SchemaCollectionPreprocessor), Member = "PreprocessLocalElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaElement)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Compiler), Member = "CompileElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaElement)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	internal bool get_HasConstraints() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	internal bool get_HasNillableAttribute() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public bool get_IsAbstract() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	internal bool get_IsLocalTypeDerivationChecked() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public bool get_IsNillable() { }

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public string get_Name() { }

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	internal virtual string get_NameAttribute() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	internal virtual string get_NameString() { }

	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	public XmlQualifiedName get_QualifiedName() { }

	[CallerCount(Count = 4)]
	[DeduplicatedMethod]
	public XmlQualifiedName get_RefName() { }

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public XmlSchemaType get_SchemaType() { }

	[CallerCount(Count = 17)]
	[DeduplicatedMethod]
	public XmlQualifiedName get_SchemaTypeName() { }

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public XmlQualifiedName get_SubstitutionGroup() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void set_Block(XmlSchemaDerivationMethod value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public void set_DefaultValue(string value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	internal void set_ElementDecl(SchemaElementDecl value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void set_Final(XmlSchemaDerivationMethod value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public void set_FixedValue(string value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void set_Form(XmlSchemaForm value) { }

	[CalledBy(Type = typeof(XsdBuilder), Member = "BuildElement_Abstract", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XsdBuilder), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	public void set_IsAbstract(bool value) { }

	[CallerCount(Count = 0)]
	internal void set_IsLocalTypeDerivationChecked(bool value) { }

	[CalledBy(Type = typeof(XmlSchemaInference), Member = "ProcessAttributes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaElement&), typeof(XmlSchemaType), typeof(bool), typeof(XmlSchema)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSchemaInference), Member = "CreateNewElementforChoice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaElement)}, ReturnType = typeof(XmlSchemaElement))]
	[CalledBy(Type = typeof(XsdBuilder), Member = "BuildElement_Nillable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XsdBuilder), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	public void set_IsNillable(bool value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public void set_Name(string value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	internal virtual void set_NameAttribute(string value) { }

	[CalledBy(Type = typeof(XmlSchemaInference), Member = "AddElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(XmlSchema), typeof(XmlSchemaObjectCollection), typeof(int)}, ReturnType = typeof(XmlSchemaElement))]
	[CalledBy(Type = typeof(XmlSchemaInference), Member = "CreateNewElementforChoice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaElement)}, ReturnType = typeof(XmlSchemaElement))]
	[CalledBy(Type = typeof(XsdBuilder), Member = "BuildElement_Ref", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XsdBuilder), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(XmlQualifiedName), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName), typeof(XmlQualifiedName)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 2)]
	public void set_RefName(XmlQualifiedName value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public void set_SchemaType(XmlSchemaType value) { }

	[CalledBy(Type = typeof(XmlSchemaInference), Member = "InferElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaElement), typeof(bool), typeof(XmlSchema)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSchemaInference), Member = "ProcessAttributes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaElement&), typeof(XmlSchemaType), typeof(bool), typeof(XmlSchema)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSchemaInference), Member = "CreateNewElementforChoice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaElement)}, ReturnType = typeof(XmlSchemaElement))]
	[CalledBy(Type = typeof(XmlSchemaValidator), Member = "GetSchemaElement", ReturnType = typeof(XmlSchemaElement))]
	[CalledBy(Type = typeof(XsdBuilder), Member = "BuildElement_Type", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XsdBuilder), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(XmlQualifiedName), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName), typeof(XmlQualifiedName)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 2)]
	public void set_SchemaTypeName(XmlQualifiedName value) { }

	[CalledBy(Type = typeof(XmlSchemaInference), Member = "CreateNewElementforChoice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaElement)}, ReturnType = typeof(XmlSchemaElement))]
	[CalledBy(Type = typeof(XsdBuilder), Member = "BuildElement_SubstitutionGroup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XsdBuilder), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(XmlQualifiedName), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName), typeof(XmlQualifiedName)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 2)]
	public void set_SubstitutionGroup(XmlQualifiedName value) { }

	[CallerCount(Count = 0)]
	internal void SetBlockResolved(XmlSchemaDerivationMethod value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	internal void SetElementType(XmlSchemaType value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	internal void SetFinalResolved(XmlSchemaDerivationMethod value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	internal void SetQualifiedName(XmlQualifiedName value) { }

}

