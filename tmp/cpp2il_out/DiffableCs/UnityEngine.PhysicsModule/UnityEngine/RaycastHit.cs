namespace UnityEngine;

[NativeHeader("PhysicsScriptingClasses.h")]
[NativeHeader("Modules/Physics/RaycastHit.h")]
[NativeHeader("Runtime/Interfaces/IRaycast.h")]
[UsedByNativeCode]
public struct RaycastHit
{
	[NativeName("point")]
	internal Vector3 m_Point; //Field offset: 0x0
	[NativeName("normal")]
	internal Vector3 m_Normal; //Field offset: 0xC
	[NativeName("faceID")]
	internal uint m_FaceID; //Field offset: 0x18
	[NativeName("distance")]
	internal float m_Distance; //Field offset: 0x1C
	[NativeName("uv")]
	internal Vector2 m_UV; //Field offset: 0x20
	[NativeName("collider")]
	internal int m_Collider; //Field offset: 0x28

	public Collider collider
	{
		[CalledBy(Type = "UnityEngine.EventSystems.PhysicsRaycaster", Member = "Raycast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.EventSystems.PointerEventData", "System.Collections.Generic.List`1<RaycastResult>"}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Object), Member = "FindObjectFromInstanceID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Object))]
		 get { } //Length: 158
	}

	public float distance
	{
		[CallerCount(Count = 57)]
		[DeduplicatedMethod]
		 get { } //Length: 8
	}

	public Vector3 normal
	{
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 19
	}

	public Vector3 point
	{
		[CallerCount(Count = 5)]
		[DeduplicatedMethod]
		 get { } //Length: 18
	}

	[CalledBy(Type = "UnityEngine.EventSystems.PhysicsRaycaster", Member = "Raycast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.EventSystems.PointerEventData", "System.Collections.Generic.List`1<RaycastResult>"}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "FindObjectFromInstanceID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Object))]
	public Collider get_collider() { }

	[CallerCount(Count = 57)]
	[DeduplicatedMethod]
	public float get_distance() { }

	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	public Vector3 get_normal() { }

	[CallerCount(Count = 5)]
	[DeduplicatedMethod]
	public Vector3 get_point() { }

}

