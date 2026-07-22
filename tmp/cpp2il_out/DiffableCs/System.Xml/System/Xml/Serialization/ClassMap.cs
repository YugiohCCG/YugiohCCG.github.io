namespace System.Xml.Serialization;

internal class ClassMap : ObjectMap
{
	private Hashtable _elements; //Field offset: 0x10
	private ArrayList _elementMembers; //Field offset: 0x18
	private Hashtable _attributeMembers; //Field offset: 0x20
	private XmlTypeMapMemberAttribute[] _attributeMembersArray; //Field offset: 0x28
	private ArrayList _flatLists; //Field offset: 0x30
	private ArrayList _allMembers; //Field offset: 0x38
	private ArrayList _membersWithDefault; //Field offset: 0x40
	private ArrayList _listMembers; //Field offset: 0x48
	private XmlTypeMapMemberAnyElement _defaultAnyElement; //Field offset: 0x50
	private XmlTypeMapMemberAnyAttribute _defaultAnyAttribute; //Field offset: 0x58
	private XmlTypeMapMemberNamespaces _namespaceDeclarations; //Field offset: 0x60
	private XmlTypeMapMember _xmlTextCollector; //Field offset: 0x68
	private XmlTypeMapMember _returnMember; //Field offset: 0x70
	private bool _ignoreMemberNamespace; //Field offset: 0x78
	private bool _canBeSimpleType; //Field offset: 0x79
	private Nullable<Boolean> _isOrderDependentMap; //Field offset: 0x7A

