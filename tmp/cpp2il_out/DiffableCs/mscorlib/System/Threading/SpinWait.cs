namespace System.Threading;

public struct SpinWait
{
	internal static readonly int SpinCountforSpinBeforeWait; //Field offset: 0x0
	private int _count; //Field offset: 0x0

	public int Count
	{
		[CallerCount(Count = 173)]
		[DeduplicatedMethod]
		 get { } //Length: 3
	}

	public bool NextSpinWillYield
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 98
	}

	[CallerCount(Count = 0)]
	private static SpinWait() { }

	[CallerCount(Count = 173)]
	[DeduplicatedMethod]
	public int get_Count() { }

	[CallerCount(Count = 0)]
	public bool get_NextSpinWillYield() { }

	[CalledBy(Type = typeof(Lazy`1), Member = "PublicationOnlyWaitForOtherThreadToPublish", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(QueueSegment), Member = "TryDequeue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IThreadPoolWorkItem&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TaskCompletionSource`1), Member = "SpinUntilCompleted", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Task), Member = "AtomicStateUpdate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Task), Member = "AtomicStateUpdate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(Int32&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Task), Member = "SetNotificationForWaitCompletion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Task), Member = "ExecuteEntry", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Hashtable), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(Segment), Member = "EnsureFrozenForEnqueues", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Segment), Member = "TryDequeue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&"}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Segment), Member = "TryPeek", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Segment), Member = "TryEnqueue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ConcurrentQueue`1), Member = "get_Count", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(ConcurrentQueue`1), Member = "GetItemWhenAvailable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Concurrent.ConcurrentQueue`1<T>+Segment<T>", typeof(int)}, ReturnType = "T")]
	[CallerCount(Count = 14)]
	[Calls(Type = typeof(SpinWait), Member = "SpinOnceCore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	public void SpinOnce() { }

	[CalledBy(Type = typeof(Task), Member = "SpinThenBlockingWait", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(CancellationToken)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Task), Member = "SpinWait", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(SpinWait), Member = "SpinOnceCore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	public void SpinOnce(int sleep1Threshold) { }

	[CalledBy(Type = typeof(ManualResetEventSlim), Member = "Wait", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(CancellationToken)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ManualResetEventSlim), Member = "UpdateStateAtomically", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SpinWait), Member = "SpinOnce", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SpinWait), Member = "SpinOnce", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CancellationTokenRegistration), Member = "Dispose", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CancellationTokenSource), Member = "WaitForCallbackToComplete", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationCallbackInfo)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SemaphoreSlim), Member = "Wait", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(CancellationToken)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(SpinLock), Member = "DecrementWaiters", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SpinLock), Member = "ContinueTryEnterWithThreadTracking", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(uint), typeof(Boolean&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(RuntimeThread), Member = "SpinWait", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(RuntimeThread), Member = "Yield", ReturnType = typeof(bool))]
	[Calls(Type = typeof(RuntimeThread), Member = "Sleep", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[ContainsUnimplementedInstructions]
	private void SpinOnceCore(int sleep1Threshold) { }

}

