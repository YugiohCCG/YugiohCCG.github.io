namespace System.Xml.Schema;

internal abstract class SchemaDeclBase
{
	public enum Use
	{
		Default = 0,
		Required = 1,
		Implied = 2,
		Fixed = 3,
		RequiredFixed = 4,
	}

	protected XmlQualifiedName name; //Field offset: 0x10
	protected string prefix; //Field offset: 0x18
	protected bool isDeclaredInExternal; //Field offset: 0x20
	protected Use presence; //Field offset: 0x24
	protected XmlSchemaType schemaType; //Field offset: 0x28
	protected XmlSchemaDatatype datatype; //Field offset: 0x30
	protected string defaultValueRaw; //Field offset: 0x38
	protected object defaultValueTyped; //Field offset: 0x40
	protected long maxLength; //Field offset: 0x48
	protected long minLength; //Field offset: 0x50
	protected List<String> values; //Field offset: 0x58

	internal XmlSchemaDatatype Datatype
	{
		[CallerCount(Count = 62)]
		[DeduplicatedMethod]
		internal get { } //Length: 5
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		internal set { } //Length: 13
	}

	internal string DefaultValueRaw
	{
		[CalledBy(Type = typeof(XmlDocument), Member = "PrepareDefaultAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SchemaAttDef), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(XmlAttribute))]
		[CalledBy(Type = typeof(SchemaCollectionCompiler), Member = "CompileAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaAttribute)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(SchemaCollectionCompiler), Member = "CompileElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaElement)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XdrBuilder), Member = "CheckDefaultAttValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SchemaAttDef)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XmlSchemaValidator), Member = "GetUnspecifiedDefaultAttributes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ArrayList), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XmlSchemaValidator), Member = "InternalValidateEndElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaInfo), typeof(object)}, ReturnType = typeof(object))]
		[CalledBy(Type = typeof(XmlSchemaValidator), Member = "ValidateAtomicValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(XmlSchemaSimpleType&)}, ReturnType = typeof(object))]
		[CalledBy(Type = typeof(XmlSchemaValidator), Member = "CheckXsiTypeAndNil", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SchemaElementDecl), typeof(string), typeof(string), typeof(Boolean&)}, ReturnType = typeof(SchemaElementDecl))]
		[CalledBy(Type = typeof(XmlSchemaValidator), Member = "CheckMixedValueConstraint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(object))]
		[CalledBy(Type = typeof(XsdValidator), Member = "ValidateEndStartElement", ReturnType = typeof(void))]
		[CallerCount(Count = 13)]
		internal get { } //Length: 30
		[CallerCount(Count = 3)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		internal set { } //Length: 13
	}

	internal object DefaultValueTyped
	{
		[CallerCount(Count = 12)]
		[DeduplicatedMethod]
		internal get { } //Length: 5
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		internal set { } //Length: 13
	}

	internal bool IsDeclaredInExternal
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		internal get { } //Length: 5
		[CallerCount(Count = 3)]
		[DeduplicatedMethod]
		internal set { } //Length: 4
	}

	internal long MaxLength
	{
		[CallerCount(Count = 10)]
		[DeduplicatedMethod]
		internal get { } //Length: 254
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		internal set { } //Length: 5
	}

	internal long MinLength
	{
		[CallerCount(Count = 16)]
		[DeduplicatedMethod]
		internal get { } //Length: 5
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		internal set { } //Length: 5
	}

	internal XmlQualifiedName Name
	{
		[CallerCount(Count = 106)]
		[DeduplicatedMethod]
		internal get { } //Length: 5
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		internal set { } //Length: 13
	}

	internal string Prefix
	{
		[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "AddDefaultAttributeNonDtd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SchemaAttDef)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(XmlDocument), Member = "AddDefaultAttributes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlElement)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XmlLoader), Member = "LoadDocumentType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IDtdInfo), typeof(XmlDocumentType)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DtdParser), Member = "ParseAttlistDecl", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(SchemaAttDef), Member = "System.Xml.IDtdAttributeInfo.get_Prefix", ReturnType = typeof(string))]
		[CalledBy(Type = typeof(XdrBuilder), Member = "XDR_EndRoot", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XdrBuilder)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XdrBuilder), Member = "XDR_BuildAttributeType_DtType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XdrBuilder), typeof(object), typeof(string)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XdrBuilder), Member = "CheckDatatype", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(XmlSchemaDatatype))]
		[CallerCount(Count = 12)]
		internal get { } //Length: 30
		[CallerCount(Count = 9)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		internal set { } //Length: 13
	}

	internal Use Presence
	{
		[CallerCount(Count = 9)]
		[DeduplicatedMethod]
		internal get { } //Length: 4
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		internal set { } //Length: 4
	}

	internal XmlSchemaType SchemaType
	{
		[CallerCount(Count = 15)]
		[DeduplicatedMethod]
		internal get { } //Length: 5
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		internal set { } //Length: 13
	}

	internal List<String> Values
	{
		[CallerCount(Count = 10)]
		[DeduplicatedMethod]
		internal get { } //Length: 5
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		internal set { } //Length: 13
	}

	[CalledBy(Type = typeof(SchemaAttDef), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SchemaAttDef), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SchemaCollectionCompiler), Member = "CompileAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaAttribute)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	protected SchemaDeclBase(XmlQualifiedName name, string prefix) { }

	[CalledBy(Type = typeof(SchemaAttDef), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SchemaAttDef), Member = ".cctor", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	protected SchemaDeclBase() { }

	[CalledBy(Type = typeof(DtdParser), Member = "ParseAttlistType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SchemaAttDef), typeof(SchemaElementDecl), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	internal void AddValue(string value) { }

	[CalledBy(Type = typeof(DtdValidator), Member = "CheckValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(SchemaAttDef)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DtdValidator), Member = "CheckDefaultValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SchemaAttDef), typeof(SchemaInfo), typeof(IValidationEventHandling), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XdrValidator), Member = "CheckValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(SchemaAttDef)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XdrValidator), Member = "CheckDefaultValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(SchemaAttDef), typeof(SchemaInfo), typeof(XmlNamespaceManager), typeof(XmlNameTable), typeof(object), typeof(ValidationEventHandler), typeof(string), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	internal bool CheckEnumeration(object pVal) { }

	[CalledBy(Type = typeof(DtdValidator), Member = "CheckValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(SchemaAttDef)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XdrValidator), Member = "CheckValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(SchemaAttDef)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSchemaValidator), Member = "ValidateAtomicValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(XmlSchemaSimpleType&)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(XmlSchemaValidator), Member = "CheckAttributeValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(SchemaAttDef)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(XmlSchemaValidator), Member = "CheckElementValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(XsdValidator), Member = "CheckValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(SchemaAttDef)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	internal bool CheckValue(object pVal) { }

	[CallerCount(Count = 62)]
	[DeduplicatedMethod]
	internal XmlSchemaDatatype get_Datatype() { }

	[CalledBy(Type = typeof(XmlDocument), Member = "PrepareDefaultAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SchemaAttDef), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(XmlAttribute))]
	[CalledBy(Type = typeof(SchemaCollectionCompiler), Member = "CompileAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaAttribute)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SchemaCollectionCompiler), Member = "CompileElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaElement)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XdrBuilder), Member = "CheckDefaultAttValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SchemaAttDef)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSchemaValidator), Member = "GetUnspecifiedDefaultAttributes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ArrayList), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSchemaValidator), Member = "InternalValidateEndElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaInfo), typeof(object)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(XmlSchemaValidator), Member = "ValidateAtomicValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(XmlSchemaSimpleType&)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(XmlSchemaValidator), Member = "CheckXsiTypeAndNil", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SchemaElementDecl), typeof(string), typeof(string), typeof(Boolean&)}, ReturnType = typeof(SchemaElementDecl))]
	[CalledBy(Type = typeof(XmlSchemaValidator), Member = "CheckMixedValueConstraint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(XsdValidator), Member = "ValidateEndStartElement", ReturnType = typeof(void))]
	[CallerCount(Count = 13)]
	internal string get_DefaultValueRaw() { }

	[CallerCount(Count = 12)]
	[DeduplicatedMethod]
	internal object get_DefaultValueTyped() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	internal bool get_IsDeclaredInExternal() { }

	[CallerCount(Count = 10)]
	[DeduplicatedMethod]
	internal long get_MaxLength() { }

	[CallerCount(Count = 16)]
	[DeduplicatedMethod]
	internal long get_MinLength() { }

	[CallerCount(Count = 106)]
	[DeduplicatedMethod]
	internal XmlQualifiedName get_Name() { }

	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "AddDefaultAttributeNonDtd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SchemaAttDef)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XmlDocument), Member = "AddDefaultAttributes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlElement)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlLoader), Member = "LoadDocumentType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IDtdInfo), typeof(XmlDocumentType)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DtdParser), Member = "ParseAttlistDecl", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SchemaAttDef), Member = "System.Xml.IDtdAttributeInfo.get_Prefix", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(XdrBuilder), Member = "XDR_EndRoot", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XdrBuilder)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XdrBuilder), Member = "XDR_BuildAttributeType_DtType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XdrBuilder), typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XdrBuilder), Member = "CheckDatatype", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(XmlSchemaDatatype))]
	[CallerCount(Count = 12)]
	internal string get_Prefix() { }

	[CallerCount(Count = 9)]
	[DeduplicatedMethod]
	internal Use get_Presence() { }

	[CallerCount(Count = 15)]
	[DeduplicatedMethod]
	internal XmlSchemaType get_SchemaType() { }

	[CallerCount(Count = 10)]
	[DeduplicatedMethod]
	internal List<String> get_Values() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	internal void set_Datatype(XmlSchemaDatatype value) { }

	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	internal void set_DefaultValueRaw(string value) { }

	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	internal void set_DefaultValueTyped(object value) { }

	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	internal void set_IsDeclaredInExternal(bool value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	internal void set_MaxLength(long value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	internal void set_MinLength(long value) { }

	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	internal void set_Name(XmlQualifiedName value) { }

	[CallerCount(Count = 9)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	internal void set_Prefix(string value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	internal void set_Presence(Use value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	internal void set_SchemaType(XmlSchemaType value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	internal void set_Values(List<String> value) { }

}

