namespace UnityEngine;

public class Logger : ILogger, ILogHandler
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private ILogHandler <logHandler>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private bool <logEnabled>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private LogType <filterLogType>k__BackingField; //Field offset: 0x1C

	public override LogType filterLogType
	{
		[CallerCount(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 4
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	public override bool logEnabled
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	public override ILogHandler logHandler
	{
		[CallerCount(Count = 106)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 13
	}

	[CalledBy(Type = typeof(Debug), Member = ".cctor", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public Logger(ILogHandler logHandler) { }

	[CallerCount(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public override LogType get_filterLogType() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public override bool get_logEnabled() { }

	[CallerCount(Count = 106)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public override ILogHandler get_logHandler() { }

	[CalledBy(Type = typeof(Logger), Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LogType), typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Logger), Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LogType), typeof(object), typeof(Object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Logger), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	private static string GetString(object message) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public override bool IsLogTypeAllowed(LogType logType) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Logger), Member = "GetString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 7)]
	public override void Log(LogType logType, object message) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Logger), Member = "GetString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 7)]
	public override void Log(LogType logType, object message, object context) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Logger), Member = "GetString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 11)]
	public override void LogError(string tag, object message) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public override void LogException(Exception exception, object context) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public override void LogFormat(LogType logType, string format, Object[] args) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public override void LogFormat(LogType logType, object context, string format, Object[] args) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public override void set_filterLogType(LogType value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public override void set_logEnabled(bool value) { }

	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public override void set_logHandler(ILogHandler value) { }

}

