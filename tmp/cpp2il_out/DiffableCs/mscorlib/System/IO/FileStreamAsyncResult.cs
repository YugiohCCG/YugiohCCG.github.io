namespace System.IO;

internal class FileStreamAsyncResult : IAsyncResult
{
	private object state; //Field offset: 0x10
	private bool completed; //Field offset: 0x18
	private ManualResetEvent wh; //Field offset: 0x20
	private AsyncCallback cb; //Field offset: 0x28
	private bool completedSynch; //Field offset: 0x30
	public int Count; //Field offset: 0x34
	public int OriginalCount; //Field offset: 0x38
	public int BytesRead; //Field offset: 0x3C
	private AsyncCallback realcb; //Field offset: 0x40

	public override object AsyncState
	{
		[CallerCount(Count = 106)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public override WaitHandle AsyncWaitHandle
	{
		[CallerCount(Count = 12)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public override bool CompletedSynchronously
	{
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public override bool IsCompleted
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ManualResetEvent), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	public FileStreamAsyncResult(AsyncCallback cb, object state) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private static void CBWrapper(IAsyncResult ares) { }

	[CallerCount(Count = 106)]
	[DeduplicatedMethod]
	public override object get_AsyncState() { }

	[CallerCount(Count = 12)]
	[DeduplicatedMethod]
	public override WaitHandle get_AsyncWaitHandle() { }

	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	public override bool get_CompletedSynchronously() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public override bool get_IsCompleted() { }

}

