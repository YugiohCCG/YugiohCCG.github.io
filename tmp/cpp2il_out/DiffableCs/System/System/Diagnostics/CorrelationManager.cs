namespace System.Diagnostics;

public class CorrelationManager
{

	public Stack LogicalOperationStack
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CallContext), Member = "LogicalGetData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(object))]
		[Calls(Type = typeof(Stack), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CallContext), Member = "LogicalSetData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(void))]
		[DeduplicatedMethod]
		 get { } //Length: 164
	}

	[CallerCount(Count = 2180)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	internal CorrelationManager() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CallContext), Member = "LogicalGetData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(Stack), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CallContext), Member = "LogicalSetData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	public Stack get_LogicalOperationStack() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CallContext), Member = "LogicalGetData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(Stack), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CallContext), Member = "LogicalSetData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	private Stack GetLogicalOperationStack() { }

}

