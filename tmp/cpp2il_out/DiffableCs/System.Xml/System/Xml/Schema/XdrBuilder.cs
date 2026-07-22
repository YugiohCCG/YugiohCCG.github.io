namespace System.Xml.Schema;

internal sealed class XdrBuilder : SchemaBuilder
{
	private sealed class AttributeContent
	{
		internal SchemaAttDef _AttDef; //Field offset: 0x10
		internal XmlQualifiedName _Name; //Field offset: 0x18
		internal string _Prefix; //Field offset: 0x20
		internal bool _Required; //Field offset: 0x28
		internal uint _MinVal; //Field offset: 0x2C
		internal uint _MaxVal; //Field offset: 0x30
		internal uint _MaxLength; //Field offset: 0x34
		internal uint _MinLength; //Field offset: 0x38
		internal bool _EnumerationRequired; //Field offset: 0x3C
		internal bool _HasDataType; //Field offset: 0x3D
		internal bool _Global; //Field offset: 0x3E
		internal object _Default; //Field offset: 0x40

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public AttributeContent() { }

	}

	private sealed class DeclBaseInfo
	{
		internal XmlQualifiedName _Name; //Field offset: 0x10
		internal string _Prefix; //Field offset: 0x18
		internal XmlQualifiedName _TypeName; //Field offset: 0x20
		internal string _TypePrefix; //Field offset: 0x28
		internal object _Default; //Field offset: 0x30
		internal object _Revises; //Field offset: 0x38
		internal uint _MaxOccurs; //Field offset: 0x40
		internal uint _MinOccurs; //Field offset: 0x44
		internal bool _Checking; //Field offset: 0x48
		internal SchemaElementDecl _ElementDecl; //Field offset: 0x50
		internal SchemaAttDef _Attdef; //Field offset: 0x58
		internal DeclBaseInfo _Next; //Field offset: 0x60

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(DeclBaseInfo), Member = "Reset", ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		internal DeclBaseInfo() { }

