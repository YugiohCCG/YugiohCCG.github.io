namespace System.Xml.Schema;

internal sealed class AllElementsContentValidator : ContentValidator
{
	private Hashtable elements; //Field offset: 0x18
	private Object[] particles; //Field offset: 0x20
	private BitSet isRequired; //Field offset: 0x28
	private int countRequired; //Field offset: 0x30

	public virtual bool IsEmptiable
	{
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 17
	}

	[CalledBy(Type = typeof(SchemaCollectionCompiler), Member = "CompileComplexContent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaComplexType)}, ReturnType = typeof(ContentValidator))]
	[CalledBy(Type = typeof(Compiler), Member = "CompileComplexContent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaComplexType)}, ReturnType = typeof(ContentValidator))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ContentValidator), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaContentType), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Hashtable), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BitSet), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public AllElementsContentValidator(XmlSchemaContentType contentType, int size, bool isEmptiable) { }

	[CalledBy(Type = typeof(SchemaCollectionCompiler), Member = "CompileComplexContent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaComplexType)}, ReturnType = typeof(ContentValidator))]
	[CalledBy(Type = typeof(Compiler), Member = "CompileComplexContent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaComplexType)}, ReturnType = typeof(ContentValidator))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(BitSet), Member = "Set", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 7)]
	public bool AddElement(XmlQualifiedName name, object particle, bool isEmptiable) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public virtual bool CompleteValidation(ValidationState context) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ArrayList), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 18)]
	public virtual ArrayList ExpectedElements(ValidationState context, bool isRequiredOnly) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ArrayList), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(ContentValidator), Member = "AddParticleToExpected", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaParticle), typeof(XmlSchemaSet), typeof(ArrayList)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 20)]
	public virtual ArrayList ExpectedParticles(ValidationState context, bool isRequiredOnly, XmlSchemaSet schemaSet) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public virtual bool get_IsEmptiable() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BitSet), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public virtual void InitValidation(ValidationState context) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BitSet), Member = "Set", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 3)]
	public virtual object ValidateElement(XmlQualifiedName name, ValidationState context, out int errorCode) { }

}

