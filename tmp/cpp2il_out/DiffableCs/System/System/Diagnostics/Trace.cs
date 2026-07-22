namespace System.Diagnostics;

public sealed class Trace
{
	private static CorrelationManager correlationManager; //Field offset: 0x0

	public static bool AutoFlush
	{
		[CalledBy(Type = "Newtonsoft.Json.Serialization.DiagnosticsTraceWriter", Member = "Trace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TraceLevel), typeof(string), typeof(Exception)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 136
	}

	public static CorrelationManager CorrelationManager
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 4)]
		 get { } //Length: 173
	}

	public static TraceListenerCollection Listeners
	{
		[CalledBy(Type = "Newtonsoft.Json.Serialization.DiagnosticsTraceWriter", Member = "Trace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TraceLevel), typeof(string), typeof(Exception)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(TraceInternal), Member = "get_Listeners", ReturnType = typeof(TraceListenerCollection))]
		 get { } //Length: 64
	}

	[CalledBy(Type = "Newtonsoft.Json.Serialization.DiagnosticsTraceWriter", Member = "Trace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TraceLevel), typeof(string), typeof(Exception)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static bool get_AutoFlush() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public static CorrelationManager get_CorrelationManager() { }

	[CalledBy(Type = "Newtonsoft.Json.Serialization.DiagnosticsTraceWriter", Member = "Trace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TraceLevel), typeof(string), typeof(Exception)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TraceInternal), Member = "get_Listeners", ReturnType = typeof(TraceListenerCollection))]
	public static TraceListenerCollection get_Listeners() { }

}

