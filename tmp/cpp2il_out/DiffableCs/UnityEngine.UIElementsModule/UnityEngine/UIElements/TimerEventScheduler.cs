namespace UnityEngine.UIElements;

internal class TimerEventScheduler : IScheduler
{
	private readonly List<ScheduledItem> m_ScheduledItems; //Field offset: 0x10
	private bool m_TransactionMode; //Field offset: 0x18
	private readonly List<ScheduledItem> m_ScheduleTransactions; //Field offset: 0x20
	private readonly HashSet<ScheduledItem> m_UnscheduleTransactions; //Field offset: 0x28
	internal bool disableThrottling; //Field offset: 0x30
	private int m_LastUpdatedIndex; //Field offset: 0x34
	private long frameCount; //Field offset: 0x38

	public override long FrameCount
	{
		[CallerCount(Count = 35)]
		[DeduplicatedMethod]
		 get { } //Length: 7
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 set { } //Length: 5
	}

	[CalledBy(Type = typeof(Panel), Member = "get_timerEventScheduler", ReturnType = typeof(TimerEventScheduler))]
	[CalledBy(Type = typeof(Panel), Member = "get_scheduler", ReturnType = typeof(IScheduler))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(System.Collections.Generic.HashSet`1<System.Object>), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 3)]
	public TimerEventScheduler() { }

	[CallerCount(Count = 35)]
	[DeduplicatedMethod]
	public override long get_FrameCount() { }

	[CalledBy(Type = typeof(TimerEventScheduler), Member = "Unschedule", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScheduledItem)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TimerEventScheduler), Member = "UpdateScheduledEvents", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ComputedStyle), Member = "get_wordSpacing", ReturnType = typeof(Length))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(List`1), Member = "RemoveAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private bool PrivateUnSchedule(ScheduledItem sItem) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List`1), Member = "RemoveAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private bool RemovedScheduledItemAt(int index) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.HashSet`1<System.Object>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 12)]
	public override void Schedule(ScheduledItem item) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void set_FrameCount(long value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TimerEventScheduler), Member = "PrivateUnSchedule", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScheduledItem)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.HashSet`1<System.Object>), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 19)]
	public override void Unschedule(ScheduledItem item) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel), Member = "TimeSinceStartupMs", ReturnType = typeof(long))]
	[Calls(Type = typeof(System.Collections.Generic.HashSet`1<System.Object>), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TimerEventScheduler), Member = "PrivateUnSchedule", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScheduledItem)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 30)]
	[ContainsUnimplementedInstructions]
	public override void UpdateScheduledEvents() { }

}

