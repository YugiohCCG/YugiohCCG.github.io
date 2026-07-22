namespace System.Xml.Schema;

internal class Datatype_NMTOKEN : Datatype_token
{

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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Datatype_string), Member = ".ctor", ReturnType = typeof(void))]
	[DeduplicatedMethod]
	public Datatype_NMTOKEN() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public virtual XmlTokenizedType get_TokenizedType() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public virtual XmlTypeCode get_TypeCode() { }

}

