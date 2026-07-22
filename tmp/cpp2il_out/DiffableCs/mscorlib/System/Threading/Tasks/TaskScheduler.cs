namespace System.Threading.Tasks;

[DebuggerDisplay("Id={Id}")]
[DebuggerTypeProxy(typeof(SystemThreadingTasks_TaskSchedulerDebugView))]
public abstract class TaskScheduler
{
	public sealed class SystemThreadingTasks_TaskSchedulerDebugView
	{

	}

	private static readonly TaskScheduler s_defaultTaskScheduler; //Field offset: 0x0
	internal static int s_taskSchedulerIdCounter; //Field offset: 0x8
	private static EventHandler<UnobservedTaskExceptionEventArgs> _unobservedTaskException; //Field offset: 0x10
	private static readonly Lock _unobservedTaskExceptionLockObject; //Field offset: 0x18
	private int m_taskSchedulerId; //Field offset: 0x10

	public static TaskScheduler Current
	{
		[CalledBy(Type = typeof(Task`1), Member = "ContinueWith", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TNewResult"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Func`2<Task`1<TResult>, TNewResult>", typeof(TaskContinuationOptions)}, ReturnType = "System.Threading.Tasks.Task`1<TNewResult>")]
		[CalledBy(Type = typeof(Task), Member = "Start", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Task), Member = "ContinueWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<System.Threading.Tasks.Task>)}, ReturnType = typeof(Task))]
		[CalledBy(Type = typeof(YieldAwaiter), Member = "QueueContinuation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = "System.Net.Sockets.Socket+AwaitableSocketAsyncEventArgs", Member = "OnCompleted", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Action`1<Object>", typeof(object), typeof(short), typeof(ValueTaskSourceOnCompletedFlags)}, ReturnType = typeof(void))]
		[CallerCount(Count = 5)]
		[Calls(Type = typeof(TaskScheduler), Member = "get_InternalCurrent", ReturnType = typeof(TaskScheduler))]
		 get { } //Length: 156
	}

	public static TaskScheduler Default
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 78
	}

	public int Id
	{
		[CalledBy(Type = typeof(Task), Member = "InternalWait", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(CancellationToken)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(ThreadPoolTaskScheduler), Member = "QueueTask", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task)}, ReturnType = typeof(void))]
		[CalledBy(Type = "System.Runtime.CompilerServices.TaskAwaiter+<>c__DisplayClass11_0", Member = "<OutputWaitEtwEvents>b__0", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TaskAwaiter), Member = "OutputWaitEtwEvents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task), typeof(Action)}, ReturnType = typeof(Action))]
		[CallerCount(Count = 9)]
		[CallsUnknownMethods(Count = 5)]
		 get { } //Length: 157
	}

	internal static TaskScheduler InternalCurrent
	{
		[CalledBy(Type = typeof(Task), Member = "SetContinuationForAwait", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TaskSchedulerAwaitTaskContinuation), Member = "Run", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(AwaitTaskContinuation), Member = "get_IsValidLocationForInlining", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(TaskScheduler), Member = "get_Current", ReturnType = typeof(TaskScheduler))]
		[CallerCount(Count = 4)]
		[CallsUnknownMethods(Count = 2)]
		internal get { } //Length: 215
	}

	internal override bool RequiresAtomicStartTransition
	{
		[CallerCount(Count = 23)]
		[DeduplicatedMethod]
		internal get { } //Length: 3
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Lock), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private static TaskScheduler() { }

	[CallerCount(Count = 2180)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	protected TaskScheduler() { }

	[CalledBy(Type = typeof(Task`1), Member = "ContinueWith", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TNewResult"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Func`2<Task`1<TResult>, TNewResult>", typeof(TaskContinuationOptions)}, ReturnType = "System.Threading.Tasks.Task`1<TNewResult>")]
	[CalledBy(Type = typeof(Task), Member = "Start", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Task), Member = "ContinueWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<System.Threading.Tasks.Task>)}, ReturnType = typeof(Task))]
	[CalledBy(Type = typeof(YieldAwaiter), Member = "QueueContinuation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.Sockets.Socket+AwaitableSocketAsyncEventArgs", Member = "OnCompleted", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Action`1<Object>", typeof(object), typeof(short), typeof(ValueTaskSourceOnCompletedFlags)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(TaskScheduler), Member = "get_InternalCurrent", ReturnType = typeof(TaskScheduler))]
	public static TaskScheduler get_Current() { }

	[CallerCount(Count = 0)]
	public static TaskScheduler get_Default() { }

	[CalledBy(Type = typeof(Task), Member = "InternalWait", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(CancellationToken)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ThreadPoolTaskScheduler), Member = "QueueTask", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Runtime.CompilerServices.TaskAwaiter+<>c__DisplayClass11_0", Member = "<OutputWaitEtwEvents>b__0", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TaskAwaiter), Member = "OutputWaitEtwEvents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task), typeof(Action)}, ReturnType = typeof(Action))]
	[CallerCount(Count = 9)]
	[CallsUnknownMethods(Count = 5)]
	public int get_Id() { }

	[CalledBy(Type = typeof(Task), Member = "SetContinuationForAwait", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TaskSchedulerAwaitTaskContinuation), Member = "Run", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(AwaitTaskContinuation), Member = "get_IsValidLocationForInlining", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TaskScheduler), Member = "get_Current", ReturnType = typeof(TaskScheduler))]
	[CallerCount(Count = 4)]
	[CallsUnknownMethods(Count = 2)]
	internal static TaskScheduler get_InternalCurrent() { }

	[CallerCount(Count = 23)]
	[DeduplicatedMethod]
	internal override bool get_RequiresAtomicStartTransition() { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	internal override void NotifyWorkItemProgress() { }

	[CalledBy(Type = typeof(TaskExceptionHolder), Member = "Finalize", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Lock), Member = "Acquire", ReturnType = typeof(void))]
	[Calls(Type = typeof(Lock), Member = "Release", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	internal static void PublishUnobservedTaskException(object sender, UnobservedTaskExceptionEventArgs ueea) { }

	protected private abstract void QueueTask(Task task) { }

	[CallerCount(Count = 271)]
	[DeduplicatedMethod]
	protected private override bool TryDequeue(Task task) { }

	protected abstract bool TryExecuteTaskInline(Task task, bool taskWasPreviouslyQueued) { }

	[CalledBy(Type = typeof(Task), Member = "WrappedTryRunInline", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TaskContinuation), Member = "InlineIfPossibleOrElseQueue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TaskScheduler), Member = "TryRunInline", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task), typeof(bool)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(TaskScheduler), Member = "TryRunInline", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task), typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 15)]
	internal bool TryRunInline(Task task, bool taskWasPreviouslyQueued) { }

}

