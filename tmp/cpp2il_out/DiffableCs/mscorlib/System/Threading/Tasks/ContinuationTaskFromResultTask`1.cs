namespace System.Threading.Tasks;

internal sealed class ContinuationTaskFromResultTask : Task
{
	private Task<TAntecedentResult> m_antecedent; //Field offset: 0x0

	[CalledBy(Type = typeof(Task`1), Member = "ContinueWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Action`1<Task`1<TResult>>", typeof(TaskScheduler)}, ReturnType = typeof(Task))]
	[CalledBy(Type = typeof(Task`1), Member = "ContinueWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Action`1<Task`1<TResult>>", typeof(TaskScheduler), typeof(CancellationToken), typeof(TaskContinuationOptions)}, ReturnType = typeof(Task))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Task), Member = "InternalCurrentIfAttached", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TaskCreationOptions)}, ReturnType = typeof(Task))]
	[Calls(Type = typeof(Task), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(object), typeof(Task), typeof(CancellationToken), typeof(TaskCreationOptions), typeof(InternalTaskOptions), typeof(TaskScheduler)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public ContinuationTaskFromResultTask`1(Task<TAntecedentResult> antecedent, Delegate action, object state, TaskCreationOptions creationOptions, InternalTaskOptions internalOptions) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Task), Member = "NotifyDebuggerOfWaitCompletionIfNecessary", ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 6)]
	[DeduplicatedMethod]
	internal virtual void InnerInvoke() { }

}

