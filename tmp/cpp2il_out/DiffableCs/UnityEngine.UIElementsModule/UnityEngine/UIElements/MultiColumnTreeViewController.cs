namespace UnityEngine.UIElements;

public abstract class MultiColumnTreeViewController : BaseTreeViewController
{
	private MultiColumnController m_ColumnController; //Field offset: 0x68

	public MultiColumnController columnController
	{
		[CallerCount(Count = 22)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	[CalledBy(Type = typeof(DefaultMultiColumnTreeViewController`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Columns), typeof(SortColumnDescriptions), typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.SortColumnDescription>)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BaseTreeViewController), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(MultiColumnController), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Columns), typeof(SortColumnDescriptions), typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.SortColumnDescription>)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	protected MultiColumnTreeViewController(Columns columns, SortColumnDescriptions sortDescriptions, List<SortColumnDescription> sortedColumns) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MultiColumnController), Member = "BindItem", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(int), "T"}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	protected virtual void BindItem(VisualElement element, int index) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MultiColumnController), Member = "DestroyItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	protected virtual void DestroyItem(VisualElement element) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MultiColumnController), Member = "Dispose", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	public virtual void Dispose() { }

	[CallerCount(Count = 22)]
	[DeduplicatedMethod]
	public MultiColumnController get_columnController() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MultiColumnController), Member = "GetSourceIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(HierarchyViewModel), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(HierarchyNode&))]
	[CallsUnknownMethods(Count = 2)]
	public virtual int GetIdForIndex(int index) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Dictionary`2), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue&"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(HierarchyViewModel), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HierarchyNode&)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(MultiColumnController), Member = "GetSortedIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 2)]
	public virtual int GetIndexForId(int id) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MultiColumnController), Member = "GetSourceIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CollectionViewController), Member = "GetItemForIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(object))]
	[CallsUnknownMethods(Count = 1)]
	public virtual object GetItemForIndex(int index) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ReusableMultiColumnTreeViewItem), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(Columns)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseTreeViewController), Member = "PostInitRegistration", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ReusableTreeViewItem)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	internal virtual void InvokeMakeItem(ReusableCollectionItem reusableItem) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MultiColumnController), Member = "MakeItem", ReturnType = typeof(VisualElement))]
	[CallsUnknownMethods(Count = 1)]
	protected virtual VisualElement MakeItem() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MultiColumnController), Member = "PrepareView", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseVerticalCollectionView)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	protected virtual void PrepareView() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseTreeViewController), Member = "UpdateHierarchy", ReturnType = typeof(void))]
	[Calls(Type = typeof(MultiColumnController), Member = "SortIfNeeded", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	internal virtual void PreRefresh() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MultiColumnController), Member = "UnbindItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	protected virtual void UnbindItem(VisualElement element, int index) { }

}

