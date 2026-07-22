namespace System.Xml.Schema;

[DefaultMember("Item")]
internal class SymbolsDictionary
{
	private int last; //Field offset: 0x10
	private Hashtable names; //Field offset: 0x18
	private Hashtable wildcards; //Field offset: 0x20
	private ArrayList particles; //Field offset: 0x28
	private object particleLast; //Field offset: 0x30
	private bool isUpaEnforced; //Field offset: 0x38

	public int Count
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 6
	}

	public bool IsUpaEnforced
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	public int Item
	{
		[CalledBy(Type = typeof(NfaContentValidator), Member = "ValidateElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName), typeof(ValidationState), typeof(Int32&)}, ReturnType = typeof(object))]
		[CalledBy(Type = typeof(RangeContentValidator), Member = "ValidateElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName), typeof(ValidationState), typeof(Int32&)}, ReturnType = typeof(object))]
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 3)]
		 get { } //Length: 193
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Hashtable), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(ArrayList), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public SymbolsDictionary() { }

	[CalledBy(Type = typeof(ParticleContentValidator), Member = "AddName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName), typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ParticleContentValidator), Member = "Finish", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(ContentValidator))]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 3)]
	public int AddName(XmlQualifiedName name, object particle) { }

	[CalledBy(Type = typeof(ParticleContentValidator), Member = "AddNamespaceList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NamespaceList), typeof(object)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(NamespaceList), Member = "get_Enumerate", ReturnType = typeof(ICollection))]
	[Calls(Type = typeof(SymbolsDictionary), Member = "AddWildcard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 12)]
	public void AddNamespaceList(NamespaceList list, object particle, bool allowLocal) { }

	[CalledBy(Type = typeof(SymbolsDictionary), Member = "AddNamespaceList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NamespaceList), typeof(object), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Hashtable), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 4)]
	private void AddWildcard(string wildcard, object particle) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public bool Exists(XmlQualifiedName name) { }

	[CallerCount(Count = 0)]
	public int get_Count() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public bool get_IsUpaEnforced() { }

	[CalledBy(Type = typeof(NfaContentValidator), Member = "ValidateElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName), typeof(ValidationState), typeof(Int32&)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(RangeContentValidator), Member = "ValidateElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName), typeof(ValidationState), typeof(Int32&)}, ReturnType = typeof(object))]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public int get_Item(XmlQualifiedName name) { }

	[CalledBy(Type = typeof(NamespaceListNode), Member = "GetResolvedSymbols", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SymbolsDictionary)}, ReturnType = typeof(ICollection))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ArrayList), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlQualifiedName), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName), typeof(XmlQualifiedName)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(NamespaceList), Member = "Allows", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 11)]
	[CallsUnknownMethods(Count = 28)]
	public ICollection GetNamespaceListSymbols(NamespaceList list) { }

	[CalledBy(Type = typeof(DfaContentValidator), Member = "ExpectedElements", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ValidationState), typeof(bool)}, ReturnType = typeof(ArrayList))]
	[CalledBy(Type = typeof(DfaContentValidator), Member = "ExpectedParticles", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ValidationState), typeof(bool), typeof(XmlSchemaSet)}, ReturnType = typeof(ArrayList))]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public object GetParticle(int symbol) { }

	[CalledBy(Type = typeof(DfaContentValidator), Member = "ExpectedElements", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ValidationState), typeof(bool)}, ReturnType = typeof(ArrayList))]
	[CalledBy(Type = typeof(NfaContentValidator), Member = "ExpectedElements", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ValidationState), typeof(bool)}, ReturnType = typeof(ArrayList))]
	[CalledBy(Type = typeof(RangeContentValidator), Member = "ExpectedElements", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ValidationState), typeof(bool)}, ReturnType = typeof(ArrayList))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 30)]
	public string NameOf(int symbol) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void set_IsUpaEnforced(bool value) { }

}

