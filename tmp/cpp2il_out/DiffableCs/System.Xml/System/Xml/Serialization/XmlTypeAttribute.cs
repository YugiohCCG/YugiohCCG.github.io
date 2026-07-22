namespace System.Xml.Serialization;

[AttributeUsage(1052)]
public class XmlTypeAttribute : Attribute
{
	private bool includeInSchema; //Field offset: 0x10
	private string ns; //Field offset: 0x18
	private string typeName; //Field offset: 0x20

	public bool IncludeInSchema
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public string Namespace
	{
		[CallerCount(Count = 31)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public string TypeName
	{
		[CallerCount(Count = 4)]
		[DeduplicatedMethod]
		 get { } //Length: 30
	}

	[CalledBy(Type = typeof(XmlAttributes), Member = "AddKeyHash", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(KeyHelper), Member = "AddField", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder), typeof(int), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(KeyHelper), Member = "AddField", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder), typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(StringBuilder))]
	[CallsUnknownMethods(Count = 1)]
	internal void AddKeyHash(StringBuilder sb) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public bool get_IncludeInSchema() { }

	[CallerCount(Count = 31)]
	[DeduplicatedMethod]
	public string get_Namespace() { }

	[CallerCount(Count = 4)]
	[DeduplicatedMethod]
	public string get_TypeName() { }

}

