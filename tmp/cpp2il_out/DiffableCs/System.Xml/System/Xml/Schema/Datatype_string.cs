namespace System.Xml.Schema;

internal class Datatype_string : Datatype_anySimpleType
{

	internal virtual XmlSchemaWhiteSpace BuiltInWhitespaceFacet
	{
		[CallerCount(Count = 182)]
		[DeduplicatedMethod]
		internal get { } //Length: 3
	}

	internal virtual FacetsChecker FacetsChecker
	{
		[CallerCount(Count = 0)]
		internal get { } //Length: 79
	}

	public virtual XmlTokenizedType TokenizedType
	{
		[CallerCount(Count = 182)]
		[DeduplicatedMethod]
		 get { } //Length: 3
	}

	public virtual XmlTypeCode TypeCode
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 6
	}

	internal virtual RestrictionFlags ValidRestrictionFlags
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		internal get { } //Length: 6
	}

	[CalledBy(Type = typeof(DatatypeImplementation), Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Datatype_normalizedString), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Datatype_normalizedStringV1Compat), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Datatype_token), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Datatype_tokenV1Compat), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Datatype_language), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Datatype_NMTOKEN), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Datatype_Name), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Datatype_NCName), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Datatype_ID), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Datatype_IDREF), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Datatype_ENTITY), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Datatype_ENUMERATION), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 25)]
	[CallsDeduplicatedMethods(Count = 1)]
	public Datatype_string() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlStringConverter), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaType)}, ReturnType = typeof(XmlValueConverter))]
	internal virtual XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	[CallerCount(Count = 182)]
	[DeduplicatedMethod]
	internal virtual XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	[CallerCount(Count = 0)]
	internal virtual FacetsChecker get_FacetsChecker() { }

	[CallerCount(Count = 182)]
	[DeduplicatedMethod]
	public virtual XmlTokenizedType get_TokenizedType() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public virtual XmlTypeCode get_TypeCode() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	internal virtual RestrictionFlags get_ValidRestrictionFlags() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	internal virtual Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

}

