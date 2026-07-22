namespace Spine;

public class Bone : IUpdatable
{
	public static bool yDown; //Field offset: 0x0
	internal BoneData data; //Field offset: 0x10
	internal Skeleton skeleton; //Field offset: 0x18
	internal Bone parent; //Field offset: 0x20
	internal ExposedList<Bone> children; //Field offset: 0x28
	internal float x; //Field offset: 0x30
	internal float y; //Field offset: 0x34
	internal float rotation; //Field offset: 0x38
	internal float scaleX; //Field offset: 0x3C
	internal float scaleY; //Field offset: 0x40
	internal float shearX; //Field offset: 0x44
	internal float shearY; //Field offset: 0x48
	internal float ax; //Field offset: 0x4C
	internal float ay; //Field offset: 0x50
	internal float arotation; //Field offset: 0x54
	internal float ascaleX; //Field offset: 0x58
	internal float ascaleY; //Field offset: 0x5C
	internal float ashearX; //Field offset: 0x60
	internal float ashearY; //Field offset: 0x64
	internal float a; //Field offset: 0x68
	internal float b; //Field offset: 0x6C
	internal float worldX; //Field offset: 0x70
	internal float c; //Field offset: 0x74
	internal float d; //Field offset: 0x78
	internal float worldY; //Field offset: 0x7C
	internal bool sorted; //Field offset: 0x80
	internal bool active; //Field offset: 0x81

