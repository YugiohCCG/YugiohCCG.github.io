namespace System.Threading.Tasks;

[FriendAccessAllowed]
internal static class AsyncCausalityTracer
{

	[FriendAccessAllowed]
	internal static bool LoggingOn
	{
		[CallerCount(Count = 271)]
		[DeduplicatedMethod]
		[FriendAccessAllowed]
		internal get { } //Length: 3
	}

	[CallerCount(Count = 271)]
	[DeduplicatedMethod]
	[FriendAccessAllowed]
	internal static bool get_LoggingOn() { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	[FriendAccessAllowed]
	internal static void TraceOperationCompletion(CausalityTraceLevel traceLevel, int taskId, AsyncCausalityStatus status) { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	[FriendAccessAllowed]
	internal static void TraceOperationCreation(CausalityTraceLevel traceLevel, int taskId, string operationName, ulong relatedContext) { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	internal static void TraceSynchronousWorkCompletion(CausalityTraceLevel traceLevel, CausalitySynchronousWork work) { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	internal static void TraceSynchronousWorkStart(CausalityTraceLevel traceLevel, int taskId, CausalitySynchronousWork work) { }

}

