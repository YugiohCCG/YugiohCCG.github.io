namespace System.Xml.Schema;

[DefaultMember("Item")]
internal class Positions
{
	private ArrayList positions; //Field offset: 0x10

	public int Count
	{
		[CallerCount(Count = 244)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 39
	}

	public Position Item
	{
		[CalledBy(Type = typeof(ParticleContentValidator), Member = "CalculateTotalFollowposForRangeNodes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitSet), typeof(BitSet[]), typeof(BitSet&)}, ReturnType = typeof(BitSet[]))]
		[CalledBy(Type = typeof(ParticleContentValidator), Member = "CheckUniqueParticleAttribution", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitSet)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ParticleContentValidator), Member = "BuildTransitionTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitSet), typeof(BitSet[]), typeof(int)}, ReturnType = typeof(Int32[][]))]
		[CalledBy(Type = typeof(NfaContentValidator), Member = "ValidateElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName), typeof(ValidationState), typeof(Int32&)}, ReturnType = typeof(object))]
		[CalledBy(Type = typeof(NfaContentValidator), Member = "ExpectedElements", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ValidationState), typeof(bool)}, ReturnType = typeof(ArrayList))]
		[CalledBy(Type = typeof(NfaContentValidator), Member = "ExpectedParticles", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ValidationState), typeof(bool), typeof(XmlSchemaSet)}, ReturnType = typeof(ArrayList))]
		[CalledBy(Type = typeof(RangeContentValidator), Member = "ValidateElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName), typeof(ValidationState), typeof(Int32&)}, ReturnType = typeof(object))]
		[CalledBy(Type = typeof(RangeContentValidator), Member = "ExpectedElements", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ValidationState), typeof(bool)}, ReturnType = typeof(ArrayList))]
		[CalledBy(Type = typeof(RangeContentValidator), Member = "ExpectedParticles", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ValidationState), typeof(bool), typeof(XmlSchemaSet)}, ReturnType = typeof(ArrayList))]
		[CallerCount(Count = 19)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		 get { } //Length: 151
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ArrayList), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public Positions() { }

	[CalledBy(Type = typeof(NamespaceListNode), Member = "ExpandTree", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InteriorNode), typeof(SymbolsDictionary), typeof(Positions)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ParticleContentValidator), Member = "AddName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName), typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ParticleContentValidator), Member = "AddLeafRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal), typeof(Decimal)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ParticleContentValidator), Member = "Finish", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(ContentValidator))]
	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public int Add(int symbol, object particle) { }

	[CallerCount(Count = 244)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public int get_Count() { }

	[CalledBy(Type = typeof(ParticleContentValidator), Member = "CalculateTotalFollowposForRangeNodes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitSet), typeof(BitSet[]), typeof(BitSet&)}, ReturnType = typeof(BitSet[]))]
	[CalledBy(Type = typeof(ParticleContentValidator), Member = "CheckUniqueParticleAttribution", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitSet)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ParticleContentValidator), Member = "BuildTransitionTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitSet), typeof(BitSet[]), typeof(int)}, ReturnType = typeof(Int32[][]))]
	[CalledBy(Type = typeof(NfaContentValidator), Member = "ValidateElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName), typeof(ValidationState), typeof(Int32&)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(NfaContentValidator), Member = "ExpectedElements", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ValidationState), typeof(bool)}, ReturnType = typeof(ArrayList))]
	[CalledBy(Type = typeof(NfaContentValidator), Member = "ExpectedParticles", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ValidationState), typeof(bool), typeof(XmlSchemaSet)}, ReturnType = typeof(ArrayList))]
	[CalledBy(Type = typeof(RangeContentValidator), Member = "ValidateElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName), typeof(ValidationState), typeof(Int32&)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(RangeContentValidator), Member = "ExpectedElements", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ValidationState), typeof(bool)}, ReturnType = typeof(ArrayList))]
	[CalledBy(Type = typeof(RangeContentValidator), Member = "ExpectedParticles", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ValidationState), typeof(bool), typeof(XmlSchemaSet)}, ReturnType = typeof(ArrayList))]
	[CallerCount(Count = 19)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public Position get_Item(int pos) { }

}

