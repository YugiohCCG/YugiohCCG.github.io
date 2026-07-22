namespace System.Threading.Tasks;

public class TaskFactory
{
	public sealed class CompleteOnInvokePromise : Task<Task>, ITaskCompletionAction
	{
		private IList<Task> _tasks; //Field offset: 0x58

		public override bool InvokeMayRunArbitraryCode
		{
			[CallerCount(Count = 23)]
			[DeduplicatedMethod]
			 get { } //Length: 3
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(System.Threading.Tasks.Task`1<System.Object>), Member = ".ctor", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 2)]
		public CompleteOnInvokePromise(IList<Task> tasks) { }

		[CallerCount(Count = 23)]
		[DeduplicatedMethod]
		public override bool get_InvokeMayRunArbitraryCode() { }

		[CalledBy(Type = typeof(TaskFactory), Member = "CommonCWAnyLogic", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IList`1<System.Threading.Tasks.Task>)}, ReturnType = typeof(System.Threading.Tasks.Task`1<System.Threading.Tasks.Task>))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(System.Threading.Tasks.Task`1<System.Object>), Member = "TrySetResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Task), Member = "get_IsCompleted", ReturnType = typeof(bool))]
		[Calls(Type = typeof(Task), Member = "RemoveContinuation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 5)]
		public override void Invoke(Task completingTask) { }

	}

	private readonly CancellationToken m_defaultCancellationToken; //Field offset: 0x10
	private readonly TaskScheduler m_defaultScheduler; //Field offset: 0x18
	private readonly TaskCreationOptions m_defaultCreationOptions; //Field offset: 0x20
	private readonly TaskContinuationOptions m_defaultContinuationOptions; //Field offset: 0x24

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public TaskFactory() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 20)]
	public TaskFactory(CancellationToken cancellationToken, TaskCreationOptions creationOptions, TaskContinuationOptions continuationOptions, TaskScheduler scheduler) { }

