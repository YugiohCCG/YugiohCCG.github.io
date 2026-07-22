namespace Spine.Unity;

[HelpURL("http://esotericsoftware.com/spine-unity#SkeletonRootMotion")]
public class SkeletonRootMotion : SkeletonRootMotionBase
{
	private const int DefaultAnimationTrackFlags = -1; //Field offset: 0x0
	public int animationTrackFlags; //Field offset: 0x90
	private AnimationState animationState; //Field offset: 0x98
	private Canvas canvas; //Field offset: 0xA0

	protected virtual float AdditionalScale
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Canvas), Member = "get_referencePixelsPerUnit", ReturnType = typeof(float))]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 136
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SkeletonRootMotionBase), Member = ".ctor", ReturnType = typeof(void))]
	[DeduplicatedMethod]
	public SkeletonRootMotion() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private void ApplyMixAlphaToDelta(ref Vector2 currentDelta, TrackEntry next, TrackEntry track) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AnimationState), Member = "GetCurrent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(TrackEntry))]
	[Calls(Type = typeof(TrackEntry), Member = "get_AnimationTime", ReturnType = typeof(float))]
	[Calls(Type = typeof(SkeletonRootMotionBase), Member = "GetAnimationRootMotion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(Animation)}, ReturnType = typeof(Vector2))]
	[Calls(Type = "UnityEngine.Rendering.MousePositionDebug", Member = "GetMouseClickPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(Vector2))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	protected virtual Vector2 CalculateAnimationsMovementDelta() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Canvas), Member = "get_referencePixelsPerUnit", ReturnType = typeof(float))]
	[CallsUnknownMethods(Count = 1)]
	protected virtual float get_AdditionalScale() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AnimationState), Member = "GetCurrent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(TrackEntry))]
	[Calls(Type = typeof(TrackEntry), Member = "get_AnimationTime", ReturnType = typeof(float))]
	[Calls(Type = typeof(SkeletonRootMotionBase), Member = "GetAnimationRootMotion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(Animation)}, ReturnType = typeof(Vector2))]
	[CallsUnknownMethods(Count = 1)]
	public virtual Vector2 GetRemainingRootMotion(int trackIndex) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AnimationState), Member = "GetCurrent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(TrackEntry))]
	[Calls(Type = typeof(TrackEntry), Member = "get_AnimationTime", ReturnType = typeof(float))]
	[Calls(Type = typeof(SkeletonRootMotionBase), Member = "GetAnimationRootMotionInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Animation), typeof(float)}, ReturnType = typeof(RootMotionInfo))]
	[CallsUnknownMethods(Count = 1)]
	public virtual RootMotionInfo GetRootMotionInfo(int trackIndex) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	protected virtual void Reset() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SkeletonRootMotionBase), Member = "Start", ReturnType = typeof(void))]
	[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Component), Member = "GetComponentInParent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	protected virtual void Start() { }

}

