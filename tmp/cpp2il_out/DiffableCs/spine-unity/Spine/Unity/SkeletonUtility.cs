namespace Spine.Unity;

[ExecuteAlways]
[HelpURL("http://esotericsoftware.com/spine-unity#SkeletonUtility")]
[RequireComponent(typeof(ISkeletonAnimation))]
public sealed class SkeletonUtility : MonoBehaviour
{
	internal sealed class SkeletonUtilityDelegate : MulticastDelegate
	{

		[CallerCount(Count = 536)]
		[CallsUnknownMethods(Count = 4)]
		[DeduplicatedMethod]
		public SkeletonUtilityDelegate(object object, IntPtr method) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		public override IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		public override void EndInvoke(IAsyncResult result) { }

		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public override void Invoke() { }

	}

	[CompilerGenerated]
	private SkeletonUtilityDelegate OnReset; //Field offset: 0x20
	public Transform boneRoot; //Field offset: 0x28
	public bool flipBy180DegreeRotation; //Field offset: 0x30
	[HideInInspector]
	public SkeletonRenderer skeletonRenderer; //Field offset: 0x38
	[HideInInspector]
	public SkeletonGraphic skeletonGraphic; //Field offset: 0x40
	private Canvas canvas; //Field offset: 0x48
	public ISkeletonAnimation skeletonAnimation; //Field offset: 0x50
	private ISkeletonComponent skeletonComponent; //Field offset: 0x58
	public List<SkeletonUtilityBone> boneComponents; //Field offset: 0x60
	public List<SkeletonUtilityConstraint> constraintComponents; //Field offset: 0x68
	private float positionScale; //Field offset: 0x70
	private bool hasOverrideBones; //Field offset: 0x74
	private bool hasConstraints; //Field offset: 0x75
	private bool needToReprocessBones; //Field offset: 0x76

