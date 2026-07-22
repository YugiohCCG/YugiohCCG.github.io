namespace Manager;

public class Hotkey : MonoBehaviour
{
	[CompilerGenerated]
	private struct <CopyDeckToClipboard>d__85 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		private TaskAwaiter<String> <>u__1; //Field offset: 0x28

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Deck), Member = "get_CurrentDeck", ReturnType = typeof(Deck))]
		[Calls(Type = typeof(Deck), Member = "GetHash", ReturnType = typeof(System.Threading.Tasks.Task`1<System.String>))]
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

	[CompilerGenerated]
	private struct <CopyLogToClipboard>d__84 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		private TaskAwaiter<String> <>u__1; //Field offset: 0x28

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Customization), Member = "GetLogText", ReturnType = typeof(System.Threading.Tasks.Task`1<System.String>))]
		[Calls(Type = typeof(Task`1), Member = "GetAwaiter", ReturnType = "System.Runtime.CompilerServices.TaskAwaiter`1<TResult>")]
		[Calls(Type = typeof(Helper), Member = "set_Clipboard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 2)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		[DeduplicatedMethod]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <PasteDeckFromClipboard>d__88 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		private DeckEdit <>7__wrap1; //Field offset: 0x28
		private TaskAwaiter<Deck> <>u__1; //Field offset: 0x30

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(GUIUtility), Member = "get_systemCopyBuffer", ReturnType = typeof(string))]
		[Calls(Type = typeof(Deck), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(System.Threading.Tasks.Task`1<Card.Deck>))]
		[Calls(Type = typeof(Task`1), Member = "GetAwaiter", ReturnType = "System.Runtime.CompilerServices.TaskAwaiter`1<TResult>")]
		[Calls(Type = typeof(DeckEdit), Member = "UpdateCurrentDeck", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Deck)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Localization), Member = "GetLocale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[])}, ReturnType = typeof(string))]
		[Calls(Type = typeof(MessageBox), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(float)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 9)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		[DeduplicatedMethod]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ReadKey>d__82 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public Action<HotkeyType, Int32> callback; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30
		private YieldAwaiter <>u__2; //Field offset: 0x38

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(LockScreen), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool), typeof(Action), typeof(short)}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Touch), Member = "get_activeFingers", ReturnType = typeof(UnityEngine.InputSystem.Utilities.ReadOnlyArray`1<UnityEngine.InputSystem.EnhancedTouch.Finger>))]
		[Calls(Type = typeof(ButtonControl), Member = "get_wasReleasedThisFrame", ReturnType = typeof(bool))]
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
		[Calls(Type = typeof(Enum), Member = "GetValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(Array))]
		[Calls(Type = typeof(Array), Member = "GetEnumerator", ReturnType = typeof(IEnumerator))]
		[Calls(Type = typeof(Keyboard), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Key)}, ReturnType = typeof(KeyControl))]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 14)]
		[CallsUnknownMethods(Count = 30)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		[DeduplicatedMethod]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	public static bool IsHotkeyLocked; //Field offset: 0x0
	public const HotkeyDefaults DFKS_DEF = 1; //Field offset: 0x0
	public static bool HotkeyLockedThisFrame; //Field offset: 0x1
	public static ChainSetting _chainOption; //Field offset: 0x4
	public static Hotkey Instance; //Field offset: 0x8
	public static bool HotkeyDisabled; //Field offset: 0x10
	[CompilerGenerated]
	private static bool <CardLocked>k__BackingField; //Field offset: 0x11
	public static readonly Dictionary<Hotkeys, ValueTuple`2<HotkeyType, Int32>> DEFAULT_TOGGLE_KEYS; //Field offset: 0x18
	public static readonly Dictionary<Hotkeys, ValueTuple`2<HotkeyType, Int32>> DEFAULT_HOLD_KEYS; //Field offset: 0x20
	private static HotkeyDefaults _dfks; //Field offset: 0x28
	public List<KeyValuePair`2<KeyValuePair`2<HotkeyType, Int32>, KeyValuePair`2<Hotkeys, Func`2<Boolean, Boolean>>>> TapKeys; //Field offset: 0x20
	private Dictionary<Hotkeys, Func`2<Boolean, Boolean>> KEY_ACTIONS; //Field offset: 0x28
	private ChainMethod LastHoldingChain; //Field offset: 0x30

	public static bool CanKeybind
	{
		[CalledBy(Type = typeof(SettingsMenu), Member = "Start", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 183
	}

	public private static bool CardLocked
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		 get { } //Length: 79
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		private set { } //Length: 84
	}

	public static ChainSetting ChainOption
	{
		[CalledBy(Type = typeof(DuelZone), Member = "OnClickChainIcon", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DuelZone), Member = "DefineChain", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool), typeof(bool), typeof(ChainMethod)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DuelZone), Member = "<Start>b__88_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		 get { } //Length: 119
		[CalledBy(Type = typeof(SettingsMenu), Member = "ApplyKeybinding", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(PlayerPrefs), Member = "SetInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(void))]
		 set { } //Length: 147
	}

	public static HotkeyDefaults DefaultKeySet
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 78
		[CalledBy(Type = "Scenes.Menu.SettingsMenu+<>c", Member = "<OnToggleHKSetup>b__121_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = "Scenes.Menu.SettingsMenu+<>c", Member = "<OnHoldHKSetup>b__122_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = "Scenes.Menu.SettingsMenu+<>c", Member = "<OnCustomHKSetup>b__123_0", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(SettingsMenu), Member = "<OnResetButton>b__148_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Hotkey), Member = "Start", ReturnType = typeof(void))]
		[CallerCount(Count = 5)]
		[Calls(Type = typeof(PlayerPrefs), Member = "SetInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Hotkey), Member = "RegisterAllKeys", ReturnType = typeof(void))]
		[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(SettingsMenu), Member = "InitKeybinding", ReturnType = typeof(void))]
		[Calls(Type = typeof(SettingsMenu), Member = "ReloadHotkeys", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		 set { } //Length: 526
	}

	public static bool HasKeyboard
	{
		[CalledBy(Type = typeof(Hotkey), Member = "Update", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(HotkeyInput), Member = "UpdateData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Hotkeys), typeof(int), typeof(HotkeyType)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 58
	}

	public static bool HasMouse
	{
		[CalledBy(Type = typeof(Hotkey), Member = "Update", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(HotkeyInput), Member = "UpdateData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Hotkeys), typeof(int), typeof(HotkeyType)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 58
	}

	public static bool IsDoubleTouching
	{
		[CalledBy(Type = typeof(CopyableCardText), Member = "OnPointerClick", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(CyclicDropdown), Member = "OnPointerClick", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DeckTrunk), Member = "OnPointerClick", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DeckTrunk), Member = "OnEndDrag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DraggableFrame), Member = "OnBeginDrag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DraggableFrame), Member = "OnDrag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DraggableFrame), Member = "OnEndDrag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(General), Member = "IsRightTap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(InteractableObject), Member = "OnPointerClick", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
		[CallerCount(Count = 9)]
		[Calls(Type = typeof(Touch), Member = "get_activeFingers", ReturnType = typeof(UnityEngine.InputSystem.Utilities.ReadOnlyArray`1<UnityEngine.InputSystem.EnhancedTouch.Finger>))]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 138
	}

	public static bool IsHoldingAlt
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ButtonControl), Member = "get_isPressed", ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 184
	}

	private bool IsHoldingChain
	{
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		private get { } //Length: 8
	}

	public static bool IsHoldingCtrl
	{
		[CalledBy(Type = typeof(DeckEdit), Member = "OnRarity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData), typeof(Rarity)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DeckTrunk), Member = "OnRightTap", ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(ButtonControl), Member = "get_isPressed", ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 184
	}

	public static bool IsHoldingShift
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ButtonControl), Member = "get_isPressed", ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 184
	}

	public static bool IsSingleTouching
	{
		[CalledBy(Type = typeof(DeckTrunk), Member = "OnEndDrag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(General), Member = "IsLeftTap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Touch), Member = "get_activeFingers", ReturnType = typeof(UnityEngine.InputSystem.Utilities.ReadOnlyArray`1<UnityEngine.InputSystem.EnhancedTouch.Finger>))]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 138
	}

	public static bool IsTripleTouching
	{
		[CalledBy(Type = typeof(General), Member = "IsMiddleTap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Touch), Member = "get_activeFingers", ReturnType = typeof(UnityEngine.InputSystem.Utilities.ReadOnlyArray`1<UnityEngine.InputSystem.EnhancedTouch.Finger>))]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 138
	}

	public static int TouchCount
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Touch), Member = "get_activeFingers", ReturnType = typeof(UnityEngine.InputSystem.Utilities.ReadOnlyArray`1<UnityEngine.InputSystem.EnhancedTouch.Finger>))]
		 get { } //Length: 85
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32Enum, System.ValueTuple`2<System.Int32Enum, System.Int32>>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Int32Enum", typeof(System.ValueTuple`2<System.Int32Enum, System.Int32>)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 32)]
	[CallsUnknownMethods(Count = 3)]
	private static Hotkey() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public Hotkey() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private void Awake() { }

	[AsyncStateMachine(typeof(<CopyDeckToClipboard>d__85))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "Create", ReturnType = typeof(AsyncVoidMethodBuilder))]
	[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<CopyDeckToClipboard>d__85)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<CopyDeckToClipboard>d__85&)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private static void CopyDeckToClipboard() { }

	[AsyncStateMachine(typeof(<CopyLogToClipboard>d__84))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "Create", ReturnType = typeof(AsyncVoidMethodBuilder))]
	[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<CopyLogToClipboard>d__84)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<CopyLogToClipboard>d__84&)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private static void CopyLogToClipboard() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DeckEdit), Member = "get_IsActive", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Toggle), Member = "set_isOn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private static void FavoriteCardOnDeckEdit() { }

	[CalledBy(Type = typeof(SettingsMenu), Member = "Start", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[ContainsUnimplementedInstructions]
	public static bool get_CanKeybind() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	public static bool get_CardLocked() { }

	[CalledBy(Type = typeof(DuelZone), Member = "OnClickChainIcon", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DuelZone), Member = "DefineChain", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool), typeof(bool), typeof(ChainMethod)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DuelZone), Member = "<Start>b__88_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	public static ChainSetting get_ChainOption() { }

	[CalledBy(Type = typeof(SettingsMenu), Member = "ReloadHotkeys", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SettingsMenu), Member = "InitKeybinding", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Hotkey), Member = "LoadCustomHKSet", ReturnType = typeof(System.Collections.Generic.Dictionary`2<Enumerator.Hotkeys, System.ValueTuple`2<Enumerator.HotkeyType, System.Int32>>))]
	public static Dictionary<Hotkeys, ValueTuple`2<HotkeyType, Int32>> GET_DEFAULT_KEYS() { }

	[CallerCount(Count = 0)]
	public static HotkeyDefaults get_DefaultKeySet() { }

	[CalledBy(Type = typeof(Hotkey), Member = "Update", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(HotkeyInput), Member = "UpdateData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Hotkeys), typeof(int), typeof(HotkeyType)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[ContainsUnimplementedInstructions]
	public static bool get_HasKeyboard() { }

	[CalledBy(Type = typeof(Hotkey), Member = "Update", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(HotkeyInput), Member = "UpdateData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Hotkeys), typeof(int), typeof(HotkeyType)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[ContainsUnimplementedInstructions]
	public static bool get_HasMouse() { }

	[CalledBy(Type = typeof(CopyableCardText), Member = "OnPointerClick", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CyclicDropdown), Member = "OnPointerClick", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DeckTrunk), Member = "OnPointerClick", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DeckTrunk), Member = "OnEndDrag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DraggableFrame), Member = "OnBeginDrag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DraggableFrame), Member = "OnDrag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DraggableFrame), Member = "OnEndDrag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(General), Member = "IsRightTap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(InteractableObject), Member = "OnPointerClick", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(Touch), Member = "get_activeFingers", ReturnType = typeof(UnityEngine.InputSystem.Utilities.ReadOnlyArray`1<UnityEngine.InputSystem.EnhancedTouch.Finger>))]
	[ContainsUnimplementedInstructions]
	public static bool get_IsDoubleTouching() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ButtonControl), Member = "get_isPressed", ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	public static bool get_IsHoldingAlt() { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	private bool get_IsHoldingChain() { }

	[CalledBy(Type = typeof(DeckEdit), Member = "OnRarity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData), typeof(Rarity)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DeckTrunk), Member = "OnRightTap", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(ButtonControl), Member = "get_isPressed", ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	public static bool get_IsHoldingCtrl() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ButtonControl), Member = "get_isPressed", ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	public static bool get_IsHoldingShift() { }

	[CalledBy(Type = typeof(DeckTrunk), Member = "OnEndDrag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(General), Member = "IsLeftTap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Touch), Member = "get_activeFingers", ReturnType = typeof(UnityEngine.InputSystem.Utilities.ReadOnlyArray`1<UnityEngine.InputSystem.EnhancedTouch.Finger>))]
	[ContainsUnimplementedInstructions]
	public static bool get_IsSingleTouching() { }

	[CalledBy(Type = typeof(General), Member = "IsMiddleTap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Touch), Member = "get_activeFingers", ReturnType = typeof(UnityEngine.InputSystem.Utilities.ReadOnlyArray`1<UnityEngine.InputSystem.EnhancedTouch.Finger>))]
	[ContainsUnimplementedInstructions]
	public static bool get_IsTripleTouching() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Touch), Member = "get_activeFingers", ReturnType = typeof(UnityEngine.InputSystem.Utilities.ReadOnlyArray`1<UnityEngine.InputSystem.EnhancedTouch.Finger>))]
	public static int get_TouchCount() { }

	[CalledBy(Type = typeof(Hotkey), Member = "IsSameHotkey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Hotkeys), typeof(Hotkeys)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Hotkey), Member = "UpdateTapKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Hotkeys), typeof(int), typeof(HotkeyType)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	public KeyValuePair<KeyValuePair`2<HotkeyType, Int32>, KeyValuePair`2<Hotkeys, Func`2<Boolean, Boolean>>> GetHotkeyData(Hotkeys hk) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Keyboard), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Key)}, ReturnType = typeof(KeyControl))]
	[Calls(Type = typeof(ButtonControl), Member = "get_isPressed", ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	public static bool GetKey(Key key) { }

	[CalledBy(Type = typeof(Hotkey), Member = "TapNoChain", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Hotkey), Member = "TapAutoChain", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Hotkey), Member = "TapFullChain", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Hotkey), Member = "TapYes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Hotkey), Member = "TapNo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	private bool HasPrompt() { }

	[CalledBy(Type = typeof(Hotkey), Member = "TapFinish", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Hotkey), Member = "TapNoChain", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Hotkey), Member = "TapAutoChain", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Hotkey), Member = "TapFullChain", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Hotkey), Member = "TapYes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Hotkey), Member = "TapNo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Hotkey), Member = "TapEscape", ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(GameObject), Member = "get_activeInHierarchy", ReturnType = typeof(bool))]
	[Calls(Type = typeof(PhaseSelect), Member = "get_IsOpen", ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	private bool HasSomethingToClose() { }

	[CalledBy(Type = typeof(Hotkey), Member = "TapFinish", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Hotkey), Member = "TapNoChain", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Hotkey), Member = "TapAutoChain", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Hotkey), Member = "TapFullChain", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(DuelZone), Member = "get_IsDueling", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(GameObject), Member = "get_activeInHierarchy", ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	private bool HasToConfirm() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DuelZone), Member = "get_IsDueling", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(GameObject), Member = "get_activeSelf", ReturnType = typeof(bool))]
	[Calls(Type = typeof(GameObject), Member = "SetActive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void HideUI(bool pressed) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	public bool HKAlreadyAssigned(int val, HotkeyType kt, Hotkeys hk) { }

	[CalledBy(Type = typeof(Hotkey), Member = "TapFinish", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Hotkey), Member = "TapNoChain", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Hotkey), Member = "TapAutoChain", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Hotkey), Member = "TapFullChain", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Hotkey), Member = "TapYes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Hotkey), Member = "TapNo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 15)]
	[Calls(Type = typeof(Hotkey), Member = "GetHotkeyData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Hotkeys)}, ReturnType = typeof(System.Collections.Generic.KeyValuePair`2<System.Collections.Generic.KeyValuePair`2<Enumerator.HotkeyType, System.Int32>, System.Collections.Generic.KeyValuePair`2<Enumerator.Hotkeys, System.Func`2<System.Boolean, System.Boolean>>>))]
	[ContainsUnimplementedInstructions]
	private bool IsSameHotkey(Hotkeys k1, Hotkeys k2) { }

	[CalledBy(Type = typeof(Hotkey), Member = "GET_DEFAULT_KEYS", ReturnType = typeof(System.Collections.Generic.Dictionary`2<Enumerator.Hotkeys, System.ValueTuple`2<Enumerator.HotkeyType, System.Int32>>))]
	[CalledBy(Type = typeof(Hotkey), Member = "RegisterAllKeys", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(Enum), Member = "GetValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(Array))]
	[Calls(Type = typeof(Array), Member = "GetEnumerator", ReturnType = typeof(IEnumerator))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32Enum, System.ValueTuple`2<System.Int32Enum, System.Int32>>), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Int32Enum"}, ReturnType = typeof(System.ValueTuple`2<System.Int32Enum, System.Int32>))]
	[Calls(Type = typeof(PlayerPrefs), Member = "GetInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32Enum, System.ValueTuple`2<System.Int32Enum, System.Int32>>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Int32Enum", typeof(System.ValueTuple`2<System.Int32Enum, System.Int32>)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 14)]
	public static Dictionary<Hotkeys, ValueTuple`2<HotkeyType, Int32>> LoadCustomHKSet() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EnhancedTouchSupport), Member = "Disable", ReturnType = typeof(void))]
	private void OnDisable() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EnhancedTouchSupport), Member = "Enable", ReturnType = typeof(void))]
	private void OnEnable() { }

	[AsyncStateMachine(typeof(<PasteDeckFromClipboard>d__88))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "Create", ReturnType = typeof(AsyncVoidMethodBuilder))]
	[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<PasteDeckFromClipboard>d__88)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<PasteDeckFromClipboard>d__88&)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private static void PasteDeckFromClipboard() { }

	[AsyncStateMachine(typeof(<ReadKey>d__82))]
	[CalledBy(Type = typeof(HotkeyInput), Member = "OnClick", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "Create", ReturnType = typeof(AsyncVoidMethodBuilder))]
	[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<ReadKey>d__82)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<ReadKey>d__82&)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	public static void ReadKey(Action<HotkeyType, Int32> callback) { }

	[CalledBy(Type = typeof(Hotkey), Member = "set_DefaultKeySet", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HotkeyDefaults)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32Enum, System.Object>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Int32Enum", typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Hotkey), Member = "LoadCustomHKSet", ReturnType = typeof(System.Collections.Generic.Dictionary`2<Enumerator.Hotkeys, System.ValueTuple`2<Enumerator.HotkeyType, System.Int32>>))]
	[Calls(Type = typeof(Dictionary`2), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.Dictionary`2<TKey, TValue>+Enumerator<TKey, TValue>")]
	[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32Enum, System.Object>), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Int32Enum"}, ReturnType = typeof(object))]
	[Calls(Type = typeof(Hotkey), Member = "RegisterTapKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Hotkeys), typeof(int), typeof(HotkeyType), typeof(System.Func`2<System.Boolean, System.Boolean>)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 19)]
	[CallsUnknownMethods(Count = 6)]
	public void RegisterAllKeys() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Hotkey), Member = "RegisterTapKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Hotkeys), typeof(int), typeof(HotkeyType), typeof(System.Func`2<System.Boolean, System.Boolean>)}, ReturnType = typeof(void))]
	private void RegisterTapKey(Hotkeys hk, MouseButton kc, Func<Boolean, Boolean> func) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Hotkey), Member = "RegisterTapKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Hotkeys), typeof(int), typeof(HotkeyType), typeof(System.Func`2<System.Boolean, System.Boolean>)}, ReturnType = typeof(void))]
	private void RegisterTapKey(Hotkeys hk, Key kc, Func<Boolean, Boolean> func) { }

	[CalledBy(Type = typeof(Hotkey), Member = "RegisterAllKeys", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Hotkey), Member = "UpdateTapKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Hotkeys), typeof(int), typeof(HotkeyType)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Hotkey), Member = "RegisterTapKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Hotkeys), typeof(MouseButton), typeof(System.Func`2<System.Boolean, System.Boolean>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Hotkey), Member = "RegisterTapKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Hotkeys), typeof(Key), typeof(System.Func`2<System.Boolean, System.Boolean>)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(PlayerPrefs), Member = "GetInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(KeyValuePair`2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private void RegisterTapKey(Hotkeys hk, int kc, HotkeyType kt, Func<Boolean, Boolean> func) { }

	[CalledBy(Type = "Scenes.Menu.SettingsMenu+<>c", Member = "<OnCustomHKSetup>b__123_0", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(Enum), Member = "GetValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(Array))]
	[Calls(Type = typeof(Array), Member = "GetEnumerator", ReturnType = typeof(IEnumerator))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(PlayerPrefs), Member = "GetInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(PlayerPrefs), Member = "SetInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 11)]
	public static void SaveCustomHKSet() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DeckEdit), Member = "get_IsActive", ReturnType = typeof(bool))]
	[Calls(Type = typeof(DeckEdit), Member = "OnSaveButton", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private static void SaveDeckOnDeckEdit() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	private static void set_CardLocked(bool value) { }

	[CalledBy(Type = typeof(SettingsMenu), Member = "ApplyKeybinding", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PlayerPrefs), Member = "SetInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(void))]
	public static void set_ChainOption(ChainSetting value) { }

	[CalledBy(Type = "Scenes.Menu.SettingsMenu+<>c", Member = "<OnToggleHKSetup>b__121_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Scenes.Menu.SettingsMenu+<>c", Member = "<OnHoldHKSetup>b__122_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Scenes.Menu.SettingsMenu+<>c", Member = "<OnCustomHKSetup>b__123_0", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SettingsMenu), Member = "<OnResetButton>b__148_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Hotkey), Member = "Start", ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(PlayerPrefs), Member = "SetInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Hotkey), Member = "RegisterAllKeys", ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(SettingsMenu), Member = "InitKeybinding", ReturnType = typeof(void))]
	[Calls(Type = typeof(SettingsMenu), Member = "ReloadHotkeys", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public static void set_DefaultKeySet(HotkeyDefaults value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EventSystem), Member = "get_current", ReturnType = typeof(EventSystem))]
	[Calls(Type = typeof(PointerEventData), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventSystem)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ExecuteEvents), Member = "Execute", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(BaseEventData), "UnityEngine.EventSystems.ExecuteEvents+EventFunction`1<T>"}, ReturnType = typeof(bool))]
	public void SimulateClick(GameObject btn) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(EventSystem), Member = "get_current", ReturnType = typeof(EventSystem))]
	[Calls(Type = typeof(PointerEventData), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventSystem)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ExecuteEvents), Member = "Execute", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(BaseEventData), "UnityEngine.EventSystems.ExecuteEvents+EventFunction`1<T>"}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	public void SimulateClick(Button btn) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EventSystem), Member = "get_current", ReturnType = typeof(EventSystem))]
	[Calls(Type = typeof(PointerEventData), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventSystem)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ExecuteEvents), Member = "Execute", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(BaseEventData), "UnityEngine.EventSystems.ExecuteEvents+EventFunction`1<T>"}, ReturnType = typeof(bool))]
	public void SimulateHover(GameObject obj) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EventSystem), Member = "get_current", ReturnType = typeof(EventSystem))]
	[Calls(Type = typeof(PointerEventData), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventSystem)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ExecuteEvents), Member = "Execute", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(BaseEventData), "UnityEngine.EventSystems.ExecuteEvents+EventFunction`1<T>"}, ReturnType = typeof(bool))]
	public void SimulateTap(GameObject obj) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EventSystem), Member = "get_current", ReturnType = typeof(EventSystem))]
	[Calls(Type = typeof(PointerEventData), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventSystem)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ExecuteEvents), Member = "Execute", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(BaseEventData), "UnityEngine.EventSystems.ExecuteEvents+EventFunction`1<T>"}, ReturnType = typeof(bool))]
	public void SimulateUnhover(GameObject obj) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerPrefs), Member = "GetInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Hotkey), Member = "set_DefaultKeySet", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HotkeyDefaults)}, ReturnType = typeof(void))]
	private void Start() { }

	[CalledBy(Type = typeof(Hotkey), Member = "Update", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(DuelZone), Member = "get_IsDueling", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Hotkey), Member = "HasToConfirm", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Hotkey), Member = "IsSameHotkey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Hotkeys), typeof(Hotkeys)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Hotkey), Member = "HasPrompt", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Hotkey), Member = "HasSomethingToClose", ReturnType = typeof(bool))]
	[Calls(Type = typeof(DuelZone), Member = "OnAvailableChain", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public bool TapAutoChain(bool pressed) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DuelZone), Member = "get_IsDueling", ReturnType = typeof(bool))]
	[Calls(Type = typeof(FieldSlot), Member = "get_AmountOfCards", ReturnType = typeof(byte))]
	[Calls(Type = typeof(CardListDisplay), Member = "IsShowingSlot", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FieldSlot)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	public bool TapBanish(bool pressed) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ChatWindow), Member = "get_AllowCard", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Toggle), Member = "set_isOn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public bool TapCardInfo(bool pressed) { }

	[CalledBy(Type = typeof(Hotkey), Member = "TapEscape", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CardListDisplay), Member = "OnClose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(GameObject), Member = "get_activeInHierarchy", ReturnType = typeof(bool))]
	[Calls(Type = typeof(GeneralSelection), Member = "OnClose", ReturnType = typeof(void))]
	[Calls(Type = typeof(TextBox), Member = "OnClickClose", ReturnType = typeof(void))]
	[Calls(Type = typeof(PhaseSelect), Member = "get_IsOpen", ReturnType = typeof(bool))]
	[Calls(Type = typeof(InfoBox), Member = "OnClickConfirm", ReturnType = typeof(void))]
	[Calls(Type = typeof(DisplayCard), Member = "get_ObjectInstance", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(Helper), Member = "CloseScreen", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[])}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	public bool TapClose(bool pressed) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DuelZone), Member = "get_IsDueling", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Toggle), Member = "set_isOn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public bool TapDisplayCard(bool pressed) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TextBox), Member = "get_ObjectInstance", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(GameObject), Member = "get_activeInHierarchy", ReturnType = typeof(bool))]
	[Calls(Type = typeof(TextBox), Member = "OnClickConfirm", ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_InputField), Member = "ActivateInputField", ReturnType = typeof(void))]
	[Calls(Type = typeof(DeckEdit), Member = "get_IsActive", ReturnType = typeof(bool))]
	[Calls(Type = typeof(ChatWindow), Member = "get_AllowChat", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Toggle), Member = "set_isOn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ChatWindow), Member = "ActivateInputField", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public bool TapEnterInput(bool pressed) { }

	[CalledBy(Type = typeof(Hotkey), Member = "Update", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(OptionBox), Member = "OnClickNo", ReturnType = typeof(void))]
	[Calls(Type = typeof(MainMenu), Member = "OnClickExit", ReturnType = typeof(void))]
	[Calls(Type = typeof(LobbyScreen), Member = "OnExitButton", ReturnType = typeof(void))]
	[Calls(Type = typeof(DeckSelection), Member = "OnClickClose", ReturnType = typeof(void))]
	[Calls(Type = typeof(DeckEdit), Member = "OnCloseButton", ReturnType = typeof(void))]
	[Calls(Type = typeof(DuelZone), Member = "OnClickExit", ReturnType = typeof(void))]
	[Calls(Type = typeof(DuelZone), Member = "get_IsDueling", ReturnType = typeof(bool))]
	[Calls(Type = typeof(GameRoom), Member = "OnClickLeave", ReturnType = typeof(void))]
	[Calls(Type = typeof(GameRoom), Member = "get_ObjectInstance", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(AboutScreen), Member = "OnClickClose", ReturnType = typeof(void))]
	[Calls(Type = typeof(AboutScreen), Member = "get_ObjectInstance", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(DeckEdit), Member = "get_IsActive", ReturnType = typeof(bool))]
	[Calls(Type = typeof(DeckSelection), Member = "get_IsActive", ReturnType = typeof(bool))]
	[Calls(Type = typeof(ReplayList), Member = "OnClickClose", ReturnType = typeof(void))]
	[Calls(Type = typeof(ReplayList), Member = "get_ObjectInstance", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(LobbyScreen), Member = "get_IsActive", ReturnType = typeof(bool))]
	[Calls(Type = typeof(MainMenu), Member = "get_IsActive", ReturnType = typeof(bool))]
	[Calls(Type = typeof(SettingsMenu), Member = "OnClickCancel", ReturnType = typeof(void))]
	[Calls(Type = typeof(GameObject), Member = "get_activeInHierarchy", ReturnType = typeof(bool))]
	[Calls(Type = typeof(SettingsMenu), Member = "get_ObjectInstance", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Hotkey), Member = "HasSomethingToClose", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Hotkey), Member = "TapClose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 2)]
	public void TapEscape() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DuelZone), Member = "get_IsDueling", ReturnType = typeof(bool))]
	[Calls(Type = typeof(FieldSlot), Member = "get_AmountOfCards", ReturnType = typeof(byte))]
	[Calls(Type = typeof(CardListDisplay), Member = "IsShowingSlot", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FieldSlot)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	public bool TapExtraDeck(bool pressed) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Hotkey), Member = "HasToConfirm", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Hotkey), Member = "HasSomethingToClose", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Hotkey), Member = "IsSameHotkey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Hotkeys), typeof(Hotkeys)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DuelZone), Member = "OnClickFinish", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	public bool TapFinish(bool pressed) { }

	[CalledBy(Type = typeof(Hotkey), Member = "Update", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(DuelZone), Member = "get_IsDueling", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Hotkey), Member = "HasToConfirm", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Hotkey), Member = "IsSameHotkey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Hotkeys), typeof(Hotkeys)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Hotkey), Member = "HasPrompt", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Hotkey), Member = "HasSomethingToClose", ReturnType = typeof(bool))]
	[Calls(Type = typeof(DuelZone), Member = "OnFullChain", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public bool TapFullChain(bool pressed) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DuelZone), Member = "get_IsDueling", ReturnType = typeof(bool))]
	[Calls(Type = typeof(FieldSlot), Member = "get_AmountOfCards", ReturnType = typeof(byte))]
	[Calls(Type = typeof(CardListDisplay), Member = "IsShowingSlot", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FieldSlot)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	public bool TapGraveyard(bool pressed) { }

	[CallerCount(Count = 0)]
	public bool TapLockCard(bool pressed) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DuelZone), Member = "get_IsDueling", ReturnType = typeof(bool))]
	[Calls(Type = typeof(DuelZone), Member = "ToggleVisualLog", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public bool TapLog(bool pressed) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Hotkey), Member = "HasPrompt", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Hotkey), Member = "HasSomethingToClose", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Hotkey), Member = "IsSameHotkey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Hotkeys), typeof(Hotkeys)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(OptionBox), Member = "OnClickNo", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public bool TapNo(bool pressed) { }

	[CalledBy(Type = typeof(Hotkey), Member = "Update", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(DuelZone), Member = "get_IsDueling", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Hotkey), Member = "HasToConfirm", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Hotkey), Member = "IsSameHotkey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Hotkeys), typeof(Hotkeys)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Hotkey), Member = "HasPrompt", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Hotkey), Member = "HasSomethingToClose", ReturnType = typeof(bool))]
	[Calls(Type = typeof(DuelZone), Member = "OnNoChain", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public bool TapNoChain(bool pressed) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Hotkey), Member = "HasPrompt", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Hotkey), Member = "HasSomethingToClose", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Hotkey), Member = "IsSameHotkey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Hotkeys), typeof(Hotkeys)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(OptionBox), Member = "OnClickYes", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public bool TapYes(bool pressed) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Template), Member = "get_IsInvalid", ReturnType = typeof(bool))]
	[Calls(Type = typeof(DuelZone), Member = "get_IsDueling", ReturnType = typeof(bool))]
	[Calls(Type = typeof(DeckEdit), Member = "get_IsActive", ReturnType = typeof(bool))]
	[Calls(Type = typeof(ClientCard), Member = "get_Data", ReturnType = typeof(Card))]
	[Calls(Type = typeof(DisplayCard), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(ClientCard)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DisplayCard), Member = "get_ObjectInstance", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(Helper), Member = "CloseScreen", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[])}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 9)]
	public bool TapZoomCard(bool pressed) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Keyboard), Member = "get_cKey", ReturnType = typeof(KeyControl))]
	[Calls(Type = typeof(Keyboard), Member = "get_sKey", ReturnType = typeof(KeyControl))]
	[Calls(Type = typeof(DeckEdit), Member = "OnSaveButton", ReturnType = typeof(void))]
	[Calls(Type = typeof(Toggle), Member = "set_isOn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<PasteDeckFromClipboard>d__88)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<PasteDeckFromClipboard>d__88&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<CopyDeckToClipboard>d__85)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<CopyDeckToClipboard>d__85&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Keyboard), Member = "get_escapeKey", ReturnType = typeof(KeyControl))]
	[Calls(Type = typeof(Hotkey), Member = "TapEscape", ReturnType = typeof(void))]
	[Calls(Type = typeof(Keyboard), Member = "get_hKey", ReturnType = typeof(KeyControl))]
	[Calls(Type = typeof(DuelZone), Member = "get_IsDueling", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(GameObject), Member = "get_activeSelf", ReturnType = typeof(bool))]
	[Calls(Type = typeof(GameObject), Member = "SetActive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Keyboard), Member = "get_fKey", ReturnType = typeof(KeyControl))]
	[Calls(Type = typeof(Keyboard), Member = "get_vKey", ReturnType = typeof(KeyControl))]
	[Calls(Type = typeof(DeckEdit), Member = "get_IsActive", ReturnType = typeof(bool))]
	[Calls(Type = typeof(ChatWindow), Member = "get_IsInputingChat", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Touch), Member = "get_activeFingers", ReturnType = typeof(UnityEngine.InputSystem.Utilities.ReadOnlyArray`1<UnityEngine.InputSystem.EnhancedTouch.Finger>))]
	[Calls(Type = typeof(Hotkey), Member = "TapFullChain", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Hotkey), Member = "TapAutoChain", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Hotkey), Member = "TapNoChain", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Keyboard), Member = "get_upArrowKey", ReturnType = typeof(KeyControl))]
	[Calls(Type = typeof(ButtonControl), Member = "get_wasReleasedThisFrame", ReturnType = typeof(bool))]
	[Calls(Type = typeof(ChatWindow), Member = "get_CanInputChat", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Hotkey), Member = "get_HasMouse", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Keyboard), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Key)}, ReturnType = typeof(KeyControl))]
	[Calls(Type = typeof(Application), Member = "get_isFocused", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Hotkey), Member = "get_HasKeyboard", ReturnType = typeof(bool))]
	[Calls(Type = typeof(ButtonControl), Member = "get_isPressed", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Keyboard), Member = "get_lKey", ReturnType = typeof(KeyControl))]
	[Calls(Type = typeof(ButtonControl), Member = "get_wasPressedThisFrame", ReturnType = typeof(bool))]
	[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "Create", ReturnType = typeof(AsyncVoidMethodBuilder))]
	[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<CopyLogToClipboard>d__84)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<CopyLogToClipboard>d__84&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ChatWindow), Member = "RetypeInput", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 26)]
	[CallsUnknownMethods(Count = 61)]
	[ContainsUnimplementedInstructions]
	private void Update() { }

	[CalledBy(Type = typeof(HotkeyInput), Member = "UpdateHKData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HotkeyType), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(HotkeyInput), Member = "UpdateHK", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HotkeyType), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Hotkey), Member = "GetHotkeyData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Hotkeys)}, ReturnType = typeof(System.Collections.Generic.KeyValuePair`2<System.Collections.Generic.KeyValuePair`2<Enumerator.HotkeyType, System.Int32>, System.Collections.Generic.KeyValuePair`2<Enumerator.Hotkeys, System.Func`2<System.Boolean, System.Boolean>>>))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Collections.Generic.KeyValuePair`2<System.Collections.Generic.KeyValuePair`2<System.Int32Enum, System.Int32>, System.Collections.Generic.KeyValuePair`2<System.Int32Enum, System.Object>>>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.KeyValuePair`2<System.Collections.Generic.KeyValuePair`2<System.Int32Enum, System.Int32>, System.Collections.Generic.KeyValuePair`2<System.Int32Enum, System.Object>>)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(PlayerPrefs), Member = "SetInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Hotkey), Member = "RegisterTapKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Hotkeys), typeof(int), typeof(HotkeyType), typeof(System.Func`2<System.Boolean, System.Boolean>)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public bool UpdateTapKey(Hotkeys hk, int val, HotkeyType kt) { }

}

