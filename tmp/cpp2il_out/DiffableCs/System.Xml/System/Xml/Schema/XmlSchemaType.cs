namespace System.Xml.Schema;

public class XmlSchemaType : XmlSchemaAnnotated
{
	private string name; //Field offset: 0x50
	private XmlSchemaDerivationMethod final; //Field offset: 0x58
	private XmlSchemaDerivationMethod derivedBy; //Field offset: 0x5C
	private XmlSchemaType baseSchemaType; //Field offset: 0x60
	private XmlSchemaDatatype datatype; //Field offset: 0x68
	private XmlSchemaDerivationMethod finalResolved; //Field offset: 0x70
	private SchemaElementDecl elementDecl; //Field offset: 0x78
	private XmlQualifiedName qname; //Field offset: 0x80
	private XmlSchemaType redefined; //Field offset: 0x88
	private XmlSchemaContentType contentType; //Field offset: 0x90

	[XmlIgnore]
	public XmlSchemaType BaseXmlSchemaType
	{
		[CallerCount(Count = 84)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	[XmlIgnore]
	public XmlSchemaDatatype Datatype
	{
		[CallerCount(Count = 22)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	[XmlIgnore]
	public XmlSchemaDerivationMethod DerivedBy
	{
		[CallerCount(Count = 26)]
		[DeduplicatedMethod]
		 get { } //Length: 4
	}

	internal SchemaElementDecl ElementDecl
	{
		[CallerCount(Count = 42)]
		[CallsUnknownMethods(Count = 1)]
		internal get { } //Length: 24
		[CalledBy(Type = typeof(DatatypeImplementation), Member = "StartBuiltinType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName), typeof(XmlSchemaDatatype)}, ReturnType = typeof(XmlSchemaSimpleType))]
		[CalledBy(Type = typeof(XmlSchemaComplexType), Member = "CreateAnyType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaContentProcessing)}, ReturnType = typeof(XmlSchemaComplexType))]
		[CalledBy(Type = typeof(XmlSchemaComplexType), Member = ".cctor", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Compiler), Member = "CompileComplexType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaComplexType)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Compiler), Member = "CleanupElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaElement)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Compiler), Member = "CleanupSimpleType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaSimpleType)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Compiler), Member = "CleanupComplexType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaComplexType)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Compiler), Member = "CleanupAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaAttribute)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(SchemaCollectionCompiler), Member = "CompileComplexType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaComplexType)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(SchemaCollectionCompiler), Member = "CleanupAttributes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaObjectCollection)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(SchemaCollectionCompiler), Member = "CleanupSimpleType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaSimpleType)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(SchemaCollectionCompiler), Member = "CleanupComplexType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaComplexType)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(SchemaCollectionCompiler), Member = "CleanupAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaAttribute)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(SchemaCollectionCompiler), Member = "Cleanup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchema)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(SchemaCollectionCompiler), Member = "Cleanup", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XmlSchemaInference), Member = ".ctor", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DatatypeImplementation), Member = "GetTokenTypeV1Compat", ReturnType = typeof(XmlSchemaSimpleType))]
		[CalledBy(Type = typeof(DatatypeImplementation), Member = "GetNormalizedStringTypeV1Compat", ReturnType = typeof(XmlSchemaSimpleType))]
		[CalledBy(Type = typeof(SchemaCollectionCompiler), Member = "CleanupElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaElement)}, ReturnType = typeof(void))]
		[CallerCount(Count = 23)]
		[CallsUnknownMethods(Count = 2)]
		internal set { } //Length: 47
	}

	[DefaultValue(XmlSchemaDerivationMethod::None (256))]
	[XmlAttribute("final")]
	public XmlSchemaDerivationMethod Final
	{
		[CallerCount(Count = 3)]
		[DeduplicatedMethod]
		 get { } //Length: 4
		[CallerCount(Count = 5)]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	[XmlIgnore]
	public XmlSchemaDerivationMethod FinalResolved
	{
		[CallerCount(Count = 3)]
		[DeduplicatedMethod]
		 get { } //Length: 4
	}

	[XmlIgnore]
	public override bool IsMixed
	{
		[CallerCount(Count = 271)]
		[DeduplicatedMethod]
		 get { } //Length: 3
		[CallerCount(Count = 13327)]
		[DeduplicatedMethod]
		 set { } //Length: 3
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
		[CallerCount(Count = 85)]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 27
	}

	[XmlIgnore]
	internal XmlSchemaType Redefined
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		internal get { } //Length: 8
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		internal set { } //Length: 19
	}

	internal XmlSchemaContentType SchemaContentType
	{
		[CallerCount(Count = 33)]
		[DeduplicatedMethod]
		internal get { } //Length: 7
	}

	[XmlIgnore]
	public XmlTypeCode TypeCode
	{
		[CalledBy(Type = typeof(DatatypeImplementation), Member = "GetPrimitiveTypeCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlTypeCode)}, ReturnType = typeof(XmlTypeCode))]
		[CalledBy(Type = typeof(SchemaCollectionCompiler), Member = "GetSimpleType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName)}, ReturnType = typeof(XmlSchemaSimpleType))]
		[CalledBy(Type = typeof(Compiler), Member = "CleanupAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaAttribute)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Compiler), Member = "CleanupSimpleType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaSimpleType)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Compiler), Member = "CleanupElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaElement)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XmlAtomicValue), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaType), typeof(string), typeof(IXmlNamespaceResolver)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XmlAtomicValue), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaType), typeof(object), typeof(IXmlNamespaceResolver)}, ReturnType = typeof(void))]
		[CallerCount(Count = 10)]
		[CallsDeduplicatedMethods(Count = 1)]
		 get { } //Length: 178
	}

	[XmlIgnore]
	internal XmlValueConverter ValueConverter
	{
		[CallerCount(Count = 29)]
		[CallsDeduplicatedMethods(Count = 1)]
		internal get { } //Length: 117
	}

	[CallerCount(Count = 5)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public XmlSchemaType() { }

	[CallerCount(Count = 84)]
	[DeduplicatedMethod]
	public XmlSchemaType get_BaseXmlSchemaType() { }

	[CallerCount(Count = 22)]
	[DeduplicatedMethod]
	public XmlSchemaDatatype get_Datatype() { }

	[CallerCount(Count = 26)]
	[DeduplicatedMethod]
	public XmlSchemaDerivationMethod get_DerivedBy() { }

	[CallerCount(Count = 42)]
	[CallsUnknownMethods(Count = 1)]
	internal SchemaElementDecl get_ElementDecl() { }

	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	public XmlSchemaDerivationMethod get_Final() { }

	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	public XmlSchemaDerivationMethod get_FinalResolved() { }

	[CallerCount(Count = 271)]
	[DeduplicatedMethod]
	public override bool get_IsMixed() { }

	[CallerCount(Count = 16)]
	[DeduplicatedMethod]
	public string get_Name() { }

	[CallerCount(Count = 16)]
	[DeduplicatedMethod]
	internal virtual string get_NameAttribute() { }

	[CallerCount(Count = 85)]
	[CallsUnknownMethods(Count = 1)]
	public XmlQualifiedName get_QualifiedName() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	internal XmlSchemaType get_Redefined() { }

	[CallerCount(Count = 33)]
	[DeduplicatedMethod]
	internal XmlSchemaContentType get_SchemaContentType() { }

	[CalledBy(Type = typeof(DatatypeImplementation), Member = "GetPrimitiveTypeCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlTypeCode)}, ReturnType = typeof(XmlTypeCode))]
	[CalledBy(Type = typeof(SchemaCollectionCompiler), Member = "GetSimpleType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName)}, ReturnType = typeof(XmlSchemaSimpleType))]
	[CalledBy(Type = typeof(Compiler), Member = "CleanupAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaAttribute)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Compiler), Member = "CleanupSimpleType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaSimpleType)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Compiler), Member = "CleanupElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaElement)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlAtomicValue), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaType), typeof(string), typeof(IXmlNamespaceResolver)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlAtomicValue), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaType), typeof(object), typeof(IXmlNamespaceResolver)}, ReturnType = typeof(void))]
	[CallerCount(Count = 10)]
	[CallsDeduplicatedMethods(Count = 1)]
	public XmlTypeCode get_TypeCode() { }

	[CallerCount(Count = 29)]
	[CallsDeduplicatedMethods(Count = 1)]
	internal XmlValueConverter get_ValueConverter() { }

	[CalledBy(Type = typeof(XmlSchemaInference), Member = "InferElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaElement), typeof(bool), typeof(XmlSchema)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSchemaInference), Member = "GetEffectiveSchemaType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaElement), typeof(bool)}, ReturnType = typeof(XmlSchemaType))]
	[CalledBy(Type = typeof(XmlSchemaValidator), Member = "CheckXsiTypeAndNil", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SchemaElementDecl), typeof(string), typeof(string), typeof(Boolean&)}, ReturnType = typeof(SchemaElementDecl))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(XmlQualifiedName), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName), typeof(XmlQualifiedName)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 8)]
	public static XmlSchemaComplexType GetBuiltInComplexType(XmlQualifiedName qualifiedName) { }

	[CalledBy(Type = typeof(XmlSchemaInference), Member = "InferElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaElement), typeof(bool), typeof(XmlSchema)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSchemaInference), Member = "GetEffectiveSchemaType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaElement), typeof(bool)}, ReturnType = typeof(XmlSchemaType))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(XmlQualifiedName), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName), typeof(XmlQualifiedName)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DatatypeImplementation), Member = "GetSimpleTypeFromXsdType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName)}, ReturnType = typeof(XmlSchemaSimpleType))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	public static XmlSchemaSimpleType GetBuiltInSimpleType(XmlQualifiedName qualifiedName) { }

	[CalledBy(Type = typeof(DtdParser), Member = "ParseAttlistType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SchemaAttDef), typeof(SchemaElementDecl), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Compiler), Member = "CleanupAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaAttribute)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Compiler), Member = "CleanupSimpleType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaSimpleType)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Compiler), Member = "CleanupElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaElement)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlAnyConverter), Member = "ChangeType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(Type)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(XmlAnyConverter), Member = "ChangeType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(Type)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(XmlAnyConverter), Member = "ChangeType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal), typeof(Type)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(XmlAnyConverter), Member = "ChangeType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double), typeof(Type)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(XmlAnyConverter), Member = "ChangeType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Type)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(XmlAnyConverter), Member = "ChangeType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(Type)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(XmlAnyConverter), Member = "ChangeType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Type), typeof(IXmlNamespaceResolver)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(XmlAnyConverter), Member = "ChangeType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Type), typeof(IXmlNamespaceResolver)}, ReturnType = typeof(object))]
	[CallerCount(Count = 31)]
	[Calls(Type = typeof(DatatypeImplementation), Member = "GetSimpleTypeFromTypeCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlTypeCode)}, ReturnType = typeof(XmlSchemaSimpleType))]
	public static XmlSchemaSimpleType GetBuiltInSimpleType(XmlTypeCode typeCode) { }

	[CalledBy(Type = typeof(SchemaCollectionCompiler), Member = "CheckSubstitutionGroup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaSubstitutionGroup)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SchemaCollectionCompiler), Member = "IsValidRestriction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaParticle), typeof(XmlSchemaParticle)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(SchemaCollectionCompiler), Member = "IsElementFromElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaElement), typeof(XmlSchemaElement)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(SchemaCollectionCompiler), Member = "CompileLocalAttributes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaComplexType), typeof(XmlSchemaComplexType), typeof(XmlSchemaObjectCollection), typeof(XmlSchemaAnyAttribute), typeof(XmlSchemaDerivationMethod)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Compiler), Member = "ProcessSubstitutionGroups", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Compiler), Member = "IsElementFromElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaElement), typeof(XmlSchemaElement)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Compiler), Member = "CompileLocalAttributes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaComplexType), typeof(XmlSchemaComplexType), typeof(XmlSchemaObjectCollection), typeof(XmlSchemaAnyAttribute), typeof(XmlSchemaDerivationMethod)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Compiler), Member = "CheckAtrributeGroupRestriction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaAttributeGroup), typeof(XmlSchemaAttributeGroup)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSchemaValidator), Member = "GetSubstitutionGroupHead", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName)}, ReturnType = typeof(XmlSchemaElement))]
	[CalledBy(Type = typeof(XmlSchemaValidator), Member = "CheckXsiTypeAndNil", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SchemaElementDecl), typeof(string), typeof(string), typeof(Boolean&)}, ReturnType = typeof(SchemaElementDecl))]
	[CalledBy(Type = typeof(XsdValidator), Member = "ProcessElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XsdValidator), Member = "ThoroughGetElementDecl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SchemaElementDecl), typeof(XmlQualifiedName), typeof(string)}, ReturnType = typeof(SchemaElementDecl))]
	[CallerCount(Count = 12)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public static bool IsDerivedFrom(XmlSchemaType derivedType, XmlSchemaType baseType, XmlSchemaDerivationMethod except) { }

	[CalledBy(Type = typeof(SchemaCollectionCompiler), Member = "CompileSimpleContentRestriction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaComplexType), typeof(XmlSchemaSimpleContentRestriction)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Compiler), Member = "CompileSimpleContentRestriction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaComplexType), typeof(XmlSchemaSimpleContentRestriction)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	internal static bool IsDerivedFromDatatype(XmlSchemaDatatype derivedDataType, XmlSchemaDatatype baseDataType, XmlSchemaDerivationMethod except) { }

	[CalledBy(Type = typeof(DatatypeImplementation), Member = "StartBuiltinType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName), typeof(XmlSchemaDatatype)}, ReturnType = typeof(XmlSchemaSimpleType))]
	[CalledBy(Type = typeof(SchemaCollectionCompiler), Member = "CleanupElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaElement)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DatatypeImplementation), Member = "GetNormalizedStringTypeV1Compat", ReturnType = typeof(XmlSchemaSimpleType))]
	[CalledBy(Type = typeof(DatatypeImplementation), Member = "GetTokenTypeV1Compat", ReturnType = typeof(XmlSchemaSimpleType))]
	[CalledBy(Type = typeof(XmlSchemaInference), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SchemaCollectionCompiler), Member = "Cleanup", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SchemaCollectionCompiler), Member = "Cleanup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchema)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SchemaCollectionCompiler), Member = "CleanupAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaAttribute)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SchemaCollectionCompiler), Member = "CleanupComplexType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaComplexType)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SchemaCollectionCompiler), Member = "CleanupSimpleType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaSimpleType)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SchemaCollectionCompiler), Member = "CompileComplexType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaComplexType)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Compiler), Member = "CleanupAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaAttribute)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Compiler), Member = "CleanupComplexType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaComplexType)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Compiler), Member = "CleanupSimpleType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaSimpleType)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Compiler), Member = "CleanupElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaElement)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Compiler), Member = "CompileComplexType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaComplexType)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSchemaComplexType), Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSchemaComplexType), Member = "CreateAnyType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaContentProcessing)}, ReturnType = typeof(XmlSchemaComplexType))]
	[CalledBy(Type = typeof(SchemaCollectionCompiler), Member = "CleanupAttributes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaObjectCollection)}, ReturnType = typeof(void))]
	[CallerCount(Count = 23)]
	[CallsUnknownMethods(Count = 2)]
	internal void set_ElementDecl(SchemaElementDecl value) { }

	[CallerCount(Count = 5)]
	[DeduplicatedMethod]
	public void set_Final(XmlSchemaDerivationMethod value) { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	public override void set_IsMixed(bool value) { }

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
	internal void set_Redefined(XmlSchemaType value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	internal void SetBaseSchemaType(XmlSchemaType value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	internal void SetContentType(XmlSchemaContentType value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	internal void SetDatatype(XmlSchemaDatatype value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	internal void SetDerivedBy(XmlSchemaDerivationMethod value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	internal void SetFinalResolved(XmlSchemaDerivationMethod value) { }

	[CalledBy(Type = typeof(DatatypeImplementation), Member = "StartBuiltinType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName), typeof(XmlSchemaDatatype)}, ReturnType = typeof(XmlSchemaSimpleType))]
	[CalledBy(Type = typeof(Preprocessor), Member = "PreprocessSimpleType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaSimpleType), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Preprocessor), Member = "PreprocessComplexType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaComplexType), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SchemaCollectionPreprocessor), Member = "PreprocessSimpleType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaSimpleType), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SchemaCollectionPreprocessor), Member = "PreprocessComplexType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaComplexType), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSchemaComplexType), Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSchemaComplexType), Member = "CreateAnyType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaContentProcessing)}, ReturnType = typeof(XmlSchemaComplexType))]
	[CallerCount(Count = 7)]
	[CallsUnknownMethods(Count = 2)]
	internal void SetQualifiedName(XmlQualifiedName value) { }

}

