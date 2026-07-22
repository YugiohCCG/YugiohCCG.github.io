namespace System.Xml.Schema;

internal sealed class XsdValidator : BaseValidator
{
	private static readonly XmlSchemaDatatype dtCDATA; //Field offset: 0x0
	private static readonly XmlSchemaDatatype dtQName; //Field offset: 0x8
	private static readonly XmlSchemaDatatype dtStringArray; //Field offset: 0x10
	private int startIDConstraint; //Field offset: 0x80
	private HWStack validationStack; //Field offset: 0x88
	private Hashtable attPresence; //Field offset: 0x90
	private XmlNamespaceManager nsManager; //Field offset: 0x98
	private bool bManageNamespaces; //Field offset: 0xA0
	private Hashtable IDs; //Field offset: 0xA8
	private IdRefNode idRefListHead; //Field offset: 0xB0
	private Parser inlineSchemaParser; //Field offset: 0xB8
	private XmlSchemaContentProcessing processContents; //Field offset: 0xC0
	private string NsXmlNs; //Field offset: 0xC8
	private string NsXs; //Field offset: 0xD0
	private string NsXsi; //Field offset: 0xD8
	private string XsiType; //Field offset: 0xE0
	private string XsiNil; //Field offset: 0xE8
	private string XsiSchemaLocation; //Field offset: 0xF0
	private string XsiNoNamespaceSchemaLocation; //Field offset: 0xF8
	private string XsdSchema; //Field offset: 0x100

