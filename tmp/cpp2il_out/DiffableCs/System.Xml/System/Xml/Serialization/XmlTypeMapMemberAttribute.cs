namespace System.Xml.Serialization;

internal class XmlTypeMapMemberAttribute : XmlTypeMapMember
{
	private string _attributeName; //Field offset: 0x58
	private string _namespace; //Field offset: 0x60
	private XmlSchemaForm _form; //Field offset: 0x68
	private XmlTypeMapping _mappedType; //Field offset: 0x70

	public string AttributeName
	{
		[CallerCount(Count = 10)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 set { } //Length: 13
	}

	public XmlSchemaForm Form
	{
		[CallerCount(Count = 10)]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	public XmlTypeMapping MappedType
	{
		[CallerCount(Count = 9)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 set { } //Length: 13
	}

	public string Namespace
	{
		[CallerCount(Count = 84)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 set { } //Length: 13
	}

	[CalledBy(Type = typeof(XmlReflectionImporter), Member = "CreateMapMember", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(XmlReflectionMember), typeof(string)}, ReturnType = typeof(XmlTypeMapMember))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(XmlTypeMapMember), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public XmlTypeMapMemberAttribute() { }

	[CallerCount(Count = 10)]
	[DeduplicatedMethod]
	public string get_AttributeName() { }

	[CallerCount(Count = 9)]
	[DeduplicatedMethod]
	public XmlTypeMapping get_MappedType() { }

	[CallerCount(Count = 84)]
	[DeduplicatedMethod]
	public string get_Namespace() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public void set_AttributeName(string value) { }

	[CallerCount(Count = 10)]
	[DeduplicatedMethod]
	public void set_Form(XmlSchemaForm value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public void set_MappedType(XmlTypeMapping value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public void set_Namespace(string value) { }

}

