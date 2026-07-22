namespace System.Xml.Serialization;

[AttributeUsage(9244)]
public class XmlRootAttribute : Attribute
{
	private string dataType; //Field offset: 0x10
	private string elementName; //Field offset: 0x18
	private bool isNullable; //Field offset: 0x20
	private string ns; //Field offset: 0x28

	public string DataType
	{
		[CallerCount(Count = 6)]
		[DeduplicatedMethod]
		 get { } //Length: 30
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 set { } //Length: 13
	}

	public string ElementName
	{
		[CallerCount(Count = 6)]
		[DeduplicatedMethod]
		 get { } //Length: 30
		[CallerCount(Count = 9)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 set { } //Length: 13
	}

	public bool IsNullable
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 3)]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	public string Namespace
	{
		[CallerCount(Count = 15)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 set { } //Length: 13
	}

	[CalledBy(Type = "System.Data.Common.ObjectStorage", Member = "GetXmlSerializer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(XmlRootAttribute)}, ReturnType = typeof(XmlSerializer))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	public XmlRootAttribute() { }

	[CalledBy(Type = "System.Data.XMLDiffLoader", Member = "ReadOldRowData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Data.DataSet", "System.Data.DataTable&", typeof(Int32&), typeof(XmlReader)}, ReturnType = typeof(int))]
	[CalledBy(Type = "System.Data.XmlDataLoader", Member = "LoadColumn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Data.DataColumn", "System.Object[]"}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Data.NewDiffgramGen", Member = "GenerateColumn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Data.DataRow", "System.Data.DataColumn", "System.Data.DataRowVersion"}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Data.XmlDataTreeWriter", Member = "XmlDataRowWriter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Data.DataRow", typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public XmlRootAttribute(string elementName) { }

	[CalledBy(Type = typeof(XmlTypeSerializationSource), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(XmlRootAttribute), typeof(XmlAttributeOverrides), typeof(string), typeof(Type[])}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(KeyHelper), Member = "AddField", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder), typeof(int), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(KeyHelper), Member = "AddField", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder), typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(StringBuilder))]
	[CallsUnknownMethods(Count = 1)]
	internal void AddKeyHash(StringBuilder sb) { }

	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	public string get_DataType() { }

	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	public string get_ElementName() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public bool get_IsNullable() { }

	[CallerCount(Count = 15)]
	[DeduplicatedMethod]
	public string get_Namespace() { }

	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public void set_DataType(string value) { }

	[CallerCount(Count = 9)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public void set_ElementName(string value) { }

	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	public void set_IsNullable(bool value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public void set_Namespace(string value) { }

}

