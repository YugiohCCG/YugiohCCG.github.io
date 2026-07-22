namespace System.Threading;

public sealed class ManualResetEvent : EventWaitHandle
{

	[CalledBy(Type = "Mono.Nat.TaskAsyncResult", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task), typeof(AsyncCallback), typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Threading.ReaderWriterLockSlim", Member = "LazyCreateEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventWaitHandle&), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UnitySynchronizationContext", Member = "Send", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SendOrPostCallback), typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.ListenerAsyncResult", Member = "get_AsyncWaitHandle", ReturnType = typeof(WaitHandle))]
	[CalledBy(Type = "System.Net.HttpStreamAsyncResult", Member = "get_AsyncWaitHandle", ReturnType = typeof(WaitHandle))]
	[CalledBy(Type = "System.Net.FileWebRequest", Member = "GetResponseCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.LazyAsyncResult", Member = "LazilyCreateEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ManualResetEvent&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "System.IOAsyncResult", Member = "get_AsyncWaitHandle", ReturnType = typeof(WaitHandle))]
	[CalledBy(Type = typeof(FileStreamAsyncResult), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AsyncCallback), typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.TimerThread", Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = "System.IO.Stream+SynchronousAsyncResult+<>c", Member = "<get_AsyncWaitHandle>b__12_0", ReturnType = typeof(ManualResetEvent))]
	[CalledBy(Type = typeof(AsyncResult), Member = "get_AsyncWaitHandle", ReturnType = typeof(WaitHandle))]
	[CalledBy(Type = "System.Threading.Timer+Scheduler", Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = "System.Threading.Timer+Scheduler", Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = "System.Threading.Timer+Scheduler", Member = "InitScheduler", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RegisteredWaitHandle), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WaitHandle), typeof(WaitOrTimerCallback), typeof(object), typeof(TimeSpan), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ThreadPool), Member = "RegisterWaitForSingleObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WaitHandle), typeof(WaitOrTimerCallback), typeof(object), typeof(uint), typeof(bool), typeof(StackCrawlMark&), typeof(bool)}, ReturnType = typeof(RegisteredWaitHandle))]
	[CalledBy(Type = typeof(FileStream), Member = "BeginWrite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int), typeof(AsyncCallback), typeof(object)}, ReturnType = typeof(IAsyncResult))]
	[CallerCount(Count = 18)]
	[Calls(Type = typeof(WaitHandle), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(NativeEventCalls), Member = "CreateEvent_internal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool), typeof(string), typeof(Int32&)}, ReturnType = typeof(IntPtr))]
	[Calls(Type = typeof(SafeHandle), Member = "SetHandleAsInvalid", ReturnType = typeof(void))]
	[Calls(Type = typeof(__Error), Member = "WinIOError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(WaitHandle), Member = "SetHandleInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SafeWaitHandle)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public ManualResetEvent(bool initialState) { }

}

