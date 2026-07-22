namespace UnityEngine.InputSystem;

[DefaultMember("Item")]
public class InputActionAsset : ScriptableObject, IInputActionCollection2, IInputActionCollection, IEnumerable<InputAction>, IEnumerable
{
	[CompilerGenerated]
	private sealed class <get_bindings>d__9 : IEnumerable<InputBinding>, IEnumerable, IEnumerator<InputBinding>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private InputBinding <>2__current; //Field offset: 0x18
		private int <>l__initialThreadId; //Field offset: 0x70
		public InputActionAsset <>4__this; //Field offset: 0x78
		private int <numActionMaps>5__2; //Field offset: 0x80
		private int <i>5__3; //Field offset: 0x84
		private InputBinding[] <bindings>5__4; //Field offset: 0x88
		private int <numBindings>5__5; //Field offset: 0x90
		private int <n>5__6; //Field offset: 0x94

		private override InputBinding System.Collections.Generic.IEnumerator<UnityEngine.InputSystem.InputBinding>.Current
		{
			[CallerCount(Count = 0)]
			[DebuggerHidden]
			private get { } //Length: 53
		}

		private override object System.Collections.IEnumerator.Current
		{
			[CallerCount(Count = 0)]
			[DebuggerHidden]
			private get { } //Length: 122
		}

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		[DebuggerHidden]
		public <get_bindings>d__9(int <>1__state) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ArrayHelpers), Member = "LengthSafe", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TValue[]"}, ReturnType = typeof(int))]
		[CallsUnknownMethods(Count = 5)]
		private override bool MoveNext() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 1)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		private override IEnumerator<InputBinding> System.Collections.Generic.IEnumerable<UnityEngine.InputSystem.InputBinding>.GetEnumerator() { }

		[CallerCount(Count = 0)]
		[DebuggerHidden]
		private override InputBinding System.Collections.Generic.IEnumerator<UnityEngine.InputSystem.InputBinding>.get_Current() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 1)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[CallerCount(Count = 0)]
		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[CallerCount(Count = 13327)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	private sealed class <GetEnumerator>d__33 : IEnumerator<InputAction>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private InputAction <>2__current; //Field offset: 0x18
		public InputActionAsset <>4__this; //Field offset: 0x20
		private int <i>5__2; //Field offset: 0x28
		private ReadOnlyArray<InputAction> <actions>5__3; //Field offset: 0x30
		private int <actionCount>5__4; //Field offset: 0x40
		private int <n>5__5; //Field offset: 0x44

		private override InputAction System.Collections.Generic.IEnumerator<UnityEngine.InputSystem.InputAction>.Current
		{
			[CallerCount(Count = 31)]
			[DebuggerHidden]
			[DeduplicatedMethod]
			private get { } //Length: 5
		}

		private override object System.Collections.IEnumerator.Current
		{
			[CallerCount(Count = 31)]
			[DebuggerHidden]
			[DeduplicatedMethod]
			private get { } //Length: 5
		}

		[CallerCount(Count = 36)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		public <GetEnumerator>d__33(int <>1__state) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ReadOnlyArray`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TValue[]"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ReadOnlyArray`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "TValue")]
		[CallsUnknownMethods(Count = 4)]
		private override bool MoveNext() { }

		[CallerCount(Count = 31)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		private override InputAction System.Collections.Generic.IEnumerator<UnityEngine.InputSystem.InputAction>.get_Current() { }

		[CallerCount(Count = 31)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		private override object System.Collections.IEnumerator.get_Current() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[CallerCount(Count = 13327)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		private override void System.IDisposable.Dispose() { }

	}

	private static class JsonVersion
	{
		public const int Version0 = 0; //Field offset: 0x0
		public const int Version1 = 1; //Field offset: 0x0
		public const int Current = 1; //Field offset: 0x0

	}

	public struct ReadFileJson
	{
		public int version; //Field offset: 0x0
		public string name; //Field offset: 0x8
		public ReadMapJson[] maps; //Field offset: 0x10
		public SchemeJson[] controlSchemes; //Field offset: 0x18

		[CalledBy(Type = typeof(InputActionAsset), Member = "LoadFromJson", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InputActionAsset), Member = "FromJson", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(InputActionAsset))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Object), Member = "set_name", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ReadFileJson), Member = "ToMaps", ReturnType = typeof(InputActionMap[]))]
		[Calls(Type = typeof(SchemeJson), Member = "ToSchemes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SchemeJson[])}, ReturnType = typeof(InputControlScheme[]))]
		[CallsUnknownMethods(Count = 6)]
		public void ToAsset(InputActionAsset asset) { }

	}

	public struct WriteFileJson
	{
		public int version; //Field offset: 0x0
		public string name; //Field offset: 0x8
		public WriteMapJson[] maps; //Field offset: 0x10
		public SchemeJson[] controlSchemes; //Field offset: 0x18

	}

	public struct WriteFileJsonNoName
	{
		public WriteMapJson[] maps; //Field offset: 0x0
		public SchemeJson[] controlSchemes; //Field offset: 0x8

	}

	public const string Extension = "inputactions"; //Field offset: 0x0
	internal const string kDefaultAssetLayoutJson = "{}"; //Field offset: 0x0
	[SerializeField]
	internal InputActionMap[] m_ActionMaps; //Field offset: 0x18
	[SerializeField]
	internal InputControlScheme[] m_ControlSchemes; //Field offset: 0x20
	[SerializeField]
	internal bool m_IsProjectWide; //Field offset: 0x28
	internal InputActionState m_SharedStateForAllMaps; //Field offset: 0x30
	internal Nullable<InputBinding> m_BindingMask; //Field offset: 0x38
	internal int m_ParameterOverridesCount; //Field offset: 0x98
	internal ParameterOverride[] m_ParameterOverrides; //Field offset: 0xA0
	internal DeviceArray m_Devices; //Field offset: 0xA8

	public ReadOnlyArray<InputActionMap> actionMaps
	{
		[CalledBy(Type = typeof(PlayerInput), Member = "UpdateDelegates", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(PlayerInput), Member = "CopyActionAssetAndApplyBindingOverrides", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(PlayerInput), Member = "InstallOnActionTriggeredHook", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(PlayerInput), Member = "UninstallOnActionTriggeredHook", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(PlayerInput), Member = "HaveBindingForDevice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(PlayerInputManager), Member = "IsDeviceUsableWithPlayerActions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(InputActionTrace), Member = "OnActionChange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(InputActionChange)}, ReturnType = typeof(void))]
		[CallerCount(Count = 10)]
		[Calls(Type = typeof(ReadOnlyArray`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TValue[]"}, ReturnType = typeof(void))]
		 get { } //Length: 83
	}

	public override Nullable<InputBinding> bindingMask
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 54
		[CalledBy(Type = typeof(DefaultInputActions), Member = "set_bindingMask", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Nullable`1<UnityEngine.InputSystem.InputBinding>)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(InputBinding), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputBinding), typeof(InputBinding)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(InputActionMap), Member = "LazyResolveBindings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 3)]
		[ContainsUnimplementedInstructions]
		 set { } //Length: 561
	}

	public override IEnumerable<InputBinding> bindings
	{
		[CalledBy(Type = typeof(DefaultInputActions), Member = "get_bindings", ReturnType = typeof(System.Collections.Generic.IEnumerable`1<UnityEngine.InputSystem.InputBinding>))]
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		[IteratorStateMachine(typeof(<get_bindings>d__9))]
		 get { } //Length: 113
	}

	public override ReadOnlyArray<InputControlScheme> controlSchemes
	{
		[CalledBy(Type = typeof(InputActionSetupExtensions), Member = "AddControlScheme", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionAsset), typeof(string)}, ReturnType = typeof(ControlSchemeSyntax))]
		[CalledBy(Type = typeof(DefaultInputActions), Member = "get_controlSchemes", ReturnType = typeof(UnityEngine.InputSystem.Utilities.ReadOnlyArray`1<UnityEngine.InputSystem.InputControlScheme>))]
		[CalledBy(Type = typeof(DefaultInputActions), Member = "get_KeyboardMouseScheme", ReturnType = typeof(InputControlScheme))]
		[CalledBy(Type = typeof(DefaultInputActions), Member = "get_GamepadScheme", ReturnType = typeof(InputControlScheme))]
		[CalledBy(Type = typeof(DefaultInputActions), Member = "get_TouchScheme", ReturnType = typeof(InputControlScheme))]
		[CalledBy(Type = typeof(DefaultInputActions), Member = "get_JoystickScheme", ReturnType = typeof(InputControlScheme))]
		[CalledBy(Type = typeof(DefaultInputActions), Member = "get_XRScheme", ReturnType = typeof(InputControlScheme))]
		[CalledBy(Type = typeof(PlayerInput), Member = "SwitchCurrentControlScheme", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice[])}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(PlayerInput), Member = "AssignUserAndDevices", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(PlayerInput), Member = "OnEnable", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(PlayerInput), Member = "OnUnpairedDeviceUsed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl), typeof(InputEventPtr)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(PlayerInput), Member = "OnDeviceChange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice), typeof(InputDeviceChange)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(PlayerInputManager), Member = "IsDeviceUsableWithPlayerActions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 16)]
		[Calls(Type = typeof(ReadOnlyArray`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TValue[]"}, ReturnType = typeof(void))]
		 get { } //Length: 83
	}

	public override Nullable<ReadOnlyArray`1<InputDevice>> devices
	{
		[CalledBy(Type = typeof(DefaultInputActions), Member = "get_devices", ReturnType = typeof(System.Nullable`1<UnityEngine.InputSystem.Utilities.ReadOnlyArray`1<UnityEngine.InputSystem.InputDevice>>))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(DeviceArray), Member = "Get", ReturnType = typeof(System.Nullable`1<UnityEngine.InputSystem.Utilities.ReadOnlyArray`1<UnityEngine.InputSystem.InputDevice>>))]
		 get { } //Length: 54
		[CalledBy(Type = typeof(DefaultInputActions), Member = "set_devices", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Nullable`1<UnityEngine.InputSystem.Utilities.ReadOnlyArray`1<UnityEngine.InputSystem.InputDevice>>)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(PlayerInput), Member = "UnassignUserAndDevices", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(PlayerInput), Member = "OnDisable", ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(DeviceArray), Member = "Set", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Nullable`1<UnityEngine.InputSystem.Utilities.ReadOnlyArray`1<UnityEngine.InputSystem.InputDevice>>)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(InputActionMap), Member = "LazyResolveBindings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 2)]
		 set { } //Length: 115
	}

	public bool enabled
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ReadOnlyArray`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TValue[]"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ReadOnlyArray`1), Member = "GetEnumerator", ReturnType = "UnityEngine.InputSystem.Utilities.ReadOnlyArray`1<TValue>+Enumerator<TValue>")]
		[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
		[Calls(Type = typeof(Enumerator), Member = "get_Current", ReturnType = "TValue")]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 2)]
		 get { } //Length: 367
	}

	public InputAction Item
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InputActionAsset), Member = "FindAction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(InputAction))]
		[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(KeyNotFoundException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 4)]
		 get { } //Length: 135
	}

	[CallerCount(Count = 3)]
	[Calls(Type = typeof(ScriptableObject), Member = ".ctor", ReturnType = typeof(void))]
	[DeduplicatedMethod]
	public InputActionAsset() { }

	[CalledBy(Type = typeof(DefaultInputActions), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputAction)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	public override bool Contains(InputAction action) { }

	[CalledBy(Type = typeof(InputActionAsset), Member = "OnDestroy", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputSystem), Member = "DisableActions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DefaultInputActions), Member = "Disable", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PlayerInput), Member = "set_actions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionAsset)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.InputSystem.Plugins.InputForUI.InputSystemProvider", Member = "UnregisterActions", ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(ReadOnlyArray`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TValue[]"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ReadOnlyArray`1), Member = "GetEnumerator", ReturnType = "UnityEngine.InputSystem.Utilities.ReadOnlyArray`1<TValue>+Enumerator<TValue>")]
	[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Enumerator), Member = "get_Current", ReturnType = "TValue")]
	[Calls(Type = typeof(InputActionState), Member = "DisableAllActions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionMap)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public override void Disable() { }

	[CalledBy(Type = typeof(InputSystem), Member = "EnableActions", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputSystem), Member = "InitializeInPlayer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IInputRuntime), typeof(InputSettings)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DefaultInputActions), Member = "Enable", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.InputSystem.Plugins.InputForUI.InputSystemProvider", Member = "RegisterActions", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(ReadOnlyArray`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TValue[]"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ReadOnlyArray`1), Member = "GetEnumerator", ReturnType = "UnityEngine.InputSystem.Utilities.ReadOnlyArray`1<TValue>+Enumerator<TValue>")]
	[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Enumerator), Member = "get_Current", ReturnType = "TValue")]
	[Calls(Type = typeof(InputActionMap), Member = "ResolveBindings", ReturnType = typeof(void))]
	[Calls(Type = typeof(InputActionState), Member = "EnableAllActions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionMap)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public override void Enable() { }

	[CalledBy(Type = typeof(InputActionAsset), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(InputAction))]
	[CalledBy(Type = typeof(InputActionSetupExtensions), Member = "RemoveAction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionAsset), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DefaultInputActions), Member = "FindAction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(InputAction))]
	[CalledBy(Type = typeof(PlayerInput), Member = "InitializeActions", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PlayerInput), Member = "UninitializeActions", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PlayerInputManager), Member = "OnEnable", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.InputSystem.Plugins.InputForUI.InputSystemProvider", Member = "FindActionAndRegisterCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "System.Action`1<CallbackContext>"}, ReturnType = typeof(InputAction))]
	[CalledBy(Type = "UnityEngine.InputSystem.Plugins.InputForUI.InputSystemProvider", Member = "RegisterActions", ReturnType = typeof(void))]
	[CallerCount(Count = 15)]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputAction), Member = "get_enabled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Substring), Member = "get_isEmpty", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Substring), Member = "Compare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Substring), typeof(Substring), typeof(StringComparison)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Substring), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Substring))]
	[Calls(Type = typeof(Substring), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(InputActionMap), Member = "FindActionIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 15)]
	public override InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false) { }

	[CalledBy(Type = typeof(InputActionReference), Member = "get_action", ReturnType = typeof(InputAction))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Guid), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public InputAction FindAction(Guid guid) { }

	[CalledBy(Type = typeof(InputActionReference), Member = "Set", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionAsset), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputActionSetupExtensions), Member = "AddActionMap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionAsset), typeof(string)}, ReturnType = typeof(InputActionMap))]
	[CalledBy(Type = typeof(InputActionSetupExtensions), Member = "AddActionMap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionAsset), typeof(InputActionMap)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputActionSetupExtensions), Member = "RemoveActionMap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionAsset), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DefaultInputActions), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PlayerInput), Member = "SwitchCurrentActionMap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputSystemUIInputModule), Member = "UpdateReferenceForNewAsset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionReference)}, ReturnType = typeof(InputActionReference))]
	[CalledBy(Type = typeof(InputSystemUIInputModule), Member = "set_actionsAsset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionAsset)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.InputSystem.Plugins.InputForUI.InputSystemProvider", Member = "RegisterActions", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.InputSystem.Plugins.InputForUI.InputSystemProvider", Member = "SelectInputActionAsset", ReturnType = typeof(void))]
	[CallerCount(Count = 20)]
	[Calls(Type = typeof(string), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Guid), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Guid&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Guid), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Compare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(StringComparison)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 10)]
	public InputActionMap FindActionMap(string nameOrId, bool throwIfNotFound = false) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Guid), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public InputActionMap FindActionMap(Guid id) { }

	[CalledBy(Type = typeof(DefaultInputActions), Member = "FindBinding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputBinding), typeof(InputAction&)}, ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ArrayHelpers), Member = "LengthSafe", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TValue[]"}, ReturnType = typeof(int))]
	[Calls(Type = typeof(InputActionMap), Member = "FindBinding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputBinding), typeof(InputAction&)}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 3)]
	public override int FindBinding(InputBinding mask, out InputAction action) { }

	[CalledBy(Type = typeof(InputActionSetupExtensions), Member = "AddControlScheme", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionAsset), typeof(InputControlScheme)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PlayerInput), Member = "AssignUserAndDevices", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "Compare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(StringComparison)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Nullable`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 12)]
	public Nullable<InputControlScheme> FindControlScheme(string name) { }

	[CalledBy(Type = typeof(InputActionSetupExtensions), Member = "RemoveControlScheme", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionAsset), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DefaultInputActions), Member = "get_KeyboardMouseScheme", ReturnType = typeof(InputControlScheme))]
	[CalledBy(Type = typeof(DefaultInputActions), Member = "get_GamepadScheme", ReturnType = typeof(InputControlScheme))]
	[CalledBy(Type = typeof(DefaultInputActions), Member = "get_TouchScheme", ReturnType = typeof(InputControlScheme))]
	[CalledBy(Type = typeof(DefaultInputActions), Member = "get_JoystickScheme", ReturnType = typeof(InputControlScheme))]
	[CalledBy(Type = typeof(DefaultInputActions), Member = "get_XRScheme", ReturnType = typeof(InputControlScheme))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "Compare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(StringComparison)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 6)]
	public int FindControlSchemeIndex(string name) { }

	[CalledBy(Type = typeof(DefaultInputActions), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ScriptableObject), Member = "CreateInstance", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(JsonUtility), Member = "FromJson", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ReadFileJson)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(ReadFileJson))]
	[Calls(Type = typeof(InputActionAsset), Member = "MigrateJson", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ReadFileJson&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ReadFileJson), Member = "ToAsset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionAsset)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 9)]
	public static InputActionAsset FromJson(string json) { }

	[CalledBy(Type = typeof(PlayerInput), Member = "UpdateDelegates", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PlayerInput), Member = "CopyActionAssetAndApplyBindingOverrides", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PlayerInput), Member = "InstallOnActionTriggeredHook", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PlayerInput), Member = "UninstallOnActionTriggeredHook", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PlayerInput), Member = "HaveBindingForDevice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(PlayerInputManager), Member = "IsDeviceUsableWithPlayerActions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(InputActionTrace), Member = "OnActionChange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(InputActionChange)}, ReturnType = typeof(void))]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(ReadOnlyArray`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TValue[]"}, ReturnType = typeof(void))]
	public ReadOnlyArray<InputActionMap> get_actionMaps() { }

	[CallerCount(Count = 0)]
	public override Nullable<InputBinding> get_bindingMask() { }

	[CalledBy(Type = typeof(DefaultInputActions), Member = "get_bindings", ReturnType = typeof(System.Collections.Generic.IEnumerable`1<UnityEngine.InputSystem.InputBinding>))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[IteratorStateMachine(typeof(<get_bindings>d__9))]
	public override IEnumerable<InputBinding> get_bindings() { }

	[CalledBy(Type = typeof(InputActionSetupExtensions), Member = "AddControlScheme", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionAsset), typeof(string)}, ReturnType = typeof(ControlSchemeSyntax))]
	[CalledBy(Type = typeof(DefaultInputActions), Member = "get_controlSchemes", ReturnType = typeof(UnityEngine.InputSystem.Utilities.ReadOnlyArray`1<UnityEngine.InputSystem.InputControlScheme>))]
	[CalledBy(Type = typeof(DefaultInputActions), Member = "get_KeyboardMouseScheme", ReturnType = typeof(InputControlScheme))]
	[CalledBy(Type = typeof(DefaultInputActions), Member = "get_GamepadScheme", ReturnType = typeof(InputControlScheme))]
	[CalledBy(Type = typeof(DefaultInputActions), Member = "get_TouchScheme", ReturnType = typeof(InputControlScheme))]
	[CalledBy(Type = typeof(DefaultInputActions), Member = "get_JoystickScheme", ReturnType = typeof(InputControlScheme))]
	[CalledBy(Type = typeof(DefaultInputActions), Member = "get_XRScheme", ReturnType = typeof(InputControlScheme))]
	[CalledBy(Type = typeof(PlayerInput), Member = "SwitchCurrentControlScheme", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice[])}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(PlayerInput), Member = "AssignUserAndDevices", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PlayerInput), Member = "OnEnable", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PlayerInput), Member = "OnUnpairedDeviceUsed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl), typeof(InputEventPtr)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PlayerInput), Member = "OnDeviceChange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice), typeof(InputDeviceChange)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PlayerInputManager), Member = "IsDeviceUsableWithPlayerActions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 16)]
	[Calls(Type = typeof(ReadOnlyArray`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TValue[]"}, ReturnType = typeof(void))]
	public override ReadOnlyArray<InputControlScheme> get_controlSchemes() { }

	[CalledBy(Type = typeof(DefaultInputActions), Member = "get_devices", ReturnType = typeof(System.Nullable`1<UnityEngine.InputSystem.Utilities.ReadOnlyArray`1<UnityEngine.InputSystem.InputDevice>>))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DeviceArray), Member = "Get", ReturnType = typeof(System.Nullable`1<UnityEngine.InputSystem.Utilities.ReadOnlyArray`1<UnityEngine.InputSystem.InputDevice>>))]
	public override Nullable<ReadOnlyArray`1<InputDevice>> get_devices() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ReadOnlyArray`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TValue[]"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ReadOnlyArray`1), Member = "GetEnumerator", ReturnType = "UnityEngine.InputSystem.Utilities.ReadOnlyArray`1<TValue>+Enumerator<TValue>")]
	[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Enumerator), Member = "get_Current", ReturnType = "TValue")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	public bool get_enabled() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputActionAsset), Member = "FindAction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(InputAction))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(KeyNotFoundException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	public InputAction get_Item(string actionNameOrId) { }

	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[IteratorStateMachine(typeof(<GetEnumerator>d__33))]
	public override IEnumerator<InputAction> GetEnumerator() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ReadOnlyArray`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TValue[]"}, ReturnType = typeof(void))]
	[ContainsUnimplementedInstructions]
	internal bool IsEmpty() { }

	[CalledBy(Type = typeof(PlayerInput), Member = "OnPreFilterUnpairedDeviceUsed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice), typeof(InputEventPtr)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ArrayHelpers), Member = "LengthSafe", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TValue[]"}, ReturnType = typeof(int))]
	[Calls(Type = typeof(InputBinding), Member = "get_effectivePath", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputControlPath), Member = "Matches", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(InputControl)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputControlScheme), Member = "SupportsDevice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 7)]
	public bool IsUsableWithDevice(InputDevice device) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(JsonUtility), Member = "FromJson", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ReadFileJson)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(ReadFileJson))]
	[Calls(Type = typeof(InputActionAsset), Member = "MigrateJson", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ReadFileJson&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ReadFileJson), Member = "ToAsset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionAsset)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	public void LoadFromJson(string json) { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	internal void MarkAsDirty() { }

	[CalledBy(Type = typeof(InputActionAsset), Member = "LoadFromJson", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputActionAsset), Member = "FromJson", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(InputActionAsset))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(NameAndParameters), Member = "ToSerializableString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<UnityEngine.InputSystem.Utilities.NameAndParameters>)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(NameAndParameters), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(System.Collections.Generic.IList`1<UnityEngine.InputSystem.Utilities.NamedValue>)}, ReturnType = typeof(NameAndParameters))]
	[Calls(Type = typeof(NamedValue), Member = "From", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "TValue"}, ReturnType = typeof(NamedValue))]
	[Calls(Type = typeof(Convert), Member = "ToInt32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Array), Member = "GetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Enum), Member = "GetValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(Array))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ReadOnlyArray`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "TValue")]
	[Calls(Type = typeof(InputSystem), Member = "TryGetProcessor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(List`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NameAndParameters), Member = "ParseMultiple", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(List`1<NameAndParameters>&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallsUnknownMethods(Count = 7)]
	internal void MigrateJson(ref ReadFileJson parsedJson) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputActionAsset), Member = "Disable", ReturnType = typeof(void))]
	[Calls(Type = typeof(InputActionState), Member = "Dispose", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private void OnDestroy() { }

	[CalledBy(Type = typeof(InputActionSetupExtensions), Member = "AddActionMap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionAsset), typeof(InputActionMap)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputActionSetupExtensions), Member = "RemoveActionMap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionAsset), typeof(InputActionMap)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputActionSetupExtensions), Member = "RemoveActionMap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionAsset), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputSystem), Member = "DisableActions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(ArrayHelpers), Member = "LengthSafe", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TValue[]"}, ReturnType = typeof(int))]
	[Calls(Type = typeof(InputActionMap), Member = "OnSetupChanged", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	internal void OnSetupChanged() { }

	[CalledBy(Type = typeof(InputActionSetupExtensions), Member = "AddActionMap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionAsset), typeof(InputActionMap)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputActionSetupExtensions), Member = "RemoveActionMap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionAsset), typeof(InputActionMap)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputActionSetupExtensions), Member = "RemoveActionMap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionAsset), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(ArrayHelpers), Member = "LengthSafe", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TValue[]"}, ReturnType = typeof(int))]
	[Calls(Type = typeof(InputActionMap), Member = "OnWantToChangeSetup", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	internal void OnWantToChangeSetup() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputActionMap), Member = "LazyResolveBindings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 2)]
	private void ReResolveIfNecessary(bool fullResolve) { }

	[CalledBy(Type = typeof(InputActionRebindingExtensions), Member = "ApplyParameterOverride", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TObject", "TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionAsset), "System.Linq.Expressions.Expression`1<Func`2<TObject, TValue>>", "TValue", typeof(InputBinding)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ArrayHelpers), Member = "LengthSafe", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TValue[]"}, ReturnType = typeof(int))]
	[Calls(Type = typeof(InputActionMap), Member = "ResolveBindings", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	internal void ResolveBindingsIfNecessary() { }

	[CalledBy(Type = typeof(DefaultInputActions), Member = "set_bindingMask", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Nullable`1<UnityEngine.InputSystem.InputBinding>)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InputBinding), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputBinding), typeof(InputBinding)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputActionMap), Member = "LazyResolveBindings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	public override void set_bindingMask(Nullable<InputBinding> value) { }

	[CalledBy(Type = typeof(DefaultInputActions), Member = "set_devices", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Nullable`1<UnityEngine.InputSystem.Utilities.ReadOnlyArray`1<UnityEngine.InputSystem.InputDevice>>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PlayerInput), Member = "UnassignUserAndDevices", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PlayerInput), Member = "OnDisable", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(DeviceArray), Member = "Set", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Nullable`1<UnityEngine.InputSystem.Utilities.ReadOnlyArray`1<UnityEngine.InputSystem.InputDevice>>)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputActionMap), Member = "LazyResolveBindings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 2)]
	public override void set_devices(Nullable<ReadOnlyArray`1<InputDevice>> value) { }

	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ArrayHelpers), Member = "LengthSafe", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TValue[]"}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Object), Member = "get_name", ReturnType = typeof(string))]
	[Calls(Type = typeof(WriteFileJson), Member = "FromMaps", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<UnityEngine.InputSystem.InputActionMap>)}, ReturnType = typeof(WriteFileJson))]
	[Calls(Type = typeof(SchemeJson), Member = "ToJson", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControlScheme[])}, ReturnType = typeof(SchemeJson[]))]
	[Calls(Type = typeof(JsonUtility), Member = "ToJson", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(bool)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	public string ToJson() { }

}

