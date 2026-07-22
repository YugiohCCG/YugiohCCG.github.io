namespace Spine;

[Extension]
public static class SpineSkeletonExtensions
{

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	[Extension]
	public static bool InheritsRotation(TransformMode mode) { }

	[CalledBy(Type = typeof(SkeletonUtilityBone), Member = "DoUpdate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UpdatePhase)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SkeletonUtilityBone), Member = "BoneTransformModeIncompatible", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Bone)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 3)]
	[Extension]
	public static bool InheritsScale(TransformMode mode) { }

	[CalledBy(Type = typeof(SkeletonUtility), Member = "AddBoundingBoxGameObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(BoundingBoxAttachment), typeof(Slot), typeof(Transform), typeof(bool)}, ReturnType = typeof(PolygonCollider2D))]
	[CalledBy(Type = typeof(SkeletonUtility), Member = "AddBoundingBoxAsComponent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BoundingBoxAttachment), typeof(Slot), typeof(GameObject), typeof(bool)}, ReturnType = typeof(PolygonCollider2D))]
	[CalledBy(Type = typeof(SkeletonUtility), Member = "SetColliderPointsLocal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PolygonCollider2D), typeof(Slot), typeof(BoundingBoxAttachment), typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MeshGenerator), Member = "FillMeshLocal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mesh), typeof(MeshAttachment), typeof(SkeletonData)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Extension]
	public static bool IsWeighted(VertexAttachment va) { }

}

