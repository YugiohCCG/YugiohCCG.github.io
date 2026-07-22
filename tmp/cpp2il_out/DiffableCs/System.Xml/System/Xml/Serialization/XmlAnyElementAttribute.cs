namespace System.Xml.Serialization;

[AttributeUsage(10624, AllowMultiple = True)]
public class XmlAnyElementAttribute : Attribute
{
	private string elementName; //Field offset: 0x10
	private string ns; //Field offset: 0x18
	private int order; //Field offset: 0x20

	public string Name
	{
		[CallerCount(Count = 6)]
		[DeduplicatedMethod]
		 get { } //Length: 30
	}

	public string Namespace
	{
		[CallerCount(Count = 31)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public int Order
	{
		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		 get { } //Length: 4
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public XmlAnyElementAttribute() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(KeyHelper), Member = "AddField", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder), typeof(int), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(StringBuilder))]
	[CallsUnknownMethods(Count = 1)]
	internal void AddKeyHash(StringBuilder sb) { }

	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	public string get_Name() { }

	[CallerCount(Count = 31)]
	[DeduplicatedMethod]
	public string get_Namespace() { }

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public int get_Order() { }

}

