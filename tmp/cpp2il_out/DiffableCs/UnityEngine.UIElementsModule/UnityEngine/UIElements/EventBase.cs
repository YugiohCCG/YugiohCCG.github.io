namespace UnityEngine.UIElements;

public abstract class EventBase : IDisposable
{
	[Flags]
	public enum EventPropagation
	{
		None = 0,
		Bubbles = 1,
		TricklesDown = 2,
		SkipDisabledElements = 4,
		BubblesOrTricklesDown = 3,
	}

	[Flags]
	private enum LifeCycleStatus
	{
		None = 0,
		PropagationStopped = 1,
		ImmediatePropagationStopped = 2,
		Dispatching = 4,
		Pooled = 8,
		IMGUIEventIsValid = 16,
		PropagateToIMGUI = 32,
		Dispatched = 64,
		Processed = 128,
		ProcessedByFocusController = 256,
	}

	private static long s_LastTypeId; //Field offset: 0x0
	private static ulong s_NextEventId; //Field offset: 0x8
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private readonly int <eventCategories>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private long <timestamp>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private ulong <eventId>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private ulong <triggerEventId>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private EventPropagation <propagation>k__BackingField; //Field offset: 0x30
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private LifeCycleStatus <lifeCycleStatus>k__BackingField; //Field offset: 0x34
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private VisualElement <elementTarget>k__BackingField; //Field offset: 0x38
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private PropagationPhase <propagationPhase>k__BackingField; //Field offset: 0x40
	private IEventHandler m_CurrentTarget; //Field offset: 0x48
	private Event m_ImguiEvent; //Field offset: 0x50
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private Vector2 <originalMousePosition>k__BackingField; //Field offset: 0x58

	public bool bubbles
	{
		[CalledBy(Type = typeof(PropagationPaths), Member = "Build", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(EventBase), typeof(int)}, ReturnType = typeof(PropagationPaths))]
		[CallerCount(Count = 1)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 10
		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		 set { } //Length: 25
	}

	internal bool bubblesOrTricklesDown
	{
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		internal get { } //Length: 8
	}

