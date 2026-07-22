namespace System.Xml.Schema;

internal sealed class Preprocessor : BaseProcessor
{
	private static XmlSchema builtInSchemaForXmlNS; //Field offset: 0x0
	private string Xmlns; //Field offset: 0x40
	private string NsXsi; //Field offset: 0x48
	private string targetNamespace; //Field offset: 0x50
	private XmlSchema rootSchema; //Field offset: 0x58
	private XmlSchema currentSchema; //Field offset: 0x60
	private XmlSchemaForm elementFormDefault; //Field offset: 0x68
	private XmlSchemaForm attributeFormDefault; //Field offset: 0x6C
	private XmlSchemaDerivationMethod blockDefault; //Field offset: 0x70
	private XmlSchemaDerivationMethod finalDefault; //Field offset: 0x74
	private Hashtable schemaLocations; //Field offset: 0x78
	private Hashtable chameleonSchemas; //Field offset: 0x80
	private Hashtable referenceNamespaces; //Field offset: 0x88
	private Hashtable processedExternals; //Field offset: 0x90
	private SortedList lockList; //Field offset: 0x98
	private XmlReaderSettings readerSettings; //Field offset: 0xA0
	private XmlSchema rootSchemaForRedefine; //Field offset: 0xA8
	private ArrayList redefinedList; //Field offset: 0xB0
	private XmlResolver xmlResolver; //Field offset: 0xB8

