namespace SimpleFileBrowser;

public class FileBrowserRenamedItem : MonoBehaviour
{
	internal sealed class OnRenameCompleted : MulticastDelegate
	{

		[CallerCount(Count = 10)]
		[CallsUnknownMethods(Count = 4)]
		[DeduplicatedMethod]
		public OnRenameCompleted(object object, IntPtr method) { }

		[CallerCount(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		public override IAsyncResult BeginInvoke(string filename, AsyncCallback callback, object object) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		public override void EndInvoke(IAsyncResult result) { }

		[CallerCount(Count = 3)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public override void Invoke(string filename) { }

	}

	[SerializeField]
	private Image background; //Field offset: 0x20
	[SerializeField]
	private Image icon; //Field offset: 0x28
	[SerializeField]
	private InputField nameInputField; //Field offset: 0x30
	private OnRenameCompleted onRenameCompleted; //Field offset: 0x38
	private RectTransform m_transform; //Field offset: 0x40

	public InputField InputField
	{
		[CallerCount(Count = 62)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public RectTransform TransformComponent
	{
		[CalledBy(Type = typeof(FileBrowser), Member = "RefreshSkin", ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
		[CallsUnknownMethods(Count = 3)]
		 get { } //Length: 210
	}

	[CallerCount(Count = 36)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public FileBrowserRenamedItem() { }

	[CallerCount(Count = 62)]
	[DeduplicatedMethod]
	public InputField get_InputField() { }

	[CalledBy(Type = typeof(FileBrowser), Member = "RefreshSkin", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[CallsUnknownMethods(Count = 3)]
	public RectTransform get_TransformComponent() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.InputSystem.InputControl`1<UnityEngine.Vector2>), Member = "ReadValue", ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(InputField), Member = "DeactivateInputField", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private void LateUpdate() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(GameObject), Member = "SetActive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(EventSystem), Member = "get_current", ReturnType = typeof(EventSystem))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(EventSystem), Member = "SetSelectedGameObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void OnInputFieldEndEdit(string filename) { }

	[CalledBy(Type = "SimpleFileBrowser.FileBrowser+<CreateNewFolderCoroutine>d__226", Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(FileBrowser), Member = "RenameSelectedFile", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Image), Member = "set_sprite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sprite)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Transform), Member = "SetAsLastSibling", ReturnType = typeof(void))]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(GameObject), Member = "SetActive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputField), Member = "set_text", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputField), Member = "ActivateInputField", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void Show(string initialFilename, Color backgroundColor, Sprite icon, OnRenameCompleted onRenameCompleted) { }

}

