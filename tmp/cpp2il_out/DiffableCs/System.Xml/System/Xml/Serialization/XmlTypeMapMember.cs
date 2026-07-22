namespace System.Xml.Serialization;

internal class XmlTypeMapMember
{
	private string _name; //Field offset: 0x10
	private int _index; //Field offset: 0x18
	private int _globalIndex; //Field offset: 0x1C
	private int _specifiedGlobalIndex; //Field offset: 0x20
	private TypeData _typeData; //Field offset: 0x28
	private MemberInfo _member; //Field offset: 0x30
	private MemberInfo _specifiedMember; //Field offset: 0x38
	private MethodInfo _shouldSerialize; //Field offset: 0x40
	private object _defaultValue; //Field offset: 0x48
	private int _flags; //Field offset: 0x50

	public object DefaultValue
	{
		[CallerCount(Count = 10)]
		[DeduplicatedMethod]
		 get { } //Length: 254
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 set { } //Length: 13
	}

	public int GlobalIndex
	{
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 4
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	public int Index
	{
		[CallerCount(Count = 7)]
		[DeduplicatedMethod]
		 get { } //Length: 4
		[CallerCount(Count = 3)]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	public bool IsOptionalValueType
	{
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 7
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 set { } //Length: 25
	}

	public bool IsReturnValue
	{
		[CallerCount(Count = 1)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		 get { } //Length: 8
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		 set { } //Length: 25
	}

	public string Name
	{
		[CallerCount(Count = 106)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 set { } //Length: 13
	}

	public TypeData TypeData
	{
		[CallerCount(Count = 15)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 set { } //Length: 13
	}

	[CalledBy(Type = typeof(XmlTypeMapMemberAttribute), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTypeMapMemberElement), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTypeMapMemberList), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTypeMapMemberExpandable), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTypeMapMemberFlatList), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTypeMapMemberAnyElement), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTypeMapMemberAnyAttribute), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTypeMapMemberNamespaces), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 8)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public XmlTypeMapMember() { }

	[CalledBy(Type = typeof(XmlReflectionImporter), Member = "ImportClassMapping", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TypeData), typeof(XmlRootAttribute), typeof(string), typeof(bool)}, ReturnType = typeof(XmlTypeMapping))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(MemberInfo), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MemberInfo), typeof(MemberInfo)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlTypeMapMember), Member = "InitMember", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MemberInfo), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MemberInfo), typeof(MemberInfo)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	public void CheckOptionalValueType(Type type) { }

	[CallerCount(Count = 10)]
	[DeduplicatedMethod]
	public object get_DefaultValue() { }

	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	public int get_GlobalIndex() { }

	[CallerCount(Count = 7)]
	[DeduplicatedMethod]
	public int get_Index() { }

	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	public bool get_IsOptionalValueType() { }

	[CallerCount(Count = 1)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public bool get_IsReturnValue() { }

	[CallerCount(Count = 106)]
	[DeduplicatedMethod]
	public string get_Name() { }

	[CallerCount(Count = 15)]
	[DeduplicatedMethod]
	public TypeData get_TypeData() { }

	[CalledBy(Type = typeof(XmlSerializationReaderInterpreter), Member = "ReadMembers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ClassMap), typeof(object), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSerializationReaderInterpreter), Member = "GetMemberValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlTypeMapMember), typeof(object), typeof(bool)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(XmlSerializationWriterInterpreter), Member = "WriteObjectElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlTypeMapping), typeof(object), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSerializationWriterInterpreter), Member = "GetMemberValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlTypeMapMember), typeof(object), typeof(bool)}, ReturnType = typeof(object))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(MemberInfo), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MemberInfo), typeof(MemberInfo)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(XmlTypeMapMember), Member = "InitMember", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public object GetValue(object ob) { }

	[CalledBy(Type = typeof(XmlTypeMapMemberElement), Member = "FindElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(XmlTypeMapElementInfo))]
	[CalledBy(Type = typeof(ListMap), Member = "FindElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(int), typeof(object)}, ReturnType = typeof(XmlTypeMapElementInfo))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	public static object GetValue(object ob, string name) { }

	[CalledBy(Type = typeof(XmlSerializationWriterInterpreter), Member = "MemberHasValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlTypeMapMember), typeof(object), typeof(bool)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(MemberInfo), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MemberInfo), typeof(MemberInfo)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(MethodBase), Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object[])}, ReturnType = typeof(object))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 10)]
	[ContainsUnimplementedInstructions]
	public bool GetValueSpecified(object ob) { }

	[CalledBy(Type = typeof(XmlTypeMapMember), Member = "IsReadOnly", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XmlTypeMapMember), Member = "GetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(XmlTypeMapMember), Member = "SetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTypeMapMember), Member = "CheckOptionalValueType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Type), Member = "GetMethod", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(BindingFlags), typeof(Binder), typeof(Type[]), typeof(ParameterModifier[])}, ReturnType = typeof(MethodInfo))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 7)]
	private void InitMember(Type type) { }

	[CalledBy(Type = typeof(XmlSerializationReaderInterpreter), Member = "ReadMembers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ClassMap), typeof(object), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSerializationReaderInterpreter), Member = "SetListMembersDefaults", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ClassMap), typeof(object), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSerializationReaderInterpreter), Member = "IsReadOnly", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlTypeMapMember), typeof(TypeData), typeof(object), typeof(bool)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(MemberInfo), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MemberInfo), typeof(MemberInfo)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlTypeMapMember), Member = "InitMember", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public bool IsReadOnly(Type type) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public void set_DefaultValue(object value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void set_GlobalIndex(int value) { }

	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	public void set_Index(int value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void set_IsOptionalValueType(bool value) { }

	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	public void set_IsReturnValue(bool value) { }

	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public void set_Name(string value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public void set_TypeData(TypeData value) { }

	[CalledBy(Type = typeof(XmlSerializationReaderInterpreter), Member = "ReadMembers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ClassMap), typeof(object), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(FieldInfo), Member = "SetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	public static void SetValue(object ob, string name, object value) { }

	[CalledBy(Type = typeof(XmlSerializationReaderInterpreter), Member = "SetMemberValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlTypeMapMember), typeof(object), typeof(object), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(MemberInfo), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MemberInfo), typeof(MemberInfo)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(XmlTypeMapMember), Member = "InitMember", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TypeData), Member = "ConvertForAssignment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FieldInfo), Member = "SetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public void SetValue(object ob, object value) { }

	[CalledBy(Type = typeof(XmlSerializationReaderInterpreter), Member = "SetMemberValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlTypeMapMember), typeof(object), typeof(object), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(FieldInfo), Member = "SetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 16)]
	public void SetValueSpecified(object ob, bool value) { }

}

