namespace System.Xml.Schema;

internal abstract class XmlBaseConverter : XmlValueConverter
{
	protected static readonly Type ICollectionType; //Field offset: 0x0
	protected static readonly Type IEnumerableType; //Field offset: 0x8
	protected static readonly Type IListType; //Field offset: 0x10
	protected static readonly Type ObjectArrayType; //Field offset: 0x18
	protected static readonly Type StringArrayType; //Field offset: 0x20
	protected static readonly Type XmlAtomicValueArrayType; //Field offset: 0x28
	protected static readonly Type DecimalType; //Field offset: 0x30
	protected static readonly Type Int32Type; //Field offset: 0x38
	protected static readonly Type Int64Type; //Field offset: 0x40
	protected static readonly Type StringType; //Field offset: 0x48
	protected static readonly Type XmlAtomicValueType; //Field offset: 0x50
	protected static readonly Type ObjectType; //Field offset: 0x58
	protected static readonly Type ByteType; //Field offset: 0x60
	protected static readonly Type Int16Type; //Field offset: 0x68
	protected static readonly Type SByteType; //Field offset: 0x70
	protected static readonly Type UInt16Type; //Field offset: 0x78
	protected static readonly Type UInt32Type; //Field offset: 0x80
	protected static readonly Type UInt64Type; //Field offset: 0x88
	protected static readonly Type XPathItemType; //Field offset: 0x90
	protected static readonly Type DoubleType; //Field offset: 0x98
	protected static readonly Type SingleType; //Field offset: 0xA0
	protected static readonly Type DateTimeType; //Field offset: 0xA8
	protected static readonly Type DateTimeOffsetType; //Field offset: 0xB0
	protected static readonly Type BooleanType; //Field offset: 0xB8
	protected static readonly Type ByteArrayType; //Field offset: 0xC0
	protected static readonly Type XmlQualifiedNameType; //Field offset: 0xC8
	protected static readonly Type UriType; //Field offset: 0xD0
	protected static readonly Type TimeSpanType; //Field offset: 0xD8
	protected static readonly Type XPathNavigatorType; //Field offset: 0xE0
	private XmlSchemaType schemaType; //Field offset: 0x10
	private XmlTypeCode typeCode; //Field offset: 0x18
	private Type clrTypeDefault; //Field offset: 0x20

