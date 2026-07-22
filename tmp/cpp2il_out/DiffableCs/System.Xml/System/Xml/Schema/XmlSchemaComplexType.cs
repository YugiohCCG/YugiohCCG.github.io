namespace System.Xml.Schema;

public class XmlSchemaComplexType : XmlSchemaType
{
	private static XmlSchemaComplexType anyTypeLax; //Field offset: 0x0
	private static XmlSchemaComplexType anyTypeSkip; //Field offset: 0x8
	private static XmlSchemaComplexType untypedAnyType; //Field offset: 0x10
	private XmlSchemaDerivationMethod block; //Field offset: 0x98
	private XmlSchemaContentModel contentModel; //Field offset: 0xA0
	private XmlSchemaParticle particle; //Field offset: 0xA8
	private XmlSchemaObjectCollection attributes; //Field offset: 0xB0
	private XmlSchemaAnyAttribute anyAttribute; //Field offset: 0xB8
	private XmlSchemaParticle contentTypeParticle; //Field offset: 0xC0
	private XmlSchemaDerivationMethod blockResolved; //Field offset: 0xC8
	private XmlSchemaObjectTable localElements; //Field offset: 0xD0
	private XmlSchemaObjectTable attributeUses; //Field offset: 0xD8
	private XmlSchemaAnyAttribute attributeWildcard; //Field offset: 0xE0
	private byte pvFlags; //Field offset: 0xE8

	[XmlElement("anyAttribute")]
	public XmlSchemaAnyAttribute AnyAttribute
	{
		[CallerCount(Count = 17)]
		[DeduplicatedMethod]
		 get { } //Length: 8
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 set { } //Length: 19
	}

	[XmlIgnore]
	internal static XmlSchemaComplexType AnyType
	{
		[CallerCount(Count = 0)]
		internal get { } //Length: 78
	}

