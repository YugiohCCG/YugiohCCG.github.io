namespace UnityEngine.InputSystem;

[AddComponentMenu("Input/Player Input Manager")]
[HelpURL("https://docs.unity3d.com/Packages/com.unity.inputsystem@1.19/manual/PlayerInputManager.html")]
public class PlayerInputManager : MonoBehaviour
{
	internal class PlayerJoinedEvent : UnityEvent<PlayerInput>
	{

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		public PlayerJoinedEvent() { }

	}

	internal class PlayerLeftEvent : UnityEvent<PlayerInput>
	{

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		public PlayerLeftEvent() { }

	}

	public const string PlayerJoinedMessage = "OnPlayerJoined"; //Field offset: 0x0
	public const string PlayerLeftMessage = "OnPlayerLeft"; //Field offset: 0x0
	[CompilerGenerated]
	private static PlayerInputManager <instance>k__BackingField; //Field offset: 0x0
	[SerializeField]
	internal PlayerNotifications m_NotificationBehavior; //Field offset: 0x20
	[SerializeField]
	[Tooltip("Set a limit for the maximum number of players who are able to join.")]
	internal int m_MaxPlayerCount; //Field offset: 0x24
	[SerializeField]
	internal bool m_AllowJoining; //Field offset: 0x28
	[SerializeField]
	internal PlayerJoinBehavior m_JoinBehavior; //Field offset: 0x2C
	[SerializeField]
	internal PlayerJoinedEvent m_PlayerJoinedEvent; //Field offset: 0x30
	[SerializeField]
	internal PlayerLeftEvent m_PlayerLeftEvent; //Field offset: 0x38
	[SerializeField]
	internal InputActionProperty m_JoinAction; //Field offset: 0x40
	[SerializeField]
	internal GameObject m_PlayerPrefab; //Field offset: 0x58
	[SerializeField]
	internal bool m_SplitScreen; //Field offset: 0x60
	[SerializeField]
	internal bool m_MaintainAspectRatioInSplitScreen; //Field offset: 0x61
	[SerializeField]
	[Tooltip("Explicitly set a fixed number of screens or otherwise allow the screen to be divided automatically to best fit the number of players.")]
	internal int m_FixedNumberOfSplitScreens; //Field offset: 0x64
	[SerializeField]
	internal Rect m_SplitScreenRect; //Field offset: 0x68
	private bool m_JoinActionDelegateHooked; //Field offset: 0x78
	private bool m_UnpairedDeviceUsedDelegateHooked; //Field offset: 0x79
	private Action<CallbackContext> m_JoinActionDelegate; //Field offset: 0x80
	private Action<InputControl, InputEventPtr> m_UnpairedDeviceUsedDelegate; //Field offset: 0x88
	private CallbackArray<Action`1<PlayerInput>> m_PlayerJoinedCallbacks; //Field offset: 0x90
	private CallbackArray<Action`1<PlayerInput>> m_PlayerLeftCallbacks; //Field offset: 0xE0

