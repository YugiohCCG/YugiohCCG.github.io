namespace UnityEngine.InputForUI;

[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
internal struct PointerEvent : IEventProperties
{
	[Flags]
	internal enum Button
	{
		None = 0,
		Primary = 1,
		FingerInTouch = 1,
		PenTipInTouch = 1,
		PenEraserInTouch = 2,
		PenBarrelButton = 4,
		MouseLeft = 1,
		MouseRight = 2,
		MouseMiddle = 4,
		MouseForward = 8,
		MouseBack = 16,
	}

	internal struct ButtonsState
	{
		private uint _state; //Field offset: 0x0

		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		public bool Get(Button button) { }

		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		public void Reset() { }

		[CallerCount(Count = 9)]
		[DeduplicatedMethod]
		public void Set(Button button, bool pressed) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
		public virtual string ToString() { }

	}

	internal enum Type
	{
		PointerMoved = 1,
		Scroll = 2,
		ButtonPressed = 3,
		ButtonReleased = 4,
		State = 5,
		TouchCanceled = 6,
	}

	public Type type; //Field offset: 0x0
	public int pointerIndex; //Field offset: 0x4
	public Vector2 position; //Field offset: 0x8
	public Vector2 deltaPosition; //Field offset: 0x10
	public Vector2 scroll; //Field offset: 0x18
	public int displayIndex; //Field offset: 0x20
	public Vector2 tilt; //Field offset: 0x24
	public float twist; //Field offset: 0x2C
	public float pressure; //Field offset: 0x30
	public bool isInverted; //Field offset: 0x34
	public Button button; //Field offset: 0x38
	public ButtonsState buttonsState; //Field offset: 0x3C
	public int clickCount; //Field offset: 0x40
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private DiscreteTime <timestamp>k__BackingField; //Field offset: 0x48
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private EventSource <eventSource>k__BackingField; //Field offset: 0x50
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private uint <playerId>k__BackingField; //Field offset: 0x54
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private EventModifiers <eventModifiers>k__BackingField; //Field offset: 0x58

	public float altitude
	{
		[CalledBy(Type = "UnityEngine.UIElements.PointerEventBase`1", Member = "GetPooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEvent), typeof(Vector2), typeof(Vector2), typeof(int), typeof(float)}, ReturnType = "T")]
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 3)]
		 get { } //Length: 75
	}

	public float azimuth
	{
		[CalledBy(Type = "UnityEngine.UIElements.PointerEventBase`1", Member = "GetPooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEvent), typeof(Vector2), typeof(Vector2), typeof(int), typeof(float)}, ReturnType = "T")]
		[CalledBy(Type = typeof(PointerEvent), Member = "ToString", ReturnType = typeof(string))]
		[CallerCount(Count = 2)]
		[CallsUnknownMethods(Count = 5)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 242
	}

	public override EventModifiers eventModifiers
	{
		[CallerCount(Count = 3)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[IsReadOnly]
		 get { } //Length: 4
		[CallerCount(Count = 5)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	public override EventSource eventSource
	{
		[CallerCount(Count = 7)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[IsReadOnly]
		 get { } //Length: 4
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	public bool isPrimaryPointer
	{
		[CallerCount(Count = 6)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		 get { } //Length: 8
	}

	public uint playerId
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	public override DiscreteTime timestamp
	{
		[CallerCount(Count = 10)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[IsReadOnly]
		 get { } //Length: 254
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 5
	}

	[CallerCount(Count = 0)]
	internal static Button ButtonFromButtonIndex(int index) { }

	[CalledBy(Type = "UnityEngine.UIElements.PointerEventBase`1", Member = "GetPooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEvent), typeof(Vector2), typeof(Vector2), typeof(int), typeof(float)}, ReturnType = "T")]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public float get_altitude() { }

	[CalledBy(Type = "UnityEngine.UIElements.PointerEventBase`1", Member = "GetPooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEvent), typeof(Vector2), typeof(Vector2), typeof(int), typeof(float)}, ReturnType = "T")]
	[CalledBy(Type = typeof(PointerEvent), Member = "ToString", ReturnType = typeof(string))]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	[ContainsUnimplementedInstructions]
	public float get_azimuth() { }

	[CallerCount(Count = 3)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[IsReadOnly]
	public override EventModifiers get_eventModifiers() { }

	[CallerCount(Count = 7)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[IsReadOnly]
	public override EventSource get_eventSource() { }

	[CallerCount(Count = 6)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public bool get_isPrimaryPointer() { }

	[CallerCount(Count = 10)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[IsReadOnly]
	public override DiscreteTime get_timestamp() { }

	[CallerCount(Count = 5)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_eventModifiers(EventModifiers value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_eventSource(EventSource value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_playerId(uint value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_timestamp(DiscreteTime value) { }

	[CalledBy(Type = "UnityEngine.UIElements.DefaultEventSystem+InputForUIProcessor", Member = "ProcessPointerEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEvent)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PointerEvent), Member = "get_azimuth", ReturnType = typeof(float))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 143)]
	[ContainsUnimplementedInstructions]
	public virtual string ToString() { }

}

