namespace UnityEngine;

[NativeClass("RaycastHit2D", "struct RaycastHit2D;")]
[NativeHeader("Runtime/Interfaces/IPhysics2D.h")]
[RequiredByNativeCode(Optional = True, GenerateProxy = True)]
public struct RaycastHit2D
{
	[NativeName("centroid")]
	private Vector2 m_Centroid; //Field offset: 0x0
	[NativeName("point")]
	private Vector2 m_Point; //Field offset: 0x8
	[NativeName("normal")]
	private Vector2 m_Normal; //Field offset: 0x10
	[NativeName("distance")]
	private float m_Distance; //Field offset: 0x18
	[NativeName("fraction")]
	private float m_Fraction; //Field offset: 0x1C
	[NativeName("collider")]
	private int m_Collider; //Field offset: 0x20

	public Collider2D collider
	{
		[CalledBy(Type = "UnityEngine.InputSystem.UI.TrackedDeviceRaycaster", Member = "PerformRaycast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.InputSystem.UI.ExtendedPointerEventData", "System.Collections.Generic.List`1<RaycastResult>"}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.EventSystems.Physics2DRaycaster", Member = "Raycast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.EventSystems.PointerEventData", "System.Collections.Generic.List`1<RaycastResult>"}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(Object), Member = "FindObjectFromInstanceID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Object))]
		 get { } //Length: 158
	}

	public float distance
	{
		[CallerCount(Count = 63)]
		[DeduplicatedMethod]
		 get { } //Length: 8
	}

	public Vector2 normal
	{
		[CallerCount(Count = 19)]
		[DeduplicatedMethod]
		 get { } //Length: 21
	}

	public Vector2 point
	{
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 21
	}

	[CalledBy(Type = "UnityEngine.InputSystem.UI.TrackedDeviceRaycaster", Member = "PerformRaycast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.InputSystem.UI.ExtendedPointerEventData", "System.Collections.Generic.List`1<RaycastResult>"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.EventSystems.Physics2DRaycaster", Member = "Raycast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.EventSystems.PointerEventData", "System.Collections.Generic.List`1<RaycastResult>"}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Object), Member = "FindObjectFromInstanceID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Object))]
	public Collider2D get_collider() { }

	[CallerCount(Count = 63)]
	[DeduplicatedMethod]
	public float get_distance() { }

	[CallerCount(Count = 19)]
	[DeduplicatedMethod]
	public Vector2 get_normal() { }

	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	public Vector2 get_point() { }

}

