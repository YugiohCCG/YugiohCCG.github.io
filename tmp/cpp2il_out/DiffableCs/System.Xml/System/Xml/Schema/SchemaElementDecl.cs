namespace System.Xml.Schema;

internal sealed class SchemaElementDecl : SchemaDeclBase, IDtdAttributeListInfo
{
	internal static readonly SchemaElementDecl Empty; //Field offset: 0x0
	private Dictionary<XmlQualifiedName, SchemaAttDef> attdefs; //Field offset: 0x60
	private List<IDtdDefaultAttributeInfo> defaultAttdefs; //Field offset: 0x68
	private bool isIdDeclared; //Field offset: 0x70
	private bool hasNonCDataAttribute; //Field offset: 0x71
	private bool isAbstract; //Field offset: 0x72
	private bool isNillable; //Field offset: 0x73
	private bool hasRequiredAttribute; //Field offset: 0x74
	private bool isNotationDeclared; //Field offset: 0x75
	private Dictionary<XmlQualifiedName, XmlQualifiedName> prohibitedAttributes; //Field offset: 0x78
	private ContentValidator contentValidator; //Field offset: 0x80
	private XmlSchemaAnyAttribute anyAttribute; //Field offset: 0x88
	private XmlSchemaDerivationMethod block; //Field offset: 0x90
	private CompiledIdentityConstraint[] constraints; //Field offset: 0x98
	private XmlSchemaElement schemaElement; //Field offset: 0xA0

