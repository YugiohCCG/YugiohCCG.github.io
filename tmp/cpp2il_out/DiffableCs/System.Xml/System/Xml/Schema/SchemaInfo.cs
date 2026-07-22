namespace System.Xml.Schema;

internal class SchemaInfo : IDtdInfo
{
	private Dictionary<XmlQualifiedName, SchemaElementDecl> elementDecls; //Field offset: 0x10
	private Dictionary<XmlQualifiedName, SchemaElementDecl> undeclaredElementDecls; //Field offset: 0x18
	private Dictionary<XmlQualifiedName, SchemaEntity> generalEntities; //Field offset: 0x20
	private Dictionary<XmlQualifiedName, SchemaEntity> parameterEntities; //Field offset: 0x28
	private XmlQualifiedName docTypeName; //Field offset: 0x30
	private string internalDtdSubset; //Field offset: 0x38
	private bool hasNonCDataAttributes; //Field offset: 0x40
	private bool hasDefaultAttributes; //Field offset: 0x41
	private Dictionary<String, Boolean> targetNamespaces; //Field offset: 0x48
	private Dictionary<XmlQualifiedName, SchemaAttDef> attributeDecls; //Field offset: 0x50
	private int errorCount; //Field offset: 0x58
	private SchemaType schemaType; //Field offset: 0x5C
	private Dictionary<XmlQualifiedName, SchemaElementDecl> elementDeclsByType; //Field offset: 0x60
	private Dictionary<String, SchemaNotation> notations; //Field offset: 0x68

	internal Dictionary<XmlQualifiedName, SchemaAttDef> AttributeDecls
	{
		[CallerCount(Count = 16)]
		[DeduplicatedMethod]
		internal get { } //Length: 5
	}

