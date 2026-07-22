namespace System.Xml.Schema;

public abstract class XmlSchemaDatatype
{

	internal abstract XmlSchemaWhiteSpace BuiltInWhitespaceFacet
	{
		internal get { } //Length: 0
	}

	internal abstract FacetsChecker FacetsChecker
	{
		internal get { } //Length: 0
	}

	internal abstract bool HasLexicalFacets
	{
		internal get { } //Length: 0
	}

	internal abstract bool HasValueFacets
	{
		internal get { } //Length: 0
	}

	internal abstract RestrictionFacets Restriction
	{
		internal get { } //Length: 0
	}

	public abstract XmlTokenizedType TokenizedType
	{
		 get { } //Length: 0
	}

	public override XmlTypeCode TypeCode
	{
		[CallerCount(Count = 182)]
		[DeduplicatedMethod]
		 get { } //Length: 3
	}

	internal string TypeCodeString
	{
		[CalledBy(Type = typeof(DatatypeImplementation), Member = "GetTypeName", ReturnType = typeof(string))]
		[CalledBy(Type = "System.Xml.Schema.FacetsChecker+FacetsCompiler", Member = "CheckProhibitedFlag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaFacet), typeof(RestrictionFlags), typeof(string)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Numeric10FacetsChecker), Member = "CheckValueFacets", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal), typeof(XmlSchemaDatatype)}, ReturnType = typeof(Exception))]
		[CalledBy(Type = typeof(Preprocessor), Member = "Preprocess", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchema), typeof(string), typeof(ArrayList)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XmlSchemaValidator), Member = "ProcessSchemaLocations", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XmlSchemaValidator), Member = "ValidateAtomicValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(XmlSchemaSimpleType&)}, ReturnType = typeof(object))]
		[CalledBy(Type = typeof(XmlSchemaValidator), Member = "GetTypeName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SchemaDeclBase)}, ReturnType = typeof(string))]
		[CalledBy(Type = typeof(XmlSchemaValidator), Member = "CheckXsiTypeAndNil", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SchemaElementDecl), typeof(string), typeof(string), typeof(Boolean&)}, ReturnType = typeof(SchemaElementDecl))]
		[CalledBy(Type = typeof(XmlSchemaValidator), Member = "CheckAttributeValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(SchemaAttDef)}, ReturnType = typeof(object))]
		[CalledBy(Type = typeof(XmlSchemaValidator), Member = "CheckElementValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(object))]
		[CallerCount(Count = 10)]
		[Calls(Type = typeof(XmlSchemaDatatype), Member = "TypeCodeToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlTypeCode)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
		[CallsDeduplicatedMethods(Count = 2)]
		internal get { } //Length: 326
	}

	internal abstract XmlValueConverter ValueConverter
	{
		internal get { } //Length: 0
	}

	public abstract Type ValueType
	{
		 get { } //Length: 0
	}

	public override XmlSchemaDatatypeVariety Variety
	{
		[CallerCount(Count = 182)]
		[DeduplicatedMethod]
		 get { } //Length: 3
	}

	[CallerCount(Count = 2180)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	protected XmlSchemaDatatype() { }

	internal abstract int Compare(object value1, object value2) { }

	[CalledBy(Type = typeof(XmlSchemaValidator), Member = "ValidateAtomicValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(XmlSchemaSimpleType&)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(XmlSchemaValidator), Member = "CheckAttributeValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(SchemaAttDef)}, ReturnType = typeof(object))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 25)]
	internal static string ConcatenatedToString(object value) { }

	internal abstract XmlSchemaDatatype DeriveByList(XmlSchemaType schemaType) { }

	internal abstract XmlSchemaDatatype DeriveByRestriction(XmlSchemaObjectCollection facets, XmlNameTable nameTable, XmlSchemaType schemaType) { }

	[CalledBy(Type = typeof(SchemaCollectionCompiler), Member = "CompileSimpleType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaSimpleType)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Compiler), Member = "CompileSimpleType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaSimpleType)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(DatatypeImplementation), Member = "DeriveByUnion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaSimpleType[]), typeof(XmlSchemaType)}, ReturnType = typeof(DatatypeImplementation))]
	internal static XmlSchemaDatatype DeriveByUnion(XmlSchemaSimpleType[] types, XmlSchemaType schemaType) { }

	[CalledBy(Type = typeof(AutoValidator), Member = "DetectValidationType", ReturnType = typeof(ValidationType))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DatatypeImplementation), Member = "FromXdrName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(DatatypeImplementation))]
	internal static XmlSchemaDatatype FromXdrName(string name) { }

	[CalledBy(Type = typeof(SchemaAttDef), Member = "set_TokenizedType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlTokenizedType)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSchemaValidator), Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XsdValidator), Member = ".cctor", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(DatatypeImplementation), Member = "FromXmlTokenizedType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlTokenizedType)}, ReturnType = typeof(DatatypeImplementation))]
	internal static XmlSchemaDatatype FromXmlTokenizedType(XmlTokenizedType token) { }

	[CalledBy(Type = typeof(XmlSchemaValidator), Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XsdBuilder), Member = "BuildSimpleTypeUnion_MemberTypes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XsdBuilder), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XsdValidator), Member = ".cctor", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(DatatypeImplementation), Member = "FromXmlTokenizedTypeXsd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlTokenizedType)}, ReturnType = typeof(DatatypeImplementation))]
	internal static XmlSchemaDatatype FromXmlTokenizedTypeXsd(XmlTokenizedType token) { }

	internal abstract XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	internal abstract FacetsChecker get_FacetsChecker() { }

	internal abstract bool get_HasLexicalFacets() { }

	internal abstract bool get_HasValueFacets() { }

	internal abstract RestrictionFacets get_Restriction() { }

	public abstract XmlTokenizedType get_TokenizedType() { }

	[CallerCount(Count = 182)]
	[DeduplicatedMethod]
	public override XmlTypeCode get_TypeCode() { }

	[CalledBy(Type = typeof(DatatypeImplementation), Member = "GetTypeName", ReturnType = typeof(string))]
	[CalledBy(Type = "System.Xml.Schema.FacetsChecker+FacetsCompiler", Member = "CheckProhibitedFlag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaFacet), typeof(RestrictionFlags), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Numeric10FacetsChecker), Member = "CheckValueFacets", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal), typeof(XmlSchemaDatatype)}, ReturnType = typeof(Exception))]
	[CalledBy(Type = typeof(Preprocessor), Member = "Preprocess", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchema), typeof(string), typeof(ArrayList)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSchemaValidator), Member = "ProcessSchemaLocations", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSchemaValidator), Member = "ValidateAtomicValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(XmlSchemaSimpleType&)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(XmlSchemaValidator), Member = "GetTypeName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SchemaDeclBase)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(XmlSchemaValidator), Member = "CheckXsiTypeAndNil", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SchemaElementDecl), typeof(string), typeof(string), typeof(Boolean&)}, ReturnType = typeof(SchemaElementDecl))]
	[CalledBy(Type = typeof(XmlSchemaValidator), Member = "CheckAttributeValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(SchemaAttDef)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(XmlSchemaValidator), Member = "CheckElementValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(object))]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(XmlSchemaDatatype), Member = "TypeCodeToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlTypeCode)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 2)]
	internal string get_TypeCodeString() { }

	internal abstract XmlValueConverter get_ValueConverter() { }

	public abstract Type get_ValueType() { }

	[CallerCount(Count = 182)]
	[DeduplicatedMethod]
	public override XmlSchemaDatatypeVariety get_Variety() { }

	internal abstract bool IsComparable(XmlSchemaDatatype dtype) { }

	[CallerCount(Count = 271)]
	[DeduplicatedMethod]
	public override bool IsDerivedFrom(XmlSchemaDatatype datatype) { }

	internal abstract bool IsEqual(object o1, object o2) { }

	public abstract object ParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr) { }

	internal abstract object ParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, bool createAtomicValue) { }

	internal abstract Exception TryParseValue(object value, XmlNameTable nameTable, IXmlNamespaceResolver namespaceResolver, out object typedValue) { }

	internal abstract Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	[CalledBy(Type = typeof(XmlSchemaDatatype), Member = "get_TypeCodeString", ReturnType = typeof(string))]
	[CallerCount(Count = 2)]
	[ContainsInvalidInstructions]
	internal string TypeCodeToString(XmlTypeCode typeCode) { }

	internal abstract void VerifySchemaValid(XmlSchemaObjectTable notations, XmlSchemaObject caller) { }

	[CalledBy(Type = typeof(SchemaNames), Member = "SchemaTypeFromRoot", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(SchemaType))]
	[CalledBy(Type = typeof(XdrBuilder), Member = "ProcessElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XdrBuilder), Member = "ProcessAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XdrValidator), Member = "ValidateElement", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XdrValidator), Member = "ValidateStartElement", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XdrValidator), Member = "QualifiedName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(XmlQualifiedName))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(string), Member = "StartsWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(StringComparison)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(string), Member = "ToUpper", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CultureInfo)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	internal static string XdrCanonizeUri(string uri, XmlNameTable nameTable, SchemaNames schemaNames) { }

}

