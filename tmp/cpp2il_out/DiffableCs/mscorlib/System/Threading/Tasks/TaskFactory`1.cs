namespace System.Threading.Tasks;

public class TaskFactory
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass35_0
	{
		public Func<IAsyncResult, TResult> endFunction; //Field offset: 0x0
		public Action<IAsyncResult> endAction; //Field offset: 0x0
		public Task<TResult> promise; //Field offset: 0x0

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c__DisplayClass35_0() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(TaskFactory`1), Member = "FromAsyncCoreLogic", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncResult), "System.Func`2<IAsyncResult, TResult>", typeof(System.Action`1<System.IAsyncResult>), "System.Threading.Tasks.Task`1<TResult>", typeof(bool)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		internal void <FromAsyncImpl>b__0(IAsyncResult iar) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass38_0
	{
		public Func<IAsyncResult, TResult> endFunction; //Field offset: 0x0
		public Action<IAsyncResult> endAction; //Field offset: 0x0
		public Task<TResult> promise; //Field offset: 0x0

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c__DisplayClass38_0`1() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(System.Threading.Tasks.TaskFactory`1<System.Object>), Member = "FromAsyncCoreLogic", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncResult), typeof(System.Func`2<System.IAsyncResult, System.Object>), typeof(System.Action`1<System.IAsyncResult>), typeof(System.Threading.Tasks.Task`1<System.Object>), typeof(bool)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		internal void <FromAsyncImpl>b__0(IAsyncResult iar) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass41_0
	{
		public Func<IAsyncResult, TResult> endFunction; //Field offset: 0x0
		public Action<IAsyncResult> endAction; //Field offset: 0x0
		public Task<TResult> promise; //Field offset: 0x0

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c__DisplayClass41_0`2() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(System.Threading.Tasks.TaskFactory`1<System.Threading.Tasks.VoidTaskResult>), Member = "FromAsyncCoreLogic", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncResult), typeof(System.Func`2<System.IAsyncResult, System.Threading.Tasks.VoidTaskResult>), typeof(System.Action`1<System.IAsyncResult>), typeof(System.Threading.Tasks.Task`1<System.Threading.Tasks.VoidTaskResult>), typeof(bool)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		internal void <FromAsyncImpl>b__0(IAsyncResult iar) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass44_0
	{
		public Func<IAsyncResult, TResult> endFunction; //Field offset: 0x0
		public Action<IAsyncResult> endAction; //Field offset: 0x0
		public Task<TResult> promise; //Field offset: 0x0

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c__DisplayClass44_0`3() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(System.Threading.Tasks.TaskFactory`1<System.Int32>), Member = "FromAsyncCoreLogic", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncResult), typeof(System.Func`2<System.IAsyncResult, System.Int32>), typeof(System.Action`1<System.IAsyncResult>), typeof(System.Threading.Tasks.Task`1<System.Int32>), typeof(bool)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		internal void <FromAsyncImpl>b__0(IAsyncResult iar) { }

	}

	private sealed class FromAsyncTrimPromise : Task<TResult>
	{
		internal static readonly AsyncCallback s_completeFromAsyncResult; //Field offset: 0x0
		private TInstance m_thisRef; //Field offset: 0x0
		private Func<TInstance, IAsyncResult, TResult> m_endMethod; //Field offset: 0x0

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 6)]
		[DeduplicatedMethod]
		private static FromAsyncTrimPromise`1() { }

		[CalledBy(Type = typeof(TaskFactory`1), Member = "FromAsyncTrim", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TInstance", "TArgs"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TInstance", "TArgs", "System.Func`5<TInstance, TArgs, AsyncCallback, Object, IAsyncResult>", "System.Func`3<TInstance, IAsyncResult, TResult>"}, ReturnType = "System.Threading.Tasks.Task`1<TResult>")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(System.Threading.Tasks.Task`1<System.Int32>), Member = ".ctor", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		internal FromAsyncTrimPromise`1(TInstance thisRef, Func<TInstance, IAsyncResult, TResult> endMethod) { }

		[CalledBy(Type = typeof(FromAsyncTrimPromise`1), Member = "CompleteFromAsyncResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncResult)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TaskFactory`1), Member = "FromAsyncTrim", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TInstance", "TArgs"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TInstance", "TArgs", "System.Func`5<TInstance, TArgs, AsyncCallback, Object, IAsyncResult>", "System.Func`3<TInstance, IAsyncResult, TResult>"}, ReturnType = "System.Threading.Tasks.Task`1<TResult>")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Task`1), Member = "DangerousSetResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TResult"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Task`1), Member = "TrySetResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TResult"}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Task), Member = "TrySetCanceled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken), typeof(object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Task), Member = "TrySetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 4)]
		[DeduplicatedMethod]
		internal void Complete(TInstance thisRef, Func<TInstance, IAsyncResult, TResult> endMethod, IAsyncResult asyncResult, bool requiresSynchronization) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(FromAsyncTrimPromise`1), Member = "Complete", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TInstance", "System.Func`3<TInstance, IAsyncResult, TResult>", typeof(IAsyncResult), typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 17)]
		[DeduplicatedMethod]
		internal static void CompleteFromAsyncResult(IAsyncResult asyncResult) { }

	}

	private CancellationToken m_defaultCancellationToken; //Field offset: 0x0
	private TaskScheduler m_defaultScheduler; //Field offset: 0x0
	private TaskCreationOptions m_defaultCreationOptions; //Field offset: 0x0
	private TaskContinuationOptions m_defaultContinuationOptions; //Field offset: 0x0

	[CalledBy(Type = typeof(Task`1), Member = "get_Factory", ReturnType = "System.Threading.Tasks.TaskFactory`1<TResult>")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TaskFactory), Member = "CheckMultiTaskContinuationOptions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TaskContinuationOptions)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TaskFactory), Member = "CheckCreationOptions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TaskCreationOptions)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Task), Member = "TrySetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Task), Member = "TrySetCanceled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken), typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Task), Member = "get_IsCompleted", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Task), Member = "AtomicStateUpdate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Interlocked), Member = "Exchange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ContingentProperties), Member = "SetCompleted", ReturnType = typeof(void))]
	[Calls(Type = typeof(Task), Member = "FinishStageThree", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 31)]
	[CallsUnknownMethods(Count = 132)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public TaskFactory`1() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TaskFactory), Member = "CheckMultiTaskContinuationOptions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TaskContinuationOptions)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TaskFactory), Member = "CheckCreationOptions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TaskCreationOptions)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public TaskFactory`1(CancellationToken cancellationToken, TaskCreationOptions creationOptions, TaskContinuationOptions continuationOptions, TaskScheduler scheduler) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TaskFactory`1), Member = "FromAsyncImpl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Func`3<System.AsyncCallback, System.Object, System.IAsyncResult>), "System.Func`2<IAsyncResult, TResult>", typeof(System.Action`1<System.IAsyncResult>), typeof(object), typeof(TaskCreationOptions)}, ReturnType = "System.Threading.Tasks.Task`1<TResult>")]
	[DeduplicatedMethod]
	public Task<TResult> FromAsync(Func<AsyncCallback, Object, IAsyncResult> beginMethod, Func<IAsyncResult, TResult> endMethod, object state) { }

	[CalledBy(Type = "System.Net.Dns", Member = "GetHostAddressesAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = "System.Threading.Tasks.Task`1<IPAddress[]>")]
	[CalledBy(Type = "System.Net.Dns", Member = "GetHostEntryAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = "System.Threading.Tasks.Task`1<IPHostEntry>")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(TaskFactory`1), Member = "FromAsyncImpl", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TArg1"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Func`4<TArg1, AsyncCallback, Object, IAsyncResult>", "System.Func`2<IAsyncResult, TResult>", typeof(System.Action`1<System.IAsyncResult>), "TArg1", typeof(object), typeof(TaskCreationOptions)}, ReturnType = "System.Threading.Tasks.Task`1<TResult>")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public Task<TResult> FromAsync(Func<TArg1, AsyncCallback, Object, IAsyncResult> beginMethod, Func<IAsyncResult, TResult> endMethod, TArg1 arg1, object state) { }

	[CalledBy(Type = "System.Net.Sockets.UdpClient", Member = "SendAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Byte[]", typeof(int), "System.Net.IPEndPoint"}, ReturnType = "System.Threading.Tasks.Task`1<Int32>")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TaskFactory`1), Member = "FromAsyncImpl", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TArg1", "TArg2", "TArg3"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Func`6<TArg1, TArg2, TArg3, AsyncCallback, Object, IAsyncResult>", "System.Func`2<IAsyncResult, TResult>", typeof(System.Action`1<System.IAsyncResult>), "TArg1", "TArg2", "TArg3", typeof(object), typeof(TaskCreationOptions)}, ReturnType = "System.Threading.Tasks.Task`1<TResult>")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public Task<TResult> FromAsync(Func<TArg1, TArg2, TArg3, AsyncCallback, Object, IAsyncResult> beginMethod, Func<IAsyncResult, TResult> endMethod, TArg1 arg1, TArg2 arg2, TArg3 arg3, object state) { }

	[CalledBy(Type = typeof(<>c__DisplayClass35_0), Member = "<FromAsyncImpl>b__0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncResult)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TaskFactory`1), Member = "FromAsyncImpl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Func`3<System.AsyncCallback, System.Object, System.IAsyncResult>), "System.Func`2<IAsyncResult, TResult>", typeof(System.Action`1<System.IAsyncResult>), typeof(object), typeof(TaskCreationOptions)}, ReturnType = "System.Threading.Tasks.Task`1<TResult>")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 7)]
	[DeduplicatedMethod]
	private static void FromAsyncCoreLogic(IAsyncResult iar, Func<IAsyncResult, TResult> endFunction, Action<IAsyncResult> endAction, Task<TResult> promise, bool requiresSynchronization) { }

	[CalledBy(Type = typeof(TaskFactory`1), Member = "FromAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Func`3<System.AsyncCallback, System.Object, System.IAsyncResult>), "System.Func`2<IAsyncResult, TResult>", typeof(object)}, ReturnType = "System.Threading.Tasks.Task`1<TResult>")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TaskFactory), Member = "CheckFromAsyncOptions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TaskCreationOptions), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Task`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(TaskCreationOptions)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(TaskFactory`1), Member = "FromAsyncCoreLogic", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncResult), "System.Func`2<IAsyncResult, TResult>", typeof(System.Action`1<System.IAsyncResult>), "System.Threading.Tasks.Task`1<TResult>", typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 38)]
	[DeduplicatedMethod]
	internal static Task<TResult> FromAsyncImpl(Func<AsyncCallback, Object, IAsyncResult> beginMethod, Func<IAsyncResult, TResult> endFunction, Action<IAsyncResult> endAction, object state, TaskCreationOptions creationOptions) { }

	[CalledBy(Type = typeof(TaskFactory`1), Member = "FromAsync", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TArg1"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Func`4<TArg1, AsyncCallback, Object, IAsyncResult>", "System.Func`2<IAsyncResult, TResult>", "TArg1", typeof(object)}, ReturnType = "System.Threading.Tasks.Task`1<TResult>")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TaskFactory), Member = "CheckFromAsyncOptions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TaskCreationOptions), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Threading.Tasks.Task`1<System.Object>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(TaskCreationOptions)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(System.Threading.Tasks.TaskFactory`1<System.Object>), Member = "FromAsyncCoreLogic", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncResult), typeof(System.Func`2<System.IAsyncResult, System.Object>), typeof(System.Action`1<System.IAsyncResult>), typeof(System.Threading.Tasks.Task`1<System.Object>), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 36)]
	[DeduplicatedMethod]
	internal static Task<TResult> FromAsyncImpl(Func<TArg1, AsyncCallback, Object, IAsyncResult> beginMethod, Func<IAsyncResult, TResult> endFunction, Action<IAsyncResult> endAction, TArg1 arg1, object state, TaskCreationOptions creationOptions) { }

	[CalledBy(Type = typeof(TaskFactory), Member = "FromAsync", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TArg1", "TArg2"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Func`5<TArg1, TArg2, AsyncCallback, Object, IAsyncResult>", typeof(System.Action`1<System.IAsyncResult>), "TArg1", "TArg2", typeof(object)}, ReturnType = typeof(Task))]
	[CalledBy(Type = typeof(TaskFactory), Member = "FromAsync", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TArg1", "TArg2"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Func`5<TArg1, TArg2, AsyncCallback, Object, IAsyncResult>", typeof(System.Action`1<System.IAsyncResult>), "TArg1", "TArg2", typeof(object), typeof(TaskCreationOptions)}, ReturnType = typeof(Task))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(TaskFactory), Member = "CheckFromAsyncOptions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TaskCreationOptions), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Threading.Tasks.Task`1<System.Threading.Tasks.VoidTaskResult>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(TaskCreationOptions)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(System.Threading.Tasks.TaskFactory`1<System.Threading.Tasks.VoidTaskResult>), Member = "FromAsyncCoreLogic", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncResult), typeof(System.Func`2<System.IAsyncResult, System.Threading.Tasks.VoidTaskResult>), typeof(System.Action`1<System.IAsyncResult>), typeof(System.Threading.Tasks.Task`1<System.Threading.Tasks.VoidTaskResult>), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 36)]
	[DeduplicatedMethod]
	internal static Task<TResult> FromAsyncImpl(Func<TArg1, TArg2, AsyncCallback, Object, IAsyncResult> beginMethod, Func<IAsyncResult, TResult> endFunction, Action<IAsyncResult> endAction, TArg1 arg1, TArg2 arg2, object state, TaskCreationOptions creationOptions) { }

	[CalledBy(Type = typeof(TaskFactory`1), Member = "FromAsync", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TArg1", "TArg2", "TArg3"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Func`6<TArg1, TArg2, TArg3, AsyncCallback, Object, IAsyncResult>", "System.Func`2<IAsyncResult, TResult>", "TArg1", "TArg2", "TArg3", typeof(object)}, ReturnType = "System.Threading.Tasks.Task`1<TResult>")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TaskFactory), Member = "CheckFromAsyncOptions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TaskCreationOptions), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Threading.Tasks.Task`1<System.Int32>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(TaskCreationOptions)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(System.Threading.Tasks.TaskFactory`1<System.Int32>), Member = "FromAsyncCoreLogic", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncResult), typeof(System.Func`2<System.IAsyncResult, System.Int32>), typeof(System.Action`1<System.IAsyncResult>), typeof(System.Threading.Tasks.Task`1<System.Int32>), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 36)]
	[DeduplicatedMethod]
	internal static Task<TResult> FromAsyncImpl(Func<TArg1, TArg2, TArg3, AsyncCallback, Object, IAsyncResult> beginMethod, Func<IAsyncResult, TResult> endFunction, Action<IAsyncResult> endAction, TArg1 arg1, TArg2 arg2, TArg3 arg3, object state, TaskCreationOptions creationOptions) { }

	[CalledBy(Type = typeof(Stream), Member = "BeginEndReadAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(System.Threading.Tasks.Task`1<System.Int32>))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(FromAsyncTrimPromise`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TInstance", "System.Func`3<TInstance, IAsyncResult, TResult>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FromAsyncTrimPromise`1), Member = "Complete", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TInstance", "System.Func`3<TInstance, IAsyncResult, TResult>", typeof(IAsyncResult), typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	[DeduplicatedMethod]
	internal static Task<TResult> FromAsyncTrim(TInstance thisRef, TArgs args, Func<TInstance, TArgs, AsyncCallback, Object, IAsyncResult> beginMethod, Func<TInstance, IAsyncResult, TResult> endMethod) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Task), Member = "InternalCurrentIfAttached", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TaskCreationOptions)}, ReturnType = typeof(Task))]
	[Calls(Type = typeof(Task`1), Member = "StartNew", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task), "System.Func`2<Object, TResult>", typeof(object), typeof(CancellationToken), typeof(TaskCreationOptions), typeof(InternalTaskOptions), typeof(TaskScheduler)}, ReturnType = "System.Threading.Tasks.Task`1<TResult>")]
	[DeduplicatedMethod]
	public Task<TResult> StartNew(Func<Object, TResult> function, object state, CancellationToken cancellationToken, TaskCreationOptions creationOptions, TaskScheduler scheduler) { }

}

