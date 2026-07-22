namespace System.Xml.Serialization;

[AttributeUsage(10624, AllowMultiple = False)]
public class XmlArrayAttribute : Attribute
{
	private string elementName; //Field offset: 0x10
	private XmlSchemaForm form; //Field offset: 0x18
	private bool isNullable; //Field offset: 0x1C
	private string ns; //Field offset: 0x20
	private int order; //Field offset: 0x28

	public string ElementName
	{
		[CallerCount(Count = 6)]
		[DeduplicatedMethod]
		 get { } //Length: 30
	}

	public XmlSchemaForm Form
	{
		[CallerCount(Count = 7)]
		[DeduplicatedMethod]
		 get { } //Length: 4
	}

	public bool IsNullable
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public string Namespace
	{
		[CallerCount(Count = 12)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public int Order
	{
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 4
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(KeyHelper), Member = "AddField", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder), typeof(int), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Enum), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(KeyHelper), Member = "AddField", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder), typeof(int), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(KeyHelper), Member = "AddField", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder), typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(StringBuilder))]
	[CallsUnknownMethods(Count = 1)]
	internal void AddKeyHash(StringBuilder sb) { }

	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	public string get_ElementName() { }

	[CallerCount(Count = 7)]
	[DeduplicatedMethod]
	public XmlSchemaForm get_Form() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public bool get_IsNullable() { }

	[CallerCount(Count = 12)]
	[DeduplicatedMethod]
	public string get_Namespace() { }

	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	public int get_Order() { }

}

