namespace System.Xml.Schema;

internal class Datatype_positiveInteger : Datatype_nonNegativeInteger
{
	private static readonly FacetsChecker numeric10FacetsChecker; //Field offset: 0x0

	internal virtual FacetsChecker FacetsChecker
	{
		[CallerCount(Count = 0)]
		internal get { } //Length: 78
	}

	public virtual XmlTypeCode TypeCode
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 6
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Decimal), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(bool), typeof(byte)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private static Datatype_positiveInteger() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Datatype_decimal), Member = ".ctor", ReturnType = typeof(void))]
	public Datatype_positiveInteger() { }

	[CallerCount(Count = 0)]
	internal virtual FacetsChecker get_FacetsChecker() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public virtual XmlTypeCode get_TypeCode() { }

}

