namespace System.Diagnostics;

public class TraceEventCache
{
	private static int processId; //Field offset: 0x0
	private static string processName; //Field offset: 0x8
	private long timeStamp; //Field offset: 0x10
	private DateTime dateTime; //Field offset: 0x18
	private string stackTrace; //Field offset: 0x20

	public string Callstack
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Environment), Member = "get_StackTrace", ReturnType = typeof(string))]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 59
	}

	public DateTime DateTime
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(DateTime), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(DateTime)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(DateTime), Member = "get_UtcNow", ReturnType = typeof(DateTime))]
		 get { } //Length: 149
	}

	public Stack LogicalOperationStack
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CallContext), Member = "LogicalGetData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(object))]
		[Calls(Type = typeof(Stack), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CallContext), Member = "LogicalSetData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 5)]
		 get { } //Length: 331
	}

	public int ProcessId
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(TraceEventCache), Member = "InitProcessInfo", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 70
	}

	public string ThreadId
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Thread), Member = "get_CurrentThread", ReturnType = typeof(Thread))]
		[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[Calls(Type = typeof(int), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(string))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 120
	}

	public long Timestamp
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 84
	}

	[CalledBy(Type = "Newtonsoft.Json.Serialization.DiagnosticsTraceWriter", Member = "Trace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TraceLevel), typeof(string), typeof(Exception)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	public TraceEventCache() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Environment), Member = "get_StackTrace", ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 1)]
	public string get_Callstack() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DateTime), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(DateTime)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DateTime), Member = "get_UtcNow", ReturnType = typeof(DateTime))]
	public DateTime get_DateTime() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CallContext), Member = "LogicalGetData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(Stack), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CallContext), Member = "LogicalSetData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	public Stack get_LogicalOperationStack() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TraceEventCache), Member = "InitProcessInfo", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public int get_ProcessId() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Thread), Member = "get_CurrentThread", ReturnType = typeof(Thread))]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(int), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public string get_ThreadId() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public long get_Timestamp() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TraceEventCache), Member = "InitProcessInfo", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	internal static int GetProcessId() { }

	[CallerCount(Count = 332)]
	[Calls(Type = typeof(Thread), Member = "get_CurrentThread", ReturnType = typeof(Thread))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	internal static int GetThreadId() { }

	[CalledBy(Type = typeof(TraceEventCache), Member = "get_ProcessId", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(TraceEventCache), Member = "GetProcessId", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(TraceListener), Member = "WriteFooter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TraceEventCache)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Process), Member = "GetCurrentProcess", ReturnType = typeof(Process))]
	[Calls(Type = typeof(Process), Member = "EnsureState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Diagnostics.Process+State"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Process), Member = "get_ProcessName", ReturnType = typeof(string))]
	[Calls(Type = typeof(Component), Member = "Dispose", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 9)]
	private static void InitProcessInfo() { }

}

