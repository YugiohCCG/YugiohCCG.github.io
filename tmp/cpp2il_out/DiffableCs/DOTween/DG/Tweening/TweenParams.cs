namespace DG.Tweening;

public class TweenParams
{
	public static readonly TweenParams Params; //Field offset: 0x0
	internal object id; //Field offset: 0x10
	internal object target; //Field offset: 0x18
	internal UpdateType updateType; //Field offset: 0x20
	internal bool isIndependentUpdate; //Field offset: 0x24
	internal TweenCallback onStart; //Field offset: 0x28
	internal TweenCallback onPlay; //Field offset: 0x30
	internal TweenCallback onRewind; //Field offset: 0x38
	internal TweenCallback onUpdate; //Field offset: 0x40
	internal TweenCallback onStepComplete; //Field offset: 0x48
	internal TweenCallback onComplete; //Field offset: 0x50
	internal TweenCallback onKill; //Field offset: 0x58
	internal TweenCallback<Int32> onWaypointChange; //Field offset: 0x60
	internal bool isRecyclable; //Field offset: 0x68
	internal bool isSpeedBased; //Field offset: 0x69
	internal bool autoKill; //Field offset: 0x6A
	internal int loops; //Field offset: 0x6C
	internal LoopType loopType; //Field offset: 0x70
	internal float delay; //Field offset: 0x74
	internal bool isRelative; //Field offset: 0x78
	internal Ease easeType; //Field offset: 0x7C
	internal EaseFunction customEase; //Field offset: 0x80
	internal float easeOvershootOrAmplitude; //Field offset: 0x88
	internal float easePeriod; //Field offset: 0x8C

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 12)]
	private static TweenParams() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 11)]
	public TweenParams() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 11)]
	public TweenParams Clear() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public TweenParams OnComplete(TweenCallback action) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public TweenParams OnKill(TweenCallback action) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public TweenParams OnPlay(TweenCallback action) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public TweenParams OnRewind(TweenCallback action) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public TweenParams OnStart(TweenCallback action) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public TweenParams OnStepComplete(TweenCallback action) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public TweenParams OnUpdate(TweenCallback action) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public TweenParams OnWaypointChange(TweenCallback<Int32> action) { }

	[CallerCount(Count = 0)]
	public TweenParams SetAutoKill(bool autoKillOnCompletion = true) { }

	[CallerCount(Count = 0)]
	public TweenParams SetDelay(float delay) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public TweenParams SetEase(EaseFunction customEase) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	public TweenParams SetEase(AnimationCurve animCurve) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.Nullable`1<System.Single>), Member = "get_Value", ReturnType = typeof(float))]
	[CallsUnknownMethods(Count = 1)]
	public TweenParams SetEase(Ease ease, Nullable<Single> overshootOrAmplitude = null, Nullable<Single> period = null) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public TweenParams SetId(object id) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Nullable`1), Member = "get_Value", ReturnType = "T")]
	public TweenParams SetLoops(int loops, Nullable<LoopType> loopType = null) { }

	[CallerCount(Count = 0)]
	public TweenParams SetRecyclable(bool recyclable = true) { }

	[CallerCount(Count = 0)]
	public TweenParams SetRelative(bool isRelative = true) { }

	[CallerCount(Count = 0)]
	public TweenParams SetSpeedBased(bool isSpeedBased = true) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public TweenParams SetTarget(object target) { }

	[CallerCount(Count = 0)]
	public TweenParams SetUpdate(bool isIndependentUpdate) { }

	[CallerCount(Count = 0)]
	public TweenParams SetUpdate(UpdateType updateType, bool isIndependentUpdate = false) { }

}