	public XmlQualifiedName DocTypeName
	{
		[CallerCount(Count = 62)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 set { } //Length: 13
	}

	internal Dictionary<XmlQualifiedName, SchemaElementDecl> ElementDecls
	{
		[CallerCount(Count = 106)]
		[DeduplicatedMethod]
		internal get { } //Length: 5
	}

	internal Dictionary<XmlQualifiedName, SchemaElementDecl> ElementDeclsByType
	{
		[CallerCount(Count = 84)]
		[DeduplicatedMethod]
		internal get { } //Length: 5
	}

	internal int ErrorCount
	{
		[CallerCount(Count = 3)]
		[DeduplicatedMethod]
		internal get { } //Length: 4
		[CallerCount(Count = 5)]
		[DeduplicatedMethod]
		internal set { } //Length: 4
	}

	internal Dictionary<XmlQualifiedName, SchemaEntity> GeneralEntities
	{
		[CalledBy(Type = typeof(XmlLoader), Member = "LoadDocumentType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IDtdInfo), typeof(XmlDocumentType)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DtdParser), Member = "ParseEntityDecl", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DtdParser), Member = "ScanLiteral", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Xml.DtdParser+LiteralType"}, ReturnType = "System.Xml.DtdParser+Token")]
		[CalledBy(Type = typeof(DtdParser), Member = "VerifyEntityReference", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(SchemaEntity))]
		[CalledBy(Type = typeof(BaseValidator), Member = "ProcessEntity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SchemaInfo), typeof(string), typeof(object), typeof(ValidationEventHandler), typeof(string), typeof(int), typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(BaseValidator), Member = "ProcessEntity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SchemaInfo), typeof(string), typeof(IValidationEventHandling), typeof(string), typeof(int), typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DtdValidator), Member = "GenEntity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(DtdValidator), Member = "GetEntity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName), typeof(bool)}, ReturnType = typeof(SchemaEntity))]
		[CallerCount(Count = 10)]
		[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		internal get { } //Length: 122
	}

	internal string InternalDtdSubset
	{
		[CallerCount(Count = 3)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		internal set { } //Length: 13
	}

	internal Dictionary<String, SchemaNotation> Notations
	{
		[CalledBy(Type = typeof(XmlLoader), Member = "LoadDocumentType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IDtdInfo), typeof(XmlDocumentType)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DtdParser), Member = "ParseAttlistType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SchemaAttDef), typeof(SchemaElementDecl), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DtdParser), Member = "ParseEntityDecl", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DtdParser), Member = "ParseNotationDecl", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(SchemaCollectionCompiler), Member = "Output", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SchemaInfo)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(SchemaInfo), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SchemaInfo), typeof(ValidationEventHandler)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Compiler), Member = "Output", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SchemaInfo)}, ReturnType = typeof(void))]
		[CallerCount(Count = 10)]
		[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		internal get { } //Length: 122
	}

	internal Dictionary<XmlQualifiedName, SchemaEntity> ParameterEntities
	{
		[CalledBy(Type = typeof(XmlLoader), Member = "LoadDocumentType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IDtdInfo), typeof(XmlDocumentType)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DtdParser), Member = "ParseEntityDecl", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DtdParser), Member = "VerifyEntityReference", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(SchemaEntity))]
		[CalledBy(Type = typeof(DtdValidator), Member = "GetEntity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName), typeof(bool)}, ReturnType = typeof(SchemaEntity))]
		[CallerCount(Count = 6)]
		[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		internal get { } //Length: 122
	}

	internal SchemaType SchemaType
	{
		[CallerCount(Count = 26)]
		[DeduplicatedMethod]
		internal get { } //Length: 4
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		internal set { } //Length: 4
	}

	private override bool System.Xml.IDtdInfo.HasDefaultAttributes
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		private get { } //Length: 5
	}

	private override bool System.Xml.IDtdInfo.HasNonCDataAttributes
	{
		[CallerCount(Count = 10)]
		[DeduplicatedMethod]
		private get { } //Length: 5
	}

	private override string System.Xml.IDtdInfo.InternalDtdSubset
	{
		[CallerCount(Count = 38)]
		[DeduplicatedMethod]
		private get { } //Length: 5
	}

	private override XmlQualifiedName System.Xml.IDtdInfo.Name
	{
		[CallerCount(Count = 62)]
		[DeduplicatedMethod]
		private get { } //Length: 5
	}

	internal Dictionary<String, Boolean> TargetNamespaces
	{
		[CallerCount(Count = 10)]
		[DeduplicatedMethod]
		internal get { } //Length: 254
	}

	internal Dictionary<XmlQualifiedName, SchemaElementDecl> UndeclaredElementDecls
	{
		[CallerCount(Count = 31)]
		[DeduplicatedMethod]
		internal get { } //Length: 5
	}

	[CalledBy(Type = typeof(DtdParser), Member = "Initialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IDtdParserAdapter)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XsdValidator), Member = "LoadSchemaFromLocation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XsdValidator), Member = "ProcessInlineSchema", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XsdValidator), Member = "Init", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSchemaSet), Member = "CopyFromCompiledSet", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaSet)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSchemaSet), Member = "Compile", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XdrValidator), Member = "Init", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSchemaSet), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNameTable)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Parser), Member = "StartParsing", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlReader), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DtdValidator), Member = "Init", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DtdValidator), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlValidatingReaderImpl), typeof(IValidationEventHandling), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BaseValidator), Member = "CreateInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ValidationType), typeof(XmlValidatingReaderImpl), typeof(XmlSchemaCollection), typeof(IValidationEventHandling), typeof(bool)}, ReturnType = typeof(BaseValidator))]
	[CalledBy(Type = typeof(AutoValidator), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlValidatingReaderImpl), typeof(XmlSchemaCollection), typeof(IValidationEventHandling)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XdrBuilder), Member = "LoadSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 15)]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	internal SchemaInfo() { }

	[CalledBy(Type = typeof(XdrBuilder), Member = "LoadSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XdrValidator), Member = "ProcessInlineSchema", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XdrValidator), Member = "LoadSchemaFromLocation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XdrValidator), Member = "LoadSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSchemaSet), Member = "Compile", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSchemaSet), Member = "CopyFromCompiledSet", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaSet)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XsdValidator), Member = "ProcessInlineSchema", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XsdValidator), Member = "LoadSchemaFromLocation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XsdValidator), Member = "LoadSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(SchemaInfo), Member = "get_Notations", ReturnType = typeof(System.Collections.Generic.Dictionary`2<System.String, System.Xml.Schema.SchemaNotation>))]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2+Enumerator<System.Object, System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(ValidationEventArgs), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaException)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Boolean>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Dictionary`2), Member = "ContainsKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlSchemaException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Dictionary`2), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.Dictionary`2<TKey, TValue>+Enumerator<TKey, TValue>")]
	[CallsDeduplicatedMethods(Count = 17)]
	[CallsUnknownMethods(Count = 22)]
	internal void Add(SchemaInfo sinfo, ValidationEventHandler eventhandler) { }

	[CalledBy(Type = typeof(XmlSchemaValidator), Member = "ValidateAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(XmlValueGetter), typeof(string), typeof(XmlSchemaInfo)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(XmlSchemaValidator), Member = "get_HasSchema", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XmlSchemaValidator), Member = "CheckXsiTypeAndNil", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SchemaElementDecl), typeof(string), typeof(string), typeof(Boolean&)}, ReturnType = typeof(SchemaElementDecl))]
	[CalledBy(Type = typeof(XmlSchemaValidator), Member = "ThrowDeclNotFoundWarningOrError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSchemaValidator), Member = "CheckIsXmlAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName)}, ReturnType = typeof(SchemaAttDef))]
	[CalledBy(Type = typeof(XsdValidator), Member = "ValidateStartElement", ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(Dictionary`2), Member = "ContainsKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	internal bool Contains(string ns) { }

	[CalledBy(Type = typeof(DtdParser), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 3)]
	internal void Finish() { }

	[CallerCount(Count = 16)]
	[DeduplicatedMethod]
	internal Dictionary<XmlQualifiedName, SchemaAttDef> get_AttributeDecls() { }

	[CallerCount(Count = 62)]
	[DeduplicatedMethod]
	public XmlQualifiedName get_DocTypeName() { }

	[CallerCount(Count = 106)]
	[DeduplicatedMethod]
	internal Dictionary<XmlQualifiedName, SchemaElementDecl> get_ElementDecls() { }

	[CallerCount(Count = 84)]
	[DeduplicatedMethod]
	internal Dictionary<XmlQualifiedName, SchemaElementDecl> get_ElementDeclsByType() { }

	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	internal int get_ErrorCount() { }

	[CalledBy(Type = typeof(XmlLoader), Member = "LoadDocumentType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IDtdInfo), typeof(XmlDocumentType)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DtdParser), Member = "ParseEntityDecl", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DtdParser), Member = "ScanLiteral", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Xml.DtdParser+LiteralType"}, ReturnType = "System.Xml.DtdParser+Token")]
	[CalledBy(Type = typeof(DtdParser), Member = "VerifyEntityReference", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(SchemaEntity))]
	[CalledBy(Type = typeof(BaseValidator), Member = "ProcessEntity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SchemaInfo), typeof(string), typeof(object), typeof(ValidationEventHandler), typeof(string), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BaseValidator), Member = "ProcessEntity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SchemaInfo), typeof(string), typeof(IValidationEventHandling), typeof(string), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DtdValidator), Member = "GenEntity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DtdValidator), Member = "GetEntity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName), typeof(bool)}, ReturnType = typeof(SchemaEntity))]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	internal Dictionary<XmlQualifiedName, SchemaEntity> get_GeneralEntities() { }

	[CalledBy(Type = typeof(XmlLoader), Member = "LoadDocumentType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IDtdInfo), typeof(XmlDocumentType)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DtdParser), Member = "ParseAttlistType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SchemaAttDef), typeof(SchemaElementDecl), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DtdParser), Member = "ParseEntityDecl", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DtdParser), Member = "ParseNotationDecl", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SchemaCollectionCompiler), Member = "Output", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SchemaInfo)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SchemaInfo), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SchemaInfo), typeof(ValidationEventHandler)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Compiler), Member = "Output", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SchemaInfo)}, ReturnType = typeof(void))]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	internal Dictionary<String, SchemaNotation> get_Notations() { }

	[CalledBy(Type = typeof(XmlLoader), Member = "LoadDocumentType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IDtdInfo), typeof(XmlDocumentType)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DtdParser), Member = "ParseEntityDecl", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DtdParser), Member = "VerifyEntityReference", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(SchemaEntity))]
	[CalledBy(Type = typeof(DtdValidator), Member = "GetEntity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName), typeof(bool)}, ReturnType = typeof(SchemaEntity))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	internal Dictionary<XmlQualifiedName, SchemaEntity> get_ParameterEntities() { }

	[CallerCount(Count = 26)]
	[DeduplicatedMethod]
	internal SchemaType get_SchemaType() { }

	[CallerCount(Count = 10)]
	[DeduplicatedMethod]
	internal Dictionary<String, Boolean> get_TargetNamespaces() { }

	[CallerCount(Count = 31)]
	[DeduplicatedMethod]
	internal Dictionary<XmlQualifiedName, SchemaElementDecl> get_UndeclaredElementDecls() { }

	[CalledBy(Type = typeof(XdrValidator), Member = "ValidateStartElement", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SchemaElementDecl), Member = "GetAttDef", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName)}, ReturnType = typeof(SchemaAttDef))]
	[Calls(Type = typeof(ContentValidator), Member = "get_IsOpen", ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Dictionary`2), Member = "ContainsKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlSchemaException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 13)]
	internal SchemaAttDef GetAttributeXdr(SchemaElementDecl ed, XmlQualifiedName qname) { }

	[CalledBy(Type = typeof(XsdValidator), Member = "ValidateStartElement", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SchemaInfo), Member = "GetAttributeXsd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SchemaElementDecl), typeof(XmlQualifiedName), typeof(XmlSchemaObject), typeof(AttributeMatchState&)}, ReturnType = typeof(SchemaAttDef))]
	[Calls(Type = typeof(XmlSchemaException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 13)]
	internal SchemaAttDef GetAttributeXsd(SchemaElementDecl ed, XmlQualifiedName qname, ref bool skip) { }

	[CalledBy(Type = typeof(SchemaInfo), Member = "GetAttributeXsd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SchemaElementDecl), typeof(XmlQualifiedName), typeof(Boolean&)}, ReturnType = typeof(SchemaAttDef))]
	[CalledBy(Type = typeof(XmlSchemaValidator), Member = "ValidateAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(XmlValueGetter), typeof(string), typeof(XmlSchemaInfo)}, ReturnType = typeof(object))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(SchemaElementDecl), Member = "GetAttDef", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName)}, ReturnType = typeof(SchemaAttDef))]
	[Calls(Type = typeof(Dictionary`2), Member = "ContainsKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(NamespaceList), Member = "Allows", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlSchemaAnyAttribute), Member = "get_ProcessContentsCorrect", ReturnType = typeof(XmlSchemaContentProcessing))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	internal SchemaAttDef GetAttributeXsd(SchemaElementDecl ed, XmlQualifiedName qname, XmlSchemaObject partialValidationType, out AttributeMatchState attributeMatchState) { }

	[CalledBy(Type = typeof(XmlSchemaValidator), Member = "ValidateElementContext", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName), typeof(Boolean&)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(XmlSchemaValidator), Member = "GetSubstitutionGroupHead", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName)}, ReturnType = typeof(XmlSchemaElement))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object&)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	internal XmlSchemaElement GetElement(XmlQualifiedName qname) { }

	[CalledBy(Type = typeof(DtdValidator), Member = "ValidateElement", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DtdValidator), Member = "ProcessElement", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XdrValidator), Member = "ThoroughGetElementDecl", ReturnType = typeof(SchemaElementDecl))]
	[CalledBy(Type = typeof(XmlSchemaValidator), Member = "ValidateElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(XmlSchemaInfo), typeof(string), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSchemaValidator), Member = "FastGetElementDecl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName), typeof(object)}, ReturnType = typeof(SchemaElementDecl))]
	[CalledBy(Type = typeof(XsdValidator), Member = "ProcessElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XsdValidator), Member = "ThoroughGetElementDecl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SchemaElementDecl), typeof(XmlQualifiedName), typeof(string)}, ReturnType = typeof(SchemaElementDecl))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object&)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	internal SchemaElementDecl GetElementDecl(XmlQualifiedName qname) { }

	[CalledBy(Type = typeof(XmlSchemaValidator), Member = "CheckXsiTypeAndNil", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SchemaElementDecl), typeof(string), typeof(string), typeof(Boolean&)}, ReturnType = typeof(SchemaElementDecl))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object&)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	internal SchemaElementDecl GetTypeDecl(XmlQualifiedName qname) { }

	[CalledBy(Type = typeof(XdrValidator), Member = "ProcessInlineSchema", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Dictionary`2), Member = "ContainsKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	internal bool HasSchema(string ns) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public void set_DocTypeName(XmlQualifiedName value) { }

	[CallerCount(Count = 5)]
	[DeduplicatedMethod]
	internal void set_ErrorCount(int value) { }

	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	internal void set_InternalDtdSubset(string value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	internal void set_SchemaType(SchemaType value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	private override bool System.Xml.IDtdInfo.get_HasDefaultAttributes() { }

	[CallerCount(Count = 10)]
	[DeduplicatedMethod]
	private override bool System.Xml.IDtdInfo.get_HasNonCDataAttributes() { }

	[CallerCount(Count = 38)]
	[DeduplicatedMethod]
	private override string System.Xml.IDtdInfo.get_InternalDtdSubset() { }

	[CallerCount(Count = 62)]
	[DeduplicatedMethod]
	private override XmlQualifiedName System.Xml.IDtdInfo.get_Name() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlQualifiedName), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object&)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	private override IDtdAttributeListInfo System.Xml.IDtdInfo.LookupAttributeList(string prefix, string localName) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlQualifiedName), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object&)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	private override IDtdEntityInfo System.Xml.IDtdInfo.LookupEntity(string name) { }

}

