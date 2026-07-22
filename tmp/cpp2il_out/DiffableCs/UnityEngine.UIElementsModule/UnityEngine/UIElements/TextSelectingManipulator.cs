namespace UnityEngine.UIElements;

[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
internal class TextSelectingManipulator
{
	private const int k_DragThresholdSqr = 16; //Field offset: 0x0
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal TextSelectingUtilities m_SelectingUtilities; //Field offset: 0x10
	private bool selectAllOnMouseUp; //Field offset: 0x18
	private TextElement m_TextElement; //Field offset: 0x20
	private Vector2 m_ClickStartPosition; //Field offset: 0x28
	private bool m_Dragged; //Field offset: 0x30
	private bool m_IsClicking; //Field offset: 0x31
	private int m_ConsecutiveMouseDownCount; //Field offset: 0x34
	private long m_LastMouseDownTimeStamp; //Field offset: 0x38
	private readonly Event m_ImguiEvent; //Field offset: 0x40

	internal int cursorIndex
	{
		[CalledBy(Type = typeof(TextElement), Member = "UnityEngine.UIElements.ITextSelection.get_cursorIndex", ReturnType = typeof(int))]
		[CallerCount(Count = 1)]
		[Calls(Type = "UnityEngine.TextSelectingUtilities", Member = "get_cursorIndex", ReturnType = typeof(int))]
		internal get { } //Length: 22
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		internal set { } //Length: 30
	}

	internal bool isClicking
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		internal get { } //Length: 5
		[CallerCount(Count = 0)]
		private set { } //Length: 9
	}

	internal int selectIndex
	{
		[CalledBy(Type = typeof(TextElement), Member = "UnityEngine.UIElements.ITextSelection.get_selectIndex", ReturnType = typeof(int))]
		[CallerCount(Count = 1)]
		[Calls(Type = "UnityEngine.TextSelectingUtilities", Member = "get_selectIndex", ReturnType = typeof(int))]
		internal get { } //Length: 22
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		internal set { } //Length: 30
	}

	[CalledBy(Type = typeof(TextElement), Member = "get_selectingManipulator", ReturnType = typeof(TextSelectingManipulator))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Event), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = "UnityEngine.TextSelectingUtilities", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.TextCore.Text.TextHandle"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 13)]
	public TextSelectingManipulator(TextElement textElement) { }

	[CalledBy(Type = typeof(TextElement), Member = "UnityEngine.UIElements.ITextSelection.get_cursorIndex", ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[Calls(Type = "UnityEngine.TextSelectingUtilities", Member = "get_cursorIndex", ReturnType = typeof(int))]
	internal int get_cursorIndex() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	internal bool get_isClicking() { }

	[CalledBy(Type = typeof(TextElement), Member = "UnityEngine.UIElements.ITextSelection.get_selectIndex", ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[Calls(Type = "UnityEngine.TextSelectingUtilities", Member = "get_selectIndex", ReturnType = typeof(int))]
	internal int get_selectIndex() { }

	[CalledBy(Type = typeof(TextElement), Member = "EditionHandleEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CommandEventBase`1), Member = "get_commandName", ReturnType = typeof(string))]
	[Calls(Type = typeof(KeyDownEvent), Member = "GetEquivalentImguiEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event)}, ReturnType = typeof(void))]
	[Calls(Type = "UnityEngine.TextSelectingUtilities", Member = "SelectAll", ReturnType = typeof(void))]
	[Calls(Type = "UnityEngine.TextSelectingUtilities", Member = "Copy", ReturnType = typeof(void))]
	[Calls(Type = typeof(EventBase), Member = "StopPropagation", ReturnType = typeof(void))]
	[Calls(Type = "UnityEngine.TextSelectingUtilities", Member = "get_hasSelection", ReturnType = typeof(bool))]
	[Calls(Type = typeof(TextElement), Member = "get_hasFocus", ReturnType = typeof(bool))]
	[Calls(Type = "UnityEngine.TextSelectingUtilities", Member = "OnFocus", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Event), Member = "get_type", ReturnType = typeof(EventType))]
	[Calls(Type = typeof(Event), Member = "get_current", ReturnType = typeof(Event))]
	[Calls(Type = typeof(VisualElement), Member = "get_panel", ReturnType = typeof(IPanel))]
	[Calls(Type = "UnityEngine.TextCore.Text.TextHandle", Member = "RemoveTextInfoFromPermanentCache", ReturnType = typeof(void))]
	[Calls(Type = typeof(PointerCaptureHelper), Member = "ReleasePointer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IEventHandler), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = "UnityEngine.TextSelectingUtilities", Member = "HandleKeyEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TextSelectingManipulator), Member = "OnPointerMoveEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerMoveEvent)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 13)]
	[CallsUnknownMethods(Count = 5)]
	[ContainsInvalidInstructions]
	[ContainsUnimplementedInstructions]
	internal void HandleEventBubbleUp(EventBase evt) { }

	[CalledBy(Type = typeof(TextElement), Member = "OnGenerateTextOver", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshGenerationContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextElement), Member = "OnGenerateTextOverNative", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshGenerationContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(TextElement), Member = "get_hasFocus", ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	internal bool HasFocus() { }

	[CallerCount(Count = 1)]
	[Calls(Type = "UnityEngine.TextSelectingUtilities", Member = "get_hasSelection", ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	internal bool HasSelection() { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	private bool MoveDistanceQualifiesForDrag(Vector2 start, Vector2 current) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void OnBlurEvent() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
	[Calls(Type = "UnityEngine.TextSelectingUtilities", Member = "get_hasSelection", ReturnType = typeof(bool))]
	[Calls(Type = typeof(FocusController), Member = "set_selectedTextElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextElement)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 2)]
	private void OnCursorIndexChange() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TextElement), Member = "get_hasFocus", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CommandEventBase`1), Member = "get_commandName", ReturnType = typeof(string))]
	[Calls(Type = "UnityEngine.TextSelectingUtilities", Member = "Copy", ReturnType = typeof(void))]
	[Calls(Type = typeof(EventBase), Member = "StopPropagation", ReturnType = typeof(void))]
	[Calls(Type = "UnityEngine.TextSelectingUtilities", Member = "SelectAll", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	private void OnExecuteCommandEvent(ExecuteCommandEvent evt) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VisualElement), Member = "get_panel", ReturnType = typeof(IPanel))]
	[Calls(Type = typeof(Event), Member = "get_current", ReturnType = typeof(Event))]
	[Calls(Type = typeof(Event), Member = "get_type", ReturnType = typeof(EventType))]
	[Calls(Type = "UnityEngine.TextSelectingUtilities", Member = "OnFocus", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	[ContainsUnimplementedInstructions]
	private void OnFocusEvent() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TextElement), Member = "get_hasFocus", ReturnType = typeof(bool))]
	[Calls(Type = typeof(KeyDownEvent), Member = "GetEquivalentImguiEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event)}, ReturnType = typeof(void))]
	[Calls(Type = "UnityEngine.TextSelectingUtilities", Member = "HandleKeyEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(EventBase), Member = "StopPropagation", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private void OnKeyDown(KeyDownEvent evt) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VisualElement), Member = "get_contentRect", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(Event), Member = "GetDoubleClickTime", ReturnType = typeof(int))]
	[Calls(Type = "UnityEngine.TextSelectingUtilities", Member = "get_cursorIndex", ReturnType = typeof(int))]
	[Calls(Type = "UnityEngine.TextSelectingUtilities", Member = "get_selectIndex", ReturnType = typeof(int))]
	[Calls(Type = typeof(PointerEventBase`1), Member = "get_shiftKey", ReturnType = typeof(bool))]
	[Calls(Type = "UnityEngine.TextSelectingUtilities", Member = "MoveCursorToPosition_Internal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = "UnityEngine.TextSelectingUtilities", Member = "SelectCurrentWord", ReturnType = typeof(void))]
	[Calls(Type = "UnityEngine.TextSelectingUtilities", Member = "MouseDragSelectsWholeWords", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = "UnityEngine.TextSelectingUtilities", Member = "SelectCurrentParagraph", ReturnType = typeof(void))]
	[Calls(Type = typeof(PointerCaptureHelper), Member = "CapturePointer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IEventHandler), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(EventBase), Member = "StopPropagation", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 4)]
	private void OnPointerDownEvent(PointerDownEvent evt) { }

	[CalledBy(Type = typeof(TextSelectingManipulator), Member = "HandleEventBubbleUp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(VisualElement), Member = "get_contentRect", ReturnType = typeof(Rect))]
	[Calls(Type = "UnityEngine.TextSelectingUtilities", Member = "SelectToPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = "UnityEngine.TextSelectingUtilities", Member = "get_hasSelection", ReturnType = typeof(bool))]
	[Calls(Type = typeof(EventBase), Member = "StopPropagation", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	private void OnPointerMoveEvent(PointerMoveEvent evt) { }

	[CallerCount(Count = 0)]
	[Calls(Type = "UnityEngine.TextSelectingUtilities", Member = "SelectAll", ReturnType = typeof(void))]
	[Calls(Type = typeof(PointerCaptureHelper), Member = "ReleasePointer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IEventHandler), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(EventBase), Member = "StopPropagation", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private void OnPointerUpEvent(PointerUpEvent evt) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private void OnRevealCursor() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
	[Calls(Type = "UnityEngine.TextSelectingUtilities", Member = "get_hasSelection", ReturnType = typeof(bool))]
	[Calls(Type = typeof(FocusController), Member = "set_selectedTextElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextElement)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 2)]
	private void OnSelectIndexChange() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TextElement), Member = "get_hasFocus", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CommandEventBase`1), Member = "get_commandName", ReturnType = typeof(string))]
	[Calls(Type = "UnityEngine.TextSelectingUtilities", Member = "get_hasSelection", ReturnType = typeof(bool))]
	[Calls(Type = typeof(EventBase), Member = "StopPropagation", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 1)]
	private void OnValidateCommandEvent(ValidateCommandEvent evt) { }

	[CalledBy(Type = typeof(TextElement), Member = "OnGenerateTextOver", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshGenerationContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextElement), Member = "OnGenerateTextOverNative", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshGenerationContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	internal bool RevealCursor() { }

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	internal void set_cursorIndex(int value) { }

	[CallerCount(Count = 0)]
	private void set_isClicking(bool value) { }

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	internal void set_selectIndex(int value) { }

}

