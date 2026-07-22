namespace Scenes.General;

public class ChatWindow : DraggableFrame
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass64_0
	{
		public long userId; //Field offset: 0x10
		public ChatWindow <>4__this; //Field offset: 0x18
		public string msg; //Field offset: 0x20

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c__DisplayClass64_0() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(LogManager), Member = "GetPlayerColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[])}, ReturnType = typeof(string))]
		[Calls(Type = typeof(ChatWindow), Member = "OnChatMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 8)]
		internal void <OnChatMessage>b__0(string name) { }

	}

	[CompilerGenerated]
	private struct <Create>d__46 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		private TaskAwaiter <>u__1; //Field offset: 0x20
		private ResourceRequest <rr>5__2; //Field offset: 0x28
		private TaskAwaiter<ChatWindow> <>u__2; //Field offset: 0x30

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SemaphoreSlim), Member = "WaitAsync", ReturnType = typeof(Task))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Resources), Member = "LoadAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(ResourceRequest))]
		[Calls(Type = typeof(AsyncExtensions), Member = "Await", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AsyncOperation)}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(AsyncExtensions), Member = "Instantiate", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Transform), typeof(bool)}, ReturnType = "System.Threading.Tasks.Task`1<T>")]
		[Calls(Type = typeof(Task`1), Member = "GetAwaiter", ReturnType = "System.Runtime.CompilerServices.TaskAwaiter`1<TResult>")]
		[Calls(Type = typeof(SemaphoreSlim), Member = "Release", ReturnType = typeof(int))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 9)]
		[CallsUnknownMethods(Count = 21)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <OnClickRoomPwd>d__48 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		private TaskAwaiter<String> <>u__1; //Field offset: 0x28

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(RoomData), Member = "GenPwd", ReturnType = typeof(System.Threading.Tasks.Task`1<System.String>))]
		[Calls(Type = typeof(Task`1), Member = "GetAwaiter", ReturnType = "System.Runtime.CompilerServices.TaskAwaiter`1<TResult>")]
		[Calls(Type = typeof(Helper), Member = "set_Clipboard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 3)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		[DeduplicatedMethod]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	public static WordFilterMode WordFilters; //Field offset: 0x0
	public const string MANUAL_HELP = "<b>[Help]</b>
<b><color=#C70039>/move|rmove|movefd|rmovefd</color> x|-x b|g|d|e|h b|g|d|e|h [b]</b>
<b><color=#C70039>rmove</color></b>=random cards are moved
<b><color=#C70039>movefd</color></b>=face-down cards are moved
x=amount of cards (if x is negative its x from bottom)
b=banish zone, g=graveyard, d=main deck, e=extra deck, h=hand
the first location is from second is to
b=bottom (optional. It puts it at bottom of destination, default is top)

e.g. Move 5 cards from main deck to banish zone face-down:
<b><color=#C70039>/movefd</color> 5 d b</b>
<b><color=#C70039>/send|sendfd</color> m|s b|g|d|e|h x [b]</b> Send cards on field zone X from m=monster zone or s=spell zone to desired location (sendfd sends them face-down) (optional b at end puts them on bottom instead of top of the destination). If x < 0 then it sends from all field slots of given type
<b><color=#C70039>/lp</color> +x|-x</b> will increase or decrease life points by x

<b><color=#C70039>/banish</color> x</b> will banish x cards from top of deck face-up
<b><color=#C70039>/banishfd</color> x</b> will banish x cards from top of deck face-down
<b><color=#C70039>/banishhand</color></b> will banish current hand
<b><color=#C70039>/draw</color> x</b> will draw x cards from top of deck
<b><color=#C70039>/discardhand</color></b> will send your current hand to graveyard
<b><color=#C70039>/revealhand</color></b> will reveal all cards in your hand

<b><color=#C70039>/excavate</color> x</b> will excavate x cards
<b><color=#C70039>/mill</color> x</b> will send x cards from top of deck to graveyard

<b><color=#C70039>/shuffle</color> d|h|e</b> will shuffle the deck, hand or extra. Default is deck
<b><color=#C70039>/reset</color></b> will return all cards in hand, gy, and banish to deck
<b><color=#C70039>/redrawhand</color></b> will send current hand back to deck and redraw 5

<b><color=#C70039>/coin</color> x</b> flips a coin x times
<b><color=#C70039>/dice</color> x</b> throws a dice x times
<b><color=#C70039>/rps</color></b> will start a rock/paper/scissors with opponent
<b><color=#C70039>/rng</color> x y</b> will generate a random number from x to y range

<b><color=#C70039>/reversedeck</color></b> will reverse the sequence of all cards in the main deck"; //Field offset: 0x0
	public static ChatWindow Instance; //Field offset: 0x8
	private static object ChatPrefab; //Field offset: 0x10
	private static readonly SemaphoreSlim ChatMaker; //Field offset: 0x18
	private static readonly Vector2 ChatAnchorMax; //Field offset: 0x20
	private static readonly Vector2 ChatPivot; //Field offset: 0x28
	private static readonly Vector2 CardAnchorMin; //Field offset: 0x30
	private static readonly Vector2 CardAnchorMax; //Field offset: 0x38
	private static readonly Vector2 CardPivot; //Field offset: 0x40
	public static DateTime LastSent; //Field offset: 0x48
	public static bool HiddenThisFrame; //Field offset: 0x50
	private static string _lis; //Field offset: 0x58
	public TMP_InputField InputChat; //Field offset: 0x98
	public TextMeshProUGUI InputChatPlaceholder; //Field offset: 0xA0
	private InputTextHandler InputChatTextHandler; //Field offset: 0xA8
	public TextMeshProUGUI ChatText; //Field offset: 0xB0
	public TextMeshProUGUI SpecCount; //Field offset: 0xB8
	public Image SpecFade; //Field offset: 0xC0
	public Image ChatboxBorder; //Field offset: 0xC8
	public Image ChatFrame; //Field offset: 0xD0
	public Toggle NoneTab; //Field offset: 0xD8
	public Toggle ChatTab; //Field offset: 0xE0
	public Toggle LogTab; //Field offset: 0xE8
	public Toggle CardTab; //Field offset: 0xF0
	public Toggle ConsoleTab; //Field offset: 0xF8
	public Image ChatMark; //Field offset: 0x100
	public Button SendChatButton; //Field offset: 0x108
	public ScrollRect TextArea; //Field offset: 0x110
	public Toggle HideChatbox; //Field offset: 0x118
	public TextMeshProUGUI RoomPasswordLabel; //Field offset: 0x120
	public Button RoomPasswordButton; //Field offset: 0x128
	private StringBuilder LogString; //Field offset: 0x130
	private StringBuilder ChatString; //Field offset: 0x138
	private StringBuilder ConsoleString; //Field offset: 0x140
	private string CardText; //Field offset: 0x148
	private bool ChatFlag; //Field offset: 0x150
	private bool LogFlag; //Field offset: 0x151
	private bool CardFlag; //Field offset: 0x152
	private bool ConsoleFlag; //Field offset: 0x153
	private bool AllFlag; //Field offset: 0x154

	public static bool AllowCard
	{
		[CalledBy(Type = typeof(ChatWindow), Member = "ChangeWindowState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ChatWindow), Member = "OnClickCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ChatWindow), Member = "FixedUpdate", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Hotkey), Member = "TapCardInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(DeckEdit), Member = "get_IsActive", ReturnType = typeof(bool))]
		 get { } //Length: 347
	}

	public static bool AllowChat
	{
		[CalledBy(Type = typeof(Hotkey), Member = "TapEnterInput", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(bool))]
		[CalledBy(Type = "ClientAPI.WebServer+<OnChatMessage>d__22", Member = "MoveNext", ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 83
	}

	public static bool AllowLog
	{
		[CalledBy(Type = typeof(ChatWindow), Member = "ChangeWindowState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 83
	}

	public static bool CanInputChat
	{
		[CalledBy(Type = typeof(ChatWindow), Member = "RetypeInput", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ChatWindow), Member = "SendChat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Hotkey), Member = "Update", ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
		[Calls(Type = typeof(GameObject), Member = "get_activeInHierarchy", ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 122
	}

	public static bool CanUseConsole
	{
		[CalledBy(Type = typeof(ChatWindow), Member = "SendChat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CalledBy(Type = "Manager.Network+<HandlePacket>d__73", Member = "MoveNext", ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 74
	}

	public string DuelLogString
	{
		[CalledBy(Type = "ClientAPI.WebServer+<OnGetDuelLog>d__23", Member = "MoveNext", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 42
	}

	public static bool FilterChat
	{
		[CalledBy(Type = typeof(Network), Member = "OnChatMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(UserRank), typeof(string)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 118
	}

	public static bool FilterName
	{
		[CalledBy(Type = typeof(RoomCard), Member = "PostSetData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(string), typeof(string)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Player), Member = "get_Username", ReturnType = typeof(string))]
		[CallerCount(Count = 2)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 118
	}

	public float FontSize
	{
		[CalledBy(Type = typeof(SettingsMenu), Member = "InitSocial", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(SettingsMenu), Member = "ApplySocial", ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 34
		[CalledBy(Type = typeof(SettingsMenu), Member = "ApplySocial", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(TMP_Text), Member = "set_fontSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		 set { } //Length: 33
	}

	public static bool IsInputingChat
	{
		[CalledBy(Type = typeof(Hotkey), Member = "Update", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 108
	}

	public private static string LastInputSent
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 79
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(string), Member = "IsNullOrWhiteSpace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 1)]
		private set { } //Length: 144
	}

	public static GameObject ObjectInstance
	{
		[CalledBy(Type = "Scenes.Menu.MainMenu+<Start>d__43", Member = "MoveNext", ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 198
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SemaphoreSlim), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private static ChatWindow() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DraggableFrame), Member = ".ctor", ReturnType = typeof(void))]
	public ChatWindow() { }

	[CalledBy(Type = typeof(Hotkey), Member = "TapEnterInput", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TMP_InputField), Member = "ActivateInputField", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void ActivateInputField() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ChatWindow), Member = "get_AllowLog", ReturnType = typeof(bool))]
	[Calls(Type = typeof(ChatWindow), Member = "get_AllowCard", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Toggle), Member = "set_isOn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(PlayerPrefs), Member = "SetInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(GameObject), Member = "SetActive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Behaviour), Member = "set_enabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public void ChangeWindowState(bool val) { }

	[CalledBy(Type = typeof(ChatWindow), Member = "ParseChatCommand", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[])}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(StringBuilder), Member = "Clear", ReturnType = typeof(StringBuilder))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void ClearChat() { }

	[CalledBy(Type = typeof(ChatWindow), Member = "ParseChatCommand", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[])}, ReturnType = typeof(void))]
	[CalledBy(Type = "Scenes.Battle.DuelZone+<ClearAllCards>d__135", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Game.DuelManager+<OnStart>d__110", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(StringBuilder), Member = "Clear", ReturnType = typeof(StringBuilder))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void ClearLog() { }

	[AsyncStateMachine(typeof(<Create>d__46))]
	[CalledBy(Type = "Manager.Helper+<Preload>d__115", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<Create>d__46)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<Create>d__46&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static Task Create() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TMP_InputField), Member = "DeactivateInputField", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(EventSystem), Member = "get_current", ReturnType = typeof(EventSystem))]
	[Calls(Type = typeof(EventSystem), Member = "SetSelectedGameObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void DeactivateInputField() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void DefineChatText(string text) { }

	[CalledBy(Type = typeof(ChatWindow), Member = "OnClickChat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ChatWindow), Member = "OnClickCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ChatWindow), Member = "OnClickConsole", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ChatWindow), Member = "OnClickLog", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(TMP_Text), Member = "get_rectTransform", ReturnType = typeof(RectTransform))]
	[Calls(Type = typeof(RectTransform), Member = "set_anchorMin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RectTransform), Member = "set_anchorMax", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RectTransform), Member = "set_pivot", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(General), Member = "SetLeft", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform), typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(General), Member = "SetRight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform), typeof(float)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void DefineTextPosition() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Trim", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "IsNullOrWhiteSpace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(StringBuilder), Member = "AppendLine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(string), Member = "ToLower", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "StartsWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Packet), Member = "ConsoleCommand", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(BinaryWriter))]
	[Calls(Type = typeof(Network), Member = "Send", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryWriter)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	private void ExecuteConsoleCommand(string cmd) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(RoomData), Member = "get_HasPwd", ReturnType = typeof(bool))]
	[Calls(Type = typeof(GameObject), Member = "SetActive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ChatWindow), Member = "get_AllowCard", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Toggle), Member = "set_isOn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	private void FixedUpdate() { }

	[CalledBy(Type = typeof(ChatWindow), Member = "ChangeWindowState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ChatWindow), Member = "OnClickCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ChatWindow), Member = "FixedUpdate", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Hotkey), Member = "TapCardInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(DeckEdit), Member = "get_IsActive", ReturnType = typeof(bool))]
	public static bool get_AllowCard() { }

	[CalledBy(Type = typeof(Hotkey), Member = "TapEnterInput", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "ClientAPI.WebServer+<OnChatMessage>d__22", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[ContainsUnimplementedInstructions]
	public static bool get_AllowChat() { }

	[CalledBy(Type = typeof(ChatWindow), Member = "ChangeWindowState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[ContainsUnimplementedInstructions]
	public static bool get_AllowLog() { }

	[CalledBy(Type = typeof(ChatWindow), Member = "RetypeInput", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ChatWindow), Member = "SendChat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Hotkey), Member = "Update", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(GameObject), Member = "get_activeInHierarchy", ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	public static bool get_CanInputChat() { }

	[CalledBy(Type = typeof(ChatWindow), Member = "SendChat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Manager.Network+<HandlePacket>d__73", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[ContainsUnimplementedInstructions]
	public static bool get_CanUseConsole() { }

	[CalledBy(Type = "ClientAPI.WebServer+<OnGetDuelLog>d__23", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public string get_DuelLogString() { }

	[CalledBy(Type = typeof(Network), Member = "OnChatMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(UserRank), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[ContainsUnimplementedInstructions]
	public static bool get_FilterChat() { }

	[CalledBy(Type = typeof(RoomCard), Member = "PostSetData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Player), Member = "get_Username", ReturnType = typeof(string))]
	[CallerCount(Count = 2)]
	[ContainsUnimplementedInstructions]
	public static bool get_FilterName() { }

	[CalledBy(Type = typeof(SettingsMenu), Member = "InitSocial", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SettingsMenu), Member = "ApplySocial", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public float get_FontSize() { }

	[CalledBy(Type = typeof(Hotkey), Member = "Update", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static bool get_IsInputingChat() { }

	[CallerCount(Count = 0)]
	public static string get_LastInputSent() { }

	[CalledBy(Type = "Scenes.Menu.MainMenu+<Start>d__43", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[CallsUnknownMethods(Count = 1)]
	public static GameObject get_ObjectInstance() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DateTime), Member = "get_Now", ReturnType = typeof(DateTime))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	public string GetTimeStamp() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(GameObject), Member = "SetActive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void MarkState(bool active) { }

	[CalledBy(Type = typeof(Template), Member = "set_SelectedCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Template)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Template), Member = "BuildPlainEntireCardText", ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void OnCardTextChanged(Template card) { }

	[CalledBy(Type = typeof(<>c__DisplayClass64_0), Member = "<OnChatMessage>b__0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ChatWindow), Member = "ParseChatCommand", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[])}, ReturnType = typeof(void))]
	[CalledBy(Type = "ClientAPI.WebServer+<OnChatMessage>d__22", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(StringBuilder), Member = "AppendLine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(string), Member = "Replace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CardLocalization), Member = "get_HighlightedName", ReturnType = typeof(string))]
	[Calls(Type = typeof(Localization), Member = "GetGameMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(int), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Int32&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(GameObject), Member = "SetActive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(string), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(string), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Manager), Member = "GetCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(Card))]
	[Calls(Type = typeof(Sound), Member = "PlaySound", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SoundTypes), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	public void OnChatMessage(string msg) { }

	[CalledBy(Type = typeof(Network), Member = "OnChatMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(UserRank), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DiscordController), Member = "GetPlayerName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(System.Action`1<System.String>)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public void OnChatMessage(long userId, string msg) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ChatWindow), Member = "get_AllowCard", ReturnType = typeof(bool))]
	[Calls(Type = typeof(TMP_InputField), Member = "set_text", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(GameObject), Member = "SetActive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_Text), Member = "set_alignment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextAlignmentOptions)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ChatWindow), Member = "DefineTextPosition", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void OnClickCard(bool cb = true) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Localization), Member = "GetLocale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(GameObject), Member = "SetActive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_Text), Member = "set_alignment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextAlignmentOptions)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ChatWindow), Member = "DefineTextPosition", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	public void OnClickChat(bool cb = true) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Localization), Member = "GetLocale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(GameObject), Member = "SetActive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_Text), Member = "set_alignment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextAlignmentOptions)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ChatWindow), Member = "DefineTextPosition", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	public void OnClickConsole(bool cb = true) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TMP_InputField), Member = "set_text", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(GameObject), Member = "SetActive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_Text), Member = "set_alignment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextAlignmentOptions)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ChatWindow), Member = "DefineTextPosition", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public void OnClickLog(bool cb = true) { }

	[AsyncStateMachine(typeof(<OnClickRoomPwd>d__48))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "Create", ReturnType = typeof(AsyncVoidMethodBuilder))]
	[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OnClickRoomPwd>d__48)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OnClickRoomPwd>d__48&)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private void OnClickRoomPwd() { }

	[CalledBy(Type = "Manager.Network+<HandlePacket>d__73", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(StringBuilder), Member = "AppendLine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(StringBuilder))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public void OnConsoleMessage(string msg) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Helper), Member = "set_Pointer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Graphic), Member = "get_rectTransform", ReturnType = typeof(RectTransform))]
	[Calls(Type = typeof(RectTransform), Member = "get_sizeDelta", ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(Screen), Member = "get_width", ReturnType = typeof(int))]
	[Calls(Type = typeof(Screen), Member = "get_height", ReturnType = typeof(int))]
	[Calls(Type = typeof(RectTransform), Member = "set_sizeDelta", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void OnDragBorder(PointerEventData data) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Helper), Member = "set_Pointer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ChatWindow), Member = "StoreSize", ReturnType = typeof(void))]
	public void OnEndDragBorder(PointerEventData data) { }

	[CallerCount(Count = 28)]
	[Calls(Type = typeof(LogManager), Member = "PrependPlayerInMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(sbyte), typeof(String&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Manager), Member = "GetCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(Card))]
	[Calls(Type = typeof(ChatWindow), Member = "ParseCardInMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Card), typeof(String&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StringBuilder), Member = "AppendLine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(StringBuilder))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public void OnLogMessage(string msg, byte player, Int32[] cardIds) { }

	[CallerCount(Count = 22)]
	[Calls(Type = typeof(LogManager), Member = "PrependPlayerInMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(sbyte), typeof(String&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DuelZone), Member = "get_IsDueling", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Template), Member = "set_SelectedCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Template)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ClientCard), Member = "get_Data", ReturnType = typeof(Card))]
	[Calls(Type = typeof(ChatWindow), Member = "ParseCardInMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Card), typeof(String&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StringBuilder), Member = "AppendLine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(StringBuilder))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	public void OnLogMessage(string msg, short player = -1, ClientCard[] cards) { }

	[CalledBy(Type = typeof(LogManager), Member = "OnJankenResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte), typeof(byte)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(LogManager), Member = "PrependPlayerInMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(sbyte), typeof(String&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Manager), Member = "GetCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(Card))]
	[Calls(Type = typeof(ChatWindow), Member = "ParseCardInMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Card), typeof(String&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StringBuilder), Member = "AppendLine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(StringBuilder))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public void OnLogMessage(string msg, sbyte player = -1, Int32[] cardIds) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ChatWindow), Member = "SendChat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void OnSendButton() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TMP_TextUtilities), Member = "FindIntersectingLink", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TMP_Text), typeof(Vector3), typeof(Camera)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(TMP_Text), Member = "get_textInfo", ReturnType = typeof(TMP_TextInfo))]
	[Calls(Type = typeof(TMP_LinkInfo), Member = "GetLinkID", ReturnType = typeof(string))]
	[Calls(Type = typeof(int), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Int32&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DisplayCard), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(ClientCard)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	public void OnTapping(PointerEventData pointerData) { }

	[CalledBy(Type = typeof(ChatWindow), Member = "OnLogMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(byte), typeof(Int32[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ChatWindow), Member = "OnLogMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(sbyte), typeof(Int32[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ChatWindow), Member = "OnLogMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(short), typeof(ClientCard[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LogManager), Member = "GetChainingEventString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ClientCard), typeof(int)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(LogManager), Member = "OnChaining", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte), typeof(ClientCard), typeof(int), typeof(byte), typeof(byte)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Localization), Member = "GetGameDescription", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(String[])}, ReturnType = typeof(string))]
	[CalledBy(Type = "Game.DuelManager+<OnChainSolved>d__104", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Game.DuelManager+<OnChainSolving>d__102", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Game.DuelManager+<OnChained>d__103", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 12)]
	[Calls(Type = typeof(CardLocalization), Member = "get_HighlightedName", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(General), Member = "ReplaceFirst", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Localization), Member = "GetGameMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public static void ParseCardInMessage(Card c, ref string msg) { }

	[CalledBy(Type = typeof(ChatWindow), Member = "ParseChatCommand", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ChatWindow), Member = "SendChat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CardOptionList), Member = "OnReposition", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DuelZone), Member = "OnManualReset", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DuelZone), Member = "OnClickRedrawHand", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DuelZone), Member = "OnClickManualShuffleHand", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ClientCard), Member = "ManualMoveCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte), typeof(CardLocation), typeof(byte), typeof(CardPosition)}, ReturnType = typeof(void))]
	[CallerCount(Count = 20)]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(Duel), Member = "GetLocalPlayer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte)}, ReturnType = typeof(byte))]
	[Calls(Type = typeof(FieldSlot), Member = "get_AmountOfCards", ReturnType = typeof(byte))]
	[Calls(Type = typeof(Convert), Member = "ToByte", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(byte))]
	[Calls(Type = typeof(byte), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Byte&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(sbyte), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(SByte&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Packet), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameMessage)}, ReturnType = typeof(BinaryWriter))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(RoomData), Member = "get_StartHand", ReturnType = typeof(byte))]
	[Calls(Type = typeof(string), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ClientCard), Member = "IsExtraCard", ReturnType = typeof(bool))]
	[Calls(Type = typeof(ChatWindow), Member = "ParseChatCommand", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(byte), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ChatWindow), Member = "SendChatMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ChatWindow), Member = "OnChatMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Network), Member = "Send", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryWriter)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(sbyte), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "StartsWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DuelEnd), Member = "EndReasonAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DuelEndReason)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ChatWindow), Member = "ClearChat", ReturnType = typeof(void))]
	[Calls(Type = typeof(ChatWindow), Member = "ClearLog", ReturnType = typeof(void))]
	[Calls(Type = typeof(Helper), Member = "OpenURL", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Manager), Member = "ReloadCustomScripts", ReturnType = typeof(void))]
	[Calls(Type = typeof(DuelZone), Member = "get_IsDueling", ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "ToLower", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "StartsWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(RoomData), Member = "get_IsManual", ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Manager), Member = "GetCardByKoID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Card))]
	[Calls(Type = typeof(CardAnimationPlayer), Member = "Animate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(float), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Single&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(bool), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Boolean&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ArtDisplay), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(float), typeof(bool), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Math), Member = "Min", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(int), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Int32&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(General), Member = "GetUniqueRandomArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(Int32[]))]
	[CallsDeduplicatedMethods(Count = 112)]
	[CallsUnknownMethods(Count = 103)]
	[ContainsInvalidInstructions]
	public void ParseChatCommand(string cmd, String[] args) { }

	[CalledBy(Type = typeof(Hotkey), Member = "Update", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ChatWindow), Member = "get_CanInputChat", ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "IsNullOrWhiteSpace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TMP_InputField), Member = "set_text", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public void RetypeInput() { }

	[CalledBy(Type = typeof(ChatWindow), Member = "OnSendButton", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Packet), Member = "ConsoleCommand", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(BinaryWriter))]
	[Calls(Type = typeof(EventSystem), Member = "SetSelectedGameObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(EventSystem), Member = "get_current", ReturnType = typeof(EventSystem))]
	[Calls(Type = typeof(TMP_InputField), Member = "DeactivateInputField", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Toggle), Member = "set_isOn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ChatWindow), Member = "ParseChatCommand", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Split", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(StringSplitOptions)}, ReturnType = typeof(String[]))]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(TMP_InputField), Member = "ActivateInputField", ReturnType = typeof(void))]
	[Calls(Type = typeof(ChatWindow), Member = "SendChatMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Network), Member = "Send", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryWriter)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "StartsWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "ToLower", ReturnType = typeof(string))]
	[Calls(Type = typeof(StringBuilder), Member = "AppendLine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(string), Member = "Trim", ReturnType = typeof(string))]
	[Calls(Type = typeof(ChatWindow), Member = "get_CanUseConsole", ReturnType = typeof(bool))]
	[Calls(Type = typeof(TMP_InputField), Member = "set_text", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TimeSpan), Member = "get_TotalMilliseconds", ReturnType = typeof(double))]
	[Calls(Type = typeof(DateTime), Member = "op_Subtraction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(DateTime)}, ReturnType = typeof(TimeSpan))]
	[Calls(Type = typeof(DateTime), Member = "get_UtcNow", ReturnType = typeof(DateTime))]
	[Calls(Type = typeof(string), Member = "IsNullOrWhiteSpace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ChatWindow), Member = "get_CanInputChat", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Localization), Member = "GetLocale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(MessageBox), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(float)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	[ContainsUnimplementedInstructions]
	public void SendChat(string input) { }

	[CalledBy(Type = typeof(ChatWindow), Member = "ParseChatCommand", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ChatWindow), Member = "SendChat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DiscordController), Member = "get_MuteChat", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Network), Member = "SendChat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Localization), Member = "GetLocale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(MessageBox), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(float)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void SendChatMessage(string msg) { }

	[CalledBy(Type = typeof(SettingsMenu), Member = "ApplySocial", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TMP_Text), Member = "set_fontSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void set_FontSize(float value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "IsNullOrWhiteSpace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	private static void set_LastInputSent(string value) { }

	[CalledBy(Type = typeof(DuelZone), Member = "SetUpOptimizedView", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Graphic), Member = "get_rectTransform", ReturnType = typeof(RectTransform))]
	[Calls(Type = typeof(RectTransform), Member = "set_sizeDelta", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ChatWindow), Member = "StoreSize", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void SetAndStoreSize(Vector2 size) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(General), Member = "GetComponentInChildrenOnly", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Component), typeof(bool)}, ReturnType = "T")]
	[Calls(Type = typeof(RectTransform), Member = "set_sizeDelta", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(PlayerPrefs), Member = "GetFloat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(float)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(Graphic), Member = "get_rectTransform", ReturnType = typeof(RectTransform))]
	[Calls(Type = typeof(General), Member = "AddTooltip", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MonoBehaviour), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Localization), Member = "GetLocale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(PlayerPrefs), Member = "GetInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Component), Member = "GetComponentInChildren", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(General), Member = "AddTrigger", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MonoBehaviour), typeof(EventTriggerType), typeof(System.Action`1<UnityEngine.EventSystems.PointerEventData>)}, ReturnType = typeof(EventTrigger))]
	[Calls(Type = typeof(UnityEvent`1), Member = "AddListener", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Events.UnityAction`1<T0>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(UnityEvent), Member = "AddListener", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityAction)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Toggle), Member = "set_isOn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 14)]
	[CallsUnknownMethods(Count = 12)]
	[ContainsUnimplementedInstructions]
	private void Start() { }

	[CalledBy(Type = typeof(ChatWindow), Member = "OnEndDragBorder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ChatWindow), Member = "SetAndStoreSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Graphic), Member = "get_rectTransform", ReturnType = typeof(RectTransform))]
	[Calls(Type = typeof(RectTransform), Member = "get_sizeDelta", ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(PlayerPrefs), Member = "SetFloat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(float)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void StoreSize() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Component), Member = "GetComponentInChildren", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(General), Member = "GetComponentInChildrenOnly", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Component), typeof(bool)}, ReturnType = "T")]
	[Calls(Type = typeof(Localization), Member = "GetLocale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(General), Member = "AddTooltip", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MonoBehaviour), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 6)]
	public void UpdateLanguage() { }

}