	internal Hashtable ChameleonSchemas
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		internal set { } //Length: 16
	}

	internal XmlReaderSettings ReaderSettings
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		internal set { } //Length: 19
	}

	internal XmlSchema RootSchema
	{
		[CallerCount(Count = 10)]
		[DeduplicatedMethod]
		internal get { } //Length: 5
	}

	internal Hashtable SchemaLocations
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		internal set { } //Length: 13
	}

	internal XmlResolver XmlResolver
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		internal set { } //Length: 19
	}

	[CalledBy(Type = typeof(XmlSchemaSet), Member = "PreprocessSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchema&), typeof(string)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BaseProcessor), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNameTable), typeof(SchemaNames), typeof(ValidationEventHandler), typeof(XmlSchemaCompilationSettings)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Hashtable), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(SortedList), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public Preprocessor(XmlNameTable nameTable, SchemaNames schemaNames, ValidationEventHandler eventHandler, XmlSchemaCompilationSettings compilationSettings) { }

	[CalledBy(Type = typeof(Preprocessor), Member = "Preprocess", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchema), typeof(string), typeof(ArrayList)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	private void BuildRefNamespaces(XmlSchema schema) { }

	[CalledBy(Type = typeof(Preprocessor), Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchema), typeof(string), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Preprocessor), Member = "BuildSchemaList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchema)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(XmlSchema), Member = "get_SchemaId", ReturnType = typeof(int))]
	[Calls(Type = typeof(Preprocessor), Member = "BuildSchemaList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchema)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 4)]
	private void BuildSchemaList(XmlSchema schema) { }

	[CalledBy(Type = typeof(Preprocessor), Member = "PreprocessRedefine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RedefineEntry)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(XmlQualifiedName), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName), typeof(XmlQualifiedName)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BaseProcessor), Member = "SendValidationEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(XmlSchemaObject)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private void CheckRefinedAttributeGroup(XmlSchemaAttributeGroup attributeGroup) { }

	[CalledBy(Type = typeof(Preprocessor), Member = "PreprocessRedefine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RedefineEntry)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(XmlSchemaType), Member = "get_QualifiedName", ReturnType = typeof(XmlQualifiedName))]
	[Calls(Type = typeof(XmlQualifiedName), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName), typeof(XmlQualifiedName)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BaseProcessor), Member = "SendValidationEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(XmlSchemaObject)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 11)]
	private void CheckRefinedComplexType(XmlSchemaComplexType ctype) { }

	[CalledBy(Type = typeof(Preprocessor), Member = "PreprocessRedefine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RedefineEntry)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Preprocessor), Member = "CountGroupSelfReference", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaObjectCollection), typeof(XmlQualifiedName), typeof(XmlSchemaGroup)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(BaseProcessor), Member = "SendValidationEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(XmlSchemaObject)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void CheckRefinedGroup(XmlSchemaGroup group) { }

	[CalledBy(Type = typeof(Preprocessor), Member = "PreprocessRedefine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RedefineEntry)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(XmlSchemaType), Member = "get_QualifiedName", ReturnType = typeof(XmlQualifiedName))]
	[Calls(Type = typeof(XmlQualifiedName), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName), typeof(XmlQualifiedName)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BaseProcessor), Member = "SendValidationEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(XmlSchemaObject)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	private void CheckRefinedSimpleType(XmlSchemaSimpleType stype) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Preprocessor), Member = "GetBuildInSchema", ReturnType = typeof(XmlSchema))]
	[Calls(Type = typeof(XmlSchema), Member = "get_Attributes", ReturnType = typeof(XmlSchemaObjectTable))]
	[Calls(Type = typeof(XmlSchemaObjectTable), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSchema), Member = "get_AttributeGroups", ReturnType = typeof(XmlSchemaObjectTable))]
	[Calls(Type = typeof(XmlSchema), Member = "get_SchemaTypes", ReturnType = typeof(XmlSchemaObjectTable))]
	[Calls(Type = typeof(XmlSchema), Member = "get_Elements", ReturnType = typeof(XmlSchemaObjectTable))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void Cleanup(XmlSchema schema) { }

	[CalledBy(Type = typeof(Preprocessor), Member = "Preprocess", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchema), typeof(string), typeof(ArrayList)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(XmlSchemaObjectTable), Member = "Clear", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private void CleanupRedefine(XmlSchemaExternal include) { }

	[CalledBy(Type = typeof(Preprocessor), Member = "Preprocess", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchema), typeof(string), typeof(ArrayList)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(XmlSchema), Member = "get_Elements", ReturnType = typeof(XmlSchemaObjectTable))]
	[Calls(Type = typeof(XmlSchemaObjectTable), Member = "get_Values", ReturnType = typeof(ICollection))]
	[Calls(Type = typeof(BaseProcessor), Member = "AddToTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaObjectTable), typeof(XmlQualifiedName), typeof(XmlSchemaObject)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSchema), Member = "get_Attributes", ReturnType = typeof(XmlSchemaObjectTable))]
	[Calls(Type = typeof(XmlSchema), Member = "get_AttributeGroups", ReturnType = typeof(XmlSchemaObjectTable))]
	[Calls(Type = typeof(XmlSchema), Member = "get_SchemaTypes", ReturnType = typeof(XmlSchemaObjectTable))]
	[Calls(Type = typeof(XmlSchemaType), Member = "get_QualifiedName", ReturnType = typeof(XmlQualifiedName))]
	[CallsDeduplicatedMethods(Count = 11)]
	[CallsUnknownMethods(Count = 73)]
	private void CopyIncludedComponents(XmlSchema includedSchema, XmlSchema schema) { }

	[CalledBy(Type = typeof(Preprocessor), Member = "CountGroupSelfReference", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaObjectCollection), typeof(XmlQualifiedName), typeof(XmlSchemaGroup)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(Preprocessor), Member = "CheckRefinedGroup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaGroup)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(XmlQualifiedName), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName), typeof(XmlQualifiedName)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Decimal), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal), typeof(Decimal)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BaseProcessor), Member = "SendValidationEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(XmlSchemaObject)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Preprocessor), Member = "CountGroupSelfReference", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaObjectCollection), typeof(XmlQualifiedName), typeof(XmlSchemaGroup)}, ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 3)]
	private int CountGroupSelfReference(XmlSchemaObjectCollection items, XmlQualifiedName name, XmlSchemaGroup redefined) { }

	[CalledBy(Type = typeof(XmlSchemaSet), Member = "PreprocessSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchema&), typeof(string)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(XmlSchema), Member = "get_ImportedSchemas", ReturnType = typeof(ArrayList))]
	[Calls(Type = typeof(XmlSchema), Member = "get_ImportedNamespaces", ReturnType = typeof(ArrayList))]
	[Calls(Type = typeof(Uri), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(Uri)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Preprocessor), Member = "GetChameleonSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(XmlSchema)}, ReturnType = typeof(XmlSchema))]
	[Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BaseProcessor), Member = "SendValidationEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(XmlSchemaObject)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Preprocessor), Member = "LoadExternals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchema)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Preprocessor), Member = "BuildSchemaList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchema)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Preprocessor), Member = "Preprocess", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchema), typeof(string), typeof(ArrayList)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Preprocessor), Member = "PreprocessRedefine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RedefineEntry)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 12)]
	[CallsUnknownMethods(Count = 17)]
	public bool Execute(XmlSchema schema, string targetNamespace, bool loadExternals) { }

	[CallerCount(Count = 10)]
	[DeduplicatedMethod]
	internal XmlSchema get_RootSchema() { }

	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "set_XmlValidatingReaderCompatibilityMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSchemaValidator), Member = "AddXmlNamespaceSchema", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSchemaSet), Member = "AddToTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaObjectTable), typeof(XmlQualifiedName), typeof(XmlSchemaObject)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XmlSchemaSet), Member = "Compile", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSchema), Member = "set_IsRedefined", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSchemaValidator), Member = "CheckIsXmlAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName)}, ReturnType = typeof(SchemaAttDef))]
	[CalledBy(Type = typeof(Preprocessor), Member = "Preprocess", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchema), typeof(string), typeof(ArrayList)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Preprocessor), Member = "LoadExternals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchema)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Preprocessor), Member = "Cleanup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchema)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BaseProcessor), Member = "AddToTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaObjectTable), typeof(XmlQualifiedName), typeof(XmlSchemaObject)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SchemaCollectionPreprocessor), Member = "LoadExternals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchema), typeof(XmlSchemaCollection)}, ReturnType = typeof(void))]
	[CallerCount(Count = 12)]
	[Calls(Type = typeof(XmlSchemaSimpleTypeRestriction), Member = "set_BaseTypeName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSchema), Member = "CompileSchemaInSet", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNameTable), typeof(ValidationEventHandler), typeof(XmlSchemaCompilationSettings)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NameTable), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSchemaAttribute), Member = "set_RefName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSchemaAttributeGroup), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSchemaEnumerationFacet), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSchemaSimpleTypeRestriction), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSchemaObject), Member = "get_Namespaces", ReturnType = typeof(XmlSerializerNamespaces))]
	[Calls(Type = typeof(XmlSchemaAttribute), Member = "set_SchemaTypeName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlQualifiedName), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSchemaAttribute), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSerializerNamespaces), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSchema), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSchemaObjectCollection), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaObject)}, ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 12)]
	internal static XmlSchema GetBuildInSchema() { }

	[CalledBy(Type = typeof(Preprocessor), Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchema), typeof(string), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Preprocessor), Member = "Preprocess", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchema), typeof(string), typeof(ArrayList)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ChameleonKey), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(XmlSchema)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSchema), Member = "DeepClone", ReturnType = typeof(XmlSchema))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	private XmlSchema GetChameleonSchema(string targetNamespace, XmlSchema schema) { }

	[CalledBy(Type = typeof(Preprocessor), Member = "PreprocessRedefine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RedefineEntry)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Preprocessor), Member = "GetIncludedSet", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchema), typeof(ArrayList)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Preprocessor), Member = "GetIncludedSet", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchema), typeof(ArrayList)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 2)]
	private void GetIncludedSet(XmlSchema schema, ArrayList includesList) { }

	[CalledBy(Type = typeof(Compiler), Member = "CompileSimpleType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaSimpleType)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	internal static XmlSchema GetParentSchema(XmlSchemaObject currentSchemaObject) { }

	[CalledBy(Type = typeof(Preprocessor), Member = "LoadExternals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchema)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private object GetSchemaEntity(Uri ruri) { }

	[CalledBy(Type = typeof(Preprocessor), Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchema), typeof(string), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Preprocessor), Member = "LoadExternals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchema)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Uri), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(Uri)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BaseProcessor), Member = "SendValidationEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(XmlSchemaObject), typeof(XmlSeverityType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseProcessor), Member = "SendValidationEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaException), typeof(XmlSeverityType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSchemaException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[]), typeof(Exception), typeof(string), typeof(int), typeof(int), typeof(XmlSchemaObject)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseProcessor), Member = "SendValidationEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(string), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Preprocessor), Member = "LoadExternals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchema)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Parser), Member = "ParseReaderNode", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Parser), Member = "StartParsing", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlReader), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Parser), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SchemaType), typeof(XmlNameTable), typeof(SchemaNames), typeof(ValidationEventHandler)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseProcessor), Member = "get_SchemaNames", ReturnType = typeof(SchemaNames))]
	[Calls(Type = typeof(XmlReader), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(XmlReaderSettings), typeof(string)}, ReturnType = typeof(XmlReader))]
	[Calls(Type = typeof(XmlReader), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextReader), typeof(XmlReaderSettings), typeof(string)}, ReturnType = typeof(XmlReader))]
	[Calls(Type = typeof(XmlReaderSettings), Member = "set_XmlResolver", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlResolver)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlReaderSettings), Member = "set_CloseInput", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(Preprocessor), Member = "GetSchemaEntity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(Preprocessor), Member = "GetBuildInSchema", ReturnType = typeof(XmlSchema))]
	[Calls(Type = typeof(Uri), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(Uri)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlSchema), Member = "get_ImportedNamespaces", ReturnType = typeof(ArrayList))]
	[CallsDeduplicatedMethods(Count = 25)]
	[CallsUnknownMethods(Count = 25)]
	private void LoadExternals(XmlSchema schema) { }

	[CalledBy(Type = typeof(Preprocessor), Member = "Preprocess", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchema), typeof(string), typeof(ArrayList)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Preprocessor), Member = "PreprocessNotation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaNotation)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(XmlConvert), Member = "ToUri", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Uri))]
	[Calls(Type = typeof(BaseProcessor), Member = "SendValidationEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[]), typeof(Exception), typeof(XmlSchemaObject)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	private void ParseUri(string uri, string code, XmlSchemaObject sourceSchemaObject) { }

	[CalledBy(Type = typeof(Preprocessor), Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchema), typeof(string), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Preprocessor), Member = "Preprocess", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchema), typeof(string), typeof(ArrayList)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Preprocessor), Member = "SetSchemaDefaults", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchema)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Uri), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(Uri)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ArrayList), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(Preprocessor), Member = "CopyIncludedComponents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchema), typeof(XmlSchema)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSchema), Member = "get_ImportedNamespaces", ReturnType = typeof(ArrayList))]
	[Calls(Type = typeof(Preprocessor), Member = "PreprocessAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaAttribute)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Preprocessor), Member = "PreprocessAnnotation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaAnnotation)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Preprocessor), Member = "PreprocessNotation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaNotation)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Preprocessor), Member = "PreprocessGroup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaGroup)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Preprocessor), Member = "PreprocessElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaElement)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Preprocessor), Member = "PreprocessSimpleType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaSimpleType), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSchemaType), Member = "get_QualifiedName", ReturnType = typeof(XmlQualifiedName))]
	[Calls(Type = typeof(Preprocessor), Member = "PreprocessComplexType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaComplexType), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Preprocessor), Member = "PreprocessAttributeGroup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaAttributeGroup)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseProcessor), Member = "AddToTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaObjectTable), typeof(XmlQualifiedName), typeof(XmlSchemaObject)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSchemaObjectCollection), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaObject)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Preprocessor), Member = "ValidateIdAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaObject)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Preprocessor), Member = "BuildRefNamespaces", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchema)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Preprocessor), Member = "GetChameleonSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(XmlSchema)}, ReturnType = typeof(XmlSchema))]
	[Calls(Type = typeof(Preprocessor), Member = "Preprocess", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchema), typeof(string), typeof(ArrayList)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Preprocessor), Member = "ParseUri", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(XmlSchemaObject)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseProcessor), Member = "SendValidationEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(XmlSchemaObject)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DatatypeImplementation), Member = "GetSimpleTypeFromTypeCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlTypeCode)}, ReturnType = typeof(XmlSchemaSimpleType))]
	[Calls(Type = typeof(Preprocessor), Member = "GetBuildInSchema", ReturnType = typeof(XmlSchema))]
	[Calls(Type = typeof(XmlSchema), Member = "get_Attributes", ReturnType = typeof(XmlSchemaObjectTable))]
	[Calls(Type = typeof(XmlSchemaObjectTable), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSchema), Member = "get_AttributeGroups", ReturnType = typeof(XmlSchemaObjectTable))]
	[Calls(Type = typeof(XmlSchema), Member = "get_SchemaTypes", ReturnType = typeof(XmlSchemaObjectTable))]
	[Calls(Type = typeof(Preprocessor), Member = "PreprocessAnnotation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaObject)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseProcessor), Member = "SendValidationEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(XmlSchemaObject)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSchemaDatatype), Member = "get_TypeCodeString", ReturnType = typeof(string))]
	[Calls(Type = typeof(BaseProcessor), Member = "SendValidationEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[]), typeof(Exception), typeof(XmlSchemaObject)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Preprocessor), Member = "CleanupRedefine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaExternal)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BaseProcessor), Member = "SendValidationEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(XmlSchemaObject)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSchema), Member = "get_Elements", ReturnType = typeof(XmlSchemaObjectTable))]
	[CallsDeduplicatedMethods(Count = 29)]
	[CallsUnknownMethods(Count = 38)]
	private void Preprocess(XmlSchema schema, string targetNamespace, ArrayList imports) { }

	[CalledBy(Type = typeof(Preprocessor), Member = "Preprocess", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchema), typeof(string), typeof(ArrayList)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Preprocessor), Member = "ValidateIdAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaObject)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	private void PreprocessAnnotation(XmlSchemaAnnotation annotation) { }

	[CalledBy(Type = typeof(Preprocessor), Member = "PreprocessSimpleType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaSimpleType), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Preprocessor), Member = "Preprocess", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchema), typeof(string), typeof(ArrayList)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Preprocessor), Member = "PreprocessLocalAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaAttribute)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Preprocessor), Member = "PreprocessAttributeContent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaAttribute)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Preprocessor), Member = "PreprocessAttributeGroup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaAttributeGroup)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Preprocessor), Member = "PreprocessLocalElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaElement)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Preprocessor), Member = "PreprocessElementContent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaElement)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Preprocessor), Member = "PreprocessIdentityConstraint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaIdentityConstraint)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Preprocessor), Member = "PreprocessComplexType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaComplexType), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Preprocessor), Member = "PreprocessGroup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaGroup)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Preprocessor), Member = "PreprocessNotation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaNotation)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Preprocessor), Member = "PreprocessParticle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaParticle)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Preprocessor), Member = "PreprocessAttributes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaObjectCollection), typeof(XmlSchemaAnyAttribute), typeof(XmlSchemaObject)}, ReturnType = typeof(void))]
	[CallerCount(Count = 17)]
	[Calls(Type = typeof(Preprocessor), Member = "ValidateIdAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaObject)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	private void PreprocessAnnotation(XmlSchemaObject schemaObject) { }

	[CalledBy(Type = typeof(Preprocessor), Member = "Preprocess", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchema), typeof(string), typeof(ArrayList)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BaseProcessor), Member = "SendValidationEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(XmlSchemaObject)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Preprocessor), Member = "ValidateNameAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaObject)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlQualifiedName), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Preprocessor), Member = "PreprocessAttributeContent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaAttribute)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Preprocessor), Member = "ValidateIdAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaObject)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	private void PreprocessAttribute(XmlSchemaAttribute attribute) { }

	[CalledBy(Type = typeof(Preprocessor), Member = "PreprocessAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaAttribute)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Preprocessor), Member = "PreprocessLocalAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaAttribute)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Preprocessor), Member = "PreprocessAnnotation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaObject)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseProcessor), Member = "SendValidationEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(XmlSchemaObject)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlQualifiedName), Member = "get_IsEmpty", ReturnType = typeof(bool))]
	[Calls(Type = typeof(BaseProcessor), Member = "SendValidationEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(XmlSchemaObject)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Preprocessor), Member = "PreprocessSimpleType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaSimpleType), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Preprocessor), Member = "ValidateQNameAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaObject), typeof(string), typeof(XmlQualifiedName)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	private void PreprocessAttributeContent(XmlSchemaAttribute attribute) { }

	[CalledBy(Type = typeof(Preprocessor), Member = "Preprocess", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchema), typeof(string), typeof(ArrayList)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Preprocessor), Member = "PreprocessRedefine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RedefineEntry)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(BaseProcessor), Member = "SendValidationEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(XmlSchemaObject)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Preprocessor), Member = "ValidateNameAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaObject)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlQualifiedName), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Preprocessor), Member = "PreprocessAttributes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaObjectCollection), typeof(XmlSchemaAnyAttribute), typeof(XmlSchemaObject)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Preprocessor), Member = "PreprocessAnnotation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaObject)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Preprocessor), Member = "ValidateIdAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaObject)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	private void PreprocessAttributeGroup(XmlSchemaAttributeGroup attributeGroup) { }

	[CalledBy(Type = typeof(Preprocessor), Member = "PreprocessAttributeGroup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaAttributeGroup)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Preprocessor), Member = "PreprocessComplexType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaComplexType), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Preprocessor), Member = "PreprocessLocalAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaAttribute)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlQualifiedName), Member = "get_IsEmpty", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Preprocessor), Member = "ValidateQNameAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaObject), typeof(string), typeof(XmlQualifiedName)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseProcessor), Member = "SendValidationEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(XmlSchemaObject)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Preprocessor), Member = "PreprocessAnnotation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaObject)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Preprocessor), Member = "ValidateIdAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaObject)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSchemaAnyAttribute), Member = "BuildNamespaceList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseProcessor), Member = "SendValidationEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[]), typeof(Exception), typeof(XmlSchemaObject)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 8)]
	private void PreprocessAttributes(XmlSchemaObjectCollection attributes, XmlSchemaAnyAttribute anyAttribute, XmlSchemaObject parent) { }

	[CalledBy(Type = typeof(Preprocessor), Member = "Preprocess", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchema), typeof(string), typeof(ArrayList)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Preprocessor), Member = "PreprocessRedefine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RedefineEntry)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Preprocessor), Member = "PreprocessElementContent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaElement)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(Preprocessor), Member = "ValidateIdAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaObject)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Preprocessor), Member = "PreprocessSimpleType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaSimpleType), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseProcessor), Member = "SendValidationEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(XmlSchemaObject)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlQualifiedName), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName), typeof(XmlQualifiedName)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlSchemaType), Member = "get_QualifiedName", ReturnType = typeof(XmlQualifiedName))]
	[Calls(Type = typeof(Preprocessor), Member = "ValidateQNameAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaObject), typeof(string), typeof(XmlQualifiedName)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlQualifiedName), Member = "get_IsEmpty", ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlSchemaComplexContent), Member = "set_IsMixed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Preprocessor), Member = "PreprocessAttributes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaObjectCollection), typeof(XmlSchemaAnyAttribute), typeof(XmlSchemaObject)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSchemaComplexType), Member = "get_Attributes", ReturnType = typeof(XmlSchemaObjectCollection))]
	[Calls(Type = typeof(Preprocessor), Member = "PreprocessParticle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaParticle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseProcessor), Member = "SendValidationEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(XmlSchemaObject)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSchemaType), Member = "SetQualifiedName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlQualifiedName), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Preprocessor), Member = "ValidateNameAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaObject)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseProcessor), Member = "SendValidationEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(XmlSchemaObject)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Preprocessor), Member = "PreprocessAnnotation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaObject)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallsUnknownMethods(Count = 17)]
	private void PreprocessComplexType(XmlSchemaComplexType complexType, bool local) { }

	[CalledBy(Type = typeof(Preprocessor), Member = "Preprocess", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchema), typeof(string), typeof(ArrayList)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(BaseProcessor), Member = "SendValidationEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(XmlSchemaObject)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Preprocessor), Member = "ValidateNameAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaObject)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlQualifiedName), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Preprocessor), Member = "PreprocessElementContent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaElement)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseProcessor), Member = "SendValidationEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(XmlSchemaObject)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSchemaParticle), Member = "get_MinOccursString", ReturnType = typeof(string))]
	[Calls(Type = typeof(XmlSchemaParticle), Member = "get_MaxOccursString", ReturnType = typeof(string))]
	[Calls(Type = typeof(XmlQualifiedName), Member = "get_IsEmpty", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Preprocessor), Member = "ValidateQNameAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaObject), typeof(string), typeof(XmlQualifiedName)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Preprocessor), Member = "ValidateIdAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaObject)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	private void PreprocessElement(XmlSchemaElement element) { }

	[CalledBy(Type = typeof(Preprocessor), Member = "PreprocessElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaElement)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Preprocessor), Member = "PreprocessLocalElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaElement)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Preprocessor), Member = "PreprocessAnnotation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaObject)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlQualifiedName), Member = "get_IsEmpty", ReturnType = typeof(bool))]
	[Calls(Type = typeof(BaseProcessor), Member = "SendValidationEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(XmlSchemaObject)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseProcessor), Member = "SendValidationEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(XmlSchemaObject)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Preprocessor), Member = "PreprocessSimpleType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaSimpleType), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Preprocessor), Member = "ValidateQNameAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaObject), typeof(string), typeof(XmlQualifiedName)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSchemaElement), Member = "get_Constraints", ReturnType = typeof(XmlSchemaObjectCollection))]
	[Calls(Type = typeof(Preprocessor), Member = "PreprocessIdentityConstraint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaIdentityConstraint)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Preprocessor), Member = "PreprocessComplexType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaComplexType), typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 6)]
	private void PreprocessElementContent(XmlSchemaElement element) { }

	[CalledBy(Type = typeof(Preprocessor), Member = "Preprocess", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchema), typeof(string), typeof(ArrayList)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Preprocessor), Member = "PreprocessRedefine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RedefineEntry)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(BaseProcessor), Member = "SendValidationEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(XmlSchemaObject)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Preprocessor), Member = "ValidateNameAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaObject)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlQualifiedName), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSchemaParticle), Member = "get_MinOccursString", ReturnType = typeof(string))]
	[Calls(Type = typeof(XmlSchemaParticle), Member = "get_MaxOccursString", ReturnType = typeof(string))]
	[Calls(Type = typeof(Preprocessor), Member = "PreprocessParticle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaParticle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Preprocessor), Member = "PreprocessAnnotation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaObject)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Preprocessor), Member = "ValidateIdAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaObject)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseProcessor), Member = "SendValidationEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(XmlSchemaObject)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	private void PreprocessGroup(XmlSchemaGroup group) { }

	[CalledBy(Type = typeof(Preprocessor), Member = "PreprocessElementContent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaElement)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Preprocessor), Member = "PreprocessAnnotation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaObject)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseProcessor), Member = "SendValidationEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(XmlSchemaObject)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Preprocessor), Member = "ValidateNameAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaObject)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlQualifiedName), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSchemaObjectTable), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName)}, ReturnType = typeof(XmlSchemaObject))]
	[Calls(Type = typeof(XmlSchemaObjectTable), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName), typeof(XmlSchemaObject)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseProcessor), Member = "SendValidationEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(XmlSchemaObject)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlQualifiedName), Member = "get_IsEmpty", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Preprocessor), Member = "ValidateQNameAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaObject), typeof(string), typeof(XmlQualifiedName)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Preprocessor), Member = "ValidateIdAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaObject)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 5)]
	private void PreprocessIdentityConstraint(XmlSchemaIdentityConstraint constraint) { }

	[CalledBy(Type = typeof(Preprocessor), Member = "PreprocessAttributes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaObjectCollection), typeof(XmlSchemaAnyAttribute), typeof(XmlSchemaObject)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Preprocessor), Member = "PreprocessAnnotation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaObject)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlQualifiedName), Member = "get_IsEmpty", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Preprocessor), Member = "ValidateQNameAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaObject), typeof(string), typeof(XmlQualifiedName)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseProcessor), Member = "SendValidationEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(XmlSchemaObject)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseProcessor), Member = "SendValidationEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(XmlSchemaObject)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Preprocessor), Member = "ValidateNameAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaObject)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Preprocessor), Member = "PreprocessAttributeContent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaAttribute)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlQualifiedName), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Preprocessor), Member = "ValidateIdAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaObject)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	private void PreprocessLocalAttribute(XmlSchemaAttribute attribute) { }

	[CalledBy(Type = typeof(Preprocessor), Member = "PreprocessParticle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaParticle)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Preprocessor), Member = "PreprocessAnnotation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaObject)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlQualifiedName), Member = "get_IsEmpty", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Preprocessor), Member = "ValidateQNameAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaObject), typeof(string), typeof(XmlQualifiedName)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseProcessor), Member = "SendValidationEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(XmlSchemaObject)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSchemaElement), Member = "get_HasConstraints", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Preprocessor), Member = "ValidateNameAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaObject)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Preprocessor), Member = "PreprocessElementContent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaElement)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlQualifiedName), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Decimal), Member = "op_GreaterThan", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal), typeof(Decimal)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlSchemaParticle), Member = "set_MinOccurs", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseProcessor), Member = "SendValidationEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(XmlSchemaObject)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Preprocessor), Member = "ValidateIdAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaObject)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	private void PreprocessLocalElement(XmlSchemaElement element) { }

	[CalledBy(Type = typeof(Preprocessor), Member = "Preprocess", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchema), typeof(string), typeof(ArrayList)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(BaseProcessor), Member = "SendValidationEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(XmlSchemaObject)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Preprocessor), Member = "ValidateNameAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaObject)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlQualifiedName), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseProcessor), Member = "SendValidationEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(XmlSchemaObject)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlConvert), Member = "VerifyTOKEN", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(BaseProcessor), Member = "SendValidationEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[]), typeof(Exception), typeof(XmlSchemaObject)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Preprocessor), Member = "ParseUri", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(XmlSchemaObject)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Preprocessor), Member = "PreprocessAnnotation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaObject)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Preprocessor), Member = "ValidateIdAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaObject)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 6)]
	private void PreprocessNotation(XmlSchemaNotation notation) { }

	[CalledBy(Type = typeof(Preprocessor), Member = "PreprocessComplexType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaComplexType), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Preprocessor), Member = "PreprocessGroup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaGroup)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Preprocessor), Member = "PreprocessParticle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaParticle)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(BaseProcessor), Member = "SendValidationEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[]), typeof(Exception), typeof(XmlSchemaObject)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSchemaAny), Member = "BuildNamespaceList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseProcessor), Member = "SendValidationEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(XmlSchemaObject)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Preprocessor), Member = "ValidateIdAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaObject)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Preprocessor), Member = "PreprocessAnnotation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaObject)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Preprocessor), Member = "ValidateQNameAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaObject), typeof(string), typeof(XmlQualifiedName)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlQualifiedName), Member = "get_IsEmpty", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Decimal), Member = "op_GreaterThan", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal), typeof(Decimal)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Preprocessor), Member = "PreprocessLocalElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaElement)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSchemaParticle), Member = "set_MaxOccurs", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseProcessor), Member = "SendValidationEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(XmlSchemaObject)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSchemaParticle), Member = "set_MinOccurs", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Decimal), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal), typeof(Decimal)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Preprocessor), Member = "PreprocessParticle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaParticle)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 14)]
	[CallsUnknownMethods(Count = 16)]
	private void PreprocessParticle(XmlSchemaParticle particle) { }

	[CalledBy(Type = typeof(Preprocessor), Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchema), typeof(string), typeof(bool)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BaseProcessor), Member = "SendValidationEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(XmlSchemaObject), typeof(XmlSeverityType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Preprocessor), Member = "CheckRefinedAttributeGroup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaAttributeGroup)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSchema), Member = "get_AttributeGroups", ReturnType = typeof(XmlSchemaObjectTable))]
	[Calls(Type = typeof(Preprocessor), Member = "PreprocessAttributeGroup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaAttributeGroup)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Preprocessor), Member = "CheckRefinedComplexType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaComplexType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Preprocessor), Member = "PreprocessComplexType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaComplexType), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseProcessor), Member = "SendValidationEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(XmlSchemaObject)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Preprocessor), Member = "CheckRefinedSimpleType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaSimpleType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSchema), Member = "get_SchemaTypes", ReturnType = typeof(XmlSchemaObjectTable))]
	[Calls(Type = typeof(XmlSchemaType), Member = "get_QualifiedName", ReturnType = typeof(XmlQualifiedName))]
	[Calls(Type = typeof(Preprocessor), Member = "PreprocessSimpleType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaSimpleType), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseProcessor), Member = "SendValidationEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(XmlSchemaObject)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Preprocessor), Member = "CheckRefinedGroup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaGroup)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSchemaObjectTable), Member = "Insert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName), typeof(XmlSchemaObject)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseProcessor), Member = "AddToTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaObjectTable), typeof(XmlQualifiedName), typeof(XmlSchemaObject)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSchemaObjectTable), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName)}, ReturnType = typeof(XmlSchemaObject))]
	[Calls(Type = typeof(Preprocessor), Member = "PreprocessGroup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaGroup)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Preprocessor), Member = "GetIncludedSet", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchema), typeof(ArrayList)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArrayList), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(Preprocessor), Member = "SetSchemaDefaults", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchema)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 13)]
	[CallsUnknownMethods(Count = 22)]
	private void PreprocessRedefine(RedefineEntry redefineEntry) { }

	[CalledBy(Type = typeof(Preprocessor), Member = "Preprocess", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchema), typeof(string), typeof(ArrayList)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Preprocessor), Member = "PreprocessRedefine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RedefineEntry)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Preprocessor), Member = "PreprocessAttributeContent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaAttribute)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Preprocessor), Member = "PreprocessElementContent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaElement)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Preprocessor), Member = "PreprocessSimpleType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaSimpleType), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Preprocessor), Member = "PreprocessComplexType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaComplexType), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(Preprocessor), Member = "ValidateIdAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaObject)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Preprocessor), Member = "PreprocessAnnotation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaObject)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Preprocessor), Member = "PreprocessSimpleType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaSimpleType), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Preprocessor), Member = "ValidateQNameAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaObject), typeof(string), typeof(XmlQualifiedName)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlQualifiedName), Member = "get_IsEmpty", ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlQualifiedName), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSchemaType), Member = "SetQualifiedName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Preprocessor), Member = "ValidateNameAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaObject)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseProcessor), Member = "SendValidationEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(XmlSchemaObject)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseProcessor), Member = "SendValidationEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(XmlSchemaObject)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 12)]
	private void PreprocessSimpleType(XmlSchemaSimpleType simpleType, bool local) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private Uri ResolveSchemaLocationUri(XmlSchema enclosingSchema, string location) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	internal void set_ChameleonSchemas(Hashtable value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	internal void set_ReaderSettings(XmlReaderSettings value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	internal void set_SchemaLocations(Hashtable value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	internal void set_XmlResolver(XmlResolver value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	private void SetParent(XmlSchemaObject child, XmlSchemaObject parent) { }

	[CalledBy(Type = typeof(Preprocessor), Member = "Preprocess", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchema), typeof(string), typeof(ArrayList)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Preprocessor), Member = "PreprocessRedefine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RedefineEntry)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(BaseProcessor), Member = "SendValidationEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(XmlSchemaObject)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private void SetSchemaDefaults(XmlSchema schema) { }

	[CalledBy(Type = typeof(Preprocessor), Member = "Preprocess", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchema), typeof(string), typeof(ArrayList)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Preprocessor), Member = "PreprocessAnnotation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaAnnotation)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Preprocessor), Member = "PreprocessAnnotation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaObject)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Preprocessor), Member = "PreprocessAttributes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaObjectCollection), typeof(XmlSchemaAnyAttribute), typeof(XmlSchemaObject)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Preprocessor), Member = "PreprocessParticle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaParticle)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Preprocessor), Member = "PreprocessGroup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaGroup)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Preprocessor), Member = "PreprocessComplexType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaComplexType), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Preprocessor), Member = "PreprocessNotation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaNotation)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Preprocessor), Member = "PreprocessIdentityConstraint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaIdentityConstraint)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Preprocessor), Member = "PreprocessLocalElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaElement)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Preprocessor), Member = "PreprocessElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaElement)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Preprocessor), Member = "PreprocessAttributeGroup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaAttributeGroup)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Preprocessor), Member = "PreprocessLocalAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaAttribute)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Preprocessor), Member = "PreprocessAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaAttribute)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Preprocessor), Member = "PreprocessSimpleType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaSimpleType), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 23)]
	[Calls(Type = typeof(XmlConvert), Member = "VerifyNCName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(BaseProcessor), Member = "SendValidationEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(XmlSchemaObject)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseProcessor), Member = "SendValidationEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[]), typeof(Exception), typeof(XmlSchemaObject)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseProcessor), Member = "SendValidationEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(XmlSchemaObject)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 11)]
	private void ValidateIdAttribute(XmlSchemaObject xso) { }

	[CalledBy(Type = typeof(Preprocessor), Member = "PreprocessAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaAttribute)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Preprocessor), Member = "PreprocessNotation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaNotation)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Preprocessor), Member = "PreprocessComplexType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaComplexType), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Preprocessor), Member = "PreprocessSimpleType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaSimpleType), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Preprocessor), Member = "PreprocessIdentityConstraint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaIdentityConstraint)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Preprocessor), Member = "PreprocessGroup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaGroup)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Preprocessor), Member = "PreprocessElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaElement)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Preprocessor), Member = "PreprocessAttributeGroup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaAttributeGroup)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Preprocessor), Member = "PreprocessLocalAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaAttribute)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Preprocessor), Member = "PreprocessLocalElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaElement)}, ReturnType = typeof(void))]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(BaseProcessor), Member = "SendValidationEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(XmlSchemaObject)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlComplianceUtil), Member = "NonCDataNormalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ValidateNames), Member = "ParseNCName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(XmlException), Member = "BuildCharExceptionArgs", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(String[]))]
	[Calls(Type = typeof(Res), Member = "GetString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 15)]
	private void ValidateNameAttribute(XmlSchemaObject xso) { }

	[CalledBy(Type = typeof(Preprocessor), Member = "PreprocessLocalAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaAttribute)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Preprocessor), Member = "PreprocessAttributes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaObjectCollection), typeof(XmlSchemaAnyAttribute), typeof(XmlSchemaObject)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Preprocessor), Member = "PreprocessComplexType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaComplexType), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Preprocessor), Member = "PreprocessSimpleType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaSimpleType), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Preprocessor), Member = "PreprocessIdentityConstraint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaIdentityConstraint)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Preprocessor), Member = "PreprocessParticle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaParticle)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Preprocessor), Member = "PreprocessLocalElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaElement)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Preprocessor), Member = "PreprocessElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaElement)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Preprocessor), Member = "PreprocessAttributeContent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaAttribute)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Preprocessor), Member = "PreprocessElementContent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaElement)}, ReturnType = typeof(void))]
	[CallerCount(Count = 14)]
	[Calls(Type = typeof(XmlQualifiedName), Member = "Verify", ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlQualifiedName), Member = "Atomize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNameTable)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseProcessor), Member = "SendValidationEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(XmlSchemaObject), typeof(XmlSeverityType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseProcessor), Member = "SendValidationEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[]), typeof(Exception), typeof(XmlSchemaObject)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 11)]
	private void ValidateQNameAttribute(XmlSchemaObject xso, string attributeName, XmlQualifiedName value) { }

}

