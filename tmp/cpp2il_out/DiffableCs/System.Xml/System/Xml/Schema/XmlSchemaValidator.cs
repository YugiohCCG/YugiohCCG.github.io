namespace System.Xml.Schema;

public sealed class XmlSchemaValidator
{
	private static readonly XmlSchemaDatatype dtQName; //Field offset: 0x0
	private static readonly XmlSchemaDatatype dtCDATA; //Field offset: 0x8
	private static readonly XmlSchemaDatatype dtStringArray; //Field offset: 0x10
	private static XmlSchemaParticle[] EmptyParticleArray; //Field offset: 0x18
	private static XmlSchemaAttribute[] EmptyAttributeArray; //Field offset: 0x20
	internal static Boolean[2] ValidStates; //Field offset: 0x28
	private static String[] MethodNames; //Field offset: 0x30
	private XmlSchemaSet schemaSet; //Field offset: 0x10
	private XmlSchemaValidationFlags validationFlags; //Field offset: 0x18
	private int startIDConstraint; //Field offset: 0x1C
	private bool isRoot; //Field offset: 0x20
	private bool rootHasSchema; //Field offset: 0x21
	private bool attrValid; //Field offset: 0x22
	private bool checkEntity; //Field offset: 0x23
	private SchemaInfo compiledSchemaInfo; //Field offset: 0x28
	private IDtdInfo dtdSchemaInfo; //Field offset: 0x30
	private Hashtable validatedNamespaces; //Field offset: 0x38
	private HWStack validationStack; //Field offset: 0x40
	private ValidationState context; //Field offset: 0x48
	private ValidatorState currentState; //Field offset: 0x50
	private Hashtable attPresence; //Field offset: 0x58
	private SchemaAttDef wildID; //Field offset: 0x60
	private Hashtable IDs; //Field offset: 0x68
	private IdRefNode idRefListHead; //Field offset: 0x70
	private XmlQualifiedName contextQName; //Field offset: 0x78
	private string NsXs; //Field offset: 0x80
	private string NsXsi; //Field offset: 0x88
	private string NsXmlNs; //Field offset: 0x90
	private string NsXml; //Field offset: 0x98
	private XmlSchemaObject partialValidationType; //Field offset: 0xA0
	private StringBuilder textValue; //Field offset: 0xA8
	private ValidationEventHandler eventHandler; //Field offset: 0xB0
	private object validationEventSender; //Field offset: 0xB8
	private XmlNameTable nameTable; //Field offset: 0xC0
	private IXmlLineInfo positionInfo; //Field offset: 0xC8
	private IXmlLineInfo dummyPositionInfo; //Field offset: 0xD0
	private XmlResolver xmlResolver; //Field offset: 0xD8
	private Uri sourceUri; //Field offset: 0xE0
	private string sourceUriString; //Field offset: 0xE8
	private IXmlNamespaceResolver nsResolver; //Field offset: 0xF0
	private XmlSchemaContentProcessing processContents; //Field offset: 0xF8
	private string xsiTypeString; //Field offset: 0x100
	private string xsiNilString; //Field offset: 0x108
	private string xsiSchemaLocationString; //Field offset: 0x110
	private string xsiNoNamespaceSchemaLocationString; //Field offset: 0x118
	private XmlCharType xmlCharType; //Field offset: 0x120

