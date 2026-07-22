namespace System.Xml.Schema;

internal class BaseValidator
{
	private XmlSchemaCollection schemaCollection; //Field offset: 0x10
	private IValidationEventHandling eventHandling; //Field offset: 0x18
	private XmlNameTable nameTable; //Field offset: 0x20
	private SchemaNames schemaNames; //Field offset: 0x28
	private PositionInfo positionInfo; //Field offset: 0x30
	private XmlResolver xmlResolver; //Field offset: 0x38
	private Uri baseUri; //Field offset: 0x40
	protected SchemaInfo schemaInfo; //Field offset: 0x48
	protected XmlValidatingReaderImpl reader; //Field offset: 0x50
	protected XmlQualifiedName elementName; //Field offset: 0x58
	protected ValidationState context; //Field offset: 0x60
	protected StringBuilder textValue; //Field offset: 0x68
	protected string textString; //Field offset: 0x70
	protected bool hasSibling; //Field offset: 0x78
	protected bool checkDatatype; //Field offset: 0x79

	public Uri BaseUri
	{
		[CallerCount(Count = 12)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 set { } //Length: 13
	}

	public IDtdInfo DtdInfo
	{
		[CalledBy(Type = typeof(XmlValidatingReaderImpl), Member = "ValidateDtd", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(XmlException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 5)]
		 set { } //Length: 208
	}

	public ValidationEventHandler EventHandler
	{
		[CalledBy(Type = typeof(DtdValidator), Member = "ValidateElement", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XsdValidator), Member = "ProcessTokenizedType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlTokenizedType), typeof(string)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XsdValidator), Member = "LoadSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XsdValidator), Member = "LoadSchemaFromLocation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XsdValidator), Member = "ValidateEndElement", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XsdValidator), Member = "ValidateChildElement", ReturnType = typeof(object))]
		[CalledBy(Type = typeof(XsdValidator), Member = "ValidateElement", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XsdValidator), Member = "ProcessInlineSchema", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XsdValidator), Member = "Validate", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XdrValidator), Member = "ProcessTokenizedType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlTokenizedType), typeof(string)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XdrValidator), Member = "LoadSchemaFromLocation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XdrValidator), Member = "ValidateEndElement", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XdrValidator), Member = "ProcessInlineSchema", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XdrValidator), Member = "ValidateChildElement", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XdrValidator), Member = "ValidateElement", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DtdValidator), Member = "ProcessTokenizedType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlTokenizedType), typeof(string)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DtdValidator), Member = "ValidateEndElement", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DtdValidator), Member = "ValidateChildElement", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XdrValidator), Member = "LoadSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallerCount(Count = 23)]
		[CallsUnknownMethods(Count = 3)]
		 get { } //Length: 120
	}

	public XmlNameTable NameTable
	{
		[CallerCount(Count = 12)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public PositionInfo PositionInfo
	{
		[CallerCount(Count = 62)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public override bool PreserveWhitespace
	{
		[CallerCount(Count = 271)]
		[DeduplicatedMethod]
		 get { } //Length: 3
	}

	public XmlValidatingReaderImpl Reader
	{
		[CallerCount(Count = 16)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public XmlSchemaCollection SchemaCollection
	{
		[CallerCount(Count = 106)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public SchemaInfo SchemaInfo
	{
		[CallerCount(Count = 10)]
		[DeduplicatedMethod]
		 get { } //Length: 254
	}

	public SchemaNames SchemaNames
	{
		[CalledBy(Type = typeof(AutoValidator), Member = "DetectValidationType", ReturnType = typeof(ValidationType))]
		[CalledBy(Type = typeof(XdrValidator), Member = "ValidateElement", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XdrValidator), Member = "ThoroughGetElementDecl", ReturnType = typeof(SchemaElementDecl))]
		[CalledBy(Type = typeof(XdrValidator), Member = "ValidateStartElement", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XdrValidator), Member = "LoadSchemaFromLocation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XdrValidator), Member = "QualifiedName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(XmlQualifiedName))]
		[CalledBy(Type = typeof(XsdValidator), Member = "Validate", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XsdValidator), Member = "ValidateElement", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XsdValidator), Member = "LoadSchemaFromLocation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
		[CallerCount(Count = 18)]
		[Calls(Type = typeof(SchemaNames), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNameTable)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(XmlSchemaCollection), Member = "GetSchemaNames", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNameTable)}, ReturnType = typeof(SchemaNames))]
		[CallsUnknownMethods(Count = 2)]
		 get { } //Length: 173
	}

	public XmlResolver XmlResolver
	{
		[CallerCount(Count = 38)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 3)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 set { } //Length: 13
	}

	[CalledBy(Type = typeof(XdrValidator), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseValidator)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XsdValidator), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseValidator)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 10)]
	public BaseValidator(BaseValidator other) { }

	[CalledBy(Type = typeof(AutoValidator), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlValidatingReaderImpl), typeof(XmlSchemaCollection), typeof(IValidationEventHandling)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BaseValidator), Member = "CreateInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ValidationType), typeof(XmlValidatingReaderImpl), typeof(XmlSchemaCollection), typeof(IValidationEventHandling), typeof(bool)}, ReturnType = typeof(BaseValidator))]
	[CalledBy(Type = typeof(DtdValidator), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlValidatingReaderImpl), typeof(IValidationEventHandling), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XdrValidator), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlValidatingReaderImpl), typeof(XmlSchemaCollection), typeof(IValidationEventHandling)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XsdValidator), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlValidatingReaderImpl), typeof(XmlSchemaCollection), typeof(IValidationEventHandling)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(PositionInfo), Member = "GetPositionInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(PositionInfo))]
	[Calls(Type = typeof(XmlQualifiedName), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 7)]
	public BaseValidator(XmlValidatingReaderImpl reader, XmlSchemaCollection schemaCollection, IValidationEventHandling eventHandling) { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	public override void CompleteValidation() { }

	[CalledBy(Type = typeof(XmlValidatingReaderImpl), Member = "SetupValidation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ValidationType)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(XsdValidator), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlValidatingReaderImpl), typeof(XmlSchemaCollection), typeof(IValidationEventHandling)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XdrValidator), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlValidatingReaderImpl), typeof(XmlSchemaCollection), typeof(IValidationEventHandling)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DtdValidator), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlValidatingReaderImpl), typeof(IValidationEventHandling), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseValidator), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlValidatingReaderImpl), typeof(XmlSchemaCollection), typeof(IValidationEventHandling)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SchemaInfo), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public static BaseValidator CreateInstance(ValidationType valType, XmlValidatingReaderImpl reader, XmlSchemaCollection schemaCollection, IValidationEventHandling eventHandling, bool processIdentityConstraints) { }

	[CallerCount(Count = 182)]
	[DeduplicatedMethod]
	public override object FindId(string name) { }

	[CallerCount(Count = 12)]
	[DeduplicatedMethod]
	public Uri get_BaseUri() { }

	[CalledBy(Type = typeof(DtdValidator), Member = "ValidateElement", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XdrValidator), Member = "LoadSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DtdValidator), Member = "ValidateChildElement", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DtdValidator), Member = "ValidateEndElement", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DtdValidator), Member = "ProcessTokenizedType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlTokenizedType), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XdrValidator), Member = "ValidateElement", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XdrValidator), Member = "ValidateChildElement", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XdrValidator), Member = "ProcessInlineSchema", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XdrValidator), Member = "ValidateEndElement", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XdrValidator), Member = "LoadSchemaFromLocation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XsdValidator), Member = "Validate", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XsdValidator), Member = "ProcessInlineSchema", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XsdValidator), Member = "ValidateElement", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XsdValidator), Member = "ValidateChildElement", ReturnType = typeof(object))]
	[CalledBy(Type = typeof(XsdValidator), Member = "ValidateEndElement", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XsdValidator), Member = "LoadSchemaFromLocation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XsdValidator), Member = "LoadSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XsdValidator), Member = "ProcessTokenizedType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlTokenizedType), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XdrValidator), Member = "ProcessTokenizedType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlTokenizedType), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 23)]
	[CallsUnknownMethods(Count = 3)]
	public ValidationEventHandler get_EventHandler() { }

	[CallerCount(Count = 12)]
	[DeduplicatedMethod]
	public XmlNameTable get_NameTable() { }

	[CallerCount(Count = 62)]
	[DeduplicatedMethod]
	public PositionInfo get_PositionInfo() { }

	[CallerCount(Count = 271)]
	[DeduplicatedMethod]
	public override bool get_PreserveWhitespace() { }

	[CallerCount(Count = 16)]
	[DeduplicatedMethod]
	public XmlValidatingReaderImpl get_Reader() { }

	[CallerCount(Count = 106)]
	[DeduplicatedMethod]
	public XmlSchemaCollection get_SchemaCollection() { }

	[CallerCount(Count = 10)]
	[DeduplicatedMethod]
	public SchemaInfo get_SchemaInfo() { }

	[CalledBy(Type = typeof(AutoValidator), Member = "DetectValidationType", ReturnType = typeof(ValidationType))]
	[CalledBy(Type = typeof(XdrValidator), Member = "ValidateElement", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XdrValidator), Member = "ThoroughGetElementDecl", ReturnType = typeof(SchemaElementDecl))]
	[CalledBy(Type = typeof(XdrValidator), Member = "ValidateStartElement", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XdrValidator), Member = "LoadSchemaFromLocation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XdrValidator), Member = "QualifiedName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(XmlQualifiedName))]
	[CalledBy(Type = typeof(XsdValidator), Member = "Validate", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XsdValidator), Member = "ValidateElement", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XsdValidator), Member = "LoadSchemaFromLocation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 18)]
	[Calls(Type = typeof(SchemaNames), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNameTable)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSchemaCollection), Member = "GetSchemaNames", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNameTable)}, ReturnType = typeof(SchemaNames))]
	[CallsUnknownMethods(Count = 2)]
	public SchemaNames get_SchemaNames() { }

	[CallerCount(Count = 38)]
	[DeduplicatedMethod]
	public XmlResolver get_XmlResolver() { }

	[CalledBy(Type = typeof(DtdValidator), Member = "CheckDefaultValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SchemaAttDef), typeof(SchemaInfo), typeof(IValidationEventHandling), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(SchemaInfo), Member = "get_GeneralEntities", ReturnType = typeof(System.Collections.Generic.Dictionary`2<System.Xml.XmlQualifiedName, System.Xml.Schema.SchemaEntity>))]
	[Calls(Type = typeof(XmlQualifiedName), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlQualifiedName), Member = "get_IsEmpty", ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlSchemaException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	protected static void ProcessEntity(SchemaInfo sinfo, string name, IValidationEventHandling eventHandling, string baseUriStr, int lineNumber, int linePosition) { }

	[CalledBy(Type = typeof(DtdValidator), Member = "ProcessTokenizedType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlTokenizedType), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XdrValidator), Member = "ProcessTokenizedType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlTokenizedType), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XdrValidator), Member = "CheckDefaultValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(SchemaAttDef), typeof(SchemaInfo), typeof(XmlNamespaceManager), typeof(XmlNameTable), typeof(object), typeof(ValidationEventHandler), typeof(string), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XsdValidator), Member = "ProcessTokenizedType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlTokenizedType), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(SchemaInfo), Member = "get_GeneralEntities", ReturnType = typeof(System.Collections.Generic.Dictionary`2<System.Xml.XmlQualifiedName, System.Xml.Schema.SchemaEntity>))]
	[Calls(Type = typeof(XmlQualifiedName), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlQualifiedName), Member = "get_IsEmpty", ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlSchemaException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ValidationEventArgs), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaException)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	protected static void ProcessEntity(SchemaInfo sinfo, string name, object sender, ValidationEventHandler eventhandler, string baseUri, int lineNumber, int linePosition) { }

	[CalledBy(Type = typeof(BaseValidator), Member = "ValidateText", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BaseValidator), Member = "ValidateWhitespace", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(StringBuilder))]
	[CallsUnknownMethods(Count = 2)]
	private void SaveTextValue(string value) { }

	[CalledBy(Type = typeof(DtdValidator), Member = "Validate", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XsdValidator), Member = "ProcessElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XsdValidator), Member = "ValidateStartElement", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(XmlSchemaException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseValidator), Member = "SendValidationEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaException), typeof(XmlSeverityType)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	protected void SendValidationEvent(string code, string msg, XmlSeverityType severity) { }

	[CalledBy(Type = typeof(BaseValidator), Member = "ValidateText", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XsdValidator), Member = "EndElementIdentityConstraints", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XsdValidator), Member = "CheckForwardRefs", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XsdValidator), Member = "ValidateEndStartElement", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XsdValidator), Member = "ValidateStartElement", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XsdValidator), Member = "CompleteValidation", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XdrValidator), Member = "CheckForwardRefs", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XdrValidator), Member = "CompleteValidation", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XdrValidator), Member = "ValidateEndStartElement", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XdrValidator), Member = "ValidateStartElement", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DtdValidator), Member = "CheckForwardRefs", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DtdValidator), Member = "CompleteValidation", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DtdValidator), Member = "ValidateEndStartElement", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DtdValidator), Member = "ValidateStartElement", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BaseValidator), Member = "SendValidationEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BaseValidator), Member = "SendValidationEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[])}, ReturnType = typeof(void))]
	[CallerCount(Count = 17)]
	[CallsUnknownMethods(Count = 4)]
	protected void SendValidationEvent(XmlSchemaException e) { }

	[CallerCount(Count = 33)]
	[Calls(Type = typeof(XmlSchemaException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseValidator), Member = "SendValidationEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaException)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	protected void SendValidationEvent(string code, string arg) { }

	[CalledBy(Type = typeof(XsdValidator), Member = "ProcessElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XsdValidator), Member = "ThoroughGetElementDecl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SchemaElementDecl), typeof(XmlQualifiedName), typeof(string)}, ReturnType = typeof(SchemaElementDecl))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(BaseValidator), Member = "SendValidationEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaException)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	protected void SendValidationEvent(string code, String[] args) { }

	[CalledBy(Type = typeof(BaseValidator), Member = "SendValidationEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(XmlSeverityType)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BaseValidator), Member = "SendValidationEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[]), typeof(XmlSeverityType)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XdrValidator), Member = "CompleteValidation", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	protected void SendValidationEvent(XmlSchemaException e, XmlSeverityType severity) { }

	[CalledBy(Type = typeof(XdrValidator), Member = "LoadSchemaFromLocation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XsdValidator), Member = "ProcessInlineSchema", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XsdValidator), Member = "LoadSchemaFromLocation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(BaseValidator), Member = "SendValidationEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaException), typeof(XmlSeverityType)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	protected void SendValidationEvent(string code, String[] args, XmlSeverityType severity) { }

	[CalledBy(Type = typeof(DtdValidator), Member = "Validate", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DtdValidator), Member = "MeetsStandAloneConstraint", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DtdValidator), Member = "ValidatePIComment", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DtdValidator), Member = "ValidateElement", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DtdValidator), Member = "GenEntity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XsdValidator), Member = "ProcessElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XsdValidator), Member = "ThoroughGetElementDecl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SchemaElementDecl), typeof(XmlQualifiedName), typeof(string)}, ReturnType = typeof(SchemaElementDecl))]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(BaseValidator), Member = "SendValidationEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	protected void SendValidationEvent(string code) { }

	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public void set_BaseUri(Uri value) { }

	[CalledBy(Type = typeof(XmlValidatingReaderImpl), Member = "ValidateDtd", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(XmlException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	public void set_DtdInfo(IDtdInfo value) { }

	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public void set_XmlResolver(XmlResolver value) { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	public override void Validate() { }

	[CalledBy(Type = typeof(DtdValidator), Member = "Validate", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XdrValidator), Member = "Validate", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XsdValidator), Member = "Validate", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(XmlSchemaValidator), Member = "BuildElementName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(XmlSchemaValidator), Member = "PrintExpectedElements", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ArrayList), typeof(bool)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(BaseValidator), Member = "SendValidationEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaException)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseValidator), Member = "SendValidationEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseValidator), Member = "SaveTextValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSchemaValidator), Member = "QNameString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 4)]
	public void ValidateText() { }

	[CalledBy(Type = typeof(DtdValidator), Member = "Validate", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XdrValidator), Member = "Validate", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XsdValidator), Member = "Validate", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(XmlSchemaValidator), Member = "QNameString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(BaseValidator), Member = "SendValidationEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseValidator), Member = "SaveTextValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void ValidateWhitespace() { }

}

