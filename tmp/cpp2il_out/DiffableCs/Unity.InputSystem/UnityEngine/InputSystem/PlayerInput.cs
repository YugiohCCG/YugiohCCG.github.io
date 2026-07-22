namespace UnityEngine.InputSystem;

[AddComponentMenu("Input/Player Input")]
[DisallowMultipleComponent]
[HelpURL("https://docs.unity3d.com/Packages/com.unity.inputsystem@1.19/manual/PlayerInput.html")]
public class PlayerInput : MonoBehaviour
{
	internal class ActionEvent : UnityEvent<CallbackContext>
	{
		[SerializeField]
		private string m_ActionId; //Field offset: 0x30
		[SerializeField]
		private string m_ActionName; //Field offset: 0x38

		public string actionId
		{
			[CallerCount(Count = 62)]
			[DeduplicatedMethod]
			 get { } //Length: 5
		}

		public string actionName
		{
			[CallerCount(Count = 38)]
			[DeduplicatedMethod]
			 get { } //Length: 5
		}

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		public ActionEvent() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InputAction), Member = "get_isSingletonAction", ReturnType = typeof(bool))]
		[Calls(Type = typeof(InputAction), Member = "get_actionMap", ReturnType = typeof(InputActionMap))]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(InputAction), Member = "get_id", ReturnType = typeof(Guid))]
		[Calls(Type = typeof(Guid), Member = "ToString", ReturnType = typeof(string))]
		[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 15)]
		public ActionEvent(InputAction action) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Guid), Member = "ToString", ReturnType = typeof(string))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		public ActionEvent(Guid actionGUID, string name = null) { }

		[CallerCount(Count = 62)]
		[DeduplicatedMethod]
		public string get_actionId() { }

		[CallerCount(Count = 38)]
		[DeduplicatedMethod]
		public string get_actionName() { }

	}

	internal class ControlsChangedEvent : UnityEvent<PlayerInput>
	{

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		public ControlsChangedEvent() { }

	}

	internal class DeviceLostEvent : UnityEvent<PlayerInput>
	{

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		public DeviceLostEvent() { }

	}

	internal class DeviceRegainedEvent : UnityEvent<PlayerInput>
	{

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		public DeviceRegainedEvent() { }

	}

	public const string DeviceLostMessage = "OnDeviceLost"; //Field offset: 0x0
	public const string DeviceRegainedMessage = "OnDeviceRegained"; //Field offset: 0x0
	public const string ControlsChangedMessage = "OnControlsChanged"; //Field offset: 0x0
	internal static int s_AllActivePlayersCount; //Field offset: 0x0
	internal static PlayerInput[] s_AllActivePlayers; //Field offset: 0x8
	private static Action<InputUser, InputUserChange, InputDevice> s_UserChangeDelegate; //Field offset: 0x10
	private static int s_InitPairWithDevicesCount; //Field offset: 0x18
	private static InputDevice[] s_InitPairWithDevices; //Field offset: 0x20
	private static int s_InitPlayerIndex; //Field offset: 0x28
	private static int s_InitSplitScreenIndex; //Field offset: 0x2C
	private static string s_InitControlScheme; //Field offset: 0x30
	internal static bool s_DestroyIfDeviceSetupUnsuccessful; //Field offset: 0x38
	private int m_AllMapsHashCode; //Field offset: 0x20
	[SerializeField]
	[Tooltip("Input actions associated with the player.")]
	internal InputActionAsset m_Actions; //Field offset: 0x28
	[SerializeField]
	[Tooltip("Determine how notifications should be sent when an input-related event associated with the player happens.")]
	internal PlayerNotifications m_NotificationBehavior; //Field offset: 0x30
	[SerializeField]
	[Tooltip("UI InputModule that should have it's input actions synchronized to this PlayerInput's actions.")]
	internal InputSystemUIInputModule m_UIInputModule; //Field offset: 0x38
	[SerializeField]
	[Tooltip("Event that is triggered when the PlayerInput loses a paired device (e.g. its battery runs out).")]
	internal DeviceLostEvent m_DeviceLostEvent; //Field offset: 0x40
	[SerializeField]
	internal DeviceRegainedEvent m_DeviceRegainedEvent; //Field offset: 0x48
	[SerializeField]
	internal ControlsChangedEvent m_ControlsChangedEvent; //Field offset: 0x50
	[SerializeField]
	internal ActionEvent[] m_ActionEvents; //Field offset: 0x58
	[SerializeField]
	internal bool m_NeverAutoSwitchControlSchemes; //Field offset: 0x60
	[SerializeField]
	internal string m_DefaultControlScheme; //Field offset: 0x68
	[SerializeField]
	internal string m_DefaultActionMap; //Field offset: 0x70
	[SerializeField]
	internal int m_SplitScreenIndex; //Field offset: 0x78
	[SerializeField]
	[Tooltip("Reference to the player's view camera. Note that this is only required when using split-screen and/or per-player UIs. Otherwise it is safe to leave this property uninitialized.")]
	internal Camera m_Camera; //Field offset: 0x80
	private InputValue m_InputValueObject; //Field offset: 0x88
	internal InputActionMap m_CurrentActionMap; //Field offset: 0x90
	private int m_PlayerIndex; //Field offset: 0x98
	private bool m_InputActive; //Field offset: 0x9C
	private bool m_Enabled; //Field offset: 0x9D
	internal bool m_ActionsInitialized; //Field offset: 0x9E
	private Dictionary<String, String> m_ActionMessageNames; //Field offset: 0xA0
	private InputUser m_InputUser; //Field offset: 0xA8
	private Action<CallbackContext> m_ActionTriggeredDelegate; //Field offset: 0xB0
	private CallbackArray<Action`1<PlayerInput>> m_DeviceLostCallbacks; //Field offset: 0xB8
	private CallbackArray<Action`1<PlayerInput>> m_DeviceRegainedCallbacks; //Field offset: 0x108
	private CallbackArray<Action`1<PlayerInput>> m_ControlsChangedCallbacks; //Field offset: 0x158
	private CallbackArray<Action`1<CallbackContext>> m_ActionTriggeredCallbacks; //Field offset: 0x1A8
	private Action<InputControl, InputEventPtr> m_UnpairedDeviceUsedDelegate; //Field offset: 0x1F8
	private Func<InputDevice, InputEventPtr, Boolean> m_PreFilterUnpairedDeviceUsedDelegate; //Field offset: 0x200
	private bool m_OnUnpairedDeviceUsedHooked; //Field offset: 0x208
	private Action<InputDevice, InputDeviceChange> m_DeviceChangeDelegate; //Field offset: 0x210
	private bool m_OnDeviceChangeHooked; //Field offset: 0x218

	public event Action<CallbackContext> onActionTriggered
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

	public event Action<PlayerInput> onControlsChanged
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

	public event Action<PlayerInput> onDeviceLost
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

	public event Action<PlayerInput> onDeviceRegained
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

	public ReadOnlyArray<ActionEvent> actionEvents
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ReadOnlyArray`1), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TValue[]"}, ReturnType = "UnityEngine.InputSystem.Utilities.ReadOnlyArray`1<TValue>")]
		 get { } //Length: 87
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(PlayerInput), Member = "UninitializeActions", ReturnType = typeof(void))]
		[Calls(Type = typeof(ReadOnlyArray`1), Member = "ToArray", ReturnType = "TValue[]")]
		[Calls(Type = typeof(PlayerInput), Member = "InitializeActions", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		 set { } //Length: 124
	}

	public InputActionAsset actions
	{
		[CalledBy(Type = typeof(PlayerInput), Member = "OnUnpairedDeviceUsed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl), typeof(InputEventPtr)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
		[Calls(Type = typeof(GameObject), Member = "get_activeInHierarchy", ReturnType = typeof(bool))]
		[Calls(Type = typeof(PlayerInput), Member = "InitializeActions", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 69
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(InputActionAsset), Member = "Disable", ReturnType = typeof(void))]
		[Calls(Type = typeof(PlayerInput), Member = "UninitializeActions", ReturnType = typeof(void))]
		[Calls(Type = typeof(Dictionary`2), Member = "Clear", ReturnType = typeof(void))]
		[Calls(Type = typeof(PlayerInput), Member = "AssignUserAndDevices", ReturnType = typeof(void))]
		[Calls(Type = typeof(PlayerInput), Member = "InitializeActions", ReturnType = typeof(void))]
		[Calls(Type = typeof(PlayerInput), Member = "ActivateInput", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 2)]
		 set { } //Length: 319
	}

	[Obsolete("Use inputIsActive instead.")]
	public bool active
	{
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 8
	}

	public static ReadOnlyArray<PlayerInput> all
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		 get { } //Length: 129
	}

	public Camera camera
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 8
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 set { } //Length: 16
	}

	public ControlsChangedEvent controlsChangedEvent
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 138
	}

	public InputActionMap currentActionMap
	{
		[CallerCount(Count = 57)]
		[DeduplicatedMethod]
		 get { } //Length: 8
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InputActionMap), Member = "Disable", ReturnType = typeof(void))]
		[Calls(Type = typeof(InputActionMap), Member = "Enable", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 2)]
		 set { } //Length: 125
	}

	public string currentControlScheme
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InputUser), Member = "get_valid", ReturnType = typeof(bool))]
		[Calls(Type = typeof(InputUser), Member = "get_controlScheme", ReturnType = typeof(System.Nullable`1<UnityEngine.InputSystem.InputControlScheme>))]
		 get { } //Length: 164
	}

	public string defaultActionMap
	{
		[CallerCount(Count = 9)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 set { } //Length: 13
	}

	public string defaultControlScheme
	{
		[CallerCount(Count = 22)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 set { } //Length: 13
	}

	public DeviceLostEvent deviceLostEvent
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 138
	}

	public DeviceRegainedEvent deviceRegainedEvent
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 138
	}

	public ReadOnlyArray<InputDevice> devices
	{
		[CalledBy(Type = typeof(PlayerInput), Member = "GetDevice", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TDevice"}, ReturnType = "TDevice")]
		[CalledBy(Type = typeof(PlayerInput), Member = "OnUnpairedDeviceUsed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl), typeof(InputEventPtr)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(OnScreenControl), Member = "OnEnable", ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(InputUser), Member = "get_valid", ReturnType = typeof(bool))]
		[Calls(Type = typeof(InputUser), Member = "get_pairedDevices", ReturnType = typeof(UnityEngine.InputSystem.Utilities.ReadOnlyArray`1<UnityEngine.InputSystem.InputDevice>))]
		 get { } //Length: 164
	}

	public bool hasMissingRequiredDevices
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InputUser), Member = "get_valid", ReturnType = typeof(bool))]
		[Calls(Type = typeof(InputUser), Member = "get_index", ReturnType = typeof(int))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		 get { } //Length: 249
	}

	public bool inputIsActive
	{
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 8
	}

	public static bool isSinglePlayer
	{
		[CalledBy(Type = typeof(PlayerInput), Member = "OnEnable", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(PlayerInput), Member = "OnUnpairedDeviceUsed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl), typeof(InputEventPtr)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(PlayerInput), Member = "OnDeviceChange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice), typeof(InputDeviceChange)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(OnScreenControl), Member = "OnEnable", ReturnType = typeof(void))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 261
	}

	public bool neverAutoSwitchControlSchemes
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(PlayerInput), Member = "StartListeningForUnpairedDeviceActivity", ReturnType = typeof(void))]
		[Calls(Type = typeof(PlayerInput), Member = "StopListeningForUnpairedDeviceActivity", ReturnType = typeof(void))]
		 set { } //Length: 51
	}

	public PlayerNotifications notificationBehavior
	{
		[CallerCount(Count = 3)]
		[DeduplicatedMethod]
		 get { } //Length: 4
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(PlayerInput), Member = "UninitializeActions", ReturnType = typeof(void))]
		[Calls(Type = typeof(PlayerInput), Member = "InitializeActions", ReturnType = typeof(void))]
		 set { } //Length: 69
	}

	public int playerIndex
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 7
	}

	public int splitScreenIndex
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 4
	}

	public InputSystemUIInputModule uiInputModule
	{
		[CallerCount(Count = 38)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(InputSystemUIInputModule), Member = "set_actionsAsset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionAsset)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 2)]
		 set { } //Length: 373
	}

	public InputUser user
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 7
	}

	[CallerCount(Count = 0)]
	private static PlayerInput() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public PlayerInput() { }

	[CalledBy(Type = typeof(PlayerInput), Member = "set_actions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionAsset)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PlayerInput), Member = "OnEnable", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(PlayerInput), Member = "UpdateDelegates", ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(PlayerInput), Member = "SwitchCurrentActionMap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputActionMap), Member = "Enable", ReturnType = typeof(void))]
	public void ActivateInput() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CallbackArray`1), Member = "AddCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TDelegate"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	public void add_onActionTriggered(Action<CallbackContext> value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CallbackArray`1), Member = "AddCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TDelegate"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	public void add_onControlsChanged(Action<PlayerInput> value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CallbackArray`1), Member = "AddCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TDelegate"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	public void add_onDeviceLost(Action<PlayerInput> value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CallbackArray`1), Member = "AddCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TDelegate"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	public void add_onDeviceRegained(Action<PlayerInput> value) { }

	[CalledBy(Type = typeof(PlayerInput), Member = "OnEnable", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Math), Member = "Min", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Math), Member = "Max", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 2)]
	private void AssignPlayerIndex() { }

	[CalledBy(Type = typeof(PlayerInput), Member = "set_actions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionAsset)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PlayerInput), Member = "OnEnable", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(InputUser), Member = "PerformPairingWithDevice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice), typeof(InputUser), typeof(InputUserPairingOptions)}, ReturnType = typeof(InputUser))]
	[Calls(Type = typeof(PlayerInput), Member = "HaveBindingForDevice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputControlList`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "TControl")]
	[Calls(Type = typeof(InputUser), Member = "GetUnpairedInputDevices", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControlList`1<InputDevice>&)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(InputControlList`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Allocator), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputControlList`1), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(Debug), Member = "LogWarning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Object), Member = "get_name", ReturnType = typeof(string))]
	[Calls(Type = typeof(InputSystem), Member = "get_devices", ReturnType = typeof(UnityEngine.InputSystem.Utilities.ReadOnlyArray`1<UnityEngine.InputSystem.InputDevice>))]
	[Calls(Type = typeof(InputControlScheme), Member = "FindControlSchemeForDevices", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TDevices", "TSchemes"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TDevices", "TSchemes", typeof(InputDevice), typeof(bool)}, ReturnType = typeof(System.Nullable`1<UnityEngine.InputSystem.InputControlScheme>))]
	[Calls(Type = typeof(InputUser), Member = "GetUnpairedInputDevices", ReturnType = typeof(UnityEngine.InputSystem.InputControlList`1<UnityEngine.InputSystem.InputDevice>))]
	[Calls(Type = typeof(InputControlScheme), Member = "FindControlSchemeForDevices", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityEngine.InputSystem.Utilities.ReadOnlyArray`1<System.Object>), typeof(UnityEngine.InputSystem.Utilities.ReadOnlyArray`1<UnityEngine.InputSystem.InputControlScheme>)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityEngine.InputSystem.Utilities.ReadOnlyArray`1<System.Object>), typeof(UnityEngine.InputSystem.Utilities.ReadOnlyArray`1<UnityEngine.InputSystem.InputControlScheme>), typeof(InputDevice), typeof(bool)}, ReturnType = typeof(System.Nullable`1<UnityEngine.InputSystem.InputControlScheme>))]
	[Calls(Type = typeof(InputUser), Member = "get_controlScheme", ReturnType = typeof(System.Nullable`1<UnityEngine.InputSystem.InputControlScheme>))]
	[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(PlayerInput), Member = "TryToActivateControlScheme", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControlScheme)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Nullable`1), Member = "get_Value", ReturnType = "T")]
	[Calls(Type = typeof(InputActionAsset), Member = "FindControlScheme", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(System.Nullable`1<UnityEngine.InputSystem.InputControlScheme>))]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputActionAsset), Member = "get_controlSchemes", ReturnType = typeof(UnityEngine.InputSystem.Utilities.ReadOnlyArray`1<UnityEngine.InputSystem.InputControlScheme>))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputUser), Member = "UnpairDevices", ReturnType = typeof(void))]
	[Calls(Type = typeof(InputUser), Member = "get_valid", ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputUser), Member = "AssociateActionsWithUser", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IInputActionCollection)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	private void AssignUserAndDevices() { }

	[CalledBy(Type = typeof(PlayerInput), Member = "UpdateDelegates", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PlayerInput), Member = "InitializeActions", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PlayerInput), Member = "OnActionTriggered", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CallbackContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(Dictionary`2), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(InputAction), Member = "MakeSureIdIsInPlace", ReturnType = typeof(string))]
	[Calls(Type = typeof(CSharpCodeHelpers), Member = "MakeTypeName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 11)]
	private void CacheMessageNames() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Dictionary`2), Member = "Clear", ReturnType = typeof(void))]
	private void ClearCaches() { }

	[CalledBy(Type = typeof(PlayerInput), Member = "InitializeActions", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "Instantiate", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(InputActionAsset), Member = "get_actionMaps", ReturnType = typeof(UnityEngine.InputSystem.Utilities.ReadOnlyArray`1<UnityEngine.InputSystem.InputActionMap>))]
	[Calls(Type = typeof(ReadOnlyArray`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "TValue")]
	[Calls(Type = typeof(InputActionMap), Member = "get_bindings", ReturnType = typeof(UnityEngine.InputSystem.Utilities.ReadOnlyArray`1<UnityEngine.InputSystem.InputBinding>))]
	[Calls(Type = typeof(InputActionRebindingExtensions), Member = "ApplyBindingOverride", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionMap), typeof(int), typeof(InputBinding)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	private void CopyActionAssetAndApplyBindingOverrides() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputActionMap), Member = "Disable", ReturnType = typeof(void))]
	[DeduplicatedMethod]
	public void DeactivateInput() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CallbackContext), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	public void DebugLogAction(CallbackContext context) { }

	[CalledBy(Type = typeof(PlayerInput), Member = "Instantiate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(int), typeof(string), typeof(int), typeof(InputDevice)}, ReturnType = typeof(PlayerInput))]
	[CalledBy(Type = typeof(PlayerInput), Member = "Instantiate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(int), typeof(string), typeof(int), typeof(InputDevice[])}, ReturnType = typeof(PlayerInput))]
	[CalledBy(Type = typeof(PlayerInputManager), Member = "JoinPlayer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(string), typeof(InputDevice)}, ReturnType = typeof(PlayerInput))]
	[CalledBy(Type = typeof(PlayerInputManager), Member = "JoinPlayer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(string), typeof(InputDevice[])}, ReturnType = typeof(PlayerInput))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Object), Member = "Instantiate", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(GameObject), Member = "SetActive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GameObject), Member = "GetComponentInChildren", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputUser), Member = "get_valid", ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputUser), Member = "get_index", ReturnType = typeof(int))]
	[Calls(Type = typeof(Object), Member = "DestroyImmediate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	private static PlayerInput DoInstantiate(GameObject prefab) { }

	[CalledBy(Type = typeof(PlayerInputManager), Member = "JoinPlayerFromActionIfNotAlreadyJoined", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CallbackContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InputUser), Member = "get_valid", ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputUser), Member = "get_pairedDevices", ReturnType = typeof(UnityEngine.InputSystem.Utilities.ReadOnlyArray`1<UnityEngine.InputSystem.InputDevice>))]
	[Calls(Type = typeof(ReadOnlyArrayExtensions), Member = "ContainsReference", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.InputSystem.Utilities.ReadOnlyArray`1<TValue>", "TValue"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 6)]
	public static PlayerInput FindFirstPairedToDevice(InputDevice device) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ReadOnlyArray`1), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TValue[]"}, ReturnType = "UnityEngine.InputSystem.Utilities.ReadOnlyArray`1<TValue>")]
	public ReadOnlyArray<ActionEvent> get_actionEvents() { }

	[CalledBy(Type = typeof(PlayerInput), Member = "OnUnpairedDeviceUsed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl), typeof(InputEventPtr)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(GameObject), Member = "get_activeInHierarchy", ReturnType = typeof(bool))]
	[Calls(Type = typeof(PlayerInput), Member = "InitializeActions", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public InputActionAsset get_actions() { }

	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	public bool get_active() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static ReadOnlyArray<PlayerInput> get_all() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public Camera get_camera() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public ControlsChangedEvent get_controlsChangedEvent() { }

	[CallerCount(Count = 57)]
	[DeduplicatedMethod]
	public InputActionMap get_currentActionMap() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputUser), Member = "get_valid", ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputUser), Member = "get_controlScheme", ReturnType = typeof(System.Nullable`1<UnityEngine.InputSystem.InputControlScheme>))]
	public string get_currentControlScheme() { }

	[CallerCount(Count = 9)]
	[DeduplicatedMethod]
	public string get_defaultActionMap() { }

	[CallerCount(Count = 22)]
	[DeduplicatedMethod]
	public string get_defaultControlScheme() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public DeviceLostEvent get_deviceLostEvent() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public DeviceRegainedEvent get_deviceRegainedEvent() { }

	[CalledBy(Type = typeof(PlayerInput), Member = "GetDevice", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TDevice"}, ReturnType = "TDevice")]
	[CalledBy(Type = typeof(PlayerInput), Member = "OnUnpairedDeviceUsed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl), typeof(InputEventPtr)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(OnScreenControl), Member = "OnEnable", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(InputUser), Member = "get_valid", ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputUser), Member = "get_pairedDevices", ReturnType = typeof(UnityEngine.InputSystem.Utilities.ReadOnlyArray`1<UnityEngine.InputSystem.InputDevice>))]
	public ReadOnlyArray<InputDevice> get_devices() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputUser), Member = "get_valid", ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputUser), Member = "get_index", ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public bool get_hasMissingRequiredDevices() { }

	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	public bool get_inputIsActive() { }

	[CalledBy(Type = typeof(PlayerInput), Member = "OnEnable", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PlayerInput), Member = "OnUnpairedDeviceUsed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl), typeof(InputEventPtr)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PlayerInput), Member = "OnDeviceChange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice), typeof(InputDeviceChange)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(OnScreenControl), Member = "OnEnable", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public static bool get_isSinglePlayer() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public bool get_neverAutoSwitchControlSchemes() { }

	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	public PlayerNotifications get_notificationBehavior() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public int get_playerIndex() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public int get_splitScreenIndex() { }

	[CallerCount(Count = 38)]
	[DeduplicatedMethod]
	public InputSystemUIInputModule get_uiInputModule() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public InputUser get_user() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerInput), Member = "get_devices", ReturnType = typeof(UnityEngine.InputSystem.Utilities.ReadOnlyArray`1<UnityEngine.InputSystem.InputDevice>))]
	[Calls(Type = typeof(ReadOnlyArray`1), Member = "GetEnumerator", ReturnType = "UnityEngine.InputSystem.Utilities.ReadOnlyArray`1<TValue>+Enumerator<TValue>")]
	[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Enumerator), Member = "get_Current", ReturnType = "TValue")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	[DeduplicatedMethod]
	public TDevice GetDevice() { }

	[CalledBy(Type = typeof(OnScreenControl), Member = "OnEnable", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static PlayerInput GetPlayerByIndex(int playerIndex) { }

	[CalledBy(Type = typeof(PlayerInput), Member = "OnEnable", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PlayerInput), Member = "OnUserChange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputUser), typeof(InputUserChange), typeof(InputDevice)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(DelegateHelpers), Member = "InvokeCallbacksSafe", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CallbackArray`1<Action`1<Object>>&), typeof(object), typeof(string), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UnityEngine.Events.UnityEvent`1<System.Object>), Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Component), Member = "BroadcastMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(SendMessageOptions)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Component), Member = "SendMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(SendMessageOptions)}, ReturnType = typeof(void))]
	private void HandleControlsChanged() { }

	[CalledBy(Type = typeof(PlayerInput), Member = "OnUserChange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputUser), typeof(InputUserChange), typeof(InputDevice)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DelegateHelpers), Member = "InvokeCallbacksSafe", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CallbackArray`1<Action`1<Object>>&), typeof(object), typeof(string), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UnityEngine.Events.UnityEvent`1<System.Object>), Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Component), Member = "BroadcastMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(SendMessageOptions)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Component), Member = "SendMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(SendMessageOptions)}, ReturnType = typeof(void))]
	private void HandleDeviceLost() { }

	[CalledBy(Type = typeof(PlayerInput), Member = "OnUserChange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputUser), typeof(InputUserChange), typeof(InputDevice)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DelegateHelpers), Member = "InvokeCallbacksSafe", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CallbackArray`1<Action`1<Object>>&), typeof(object), typeof(string), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UnityEngine.Events.UnityEvent`1<System.Object>), Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Component), Member = "BroadcastMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(SendMessageOptions)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Component), Member = "SendMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(SendMessageOptions)}, ReturnType = typeof(void))]
	private void HandleDeviceRegained() { }

	[CalledBy(Type = typeof(PlayerInput), Member = "AssignUserAndDevices", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PlayerInput), Member = "OnDeviceChange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice), typeof(InputDeviceChange)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputActionAsset), Member = "get_actionMaps", ReturnType = typeof(UnityEngine.InputSystem.Utilities.ReadOnlyArray`1<UnityEngine.InputSystem.InputActionMap>))]
	[Calls(Type = typeof(ReadOnlyArray`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "TValue")]
	[Calls(Type = typeof(InputActionMap), Member = "IsUsableWithDevice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private bool HaveBindingForDevice(InputDevice device) { }

	[CalledBy(Type = typeof(PlayerInput), Member = "get_actions", ReturnType = typeof(InputActionAsset))]
	[CalledBy(Type = typeof(PlayerInput), Member = "set_actions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionAsset)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PlayerInput), Member = "set_notificationBehavior", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PlayerNotifications)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PlayerInput), Member = "set_actionEvents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityEngine.InputSystem.Utilities.ReadOnlyArray`1<UnityEngine.InputSystem.PlayerInput+ActionEvent>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PlayerInput), Member = "SwitchCurrentControlScheme", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice[])}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(PlayerInput), Member = "OnEnable", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PlayerInput), Member = "OnPreFilterUnpairedDeviceUsed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice), typeof(InputEventPtr)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(PlayerInputManager), Member = "IsDeviceUsableWithPlayerActions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(PlayerInput), Member = "CacheMessageNames", ReturnType = typeof(void))]
	[Calls(Type = typeof(InputAction), Member = "add_started", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<UnityEngine.InputSystem.InputAction+CallbackContext>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputAction), Member = "add_canceled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<UnityEngine.InputSystem.InputAction+CallbackContext>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputAction), Member = "add_performed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<UnityEngine.InputSystem.InputAction+CallbackContext>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputActionAsset), Member = "FindAction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(InputAction))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(PlayerInput), Member = "InstallOnActionTriggeredHook", ReturnType = typeof(void))]
	[Calls(Type = typeof(InputSystemUIInputModule), Member = "set_actionsAsset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionAsset)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(PlayerInput), Member = "CopyActionAssetAndApplyBindingOverrides", ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	private void InitializeActions() { }

	[CalledBy(Type = typeof(PlayerInput), Member = "UpdateDelegates", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PlayerInput), Member = "InitializeActions", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(InputActionAsset), Member = "get_actionMaps", ReturnType = typeof(UnityEngine.InputSystem.Utilities.ReadOnlyArray`1<UnityEngine.InputSystem.InputActionMap>))]
	[Calls(Type = typeof(ReadOnlyArray`1), Member = "GetEnumerator", ReturnType = "UnityEngine.InputSystem.Utilities.ReadOnlyArray`1<TValue>+Enumerator<TValue>")]
	[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Enumerator), Member = "get_Current", ReturnType = "TValue")]
	[Calls(Type = typeof(InputActionMap), Member = "add_actionTriggered", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<UnityEngine.InputSystem.InputAction+CallbackContext>)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	private void InstallOnActionTriggeredHook() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ArrayHelpers), Member = "AppendWithCapacity", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[]&), typeof(Int32&), typeof(object), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(PlayerInput), Member = "DoInstantiate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject)}, ReturnType = typeof(PlayerInput))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 6)]
	public static PlayerInput Instantiate(GameObject prefab, int playerIndex = -1, string controlScheme = null, int splitScreenIndex = -1, InputDevice[] pairWithDevices) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ArrayHelpers), Member = "AppendWithCapacity", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[]&), typeof(Int32&), typeof(object), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(PlayerInput), Member = "DoInstantiate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject)}, ReturnType = typeof(PlayerInput))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	public static PlayerInput Instantiate(GameObject prefab, int playerIndex = -1, string controlScheme = null, int splitScreenIndex = -1, InputDevice pairWithDevice = null) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CallbackContext), Member = "get_action", ReturnType = typeof(InputAction))]
	[Calls(Type = typeof(CallbackContext), Member = "get_performed", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CallbackContext), Member = "get_canceled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(PlayerInput), Member = "CacheMessageNames", ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(Nullable`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Component), Member = "SendMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(SendMessageOptions)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Component), Member = "BroadcastMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(SendMessageOptions)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DelegateHelpers), Member = "InvokeCallbacksSafe", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CallbackContext)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CallbackArray`1<Action`1<CallbackContext>>&), typeof(CallbackContext), typeof(string), typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	private void OnActionTriggered(CallbackContext context) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerInput), Member = "get_isSinglePlayer", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputActionAsset), Member = "get_controlSchemes", ReturnType = typeof(UnityEngine.InputSystem.Utilities.ReadOnlyArray`1<UnityEngine.InputSystem.InputControlScheme>))]
	[Calls(Type = typeof(PlayerInput), Member = "HaveBindingForDevice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputUser), Member = "get_valid", ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputUser), Member = "PerformPairingWithDevice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice), typeof(InputUser), typeof(InputUserPairingOptions)}, ReturnType = typeof(InputUser))]
	[CallsUnknownMethods(Count = 1)]
	private void OnDeviceChange(InputDevice device, InputDeviceChange change) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerInput), Member = "UninitializeActions", ReturnType = typeof(void))]
	[Calls(Type = typeof(InputActionAsset), Member = "set_devices", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Nullable`1<UnityEngine.InputSystem.Utilities.ReadOnlyArray`1<UnityEngine.InputSystem.InputDevice>>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputUser), Member = "RemoveUser", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputUser), Member = "get_index", ReturnType = typeof(int))]
	[Calls(Type = typeof(InputUser), Member = "UnpairDevices", ReturnType = typeof(void))]
	[Calls(Type = typeof(InputUser), Member = "get_valid", ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputActionMap), Member = "Disable", ReturnType = typeof(void))]
	[Calls(Type = typeof(InputActionRebindingExtensions), Member = "DeferBindingResolution", ReturnType = typeof(DeferBindingResolutionWrapper))]
	[Calls(Type = typeof(Component), Member = "SendMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(SendMessageOptions)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Component), Member = "BroadcastMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(SendMessageOptions)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UnityEngine.Events.UnityEvent`1<System.Object>), Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DelegateHelpers), Member = "InvokeCallbacksSafe", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CallbackArray`1<Action`1<Object>>&), typeof(object), typeof(string), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(PlayerInputManager), Member = "UpdateSplitScreen", ReturnType = typeof(void))]
	[Calls(Type = typeof(InputSystem), Member = "remove_onDeviceChange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`2<UnityEngine.InputSystem.InputDevice, UnityEngine.InputSystem.InputDeviceChange>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(PlayerInput), Member = "StopListeningForUnpairedDeviceActivity", ReturnType = typeof(void))]
	[Calls(Type = typeof(CallbackArray`1), Member = "RemoveCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TDelegate"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArrayHelpers), Member = "EraseAtWithCapacity", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[]), typeof(Int32&), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArrayHelpers), Member = "IndexOfReference", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TFirst", "TSecond"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TFirst[]", "TSecond", typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 8)]
	private void OnDisable() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerInputManager), Member = "NotifyPlayerJoined", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PlayerInput)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(PlayerInput), Member = "HandleControlsChanged", ReturnType = typeof(void))]
	[Calls(Type = typeof(PlayerInput), Member = "StartListeningForUnpairedDeviceActivity", ReturnType = typeof(void))]
	[Calls(Type = typeof(InputSystem), Member = "add_onDeviceChange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`2<UnityEngine.InputSystem.InputDevice, UnityEngine.InputSystem.InputDeviceChange>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Action`2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputActionAsset), Member = "get_controlSchemes", ReturnType = typeof(UnityEngine.InputSystem.Utilities.ReadOnlyArray`1<UnityEngine.InputSystem.InputControlScheme>))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(PlayerInput), Member = "get_isSinglePlayer", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CallbackArray`1), Member = "AddCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TDelegate"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Action`3<UnityEngine.InputSystem.Users.InputUser, System.Int32Enum, System.Object>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArrayHelpers), Member = "SwapElements", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TValue[]", typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArrayHelpers), Member = "AppendWithCapacity", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[]&), typeof(Int32&), typeof(object), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(PlayerInput), Member = "ActivateInput", ReturnType = typeof(void))]
	[Calls(Type = typeof(PlayerInput), Member = "AssignUserAndDevices", ReturnType = typeof(void))]
	[Calls(Type = typeof(PlayerInput), Member = "InitializeActions", ReturnType = typeof(void))]
	[Calls(Type = typeof(PlayerInput), Member = "AssignPlayerIndex", ReturnType = typeof(void))]
	[Calls(Type = typeof(InputActionRebindingExtensions), Member = "DeferBindingResolution", ReturnType = typeof(DeferBindingResolutionWrapper))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 11)]
	private void OnEnable() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ReadOnlyArray`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "TValue")]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(GameObject), Member = "get_activeInHierarchy", ReturnType = typeof(bool))]
	[Calls(Type = typeof(PlayerInput), Member = "InitializeActions", ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(OnScreenControl), Member = "get_HasAnyActive", ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputActionAsset), Member = "IsUsableWithDevice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private static bool OnPreFilterUnpairedDeviceUsed(InputDevice device, InputEventPtr eventPtr) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputControlList`1), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(MatchResult), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(InputUser), Member = "ActivateControlScheme", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControlScheme)}, ReturnType = typeof(ControlSchemeChangeSyntax))]
	[Calls(Type = typeof(InputUser), Member = "AssociateActionsWithUser", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IInputActionCollection)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(PlayerInput), Member = "get_actions", ReturnType = typeof(InputActionAsset))]
	[Calls(Type = typeof(InputUser), Member = "PerformPairingWithDevice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice), typeof(InputUser), typeof(InputUserPairingOptions)}, ReturnType = typeof(InputUser))]
	[Calls(Type = typeof(InputControlList`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "TControl")]
	[Calls(Type = typeof(MatchResult), Member = "get_devices", ReturnType = typeof(UnityEngine.InputSystem.InputControlList`1<UnityEngine.InputSystem.InputDevice>))]
	[Calls(Type = typeof(InputUser), Member = "UnpairDevices", ReturnType = typeof(void))]
	[Calls(Type = typeof(InputUser), Member = "get_valid", ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputControlScheme), Member = "FindControlSchemeForDevices", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TDevices", "TSchemes"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TDevices", "TSchemes", typeof(InputControlScheme&), typeof(MatchResult&), typeof(InputDevice), typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputActionAsset), Member = "get_controlSchemes", ReturnType = typeof(UnityEngine.InputSystem.Utilities.ReadOnlyArray`1<UnityEngine.InputSystem.InputControlScheme>))]
	[Calls(Type = typeof(InputControlList`1), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TControl"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(PlayerInput), Member = "get_devices", ReturnType = typeof(UnityEngine.InputSystem.Utilities.ReadOnlyArray`1<UnityEngine.InputSystem.InputDevice>))]
	[Calls(Type = typeof(InputControlList`1), Member = "SwapElements", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputControlList`1), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TControl"}, ReturnType = typeof(int))]
	[Calls(Type = typeof(InputUser), Member = "GetUnpairedInputDevices", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControlList`1<InputDevice>&)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(InputControlList`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Allocator), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputActionRebindingExtensions), Member = "DeferBindingResolution", ReturnType = typeof(DeferBindingResolutionWrapper))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ReadOnlyArray`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "TValue")]
	[Calls(Type = typeof(PlayerInput), Member = "get_isSinglePlayer", ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 8)]
	private void OnUnpairedDeviceUsed(InputControl control, InputEventPtr eventPtr) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerInput), Member = "HandleDeviceRegained", ReturnType = typeof(void))]
	[Calls(Type = typeof(PlayerInput), Member = "HandleDeviceLost", ReturnType = typeof(void))]
	[Calls(Type = typeof(PlayerInput), Member = "HandleControlsChanged", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	private static void OnUserChange(InputUser user, InputUserChange change, InputDevice device) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputActionMap), Member = "Disable", ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Obsolete("Use DeactivateInput instead.")]
	public void PassivateInput() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CallbackArray`1), Member = "RemoveCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TDelegate"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	public void remove_onActionTriggered(Action<CallbackContext> value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CallbackArray`1), Member = "RemoveCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TDelegate"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	public void remove_onControlsChanged(Action<PlayerInput> value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CallbackArray`1), Member = "RemoveCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TDelegate"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	public void remove_onDeviceLost(Action<PlayerInput> value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CallbackArray`1), Member = "RemoveCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TDelegate"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	public void remove_onDeviceRegained(Action<PlayerInput> value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerInput), Member = "UninitializeActions", ReturnType = typeof(void))]
	[Calls(Type = typeof(ReadOnlyArray`1), Member = "ToArray", ReturnType = "TValue[]")]
	[Calls(Type = typeof(PlayerInput), Member = "InitializeActions", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void set_actionEvents(ReadOnlyArray<ActionEvent> value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputActionAsset), Member = "Disable", ReturnType = typeof(void))]
	[Calls(Type = typeof(PlayerInput), Member = "UninitializeActions", ReturnType = typeof(void))]
	[Calls(Type = typeof(Dictionary`2), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(PlayerInput), Member = "AssignUserAndDevices", ReturnType = typeof(void))]
	[Calls(Type = typeof(PlayerInput), Member = "InitializeActions", ReturnType = typeof(void))]
	[Calls(Type = typeof(PlayerInput), Member = "ActivateInput", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	public void set_actions(InputActionAsset value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public void set_camera(Camera value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputActionMap), Member = "Disable", ReturnType = typeof(void))]
	[Calls(Type = typeof(InputActionMap), Member = "Enable", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	public void set_currentActionMap(InputActionMap value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public void set_defaultActionMap(string value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public void set_defaultControlScheme(string value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerInput), Member = "StartListeningForUnpairedDeviceActivity", ReturnType = typeof(void))]
	[Calls(Type = typeof(PlayerInput), Member = "StopListeningForUnpairedDeviceActivity", ReturnType = typeof(void))]
	public void set_neverAutoSwitchControlSchemes(bool value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerInput), Member = "UninitializeActions", ReturnType = typeof(void))]
	[Calls(Type = typeof(PlayerInput), Member = "InitializeActions", ReturnType = typeof(void))]
	public void set_notificationBehavior(PlayerNotifications value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputSystemUIInputModule), Member = "set_actionsAsset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionAsset)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	public void set_uiInputModule(InputSystemUIInputModule value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Action`2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputSystem), Member = "add_onDeviceChange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`2<UnityEngine.InputSystem.InputDevice, UnityEngine.InputSystem.InputDeviceChange>)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private void StartListeningForDeviceChanges() { }

	[CalledBy(Type = typeof(PlayerInput), Member = "set_neverAutoSwitchControlSchemes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PlayerInput), Member = "OnEnable", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(System.Func`3<System.Object, UnityEngine.InputSystem.LowLevel.InputEventPtr, System.Boolean>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputUser), Member = "add_onUnpairedDeviceUsed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`2<UnityEngine.InputSystem.InputControl, UnityEngine.InputSystem.LowLevel.InputEventPtr>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CallbackArray`1), Member = "AddCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TDelegate"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputUser), Member = "set_listenForUnpairedDeviceActivity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	private void StartListeningForUnpairedDeviceActivity() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputSystem), Member = "remove_onDeviceChange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`2<UnityEngine.InputSystem.InputDevice, UnityEngine.InputSystem.InputDeviceChange>)}, ReturnType = typeof(void))]
	private void StopListeningForDeviceChanges() { }

	[CalledBy(Type = typeof(PlayerInput), Member = "set_neverAutoSwitchControlSchemes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PlayerInput), Member = "OnDisable", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(InputUser), Member = "remove_onUnpairedDeviceUsed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`2<UnityEngine.InputSystem.InputControl, UnityEngine.InputSystem.LowLevel.InputEventPtr>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CallbackArray`1), Member = "RemoveCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TDelegate"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputUser), Member = "set_listenForUnpairedDeviceActivity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	private void StopListeningForUnpairedDeviceActivity() { }

	[CalledBy(Type = typeof(PlayerInput), Member = "SwitchCurrentControlScheme", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice[])}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(PlayerInput), Member = "SwitchCurrentControlScheme", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(InputDevice[])}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(InputUser), Member = "get_pairedDevices", ReturnType = typeof(UnityEngine.InputSystem.Utilities.ReadOnlyArray`1<UnityEngine.InputSystem.InputDevice>))]
	[Calls(Type = typeof(InputActionRebindingExtensions), Member = "DeferBindingResolution", ReturnType = typeof(DeferBindingResolutionWrapper))]
	[Calls(Type = typeof(InputUser), Member = "get_index", ReturnType = typeof(int))]
	[Calls(Type = typeof(ReadOnlyArray`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "TValue")]
	[Calls(Type = typeof(ArrayHelpers), Member = "ContainsReference", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TValue[]", "TValue"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputUser), Member = "UnpairDevice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ReadOnlyArrayExtensions), Member = "ContainsReference", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.InputSystem.Utilities.ReadOnlyArray`1<TValue>", "TValue"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputUser), Member = "PerformPairingWithDevice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice), typeof(InputUser), typeof(InputUserPairingOptions)}, ReturnType = typeof(InputUser))]
	[Calls(Type = typeof(Nullable`1), Member = "get_Value", ReturnType = "T")]
	[Calls(Type = typeof(InputControlScheme), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControlScheme)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputUser), Member = "ActivateControlScheme", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControlScheme)}, ReturnType = typeof(ControlSchemeChangeSyntax))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 21)]
	[ContainsUnimplementedInstructions]
	private void SwitchControlSchemeInternal(ref InputControlScheme controlScheme, InputDevice[] devices) { }

	[CalledBy(Type = typeof(PlayerInput), Member = "ActivateInput", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputActionAsset), Member = "FindActionMap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(InputActionMap))]
	[Calls(Type = typeof(InputActionMap), Member = "Disable", ReturnType = typeof(void))]
	[Calls(Type = typeof(InputActionMap), Member = "Enable", ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public void SwitchCurrentActionMap(string mapNameOrId) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputUser), Member = "FindControlScheme", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(InputControlScheme&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(PlayerInput), Member = "SwitchControlSchemeInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControlScheme&), typeof(InputDevice[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 8)]
	public void SwitchCurrentControlScheme(string controlScheme, InputDevice[] devices) { }

	[CalledBy(Type = typeof(OnScreenControl), Member = "OnEnable", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(GameObject), Member = "get_activeInHierarchy", ReturnType = typeof(bool))]
	[Calls(Type = typeof(PlayerInput), Member = "InitializeActions", ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputActionAsset), Member = "get_controlSchemes", ReturnType = typeof(UnityEngine.InputSystem.Utilities.ReadOnlyArray`1<UnityEngine.InputSystem.InputControlScheme>))]
	[Calls(Type = typeof(InputControlScheme), Member = "FindControlSchemeForDevices", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(UnityEngine.InputSystem.Utilities.ReadOnlyArray`1<UnityEngine.InputSystem.InputControlScheme>)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(UnityEngine.InputSystem.Utilities.ReadOnlyArray`1<UnityEngine.InputSystem.InputControlScheme>), typeof(InputDevice), typeof(bool)}, ReturnType = typeof(System.Nullable`1<UnityEngine.InputSystem.InputControlScheme>))]
	[Calls(Type = typeof(Nullable`1), Member = "get_Value", ReturnType = "T")]
	[Calls(Type = typeof(PlayerInput), Member = "SwitchControlSchemeInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControlScheme&), typeof(InputDevice[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 9)]
	public bool SwitchCurrentControlScheme(InputDevice[] devices) { }

	[CalledBy(Type = typeof(PlayerInput), Member = "AssignUserAndDevices", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(InputControlScheme), Member = "SupportsDevice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputUser), Member = "PerformPairingWithDevice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice), typeof(InputUser), typeof(InputUserPairingOptions)}, ReturnType = typeof(InputUser))]
	[Calls(Type = typeof(InputUser), Member = "get_valid", ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputUser), Member = "AddUser", ReturnType = typeof(int))]
	[Calls(Type = typeof(InputUser), Member = "ActivateControlScheme", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControlScheme)}, ReturnType = typeof(ControlSchemeChangeSyntax))]
	[Calls(Type = typeof(ControlSchemeChangeSyntax), Member = "AndPairRemainingDevices", ReturnType = typeof(ControlSchemeChangeSyntax))]
	[Calls(Type = typeof(InputUser), Member = "get_index", ReturnType = typeof(int))]
	[Calls(Type = typeof(InputUser), Member = "ActivateControlScheme", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(ControlSchemeChangeSyntax))]
	[Calls(Type = typeof(InputUser), Member = "UnpairDevices", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private bool TryToActivateControlScheme(InputControlScheme controlScheme) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputUser), Member = "get_valid", ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputUser), Member = "UnpairDevices", ReturnType = typeof(void))]
	[Calls(Type = typeof(InputUser), Member = "get_index", ReturnType = typeof(int))]
	[Calls(Type = typeof(InputUser), Member = "RemoveUser", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputActionAsset), Member = "set_devices", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Nullable`1<UnityEngine.InputSystem.Utilities.ReadOnlyArray`1<UnityEngine.InputSystem.InputDevice>>)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private void UnassignUserAndDevices() { }

	[CalledBy(Type = typeof(PlayerInput), Member = "set_actions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionAsset)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PlayerInput), Member = "set_notificationBehavior", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PlayerNotifications)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PlayerInput), Member = "set_actionEvents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityEngine.InputSystem.Utilities.ReadOnlyArray`1<UnityEngine.InputSystem.PlayerInput+ActionEvent>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PlayerInput), Member = "OnDisable", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(PlayerInput), Member = "UninstallOnActionTriggeredHook", ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputActionAsset), Member = "FindAction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(InputAction))]
	[Calls(Type = typeof(InputAction), Member = "remove_performed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<UnityEngine.InputSystem.InputAction+CallbackContext>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputAction), Member = "remove_canceled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<UnityEngine.InputSystem.InputAction+CallbackContext>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputAction), Member = "remove_started", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<UnityEngine.InputSystem.InputAction+CallbackContext>)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 3)]
	private void UninitializeActions() { }

	[CalledBy(Type = typeof(PlayerInput), Member = "UninitializeActions", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InputActionAsset), Member = "get_actionMaps", ReturnType = typeof(UnityEngine.InputSystem.Utilities.ReadOnlyArray`1<UnityEngine.InputSystem.InputActionMap>))]
	[Calls(Type = typeof(ReadOnlyArray`1), Member = "GetEnumerator", ReturnType = "UnityEngine.InputSystem.Utilities.ReadOnlyArray`1<TValue>+Enumerator<TValue>")]
	[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Enumerator), Member = "get_Current", ReturnType = "TValue")]
	[Calls(Type = typeof(InputActionMap), Member = "remove_actionTriggered", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<UnityEngine.InputSystem.InputAction+CallbackContext>)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private void UninstallOnActionTriggeredHook() { }

	[CalledBy(Type = typeof(PlayerInput), Member = "ActivateInput", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputActionAsset), Member = "get_actionMaps", ReturnType = typeof(UnityEngine.InputSystem.Utilities.ReadOnlyArray`1<UnityEngine.InputSystem.InputActionMap>))]
	[Calls(Type = typeof(ReadOnlyArray`1), Member = "GetEnumerator", ReturnType = "UnityEngine.InputSystem.Utilities.ReadOnlyArray`1<TValue>+Enumerator<TValue>")]
	[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Enumerator), Member = "get_Current", ReturnType = "TValue")]
	[Calls(Type = typeof(PlayerInput), Member = "InstallOnActionTriggeredHook", ReturnType = typeof(void))]
	[Calls(Type = typeof(PlayerInput), Member = "CacheMessageNames", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 3)]
	private void UpdateDelegates() { }

}

