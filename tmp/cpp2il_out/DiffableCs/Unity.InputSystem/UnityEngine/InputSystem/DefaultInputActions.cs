namespace UnityEngine.InputSystem;

public class DefaultInputActions : IInputActionCollection2, IInputActionCollection, IEnumerable<InputAction>, IEnumerable, IDisposable
{
	internal interface IPlayerActions
	{

		public void OnFire(CallbackContext context) { }

		public void OnLook(CallbackContext context) { }

		public void OnMove(CallbackContext context) { }

	}

	internal interface IUIActions
	{

		public void OnCancel(CallbackContext context) { }

		public void OnClick(CallbackContext context) { }

		public void OnMiddleClick(CallbackContext context) { }

		public void OnNavigate(CallbackContext context) { }

		public void OnPoint(CallbackContext context) { }

		public void OnRightClick(CallbackContext context) { }

		public void OnScrollWheel(CallbackContext context) { }

		public void OnSubmit(CallbackContext context) { }

		public void OnTrackedDeviceOrientation(CallbackContext context) { }

		public void OnTrackedDevicePosition(CallbackContext context) { }

	}

	internal struct PlayerActions
	{
		private DefaultInputActions m_Wrapper; //Field offset: 0x0

		public bool enabled
		{
			[CallerCount(Count = 0)]
			[CallsDeduplicatedMethods(Count = 1)]
			[CallsUnknownMethods(Count = 1)]
			 get { } //Length: 37
		}

		public InputAction Fire
		{
			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			 get { } //Length: 26
		}

		public InputAction Look
		{
			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			 get { } //Length: 26
		}

		public InputAction Move
		{
			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			[DeduplicatedMethod]
			 get { } //Length: 26
		}

		[CallerCount(Count = 5)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		public PlayerActions(DefaultInputActions wrapper) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InputActionMap), Member = "Disable", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		public void Disable() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InputActionMap), Member = "Enable", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		public void Enable() { }

