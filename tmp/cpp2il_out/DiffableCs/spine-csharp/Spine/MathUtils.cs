namespace Spine;

public static class MathUtils
{
	public const float PI = 3.1415927; //Field offset: 0x0
	public const float PI2 = 6.2831855; //Field offset: 0x0
	public const float RadDeg = 57.295776; //Field offset: 0x0
	public const float DegRad = 0.017453292; //Field offset: 0x0
	private static Random random; //Field offset: 0x0

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Random), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private static MathUtils() { }

	[CalledBy(Type = typeof(Bone), Member = "UpdateWorldTransform", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Bone), Member = "UpdateAppliedTransform", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Bone), Member = "get_WorldToLocalRotationX", ReturnType = typeof(float))]
	[CalledBy(Type = typeof(Bone), Member = "get_WorldToLocalRotationY", ReturnType = typeof(float))]
	[CalledBy(Type = typeof(PathConstraint), Member = "Update", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TransformConstraint), Member = "ApplyAbsoluteWorld", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TransformConstraint), Member = "ApplyRelativeWorld", ReturnType = typeof(void))]
	[CallerCount(Count = 22)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public static float Atan2(float y, float x) { }

	[CallerCount(Count = 7)]
	[DeduplicatedMethod]
	public static float Clamp(float value, float min, float max) { }

	[CalledBy(Type = typeof(Bone), Member = "UpdateWorldTransform", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PathConstraint), Member = "Update", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TransformConstraint), Member = "ApplyAbsoluteWorld", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TransformConstraint), Member = "ApplyRelativeWorld", ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public static float Cos(float radians) { }

	[CalledBy(Type = typeof(Bone), Member = "UpdateWorldTransform", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Spine.BoneMatrix", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BoneData)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Spine.BoneMatrix", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Bone)}, ReturnType = typeof(void))]
	[CallerCount(Count = 11)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public static float CosDeg(float degrees) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	public static float RandomTriangle(float min, float max) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	public static float RandomTriangle(float min, float max, float mode) { }

	[CalledBy(Type = typeof(Bone), Member = "UpdateWorldTransform", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PathConstraint), Member = "Update", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TransformConstraint), Member = "ApplyAbsoluteWorld", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TransformConstraint), Member = "ApplyRelativeWorld", ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public static float Sin(float radians) { }

	[CalledBy(Type = typeof(Bone), Member = "UpdateWorldTransform", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Spine.BoneMatrix", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BoneData)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Spine.BoneMatrix", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Bone)}, ReturnType = typeof(void))]
	[CallerCount(Count = 8)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public static float SinDeg(float degrees) { }

}

