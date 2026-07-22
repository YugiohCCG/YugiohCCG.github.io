namespace UnityEngine.InputSystem.Plugins.InputForUI;

internal class InputSystemProvider : IEventProviderImpl
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Comparison<Event> <>9__33_0; //Field offset: 0x8

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		private static <>c() { }

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c() { }

		[CallerCount(Count = 0)]
		[Calls(Type = "UnityEngine.InputForUI.Event", Member = "CompareType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.InputForUI.Event", "UnityEngine.InputForUI.Event"}, ReturnType = typeof(int))]
		internal int <Update>b__33_0(Event a, Event b) { }

	}

	internal static class Actions
	{
		public static readonly string PointAction; //Field offset: 0x0
		public static readonly string MoveAction; //Field offset: 0x8
		public static readonly string SubmitAction; //Field offset: 0x10
		public static readonly string CancelAction; //Field offset: 0x18
		public static readonly string LeftClickAction; //Field offset: 0x20
		public static readonly string MiddleClickAction; //Field offset: 0x28
		public static readonly string RightClickAction; //Field offset: 0x30
		public static readonly string ScrollWheelAction; //Field offset: 0x38

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 8)]
		private static Actions() { }

	}

	private const uint k_DefaultPlayerId = 0; //Field offset: 0x0
	private const float kScrollUGUIScaleFactor = 3; //Field offset: 0x0
	private const float k_SmallestReportedMovementSqrDist = 0.01; //Field offset: 0x0
	private static Action<InputActionAsset> s_OnRegisterActions; //Field offset: 0x0
	private InputEventPartialProvider m_InputEventPartialProvider; //Field offset: 0x10
	private DefaultInputActions m_DefaultInputActions; //Field offset: 0x18
	private InputActionAsset m_InputActionAsset; //Field offset: 0x20
	private InputAction m_PointAction; //Field offset: 0x28
	private InputAction m_MoveAction; //Field offset: 0x30
	private InputAction m_SubmitAction; //Field offset: 0x38
	private InputAction m_CancelAction; //Field offset: 0x40
	private InputAction m_LeftClickAction; //Field offset: 0x48
	private InputAction m_MiddleClickAction; //Field offset: 0x50
	private InputAction m_RightClickAction; //Field offset: 0x58
	private InputAction m_ScrollWheelAction; //Field offset: 0x60
	private InputAction m_NextPreviousAction; //Field offset: 0x68
	private List<Event> m_Events; //Field offset: 0x70
	private PointerState m_MouseState; //Field offset: 0x78
	private PointerState m_PenState; //Field offset: 0xA0
	private bool m_SeenPenEvents; //Field offset: 0xC8
	private PointerState m_TouchState; //Field offset: 0xD0
	private bool m_SeenTouchEvents; //Field offset: 0xF8
	private NavigationEventRepeatHelper m_RepeatHelper; //Field offset: 0x100
	private bool m_ResetSeenEventsOnUpdate; //Field offset: 0x108

	private DiscreteTime m_CurrentTime
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Time), Member = "get_timeAsRational", ReturnType = typeof(RationalTime))]
		[Calls(Type = typeof(RationalTime), Member = "op_Explicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RationalTime)}, ReturnType = typeof(DiscreteTime))]
		private get { } //Length: 41
	}

	private EventModifiers m_EventModifiers
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		private get { } //Length: 26
	}

	public override uint playerCount
	{
		[CallerCount(Count = 9)]
		[DeduplicatedMethod]
		 get { } //Length: 6
	}

	[CallerCount(Count = 0)]
	[Calls(Type = "UnityEngine.InputForUI.NavigationEventRepeatHelper", Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = "UnityEngine.InputForUI.EventProvider", Member = "SetInputSystemProvider", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.InputForUI.IEventProviderImpl"}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	private static InputSystemProvider() { }

	[CallerCount(Count = 0)]
	[Calls(Type = "UnityEngine.InputForUI.NavigationEventRepeatHelper", Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public InputSystemProvider() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	public bool ActionAssetIsNotNull() { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType::SubsystemRegistration (4))]
	private static void Bootstrap() { }

	[CalledBy(Type = typeof(InputSystemProvider), Member = "Update", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InputAction), Member = "ReadValue", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(InputAction), Member = "WasPressedThisFrame", ReturnType = typeof(bool))]
	[Calls(Type = typeof(ValueTuple`2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T1", "T2"}, ReturnType = typeof(void))]
	[Calls(Type = "UnityEngine.InputForUI.NavigationEvent", Member = "DetermineMoveDirection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(float)}, ReturnType = "UnityEngine.InputForUI.NavigationEvent+Direction")]
	[Calls(Type = typeof(InputAction), Member = "IsPressed", ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputAction), Member = "get_activeControl", ReturnType = typeof(InputControl))]
	[Calls(Type = typeof(ButtonControl), Member = "get_isPressed", ReturnType = typeof(bool))]
	[Calls(Type = "UnityEngine.InputForUI.NavigationEventRepeatHelper", Member = "Reset", ReturnType = typeof(void))]
	[Calls(Type = "UnityEngine.InputForUI.NavigationEventRepeatHelper", Member = "ShouldSendMoveEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DiscreteTime), "UnityEngine.InputForUI.NavigationEvent+Direction", typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputSystemProvider), Member = "GetEventSource", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice)}, ReturnType = "UnityEngine.InputForUI.EventSource")]
	[Calls(Type = "UnityEngine.InputForUI.Event", Member = "From", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.InputForUI.NavigationEvent"}, ReturnType = "UnityEngine.InputForUI.Event")]
	[Calls(Type = "UnityEngine.InputForUI.EventProvider", Member = "Dispatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event&)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	private void DirectionNavigation(DiscreteTime currentTime) { }

	[CalledBy(Type = typeof(InputSystemProvider), Member = "OnPointerPerformed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CallbackContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputSystemProvider), Member = "OnSubmitPerformed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CallbackContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputSystemProvider), Member = "OnCancelPerformed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CallbackContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputSystemProvider), Member = "OnClickPerformed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CallbackContext), "UnityEngine.InputForUI.EventSource", "UnityEngine.InputForUI.PointerEvent+Button"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputSystemProvider), Member = "OnScrollWheelPerformed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CallbackContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(System.Collections.Generic.List`1<UnityEngine.InputForUI.Event>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.InputForUI.Event"}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	private void DispatchFromCallback(in Event ev) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputActionAsset), Member = "FindAction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(InputAction))]
	[Calls(Type = typeof(InputAction), Member = "add_performed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<UnityEngine.InputSystem.InputAction+CallbackContext>)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private InputAction FindActionAndRegisterCallback(string actionNameOrId, Action<CallbackContext> callback = null) { }

	[CalledBy(Type = typeof(InputSystemProvider), Member = "OnPointerPerformed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CallbackContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputSystemProvider), Member = "OnClickPerformed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CallbackContext), "UnityEngine.InputForUI.EventSource", "UnityEngine.InputForUI.PointerEvent+Button"}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CallbackContext), Member = "get_control", ReturnType = typeof(InputControl))]
	[Calls(Type = typeof(ReadOnlyArray`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "TValue")]
	[CallsUnknownMethods(Count = 4)]
	private static int FindTouchFingerIndex(Touchscreen touchscreen, CallbackContext ctx) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Time), Member = "get_timeAsRational", ReturnType = typeof(RationalTime))]
	[Calls(Type = typeof(RationalTime), Member = "op_Explicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RationalTime)}, ReturnType = typeof(DiscreteTime))]
	private DiscreteTime get_m_CurrentTime() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	private EventModifiers get_m_EventModifiers() { }

	[CallerCount(Count = 9)]
	[DeduplicatedMethod]
	public override uint get_playerCount() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputAction), Member = "get_activeControl", ReturnType = typeof(InputControl))]
	[CallsUnknownMethods(Count = 2)]
	private InputDevice GetActiveDeviceFromDirection(Direction direction) { }

	[CalledBy(Type = typeof(InputSystemProvider), Member = "DirectionNavigation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DiscreteTime)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputSystemProvider), Member = "GetEventSource", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CallbackContext)}, ReturnType = "UnityEngine.InputForUI.EventSource")]
	[CalledBy(Type = typeof(InputSystemProvider), Member = "OnPointerPerformed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CallbackContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputSystemProvider), Member = "OnSubmitPerformed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CallbackContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputSystemProvider), Member = "OnCancelPerformed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CallbackContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputSystemProvider), Member = "OnLeftClickPerformed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CallbackContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputSystemProvider), Member = "OnMiddleClickPerformed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CallbackContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputSystemProvider), Member = "OnRightClickPerformed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CallbackContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputSystemProvider), Member = "OnScrollWheelPerformed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CallbackContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 9)]
	private EventSource GetEventSource(InputDevice device) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CallbackContext), Member = "get_control", ReturnType = typeof(InputControl))]
	[Calls(Type = typeof(InputSystemProvider), Member = "GetEventSource", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice)}, ReturnType = "UnityEngine.InputForUI.EventSource")]
	[CallsUnknownMethods(Count = 1)]
	private EventSource GetEventSource(CallbackContext ctx) { }

	[CallerCount(Count = 0)]
	private PointerState GetPointerStateForSource(EventSource eventSource) { }

	[CallerCount(Count = 0)]
	[Calls(Type = "UnityEngine.InputForUI.InputEventPartialProvider", Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = "UnityEngine.InputForUI.InputEventPartialProvider", Member = "Initialize", ReturnType = typeof(void))]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = "UnityEngine.InputForUI.PointerState", Member = "Reset", ReturnType = typeof(void))]
	[Calls(Type = typeof(InputSystemProvider), Member = "SelectInputActionAsset", ReturnType = typeof(void))]
	[Calls(Type = typeof(InputSystemProvider), Member = "RegisterActions", ReturnType = typeof(void))]
	[Calls(Type = typeof(InputAction), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(InputActionType), typeof(string), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputActionSetupExtensions), Member = "AddBinding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputAction), typeof(string), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(BindingSyntax))]
	[Calls(Type = typeof(InputAction), Member = "Enable", ReturnType = typeof(void))]
	[Calls(Type = typeof(InputSystem), Member = "add_onActionsChange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public override void Initialize() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputSystemProvider), Member = "UnregisterActions", ReturnType = typeof(void))]
	[Calls(Type = typeof(InputSystemProvider), Member = "SelectInputActionAsset", ReturnType = typeof(void))]
	[Calls(Type = typeof(InputSystemProvider), Member = "RegisterActions", ReturnType = typeof(void))]
	public void OnActionsChange() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Time), Member = "get_timeAsRational", ReturnType = typeof(RationalTime))]
	[Calls(Type = typeof(RationalTime), Member = "op_Explicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RationalTime)}, ReturnType = typeof(DiscreteTime))]
	[Calls(Type = typeof(CallbackContext), Member = "get_control", ReturnType = typeof(InputControl))]
	[Calls(Type = typeof(InputSystemProvider), Member = "GetEventSource", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice)}, ReturnType = "UnityEngine.InputForUI.EventSource")]
	[Calls(Type = "UnityEngine.InputForUI.Event", Member = "From", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.InputForUI.NavigationEvent"}, ReturnType = "UnityEngine.InputForUI.Event")]
	[Calls(Type = typeof(InputSystemProvider), Member = "DispatchFromCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event&)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	private void OnCancelPerformed(CallbackContext ctx) { }

	[CalledBy(Type = typeof(InputSystemProvider), Member = "OnLeftClickPerformed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CallbackContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputSystemProvider), Member = "OnMiddleClickPerformed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CallbackContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputSystemProvider), Member = "OnRightClickPerformed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CallbackContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CallbackContext), Member = "get_control", ReturnType = typeof(InputControl))]
	[Calls(Type = typeof(InputSystemProvider), Member = "FindTouchFingerIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Touchscreen), typeof(CallbackContext)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CallbackContext), Member = "ReadValueAsButton", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Time), Member = "get_timeAsRational", ReturnType = typeof(RationalTime))]
	[Calls(Type = typeof(RationalTime), Member = "op_Explicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RationalTime)}, ReturnType = typeof(DiscreteTime))]
	[Calls(Type = "UnityEngine.InputForUI.PointerState", Member = "OnButtonChange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DiscreteTime), "UnityEngine.InputForUI.PointerEvent+Button", typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = "UnityEngine.InputForUI.Event", Member = "From", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.InputForUI.PointerEvent"}, ReturnType = "UnityEngine.InputForUI.Event")]
	[Calls(Type = typeof(InputSystemProvider), Member = "DispatchFromCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event&)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	private void OnClickPerformed(CallbackContext ctx, EventSource eventSource, Button button) { }

	[CallerCount(Count = 0)]
	[Calls(Type = "UnityEngine.InputForUI.InputEventPartialProvider", Member = "OnFocusChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public override void OnFocusChanged(bool focus) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CallbackContext), Member = "get_control", ReturnType = typeof(InputControl))]
	[Calls(Type = typeof(InputSystemProvider), Member = "GetEventSource", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice)}, ReturnType = "UnityEngine.InputForUI.EventSource")]
	[Calls(Type = typeof(InputSystemProvider), Member = "OnClickPerformed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CallbackContext), "UnityEngine.InputForUI.EventSource", "UnityEngine.InputForUI.PointerEvent+Button"}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private void OnLeftClickPerformed(CallbackContext ctx) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CallbackContext), Member = "get_control", ReturnType = typeof(InputControl))]
	[Calls(Type = typeof(InputSystemProvider), Member = "GetEventSource", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice)}, ReturnType = "UnityEngine.InputForUI.EventSource")]
	[Calls(Type = typeof(InputSystemProvider), Member = "OnClickPerformed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CallbackContext), "UnityEngine.InputForUI.EventSource", "UnityEngine.InputForUI.PointerEvent+Button"}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private void OnMiddleClickPerformed(CallbackContext ctx) { }

	[CallerCount(Count = 0)]
	[Calls(Type = "UnityEngine.InputForUI.Event", Member = "From", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.InputForUI.PointerEvent"}, ReturnType = "UnityEngine.InputForUI.Event")]
	[Calls(Type = "UnityEngine.InputForUI.PointerState", Member = "OnMove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DiscreteTime), typeof(Vector2), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RationalTime), Member = "op_Explicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RationalTime)}, ReturnType = typeof(DiscreteTime))]
	[Calls(Type = typeof(Time), Member = "get_timeAsRational", ReturnType = typeof(RationalTime))]
	[Calls(Type = typeof(ButtonControl), Member = "get_isPressed", ReturnType = typeof(bool))]
	[Calls(Type = typeof(UnityEngine.InputSystem.InputControl`1<System.Single>), Member = "ReadValue", ReturnType = typeof(float))]
	[Calls(Type = typeof(InputSystemProvider), Member = "DispatchFromCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UnityEngine.InputSystem.InputControl`1<UnityEngine.Vector2>), Member = "ReadValue", ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(Screen), Member = "get_height", ReturnType = typeof(int))]
	[Calls(Type = typeof(UnityEngine.InputSystem.InputControl`1<System.Int32>), Member = "ReadValue", ReturnType = typeof(int))]
	[Calls(Type = typeof(CallbackContext), Member = "ReadValue", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(InputSystemProvider), Member = "FindTouchFingerIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Touchscreen), typeof(CallbackContext)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(InputSystemProvider), Member = "GetEventSource", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice)}, ReturnType = "UnityEngine.InputForUI.EventSource")]
	[Calls(Type = typeof(CallbackContext), Member = "get_control", ReturnType = typeof(InputControl))]
	[Calls(Type = typeof(Display), Member = "get_systemHeight", ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 7)]
	private void OnPointerPerformed(CallbackContext ctx) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CallbackContext), Member = "get_control", ReturnType = typeof(InputControl))]
	[Calls(Type = typeof(InputSystemProvider), Member = "GetEventSource", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice)}, ReturnType = "UnityEngine.InputForUI.EventSource")]
	[Calls(Type = typeof(InputSystemProvider), Member = "OnClickPerformed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CallbackContext), "UnityEngine.InputForUI.EventSource", "UnityEngine.InputForUI.PointerEvent+Button"}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private void OnRightClickPerformed(CallbackContext ctx) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CallbackContext), Member = "ReadValue", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(InputSystem), Member = "get_scrollWheelDeltaPerTick", ReturnType = typeof(float))]
	[Calls(Type = typeof(CallbackContext), Member = "get_control", ReturnType = typeof(InputControl))]
	[Calls(Type = typeof(InputSystemProvider), Member = "GetEventSource", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice)}, ReturnType = "UnityEngine.InputForUI.EventSource")]
	[Calls(Type = typeof(UnityEngine.InputSystem.InputControl`1<UnityEngine.Vector2>), Member = "ReadValue", ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(UnityEngine.InputSystem.InputControl`1<System.Int32>), Member = "ReadValue", ReturnType = typeof(int))]
	[Calls(Type = typeof(Time), Member = "get_timeAsRational", ReturnType = typeof(RationalTime))]
	[Calls(Type = typeof(RationalTime), Member = "op_Explicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RationalTime)}, ReturnType = typeof(DiscreteTime))]
	[Calls(Type = "UnityEngine.InputForUI.Event", Member = "From", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.InputForUI.PointerEvent"}, ReturnType = "UnityEngine.InputForUI.Event")]
	[Calls(Type = typeof(InputSystemProvider), Member = "DispatchFromCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event&)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	private void OnScrollWheelPerformed(CallbackContext ctx) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Time), Member = "get_timeAsRational", ReturnType = typeof(RationalTime))]
	[Calls(Type = typeof(RationalTime), Member = "op_Explicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RationalTime)}, ReturnType = typeof(DiscreteTime))]
	[Calls(Type = typeof(CallbackContext), Member = "get_control", ReturnType = typeof(InputControl))]
	[Calls(Type = typeof(InputSystemProvider), Member = "GetEventSource", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice)}, ReturnType = "UnityEngine.InputForUI.EventSource")]
	[Calls(Type = "UnityEngine.InputForUI.Event", Member = "From", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.InputForUI.NavigationEvent"}, ReturnType = "UnityEngine.InputForUI.Event")]
	[Calls(Type = typeof(InputSystemProvider), Member = "DispatchFromCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event&)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	private void OnSubmitPerformed(CallbackContext ctx) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputAction), Member = "ReadValue", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(InputAction), Member = "WasPressedThisFrame", ReturnType = typeof(bool))]
	[Calls(Type = typeof(ValueTuple`2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T1", "T2"}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private ValueTuple<Vector2, Boolean> ReadCurrentNavigationMoveVector() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputAction), Member = "IsPressed", ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputAction), Member = "get_activeControl", ReturnType = typeof(InputControl))]
	[Calls(Type = typeof(ButtonControl), Member = "get_isPressed", ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private Direction ReadNextPreviousDirection() { }

	[CalledBy(Type = typeof(InputSystemProvider), Member = "Initialize", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputSystemProvider), Member = "OnActionsChange", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(InputActionAsset), Member = "FindAction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(InputAction))]
	[Calls(Type = typeof(InputAction), Member = "add_performed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<UnityEngine.InputSystem.InputAction+CallbackContext>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputSystem), Member = "get_actions", ReturnType = typeof(InputActionAsset))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputActionAsset), Member = "Enable", ReturnType = typeof(void))]
	[Calls(Type = typeof(InputActionAsset), Member = "FindActionMap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(InputActionMap))]
	[Calls(Type = typeof(InputActionMap), Member = "Enable", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 9)]
	private void RegisterActions() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputAction), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(InputActionType), typeof(string), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputActionSetupExtensions), Member = "AddBinding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputAction), typeof(string), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(BindingSyntax))]
	[Calls(Type = typeof(InputAction), Member = "Enable", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	private void RegisterFixedActions() { }

	[CallerCount(Count = 0)]
	[Calls(Type = "UnityEngine.InputForUI.InputEventPartialProvider", Member = "RequestCurrentState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.InputForUI.Event+Type"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Time), Member = "get_timeAsRational", ReturnType = typeof(RationalTime))]
	[Calls(Type = typeof(RationalTime), Member = "op_Explicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RationalTime)}, ReturnType = typeof(DiscreteTime))]
	[Calls(Type = typeof(InputSystemProvider), Member = "ToPointerStateEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DiscreteTime), typeof(PointerState&), "UnityEngine.InputForUI.EventSource"}, ReturnType = "UnityEngine.InputForUI.PointerEvent")]
	[Calls(Type = "UnityEngine.InputForUI.Event", Member = "From", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.InputForUI.PointerEvent"}, ReturnType = "UnityEngine.InputForUI.Event")]
	[Calls(Type = "UnityEngine.InputForUI.EventProvider", Member = "Dispatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event&)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public override bool RequestCurrentState(Type type) { }

	[CallerCount(Count = 0)]
	private void ResetSeenEvents() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Screen), Member = "get_height", ReturnType = typeof(int))]
	[Calls(Type = typeof(Display), Member = "get_systemHeight", ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 2)]
	internal static Vector2 ScreenBottomLeftToPanelPosition(Vector2 position, int targetDisplay) { }

	[CalledBy(Type = typeof(InputSystemProvider), Member = "Initialize", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputSystemProvider), Member = "OnActionsChange", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(InputSystem), Member = "get_actions", ReturnType = typeof(InputActionAsset))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputActionAsset), Member = "FindActionMap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(InputActionMap))]
	[Calls(Type = typeof(DefaultInputActions), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	private void SelectInputActionAsset() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	internal static void SetOnRegisterActions(Action<InputActionAsset> callback) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputSystemProvider), Member = "UnregisterActions", ReturnType = typeof(void))]
	[Calls(Type = typeof(InputAction), Member = "Disable", ReturnType = typeof(void))]
	[Calls(Type = typeof(DefaultInputActions), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(InputSystem), Member = "remove_onActionsChange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	public override void Shutdown() { }

	[CallerCount(Count = 0)]
	[Calls(Type = "UnityEngine.InputForUI.Event", Member = "CompareType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.InputForUI.Event", "UnityEngine.InputForUI.Event"}, ReturnType = typeof(int))]
	private static int SortEvents(Event a, Event b) { }

	[CalledBy(Type = typeof(InputSystemProvider), Member = "RequestCurrentState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.InputForUI.Event+Type"}, ReturnType = typeof(bool))]
	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	private PointerEvent ToPointerStateEvent(DiscreteTime currentTime, in PointerState state, EventSource eventSource) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputAction), Member = "remove_performed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<UnityEngine.InputSystem.InputAction+CallbackContext>)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private void UnregisterAction(ref InputAction action, Action<CallbackContext> callback = null) { }

	[CalledBy(Type = typeof(InputSystemProvider), Member = "Shutdown", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputSystemProvider), Member = "OnActionsChange", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(InputAction), Member = "remove_performed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<UnityEngine.InputSystem.InputAction+CallbackContext>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputActionAsset), Member = "Disable", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 9)]
	private void UnregisterActions() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputAction), Member = "Disable", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private void UnregisterFixedActions() { }

	[CallerCount(Count = 0)]
	[Calls(Type = "UnityEngine.InputForUI.InputEventPartialProvider", Member = "Update", ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Comparison`1<UnityEngine.InputForUI.Event>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<UnityEngine.InputForUI.Event>), Member = "Sort", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Comparison`1<UnityEngine.InputForUI.Event>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Time), Member = "get_timeAsRational", ReturnType = typeof(RationalTime))]
	[Calls(Type = typeof(RationalTime), Member = "op_Explicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RationalTime)}, ReturnType = typeof(DiscreteTime))]
	[Calls(Type = typeof(InputSystemProvider), Member = "DirectionNavigation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DiscreteTime)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<UnityEngine.InputForUI.Event>), Member = "GetEnumerator", ReturnType = typeof(System.Collections.Generic.List`1+Enumerator<UnityEngine.InputForUI.Event>))]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<UnityEngine.InputForUI.Event>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = "UnityEngine.InputForUI.Event", Member = "get_eventSource", ReturnType = "UnityEngine.InputForUI.EventSource")]
	[Calls(Type = "UnityEngine.InputForUI.PointerState", Member = "Reset", ReturnType = typeof(void))]
	[Calls(Type = "UnityEngine.InputForUI.EventProvider", Member = "Dispatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public override void Update() { }

}

