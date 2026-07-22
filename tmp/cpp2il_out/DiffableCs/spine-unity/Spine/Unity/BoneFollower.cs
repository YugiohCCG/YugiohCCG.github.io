namespace Spine.Unity;

[AddComponentMenu("Spine/BoneFollower")]
[ExecuteAlways]
[HelpURL("http://esotericsoftware.com/spine-unity#BoneFollower")]
public class BoneFollower : MonoBehaviour
{
	internal enum AxisOrientation
	{
		XAxis = 1,
		YAxis = 2,
	}

	public SkeletonRenderer skeletonRenderer; //Field offset: 0x20
	[SpineBone(null, "skeletonRenderer", True, False)]
	public string boneName; //Field offset: 0x28
	public bool followXYPosition; //Field offset: 0x30
	public bool followZPosition; //Field offset: 0x31
	public bool followBoneRotation; //Field offset: 0x32
	[Tooltip("Follows the skeleton's flip state by controlling this Transform's local scale.")]
	public bool followSkeletonFlip; //Field offset: 0x33
	[FormerlySerializedAs("followScale")]
	[Tooltip("Follows the target bone's local scale.")]
	public bool followLocalScale; //Field offset: 0x34
	[Tooltip("Includes the parent bone's lossy world scale. BoneFollower cannot inherit rotated/skewed scale because of UnityEngine.Transform property limitations.")]
	public bool followParentWorldScale; //Field offset: 0x35
	[Tooltip("Applies when 'Follow Skeleton Flip' is disabled but 'Follow Bone Rotation' is enabled. When flipping the skeleton by scaling its Transform, this follower's rotation is adjusted instead of its scale to follow the bone orientation. When one of the axes is flipped,  only one axis can be followed, either the X or the Y axis, which is selected here.")]
	public AxisOrientation maintainedAxisOrientation; //Field offset: 0x38
	[FormerlySerializedAs("resetOnAwake")]
	public bool initializeOnAwake; //Field offset: 0x3C
	public bool valid; //Field offset: 0x3D
	public Bone bone; //Field offset: 0x40
	private Transform skeletonTransform; //Field offset: 0x48
	private bool skeletonTransformIsParent; //Field offset: 0x50

	public SkeletonRenderer SkeletonRenderer
	{
		[CallerCount(Count = 12)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(BoneFollower), Member = "Initialize", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		 set { } //Length: 37
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public BoneFollower() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BoneFollower), Member = "Initialize", ReturnType = typeof(void))]
	public void Awake() { }

	[CallerCount(Count = 12)]
	[DeduplicatedMethod]
	public SkeletonRenderer get_SkeletonRenderer() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BoneFollower), Member = "Initialize", ReturnType = typeof(void))]
	public void HandleRebuildRenderer(SkeletonRenderer skeletonRenderer) { }

	[CalledBy(Type = typeof(BoneFollower), Member = "set_SkeletonRenderer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SkeletonRenderer)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BoneFollower), Member = "Awake", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BoneFollower), Member = "HandleRebuildRenderer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SkeletonRenderer)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BoneFollower), Member = "LateUpdate", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(SkeletonRenderer), Member = "remove_OnRebuild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SkeletonRendererDelegate)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SkeletonRenderer), Member = "add_OnRebuild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SkeletonRendererDelegate)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Skeleton), Member = "FindBone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Bone))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	[ContainsUnimplementedInstructions]
	public void Initialize() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BoneFollower), Member = "Initialize", ReturnType = typeof(void))]
	[Calls(Type = typeof(Transform), Member = "set_localScale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Skeleton), Member = "get_ScaleY", ReturnType = typeof(float))]
	[Calls(Type = typeof(Bone), Member = "get_WorldScaleY", ReturnType = typeof(float))]
	[Calls(Type = typeof(Bone), Member = "get_WorldScaleX", ReturnType = typeof(float))]
	[Calls(Type = typeof(Transform), Member = "set_localRotation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Transform), Member = "set_localPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Transform), Member = "get_localPosition", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Transform), Member = "SetPositionAndRotation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Quaternion)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Quaternion), Member = "Internal_FromEulerRad", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Quaternion))]
	[Calls(Type = typeof(Quaternion), Member = "Internal_MakePositive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Quaternion), Member = "Internal_ToEulerRad", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Bone), Member = "get_WorldRotationX", ReturnType = typeof(float))]
	[Calls(Type = typeof(Transform), Member = "set_position", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Transform), Member = "get_lossyScale", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Transform), Member = "get_position", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Transform), Member = "TransformPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Skeleton), Member = "FindBone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Bone))]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Transform), Member = "get_rotation", ReturnType = typeof(Quaternion))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	public void LateUpdate() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(SkeletonRenderer), Member = "remove_OnRebuild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SkeletonRendererDelegate)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void OnDestroy() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BoneFollower), Member = "Initialize", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void set_SkeletonRenderer(SkeletonRenderer value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Skeleton), Member = "FindBone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Bone))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public bool SetBone(string name) { }

}

