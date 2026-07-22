namespace System.Xml.Serialization;

[AttributeUsage(10624, AllowMultiple = False)]
public class XmlChoiceIdentifierAttribute : Attribute
{
	private string memberName; //Field offset: 0x10

	public string MemberName
	{
		[CallerCount(Count = 6)]
		[DeduplicatedMethod]
		 get { } //Length: 30
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(KeyHelper), Member = "AddField", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder), typeof(int), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(StringBuilder))]
	[CallsUnknownMethods(Count = 1)]
	internal void AddKeyHash(StringBuilder sb) { }

	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	public string get_MemberName() { }

}

