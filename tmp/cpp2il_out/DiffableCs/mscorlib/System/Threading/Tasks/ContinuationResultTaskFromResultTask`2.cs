namespace System.Threading.Tasks;

internal sealed class ContinuationResultTaskFromResultTask : Task<TResult>
{
	private Task<TAntecedentResult> m_antecedent; //Field offset: 0x0

	[CalledBy(Type = typeof(Task`1), Member = "ContinueWith", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TNewResult"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Func`2<Task`1<TResult>, TNewResult>", typeof(TaskContinuationOptions)}, ReturnType = "System.Threading.Tasks.Task`1<TNewResult>")]
	[CalledBy(Type = typeof(Task`1), Member = "ContinueWith", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TNewResult"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Func`2<Task`1<TResult>, TNewResult>", typeof(TaskScheduler), typeof(CancellationToken), typeof(TaskContinuationOptions)}, ReturnType = "System.Threading.Tasks.Task`1<TNewResult>")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Task), Member = "InternalCurrentIfAttached", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TaskCreationOptions)}, ReturnType = typeof(Task))]
	[Calls(Type = typeof(System.Threading.Tasks.Task`1<System.Nullable`1<System.Int32>>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(object), typeof(Task), typeof(CancellationToken), typeof(TaskCreationOptions), typeof(InternalTaskOptions), typeof(TaskScheduler)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public ContinuationResultTaskFromResultTask`2(Task<TAntecedentResult> antecedent, Delegate function, object state, TaskCreationOptions creationOptions, InternalTaskOptions internalOptions) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Task), Member = "NotifyDebuggerOfWaitCompletionIfNecessary", ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 6)]
	[DeduplicatedMethod]
	internal virtual void InnerInvoke() { }

}

