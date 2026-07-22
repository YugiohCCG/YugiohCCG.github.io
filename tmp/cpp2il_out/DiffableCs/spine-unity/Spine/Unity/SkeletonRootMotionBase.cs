namespace Spine.Unity;

public abstract class SkeletonRootMotionBase : MonoBehaviour
{
	internal struct RootMotionInfo
	{
		public Vector2 start; //Field offset: 0x0
		public Vector2 current; //Field offset: 0x8
		public Vector2 mid; //Field offset: 0x10
		public Vector2 end; //Field offset: 0x18
		public bool timeIsPastMid; //Field offset: 0x20

	}

	[SerializeField]
	[SpineBone(null, null, True, False)]
	protected string rootMotionBoneName; //Field offset: 0x20
	public bool transformPositionX; //Field offset: 0x28
	public bool transformPositionY; //Field offset: 0x29
	public float rootMotionScaleX; //Field offset: 0x2C
	public float rootMotionScaleY; //Field offset: 0x30
	public float rootMotionTranslateXPerY; //Field offset: 0x34
	public float rootMotionTranslateYPerX; //Field offset: 0x38
	[Header("Optional")]
	public Rigidbody2D rigidBody2D; //Field offset: 0x40
	public bool applyRigidbody2DGravity; //Field offset: 0x48
	public Rigidbody rigidBody; //Field offset: 0x50
	protected ISkeletonComponent skeletonComponent; //Field offset: 0x58
	protected Bone rootMotionBone; //Field offset: 0x60
	protected int rootMotionBoneIndex; //Field offset: 0x68
	protected List<Bone> topLevelBones; //Field offset: 0x70
	protected Vector2 initialOffset; //Field offset: 0x78
	protected Vector2 tempSkeletonDisplacement; //Field offset: 0x80
	protected Vector2 rigidbodyDisplacement; //Field offset: 0x88

	protected override float AdditionalScale
	{
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 9
	}

