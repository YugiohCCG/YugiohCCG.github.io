namespace UnityEngine.UIElements;

[EventCategory(EventCategory::Command (15))]
public abstract class CommandEventBase : EventBase<T>
{
	private string m_CommandName; //Field offset: 0x0

	public override string commandName
	{
		[CalledBy(Type = typeof(KeyboardTextEditorEventHandler), Member = "HandleEventBubbleUp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(KeyboardTextEditorEventHandler), Member = "OnValidateCommandEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ValidateCommandEvent)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(KeyboardTextEditorEventHandler), Member = "OnExecuteCommandEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExecuteCommandEvent)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TextSelectingManipulator), Member = "HandleEventBubbleUp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TextSelectingManipulator), Member = "OnValidateCommandEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ValidateCommandEvent)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TextSelectingManipulator), Member = "OnExecuteCommandEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExecuteCommandEvent)}, ReturnType = typeof(void))]
		[CallerCount(Count = 7)]
		[Calls(Type = typeof(EventBase), Member = "get_imguiEvent", ReturnType = typeof(Event))]
		[Calls(Type = typeof(Event), Member = "get_commandName", ReturnType = typeof(string))]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 73
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 set { } //Length: 13
	}

	[CalledBy(Type = "UnityEngine.UIElements.ValidateCommandEvent+<>c", Member = "<.cctor>b__0_0", ReturnType = typeof(ValidateCommandEvent))]
	[CalledBy(Type = typeof(ValidateCommandEvent), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.ExecuteCommandEvent+<>c", Member = "<.cctor>b__0_0", ReturnType = typeof(ExecuteCommandEvent))]
	[CalledBy(Type = typeof(ExecuteCommandEvent), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(EventBase`1), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	protected CommandEventBase`1() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EventDispatchUtilities), Member = "DispatchToFocusedElementOrPanelRoot", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase), typeof(BaseVisualElementPanel)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	internal virtual void Dispatch(BaseVisualElementPanel panel) { }

	[CalledBy(Type = typeof(KeyboardTextEditorEventHandler), Member = "HandleEventBubbleUp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(KeyboardTextEditorEventHandler), Member = "OnValidateCommandEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ValidateCommandEvent)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(KeyboardTextEditorEventHandler), Member = "OnExecuteCommandEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExecuteCommandEvent)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextSelectingManipulator), Member = "HandleEventBubbleUp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextSelectingManipulator), Member = "OnValidateCommandEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ValidateCommandEvent)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextSelectingManipulator), Member = "OnExecuteCommandEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExecuteCommandEvent)}, ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(EventBase), Member = "get_imguiEvent", ReturnType = typeof(Event))]
	[Calls(Type = typeof(Event), Member = "get_commandName", ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public override string get_commandName() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EventBase`1), Member = "GetPooled", ReturnType = "T")]
	[Calls(Type = typeof(EventBase), Member = "set_imguiEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	[DeduplicatedMethod]
	public static T GetPooled(Event systemEvent) { }

	[CalledBy(Type = typeof(TextElement), Member = "ProcessMenuCommand", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(EventBase`1), Member = "GetPooled", ReturnType = "T")]
	[CallsUnknownMethods(Count = 6)]
	[DeduplicatedMethod]
	public static T GetPooled(string commandName) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EventBase`1), Member = "Init", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	protected virtual void Init() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	private void LocalInit() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	protected void set_commandName(string value) { }

}

