namespace UnityEngine.UIElements;

public class NavigationMoveEvent : NavigationEventBase<NavigationMoveEvent>
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		private static <>c() { }

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(NavigationEventBase`1), Member = ".ctor", ReturnType = typeof(void))]
		internal NavigationMoveEvent <.cctor>b__0_0() { }

	}

	internal enum Direction
	{
		None = 0,
		Left = 1,
		Up = 2,
		Right = 3,
		Down = 4,
		Next = 5,
		Previous = 6,
	}

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private Direction <direction>k__BackingField; //Field offset: 0x70
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private Vector2 <move>k__BackingField; //Field offset: 0x74

	public private Direction direction
	{
		[CallerCount(Count = 3)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 4
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private set { } //Length: 4
	}

	private Vector2 move
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private set { } //Length: 5
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EventBase`1), Member = "SetCreateFunction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Func`1<T>"}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	private static NavigationMoveEvent() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NavigationEventBase`1), Member = ".ctor", ReturnType = typeof(void))]
	public NavigationMoveEvent() { }

	[CalledBy(Type = typeof(LegacyInputProcessor), Member = "ShouldSendMoveFromInput", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(KeyDownEvent), Member = "SendEquivalentNavigationEventIfAny", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPanel)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NavigationMoveEvent), Member = "GetPooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(EventModifiers)}, ReturnType = typeof(NavigationMoveEvent))]
	[CalledBy(Type = typeof(NavigationMoveEvent), Member = "GetPooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(NavigationDeviceType), typeof(EventModifiers)}, ReturnType = typeof(NavigationMoveEvent))]
	[CallerCount(Count = 4)]
	internal static Direction DetermineMoveDirection(float x, float y, float deadZone = 0.6) { }

	[CallerCount(Count = 3)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public Direction get_direction() { }

	[CalledBy(Type = "UnityEngine.UIElements.PanelEventHandler", Member = "OnMove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.EventSystems.AxisEventData"}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(NavigationEventBase`1), Member = "GetPooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NavigationDeviceType), typeof(EventModifiers)}, ReturnType = "T")]
	[Calls(Type = typeof(NavigationMoveEvent), Member = "DetermineMoveDirection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(float)}, ReturnType = typeof(Direction))]
	[CallsUnknownMethods(Count = 1)]
	public static NavigationMoveEvent GetPooled(Vector2 moveVector, EventModifiers modifiers = 0) { }

	[CalledBy(Type = "UnityEngine.UIElements.DefaultEventSystem+InputForUIProcessor+<>c", Member = "<ProcessNavigationEvent>b__10_2", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ValueTuple`3<UnityEngine.Vector2, UnityEngine.UIElements.NavigationDeviceType, UnityEngine.EventModifiers>)}, ReturnType = typeof(EventBase))]
	[CalledBy(Type = "UnityEngine.UIElements.DefaultEventSystem+LegacyInputProcessor+<>c", Member = "<SendInputEvents>b__28_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LegacyInputProcessor)}, ReturnType = typeof(EventBase))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(NavigationEventBase`1), Member = "GetPooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NavigationDeviceType), typeof(EventModifiers)}, ReturnType = "T")]
	[Calls(Type = typeof(NavigationMoveEvent), Member = "DetermineMoveDirection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(float)}, ReturnType = typeof(Direction))]
	[CallsUnknownMethods(Count = 1)]
	internal static NavigationMoveEvent GetPooled(Vector2 moveVector, NavigationDeviceType deviceType, EventModifiers modifiers = 0) { }

	[CalledBy(Type = "UnityEngine.UIElements.PanelEventHandler", Member = "SendTabEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event), typeof(Direction), typeof(Focusable)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(NavigationEventBase`1), Member = "GetPooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NavigationDeviceType), typeof(EventModifiers)}, ReturnType = "T")]
	[CallsUnknownMethods(Count = 1)]
	public static NavigationMoveEvent GetPooled(Direction direction, EventModifiers modifiers = 0) { }

	[CalledBy(Type = "UnityEngine.UIElements.DefaultEventSystem+InputForUIProcessor+<>c", Member = "<ProcessNavigationEvent>b__10_3", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ValueTuple`3<UnityEngine.UIElements.NavigationMoveEvent+Direction, UnityEngine.UIElements.NavigationDeviceType, UnityEngine.EventModifiers>)}, ReturnType = typeof(EventBase))]
	[CalledBy(Type = "UnityEngine.UIElements.DefaultEventSystem+LegacyInputProcessor+<>c", Member = "<ProcessTabEvent>b__37_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ValueTuple`3<UnityEngine.UIElements.NavigationMoveEvent+Direction, UnityEngine.EventModifiers, UnityEngine.UIElements.DefaultEventSystem+LegacyInputProcessor+IInput>)}, ReturnType = typeof(EventBase))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(NavigationEventBase`1), Member = "GetPooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NavigationDeviceType), typeof(EventModifiers)}, ReturnType = "T")]
	[CallsUnknownMethods(Count = 1)]
	internal static NavigationMoveEvent GetPooled(Direction direction, NavigationDeviceType deviceType, EventModifiers modifiers = 0) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NavigationEventBase`1), Member = "Init", ReturnType = typeof(void))]
	protected virtual void Init() { }

	[CallerCount(Count = 0)]
	private void LocalInit() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FocusController), Member = "GetLeafFocusedElement", ReturnType = typeof(Focusable))]
	[Calls(Type = typeof(FocusController), Member = "SwitchFocusOnEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Focusable), typeof(EventBase)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	protected private virtual void PostDispatch(IPanel panel) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void set_direction(Direction value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void set_move(Vector2 value) { }

}

