namespace Spine;

public class Skeleton
{
	internal SkeletonData data; //Field offset: 0x10
	internal ExposedList<Bone> bones; //Field offset: 0x18
	internal ExposedList<Slot> slots; //Field offset: 0x20
	internal ExposedList<Slot> drawOrder; //Field offset: 0x28
	internal ExposedList<IkConstraint> ikConstraints; //Field offset: 0x30
	internal ExposedList<TransformConstraint> transformConstraints; //Field offset: 0x38
	internal ExposedList<PathConstraint> pathConstraints; //Field offset: 0x40
	internal ExposedList<IUpdatable> updateCache; //Field offset: 0x48
	internal Skin skin; //Field offset: 0x50
	internal float r; //Field offset: 0x58
	internal float g; //Field offset: 0x5C
	internal float b; //Field offset: 0x60
	internal float a; //Field offset: 0x64
	internal float time; //Field offset: 0x68
	private float scaleX; //Field offset: 0x6C
	private float scaleY; //Field offset: 0x70
	internal float x; //Field offset: 0x74
	internal float y; //Field offset: 0x78

	public float A
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 6
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 set { } //Length: 6
	}

	public float B
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 6
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 set { } //Length: 6
	}

	public ExposedList<Bone> Bones
	{
		[CallerCount(Count = 31)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public SkeletonData Data
	{
		[CallerCount(Count = 106)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public ExposedList<Slot> DrawOrder
	{
		[CallerCount(Count = 15)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	[Obsolete("Use ScaleX instead. FlipX is when ScaleX is negative.")]
	public bool FlipX
	{
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 11
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		 set { } //Length: 46
	}

	[Obsolete("Use ScaleY instead. FlipY is when ScaleY is negative.")]
	public bool FlipY
	{
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 11
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		 set { } //Length: 46
	}

	public float G
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 6
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 set { } //Length: 6
	}

	public ExposedList<IkConstraint> IkConstraints
	{
		[CallerCount(Count = 62)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public ExposedList<PathConstraint> PathConstraints
	{
		[CallerCount(Count = 12)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public float R
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 6
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 set { } //Length: 6
	}

	public Bone RootBone
	{
		[CalledBy(Type = "Spine.Unity.SkeletonRootMotionBase", Member = "Start", ReturnType = typeof(void))]
		[CalledBy(Type = "Spine.Unity.SkeletonRootMotionBase", Member = "SetRootMotionBone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CalledBy(Type = "Spine.Unity.SkeletonUtility", Member = "SpawnRoot", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Spine.Unity.SkeletonUtilityBone+Mode", typeof(bool), typeof(bool), typeof(bool)}, ReturnType = "UnityEngine.GameObject")]
		[CalledBy(Type = "Spine.Unity.SkeletonUtility", Member = "SpawnHierarchy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Spine.Unity.SkeletonUtilityBone+Mode", typeof(bool), typeof(bool), typeof(bool)}, ReturnType = "UnityEngine.GameObject")]
		[CallerCount(Count = 4)]
		[CallsUnknownMethods(Count = 2)]
		 get { } //Length: 61
	}

	public float ScaleX
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 6
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 set { } //Length: 6
	}

	public float ScaleY
	{
		[CalledBy(Type = typeof(Bone), Member = "UpdateWorldTransform", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = "Spine.Unity.BoneFollower", Member = "LateUpdate", ReturnType = typeof(void))]
		[CalledBy(Type = "Spine.Unity.BoneFollowerGraphic", Member = "LateUpdate", ReturnType = typeof(void))]
		[CalledBy(Type = "Spine.Unity.PointFollower", Member = "LateUpdate", ReturnType = typeof(void))]
		[CalledBy(Type = "Spine.Unity.SkeletonRootMotionBase", Member = "GetScaleAffectingRootMotion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Vector2&"}, ReturnType = "UnityEngine.Vector2")]
		[CalledBy(Type = "Spine.Unity.SkeletonRootMotionBase", Member = "SetEffectiveBoneOffsetsTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Vector2", "UnityEngine.Vector2"}, ReturnType = typeof(void))]
		[CalledBy(Type = "Spine.Unity.SkeletonUtility", Member = "Update", ReturnType = typeof(void))]
		[CalledBy(Type = "Spine.Unity.SkeletonUtilityBone", Member = "DoUpdate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Spine.Unity.SkeletonUtilityBone+UpdatePhase"}, ReturnType = typeof(void))]
		[CalledBy(Type = "Spine.Unity.SkeletonExtensions", Member = "GetLocalScale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Skeleton)}, ReturnType = "UnityEngine.Vector2")]
		[CallerCount(Count = 13)]
		 get { } //Length: 85
		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		 set { } //Length: 6
	}

	public Skin Skin
	{
		[CallerCount(Count = 16)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Skeleton), Member = "SetSkin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Skin)}, ReturnType = typeof(void))]
		 set { } //Length: 8
	}

	public ExposedList<Slot> Slots
	{
		[CallerCount(Count = 12)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public float Time
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 6
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 set { } //Length: 6
	}

	public ExposedList<TransformConstraint> TransformConstraints
	{
		[CallerCount(Count = 38)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public ExposedList<IUpdatable> UpdateCacheList
	{
		[CallerCount(Count = 10)]
		[DeduplicatedMethod]
		 get { } //Length: 254
	}

	public float X
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 6
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 set { } //Length: 6
	}

	public float Y
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 6
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 set { } //Length: 6
	}

	[CalledBy(Type = "Spine.Unity.SkeletonGraphic", Member = "Initialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Spine.Unity.SkeletonRenderer", Member = "Initialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ExposedList`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ExposedList`1), Member = "GetEnumerator", ReturnType = "Spine.ExposedList`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(Spine.ExposedList`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Bone), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BoneData), typeof(Skeleton), typeof(Bone)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Spine.ExposedList`1<System.Object>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Slot), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SlotData), typeof(Bone)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(IkConstraint), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IkConstraintData), typeof(Skeleton)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TransformConstraint), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TransformConstraintData), typeof(Skeleton)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(PathConstraint), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PathConstraintData), typeof(Skeleton)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Skeleton), Member = "UpdateCache", ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 12)]
	[CallsUnknownMethods(Count = 34)]
	public Skeleton(SkeletonData data) { }

	[CalledBy(Type = typeof(IkConstraint), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IkConstraintData), typeof(Skeleton)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Spine.Unity.SpineBone", Member = "GetBone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "Spine.Unity.SkeletonRenderer"}, ReturnType = typeof(Bone))]
	[CalledBy(Type = "Spine.Unity.SkeletonUtilityBone", Member = "DoUpdate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Spine.Unity.SkeletonUtilityBone+UpdatePhase"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Spine.Unity.SkeletonRootMotionBase", Member = "SetRootMotionBone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Spine.Unity.SkeletonRootMotionBase", Member = "Start", ReturnType = typeof(void))]
	[CalledBy(Type = "Spine.Unity.BoneFollowerGraphic", Member = "Initialize", ReturnType = typeof(void))]
	[CalledBy(Type = "Spine.Unity.BoneFollowerGraphic", Member = "LateUpdate", ReturnType = typeof(void))]
	[CalledBy(Type = "Spine.Unity.BoneFollower", Member = "LateUpdate", ReturnType = typeof(void))]
	[CalledBy(Type = "Spine.Unity.BoneFollower", Member = "Initialize", ReturnType = typeof(void))]
	[CalledBy(Type = "Spine.Unity.BoneFollower", Member = "SetBone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TransformConstraint), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TransformConstraintData), typeof(Skeleton)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PathConstraint), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PathConstraintData), typeof(Skeleton)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Spine.Unity.BoneFollowerGraphic", Member = "SetBone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 17)]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	public Bone FindBone(string boneName) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	public IkConstraint FindIkConstraint(string constraintName) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 7)]
	public PathConstraint FindPathConstraint(string constraintName) { }

	[CalledBy(Type = "Spine.Unity.BoundingBoxFollower", Member = "Initialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Spine.Unity.BoundingBoxFollowerGraphic", Member = "Initialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Spine.Unity.PointFollower", Member = "UpdateReferences", ReturnType = typeof(void))]
	[CalledBy(Type = "Spine.Unity.SkeletonGraphic", Member = "ReapplySeparatorSlotNames", ReturnType = typeof(void))]
	[CalledBy(Type = "Spine.Unity.SkeletonGraphic", Member = "Initialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Spine.Unity.SkeletonRenderer", Member = "Initialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Spine.Unity.SkeletonRenderer", Member = "ReapplySeparatorSlotNames", ReturnType = typeof(void))]
	[CalledBy(Type = "Spine.Unity.SkeletonRendererCustomMaterials", Member = "SetCustomSlotMaterials", ReturnType = typeof(void))]
	[CalledBy(Type = "Spine.Unity.SkeletonRendererCustomMaterials", Member = "RemoveCustomSlotMaterials", ReturnType = typeof(void))]
	[CalledBy(Type = "Spine.Unity.SkeletonRendererCustomMaterials", Member = "OnEnable", ReturnType = typeof(void))]
	[CalledBy(Type = "Spine.Unity.SkeletonUtility", Member = "AddBoundingBoxGameObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Skeleton), typeof(string), typeof(string), typeof(string), "UnityEngine.Transform", typeof(bool)}, ReturnType = "UnityEngine.PolygonCollider2D")]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	public Slot FindSlot(string slotName) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	public TransformConstraint FindTransformConstraint(string constraintName) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public float get_A() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public float get_B() { }

	[CallerCount(Count = 31)]
	[DeduplicatedMethod]
	public ExposedList<Bone> get_Bones() { }

	[CallerCount(Count = 106)]
	[DeduplicatedMethod]
	public SkeletonData get_Data() { }

	[CallerCount(Count = 15)]
	[DeduplicatedMethod]
	public ExposedList<Slot> get_DrawOrder() { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public bool get_FlipX() { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public bool get_FlipY() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public float get_G() { }

	[CallerCount(Count = 62)]
	[DeduplicatedMethod]
	public ExposedList<IkConstraint> get_IkConstraints() { }

	[CallerCount(Count = 12)]
	[DeduplicatedMethod]
	public ExposedList<PathConstraint> get_PathConstraints() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public float get_R() { }

	[CalledBy(Type = "Spine.Unity.SkeletonRootMotionBase", Member = "Start", ReturnType = typeof(void))]
	[CalledBy(Type = "Spine.Unity.SkeletonRootMotionBase", Member = "SetRootMotionBone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Spine.Unity.SkeletonUtility", Member = "SpawnRoot", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Spine.Unity.SkeletonUtilityBone+Mode", typeof(bool), typeof(bool), typeof(bool)}, ReturnType = "UnityEngine.GameObject")]
	[CalledBy(Type = "Spine.Unity.SkeletonUtility", Member = "SpawnHierarchy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Spine.Unity.SkeletonUtilityBone+Mode", typeof(bool), typeof(bool), typeof(bool)}, ReturnType = "UnityEngine.GameObject")]
	[CallerCount(Count = 4)]
	[CallsUnknownMethods(Count = 2)]
	public Bone get_RootBone() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public float get_ScaleX() { }

	[CalledBy(Type = typeof(Bone), Member = "UpdateWorldTransform", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Spine.Unity.BoneFollower", Member = "LateUpdate", ReturnType = typeof(void))]
	[CalledBy(Type = "Spine.Unity.BoneFollowerGraphic", Member = "LateUpdate", ReturnType = typeof(void))]
	[CalledBy(Type = "Spine.Unity.PointFollower", Member = "LateUpdate", ReturnType = typeof(void))]
	[CalledBy(Type = "Spine.Unity.SkeletonRootMotionBase", Member = "GetScaleAffectingRootMotion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Vector2&"}, ReturnType = "UnityEngine.Vector2")]
	[CalledBy(Type = "Spine.Unity.SkeletonRootMotionBase", Member = "SetEffectiveBoneOffsetsTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Vector2", "UnityEngine.Vector2"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Spine.Unity.SkeletonUtility", Member = "Update", ReturnType = typeof(void))]
	[CalledBy(Type = "Spine.Unity.SkeletonUtilityBone", Member = "DoUpdate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Spine.Unity.SkeletonUtilityBone+UpdatePhase"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Spine.Unity.SkeletonExtensions", Member = "GetLocalScale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Skeleton)}, ReturnType = "UnityEngine.Vector2")]
	[CallerCount(Count = 13)]
	public float get_ScaleY() { }

	[CallerCount(Count = 16)]
	[DeduplicatedMethod]
	public Skin get_Skin() { }

	[CallerCount(Count = 12)]
	[DeduplicatedMethod]
	public ExposedList<Slot> get_Slots() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public float get_Time() { }

	[CallerCount(Count = 38)]
	[DeduplicatedMethod]
	public ExposedList<TransformConstraint> get_TransformConstraints() { }

	[CallerCount(Count = 10)]
	[DeduplicatedMethod]
	public ExposedList<IUpdatable> get_UpdateCacheList() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public float get_X() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public float get_Y() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SkeletonData), Member = "FindSlot", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(SlotData))]
	[Calls(Type = typeof(Skin), Member = "GetAttachment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string)}, ReturnType = typeof(Attachment))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 6)]
	public Attachment GetAttachment(string slotName, string attachmentName) { }

	[CalledBy(Type = typeof(AttachmentTimeline), Member = "Apply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Skeleton), typeof(float), typeof(float), typeof(Spine.ExposedList`1<Spine.Event>), typeof(float), typeof(MixBlend), typeof(MixDirection)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(AttachmentTimeline), Member = "SetAttachment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Skeleton), typeof(Slot), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(AnimationState), Member = "Apply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Skeleton)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(AnimationState), Member = "ApplyAttachmentTimeline", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AttachmentTimeline), typeof(Skeleton), typeof(float), typeof(MixBlend), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(AnimationState), Member = "SetAttachment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Skeleton), typeof(Slot), typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Skeleton), Member = "SetAttachment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Slot), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SlotData), typeof(Bone)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Slot), Member = "SetToSetupPose", ReturnType = typeof(void))]
	[CalledBy(Type = "Spine.Unity.PointFollower", Member = "UpdateReferences", ReturnType = typeof(void))]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(Skin), Member = "GetAttachment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string)}, ReturnType = typeof(Attachment))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 6)]
	public Attachment GetAttachment(int slotIndex, string attachmentName) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RegionAttachment), Member = "ComputeWorldVertices", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Bone), typeof(Single[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VertexAttachment), Member = "ComputeWorldVertices", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Slot), typeof(int), typeof(int), typeof(Single[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Math), Member = "Min", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(Math), Member = "Max", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(float))]
	[CallsUnknownMethods(Count = 3)]
	public void GetBounds(out float x, out float y, out float width, out float height, ref Single[] vertexBuffer) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void set_A(float value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void set_B(float value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public void set_FlipX(bool value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public void set_FlipY(bool value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void set_G(float value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void set_R(float value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void set_ScaleX(float value) { }

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public void set_ScaleY(float value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Skeleton), Member = "SetSkin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Skin)}, ReturnType = typeof(void))]
	public void set_Skin(Skin value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void set_Time(float value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void set_X(float value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void set_Y(float value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Skeleton), Member = "GetAttachment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string)}, ReturnType = typeof(Attachment))]
	[Calls(Type = typeof(Slot), Member = "set_Attachment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Attachment)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Exception), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 16)]
	public void SetAttachment(string slotName, string attachmentName) { }

	[CalledBy(Type = typeof(Skeleton), Member = "SetToSetupPose", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void SetBonesToSetupPose() { }

	[CalledBy(Type = typeof(Skeleton), Member = "set_Skin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Skin)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Skeleton), Member = "SetSkin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Skin), Member = "GetAttachment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string)}, ReturnType = typeof(Attachment))]
	[Calls(Type = typeof(Slot), Member = "set_Attachment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Attachment)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Skin), Member = "AttachAll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Skeleton), typeof(Skin)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Skeleton), Member = "UpdateCache", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public void SetSkin(Skin newSkin) { }

	[CalledBy(Type = "Spine.Unity.SkeletonGraphic", Member = "Initialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Spine.Unity.SkeletonRenderer", Member = "Initialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(SkeletonData), Member = "FindSkin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Skin))]
	[Calls(Type = typeof(Skeleton), Member = "SetSkin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Skin)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 6)]
	public void SetSkin(string skinName) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Slot), Member = "SetToSetupPose", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	public void SetSlotsToSetupPose() { }

	[CalledBy(Type = "Spine.Unity.SkeletonRenderer", Member = "ClearState", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Skeleton), Member = "SetBonesToSetupPose", ReturnType = typeof(void))]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Slot), Member = "SetToSetupPose", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	public void SetToSetupPose() { }

	[CalledBy(Type = typeof(Skeleton), Member = "UpdateCache", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Skeleton), Member = "SortIkConstraint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IkConstraint)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Skeleton), Member = "SortPathConstraint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PathConstraint)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Skeleton), Member = "SortTransformConstraint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TransformConstraint)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Skeleton), Member = "SortPathConstraintAttachment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Attachment), typeof(Bone)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Skeleton), Member = "SortBone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Bone)}, ReturnType = typeof(void))]
	[CallerCount(Count = 12)]
	[Calls(Type = typeof(Skeleton), Member = "SortBone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Bone)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Spine.ExposedList`1<System.Object>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private void SortBone(Bone bone) { }

	[CalledBy(Type = typeof(Skeleton), Member = "UpdateCache", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Spine.ExposedList`1<System.Object>), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Skeleton), Member = "SortBone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Bone)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Spine.ExposedList`1<System.Object>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Skeleton), Member = "SortReset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Spine.ExposedList`1<Spine.Bone>)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	private void SortIkConstraint(IkConstraint constraint) { }

	[CalledBy(Type = typeof(Skeleton), Member = "UpdateCache", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Spine.ExposedList`1<System.Object>), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Skeleton), Member = "SortPathConstraintAttachment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Skin), typeof(int), typeof(Bone)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Skeleton), Member = "SortPathConstraintAttachment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Attachment), typeof(Bone)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Skeleton), Member = "SortBone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Bone)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Spine.ExposedList`1<System.Object>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Skeleton), Member = "SortReset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Spine.ExposedList`1<Spine.Bone>)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	private void SortPathConstraint(PathConstraint constraint) { }

	[CalledBy(Type = typeof(Skeleton), Member = "SortPathConstraint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PathConstraint)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Skeleton), Member = "SortPathConstraintAttachment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Skin), typeof(int), typeof(Bone)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Skeleton), Member = "SortBone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Bone)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Spine.ExposedList`1<System.Object>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	private void SortPathConstraintAttachment(Attachment attachment, Bone slotBone) { }

	[CalledBy(Type = typeof(Skeleton), Member = "SortPathConstraint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PathConstraint)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Skin), Member = "get_Attachments", ReturnType = typeof(System.Collections.Generic.ICollection`1<Spine.Skin+SkinEntry>))]
	[Calls(Type = typeof(Skeleton), Member = "SortPathConstraintAttachment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Attachment), typeof(Bone)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 9)]
	private void SortPathConstraintAttachment(Skin skin, int slotIndex, Bone slotBone) { }

	[CalledBy(Type = typeof(Skeleton), Member = "SortIkConstraint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IkConstraint)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Skeleton), Member = "SortPathConstraint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PathConstraint)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Skeleton), Member = "SortTransformConstraint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TransformConstraint)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Skeleton), Member = "SortReset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Spine.ExposedList`1<Spine.Bone>)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(Skeleton), Member = "SortReset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Spine.ExposedList`1<Spine.Bone>)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	private static void SortReset(ExposedList<Bone> bones) { }

	[CalledBy(Type = typeof(Skeleton), Member = "UpdateCache", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Spine.ExposedList`1<System.Object>), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Skeleton), Member = "SortBone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Bone)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Spine.ExposedList`1<System.Object>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Skeleton), Member = "SortReset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Spine.ExposedList`1<Spine.Bone>)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	private void SortTransformConstraint(TransformConstraint constraint) { }

	[CalledBy(Type = "Spine.Unity.SkeletonAnimation", Member = "Update", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Spine.Unity.SkeletonAnimation", Member = "UpdateAnimationStatus", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Spine.Unity.SkeletonGraphic", Member = "Update", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Spine.Unity.SkeletonGraphic", Member = "UpdateAnimationStatus", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	public void Update(float delta) { }

	[CalledBy(Type = typeof(Skeleton), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SkeletonData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Skeleton), Member = "SetSkin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Skin)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ExposedList`1), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Skeleton), Member = "SortIkConstraint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IkConstraint)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Skeleton), Member = "SortTransformConstraint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TransformConstraint)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Skeleton), Member = "SortPathConstraint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PathConstraint)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Skeleton), Member = "SortBone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Bone)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Spine.ExposedList`1<System.Object>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	public void UpdateCache() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 12)]
	[ContainsUnimplementedInstructions]
	public void UpdateWorldTransform(Bone parent) { }

	[CalledBy(Type = "Spine.Unity.SkeletonAnimation", Member = "Update", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Spine.Unity.SkeletonAnimation", Member = "ApplyAnimation", ReturnType = typeof(void))]
	[CalledBy(Type = "Spine.Unity.SkeletonGraphic", Member = "Update", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Spine.Unity.SkeletonGraphic", Member = "ApplyAnimation", ReturnType = typeof(void))]
	[CalledBy(Type = "Spine.Unity.SkeletonMecanim", Member = "Update", ReturnType = typeof(void))]
	[CalledBy(Type = "Spine.Unity.SkeletonMecanim", Member = "ApplyAnimation", ReturnType = typeof(void))]
	[CalledBy(Type = "Spine.Unity.SkeletonRenderer", Member = "Initialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 13)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public void UpdateWorldTransform() { }

}

