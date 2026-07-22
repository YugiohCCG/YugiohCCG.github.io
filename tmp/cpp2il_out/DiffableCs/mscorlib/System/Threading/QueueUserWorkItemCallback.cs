namespace System.Threading;

internal sealed class QueueUserWorkItemCallback : IThreadPoolWorkItem
{
	internal static ContextCallback ccb; //Field offset: 0x0
	private WaitCallback callback; //Field offset: 0x10
	private ExecutionContext context; //Field offset: 0x18
	private object state; //Field offset: 0x20

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private static QueueUserWorkItemCallback() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ExecutionContext), Member = "IsFlowSuppressed", ReturnType = typeof(bool))]
	[Calls(Type = typeof(ExecutionContext), Member = "Capture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StackCrawlMark&), typeof(CaptureOptions)}, ReturnType = typeof(ExecutionContext))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	internal QueueUserWorkItemCallback(WaitCallback waitCallback, object stateObj, bool compressStack, ref StackCrawlMark stackMark) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ExecutionContext), Member = "Run", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExecutionContext), typeof(ContextCallback), typeof(object), typeof(bool)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	private override void System.Threading.IThreadPoolWorkItem.ExecuteWorkItem() { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	private override void System.Threading.IThreadPoolWorkItem.MarkAborted(ThreadAbortException tae) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private static void WaitCallback_Context(object state) { }

}

