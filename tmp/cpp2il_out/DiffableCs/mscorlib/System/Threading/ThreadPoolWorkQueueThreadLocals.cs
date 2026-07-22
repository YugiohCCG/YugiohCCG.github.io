namespace System.Threading;

internal sealed class ThreadPoolWorkQueueThreadLocals
{
	[ThreadStatic]
	public static ThreadPoolWorkQueueThreadLocals threadLocals; //Field offset: 0x80000000
	public readonly ThreadPoolWorkQueue workQueue; //Field offset: 0x10
	public readonly WorkStealingQueue workStealingQueue; //Field offset: 0x18
	public readonly Random random; //Field offset: 0x20

	[CalledBy(Type = typeof(ThreadPoolWorkQueue), Member = "EnsureCurrentThreadHasQueue", ReturnType = typeof(ThreadPoolWorkQueueThreadLocals))]
	[CalledBy(Type = typeof(ThreadPoolWorkQueue), Member = "Dispatch", ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Thread), Member = "get_CurrentThread", ReturnType = typeof(Thread))]
	[Calls(Type = typeof(Random), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(WorkStealingQueue), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(SparseArray`1), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	public ThreadPoolWorkQueueThreadLocals(ThreadPoolWorkQueue tpq) { }

	[CalledBy(Type = typeof(ThreadPoolWorkQueueThreadLocals), Member = "Finalize", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SparseArray`1), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	private void CleanUp() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Environment), Member = "get_HasShutdownStarted", ReturnType = typeof(bool))]
	[Calls(Type = typeof(AppDomain), Member = "IsFinalizingForUnload", ReturnType = typeof(bool))]
	[Calls(Type = typeof(ThreadPoolWorkQueueThreadLocals), Member = "CleanUp", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	protected virtual void Finalize() { }

}

