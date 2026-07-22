namespace UnityEngine.UIElements;

[IsReadOnly]
public struct BindingResult
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private readonly BindingStatus <status>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private readonly string <message>k__BackingField; //Field offset: 0x8

	public string message
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public BindingStatus status
	{
		[CallerCount(Count = 173)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 3
	}

	[CallerCount(Count = 12)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public BindingResult(BindingStatus status, string message = null) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public string get_message() { }

	[CallerCount(Count = 173)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public BindingStatus get_status() { }

}

