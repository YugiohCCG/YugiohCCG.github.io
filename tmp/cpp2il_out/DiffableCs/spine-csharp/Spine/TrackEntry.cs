namespace Spine;

public class TrackEntry : IPoolable<TrackEntry>
{
	internal Animation animation; //Field offset: 0x10
	internal TrackEntry previous; //Field offset: 0x18
	internal TrackEntry next; //Field offset: 0x20
	internal TrackEntry mixingFrom; //Field offset: 0x28
	internal TrackEntry mixingTo; //Field offset: 0x30
	[CompilerGenerated]
	private TrackEntryDelegate Start; //Field offset: 0x38
	[CompilerGenerated]
	private TrackEntryDelegate Interrupt; //Field offset: 0x40
	[CompilerGenerated]
	private TrackEntryDelegate End; //Field offset: 0x48
	[CompilerGenerated]
	private TrackEntryDelegate Dispose; //Field offset: 0x50
	[CompilerGenerated]
	private TrackEntryDelegate Complete; //Field offset: 0x58
	[CompilerGenerated]
	private TrackEntryEventDelegate Event; //Field offset: 0x60
	internal int trackIndex; //Field offset: 0x68
	internal bool loop; //Field offset: 0x6C
	internal bool holdPrevious; //Field offset: 0x6D
	internal bool reverse; //Field offset: 0x6E
	internal float eventThreshold; //Field offset: 0x70
	internal float attachmentThreshold; //Field offset: 0x74
	internal float drawOrderThreshold; //Field offset: 0x78
	internal float animationStart; //Field offset: 0x7C
	internal float animationEnd; //Field offset: 0x80
	internal float animationLast; //Field offset: 0x84
	internal float nextAnimationLast; //Field offset: 0x88
	internal float delay; //Field offset: 0x8C
	internal float trackTime; //Field offset: 0x90
	internal float trackLast; //Field offset: 0x94
	internal float nextTrackLast; //Field offset: 0x98
	internal float trackEnd; //Field offset: 0x9C
	internal float timeScale; //Field offset: 0xA0
	internal float alpha; //Field offset: 0xA4
	internal float mixTime; //Field offset: 0xA8
	internal float mixDuration; //Field offset: 0xAC
	internal float interruptAlpha; //Field offset: 0xB0
	internal float totalAlpha; //Field offset: 0xB4
	internal MixBlend mixBlend; //Field offset: 0xB8
	internal readonly ExposedList<Int32> timelineMode; //Field offset: 0xC0
	internal readonly ExposedList<TrackEntry> timelineHoldMix; //Field offset: 0xC8
	internal readonly ExposedList<Single> timelinesRotation; //Field offset: 0xD0

