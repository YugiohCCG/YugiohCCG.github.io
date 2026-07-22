namespace Utilities.Async.AwaitYieldInstructions;

public sealed class UnityMainThread : CustomYieldInstruction
{

	public virtual bool keepWaiting
	{
		[CallerCount(Count = 271)]
		[DeduplicatedMethod]
		 get { } //Length: 3
	}

	[CallerCount(Count = 162)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public UnityMainThread() { }

	[CallerCount(Count = 271)]
	[DeduplicatedMethod]
	public virtual bool get_keepWaiting() { }

}

