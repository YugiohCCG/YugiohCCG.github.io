namespace Spine.Unity;

[AddComponentMenu("Spine/SkeletonUtilityBone")]
[ExecuteAlways]
[HelpURL("http://esotericsoftware.com/spine-unity#SkeletonUtilityBone")]
public class SkeletonUtilityBone : MonoBehaviour
{
	internal enum Mode
	{
		Follow = 0,
		Override = 1,
	}

	internal enum UpdatePhase
	{
		Local = 0,
		World = 1,
		Complete = 2,
	}

	public string boneName; //Field offset: 0x20
	public Transform parentReference; //Field offset: 0x28
	public Mode mode; //Field offset: 0x30
	public bool position; //Field offset: 0x34
	public bool rotation; //Field offset: 0x35
	public bool scale; //Field offset: 0x36
	public bool zPosition; //Field offset: 0x37
	[Range(0, 1)]
	public float overrideAlpha; //Field offset: 0x38
	public SkeletonUtility hierarchy; //Field offset: 0x40
	public Bone bone; //Field offset: 0x48
	public bool transformLerpComplete; //Field offset: 0x50
	public bool valid; //Field offset: 0x51
	private Transform cachedTransform; //Field offset: 0x58
	private Transform skeletonTransform; //Field offset: 0x60
	private bool incompatibleTransformMode; //Field offset: 0x68

	public bool IncompatibleTransformMode
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public SkeletonUtilityBone() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(GameObject), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(GameObject), Member = "AddComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(Rigidbody2D), Member = "set_isKinematic", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Rigidbody2D), Member = "set_gravityScale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SkeletonUtility), Member = "AddBoundingBoxGameObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Skeleton), typeof(string), typeof(string), typeof(string), typeof(Transform), typeof(bool)}, ReturnType = typeof(PolygonCollider2D))]
	[CallsUnknownMethods(Count = 1)]
	public void AddBoundingBox(string skinName, string slotName, string attachmentName) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SpineSkeletonExtensions), Member = "InheritsScale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TransformMode)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	public static bool BoneTransformModeIncompatible(Bone bone) { }

	[CalledBy(Type = typeof(SkeletonUtility), Member = "CollectBones", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SkeletonUtility), Member = "UpdateLocal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ISkeletonAnimation)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SkeletonUtility), Member = "UpdateAllBones", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UpdatePhase)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SkeletonUtilityBone), Member = "Reset", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Transform), Member = "get_localScale", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(SpineSkeletonExtensions), Member = "InheritsScale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TransformMode)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Transform), Member = "get_localPosition", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Transform), Member = "get_localRotation", ReturnType = typeof(Quaternion))]
	[Calls(Type = typeof(Transform), Member = "set_localPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Transform), Member = "get_rotation", ReturnType = typeof(Quaternion))]
	[Calls(Type = typeof(Quaternion), Member = "Internal_FromEulerRad", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Quaternion))]
	[Calls(Type = typeof(Mathf), Member = "LerpAngle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(float)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(Transform), Member = "set_rotation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Transform), Member = "set_localRotation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Transform), Member = "set_localScale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SkeletonUtilityBone), Member = "Reset", ReturnType = typeof(void))]
	[Calls(Type = typeof(Bone), Member = "get_WorldRotationX", ReturnType = typeof(float))]
	[Calls(Type = typeof(Quaternion), Member = "Internal_MakePositive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Quaternion), Member = "LookRotation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3)}, ReturnType = typeof(Quaternion))]
	[Calls(Type = typeof(Transform), Member = "InverseTransformDirection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Transform), Member = "get_up", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Transform), Member = "InverseTransformPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Transform), Member = "get_position", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Skeleton), Member = "get_ScaleY", ReturnType = typeof(float))]
	[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Skeleton), Member = "FindBone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Bone))]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Quaternion), Member = "Internal_ToEulerRad", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion)}, ReturnType = typeof(Vector3))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	public void DoUpdate(UpdatePhase phase) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public bool get_IncompatibleTransformMode() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SkeletonUtilityBone), Member = "Reset", ReturnType = typeof(void))]
	private void HandleOnReset() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(SkeletonUtility), Member = "remove_OnReset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SkeletonUtilityDelegate)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 3)]
	private void OnDisable() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Component), Member = "GetComponentInParent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SkeletonUtility), Member = "add_OnReset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SkeletonUtilityDelegate)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 6)]
	private void OnEnable() { }

	[CalledBy(Type = typeof(SkeletonUtility), Member = "SpawnBone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Bone), typeof(Transform), typeof(Mode), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(GameObject))]
	[CalledBy(Type = typeof(SkeletonUtilityBone), Member = "HandleOnReset", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SkeletonUtilityBone), Member = "DoUpdate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UpdatePhase)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(SkeletonGraphic), Member = "get_IsValid", ReturnType = typeof(bool))]
	[Calls(Type = typeof(SkeletonUtility), Member = "remove_OnReset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SkeletonUtilityDelegate)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SkeletonUtility), Member = "add_OnReset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SkeletonUtilityDelegate)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SkeletonUtilityBone), Member = "DoUpdate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UpdatePhase)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 8)]
	public void Reset() { }

}

