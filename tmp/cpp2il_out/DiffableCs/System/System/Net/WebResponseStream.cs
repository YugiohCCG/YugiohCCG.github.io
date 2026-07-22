namespace System.Net;

internal class WebResponseStream : WebConnectionStream
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass41_0
	{
		public WebResponseStream <>4__this; //Field offset: 0x10
		public Byte[] buffer; //Field offset: 0x18
		public int offset; //Field offset: 0x20
		public int size; //Field offset: 0x24

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c__DisplayClass41_0() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		internal Task<Int32> <ProcessRead>b__0(CancellationToken ct) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(WebOperation), Member = "Abort", ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		internal void <ProcessRead>b__1() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(WebOperation), Member = "get_Aborted", ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 1)]
		internal bool <ProcessRead>b__2() { }

	}

	[CompilerGenerated]
	private struct <InitReadAsync>d__52 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public WebResponseStream <>4__this; //Field offset: 0x20
		public CancellationToken cancellationToken; //Field offset: 0x28
		private BufferOffsetSize <buffer>5__2; //Field offset: 0x30
		private ReadState <state>5__3; //Field offset: 0x38
		private int <position>5__4; //Field offset: 0x3C
		private ConfiguredTaskAwaiter<Int32> <>u__1; //Field offset: 0x40

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(BufferOffsetSize), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(WebOperation), Member = "ThrowIfClosedOrDisposed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Task`1), Member = "ConfigureAwait", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = "System.Runtime.CompilerServices.ConfiguredTaskAwaitable`1<TResult>")]
		[Calls(Type = typeof(WebResponseStream), Member = "GetResponse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BufferOffsetSize), typeof(Int32&), typeof(ReadState&)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Buffer), Member = "BlockCopy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(BufferOffsetSize), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int), typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(WebResponseStream), Member = "Initialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BufferOffsetSize)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(WebResponseStream), Member = "GetReadException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WebExceptionStatus), typeof(Exception), typeof(string)}, ReturnType = typeof(WebException))]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 47)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ReadAllAsync>d__48 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public WebResponseStream <>4__this; //Field offset: 0x20
		public CancellationToken cancellationToken; //Field offset: 0x28
		public bool resending; //Field offset: 0x30
		private WebCompletionSource <completion>5__2; //Field offset: 0x38
		private CancellationTokenSource <timeoutCts>5__3; //Field offset: 0x40
		private Task <timeoutTask>5__4; //Field offset: 0x48
		private ConfiguredTaskAwaiter<Task> <>u__1; //Field offset: 0x50
		private ConfiguredTaskAwaiter<Byte[]> <>u__2; //Field offset: 0x60

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(WebException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(WebExceptionStatus)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(WebCompletionSource`1), Member = "TrySetCompleted", ReturnType = typeof(bool))]
		[Calls(Type = typeof(BufferOffsetSize), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int), typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(WebResponseStream), Member = "ReadAllAsyncInner", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = typeof(System.Threading.Tasks.Task`1<Byte[]>))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Task`1), Member = "ConfigureAwait", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = "System.Runtime.CompilerServices.ConfiguredTaskAwaitable`1<TResult>")]
		[Calls(Type = typeof(Task), Member = "WhenAny", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task[])}, ReturnType = typeof(System.Threading.Tasks.Task`1<System.Threading.Tasks.Task>))]
		[Calls(Type = typeof(CancellationTokenSource), Member = "Dispose", ReturnType = typeof(void))]
		[Calls(Type = typeof(CancellationTokenSource), Member = "Cancel", ReturnType = typeof(void))]
		[Calls(Type = typeof(CancellationToken), Member = "ThrowIfCancellationRequested", ReturnType = typeof(void))]
		[Calls(Type = typeof(Task), Member = "Delay", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(CancellationToken)}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(CancellationTokenSource), Member = "get_Token", ReturnType = typeof(CancellationToken))]
		[Calls(Type = typeof(WebOperation), Member = "Finish", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(Exception)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CancellationTokenSource), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(WebCompletionSource), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Net.WebCompletionSource`1<System.Object>), Member = "WaitForCompletion", ReturnType = typeof(System.Threading.Tasks.Task`1<System.Object>))]
		[CallsDeduplicatedMethods(Count = 7)]
		[CallsUnknownMethods(Count = 68)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ReadAllAsyncInner>d__47 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<Byte[]> <>t__builder; //Field offset: 0x8
		public CancellationToken cancellationToken; //Field offset: 0x20
		public WebResponseStream <>4__this; //Field offset: 0x28
		private long <maximumSize>5__2; //Field offset: 0x30
		private MemoryStream <ms>5__3; //Field offset: 0x38
		private Byte[] <buffer>5__4; //Field offset: 0x40
		private ConfiguredTaskAwaiter<Int32> <>u__1; //Field offset: 0x48

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(MemoryStream), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CancellationToken), Member = "ThrowIfCancellationRequested", ReturnType = typeof(void))]
		[Calls(Type = typeof(WebResponseStream), Member = "ProcessRead", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int), typeof(CancellationToken)}, ReturnType = typeof(System.Threading.Tasks.Task`1<System.Int32>))]
		[Calls(Type = typeof(Task`1), Member = "ConfigureAwait", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = "System.Runtime.CompilerServices.ConfiguredTaskAwaitable`1<TResult>")]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "SetResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder`1), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(IOException), Member = ".ctor", ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 5)]
		[CallsUnknownMethods(Count = 19)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder`1), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ReadAsync>d__40 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<Int32> <>t__builder; //Field offset: 0x8
		public CancellationToken cancellationToken; //Field offset: 0x20
		public Byte[] buffer; //Field offset: 0x28
		public int offset; //Field offset: 0x30
		public int count; //Field offset: 0x34
		public WebResponseStream <>4__this; //Field offset: 0x38
		private WebCompletionSource <completion>5__2; //Field offset: 0x40
		private int <nbytes>5__3; //Field offset: 0x48
		private Exception <throwMe>5__4; //Field offset: 0x50
		private ConfiguredTaskAwaiter<Object> <>u__1; //Field offset: 0x58
		private ConfiguredTaskAwaiter<Int32> <>u__2; //Field offset: 0x68

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Int32>), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Int32>), Member = "SetResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(WebOperation), Member = "Finish", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(Exception)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(WebCompletionSource`1), Member = "TrySetCompleted", ReturnType = typeof(bool))]
		[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(WebResponseStream), Member = "ProcessRead", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int), typeof(CancellationToken)}, ReturnType = typeof(System.Threading.Tasks.Task`1<System.Int32>))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder`1), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Task`1), Member = "ConfigureAwait", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = "System.Runtime.CompilerServices.ConfiguredTaskAwaitable`1<TResult>")]
		[Calls(Type = typeof(System.Net.WebCompletionSource`1<System.Object>), Member = "WaitForCompletion", ReturnType = typeof(System.Threading.Tasks.Task`1<System.Object>))]
		[Calls(Type = typeof(CancellationToken), Member = "get_IsCancellationRequested", ReturnType = typeof(bool))]
		[Calls(Type = typeof(WebCompletionSource), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(Interlocked), Member = "CompareExchange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&), typeof(int), typeof(int)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(CancellationToken), Member = "ThrowIfCancellationRequested", ReturnType = typeof(void))]
		[Calls(Type = typeof(WebResponseStream), Member = "GetReadException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WebExceptionStatus), typeof(Exception), typeof(string)}, ReturnType = typeof(WebException))]
		[CallsDeduplicatedMethods(Count = 6)]
		[CallsUnknownMethods(Count = 55)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder`1), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private WebReadStream innerStream; //Field offset: 0x58
	private bool nextReadCalled; //Field offset: 0x60
	private bool bufferedEntireContent; //Field offset: 0x61
	private WebCompletionSource pendingRead; //Field offset: 0x68
	private object locker; //Field offset: 0x70
	private int nestedRead; //Field offset: 0x78
	private bool read_eof; //Field offset: 0x7C
	[CompilerGenerated]
	private readonly WebRequestStream <RequestStream>k__BackingField; //Field offset: 0x80
	[CompilerGenerated]
	private WebHeaderCollection <Headers>k__BackingField; //Field offset: 0x88
	[CompilerGenerated]
	private HttpStatusCode <StatusCode>k__BackingField; //Field offset: 0x90
	[CompilerGenerated]
	private string <StatusDescription>k__BackingField; //Field offset: 0x98
	[CompilerGenerated]
	private Version <Version>k__BackingField; //Field offset: 0xA0
	[CompilerGenerated]
	private bool <KeepAlive>k__BackingField; //Field offset: 0xA8
	[CompilerGenerated]
	private bool <ChunkedRead>k__BackingField; //Field offset: 0xA9

	public virtual bool CanRead
	{
		[CallerCount(Count = 23)]
		[DeduplicatedMethod]
		 get { } //Length: 3
	}

	public virtual bool CanWrite
	{
		[CallerCount(Count = 271)]
		[DeduplicatedMethod]
		 get { } //Length: 3
	}

	private bool ChunkedRead
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private get { } //Length: 8
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private set { } //Length: 7
	}

	private bool ExpectContent
	{
		[CalledBy(Type = typeof(WebResponseStream), Member = "Initialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BufferOffsetSize)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		private get { } //Length: 151
	}

	public private WebHeaderCollection Headers
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 8
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private set { } //Length: 19
	}

	public private bool KeepAlive
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 8
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private set { } //Length: 7
	}

	public WebRequestStream RequestStream
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 8
	}

	public private HttpStatusCode StatusCode
	{
		[CallerCount(Count = 33)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 7
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private set { } //Length: 7
	}

	public private string StatusDescription
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 8
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private set { } //Length: 19
	}

	public private Version Version
	{
		[CallerCount(Count = 2)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 8
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private set { } //Length: 19
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(WebConnectionStream), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WebConnection), typeof(WebOperation)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public WebResponseStream(WebRequestStream request) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(WebOperation), Member = "Finish", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(Exception)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	protected virtual void Close_internal(ref bool disposed) { }

	[CallerCount(Count = 23)]
	[DeduplicatedMethod]
	public virtual bool get_CanRead() { }

	[CallerCount(Count = 271)]
	[DeduplicatedMethod]
	public virtual bool get_CanWrite() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private bool get_ChunkedRead() { }

	[CalledBy(Type = typeof(WebResponseStream), Member = "Initialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BufferOffsetSize)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private bool get_ExpectContent() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public WebHeaderCollection get_Headers() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public bool get_KeepAlive() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public WebRequestStream get_RequestStream() { }

	[CallerCount(Count = 33)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public HttpStatusCode get_StatusCode() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public string get_StatusDescription() { }

	[CallerCount(Count = 2)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public Version get_Version() { }

	[CalledBy(Type = typeof(<ReadAsync>d__40), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<InitReadAsync>d__52), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(WebResponseStream), Member = "GetResponse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BufferOffsetSize), typeof(Int32&), typeof(ReadState&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(WebConnectionStream), Member = "GetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(HttpWebRequest), Member = "get_Aborted", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CancellationTokenSource), Member = "get_IsCancellationRequested", ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(WebException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(WebExceptionStatus), typeof(WebExceptionInternalStatus), typeof(Exception)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(HttpWebRequest), Member = "CreateRequestAbortedException", ReturnType = typeof(WebException))]
	[Calls(Type = typeof(WebException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(WebExceptionStatus)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private WebException GetReadException(WebExceptionStatus status, Exception error, string where) { }

	[CalledBy(Type = typeof(<InitReadAsync>d__52), Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(WebResponseStream), Member = "GetReadException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WebExceptionStatus), typeof(Exception), typeof(string)}, ReturnType = typeof(WebException))]
	[Calls(Type = typeof(HttpWebRequest), Member = "DoContinueDelegate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(WebHeaderCollection)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(WebHeaderCollection), Member = "AddInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(WebHeaderCollection), Member = "SetInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(WebHeaderCollection), Member = "AllowMultiValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "Trim", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(WebHeaderCollection), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Join", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[]), typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(uint), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(uint))]
	[Calls(Type = typeof(string), Member = "Compare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(bool)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(string), Member = "Split", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(StringSplitOptions)}, ReturnType = typeof(String[]))]
	[Calls(Type = typeof(WebConnection), Member = "ReadLine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(Int32&), typeof(int), typeof(String&)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 27)]
	private bool GetResponse(BufferOffsetSize buffer, ref int pos, ref ReadState state) { }

	[CalledBy(Type = typeof(<InitReadAsync>d__52), Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "ToLower", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(StringComparison)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(long), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Int64&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(WebResponseStream), Member = "get_ExpectContent", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Version), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Version), typeof(Version)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(FixedSizeReadStream), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WebOperation), typeof(Stream), typeof(long)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(ArrayList), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(ContentDecodeStream), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WebOperation), typeof(Stream), typeof(Mode)}, ReturnType = typeof(ContentDecodeStream))]
	[Calls(Type = typeof(WebHeaderCollection), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HttpRequestHeader)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(WebOperation), Member = "Finish", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(Exception)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 12)]
	[CallsUnknownMethods(Count = 11)]
	[ContainsUnimplementedInstructions]
	private void Initialize(BufferOffsetSize buffer) { }

	[AsyncStateMachine(typeof(<InitReadAsync>d__52))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<InitReadAsync>d__52)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<InitReadAsync>d__52&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	internal Task InitReadAsync(CancellationToken cancellationToken) { }

	[CalledBy(Type = typeof(<ReadAsync>d__40), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<ReadAllAsyncInner>d__47), Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CancellationToken), Member = "get_IsCancellationRequested", ReturnType = typeof(bool))]
	[Calls(Type = typeof(HttpWebRequest), Member = "RunWithTimeout", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Func`2<CancellationToken, Task`1<T>>", typeof(int), typeof(Action), typeof(System.Func`1<System.Boolean>), typeof(CancellationToken)}, ReturnType = "System.Threading.Tasks.Task`1<T>")]
	[Calls(Type = typeof(Task), Member = "FromCanceled", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TResult"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = "System.Threading.Tasks.Task`1<TResult>")]
	[Calls(Type = typeof(Task), Member = "FromResult", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(System.Threading.Tasks.Task`1<System.Int32>))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 3)]
	private Task<Int32> ProcessRead(Byte[] buffer, int offset, int size, CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(<ReadAllAsync>d__48))]
	[CalledBy(Type = "System.Net.HttpWebRequest+<MyGetResponseAsync>d__243", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.HttpWebRequest+<GetResponseFromData>d__244", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<ReadAllAsync>d__48)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<ReadAllAsync>d__48&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	internal Task ReadAllAsync(bool resending, CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(<ReadAllAsyncInner>d__47))]
	[CalledBy(Type = typeof(<ReadAllAsync>d__48), Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<ReadAllAsyncInner>d__47)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<ReadAllAsyncInner>d__47&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "get_Task", ReturnType = typeof(System.Threading.Tasks.Task`1<System.Object>))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private Task<Byte[]> ReadAllAsyncInner(CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(<ReadAsync>d__40))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Int32>), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<ReadAsync>d__40)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<ReadAsync>d__40&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Int32>), Member = "get_Task", ReturnType = typeof(System.Threading.Tasks.Task`1<System.Int32>))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public virtual Task<Int32> ReadAsync(Byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void set_ChunkedRead(bool value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void set_Headers(WebHeaderCollection value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void set_KeepAlive(bool value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void set_StatusCode(HttpStatusCode value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void set_StatusDescription(string value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void set_Version(Version value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BufferedReadStream), Member = "TryReadFromBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int), typeof(Int32&)}, ReturnType = typeof(bool))]
	protected virtual bool TryReadFromBufferedContent(Byte[] buffer, int offset, int count, out int result) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Task), Member = "FromException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(Task))]
	public virtual Task WriteAsync(Byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

}

