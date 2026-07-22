namespace System.Runtime.Serialization;

[AttributeUsage(384, Inherited = False, AllowMultiple = False)]
public sealed class DataMemberAttribute : Attribute
{
	private string name; //Field offset: 0x10
	private int order; //Field offset: 0x18
	private bool isRequired; //Field offset: 0x1C
	private bool emitDefaultValue; //Field offset: 0x1D

	public bool EmitDefaultValue
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public bool IsRequired
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public string Name
	{
		[CallerCount(Count = 106)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public int Order
	{
		[CallerCount(Count = 7)]
		[DeduplicatedMethod]
		 get { } //Length: 4
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public bool get_EmitDefaultValue() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public bool get_IsRequired() { }

	[CallerCount(Count = 106)]
	[DeduplicatedMethod]
	public string get_Name() { }

	[CallerCount(Count = 7)]
	[DeduplicatedMethod]
	public int get_Order() { }

}

