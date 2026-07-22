namespace System.Xml.Schema;

internal abstract class DatatypeImplementation : XmlSchemaDatatype
{
	private class SchemaDatatypeMap : IComparable
	{
		private string name; //Field offset: 0x10
		private DatatypeImplementation type; //Field offset: 0x18
		private int parentIndex; //Field offset: 0x20

		public string Name
		{
			[CallerCount(Count = 106)]
			[DeduplicatedMethod]
			 get { } //Length: 5
		}

		public int ParentIndex
		{
			[CallerCount(Count = 2)]
			[DeduplicatedMethod]
			 get { } //Length: 4
		}

		[CallerCount(Count = 40)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		internal SchemaDatatypeMap(string name, DatatypeImplementation type) { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		internal SchemaDatatypeMap(string name, DatatypeImplementation type, int parentIndex) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(string), Member = "Compare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(StringComparison)}, ReturnType = typeof(int))]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		public override int CompareTo(object obj) { }

		[CallerCount(Count = 106)]
		[DeduplicatedMethod]
		public string get_Name() { }

		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		public int get_ParentIndex() { }

		[CallerCount(Count = 43)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		public static DatatypeImplementation op_Explicit(SchemaDatatypeMap sdm) { }

	}

	private static Hashtable builtinTypes; //Field offset: 0x0
	private static XmlSchemaSimpleType[] enumToTypeCode; //Field offset: 0x8
	private static XmlSchemaSimpleType anySimpleType; //Field offset: 0x10
	private static XmlSchemaSimpleType anyAtomicType; //Field offset: 0x18
	private static XmlSchemaSimpleType untypedAtomicType; //Field offset: 0x20
	private static XmlSchemaSimpleType yearMonthDurationType; //Field offset: 0x28
	private static XmlSchemaSimpleType dayTimeDurationType; //Field offset: 0x30
	private static XmlSchemaSimpleType normalizedStringTypeV1Compat; //Field offset: 0x38
	private static XmlSchemaSimpleType tokenTypeV1Compat; //Field offset: 0x40
	internal static XmlQualifiedName QnAnySimpleType; //Field offset: 0x48
	internal static XmlQualifiedName QnAnyType; //Field offset: 0x50
	internal static FacetsChecker stringFacetsChecker; //Field offset: 0x58
	internal static FacetsChecker miscFacetsChecker; //Field offset: 0x60
	internal static FacetsChecker numeric2FacetsChecker; //Field offset: 0x68
	internal static FacetsChecker binaryFacetsChecker; //Field offset: 0x70
	internal static FacetsChecker dateTimeFacetsChecker; //Field offset: 0x78
	internal static FacetsChecker durationFacetsChecker; //Field offset: 0x80
	internal static FacetsChecker listFacetsChecker; //Field offset: 0x88
	internal static FacetsChecker qnameFacetsChecker; //Field offset: 0x90
	internal static FacetsChecker unionFacetsChecker; //Field offset: 0x98
	private static readonly DatatypeImplementation c_anySimpleType; //Field offset: 0xA0
	private static readonly DatatypeImplementation c_anyURI; //Field offset: 0xA8
	private static readonly DatatypeImplementation c_base64Binary; //Field offset: 0xB0
	private static readonly DatatypeImplementation c_boolean; //Field offset: 0xB8
	private static readonly DatatypeImplementation c_byte; //Field offset: 0xC0
	private static readonly DatatypeImplementation c_char; //Field offset: 0xC8
	private static readonly DatatypeImplementation c_date; //Field offset: 0xD0
	private static readonly DatatypeImplementation c_dateTime; //Field offset: 0xD8
	private static readonly DatatypeImplementation c_dateTimeNoTz; //Field offset: 0xE0
	private static readonly DatatypeImplementation c_dateTimeTz; //Field offset: 0xE8
	private static readonly DatatypeImplementation c_day; //Field offset: 0xF0
	private static readonly DatatypeImplementation c_decimal; //Field offset: 0xF8
	private static readonly DatatypeImplementation c_double; //Field offset: 0x100
	private static readonly DatatypeImplementation c_doubleXdr; //Field offset: 0x108
	private static readonly DatatypeImplementation c_duration; //Field offset: 0x110
	private static readonly DatatypeImplementation c_ENTITY; //Field offset: 0x118
	private static readonly DatatypeImplementation c_ENTITIES; //Field offset: 0x120
	private static readonly DatatypeImplementation c_ENUMERATION; //Field offset: 0x128
	private static readonly DatatypeImplementation c_fixed; //Field offset: 0x130
	private static readonly DatatypeImplementation c_float; //Field offset: 0x138
	private static readonly DatatypeImplementation c_floatXdr; //Field offset: 0x140
	private static readonly DatatypeImplementation c_hexBinary; //Field offset: 0x148
	private static readonly DatatypeImplementation c_ID; //Field offset: 0x150
	private static readonly DatatypeImplementation c_IDREF; //Field offset: 0x158
	private static readonly DatatypeImplementation c_IDREFS; //Field offset: 0x160
	private static readonly DatatypeImplementation c_int; //Field offset: 0x168
	private static readonly DatatypeImplementation c_integer; //Field offset: 0x170
	private static readonly DatatypeImplementation c_language; //Field offset: 0x178
	private static readonly DatatypeImplementation c_long; //Field offset: 0x180
	private static readonly DatatypeImplementation c_month; //Field offset: 0x188
	private static readonly DatatypeImplementation c_monthDay; //Field offset: 0x190
	private static readonly DatatypeImplementation c_Name; //Field offset: 0x198
	private static readonly DatatypeImplementation c_NCName; //Field offset: 0x1A0
	private static readonly DatatypeImplementation c_negativeInteger; //Field offset: 0x1A8
	private static readonly DatatypeImplementation c_NMTOKEN; //Field offset: 0x1B0
	private static readonly DatatypeImplementation c_NMTOKENS; //Field offset: 0x1B8
	private static readonly DatatypeImplementation c_nonNegativeInteger; //Field offset: 0x1C0
	private static readonly DatatypeImplementation c_nonPositiveInteger; //Field offset: 0x1C8
	private static readonly DatatypeImplementation c_normalizedString; //Field offset: 0x1D0
	private static readonly DatatypeImplementation c_NOTATION; //Field offset: 0x1D8
	private static readonly DatatypeImplementation c_positiveInteger; //Field offset: 0x1E0
	private static readonly DatatypeImplementation c_QName; //Field offset: 0x1E8
	private static readonly DatatypeImplementation c_QNameXdr; //Field offset: 0x1F0
	private static readonly DatatypeImplementation c_short; //Field offset: 0x1F8
	private static readonly DatatypeImplementation c_string; //Field offset: 0x200
	private static readonly DatatypeImplementation c_time; //Field offset: 0x208
	private static readonly DatatypeImplementation c_timeNoTz; //Field offset: 0x210
	private static readonly DatatypeImplementation c_timeTz; //Field offset: 0x218
	private static readonly DatatypeImplementation c_token; //Field offset: 0x220
	private static readonly DatatypeImplementation c_unsignedByte; //Field offset: 0x228
	private static readonly DatatypeImplementation c_unsignedInt; //Field offset: 0x230
	private static readonly DatatypeImplementation c_unsignedLong; //Field offset: 0x238
	private static readonly DatatypeImplementation c_unsignedShort; //Field offset: 0x240
	private static readonly DatatypeImplementation c_uuid; //Field offset: 0x248
	private static readonly DatatypeImplementation c_year; //Field offset: 0x250
	private static readonly DatatypeImplementation c_yearMonth; //Field offset: 0x258
	internal static readonly DatatypeImplementation c_normalizedStringV1Compat; //Field offset: 0x260
	internal static readonly DatatypeImplementation c_tokenV1Compat; //Field offset: 0x268
	private static readonly DatatypeImplementation c_anyAtomicType; //Field offset: 0x270
	private static readonly DatatypeImplementation c_dayTimeDuration; //Field offset: 0x278
	private static readonly DatatypeImplementation c_untypedAtomicType; //Field offset: 0x280
	private static readonly DatatypeImplementation c_yearMonthDuration; //Field offset: 0x288
	private static readonly DatatypeImplementation[] c_tokenizedTypes; //Field offset: 0x290
	private static readonly DatatypeImplementation[] c_tokenizedTypesXsd; //Field offset: 0x298
	private static readonly SchemaDatatypeMap[] c_XdrTypes; //Field offset: 0x2A0
	private static readonly SchemaDatatypeMap[] c_XsdTypes; //Field offset: 0x2A8
	private XmlSchemaDatatypeVariety variety; //Field offset: 0x10
	private RestrictionFacets restriction; //Field offset: 0x18
	private DatatypeImplementation baseType; //Field offset: 0x20
	private XmlValueConverter valueConverter; //Field offset: 0x28
	private XmlSchemaType parentSchemaType; //Field offset: 0x30

	internal static XmlSchemaSimpleType AnySimpleType
	{
		[CallerCount(Count = 0)]
		internal get { } //Length: 79
	}

	protected DatatypeImplementation Base
	{
		[CallerCount(Count = 12)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	internal virtual XmlSchemaWhiteSpace BuiltInWhitespaceFacet
	{
		[CallerCount(Count = 182)]
		[DeduplicatedMethod]
		internal get { } //Length: 3
	}

	internal virtual FacetsChecker FacetsChecker
	{
		[CallerCount(Count = 0)]
		internal get { } //Length: 79
	}

	internal virtual bool HasLexicalFacets
	{
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		internal get { } //Length: 31
	}

	internal virtual bool HasValueFacets
	{
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		internal get { } //Length: 31
	}

	internal abstract Type ListValueType
	{
		internal get { } //Length: 0
	}

	internal virtual RestrictionFacets Restriction
	{
		[CallerCount(Count = 31)]
		[DeduplicatedMethod]
		internal get { } //Length: 5
	}

	public virtual XmlTokenizedType TokenizedType
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 6
	}

	public virtual XmlTypeCode TypeCode
	{
		[CallerCount(Count = 182)]
		[DeduplicatedMethod]
		 get { } //Length: 3
	}

	internal static XmlSchemaSimpleType UntypedAtomicType
	{
		[CallerCount(Count = 0)]
		internal get { } //Length: 79
	}

	internal abstract RestrictionFlags ValidRestrictionFlags
	{
		internal get { } //Length: 0
	}

	internal virtual XmlValueConverter ValueConverter
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		internal get { } //Length: 72
	}

	public virtual Type ValueType
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
		[DeduplicatedMethod]
		 get { } //Length: 50
	}

	public virtual XmlSchemaDatatypeVariety Variety
	{
		[CallerCount(Count = 94)]
		[DeduplicatedMethod]
		 get { } //Length: 4
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DatatypeImplementation), Member = "CreateBuiltinTypes", ReturnType = typeof(void))]
	[Calls(Type = typeof(Datatype_anyAtomicType), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(Datatype_unsignedLong), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(Datatype_unsignedShort), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(Datatype_float), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(DatatypeImplementation), Member = "DeriveByList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(XmlSchemaType)}, ReturnType = typeof(XmlSchemaDatatype))]
	[Calls(Type = typeof(Datatype_string), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(Datatype_double), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(Datatype_decimal), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(Datatype_dateTimeBase), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XsdDateTimeFlags)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Datatype_int), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlQualifiedName), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Hashtable), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(Datatype_duration), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 102)]
	[CallsUnknownMethods(Count = 682)]
	private static DatatypeImplementation() { }

	[CallerCount(Count = 162)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	protected DatatypeImplementation() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	protected int Compare(Byte[] value1, Byte[] value2) { }

	[CalledBy(Type = typeof(DatatypeImplementation), Member = ".cctor", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(XmlQualifiedName), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DatatypeImplementation), Member = "FromTypeName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(DatatypeImplementation))]
	[Calls(Type = typeof(DatatypeImplementation), Member = "StartBuiltinType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName), typeof(XmlSchemaDatatype)}, ReturnType = typeof(XmlSchemaSimpleType))]
	[Calls(Type = typeof(DatatypeImplementation), Member = "FinishBuiltinType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaSimpleType), typeof(XmlSchemaSimpleType)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallsUnknownMethods(Count = 35)]
	internal static void CreateBuiltinTypes() { }

	[CallerCount(Count = 182)]
	[DeduplicatedMethod]
	internal override XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	[CalledBy(Type = typeof(DatatypeImplementation), Member = ".cctor", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(XmlSchemaException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 15)]
	internal XmlSchemaDatatype DeriveByList(int minSize, XmlSchemaType schemaType) { }

	[CallerCount(Count = 0)]
	[ContainsInvalidInstructions]
	internal virtual XmlSchemaDatatype DeriveByList(XmlSchemaType schemaType) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 6)]
	internal virtual XmlSchemaDatatype DeriveByRestriction(XmlSchemaObjectCollection facets, XmlNameTable nameTable, XmlSchemaType schemaType) { }

	[CalledBy(Type = typeof(XmlSchemaDatatype), Member = "DeriveByUnion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaSimpleType[]), typeof(XmlSchemaType)}, ReturnType = typeof(XmlSchemaDatatype))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	internal static DatatypeImplementation DeriveByUnion(XmlSchemaSimpleType[] types, XmlSchemaType schemaType) { }

	[CalledBy(Type = typeof(DatatypeImplementation), Member = "CreateBuiltinTypes", ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(XmlSchemaSimpleTypeRestriction), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSchemaType), Member = "get_QualifiedName", ReturnType = typeof(XmlQualifiedName))]
	[Calls(Type = typeof(XmlSchemaSimpleTypeRestriction), Member = "set_BaseTypeName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSchemaSimpleTypeList), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 7)]
	internal static void FinishBuiltinType(XmlSchemaSimpleType derivedType, XmlSchemaSimpleType baseType) { }

	[CalledBy(Type = typeof(DatatypeImplementation), Member = "CreateBuiltinTypes", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Array), Member = "BinarySearch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(object), typeof(IComparer)}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 2)]
	private static DatatypeImplementation FromTypeName(string name) { }

	[CalledBy(Type = typeof(XdrBuilder), Member = "XDR_BuildElementType_DtType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XdrBuilder), typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XdrBuilder), Member = "XDR_BuildAttributeType_DtType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XdrBuilder), typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XdrBuilder), Member = "CheckDatatype", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(XmlSchemaDatatype))]
	[CalledBy(Type = typeof(XdrValidator), Member = "ThoroughGetElementDecl", ReturnType = typeof(SchemaElementDecl))]
	[CalledBy(Type = typeof(XmlSchemaDatatype), Member = "FromXdrName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(XmlSchemaDatatype))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(Array), Member = "BinarySearch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(object), typeof(IComparer)}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 2)]
	internal static DatatypeImplementation FromXdrName(string name) { }

	[CalledBy(Type = "System.Xml.Schema.XdrBuilder+XdrAttributeEntry", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Token), typeof(XmlTokenizedType), "System.Xml.Schema.XdrBuilder+XdrBuildFunction"}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Xml.Schema.XdrBuilder+XdrAttributeEntry", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Token), typeof(XmlTokenizedType), typeof(int), "System.Xml.Schema.XdrBuilder+XdrBuildFunction"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XdrBuilder), Member = "XDR_EndAttributeType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XdrBuilder)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XdrBuilder), Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSchemaDatatype), Member = "FromXmlTokenizedType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlTokenizedType)}, ReturnType = typeof(XmlSchemaDatatype))]
	[CallerCount(Count = 38)]
	[CallsUnknownMethods(Count = 2)]
	internal static DatatypeImplementation FromXmlTokenizedType(XmlTokenizedType token) { }

	[CalledBy(Type = typeof(XmlSchemaDatatype), Member = "FromXmlTokenizedTypeXsd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlTokenizedType)}, ReturnType = typeof(XmlSchemaDatatype))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	internal static DatatypeImplementation FromXmlTokenizedTypeXsd(XmlTokenizedType token) { }

	[CallerCount(Count = 0)]
	internal static XmlSchemaSimpleType get_AnySimpleType() { }

	[CallerCount(Count = 12)]
	[DeduplicatedMethod]
	protected DatatypeImplementation get_Base() { }

	[CallerCount(Count = 182)]
	[DeduplicatedMethod]
	internal virtual XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	[CallerCount(Count = 0)]
	internal virtual FacetsChecker get_FacetsChecker() { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	internal virtual bool get_HasLexicalFacets() { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	internal virtual bool get_HasValueFacets() { }

	internal abstract Type get_ListValueType() { }

	[CallerCount(Count = 31)]
	[DeduplicatedMethod]
	internal virtual RestrictionFacets get_Restriction() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public virtual XmlTokenizedType get_TokenizedType() { }

	[CallerCount(Count = 182)]
	[DeduplicatedMethod]
	public virtual XmlTypeCode get_TypeCode() { }

	[CallerCount(Count = 0)]
	internal static XmlSchemaSimpleType get_UntypedAtomicType() { }

	internal abstract RestrictionFlags get_ValidRestrictionFlags() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	internal virtual XmlValueConverter get_ValueConverter() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[DeduplicatedMethod]
	public virtual Type get_ValueType() { }

	[CallerCount(Count = 94)]
	[DeduplicatedMethod]
	public virtual XmlSchemaDatatypeVariety get_Variety() { }

	[CallerCount(Count = 0)]
	internal static XmlSchemaSimpleType[] GetBuiltInTypes() { }

	[CalledBy(Type = typeof(SchemaCollectionCompiler), Member = "GetSimpleType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName)}, ReturnType = typeof(XmlSchemaSimpleType))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DatatypeImplementation), Member = "GetSimpleTypeFromTypeCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlTypeCode)}, ReturnType = typeof(XmlSchemaSimpleType))]
	[Calls(Type = typeof(SchemaElementDecl), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaDatatype)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSchemaType), Member = "set_ElementDecl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SchemaElementDecl)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSchemaType), Member = "get_ElementDecl", ReturnType = typeof(SchemaElementDecl))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	internal static XmlSchemaSimpleType GetNormalizedStringTypeV1Compat() { }

	[CalledBy(Type = typeof(DatatypeImplementation), Member = "IsComparable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaDatatype)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(XmlSchemaType), Member = "get_TypeCode", ReturnType = typeof(XmlTypeCode))]
	[CallsUnknownMethods(Count = 2)]
	internal static XmlTypeCode GetPrimitiveTypeCode(XmlTypeCode typeCode) { }

	[CalledBy(Type = typeof(DatatypeImplementation), Member = "GetNormalizedStringTypeV1Compat", ReturnType = typeof(XmlSchemaSimpleType))]
	[CalledBy(Type = typeof(DatatypeImplementation), Member = "GetTokenTypeV1Compat", ReturnType = typeof(XmlSchemaSimpleType))]
	[CalledBy(Type = typeof(Datatype_List), Member = "CreateValueConverter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaType)}, ReturnType = typeof(XmlValueConverter))]
	[CalledBy(Type = "System.Xml.Schema.FacetsChecker+FacetsCompiler", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DatatypeImplementation), typeof(RestrictionFacets)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Preprocessor), Member = "Preprocess", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchema), typeof(string), typeof(ArrayList)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSchemaType), Member = "GetBuiltInSimpleType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlTypeCode)}, ReturnType = typeof(XmlSchemaSimpleType))]
	[CalledBy(Type = typeof(XmlBaseConverter), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaType)}, ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[CallsUnknownMethods(Count = 2)]
	internal static XmlSchemaSimpleType GetSimpleTypeFromTypeCode(XmlTypeCode typeCode) { }

	[CalledBy(Type = typeof(SchemaCollectionCompiler), Member = "GetSimpleType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName)}, ReturnType = typeof(XmlSchemaSimpleType))]
	[CalledBy(Type = typeof(SchemaCollectionCompiler), Member = "GetAnySchemaType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName)}, ReturnType = typeof(XmlSchemaType))]
	[CalledBy(Type = typeof(Compiler), Member = "GetSimpleType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName)}, ReturnType = typeof(XmlSchemaSimpleType))]
	[CalledBy(Type = typeof(Compiler), Member = "GetAnySchemaType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName)}, ReturnType = typeof(XmlSchemaType))]
	[CalledBy(Type = typeof(XmlSchemaDocumentation), Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSchemaType), Member = "GetBuiltInSimpleType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName)}, ReturnType = typeof(XmlSchemaSimpleType))]
	[CalledBy(Type = typeof(XmlSchemaValidator), Member = "CheckXsiTypeAndNil", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SchemaElementDecl), typeof(string), typeof(string), typeof(Boolean&)}, ReturnType = typeof(SchemaElementDecl))]
	[CalledBy(Type = typeof(XsdValidator), Member = "ProcessElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XsdValidator), Member = "ThoroughGetElementDecl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SchemaElementDecl), typeof(XmlQualifiedName), typeof(string)}, ReturnType = typeof(SchemaElementDecl))]
	[CallerCount(Count = 9)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	internal static XmlSchemaSimpleType GetSimpleTypeFromXsdType(XmlQualifiedName qname) { }

	[CalledBy(Type = typeof(SchemaCollectionCompiler), Member = "GetSimpleType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName)}, ReturnType = typeof(XmlSchemaSimpleType))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DatatypeImplementation), Member = "GetSimpleTypeFromTypeCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlTypeCode)}, ReturnType = typeof(XmlSchemaSimpleType))]
	[Calls(Type = typeof(SchemaElementDecl), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaDatatype)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSchemaType), Member = "set_ElementDecl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SchemaElementDecl)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSchemaType), Member = "get_ElementDecl", ReturnType = typeof(SchemaElementDecl))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	internal static XmlSchemaSimpleType GetTokenTypeV1Compat() { }

	[CalledBy(Type = typeof(DatatypeImplementation), Member = "ParseValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(XmlNameTable), typeof(IXmlNamespaceResolver)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(DatatypeImplementation), Member = "ParseValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(XmlNameTable), typeof(IXmlNamespaceResolver), typeof(bool)}, ReturnType = typeof(object))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(XmlSchemaType), Member = "get_QualifiedName", ReturnType = typeof(XmlQualifiedName))]
	[Calls(Type = typeof(XmlQualifiedName), Member = "get_IsEmpty", ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlSchemaDatatype), Member = "get_TypeCodeString", ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	internal string GetTypeName() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DatatypeImplementation), Member = "GetPrimitiveTypeCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlTypeCode)}, ReturnType = typeof(XmlTypeCode))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	internal virtual bool IsComparable(XmlSchemaDatatype dtype) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 4)]
	[ContainsUnimplementedInstructions]
	public virtual bool IsDerivedFrom(XmlSchemaDatatype datatype) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	internal virtual bool IsEqual(object o1, object o2) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DatatypeImplementation), Member = "GetTypeName", ReturnType = typeof(string))]
	[Calls(Type = typeof(XmlSchemaException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[]), typeof(Exception), typeof(string), typeof(int), typeof(int), typeof(XmlSchemaObject)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 14)]
	[ContainsUnimplementedInstructions]
	public virtual object ParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DatatypeImplementation), Member = "GetTypeName", ReturnType = typeof(string))]
	[Calls(Type = typeof(XmlSchemaException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[]), typeof(Exception), typeof(string), typeof(int), typeof(int), typeof(XmlSchemaObject)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 13)]
	internal virtual object ParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, bool createAtomicValue) { }

	[CalledBy(Type = typeof(DatatypeImplementation), Member = "CreateBuiltinTypes", ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(XmlSchemaType), Member = "SetQualifiedName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SchemaElementDecl), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaDatatype)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSchemaType), Member = "set_ElementDecl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SchemaElementDecl)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSchemaType), Member = "get_ElementDecl", ReturnType = typeof(SchemaElementDecl))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	internal static XmlSchemaSimpleType StartBuiltinType(XmlQualifiedName qname, XmlSchemaDatatype dataType) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 14)]
	[CallsUnknownMethods(Count = 7)]
	internal virtual Exception TryParseValue(object value, XmlNameTable nameTable, IXmlNamespaceResolver namespaceResolver, out object typedValue) { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	internal virtual void VerifySchemaValid(XmlSchemaObjectTable notations, XmlSchemaObject caller) { }

}

