namespace UnityEngine;

[NativeHeader("Modules/Physics2D/Public/BoxCollider2D.h")]
public sealed class BoxCollider2D : Collider2D
{

	public Vector2 size
	{
		[CalledBy(Type = "Extensions.CopyableCardText", Member = "Start", ReturnType = typeof(void))]
		[CalledBy(Type = "Extensions.DeckTrunk", Member = "OnBeginDrag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.EventSystems.PointerEventData"}, ReturnType = typeof(void))]
		[CalledBy(Type = "Extensions.DeckTrunk", Member = "MakeDragStartBox", ReturnType = typeof(void))]
		[CallerCount(Count = 6)]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		 set { } //Length: 128
	}

	[CallerCount(Count = 36)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public BoxCollider2D() { }

	[CalledBy(Type = "Extensions.CopyableCardText", Member = "Start", ReturnType = typeof(void))]
	[CalledBy(Type = "Extensions.DeckTrunk", Member = "OnBeginDrag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.EventSystems.PointerEventData"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Extensions.DeckTrunk", Member = "MakeDragStartBox", ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public void set_size(Vector2 value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void set_size_Injected(IntPtr _unity_self, in Vector2 value) { }

}