	internal XmlSchemaAnyAttribute AnyAttribute
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		internal get { } //Length: 8
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		internal set { } //Length: 19
	}

	internal Dictionary<XmlQualifiedName, SchemaAttDef> AttDefs
	{
		[CallerCount(Count = 84)]
		[DeduplicatedMethod]
		internal get { } //Length: 5
	}

	internal XmlSchemaDerivationMethod Block
	{
		[CallerCount(Count = 33)]
		[DeduplicatedMethod]
		internal get { } //Length: 7
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		internal set { } //Length: 7
	}

	internal CompiledIdentityConstraint[] Constraints
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		internal get { } //Length: 8
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		internal set { } //Length: 19
	}

	internal ContentValidator ContentValidator
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		internal get { } //Length: 8
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		internal set { } //Length: 16
	}

	internal IList<IDtdDefaultAttributeInfo> DefaultAttDefs
	{
		[CallerCount(Count = 22)]
		[DeduplicatedMethod]
		internal get { } //Length: 5
	}

	internal bool HasDefaultAttribute
	{
		[CalledBy(Type = typeof(XdrValidator), Member = "ValidateEndStartElement", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XmlSchemaValidator), Member = "GetUnspecifiedDefaultAttributes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ArrayList), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XsdValidator), Member = "ValidateEndStartElement", ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[ContainsUnimplementedInstructions]
		internal get { } //Length: 9
	}

	internal bool HasNonCDataAttribute
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		internal get { } //Length: 5
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		internal set { } //Length: 4
	}

	internal bool HasRequiredAttribute
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		internal get { } //Length: 5
	}

	internal bool IsAbstract
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		internal get { } //Length: 5
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		internal set { } //Length: 4
	}

	internal bool IsIdDeclared
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		internal get { } //Length: 5
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		internal set { } //Length: 4
	}

	internal bool IsNillable
	{
		[CallerCount(Count = 0)]
		internal get { } //Length: 5
		[CallerCount(Count = 0)]
		internal set { } //Length: 4
	}

	internal bool IsNotationDeclared
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		internal get { } //Length: 5
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		internal set { } //Length: 4
	}

	internal Dictionary<XmlQualifiedName, XmlQualifiedName> ProhibitedAttributes
	{
		[CallerCount(Count = 7)]
		[DeduplicatedMethod]
		internal get { } //Length: 5
	}

	internal XmlSchemaElement SchemaElement
	{
		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		internal get { } //Length: 8
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		internal set { } //Length: 19
	}

	private override bool System.Xml.IDtdAttributeListInfo.HasNonCDataAttributes
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		private get { } //Length: 5
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SchemaElementDecl), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private static SchemaElementDecl() { }

	[CalledBy(Type = typeof(DtdParser), Member = "ParseAttlistDecl", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DtdParser), Member = "ParseElementDecl", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XdrBuilder), Member = "XDR_BuildElement_Type", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XdrBuilder), typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	internal SchemaElementDecl(XmlQualifiedName name, string prefix) { }

	[CalledBy(Type = typeof(XmlSchemaInference), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SchemaCollectionCompiler), Member = "CompileComplexType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaComplexType)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SchemaElementDecl), Member = "CreateAnyTypeElementDecl", ReturnType = typeof(SchemaElementDecl))]
	[CalledBy(Type = typeof(SchemaElementDecl), Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Compiler), Member = "CompileComplexType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaComplexType)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XdrBuilder), Member = "XDR_InitElementType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XdrBuilder), typeof(object)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	internal SchemaElementDecl() { }

	[CalledBy(Type = typeof(DatatypeImplementation), Member = "StartBuiltinType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName), typeof(XmlSchemaDatatype)}, ReturnType = typeof(XmlSchemaSimpleType))]
	[CalledBy(Type = typeof(DatatypeImplementation), Member = "GetNormalizedStringTypeV1Compat", ReturnType = typeof(XmlSchemaSimpleType))]
	[CalledBy(Type = typeof(DatatypeImplementation), Member = "GetTokenTypeV1Compat", ReturnType = typeof(XmlSchemaSimpleType))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	internal SchemaElementDecl(XmlSchemaDatatype dtype) { }

	[CalledBy(Type = typeof(DtdParser), Member = "ParseAttlistDecl", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SchemaCollectionCompiler), Member = "CompileComplexType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaComplexType)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Compiler), Member = "CompileComplexType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaComplexType)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XdrBuilder), Member = "XDR_BeginAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XdrBuilder)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	internal void AddAttDef(SchemaAttDef attdef) { }

	[CalledBy(Type = typeof(DtdValidator), Member = "ValidateEndStartElement", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XdrValidator), Member = "ValidateEndStartElement", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XsdValidator), Member = "ValidateEndStartElement", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlSchemaException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 15)]
	internal void CheckAttributes(Hashtable presence, bool standalone) { }

	[CalledBy(Type = typeof(SchemaCollectionCompiler), Member = "CompileElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaElement)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Compiler), Member = "CompileElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaElement)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSchemaValidator), Member = "CheckXsiTypeAndNil", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SchemaElementDecl), typeof(string), typeof(string), typeof(Boolean&)}, ReturnType = typeof(SchemaElementDecl))]
	[CallerCount(Count = 11)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	internal SchemaElementDecl Clone() { }

	[CalledBy(Type = typeof(XmlSchemaComplexType), Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSchemaComplexType), Member = "CreateAnyType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaContentProcessing)}, ReturnType = typeof(XmlSchemaComplexType))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(SchemaElementDecl), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	internal static SchemaElementDecl CreateAnyTypeElementDecl() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	internal XmlSchemaAnyAttribute get_AnyAttribute() { }

	[CallerCount(Count = 84)]
	[DeduplicatedMethod]
	internal Dictionary<XmlQualifiedName, SchemaAttDef> get_AttDefs() { }

	[CallerCount(Count = 33)]
	[DeduplicatedMethod]
	internal XmlSchemaDerivationMethod get_Block() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	internal CompiledIdentityConstraint[] get_Constraints() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	internal ContentValidator get_ContentValidator() { }

	[CallerCount(Count = 22)]
	[DeduplicatedMethod]
	internal IList<IDtdDefaultAttributeInfo> get_DefaultAttDefs() { }

	[CalledBy(Type = typeof(XdrValidator), Member = "ValidateEndStartElement", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSchemaValidator), Member = "GetUnspecifiedDefaultAttributes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ArrayList), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XsdValidator), Member = "ValidateEndStartElement", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[ContainsUnimplementedInstructions]
	internal bool get_HasDefaultAttribute() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	internal bool get_HasNonCDataAttribute() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	internal bool get_HasRequiredAttribute() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	internal bool get_IsAbstract() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	internal bool get_IsIdDeclared() { }

	[CallerCount(Count = 0)]
	internal bool get_IsNillable() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	internal bool get_IsNotationDeclared() { }

	[CallerCount(Count = 7)]
	[DeduplicatedMethod]
	internal Dictionary<XmlQualifiedName, XmlQualifiedName> get_ProhibitedAttributes() { }

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	internal XmlSchemaElement get_SchemaElement() { }

	[CalledBy(Type = typeof(DtdParser), Member = "ParseAttlistDecl", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DtdParser), Member = "ParseAttlistType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SchemaAttDef), typeof(SchemaElementDecl), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DtdValidator), Member = "ValidateStartElement", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SchemaInfo), Member = "GetAttributeXdr", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SchemaElementDecl), typeof(XmlQualifiedName)}, ReturnType = typeof(SchemaAttDef))]
	[CalledBy(Type = typeof(SchemaInfo), Member = "GetAttributeXsd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SchemaElementDecl), typeof(XmlQualifiedName), typeof(XmlSchemaObject), typeof(AttributeMatchState&)}, ReturnType = typeof(SchemaAttDef))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object&)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	internal SchemaAttDef GetAttDef(XmlQualifiedName qname) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	internal void set_AnyAttribute(XmlSchemaAnyAttribute value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	internal void set_Block(XmlSchemaDerivationMethod value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	internal void set_Constraints(CompiledIdentityConstraint[] value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	internal void set_ContentValidator(ContentValidator value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	internal void set_HasNonCDataAttribute(bool value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	internal void set_IsAbstract(bool value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	internal void set_IsIdDeclared(bool value) { }

	[CallerCount(Count = 0)]
	internal void set_IsNillable(bool value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	internal void set_IsNotationDeclared(bool value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	internal void set_SchemaElement(XmlSchemaElement value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	private override bool System.Xml.IDtdAttributeListInfo.get_HasNonCDataAttributes() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlQualifiedName), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object&)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	private override IDtdAttributeInfo System.Xml.IDtdAttributeListInfo.LookupAttribute(string prefix, string localName) { }

	[CallerCount(Count = 22)]
	[DeduplicatedMethod]
	private override IEnumerable<IDtdDefaultAttributeInfo> System.Xml.IDtdAttributeListInfo.LookupDefaultAttributes() { }

}

