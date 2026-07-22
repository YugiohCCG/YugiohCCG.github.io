namespace System.Xml.Schema;

internal class Datatype_ENUMERATION : Datatype_NMTOKEN
{

	public virtual XmlTokenizedType TokenizedType
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 6
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Datatype_string), Member = ".ctor", ReturnType = typeof(void))]
	[DeduplicatedMethod]
	public Datatype_ENUMERATION() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public virtual XmlTokenizedType get_TokenizedType() { }

}

