namespace UnityEngine.InputForUI;

internal class InputManagerProvider : IEventProviderImpl
{
	private struct ButtonEventsIterator : IEnumerator
	{
		private uint _mask; //Field offset: 0x0
		private int _bit; //Field offset: 0x4

		public bool Current
		{
			[CallerCount(Count = 0)]
			 get { } //Length: 9
		}

		private override object System.Collections.IEnumerator.Current
		{
			[CallerCount(Count = 0)]
			private get { } //Length: 38
		}

		[CallerCount(Count = 0)]
		public static ButtonEventsIterator FromState(bool previous, bool down, bool up, bool current) { }

		[CallerCount(Count = 0)]
		public bool get_Current() { }

		[CallerCount(Count = 0)]
		public override bool MoveNext() { }

		[CallerCount(Count = 0)]
		public override void Reset() { }

		[CallerCount(Count = 0)]
		private override object System.Collections.IEnumerator.get_Current() { }

	}

	internal struct Configuration
	{
		public string HorizontalAxis; //Field offset: 0x0
		public string VerticalAxis; //Field offset: 0x8
		public string SubmitButton; //Field offset: 0x10
		public string CancelButton; //Field offset: 0x18
		public string NavigateNextButton; //Field offset: 0x20
		public string NavigatePreviousButton; //Field offset: 0x28
		public float InputActionsPerSecond; //Field offset: 0x30
		public float RepeatDelay; //Field offset: 0x34

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 6)]
		public static Configuration GetDefaultConfiguration() { }

	}

	public interface IInput
	{

		public string compositionString
		{
			 get { } //Length: 0
		}

		public Vector3 mousePosition
		{
			 get { } //Length: 0
		}

		public bool mousePresent
		{
			 get { } //Length: 0
		}

		public Vector2 mouseScrollDelta
		{
			 get { } //Length: 0
		}

		public int touchCount
		{
			 get { } //Length: 0
		}

		public bool touchSupported
		{
			 get { } //Length: 0
		}

		public string get_compositionString() { }

		public Vector3 get_mousePosition() { }

		public bool get_mousePresent() { }

		public Vector2 get_mouseScrollDelta() { }

		public int get_touchCount() { }

		public bool get_touchSupported() { }

		public float GetAxisRaw(string axis) { }

		public bool GetButtonDown(string button) { }

		public bool GetKey(KeyCode keyCode) { }

		public PenData GetLastPenContactEvent() { }

		public bool GetMouseButton(int button) { }

		public bool GetMouseButtonDown(int button) { }

		public bool GetMouseButtonUp(int button) { }

		public Touch GetTouch(int index) { }

	}

	private class Input : IInput
	{

		public override string compositionString
		{
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(Input), Member = "get_compositionString", ReturnType = typeof(string))]
			[DeduplicatedMethod]
			 get { } //Length: 7
		}

		public override Vector3 mousePosition
		{
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(Input), Member = "get_mousePosition", ReturnType = typeof(Vector3))]
			[DeduplicatedMethod]
			 get { } //Length: 44
		}

		public override bool mousePresent
		{
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(Input), Member = "get_mousePresent", ReturnType = typeof(bool))]
			[DeduplicatedMethod]
			 get { } //Length: 7
		}

		public override Vector2 mouseScrollDelta
		{
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(Input), Member = "get_mouseScrollDelta", ReturnType = typeof(Vector2))]
			[DeduplicatedMethod]
			 get { } //Length: 7
		}

		public override int touchCount
		{
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(Input), Member = "get_touchCount", ReturnType = typeof(int))]
			[DeduplicatedMethod]
			 get { } //Length: 7
		}

		public override bool touchSupported
		{
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(Input), Member = "get_touchSupported", ReturnType = typeof(bool))]
			[DeduplicatedMethod]
			 get { } //Length: 7
		}

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public Input() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Input), Member = "get_compositionString", ReturnType = typeof(string))]
		[DeduplicatedMethod]
		public override string get_compositionString() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Input), Member = "get_mousePosition", ReturnType = typeof(Vector3))]
		[DeduplicatedMethod]
		public override Vector3 get_mousePosition() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Input), Member = "get_mousePresent", ReturnType = typeof(bool))]
		[DeduplicatedMethod]
		public override bool get_mousePresent() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Input), Member = "get_mouseScrollDelta", ReturnType = typeof(Vector2))]
		[DeduplicatedMethod]
		public override Vector2 get_mouseScrollDelta() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Input), Member = "get_touchCount", ReturnType = typeof(int))]
		[DeduplicatedMethod]
		public override int get_touchCount() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Input), Member = "get_touchSupported", ReturnType = typeof(bool))]
		[DeduplicatedMethod]
		public override bool get_touchSupported() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Input), Member = "GetAxisRaw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(float))]
		[DeduplicatedMethod]
		public override float GetAxisRaw(string axis) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Input), Member = "GetButtonDown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
		[DeduplicatedMethod]
		public override bool GetButtonDown(string button) { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		public override bool GetKey(KeyCode key) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Input), Member = "GetLastPenContactEvent", ReturnType = typeof(PenData))]
		[DeduplicatedMethod]
		public override PenData GetLastPenContactEvent() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Input), Member = "GetMouseButton", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
		[DeduplicatedMethod]
		public override bool GetMouseButton(int button) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Input), Member = "GetMouseButtonDown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
		[DeduplicatedMethod]
		public override bool GetMouseButtonDown(int button) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Input), Member = "GetMouseButtonUp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
		[DeduplicatedMethod]
		public override bool GetMouseButtonUp(int button) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Input), Member = "GetTouch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Touch))]
		[DeduplicatedMethod]
		public override Touch GetTouch(int index) { }

	}

	public interface ITime
	{

		public RationalTime timeAsRational
		{
			 get { } //Length: 0
		}

		public RationalTime get_timeAsRational() { }

	}

	private class Time : ITime
	{

		public override RationalTime timeAsRational
		{
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(Time), Member = "get_timeAsRational", ReturnType = typeof(RationalTime))]
			 get { } //Length: 36
		}

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public Time() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Time), Member = "get_timeAsRational", ReturnType = typeof(RationalTime))]
		public override RationalTime get_timeAsRational() { }

	}

	private InputEventPartialProvider _inputEventPartialProvider; //Field offset: 0x10
	private string _compositionString; //Field offset: 0x18
	private Configuration _configuration; //Field offset: 0x20
	private IInput _input; //Field offset: 0x58
	private ITime _time; //Field offset: 0x60
	private NavigationEventRepeatHelper _navigationEventRepeatHelper; //Field offset: 0x68
	private PointerState _mouseState; //Field offset: 0x70
	private bool _isPenPresent; //Field offset: 0x98
	private bool _seenAtLeastOnePenPosition; //Field offset: 0x99
	private Vector2 _lastSeenPenPositionForDetection; //Field offset: 0x9C
	private PointerState _penState; //Field offset: 0xA8
	private PenData _lastPenData; //Field offset: 0xD0
	private Dictionary<Int32, Int32> _touchFingerIdToFingerIndex; //Field offset: 0xF8
	private int _touchNextFingerIndex; //Field offset: 0x100
	private PointerState _touchState; //Field offset: 0x108

	private EventModifiers _eventModifiers
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		private get { } //Length: 26
	}

	[CalledBy(Type = typeof(EventProvider), Member = ".cctor", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 14)]
	public InputManagerProvider() { }

	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 8)]
	[DeduplicatedMethod]
	internal static Vector2 AzimuthAndAlitutudeToTilt(float altitude, float azimuth) { }

	[CalledBy(Type = typeof(InputManagerProvider), Member = "Update", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(EventProvider), Member = "Dispatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event&)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	private void CheckIfIMEChanged(DiscreteTime currentTime) { }

	[CalledBy(Type = typeof(InputManagerProvider), Member = "Update", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(InputManagerProvider), Member = "MultiDisplayBottomLeftToPanelPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(Int32&)}, ReturnType = typeof(Vector2))]
	[Calls(Type = "UnityEngine.Rendering.MousePositionDebug", Member = "GetMouseClickPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(EventProvider), Member = "Dispatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(PointerState), Member = "OnMove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DiscreteTime), typeof(Vector2), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(PointerState), Member = "OnButtonChange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DiscreteTime), typeof(Button), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	[ContainsUnimplementedInstructions]
	private void CheckMouseEvents(DiscreteTime currentTime, bool muted = false) { }

	[CalledBy(Type = typeof(InputManagerProvider), Member = "Update", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InputManagerProvider), Member = "MultiDisplayBottomLeftToPanelPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(Int32&)}, ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(EventProvider), Member = "Dispatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event&)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private void CheckMouseScroll(DiscreteTime currentTime) { }

	[CalledBy(Type = typeof(InputManagerProvider), Member = "Update", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PointerState), Member = "OnButtonDown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DiscreteTime), typeof(Button)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(PointerState), Member = "OnButtonUp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DiscreteTime), typeof(Button)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(EventProvider), Member = "Dispatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(PointerState), Member = "OnMove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DiscreteTime), typeof(Vector2), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private bool CheckPenEvent(DiscreteTime currentTime, in PenData currentPenData) { }

	[CalledBy(Type = typeof(InputManagerProvider), Member = "Update", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Touch), Member = "get_phase", ReturnType = typeof(TouchPhase))]
	[Calls(Type = typeof(Dictionary`2), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue&"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32, System.Int32>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputManagerProvider), Member = "MultiDisplayBottomLeftToPanelPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(Int32&)}, ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(PointerState), Member = "OnButtonUp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DiscreteTime), typeof(Button)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(PointerState), Member = "OnButtonDown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DiscreteTime), typeof(Button)}, ReturnType = typeof(void))]
	[Calls(Type = "UnityEngine.Rendering.MousePositionDebug", Member = "GetMouseClickPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(EventProvider), Member = "Dispatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Dictionary`2), Member = "Clear", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 13)]
	[CallsUnknownMethods(Count = 3)]
	private bool CheckTouchEvents(DiscreteTime currentTime) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	private void DetectPen() { }

	[CalledBy(Type = typeof(InputManagerProvider), Member = "Update", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InputManagerProvider), Member = "InputManagerGetAxisRawOrDefault", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(InputManagerProvider), Member = "InputManagerGetButtonDownOrDefault", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ValueTuple`2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T1", "T2"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputManagerProvider), Member = "GetEventSourceFromPressedKey", ReturnType = typeof(EventSource))]
	[Calls(Type = typeof(EventProvider), Member = "Dispatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event&)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private void DirectionNavigation(DiscreteTime currentTime) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	private EventModifiers get__eventModifiers() { }

	[CalledBy(Type = typeof(InputManagerProvider), Member = "Update", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputManagerProvider), Member = "NextPreviousNavigation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DiscreteTime)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputManagerProvider), Member = "SubmitCancelNavigation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DiscreteTime)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputManagerProvider), Member = "DirectionNavigation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DiscreteTime)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[CallsUnknownMethods(Count = 3)]
	private EventSource GetEventSourceFromPressedKey() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputEventPartialProvider), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(PointerState), Member = "Reset", ReturnType = typeof(void))]
	[Calls(Type = typeof(Dictionary`2), Member = "Clear", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public override void Initialize() { }

	[CalledBy(Type = typeof(InputManagerProvider), Member = "DirectionNavigation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DiscreteTime)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputManagerProvider), Member = "ReadCurrentNavigationMoveVector", ReturnType = typeof(System.ValueTuple`2<UnityEngine.Vector2, System.Boolean>))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private float InputManagerGetAxisRawOrDefault(string axisName) { }

	[CalledBy(Type = typeof(InputManagerProvider), Member = "Update", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputManagerProvider), Member = "NextPreviousNavigation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DiscreteTime)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputManagerProvider), Member = "SubmitCancelNavigation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DiscreteTime)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputManagerProvider), Member = "DirectionNavigation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DiscreteTime)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputManagerProvider), Member = "ReadCurrentNavigationMoveVector", ReturnType = typeof(System.ValueTuple`2<UnityEngine.Vector2, System.Boolean>))]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	private bool InputManagerGetButtonDownOrDefault(string axisName) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private bool InputManagerJoystickWasPressed() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private bool InputManagerKeyboardWasPressed() { }

	[CalledBy(Type = typeof(InputManagerProvider), Member = "CheckTouchEvents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DiscreteTime)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(InputManagerProvider), Member = "CheckMouseEvents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DiscreteTime), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputManagerProvider), Member = "CheckMouseScroll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DiscreteTime)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Display), Member = "RelativeMouseAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Screen), Member = "get_height", ReturnType = typeof(int))]
	[Calls(Type = typeof(Display), Member = "get_systemHeight", ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	private static Vector2 MultiDisplayBottomLeftToPanelPosition(Vector2 position, out int targetDisplay) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Display), Member = "RelativeMouseAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private static Vector2 MultiDisplayToLocalScreenPosition(Vector2 position, out Nullable<Int32>& targetDisplay) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputManagerProvider), Member = "InputManagerGetButtonDownOrDefault", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputManagerProvider), Member = "GetEventSourceFromPressedKey", ReturnType = typeof(EventSource))]
	[Calls(Type = typeof(EventProvider), Member = "Dispatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event&)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private void NextPreviousNavigation(DiscreteTime currentTime) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public override void OnFocusChanged(bool focus) { }

	[CallerCount(Count = 0)]
	private static Button PenStatusToButton(PenStatus status) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputManagerProvider), Member = "InputManagerGetAxisRawOrDefault", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(InputManagerProvider), Member = "InputManagerGetButtonDownOrDefault", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ValueTuple`2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T1", "T2"}, ReturnType = typeof(void))]
	private ValueTuple<Vector2, Boolean> ReadCurrentNavigationMoveVector() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	private static Vector2 ScreenBottomLeftToPanelDelta(Vector2 delta) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Screen), Member = "get_height", ReturnType = typeof(int))]
	[Calls(Type = typeof(Display), Member = "get_systemHeight", ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 2)]
	private static Vector2 ScreenBottomLeftToPanelPosition(Vector2 position, int targetDisplay) { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	public override void Shutdown() { }

	[CalledBy(Type = typeof(InputManagerProvider), Member = "Update", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InputManagerProvider), Member = "InputManagerGetButtonDownOrDefault", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputManagerProvider), Member = "GetEventSourceFromPressedKey", ReturnType = typeof(EventSource))]
	[Calls(Type = typeof(EventProvider), Member = "Dispatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event&)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private void SubmitCancelNavigation(DiscreteTime currentTime) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	internal static float TiltToAltitude(Vector2 tilt) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 5)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	internal static float TiltToAzimuth(Vector2 tilt) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private IMECompositionEvent ToIMECompositionEvent(DiscreteTime currentTime, string compositionString) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputManagerProvider), Member = "CheckIfIMEChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DiscreteTime)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputEventPartialProvider), Member = "Update", ReturnType = typeof(void))]
	[Calls(Type = typeof(RationalTime), Member = "op_Explicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RationalTime)}, ReturnType = typeof(DiscreteTime))]
	[Calls(Type = typeof(InputManagerProvider), Member = "CheckTouchEvents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DiscreteTime)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(PointerState), Member = "Reset", ReturnType = typeof(void))]
	[Calls(Type = typeof(InputManagerProvider), Member = "CheckMouseEvents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DiscreteTime), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputManagerProvider), Member = "CheckMouseScroll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DiscreteTime)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputManagerProvider), Member = "DirectionNavigation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DiscreteTime)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputManagerProvider), Member = "SubmitCancelNavigation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DiscreteTime)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputManagerProvider), Member = "InputManagerGetButtonDownOrDefault", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputManagerProvider), Member = "GetEventSourceFromPressedKey", ReturnType = typeof(EventSource))]
	[Calls(Type = typeof(EventProvider), Member = "Dispatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputManagerProvider), Member = "CheckPenEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DiscreteTime), typeof(PenData&)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 8)]
	[ContainsUnimplementedInstructions]
	public override void Update() { }

}

