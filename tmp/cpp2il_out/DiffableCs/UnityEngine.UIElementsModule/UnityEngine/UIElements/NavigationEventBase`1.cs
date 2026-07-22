namespace UnityEngine.UIElements;

[EventCategory(EventCategory::Navigation (14))]
public abstract class NavigationEventBase : EventBase<T>, INavigationEvent
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private EventModifiers <modifiers>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private NavigationDeviceType <deviceType>k__BackingField; //Field offset: 0x0

	public override bool altKey
	{
		[CallerCount(Count = 7)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		 get { } //Length: 10
	}

	internal NavigationDeviceType deviceType
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		internal get { } //Length: 4
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private set { } //Length: 4
	}

	public override EventModifiers modifiers
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 4
		[CallerCount(Count = 10)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	public override bool shiftKey
	{
		[CallerCount(Count = 8)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		 get { } //Length: 10
	}

	[CalledBy(Type = "UnityEngine.UIElements.NavigationMoveEvent+<>c", Member = "<.cctor>b__0_0", ReturnType = typeof(NavigationMoveEvent))]
	[CalledBy(Type = typeof(NavigationMoveEvent), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.NavigationCancelEvent+<>c", Member = "<.cctor>b__0_0", ReturnType = typeof(NavigationCancelEvent))]
	[CalledBy(Type = typeof(NavigationCancelEvent), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.NavigationSubmitEvent+<>c", Member = "<.cctor>b__0_0", ReturnType = typeof(NavigationSubmitEvent))]
	[CalledBy(Type = typeof(NavigationSubmitEvent), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(EventBase`1), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	protected NavigationEventBase`1() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EventDispatchUtilities), Member = "DispatchToFocusedElementOrPanelRoot", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase), typeof(BaseVisualElementPanel)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	internal virtual void Dispatch(BaseVisualElementPanel panel) { }

	[CallerCount(Count = 7)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public override bool get_altKey() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	internal NavigationDeviceType get_deviceType() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public override EventModifiers get_modifiers() { }

	[CallerCount(Count = 8)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public override bool get_shiftKey() { }

	[CalledBy(Type = "UnityEngine.UIElements.PanelEventHandler", Member = "OnSubmit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.EventSystems.BaseEventData"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.PanelEventHandler", Member = "OnCancel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.EventSystems.BaseEventData"}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(EventBase`1), Member = "GetPooled", ReturnType = "T")]
	[CallsUnknownMethods(Count = 6)]
	[DeduplicatedMethod]
	public static T GetPooled(EventModifiers modifiers = 0) { }

	[CalledBy(Type = "UnityEngine.UIElements.DefaultEventSystem+InputForUIProcessor+<>c", Member = "<ProcessNavigationEvent>b__10_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ValueTuple`2<UnityEngine.UIElements.NavigationDeviceType, UnityEngine.EventModifiers>)}, ReturnType = typeof(EventBase))]
	[CalledBy(Type = "UnityEngine.UIElements.DefaultEventSystem+InputForUIProcessor+<>c", Member = "<ProcessNavigationEvent>b__10_1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ValueTuple`2<UnityEngine.UIElements.NavigationDeviceType, UnityEngine.EventModifiers>)}, ReturnType = typeof(EventBase))]
	[CalledBy(Type = "UnityEngine.UIElements.DefaultEventSystem+LegacyInputProcessor+<>c", Member = "<SendInputEvents>b__28_1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LegacyInputProcessor)}, ReturnType = typeof(EventBase))]
	[CalledBy(Type = "UnityEngine.UIElements.DefaultEventSystem+LegacyInputProcessor+<>c", Member = "<SendInputEvents>b__28_2", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LegacyInputProcessor)}, ReturnType = typeof(EventBase))]
	[CalledBy(Type = typeof(KeyDownEvent), Member = "SendEquivalentNavigationEventIfAny", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPanel)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NavigationMoveEvent), Member = "GetPooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(EventModifiers)}, ReturnType = typeof(NavigationMoveEvent))]
	[CalledBy(Type = typeof(NavigationMoveEvent), Member = "GetPooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(NavigationDeviceType), typeof(EventModifiers)}, ReturnType = typeof(NavigationMoveEvent))]
	[CalledBy(Type = typeof(NavigationMoveEvent), Member = "GetPooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Direction), typeof(EventModifiers)}, ReturnType = typeof(NavigationMoveEvent))]
	[CalledBy(Type = typeof(NavigationMoveEvent), Member = "GetPooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Direction), typeof(NavigationDeviceType), typeof(EventModifiers)}, ReturnType = typeof(NavigationMoveEvent))]
	[CallerCount(Count = 12)]
	[Calls(Type = typeof(EventBase`1), Member = "GetPooled", ReturnType = "T")]
	[CallsUnknownMethods(Count = 6)]
	[DeduplicatedMethod]
	internal static T GetPooled(NavigationDeviceType deviceType, EventModifiers modifiers = 0) { }

	[CalledBy(Type = typeof(NavigationMoveEvent), Member = "Init", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(EventBase`1), Member = "Init", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	protected virtual void Init() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	private void LocalInit() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void set_deviceType(NavigationDeviceType value) { }

	[CallerCount(Count = 10)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	protected void set_modifiers(EventModifiers value) { }

}

