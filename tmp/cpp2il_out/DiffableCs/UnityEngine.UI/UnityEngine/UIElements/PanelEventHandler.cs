namespace UnityEngine.UIElements;

[AddComponentMenu("UI Toolkit/Panel Event Handler (UI Toolkit)")]
public class PanelEventHandler : UIBehaviour, IPointerMoveHandler, IEventSystemHandler, IPointerUpHandler, IPointerDownHandler, ISubmitHandler, ICancelHandler, IMoveHandler, IScrollHandler, ISelectHandler, IDeselectHandler, IPointerExitHandler, IPointerEnterHandler, IRuntimePanelComponent, IPointerClickHandler
{
	private class PointerEvent : IPointerEvent
	{
		[CompilerGenerated]
		private int <pointerId>k__BackingField; //Field offset: 0x10
		[CompilerGenerated]
		private string <pointerType>k__BackingField; //Field offset: 0x18
		[CompilerGenerated]
		private bool <isPrimary>k__BackingField; //Field offset: 0x20
		[CompilerGenerated]
		private int <button>k__BackingField; //Field offset: 0x24
		[CompilerGenerated]
		private int <pressedButtons>k__BackingField; //Field offset: 0x28
		[CompilerGenerated]
		private Vector3 <position>k__BackingField; //Field offset: 0x2C
		[CompilerGenerated]
		private Vector3 <localPosition>k__BackingField; //Field offset: 0x38
		[CompilerGenerated]
		private Vector3 <deltaPosition>k__BackingField; //Field offset: 0x44
		[CompilerGenerated]
		private float <deltaTime>k__BackingField; //Field offset: 0x50
		[CompilerGenerated]
		private int <clickCount>k__BackingField; //Field offset: 0x54
		[CompilerGenerated]
		private float <pressure>k__BackingField; //Field offset: 0x58
		[CompilerGenerated]
		private float <tangentialPressure>k__BackingField; //Field offset: 0x5C
		[CompilerGenerated]
		private float <altitudeAngle>k__BackingField; //Field offset: 0x60
		[CompilerGenerated]
		private float <azimuthAngle>k__BackingField; //Field offset: 0x64
		[CompilerGenerated]
		private float <twist>k__BackingField; //Field offset: 0x68
		[CompilerGenerated]
		private Vector2 <tilt>k__BackingField; //Field offset: 0x6C
		[CompilerGenerated]
		private PenStatus <penStatus>k__BackingField; //Field offset: 0x74
		[CompilerGenerated]
		private Vector2 <radius>k__BackingField; //Field offset: 0x78
		[CompilerGenerated]
		private Vector2 <radiusVariance>k__BackingField; //Field offset: 0x80
		[CompilerGenerated]
		private EventModifiers <modifiers>k__BackingField; //Field offset: 0x88

