namespace System.Xml.Schema;

internal sealed class XdrValidator : BaseValidator
{
	private HWStack validationStack; //Field offset: 0x80
	private Hashtable attPresence; //Field offset: 0x88
	private XmlQualifiedName name; //Field offset: 0x90
	private XmlNamespaceManager nsManager; //Field offset: 0x98
	private bool isProcessContents; //Field offset: 0xA0
	private Hashtable IDs; //Field offset: 0xA8
	private IdRefNode idRefListHead; //Field offset: 0xB0
	private Parser inlineSchemaParser; //Field offset: 0xB8

	private bool HasSchema
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		private get { } //Length: 30
	}

	private bool IsInlineSchemaStarted
	{
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		private get { } //Length: 12
	}

	public virtual bool PreserveWhitespace
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ContentValidator), Member = "get_PreserveWhitespace", ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 59
	}

	[CalledBy(Type = typeof(AutoValidator), Member = "Validate", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BaseValidator), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseValidator)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XdrValidator), Member = "Init", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	internal XdrValidator(BaseValidator validator) { }

	[CalledBy(Type = typeof(BaseValidator), Member = "CreateInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ValidationType), typeof(XmlValidatingReaderImpl), typeof(XmlSchemaCollection), typeof(IValidationEventHandling), typeof(bool)}, ReturnType = typeof(BaseValidator))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BaseValidator), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlValidatingReaderImpl), typeof(XmlSchemaCollection), typeof(IValidationEventHandling)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XdrValidator), Member = "Init", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	internal XdrValidator(XmlValidatingReaderImpl reader, XmlSchemaCollection schemaCollection, IValidationEventHandling eventHandling) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Hashtable), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	internal void AddID(string name, object node) { }

	[CalledBy(Type = typeof(XdrBuilder), Member = "CheckDefaultAttValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SchemaAttDef)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "Trim", ReturnType = typeof(string))]
	[Calls(Type = typeof(SchemaDeclBase), Member = "CheckEnumeration", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlSchemaException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ValidationEventArgs), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaException)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseValidator), Member = "ProcessEntity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SchemaInfo), typeof(string), typeof(object), typeof(ValidationEventHandler), typeof(string), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 18)]
	public static void CheckDefaultValue(string value, SchemaAttDef attdef, SchemaInfo sinfo, XmlNamespaceManager nsManager, XmlNameTable NameTable, object sender, ValidationEventHandler eventhandler, string baseUri, int lineNo, int linePos) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlSchemaException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseValidator), Member = "SendValidationEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaException)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private void CheckForwardRefs() { }

	[CalledBy(Type = typeof(XdrValidator), Member = "ValidateEndElement", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XdrValidator), Member = "ValidateStartElement", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(XmlValidatingReaderImpl), Member = "set_TypedValueObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Trim", ReturnType = typeof(string))]
	[Calls(Type = typeof(XdrValidator), Member = "ProcessTokenizedType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlTokenizedType), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseValidator), Member = "SendValidationEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SchemaDeclBase), Member = "CheckEnumeration", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(SchemaDeclBase), Member = "CheckValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlSchemaValidator), Member = "QNameString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 11)]
	[CallsUnknownMethods(Count = 20)]
	private void CheckValue(string value, SchemaAttDef attdef) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlSchemaException), Member = "CreateMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(SystemException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Exception)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseValidator), Member = "SendValidationEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaException), typeof(XmlSeverityType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSchemaException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseValidator), Member = "SendValidationEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaException)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 9)]
	public virtual void CompleteValidation() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public virtual object FindId(string name) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	private bool get_HasSchema() { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	private bool get_IsInlineSchemaStarted() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ContentValidator), Member = "get_PreserveWhitespace", ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public virtual bool get_PreserveWhitespace() { }

	[CalledBy(Type = typeof(XdrValidator), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseValidator)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XdrValidator), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlValidatingReaderImpl), typeof(XmlSchemaCollection), typeof(IValidationEventHandling)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(XmlNamespaceManager), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNameTable)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(HWStack), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(Hashtable), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(XdrValidator), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SchemaInfo), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 8)]
	private void Init() { }

	[CalledBy(Type = typeof(XdrValidator), Member = "ThoroughGetElementDecl", ReturnType = typeof(SchemaElementDecl))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Dictionary`2), Member = "ContainsKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BaseValidator), Member = "get_EventHandler", ReturnType = typeof(ValidationEventHandler))]
	[Calls(Type = typeof(SchemaInfo), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SchemaInfo), typeof(ValidationEventHandler)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XdrValidator), Member = "LoadSchemaFromLocation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 10)]
	private void LoadSchema(string uri) { }

	[CalledBy(Type = typeof(XdrValidator), Member = "LoadSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "Compare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(string), typeof(int), typeof(int), typeof(StringComparison)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(string), Member = "StartsWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(StringComparison)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(XmlTextReader), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Stream), typeof(XmlNameTable)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextReader), Member = "set_XmlResolver", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlResolver)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseValidator), Member = "get_SchemaNames", ReturnType = typeof(SchemaNames))]
	[Calls(Type = typeof(BaseValidator), Member = "get_EventHandler", ReturnType = typeof(ValidationEventHandler))]
	[Calls(Type = typeof(Parser), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SchemaType), typeof(XmlNameTable), typeof(SchemaNames), typeof(ValidationEventHandler)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Parser), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlReader), typeof(string)}, ReturnType = typeof(SchemaType))]
	[Calls(Type = typeof(BaseValidator), Member = "SendValidationEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[]), typeof(XmlSeverityType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SchemaInfo), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SchemaInfo), typeof(ValidationEventHandler)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSchemaCollection), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(SchemaInfo), typeof(XmlSchema), typeof(bool)}, ReturnType = typeof(XmlSchema))]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallsUnknownMethods(Count = 27)]
	private void LoadSchemaFromLocation(string uri) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(HWStack), Member = "Pop", ReturnType = typeof(object))]
	[Calls(Type = typeof(HWStack), Member = "Peek", ReturnType = typeof(object))]
	[CallsUnknownMethods(Count = 5)]
	private void Pop() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XdrValidator), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XdrValidator), Member = "ThoroughGetElementDecl", ReturnType = typeof(SchemaElementDecl))]
	[Calls(Type = typeof(XdrValidator), Member = "ValidateStartElement", ReturnType = typeof(void))]
	[Calls(Type = typeof(XdrValidator), Member = "ValidateEndStartElement", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	private void ProcessElement() { }

	[CalledBy(Type = typeof(XdrValidator), Member = "Validate", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Parser), Member = "ParseReaderNode", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(SchemaInfo), Member = "HasSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BaseValidator), Member = "get_EventHandler", ReturnType = typeof(ValidationEventHandler))]
	[Calls(Type = typeof(SchemaInfo), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SchemaInfo), typeof(ValidationEventHandler)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSchemaCollection), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(SchemaInfo), typeof(XmlSchema), typeof(bool)}, ReturnType = typeof(XmlSchema))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 6)]
	private void ProcessInlineSchema() { }

	[CalledBy(Type = typeof(XdrValidator), Member = "CheckValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(SchemaAttDef)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(BaseValidator), Member = "get_EventHandler", ReturnType = typeof(ValidationEventHandler))]
	[Calls(Type = typeof(BaseValidator), Member = "ProcessEntity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SchemaInfo), typeof(string), typeof(object), typeof(ValidationEventHandler), typeof(string), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(IdRefNode), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IdRefNode), typeof(string), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Hashtable), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseValidator), Member = "SendValidationEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 3)]
	private void ProcessTokenizedType(XmlTokenizedType ttype, string name) { }

	[CalledBy(Type = typeof(XdrValidator), Member = "Init", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XdrValidator), Member = "ValidateElement", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XdrValidator), Member = "ProcessElement", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(HWStack), Member = "Push", ReturnType = typeof(object))]
	[Calls(Type = typeof(HWStack), Member = "AddToTop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 8)]
	private void Push(XmlQualifiedName elementName) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseValidator), Member = "get_SchemaNames", ReturnType = typeof(SchemaNames))]
	[Calls(Type = typeof(XmlSchemaDatatype), Member = "XdrCanonizeUri", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(XmlNameTable), typeof(SchemaNames)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(XmlQualifiedName), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	private XmlQualifiedName QualifiedName(string name, string ns) { }

	[CalledBy(Type = typeof(XdrValidator), Member = "ValidateElement", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XdrValidator), Member = "ProcessElement", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(XdrValidator), Member = "LoadSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseValidator), Member = "get_SchemaNames", ReturnType = typeof(SchemaNames))]
	[Calls(Type = typeof(DatatypeImplementation), Member = "FromXdrName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(DatatypeImplementation))]
	[Calls(Type = typeof(XmlValidatingReaderImpl), Member = "set_SchemaTypeObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SchemaInfo), Member = "GetElementDecl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName)}, ReturnType = typeof(SchemaElementDecl))]
	[Calls(Type = typeof(Dictionary`2), Member = "ContainsKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlSchemaValidator), Member = "QNameString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(BaseValidator), Member = "SendValidationEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 15)]
	[CallsUnknownMethods(Count = 1)]
	private SchemaElementDecl ThoroughGetElementDecl() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XdrValidator), Member = "ValidateElement", ReturnType = typeof(void))]
	[Calls(Type = typeof(XdrValidator), Member = "ValidateEndElement", ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseValidator), Member = "ValidateWhitespace", ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseValidator), Member = "ValidateText", ReturnType = typeof(void))]
	[Calls(Type = typeof(XdrValidator), Member = "ProcessInlineSchema", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public virtual void Validate() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseValidator), Member = "get_EventHandler", ReturnType = typeof(ValidationEventHandler))]
	[Calls(Type = typeof(XmlSchemaValidator), Member = "ElementValidationError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName), typeof(ValidationState), typeof(ValidationEventHandler), typeof(object), typeof(string), typeof(int), typeof(int), typeof(XmlSchemaSet)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	private void ValidateChildElement() { }

	[CalledBy(Type = typeof(XdrValidator), Member = "Validate", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(XdrValidator), Member = "ValidateEndStartElement", ReturnType = typeof(void))]
	[Calls(Type = typeof(XdrValidator), Member = "ValidateStartElement", ReturnType = typeof(void))]
	[Calls(Type = typeof(XdrValidator), Member = "ThoroughGetElementDecl", ReturnType = typeof(SchemaElementDecl))]
	[Calls(Type = typeof(XdrValidator), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Parser), Member = "ParseReaderNode", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Parser), Member = "StartParsing", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlReader), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Parser), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SchemaType), typeof(XmlNameTable), typeof(SchemaNames), typeof(ValidationEventHandler)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SchemaNames), Member = "IsXDRRoot", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlSchemaValidator), Member = "ElementValidationError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName), typeof(ValidationState), typeof(ValidationEventHandler), typeof(object), typeof(string), typeof(int), typeof(int), typeof(XmlSchemaSet)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseValidator), Member = "get_EventHandler", ReturnType = typeof(ValidationEventHandler))]
	[Calls(Type = typeof(XmlQualifiedName), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSchemaDatatype), Member = "XdrCanonizeUri", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(XmlNameTable), typeof(SchemaNames)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(BaseValidator), Member = "get_SchemaNames", ReturnType = typeof(SchemaNames))]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallsUnknownMethods(Count = 4)]
	private void ValidateElement() { }

	[CalledBy(Type = typeof(XdrValidator), Member = "Validate", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(BaseValidator), Member = "get_EventHandler", ReturnType = typeof(ValidationEventHandler))]
	[Calls(Type = typeof(XmlSchemaValidator), Member = "CompleteValidationError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ValidationState), typeof(ValidationEventHandler), typeof(object), typeof(string), typeof(int), typeof(int), typeof(XmlSchemaSet)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XdrValidator), Member = "CheckValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(SchemaAttDef)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StringBuilder), Member = "set_Length", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(HWStack), Member = "Pop", ReturnType = typeof(object))]
	[Calls(Type = typeof(HWStack), Member = "Peek", ReturnType = typeof(object))]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 5)]
	private void ValidateEndElement() { }

	[CalledBy(Type = typeof(XdrValidator), Member = "ValidateElement", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XdrValidator), Member = "ProcessElement", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(SchemaElementDecl), Member = "get_HasDefaultAttribute", ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlValidatingReaderImpl), Member = "AddDefaultAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SchemaAttDef)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlValidatingReaderImpl), Member = "get_StandAlone", ReturnType = typeof(bool))]
	[Calls(Type = typeof(SchemaElementDecl), Member = "CheckAttributes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Hashtable), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSchemaException), Member = "SetSource", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseValidator), Member = "SendValidationEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaException)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StringBuilder), Member = "set_Length", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 8)]
	private void ValidateEndStartElement() { }

	[CalledBy(Type = typeof(XdrValidator), Member = "ValidateElement", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XdrValidator), Member = "ProcessElement", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(XmlValidatingReaderImpl), Member = "set_SchemaTypeObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlValidatingReaderImpl), Member = "set_TypedValueObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseValidator), Member = "get_SchemaNames", ReturnType = typeof(SchemaNames))]
	[Calls(Type = typeof(XmlSchemaDatatype), Member = "XdrCanonizeUri", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(XmlNameTable), typeof(SchemaNames)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(XmlQualifiedName), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SchemaInfo), Member = "GetAttributeXdr", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SchemaElementDecl), typeof(XmlQualifiedName)}, ReturnType = typeof(SchemaAttDef))]
	[Calls(Type = typeof(XdrValidator), Member = "CheckValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(SchemaAttDef)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSchemaException), Member = "SetSource", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseValidator), Member = "SendValidationEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaException)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 13)]
	[CallsUnknownMethods(Count = 10)]
	private void ValidateStartElement() { }

}

