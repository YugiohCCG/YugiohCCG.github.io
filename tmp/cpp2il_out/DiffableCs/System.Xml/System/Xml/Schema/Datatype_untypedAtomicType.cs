namespace System.Xml.Schema;

internal class Datatype_untypedAtomicType : Datatype_anyAtomicType
{

	internal virtual XmlSchemaWhiteSpace BuiltInWhitespaceFacet
	{
		[CallerCount(Count = 182)]
		[DeduplicatedMethod]
		internal get { } //Length: 3
	}

	public virtual XmlTypeCode TypeCode
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 6
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Datatype_anyAtomicType), Member = ".ctor", ReturnType = typeof(void))]
	public Datatype_untypedAtomicType() { }

	[CallerCount(Count = 0)]
	internal virtual XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	[CallerCount(Count = 182)]
	[DeduplicatedMethod]
	internal virtual XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public virtual XmlTypeCode get_TypeCode() { }

}

