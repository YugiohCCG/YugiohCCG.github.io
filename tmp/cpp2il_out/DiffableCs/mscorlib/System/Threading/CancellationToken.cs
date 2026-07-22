namespace System.Threading;

[DebuggerDisplay("IsCancellationRequested = {IsCancellationRequested}")]
[IsReadOnly]
public struct CancellationToken
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
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		internal void <.cctor>b__26_0(object obj) { }

	}

	private static readonly Action<Object> s_actionToActionObjShunt; //Field offset: 0x0
	private readonly CancellationTokenSource _source; //Field offset: 0x0

	public bool CanBeCanceled
	{
		[CallerCount(Count = 11)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		 get { } //Length: 8
	}

	public bool IsCancellationRequested
	{
		[CallerCount(Count = 131)]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 49
	}

	public static CancellationToken None
	{
		[CallerCount(Count = 182)]
		[DeduplicatedMethod]
		 get { } //Length: 3
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private static CancellationToken() { }

	[CallerCount(Count = 5)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	internal CancellationToken(CancellationTokenSource source) { }

	[CalledBy(Type = "System.Threading.Tasks.ValueTask+ValueTaskSourceAsTask+<>c", Member = "<.cctor>b__4_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ValueTask), Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = "System.Threading.Tasks.ValueTask`1+ValueTaskSourceAsTask+<>c", Member = "<.cctor>b__4_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ValueTask`1), Member = "GetTaskForValueTaskSource", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Threading.Tasks.Sources.IValueTaskSource`1<TResult>"}, ReturnType = "System.Threading.Tasks.Task`1<TResult>")]
	[CallerCount(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	public CancellationToken(bool canceled) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public virtual bool Equals(object other) { }

	[CallerCount(Count = 9)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public bool Equals(CancellationToken other) { }

	[CallerCount(Count = 11)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public bool get_CanBeCanceled() { }

	[CallerCount(Count = 131)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public bool get_IsCancellationRequested() { }

	[CallerCount(Count = 182)]
	[DeduplicatedMethod]
	public static CancellationToken get_None() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public virtual int GetHashCode() { }

	[CalledBy(Type = "System.Threading.CancellationTokenSource+LinkedNCancellationTokenSource", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Task), Member = "AssignCancellationToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken), typeof(Task), typeof(TaskContinuation)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Task), Member = "Delay", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CancellationToken), Member = "Register", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<System.Object>), typeof(object), typeof(bool), typeof(bool)}, ReturnType = typeof(CancellationTokenRegistration))]
	internal CancellationTokenRegistration InternalRegisterWithoutEC(Action<Object> callback, object state) { }

	[CalledBy(Type = typeof(Task), Member = "HandleException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[ContainsUnimplementedInstructions]
	public static bool op_Equality(CancellationToken left, CancellationToken right) { }

	[CalledBy(Type = typeof(Task), Member = "TrySetCanceled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken), typeof(object)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Task), Member = "RecordInternalCancellationRequest", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Task), Member = "RecordInternalCancellationRequest", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken), typeof(object)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[ContainsUnimplementedInstructions]
	public static bool op_Inequality(CancellationToken left, CancellationToken right) { }

	[CalledBy(Type = "Plugins.WindowsPermissionSetup", Member = "get_UpdaterTempFile", ReturnType = typeof(FileInfo))]
	[CalledBy(Type = "UnityEngine.Awaitable", Member = "WireupCancellation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Awaitable", typeof(CancellationToken)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CancellationToken), Member = "Register", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<System.Object>), typeof(object), typeof(bool), typeof(bool)}, ReturnType = typeof(CancellationTokenRegistration))]
	public CancellationTokenRegistration Register(Action<Object> callback, object state, bool useSynchronizationContext) { }

	[CalledBy(Type = "Mono.Nat.Upnp.UpnpSearcher+<GetServicesList>d__16", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Mono.Nat.Pmp.PmpNatDevice+<SendMessageAsync>d__12", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.WebOperation", Member = "RegisterRequest", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Net.ServicePoint", "System.Net.WebConnection"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Utilities.Async.Awaiters+<WaitUntil>d__6`1", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CancellationToken), Member = "Register", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<System.Object>), typeof(object), typeof(bool), typeof(bool)}, ReturnType = typeof(CancellationTokenRegistration))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	public CancellationTokenRegistration Register(Action callback) { }

	[CalledBy(Type = typeof(CancellationToken), Member = "Register", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action)}, ReturnType = typeof(CancellationTokenRegistration))]
	[CalledBy(Type = typeof(CancellationToken), Member = "Register", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<System.Object>), typeof(object), typeof(bool)}, ReturnType = typeof(CancellationTokenRegistration))]
	[CalledBy(Type = typeof(CancellationToken), Member = "InternalRegisterWithoutEC", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<System.Object>), typeof(object)}, ReturnType = typeof(CancellationTokenRegistration))]
	[CalledBy(Type = typeof(ManualResetEventSlim), Member = "Wait", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(CancellationToken)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "System.Threading.CancellationTokenSource+Linked1CancellationTokenSource", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Threading.CancellationTokenSource+Linked2CancellationTokenSource", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken), typeof(CancellationToken)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CancellationTokenSource), Member = "CreateLinkedTokenSource", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken), typeof(CancellationToken)}, ReturnType = typeof(CancellationTokenSource))]
	[CalledBy(Type = typeof(SemaphoreSlim), Member = "Wait", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(CancellationToken)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(SynchronizationContext), Member = "get_Current", ReturnType = typeof(SynchronizationContext))]
	[Calls(Type = typeof(ExecutionContext), Member = "Capture", ReturnType = typeof(ExecutionContext))]
	[Calls(Type = typeof(CancellationTokenSource), Member = "InternalRegister", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<System.Object>), typeof(object), typeof(SynchronizationContext), typeof(ExecutionContext)}, ReturnType = typeof(CancellationTokenRegistration))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	public CancellationTokenRegistration Register(Action<Object> callback, object state, bool useSynchronizationContext, bool useExecutionContext) { }

	[CallerCount(Count = 31)]
	[Calls(Type = typeof(CancellationToken), Member = "ThrowOperationCanceledException", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	public void ThrowIfCancellationRequested() { }

	[CalledBy(Type = typeof(CancellationToken), Member = "ThrowIfCancellationRequested", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ManualResetEventSlim), Member = "Wait", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(CancellationToken)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(SemaphoreSlim), Member = "Wait", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(CancellationToken)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(SemaphoreSlim), Member = "WaitUntilCountOrTimeout", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(uint), typeof(CancellationToken)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(OperationCanceledException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(CancellationToken)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	private void ThrowOperationCanceledException() { }

}

