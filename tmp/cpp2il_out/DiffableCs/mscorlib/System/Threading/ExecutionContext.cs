namespace System.Threading;

public sealed class ExecutionContext : IDisposable, ISerializable
{
	[Flags]
	public enum CaptureOptions
	{
		None = 0,
		IgnoreSyncCtx = 1,
		OptimizeDefaultCase = 2,
	}

	private enum Flags
	{
		None = 0,
		IsNewCapture = 1,
		IsFlowSuppressed = 2,
		IsPreAllocatedDefault = 4,
	}

	public struct Reader
	{
		private ExecutionContext m_ec; //Field offset: 0x0

		public bool IsFlowSuppressed
		{
			[CallerCount(Count = 0)]
			[ContainsUnimplementedInstructions]
			 get { } //Length: 20
		}

		public bool IsNull
		{
			[CallerCount(Count = 13)]
			[ContainsUnimplementedInstructions]
			[DeduplicatedMethod]
			 get { } //Length: 8
		}

		public Reader LogicalCallContext
		{
			[CalledBy(Type = typeof(RemotingServices), Member = "SerializeCallData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(Byte[]))]
			[CalledBy(Type = typeof(CallContext), Member = "LogicalGetData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(object))]
			[CallerCount(Count = 2)]
			[Calls(Type = typeof(ExecutionContext), Member = "get_LogicalCallContext", ReturnType = typeof(LogicalCallContext))]
			[CallsUnknownMethods(Count = 1)]
			 get { } //Length: 52
		}

		public SynchronizationContext SynchronizationContext
		{
			[CallerCount(Count = 0)]
			 get { } //Length: 17
		}

		public SynchronizationContext SynchronizationContextNoFlow
		{
			[CallerCount(Count = 0)]
			 get { } //Length: 17
		}

		[CallerCount(Count = 5)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		public Reader(ExecutionContext ec) { }

		[CallerCount(Count = 138)]
		[DeduplicatedMethod]
		public ExecutionContext DangerousGetRawExecutionContext() { }

		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		public bool get_IsFlowSuppressed() { }

		[CallerCount(Count = 13)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		public bool get_IsNull() { }

		[CalledBy(Type = typeof(RemotingServices), Member = "SerializeCallData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(Byte[]))]
		[CalledBy(Type = typeof(CallContext), Member = "LogicalGetData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(object))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(ExecutionContext), Member = "get_LogicalCallContext", ReturnType = typeof(LogicalCallContext))]
		[CallsUnknownMethods(Count = 1)]
		public Reader get_LogicalCallContext() { }

		[CallerCount(Count = 0)]
		public SynchronizationContext get_SynchronizationContext() { }

		[CallerCount(Count = 0)]
		public SynchronizationContext get_SynchronizationContextNoFlow() { }

		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		public bool HasSameLocalValues(ExecutionContext other) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(LogicalCallContext), Member = "get_HasInfo", ReturnType = typeof(bool))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		public bool IsDefaultFTContext(bool ignoreSyncCtx) { }

	}

	private static readonly ExecutionContext s_dummyDefaultEC; //Field offset: 0x0
	internal static readonly ExecutionContext Default; //Field offset: 0x8
	private SynchronizationContext _syncContext; //Field offset: 0x10
	private SynchronizationContext _syncContextNoFlow; //Field offset: 0x18
	private LogicalCallContext _logicalCallContext; //Field offset: 0x20
	private IllogicalCallContext _illogicalCallContext; //Field offset: 0x28
	private Flags _flags; //Field offset: 0x30
	private Dictionary<IAsyncLocal, Object> _localValues; //Field offset: 0x38
	private List<IAsyncLocal> _localChangeNotifications; //Field offset: 0x40

	internal IllogicalCallContext IllogicalCallContext
	{
		[CalledBy(Type = typeof(CallContext), Member = "LogicalSetData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		internal get { } //Length: 105
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		internal set { } //Length: 13
	}

	internal bool isFlowSuppressed
	{
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		internal get { } //Length: 8
		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		internal set { } //Length: 25
	}

	internal bool isNewCapture
	{
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		internal get { } //Length: 8
		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		internal set { } //Length: 25
	}

	internal bool IsPreAllocatedDefault
	{
		[CalledBy(Type = typeof(AsyncMethodBuilderCore), Member = "GetCompletionAction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task), typeof(MoveNextRunner&)}, ReturnType = typeof(Action))]
		[CallerCount(Count = 1)]
		[ContainsUnimplementedInstructions]
		internal get { } //Length: 8
	}

	internal LogicalCallContext LogicalCallContext
	{
		[CalledBy(Type = typeof(Reader), Member = "get_LogicalCallContext", ReturnType = typeof(Reader))]
		[CalledBy(Type = typeof(ExecutionContext), Member = "CreateCopy", ReturnType = typeof(ExecutionContext))]
		[CalledBy(Type = typeof(ExecutionContext), Member = "CreateMutableCopy", ReturnType = typeof(ExecutionContext))]
		[CalledBy(Type = typeof(ExecutionContext), Member = "Capture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StackCrawlMark&), typeof(CaptureOptions)}, ReturnType = typeof(ExecutionContext))]
		[CalledBy(Type = typeof(RemotingServices), Member = "InternalExecuteMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MarshalByRefObject), typeof(IMethodCallMessage)}, ReturnType = typeof(IMethodReturnMessage))]
		[CalledBy(Type = typeof(RemotingServices), Member = "DeserializeCallData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(object))]
		[CalledBy(Type = typeof(RealProxy), Member = "PrivateInvoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RealProxy), typeof(IMessage), typeof(Exception&), typeof(Object[]&)}, ReturnType = typeof(object))]
		[CalledBy(Type = typeof(CallContext), Member = "SetLogicalCallContext", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LogicalCallContext)}, ReturnType = typeof(LogicalCallContext))]
		[CalledBy(Type = typeof(CallContext), Member = "LogicalSetData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(void))]
		[CallerCount(Count = 11)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		internal get { } //Length: 105
		[CallerCount(Count = 10)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		internal set { } //Length: 13
	}

	internal SynchronizationContext SynchronizationContext
	{
		[CallerCount(Count = 106)]
		[DeduplicatedMethod]
		[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::Success (2))]
		internal get { } //Length: 5
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::Success (2))]
		internal set { } //Length: 13
	}

	internal SynchronizationContext SynchronizationContextNoFlow
	{
		[CallerCount(Count = 31)]
		[DeduplicatedMethod]
		[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::Success (2))]
		internal get { } //Length: 5
		[CallerCount(Count = 9)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::Success (2))]
		internal set { } //Length: 13
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	private static ExecutionContext() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SerializationInfo), Member = "GetEnumerator", ReturnType = typeof(SerializationInfoEnumerator))]
	[Calls(Type = typeof(SerializationInfoEnumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(SerializationInfoEnumerator), Member = "get_Name", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(SerializationInfoEnumerator), Member = "get_Value", ReturnType = typeof(object))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	private ExecutionContext(SerializationInfo info, StreamingContext context) { }

	[CallerCount(Count = 2180)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::Success (2))]
	internal ExecutionContext() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::Success (2))]
	internal ExecutionContext(bool isPreAllocatedDefault) { }

	[CalledBy(Type = typeof(__ComObject), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ExecutionContext), Member = "Capture", ReturnType = typeof(ExecutionContext))]
	[CalledBy(Type = typeof(ExecutionContext), Member = "FastCapture", ReturnType = typeof(ExecutionContext))]
	[CalledBy(Type = typeof(Thread), Member = "Start", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StackCrawlMark&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(QueueUserWorkItemCallback), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WaitCallback), typeof(object), typeof(bool), typeof(StackCrawlMark&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(ExecutionContext), Member = "get_LogicalCallContext", ReturnType = typeof(LogicalCallContext))]
	[Calls(Type = typeof(Reader), Member = "get_HasInfo", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Reader), Member = "Clone", ReturnType = typeof(LogicalCallContext))]
	[Calls(Type = typeof(LogicalCallContext), Member = "get_HasInfo", ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 10)]
	internal static ExecutionContext Capture(ref StackCrawlMark stackMark, CaptureOptions options) { }

	[CalledBy(Type = typeof(CancellationToken), Member = "Register", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<System.Object>), typeof(object), typeof(bool), typeof(bool)}, ReturnType = typeof(CancellationTokenRegistration))]
	[CalledBy(Type = typeof(Task), Member = "TaskConstructorCore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(object), typeof(CancellationToken), typeof(TaskCreationOptions), typeof(InternalTaskOptions), typeof(TaskScheduler)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(AwaitTaskContinuation), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.IO.Stream+ReadWriteTask", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool), typeof(System.Func`2<System.Object, System.Int32>), typeof(object), typeof(Stream), typeof(Byte[]), typeof(int), typeof(int), typeof(AsyncCallback)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.ContextAwareResult", Member = "CaptureOrComplete", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExecutionContext&), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "System.Net.ServerCertValidationCallback", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Net.Security.RemoteCertificateValidationCallback"}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.Sockets.Socket+AwaitableSocketAsyncEventArgs", Member = "OnCompleted", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Action`1<Object>", typeof(object), typeof(short), typeof(ValueTaskSourceOnCompletedFlags)}, ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(ExecutionContext), Member = "Capture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StackCrawlMark&), typeof(CaptureOptions)}, ReturnType = typeof(ExecutionContext))]
	public static ExecutionContext Capture() { }

	[CalledBy(Type = "System.Net.ServerCertValidationCallback", Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(X509Certificate), "System.Security.Cryptography.X509Certificates.X509Chain", "System.Net.Security.SslPolicyErrors"}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ExecutionContext), Member = "get_LogicalCallContext", ReturnType = typeof(LogicalCallContext))]
	[Calls(Type = typeof(LogicalCallContext), Member = "Clone", ReturnType = typeof(object))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 10)]
	public ExecutionContext CreateCopy() { }

	[CalledBy(Type = typeof(Thread), Member = "GetMutableExecutionContext", ReturnType = typeof(ExecutionContext))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ExecutionContext), Member = "get_LogicalCallContext", ReturnType = typeof(LogicalCallContext))]
	[Calls(Type = typeof(LogicalCallContext), Member = "Clone", ReturnType = typeof(object))]
	[Calls(Type = typeof(IllogicalCallContext), Member = "CreateCopy", ReturnType = typeof(IllogicalCallContext))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 9)]
	internal ExecutionContext CreateMutableCopy() { }

	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	public override void Dispose() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 4)]
	[ContainsUnimplementedInstructions]
	private static void EstablishCopyOnWriteScope(Thread currentThread, bool knownNullWindowsIdentity, ref ExecutionContextSwitcher ecsw) { }

