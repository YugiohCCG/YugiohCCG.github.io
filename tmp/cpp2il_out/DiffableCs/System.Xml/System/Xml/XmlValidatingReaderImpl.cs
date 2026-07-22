namespace System.Xml;

internal sealed class XmlValidatingReaderImpl : XmlReader, IXmlLineInfo, IXmlNamespaceResolver
{
	private enum ParsingFunction
	{
		Read = 0,
		Init = 1,
		ParseDtdFromContext = 2,
		ResolveEntityInternally = 3,
		InReadBinaryContent = 4,
		ReaderClosed = 5,
		Error = 6,
		None = 7,
	}

	public class ValidationEventHandling : IValidationEventHandling
	{
		private XmlValidatingReaderImpl reader; //Field offset: 0x10
		private ValidationEventHandler eventHandler; //Field offset: 0x18

		private override object System.Xml.IValidationEventHandling.EventHandler
		{
			[CallerCount(Count = 31)]
			[DeduplicatedMethod]
			private get { } //Length: 5
		}

		[CallerCount(Count = 98)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		internal ValidationEventHandling(XmlValidatingReaderImpl reader) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[CallsUnknownMethods(Count = 3)]
		internal void AddHandler(ValidationEventHandler handler) { }

		[CallerCount(Count = 31)]
		[DeduplicatedMethod]
		private override object System.Xml.IValidationEventHandling.get_EventHandler() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ValidationEventArgs), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaException), typeof(XmlSeverityType)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 4)]
		private override void System.Xml.IValidationEventHandling.SendEvent(Exception exception, XmlSeverityType severity) { }

	}

	private static XmlResolver s_tempResolver; //Field offset: 0x0
	private XmlReader coreReader; //Field offset: 0x10
	private XmlTextReaderImpl coreReaderImpl; //Field offset: 0x18
	private IXmlNamespaceResolver coreReaderNSResolver; //Field offset: 0x20
	private ValidationType validationType; //Field offset: 0x28
	private BaseValidator validator; //Field offset: 0x30
	private XmlSchemaCollection schemaCollection; //Field offset: 0x38
	private bool processIdentityConstraints; //Field offset: 0x40
	private ParsingFunction parsingFunction; //Field offset: 0x44
	private ValidationEventHandling eventHandling; //Field offset: 0x48
	private XmlParserContext parserContext; //Field offset: 0x50
	private ReadContentAsBinaryHelper readBinaryHelper; //Field offset: 0x58
	private XmlReader outerReader; //Field offset: 0x60

	public virtual int AttributeCount
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 39
	}

	public virtual string BaseURI
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 39
	}

	public virtual bool CanResolveEntity
	{
		[CallerCount(Count = 23)]
		[DeduplicatedMethod]
		 get { } //Length: 3
	}

	public virtual int Depth
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 39
	}

	internal virtual IDtdInfo DtdInfo
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		internal get { } //Length: 39
	}

	public virtual bool EOF
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 39
	}

	public virtual bool IsDefault
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 39
	}

	public virtual bool IsEmptyElement
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 39
	}

	public override int LineNumber
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 6)]
		 get { } //Length: 153
	}

	public override int LinePosition
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 6)]
		 get { } //Length: 153
	}

	public virtual string LocalName
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 39
	}

	public virtual string Name
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 39
	}

	internal virtual XmlNamespaceManager NamespaceManager
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		internal get { } //Length: 39
	}

	internal bool Namespaces
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		internal get { } //Length: 30
	}

	public virtual string NamespaceURI
	{
		[CallerCount(Count = 12)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 39
	}

	public virtual XmlNameTable NameTable
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 39
	}

	public virtual XmlNodeType NodeType
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 39
	}

	public virtual string Prefix
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 39
	}

	public virtual char QuoteChar
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 39
	}

	public virtual ReadState ReadState
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 52
	}

	internal XmlSchemaCollection Schemas
	{
		[CallerCount(Count = 38)]
		[DeduplicatedMethod]
		internal get { } //Length: 5
	}

	internal object SchemaTypeObject
	{
		[CalledBy(Type = typeof(AutoValidator), Member = "DetectValidationType", ReturnType = typeof(ValidationType))]
		[CalledBy(Type = typeof(DtdValidator), Member = "ValidateStartElement", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XdrValidator), Member = "ThoroughGetElementDecl", ReturnType = typeof(SchemaElementDecl))]
		[CalledBy(Type = typeof(XdrValidator), Member = "ValidateStartElement", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XsdValidator), Member = "ValidateStartElement", ReturnType = typeof(void))]
		[CallerCount(Count = 11)]
		[Calls(Type = typeof(XmlTextReaderImpl), Member = "set_InternalSchemaType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		internal set { } //Length: 30
	}

	public virtual XmlReaderSettings Settings
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(XmlReaderSettings), Member = "Clone", ReturnType = typeof(XmlReaderSettings))]
		[Calls(Type = typeof(XmlReaderSettings), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(XmlReaderSettings), Member = "set_ValidationType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ValidationType)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(XmlReaderSettings), Member = "set_ValidationFlags", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaValidationFlags)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 201
	}

	internal bool StandAlone
	{
		[CalledBy(Type = typeof(DtdValidator), Member = "Validate", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DtdValidator), Member = "MeetsStandAloneConstraint", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(DtdValidator), Member = "ValidateEndStartElement", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DtdValidator), Member = "GenEntity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(XdrValidator), Member = "ValidateEndStartElement", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XsdValidator), Member = "ValidateEndStartElement", ReturnType = typeof(void))]
		[CallerCount(Count = 6)]
		[CallsUnknownMethods(Count = 1)]
		internal get { } //Length: 30
	}

	internal object TypedValueObject
	{
		[CalledBy(Type = typeof(XsdValidator), Member = "ValidateStartElement", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XsdValidator), Member = "EndElementIdentityConstraints", ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(XmlTextReaderImpl), Member = "get_InternalTypedValue", ReturnType = typeof(object))]
		[CallsUnknownMethods(Count = 1)]
		internal get { } //Length: 29
		[CalledBy(Type = typeof(DtdValidator), Member = "ValidateStartElement", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DtdValidator), Member = "CheckValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(SchemaAttDef)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XdrValidator), Member = "ValidateStartElement", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XdrValidator), Member = "CheckValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(SchemaAttDef)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XsdValidator), Member = "ValidateStartElement", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XsdValidator), Member = "CheckValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(SchemaAttDef)}, ReturnType = typeof(void))]
		[CallerCount(Count = 10)]
		[Calls(Type = typeof(XmlTextReaderImpl), Member = "set_InternalTypedValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		internal set { } //Length: 30
	}

	internal ValidationType ValidationType
	{
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		internal get { } //Length: 4
	}

	internal BaseValidator Validator
	{
		[CallerCount(Count = 62)]
		[DeduplicatedMethod]
		internal get { } //Length: 5
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		internal set { } //Length: 13
	}

	public virtual string Value
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 39
	}

	public virtual string XmlLang
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 39
	}

	public virtual XmlSpace XmlSpace
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 39
	}

	[CalledBy(Type = typeof(XmlReaderSettings), Member = "AddValidation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlReader)}, ReturnType = typeof(XmlReader))]
	[CalledBy(Type = typeof(XmlReaderSettings), Member = "CreateDtdValidatingReader", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlReader)}, ReturnType = typeof(XmlValidatingReaderImpl))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "set_XmlValidatingReaderCompatibilityMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSchemaCollection), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNameTable)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlValidatingReaderImpl), Member = "GetResolver", ReturnType = typeof(XmlResolver))]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(XmlValidatingReaderImpl), Member = "SetupValidation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ValidationType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 27)]
	internal XmlValidatingReaderImpl(XmlReader reader, ValidationEventHandler settingsEventHandler, bool processIdentityConstraints) { }

	[CalledBy(Type = typeof(XdrValidator), Member = "ValidateEndStartElement", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XsdValidator), Member = "ValidateEndStartElement", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "AddDefaultAttributeNonDtd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SchemaAttDef)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	internal bool AddDefaultAttribute(SchemaAttDef attdef) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public virtual void Close() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public virtual int get_AttributeCount() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public virtual string get_BaseURI() { }

	[CallerCount(Count = 23)]
	[DeduplicatedMethod]
	public virtual bool get_CanResolveEntity() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public virtual int get_Depth() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	internal virtual IDtdInfo get_DtdInfo() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public virtual bool get_EOF() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public virtual bool get_IsDefault() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public virtual bool get_IsEmptyElement() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 6)]
	public override int get_LineNumber() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 6)]
	public override int get_LinePosition() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public virtual string get_LocalName() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public virtual string get_Name() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	internal virtual XmlNamespaceManager get_NamespaceManager() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	internal bool get_Namespaces() { }

	[CallerCount(Count = 12)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public virtual string get_NamespaceURI() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public virtual XmlNameTable get_NameTable() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public virtual XmlNodeType get_NodeType() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public virtual string get_Prefix() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public virtual char get_QuoteChar() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public virtual ReadState get_ReadState() { }

	[CallerCount(Count = 38)]
	[DeduplicatedMethod]
	internal XmlSchemaCollection get_Schemas() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlReaderSettings), Member = "Clone", ReturnType = typeof(XmlReaderSettings))]
	[Calls(Type = typeof(XmlReaderSettings), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlReaderSettings), Member = "set_ValidationType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ValidationType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlReaderSettings), Member = "set_ValidationFlags", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaValidationFlags)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public virtual XmlReaderSettings get_Settings() { }

	[CalledBy(Type = typeof(DtdValidator), Member = "Validate", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DtdValidator), Member = "MeetsStandAloneConstraint", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DtdValidator), Member = "ValidateEndStartElement", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DtdValidator), Member = "GenEntity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XdrValidator), Member = "ValidateEndStartElement", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XsdValidator), Member = "ValidateEndStartElement", ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[CallsUnknownMethods(Count = 1)]
	internal bool get_StandAlone() { }

	[CalledBy(Type = typeof(XsdValidator), Member = "ValidateStartElement", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XsdValidator), Member = "EndElementIdentityConstraints", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "get_InternalTypedValue", ReturnType = typeof(object))]
	[CallsUnknownMethods(Count = 1)]
	internal object get_TypedValueObject() { }

	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	internal ValidationType get_ValidationType() { }

	[CallerCount(Count = 62)]
	[DeduplicatedMethod]
	internal BaseValidator get_Validator() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public virtual string get_Value() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public virtual string get_XmlLang() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public virtual XmlSpace get_XmlSpace() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public virtual string GetAttribute(string localName, string namespaceURI) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public virtual string GetAttribute(string name) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public virtual string GetAttribute(int i) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	internal IDictionary<String, String> GetNamespacesInScope(XmlNamespaceScope scope) { }

	[CalledBy(Type = typeof(XmlValidatingReaderImpl), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlReader), typeof(ValidationEventHandler), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlValidatingReaderImpl), Member = "SetupValidation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ValidationType)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "GetResolver", ReturnType = typeof(XmlResolver))]
	[Calls(Type = typeof(XmlReaderSettings), Member = "EnableLegacyXmlSettings", ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private XmlResolver GetResolver() { }

	[CallerCount(Count = 23)]
	[DeduplicatedMethod]
	public override bool HasLineInfo() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public virtual string LookupNamespace(string prefix) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	internal string LookupPrefix(string namespaceName) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 5)]
	internal void MoveOffEntityReference() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public virtual void MoveToAttribute(int i) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public virtual bool MoveToAttribute(string name) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public virtual bool MoveToElement() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public virtual bool MoveToFirstAttribute() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public virtual bool MoveToNextAttribute() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DtdParser), Member = "Create", ReturnType = typeof(IDtdParser))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "SetDtdInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IDtdInfo)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlValidatingReaderImpl), Member = "ValidateDtd", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	private void ParseDtdFromParserContext() { }

	[CalledBy(Type = typeof(XmlValidatingReaderImpl), Member = "Read", ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(XmlValidatingReaderImpl), Member = "ValidateDtd", ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "ChangeCurrentNodeType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNodeType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "set_InternalSchemaType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "set_InternalTypedValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	private void ProcessCoreReaderEvent() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlValidatingReaderImpl), Member = "ProcessCoreReaderEvent", ReturnType = typeof(void))]
	[Calls(Type = typeof(DtdParser), Member = "Create", ReturnType = typeof(IDtdParser))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "SetDtdInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IDtdInfo)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlValidatingReaderImpl), Member = "ValidateDtd", ReturnType = typeof(void))]
	[Calls(Type = typeof(ReadContentAsBinaryHelper), Member = "Finish", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallsUnknownMethods(Count = 3)]
	public virtual bool Read() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ReadContentAsBinaryHelper), Member = "Finish", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public virtual bool ReadAttributeValue() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlReader), Member = "ReadString", ReturnType = typeof(string))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 5)]
	public virtual string ReadString() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public virtual void ResolveEntity() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	private void ResolveEntityInternally() { }

	[CalledBy(Type = typeof(AutoValidator), Member = "DetectValidationType", ReturnType = typeof(ValidationType))]
	[CalledBy(Type = typeof(DtdValidator), Member = "ValidateStartElement", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XdrValidator), Member = "ThoroughGetElementDecl", ReturnType = typeof(SchemaElementDecl))]
	[CalledBy(Type = typeof(XdrValidator), Member = "ValidateStartElement", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XsdValidator), Member = "ValidateStartElement", ReturnType = typeof(void))]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "set_InternalSchemaType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	internal void set_SchemaTypeObject(object value) { }

	[CalledBy(Type = typeof(DtdValidator), Member = "ValidateStartElement", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DtdValidator), Member = "CheckValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(SchemaAttDef)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XdrValidator), Member = "ValidateStartElement", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XdrValidator), Member = "CheckValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(SchemaAttDef)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XsdValidator), Member = "ValidateStartElement", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XsdValidator), Member = "CheckValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(SchemaAttDef)}, ReturnType = typeof(void))]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "set_InternalTypedValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	internal void set_TypedValueObject(object value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	internal void set_Validator(BaseValidator value) { }

	[CalledBy(Type = typeof(XmlValidatingReaderImpl), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlReader), typeof(ValidationEventHandler), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlValidatingReaderImpl), Member = "ValidateDtd", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(BaseValidator), Member = "CreateInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ValidationType), typeof(XmlValidatingReaderImpl), typeof(XmlSchemaCollection), typeof(IValidationEventHandling), typeof(bool)}, ReturnType = typeof(BaseValidator))]
	[Calls(Type = typeof(XmlValidatingReaderImpl), Member = "GetResolver", ReturnType = typeof(XmlResolver))]
	[Calls(Type = typeof(Uri), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(UriKind)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 5)]
	private void SetupValidation(ValidationType valType) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	private override IDictionary<String, String> System.Xml.IXmlNamespaceResolver.GetNamespacesInScope(XmlNamespaceScope scope) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	private override string System.Xml.IXmlNamespaceResolver.LookupNamespace(string prefix) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	private override string System.Xml.IXmlNamespaceResolver.LookupPrefix(string namespaceName) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DtdValidator), Member = "CheckDefaultValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SchemaAttDef), typeof(SchemaInfo), typeof(IValidationEventHandling), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	internal void ValidateDefaultAttributeOnUse(IDtdDefaultAttributeInfo defaultAttribute, XmlTextReaderImpl coreReader) { }

	[CalledBy(Type = typeof(XmlValidatingReaderImpl), Member = "Read", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XmlValidatingReaderImpl), Member = "ParseDtdFromParserContext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlValidatingReaderImpl), Member = "ProcessCoreReaderEvent", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(XmlValidatingReaderImpl), Member = "SetupValidation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ValidationType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseValidator), Member = "set_DtdInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IDtdInfo)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void ValidateDtd() { }

}