		public override bool actionKey
		{
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(Application), Member = "get_platform", ReturnType = typeof(RuntimePlatform))]
			[ContainsUnimplementedInstructions]
			 get { } //Length: 134
		}

		public private override float altitudeAngle
		{
			[CallerCount(Count = 0)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			 get { } //Length: 6
			[CallerCount(Count = 0)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			private set { } //Length: 6
		}

		public override bool altKey
		{
			[CallerCount(Count = 0)]
			[ContainsUnimplementedInstructions]
			 get { } //Length: 11
		}

		public private override float azimuthAngle
		{
			[CallerCount(Count = 0)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			 get { } //Length: 6
			[CallerCount(Count = 0)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			private set { } //Length: 6
		}

		public private override int button
		{
			[CallerCount(Count = 9)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			 get { } //Length: 4
			[CallerCount(Count = 0)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			private set { } //Length: 4
		}

		public private override int clickCount
		{
			[CallerCount(Count = 14)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			 get { } //Length: 4
			[CallerCount(Count = 0)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			private set { } //Length: 4
		}

		public override bool commandKey
		{
			[CallerCount(Count = 0)]
			[ContainsUnimplementedInstructions]
			 get { } //Length: 11
		}

		public override bool ctrlKey
		{
			[CallerCount(Count = 0)]
			[ContainsUnimplementedInstructions]
			 get { } //Length: 11
		}

		public private override Vector3 deltaPosition
		{
			[CallerCount(Count = 0)]
			[CompilerGenerated]
			 get { } //Length: 19
			[CallerCount(Count = 0)]
			[CompilerGenerated]
			private set { } //Length: 16
		}

		public private override float deltaTime
		{
			[CallerCount(Count = 0)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			 get { } //Length: 6
			[CallerCount(Count = 0)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			private set { } //Length: 6
		}

		public private override bool isPrimary
		{
			[CallerCount(Count = 0)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			 get { } //Length: 5
			[CallerCount(Count = 3)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			private set { } //Length: 4
		}

		public private override Vector3 localPosition
		{
			[CallerCount(Count = 0)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			 get { } //Length: 19
			[CallerCount(Count = 0)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			private set { } //Length: 16
		}

		public private override EventModifiers modifiers
		{
			[CallerCount(Count = 0)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			 get { } //Length: 7
			[CallerCount(Count = 0)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			private set { } //Length: 7
		}

		public private override PenStatus penStatus
		{
			[CallerCount(Count = 3)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			 get { } //Length: 4
			[CallerCount(Count = 1)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			private set { } //Length: 4
		}

		public private override int pointerId
		{
			[CallerCount(Count = 94)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			 get { } //Length: 4
			[CallerCount(Count = 7)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			private set { } //Length: 4
		}

		public private override string pointerType
		{
			[CallerCount(Count = 31)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			 get { } //Length: 5
			[CallerCount(Count = 9)]
			[CallsUnknownMethods(Count = 1)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			private set { } //Length: 13
		}

		public private override Vector3 position
		{
			[CallerCount(Count = 0)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			 get { } //Length: 19
			[CallerCount(Count = 0)]
			[CompilerGenerated]
			private set { } //Length: 16
		}

		public private override int pressedButtons
		{
			[CallerCount(Count = 1)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			 get { } //Length: 4
			[CallerCount(Count = 5)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			private set { } //Length: 4
		}

		public private override float pressure
		{
			[CallerCount(Count = 0)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			 get { } //Length: 6
			[CallerCount(Count = 0)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			private set { } //Length: 6
		}

		public private override Vector2 radius
		{
			[CallerCount(Count = 0)]
			[CompilerGenerated]
			 get { } //Length: 19
			[CallerCount(Count = 0)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			private set { } //Length: 5
		}

		public private override Vector2 radiusVariance
		{
			[CallerCount(Count = 0)]
			[CompilerGenerated]
			 get { } //Length: 25
			[CallerCount(Count = 0)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			private set { } //Length: 8
		}

		public override bool shiftKey
		{
			[CallerCount(Count = 0)]
			 get { } //Length: 10
		}

		public private override float tangentialPressure
		{
			[CallerCount(Count = 0)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			 get { } //Length: 6
			[CallerCount(Count = 0)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			private set { } //Length: 6
		}

		public private override Vector2 tilt
		{
			[CallerCount(Count = 0)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			 get { } //Length: 19
			[CallerCount(Count = 0)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			private set { } //Length: 5
		}

		public private override float twist
		{
			[CallerCount(Count = 0)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			 get { } //Length: 6
			[CallerCount(Count = 0)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			private set { } //Length: 6
		}

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public PointerEvent() { }

		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[ContainsUnimplementedInstructions]
		internal static bool <Read>g__InRange|90_0(int i, int start, int count) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Application), Member = "get_platform", ReturnType = typeof(RuntimePlatform))]
		[ContainsUnimplementedInstructions]
		public override bool get_actionKey() { }

		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		public override float get_altitudeAngle() { }

		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		public override bool get_altKey() { }

		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		public override float get_azimuthAngle() { }

		[CallerCount(Count = 9)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		public override int get_button() { }

		[CallerCount(Count = 14)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		public override int get_clickCount() { }

		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		public override bool get_commandKey() { }

		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		public override bool get_ctrlKey() { }

		[CallerCount(Count = 0)]
		[CompilerGenerated]
		public override Vector3 get_deltaPosition() { }

		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		public override float get_deltaTime() { }

		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		public override bool get_isPrimary() { }

		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		public override Vector3 get_localPosition() { }

		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		public override EventModifiers get_modifiers() { }

		[CallerCount(Count = 3)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		public override PenStatus get_penStatus() { }

		[CallerCount(Count = 94)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		public override int get_pointerId() { }

		[CallerCount(Count = 31)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		public override string get_pointerType() { }

		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		public override Vector3 get_position() { }

		[CallerCount(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		public override int get_pressedButtons() { }

		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		public override float get_pressure() { }

		[CallerCount(Count = 0)]
		[CompilerGenerated]
		public override Vector2 get_radius() { }

		[CallerCount(Count = 0)]
		[CompilerGenerated]
		public override Vector2 get_radiusVariance() { }

		[CallerCount(Count = 0)]
		public override bool get_shiftKey() { }

		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		public override float get_tangentialPressure() { }

		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		public override Vector2 get_tilt() { }

		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		public override float get_twist() { }

		[CalledBy(Type = typeof(PanelEventHandler), Member = "ReadPointerData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEvent), typeof(PointerEventData), "UnityEngine.UIElements.PanelEventHandler+PointerEventType"}, ReturnType = typeof(bool))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(PanelEventHandler), Member = "get_eventSystem", ReturnType = typeof(EventSystem))]
		[Calls(Type = typeof(Screen), Member = "get_height", ReturnType = typeof(int))]
		[Calls(Type = typeof(MultipleDisplayUtilities), Member = "GetRelativeMousePositionForRaycast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(Vector3))]
		[Calls(Type = typeof(Display), Member = "get_systemHeight", ReturnType = typeof(int))]
		[Calls(Type = "UnityEngine.UIElements.PointerDeviceState", Member = "ReleaseButton", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Time), Member = "get_unscaledTime", ReturnType = typeof(float))]
		[Calls(Type = "UnityEngine.UIElements.PointerDeviceState", Member = "PressButton", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = "UnityEngine.UIElements.PointerDeviceState", Member = "GetPressedButtons", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 3)]
		[ContainsUnimplementedInstructions]
		public void Read(PanelEventHandler self, PointerEventData eventData, PointerEventType eventType) { }

		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private void set_altitudeAngle(float value) { }

		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private void set_azimuthAngle(float value) { }

		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private void set_button(int value) { }

		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private void set_clickCount(int value) { }

		[CallerCount(Count = 0)]
		[CompilerGenerated]
		private void set_deltaPosition(Vector3 value) { }

		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private void set_deltaTime(float value) { }

		[CallerCount(Count = 3)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private void set_isPrimary(bool value) { }

		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private void set_localPosition(Vector3 value) { }

		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private void set_modifiers(EventModifiers value) { }

		[CallerCount(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private void set_penStatus(PenStatus value) { }

		[CallerCount(Count = 7)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private void set_pointerId(int value) { }

		[CallerCount(Count = 9)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private void set_pointerType(string value) { }

		[CallerCount(Count = 0)]
		[CompilerGenerated]
		private void set_position(Vector3 value) { }

		[CallerCount(Count = 5)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private void set_pressedButtons(int value) { }

		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private void set_pressure(float value) { }

		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private void set_radius(Vector2 value) { }

		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private void set_radiusVariance(Vector2 value) { }

		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private void set_tangentialPressure(float value) { }

		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private void set_tilt(Vector2 value) { }

		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private void set_twist(float value) { }

		[CallerCount(Count = 0)]
		public void SetPosition(Vector3 positionOverride, Vector3 deltaOverride) { }

	}

	private enum PointerEventType
	{
		Default = 0,
		Down = 1,
		Up = 2,
	}

	private static EventModifiers s_Modifiers; //Field offset: 0x0
	private BaseRuntimePanel m_Panel; //Field offset: 0x20
	private readonly PointerEvent m_PointerEvent; //Field offset: 0x28
	private float m_LastClickTime; //Field offset: 0x30
	private bool m_Selecting; //Field offset: 0x34
	private Event m_Event; //Field offset: 0x38

	private Focusable currentFocusedElement
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(FocusController), Member = "GetLeafFocusedElement", ReturnType = typeof(Focusable))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		private get { } //Length: 60
	}

	private EventSystem eventSystem
	{
		[CalledBy(Type = typeof(PointerEvent), Member = "Read", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PanelEventHandler), typeof(PointerEventData), typeof(PointerEventType)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(PanelEventHandler), Member = "get_isCurrentFocusedPanel", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(PanelEventHandler), Member = "OnElementFocus", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FocusEvent)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(PanelEventHandler), Member = "OnPointerDown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(PanelEventHandler), Member = "OnScroll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(PanelEventHandler), Member = "Update", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(PanelEventHandler), Member = "ProcessImguiEvents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Focusable)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(PanelEventHandler), Member = "ReadPointerData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEvent), typeof(PointerEventData), typeof(PointerEventType)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 13)]
		private get { } //Length: 204
	}

	private bool isCurrentFocusedPanel
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(PanelEventHandler), Member = "get_eventSystem", ReturnType = typeof(EventSystem))]
		[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 1)]
		private get { } //Length: 206
	}

	public override IPanel panel
	{
		[CallerCount(Count = 12)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(PanelEventHandler), Member = "UnregisterCallbacks", ReturnType = typeof(void))]
		[Calls(Type = typeof(PanelEventHandler), Member = "RegisterCallbacks", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 2)]
		 set { } //Length: 153
	}

	private GameObject selectableGameObject
	{
		[CallerCount(Count = 0)]
		private get { } //Length: 18
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Event), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public PanelEventHandler() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FocusController), Member = "GetLeafFocusedElement", ReturnType = typeof(Focusable))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private Focusable get_currentFocusedElement() { }

	[CalledBy(Type = typeof(PointerEvent), Member = "Read", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PanelEventHandler), typeof(PointerEventData), typeof(PointerEventType)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PanelEventHandler), Member = "get_isCurrentFocusedPanel", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(PanelEventHandler), Member = "OnElementFocus", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FocusEvent)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PanelEventHandler), Member = "OnPointerDown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PanelEventHandler), Member = "OnScroll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PanelEventHandler), Member = "Update", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PanelEventHandler), Member = "ProcessImguiEvents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Focusable)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PanelEventHandler), Member = "ReadPointerData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEvent), typeof(PointerEventData), typeof(PointerEventType)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 13)]
	private EventSystem get_eventSystem() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PanelEventHandler), Member = "get_eventSystem", ReturnType = typeof(EventSystem))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	private bool get_isCurrentFocusedPanel() { }

	[CallerCount(Count = 12)]
	[DeduplicatedMethod]
	public override IPanel get_panel() { }

	[CallerCount(Count = 0)]
	private GameObject get_selectableGameObject() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PanelEventHandler), Member = "ProcessImguiEvents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Focusable)}, ReturnType = typeof(void))]
	private void LateUpdate() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FocusController), Member = "GetLeafFocusedElement", ReturnType = typeof(Focusable))]
	[Calls(Type = typeof(PanelEventHandler), Member = "ProcessImguiEvents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Focusable)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NavigationEventBase`1), Member = "GetPooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventModifiers)}, ReturnType = "T")]
	[Calls(Type = typeof(EventBase), Member = "set_target", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IEventHandler)}, ReturnType = typeof(void))]
	[Calls(Type = "UnityEngine.UIElements.BaseVisualElementPanel", Member = "SendEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase), "UnityEngine.UIElements.DispatchMode"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(EventBase), Member = "get_isPropagationStopped", ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 8)]
	public override void OnCancel(BaseEventData eventData) { }

	[CallerCount(Count = 0)]
	[Calls(Type = "UnityEngine.UIElements.Panel", Member = "Blur", ReturnType = typeof(void))]
	public override void OnDeselect(BaseEventData eventData) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PanelEventHandler), Member = "UnregisterCallbacks", ReturnType = typeof(void))]
	protected virtual void OnDisable() { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	private void OnElementBlur(BlurEvent e) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PanelEventHandler), Member = "get_eventSystem", ReturnType = typeof(EventSystem))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(EventSystem), Member = "SetSelectedGameObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private void OnElementFocus(FocusEvent e) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PanelEventHandler), Member = "RegisterCallbacks", ReturnType = typeof(void))]
	protected virtual void OnEnable() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FocusController), Member = "GetLeafFocusedElement", ReturnType = typeof(Focusable))]
	[Calls(Type = typeof(PanelEventHandler), Member = "ProcessImguiEvents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Focusable)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NavigationMoveEvent), Member = "GetPooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(EventModifiers)}, ReturnType = typeof(NavigationMoveEvent))]
	[Calls(Type = typeof(EventBase), Member = "set_target", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IEventHandler)}, ReturnType = typeof(void))]
	[Calls(Type = "UnityEngine.UIElements.BaseVisualElementPanel", Member = "SendEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase), "UnityEngine.UIElements.DispatchMode"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(EventBase), Member = "get_isPropagationStopped", ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 7)]
	public override void OnMove(AxisEventData eventData) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PanelEventHandler), Member = "UnregisterCallbacks", ReturnType = typeof(void))]
	[Calls(Type = typeof(PanelEventHandler), Member = "RegisterCallbacks", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private void OnPanelDestroyed() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Time), Member = "get_unscaledTime", ReturnType = typeof(float))]
	public override void OnPointerClick(PointerEventData eventData) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PanelEventHandler), Member = "ReadPointerData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEvent), typeof(PointerEventData), typeof(PointerEventType)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(FocusController), Member = "GetLeafFocusedElement", ReturnType = typeof(Focusable))]
	[Calls(Type = typeof(PanelEventHandler), Member = "ProcessImguiEvents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Focusable)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(PanelEventHandler), Member = "get_eventSystem", ReturnType = typeof(EventSystem))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(EventSystem), Member = "SetSelectedGameObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(PointerEventBase`1), Member = "GetPooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPointerEvent)}, ReturnType = "T")]
	[Calls(Type = "UnityEngine.UIElements.BaseVisualElementPanel", Member = "SendEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase), "UnityEngine.UIElements.DispatchMode"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(EventBase), Member = "get_isPropagationStopped", ReturnType = typeof(bool))]
	[Calls(Type = "UnityEngine.UIElements.PointerDeviceState", Member = "SetPlayerPanelWithSoftPointerCapture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(IPanel)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 8)]
	public override void OnPointerDown(PointerEventData eventData) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PanelEventHandler), Member = "ReadPointerData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEvent), typeof(PointerEventData), typeof(PointerEventType)}, ReturnType = typeof(bool))]
	[Calls(Type = "UnityEngine.UIElements.BaseRuntimePanel", Member = "PointerEntersPanel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Vector2)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public override void OnPointerEnter(PointerEventData eventData) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PanelEventHandler), Member = "ReadPointerData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEvent), typeof(PointerEventData), typeof(PointerEventType)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(PointerEventBase`1), Member = "GetPooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPointerEvent)}, ReturnType = "T")]
	[Calls(Type = "UnityEngine.UIElements.BaseVisualElementPanel", Member = "SendEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase), "UnityEngine.UIElements.DispatchMode"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(EventBase), Member = "get_isPropagationStopped", ReturnType = typeof(bool))]
	[Calls(Type = "UnityEngine.UIElements.PointerDeviceState", Member = "SetPlayerPanelWithSoftPointerCapture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(IPanel)}, ReturnType = typeof(void))]
	[Calls(Type = "UnityEngine.UIElements.BaseRuntimePanel", Member = "PointerLeavesPanel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Vector2)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	public override void OnPointerExit(PointerEventData eventData) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PanelEventHandler), Member = "ReadPointerData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEvent), typeof(PointerEventData), typeof(PointerEventType)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(PointerEventBase`1), Member = "GetPooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPointerEvent)}, ReturnType = "T")]
	[Calls(Type = "UnityEngine.UIElements.BaseVisualElementPanel", Member = "SendEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase), "UnityEngine.UIElements.DispatchMode"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(EventBase), Member = "get_isPropagationStopped", ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	public override void OnPointerMove(PointerEventData eventData) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PanelEventHandler), Member = "ReadPointerData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEvent), typeof(PointerEventData), typeof(PointerEventType)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(PointerEventBase`1), Member = "GetPooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPointerEvent)}, ReturnType = "T")]
	[Calls(Type = "UnityEngine.UIElements.BaseVisualElementPanel", Member = "SendEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase), "UnityEngine.UIElements.DispatchMode"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(EventBase), Member = "get_isPropagationStopped", ReturnType = typeof(bool))]
	[Calls(Type = "UnityEngine.UIElements.PointerDeviceState", Member = "SetPlayerPanelWithSoftPointerCapture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(IPanel)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	public override void OnPointerUp(PointerEventData eventData) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PanelEventHandler), Member = "ReadPointerData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEvent), typeof(PointerEventData), typeof(PointerEventType)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(PanelEventHandler), Member = "get_eventSystem", ReturnType = typeof(EventSystem))]
	[Calls(Type = typeof(WheelEvent), Member = "GetPooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(IPointerEvent)}, ReturnType = typeof(WheelEvent))]
	[Calls(Type = "UnityEngine.UIElements.BaseVisualElementPanel", Member = "SendEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase), "UnityEngine.UIElements.DispatchMode"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(EventBase), Member = "get_isPropagationStopped", ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 6)]
	public override void OnScroll(PointerEventData eventData) { }

	[CallerCount(Count = 0)]
	[Calls(Type = "UnityEngine.UIElements.Panel", Member = "Focus", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public override void OnSelect(BaseEventData eventData) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FocusController), Member = "GetLeafFocusedElement", ReturnType = typeof(Focusable))]
	[Calls(Type = typeof(PanelEventHandler), Member = "ProcessImguiEvents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Focusable)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NavigationEventBase`1), Member = "GetPooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventModifiers)}, ReturnType = "T")]
	[Calls(Type = typeof(EventBase), Member = "set_target", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IEventHandler)}, ReturnType = typeof(void))]
	[Calls(Type = "UnityEngine.UIElements.BaseVisualElementPanel", Member = "SendEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase), "UnityEngine.UIElements.DispatchMode"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(EventBase), Member = "get_isPropagationStopped", ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 8)]
	public override void OnSubmit(BaseEventData eventData) { }

	[CalledBy(Type = typeof(PanelEventHandler), Member = "OnPointerDown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PanelEventHandler), Member = "OnSubmit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PanelEventHandler), Member = "OnCancel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PanelEventHandler), Member = "OnMove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AxisEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PanelEventHandler), Member = "Update", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PanelEventHandler), Member = "LateUpdate", ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(Event), Member = "PopEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Event), Member = "get_type", ReturnType = typeof(EventType))]
	[Calls(Type = typeof(Event), Member = "get_modifiers", ReturnType = typeof(EventModifiers))]
	[Calls(Type = typeof(PanelEventHandler), Member = "ProcessKeyboardEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event), typeof(Focusable)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(PanelEventHandler), Member = "get_eventSystem", ReturnType = typeof(EventSystem))]
	[Calls(Type = "UnityEngine.UIElements.KeyboardEventExtensions", Member = "ShouldSendNavigationMoveEventRuntime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Event), Member = "get_shift", ReturnType = typeof(bool))]
	[Calls(Type = typeof(PanelEventHandler), Member = "SendTabEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event), typeof(Direction), typeof(Focusable)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private void ProcessImguiEvents(Focusable target) { }

	[CalledBy(Type = typeof(PanelEventHandler), Member = "ProcessImguiEvents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Focusable)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Event), Member = "get_type", ReturnType = typeof(EventType))]
	[Calls(Type = typeof(PanelEventHandler), Member = "SendKeyDownEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event), typeof(Focusable)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(PanelEventHandler), Member = "SendKeyUpEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event), typeof(Focusable)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private void ProcessKeyboardEvent(Event e, Focusable target) { }

	[CallerCount(Count = 0)]
	[Calls(Type = "UnityEngine.UIElements.KeyboardEventExtensions", Member = "ShouldSendNavigationMoveEventRuntime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Event), Member = "get_shift", ReturnType = typeof(bool))]
	[Calls(Type = typeof(PanelEventHandler), Member = "SendTabEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event), typeof(Direction), typeof(Focusable)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private void ProcessTabEvent(Event e, Focusable target) { }

	[CalledBy(Type = typeof(PanelEventHandler), Member = "OnPointerMove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PanelEventHandler), Member = "OnPointerUp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PanelEventHandler), Member = "OnPointerDown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PanelEventHandler), Member = "OnPointerExit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PanelEventHandler), Member = "OnPointerEnter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PanelEventHandler), Member = "OnScroll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(PanelEventHandler), Member = "get_eventSystem", ReturnType = typeof(EventSystem))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(PointerEvent), Member = "Read", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PanelEventHandler), typeof(PointerEventData), typeof(PointerEventType)}, ReturnType = typeof(void))]
	[Calls(Type = "UnityEngine.UIElements.BaseRuntimePanel", Member = "ScreenToPanel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(Vector2), typeof(Vector2&), typeof(Vector2&), typeof(bool)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	private bool ReadPointerData(PointerEvent pe, PointerEventData eventData, PointerEventType eventType = 0) { }

	[CalledBy(Type = typeof(PanelEventHandler), Member = "set_panel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPanel)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PanelEventHandler), Member = "OnEnable", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PanelEventHandler), Member = "OnPanelDestroyed", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = "UnityEngine.UIElements.BaseRuntimePanel", Member = "add_destroyed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CallbackEventHandler), Member = "RegisterCallback", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TEventType"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.EventCallback`1<TEventType>", typeof(TrickleDown)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 1)]
	private void RegisterCallbacks() { }

	[CallerCount(Count = 0)]
	[Calls(Type = "UnityEngine.UIElements.BaseVisualElementPanel", Member = "SendEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase), "UnityEngine.UIElements.DispatchMode"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(EventBase), Member = "get_isPropagationStopped", ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void SendEvent(EventBase e, BaseEventData sourceEventData) { }

	[CallerCount(Count = 0)]
	[Calls(Type = "UnityEngine.UIElements.BaseVisualElementPanel", Member = "SendEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase), "UnityEngine.UIElements.DispatchMode"}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private void SendEvent(EventBase e, Event sourceEvent) { }

	[CalledBy(Type = typeof(PanelEventHandler), Member = "ProcessKeyboardEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event), typeof(Focusable)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = "UnityEngine.UIElements.UIElementsRuntimeUtility", Member = "CreateEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event)}, ReturnType = typeof(EventBase))]
	[Calls(Type = typeof(EventBase), Member = "set_target", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IEventHandler)}, ReturnType = typeof(void))]
	[Calls(Type = "UnityEngine.UIElements.BaseVisualElementPanel", Member = "SendEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase), "UnityEngine.UIElements.DispatchMode"}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 6)]
	private void SendKeyDownEvent(Event e, Focusable target) { }

	[CalledBy(Type = typeof(PanelEventHandler), Member = "ProcessKeyboardEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event), typeof(Focusable)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = "UnityEngine.UIElements.UIElementsRuntimeUtility", Member = "CreateEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event)}, ReturnType = typeof(EventBase))]
	[Calls(Type = typeof(EventBase), Member = "set_target", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IEventHandler)}, ReturnType = typeof(void))]
	[Calls(Type = "UnityEngine.UIElements.BaseVisualElementPanel", Member = "SendEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase), "UnityEngine.UIElements.DispatchMode"}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 6)]
	private void SendKeyUpEvent(Event e, Focusable target) { }

	[CalledBy(Type = typeof(PanelEventHandler), Member = "ProcessImguiEvents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Focusable)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PanelEventHandler), Member = "ProcessTabEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event), typeof(Focusable)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(NavigationMoveEvent), Member = "GetPooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Direction), typeof(EventModifiers)}, ReturnType = typeof(NavigationMoveEvent))]
	[Calls(Type = typeof(EventBase), Member = "set_target", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IEventHandler)}, ReturnType = typeof(void))]
	[Calls(Type = "UnityEngine.UIElements.BaseVisualElementPanel", Member = "SendEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase), "UnityEngine.UIElements.DispatchMode"}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	private void SendTabEvent(Event e, Direction direction, Focusable target) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PanelEventHandler), Member = "UnregisterCallbacks", ReturnType = typeof(void))]
	[Calls(Type = typeof(PanelEventHandler), Member = "RegisterCallbacks", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	public override void set_panel(IPanel value) { }

	[CalledBy(Type = typeof(PanelEventHandler), Member = "set_panel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPanel)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PanelEventHandler), Member = "OnDisable", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PanelEventHandler), Member = "OnPanelDestroyed", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = "UnityEngine.UIElements.BaseRuntimePanel", Member = "remove_destroyed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 1)]
	private void UnregisterCallbacks() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PanelEventHandler), Member = "get_eventSystem", ReturnType = typeof(EventSystem))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(FocusController), Member = "GetLeafFocusedElement", ReturnType = typeof(Focusable))]
	[Calls(Type = typeof(PanelEventHandler), Member = "ProcessImguiEvents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Focusable)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	internal void Update() { }

}

