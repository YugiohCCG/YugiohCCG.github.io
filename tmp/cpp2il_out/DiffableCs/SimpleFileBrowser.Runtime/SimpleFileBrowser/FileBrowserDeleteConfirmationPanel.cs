namespace SimpleFileBrowser;

public class FileBrowserDeleteConfirmationPanel : MonoBehaviour
{
	internal sealed class OnDeletionConfirmed : MulticastDelegate
	{

		[CallerCount(Count = 536)]
		[CallsUnknownMethods(Count = 4)]
		[DeduplicatedMethod]
		public OnDeletionConfirmed(object object, IntPtr method) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		public override IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		public override void EndInvoke(IAsyncResult result) { }

		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public override void Invoke() { }

	}

	[SerializeField]
	private Text titleLabel; //Field offset: 0x20
	[SerializeField]
	private GameObject[] deletedItems; //Field offset: 0x28
	[SerializeField]
	private Image[] deletedItemIcons; //Field offset: 0x30
	[SerializeField]
	private Text[] deletedItemNames; //Field offset: 0x38
	[SerializeField]
	private GameObject deletedItemsRest; //Field offset: 0x40
	[SerializeField]
	private Text deletedItemsRestLabel; //Field offset: 0x48
	[SerializeField]
	private RectTransform yesButtonTransform; //Field offset: 0x50
	[SerializeField]
	private RectTransform noButtonTransform; //Field offset: 0x58
	[SerializeField]
	private float narrowScreenWidth; //Field offset: 0x60
	private OnDeletionConfirmed onDeletionConfirmed; //Field offset: 0x68

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public FileBrowserDeleteConfirmationPanel() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Keyboard), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Key)}, ReturnType = typeof(KeyControl))]
	[Calls(Type = typeof(ButtonControl), Member = "get_wasPressedThisFrame", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(GameObject), Member = "SetActive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void LateUpdate() { }

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(GameObject), Member = "SetActive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public void NoButtonClicked() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RectTransform), Member = "set_anchorMin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RectTransform), Member = "set_anchorMax", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	internal void OnCanvasDimensionsChanged(Vector2 size) { }

	[CalledBy(Type = typeof(FileBrowser), Member = "RefreshSkin", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Component), Member = "GetComponentInChildren", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(Image), Member = "set_sprite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sprite)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(UISkin), Member = "ApplyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Button)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Text), Member = "set_font", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Font)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Text), Member = "set_fontSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GameObject), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 2)]
	internal void RefreshSkin(UISkin skin) { }

	[CalledBy(Type = typeof(FileBrowser), Member = "DeleteSelectedFiles", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameObject), Member = "SetActive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[Calls(Type = typeof(FileBrowser), Member = "GetIconForFileEntry", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FileSystemEntry)}, ReturnType = typeof(Sprite))]
	[Calls(Type = typeof(Image), Member = "set_sprite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sprite)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	internal void Show(FileBrowser fileBrowser, List<FileSystemEntry> items, List<Int32> selectedItemIndices, OnDeletionConfirmed onDeletionConfirmed) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(GameObject), Member = "SetActive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void YesButtonClicked() { }

}

