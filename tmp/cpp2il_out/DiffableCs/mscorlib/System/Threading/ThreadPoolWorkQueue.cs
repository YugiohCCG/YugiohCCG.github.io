namespace System.Threading;

internal sealed class ThreadPoolWorkQueue
{
	public class QueueSegment
	{
		internal readonly IThreadPoolWorkItem[] nodes; //Field offset: 0x10
		private int indexes; //Field offset: 0x18
		public QueueSegment Next; //Field offset: 0x20

		[CalledBy(Type = typeof(ThreadPoolGlobals), Member = ".cctor", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ThreadPoolWorkQueue), Member = ".ctor", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ThreadPoolWorkQueue), Member = "Enqueue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IThreadPoolWorkItem), typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::MayFail (1))]
		public QueueSegment() { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		[ContainsUnimplementedInstructions]
		private bool CompareExchangeIndexes(ref int prevUpper, int newUpper, ref int prevLower, int newLower) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		private void GetIndexes(out int upper, out int lower) { }

		[CalledBy(Type = typeof(ThreadPoolWorkQueue), Member = "Dequeue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ThreadPoolWorkQueueThreadLocals), typeof(IThreadPoolWorkItem&), typeof(Boolean&)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		[ContainsUnimplementedInstructions]
		public bool IsUsedUp() { }

		[CalledBy(Type = typeof(ThreadPoolWorkQueue), Member = "Dequeue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ThreadPoolWorkQueueThreadLocals), typeof(IThreadPoolWorkItem&), typeof(Boolean&)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(SpinWait), Member = "SpinOnce", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 9)]
		public bool TryDequeue(out IThreadPoolWorkItem node) { }

		[CalledBy(Type = typeof(ThreadPoolWorkQueue), Member = "Enqueue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IThreadPoolWorkItem), typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 7)]
		public bool TryEnqueue(IThreadPoolWorkItem node) { }

	}

	public class SparseArray
	{
		private T[] m_array; //Field offset: 0x0

		internal T[] Current
		{
			[CalledBy(Type = typeof(ThreadPoolWorkQueue), Member = "Dequeue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ThreadPoolWorkQueueThreadLocals), typeof(IThreadPoolWorkItem&), typeof(Boolean&)}, ReturnType = typeof(void))]
			[CallerCount(Count = 1)]
			[CallsUnknownMethods(Count = 1)]
			[DeduplicatedMethod]
			internal get { } //Length: 24
		}

		[CalledBy(Type = typeof(ThreadPoolWorkQueue), Member = ".cctor", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 3)]
		[DeduplicatedMethod]
		internal SparseArray`1(int initialSize) { }

		[CalledBy(Type = typeof(ThreadPoolWorkQueueThreadLocals), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ThreadPoolWorkQueue)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(Array), typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 14)]
		[DeduplicatedMethod]
		internal int Add(T e) { }

		[CalledBy(Type = typeof(ThreadPoolWorkQueue), Member = "Dequeue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ThreadPoolWorkQueueThreadLocals), typeof(IThreadPoolWorkItem&), typeof(Boolean&)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		internal T[] get_Current() { }

		[CalledBy(Type = typeof(ThreadPoolWorkQueueThreadLocals), Member = "CleanUp", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 12)]
		[DeduplicatedMethod]
		internal void Remove(T e) { }

	}

	public class WorkStealingQueue
	{
		internal IThreadPoolWorkItem[] m_array; //Field offset: 0x10
		private int m_mask; //Field offset: 0x18
		private int m_headIndex; //Field offset: 0x1C
		private int m_tailIndex; //Field offset: 0x20
		private SpinLock m_foreignLock; //Field offset: 0x24

		[CalledBy(Type = typeof(ThreadPoolWorkQueueThreadLocals), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ThreadPoolWorkQueue)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 6)]
		public WorkStealingQueue() { }

		[CalledBy(Type = typeof(ThreadPoolWorkQueue), Member = "LocalFindAndPop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IThreadPoolWorkItem)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(SpinLock), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Boolean&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(WorkStealingQueue), Member = "LocalPop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IThreadPoolWorkItem&)}, ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 29)]
		[ContainsUnimplementedInstructions]
		public bool LocalFindAndPop(IThreadPoolWorkItem obj) { }

		[CalledBy(Type = typeof(__ComObject), Member = ".ctor", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(WorkStealingQueue), Member = "LocalFindAndPop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IThreadPoolWorkItem)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(ThreadPoolWorkQueue), Member = "Dequeue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ThreadPoolWorkQueueThreadLocals), typeof(IThreadPoolWorkItem&), typeof(Boolean&)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(Interlocked), Member = "Exchange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&), typeof(int)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(Thread), Member = "BeginCriticalRegion", ReturnType = typeof(void))]
		[Calls(Type = typeof(Interlocked), Member = "CompareExchange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&), typeof(int), typeof(int), typeof(Boolean&)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(SpinLock), Member = "ContinueTryEnter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Boolean&)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 33)]
		public bool LocalPop(out IThreadPoolWorkItem obj) { }

		[CalledBy(Type = typeof(ThreadPoolWorkQueue), Member = "Enqueue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IThreadPoolWorkItem), typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(SpinLock), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Boolean&)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 54)]
		public void LocalPush(IThreadPoolWorkItem obj) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(WorkStealingQueue), Member = "TrySteal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IThreadPoolWorkItem&), typeof(Boolean&), typeof(int)}, ReturnType = typeof(bool))]
		public bool TrySteal(out IThreadPoolWorkItem obj, ref bool missedSteal) { }

		[CalledBy(Type = typeof(WorkStealingQueue), Member = "TrySteal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IThreadPoolWorkItem&), typeof(Boolean&)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(ThreadPoolWorkQueue), Member = "Dequeue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ThreadPoolWorkQueueThreadLocals), typeof(IThreadPoolWorkItem&), typeof(Boolean&)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Thread), Member = "BeginCriticalRegion", ReturnType = typeof(void))]
		[Calls(Type = typeof(Interlocked), Member = "CompareExchange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&), typeof(int), typeof(int), typeof(Boolean&)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(SpinLock), Member = "ContinueTryEnter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Boolean&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Interlocked), Member = "Exchange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&), typeof(int)}, ReturnType = typeof(int))]
		[CallsUnknownMethods(Count = 26)]
		[ContainsUnimplementedInstructions]
		private bool TrySteal(out IThreadPoolWorkItem obj, ref bool missedSteal, int millisecondsTimeout) { }

	}

	internal static SparseArray<WorkStealingQueue> allThreadQueues; //Field offset: 0x0
	internal QueueSegment queueHead; //Field offset: 0x10
	internal QueueSegment queueTail; //Field offset: 0x18
	private int numOutstandingThreadRequests; //Field offset: 0x20

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SparseArray`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private static ThreadPoolWorkQueue() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(QueueSegment), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public ThreadPoolWorkQueue() { }

	[CalledBy(Type = "System.Console+WindowsConsole", Member = ".cctor", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(WorkStealingQueue), Member = "LocalPop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IThreadPoolWorkItem&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(QueueSegment), Member = "TryDequeue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IThreadPoolWorkItem&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(QueueSegment), Member = "IsUsedUp", ReturnType = typeof(bool))]
	[Calls(Type = typeof(SparseArray`1), Member = "get_Current", ReturnType = "T[]")]
	[Calls(Type = typeof(WorkStealingQueue), Member = "TrySteal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IThreadPoolWorkItem&), typeof(Boolean&), typeof(int)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 10)]
	[ContainsUnimplementedInstructions]
	public void Dequeue(ThreadPoolWorkQueueThreadLocals tl, out IThreadPoolWorkItem callback, out bool missedSteal) { }

	[CalledBy(Type = typeof(_ThreadPoolWaitCallback), Member = "PerformWaitCallback", ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Environment), Member = "get_TickCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(Interlocked), Member = "CompareExchange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ThreadPoolWorkQueueThreadLocals), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ThreadPoolWorkQueue)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ThreadPool), Member = "NotifyWorkItemComplete", ReturnType = typeof(bool))]
	[Calls(Type = typeof(ThreadPoolWorkQueue), Member = "EnsureThreadRequested", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 25)]
	internal static bool Dispatch() { }

	[CalledBy(Type = typeof(__ComObject), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(WorkStealingQueue), Member = "LocalPush", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IThreadPoolWorkItem)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ThreadPoolWorkQueue), Member = "EnsureThreadRequested", ReturnType = typeof(void))]
	[Calls(Type = typeof(QueueSegment), Member = "TryEnqueue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IThreadPoolWorkItem)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(QueueSegment), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 10)]
	public void Enqueue(IThreadPoolWorkItem callback, bool forceGlobal) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ThreadPoolWorkQueueThreadLocals), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ThreadPoolWorkQueue)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	public ThreadPoolWorkQueueThreadLocals EnsureCurrentThreadHasQueue() { }

	[CalledBy(Type = "System.Console+WindowsConsole", Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ThreadPoolWorkQueue), Member = "Enqueue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IThreadPoolWorkItem), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ThreadPoolWorkQueue), Member = "Dispatch", ReturnType = typeof(bool))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(Interlocked), Member = "CompareExchange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ThreadPool), Member = "RequestWorkerThread", ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 2)]
	internal void EnsureThreadRequested() { }

	[CalledBy(Type = typeof(ThreadPool), Member = "TryPopCustomWorkItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IThreadPoolWorkItem)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(WorkStealingQueue), Member = "LocalFindAndPop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IThreadPoolWorkItem)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 2)]
	internal bool LocalFindAndPop(IThreadPoolWorkItem callback) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Interlocked), Member = "CompareExchange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 2)]
	internal void MarkThreadRequestSatisfied() { }

}

