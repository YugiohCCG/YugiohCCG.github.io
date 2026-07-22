namespace System.Xml.Serialization;

[AttributeUsage(1100, AllowMultiple = True)]
public class XmlIncludeAttribute : Attribute
{
	private Type type; //Field offset: 0x10

	public Type Type
	{
		[CallerCount(Count = 106)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	[CallerCount(Count = 106)]
	[DeduplicatedMethod]
	public Type get_Type() { }

}

