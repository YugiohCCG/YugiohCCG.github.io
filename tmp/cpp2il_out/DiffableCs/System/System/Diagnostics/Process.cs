namespace System.Diagnostics;

[DefaultEvent("Exited")]
[DefaultProperty("StartInfo")]
[MonitoringDescription("Provides access to local and remote processes, enabling starting and stopping of local processes.")]
public class Process : Component
{
	private struct ProcInfo
	{
		public IntPtr process_handle; //Field offset: 0x0
		public int pid; //Field offset: 0x8
		public String[] envVariables; //Field offset: 0x10
		public string UserName; //Field offset: 0x18
		public string Domain; //Field offset: 0x20
		public IntPtr Password; //Field offset: 0x28
		public bool LoadUserProfile; //Field offset: 0x30

	}

	private enum State
	{
		HaveId = 1,
		IsLocal = 2,
		IsNt = 4,
		HaveProcessInfo = 8,
		Exited = 16,
		Associated = 32,
		IsWin2k = 64,
		HaveNtProcessInfo = 12,
	}

	private enum StreamReadMode
	{
		undefined = 0,
		syncMode = 1,
		asyncMode = 2,
	}

	private bool haveProcessId; //Field offset: 0x28
	private int processId; //Field offset: 0x2C
	private bool haveProcessHandle; //Field offset: 0x30
	private SafeProcessHandle m_processHandle; //Field offset: 0x38
	private bool isRemoteMachine; //Field offset: 0x40
	private string machineName; //Field offset: 0x48
	private int m_processAccess; //Field offset: 0x50
	private ProcessThreadCollection threads; //Field offset: 0x58
	private ProcessModuleCollection modules; //Field offset: 0x60
	private bool haveWorkingSetLimits; //Field offset: 0x68
	private bool havePriorityClass; //Field offset: 0x69
	private ProcessStartInfo startInfo; //Field offset: 0x70
	private bool watchForExit; //Field offset: 0x78
	private bool watchingForExit; //Field offset: 0x79
	private EventHandler onExited; //Field offset: 0x80
	private bool exited; //Field offset: 0x88
	private int exitCode; //Field offset: 0x8C
	private bool signaled; //Field offset: 0x90
	private bool haveExitTime; //Field offset: 0x91
	private bool raisedOnExited; //Field offset: 0x92
	private RegisteredWaitHandle registeredWaitHandle; //Field offset: 0x98
	private WaitHandle waitHandle; //Field offset: 0xA0
	private ISynchronizeInvoke synchronizingObject; //Field offset: 0xA8
	private StreamReader standardOutput; //Field offset: 0xB0
	private StreamWriter standardInput; //Field offset: 0xB8
	private StreamReader standardError; //Field offset: 0xC0
	private bool disposed; //Field offset: 0xC8
	private StreamReadMode outputStreamReadMode; //Field offset: 0xCC
	private StreamReadMode errorStreamReadMode; //Field offset: 0xD0
	private StreamReadMode inputStreamReadMode; //Field offset: 0xD4
	internal AsyncStreamReader output; //Field offset: 0xD8
	internal AsyncStreamReader error; //Field offset: 0xE0
	private string process_name; //Field offset: 0xE8

