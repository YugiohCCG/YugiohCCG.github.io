namespace UnityEngine.UIElements;

public class MultiColumnListViewController : BaseListViewController
{
	private MultiColumnController m_ColumnController; //Field offset: 0x48

	public MultiColumnController columnController
	{
		[CallerCount(Count = 10)]
		[DeduplicatedMethod]
		 get { } //Length: 254
	}

	[CalledBy(Type = typeof(MultiColumnListView), Member = "CreateViewController", ReturnType = typeof(CollectionViewController))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(MultiColumnController), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Columns), typeof(SortColumnDescriptions), typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.SortColumnDescription>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseListViewController), Member = "add_itemsSourceSizeChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 3)]
	public MultiColumnListViewController(Columns columns, SortColumnDescriptions sortDescriptions, List<SortColumnDescription> sortedColumns) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MultiColumnController), Member = "GetSourceIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(MultiColumnController), Member = "BindItem", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(int), "T"}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	protected virtual void BindItem(VisualElement element, int index) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MultiColumnController), Member = "DestroyItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	protected virtual void DestroyItem(VisualElement element) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseListViewController), Member = "get_baseListView", ReturnType = typeof(BaseListView))]
	[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(MultiColumnController), Member = "Dispose", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	public virtual void Dispose() { }

	[CallerCount(Count = 10)]
	[DeduplicatedMethod]
	public MultiColumnController get_columnController() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MultiColumnController), Member = "GetSourceIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 1)]
	public virtual int GetIdForIndex(int index) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MultiColumnController), Member = "GetSortedIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 1)]
	public virtual int GetIndexForId(int id) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MultiColumnController), Member = "GetSourceIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CollectionViewController), Member = "GetItemForIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(object))]
	[CallsUnknownMethods(Count = 1)]
	public virtual object GetItemForIndex(int index) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseListViewController), Member = "InvokeBindItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ReusableCollectionItem), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "SetEnabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "set_tooltip", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	internal virtual void InvokeBindItem(ReusableCollectionItem reusableItem, int index) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseListViewController), Member = "get_baseListView", ReturnType = typeof(BaseListView))]
	[Calls(Type = typeof(ReusableMultiColumnListViewItem), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(Columns), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseListViewController), Member = "PostInitRegistration", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ReusableListViewItem)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseVerticalCollectionView), Member = "get_reorderable", ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElement), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "set_name", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ReusableListViewItem), Member = "UpdateHierarchy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(VisualElement), typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	internal virtual void InvokeMakeItem(ReusableCollectionItem reusableItem) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MultiColumnController), Member = "MakeItem", ReturnType = typeof(VisualElement))]
	[CallsUnknownMethods(Count = 1)]
	protected virtual VisualElement MakeItem() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MultiColumnController), Member = "PrepareView", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseVerticalCollectionView)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseListViewController), Member = "get_baseListView", ReturnType = typeof(BaseListView))]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	protected virtual void PrepareView() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MultiColumnController), Member = "SortIfNeeded", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	internal virtual void PreRefresh() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MultiColumnController), Member = "UpdateDragger", ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseVerticalCollectionView), Member = "RefreshItems", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private void SortIfNeeded() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MultiColumnController), Member = "UnbindItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	protected virtual void UnbindItem(VisualElement element, int index) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseListViewController), Member = "get_baseListView", ReturnType = typeof(BaseListView))]
	[Calls(Type = typeof(BaseVerticalCollectionView), Member = "get_reorderable", ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElement), Member = "EnableInClassList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private void UpdateReorderClassList() { }

}

