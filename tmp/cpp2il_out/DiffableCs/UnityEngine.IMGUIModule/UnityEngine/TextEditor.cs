namespace UnityEngine;

public class TextEditor
{
	internal enum DblClickSnapping
	{
		WORDS = 0,
		PARAGRAPHS = 1,
	}

	private readonly GUIContent m_Content; //Field offset: 0x10
	private TextSelectingUtilities m_TextSelecting; //Field offset: 0x18
	internal TextEditingUtilities m_TextEditing; //Field offset: 0x20
	internal IMGUITextHandle m_TextHandle; //Field offset: 0x28
	public TouchScreenKeyboard keyboardOnScreen; //Field offset: 0x30
	public int controlID; //Field offset: 0x38
	public GUIStyle style; //Field offset: 0x40
	[Obsolete("'hasHorizontalCursorPos' has been deprecated. Changes to this member will not be observed. Use 'hasHorizontalCursor' instead.", True)]
	public bool hasHorizontalCursorPos; //Field offset: 0x48
	public bool isPasswordField; //Field offset: 0x49
	public Vector2 scrollOffset; //Field offset: 0x4C
	private string m_TextWithWhitespace; //Field offset: 0x58
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private Rect <position>k__BackingField; //Field offset: 0x60
	public Vector2 graphicalCursorPos; //Field offset: 0x70
	private Vector2 lastCursorPos; //Field offset: 0x78
	private Vector2 previousContentSize; //Field offset: 0x80

	public Rect position
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 11
	}

	public bool showCursor
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 27
	}

	public string text
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 27
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(GUIContent), Member = "SetTextWithoutNotify", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(TextEditor), Member = "set_textWithWhitespace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(TextEditor), Member = "UpdateTextHandle", ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		 set { } //Length: 176
	}

	internal string textWithWhitespace
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
		internal get { } //Length: 110
		[CalledBy(Type = typeof(TextEditor), Member = "set_text", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TextEditor), Member = "OnTextChangedHandle", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TextEditor), Member = "OnContentTextChangedHandle", ReturnType = typeof(void))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
		[CallsUnknownMethods(Count = 1)]
		internal set { } //Length: 123
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GUIContent), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(GUIStyle), Member = "get_none", ReturnType = typeof(GUIStyle))]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Color32), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(Color32))]
	[Calls(Type = typeof(IMGUITextHandle), Member = "GetTextHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GUIStyle), typeof(Rect), typeof(string), typeof(Color32)}, ReturnType = typeof(IMGUITextHandle))]
	[Calls(Type = typeof(TextEditingUtilities), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextSelectingUtilities), "UnityEngine.TextCore.Text.TextHandle", typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GUIContent), Member = "add_OnTextChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 17)]
	[RequiredByNativeCode]
	public TextEditor() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public Rect get_position() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public bool get_showCursor() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public string get_text() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	internal string get_textWithWhitespace() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GUIContent), Member = "SetTextWithoutNotify", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TextEditor), Member = "set_textWithWhitespace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TextEditor), Member = "UpdateTextHandle", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	private void OnContentTextChangedHandle() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TextEditor), Member = "UpdateScrollOffset", ReturnType = typeof(void))]
	[DeduplicatedMethod]
	internal override void OnCursorIndexChange() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TextEditor), Member = "UpdateScrollOffset", ReturnType = typeof(void))]
	[DeduplicatedMethod]
	internal override void OnSelectIndexChange() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GUIContent), Member = "SetTextWithoutNotify", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TextEditor), Member = "set_textWithWhitespace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TextEditor), Member = "UpdateTextHandle", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private void OnTextChangedHandle() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GUIContent), Member = "SetTextWithoutNotify", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TextEditor), Member = "set_textWithWhitespace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TextEditor), Member = "UpdateTextHandle", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public void set_text(string value) { }

	[CalledBy(Type = typeof(TextEditor), Member = "set_text", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextEditor), Member = "OnTextChangedHandle", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextEditor), Member = "OnContentTextChangedHandle", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 1)]
	internal void set_textWithWhitespace(string value) { }

	[CalledBy(Type = typeof(TextEditor), Member = "OnCursorIndexChange", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextEditor), Member = "OnSelectIndexChange", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GUIStyle), Member = "GetCursorPixelPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), typeof(GUIContent), typeof(int)}, ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(GUIStyle), Member = "get_padding", ReturnType = typeof(RectOffset))]
	[Calls(Type = typeof(RectOffset), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect)}, ReturnType = typeof(Rect))]
	[Calls(Type = typeof(RectOffset), Member = "get_left", ReturnType = typeof(int))]
	[Calls(Type = typeof(RectOffset), Member = "get_top", ReturnType = typeof(int))]
	[Calls(Type = typeof(GUIContent), Member = "get_textWithWhitespace", ReturnType = typeof(string))]
	[Calls(Type = typeof(GUIStyle), Member = "GetPreferredSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Rect)}, ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(GUIStyle), Member = "get_lineHeight", ReturnType = typeof(float))]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	[VisibleToOtherModules]
	internal void UpdateScrollOffset() { }

	[CalledBy(Type = typeof(TextEditor), Member = "set_text", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextEditor), Member = "OnTextChangedHandle", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextEditor), Member = "OnContentTextChangedHandle", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(GUIStyle), Member = "get_padding", ReturnType = typeof(RectOffset))]
	[Calls(Type = typeof(RectOffset), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect)}, ReturnType = typeof(Rect))]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Color32), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(Color32))]
	[Calls(Type = typeof(IMGUITextHandle), Member = "GetTextHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GUIStyle), typeof(Rect), typeof(string), typeof(Color32)}, ReturnType = typeof(IMGUITextHandle))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	internal void UpdateTextHandle() { }

}

