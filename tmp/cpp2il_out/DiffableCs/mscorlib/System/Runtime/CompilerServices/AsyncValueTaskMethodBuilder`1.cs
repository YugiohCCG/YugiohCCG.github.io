namespace System.Runtime.CompilerServices;

public struct AsyncValueTaskMethodBuilder
{
	private AsyncTaskMethodBuilder<TResult> _methodBuilder; //Field offset: 0x0
	private TResult _result; //Field offset: 0x0
	private bool _haveResult; //Field offset: 0x0
	private bool _useBuilder; //Field offset: 0x0

	public ValueTask<TResult> Task
	{
		[CalledBy(Type = typeof(StreamReader), Member = "ReadAsyncInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Memory`1<System.Char>), typeof(CancellationToken)}, ReturnType = typeof(System.Threading.Tasks.ValueTask`1<System.Int32>))]
		[CalledBy(Type = typeof(Stream), Member = "ReadAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Memory`1<System.Byte>), typeof(CancellationToken)}, ReturnType = typeof(System.Threading.Tasks.ValueTask`1<System.Int32>))]
		[CalledBy(Type = typeof(Stream), Member = "<ReadAsync>g__FinishReadAsync|44_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Threading.Tasks.Task`1<System.Int32>), typeof(Byte[]), typeof(System.Memory`1<System.Byte>)}, ReturnType = typeof(System.Threading.Tasks.ValueTask`1<System.Int32>))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionArgument)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 8)]
		[DeduplicatedMethod]
		 get { } //Length: 283
	}

	[CalledBy(Type = "System.IO.Stream+<<ReadAsync>g__FinishReadAsync|44_0>d", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(AsyncTaskMethodBuilder`1), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	public void AwaitUnsafeOnCompleted(ref TAwaiter awaiter, ref TStateMachine stateMachine) { }

	[CallerCount(Count = 7)]
	[DeduplicatedMethod]
	public static AsyncValueTaskMethodBuilder<TResult> Create() { }

	[CalledBy(Type = typeof(StreamReader), Member = "ReadAsyncInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Memory`1<System.Char>), typeof(CancellationToken)}, ReturnType = typeof(System.Threading.Tasks.ValueTask`1<System.Int32>))]
	[CalledBy(Type = typeof(Stream), Member = "ReadAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Memory`1<System.Byte>), typeof(CancellationToken)}, ReturnType = typeof(System.Threading.Tasks.ValueTask`1<System.Int32>))]
	[CalledBy(Type = typeof(Stream), Member = "<ReadAsync>g__FinishReadAsync|44_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Threading.Tasks.Task`1<System.Int32>), typeof(Byte[]), typeof(System.Memory`1<System.Byte>)}, ReturnType = typeof(System.Threading.Tasks.ValueTask`1<System.Int32>))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionArgument)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 8)]
	[DeduplicatedMethod]
	public ValueTask<TResult> get_Task() { }

	[CalledBy(Type = "System.IO.StreamReader+<ReadAsyncInternal>d__66", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "System.IO.Stream+<<ReadAsync>g__FinishReadAsync|44_0>d", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Int32>), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	public void SetException(Exception exception) { }

	[CalledBy(Type = "System.IO.StreamReader+<ReadAsyncInternal>d__66", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "System.IO.Stream+<<ReadAsync>g__FinishReadAsync|44_0>d", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Int32>), Member = "SetResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	public void SetResult(TResult result) { }

	[CalledBy(Type = "System.IO.StreamReader+<ReadAsyncInternal>d__66", Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.IO.Stream+<<ReadAsync>g__FinishReadAsync|44_0>d", Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(AsyncMethodBuilderCore), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	public void SetStateMachine(IAsyncStateMachine stateMachine) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Int32>), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"System.IO.Stream+<<ReadAsync>g__FinishReadAsync|44_0>d"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<<ReadAsync>g__FinishReadAsync|44_0>d&)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	public void Start(ref TStateMachine stateMachine) { }

}