	[CalledBy(Type = typeof(AsyncVoidMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TStateMachine&"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TStateMachine&"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(AsyncTaskMethodBuilder`1), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TStateMachine&"}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 6)]
	[ContainsUnimplementedInstructions]
	internal static void EstablishCopyOnWriteScope(ref ExecutionContextSwitcher ecsw) { }

	[CalledBy(Type = typeof(AsyncMethodBuilderCore), Member = "GetCompletionAction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task), typeof(MoveNextRunner&)}, ReturnType = typeof(Action))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ExecutionContext), Member = "Capture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StackCrawlMark&), typeof(CaptureOptions)}, ReturnType = typeof(ExecutionContext))]
	[FriendAccessAllowed]
	internal static ExecutionContext FastCapture() { }

	[CalledBy(Type = typeof(CallContext), Member = "LogicalSetData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	internal IllogicalCallContext get_IllogicalCallContext() { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	internal bool get_isFlowSuppressed() { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	internal bool get_isNewCapture() { }

	[CalledBy(Type = typeof(AsyncMethodBuilderCore), Member = "GetCompletionAction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task), typeof(MoveNextRunner&)}, ReturnType = typeof(Action))]
	[CallerCount(Count = 1)]
	[ContainsUnimplementedInstructions]
	internal bool get_IsPreAllocatedDefault() { }

	[CalledBy(Type = typeof(Reader), Member = "get_LogicalCallContext", ReturnType = typeof(Reader))]
	[CalledBy(Type = typeof(ExecutionContext), Member = "CreateCopy", ReturnType = typeof(ExecutionContext))]
	[CalledBy(Type = typeof(ExecutionContext), Member = "CreateMutableCopy", ReturnType = typeof(ExecutionContext))]
	[CalledBy(Type = typeof(ExecutionContext), Member = "Capture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StackCrawlMark&), typeof(CaptureOptions)}, ReturnType = typeof(ExecutionContext))]
	[CalledBy(Type = typeof(RemotingServices), Member = "InternalExecuteMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MarshalByRefObject), typeof(IMethodCallMessage)}, ReturnType = typeof(IMethodReturnMessage))]
	[CalledBy(Type = typeof(RemotingServices), Member = "DeserializeCallData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(RealProxy), Member = "PrivateInvoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RealProxy), typeof(IMessage), typeof(Exception&), typeof(Object[]&)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(CallContext), Member = "SetLogicalCallContext", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LogicalCallContext)}, ReturnType = typeof(LogicalCallContext))]
	[CalledBy(Type = typeof(CallContext), Member = "LogicalSetData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(void))]
	[CallerCount(Count = 11)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	internal LogicalCallContext get_LogicalCallContext() { }

	[CallerCount(Count = 106)]
	[DeduplicatedMethod]
	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::Success (2))]
	internal SynchronizationContext get_SynchronizationContext() { }

	[CallerCount(Count = 31)]
	[DeduplicatedMethod]
	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::Success (2))]
	internal SynchronizationContext get_SynchronizationContextNoFlow() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(SerializationInfo), Member = "AddValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(Type)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LogicalCallContext), Member = "get_HasInfo", ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	internal bool IsDefaultFTContext(bool ignoreSyncCtx) { }

	[CalledBy(Type = typeof(__ComObject), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(QueueUserWorkItemCallback), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WaitCallback), typeof(object), typeof(bool), typeof(StackCrawlMark&)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.WebRequest", Member = "GetRequestStreamAsync", ReturnType = "System.Threading.Tasks.Task`1<Stream>")]
	[CalledBy(Type = "System.Net.WebRequest", Member = "GetResponseAsync", ReturnType = "System.Threading.Tasks.Task`1<WebResponse>")]
	[CallerCount(Count = 4)]
	[CallsUnknownMethods(Count = 4)]
	[ContainsUnimplementedInstructions]
	public static bool IsFlowSuppressed() { }

	[CalledBy(Type = typeof(ExecutionContextSwitcher), Member = "Undo", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ExecutionContext), Member = "SetExecutionContext", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExecutionContext), typeof(bool)}, ReturnType = typeof(ExecutionContextSwitcher))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Environment), Member = "FailFast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Exception)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 7)]
	[HandleProcessCorruptedStateExceptions]
	internal static void OnAsyncLocalContextChanged(ExecutionContext previous, ExecutionContext current) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Thread), Member = "GetMutableExecutionContext", ReturnType = typeof(ExecutionContext))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	public static void RestoreFlow() { }

