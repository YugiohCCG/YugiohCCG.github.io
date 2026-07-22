namespace UnityEngine.UIElements;

public class DefaultTreeViewController : TreeViewController
{
	private TreeDataController<T> m_TreeDataController; //Field offset: 0x0

	public virtual IList itemsSource
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 25
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
		[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(DefaultTreeViewController`1), Member = "SetRootItems", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IList`1<TreeViewItemData`1<T>>"}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		 set { } //Length: 268
	}

	private TreeDataController<T> treeDataController
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(TreeDataController`1), Member = ".ctor", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		private get { } //Length: 131
	}

	[CalledBy(Type = typeof(TreeView), Member = "CreateViewController", ReturnType = typeof(CollectionViewController))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TreeViewController), Member = ".ctor", ReturnType = typeof(void))]
	[DeduplicatedMethod]
	public DefaultTreeViewController`1() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseTreeViewController), Member = "CreateNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HierarchyNode&)}, ReturnType = typeof(HierarchyNode))]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private HierarchyNode <SetRootItems>b__6_0(HierarchyNode node) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseTreeViewController), Member = "UpdateIdToNodeDictionary", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(HierarchyNode&), typeof(bool)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void <SetRootItems>b__6_1(int id, HierarchyNode node) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public virtual IList get_itemsSource() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TreeDataController`1), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	private TreeDataController<T> get_treeDataController() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseTreeViewController), Member = "GetHierarchyNodeByIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(HierarchyNode))]
	[Calls(Type = typeof(TreeDataController`1), Member = "GetDataForNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HierarchyNode)}, ReturnType = "T")]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public virtual object GetItemForIndex(int index) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DefaultTreeViewController`1), Member = "SetRootItems", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IList`1<TreeViewItemData`1<T>>"}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public virtual void set_itemsSource(IList value) { }

	[CalledBy(Type = typeof(DefaultTreeViewController`1), Member = "set_itemsSource", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IList)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BaseTreeViewController), Member = "ClearIdToNodeDictionary", ReturnType = typeof(void))]
	[Calls(Type = typeof(TreeDataController`1), Member = "ClearNodeToDataDictionary", ReturnType = typeof(void))]
	[Calls(Type = typeof(Hierarchy), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseTreeViewController), Member = "set_hierarchy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Hierarchy)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Action`2<System.Int32, Unity.Hierarchy.HierarchyNode>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TreeDataController`1), Member = "ConvertTreeViewItemDataToHierarchy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TreeViewItemData`1<T>>", typeof(System.Func`2<Unity.Hierarchy.HierarchyNode, Unity.Hierarchy.HierarchyNode>), typeof(System.Action`2<System.Int32, Unity.Hierarchy.HierarchyNode>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseTreeViewController), Member = "UpdateHierarchy", ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseTreeViewController), Member = "get_baseTreeView", ReturnType = typeof(BaseTreeView))]
	[Calls(Type = typeof(BaseTreeViewController), Member = "IsViewDataKeyEnabled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(BaseTreeViewController), Member = "OnViewDataReadyUpdateNodes", ReturnType = typeof(void))]
	[Calls(Type = typeof(CollectionViewController), Member = "SetHierarchyViewModelWithoutNotify", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HierarchyViewModel)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	public override void SetRootItems(IList<TreeViewItemData`1<T>> items) { }

}

