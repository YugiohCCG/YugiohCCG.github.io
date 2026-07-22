namespace System.Threading;

public sealed class Thread : CriticalFinalizerObject
{
	[ThreadStatic]
	private static LocalDataStoreHolder s_LocalDataStore; //Field offset: 0x80000000
	[ThreadStatic]
	internal static CultureInfo m_CurrentCulture; //Field offset: 0x80000008
	[ThreadStatic]
	internal static CultureInfo m_CurrentUICulture; //Field offset: 0x80000010
	[ThreadStatic]
	private static Thread current_thread; //Field offset: 0x80000018
	private static LocalDataStoreMgr s_LocalDataStoreMgr; //Field offset: 0x0
	private static AsyncLocal<CultureInfo> s_asyncLocalCurrentCulture; //Field offset: 0x8
	private static AsyncLocal<CultureInfo> s_asyncLocalCurrentUICulture; //Field offset: 0x10
	private InternalThread internal_thread; //Field offset: 0x10
	private object m_ThreadStartArg; //Field offset: 0x18
	private object pending_exception; //Field offset: 0x20
	private MulticastDelegate m_Delegate; //Field offset: 0x28
	private ExecutionContext m_ExecutionContext; //Field offset: 0x30
	private bool m_ExecutionContextBelongsToOuterScope; //Field offset: 0x38
	private IPrincipal principal; //Field offset: 0x40
	private int principal_version; //Field offset: 0x48

	public static Context CurrentContext
	{
		[CallerCount(Count = 25)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 7
	}

	public CultureInfo CurrentCulture
	{
		[CalledBy(Type = typeof(NumberFormatInfo), Member = "GetInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(NumberFormatInfo))]
		[CalledBy(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo", ReturnType = typeof(NumberFormatInfo))]
		[CalledBy(Type = typeof(CultureInfo), Member = "get_CurrentCulture", ReturnType = typeof(CultureInfo))]
		[CalledBy(Type = "TMPro.TMP_InputField", Member = "Validate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(char)}, ReturnType = typeof(char))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(Thread), Member = "GetCurrentCultureNoAppX", ReturnType = typeof(CultureInfo))]
		 get { } //Length: 52
	}

	public static Thread CurrentThread
	{
		[CallerCount(Count = 55)]
		[CallsUnknownMethods(Count = 2)]
		[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::MayFail (1))]
		 get { } //Length: 78
	}

	internal static int CurrentThreadId
	{
		[CalledBy(Type = typeof(ReaderWriterLock), Member = "AcquireWriterLock", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ReaderWriterLock), Member = "ReleaseWriterLock", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ReaderWriterLock), Member = "HasWriterLock", ReturnType = typeof(bool))]
		[CallerCount(Count = 4)]
		[CallsUnknownMethods(Count = 3)]
		internal get { } //Length: 100
	}

	public CultureInfo CurrentUICulture
	{
		[CalledBy(Type = typeof(CultureInfo), Member = "get_CurrentUICulture", ReturnType = typeof(CultureInfo))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Thread), Member = "GetCurrentUICultureNoAppX", ReturnType = typeof(CultureInfo))]
		 get { } //Length: 52
	}

	internal bool ExecutionContextBelongsToCurrentScope
	{
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		internal get { } //Length: 8
		[CallerCount(Count = 0)]
		internal set { } //Length: 7
	}

	private InternalThread Internal
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		private get { } //Length: 41
	}

	public bool IsBackground
	{
		[CalledBy(Type = typeof(RuntimeThread), Member = "set_IsBackground", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = "System.Threading.Timer+Scheduler", Member = "InitScheduler", ReturnType = typeof(void))]
		[CalledBy(Type = "System.Threading.Timer+Scheduler", Member = ".ctor", ReturnType = typeof(void))]
		[CalledBy(Type = "System.Threading.Timer+Scheduler", Member = ".cctor", ReturnType = typeof(void))]
		[CalledBy(Type = "System.Net.TimerThread", Member = "ThreadProc", ReturnType = typeof(void))]
		[CallerCount(Count = 5)]
		[Calls(Type = typeof(ThreadStateException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 10)]
		 set { } //Length: 196
	}

	public bool IsThreadPoolThread
	{
		[CallerCount(Count = 2)]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		 get { } //Length: 48
	}

	internal bool IsThreadPoolThreadInternal
	{
		[CallerCount(Count = 2)]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		internal get { } //Length: 48
	}

	public int ManagedThreadId
	{
		[CallerCount(Count = 27)]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::Success (2))]
		 get { } //Length: 47
	}

