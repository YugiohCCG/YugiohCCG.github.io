namespace UnityEngine.EventSystems;

[AddComponentMenu("Event/Physics 2D Raycaster")]
[RequireComponent(typeof(Camera))]
public class Physics2DRaycaster : PhysicsRaycaster
{
	private RaycastHit2D[] m_Hits; //Field offset: 0x48

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[DeduplicatedMethod]
	protected Physics2DRaycaster() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SortingGroup), Member = "get_invalidSortingGroupID", ReturnType = typeof(int))]
	[Calls(Type = typeof(Transform), Member = "get_position", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(SortingGroup), Member = "GetSortingGroupByIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(SortingGroup))]
	[Calls(Type = typeof(Renderer), Member = "get_sortingOrder", ReturnType = typeof(int))]
	[Calls(Type = typeof(Renderer), Member = "get_sortingLayerID", ReturnType = typeof(int))]
	[Calls(Type = typeof(Renderer), Member = "get_sortingGroupOrder", ReturnType = typeof(int))]
	[Calls(Type = typeof(SortingGroup), Member = "get_sortingLayerID", ReturnType = typeof(int))]
	[Calls(Type = typeof(Renderer), Member = "get_sortingGroupID", ReturnType = typeof(int))]
	[Calls(Type = typeof(GameObject), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(RaycastHit2D), Member = "get_collider", ReturnType = typeof(Collider2D))]
	[Calls(Type = typeof(PhysicsRaycaster), Member = "get_finalEventMask", ReturnType = typeof(int))]
	[Calls(Type = typeof(ReflectionMethodsCache), Member = "get_Singleton", ReturnType = typeof(ReflectionMethodsCache))]
	[Calls(Type = typeof(PhysicsRaycaster), Member = "ComputeRayAndDistance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData), typeof(Ray&), typeof(Int32&), typeof(Single&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(SortingGroup), Member = "get_sortingOrder", ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 7)]
	[ContainsUnimplementedInstructions]
	public virtual void Raycast(PointerEventData eventData, List<RaycastResult> resultAppendList) { }

}

