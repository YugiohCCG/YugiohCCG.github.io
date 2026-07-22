namespace Spine.Unity;

[ExecuteAlways]
[HelpURL("http://esotericsoftware.com/spine-unity#BoundingBoxFollowerGraphic")]
public class BoundingBoxFollowerGraphic : MonoBehaviour
{
	internal static bool DebugMessages; //Field offset: 0x0
	public SkeletonGraphic skeletonGraphic; //Field offset: 0x20
	[SpineSlot(null, "skeletonGraphic", True, True, False)]
	public string slotName; //Field offset: 0x28
	public bool isTrigger; //Field offset: 0x30
	public bool usedByEffector; //Field offset: 0x31
	public bool usedByComposite; //Field offset: 0x32
	public bool clearStateOnDisable; //Field offset: 0x33
	private Slot slot; //Field offset: 0x38
	private BoundingBoxAttachment currentAttachment; //Field offset: 0x40
	private string currentAttachmentName; //Field offset: 0x48
	private PolygonCollider2D currentCollider; //Field offset: 0x50
	public readonly Dictionary<BoundingBoxAttachment, PolygonCollider2D> colliderTable; //Field offset: 0x58
	public readonly Dictionary<BoundingBoxAttachment, String> nameTable; //Field offset: 0x60

	public BoundingBoxAttachment CurrentAttachment
	{
		[CallerCount(Count = 12)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public string CurrentAttachmentName
	{
		[CallerCount(Count = 10)]
		[DeduplicatedMethod]
		 get { } //Length: 254
	}

	public PolygonCollider2D CurrentCollider
	{
		[CallerCount(Count = 16)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public bool IsTrigger
	{
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public Slot Slot
	{
		[CallerCount(Count = 38)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	[CallerCount(Count = 0)]
	private static BoundingBoxFollowerGraphic() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public BoundingBoxFollowerGraphic() { }

	[CalledBy(Type = typeof(BoundingBoxFollowerGraphic), Member = "Initialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "set_hideFlags", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HideFlags)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Behaviour), Member = "set_enabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Collider2D), Member = "set_usedByComposite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Collider2D), Member = "set_usedByEffector", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Collider2D), Member = "set_isTrigger", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SkeletonUtility), Member = "SetColliderPointsLocal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PolygonCollider2D), typeof(Slot), typeof(BoundingBoxAttachment), typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GameObject), Member = "AddComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(Dictionary`2), Member = "ContainsKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Skin), Member = "GetAttachment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string)}, ReturnType = typeof(Attachment))]
	[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(Skin), Member = "GetAttachments", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(System.Collections.Generic.List`1<Spine.Skin+SkinEntry>)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 9)]
	private void AddCollidersForSkin(Skin skin, int slotIndex, PolygonCollider2D[] previousColliders, float scale, ref int collidersCount) { }

	[CalledBy(Type = typeof(BoundingBoxFollowerGraphic), Member = "OnDisable", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Behaviour), Member = "set_enabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 6)]
	public void ClearState() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = "GetComponents", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T[]")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "Destroy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	private void DisposeExcessCollidersAfter(int requiredCount) { }

	[CallerCount(Count = 12)]
	[DeduplicatedMethod]
	public BoundingBoxAttachment get_CurrentAttachment() { }

	[CallerCount(Count = 10)]
	[DeduplicatedMethod]
	public string get_CurrentAttachmentName() { }

	[CallerCount(Count = 16)]
	[DeduplicatedMethod]
	public PolygonCollider2D get_CurrentCollider() { }

	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	public bool get_IsTrigger() { }

	[CallerCount(Count = 38)]
	[DeduplicatedMethod]
	public Slot get_Slot() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BoundingBoxFollowerGraphic), Member = "Initialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	private void HandleRebuild(SkeletonGraphic sr) { }

	[CalledBy(Type = typeof(BoundingBoxFollowerGraphic), Member = "Start", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BoundingBoxFollowerGraphic), Member = "OnEnable", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BoundingBoxFollowerGraphic), Member = "HandleRebuild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SkeletonGraphic)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Debug), Member = "LogWarning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Object), Member = "get_name", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Object), Member = "Destroy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BoundingBoxFollowerGraphic), Member = "AddCollidersForSkin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Skin), typeof(int), typeof(PolygonCollider2D[]), typeof(float), typeof(Int32&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Spine.ExposedList`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(ExposedList`1), Member = "GetEnumerator", ReturnType = "Spine.ExposedList`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(Canvas), Member = "get_referencePixelsPerUnit", ReturnType = typeof(float))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Graphic), Member = "get_canvas", ReturnType = typeof(Canvas))]
	[Calls(Type = typeof(GameObject), Member = "get_activeInHierarchy", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(Component), Member = "GetComponents", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T[]")]
	[Calls(Type = typeof(Skeleton), Member = "FindSlot", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Slot))]
	[Calls(Type = typeof(Dictionary`2), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(Dictionary`2), Member = "get_Count", ReturnType = typeof(int))]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(SkeletonGraphic), Member = "Initialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Component), Member = "GetComponentInParent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 8)]
	public void Initialize(bool overwrite = false) { }

	[CallerCount(Count = 0)]
	[ContainsInvalidInstructions]
	private void LateUpdate() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Debug), Member = "LogWarning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Behaviour), Member = "set_enabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Debug), Member = "LogFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(object))]
	[CallsUnknownMethods(Count = 14)]
	private void MatchAttachment(Attachment attachment) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BoundingBoxFollowerGraphic), Member = "ClearState", ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(SkeletonGraphic), Member = "remove_OnRebuild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SkeletonRendererDelegate)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void OnDisable() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(SkeletonGraphic), Member = "remove_OnRebuild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SkeletonRendererDelegate)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(BoundingBoxFollowerGraphic), Member = "Initialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private void OnEnable() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BoundingBoxFollowerGraphic), Member = "Initialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	private void Start() { }

}

