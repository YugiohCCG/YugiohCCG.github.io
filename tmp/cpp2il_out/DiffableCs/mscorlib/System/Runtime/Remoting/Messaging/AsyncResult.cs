namespace System.Runtime.Remoting.Messaging;

[ComVisible(True)]
public class AsyncResult : IAsyncResult, IMessageSink, IThreadPoolWorkItem
{
	private object async_state; //Field offset: 0x10
	private WaitHandle handle; //Field offset: 0x18
	private object async_delegate; //Field offset: 0x20
	private IntPtr data; //Field offset: 0x28
	private object object_data; //Field offset: 0x30
	private bool sync_completed; //Field offset: 0x38
	private bool completed; //Field offset: 0x39
	private bool endinvoke_called; //Field offset: 0x3A
	private object async_callback; //Field offset: 0x40
	private ExecutionContext current; //Field offset: 0x48
	private ExecutionContext original; //Field offset: 0x50
	private long add_time; //Field offset: 0x58
	private MonoMethodMessage call_message; //Field offset: 0x60
	private IMessageCtrl message_ctrl; //Field offset: 0x68
	private IMessage reply_message; //Field offset: 0x70
	private WaitCallback orig_cb; //Field offset: 0x78

	public override object AsyncDelegate
	{
		[CallerCount(Count = 12)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public override object AsyncState
	{
		[CallerCount(Count = 106)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public override WaitHandle AsyncWaitHandle
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ManualResetEvent), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 2)]
		 get { } //Length: 235
	}

	internal MonoMethodMessage CallMessage
	{
		[CallerCount(Count = 84)]
		[DeduplicatedMethod]
		internal get { } //Length: 5
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		internal set { } //Length: 13
	}

	public override bool CompletedSynchronously
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public bool EndInvokeCalled
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	public override bool IsCompleted
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public override IMessageSink NextSink
	{
		[CallerCount(Count = 182)]
		[DeduplicatedMethod]
		 get { } //Length: 3
	}

	[CallerCount(Count = 2180)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	internal AsyncResult() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public override IMessageCtrl AsyncProcessMessage(IMessage msg, IMessageSink replySink) { }

	[CalledBy(Type = typeof(RealProxy), Member = "PrivateInvoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RealProxy), typeof(IMessage), typeof(Exception&), typeof(Object[]&)}, ReturnType = typeof(object))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	internal IMessage EndInvoke() { }

	[CallerCount(Count = 12)]
	[DeduplicatedMethod]
	public override object get_AsyncDelegate() { }

	[CallerCount(Count = 106)]
	[DeduplicatedMethod]
	public override object get_AsyncState() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ManualResetEvent), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	public override WaitHandle get_AsyncWaitHandle() { }

	[CallerCount(Count = 84)]
	[DeduplicatedMethod]
	internal MonoMethodMessage get_CallMessage() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public override bool get_CompletedSynchronously() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public bool get_EndInvokeCalled() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public override bool get_IsCompleted() { }

	[CallerCount(Count = 182)]
	[DeduplicatedMethod]
	public override IMessageSink get_NextSink() { }

	[CallerCount(Count = 9)]
	[DeduplicatedMethod]
	public override IMessage GetReplyMessage() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	internal object Invoke() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	internal void set_CallMessage(MonoMethodMessage value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void set_EndInvokeCalled(bool value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	internal void SetCompletedSynchronously(bool completed) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public override void SetMessageCtrl(IMessageCtrl mc) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(EventWaitHandle), Member = "Set", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	public override IMessage SyncProcessMessage(IMessage msg) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	private override void System.Threading.IThreadPoolWorkItem.ExecuteWorkItem() { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	private override void System.Threading.IThreadPoolWorkItem.MarkAborted(ThreadAbortException tae) { }

}

