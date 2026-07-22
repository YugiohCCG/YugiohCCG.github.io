namespace System.Threading.Tasks;

[AsyncMethodBuilder(typeof(AsyncValueTaskMethodBuilder`1))]
[IsReadOnly]
public struct ValueTask : IEquatable<ValueTask`1<TResult>>
{
	private sealed class ValueTaskSourceAsTask : Task<TResult>
	{
		[CompilerGenerated]
		private sealed class <>c
		{
			public static readonly <>c<TResult> <>9; //Field offset: 0x0

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
			[Calls(Type = typeof(Task`1), Member = "TrySetResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TResult"}, ReturnType = typeof(bool))]
			[Calls(Type = typeof(Task), Member = "TrySetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
			[Calls(Type = typeof(Task), Member = "TrySetCanceled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken), typeof(object)}, ReturnType = typeof(bool))]
			[Calls(Type = typeof(CancellationToken), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
			[Calls(Type = typeof(Task), Member = "TrySetCanceled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = typeof(bool))]
			[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentOutOfRangeException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionArgument)}, ReturnType = typeof(void))]
			[CallsUnknownMethods(Count = 7)]
			[DeduplicatedMethod]
			internal void <.cctor>b__4_0(object state) { }

		}

		private static readonly Action<Object> s_completionAction; //Field offset: 0x0
		private IValueTaskSource<TResult> _source; //Field offset: 0x0
		private readonly short _token; //Field offset: 0x0

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 10)]
		[DeduplicatedMethod]
		private static ValueTaskSourceAsTask() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(System.Threading.Tasks.Task`1<System.Int32>), Member = ".ctor", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 6)]
		[DeduplicatedMethod]
		public ValueTaskSourceAsTask(IValueTaskSource<TResult> source, short token) { }

	}

	private static Task<TResult> s_canceledTask; //Field offset: 0x0
	internal readonly object _obj; //Field offset: 0x0
	internal readonly TResult _result; //Field offset: 0x0
	internal readonly short _token; //Field offset: 0x0
	internal readonly bool _continueOnCapturedContext; //Field offset: 0x0

	public bool IsCompleted
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Task), Member = "get_IsCompleted", ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 5)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		 get { } //Length: 252
	}

	public bool IsCompletedSuccessfully
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Task), Member = "get_IsCompletedSuccessfully", ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 5)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		 get { } //Length: 253
	}

	public TResult Result
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(TaskAwaiter), Member = "ValidateEnd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 6)]
		[DeduplicatedMethod]
		 get { } //Length: 276
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public ValueTask`1(TResult result) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionArgument)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public ValueTask`1(Task<TResult> task) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionArgument)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public ValueTask`1(IValueTaskSource<TResult> source, short token) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	private ValueTask`1(object obj, TResult result, short token, bool continueOnCapturedContext) { }

	[CalledBy(Type = typeof(StreamReader), Member = "ReadAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(System.Threading.Tasks.Task`1<System.Int32>))]
	[CalledBy(Type = typeof(TextReader), Member = "ReadAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(System.Threading.Tasks.Task`1<System.Int32>))]
	[CalledBy(Type = "System.Net.Sockets.NetworkStream", Member = "ReadAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Byte[]", typeof(int), typeof(int), typeof(CancellationToken)}, ReturnType = "System.Threading.Tasks.Task`1<Int32>")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(ValueTask`1), Member = "GetTaskForValueTaskSource", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Threading.Tasks.Sources.IValueTaskSource`1<TResult>"}, ReturnType = "System.Threading.Tasks.Task`1<TResult>")]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Int32>), Member = "GetTaskForResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(System.Threading.Tasks.Task`1<System.Int32>))]
	[CallsUnknownMethods(Count = 6)]
	[DeduplicatedMethod]
	public Task<TResult> AsTask() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 4)]
	[DeduplicatedMethod]
	public ConfiguredValueTaskAwaitable<TResult> ConfigureAwait(bool continueOnCapturedContext) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 9)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public virtual bool Equals(object obj) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public override bool Equals(ValueTask<TResult> other) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Task), Member = "get_IsCompleted", ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 5)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public bool get_IsCompleted() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Task), Member = "get_IsCompletedSuccessfully", ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 5)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public bool get_IsCompletedSuccessfully() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TaskAwaiter), Member = "ValidateEnd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 6)]
	[DeduplicatedMethod]
	public TResult get_Result() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public ValueTaskAwaiter<TResult> GetAwaiter() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public virtual int GetHashCode() { }

	[CalledBy(Type = typeof(ValueTask`1), Member = "AsTask", ReturnType = "System.Threading.Tasks.Task`1<TResult>")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.Threading.Tasks.Task`1<System.Int32>), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Int32>), Member = "GetTaskForResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(System.Threading.Tasks.Task`1<System.Int32>))]
	[Calls(Type = typeof(Task), Member = "FromException", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TResult"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = "System.Threading.Tasks.Task`1<TResult>")]
	[Calls(Type = typeof(CancellationToken), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Task), Member = "FromCanceled", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TResult"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = "System.Threading.Tasks.Task`1<TResult>")]
	[Calls(Type = typeof(Task), Member = "TrySetCanceled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken), typeof(object)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 33)]
	[DeduplicatedMethod]
	private Task<TResult> GetTaskForValueTaskSource(IValueTaskSource<TResult> t) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 5)]
	[DeduplicatedMethod]
	public virtual string ToString() { }

}

