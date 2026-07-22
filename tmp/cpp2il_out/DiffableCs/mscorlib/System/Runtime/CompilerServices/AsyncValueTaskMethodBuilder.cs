namespace System.Runtime.CompilerServices;

public struct AsyncValueTaskMethodBuilder
{
	private AsyncTaskMethodBuilder _methodBuilder; //Field offset: 0x0
	private bool _haveResult; //Field offset: 0x18
	private bool _useBuilder; //Field offset: 0x19

	public ValueTask Task
	{
		[CalledBy(Type = "K4os.Compression.LZ4.Streams.LZ4DecoderStream", Member = "DisposeAsync", ReturnType = typeof(ValueTask))]
		[CalledBy(Type = "K4os.Compression.LZ4.Streams.LZ4EncoderStream", Member = "DisposeAsync", ReturnType = typeof(ValueTask))]
		[CalledBy(Type = typeof(StreamWriter), Member = "DisposeAsync", ReturnType = typeof(ValueTask))]
		[CalledBy(Type = typeof(StreamWriter), Member = "DisposeAsyncCore", ReturnType = typeof(ValueTask))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Threading.Tasks.VoidTaskResult>), Member = "get_Task", ReturnType = typeof(System.Threading.Tasks.Task`1<System.Threading.Tasks.VoidTaskResult>))]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionArgument)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 255
	}

	[CalledBy(Type = "K4os.Compression.LZ4.Streams.LZ4DecoderStream+<DisposeAsync>d__44", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "K4os.Compression.LZ4.Streams.LZ4EncoderStream+<DisposeAsync>d__31", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public void AwaitUnsafeOnCompleted(ref TAwaiter awaiter, ref TStateMachine stateMachine) { }

	[CallerCount(Count = 7)]
	[DeduplicatedMethod]
	public static AsyncValueTaskMethodBuilder Create() { }

	[CalledBy(Type = "K4os.Compression.LZ4.Streams.LZ4DecoderStream", Member = "DisposeAsync", ReturnType = typeof(ValueTask))]
	[CalledBy(Type = "K4os.Compression.LZ4.Streams.LZ4EncoderStream", Member = "DisposeAsync", ReturnType = typeof(ValueTask))]
	[CalledBy(Type = typeof(StreamWriter), Member = "DisposeAsync", ReturnType = typeof(ValueTask))]
	[CalledBy(Type = typeof(StreamWriter), Member = "DisposeAsyncCore", ReturnType = typeof(ValueTask))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Threading.Tasks.VoidTaskResult>), Member = "get_Task", ReturnType = typeof(System.Threading.Tasks.Task`1<System.Threading.Tasks.VoidTaskResult>))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionArgument)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public ValueTask get_Task() { }

	[CalledBy(Type = "K4os.Compression.LZ4.Streams.LZ4DecoderStream+<DisposeAsync>d__44", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "K4os.Compression.LZ4.Streams.LZ4EncoderStream+<DisposeAsync>d__31", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "System.IO.StreamWriter+<DisposeAsyncCore>d__33", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Threading.Tasks.VoidTaskResult>), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
	public void SetException(Exception exception) { }

	[CalledBy(Type = "K4os.Compression.LZ4.Streams.LZ4DecoderStream+<DisposeAsync>d__44", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "K4os.Compression.LZ4.Streams.LZ4EncoderStream+<DisposeAsync>d__31", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "System.IO.StreamWriter+<DisposeAsyncCore>d__33", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
	public void SetResult() { }

	[CalledBy(Type = "K4os.Compression.LZ4.Streams.LZ4DecoderStream+<DisposeAsync>d__44", Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
	[CalledBy(Type = "K4os.Compression.LZ4.Streams.LZ4EncoderStream+<DisposeAsync>d__31", Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.IO.StreamWriter+<DisposeAsyncCore>d__33", Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(AsyncTaskMethodBuilder`1), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
	public void SetStateMachine(IAsyncStateMachine stateMachine) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public void Start(ref TStateMachine stateMachine) { }

}