	public event TrackEntryDelegate Complete
	{
		[CalledBy(Type = "Spine.Unity.WaitForSpineAnimation", Member = "SafeSubscribe", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TrackEntry), "Spine.Unity.WaitForSpineAnimation+AnimationEventTypes"}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
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

	public event TrackEntryDelegate Dispose
	{
		[CalledBy(Type = "Spine.Unity.WaitForSpineAnimation", Member = "SafeSubscribe", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TrackEntry), "Spine.Unity.WaitForSpineAnimation+AnimationEventTypes"}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
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
		[CalledBy(Type = "Spine.Unity.WaitForSpineAnimation", Member = "SafeSubscribe", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TrackEntry), "Spine.Unity.WaitForSpineAnimation+AnimationEventTypes"}, ReturnType = typeof(void))]
		[CalledBy(Type = "Spine.Unity.WaitForSpineTrackEntryEnd", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TrackEntry)}, ReturnType = typeof(void))]
		[CalledBy(Type = "Spine.Unity.WaitForSpineTrackEntryEnd", Member = "SafeSubscribe", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TrackEntry)}, ReturnType = typeof(void))]
		[CalledBy(Type = "Spine.Unity.WaitForSpineTrackEntryEnd", Member = "NowWaitFor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TrackEntry)}, ReturnType = "Spine.Unity.WaitForSpineTrackEntryEnd")]
		[CallerCount(Count = 4)]
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

	public event TrackEntryDelegate Interrupt
	{
		[CalledBy(Type = "Spine.Unity.WaitForSpineAnimation", Member = "SafeSubscribe", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TrackEntry), "Spine.Unity.WaitForSpineAnimation+AnimationEventTypes"}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
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
		[CalledBy(Type = "Spine.Unity.WaitForSpineAnimation", Member = "SafeSubscribe", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TrackEntry), "Spine.Unity.WaitForSpineAnimation+AnimationEventTypes"}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
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

	public float Alpha
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 9
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 set { } //Length: 9
	}

	public Animation Animation
	{
		[CallerCount(Count = 106)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public float AnimationEnd
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 9
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 set { } //Length: 9
	}

	public float AnimationLast
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 9
		[CallerCount(Count = 0)]
		 set { } //Length: 17
	}

	public float AnimationStart
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 6
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 set { } //Length: 6
	}

	public float AnimationTime
	{
		[CalledBy(Type = typeof(AnimationState), Member = "Apply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Skeleton)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(AnimationState), Member = "ApplyEventTimelinesOnly", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Skeleton), typeof(bool)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(AnimationState), Member = "ApplyMixingFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TrackEntry), typeof(Skeleton), typeof(MixBlend)}, ReturnType = typeof(float))]
		[CalledBy(Type = typeof(AnimationState), Member = "ApplyMixingFromEventTimelinesOnly", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TrackEntry), typeof(Skeleton), typeof(bool)}, ReturnType = typeof(float))]
		[CalledBy(Type = "Spine.Unity.SkeletonRootMotion", Member = "GetRemainingRootMotion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "UnityEngine.Vector2")]
		[CalledBy(Type = "Spine.Unity.SkeletonRootMotion", Member = "GetRootMotionInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "Spine.Unity.SkeletonRootMotionBase+RootMotionInfo")]
		[CalledBy(Type = "Spine.Unity.SkeletonRootMotion", Member = "CalculateAnimationsMovementDelta", ReturnType = "UnityEngine.Vector2")]
		[CallerCount(Count = 7)]
		[Calls(Type = typeof(Math), Member = "Min", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(float))]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 210
	}

	public float AttachmentThreshold
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 6
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 set { } //Length: 6
	}

	public float Delay
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 9
		[CallerCount(Count = 0)]
		 set { } //Length: 9
	}

	public float DrawOrderThreshold
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 6
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 set { } //Length: 6
	}

	public float EventThreshold
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 6
		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		 set { } //Length: 6
	}

	public bool HoldPrevious
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	public float InterruptAlpha
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 9
	}

	public bool IsComplete
	{
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 28
	}

	public bool IsEmptyAnimation
	{
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 91
	}

	public bool Loop
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	public MixBlend MixBlend
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 7
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 set { } //Length: 7
	}

	public float MixDuration
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 9
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 set { } //Length: 9
	}

	public TrackEntry MixingFrom
	{
		[CallerCount(Count = 15)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public TrackEntry MixingTo
	{
		[CallerCount(Count = 62)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public float MixTime
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 9
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 set { } //Length: 9
	}

	public TrackEntry Next
	{
		[CallerCount(Count = 12)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public TrackEntry Previous
	{
		[CallerCount(Count = 31)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public bool Reverse
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		 set { } //Length: 4
	}

	public float TimeScale
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 9
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 set { } //Length: 9
	}

	public float TrackComplete
	{
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 77
	}

	public float TrackEnd
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 9
		[CallerCount(Count = 0)]
		 set { } //Length: 9
	}

	public int TrackIndex
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 4
	}

	public float TrackTime
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 9
		[CallerCount(Count = 0)]
		 set { } //Length: 9
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 3)]
	public TrackEntry() { }

	[CalledBy(Type = "Spine.Unity.WaitForSpineAnimation", Member = "SafeSubscribe", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TrackEntry), "Spine.Unity.WaitForSpineAnimation+AnimationEventTypes"}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[CallsUnknownMethods(Count = 2)]
	[CompilerGenerated]
	public void add_Complete(TrackEntryDelegate value) { }

	[CalledBy(Type = "Spine.Unity.WaitForSpineAnimation", Member = "SafeSubscribe", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TrackEntry), "Spine.Unity.WaitForSpineAnimation+AnimationEventTypes"}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[CallsUnknownMethods(Count = 2)]
	[CompilerGenerated]
	public void add_Dispose(TrackEntryDelegate value) { }

	[CalledBy(Type = "Spine.Unity.WaitForSpineAnimation", Member = "SafeSubscribe", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TrackEntry), "Spine.Unity.WaitForSpineAnimation+AnimationEventTypes"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Spine.Unity.WaitForSpineTrackEntryEnd", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TrackEntry)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Spine.Unity.WaitForSpineTrackEntryEnd", Member = "SafeSubscribe", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TrackEntry)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Spine.Unity.WaitForSpineTrackEntryEnd", Member = "NowWaitFor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TrackEntry)}, ReturnType = "Spine.Unity.WaitForSpineTrackEntryEnd")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[CallsUnknownMethods(Count = 2)]
	[CompilerGenerated]
	public void add_End(TrackEntryDelegate value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[CallsUnknownMethods(Count = 2)]
	[CompilerGenerated]
	public void add_Event(TrackEntryEventDelegate value) { }

	[CalledBy(Type = "Spine.Unity.WaitForSpineAnimation", Member = "SafeSubscribe", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TrackEntry), "Spine.Unity.WaitForSpineAnimation+AnimationEventTypes"}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[CallsUnknownMethods(Count = 2)]
	[CompilerGenerated]
	public void add_Interrupt(TrackEntryDelegate value) { }

	[CalledBy(Type = "Spine.Unity.WaitForSpineAnimation", Member = "SafeSubscribe", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TrackEntry), "Spine.Unity.WaitForSpineAnimation+AnimationEventTypes"}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[CallsUnknownMethods(Count = 2)]
	[CompilerGenerated]
	public void add_Start(TrackEntryDelegate value) { }

	[CallerCount(Count = 0)]
	public void AllowImmediateQueue() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public float get_Alpha() { }

	[CallerCount(Count = 106)]
	[DeduplicatedMethod]
	public Animation get_Animation() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public float get_AnimationEnd() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public float get_AnimationLast() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public float get_AnimationStart() { }

	[CalledBy(Type = typeof(AnimationState), Member = "Apply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Skeleton)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(AnimationState), Member = "ApplyEventTimelinesOnly", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Skeleton), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(AnimationState), Member = "ApplyMixingFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TrackEntry), typeof(Skeleton), typeof(MixBlend)}, ReturnType = typeof(float))]
	[CalledBy(Type = typeof(AnimationState), Member = "ApplyMixingFromEventTimelinesOnly", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TrackEntry), typeof(Skeleton), typeof(bool)}, ReturnType = typeof(float))]
	[CalledBy(Type = "Spine.Unity.SkeletonRootMotion", Member = "GetRemainingRootMotion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "UnityEngine.Vector2")]
	[CalledBy(Type = "Spine.Unity.SkeletonRootMotion", Member = "GetRootMotionInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "Spine.Unity.SkeletonRootMotionBase+RootMotionInfo")]
	[CalledBy(Type = "Spine.Unity.SkeletonRootMotion", Member = "CalculateAnimationsMovementDelta", ReturnType = "UnityEngine.Vector2")]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(Math), Member = "Min", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(float))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public float get_AnimationTime() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public float get_AttachmentThreshold() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public float get_Delay() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public float get_DrawOrderThreshold() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public float get_EventThreshold() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public bool get_HoldPrevious() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public float get_InterruptAlpha() { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public bool get_IsComplete() { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public bool get_IsEmptyAnimation() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public bool get_Loop() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public MixBlend get_MixBlend() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public float get_MixDuration() { }

	[CallerCount(Count = 15)]
	[DeduplicatedMethod]
	public TrackEntry get_MixingFrom() { }

	[CallerCount(Count = 62)]
	[DeduplicatedMethod]
	public TrackEntry get_MixingTo() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public float get_MixTime() { }

	[CallerCount(Count = 12)]
	[DeduplicatedMethod]
	public TrackEntry get_Next() { }

	[CallerCount(Count = 31)]
	[DeduplicatedMethod]
	public TrackEntry get_Previous() { }

	[CallerCount(Count = 0)]
	public bool get_Reverse() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public float get_TimeScale() { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public float get_TrackComplete() { }

	[CallerCount(Count = 0)]
	public float get_TrackEnd() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public int get_TrackIndex() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public float get_TrackTime() { }

	[CalledBy(Type = typeof(EventQueue), Member = "Drain", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	internal void OnComplete() { }

	[CalledBy(Type = typeof(EventQueue), Member = "Drain", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	internal void OnDispose() { }

	[CalledBy(Type = typeof(EventQueue), Member = "Drain", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	internal void OnEnd() { }

	[CalledBy(Type = typeof(EventQueue), Member = "Drain", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	internal void OnEvent(Event e) { }

	[CalledBy(Type = typeof(EventQueue), Member = "Drain", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	internal void OnInterrupt() { }

	[CalledBy(Type = typeof(EventQueue), Member = "Drain", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	internal void OnStart() { }

	[CallerCount(Count = 0)]
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

	[CallerCount(Count = 0)]
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
	[Calls(Type = typeof(ExposedList`1), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 12)]
	public override void Reset() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ExposedList`1), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void ResetRotationDirections() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void set_Alpha(float value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void set_AnimationEnd(float value) { }

	[CallerCount(Count = 0)]
	public void set_AnimationLast(float value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void set_AnimationStart(float value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void set_AttachmentThreshold(float value) { }

	[CallerCount(Count = 0)]
	public void set_Delay(float value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void set_DrawOrderThreshold(float value) { }

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public void set_EventThreshold(float value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void set_HoldPrevious(bool value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void set_Loop(bool value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void set_MixBlend(MixBlend value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void set_MixDuration(float value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void set_MixTime(float value) { }

	[CallerCount(Count = 0)]
	public void set_Reverse(bool value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void set_TimeScale(float value) { }

	[CallerCount(Count = 0)]
	public void set_TrackEnd(float value) { }

	[CallerCount(Count = 0)]
	public void set_TrackTime(float value) { }

	[CallerCount(Count = 0)]
	public virtual string ToString() { }

}

