namespace UnityEngine.UIElements;

internal class TextEditingManipulator
{
	private readonly TextElement m_TextElement; //Field offset: 0x10
	private TextEditorEventHandler m_TouchScreenEditingEventHandler; //Field offset: 0x18
	private TextEditorEventHandler m_KeyboardEditingEventHandler; //Field offset: 0x20
	internal TextEditingUtilities editingUtilities; //Field offset: 0x28
	private IVisualElementScheduledItem m_HardwareKeyboardPoller; //Field offset: 0x30

	private bool keyboardCanBeUsed
	{
		[CalledBy(Type = typeof(TextEditingManipulator), Member = "get_touchScreenTextFieldChanged", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(TextEditingManipulator), Member = "UpdateTextEditorEventHandler", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TextEditingManipulator), Member = "OnFocusInEvent", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TextEditingManipulator), Member = "<OnFocusInEvent>b__21_0", ReturnType = typeof(void))]
		[CallerCount(Count = 4)]
		[Calls(Type = "UnityEngine.TextEditingUtilities", Member = "PhysicalKeyboardCanBeUsed", ReturnType = typeof(bool))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		private get { } //Length: 116
	}

	internal TextEditorEventHandler keyboardEditingEventHandler
	{
		[CallerCount(Count = 12)]
		[DeduplicatedMethod]
		internal get { } //Length: 5
		[CalledBy(Type = typeof(TextEditingManipulator), Member = "UpdateTextEditorEventHandler", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		internal set { } //Length: 107
	}

	private bool touchScreenCanBeUsed
	{
		[CalledBy(Type = typeof(TextEditingManipulator), Member = "get_touchScreenTextFieldChanged", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(TextEditingManipulator), Member = "UpdateTextEditorEventHandler", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TextEditingManipulator), Member = "OnFocusInEvent", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TextEditingManipulator), Member = "<OnFocusInEvent>b__21_0", ReturnType = typeof(void))]
		[CallerCount(Count = 4)]
		[Calls(Type = "UnityEngine.TextEditingUtilities", Member = "TouchScreenKeyboardCanBeUsed", ReturnType = typeof(bool))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		private get { } //Length: 119
	}

	internal TextEditorEventHandler touchScreenEditingEventHandler
	{
		[CallerCount(Count = 31)]
		[DeduplicatedMethod]
		internal get { } //Length: 5
		[CalledBy(Type = typeof(TextEditingManipulator), Member = "UpdateTextEditorEventHandler", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		internal set { } //Length: 107
	}

	private bool touchScreenTextFieldChanged
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(TextEditingManipulator), Member = "get_touchScreenCanBeUsed", ReturnType = typeof(bool))]
		[Calls(Type = typeof(TextEditingManipulator), Member = "get_keyboardCanBeUsed", ReturnType = typeof(bool))]
		[ContainsUnimplementedInstructions]
		private get { } //Length: 66
	}

	[CalledBy(Type = typeof(TextElement), Member = "UnityEngine.UIElements.ITextEdition.set_isReadOnly", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TextElement), Member = "get_selectingManipulator", ReturnType = typeof(TextSelectingManipulator))]
	[Calls(Type = "UnityEngine.TextEditingUtilities", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.TextSelectingUtilities", "UnityEngine.TextCore.Text.TextHandle", typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TextEditingManipulator), Member = "UpdateTextEditorEventHandler", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	public TextEditingManipulator(TextElement textElement) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TextEditingManipulator), Member = "get_touchScreenCanBeUsed", ReturnType = typeof(bool))]
	[Calls(Type = typeof(TextEditingManipulator), Member = "get_keyboardCanBeUsed", ReturnType = typeof(bool))]
	[Calls(Type = typeof(TextEditingManipulator), Member = "UpdateTextEditorEventHandler", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[ContainsUnimplementedInstructions]
	private void <OnFocusInEvent>b__21_0() { }

	[CalledBy(Type = typeof(TextEditingManipulator), Member = "get_touchScreenTextFieldChanged", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TextEditingManipulator), Member = "UpdateTextEditorEventHandler", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextEditingManipulator), Member = "OnFocusInEvent", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextEditingManipulator), Member = "<OnFocusInEvent>b__21_0", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = "UnityEngine.TextEditingUtilities", Member = "PhysicalKeyboardCanBeUsed", ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private bool get_keyboardCanBeUsed() { }

	[CallerCount(Count = 12)]
	[DeduplicatedMethod]
	internal TextEditorEventHandler get_keyboardEditingEventHandler() { }

	[CalledBy(Type = typeof(TextEditingManipulator), Member = "get_touchScreenTextFieldChanged", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TextEditingManipulator), Member = "UpdateTextEditorEventHandler", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextEditingManipulator), Member = "OnFocusInEvent", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextEditingManipulator), Member = "<OnFocusInEvent>b__21_0", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = "UnityEngine.TextEditingUtilities", Member = "TouchScreenKeyboardCanBeUsed", ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private bool get_touchScreenCanBeUsed() { }

	[CallerCount(Count = 31)]
	[DeduplicatedMethod]
	internal TextEditorEventHandler get_touchScreenEditingEventHandler() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TextEditingManipulator), Member = "get_touchScreenCanBeUsed", ReturnType = typeof(bool))]
	[Calls(Type = typeof(TextEditingManipulator), Member = "get_keyboardCanBeUsed", ReturnType = typeof(bool))]
	[ContainsUnimplementedInstructions]
	private bool get_touchScreenTextFieldChanged() { }

	[CalledBy(Type = typeof(TextElement), Member = "EditionHandleEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = "UnityEngine.TextCore.Text.TextHandle", Member = "RemoveTextInfoFromPermanentCache", ReturnType = typeof(void))]
	[Calls(Type = typeof(TextElement), Member = "get_selectingManipulator", ReturnType = typeof(TextSelectingManipulator))]
	[Calls(Type = typeof(TextEditingManipulator), Member = "OnFocusInEvent", ReturnType = typeof(void))]
	[Calls(Type = "UnityEngine.TextEditingUtilities", Member = "OnBlur", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 3)]
	internal void HandleEventBubbleUp(EventBase evt) { }

	[CalledBy(Type = typeof(TextEditingManipulator), Member = "HandleEventBubbleUp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(FocusController), Member = "set_selectedTextElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextElement)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TextEditingManipulator), Member = "get_touchScreenCanBeUsed", ReturnType = typeof(bool))]
	[Calls(Type = typeof(TextEditingManipulator), Member = "get_keyboardCanBeUsed", ReturnType = typeof(bool))]
	[Calls(Type = typeof(TextEditingManipulator), Member = "UpdateTextEditorEventHandler", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 6)]
	[ContainsUnimplementedInstructions]
	private void OnFocusInEvent() { }

	[CallerCount(Count = 0)]
	[Calls(Type = "UnityEngine.TextEditingUtilities", Member = "OnBlur", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	private void OnFocusOutEvent() { }

	[CalledBy(Type = typeof(TextElement), Member = "UnityEngine.UIElements.ITextEdition.set_isReadOnly", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 2)]
	public void Reset() { }

	[CalledBy(Type = typeof(TextEditingManipulator), Member = "UpdateTextEditorEventHandler", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	internal void set_keyboardEditingEventHandler(TextEditorEventHandler value) { }

	[CalledBy(Type = typeof(TextEditingManipulator), Member = "UpdateTextEditorEventHandler", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	internal void set_touchScreenEditingEventHandler(TextEditorEventHandler value) { }

	[CalledBy(Type = typeof(TextEditingManipulator), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextElement)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextEditingManipulator), Member = "OnFocusInEvent", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextEditingManipulator), Member = "<OnFocusInEvent>b__21_0", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(TextEditingManipulator), Member = "get_touchScreenCanBeUsed", ReturnType = typeof(bool))]
	[Calls(Type = typeof(TouchScreenTextEditorEventHandler), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextElement), "UnityEngine.TextEditingUtilities"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TextEditingManipulator), Member = "set_touchScreenEditingEventHandler", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextEditorEventHandler)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TextEditingManipulator), Member = "get_keyboardCanBeUsed", ReturnType = typeof(bool))]
	[Calls(Type = typeof(KeyboardTextEditorEventHandler), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextElement), "UnityEngine.TextEditingUtilities"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TextEditingManipulator), Member = "set_keyboardEditingEventHandler", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextEditorEventHandler)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 2)]
	private void UpdateTextEditorEventHandler() { }

}