	public bool UsesRigidbody
	{
		[CalledBy(Type = typeof(SkeletonRootMotionBase), Member = "AdjustRootMotionToDistance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(int), typeof(bool), typeof(bool), typeof(float), typeof(float), typeof(float), typeof(float), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(SkeletonRootMotionBase), Member = "ApplyRootMotion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(Vector2)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		 get { } //Length: 144
	}

	[CalledBy(Type = typeof(SkeletonMecanimRootMotion), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SkeletonRootMotion), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	protected SkeletonRootMotionBase() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Transform), Member = "InverseTransformVector", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(SkeletonRootMotionBase), Member = "GetScaleAffectingRootMotion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2&)}, ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(SkeletonRootMotionBase), Member = "get_UsesRigidbody", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Math), Member = "Max", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(Math), Member = "Min", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(float))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public void AdjustRootMotionToDistance(Vector2 distanceToTarget, int trackIndex = 0, bool adjustX = true, bool adjustY = true, float minX = 0, float maxX = 3.4028235E+38, float minY = 0, float maxY = 3.4028235E+38, bool allowXTranslation = false, bool allowYTranslation = false) { }

	[CalledBy(Type = typeof(SkeletonRootMotionBase), Member = "HandleUpdateLocal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ISkeletonAnimation)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SkeletonRootMotionBase), Member = "get_UsesRigidbody", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Transform), Member = "get_position", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Transform), Member = "TransformVector", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Transform), Member = "set_position", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SkeletonRootMotionBase), Member = "ClearEffectiveBoneOffsets", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SkeletonRootMotionBase), Member = "SetEffectiveBoneOffsetsTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(Vector2)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private void ApplyRootMotion(Vector2 skeletonDelta, Vector2 parentBoneScale) { }

	protected abstract Vector2 CalculateAnimationsMovementDelta() { }

	[CalledBy(Type = typeof(SkeletonRootMotionBase), Member = "FixedUpdate", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SkeletonRootMotionBase), Member = "ApplyRootMotion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(Vector2)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(SkeletonRootMotionBase), Member = "SetEffectiveBoneOffsetsTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(Vector2)}, ReturnType = typeof(void))]
	private void ClearEffectiveBoneOffsets(Vector2 parentBoneScale) { }

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Component), Member = "GetComponentInParent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[CallsUnknownMethods(Count = 4)]
	[DeduplicatedMethod]
	protected void FindRigidbodyComponent() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Behaviour), Member = "get_isActiveAndEnabled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Time), Member = "get_fixedDeltaTime", ReturnType = typeof(float))]
	[Calls(Type = typeof(Rigidbody2D), Member = "get_gravityScale", ReturnType = typeof(float))]
	[Calls(Type = typeof(Physics2D), Member = "get_gravity", ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(Rigidbody2D), Member = "set_velocity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Transform), Member = "get_position", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Rigidbody2D), Member = "MovePosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Rigidbody), Member = "MovePosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SkeletonRootMotionBase), Member = "GetScaleAffectingRootMotion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2&)}, ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(SkeletonRootMotionBase), Member = "ClearEffectiveBoneOffsets", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	protected override void FixedUpdate() { }

	[CalledBy(Type = typeof(SkeletonRootMotionBase), Member = "Start", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ExposedList`1), Member = "GetEnumerator", ReturnType = "Spine.ExposedList`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(Spine.ExposedList`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 6)]
	private void GatherTopLevelBones() { }

	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	protected override float get_AdditionalScale() { }

	[CalledBy(Type = typeof(SkeletonRootMotionBase), Member = "AdjustRootMotionToDistance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(int), typeof(bool), typeof(bool), typeof(float), typeof(float), typeof(float), typeof(float), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SkeletonRootMotionBase), Member = "ApplyRootMotion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(Vector2)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	public bool get_UsesRigidbody() { }

	[CalledBy(Type = typeof(SkeletonMecanimRootMotion), Member = "GetRemainingRootMotion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Vector2))]
	[CalledBy(Type = typeof(SkeletonMecanimRootMotion), Member = "OnClipApplied", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Animation), typeof(int), typeof(float), typeof(float), typeof(float), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SkeletonRootMotion), Member = "GetRemainingRootMotion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Vector2))]
	[CalledBy(Type = typeof(SkeletonRootMotion), Member = "CalculateAnimationsMovementDelta", ReturnType = typeof(Vector2))]
	[CalledBy(Type = typeof(SkeletonRootMotionBase), Member = "GetAnimationRootMotion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Animation)}, ReturnType = typeof(Vector2))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(TimelineExtensions), Member = "FindTranslateTimelineForBone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Animation), typeof(int)}, ReturnType = typeof(TranslateTimeline))]
	[Calls(Type = typeof(TimelineExtensions), Member = "FindTimelineForBone", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Animation), typeof(int)}, ReturnType = "T")]
	[Calls(Type = typeof(TimelineExtensions), Member = "Evaluate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TranslateXTimeline), typeof(TranslateYTimeline), typeof(float), typeof(SkeletonData)}, ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(TimelineExtensions), Member = "Evaluate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TranslateTimeline), typeof(float), typeof(SkeletonData)}, ReturnType = typeof(Vector2))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public Vector2 GetAnimationRootMotion(float startTime, float endTime, Animation animation) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SkeletonRootMotionBase), Member = "GetAnimationRootMotion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(Animation)}, ReturnType = typeof(Vector2))]
	[CallsUnknownMethods(Count = 1)]
	public Vector2 GetAnimationRootMotion(Animation animation) { }

	[CalledBy(Type = typeof(SkeletonMecanimRootMotion), Member = "GetRootMotionInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(RootMotionInfo))]
	[CalledBy(Type = typeof(SkeletonRootMotion), Member = "GetRootMotionInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(RootMotionInfo))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(TimelineExtensions), Member = "FindTranslateTimelineForBone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Animation), typeof(int)}, ReturnType = typeof(TranslateTimeline))]
	[Calls(Type = typeof(TimelineExtensions), Member = "FindTimelineForBone", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Animation), typeof(int)}, ReturnType = "T")]
	[Calls(Type = typeof(TimelineExtensions), Member = "Evaluate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TranslateXTimeline), typeof(TranslateYTimeline), typeof(float), typeof(SkeletonData)}, ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(TimelineExtensions), Member = "Evaluate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TranslateTimeline), typeof(float), typeof(SkeletonData)}, ReturnType = typeof(Vector2))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public RootMotionInfo GetAnimationRootMotionInfo(Animation animation, float currentTime) { }

	public abstract Vector2 GetRemainingRootMotion(int trackIndex = 0) { }

	public abstract RootMotionInfo GetRootMotionInfo(int trackIndex = 0) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SkeletonRootMotionBase), Member = "GetScaleAffectingRootMotion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2&)}, ReturnType = typeof(Vector2))]
	private Vector2 GetScaleAffectingRootMotion() { }

	[CalledBy(Type = typeof(SkeletonRootMotionBase), Member = "FixedUpdate", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SkeletonRootMotionBase), Member = "AdjustRootMotionToDistance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(int), typeof(bool), typeof(bool), typeof(float), typeof(float), typeof(float), typeof(float), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SkeletonRootMotionBase), Member = "HandleUpdateLocal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ISkeletonAnimation)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SkeletonRootMotionBase), Member = "GetScaleAffectingRootMotion", ReturnType = typeof(Vector2))]
	[CalledBy(Type = typeof(SkeletonRootMotionBase), Member = "GetSkeletonSpaceMovementDelta", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(Vector2&)}, ReturnType = typeof(Vector2))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(Skeleton), Member = "get_ScaleY", ReturnType = typeof(float))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private Vector2 GetScaleAffectingRootMotion(out Vector2 parentBoneScale) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SkeletonRootMotionBase), Member = "GetScaleAffectingRootMotion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2&)}, ReturnType = typeof(Vector2))]
	private Vector2 GetSkeletonSpaceMovementDelta(Vector2 boneLocalDelta, out Vector2 parentBoneScale) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TimelineExtensions), Member = "Evaluate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TranslateTimeline), typeof(float), typeof(SkeletonData)}, ReturnType = typeof(Vector2))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private Vector2 GetTimelineMovementDelta(float startTime, float endTime, TranslateTimeline timeline, Animation animation) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TimelineExtensions), Member = "Evaluate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TranslateXTimeline), typeof(TranslateYTimeline), typeof(float), typeof(SkeletonData)}, ReturnType = typeof(Vector2))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private Vector2 GetTimelineMovementDelta(float startTime, float endTime, TranslateXTimeline xTimeline, TranslateYTimeline yTimeline, Animation animation) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Behaviour), Member = "get_isActiveAndEnabled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(SkeletonRootMotionBase), Member = "GetScaleAffectingRootMotion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2&)}, ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(SkeletonRootMotionBase), Member = "ApplyRootMotion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(Vector2)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	private void HandleUpdateLocal(ISkeletonAnimation animatedSkeletonComponent) { }

	[CallerCount(Count = 0)]
	protected override void OnDisable() { }

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Component), Member = "GetComponentInParent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[CallsUnknownMethods(Count = 4)]
	[DeduplicatedMethod]
	protected override void Reset() { }

	[CalledBy(Type = typeof(SkeletonRootMotionBase), Member = "ApplyRootMotion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(Vector2)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SkeletonRootMotionBase), Member = "ClearEffectiveBoneOffsets", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Skeleton), Member = "get_ScaleY", ReturnType = typeof(float))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 12)]
	private void SetEffectiveBoneOffsetsTo(Vector2 displacementSkeletonSpace, Vector2 parentBoneScale) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Skeleton), Member = "FindBone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Bone))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Skeleton), Member = "get_RootBone", ReturnType = typeof(Bone))]
	[CallsUnknownMethods(Count = 3)]
	public void SetRootMotionBone(string name) { }

	[CalledBy(Type = typeof(SkeletonMecanimRootMotion), Member = "Start", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SkeletonRootMotion), Member = "Start", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(SkeletonRootMotionBase), Member = "GatherTopLevelBones", ReturnType = typeof(void))]
	[Calls(Type = typeof(Skeleton), Member = "FindBone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Bone))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Skeleton), Member = "get_RootBone", ReturnType = typeof(Bone))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 7)]
	protected override void Start() { }

}

