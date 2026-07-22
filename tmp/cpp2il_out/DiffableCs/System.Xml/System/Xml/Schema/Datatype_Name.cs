namespace System.Xml.Schema;

internal class Datatype_Name : Datatype_token
{

	public virtual XmlTypeCode TypeCode
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 6
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Datatype_string), Member = ".ctor", ReturnType = typeof(void))]
	[DeduplicatedMethod]
	public Datatype_Name() { }

	[CallerCount(Count = 0)]
	public virtual XmlTypeCode get_TypeCode() { }

}