	public float A
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 6
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 set { } //Length: 6
	}

	public override bool Active
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 8
	}

	public float AppliedRotation
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 6
		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		 set { } //Length: 6
	}

	public float AScaleX
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 6
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 set { } //Length: 6
	}

	public float AScaleY
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 6
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 set { } //Length: 6
	}

	public float AShearX
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 6
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 set { } //Length: 6
	}

	public float AShearY
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 6
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 set { } //Length: 6
	}

	public float AX
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 6
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 set { } //Length: 6
	}

	public float AY
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

	public float C
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 6
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 set { } //Length: 6
	}

	public ExposedList<Bone> Children
	{
		[CallerCount(Count = 15)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public float D
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 6
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 set { } //Length: 6
	}

	public BoneData Data
	{
		[CallerCount(Count = 106)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public Bone Parent
	{
		[CallerCount(Count = 12)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public float Rotation
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 6
		[CallerCount(Count = 3)]
		[DeduplicatedMethod]
		 set { } //Length: 6
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
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 6
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 set { } //Length: 6
	}

	public float ShearX
	{
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 6
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 set { } //Length: 6
	}

	public float ShearY
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 6
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 set { } //Length: 6
	}

	public Skeleton Skeleton
	{
		[CallerCount(Count = 31)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public float WorldRotationX
	{
		[CalledBy(Type = "Spine.Unity.BoneFollower", Member = "LateUpdate", ReturnType = typeof(void))]
		[CalledBy(Type = "Spine.Unity.BoneFollowerGraphic", Member = "LateUpdate", ReturnType = typeof(void))]
		[CalledBy(Type = "Spine.Unity.SkeletonUtilityBone", Member = "DoUpdate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Spine.Unity.SkeletonUtilityBone+UpdatePhase"}, ReturnType = typeof(void))]
		[CallerCount(Count = 4)]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 166
	}

	public float WorldRotationY
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 166
	}

	public float WorldScaleX
	{
		[CalledBy(Type = "Spine.Unity.BoneFollower", Member = "LateUpdate", ReturnType = typeof(void))]
		[CalledBy(Type = "Spine.Unity.BoneFollowerGraphic", Member = "LateUpdate", ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 179
	}

	public float WorldScaleY
	{
		[CalledBy(Type = "Spine.Unity.BoneFollower", Member = "LateUpdate", ReturnType = typeof(void))]
		[CalledBy(Type = "Spine.Unity.BoneFollowerGraphic", Member = "LateUpdate", ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 179
	}

	public float WorldToLocalRotationX
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(MathUtils), Member = "Atan2", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(float))]
		 get { } //Length: 251
	}

	public float WorldToLocalRotationY
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(MathUtils), Member = "Atan2", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(float))]
		 get { } //Length: 251
	}

	public float WorldX
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 6
		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		 set { } //Length: 6
	}

	public float WorldY
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 6
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 set { } //Length: 6
	}

	public float X
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 6
		[CallerCount(Count = 2)]
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

	[CalledBy(Type = typeof(Skeleton), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SkeletonData)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 15)]
	public Bone(BoneData data, Skeleton skeleton, Bone parent) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public float get_A() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public override bool get_Active() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public float get_AppliedRotation() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public float get_AScaleX() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public float get_AScaleY() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public float get_AShearX() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public float get_AShearY() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public float get_AX() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public float get_AY() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public float get_B() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public float get_C() { }

	[CallerCount(Count = 15)]
	[DeduplicatedMethod]
	public ExposedList<Bone> get_Children() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public float get_D() { }

	[CallerCount(Count = 106)]
	[DeduplicatedMethod]
	public BoneData get_Data() { }

	[CallerCount(Count = 12)]
	[DeduplicatedMethod]
	public Bone get_Parent() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public float get_Rotation() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public float get_ScaleX() { }

	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	public float get_ScaleY() { }

	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	public float get_ShearX() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public float get_ShearY() { }

	[CallerCount(Count = 31)]
	[DeduplicatedMethod]
	public Skeleton get_Skeleton() { }

	[CalledBy(Type = "Spine.Unity.BoneFollower", Member = "LateUpdate", ReturnType = typeof(void))]
	[CalledBy(Type = "Spine.Unity.BoneFollowerGraphic", Member = "LateUpdate", ReturnType = typeof(void))]
	[CalledBy(Type = "Spine.Unity.SkeletonUtilityBone", Member = "DoUpdate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Spine.Unity.SkeletonUtilityBone+UpdatePhase"}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public float get_WorldRotationX() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public float get_WorldRotationY() { }

	[CalledBy(Type = "Spine.Unity.BoneFollower", Member = "LateUpdate", ReturnType = typeof(void))]
	[CalledBy(Type = "Spine.Unity.BoneFollowerGraphic", Member = "LateUpdate", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public float get_WorldScaleX() { }

	[CalledBy(Type = "Spine.Unity.BoneFollower", Member = "LateUpdate", ReturnType = typeof(void))]
	[CalledBy(Type = "Spine.Unity.BoneFollowerGraphic", Member = "LateUpdate", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public float get_WorldScaleY() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MathUtils), Member = "Atan2", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(float))]
	public float get_WorldToLocalRotationX() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MathUtils), Member = "Atan2", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(float))]
	public float get_WorldToLocalRotationY() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public float get_WorldX() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public float get_WorldY() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public float get_X() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public float get_Y() { }

	[CalledBy(Type = typeof(TransformConstraint), Member = "ApplyAbsoluteWorld", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TransformConstraint), Member = "ApplyRelativeWorld", ReturnType = typeof(void))]
	[CalledBy(Type = "Spine.Unity.SkeletonExtensions", Member = "GetSkeletonSpacePosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Bone), "UnityEngine.Vector2"}, ReturnType = "UnityEngine.Vector2")]
	[CallerCount(Count = 3)]
	public void LocalToWorld(float localX, float localY, out float worldX, out float worldY) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	public float LocalToWorldRotation(float localRotation) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	public void RotateWorld(float degrees) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void set_A(float value) { }

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public void set_AppliedRotation(float value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void set_AScaleX(float value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void set_AScaleY(float value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void set_AShearX(float value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void set_AShearY(float value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void set_AX(float value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void set_AY(float value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void set_B(float value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void set_C(float value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void set_D(float value) { }

	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	public void set_Rotation(float value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void set_ScaleX(float value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void set_ScaleY(float value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void set_ShearX(float value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void set_ShearY(float value) { }

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public void set_WorldX(float value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void set_WorldY(float value) { }

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public void set_X(float value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void set_Y(float value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public void SetToSetupPose() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public virtual string ToString() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Bone), Member = "UpdateWorldTransform", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float)}, ReturnType = typeof(void))]
	public override void Update() { }

	[CalledBy(Type = typeof(PathConstraint), Member = "Update", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TransformConstraint), Member = "ApplyAbsoluteWorld", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TransformConstraint), Member = "ApplyRelativeWorld", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(MathUtils), Member = "Atan2", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(float))]
	[CallsUnknownMethods(Count = 5)]
	[ContainsUnimplementedInstructions]
	public void UpdateAppliedTransform() { }

	[CalledBy(Type = typeof(Bone), Member = "Update", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Bone), Member = "UpdateWorldTransform", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(IkConstraint), Member = "Apply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Bone), typeof(float), typeof(float), typeof(bool), typeof(bool), typeof(bool), typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(IkConstraint), Member = "Apply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Bone), typeof(Bone), typeof(float), typeof(float), typeof(int), typeof(bool), typeof(bool), typeof(float), typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TransformConstraint), Member = "ApplyAbsoluteLocal", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TransformConstraint), Member = "ApplyRelativeLocal", ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(MathUtils), Member = "CosDeg", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(MathUtils), Member = "SinDeg", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(MathUtils), Member = "Atan2", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(Skeleton), Member = "get_ScaleY", ReturnType = typeof(float))]
	[Calls(Type = typeof(MathUtils), Member = "Cos", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(MathUtils), Member = "Sin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(float))]
	[CallsUnknownMethods(Count = 15)]
	[ContainsUnimplementedInstructions]
	public void UpdateWorldTransform(float x, float y, float rotation, float scaleX, float scaleY, float shearX, float shearY) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Bone), Member = "UpdateWorldTransform", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float)}, ReturnType = typeof(void))]
	public void UpdateWorldTransform() { }

	[CalledBy(Type = "Spine.Unity.SkeletonExtensions", Member = "WorldToLocal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Bone), "UnityEngine.Vector2"}, ReturnType = "UnityEngine.Vector2")]
	[CalledBy(Type = "Spine.Unity.SkeletonExtensions", Member = "SetPositionSkeletonSpace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Bone), "UnityEngine.Vector2"}, ReturnType = "UnityEngine.Vector2")]
	[CallerCount(Count = 2)]
	public void WorldToLocal(float worldX, float worldY, out float localX, out float localY) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	public float WorldToLocalRotation(float worldRotation) { }

}

