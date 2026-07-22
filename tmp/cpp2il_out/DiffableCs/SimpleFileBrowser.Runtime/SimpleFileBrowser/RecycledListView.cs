namespace SimpleFileBrowser;

[RequireComponent(typeof(ScrollRect))]
public class RecycledListView : MonoBehaviour, IPointerClickHandler, IEventSystemHandler
{
	[SerializeField]
	private FileBrowser fileBrowser; //Field offset: 0x20
	[SerializeField]
	private RectTransform viewportTransform; //Field offset: 0x28
	[SerializeField]
	private RectTransform contentTransform; //Field offset: 0x30
	private float itemHeight; //Field offset: 0x38
	private float _1OverItemHeight; //Field offset: 0x3C
	private float viewportHeight; //Field offset: 0x40
	private readonly Dictionary<Int32, ListItem> items; //Field offset: 0x48
	private readonly Stack<ListItem> pooledItems; //Field offset: 0x50
	private IListViewAdapter adapter; //Field offset: 0x58
	private int currentTopIndex; //Field offset: 0x60
	private int currentBottomIndex; //Field offset: 0x64

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public RecycledListView() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RecycledListView), Member = "UpdateItemsInTheList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CompilerGenerated]
	private void <Start>b__11_0(Vector2 pos) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Transform), Member = "SetParent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Transform), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Stack`1<System.Object>), Member = "Pop", ReturnType = typeof(object))]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(GameObject), Member = "SetActive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RectTransform), Member = "set_anchoredPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32, System.Object>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	private void CreateItemAtIndex(int index) { }

	[CalledBy(Type = typeof(RecycledListView), Member = "UpdateItemsInTheList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Transform), Member = "SetParent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Transform), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Stack`1<System.Object>), Member = "Pop", ReturnType = typeof(object))]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(GameObject), Member = "SetActive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RectTransform), Member = "set_anchoredPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32, System.Object>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	private void CreateItemsBetweenIndices(int topIndex, int bottomIndex) { }

	[CalledBy(Type = typeof(FileBrowser), Member = "RefreshSkin", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RecycledListView), Member = "OnSkinRefreshed", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RecycledListView), Member = "UpdateItemsInTheList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(Dictionary`2), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = "TValue")]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(GameObject), Member = "SetActive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Stack`1<System.Object>), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private void DestroyItemsBetweenIndices(int topIndex, int bottomIndex) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FileBrowser), Member = "OnContextMenuTriggered", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FileBrowser), Member = "DeselectAllFiles", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public override void OnPointerClick(PointerEventData eventData) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RecycledListView), Member = "DestroyItemsBetweenIndices", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RecycledListView), Member = "UpdateList", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	public void OnSkinRefreshed() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RectTransform), Member = "get_rect", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(RecycledListView), Member = "UpdateItemsInTheList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void OnViewportDimensionsChanged() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 3)]
	public void SetAdapter(IListViewAdapter adapter) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RectTransform), Member = "get_rect", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(UnityEvent`1), Member = "AddListener", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Events.UnityAction`1<T0>"}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void Start() { }

	[CalledBy(Type = typeof(RecycledListView), Member = "UpdateItemsInTheList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Dictionary`2), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = "TValue")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void UpdateItemContentsBetweenIndices(int topIndex, int bottomIndex) { }

	[CalledBy(Type = typeof(FileBrowser), Member = "OnWindowDimensionsChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FileBrowserMovement), Member = "OnResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RecycledListView), Member = "UpdateList", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RecycledListView), Member = "OnViewportDimensionsChanged", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RecycledListView), Member = "<Start>b__11_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(RecycledListView), Member = "DestroyItemsBetweenIndices", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RectTransform), Member = "get_anchoredPosition", ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(RecycledListView), Member = "CreateItemsBetweenIndices", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RecycledListView), Member = "UpdateItemContentsBetweenIndices", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	[ContainsUnimplementedInstructions]
	private void UpdateItemsInTheList(bool updateAllVisibleItems = false) { }

	[CalledBy(Type = "SimpleFileBrowser.FileBrowser+<CreateNewFolderCoroutine>d__226", Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(FileBrowser), Member = "RefreshSkin", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FileBrowser), Member = "RefreshFiles", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FileBrowser), Member = "SelectAllFiles", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FileBrowser), Member = "DeselectAllFiles", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RecycledListView), Member = "OnSkinRefreshed", ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(RectTransform), Member = "set_sizeDelta", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RectTransform), Member = "get_rect", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(RecycledListView), Member = "UpdateItemsInTheList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	public void UpdateList() { }

}

