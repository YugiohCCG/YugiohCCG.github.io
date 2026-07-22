namespace System.Xml.Schema;

internal class Datatype_anyAtomicType : Datatype_anySimpleType
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

	[CalledBy(Type = typeof(DatatypeImplementation), Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Datatype_untypedAtomicType), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	public Datatype_anyAtomicType() { }

	[CallerCount(Count = 0)]
	internal virtual XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	[CallerCount(Count = 182)]
	[DeduplicatedMethod]
	internal virtual XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public virtual XmlTypeCode get_TypeCode() { }

}

