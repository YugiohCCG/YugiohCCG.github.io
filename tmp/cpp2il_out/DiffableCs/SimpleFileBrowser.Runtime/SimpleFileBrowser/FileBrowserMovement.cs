namespace SimpleFileBrowser;

public class FileBrowserMovement : MonoBehaviour
{
	private FileBrowser fileBrowser; //Field offset: 0x20
	private RectTransform canvasTR; //Field offset: 0x28
	private Camera canvasCam; //Field offset: 0x30
	[SerializeField]
	private RectTransform window; //Field offset: 0x38
	[SerializeField]
	private RecycledListView listView; //Field offset: 0x40
	private Vector2 initialTouchPos; //Field offset: 0x48
	private Vector2 initialAnchoredPos; //Field offset: 0x50
	private Vector2 initialSizeDelta; //Field offset: 0x58

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public FileBrowserMovement() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[CallsUnknownMethods(Count = 3)]
	public void Initialize(FileBrowser fileBrowser) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RectTransformUtility), Member = "ScreenPointToLocalPointInRectangle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform), typeof(Vector2), typeof(Camera), typeof(Vector2&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(RectTransform), Member = "get_anchoredPosition", ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(RectTransform), Member = "set_anchoredPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	public void OnDrag(BaseEventData data) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PointerEventData), Member = "get_pressEventCamera", ReturnType = typeof(Camera))]
	[Calls(Type = typeof(RectTransformUtility), Member = "ScreenPointToLocalPointInRectangle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform), typeof(Vector2), typeof(Camera), typeof(Vector2&)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 3)]
	public void OnDragStarted(BaseEventData data) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FileBrowser), Member = "EnsureWindowIsWithinBounds", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public void OnEndDrag(BaseEventData data) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FileBrowser), Member = "EnsureWindowIsWithinBounds", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public void OnEndResize(BaseEventData data) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RectTransformUtility), Member = "ScreenPointToLocalPointInRectangle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform), typeof(Vector2), typeof(Camera), typeof(Vector2&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(RectTransform), Member = "get_sizeDelta", ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(RectTransform), Member = "set_anchoredPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RectTransform), Member = "set_sizeDelta", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FileBrowser), Member = "OnWindowDimensionsChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RectTransform), Member = "get_rect", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(RecycledListView), Member = "UpdateItemsInTheList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	public void OnResize(BaseEventData data) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PointerEventData), Member = "get_pressEventCamera", ReturnType = typeof(Camera))]
	[Calls(Type = typeof(RectTransform), Member = "get_anchoredPosition", ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(RectTransform), Member = "get_sizeDelta", ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(RectTransformUtility), Member = "ScreenPointToLocalPointInRectangle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform), typeof(Vector2), typeof(Camera), typeof(Vector2&)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 3)]
	public void OnResizeStarted(BaseEventData data) { }

}