	public ArrayList AllMembers
	{
		[CallerCount(Count = 38)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public ICollection AttributeMembers
	{
		[CalledBy(Type = typeof(XmlSerializationWriterInterpreter), Member = "WriteAttributeMembers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ClassMap), typeof(object), typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 19)]
		 get { } //Length: 789
	}

	public XmlTypeMapMemberAnyAttribute DefaultAnyAttributeMember
	{
		[CallerCount(Count = 10)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public XmlTypeMapMemberAnyElement DefaultAnyElementMember
	{
		[CallerCount(Count = 16)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public ICollection ElementMembers
	{
		[CallerCount(Count = 31)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public ArrayList FlatLists
	{
		[CallerCount(Count = 62)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public bool HasSimpleContent
	{
		[CalledBy(Type = typeof(XmlReflectionImporter), Member = "ImportClassMapping", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TypeData), typeof(XmlRootAttribute), typeof(string), typeof(bool)}, ReturnType = typeof(XmlTypeMapping))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(ClassMap), Member = "get_SimpleContentBaseType", ReturnType = typeof(XmlQualifiedName))]
		[Calls(Type = typeof(XmlQualifiedName), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName), typeof(XmlQualifiedName)}, ReturnType = typeof(bool))]
		 get { } //Length: 89
	}

	public bool IsOrderDependentMap
	{
		[CalledBy(Type = typeof(XmlSerializationReaderInterpreter), Member = "ReadMembers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ClassMap), typeof(object), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Nullable`1), Member = "get_Value", ReturnType = "T")]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 13)]
		 get { } //Length: 619
	}

	public ArrayList ListMembers
	{
		[CallerCount(Count = 10)]
		[DeduplicatedMethod]
		 get { } //Length: 254
	}

	public XmlTypeMapMemberNamespaces NamespaceDeclarations
	{
		[CallerCount(Count = 84)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public XmlTypeMapMember ReturnMember
	{
		[CallerCount(Count = 9)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public XmlQualifiedName SimpleContentBaseType
	{
		[CalledBy(Type = typeof(ClassMap), Member = "get_HasSimpleContent", ReturnType = typeof(bool))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(XmlTypeMapMemberElement), Member = "get_ElementInfo", ReturnType = typeof(XmlTypeMapElementInfoList))]
		[Calls(Type = typeof(XmlTypeMapElementInfo), Member = "get_IsTextElement", ReturnType = typeof(bool))]
		[Calls(Type = typeof(XmlTypeMapElementInfo), Member = "get_DataTypeNamespace", ReturnType = typeof(string))]
		[Calls(Type = typeof(XmlQualifiedName), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 4)]
		[CallsUnknownMethods(Count = 3)]
		 get { } //Length: 530
	}

	public XmlTypeMapMember XmlTextCollector
	{
		[CallerCount(Count = 22)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	[CalledBy(Type = typeof(XmlReflectionImporter), Member = "ImportClassMapping", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TypeData), typeof(XmlRootAttribute), typeof(string), typeof(bool)}, ReturnType = typeof(XmlTypeMapping))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Hashtable), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(ArrayList), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public ClassMap() { }

	[CalledBy(Type = typeof(XmlReflectionImporter), Member = "ImportClassMapping", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TypeData), typeof(XmlRootAttribute), typeof(string), typeof(bool)}, ReturnType = typeof(XmlTypeMapping))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Type), Member = "get_IsArray", ReturnType = typeof(bool))]
	[Calls(Type = typeof(ClassMap), Member = "BuildKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(XmlTypeMapMemberElement), Member = "get_ElementInfo", ReturnType = typeof(XmlTypeMapElementInfoList))]
	[Calls(Type = typeof(ClassMap), Member = "RegisterFlatList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlTypeMapMemberExpandable)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TypeData), Member = "get_IsListType", ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlTypeMapMemberAnyElement), Member = "get_IsDefaultAny", ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(Hashtable), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(ArrayList), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 16)]
	[CallsUnknownMethods(Count = 74)]
	public void AddMember(XmlTypeMapMember member) { }

	[CalledBy(Type = typeof(ClassMap), Member = "AddMember", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlTypeMapMember)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	private string BuildKey(string name, string ns, int explicitOrder) { }

	[CallerCount(Count = 38)]
	[DeduplicatedMethod]
	public ArrayList get_AllMembers() { }

	[CalledBy(Type = typeof(XmlSerializationWriterInterpreter), Member = "WriteAttributeMembers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ClassMap), typeof(object), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 19)]
	public ICollection get_AttributeMembers() { }

	[CallerCount(Count = 10)]
	[DeduplicatedMethod]
	public XmlTypeMapMemberAnyAttribute get_DefaultAnyAttributeMember() { }

	[CallerCount(Count = 16)]
	[DeduplicatedMethod]
	public XmlTypeMapMemberAnyElement get_DefaultAnyElementMember() { }

	[CallerCount(Count = 31)]
	[DeduplicatedMethod]
	public ICollection get_ElementMembers() { }

	[CallerCount(Count = 62)]
	[DeduplicatedMethod]
	public ArrayList get_FlatLists() { }

	[CalledBy(Type = typeof(XmlReflectionImporter), Member = "ImportClassMapping", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TypeData), typeof(XmlRootAttribute), typeof(string), typeof(bool)}, ReturnType = typeof(XmlTypeMapping))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(ClassMap), Member = "get_SimpleContentBaseType", ReturnType = typeof(XmlQualifiedName))]
	[Calls(Type = typeof(XmlQualifiedName), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName), typeof(XmlQualifiedName)}, ReturnType = typeof(bool))]
	public bool get_HasSimpleContent() { }

	[CalledBy(Type = typeof(XmlSerializationReaderInterpreter), Member = "ReadMembers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ClassMap), typeof(object), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Nullable`1), Member = "get_Value", ReturnType = "T")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 13)]
	public bool get_IsOrderDependentMap() { }

	[CallerCount(Count = 10)]
	[DeduplicatedMethod]
	public ArrayList get_ListMembers() { }

	[CallerCount(Count = 84)]
	[DeduplicatedMethod]
	public XmlTypeMapMemberNamespaces get_NamespaceDeclarations() { }

	[CallerCount(Count = 9)]
	[DeduplicatedMethod]
	public XmlTypeMapMember get_ReturnMember() { }

	[CalledBy(Type = typeof(ClassMap), Member = "get_HasSimpleContent", ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(XmlTypeMapMemberElement), Member = "get_ElementInfo", ReturnType = typeof(XmlTypeMapElementInfoList))]
	[Calls(Type = typeof(XmlTypeMapElementInfo), Member = "get_IsTextElement", ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlTypeMapElementInfo), Member = "get_DataTypeNamespace", ReturnType = typeof(string))]
	[Calls(Type = typeof(XmlQualifiedName), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 3)]
	public XmlQualifiedName get_SimpleContentBaseType() { }

	[CallerCount(Count = 22)]
	[DeduplicatedMethod]
	public XmlTypeMapMember get_XmlTextCollector() { }

	[CalledBy(Type = typeof(XmlSerializationReaderInterpreter), Member = "ReadAttributeMembers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ClassMap), typeof(object), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public XmlTypeMapMemberAttribute GetAttribute(string name, string ns) { }

	[CalledBy(Type = typeof(XmlSerializationReaderInterpreter), Member = "ReadMembers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ClassMap), typeof(object), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 13)]
	public XmlTypeMapElementInfo GetElement(string name, string ns) { }

	[CalledBy(Type = typeof(XmlSerializationReaderInterpreter), Member = "ReadMembers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ClassMap), typeof(object), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 12)]
	public XmlTypeMapElementInfo GetElement(string name, string ns, int minimalOrder) { }

	[CalledBy(Type = typeof(ClassMap), Member = "AddMember", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlTypeMapMember)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ArrayList), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	private void RegisterFlatList(XmlTypeMapMemberExpandable member) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void SetCanBeSimpleType(bool can) { }

}

