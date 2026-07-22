namespace System.Xml.Schema;

internal class Datatype_normalizedStringV1Compat : Datatype_string
{

	internal virtual bool HasValueFacets
	{
		[CallerCount(Count = 23)]
		[DeduplicatedMethod]
		internal get { } //Length: 3
	}

	public virtual XmlTypeCode TypeCode
	{
		[CallerCount(Count = 3)]
		[DeduplicatedMethod]
		 get { } //Length: 6
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Datatype_string), Member = ".ctor", ReturnType = typeof(void))]
	[DeduplicatedMethod]
	public Datatype_normalizedStringV1Compat() { }

	[CallerCount(Count = 23)]
	[DeduplicatedMethod]
	internal virtual bool get_HasValueFacets() { }

	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	public virtual XmlTypeCode get_TypeCode() { }

}

