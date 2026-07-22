namespace System.Xml.Schema;

internal class Datatype_decimal : Datatype_anySimpleType
{
	private static readonly Type atomicValueType; //Field offset: 0x0
	private static readonly Type listValueType; //Field offset: 0x8
	private static readonly FacetsChecker numeric10FacetsChecker; //Field offset: 0x10

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
		internal get { } //Length: 6
	}

	public virtual Type ValueType
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 78
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(Decimal), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(bool), typeof(byte)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private static Datatype_decimal() { }

	[CalledBy(Type = typeof(DatatypeImplementation), Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Datatype_integer), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Datatype_nonPositiveInteger), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Datatype_negativeInteger), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Datatype_long), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Datatype_int), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Datatype_nonNegativeInteger), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Datatype_unsignedLong), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Datatype_positiveInteger), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Datatype_fixed), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 17)]
	[CallsDeduplicatedMethods(Count = 1)]
	public Datatype_decimal() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Decimal), Member = "CompareTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 2)]
	internal virtual int Compare(object value1, object value2) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlNumeric10Converter), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaType)}, ReturnType = typeof(XmlValueConverter))]
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
	internal virtual RestrictionFlags get_ValidRestrictionFlags() { }

	[CallerCount(Count = 0)]
	public virtual Type get_ValueType() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlConvert), Member = "TryToDecimal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Decimal&)}, ReturnType = typeof(Exception))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	internal virtual Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

}

