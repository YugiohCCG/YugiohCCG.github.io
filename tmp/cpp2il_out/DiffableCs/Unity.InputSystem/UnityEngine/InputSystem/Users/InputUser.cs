namespace UnityEngine.InputSystem.Users;

public struct InputUser : IEquatable<InputUser>
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static TypedRestore<GlobalState> <>9__88_0; //Field offset: 0x8
		public static Action <>9__88_1; //Field offset: 0x10

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		private static <>c() { }

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c() { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		internal void <SaveAndResetState>b__88_0(ref GlobalState state) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InputUser), Member = "DisposeAndResetGlobalState", ReturnType = typeof(void))]
		internal void <SaveAndResetState>b__88_1() { }

	}

	private struct CompareDevicesByUserAccount : IComparer<InputDevice>
	{
		public InputUserAccountHandle platformUserAccountHandle; //Field offset: 0x0

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 8)]
		[ContainsUnimplementedInstructions]
		public override int Compare(InputDevice x, InputDevice y) { }

		[CallerCount(Count = 941)]
		[DeduplicatedMethod]
		private static Nullable<InputUserAccountHandle> GetUserAccountHandleForDevice(InputDevice device) { }

	}

	internal struct ControlSchemeChangeSyntax
	{
		internal int m_UserIndex; //Field offset: 0x0

		[CalledBy(Type = typeof(PlayerInput), Member = "TryToActivateControlScheme", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControlScheme)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(InputUser), Member = "UpdateControlSchemeMatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(void))]
		public ControlSchemeChangeSyntax AndPairRemainingDevices() { }

	}

	private struct GlobalState
	{
		internal int pairingStateVersion; //Field offset: 0x0
		internal uint lastUserId; //Field offset: 0x4
		internal int allUserCount; //Field offset: 0x8
		internal int allPairedDeviceCount; //Field offset: 0xC
		internal int allLostDeviceCount; //Field offset: 0x10
		internal InputUser[] allUsers; //Field offset: 0x18
		internal UserData[] allUserData; //Field offset: 0x20
		internal InputDevice[] allPairedDevices; //Field offset: 0x28
		internal InputDevice[] allLostDevices; //Field offset: 0x30
		internal InlinedArray<OngoingAccountSelection> ongoingAccountSelections; //Field offset: 0x38
		internal CallbackArray<Action`3<InputUser, InputUserChange, InputDevice>> onChange; //Field offset: 0x58
		internal CallbackArray<Action`2<InputControl, InputEventPtr>> onUnpairedDeviceUsed; //Field offset: 0xA8
		internal CallbackArray<Func`3<InputDevice, InputEventPtr, Boolean>> onPreFilterUnpairedDeviceUsed; //Field offset: 0xF8
		internal Action<Object, InputActionChange> actionChangeDelegate; //Field offset: 0x148
		internal Action<InputDevice, InputDeviceChange> onDeviceChangeDelegate; //Field offset: 0x150
		internal Action<InputEventPtr, InputDevice> onEventDelegate; //Field offset: 0x158
		internal bool onActionChangeHooked; //Field offset: 0x160
		internal bool onDeviceChangeHooked; //Field offset: 0x161
		internal bool onEventHooked; //Field offset: 0x162
		internal int listenForUnpairedDeviceActivity; //Field offset: 0x164

	}

	private struct OngoingAccountSelection
	{
		public InputDevice device; //Field offset: 0x0
		public uint userId; //Field offset: 0x8

	}

	private struct UserData
	{
		public Nullable<InputUserAccountHandle> platformUserAccountHandle; //Field offset: 0x0
		public string platformUserAccountName; //Field offset: 0x18
		public string platformUserAccountId; //Field offset: 0x20
		public int deviceCount; //Field offset: 0x28
		public int deviceStartIndex; //Field offset: 0x2C
		public IInputActionCollection actions; //Field offset: 0x30
		public Nullable<InputControlScheme> controlScheme; //Field offset: 0x38
		public MatchResult controlSchemeMatch; //Field offset: 0x58
		public int lostDeviceCount; //Field offset: 0xA8
		public int lostDeviceStartIndex; //Field offset: 0xAC
		public UserFlags flags; //Field offset: 0xB0

	}

	[Flags]
	public enum UserFlags
	{
		BindToAllDevices = 1,
		UserAccountSelectionInProgress = 2,
	}

	public const uint InvalidId = 0; //Field offset: 0x0
	private static readonly ProfilerMarker k_InputUserOnChangeMarker; //Field offset: 0x0
	private static readonly ProfilerMarker k_InputCheckForUnpairMarker; //Field offset: 0x8
	private static GlobalState s_GlobalState; //Field offset: 0x10
	private uint m_Id; //Field offset: 0x0

	public static event Action<InputUser, InputUserChange, InputDevice> onChange
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CallbackArray`1), Member = "AddCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TDelegate"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 4)]
		 add { } //Length: 185
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CallbackArray`1), Member = "RemoveCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TDelegate"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 4)]
		 remove { } //Length: 185
	}

	public static event Func<InputDevice, InputEventPtr, Boolean> onPrefilterUnpairedDeviceActivity
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CallbackArray`1), Member = "AddCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TDelegate"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 4)]
		 add { } //Length: 188
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CallbackArray`1), Member = "RemoveCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TDelegate"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 4)]
		 remove { } //Length: 188
	}

	public static event Action<InputControl, InputEventPtr> onUnpairedDeviceUsed
	{
		[CalledBy(Type = typeof(PlayerInput), Member = "StartListeningForUnpairedDeviceActivity", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(PlayerInputManager), Member = "EnableJoining", ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CallbackArray`1), Member = "AddCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TDelegate"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(InputUser), Member = "HookIntoEvents", ReturnType = typeof(void))]
		[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 4)]
		 add { } //Length: 238
		[CalledBy(Type = typeof(PlayerInput), Member = "StopListeningForUnpairedDeviceActivity", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(PlayerInputManager), Member = "DisableJoining", ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CallbackArray`1), Member = "RemoveCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TDelegate"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(InputUser), Member = "UnhookFromDeviceStateChange", ReturnType = typeof(void))]
		[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 4)]
		 remove { } //Length: 274
	}

	public IInputActionCollection actions
	{
		[CalledBy(Type = typeof(InputUser), Member = "ToString", ReturnType = typeof(string))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(InputUser), Member = "get_index", ReturnType = typeof(int))]
		[CallsUnknownMethods(Count = 2)]
		 get { } //Length: 140
	}

	public static ReadOnlyArray<InputUser> all
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		 get { } //Length: 130
	}

	public Nullable<InputControlScheme> controlScheme
	{
		[CalledBy(Type = typeof(PlayerInput), Member = "get_currentControlScheme", ReturnType = typeof(string))]
		[CalledBy(Type = typeof(PlayerInput), Member = "AssignUserAndDevices", ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(InputUser), Member = "get_index", ReturnType = typeof(int))]
		[CallsUnknownMethods(Count = 2)]
		 get { } //Length: 167
	}

	public MatchResult controlSchemeMatch
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InputUser), Member = "get_index", ReturnType = typeof(int))]
		[CallsUnknownMethods(Count = 2)]
		 get { } //Length: 206
	}

	public bool hasMissingRequiredDevices
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InputUser), Member = "get_index", ReturnType = typeof(int))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		 get { } //Length: 147
	}

	public uint id
	{
		[CallerCount(Count = 173)]
		[DeduplicatedMethod]
		 get { } //Length: 3
	}

	public int index
	{
		[CallerCount(Count = 37)]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
		[CallsUnknownMethods(Count = 10)]
		 get { } //Length: 449
	}

	public static int listenForUnpairedDeviceActivity
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 81
		[CalledBy(Type = typeof(PlayerInput), Member = "StartListeningForUnpairedDeviceActivity", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(PlayerInput), Member = "StopListeningForUnpairedDeviceActivity", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(PlayerInputManager), Member = "EnableJoining", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(PlayerInputManager), Member = "DisableJoining", ReturnType = typeof(void))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(InputUser), Member = "HookIntoEvents", ReturnType = typeof(void))]
		[Calls(Type = typeof(InputUser), Member = "UnhookFromDeviceStateChange", ReturnType = typeof(void))]
		[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 5)]
		 set { } //Length: 328
	}

	public ReadOnlyArray<InputDevice> lostDevices
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InputUser), Member = "get_index", ReturnType = typeof(int))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		 get { } //Length: 207
	}

	public ReadOnlyArray<InputDevice> pairedDevices
	{
		[CalledBy(Type = typeof(PlayerInput), Member = "get_devices", ReturnType = typeof(UnityEngine.InputSystem.Utilities.ReadOnlyArray`1<UnityEngine.InputSystem.InputDevice>))]
		[CalledBy(Type = typeof(PlayerInput), Member = "FindFirstPairedToDevice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice)}, ReturnType = typeof(PlayerInput))]
		[CalledBy(Type = typeof(PlayerInput), Member = "SwitchControlSchemeInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControlScheme&), typeof(InputDevice[])}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InputUser), Member = "ToString", ReturnType = typeof(string))]
		[CalledBy(Type = typeof(InputUser), Member = "UnpairDevice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InputUser), Member = "UnpairDevices", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InputUser), Member = "PerformPairingWithDevice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice), typeof(InputUser), typeof(InputUserPairingOptions)}, ReturnType = typeof(InputUser))]
		[CalledBy(Type = typeof(InputUser), Member = "UpdateControlSchemeMatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InputUser), Member = "OnDeviceChange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice), typeof(InputDeviceChange)}, ReturnType = typeof(void))]
		[CallerCount(Count = 10)]
		[Calls(Type = typeof(InputUser), Member = "get_index", ReturnType = typeof(int))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		 get { } //Length: 201
	}

	public Nullable<InputUserAccountHandle> platformUserAccountHandle
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InputUser), Member = "get_index", ReturnType = typeof(int))]
		[CallsUnknownMethods(Count = 2)]
		 get { } //Length: 169
	}

	public string platformUserAccountId
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InputUser), Member = "get_index", ReturnType = typeof(int))]
		[CallsUnknownMethods(Count = 2)]
		 get { } //Length: 140
	}

	public string platformUserAccountName
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InputUser), Member = "get_index", ReturnType = typeof(int))]
		[CallsUnknownMethods(Count = 2)]
		 get { } //Length: 140
	}

	public bool valid
	{
		[CalledBy(Type = typeof(PlayerInput), Member = "get_currentControlScheme", ReturnType = typeof(string))]
		[CalledBy(Type = typeof(PlayerInput), Member = "get_devices", ReturnType = typeof(UnityEngine.InputSystem.Utilities.ReadOnlyArray`1<UnityEngine.InputSystem.InputDevice>))]
		[CalledBy(Type = typeof(PlayerInput), Member = "get_hasMissingRequiredDevices", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(PlayerInput), Member = "FindFirstPairedToDevice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice)}, ReturnType = typeof(PlayerInput))]
		[CalledBy(Type = typeof(PlayerInput), Member = "DoInstantiate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject)}, ReturnType = typeof(PlayerInput))]
		[CalledBy(Type = typeof(PlayerInput), Member = "AssignUserAndDevices", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(PlayerInput), Member = "UnassignUserAndDevices", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(PlayerInput), Member = "TryToActivateControlScheme", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControlScheme)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(PlayerInput), Member = "OnDisable", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(PlayerInput), Member = "OnUnpairedDeviceUsed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl), typeof(InputEventPtr)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(PlayerInput), Member = "OnDeviceChange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice), typeof(InputDeviceChange)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InputUser), Member = "ToString", ReturnType = typeof(string))]
		[CalledBy(Type = typeof(InputUser), Member = "PerformPairingWithDevice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice), typeof(InputUser), typeof(InputUserPairingOptions)}, ReturnType = typeof(InputUser))]
		[CallerCount(Count = 17)]
		[CallsUnknownMethods(Count = 2)]
		 get { } //Length: 199
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ProfilerUnsafeUtility), Member = "CreateMarker", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(ushort), typeof(MarkerFlags), typeof(int)}, ReturnType = typeof(IntPtr))]
	private static InputUser() { }

	[CalledBy(Type = typeof(PlayerInput), Member = "TryToActivateControlScheme", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControlScheme)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputUser), Member = "ActivateControlScheme", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControlScheme)}, ReturnType = typeof(ControlSchemeChangeSyntax))]
	[Calls(Type = typeof(InputUser), Member = "FindControlScheme", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(InputControlScheme&)}, ReturnType = typeof(void))]
	public ControlSchemeChangeSyntax ActivateControlScheme(string schemeName) { }

	[CalledBy(Type = typeof(PlayerInput), Member = "TryToActivateControlScheme", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControlScheme)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(PlayerInput), Member = "OnUnpairedDeviceUsed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl), typeof(InputEventPtr)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PlayerInput), Member = "SwitchControlSchemeInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControlScheme&), typeof(InputDevice[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputUser), Member = "ActivateControlScheme", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(ControlSchemeChangeSyntax))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(InputUser), Member = "get_index", ReturnType = typeof(int))]
	[Calls(Type = typeof(InputControlScheme), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControlScheme), typeof(InputControlScheme)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputControlScheme), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControlScheme), typeof(InputControlScheme)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputUser), Member = "ActivateControlSchemeInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(InputControlScheme)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputUser), Member = "Notify", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(InputUserChange), typeof(InputDevice)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	public ControlSchemeChangeSyntax ActivateControlScheme(InputControlScheme scheme) { }

	[CalledBy(Type = typeof(InputUser), Member = "AssociateActionsWithUser", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IInputActionCollection)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputUser), Member = "ActivateControlScheme", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControlScheme)}, ReturnType = typeof(ControlSchemeChangeSyntax))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(InputControlScheme), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControlScheme), typeof(InputControlScheme)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Nullable`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Nullable`1<UnityEngine.InputSystem.InputBinding>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputBinding)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputUser), Member = "UpdateControlSchemeMatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MatchResult), Member = "get_isSuccessfulMatch", ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputUser), Member = "RemoveLostDevicesForUser", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MatchResult), Member = "Dispose", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 10)]
	private void ActivateControlSchemeInternal(int userIndex, InputControlScheme scheme) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CallbackArray`1), Member = "AddCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TDelegate"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	public static void add_onChange(Action<InputUser, InputUserChange, InputDevice> value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CallbackArray`1), Member = "AddCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TDelegate"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	public static void add_onPrefilterUnpairedDeviceActivity(Func<InputDevice, InputEventPtr, Boolean> value) { }

	[CalledBy(Type = typeof(PlayerInput), Member = "StartListeningForUnpairedDeviceActivity", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PlayerInputManager), Member = "EnableJoining", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CallbackArray`1), Member = "AddCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TDelegate"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputUser), Member = "HookIntoEvents", ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	public static void add_onUnpairedDeviceUsed(Action<InputControl, InputEventPtr> value) { }

	[CalledBy(Type = typeof(InputUser), Member = "PerformPairingWithDevice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice), typeof(InputUser), typeof(InputUserPairingOptions)}, ReturnType = typeof(InputUser))]
	[CalledBy(Type = typeof(InputUser), Member = "UpdateControlSchemeMatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputUser), Member = "OnDeviceChange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice), typeof(InputDeviceChange)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(ArrayHelpers), Member = "MoveSlice", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TValue[]", typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArrayHelpers), Member = "AppendWithCapacity", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[]&), typeof(Int32&), typeof(object), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(InputUser), Member = "get_index", ReturnType = typeof(int))]
	[Calls(Type = typeof(Nullable`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputUser), Member = "UpdateControlSchemeMatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputUser), Member = "HookIntoDeviceChange", ReturnType = typeof(void))]
	[Calls(Type = typeof(InputUser), Member = "Notify", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(InputUserChange), typeof(InputDevice)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 6)]
	private static void AddDeviceToUser(int userIndex, InputDevice device, bool asLostDevice = false, bool dontUpdateControlScheme = false) { }

	[CalledBy(Type = typeof(PlayerInput), Member = "TryToActivateControlScheme", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControlScheme)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(InputUser), Member = "CreateUserWithoutPairedDevices", ReturnType = typeof(InputUser))]
	[CalledBy(Type = typeof(InputUser), Member = "PerformPairingWithDevice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice), typeof(InputUser), typeof(InputUserPairingOptions)}, ReturnType = typeof(InputUser))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(ArrayHelpers), Member = "AppendWithCapacity", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputUser)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputUser[]&), typeof(Int32&), typeof(InputUser), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ArrayHelpers), Member = "AppendWithCapacity", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UserData)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UserData[]&), typeof(Int32&), typeof(UserData), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(InputUser), Member = "Notify", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(InputUserChange), typeof(InputDevice)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private static int AddUser() { }

	[CalledBy(Type = typeof(PlayerInput), Member = "AssignUserAndDevices", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PlayerInput), Member = "OnUnpairedDeviceUsed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl), typeof(InputEventPtr)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(InputUser), Member = "get_index", ReturnType = typeof(int))]
	[Calls(Type = typeof(Action`2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputSystem), Member = "add_onActionChange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`2<System.Object, UnityEngine.InputSystem.InputActionChange>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Nullable`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Nullable`1), Member = "get_Value", ReturnType = "T")]
	[Calls(Type = typeof(InputUser), Member = "ActivateControlSchemeInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(InputControlScheme)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 11)]
	public void AssociateActionsWithUser(IInputActionCollection actions) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputUser), Member = "AddUser", ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 2)]
	public static InputUser CreateUserWithoutPairedDevices() { }

	[CalledBy(Type = typeof(<>c), Member = "<SaveAndResetState>b__88_1", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(MatchResult), Member = "Dispose", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	private static void DisposeAndResetGlobalState() { }

	[CallerCount(Count = 12)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public override bool Equals(InputUser other) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public virtual bool Equals(object obj) { }

	[CalledBy(Type = typeof(PlayerInput), Member = "SwitchCurrentControlScheme", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(InputDevice[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputUser), Member = "ActivateControlScheme", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(ControlSchemeChangeSyntax))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(InputUser), Member = "TryFindControlScheme", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(InputControlScheme&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputUser), Member = "get_index", ReturnType = typeof(int))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 9)]
	internal void FindControlScheme(string schemeName, out InputControlScheme scheme) { }

	[CalledBy(Type = typeof(InputUser), Member = "OnDeviceChange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice), typeof(InputDeviceChange)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	private static int FindLostDevice(InputDevice device, int startIndex = 0) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 9)]
	public static Nullable<InputUser> FindUserByAccount(InputUserAccountHandle platformUserAccountHandle) { }

	[CalledBy(Type = typeof(InputUser), Member = "OnEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputEventPtr), typeof(InputDevice)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ArrayHelpers), Member = "IndexOfReference", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TFirst", "TSecond"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TFirst[]", "TSecond", typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 8)]
	public static Nullable<InputUser> FindUserPairedToDevice(InputDevice device) { }

	[CalledBy(Type = typeof(InputUser), Member = "ToString", ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InputUser), Member = "get_index", ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 2)]
	public IInputActionCollection get_actions() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static ReadOnlyArray<InputUser> get_all() { }

	[CalledBy(Type = typeof(PlayerInput), Member = "get_currentControlScheme", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(PlayerInput), Member = "AssignUserAndDevices", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(InputUser), Member = "get_index", ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 2)]
	public Nullable<InputControlScheme> get_controlScheme() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputUser), Member = "get_index", ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 2)]
	public MatchResult get_controlSchemeMatch() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputUser), Member = "get_index", ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public bool get_hasMissingRequiredDevices() { }

	[CallerCount(Count = 173)]
	[DeduplicatedMethod]
	public uint get_id() { }

	[CallerCount(Count = 37)]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 10)]
	public int get_index() { }

	[CallerCount(Count = 0)]
	public static int get_listenForUnpairedDeviceActivity() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputUser), Member = "get_index", ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public ReadOnlyArray<InputDevice> get_lostDevices() { }

	[CalledBy(Type = typeof(PlayerInput), Member = "get_devices", ReturnType = typeof(UnityEngine.InputSystem.Utilities.ReadOnlyArray`1<UnityEngine.InputSystem.InputDevice>))]
	[CalledBy(Type = typeof(PlayerInput), Member = "FindFirstPairedToDevice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice)}, ReturnType = typeof(PlayerInput))]
	[CalledBy(Type = typeof(PlayerInput), Member = "SwitchControlSchemeInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControlScheme&), typeof(InputDevice[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputUser), Member = "ToString", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(InputUser), Member = "UnpairDevice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputUser), Member = "UnpairDevices", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputUser), Member = "PerformPairingWithDevice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice), typeof(InputUser), typeof(InputUserPairingOptions)}, ReturnType = typeof(InputUser))]
	[CalledBy(Type = typeof(InputUser), Member = "UpdateControlSchemeMatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputUser), Member = "OnDeviceChange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice), typeof(InputDeviceChange)}, ReturnType = typeof(void))]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(InputUser), Member = "get_index", ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public ReadOnlyArray<InputDevice> get_pairedDevices() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputUser), Member = "get_index", ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 2)]
	public Nullable<InputUserAccountHandle> get_platformUserAccountHandle() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputUser), Member = "get_index", ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 2)]
	public string get_platformUserAccountId() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputUser), Member = "get_index", ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 2)]
	public string get_platformUserAccountName() { }

	[CalledBy(Type = typeof(PlayerInput), Member = "get_currentControlScheme", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(PlayerInput), Member = "get_devices", ReturnType = typeof(UnityEngine.InputSystem.Utilities.ReadOnlyArray`1<UnityEngine.InputSystem.InputDevice>))]
	[CalledBy(Type = typeof(PlayerInput), Member = "get_hasMissingRequiredDevices", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(PlayerInput), Member = "FindFirstPairedToDevice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice)}, ReturnType = typeof(PlayerInput))]
	[CalledBy(Type = typeof(PlayerInput), Member = "DoInstantiate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject)}, ReturnType = typeof(PlayerInput))]
	[CalledBy(Type = typeof(PlayerInput), Member = "AssignUserAndDevices", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PlayerInput), Member = "UnassignUserAndDevices", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PlayerInput), Member = "TryToActivateControlScheme", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControlScheme)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(PlayerInput), Member = "OnDisable", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PlayerInput), Member = "OnUnpairedDeviceUsed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl), typeof(InputEventPtr)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PlayerInput), Member = "OnDeviceChange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice), typeof(InputDeviceChange)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputUser), Member = "ToString", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(InputUser), Member = "PerformPairingWithDevice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice), typeof(InputUser), typeof(InputUserPairingOptions)}, ReturnType = typeof(InputUser))]
	[CallerCount(Count = 17)]
	[CallsUnknownMethods(Count = 2)]
	public bool get_valid() { }

	[CallerCount(Count = 173)]
	[DeduplicatedMethod]
	public virtual int GetHashCode() { }

	[CalledBy(Type = typeof(PlayerInput), Member = "AssignUserAndDevices", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PlayerInputManager), Member = "IsDeviceUsableWithPlayerActions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(InputControlList`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Allocator), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputUser), Member = "GetUnpairedInputDevices", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControlList`1<InputDevice>&)}, ReturnType = typeof(int))]
	public static InputControlList<InputDevice> GetUnpairedInputDevices() { }

	[CalledBy(Type = typeof(PlayerInput), Member = "AssignUserAndDevices", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PlayerInput), Member = "OnUnpairedDeviceUsed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl), typeof(InputEventPtr)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputUser), Member = "GetUnpairedInputDevices", ReturnType = typeof(UnityEngine.InputSystem.InputControlList`1<UnityEngine.InputSystem.InputDevice>))]
	[CalledBy(Type = typeof(InputUser), Member = "UpdateControlSchemeMatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(InputSystem), Member = "get_devices", ReturnType = typeof(UnityEngine.InputSystem.Utilities.ReadOnlyArray`1<UnityEngine.InputSystem.InputDevice>))]
	[Calls(Type = typeof(ReadOnlyArray`1), Member = "GetEnumerator", ReturnType = "UnityEngine.InputSystem.Utilities.ReadOnlyArray`1<TValue>+Enumerator<TValue>")]
	[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Enumerator), Member = "get_Current", ReturnType = "TValue")]
	[Calls(Type = typeof(ArrayHelpers), Member = "ContainsReference", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TFirst", "TSecond"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TFirst[]", typeof(int), "TSecond"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputControlList`1), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TControl"}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public static int GetUnpairedInputDevices(ref InputControlList<InputDevice>& list) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Action`2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputSystem), Member = "add_onActionChange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`2<System.Object, UnityEngine.InputSystem.InputActionChange>)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private static void HookIntoActionChange() { }

	[CalledBy(Type = typeof(InputUser), Member = "InitiateUserAccountSelection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(InputDevice), typeof(InputUserPairingOptions)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(InputUser), Member = "AddDeviceToUser", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(InputDevice), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Action`2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputSystem), Member = "add_onDeviceChange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`2<UnityEngine.InputSystem.InputDevice, UnityEngine.InputSystem.InputDeviceChange>)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private static void HookIntoDeviceChange() { }

	[CalledBy(Type = typeof(InputUser), Member = "add_onUnpairedDeviceUsed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`2<UnityEngine.InputSystem.InputControl, UnityEngine.InputSystem.LowLevel.InputEventPtr>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputUser), Member = "set_listenForUnpairedDeviceActivity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Action`2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputEventListener), Member = "op_Addition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputEventListener), typeof(System.Action`2<UnityEngine.InputSystem.LowLevel.InputEventPtr, UnityEngine.InputSystem.InputDevice>)}, ReturnType = typeof(InputEventListener))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	private static void HookIntoEvents() { }

	[CalledBy(Type = typeof(InputUser), Member = "PerformPairingWithDevice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice), typeof(InputUser), typeof(InputUserPairingOptions)}, ReturnType = typeof(InputUser))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(InputUser), Member = "UpdatePlatformUserAccount", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(InputDevice)}, ReturnType = typeof(long))]
	[Calls(Type = typeof(InitiateUserAccountPairingCommand), Member = "Create", ReturnType = typeof(InitiateUserAccountPairingCommand))]
	[Calls(Type = typeof(InputDevice), Member = "ExecuteCommand", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InitiateUserAccountPairingCommand)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InitiateUserAccountPairingCommand&)}, ReturnType = typeof(long))]
	[Calls(Type = typeof(InlinedArray`1), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, ReturnType = typeof(int))]
	[Calls(Type = typeof(InputUser), Member = "HookIntoDeviceChange", ReturnType = typeof(void))]
	[Calls(Type = typeof(InputUser), Member = "Notify", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(InputUserChange), typeof(InputDevice)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 8)]
	private static bool InitiateUserAccountSelection(int userIndex, InputDevice device, InputUserPairingOptions options) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InitiateUserAccountPairingCommand), Member = "Create", ReturnType = typeof(InitiateUserAccountPairingCommand))]
	[Calls(Type = typeof(InputDevice), Member = "ExecuteCommand", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InitiateUserAccountPairingCommand)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InitiateUserAccountPairingCommand&)}, ReturnType = typeof(long))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	[ContainsUnimplementedInstructions]
	private static bool InitiateUserAccountSelectionAtPlatformLevel(InputDevice device) { }

	[CalledBy(Type = typeof(InputUser), Member = "ActivateControlScheme", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControlScheme)}, ReturnType = typeof(ControlSchemeChangeSyntax))]
	[CalledBy(Type = typeof(InputUser), Member = "OnActionChange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(InputActionChange)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputUser), Member = "UpdatePlatformUserAccount", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(InputDevice)}, ReturnType = typeof(long))]
	[CalledBy(Type = typeof(InputUser), Member = "RemoveDeviceFromUser", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(InputDevice), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputUser), Member = "OnDeviceChange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice), typeof(InputDeviceChange)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputUser), Member = "RemoveUser", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputUser), Member = "AddUser", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(InputUser), Member = "InitiateUserAccountSelection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(InputDevice), typeof(InputUserPairingOptions)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(InputUser), Member = "AddDeviceToUser", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(InputDevice), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(CallbackArray`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "TDelegate")]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Debug), Member = "LogException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CallbackArray`1), Member = "UnlockForChanges", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 6)]
	private static void Notify(int userIndex, InputUserChange change, InputDevice device) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputUser), Member = "get_index", ReturnType = typeof(int))]
	[Calls(Type = typeof(InputUser), Member = "Notify", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(InputUserChange), typeof(InputDevice)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	private static void OnActionChange(object obj, InputActionChange change) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputUser), Member = "FindLostDevice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(InputUser), Member = "RemoveDeviceFromUser", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(InputDevice), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputUser), Member = "Notify", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(InputUserChange), typeof(InputDevice)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputUser), Member = "AddDeviceToUser", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(InputDevice), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArrayHelpers), Member = "IndexOfReference", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TFirst", "TSecond"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TFirst[]", "TSecond", typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(InlinedArray`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "TValue")]
	[Calls(Type = typeof(InputUser), Member = "get_index", ReturnType = typeof(int))]
	[Calls(Type = typeof(InputUser), Member = "UpdatePlatformUserAccount", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(InputDevice)}, ReturnType = typeof(long))]
	[Calls(Type = typeof(InlinedArray`1), Member = "RemoveAtByMovingTailWithCapacity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputUser), Member = "get_pairedDevices", ReturnType = typeof(UnityEngine.InputSystem.Utilities.ReadOnlyArray`1<UnityEngine.InputSystem.InputDevice>))]
	[Calls(Type = typeof(ReadOnlyArrayExtensions), Member = "ContainsReference", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.InputSystem.Utilities.ReadOnlyArray`1<TValue>", "TValue"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Math), Member = "Max", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ArrayHelpers), Member = "IndexOfReference", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TFirst", "TSecond"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TFirst[]", "TSecond", typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 3)]
	private static void OnDeviceChange(InputDevice device, InputDeviceChange change) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputEventPtr), Member = "get_type", ReturnType = typeof(FourCC))]
	[Calls(Type = typeof(InputDevice), Member = "get_enabled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(ArrayHelpers), Member = "ContainsReference", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TFirst", "TSecond"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TFirst[]", typeof(int), "TSecond"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DelegateHelpers), Member = "InvokeCallbacksSafe_AnyCallbackReturnsTrue", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue1", "TValue2"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.InputSystem.Utilities.CallbackArray`1<Func`3<TValue1, TValue2, Boolean>>&", "TValue1", "TValue2", typeof(string), typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputControlExtensions), Member = "EnumerateChangedControls", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputEventPtr), typeof(InputDevice), typeof(float)}, ReturnType = typeof(InputEventControlCollection))]
	[Calls(Type = typeof(InputEventControlCollection), Member = "GetEnumerator", ReturnType = typeof(InputEventControlEnumerator))]
	[Calls(Type = typeof(InputEventControlEnumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CallbackArray`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "TDelegate")]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Debug), Member = "LogException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputUser), Member = "FindUserPairedToDevice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice)}, ReturnType = typeof(System.Nullable`1<UnityEngine.InputSystem.Users.InputUser>))]
	[Calls(Type = typeof(CallbackArray`1), Member = "UnlockForChanges", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 7)]
	private static void OnEvent(InputEventPtr eventPtr, InputDevice device) { }

	[CallerCount(Count = 2)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public static bool op_Equality(InputUser left, InputUser right) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public static bool op_Inequality(InputUser left, InputUser right) { }

	[CalledBy(Type = typeof(PlayerInput), Member = "AssignUserAndDevices", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PlayerInput), Member = "TryToActivateControlScheme", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControlScheme)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(PlayerInput), Member = "OnUnpairedDeviceUsed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl), typeof(InputEventPtr)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PlayerInput), Member = "OnDeviceChange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice), typeof(InputDeviceChange)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PlayerInput), Member = "SwitchControlSchemeInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControlScheme&), typeof(InputDevice[])}, ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputUser), Member = "AddDeviceToUser", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(InputDevice), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputUser), Member = "AddUser", ReturnType = typeof(int))]
	[Calls(Type = typeof(InputUser), Member = "InitiateUserAccountSelection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(InputDevice), typeof(InputUserPairingOptions)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputUser), Member = "UnpairDevices", ReturnType = typeof(void))]
	[Calls(Type = typeof(InputUser), Member = "get_pairedDevices", ReturnType = typeof(UnityEngine.InputSystem.Utilities.ReadOnlyArray`1<UnityEngine.InputSystem.InputDevice>))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputUser), Member = "get_index", ReturnType = typeof(int))]
	[Calls(Type = typeof(InputUser), Member = "get_valid", ReturnType = typeof(bool))]
	[Calls(Type = typeof(ReadOnlyArrayExtensions), Member = "ContainsReference", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.InputSystem.Utilities.ReadOnlyArray`1<TValue>", "TValue"}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 11)]
	public static InputUser PerformPairingWithDevice(InputDevice device, InputUser user = null, InputUserPairingOptions options = 0) { }

	[CalledBy(Type = typeof(InputUser), Member = "UpdatePlatformUserAccount", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(InputDevice)}, ReturnType = typeof(long))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(QueryPairedUserAccountCommand), Member = "Create", ReturnType = typeof(QueryPairedUserAccountCommand))]
	[Calls(Type = typeof(InputDevice), Member = "ExecuteCommand", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(QueryPairedUserAccountCommand)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(QueryPairedUserAccountCommand&)}, ReturnType = typeof(long))]
	[Calls(Type = typeof(InputUserAccountHandle), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(ulong)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Nullable`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(QueryPairedUserAccountCommand), Member = "get_name", ReturnType = typeof(string))]
	[Calls(Type = typeof(QueryPairedUserAccountCommand), Member = "get_id", ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 8)]
	private static long QueryPairedPlatformUserAccount(InputDevice device, out Nullable<InputUserAccountHandle>& platformAccountHandle, out string platformAccountName, out string platformAccountId) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CallbackArray`1), Member = "RemoveCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TDelegate"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	public static void remove_onChange(Action<InputUser, InputUserChange, InputDevice> value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CallbackArray`1), Member = "RemoveCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TDelegate"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	public static void remove_onPrefilterUnpairedDeviceActivity(Func<InputDevice, InputEventPtr, Boolean> value) { }

	[CalledBy(Type = typeof(PlayerInput), Member = "StopListeningForUnpairedDeviceActivity", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PlayerInputManager), Member = "DisableJoining", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CallbackArray`1), Member = "RemoveCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TDelegate"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputUser), Member = "UnhookFromDeviceStateChange", ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public static void remove_onUnpairedDeviceUsed(Action<InputControl, InputEventPtr> value) { }

	[CalledBy(Type = typeof(InputUser), Member = "UnpairDevice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputUser), Member = "UnpairDevices", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputUser), Member = "OnDeviceChange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice), typeof(InputDeviceChange)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(ArrayHelpers), Member = "IndexOfReference", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TFirst", "TSecond"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TFirst[]", "TSecond", typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ArrayHelpers), Member = "IndexOfReference", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TFirst", "TSecond"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TFirst[]", "TSecond", typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ArrayHelpers), Member = "EraseAtWithCapacity", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[]), typeof(Int32&), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InlinedArray`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "TValue")]
	[Calls(Type = typeof(InlinedArray`1), Member = "RemoveAtByMovingTailWithCapacity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputUser), Member = "get_index", ReturnType = typeof(int))]
	[Calls(Type = typeof(Nullable`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputUser), Member = "UpdateControlSchemeMatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputUser), Member = "Notify", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(InputUserChange), typeof(InputDevice)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 7)]
	private static void RemoveDeviceFromUser(int userIndex, InputDevice device, bool asLostDevice = false) { }

	[CalledBy(Type = typeof(InputUser), Member = "ActivateControlSchemeInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(InputControlScheme)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputUser), Member = "UnpairDevices", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputUser), Member = "RemoveUser", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(ArrayHelpers), Member = "EraseSliceWithCapacity", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TValue[]&", typeof(Int32&), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	private static void RemoveLostDevicesForUser(int userIndex) { }

	[CalledBy(Type = typeof(PlayerInput), Member = "UnassignUserAndDevices", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PlayerInput), Member = "OnDisable", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputUser), Member = "UnpairDevicesAndRemoveUser", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(MatchResult), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(InputUser), Member = "RemoveLostDevicesForUser", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InlinedArray`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "TValue")]
	[Calls(Type = typeof(InlinedArray`1), Member = "RemoveAtByMovingTailWithCapacity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputUser), Member = "Notify", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(InputUserChange), typeof(InputDevice)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArrayHelpers), Member = "EraseAtWithCapacity", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TValue[]", typeof(Int32&), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArrayHelpers), Member = "EraseAtWithCapacity", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UserData)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UserData[]), typeof(Int32&), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputUser), Member = "UnhookFromDeviceChange", ReturnType = typeof(void))]
	[Calls(Type = typeof(InputUser), Member = "UnhookFromActionChange", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	private static void RemoveUser(int userIndex) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputUser), Member = "UnhookFromActionChange", ReturnType = typeof(void))]
	[Calls(Type = typeof(InputUser), Member = "UnhookFromDeviceChange", ReturnType = typeof(void))]
	[Calls(Type = typeof(InputUser), Member = "UnhookFromDeviceStateChange", ReturnType = typeof(void))]
	[Calls(Type = typeof(MatchResult), Member = "Dispose", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	internal static void ResetGlobals() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.InputSystem.Utilities.SavedStructState`1<UnityEngine.InputSystem.Users.InputUser+GlobalState>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GlobalState&), typeof(UnityEngine.InputSystem.Utilities.SavedStructState`1+TypedRestore<UnityEngine.InputSystem.Users.InputUser+GlobalState>), typeof(Action)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	internal static ISavedState SaveAndResetState() { }

	[CalledBy(Type = typeof(PlayerInput), Member = "StartListeningForUnpairedDeviceActivity", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PlayerInput), Member = "StopListeningForUnpairedDeviceActivity", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PlayerInputManager), Member = "EnableJoining", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PlayerInputManager), Member = "DisableJoining", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(InputUser), Member = "HookIntoEvents", ReturnType = typeof(void))]
	[Calls(Type = typeof(InputUser), Member = "UnhookFromDeviceStateChange", ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	public static void set_listenForUnpairedDeviceActivity(int value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputUser), Member = "get_valid", ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputUser), Member = "get_pairedDevices", ReturnType = typeof(UnityEngine.InputSystem.Utilities.ReadOnlyArray`1<UnityEngine.InputSystem.InputDevice>))]
	[Calls(Type = typeof(string), Member = "Join", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(InputUser), Member = "get_index", ReturnType = typeof(int))]
	[Calls(Type = typeof(InputUser), Member = "get_actions", ReturnType = typeof(IInputActionCollection))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 18)]
	public virtual string ToString() { }

	[CalledBy(Type = typeof(InputUser), Member = "FindControlScheme", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(InputControlScheme&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputUser), Member = "get_index", ReturnType = typeof(int))]
	[Calls(Type = typeof(ReadOnlyArray`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "TValue")]
	[Calls(Type = typeof(string), Member = "Compare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(StringComparison)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 10)]
	[ContainsUnimplementedInstructions]
	private bool TryFindControlScheme(string schemeName, out InputControlScheme scheme) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ArrayHelpers), Member = "IndexOfReference", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TFirst", "TSecond"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TFirst[]", "TSecond", typeof(int)}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 2)]
	private static int TryFindUserIndex(InputDevice device) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static int TryFindUserIndex(uint userId) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private static int TryFindUserIndex(InputUserAccountHandle platformHandle) { }

	[CalledBy(Type = typeof(InputUser), Member = "RemoveUser", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputUser), Member = "ResetGlobals", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Action`2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputSystem), Member = "remove_onActionChange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`2<System.Object, UnityEngine.InputSystem.InputActionChange>)}, ReturnType = typeof(void))]
	private static void UnhookFromActionChange() { }

	[CalledBy(Type = typeof(InputUser), Member = "RemoveUser", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputUser), Member = "ResetGlobals", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(InputSystem), Member = "remove_onDeviceChange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`2<UnityEngine.InputSystem.InputDevice, UnityEngine.InputSystem.InputDeviceChange>)}, ReturnType = typeof(void))]
	private static void UnhookFromDeviceChange() { }

	[CalledBy(Type = typeof(InputUser), Member = "remove_onUnpairedDeviceUsed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`2<UnityEngine.InputSystem.InputControl, UnityEngine.InputSystem.LowLevel.InputEventPtr>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputUser), Member = "set_listenForUnpairedDeviceActivity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputUser), Member = "ResetGlobals", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(InputEventListener), Member = "op_Subtraction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputEventListener), typeof(System.Action`2<UnityEngine.InputSystem.LowLevel.InputEventPtr, UnityEngine.InputSystem.InputDevice>)}, ReturnType = typeof(InputEventListener))]
	[CallsDeduplicatedMethods(Count = 2)]
	private static void UnhookFromDeviceStateChange() { }

	[CalledBy(Type = typeof(PlayerInput), Member = "SwitchControlSchemeInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControlScheme&), typeof(InputDevice[])}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InputUser), Member = "get_index", ReturnType = typeof(int))]
	[Calls(Type = typeof(InputUser), Member = "get_pairedDevices", ReturnType = typeof(UnityEngine.InputSystem.Utilities.ReadOnlyArray`1<UnityEngine.InputSystem.InputDevice>))]
	[Calls(Type = typeof(ReadOnlyArrayExtensions), Member = "ContainsReference", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.InputSystem.Utilities.ReadOnlyArray`1<TValue>", "TValue"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputUser), Member = "RemoveDeviceFromUser", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(InputDevice), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	public void UnpairDevice(InputDevice device) { }

	[CalledBy(Type = typeof(PlayerInput), Member = "AssignUserAndDevices", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PlayerInput), Member = "UnassignUserAndDevices", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PlayerInput), Member = "TryToActivateControlScheme", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControlScheme)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(PlayerInput), Member = "OnDisable", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PlayerInput), Member = "OnUnpairedDeviceUsed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl), typeof(InputEventPtr)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputUser), Member = "UnpairDevicesAndRemoveUser", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputUser), Member = "PerformPairingWithDevice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice), typeof(InputUser), typeof(InputUserPairingOptions)}, ReturnType = typeof(InputUser))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(InputUser), Member = "UpdateControlSchemeMatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputUser), Member = "RemoveDeviceFromUser", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(InputDevice), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ReadOnlyArrayExtensions), Member = "ContainsReference", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.InputSystem.Utilities.ReadOnlyArray`1<TValue>", "TValue"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputUser), Member = "get_index", ReturnType = typeof(int))]
	[Calls(Type = typeof(InputActionRebindingExtensions), Member = "DeferBindingResolution", ReturnType = typeof(DeferBindingResolutionWrapper))]
	[Calls(Type = typeof(InputUser), Member = "RemoveLostDevicesForUser", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputUser), Member = "get_pairedDevices", ReturnType = typeof(UnityEngine.InputSystem.Utilities.ReadOnlyArray`1<UnityEngine.InputSystem.InputDevice>))]
	[CallsUnknownMethods(Count = 17)]
	public void UnpairDevices() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputUser), Member = "UnpairDevices", ReturnType = typeof(void))]
	[Calls(Type = typeof(InputUser), Member = "get_index", ReturnType = typeof(int))]
	[Calls(Type = typeof(InputUser), Member = "RemoveUser", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	public void UnpairDevicesAndRemoveUser() { }

	[CalledBy(Type = typeof(ControlSchemeChangeSyntax), Member = "AndPairRemainingDevices", ReturnType = typeof(ControlSchemeChangeSyntax))]
	[CalledBy(Type = typeof(InputUser), Member = "ActivateControlSchemeInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(InputControlScheme)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputUser), Member = "UnpairDevices", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputUser), Member = "AddDeviceToUser", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(InputDevice), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputUser), Member = "RemoveDeviceFromUser", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(InputDevice), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(InputControlList`1), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(InputUser), Member = "AddDeviceToUser", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(InputDevice), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ReadOnlyArrayExtensions), Member = "ContainsReference", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.InputSystem.Utilities.ReadOnlyArray`1<TValue>", "TValue"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputControlList`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.IEnumerator`1<TControl>")]
	[Calls(Type = typeof(MatchResult), Member = "get_devices", ReturnType = typeof(UnityEngine.InputSystem.InputControlList`1<UnityEngine.InputSystem.InputDevice>))]
	[Calls(Type = typeof(MatchResult), Member = "get_isSuccessfulMatch", ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputControlScheme), Member = "PickDevicesFrom", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TDevices"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TDevices", typeof(InputDevice)}, ReturnType = typeof(MatchResult))]
	[Calls(Type = typeof(InputControlList`1), Member = "AddSlice", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TList"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TList", typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputUser), Member = "GetUnpairedInputDevices", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControlList`1<InputDevice>&)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(InputUser), Member = "get_pairedDevices", ReturnType = typeof(UnityEngine.InputSystem.Utilities.ReadOnlyArray`1<UnityEngine.InputSystem.InputDevice>))]
	[Calls(Type = typeof(InputControlList`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Allocator), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputControlScheme), Member = "get_deviceRequirements", ReturnType = typeof(UnityEngine.InputSystem.Utilities.ReadOnlyArray`1<UnityEngine.InputSystem.InputControlScheme+DeviceRequirement>))]
	[Calls(Type = typeof(Nullable`1), Member = "get_Value", ReturnType = "T")]
	[Calls(Type = typeof(MatchResult), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(UnityEngine.InputSystem.InputControlList`1<System.Object>), Member = "Sort", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CompareDevicesByUserAccount)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(CompareDevicesByUserAccount)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 31)]
	private static void UpdateControlSchemeMatch(int userIndex, bool autoPairMissing = false) { }

	[CalledBy(Type = typeof(InputUser), Member = "InitiateUserAccountSelection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(InputDevice), typeof(InputUserPairingOptions)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(InputUser), Member = "OnDeviceChange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice), typeof(InputDeviceChange)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(InputUser), Member = "QueryPairedPlatformUserAccount", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice), typeof(Nullable`1<InputUserAccountHandle>&), typeof(String&), typeof(String&)}, ReturnType = typeof(long))]
	[Calls(Type = typeof(InputUserAccountHandle), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputUserAccountHandle), typeof(InputUserAccountHandle)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputUser), Member = "Notify", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(InputUserChange), typeof(InputDevice)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 10)]
	private static long UpdatePlatformUserAccount(int userIndex, InputDevice device) { }

}