	[Browsable(False)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility::Hidden (0))]
	[MonitoringDescription("Indicates if the process component is associated with a real process.")]
	private bool Associated
	{
		[CallerCount(Count = 0)]
		private get { } //Length: 13
	}

	[Browsable(False)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility::Hidden (0))]
	[MonitoringDescription("Returns the native handle for this process.   The handle is only available if the process was started using this component.")]
	public IntPtr Handle
	{
		[CalledBy(Type = typeof(Process), Member = "CreatePipe", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr&), typeof(IntPtr&), typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Process), Member = "EnsureState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(State)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Process), Member = "GetProcessHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(SafeProcessHandle))]
		[Calls(Type = typeof(Process), Member = "EnsureWatchingForExit", ReturnType = typeof(void))]
		[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
		[Calls(Type = typeof(ObjectDisposedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 7)]
		 get { } //Length: 219
	}

	[Browsable(False)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility::Hidden (0))]
	[MonitoringDescription("Indicates if the associated process has been terminated.")]
	public bool HasExited
	{
		[CalledBy(Type = typeof(Process), Member = "EnsureState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(State)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Process), Member = "EnsureState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(State)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Process), Member = "GetProcessHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(SafeProcessHandle))]
		[Calls(Type = typeof(NativeMethods), Member = "GetExitCodeProcess", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SafeProcessHandle), typeof(Int32&)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Process), Member = "RaiseOnExited", ReturnType = typeof(void))]
		[Calls(Type = typeof(ProcessWaitHandle), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SafeProcessHandle)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Win32Exception), Member = ".ctor", ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 6)]
		[CallsUnknownMethods(Count = 8)]
		 get { } //Length: 813
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility::Hidden (0))]
	[MonitoringDescription("The unique identifier for the process.")]
	public int Id
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Process), Member = "EnsureState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(State)}, ReturnType = typeof(void))]
		 get { } //Length: 31
	}

	private static bool IsWindows
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Environment), Member = "get_OSVersion", ReturnType = typeof(OperatingSystem))]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		private get { } //Length: 47
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility::Hidden (0))]
	[MonitoringDescription("The name of this process.")]
	public string ProcessName
	{
		[CalledBy(Type = "Mono.Nat.Upnp.CreatePortMappingMessage", Member = "CreateDefaultDescription", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Mono.Nat.Mapping"}, ReturnType = typeof(string))]
		[CalledBy(Type = typeof(TraceEventCache), Member = "InitProcessInfo", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Process), Member = "ToString", ReturnType = typeof(string))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(Process), Member = "GetProcessHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(SafeProcessHandle))]
		[Calls(Type = typeof(Process), Member = "ProcessName_internal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SafeProcessHandle)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(string), Member = "EndsWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 10)]
		 get { } //Length: 576
	}

	[Browsable(False)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility::Content (2))]
	[MonitoringDescription("Specifies information used to start a process.")]
	public ProcessStartInfo StartInfo
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(WeakReference), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		 get { } //Length: 202
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 5)]
		 set { } //Length: 108
	}

	[Browsable(False)]
	[DefaultValue(null)]
	[MonitoringDescription("The object used to marshal the event handler calls issued as a result of a Process exit.")]
	public ISynchronizeInvoke SynchronizingObject
	{
		[CalledBy(Type = typeof(Process), Member = "OnExited", ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(Component), Member = "get_DesignMode", ReturnType = typeof(bool))]
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 9)]
		 get { } //Length: 371
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public Process() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private Process(string machineName, bool isRemoteMachine, int processId, ProcessInfo processInfo) { }

	[CalledBy(Type = typeof(Process), Member = "Dispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Process), Member = "Start", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Process), Member = "Start", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ProcessStartInfo)}, ReturnType = typeof(Process))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Process), Member = "StopWatchingForExit", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 10)]
	public void Close() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Process), Member = "StopWatchingForExit", ReturnType = typeof(void))]
	[Calls(Type = typeof(Process), Member = "RaiseOnExited", ReturnType = typeof(void))]
	private void CompletionCallback(object context, bool wasSignaled) { }

	[CalledBy(Type = typeof(Process), Member = "StartWithCreateProcess", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ProcessStartInfo)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 3)]
	[Calls(Type = "System.IO.MonoIO", Member = "CreatePipe", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr&), typeof(IntPtr&), typeof(MonoIOError&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Environment), Member = "get_OSVersion", ReturnType = typeof(OperatingSystem))]
	[Calls(Type = typeof(Process), Member = "GetCurrentProcess", ReturnType = typeof(Process))]
	[Calls(Type = typeof(Process), Member = "get_Handle", ReturnType = typeof(IntPtr))]
	[Calls(Type = "System.IO.MonoIO", Member = "DuplicateHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(IntPtr), typeof(IntPtr), typeof(IntPtr&), typeof(int), typeof(int), typeof(int), typeof(MonoIOError&)}, ReturnType = typeof(bool))]
	[Calls(Type = "System.IO.MonoIO", Member = "Close", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(MonoIOError&)}, ReturnType = typeof(bool))]
	[Calls(Type = "System.IO.MonoIO", Member = "GetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.IO.MonoIOError"}, ReturnType = typeof(Exception))]
	[CallsUnknownMethods(Count = 17)]
	private static void CreatePipe(out IntPtr read, out IntPtr write, bool writeDirection) { }

	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	private static bool CreateProcess_internal(ProcessStartInfo startInfo, IntPtr stdin, IntPtr stdout, IntPtr stderr, ref ProcInfo procInfo) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Process), Member = "Close", ReturnType = typeof(void))]
	[Calls(Type = typeof(Component), Member = "Dispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	protected virtual void Dispose(bool disposing) { }

	[CalledBy(Type = typeof(TraceEventCache), Member = "InitProcessInfo", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Process), Member = "get_HasExited", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Process), Member = "get_Handle", ReturnType = typeof(IntPtr))]
	[CalledBy(Type = typeof(Process), Member = "get_Id", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(Process), Member = "EnsureState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(State)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Process), Member = "GetProcessHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(SafeProcessHandle))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(Process), Member = "get_HasExited", ReturnType = typeof(bool))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Process), Member = "EnsureState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(State)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 24)]
	private void EnsureState(State state) { }

	[CalledBy(Type = typeof(Process), Member = "get_Handle", ReturnType = typeof(IntPtr))]
	[CalledBy(Type = typeof(Process), Member = "OpenProcessHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(SafeProcessHandle))]
	[CalledBy(Type = typeof(Process), Member = "SetProcessHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SafeProcessHandle)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Process), Member = "StartWithShellExecuteEx", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ProcessStartInfo)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Process), Member = "StartWithCreateProcess", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ProcessStartInfo)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ProcessWaitHandle), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SafeProcessHandle)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	private void EnsureWatchingForExit() { }

	[CalledBy(Type = typeof(Process), Member = "StartWithShellExecuteEx", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ProcessStartInfo)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Process), Member = "StartWithCreateProcess", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ProcessStartInfo)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Marshal), Member = "SecureStringToBSTR", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SecureString)}, ReturnType = typeof(IntPtr))]
	[CallsUnknownMethods(Count = 3)]
	private static void FillUserInfo(ProcessStartInfo startInfo, ref ProcInfo procInfo) { }

	[CallerCount(Count = 0)]
	private bool get_Associated() { }

	[CalledBy(Type = typeof(Process), Member = "CreatePipe", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr&), typeof(IntPtr&), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Process), Member = "EnsureState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(State)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Process), Member = "GetProcessHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(SafeProcessHandle))]
	[Calls(Type = typeof(Process), Member = "EnsureWatchingForExit", ReturnType = typeof(void))]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(ObjectDisposedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 7)]
	public IntPtr get_Handle() { }

	[CalledBy(Type = typeof(Process), Member = "EnsureState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(State)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Process), Member = "EnsureState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(State)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Process), Member = "GetProcessHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(SafeProcessHandle))]
	[Calls(Type = typeof(NativeMethods), Member = "GetExitCodeProcess", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SafeProcessHandle), typeof(Int32&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Process), Member = "RaiseOnExited", ReturnType = typeof(void))]
	[Calls(Type = typeof(ProcessWaitHandle), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SafeProcessHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Win32Exception), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 8)]
	public bool get_HasExited() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Process), Member = "EnsureState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(State)}, ReturnType = typeof(void))]
	public int get_Id() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Environment), Member = "get_OSVersion", ReturnType = typeof(OperatingSystem))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private static bool get_IsWindows() { }

	[CalledBy(Type = "Mono.Nat.Upnp.CreatePortMappingMessage", Member = "CreateDefaultDescription", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Mono.Nat.Mapping"}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(TraceEventCache), Member = "InitProcessInfo", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Process), Member = "ToString", ReturnType = typeof(string))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Process), Member = "GetProcessHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(SafeProcessHandle))]
	[Calls(Type = typeof(Process), Member = "ProcessName_internal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SafeProcessHandle)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "EndsWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 10)]
	public string get_ProcessName() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(WeakReference), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public ProcessStartInfo get_StartInfo() { }

	[CalledBy(Type = typeof(Process), Member = "OnExited", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Component), Member = "get_DesignMode", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 9)]
	public ISynchronizeInvoke get_SynchronizingObject() { }

	[CalledBy(Type = "Mono.Nat.Upnp.CreatePortMappingMessage", Member = "CreateDefaultDescription", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Mono.Nat.Mapping"}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(TraceEventCache), Member = "InitProcessInfo", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Process), Member = "CreatePipe", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr&), typeof(IntPtr&), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(NativeMethods), Member = "GetCurrentProcessId", ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static Process GetCurrentProcess() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Process), Member = "GetProcessHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(SafeProcessHandle))]
	private SafeProcessHandle GetProcessHandle(int access) { }

	[CalledBy(Type = typeof(Process), Member = "get_HasExited", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Process), Member = "get_Handle", ReturnType = typeof(IntPtr))]
	[CalledBy(Type = typeof(Process), Member = "GetProcessHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(SafeProcessHandle))]
	[CalledBy(Type = typeof(Process), Member = "OpenProcessHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(SafeProcessHandle))]
	[CalledBy(Type = typeof(Process), Member = "get_ProcessName", ReturnType = typeof(string))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(NativeMethods), Member = "DuplicateHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HandleRef), typeof(HandleRef), typeof(HandleRef), typeof(SafeProcessHandle&), typeof(int), typeof(bool), typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = "SR", Member = "GetString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(int), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CultureInfo), Member = "get_CurrentCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(NativeMethods), Member = "GetCurrentProcess", ReturnType = typeof(IntPtr))]
	[Calls(Type = typeof(Win32Exception), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(Process), Member = "EnsureState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(State)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NativeMethods), Member = "GetExitCodeProcess", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SafeProcessHandle), typeof(Int32&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ProcessWaitHandle), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SafeProcessHandle)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 16)]
	[ContainsUnimplementedInstructions]
	private SafeProcessHandle GetProcessHandle(int access, bool throwIfExited) { }

	[CalledBy(Type = typeof(Process), Member = "RaiseOnExited", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Process), Member = "get_SynchronizingObject", ReturnType = typeof(ISynchronizeInvoke))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 12)]
	protected void OnExited() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Process), Member = "GetProcessHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(SafeProcessHandle))]
	[Calls(Type = typeof(Process), Member = "EnsureWatchingForExit", ReturnType = typeof(void))]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(ObjectDisposedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 6)]
	private SafeProcessHandle OpenProcessHandle(int access) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private static string ProcessName_icall(IntPtr handle) { }

	[CalledBy(Type = typeof(Process), Member = "get_ProcessName", ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SafeHandle), Member = "DangerousAddRef", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SafeHandle), Member = "DangerousRelease", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 6)]
	private static string ProcessName_internal(SafeProcessHandle handle) { }

	[CalledBy(Type = typeof(Process), Member = "get_HasExited", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Process), Member = "CompletionCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Process), Member = "OnExited", ReturnType = typeof(void))]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private void RaiseOnExited() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public void Refresh() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private void ReleaseProcessHandle(SafeProcessHandle handle) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	public void set_StartInfo(ProcessStartInfo value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Process), Member = "EnsureWatchingForExit", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private void SetProcessHandle(SafeProcessHandle processHandle) { }

	[CallerCount(Count = 0)]
	private void SetProcessId(int processId) { }

	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	private static bool ShellExecuteEx_internal(ProcessStartInfo startInfo, ref ProcInfo procInfo) { }

	[CalledBy(Type = "Plugins.WindowsPermissionSetup", Member = "LaunchAsAdmin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FileInfo), typeof(string)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Process), Member = "Close", ReturnType = typeof(void))]
	[Calls(Type = typeof(WeakReference), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Process), Member = "StartWithCreateProcess", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ProcessStartInfo)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Process), Member = "StartWithShellExecuteEx", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ProcessStartInfo)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 13)]
	public static Process Start(ProcessStartInfo startInfo) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Process), Member = "Close", ReturnType = typeof(void))]
	[Calls(Type = typeof(WeakReference), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Process), Member = "StartWithCreateProcess", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ProcessStartInfo)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Process), Member = "StartWithShellExecuteEx", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ProcessStartInfo)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 7)]
	public bool Start() { }

	[CalledBy(Type = typeof(Process), Member = "Start", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Process), Member = "Start", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ProcessStartInfo)}, ReturnType = typeof(Process))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ObjectDisposedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(Win32Exception), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Win32Exception), Member = "GetErrorMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StreamReader), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(Encoding), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StreamWriter), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(Encoding)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FileStream), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(FileAccess), typeof(bool), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Encoding), Member = "get_Default", ReturnType = typeof(Encoding))]
	[Calls(Type = "System.IO.MonoIO", Member = "Close", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(MonoIOError&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Process), Member = "EnsureWatchingForExit", ReturnType = typeof(void))]
	[Calls(Type = typeof(SafeProcessHandle), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Process), Member = "FillUserInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ProcessStartInfo), typeof(ProcInfo&)}, ReturnType = typeof(void))]
	[Calls(Type = "System.IO.MonoIO", Member = "get_ConsoleError", ReturnType = typeof(IntPtr))]
	[Calls(Type = "System.IO.MonoIO", Member = "get_ConsoleOutput", ReturnType = typeof(IntPtr))]
	[Calls(Type = typeof(Process), Member = "CreatePipe", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr&), typeof(IntPtr&), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = "System.IO.MonoIO", Member = "get_ConsoleInput", ReturnType = typeof(IntPtr))]
	[Calls(Type = typeof(PasteArguments), Member = "AppendArgument", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Collection`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.IEnumerator`1<T>")]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(Collection`1), Member = "get_Count", ReturnType = typeof(int))]
	[Calls(Type = typeof(ProcessStartInfo), Member = "get_ArgumentList", ReturnType = typeof(System.Collections.ObjectModel.Collection`1<System.String>))]
	[Calls(Type = typeof(List`1), Member = "ToArray", ReturnType = "T[]")]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ProcessStartInfo), Member = "get_EnvironmentVariables", ReturnType = typeof(StringDictionary))]
	[Calls(Type = typeof(Marshal), Member = "ZeroFreeBSTR", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 19)]
	[CallsUnknownMethods(Count = 87)]
	private bool StartWithCreateProcess(ProcessStartInfo startInfo) { }

	[CalledBy(Type = typeof(Process), Member = "Start", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Process), Member = "Start", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ProcessStartInfo)}, ReturnType = typeof(Process))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Process), Member = "FillUserInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ProcessStartInfo), typeof(ProcInfo&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Marshal), Member = "ZeroFreeBSTR", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SafeProcessHandle), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Process), Member = "EnsureWatchingForExit", ReturnType = typeof(void))]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(ObjectDisposedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Win32Exception), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 32)]
	private bool StartWithShellExecuteEx(ProcessStartInfo startInfo) { }

	[CalledBy(Type = typeof(Process), Member = "CompletionCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Process), Member = "Close", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RegisteredWaitHandle), Member = "Unregister", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WaitHandle)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	private void StopWatchingForExit() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Process), Member = "get_ProcessName", ReturnType = typeof(string))]
	[Calls(Type = typeof(Component), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(CultureInfo), Member = "get_CurrentCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider), typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 1)]
	public virtual string ToString() { }

}

