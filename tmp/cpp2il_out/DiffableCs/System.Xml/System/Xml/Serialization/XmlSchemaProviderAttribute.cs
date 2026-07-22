namespace System.Xml.Serialization;

[AttributeUsage(1036)]
public sealed class XmlSchemaProviderAttribute : Attribute
{
	private string _methodName; //Field offset: 0x10
	private bool _isAny; //Field offset: 0x18

	public bool IsAny
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	public string MethodName
	{
		[CallerCount(Count = 106)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	[CallerCount(Count = 27)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public XmlSchemaProviderAttribute(string methodName) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public bool get_IsAny() { }

	[CallerCount(Count = 106)]
	[DeduplicatedMethod]
	public string get_MethodName() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void set_IsAny(bool value) { }

}

