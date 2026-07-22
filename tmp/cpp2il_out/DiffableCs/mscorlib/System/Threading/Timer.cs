namespace System.Threading;

[ComVisible(True)]
public sealed class Timer : MarshalByRefObject, IDisposable, IAsyncDisposable
{
	private sealed class Scheduler
	{
		private static readonly Scheduler instance; //Field offset: 0x0
		private bool needReSort; //Field offset: 0x10
		private List<Timer> list; //Field offset: 0x18
		private long current_next_run; //Field offset: 0x20
		private ManualResetEvent changed; //Field offset: 0x28

		public static Scheduler Instance
		{
			[CallerCount(Count = 0)]
			 get { } //Length: 78
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(List`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ManualResetEvent), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Thread), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ThreadStart)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Thread), Member = "set_IsBackground", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Thread), Member = "Start", ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 5)]
		private static Scheduler() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(List`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ManualResetEvent), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Thread), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ThreadStart)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Thread), Member = "set_IsBackground", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Thread), Member = "Start", ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 4)]
		private Scheduler() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(EventWaitHandle), Member = "Set", ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 4)]
		private void Add(Timer timer) { }

		[CalledBy(Type = typeof(Timer), Member = "Change", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(long), typeof(bool)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(EventWaitHandle), Member = "Set", ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 11)]
		[ContainsUnimplementedInstructions]
		public void Change(Timer timer, long new_next_run) { }

		[CalledBy(Type = typeof(Scheduler), Member = "RunSchedulerLoop", ReturnType = typeof(int))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(ThreadPool), Member = "UnsafeQueueUserWorkItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WaitCallback), typeof(object)}, ReturnType = typeof(bool))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		private void FireTimer(Timer timer) { }

		[CallerCount(Count = 0)]
		public static Scheduler get_Instance() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ManualResetEvent), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Thread), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ThreadStart)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Thread), Member = "set_IsBackground", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Thread), Member = "Start", ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		private void InitScheduler() { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		private void InternalRemove(Timer timer) { }

		[CalledBy(Type = typeof(Timer), Member = "Dispose", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Timer), Member = "DisposeAsync", ReturnType = typeof(ValueTask))]
		[CalledBy(Type = "System.Threading.Tasks.Task+DelayPromise", Member = "Complete", ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		public void Remove(Timer timer) { }

		[CalledBy(Type = typeof(Scheduler), Member = "SchedulerThread", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Sort", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Comparison`1<System.Object>)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Scheduler), Member = "FireTimer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Timer)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Math), Member = "Min", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(long)}, ReturnType = typeof(long))]
		[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(List`1), Member = "RemoveAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 5)]
		[CallsUnknownMethods(Count = 10)]
		[ContainsUnimplementedInstructions]
		private int RunSchedulerLoop() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Thread), Member = "get_CurrentThread", ReturnType = typeof(Thread))]
		[Calls(Type = typeof(Thread), Member = "set_Name", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(EventWaitHandle), Member = "Reset", ReturnType = typeof(bool))]
		[Calls(Type = typeof(Scheduler), Member = "RunSchedulerLoop", ReturnType = typeof(int))]
		[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 3)]
		private void SchedulerThread() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		private static void TimerCB(object o) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(EventWaitHandle), Member = "Set", ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 1)]
		private void WakeupScheduler() { }

	}

	private struct TimerComparer : IComparer, IComparer<Timer>
	{

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Math), Member = "Sign", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(int))]
		[CallsUnknownMethods(Count = 1)]
		public override int Compare(Timer tx, Timer ty) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Math), Member = "Sign", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(int))]
		private override int System.Collections.IComparer.Compare(object x, object y) { }

	}

	private TimerCallback callback; //Field offset: 0x18
	private object state; //Field offset: 0x20
	private long due_time_ms; //Field offset: 0x28
	private long period_ms; //Field offset: 0x30
	private long next_run; //Field offset: 0x38
	private bool disposed; //Field offset: 0x40
	private bool is_dead; //Field offset: 0x41
	private bool is_added; //Field offset: 0x42

	private static Scheduler scheduler
	{
		[CalledBy(Type = typeof(Timer), Member = "Dispose", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Timer), Member = "Change", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(long), typeof(bool)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(Timer), Member = "DisposeAsync", ReturnType = typeof(ValueTask))]
		[CalledBy(Type = "System.Threading.Tasks.Task+DelayPromise", Member = "Complete", ReturnType = typeof(void))]
		[CallerCount(Count = 4)]
		private get { } //Length: 137
	}

	[CalledBy(Type = typeof(CancellationTokenSource), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpan)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CancellationTokenSource), Member = "InitializeWithTimer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CancellationTokenSource), Member = "CancelAfter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.HttpConnection", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Net.Sockets.Socket", "System.Net.EndPointListener", typeof(bool), typeof(X509Certificate)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Timer), Member = "Change", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(long), typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	public Timer(TimerCallback callback, object state, int dueTime, int period) { }

	[CalledBy(Type = typeof(LeaseManager), Member = "TrackLifetime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ServerIdentity)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LeaseManager), Member = "StartManager", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(TimeSpan), Member = "get_TotalMilliseconds", ReturnType = typeof(double))]
	[Calls(Type = typeof(Timer), Member = "Change", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(long), typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	public Timer(TimerCallback callback, object state, TimeSpan dueTime, TimeSpan period) { }

	[CalledBy(Type = typeof(CancellationTokenSource), Member = "CancelAfter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.HttpConnection", Member = "BeginReadRequest", ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.HttpConnection", Member = "OnReadInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncResult)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Timer), Member = "Change", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(long), typeof(bool)}, ReturnType = typeof(bool))]
	public bool Change(int dueTime, int period) { }

	[CalledBy(Type = typeof(LeaseManager), Member = "SetPollTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpan)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TimeSpan), Member = "get_TotalMilliseconds", ReturnType = typeof(double))]
	[Calls(Type = typeof(Timer), Member = "Change", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(long), typeof(bool)}, ReturnType = typeof(bool))]
	public bool Change(TimeSpan dueTime, TimeSpan period) { }

	[CalledBy(Type = typeof(Timer), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimerCallback), typeof(object), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Timer), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimerCallback), typeof(object), typeof(TimeSpan), typeof(TimeSpan)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Timer), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimerCallback), typeof(object), typeof(long), typeof(long)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Timer), Member = "Change", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Timer), Member = "Change", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpan), typeof(TimeSpan)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Task), Member = "Delay", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(Timer), Member = "get_scheduler", ReturnType = typeof(Scheduler))]
	[Calls(Type = typeof(Scheduler), Member = "Change", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Timer), typeof(long)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ObjectDisposedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 24)]
	private bool Change(long dueTime, long period, bool first) { }

	[CalledBy(Type = typeof(CancellationTokenSource), Member = "CancelAfter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CancellationTokenSource), Member = "Dispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CancellationTokenSource), Member = "NotifyCancellation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LeaseManager), Member = "StopManager", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LeaseManager), Member = "ManageLeases", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(Timer), Member = "get_scheduler", ReturnType = typeof(Scheduler))]
	[Calls(Type = typeof(Scheduler), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Timer)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public override void Dispose() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Timer), Member = "get_scheduler", ReturnType = typeof(Scheduler))]
	[Calls(Type = typeof(Scheduler), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Timer)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Task), Member = "FromResult", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(System.Threading.Tasks.Task`1<System.Object>))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionArgument)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	public override ValueTask DisposeAsync() { }

	[CalledBy(Type = typeof(Timer), Member = "Dispose", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Timer), Member = "Change", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(long), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Timer), Member = "DisposeAsync", ReturnType = typeof(ValueTask))]
	[CalledBy(Type = "System.Threading.Tasks.Task+DelayPromise", Member = "Complete", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	private static Scheduler get_scheduler() { }

	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	private static long GetTimeMonotonic() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Timer), Member = "Change", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(long), typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 6)]
	private void Init(TimerCallback callback, object state, long dueTime, long period) { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	internal void KeepRootedWhileScheduled() { }

}

