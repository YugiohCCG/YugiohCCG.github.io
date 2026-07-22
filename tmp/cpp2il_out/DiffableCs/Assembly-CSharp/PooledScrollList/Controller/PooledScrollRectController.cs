namespace PooledScrollList.Controller;

public class PooledScrollRectController : PooledScrollRectBase
{
	private LayoutElement _spaceElement; //Field offset: 0x78
	private HorizontalOrVerticalLayoutGroup _layoutGroup; //Field offset: 0x80

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PooledScrollRectBase), Member = ".ctor", ReturnType = typeof(void))]
	public PooledScrollRectController() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Transform), Member = "SetAsFirstSibling", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	protected virtual void AdjustSpaceElement(float size) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PooledScrollRectBase), Member = "Awake", ReturnType = typeof(void))]
	[Calls(Type = typeof(PooledScrollRectBase), Member = "CreateSpaceElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScrollRect), typeof(float)}, ReturnType = typeof(LayoutElement))]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Transform), Member = "SetParent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Transform), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(PooledScrollRectController), Member = "UpdateSizing", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	protected virtual void Awake() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PooledScrollRectBase), Member = "OnDestroy", ReturnType = typeof(void))]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(Object), Member = "Destroy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	protected virtual void OnDestroy() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List`1), Member = "RemoveAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Insert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Transform), Member = "GetSiblingIndex", ReturnType = typeof(int))]
	[Calls(Type = typeof(Transform), Member = "SetSiblingIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(PooledElement), Member = "set_Data", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPooledData)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 2)]
	protected virtual void ReorientElement(ReorientMethod reorientMethod, int elementsCulledAbove) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PooledScrollRectController), Member = "UpdateSizing", ReturnType = typeof(void))]
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

	[CalledBy(Type = typeof(PooledScrollRectController), Member = "Awake", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PooledScrollRectController), Member = "UpdateContent", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Debug), Member = "LogWarning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(PooledElement), Member = "get_RectTransform", ReturnType = typeof(RectTransform))]
	[Calls(Type = typeof(RectTransform), Member = "get_rect", ReturnType = typeof(Rect))]
	[CallsUnknownMethods(Count = 3)]
	protected void UpdateSizing() { }

}

