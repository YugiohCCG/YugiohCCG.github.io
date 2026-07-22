namespace UnityEngine.InputSystem;

public sealed class InputAction : ICloneable, IDisposable
{
	[Flags]
	public enum ActionFlags
	{
		WantsInitialStateCheck = 1,
	}

	internal struct CallbackContext
	{
		internal InputActionState m_State; //Field offset: 0x0
		internal int m_ActionIndex; //Field offset: 0x8

		public InputAction action
		{
			[CalledBy(Type = typeof(InputActionState), Member = "CallActionListeners", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(InputActionMap), typeof(InputActionPhase), typeof(CallbackArray`1<Action`1<CallbackContext>>&), typeof(string)}, ReturnType = typeof(void))]
			[CalledBy(Type = typeof(PlayerInput), Member = "OnActionTriggered", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CallbackContext)}, ReturnType = typeof(void))]
			[CalledBy(Type = typeof(VirtualMouseInput), Member = "OnButtonActionTriggered", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CallbackContext)}, ReturnType = typeof(void))]
			[CallerCount(Count = 3)]
			[Calls(Type = typeof(InputActionState), Member = "GetActionOrNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(InputAction))]
			[CallsDeduplicatedMethods(Count = 1)]
			 get { } //Length: 79
		}

		private int actionIndex
		{
			[CallerCount(Count = 28)]
			[DeduplicatedMethod]
			private get { } //Length: 4
		}

		private int bindingIndex
		{
			[CalledBy(Type = typeof(CallbackContext), Member = "ReadValue", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, ReturnType = "TValue")]
			[CallerCount(Count = 2)]
			[CallsDeduplicatedMethods(Count = 1)]
			[CallsUnknownMethods(Count = 1)]
			private get { } //Length: 48
		}

		public bool canceled
		{
			[CalledBy(Type = typeof(PlayerInput), Member = "OnActionTriggered", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CallbackContext)}, ReturnType = typeof(void))]
			[CalledBy(Type = typeof(InputSystemUIInputModule), Member = "GetPointerStateIndexFor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CallbackContext&)}, ReturnType = typeof(int))]
			[CalledBy(Type = typeof(InputSystemUIInputModule), Member = "OnPointCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CallbackContext)}, ReturnType = typeof(void))]
			[CalledBy(Type = typeof(InputSystemUIInputModule), Member = "IgnoreNextClick", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CallbackContext&), typeof(bool)}, ReturnType = typeof(bool))]
			[CalledBy(Type = typeof(InputSystemUIInputModule), Member = "CheckForRemovedDevice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CallbackContext&)}, ReturnType = typeof(bool))]
			[CallerCount(Count = 6)]
			[CallsDeduplicatedMethods(Count = 1)]
			[ContainsUnimplementedInstructions]
			 get { } //Length: 63
		}

		public InputControl control
		{
			[CallerCount(Count = 48)]
			[Calls(Type = typeof(TriggerState), Member = "get_controlIndex", ReturnType = typeof(int))]
			[CallsDeduplicatedMethods(Count = 1)]
			[CallsUnknownMethods(Count = 2)]
			 get { } //Length: 108
		}

		private int controlIndex
		{
			[CalledBy(Type = typeof(CallbackContext), Member = "ReadValue", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, ReturnType = "TValue")]
			[CallerCount(Count = 1)]
			[Calls(Type = typeof(TriggerState), Member = "get_controlIndex", ReturnType = typeof(int))]
			[CallsDeduplicatedMethods(Count = 1)]
			[CallsUnknownMethods(Count = 1)]
			private get { } //Length: 52
		}

		public double duration
		{
			[CallerCount(Count = 0)]
			[CallsDeduplicatedMethods(Count = 2)]
			[ContainsUnimplementedInstructions]
			 get { } //Length: 111
		}

		public IInputInteraction interaction
		{
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(TriggerState), Member = "get_interactionIndex", ReturnType = typeof(int))]
			[CallsDeduplicatedMethods(Count = 1)]
			[CallsUnknownMethods(Count = 2)]
			 get { } //Length: 102
		}

		private int interactionIndex
		{
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(TriggerState), Member = "get_interactionIndex", ReturnType = typeof(int))]
			[CallsDeduplicatedMethods(Count = 1)]
			[CallsUnknownMethods(Count = 1)]
			private get { } //Length: 52
		}

		public bool performed
		{
			[CalledBy(Type = typeof(PlayerInput), Member = "OnActionTriggered", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CallbackContext)}, ReturnType = typeof(void))]
			[CallerCount(Count = 1)]
			[CallsDeduplicatedMethods(Count = 1)]
			[ContainsUnimplementedInstructions]
			 get { } //Length: 63
		}

		public InputActionPhase phase
		{
			[CalledBy(Type = typeof(CallbackContext), Member = "ReadValue", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, ReturnType = "TValue")]
			[CalledBy(Type = typeof(InputSystemUIInputModule), Member = "GetPointerStateIndexFor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CallbackContext&)}, ReturnType = typeof(int))]
			[CallerCount(Count = 2)]
			[CallsDeduplicatedMethods(Count = 1)]
			 get { } //Length: 51
		}

		public bool started
		{
			[CallerCount(Count = 0)]
			[CallsDeduplicatedMethods(Count = 1)]
			[ContainsUnimplementedInstructions]
			 get { } //Length: 63
		}

		public double startTime
		{
			[CallerCount(Count = 0)]
			[CallsDeduplicatedMethods(Count = 1)]
			 get { } //Length: 54
		}

		public double time
		{
			[CallerCount(Count = 0)]
			[CallsDeduplicatedMethods(Count = 1)]
			 get { } //Length: 54
		}

		public int valueSizeInBytes
		{
			[CalledBy(Type = typeof(CallbackContext), Member = "ReadValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(int)}, ReturnType = typeof(void))]
			[CalledBy(Type = typeof(InputActionTrace), Member = "RecordAction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CallbackContext)}, ReturnType = typeof(void))]
			[CallerCount(Count = 3)]
			[Calls(Type = typeof(TriggerState), Member = "get_controlIndex", ReturnType = typeof(int))]
			[Calls(Type = typeof(InputActionState), Member = "GetValueSizeInBytes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
			[CallsDeduplicatedMethods(Count = 2)]
			[CallsUnknownMethods(Count = 1)]
			 get { } //Length: 129
		}

		public Type valueType
		{
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(TriggerState), Member = "get_controlIndex", ReturnType = typeof(int))]
			[Calls(Type = typeof(InputActionState), Member = "GetValueType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(Type))]
			[CallsDeduplicatedMethods(Count = 2)]
			[CallsUnknownMethods(Count = 1)]
			 get { } //Length: 132
		}

		[CalledBy(Type = typeof(InputActionState), Member = "CallActionListeners", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(InputActionMap), typeof(InputActionPhase), typeof(CallbackArray`1<Action`1<CallbackContext>>&), typeof(string)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(PlayerInput), Member = "OnActionTriggered", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CallbackContext)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(VirtualMouseInput), Member = "OnButtonActionTriggered", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CallbackContext)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(InputActionState), Member = "GetActionOrNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(InputAction))]
		[CallsDeduplicatedMethods(Count = 1)]
		public InputAction get_action() { }

		[CallerCount(Count = 28)]
		[DeduplicatedMethod]
		private int get_actionIndex() { }

		[CalledBy(Type = typeof(CallbackContext), Member = "ReadValue", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, ReturnType = "TValue")]
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		private int get_bindingIndex() { }

		[CalledBy(Type = typeof(PlayerInput), Member = "OnActionTriggered", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CallbackContext)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InputSystemUIInputModule), Member = "GetPointerStateIndexFor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CallbackContext&)}, ReturnType = typeof(int))]
		[CalledBy(Type = typeof(InputSystemUIInputModule), Member = "OnPointCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CallbackContext)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InputSystemUIInputModule), Member = "IgnoreNextClick", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CallbackContext&), typeof(bool)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(InputSystemUIInputModule), Member = "CheckForRemovedDevice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CallbackContext&)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 6)]
		[CallsDeduplicatedMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		public bool get_canceled() { }

		[CallerCount(Count = 48)]
		[Calls(Type = typeof(TriggerState), Member = "get_controlIndex", ReturnType = typeof(int))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		public InputControl get_control() { }

		[CalledBy(Type = typeof(CallbackContext), Member = "ReadValue", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, ReturnType = "TValue")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(TriggerState), Member = "get_controlIndex", ReturnType = typeof(int))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		private int get_controlIndex() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		[ContainsUnimplementedInstructions]
		public double get_duration() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(TriggerState), Member = "get_interactionIndex", ReturnType = typeof(int))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		public IInputInteraction get_interaction() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(TriggerState), Member = "get_interactionIndex", ReturnType = typeof(int))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		private int get_interactionIndex() { }

		[CalledBy(Type = typeof(PlayerInput), Member = "OnActionTriggered", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CallbackContext)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		public bool get_performed() { }

		[CalledBy(Type = typeof(CallbackContext), Member = "ReadValue", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, ReturnType = "TValue")]
		[CalledBy(Type = typeof(InputSystemUIInputModule), Member = "GetPointerStateIndexFor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CallbackContext&)}, ReturnType = typeof(int))]
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		public InputActionPhase get_phase() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		public bool get_started() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		public double get_startTime() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		public double get_time() { }

		[CalledBy(Type = typeof(CallbackContext), Member = "ReadValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InputActionTrace), Member = "RecordAction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CallbackContext)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(TriggerState), Member = "get_controlIndex", ReturnType = typeof(int))]
		[Calls(Type = typeof(InputActionState), Member = "GetValueSizeInBytes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		public int get_valueSizeInBytes() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(TriggerState), Member = "get_controlIndex", ReturnType = typeof(int))]
		[Calls(Type = typeof(InputActionState), Member = "GetValueType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(Type))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		public Type get_valueType() { }

		[CalledBy(Type = typeof(InputActionTrace), Member = "RecordAction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CallbackContext)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(TriggerState), Member = "get_controlIndex", ReturnType = typeof(int))]
		[Calls(Type = typeof(InputActionState), Member = "ReadValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(Void*), typeof(int), typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CallbackContext), Member = "get_valueSizeInBytes", ReturnType = typeof(int))]
		[Calls(Type = typeof(UnsafeUtility), Member = "MemClear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(long)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 4)]
		[CallsUnknownMethods(Count = 10)]
		public void ReadValue(Void* buffer, int bufferSize) { }

		[CalledBy(Type = typeof(TrackedPoseDriver), Member = "OnTrackingStatePerformed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CallbackContext)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CallbackContext), Member = "get_phase", ReturnType = typeof(InputActionPhase))]
		[Calls(Type = typeof(CallbackContext), Member = "get_bindingIndex", ReturnType = typeof(int))]
		[Calls(Type = typeof(CallbackContext), Member = "get_controlIndex", ReturnType = typeof(int))]
		[Calls(Type = typeof(InputActionState), Member = "ReadValue", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(bool)}, ReturnType = "TValue")]
		[Calls(Type = typeof(InputActionState), Member = "ApplyProcessors", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), "TValue", "UnityEngine.InputSystem.InputControl`1<TValue>"}, ReturnType = "TValue")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		public TValue ReadValue() { }

		[CalledBy(Type = typeof(InputSystemUIInputModule), Member = "OnLeftClickCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CallbackContext)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InputSystemUIInputModule), Member = "OnRightClickCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CallbackContext)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InputSystemUIInputModule), Member = "OnMiddleClickCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CallbackContext)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.InputSystem.Plugins.InputForUI.InputSystemProvider", Member = "OnClickPerformed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CallbackContext), "UnityEngine.InputForUI.EventSource", "UnityEngine.InputForUI.PointerEvent+Button"}, ReturnType = typeof(void))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(TriggerState), Member = "get_controlIndex", ReturnType = typeof(int))]
		[Calls(Type = typeof(InputActionState), Member = "ReadValueAsButton", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(bool))]
		[CallsDeduplicatedMethods(Count = 4)]
		[CallsUnknownMethods(Count = 1)]
		public bool ReadValueAsButton() { }

		[CalledBy(Type = typeof(CallbackContext), Member = "ToString", ReturnType = typeof(string))]
		[CalledBy(Type = typeof(InputValue), Member = "Get", ReturnType = typeof(object))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(TriggerState), Member = "get_controlIndex", ReturnType = typeof(int))]
		[Calls(Type = typeof(InputActionState), Member = "ReadValueAsObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(bool)}, ReturnType = typeof(object))]
		[CallsDeduplicatedMethods(Count = 4)]
		[CallsUnknownMethods(Count = 1)]
		public object ReadValueAsObject() { }

		[CalledBy(Type = typeof(PlayerInput), Member = "DebugLogAction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CallbackContext)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(InputActionState), Member = "GetActionOrNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(InputAction))]
		[Calls(Type = typeof(TriggerState), Member = "get_controlIndex", ReturnType = typeof(int))]
		[Calls(Type = typeof(CallbackContext), Member = "ReadValueAsObject", ReturnType = typeof(object))]
		[Calls(Type = typeof(TriggerState), Member = "get_interactionIndex", ReturnType = typeof(int))]
		[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
		[CallsDeduplicatedMethods(Count = 5)]
		[CallsUnknownMethods(Count = 26)]
		public virtual string ToString() { }

	}

	private static readonly ProfilerMarker k_InputActionEnableProfilerMarker; //Field offset: 0x0
	private static readonly ProfilerMarker k_InputActionDisableProfilerMarker; //Field offset: 0x8
	[SerializeField]
	[Tooltip("Human readable name of the action. Must be unique within its action map (case is ignored). Can be changed without breaking references to the action.")]
	internal string m_Name; //Field offset: 0x10
	[SerializeField]
	[Tooltip("Determines how the action triggers.\n\nA Value action will start and perform when a control moves from its default value and then perform on every value change. It will cancel when controls go back to default value. Also, when enabled, a Value action will respond right away to a control's current value.\n\nA Button action will start when a button is pressed and perform when the press threshold (see 'Default Button Press Point' in settings) is reached. It will cancel when the button is going below the release threshold (see 'Button Release Threshold' in settings). Also, if a button is already pressed when the action is enabled, the button has to be released first.\n\nA Pass-Through action will not explicitly start and will never cancel. Instead, for every value change on any bound control, the action will perform.")]
	internal InputActionType m_Type; //Field offset: 0x18
	[FormerlySerializedAs("m_ExpectedControlLayout")]
	[SerializeField]
	[Tooltip("The type of control expected by the action (e.g. \"Digital\" for buttons, \"Vector2\" for sticks). This will limit the controls shown when setting up bindings in the UI and will also limit which controls can be bound interactively to the action.")]
	internal string m_ExpectedControlType; //Field offset: 0x20
	[SerializeField]
	[Tooltip("Unique ID of the action (GUID). Used to reference the action from bindings such that actions can be renamed without breaking references.")]
	internal string m_Id; //Field offset: 0x28
	[SerializeField]
	internal string m_Processors; //Field offset: 0x30
	[SerializeField]
	internal string m_Interactions; //Field offset: 0x38
	[SerializeField]
	internal InputBinding[] m_SingletonActionBindings; //Field offset: 0x40
	[SerializeField]
	internal ActionFlags m_Flags; //Field offset: 0x48
	internal Nullable<InputBinding> m_BindingMask; //Field offset: 0x50
	internal int m_BindingsStartIndex; //Field offset: 0xB0
	internal int m_BindingsCount; //Field offset: 0xB4
	internal int m_ControlStartIndex; //Field offset: 0xB8
	internal int m_ControlCount; //Field offset: 0xBC
	internal int m_ActionIndexInState; //Field offset: 0xC0
	internal InputActionMap m_ActionMap; //Field offset: 0xC8
	internal CallbackArray<Action`1<CallbackContext>> m_OnStarted; //Field offset: 0xD0
	internal CallbackArray<Action`1<CallbackContext>> m_OnCanceled; //Field offset: 0x120
	internal CallbackArray<Action`1<CallbackContext>> m_OnPerformed; //Field offset: 0x170

	public event Action<CallbackContext> canceled
	{
		[CalledBy(Type = typeof(PlayerActions), Member = "SetCallbacks", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPlayerActions)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InputActionTrace), Member = "SubscribeTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputAction)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InputActionTrace), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputAction)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(VirtualMouseInput), Member = "SetActionCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionProperty), typeof(System.Action`1<UnityEngine.InputSystem.InputAction+CallbackContext>), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(VirtualMouseInput), Member = "OnEnable", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(VirtualMouseInput), Member = "set_backButtonAction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionProperty)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(VirtualMouseInput), Member = "set_forwardButtonAction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionProperty)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(VirtualMouseInput), Member = "set_middleButtonAction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionProperty)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(VirtualMouseInput), Member = "set_rightButtonAction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionProperty)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(VirtualMouseInput), Member = "set_leftButtonAction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionProperty)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InputSystemUIInputModule), Member = "SetActionCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionReference), typeof(System.Action`1<UnityEngine.InputSystem.InputAction+CallbackContext>), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InputSystemUIInputModule), Member = "SetActionCallbacks", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InputSystemUIInputModule), Member = "SwapAction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionReference&), typeof(InputActionReference), typeof(bool), typeof(System.Action`1<UnityEngine.InputSystem.InputAction+CallbackContext>)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TrackedPoseDriver), Member = "BindTrackingState", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TrackedPoseDriver), Member = "BindRotation", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TrackedPoseDriver), Member = "BindPosition", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(PlayerInput), Member = "InitializeActions", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UIActions), Member = "SetCallbacks", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IUIActions)}, ReturnType = typeof(void))]
		[CallerCount(Count = 42)]
		[Calls(Type = typeof(CallbackArray`1), Member = "AddCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TDelegate"}, ReturnType = typeof(void))]
		 add { } //Length: 76
		[CalledBy(Type = typeof(PlayerActions), Member = "SetCallbacks", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPlayerActions)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InputActionTrace), Member = "UnsubscribeFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputAction)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InputActionTrace), Member = "UnsubscribeFromAll", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InputActionTrace), Member = "SubscribeToAll", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(VirtualMouseInput), Member = "SetActionCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionProperty), typeof(System.Action`1<UnityEngine.InputSystem.InputAction+CallbackContext>), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(VirtualMouseInput), Member = "OnDisable", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(VirtualMouseInput), Member = "set_backButtonAction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionProperty)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(VirtualMouseInput), Member = "set_forwardButtonAction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionProperty)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(VirtualMouseInput), Member = "set_middleButtonAction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionProperty)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(VirtualMouseInput), Member = "set_rightButtonAction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionProperty)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InputSystemUIInputModule), Member = "SetActionCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionReference), typeof(System.Action`1<UnityEngine.InputSystem.InputAction+CallbackContext>), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InputSystemUIInputModule), Member = "SetActionCallbacks", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InputSystemUIInputModule), Member = "SwapAction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionReference&), typeof(InputActionReference), typeof(bool), typeof(System.Action`1<UnityEngine.InputSystem.InputAction+CallbackContext>)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TrackedPoseDriver), Member = "UnbindTrackingState", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TrackedPoseDriver), Member = "UnbindRotation", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TrackedPoseDriver), Member = "UnbindPosition", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(PlayerInput), Member = "UninitializeActions", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UIActions), Member = "SetCallbacks", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IUIActions)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(VirtualMouseInput), Member = "set_leftButtonAction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionProperty)}, ReturnType = typeof(void))]
		[CallerCount(Count = 43)]
		[Calls(Type = typeof(CallbackArray`1), Member = "RemoveCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TDelegate"}, ReturnType = typeof(void))]
		 remove { } //Length: 76
	}

	public event Action<CallbackContext> performed
	{
		[CalledBy(Type = typeof(PlayerActions), Member = "SetCallbacks", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPlayerActions)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.InputSystem.Plugins.InputForUI.InputSystemProvider", Member = "RegisterActions", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.InputSystem.Plugins.InputForUI.InputSystemProvider", Member = "FindActionAndRegisterCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "System.Action`1<CallbackContext>"}, ReturnType = typeof(InputAction))]
		[CalledBy(Type = typeof(InputActionTrace), Member = "SubscribeTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputAction)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InputActionTrace), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputAction)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(OnScreenStick), Member = "OnPointerDown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CallbackContext)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(OnScreenStick), Member = "Start", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InputSystemUIInputModule), Member = "SetActionCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionReference), typeof(System.Action`1<UnityEngine.InputSystem.InputAction+CallbackContext>), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InputSystemUIInputModule), Member = "SetActionCallbacks", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InputSystemUIInputModule), Member = "SwapAction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionReference&), typeof(InputActionReference), typeof(bool), typeof(System.Action`1<UnityEngine.InputSystem.InputAction+CallbackContext>)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TrackedPoseDriver), Member = "BindTrackingState", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TrackedPoseDriver), Member = "BindRotation", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TrackedPoseDriver), Member = "BindPosition", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(PlayerInputManager), Member = "EnableJoining", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(PlayerInput), Member = "InitializeActions", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UIActions), Member = "SetCallbacks", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IUIActions)}, ReturnType = typeof(void))]
		[CallerCount(Count = 42)]
		[Calls(Type = typeof(CallbackArray`1), Member = "AddCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TDelegate"}, ReturnType = typeof(void))]
		 add { } //Length: 76
		[CalledBy(Type = typeof(PlayerActions), Member = "SetCallbacks", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPlayerActions)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.InputSystem.Plugins.InputForUI.InputSystemProvider", Member = "UnregisterActions", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.InputSystem.Plugins.InputForUI.InputSystemProvider", Member = "UnregisterAction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputAction&), "System.Action`1<CallbackContext>"}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InputActionTrace), Member = "UnsubscribeFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputAction)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InputActionTrace), Member = "UnsubscribeFromAll", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InputActionTrace), Member = "SubscribeToAll", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(OnScreenStick), Member = "OnPointerUp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CallbackContext)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(OnScreenStick), Member = "OnPointerChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CallbackContext)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(OnScreenStick), Member = "OnDestroy", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InputSystemUIInputModule), Member = "SetActionCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionReference), typeof(System.Action`1<UnityEngine.InputSystem.InputAction+CallbackContext>), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InputSystemUIInputModule), Member = "SetActionCallbacks", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InputSystemUIInputModule), Member = "SwapAction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionReference&), typeof(InputActionReference), typeof(bool), typeof(System.Action`1<UnityEngine.InputSystem.InputAction+CallbackContext>)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TrackedPoseDriver), Member = "UnbindTrackingState", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TrackedPoseDriver), Member = "UnbindRotation", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TrackedPoseDriver), Member = "UnbindPosition", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(PlayerInputManager), Member = "DisableJoining", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(PlayerInput), Member = "UninitializeActions", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UIActions), Member = "SetCallbacks", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IUIActions)}, ReturnType = typeof(void))]
		[CallerCount(Count = 44)]
		[Calls(Type = typeof(CallbackArray`1), Member = "RemoveCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TDelegate"}, ReturnType = typeof(void))]
		 remove { } //Length: 76
	}

	public event Action<CallbackContext> started
	{
		[CalledBy(Type = typeof(PlayerActions), Member = "SetCallbacks", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPlayerActions)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UIActions), Member = "SetCallbacks", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IUIActions)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(PlayerInput), Member = "InitializeActions", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(VirtualMouseInput), Member = "set_leftButtonAction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionProperty)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(VirtualMouseInput), Member = "set_rightButtonAction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionProperty)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(VirtualMouseInput), Member = "set_middleButtonAction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionProperty)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(VirtualMouseInput), Member = "set_forwardButtonAction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionProperty)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(VirtualMouseInput), Member = "set_backButtonAction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionProperty)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(VirtualMouseInput), Member = "OnEnable", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(VirtualMouseInput), Member = "SetActionCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionProperty), typeof(System.Action`1<UnityEngine.InputSystem.InputAction+CallbackContext>), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InputActionTrace), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputAction)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InputActionTrace), Member = "SubscribeTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputAction)}, ReturnType = typeof(void))]
		[CallerCount(Count = 27)]
		[Calls(Type = typeof(CallbackArray`1), Member = "AddCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TDelegate"}, ReturnType = typeof(void))]
		 add { } //Length: 76
		[CalledBy(Type = typeof(PlayerActions), Member = "SetCallbacks", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPlayerActions)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UIActions), Member = "SetCallbacks", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IUIActions)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(PlayerInput), Member = "UninitializeActions", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(VirtualMouseInput), Member = "set_leftButtonAction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionProperty)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(VirtualMouseInput), Member = "set_rightButtonAction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionProperty)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(VirtualMouseInput), Member = "set_middleButtonAction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionProperty)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(VirtualMouseInput), Member = "set_forwardButtonAction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionProperty)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(VirtualMouseInput), Member = "set_backButtonAction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionProperty)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(VirtualMouseInput), Member = "OnDisable", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(VirtualMouseInput), Member = "SetActionCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionProperty), typeof(System.Action`1<UnityEngine.InputSystem.InputAction+CallbackContext>), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InputActionTrace), Member = "SubscribeToAll", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InputActionTrace), Member = "UnsubscribeFromAll", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InputActionTrace), Member = "UnsubscribeFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputAction)}, ReturnType = typeof(void))]
		[CallerCount(Count = 28)]
		[Calls(Type = typeof(CallbackArray`1), Member = "RemoveCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TDelegate"}, ReturnType = typeof(void))]
		 remove { } //Length: 76
	}

	public InputActionMap actionMap
	{
		[CalledBy(Type = typeof(InputActionReference), Member = "get_action", ReturnType = typeof(InputAction))]
		[CalledBy(Type = typeof(InputActionReference), Member = "Set", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputAction)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InputActionReference), Member = "SetInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionAsset), typeof(InputAction)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InputActionReference), Member = "ToString", ReturnType = typeof(string))]
		[CalledBy(Type = typeof(InputActionReference), Member = "GetDisplayName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputAction)}, ReturnType = typeof(string))]
		[CalledBy(Type = typeof(InputActionReference), Member = "ToDisplayName", ReturnType = typeof(string))]
		[CalledBy(Type = typeof(InputActionReference), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputAction)}, ReturnType = typeof(InputActionReference))]
		[CalledBy(Type = typeof(InputActionSetupExtensions), Member = "RemoveAction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputAction)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InputActionSetupExtensions), Member = "AddBinding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionMap), typeof(string), typeof(InputAction), typeof(string), typeof(string)}, ReturnType = typeof(BindingSyntax))]
		[CalledBy(Type = typeof(InputActionSetupExtensions), Member = "Rename", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputAction), typeof(string)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ActionEvent), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputAction)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(PlayerInputManager), Member = "OnEnable", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InputSystemUIInputModule), Member = "UpdateReferenceForNewAsset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionReference)}, ReturnType = typeof(InputActionReference))]
		[CalledBy(Type = typeof(InputSystemUIInputModule), Member = "set_actionsAsset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionAsset)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ActionEventPtr), Member = "ToString", ReturnType = typeof(string))]
		[CallerCount(Count = 33)]
		 get { } //Length: 26
	}

	public InputControl activeControl
	{
		[CalledBy(Type = typeof(InputActionState), Member = "PrepareForBindingReResolution", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(InputControlList`1<InputControl>&), typeof(Boolean&)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.InputSystem.Plugins.InputForUI.InputSystemProvider", Member = "DirectionNavigation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DiscreteTime)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.InputSystem.Plugins.InputForUI.InputSystemProvider", Member = "GetActiveDeviceFromDirection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.InputForUI.NavigationEvent+Direction"}, ReturnType = typeof(InputDevice))]
		[CalledBy(Type = "UnityEngine.InputSystem.Plugins.InputForUI.InputSystemProvider", Member = "ReadNextPreviousDirection", ReturnType = "UnityEngine.InputForUI.NavigationEvent+Direction")]
		[CallerCount(Count = 7)]
		[Calls(Type = typeof(InputAction), Member = "GetOrCreateActionMap", ReturnType = typeof(InputActionMap))]
		[Calls(Type = typeof(TriggerState), Member = "get_controlIndex", ReturnType = typeof(int))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		 get { } //Length: 126
	}

	public Type activeValueType
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InputAction), Member = "GetOrCreateActionMap", ReturnType = typeof(InputActionMap))]
		[Calls(Type = typeof(TriggerState), Member = "get_controlIndex", ReturnType = typeof(int))]
		[Calls(Type = typeof(InputActionState), Member = "GetValueType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(Type))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 120
	}

	public Nullable<InputBinding> bindingMask
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 60
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InputBinding), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputBinding), typeof(InputBinding)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(System.Nullable`1<UnityEngine.InputSystem.InputBinding>), Member = "get_Value", ReturnType = typeof(InputBinding))]
		[Calls(Type = typeof(System.Nullable`1<UnityEngine.InputSystem.InputBinding>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputBinding)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(InputAction), Member = "GetOrCreateActionMap", ReturnType = typeof(InputActionMap))]
		[Calls(Type = typeof(InputActionMap), Member = "LazyResolveBindings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 3)]
		[ContainsUnimplementedInstructions]
		 set { } //Length: 799
	}

	public ReadOnlyArray<InputBinding> bindings
	{
		[CalledBy(Type = typeof(RebindingOperation), Member = "OnComplete", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InputActionSetupExtensions), Member = "RemoveAction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputAction)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(OnScreenStick), Member = "Start", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.DebugManager", Member = "SampleAction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.DebugManager", Member = "UpdateActions", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.DebugActionState", Member = "TriggerWithButton", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputAction), typeof(float)}, ReturnType = typeof(void))]
		[CallerCount(Count = 8)]
		[Calls(Type = typeof(InputAction), Member = "GetOrCreateActionMap", ReturnType = typeof(InputActionMap))]
		[Calls(Type = typeof(InputActionMap), Member = "SetUpPerActionControlAndBindingArrays", ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		 get { } //Length: 177
	}

	public ReadOnlyArray<InputControl> controls
	{
		[CalledBy(Type = typeof(InputSystemUIInputModule), Member = "GetPointerStateIndexFor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl), typeof(bool)}, ReturnType = typeof(int))]
		[CalledBy(Type = typeof(InputSystemUIInputModule), Member = "HaveControlForDevice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice), typeof(InputActionReference)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(InputAction), Member = "GetOrCreateActionMap", ReturnType = typeof(InputActionMap))]
		[Calls(Type = typeof(InputActionMap), Member = "ResolveBindings", ReturnType = typeof(void))]
		[Calls(Type = typeof(InputActionMap), Member = "SetUpPerActionControlAndBindingArrays", ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		 get { } //Length: 220
	}

	private TriggerState currentState
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InputActionState), Member = "FetchActionState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputAction)}, ReturnType = typeof(TriggerState&))]
		[CallsUnknownMethods(Count = 1)]
		private get { } //Length: 129
	}

	public bool enabled
	{
		[CalledBy(Type = typeof(InputActionAsset), Member = "FindAction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(InputAction))]
		[CalledBy(Type = typeof(InputActionState), Member = "RestoreActionStatesAfterReResolvingBindings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnmanagedMemory), typeof(UnityEngine.InputSystem.InputControlList`1<UnityEngine.InputSystem.InputControl>), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TrackedPoseDriver), Member = "UpdateCallback", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TrackedPoseDriver), Member = "ReadTrackingState", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InputSystemUIInputModule), Member = "SwapAction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionReference&), typeof(InputActionReference), typeof(bool), typeof(System.Action`1<UnityEngine.InputSystem.InputAction+CallbackContext>)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InputSystemUIInputModule), Member = "EnableInputAction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionReference)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(VirtualMouseInput), Member = "SetAction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionProperty&), typeof(InputActionProperty)}, ReturnType = typeof(void))]
		[CallerCount(Count = 7)]
		[Calls(Type = typeof(InputActionState), Member = "FetchActionState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputAction)}, ReturnType = typeof(TriggerState&))]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 87
	}

	public string expectedControlType
	{
		[CallerCount(Count = 12)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 10)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 set { } //Length: 13
	}

	public Guid id
	{
		[CalledBy(Type = typeof(InputActionReference), Member = "SetInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionAsset), typeof(InputAction)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InputActionSetupExtensions), Member = "AddBinding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionMap), typeof(string), typeof(InputAction), typeof(string), typeof(string)}, ReturnType = typeof(BindingSyntax))]
		[CalledBy(Type = typeof(InputActionSetupExtensions), Member = "ChangeBinding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputAction), typeof(InputBinding)}, ReturnType = typeof(BindingSyntax))]
		[CalledBy(Type = typeof(ActionEvent), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputAction)}, ReturnType = typeof(void))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Guid), Member = "NewGuid", ReturnType = typeof(Guid))]
		[Calls(Type = typeof(Guid), Member = "ToString", ReturnType = typeof(string))]
		[Calls(Type = typeof(Guid), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 122
	}

	internal Guid idDontGenerate
	{
		[CalledBy(Type = typeof(InputActionSetupExtensions), Member = "ChangeBinding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputAction), typeof(InputBinding)}, ReturnType = typeof(BindingSyntax))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Guid), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		internal get { } //Length: 78
	}

	public bool inProgress
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InputActionState), Member = "FetchActionState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputAction)}, ReturnType = typeof(TriggerState&))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 95
	}

	public string interactions
	{
		[CallerCount(Count = 38)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	internal bool isSingletonAction
	{
		[CalledBy(Type = typeof(BindingSyntax), Member = "Triggering", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputAction)}, ReturnType = typeof(BindingSyntax))]
		[CalledBy(Type = typeof(ActionEvent), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputAction)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[ContainsUnimplementedInstructions]
		internal get { } //Length: 28
	}

	public string name
	{
		[CallerCount(Count = 106)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public InputActionPhase phase
	{
		[CalledBy(Type = typeof(InputActionState), Member = "PrepareForBindingReResolution", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(InputControlList`1<InputControl>&), typeof(Boolean&)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(InputActionState), Member = "FetchActionState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputAction)}, ReturnType = typeof(TriggerState&))]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 83
	}

	public string processors
	{
		[CallerCount(Count = 62)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public bool triggered
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InputAction), Member = "GetOrCreateActionMap", ReturnType = typeof(InputActionMap))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 137
	}

	public InputActionType type
	{
		[CallerCount(Count = 7)]
		[DeduplicatedMethod]
		 get { } //Length: 4
	}

	public bool wantsInitialStateCheck
	{
		[CalledBy(Type = typeof(InputBindingResolver), Member = "AddActionMap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionMap)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		 get { } //Length: 16
		[CallerCount(Count = 0)]
		 set { } //Length: 25
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ProfilerUnsafeUtility), Member = "CreateMarker", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(ushort), typeof(MarkerFlags), typeof(int)}, ReturnType = typeof(IntPtr))]
	private static InputAction() { }

	[CalledBy(Type = typeof(InputAction), Member = "Clone", ReturnType = typeof(InputAction))]
	[CalledBy(Type = typeof(InputAction), Member = "System.ICloneable.Clone", ReturnType = typeof(object))]
	[CalledBy(Type = typeof(ReadActionJson), Member = "ToAction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(InputAction))]
	[CalledBy(Type = typeof(InputActionSetupExtensions), Member = "AddAction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionMap), typeof(string), typeof(InputActionType), typeof(string), typeof(string), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(InputAction))]
	[CalledBy(Type = typeof(TrackedPoseDriver), Member = "Reset", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(OnScreenStick), Member = "Start", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.InputSystem.Plugins.InputForUI.InputSystemProvider", Member = "Initialize", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.InputSystem.Plugins.InputForUI.InputSystemProvider", Member = "RegisterFixedActions", ReturnType = typeof(void))]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Guid), Member = "NewGuid", ReturnType = typeof(Guid))]
	[Calls(Type = typeof(InputBinding), Member = "set_id", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Guid)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Guid), Member = "ToString", ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 13)]
	public InputAction(string name = null, InputActionType type = 0, string binding = null, string interactions = null, string processors = null, string expectedControlType = null) { }

	[CalledBy(Type = typeof(OnScreenStick), Member = "Start", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Guid), Member = "NewGuid", ReturnType = typeof(Guid))]
	[Calls(Type = typeof(Guid), Member = "ToString", ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public InputAction() { }

	[CalledBy(Type = typeof(InputActionState), Member = "PrepareForBindingReResolution", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(InputControlList`1<InputControl>&), typeof(Boolean&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(InputDevice), Member = "get_added", ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputAction), Member = "GetOrCreateActionMap", ReturnType = typeof(InputActionMap))]
	[Calls(Type = typeof(DeviceArray), Member = "Get", ReturnType = typeof(System.Nullable`1<UnityEngine.InputSystem.Utilities.ReadOnlyArray`1<UnityEngine.InputSystem.InputDevice>>))]
	[Calls(Type = typeof(Nullable`1), Member = "get_Value", ReturnType = "T")]
	[Calls(Type = typeof(ReadOnlyArrayExtensions), Member = "ContainsReference", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.InputSystem.Utilities.ReadOnlyArray`1<TValue>", "TValue"}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	internal bool ActiveControlIsValid(InputControl control) { }

	[CalledBy(Type = typeof(PlayerActions), Member = "SetCallbacks", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPlayerActions)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UIActions), Member = "SetCallbacks", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IUIActions)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PlayerInput), Member = "InitializeActions", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TrackedPoseDriver), Member = "BindPosition", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TrackedPoseDriver), Member = "BindRotation", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TrackedPoseDriver), Member = "BindTrackingState", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputSystemUIInputModule), Member = "SwapAction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionReference&), typeof(InputActionReference), typeof(bool), typeof(System.Action`1<UnityEngine.InputSystem.InputAction+CallbackContext>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputSystemUIInputModule), Member = "SetActionCallbacks", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputSystemUIInputModule), Member = "SetActionCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionReference), typeof(System.Action`1<UnityEngine.InputSystem.InputAction+CallbackContext>), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VirtualMouseInput), Member = "set_leftButtonAction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionProperty)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VirtualMouseInput), Member = "set_rightButtonAction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionProperty)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VirtualMouseInput), Member = "set_middleButtonAction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionProperty)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VirtualMouseInput), Member = "set_forwardButtonAction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionProperty)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VirtualMouseInput), Member = "set_backButtonAction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionProperty)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VirtualMouseInput), Member = "OnEnable", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VirtualMouseInput), Member = "SetActionCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionProperty), typeof(System.Action`1<UnityEngine.InputSystem.InputAction+CallbackContext>), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputActionTrace), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputAction)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputActionTrace), Member = "SubscribeTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputAction)}, ReturnType = typeof(void))]
	[CallerCount(Count = 42)]
	[Calls(Type = typeof(CallbackArray`1), Member = "AddCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TDelegate"}, ReturnType = typeof(void))]
	public void add_canceled(Action<CallbackContext> value) { }

	[CalledBy(Type = typeof(PlayerActions), Member = "SetCallbacks", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPlayerActions)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UIActions), Member = "SetCallbacks", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IUIActions)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PlayerInput), Member = "InitializeActions", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PlayerInputManager), Member = "EnableJoining", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TrackedPoseDriver), Member = "BindPosition", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TrackedPoseDriver), Member = "BindRotation", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TrackedPoseDriver), Member = "BindTrackingState", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputSystemUIInputModule), Member = "SwapAction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionReference&), typeof(InputActionReference), typeof(bool), typeof(System.Action`1<UnityEngine.InputSystem.InputAction+CallbackContext>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputSystemUIInputModule), Member = "SetActionCallbacks", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputSystemUIInputModule), Member = "SetActionCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionReference), typeof(System.Action`1<UnityEngine.InputSystem.InputAction+CallbackContext>), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(OnScreenStick), Member = "Start", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(OnScreenStick), Member = "OnPointerDown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CallbackContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputActionTrace), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputAction)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputActionTrace), Member = "SubscribeTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputAction)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.InputSystem.Plugins.InputForUI.InputSystemProvider", Member = "FindActionAndRegisterCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "System.Action`1<CallbackContext>"}, ReturnType = typeof(InputAction))]
	[CalledBy(Type = "UnityEngine.InputSystem.Plugins.InputForUI.InputSystemProvider", Member = "RegisterActions", ReturnType = typeof(void))]
	[CallerCount(Count = 42)]
	[Calls(Type = typeof(CallbackArray`1), Member = "AddCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TDelegate"}, ReturnType = typeof(void))]
	public void add_performed(Action<CallbackContext> value) { }

	[CalledBy(Type = typeof(PlayerActions), Member = "SetCallbacks", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPlayerActions)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UIActions), Member = "SetCallbacks", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IUIActions)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PlayerInput), Member = "InitializeActions", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VirtualMouseInput), Member = "set_leftButtonAction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionProperty)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VirtualMouseInput), Member = "set_rightButtonAction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionProperty)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VirtualMouseInput), Member = "set_middleButtonAction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionProperty)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VirtualMouseInput), Member = "set_forwardButtonAction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionProperty)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VirtualMouseInput), Member = "set_backButtonAction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionProperty)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VirtualMouseInput), Member = "OnEnable", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VirtualMouseInput), Member = "SetActionCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionProperty), typeof(System.Action`1<UnityEngine.InputSystem.InputAction+CallbackContext>), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputActionTrace), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputAction)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputActionTrace), Member = "SubscribeTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputAction)}, ReturnType = typeof(void))]
	[CallerCount(Count = 27)]
	[Calls(Type = typeof(CallbackArray`1), Member = "AddCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TDelegate"}, ReturnType = typeof(void))]
	public void add_started(Action<CallbackContext> value) { }

	[CalledBy(Type = typeof(InputActionRebindingExtensions), Member = "GetParameterValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputAction), typeof(string), typeof(int)}, ReturnType = typeof(System.Nullable`1<UnityEngine.InputSystem.Utilities.PrimitiveValue>))]
	[CalledBy(Type = typeof(InputActionRebindingExtensions), Member = "ApplyParameterOverride", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputAction), typeof(string), typeof(PrimitiveValue), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputActionRebindingExtensions), Member = "GetBindingDisplayString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputAction), typeof(int), typeof(String&), typeof(String&), typeof(DisplayStringOptions)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(InputActionRebindingExtensions), Member = "ApplyBindingOverride", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputAction), typeof(int), typeof(InputBinding)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputActionRebindingExtensions), Member = "ApplyBindingOverride", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputAction), typeof(int), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputActionRebindingExtensions), Member = "RemoveBindingOverride", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputAction), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputActionRebindingExtensions), Member = "LoadBindingOverridesFromJsonInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IInputActionCollection2), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputActionSetupExtensions), Member = "ChangeBinding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputAction), typeof(int)}, ReturnType = typeof(BindingSyntax))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(InputAction), Member = "GetOrCreateActionMap", ReturnType = typeof(InputActionMap))]
	[Calls(Type = typeof(ArrayHelpers), Member = "LengthSafe", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TValue[]"}, ReturnType = typeof(int))]
	[Calls(Type = typeof(InputBinding), Member = "TriggersAction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputAction)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 8)]
	internal int BindingIndexOnActionToBindingIndexOnMap(int indexOfBindingOnAction) { }

	[CalledBy(Type = typeof(InputActionMap), Member = "FindBinding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputBinding), typeof(InputAction&)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(InputActionRebindingExtensions), Member = "GetBindingIndexForControl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputAction), typeof(InputControl)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(BindingSyntax), Member = "get_bindingIndex", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(CompositeSyntax), Member = "get_bindingIndex", ReturnType = typeof(int))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(InputAction), Member = "GetOrCreateActionMap", ReturnType = typeof(InputActionMap))]
	[Calls(Type = typeof(string), Member = "Compare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(StringComparison)}, ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	internal int BindingIndexOnMapToBindingIndexOnAction(int indexOfBindingOnMap) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputAction), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(InputActionType), typeof(string), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputAction), Member = "GetOrCreateActionMap", ReturnType = typeof(InputActionMap))]
	[Calls(Type = typeof(InputActionMap), Member = "SetUpPerActionControlAndBindingArrays", ReturnType = typeof(void))]
	[Calls(Type = typeof(ReadOnlyArray`1), Member = "ToArray", ReturnType = "TValue[]")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	[DeduplicatedMethod]
	public InputAction Clone() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputActionMap), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 7)]
	private void CreateInternalActionMapForSingletonAction() { }

	[CalledBy(Type = typeof(InputActionRebindingExtensions), Member = "ApplyBindingOverride", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputAction), typeof(InputBinding)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PlayerInputManager), Member = "DisableJoining", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TrackedPoseDriver), Member = "UnbindPosition", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TrackedPoseDriver), Member = "UnbindRotation", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TrackedPoseDriver), Member = "UnbindTrackingState", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputSystemUIInputModule), Member = "TryDisableInputAction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionReference), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VirtualMouseInput), Member = "OnDisable", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VirtualMouseInput), Member = "SetAction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionProperty&), typeof(InputActionProperty)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.InputSystem.Plugins.InputForUI.InputSystemProvider", Member = "Shutdown", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.InputSystem.Plugins.InputForUI.InputSystemProvider", Member = "UnregisterFixedActions", ReturnType = typeof(void))]
	[CallerCount(Count = 16)]
	[Calls(Type = typeof(ProfilerUnsafeUtility), Member = "BeginSample", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputActionState), Member = "FetchActionState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputAction)}, ReturnType = typeof(TriggerState&))]
	[Calls(Type = typeof(InputActionState), Member = "DisableSingleAction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputAction)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ProfilerUnsafeUtility), Member = "EndSample", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	public void Disable() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputActionState), Member = "Dispose", ReturnType = typeof(void))]
	public override void Dispose() { }

	[CalledBy(Type = typeof(InputActionRebindingExtensions), Member = "ApplyBindingOverride", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputAction), typeof(InputBinding)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.InputSystem.Plugins.InputForUI.InputSystemProvider", Member = "RegisterFixedActions", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.InputSystem.Plugins.InputForUI.InputSystemProvider", Member = "Initialize", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.DebugManager", Member = "EnableInputActions", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(OnScreenStick), Member = "Start", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VirtualMouseInput), Member = "SetAction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionProperty&), typeof(InputActionProperty)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VirtualMouseInput), Member = "OnEnable", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.FreeCamera", Member = "RegisterInputs", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TrackedPoseDriver), Member = "RenameAndEnable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputAction), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TrackedPoseDriver), Member = "BindTrackingState", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TrackedPoseDriver), Member = "BindRotation", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TrackedPoseDriver), Member = "BindPosition", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PlayerInputManager), Member = "EnableJoining", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputSystemUIInputModule), Member = "EnableInputAction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionReference)}, ReturnType = typeof(void))]
	[CallerCount(Count = 25)]
	[Calls(Type = typeof(ProfilerUnsafeUtility), Member = "EndSample", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ProfilerUnsafeUtility), Member = "BeginSample", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputActionState), Member = "FetchActionState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputAction)}, ReturnType = typeof(TriggerState&))]
	[Calls(Type = typeof(InputAction), Member = "GetOrCreateActionMap", ReturnType = typeof(InputActionMap))]
	[Calls(Type = typeof(InputActionMap), Member = "ResolveBindings", ReturnType = typeof(void))]
	[Calls(Type = typeof(InputActionState), Member = "EnableSingleAction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputAction)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	public void Enable() { }

	[CalledBy(Type = typeof(InputAction), Member = "WasPressedThisDynamicUpdate", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(InputAction), Member = "WasReleasedThisDynamicUpdate", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(InputAction), Member = "WasPerformedThisDynamicUpdate", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(InputAction), Member = "WasCompletedThisDynamicUpdate", ReturnType = typeof(bool))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(InputSystem), Member = "get_settings", ReturnType = typeof(InputSettings))]
	[Calls(Type = typeof(Time), Member = "get_frameCount", ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private int ExpectedFrame() { }

	[CallerCount(Count = 0)]
	internal Nullable<InputBinding> FindEffectiveBindingMask() { }

	[CalledBy(Type = typeof(InputActionSetupExtensions), Member = "AddAction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionMap), typeof(string), typeof(InputActionType), typeof(string), typeof(string), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(InputAction))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Guid), Member = "NewGuid", ReturnType = typeof(Guid))]
	[Calls(Type = typeof(Guid), Member = "ToString", ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 1)]
	internal void GenerateId() { }

	[CalledBy(Type = typeof(InputActionReference), Member = "get_action", ReturnType = typeof(InputAction))]
	[CalledBy(Type = typeof(InputActionReference), Member = "Set", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputAction)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputActionReference), Member = "SetInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionAsset), typeof(InputAction)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputActionReference), Member = "ToString", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(InputActionReference), Member = "GetDisplayName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputAction)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(InputActionReference), Member = "ToDisplayName", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(InputActionReference), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputAction)}, ReturnType = typeof(InputActionReference))]
	[CalledBy(Type = typeof(InputActionSetupExtensions), Member = "RemoveAction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputAction)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputActionSetupExtensions), Member = "AddBinding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionMap), typeof(string), typeof(InputAction), typeof(string), typeof(string)}, ReturnType = typeof(BindingSyntax))]
	[CalledBy(Type = typeof(InputActionSetupExtensions), Member = "Rename", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputAction), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ActionEvent), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputAction)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PlayerInputManager), Member = "OnEnable", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputSystemUIInputModule), Member = "UpdateReferenceForNewAsset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionReference)}, ReturnType = typeof(InputActionReference))]
	[CalledBy(Type = typeof(InputSystemUIInputModule), Member = "set_actionsAsset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionAsset)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ActionEventPtr), Member = "ToString", ReturnType = typeof(string))]
	[CallerCount(Count = 33)]
	public InputActionMap get_actionMap() { }

	[CalledBy(Type = typeof(InputActionState), Member = "PrepareForBindingReResolution", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(InputControlList`1<InputControl>&), typeof(Boolean&)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.InputSystem.Plugins.InputForUI.InputSystemProvider", Member = "DirectionNavigation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DiscreteTime)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.InputSystem.Plugins.InputForUI.InputSystemProvider", Member = "GetActiveDeviceFromDirection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.InputForUI.NavigationEvent+Direction"}, ReturnType = typeof(InputDevice))]
	[CalledBy(Type = "UnityEngine.InputSystem.Plugins.InputForUI.InputSystemProvider", Member = "ReadNextPreviousDirection", ReturnType = "UnityEngine.InputForUI.NavigationEvent+Direction")]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(InputAction), Member = "GetOrCreateActionMap", ReturnType = typeof(InputActionMap))]
	[Calls(Type = typeof(TriggerState), Member = "get_controlIndex", ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public InputControl get_activeControl() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputAction), Member = "GetOrCreateActionMap", ReturnType = typeof(InputActionMap))]
	[Calls(Type = typeof(TriggerState), Member = "get_controlIndex", ReturnType = typeof(int))]
	[Calls(Type = typeof(InputActionState), Member = "GetValueType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(Type))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public Type get_activeValueType() { }

	[CallerCount(Count = 0)]
	public Nullable<InputBinding> get_bindingMask() { }

	[CalledBy(Type = typeof(RebindingOperation), Member = "OnComplete", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputActionSetupExtensions), Member = "RemoveAction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputAction)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(OnScreenStick), Member = "Start", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.DebugManager", Member = "SampleAction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.DebugManager", Member = "UpdateActions", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.DebugActionState", Member = "TriggerWithButton", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputAction), typeof(float)}, ReturnType = typeof(void))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(InputAction), Member = "GetOrCreateActionMap", ReturnType = typeof(InputActionMap))]
	[Calls(Type = typeof(InputActionMap), Member = "SetUpPerActionControlAndBindingArrays", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public ReadOnlyArray<InputBinding> get_bindings() { }

	[CalledBy(Type = typeof(InputSystemUIInputModule), Member = "GetPointerStateIndexFor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl), typeof(bool)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(InputSystemUIInputModule), Member = "HaveControlForDevice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice), typeof(InputActionReference)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(InputAction), Member = "GetOrCreateActionMap", ReturnType = typeof(InputActionMap))]
	[Calls(Type = typeof(InputActionMap), Member = "ResolveBindings", ReturnType = typeof(void))]
	[Calls(Type = typeof(InputActionMap), Member = "SetUpPerActionControlAndBindingArrays", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public ReadOnlyArray<InputControl> get_controls() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputActionState), Member = "FetchActionState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputAction)}, ReturnType = typeof(TriggerState&))]
	[CallsUnknownMethods(Count = 1)]
	private TriggerState get_currentState() { }

	[CalledBy(Type = typeof(InputActionAsset), Member = "FindAction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(InputAction))]
	[CalledBy(Type = typeof(InputActionState), Member = "RestoreActionStatesAfterReResolvingBindings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnmanagedMemory), typeof(UnityEngine.InputSystem.InputControlList`1<UnityEngine.InputSystem.InputControl>), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TrackedPoseDriver), Member = "UpdateCallback", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TrackedPoseDriver), Member = "ReadTrackingState", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputSystemUIInputModule), Member = "SwapAction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionReference&), typeof(InputActionReference), typeof(bool), typeof(System.Action`1<UnityEngine.InputSystem.InputAction+CallbackContext>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputSystemUIInputModule), Member = "EnableInputAction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionReference)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VirtualMouseInput), Member = "SetAction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionProperty&), typeof(InputActionProperty)}, ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(InputActionState), Member = "FetchActionState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputAction)}, ReturnType = typeof(TriggerState&))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public bool get_enabled() { }

	[CallerCount(Count = 12)]
	[DeduplicatedMethod]
	public string get_expectedControlType() { }

	[CalledBy(Type = typeof(InputActionReference), Member = "SetInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionAsset), typeof(InputAction)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputActionSetupExtensions), Member = "AddBinding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionMap), typeof(string), typeof(InputAction), typeof(string), typeof(string)}, ReturnType = typeof(BindingSyntax))]
	[CalledBy(Type = typeof(InputActionSetupExtensions), Member = "ChangeBinding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputAction), typeof(InputBinding)}, ReturnType = typeof(BindingSyntax))]
	[CalledBy(Type = typeof(ActionEvent), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputAction)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Guid), Member = "NewGuid", ReturnType = typeof(Guid))]
	[Calls(Type = typeof(Guid), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(Guid), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public Guid get_id() { }

	[CalledBy(Type = typeof(InputActionSetupExtensions), Member = "ChangeBinding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputAction), typeof(InputBinding)}, ReturnType = typeof(BindingSyntax))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Guid), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	internal Guid get_idDontGenerate() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputActionState), Member = "FetchActionState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputAction)}, ReturnType = typeof(TriggerState&))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public bool get_inProgress() { }

	[CallerCount(Count = 38)]
	[DeduplicatedMethod]
	public string get_interactions() { }

	[CalledBy(Type = typeof(BindingSyntax), Member = "Triggering", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputAction)}, ReturnType = typeof(BindingSyntax))]
	[CalledBy(Type = typeof(ActionEvent), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputAction)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[ContainsUnimplementedInstructions]
	internal bool get_isSingletonAction() { }

	[CallerCount(Count = 106)]
	[DeduplicatedMethod]
	public string get_name() { }

	[CalledBy(Type = typeof(InputActionState), Member = "PrepareForBindingReResolution", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(InputControlList`1<InputControl>&), typeof(Boolean&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InputActionState), Member = "FetchActionState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputAction)}, ReturnType = typeof(TriggerState&))]
	[CallsUnknownMethods(Count = 1)]
	public InputActionPhase get_phase() { }

	[CallerCount(Count = 62)]
	[DeduplicatedMethod]
	public string get_processors() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputAction), Member = "GetOrCreateActionMap", ReturnType = typeof(InputActionMap))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public bool get_triggered() { }

	[CallerCount(Count = 7)]
	[DeduplicatedMethod]
	public InputActionType get_type() { }

	[CalledBy(Type = typeof(InputBindingResolver), Member = "AddActionMap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionMap)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	public bool get_wantsInitialStateCheck() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputAction), Member = "GetOrCreateActionMap", ReturnType = typeof(InputActionMap))]
	[Calls(Type = typeof(TriggerState), Member = "get_haveMagnitude", ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public float GetControlMagnitude() { }

	[CallerCount(Count = 65)]
	[Calls(Type = typeof(InputActionMap), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 7)]
	internal InputActionMap GetOrCreateActionMap() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputAction), Member = "GetOrCreateActionMap", ReturnType = typeof(InputActionMap))]
	[Calls(Type = typeof(TriggerState), Member = "get_interactionIndex", ReturnType = typeof(int))]
	[Calls(Type = typeof(InteractionState), Member = "get_isTimerRunning", ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputState), Member = "get_currentTime", ReturnType = typeof(double))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public float GetTimeoutCompletionPercentage() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputAction), Member = "GetOrCreateActionMap", ReturnType = typeof(InputActionMap))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public bool IsInProgress() { }

	[CalledBy(Type = "UnityEngine.InputSystem.Plugins.InputForUI.InputSystemProvider", Member = "DirectionNavigation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DiscreteTime)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.InputSystem.Plugins.InputForUI.InputSystemProvider", Member = "ReadNextPreviousDirection", ReturnType = "UnityEngine.InputForUI.NavigationEvent+Direction")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(InputAction), Member = "GetOrCreateActionMap", ReturnType = typeof(InputActionMap))]
	[Calls(Type = typeof(TriggerState), Member = "get_isPressed", ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public bool IsPressed() { }

	[CalledBy(Type = typeof(PlayerInput), Member = "CacheMessageNames", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Guid), Member = "NewGuid", ReturnType = typeof(Guid))]
	[Calls(Type = typeof(Guid), Member = "ToString", ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 1)]
	internal string MakeSureIdIsInPlace() { }

	[CalledBy(Type = typeof(TrackedPoseDriver), Member = "UpdateCallback", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TrackedPoseDriver), Member = "ReadTrackingState", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(InputAction), Member = "GetOrCreateActionMap", ReturnType = typeof(InputActionMap))]
	[Calls(Type = typeof(TriggerState), Member = "get_controlIndex", ReturnType = typeof(int))]
	[Calls(Type = typeof(InputActionState), Member = "ReadValue", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(bool)}, ReturnType = "TValue")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	public TValue ReadValue() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputAction), Member = "GetOrCreateActionMap", ReturnType = typeof(InputActionMap))]
	[Calls(Type = typeof(TriggerState), Member = "get_controlIndex", ReturnType = typeof(int))]
	[Calls(Type = typeof(InputActionState), Member = "ReadValueAsObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(bool)}, ReturnType = typeof(object))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public object ReadValueAsObject() { }

	[CalledBy(Type = typeof(PlayerActions), Member = "SetCallbacks", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPlayerActions)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VirtualMouseInput), Member = "set_leftButtonAction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionProperty)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UIActions), Member = "SetCallbacks", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IUIActions)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PlayerInput), Member = "UninitializeActions", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TrackedPoseDriver), Member = "UnbindPosition", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TrackedPoseDriver), Member = "UnbindRotation", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TrackedPoseDriver), Member = "UnbindTrackingState", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputSystemUIInputModule), Member = "SwapAction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionReference&), typeof(InputActionReference), typeof(bool), typeof(System.Action`1<UnityEngine.InputSystem.InputAction+CallbackContext>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputSystemUIInputModule), Member = "SetActionCallbacks", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputSystemUIInputModule), Member = "SetActionCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionReference), typeof(System.Action`1<UnityEngine.InputSystem.InputAction+CallbackContext>), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VirtualMouseInput), Member = "set_middleButtonAction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionProperty)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VirtualMouseInput), Member = "set_forwardButtonAction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionProperty)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VirtualMouseInput), Member = "set_backButtonAction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionProperty)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VirtualMouseInput), Member = "OnDisable", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VirtualMouseInput), Member = "SetActionCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionProperty), typeof(System.Action`1<UnityEngine.InputSystem.InputAction+CallbackContext>), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputActionTrace), Member = "SubscribeToAll", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputActionTrace), Member = "UnsubscribeFromAll", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputActionTrace), Member = "UnsubscribeFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputAction)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VirtualMouseInput), Member = "set_rightButtonAction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionProperty)}, ReturnType = typeof(void))]
	[CallerCount(Count = 43)]
	[Calls(Type = typeof(CallbackArray`1), Member = "RemoveCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TDelegate"}, ReturnType = typeof(void))]
	public void remove_canceled(Action<CallbackContext> value) { }

	[CalledBy(Type = typeof(PlayerActions), Member = "SetCallbacks", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPlayerActions)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UIActions), Member = "SetCallbacks", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IUIActions)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PlayerInput), Member = "UninitializeActions", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PlayerInputManager), Member = "DisableJoining", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TrackedPoseDriver), Member = "UnbindPosition", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TrackedPoseDriver), Member = "UnbindRotation", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TrackedPoseDriver), Member = "UnbindTrackingState", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputSystemUIInputModule), Member = "SwapAction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionReference&), typeof(InputActionReference), typeof(bool), typeof(System.Action`1<UnityEngine.InputSystem.InputAction+CallbackContext>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputSystemUIInputModule), Member = "SetActionCallbacks", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputSystemUIInputModule), Member = "SetActionCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionReference), typeof(System.Action`1<UnityEngine.InputSystem.InputAction+CallbackContext>), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(OnScreenStick), Member = "OnDestroy", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(OnScreenStick), Member = "OnPointerChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CallbackContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(OnScreenStick), Member = "OnPointerUp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CallbackContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputActionTrace), Member = "SubscribeToAll", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputActionTrace), Member = "UnsubscribeFromAll", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputActionTrace), Member = "UnsubscribeFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputAction)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.InputSystem.Plugins.InputForUI.InputSystemProvider", Member = "UnregisterAction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputAction&), "System.Action`1<CallbackContext>"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.InputSystem.Plugins.InputForUI.InputSystemProvider", Member = "UnregisterActions", ReturnType = typeof(void))]
	[CallerCount(Count = 44)]
	[Calls(Type = typeof(CallbackArray`1), Member = "RemoveCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TDelegate"}, ReturnType = typeof(void))]
	public void remove_performed(Action<CallbackContext> value) { }

	[CalledBy(Type = typeof(PlayerActions), Member = "SetCallbacks", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPlayerActions)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UIActions), Member = "SetCallbacks", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IUIActions)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PlayerInput), Member = "UninitializeActions", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VirtualMouseInput), Member = "set_leftButtonAction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionProperty)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VirtualMouseInput), Member = "set_rightButtonAction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionProperty)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VirtualMouseInput), Member = "set_middleButtonAction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionProperty)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VirtualMouseInput), Member = "set_forwardButtonAction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionProperty)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VirtualMouseInput), Member = "set_backButtonAction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionProperty)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VirtualMouseInput), Member = "OnDisable", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VirtualMouseInput), Member = "SetActionCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionProperty), typeof(System.Action`1<UnityEngine.InputSystem.InputAction+CallbackContext>), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputActionTrace), Member = "SubscribeToAll", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputActionTrace), Member = "UnsubscribeFromAll", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputActionTrace), Member = "UnsubscribeFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputAction)}, ReturnType = typeof(void))]
	[CallerCount(Count = 28)]
	[Calls(Type = typeof(CallbackArray`1), Member = "RemoveCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TDelegate"}, ReturnType = typeof(void))]
	public void remove_started(Action<CallbackContext> value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputAction), Member = "GetOrCreateActionMap", ReturnType = typeof(InputActionMap))]
	[Calls(Type = typeof(InputActionState), Member = "SetInitialStateCheckPending", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	internal void RequestInitialStateCheckOnEnabledAction() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputAction), Member = "GetOrCreateActionMap", ReturnType = typeof(InputActionMap))]
	[Calls(Type = typeof(InputActionState), Member = "FetchActionState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputAction)}, ReturnType = typeof(TriggerState&))]
	[Calls(Type = typeof(InputActionState), Member = "ResetActionState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(InputActionPhase), typeof(bool)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public void Reset() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputBinding), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputBinding), typeof(InputBinding)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Nullable`1<UnityEngine.InputSystem.InputBinding>), Member = "get_Value", ReturnType = typeof(InputBinding))]
	[Calls(Type = typeof(System.Nullable`1<UnityEngine.InputSystem.InputBinding>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputBinding)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputAction), Member = "GetOrCreateActionMap", ReturnType = typeof(InputActionMap))]
	[Calls(Type = typeof(InputActionMap), Member = "LazyResolveBindings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	public void set_bindingMask(Nullable<InputBinding> value) { }

	[CallerCount(Count = 10)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public void set_expectedControlType(string value) { }

	[CallerCount(Count = 0)]
	public void set_wantsInitialStateCheck(bool value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputAction), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(InputActionType), typeof(string), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputAction), Member = "GetOrCreateActionMap", ReturnType = typeof(InputActionMap))]
	[Calls(Type = typeof(InputActionMap), Member = "SetUpPerActionControlAndBindingArrays", ReturnType = typeof(void))]
	[Calls(Type = typeof(ReadOnlyArray`1), Member = "ToArray", ReturnType = "TValue[]")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	[DeduplicatedMethod]
	private override object System.ICloneable.Clone() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(InputAction), Member = "GetOrCreateActionMap", ReturnType = typeof(InputActionMap))]
	[Calls(Type = typeof(InputActionMap), Member = "ResolveBindings", ReturnType = typeof(void))]
	[Calls(Type = typeof(InputActionMap), Member = "SetUpPerActionControlAndBindingArrays", ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ReadOnlyArray`1), Member = "GetEnumerator", ReturnType = "UnityEngine.InputSystem.Utilities.ReadOnlyArray`1<TValue>+Enumerator<TValue>")]
	[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Enumerator), Member = "get_Current", ReturnType = "TValue")]
	[Calls(Type = typeof(InputControl), Member = "get_path", ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	public virtual string ToString() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputAction), Member = "GetOrCreateActionMap", ReturnType = typeof(InputActionMap))]
	[Calls(Type = typeof(InputAction), Member = "ExpectedFrame", ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public bool WasCompletedThisDynamicUpdate() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputAction), Member = "GetOrCreateActionMap", ReturnType = typeof(InputActionMap))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public bool WasCompletedThisFrame() { }

	[CalledBy(Type = typeof(InputSystemUIInputModule), Member = "ProcessNavigation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NavigationModel&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(InputAction), Member = "GetOrCreateActionMap", ReturnType = typeof(InputActionMap))]
	[Calls(Type = typeof(InputAction), Member = "ExpectedFrame", ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public bool WasPerformedThisDynamicUpdate() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputAction), Member = "GetOrCreateActionMap", ReturnType = typeof(InputActionMap))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public bool WasPerformedThisFrame() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputAction), Member = "GetOrCreateActionMap", ReturnType = typeof(InputActionMap))]
	[Calls(Type = typeof(InputAction), Member = "ExpectedFrame", ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public bool WasPressedThisDynamicUpdate() { }

	[CalledBy(Type = "UnityEngine.InputSystem.Plugins.InputForUI.InputSystemProvider", Member = "DirectionNavigation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DiscreteTime)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.InputSystem.Plugins.InputForUI.InputSystemProvider", Member = "ReadCurrentNavigationMoveVector", ReturnType = "System.ValueTuple`2<Vector2, Boolean>")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(InputAction), Member = "GetOrCreateActionMap", ReturnType = typeof(InputActionMap))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public bool WasPressedThisFrame() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputAction), Member = "GetOrCreateActionMap", ReturnType = typeof(InputActionMap))]
	[Calls(Type = typeof(InputAction), Member = "ExpectedFrame", ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public bool WasReleasedThisDynamicUpdate() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputAction), Member = "GetOrCreateActionMap", ReturnType = typeof(InputActionMap))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public bool WasReleasedThisFrame() { }

}

