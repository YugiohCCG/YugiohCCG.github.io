namespace Newtonsoft.Json.Serialization;

[Nullable(0)]
[NullableContext(1)]
public class ErrorEventArgs : EventArgs
{
	[CompilerGenerated]
	[Nullable(2)]
	private readonly object <CurrentObject>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private readonly ErrorContext <ErrorContext>k__BackingField; //Field offset: 0x18

	[Nullable(2)]
	public object CurrentObject
	{
		[CallerCount(Count = 106)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[NullableContext(2)]
		 get { } //Length: 5
	}

	public ErrorContext ErrorContext
	{
		[CallerCount(Count = 31)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public ErrorEventArgs(object currentObject, ErrorContext errorContext) { }

	[CallerCount(Count = 106)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[NullableContext(2)]
	public object get_CurrentObject() { }

	[CallerCount(Count = 31)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public ErrorContext get_ErrorContext() { }

}

