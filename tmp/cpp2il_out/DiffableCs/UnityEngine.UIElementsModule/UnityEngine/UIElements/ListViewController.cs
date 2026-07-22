namespace UnityEngine.UIElements;

public class ListViewController : BaseListViewController
{

	protected ListView listView
	{
		[CalledBy(Type = typeof(ListViewController), Member = "MakeItem", ReturnType = typeof(VisualElement))]
		[CalledBy(Type = typeof(ListViewController), Member = "BindItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ListViewController), Member = "UnbindItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ListViewController), Member = "DestroyItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
		[CallerCount(Count = 9)]
		 get { } //Length: 114
	}

	[CallerCount(Count = 2180)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public ListViewController() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ListViewController), Member = "get_listView", ReturnType = typeof(ListView))]
	[Calls(Type = typeof(BaseVerticalCollectionView), Member = "get_itemsSource", ReturnType = typeof(IList))]
	[Calls(Type = typeof(NotImplementedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 7)]
	[ContainsUnimplementedInstructions]
	protected virtual void BindItem(VisualElement element, int index) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ListViewController), Member = "get_listView", ReturnType = typeof(ListView))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	protected virtual void DestroyItem(VisualElement element) { }

	[CalledBy(Type = typeof(ListViewController), Member = "MakeItem", ReturnType = typeof(VisualElement))]
	[CalledBy(Type = typeof(ListViewController), Member = "BindItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ListViewController), Member = "UnbindItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ListViewController), Member = "DestroyItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[CallerCount(Count = 9)]
	protected ListView get_listView() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ListViewController), Member = "get_listView", ReturnType = typeof(ListView))]
	[Calls(Type = typeof(Label), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(NotImplementedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	protected virtual VisualElement MakeItem() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ListViewController), Member = "get_listView", ReturnType = typeof(ListView))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	protected virtual void UnbindItem(VisualElement element, int index) { }

}

