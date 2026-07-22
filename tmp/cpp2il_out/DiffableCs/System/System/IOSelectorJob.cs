namespace System;

internal class IOSelectorJob : IThreadPoolWorkItem
{
	private IOOperation operation; //Field offset: 0x10
	private IOAsyncCallback callback; //Field offset: 0x18
	private IOAsyncResult state; //Field offset: 0x20

	[CallerCount(Count = 24)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public IOSelectorJob(IOOperation operation, IOAsyncCallback callback, IOAsyncResult state) { }

	[CalledBy(Type = "System.Net.Sockets.Socket+<>c__DisplayClass355_0", Member = "<QueueIOSelectorJob>b__0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Socket), Member = "QueueIOSelectorJob", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SemaphoreSlim), typeof(IntPtr), typeof(IOSelectorJob)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void MarkDisposed() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private override void System.Threading.IThreadPoolWorkItem.ExecuteWorkItem() { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	private override void System.Threading.IThreadPoolWorkItem.MarkAborted(ThreadAbortException tae) { }

}

