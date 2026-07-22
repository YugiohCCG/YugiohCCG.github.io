namespace System.Runtime.Serialization;

[AttributeUsage(AttributeTargets::Field (256), Inherited = False, AllowMultiple = False)]
public sealed class EnumMemberAttribute : Attribute
{
	private string value; //Field offset: 0x10

	public string Value
	{
		[CallerCount(Count = 106)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	[CallerCount(Count = 106)]
	[DeduplicatedMethod]
	public string get_Value() { }

}

