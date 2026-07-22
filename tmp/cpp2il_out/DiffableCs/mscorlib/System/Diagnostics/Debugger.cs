namespace System.Diagnostics;

[ComVisible(True)]
public sealed class Debugger
{
	public static readonly string DefaultCategory; //Field offset: 0x0

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private static Debugger() { }

	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	public static bool IsLogging() { }

	[CalledBy(Type = "System.Diagnostics.DefaultTraceListener", Member = "WriteImpl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	public static void Log(int level, string category, string message) { }

	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	private static void Log_icall(int level, ref string category, ref string message) { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	public static void NotifyOfCrossThreadDependency() { }

}

