namespace UnityEngine.InputForUI;

[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
internal struct Event : IEventProperties
{
	private interface IMapFn
	{

		public TOutputType Map(ref TEventType ev) { }

	}

	private struct MapAsEventModifiers : IMapFn<EventModifiers>
	{

		[CallerCount(Count = 3)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		public override EventModifiers Map(ref TEventType ev) { }

	}

	private struct MapAsEventSource : IMapFn<EventSource>
	{

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		public override EventSource Map(ref TEventType ev) { }

	}

	private struct MapAsObject : IMapFn<IEventProperties>
	{

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		public override IEventProperties Map(ref TEventType ev) { }

	}

	internal enum Type
	{
		Invalid = 0,
		KeyEvent = 1,
		PointerEvent = 2,
		TextInputEvent = 3,
		IMECompositionEvent = 4,
		CommandEvent = 5,
		NavigationEvent = 6,
	}

	public static Type[] TypesWithState; //Field offset: 0x0
	private Type _type; //Field offset: 0x0
	private object _managedEvent; //Field offset: 0x8
	private KeyEvent _keyEvent; //Field offset: 0x10
	private PointerEvent _pointerEvent; //Field offset: 0x10
	private TextInputEvent _textInputEvent; //Field offset: 0x10
	private CommandEvent _commandEvent; //Field offset: 0x10
	private NavigationEvent _navigationEvent; //Field offset: 0x10

	public CommandEvent asCommandEvent
	{
		[CalledBy(Type = "UnityEngine.UIElements.DefaultEventSystem+InputForUIProcessor", Member = "ProcessInputForUIEvents", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Event), Member = "Ensure", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(void))]
		 get { } //Length: 120
	}

	public IMECompositionEvent asIMECompositionEvent
	{
		[CalledBy(Type = "UnityEngine.UIElements.DefaultEventSystem+InputForUIProcessor", Member = "ProcessInputForUIEvents", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Event), Member = "Ensure", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 2)]
		 get { } //Length: 179
	}

	public KeyEvent asKeyEvent
	{
		[CalledBy(Type = "UnityEngine.UIElements.DefaultEventSystem+InputForUIProcessor", Member = "ProcessInputForUIEvents", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Event), Member = "Ensure", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(void))]
		 get { } //Length: 159
	}

	public NavigationEvent asNavigationEvent
	{
		[CalledBy(Type = "UnityEngine.UIElements.DefaultEventSystem+InputForUIProcessor", Member = "ProcessInputForUIEvents", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Event), Member = "Ensure", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(void))]
		 get { } //Length: 135
	}

	private IEventProperties asObject
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Event), Member = "Map", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(MapAsObject)}, ReturnType = typeof(object))]
		private get { } //Length: 90
	}

	public PointerEvent asPointerEvent
	{
		[CalledBy(Type = "UnityEngine.UIElements.DefaultEventSystem+InputForUIProcessor", Member = "ProcessInputForUIEvents", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Event), Member = "Ensure", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(void))]
		 get { } //Length: 168
	}

	public TextInputEvent asTextInputEvent
	{
		[CalledBy(Type = "UnityEngine.UIElements.DefaultEventSystem+InputForUIProcessor", Member = "ProcessInputForUIEvents", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Event), Member = "Ensure", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(void))]
		 get { } //Length: 120
	}

	public override EventModifiers eventModifiers
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Event), Member = "Map", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TOutputType", "TMapType"}, ReturnType = "TOutputType")]
		 get { } //Length: 90
	}

	public override EventSource eventSource
	{
		[CalledBy(Type = "UnityEngine.InputSystem.Plugins.InputForUI.InputSystemProvider", Member = "Update", ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(Event), Member = "Map", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"System.Int32Enum", typeof(MapAsEventSource)}, ReturnType = "System.Int32Enum")]
		 get { } //Length: 90
	}

	public Type type
	{
		[CallerCount(Count = 173)]
		[DeduplicatedMethod]
		 get { } //Length: 3
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(RuntimeFieldHandle)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private static Event() { }

	[CalledBy(Type = "UnityEngine.InputSystem.Plugins.InputForUI.InputSystemProvider+<>c", Member = "<Update>b__33_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event), typeof(Event)}, ReturnType = typeof(int))]
	[CalledBy(Type = "UnityEngine.InputSystem.Plugins.InputForUI.InputSystemProvider", Member = "SortEvents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event), typeof(Event)}, ReturnType = typeof(int))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Event), Member = "Map", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"System.Int32Enum", typeof(MapAsEventSource)}, ReturnType = "System.Int32Enum")]
	[Calls(Type = typeof(int), Member = "CompareTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	internal static int CompareType(Event a, Event b) { }

	[CalledBy(Type = typeof(Event), Member = "get_asKeyEvent", ReturnType = typeof(KeyEvent))]
	[CalledBy(Type = typeof(Event), Member = "get_asPointerEvent", ReturnType = typeof(PointerEvent))]
	[CalledBy(Type = typeof(Event), Member = "get_asTextInputEvent", ReturnType = typeof(TextInputEvent))]
	[CalledBy(Type = typeof(Event), Member = "get_asIMECompositionEvent", ReturnType = typeof(IMECompositionEvent))]
	[CalledBy(Type = typeof(Event), Member = "get_asCommandEvent", ReturnType = typeof(CommandEvent))]
	[CalledBy(Type = typeof(Event), Member = "get_asNavigationEvent", ReturnType = typeof(NavigationEvent))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(Debug), Member = "Assert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[ContainsUnimplementedInstructions]
	private void Ensure(Type t) { }

	[CallerCount(Count = 0)]
	public static Event From(TextInputEvent textInputEvent) { }

	[CalledBy(Type = "UnityEngine.InputSystem.Plugins.InputForUI.InputSystemProvider", Member = "DirectionNavigation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DiscreteTime)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.InputSystem.Plugins.InputForUI.InputSystemProvider", Member = "OnSubmitPerformed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.InputSystem.InputAction+CallbackContext"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.InputSystem.Plugins.InputForUI.InputSystemProvider", Member = "OnCancelPerformed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.InputSystem.InputAction+CallbackContext"}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	public static Event From(NavigationEvent navigationEvent) { }

	[CallerCount(Count = 0)]
	public static Event From(KeyEvent keyEvent) { }

	[CalledBy(Type = "UnityEngine.InputSystem.Plugins.InputForUI.InputSystemProvider", Member = "RequestCurrentState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.InputSystem.Plugins.InputForUI.InputSystemProvider", Member = "OnPointerPerformed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.InputSystem.InputAction+CallbackContext"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.InputSystem.Plugins.InputForUI.InputSystemProvider", Member = "OnClickPerformed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.InputSystem.InputAction+CallbackContext", typeof(EventSource), typeof(Button)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.InputSystem.Plugins.InputForUI.InputSystemProvider", Member = "OnScrollWheelPerformed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.InputSystem.InputAction+CallbackContext"}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	public static Event From(PointerEvent pointerEvent) { }

	[CallerCount(Count = 0)]
	public static Event From(CommandEvent commandEvent) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public static Event From(IMECompositionEvent imeCompositionEvent) { }

	[CalledBy(Type = "UnityEngine.UIElements.DefaultEventSystem+InputForUIProcessor", Member = "ProcessInputForUIEvents", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Event), Member = "Ensure", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(void))]
	public CommandEvent get_asCommandEvent() { }

	[CalledBy(Type = "UnityEngine.UIElements.DefaultEventSystem+InputForUIProcessor", Member = "ProcessInputForUIEvents", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Event), Member = "Ensure", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	public IMECompositionEvent get_asIMECompositionEvent() { }

	[CalledBy(Type = "UnityEngine.UIElements.DefaultEventSystem+InputForUIProcessor", Member = "ProcessInputForUIEvents", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Event), Member = "Ensure", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(void))]
	public KeyEvent get_asKeyEvent() { }

	[CalledBy(Type = "UnityEngine.UIElements.DefaultEventSystem+InputForUIProcessor", Member = "ProcessInputForUIEvents", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Event), Member = "Ensure", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(void))]
	public NavigationEvent get_asNavigationEvent() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Event), Member = "Map", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(MapAsObject)}, ReturnType = typeof(object))]
	private IEventProperties get_asObject() { }

	[CalledBy(Type = "UnityEngine.UIElements.DefaultEventSystem+InputForUIProcessor", Member = "ProcessInputForUIEvents", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Event), Member = "Ensure", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(void))]
	public PointerEvent get_asPointerEvent() { }

	[CalledBy(Type = "UnityEngine.UIElements.DefaultEventSystem+InputForUIProcessor", Member = "ProcessInputForUIEvents", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Event), Member = "Ensure", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(void))]
	public TextInputEvent get_asTextInputEvent() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Event), Member = "Map", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TOutputType", "TMapType"}, ReturnType = "TOutputType")]
	public override EventModifiers get_eventModifiers() { }

	[CalledBy(Type = "UnityEngine.InputSystem.Plugins.InputForUI.InputSystemProvider", Member = "Update", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Event), Member = "Map", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"System.Int32Enum", typeof(MapAsEventSource)}, ReturnType = "System.Int32Enum")]
	public override EventSource get_eventSource() { }

	[CallerCount(Count = 173)]
	[DeduplicatedMethod]
	public Type get_type() { }

	[CalledBy(Type = typeof(Event), Member = "get_eventModifiers", ReturnType = typeof(EventModifiers))]
	[CalledBy(Type = typeof(Event), Member = "ToString", ReturnType = typeof(string))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Activator), Member = "CreateInstance", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[CallsUnknownMethods(Count = 1)]
	[ContainsInvalidInstructions]
	[DeduplicatedMethod]
	private TOutputType Map() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MapAsEventModifiers), Member = "Map", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(KeyEvent)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(KeyEvent&)}, ReturnType = typeof(EventModifiers))]
	[Calls(Type = typeof(MapAsEventModifiers), Member = "Map", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEvent)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEvent&)}, ReturnType = typeof(EventModifiers))]
	[Calls(Type = typeof(MapAsEventModifiers), Member = "Map", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NavigationEvent)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NavigationEvent&)}, ReturnType = typeof(EventModifiers))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 6)]
	[DeduplicatedMethod]
	private TOutputType Map(TMapType fn) { }

	[CalledBy(Type = "UnityEngine.UIElements.DefaultEventSystem+InputForUIProcessor", Member = "ProcessInputForUIEvents", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Event), Member = "Map", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TOutputType", "TMapType"}, ReturnType = "TOutputType")]
	[Calls(Type = typeof(EventModifiers), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Event), Member = "Map", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(MapAsObject)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(Event), Member = "Map", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"System.Int32Enum", typeof(MapAsEventSource)}, ReturnType = "System.Int32Enum")]
	[Calls(Type = typeof(Enum), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	public virtual string ToString() { }

}

