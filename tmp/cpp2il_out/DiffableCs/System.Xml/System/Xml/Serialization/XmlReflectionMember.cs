namespace System.Xml.Serialization;

public class XmlReflectionMember
{
	private bool isReturnValue; //Field offset: 0x10
	private string memberName; //Field offset: 0x18
	private Type memberType; //Field offset: 0x20
	private XmlAttributes xmlAttributes; //Field offset: 0x28
	private Type declaringType; //Field offset: 0x30

	internal Type DeclaringType
	{
		[CallerCount(Count = 62)]
		[DeduplicatedMethod]
		internal get { } //Length: 5
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		internal set { } //Length: 13
	}

	public bool IsReturnValue
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public string MemberName
	{
		[CallerCount(Count = 31)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public Type MemberType
	{
		[CallerCount(Count = 12)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public XmlAttributes XmlAttributes
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(XmlAttributes), Member = ".ctor", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 105
	}

	[CalledBy(Type = typeof(XmlReflectionImporter), Member = "GetReflectionMembers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(System.Collections.Generic.List`1<System.Xml.Serialization.XmlReflectionMember>))]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	internal XmlReflectionMember(string name, Type type, XmlAttributes attributes) { }

	[CallerCount(Count = 62)]
	[DeduplicatedMethod]
	internal Type get_DeclaringType() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public bool get_IsReturnValue() { }

	[CallerCount(Count = 31)]
	[DeduplicatedMethod]
	public string get_MemberName() { }

	[CallerCount(Count = 12)]
	[DeduplicatedMethod]
	public Type get_MemberType() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlAttributes), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public XmlAttributes get_XmlAttributes() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	internal void set_DeclaringType(Type value) { }

}

