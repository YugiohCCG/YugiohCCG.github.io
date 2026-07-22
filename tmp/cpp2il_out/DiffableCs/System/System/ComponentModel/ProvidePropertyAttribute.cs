namespace System.ComponentModel;

[AttributeUsage(AttributeTargets::Class (4), AllowMultiple = True)]
public sealed class ProvidePropertyAttribute : Attribute
{
	[CompilerGenerated]
	private readonly string <PropertyName>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private readonly string <ReceiverTypeName>k__BackingField; //Field offset: 0x18

	public string PropertyName
	{
		[CallerCount(Count = 106)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public string ReceiverTypeName
	{
		[CallerCount(Count = 31)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	[CallerCount(Count = 106)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public string get_PropertyName() { }

	[CallerCount(Count = 31)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public string get_ReceiverTypeName() { }

}

