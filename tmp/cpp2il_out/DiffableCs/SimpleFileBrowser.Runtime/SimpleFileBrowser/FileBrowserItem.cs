namespace SimpleFileBrowser;

public class FileBrowserItem : ListItem, IPointerClickHandler, IEventSystemHandler, IPointerDownHandler, IPointerUpHandler, IPointerEnterHandler, IPointerExitHandler
{
	private const float DOUBLE_CLICK_TIME = 0.5; //Field offset: 0x0
	private const float TOGGLE_MULTI_SELECTION_HOLD_TIME = 0.5; //Field offset: 0x0
	protected FileBrowser fileBrowser; //Field offset: 0x38
	[SerializeField]
	private Image background; //Field offset: 0x40
	[SerializeField]
	private Image icon; //Field offset: 0x48
	[SerializeField]
	private Image multiSelectionToggle; //Field offset: 0x50
	[SerializeField]
	private Text nameText; //Field offset: 0x58
	private bool isSelected; //Field offset: 0x60
	private bool isHidden; //Field offset: 0x61
	private UISkin skin; //Field offset: 0x68
	private float pressTime; //Field offset: 0x70
	private float prevClickTime; //Field offset: 0x74
	private RectTransform m_transform; //Field offset: 0x78
	[CompilerGenerated]
	private bool <IsDirectory>k__BackingField; //Field offset: 0x80

	public Image Icon
	{
		[CallerCount(Count = 10)]
		[DeduplicatedMethod]
		 get { } //Length: 254
	}

	public private bool IsDirectory
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 8
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private set { } //Length: 7
	}

	public string Name
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 39
	}

	public RectTransform TransformComponent
	{
		[CalledBy(Type = typeof(FileBrowser), Member = "RefreshDriveQuickLinks", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(FileBrowser), Member = "RefreshSkin", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(FileBrowser), Member = "AddQuickLink", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sprite), typeof(string), typeof(string)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(FileBrowser), Member = "ClearQuickLinksInternal", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(FileBrowserItem), Member = "OnSkinRefreshed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UISkin), typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 7)]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
		[CallsUnknownMethods(Count = 3)]
		 get { } //Length: 210
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public FileBrowserItem() { }

	[CallerCount(Count = 10)]
	[DeduplicatedMethod]
	public Image get_Icon() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public bool get_IsDirectory() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public string get_Name() { }

	[CalledBy(Type = typeof(FileBrowser), Member = "RefreshDriveQuickLinks", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FileBrowser), Member = "RefreshSkin", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FileBrowser), Member = "AddQuickLink", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sprite), typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(FileBrowser), Member = "ClearQuickLinksInternal", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FileBrowserItem), Member = "OnSkinRefreshed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UISkin), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[CallsUnknownMethods(Count = 3)]
	public RectTransform get_TransformComponent() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Time), Member = "get_realtimeSinceStartup", ReturnType = typeof(float))]
	[Calls(Type = typeof(FileBrowser), Member = "OnItemSelected", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FileBrowserItem), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FileBrowser), Member = "OnContextMenuTriggered", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public override void OnPointerClick(PointerEventData eventData) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Time), Member = "get_realtimeSinceStartup", ReturnType = typeof(float))]
	[CallsUnknownMethods(Count = 1)]
	public override void OnPointerDown(PointerEventData eventData) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public override void OnPointerEnter(PointerEventData eventData) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public override void OnPointerExit(PointerEventData eventData) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public override void OnPointerUp(PointerEventData eventData) { }

	[CalledBy(Type = typeof(FileBrowser), Member = "SimpleFileBrowser.IListViewAdapter.CreateItem", ReturnType = typeof(ListItem))]
	[CalledBy(Type = typeof(FileBrowser), Member = "RefreshSkin", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FileBrowser), Member = "AddQuickLink", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sprite), typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(FileBrowserItem), Member = "SetFileBrowser", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FileBrowser), typeof(UISkin)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(FileBrowserItem), Member = "get_TransformComponent", ReturnType = typeof(RectTransform))]
	[Calls(Type = typeof(RectTransform), Member = "get_sizeDelta", ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(RectTransform), Member = "set_sizeDelta", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Text), Member = "set_font", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Font)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Text), Member = "set_fontSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Graphic), Member = "get_rectTransform", ReturnType = typeof(RectTransform))]
	[Calls(Type = typeof(FileBrowserItem), Member = "SetSelected", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void OnSkinRefreshed(UISkin skin, bool isInitialized = true) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void set_IsDirectory(bool value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Image), Member = "set_sprite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sprite)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void SetFile(Sprite icon, string name, bool isDirectory) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FileBrowserItem), Member = "OnSkinRefreshed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UISkin), typeof(bool)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void SetFileBrowser(FileBrowser fileBrowser, UISkin skin) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	public void SetHidden(bool isHidden) { }

	[CalledBy(Type = typeof(FileBrowser), Member = "set_CurrentPath", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FileBrowser), Member = "set_MultiSelectionToggleSelectionMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FileBrowser), Member = "SimpleFileBrowser.IListViewAdapter.SetItemContent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ListItem)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FileBrowser), Member = "OnItemSelected", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FileBrowserItem), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FileBrowserItem), Member = "OnSkinRefreshed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UISkin), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(Image), Member = "set_sprite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sprite)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RectTransform), Member = "set_anchoredPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RectTransform), Member = "get_anchoredPosition", ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(RectTransform), Member = "get_sizeDelta", ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(GameObject), Member = "get_activeSelf", ReturnType = typeof(bool))]
	[Calls(Type = typeof(GameObject), Member = "SetActive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Graphic), Member = "get_rectTransform", ReturnType = typeof(RectTransform))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	public void SetSelected(bool isSelected) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Time), Member = "get_realtimeSinceStartup", ReturnType = typeof(float))]
	[Calls(Type = typeof(List`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[Calls(Type = typeof(List`1), Member = "RemoveAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FileBrowser), Member = "set_MultiSelectionToggleSelectionMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Int32>), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(FileBrowser), Member = "OnItemSelected", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FileBrowserItem), typeof(bool)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private void Update() { }

}

