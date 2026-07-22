namespace Spine.Unity;

[Extension]
public static class SkeletonExtensions
{
	private const float ByteToFloat = 0.003921569; //Field offset: 0x0

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[Extension]
	public static Color GetColor(Skeleton s) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[Extension]
	public static Color GetColor(RegionAttachment a) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[Extension]
	public static Color GetColor(MeshAttachment a) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[Extension]
	public static Color GetColor(Slot s) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[Extension]
	public static Color GetColorTintBlack(Slot s) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[Extension]
	public static Vector2 GetLocalPosition(Bone bone) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 3)]
	[Extension]
	public static Quaternion GetLocalQuaternion(Bone bone) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Skeleton), Member = "get_ScaleY", ReturnType = typeof(float))]
	[CallsUnknownMethods(Count = 1)]
	[Extension]
	public static Vector2 GetLocalScale(Skeleton skeleton) { }

	[CalledBy(Type = typeof(SkeletonUtility), Member = "AddBoundingBoxGameObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(BoundingBoxAttachment), typeof(Slot), typeof(Transform), typeof(bool)}, ReturnType = typeof(PolygonCollider2D))]
	[CalledBy(Type = typeof(SkeletonUtility), Member = "AddBoundingBoxAsComponent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BoundingBoxAttachment), typeof(Slot), typeof(GameObject), typeof(bool)}, ReturnType = typeof(PolygonCollider2D))]
	[CalledBy(Type = typeof(SkeletonUtility), Member = "SetColliderPointsLocal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PolygonCollider2D), typeof(Slot), typeof(BoundingBoxAttachment), typeof(float)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(VertexAttachment), Member = "ComputeWorldVertices", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Slot), typeof(Single[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 8)]
	[Extension]
	public static Vector2[] GetLocalVertices(VertexAttachment va, Slot slot, Vector2[] buffer) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 5)]
	[Extension]
	public static Material GetMaterial(Attachment a) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[Extension]
	public static Matrix4x4 GetMatrix4x4(Bone bone) { }

	[CalledBy(Type = typeof(BoneFollowerGraphic), Member = "LateUpdate", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	[Extension]
	public static Quaternion GetQuaternion(Bone bone) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Bone), Member = "LocalToWorld", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(Single&), typeof(Single&)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[Extension]
	public static Vector2 GetSkeletonSpacePosition(Bone bone, Vector2 boneLocal) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[Extension]
	public static Vector2 GetSkeletonSpacePosition(Bone bone) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Transform), Member = "TransformPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[CallsUnknownMethods(Count = 1)]
	[Extension]
	public static Vector3 GetWorldPosition(Bone bone, Transform spineGameObjectTransform, float positionScale) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Transform), Member = "TransformPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[CallsUnknownMethods(Count = 1)]
	[Extension]
	public static Vector3 GetWorldPosition(Bone bone, Transform spineGameObjectTransform) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PointAttachment), Member = "ComputeWorldPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Bone), typeof(Single&), typeof(Single&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Transform), Member = "TransformPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[CallsUnknownMethods(Count = 1)]
	[Extension]
	public static Vector3 GetWorldPosition(PointAttachment attachment, Bone bone, Transform spineGameObjectTransform) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PointAttachment), Member = "ComputeWorldPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Bone), typeof(Single&), typeof(Single&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Transform), Member = "TransformPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[CallsUnknownMethods(Count = 1)]
	[Extension]
	public static Vector3 GetWorldPosition(PointAttachment attachment, Slot slot, Transform spineGameObjectTransform) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[Extension]
	public static void GetWorldToLocalMatrix(Bone bone, out float ia, out float ib, out float ic, out float id) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VertexAttachment), Member = "ComputeWorldVertices", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Slot), typeof(Single[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 8)]
	[Extension]
	public static Vector2[] GetWorldVertices(VertexAttachment a, Slot slot, Vector2[] buffer) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[Extension]
	public static void SetColor(MeshAttachment attachment, Color32 color) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[Extension]
	public static void SetColor(MeshAttachment attachment, Color color) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[Extension]
	public static void SetColor(RegionAttachment attachment, Color32 color) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[Extension]
	public static void SetColor(RegionAttachment attachment, Color color) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[Extension]
	public static void SetColor(Slot slot, Color32 color) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[Extension]
	public static void SetColor(Slot slot, Color color) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[Extension]
	public static void SetColor(Skeleton skeleton, Color32 color) { }

	[CalledBy(Type = typeof(SkeletonGraphic), Member = "UpdateMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Extension]
	public static void SetColor(Skeleton skeleton, Color color) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[Extension]
	public static void SetLocalPosition(Bone bone, Vector2 position) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[Extension]
	public static void SetLocalPosition(Bone bone, Vector3 position) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[Extension]
	public static void SetLocalScale(Skeleton skeleton, Vector2 scale) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Bone), Member = "WorldToLocal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(Single&), typeof(Single&)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[Extension]
	public static Vector2 SetPositionSkeletonSpace(Bone bone, Vector2 skeletonSpacePosition) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Bone), Member = "WorldToLocal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(Single&), typeof(Single&)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[Extension]
	public static Vector2 WorldToLocal(Bone bone, Vector2 worldPosition) { }

}

