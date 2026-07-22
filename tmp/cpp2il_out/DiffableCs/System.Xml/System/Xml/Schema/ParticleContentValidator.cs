namespace System.Xml.Schema;

internal sealed class ParticleContentValidator : ContentValidator
{
	private SymbolsDictionary symbols; //Field offset: 0x18
	private Positions positions; //Field offset: 0x20
	private Stack stack; //Field offset: 0x28
	private SyntaxTreeNode contentNode; //Field offset: 0x30
	private bool isPartial; //Field offset: 0x38
	private int minMaxNodesCount; //Field offset: 0x3C
	private bool enableUpaCheck; //Field offset: 0x40

	[CalledBy(Type = typeof(DtdParser), Member = "ParseElementDecl", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SchemaCollectionCompiler), Member = "CompileComplexContent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaComplexType)}, ReturnType = typeof(ContentValidator))]
	[CalledBy(Type = typeof(XdrBuilder), Member = "XDR_InitElementType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XdrBuilder), typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XdrBuilder), Member = "XDR_BeginElementType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XdrBuilder)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSchemaComplexType), Member = "CreateAnyType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaContentProcessing)}, ReturnType = typeof(XmlSchemaComplexType))]
	[CallerCount(Count = 6)]
	[CallsDeduplicatedMethods(Count = 1)]
	public ParticleContentValidator(XmlSchemaContentType contentType) { }

	[CalledBy(Type = typeof(Compiler), Member = "CompileComplexContent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaComplexType)}, ReturnType = typeof(ContentValidator))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	public ParticleContentValidator(XmlSchemaContentType contentType, bool enableUpaCheck) { }

	[CalledBy(Type = typeof(DtdParser), Member = "ParseElementOnlyContent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParticleContentValidator), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DtdParser), Member = "ParseElementMixedContent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParticleContentValidator), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SchemaCollectionCompiler), Member = "BuildParticleContentModel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParticleContentValidator), typeof(XmlSchemaParticle)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Compiler), Member = "BuildParticleContentModel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParticleContentValidator), typeof(XmlSchemaParticle)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XdrBuilder), Member = "AddOrder", ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 3)]
	public void AddChoice() { }

	[CalledBy(Type = typeof(ParticleContentValidator), Member = "AddName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName), typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ParticleContentValidator), Member = "AddNamespaceList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NamespaceList), typeof(object)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 3)]
	private void AddLeafNode(SyntaxTreeNode node) { }

	[CalledBy(Type = typeof(SchemaCollectionCompiler), Member = "BuildParticleContentModel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParticleContentValidator), typeof(XmlSchemaParticle)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Compiler), Member = "BuildParticleContentModel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParticleContentValidator), typeof(XmlSchemaParticle)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Positions), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ParticleContentValidator), Member = "Closure", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InteriorNode)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public void AddLeafRange(decimal min, decimal max) { }

	[CalledBy(Type = typeof(DtdParser), Member = "ParseElementOnlyContent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParticleContentValidator), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DtdParser), Member = "ParseElementMixedContent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParticleContentValidator), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SchemaCollectionCompiler), Member = "BuildParticleContentModel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParticleContentValidator), typeof(XmlSchemaParticle)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Compiler), Member = "BuildParticleContentModel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParticleContentValidator), typeof(XmlSchemaParticle)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XdrBuilder), Member = "XDR_BuildElement_Type", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XdrBuilder), typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(SymbolsDictionary), Member = "AddName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName), typeof(object)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Positions), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ParticleContentValidator), Member = "AddLeafNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SyntaxTreeNode)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void AddName(XmlQualifiedName name, object particle) { }

	[CalledBy(Type = typeof(SchemaCollectionCompiler), Member = "BuildParticleContentModel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParticleContentValidator), typeof(XmlSchemaParticle)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Compiler), Member = "BuildParticleContentModel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParticleContentValidator), typeof(XmlSchemaParticle)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XmlSchemaComplexType), Member = "CreateAnyType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaContentProcessing)}, ReturnType = typeof(XmlSchemaComplexType))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(SymbolsDictionary), Member = "AddNamespaceList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NamespaceList), typeof(object), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ParticleContentValidator), Member = "AddLeafNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SyntaxTreeNode)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public void AddNamespaceList(NamespaceList namespaceList, object particle) { }

	[CalledBy(Type = typeof(DtdParser), Member = "ParseElementOnlyContent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParticleContentValidator), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DtdParser), Member = "ParseHowMany", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParticleContentValidator)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SchemaCollectionCompiler), Member = "BuildParticleContentModel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParticleContentValidator), typeof(XmlSchemaParticle)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Compiler), Member = "BuildParticleContentModel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParticleContentValidator), typeof(XmlSchemaParticle)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XdrBuilder), Member = "XDR_EndElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XdrBuilder)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XdrBuilder), Member = "XDR_EndGroup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XdrBuilder)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XdrBuilder), Member = "HandleMinMax", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParticleContentValidator), typeof(uint), typeof(uint)}, ReturnType = typeof(void))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(ParticleContentValidator), Member = "Closure", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InteriorNode)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	public void AddPlus() { }

	[CalledBy(Type = typeof(DtdParser), Member = "ParseElementOnlyContent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParticleContentValidator), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DtdParser), Member = "ParseHowMany", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParticleContentValidator)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SchemaCollectionCompiler), Member = "BuildParticleContentModel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParticleContentValidator), typeof(XmlSchemaParticle)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Compiler), Member = "BuildParticleContentModel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParticleContentValidator), typeof(XmlSchemaParticle)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XdrBuilder), Member = "XDR_EndElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XdrBuilder)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XdrBuilder), Member = "XDR_EndGroup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XdrBuilder)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XdrBuilder), Member = "HandleMinMax", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParticleContentValidator), typeof(uint), typeof(uint)}, ReturnType = typeof(void))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(ParticleContentValidator), Member = "Closure", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InteriorNode)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	public void AddQMark() { }

	[CalledBy(Type = typeof(DtdParser), Member = "ParseElementOnlyContent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParticleContentValidator), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SchemaCollectionCompiler), Member = "BuildParticleContentModel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParticleContentValidator), typeof(XmlSchemaParticle)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Compiler), Member = "BuildParticleContentModel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParticleContentValidator), typeof(XmlSchemaParticle)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XdrBuilder), Member = "AddOrder", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 3)]
	public void AddSequence() { }

	[CalledBy(Type = typeof(DtdParser), Member = "ParseElementOnlyContent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParticleContentValidator), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DtdParser), Member = "ParseHowMany", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParticleContentValidator)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DtdParser), Member = "ParseElementMixedContent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParticleContentValidator), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SchemaCollectionCompiler), Member = "BuildParticleContentModel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParticleContentValidator), typeof(XmlSchemaParticle)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Compiler), Member = "BuildParticleContentModel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParticleContentValidator), typeof(XmlSchemaParticle)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XdrBuilder), Member = "XDR_EndElementType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XdrBuilder)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XdrBuilder), Member = "XDR_EndElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XdrBuilder)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XdrBuilder), Member = "XDR_EndGroup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XdrBuilder)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XdrBuilder), Member = "HandleMinMax", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParticleContentValidator), typeof(uint), typeof(uint)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSchemaComplexType), Member = "CreateAnyType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaContentProcessing)}, ReturnType = typeof(XmlSchemaComplexType))]
	[CallerCount(Count = 12)]
	[Calls(Type = typeof(ParticleContentValidator), Member = "Closure", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InteriorNode)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	public void AddStar() { }

	[CalledBy(Type = typeof(ParticleContentValidator), Member = "Finish", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(ContentValidator))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ArrayList), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(Hashtable), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(Queue), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(BitSet), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BitSet), Member = "NextSet", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Positions), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Position))]
	[Calls(Type = typeof(BitSet), Member = "Or", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitSet)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[CallsDeduplicatedMethods(Count = 15)]
	[CallsUnknownMethods(Count = 12)]
	[ContainsUnimplementedInstructions]
	private Int32[][] BuildTransitionTable(BitSet firstpos, BitSet[] followpos, int endMarkerPos) { }

	[CalledBy(Type = typeof(ParticleContentValidator), Member = "Finish", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(ContentValidator))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BitSet), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BitSet), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(BitSet), Member = "Or", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitSet)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Decimal), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal), typeof(Decimal)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BitSet), Member = "NextSet", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Positions), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Position))]
	[Calls(Type = typeof(BitSet), Member = "Set", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 6)]
	private BitSet[] CalculateTotalFollowposForRangeNodes(BitSet firstpos, BitSet[] followpos, out BitSet posWithRangeTerminals) { }

	[CalledBy(Type = typeof(ParticleContentValidator), Member = "Finish", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(ContentValidator))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(BitSet), Member = "NextSet", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(UpaException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 12)]
	private void CheckCMUPAWithLeafRangeNodes(BitSet curpos) { }

	[CalledBy(Type = typeof(ParticleContentValidator), Member = "Finish", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(ContentValidator))]
	[CalledBy(Type = typeof(ParticleContentValidator), Member = "CheckUniqueParticleAttribution", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitSet), typeof(BitSet[])}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(BitSet), Member = "NextSet", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Positions), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Position))]
	[Calls(Type = typeof(UpaException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 13)]
	private void CheckUniqueParticleAttribution(BitSet curpos) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ParticleContentValidator), Member = "CheckUniqueParticleAttribution", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitSet)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void CheckUniqueParticleAttribution(BitSet firstpos, BitSet[] followpos) { }

	[CalledBy(Type = typeof(DtdParser), Member = "ParseElementOnlyContent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParticleContentValidator), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DtdParser), Member = "ParseElementMixedContent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParticleContentValidator), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SchemaCollectionCompiler), Member = "BuildParticleContentModel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParticleContentValidator), typeof(XmlSchemaParticle)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Compiler), Member = "BuildParticleContentModel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParticleContentValidator), typeof(XmlSchemaParticle)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XdrBuilder), Member = "XDR_EndElementType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XdrBuilder)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XdrBuilder), Member = "XDR_EndGroup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XdrBuilder)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSchemaComplexType), Member = "CreateAnyType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaContentProcessing)}, ReturnType = typeof(XmlSchemaComplexType))]
	[CallerCount(Count = 7)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 5)]
	public void CloseGroup() { }

	[CalledBy(Type = typeof(ParticleContentValidator), Member = "AddStar", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ParticleContentValidator), Member = "AddPlus", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ParticleContentValidator), Member = "AddQMark", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ParticleContentValidator), Member = "AddLeafRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal), typeof(Decimal)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 6)]
	private void Closure(InteriorNode node) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public virtual bool CompleteValidation(ValidationState context) { }

	[CalledBy(Type = typeof(DtdParser), Member = "ParseElementMixedContent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParticleContentValidator), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public bool Exists(XmlQualifiedName name) { }

	[CalledBy(Type = typeof(DtdParser), Member = "ParseElementDecl", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SchemaCollectionCompiler), Member = "CompileComplexContent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaComplexType)}, ReturnType = typeof(ContentValidator))]
	[CalledBy(Type = typeof(Compiler), Member = "CompileComplexContent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaComplexType)}, ReturnType = typeof(ContentValidator))]
	[CalledBy(Type = typeof(XdrBuilder), Member = "XDR_EndElementType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XdrBuilder)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSchemaComplexType), Member = "CreateAnyType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaContentProcessing)}, ReturnType = typeof(XmlSchemaComplexType))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(RangeContentValidator), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitSet), typeof(BitSet[]), typeof(SymbolsDictionary), typeof(Positions), typeof(int), typeof(XmlSchemaContentType), typeof(bool), typeof(BitSet), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ParticleContentValidator), Member = "CheckCMUPAWithLeafRangeNodes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitSet)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BitSet), Member = "NextSet", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(BitSet), Member = "Clone", ReturnType = typeof(BitSet))]
	[Calls(Type = typeof(BitSet), Member = "EnsureLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Math), Member = "Min", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ParticleContentValidator), Member = "CheckUniqueParticleAttribution", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitSet)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NfaContentValidator), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitSet), typeof(BitSet[]), typeof(SymbolsDictionary), typeof(Positions), typeof(int), typeof(XmlSchemaContentType), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ParticleContentValidator), Member = "BuildTransitionTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitSet), typeof(BitSet[]), typeof(int)}, ReturnType = typeof(Int32[][]))]
	[Calls(Type = typeof(Positions), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(SymbolsDictionary), Member = "AddName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName), typeof(object)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ParticleContentValidator), Member = "CalculateTotalFollowposForRangeNodes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitSet), typeof(BitSet[]), typeof(BitSet&)}, ReturnType = typeof(BitSet[]))]
	[CallsDeduplicatedMethods(Count = 19)]
	[CallsUnknownMethods(Count = 14)]
	public ContentValidator Finish(bool useDFA) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Math), Member = "Min", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(BitSet), Member = "EnsureLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BitSet), Member = "Clone", ReturnType = typeof(BitSet))]
	[Calls(Type = typeof(BitSet), Member = "NextSet", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	private BitSet GetApplicableMinMaxFollowPos(BitSet curpos, BitSet posWithRangeTerminals, BitSet[] minmaxFollowPos) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public virtual void InitValidation(ValidationState context) { }

	[CalledBy(Type = typeof(DtdParser), Member = "ParseElementDecl", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DtdParser), Member = "ParseElementOnlyContent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParticleContentValidator), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SchemaCollectionCompiler), Member = "BuildParticleContentModel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParticleContentValidator), typeof(XmlSchemaParticle)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Compiler), Member = "BuildParticleContentModel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParticleContentValidator), typeof(XmlSchemaParticle)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XdrBuilder), Member = "XDR_BeginElementType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XdrBuilder)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XdrBuilder), Member = "XDR_InitGroup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XdrBuilder), typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSchemaComplexType), Member = "CreateAnyType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaContentProcessing)}, ReturnType = typeof(XmlSchemaComplexType))]
	[CallerCount(Count = 8)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void OpenGroup() { }

	[CalledBy(Type = typeof(DtdParser), Member = "ParseElementDecl", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SchemaCollectionCompiler), Member = "CompileComplexContent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaComplexType)}, ReturnType = typeof(ContentValidator))]
	[CalledBy(Type = typeof(Compiler), Member = "CompileComplexContent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaComplexType)}, ReturnType = typeof(ContentValidator))]
	[CalledBy(Type = typeof(XdrBuilder), Member = "XDR_BeginElementType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XdrBuilder)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSchemaComplexType), Member = "CreateAnyType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaContentProcessing)}, ReturnType = typeof(XmlSchemaComplexType))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(Hashtable), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(ArrayList), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(Stack), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 6)]
	public void Start() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public virtual object ValidateElement(XmlQualifiedName name, ValidationState context, out int errorCode) { }

}

