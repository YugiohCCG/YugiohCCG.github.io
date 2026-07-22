namespace System.Threading.Tasks;

internal sealed class CompletionActionInvoker : IThreadPoolWorkItem
{
	private readonly ITaskCompletionAction m_action; //Field offset: 0x10
	private readonly Task m_completingTask; //Field offset: 0x18

	[CallerCount(Count = 40)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	internal CompletionActionInvoker(ITaskCompletionAction action, Task completingTask) { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	public override void MarkAborted(ThreadAbortException e) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private override void System.Threading.IThreadPoolWorkItem.ExecuteWorkItem() { }

}

