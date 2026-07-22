namespace SQLite;

[AttributeUsage(AttributeTargets::Property (128))]
public class MaxLengthAttribute : Attribute
{
	[CompilerGenerated]
	private int <Value>k__BackingField; //Field offset: 0x10

	public private int Value
	{
		[CallerCount(Count = 94)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 4
		[CallerCount(Count = 7)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private set { } //Length: 4
	}

	[CallerCount(Count = 31)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public MaxLengthAttribute(int length) { }

	[CallerCount(Count = 94)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public int get_Value() { }

	[CallerCount(Count = 7)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void set_Value(int value) { }

}