	internal static ContentValidator AnyTypeContentValidator
	{
		[CalledBy(Type = typeof(SchemaCollectionCompiler), Member = "CompileComplexContent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaComplexType)}, ReturnType = typeof(ContentValidator))]
		[CalledBy(Type = typeof(Compiler), Member = "CompileComplexContent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaComplexType)}, ReturnType = typeof(ContentValidator))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(XmlSchemaType), Member = "get_ElementDecl", ReturnType = typeof(SchemaElementDecl))]
		[CallsUnknownMethods(Count = 1)]
		internal get { } //Length: 107
	}

	[XmlElement("attribute", typeof(XmlSchemaAttribute))]
	[XmlElement("attributeGroup", typeof(XmlSchemaAttributeGroupRef))]
	public XmlSchemaObjectCollection Attributes
	{
		[CalledBy(Type = typeof(XmlSchemaInference), Member = "InferElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaElement), typeof(bool), typeof(XmlSchema)}, ReturnType = typeof(void))]
		[CalledBy(Type = "System.Data.XSDSchema", Member = "HandleComplexType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaComplexType), "System.Data.DataTable", typeof(ArrayList), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = "System.Data.XSDSchema", Member = "FindDatasetElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaObjectCollection)}, ReturnType = typeof(XmlSchemaElement))]
		[CalledBy(Type = typeof(XsdBuilder), Member = "AddParticle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaParticle)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XsdBuilder), Member = "AddAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaObject)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XsdBuilder), Member = "InitSimpleContent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XsdBuilder), typeof(string)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XsdBuilder), Member = "InitComplexContent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XsdBuilder), typeof(string)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Compiler), Member = "CompileComplexType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaComplexType)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Compiler), Member = "CleanupComplexType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaComplexType)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(SchemaCollectionCompiler), Member = "CompileComplexType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaComplexType)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(SchemaCollectionCompiler), Member = "CleanupComplexType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaComplexType)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Preprocessor), Member = "PreprocessComplexType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaComplexType), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XmlSchemaInference), Member = "MakeExistingAttributesOptional", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaComplexType), typeof(XmlSchemaObjectCollection)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XmlSchemaInference), Member = "MoveAttributes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaComplexType), typeof(XmlSchemaSimpleContentExtension), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XmlSchemaInference), Member = "MoveAttributes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaSimpleContentExtension), typeof(XmlSchemaComplexType)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XmlSchemaInference), Member = "ProcessAttributes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaElement&), typeof(XmlSchemaType), typeof(bool), typeof(XmlSchema)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(SchemaCollectionPreprocessor), Member = "PreprocessComplexType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaComplexType), typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 22)]
		[Calls(Type = typeof(CollectionBase), Member = ".ctor", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 117
	}

	[XmlIgnore]
	public XmlSchemaObjectTable AttributeUses
	{
		[CalledBy(Type = typeof(XmlSchemaInference), Member = "ProcessAttributes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaElement&), typeof(XmlSchemaType), typeof(bool), typeof(XmlSchema)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XmlSchemaInference), Member = "MoveAttributes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaComplexType), typeof(XmlSchemaSimpleContentExtension), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(SchemaCollectionCompiler), Member = "CleanupComplexType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaComplexType)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(SchemaCollectionCompiler), Member = "CompileComplexType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaComplexType)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(SchemaCollectionCompiler), Member = "CompileLocalAttributes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaComplexType), typeof(XmlSchemaComplexType), typeof(XmlSchemaObjectCollection), typeof(XmlSchemaAnyAttribute), typeof(XmlSchemaDerivationMethod)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Compiler), Member = "CleanupComplexType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaComplexType)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Compiler), Member = "CompileComplexType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaComplexType)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Compiler), Member = "CompileLocalAttributes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaComplexType), typeof(XmlSchemaComplexType), typeof(XmlSchemaObjectCollection), typeof(XmlSchemaAnyAttribute), typeof(XmlSchemaDerivationMethod)}, ReturnType = typeof(void))]
		[CallerCount(Count = 32)]
		[Calls(Type = typeof(XmlSchemaObjectTable), Member = ".ctor", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 117
	}

	[XmlIgnore]
	public XmlSchemaAnyAttribute AttributeWildcard
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 8
	}

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

	[XmlElement("simpleContent", typeof(XmlSchemaSimpleContent))]
	[XmlElement("complexContent", typeof(XmlSchemaComplexContent))]
	public XmlSchemaContentModel ContentModel
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
	public XmlSchemaContentType ContentType
	{
		[CallerCount(Count = 33)]
		[DeduplicatedMethod]
		 get { } //Length: 7
	}

	[XmlIgnore]
	public XmlSchemaParticle ContentTypeParticle
	{
		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		 get { } //Length: 8
	}

	internal bool HasWildCard
	{
		[CalledBy(Type = typeof(Compiler), Member = "CleanupComplexType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaComplexType)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Compiler), Member = "CompileComplexContent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaComplexType)}, ReturnType = typeof(ContentValidator))]
		[CallerCount(Count = 2)]
		internal set { } //Length: 39
	}

	[DefaultValue(False)]
	[XmlAttribute("abstract")]
	public bool IsAbstract
	{
		[CalledBy(Type = typeof(SchemaCollectionCompiler), Member = "Output", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SchemaInfo)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(SchemaCollectionCompiler), Member = "CompileComplexType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaComplexType)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(SchemaCollectionCompiler), Member = "CompileElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaElement)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Compiler), Member = "CompileComplexType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaComplexType)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Compiler), Member = "CompileElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaElement)}, ReturnType = typeof(void))]
		[CalledBy(Type = "System.Data.XSDSchema", Member = "IsTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaElement)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 6)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 11
		[CalledBy(Type = typeof(XsdBuilder), Member = "BuildComplexType_Abstract", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XsdBuilder), typeof(string)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		 set { } //Length: 39
	}

	[DefaultValue(False)]
	[XmlAttribute("mixed")]
	public virtual bool IsMixed
	{
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 11
		[CallerCount(Count = 0)]
		 set { } //Length: 39
	}

	[XmlIgnore]
	internal XmlSchemaObjectTable LocalElements
	{
		[CalledBy(Type = typeof(SchemaCollectionCompiler), Member = "CleanupComplexType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaComplexType)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(SchemaCollectionCompiler), Member = "CompileParticleElements", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaComplexType), typeof(XmlSchemaParticle)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Compiler), Member = "CleanupComplexType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaComplexType)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Compiler), Member = "CheckParticleDerivation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaComplexType)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Compiler), Member = "CompileParticleElements", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaComplexType), typeof(XmlSchemaParticle)}, ReturnType = typeof(void))]
		[CallerCount(Count = 9)]
		[Calls(Type = typeof(XmlSchemaObjectTable), Member = ".ctor", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		internal get { } //Length: 117
	}

	[XmlElement("all", typeof(XmlSchemaAll))]
	[XmlElement("group", typeof(XmlSchemaGroupRef))]
	[XmlElement("sequence", typeof(XmlSchemaSequence))]
	[XmlElement("choice", typeof(XmlSchemaChoice))]
	public XmlSchemaParticle Particle
	{
		[CallerCount(Count = 4)]
		[DeduplicatedMethod]
		 get { } //Length: 8
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 set { } //Length: 19
	}

	[XmlIgnore]
	internal static XmlSchemaComplexType UntypedAnyType
	{
		[CallerCount(Count = 0)]
		internal get { } //Length: 79
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlSchemaComplexType), Member = "CreateAnyType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaContentProcessing)}, ReturnType = typeof(XmlSchemaComplexType))]
	[Calls(Type = typeof(XmlQualifiedName), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSchemaType), Member = "SetQualifiedName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SchemaElementDecl), Member = "CreateAnyTypeElementDecl", ReturnType = typeof(SchemaElementDecl))]
	[Calls(Type = typeof(XmlSchemaType), Member = "set_ElementDecl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SchemaElementDecl)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSchemaType), Member = "get_ElementDecl", ReturnType = typeof(SchemaElementDecl))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 8)]
	private static XmlSchemaComplexType() { }

	[CalledBy(Type = typeof(XmlSchemaInference), Member = "InferElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaElement), typeof(bool), typeof(XmlSchema)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSchemaInference), Member = "ProcessAttributes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaElement&), typeof(XmlSchemaType), typeof(bool), typeof(XmlSchema)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSchemaComplexType), Member = "CreateAnyType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaContentProcessing)}, ReturnType = typeof(XmlSchemaComplexType))]
	[CalledBy(Type = typeof(XsdBuilder), Member = "InitComplexType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XsdBuilder), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Data.DataSet", Member = "GetDataSetSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaSet)}, ReturnType = typeof(XmlSchemaComplexType))]
	[CalledBy(Type = "System.Data.DataTable", Member = "GetDataTableSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaSet)}, ReturnType = typeof(XmlSchemaComplexType))]
	[CallerCount(Count = 6)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public XmlSchemaComplexType() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 4)]
	private void ClearCompiledState() { }

	[CalledBy(Type = typeof(XmlSchema), Member = "DeepClone", ReturnType = typeof(XmlSchema))]
	[CalledBy(Type = typeof(XmlSchemaComplexType), Member = "Clone", ReturnType = typeof(XmlSchemaObject))]
	[CalledBy(Type = typeof(XmlSchemaElement), Member = "Clone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchema)}, ReturnType = typeof(XmlSchemaObject))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(XmlSchemaComplexType), Member = "HasParticleRef", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaParticle), typeof(XmlSchema)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlSchemaComplexType), Member = "CloneParticle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaParticle), typeof(XmlSchema)}, ReturnType = typeof(XmlSchemaParticle))]
	[Calls(Type = typeof(CollectionBase), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSchemaComplexType), Member = "CloneAttributes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaObjectCollection)}, ReturnType = typeof(XmlSchemaObjectCollection))]
	[Calls(Type = typeof(XmlQualifiedName), Member = "Clone", ReturnType = typeof(XmlQualifiedName))]
	[Calls(Type = typeof(XmlSchemaSimpleContentExtension), Member = "set_BaseTypeName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSchemaSimpleContentRestriction), Member = "set_BaseTypeName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlQualifiedName), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName), typeof(XmlQualifiedName)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 12)]
	[CallsUnknownMethods(Count = 23)]
	internal XmlSchemaObject Clone(XmlSchema parentSchema) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlSchemaComplexType), Member = "Clone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchema)}, ReturnType = typeof(XmlSchemaObject))]
	internal virtual XmlSchemaObject Clone() { }

	[CalledBy(Type = typeof(XmlSchemaAttributeGroup), Member = "Clone", ReturnType = typeof(XmlSchemaObject))]
	[CalledBy(Type = typeof(XmlSchemaComplexType), Member = "Clone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchema)}, ReturnType = typeof(XmlSchemaObject))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(XmlSchemaComplexType), Member = "HasAttributeQNameRef", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaObjectCollection)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlSchemaObjectCollection), Member = "Clone", ReturnType = typeof(XmlSchemaObjectCollection))]
	[Calls(Type = typeof(XmlQualifiedName), Member = "Clone", ReturnType = typeof(XmlQualifiedName))]
	[Calls(Type = typeof(XmlSchemaAttributeGroupRef), Member = "set_RefName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlQualifiedName), Member = "get_IsEmpty", ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 2)]
	internal static XmlSchemaObjectCollection CloneAttributes(XmlSchemaObjectCollection attributes) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlSchemaObjectCollection), Member = "Clone", ReturnType = typeof(XmlSchemaObjectCollection))]
	[Calls(Type = typeof(XmlSchemaComplexType), Member = "CloneParticle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaParticle), typeof(XmlSchema)}, ReturnType = typeof(XmlSchemaParticle))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	private static XmlSchemaObjectCollection CloneGroupBaseParticles(XmlSchemaObjectCollection groupBaseParticles, XmlSchema parentSchema) { }

	[CalledBy(Type = typeof(XmlSchemaComplexType), Member = "Clone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchema)}, ReturnType = typeof(XmlSchemaObject))]
	[CalledBy(Type = typeof(XmlSchemaComplexType), Member = "CloneGroupBaseParticles", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaObjectCollection), typeof(XmlSchema)}, ReturnType = typeof(XmlSchemaObjectCollection))]
	[CalledBy(Type = typeof(XmlSchemaComplexType), Member = "CloneParticle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaParticle), typeof(XmlSchema)}, ReturnType = typeof(XmlSchemaParticle))]
	[CalledBy(Type = typeof(XmlSchemaGroup), Member = "Clone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchema)}, ReturnType = typeof(XmlSchemaObject))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(XmlSchemaObjectCollection), Member = "Clone", ReturnType = typeof(XmlSchemaObjectCollection))]
	[Calls(Type = typeof(XmlSchemaComplexType), Member = "CloneParticle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaParticle), typeof(XmlSchema)}, ReturnType = typeof(XmlSchemaParticle))]
	[Calls(Type = typeof(XmlQualifiedName), Member = "Clone", ReturnType = typeof(XmlQualifiedName))]
	[Calls(Type = typeof(XmlQualifiedName), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName), typeof(XmlQualifiedName)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlQualifiedName), Member = "get_IsEmpty", ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlSchemaElement), Member = "Clone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchema)}, ReturnType = typeof(XmlSchemaObject))]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 6)]
	internal static XmlSchemaParticle CloneParticle(XmlSchemaParticle particle, XmlSchema parentSchema) { }

	[CalledBy(Type = typeof(Compiler), Member = "CompileComplexType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaComplexType)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSchemaValidator), Member = "ValidateAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(XmlValueGetter), typeof(string), typeof(XmlSchemaInfo)}, ReturnType = typeof(object))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(XmlSchemaObjectTable), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSchemaObjectTable), Member = "get_Values", ReturnType = typeof(ICollection))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 14)]
	[ContainsUnimplementedInstructions]
	internal bool ContainsIdAttribute(bool findAll) { }

	[CalledBy(Type = typeof(XmlSchemaComplexType), Member = ".cctor", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ParticleContentValidator), Member = "Finish", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(ContentValidator))]
	[Calls(Type = typeof(ParticleContentValidator), Member = "CloseGroup", ReturnType = typeof(void))]
	[Calls(Type = typeof(ParticleContentValidator), Member = "AddStar", ReturnType = typeof(void))]
	[Calls(Type = typeof(ParticleContentValidator), Member = "AddNamespaceList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NamespaceList), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ParticleContentValidator), Member = "OpenGroup", ReturnType = typeof(void))]
	[Calls(Type = typeof(ParticleContentValidator), Member = "Start", ReturnType = typeof(void))]
	[Calls(Type = typeof(ParticleContentValidator), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaContentType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSchemaType), Member = "get_ElementDecl", ReturnType = typeof(SchemaElementDecl))]
	[Calls(Type = typeof(XmlSchemaType), Member = "set_ElementDecl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SchemaElementDecl)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SchemaElementDecl), Member = "CreateAnyTypeElementDecl", ReturnType = typeof(SchemaElementDecl))]
	[Calls(Type = typeof(XmlSchemaSequence), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(NamespaceList), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSchemaParticle), Member = "set_MaxOccurs", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Decimal), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(bool), typeof(byte)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSchemaParticle), Member = "set_MinOccurs", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSchemaParticle), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSchemaType), Member = "SetQualifiedName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSchemaComplexType), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 9)]
	private static XmlSchemaComplexType CreateAnyType(XmlSchemaContentProcessing processContents) { }

	[CallerCount(Count = 17)]
	[DeduplicatedMethod]
	public XmlSchemaAnyAttribute get_AnyAttribute() { }

	[CallerCount(Count = 0)]
	internal static XmlSchemaComplexType get_AnyType() { }

	[CalledBy(Type = typeof(SchemaCollectionCompiler), Member = "CompileComplexContent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaComplexType)}, ReturnType = typeof(ContentValidator))]
	[CalledBy(Type = typeof(Compiler), Member = "CompileComplexContent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaComplexType)}, ReturnType = typeof(ContentValidator))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(XmlSchemaType), Member = "get_ElementDecl", ReturnType = typeof(SchemaElementDecl))]
	[CallsUnknownMethods(Count = 1)]
	internal static ContentValidator get_AnyTypeContentValidator() { }

	[CalledBy(Type = typeof(XmlSchemaInference), Member = "InferElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaElement), typeof(bool), typeof(XmlSchema)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SchemaCollectionPreprocessor), Member = "PreprocessComplexType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaComplexType), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSchemaInference), Member = "ProcessAttributes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaElement&), typeof(XmlSchemaType), typeof(bool), typeof(XmlSchema)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSchemaInference), Member = "MoveAttributes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaSimpleContentExtension), typeof(XmlSchemaComplexType)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSchemaInference), Member = "MoveAttributes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaComplexType), typeof(XmlSchemaSimpleContentExtension), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSchemaInference), Member = "MakeExistingAttributesOptional", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaComplexType), typeof(XmlSchemaObjectCollection)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Preprocessor), Member = "PreprocessComplexType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaComplexType), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SchemaCollectionCompiler), Member = "CleanupComplexType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaComplexType)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SchemaCollectionCompiler), Member = "CompileComplexType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaComplexType)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Compiler), Member = "CompileComplexType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaComplexType)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XsdBuilder), Member = "InitComplexContent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XsdBuilder), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XsdBuilder), Member = "InitSimpleContent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XsdBuilder), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XsdBuilder), Member = "AddAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaObject)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XsdBuilder), Member = "AddParticle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaParticle)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Data.XSDSchema", Member = "FindDatasetElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaObjectCollection)}, ReturnType = typeof(XmlSchemaElement))]
	[CalledBy(Type = "System.Data.XSDSchema", Member = "HandleComplexType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaComplexType), "System.Data.DataTable", typeof(ArrayList), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Compiler), Member = "CleanupComplexType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaComplexType)}, ReturnType = typeof(void))]
	[CallerCount(Count = 22)]
	[Calls(Type = typeof(CollectionBase), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public XmlSchemaObjectCollection get_Attributes() { }

	[CalledBy(Type = typeof(XmlSchemaInference), Member = "ProcessAttributes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaElement&), typeof(XmlSchemaType), typeof(bool), typeof(XmlSchema)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSchemaInference), Member = "MoveAttributes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaComplexType), typeof(XmlSchemaSimpleContentExtension), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SchemaCollectionCompiler), Member = "CleanupComplexType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaComplexType)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SchemaCollectionCompiler), Member = "CompileComplexType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaComplexType)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SchemaCollectionCompiler), Member = "CompileLocalAttributes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaComplexType), typeof(XmlSchemaComplexType), typeof(XmlSchemaObjectCollection), typeof(XmlSchemaAnyAttribute), typeof(XmlSchemaDerivationMethod)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Compiler), Member = "CleanupComplexType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaComplexType)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Compiler), Member = "CompileComplexType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaComplexType)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Compiler), Member = "CompileLocalAttributes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaComplexType), typeof(XmlSchemaComplexType), typeof(XmlSchemaObjectCollection), typeof(XmlSchemaAnyAttribute), typeof(XmlSchemaDerivationMethod)}, ReturnType = typeof(void))]
	[CallerCount(Count = 32)]
	[Calls(Type = typeof(XmlSchemaObjectTable), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public XmlSchemaObjectTable get_AttributeUses() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public XmlSchemaAnyAttribute get_AttributeWildcard() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public XmlSchemaDerivationMethod get_Block() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public XmlSchemaDerivationMethod get_BlockResolved() { }

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public XmlSchemaContentModel get_ContentModel() { }

	[CallerCount(Count = 33)]
	[DeduplicatedMethod]
	public XmlSchemaContentType get_ContentType() { }

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public XmlSchemaParticle get_ContentTypeParticle() { }

	[CalledBy(Type = typeof(SchemaCollectionCompiler), Member = "Output", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SchemaInfo)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SchemaCollectionCompiler), Member = "CompileComplexType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaComplexType)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SchemaCollectionCompiler), Member = "CompileElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaElement)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Compiler), Member = "CompileComplexType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaComplexType)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Compiler), Member = "CompileElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaElement)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Data.XSDSchema", Member = "IsTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaElement)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 6)]
	[ContainsUnimplementedInstructions]
	public bool get_IsAbstract() { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public virtual bool get_IsMixed() { }

	[CalledBy(Type = typeof(SchemaCollectionCompiler), Member = "CleanupComplexType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaComplexType)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SchemaCollectionCompiler), Member = "CompileParticleElements", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaComplexType), typeof(XmlSchemaParticle)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Compiler), Member = "CleanupComplexType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaComplexType)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Compiler), Member = "CheckParticleDerivation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaComplexType)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Compiler), Member = "CompileParticleElements", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaComplexType), typeof(XmlSchemaParticle)}, ReturnType = typeof(void))]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(XmlSchemaObjectTable), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	internal XmlSchemaObjectTable get_LocalElements() { }

	[CallerCount(Count = 4)]
	[DeduplicatedMethod]
	public XmlSchemaParticle get_Particle() { }

	[CallerCount(Count = 0)]
	internal static XmlSchemaComplexType get_UntypedAnyType() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private static XmlSchemaForm GetResolvedElementForm(XmlSchema parentSchema, XmlSchemaElement element) { }

	[CalledBy(Type = typeof(XmlSchemaAttributeGroup), Member = "Clone", ReturnType = typeof(XmlSchemaObject))]
	[CalledBy(Type = typeof(XmlSchemaComplexType), Member = "CloneAttributes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaObjectCollection)}, ReturnType = typeof(XmlSchemaObjectCollection))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(XmlQualifiedName), Member = "get_IsEmpty", ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	internal static bool HasAttributeQNameRef(XmlSchemaObjectCollection attributes) { }

	[CalledBy(Type = typeof(XmlSchemaComplexType), Member = "Clone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchema)}, ReturnType = typeof(XmlSchemaObject))]
	[CalledBy(Type = typeof(XmlSchemaComplexType), Member = "HasParticleRef", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaParticle), typeof(XmlSchema)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XmlSchemaGroup), Member = "Clone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchema)}, ReturnType = typeof(XmlSchemaObject))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(XmlSchemaComplexType), Member = "HasParticleRef", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaParticle), typeof(XmlSchema)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlQualifiedName), Member = "get_IsEmpty", ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 2)]
	internal static bool HasParticleRef(XmlSchemaParticle particle, XmlSchema parentSchema) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public void set_AnyAttribute(XmlSchemaAnyAttribute value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void set_Block(XmlSchemaDerivationMethod value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public void set_ContentModel(XmlSchemaContentModel value) { }

	[CalledBy(Type = typeof(Compiler), Member = "CleanupComplexType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaComplexType)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Compiler), Member = "CompileComplexContent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaComplexType)}, ReturnType = typeof(ContentValidator))]
	[CallerCount(Count = 2)]
	internal void set_HasWildCard(bool value) { }

	[CalledBy(Type = typeof(XsdBuilder), Member = "BuildComplexType_Abstract", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XsdBuilder), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	public void set_IsAbstract(bool value) { }

	[CallerCount(Count = 0)]
	public virtual void set_IsMixed(bool value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public void set_Particle(XmlSchemaParticle value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	internal void SetAttributes(XmlSchemaObjectCollection newAttributes) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	internal void SetAttributeWildcard(XmlSchemaAnyAttribute value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	internal void SetBlockResolved(XmlSchemaDerivationMethod value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	internal void SetContentTypeParticle(XmlSchemaParticle value) { }

}

