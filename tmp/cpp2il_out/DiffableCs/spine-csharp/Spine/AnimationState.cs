namespace Spine;

public class AnimationState
{
	internal sealed class TrackEntryDelegate : MulticastDelegate
	{

		[CallerCount(Count = 389)]
		[CallsUnknownMethods(Count = 7)]
		[DeduplicatedMethod]
		public TrackEntryDelegate(object object, IntPtr method) { }

		[CallerCount(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		public override IAsyncResult BeginInvoke(TrackEntry trackEntry, AsyncCallback callback, object object) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		public override void EndInvoke(IAsyncResult result) { }

		[CallerCount(Count = 3)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public override void Invoke(TrackEntry trackEntry) { }

	}

	internal sealed class TrackEntryEventDelegate : MulticastDelegate
	{

		[CallerCount(Count = 290)]
		[CallsUnknownMethods(Count = 7)]
		[DeduplicatedMethod]
		public TrackEntryEventDelegate(object object, IntPtr method) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		public override IAsyncResult BeginInvoke(TrackEntry trackEntry, Event e, AsyncCallback callback, object object) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		public override void EndInvoke(IAsyncResult result) { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public override void Invoke(TrackEntry trackEntry, Event e) { }

	}

	internal static readonly Animation EmptyAnimation; //Field offset: 0x0
	internal const int Subsequent = 0; //Field offset: 0x0
	internal const int First = 1; //Field offset: 0x0
	internal const int HoldSubsequent = 2; //Field offset: 0x0
	internal const int HoldFirst = 3; //Field offset: 0x0
	internal const int HoldMix = 4; //Field offset: 0x0
	internal const int Setup = 1; //Field offset: 0x0
	internal const int Current = 2; //Field offset: 0x0
	protected AnimationStateData data; //Field offset: 0x10
	private readonly ExposedList<TrackEntry> tracks; //Field offset: 0x18
	private readonly ExposedList<Event> events; //Field offset: 0x20
	[CompilerGenerated]
	private TrackEntryDelegate Start; //Field offset: 0x28
	[CompilerGenerated]
	private TrackEntryDelegate Interrupt; //Field offset: 0x30
	[CompilerGenerated]
	private TrackEntryDelegate End; //Field offset: 0x38
	[CompilerGenerated]
	private TrackEntryDelegate Dispose; //Field offset: 0x40
	[CompilerGenerated]
	private TrackEntryDelegate Complete; //Field offset: 0x48
	[CompilerGenerated]
	private TrackEntryEventDelegate Event; //Field offset: 0x50
	private readonly EventQueue queue; //Field offset: 0x58
	private readonly HashSet<String> propertyIds; //Field offset: 0x60
	private bool animationsChanged; //Field offset: 0x68
	private float timeScale; //Field offset: 0x6C
	private int unkeyedState; //Field offset: 0x70
	private readonly Pool<TrackEntry> trackEntryPool; //Field offset: 0x78

	public event TrackEntryDelegate Complete
	{
		[CalledBy(Type = "Game.CardAnimationPlayer", Member = "Play", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[CallsUnknownMethods(Count = 2)]
		[CompilerGenerated]
		 add { } //Length: 146
		[CalledBy(Type = "Game.CardAnimationPlayer", Member = "OnStop", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[CallsUnknownMethods(Count = 2)]
		[CompilerGenerated]
		 remove { } //Length: 146
	}

	public event TrackEntryDelegate Dispose
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[CallsUnknownMethods(Count = 2)]
		[CompilerGenerated]
		 add { } //Length: 146
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[CallsUnknownMethods(Count = 2)]
		[CompilerGenerated]
		 remove { } //Length: 146
	}

	public event TrackEntryDelegate End
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[CallsUnknownMethods(Count = 2)]
		[CompilerGenerated]
		 add { } //Length: 146
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[CallsUnknownMethods(Count = 2)]
		[CompilerGenerated]
		 remove { } //Length: 146
	}

	public event TrackEntryEventDelegate Event
	{
		[CalledBy(Type = "Spine.Unity.WaitForSpineEvent", Member = "Subscribe", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AnimationState), typeof(EventData), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = "Spine.Unity.WaitForSpineEvent", Member = "SubscribeByName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AnimationState), typeof(string), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = "Spine.Unity.WaitForSpineEvent", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AnimationState), typeof(EventData), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = "Spine.Unity.WaitForSpineEvent", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Spine.Unity.SkeletonAnimation", typeof(EventData), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = "Spine.Unity.WaitForSpineEvent", Member = "NowWaitFor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AnimationState), typeof(EventData), typeof(bool)}, ReturnType = "Spine.Unity.WaitForSpineEvent")]
		[CallerCount(Count = 5)]
		[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[CallsUnknownMethods(Count = 2)]
		[CompilerGenerated]
		 add { } //Length: 146
		[CalledBy(Type = "Spine.Unity.WaitForSpineEvent", Member = "HandleAnimationStateEventByName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TrackEntry), typeof(Event)}, ReturnType = typeof(void))]
		[CalledBy(Type = "Spine.Unity.WaitForSpineEvent", Member = "HandleAnimationStateEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TrackEntry), typeof(Event)}, ReturnType = typeof(void))]
		[CalledBy(Type = "Spine.Unity.WaitForSpineEvent", Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AnimationState)}, ReturnType = typeof(void))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[CallsUnknownMethods(Count = 2)]
		[CompilerGenerated]
		 remove { } //Length: 146
	}

	public event TrackEntryDelegate Interrupt
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[CallsUnknownMethods(Count = 2)]
		[CompilerGenerated]
		 add { } //Length: 146
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[CallsUnknownMethods(Count = 2)]
		[CompilerGenerated]
		 remove { } //Length: 146
	}

	public event TrackEntryDelegate Start
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[CallsUnknownMethods(Count = 2)]
		[CompilerGenerated]
		 add { } //Length: 146
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[CallsUnknownMethods(Count = 2)]
		[CompilerGenerated]
		 remove { } //Length: 146
	}

	public AnimationStateData Data
	{
		[CallerCount(Count = 106)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 6)]
		 set { } //Length: 138
	}

	public float TimeScale
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 6
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 set { } //Length: 6
	}

	public ExposedList<TrackEntry> Tracks
	{
		[CallerCount(Count = 31)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Animation), Member = "SetTimelines", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Spine.ExposedList`1<Spine.Timeline>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 7)]
	private static AnimationState() { }

	[CalledBy(Type = "Spine.Unity.SkeletonAnimation", Member = "Initialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Spine.Unity.SkeletonGraphic", Member = "Initialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(System.Collections.Generic.HashSet`1<System.Object>), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(Pool`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(EventQueue), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AnimationState), typeof(Action), typeof(Spine.Pool`1<Spine.TrackEntry>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 11)]
	public AnimationState(AnimationStateData data) { }

	[CallerCount(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void <.ctor>b__45_0() { }

	[CalledBy(Type = "Game.CardAnimationPlayer", Member = "Play", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[CallsUnknownMethods(Count = 2)]
	[CompilerGenerated]
	public void add_Complete(TrackEntryDelegate value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[CallsUnknownMethods(Count = 2)]
	[CompilerGenerated]
	public void add_Dispose(TrackEntryDelegate value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[CallsUnknownMethods(Count = 2)]
	[CompilerGenerated]
	public void add_End(TrackEntryDelegate value) { }

	[CalledBy(Type = "Spine.Unity.WaitForSpineEvent", Member = "Subscribe", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AnimationState), typeof(EventData), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Spine.Unity.WaitForSpineEvent", Member = "SubscribeByName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AnimationState), typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Spine.Unity.WaitForSpineEvent", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AnimationState), typeof(EventData), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Spine.Unity.WaitForSpineEvent", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Spine.Unity.SkeletonAnimation", typeof(EventData), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Spine.Unity.WaitForSpineEvent", Member = "NowWaitFor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AnimationState), typeof(EventData), typeof(bool)}, ReturnType = "Spine.Unity.WaitForSpineEvent")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[CallsUnknownMethods(Count = 2)]
	[CompilerGenerated]
	public void add_Event(TrackEntryEventDelegate value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[CallsUnknownMethods(Count = 2)]
	[CompilerGenerated]
	public void add_Interrupt(TrackEntryDelegate value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[CallsUnknownMethods(Count = 2)]
	[CompilerGenerated]
	public void add_Start(TrackEntryDelegate value) { }

	[CalledBy(Type = typeof(AnimationState), Member = "AddAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string), typeof(bool), typeof(float)}, ReturnType = typeof(TrackEntry))]
	[CalledBy(Type = typeof(AnimationState), Member = "AddEmptyAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(float), typeof(float)}, ReturnType = typeof(TrackEntry))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(AnimationState), Member = "ExpandToIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(TrackEntry))]
	[Calls(Type = typeof(AnimationState), Member = "NewTrackEntry", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Animation), typeof(bool), typeof(TrackEntry)}, ReturnType = typeof(TrackEntry))]
	[Calls(Type = typeof(AnimationState), Member = "SetCurrent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(TrackEntry), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(EventQueue), Member = "Drain", ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 8)]
	[ContainsUnimplementedInstructions]
	public TrackEntry AddAnimation(int trackIndex, Animation animation, bool loop, float delay) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SkeletonData), Member = "FindAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Animation))]
	[Calls(Type = typeof(AnimationState), Member = "AddAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Animation), typeof(bool), typeof(float)}, ReturnType = typeof(TrackEntry))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 6)]
	public TrackEntry AddAnimation(int trackIndex, string animationName, bool loop, float delay) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AnimationState), Member = "AddAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Animation), typeof(bool), typeof(float)}, ReturnType = typeof(TrackEntry))]
	[CallsUnknownMethods(Count = 1)]
	public TrackEntry AddEmptyAnimation(int trackIndex, float mixDuration, float delay) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[CallsUnknownMethods(Count = 13)]
	public void AddEventSubscribersFrom(AnimationState src) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(HashSet`1), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(AnimationState), Member = "ComputeHold", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TrackEntry)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	private void AnimationsChanged() { }

	[CalledBy(Type = "Spine.Unity.SkeletonAnimation", Member = "Update", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Spine.Unity.SkeletonAnimation", Member = "ApplyAnimation", ReturnType = typeof(void))]
	[CalledBy(Type = "Spine.Unity.SkeletonGraphic", Member = "Update", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Spine.Unity.SkeletonGraphic", Member = "ApplyAnimation", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(TrackEntry), Member = "get_AnimationTime", ReturnType = typeof(float))]
	[Calls(Type = typeof(Skeleton), Member = "GetAttachment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string)}, ReturnType = typeof(Attachment))]
	[Calls(Type = typeof(ExposedList`1), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AnimationState), Member = "QueueEvents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TrackEntry), typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AnimationState), Member = "ApplyAttachmentTimeline", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AttachmentTimeline), typeof(Skeleton), typeof(float), typeof(MixBlend), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AnimationState), Member = "ApplyRotateTimeline", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RotateTimeline), typeof(Skeleton), typeof(float), typeof(float), typeof(MixBlend), typeof(Single[]), typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AnimationState), Member = "ApplyMixingFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TrackEntry), typeof(Skeleton), typeof(MixBlend)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Slot), Member = "set_Attachment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Attachment)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AnimationState), Member = "ComputeHold", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TrackEntry)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(HashSet`1), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(ExposedList`1), Member = "Resize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "Spine.ExposedList`1<T>")]
	[Calls(Type = typeof(EventQueue), Member = "Drain", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 11)]
	[ContainsUnimplementedInstructions]
	public bool Apply(Skeleton skeleton) { }

	[CalledBy(Type = typeof(AnimationState), Member = "Apply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Skeleton)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(AnimationState), Member = "ApplyMixingFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TrackEntry), typeof(Skeleton), typeof(MixBlend)}, ReturnType = typeof(float))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Skeleton), Member = "GetAttachment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string)}, ReturnType = typeof(Attachment))]
	[Calls(Type = typeof(Slot), Member = "set_Attachment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Attachment)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	private void ApplyAttachmentTimeline(AttachmentTimeline timeline, Skeleton skeleton, float time, MixBlend blend, bool attachments) { }

	[CalledBy(Type = "Spine.Unity.SkeletonAnimation", Member = "Update", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Spine.Unity.SkeletonAnimation", Member = "ApplyAnimation", ReturnType = typeof(void))]
	[CalledBy(Type = "Spine.Unity.SkeletonGraphic", Member = "Update", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Spine.Unity.SkeletonGraphic", Member = "ApplyAnimation", ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(AnimationState), Member = "ApplyMixingFromEventTimelinesOnly", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TrackEntry), typeof(Skeleton), typeof(bool)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(TrackEntry), Member = "get_AnimationTime", ReturnType = typeof(float))]
	[Calls(Type = typeof(AnimationState), Member = "QueueEvents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TrackEntry), typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ExposedList`1), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(EventQueue), Member = "Drain", ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	public bool ApplyEventTimelinesOnly(Skeleton skeleton, bool issueEvents = true) { }

	[CalledBy(Type = typeof(AnimationState), Member = "Apply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Skeleton)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(AnimationState), Member = "ApplyMixingFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TrackEntry), typeof(Skeleton), typeof(MixBlend)}, ReturnType = typeof(float))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(AnimationState), Member = "ApplyMixingFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TrackEntry), typeof(Skeleton), typeof(MixBlend)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(TrackEntry), Member = "get_AnimationTime", ReturnType = typeof(float))]
	[Calls(Type = typeof(ExposedList`1), Member = "Resize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "Spine.ExposedList`1<T>")]
	[Calls(Type = typeof(Math), Member = "Max", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(AnimationState), Member = "ApplyRotateTimeline", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RotateTimeline), typeof(Skeleton), typeof(float), typeof(float), typeof(MixBlend), typeof(Single[]), typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AnimationState), Member = "ApplyAttachmentTimeline", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AttachmentTimeline), typeof(Skeleton), typeof(float), typeof(MixBlend), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AnimationState), Member = "QueueEvents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TrackEntry), typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ExposedList`1), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	[ContainsUnimplementedInstructions]
	private float ApplyMixingFrom(TrackEntry to, Skeleton skeleton, MixBlend blend) { }

	[CalledBy(Type = typeof(AnimationState), Member = "ApplyEventTimelinesOnly", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Skeleton), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(AnimationState), Member = "ApplyMixingFromEventTimelinesOnly", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TrackEntry), typeof(Skeleton), typeof(bool)}, ReturnType = typeof(float))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(AnimationState), Member = "ApplyMixingFromEventTimelinesOnly", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TrackEntry), typeof(Skeleton), typeof(bool)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(TrackEntry), Member = "get_AnimationTime", ReturnType = typeof(float))]
	[Calls(Type = typeof(AnimationState), Member = "QueueEvents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TrackEntry), typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ExposedList`1), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	private float ApplyMixingFromEventTimelinesOnly(TrackEntry to, Skeleton skeleton, bool issueEvents) { }

	[CalledBy(Type = typeof(AnimationState), Member = "Apply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Skeleton)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(AnimationState), Member = "ApplyMixingFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TrackEntry), typeof(Skeleton), typeof(MixBlend)}, ReturnType = typeof(float))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CurveTimeline1), Member = "GetCurveValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(Math), Member = "Sign", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	[ContainsUnimplementedInstructions]
	private static void ApplyRotateTimeline(RotateTimeline timeline, Skeleton skeleton, float time, float alpha, MixBlend blend, Single[] timelinesRotation, int i, bool firstFrame) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 7)]
	public void AssignEventSubscribersFrom(AnimationState src) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EventQueue), Member = "Clear", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void ClearListenerNotifications() { }

	[CalledBy(Type = typeof(AnimationState), Member = "Update", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(EventQueue), Member = "Dispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TrackEntry)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	public void ClearNext(TrackEntry entry) { }

	[CalledBy(Type = typeof(AnimationState), Member = "ClearTracks", ReturnType = typeof(void))]
	[CalledBy(Type = "Spine.Unity.SkeletonAnimation", Member = "set_AnimationName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(EventQueue), Member = "End", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TrackEntry)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(EventQueue), Member = "Dispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TrackEntry)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(EventQueue), Member = "Drain", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 6)]
	public void ClearTrack(int trackIndex) { }

	[CalledBy(Type = "Spine.Unity.SkeletonAnimation", Member = "ClearState", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(AnimationState), Member = "ClearTrack", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ExposedList`1), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(EventQueue), Member = "Drain", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void ClearTracks() { }

	[CalledBy(Type = typeof(AnimationState), Member = "Apply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Skeleton)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(AnimationState), Member = "AnimationsChanged", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ExposedList`1), Member = "Resize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "Spine.ExposedList`1<T>")]
	[Calls(Type = typeof(ExposedList`1), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Spine.ExposedList`1<System.Object>), Member = "Resize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Spine.ExposedList`1<System.Object>))]
	[Calls(Type = typeof(HashSetExtensions), Member = "AddAll", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.HashSet`1<T>", "T[]"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Animation), Member = "HasTimeline", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[])}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 6)]
	private void ComputeHold(TrackEntry entry) { }

	[CalledBy(Type = typeof(AnimationState), Member = "SetCurrent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(TrackEntry), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(AnimationState), Member = "SetAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Animation), typeof(bool)}, ReturnType = typeof(TrackEntry))]
	[CalledBy(Type = typeof(AnimationState), Member = "AddAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Animation), typeof(bool), typeof(float)}, ReturnType = typeof(TrackEntry))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Spine.ExposedList`1<System.Object>), Member = "Resize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Spine.ExposedList`1<System.Object>))]
	[CallsUnknownMethods(Count = 2)]
	private TrackEntry ExpandToIndex(int index) { }

	[CallerCount(Count = 106)]
	[DeduplicatedMethod]
	public AnimationStateData get_Data() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public float get_TimeScale() { }

	[CallerCount(Count = 31)]
	[DeduplicatedMethod]
	public ExposedList<TrackEntry> get_Tracks() { }

	[CalledBy(Type = "Spine.Unity.SkeletonRootMotion", Member = "GetRemainingRootMotion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "UnityEngine.Vector2")]
	[CalledBy(Type = "Spine.Unity.SkeletonRootMotion", Member = "GetRootMotionInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "Spine.Unity.SkeletonRootMotionBase+RootMotionInfo")]
	[CalledBy(Type = "Spine.Unity.SkeletonRootMotion", Member = "CalculateAnimationsMovementDelta", ReturnType = "UnityEngine.Vector2")]
	[CalledBy(Type = "Spine.Unity.SkeletonAnimation", Member = "get_AnimationName", ReturnType = typeof(string))]
	[CalledBy(Type = "Spine.Unity.SkeletonAnimation", Member = "set_AnimationName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[CallsUnknownMethods(Count = 2)]
	public TrackEntry GetCurrent(int trackIndex) { }

	[CalledBy(Type = typeof(AnimationState), Member = "SetAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Animation), typeof(bool)}, ReturnType = typeof(TrackEntry))]
	[CalledBy(Type = typeof(AnimationState), Member = "AddAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Animation), typeof(bool), typeof(float)}, ReturnType = typeof(TrackEntry))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Pool`1), Member = "Obtain", ReturnType = "T")]
	[Calls(Type = typeof(AnimationStateData), Member = "GetMix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Animation), typeof(Animation)}, ReturnType = typeof(float))]
	[CallsUnknownMethods(Count = 2)]
	private TrackEntry NewTrackEntry(int trackIndex, Animation animation, bool loop, TrackEntry last) { }

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	internal void OnComplete(TrackEntry entry) { }

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	internal void OnDispose(TrackEntry entry) { }

	[CalledBy(Type = typeof(EventQueue), Member = "Drain", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	internal void OnEnd(TrackEntry entry) { }

	[CalledBy(Type = typeof(EventQueue), Member = "Drain", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	internal void OnEvent(TrackEntry entry, Event e) { }

	[CalledBy(Type = typeof(EventQueue), Member = "Drain", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	internal void OnInterrupt(TrackEntry entry) { }

	[CalledBy(Type = typeof(EventQueue), Member = "Drain", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	internal void OnStart(TrackEntry entry) { }

	[CalledBy(Type = typeof(AnimationState), Member = "Apply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Skeleton)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(AnimationState), Member = "ApplyEventTimelinesOnly", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Skeleton), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(AnimationState), Member = "ApplyMixingFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TrackEntry), typeof(Skeleton), typeof(MixBlend)}, ReturnType = typeof(float))]
	[CalledBy(Type = typeof(AnimationState), Member = "ApplyMixingFromEventTimelinesOnly", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TrackEntry), typeof(Skeleton), typeof(bool)}, ReturnType = typeof(float))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(EventQueue), Member = "Event", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TrackEntry), typeof(Event)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(EventQueue), Member = "Complete", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TrackEntry)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	[ContainsUnimplementedInstructions]
	private void QueueEvents(TrackEntry entry, float animationTime) { }

	[CalledBy(Type = "Game.CardAnimationPlayer", Member = "OnStop", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[CallsUnknownMethods(Count = 2)]
	[CompilerGenerated]
	public void remove_Complete(TrackEntryDelegate value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[CallsUnknownMethods(Count = 2)]
	[CompilerGenerated]
	public void remove_Dispose(TrackEntryDelegate value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[CallsUnknownMethods(Count = 2)]
	[CompilerGenerated]
	public void remove_End(TrackEntryDelegate value) { }

	[CalledBy(Type = "Spine.Unity.WaitForSpineEvent", Member = "HandleAnimationStateEventByName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TrackEntry), typeof(Event)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Spine.Unity.WaitForSpineEvent", Member = "HandleAnimationStateEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TrackEntry), typeof(Event)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Spine.Unity.WaitForSpineEvent", Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AnimationState)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[CallsUnknownMethods(Count = 2)]
	[CompilerGenerated]
	public void remove_Event(TrackEntryEventDelegate value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[CallsUnknownMethods(Count = 2)]
	[CompilerGenerated]
	public void remove_Interrupt(TrackEntryDelegate value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[CallsUnknownMethods(Count = 2)]
	[CompilerGenerated]
	public void remove_Start(TrackEntryDelegate value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 6)]
	public void set_Data(AnimationStateData value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void set_TimeScale(float value) { }

	[CalledBy(Type = "Game.CardAnimationPlayer", Member = "Play", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SkeletonData), Member = "FindAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Animation))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 6)]
	[ContainsInvalidInstructions]
	public TrackEntry SetAnimation(int trackIndex, string animationName, bool loop) { }

	[CalledBy(Type = typeof(AnimationState), Member = "SetEmptyAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(float)}, ReturnType = typeof(TrackEntry))]
	[CalledBy(Type = "Spine.Unity.SkeletonAnimation", Member = "set_AnimationName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Spine.Unity.SkeletonAnimation", Member = "Initialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Spine.Unity.SkeletonGraphic", Member = "Initialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(AnimationState), Member = "ExpandToIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(TrackEntry))]
	[Calls(Type = typeof(EventQueue), Member = "Interrupt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TrackEntry)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(EventQueue), Member = "End", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TrackEntry)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(EventQueue), Member = "Dispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TrackEntry)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AnimationState), Member = "NewTrackEntry", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Animation), typeof(bool), typeof(TrackEntry)}, ReturnType = typeof(TrackEntry))]
	[Calls(Type = typeof(AnimationState), Member = "SetCurrent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(TrackEntry), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(EventQueue), Member = "Drain", ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 13)]
	[ContainsUnimplementedInstructions]
	public TrackEntry SetAnimation(int trackIndex, Animation animation, bool loop) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Skeleton), Member = "GetAttachment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string)}, ReturnType = typeof(Attachment))]
	[Calls(Type = typeof(Slot), Member = "set_Attachment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Attachment)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private void SetAttachment(Skeleton skeleton, Slot slot, string attachmentName, bool attachments) { }

	[CalledBy(Type = typeof(AnimationState), Member = "Update", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(AnimationState), Member = "SetAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Animation), typeof(bool)}, ReturnType = typeof(TrackEntry))]
	[CalledBy(Type = typeof(AnimationState), Member = "AddAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Animation), typeof(bool), typeof(float)}, ReturnType = typeof(TrackEntry))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(AnimationState), Member = "ExpandToIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(TrackEntry))]
	[Calls(Type = typeof(EventQueue), Member = "Interrupt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TrackEntry)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Math), Member = "Min", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(ExposedList`1), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(EventQueue), Member = "Start", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TrackEntry)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 9)]
	private void SetCurrent(int index, TrackEntry current, bool interrupt) { }

	[CalledBy(Type = typeof(AnimationState), Member = "SetEmptyAnimations", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(AnimationState), Member = "SetAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Animation), typeof(bool)}, ReturnType = typeof(TrackEntry))]
	[CallsUnknownMethods(Count = 1)]
	public TrackEntry SetEmptyAnimation(int trackIndex, float mixDuration) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AnimationState), Member = "SetEmptyAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(float)}, ReturnType = typeof(TrackEntry))]
	[Calls(Type = typeof(EventQueue), Member = "Drain", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	public void SetEmptyAnimations(float mixDuration) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(StringBuilder))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 2)]
	public virtual string ToString() { }

	[CalledBy(Type = "Spine.Unity.SkeletonAnimation", Member = "Update", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Spine.Unity.SkeletonAnimation", Member = "UpdateAnimationStatus", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Spine.Unity.SkeletonGraphic", Member = "Update", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Spine.Unity.SkeletonGraphic", Member = "UpdateAnimationStatus", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(EventQueue), Member = "End", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TrackEntry)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AnimationState), Member = "ClearNext", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TrackEntry)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(EventQueue), Member = "Drain", ReturnType = typeof(void))]
	[Calls(Type = typeof(AnimationState), Member = "UpdateMixingFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TrackEntry), typeof(float)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(AnimationState), Member = "SetCurrent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(TrackEntry), typeof(bool)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 7)]
	[ContainsUnimplementedInstructions]
	public void Update(float delta) { }

	[CalledBy(Type = typeof(AnimationState), Member = "Update", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(AnimationState), Member = "UpdateMixingFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TrackEntry), typeof(float)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(AnimationState), Member = "UpdateMixingFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TrackEntry), typeof(float)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(EventQueue), Member = "End", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TrackEntry)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	private bool UpdateMixingFrom(TrackEntry to, float delta) { }

}

