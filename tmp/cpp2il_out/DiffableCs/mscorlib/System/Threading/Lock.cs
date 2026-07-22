namespace System.Threading;

public class Lock
{
	private object _lock; //Field offset: 0x10

	[CalledBy(Type = typeof(TaskScheduler), Member = ".cctor", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public Lock() { }

	[CalledBy(Type = typeof(TaskScheduler), Member = "PublishUnobservedTaskException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(UnobservedTaskExceptionEventArgs)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void Acquire() { }

	[CalledBy(Type = typeof(TaskScheduler), Member = "PublishUnobservedTaskException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(UnobservedTaskExceptionEventArgs)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public void Release() { }

}