	[CalledBy(Type = typeof(TaskFactory`1), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TaskFactory`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken), typeof(TaskCreationOptions), typeof(TaskContinuationOptions), typeof(TaskScheduler)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	internal static void CheckCreationOptions(TaskCreationOptions creationOptions) { }

	[CalledBy(Type = typeof(TaskFactory`1), Member = "FromAsyncImpl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Func`3<System.AsyncCallback, System.Object, System.IAsyncResult>), "System.Func`2<IAsyncResult, TResult>", typeof(System.Action`1<System.IAsyncResult>), typeof(object), typeof(TaskCreationOptions)}, ReturnType = "System.Threading.Tasks.Task`1<TResult>")]
	[CalledBy(Type = typeof(TaskFactory`1), Member = "FromAsyncImpl", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TArg1"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Func`4<TArg1, AsyncCallback, Object, IAsyncResult>", "System.Func`2<IAsyncResult, TResult>", typeof(System.Action`1<System.IAsyncResult>), "TArg1", typeof(object), typeof(TaskCreationOptions)}, ReturnType = "System.Threading.Tasks.Task`1<TResult>")]
	[CalledBy(Type = typeof(TaskFactory`1), Member = "FromAsyncImpl", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TArg1", "TArg2"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Func`5<TArg1, TArg2, AsyncCallback, Object, IAsyncResult>", "System.Func`2<IAsyncResult, TResult>", typeof(System.Action`1<System.IAsyncResult>), "TArg1", "TArg2", typeof(object), typeof(TaskCreationOptions)}, ReturnType = "System.Threading.Tasks.Task`1<TResult>")]
	[CalledBy(Type = typeof(TaskFactory`1), Member = "FromAsyncImpl", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TArg1", "TArg2", "TArg3"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Func`6<TArg1, TArg2, TArg3, AsyncCallback, Object, IAsyncResult>", "System.Func`2<IAsyncResult, TResult>", typeof(System.Action`1<System.IAsyncResult>), "TArg1", "TArg2", "TArg3", typeof(object), typeof(TaskCreationOptions)}, ReturnType = "System.Threading.Tasks.Task`1<TResult>")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 14)]
	internal static void CheckFromAsyncOptions(TaskCreationOptions creationOptions, bool hasBeginMethod) { }

	[CalledBy(Type = typeof(TaskFactory`1), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TaskFactory`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken), typeof(TaskCreationOptions), typeof(TaskContinuationOptions), typeof(TaskScheduler)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 14)]
	internal static void CheckMultiTaskContinuationOptions(TaskContinuationOptions continuationOptions) { }

	[CalledBy(Type = typeof(Task), Member = "WhenAny", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task[])}, ReturnType = typeof(System.Threading.Tasks.Task`1<System.Threading.Tasks.Task>))]
	[CalledBy(Type = typeof(Task), Member = "WhenAny", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Threading.Tasks.Task>)}, ReturnType = typeof(System.Threading.Tasks.Task`1<System.Threading.Tasks.Task>))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(System.Threading.Tasks.Task`1<System.Object>), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(Task), Member = "get_IsCompleted", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Task), Member = "AddTaskContinuation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Task), Member = "RemoveContinuation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CompleteOnInvokePromise), Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 11)]
	internal static Task<Task> CommonCWAnyLogic(IList<Task> tasks) { }

	[CalledBy(Type = "System.Net.WebConnection+<Connect>d__16", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.Threading.Tasks.TaskFactory`1<System.Threading.Tasks.VoidTaskResult>), Member = "FromAsyncImpl", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Func`4<System.Object, System.AsyncCallback, System.Object, System.IAsyncResult>), typeof(System.Func`2<System.IAsyncResult, System.Threading.Tasks.VoidTaskResult>), typeof(System.Action`1<System.IAsyncResult>), typeof(object), typeof(object), typeof(TaskCreationOptions)}, ReturnType = typeof(System.Threading.Tasks.Task`1<System.Threading.Tasks.VoidTaskResult>))]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public Task FromAsync(Func<TArg1, AsyncCallback, Object, IAsyncResult> beginMethod, Action<IAsyncResult> endMethod, TArg1 arg1, object state) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.Threading.Tasks.TaskFactory`1<System.Threading.Tasks.VoidTaskResult>), Member = "FromAsyncImpl", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Func`4<System.Object, System.AsyncCallback, System.Object, System.IAsyncResult>), typeof(System.Func`2<System.IAsyncResult, System.Threading.Tasks.VoidTaskResult>), typeof(System.Action`1<System.IAsyncResult>), typeof(object), typeof(object), typeof(TaskCreationOptions)}, ReturnType = typeof(System.Threading.Tasks.Task`1<System.Threading.Tasks.VoidTaskResult>))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public Task FromAsync(Func<TArg1, AsyncCallback, Object, IAsyncResult> beginMethod, Action<IAsyncResult> endMethod, TArg1 arg1, object state, TaskCreationOptions creationOptions) { }

	[CalledBy(Type = "System.Net.Sockets.TcpClient", Member = "ConnectAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Net.IPAddress", typeof(int)}, ReturnType = typeof(Task))]
	[CalledBy(Type = "System.Net.Sockets.TcpClient", Member = "ConnectAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(Task))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(TaskFactory`1), Member = "FromAsyncImpl", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TArg1", "TArg2"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Func`5<TArg1, TArg2, AsyncCallback, Object, IAsyncResult>", "System.Func`2<IAsyncResult, TResult>", typeof(System.Action`1<System.IAsyncResult>), "TArg1", "TArg2", typeof(object), typeof(TaskCreationOptions)}, ReturnType = "System.Threading.Tasks.Task`1<TResult>")]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public Task FromAsync(Func<TArg1, TArg2, AsyncCallback, Object, IAsyncResult> beginMethod, Action<IAsyncResult> endMethod, TArg1 arg1, TArg2 arg2, object state) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TaskFactory`1), Member = "FromAsyncImpl", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TArg1", "TArg2"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Func`5<TArg1, TArg2, AsyncCallback, Object, IAsyncResult>", "System.Func`2<IAsyncResult, TResult>", typeof(System.Action`1<System.IAsyncResult>), "TArg1", "TArg2", typeof(object), typeof(TaskCreationOptions)}, ReturnType = "System.Threading.Tasks.Task`1<TResult>")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public Task FromAsync(Func<TArg1, TArg2, AsyncCallback, Object, IAsyncResult> beginMethod, Action<IAsyncResult> endMethod, TArg1 arg1, TArg2 arg2, object state, TaskCreationOptions creationOptions) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private TaskScheduler GetDefaultScheduler(Task currTask) { }

	[CalledBy(Type = "DigitalRuby.Threading.EZThread+EZThreadRunner", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "DigitalRuby.Threading.EZThread", Member = "InternalExecute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Func`1<Object>", "System.Action`1<Object>"}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Task), Member = "TaskConstructorCore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(object), typeof(CancellationToken), typeof(TaskCreationOptions), typeof(InternalTaskOptions), typeof(TaskScheduler)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Task), Member = "ScheduleAndStart", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 12)]
	public Task StartNew(Action action) { }

	[CalledBy(Type = "SQLite.SQLiteAsyncConnection", Member = "CloseAsync", ReturnType = typeof(Task))]
	[CalledBy(Type = typeof(YieldAwaiter), Member = "QueueContinuation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Task), Member = "InternalCurrentIfAttached", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TaskCreationOptions)}, ReturnType = typeof(Task))]
	[Calls(Type = typeof(Task), Member = "TaskConstructorCore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(object), typeof(CancellationToken), typeof(TaskCreationOptions), typeof(InternalTaskOptions), typeof(TaskScheduler)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Task), Member = "ScheduleAndStart", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 10)]
	public Task StartNew(Action action, CancellationToken cancellationToken, TaskCreationOptions creationOptions, TaskScheduler scheduler) { }

	[CalledBy(Type = typeof(TextWriter), Member = "WriteAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(Task))]
	[CalledBy(Type = typeof(TextWriter), Member = "WriteAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Task))]
	[CalledBy(Type = typeof(TextWriter), Member = "WriteAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(Task))]
	[CalledBy(Type = typeof(TextWriter), Member = "WriteAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlyMemory`1<System.Char>), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CalledBy(Type = typeof(TextWriter), Member = "FlushAsync", ReturnType = typeof(Task))]
	[CalledBy(Type = typeof(Stream), Member = "FlushAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CalledBy(Type = typeof(FileStream), Member = "FlushAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CalledBy(Type = "System.Net.Sockets.Socket+AwaitableSocketAsyncEventArgs", Member = "InvokeContinuation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Action`1<Object>", typeof(object), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(Task), Member = "InternalCurrentIfAttached", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TaskCreationOptions)}, ReturnType = typeof(Task))]
	[Calls(Type = typeof(Task), Member = "TaskConstructorCore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(object), typeof(CancellationToken), typeof(TaskCreationOptions), typeof(InternalTaskOptions), typeof(TaskScheduler)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Task), Member = "ScheduleAndStart", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 10)]
	public Task StartNew(Action<Object> action, object state, CancellationToken cancellationToken, TaskCreationOptions creationOptions, TaskScheduler scheduler) { }

	[CalledBy(Type = "SQLite.SQLiteAsyncConnection", Member = "WriteAsync", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Func`2<SQLiteConnectionWithLock, T>"}, ReturnType = "System.Threading.Tasks.Task`1<T>")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Task), Member = "InternalCurrentIfAttached", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TaskCreationOptions)}, ReturnType = typeof(Task))]
	[Calls(Type = typeof(System.Threading.Tasks.Task`1<System.Int32>), Member = "StartNew", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task), typeof(System.Func`1<System.Int32>), typeof(CancellationToken), typeof(TaskCreationOptions), typeof(InternalTaskOptions), typeof(TaskScheduler)}, ReturnType = typeof(System.Threading.Tasks.Task`1<System.Int32>))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public Task<TResult> StartNew(Func<TResult> function, CancellationToken cancellationToken, TaskCreationOptions creationOptions, TaskScheduler scheduler) { }

	[CalledBy(Type = "System.Net.ServicePointScheduler+AsyncManualResetEvent", Member = "Set", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Task), Member = "InternalCurrentIfAttached", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TaskCreationOptions)}, ReturnType = typeof(Task))]
	[Calls(Type = typeof(System.Threading.Tasks.Task`1<System.Boolean>), Member = "StartNew", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task), typeof(System.Func`2<System.Object, System.Boolean>), typeof(object), typeof(CancellationToken), typeof(TaskCreationOptions), typeof(InternalTaskOptions), typeof(TaskScheduler)}, ReturnType = typeof(System.Threading.Tasks.Task`1<System.Boolean>))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public Task<TResult> StartNew(Func<Object, TResult> function, object state, CancellationToken cancellationToken, TaskCreationOptions creationOptions, TaskScheduler scheduler) { }

}

