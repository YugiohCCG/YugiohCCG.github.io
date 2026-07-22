namespace System.Xml.Schema;

internal class Datatype_long : Datatype_integer
{
	private static readonly Type atomicValueType; //Field offset: 0x0
	private static readonly Type listValueType; //Field offset: 0x8
	private static readonly FacetsChecker numeric10FacetsChecker; //Field offset: 0x10

	internal virtual FacetsChecker FacetsChecker
	{
		[CallerCount(Count = 0)]
		internal get { } //Length: 79
	}

	internal virtual bool HasValueFacets
	{
		[CallerCount(Count = 23)]
		[DeduplicatedMethod]
		internal get { } //Length: 3
	}

	internal virtual Type ListValueType
	{
		[CallerCount(Count = 0)]
		internal get { } //Length: 79
	}

	public virtual XmlTypeCode TypeCode
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 6
	}

	public virtual Type ValueType
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 78
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(Decimal), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private static Datatype_long() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Datatype_decimal), Member = ".ctor", ReturnType = typeof(void))]
	[DeduplicatedMethod]
	public Datatype_long() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(long), Member = "CompareTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 2)]
	internal virtual int Compare(object value1, object value2) { }

	[CallerCount(Count = 0)]
	internal virtual FacetsChecker get_FacetsChecker() { }

	[CallerCount(Count = 23)]
	[DeduplicatedMethod]
	internal virtual bool get_HasValueFacets() { }

	[CallerCount(Count = 0)]
	internal virtual Type get_ListValueType() { }

	[CallerCount(Count = 0)]
	public virtual XmlTypeCode get_TypeCode() { }

	[CallerCount(Count = 0)]
	public virtual Type get_ValueType() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlConvert), Member = "TryToInt64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Int64&)}, ReturnType = typeof(Exception))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	internal virtual Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

}