	private bool HasIdentityConstraints
	{
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		private get { } //Length: 11
	}

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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlSchemaDatatype), Member = "FromXmlTokenizedType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlTokenizedType)}, ReturnType = typeof(XmlSchemaDatatype))]
	[Calls(Type = typeof(XmlSchemaDatatype), Member = "FromXmlTokenizedTypeXsd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlTokenizedType)}, ReturnType = typeof(XmlSchemaDatatype))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	private static XsdValidator() { }

	[CalledBy(Type = typeof(AutoValidator), Member = "Validate", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BaseValidator), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseValidator)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XsdValidator), Member = "Init", ReturnType = typeof(void))]
	internal XsdValidator(BaseValidator validator) { }

	[CalledBy(Type = typeof(BaseValidator), Member = "CreateInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ValidationType), typeof(XmlValidatingReaderImpl), typeof(XmlSchemaCollection), typeof(IValidationEventHandling), typeof(bool)}, ReturnType = typeof(BaseValidator))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BaseValidator), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlValidatingReaderImpl), typeof(XmlSchemaCollection), typeof(IValidationEventHandling)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XsdValidator), Member = "Init", ReturnType = typeof(void))]
	internal XsdValidator(XmlValidatingReaderImpl reader, XmlSchemaCollection schemaCollection, IValidationEventHandling eventHandling) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Hashtable), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	internal void AddID(string name, object node) { }

	[CalledBy(Type = typeof(XsdValidator), Member = "ProcessElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XsdValidator), Member = "ValidateStartElementIdentityConstraints", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ConstraintStruct), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CompiledIdentityConstraint)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(HWStack), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(XmlQualifiedName), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName), typeof(XmlQualifiedName)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Hashtable), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSchemaValidator), Member = "QNameString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(BaseValidator), Member = "SendValidationEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 8)]
	private void AddIdentityConstraints() { }

	[CalledBy(Type = typeof(XsdValidator), Member = "ValidateStartElement", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XsdValidator), Member = "ValidateEndStartElement", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(HWStack), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(ActiveAxis), Member = "MoveToAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TypedObject), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string), typeof(XmlSchemaDatatype)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(KeySequence), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseValidator), Member = "SendValidationEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 5)]
	private void AttributeIdentityConstraints(string name, string ns, object obj, string sobj, SchemaAttDef attdef) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlSchemaException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseValidator), Member = "SendValidationEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaException)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	private void CheckForwardRefs() { }

	[CalledBy(Type = typeof(XsdValidator), Member = "ValidateEndElement", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XsdValidator), Member = "ValidateStartElement", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(XmlValidatingReaderImpl), Member = "set_TypedValueObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XsdValidator), Member = "ProcessTokenizedType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlTokenizedType), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SchemaDeclBase), Member = "CheckValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlSchemaValidator), Member = "QNameString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(BaseValidator), Member = "SendValidationEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 16)]
	private void CheckValue(string value, SchemaAttDef attdef) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlSchemaException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseValidator), Member = "SendValidationEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaException)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	public virtual void CompleteValidation() { }

	[CalledBy(Type = typeof(XsdValidator), Member = "ProcessElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XsdValidator), Member = "ValidateStartElementIdentityConstraints", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(HWStack), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(ActiveAxis), Member = "MoveToStartElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(SelectorActiveAxis), Member = "PushKS", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(BaseValidator), Member = "SendValidationEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallsUnknownMethods(Count = 5)]
	private void ElementIdentityConstraints() { }

	[CalledBy(Type = typeof(XsdValidator), Member = "ValidateEndElement", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(HWStack), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(XmlValidatingReaderImpl), Member = "get_TypedValueObject", ReturnType = typeof(object))]
	[Calls(Type = typeof(TypedObject), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string), typeof(XmlSchemaDatatype)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(KeySequence), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseValidator), Member = "SendValidationEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SelectorActiveAxis), Member = "PopKS", ReturnType = typeof(KeySequence))]
	[Calls(Type = typeof(KeySequence), Member = "IsQualified", ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlSchemaException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseValidator), Member = "SendValidationEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaException)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 26)]
	[CallsUnknownMethods(Count = 31)]
	private void EndElementIdentityConstraints() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlSchemaAny), Member = "get_ProcessContentsCorrect", ReturnType = typeof(XmlSchemaContentProcessing))]
	[CallsUnknownMethods(Count = 1)]
	private SchemaElementDecl FastGetElementDecl(object particle) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public virtual object FindId(string name) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	private bool get_HasIdentityConstraints() { }

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

	[CalledBy(Type = typeof(XsdValidator), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseValidator)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XsdValidator), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlValidatingReaderImpl), typeof(XmlSchemaCollection), typeof(IValidationEventHandling)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(XmlNamespaceManager), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNameTable)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(HWStack), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(Hashtable), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(SchemaInfo), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(XsdValidator), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallsUnknownMethods(Count = 15)]
	private void Init() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public bool IsXSDRoot(string localName, string ns) { }

	[CalledBy(Type = typeof(XsdValidator), Member = "ProcessXsiAttributes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName&), typeof(String&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(Dictionary`2), Member = "ContainsKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlSchemaCollection), Member = "GetSchemaInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(SchemaInfo))]
	[Calls(Type = typeof(BaseValidator), Member = "get_EventHandler", ReturnType = typeof(ValidationEventHandler))]
	[Calls(Type = typeof(SchemaInfo), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SchemaInfo), typeof(ValidationEventHandler)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XsdValidator), Member = "LoadSchemaFromLocation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 9)]
	private void LoadSchema(string uri, string url) { }

	[CalledBy(Type = typeof(XsdValidator), Member = "LoadSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(XmlTextReader), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Stream), typeof(XmlNameTable)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseValidator), Member = "get_SchemaNames", ReturnType = typeof(SchemaNames))]
	[Calls(Type = typeof(BaseValidator), Member = "get_EventHandler", ReturnType = typeof(ValidationEventHandler))]
	[Calls(Type = typeof(Parser), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SchemaType), typeof(XmlNameTable), typeof(SchemaNames), typeof(ValidationEventHandler)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Parser), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlReader), typeof(string)}, ReturnType = typeof(SchemaType))]
	[Calls(Type = typeof(SchemaInfo), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSchemaCollection), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(SchemaInfo), typeof(XmlSchema), typeof(bool)}, ReturnType = typeof(XmlSchema))]
	[Calls(Type = typeof(SchemaInfo), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SchemaInfo), typeof(ValidationEventHandler)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseValidator), Member = "SendValidationEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[]), typeof(XmlSeverityType)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallsUnknownMethods(Count = 29)]
	private void LoadSchemaFromLocation(string uri, string url) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(HWStack), Member = "Pop", ReturnType = typeof(object))]
	[Calls(Type = typeof(HWStack), Member = "Peek", ReturnType = typeof(object))]
	[CallsUnknownMethods(Count = 4)]
	private void Pop() { }

	[CalledBy(Type = typeof(XsdValidator), Member = "Validate", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XsdValidator), Member = "ValidateElement", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BaseValidator), Member = "SendValidationEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSchemaValidator), Member = "QNameString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(XmlSchemaType), Member = "IsDerivedFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaType), typeof(XmlSchemaType), typeof(XmlSchemaDerivationMethod)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlSchemaType), Member = "get_ElementDecl", ReturnType = typeof(SchemaElementDecl))]
	[Calls(Type = typeof(DatatypeImplementation), Member = "GetSimpleTypeFromXsdType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName)}, ReturnType = typeof(XmlSchemaSimpleType))]
	[Calls(Type = typeof(XmlQualifiedName), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlConvert), Member = "ToBoolean", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BaseValidator), Member = "SendValidationEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SchemaInfo), Member = "GetElementDecl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName)}, ReturnType = typeof(SchemaElementDecl))]
	[Calls(Type = typeof(BaseValidator), Member = "SendValidationEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSchemaAny), Member = "get_ProcessContentsCorrect", ReturnType = typeof(XmlSchemaContentProcessing))]
	[Calls(Type = typeof(XsdValidator), Member = "ValidateEndStartElement", ReturnType = typeof(void))]
	[Calls(Type = typeof(XsdValidator), Member = "ValidateStartElement", ReturnType = typeof(void))]
	[Calls(Type = typeof(XsdValidator), Member = "ElementIdentityConstraints", ReturnType = typeof(void))]
	[Calls(Type = typeof(XsdValidator), Member = "AddIdentityConstraints", ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlQualifiedName), Member = "get_IsEmpty", ReturnType = typeof(bool))]
	[Calls(Type = typeof(XsdValidator), Member = "ProcessXsiAttributes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName&), typeof(String&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XsdValidator), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseValidator), Member = "SendValidationEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(XmlSeverityType)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 7)]
	[ContainsUnimplementedInstructions]
	private void ProcessElement(object particle) { }

	[CalledBy(Type = typeof(XsdValidator), Member = "Validate", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XsdValidator), Member = "ValidateElement", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Parser), Member = "ParseReaderNode", ReturnType = typeof(bool))]
	[Calls(Type = typeof(SchemaInfo), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(Dictionary`2), Member = "ContainsKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlSchemaCollection), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(SchemaInfo), typeof(XmlSchema), typeof(bool)}, ReturnType = typeof(XmlSchema))]
	[Calls(Type = typeof(BaseValidator), Member = "get_EventHandler", ReturnType = typeof(ValidationEventHandler))]
	[Calls(Type = typeof(SchemaInfo), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SchemaInfo), typeof(ValidationEventHandler)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Uri), Member = "get_AbsoluteUri", ReturnType = typeof(string))]
	[Calls(Type = typeof(BaseValidator), Member = "SendValidationEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[]), typeof(XmlSeverityType)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 12)]
	private void ProcessInlineSchema() { }

	[CalledBy(Type = typeof(XsdValidator), Member = "CheckValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(SchemaAttDef)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(BaseValidator), Member = "get_EventHandler", ReturnType = typeof(ValidationEventHandler))]
	[Calls(Type = typeof(BaseValidator), Member = "ProcessEntity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SchemaInfo), typeof(string), typeof(object), typeof(ValidationEventHandler), typeof(string), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(IdRefNode), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IdRefNode), typeof(string), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Hashtable), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseValidator), Member = "SendValidationEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 3)]
	private void ProcessTokenizedType(XmlTokenizedType ttype, string name) { }

	[CalledBy(Type = typeof(XsdValidator), Member = "ProcessElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(XsdValidator), Member = "LoadSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 25)]
	[CallsUnknownMethods(Count = 20)]
	private void ProcessXsiAttributes(out XmlQualifiedName xsiType, out string xsiNil) { }

	[CalledBy(Type = typeof(XsdValidator), Member = "Init", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XsdValidator), Member = "ProcessElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(HWStack), Member = "Push", ReturnType = typeof(object))]
	[Calls(Type = typeof(ValidationState), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(HWStack), Member = "AddToTop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 8)]
	private void Push(XmlQualifiedName elementName) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SchemaInfo), Member = "GetElementDecl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName)}, ReturnType = typeof(SchemaElementDecl))]
	[Calls(Type = typeof(XmlQualifiedName), Member = "get_IsEmpty", ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BaseValidator), Member = "SendValidationEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlConvert), Member = "ToBoolean", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlQualifiedName), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DatatypeImplementation), Member = "GetSimpleTypeFromXsdType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName)}, ReturnType = typeof(XmlSchemaSimpleType))]
	[Calls(Type = typeof(XmlSchemaType), Member = "get_ElementDecl", ReturnType = typeof(SchemaElementDecl))]
	[Calls(Type = typeof(XmlSchemaType), Member = "IsDerivedFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaType), typeof(XmlSchemaType), typeof(XmlSchemaDerivationMethod)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlSchemaValidator), Member = "QNameString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(BaseValidator), Member = "SendValidationEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseValidator), Member = "SendValidationEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	private SchemaElementDecl ThoroughGetElementDecl(SchemaElementDecl elementDecl, XmlQualifiedName xsiType, string xsiNil) { }

	[CallerCount(Count = 0)]
	private object UnWrapUnion(object typedValue) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlQualifiedName), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XsdValidator), Member = "ValidateChildElement", ReturnType = typeof(object))]
	[Calls(Type = typeof(BaseValidator), Member = "get_SchemaNames", ReturnType = typeof(SchemaNames))]
	[Calls(Type = typeof(BaseValidator), Member = "get_EventHandler", ReturnType = typeof(ValidationEventHandler))]
	[Calls(Type = typeof(Parser), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SchemaType), typeof(XmlNameTable), typeof(SchemaNames), typeof(ValidationEventHandler)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Parser), Member = "StartParsing", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlReader), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XsdValidator), Member = "ProcessInlineSchema", ReturnType = typeof(void))]
	[Calls(Type = typeof(XsdValidator), Member = "ProcessElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XsdValidator), Member = "ValidateEndElement", ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseValidator), Member = "ValidateWhitespace", ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseValidator), Member = "ValidateText", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 2)]
	public virtual void Validate() { }

	[CalledBy(Type = typeof(XsdValidator), Member = "Validate", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XsdValidator), Member = "ValidateElement", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(BaseValidator), Member = "SendValidationEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseValidator), Member = "get_EventHandler", ReturnType = typeof(ValidationEventHandler))]
	[Calls(Type = typeof(XmlSchemaValidator), Member = "ElementValidationError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName), typeof(ValidationState), typeof(ValidationEventHandler), typeof(object), typeof(string), typeof(int), typeof(int), typeof(XmlSchemaSet)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 1)]
	private object ValidateChildElement() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlQualifiedName), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XsdValidator), Member = "ValidateChildElement", ReturnType = typeof(object))]
	[Calls(Type = typeof(BaseValidator), Member = "get_SchemaNames", ReturnType = typeof(SchemaNames))]
	[Calls(Type = typeof(BaseValidator), Member = "get_EventHandler", ReturnType = typeof(ValidationEventHandler))]
	[Calls(Type = typeof(Parser), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SchemaType), typeof(XmlNameTable), typeof(SchemaNames), typeof(ValidationEventHandler)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Parser), Member = "StartParsing", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlReader), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XsdValidator), Member = "ProcessInlineSchema", ReturnType = typeof(void))]
	[Calls(Type = typeof(XsdValidator), Member = "ProcessElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 2)]
	private void ValidateElement() { }

	[CalledBy(Type = typeof(XsdValidator), Member = "Validate", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BaseValidator), Member = "get_EventHandler", ReturnType = typeof(ValidationEventHandler))]
	[Calls(Type = typeof(XmlSchemaValidator), Member = "CompleteValidationError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ValidationState), typeof(ValidationEventHandler), typeof(object), typeof(string), typeof(int), typeof(int), typeof(XmlSchemaSet)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XsdValidator), Member = "CheckValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(SchemaAttDef)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XsdValidator), Member = "EndElementIdentityConstraints", ReturnType = typeof(void))]
	[Calls(Type = typeof(HWStack), Member = "Pop", ReturnType = typeof(object))]
	[Calls(Type = typeof(HWStack), Member = "Peek", ReturnType = typeof(object))]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 4)]
	private void ValidateEndElement() { }

	[CalledBy(Type = typeof(XsdValidator), Member = "ProcessElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SchemaElementDecl), Member = "get_HasDefaultAttribute", ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlValidatingReaderImpl), Member = "AddDefaultAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SchemaAttDef)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(SchemaDeclBase), Member = "get_DefaultValueRaw", ReturnType = typeof(string))]
	[Calls(Type = typeof(XsdValidator), Member = "AttributeIdentityConstraints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(object), typeof(string), typeof(SchemaAttDef)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlValidatingReaderImpl), Member = "get_StandAlone", ReturnType = typeof(bool))]
	[Calls(Type = typeof(SchemaElementDecl), Member = "CheckAttributes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Hashtable), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSchemaException), Member = "SetSource", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseValidator), Member = "SendValidationEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaException)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StringBuilder), Member = "set_Length", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 8)]
	private void ValidateEndStartElement() { }

	[CalledBy(Type = typeof(XsdValidator), Member = "ProcessElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SchemaInfo), Member = "GetAttributeXsd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SchemaElementDecl), typeof(XmlQualifiedName), typeof(Boolean&)}, ReturnType = typeof(SchemaAttDef))]
	[Calls(Type = typeof(XmlSchemaValidator), Member = "QNameString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(BaseValidator), Member = "SendValidationEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlValidatingReaderImpl), Member = "set_SchemaTypeObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlValidatingReaderImpl), Member = "set_TypedValueObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlQualifiedName), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SchemaInfo), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BaseValidator), Member = "SendValidationEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(XmlSeverityType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XsdValidator), Member = "CheckValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(SchemaAttDef)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlValidatingReaderImpl), Member = "get_TypedValueObject", ReturnType = typeof(object))]
	[Calls(Type = typeof(XsdValidator), Member = "AttributeIdentityConstraints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(object), typeof(string), typeof(SchemaAttDef)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSchemaException), Member = "SetSource", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseValidator), Member = "SendValidationEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaException)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 19)]
	[CallsUnknownMethods(Count = 19)]
	[ContainsUnimplementedInstructions]
	private void ValidateStartElement() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XsdValidator), Member = "AddIdentityConstraints", ReturnType = typeof(void))]
	[Calls(Type = typeof(XsdValidator), Member = "ElementIdentityConstraints", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private void ValidateStartElementIdentityConstraints() { }

}

