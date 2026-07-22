namespace UnityEngine.UIElements;

internal class TouchScreenTextEditorEventHandler : TextEditorEventHandler
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private static long <Frame>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private static TouchScreenKeyboard <activeTouchScreenKeyboard>k__BackingField; //Field offset: 0x8
	private IVisualElementScheduledItem m_TouchKeyboardPoller; //Field offset: 0x20
	private bool m_IsClicking; //Field offset: 0x28

	private static TouchScreenKeyboard activeTouchScreenKeyboard
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		private set { } //Length: 86
	}

	internal static long Frame
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		internal get { } //Length: 54
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		private set { } //Length: 60
	}

	[CalledBy(Type = typeof(TextEditingManipulator), Member = "UpdateTextEditorEventHandler", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public TouchScreenTextEditorEventHandler(TextElement textElement, TextEditingUtilities editingUtilities) { }

	[CalledBy(Type = typeof(TouchScreenTextEditorEventHandler), Member = "DoPollTouchScreenKeyboard", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TouchScreenTextEditorEventHandler), Member = "OnFocusOutEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FocusOutEvent)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(TouchScreenKeyboard), Member = "set_active", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	private void CloseTouchScreenKeyboard() { }

	[CallerCount(Count = 0)]
	[Calls(Type = "UnityEngine.TextEditingUtilities", Member = "TouchScreenKeyboardCanBeUsed", ReturnType = typeof(bool))]
	[Calls(Type = typeof(TouchScreenKeyboard), Member = "get_text", ReturnType = typeof(string))]
	[Calls(Type = typeof(TouchScreenKeyboard), Member = "get_status", ReturnType = typeof(Status))]
	[Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TouchScreenKeyboard), Member = "get_canGetSelection", ReturnType = typeof(bool))]
	[Calls(Type = typeof(TouchScreenTextEditorEventHandler), Member = "UpdateStringPositionFromKeyboard", ReturnType = typeof(void))]
	[Calls(Type = "UnityEngine.TextEditingUtilities", Member = "set_text", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(UITKTextHandle), Member = "ComputeSettingsAndUpdate", ReturnType = typeof(void))]
	[Calls(Type = "UnityEngine.TextCore.Text.TextHandle", Member = "Update", ReturnType = "UnityEngine.TextCore.Text.TextInfo")]
	[Calls(Type = typeof(TouchScreenTextEditorEventHandler), Member = "CloseTouchScreenKeyboard", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 12)]
	[CallsUnknownMethods(Count = 16)]
	private void DoPollTouchScreenKeyboard() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	internal static long get_Frame() { }

	[CallerCount(Count = 0)]
	[Calls(Type = "UnityEngine.TextEditingUtilities", Member = "TouchScreenKeyboardCanBeUsed", ReturnType = typeof(bool))]
	[Calls(Type = typeof(TouchScreenKeyboard), Member = "get_text", ReturnType = typeof(string))]
	[Calls(Type = typeof(TouchScreenKeyboard), Member = "set_selection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RangeInt)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(EventBase), Member = "StopPropagation", ReturnType = typeof(void))]
	[Calls(Type = typeof(TouchScreenTextEditorEventHandler), Member = "OpenTouchScreenKeyboard", ReturnType = typeof(void))]
	[Calls(Type = typeof(TouchScreenTextEditorEventHandler), Member = "PollTouchScreenKeyboard", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 8)]
	[ContainsInvalidInstructions]
	public virtual void HandleEventBubbleUp(EventBase evt) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TouchScreenTextEditorEventHandler), Member = "OpenTouchScreenKeyboard", ReturnType = typeof(void))]
	[Calls(Type = typeof(TouchScreenTextEditorEventHandler), Member = "PollTouchScreenKeyboard", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 3)]
	private void OnFocusInEvent() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TouchScreenTextEditorEventHandler), Member = "CloseTouchScreenKeyboard", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallsUnknownMethods(Count = 12)]
	private void OnFocusOutEvent(FocusOutEvent evt) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TouchScreenKeyboard), Member = "get_text", ReturnType = typeof(string))]
	[Calls(Type = typeof(TouchScreenKeyboard), Member = "set_selection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RangeInt)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	private void OnPointerDownEvent() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EventBase), Member = "StopPropagation", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private void OnPointerUpEvent(PointerUpEvent evt) { }

	[CalledBy(Type = typeof(TouchScreenTextEditorEventHandler), Member = "HandleEventBubbleUp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TouchScreenTextEditorEventHandler), Member = "OnFocusInEvent", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(TouchScreenKeyboard), Member = "set_hideInput", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TouchScreenKeyboard), Member = "Open", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(TouchScreenKeyboardType), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(TouchScreenKeyboard))]
	[Calls(Type = typeof(TouchScreenKeyboard), Member = "get_text", ReturnType = typeof(string))]
	[Calls(Type = typeof(TouchScreenKeyboard), Member = "set_selection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RangeInt)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 13)]
	private void OpenTouchScreenKeyboard() { }

	[CalledBy(Type = typeof(TouchScreenTextEditorEventHandler), Member = "HandleEventBubbleUp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TouchScreenTextEditorEventHandler), Member = "OnFocusInEvent", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(TouchScreenKeyboard), Member = "get_isSupported", ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 5)]
	private void PollTouchScreenKeyboard() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	private static void set_activeTouchScreenKeyboard(TouchScreenKeyboard value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	private static void set_Frame(long value) { }

	[CalledBy(Type = typeof(TouchScreenTextEditorEventHandler), Member = "DoPollTouchScreenKeyboard", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(TouchScreenKeyboard), Member = "get_selection", ReturnType = typeof(RangeInt))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 5)]
	private void UpdateStringPositionFromKeyboard() { }

}