	public internal override IEventHandler currentTarget
	{
		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		 get { } //Length: 7
		[CalledBy(Type = typeof(MouseEventBase`1), Member = "set_currentTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IEventHandler)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(PointerEventBase`1), Member = "set_currentTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IEventHandler)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Event), Member = "set_mousePosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(VisualElementExtensions), Member = "WorldToLocal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(Vector2)}, ReturnType = typeof(Vector2))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		internal set { } //Length: 309
	}

	public internal bool dispatch
	{
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 10
		[CallerCount(Count = 0)]
		internal set { } //Length: 21
	}

	private bool dispatched
	{
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		private get { } //Length: 10
		[CallerCount(Count = 0)]
		private set { } //Length: 25
	}

	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal VisualElement elementTarget
	{
		[CallerCount(Count = 38)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		internal get { } //Length: 5
		[CallerCount(Count = 3)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		internal set { } //Length: 13
	}

	internal int eventCategories
	{
		[CallerCount(Count = 94)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		internal get { } //Length: 4
	}

	internal ulong eventId
	{
		[CallerCount(Count = 12)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		internal get { } //Length: 5
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private set { } //Length: 5
	}

	public override long eventTypeId
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 8
	}

	public Event imguiEvent
	{
		[CalledBy(Type = typeof(CommandEventBase`1), Member = "get_commandName", ReturnType = typeof(string))]
		[CalledBy(Type = typeof(MouseEventBase`1), Member = "GetPooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPointerEvent)}, ReturnType = "T")]
		[CalledBy(Type = typeof(IMGUIContainer), Member = "SendEventToIMGUI", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase), typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(IMGUIContainer), Member = "SendEventToIMGUIRaw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase), typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(IMGUIContainer), Member = "HandleEventBubbleUp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase)}, ReturnType = typeof(void))]
		[CallerCount(Count = 15)]
		 get { } //Length: 16
		[CalledBy(Type = typeof(CommandEventBase`1), Member = "GetPooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event)}, ReturnType = "T")]
		[CalledBy(Type = typeof(KeyboardEventBase`1), Member = "GetPooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event)}, ReturnType = "T")]
		[CalledBy(Type = typeof(MouseEventBase`1), Member = "GetPooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event)}, ReturnType = "T")]
		[CalledBy(Type = typeof(MouseEventBase`1), Member = "GetPooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPointerEvent)}, ReturnType = "T")]
		[CalledBy(Type = typeof(PointerEventBase`1), Member = "GetPooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event)}, ReturnType = "T")]
		[CalledBy(Type = typeof(IMGUIEvent), Member = "GetPooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event)}, ReturnType = typeof(IMGUIEvent))]
		[CallerCount(Count = 7)]
		[Calls(Type = typeof(Event), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(Event), Member = "CopyFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Event), Member = "get_mousePosition", ReturnType = typeof(Vector2))]
		[CallsUnknownMethods(Count = 2)]
		 set { } //Length: 191
	}

	private bool imguiEventIsValid
	{
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		private get { } //Length: 10
		[CallerCount(Count = 0)]
		private set { } //Length: 25
	}

	public private bool isImmediatePropagationStopped
	{
		[CalledBy(Type = typeof(MouseEventBase`1), Member = "PostDispatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPanel)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 10
		[CallerCount(Count = 0)]
		private set { } //Length: 25
	}

	public private bool isPropagationStopped
	{
		[CalledBy(Type = typeof(DefaultEventSystem), Member = "SendFocusBasedEvent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TArg"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Func`2<TArg, EventBase>", "TArg"}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(MouseEventBase`1), Member = "PostDispatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPanel)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UIElementsUtility), Member = "DoDispatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseVisualElementPanel)}, ReturnType = typeof(bool))]
		[CalledBy(Type = "UnityEngine.UIElements.PanelEventHandler", Member = "OnPointerMove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.EventSystems.PointerEventData"}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UIElements.PanelEventHandler", Member = "OnPointerUp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.EventSystems.PointerEventData"}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UIElements.PanelEventHandler", Member = "OnPointerDown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.EventSystems.PointerEventData"}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UIElements.PanelEventHandler", Member = "OnPointerExit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.EventSystems.PointerEventData"}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UIElements.PanelEventHandler", Member = "OnSubmit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.EventSystems.BaseEventData"}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UIElements.PanelEventHandler", Member = "OnCancel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.EventSystems.BaseEventData"}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UIElements.PanelEventHandler", Member = "OnMove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.EventSystems.AxisEventData"}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UIElements.PanelEventHandler", Member = "OnScroll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.EventSystems.PointerEventData"}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UIElements.PanelEventHandler", Member = "SendEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase), "UnityEngine.EventSystems.BaseEventData"}, ReturnType = typeof(void))]
		[CallerCount(Count = 12)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 10
		[CallerCount(Count = 0)]
		private set { } //Length: 25
	}

	private LifeCycleStatus lifeCycleStatus
	{
		[CallerCount(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private get { } //Length: 4
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private set { } //Length: 4
	}

	public private Vector2 originalMousePosition
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		 get { } //Length: 19
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private set { } //Length: 5
	}

	protected bool pooled
	{
		[CalledBy(Type = typeof(EventBase`1), Member = "ReleasePooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(EventBase`1), Member = "Dispose", ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 10
		[CalledBy(Type = typeof(EventBase`1), Member = "GetPooled", ReturnType = "T")]
		[CalledBy(Type = typeof(EventBase`1), Member = "GetPooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase)}, ReturnType = "T")]
		[CalledBy(Type = typeof(EventBase`1), Member = "ReleasePooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(EventBase`1), Member = "Dispose", ReturnType = typeof(void))]
		[CallerCount(Count = 4)]
		 set { } //Length: 25
	}

	internal bool processed
	{
		[CalledBy(Type = typeof(MouseEventBase`1), Member = "PostDispatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPanel)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[ContainsUnimplementedInstructions]
		internal get { } //Length: 13
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		private set { } //Length: 27
	}

	internal bool processedByFocusController
	{
		[CalledBy(Type = typeof(DefaultEventSystem), Member = "SendPositionBasedEvent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TArg"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3), typeof(int), typeof(System.Nullable`1<System.Int32>), "System.Func`4<Vector3, Vector3, TArg, EventBase>", "TArg", typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(MouseEventBase`1), Member = "PostDispatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPanel)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(FocusController), Member = "SwitchFocusOnEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Focusable), typeof(EventBase)}, ReturnType = typeof(void))]
		[CallerCount(Count = 4)]
		[ContainsUnimplementedInstructions]
		internal get { } //Length: 13
		[CalledBy(Type = typeof(MouseEventBase`1), Member = "PostDispatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPanel)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(FocusController), Member = "IgnoreEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(FocusController), Member = "SwitchFocusOnEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Focusable), typeof(EventBase)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(IMGUIContainer), Member = "HandleEventBubbleUp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase)}, ReturnType = typeof(void))]
		[CallerCount(Count = 6)]
		[ContainsUnimplementedInstructions]
		internal set { } //Length: 27
	}

	internal bool propagateToIMGUI
	{
		[CalledBy(Type = typeof(EditorPanelRootElement), Member = "OnEventCompletedAtAnyTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[ContainsUnimplementedInstructions]
		internal get { } //Length: 10
		[CalledBy(Type = typeof(EditorPanelRootElement), Member = "OnEventCompletedAtAnyTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		internal set { } //Length: 25
	}

	internal EventPropagation propagation
	{
		[CallerCount(Count = 3)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		internal get { } //Length: 4
		[CallerCount(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		internal set { } //Length: 4
	}

	internal PropagationPhase propagationPhase
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		internal set { } //Length: 4
	}

	internal bool skipDisabledElements
	{
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		internal get { } //Length: 10
		[CallerCount(Count = 0)]
		internal set { } //Length: 25
	}

	public IEventHandler target
	{
		[CallerCount(Count = 38)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CalledBy(Type = typeof(FocusController), Member = "ReleaseFocus", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Focusable), typeof(Focusable), typeof(FocusChangeDirection), typeof(DispatchMode)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(FocusController), Member = "GrabFocus", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Focusable), typeof(Focusable), typeof(FocusChangeDirection), typeof(bool), typeof(DispatchMode)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UIElements.PanelEventHandler", Member = "OnSubmit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.EventSystems.BaseEventData"}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UIElements.PanelEventHandler", Member = "OnCancel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.EventSystems.BaseEventData"}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UIElements.PanelEventHandler", Member = "OnMove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.EventSystems.AxisEventData"}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UIElements.PanelEventHandler", Member = "SendTabEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event), typeof(Direction), typeof(Focusable)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UIElements.PanelEventHandler", Member = "SendKeyUpEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event), typeof(Focusable)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UIElements.PanelEventHandler", Member = "SendKeyDownEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event), typeof(Focusable)}, ReturnType = typeof(void))]
		[CallerCount(Count = 8)]
		[CallsUnknownMethods(Count = 1)]
		 set { } //Length: 131
	}

	public private long timestamp
	{
		[CallerCount(Count = 31)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private set { } //Length: 5
	}

	public bool tricklesDown
	{
		[CalledBy(Type = typeof(PropagationPaths), Member = "Build", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(EventBase), typeof(int)}, ReturnType = typeof(PropagationPaths))]
		[CallerCount(Count = 1)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 10
		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		 set { } //Length: 25
	}

	private ulong triggerEventId
	{
		[CallerCount(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private set { } //Length: 5
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EventBase), Member = "LocalInit", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	protected EventBase() { }

	[CalledBy(Type = typeof(EventBase`1), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(EventBase), Member = "LocalInit", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	internal EventBase(EventCategory category) { }

	internal abstract void Acquire() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EventDispatchUtilities), Member = "HandleEventAtTargetAndDefaultPhase", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase), typeof(BaseVisualElementPanel), typeof(VisualElement)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	internal override void Dispatch(BaseVisualElementPanel panel) { }

	public abstract void Dispose() { }

	[CalledBy(Type = typeof(PropagationPaths), Member = "Build", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(EventBase), typeof(int)}, ReturnType = typeof(PropagationPaths))]
	[CallerCount(Count = 1)]
	[ContainsUnimplementedInstructions]
	public bool get_bubbles() { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	internal bool get_bubblesOrTricklesDown() { }

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public override IEventHandler get_currentTarget() { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public bool get_dispatch() { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	private bool get_dispatched() { }

	[CallerCount(Count = 38)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	internal VisualElement get_elementTarget() { }

	[CallerCount(Count = 94)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	internal int get_eventCategories() { }

	[CallerCount(Count = 12)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	internal ulong get_eventId() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public override long get_eventTypeId() { }

	[CalledBy(Type = typeof(CommandEventBase`1), Member = "get_commandName", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(MouseEventBase`1), Member = "GetPooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPointerEvent)}, ReturnType = "T")]
	[CalledBy(Type = typeof(IMGUIContainer), Member = "SendEventToIMGUI", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase), typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(IMGUIContainer), Member = "SendEventToIMGUIRaw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase), typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(IMGUIContainer), Member = "HandleEventBubbleUp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase)}, ReturnType = typeof(void))]
	[CallerCount(Count = 15)]
	public Event get_imguiEvent() { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	private bool get_imguiEventIsValid() { }

	[CalledBy(Type = typeof(MouseEventBase`1), Member = "PostDispatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPanel)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[ContainsUnimplementedInstructions]
	public bool get_isImmediatePropagationStopped() { }

	[CalledBy(Type = typeof(DefaultEventSystem), Member = "SendFocusBasedEvent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TArg"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Func`2<TArg, EventBase>", "TArg"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MouseEventBase`1), Member = "PostDispatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPanel)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UIElementsUtility), Member = "DoDispatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseVisualElementPanel)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.UIElements.PanelEventHandler", Member = "OnPointerMove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.EventSystems.PointerEventData"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.PanelEventHandler", Member = "OnPointerUp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.EventSystems.PointerEventData"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.PanelEventHandler", Member = "OnPointerDown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.EventSystems.PointerEventData"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.PanelEventHandler", Member = "OnPointerExit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.EventSystems.PointerEventData"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.PanelEventHandler", Member = "OnSubmit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.EventSystems.BaseEventData"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.PanelEventHandler", Member = "OnCancel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.EventSystems.BaseEventData"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.PanelEventHandler", Member = "OnMove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.EventSystems.AxisEventData"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.PanelEventHandler", Member = "OnScroll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.EventSystems.PointerEventData"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.PanelEventHandler", Member = "SendEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase), "UnityEngine.EventSystems.BaseEventData"}, ReturnType = typeof(void))]
	[CallerCount(Count = 12)]
	[ContainsUnimplementedInstructions]
	public bool get_isPropagationStopped() { }

	[CallerCount(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private LifeCycleStatus get_lifeCycleStatus() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	public Vector2 get_originalMousePosition() { }

	[CalledBy(Type = typeof(EventBase`1), Member = "ReleasePooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(EventBase`1), Member = "Dispose", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[ContainsUnimplementedInstructions]
	protected bool get_pooled() { }

	[CalledBy(Type = typeof(MouseEventBase`1), Member = "PostDispatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPanel)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[ContainsUnimplementedInstructions]
	internal bool get_processed() { }

	[CalledBy(Type = typeof(DefaultEventSystem), Member = "SendPositionBasedEvent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TArg"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3), typeof(int), typeof(System.Nullable`1<System.Int32>), "System.Func`4<Vector3, Vector3, TArg, EventBase>", "TArg", typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MouseEventBase`1), Member = "PostDispatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPanel)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FocusController), Member = "SwitchFocusOnEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Focusable), typeof(EventBase)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[ContainsUnimplementedInstructions]
	internal bool get_processedByFocusController() { }

	[CalledBy(Type = typeof(EditorPanelRootElement), Member = "OnEventCompletedAtAnyTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[ContainsUnimplementedInstructions]
	internal bool get_propagateToIMGUI() { }

	[CallerCount(Count = 3)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	internal EventPropagation get_propagation() { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	internal bool get_skipDisabledElements() { }

	[CallerCount(Count = 38)]
	[DeduplicatedMethod]
	public IEventHandler get_target() { }

	[CallerCount(Count = 31)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public long get_timestamp() { }

	[CalledBy(Type = typeof(PropagationPaths), Member = "Build", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(EventBase), typeof(int)}, ReturnType = typeof(PropagationPaths))]
	[CallerCount(Count = 1)]
	[ContainsUnimplementedInstructions]
	public bool get_tricklesDown() { }

	[CalledBy(Type = typeof(EventBase`1), Member = "Init", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(EventBase), Member = "LocalInit", ReturnType = typeof(void))]
	protected override void Init() { }

	[CalledBy(Type = typeof(EventBase), Member = "Init", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(EventBase), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(EventBase), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventCategory)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Panel), Member = "TimeSinceStartupMs", ReturnType = typeof(long))]
	[CallsUnknownMethods(Count = 2)]
	private void LocalInit() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Debug), Member = "Assert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(string)}, ReturnType = typeof(void))]
	[ContainsUnimplementedInstructions]
	internal void MarkReceivedByDispatcher() { }

	[CalledBy(Type = typeof(MouseEventBase`1), Member = "PostDispatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPanel)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PointerEventBase`1), Member = "PostDispatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPanel)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	protected private override void PostDispatch(IPanel panel) { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	[Obsolete("Override PostDispatch(IPanel panel) instead.")]
	protected override void PostDispatch() { }

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	protected private override void PreDispatch(IPanel panel) { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	[Obsolete("Override PreDispatch(IPanel panel) instead.")]
	protected override void PreDispatch() { }

	[CalledBy(Type = typeof(EventBase`1), Member = ".cctor", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	protected static long RegisterEventType() { }

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	protected void set_bubbles(bool value) { }

	[CalledBy(Type = typeof(MouseEventBase`1), Member = "set_currentTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IEventHandler)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PointerEventBase`1), Member = "set_currentTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IEventHandler)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Event), Member = "set_mousePosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElementExtensions), Member = "WorldToLocal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(Vector2)}, ReturnType = typeof(Vector2))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	internal override void set_currentTarget(IEventHandler value) { }

	[CallerCount(Count = 0)]
	internal void set_dispatch(bool value) { }

	[CallerCount(Count = 0)]
	private void set_dispatched(bool value) { }

	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	internal void set_elementTarget(VisualElement value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void set_eventId(ulong value) { }

	[CalledBy(Type = typeof(CommandEventBase`1), Member = "GetPooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event)}, ReturnType = "T")]
	[CalledBy(Type = typeof(KeyboardEventBase`1), Member = "GetPooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event)}, ReturnType = "T")]
	[CalledBy(Type = typeof(MouseEventBase`1), Member = "GetPooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event)}, ReturnType = "T")]
	[CalledBy(Type = typeof(MouseEventBase`1), Member = "GetPooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPointerEvent)}, ReturnType = "T")]
	[CalledBy(Type = typeof(PointerEventBase`1), Member = "GetPooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event)}, ReturnType = "T")]
	[CalledBy(Type = typeof(IMGUIEvent), Member = "GetPooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event)}, ReturnType = typeof(IMGUIEvent))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(Event), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(Event), Member = "CopyFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Event), Member = "get_mousePosition", ReturnType = typeof(Vector2))]
	[CallsUnknownMethods(Count = 2)]
	protected void set_imguiEvent(Event value) { }

	[CallerCount(Count = 0)]
	private void set_imguiEventIsValid(bool value) { }

	[CallerCount(Count = 0)]
	private void set_isImmediatePropagationStopped(bool value) { }

	[CallerCount(Count = 0)]
	private void set_isPropagationStopped(bool value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void set_lifeCycleStatus(LifeCycleStatus value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void set_originalMousePosition(Vector2 value) { }

	[CalledBy(Type = typeof(EventBase`1), Member = "GetPooled", ReturnType = "T")]
	[CalledBy(Type = typeof(EventBase`1), Member = "GetPooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase)}, ReturnType = "T")]
	[CalledBy(Type = typeof(EventBase`1), Member = "ReleasePooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(EventBase`1), Member = "Dispose", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	protected void set_pooled(bool value) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	private void set_processed(bool value) { }

	[CalledBy(Type = typeof(MouseEventBase`1), Member = "PostDispatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPanel)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FocusController), Member = "IgnoreEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FocusController), Member = "SwitchFocusOnEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Focusable), typeof(EventBase)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(IMGUIContainer), Member = "HandleEventBubbleUp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[ContainsUnimplementedInstructions]
	internal void set_processedByFocusController(bool value) { }

	[CalledBy(Type = typeof(EditorPanelRootElement), Member = "OnEventCompletedAtAnyTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	internal void set_propagateToIMGUI(bool value) { }

	[CallerCount(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	internal void set_propagation(EventPropagation value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	internal void set_propagationPhase(PropagationPhase value) { }

	[CallerCount(Count = 0)]
	internal void set_skipDisabledElements(bool value) { }

	[CalledBy(Type = typeof(FocusController), Member = "ReleaseFocus", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Focusable), typeof(Focusable), typeof(FocusChangeDirection), typeof(DispatchMode)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FocusController), Member = "GrabFocus", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Focusable), typeof(Focusable), typeof(FocusChangeDirection), typeof(bool), typeof(DispatchMode)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.PanelEventHandler", Member = "OnSubmit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.EventSystems.BaseEventData"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.PanelEventHandler", Member = "OnCancel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.EventSystems.BaseEventData"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.PanelEventHandler", Member = "OnMove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.EventSystems.AxisEventData"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.PanelEventHandler", Member = "SendTabEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event), typeof(Direction), typeof(Focusable)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.PanelEventHandler", Member = "SendKeyUpEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event), typeof(Focusable)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.PanelEventHandler", Member = "SendKeyDownEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event), typeof(Focusable)}, ReturnType = typeof(void))]
	[CallerCount(Count = 8)]
	[CallsUnknownMethods(Count = 1)]
	public void set_target(IEventHandler value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void set_timestamp(long value) { }

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	protected void set_tricklesDown(bool value) { }

	[CallerCount(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void set_triggerEventId(ulong value) { }

	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	internal void SetTriggerEventId(ulong id) { }

	[CalledBy(Type = typeof(Clickable), Member = "ProcessDownEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase), typeof(Vector2), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BaseField`1), Member = "HandleEventBubbleUp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.Tab+<>c", Member = "<.ctor>b__67_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TooltipEvent)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Tab), Member = "UpdateTooltip", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TooltipEvent)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TabDragger), Member = "OnPointerDown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerDownEvent)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TwoPaneSplitViewResizer), Member = "OnPointerDown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerDownEvent)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MouseEventBase`1), Member = "PostDispatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPanel)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VisualElement), Member = "SetTooltip", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TooltipEvent)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ColumnMover), Member = "OnPointerUp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerUpEvent)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ColumnMover), Member = "ProcessDownEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase), typeof(Vector2), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ColumnMover), Member = "ProcessUpEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase), typeof(Vector2), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ColumnResizer), Member = "OnPointerDown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerDownEvent)}, ReturnType = typeof(void))]
	[CallerCount(Count = 12)]
	public void StopImmediatePropagation() { }

	[CallerCount(Count = 77)]
	public void StopPropagation() { }

}

