namespace System.Xml.Schema;

internal class Datatype_dateTimeBase : Datatype_anySimpleType
{
	private static readonly Type atomicValueType; //Field offset: 0x0
	private static readonly Type listValueType; //Field offset: 0x8
	private XsdDateTimeFlags dateTimeFlags; //Field offset: 0x38

	internal virtual XmlSchemaWhiteSpace BuiltInWhitespaceFacet
	{
		[CallerCount(Count = 8)]
		[DeduplicatedMethod]
		internal get { } //Length: 6
	}

	internal virtual FacetsChecker FacetsChecker
	{
		[CallerCount(Count = 0)]
		internal get { } //Length: 79
	}

	internal virtual Type ListValueType
	{
		[CallerCount(Count = 0)]
		internal get { } //Length: 79
	}

	public virtual XmlTypeCode TypeCode
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 6
	}

	internal virtual RestrictionFlags ValidRestrictionFlags
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		internal get { } //Length: 6
	}

	public virtual Type ValueType
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 78
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[CallsUnknownMethods(Count = 2)]
	private static Datatype_dateTimeBase() { }

	[CalledBy(Type = typeof(DatatypeImplementation), Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Datatype_dateTimeNoTimeZone), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Datatype_dateTimeTimeZone), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Datatype_dateTime), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Datatype_timeNoTimeZone), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Datatype_timeTimeZone), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Datatype_time), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Datatype_date), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Datatype_yearMonth), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Datatype_year), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Datatype_monthDay), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Datatype_day), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Datatype_month), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 24)]
	[CallsDeduplicatedMethods(Count = 1)]
	internal Datatype_dateTimeBase(XsdDateTimeFlags dateTimeFlags) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DateTime), Member = "get_Kind", ReturnType = typeof(DateTimeKind))]
	[Calls(Type = typeof(DateTime), Member = "ToUniversalTime", ReturnType = typeof(DateTime))]
	[Calls(Type = typeof(DateTime), Member = "CompareTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime)}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 3)]
	internal virtual int Compare(object value1, object value2) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlDateTimeConverter), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaType)}, ReturnType = typeof(XmlValueConverter))]
	internal virtual XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	[CallerCount(Count = 8)]
	[DeduplicatedMethod]
	internal virtual XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	[CallerCount(Count = 0)]
	internal virtual FacetsChecker get_FacetsChecker() { }

	[CallerCount(Count = 0)]
	internal virtual Type get_ListValueType() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public virtual XmlTypeCode get_TypeCode() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	internal virtual RestrictionFlags get_ValidRestrictionFlags() { }

	[CallerCount(Count = 0)]
	public virtual Type get_ValueType() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XsdDateTime), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(XsdDateTimeFlags), typeof(XsdDateTime&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(XsdDateTime), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XsdDateTime)}, ReturnType = typeof(DateTime))]
	[Calls(Type = typeof(Enum), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(Res), Member = "GetString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(FormatException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 13)]
	internal virtual Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

}

