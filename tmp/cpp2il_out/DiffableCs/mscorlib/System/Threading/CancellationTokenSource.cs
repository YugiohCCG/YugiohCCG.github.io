namespace System.Threading;

public class CancellationTokenSource : IDisposable
{
	private sealed class Linked1CancellationTokenSource : CancellationTokenSource
	{
		private readonly CancellationTokenRegistration _reg1; //Field offset: 0x40

		[CalledBy(Type = typeof(CancellationTokenSource), Member = "CreateLinkedTokenSource", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken), typeof(CancellationToken)}, ReturnType = typeof(CancellationTokenSource))]
		[CalledBy(Type = typeof(CancellationTokenSource), Member = "CreateLinkedTokenSource", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = typeof(CancellationTokenSource))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CancellationToken), Member = "Register", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<System.Object>), typeof(object), typeof(bool), typeof(bool)}, ReturnType = typeof(CancellationTokenRegistration))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 3)]
		internal Linked1CancellationTokenSource(CancellationToken token1) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CancellationTokenRegistration), Member = "Dispose", ReturnType = typeof(void))]
		[Calls(Type = typeof(CancellationTokenSource), Member = "Dispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		protected virtual void Dispose(bool disposing) { }

	}

	private sealed class Linked2CancellationTokenSource : CancellationTokenSource
	{
		private readonly CancellationTokenRegistration _reg1; //Field offset: 0x40
		private readonly CancellationTokenRegistration _reg2; //Field offset: 0x58

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CancellationToken), Member = "Register", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<System.Object>), typeof(object), typeof(bool), typeof(bool)}, ReturnType = typeof(CancellationTokenRegistration))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 4)]
		internal Linked2CancellationTokenSource(CancellationToken token1, CancellationToken token2) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CancellationTokenRegistration), Member = "Dispose", ReturnType = typeof(void))]
		[Calls(Type = typeof(CancellationTokenSource), Member = "Dispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		protected virtual void Dispose(bool disposing) { }

	}

	private sealed class LinkedNCancellationTokenSource : CancellationTokenSource
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
			[Calls(Type = typeof(CancellationTokenSource), Member = "NotifyCancellation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
			[CallsUnknownMethods(Count = 2)]
			internal void <.cctor>b__4_0(object s) { }

		}

		internal static readonly Action<Object> s_linkedTokenCancelDelegate; //Field offset: 0x0
		private CancellationTokenRegistration[] _linkingRegistrations; //Field offset: 0x40

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		private static LinkedNCancellationTokenSource() { }

		[CalledBy(Type = typeof(CancellationTokenSource), Member = "CreateLinkedTokenSource", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken[])}, ReturnType = typeof(CancellationTokenSource))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CancellationToken), Member = "InternalRegisterWithoutEC", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<System.Object>), typeof(object)}, ReturnType = typeof(CancellationTokenRegistration))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 7)]
		internal LinkedNCancellationTokenSource(CancellationToken[] tokens) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CancellationTokenRegistration), Member = "Dispose", ReturnType = typeof(void))]
		[Calls(Type = typeof(CancellationTokenSource), Member = "Dispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 2)]
		protected virtual void Dispose(bool disposing) { }

	}

	internal static readonly CancellationTokenSource s_canceledSource; //Field offset: 0x0
	internal static readonly CancellationTokenSource s_neverCanceledSource; //Field offset: 0x8
	private static readonly int s_nLists; //Field offset: 0x10
	private static readonly TimerCallback s_timerCallback; //Field offset: 0x18
	private ManualResetEvent _kernelEvent; //Field offset: 0x10
	private SparselyPopulatedArray<CancellationCallbackInfo>[] _registeredCallbacksLists; //Field offset: 0x18
	private int _state; //Field offset: 0x20
	private int _threadIDExecutingCallbacks; //Field offset: 0x24
	private bool _disposed; //Field offset: 0x28
	private CancellationCallbackInfo _executingCallback; //Field offset: 0x30
	private Timer _timer; //Field offset: 0x38

	internal CancellationCallbackInfo ExecutingCallback
	{
		[CallerCount(Count = 6)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		internal get { } //Length: 24
	}

	internal bool IsCancellationCompleted
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		internal get { } //Length: 26
	}

	public bool IsCancellationRequested
	{
		[CalledBy(Type = "System.Net.WebOperation", Member = "ThrowIfDisposed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = typeof(void))]
		[CalledBy(Type = "Game.Local.LocalGame", Member = "CleanTimerToken", ReturnType = typeof(void))]
		[CalledBy(Type = "System.Net.ServicePointScheduler+ConnectionGroup", Member = "GetNextOperation", ReturnType = "System.Net.WebOperation")]
		[CalledBy(Type = "System.Net.ServicePointScheduler", Member = "SchedulerIteration", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Net.ServicePointScheduler+ConnectionGroup"}, ReturnType = typeof(bool))]
		[CalledBy(Type = "System.Net.WebConnectionStream", Member = "GetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(Exception))]
		[CalledBy(Type = "System.Net.WebOperation", Member = "get_Aborted", ReturnType = typeof(bool))]
		[CalledBy(Type = "System.Net.WebOperation", Member = "get_Closed", ReturnType = typeof(bool))]
		[CalledBy(Type = "System.Net.WebOperation", Member = "CheckDisposed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = typeof(ExceptionDispatchInfo))]
		[CalledBy(Type = "System.Net.WebOperation", Member = "ThrowIfClosedOrDisposed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = typeof(void))]
		[CalledBy(Type = "System.Net.WebOperation", Member = "Finish", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(Exception)}, ReturnType = typeof(void))]
		[CalledBy(Type = "System.Net.WebReadStream", Member = "GetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(Exception))]
		[CalledBy(Type = "System.Net.WebResponseStream", Member = "GetReadException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Net.WebExceptionStatus", typeof(Exception), typeof(string)}, ReturnType = "System.Net.WebException")]
		[CalledBy(Type = "UnityEngine.Application", Member = "Internal_InitializeExitCancellationToken", ReturnType = typeof(void))]
		[CalledBy(Type = "Utilities.Async.Awaiters+<WaitUntil>d__6`1", Member = "MoveNext", ReturnType = typeof(void))]
		[CallerCount(Count = 14)]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 26
	}

	internal bool IsDisposed
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		internal get { } //Length: 5
	}

	internal int ThreadIDExecutingCallbacks
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		internal get { } //Length: 22
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		internal set { } //Length: 34
	}

	public CancellationToken Token
	{
		[CalledBy(Type = "Mono.Nat.Searcher", Member = "BeginListening", ReturnType = typeof(void))]
		[CalledBy(Type = "Utilities.Async.Awaiters+<WaitUntil>d__6`1", Member = "MoveNext", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.MonoBehaviour", Member = "get_destroyCancellationToken", ReturnType = typeof(CancellationToken))]
		[CalledBy(Type = "System.Net.WebResponseStream+<ReadAllAsync>d__48", Member = "MoveNext", ReturnType = typeof(void))]
		[CalledBy(Type = "System.Net.WebRequestStream+<WriteChunkTrailer>d__40", Member = "MoveNext", ReturnType = typeof(void))]
		[CalledBy(Type = "System.Net.WebOperation", Member = "RegisterRequest", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Net.ServicePoint", "System.Net.WebConnection"}, ReturnType = typeof(void))]
		[CalledBy(Type = "System.Net.WebOperation+<Run>d__58", Member = "MoveNext", ReturnType = typeof(void))]
		[CalledBy(Type = "System.Net.ServicePointScheduler+<WaitAsync>d__46", Member = "MoveNext", ReturnType = typeof(void))]
		[CalledBy(Type = "System.Net.HttpWebRequest", Member = "RunWithTimeout", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Func`2<CancellationToken, Task`1<T>>", typeof(int), typeof(Action), "System.Func`1<Boolean>", typeof(CancellationToken)}, ReturnType = "System.Threading.Tasks.Task`1<T>")]
		[CalledBy(Type = "Game.Local.LocalGame+<TimeTick>d__226", Member = "MoveNext", ReturnType = typeof(void))]
		[CalledBy(Type = "Mono.Nat.Pmp.PmpSearcher+<SearchAsync>d__11", Member = "MoveNext", ReturnType = typeof(void))]
		[CalledBy(Type = "Mono.Nat.Pmp.PmpNatDevice+<SendMessageAsync>d__12", Member = "MoveNext", ReturnType = typeof(void))]
		[CalledBy(Type = "Mono.Nat.Searcher", Member = "BeginSearching", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Net.IPAddress"}, ReturnType = typeof(void))]
		[CalledBy(Type = "Mono.Nat.Searcher", Member = "BeginSearching", ReturnType = typeof(void))]
		[CalledBy(Type = "System.Net.HttpWebRequest", Member = "RunWithTimeout", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Func`2<CancellationToken, Task`1<T>>"}, ReturnType = "System.Threading.Tasks.Task`1<T>")]
		[CallerCount(Count = 21)]
		[Calls(Type = typeof(CancellationTokenSource), Member = "ThrowObjectDisposedException", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 2)]
		 get { } //Length: 91
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlatformHelper), Member = "get_ProcessorCount", ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 9)]
	private static CancellationTokenSource() { }

	[CalledBy(Type = "Mono.Nat.Searcher", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Mono.Nat.SocketGroup"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Mono.Nat.Upnp.UpnpSearcher", Member = "Create", ReturnType = "Mono.Nat.Upnp.UpnpSearcher")]
	[CalledBy(Type = "Mono.Nat.Upnp.UpnpSearcher", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Mono.Nat.SocketGroup"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Mono.Nat.Pmp.PmpNatDevice+<SendMessageAsync>d__12", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Game.Local.LocalGame+<TimeStart>d__219", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.HttpWebRequest", Member = "RunWithTimeout", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Func`2<CancellationToken, Task`1<T>>"}, ReturnType = "System.Threading.Tasks.Task`1<T>")]
	[CalledBy(Type = "System.Net.ServicePointScheduler+<WaitAsync>d__46", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.WebRequestStream+<WriteChunkTrailer>d__40", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.WebResponseStream+<ReadAllAsync>d__48", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Application", Member = "Internal_InitializeExitCancellationToken", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Application", Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.AsyncInstantiateOperation", Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.MonoBehaviour", Member = "get_destroyCancellationToken", ReturnType = typeof(CancellationToken))]
	[CallerCount(Count = 13)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public CancellationTokenSource() { }

	[CalledBy(Type = "Utilities.Async.Awaiters+<WaitUntil>d__6`1", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TimeSpan), Member = "get_TotalMilliseconds", ReturnType = typeof(double))]
	[Calls(Type = typeof(Timer), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimerCallback), typeof(object), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 8)]
	public CancellationTokenSource(TimeSpan delay) { }

	[CalledBy(Type = "Mono.Nat.Searcher", Member = "Dispose", ReturnType = typeof(void))]
	[CalledBy(Type = "Unity.Mathematics.math", Member = "uint2x3", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Mathematics.uint2", "Unity.Mathematics.uint2", "Unity.Mathematics.uint2"}, ReturnType = "Unity.Mathematics.uint2x3")]
	[CalledBy(Type = "Unity.Mathematics.math", Member = "int2x3", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Mathematics.int2", "Unity.Mathematics.int2", "Unity.Mathematics.int2"}, ReturnType = "Unity.Mathematics.int2x3")]
	[CalledBy(Type = "Unity.Mathematics.math", Member = "float2x3", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Mathematics.float2", "Unity.Mathematics.float2", "Unity.Mathematics.float2"}, ReturnType = "Unity.Mathematics.float2x3")]
	[CalledBy(Type = "UnityEngine.MonoBehaviour", Member = "RaiseCancellation", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Application", Member = "Internal_RaiseExitCancellationToken", ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.WebResponseStream+<ReadAllAsync>d__48", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.WebOperation", Member = "CheckThrowDisposed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(ExceptionDispatchInfo&)}, ReturnType = typeof(ExceptionDispatchInfo))]
	[CalledBy(Type = "System.Net.WebOperation", Member = "ThrowIfDisposed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.WebOperation", Member = "ThrowIfClosedOrDisposed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.WebOperation", Member = "Abort", ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.ServicePointScheduler+<WaitAsync>d__46", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.HttpWebRequest+<<GetRewriteHandler>b__271_0>d", Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.HttpWebRequest+<RunWithTimeoutWorker>d__241`1", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Game.Local.LocalGame", Member = "CleanTimerToken", ReturnType = typeof(void))]
	[CalledBy(Type = "Mono.Nat.Pmp.PmpSearcher", Member = "HandleMessageReceived", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Net.IPAddress", "System.Byte[]", "System.Net.IPEndPoint", typeof(bool), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CalledBy(Type = "Mono.Nat.Pmp.PmpSearcher+<SearchAsync>d__11", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.WebOperation", Member = "CheckDisposed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = typeof(ExceptionDispatchInfo))]
	[CallerCount(Count = 21)]
	[Calls(Type = typeof(CancellationTokenSource), Member = "ThrowObjectDisposedException", ReturnType = typeof(void))]
	[Calls(Type = typeof(CancellationTokenSource), Member = "NotifyCancellation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void Cancel() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CancellationTokenSource), Member = "NotifyCancellation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CancellationTokenSource), Member = "ThrowObjectDisposedException", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void Cancel(bool throwOnFirstException) { }

	[CalledBy(Type = "System.Net.WebRequestStream+<WriteChunkTrailer>d__40", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Timer), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimerCallback), typeof(object), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Timer), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(Timer), Member = "Change", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CancellationTokenSource), Member = "ThrowObjectDisposedException", ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 12)]
	public void CancelAfter(int millisecondsDelay) { }

	[CalledBy(Type = typeof(CancellationTokenSource), Member = "ExecuteCallbackHandlers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CancellationTokenSource), Member = "CancellationCallbackCoreWork_OnSyncContext", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(SparselyPopulatedArrayFragment`1), Member = "SafeAtomicRemove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), "T"}, ReturnType = "T")]
	[Calls(Type = typeof(ExecutionContext), Member = "Run", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExecutionContext), typeof(ContextCallback), typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 5)]
	private void CancellationCallbackCoreWork(CancellationCallbackCoreWorkArguments args) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CancellationTokenSource), Member = "CancellationCallbackCoreWork", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationCallbackCoreWorkArguments)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	private void CancellationCallbackCoreWork_OnSyncContext(object obj) { }

	[CalledBy(Type = "Mono.Nat.Pmp.PmpSearcher+<SearchAsync>d__11", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(LinkedNCancellationTokenSource), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CancellationTokenSource), Member = "CreateLinkedTokenSource", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken), typeof(CancellationToken)}, ReturnType = typeof(CancellationTokenSource))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 9)]
	[ContainsInvalidInstructions]
	public static CancellationTokenSource CreateLinkedTokenSource(CancellationToken[] tokens) { }

	[CalledBy(Type = typeof(CancellationTokenSource), Member = "CreateLinkedTokenSource", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken), typeof(CancellationToken)}, ReturnType = typeof(CancellationTokenSource))]
	[CalledBy(Type = "System.Net.HttpWebRequest", Member = "RunWithTimeout", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Func`2<CancellationToken, Task`1<T>>", typeof(int), typeof(Action), "System.Func`1<Boolean>", typeof(CancellationToken)}, ReturnType = "System.Threading.Tasks.Task`1<T>")]
	[CalledBy(Type = "System.Net.WebOperation", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Net.HttpWebRequest", "System.Net.BufferOffsetSize", typeof(bool), typeof(CancellationToken)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Linked1CancellationTokenSource), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	internal static CancellationTokenSource CreateLinkedTokenSource(CancellationToken token) { }

	[CalledBy(Type = typeof(CancellationTokenSource), Member = "CreateLinkedTokenSource", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken[])}, ReturnType = typeof(CancellationTokenSource))]
	[CalledBy(Type = "System.Threading.SemaphoreSlim+<WaitUntilCountOrTimeoutAsync>d__32", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CancellationTokenSource), Member = "CreateLinkedTokenSource", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = typeof(CancellationTokenSource))]
	[Calls(Type = typeof(CancellationToken), Member = "Register", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<System.Object>), typeof(object), typeof(bool), typeof(bool)}, ReturnType = typeof(CancellationTokenRegistration))]
	[Calls(Type = typeof(Linked1CancellationTokenSource), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public static CancellationTokenSource CreateLinkedTokenSource(CancellationToken token1, CancellationToken token2) { }

	[CalledBy(Type = "Mono.Nat.Pmp.PmpNatDevice+<SendMessageAsync>d__12", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Game.Local.LocalGame+<>c", Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = "Game.Local.LocalGame+<TimeTick>d__226", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.HttpWebRequest+<RunWithTimeoutWorker>d__241`1", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.HttpWebRequest+<<GetRewriteHandler>b__271_0>d", Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.ServicePointScheduler+<WaitAsync>d__46", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.WebResponseStream+<ReadAllAsync>d__48", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Unity.Mathematics.math", Member = "float2x3", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Mathematics.float2", "Unity.Mathematics.float2", "Unity.Mathematics.float2"}, ReturnType = "Unity.Mathematics.float2x3")]
	[CalledBy(Type = "Unity.Mathematics.math", Member = "int2x3", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Mathematics.int2", "Unity.Mathematics.int2", "Unity.Mathematics.int2"}, ReturnType = "Unity.Mathematics.int2x3")]
	[CalledBy(Type = "Unity.Mathematics.math", Member = "uint2x3", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Mathematics.uint2", "Unity.Mathematics.uint2", "Unity.Mathematics.uint2"}, ReturnType = "Unity.Mathematics.uint2x3")]
	[CalledBy(Type = "Newtonsoft.Json.Utilities.LateBoundReflectionDelegateFactory+<>c__DisplayClass9_0`1", Member = "<CreateSet>b__0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", typeof(object)}, ReturnType = typeof(void))]
	[CallerCount(Count = 29)]
	[Calls(Type = typeof(GC), Member = "SuppressFinalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	public override void Dispose() { }

	[CalledBy(Type = typeof(Linked1CancellationTokenSource), Member = "Dispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Linked2CancellationTokenSource), Member = "Dispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LinkedNCancellationTokenSource), Member = "Dispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Timer), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(WaitHandle), Member = "Dispose", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 7)]
	protected override void Dispose(bool disposing) { }

	[CalledBy(Type = typeof(CancellationTokenSource), Member = "NotifyCancellation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SparselyPopulatedArray`1), Member = "get_Tail", ReturnType = "System.Threading.SparselyPopulatedArrayFragment`1<T>")]
	[Calls(Type = typeof(SparselyPopulatedArrayFragment`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[Calls(Type = typeof(CancellationTokenSource), Member = "CancellationCallbackCoreWork", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationCallbackCoreWorkArguments)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(LowLevelListWithIList`1), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(LowLevelList`1), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Interlocked), Member = "MemoryBarrier", ReturnType = typeof(void))]
	[Calls(Type = typeof(Interlocked), Member = "Exchange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(AggregateException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Exception>)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 25)]
	private void ExecuteCallbackHandlers(bool throwOnFirstException) { }

	[CallerCount(Count = 6)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	internal CancellationCallbackInfo get_ExecutingCallback() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	internal bool get_IsCancellationCompleted() { }

	[CalledBy(Type = "System.Net.WebOperation", Member = "ThrowIfDisposed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Utilities.Async.Awaiters+<WaitUntil>d__6`1", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Application", Member = "Internal_InitializeExitCancellationToken", ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.WebResponseStream", Member = "GetReadException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Net.WebExceptionStatus", typeof(Exception), typeof(string)}, ReturnType = "System.Net.WebException")]
	[CalledBy(Type = "System.Net.WebReadStream", Member = "GetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(Exception))]
	[CalledBy(Type = "System.Net.WebOperation", Member = "Finish", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(Exception)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.WebOperation", Member = "CheckDisposed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = typeof(ExceptionDispatchInfo))]
	[CalledBy(Type = "System.Net.WebOperation", Member = "ThrowIfClosedOrDisposed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.WebOperation", Member = "get_Aborted", ReturnType = typeof(bool))]
	[CalledBy(Type = "System.Net.WebConnectionStream", Member = "GetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(Exception))]
	[CalledBy(Type = "System.Net.ServicePointScheduler", Member = "SchedulerIteration", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Net.ServicePointScheduler+ConnectionGroup"}, ReturnType = typeof(bool))]
	[CalledBy(Type = "System.Net.ServicePointScheduler+ConnectionGroup", Member = "GetNextOperation", ReturnType = "System.Net.WebOperation")]
	[CalledBy(Type = "Game.Local.LocalGame", Member = "CleanTimerToken", ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.WebOperation", Member = "get_Closed", ReturnType = typeof(bool))]
	[CallerCount(Count = 14)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public bool get_IsCancellationRequested() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	internal bool get_IsDisposed() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	internal int get_ThreadIDExecutingCallbacks() { }

	[CalledBy(Type = "Mono.Nat.Searcher", Member = "BeginListening", ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.HttpWebRequest", Member = "RunWithTimeout", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Func`2<CancellationToken, Task`1<T>>"}, ReturnType = "System.Threading.Tasks.Task`1<T>")]
	[CalledBy(Type = "Mono.Nat.Searcher", Member = "BeginSearching", ReturnType = typeof(void))]
	[CalledBy(Type = "Mono.Nat.Searcher", Member = "BeginSearching", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Net.IPAddress"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Mono.Nat.Pmp.PmpNatDevice+<SendMessageAsync>d__12", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Mono.Nat.Pmp.PmpSearcher+<SearchAsync>d__11", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Game.Local.LocalGame+<TimeTick>d__226", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.HttpWebRequest", Member = "RunWithTimeout", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Func`2<CancellationToken, Task`1<T>>", typeof(int), typeof(Action), "System.Func`1<Boolean>", typeof(CancellationToken)}, ReturnType = "System.Threading.Tasks.Task`1<T>")]
	[CalledBy(Type = "System.Net.WebOperation+<Run>d__58", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.WebOperation", Member = "RegisterRequest", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Net.ServicePoint", "System.Net.WebConnection"}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.WebRequestStream+<WriteChunkTrailer>d__40", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.WebResponseStream+<ReadAllAsync>d__48", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.MonoBehaviour", Member = "get_destroyCancellationToken", ReturnType = typeof(CancellationToken))]
	[CalledBy(Type = "Utilities.Async.Awaiters+<WaitUntil>d__6`1", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.ServicePointScheduler+<WaitAsync>d__46", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 21)]
	[Calls(Type = typeof(CancellationTokenSource), Member = "ThrowObjectDisposedException", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	public CancellationToken get_Token() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Timer), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimerCallback), typeof(object), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	private void InitializeWithTimer(int millisecondsDelay) { }

	[CalledBy(Type = typeof(CancellationToken), Member = "Register", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<System.Object>), typeof(object), typeof(bool), typeof(bool)}, ReturnType = typeof(CancellationTokenRegistration))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CancellationCallbackInfo), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<System.Object>), typeof(object), typeof(ExecutionContext), typeof(CancellationTokenSource)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SparselyPopulatedArray`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SparselyPopulatedArray`1), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "System.Threading.SparselyPopulatedArrayAddInfo`1<T>")]
	[Calls(Type = typeof(SparselyPopulatedArrayFragment`1), Member = "SafeAtomicRemove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), "T"}, ReturnType = "T")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 16)]
	[ContainsUnimplementedInstructions]
	internal CancellationTokenRegistration InternalRegister(Action<Object> callback, object stateForCallback, SynchronizationContext targetSyncContext, ExecutionContext executionContext) { }

	[CalledBy(Type = "System.Threading.CancellationTokenSource+LinkedNCancellationTokenSource+<>c", Member = "<.cctor>b__4_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CancellationTokenSource), Member = "Cancel", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CancellationTokenSource), Member = "Cancel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CancellationTokenSource), Member = "TimerCallbackLogic", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Threading.SemaphoreSlim+<WaitUntilCountOrTimeoutAsync>d__32", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(Interlocked), Member = "CompareExchange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Timer), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(EventWaitHandle), Member = "Set", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CancellationTokenSource), Member = "ExecuteCallbackHandlers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	private void NotifyCancellation(bool throwOnFirstException) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	internal void set_ThreadIDExecutingCallbacks(int value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CancellationTokenSource), Member = "ThrowObjectDisposedException", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	internal void ThrowIfDisposed() { }

	[CalledBy(Type = typeof(CancellationTokenSource), Member = "get_Token", ReturnType = typeof(CancellationToken))]
	[CalledBy(Type = typeof(CancellationTokenSource), Member = "Cancel", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CancellationTokenSource), Member = "Cancel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CancellationTokenSource), Member = "CancelAfter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CancellationTokenSource), Member = "TimerCallbackLogic", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CancellationTokenSource), Member = "ThrowIfDisposed", ReturnType = typeof(void))]
	[CalledBy(Type = "System.Threading.SemaphoreSlim+<WaitUntilCountOrTimeoutAsync>d__32", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(ObjectDisposedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	private static void ThrowObjectDisposedException() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CancellationTokenSource), Member = "NotifyCancellation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CancellationTokenSource), Member = "ThrowObjectDisposedException", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	private static void TimerCallbackLogic(object obj) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SpinWait), Member = "SpinOnceCore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	internal void WaitForCallbackToComplete(CancellationCallbackInfo callbackInfo) { }

}

