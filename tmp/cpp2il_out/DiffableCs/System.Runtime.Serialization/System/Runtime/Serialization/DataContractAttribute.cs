namespace System.Runtime.Serialization;

[AttributeUsage(28, Inherited = False, AllowMultiple = False)]
public sealed class DataContractAttribute : Attribute
{
	private bool isReference; //Field offset: 0x10

	public bool IsReference
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public bool get_IsReference() { }

}