	[CalledBy(Type = typeof(CancellationTokenSource), Member = "CancellationCallbackCoreWork", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationCallbackCoreWorkArguments)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CancellationCallbackInfo), Member = "ExecuteCallback", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ThreadHelper), Member = "ThreadStart", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ThreadHelper), Member = "ThreadStart", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(AwaitTaskContinuation), Member = "System.Threading.IThreadPoolWorkItem.ExecuteWorkItem", ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.ContextAwareResult", Member = "Complete", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.ServerCertValidationCallback", Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(X509Certificate), "System.Security.Cryptography.X509Certificates.X509Chain", "System.Net.Security.SslPolicyErrors"}, ReturnType = typeof(bool))]
	[CalledBy(Type = "System.Net.Sockets.Socket+AwaitableSocketAsyncEventArgs", Member = "OnCompleted", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Net.Sockets.SocketAsyncEventArgs"}, ReturnType = typeof(void))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(ExecutionContext), Member = "RunInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExecutionContext), typeof(ContextCallback), typeof(object), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 8)]
	public static void Run(ExecutionContext executionContext, ContextCallback callback, object state) { }

	[CalledBy(Type = typeof(QueueUserWorkItemCallback), Member = "System.Threading.IThreadPoolWorkItem.ExecuteWorkItem", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Task), Member = "ExecuteWithThreadLocal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MoveNextRunner), Member = "Run", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(ExecutionContext), Member = "RunInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExecutionContext), typeof(ContextCallback), typeof(object), typeof(bool)}, ReturnType = typeof(void))]
	[FriendAccessAllowed]
	internal static void Run(ExecutionContext executionContext, ContextCallback callback, object state, bool preserveSyncCtx) { }

	[CalledBy(Type = typeof(ExecutionContext), Member = "Run", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExecutionContext), typeof(ContextCallback), typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ExecutionContext), Member = "Run", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExecutionContext), typeof(ContextCallback), typeof(object), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ExecutionContext), Member = "RunInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExecutionContext), typeof(ContextCallback), typeof(object)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(LogicalCallContext), Member = "get_HasInfo", ReturnType = typeof(bool))]
	[Calls(Type = typeof(ExecutionContext), Member = "SetExecutionContext", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExecutionContext), typeof(bool)}, ReturnType = typeof(ExecutionContextSwitcher))]
	[Calls(Type = typeof(ExecutionContextSwitcher), Member = "Undo", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 10)]
	[ContainsUnimplementedInstructions]
	[HandleProcessCorruptedStateExceptions]
	internal static void RunInternal(ExecutionContext executionContext, ContextCallback callback, object state, bool preserveSyncCtx) { }

	[CalledBy(Type = "System.IO.Stream+ReadWriteTask", Member = "System.Threading.Tasks.ITaskCompletionAction.Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ExecutionContext), Member = "RunInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExecutionContext), typeof(ContextCallback), typeof(object), typeof(bool)}, ReturnType = typeof(void))]
	internal static void RunInternal(ExecutionContext executionContext, ContextCallback callback, object state) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	internal void set_IllogicalCallContext(IllogicalCallContext value) { }

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	internal void set_isFlowSuppressed(bool value) { }

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	internal void set_isNewCapture(bool value) { }

	[CallerCount(Count = 10)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	internal void set_LogicalCallContext(LogicalCallContext value) { }

	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::Success (2))]
	internal void set_SynchronizationContext(SynchronizationContext value) { }

	[CallerCount(Count = 9)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::Success (2))]
	internal void set_SynchronizationContextNoFlow(SynchronizationContext value) { }

	[CalledBy(Type = typeof(ExecutionContext), Member = "RunInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExecutionContext), typeof(ContextCallback), typeof(object), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ExecutionContext), Member = "OnAsyncLocalContextChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExecutionContext), typeof(ExecutionContext)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ExecutionContextSwitcher), Member = "UndoNoThrow", ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 11)]
	[ContainsUnimplementedInstructions]
	[HandleProcessCorruptedStateExceptions]
	internal static ExecutionContextSwitcher SetExecutionContext(ExecutionContext executionContext, bool preserveSyncCtx) { }

	[CalledBy(Type = "Plugins.WindowsPermissionSetup", Member = "get_UpdaterTempFile", ReturnType = typeof(FileInfo))]
	[CalledBy(Type = "UnityEngine.Awaitable", Member = "WireupCancellation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Awaitable", typeof(CancellationToken)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(AsyncFlowControl), Member = "Setup", ReturnType = typeof(void))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 8)]
	public static AsyncFlowControl SuppressFlow() { }

}

