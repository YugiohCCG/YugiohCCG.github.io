namespace Spine.Unity;

[AddComponentMenu("Spine/Point Follower")]
[ExecuteAlways]
[HelpURL("http://esotericsoftware.com/spine-unity#PointFollower")]
public class PointFollower : MonoBehaviour, IHasSkeletonRenderer, ISpineComponent, IHasSkeletonComponent
{
	public SkeletonRenderer skeletonRenderer; //Field offset: 0x20
	[SpineSlot(null, "skeletonRenderer", False, True, False)]
	public string slotName; //Field offset: 0x28
	[SpineAttachment(True, False, False, "slotName", "skeletonRenderer", null, True, True)]
	public string pointAttachmentName; //Field offset: 0x30
	public bool followRotation; //Field offset: 0x38
	public bool followSkeletonFlip; //Field offset: 0x39
	public bool followSkeletonZPosition; //Field offset: 0x3A
	private Transform skeletonTransform; //Field offset: 0x40
	private bool skeletonTransformIsParent; //Field offset: 0x48
	private PointAttachment point; //Field offset: 0x50
	private Bone bone; //Field offset: 0x58
	private bool valid; //Field offset: 0x60

	public bool IsValid
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public override ISkeletonComponent SkeletonComponent
	{
		[CallerCount(Count = 12)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public override SkeletonRenderer SkeletonRenderer
	{
		[CallerCount(Count = 12)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public PointFollower() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public bool get_IsValid() { }

	[CallerCount(Count = 12)]
	[DeduplicatedMethod]
	public override ISkeletonComponent get_SkeletonComponent() { }

	[CallerCount(Count = 12)]
	[DeduplicatedMethod]
	public override SkeletonRenderer get_SkeletonRenderer() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(PointFollower), Member = "UpdateReferences", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	private void HandleRebuildRenderer(SkeletonRenderer skeletonRenderer) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(PointFollower), Member = "UpdateReferences", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public void Initialize() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Transform), Member = "set_localScale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Skeleton), Member = "get_ScaleY", ReturnType = typeof(float))]
	[Calls(Type = typeof(Transform), Member = "get_localScale", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Transform), Member = "set_localRotation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Transform), Member = "set_localPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Transform), Member = "get_localPosition", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Transform), Member = "SetPositionAndRotation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Quaternion)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Quaternion), Member = "Internal_FromEulerRad", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Quaternion))]
	[Calls(Type = typeof(Quaternion), Member = "Internal_MakePositive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Quaternion), Member = "Internal_ToEulerRad", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Transform), Member = "get_rotation", ReturnType = typeof(Quaternion))]
	[Calls(Type = typeof(Transform), Member = "set_position", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Transform), Member = "get_localToWorldMatrix", ReturnType = typeof(Matrix4x4))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Transform), Member = "get_position", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Transform), Member = "TransformPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(PointAttachment), Member = "ComputeWorldRotation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Bone)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(PointAttachment), Member = "ComputeWorldPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Bone), typeof(Single&), typeof(Single&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(PointFollower), Member = "UpdateReferences", ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public void LateUpdate() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(SkeletonRenderer), Member = "remove_OnRebuild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SkeletonRendererDelegate)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void OnDestroy() { }

	[CalledBy(Type = typeof(PointFollower), Member = "Initialize", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PointFollower), Member = "HandleRebuildRenderer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SkeletonRenderer)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PointFollower), Member = "LateUpdate", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(SkeletonRenderer), Member = "remove_OnRebuild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SkeletonRendererDelegate)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SkeletonRenderer), Member = "add_OnRebuild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SkeletonRendererDelegate)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(SkeletonRenderer), Member = "get_Skeleton", ReturnType = typeof(Skeleton))]
	[Calls(Type = typeof(Skeleton), Member = "FindSlot", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Slot))]
	[Calls(Type = typeof(Skeleton), Member = "GetAttachment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string)}, ReturnType = typeof(Attachment))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 6)]
	[ContainsUnimplementedInstructions]
	private void UpdateReferences() { }

}

