namespace System.ComponentModel;

[AttributeUsage(AttributeTargets::All (32767))]
public sealed class AmbientValueAttribute : Attribute
{
	[CompilerGenerated]
	private readonly object <Value>k__BackingField; //Field offset: 0x10

	public object Value
	{
		[CallerCount(Count = 106)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	[CallerCount(Count = 106)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public object get_Value() { }

}

