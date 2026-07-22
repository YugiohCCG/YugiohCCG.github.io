namespace System.Xml.Schema;

internal class BaseProcessor
{
	private XmlNameTable nameTable; //Field offset: 0x10
	private SchemaNames schemaNames; //Field offset: 0x18
	private ValidationEventHandler eventHandler; //Field offset: 0x20
	private XmlSchemaCompilationSettings compilationSettings; //Field offset: 0x28
	private int errorCount; //Field offset: 0x30
	private string NsXml; //Field offset: 0x38

	protected XmlSchemaCompilationSettings CompilationSettings
	{
		[CallerCount(Count = 15)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	protected ValidationEventHandler EventHandler
	{
		[CallerCount(Count = 12)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	protected bool HasErrors
	{
		[CallerCount(Count = 10)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		 get { } //Length: 8
	}

	protected XmlNameTable NameTable
	{
		[CallerCount(Count = 106)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	protected SchemaNames SchemaNames
	{
		[CalledBy(Type = typeof(Preprocessor), Member = "LoadExternals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchema)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(SchemaCollectionPreprocessor), Member = "LoadExternals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchema), typeof(XmlSchemaCollection)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(SchemaNames), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNameTable)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 123
	}

	[CalledBy(Type = typeof(SchemaCollectionCompiler), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNameTable), typeof(ValidationEventHandler)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SchemaCollectionPreprocessor), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNameTable), typeof(SchemaNames), typeof(ValidationEventHandler)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 6)]
	public BaseProcessor(XmlNameTable nameTable, SchemaNames schemaNames, ValidationEventHandler eventHandler) { }

	[CalledBy(Type = typeof(Preprocessor), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNameTable), typeof(SchemaNames), typeof(ValidationEventHandler), typeof(XmlSchemaCompilationSettings)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Compiler), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNameTable), typeof(ValidationEventHandler), typeof(XmlSchema), typeof(XmlSchemaCompilationSettings)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 6)]
	public BaseProcessor(XmlNameTable nameTable, SchemaNames schemaNames, ValidationEventHandler eventHandler, XmlSchemaCompilationSettings compilationSettings) { }

	[CalledBy(Type = typeof(Preprocessor), Member = "Preprocess", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchema), typeof(string), typeof(ArrayList)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Preprocessor), Member = "CopyIncludedComponents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchema), typeof(XmlSchema)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Preprocessor), Member = "PreprocessRedefine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RedefineEntry)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SchemaCollectionPreprocessor), Member = "Preprocess", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchema), typeof(string), "System.Xml.Schema.SchemaCollectionPreprocessor+Compositor"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SchemaCollectionPreprocessor), Member = "PreprocessRedefine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaRedefine)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Compiler), Member = "Prepare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchema), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 29)]
	[Calls(Type = typeof(ValidationEventArgs), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaException), typeof(XmlSeverityType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSchemaException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(XmlSchemaObject)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseProcessor), Member = "IsValidTypeRedefine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaObject), typeof(XmlSchemaObject), typeof(XmlSchemaObjectTable)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlSchema), Member = "get_Attributes", ReturnType = typeof(XmlSchemaObjectTable))]
	[Calls(Type = typeof(XmlSchema), Member = "get_AttributeGroups", ReturnType = typeof(XmlSchemaObjectTable))]
	[Calls(Type = typeof(XmlSchemaAttributeGroup), Member = "get_AttributeUses", ReturnType = typeof(XmlSchemaObjectTable))]
	[Calls(Type = typeof(XmlSchemaObjectTable), Member = "Insert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName), typeof(XmlSchemaObject)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSchemaObjectTable), Member = "get_Count", ReturnType = typeof(int))]
	[Calls(Type = typeof(XmlSchemaObjectTable), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName), typeof(XmlSchemaObject)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSchemaObjectTable), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName)}, ReturnType = typeof(XmlSchemaObject))]
	[Calls(Type = typeof(Preprocessor), Member = "GetBuildInSchema", ReturnType = typeof(XmlSchema))]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 3)]
	protected void AddToTable(XmlSchemaObjectTable table, XmlQualifiedName qname, XmlSchemaObject item) { }

	[CallerCount(Count = 15)]
	[DeduplicatedMethod]
	protected XmlSchemaCompilationSettings get_CompilationSettings() { }

	[CallerCount(Count = 12)]
	[DeduplicatedMethod]
	protected ValidationEventHandler get_EventHandler() { }

	[CallerCount(Count = 10)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	protected bool get_HasErrors() { }

	[CallerCount(Count = 106)]
	[DeduplicatedMethod]
	protected XmlNameTable get_NameTable() { }

	[CalledBy(Type = typeof(Preprocessor), Member = "LoadExternals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchema)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SchemaCollectionPreprocessor), Member = "LoadExternals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchema), typeof(XmlSchemaCollection)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(SchemaNames), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNameTable)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	protected SchemaNames get_SchemaNames() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlSchemaAttributeGroup), Member = "get_AttributeUses", ReturnType = typeof(XmlSchemaObjectTable))]
	[Calls(Type = typeof(XmlSchemaObjectTable), Member = "get_Count", ReturnType = typeof(int))]
	[Calls(Type = typeof(XmlSchemaObjectTable), Member = "Insert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName), typeof(XmlSchemaObject)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private bool IsValidAttributeGroupRedefine(XmlSchemaObject existingObject, XmlSchemaObject item, XmlSchemaObjectTable table) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlSchemaObjectTable), Member = "Insert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName), typeof(XmlSchemaObject)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private bool IsValidGroupRedefine(XmlSchemaObject existingObject, XmlSchemaObject item, XmlSchemaObjectTable table) { }

	[CalledBy(Type = typeof(BaseProcessor), Member = "AddToTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaObjectTable), typeof(XmlQualifiedName), typeof(XmlSchemaObject)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(XmlSchemaType), Member = "get_ElementDecl", ReturnType = typeof(SchemaElementDecl))]
	[Calls(Type = typeof(XmlSchemaType), Member = "get_QualifiedName", ReturnType = typeof(XmlQualifiedName))]
	[Calls(Type = typeof(XmlSchemaObjectTable), Member = "Insert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName), typeof(XmlSchemaObject)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private bool IsValidTypeRedefine(XmlSchemaObject existingObject, XmlSchemaObject item, XmlSchemaObjectTable table) { }

	[CallerCount(Count = 196)]
	[Calls(Type = typeof(XmlSchemaException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(XmlSchemaObject)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ValidationEventArgs), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaException), typeof(XmlSeverityType)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	protected void SendValidationEvent(string code, XmlSchemaObject source) { }

	[CallerCount(Count = 100)]
	[Calls(Type = typeof(XmlSchemaException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(XmlSchemaObject)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ValidationEventArgs), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaException), typeof(XmlSeverityType)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	protected void SendValidationEvent(string code, string msg, XmlSchemaObject source) { }

	[CalledBy(Type = typeof(Preprocessor), Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchema), typeof(string), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Compiler), Member = "CompileComplexContent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaComplexType)}, ReturnType = typeof(ContentValidator))]
	[CalledBy(Type = typeof(Compiler), Member = "CheckAtrributeGroupRestriction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaAttributeGroup), typeof(XmlSchemaAttributeGroup)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Compiler), Member = "ProcessSubstitutionGroups", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SchemaCollectionPreprocessor), Member = "ValidateQNameAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaObject), typeof(string), typeof(XmlQualifiedName)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SchemaCollectionPreprocessor), Member = "PreprocessComplexType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaComplexType), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SchemaCollectionPreprocessor), Member = "Preprocess", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchema), typeof(string), "System.Xml.Schema.SchemaCollectionPreprocessor+Compositor"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SchemaCollectionPreprocessor), Member = "ValidateNameAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaObject)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SchemaCollectionCompiler), Member = "CheckSubstitutionGroup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaSubstitutionGroup)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Preprocessor), Member = "ValidateNameAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaObject)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Preprocessor), Member = "PreprocessComplexType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaComplexType), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Preprocessor), Member = "PreprocessRedefine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RedefineEntry)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Preprocessor), Member = "Preprocess", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchema), typeof(string), typeof(ArrayList)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SchemaCollectionCompiler), Member = "CompileComplexContent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaComplexType)}, ReturnType = typeof(ContentValidator))]
	[CallerCount(Count = 21)]
	[Calls(Type = typeof(XmlSchemaException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[]), typeof(XmlSchemaObject)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ValidationEventArgs), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaException), typeof(XmlSeverityType)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	protected void SendValidationEvent(string code, string msg1, string msg2, XmlSchemaObject source) { }

	[CalledBy(Type = typeof(Preprocessor), Member = "ParseUri", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(XmlSchemaObject)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Preprocessor), Member = "Preprocess", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchema), typeof(string), typeof(ArrayList)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Preprocessor), Member = "PreprocessNotation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaNotation)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Preprocessor), Member = "PreprocessParticle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaParticle)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Preprocessor), Member = "PreprocessAttributes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaObjectCollection), typeof(XmlSchemaAnyAttribute), typeof(XmlSchemaObject)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Preprocessor), Member = "ValidateIdAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaObject)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Preprocessor), Member = "ValidateQNameAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaObject), typeof(string), typeof(XmlQualifiedName)}, ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(XmlSchemaException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[]), typeof(Exception), typeof(string), typeof(int), typeof(int), typeof(XmlSchemaObject)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ValidationEventArgs), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaException), typeof(XmlSeverityType)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	protected void SendValidationEvent(string code, String[] args, Exception innerException, XmlSchemaObject source) { }

	[CalledBy(Type = typeof(Preprocessor), Member = "LoadExternals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchema)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ValidationEventArgs), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaException), typeof(XmlSeverityType)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 6)]
	protected void SendValidationEvent(string code, string msg1, string msg2, string sourceUri, int lineNumber, int linePosition) { }

	[CalledBy(Type = typeof(Preprocessor), Member = "LoadExternals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchema)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Preprocessor), Member = "PreprocessRedefine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RedefineEntry)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SchemaCollectionCompiler), Member = "CompileContentTypeParticle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaParticle), typeof(bool)}, ReturnType = typeof(XmlSchemaParticle))]
	[CalledBy(Type = typeof(SchemaCollectionCompiler), Member = "CannonicalizeGroupRef", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaGroupRef), typeof(bool), typeof(bool)}, ReturnType = typeof(XmlSchemaParticle))]
	[CalledBy(Type = typeof(SchemaCollectionCompiler), Member = "CannonicalizeChoice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaChoice), typeof(bool), typeof(bool)}, ReturnType = typeof(XmlSchemaParticle))]
	[CalledBy(Type = typeof(SchemaCollectionCompiler), Member = "CompileComplexContent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaComplexType)}, ReturnType = typeof(ContentValidator))]
	[CalledBy(Type = typeof(SchemaCollectionPreprocessor), Member = "LoadExternals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchema), typeof(XmlSchemaCollection)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Compiler), Member = "CompileContentTypeParticle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaParticle)}, ReturnType = typeof(XmlSchemaParticle))]
	[CalledBy(Type = typeof(Compiler), Member = "CannonicalizeGroupRef", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaGroupRef), typeof(bool)}, ReturnType = typeof(XmlSchemaParticle))]
	[CalledBy(Type = typeof(Compiler), Member = "CannonicalizeChoice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaChoice), typeof(bool)}, ReturnType = typeof(XmlSchemaParticle))]
	[CalledBy(Type = typeof(Compiler), Member = "CompileComplexContent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaComplexType)}, ReturnType = typeof(ContentValidator))]
	[CallerCount(Count = 12)]
	[Calls(Type = typeof(XmlSchemaException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(XmlSchemaObject)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseProcessor), Member = "SendValidationEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaException), typeof(XmlSeverityType)}, ReturnType = typeof(void))]
	protected void SendValidationEvent(string code, XmlSchemaObject source, XmlSeverityType severity) { }

	[CalledBy(Type = typeof(SchemaCollectionCompiler), Member = "CompileSimpleType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaSimpleType)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SchemaCollectionCompiler), Member = "CompileSimpleContentRestriction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaComplexType), typeof(XmlSchemaSimpleContentRestriction)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SchemaCollectionCompiler), Member = "CompileAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaAttribute)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SchemaCollectionCompiler), Member = "CompileIdentityConstraint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaIdentityConstraint)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SchemaCollectionCompiler), Member = "CompileElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaElement)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Compiler), Member = "CompileSimpleType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaSimpleType)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Compiler), Member = "CompileSimpleContentRestriction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaComplexType), typeof(XmlSchemaSimpleContentRestriction)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Compiler), Member = "CompileAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaAttribute)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Compiler), Member = "CompileIdentityConstraint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaIdentityConstraint)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Compiler), Member = "CompileElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaElement)}, ReturnType = typeof(void))]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(ValidationEventArgs), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaException), typeof(XmlSeverityType)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	protected void SendValidationEvent(XmlSchemaException e) { }

	[CalledBy(Type = typeof(Preprocessor), Member = "ValidateQNameAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaObject), typeof(string), typeof(XmlQualifiedName)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SchemaCollectionCompiler), Member = "CompileLocalAttributes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaComplexType), typeof(XmlSchemaComplexType), typeof(XmlSchemaObjectCollection), typeof(XmlSchemaAnyAttribute), typeof(XmlSchemaDerivationMethod)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SchemaCollectionPreprocessor), Member = "ValidateQNameAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaObject), typeof(string), typeof(XmlQualifiedName)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Compiler), Member = "CompileLocalAttributes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaComplexType), typeof(XmlSchemaComplexType), typeof(XmlSchemaObjectCollection), typeof(XmlSchemaAnyAttribute), typeof(XmlSchemaDerivationMethod)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(XmlSchemaException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(XmlSchemaObject)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseProcessor), Member = "SendValidationEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaException), typeof(XmlSeverityType)}, ReturnType = typeof(void))]
	protected void SendValidationEvent(string code, string msg, XmlSchemaObject source, XmlSeverityType severity) { }

	[CalledBy(Type = typeof(BaseProcessor), Member = "SendValidationEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(XmlSchemaObject), typeof(XmlSeverityType)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BaseProcessor), Member = "SendValidationEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(XmlSchemaObject), typeof(XmlSeverityType)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Preprocessor), Member = "LoadExternals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchema)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(ValidationEventArgs), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaException), typeof(XmlSeverityType)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	protected void SendValidationEvent(XmlSchemaException e, XmlSeverityType severity) { }

	[CalledBy(Type = typeof(SchemaCollectionPreprocessor), Member = "LoadExternals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchema), typeof(XmlSchemaCollection)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ValidationEventArgs), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaException), typeof(XmlSeverityType)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	protected void SendValidationEventNoThrow(XmlSchemaException e, XmlSeverityType severity) { }

}

