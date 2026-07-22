namespace System.Threading;

public sealed class AutoResetEvent : EventWaitHandle
{

	[CalledBy(Type = "DigitalRuby.Threading.EZThread+EZThreadRunner", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.TimerThread", Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = "System.Threading.ReaderWriterLockSlim", Member = "LazyCreateEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventWaitHandle&), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(WaitHandle), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(NativeEventCalls), Member = "CreateEvent_internal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool), typeof(string), typeof(Int32&)}, ReturnType = typeof(IntPtr))]
	[Calls(Type = typeof(SafeHandle), Member = "SetHandleAsInvalid", ReturnType = typeof(void))]
	[Calls(Type = typeof(__Error), Member = "WinIOError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(WaitHandle), Member = "SetHandleInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SafeWaitHandle)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public AutoResetEvent(bool initialState) { }

}

