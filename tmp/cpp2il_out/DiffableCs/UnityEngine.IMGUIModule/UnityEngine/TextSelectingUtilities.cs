namespace UnityEngine;

[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule", "UnityEditor.UIBuilderModule"})]
internal class TextSelectingUtilities
{
	private enum CharacterType
	{
		LetterLike = 0,
		Symbol = 1,
		Symbol2 = 2,
		WhiteSpace = 3,
		NewLine = 4,
	}

	private enum Direction
	{
		Forward = 0,
		Backward = 1,
	}

	private const int kMoveDownHeight = 5; //Field offset: 0x0
	private static Dictionary<Event, TextSelectOp> s_KeySelectOps; //Field offset: 0x0
	private const char kNewLineChar = '\uA'; //Field offset: 0x0
	public DblClickSnapping dblClickSnap; //Field offset: 0x10
	public int iAltCursorPos; //Field offset: 0x14
	public bool hasHorizontalCursorPos; //Field offset: 0x18
	private bool m_bJustSelected; //Field offset: 0x19
	private bool m_MouseDragSelectsWholeWords; //Field offset: 0x1A
	private int m_DblClickInitPosStart; //Field offset: 0x1C
	private int m_DblClickInitPosEnd; //Field offset: 0x20
	public TextHandle textHandle; //Field offset: 0x28
	private bool m_RevealCursor; //Field offset: 0x30
	private int m_CursorIndex; //Field offset: 0x34
	internal int m_SelectIndex; //Field offset: 0x38
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
	internal Action OnCursorIndexChange; //Field offset: 0x40
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
	internal Action OnSelectIndexChange; //Field offset: 0x48
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
	internal Action OnRevealCursorChange; //Field offset: 0x50

	private int characterCount
	{
		[CallerCount(Count = 213)]
		[Calls(Type = "UnityEngine.TextCore.Text.TextHandle", Member = "get_characterCount", ReturnType = typeof(int))]
		[Calls(Type = "UnityEngine.TextCore.Text.TextHandle", Member = "get_textInfo", ReturnType = "UnityEngine.TextCore.Text.TextInfo")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		private get { } //Length: 201
	}

	public int cursorIndex
	{
		[CallerCount(Count = 57)]
		[Calls(Type = typeof(TextSelectingUtilities), Member = "get_characterCount", ReturnType = typeof(int))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 97
		[CallerCount(Count = 21)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		 set { } //Length: 37
	}

	internal int cursorIndexNoValidation
	{
		[CalledBy(Type = typeof(TextEditingUtilities), Member = "get_cursorIndexNoValidation", ReturnType = typeof(int))]
		[CalledBy(Type = typeof(TextEditingUtilities), Member = "EnableCursorPreviewState", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TextEditingUtilities), Member = "ReplaceSelection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		internal get { } //Length: 6
		[CallerCount(Count = 21)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		internal set { } //Length: 37
	}

	public bool hasSelection
	{
		[CalledBy(Type = typeof(TextEditingUtilities), Member = "DeleteLineBack", ReturnType = typeof(bool))]
		[CalledBy(Type = "UnityEngine.UIElements.TextSelectingManipulator", Member = "OnSelectIndexChange", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UIElements.TextSelectingManipulator", Member = "OnCursorIndexChange", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UIElements.TextSelectingManipulator", Member = "HasSelection", ReturnType = typeof(bool))]
		[CalledBy(Type = "UnityEngine.UIElements.TextSelectingManipulator", Member = "HandleEventBubbleUp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.EventBase"}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UIElements.TextSelectingManipulator", Member = "OnPointerMoveEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.PointerMoveEvent"}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UIElements.TextSelectingManipulator", Member = "OnValidateCommandEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.ValidateCommandEvent"}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TextEditingUtilities), Member = "get_hasSelection", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(TextEditingUtilities), Member = "DeleteWordBack", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(TextEditingUtilities), Member = "DeleteWordForward", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(TextEditingUtilities), Member = "Delete", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(TextEditingUtilities), Member = "Backspace", ReturnType = typeof(bool))]
		[CallerCount(Count = 12)]
		[Calls(Type = typeof(TextSelectingUtilities), Member = "get_characterCount", ReturnType = typeof(int))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 173
	}

	private int m_CharacterCount
	{
		[CallerCount(Count = 0)]
		[Calls(Type = "UnityEngine.TextCore.Text.TextHandle", Member = "get_characterCount", ReturnType = typeof(int))]
		[CallsUnknownMethods(Count = 1)]
		private get { } //Length: 29
	}

	private TextElementInfo[] m_TextElementInfos
	{
		[CallerCount(Count = 0)]
		[Calls(Type = "UnityEngine.TextCore.Text.TextHandle", Member = "get_textInfo", ReturnType = "UnityEngine.TextCore.Text.TextInfo")]
		[CallsUnknownMethods(Count = 1)]
		private get { } //Length: 39
	}

	public bool revealCursor
	{
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CalledBy(Type = typeof(TextEditingUtilities), Member = "set_revealCursor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TextEditingUtilities), Member = "PerformOperation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextEditOp)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TextEditingUtilities), Member = "OnBlur", ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[CallsDeduplicatedMethods(Count = 1)]
		 set { } //Length: 37
	}

	public string selectedText
	{
		[CalledBy(Type = typeof(TextSelectingUtilities), Member = "PerformOperation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextSelectOp)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(TextSelectingUtilities), Member = "Copy", ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(TextSelectingUtilities), Member = "get_characterCount", ReturnType = typeof(int))]
		[Calls(Type = typeof(TextSelectingUtilities), Member = "get_selectIndex", ReturnType = typeof(int))]
		[Calls(Type = typeof(TextSelectingUtilities), Member = "get_cursorIndex", ReturnType = typeof(int))]
		[Calls(Type = "UnityEngine.TextCore.Text.TextHandle", Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
		[CallsDeduplicatedMethods(Count = 4)]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 459
	}

	public int selectIndex
	{
		[CalledBy(Type = "UnityEngine.UIElements.TextSelectingManipulator", Member = "get_selectIndex", ReturnType = typeof(int))]
		[CalledBy(Type = typeof(TextSelectingUtilities), Member = "SelectToPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TextSelectingUtilities), Member = "MoveParagraphBackward", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TextSelectingUtilities), Member = "MoveParagraphForward", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TextSelectingUtilities), Member = "MoveLeft", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TextSelectingUtilities), Member = "MoveRight", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TextSelectingUtilities), Member = "SelectCurrentParagraph", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TextSelectingUtilities), Member = "SelectParagraphBackward", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TextSelectingUtilities), Member = "SelectWordLeft", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TextSelectingUtilities), Member = "SelectParagraphForward", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TextSelectingUtilities), Member = "SelectRight", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TextSelectingUtilities), Member = "SelectLeft", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TextSelectingUtilities), Member = "get_selectedText", ReturnType = typeof(string))]
		[CalledBy(Type = typeof(TextEditingUtilities), Member = "DeleteSelection", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(TextEditingUtilities), Member = "Backspace", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(TextEditingUtilities), Member = "get_selectIndex", ReturnType = typeof(int))]
		[CalledBy(Type = typeof(TextEditingUtilities), Member = "get_stringSelectIndex", ReturnType = typeof(int))]
		[CalledBy(Type = "UnityEngine.UIElements.TextSelectingManipulator", Member = "OnPointerDownEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.PointerDownEvent"}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TextSelectingUtilities), Member = "SelectWordRight", ReturnType = typeof(void))]
		[CallerCount(Count = 29)]
		[Calls(Type = typeof(TextSelectingUtilities), Member = "get_characterCount", ReturnType = typeof(int))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 97
		[CallerCount(Count = 21)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		 set { } //Length: 37
	}

	internal int selectIndexNoValidation
	{
		[CallerCount(Count = 21)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		internal set { } //Length: 37
	}

	[CalledBy(Type = "UnityEngine.UIElements.TextSelectingManipulator", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.TextElement"}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public TextSelectingUtilities(TextHandle textHandle) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TextSelectingUtilities), Member = "get_characterCount", ReturnType = typeof(int))]
	private int ClampTextIndex(int index) { }

	[CalledBy(Type = typeof(TextSelectingUtilities), Member = "SelectCurrentWord", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextSelectingUtilities), Member = "MoveWordRight", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextSelectingUtilities), Member = "SelectToPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextSelectingUtilities), Member = "FindNextSeperator", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(TextSelectingUtilities), Member = "FindPrevSeperator", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(TextSelectingUtilities), Member = "FindStartOfNextWord", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(TextSelectingUtilities), Member = "FindEndOfPreviousWord", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(TextSelectingUtilities), Member = "FindEndOfClassification", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Direction)}, ReturnType = typeof(int))]
	[CallerCount(Count = 33)]
	[Calls(Type = "UnityEngine.TextCore.Text.TextHandle", Member = "get_textInfo", ReturnType = "UnityEngine.TextCore.Text.TextInfo")]
	[Calls(Type = typeof(char), Member = "IsWhiteSpace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(char), Member = "IsLetterOrDigit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 2)]
	private CharacterType ClassifyChar(int index) { }

	[CalledBy(Type = typeof(TextEditingUtilities), Member = "Backspace", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TextEditingUtilities), Member = "DeleteSelection", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TextEditingUtilities), Member = "ReplaceSelection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	public void ClearCursorPos() { }

	[CalledBy(Type = "UnityEngine.UIElements.TextSelectingManipulator", Member = "HandleEventBubbleUp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.EventBase"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.TextSelectingManipulator", Member = "OnExecuteCommandEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.ExecuteCommandEvent"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextEditingUtilities), Member = "PerformOperation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextEditOp)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextEditingUtilities), Member = "Cut", ReturnType = typeof(bool))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(TextSelectingUtilities), Member = "get_characterCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(TextSelectingUtilities), Member = "get_selectedText", ReturnType = typeof(string))]
	[Calls(Type = typeof(GUIUtility), Member = "set_systemCopyBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public void Copy() { }

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SemaphoreSlim), Member = "Release", ReturnType = typeof(int))]
	[Calls(Type = typeof(Math), Member = "ThrowAbsOverflow", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public void DblClickSnap(DblClickSnapping snapping) { }

	[CalledBy(Type = typeof(TextSelectingUtilities), Member = "PerformOperation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextSelectOp)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TextSelectingUtilities), Member = "get_characterCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(TextSelectingUtilities), Member = "GetGraphicalLineEnd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 1)]
	public void ExpandSelectGraphicalLineEnd() { }

	[CalledBy(Type = typeof(TextSelectingUtilities), Member = "PerformOperation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextSelectOp)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TextSelectingUtilities), Member = "get_characterCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(TextSelectingUtilities), Member = "GetGraphicalLineStart", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 1)]
	public void ExpandSelectGraphicalLineStart() { }

	[CalledBy(Type = typeof(TextSelectingUtilities), Member = "SelectToPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TextSelectingUtilities), Member = "get_characterCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(TextSelectingUtilities), Member = "ClassifyChar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(CharacterType))]
	[Calls(Type = "UnityEngine.TextCore.Text.TextHandle", Member = "NextCodePointIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = "UnityEngine.TextCore.Text.TextHandle", Member = "PreviousCodePointIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(TextSelectingUtilities), Member = "NextCodePointIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	private int FindEndOfClassification(int p, Direction dir) { }

	[CalledBy(Type = typeof(TextEditingUtilities), Member = "DeleteWordBack", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TextSelectingUtilities), Member = "PerformOperation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextSelectOp)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TextSelectingUtilities), Member = "SelectToEndOfPreviousWord", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextSelectingUtilities), Member = "MoveToEndOfPreviousWord", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextSelectingUtilities), Member = "MoveWordLeft", ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = "UnityEngine.TextCore.Text.TextHandle", Member = "PreviousCodePointIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = "UnityEngine.TextCore.Text.TextHandle", Member = "get_textInfo", ReturnType = "UnityEngine.TextCore.Text.TextInfo")]
	[Calls(Type = typeof(TextSelectingUtilities), Member = "ClassifyChar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(CharacterType))]
	[Calls(Type = "UnityEngine.TextCore.Text.TextHandle", Member = "GetEndOfPreviousWord", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 2)]
	public int FindEndOfPreviousWord(int p) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TextSelectingUtilities), Member = "get_characterCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(TextSelectingUtilities), Member = "ClassifyChar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(CharacterType))]
	[Calls(Type = "UnityEngine.TextCore.Text.TextHandle", Member = "NextCodePointIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	private int FindNextSeperator(int startPos) { }

	[CalledBy(Type = typeof(TextSelectingUtilities), Member = "MoveWordLeft", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = "UnityEngine.TextCore.Text.TextHandle", Member = "PreviousCodePointIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(TextSelectingUtilities), Member = "ClassifyChar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(CharacterType))]
	[Calls(Type = typeof(TextSelectingUtilities), Member = "get_characterCount", ReturnType = typeof(int))]
	[Calls(Type = "UnityEngine.TextCore.Text.TextHandle", Member = "NextCodePointIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	private int FindPrevSeperator(int startPos) { }

	[CalledBy(Type = typeof(TextEditingUtilities), Member = "DeleteWordForward", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TextSelectingUtilities), Member = "PerformOperation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextSelectOp)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TextSelectingUtilities), Member = "SelectToStartOfNextWord", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextSelectingUtilities), Member = "MoveWordRight", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextSelectingUtilities), Member = "MoveToStartOfNextWord", ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(TextSelectingUtilities), Member = "get_characterCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(TextSelectingUtilities), Member = "ClassifyChar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(CharacterType))]
	[Calls(Type = "UnityEngine.TextCore.Text.TextHandle", Member = "get_textInfo", ReturnType = "UnityEngine.TextCore.Text.TextInfo")]
	[Calls(Type = typeof(TextSelectingUtilities), Member = "NextCodePointIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = "UnityEngine.TextCore.Text.TextHandle", Member = "NextCodePointIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = "UnityEngine.TextCore.Text.TextHandle", Member = "GetStartOfNextWord", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	public int FindStartOfNextWord(int p) { }

	[CallerCount(Count = 213)]
	[Calls(Type = "UnityEngine.TextCore.Text.TextHandle", Member = "get_characterCount", ReturnType = typeof(int))]
	[Calls(Type = "UnityEngine.TextCore.Text.TextHandle", Member = "get_textInfo", ReturnType = "UnityEngine.TextCore.Text.TextInfo")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private int get_characterCount() { }

	[CallerCount(Count = 57)]
	[Calls(Type = typeof(TextSelectingUtilities), Member = "get_characterCount", ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public int get_cursorIndex() { }

	[CalledBy(Type = typeof(TextEditingUtilities), Member = "get_cursorIndexNoValidation", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(TextEditingUtilities), Member = "EnableCursorPreviewState", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextEditingUtilities), Member = "ReplaceSelection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	internal int get_cursorIndexNoValidation() { }

	[CalledBy(Type = typeof(TextEditingUtilities), Member = "DeleteLineBack", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TextEditingUtilities), Member = "Backspace", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TextEditingUtilities), Member = "Delete", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TextEditingUtilities), Member = "DeleteWordForward", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TextEditingUtilities), Member = "get_hasSelection", ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.UIElements.TextSelectingManipulator", Member = "OnValidateCommandEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.ValidateCommandEvent"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextEditingUtilities), Member = "DeleteWordBack", ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.UIElements.TextSelectingManipulator", Member = "HandleEventBubbleUp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.EventBase"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.TextSelectingManipulator", Member = "HasSelection", ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.UIElements.TextSelectingManipulator", Member = "OnCursorIndexChange", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.TextSelectingManipulator", Member = "OnSelectIndexChange", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.TextSelectingManipulator", Member = "OnPointerMoveEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.PointerMoveEvent"}, ReturnType = typeof(void))]
	[CallerCount(Count = 12)]
	[Calls(Type = typeof(TextSelectingUtilities), Member = "get_characterCount", ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public bool get_hasSelection() { }

	[CallerCount(Count = 0)]
	[Calls(Type = "UnityEngine.TextCore.Text.TextHandle", Member = "get_characterCount", ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 1)]
	private int get_m_CharacterCount() { }

	[CallerCount(Count = 0)]
	[Calls(Type = "UnityEngine.TextCore.Text.TextHandle", Member = "get_textInfo", ReturnType = "UnityEngine.TextCore.Text.TextInfo")]
	[CallsUnknownMethods(Count = 1)]
	private TextElementInfo[] get_m_TextElementInfos() { }

	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	public bool get_revealCursor() { }

	[CalledBy(Type = typeof(TextSelectingUtilities), Member = "PerformOperation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextSelectOp)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TextSelectingUtilities), Member = "Copy", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(TextSelectingUtilities), Member = "get_characterCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(TextSelectingUtilities), Member = "get_selectIndex", ReturnType = typeof(int))]
	[Calls(Type = typeof(TextSelectingUtilities), Member = "get_cursorIndex", ReturnType = typeof(int))]
	[Calls(Type = "UnityEngine.TextCore.Text.TextHandle", Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	public string get_selectedText() { }

	[CalledBy(Type = "UnityEngine.UIElements.TextSelectingManipulator", Member = "get_selectIndex", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(TextSelectingUtilities), Member = "SelectWordRight", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.TextSelectingManipulator", Member = "OnPointerDownEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.PointerDownEvent"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextEditingUtilities), Member = "get_stringSelectIndex", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(TextEditingUtilities), Member = "get_selectIndex", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(TextEditingUtilities), Member = "Backspace", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TextEditingUtilities), Member = "DeleteSelection", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TextSelectingUtilities), Member = "get_selectedText", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(TextSelectingUtilities), Member = "SelectRight", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextSelectingUtilities), Member = "SelectLeft", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextSelectingUtilities), Member = "SelectWordLeft", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextSelectingUtilities), Member = "SelectParagraphBackward", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextSelectingUtilities), Member = "SelectCurrentParagraph", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextSelectingUtilities), Member = "MoveRight", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextSelectingUtilities), Member = "MoveLeft", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextSelectingUtilities), Member = "MoveParagraphForward", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextSelectingUtilities), Member = "MoveParagraphBackward", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextSelectingUtilities), Member = "SelectToPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextSelectingUtilities), Member = "SelectParagraphForward", ReturnType = typeof(void))]
	[CallerCount(Count = 29)]
	[Calls(Type = typeof(TextSelectingUtilities), Member = "get_characterCount", ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public int get_selectIndex() { }

	[CalledBy(Type = typeof(TextSelectingUtilities), Member = "PerformOperation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextSelectOp)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TextSelectingUtilities), Member = "SelectGraphicalLineEnd", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextSelectingUtilities), Member = "MoveGraphicalLineEnd", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextSelectingUtilities), Member = "ExpandSelectGraphicalLineEnd", ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = "UnityEngine.TextCore.Text.TextHandle", Member = "GetCursorPositionFromStringIndexUsingLineHeight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool), typeof(bool)}, ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(GUIUtility), Member = "get_pixelsPerPoint", ReturnType = typeof(float))]
	[Calls(Type = "UnityEngine.TextCore.Text.TextHandle", Member = "GetCursorIndexFromPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(bool)}, ReturnType = typeof(int))]
	[Calls(Type = "UnityEngine.TextCore.Text.TextHandle", Member = "GetLastCharacterIndexOnLine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private int GetGraphicalLineEnd(int p) { }

	[CalledBy(Type = typeof(TextSelectingUtilities), Member = "PerformOperation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextSelectOp)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TextSelectingUtilities), Member = "SelectGraphicalLineStart", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextSelectingUtilities), Member = "MoveGraphicalLineStart", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextSelectingUtilities), Member = "ExpandSelectGraphicalLineStart", ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = "UnityEngine.TextCore.Text.TextHandle", Member = "GetCursorPositionFromStringIndexUsingLineHeight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool), typeof(bool)}, ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(GUIUtility), Member = "get_pixelsPerPoint", ReturnType = typeof(float))]
	[Calls(Type = "UnityEngine.TextCore.Text.TextHandle", Member = "GetCursorIndexFromPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(bool)}, ReturnType = typeof(int))]
	[Calls(Type = "UnityEngine.TextCore.Text.TextHandle", Member = "GetFirstCharacterIndexOnLine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private int GetGraphicalLineStart(int p) { }

	[CalledBy(Type = "UnityEngine.UIElements.TextSelectingManipulator", Member = "HandleEventBubbleUp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.EventBase"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.TextSelectingManipulator", Member = "OnKeyDown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.KeyDownEvent"}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(TextSelectingUtilities), Member = "InitKeyActions", ReturnType = typeof(void))]
	[Calls(Type = typeof(Event), Member = "get_modifiers", ReturnType = typeof(EventModifiers))]
	[Calls(Type = typeof(Event), Member = "set_modifiers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventModifiers)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Dictionary`2), Member = "ContainsKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Dictionary`2), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = "TValue")]
	[Calls(Type = typeof(TextSelectingUtilities), Member = "PerformOperation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextSelectOp)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
	internal bool HandleKeyEvent(Event e) { }

	[CalledBy(Type = typeof(TextSelectingUtilities), Member = "SelectToPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = "UnityEngine.TextCore.Text.TextHandle", Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(TextSelectingUtilities), Member = "get_characterCount", ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 1)]
	private int IndexOfEndOfLine(int startIndex) { }

	[CalledBy(Type = typeof(TextSelectingUtilities), Member = "HandleKeyEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(Event), Member = "KeyboardEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Event))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Int32Enum>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), "System.Int32Enum"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TextSelectingUtilities), Member = "MapKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(TextSelectOp)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsInvalidInstructions]
	private void InitKeyActions() { }

	[CalledBy(Type = typeof(TextSelectingUtilities), Member = "InitKeyActions", ReturnType = typeof(void))]
	[CallerCount(Count = 26)]
	[Calls(Type = typeof(Event), Member = "KeyboardEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Event))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Int32Enum>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), "System.Int32Enum"}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private static void MapKey(string key, TextSelectOp action) { }

	[CalledBy(Type = "UnityEngine.UIElements.TextSelectingManipulator", Member = "OnPointerDownEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.PointerDownEvent"}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(TextSelectingUtilities), Member = "get_characterCount", ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 1)]
	public void MouseDragSelectsWholeWords(bool on) { }

	[CalledBy(Type = "UnityEngine.UIElements.TextSelectingManipulator", Member = "OnPointerDownEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.PointerDownEvent"}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = "UnityEngine.TextCore.Text.TextHandle", Member = "GetCursorIndexFromPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(bool)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(TextSelectingUtilities), Member = "get_characterCount", ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	protected private void MoveCursorToPosition_Internal(Vector2 cursorPosition, bool shift) { }

	[CalledBy(Type = typeof(TextEditingUtilities), Member = "PerformOperation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextEditOp)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TextSelectingUtilities), Member = "get_characterCount", ReturnType = typeof(int))]
	[Calls(Type = "UnityEngine.TextCore.Text.TextHandle", Member = "LineDownCharacterPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallsUnknownMethods(Count = 1)]
	public void MoveDown() { }

	[CalledBy(Type = typeof(TextEditingUtilities), Member = "PerformOperation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextEditOp)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TextSelectingUtilities), Member = "get_characterCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(TextSelectingUtilities), Member = "GetGraphicalLineEnd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 1)]
	public void MoveGraphicalLineEnd() { }

	[CalledBy(Type = typeof(TextEditingUtilities), Member = "PerformOperation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextEditOp)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TextSelectingUtilities), Member = "get_characterCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(TextSelectingUtilities), Member = "GetGraphicalLineStart", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 1)]
	public void MoveGraphicalLineStart() { }

	[CalledBy(Type = typeof(TextEditingUtilities), Member = "PerformOperation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextEditOp)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextSelectingUtilities), Member = "MoveToEndOfPreviousWord", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(TextSelectingUtilities), Member = "get_characterCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(TextSelectingUtilities), Member = "get_selectIndex", ReturnType = typeof(int))]
	[Calls(Type = typeof(TextSelectingUtilities), Member = "get_cursorIndex", ReturnType = typeof(int))]
	[Calls(Type = "UnityEngine.TextCore.Text.TextHandle", Member = "PreviousCodePointIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallsUnknownMethods(Count = 1)]
	public void MoveLeft() { }

	[CalledBy(Type = typeof(TextEditingUtilities), Member = "PerformOperation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextEditOp)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TextSelectingUtilities), Member = "get_characterCount", ReturnType = typeof(int))]
	[Calls(Type = "UnityEngine.TextCore.Text.TextHandle", Member = "get_textInfo", ReturnType = "UnityEngine.TextCore.Text.TextInfo")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 2)]
	public void MoveLineEnd() { }

	[CalledBy(Type = typeof(TextEditingUtilities), Member = "PerformOperation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextEditOp)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TextSelectingUtilities), Member = "get_characterCount", ReturnType = typeof(int))]
	[Calls(Type = "UnityEngine.TextCore.Text.TextHandle", Member = "get_textInfo", ReturnType = "UnityEngine.TextCore.Text.TextInfo")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 2)]
	public void MoveLineStart() { }

	[CalledBy(Type = typeof(TextEditingUtilities), Member = "PerformOperation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextEditOp)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TextSelectingUtilities), Member = "get_characterCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(TextSelectingUtilities), Member = "get_cursorIndex", ReturnType = typeof(int))]
	[Calls(Type = typeof(TextSelectingUtilities), Member = "get_selectIndex", ReturnType = typeof(int))]
	[Calls(Type = "UnityEngine.TextCore.Text.TextHandle", Member = "LastIndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = "UnityEngine.TextCore.Text.TextHandle", Member = "SelectToPreviousParagraph", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallsUnknownMethods(Count = 1)]
	public void MoveParagraphBackward() { }

	[CalledBy(Type = typeof(TextEditingUtilities), Member = "PerformOperation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextEditOp)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TextSelectingUtilities), Member = "get_characterCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(TextSelectingUtilities), Member = "get_cursorIndex", ReturnType = typeof(int))]
	[Calls(Type = typeof(TextSelectingUtilities), Member = "get_selectIndex", ReturnType = typeof(int))]
	[Calls(Type = "UnityEngine.TextCore.Text.TextHandle", Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = "UnityEngine.TextCore.Text.TextHandle", Member = "SelectToNextParagraph", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallsUnknownMethods(Count = 1)]
	public void MoveParagraphForward() { }

	[CalledBy(Type = typeof(TextEditingUtilities), Member = "PerformOperation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextEditOp)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextSelectingUtilities), Member = "MoveToStartOfNextWord", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(TextSelectingUtilities), Member = "get_characterCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(TextSelectingUtilities), Member = "get_cursorIndex", ReturnType = typeof(int))]
	[Calls(Type = typeof(TextSelectingUtilities), Member = "get_selectIndex", ReturnType = typeof(int))]
	[Calls(Type = "UnityEngine.TextCore.Text.TextHandle", Member = "NextCodePointIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallsUnknownMethods(Count = 1)]
	public void MoveRight() { }

	[CalledBy(Type = typeof(TextEditingUtilities), Member = "PerformOperation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextEditOp)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TextSelectingUtilities), Member = "get_characterCount", ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 2)]
	public void MoveTextEnd() { }

	[CalledBy(Type = typeof(TextEditingUtilities), Member = "PerformOperation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextEditOp)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	public void MoveTextStart() { }

	[CalledBy(Type = typeof(TextEditingUtilities), Member = "PerformOperation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextEditOp)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TextSelectingUtilities), Member = "get_characterCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(TextSelectingUtilities), Member = "FindEndOfPreviousWord", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(TextSelectingUtilities), Member = "MoveLeft", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 1)]
	public void MoveToEndOfPreviousWord() { }

	[CalledBy(Type = typeof(TextEditingUtilities), Member = "PerformOperation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextEditOp)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TextSelectingUtilities), Member = "get_characterCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(TextSelectingUtilities), Member = "FindStartOfNextWord", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(TextSelectingUtilities), Member = "MoveRight", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 1)]
	public void MoveToStartOfNextWord() { }

	[CalledBy(Type = typeof(TextEditingUtilities), Member = "PerformOperation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextEditOp)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TextSelectingUtilities), Member = "get_characterCount", ReturnType = typeof(int))]
	[Calls(Type = "UnityEngine.TextCore.Text.TextHandle", Member = "LineUpCharacterPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallsUnknownMethods(Count = 1)]
	public void MoveUp() { }

	[CalledBy(Type = typeof(TextEditingUtilities), Member = "PerformOperation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextEditOp)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextSelectingUtilities), Member = "SelectWordLeft", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(TextSelectingUtilities), Member = "get_characterCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(TextSelectingUtilities), Member = "FindPrevSeperator", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(TextSelectingUtilities), Member = "FindEndOfPreviousWord", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 11)]
	[CallsUnknownMethods(Count = 1)]
	public void MoveWordLeft() { }

	[CalledBy(Type = typeof(TextEditingUtilities), Member = "PerformOperation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextEditOp)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextSelectingUtilities), Member = "SelectWordRight", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(TextSelectingUtilities), Member = "get_characterCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(TextSelectingUtilities), Member = "ClassifyChar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(CharacterType))]
	[Calls(Type = "UnityEngine.TextCore.Text.TextHandle", Member = "NextCodePointIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(TextSelectingUtilities), Member = "FindStartOfNextWord", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 13)]
	[CallsUnknownMethods(Count = 1)]
	public void MoveWordRight() { }

	[CalledBy(Type = typeof(TextSelectingUtilities), Member = "SelectCurrentWord", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextSelectingUtilities), Member = "SelectToPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextSelectingUtilities), Member = "FindStartOfNextWord", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(TextSelectingUtilities), Member = "FindEndOfClassification", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Direction)}, ReturnType = typeof(int))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(TextSelectingUtilities), Member = "get_characterCount", ReturnType = typeof(int))]
	[Calls(Type = "UnityEngine.TextCore.Text.TextHandle", Member = "NextCodePointIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public int NextCodePointIndex(int index) { }

	[CalledBy(Type = "UnityEngine.UIElements.TextSelectingManipulator", Member = "HandleEventBubbleUp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.EventBase"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.TextSelectingManipulator", Member = "OnFocusEvent", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 3)]
	public void OnFocus(bool selectAll = true) { }

	[CalledBy(Type = typeof(TextSelectingUtilities), Member = "HandleKeyEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Enum), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(GUIUtility), Member = "set_systemCopyBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TextSelectingUtilities), Member = "get_selectedText", ReturnType = typeof(string))]
	[Calls(Type = typeof(TextSelectingUtilities), Member = "SelectParagraphForward", ReturnType = typeof(void))]
	[Calls(Type = typeof(TextSelectingUtilities), Member = "SelectParagraphBackward", ReturnType = typeof(void))]
	[Calls(Type = typeof(TextSelectingUtilities), Member = "FindStartOfNextWord", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(TextSelectingUtilities), Member = "FindEndOfPreviousWord", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(TextSelectingUtilities), Member = "SelectWordRight", ReturnType = typeof(void))]
	[Calls(Type = typeof(TextSelectingUtilities), Member = "SelectWordLeft", ReturnType = typeof(void))]
	[Calls(Type = typeof(TextSelectingUtilities), Member = "GetGraphicalLineEnd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(TextSelectingUtilities), Member = "GetGraphicalLineStart", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(TextSelectingUtilities), Member = "ExpandSelectGraphicalLineEnd", ReturnType = typeof(void))]
	[Calls(Type = typeof(TextSelectingUtilities), Member = "ExpandSelectGraphicalLineStart", ReturnType = typeof(void))]
	[Calls(Type = "UnityEngine.TextCore.Text.TextHandle", Member = "LineDownCharacterPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = "UnityEngine.TextCore.Text.TextHandle", Member = "LineUpCharacterPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(TextSelectingUtilities), Member = "get_characterCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(TextSelectingUtilities), Member = "SelectRight", ReturnType = typeof(void))]
	[Calls(Type = typeof(TextSelectingUtilities), Member = "SelectLeft", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 12)]
	[CallsUnknownMethods(Count = 2)]
	private bool PerformOperation(TextSelectOp operation) { }

	[CalledBy(Type = typeof(TextEditingUtilities), Member = "Backspace", ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = "UnityEngine.TextCore.Text.TextHandle", Member = "PreviousCodePointIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public int PreviousCodePointIndex(int index) { }

	[CalledBy(Type = "UnityEngine.UIElements.TextSelectingManipulator", Member = "HandleEventBubbleUp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.EventBase"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.TextSelectingManipulator", Member = "OnPointerUpEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.PointerUpEvent"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.TextSelectingManipulator", Member = "OnExecuteCommandEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.ExecuteCommandEvent"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.TextElement", Member = "UnityEngine.UIElements.ITextSelection.SelectAll", ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[CallsDeduplicatedMethods(Count = 2)]
	public void SelectAll() { }

	[CalledBy(Type = "UnityEngine.UIElements.TextSelectingManipulator", Member = "OnPointerDownEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.PointerDownEvent"}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TextSelectingUtilities), Member = "get_characterCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(TextSelectingUtilities), Member = "get_cursorIndex", ReturnType = typeof(int))]
	[Calls(Type = "UnityEngine.TextCore.Text.TextHandle", Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(TextSelectingUtilities), Member = "get_selectIndex", ReturnType = typeof(int))]
	[Calls(Type = "UnityEngine.TextCore.Text.TextHandle", Member = "LastIndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = "UnityEngine.TextCore.Text.TextHandle", Member = "SelectCurrentParagraph", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&), typeof(Int32&)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 1)]
	public void SelectCurrentParagraph() { }

	[CalledBy(Type = "UnityEngine.UIElements.TextSelectingManipulator", Member = "OnPointerDownEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.PointerDownEvent"}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TextSelectingUtilities), Member = "get_characterCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(TextSelectingUtilities), Member = "ClassifyChar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(CharacterType))]
	[Calls(Type = "UnityEngine.TextCore.Text.TextHandle", Member = "NextCodePointIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = "UnityEngine.TextCore.Text.TextHandle", Member = "PreviousCodePointIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(TextSelectingUtilities), Member = "NextCodePointIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = "UnityEngine.TextCore.Text.TextHandle", Member = "SelectCurrentWord", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Int32&), typeof(Int32&)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 17)]
	[CallsUnknownMethods(Count = 1)]
	public void SelectCurrentWord() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TextSelectingUtilities), Member = "get_characterCount", ReturnType = typeof(int))]
	[Calls(Type = "UnityEngine.TextCore.Text.TextHandle", Member = "LineDownCharacterPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public void SelectDown() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TextSelectingUtilities), Member = "get_characterCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(TextSelectingUtilities), Member = "GetGraphicalLineEnd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public void SelectGraphicalLineEnd() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TextSelectingUtilities), Member = "get_characterCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(TextSelectingUtilities), Member = "GetGraphicalLineStart", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public void SelectGraphicalLineStart() { }

	[CalledBy(Type = typeof(TextSelectingUtilities), Member = "PerformOperation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextSelectOp)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TextSelectingUtilities), Member = "get_characterCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(TextSelectingUtilities), Member = "get_cursorIndex", ReturnType = typeof(int))]
	[Calls(Type = typeof(TextSelectingUtilities), Member = "get_selectIndex", ReturnType = typeof(int))]
	[Calls(Type = "UnityEngine.TextCore.Text.TextHandle", Member = "PreviousCodePointIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 1)]
	public void SelectLeft() { }

	[CalledBy(Type = "UnityEngine.UIElements.TextElement", Member = "UnityEngine.UIElements.ITextSelection.SelectNone", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextEditingUtilities), Member = "OnBlur", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(TextSelectingUtilities), Member = "get_characterCount", ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public void SelectNone() { }

	[CalledBy(Type = typeof(TextSelectingUtilities), Member = "PerformOperation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextSelectOp)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TextSelectingUtilities), Member = "get_characterCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(TextSelectingUtilities), Member = "get_cursorIndex", ReturnType = typeof(int))]
	[Calls(Type = "UnityEngine.TextCore.Text.TextHandle", Member = "LastIndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(TextSelectingUtilities), Member = "get_selectIndex", ReturnType = typeof(int))]
	[Calls(Type = "UnityEngine.TextCore.Text.TextHandle", Member = "SelectToPreviousParagraph", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallsUnknownMethods(Count = 1)]
	public void SelectParagraphBackward() { }

	[CalledBy(Type = typeof(TextSelectingUtilities), Member = "PerformOperation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextSelectOp)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TextSelectingUtilities), Member = "get_characterCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(TextSelectingUtilities), Member = "get_cursorIndex", ReturnType = typeof(int))]
	[Calls(Type = "UnityEngine.TextCore.Text.TextHandle", Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(TextSelectingUtilities), Member = "get_selectIndex", ReturnType = typeof(int))]
	[Calls(Type = "UnityEngine.TextCore.Text.TextHandle", Member = "SelectToNextParagraph", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 1)]
	public void SelectParagraphForward() { }

	[CalledBy(Type = typeof(TextSelectingUtilities), Member = "PerformOperation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextSelectOp)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TextSelectingUtilities), Member = "get_characterCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(TextSelectingUtilities), Member = "get_cursorIndex", ReturnType = typeof(int))]
	[Calls(Type = typeof(TextSelectingUtilities), Member = "get_selectIndex", ReturnType = typeof(int))]
	[Calls(Type = "UnityEngine.TextCore.Text.TextHandle", Member = "NextCodePointIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 1)]
	public void SelectRight() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TextSelectingUtilities), Member = "get_characterCount", ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 1)]
	public void SelectTextEnd() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void SelectTextStart() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TextSelectingUtilities), Member = "get_characterCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(TextSelectingUtilities), Member = "FindEndOfPreviousWord", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public void SelectToEndOfPreviousWord() { }

	[CalledBy(Type = "UnityEngine.UIElements.TextSelectingManipulator", Member = "OnPointerMoveEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.PointerMoveEvent"}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TextSelectingUtilities), Member = "FindEndOfClassification", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Direction)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(TextSelectingUtilities), Member = "get_cursorIndex", ReturnType = typeof(int))]
	[Calls(Type = typeof(TextSelectingUtilities), Member = "get_selectIndex", ReturnType = typeof(int))]
	[Calls(Type = typeof(TextSelectingUtilities), Member = "NextCodePointIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = "UnityEngine.TextCore.Text.TextHandle", Member = "NextCodePointIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = "UnityEngine.TextCore.Text.TextHandle", Member = "PreviousCodePointIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(TextSelectingUtilities), Member = "ClassifyChar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(CharacterType))]
	[Calls(Type = "UnityEngine.TextCore.Text.TextHandle", Member = "SelectToStartOfParagraph", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&)}, ReturnType = typeof(void))]
	[Calls(Type = "UnityEngine.TextCore.Text.TextHandle", Member = "GetStartOfNextWord", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = "UnityEngine.TextCore.Text.TextHandle", Member = "SelectToEndOfParagraph", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&)}, ReturnType = typeof(void))]
	[Calls(Type = "UnityEngine.TextCore.Text.TextHandle", Member = "LastIndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(TextSelectingUtilities), Member = "IndexOfEndOfLine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = "UnityEngine.TextCore.Text.TextHandle", Member = "GetCursorIndexFromPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(bool)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(TextSelectingUtilities), Member = "get_characterCount", ReturnType = typeof(int))]
	[Calls(Type = "UnityEngine.TextCore.Text.TextHandle", Member = "GetEndOfPreviousWord", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 21)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public void SelectToPosition(Vector2 cursorPosition) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TextSelectingUtilities), Member = "get_characterCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(TextSelectingUtilities), Member = "FindStartOfNextWord", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public void SelectToStartOfNextWord() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TextSelectingUtilities), Member = "get_characterCount", ReturnType = typeof(int))]
	[Calls(Type = "UnityEngine.TextCore.Text.TextHandle", Member = "LineUpCharacterPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public void SelectUp() { }

	[CalledBy(Type = typeof(TextSelectingUtilities), Member = "PerformOperation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextSelectOp)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TextSelectingUtilities), Member = "get_characterCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(TextSelectingUtilities), Member = "MoveWordLeft", ReturnType = typeof(void))]
	[Calls(Type = typeof(TextSelectingUtilities), Member = "get_cursorIndex", ReturnType = typeof(int))]
	[Calls(Type = typeof(TextSelectingUtilities), Member = "get_selectIndex", ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 11)]
	[CallsUnknownMethods(Count = 1)]
	public void SelectWordLeft() { }

	[CalledBy(Type = typeof(TextSelectingUtilities), Member = "PerformOperation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextSelectOp)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TextSelectingUtilities), Member = "get_characterCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(TextSelectingUtilities), Member = "MoveWordRight", ReturnType = typeof(void))]
	[Calls(Type = typeof(TextSelectingUtilities), Member = "get_cursorIndex", ReturnType = typeof(int))]
	[Calls(Type = typeof(TextSelectingUtilities), Member = "get_selectIndex", ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 11)]
	[CallsUnknownMethods(Count = 1)]
	public void SelectWordRight() { }

	[CallerCount(Count = 21)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public void set_cursorIndex(int value) { }

	[CallerCount(Count = 21)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	internal void set_cursorIndexNoValidation(int value) { }

	[CalledBy(Type = typeof(TextEditingUtilities), Member = "set_revealCursor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextEditingUtilities), Member = "PerformOperation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextEditOp)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextEditingUtilities), Member = "OnBlur", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void set_revealCursor(bool value) { }

	[CallerCount(Count = 21)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public void set_selectIndex(int value) { }

	[CallerCount(Count = 21)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	internal void set_selectIndexNoValidation(int value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	internal void SetCursorIndexWithoutNotify(int index) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	internal void SetSelectIndexWithoutNotify(int index) { }

}

