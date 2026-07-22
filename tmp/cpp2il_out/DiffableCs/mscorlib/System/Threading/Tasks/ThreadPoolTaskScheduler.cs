namespace System.Threading.Tasks;

internal sealed class ThreadPoolTaskScheduler : TaskScheduler
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		private static <>c() { }

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Task), Member = "ExecuteEntry", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 2)]
		internal void <.cctor>b__10_0(object s) { }

	}

	private static readonly ParameterizedThreadStart s_longRunningThreadWork; //Field offset: 0x0

	internal virtual bool RequiresAtomicStartTransition
	{
		[CallerCount(Count = 271)]
		[DeduplicatedMethod]
		internal get { } //Length: 3
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private static ThreadPoolTaskScheduler() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	internal ThreadPoolTaskScheduler() { }

	[CallerCount(Count = 271)]
	[DeduplicatedMethod]
	internal virtual bool get_RequiresAtomicStartTransition() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ThreadPool), Member = "EnsureVMInitialized", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	internal virtual void NotifyWorkItemProgress() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TaskTrace), Member = "get_Enabled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(TaskScheduler), Member = "get_Id", ReturnType = typeof(int))]
	[Calls(Type = typeof(Task), Member = "get_Id", ReturnType = typeof(int))]
	[Calls(Type = typeof(TaskTrace), Member = "TaskScheduled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ThreadPool), Member = "UnsafeQueueCustomWorkItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IThreadPoolWorkItem), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RuntimeThread), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParameterizedThreadStart), typeof(int)}, ReturnType = typeof(RuntimeThread))]
	[Calls(Type = typeof(RuntimeThread), Member = "set_IsBackground", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RuntimeThread), Member = "Start", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	[ContainsUnimplementedInstructions]
	protected private virtual void QueueTask(Task task) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ThreadPool), Member = "TryPopCustomWorkItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IThreadPoolWorkItem)}, ReturnType = typeof(bool))]
	protected private virtual bool TryDequeue(Task task) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ThreadPool), Member = "TryPopCustomWorkItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IThreadPoolWorkItem)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Task), Member = "ExecuteEntry", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	protected virtual bool TryExecuteTaskInline(Task task, bool taskWasPreviouslyQueued) { }

}

