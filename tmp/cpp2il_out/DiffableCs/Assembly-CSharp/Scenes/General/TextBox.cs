namespace Scenes.General;

public class TextBox : DraggableFrame
{
	[CompilerGenerated]
	private struct <Create>d__16 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public Action<String> onConfirm; //Field offset: 0x28
		public string message; //Field offset: 0x30
		public bool allowEmpty; //Field offset: 0x38
		public Action onClose; //Field offset: 0x40
		public bool allowClose; //Field offset: 0x48
		public bool numberOnly; //Field offset: 0x49
		public int numMin; //Field offset: 0x4C
		public int numMax; //Field offset: 0x50
		public string currentText; //Field offset: 0x58
		public short sortOrder; //Field offset: 0x60
		private TaskAwaiter <>u__1; //Field offset: 0x68
		private ResourceRequest <rr>5__2; //Field offset: 0x70
		private TaskAwaiter<TextBox> <>u__2; //Field offset: 0x78

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Runtime.CompilerServices.TaskAwaiter`1<System.Object>), typeof(<Create>d__16)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TaskAwaiter`1<Object>&), typeof(<Create>d__16&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(SemaphoreSlim), Member = "Release", ReturnType = typeof(int))]
		[Calls(Type = typeof(Canvas), Member = "set_sortingOrder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
		[Calls(Type = typeof(TMP_InputField), Member = "set_text", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(AsyncExtensions), Member = "Instantiate", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Transform), typeof(bool)}, ReturnType = "System.Threading.Tasks.Task`1<T>")]
		[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(AsyncExtensions), Member = "Await", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AsyncOperation)}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(Resources), Member = "LoadAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(ResourceRequest))]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(SemaphoreSlim), Member = "WaitAsync", ReturnType = typeof(Task))]
		[Calls(Type = typeof(Task`1), Member = "GetAwaiter", ReturnType = "System.Runtime.CompilerServices.TaskAwaiter`1<TResult>")]
		[CallsDeduplicatedMethods(Count = 10)]
		[CallsUnknownMethods(Count = 33)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		[DeduplicatedMethod]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private static object TextBoxPrefab; //Field offset: 0x0
	public static TextBox Instance; //Field offset: 0x8
	private static readonly SemaphoreSlim TxtSem; //Field offset: 0x10
	public Button Confirm; //Field offset: 0x98
	public TextMeshProUGUI Message; //Field offset: 0xA0
	public TMP_InputField Input; //Field offset: 0xA8
	public Button Close; //Field offset: 0xB0
	private Action<String> OnConfirm; //Field offset: 0xB8
	private bool AllowEmpty; //Field offset: 0xC0
	private bool AllowClose; //Field offset: 0xC1
	private bool NumberOnly; //Field offset: 0xC2
	private int MinimumValue; //Field offset: 0xC4
	private int MaximumValue; //Field offset: 0xC8
	private Action OnClose; //Field offset: 0xD0

	public static GameObject ObjectInstance
	{
		[CalledBy(Type = typeof(ReplayList), Member = "OnClickClose", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TextBox), Member = "OnClickClose", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TextBox), Member = "OnClickConfirm", ReturnType = typeof(void))]
		[CalledBy(Type = "Scenes.Deck.DeckSelection+<ImportDeck>d__76", Member = "MoveNext", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DeckSelection), Member = "OnClickClose", ReturnType = typeof(void))]
		[CalledBy(Type = "Scenes.Battle.DuelZone+<CloseAllDuelWindows>d__79", Member = "MoveNext", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Helper), Member = "CloseAllScreens", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Hotkey), Member = "TapEnterInput", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 8)]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 198
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SemaphoreSlim), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private static TextBox() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DraggableFrame), Member = ".ctor", ReturnType = typeof(void))]
	public TextBox() { }

	[AsyncStateMachine(typeof(<Create>d__16))]
	[CalledBy(Type = "Manager.Network+<>c__DisplayClass68_0", Member = "<OnReceiveServerReplay>b__0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FieldCenter), Member = "OnLeftPhaseButton", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DuelEnd), Member = "<Start>b__37_0", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DuelEnd), Member = "OnSaveReplay", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DeckSelection), Member = "OnCloneButton", ReturnType = typeof(void))]
	[CalledBy(Type = "Scenes.Deck.DeckSelection+<ImportDeck>d__76", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LifePoints), Member = "OnClickLPBar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Scenes.Deck.DeckSelection+<DeckSync>d__52", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ReplayList), Member = "OnClickExportAll", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ReplayList), Member = "ImportReplay", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ReplayList), Member = "OnClickRename", ReturnType = typeof(void))]
	[CalledBy(Type = "Scenes.Menu.ReplayList+<>c__DisplayClass54_0", Member = "<OnGetDecks>b__2", ReturnType = typeof(void))]
	[CalledBy(Type = "Scenes.Menu.MainMenu+<<OnClickLocal>b__33_1>d", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(HostSettings), Member = "OnCreateRoomButton", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LobbyScreen), Member = "OnTryEnterSeletedRoom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 16)]
	[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<Create>d__16)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<Create>d__16&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "Create", ReturnType = typeof(AsyncVoidMethodBuilder))]
	[CallsUnknownMethods(Count = 5)]
	public static void Create(Action<String> onConfirm, string message, bool allowEmpty = false, string currentText = null, bool allowClose = false, Action onClose = null, bool numberOnly = false, int numMin = -2147483648, int numMax = 2147483647, short sortOrder = -1) { }

	[CalledBy(Type = typeof(ReplayList), Member = "OnClickClose", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextBox), Member = "OnClickClose", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextBox), Member = "OnClickConfirm", ReturnType = typeof(void))]
	[CalledBy(Type = "Scenes.Deck.DeckSelection+<ImportDeck>d__76", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DeckSelection), Member = "OnClickClose", ReturnType = typeof(void))]
	[CalledBy(Type = "Scenes.Battle.DuelZone+<CloseAllDuelWindows>d__79", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Helper), Member = "CloseAllScreens", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Hotkey), Member = "TapEnterInput", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[CallsUnknownMethods(Count = 1)]
	public static GameObject get_ObjectInstance() { }

	[CalledBy(Type = typeof(Hotkey), Member = "TapClose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TextBox), Member = "get_ObjectInstance", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(Helper), Member = "CloseScreen", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[])}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	public void OnClickClose() { }

	[CalledBy(Type = typeof(TextBox), Member = "Update", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Hotkey), Member = "TapEnterInput", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Localization), Member = "GetClientMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(MessageBox), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(int), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Int32&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TextBox), Member = "get_ObjectInstance", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(Helper), Member = "CloseScreen", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[])}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	public void OnClickConfirm() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TMP_InputField), Member = "set_contentType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ContentType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_InputField), Member = "set_characterLimit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UnityEvent), Member = "AddListener", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityAction)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(GameObject), Member = "SetActive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Transform), Member = "SetAsFirstSibling", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	private void Start() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Keyboard), Member = "get_enterKey", ReturnType = typeof(KeyControl))]
	[Calls(Type = typeof(ButtonControl), Member = "get_wasPressedThisFrame", ReturnType = typeof(bool))]
	[Calls(Type = typeof(TextBox), Member = "OnClickConfirm", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private void Update() { }

}