		[CallerCount(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		public InputActionMap Get() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		public bool get_enabled() { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		public InputAction get_Fire() { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		public InputAction get_Look() { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		public InputAction get_Move() { }

		[CallerCount(Count = 43)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		public static InputActionMap op_Implicit(PlayerActions set) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InputAction), Member = "remove_started", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<UnityEngine.InputSystem.InputAction+CallbackContext>)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(InputAction), Member = "remove_performed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<UnityEngine.InputSystem.InputAction+CallbackContext>)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(InputAction), Member = "remove_canceled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<UnityEngine.InputSystem.InputAction+CallbackContext>)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(InputAction), Member = "add_started", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<UnityEngine.InputSystem.InputAction+CallbackContext>)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(InputAction), Member = "add_performed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<UnityEngine.InputSystem.InputAction+CallbackContext>)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(InputAction), Member = "add_canceled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<UnityEngine.InputSystem.InputAction+CallbackContext>)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 18)]
		[CallsUnknownMethods(Count = 20)]
		public void SetCallbacks(IPlayerActions instance) { }

	}

	internal struct UIActions
	{
		private DefaultInputActions m_Wrapper; //Field offset: 0x0

		public InputAction Cancel
		{
			[CalledBy(Type = typeof(InputSystemUIInputModule), Member = "AssignDefaultActions", ReturnType = typeof(void))]
			[CallerCount(Count = 1)]
			[CallsUnknownMethods(Count = 1)]
			 get { } //Length: 26
		}

		public InputAction Click
		{
			[CalledBy(Type = typeof(InputSystemUIInputModule), Member = "AssignDefaultActions", ReturnType = typeof(void))]
			[CallerCount(Count = 1)]
			[CallsUnknownMethods(Count = 1)]
			 get { } //Length: 26
		}

		public bool enabled
		{
			[CallerCount(Count = 0)]
			[CallsDeduplicatedMethods(Count = 1)]
			[CallsUnknownMethods(Count = 1)]
			 get { } //Length: 37
		}

		public InputAction MiddleClick
		{
			[CalledBy(Type = typeof(InputSystemUIInputModule), Member = "AssignDefaultActions", ReturnType = typeof(void))]
			[CallerCount(Count = 1)]
			[CallsUnknownMethods(Count = 1)]
			 get { } //Length: 29
		}

		public InputAction Navigate
		{
			[CalledBy(Type = typeof(InputSystemUIInputModule), Member = "AssignDefaultActions", ReturnType = typeof(void))]
			[CallerCount(Count = 1)]
			[CallsUnknownMethods(Count = 1)]
			 get { } //Length: 26
		}

		public InputAction Point
		{
			[CalledBy(Type = typeof(InputSystemUIInputModule), Member = "AssignDefaultActions", ReturnType = typeof(void))]
			[CallerCount(Count = 1)]
			[CallsUnknownMethods(Count = 1)]
			 get { } //Length: 26
		}

		public InputAction RightClick
		{
			[CalledBy(Type = typeof(InputSystemUIInputModule), Member = "AssignDefaultActions", ReturnType = typeof(void))]
			[CallerCount(Count = 1)]
			[CallsUnknownMethods(Count = 1)]
			 get { } //Length: 29
		}

		public InputAction ScrollWheel
		{
			[CalledBy(Type = typeof(InputSystemUIInputModule), Member = "AssignDefaultActions", ReturnType = typeof(void))]
			[CallerCount(Count = 1)]
			[CallsUnknownMethods(Count = 1)]
			 get { } //Length: 26
		}

		public InputAction Submit
		{
			[CallerCount(Count = 1)]
			[CallsUnknownMethods(Count = 1)]
			[DeduplicatedMethod]
			 get { } //Length: 26
		}

		public InputAction TrackedDeviceOrientation
		{
			[CalledBy(Type = typeof(InputSystemUIInputModule), Member = "AssignDefaultActions", ReturnType = typeof(void))]
			[CallerCount(Count = 1)]
			[CallsUnknownMethods(Count = 1)]
			 get { } //Length: 29
		}

		public InputAction TrackedDevicePosition
		{
			[CalledBy(Type = typeof(InputSystemUIInputModule), Member = "AssignDefaultActions", ReturnType = typeof(void))]
			[CallerCount(Count = 1)]
			[CallsUnknownMethods(Count = 1)]
			 get { } //Length: 29
		}

		[CallerCount(Count = 5)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		public UIActions(DefaultInputActions wrapper) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InputActionMap), Member = "Disable", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		public void Disable() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InputActionMap), Member = "Enable", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		public void Enable() { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		public InputActionMap Get() { }

		[CalledBy(Type = typeof(InputSystemUIInputModule), Member = "AssignDefaultActions", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		public InputAction get_Cancel() { }

		[CalledBy(Type = typeof(InputSystemUIInputModule), Member = "AssignDefaultActions", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		public InputAction get_Click() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		public bool get_enabled() { }

		[CalledBy(Type = typeof(InputSystemUIInputModule), Member = "AssignDefaultActions", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		public InputAction get_MiddleClick() { }

		[CalledBy(Type = typeof(InputSystemUIInputModule), Member = "AssignDefaultActions", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		public InputAction get_Navigate() { }

		[CalledBy(Type = typeof(InputSystemUIInputModule), Member = "AssignDefaultActions", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		public InputAction get_Point() { }

		[CalledBy(Type = typeof(InputSystemUIInputModule), Member = "AssignDefaultActions", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		public InputAction get_RightClick() { }

		[CalledBy(Type = typeof(InputSystemUIInputModule), Member = "AssignDefaultActions", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		public InputAction get_ScrollWheel() { }

		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		public InputAction get_Submit() { }

		[CalledBy(Type = typeof(InputSystemUIInputModule), Member = "AssignDefaultActions", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		public InputAction get_TrackedDeviceOrientation() { }

		[CalledBy(Type = typeof(InputSystemUIInputModule), Member = "AssignDefaultActions", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		public InputAction get_TrackedDevicePosition() { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		public static InputActionMap op_Implicit(UIActions set) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InputAction), Member = "remove_started", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<UnityEngine.InputSystem.InputAction+CallbackContext>)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(InputAction), Member = "remove_performed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<UnityEngine.InputSystem.InputAction+CallbackContext>)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(InputAction), Member = "remove_canceled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<UnityEngine.InputSystem.InputAction+CallbackContext>)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(InputAction), Member = "add_started", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<UnityEngine.InputSystem.InputAction+CallbackContext>)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(InputAction), Member = "add_performed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<UnityEngine.InputSystem.InputAction+CallbackContext>)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(InputAction), Member = "add_canceled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<UnityEngine.InputSystem.InputAction+CallbackContext>)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 60)]
		[CallsUnknownMethods(Count = 62)]
		public void SetCallbacks(IUIActions instance) { }

	}

	[CompilerGenerated]
	private readonly InputActionAsset <asset>k__BackingField; //Field offset: 0x10
	private readonly InputActionMap m_Player; //Field offset: 0x18
	private IPlayerActions m_PlayerActionsCallbackInterface; //Field offset: 0x20
	private readonly InputAction m_Player_Move; //Field offset: 0x28
	private readonly InputAction m_Player_Look; //Field offset: 0x30
	private readonly InputAction m_Player_Fire; //Field offset: 0x38
	private readonly InputActionMap m_UI; //Field offset: 0x40
	private IUIActions m_UIActionsCallbackInterface; //Field offset: 0x48
	private readonly InputAction m_UI_Navigate; //Field offset: 0x50
	private readonly InputAction m_UI_Submit; //Field offset: 0x58
	private readonly InputAction m_UI_Cancel; //Field offset: 0x60
	private readonly InputAction m_UI_Point; //Field offset: 0x68
	private readonly InputAction m_UI_Click; //Field offset: 0x70
	private readonly InputAction m_UI_ScrollWheel; //Field offset: 0x78
	private readonly InputAction m_UI_MiddleClick; //Field offset: 0x80
	private readonly InputAction m_UI_RightClick; //Field offset: 0x88
	private readonly InputAction m_UI_TrackedDevicePosition; //Field offset: 0x90
	private readonly InputAction m_UI_TrackedDeviceOrientation; //Field offset: 0x98
	private int m_KeyboardMouseSchemeIndex; //Field offset: 0xA0
	private int m_GamepadSchemeIndex; //Field offset: 0xA4
	private int m_TouchSchemeIndex; //Field offset: 0xA8
	private int m_JoystickSchemeIndex; //Field offset: 0xAC
	private int m_XRSchemeIndex; //Field offset: 0xB0

	public InputActionAsset asset
	{
		[CallerCount(Count = 106)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public override Nullable<InputBinding> bindingMask
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 76
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InputActionAsset), Member = "set_bindingMask", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Nullable`1<UnityEngine.InputSystem.InputBinding>)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		 set { } //Length: 91
	}

	public override IEnumerable<InputBinding> bindings
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InputActionAsset), Member = "get_bindings", ReturnType = typeof(System.Collections.Generic.IEnumerable`1<UnityEngine.InputSystem.InputBinding>))]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 29
	}

	public override ReadOnlyArray<InputControlScheme> controlSchemes
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InputActionAsset), Member = "get_controlSchemes", ReturnType = typeof(UnityEngine.InputSystem.Utilities.ReadOnlyArray`1<UnityEngine.InputSystem.InputControlScheme>))]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 51
	}

	public override Nullable<ReadOnlyArray`1<InputDevice>> devices
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InputActionAsset), Member = "get_devices", ReturnType = typeof(System.Nullable`1<UnityEngine.InputSystem.Utilities.ReadOnlyArray`1<UnityEngine.InputSystem.InputDevice>>))]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 61
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InputActionAsset), Member = "set_devices", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Nullable`1<UnityEngine.InputSystem.Utilities.ReadOnlyArray`1<UnityEngine.InputSystem.InputDevice>>)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		 set { } //Length: 55
	}

	public InputControlScheme GamepadScheme
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InputActionAsset), Member = "FindControlSchemeIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(InputActionAsset), Member = "get_controlSchemes", ReturnType = typeof(UnityEngine.InputSystem.Utilities.ReadOnlyArray`1<UnityEngine.InputSystem.InputControlScheme>))]
		[Calls(Type = typeof(ReadOnlyArray`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "TValue")]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 200
	}

	public InputControlScheme JoystickScheme
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InputActionAsset), Member = "FindControlSchemeIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(InputActionAsset), Member = "get_controlSchemes", ReturnType = typeof(UnityEngine.InputSystem.Utilities.ReadOnlyArray`1<UnityEngine.InputSystem.InputControlScheme>))]
		[Calls(Type = typeof(ReadOnlyArray`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "TValue")]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 200
	}

	public InputControlScheme KeyboardMouseScheme
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InputActionAsset), Member = "FindControlSchemeIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(InputActionAsset), Member = "get_controlSchemes", ReturnType = typeof(UnityEngine.InputSystem.Utilities.ReadOnlyArray`1<UnityEngine.InputSystem.InputControlScheme>))]
		[Calls(Type = typeof(ReadOnlyArray`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "TValue")]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 200
	}

	public PlayerActions Player
	{
		[CallerCount(Count = 778)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 32
	}

	public InputControlScheme TouchScheme
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InputActionAsset), Member = "FindControlSchemeIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(InputActionAsset), Member = "get_controlSchemes", ReturnType = typeof(UnityEngine.InputSystem.Utilities.ReadOnlyArray`1<UnityEngine.InputSystem.InputControlScheme>))]
		[Calls(Type = typeof(ReadOnlyArray`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "TValue")]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 200
	}

	public UIActions UI
	{
		[CallerCount(Count = 778)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 32
	}

	public InputControlScheme XRScheme
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InputActionAsset), Member = "FindControlSchemeIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(InputActionAsset), Member = "get_controlSchemes", ReturnType = typeof(UnityEngine.InputSystem.Utilities.ReadOnlyArray`1<UnityEngine.InputSystem.InputControlScheme>))]
		[Calls(Type = typeof(ReadOnlyArray`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "TValue")]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 200
	}

	[CalledBy(Type = typeof(InputSystemUIInputModule), Member = "AssignDefaultActions", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.InputSystem.Plugins.InputForUI.InputSystemProvider", Member = "SelectInputActionAsset", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(InputActionAsset), Member = "FromJson", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(InputActionAsset))]
	[Calls(Type = typeof(InputActionAsset), Member = "FindActionMap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(InputActionMap))]
	[Calls(Type = typeof(InputActionMap), Member = "FindAction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(InputAction))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 17)]
	public DefaultInputActions() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputActionAsset), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputAction)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	public override bool Contains(InputAction action) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputActionAsset), Member = "Disable", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public override void Disable() { }

	[CalledBy(Type = typeof(InputSystemUIInputModule), Member = "ResetDefaultActions", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputSystemUIInputModule), Member = "UnassignActions", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.InputSystem.Plugins.InputForUI.InputSystemProvider", Member = "Shutdown", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Object), Member = "Destroy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(void))]
	public override void Dispose() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputActionAsset), Member = "Enable", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public override void Enable() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputActionAsset), Member = "FindAction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(InputAction))]
	[CallsUnknownMethods(Count = 1)]
	public override InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputActionAsset), Member = "FindBinding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputBinding), typeof(InputAction&)}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 1)]
	public override int FindBinding(InputBinding bindingMask, out InputAction action) { }

	[CallerCount(Count = 106)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public InputActionAsset get_asset() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public override Nullable<InputBinding> get_bindingMask() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputActionAsset), Member = "get_bindings", ReturnType = typeof(System.Collections.Generic.IEnumerable`1<UnityEngine.InputSystem.InputBinding>))]
	[CallsUnknownMethods(Count = 1)]
	public override IEnumerable<InputBinding> get_bindings() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputActionAsset), Member = "get_controlSchemes", ReturnType = typeof(UnityEngine.InputSystem.Utilities.ReadOnlyArray`1<UnityEngine.InputSystem.InputControlScheme>))]
	[CallsUnknownMethods(Count = 1)]
	public override ReadOnlyArray<InputControlScheme> get_controlSchemes() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputActionAsset), Member = "get_devices", ReturnType = typeof(System.Nullable`1<UnityEngine.InputSystem.Utilities.ReadOnlyArray`1<UnityEngine.InputSystem.InputDevice>>))]
	[CallsUnknownMethods(Count = 1)]
	public override Nullable<ReadOnlyArray`1<InputDevice>> get_devices() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputActionAsset), Member = "FindControlSchemeIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(InputActionAsset), Member = "get_controlSchemes", ReturnType = typeof(UnityEngine.InputSystem.Utilities.ReadOnlyArray`1<UnityEngine.InputSystem.InputControlScheme>))]
	[Calls(Type = typeof(ReadOnlyArray`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "TValue")]
	[CallsUnknownMethods(Count = 1)]
	public InputControlScheme get_GamepadScheme() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputActionAsset), Member = "FindControlSchemeIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(InputActionAsset), Member = "get_controlSchemes", ReturnType = typeof(UnityEngine.InputSystem.Utilities.ReadOnlyArray`1<UnityEngine.InputSystem.InputControlScheme>))]
	[Calls(Type = typeof(ReadOnlyArray`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "TValue")]
	[CallsUnknownMethods(Count = 1)]
	public InputControlScheme get_JoystickScheme() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputActionAsset), Member = "FindControlSchemeIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(InputActionAsset), Member = "get_controlSchemes", ReturnType = typeof(UnityEngine.InputSystem.Utilities.ReadOnlyArray`1<UnityEngine.InputSystem.InputControlScheme>))]
	[Calls(Type = typeof(ReadOnlyArray`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "TValue")]
	[CallsUnknownMethods(Count = 1)]
	public InputControlScheme get_KeyboardMouseScheme() { }

	[CallerCount(Count = 778)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public PlayerActions get_Player() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputActionAsset), Member = "FindControlSchemeIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(InputActionAsset), Member = "get_controlSchemes", ReturnType = typeof(UnityEngine.InputSystem.Utilities.ReadOnlyArray`1<UnityEngine.InputSystem.InputControlScheme>))]
	[Calls(Type = typeof(ReadOnlyArray`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "TValue")]
	[CallsUnknownMethods(Count = 1)]
	public InputControlScheme get_TouchScheme() { }

	[CallerCount(Count = 778)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public UIActions get_UI() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputActionAsset), Member = "FindControlSchemeIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(InputActionAsset), Member = "get_controlSchemes", ReturnType = typeof(UnityEngine.InputSystem.Utilities.ReadOnlyArray`1<UnityEngine.InputSystem.InputControlScheme>))]
	[Calls(Type = typeof(ReadOnlyArray`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "TValue")]
	[CallsUnknownMethods(Count = 1)]
	public InputControlScheme get_XRScheme() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public override IEnumerator<InputAction> GetEnumerator() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputActionAsset), Member = "set_bindingMask", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Nullable`1<UnityEngine.InputSystem.InputBinding>)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public override void set_bindingMask(Nullable<InputBinding> value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputActionAsset), Member = "set_devices", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Nullable`1<UnityEngine.InputSystem.Utilities.ReadOnlyArray`1<UnityEngine.InputSystem.InputDevice>>)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public override void set_devices(Nullable<ReadOnlyArray`1<InputDevice>> value) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

