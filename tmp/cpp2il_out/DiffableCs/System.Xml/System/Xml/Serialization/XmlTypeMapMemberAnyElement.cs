namespace System.Xml.Serialization;

internal class XmlTypeMapMemberAnyElement : XmlTypeMapMemberExpandable
{

	public bool IsDefaultAny
	{
		[CalledBy(Type = typeof(ClassMap), Member = "AddMember", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlTypeMapMember)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(ArrayList), Member = ".ctor", ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 13)]
		 get { } //Length: 525
	}

	[CallerCount(Count = 6)]
	[Calls(Type = typeof(XmlTypeMapMember), Member = ".ctor", ReturnType = typeof(void))]
	[DeduplicatedMethod]
	public XmlTypeMapMemberAnyElement() { }

	[CalledBy(Type = typeof(ClassMap), Member = "AddMember", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlTypeMapMember)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ArrayList), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 13)]
	public bool get_IsDefaultAny() { }

	[CalledBy(Type = typeof(XmlSerializationWriterInterpreter), Member = "WriteAnyElementContent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlTypeMapMemberAnyElement), typeof(object)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ArrayList), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 14)]
	public bool IsElementDefined(string name, string ns) { }

}