	public event SkeletonUtilityDelegate OnReset
	{
		[CalledBy(Type = typeof(SkeletonUtilityBone), Member = "Reset", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(SkeletonUtilityBone), Member = "OnEnable", ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[CallsUnknownMethods(Count = 2)]
		[CompilerGenerated]
		 add { } //Length: 146
		[CalledBy(Type = typeof(SkeletonUtilityBone), Member = "Reset", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(SkeletonUtilityBone), Member = "OnDisable", ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[CallsUnknownMethods(Count = 2)]
		[CompilerGenerated]
		 remove { } //Length: 146
	}

	public bool IsValid
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(SkeletonGraphic), Member = "get_IsValid", ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 198
	}

	public float PositionScale
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 6
	}

	public Skeleton Skeleton
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
		[CallsUnknownMethods(Count = 3)]
		 get { } //Length: 290
	}

	public ISkeletonComponent SkeletonComponent
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
		[CallsUnknownMethods(Count = 2)]
		 get { } //Length: 222
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	public SkeletonUtility() { }

	[CalledBy(Type = typeof(SkeletonUtilityBone), Member = "Reset", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SkeletonUtilityBone), Member = "OnEnable", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[CallsUnknownMethods(Count = 2)]
	[CompilerGenerated]
	public void add_OnReset(SkeletonUtilityDelegate value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameObject), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(GameObject), Member = "AddComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(Rigidbody2D), Member = "set_isKinematic", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Rigidbody2D), Member = "set_gravityScale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public static Rigidbody2D AddBoneRigidbody2D(GameObject gameObject, bool isKinematic = true, float gravityScale = 0) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameObject), Member = "AddComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(Collider2D), Member = "set_isTrigger", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SpineSkeletonExtensions), Member = "IsWeighted", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexAttachment)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Debug), Member = "LogWarning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SkeletonExtensions), Member = "GetLocalVertices", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexAttachment), typeof(Slot), typeof(Vector2[])}, ReturnType = typeof(Vector2[]))]
	[Calls(Type = typeof(PolygonCollider2D), Member = "SetPath", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Vector2[])}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public static PolygonCollider2D AddBoundingBoxAsComponent(BoundingBoxAttachment box, Slot slot, GameObject gameObject, bool isTrigger = true) { }

	[CalledBy(Type = typeof(SkeletonUtilityBone), Member = "AddBoundingBox", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(SkeletonData), Member = "FindSkin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Skin))]
	[Calls(Type = typeof(Skeleton), Member = "FindSlot", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Slot))]
	[Calls(Type = typeof(Skin), Member = "GetAttachment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string)}, ReturnType = typeof(Attachment))]
	[Calls(Type = typeof(SkeletonUtility), Member = "AddBoundingBoxGameObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(BoundingBoxAttachment), typeof(Slot), typeof(Transform), typeof(bool)}, ReturnType = typeof(PolygonCollider2D))]
	[Calls(Type = typeof(Debug), Member = "LogFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 18)]
	public static PolygonCollider2D AddBoundingBoxGameObject(Skeleton skeleton, string skinName, string slotName, string attachmentName, Transform parent, bool isTrigger = true) { }

	[CalledBy(Type = typeof(SkeletonUtility), Member = "AddBoundingBoxGameObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Skeleton), typeof(string), typeof(string), typeof(string), typeof(Transform), typeof(bool)}, ReturnType = typeof(PolygonCollider2D))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SkeletonExtensions), Member = "GetLocalVertices", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexAttachment), typeof(Slot), typeof(Vector2[])}, ReturnType = typeof(Vector2[]))]
	[Calls(Type = typeof(Debug), Member = "LogWarning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SpineSkeletonExtensions), Member = "IsWeighted", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexAttachment)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Collider2D), Member = "set_isTrigger", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GameObject), Member = "AddComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(Transform), Member = "set_localScale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Transform), Member = "set_localRotation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Transform), Member = "set_localPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Transform), Member = "set_parent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Transform)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GameObject), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(GameObject), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(PolygonCollider2D), Member = "SetPath", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Vector2[])}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public static PolygonCollider2D AddBoundingBoxGameObject(string name, BoundingBoxAttachment box, Slot slot, Transform parent, bool isTrigger = true) { }

	[CalledBy(Type = typeof(SkeletonUtility), Member = "SpawnHierarchy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mode), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(GameObject))]
	[CalledBy(Type = typeof(SkeletonUtility), Member = "OnEnable", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SkeletonUtility), Member = "Start", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SkeletonUtility), Member = "HandleRendererReset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SkeletonRenderer)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SkeletonUtility), Member = "HandleRendererReset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SkeletonGraphic)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SkeletonUtility), Member = "UpdateLocal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ISkeletonAnimation)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SkeletonUtility), Member = "UpdateAllBones", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UpdatePhase)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SkeletonUtility), Member = "SpawnRoot", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mode), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(GameObject))]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SkeletonUtilityBone), Member = "DoUpdate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UpdatePhase)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 29)]
	[ContainsUnimplementedInstructions]
	public void CollectBones() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(SkeletonGraphic), Member = "get_IsValid", ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	public bool get_IsValid() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public float get_PositionScale() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[CallsUnknownMethods(Count = 3)]
	public Skeleton get_Skeleton() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[CallsUnknownMethods(Count = 2)]
	public ISkeletonComponent get_SkeletonComponent() { }

	[CalledBy(Type = typeof(SkeletonUtility), Member = "SpawnRoot", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mode), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(GameObject))]
	[CalledBy(Type = typeof(SkeletonUtility), Member = "SpawnHierarchy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mode), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(GameObject))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(GameObject), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GameObject), Member = "AddComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(GameObject), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Transform), Member = "set_localPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Transform), Member = "set_localRotation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Transform), Member = "set_localScale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public Transform GetBoneRoot() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public static Bounds GetBoundingBoxBounds(BoundingBoxAttachment boundingBox, float depth = 0) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SkeletonUtility), Member = "CollectBones", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	private void HandleRendererReset(SkeletonGraphic g) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SkeletonUtility), Member = "CollectBones", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	private void HandleRendererReset(SkeletonRenderer r) { }

	[CalledBy(Type = typeof(SkeletonUtility), Member = "ResubscribeEvents", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(SkeletonRenderer), Member = "remove_OnRebuild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SkeletonRendererDelegate)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SkeletonGraphic), Member = "remove_OnRebuild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SkeletonRendererDelegate)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 4)]
	private void OnDisable() { }

	[CalledBy(Type = typeof(SkeletonUtility), Member = "ResubscribeEvents", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(SkeletonGraphic), Member = "remove_OnRebuild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SkeletonRendererDelegate)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SkeletonGraphic), Member = "add_OnRebuild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SkeletonRendererDelegate)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Graphic), Member = "get_canvas", ReturnType = typeof(Canvas))]
	[Calls(Type = typeof(Component), Member = "GetComponentInParent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(SkeletonRenderer), Member = "remove_OnRebuild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SkeletonRendererDelegate)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(SkeletonUtility), Member = "CollectBones", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 11)]
	private void OnEnable() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public void RegisterBone(SkeletonUtilityBone bone) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public void RegisterConstraint(SkeletonUtilityConstraint constraint) { }

	[CalledBy(Type = typeof(SkeletonUtilityBone), Member = "Reset", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SkeletonUtilityBone), Member = "OnDisable", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[CallsUnknownMethods(Count = 2)]
	[CompilerGenerated]
	public void remove_OnReset(SkeletonUtilityDelegate value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SkeletonUtility), Member = "OnDisable", ReturnType = typeof(void))]
	[Calls(Type = typeof(SkeletonUtility), Member = "OnEnable", ReturnType = typeof(void))]
	public void ResubscribeEvents() { }

	[CalledBy(Type = typeof(BoundingBoxFollower), Member = "AddCollidersForSkin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Skin), typeof(int), typeof(PolygonCollider2D[]), typeof(Int32&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BoundingBoxFollowerGraphic), Member = "AddCollidersForSkin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Skin), typeof(int), typeof(PolygonCollider2D[]), typeof(float), typeof(Int32&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(SpineSkeletonExtensions), Member = "IsWeighted", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexAttachment)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Debug), Member = "LogWarning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SkeletonExtensions), Member = "GetLocalVertices", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexAttachment), typeof(Slot), typeof(Vector2[])}, ReturnType = typeof(Vector2[]))]
	[Calls(Type = typeof(PolygonCollider2D), Member = "SetPath", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Vector2[])}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	public static void SetColliderPointsLocal(PolygonCollider2D collider, Slot slot, BoundingBoxAttachment box, float scale = 1) { }

	[CalledBy(Type = typeof(SkeletonUtility), Member = "SpawnRoot", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mode), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(GameObject))]
	[CalledBy(Type = typeof(SkeletonUtility), Member = "SpawnBoneRecursively", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Bone), typeof(Transform), typeof(Mode), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(GameObject))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GameObject), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(GameObject), Member = "AddComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(GameObject), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(SkeletonUtilityBone), Member = "Reset", ReturnType = typeof(void))]
	[Calls(Type = typeof(Quaternion), Member = "Internal_FromEulerRad", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Quaternion))]
	[Calls(Type = typeof(Transform), Member = "set_localRotation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Transform), Member = "set_localPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Transform), Member = "set_localScale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public GameObject SpawnBone(Bone bone, Transform parent, Mode mode, bool pos, bool rot, bool sca) { }

	[CalledBy(Type = typeof(SkeletonUtility), Member = "SpawnHierarchy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mode), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(GameObject))]
	[CalledBy(Type = typeof(SkeletonUtility), Member = "SpawnBoneRecursively", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Bone), typeof(Transform), typeof(Mode), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(GameObject))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(SkeletonUtility), Member = "SpawnBone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Bone), typeof(Transform), typeof(Mode), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(GameObject), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(SkeletonUtility), Member = "SpawnBoneRecursively", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Bone), typeof(Transform), typeof(Mode), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(GameObject))]
	[CallsUnknownMethods(Count = 2)]
	public GameObject SpawnBoneRecursively(Bone bone, Transform parent, Mode mode, bool pos, bool rot, bool sca) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SkeletonUtility), Member = "GetBoneRoot", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Skeleton), Member = "get_RootBone", ReturnType = typeof(Bone))]
	[Calls(Type = typeof(SkeletonUtility), Member = "SpawnBoneRecursively", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Bone), typeof(Transform), typeof(Mode), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(SkeletonUtility), Member = "CollectBones", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	public GameObject SpawnHierarchy(Mode mode, bool pos, bool rot, bool sca) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SkeletonUtility), Member = "GetBoneRoot", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Skeleton), Member = "get_RootBone", ReturnType = typeof(Bone))]
	[Calls(Type = typeof(SkeletonUtility), Member = "SpawnBone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Bone), typeof(Transform), typeof(Mode), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(SkeletonUtility), Member = "CollectBones", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	public GameObject SpawnRoot(Mode mode, bool pos, bool rot, bool sca) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SkeletonUtility), Member = "CollectBones", ReturnType = typeof(void))]
	private void Start() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	public void UnregisterBone(SkeletonUtilityBone bone) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	public void UnregisterConstraint(SkeletonUtilityConstraint constraint) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Skeleton), Member = "get_ScaleY", ReturnType = typeof(float))]
	[Calls(Type = typeof(Transform), Member = "set_localScale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Transform), Member = "set_eulerAngles", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Canvas), Member = "get_referencePixelsPerUnit", ReturnType = typeof(float))]
	[CallsUnknownMethods(Count = 2)]
	private void Update() { }

	[CalledBy(Type = typeof(SkeletonUtility), Member = "UpdateWorld", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ISkeletonAnimation)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SkeletonUtility), Member = "UpdateComplete", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ISkeletonAnimation)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(SkeletonUtility), Member = "CollectBones", ReturnType = typeof(void))]
	[Calls(Type = typeof(SkeletonUtilityBone), Member = "DoUpdate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UpdatePhase)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void UpdateAllBones(UpdatePhase phase) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SkeletonUtility), Member = "UpdateAllBones", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UpdatePhase)}, ReturnType = typeof(void))]
	private void UpdateComplete(ISkeletonAnimation anim) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SkeletonUtility), Member = "CollectBones", ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(SkeletonUtilityBone), Member = "DoUpdate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UpdatePhase)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	private void UpdateLocal(ISkeletonAnimation anim) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SkeletonUtility), Member = "UpdateAllBones", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UpdatePhase)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	private void UpdateWorld(ISkeletonAnimation anim) { }

}

