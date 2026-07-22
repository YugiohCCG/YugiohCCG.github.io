namespace Scenes.Menu;

public class SettingsMenu : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Action<Boolean> <>9__121_0; //Field offset: 0x8
		public static Action<Boolean> <>9__122_0; //Field offset: 0x10
		public static Action <>9__123_0; //Field offset: 0x18
		public static Action<Boolean> <>9__125_0; //Field offset: 0x20
		public static UnityAction <>9__126_0; //Field offset: 0x28

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		private static <>c() { }

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(GeneralSelection), Member = "GetSelectionIndex", ReturnType = typeof(int))]
		[Calls(Type = typeof(Hotkey), Member = "SaveCustomHKSet", ReturnType = typeof(void))]
		[Calls(Type = typeof(Hotkey), Member = "set_DefaultKeySet", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HotkeyDefaults)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(GeneralSelection), Member = "get_ObjectInstance", ReturnType = typeof(GameObject))]
		[Calls(Type = typeof(Helper), Member = "CloseScreen", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[])}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 6)]
		internal void <OnCustomHKSetup>b__123_0() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(PlayerPrefs), Member = "DeleteKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(PlayerPrefs), Member = "Save", ReturnType = typeof(void))]
		internal void <OnDeauth>b__125_0(bool r) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Hotkey), Member = "set_DefaultKeySet", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HotkeyDefaults)}, ReturnType = typeof(void))]
		internal void <OnHoldHKSetup>b__122_0(bool r) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Hotkey), Member = "set_DefaultKeySet", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HotkeyDefaults)}, ReturnType = typeof(void))]
		internal void <OnToggleHKSetup>b__121_0(bool r) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Helper), Member = "OpenURL", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(void))]
		internal void <Start>b__126_0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass118_0
	{
		public SettingsMenu <>4__this; //Field offset: 0x10
		public string desc; //Field offset: 0x18

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c__DisplayClass118_0() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SettingsMenu), Member = "UpdateDesc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		internal void <DefineDesc>b__0(PointerEventData p) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass127_0
	{
		public Transform sec; //Field offset: 0x10
		public SettingsMenu <>4__this; //Field offset: 0x18

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c__DisplayClass127_0() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(GameObject), Member = "get_transform", ReturnType = typeof(Transform))]
		[Calls(Type = typeof(Transform), Member = "get_childCount", ReturnType = typeof(int))]
		[Calls(Type = typeof(Transform), Member = "GetChild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Transform))]
		[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
		[Calls(Type = typeof(GameObject), Member = "SetActive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(SettingsMenu), Member = "UpdateDesc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		internal void <SetupTabs>b__0(bool v) { }

	}

	[CompilerGenerated]
	private struct <ApplyGraphics>d__131 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public SettingsMenu <>4__this; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Helper), Member = "DefineResolution", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(DuelZone), Member = "set_FieldSpellBG", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FieldBGMode)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(DuelField), Member = "SetCurrentField", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderedField)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CustomTheme), Member = "DefineTheme", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(Background), Member = "SetRenderer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BackgroundType), typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Helper), Member = "SetFPS", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(SettingsMenu), Member = "ApplyQuality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(int), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Int32&)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Helper), Member = "ToggleBatterySaving", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(General), Member = "ToText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Resolution)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(Screen), Member = "get_currentResolution", ReturnType = typeof(Resolution))]
		[Calls(Type = typeof(int), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(string), Member = "Split", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(StringSplitOptions)}, ReturnType = typeof(String[]))]
		[Calls(Type = typeof(string), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(SettingsMenu), Member = "get_CurrentResolution", ReturnType = typeof(string))]
		[Calls(Type = typeof(TMP_Dropdown), Member = "get_options", ReturnType = typeof(System.Collections.Generic.List`1<TMPro.TMP_Dropdown+OptionData>))]
		[Calls(Type = typeof(Application), Member = "get_isMobilePlatform", ReturnType = typeof(bool))]
		[Calls(Type = typeof(FPSData), Member = "DefineDisplay", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FPSMode)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(PlayerPrefs), Member = "SetInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 5)]
		[CallsUnknownMethods(Count = 31)]
		[ContainsUnimplementedInstructions]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ApplyOthers>d__139 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public SettingsMenu <>4__this; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Localization), Member = "ChangeLocale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Locale)}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(Localization), Member = "ChangeCardLocale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Locale)}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(Task), Member = "WhenAll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task[])}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(PlayerPrefs), Member = "SetInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(PlayerPrefs), Member = "SetString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Updater), Member = "set_UpdateServer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(WebServer), Member = "set_EnableClientAPI", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(WebServer), Member = "get_EnableClientAPI", ReturnType = typeof(bool))]
		[Calls(Type = typeof(Tooltip), Member = "set_EnableTooltips", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 29)]
		[ContainsUnimplementedInstructions]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <Create>d__113 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public Action onConfirm; //Field offset: 0x28
		private ResourceRequest <rr>5__2; //Field offset: 0x30
		private TaskAwaiter <>u__1; //Field offset: 0x38
		private TaskAwaiter<SettingsMenu> <>u__2; //Field offset: 0x40

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Resources), Member = "LoadAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(ResourceRequest))]
		[Calls(Type = typeof(AsyncExtensions), Member = "Await", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AsyncOperation)}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(AsyncExtensions), Member = "Instantiate", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Transform), typeof(bool)}, ReturnType = "System.Threading.Tasks.Task`1<T>")]
		[Calls(Type = typeof(Task`1), Member = "GetAwaiter", ReturnType = "System.Runtime.CompilerServices.TaskAwaiter`1<TResult>")]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 6)]
		[CallsUnknownMethods(Count = 11)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		[DeduplicatedMethod]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <OnClickConfirm>d__147 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public SettingsMenu <>4__this; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(MessageBox), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(float)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Localization), Member = "GetClientMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(PlayerPrefs), Member = "Save", ReturnType = typeof(void))]
		[Calls(Type = typeof(Task), Member = "WhenAll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task[])}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(SettingsMenu), Member = "ApplyGraphics", ReturnType = typeof(Task))]
		[Calls(Type = typeof(SettingsMenu), Member = "ApplyKeybinding", ReturnType = typeof(void))]
		[Calls(Type = typeof(SettingsMenu), Member = "ApplySocial", ReturnType = typeof(void))]
		[Calls(Type = typeof(SettingsMenu), Member = "ApplyCard", ReturnType = typeof(void))]
		[Calls(Type = typeof(SettingsMenu), Member = "ApplySound", ReturnType = typeof(void))]
		[Calls(Type = typeof(SettingsMenu), Member = "ApplyGameplay", ReturnType = typeof(void))]
		[Calls(Type = typeof(SettingsMenu), Member = "ApplyOthers", ReturnType = typeof(Task))]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 14)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		[DeduplicatedMethod]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private static object SettingsMenuPrefab; //Field offset: 0x0
	private const float VOLUME_SLIDER_MULT = 1; //Field offset: 0x0
	public static SettingsMenu Instance; //Field offset: 0x8
	[Header("Global")]
	public TextMeshProUGUI Title; //Field offset: 0x20
	public Button Confirm; //Field offset: 0x28
	public Button Cancel; //Field offset: 0x30
	public Button DataFolder; //Field offset: 0x38
	public Button Reset; //Field offset: 0x40
	public Button Deauthorize; //Field offset: 0x48
	[Header("Description")]
	public TextMeshProUGUI DescText; //Field offset: 0x50
	[Header("Tabs")]
	public ToggleGroup TabsHolder; //Field offset: 0x58
	public Toggle GameplayTab; //Field offset: 0x60
	public Toggle GraphicsTab; //Field offset: 0x68
	public Toggle SoundTab; //Field offset: 0x70
	public Toggle CardTab; //Field offset: 0x78
	public Toggle SocialTab; //Field offset: 0x80
	public Toggle OthersTab; //Field offset: 0x88
	public Toggle KeybindingTab; //Field offset: 0x90
	[Header("Sections")]
	public GameObject SectionsHolder; //Field offset: 0x98
	public GameObject GameplaySection; //Field offset: 0xA0
	public GameObject GraphicSection; //Field offset: 0xA8
	public GameObject SoundSection; //Field offset: 0xB0
	public GameObject CardSection; //Field offset: 0xB8
	public GameObject SocialSection; //Field offset: 0xC0
	public GameObject OtherSection; //Field offset: 0xC8
	public GameObject KeybindingSection; //Field offset: 0xD0
	[Header("Stripes")]
	public Image ResolutionStripe; //Field offset: 0xD8
	[Header("Gameplay")]
	public Toggle RandomDelay; //Field offset: 0xE0
	public Slider GameSpeed; //Field offset: 0xE8
	public Toggle AlwaysShowCardList; //Field offset: 0xF0
	public Toggle AutoJanken; //Field offset: 0xF8
	public Toggle AutoFlip; //Field offset: 0x100
	public Toggle AutoZone; //Field offset: 0x108
	public Toggle InvertPrompts; //Field offset: 0x110
	public Toggle AlwaysPrompt; //Field offset: 0x118
	public Toggle ShowOptionListOnHover; //Field offset: 0x120
	public TMP_InputField TimeScaling; //Field offset: 0x128
	public TextMeshProUGUI TimeScalingLabel; //Field offset: 0x130
	[Header("Graphics")]
	public TMP_Dropdown BackgroundOption; //Field offset: 0x138
	public TMP_InputField FrameRateTarget; //Field offset: 0x140
	public TextMeshProUGUI FrameRateTargetLabel; //Field offset: 0x148
	public TMP_Dropdown MSAASelect; //Field offset: 0x150
	public Toggle SwitchGFX; //Field offset: 0x158
	public TMP_Dropdown ScreenResolution; //Field offset: 0x160
	public Toggle BatterySaving; //Field offset: 0x168
	public TMP_Dropdown Themes; //Field offset: 0x170
	public TMP_Dropdown RenderField; //Field offset: 0x178
	public TMP_Dropdown FieldSpellBG; //Field offset: 0x180
	public TMP_Dropdown DisplayFPS; //Field offset: 0x188
	[Header("Sound")]
	public Slider BGM; //Field offset: 0x190
	public Slider SFX; //Field offset: 0x198
	public TMP_Dropdown SoundDisabled; //Field offset: 0x1A0
	public Toggle LoopTracks; //Field offset: 0x1A8
	public TMP_Dropdown TrackMix; //Field offset: 0x1B0
	[Header("Card")]
	public Slider HologramScale; //Field offset: 0x1B8
	public TMP_Dropdown CardLayout; //Field offset: 0x1C0
	public TMP_Dropdown ReadableCardLayout; //Field offset: 0x1C8
	public TMP_InputField FontSize; //Field offset: 0x1D0
	public TextMeshProUGUI FontSizeLabel; //Field offset: 0x1D8
	public TMP_Dropdown Popup; //Field offset: 0x1E0
	public Toggle FieldStatus; //Field offset: 0x1E8
	public Toggle EnableCardAnimis; //Field offset: 0x1F0
	public Toggle LevelInHand; //Field offset: 0x1F8
	public Toggle DynamicDisplayCard; //Field offset: 0x200
	public Toggle RefreshCardOnHover; //Field offset: 0x208
	[Header("Social")]
	public TMP_Dropdown JoinRequest; //Field offset: 0x210
	public TMP_Dropdown JoinInvite; //Field offset: 0x218
	public TMP_Dropdown MuteOptions; //Field offset: 0x220
	public TMP_Dropdown SafeOptions; //Field offset: 0x228
	public TMP_Dropdown WordFilter; //Field offset: 0x230
	public TMP_InputField ChatFontSize; //Field offset: 0x238
	public TextMeshProUGUI ChatFontSizeLabel; //Field offset: 0x240
	public Toggle AutoSaveReplay; //Field offset: 0x248
	public Toggle NoPopupNotifications; //Field offset: 0x250
	[Header("Other")]
	public TextMeshProUGUI UpdateServerLabel; //Field offset: 0x258
	public TextMeshProUGUI GameServerLabel; //Field offset: 0x260
	public TMP_InputField GameServer; //Field offset: 0x268
	public TMP_InputField UpdateServer; //Field offset: 0x270
	public TMP_Dropdown Language; //Field offset: 0x278
	public TMP_Dropdown CardLanguage; //Field offset: 0x280
	public Toggle ReplaySharing; //Field offset: 0x288
	public Toggle ClientWebAPI; //Field offset: 0x290
	public Toggle Tooltips; //Field offset: 0x298
	public Toggle HidePrices; //Field offset: 0x2A0
	public Toggle SearchOnType; //Field offset: 0x2A8
	public Toggle DisableDeckEditorValidations; //Field offset: 0x2B0
	public Toggle SaveDeckEditorFilters; //Field offset: 0x2B8
	[Header("Keybinding")]
	public Transform KeybindingOptions; //Field offset: 0x2C0
	public Toggle DisableKeybinding; //Field offset: 0x2C8
	public TMP_Dropdown ChainSetting; //Field offset: 0x2D0
	public TMP_Dropdown DefaultChain; //Field offset: 0x2D8
	public HotkeyInput NoChain; //Field offset: 0x2E0
	public HotkeyInput LegalChain; //Field offset: 0x2E8
	public HotkeyInput AllChain; //Field offset: 0x2F0
	public HotkeyInput ZoomCard; //Field offset: 0x2F8
	public HotkeyInput YesPrompt; //Field offset: 0x300
	public HotkeyInput NoPrompt; //Field offset: 0x308
	public HotkeyInput DisplayCard; //Field offset: 0x310
	public HotkeyInput FinishCancel; //Field offset: 0x318
	public HotkeyInput SurrenderClose; //Field offset: 0x320
	public HotkeyInput EnterInput; //Field offset: 0x328
	public HotkeyInput GraveyardInput; //Field offset: 0x330
	public HotkeyInput BanishedInput; //Field offset: 0x338
	public HotkeyInput ExtraDeckInput; //Field offset: 0x340
	public HotkeyInput LogInput; //Field offset: 0x348
	public HotkeyInput CardTabInput; //Field offset: 0x350
	public HotkeyInput LockCardInput; //Field offset: 0x358
	[Header("Hotkey Setups")]
	public TextMeshProUGUI HKSetuplabel; //Field offset: 0x360
	public Button ToggleHKSetup; //Field offset: 0x368
	public Button HoldHKSetup; //Field offset: 0x370
	public Button CustomHKSetup; //Field offset: 0x378
	private Action OnConfirm; //Field offset: 0x380
	private Dictionary<Hotkeys, HotkeyInput> INPUT_KEYS; //Field offset: 0x388

	private static string CurrentResolution
	{
		[CalledBy(Type = typeof(<ApplyGraphics>d__131), Member = "MoveNext", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Screen), Member = "get_width", ReturnType = typeof(int))]
		[Calls(Type = typeof(Screen), Member = "get_height", ReturnType = typeof(int))]
		[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
		private get { } //Length: 120
	}

	public static GameObject ObjectInstance
	{
		[CalledBy(Type = "Scenes.Battle.DuelEnd+<EndReasonAnimation>d__33", Member = "MoveNext", ReturnType = typeof(void))]
		[CalledBy(Type = "Scenes.Battle.DuelZone+<CloseAllDuelWindows>d__79", Member = "MoveNext", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DiscordController), Member = "OnActivitySpectate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Helper), Member = "CloseAllScreens", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Hotkey), Member = "TapEscape", ReturnType = typeof(void))]
		[CalledBy(Type = "Manager.Network+<EndConnection>d__39", Member = "MoveNext", ReturnType = typeof(void))]
		[CallerCount(Count = 6)]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 150
	}

	[CallerCount(Count = 36)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public SettingsMenu() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Localization), Member = "GetLocale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Localization), Member = "GetClientMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(OptionBox), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<System.Boolean>), typeof(string), typeof(Template)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	private void <InitSocial>b__140_0(int value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TMP_Dropdown), Member = "SetValueWithoutNotify", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	private void <InitSocial>b__140_1(bool r) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SettingsMenu), Member = "InitCard", ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "Create", ReturnType = typeof(AsyncVoidMethodBuilder))]
	[Calls(Type = typeof(Hotkey), Member = "set_DefaultKeySet", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HotkeyDefaults)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SettingsMenu), Member = "InitKeybinding", ReturnType = typeof(void))]
	[Calls(Type = typeof(SettingsMenu), Member = "InitSocial", ReturnType = typeof(void))]
	[Calls(Type = typeof(SettingsMenu), Member = "InitOthers", ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OnClickConfirm>d__147)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OnClickConfirm>d__147&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SettingsMenu), Member = "InitSound", ReturnType = typeof(void))]
	[Calls(Type = typeof(SettingsMenu), Member = "InitGameplay", ReturnType = typeof(void))]
	[Calls(Type = typeof(Template), Member = "ResetLayouts", ReturnType = typeof(void))]
	[Calls(Type = typeof(Helper), Member = "LoadPrefs", ReturnType = typeof(void))]
	[Calls(Type = typeof(PlayerPrefs), Member = "Save", ReturnType = typeof(void))]
	[Calls(Type = typeof(PlayerPrefs), Member = "DeleteAll", ReturnType = typeof(void))]
	[Calls(Type = typeof(SettingsMenu), Member = "InitGraphics", ReturnType = typeof(void))]
	[Calls(Type = typeof(SettingsMenu), Member = "UpdateLanguage", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	[CompilerGenerated]
	private void <OnResetButton>b__148_0(bool b) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Sound), Member = "SetVolume", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SoundTypes), typeof(float)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	private void <Start>b__126_1(float f) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Sound), Member = "SetVolume", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SoundTypes), typeof(float)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	private void <Start>b__126_2(float f) { }

	[CalledBy(Type = typeof(<OnClickConfirm>d__147), Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Hologram), Member = "DefineScale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(float), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Single&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(PlayerPrefs), Member = "SetFloat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(float), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(TMP_InputField), Member = "set_text", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Template), Member = "DefineLayouts", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CardLayout), typeof(CardLayout)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(PlayerPrefs), Member = "SetInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ClientCard), Member = "set_ShowLevelInHand", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public void ApplyCard() { }

	[CalledBy(Type = typeof(<OnClickConfirm>d__147), Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DuelManager), Member = "set_GameSpeed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(PlayerPrefs), Member = "SetFloat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(PlayerPrefs), Member = "SetInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(int), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Int32&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Helper), Member = "SetTimeScale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Time), Member = "get_timeScale", ReturnType = typeof(float))]
	[Calls(Type = typeof(float), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(TMP_InputField), Member = "set_text", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public void ApplyGameplay() { }

	[AsyncStateMachine(typeof(<ApplyGraphics>d__131))]
	[CalledBy(Type = typeof(<OnClickConfirm>d__147), Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<ApplyGraphics>d__131)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<ApplyGraphics>d__131&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public Task ApplyGraphics() { }

	[CalledBy(Type = typeof(<OnClickConfirm>d__147), Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PlayerPrefs), Member = "SetInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Hotkey), Member = "set_ChainOption", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ChainSetting)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public void ApplyKeybinding() { }

	[AsyncStateMachine(typeof(<ApplyOthers>d__139))]
	[CalledBy(Type = typeof(<OnClickConfirm>d__147), Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<ApplyOthers>d__139)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<ApplyOthers>d__139&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public Task ApplyOthers() { }

	[CalledBy(Type = typeof(<ApplyGraphics>d__131), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Helper), Member = "LoadPrefs", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(QualitySettings), Member = "SetQualityLevel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(PlayerPrefs), Member = "SetInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(void))]
	public static void ApplyQuality(int quality) { }

	[CalledBy(Type = typeof(<OnClickConfirm>d__147), Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(float), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Single&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ChatWindow), Member = "set_FontSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(PlayerPrefs), Member = "SetFloat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ChatWindow), Member = "get_FontSize", ReturnType = typeof(float))]
	[Calls(Type = typeof(float), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(TMP_InputField), Member = "set_text", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(PlayerPrefs), Member = "SetInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Player), Member = "set_SafeOpt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SafeOptions)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public void ApplySocial() { }

	[CalledBy(Type = typeof(<OnClickConfirm>d__147), Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Sound), Member = "set_SoundDisabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(PlayerPrefs), Member = "SetInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public void ApplySound() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32Enum, System.Object>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Int32Enum", typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	private void Awake() { }

	[AsyncStateMachine(typeof(<Create>d__113))]
	[CalledBy(Type = typeof(MainMenu), Member = "OnClickSettings", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ReplayList), Member = "OnClickSettings", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GameRoom), Member = "OnClickSettings", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LobbyScreen), Member = "OnSettings", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DeckEdit), Member = "OnSettingsButton", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DeckSelection), Member = "OnClickSettings", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DuelZone), Member = "OnClickSettings", ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "Create", ReturnType = typeof(AsyncVoidMethodBuilder))]
	[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<Create>d__113)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<Create>d__113&)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	public static void Create(Action onConfirm = null) { }

	[CalledBy(Type = typeof(SettingsMenu), Member = "DefineDescs", ReturnType = typeof(void))]
	[CallerCount(Count = 76)]
	[Calls(Type = typeof(General), Member = "AddTrigger", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MonoBehaviour), typeof(EventTriggerType), typeof(System.Action`1<UnityEngine.EventSystems.PointerEventData>)}, ReturnType = typeof(EventTrigger))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private void DefineDesc(MonoBehaviour obj, string desc) { }

	[CalledBy(Type = typeof(SettingsMenu), Member = "UpdateLanguage", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Localization), Member = "GetLocale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(SettingsMenu), Member = "DefineDesc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MonoBehaviour), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[])}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 89)]
	private void DefineDescs() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Localization), Member = "GetLocale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(General), Member = "AddTooltip", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MonoBehaviour), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	private void DefineTooltips() { }

	[CalledBy(Type = typeof(<ApplyGraphics>d__131), Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Screen), Member = "get_width", ReturnType = typeof(int))]
	[Calls(Type = typeof(Screen), Member = "get_height", ReturnType = typeof(int))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	private static string get_CurrentResolution() { }

	[CalledBy(Type = "Scenes.Battle.DuelEnd+<EndReasonAnimation>d__33", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Scenes.Battle.DuelZone+<CloseAllDuelWindows>d__79", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DiscordController), Member = "OnActivitySpectate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Helper), Member = "CloseAllScreens", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Hotkey), Member = "TapEscape", ReturnType = typeof(void))]
	[CalledBy(Type = "Manager.Network+<EndConnection>d__39", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[CallsUnknownMethods(Count = 1)]
	public static GameObject get_ObjectInstance() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SettingsMenu), Member = "InitGameplay", ReturnType = typeof(void))]
	[Calls(Type = typeof(SettingsMenu), Member = "InitGraphics", ReturnType = typeof(void))]
	[Calls(Type = typeof(SettingsMenu), Member = "InitSound", ReturnType = typeof(void))]
	[Calls(Type = typeof(SettingsMenu), Member = "InitCard", ReturnType = typeof(void))]
	[Calls(Type = typeof(SettingsMenu), Member = "InitOthers", ReturnType = typeof(void))]
	[Calls(Type = typeof(SettingsMenu), Member = "InitSocial", ReturnType = typeof(void))]
	[Calls(Type = typeof(SettingsMenu), Member = "InitKeybinding", ReturnType = typeof(void))]
	public void InitAllOptions() { }

	[CalledBy(Type = typeof(SettingsMenu), Member = "Start", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SettingsMenu), Member = "InitAllOptions", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SettingsMenu), Member = "<OnResetButton>b__148_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Slider), Member = "set_minValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Localization), Member = "GetLocale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(General), Member = "Setup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TMP_Dropdown), typeof(int), typeof(String[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(float), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(TMP_InputField), Member = "set_text", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Toggle), Member = "set_isOn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 22)]
	public void InitCard() { }

	[CalledBy(Type = typeof(SettingsMenu), Member = "Start", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SettingsMenu), Member = "InitAllOptions", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SettingsMenu), Member = "<OnResetButton>b__148_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Toggle), Member = "set_isOn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Slider), Member = "set_minValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Slider), Member = "set_maxValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(GameObject), Member = "SetActive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Time), Member = "get_timeScale", ReturnType = typeof(float))]
	[Calls(Type = typeof(float), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(TMP_InputField), Member = "set_text", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public void InitGameplay() { }

	[CalledBy(Type = typeof(SettingsMenu), Member = "Start", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SettingsMenu), Member = "InitAllOptions", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SettingsMenu), Member = "<OnResetButton>b__148_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(General), Member = "Setup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TMP_Dropdown), typeof(int), typeof(String[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Application), Member = "get_isMobilePlatform", ReturnType = typeof(bool))]
	[Calls(Type = typeof(TMP_InputField), Member = "set_text", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(Application), Member = "get_targetFrameRate", ReturnType = typeof(int))]
	[Calls(Type = typeof(QualitySettings), Member = "get_vSyncCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(PlayerPrefs), Member = "GetInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Localization), Member = "GetLocale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(SettingsMenu), Member = "UpdateResolutions", ReturnType = typeof(void))]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(DuelField), Member = "get_CurrentSetFieldName", ReturnType = typeof(string))]
	[Calls(Type = typeof(General), Member = "Setup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TMP_Dropdown), typeof(string), typeof(String[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "ToArray", ReturnType = "T[]")]
	[Calls(Type = typeof(CustomTheme), Member = "ListOfThemes", ReturnType = typeof(System.Collections.Generic.List`1<System.String>))]
	[Calls(Type = typeof(Toggle), Member = "set_isOn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GameObject), Member = "SetActive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 36)]
	[ContainsUnimplementedInstructions]
	public void InitGraphics() { }

	[CalledBy(Type = typeof(SettingsMenu), Member = "Start", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SettingsMenu), Member = "InitAllOptions", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SettingsMenu), Member = "<OnResetButton>b__148_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Hotkey), Member = "set_DefaultKeySet", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HotkeyDefaults)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(HotkeyInput), Member = "UpdateData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Hotkeys), typeof(MouseButton)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(HotkeyInput), Member = "UpdateData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Hotkeys), typeof(Key)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32Enum, System.ValueTuple`2<System.Int32Enum, System.Int32>>), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Int32Enum"}, ReturnType = typeof(System.ValueTuple`2<System.Int32Enum, System.Int32>))]
	[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Dictionary`2), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.Dictionary`2<TKey, TValue>+Enumerator<TKey, TValue>")]
	[Calls(Type = typeof(Hotkey), Member = "GET_DEFAULT_KEYS", ReturnType = typeof(System.Collections.Generic.Dictionary`2<Enumerator.Hotkeys, System.ValueTuple`2<Enumerator.HotkeyType, System.Int32>>))]
	[Calls(Type = typeof(Enumerable), Member = "ToArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(Object[]))]
	[Calls(Type = typeof(General), Member = "ToArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array)}, ReturnType = "T[]")]
	[Calls(Type = typeof(Enum), Member = "GetValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(Array))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(General), Member = "Setup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TMP_Dropdown), typeof(int), typeof(String[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Localization), Member = "GetLocale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Toggle), Member = "set_isOn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Enumerable), Member = "Select", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource", "TResult"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, TResult>"}, ReturnType = "System.Collections.Generic.IEnumerable`1<TResult>")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 10)]
	public void InitKeybinding() { }

	[CalledBy(Type = typeof(SettingsMenu), Member = "Start", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SettingsMenu), Member = "InitAllOptions", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SettingsMenu), Member = "<OnResetButton>b__148_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Localization), Member = "GetLocaleName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Locale), typeof(byte)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(Enum), Member = "GetValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(Array))]
	[Calls(Type = typeof(Array), Member = "GetEnumerator", ReturnType = typeof(IEnumerator))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "ToArray", ReturnType = "T[]")]
	[Calls(Type = typeof(General), Member = "Setup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TMP_Dropdown), typeof(int), typeof(String[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_InputField), Member = "set_text", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Toggle), Member = "set_isOn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(WebServer), Member = "get_EnableClientAPI", ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 15)]
	[ContainsUnimplementedInstructions]
	public void InitOthers() { }

	[CalledBy(Type = typeof(SettingsMenu), Member = "Start", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SettingsMenu), Member = "InitAllOptions", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SettingsMenu), Member = "<OnResetButton>b__148_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Toggle), Member = "set_isOn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ChatWindow), Member = "get_FontSize", ReturnType = typeof(float))]
	[Calls(Type = typeof(float), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(TMP_InputField), Member = "set_text", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Localization), Member = "GetLocale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(General), Member = "Setup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TMP_Dropdown), typeof(int), typeof(String[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UnityEvent`1), Member = "AddListener", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Events.UnityAction`1<T0>"}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 36)]
	public void InitSocial() { }

	[CalledBy(Type = typeof(SettingsMenu), Member = "Start", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SettingsMenu), Member = "InitAllOptions", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SettingsMenu), Member = "<OnResetButton>b__148_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Sound), Member = "GetVolume", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SoundTypes)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(PlayerPrefs), Member = "GetInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Localization), Member = "GetLocale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(General), Member = "Setup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TMP_Dropdown), typeof(int), typeof(String[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Toggle), Member = "set_isOn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 14)]
	public void InitSound() { }

	[CalledBy(Type = typeof(DiscordController), Member = "OnActivitySpectate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Hotkey), Member = "TapEscape", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(Helper), Member = "CloseScreen", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[])}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	public void OnClickCancel() { }

	[AsyncStateMachine(typeof(<OnClickConfirm>d__147))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "Create", ReturnType = typeof(AsyncVoidMethodBuilder))]
	[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OnClickConfirm>d__147)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OnClickConfirm>d__147&)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	public void OnClickConfirm() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Localization), Member = "GetLocale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(GeneralSelection), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.String>), typeof(string), typeof(bool), typeof(Action), typeof(Action), typeof(int), typeof(Transform)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 8)]
	private void OnCustomHKSetup() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Localization), Member = "GetLocale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(OptionBox), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<System.Boolean>), typeof(string), typeof(Template)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void OnDeauth() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Localization), Member = "GetLocale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(OptionBox), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<System.Boolean>), typeof(string), typeof(Template)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void OnHoldHKSetup() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Localization), Member = "GetLocale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Localization), Member = "GetClientMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(OptionBox), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<System.Boolean>), typeof(string), typeof(Template)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void OnResetButton() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Localization), Member = "GetLocale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(OptionBox), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<System.Boolean>), typeof(string), typeof(Template)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void OnToggleHKSetup() { }

	[CalledBy(Type = typeof(Hotkey), Member = "set_DefaultKeySet", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HotkeyDefaults)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Hotkey), Member = "GET_DEFAULT_KEYS", ReturnType = typeof(System.Collections.Generic.Dictionary`2<Enumerator.Hotkeys, System.ValueTuple`2<Enumerator.HotkeyType, System.Int32>>))]
	[Calls(Type = typeof(Dictionary`2), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.Dictionary`2<TKey, TValue>+Enumerator<TKey, TValue>")]
	[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32Enum, System.ValueTuple`2<System.Int32Enum, System.Int32>>), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Int32Enum"}, ReturnType = typeof(System.ValueTuple`2<System.Int32Enum, System.Int32>))]
	[Calls(Type = typeof(HotkeyInput), Member = "UpdateHKData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HotkeyType), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	public void ReloadHotkeys() { }

	[CalledBy(Type = typeof(SettingsMenu), Member = "Start", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Transform), Member = "get_childCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(GameObject), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Transform), Member = "GetChild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Component), Member = "TryGetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(UnityEvent`1), Member = "AddListener", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Events.UnityAction`1<T0>"}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public void SetupTabs() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SettingsMenu), Member = "SetupTabs", ReturnType = typeof(void))]
	[Calls(Type = typeof(SettingsMenu), Member = "InitKeybinding", ReturnType = typeof(void))]
	[Calls(Type = typeof(SettingsMenu), Member = "InitSocial", ReturnType = typeof(void))]
	[Calls(Type = typeof(SettingsMenu), Member = "InitOthers", ReturnType = typeof(void))]
	[Calls(Type = typeof(SettingsMenu), Member = "InitCard", ReturnType = typeof(void))]
	[Calls(Type = typeof(SettingsMenu), Member = "InitSound", ReturnType = typeof(void))]
	[Calls(Type = typeof(SettingsMenu), Member = "InitGraphics", ReturnType = typeof(void))]
	[Calls(Type = typeof(GameObject), Member = "SetActive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Hotkey), Member = "get_CanKeybind", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(UnityEvent`1), Member = "AddListener", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Events.UnityAction`1<T0>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UnityEvent), Member = "AddListener", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityAction)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SettingsMenu), Member = "UpdateLanguage", ReturnType = typeof(void))]
	[Calls(Type = typeof(SettingsMenu), Member = "InitGameplay", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallsUnknownMethods(Count = 2)]
	private void Start() { }

	[CalledBy(Type = typeof(<>c__DisplayClass118_0), Member = "<DefineDesc>b__0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<>c__DisplayClass127_0), Member = "<SetupTabs>b__0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public void UpdateDesc(string desc) { }

	[CalledBy(Type = typeof(SettingsMenu), Member = "Start", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SettingsMenu), Member = "<OnResetButton>b__148_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Localization), Member = "GetLocale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Component), Member = "GetComponentInChildren", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Transform), Member = "GetChild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(General), Member = "AddTooltip", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MonoBehaviour), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SettingsMenu), Member = "DefineDescs", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 88)]
	[CallsUnknownMethods(Count = 86)]
	public void UpdateLanguage() { }

	[CalledBy(Type = typeof(SettingsMenu), Member = "InitGraphics", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Helper), Member = "FixedUpdate", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Screen), Member = "get_width", ReturnType = typeof(int))]
	[Calls(Type = typeof(Screen), Member = "get_height", ReturnType = typeof(int))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Screen), Member = "get_resolutions", ReturnType = typeof(Resolution[]))]
	[Calls(Type = typeof(General), Member = "ToText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Resolution)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(List`1), Member = "ToArray", ReturnType = "T[]")]
	[Calls(Type = typeof(General), Member = "Setup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TMP_Dropdown), typeof(string), typeof(String[])}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public void UpdateResolutions() { }

}

