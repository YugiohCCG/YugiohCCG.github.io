namespace System.Threading;

public class SynchronizationContext
{
	private SynchronizationContextProperties _props; //Field offset: 0x10

	public static SynchronizationContext Current
	{
		[CalledBy(Type = typeof(CancellationToken), Member = "Register", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<System.Object>), typeof(object), typeof(bool), typeof(bool)}, ReturnType = typeof(CancellationTokenRegistration))]
		[CalledBy(Type = "Utilities.Async.AwaitYieldInstructions.BackgroundThread+<>c+<<GetAwaiter>b__0_0>d", Member = "MoveNext", ReturnType = typeof(void))]
		[CalledBy(Type = "Utilities.Async.Internal.SyncContextUtility", Member = "get_IsMainThread", ReturnType = typeof(bool))]
		[CalledBy(Type = "Utilities.Async.Internal.SyncContextUtility", Member = "Initialize", ReturnType = typeof(void))]
		[CalledBy(Type = "Utilities.Async.AwaiterExtensions", Member = "DeferredPostCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CalledBy(Type = "Utilities.Async.AwaiterExtensions", Member = "RunOnUnityScheduler", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Android.AndroidApplication", Member = "AcquireMainThreadSynchronizationContext", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UnitySynchronizationContext", Member = "ExecuteTasks", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UnitySynchronizationContext", Member = "ExecutePendingTasks", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(AwaitTaskContinuation), Member = "get_IsValidLocationForInlining", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(SynchronizationContextAwaitTaskContinuation), Member = "Run", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Task), Member = "SetContinuationForAwait", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(WaitHandle), Member = "WaitMultiple", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WaitHandle[]), typeof(int), typeof(bool), typeof(bool)}, ReturnType = typeof(int))]
		[CalledBy(Type = typeof(WaitHandle), Member = "WaitOneNative", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SafeHandle), typeof(uint), typeof(bool), typeof(bool)}, ReturnType = typeof(int))]
		[CalledBy(Type = typeof(SynchronizationContext), Member = "get_CurrentExplicit", ReturnType = typeof(SynchronizationContext))]
		[CalledBy(Type = "System.Net.Sockets.Socket+AwaitableSocketAsyncEventArgs", Member = "OnCompleted", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Action`1<Object>", typeof(object), typeof(short), typeof(ValueTaskSourceOnCompletedFlags)}, ReturnType = typeof(void))]
		[CallerCount(Count = 16)]
		[Calls(Type = typeof(SynchronizationContext), Member = "GetThreadLocalContext", ReturnType = typeof(SynchronizationContext))]
		[CallsUnknownMethods(Count = 4)]
		 get { } //Length: 137
	}

	internal static SynchronizationContext CurrentExplicit
	{
		[CalledBy(Type = typeof(AwaitTaskContinuation), Member = "RunCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ContextCallback), typeof(object), typeof(Task&)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(SynchronizationContext), Member = "get_Current", ReturnType = typeof(SynchronizationContext))]
		internal get { } //Length: 7
	}

	internal static SynchronizationContext CurrentNoFlow
	{
		[CalledBy(Type = typeof(AsyncVoidMethodBuilder), Member = "Create", ReturnType = typeof(AsyncVoidMethodBuilder))]
		[CalledBy(Type = typeof(YieldAwaiter), Member = "QueueContinuation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action), typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(SynchronizationContext), Member = "GetThreadLocalContext", ReturnType = typeof(SynchronizationContext))]
		[CallsUnknownMethods(Count = 4)]
		[FriendAccessAllowed]
		internal get { } //Length: 137
	}

	[CallerCount(Count = 2180)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public SynchronizationContext() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public override SynchronizationContext CreateCopy() { }

	[CalledBy(Type = typeof(CancellationToken), Member = "Register", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<System.Object>), typeof(object), typeof(bool), typeof(bool)}, ReturnType = typeof(CancellationTokenRegistration))]
	[CalledBy(Type = "System.Net.Sockets.Socket+AwaitableSocketAsyncEventArgs", Member = "OnCompleted", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Action`1<Object>", typeof(object), typeof(short), typeof(ValueTaskSourceOnCompletedFlags)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SynchronizationContext), Member = "get_CurrentExplicit", ReturnType = typeof(SynchronizationContext))]
	[CalledBy(Type = typeof(WaitHandle), Member = "WaitOneNative", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SafeHandle), typeof(uint), typeof(bool), typeof(bool)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(WaitHandle), Member = "WaitMultiple", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WaitHandle[]), typeof(int), typeof(bool), typeof(bool)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(Task), Member = "SetContinuationForAwait", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SynchronizationContextAwaitTaskContinuation), Member = "Run", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UnitySynchronizationContext", Member = "ExecutePendingTasks", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(AwaitTaskContinuation), Member = "get_IsValidLocationForInlining", ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.Android.AndroidApplication", Member = "AcquireMainThreadSynchronizationContext", ReturnType = typeof(void))]
	[CalledBy(Type = "Utilities.Async.AwaiterExtensions", Member = "RunOnUnityScheduler", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Utilities.Async.AwaiterExtensions", Member = "DeferredPostCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Utilities.Async.Internal.SyncContextUtility", Member = "Initialize", ReturnType = typeof(void))]
	[CalledBy(Type = "Utilities.Async.Internal.SyncContextUtility", Member = "get_IsMainThread", ReturnType = typeof(bool))]
	[CalledBy(Type = "Utilities.Async.AwaitYieldInstructions.BackgroundThread+<>c+<<GetAwaiter>b__0_0>d", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UnitySynchronizationContext", Member = "ExecuteTasks", ReturnType = typeof(void))]
	[CallerCount(Count = 16)]
	[Calls(Type = typeof(SynchronizationContext), Member = "GetThreadLocalContext", ReturnType = typeof(SynchronizationContext))]
	[CallsUnknownMethods(Count = 4)]
	public static SynchronizationContext get_Current() { }

	[CalledBy(Type = typeof(AwaitTaskContinuation), Member = "RunCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ContextCallback), typeof(object), typeof(Task&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SynchronizationContext), Member = "get_Current", ReturnType = typeof(SynchronizationContext))]
	internal static SynchronizationContext get_CurrentExplicit() { }

	[CalledBy(Type = typeof(AsyncVoidMethodBuilder), Member = "Create", ReturnType = typeof(AsyncVoidMethodBuilder))]
	[CalledBy(Type = typeof(YieldAwaiter), Member = "QueueContinuation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(SynchronizationContext), Member = "GetThreadLocalContext", ReturnType = typeof(SynchronizationContext))]
	[CallsUnknownMethods(Count = 4)]
	[FriendAccessAllowed]
	internal static SynchronizationContext get_CurrentNoFlow() { }

	[CalledBy(Type = typeof(SynchronizationContext), Member = "get_Current", ReturnType = typeof(SynchronizationContext))]
	[CalledBy(Type = typeof(SynchronizationContext), Member = "get_CurrentNoFlow", ReturnType = typeof(SynchronizationContext))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ConditionalWeakTable`2), Member = "GetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "System.Runtime.CompilerServices.ConditionalWeakTable`2<TKey, TValue>+CreateValueCallback<TKey, TValue>"}, ReturnType = "TValue")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private static SynchronizationContext GetThreadLocalContext() { }

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public bool IsWaitNotificationRequired() { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	public override void OperationCompleted() { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	public override void OperationStarted() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ThreadPool), Member = "QueueUserWorkItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WaitCallback), typeof(object)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 7)]
	public override void Post(SendOrPostCallback d, object state) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public override void Send(SendOrPostCallback d, object state) { }

	[CalledBy(Type = typeof(__ComObject), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(AwaitTaskContinuation), Member = "RunCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ContextCallback), typeof(object), typeof(Task&)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UnitySynchronizationContext", Member = "InitializeSynchronizationContext", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Thread), Member = "GetMutableExecutionContext", ReturnType = typeof(ExecutionContext))]
	[CallsUnknownMethods(Count = 5)]
	public static void SetSynchronizationContext(SynchronizationContext syncContext) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(WaitHandle), Member = "Wait_internal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr*), typeof(int), typeof(bool), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	[CLSCompliant(False)]
	[PrePrepareMethod]
	public override int Wait(IntPtr[] waitHandles, bool waitAll, int millisecondsTimeout) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(WaitHandle), Member = "Wait_internal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr*), typeof(int), typeof(bool), typeof(int)}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 2)]
	[CLSCompliant(False)]
	[PrePrepareMethod]
	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::MayFail (1))]
	protected static int WaitHelper(IntPtr[] waitHandles, bool waitAll, int millisecondsTimeout) { }

}

