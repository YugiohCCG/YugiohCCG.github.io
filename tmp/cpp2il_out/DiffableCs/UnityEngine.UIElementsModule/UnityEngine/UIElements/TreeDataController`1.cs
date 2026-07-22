namespace UnityEngine.UIElements;

internal sealed class TreeDataController
{
	private Dictionary<HierarchyNode, TreeViewItemData`1<T>> m_NodeToItemDataDictionary; //Field offset: 0x0
	private Stack<IEnumerator`1<TreeViewItemData`1<T>>> m_ItemStack; //Field offset: 0x0
	private Stack<HierarchyNode> m_NodeStack; //Field offset: 0x0

	[CalledBy(Type = typeof(DefaultMultiColumnTreeViewController`1), Member = "get_treeDataController", ReturnType = "UnityEngine.UIElements.TreeDataController`1<T>")]
	[CalledBy(Type = typeof(DefaultTreeViewController`1), Member = "get_treeDataController", ReturnType = "UnityEngine.UIElements.TreeDataController`1<T>")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<Unity.Hierarchy.HierarchyNode, UnityEngine.UIElements.TreeViewItemData`1<System.Object>>), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 5)]
	[DeduplicatedMethod]
	public TreeDataController`1() { }

	[CalledBy(Type = typeof(DefaultMultiColumnTreeViewController`1), Member = "SetRootItems", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IList`1<TreeViewItemData`1<T>>"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DefaultTreeViewController`1), Member = "SetRootItems", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IList`1<TreeViewItemData`1<T>>"}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Dictionary`2), Member = "Clear", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	internal void ClearNodeToDataDictionary() { }

	[CalledBy(Type = typeof(DefaultMultiColumnTreeViewController`1), Member = "SetRootItems", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IList`1<TreeViewItemData`1<T>>"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DefaultTreeViewController`1), Member = "SetRootItems", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IList`1<TreeViewItemData`1<T>>"}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Stack`1), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(HierarchyNode), Member = "get_Null", ReturnType = typeof(HierarchyNode&))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<Unity.Hierarchy.HierarchyNode, UnityEngine.UIElements.TreeViewItemData`1<System.Object>>), Member = "TryAdd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HierarchyNode), typeof(UnityEngine.UIElements.TreeViewItemData`1<System.Object>)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Stack`1), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Stack`1<System.Object>), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Stack`1), Member = "Pop", ReturnType = "T")]
	[Calls(Type = typeof(System.Collections.Generic.Stack`1<System.Object>), Member = "Pop", ReturnType = typeof(object))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 16)]
	[DeduplicatedMethod]
	internal void ConvertTreeViewItemDataToHierarchy(IEnumerable<TreeViewItemData`1<T>> list, Func<HierarchyNode, HierarchyNode> createNode, Action<Int32, HierarchyNode> updateDictionary) { }

	[CalledBy(Type = typeof(DefaultMultiColumnTreeViewController`1), Member = "GetItemForIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(DefaultTreeViewController`1), Member = "GetItemForIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(object))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<Unity.Hierarchy.HierarchyNode, UnityEngine.UIElements.TreeViewItemData`1<System.Object>>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HierarchyNode), typeof(TreeViewItemData`1<Object>&)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public T GetDataForNode(HierarchyNode node) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<Unity.Hierarchy.HierarchyNode, UnityEngine.UIElements.TreeViewItemData`1<System.Object>>), Member = "TryAdd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HierarchyNode), typeof(UnityEngine.UIElements.TreeViewItemData`1<System.Object>)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	internal void UpdateNodeToDataDictionary(HierarchyNode node, TreeViewItemData<T> item) { }

}

