namespace UnityEngine;

[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
internal class TextEditingUtilities
{
	private static Dictionary<Event, TextEditOp> s_KeyEditOps; //Field offset: 0x0
	private TextSelectingUtilities m_TextSelectingUtility; //Field offset: 0x10
	internal TextHandle textHandle; //Field offset: 0x18
	private int m_CursorIndexSavedState; //Field offset: 0x20
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
	internal bool isCompositionActive; //Field offset: 0x24
	private bool m_UpdateImeWindowPosition; //Field offset: 0x25
	internal Action OnTextChanged; //Field offset: 0x28
	public bool multiline; //Field offset: 0x30
	private string m_Text; //Field offset: 0x38
	private char m_HighSurrogate; //Field offset: 0x40

	private int cursorIndex
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(TextSelectingUtilities), Member = "get_cursorIndex", ReturnType = typeof(int))]
		[CallsUnknownMethods(Count = 1)]
		private get { } //Length: 29
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		private set { } //Length: 30
	}

	private int cursorIndexNoValidation
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(TextSelectingUtilities), Member = "get_cursorIndexNoValidation", ReturnType = typeof(int))]
		[CallsUnknownMethods(Count = 1)]
		private get { } //Length: 29
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		private set { } //Length: 30
	}

	private bool hasSelection
	{
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(TextSelectingUtilities), Member = "get_hasSelection", ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		private get { } //Length: 29
	}

	internal bool revealCursor
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(TextSelectingUtilities), Member = "set_revealCursor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		internal set { } //Length: 30
	}

	private int selectIndex
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(TextSelectingUtilities), Member = "get_selectIndex", ReturnType = typeof(int))]
		[CallsUnknownMethods(Count = 1)]
		private get { } //Length: 29
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		private set { } //Length: 30
	}

	private int selectIndexNoValidation
	{
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		private set { } //Length: 30
	}

	internal int stringCursorIndex
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(TextSelectingUtilities), Member = "get_cursorIndex", ReturnType = typeof(int))]
		[Calls(Type = "UnityEngine.TextCore.Text.TextHandle", Member = "GetCorrespondingStringIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
		[CallsUnknownMethods(Count = 1)]
		internal get { } //Length: 57
	}

	internal int stringSelectIndex
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(TextSelectingUtilities), Member = "get_selectIndex", ReturnType = typeof(int))]
		[Calls(Type = "UnityEngine.TextCore.Text.TextHandle", Member = "GetCorrespondingStringIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
		[CallsUnknownMethods(Count = 1)]
		internal get { } //Length: 57
	}

	public string text
	{
		[CallerCount(Count = 38)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CalledBy(Type = "UnityEngine.UIElements.KeyboardTextEditorEventHandler", Member = "UpdateLabel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UIElements.TouchScreenTextEditorEventHandler", Member = "DoPollTouchScreenKeyboard", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UIElements.TextElement", Member = "UnityEngine.UIElements.INotifyValueChanged<System.String>.SetValueWithoutNotify", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallerCount(Count = 4)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		 set { } //Length: 104
	}

	[CalledBy(Type = "UnityEngine.UIElements.TextEditingManipulator", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.TextElement"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextEditor), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public TextEditingUtilities(TextSelectingUtilities selectingUtilities, TextHandle textHandle, string text) { }

	[CalledBy(Type = typeof(TextEditingUtilities), Member = "PerformOperation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextEditOp)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TextSelectingUtilities), Member = "get_hasSelection", ReturnType = typeof(bool))]
	[Calls(Type = typeof(TextSelectingUtilities), Member = "get_cursorIndex", ReturnType = typeof(int))]
	[Calls(Type = typeof(TextSelectingUtilities), Member = "PreviousCodePointIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = "UnityEngine.TextCore.Text.TextHandle", Member = "get_textInfo", ReturnType = "UnityEngine.TextCore.Text.TextInfo")]
	[Calls(Type = "UnityEngine.TextCore.Text.TextHandle", Member = "GetCorrespondingStringIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(string), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Math), Member = "Max", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(TextSelectingUtilities), Member = "get_selectIndex", ReturnType = typeof(int))]
	[Calls(Type = typeof(TextSelectingUtilities), Member = "ClearCursorPos", ReturnType = typeof(void))]
	[Calls(Type = typeof(TextEditingUtilities), Member = "DeleteSelection", ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallsUnknownMethods(Count = 3)]
	public bool Backspace() { }

	[CalledBy(Type = "UnityEngine.UIElements.KeyboardTextEditorEventHandler", Member = "HandleEventBubbleUp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.EventBase"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.KeyboardTextEditorEventHandler", Member = "OnValidateCommandEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.ValidateCommandEvent"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.TextElement", Member = "PasteActionStatus", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.DropdownMenuAction"}, ReturnType = "UnityEngine.UIElements.DropdownMenuAction+Status")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(GUIUtility), Member = "get_systemCopyBuffer", ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public bool CanPaste() { }

	[CalledBy(Type = "UnityEngine.UIElements.KeyboardTextEditorEventHandler", Member = "OnExecuteCommandEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.ExecuteCommandEvent"}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TextSelectingUtilities), Member = "Copy", ReturnType = typeof(void))]
	[Calls(Type = typeof(TextEditingUtilities), Member = "DeleteSelection", ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	public bool Cut() { }

	[CalledBy(Type = typeof(TextEditingUtilities), Member = "PerformOperation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextEditOp)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TextSelectingUtilities), Member = "get_hasSelection", ReturnType = typeof(bool))]
	[Calls(Type = typeof(TextSelectingUtilities), Member = "get_cursorIndex", ReturnType = typeof(int))]
	[Calls(Type = "UnityEngine.TextCore.Text.TextHandle", Member = "GetCorrespondingStringIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = "UnityEngine.TextCore.Text.TextHandle", Member = "get_textInfo", ReturnType = "UnityEngine.TextCore.Text.TextInfo")]
	[Calls(Type = "UnityEngine.TextCore.Text.TextHandle", Member = "NextCodePointIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(string), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(TextEditingUtilities), Member = "DeleteSelection", ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 3)]
	public bool Delete() { }

	[CalledBy(Type = typeof(TextEditingUtilities), Member = "PerformOperation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextEditOp)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TextSelectingUtilities), Member = "get_hasSelection", ReturnType = typeof(bool))]
	[Calls(Type = typeof(TextSelectingUtilities), Member = "get_cursorIndex", ReturnType = typeof(int))]
	[Calls(Type = "UnityEngine.TextCore.Text.TextHandle", Member = "GetLineInfoFromCharacterIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "UnityEngine.TextCore.Text.LineInfo")]
	[Calls(Type = "UnityEngine.TextCore.Text.TextHandle", Member = "GetCorrespondingStringIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(string), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = "UnityEngine.TextCore.Text.TextHandle", Member = "GetFirstCharacterIndexOnLine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(TextEditingUtilities), Member = "DeleteSelection", ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	public bool DeleteLineBack() { }

	[CalledBy(Type = typeof(TextEditingUtilities), Member = "PerformOperation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextEditOp)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextEditingUtilities), Member = "DeleteLineBack", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TextEditingUtilities), Member = "DeleteWordBack", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TextEditingUtilities), Member = "DeleteWordForward", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TextEditingUtilities), Member = "Delete", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TextEditingUtilities), Member = "Backspace", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TextEditingUtilities), Member = "ReplaceSelection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextEditingUtilities), Member = "Cut", ReturnType = typeof(bool))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(TextSelectingUtilities), Member = "get_cursorIndex", ReturnType = typeof(int))]
	[Calls(Type = typeof(TextSelectingUtilities), Member = "get_selectIndex", ReturnType = typeof(int))]
	[Calls(Type = "UnityEngine.TextCore.Text.TextHandle", Member = "GetCorrespondingStringIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(TextSelectingUtilities), Member = "ClearCursorPos", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 3)]
	public bool DeleteSelection() { }

	[CalledBy(Type = typeof(TextEditingUtilities), Member = "PerformOperation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextEditOp)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TextSelectingUtilities), Member = "get_hasSelection", ReturnType = typeof(bool))]
	[Calls(Type = typeof(TextSelectingUtilities), Member = "get_cursorIndex", ReturnType = typeof(int))]
	[Calls(Type = typeof(TextSelectingUtilities), Member = "FindEndOfPreviousWord", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = "UnityEngine.TextCore.Text.TextHandle", Member = "GetCorrespondingStringIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(string), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(TextEditingUtilities), Member = "DeleteSelection", ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 2)]
	public bool DeleteWordBack() { }

	[CalledBy(Type = typeof(TextEditingUtilities), Member = "PerformOperation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextEditOp)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TextSelectingUtilities), Member = "get_hasSelection", ReturnType = typeof(bool))]
	[Calls(Type = typeof(TextSelectingUtilities), Member = "get_cursorIndex", ReturnType = typeof(int))]
	[Calls(Type = typeof(TextSelectingUtilities), Member = "FindStartOfNextWord", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = "UnityEngine.TextCore.Text.TextHandle", Member = "GetCorrespondingStringIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(string), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(TextEditingUtilities), Member = "DeleteSelection", ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 2)]
	public bool DeleteWordForward() { }

	[CalledBy(Type = "UnityEngine.UIElements.KeyboardTextEditorEventHandler", Member = "UpdateLabel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TextSelectingUtilities), Member = "get_cursorIndexNoValidation", ReturnType = typeof(int))]
	[Calls(Type = typeof(GUIUtility), Member = "get_compositionString", ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public void EnableCursorPreviewState() { }

	[CalledBy(Type = "UnityEngine.UIElements.KeyboardTextEditorEventHandler", Member = "UpdateLabel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GUIUtility), Member = "get_compositionString", ReturnType = typeof(string))]
	[Calls(Type = typeof(TextSelectingUtilities), Member = "get_cursorIndex", ReturnType = typeof(int))]
	[Calls(Type = "UnityEngine.TextCore.Text.TextHandle", Member = "GetCorrespondingStringIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Insert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public string GeneratePreviewString(bool richText) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TextSelectingUtilities), Member = "get_cursorIndex", ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 1)]
	private int get_cursorIndex() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TextSelectingUtilities), Member = "get_cursorIndexNoValidation", ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 1)]
	private int get_cursorIndexNoValidation() { }

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TextSelectingUtilities), Member = "get_hasSelection", ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	private bool get_hasSelection() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TextSelectingUtilities), Member = "get_selectIndex", ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 1)]
	private int get_selectIndex() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TextSelectingUtilities), Member = "get_cursorIndex", ReturnType = typeof(int))]
	[Calls(Type = "UnityEngine.TextCore.Text.TextHandle", Member = "GetCorrespondingStringIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 1)]
	internal int get_stringCursorIndex() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TextSelectingUtilities), Member = "get_selectIndex", ReturnType = typeof(int))]
	[Calls(Type = "UnityEngine.TextCore.Text.TextHandle", Member = "GetCorrespondingStringIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 1)]
	internal int get_stringSelectIndex() { }

	[CallerCount(Count = 38)]
	[DeduplicatedMethod]
	public string get_text() { }

	[CalledBy(Type = "UnityEngine.UIElements.KeyboardTextEditorEventHandler", Member = "OnKeyDown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.KeyDownEvent"}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TextEditingUtilities), Member = "InitKeyActions", ReturnType = typeof(void))]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Dictionary`2), Member = "ContainsKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Dictionary`2), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = "TValue")]
	[Calls(Type = typeof(TextEditingUtilities), Member = "PerformOperation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextEditOp)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 11)]
	[VisibleToOtherModules]
	internal bool HandleKeyEvent(Event e) { }

	[CalledBy(Type = typeof(TextEditingUtilities), Member = "HandleKeyEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(Event), Member = "KeyboardEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Event))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Int32Enum>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), "System.Int32Enum"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TextEditingUtilities), Member = "MapKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(TextEditOp)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsInvalidInstructions]
	private void InitKeyActions() { }

	[CalledBy(Type = "UnityEngine.UIElements.KeyboardTextEditorEventHandler", Member = "OnKeyDown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.KeyDownEvent"}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "CreateString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(TextEditingUtilities), Member = "ReplaceSelection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 2)]
	public bool Insert(char c) { }

	[CalledBy(Type = typeof(TextEditingUtilities), Member = "InitKeyActions", ReturnType = typeof(void))]
	[CallerCount(Count = 42)]
	[Calls(Type = typeof(Event), Member = "KeyboardEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Event))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Int32Enum>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), "System.Int32Enum"}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private static void MapKey(string key, TextEditOp action) { }

	[CalledBy(Type = "UnityEngine.UIElements.TextEditingManipulator", Member = "HandleEventBubbleUp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.EventBase"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.TextEditingManipulator", Member = "OnFocusOutEvent", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(TextSelectingUtilities), Member = "set_revealCursor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TextSelectingUtilities), Member = "SelectNone", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
	internal void OnBlur() { }

	[CalledBy(Type = "UnityEngine.UIElements.KeyboardTextEditorEventHandler", Member = "OnExecuteCommandEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.ExecuteCommandEvent"}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GUIUtility), Member = "get_systemCopyBuffer", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "Replace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Replace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(char)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(TextEditingUtilities), Member = "ReplaceSelection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public bool Paste() { }

	[CalledBy(Type = typeof(TextEditingUtilities), Member = "HandleKeyEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TextSelectingUtilities), Member = "MoveParagraphBackward", ReturnType = typeof(void))]
	[Calls(Type = typeof(TextEditingUtilities), Member = "Delete", ReturnType = typeof(bool))]
	[Calls(Type = typeof(TextEditingUtilities), Member = "Backspace", ReturnType = typeof(bool))]
	[Calls(Type = typeof(TextEditingUtilities), Member = "DeleteWordBack", ReturnType = typeof(bool))]
	[Calls(Type = typeof(TextEditingUtilities), Member = "DeleteWordForward", ReturnType = typeof(bool))]
	[Calls(Type = typeof(TextEditingUtilities), Member = "DeleteLineBack", ReturnType = typeof(bool))]
	[Calls(Type = typeof(TextSelectingUtilities), Member = "Copy", ReturnType = typeof(void))]
	[Calls(Type = typeof(TextEditingUtilities), Member = "DeleteSelection", ReturnType = typeof(bool))]
	[Calls(Type = typeof(GUIUtility), Member = "get_systemCopyBuffer", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "Replace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Replace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(char)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Enum), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(TextSelectingUtilities), Member = "MoveToEndOfPreviousWord", ReturnType = typeof(void))]
	[Calls(Type = typeof(TextSelectingUtilities), Member = "MoveToStartOfNextWord", ReturnType = typeof(void))]
	[Calls(Type = typeof(TextSelectingUtilities), Member = "MoveParagraphForward", ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(TextSelectingUtilities), Member = "MoveWordRight", ReturnType = typeof(void))]
	[Calls(Type = typeof(TextSelectingUtilities), Member = "MoveWordLeft", ReturnType = typeof(void))]
	[Calls(Type = typeof(TextSelectingUtilities), Member = "MoveGraphicalLineEnd", ReturnType = typeof(void))]
	[Calls(Type = typeof(TextSelectingUtilities), Member = "MoveGraphicalLineStart", ReturnType = typeof(void))]
	[Calls(Type = typeof(TextSelectingUtilities), Member = "MoveTextEnd", ReturnType = typeof(void))]
	[Calls(Type = typeof(TextSelectingUtilities), Member = "MoveTextStart", ReturnType = typeof(void))]
	[Calls(Type = typeof(TextSelectingUtilities), Member = "MoveLineEnd", ReturnType = typeof(void))]
	[Calls(Type = typeof(TextSelectingUtilities), Member = "MoveLineStart", ReturnType = typeof(void))]
	[Calls(Type = typeof(TextSelectingUtilities), Member = "MoveDown", ReturnType = typeof(void))]
	[Calls(Type = typeof(TextSelectingUtilities), Member = "MoveUp", ReturnType = typeof(void))]
	[Calls(Type = typeof(TextSelectingUtilities), Member = "MoveRight", ReturnType = typeof(void))]
	[Calls(Type = typeof(TextSelectingUtilities), Member = "MoveLeft", ReturnType = typeof(void))]
	[Calls(Type = typeof(TextSelectingUtilities), Member = "set_revealCursor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsInvalidInstructions]
	private void PerformOperation(TextEditOp operation) { }

	[CalledBy(Type = "UnityEngine.UIElements.TextEditingManipulator", Member = "get_keyboardCanBeUsed", ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TouchScreenKeyboard), Member = "get_isSupported", ReturnType = typeof(bool))]
	[Calls(Type = typeof(TouchScreenKeyboard), Member = "get_isInPlaceEditingAllowed", ReturnType = typeof(bool))]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
	internal bool PhysicalKeyboardCanBeUsed() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Replace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Replace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(char)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 1)]
	private static string ReplaceNewlinesWithSpaces(string value) { }

	[CalledBy(Type = typeof(TextEditingUtilities), Member = "UpdateImeState", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TextEditingUtilities), Member = "Insert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TextEditingUtilities), Member = "Paste", ReturnType = typeof(bool))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(TextEditingUtilities), Member = "DeleteSelection", ReturnType = typeof(bool))]
	[Calls(Type = typeof(TextSelectingUtilities), Member = "get_cursorIndex", ReturnType = typeof(int))]
	[Calls(Type = "UnityEngine.TextCore.Text.TextHandle", Member = "GetCorrespondingStringIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(string), Member = "Insert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(StringInfo), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StringInfo), Member = "get_LengthInTextElements", ReturnType = typeof(int))]
	[Calls(Type = typeof(TextSelectingUtilities), Member = "get_cursorIndexNoValidation", ReturnType = typeof(int))]
	[Calls(Type = typeof(TextSelectingUtilities), Member = "ClearCursorPos", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 2)]
	public void ReplaceSelection(string replace) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public void RestoreCursorState() { }

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	private void set_cursorIndex(int value) { }

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	private void set_cursorIndexNoValidation(int value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TextSelectingUtilities), Member = "set_revealCursor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	internal void set_revealCursor(bool value) { }

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	private void set_selectIndex(int value) { }

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	private void set_selectIndexNoValidation(int value) { }

	[CalledBy(Type = "UnityEngine.UIElements.KeyboardTextEditorEventHandler", Member = "UpdateLabel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.TouchScreenTextEditorEventHandler", Member = "DoPollTouchScreenKeyboard", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.TextElement", Member = "UnityEngine.UIElements.INotifyValueChanged<System.String>.SetValueWithoutNotify", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public void set_text(string value) { }

	[CalledBy(Type = "UnityEngine.UIElements.KeyboardTextEditorEventHandler", Member = "UpdateLabel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TextSelectingUtilities), Member = "get_cursorIndex", ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public void SetImeWindowPosition(Vector2 worldPosition) { }

	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	internal void SetTextWithoutNotify(string value) { }

	[CalledBy(Type = "UnityEngine.UIElements.KeyboardTextEditorEventHandler", Member = "UpdateLabel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	public bool ShouldUpdateImeWindowPosition() { }

	[CalledBy(Type = "UnityEngine.UIElements.TouchScreenTextEditorEventHandler", Member = "DoPollTouchScreenKeyboard", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.TouchScreenTextEditorEventHandler", Member = "HandleEventBubbleUp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.EventBase"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.TextEditingManipulator", Member = "get_touchScreenCanBeUsed", ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.UIElements.TextElement", Member = "EditionHandleEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.EventBase"}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Application), Member = "get_platform", ReturnType = typeof(RuntimePlatform))]
	[Calls(Type = typeof(TouchScreenKeyboard), Member = "get_isSupported", ReturnType = typeof(bool))]
	[Calls(Type = typeof(TouchScreenKeyboard), Member = "get_isInPlaceEditingAllowed", ReturnType = typeof(bool))]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
	internal bool TouchScreenKeyboardCanBeUsed() { }

	[CalledBy(Type = "UnityEngine.UIElements.KeyboardTextEditorEventHandler", Member = "HandleEventBubbleUp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.EventBase"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.KeyboardTextEditorEventHandler", Member = "OnIMEInput", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.IMEEvent"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.KeyboardTextEditorEventHandler", Member = "OnKeyDown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.KeyDownEvent"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.KeyboardTextEditorEventHandler", Member = "UpdateLabel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(GUIUtility), Member = "get_compositionString", ReturnType = typeof(string))]
	[Calls(Type = typeof(TextEditingUtilities), Member = "ReplaceSelection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public bool UpdateImeState() { }

}

