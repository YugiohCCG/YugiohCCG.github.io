namespace Spine;

public struct BoneMatrix
{
	public float a; //Field offset: 0x0
	public float b; //Field offset: 0x4
	public float c; //Field offset: 0x8
	public float d; //Field offset: 0xC
	public float x; //Field offset: 0x10
	public float y; //Field offset: 0x14

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MathUtils), Member = "CosDeg", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(MathUtils), Member = "SinDeg", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(float))]
	[CallsUnknownMethods(Count = 1)]
	public BoneMatrix(BoneData boneData) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MathUtils), Member = "CosDeg", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(MathUtils), Member = "SinDeg", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(float))]
	[CallsUnknownMethods(Count = 1)]
	public BoneMatrix(Bone bone) { }

	[CalledBy(Type = typeof(BoneMatrix), Member = "CalculateSetupWorld", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BoneData)}, ReturnType = typeof(BoneMatrix))]
	[CalledBy(Type = typeof(MeshGenerator), Member = "FillMeshLocal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mesh), typeof(MeshAttachment), typeof(SkeletonData)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(BoneMatrix), Member = "CalculateSetupWorld", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BoneData)}, ReturnType = typeof(BoneMatrix))]
	[Calls(Type = typeof(BoneMatrix), Member = "GetInheritedInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BoneData), typeof(BoneMatrix)}, ReturnType = typeof(BoneMatrix))]
	public static BoneMatrix CalculateSetupWorld(BoneData boneData) { }

	[CalledBy(Type = typeof(BoneMatrix), Member = "CalculateSetupWorld", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BoneData)}, ReturnType = typeof(BoneMatrix))]
	[CallerCount(Count = 1)]
	[ContainsInvalidInstructions]
	private static BoneMatrix GetInheritedInternal(BoneData boneData, BoneMatrix parentMatrix) { }

	[CallerCount(Count = 0)]
	public BoneMatrix TransformMatrix(BoneMatrix local) { }

}

