namespace UnityEngine.UIElements;

internal class ReusableMultiColumnTreeViewItem : ReusableTreeViewItem
{

	public virtual VisualElement rootElement
	{
		[CallerCount(Count = 106)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ReusableCollectionItem), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	public ReusableMultiColumnTreeViewItem() { }

	[CallerCount(Count = 106)]
	[DeduplicatedMethod]
	public virtual VisualElement get_rootElement() { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	public virtual void Init(VisualElement item) { }

	[CalledBy(Type = typeof(MultiColumnTreeViewController), Member = "InvokeMakeItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ReusableCollectionItem)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Columns), Member = "get_visibleList", ReturnType = typeof(System.Collections.Generic.IEnumerable`1<UnityEngine.UIElements.Column>))]
	[Calls(Type = typeof(Columns), Member = "IsPrimary", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Column)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElement), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(VisualElement))]
	[Calls(Type = typeof(VisualElement), Member = "GetProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyName)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(ReusableTreeViewItem), Member = "InitExpandHierarchy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(VisualElement)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 12)]
	public void Init(VisualElement container, Columns columns) { }

}

