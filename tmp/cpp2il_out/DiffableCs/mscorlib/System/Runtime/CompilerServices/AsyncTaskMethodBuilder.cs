namespace System.Runtime.CompilerServices;

public struct AsyncTaskMethodBuilder
{
	private static readonly Task<VoidTaskResult> s_cachedCompleted; //Field offset: 0x0
	private AsyncTaskMethodBuilder<VoidTaskResult> m_builder; //Field offset: 0x0

	public Task Task
	{
		[CallerCount(Count = 625)]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Threading.Tasks.VoidTaskResult>), Member = "get_Task", ReturnType = typeof(System.Threading.Tasks.Task`1<System.Threading.Tasks.VoidTaskResult>))]
		 get { } //Length: 90
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private static AsyncTaskMethodBuilder() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public void AwaitOnCompleted(ref TAwaiter awaiter, ref TStateMachine stateMachine) { }

	[CallerCount(Count = 4)]
	[Calls(Type = typeof(AsyncTaskMethodBuilder`1), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public void AwaitUnsafeOnCompleted(ref TAwaiter awaiter, ref TStateMachine stateMachine) { }

	[CallerCount(Count = 941)]
	[DeduplicatedMethod]
	public static AsyncTaskMethodBuilder Create() { }

	[CallerCount(Count = 625)]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Threading.Tasks.VoidTaskResult>), Member = "get_Task", ReturnType = typeof(System.Threading.Tasks.Task`1<System.Threading.Tasks.VoidTaskResult>))]
	public Task get_Task() { }

	[CallerCount(Count = 476)]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Threading.Tasks.VoidTaskResult>), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
	public void SetException(Exception exception) { }

	[CallerCount(Count = 477)]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Threading.Tasks.VoidTaskResult>), Member = "SetResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Threading.Tasks.Task`1<System.Threading.Tasks.VoidTaskResult>)}, ReturnType = typeof(void))]
	public void SetResult() { }

	[CallerCount(Count = 486)]
	[Calls(Type = typeof(AsyncTaskMethodBuilder`1), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
	public void SetStateMachine(IAsyncStateMachine stateMachine) { }

	[CalledBy(Type = "Manager.Helper", Member = "GetAsset", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Enumerator.AssetType", typeof(string), "System.Action`2<T, Object>", typeof(object), typeof(object)}, ReturnType = typeof(Task))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ExecutionContext), Member = "EstablishCopyOnWriteScope", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExecutionContextSwitcher&)}, ReturnType = typeof(void))]
	[Calls(Type = "Manager.Helper+<GetAsset>d__76`1", Member = "MoveNext", ReturnType = typeof(void))]
	[Calls(Type = typeof(ExecutionContextSwitcher), Member = "Undo", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DebuggerStepThrough]
	[DeduplicatedMethod]
	public void Start(ref TStateMachine stateMachine) { }

}

