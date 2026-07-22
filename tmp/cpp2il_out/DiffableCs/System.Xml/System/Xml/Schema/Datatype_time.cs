namespace System.Xml.Schema;

internal class Datatype_time : Datatype_dateTimeBase
{

	public virtual XmlTypeCode TypeCode
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 6
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Datatype_dateTimeBase), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XsdDateTimeFlags)}, ReturnType = typeof(void))]
	internal Datatype_time() { }

	[CallerCount(Count = 0)]
	public virtual XmlTypeCode get_TypeCode() { }

}

