namespace System.Xml.Schema;

internal sealed class XsdBuilder : SchemaBuilder
{
	private class BuilderNamespaceManager : XmlNamespaceManager
	{
		private XmlNamespaceManager nsMgr; //Field offset: 0x50
		private XmlReader reader; //Field offset: 0x58

		[CalledBy(Type = typeof(XsdBuilder), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlReader), typeof(XmlNamespaceManager), typeof(XmlSchema), typeof(XmlNameTable), typeof(SchemaNames), typeof(ValidationEventHandler)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		public BuilderNamespaceManager(XmlNamespaceManager nsMgr, XmlReader reader) { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		public virtual string LookupNamespace(string prefix) { }

	}

	private enum State
	{
		Root = 0,
		Schema = 1,
		Annotation = 2,
		Include = 3,
		Import = 4,
		Element = 5,
		Attribute = 6,
		AttributeGroup = 7,
		AttributeGroupRef = 8,
		AnyAttribute = 9,
		Group = 10,
		GroupRef = 11,
		All = 12,
		Choice = 13,
		Sequence = 14,
		Any = 15,
		Notation = 16,
		SimpleType = 17,
		ComplexType = 18,
		ComplexContent = 19,
		ComplexContentRestriction = 20,
		ComplexContentExtension = 21,
		SimpleContent = 22,
		SimpleContentExtension = 23,
		SimpleContentRestriction = 24,
		SimpleTypeUnion = 25,
		SimpleTypeList = 26,
		SimpleTypeRestriction = 27,
		Unique = 28,
		Key = 29,
		KeyRef = 30,
		Selector = 31,
		Field = 32,
		MinExclusive = 33,
		MinInclusive = 34,
		MaxExclusive = 35,
		MaxInclusive = 36,
		TotalDigits = 37,
		FractionDigits = 38,
		Length = 39,
		MinLength = 40,
		MaxLength = 41,
		Enumeration = 42,
		Pattern = 43,
		WhiteSpace = 44,
		AppInfo = 45,
		Documentation = 46,
		Redefine = 47,
	}

	private sealed class XsdAttributeEntry
	{
		public Token Attribute; //Field offset: 0x10
		public XsdBuildFunction BuildFunc; //Field offset: 0x18

		[CallerCount(Count = 157)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		public XsdAttributeEntry(Token a, XsdBuildFunction build) { }

	}

	private sealed class XsdBuildFunction : MulticastDelegate
	{

		[CallerCount(Count = 148)]
		[CallsUnknownMethods(Count = 4)]
		[DeduplicatedMethod]
		public XsdBuildFunction(object object, IntPtr method) { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public override void Invoke(XsdBuilder builder, string value) { }

	}

	private sealed class XsdEndChildFunction : MulticastDelegate
	{

		[CallerCount(Count = 10)]
		[CallsUnknownMethods(Count = 4)]
		[DeduplicatedMethod]
		public XsdEndChildFunction(object object, IntPtr method) { }

		[CallerCount(Count = 3)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public override void Invoke(XsdBuilder builder) { }

	}

	private sealed class XsdEntry
	{
		public Token Name; //Field offset: 0x10
		public State CurrentState; //Field offset: 0x14
		public State[] NextStates; //Field offset: 0x18
		public XsdAttributeEntry[] Attributes; //Field offset: 0x20
		public XsdInitFunction InitFunc; //Field offset: 0x28
		public XsdEndChildFunction EndChildFunc; //Field offset: 0x30
		public bool ParseContent; //Field offset: 0x38

		[CalledBy(Type = typeof(XsdBuilder), Member = ".cctor", ReturnType = typeof(void))]
		[CallerCount(Count = 48)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 4)]
		public XsdEntry(Token n, State state, State[] nextStates, XsdAttributeEntry[] attributes, XsdInitFunction init, XsdEndChildFunction end, bool parseContent) { }

	}

	private sealed class XsdInitFunction : MulticastDelegate
	{

		[CallerCount(Count = 148)]
		[CallsUnknownMethods(Count = 4)]
		[DeduplicatedMethod]
		public XsdInitFunction(object object, IntPtr method) { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public override void Invoke(XsdBuilder builder, string value) { }

	}

	private static readonly State[] SchemaElement; //Field offset: 0x0
	private static readonly State[] SchemaSubelements; //Field offset: 0x8
	private static readonly State[] AttributeSubelements; //Field offset: 0x10
	private static readonly State[] ElementSubelements; //Field offset: 0x18
	private static readonly State[] ComplexTypeSubelements; //Field offset: 0x20
	private static readonly State[] SimpleContentSubelements; //Field offset: 0x28
	private static readonly State[] SimpleContentExtensionSubelements; //Field offset: 0x30
	private static readonly State[] SimpleContentRestrictionSubelements; //Field offset: 0x38
	private static readonly State[] ComplexContentSubelements; //Field offset: 0x40
	private static readonly State[] ComplexContentExtensionSubelements; //Field offset: 0x48
	private static readonly State[] ComplexContentRestrictionSubelements; //Field offset: 0x50
	private static readonly State[] SimpleTypeSubelements; //Field offset: 0x58
	private static readonly State[] SimpleTypeRestrictionSubelements; //Field offset: 0x60
	private static readonly State[] SimpleTypeListSubelements; //Field offset: 0x68
	private static readonly State[] SimpleTypeUnionSubelements; //Field offset: 0x70
	private static readonly State[] RedefineSubelements; //Field offset: 0x78
	private static readonly State[] AttributeGroupSubelements; //Field offset: 0x80
	private static readonly State[] GroupSubelements; //Field offset: 0x88
	private static readonly State[] AllSubelements; //Field offset: 0x90
	private static readonly State[] ChoiceSequenceSubelements; //Field offset: 0x98
	private static readonly State[] IdentityConstraintSubelements; //Field offset: 0xA0
	private static readonly State[] AnnotationSubelements; //Field offset: 0xA8
	private static readonly State[] AnnotatedSubelements; //Field offset: 0xB0
	private static readonly XsdAttributeEntry[] SchemaAttributes; //Field offset: 0xB8
	private static readonly XsdAttributeEntry[] AttributeAttributes; //Field offset: 0xC0
	private static readonly XsdAttributeEntry[] ElementAttributes; //Field offset: 0xC8
	private static readonly XsdAttributeEntry[] ComplexTypeAttributes; //Field offset: 0xD0
	private static readonly XsdAttributeEntry[] SimpleContentAttributes; //Field offset: 0xD8
	private static readonly XsdAttributeEntry[] SimpleContentExtensionAttributes; //Field offset: 0xE0
	private static readonly XsdAttributeEntry[] SimpleContentRestrictionAttributes; //Field offset: 0xE8
	private static readonly XsdAttributeEntry[] ComplexContentAttributes; //Field offset: 0xF0
	private static readonly XsdAttributeEntry[] ComplexContentExtensionAttributes; //Field offset: 0xF8
	private static readonly XsdAttributeEntry[] ComplexContentRestrictionAttributes; //Field offset: 0x100
	private static readonly XsdAttributeEntry[] SimpleTypeAttributes; //Field offset: 0x108
	private static readonly XsdAttributeEntry[] SimpleTypeRestrictionAttributes; //Field offset: 0x110
	private static readonly XsdAttributeEntry[] SimpleTypeUnionAttributes; //Field offset: 0x118
	private static readonly XsdAttributeEntry[] SimpleTypeListAttributes; //Field offset: 0x120
	private static readonly XsdAttributeEntry[] AttributeGroupAttributes; //Field offset: 0x128
	private static readonly XsdAttributeEntry[] AttributeGroupRefAttributes; //Field offset: 0x130
	private static readonly XsdAttributeEntry[] GroupAttributes; //Field offset: 0x138
	private static readonly XsdAttributeEntry[] GroupRefAttributes; //Field offset: 0x140
	private static readonly XsdAttributeEntry[] ParticleAttributes; //Field offset: 0x148
	private static readonly XsdAttributeEntry[] AnyAttributes; //Field offset: 0x150
	private static readonly XsdAttributeEntry[] IdentityConstraintAttributes; //Field offset: 0x158
	private static readonly XsdAttributeEntry[] SelectorAttributes; //Field offset: 0x160
	private static readonly XsdAttributeEntry[] FieldAttributes; //Field offset: 0x168
	private static readonly XsdAttributeEntry[] NotationAttributes; //Field offset: 0x170
	private static readonly XsdAttributeEntry[] IncludeAttributes; //Field offset: 0x178
	private static readonly XsdAttributeEntry[] ImportAttributes; //Field offset: 0x180
	private static readonly XsdAttributeEntry[] FacetAttributes; //Field offset: 0x188
	private static readonly XsdAttributeEntry[] AnyAttributeAttributes; //Field offset: 0x190
	private static readonly XsdAttributeEntry[] DocumentationAttributes; //Field offset: 0x198
	private static readonly XsdAttributeEntry[] AppinfoAttributes; //Field offset: 0x1A0
	private static readonly XsdAttributeEntry[] RedefineAttributes; //Field offset: 0x1A8
	private static readonly XsdAttributeEntry[] AnnotationAttributes; //Field offset: 0x1B0
	private static readonly XsdEntry[] SchemaEntries; //Field offset: 0x1B8
	private static readonly Int32[] DerivationMethodValues; //Field offset: 0x1C0
	private static readonly String[] DerivationMethodStrings; //Field offset: 0x1C8
	private static readonly String[] FormStringValues; //Field offset: 0x1D0
	private static readonly String[] UseStringValues; //Field offset: 0x1D8
	private static readonly String[] ProcessContentsStringValues; //Field offset: 0x1E0
	private XmlReader reader; //Field offset: 0x10
	private PositionInfo positionInfo; //Field offset: 0x18
	private XsdEntry currentEntry; //Field offset: 0x20
	private XsdEntry nextEntry; //Field offset: 0x28
	private bool hasChild; //Field offset: 0x30
	private HWStack stateHistory; //Field offset: 0x38
	private Stack containerStack; //Field offset: 0x40
	private XmlNameTable nameTable; //Field offset: 0x48
	private SchemaNames schemaNames; //Field offset: 0x50
	private XmlNamespaceManager namespaceManager; //Field offset: 0x58
	private bool canIncludeImport; //Field offset: 0x60
	private XmlSchema schema; //Field offset: 0x68
	private XmlSchemaObject xso; //Field offset: 0x70
	private XmlSchemaElement element; //Field offset: 0x78
	private XmlSchemaAny anyElement; //Field offset: 0x80
	private XmlSchemaAttribute attribute; //Field offset: 0x88
	private XmlSchemaAnyAttribute anyAttribute; //Field offset: 0x90
	private XmlSchemaComplexType complexType; //Field offset: 0x98
	private XmlSchemaSimpleType simpleType; //Field offset: 0xA0
	private XmlSchemaComplexContent complexContent; //Field offset: 0xA8
	private XmlSchemaComplexContentExtension complexContentExtension; //Field offset: 0xB0
	private XmlSchemaComplexContentRestriction complexContentRestriction; //Field offset: 0xB8
	private XmlSchemaSimpleContent simpleContent; //Field offset: 0xC0
	private XmlSchemaSimpleContentExtension simpleContentExtension; //Field offset: 0xC8
	private XmlSchemaSimpleContentRestriction simpleContentRestriction; //Field offset: 0xD0
	private XmlSchemaSimpleTypeUnion simpleTypeUnion; //Field offset: 0xD8
	private XmlSchemaSimpleTypeList simpleTypeList; //Field offset: 0xE0
	private XmlSchemaSimpleTypeRestriction simpleTypeRestriction; //Field offset: 0xE8
	private XmlSchemaGroup group; //Field offset: 0xF0
	private XmlSchemaGroupRef groupRef; //Field offset: 0xF8
	private XmlSchemaAll all; //Field offset: 0x100
	private XmlSchemaChoice choice; //Field offset: 0x108
	private XmlSchemaSequence sequence; //Field offset: 0x110
	private XmlSchemaParticle particle; //Field offset: 0x118
	private XmlSchemaAttributeGroup attributeGroup; //Field offset: 0x120
	private XmlSchemaAttributeGroupRef attributeGroupRef; //Field offset: 0x128
	private XmlSchemaNotation notation; //Field offset: 0x130
	private XmlSchemaIdentityConstraint identityConstraint; //Field offset: 0x138
	private XmlSchemaXPath xpath; //Field offset: 0x140
	private XmlSchemaInclude include; //Field offset: 0x148
	private XmlSchemaImport import; //Field offset: 0x150
	private XmlSchemaAnnotation annotation; //Field offset: 0x158
	private XmlSchemaAppInfo appInfo; //Field offset: 0x160
	private XmlSchemaDocumentation documentation; //Field offset: 0x168
	private XmlSchemaFacet facet; //Field offset: 0x170
	private XmlNode[] markup; //Field offset: 0x178
	private XmlSchemaRedefine redefine; //Field offset: 0x180
	private ValidationEventHandler validationEventHandler; //Field offset: 0x188
	private ArrayList unhandledAttributes; //Field offset: 0x190
	private Hashtable namespaces; //Field offset: 0x198

	private Token CurrentElement
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		private get { } //Length: 26
	}

	private XmlSchemaObject ParentContainer
	{
		[CalledBy(Type = typeof(XsdBuilder), Member = "ProcessElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(XsdBuilder), Member = "InitAnnotation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XsdBuilder), typeof(string)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XsdBuilder), Member = "AddParticle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaParticle)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XsdBuilder), Member = "RecordPosition", ReturnType = typeof(void))]
		[CallerCount(Count = 4)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		private get { } //Length: 136
	}

	private Token ParentElement
	{
		[CalledBy(Type = typeof(XsdBuilder), Member = "InitAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XsdBuilder), typeof(string)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XsdBuilder), Member = "InitElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XsdBuilder), typeof(string)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XsdBuilder), Member = "InitSimpleType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XsdBuilder), typeof(string)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XsdBuilder), Member = "InitComplexType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XsdBuilder), typeof(string)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XsdBuilder), Member = "InitAttributeGroup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XsdBuilder), typeof(string)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XsdBuilder), Member = "InitAnyAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XsdBuilder), typeof(string)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XsdBuilder), Member = "InitGroup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XsdBuilder), typeof(string)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XsdBuilder), Member = "InitFacet", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XsdBuilder), typeof(string)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XsdBuilder), Member = "InitAnnotation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XsdBuilder), typeof(string)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XsdBuilder), Member = "AddAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaObject)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XsdBuilder), Member = "AddParticle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaParticle)}, ReturnType = typeof(void))]
		[CallerCount(Count = 12)]
		[Calls(Type = typeof(HWStack), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(object))]
		[CallsUnknownMethods(Count = 2)]
		private get { } //Length: 121
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(RuntimeFieldHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XsdEntry), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Token), typeof(State), typeof(State[]), typeof(XsdAttributeEntry[]), typeof(XsdInitFunction), typeof(XsdEndChildFunction), typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 252)]
	[CallsUnknownMethods(Count = 228)]
	private static XsdBuilder() { }

	[CalledBy(Type = typeof(Parser), Member = "StartParsing", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlReader), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(HWStack), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Stack), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(ArrayList), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(BuilderNamespaceManager), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNamespaceManager), typeof(XmlReader)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(PositionInfo), Member = "GetPositionInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(PositionInfo))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 15)]
	internal XsdBuilder(XmlReader reader, XmlNamespaceManager curmgr, XmlSchema schema, XmlNameTable nameTable, SchemaNames schemaNames, ValidationEventHandler eventhandler) { }

	[CalledBy(Type = typeof(XsdBuilder), Member = "InitAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XsdBuilder), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XsdBuilder), Member = "InitAttributeGroupRef", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XsdBuilder), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(XsdBuilder), Member = "get_ParentElement", ReturnType = typeof(Token))]
	[Calls(Type = typeof(XsdBuilder), Member = "SendValidationEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSchemaObjectCollection), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaObject)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(XmlSchemaComplexType), Member = "get_Attributes", ReturnType = typeof(XmlSchemaObjectCollection))]
	[CallsUnknownMethods(Count = 1)]
	private void AddAttribute(XmlSchemaObject value) { }

	[CalledBy(Type = typeof(XsdBuilder), Member = "InitGroupRef", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XsdBuilder), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XsdBuilder), Member = "InitAll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XsdBuilder), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XsdBuilder), Member = "InitChoice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XsdBuilder), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XsdBuilder), Member = "InitSequence", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XsdBuilder), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XsdBuilder), Member = "InitAny", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XsdBuilder), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(XsdBuilder), Member = "get_ParentElement", ReturnType = typeof(Token))]
	[Calls(Type = typeof(XmlSchemaComplexType), Member = "get_Attributes", ReturnType = typeof(XmlSchemaObjectCollection))]
	[Calls(Type = typeof(XsdBuilder), Member = "SendValidationEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XsdBuilder), Member = "get_ParentContainer", ReturnType = typeof(XmlSchemaObject))]
	[Calls(Type = typeof(XmlSchemaObjectCollection), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaObject)}, ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 7)]
	private void AddParticle(XmlSchemaParticle particle) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private static void BuildAnnotated_Id(XsdBuilder builder, string value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void BuildAny_Namespace(XsdBuilder builder, string value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XsdBuilder), Member = "ParseEnum", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(String[])}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 1)]
	private static void BuildAny_ProcessContents(XsdBuilder builder, string value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void BuildAnyAttribute_Namespace(XsdBuilder builder, string value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XsdBuilder), Member = "ParseEnum", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(String[])}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 1)]
	private static void BuildAnyAttribute_ProcessContents(XsdBuilder builder, string value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void BuildAppinfo_Source(XsdBuilder builder, string value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void BuildAttribute_Default(XsdBuilder builder, string value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void BuildAttribute_Fixed(XsdBuilder builder, string value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XsdBuilder), Member = "ParseEnum", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(String[])}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 1)]
	private static void BuildAttribute_Form(XsdBuilder builder, string value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void BuildAttribute_Name(XsdBuilder builder, string value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XsdBuilder), Member = "ParseQName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(XmlQualifiedName))]
	[Calls(Type = typeof(XmlSchemaAttribute), Member = "set_RefName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private static void BuildAttribute_Ref(XsdBuilder builder, string value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XsdBuilder), Member = "ParseQName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(XmlQualifiedName))]
	[Calls(Type = typeof(XmlSchemaAttribute), Member = "set_SchemaTypeName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private static void BuildAttribute_Type(XsdBuilder builder, string value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XsdBuilder), Member = "ParseEnum", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(String[])}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 1)]
	private static void BuildAttribute_Use(XsdBuilder builder, string value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void BuildAttributeGroup_Name(XsdBuilder builder, string value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XsdBuilder), Member = "ParseQName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(XmlQualifiedName))]
	[Calls(Type = typeof(XmlSchemaAttributeGroupRef), Member = "set_RefName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private static void BuildAttributeGroupRef_Ref(XsdBuilder builder, string value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XsdBuilder), Member = "ParseBoolean", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlSchemaComplexContent), Member = "set_IsMixed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private static void BuildComplexContent_Mixed(XsdBuilder builder, string value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XsdBuilder), Member = "ParseQName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(XmlQualifiedName))]
	[Calls(Type = typeof(XmlSchemaComplexContentExtension), Member = "set_BaseTypeName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private static void BuildComplexContentExtension_Base(XsdBuilder builder, string value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XsdBuilder), Member = "ParseQName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(XmlQualifiedName))]
	[Calls(Type = typeof(XmlSchemaComplexContentRestriction), Member = "set_BaseTypeName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private static void BuildComplexContentRestriction_Base(XsdBuilder builder, string value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XsdBuilder), Member = "ParseBoolean", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlSchemaComplexType), Member = "set_IsAbstract", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private static void BuildComplexType_Abstract(XsdBuilder builder, string value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XsdBuilder), Member = "ParseBlockFinalEnum", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 1)]
	private static void BuildComplexType_Block(XsdBuilder builder, string value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XsdBuilder), Member = "ParseBlockFinalEnum", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 1)]
	private static void BuildComplexType_Final(XsdBuilder builder, string value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XsdBuilder), Member = "ParseBoolean", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private static void BuildComplexType_Mixed(XsdBuilder builder, string value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void BuildComplexType_Name(XsdBuilder builder, string value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void BuildDocumentation_Source(XsdBuilder builder, string value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlSchemaDocumentation), Member = "set_Language", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSchemaException), Member = "SetSource", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XsdBuilder), Member = "SendValidationEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaException), typeof(XmlSeverityType)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 3)]
	private static void BuildDocumentation_XmlLang(XsdBuilder builder, string value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XsdBuilder), Member = "ParseBoolean", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlSchemaElement), Member = "set_IsAbstract", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private static void BuildElement_Abstract(XsdBuilder builder, string value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XsdBuilder), Member = "ParseBlockFinalEnum", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 1)]
	private static void BuildElement_Block(XsdBuilder builder, string value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void BuildElement_Default(XsdBuilder builder, string value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XsdBuilder), Member = "ParseBlockFinalEnum", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 1)]
	private static void BuildElement_Final(XsdBuilder builder, string value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void BuildElement_Fixed(XsdBuilder builder, string value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XsdBuilder), Member = "ParseEnum", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(String[])}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 1)]
	private static void BuildElement_Form(XsdBuilder builder, string value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XsdBuilder), Member = "SetMaxOccurs", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaParticle), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private static void BuildElement_MaxOccurs(XsdBuilder builder, string value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XsdBuilder), Member = "SetMinOccurs", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaParticle), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private static void BuildElement_MinOccurs(XsdBuilder builder, string value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void BuildElement_Name(XsdBuilder builder, string value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XsdBuilder), Member = "ParseBoolean", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlSchemaElement), Member = "set_IsNillable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private static void BuildElement_Nillable(XsdBuilder builder, string value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XsdBuilder), Member = "ParseQName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(XmlQualifiedName))]
	[Calls(Type = typeof(XmlSchemaElement), Member = "set_RefName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private static void BuildElement_Ref(XsdBuilder builder, string value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XsdBuilder), Member = "ParseQName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(XmlQualifiedName))]
	[Calls(Type = typeof(XmlSchemaElement), Member = "set_SubstitutionGroup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private static void BuildElement_SubstitutionGroup(XsdBuilder builder, string value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XsdBuilder), Member = "ParseQName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(XmlQualifiedName))]
	[Calls(Type = typeof(XmlSchemaElement), Member = "set_SchemaTypeName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private static void BuildElement_Type(XsdBuilder builder, string value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XsdBuilder), Member = "ParseBoolean", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private static void BuildFacet_Fixed(XsdBuilder builder, string value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void BuildFacet_Value(XsdBuilder builder, string value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	private static void BuildField_XPath(XsdBuilder builder, string value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void BuildGroup_Name(XsdBuilder builder, string value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XsdBuilder), Member = "ParseQName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(XmlQualifiedName))]
	[Calls(Type = typeof(XmlSchemaGroupRef), Member = "set_RefName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private static void BuildGroupRef_Ref(XsdBuilder builder, string value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void BuildIdentityConstraint_Name(XsdBuilder builder, string value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XsdBuilder), Member = "ParseQName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(XmlQualifiedName))]
	[Calls(Type = typeof(XmlSchemaKeyref), Member = "set_Refer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XsdBuilder), Member = "SendValidationEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	private static void BuildIdentityConstraint_Refer(XsdBuilder builder, string value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void BuildImport_Namespace(XsdBuilder builder, string value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void BuildImport_SchemaLocation(XsdBuilder builder, string value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void BuildInclude_SchemaLocation(XsdBuilder builder, string value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void BuildNotation_Name(XsdBuilder builder, string value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void BuildNotation_Public(XsdBuilder builder, string value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void BuildNotation_System(XsdBuilder builder, string value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XsdBuilder), Member = "SetMaxOccurs", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaParticle), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private static void BuildParticle_MaxOccurs(XsdBuilder builder, string value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XsdBuilder), Member = "SetMinOccurs", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaParticle), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private static void BuildParticle_MinOccurs(XsdBuilder builder, string value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void BuildRedefine_SchemaLocation(XsdBuilder builder, string value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XsdBuilder), Member = "ParseEnum", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(String[])}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 1)]
	private static void BuildSchema_AttributeFormDefault(XsdBuilder builder, string value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XsdBuilder), Member = "ParseBlockFinalEnum", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 1)]
	private static void BuildSchema_BlockDefault(XsdBuilder builder, string value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XsdBuilder), Member = "ParseEnum", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(String[])}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 1)]
	private static void BuildSchema_ElementFormDefault(XsdBuilder builder, string value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XsdBuilder), Member = "ParseBlockFinalEnum", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 1)]
	private static void BuildSchema_FinalDefault(XsdBuilder builder, string value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void BuildSchema_TargetNamespace(XsdBuilder builder, string value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void BuildSchema_Version(XsdBuilder builder, string value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	private static void BuildSelector_XPath(XsdBuilder builder, string value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XsdBuilder), Member = "ParseQName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(XmlQualifiedName))]
	[Calls(Type = typeof(XmlSchemaSimpleContentExtension), Member = "set_BaseTypeName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private static void BuildSimpleContentExtension_Base(XsdBuilder builder, string value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XsdBuilder), Member = "ParseQName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(XmlQualifiedName))]
	[Calls(Type = typeof(XmlSchemaSimpleContentRestriction), Member = "set_BaseTypeName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private static void BuildSimpleContentRestriction_Base(XsdBuilder builder, string value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XsdBuilder), Member = "ParseBlockFinalEnum", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 1)]
	private static void BuildSimpleType_Final(XsdBuilder builder, string value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void BuildSimpleType_Name(XsdBuilder builder, string value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XsdBuilder), Member = "ParseQName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(XmlQualifiedName))]
	[Calls(Type = typeof(XmlSchemaSimpleTypeList), Member = "set_ItemTypeName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private static void BuildSimpleTypeList_ItemType(XsdBuilder builder, string value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XsdBuilder), Member = "ParseQName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(XmlQualifiedName))]
	[Calls(Type = typeof(XmlSchemaSimpleTypeRestriction), Member = "set_BaseTypeName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private static void BuildSimpleTypeRestriction_Base(XsdBuilder builder, string value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlSchemaDatatype), Member = "FromXmlTokenizedTypeXsd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlTokenizedType)}, ReturnType = typeof(XmlSchemaDatatype))]
	[Calls(Type = typeof(XmlSchemaException), Member = "SetSource", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XsdBuilder), Member = "SendValidationEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaException), typeof(XmlSeverityType)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 7)]
	private static void BuildSimpleTypeUnion_MemberTypes(XsdBuilder builder, string value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void EndAppinfo(XsdBuilder builder) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(HWStack), Member = "Pop", ReturnType = typeof(object))]
	[Calls(Type = typeof(XsdBuilder), Member = "SetContainer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(State), typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	internal virtual void EndChildren() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void EndDocumentation(XsdBuilder builder) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private static void EndRedefine(XsdBuilder builder) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	private Token get_CurrentElement() { }

	[CalledBy(Type = typeof(XsdBuilder), Member = "ProcessElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XsdBuilder), Member = "InitAnnotation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XsdBuilder), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XsdBuilder), Member = "AddParticle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaParticle)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XsdBuilder), Member = "RecordPosition", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private XmlSchemaObject get_ParentContainer() { }

	[CalledBy(Type = typeof(XsdBuilder), Member = "InitAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XsdBuilder), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XsdBuilder), Member = "InitElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XsdBuilder), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XsdBuilder), Member = "InitSimpleType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XsdBuilder), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XsdBuilder), Member = "InitComplexType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XsdBuilder), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XsdBuilder), Member = "InitAttributeGroup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XsdBuilder), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XsdBuilder), Member = "InitAnyAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XsdBuilder), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XsdBuilder), Member = "InitGroup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XsdBuilder), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XsdBuilder), Member = "InitFacet", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XsdBuilder), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XsdBuilder), Member = "InitAnnotation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XsdBuilder), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XsdBuilder), Member = "AddAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaObject)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XsdBuilder), Member = "AddParticle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaParticle)}, ReturnType = typeof(void))]
	[CallerCount(Count = 12)]
	[Calls(Type = typeof(HWStack), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(object))]
	[CallsUnknownMethods(Count = 2)]
	private Token get_ParentElement() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private XmlSchemaObject GetContainer(State state) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private bool GetNextState(XmlQualifiedName qname) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlSchemaAll), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(XsdBuilder), Member = "AddParticle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaParticle)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	private static void InitAll(XsdBuilder builder, string value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XsdBuilder), Member = "get_ParentElement", ReturnType = typeof(Token))]
	[Calls(Type = typeof(XsdBuilder), Member = "SendValidationEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSchemaAnnotation), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(XsdBuilder), Member = "get_ParentContainer", ReturnType = typeof(XmlSchemaObject))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private static void InitAnnotation(XsdBuilder builder, string value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlSchemaAny), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(XsdBuilder), Member = "AddParticle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaParticle)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	private static void InitAny(XsdBuilder builder, string value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XsdBuilder), Member = "get_ParentElement", ReturnType = typeof(Token))]
	[Calls(Type = typeof(XsdBuilder), Member = "SendValidationEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	private static void InitAnyAttribute(XsdBuilder builder, string value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlSchemaObjectCollection), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaObject)}, ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	private static void InitAppinfo(XsdBuilder builder, string value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlSchemaAttribute), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(XsdBuilder), Member = "get_ParentElement", ReturnType = typeof(Token))]
	[Calls(Type = typeof(XsdBuilder), Member = "AddAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaObject)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSchemaObjectCollection), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaObject)}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 3)]
	private static void InitAttribute(XsdBuilder builder, string value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlSchemaAttributeGroup), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(XsdBuilder), Member = "get_ParentElement", ReturnType = typeof(Token))]
	[Calls(Type = typeof(XmlSchemaObjectCollection), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaObject)}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 3)]
	private static void InitAttributeGroup(XsdBuilder builder, string value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlSchemaAttributeGroupRef), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(XsdBuilder), Member = "AddAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaObject)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	private static void InitAttributeGroupRef(XsdBuilder builder, string value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlSchemaChoice), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(XsdBuilder), Member = "AddParticle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaParticle)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	private static void InitChoice(XsdBuilder builder, string value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlSchemaComplexType), Member = "get_Attributes", ReturnType = typeof(XmlSchemaObjectCollection))]
	[Calls(Type = typeof(XsdBuilder), Member = "SendValidationEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	private static void InitComplexContent(XsdBuilder builder, string value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XsdBuilder), Member = "SendValidationEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSchemaComplexContentExtension), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private static void InitComplexContentExtension(XsdBuilder builder, string value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlSchemaComplexContentRestriction), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private static void InitComplexContentRestriction(XsdBuilder builder, string value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlSchemaComplexType), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(XsdBuilder), Member = "get_ParentElement", ReturnType = typeof(Token))]
	[Calls(Type = typeof(XmlSchemaObjectCollection), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaObject)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(XsdBuilder), Member = "SendValidationEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSchemaElement), Member = "get_Constraints", ReturnType = typeof(XmlSchemaObjectCollection))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	private static void InitComplexType(XsdBuilder builder, string value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlSchemaObjectCollection), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaObject)}, ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	private static void InitDocumentation(XsdBuilder builder, string value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlSchemaElement), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(XsdBuilder), Member = "get_ParentElement", ReturnType = typeof(Token))]
	[Calls(Type = typeof(XmlSchemaObjectCollection), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaObject)}, ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private static void InitElement(XsdBuilder builder, string value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlSchemaObjectCollection), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaObject)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(XsdBuilder), Member = "SendValidationEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XsdBuilder), Member = "get_ParentElement", ReturnType = typeof(Token))]
	[Calls(Type = typeof(XmlSchemaWhiteSpaceFacet), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSchemaPatternFacet), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSchemaEnumerationFacet), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSchemaMaxLengthFacet), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSchemaMinLengthFacet), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSchemaLengthFacet), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSchemaFractionDigitsFacet), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSchemaTotalDigitsFacet), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSchemaMaxInclusiveFacet), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSchemaMaxExclusiveFacet), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSchemaMinInclusiveFacet), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSchemaMinExclusiveFacet), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	private static void InitFacet(XsdBuilder builder, string value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XsdBuilder), Member = "SendValidationEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSchemaObjectCollection), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaObject)}, ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private static void InitField(XsdBuilder builder, string value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlSchemaGroup), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(XsdBuilder), Member = "get_ParentElement", ReturnType = typeof(Token))]
	[Calls(Type = typeof(XmlSchemaObjectCollection), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaObject)}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 3)]
	private static void InitGroup(XsdBuilder builder, string value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlSchemaGroupRef), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(XsdBuilder), Member = "AddParticle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaParticle)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	private static void InitGroupRef(XsdBuilder builder, string value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlQualifiedName), Member = "get_IsEmpty", ReturnType = typeof(bool))]
	[Calls(Type = typeof(XsdBuilder), Member = "SendValidationEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSchemaKeyref), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSchemaElement), Member = "get_Constraints", ReturnType = typeof(XmlSchemaObjectCollection))]
	[Calls(Type = typeof(XmlSchemaObjectCollection), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaObject)}, ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private static void InitIdentityConstraint(XsdBuilder builder, string value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XsdBuilder), Member = "SendValidationEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSchemaImport), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSchemaObjectCollection), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaObject)}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 3)]
	private static void InitImport(XsdBuilder builder, string value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XsdBuilder), Member = "SendValidationEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSchemaInclude), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSchemaObjectCollection), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaObject)}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 3)]
	private static void InitInclude(XsdBuilder builder, string value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlSchemaNotation), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSchemaObjectCollection), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaObject)}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 3)]
	private static void InitNotation(XsdBuilder builder, string value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XsdBuilder), Member = "SendValidationEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSchemaRedefine), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSchemaObjectCollection), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaObject)}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 3)]
	private static void InitRedefine(XsdBuilder builder, string value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void InitSchema(XsdBuilder builder, string value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XsdBuilder), Member = "SendValidationEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	private static void InitSelector(XsdBuilder builder, string value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlSchemaSequence), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(XsdBuilder), Member = "AddParticle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaParticle)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	private static void InitSequence(XsdBuilder builder, string value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlSchemaComplexType), Member = "get_Attributes", ReturnType = typeof(XmlSchemaObjectCollection))]
	[Calls(Type = typeof(XsdBuilder), Member = "SendValidationEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	private static void InitSimpleContent(XsdBuilder builder, string value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XsdBuilder), Member = "SendValidationEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSchemaSimpleContentExtension), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private static void InitSimpleContentExtension(XsdBuilder builder, string value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XsdBuilder), Member = "SendValidationEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSchemaSimpleContentRestriction), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private static void InitSimpleContentRestriction(XsdBuilder builder, string value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XsdBuilder), Member = "get_ParentElement", ReturnType = typeof(Token))]
	[Calls(Type = typeof(XsdBuilder), Member = "SendValidationEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSchemaObjectCollection), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaObject)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(XmlSchemaElement), Member = "get_Constraints", ReturnType = typeof(XmlSchemaObjectCollection))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 7)]
	private static void InitSimpleType(XsdBuilder builder, string value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XsdBuilder), Member = "SendValidationEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSchemaSimpleTypeList), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	private static void InitSimpleTypeList(XsdBuilder builder, string value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XsdBuilder), Member = "SendValidationEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSchemaSimpleTypeRestriction), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	private static void InitSimpleTypeRestriction(XsdBuilder builder, string value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XsdBuilder), Member = "SendValidationEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSchemaSimpleTypeUnion), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	private static void InitSimpleTypeUnion(XsdBuilder builder, string value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	internal virtual bool IsContentParsed() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private bool IsSkipableElement(XmlQualifiedName qname) { }

	[CalledBy(Type = typeof(XsdBuilder), Member = "BuildSchema_FinalDefault", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XsdBuilder), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XsdBuilder), Member = "BuildSchema_BlockDefault", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XsdBuilder), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XsdBuilder), Member = "BuildElement_Block", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XsdBuilder), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XsdBuilder), Member = "BuildElement_Final", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XsdBuilder), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XsdBuilder), Member = "BuildSimpleType_Final", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XsdBuilder), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XsdBuilder), Member = "BuildComplexType_Block", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XsdBuilder), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XsdBuilder), Member = "BuildComplexType_Final", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XsdBuilder), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(XmlConvert), Member = "SplitString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(String[]))]
	[Calls(Type = typeof(XsdBuilder), Member = "SendValidationEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private int ParseBlockFinalEnum(string value, string attributeName) { }

	[CalledBy(Type = typeof(XsdBuilder), Member = "BuildElement_Abstract", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XsdBuilder), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XsdBuilder), Member = "BuildElement_Nillable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XsdBuilder), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XsdBuilder), Member = "BuildComplexType_Abstract", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XsdBuilder), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XsdBuilder), Member = "BuildComplexType_Mixed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XsdBuilder), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XsdBuilder), Member = "BuildComplexContent_Mixed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XsdBuilder), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XsdBuilder), Member = "BuildFacet_Fixed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XsdBuilder), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(XmlConvert), Member = "ToBoolean", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(XsdBuilder), Member = "SendValidationEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private bool ParseBoolean(string value, string attributeName) { }

	[CalledBy(Type = typeof(XsdBuilder), Member = "BuildSchema_AttributeFormDefault", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XsdBuilder), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XsdBuilder), Member = "BuildSchema_ElementFormDefault", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XsdBuilder), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XsdBuilder), Member = "BuildAttribute_Form", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XsdBuilder), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XsdBuilder), Member = "BuildAttribute_Use", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XsdBuilder), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XsdBuilder), Member = "BuildElement_Form", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XsdBuilder), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XsdBuilder), Member = "BuildAnyAttribute_ProcessContents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XsdBuilder), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XsdBuilder), Member = "BuildAny_ProcessContents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XsdBuilder), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(string), Member = "Trim", ReturnType = typeof(string))]
	[Calls(Type = typeof(XsdBuilder), Member = "SendValidationEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private int ParseEnum(string value, string attributeName, String[] values) { }

	[CalledBy(Type = typeof(XsdBuilder), Member = "BuildAttribute_Ref", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XsdBuilder), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XsdBuilder), Member = "BuildIdentityConstraint_Refer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XsdBuilder), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XsdBuilder), Member = "BuildGroupRef_Ref", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XsdBuilder), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XsdBuilder), Member = "BuildAttributeGroupRef_Ref", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XsdBuilder), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XsdBuilder), Member = "BuildSimpleContentRestriction_Base", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XsdBuilder), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XsdBuilder), Member = "BuildComplexContentRestriction_Base", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XsdBuilder), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XsdBuilder), Member = "BuildComplexContentExtension_Base", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XsdBuilder), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XsdBuilder), Member = "BuildSimpleContentExtension_Base", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XsdBuilder), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XsdBuilder), Member = "BuildSimpleTypeList_ItemType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XsdBuilder), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XsdBuilder), Member = "BuildElement_Type", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XsdBuilder), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XsdBuilder), Member = "BuildElement_Ref", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XsdBuilder), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XsdBuilder), Member = "BuildElement_SubstitutionGroup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XsdBuilder), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XsdBuilder), Member = "BuildAttribute_Type", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XsdBuilder), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XsdBuilder), Member = "BuildSimpleTypeRestriction_Base", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XsdBuilder), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 14)]
	[Calls(Type = typeof(XsdBuilder), Member = "SendValidationEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlComplianceUtil), Member = "NonCDataNormalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(XmlQualifiedName), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IXmlNamespaceResolver), typeof(String&)}, ReturnType = typeof(XmlQualifiedName))]
	[CallsUnknownMethods(Count = 3)]
	private XmlQualifiedName ParseQName(string value, string attributeName) { }

	[CallerCount(Count = 2063)]
	[DeduplicatedMethod]
	private static string ParseUriReference(string s) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(HWStack), Member = "Pop", ReturnType = typeof(object))]
	[Calls(Type = typeof(XsdBuilder), Member = "SetContainer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(State), typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	private void Pop() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlQualifiedName), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSchemaException), Member = "SetSource", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XsdBuilder), Member = "SendValidationEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[]), typeof(XmlSeverityType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlSchema), Member = "get_Document", ReturnType = typeof(XmlDocument))]
	[Calls(Type = typeof(XmlAttribute), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(XmlDocument)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Hashtable), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(XsdBuilder), Member = "SendValidationEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 12)]
	[CallsUnknownMethods(Count = 8)]
	internal virtual void ProcessAttribute(string prefix, string name, string ns, string value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XsdBuilder), Member = "SendValidationEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	internal virtual void ProcessCData(string value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlQualifiedName), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XsdBuilder), Member = "Push", ReturnType = typeof(void))]
	[Calls(Type = typeof(XsdBuilder), Member = "get_ParentContainer", ReturnType = typeof(XmlSchemaObject))]
	[Calls(Type = typeof(XsdBuilder), Member = "SendValidationEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 6)]
	internal virtual bool ProcessElement(string prefix, string name, string ns) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	internal virtual void ProcessMarkup(XmlNode[] markup) { }

	[CalledBy(Type = typeof(XsdBuilder), Member = "ProcessElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(HWStack), Member = "Push", ReturnType = typeof(object))]
	[Calls(Type = typeof(HWStack), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private void Push() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XsdBuilder), Member = "get_ParentContainer", ReturnType = typeof(XmlSchemaObject))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 3)]
	private void RecordPosition() { }

	[CalledBy(Type = typeof(XsdBuilder), Member = "ParseBoolean", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XsdBuilder), Member = "ParseEnum", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(String[])}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(XsdBuilder), Member = "ParseQName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(XmlQualifiedName))]
	[CalledBy(Type = typeof(XsdBuilder), Member = "ParseBlockFinalEnum", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(int))]
	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 5)]
	[ContainsInvalidInstructions]
	private void SendValidationEvent(string code, string arg0, string arg1, string arg2) { }

	[CallerCount(Count = 49)]
	[Calls(Type = typeof(XmlSchemaException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsInvalidInstructions]
	private void SendValidationEvent(string code, string msg) { }

	[CalledBy(Type = typeof(XsdBuilder), Member = "ProcessAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(XsdBuilder), Member = "SendValidationEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaException), typeof(XmlSeverityType)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	private void SendValidationEvent(string code, String[] args, XmlSeverityType severity) { }

	[CalledBy(Type = typeof(XsdBuilder), Member = "BuildSimpleTypeUnion_MemberTypes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XsdBuilder), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XsdBuilder), Member = "BuildDocumentation_XmlLang", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XsdBuilder), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XsdBuilder), Member = "SendValidationEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[]), typeof(XmlSeverityType)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XsdBuilder), Member = "SendValidationEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaException)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(ValidationEventArgs), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaException), typeof(XmlSeverityType)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	private void SendValidationEvent(XmlSchemaException e, XmlSeverityType severity) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XsdBuilder), Member = "SendValidationEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaException), typeof(XmlSeverityType)}, ReturnType = typeof(void))]
	private void SendValidationEvent(XmlSchemaException e) { }

	[CalledBy(Type = typeof(XsdBuilder), Member = "EndChildren", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XsdBuilder), Member = "Pop", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 66)]
	private void SetContainer(State state, object container) { }

	[CalledBy(Type = typeof(XsdBuilder), Member = "BuildElement_MaxOccurs", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XsdBuilder), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XsdBuilder), Member = "BuildParticle_MaxOccurs", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XsdBuilder), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(XmlSchemaParticle), Member = "set_MaxOccursString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XsdBuilder), Member = "SendValidationEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	private void SetMaxOccurs(XmlSchemaParticle particle, string value) { }

	[CalledBy(Type = typeof(XsdBuilder), Member = "BuildElement_MinOccurs", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XsdBuilder), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XsdBuilder), Member = "BuildParticle_MinOccurs", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XsdBuilder), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(XmlSchemaParticle), Member = "set_MinOccursString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XsdBuilder), Member = "SendValidationEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	private void SetMinOccurs(XmlSchemaParticle particle, string value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlSchemaObject), Member = "get_Namespaces", ReturnType = typeof(XmlSerializerNamespaces))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 5)]
	internal virtual void StartChildren() { }

}

