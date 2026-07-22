namespace System.Runtime.Remoting.Messaging;

[ComVisible(True)]
public sealed class CallContext
{

	[CallerCount(Count = 2180)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	private CallContext() { }

	[CalledBy(Type = "System.Diagnostics.CorrelationManager", Member = "get_LogicalOperationStack", ReturnType = typeof(Stack))]
	[CalledBy(Type = "System.Diagnostics.CorrelationManager", Member = "GetLogicalOperationStack", ReturnType = typeof(Stack))]
	[CalledBy(Type = "System.Diagnostics.TraceEventCache", Member = "get_LogicalOperationStack", ReturnType = typeof(Stack))]
	[CalledBy(Type = "System.Diagnostics.TraceListener", Member = "WriteFooter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Diagnostics.TraceEventCache"}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Thread), Member = "get_CurrentThread", ReturnType = typeof(Thread))]
	[Calls(Type = typeof(Thread), Member = "GetExecutionContextReader", ReturnType = typeof(Reader))]
	[Calls(Type = typeof(Reader), Member = "get_LogicalCallContext", ReturnType = typeof(Reader))]
	[Calls(Type = typeof(Hashtable), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static object LogicalGetData(string name) { }

	[CalledBy(Type = "System.Diagnostics.CorrelationManager", Member = "get_LogicalOperationStack", ReturnType = typeof(Stack))]
	[CalledBy(Type = "System.Diagnostics.CorrelationManager", Member = "GetLogicalOperationStack", ReturnType = typeof(Stack))]
	[CalledBy(Type = "System.Diagnostics.TraceEventCache", Member = "get_LogicalOperationStack", ReturnType = typeof(Stack))]
	[CalledBy(Type = "System.Diagnostics.TraceListener", Member = "WriteFooter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Diagnostics.TraceEventCache"}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Thread), Member = "get_CurrentThread", ReturnType = typeof(Thread))]
	[Calls(Type = typeof(Thread), Member = "GetMutableExecutionContext", ReturnType = typeof(ExecutionContext))]
	[Calls(Type = typeof(ExecutionContext), Member = "get_IllogicalCallContext", ReturnType = typeof(IllogicalCallContext))]
	[Calls(Type = typeof(Hashtable), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(ExecutionContext), Member = "get_LogicalCallContext", ReturnType = typeof(LogicalCallContext))]
	[Calls(Type = typeof(string), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public static void LogicalSetData(string name, object data) { }

	[CallerCount(Count = 182)]
	[DeduplicatedMethod]
	internal static object SetCurrentCallContext(LogicalCallContext ctx) { }

	[CalledBy(Type = typeof(RemotingServices), Member = "InternalExecuteMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MarshalByRefObject), typeof(IMethodCallMessage)}, ReturnType = typeof(IMethodReturnMessage))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Thread), Member = "get_CurrentThread", ReturnType = typeof(Thread))]
	[Calls(Type = typeof(Thread), Member = "GetMutableExecutionContext", ReturnType = typeof(ExecutionContext))]
	[Calls(Type = typeof(ExecutionContext), Member = "get_LogicalCallContext", ReturnType = typeof(LogicalCallContext))]
	[CallsUnknownMethods(Count = 2)]
	internal static LogicalCallContext SetLogicalCallContext(LogicalCallContext callCtx) { }

}

