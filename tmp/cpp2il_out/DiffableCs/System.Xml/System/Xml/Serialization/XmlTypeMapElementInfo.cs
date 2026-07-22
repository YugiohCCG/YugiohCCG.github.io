namespace System.Xml.Serialization;

internal class XmlTypeMapElementInfo
{
	private string _elementName; //Field offset: 0x10
	private string _namespace; //Field offset: 0x18
	private XmlSchemaForm _form; //Field offset: 0x20
	private XmlTypeMapMember _member; //Field offset: 0x28
	private object _choiceValue; //Field offset: 0x30
	private bool _isNullable; //Field offset: 0x38
	private int _nestingLevel; //Field offset: 0x3C
	private XmlTypeMapping _mappedType; //Field offset: 0x40
	private TypeData _type; //Field offset: 0x48
	private bool _wrappedElement; //Field offset: 0x50
	private int _explicitOrder; //Field offset: 0x54

	public object ChoiceValue
	{
		[CallerCount(Count = 62)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 set { } //Length: 13
	}

	public string DataTypeName
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 47
	}

	public string DataTypeNamespace
	{
		[CalledBy(Type = typeof(ClassMap), Member = "get_SimpleContentBaseType", ReturnType = typeof(XmlQualifiedName))]
		[CalledBy(Type = typeof(ListMap), Member = "GetArrayType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(String&), typeof(String&)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		 get { } //Length: 94
	}

	public string ElementName
	{
		[CallerCount(Count = 106)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 set { } //Length: 13
	}

	public int ExplicitOrder
	{
		[CallerCount(Count = 14)]
		[DeduplicatedMethod]
		 get { } //Length: 4
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	public XmlSchemaForm Form
	{
		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		 get { } //Length: 4
		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	public bool IsNullable
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	public bool IsTextElement
	{
		[CalledBy(Type = typeof(ClassMap), Member = "get_SimpleContentBaseType", ReturnType = typeof(XmlQualifiedName))]
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		 get { } //Length: 61
		[CalledBy(Type = typeof(XmlReflectionImporter), Member = "ImportTextElementInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlTypeMapElementInfoList), typeof(Type), typeof(XmlTypeMapMemberElement), typeof(XmlAttributes), typeof(string)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Exception), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 6)]
		 set { } //Length: 181
	}

	public bool IsUnnamedAnyElement
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		 get { } //Length: 29
		[CalledBy(Type = typeof(XmlReflectionImporter), Member = "ImportAnyElementInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(XmlReflectionMember), typeof(XmlTypeMapMemberElement), typeof(XmlAttributes)}, ReturnType = typeof(XmlTypeMapElementInfoList))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Exception), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 6)]
		 set { } //Length: 150
	}

	public XmlTypeMapping MappedType
	{
		[CallerCount(Count = 12)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 set { } //Length: 13
	}

	public XmlTypeMapMember Member
	{
		[CallerCount(Count = 15)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public bool MultiReferenceType
	{
		[CalledBy(Type = typeof(XmlSerializationReaderInterpreter), Member = "ReadMembers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ClassMap), typeof(object), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		 get { } //Length: 19
	}

	public string Namespace
	{
		[CallerCount(Count = 31)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 9)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 set { } //Length: 13
	}

	public int NestingLevel
	{
		[CallerCount(Count = 11)]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	public TypeData TypeData
	{
		[CallerCount(Count = 10)]
		[DeduplicatedMethod]
		 get { } //Length: 254
	}

	public bool WrappedElement
	{
		[CallerCount(Count = 8)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	[CalledBy(Type = typeof(XmlReflectionImporter), Member = "ImportListMapping", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TypeData), typeof(XmlRootAttribute), typeof(string), typeof(XmlAttributes), typeof(int)}, ReturnType = typeof(XmlTypeMapping))]
	[CalledBy(Type = typeof(XmlReflectionImporter), Member = "CreateMapMember", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(XmlReflectionMember), typeof(string)}, ReturnType = typeof(XmlTypeMapMember))]
	[CalledBy(Type = typeof(XmlReflectionImporter), Member = "ImportElementInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(string), typeof(string), typeof(Type), typeof(XmlTypeMapMemberElement), typeof(XmlAttributes)}, ReturnType = typeof(XmlTypeMapElementInfoList))]
	[CalledBy(Type = typeof(XmlReflectionImporter), Member = "ImportAnyElementInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(XmlReflectionMember), typeof(XmlTypeMapMemberElement), typeof(XmlAttributes)}, ReturnType = typeof(XmlTypeMapElementInfoList))]
	[CalledBy(Type = typeof(XmlReflectionImporter), Member = "ImportTextElementInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlTypeMapElementInfoList), typeof(Type), typeof(XmlTypeMapMemberElement), typeof(XmlAttributes), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(TypeData), Member = "get_IsValueType", ReturnType = typeof(bool))]
	[Calls(Type = typeof(TypeData), Member = "get_IsNullable", ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public XmlTypeMapElementInfo(XmlTypeMapMember member, TypeData type) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public virtual bool Equals(object other) { }

	[CallerCount(Count = 62)]
	[DeduplicatedMethod]
	public object get_ChoiceValue() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public string get_DataTypeName() { }

	[CalledBy(Type = typeof(ClassMap), Member = "get_SimpleContentBaseType", ReturnType = typeof(XmlQualifiedName))]
	[CalledBy(Type = typeof(ListMap), Member = "GetArrayType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(String&), typeof(String&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	public string get_DataTypeNamespace() { }

	[CallerCount(Count = 106)]
	[DeduplicatedMethod]
	public string get_ElementName() { }

	[CallerCount(Count = 14)]
	[DeduplicatedMethod]
	public int get_ExplicitOrder() { }

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public XmlSchemaForm get_Form() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public bool get_IsNullable() { }

	[CalledBy(Type = typeof(ClassMap), Member = "get_SimpleContentBaseType", ReturnType = typeof(XmlQualifiedName))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	public bool get_IsTextElement() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public bool get_IsUnnamedAnyElement() { }

	[CallerCount(Count = 12)]
	[DeduplicatedMethod]
	public XmlTypeMapping get_MappedType() { }

	[CallerCount(Count = 15)]
	[DeduplicatedMethod]
	public XmlTypeMapMember get_Member() { }

	[CalledBy(Type = typeof(XmlSerializationReaderInterpreter), Member = "ReadMembers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ClassMap), typeof(object), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	public bool get_MultiReferenceType() { }

	[CallerCount(Count = 31)]
	[DeduplicatedMethod]
	public string get_Namespace() { }

	[CallerCount(Count = 10)]
	[DeduplicatedMethod]
	public TypeData get_TypeData() { }

	[CallerCount(Count = 8)]
	[DeduplicatedMethod]
	public bool get_WrappedElement() { }

	[CallerCount(Count = 19)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public virtual int GetHashCode() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public void set_ChoiceValue(object value) { }

	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public void set_ElementName(string value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void set_ExplicitOrder(int value) { }

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public void set_Form(XmlSchemaForm value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void set_IsNullable(bool value) { }

	[CalledBy(Type = typeof(XmlReflectionImporter), Member = "ImportTextElementInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlTypeMapElementInfoList), typeof(Type), typeof(XmlTypeMapMemberElement), typeof(XmlAttributes), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Exception), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 6)]
	public void set_IsTextElement(bool value) { }

	[CalledBy(Type = typeof(XmlReflectionImporter), Member = "ImportAnyElementInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(XmlReflectionMember), typeof(XmlTypeMapMemberElement), typeof(XmlAttributes)}, ReturnType = typeof(XmlTypeMapElementInfoList))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Exception), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 6)]
	public void set_IsUnnamedAnyElement(bool value) { }

	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public void set_MappedType(XmlTypeMapping value) { }

	[CallerCount(Count = 9)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public void set_Namespace(string value) { }

	[CallerCount(Count = 11)]
	[DeduplicatedMethod]
	public void set_NestingLevel(int value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void set_WrappedElement(bool value) { }

}

