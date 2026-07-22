namespace System.Threading.Tasks;

public class TaskCanceledException : OperationCanceledException
{
	private readonly Task _canceledTask; //Field offset: 0x98

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(OperationCanceledException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	public TaskCanceledException() { }

	[CalledBy(Type = typeof(TaskAwaiter), Member = "HandleNonSuccessAndDebuggerNotification", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TaskAwaiter), Member = "ThrowForNonSuccess", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(OperationCanceledException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(CancellationToken)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	public TaskCanceledException(Task task) { }

	[CallerCount(Count = 17)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	protected TaskCanceledException(SerializationInfo info, StreamingContext context) { }

}

