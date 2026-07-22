namespace UnityEngine;

[NativeHeader("Modules/Physics2D/Public/Collider2D.h")]
[RequireComponent(typeof(Transform))]
[RequiredByNativeCode(Optional = True)]
public class Collider2D : Behaviour
{
	internal enum CompositeOperation
	{
		None = 0,
		Merge = 1,
		Intersect = 2,
		Difference = 3,
		Flip = 4,
	}


	public Bounds bounds
	{
		[CalledBy(Type = "Extensions.CopyableCardText", Member = "HoveringBox", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(string))]
		[CalledBy(Type = "Extensions.DeckTrunk", Member = "HoveringBox", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = "Enumerator.DeckType")]
		[CalledBy(Type = "Extensions.DeckTrunk", Member = "OnEndDrag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.EventSystems.PointerEventData"}, ReturnType = typeof(void))]
		[CallerCount(Count = 9)]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		 get { } //Length: 148
	}

	public CompositeOperation compositeOperation
	{
		[CallerCount(Count = 0)]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		 set { } //Length: 131
	}

	public bool isTrigger
	{
		[CalledBy(Type = "Spine.Unity.BoundingBoxFollower", Member = "AddCollidersForSkin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Spine.Skin", typeof(int), "UnityEngine.PolygonCollider2D[]", typeof(Int32&)}, ReturnType = typeof(void))]
		[CalledBy(Type = "Spine.Unity.BoundingBoxFollowerGraphic", Member = "AddCollidersForSkin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Spine.Skin", typeof(int), "UnityEngine.PolygonCollider2D[]", typeof(float), typeof(Int32&)}, ReturnType = typeof(void))]
		[CalledBy(Type = "Spine.Unity.SkeletonUtility", Member = "AddBoundingBoxGameObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "Spine.BoundingBoxAttachment", "Spine.Slot", typeof(Transform), typeof(bool)}, ReturnType = typeof(PolygonCollider2D))]
		[CalledBy(Type = "Spine.Unity.SkeletonUtility", Member = "AddBoundingBoxAsComponent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Spine.BoundingBoxAttachment", "Spine.Slot", typeof(GameObject), typeof(bool)}, ReturnType = typeof(PolygonCollider2D))]
		[CallerCount(Count = 4)]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		 set { } //Length: 134
	}

	public Vector2 offset
	{
		[CalledBy(Type = "Extensions.DeckTrunk", Member = "OnBeginDrag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.EventSystems.PointerEventData"}, ReturnType = typeof(void))]
		[CalledBy(Type = "Extensions.DeckTrunk", Member = "MakeDragStartBox", ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		 set { } //Length: 128
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[ExcludeFromDocs]
	[Obsolete("usedByComposite has been deprecated. Use Collider2D.compositeOperation instead", False)]
	public bool usedByComposite
	{
		[CalledBy(Type = "Spine.Unity.BoundingBoxFollower", Member = "AddCollidersForSkin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Spine.Skin", typeof(int), "UnityEngine.PolygonCollider2D[]", typeof(Int32&)}, ReturnType = typeof(void))]
		[CalledBy(Type = "Spine.Unity.BoundingBoxFollowerGraphic", Member = "AddCollidersForSkin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Spine.Skin", typeof(int), "UnityEngine.PolygonCollider2D[]", typeof(float), typeof(Int32&)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		 set { } //Length: 133
	}

	public bool usedByEffector
	{
		[CalledBy(Type = "Spine.Unity.BoundingBoxFollower", Member = "AddCollidersForSkin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Spine.Skin", typeof(int), "UnityEngine.PolygonCollider2D[]", typeof(Int32&)}, ReturnType = typeof(void))]
		[CalledBy(Type = "Spine.Unity.BoundingBoxFollowerGraphic", Member = "AddCollidersForSkin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Spine.Skin", typeof(int), "UnityEngine.PolygonCollider2D[]", typeof(float), typeof(Int32&)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		 set { } //Length: 134
	}

	[CallerCount(Count = 36)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public Collider2D() { }

	[CalledBy(Type = "Extensions.CopyableCardText", Member = "HoveringBox", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(string))]
	[CalledBy(Type = "Extensions.DeckTrunk", Member = "HoveringBox", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = "Enumerator.DeckType")]
	[CalledBy(Type = "Extensions.DeckTrunk", Member = "OnEndDrag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.EventSystems.PointerEventData"}, ReturnType = typeof(void))]
	[CallerCount(Count = 9)]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public Bounds get_bounds() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void get_bounds_Injected(IntPtr _unity_self, out Bounds ret) { }

	[CallerCount(Count = 0)]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public void set_compositeOperation(CompositeOperation value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void set_compositeOperation_Injected(IntPtr _unity_self, CompositeOperation value) { }

	[CalledBy(Type = "Spine.Unity.BoundingBoxFollower", Member = "AddCollidersForSkin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Spine.Skin", typeof(int), "UnityEngine.PolygonCollider2D[]", typeof(Int32&)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Spine.Unity.BoundingBoxFollowerGraphic", Member = "AddCollidersForSkin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Spine.Skin", typeof(int), "UnityEngine.PolygonCollider2D[]", typeof(float), typeof(Int32&)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Spine.Unity.SkeletonUtility", Member = "AddBoundingBoxGameObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "Spine.BoundingBoxAttachment", "Spine.Slot", typeof(Transform), typeof(bool)}, ReturnType = typeof(PolygonCollider2D))]
	[CalledBy(Type = "Spine.Unity.SkeletonUtility", Member = "AddBoundingBoxAsComponent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Spine.BoundingBoxAttachment", "Spine.Slot", typeof(GameObject), typeof(bool)}, ReturnType = typeof(PolygonCollider2D))]
	[CallerCount(Count = 4)]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public void set_isTrigger(bool value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void set_isTrigger_Injected(IntPtr _unity_self, bool value) { }

	[CalledBy(Type = "Extensions.DeckTrunk", Member = "OnBeginDrag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.EventSystems.PointerEventData"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Extensions.DeckTrunk", Member = "MakeDragStartBox", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public void set_offset(Vector2 value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void set_offset_Injected(IntPtr _unity_self, in Vector2 value) { }

	[CalledBy(Type = "Spine.Unity.BoundingBoxFollower", Member = "AddCollidersForSkin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Spine.Skin", typeof(int), "UnityEngine.PolygonCollider2D[]", typeof(Int32&)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Spine.Unity.BoundingBoxFollowerGraphic", Member = "AddCollidersForSkin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Spine.Skin", typeof(int), "UnityEngine.PolygonCollider2D[]", typeof(float), typeof(Int32&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public void set_usedByComposite(bool value) { }

	[CalledBy(Type = "Spine.Unity.BoundingBoxFollower", Member = "AddCollidersForSkin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Spine.Skin", typeof(int), "UnityEngine.PolygonCollider2D[]", typeof(Int32&)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Spine.Unity.BoundingBoxFollowerGraphic", Member = "AddCollidersForSkin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Spine.Skin", typeof(int), "UnityEngine.PolygonCollider2D[]", typeof(float), typeof(Int32&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public void set_usedByEffector(bool value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void set_usedByEffector_Injected(IntPtr _unity_self, bool value) { }

}

