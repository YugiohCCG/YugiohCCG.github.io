namespace UnityEngine.InputForUI;

internal class InputEventPartialProvider : IEventProviderImpl
{
	private Event _ev; //Field offset: 0x10
	private OperatingSystemFamily _operatingSystemFamily; //Field offset: 0x18
	private ButtonsState _keyboardButtonsState; //Field offset: 0x1C
	internal EventModifiers _eventModifiers; //Field offset: 0x44
	internal bool _sendNavigationEventOnTabKey; //Field offset: 0x48
	private IDictionary<String, Command> _IMGUICommandToInputForUICommandType; //Field offset: 0x50

	[CalledBy(Type = typeof(InputManagerProvider), Member = "Initialize", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.InputSystem.Plugins.InputForUI.InputSystemProvider", Member = "Initialize", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Event), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Int32Enum>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), "System.Int32Enum"}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public InputEventPartialProvider() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Time), Member = "get_timeAsRational", ReturnType = typeof(RationalTime))]
	[Calls(Type = typeof(RationalTime), Member = "op_Explicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RationalTime)}, ReturnType = typeof(DiscreteTime))]
	private DiscreteTime GetTimestamp(in Event ev) { }

	[CalledBy(Type = "UnityEngine.InputSystem.Plugins.InputForUI.InputSystemProvider", Member = "Initialize", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	public override void Initialize() { }

	[CalledBy(Type = "UnityEngine.InputSystem.Plugins.InputForUI.InputSystemProvider", Member = "OnFocusChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	public override void OnFocusChanged(bool focus) { }

	[CalledBy(Type = "UnityEngine.InputSystem.Plugins.InputForUI.InputSystemProvider", Member = "RequestCurrentState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Time), Member = "get_timeAsRational", ReturnType = typeof(RationalTime))]
	[Calls(Type = typeof(RationalTime), Member = "op_Explicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RationalTime)}, ReturnType = typeof(DiscreteTime))]
	[Calls(Type = typeof(EventProvider), Member = "Dispatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event&)}, ReturnType = typeof(void))]
	[ContainsUnimplementedInstructions]
	public override bool RequestCurrentState(Type type) { }

	[CalledBy(Type = typeof(InputEventPartialProvider), Member = "Update", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Event), Member = "get_type", ReturnType = typeof(EventType))]
	[Calls(Type = typeof(Event), Member = "get_keyCode", ReturnType = typeof(KeyCode))]
	[Calls(Type = typeof(Event), Member = "get_shift", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Time), Member = "get_timeAsRational", ReturnType = typeof(RationalTime))]
	[Calls(Type = typeof(RationalTime), Member = "op_Explicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RationalTime)}, ReturnType = typeof(DiscreteTime))]
	[Calls(Type = typeof(EventProvider), Member = "Dispatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event&)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private void SendNextOrPreviousNavigationEventOnTabKeyDownEvent(in Event ev) { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	public override void Shutdown() { }

	[CalledBy(Type = typeof(InputEventPartialProvider), Member = "Update", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Event), Member = "get_commandName", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Debug), Member = "LogWarning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Event), Member = "get_type", ReturnType = typeof(EventType))]
	[Calls(Type = typeof(Time), Member = "get_timeAsRational", ReturnType = typeof(RationalTime))]
	[Calls(Type = typeof(RationalTime), Member = "op_Explicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RationalTime)}, ReturnType = typeof(DiscreteTime))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	private CommandEvent ToCommandEvent(in Event ev) { }

	[CalledBy(Type = typeof(InputEventPartialProvider), Member = "Update", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Event), Member = "get_keyCode", ReturnType = typeof(KeyCode))]
	[Calls(Type = typeof(Event), Member = "get_type", ReturnType = typeof(EventType))]
	[Calls(Type = typeof(Time), Member = "get_timeAsRational", ReturnType = typeof(RationalTime))]
	[Calls(Type = typeof(RationalTime), Member = "op_Explicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RationalTime)}, ReturnType = typeof(DiscreteTime))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private KeyEvent ToKeyEvent(in Event ev) { }

	[CalledBy(Type = typeof(InputEventPartialProvider), Member = "Update", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Event), Member = "get_character", ReturnType = typeof(char))]
	[Calls(Type = typeof(Time), Member = "get_timeAsRational", ReturnType = typeof(RationalTime))]
	[Calls(Type = typeof(RationalTime), Member = "op_Explicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RationalTime)}, ReturnType = typeof(DiscreteTime))]
	[CallsUnknownMethods(Count = 1)]
	private TextInputEvent ToTextInputEvent(in Event ev) { }

	[CalledBy(Type = typeof(InputManagerProvider), Member = "Update", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.InputSystem.Plugins.InputForUI.InputSystemProvider", Member = "Update", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Event), Member = "GetEventCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(Event), Member = "GetEventAtIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Event)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputEventPartialProvider), Member = "UpdateEventModifiers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Event), Member = "get_type", ReturnType = typeof(EventType))]
	[Calls(Type = typeof(Event), Member = "get_keyCode", ReturnType = typeof(KeyCode))]
	[Calls(Type = typeof(InputEventPartialProvider), Member = "ToTextInputEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event&)}, ReturnType = typeof(TextInputEvent))]
	[Calls(Type = typeof(InputEventPartialProvider), Member = "ToKeyEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event&)}, ReturnType = typeof(KeyEvent))]
	[Calls(Type = typeof(EventProvider), Member = "Dispatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputEventPartialProvider), Member = "SendNextOrPreviousNavigationEventOnTabKeyDownEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Event), Member = "get_character", ReturnType = typeof(char))]
	[Calls(Type = typeof(InputEventPartialProvider), Member = "ToCommandEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event&)}, ReturnType = typeof(CommandEvent))]
	[CallsUnknownMethods(Count = 1)]
	public override void Update() { }

	[CalledBy(Type = typeof(InputEventPartialProvider), Member = "Update", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Event), Member = "get_capsLock", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Event), Member = "get_functionKey", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Event), Member = "get_numeric", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Event), Member = "get_isKey", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Event), Member = "get_keyCode", ReturnType = typeof(KeyCode))]
	[Calls(Type = typeof(Event), Member = "get_type", ReturnType = typeof(EventType))]
	[ContainsInvalidInstructions]
	[ContainsUnimplementedInstructions]
	private void UpdateEventModifiers(in Event ev) { }

}

