namespace System.Xml.Schema;

internal class Datatype_anySimpleType : DatatypeImplementation
{
	private static readonly Type atomicValueType; //Field offset: 0x0
	private static readonly Type listValueType; //Field offset: 0x8

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

	public virtual XmlTokenizedType TokenizedType
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 6
	}

	public virtual XmlTypeCode TypeCode
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 6
	}

	internal virtual RestrictionFlags ValidRestrictionFlags
	{
		[CallerCount(Count = 182)]
		[DeduplicatedMethod]
		internal get { } //Length: 3
	}

	public virtual Type ValueType
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 78
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[CallsUnknownMethods(Count = 2)]
	private static Datatype_anySimpleType() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public Datatype_anySimpleType() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Compare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(StringComparison)}, ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	internal virtual int Compare(object value1, object value2) { }

	[CallerCount(Count = 0)]
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
	public virtual XmlTokenizedType get_TokenizedType() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public virtual XmlTypeCode get_TypeCode() { }

	[CallerCount(Count = 182)]
	[DeduplicatedMethod]
	internal virtual RestrictionFlags get_ValidRestrictionFlags() { }

	[CallerCount(Count = 0)]
	public virtual Type get_ValueType() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlComplianceUtil), Member = "NonCDataNormalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 1)]
	internal virtual Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

}

