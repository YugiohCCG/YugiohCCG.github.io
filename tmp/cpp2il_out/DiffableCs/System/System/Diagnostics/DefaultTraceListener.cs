namespace System.Diagnostics;

public class DefaultTraceListener : TraceListener
{
	private static readonly bool OnWin32; //Field offset: 0x0
	private static readonly string MonoTracePrefix; //Field offset: 0x8
	private static readonly string MonoTraceFile; //Field offset: 0x10
	private string logFileName; //Field offset: 0x38

	[MonoTODO]
	public string LogFileName
	{
		[CallerCount(Count = 38)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Environment), Member = "GetEnvironmentVariable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "StartsWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	private static DefaultTraceListener() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public DefaultTraceListener() { }

	[CallerCount(Count = 38)]
	[DeduplicatedMethod]
	public string get_LogFileName() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 1)]
	private static string GetPrefix(string var, string target) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DefaultTraceListener), Member = "WriteImpl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	public virtual void Write(string message) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DefaultTraceListener), Member = "WriteMonoTrace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RuntimeHelpers), Member = "get_OffsetToStringData", ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 1)]
	private void WriteDebugString(string message) { }

	[CalledBy(Type = typeof(DefaultTraceListener), Member = "Write", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DefaultTraceListener), Member = "WriteLine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(DefaultTraceListener), Member = "WriteMonoTrace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RuntimeHelpers), Member = "get_OffsetToStringData", ReturnType = typeof(int))]
	[Calls(Type = typeof(Debugger), Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsInvalidInstructions]
	private void WriteImpl(string message) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Environment), Member = "get_NewLine", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(DefaultTraceListener), Member = "WriteImpl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	public virtual void WriteLine(string message) { }

	[CalledBy(Type = typeof(DefaultTraceListener), Member = "WriteMonoTrace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(FileInfo), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FileInfo), Member = "CreateText", ReturnType = typeof(StreamWriter))]
	[Calls(Type = typeof(FileInfo), Member = "AppendText", ReturnType = typeof(StreamWriter))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 5)]
	private void WriteLogFile(string message, string logFile) { }

	[CalledBy(Type = typeof(DefaultTraceListener), Member = "WriteDebugString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DefaultTraceListener), Member = "WritePrefix", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DefaultTraceListener), Member = "WriteImpl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(DefaultTraceListener), Member = "WriteLogFile", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	private void WriteMonoTrace(string message) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DefaultTraceListener), Member = "WriteMonoTrace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	private void WritePrefix() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private static void WriteWindowsDebugString(Char* message) { }

}

