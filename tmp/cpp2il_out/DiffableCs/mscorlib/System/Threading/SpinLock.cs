namespace System.Threading;

[ComVisible(False)]
[DebuggerDisplay("IsHeld = {IsHeld}")]
[DebuggerTypeProxy(typeof(SystemThreading_SpinLockDebugView))]
public struct SpinLock
{
	public class SystemThreading_SpinLockDebugView
	{

	}

	private static int MAXIMUM_WAITERS; //Field offset: 0x0
	private int m_owner; //Field offset: 0x0

	public bool IsHeldByCurrentThread
	{
		[CalledBy(Type = typeof(SpinLock), Member = "ExitSlowPath", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 10)]
		[ContainsUnimplementedInstructions]
		[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::Success (2))]
		 get { } //Length: 301
	}

	public bool IsThreadOwnerTrackingEnabled
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::Success (2))]
		 get { } //Length: 28
	}

	[CallerCount(Count = 0)]
	private static SpinLock() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 3)]
	public SpinLock(bool enableThreadOwnerTracking) { }

	[CalledBy(Type = typeof(SpinLock), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Boolean&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SpinLock), Member = "TryEnter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Boolean&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(WorkStealingQueue), Member = "LocalPop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IThreadPoolWorkItem&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(WorkStealingQueue), Member = "TrySteal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IThreadPoolWorkItem&), typeof(Boolean&), typeof(int)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Thread), Member = "BeginCriticalRegion", ReturnType = typeof(void))]
	[Calls(Type = typeof(SpinLock), Member = "ContinueTryEnterWithThreadTracking", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(uint), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SpinLock), Member = "DecrementWaiters", ReturnType = typeof(void))]
	[Calls(Type = typeof(PlatformHelper), Member = "get_ProcessorCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(TimeoutHelper), Member = "UpdateTimeOut", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Interlocked), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Environment), Member = "get_TickCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(Thread), Member = "EndCriticalRegion", ReturnType = typeof(void))]
	[Calls(Type = typeof(Interlocked), Member = "CompareExchange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&), typeof(int), typeof(int), typeof(Boolean&)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 20)]
	[ContainsUnimplementedInstructions]
	private void ContinueTryEnter(int millisecondsTimeout, ref bool lockTaken) { }

	[CalledBy(Type = typeof(SpinLock), Member = "ContinueTryEnter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Boolean&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SpinWait), Member = "SpinOnceCore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Thread), Member = "BeginCriticalRegion", ReturnType = typeof(void))]
	[Calls(Type = typeof(Interlocked), Member = "CompareExchange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&), typeof(int), typeof(int), typeof(Boolean&)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Thread), Member = "EndCriticalRegion", ReturnType = typeof(void))]
	[Calls(Type = typeof(Environment), Member = "get_TickCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(LockRecursionException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 11)]
	private void ContinueTryEnterWithThreadTracking(int millisecondsTimeout, uint startTime, ref bool lockTaken) { }

	[CalledBy(Type = typeof(SpinLock), Member = "ContinueTryEnter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Boolean&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Interlocked), Member = "CompareExchange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(SpinWait), Member = "SpinOnceCore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	private void DecrementWaiters() { }

	[CalledBy(Type = "Plugins.WindowsPermissionSetup", Member = "get_UpdaterTempFile", ReturnType = typeof(FileInfo))]
	[CalledBy(Type = "UnityEngine.Awaitable", Member = "SetContinuation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Awaitable", Member = "get_IsDettachedOrCompleted", ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.Awaitable", Member = "get_IsCompleted", ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.Awaitable", Member = "PropagateExceptionAndRelease", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Awaitable", Member = "RaiseManagedCompletion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Awaitable", Member = "RaiseManagedCompletion", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Awaitable", Member = "RunContinuation", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Awaitable", Member = "SetExceptionFromNative", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UnityLogWriter", Member = "get_Encoding", ReturnType = typeof(Encoding))]
	[CalledBy(Type = typeof(WorkStealingQueue), Member = "LocalFindAndPop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IThreadPoolWorkItem)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(WorkStealingQueue), Member = "LocalPush", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IThreadPoolWorkItem)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Awaitable", Member = "WireupCancellation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Awaitable", typeof(CancellationToken)}, ReturnType = typeof(void))]
	[CallerCount(Count = 15)]
	[Calls(Type = typeof(SpinLock), Member = "ContinueTryEnter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Thread), Member = "BeginCriticalRegion", ReturnType = typeof(void))]
	[Calls(Type = typeof(Interlocked), Member = "CompareExchange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&), typeof(int), typeof(int), typeof(Boolean&)}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 2)]
	public void Enter(ref bool lockTaken) { }

	[CalledBy(Type = "Plugins.WindowsPermissionSetup", Member = "get_UpdaterTempFile", ReturnType = typeof(FileInfo))]
	[CalledBy(Type = "UnityEngine.UnityLogWriter", Member = "get_Encoding", ReturnType = typeof(Encoding))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Interlocked), Member = "Decrement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Thread), Member = "EndCriticalRegion", ReturnType = typeof(void))]
	[Calls(Type = typeof(SpinLock), Member = "ExitSlowPath", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::Success (2))]
	public void Exit() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SpinLock), Member = "ExitSlowPath", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Thread), Member = "EndCriticalRegion", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::Success (2))]
	public void Exit(bool useMemoryBarrier) { }

	[CalledBy(Type = "System.Console+WindowsConsole", Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SpinLock), Member = "Exit", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SpinLock), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(SpinLock), Member = "get_IsHeldByCurrentThread", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Interlocked), Member = "Decrement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Interlocked), Member = "Exchange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(SynchronizationLockException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 9)]
	private void ExitSlowPath(bool useMemoryBarrier) { }

	[CalledBy(Type = typeof(SpinLock), Member = "ExitSlowPath", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 10)]
	[ContainsUnimplementedInstructions]
	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::Success (2))]
	public bool get_IsHeldByCurrentThread() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::Success (2))]
	public bool get_IsThreadOwnerTrackingEnabled() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Thread), Member = "BeginCriticalRegion", ReturnType = typeof(void))]
	[Calls(Type = typeof(Interlocked), Member = "CompareExchange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&), typeof(int), typeof(int), typeof(Boolean&)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(SpinLock), Member = "ContinueTryEnter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Boolean&)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	public void TryEnter(int millisecondsTimeout, ref bool lockTaken) { }

}

