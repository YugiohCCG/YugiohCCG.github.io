namespace System.Xml.Schema;

internal class NamespaceList
{
	internal enum ListType
	{
		Any = 0,
		Other = 1,
		Set = 2,
	}

	private ListType type; //Field offset: 0x10
	private Hashtable set; //Field offset: 0x18
	private string targetNamespace; //Field offset: 0x20

	public ICollection Enumerate
	{
		[CalledBy(Type = typeof(SymbolsDictionary), Member = "AddNamespaceList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NamespaceList), typeof(object), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XmlSchemaAny), Member = "get_NameString", ReturnType = typeof(string))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 4)]
		 get { } //Length: 118
	}

	public string Excluded
	{
		[CallerCount(Count = 12)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public ListType Type
	{
		[CallerCount(Count = 94)]
		[DeduplicatedMethod]
		 get { } //Length: 4
	}

	[CallerCount(Count = 2180)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public NamespaceList() { }

	[CalledBy(Type = typeof(NamespaceList), Member = "Union", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NamespaceList), typeof(NamespaceList), typeof(bool)}, ReturnType = typeof(NamespaceList))]
	[CalledBy(Type = typeof(NamespaceList), Member = "CompareSetToOther", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NamespaceList)}, ReturnType = typeof(NamespaceList))]
	[CalledBy(Type = typeof(NamespaceListV1Compat), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSchemaAny), Member = "BuildNamespaceList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSchemaAnyAttribute), Member = "BuildNamespaceList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSchemaComplexType), Member = "CreateAnyType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaContentProcessing)}, ReturnType = typeof(XmlSchemaComplexType))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(string), Member = "Trim", ReturnType = typeof(string))]
	[Calls(Type = typeof(Hashtable), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlConvert), Member = "SplitString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(String[]))]
	[Calls(Type = typeof(XmlConvert), Member = "ToUri", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Uri))]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 4)]
	public NamespaceList(string namespaces, string targetNamespace) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public override bool Allows(string ns) { }

	[CalledBy(Type = typeof(SymbolsDictionary), Member = "GetNamespaceListSymbols", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NamespaceList)}, ReturnType = typeof(ICollection))]
	[CalledBy(Type = typeof(SchemaInfo), Member = "GetAttributeXsd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SchemaElementDecl), typeof(XmlQualifiedName), typeof(XmlSchemaObject), typeof(AttributeMatchState&)}, ReturnType = typeof(SchemaAttDef))]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public bool Allows(XmlQualifiedName qname) { }

	[CalledBy(Type = typeof(NamespaceList), Member = "Union", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NamespaceList), typeof(NamespaceList), typeof(bool)}, ReturnType = typeof(NamespaceList))]
	[CalledBy(Type = typeof(NamespaceList), Member = "CompareSetToOther", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NamespaceList)}, ReturnType = typeof(NamespaceList))]
	[CalledBy(Type = typeof(NamespaceList), Member = "Intersection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NamespaceList), typeof(NamespaceList), typeof(bool)}, ReturnType = typeof(NamespaceList))]
	[CallerCount(Count = 10)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	public NamespaceList Clone() { }

	[CalledBy(Type = typeof(NamespaceList), Member = "Union", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NamespaceList), typeof(NamespaceList), typeof(bool)}, ReturnType = typeof(NamespaceList))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(NamespaceList), Member = "Clone", ReturnType = typeof(NamespaceList))]
	[Calls(Type = typeof(NamespaceList), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	private NamespaceList CompareSetToOther(NamespaceList other) { }

	[CalledBy(Type = typeof(SymbolsDictionary), Member = "AddNamespaceList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NamespaceList), typeof(object), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSchemaAny), Member = "get_NameString", ReturnType = typeof(string))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public ICollection get_Enumerate() { }

	[CallerCount(Count = 12)]
	[DeduplicatedMethod]
	public string get_Excluded() { }

	[CallerCount(Count = 94)]
	[DeduplicatedMethod]
	public ListType get_Type() { }

	[CalledBy(Type = typeof(XmlSchemaAnyAttribute), Member = "Intersection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaAnyAttribute), typeof(XmlSchemaAnyAttribute), typeof(bool)}, ReturnType = typeof(XmlSchemaAnyAttribute))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(NamespaceList), Member = "Clone", ReturnType = typeof(NamespaceList))]
	[Calls(Type = typeof(NamespaceList), Member = "RemoveNamespace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Hashtable), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 14)]
	public static NamespaceList Intersection(NamespaceList o1, NamespaceList o2, bool v1Compat) { }

	[CalledBy(Type = typeof(SchemaCollectionCompiler), Member = "IsValidRestriction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaParticle), typeof(XmlSchemaParticle)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(SchemaCollectionCompiler), Member = "IsAnyFromAny", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaAny), typeof(XmlSchemaAny)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Compiler), Member = "IsValidRestriction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaParticle), typeof(XmlSchemaParticle)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Compiler), Member = "IsAnyFromAny", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaAny), typeof(XmlSchemaAny)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XmlSchemaAnyAttribute), Member = "IsSubset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaAnyAttribute), typeof(XmlSchemaAnyAttribute)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 5)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 13)]
	[ContainsUnimplementedInstructions]
	public static bool IsSubset(NamespaceList sub, NamespaceList super) { }

	[CalledBy(Type = typeof(NamespaceList), Member = "Intersection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NamespaceList), typeof(NamespaceList), typeof(bool)}, ReturnType = typeof(NamespaceList))]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	private void RemoveNamespace(string tns) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(StringBuilder))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 16)]
	public virtual string ToString() { }

	[CalledBy(Type = typeof(XmlSchemaAnyAttribute), Member = "Union", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaAnyAttribute), typeof(XmlSchemaAnyAttribute), typeof(bool)}, ReturnType = typeof(XmlSchemaAnyAttribute))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(NamespaceList), Member = "Clone", ReturnType = typeof(NamespaceList))]
	[Calls(Type = typeof(NamespaceList), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(NamespaceList), Member = "CompareSetToOther", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NamespaceList)}, ReturnType = typeof(NamespaceList))]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 13)]
	public static NamespaceList Union(NamespaceList o1, NamespaceList o2, bool v1Compat) { }

}