	public string Name
	{
		[CalledBy(Type = "System.Threading.Timer+Scheduler", Member = "SchedulerThread", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(RuntimeHelpers), Member = "get_OffsetToStringData", ReturnType = typeof(int))]
		[CallsUnknownMethods(Count = 3)]
		 set { } //Length: 95
	}

	[CalledBy(Type = "System.Threading.Timer+Scheduler", Member = "InitScheduler", ReturnType = typeof(void))]
	[CalledBy(Type = "System.Threading.Timer+Scheduler", Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = "System.Threading.Timer+Scheduler", Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.TimerThread+TimerQueue", Member = "CreateTimer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Net.TimerThread+Callback", typeof(object)}, ReturnType = "System.Net.TimerThread+Timer")]
	[CalledBy(Type = "System.Net.TimerThread", Member = "Prod", ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(Thread), Member = "SetStartHelper", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public Thread(ThreadStart start) { }

	[CalledBy(Type = typeof(RuntimeThread), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParameterizedThreadStart), typeof(int)}, ReturnType = typeof(RuntimeThread))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Thread), Member = "SetStartHelper", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 9)]
	public Thread(ParameterizedThreadStart start, int maxStackSize) { }

	[CalledBy(Type = typeof(SpinLock), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Boolean&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SpinLock), Member = "TryEnter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Boolean&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SpinLock), Member = "ContinueTryEnter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Boolean&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SpinLock), Member = "ContinueTryEnterWithThreadTracking", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(uint), typeof(Boolean&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(WorkStealingQueue), Member = "LocalPop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IThreadPoolWorkItem&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(WorkStealingQueue), Member = "TrySteal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IThreadPoolWorkItem&), typeof(Boolean&), typeof(int)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 8)]
	[CallsUnknownMethods(Count = 6)]
	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::MayFail (1))]
	public static void BeginCriticalRegion() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private static void ClrState(InternalThread thread, ThreadState clr) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private void ConstructInternalThread() { }

	[CalledBy(Type = "System.Console+WindowsConsole", Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SpinLock), Member = "ContinueTryEnter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Boolean&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SpinLock), Member = "ContinueTryEnterWithThreadTracking", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(uint), typeof(Boolean&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SpinLock), Member = "Exit", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SpinLock), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 10)]
	[CallsUnknownMethods(Count = 6)]
	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::Success (2))]
	public static void EndCriticalRegion() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CriticalFinalizerObject), Member = "Finalize", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::Success (2))]
	protected virtual void Finalize() { }

	[CallerCount(Count = 25)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public static Context get_CurrentContext() { }

	[CalledBy(Type = typeof(NumberFormatInfo), Member = "GetInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(NumberFormatInfo))]
	[CalledBy(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo", ReturnType = typeof(NumberFormatInfo))]
	[CalledBy(Type = typeof(CultureInfo), Member = "get_CurrentCulture", ReturnType = typeof(CultureInfo))]
	[CalledBy(Type = "TMPro.TMP_InputField", Member = "Validate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(char)}, ReturnType = typeof(char))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Thread), Member = "GetCurrentCultureNoAppX", ReturnType = typeof(CultureInfo))]
	public CultureInfo get_CurrentCulture() { }

	[CallerCount(Count = 55)]
	[CallsUnknownMethods(Count = 2)]
	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::MayFail (1))]
	public static Thread get_CurrentThread() { }

	[CalledBy(Type = typeof(ReaderWriterLock), Member = "AcquireWriterLock", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ReaderWriterLock), Member = "ReleaseWriterLock", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ReaderWriterLock), Member = "HasWriterLock", ReturnType = typeof(bool))]
	[CallerCount(Count = 4)]
	[CallsUnknownMethods(Count = 3)]
	internal static int get_CurrentThreadId() { }

	[CalledBy(Type = typeof(CultureInfo), Member = "get_CurrentUICulture", ReturnType = typeof(CultureInfo))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Thread), Member = "GetCurrentUICultureNoAppX", ReturnType = typeof(CultureInfo))]
	public CultureInfo get_CurrentUICulture() { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	internal bool get_ExecutionContextBelongsToCurrentScope() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private InternalThread get_Internal() { }

	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public bool get_IsThreadPoolThread() { }

	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	internal bool get_IsThreadPoolThreadInternal() { }

	[CallerCount(Count = 27)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::Success (2))]
	public int get_ManagedThreadId() { }

	[CalledBy(Type = typeof(Thread), Member = "get_CurrentCulture", ReturnType = typeof(CultureInfo))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CultureInfo), Member = "get_DefaultThreadCurrentCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(CultureInfo), Member = "get_UserDefaultCulture", ReturnType = typeof(CultureInfo))]
	[CallsUnknownMethods(Count = 2)]
	private CultureInfo GetCurrentCultureNoAppX() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private static Thread GetCurrentThread() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private static void GetCurrentThread_icall(ref Thread thread) { }

	[CalledBy(Type = typeof(Thread), Member = "get_CurrentUICulture", ReturnType = typeof(CultureInfo))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CultureInfo), Member = "get_DefaultThreadCurrentUICulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(CultureInfo), Member = "get_UserDefaultUICulture", ReturnType = typeof(CultureInfo))]
	[CallsUnknownMethods(Count = 2)]
	internal CultureInfo GetCurrentUICultureNoAppX() { }

	[CalledBy(Type = typeof(AppDomain), Member = "IsFinalizingForUnload", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(AppDomain), Member = "getDomainID", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(Context), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Context), Member = "CreateNewContext", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IConstructionCallMessage)}, ReturnType = typeof(Context))]
	[CalledBy(Type = typeof(CrossAppDomainChannel), Member = "get_ChannelData", ReturnType = typeof(object))]
	[CalledBy(Type = typeof(CADMessageBase), Member = "MarshalArgument", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(ArrayList&)}, ReturnType = typeof(object))]
	[CallerCount(Count = 6)]
	[CallsUnknownMethods(Count = 1)]
	public static int GetDomainID() { }

	[CalledBy(Type = typeof(RemotingServices), Member = "SerializeCallData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(Byte[]))]
	[CalledBy(Type = typeof(CallContext), Member = "LogicalGetData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(object))]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::Success (2))]
	internal Reader GetExecutionContextReader() { }

	[CallerCount(Count = 27)]
	[CallsUnknownMethods(Count = 2)]
	[ComVisible(False)]
	[DeduplicatedMethod]
	public virtual int GetHashCode() { }

	[CalledBy(Type = typeof(AsyncFlowControl), Member = "Setup", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(AsyncFlowControl), Member = "Undo", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ExecutionContext), Member = "RestoreFlow", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SynchronizationContext), Member = "SetSynchronizationContext", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SynchronizationContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RemotingServices), Member = "InternalExecuteMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MarshalByRefObject), typeof(IMethodCallMessage)}, ReturnType = typeof(IMethodReturnMessage))]
	[CalledBy(Type = typeof(RemotingServices), Member = "DeserializeCallData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(RealProxy), Member = "PrivateInvoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RealProxy), typeof(IMessage), typeof(Exception&), typeof(Object[]&)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(CallContext), Member = "SetLogicalCallContext", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LogicalCallContext)}, ReturnType = typeof(LogicalCallContext))]
	[CalledBy(Type = typeof(CallContext), Member = "LogicalSetData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(void))]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(ExecutionContext), Member = "CreateMutableCopy", ReturnType = typeof(ExecutionContext))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::MayFail (1))]
	internal ExecutionContext GetMutableExecutionContext() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Environment), Member = "GetPageSize", ReturnType = typeof(int))]
	[Calls(Type = typeof(Math), Member = "Min", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private static int GetProcessDefaultStackSize(int maxStackSize) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private static ThreadState GetState(InternalThread thread) { }

	[CalledBy(Type = typeof(Interlocked), Member = "MemoryBarrier", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CultureInfo), Member = "get_DateTimeFormat", ReturnType = typeof(DateTimeFormatInfo))]
	[CalledBy(Type = "System.Xml.XmlCharType", Member = "InitInstance", ReturnType = typeof(void))]
	[CalledBy(Type = "System.Xml.Linq.XHashtable`1+XHashtableState", Member = "TryAdd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TValue", "TValue&"}, ReturnType = typeof(bool))]
	[CalledBy(Type = "System.Xml.Linq.XHashtable`1", Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, ReturnType = "TValue")]
	[CallerCount(Count = 5)]
	[CallsUnknownMethods(Count = 1)]
	public static void MemoryBarrier() { }

	[CallerCount(Count = 0)]
	internal void set_ExecutionContextBelongsToCurrentScope(bool value) { }

	[CalledBy(Type = typeof(RuntimeThread), Member = "set_IsBackground", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Threading.Timer+Scheduler", Member = "InitScheduler", ReturnType = typeof(void))]
	[CalledBy(Type = "System.Threading.Timer+Scheduler", Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = "System.Threading.Timer+Scheduler", Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.TimerThread", Member = "ThreadProc", ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(ThreadStateException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 10)]
	public void set_IsBackground(bool value) { }

	[CalledBy(Type = "System.Threading.Timer+Scheduler", Member = "SchedulerThread", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(RuntimeHelpers), Member = "get_OffsetToStringData", ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 3)]
	public void set_Name(string value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::Success (2))]
	internal void SetExecutionContext(Reader value, bool belongsToCurrentScope) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::Success (2))]
	internal void SetExecutionContext(ExecutionContext value, bool belongsToCurrentScope) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private static void SetName_icall(InternalThread thread, Char* name, int nameLength) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RuntimeHelpers), Member = "get_OffsetToStringData", ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 2)]
	private static void SetName_internal(InternalThread thread, string name) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 3)]
	private void SetStart(MulticastDelegate start, int maxStackSize) { }

	[CalledBy(Type = typeof(Thread), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ThreadStart)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Thread), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParameterizedThreadStart), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Environment), Member = "GetPageSize", ReturnType = typeof(int))]
	[Calls(Type = typeof(Math), Member = "Min", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 12)]
	[ContainsUnimplementedInstructions]
	private void SetStartHelper(Delegate start, int maxStackSize) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private static void SetState(InternalThread thread, ThreadState set) { }

	[CalledBy(Type = typeof(RuntimeThread), Member = "Sleep", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.TimerThread", Member = "ThreadProc", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UnitySynchronizationContext", Member = "ExecutePendingTasks", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "System.Threading.ReaderWriterLockSlim", Member = "EnterMyLockSpin", ReturnType = typeof(void))]
	[CalledBy(Type = "System.Threading.ReaderWriterLockSlim", Member = "SpinWait", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	public static void Sleep(int millisecondsTimeout) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private static void SleepInternal(int millisecondsTimeout) { }

	[CalledBy(Type = typeof(RuntimeThread), Member = "SpinWait", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "System.Net.LazyAsyncResult", Member = "WaitForCompletion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(object))]
	[CalledBy(Type = "System.Threading.ReaderWriterLockSlim", Member = "EnterMyLockSpin", ReturnType = typeof(void))]
	[CalledBy(Type = "System.Threading.ReaderWriterLockSlim", Member = "SpinWait", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::Success (2))]
	public static void SpinWait(int iterations) { }

	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	private static void SpinWait_nop() { }

	[CalledBy(Type = typeof(Thread), Member = "Start", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Thread), Member = "Start", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ExecutionContext), Member = "Capture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StackCrawlMark&), typeof(CaptureOptions)}, ReturnType = typeof(ExecutionContext))]
	[Calls(Type = typeof(SystemException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 9)]
	private void Start(ref StackCrawlMark stackMark) { }

	[CalledBy(Type = typeof(RuntimeThread), Member = "Start", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Thread), Member = "Start", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StackCrawlMark&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	public void Start(object parameter) { }

	[CalledBy(Type = "System.Threading.Timer+Scheduler", Member = "InitScheduler", ReturnType = typeof(void))]
	[CalledBy(Type = "System.Threading.Timer+Scheduler", Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = "System.Threading.Timer+Scheduler", Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.TimerThread+TimerQueue", Member = "CreateTimer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Net.TimerThread+Callback", typeof(object)}, ReturnType = "System.Net.TimerThread+Timer")]
	[CalledBy(Type = "System.Net.TimerThread", Member = "Prod", ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(Thread), Member = "Start", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StackCrawlMark&)}, ReturnType = typeof(void))]
	public void Start() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SystemException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 6)]
	private void StartInternal(object principal, ref StackCrawlMark stackMark) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private static int SystemMaxStackStize() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private bool Thread_internal(MulticastDelegate start) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ThreadStateException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 6)]
	private ThreadState ValidateThreadState() { }

	[CalledBy(Type = "SQLite.SQLiteConnection", Member = "DoSavePointExecute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static void VolatileWrite(ref int address, int value) { }

	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public static bool Yield() { }

	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	private static bool YieldInternal() { }

}

