namespace System.Xml.Serialization;

[AttributeUsage(10624)]
public class XmlAttributeAttribute : Attribute
{
	private string attributeName; //Field offset: 0x10
	private string dataType; //Field offset: 0x18
	private Type type; //Field offset: 0x20
	private XmlSchemaForm form; //Field offset: 0x28
	private string ns; //Field offset: 0x30

	public string AttributeName
	{
		[CallerCount(Count = 6)]
		[DeduplicatedMethod]
		 get { } //Length: 30
	}

	public string DataType
	{
		[CallerCount(Count = 6)]
		[DeduplicatedMethod]
		 get { } //Length: 30
		[CallerCount(Count = 9)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 set { } //Length: 13
	}

	public XmlSchemaForm Form
	{
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 4
	}

	public string Namespace
	{
		[CallerCount(Count = 62)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	[CallerCount(Count = 27)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public XmlAttributeAttribute(string attributeName) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(KeyHelper), Member = "AddField", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder), typeof(int), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Enum), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(KeyHelper), Member = "AddField", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder), typeof(int), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(KeyHelper), Member = "AddField", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder), typeof(int), typeof(Type)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(StringBuilder))]
	[CallsUnknownMethods(Count = 1)]
	internal void AddKeyHash(StringBuilder sb) { }

	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	public string get_AttributeName() { }

	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	public string get_DataType() { }

	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	public XmlSchemaForm get_Form() { }

	[CallerCount(Count = 62)]
	[DeduplicatedMethod]
	public string get_Namespace() { }

	[CallerCount(Count = 9)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public void set_DataType(string value) { }

}

