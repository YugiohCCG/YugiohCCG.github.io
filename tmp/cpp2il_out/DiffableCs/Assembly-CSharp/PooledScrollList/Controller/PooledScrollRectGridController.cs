namespace PooledScrollList.Controller;

public class PooledScrollRectGridController : PooledScrollRectBase
{
	private readonly List<LayoutElement> _activeSpaceElements; //Field offset: 0x78
	private Pool<LayoutElement> _spaceElenemtsPool; //Field offset: 0x80
	private GridLayoutGroup gridLayoutGroup; //Field offset: 0x88
	private int _constraintCount; //Field offset: 0x90
	public int SpaceElementsPoolCapacity; //Field offset: 0x94
	private LayoutElement _baseSpaceElement; //Field offset: 0x98

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PooledScrollRectBase), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public PooledScrollRectGridController() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Pool`1), Member = "GetNext", ReturnType = "T")]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Transform), Member = "SetParent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Transform), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Transform), Member = "SetSiblingIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Pool`1), Member = "Return", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "RemoveAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	protected virtual void AdjustSpaceElement(float size) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PooledScrollRectBase), Member = "Awake", ReturnType = typeof(void))]
	[Calls(Type = typeof(PooledScrollRectBase), Member = "CreateSpaceElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScrollRect), typeof(float)}, ReturnType = typeof(LayoutElement))]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Pool`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", typeof(Transform), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(PooledScrollRectGridController), Member = "UpdateSizing", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	protected virtual void Awake() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PooledScrollRectBase), Member = "OnDestroy", ReturnType = typeof(void))]
	[Calls(Type = typeof(Pool`1), Member = "Return", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Pool`1), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(Object), Member = "Destroy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	protected virtual void OnDestroy() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List`1), Member = "RemoveAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Insert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Transform), Member = "GetSiblingIndex", ReturnType = typeof(int))]
	[Calls(Type = typeof(Transform), Member = "SetSiblingIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(PooledElement), Member = "set_Data", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPooledData)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 3)]
	protected virtual void ReorientElement(ReorientMethod reorientMethod, int elementsCulledAbove) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PooledScrollRectGridController), Member = "UpdateSizing", ReturnType = typeof(void))]
	[Calls(Type = typeof(PooledScrollRectBase), Member = "AdjustContentSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(RectTransform), Member = "get_rect", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(ScrollRect), Member = "get_verticalNormalizedPosition", ReturnType = typeof(float))]
	[Calls(Type = typeof(ScrollRect), Member = "get_horizontalNormalizedPosition", ReturnType = typeof(float))]
	[Calls(Type = typeof(PooledScrollRectBase), Member = "InitializeElements", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	protected virtual void UpdateContent() { }

	[CalledBy(Type = typeof(PooledScrollRectGridController), Member = "Awake", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PooledScrollRectGridController), Member = "UpdateContent", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(RectOffset), Member = "set_bottom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Debug), Member = "LogWarning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RectTransform), Member = "get_rect", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(RectOffset), Member = "set_top", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RectOffset), Member = "set_right", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RectOffset), Member = "set_left", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(General), Member = "GetDynamicConstraintCount", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GridLayoutGroup)}, ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(General), Member = "ToInteger", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(Vector2Int))]
	[Calls(Type = typeof(PooledElement), Member = "get_RectTransform", ReturnType = typeof(RectTransform))]
	[CallsUnknownMethods(Count = 5)]
	[ContainsUnimplementedInstructions]
	protected void UpdateSizing() { }

}

