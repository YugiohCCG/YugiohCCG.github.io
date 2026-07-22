namespace System.Xml.Schema;

internal sealed class DtdValidator : BaseValidator
{
	private class NamespaceManager : XmlNamespaceManager
	{

		[CallerCount(Count = 162)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public NamespaceManager() { }

		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		public virtual string LookupNamespace(string prefix) { }

	}

	private static NamespaceManager namespaceManager; //Field offset: 0x0
	private HWStack validationStack; //Field offset: 0x80
	private Hashtable attPresence; //Field offset: 0x88
	private XmlQualifiedName name; //Field offset: 0x90
	private Hashtable IDs; //Field offset: 0x98
	private IdRefNode idRefListHead; //Field offset: 0xA0
	private bool processIdentityConstraints; //Field offset: 0xA8

	public virtual bool PreserveWhitespace
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ContentValidator), Member = "get_PreserveWhitespace", ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 59
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private static DtdValidator() { }

	[CalledBy(Type = typeof(BaseValidator), Member = "CreateInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ValidationType), typeof(XmlValidatingReaderImpl), typeof(XmlSchemaCollection), typeof(IValidationEventHandling), typeof(bool)}, ReturnType = typeof(BaseValidator))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BaseValidator), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlValidatingReaderImpl), typeof(XmlSchemaCollection), typeof(IValidationEventHandling)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(HWStack), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(Hashtable), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(SchemaInfo), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(DtdValidator), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 6)]
	internal DtdValidator(XmlValidatingReaderImpl reader, IValidationEventHandling eventHandling, bool processIdentityConstraints) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Hashtable), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	internal void AddID(string name, object node) { }

	[CalledBy(Type = typeof(XmlValidatingReaderImpl), Member = "ValidateDefaultAttributeOnUse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IDtdDefaultAttributeInfo), typeof(XmlTextReaderImpl)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SchemaDeclBase), Member = "CheckEnumeration", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlSchemaException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseValidator), Member = "ProcessEntity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SchemaInfo), typeof(string), typeof(IValidationEventHandling), typeof(string), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSchemaException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 13)]
	public static void CheckDefaultValue(SchemaAttDef attdef, SchemaInfo sinfo, IValidationEventHandling eventHandling, string baseUriStr) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlSchemaException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseValidator), Member = "SendValidationEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaException)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private void CheckForwardRefs() { }

	[CalledBy(Type = typeof(DtdValidator), Member = "ValidateStartElement", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DtdValidator), Member = "ValidateEndElement", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(XmlValidatingReaderImpl), Member = "set_TypedValueObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Trim", ReturnType = typeof(string))]
	[Calls(Type = typeof(DtdValidator), Member = "ProcessTokenizedType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlTokenizedType), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SchemaDeclBase), Member = "CheckEnumeration", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BaseValidator), Member = "SendValidationEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SchemaDeclBase), Member = "CheckValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlSchemaValidator), Member = "QNameString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 11)]
	[CallsUnknownMethods(Count = 19)]
	private void CheckValue(string value, SchemaAttDef attdef) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DtdValidator), Member = "ValidateEndElement", ReturnType = typeof(void))]
	[Calls(Type = typeof(DtdValidator), Member = "Pop", ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlSchemaException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseValidator), Member = "SendValidationEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaException)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public virtual void CompleteValidation() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public virtual object FindId(string name) { }

	[CalledBy(Type = typeof(DtdValidator), Member = "Validate", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(SchemaEntity), Member = "IsPredefinedEntity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(SchemaInfo), Member = "get_GeneralEntities", ReturnType = typeof(System.Collections.Generic.Dictionary`2<System.Xml.XmlQualifiedName, System.Xml.Schema.SchemaEntity>))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlQualifiedName), Member = "get_IsEmpty", ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlValidatingReaderImpl), Member = "get_StandAlone", ReturnType = typeof(bool))]
	[Calls(Type = typeof(BaseValidator), Member = "SendValidationEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 10)]
	private bool GenEntity(XmlQualifiedName qname) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ContentValidator), Member = "get_PreserveWhitespace", ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public virtual bool get_PreserveWhitespace() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SchemaInfo), Member = "get_GeneralEntities", ReturnType = typeof(System.Collections.Generic.Dictionary`2<System.Xml.XmlQualifiedName, System.Xml.Schema.SchemaEntity>))]
	[Calls(Type = typeof(SchemaInfo), Member = "get_ParameterEntities", ReturnType = typeof(System.Collections.Generic.Dictionary`2<System.Xml.XmlQualifiedName, System.Xml.Schema.SchemaEntity>))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object&)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	private SchemaEntity GetEntity(XmlQualifiedName qname, bool fParameterEntity) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(HWStack), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(Hashtable), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(SchemaInfo), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(DtdValidator), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	private void Init() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlValidatingReaderImpl), Member = "get_StandAlone", ReturnType = typeof(bool))]
	[Calls(Type = typeof(BaseValidator), Member = "SendValidationEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private bool MeetsStandAloneConstraint() { }

	[CalledBy(Type = typeof(DtdValidator), Member = "CompleteValidation", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DtdValidator), Member = "ValidateEndElement", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(HWStack), Member = "Pop", ReturnType = typeof(object))]
	[Calls(Type = typeof(HWStack), Member = "Peek", ReturnType = typeof(object))]
	[CallsUnknownMethods(Count = 5)]
	private bool Pop() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SchemaInfo), Member = "GetElementDecl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName)}, ReturnType = typeof(SchemaElementDecl))]
	[Calls(Type = typeof(DtdValidator), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSchemaValidator), Member = "QNameString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(BaseValidator), Member = "SendValidationEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DtdValidator), Member = "ValidateStartElement", ReturnType = typeof(void))]
	[Calls(Type = typeof(DtdValidator), Member = "ValidateEndStartElement", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private void ProcessElement() { }

	[CalledBy(Type = typeof(DtdValidator), Member = "CheckValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(SchemaAttDef)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(BaseValidator), Member = "get_EventHandler", ReturnType = typeof(ValidationEventHandler))]
	[Calls(Type = typeof(BaseValidator), Member = "ProcessEntity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SchemaInfo), typeof(string), typeof(object), typeof(ValidationEventHandler), typeof(string), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(IdRefNode), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IdRefNode), typeof(string), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Hashtable), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseValidator), Member = "SendValidationEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 3)]
	private void ProcessTokenizedType(XmlTokenizedType ttype, string name) { }

	[CalledBy(Type = typeof(DtdValidator), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlValidatingReaderImpl), typeof(IValidationEventHandling), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DtdValidator), Member = "Init", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DtdValidator), Member = "ValidateElement", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DtdValidator), Member = "ProcessElement", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(HWStack), Member = "Push", ReturnType = typeof(object))]
	[Calls(Type = typeof(ValidationState), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(HWStack), Member = "AddToTop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 7)]
	private void Push(XmlQualifiedName elementName) { }

	[CalledBy(Type = typeof(DtdParser), Member = "ParseAttlistDefault", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SchemaAttDef), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "Trim", ReturnType = typeof(string))]
	[Calls(Type = typeof(XmlSchemaException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 19)]
	public static void SetDefaultTypedValue(SchemaAttDef attdef, IDtdParserAdapter readerAdapter) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseValidator), Member = "SendValidationEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(XmlSeverityType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DtdValidator), Member = "ValidateElement", ReturnType = typeof(void))]
	[Calls(Type = typeof(DtdValidator), Member = "ValidateEndElement", ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlQualifiedName), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DtdValidator), Member = "GenEntity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BaseValidator), Member = "ValidateText", ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseValidator), Member = "SendValidationEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlValidatingReaderImpl), Member = "get_StandAlone", ReturnType = typeof(bool))]
	[Calls(Type = typeof(BaseValidator), Member = "ValidateWhitespace", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 2)]
	public virtual void Validate() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseValidator), Member = "get_EventHandler", ReturnType = typeof(ValidationEventHandler))]
	[Calls(Type = typeof(XmlSchemaValidator), Member = "ElementValidationError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName), typeof(ValidationState), typeof(ValidationEventHandler), typeof(object), typeof(string), typeof(int), typeof(int), typeof(XmlSchemaSet)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	private void ValidateChildElement() { }

	[CalledBy(Type = typeof(DtdValidator), Member = "Validate", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(XmlQualifiedName), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlQualifiedName), Member = "get_IsEmpty", ReturnType = typeof(bool))]
	[Calls(Type = typeof(BaseValidator), Member = "SendValidationEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseValidator), Member = "get_EventHandler", ReturnType = typeof(ValidationEventHandler))]
	[Calls(Type = typeof(XmlSchemaValidator), Member = "ElementValidationError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName), typeof(ValidationState), typeof(ValidationEventHandler), typeof(object), typeof(string), typeof(int), typeof(int), typeof(XmlSchemaSet)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SchemaInfo), Member = "GetElementDecl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName)}, ReturnType = typeof(SchemaElementDecl))]
	[Calls(Type = typeof(DtdValidator), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSchemaValidator), Member = "QNameString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(BaseValidator), Member = "SendValidationEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DtdValidator), Member = "ValidateStartElement", ReturnType = typeof(void))]
	[Calls(Type = typeof(DtdValidator), Member = "ValidateEndStartElement", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallsUnknownMethods(Count = 4)]
	private void ValidateElement() { }

	[CalledBy(Type = typeof(DtdValidator), Member = "Validate", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DtdValidator), Member = "CompleteValidation", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(BaseValidator), Member = "get_EventHandler", ReturnType = typeof(ValidationEventHandler))]
	[Calls(Type = typeof(XmlSchemaValidator), Member = "CompleteValidationError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ValidationState), typeof(ValidationEventHandler), typeof(object), typeof(string), typeof(int), typeof(int), typeof(XmlSchemaSet)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DtdValidator), Member = "CheckValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(SchemaAttDef)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StringBuilder), Member = "set_Length", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DtdValidator), Member = "Pop", ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 2)]
	private void ValidateEndElement() { }

	[CalledBy(Type = typeof(DtdValidator), Member = "ValidateElement", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DtdValidator), Member = "ProcessElement", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(XmlValidatingReaderImpl), Member = "get_StandAlone", ReturnType = typeof(bool))]
	[Calls(Type = typeof(SchemaElementDecl), Member = "CheckAttributes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Hashtable), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSchemaException), Member = "SetSource", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseValidator), Member = "SendValidationEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaException)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StringBuilder), Member = "set_Length", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 5)]
	private void ValidateEndStartElement() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseValidator), Member = "SendValidationEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private void ValidatePIComment() { }

	[CalledBy(Type = typeof(DtdValidator), Member = "ValidateElement", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DtdValidator), Member = "ProcessElement", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(XmlValidatingReaderImpl), Member = "set_SchemaTypeObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlValidatingReaderImpl), Member = "set_TypedValueObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlQualifiedName), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SchemaElementDecl), Member = "GetAttDef", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName)}, ReturnType = typeof(SchemaAttDef))]
	[Calls(Type = typeof(BaseValidator), Member = "SendValidationEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DtdValidator), Member = "CheckValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(SchemaAttDef)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSchemaException), Member = "SetSource", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseValidator), Member = "SendValidationEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaException)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 14)]
	[CallsUnknownMethods(Count = 12)]
	private void ValidateStartElement() { }

}

