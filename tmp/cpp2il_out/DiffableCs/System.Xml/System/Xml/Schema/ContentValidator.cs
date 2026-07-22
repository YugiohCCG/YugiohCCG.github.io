namespace System.Xml.Schema;

internal class ContentValidator
{
	public static readonly ContentValidator Empty; //Field offset: 0x0
	public static readonly ContentValidator TextOnly; //Field offset: 0x8
	public static readonly ContentValidator Mixed; //Field offset: 0x10
	public static readonly ContentValidator Any; //Field offset: 0x18
	private XmlSchemaContentType contentType; //Field offset: 0x10
	private bool isOpen; //Field offset: 0x14
	private bool isEmptiable; //Field offset: 0x15

	public XmlSchemaContentType ContentType
	{
		[CallerCount(Count = 94)]
		[DeduplicatedMethod]
		 get { } //Length: 4
	}

	public override bool IsEmptiable
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public bool IsOpen
	{
		[CalledBy(Type = typeof(NfaContentValidator), Member = "ValidateElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName), typeof(ValidationState), typeof(Int32&)}, ReturnType = typeof(object))]
		[CalledBy(Type = typeof(SchemaInfo), Member = "GetAttributeXdr", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SchemaElementDecl), typeof(XmlQualifiedName)}, ReturnType = typeof(SchemaAttDef))]
		[CalledBy(Type = typeof(XdrBuilder), Member = "XDR_BeginElementType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XdrBuilder)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XdrBuilder), Member = "XDR_EndElementType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XdrBuilder)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XmlSchemaValidator), Member = "ElementValidationError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName), typeof(ValidationState), typeof(ValidationEventHandler), typeof(object), typeof(string), typeof(int), typeof(int), typeof(XmlSchemaSet)}, ReturnType = typeof(void))]
		[CallerCount(Count = 5)]
		 get { } //Length: 20
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	public bool PreserveWhitespace
	{
		[CalledBy(Type = typeof(DtdValidator), Member = "get_PreserveWhitespace", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(XdrValidator), Member = "get_PreserveWhitespace", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(XsdValidator), Member = "get_PreserveWhitespace", ReturnType = typeof(bool))]
		[CallerCount(Count = 3)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 17
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 4)]
	private static ContentValidator() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public ContentValidator(XmlSchemaContentType contentType) { }

	[CalledBy(Type = typeof(NfaContentValidator), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitSet), typeof(BitSet[]), typeof(SymbolsDictionary), typeof(Positions), typeof(int), typeof(XmlSchemaContentType), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RangeContentValidator), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitSet), typeof(BitSet[]), typeof(SymbolsDictionary), typeof(Positions), typeof(int), typeof(XmlSchemaContentType), typeof(bool), typeof(BitSet), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(AllElementsContentValidator), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaContentType), typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	protected ContentValidator(XmlSchemaContentType contentType, bool isOpen, bool isEmptiable) { }

	[CalledBy(Type = typeof(DfaContentValidator), Member = "ExpectedParticles", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ValidationState), typeof(bool), typeof(XmlSchemaSet)}, ReturnType = typeof(ArrayList))]
	[CalledBy(Type = typeof(NfaContentValidator), Member = "ExpectedParticles", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ValidationState), typeof(bool), typeof(XmlSchemaSet)}, ReturnType = typeof(ArrayList))]
	[CalledBy(Type = typeof(RangeContentValidator), Member = "ExpectedParticles", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ValidationState), typeof(bool), typeof(XmlSchemaSet)}, ReturnType = typeof(ArrayList))]
	[CalledBy(Type = typeof(AllElementsContentValidator), Member = "ExpectedParticles", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ValidationState), typeof(bool), typeof(XmlSchemaSet)}, ReturnType = typeof(ArrayList))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(ContentValidator), Member = "AddParticleToExpected", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaParticle), typeof(XmlSchemaSet), typeof(ArrayList), typeof(bool)}, ReturnType = typeof(void))]
	public static void AddParticleToExpected(XmlSchemaParticle p, XmlSchemaSet schemaSet, ArrayList particles) { }

	[CalledBy(Type = typeof(ContentValidator), Member = "AddParticleToExpected", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaParticle), typeof(XmlSchemaSet), typeof(ArrayList)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(XmlQualifiedName), Member = "get_IsEmpty", ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlSchemaSet), Member = "get_SubstitutionGroups", ReturnType = typeof(XmlSchemaObjectTable))]
	[Calls(Type = typeof(XmlSchemaObjectTable), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName)}, ReturnType = typeof(XmlSchemaObject))]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 3)]
	public static void AddParticleToExpected(XmlSchemaParticle p, XmlSchemaSet schemaSet, ArrayList particles, bool global) { }

	[CallerCount(Count = 23)]
	[DeduplicatedMethod]
	public override bool CompleteValidation(ValidationState context) { }

	[CallerCount(Count = 182)]
	[DeduplicatedMethod]
	public override ArrayList ExpectedElements(ValidationState context, bool isRequiredOnly) { }

	[CallerCount(Count = 182)]
	[DeduplicatedMethod]
	public override ArrayList ExpectedParticles(ValidationState context, bool isRequiredOnly, XmlSchemaSet schemaSet) { }

	[CallerCount(Count = 94)]
	[DeduplicatedMethod]
	public XmlSchemaContentType get_ContentType() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public override bool get_IsEmptiable() { }

	[CalledBy(Type = typeof(NfaContentValidator), Member = "ValidateElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName), typeof(ValidationState), typeof(Int32&)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(SchemaInfo), Member = "GetAttributeXdr", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SchemaElementDecl), typeof(XmlQualifiedName)}, ReturnType = typeof(SchemaAttDef))]
	[CalledBy(Type = typeof(XdrBuilder), Member = "XDR_BeginElementType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XdrBuilder)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XdrBuilder), Member = "XDR_EndElementType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XdrBuilder)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSchemaValidator), Member = "ElementValidationError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName), typeof(ValidationState), typeof(ValidationEventHandler), typeof(object), typeof(string), typeof(int), typeof(int), typeof(XmlSchemaSet)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	public bool get_IsOpen() { }

	[CalledBy(Type = typeof(DtdValidator), Member = "get_PreserveWhitespace", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XdrValidator), Member = "get_PreserveWhitespace", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XsdValidator), Member = "get_PreserveWhitespace", ReturnType = typeof(bool))]
	[CallerCount(Count = 3)]
	[ContainsUnimplementedInstructions]
	public bool get_PreserveWhitespace() { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	public override void InitValidation(ValidationState context) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void set_IsOpen(bool value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public override object ValidateElement(XmlQualifiedName name, ValidationState context, out int errorCode) { }

}