	public event Action<PlayerInput> onPlayerJoined
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CallbackArray`1), Member = "AddCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TDelegate"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 4)]
		 add { } //Length: 153
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CallbackArray`1), Member = "RemoveCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TDelegate"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 4)]
		 remove { } //Length: 153
	}

	public event Action<PlayerInput> onPlayerLeft
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CallbackArray`1), Member = "AddCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TDelegate"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 4)]
		 add { } //Length: 153
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CallbackArray`1), Member = "RemoveCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TDelegate"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 4)]
		 remove { } //Length: 153
	}

	public int fixedNumberOfSplitScreens
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 4
	}

	public private static PlayerInputManager instance
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		 get { } //Length: 54
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		private set { } //Length: 81
	}

	public InputActionProperty joinAction
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 21
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InputActionProperty), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionProperty), typeof(InputActionProperty)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(PlayerInputManager), Member = "DisableJoining", ReturnType = typeof(void))]
		[Calls(Type = typeof(PlayerInputManager), Member = "EnableJoining", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		 set { } //Length: 164
	}

	public PlayerJoinBehavior joinBehavior
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 4
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(PlayerInputManager), Member = "DisableJoining", ReturnType = typeof(void))]
		[Calls(Type = typeof(PlayerInputManager), Member = "EnableJoining", ReturnType = typeof(void))]
		 set { } //Length: 70
	}

	public bool joiningEnabled
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public bool maintainAspectRatioInSplitScreen
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public int maxPlayerCount
	{
		[CallerCount(Count = 9)]
		[DeduplicatedMethod]
		 get { } //Length: 4
	}

	internal static String[] messages
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 4)]
		internal get { } //Length: 155
	}

	public PlayerNotifications notificationBehavior
	{
		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		 get { } //Length: 4
		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	public int playerCount
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 77
	}

	public PlayerJoinedEvent playerJoinedEvent
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 138
	}

	public PlayerLeftEvent playerLeftEvent
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 138
	}

	public GameObject playerPrefab
	{
		[CallerCount(Count = 10)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 set { } //Length: 13
	}

	public bool splitScreen
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ReadOnlyArray`1), Member = "GetEnumerator", ReturnType = "UnityEngine.InputSystem.Utilities.ReadOnlyArray`1<TValue>+Enumerator<TValue>")]
		[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
		[Calls(Type = typeof(Enumerator), Member = "get_Current", ReturnType = "TValue")]
		[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Camera), Member = "set_rect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(PlayerInputManager), Member = "UpdateSplitScreen", ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 3)]
		 set { } //Length: 646
	}

	public Rect splitScreenArea
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 11
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public PlayerInputManager() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CallbackArray`1), Member = "AddCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TDelegate"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	public void add_onPlayerJoined(Action<PlayerInput> value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CallbackArray`1), Member = "AddCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TDelegate"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	public void add_onPlayerLeft(Action<PlayerInput> value) { }

	[CalledBy(Type = typeof(PlayerInputManager), Member = "JoinPlayerFromUI", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PlayerInputManager), Member = "JoinPlayerFromAction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CallbackContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PlayerInputManager), Member = "JoinPlayerFromActionIfNotAlreadyJoined", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CallbackContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PlayerInputManager), Member = "JoinPlayer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(string), typeof(InputDevice)}, ReturnType = typeof(PlayerInput))]
	[CalledBy(Type = typeof(PlayerInputManager), Member = "JoinPlayer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(string), typeof(InputDevice[])}, ReturnType = typeof(PlayerInput))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Debug), Member = "LogWarning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	private bool CheckIfPlayerCanJoin(int playerIndex = -1) { }

	[CalledBy(Type = typeof(PlayerInputManager), Member = "set_joinBehavior", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PlayerJoinBehavior)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PlayerInputManager), Member = "set_joinAction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionProperty)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PlayerInputManager), Member = "OnEnable", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PlayerInputManager), Member = "OnDisable", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(InputUser), Member = "remove_onUnpairedDeviceUsed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`2<UnityEngine.InputSystem.InputControl, UnityEngine.InputSystem.LowLevel.InputEventPtr>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputUser), Member = "set_listenForUnpairedDeviceActivity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputActionProperty), Member = "get_action", ReturnType = typeof(InputAction))]
	[Calls(Type = typeof(InputAction), Member = "remove_performed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<UnityEngine.InputSystem.InputAction+CallbackContext>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputAction), Member = "Disable", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void DisableJoining() { }

	[CalledBy(Type = typeof(PlayerInputManager), Member = "set_joinBehavior", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PlayerJoinBehavior)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PlayerInputManager), Member = "set_joinAction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionProperty)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PlayerInputManager), Member = "OnEnable", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(InputUser), Member = "add_onUnpairedDeviceUsed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`2<UnityEngine.InputSystem.InputControl, UnityEngine.InputSystem.LowLevel.InputEventPtr>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputUser), Member = "set_listenForUnpairedDeviceActivity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputActionProperty), Member = "get_action", ReturnType = typeof(InputAction))]
	[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputAction), Member = "add_performed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<UnityEngine.InputSystem.InputAction+CallbackContext>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputAction), Member = "Enable", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public void EnableJoining() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public int get_fixedNumberOfSplitScreens() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	public static PlayerInputManager get_instance() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public InputActionProperty get_joinAction() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public PlayerJoinBehavior get_joinBehavior() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public bool get_joiningEnabled() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public bool get_maintainAspectRatioInSplitScreen() { }

	[CallerCount(Count = 9)]
	[DeduplicatedMethod]
	public int get_maxPlayerCount() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 4)]
	internal static String[] get_messages() { }

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public PlayerNotifications get_notificationBehavior() { }

	[CallerCount(Count = 0)]
	public int get_playerCount() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public PlayerJoinedEvent get_playerJoinedEvent() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public PlayerLeftEvent get_playerLeftEvent() { }

	[CallerCount(Count = 10)]
	[DeduplicatedMethod]
	public GameObject get_playerPrefab() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public bool get_splitScreen() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public Rect get_splitScreenArea() { }

	[CalledBy(Type = typeof(PlayerInputManager), Member = "OnUnpairedDeviceUsed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl), typeof(InputEventPtr)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InputControlList`1), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(InputControlScheme), Member = "FindControlSchemeForDevices", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TDevices", "TSchemes"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TDevices", "TSchemes", typeof(InputDevice), typeof(bool)}, ReturnType = typeof(System.Nullable`1<UnityEngine.InputSystem.InputControlScheme>))]
	[Calls(Type = typeof(InputUser), Member = "GetUnpairedInputDevices", ReturnType = typeof(UnityEngine.InputSystem.InputControlList`1<UnityEngine.InputSystem.InputDevice>))]
	[Calls(Type = typeof(InputActionMap), Member = "IsUsableWithDevice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Enumerator), Member = "get_Current", ReturnType = "TValue")]
	[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(ReadOnlyArray`1), Member = "GetEnumerator", ReturnType = "UnityEngine.InputSystem.Utilities.ReadOnlyArray`1<TValue>+Enumerator<TValue>")]
	[Calls(Type = typeof(InputActionAsset), Member = "get_actionMaps", ReturnType = typeof(UnityEngine.InputSystem.Utilities.ReadOnlyArray`1<UnityEngine.InputSystem.InputActionMap>))]
	[Calls(Type = typeof(InputActionAsset), Member = "get_controlSchemes", ReturnType = typeof(UnityEngine.InputSystem.Utilities.ReadOnlyArray`1<UnityEngine.InputSystem.InputControlScheme>))]
	[Calls(Type = typeof(PlayerInput), Member = "InitializeActions", ReturnType = typeof(void))]
	[Calls(Type = typeof(GameObject), Member = "get_activeInHierarchy", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(GameObject), Member = "GetComponentInChildren", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	private bool IsDeviceUsableWithPlayerActions(InputDevice device) { }

	[CalledBy(Type = typeof(PlayerInputManager), Member = "JoinPlayerFromAction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CallbackContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PlayerInputManager), Member = "JoinPlayerFromActionIfNotAlreadyJoined", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CallbackContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PlayerInputManager), Member = "OnUnpairedDeviceUsed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl), typeof(InputEventPtr)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(PlayerInputManager), Member = "CheckIfPlayerCanJoin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ArrayHelpers), Member = "AppendWithCapacity", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[]&), typeof(Int32&), typeof(object), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(PlayerInput), Member = "DoInstantiate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject)}, ReturnType = typeof(PlayerInput))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	public PlayerInput JoinPlayer(int playerIndex = -1, int splitScreenIndex = -1, string controlScheme = null, InputDevice pairWithDevice = null) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerInputManager), Member = "CheckIfPlayerCanJoin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ArrayHelpers), Member = "AppendWithCapacity", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[]&), typeof(Int32&), typeof(object), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(PlayerInput), Member = "DoInstantiate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject)}, ReturnType = typeof(PlayerInput))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 6)]
	public PlayerInput JoinPlayer(int playerIndex = -1, int splitScreenIndex = -1, string controlScheme = null, InputDevice[] pairWithDevices) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerInputManager), Member = "CheckIfPlayerCanJoin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CallbackContext), Member = "get_control", ReturnType = typeof(InputControl))]
	[Calls(Type = typeof(PlayerInputManager), Member = "JoinPlayer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(string), typeof(InputDevice)}, ReturnType = typeof(PlayerInput))]
	[CallsUnknownMethods(Count = 1)]
	public void JoinPlayerFromAction(CallbackContext context) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerInputManager), Member = "CheckIfPlayerCanJoin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CallbackContext), Member = "get_control", ReturnType = typeof(InputControl))]
	[Calls(Type = typeof(PlayerInput), Member = "FindFirstPairedToDevice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice)}, ReturnType = typeof(PlayerInput))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(PlayerInputManager), Member = "JoinPlayer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(string), typeof(InputDevice)}, ReturnType = typeof(PlayerInput))]
	[CallsUnknownMethods(Count = 1)]
	public void JoinPlayerFromActionIfNotAlreadyJoined(CallbackContext context) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerInputManager), Member = "CheckIfPlayerCanJoin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(NotImplementedException), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	internal void JoinPlayerFromUI() { }

	[CalledBy(Type = typeof(PlayerInput), Member = "OnEnable", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PlayerInputManager), Member = "OnEnable", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(PlayerInputManager), Member = "UpdateSplitScreen", ReturnType = typeof(void))]
	[Calls(Type = typeof(DelegateHelpers), Member = "InvokeCallbacksSafe", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CallbackArray`1<Action`1<Object>>&), typeof(object), typeof(string), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UnityEngine.Events.UnityEvent`1<System.Object>), Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Component), Member = "BroadcastMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(SendMessageOptions)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Component), Member = "SendMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(SendMessageOptions)}, ReturnType = typeof(void))]
	internal void NotifyPlayerJoined(PlayerInput player) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerInputManager), Member = "UpdateSplitScreen", ReturnType = typeof(void))]
	[Calls(Type = typeof(DelegateHelpers), Member = "InvokeCallbacksSafe", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CallbackArray`1<Action`1<Object>>&), typeof(object), typeof(string), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UnityEngine.Events.UnityEvent`1<System.Object>), Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Component), Member = "BroadcastMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(SendMessageOptions)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Component), Member = "SendMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(SendMessageOptions)}, ReturnType = typeof(void))]
	internal void NotifyPlayerLeft(PlayerInput player) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(PlayerInputManager), Member = "DisableJoining", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private void OnDisable() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Debug), Member = "LogWarning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputActionProperty), Member = "get_reference", ReturnType = typeof(InputActionReference))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputActionProperty), Member = "get_action", ReturnType = typeof(InputAction))]
	[Calls(Type = typeof(InputAction), Member = "get_actionMap", ReturnType = typeof(InputActionMap))]
	[Calls(Type = typeof(Object), Member = "Instantiate", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(InputActionAsset), Member = "FindAction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(InputAction))]
	[Calls(Type = typeof(InputActionReference), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputAction)}, ReturnType = typeof(InputActionReference))]
	[Calls(Type = typeof(InputActionProperty), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionReference)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputActionProperty), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionProperty), typeof(InputActionProperty)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(PlayerInputManager), Member = "NotifyPlayerJoined", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PlayerInput)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(PlayerInputManager), Member = "DisableJoining", ReturnType = typeof(void))]
	[Calls(Type = typeof(PlayerInputManager), Member = "EnableJoining", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 6)]
	private void OnEnable() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerInputManager), Member = "IsDeviceUsableWithPlayerActions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(PlayerInputManager), Member = "JoinPlayer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(string), typeof(InputDevice)}, ReturnType = typeof(PlayerInput))]
	private void OnUnpairedDeviceUsed(InputControl control, InputEventPtr eventPtr) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CallbackArray`1), Member = "RemoveCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TDelegate"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	public void remove_onPlayerJoined(Action<PlayerInput> value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CallbackArray`1), Member = "RemoveCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TDelegate"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	public void remove_onPlayerLeft(Action<PlayerInput> value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	private static void set_instance(PlayerInputManager value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputActionProperty), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionProperty), typeof(InputActionProperty)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(PlayerInputManager), Member = "DisableJoining", ReturnType = typeof(void))]
	[Calls(Type = typeof(PlayerInputManager), Member = "EnableJoining", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public void set_joinAction(InputActionProperty value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerInputManager), Member = "DisableJoining", ReturnType = typeof(void))]
	[Calls(Type = typeof(PlayerInputManager), Member = "EnableJoining", ReturnType = typeof(void))]
	public void set_joinBehavior(PlayerJoinBehavior value) { }

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public void set_notificationBehavior(PlayerNotifications value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public void set_playerPrefab(GameObject value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ReadOnlyArray`1), Member = "GetEnumerator", ReturnType = "UnityEngine.InputSystem.Utilities.ReadOnlyArray`1<TValue>+Enumerator<TValue>")]
	[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Enumerator), Member = "get_Current", ReturnType = "TValue")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Camera), Member = "set_rect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(PlayerInputManager), Member = "UpdateSplitScreen", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 3)]
	public void set_splitScreen(bool value) { }

	[CalledBy(Type = typeof(PlayerInput), Member = "OnDisable", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PlayerInputManager), Member = "set_splitScreen", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PlayerInputManager), Member = "NotifyPlayerJoined", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PlayerInput)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PlayerInputManager), Member = "NotifyPlayerLeft", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PlayerInput)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(ReadOnlyArray`1), Member = "GetEnumerator", ReturnType = "UnityEngine.InputSystem.Utilities.ReadOnlyArray`1<TValue>+Enumerator<TValue>")]
	[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Enumerator), Member = "get_Current", ReturnType = "TValue")]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Debug), Member = "LogWarning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Camera), Member = "set_rect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 7)]
	[ContainsUnimplementedInstructions]
	private void UpdateSplitScreen() { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	private void ValidateInputActionAsset() { }

}

