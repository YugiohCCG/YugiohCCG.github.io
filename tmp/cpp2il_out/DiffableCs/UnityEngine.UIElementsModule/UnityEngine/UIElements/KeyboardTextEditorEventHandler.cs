namespace UnityEngine.UIElements;

internal class KeyboardTextEditorEventHandler : TextEditorEventHandler
{
	private readonly Event m_ImguiEvent; //Field offset: 0x20
	internal bool m_Changed; //Field offset: 0x28
	internal bool m_ShouldInvokeUpdateValue; //Field offset: 0x29

	[CalledBy(Type = typeof(TextEditingManipulator), Member = "UpdateTextEditorEventHandler", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Event), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	public KeyboardTextEditorEventHandler(TextElement textElement, TextEditingUtilities editingUtilities) { }

	[CalledBy(Type = typeof(KeyboardTextEditorEventHandler), Member = "OnKeyDown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(KeyDownEvent)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	private void ApplyTextIfNeeded() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(KeyboardTextEditorEventHandler), Member = "OnKeyDown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(KeyDownEvent)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TextElement), Member = "get_hasFocus", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CommandEventBase`1), Member = "get_commandName", ReturnType = typeof(string))]
	[Calls(Type = "UnityEngine.TextEditingUtilities", Member = "CanPaste", ReturnType = typeof(bool))]
	[Calls(Type = typeof(EventBase), Member = "StopPropagation", ReturnType = typeof(void))]
	[Calls(Type = typeof(GUIUtility), Member = "set_imeCompositionMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IMECompositionMode)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(KeyboardTextEditorEventHandler), Member = "OnNavigationEvent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TEvent"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.NavigationEventBase`1<TEvent>"}, ReturnType = typeof(void))]
	[Calls(Type = "UnityEngine.TextEditingUtilities", Member = "UpdateImeState", ReturnType = typeof(bool))]
	[Calls(Type = typeof(KeyboardTextEditorEventHandler), Member = "UpdateLabel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 3)]
	[ContainsInvalidInstructions]
	public virtual void HandleEventBubbleUp(EventBase evt) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GUIUtility), Member = "set_imeCompositionMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IMECompositionMode)}, ReturnType = typeof(void))]
	private void OnBlur(BlurEvent _) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TextElement), Member = "get_hasFocus", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CommandEventBase`1), Member = "get_commandName", ReturnType = typeof(string))]
	[Calls(Type = typeof(EventBase), Member = "StopPropagation", ReturnType = typeof(void))]
	[Calls(Type = "UnityEngine.TextEditingUtilities", Member = "Paste", ReturnType = typeof(bool))]
	[Calls(Type = "UnityEngine.TextEditingUtilities", Member = "Cut", ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(KeyboardTextEditorEventHandler), Member = "UpdateLabel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 2)]
	private void OnExecuteCommandEvent(ExecuteCommandEvent evt) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GUIUtility), Member = "set_imeCompositionMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IMECompositionMode)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void OnFocus(FocusEvent _) { }

	[CallerCount(Count = 0)]
	[Calls(Type = "UnityEngine.TextEditingUtilities", Member = "UpdateImeState", ReturnType = typeof(bool))]
	[Calls(Type = typeof(KeyboardTextEditorEventHandler), Member = "UpdateLabel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private void OnIMEInput(IMEEvent _) { }

	[CalledBy(Type = typeof(KeyboardTextEditorEventHandler), Member = "HandleEventBubbleUp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(EventBase), Member = "StopPropagation", ReturnType = typeof(void))]
	[Calls(Type = typeof(TextElement), Member = "get_hasFocus", ReturnType = typeof(bool))]
	[Calls(Type = typeof(KeyDownEvent), Member = "GetEquivalentImguiEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event)}, ReturnType = typeof(void))]
	[Calls(Type = "UnityEngine.TextEditingUtilities", Member = "HandleKeyEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(KeyboardEventBase`1), Member = "get_actionKey", ReturnType = typeof(bool))]
	[Calls(Type = typeof(KeyboardEventExtensions), Member = "ShouldSendNavigationMoveEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(KeyDownEvent)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(FocusController), Member = "FocusNextInDirection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Focusable), typeof(FocusChangeDirection)}, ReturnType = typeof(Focusable))]
	[Calls(Type = "UnityEngine.TextEditingUtilities", Member = "UpdateImeState", ReturnType = typeof(bool))]
	[Calls(Type = "UnityEngine.TextEditingUtilities", Member = "Insert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(KeyboardTextEditorEventHandler), Member = "ApplyTextIfNeeded", ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(KeyboardTextEditorEventHandler), Member = "UpdateLabel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 24)]
	[CallsUnknownMethods(Count = 11)]
	[ContainsUnimplementedInstructions]
	private void OnKeyDown(KeyDownEvent evt) { }

	[CalledBy(Type = typeof(KeyboardTextEditorEventHandler), Member = "HandleEventBubbleUp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(EventBase), Member = "StopPropagation", ReturnType = typeof(void))]
	[Calls(Type = typeof(FocusController), Member = "IgnoreEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	private void OnNavigationEvent(NavigationEventBase<TEvent> evt) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TextElement), Member = "get_hasFocus", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CommandEventBase`1), Member = "get_commandName", ReturnType = typeof(string))]
	[Calls(Type = "UnityEngine.TextEditingUtilities", Member = "CanPaste", ReturnType = typeof(bool))]
	[Calls(Type = typeof(EventBase), Member = "StopPropagation", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 2)]
	private void OnValidateCommandEvent(ValidateCommandEvent evt) { }

	[CalledBy(Type = typeof(KeyboardTextEditorEventHandler), Member = "HandleEventBubbleUp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(KeyboardTextEditorEventHandler), Member = "OnIMEInput", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IMEEvent)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(KeyboardTextEditorEventHandler), Member = "OnKeyDown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(KeyDownEvent)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(KeyboardTextEditorEventHandler), Member = "OnExecuteCommandEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExecuteCommandEvent)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = "UnityEngine.TextEditingUtilities", Member = "UpdateImeState", ReturnType = typeof(bool))]
	[Calls(Type = "UnityEngine.TextEditingUtilities", Member = "ShouldUpdateImeWindowPosition", ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElement), Member = "get_worldBound", ReturnType = typeof(Rect))]
	[Calls(Type = "UnityEngine.TextEditingUtilities", Member = "SetImeWindowPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = "UnityEngine.TextEditingUtilities", Member = "GeneratePreviewString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(string))]
	[Calls(Type = "UnityEngine.TextEditingUtilities", Member = "set_text", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = "UnityEngine.TextEditingUtilities", Member = "EnableCursorPreviewState", ReturnType = typeof(void))]
	[Calls(Type = typeof(UITKTextHandle), Member = "ComputeSettingsAndUpdate", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 4)]
	private void UpdateLabel(bool generatePreview) { }

}

