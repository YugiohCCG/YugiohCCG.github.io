namespace Spine;

internal class EventQueue
{
	private struct EventQueueEntry
	{
		public EventType type; //Field offset: 0x0
		public TrackEntry entry; //Field offset: 0x8
		public Event e; //Field offset: 0x10

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		public EventQueueEntry(EventType eventType, TrackEntry trackEntry, Event e = null) { }

	}

	private enum EventType
	{
		Start = 0,
		Interrupt = 1,
		End = 2,
		Dispose = 3,
		Complete = 4,
		Event = 5,
	}

	private readonly List<EventQueueEntry> eventQueueEntries; //Field offset: 0x10
	internal bool drainDisabled; //Field offset: 0x18
	private readonly AnimationState state; //Field offset: 0x20
	private readonly Pool<TrackEntry> trackEntryPool; //Field offset: 0x28
	[CompilerGenerated]
	private Action AnimationsChanged; //Field offset: 0x30

	internal event Action AnimationsChanged
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[CallsUnknownMethods(Count = 2)]
		[CompilerGenerated]
		internal add { } //Length: 146
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[CallsUnknownMethods(Count = 2)]
		[CompilerGenerated]
		internal remove { } //Length: 146
	}

	[CalledBy(Type = typeof(AnimationState), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AnimationStateData)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	internal EventQueue(AnimationState state, Action HandleAnimationsChanged, Pool<TrackEntry> trackEntryPool) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[CallsUnknownMethods(Count = 2)]
	[CompilerGenerated]
	internal void add_AnimationsChanged(Action value) { }

	[CalledBy(Type = typeof(AnimationState), Member = "ClearListenerNotifications", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	internal void Clear() { }

	[CalledBy(Type = typeof(AnimationState), Member = "QueueEvents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TrackEntry), typeof(float)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(List`1), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	internal void Complete(TrackEntry entry) { }

	[CalledBy(Type = typeof(AnimationState), Member = "ClearTrack", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(AnimationState), Member = "SetAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Animation), typeof(bool)}, ReturnType = typeof(TrackEntry))]
	[CalledBy(Type = typeof(AnimationState), Member = "ClearNext", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TrackEntry)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(List`1), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	internal void Dispose(TrackEntry entry) { }

	[CalledBy(Type = typeof(AnimationState), Member = "Update", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(AnimationState), Member = "Apply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Skeleton)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(AnimationState), Member = "ApplyEventTimelinesOnly", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Skeleton), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(AnimationState), Member = "ClearTracks", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(AnimationState), Member = "ClearTrack", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(AnimationState), Member = "SetAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Animation), typeof(bool)}, ReturnType = typeof(TrackEntry))]
	[CalledBy(Type = typeof(AnimationState), Member = "AddAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Animation), typeof(bool), typeof(float)}, ReturnType = typeof(TrackEntry))]
	[CalledBy(Type = typeof(AnimationState), Member = "SetEmptyAnimations", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AnimationState), Member = "OnEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TrackEntry), typeof(Event)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TrackEntry), Member = "OnEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TrackEntry), Member = "OnComplete", ReturnType = typeof(void))]
	[Calls(Type = typeof(Pool`1), Member = "Free", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TrackEntry), Member = "OnDispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(AnimationState), Member = "OnStart", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TrackEntry)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TrackEntry), Member = "OnEnd", ReturnType = typeof(void))]
	[Calls(Type = typeof(AnimationState), Member = "OnInterrupt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TrackEntry)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TrackEntry), Member = "OnInterrupt", ReturnType = typeof(void))]
	[Calls(Type = typeof(TrackEntry), Member = "OnStart", ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[Calls(Type = typeof(AnimationState), Member = "OnEnd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TrackEntry)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	internal void Drain() { }

	[CalledBy(Type = typeof(AnimationState), Member = "Update", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(AnimationState), Member = "UpdateMixingFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TrackEntry), typeof(float)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(AnimationState), Member = "ClearTrack", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(AnimationState), Member = "SetAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Animation), typeof(bool)}, ReturnType = typeof(TrackEntry))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(List`1), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	internal void End(TrackEntry entry) { }

	[CalledBy(Type = typeof(AnimationState), Member = "QueueEvents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TrackEntry), typeof(float)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(List`1), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	internal void Event(TrackEntry entry, Event e) { }

	[CalledBy(Type = typeof(AnimationState), Member = "SetCurrent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(TrackEntry), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(AnimationState), Member = "SetAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Animation), typeof(bool)}, ReturnType = typeof(TrackEntry))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(List`1), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	internal void Interrupt(TrackEntry entry) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[CallsUnknownMethods(Count = 2)]
	[CompilerGenerated]
	internal void remove_AnimationsChanged(Action value) { }

	[CalledBy(Type = typeof(AnimationState), Member = "SetCurrent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(TrackEntry), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(List`1), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	internal void Start(TrackEntry entry) { }

}

