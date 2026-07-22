namespace UnityEngine.UIElements;

internal class ListViewReorderableDragAndDropController : BaseReorderableDragAndDropController
{
	protected readonly BaseListView m_ListView; //Field offset: 0x28

	[CalledBy(Type = typeof(BaseListView), Member = "CreateDragAndDropController", ReturnType = typeof(ICollectionDragAndDropController))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BaseReorderableDragAndDropController), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseVerticalCollectionView)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public ListViewReorderableDragAndDropController(BaseListView view) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	public virtual DragVisualMode HandleDragAndDrop(IListDragAndDropArgs args) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseVerticalCollectionView), Member = "get_reorderable", ReturnType = typeof(bool))]
	[Calls(Type = typeof(List`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[Calls(Type = typeof(BaseListView), Member = "get_viewController", ReturnType = typeof(BaseListViewController))]
	[Calls(Type = typeof(BaseVerticalCollectionView), Member = "get_selectionType", ReturnType = typeof(SelectionType))]
	[Calls(Type = typeof(BaseVerticalCollectionView), Member = "ClearSelection", ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseVerticalCollectionView), Member = "SetSelectionWithoutNotify", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Int32>)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 3)]
	public virtual void OnDrop(IListDragAndDropArgs args) { }

}