	public event ValidationEventHandler ValidationEventHandler
	{
		[CalledBy(Type = typeof(XsdValidatingReader), Member = "SetupValidator", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlReaderSettings), typeof(XmlReader), typeof(XmlSchemaObject)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[CallsUnknownMethods(Count = 3)]
		 add { } //Length: 171
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[CallsUnknownMethods(Count = 3)]
		 remove { } //Length: 171
	}

	internal XmlSchemaContentType CurrentContentType
	{
		[CalledBy(Type = typeof(XsdValidatingReader), Member = "get_NodeType", ReturnType = typeof(XmlNodeType))]
		[CallerCount(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		internal get { } //Length: 59
	}

	private bool HasIdentityConstraints
	{
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		private get { } //Length: 17
	}

	private bool HasSchema
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SchemaInfo), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 1)]
		private get { } //Length: 71
	}

	public IXmlLineInfo LineInfoProvider
	{
		[CalledBy(Type = typeof(XsdValidatingReader), Member = "SetupValidator", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlReaderSettings), typeof(XmlReader), typeof(XmlSchemaObject)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		 set { } //Length: 34
	}

	internal bool ProcessIdentityConstraints
	{
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		internal get { } //Length: 8
	}

	internal bool ProcessSchemaHints
	{
		[CalledBy(Type = typeof(XsdValidatingReader), Member = "SetupValidator", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlReaderSettings), typeof(XmlReader), typeof(XmlSchemaObject)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[ContainsUnimplementedInstructions]
		internal get { } //Length: 17
	}

	internal bool ReportValidationWarnings
	{
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		internal get { } //Length: 8
	}

	internal XmlSchemaSet SchemaSet
	{
		[CallerCount(Count = 106)]
		[DeduplicatedMethod]
		internal get { } //Length: 5
	}

	public Uri SourceUri
	{
		[CalledBy(Type = typeof(XsdValidatingReader), Member = "SetupValidator", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlReaderSettings), typeof(XmlReader), typeof(XmlSchemaObject)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 3)]
		 set { } //Length: 88
	}

	private bool StrictlyAssessed
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		private get { } //Length: 62
	}

	public object ValidationEventSender
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 set { } //Length: 19
	}

	internal XmlSchemaValidationFlags ValidationFlags
	{
		[CallerCount(Count = 7)]
		[DeduplicatedMethod]
		internal get { } //Length: 4
	}

	public XmlResolver XmlResolver
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 set { } //Length: 19
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlSchemaDatatype), Member = "FromXmlTokenizedTypeXsd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlTokenizedType)}, ReturnType = typeof(XmlSchemaDatatype))]
	[Calls(Type = typeof(XmlSchemaDatatype), Member = "FromXmlTokenizedType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlTokenizedType)}, ReturnType = typeof(XmlSchemaDatatype))]
	[Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(RuntimeFieldHandle)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 22)]
	private static XmlSchemaValidator() { }

	[CalledBy(Type = typeof(XsdValidatingReader), Member = "SetupValidator", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlReaderSettings), typeof(XmlReader), typeof(XmlSchemaObject)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(XmlCharType), Member = "get_Instance", ReturnType = typeof(XmlCharType))]
	[Calls(Type = typeof(XmlSchemaSet), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNameTable)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(XmlReaderSettings), Member = "GetXmlResolver_CheckConfig", ReturnType = typeof(XmlResolver))]
	[Calls(Type = typeof(XmlReaderSettings), Member = "set_XmlResolver", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlResolver)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSchemaSet), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaSet)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Hashtable), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSchemaValidator), Member = "Init", ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 26)]
	public XmlSchemaValidator(XmlNameTable nameTable, XmlSchemaSet schemas, IXmlNamespaceResolver namespaceResolver, XmlSchemaValidationFlags validationFlags) { }

	[CalledBy(Type = typeof(XsdValidatingReader), Member = "SetupValidator", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlReaderSettings), typeof(XmlReader), typeof(XmlSchemaObject)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[CallsUnknownMethods(Count = 3)]
	public void add_ValidationEventHandler(ValidationEventHandler value) { }

	[CalledBy(Type = typeof(XmlSchemaValidator), Member = "ValidateElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(XmlSchemaInfo), typeof(string), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSchemaValidator), Member = "ValidateStartElementIdentityConstraints", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ConstraintStruct), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CompiledIdentityConstraint)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(HWStack), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(XmlQualifiedName), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName), typeof(XmlQualifiedName)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Hashtable), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(XmlSchemaValidator), Member = "SendValidationEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 8)]
	private void AddIdentityConstraints() { }

	[CalledBy(Type = typeof(XsdValidatingReader), Member = "ProcessInlineSchema", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(XmlSchemaSet), Member = "FindSchemaByNSAndUrl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(string), typeof(DictionaryEntry[])}, ReturnType = typeof(XmlSchema))]
	[Calls(Type = typeof(XmlSchemaValidator), Member = "SendValidationEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(XmlSeverityType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSchemaSet), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchema)}, ReturnType = typeof(XmlSchema))]
	[Calls(Type = typeof(XmlSchemaValidator), Member = "RecompileSchemaSet", ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSchemaValidator), Member = "SendValidationEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[]), typeof(Exception)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSchema), Member = "get_ImportedSchemas", ReturnType = typeof(ArrayList))]
	[Calls(Type = typeof(XmlSchemaSet), Member = "RemoveRecursive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchema)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 12)]
	public void AddSchema(XmlSchema schema) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NameTable), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSchemaSet), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNameTable)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Preprocessor), Member = "GetBuildInSchema", ReturnType = typeof(XmlSchema))]
	[Calls(Type = typeof(XmlSchemaSet), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchema)}, ReturnType = typeof(XmlSchema))]
	[Calls(Type = typeof(XmlSchemaSet), Member = "Compile", ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSchemaSet), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaSet)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSchemaValidator), Member = "RecompileSchemaSet", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private void AddXmlNamespaceSchema() { }

	[CalledBy(Type = typeof(XmlSchemaValidator), Member = "ValidateAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(XmlValueGetter), typeof(string), typeof(XmlSchemaInfo)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(XmlSchemaValidator), Member = "GetUnspecifiedDefaultAttributes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ArrayList), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(HWStack), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(ActiveAxis), Member = "MoveToAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TypedObject), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string), typeof(XmlSchemaDatatype)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(KeySequence), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSchemaValidator), Member = "SendValidationEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 5)]
	private void AttributeIdentityConstraints(string name, string ns, object obj, string sobj, XmlSchemaDatatype datatype) { }

	[CalledBy(Type = typeof(BaseValidator), Member = "ValidateText", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSchemaValidator), Member = "ValidateText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(XmlValueGetter)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSchemaValidator), Member = "ValidateElementContext", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName), typeof(Boolean&)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(XmlSchemaValidator), Member = "ElementValidationError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName), typeof(ValidationState), typeof(ValidationEventHandler), typeof(object), typeof(string), typeof(int), typeof(int), typeof(XmlSchemaSet)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSchemaValidator), Member = "CompleteValidationError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ValidationState), typeof(ValidationEventHandler), typeof(object), typeof(string), typeof(int), typeof(int), typeof(XmlSchemaSet)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSchemaValidator), Member = "BuildElementName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName)}, ReturnType = typeof(string))]
	[CallerCount(Count = 19)]
	[Calls(Type = typeof(Res), Member = "GetString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 14)]
	internal static string BuildElementName(string localName, string ns) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlSchemaValidator), Member = "BuildElementName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 1)]
	internal static string BuildElementName(XmlQualifiedName qname) { }

	[CalledBy(Type = typeof(XmlSchemaValidator), Member = "ValidateAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(XmlValueGetter), typeof(string), typeof(XmlSchemaInfo)}, ReturnType = typeof(object))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SchemaDeclBase), Member = "CheckValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlSchemaValidator), Member = "SendValidationEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSchemaDatatype), Member = "ConcatenatedToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(XmlSchemaDatatype), Member = "get_TypeCodeString", ReturnType = typeof(string))]
	[Calls(Type = typeof(XmlSchemaValidator), Member = "SendValidationEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[]), typeof(Exception)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 7)]
	private object CheckAttributeValue(object value, SchemaAttDef attdef) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(XmlSchemaValidator), Member = "SendValidationEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private void CheckElementProperties() { }

	[CalledBy(Type = typeof(XmlSchemaValidator), Member = "ValidateAtomicValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(XmlSchemaSimpleType&)}, ReturnType = typeof(object))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SchemaDeclBase), Member = "CheckValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(XmlSchemaValidator), Member = "SendValidationEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSchemaDatatype), Member = "get_TypeCodeString", ReturnType = typeof(string))]
	[Calls(Type = typeof(XmlSchemaValidator), Member = "SendValidationEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[]), typeof(Exception)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 7)]
	private object CheckElementValue(string stringValue) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlSchemaValidationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSchemaValidator), Member = "SendValidationEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaValidationException), typeof(XmlSeverityType)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void CheckForwardRefs() { }

	[CalledBy(Type = typeof(XmlSchemaValidator), Member = "ValidateAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(XmlValueGetter), typeof(string), typeof(XmlSchemaInfo)}, ReturnType = typeof(object))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(SchemaInfo), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(NameTable), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSchemaSet), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNameTable)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Preprocessor), Member = "GetBuildInSchema", ReturnType = typeof(XmlSchema))]
	[Calls(Type = typeof(XmlSchemaSet), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchema)}, ReturnType = typeof(XmlSchema))]
	[Calls(Type = typeof(XmlSchemaSet), Member = "Compile", ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSchemaSet), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaSet)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSchemaValidator), Member = "RecompileSchemaSet", ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object&)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private SchemaAttDef CheckIsXmlAttribute(XmlQualifiedName attQName) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SchemaDeclBase), Member = "get_DefaultValueRaw", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlSchemaValidator), Member = "SendValidationEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	internal object CheckMixedValueConstraint(string elementValue) { }

	[CalledBy(Type = typeof(XmlSchemaValidator), Member = "ValidateEndOfAttributes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaInfo)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSchemaValidator), Member = "InternalValidateEndElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaInfo), typeof(object)}, ReturnType = typeof(object))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlSchemaValidator), Member = "SendValidationEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 5)]
	private void CheckRequiredAttributes(SchemaElementDecl currentElementDecl) { }

	[CalledBy(Type = typeof(XmlSchemaValidator), Member = "ValidateElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(XmlSchemaInfo), typeof(string), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSchemaValidator), Member = "ValidateAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(XmlValueGetter), typeof(string), typeof(XmlSchemaInfo)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(XmlSchemaValidator), Member = "ValidateEndOfAttributes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaInfo)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSchemaValidator), Member = "ValidateText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(XmlValueGetter)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSchemaValidator), Member = "ValidateWhitespace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(XmlValueGetter)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSchemaValidator), Member = "SkipToEndElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaInfo)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSchemaValidator), Member = "EndValidation", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSchemaValidator), Member = "InternalValidateEndElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaInfo), typeof(object)}, ReturnType = typeof(object))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(Res), Member = "GetString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 30)]
	private void CheckStateTransition(ValidatorState toState, string methodName) { }

	[CalledBy(Type = typeof(XmlSchemaValidator), Member = "ValidateAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(XmlValueGetter), typeof(string), typeof(XmlSchemaInfo)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(XmlSchemaValidator), Member = "GetUnspecifiedDefaultAttributes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ArrayList), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSchemaValidator), Member = "ValidateAtomicValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(XmlSchemaSimpleType&)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(XmlSchemaValidator), Member = "ValidateAtomicValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(XmlSchemaSimpleType&)}, ReturnType = typeof(object))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(XmlSchemaValidator), Member = "ProcessTokenizedType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlTokenizedType), typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 5)]
	private void CheckTokenizedTypes(XmlSchemaDatatype dtype, object typedValue, bool attrValue) { }

	[CalledBy(Type = typeof(XmlSchemaValidator), Member = "ValidateElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(XmlSchemaInfo), typeof(string), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SchemaInfo), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(SchemaDeclBase), Member = "get_DefaultValueRaw", ReturnType = typeof(string))]
	[Calls(Type = typeof(SchemaElementDecl), Member = "Clone", ReturnType = typeof(SchemaElementDecl))]
	[Calls(Type = typeof(XmlSchemaType), Member = "IsDerivedFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaType), typeof(XmlSchemaType), typeof(XmlSchemaDerivationMethod)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlSchemaType), Member = "GetBuiltInComplexType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName)}, ReturnType = typeof(XmlSchemaComplexType))]
	[Calls(Type = typeof(DatatypeImplementation), Member = "GetSimpleTypeFromXsdType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName)}, ReturnType = typeof(XmlSchemaSimpleType))]
	[Calls(Type = typeof(SchemaInfo), Member = "GetTypeDecl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName)}, ReturnType = typeof(SchemaElementDecl))]
	[Calls(Type = typeof(XmlSchemaValidator), Member = "SendValidationEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlQualifiedName), Member = "get_IsEmpty", ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlSchemaValidator), Member = "SendValidationEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlConvert), Member = "ToBoolean", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlSchemaValidator), Member = "SendValidationEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[]), typeof(Exception)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSchemaDatatype), Member = "get_TypeCodeString", ReturnType = typeof(string))]
	[Calls(Type = typeof(XmlSchemaValidator), Member = "SendValidationEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(XmlSeverityType)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 13)]
	[ContainsUnimplementedInstructions]
	private SchemaElementDecl CheckXsiTypeAndNil(SchemaElementDecl elementDecl, string xsiType, string xsiNil, ref bool declFound) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StringBuilder), Member = "set_Length", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void ClearPSVI() { }

	[CalledBy(Type = typeof(DtdValidator), Member = "ValidateEndElement", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XdrValidator), Member = "ValidateEndElement", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSchemaValidator), Member = "InternalValidateEndElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaInfo), typeof(object)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(XsdValidator), Member = "ValidateEndElement", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(XmlSchemaValidator), Member = "BuildElementName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(XmlSchemaValidator), Member = "PrintExpectedElements", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ArrayList), typeof(bool)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(XmlSchemaException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[]), typeof(Exception), typeof(string), typeof(int), typeof(int), typeof(XmlSchemaObject)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ValidationEventArgs), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaException), typeof(XmlSeverityType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSchemaValidationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 17)]
	[ContainsUnimplementedInstructions]
	internal static void CompleteValidationError(ValidationState context, ValidationEventHandler eventHandler, object sender, string sourceUri, int lineNo, int linePos, XmlSchemaSet schemaSet) { }

	[CalledBy(Type = typeof(XmlSchemaValidator), Member = "ValidateElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(XmlSchemaInfo), typeof(string), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSchemaValidator), Member = "ValidateStartElementIdentityConstraints", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(HWStack), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(ActiveAxis), Member = "MoveToStartElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(SelectorActiveAxis), Member = "PushKS", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(XmlSchemaValidator), Member = "SendValidationEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 7)]
	private void ElementIdentityConstraints() { }

	[CalledBy(Type = typeof(DtdValidator), Member = "ValidateElement", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DtdValidator), Member = "ValidateChildElement", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XdrValidator), Member = "ValidateElement", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XdrValidator), Member = "ValidateChildElement", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSchemaValidator), Member = "ValidateElementContext", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName), typeof(Boolean&)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(XsdValidator), Member = "ValidateChildElement", ReturnType = typeof(object))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(ContentValidator), Member = "get_IsOpen", ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(XmlSchemaException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[]), typeof(Exception), typeof(string), typeof(int), typeof(int), typeof(XmlSchemaObject)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ValidationEventArgs), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaException), typeof(XmlSeverityType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSchemaValidator), Member = "BuildElementName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(XmlSchemaValidator), Member = "PrintExpectedElements", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ArrayList), typeof(bool)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 30)]
	[ContainsUnimplementedInstructions]
	internal static void ElementValidationError(XmlQualifiedName name, ValidationState context, ValidationEventHandler eventHandler, object sender, string sourceUri, int lineNo, int linePos, XmlSchemaSet schemaSet) { }

	[CalledBy(Type = typeof(XmlSchemaValidator), Member = "InternalValidateEndElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaInfo), typeof(object)}, ReturnType = typeof(object))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(HWStack), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(TypedObject), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string), typeof(XmlSchemaDatatype)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(KeySequence), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSchemaValidator), Member = "SendValidationEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SelectorActiveAxis), Member = "PopKS", ReturnType = typeof(KeySequence))]
	[Calls(Type = typeof(KeySequence), Member = "IsQualified", ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlSchemaValidationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSchemaException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[]), typeof(Exception), typeof(string), typeof(int), typeof(int), typeof(XmlSchemaObject)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSchemaValidator), Member = "SendValidationEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaValidationException), typeof(XmlSeverityType)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 15)]
	[CallsUnknownMethods(Count = 30)]
	private void EndElementIdentityConstraints(object typedValue, string stringValue, XmlSchemaDatatype datatype) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlSchemaValidator), Member = "CheckStateTransition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ValidatorState), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSchemaValidationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSchemaValidator), Member = "SendValidationEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaValidationException), typeof(XmlSeverityType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 8)]
	public void EndValidation() { }

	[CalledBy(Type = typeof(XmlSchemaValidator), Member = "PrintNamesWithNS", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ArrayList), typeof(StringBuilder)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlConvert), Member = "SplitString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(String[]))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(Res), Member = "GetString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 6)]
	private static void EnumerateAny(StringBuilder builder, string namespaces) { }

	[CalledBy(Type = typeof(XmlSchemaValidator), Member = "ValidateElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(XmlSchemaInfo), typeof(string), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(XmlSchemaAny), Member = "get_ProcessContentsCorrect", ReturnType = typeof(XmlSchemaContentProcessing))]
	[Calls(Type = typeof(XmlSchemaValidator), Member = "SendValidationEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSchemaValidator), Member = "SendValidationEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SchemaInfo), Member = "GetElementDecl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName)}, ReturnType = typeof(SchemaElementDecl))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 5)]
	private SchemaElementDecl FastGetElementDecl(XmlQualifiedName elementName, object particle) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private object FindId(string name) { }

	[CalledBy(Type = typeof(XsdValidatingReader), Member = "get_NodeType", ReturnType = typeof(XmlNodeType))]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	internal XmlSchemaContentType get_CurrentContentType() { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	private bool get_HasIdentityConstraints() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SchemaInfo), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	private bool get_HasSchema() { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	internal bool get_ProcessIdentityConstraints() { }

	[CalledBy(Type = typeof(XsdValidatingReader), Member = "SetupValidator", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlReaderSettings), typeof(XmlReader), typeof(XmlSchemaObject)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[ContainsUnimplementedInstructions]
	internal bool get_ProcessSchemaHints() { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	internal bool get_ReportValidationWarnings() { }

	[CallerCount(Count = 106)]
	[DeduplicatedMethod]
	internal XmlSchemaSet get_SchemaSet() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private bool get_StrictlyAssessed() { }

	[CallerCount(Count = 7)]
	[DeduplicatedMethod]
	internal XmlSchemaValidationFlags get_ValidationFlags() { }

	[CalledBy(Type = typeof(XsdValidatingReader), Member = "GetOriginalAtomicValueStringOfElement", ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	internal string GetConcatenatedValue() { }

	[CalledBy(Type = typeof(XsdValidatingReader), Member = "get_Name", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(XmlSchemaValidator), Member = "GetUnspecifiedDefaultAttributes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ArrayList), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 13)]
	internal string GetDefaultAttributePrefix(string attributeNS) { }

	[CalledBy(Type = typeof(XmlSchemaValidator), Member = "ValidateElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(XmlSchemaInfo), typeof(string), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSchemaValidator), Member = "SkipToEndElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaInfo)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSchemaValidator), Member = "InternalValidateEndElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaInfo), typeof(object)}, ReturnType = typeof(object))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(XmlSchemaElement), Member = "Clone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchema)}, ReturnType = typeof(XmlSchemaObject))]
	[Calls(Type = typeof(XmlSchemaElement), Member = "set_SchemaTypeName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	private XmlSchemaElement GetSchemaElement() { }

	[CalledBy(Type = typeof(XmlSchemaValidator), Member = "ValidateElementContext", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName), typeof(Boolean&)}, ReturnType = typeof(object))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SchemaInfo), Member = "GetElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName)}, ReturnType = typeof(XmlSchemaElement))]
	[Calls(Type = typeof(XmlQualifiedName), Member = "get_IsEmpty", ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlSchemaType), Member = "IsDerivedFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaType), typeof(XmlSchemaType), typeof(XmlSchemaDerivationMethod)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlSchemaValidator), Member = "SendValidationEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[])}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 6)]
	private XmlSchemaElement GetSubstitutionGroupHead(XmlQualifiedName member) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlSchemaDatatype), Member = "get_TypeCodeString", ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private string GetTypeName(SchemaDeclBase decl) { }

	[CalledBy(Type = typeof(XsdValidatingReader), Member = "ValidateAttributes", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(XmlSchemaValidator), Member = "AttributeIdentityConstraints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(object), typeof(string), typeof(XmlSchemaDatatype)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SchemaDeclBase), Member = "get_DefaultValueRaw", ReturnType = typeof(string))]
	[Calls(Type = typeof(XmlSchemaValidator), Member = "CheckTokenizedTypes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaDatatype), typeof(object), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSchemaType), Member = "get_ValueConverter", ReturnType = typeof(XmlValueConverter))]
	[Calls(Type = typeof(XmlSchemaInfo), Member = "get_XmlType", ReturnType = typeof(XmlSchemaType))]
	[Calls(Type = typeof(XmlSchemaInfo), Member = "set_SchemaAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaAttribute)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSchemaInfo), Member = "set_SchemaType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AttributePSVIInfo), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(ValidatingReaderNodeData), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSchemaValidator), Member = "SendValidationEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(XmlSchemaValidator), Member = "GetDefaultAttributePrefix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(SchemaElementDecl), Member = "get_HasDefaultAttribute", ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 11)]
	[CallsUnknownMethods(Count = 15)]
	internal void GetUnspecifiedDefaultAttributes(ArrayList defaultAttributes, bool createNodeData) { }

	[CalledBy(Type = typeof(XmlSchemaValidator), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNameTable), typeof(XmlSchemaSet), typeof(IXmlNamespaceResolver), typeof(XmlSchemaValidationFlags)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(HWStack), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Hashtable), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSchemaValidator), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlReaderSection), Member = "CreateDefaultResolver", ReturnType = typeof(XmlResolver))]
	[Calls(Type = typeof(XmlQualifiedName), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSchemaValidator), Member = "Reset", ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSchemaValidator), Member = "RecompileSchemaSet", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallsUnknownMethods(Count = 17)]
	private void Init() { }

	[CalledBy(Type = typeof(XsdValidatingReader), Member = "SetupValidator", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlReaderSettings), typeof(XmlReader), typeof(XmlSchemaObject)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(XmlSchemaValidator), Member = "Reset", ReturnType = typeof(void))]
	[Calls(Type = typeof(Res), Member = "GetString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 17)]
	public void Initialize() { }

	[CalledBy(Type = typeof(XsdValidatingReader), Member = "SetupValidator", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlReaderSettings), typeof(XmlReader), typeof(XmlSchemaObject)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(XmlSchemaValidator), Member = "Reset", ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Res), Member = "GetString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 26)]
	public void Initialize(XmlSchemaObject partialValidationType) { }

	[CalledBy(Type = typeof(XmlSchemaValidator), Member = "ValidateEndElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaInfo)}, ReturnType = typeof(object))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Res), Member = "GetString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSchemaValidator), Member = "Pop", ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSchemaInfo), Member = "set_SchemaElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaElement)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSchemaInfo), Member = "set_SchemaType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSchemaValidator), Member = "GetSchemaElement", ReturnType = typeof(XmlSchemaElement))]
	[Calls(Type = typeof(XmlSchemaValidator), Member = "EndElementIdentityConstraints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string), typeof(XmlSchemaDatatype)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSchemaValidator), Member = "CompleteValidationError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ValidationState), typeof(ValidationEventHandler), typeof(object), typeof(string), typeof(int), typeof(int), typeof(XmlSchemaSet)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSchemaValidator), Member = "ValidateAtomicValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(XmlSchemaSimpleType&)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(XmlSchemaValidator), Member = "ValidateAtomicValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(XmlSchemaSimpleType&)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(XmlSchemaValidator), Member = "SendValidationEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(SchemaDeclBase), Member = "get_DefaultValueRaw", ReturnType = typeof(string))]
	[Calls(Type = typeof(XmlSchemaValidator), Member = "CheckRequiredAttributes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SchemaElementDecl)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSchemaValidator), Member = "CheckStateTransition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ValidatorState), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 22)]
	private object InternalValidateEndElement(XmlSchemaInfo schemaInfo, object typedValue) { }

	[CalledBy(Type = typeof(XmlSchemaValidator), Member = "ProcessSchemaLocations", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(XmlReaderSettings), Member = "set_CloseInput", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlReaderSettings), Member = "set_XmlResolver", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlResolver)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlReader), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(XmlReaderSettings), typeof(string)}, ReturnType = typeof(XmlReader))]
	[Calls(Type = typeof(XmlSchemaSet), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(XmlReader), typeof(Hashtable)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSchemaValidator), Member = "SendValidationEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[]), typeof(Exception)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSchemaValidator), Member = "SendValidationEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[]), typeof(Exception), typeof(XmlSeverityType)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallsUnknownMethods(Count = 25)]
	private void LoadSchema(string uri, string url) { }

	[CalledBy(Type = typeof(XmlSchemaValidator), Member = "SkipToEndElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaInfo)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSchemaValidator), Member = "InternalValidateEndElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaInfo), typeof(object)}, ReturnType = typeof(object))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(HWStack), Member = "Pop", ReturnType = typeof(object))]
	[Calls(Type = typeof(HWStack), Member = "Peek", ReturnType = typeof(object))]
	[CallsUnknownMethods(Count = 6)]
	private void Pop() { }

	[CalledBy(Type = typeof(BaseValidator), Member = "ValidateText", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSchemaValidator), Member = "ValidateText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(XmlValueGetter)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSchemaValidator), Member = "ElementValidationError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName), typeof(ValidationState), typeof(ValidationEventHandler), typeof(object), typeof(string), typeof(int), typeof(int), typeof(XmlSchemaSet)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSchemaValidator), Member = "CompleteValidationError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ValidationState), typeof(ValidationEventHandler), typeof(object), typeof(string), typeof(int), typeof(int), typeof(XmlSchemaSet)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(Res), Member = "GetString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArrayList), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSchemaParticle), Member = "GetQualifiedName", ReturnType = typeof(XmlQualifiedName))]
	[Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlSchemaValidator), Member = "PrintNamesWithNS", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ArrayList), typeof(StringBuilder)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 15)]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	internal static string PrintExpectedElements(ArrayList expected, bool getParticles) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(StringBuilder))]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 1)]
	private static string PrintNames(ArrayList expected) { }

	[CalledBy(Type = typeof(XmlSchemaValidator), Member = "PrintExpectedElements", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ArrayList), typeof(bool)}, ReturnType = typeof(string))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(Res), Member = "GetString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(XmlSchemaValidator), Member = "EnumerateAny", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallsUnknownMethods(Count = 26)]
	private static void PrintNamesWithNS(ArrayList expected, StringBuilder builder) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlSchemaValidator), Member = "SendValidationEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void ProcessEntity(string name) { }

	[CalledBy(Type = typeof(XmlSchemaValidator), Member = "ValidateElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(XmlSchemaInfo), typeof(string), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(XmlSchemaValidator), Member = "LoadSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSchemaValidator), Member = "SendValidationEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaException)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSchemaDatatype), Member = "get_TypeCodeString", ReturnType = typeof(string))]
	[Calls(Type = typeof(XmlSchemaValidator), Member = "SendValidationEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[]), typeof(Exception)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSchemaValidator), Member = "RecompileSchemaSet", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 11)]
	private void ProcessSchemaLocations(string xsiSchemaLocation, string xsiNoNamespaceSchemaLocation) { }

	[CalledBy(Type = typeof(XmlSchemaValidator), Member = "CheckTokenizedTypes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaDatatype), typeof(object), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(XmlSchemaValidator), Member = "SendValidationEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Hashtable), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 9)]
	private void ProcessTokenizedType(XmlTokenizedType ttype, string name, bool attrValue) { }

	[CalledBy(Type = typeof(XmlSchemaValidator), Member = "Init", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSchemaValidator), Member = "ValidateElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(XmlSchemaInfo), typeof(string), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(HWStack), Member = "Push", ReturnType = typeof(object))]
	[Calls(Type = typeof(ValidationState), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(HWStack), Member = "AddToTop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 9)]
	private void Push(XmlQualifiedName elementName) { }

	[CalledBy(Type = typeof(BaseValidator), Member = "ValidateText", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BaseValidator), Member = "ValidateWhitespace", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DtdValidator), Member = "ValidateElement", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DtdValidator), Member = "ProcessElement", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DtdValidator), Member = "CheckValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(SchemaAttDef)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XdrValidator), Member = "ThoroughGetElementDecl", ReturnType = typeof(SchemaElementDecl))]
	[CalledBy(Type = typeof(XdrValidator), Member = "CheckValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(SchemaAttDef)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XsdValidator), Member = "ProcessElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XsdValidator), Member = "ThoroughGetElementDecl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SchemaElementDecl), typeof(XmlQualifiedName), typeof(string)}, ReturnType = typeof(SchemaElementDecl))]
	[CalledBy(Type = typeof(XsdValidator), Member = "ValidateStartElement", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XsdValidator), Member = "CheckValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(SchemaAttDef)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XsdValidator), Member = "AddIdentityConstraints", ReturnType = typeof(void))]
	[CallerCount(Count = 19)]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 1)]
	internal static string QNameString(string localName, string ns) { }

	[CalledBy(Type = typeof(XmlSchemaValidator), Member = "Init", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSchemaValidator), Member = "AddSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchema)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSchemaValidator), Member = "ProcessSchemaLocations", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSchemaValidator), Member = "CheckIsXmlAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName)}, ReturnType = typeof(SchemaAttDef))]
	[CalledBy(Type = typeof(XmlSchemaValidator), Member = "AddXmlNamespaceSchema", ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(XmlSchemaSet), Member = "Compile", ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSchemaValidator), Member = "SendValidationEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaException)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	internal void RecompileSchemaSet() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[CallsUnknownMethods(Count = 3)]
	public void remove_ValidationEventHandler(ValidationEventHandler value) { }

	[CalledBy(Type = typeof(XmlSchemaValidator), Member = "Init", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSchemaValidator), Member = "Initialize", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSchemaValidator), Member = "Initialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaObject)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(HWStack), Member = "Pop", ReturnType = typeof(object))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	private void Reset() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(StringBuilder))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void SaveTextValue(object value) { }

	[CalledBy(Type = typeof(XmlSchemaValidator), Member = "LoadSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(XmlSchemaException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[]), typeof(Exception), typeof(string), typeof(int), typeof(int), typeof(XmlSchemaObject)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSchemaValidator), Member = "SendValidationEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaValidationException), typeof(XmlSeverityType)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	private void SendValidationEvent(string code, String[] args, Exception innerException, XmlSeverityType severity) { }

	[CallerCount(Count = 0)]
	[ContainsInvalidInstructions]
	private void SendValidationEvent(string code) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ValidationEventArgs), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaException), typeof(XmlSeverityType)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	internal static void SendValidationEvent(ValidationEventHandler eventHandler, object sender, XmlSchemaValidationException e, XmlSeverityType severity) { }

	[CalledBy(Type = typeof(XmlSchemaValidator), Member = "ValidateElementContext", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName), typeof(Boolean&)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(XmlSchemaValidator), Member = "FastGetElementDecl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName), typeof(object)}, ReturnType = typeof(SchemaElementDecl))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(XmlSchemaException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[]), typeof(Exception), typeof(string), typeof(int), typeof(int), typeof(XmlSchemaObject)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 6)]
	[ContainsInvalidInstructions]
	private void SendValidationEvent(string code, string arg1, string arg2) { }

	[CalledBy(Type = typeof(XmlSchemaValidator), Member = "ValidateAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(XmlValueGetter), typeof(string), typeof(XmlSchemaInfo)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(XmlSchemaValidator), Member = "ValidateText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(XmlValueGetter)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSchemaValidator), Member = "GetUnspecifiedDefaultAttributes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ArrayList), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSchemaValidator), Member = "GetSubstitutionGroupHead", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName)}, ReturnType = typeof(XmlSchemaElement))]
	[CalledBy(Type = typeof(XmlSchemaValidator), Member = "ValidateAtomicValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(XmlSchemaSimpleType&)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(XmlSchemaValidator), Member = "CheckXsiTypeAndNil", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SchemaElementDecl), typeof(string), typeof(string), typeof(Boolean&)}, ReturnType = typeof(SchemaElementDecl))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(XmlSchemaException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[]), typeof(Exception), typeof(string), typeof(int), typeof(int), typeof(XmlSchemaObject)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSchemaValidator), Member = "SendValidationEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaValidationException), typeof(XmlSeverityType)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	private void SendValidationEvent(string code, String[] args) { }

	[CalledBy(Type = typeof(XmlSchemaValidator), Member = "AddSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchema)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSchemaValidator), Member = "ProcessSchemaLocations", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSchemaValidator), Member = "ValidateAtomicValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(XmlSchemaSimpleType&)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(XmlSchemaValidator), Member = "CheckXsiTypeAndNil", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SchemaElementDecl), typeof(string), typeof(string), typeof(Boolean&)}, ReturnType = typeof(SchemaElementDecl))]
	[CalledBy(Type = typeof(XmlSchemaValidator), Member = "LoadSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSchemaValidator), Member = "CheckAttributeValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(SchemaAttDef)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(XmlSchemaValidator), Member = "CheckElementValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(object))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(XmlSchemaException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[]), typeof(Exception), typeof(string), typeof(int), typeof(int), typeof(XmlSchemaObject)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSchemaValidator), Member = "SendValidationEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaValidationException), typeof(XmlSeverityType)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	private void SendValidationEvent(string code, String[] args, Exception innerException) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlSchemaValidator), Member = "SendValidationEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaValidationException), typeof(XmlSeverityType)}, ReturnType = typeof(void))]
	private void SendValidationEvent(XmlSchemaValidationException e) { }

	[CallerCount(Count = 25)]
	[Calls(Type = typeof(XmlSchemaValidationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSchemaValidator), Member = "SendValidationEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaValidationException), typeof(XmlSeverityType)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	private void SendValidationEvent(string code, string arg) { }

	[CalledBy(Type = typeof(XmlSchemaValidator), Member = "AddSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchema)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSchemaValidator), Member = "ValidateAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(XmlValueGetter), typeof(string), typeof(XmlSchemaInfo)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(XmlSchemaValidator), Member = "CheckXsiTypeAndNil", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SchemaElementDecl), typeof(string), typeof(string), typeof(Boolean&)}, ReturnType = typeof(SchemaElementDecl))]
	[CalledBy(Type = typeof(XmlSchemaValidator), Member = "ThrowDeclNotFoundWarningOrError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(XmlSchemaValidationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSchemaValidator), Member = "SendValidationEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaValidationException), typeof(XmlSeverityType)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	private void SendValidationEvent(string code, string msg, XmlSeverityType severity) { }

	[CalledBy(Type = typeof(XmlSchemaValidator), Member = "EndValidation", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSchemaValidator), Member = "CheckForwardRefs", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSchemaValidator), Member = "EndElementIdentityConstraints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string), typeof(XmlSchemaDatatype)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSchemaValidator), Member = "SendValidationEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSchemaValidator), Member = "SendValidationEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSchemaValidator), Member = "SendValidationEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[]), typeof(Exception), typeof(XmlSeverityType)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSchemaValidator), Member = "SendValidationEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[]), typeof(Exception)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSchemaValidator), Member = "SendValidationEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaValidationException)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSchemaValidator), Member = "SendValidationEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaException)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSchemaValidator), Member = "SendValidationEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(XmlSeverityType)}, ReturnType = typeof(void))]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(ValidationEventArgs), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaException), typeof(XmlSeverityType)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private void SendValidationEvent(XmlSchemaValidationException e, XmlSeverityType severity) { }

	[CalledBy(Type = typeof(XmlSchemaValidator), Member = "ProcessSchemaLocations", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSchemaValidator), Member = "RecompileSchemaSet", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(XmlSchemaException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[]), typeof(Exception), typeof(string), typeof(int), typeof(int), typeof(XmlSchemaObject)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSchemaValidator), Member = "SendValidationEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaValidationException), typeof(XmlSeverityType)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private void SendValidationEvent(XmlSchemaException e) { }

	[CalledBy(Type = typeof(XsdValidatingReader), Member = "SetupValidator", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlReaderSettings), typeof(XmlReader), typeof(XmlSchemaObject)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void set_LineInfoProvider(IXmlLineInfo value) { }

	[CalledBy(Type = typeof(XsdValidatingReader), Member = "SetupValidator", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlReaderSettings), typeof(XmlReader), typeof(XmlSchemaObject)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public void set_SourceUri(Uri value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public void set_ValidationEventSender(object value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public void set_XmlResolver(XmlResolver value) { }

	[CalledBy(Type = typeof(XsdValidatingReader), Member = "SetupValidator", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlReaderSettings), typeof(XmlReader), typeof(XmlSchemaObject)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XsdValidatingReader), Member = "ProcessReaderEvent", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	internal void SetDtdSchemaInfo(IDtdInfo dtdSchemaInfo) { }

	[CalledBy(Type = typeof(XsdValidatingReader), Member = "Skip", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(XmlSchemaValidator), Member = "CheckStateTransition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ValidatorState), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSchemaInfo), Member = "set_SchemaType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSchemaValidator), Member = "GetSchemaElement", ReturnType = typeof(XmlSchemaElement))]
	[Calls(Type = typeof(XmlSchemaInfo), Member = "set_SchemaElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaElement)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSchemaValidator), Member = "Pop", ReturnType = typeof(void))]
	[Calls(Type = typeof(Res), Member = "GetString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 16)]
	public void SkipToEndElement(XmlSchemaInfo schemaInfo) { }

	[CalledBy(Type = typeof(XmlSchemaValidator), Member = "ValidateElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(XmlSchemaInfo), typeof(string), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SchemaInfo), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(XmlSchemaValidator), Member = "SendValidationEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSchemaValidator), Member = "SendValidationEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(XmlSeverityType)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private void ThrowDeclNotFoundWarningOrError(bool declFound) { }

	[CalledBy(Type = typeof(XmlSchemaValidator), Member = "InternalValidateEndElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaInfo), typeof(object)}, ReturnType = typeof(object))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SchemaDeclBase), Member = "get_DefaultValueRaw", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(XmlSchemaValidator), Member = "SendValidationEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSchemaValidator), Member = "CheckElementValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(XmlSchemaValidator), Member = "CheckTokenizedTypes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaDatatype), typeof(object), typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	private object ValidateAtomicValue(string stringValue, out XmlSchemaSimpleType memberType) { }

	[CalledBy(Type = typeof(XmlSchemaValidator), Member = "InternalValidateEndElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaInfo), typeof(object)}, ReturnType = typeof(object))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SchemaDeclBase), Member = "CheckValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(XmlSchemaValidator), Member = "SendValidationEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSchemaValidator), Member = "CheckTokenizedTypes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaDatatype), typeof(object), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSchemaDatatype), Member = "ConcatenatedToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(XmlSchemaDatatype), Member = "get_TypeCodeString", ReturnType = typeof(string))]
	[Calls(Type = typeof(XmlSchemaValidator), Member = "SendValidationEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[]), typeof(Exception)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 9)]
	private object ValidateAtomicValue(object parsedValue, out XmlSchemaSimpleType memberType) { }

	[CalledBy(Type = typeof(XmlSchemaValidator), Member = "ValidateAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(XmlValueGetter), typeof(XmlSchemaInfo)}, ReturnType = typeof(object))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(XmlSchemaValidator), Member = "CheckAttributeValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(SchemaAttDef)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(XmlSchemaInfo), Member = "set_SchemaType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSchemaInfo), Member = "set_SchemaAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaAttribute)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSchemaValidator), Member = "SendValidationEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSchemaValidator), Member = "SendValidationEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSchemaValidator), Member = "AttributeIdentityConstraints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(object), typeof(string), typeof(XmlSchemaDatatype)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSchemaValidator), Member = "CheckTokenizedTypes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaDatatype), typeof(object), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSchemaValidator), Member = "SendValidationEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(XmlSeverityType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SchemaInfo), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlSchemaValidator), Member = "CheckIsXmlAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName)}, ReturnType = typeof(SchemaAttDef))]
	[Calls(Type = typeof(XmlSchemaComplexType), Member = "ContainsIdAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(SchemaInfo), Member = "GetAttributeXsd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SchemaElementDecl), typeof(XmlQualifiedName), typeof(XmlSchemaObject), typeof(AttributeMatchState&)}, ReturnType = typeof(SchemaAttDef))]
	[Calls(Type = typeof(XmlQualifiedName), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSchemaValidator), Member = "CheckStateTransition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ValidatorState), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSchemaInfo), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 23)]
	[CallsUnknownMethods(Count = 16)]
	[ContainsUnimplementedInstructions]
	private object ValidateAttribute(string lName, string ns, XmlValueGetter attributeValueGetter, string attributeStringValue, XmlSchemaInfo schemaInfo) { }

	[CalledBy(Type = typeof(XsdValidatingReader), Member = "ValidateAttributes", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(XmlSchemaValidator), Member = "ValidateAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(XmlValueGetter), typeof(string), typeof(XmlSchemaInfo)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	public object ValidateAttribute(string localName, string namespaceUri, XmlValueGetter attributeValue, XmlSchemaInfo schemaInfo) { }

	[CalledBy(Type = typeof(XsdValidatingReader), Member = "ProcessElementEvent", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(XmlSchemaValidator), Member = "CheckXsiTypeAndNil", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SchemaElementDecl), typeof(string), typeof(string), typeof(Boolean&)}, ReturnType = typeof(SchemaElementDecl))]
	[Calls(Type = typeof(XmlSchemaInfo), Member = "set_SchemaType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSchemaValidator), Member = "GetSchemaElement", ReturnType = typeof(XmlSchemaElement))]
	[Calls(Type = typeof(XmlSchemaValidator), Member = "ElementIdentityConstraints", ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSchemaValidator), Member = "AddIdentityConstraints", ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSchemaValidator), Member = "SendValidationEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(XmlSchemaValidator), Member = "ThrowDeclNotFoundWarningOrError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SchemaInfo), Member = "GetElementDecl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName)}, ReturnType = typeof(SchemaElementDecl))]
	[Calls(Type = typeof(XmlSchemaValidator), Member = "ProcessSchemaLocations", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSchemaValidator), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSchemaValidator), Member = "FastGetElementDecl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName), typeof(object)}, ReturnType = typeof(SchemaElementDecl))]
	[Calls(Type = typeof(XmlSchemaValidator), Member = "ValidateElementContext", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName), typeof(Boolean&)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(XmlQualifiedName), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StringBuilder), Member = "set_Length", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSchemaValidator), Member = "CheckStateTransition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ValidatorState), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSchemaInfo), Member = "set_SchemaElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaElement)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 12)]
	[ContainsUnimplementedInstructions]
	public void ValidateElement(string localName, string namespaceUri, XmlSchemaInfo schemaInfo, string xsiType, string xsiNil, string xsiSchemaLocation, string xsiNoNamespaceSchemaLocation) { }

	[CalledBy(Type = typeof(XmlSchemaValidator), Member = "ValidateElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(XmlSchemaInfo), typeof(string), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(XmlSchemaValidator), Member = "SendValidationEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSchemaValidator), Member = "GetSubstitutionGroupHead", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName)}, ReturnType = typeof(XmlSchemaElement))]
	[Calls(Type = typeof(XmlQualifiedName), Member = "get_IsEmpty", ReturnType = typeof(bool))]
	[Calls(Type = typeof(SchemaInfo), Member = "GetElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName)}, ReturnType = typeof(XmlSchemaElement))]
	[Calls(Type = typeof(XmlSchemaValidator), Member = "BuildElementName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(XmlSchemaValidator), Member = "SendValidationEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSchemaValidator), Member = "ElementValidationError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName), typeof(ValidationState), typeof(ValidationEventHandler), typeof(object), typeof(string), typeof(int), typeof(int), typeof(XmlSchemaSet)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private object ValidateElementContext(XmlQualifiedName elementName, out bool invalidElementInContext) { }

	[CalledBy(Type = typeof(XsdValidatingReader), Member = "ProcessEndElementEvent", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XsdValidatingReader), Member = "ReadAheadForMemberType", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XsdValidatingReader), Member = "GetIsDefault", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(XmlSchemaValidator), Member = "InternalValidateEndElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaInfo), typeof(object)}, ReturnType = typeof(object))]
	public object ValidateEndElement(XmlSchemaInfo schemaInfo) { }

	[CalledBy(Type = typeof(XsdValidatingReader), Member = "ProcessElementEvent", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(XmlSchemaValidator), Member = "CheckStateTransition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ValidatorState), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSchemaValidator), Member = "CheckRequiredAttributes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SchemaElementDecl)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	public void ValidateEndOfAttributes(XmlSchemaInfo schemaInfo) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlSchemaValidator), Member = "AddIdentityConstraints", ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSchemaValidator), Member = "ElementIdentityConstraints", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private void ValidateStartElementIdentityConstraints() { }

	[CalledBy(Type = typeof(XsdValidatingReader), Member = "ProcessReaderEvent", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XsdValidatingReader), Member = "ReadAheadForMemberType", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XsdValidatingReader), Member = "GetIsDefault", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	[ContainsInvalidInstructions]
	public void ValidateText(XmlValueGetter elementValue) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlSchemaValidator), Member = "CheckStateTransition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ValidatorState), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(XmlCharType), Member = "IsOnlyWhitespace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlSchemaValidator), Member = "BuildElementName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(XmlSchemaValidator), Member = "PrintExpectedElements", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ArrayList), typeof(bool)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(XmlSchemaValidator), Member = "SendValidationEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSchemaValidator), Member = "SendValidationEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 5)]
	private void ValidateText(string elementStringValue, XmlValueGetter elementValueGetter) { }

	[CalledBy(Type = typeof(XsdValidatingReader), Member = "ProcessReaderEvent", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XsdValidatingReader), Member = "ReadAheadForMemberType", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XsdValidatingReader), Member = "GetIsDefault", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(XmlSchemaValidator), Member = "ValidateWhitespace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(XmlValueGetter)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	public void ValidateWhitespace(XmlValueGetter elementValue) { }

	[CalledBy(Type = typeof(XmlSchemaValidator), Member = "ValidateWhitespace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlValueGetter)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(XmlSchemaValidator), Member = "CheckStateTransition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ValidatorState), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(XmlSchemaValidator), Member = "SendValidationEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(StringBuilder))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	private void ValidateWhitespace(string elementStringValue, XmlValueGetter elementValueGetter) { }

}

