namespace System.Threading.Tasks;

internal sealed class UnwrapPromise : Task<TResult>, ITaskCompletionAction
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c<TResult> <>9; //Field offset: 0x0
		public static WaitCallback <>9__8_0; //Field offset: 0x0

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 8)]
		[DeduplicatedMethod]
		private static <>c() { }

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UnwrapPromise`1), Member = "InvokeCore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		[DeduplicatedMethod]
		internal void <InvokeCoreAsync>b__8_0(object state) { }

	}

	private byte _state; //Field offset: 0x0
	private readonly bool _lookForOce; //Field offset: 0x0

	public override bool InvokeMayRunArbitraryCode
	{
		[CallerCount(Count = 23)]
		[DeduplicatedMethod]
		 get { } //Length: 3
	}

	[CalledBy(Type = typeof(Task), Member = "Run", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TResult"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Func`1<Task`1<TResult>>", typeof(CancellationToken)}, ReturnType = "System.Threading.Tasks.Task`1<TResult>")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Task), Member = "get_CreationOptions", ReturnType = typeof(TaskCreationOptions))]
	[Calls(Type = typeof(System.Threading.Tasks.Task`1<System.Object>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(TaskCreationOptions)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Task), Member = "get_IsCompleted", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Task), Member = "AddCompletionAction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ITaskCompletionAction)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UnwrapPromise`1), Member = "ProcessCompletedOuterTask", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public UnwrapPromise`1(Task outerTask, bool lookForOce) { }

	[CallerCount(Count = 23)]
	[DeduplicatedMethod]
	public override bool get_InvokeMayRunArbitraryCode() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Task), Member = "get_CurrentStackGuard", ReturnType = typeof(StackGuard))]
	[Calls(Type = typeof(StackGuard), Member = "TryBeginInliningScope", ReturnType = typeof(bool))]
	[Calls(Type = typeof(UnwrapPromise`1), Member = "ProcessCompletedOuterTask", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UnwrapPromise`1), Member = "TrySetFromTask", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task), typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(StackGuard), Member = "EndInliningScope", ReturnType = typeof(void))]
	[Calls(Type = typeof(UnwrapPromise`1), Member = "InvokeCoreAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	public override void Invoke(Task completingTask) { }

	[CalledBy(Type = typeof(<>c), Member = "<InvokeCoreAsync>b__8_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnwrapPromise`1), Member = "ProcessCompletedOuterTask", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UnwrapPromise`1), Member = "TrySetFromTask", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task), typeof(bool)}, ReturnType = typeof(bool))]
	[DeduplicatedMethod]
	private void InvokeCore(Task completingTask) { }

	[CalledBy(Type = typeof(UnwrapPromise`1), Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Tuple), Member = "Create", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(System.Tuple`2<System.Object, System.Object>))]
	[Calls(Type = typeof(ThreadPool), Member = "UnsafeQueueUserWorkItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WaitCallback), typeof(object)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	[DeduplicatedMethod]
	private void InvokeCoreAsync(Task completingTask) { }

	[CalledBy(Type = typeof(UnwrapPromise`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UnwrapPromise`1), Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UnwrapPromise`1), Member = "InvokeCore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Task), Member = "get_Status", ReturnType = typeof(TaskStatus))]
	[Calls(Type = typeof(Task`1), Member = "get_Result", ReturnType = "TResult")]
	[Calls(Type = typeof(Task), Member = "get_IsCompleted", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Task), Member = "AddCompletionAction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ITaskCompletionAction)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UnwrapPromise`1), Member = "TrySetFromTask", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task), typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Task), Member = "TrySetCanceled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	private void ProcessCompletedOuterTask(Task task) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Task), Member = "get_IsCompleted", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Task), Member = "AddCompletionAction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ITaskCompletionAction)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UnwrapPromise`1), Member = "TrySetFromTask", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task), typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Task), Member = "TrySetCanceled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	private void ProcessInnerTask(Task task) { }

	[CalledBy(Type = typeof(UnwrapPromise`1), Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UnwrapPromise`1), Member = "InvokeCore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UnwrapPromise`1), Member = "ProcessCompletedOuterTask", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UnwrapPromise`1), Member = "ProcessInnerTask", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(ReadOnlyCollection`1), Member = "get_Count", ReturnType = typeof(int))]
	[Calls(Type = typeof(Task), Member = "get_Status", ReturnType = typeof(TaskStatus))]
	[Calls(Type = typeof(Task), Member = "GetExceptionDispatchInfos", ReturnType = typeof(System.Collections.ObjectModel.ReadOnlyCollection`1<System.Runtime.ExceptionServices.ExceptionDispatchInfo>))]
	[Calls(Type = typeof(Task), Member = "TrySetCanceled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken), typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Task), Member = "TrySetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Task), Member = "get_CancellationToken", ReturnType = typeof(CancellationToken))]
	[Calls(Type = typeof(Task), Member = "GetCancellationExceptionDispatchInfo", ReturnType = typeof(ExceptionDispatchInfo))]
	[Calls(Type = typeof(Task`1), Member = "get_Result", ReturnType = "TResult")]
	[Calls(Type = typeof(System.Threading.Tasks.Task`1<System.Object>), Member = "TrySetResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	private bool TrySetFromTask(Task task, bool lookForOce) { }

}

