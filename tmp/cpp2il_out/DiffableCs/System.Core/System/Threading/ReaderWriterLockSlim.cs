namespace System.Threading;

public class ReaderWriterLockSlim : IDisposable
{
	private struct TimeoutTracker
	{
		private int m_total; //Field offset: 0x0
		private int m_start; //Field offset: 0x4

		public bool IsExpired
		{
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(Environment), Member = "get_TickCount", ReturnType = typeof(int))]
			[ContainsUnimplementedInstructions]
			 get { } //Length: 76
		}

		public int RemainingMilliseconds
		{
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(Environment), Member = "get_TickCount", ReturnType = typeof(int))]
			 get { } //Length: 63
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Environment), Member = "get_TickCount", ReturnType = typeof(int))]
		[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 4)]
		public TimeoutTracker(int millisecondsTimeout) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Environment), Member = "get_TickCount", ReturnType = typeof(int))]
		[ContainsUnimplementedInstructions]
		public bool get_IsExpired() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Environment), Member = "get_TickCount", ReturnType = typeof(int))]
		public int get_RemainingMilliseconds() { }

	}

	[ThreadStatic]
	private static ReaderWriterCount t_rwc; //Field offset: 0x80000000
	private static long s_nextLockID; //Field offset: 0x0
	private bool fIsReentrant; //Field offset: 0x10
	private int myLock; //Field offset: 0x14
	private uint numWriteWaiters; //Field offset: 0x18
	private uint numReadWaiters; //Field offset: 0x1C
	private uint numWriteUpgradeWaiters; //Field offset: 0x20
	private uint numUpgradeWaiters; //Field offset: 0x24
	private bool fNoWaiters; //Field offset: 0x28
	private int upgradeLockOwnerId; //Field offset: 0x2C
	private int writeLockOwnerId; //Field offset: 0x30
	private EventWaitHandle writeEvent; //Field offset: 0x38
	private EventWaitHandle readEvent; //Field offset: 0x40
	private EventWaitHandle upgradeEvent; //Field offset: 0x48
	private EventWaitHandle waitUpgradeEvent; //Field offset: 0x50
	private long lockID; //Field offset: 0x58
	private bool fUpgradeThreadHoldingRead; //Field offset: 0x60
	private uint owners; //Field offset: 0x64
	private bool fDisposed; //Field offset: 0x68

	public bool IsReadLockHeld
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 38
	}

	public bool IsUpgradeableReadLockHeld
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Thread), Member = "get_CurrentThread", ReturnType = typeof(Thread))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 91
	}

	public bool IsWriteLockHeld
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Thread), Member = "get_CurrentThread", ReturnType = typeof(Thread))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 91
	}

	public int RecursiveReadCount
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 32
	}

	public int RecursiveUpgradeCount
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Thread), Member = "get_CurrentThread", ReturnType = typeof(Thread))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 100
	}

	public int RecursiveWriteCount
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Thread), Member = "get_CurrentThread", ReturnType = typeof(Thread))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 100
	}

	public int WaitingReadCount
	{
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 4
	}

	public int WaitingUpgradeCount
	{
		[CallerCount(Count = 9)]
		[DeduplicatedMethod]
		 get { } //Length: 4
	}

	public int WaitingWriteCount
	{
		[CallerCount(Count = 7)]
		[DeduplicatedMethod]
		 get { } //Length: 4
	}

	[CalledBy(Type = "System.Data.DataTable", Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Playables.PlayableSystems", Member = ".cctor", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Interlocked), Member = "Increment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int64&)}, ReturnType = typeof(long))]
	[CallsDeduplicatedMethods(Count = 1)]
	public ReaderWriterLockSlim() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Interlocked), Member = "Increment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int64&)}, ReturnType = typeof(long))]
	[CallsDeduplicatedMethods(Count = 1)]
	public ReaderWriterLockSlim(LockRecursionPolicy recursionPolicy) { }

	[CallerCount(Count = 0)]
	private void ClearUpgraderWaiting() { }

	[CallerCount(Count = 0)]
	private void ClearWriterAcquired() { }

	[CallerCount(Count = 0)]
	private void ClearWritersWaiting() { }

	[CalledBy(Type = typeof(ReaderWriterLockSlim), Member = "Dispose", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Thread), Member = "get_CurrentThread", ReturnType = typeof(Thread))]
	[Calls(Type = typeof(SynchronizationLockException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 16)]
	private void Dispose(bool disposing) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ReaderWriterLockSlim), Member = "Dispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	public override void Dispose() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Interlocked), Member = "CompareExchange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ReaderWriterLockSlim), Member = "EnterMyLockSpin", ReturnType = typeof(void))]
	private void EnterMyLock() { }

	[CalledBy(Type = "System.Linq.Expressions.Interpreter.LocalVariables+VariableScope", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LocalVariable), typeof(int), "System.Linq.Expressions.Interpreter.LocalVariables+VariableScope"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ReaderWriterLockSlim), Member = "TryEnterReadLockCore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeoutTracker)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ReaderWriterLockSlim), Member = "TryEnterWriteLockCore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeoutTracker)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ReaderWriterLockSlim), Member = "TryEnterUpgradeableReadLockCore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeoutTracker)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ReaderWriterLockSlim), Member = "ExitReadLock", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ReaderWriterLockSlim), Member = "ExitWriteLock", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ReaderWriterLockSlim), Member = "ExitUpgradeableReadLock", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ReaderWriterLockSlim), Member = "LazyCreateEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventWaitHandle&), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ReaderWriterLockSlim), Member = "EnterMyLock", ReturnType = typeof(void))]
	[CallerCount(Count = 17)]
	[Calls(Type = "System.Threading.PlatformHelper", Member = "get_ProcessorCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(Thread), Member = "SpinWait", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Thread), Member = "Sleep", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Interlocked), Member = "CompareExchange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	private void EnterMyLockSpin() { }

	[CalledBy(Type = "UnityEngine.Playables.PlayableSystems", Member = "Internal_CallSystemDelegate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), "UnityEngine.Playables.PlayableSystems+PlayableSystemStage", typeof(IntPtr), typeof(int)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ReaderWriterLockSlim), Member = "TryEnterReadLockCore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeoutTracker)}, ReturnType = typeof(bool))]
	public void EnterReadLock() { }

	[CalledBy(Type = "System.Data.DataTable", Member = "GetIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Data.IndexField[]", "System.Data.DataViewRowState", "System.Data.IFilter"}, ReturnType = "System.Data.Index")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ReaderWriterLockSlim), Member = "TryEnterUpgradeableReadLockCore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeoutTracker)}, ReturnType = typeof(bool))]
	public void EnterUpgradeableReadLock() { }

	[CalledBy(Type = "System.Data.Index", Member = "AddRef", ReturnType = typeof(void))]
	[CalledBy(Type = "System.Data.Index", Member = "RemoveRef", ReturnType = typeof(int))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ReaderWriterLockSlim), Member = "TryEnterWriteLockCore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeoutTracker)}, ReturnType = typeof(bool))]
	public void EnterWriteLock() { }

	[CalledBy(Type = typeof(ReaderWriterLockSlim), Member = "ExitReadLock", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ReaderWriterLockSlim), Member = "ExitAndWakeUpAppropriateWaiters", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ReaderWriterLockSlim), Member = "ExitAndWakeUpAppropriateWaitersPreferringWriters", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(EventWaitHandle), Member = "Set", ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	private void ExitAndWakeUpAppropriateReadWaiters() { }

	[CalledBy(Type = typeof(ReaderWriterLockSlim), Member = "ExitWriteLock", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(EventWaitHandle), Member = "Set", ReturnType = typeof(bool))]
	[Calls(Type = typeof(ReaderWriterLockSlim), Member = "ExitAndWakeUpAppropriateReadWaiters", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	private void ExitAndWakeUpAppropriateWaiters() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EventWaitHandle), Member = "Set", ReturnType = typeof(bool))]
	[Calls(Type = typeof(ReaderWriterLockSlim), Member = "ExitAndWakeUpAppropriateReadWaiters", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	private void ExitAndWakeUpAppropriateWaitersPreferringWriters() { }

	[CalledBy(Type = typeof(ReaderWriterLockSlim), Member = "TryEnterReadLockCore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeoutTracker)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ReaderWriterLockSlim), Member = "TryEnterWriteLockCore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeoutTracker)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ReaderWriterLockSlim), Member = "TryEnterUpgradeableReadLockCore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeoutTracker)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ReaderWriterLockSlim), Member = "ExitReadLock", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ReaderWriterLockSlim), Member = "ExitWriteLock", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ReaderWriterLockSlim), Member = "ExitUpgradeableReadLock", ReturnType = typeof(void))]
	[CallerCount(Count = 10)]
	[CallsUnknownMethods(Count = 1)]
	private void ExitMyLock() { }

	[CalledBy(Type = "UnityEngine.Playables.PlayableSystems", Member = "Internal_CallSystemDelegate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), "UnityEngine.Playables.PlayableSystems+PlayableSystemStage", typeof(IntPtr), typeof(int)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Interlocked), Member = "CompareExchange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ReaderWriterLockSlim), Member = "EnterMyLockSpin", ReturnType = typeof(void))]
	[Calls(Type = typeof(Thread), Member = "get_CurrentThread", ReturnType = typeof(Thread))]
	[Calls(Type = typeof(EventWaitHandle), Member = "Set", ReturnType = typeof(bool))]
	[Calls(Type = typeof(ReaderWriterLockSlim), Member = "ExitAndWakeUpAppropriateReadWaiters", ReturnType = typeof(void))]
	[Calls(Type = typeof(ReaderWriterLockSlim), Member = "ExitMyLock", ReturnType = typeof(void))]
	[Calls(Type = typeof(SynchronizationLockException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 9)]
	public void ExitReadLock() { }

	[CalledBy(Type = "System.Data.DataTable", Member = "GetIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Data.IndexField[]", "System.Data.DataViewRowState", "System.Data.IFilter"}, ReturnType = "System.Data.Index")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Interlocked), Member = "CompareExchange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ReaderWriterLockSlim), Member = "EnterMyLockSpin", ReturnType = typeof(void))]
	[Calls(Type = typeof(Thread), Member = "get_CurrentThread", ReturnType = typeof(Thread))]
	[Calls(Type = typeof(EventWaitHandle), Member = "Set", ReturnType = typeof(bool))]
	[Calls(Type = typeof(ReaderWriterLockSlim), Member = "ExitMyLock", ReturnType = typeof(void))]
	[Calls(Type = typeof(SynchronizationLockException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 18)]
	public void ExitUpgradeableReadLock() { }

	[CalledBy(Type = "System.Data.Index", Member = "AddRef", ReturnType = typeof(void))]
	[CalledBy(Type = "System.Data.Index", Member = "RemoveRef", ReturnType = typeof(int))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Interlocked), Member = "CompareExchange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ReaderWriterLockSlim), Member = "EnterMyLockSpin", ReturnType = typeof(void))]
	[Calls(Type = typeof(Thread), Member = "get_CurrentThread", ReturnType = typeof(Thread))]
	[Calls(Type = typeof(ReaderWriterLockSlim), Member = "ExitAndWakeUpAppropriateWaiters", ReturnType = typeof(void))]
	[Calls(Type = typeof(ReaderWriterLockSlim), Member = "ExitMyLock", ReturnType = typeof(void))]
	[Calls(Type = typeof(SynchronizationLockException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 15)]
	public void ExitWriteLock() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public bool get_IsReadLockHeld() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Thread), Member = "get_CurrentThread", ReturnType = typeof(Thread))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	public bool get_IsUpgradeableReadLockHeld() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Thread), Member = "get_CurrentThread", ReturnType = typeof(Thread))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	public bool get_IsWriteLockHeld() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public int get_RecursiveReadCount() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Thread), Member = "get_CurrentThread", ReturnType = typeof(Thread))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	public int get_RecursiveUpgradeCount() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Thread), Member = "get_CurrentThread", ReturnType = typeof(Thread))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	public int get_RecursiveWriteCount() { }

	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	public int get_WaitingReadCount() { }

	[CallerCount(Count = 9)]
	[DeduplicatedMethod]
	public int get_WaitingUpgradeCount() { }

	[CallerCount(Count = 7)]
	[DeduplicatedMethod]
	public int get_WaitingWriteCount() { }

	[CallerCount(Count = 0)]
	private uint GetNumReaders() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	private ReaderWriterCount GetThreadRWCount(bool dontAllocate) { }

	[CallerCount(Count = 0)]
	private void InitializeThreadCounts() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private static bool IsRWEntryEmpty(ReaderWriterCount rwc) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private bool IsRwHashEntryChanged(ReaderWriterCount lrwc) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	private bool IsWriterAcquired() { }

	[CalledBy(Type = typeof(ReaderWriterLockSlim), Member = "TryEnterReadLockCore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeoutTracker)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ReaderWriterLockSlim), Member = "TryEnterWriteLockCore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeoutTracker)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ReaderWriterLockSlim), Member = "TryEnterUpgradeableReadLockCore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeoutTracker)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(ManualResetEvent), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AutoResetEvent), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Interlocked), Member = "CompareExchange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ReaderWriterLockSlim), Member = "EnterMyLockSpin", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private void LazyCreateEvent(ref EventWaitHandle waitEvent, bool makeAutoResetEvent) { }

	[CallerCount(Count = 0)]
	private void SetUpgraderWaiting() { }

	[CallerCount(Count = 0)]
	private void SetWriterAcquired() { }

	[CallerCount(Count = 0)]
	private void SetWritersWaiting() { }

	[CalledBy(Type = typeof(ReaderWriterLockSlim), Member = "TryEnterReadLockCore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeoutTracker)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ReaderWriterLockSlim), Member = "TryEnterWriteLockCore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeoutTracker)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ReaderWriterLockSlim), Member = "TryEnterUpgradeableReadLockCore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeoutTracker)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 3)]
	[Calls(Type = "System.Threading.PlatformHelper", Member = "get_ProcessorCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(Thread), Member = "SpinWait", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Thread), Member = "Sleep", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	private static void SpinWait(int SpinCount) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ReaderWriterLockSlim), Member = "TryEnterReadLockCore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeoutTracker)}, ReturnType = typeof(bool))]
	private bool TryEnterReadLock(TimeoutTracker timeout) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Environment), Member = "get_TickCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(ReaderWriterLockSlim), Member = "TryEnterReadLockCore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeoutTracker)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	public bool TryEnterReadLock(int millisecondsTimeout) { }

	[CalledBy(Type = typeof(ReaderWriterLockSlim), Member = "EnterReadLock", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ReaderWriterLockSlim), Member = "TryEnterReadLock", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ReaderWriterLockSlim), Member = "TryEnterReadLock", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeoutTracker)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Thread), Member = "get_CurrentThread", ReturnType = typeof(Thread))]
	[Calls(Type = typeof(Interlocked), Member = "CompareExchange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ReaderWriterLockSlim), Member = "EnterMyLockSpin", ReturnType = typeof(void))]
	[Calls(Type = typeof(ReaderWriterLockSlim), Member = "WaitOnEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventWaitHandle), typeof(UInt32&), typeof(TimeoutTracker), typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ReaderWriterLockSlim), Member = "LazyCreateEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventWaitHandle&), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Environment), Member = "get_TickCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(ReaderWriterLockSlim), Member = "SpinWait", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ObjectDisposedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ReaderWriterLockSlim), Member = "ExitMyLock", ReturnType = typeof(void))]
	[Calls(Type = typeof(LockRecursionException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 19)]
	private bool TryEnterReadLockCore(TimeoutTracker timeout) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ReaderWriterLockSlim), Member = "TryEnterUpgradeableReadLockCore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeoutTracker)}, ReturnType = typeof(bool))]
	private bool TryEnterUpgradeableReadLock(TimeoutTracker timeout) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Environment), Member = "get_TickCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(ReaderWriterLockSlim), Member = "TryEnterUpgradeableReadLockCore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeoutTracker)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	public bool TryEnterUpgradeableReadLock(int millisecondsTimeout) { }

	[CalledBy(Type = typeof(ReaderWriterLockSlim), Member = "EnterUpgradeableReadLock", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ReaderWriterLockSlim), Member = "TryEnterUpgradeableReadLock", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ReaderWriterLockSlim), Member = "TryEnterUpgradeableReadLock", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeoutTracker)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Thread), Member = "get_CurrentThread", ReturnType = typeof(Thread))]
	[Calls(Type = typeof(Interlocked), Member = "CompareExchange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ReaderWriterLockSlim), Member = "EnterMyLockSpin", ReturnType = typeof(void))]
	[Calls(Type = typeof(ReaderWriterLockSlim), Member = "WaitOnEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventWaitHandle), typeof(UInt32&), typeof(TimeoutTracker), typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ReaderWriterLockSlim), Member = "LazyCreateEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventWaitHandle&), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Environment), Member = "get_TickCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(ReaderWriterLockSlim), Member = "SpinWait", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ObjectDisposedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ReaderWriterLockSlim), Member = "ExitMyLock", ReturnType = typeof(void))]
	[Calls(Type = typeof(LockRecursionException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 26)]
	private bool TryEnterUpgradeableReadLockCore(TimeoutTracker timeout) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ReaderWriterLockSlim), Member = "TryEnterWriteLockCore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeoutTracker)}, ReturnType = typeof(bool))]
	private bool TryEnterWriteLock(TimeoutTracker timeout) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Environment), Member = "get_TickCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(ReaderWriterLockSlim), Member = "TryEnterWriteLockCore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeoutTracker)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	public bool TryEnterWriteLock(int millisecondsTimeout) { }

	[CalledBy(Type = typeof(ReaderWriterLockSlim), Member = "EnterWriteLock", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ReaderWriterLockSlim), Member = "TryEnterWriteLock", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ReaderWriterLockSlim), Member = "TryEnterWriteLock", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeoutTracker)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(ReaderWriterLockSlim), Member = "WaitOnEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventWaitHandle), typeof(UInt32&), typeof(TimeoutTracker), typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Thread), Member = "get_CurrentThread", ReturnType = typeof(Thread))]
	[Calls(Type = typeof(Interlocked), Member = "CompareExchange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ReaderWriterLockSlim), Member = "EnterMyLockSpin", ReturnType = typeof(void))]
	[Calls(Type = typeof(ReaderWriterLockSlim), Member = "LazyCreateEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventWaitHandle&), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Environment), Member = "get_TickCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(ReaderWriterLockSlim), Member = "SpinWait", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ObjectDisposedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ReaderWriterLockSlim), Member = "ExitMyLock", ReturnType = typeof(void))]
	[Calls(Type = typeof(LockRecursionException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 23)]
	[ContainsUnimplementedInstructions]
	private bool TryEnterWriteLockCore(TimeoutTracker timeout) { }

	[CalledBy(Type = typeof(ReaderWriterLockSlim), Member = "TryEnterReadLockCore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeoutTracker)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ReaderWriterLockSlim), Member = "TryEnterWriteLockCore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeoutTracker)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ReaderWriterLockSlim), Member = "TryEnterUpgradeableReadLockCore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeoutTracker)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(EventWaitHandle), Member = "Reset", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Environment), Member = "get_TickCount", ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	private bool WaitOnEvent(EventWaitHandle waitEvent, ref uint numWaiters, TimeoutTracker timeout, bool isWriteWaiter) { }

}

