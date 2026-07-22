namespace System.Net;

internal class ListenerAsyncResult : IAsyncResult
{
	private static WaitCallback InvokeCB; //Field offset: 0x0
	private ManualResetEvent handle; //Field offset: 0x10
	private bool synch; //Field offset: 0x18
	private bool completed; //Field offset: 0x19
	private AsyncCallback cb; //Field offset: 0x20
	private object state; //Field offset: 0x28
	private Exception exception; //Field offset: 0x30
	private HttpListenerContext context; //Field offset: 0x38
	private object locker; //Field offset: 0x40
	private ListenerAsyncResult forward; //Field offset: 0x48
	internal bool EndCalled; //Field offset: 0x50
	internal bool InGet; //Field offset: 0x51

	public override object AsyncState
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 23
	}

	public override WaitHandle AsyncWaitHandle
	{
		[CalledBy(Type = typeof(HttpListener), Member = "EndGetContext", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncResult)}, ReturnType = typeof(HttpListenerContext))]
		[CalledBy(Type = typeof(ListenerAsyncResult), Member = "get_AsyncWaitHandle", ReturnType = typeof(WaitHandle))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ManualResetEvent), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ListenerAsyncResult), Member = "get_AsyncWaitHandle", ReturnType = typeof(WaitHandle))]
		[CallsUnknownMethods(Count = 3)]
		 get { } //Length: 275
	}

	public override bool CompletedSynchronously
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 23
	}

	public override bool IsCompleted
	{
		[CalledBy(Type = typeof(HttpListener), Member = "EndGetContext", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncResult)}, ReturnType = typeof(HttpListenerContext))]
		[CalledBy(Type = typeof(ListenerAsyncResult), Member = "get_IsCompleted", ReturnType = typeof(bool))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ListenerAsyncResult), Member = "get_IsCompleted", ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 2)]
		 get { } //Length: 185
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private static ListenerAsyncResult() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public ListenerAsyncResult(AsyncCallback cb, object state) { }

	[CalledBy(Type = typeof(HttpListener), Member = "Cleanup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ListenerAsyncResult), Member = "Complete", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ListenerAsyncResult), Member = "Complete", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HttpListenerContext), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(EventWaitHandle), Member = "Set", ReturnType = typeof(bool))]
	[Calls(Type = typeof(ThreadPool), Member = "UnsafeQueueUserWorkItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WaitCallback), typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ListenerAsyncResult), Member = "Complete", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	internal void Complete(Exception exc) { }

	[CallerCount(Count = 0)]
	[ContainsInvalidInstructions]
	internal void Complete(HttpListenerContext context) { }

	[CalledBy(Type = typeof(HttpListener), Member = "BeginGetContext", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AsyncCallback), typeof(object)}, ReturnType = typeof(IAsyncResult))]
	[CalledBy(Type = typeof(HttpListener), Member = "RegisterContext", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HttpListenerContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ListenerAsyncResult), Member = "Complete", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HttpListenerContext), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(ListenerAsyncResult), Member = "Complete", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HttpListenerContext), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ListenerAsyncResult), Member = "Complete", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(HttpListener), Member = "BeginGetContext", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AsyncCallback), typeof(object)}, ReturnType = typeof(IAsyncResult))]
	[Calls(Type = typeof(HttpConnection), Member = "GetResponseStream", ReturnType = typeof(ResponseStream))]
	[Calls(Type = typeof(NameValueCollection), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(HttpListenerResponse), Member = "set_StatusCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ThreadPool), Member = "UnsafeQueueUserWorkItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WaitCallback), typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(EventWaitHandle), Member = "Set", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Enum), Member = "ToString", ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 26)]
	internal void Complete(HttpListenerContext context, bool synch) { }

	[CallerCount(Count = 0)]
	public override object get_AsyncState() { }

	[CalledBy(Type = typeof(HttpListener), Member = "EndGetContext", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncResult)}, ReturnType = typeof(HttpListenerContext))]
	[CalledBy(Type = typeof(ListenerAsyncResult), Member = "get_AsyncWaitHandle", ReturnType = typeof(WaitHandle))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ManualResetEvent), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ListenerAsyncResult), Member = "get_AsyncWaitHandle", ReturnType = typeof(WaitHandle))]
	[CallsUnknownMethods(Count = 3)]
	public override WaitHandle get_AsyncWaitHandle() { }

	[CallerCount(Count = 0)]
	public override bool get_CompletedSynchronously() { }

	[CalledBy(Type = typeof(HttpListener), Member = "EndGetContext", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncResult)}, ReturnType = typeof(HttpListenerContext))]
	[CalledBy(Type = typeof(ListenerAsyncResult), Member = "get_IsCompleted", ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ListenerAsyncResult), Member = "get_IsCompleted", ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 2)]
	public override bool get_IsCompleted() { }

	[CalledBy(Type = typeof(HttpListener), Member = "EndGetContext", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncResult)}, ReturnType = typeof(HttpListenerContext))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	internal HttpListenerContext GetContext() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private static void InvokeCallback(object o) { }

}

