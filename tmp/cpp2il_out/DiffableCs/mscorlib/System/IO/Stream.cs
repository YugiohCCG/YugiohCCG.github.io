namespace System.IO;

public abstract class Stream : MarshalByRefObject, IDisposable, IAsyncDisposable
{
	[CompilerGenerated]
	private struct <<ReadAsync>g__FinishReadAsync|44_0>d : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncValueTaskMethodBuilder<Int32> <>t__builder; //Field offset: 0x8
		public Task<Int32> readTask; //Field offset: 0x28
		public Byte[] localBuffer; //Field offset: 0x30
		public Memory<Byte> localDestination; //Field offset: 0x38
		private ConfiguredTaskAwaiter<Int32> <>u__1; //Field offset: 0x48

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Task`1), Member = "ConfigureAwait", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = "System.Runtime.CompilerServices.ConfiguredTaskAwaitable`1<TResult>")]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
		[Calls(Type = typeof(Memory`1), Member = "get_Span", ReturnType = "System.Span`1<T>")]
		[Calls(Type = typeof(Span`1), Member = "CopyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Span`1<T>"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncValueTaskMethodBuilder`1), Member = "SetResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TResult"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncValueTaskMethodBuilder`1), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncValueTaskMethodBuilder`1), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 7)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncValueTaskMethodBuilder`1), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<SemaphoreSlim> <>9__4_0; //Field offset: 0x8
		public static Action<Object> <>9__37_0; //Field offset: 0x10
		public static Func<Object, Int32> <>9__40_0; //Field offset: 0x18
		public static Func<Stream, ReadWriteParameters, AsyncCallback, Object, IAsyncResult> <>9__45_0; //Field offset: 0x20
		public static Func<Stream, IAsyncResult, Int32> <>9__45_1; //Field offset: 0x28
		public static Func<Object, Int32> <>9__48_0; //Field offset: 0x30
		public static Action<Task, Object> <>9__49_0; //Field offset: 0x38
		public static Func<Stream, ReadWriteParameters, AsyncCallback, Object, IAsyncResult> <>9__58_0; //Field offset: 0x40
		public static Func<Stream, IAsyncResult, VoidTaskResult> <>9__58_1; //Field offset: 0x48

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		private static <>c() { }

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		internal IAsyncResult <BeginEndReadAsync>b__45_0(Stream stream, ReadWriteParameters args, AsyncCallback callback, object state) { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		internal int <BeginEndReadAsync>b__45_1(Stream stream, IAsyncResult asyncResult) { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		internal IAsyncResult <BeginEndWriteAsync>b__58_0(Stream stream, ReadWriteParameters args, AsyncCallback callback, object state) { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		internal VoidTaskResult <BeginEndWriteAsync>b__58_1(Stream stream, IAsyncResult asyncResult) { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 6)]
		internal int <BeginReadInternal>b__40_0(object <p0>) { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 6)]
		internal int <BeginWriteInternal>b__48_0(object <p0>) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SemaphoreSlim), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
		internal SemaphoreSlim <EnsureAsyncActiveSemaphoreInitialized>b__4_0() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		internal void <FlushAsync>b__37_0(object state) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Stream), Member = "RunReadWriteTask", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.IO.Stream+ReadWriteTask"}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 2)]
		internal void <RunReadWriteTaskWhenReady>b__49_0(Task t, object state) { }

	}

	[CompilerGenerated]
	private struct <CopyToAsyncInternal>d__28 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public int bufferSize; //Field offset: 0x20
		public Stream <>4__this; //Field offset: 0x28
		public CancellationToken cancellationToken; //Field offset: 0x30
		public Stream destination; //Field offset: 0x38
		private Byte[] <buffer>5__2; //Field offset: 0x40
		private ConfiguredValueTaskAwaiter<Int32> <>u__1; //Field offset: 0x48
		private ConfiguredValueTaskAwaiter <>u__2; //Field offset: 0x58

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(TaskAwaiter), Member = "ValidateEnd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ConfiguredValueTaskAwaiter), typeof(<CopyToAsyncInternal>d__28)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ConfiguredValueTaskAwaiter&), typeof(<CopyToAsyncInternal>d__28&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Runtime.CompilerServices.ConfiguredValueTaskAwaitable`1+ConfiguredValueTaskAwaiter<System.Int32>), typeof(<CopyToAsyncInternal>d__28)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ConfiguredValueTaskAwaiter<Int32>&), typeof(<CopyToAsyncInternal>d__28&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 36)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <FinishWriteAsync>d__57 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public Task writeTask; //Field offset: 0x20
		public Byte[] localBuffer; //Field offset: 0x28
		private ConfiguredTaskAwaiter <>u__1; //Field offset: 0x30

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Task), Member = "ConfigureAwait", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(ConfiguredTaskAwaitable))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 7)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private sealed class NullStream : Stream
	{
		private static readonly Task<Int32> s_zeroTask; //Field offset: 0x0

		public virtual bool CanRead
		{
			[CallerCount(Count = 23)]
			[DeduplicatedMethod]
			 get { } //Length: 3
		}

		public virtual bool CanSeek
		{
			[CallerCount(Count = 23)]
			[DeduplicatedMethod]
			 get { } //Length: 3
		}

		public virtual bool CanWrite
		{
			[CallerCount(Count = 23)]
			[DeduplicatedMethod]
			 get { } //Length: 3
		}

		public virtual long Length
		{
			[CallerCount(Count = 182)]
			[DeduplicatedMethod]
			 get { } //Length: 3
		}

		public virtual long Position
		{
			[CallerCount(Count = 182)]
			[DeduplicatedMethod]
			 get { } //Length: 3
			[CallerCount(Count = 13327)]
			[DeduplicatedMethod]
			 set { } //Length: 3
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Task), Member = "FromResult", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(System.Threading.Tasks.Task`1<System.Int32>))]
		[CallsUnknownMethods(Count = 1)]
		private static NullStream() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		internal NullStream() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Stream), Member = "BlockingBeginRead", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int), typeof(AsyncCallback), typeof(object)}, ReturnType = typeof(IAsyncResult))]
		[Calls(Type = typeof(Error), Member = "GetReadNotSupported", ReturnType = typeof(Exception))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		public virtual IAsyncResult BeginRead(Byte[] buffer, int offset, int count, AsyncCallback callback, object state) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Stream), Member = "BlockingBeginWrite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int), typeof(AsyncCallback), typeof(object)}, ReturnType = typeof(IAsyncResult))]
		[Calls(Type = typeof(Error), Member = "GetWriteNotSupported", ReturnType = typeof(Exception))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		public virtual IAsyncResult BeginWrite(Byte[] buffer, int offset, int count, AsyncCallback callback, object state) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(StreamHelpers), Member = "ValidateCopyToArgs", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(Stream), typeof(int)}, ReturnType = typeof(void))]
		public virtual void CopyTo(Stream destination, int bufferSize) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(StreamHelpers), Member = "ValidateCopyToArgs", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(Stream), typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CancellationToken), Member = "get_IsCancellationRequested", ReturnType = typeof(bool))]
		[Calls(Type = typeof(Task), Member = "FromCanceled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = typeof(Task))]
		public virtual Task CopyToAsync(Stream destination, int bufferSize, CancellationToken cancellationToken) { }

		[CallerCount(Count = 13327)]
		[DeduplicatedMethod]
		protected virtual void Dispose(bool disposing) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ExceptionDispatchInfo), Member = "Throw", ReturnType = typeof(void))]
		[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 12)]
		public virtual int EndRead(IAsyncResult asyncResult) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ExceptionDispatchInfo), Member = "Throw", ReturnType = typeof(void))]
		[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 12)]
		public virtual void EndWrite(IAsyncResult asyncResult) { }

		[CallerCount(Count = 13327)]
		[DeduplicatedMethod]
		public virtual void Flush() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CancellationToken), Member = "get_IsCancellationRequested", ReturnType = typeof(bool))]
		[Calls(Type = typeof(Task), Member = "FromCanceled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = typeof(Task))]
		public virtual Task FlushAsync(CancellationToken cancellationToken) { }

		[CallerCount(Count = 23)]
		[DeduplicatedMethod]
		public virtual bool get_CanRead() { }

		[CallerCount(Count = 23)]
		[DeduplicatedMethod]
		public virtual bool get_CanSeek() { }

		[CallerCount(Count = 23)]
		[DeduplicatedMethod]
		public virtual bool get_CanWrite() { }

		[CallerCount(Count = 182)]
		[DeduplicatedMethod]
		public virtual long get_Length() { }

		[CallerCount(Count = 182)]
		[DeduplicatedMethod]
		public virtual long get_Position() { }

		[CallerCount(Count = 182)]
		[DeduplicatedMethod]
		public virtual int Read(Byte[] buffer, int offset, int count) { }

		[CallerCount(Count = 182)]
		[DeduplicatedMethod]
		public virtual int Read(Span<Byte> buffer) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		public virtual ValueTask<Int32> ReadAsync(Memory<Byte> buffer, CancellationToken cancellationToken = null) { }

		[CallerCount(Count = 0)]
		public virtual Task<Int32> ReadAsync(Byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		public virtual int ReadByte() { }

		[CallerCount(Count = 182)]
		[DeduplicatedMethod]
		public virtual long Seek(long offset, SeekOrigin origin) { }

		[CallerCount(Count = 13327)]
		[DeduplicatedMethod]
		public virtual void set_Position(long value) { }

		[CallerCount(Count = 13327)]
		[DeduplicatedMethod]
		public virtual void SetLength(long length) { }

		[CallerCount(Count = 13327)]
		[DeduplicatedMethod]
		public virtual void Write(Byte[] buffer, int offset, int count) { }

		[CallerCount(Count = 13327)]
		[DeduplicatedMethod]
		public virtual void Write(ReadOnlySpan<Byte> buffer) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CancellationToken), Member = "get_IsCancellationRequested", ReturnType = typeof(bool))]
		[Calls(Type = typeof(Task), Member = "FromCanceled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = typeof(Task))]
		public virtual Task WriteAsync(Byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CancellationToken), Member = "get_IsCancellationRequested", ReturnType = typeof(bool))]
		[Calls(Type = typeof(Task), Member = "FromCanceled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionArgument)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		public virtual ValueTask WriteAsync(ReadOnlyMemory<Byte> buffer, CancellationToken cancellationToken = null) { }

		[CallerCount(Count = 13327)]
		[DeduplicatedMethod]
		public virtual void WriteByte(byte value) { }

	}

	private struct ReadWriteParameters
	{
		internal Byte[] Buffer; //Field offset: 0x0
		internal int Offset; //Field offset: 0x8
		internal int Count; //Field offset: 0xC

	}

	private sealed class ReadWriteTask : Task<Int32>, ITaskCompletionAction
	{
		private static ContextCallback s_invokeAsyncCallback; //Field offset: 0x0
		internal readonly bool _isRead; //Field offset: 0x58
		internal readonly bool _apm; //Field offset: 0x59
		internal Stream _stream; //Field offset: 0x60
		internal Byte[] _buffer; //Field offset: 0x68
		internal readonly int _offset; //Field offset: 0x70
		internal readonly int _count; //Field offset: 0x74
		private AsyncCallback _callback; //Field offset: 0x78
		private ExecutionContext _context; //Field offset: 0x80

		private override bool System.Threading.Tasks.ITaskCompletionAction.InvokeMayRunArbitraryCode
		{
			[CallerCount(Count = 23)]
			[DeduplicatedMethod]
			private get { } //Length: 3
		}

		[CalledBy(Type = typeof(Stream), Member = "BeginReadInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int), typeof(AsyncCallback), typeof(object), typeof(bool), typeof(bool)}, ReturnType = typeof(IAsyncResult))]
		[CalledBy(Type = typeof(Stream), Member = "BeginWriteInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int), typeof(AsyncCallback), typeof(object), typeof(bool), typeof(bool)}, ReturnType = typeof(IAsyncResult))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(System.Threading.Tasks.Task`1<System.Int32>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Func`2<System.Object, System.Int32>), typeof(object), typeof(CancellationToken), typeof(TaskCreationOptions)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ExecutionContext), Member = "Capture", ReturnType = typeof(ExecutionContext))]
		[Calls(Type = typeof(Task), Member = "AddCompletionAction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ITaskCompletionAction)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 4)]
		public ReadWriteTask(bool isRead, bool apm, Func<Object, Int32> function, object state, Stream stream, Byte[] buffer, int offset, int count, AsyncCallback callback) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		internal void ClearBeginState() { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 4)]
		private static void InvokeAsyncCallback(object completedTask) { }

		[CallerCount(Count = 23)]
		[DeduplicatedMethod]
		private override bool System.Threading.Tasks.ITaskCompletionAction.get_InvokeMayRunArbitraryCode() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ExecutionContext), Member = "RunInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExecutionContext), typeof(ContextCallback), typeof(object)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 4)]
		private override void System.Threading.Tasks.ITaskCompletionAction.Invoke(Task completingTask) { }

	}

	private sealed class SynchronousAsyncResult : IAsyncResult
	{
		[CompilerGenerated]
		private sealed class <>c
		{
			public static readonly <>c <>9; //Field offset: 0x0
			public static Func<ManualResetEvent> <>9__12_0; //Field offset: 0x8

			[CallerCount(Count = 0)]
			[CallsDeduplicatedMethods(Count = 1)]
			[CallsUnknownMethods(Count = 1)]
			private static <>c() { }

			[CallerCount(Count = 2180)]
			[CallsDeduplicatedMethods(Count = 1)]
			[DeduplicatedMethod]
			public <>c() { }

			[CallerCount(Count = 0)]
			[Calls(Type = typeof(ManualResetEvent), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
			internal ManualResetEvent <get_AsyncWaitHandle>b__12_0() { }

		}

		private readonly object _stateObject; //Field offset: 0x10
		private readonly bool _isWrite; //Field offset: 0x18
		private ManualResetEvent _waitHandle; //Field offset: 0x20
		private ExceptionDispatchInfo _exceptionInfo; //Field offset: 0x28
		private bool _endXxxCalled; //Field offset: 0x30
		private int _bytesRead; //Field offset: 0x34

		public override object AsyncState
		{
			[CallerCount(Count = 106)]
			[DeduplicatedMethod]
			 get { } //Length: 5
		}

		public override WaitHandle AsyncWaitHandle
		{
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(LazyInitializer), Member = "EnsureInitialized", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", "System.Func`1<T>"}, ReturnType = "T")]
			[CallsDeduplicatedMethods(Count = 1)]
			[CallsUnknownMethods(Count = 1)]
			 get { } //Length: 273
		}

		public override bool CompletedSynchronously
		{
			[CallerCount(Count = 23)]
			[DeduplicatedMethod]
			 get { } //Length: 3
		}

		public override bool IsCompleted
		{
			[CallerCount(Count = 23)]
			[DeduplicatedMethod]
			 get { } //Length: 3
		}

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		internal SynchronousAsyncResult(int bytesRead, object asyncStateObject) { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		internal SynchronousAsyncResult(object asyncStateObject) { }

		[CalledBy(Type = typeof(Stream), Member = "BlockingBeginRead", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int), typeof(AsyncCallback), typeof(object)}, ReturnType = typeof(IAsyncResult))]
		[CalledBy(Type = typeof(Stream), Member = "BlockingBeginWrite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int), typeof(AsyncCallback), typeof(object)}, ReturnType = typeof(IAsyncResult))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(ExceptionDispatchInfo), Member = "Capture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(ExceptionDispatchInfo))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		internal SynchronousAsyncResult(Exception ex, object asyncStateObject, bool isWrite) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ExceptionDispatchInfo), Member = "Throw", ReturnType = typeof(void))]
		[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 8)]
		[DeduplicatedMethod]
		internal static int EndRead(IAsyncResult asyncResult) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ExceptionDispatchInfo), Member = "Throw", ReturnType = typeof(void))]
		[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 8)]
		[DeduplicatedMethod]
		internal static void EndWrite(IAsyncResult asyncResult) { }

		[CallerCount(Count = 106)]
		[DeduplicatedMethod]
		public override object get_AsyncState() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(LazyInitializer), Member = "EnsureInitialized", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", "System.Func`1<T>"}, ReturnType = "T")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		public override WaitHandle get_AsyncWaitHandle() { }

		[CallerCount(Count = 23)]
		[DeduplicatedMethod]
		public override bool get_CompletedSynchronously() { }

		[CallerCount(Count = 23)]
		[DeduplicatedMethod]
		public override bool get_IsCompleted() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ExceptionDispatchInfo), Member = "Throw", ReturnType = typeof(void))]
		internal void ThrowIfError() { }

	}

	public static readonly Stream Null; //Field offset: 0x0
	private ReadWriteTask _activeReadWriteTask; //Field offset: 0x18
	private SemaphoreSlim _asyncActiveSemaphore; //Field offset: 0x20

	public abstract bool CanRead
	{
		 get { } //Length: 0
	}

	public abstract bool CanSeek
	{
		 get { } //Length: 0
	}

	public override bool CanTimeout
	{
		[CallerCount(Count = 271)]
		[DeduplicatedMethod]
		 get { } //Length: 3
	}

	public abstract bool CanWrite
	{
		 get { } //Length: 0
	}

	public abstract long Length
	{
		 get { } //Length: 0
	}

	public abstract long Position
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public override int ReadTimeout
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 4)]
		 get { } //Length: 78
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 4)]
		 set { } //Length: 78
	}

	public override int WriteTimeout
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 4)]
		 get { } //Length: 78
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 4)]
		 set { } //Length: 78
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private static Stream() { }

	[CallerCount(Count = 2180)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	protected Stream() { }

	[AsyncStateMachine(typeof(<<ReadAsync>g__FinishReadAsync|44_0>d))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Int32>), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<<ReadAsync>g__FinishReadAsync|44_0>d)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<<ReadAsync>g__FinishReadAsync|44_0>d&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncValueTaskMethodBuilder`1), Member = "get_Task", ReturnType = "System.Threading.Tasks.ValueTask`1<TResult>")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	[CompilerGenerated]
	internal static ValueTask<Int32> <ReadAsync>g__FinishReadAsync|44_0(Task<Int32> readTask, Byte[] localBuffer, Memory<Byte> localDestination) { }

	[CalledBy(Type = typeof(Stream), Member = "ReadAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int), typeof(CancellationToken)}, ReturnType = typeof(System.Threading.Tasks.Task`1<System.Int32>))]
	[CalledBy(Type = typeof(FileStream), Member = "ReadAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int), typeof(CancellationToken)}, ReturnType = typeof(System.Threading.Tasks.Task`1<System.Int32>))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(System.Func`5<System.Object, System.IO.Stream+ReadWriteParameters, System.Object, System.Object, System.Object>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TaskFactory`1), Member = "FromAsyncTrim", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TInstance", "TArgs"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TInstance", "TArgs", "System.Func`5<TInstance, TArgs, AsyncCallback, Object, IAsyncResult>", "System.Func`3<TInstance, IAsyncResult, TResult>"}, ReturnType = "System.Threading.Tasks.Task`1<TResult>")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private Task<Int32> BeginEndReadAsync(Byte[] buffer, int offset, int count) { }

	[CalledBy(Type = typeof(Stream), Member = "WriteAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CalledBy(Type = typeof(FileStream), Member = "WriteAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(System.Func`5<System.Object, System.IO.Stream+ReadWriteParameters, System.Object, System.Object, System.Object>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Threading.Tasks.TaskFactory`1<System.Threading.Tasks.VoidTaskResult>), Member = "FromAsyncTrim", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(ReadWriteParameters)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(ReadWriteParameters), typeof(System.Func`5<System.Object, System.IO.Stream+ReadWriteParameters, System.AsyncCallback, System.Object, System.IAsyncResult>), typeof(System.Func`3<System.Object, System.IAsyncResult, System.Threading.Tasks.VoidTaskResult>)}, ReturnType = typeof(System.Threading.Tasks.Task`1<System.Threading.Tasks.VoidTaskResult>))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private Task BeginEndWriteAsync(Byte[] buffer, int offset, int count) { }

	[CalledBy(Type = "NGettext.Loaders.ReadOnlyStreamWrapper", Member = "BeginRead", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Byte[]", typeof(int), typeof(int), typeof(AsyncCallback), typeof(object)}, ReturnType = typeof(IAsyncResult))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Stream), Member = "BeginReadInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int), typeof(AsyncCallback), typeof(object), typeof(bool), typeof(bool)}, ReturnType = typeof(IAsyncResult))]
	public override IAsyncResult BeginRead(Byte[] buffer, int offset, int count, AsyncCallback callback, object state) { }

	[CalledBy(Type = typeof(Stream), Member = "BeginRead", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int), typeof(AsyncCallback), typeof(object)}, ReturnType = typeof(IAsyncResult))]
	[CalledBy(Type = typeof(FileStream), Member = "BeginRead", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int), typeof(AsyncCallback), typeof(object)}, ReturnType = typeof(IAsyncResult))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Stream), Member = "EnsureAsyncActiveSemaphoreInitialized", ReturnType = typeof(SemaphoreSlim))]
	[Calls(Type = typeof(SemaphoreSlim), Member = "Wait", ReturnType = typeof(void))]
	[Calls(Type = typeof(SemaphoreSlim), Member = "WaitAsync", ReturnType = typeof(Task))]
	[Calls(Type = typeof(ReadWriteTask), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool), typeof(System.Func`2<System.Object, System.Int32>), typeof(object), typeof(Stream), typeof(Byte[]), typeof(int), typeof(int), typeof(AsyncCallback)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Stream), Member = "RunReadWriteTask", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ReadWriteTask)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Stream), Member = "RunReadWriteTaskWhenReady", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task), typeof(ReadWriteTask)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Error), Member = "GetReadNotSupported", ReturnType = typeof(Exception))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	internal IAsyncResult BeginReadInternal(Byte[] buffer, int offset, int count, AsyncCallback callback, object state, bool serializeAsynchronously, bool apm) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Stream), Member = "BeginWriteInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int), typeof(AsyncCallback), typeof(object), typeof(bool), typeof(bool)}, ReturnType = typeof(IAsyncResult))]
	public override IAsyncResult BeginWrite(Byte[] buffer, int offset, int count, AsyncCallback callback, object state) { }

	[CalledBy(Type = typeof(Stream), Member = "BeginWrite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int), typeof(AsyncCallback), typeof(object)}, ReturnType = typeof(IAsyncResult))]
	[CalledBy(Type = typeof(FileStream), Member = "BeginWrite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int), typeof(AsyncCallback), typeof(object)}, ReturnType = typeof(IAsyncResult))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Stream), Member = "EnsureAsyncActiveSemaphoreInitialized", ReturnType = typeof(SemaphoreSlim))]
	[Calls(Type = typeof(SemaphoreSlim), Member = "Wait", ReturnType = typeof(void))]
	[Calls(Type = typeof(SemaphoreSlim), Member = "WaitAsync", ReturnType = typeof(Task))]
	[Calls(Type = typeof(ReadWriteTask), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool), typeof(System.Func`2<System.Object, System.Int32>), typeof(object), typeof(Stream), typeof(Byte[]), typeof(int), typeof(int), typeof(AsyncCallback)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Stream), Member = "RunReadWriteTask", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ReadWriteTask)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Stream), Member = "RunReadWriteTaskWhenReady", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task), typeof(ReadWriteTask)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Error), Member = "GetWriteNotSupported", ReturnType = typeof(Exception))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	internal IAsyncResult BeginWriteInternal(Byte[] buffer, int offset, int count, AsyncCallback callback, object state, bool serializeAsynchronously, bool apm) { }

	[CalledBy(Type = typeof(NullStream), Member = "BeginRead", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int), typeof(AsyncCallback), typeof(object)}, ReturnType = typeof(IAsyncResult))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SynchronousAsyncResult), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception), typeof(object), typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	internal IAsyncResult BlockingBeginRead(Byte[] buffer, int offset, int count, AsyncCallback callback, object state) { }

	[CalledBy(Type = typeof(NullStream), Member = "BeginWrite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int), typeof(AsyncCallback), typeof(object)}, ReturnType = typeof(IAsyncResult))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SynchronousAsyncResult), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception), typeof(object), typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	internal IAsyncResult BlockingBeginWrite(Byte[] buffer, int offset, int count, AsyncCallback callback, object state) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ExceptionDispatchInfo), Member = "Throw", ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 8)]
	[DeduplicatedMethod]
	internal static int BlockingEndRead(IAsyncResult asyncResult) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ExceptionDispatchInfo), Member = "Throw", ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 8)]
	[DeduplicatedMethod]
	internal static void BlockingEndWrite(IAsyncResult asyncResult) { }

	[CalledBy(Type = "System.Net.TlsStream", Member = "Close", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GC), Member = "SuppressFinalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	public override void Close() { }

	[CalledBy(Type = typeof(MemoryStream), Member = "CopyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(StreamHelpers), Member = "ValidateCopyToArgs", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(Stream), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 8)]
	public override void CopyTo(Stream destination, int bufferSize) { }

	[CalledBy(Type = "Data.PackedBinaryData", Member = "DecompressDataSync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Byte[]"}, ReturnType = "System.Byte[]")]
	[CalledBy(Type = "System.IO.Compression.ZipArchive", Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), "System.IO.Compression.ZipArchiveMode", typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.IO.Compression.ZipArchiveEntry", Member = "get_UncompressedData", ReturnType = typeof(MemoryStream))]
	[CalledBy(Type = "System.IO.Compression.ZipArchiveEntry", Member = "WriteLocalFileHeaderAndDataIfNeeded", ReturnType = typeof(void))]
	[CalledBy(Type = "System.IO.Compression.ZipFileExtensions", Member = "DoCreateEntryFromFile", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.IO.Compression.ZipArchive", typeof(string), typeof(string), "System.Nullable`1<CompressionLevel>"}, ReturnType = "System.IO.Compression.ZipArchiveEntry")]
	[CalledBy(Type = "System.IO.Compression.ZipFileExtensions", Member = "ExtractToFile", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.IO.Compression.ZipArchiveEntry", typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(Stream), Member = "GetCopyBufferSize", ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 1)]
	public void CopyTo(Stream destination) { }

	[CalledBy(Type = "Data.PackedBinaryData+<DecompressData>d__4", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Data.PackedBinaryData+<LZ4Unpack>d__2", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Data.PackedBinaryData+<LZ4Unpack>d__3", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Stream), Member = "GetCopyBufferSize", ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 2)]
	public Task CopyToAsync(Stream destination) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public Task CopyToAsync(Stream destination, int bufferSize) { }

	[CalledBy(Type = typeof(MemoryStream), Member = "CopyToAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(int), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(StreamHelpers), Member = "ValidateCopyToArgs", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(Stream), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<CopyToAsyncInternal>d__28)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<CopyToAsyncInternal>d__28&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public override Task CopyToAsync(Stream destination, int bufferSize, CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(<CopyToAsyncInternal>d__28))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<CopyToAsyncInternal>d__28)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<CopyToAsyncInternal>d__28&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	private Task CopyToAsyncInternal(Stream destination, int bufferSize, CancellationToken cancellationToken) { }

	[CallerCount(Count = 40)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public override void Dispose() { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	protected override void Dispose(bool disposing) { }

	[CalledBy(Type = "K4os.Compression.LZ4.Streams.LZ4DecoderStream+<DisposeAsync>d__44", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "K4os.Compression.LZ4.Streams.LZ4DecoderStream", Member = "<>n__0", ReturnType = typeof(ValueTask))]
	[CalledBy(Type = "K4os.Compression.LZ4.Streams.LZ4EncoderStream+<DisposeAsync>d__31", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "K4os.Compression.LZ4.Streams.LZ4EncoderStream", Member = "<>n__0", ReturnType = typeof(ValueTask))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Task), Member = "FromException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(Task))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionArgument)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public override ValueTask DisposeAsync() { }

	[CalledBy(Type = typeof(FileStream), Member = "EndRead", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncResult)}, ReturnType = typeof(int))]
	[CalledBy(Type = "NGettext.Loaders.ReadOnlyStreamWrapper", Member = "EndRead", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncResult)}, ReturnType = typeof(int))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Task`1), Member = "GetAwaiter", ReturnType = "System.Runtime.CompilerServices.TaskAwaiter`1<TResult>")]
	[Calls(Type = typeof(SemaphoreSlim), Member = "Release", ReturnType = typeof(int))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 20)]
	public override int EndRead(IAsyncResult asyncResult) { }

	[CalledBy(Type = typeof(FileStream), Member = "EndWrite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncResult)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Task`1), Member = "GetAwaiter", ReturnType = "System.Runtime.CompilerServices.TaskAwaiter`1<TResult>")]
	[Calls(Type = typeof(SemaphoreSlim), Member = "Release", ReturnType = typeof(int))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 20)]
	public override void EndWrite(IAsyncResult asyncResult) { }

	[CalledBy(Type = typeof(Stream), Member = "BeginReadInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int), typeof(AsyncCallback), typeof(object), typeof(bool), typeof(bool)}, ReturnType = typeof(IAsyncResult))]
	[CalledBy(Type = typeof(Stream), Member = "BeginWriteInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int), typeof(AsyncCallback), typeof(object), typeof(bool), typeof(bool)}, ReturnType = typeof(IAsyncResult))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(LazyInitializer), Member = "EnsureInitialized", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", "System.Func`1<T>"}, ReturnType = "T")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	internal SemaphoreSlim EnsureAsyncActiveSemaphoreInitialized() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SemaphoreSlim), Member = "Release", ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 2)]
	private void FinishTrackingAsyncOperation() { }

	[AsyncStateMachine(typeof(<FinishWriteAsync>d__57))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<FinishWriteAsync>d__57)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<FinishWriteAsync>d__57&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private Task FinishWriteAsync(Task writeTask, Byte[] localBuffer) { }

	public abstract void Flush() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public Task FlushAsync() { }

	[CalledBy(Type = typeof(CryptoStream), Member = "FlushAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TaskFactory), Member = "StartNew", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<System.Object>), typeof(object), typeof(CancellationToken), typeof(TaskCreationOptions), typeof(TaskScheduler)}, ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public override Task FlushAsync(CancellationToken cancellationToken) { }

	public abstract bool get_CanRead() { }

	public abstract bool get_CanSeek() { }

	[CallerCount(Count = 271)]
	[DeduplicatedMethod]
	public override bool get_CanTimeout() { }

	public abstract bool get_CanWrite() { }

	public abstract long get_Length() { }

	public abstract long get_Position() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	public override int get_ReadTimeout() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	public override int get_WriteTimeout() { }

	[CalledBy(Type = typeof(Stream), Member = "CopyToAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream)}, ReturnType = typeof(Task))]
	[CalledBy(Type = typeof(Stream), Member = "CopyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Math), Member = "Min", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(long)}, ReturnType = typeof(long))]
	[CallsDeduplicatedMethods(Count = 3)]
	private int GetCopyBufferSize() { }

	[CallerCount(Count = 23)]
	[DeduplicatedMethod]
	private bool HasOverriddenBeginEndRead() { }

	[CallerCount(Count = 23)]
	[DeduplicatedMethod]
	private bool HasOverriddenBeginEndWrite() { }

	public abstract int Read(Byte[] buffer, int offset, int count) { }

	[CalledBy(Type = typeof(MemoryStream), Member = "Read", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Span`1<System.Byte>)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(UnmanagedMemoryStream), Member = "Read", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Span`1<System.Byte>)}, ReturnType = typeof(int))]
	[CalledBy(Type = "System.IO.Compression.GZipStream", Member = "Read", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Span`1<Byte>"}, ReturnType = typeof(int))]
	[CalledBy(Type = "System.Net.Sockets.NetworkStream", Member = "Read", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Span`1<Byte>"}, ReturnType = typeof(int))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
	[Calls(Type = typeof(Span`1), Member = "CopyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Span`1<T>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(IOException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 10)]
	public override int Read(Span<Byte> buffer) { }

	[CalledBy(Type = "System.IO.Compression.GZipStream", Member = "ReadAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Memory`1<Byte>", typeof(CancellationToken)}, ReturnType = "System.Threading.Tasks.ValueTask`1<Int32>")]
	[CalledBy(Type = "System.IO.Compression.DeflateStream", Member = "ReadAsyncMemory", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Memory`1<Byte>", typeof(CancellationToken)}, ReturnType = "System.Threading.Tasks.ValueTask`1<Int32>")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(MemoryMarshal), Member = "TryGetArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.ReadOnlyMemory`1<T>", "System.ArraySegment`1<T>&"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Int32>), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<<ReadAsync>g__FinishReadAsync|44_0>d)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<<ReadAsync>g__FinishReadAsync|44_0>d&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncValueTaskMethodBuilder`1), Member = "get_Task", ReturnType = "System.Threading.Tasks.ValueTask`1<TResult>")]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionArgument)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 10)]
	public override ValueTask<Int32> ReadAsync(Memory<Byte> buffer, CancellationToken cancellationToken = null) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CancellationToken), Member = "get_IsCancellationRequested", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Task), Member = "FromCanceled", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TResult"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = "System.Threading.Tasks.Task`1<TResult>")]
	[Calls(Type = typeof(Stream), Member = "BeginEndReadAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(System.Threading.Tasks.Task`1<System.Int32>))]
	public override Task<Int32> ReadAsync(Byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	[CalledBy(Type = "Mono.Nat.Upnp.UpnpNatDevice+<DecodeMessageFromResponse>d__24", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Manager.Network+<ReceiveData>d__35", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Manager.P2PManager+<ReceiveData>d__25", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.Security.SslStream", Member = "BeginRead", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Byte[]", typeof(int), typeof(int), typeof(AsyncCallback), typeof(object)}, ReturnType = typeof(IAsyncResult))]
	[CallerCount(Count = 5)]
	[CallsDeduplicatedMethods(Count = 2)]
	public Task<Int32> ReadAsync(Byte[] buffer, int offset, int count) { }

	[CalledBy(Type = typeof(CryptoStream), Member = "ReadByte", ReturnType = typeof(int))]
	[CalledBy(Type = "NGettext.Loaders.ReadOnlyStreamWrapper", Member = "ReadByte", ReturnType = typeof(int))]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public override int ReadByte() { }

	[CalledBy(Type = typeof(<>c), Member = "<RunReadWriteTaskWhenReady>b__49_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task), typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Stream), Member = "BeginReadInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int), typeof(AsyncCallback), typeof(object), typeof(bool), typeof(bool)}, ReturnType = typeof(IAsyncResult))]
	[CalledBy(Type = typeof(Stream), Member = "BeginWriteInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int), typeof(AsyncCallback), typeof(object), typeof(bool), typeof(bool)}, ReturnType = typeof(IAsyncResult))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Task), Member = "ScheduleAndStart", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	private void RunReadWriteTask(ReadWriteTask readWriteTask) { }

	[CalledBy(Type = typeof(Stream), Member = "BeginReadInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int), typeof(AsyncCallback), typeof(object), typeof(bool), typeof(bool)}, ReturnType = typeof(IAsyncResult))]
	[CalledBy(Type = typeof(Stream), Member = "BeginWriteInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int), typeof(AsyncCallback), typeof(object), typeof(bool), typeof(bool)}, ReturnType = typeof(IAsyncResult))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Task), Member = "get_IsCompleted", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Task), Member = "ContinueWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`2<System.Threading.Tasks.Task, System.Object>), typeof(object), typeof(CancellationToken), typeof(TaskContinuationOptions), typeof(TaskScheduler)}, ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsInvalidInstructions]
	private void RunReadWriteTaskWhenReady(Task asyncWaiter, ReadWriteTask readWriteTask) { }

	public abstract long Seek(long offset, SeekOrigin origin) { }

	public abstract void set_Position(long value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	public override void set_ReadTimeout(int value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	public override void set_WriteTimeout(int value) { }

	public abstract void SetLength(long value) { }

	public abstract void Write(Byte[] buffer, int offset, int count) { }

	[CalledBy(Type = typeof(MemoryStream), Member = "Write", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Byte>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UnmanagedMemoryStream), Member = "Write", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Byte>)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.IO.Compression.GZipStream", Member = "Write", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.ReadOnlySpan`1<Byte>"}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.Sockets.NetworkStream", Member = "Write", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.ReadOnlySpan`1<Byte>"}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(ReadOnlySpan`1), Member = "CopyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Span`1<T>"}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 6)]
	public override void Write(ReadOnlySpan<Byte> buffer) { }

	[CalledBy(Type = "System.IO.Compression.GZipStream", Member = "WriteAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.ReadOnlyMemory`1<Byte>", typeof(CancellationToken)}, ReturnType = typeof(ValueTask))]
	[CalledBy(Type = "System.IO.Compression.DeflateStream", Member = "WriteAsyncMemory", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.ReadOnlyMemory`1<Byte>", typeof(CancellationToken)}, ReturnType = typeof(ValueTask))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(MemoryMarshal), Member = "TryGetArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.ReadOnlyMemory`1<T>", "System.ArraySegment`1<T>&"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ReadOnlyMemory`1), Member = "get_Span", ReturnType = "System.ReadOnlySpan`1<T>")]
	[Calls(Type = typeof(ReadOnlySpan`1), Member = "CopyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Span`1<T>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<FinishWriteAsync>d__57)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<FinishWriteAsync>d__57&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionArgument)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 7)]
	public override ValueTask WriteAsync(ReadOnlyMemory<Byte> buffer, CancellationToken cancellationToken = null) { }

	[CalledBy(Type = "System.IO.Compression.DeflateManagedStream+<WriteAsyncCore>d__47", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "System.IO.Compression.DeflateManagedStream", Member = "<>n__0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Byte[]", typeof(int), typeof(int), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CancellationToken), Member = "get_IsCancellationRequested", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Task), Member = "FromCanceled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[Calls(Type = typeof(Stream), Member = "BeginEndWriteAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(Task))]
	public override Task WriteAsync(Byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	[CalledBy(Type = "Mono.Nat.Upnp.UpnpNatDevice+<SendMessageAsync>d__20", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Manager.Network+<Send>d__47", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Manager.P2PManager+<SendDirectPacket>d__49", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Data.PackedBinaryData+<CompressData>d__7", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "ClientAPI.WebServer+<ParseRequest>d__101", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Mono.Net.Security.MobileAuthenticatedStream+<InnerWrite>d__67", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.WebConnectionStream", Member = "Write", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Byte[]", typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.Security.SslStream", Member = "BeginWrite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Byte[]", typeof(int), typeof(int), typeof(AsyncCallback), typeof(object)}, ReturnType = typeof(IAsyncResult))]
	[CallerCount(Count = 9)]
	[CallsDeduplicatedMethods(Count = 2)]
	public Task WriteAsync(Byte[] buffer, int offset, int count) { }

	[CalledBy(Type = typeof(CryptoStream), Member = "WriteByte", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public override void WriteByte(byte value) { }

}

