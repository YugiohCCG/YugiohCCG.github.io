namespace Mono.Net.Security;

internal class AsyncProtocolResult
{
	[CompilerGenerated]
	private readonly int <UserResult>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private readonly ExceptionDispatchInfo <Error>k__BackingField; //Field offset: 0x18

	public ExceptionDispatchInfo Error
	{
		[CallerCount(Count = 31)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public int UserResult
	{
		[CallerCount(Count = 94)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 4
	}

	[CallerCount(Count = 36)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public AsyncProtocolResult(int result) { }

	[CallerCount(Count = 7)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public AsyncProtocolResult(ExceptionDispatchInfo error) { }

	[CallerCount(Count = 31)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public ExceptionDispatchInfo get_Error() { }

	[CallerCount(Count = 94)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public int get_UserResult() { }

}