		[CalledBy(Type = typeof(DeclBaseInfo), Member = ".ctor", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XdrBuilder), Member = "XDR_InitAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XdrBuilder), typeof(object)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XdrBuilder), Member = "XDR_BeginAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XdrBuilder)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XdrBuilder), Member = "XDR_EndAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XdrBuilder)}, ReturnType = typeof(void))]
		[CallerCount(Count = 4)]
		[CallsUnknownMethods(Count = 9)]
		internal void Reset() { }

	}

	private sealed class ElementContent
	{
		internal SchemaElementDecl _ElementDecl; //Field offset: 0x10
		internal int _ContentAttr; //Field offset: 0x18
		internal int _OrderAttr; //Field offset: 0x1C
		internal bool _MasterGroupRequired; //Field offset: 0x20
		internal bool _ExistTerminal; //Field offset: 0x21
		internal bool _AllowDataType; //Field offset: 0x22
		internal bool _HasDataType; //Field offset: 0x23
		internal bool _HasType; //Field offset: 0x24
		internal bool _EnumerationRequired; //Field offset: 0x25
		internal uint _MinVal; //Field offset: 0x28
		internal uint _MaxVal; //Field offset: 0x2C
		internal uint _MaxLength; //Field offset: 0x30
		internal uint _MinLength; //Field offset: 0x34
		internal Hashtable _AttDefList; //Field offset: 0x38

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public ElementContent() { }

	}

	private sealed class GroupContent
	{
		internal uint _MinVal; //Field offset: 0x10
		internal uint _MaxVal; //Field offset: 0x14
		internal bool _HasMaxAttr; //Field offset: 0x18
		internal bool _HasMinAttr; //Field offset: 0x19
		internal int _Order; //Field offset: 0x1C

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public GroupContent() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		internal static GroupContent Copy(GroupContent other) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		internal static void Copy(GroupContent from, GroupContent to) { }

	}

	private sealed class XdrAttributeEntry
	{
		internal Token _Attribute; //Field offset: 0x10
		internal int _SchemaFlags; //Field offset: 0x14
		internal XmlSchemaDatatype _Datatype; //Field offset: 0x18
		internal XdrBuildFunction _BuildFunc; //Field offset: 0x20

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(DatatypeImplementation), Member = "FromXmlTokenizedType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlTokenizedType)}, ReturnType = typeof(DatatypeImplementation))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		internal XdrAttributeEntry(Token a, XmlTokenizedType ttype, XdrBuildFunction build) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(DatatypeImplementation), Member = "FromXmlTokenizedType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlTokenizedType)}, ReturnType = typeof(DatatypeImplementation))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		internal XdrAttributeEntry(Token a, XmlTokenizedType ttype, int schemaFlags, XdrBuildFunction build) { }

	}

	private sealed class XdrBeginChildFunction : MulticastDelegate
	{

		[CallerCount(Count = 10)]
		[CallsUnknownMethods(Count = 4)]
		[DeduplicatedMethod]
		public XdrBeginChildFunction(object object, IntPtr method) { }

		[CallerCount(Count = 3)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public override void Invoke(XdrBuilder builder) { }

	}

	private sealed class XdrBuildFunction : MulticastDelegate
	{

		[CallerCount(Count = 4)]
		[CallsUnknownMethods(Count = 4)]
		[DeduplicatedMethod]
		public XdrBuildFunction(object object, IntPtr method) { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public override void Invoke(XdrBuilder builder, object obj, string prefix) { }

	}

	private sealed class XdrEndChildFunction : MulticastDelegate
	{

		[CallerCount(Count = 10)]
		[CallsUnknownMethods(Count = 4)]
		[DeduplicatedMethod]
		public XdrEndChildFunction(object object, IntPtr method) { }

		[CallerCount(Count = 3)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public override void Invoke(XdrBuilder builder) { }

	}

	private sealed class XdrEntry
	{
		internal Token _Name; //Field offset: 0x10
		internal Int32[] _NextStates; //Field offset: 0x18
		internal XdrAttributeEntry[] _Attributes; //Field offset: 0x20
		internal XdrInitFunction _InitFunc; //Field offset: 0x28
		internal XdrBeginChildFunction _BeginChildFunc; //Field offset: 0x30
		internal XdrEndChildFunction _EndChildFunc; //Field offset: 0x38
		internal bool _AllowText; //Field offset: 0x40

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 5)]
		internal XdrEntry(Token n, Int32[] states, XdrAttributeEntry[] attributes, XdrInitFunction init, XdrBeginChildFunction begin, XdrEndChildFunction end, bool fText) { }

	}

	private sealed class XdrInitFunction : MulticastDelegate
	{

		[CallerCount(Count = 148)]
		[CallsUnknownMethods(Count = 4)]
		[DeduplicatedMethod]
		public XdrInitFunction(object object, IntPtr method) { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public override void Invoke(XdrBuilder builder, object obj) { }

	}

	private static readonly Int32[] S_XDR_Root_Element; //Field offset: 0x0
	private static readonly Int32[] S_XDR_Root_SubElements; //Field offset: 0x8
	private static readonly Int32[] S_XDR_ElementType_SubElements; //Field offset: 0x10
	private static readonly Int32[] S_XDR_AttributeType_SubElements; //Field offset: 0x18
	private static readonly Int32[] S_XDR_Group_SubElements; //Field offset: 0x20
	private static readonly XdrAttributeEntry[] S_XDR_Root_Attributes; //Field offset: 0x28
	private static readonly XdrAttributeEntry[] S_XDR_ElementType_Attributes; //Field offset: 0x30
	private static readonly XdrAttributeEntry[] S_XDR_AttributeType_Attributes; //Field offset: 0x38
	private static readonly XdrAttributeEntry[] S_XDR_Element_Attributes; //Field offset: 0x40
	private static readonly XdrAttributeEntry[] S_XDR_Attribute_Attributes; //Field offset: 0x48
	private static readonly XdrAttributeEntry[] S_XDR_Group_Attributes; //Field offset: 0x50
	private static readonly XdrAttributeEntry[] S_XDR_ElementDataType_Attributes; //Field offset: 0x58
	private static readonly XdrAttributeEntry[] S_XDR_AttributeDataType_Attributes; //Field offset: 0x60
	private static readonly XdrEntry[] S_SchemaEntries; //Field offset: 0x68
	private SchemaInfo _SchemaInfo; //Field offset: 0x10
	private string _TargetNamespace; //Field offset: 0x18
	private XmlReader _reader; //Field offset: 0x20
	private PositionInfo positionInfo; //Field offset: 0x28
	private ParticleContentValidator _contentValidator; //Field offset: 0x30
	private XdrEntry _CurState; //Field offset: 0x38
	private XdrEntry _NextState; //Field offset: 0x40
	private HWStack _StateHistory; //Field offset: 0x48
	private HWStack _GroupStack; //Field offset: 0x50
	private string _XdrName; //Field offset: 0x58
	private string _XdrPrefix; //Field offset: 0x60
	private ElementContent _ElementDef; //Field offset: 0x68
	private GroupContent _GroupDef; //Field offset: 0x70
	private AttributeContent _AttributeDef; //Field offset: 0x78
	private DeclBaseInfo _UndefinedAttributeTypes; //Field offset: 0x80
	private DeclBaseInfo _BaseDecl; //Field offset: 0x88
	private XmlNameTable _NameTable; //Field offset: 0x90
	private SchemaNames _SchemaNames; //Field offset: 0x98
	private XmlNamespaceManager _CurNsMgr; //Field offset: 0xA0
	private string _Text; //Field offset: 0xA8
	private ValidationEventHandler validationEventHandler; //Field offset: 0xB0
	private Hashtable _UndeclaredElements; //Field offset: 0xB8
	private XmlResolver xmlResolver; //Field offset: 0xC0

	internal XmlResolver XmlResolver
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		internal set { } //Length: 19
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(RuntimeFieldHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DatatypeImplementation), Member = "FromXmlTokenizedType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlTokenizedType)}, ReturnType = typeof(DatatypeImplementation))]
	[CallsDeduplicatedMethods(Count = 43)]
	[CallsUnknownMethods(Count = 390)]
	private static XdrBuilder() { }

	[CalledBy(Type = typeof(Parser), Member = "StartParsing", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlReader), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Hashtable), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(HWStack), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(PositionInfo), Member = "GetPositionInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(PositionInfo))]
	[Calls(Type = typeof(XmlReaderSection), Member = "CreateDefaultResolver", ReturnType = typeof(XmlResolver))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 18)]
	internal XdrBuilder(XmlReader reader, XmlNamespaceManager curmgr, SchemaInfo sinfo, string targetNamspace, XmlNameTable nameTable, SchemaNames schemaNames, ValidationEventHandler eventhandler) { }

	[CalledBy(Type = typeof(XdrBuilder), Member = "XDR_BuildElement_Type", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XdrBuilder), typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XdrBuilder), Member = "XDR_InitGroup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XdrBuilder), typeof(object)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ParticleContentValidator), Member = "AddSequence", ReturnType = typeof(void))]
	[Calls(Type = typeof(ParticleContentValidator), Member = "AddChoice", ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 6)]
	private void AddOrder() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DatatypeImplementation), Member = "FromXdrName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(DatatypeImplementation))]
	[Calls(Type = typeof(SchemaDeclBase), Member = "get_Prefix", ReturnType = typeof(string))]
	[Calls(Type = typeof(XmlQualifiedName), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(XdrBuilder), Member = "SendValidationEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private XmlSchemaDatatype CheckDatatype(string str) { }

	[CalledBy(Type = typeof(XdrBuilder), Member = "XDR_EndRoot", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XdrBuilder)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XdrBuilder), Member = "XDR_EndElementType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XdrBuilder)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XdrBuilder), Member = "XDR_EndAttributeType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XdrBuilder)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XdrBuilder), Member = "XDR_BeginAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XdrBuilder)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XdrBuilder), Member = "XDR_CheckAttributeDefault", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DeclBaseInfo), typeof(SchemaAttDef)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(SchemaDeclBase), Member = "get_DefaultValueRaw", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Trim", ReturnType = typeof(string))]
	[Calls(Type = typeof(XdrValidator), Member = "CheckDefaultValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(SchemaAttDef), typeof(SchemaInfo), typeof(XmlNamespaceManager), typeof(XmlNameTable), typeof(object), typeof(ValidationEventHandler), typeof(string), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	private void CheckDefaultAttValue(SchemaAttDef attDef) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XdrBuilder), Member = "SendValidationEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private static void CompareMinMaxLength(uint cMin, uint cMax, XdrBuilder builder) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(HWStack), Member = "Pop", ReturnType = typeof(object))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	internal virtual void EndChildren() { }

	[CalledBy(Type = typeof(XdrBuilder), Member = "XDR_BuildElementType_Content", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XdrBuilder), typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(XdrBuilder), Member = "SendValidationEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 2)]
	private int GetContent(XmlQualifiedName qname) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XdrBuilder), Member = "SendValidationEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	private bool GetModel(XmlQualifiedName qname) { }

	[CalledBy(Type = typeof(XdrBuilder), Member = "ProcessElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private bool GetNextState(XmlQualifiedName qname) { }

	[CalledBy(Type = typeof(XdrBuilder), Member = "XDR_BuildElementType_Order", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XdrBuilder), typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XdrBuilder), Member = "XDR_BuildGroup_Order", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XdrBuilder), typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(XdrBuilder), Member = "SendValidationEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	private int GetOrder(XmlQualifiedName qname) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ParticleContentValidator), Member = "AddQMark", ReturnType = typeof(void))]
	[Calls(Type = typeof(ParticleContentValidator), Member = "AddPlus", ReturnType = typeof(void))]
	[Calls(Type = typeof(ParticleContentValidator), Member = "AddStar", ReturnType = typeof(void))]
	private static void HandleMinMax(ParticleContentValidator pContent, uint cMin, uint cMax) { }

	[CallerCount(Count = 23)]
	[DeduplicatedMethod]
	internal virtual bool IsContentParsed() { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	private bool IsGlobal(int flags) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 1)]
	private bool IsSkipableAttribute(XmlQualifiedName qname) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	private bool IsSkipableElement(XmlQualifiedName qname) { }

	[CalledBy(Type = typeof(AutoValidator), Member = "DetectValidationType", ReturnType = typeof(ValidationType))]
	[CalledBy(Type = typeof(XdrBuilder), Member = "ProcessAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "Compare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(string), typeof(int), typeof(int), typeof(StringComparison)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(string), Member = "StartsWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(StringComparison)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	internal static bool IsXdrSchema(string uri) { }

	[CalledBy(Type = typeof(XdrBuilder), Member = "XDR_BuildAttributeType_Required", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XdrBuilder), typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XdrBuilder), Member = "XDR_BuildAttribute_Required", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XdrBuilder), typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(XdrBuilder), Member = "SendValidationEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private static bool IsYes(object obj, XdrBuilder builder) { }

	[CalledBy(Type = typeof(XdrBuilder), Member = "ProcessAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Dictionary`2), Member = "ContainsKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(XmlTextReader), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Stream), typeof(XmlNameTable)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SchemaInfo), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(Parser), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SchemaType), typeof(XmlNameTable), typeof(SchemaNames), typeof(ValidationEventHandler)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Parser), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlReader), typeof(string)}, ReturnType = typeof(SchemaType))]
	[Calls(Type = typeof(XdrBuilder), Member = "SendValidationEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[]), typeof(XmlSeverityType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SchemaInfo), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SchemaInfo), typeof(ValidationEventHandler)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallsUnknownMethods(Count = 18)]
	private bool LoadSchema(string uri) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XdrBuilder), Member = "SendValidationEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_InvariantInfo", ReturnType = typeof(NumberFormatInfo))]
	[Calls(Type = typeof(uint), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(NumberStyles), typeof(IFormatProvider), typeof(UInt32&)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private static void ParseDtMaxLength(ref uint cVal, object obj, XdrBuilder builder) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XdrBuilder), Member = "SendValidationEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_InvariantInfo", ReturnType = typeof(NumberFormatInfo))]
	[Calls(Type = typeof(uint), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(NumberStyles), typeof(IFormatProvider), typeof(UInt32&)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private static void ParseDtMinLength(ref uint cVal, object obj, XdrBuilder builder) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_InvariantInfo", ReturnType = typeof(NumberFormatInfo))]
	[Calls(Type = typeof(uint), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(NumberStyles), typeof(IFormatProvider), typeof(UInt32&)}, ReturnType = typeof(bool))]
	private static bool ParseInteger(string str, ref uint n) { }

	[CalledBy(Type = typeof(XdrBuilder), Member = "XDR_BuildElement_MaxOccurs", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XdrBuilder), typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XdrBuilder), Member = "XDR_BuildGroup_MaxOccurs", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XdrBuilder), typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_InvariantInfo", ReturnType = typeof(NumberFormatInfo))]
	[Calls(Type = typeof(uint), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(NumberStyles), typeof(IFormatProvider), typeof(UInt32&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(XdrBuilder), Member = "SendValidationEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	private static uint ParseMaxOccurs(object obj, XdrBuilder builder) { }

	[CalledBy(Type = typeof(XdrBuilder), Member = "XDR_BuildElement_MinOccurs", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XdrBuilder), typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XdrBuilder), Member = "XDR_BuildGroup_MinOccurs", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XdrBuilder), typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_InvariantInfo", ReturnType = typeof(NumberFormatInfo))]
	[Calls(Type = typeof(uint), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(NumberStyles), typeof(IFormatProvider), typeof(UInt32&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(XdrBuilder), Member = "SendValidationEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	private static uint ParseMinOccurs(object obj, XdrBuilder builder) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(HWStack), Member = "Pop", ReturnType = typeof(object))]
	[CallsUnknownMethods(Count = 5)]
	private void Pop() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(HWStack), Member = "Pop", ReturnType = typeof(object))]
	[CallsUnknownMethods(Count = 5)]
	private void PopGroupInfo() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlSchemaDatatype), Member = "XdrCanonizeUri", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(XmlNameTable), typeof(SchemaNames)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(XmlQualifiedName), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlQualifiedName), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IXmlNamespaceResolver), typeof(String&)}, ReturnType = typeof(XmlQualifiedName))]
	[Calls(Type = typeof(XmlQualifiedName), Member = "Atomize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNameTable)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlQualifiedName), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XdrBuilder), Member = "IsXdrSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(XdrBuilder), Member = "LoadSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlQualifiedName), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(XdrBuilder), Member = "SendValidationEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallsUnknownMethods(Count = 8)]
	internal virtual void ProcessAttribute(string prefix, string name, string ns, string value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XdrBuilder), Member = "SendValidationEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	internal virtual void ProcessCData(string value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlSchemaDatatype), Member = "XdrCanonizeUri", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(XmlNameTable), typeof(SchemaNames)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(XmlQualifiedName), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XdrBuilder), Member = "GetNextState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlQualifiedName), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(XdrBuilder), Member = "SendValidationEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(HWStack), Member = "Push", ReturnType = typeof(object))]
	[Calls(Type = typeof(HWStack), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 3)]
	internal virtual bool ProcessElement(string prefix, string name, string ns) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	internal virtual void ProcessMarkup(XmlNode[] markup) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(HWStack), Member = "Push", ReturnType = typeof(object))]
	[Calls(Type = typeof(HWStack), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	private void Push() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(HWStack), Member = "Push", ReturnType = typeof(object))]
	[Calls(Type = typeof(HWStack), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void PushGroupInfo() { }

	[CalledBy(Type = typeof(XdrBuilder), Member = "SendValidationEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	private void SendValidationEvent(XmlSchemaException e, XmlSeverityType severity) { }

	[CalledBy(Type = typeof(XdrBuilder), Member = "LoadSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(XmlSchemaException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[]), typeof(Exception), typeof(string), typeof(int), typeof(int), typeof(XmlSchemaObject)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsInvalidInstructions]
	private void SendValidationEvent(string code, String[] args, XmlSeverityType severity) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XdrBuilder), Member = "SendValidationEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	private void SendValidationEvent(string code) { }

	[CallerCount(Count = 54)]
	[Calls(Type = typeof(XmlSchemaException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XdrBuilder), Member = "SendValidationEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaException), typeof(XmlSeverityType)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	private void SendValidationEvent(string code, string msg) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	internal void set_XmlResolver(XmlResolver value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private void SetAttributePresence(SchemaAttDef pAttdef, bool fRequired) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	internal virtual void StartChildren() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlQualifiedName), Member = "get_IsEmpty", ReturnType = typeof(bool))]
	[Calls(Type = typeof(XdrBuilder), Member = "SendValidationEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlQualifiedName), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlQualifiedName), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(SchemaAttDef), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DeclBaseInfo), Member = "Reset", ReturnType = typeof(void))]
	[Calls(Type = typeof(SchemaAttDef), Member = "Clone", ReturnType = typeof(SchemaAttDef))]
	[Calls(Type = typeof(XdrBuilder), Member = "CheckDefaultAttValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SchemaAttDef)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SchemaElementDecl), Member = "AddAttDef", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SchemaAttDef)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 12)]
	private static void XDR_BeginAttribute(XdrBuilder builder) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlQualifiedName), Member = "get_IsEmpty", ReturnType = typeof(bool))]
	[Calls(Type = typeof(XdrBuilder), Member = "SendValidationEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private static void XDR_BeginAttributeType(XdrBuilder builder) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlQualifiedName), Member = "get_IsEmpty", ReturnType = typeof(bool))]
	[Calls(Type = typeof(ContentValidator), Member = "get_IsOpen", ReturnType = typeof(bool))]
	[Calls(Type = typeof(ParticleContentValidator), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaContentType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ParticleContentValidator), Member = "Start", ReturnType = typeof(void))]
	[Calls(Type = typeof(ParticleContentValidator), Member = "OpenGroup", ReturnType = typeof(void))]
	[Calls(Type = typeof(XdrBuilder), Member = "SendValidationEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	private static void XDR_BeginElementType(XdrBuilder builder) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Boolean>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private static void XDR_BeginRoot(XdrBuilder builder) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void XDR_BuildAttribute_Default(XdrBuilder builder, object obj, string prefix) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XdrBuilder), Member = "IsYes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(XdrBuilder)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	private static void XDR_BuildAttribute_Required(XdrBuilder builder, object obj, string prefix) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 5)]
	private static void XDR_BuildAttribute_Type(XdrBuilder builder, object obj, string prefix) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void XDR_BuildAttributeType_Default(XdrBuilder builder, object obj, string prefix) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XdrBuilder), Member = "SendValidationEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_InvariantInfo", ReturnType = typeof(NumberFormatInfo))]
	[Calls(Type = typeof(uint), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(NumberStyles), typeof(IFormatProvider), typeof(UInt32&)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private static void XDR_BuildAttributeType_DtMaxLength(XdrBuilder builder, object obj, string prefix) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XdrBuilder), Member = "SendValidationEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_InvariantInfo", ReturnType = typeof(NumberFormatInfo))]
	[Calls(Type = typeof(uint), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(NumberStyles), typeof(IFormatProvider), typeof(UInt32&)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private static void XDR_BuildAttributeType_DtMinLength(XdrBuilder builder, object obj, string prefix) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DatatypeImplementation), Member = "FromXdrName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(DatatypeImplementation))]
	[Calls(Type = typeof(SchemaDeclBase), Member = "get_Prefix", ReturnType = typeof(string))]
	[Calls(Type = typeof(XmlQualifiedName), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(XdrBuilder), Member = "SendValidationEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private static void XDR_BuildAttributeType_DtType(XdrBuilder builder, object obj, string prefix) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	private static void XDR_BuildAttributeType_DtValues(XdrBuilder builder, object obj, string prefix) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlQualifiedName), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Dictionary`2), Member = "ContainsKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlQualifiedName), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(XdrBuilder), Member = "SendValidationEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 6)]
	private static void XDR_BuildAttributeType_Name(XdrBuilder builder, object obj, string prefix) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XdrBuilder), Member = "IsYes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(XdrBuilder)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	private static void XDR_BuildAttributeType_Required(XdrBuilder builder, object obj, string prefix) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XdrBuilder), Member = "ParseMaxOccurs", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(XdrBuilder)}, ReturnType = typeof(uint))]
	[CallsUnknownMethods(Count = 1)]
	private static void XDR_BuildElement_MaxOccurs(XdrBuilder builder, object obj, string prefix) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XdrBuilder), Member = "ParseMinOccurs", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(XdrBuilder)}, ReturnType = typeof(uint))]
	[CallsUnknownMethods(Count = 1)]
	private static void XDR_BuildElement_MinOccurs(XdrBuilder builder, object obj, string prefix) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Dictionary`2), Member = "ContainsKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(SchemaElementDecl), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XdrBuilder), Member = "AddOrder", ReturnType = typeof(void))]
	[Calls(Type = typeof(ParticleContentValidator), Member = "AddName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName), typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private static void XDR_BuildElement_Type(XdrBuilder builder, object obj, string prefix) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XdrBuilder), Member = "GetContent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName)}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 2)]
	private static void XDR_BuildElementType_Content(XdrBuilder builder, object obj, string prefix) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XdrBuilder), Member = "SendValidationEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_InvariantInfo", ReturnType = typeof(NumberFormatInfo))]
	[Calls(Type = typeof(uint), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(NumberStyles), typeof(IFormatProvider), typeof(UInt32&)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private static void XDR_BuildElementType_DtMaxLength(XdrBuilder builder, object obj, string prefix) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XdrBuilder), Member = "SendValidationEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_InvariantInfo", ReturnType = typeof(NumberFormatInfo))]
	[Calls(Type = typeof(uint), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(NumberStyles), typeof(IFormatProvider), typeof(UInt32&)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private static void XDR_BuildElementType_DtMinLength(XdrBuilder builder, object obj, string prefix) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Trim", ReturnType = typeof(string))]
	[Calls(Type = typeof(DatatypeImplementation), Member = "FromXdrName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(DatatypeImplementation))]
	[Calls(Type = typeof(XdrBuilder), Member = "SendValidationEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	private static void XDR_BuildElementType_DtType(XdrBuilder builder, object obj, string prefix) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	private static void XDR_BuildElementType_DtValues(XdrBuilder builder, object obj, string prefix) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XdrBuilder), Member = "SendValidationEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private static void XDR_BuildElementType_Model(XdrBuilder builder, object obj, string prefix) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Dictionary`2), Member = "ContainsKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlQualifiedName), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(XdrBuilder), Member = "SendValidationEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	private static void XDR_BuildElementType_Name(XdrBuilder builder, object obj, string prefix) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XdrBuilder), Member = "GetOrder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName)}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 2)]
	private static void XDR_BuildElementType_Order(XdrBuilder builder, object obj, string prefix) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XdrBuilder), Member = "ParseMaxOccurs", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(XdrBuilder)}, ReturnType = typeof(uint))]
	[CallsUnknownMethods(Count = 1)]
	private static void XDR_BuildGroup_MaxOccurs(XdrBuilder builder, object obj, string prefix) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XdrBuilder), Member = "ParseMinOccurs", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(XdrBuilder)}, ReturnType = typeof(uint))]
	[CallsUnknownMethods(Count = 1)]
	private static void XDR_BuildGroup_MinOccurs(XdrBuilder builder, object obj, string prefix) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XdrBuilder), Member = "GetOrder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(XdrBuilder), Member = "SendValidationEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	private static void XDR_BuildGroup_Order(XdrBuilder builder, object obj, string prefix) { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	private static void XDR_BuildRoot_ID(XdrBuilder builder, object obj, string prefix) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 5)]
	private static void XDR_BuildRoot_Name(XdrBuilder builder, object obj, string prefix) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XdrBuilder), Member = "CheckDefaultAttValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SchemaAttDef)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	private void XDR_CheckAttributeDefault(DeclBaseInfo decl, SchemaAttDef pAttdef) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DeclBaseInfo), Member = "Reset", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private static void XDR_EndAttribute(XdrBuilder builder) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XdrBuilder), Member = "SendValidationEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private static void XDR_EndAttributeDtType(XdrBuilder builder) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XdrBuilder), Member = "SendValidationEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DatatypeImplementation), Member = "FromXmlTokenizedType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlTokenizedType)}, ReturnType = typeof(DatatypeImplementation))]
	[Calls(Type = typeof(XdrBuilder), Member = "CheckDefaultAttValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SchemaAttDef)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	private static void XDR_EndAttributeType(XdrBuilder builder) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XdrBuilder), Member = "SendValidationEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ParticleContentValidator), Member = "AddQMark", ReturnType = typeof(void))]
	[Calls(Type = typeof(ParticleContentValidator), Member = "AddPlus", ReturnType = typeof(void))]
	[Calls(Type = typeof(ParticleContentValidator), Member = "AddStar", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private static void XDR_EndElement(XdrBuilder builder) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XdrBuilder), Member = "SendValidationEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	private static void XDR_EndElementDtType(XdrBuilder builder) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SchemaAttDef), Member = "Clone", ReturnType = typeof(SchemaAttDef))]
	[Calls(Type = typeof(XdrBuilder), Member = "CheckDefaultAttValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SchemaAttDef)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ParticleContentValidator), Member = "CloseGroup", ReturnType = typeof(void))]
	[Calls(Type = typeof(ParticleContentValidator), Member = "AddStar", ReturnType = typeof(void))]
	[Calls(Type = typeof(ContentValidator), Member = "get_IsOpen", ReturnType = typeof(bool))]
	[Calls(Type = typeof(XdrBuilder), Member = "SendValidationEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ParticleContentValidator), Member = "Finish", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(ContentValidator))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 15)]
	private static void XDR_EndElementType(XdrBuilder builder) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XdrBuilder), Member = "SendValidationEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ParticleContentValidator), Member = "CloseGroup", ReturnType = typeof(void))]
	[Calls(Type = typeof(ParticleContentValidator), Member = "AddStar", ReturnType = typeof(void))]
	[Calls(Type = typeof(ParticleContentValidator), Member = "AddQMark", ReturnType = typeof(void))]
	[Calls(Type = typeof(ParticleContentValidator), Member = "AddPlus", ReturnType = typeof(void))]
	[Calls(Type = typeof(HWStack), Member = "Pop", ReturnType = typeof(object))]
	[CallsUnknownMethods(Count = 5)]
	private static void XDR_EndGroup(XdrBuilder builder) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlQualifiedName), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(XdrBuilder), Member = "SendValidationEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SchemaAttDef), Member = "Clone", ReturnType = typeof(SchemaAttDef))]
	[Calls(Type = typeof(XdrBuilder), Member = "CheckDefaultAttValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SchemaAttDef)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SchemaDeclBase), Member = "get_Prefix", ReturnType = typeof(string))]
	[Calls(Type = typeof(XmlQualifiedName), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 19)]
	private static void XDR_EndRoot(XdrBuilder builder) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DeclBaseInfo), Member = "Reset", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private static void XDR_InitAttribute(XdrBuilder builder, object obj) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XdrBuilder), Member = "SendValidationEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private static void XDR_InitAttributeDtType(XdrBuilder builder, object obj) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SchemaAttDef), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	[ContainsUnimplementedInstructions]
	private static void XDR_InitAttributeType(XdrBuilder builder, object obj) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XdrBuilder), Member = "SendValidationEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private static void XDR_InitElement(XdrBuilder builder, object obj) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XdrBuilder), Member = "SendValidationEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private static void XDR_InitElementDtType(XdrBuilder builder, object obj) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SchemaElementDecl), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(ParticleContentValidator), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaContentType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Hashtable), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	private static void XDR_InitElementType(XdrBuilder builder, object obj) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XdrBuilder), Member = "SendValidationEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(HWStack), Member = "Push", ReturnType = typeof(object))]
	[Calls(Type = typeof(HWStack), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XdrBuilder), Member = "AddOrder", ReturnType = typeof(void))]
	[Calls(Type = typeof(ParticleContentValidator), Member = "OpenGroup", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private static void XDR_InitGroup(XdrBuilder builder, object obj) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 4)]
	private static void XDR_InitRoot(XdrBuilder builder, object obj) { }

}

