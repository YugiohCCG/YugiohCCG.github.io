namespace System.Xml.Schema;

[DefaultMember("Item")]
internal sealed class BitSet
{
	private int count; //Field offset: 0x10
	private UInt32[] bits; //Field offset: 0x18

	public int Count
	{
		[CallerCount(Count = 94)]
		[DeduplicatedMethod]
		 get { } //Length: 4
	}

	public bool IsEmpty
	{
		[CalledBy(Type = typeof(NfaContentValidator), Member = "ValidateElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName), typeof(ValidationState), typeof(Int32&)}, ReturnType = typeof(object))]
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 68
	}

	public bool Item
	{
		[CallerCount(Count = 16)]
		[CallsUnknownMethods(Count = 2)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		 get { } //Length: 79
	}

	[CallerCount(Count = 2180)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	private BitSet() { }

	[CalledBy(Type = typeof(ParticleContentValidator), Member = "CalculateTotalFollowposForRangeNodes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitSet), typeof(BitSet[]), typeof(BitSet&)}, ReturnType = typeof(BitSet[]))]
	[CalledBy(Type = typeof(ParticleContentValidator), Member = "BuildTransitionTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitSet), typeof(BitSet[]), typeof(int)}, ReturnType = typeof(Int32[][]))]
	[CalledBy(Type = typeof(NfaContentValidator), Member = "InitValidation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ValidationState)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RangeContentValidator), Member = "ExpectedElements", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ValidationState), typeof(bool)}, ReturnType = typeof(ArrayList))]
	[CalledBy(Type = typeof(RangeContentValidator), Member = "ExpectedParticles", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ValidationState), typeof(bool), typeof(XmlSchemaSet)}, ReturnType = typeof(ArrayList))]
	[CalledBy(Type = typeof(AllElementsContentValidator), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaContentType), typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(AllElementsContentValidator), Member = "InitValidation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ValidationState)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SchemaCollectionCompiler), Member = "IsSequenceFromAll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaSequence), typeof(XmlSchemaAll)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Compiler), Member = "IsSequenceFromAll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaSequence), typeof(XmlSchemaAll)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 9)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public BitSet(int count) { }

	[CalledBy(Type = typeof(RangeContentValidator), Member = "ValidateElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName), typeof(ValidationState), typeof(Int32&)}, ReturnType = typeof(object))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void And(BitSet other) { }

	[CalledBy(Type = typeof(ParticleContentValidator), Member = "CalculateTotalFollowposForRangeNodes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitSet), typeof(BitSet[]), typeof(BitSet&)}, ReturnType = typeof(BitSet[]))]
	[CalledBy(Type = typeof(NfaContentValidator), Member = "ValidateElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName), typeof(ValidationState), typeof(Int32&)}, ReturnType = typeof(object))]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public void Clear() { }

	[CalledBy(Type = typeof(SequenceNode), Member = "ConstructPos", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitSet), typeof(BitSet), typeof(BitSet[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ParticleContentValidator), Member = "Finish", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(ContentValidator))]
	[CalledBy(Type = typeof(ParticleContentValidator), Member = "GetApplicableMinMaxFollowPos", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitSet), typeof(BitSet), typeof(BitSet[])}, ReturnType = typeof(BitSet))]
	[CalledBy(Type = typeof(NfaContentValidator), Member = "InitValidation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ValidationState)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RangeContentValidator), Member = "InitValidation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ValidationState)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RangeContentValidator), Member = "ValidateElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName), typeof(ValidationState), typeof(Int32&)}, ReturnType = typeof(object))]
	[CallerCount(Count = 7)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 6)]
	public BitSet Clone() { }

	[CalledBy(Type = typeof(BitSet), Member = "Set", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BitSet), Member = "Or", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitSet)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LeafNode), Member = "ConstructPos", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitSet), typeof(BitSet), typeof(BitSet[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SequenceNode), Member = "ConstructPos", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitSet), typeof(BitSet), typeof(BitSet[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ChoiceNode), Member = "ConstructChildPos", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SyntaxTreeNode), typeof(BitSet), typeof(BitSet), typeof(BitSet[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ChoiceNode), Member = "ConstructPos", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitSet), typeof(BitSet), typeof(BitSet[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PlusNode), Member = "ConstructPos", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitSet), typeof(BitSet), typeof(BitSet[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(StarNode), Member = "ConstructPos", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitSet), typeof(BitSet), typeof(BitSet[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ParticleContentValidator), Member = "Finish", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(ContentValidator))]
	[CalledBy(Type = typeof(ParticleContentValidator), Member = "GetApplicableMinMaxFollowPos", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitSet), typeof(BitSet), typeof(BitSet[])}, ReturnType = typeof(BitSet))]
	[CallerCount(Count = 19)]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(Array), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	private void EnsureLength(int nRequiredLength) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 3)]
	public virtual bool Equals(object obj) { }

	[CallerCount(Count = 16)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public bool Get(int index) { }

	[CallerCount(Count = 94)]
	[DeduplicatedMethod]
	public int get_Count() { }

	[CalledBy(Type = typeof(NfaContentValidator), Member = "ValidateElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName), typeof(ValidationState), typeof(Int32&)}, ReturnType = typeof(object))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	public bool get_IsEmpty() { }

	[CallerCount(Count = 16)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public bool get_Item(int index) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public virtual int GetHashCode() { }

	[CalledBy(Type = typeof(RangeContentValidator), Member = "ValidateElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName), typeof(ValidationState), typeof(Int32&)}, ReturnType = typeof(object))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Math), Member = "Min", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 2)]
	public bool Intersects(BitSet other) { }

	[CalledBy(Type = typeof(PlusNode), Member = "ConstructPos", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitSet), typeof(BitSet), typeof(BitSet[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(StarNode), Member = "ConstructPos", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitSet), typeof(BitSet), typeof(BitSet[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ParticleContentValidator), Member = "Finish", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(ContentValidator))]
	[CalledBy(Type = typeof(ParticleContentValidator), Member = "CalculateTotalFollowposForRangeNodes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitSet), typeof(BitSet[]), typeof(BitSet&)}, ReturnType = typeof(BitSet[]))]
	[CalledBy(Type = typeof(ParticleContentValidator), Member = "CheckCMUPAWithLeafRangeNodes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitSet)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ParticleContentValidator), Member = "GetApplicableMinMaxFollowPos", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitSet), typeof(BitSet), typeof(BitSet[])}, ReturnType = typeof(BitSet))]
	[CalledBy(Type = typeof(ParticleContentValidator), Member = "CheckUniqueParticleAttribution", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitSet)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ParticleContentValidator), Member = "BuildTransitionTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitSet), typeof(BitSet[]), typeof(int)}, ReturnType = typeof(Int32[][]))]
	[CalledBy(Type = typeof(NfaContentValidator), Member = "ValidateElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName), typeof(ValidationState), typeof(Int32&)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(NfaContentValidator), Member = "ExpectedElements", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ValidationState), typeof(bool)}, ReturnType = typeof(ArrayList))]
	[CalledBy(Type = typeof(NfaContentValidator), Member = "ExpectedParticles", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ValidationState), typeof(bool), typeof(XmlSchemaSet)}, ReturnType = typeof(ArrayList))]
	[CalledBy(Type = typeof(RangeContentValidator), Member = "ValidateElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName), typeof(ValidationState), typeof(Int32&)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(RangeContentValidator), Member = "ExpectedElements", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ValidationState), typeof(bool)}, ReturnType = typeof(ArrayList))]
	[CalledBy(Type = typeof(RangeContentValidator), Member = "ExpectedParticles", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ValidationState), typeof(bool), typeof(XmlSchemaSet)}, ReturnType = typeof(ArrayList))]
	[CallerCount(Count = 26)]
	[CallsUnknownMethods(Count = 2)]
	public int NextSet(int startFrom) { }

	[CalledBy(Type = typeof(ParticleContentValidator), Member = "CalculateTotalFollowposForRangeNodes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitSet), typeof(BitSet[]), typeof(BitSet&)}, ReturnType = typeof(BitSet[]))]
	[CalledBy(Type = typeof(ParticleContentValidator), Member = "BuildTransitionTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitSet), typeof(BitSet[]), typeof(int)}, ReturnType = typeof(Int32[][]))]
	[CalledBy(Type = typeof(NfaContentValidator), Member = "ValidateElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName), typeof(ValidationState), typeof(Int32&)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(RangeContentValidator), Member = "ExpectedElements", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ValidationState), typeof(bool)}, ReturnType = typeof(ArrayList))]
	[CalledBy(Type = typeof(RangeContentValidator), Member = "ExpectedParticles", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ValidationState), typeof(bool), typeof(XmlSchemaSet)}, ReturnType = typeof(ArrayList))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(BitSet), Member = "EnsureLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	public void Or(BitSet other) { }

	[CalledBy(Type = typeof(ParticleContentValidator), Member = "CalculateTotalFollowposForRangeNodes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitSet), typeof(BitSet[]), typeof(BitSet&)}, ReturnType = typeof(BitSet[]))]
	[CalledBy(Type = typeof(AllElementsContentValidator), Member = "AddElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName), typeof(object), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(AllElementsContentValidator), Member = "ValidateElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName), typeof(ValidationState), typeof(Int32&)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(SchemaCollectionCompiler), Member = "IsSequenceFromAll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaSequence), typeof(XmlSchemaAll)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Compiler), Member = "IsSequenceFromAll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaSequence), typeof(XmlSchemaAll)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(BitSet), Member = "EnsureLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	public void Set(int index) { }

	[CallerCount(Count = 0)]
	private int Subscript(int bitIndex) { }

}

