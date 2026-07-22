namespace System.Threading.Tasks;

internal class StandardTaskContinuation : TaskContinuation
{
	internal readonly Task m_task; //Field offset: 0x10
	internal readonly TaskContinuationOptions m_options; //Field offset: 0x18
	private readonly TaskScheduler m_taskScheduler; //Field offset: 0x20

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	internal StandardTaskContinuation(Task task, TaskContinuationOptions options, TaskScheduler scheduler) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Task), Member = "InternalCancel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TaskContinuation), Member = "InlineIfPossibleOrElseQueue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Task), Member = "ScheduleAndStart", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	[ContainsUnimplementedInstructions]
	internal virtual void Run(Task completedTask, bool bCanInlineContinuationTask) { }

}