	protected Type DefaultClrType
	{
		[CallerCount(Count = 12)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	protected XmlSchemaType SchemaType
	{
		[CallerCount(Count = 106)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	protected XmlTypeCode TypeCode
	{
		[CallerCount(Count = 7)]
		[DeduplicatedMethod]
		 get { } //Length: 4
	}

	protected string XmlTypeName
	{
		[CalledBy(Type = typeof(XmlBaseConverter), Member = "CreateInvalidClrMappingException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Type)}, ReturnType = typeof(Exception))]
		[CalledBy(Type = typeof(XmlUntypedConverter), Member = "ChangeListType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Type), typeof(IXmlNamespaceResolver)}, ReturnType = typeof(object))]
		[CalledBy(Type = typeof(XmlListConverter), Member = "CreateInvalidClrMappingException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Type)}, ReturnType = typeof(Exception))]
		[CallerCount(Count = 6)]
		[Calls(Type = typeof(XmlQualifiedName), Member = "get_IsEmpty", ReturnType = typeof(bool))]
		[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 3)]
		 get { } //Length: 514
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[CallsUnknownMethods(Count = 29)]
	private static XmlBaseConverter() { }

	[CalledBy(Type = typeof(XmlUntypedConverter), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlUntypedConverter), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlUntypedConverter), Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlListConverter), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlBaseConverter), typeof(Type)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	protected XmlBaseConverter(XmlBaseConverter converterAtomic, Type clrTypeDefault) { }

	[CalledBy(Type = typeof(XmlNumeric10Converter), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaType)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlUnionConverter), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaType)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlListConverter), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaType)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlUntypedConverter), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlStringConverter), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaType)}, ReturnType = typeof(XmlValueConverter))]
	[CalledBy(Type = typeof(XmlStringConverter), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaType)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlMiscConverter), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaType)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlMiscConverter), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaType)}, ReturnType = typeof(XmlValueConverter))]
	[CalledBy(Type = typeof(XmlBooleanConverter), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaType)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlDateTimeConverter), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaType)}, ReturnType = typeof(XmlValueConverter))]
	[CalledBy(Type = typeof(XmlDateTimeConverter), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaType)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlNumeric2Converter), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaType)}, ReturnType = typeof(XmlValueConverter))]
	[CalledBy(Type = typeof(XmlNumeric2Converter), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaType)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlNumeric10Converter), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaType)}, ReturnType = typeof(XmlValueConverter))]
	[CalledBy(Type = typeof(XmlBooleanConverter), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaType)}, ReturnType = typeof(XmlValueConverter))]
	[CallerCount(Count = 15)]
	[Calls(Type = typeof(DatatypeImplementation), Member = "GetSimpleTypeFromTypeCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlTypeCode)}, ReturnType = typeof(XmlSchemaSimpleType))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 4)]
	protected XmlBaseConverter(XmlSchemaType schemaType) { }

	[CalledBy(Type = typeof(XmlAnyConverter), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlTypeCode)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlAnyConverter), Member = ".cctor", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	protected XmlBaseConverter(XmlTypeCode typeCode) { }

	[CalledBy(Type = typeof(XmlAnyListConverter), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlBaseConverter)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlAnyListConverter), Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlListConverter), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlBaseConverter)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Array), Member = "CreateInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(int)}, ReturnType = typeof(Array))]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	protected XmlBaseConverter(XmlBaseConverter converterAtomic) { }

	[CalledBy(Type = typeof(XmlMiscConverter), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IXmlNamespaceResolver)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(XmlUntypedConverter), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IXmlNamespaceResolver)}, ReturnType = typeof(string))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Uri), Member = "get_OriginalString", ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 1)]
	protected static string AnyUriToString(Uri value) { }

	[CalledBy(Type = typeof(XmlMiscConverter), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IXmlNamespaceResolver)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(XmlUntypedConverter), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IXmlNamespaceResolver)}, ReturnType = typeof(string))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Convert), Member = "ToBase64String", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(string))]
	protected static string Base64BinaryToString(Byte[] value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(XmlBaseConverter), Member = "CreateInvalidClrMappingException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Type)}, ReturnType = typeof(Exception))]
	[CallsUnknownMethods(Count = 3)]
	protected override object ChangeListType(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public virtual object ChangeType(decimal value, Type destinationType) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public virtual object ChangeType(double value, Type destinationType) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public virtual object ChangeType(int value, Type destinationType) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public virtual object ChangeType(long value, Type destinationType) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public virtual object ChangeType(string value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public virtual object ChangeType(object value, Type destinationType) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public virtual object ChangeType(DateTime value, Type destinationType) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public virtual object ChangeType(bool value, Type destinationType) { }

	[CalledBy(Type = typeof(XmlBaseConverter), Member = "ChangeListType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Type), typeof(IXmlNamespaceResolver)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(XmlUntypedConverter), Member = "ChangeListType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Type), typeof(IXmlNamespaceResolver)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(XmlAnyConverter), Member = "ChangeType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Type), typeof(IXmlNamespaceResolver)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(XmlAnyConverter), Member = "ToNavigator", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XPathNavigator)}, ReturnType = typeof(XPathNavigator))]
	[CalledBy(Type = typeof(XmlUnionConverter), Member = "ChangeType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Type), typeof(IXmlNamespaceResolver)}, ReturnType = typeof(object))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(XmlBaseConverter), Member = "get_XmlTypeName", ReturnType = typeof(string))]
	[Calls(Type = typeof(Res), Member = "GetString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(InvalidCastException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 22)]
	protected Exception CreateInvalidClrMappingException(Type sourceType, Type destinationType) { }

	[CalledBy(Type = typeof(XmlDateTimeConverter), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeOffset)}, ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(XsdDateTime), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeOffset), typeof(XsdDateTimeFlags)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XsdDateTime), Member = "ToString", ReturnType = typeof(string))]
	protected static string DateOffsetToString(DateTimeOffset value) { }

	[CalledBy(Type = typeof(XmlDateTimeConverter), Member = "ToDateTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeOffset)}, ReturnType = typeof(DateTime))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DateTimeOffset), Member = "get_LocalDateTime", ReturnType = typeof(DateTime))]
	internal static DateTime DateTimeOffsetToDateTime(DateTimeOffset value) { }

	[CalledBy(Type = typeof(XmlDateTimeConverter), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeOffset)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(XmlUntypedConverter), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeOffset)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(XmlUntypedConverter), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IXmlNamespaceResolver)}, ReturnType = typeof(string))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(XsdDateTime), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeOffset), typeof(XsdDateTimeFlags)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XsdDateTime), Member = "ToString", ReturnType = typeof(string))]
	protected static string DateTimeOffsetToString(DateTimeOffset value) { }

	[CalledBy(Type = typeof(XmlDateTimeConverter), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(XmlUntypedConverter), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(XmlUntypedConverter), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IXmlNamespaceResolver)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(XmlUntypedConverter), Member = "ChangeType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(Type)}, ReturnType = typeof(object))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(XsdDateTime), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(XsdDateTimeFlags)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XsdDateTime), Member = "ToString", ReturnType = typeof(string))]
	protected static string DateTimeToString(DateTime value) { }

	[CalledBy(Type = typeof(XmlDateTimeConverter), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime)}, ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(XsdDateTime), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(XsdDateTimeFlags)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XsdDateTime), Member = "ToString", ReturnType = typeof(string))]
	protected static string DateToString(DateTime value) { }

	[CalledBy(Type = typeof(XmlMiscConverter), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IXmlNamespaceResolver)}, ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(XsdDuration), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpan), typeof(DurationType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XsdDuration), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DurationType)}, ReturnType = typeof(string))]
	protected static string DayTimeDurationToString(TimeSpan value) { }

	[CalledBy(Type = "System.Xml.Schema.FacetsChecker+FacetsCompiler", Member = "CompileLengthFacet", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaFacet)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Xml.Schema.FacetsChecker+FacetsCompiler", Member = "CompileMinLengthFacet", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaFacet)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Xml.Schema.FacetsChecker+FacetsCompiler", Member = "CompileMaxLengthFacet", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaFacet)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Xml.Schema.FacetsChecker+FacetsCompiler", Member = "CompileTotalDigitsFacet", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaFacet)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Xml.Schema.FacetsChecker+FacetsCompiler", Member = "CompileFractionDigitsFacet", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaFacet)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlNumeric10Converter), Member = "ToInt32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(XmlNumeric10Converter), Member = "ToInt32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(XmlNumeric10Converter), Member = "ChangeType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal), typeof(Type)}, ReturnType = typeof(object))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(Decimal), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Decimal), Member = "op_LessThan", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal), typeof(Decimal)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Decimal), Member = "op_GreaterThan", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal), typeof(Decimal)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Decimal), Member = "op_Explicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(XmlConvert), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Res), Member = "GetString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(OverflowException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 12)]
	internal static int DecimalToInt32(decimal value) { }

	[CalledBy(Type = typeof(XmlNumeric10Converter), Member = "ToInt64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(long))]
	[CalledBy(Type = typeof(XmlNumeric10Converter), Member = "ToInt64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(long))]
	[CalledBy(Type = typeof(XmlNumeric10Converter), Member = "ChangeType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal), typeof(Type)}, ReturnType = typeof(object))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Decimal), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Decimal), Member = "op_LessThan", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal), typeof(Decimal)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Decimal), Member = "op_GreaterThan", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal), typeof(Decimal)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Decimal), Member = "op_Explicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal)}, ReturnType = typeof(long))]
	[Calls(Type = typeof(XmlConvert), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Res), Member = "GetString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(OverflowException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 12)]
	protected static long DecimalToInt64(decimal value) { }

	[CalledBy(Type = typeof(XmlNumeric10Converter), Member = "ChangeType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Type), typeof(IXmlNamespaceResolver)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(XmlNumeric10Converter), Member = "ChangeTypeWildcardSource", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Type), typeof(IXmlNamespaceResolver)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(XmlUntypedConverter), Member = "ChangeType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Type), typeof(IXmlNamespaceResolver)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(XmlUntypedConverter), Member = "ChangeType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Type), typeof(IXmlNamespaceResolver)}, ReturnType = typeof(object))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Decimal), Member = "op_LessThan", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal), typeof(Decimal)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Decimal), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ulong)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Decimal), Member = "op_GreaterThan", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal), typeof(Decimal)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Decimal), Member = "op_Explicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal)}, ReturnType = typeof(ulong))]
	[Calls(Type = typeof(XmlConvert), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Res), Member = "GetString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(OverflowException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 12)]
	protected static ulong DecimalToUInt64(decimal value) { }

	[CalledBy(Type = typeof(XmlMiscConverter), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IXmlNamespaceResolver)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(XmlUntypedConverter), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IXmlNamespaceResolver)}, ReturnType = typeof(string))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(XsdDuration), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpan), typeof(DurationType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XsdDuration), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DurationType)}, ReturnType = typeof(string))]
	protected static string DurationToString(TimeSpan value) { }

	[CalledBy(Type = typeof(XmlDateTimeConverter), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeOffset)}, ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(XsdDateTime), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeOffset), typeof(XsdDateTimeFlags)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XsdDateTime), Member = "ToString", ReturnType = typeof(string))]
	protected static string GDayOffsetToString(DateTimeOffset value) { }

	[CalledBy(Type = typeof(XmlDateTimeConverter), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime)}, ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(XsdDateTime), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(XsdDateTimeFlags)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XsdDateTime), Member = "ToString", ReturnType = typeof(string))]
	protected static string GDayToString(DateTime value) { }

	[CallerCount(Count = 12)]
	[DeduplicatedMethod]
	protected Type get_DefaultClrType() { }

	[CallerCount(Count = 106)]
	[DeduplicatedMethod]
	protected XmlSchemaType get_SchemaType() { }

	[CallerCount(Count = 7)]
	[DeduplicatedMethod]
	protected XmlTypeCode get_TypeCode() { }

	[CalledBy(Type = typeof(XmlBaseConverter), Member = "CreateInvalidClrMappingException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Type)}, ReturnType = typeof(Exception))]
	[CalledBy(Type = typeof(XmlUntypedConverter), Member = "ChangeListType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Type), typeof(IXmlNamespaceResolver)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(XmlListConverter), Member = "CreateInvalidClrMappingException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Type)}, ReturnType = typeof(Exception))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(XmlQualifiedName), Member = "get_IsEmpty", ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	protected string get_XmlTypeName() { }

	[CalledBy(Type = typeof(XmlDateTimeConverter), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeOffset)}, ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(XsdDateTime), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeOffset), typeof(XsdDateTimeFlags)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XsdDateTime), Member = "ToString", ReturnType = typeof(string))]
	protected static string GMonthDayOffsetToString(DateTimeOffset value) { }

	[CalledBy(Type = typeof(XmlDateTimeConverter), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime)}, ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(XsdDateTime), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(XsdDateTimeFlags)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XsdDateTime), Member = "ToString", ReturnType = typeof(string))]
	protected static string GMonthDayToString(DateTime value) { }

	[CalledBy(Type = typeof(XmlDateTimeConverter), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeOffset)}, ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(XsdDateTime), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeOffset), typeof(XsdDateTimeFlags)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XsdDateTime), Member = "ToString", ReturnType = typeof(string))]
	protected static string GMonthOffsetToString(DateTimeOffset value) { }

	[CalledBy(Type = typeof(XmlDateTimeConverter), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime)}, ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(XsdDateTime), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(XsdDateTimeFlags)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XsdDateTime), Member = "ToString", ReturnType = typeof(string))]
	protected static string GMonthToString(DateTime value) { }

	[CalledBy(Type = typeof(XmlDateTimeConverter), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeOffset)}, ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(XsdDateTime), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeOffset), typeof(XsdDateTimeFlags)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XsdDateTime), Member = "ToString", ReturnType = typeof(string))]
	protected static string GYearMonthOffsetToString(DateTimeOffset value) { }

	[CalledBy(Type = typeof(XmlDateTimeConverter), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime)}, ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(XsdDateTime), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(XsdDateTimeFlags)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XsdDateTime), Member = "ToString", ReturnType = typeof(string))]
	protected static string GYearMonthToString(DateTime value) { }

	[CalledBy(Type = typeof(XmlDateTimeConverter), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeOffset)}, ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(XsdDateTime), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeOffset), typeof(XsdDateTimeFlags)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XsdDateTime), Member = "ToString", ReturnType = typeof(string))]
	protected static string GYearOffsetToString(DateTimeOffset value) { }

	[CalledBy(Type = typeof(XmlDateTimeConverter), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime)}, ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(XsdDateTime), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(XsdDateTimeFlags)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XsdDateTime), Member = "ToString", ReturnType = typeof(string))]
	protected static string GYearToString(DateTime value) { }

	[CalledBy(Type = typeof(XmlNumeric10Converter), Member = "ChangeType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Type), typeof(IXmlNamespaceResolver)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(XmlNumeric10Converter), Member = "ChangeTypeWildcardSource", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Type), typeof(IXmlNamespaceResolver)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(XmlUntypedConverter), Member = "ChangeType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Type), typeof(IXmlNamespaceResolver)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(XmlUntypedConverter), Member = "ChangeType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Type), typeof(IXmlNamespaceResolver)}, ReturnType = typeof(object))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(XmlConvert), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Res), Member = "GetString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(OverflowException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 12)]
	protected static byte Int32ToByte(int value) { }

	[CalledBy(Type = typeof(XmlNumeric10Converter), Member = "ChangeType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Type), typeof(IXmlNamespaceResolver)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(XmlNumeric10Converter), Member = "ChangeTypeWildcardSource", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Type), typeof(IXmlNamespaceResolver)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(XmlUntypedConverter), Member = "ChangeType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Type), typeof(IXmlNamespaceResolver)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(XmlUntypedConverter), Member = "ChangeType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Type), typeof(IXmlNamespaceResolver)}, ReturnType = typeof(object))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(XmlConvert), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Res), Member = "GetString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(OverflowException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 12)]
	protected static short Int32ToInt16(int value) { }

	[CalledBy(Type = typeof(XmlNumeric10Converter), Member = "ChangeType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Type), typeof(IXmlNamespaceResolver)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(XmlNumeric10Converter), Member = "ChangeTypeWildcardSource", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Type), typeof(IXmlNamespaceResolver)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(XmlUntypedConverter), Member = "ChangeType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Type), typeof(IXmlNamespaceResolver)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(XmlUntypedConverter), Member = "ChangeType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Type), typeof(IXmlNamespaceResolver)}, ReturnType = typeof(object))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(XmlConvert), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Res), Member = "GetString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(OverflowException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 12)]
	protected static sbyte Int32ToSByte(int value) { }

	[CalledBy(Type = typeof(XmlNumeric10Converter), Member = "ChangeType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Type), typeof(IXmlNamespaceResolver)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(XmlNumeric10Converter), Member = "ChangeTypeWildcardSource", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Type), typeof(IXmlNamespaceResolver)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(XmlUntypedConverter), Member = "ChangeType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Type), typeof(IXmlNamespaceResolver)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(XmlUntypedConverter), Member = "ChangeType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Type), typeof(IXmlNamespaceResolver)}, ReturnType = typeof(object))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(XmlConvert), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Res), Member = "GetString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(OverflowException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 12)]
	protected static ushort Int32ToUInt16(int value) { }

	[CalledBy(Type = typeof(XmlNumeric10Converter), Member = "ToInt32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(XmlNumeric10Converter), Member = "ToInt32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(XmlNumeric10Converter), Member = "ChangeType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(Type)}, ReturnType = typeof(object))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(XmlConvert), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Res), Member = "GetString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(OverflowException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 12)]
	protected static int Int64ToInt32(long value) { }

	[CalledBy(Type = typeof(XmlNumeric10Converter), Member = "ChangeType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Type), typeof(IXmlNamespaceResolver)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(XmlNumeric10Converter), Member = "ChangeTypeWildcardSource", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Type), typeof(IXmlNamespaceResolver)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(XmlUntypedConverter), Member = "ChangeType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Type), typeof(IXmlNamespaceResolver)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(XmlUntypedConverter), Member = "ChangeType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Type), typeof(IXmlNamespaceResolver)}, ReturnType = typeof(object))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(XmlConvert), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Res), Member = "GetString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(OverflowException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 12)]
	protected static uint Int64ToUInt32(long value) { }

	[CalledBy(Type = typeof(XmlMiscConverter), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IXmlNamespaceResolver)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(XmlMiscConverter), Member = "ChangeType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Type), typeof(IXmlNamespaceResolver)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(XmlUntypedConverter), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IXmlNamespaceResolver)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(XmlAnyConverter), Member = "ChangeType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Type), typeof(IXmlNamespaceResolver)}, ReturnType = typeof(object))]
	[CallerCount(Count = 12)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	protected static bool IsDerivedFrom(Type derivedType, Type baseType) { }

	[CalledBy(Type = typeof(XmlMiscConverter), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IXmlNamespaceResolver)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(XmlUntypedConverter), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IXmlNamespaceResolver)}, ReturnType = typeof(string))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Res), Member = "GetString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(InvalidCastException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 16)]
	protected static string QNameToString(XmlQualifiedName qname, IXmlNamespaceResolver nsResolver) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	protected static string QNameToString(XmlQualifiedName name) { }

	[CalledBy(Type = typeof(XmlMiscConverter), Member = "ChangeType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Type), typeof(IXmlNamespaceResolver)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(XmlMiscConverter), Member = "ChangeType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Type), typeof(IXmlNamespaceResolver)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(XmlUntypedConverter), Member = "ChangeType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Type), typeof(IXmlNamespaceResolver)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(XmlUntypedConverter), Member = "ChangeType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Type), typeof(IXmlNamespaceResolver)}, ReturnType = typeof(object))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(XmlConvert), Member = "TrimString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Convert), Member = "FromBase64String", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Byte[]))]
	protected static Byte[] StringToBase64Binary(string value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XsdDateTime), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(XsdDateTimeFlags)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XsdDateTime), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XsdDateTime)}, ReturnType = typeof(DateTime))]
	protected static DateTime StringToDate(string value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XsdDateTime), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(XsdDateTimeFlags)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XsdDateTime), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XsdDateTime)}, ReturnType = typeof(DateTimeOffset))]
	protected static DateTimeOffset StringToDateOffset(string value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XsdDateTime), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(XsdDateTimeFlags)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XsdDateTime), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XsdDateTime)}, ReturnType = typeof(DateTime))]
	protected static DateTime StringToDateTime(string value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XsdDateTime), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(XsdDateTimeFlags)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XsdDateTime), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XsdDateTime)}, ReturnType = typeof(DateTimeOffset))]
	protected static DateTimeOffset StringToDateTimeOffset(string value) { }

	[CalledBy(Type = typeof(XmlMiscConverter), Member = "ChangeType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Type), typeof(IXmlNamespaceResolver)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(XmlMiscConverter), Member = "ChangeType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Type), typeof(IXmlNamespaceResolver)}, ReturnType = typeof(object))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(XsdDuration), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(DurationType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XsdDuration), Member = "ToTimeSpan", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DurationType)}, ReturnType = typeof(TimeSpan))]
	protected static TimeSpan StringToDayTimeDuration(string value) { }

	[CalledBy(Type = typeof(XmlMiscConverter), Member = "ChangeType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Type), typeof(IXmlNamespaceResolver)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(XmlMiscConverter), Member = "ChangeType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Type), typeof(IXmlNamespaceResolver)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(XmlUntypedConverter), Member = "ChangeType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Type), typeof(IXmlNamespaceResolver)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(XmlUntypedConverter), Member = "ChangeType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Type), typeof(IXmlNamespaceResolver)}, ReturnType = typeof(object))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(XsdDuration), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(DurationType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XsdDuration), Member = "ToTimeSpan", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DurationType)}, ReturnType = typeof(TimeSpan))]
	protected static TimeSpan StringToDuration(string value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XsdDateTime), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(XsdDateTimeFlags)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XsdDateTime), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XsdDateTime)}, ReturnType = typeof(DateTime))]
	protected static DateTime StringToGDay(string value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XsdDateTime), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(XsdDateTimeFlags)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XsdDateTime), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XsdDateTime)}, ReturnType = typeof(DateTimeOffset))]
	protected static DateTimeOffset StringToGDayOffset(string value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XsdDateTime), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(XsdDateTimeFlags)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XsdDateTime), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XsdDateTime)}, ReturnType = typeof(DateTime))]
	protected static DateTime StringToGMonth(string value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XsdDateTime), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(XsdDateTimeFlags)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XsdDateTime), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XsdDateTime)}, ReturnType = typeof(DateTime))]
	protected static DateTime StringToGMonthDay(string value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XsdDateTime), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(XsdDateTimeFlags)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XsdDateTime), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XsdDateTime)}, ReturnType = typeof(DateTimeOffset))]
	protected static DateTimeOffset StringToGMonthDayOffset(string value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XsdDateTime), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(XsdDateTimeFlags)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XsdDateTime), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XsdDateTime)}, ReturnType = typeof(DateTimeOffset))]
	protected static DateTimeOffset StringToGMonthOffset(string value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XsdDateTime), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(XsdDateTimeFlags)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XsdDateTime), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XsdDateTime)}, ReturnType = typeof(DateTime))]
	protected static DateTime StringToGYear(string value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XsdDateTime), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(XsdDateTimeFlags)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XsdDateTime), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XsdDateTime)}, ReturnType = typeof(DateTime))]
	protected static DateTime StringToGYearMonth(string value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XsdDateTime), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(XsdDateTimeFlags)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XsdDateTime), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XsdDateTime)}, ReturnType = typeof(DateTimeOffset))]
	protected static DateTimeOffset StringToGYearMonthOffset(string value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XsdDateTime), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(XsdDateTimeFlags)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XsdDateTime), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XsdDateTime)}, ReturnType = typeof(DateTimeOffset))]
	protected static DateTimeOffset StringToGYearOffset(string value) { }

	[CalledBy(Type = typeof(XmlMiscConverter), Member = "ChangeType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Type), typeof(IXmlNamespaceResolver)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(XmlMiscConverter), Member = "ChangeType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Type), typeof(IXmlNamespaceResolver)}, ReturnType = typeof(object))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(XmlConvert), Member = "TrimString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(XmlConvert), Member = "FromBinHexString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(Byte[]))]
	[Calls(Type = typeof(FormatException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 6)]
	protected static Byte[] StringToHexBinary(string value) { }

	[CalledBy(Type = typeof(XmlMiscConverter), Member = "ChangeType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Type), typeof(IXmlNamespaceResolver)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(XmlMiscConverter), Member = "ChangeType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Type), typeof(IXmlNamespaceResolver)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(XmlUntypedConverter), Member = "ChangeType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Type), typeof(IXmlNamespaceResolver)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(XmlUntypedConverter), Member = "ChangeType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Type), typeof(IXmlNamespaceResolver)}, ReturnType = typeof(object))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(string), Member = "Trim", ReturnType = typeof(string))]
	[Calls(Type = typeof(ValidateNames), Member = "ParseQNameThrow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String&), typeof(String&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlQualifiedName), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Res), Member = "GetString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(InvalidCastException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FormatException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 30)]
	protected static XmlQualifiedName StringToQName(string value, IXmlNamespaceResolver nsResolver) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XsdDateTime), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(XsdDateTimeFlags)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XsdDateTime), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XsdDateTime)}, ReturnType = typeof(DateTime))]
	protected static DateTime StringToTime(string value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XsdDateTime), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(XsdDateTimeFlags)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XsdDateTime), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XsdDateTime)}, ReturnType = typeof(DateTimeOffset))]
	protected static DateTimeOffset StringToTimeOffset(string value) { }

	[CalledBy(Type = typeof(XmlMiscConverter), Member = "ChangeType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Type), typeof(IXmlNamespaceResolver)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(XmlMiscConverter), Member = "ChangeType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Type), typeof(IXmlNamespaceResolver)}, ReturnType = typeof(object))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(XsdDuration), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(DurationType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XsdDuration), Member = "ToTimeSpan", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DurationType)}, ReturnType = typeof(TimeSpan))]
	protected static TimeSpan StringToYearMonthDuration(string value) { }

	[CalledBy(Type = typeof(XmlDateTimeConverter), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeOffset)}, ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(XsdDateTime), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeOffset), typeof(XsdDateTimeFlags)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XsdDateTime), Member = "ToString", ReturnType = typeof(string))]
	protected static string TimeOffsetToString(DateTimeOffset value) { }

	[CalledBy(Type = typeof(XmlDateTimeConverter), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime)}, ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(XsdDateTime), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(XsdDateTimeFlags)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XsdDateTime), Member = "ToString", ReturnType = typeof(string))]
	protected static string TimeToString(DateTime value) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public virtual bool ToBoolean(object value) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public virtual bool ToBoolean(long value) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public virtual bool ToBoolean(int value) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public virtual bool ToBoolean(double value) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public virtual bool ToBoolean(DateTime value) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public virtual bool ToBoolean(string value) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public virtual DateTime ToDateTime(object value) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public virtual DateTime ToDateTime(DateTimeOffset value) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public virtual DateTime ToDateTime(int value) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public virtual DateTime ToDateTime(double value) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public virtual DateTime ToDateTime(bool value) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public virtual DateTime ToDateTime(string value) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public virtual DateTime ToDateTime(long value) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public virtual DateTimeOffset ToDateTimeOffset(DateTime value) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public virtual DateTimeOffset ToDateTimeOffset(string value) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public virtual DateTimeOffset ToDateTimeOffset(object value) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public virtual decimal ToDecimal(string value) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public virtual decimal ToDecimal(object value) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public virtual double ToDouble(long value) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public virtual double ToDouble(object value) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public virtual double ToDouble(int value) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public virtual double ToDouble(DateTime value) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public virtual double ToDouble(bool value) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public virtual double ToDouble(string value) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public virtual int ToInt32(bool value) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public virtual int ToInt32(double value) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public virtual int ToInt32(DateTime value) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public virtual int ToInt32(object value) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public virtual int ToInt32(string value) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public virtual int ToInt32(long value) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public virtual long ToInt64(DateTime value) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public virtual long ToInt64(bool value) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public virtual long ToInt64(double value) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public virtual long ToInt64(int value) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public virtual long ToInt64(string value) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public virtual long ToInt64(object value) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public virtual float ToSingle(double value) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public virtual float ToSingle(string value) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public virtual float ToSingle(object value) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public virtual string ToString(int value) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public virtual string ToString(long value) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public virtual string ToString(float value) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public virtual string ToString(object value, IXmlNamespaceResolver nsResolver) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public virtual string ToString(DateTimeOffset value) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public virtual string ToString(DateTime value) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public virtual string ToString(bool value) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public virtual string ToString(object value) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public virtual string ToString(decimal value) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public virtual string ToString(double value) { }

	[CalledBy(Type = typeof(XmlUntypedConverter), Member = "ToDateTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(DateTime))]
	[CalledBy(Type = typeof(XmlUntypedConverter), Member = "ToDateTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(DateTime))]
	[CalledBy(Type = typeof(XmlUntypedConverter), Member = "ChangeType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Type), typeof(IXmlNamespaceResolver)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(XmlUntypedConverter), Member = "ChangeType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Type), typeof(IXmlNamespaceResolver)}, ReturnType = typeof(object))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(XsdDateTime), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(XsdDateTimeFlags)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XsdDateTime), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XsdDateTime)}, ReturnType = typeof(DateTime))]
	protected static DateTime UntypedAtomicToDateTime(string value) { }

	[CalledBy(Type = typeof(XmlUntypedConverter), Member = "ToDateTimeOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(DateTimeOffset))]
	[CalledBy(Type = typeof(XmlUntypedConverter), Member = "ToDateTimeOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(DateTimeOffset))]
	[CalledBy(Type = typeof(XmlUntypedConverter), Member = "ChangeType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Type), typeof(IXmlNamespaceResolver)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(XmlUntypedConverter), Member = "ChangeType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Type), typeof(IXmlNamespaceResolver)}, ReturnType = typeof(object))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(XsdDateTime), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(XsdDateTimeFlags)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XsdDateTime), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XsdDateTime)}, ReturnType = typeof(DateTimeOffset))]
	protected static DateTimeOffset UntypedAtomicToDateTimeOffset(string value) { }

	[CalledBy(Type = typeof(XmlMiscConverter), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IXmlNamespaceResolver)}, ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(XsdDuration), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpan), typeof(DurationType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XsdDuration), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DurationType)}, ReturnType = typeof(string))]
	protected static string YearMonthDurationToString(TimeSpan value) { }

}

