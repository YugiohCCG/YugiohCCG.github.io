namespace System.Xml.Serialization;

internal class XmlTypeMapMemberElement : XmlTypeMapMember
{
	private XmlTypeMapElementInfoList _elementInfo; //Field offset: 0x58
	private string _choiceMember; //Field offset: 0x60
	private bool _isTextCollector; //Field offset: 0x68
	private TypeData _choiceTypeData; //Field offset: 0x70

	public string ChoiceMember
	{
		[CallerCount(Count = 84)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 set { } //Length: 13
	}

	public TypeData ChoiceTypeData
	{
		[CallerCount(Count = 9)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 set { } //Length: 13
	}

	public XmlTypeMapElementInfoList ElementInfo
	{
		[CalledBy(Type = typeof(XmlReflectionImporter), Member = "CreateMapMember", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(XmlReflectionMember), typeof(string)}, ReturnType = typeof(XmlTypeMapMember))]
		[CalledBy(Type = typeof(XmlSerializationReaderInterpreter), Member = "ReadMembers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ClassMap), typeof(object), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XmlSerializationWriterInterpreter), Member = "WriteElementMembers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ClassMap), typeof(object), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ClassMap), Member = "AddMember", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlTypeMapMember)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ClassMap), Member = "get_SimpleContentBaseType", ReturnType = typeof(XmlQualifiedName))]
		[CallerCount(Count = 7)]
		[Calls(Type = typeof(ArrayList), Member = ".ctor", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 105
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 set { } //Length: 13
	}

	public bool IsXmlTextCollector
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	[CallerCount(Count = 6)]
	[Calls(Type = typeof(XmlTypeMapMember), Member = ".ctor", ReturnType = typeof(void))]
	[DeduplicatedMethod]
	public XmlTypeMapMemberElement() { }

	[CalledBy(Type = typeof(XmlSerializationWriterInterpreter), Member = "WriteElementMembers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ClassMap), typeof(object), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(XmlTypeMapMember), Member = "GetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(object))]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 29)]
	public XmlTypeMapElementInfo FindElement(object ob, object memberValue) { }

	[CallerCount(Count = 84)]
	[DeduplicatedMethod]
	public string get_ChoiceMember() { }

	[CallerCount(Count = 9)]
	[DeduplicatedMethod]
	public TypeData get_ChoiceTypeData() { }

	[CalledBy(Type = typeof(XmlReflectionImporter), Member = "CreateMapMember", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(XmlReflectionMember), typeof(string)}, ReturnType = typeof(XmlTypeMapMember))]
	[CalledBy(Type = typeof(XmlSerializationReaderInterpreter), Member = "ReadMembers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ClassMap), typeof(object), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSerializationWriterInterpreter), Member = "WriteElementMembers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ClassMap), typeof(object), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ClassMap), Member = "AddMember", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlTypeMapMember)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ClassMap), Member = "get_SimpleContentBaseType", ReturnType = typeof(XmlQualifiedName))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(ArrayList), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public XmlTypeMapElementInfoList get_ElementInfo() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public bool get_IsXmlTextCollector() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public void set_ChoiceMember(string value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public void set_ChoiceTypeData(TypeData value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public void set_ElementInfo(XmlTypeMapElementInfoList value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void set_IsXmlTextCollector(bool value) { }

	[CalledBy(Type = typeof(XmlSerializationReaderInterpreter), Member = "ReadMembers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ClassMap), typeof(object), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(FieldInfo), Member = "SetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	public void SetChoice(object ob, object choice) { }

}

