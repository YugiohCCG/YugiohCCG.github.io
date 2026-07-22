namespace System.Xml.Schema;

internal sealed class NfaContentValidator : ContentValidator
{
	private BitSet firstpos; //Field offset: 0x18
	private BitSet[] followpos; //Field offset: 0x20
	private SymbolsDictionary symbols; //Field offset: 0x28
	private Positions positions; //Field offset: 0x30
	private int endMarkerPos; //Field offset: 0x38

	[CalledBy(Type = typeof(ParticleContentValidator), Member = "Finish", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(ContentValidator))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ContentValidator), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaContentType), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	internal NfaContentValidator(BitSet firstpos, BitSet[] followpos, SymbolsDictionary symbols, Positions positions, int endMarkerPos, XmlSchemaContentType contentType, bool isOpen, bool isEmptiable) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	public virtual bool CompleteValidation(ValidationState context) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BitSet), Member = "NextSet", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ArrayList), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(Positions), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Position))]
	[Calls(Type = typeof(SymbolsDictionary), Member = "NameOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 3)]
	public virtual ArrayList ExpectedElements(ValidationState context, bool isRequiredOnly) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ArrayList), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(BitSet), Member = "NextSet", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Positions), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Position))]
	[Calls(Type = typeof(ContentValidator), Member = "AddParticleToExpected", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaParticle), typeof(XmlSchemaSet), typeof(ArrayList)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public virtual ArrayList ExpectedParticles(ValidationState context, bool isRequiredOnly, XmlSchemaSet schemaSet) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BitSet), Member = "Clone", ReturnType = typeof(BitSet))]
	[Calls(Type = typeof(BitSet), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	public virtual void InitValidation(ValidationState context) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BitSet), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(SymbolsDictionary), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(BitSet), Member = "NextSet", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Positions), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Position))]
	[Calls(Type = typeof(BitSet), Member = "Or", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitSet)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BitSet), Member = "get_IsEmpty", ReturnType = typeof(bool))]
	[Calls(Type = typeof(ContentValidator), Member = "get_IsOpen", ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public virtual object ValidateElement(XmlQualifiedName name, ValidationState context, out int errorCode) { }

}

