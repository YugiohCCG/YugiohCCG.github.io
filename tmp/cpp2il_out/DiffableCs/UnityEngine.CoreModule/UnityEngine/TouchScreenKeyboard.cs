namespace UnityEngine;

[NativeConditional("ENABLE_ONSCREEN_KEYBOARD")]
[NativeHeader("Runtime/Input/KeyboardOnScreen.h")]
[NativeHeader("Runtime/Export/TouchScreenKeyboard/TouchScreenKeyboard.bindings.h")]
public class TouchScreenKeyboard
{
	public static class BindingsMarshaller
	{

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		public static IntPtr ConvertToNative(TouchScreenKeyboard touchScreenKeyboard) { }

	}

	internal enum InputFieldAppearance
	{
		Customizable = 0,
		AlwaysVisible = 1,
		AlwaysHidden = 2,
	}

	internal enum Status
	{
		Visible = 0,
		Done = 1,
		Canceled = 2,
		LostFocus = 3,
	}

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private static bool <disableInPlaceEditing>k__BackingField; //Field offset: 0x0
	internal IntPtr m_Ptr; //Field offset: 0x10

	public bool active
	{
		[CalledBy(Type = "TMPro.TMP_InputField", Member = "set_shouldHideSoftKeyboard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = "TMPro.TMP_InputField", Member = "LateUpdate", ReturnType = typeof(void))]
		[CalledBy(Type = "TMPro.TMP_InputField", Member = "OnPointerDown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.EventSystems.PointerEventData"}, ReturnType = typeof(void))]
		[CalledBy(Type = "TMPro.TMP_InputField", Member = "ActivateInputField", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UI.InputField", Member = "OnPointerDown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.EventSystems.PointerEventData"}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UI.InputField", Member = "ActivateInputField", ReturnType = typeof(void))]
		[CallerCount(Count = 6)]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		[NativeName("IsActive")]
		 get { } //Length: 82
		[CalledBy(Type = "UnityEngine.UIElements.TouchScreenTextEditorEventHandler", Member = "CloseTouchScreenKeyboard", ReturnType = typeof(void))]
		[CalledBy(Type = "TMPro.TMP_InputField", Member = "set_shouldHideSoftKeyboard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = "TMPro.TMP_InputField", Member = "ActivateInputField", ReturnType = typeof(void))]
		[CalledBy(Type = "TMPro.TMP_InputField", Member = "DeactivateInputField", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UI.InputField", Member = "ActivateInputField", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UI.InputField", Member = "DeactivateInputField", ReturnType = typeof(void))]
		[CallerCount(Count = 6)]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		[NativeName("SetActive")]
		 set { } //Length: 92
	}

	public bool canGetSelection
	{
		[CalledBy(Type = "UnityEngine.UIElements.TouchScreenTextEditorEventHandler", Member = "DoPollTouchScreenKeyboard", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UI.InputField", Member = "LateUpdate", ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		[NativeName("CanGetSelection")]
		 get { } //Length: 82
	}

	public bool canSetSelection
	{
		[CalledBy(Type = "TMPro.TMP_InputField", Member = "UpdateKeyboardStringPosition", ReturnType = typeof(void))]
		[CalledBy(Type = "TMPro.TMP_InputField", Member = "LateUpdate", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UI.InputField", Member = "UpdateKeyboardCaret", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UI.InputField", Member = "LateUpdate", ReturnType = typeof(void))]
		[CallerCount(Count = 5)]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		[NativeName("CanSetSelection")]
		 get { } //Length: 82
	}

	public int characterLimit
	{
		[CalledBy(Type = "TMPro.TMP_InputField", Member = "set_characterLimit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UI.InputField", Member = "set_characterLimit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		[NativeName("SetCharacterLimit")]
		 set { } //Length: 89
	}

	internal static bool disableInPlaceEditing
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		internal get { } //Length: 54
	}

	public static bool hideInput
	{
		[CalledBy(Type = "UnityEngine.UIElements.TouchScreenTextEditorEventHandler", Member = "OpenTouchScreenKeyboard", ReturnType = typeof(void))]
		[CalledBy(Type = "TMPro.TMP_InputField", Member = "ActivateInputFieldInternal", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UI.InputField", Member = "ActivateInputFieldInternal", ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[CallsUnknownMethods(Count = 2)]
		[NativeName("SetInputHidden")]
		 set { } //Length: 51
	}

	public static InputFieldAppearance inputFieldAppearance
	{
		[CalledBy(Type = "UnityEngine.UIElements.TextElement", Member = "UnityEngine.UIElements.ITextEdition.get_hideMobileInput", ReturnType = typeof(bool))]
		[CalledBy(Type = "UnityEngine.UIElements.TextElement", Member = "UnityEngine.UIElements.ITextEdition.set_hideMobileInput", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[CallsUnknownMethods(Count = 2)]
		[NativeName("GetInputFieldAppearance")]
		 get { } //Length: 42
	}

	public static bool isInPlaceEditingAllowed
	{
		[CalledBy(Type = "TMPro.TMP_InputField", Member = "OnEnable", ReturnType = typeof(void))]
		[CalledBy(Type = "TMPro.TMP_InputField", Member = "InPlaceEditingChanged", ReturnType = typeof(bool))]
		[CalledBy(Type = "TMPro.TMP_InputField", Member = "TouchScreenKeyboardShouldBeUsed", ReturnType = typeof(bool))]
		[CalledBy(Type = "TMPro.TMP_InputField", Member = "LateUpdate", ReturnType = typeof(void))]
		[CalledBy(Type = "TMPro.TMP_InputField", Member = "ActivateInputFieldInternal", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UI.InputField", Member = "TouchScreenKeyboardShouldBeUsed", ReturnType = typeof(bool))]
		[CalledBy(Type = "UnityEngine.UI.InputField", Member = "InPlaceEditingChanged", ReturnType = typeof(bool))]
		[CalledBy(Type = "UnityEngine.UI.InputField", Member = "LateUpdate", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UI.InputField", Member = "ActivateInputFieldInternal", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.TextEditingUtilities", Member = "TouchScreenKeyboardCanBeUsed", ReturnType = typeof(bool))]
		[CalledBy(Type = "UnityEngine.TextEditingUtilities", Member = "PhysicalKeyboardCanBeUsed", ReturnType = typeof(bool))]
		[CallerCount(Count = 14)]
		[CallsUnknownMethods(Count = 2)]
		 get { } //Length: 96
	}

	public static bool isSupported
	{
		[CallerCount(Count = 24)]
		[Calls(Type = typeof(Application), Member = "get_platform", ReturnType = typeof(RuntimePlatform))]
		 get { } //Length: 131
	}

	public RangeInt selection
	{
		[CalledBy(Type = "UnityEngine.UIElements.TouchScreenTextEditorEventHandler", Member = "UpdateStringPositionFromKeyboard", ReturnType = typeof(void))]
		[CalledBy(Type = "TMPro.TMP_InputField", Member = "UpdateStringPositionFromKeyboard", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UI.InputField", Member = "UpdateCaretFromKeyboard", ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[CallsUnknownMethods(Count = 2)]
		 get { } //Length: 66
		[CalledBy(Type = "UnityEngine.UIElements.TouchScreenTextEditorEventHandler", Member = "OpenTouchScreenKeyboard", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UI.InputField", Member = "LateUpdate", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UI.InputField", Member = "UpdateKeyboardCaret", ReturnType = typeof(void))]
		[CalledBy(Type = "TMPro.TMP_InputField", Member = "ActivateInputFieldInternal", ReturnType = typeof(void))]
		[CalledBy(Type = "TMPro.TMP_InputField", Member = "GenerateCaret", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UI.VertexHelper", typeof(Vector2)}, ReturnType = typeof(void))]
		[CalledBy(Type = "TMPro.TMP_InputField", Member = "LateUpdate", ReturnType = typeof(void))]
		[CalledBy(Type = "TMPro.TMP_InputField", Member = "GenerateHighlight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UI.VertexHelper", typeof(Vector2)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UIElements.TextElement", Member = "DrawNativeHighlighting", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.MeshGenerationContext"}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UIElements.TextElement", Member = "DrawHighlighting", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.MeshGenerationContext"}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UIElements.TouchScreenTextEditorEventHandler", Member = "OnPointerDownEvent", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UIElements.TouchScreenTextEditorEventHandler", Member = "HandleEventBubbleUp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.EventBase"}, ReturnType = typeof(void))]
		[CalledBy(Type = "TMPro.TMP_InputField", Member = "UpdateKeyboardStringPosition", ReturnType = typeof(void))]
		[CallerCount(Count = 12)]
		[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(TouchScreenKeyboard), Member = "get_text", ReturnType = typeof(string))]
		[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 10)]
		 set { } //Length: 287
	}

	public Status status
	{
		[CalledBy(Type = "UnityEngine.UIElements.TouchScreenTextEditorEventHandler", Member = "DoPollTouchScreenKeyboard", ReturnType = typeof(void))]
		[CalledBy(Type = "TMPro.TMP_InputField", Member = "LateUpdate", ReturnType = typeof(void))]
		[CalledBy(Type = "TMPro.TMP_InputField", Member = "SendTouchScreenKeyboardStatusChanged", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UI.InputField", Member = "LateUpdate", ReturnType = typeof(void))]
		[CallerCount(Count = 13)]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		[NativeName("GetKeyboardStatus")]
		 get { } //Length: 82
	}

	public string text
	{
		[CalledBy(Type = "UnityEngine.UIElements.TouchScreenTextEditorEventHandler", Member = "DoPollTouchScreenKeyboard", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UIElements.TouchScreenTextEditorEventHandler", Member = "OpenTouchScreenKeyboard", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UIElements.TouchScreenTextEditorEventHandler", Member = "HandleEventBubbleUp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.EventBase"}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UIElements.TouchScreenTextEditorEventHandler", Member = "OnPointerDownEvent", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UIElements.TextElement", Member = "UnityEngine.UIElements.ITextEdition.UpdateText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TouchScreenKeyboard), Member = "set_selection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RangeInt)}, ReturnType = typeof(void))]
		[CalledBy(Type = "TMPro.TMP_InputField", Member = "LateUpdate", ReturnType = typeof(void))]
		[CalledBy(Type = "TMPro.TMP_InputField", Member = "GenerateCaret", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UI.VertexHelper", typeof(Vector2)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UI.InputField", Member = "LateUpdate", ReturnType = typeof(void))]
		[CallerCount(Count = 14)]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 6)]
		[NativeName("GetText")]
		 get { } //Length: 163
		[CalledBy(Type = "UnityEngine.UI.InputField", Member = "LateUpdate", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UI.InputField", Member = "ActivateInputField", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UI.InputField", Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UI.InputField", Member = "UpdateTouchKeyboardFromEditChanges", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UI.InputField", Member = "Insert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UI.InputField", Member = "Backspace", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UI.InputField", Member = "ForwardSpace", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UI.InputField", Member = "KeyPressed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Event"}, ReturnType = "UnityEngine.UI.InputField+EditState")]
		[CalledBy(Type = "TMPro.TMP_InputField", Member = "ActivateInputField", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UI.InputField", Member = "SetText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = "TMPro.TMP_InputField", Member = "Insert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(void))]
		[CalledBy(Type = "TMPro.TMP_InputField", Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(void))]
		[CalledBy(Type = "TMPro.TMP_InputField", Member = "Backspace", ReturnType = typeof(void))]
		[CalledBy(Type = "TMPro.TMP_InputField", Member = "DeleteKey", ReturnType = typeof(void))]
		[CalledBy(Type = "TMPro.TMP_InputField", Member = "LateUpdate", ReturnType = typeof(void))]
		[CalledBy(Type = "TMPro.TMP_InputField", Member = "SetText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UIElements.TextElement", Member = "UnityEngine.UIElements.ITextEdition.UpdateText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CalledBy(Type = "TMPro.TMP_InputField", Member = "UpdateTouchKeyboardFromEditChanges", ReturnType = typeof(void))]
		[CallerCount(Count = 20)]
		[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 4)]
		[NativeName("SetText")]
		 set { } //Length: 391
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Convert), Member = "ToUInt32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(uint))]
	[Calls(Type = typeof(TouchScreenKeyboard), Member = "TouchScreenKeyboard_InternalConstructorHelper", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TouchScreenKeyboard_InternalConstructorHelperArguments&), typeof(string), typeof(string)}, ReturnType = typeof(IntPtr))]
	[CallsDeduplicatedMethods(Count = 5)]
	public TouchScreenKeyboard(string text, TouchScreenKeyboardType keyboardType, bool autocorrection, bool multiline, bool secure, bool alert, string textPlaceholder, int characterLimit) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GC), Member = "SuppressFinalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	private void Destroy() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GC), Member = "SuppressFinalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	protected virtual void Finalize() { }

	[CalledBy(Type = "TMPro.TMP_InputField", Member = "set_shouldHideSoftKeyboard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TMP_InputField", Member = "LateUpdate", ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TMP_InputField", Member = "OnPointerDown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.EventSystems.PointerEventData"}, ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TMP_InputField", Member = "ActivateInputField", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.InputField", Member = "OnPointerDown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.EventSystems.PointerEventData"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.InputField", Member = "ActivateInputField", ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[NativeName("IsActive")]
	public bool get_active() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static bool get_active_Injected(IntPtr _unity_self) { }

	[CalledBy(Type = "UnityEngine.UIElements.TouchScreenTextEditorEventHandler", Member = "DoPollTouchScreenKeyboard", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.InputField", Member = "LateUpdate", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[NativeName("CanGetSelection")]
	public bool get_canGetSelection() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static bool get_canGetSelection_Injected(IntPtr _unity_self) { }

	[CalledBy(Type = "TMPro.TMP_InputField", Member = "UpdateKeyboardStringPosition", ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TMP_InputField", Member = "LateUpdate", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.InputField", Member = "UpdateKeyboardCaret", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.InputField", Member = "LateUpdate", ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[NativeName("CanSetSelection")]
	public bool get_canSetSelection() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static bool get_canSetSelection_Injected(IntPtr _unity_self) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	internal static bool get_disableInPlaceEditing() { }

	[CalledBy(Type = "UnityEngine.UIElements.TextElement", Member = "UnityEngine.UIElements.ITextEdition.get_hideMobileInput", ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.UIElements.TextElement", Member = "UnityEngine.UIElements.ITextEdition.set_hideMobileInput", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	[NativeName("GetInputFieldAppearance")]
	public static InputFieldAppearance get_inputFieldAppearance() { }

	[CalledBy(Type = "TMPro.TMP_InputField", Member = "OnEnable", ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TMP_InputField", Member = "InPlaceEditingChanged", ReturnType = typeof(bool))]
	[CalledBy(Type = "TMPro.TMP_InputField", Member = "TouchScreenKeyboardShouldBeUsed", ReturnType = typeof(bool))]
	[CalledBy(Type = "TMPro.TMP_InputField", Member = "LateUpdate", ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TMP_InputField", Member = "ActivateInputFieldInternal", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.InputField", Member = "TouchScreenKeyboardShouldBeUsed", ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.UI.InputField", Member = "InPlaceEditingChanged", ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.UI.InputField", Member = "LateUpdate", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.InputField", Member = "ActivateInputFieldInternal", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.TextEditingUtilities", Member = "TouchScreenKeyboardCanBeUsed", ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.TextEditingUtilities", Member = "PhysicalKeyboardCanBeUsed", ReturnType = typeof(bool))]
	[CallerCount(Count = 14)]
	[CallsUnknownMethods(Count = 2)]
	public static bool get_isInPlaceEditingAllowed() { }

	[CallerCount(Count = 24)]
	[Calls(Type = typeof(Application), Member = "get_platform", ReturnType = typeof(RuntimePlatform))]
	public static bool get_isSupported() { }

	[CalledBy(Type = "UnityEngine.UIElements.TouchScreenTextEditorEventHandler", Member = "UpdateStringPositionFromKeyboard", ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TMP_InputField", Member = "UpdateStringPositionFromKeyboard", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.InputField", Member = "UpdateCaretFromKeyboard", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	public RangeInt get_selection() { }

	[CalledBy(Type = "UnityEngine.UIElements.TouchScreenTextEditorEventHandler", Member = "DoPollTouchScreenKeyboard", ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TMP_InputField", Member = "LateUpdate", ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TMP_InputField", Member = "SendTouchScreenKeyboardStatusChanged", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.InputField", Member = "LateUpdate", ReturnType = typeof(void))]
	[CallerCount(Count = 13)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[NativeName("GetKeyboardStatus")]
	public Status get_status() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static Status get_status_Injected(IntPtr _unity_self) { }

	[CalledBy(Type = "UnityEngine.UIElements.TouchScreenTextEditorEventHandler", Member = "DoPollTouchScreenKeyboard", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.TouchScreenTextEditorEventHandler", Member = "OpenTouchScreenKeyboard", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.TouchScreenTextEditorEventHandler", Member = "HandleEventBubbleUp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.EventBase"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.TouchScreenTextEditorEventHandler", Member = "OnPointerDownEvent", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.TextElement", Member = "UnityEngine.UIElements.ITextEdition.UpdateText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TouchScreenKeyboard), Member = "set_selection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RangeInt)}, ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TMP_InputField", Member = "LateUpdate", ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TMP_InputField", Member = "GenerateCaret", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UI.VertexHelper", typeof(Vector2)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.InputField", Member = "LateUpdate", ReturnType = typeof(void))]
	[CallerCount(Count = 14)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 6)]
	[NativeName("GetText")]
	public string get_text() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void get_text_Injected(IntPtr _unity_self, out ManagedSpanWrapper ret) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void GetSelection(out int start, out int length) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[FreeFunction("TouchScreenKeyboard_Destroy", IsThreadSafe = True)]
	private static void Internal_Destroy(IntPtr ptr) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static bool IsInPlaceEditingAllowed() { }

	[CalledBy(Type = "UnityEngine.UIElements.TouchScreenTextEditorEventHandler", Member = "OpenTouchScreenKeyboard", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Convert), Member = "ToUInt32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(uint))]
	[Calls(Type = typeof(TouchScreenKeyboard), Member = "TouchScreenKeyboard_InternalConstructorHelper", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TouchScreenKeyboard_InternalConstructorHelperArguments&), typeof(string), typeof(string)}, ReturnType = typeof(IntPtr))]
	[CallsDeduplicatedMethods(Count = 5)]
	[ExcludeFromDocs]
	public static TouchScreenKeyboard Open(string text, TouchScreenKeyboardType keyboardType, bool autocorrection, bool multiline, bool secure) { }

	[CalledBy(Type = "TMPro.TMP_InputField", Member = "ActivateInputFieldInternal", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.InputField", Member = "ActivateInputFieldInternal", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Convert), Member = "ToUInt32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(uint))]
	[Calls(Type = typeof(TouchScreenKeyboard), Member = "TouchScreenKeyboard_InternalConstructorHelper", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TouchScreenKeyboard_InternalConstructorHelperArguments&), typeof(string), typeof(string)}, ReturnType = typeof(IntPtr))]
	[CallsDeduplicatedMethods(Count = 5)]
	public static TouchScreenKeyboard Open(string text, TouchScreenKeyboardType keyboardType, bool autocorrection, bool multiline, bool secure, bool alert, string textPlaceholder, int characterLimit) { }

	[CalledBy(Type = "UnityEngine.UIElements.TouchScreenTextEditorEventHandler", Member = "CloseTouchScreenKeyboard", ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TMP_InputField", Member = "set_shouldHideSoftKeyboard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TMP_InputField", Member = "ActivateInputField", ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TMP_InputField", Member = "DeactivateInputField", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.InputField", Member = "ActivateInputField", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.InputField", Member = "DeactivateInputField", ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[NativeName("SetActive")]
	public void set_active(bool value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void set_active_Injected(IntPtr _unity_self, bool value) { }

	[CalledBy(Type = "TMPro.TMP_InputField", Member = "set_characterLimit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.InputField", Member = "set_characterLimit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[NativeName("SetCharacterLimit")]
	public void set_characterLimit(int value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void set_characterLimit_Injected(IntPtr _unity_self, int value) { }

	[CalledBy(Type = "UnityEngine.UIElements.TouchScreenTextEditorEventHandler", Member = "OpenTouchScreenKeyboard", ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TMP_InputField", Member = "ActivateInputFieldInternal", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.InputField", Member = "ActivateInputFieldInternal", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	[NativeName("SetInputHidden")]
	public static void set_hideInput(bool value) { }

	[CalledBy(Type = "UnityEngine.UIElements.TouchScreenTextEditorEventHandler", Member = "OpenTouchScreenKeyboard", ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TMP_InputField", Member = "UpdateKeyboardStringPosition", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.TouchScreenTextEditorEventHandler", Member = "HandleEventBubbleUp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.EventBase"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.TouchScreenTextEditorEventHandler", Member = "OnPointerDownEvent", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.TextElement", Member = "DrawNativeHighlighting", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.MeshGenerationContext"}, ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TMP_InputField", Member = "GenerateHighlight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UI.VertexHelper", typeof(Vector2)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.TextElement", Member = "DrawHighlighting", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.MeshGenerationContext"}, ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TMP_InputField", Member = "GenerateCaret", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UI.VertexHelper", typeof(Vector2)}, ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TMP_InputField", Member = "ActivateInputFieldInternal", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.InputField", Member = "UpdateKeyboardCaret", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.InputField", Member = "LateUpdate", ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TMP_InputField", Member = "LateUpdate", ReturnType = typeof(void))]
	[CallerCount(Count = 12)]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TouchScreenKeyboard), Member = "get_text", ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 10)]
	public void set_selection(RangeInt value) { }

	[CalledBy(Type = "UnityEngine.UI.InputField", Member = "LateUpdate", ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TMP_InputField", Member = "UpdateTouchKeyboardFromEditChanges", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.TextElement", Member = "UnityEngine.UIElements.ITextEdition.UpdateText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TMP_InputField", Member = "SetText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TMP_InputField", Member = "LateUpdate", ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TMP_InputField", Member = "DeleteKey", ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TMP_InputField", Member = "Backspace", ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TMP_InputField", Member = "Insert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.InputField", Member = "SetText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TMP_InputField", Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.InputField", Member = "KeyPressed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Event"}, ReturnType = "UnityEngine.UI.InputField+EditState")]
	[CalledBy(Type = "UnityEngine.UI.InputField", Member = "ForwardSpace", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.InputField", Member = "Backspace", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.InputField", Member = "Insert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.InputField", Member = "UpdateTouchKeyboardFromEditChanges", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.InputField", Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.InputField", Member = "ActivateInputField", ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TMP_InputField", Member = "ActivateInputField", ReturnType = typeof(void))]
	[CallerCount(Count = 20)]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	[NativeName("SetText")]
	public void set_text(string value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void set_text_Injected(IntPtr _unity_self, ref ManagedSpanWrapper value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void SetSelection(int start, int length) { }

	[CalledBy(Type = typeof(TouchScreenKeyboard), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(TouchScreenKeyboardType), typeof(bool), typeof(bool), typeof(bool), typeof(bool), typeof(string), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TouchScreenKeyboard), Member = "Open", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(TouchScreenKeyboardType), typeof(bool), typeof(bool), typeof(bool), typeof(bool), typeof(string), typeof(int)}, ReturnType = typeof(TouchScreenKeyboard))]
	[CalledBy(Type = typeof(TouchScreenKeyboard), Member = "Open", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(TouchScreenKeyboardType), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(TouchScreenKeyboard))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 3)]
	[FreeFunction("TouchScreenKeyboard_InternalConstructorHelper")]
	private static IntPtr TouchScreenKeyboard_InternalConstructorHelper(ref TouchScreenKeyboard_InternalConstructorHelperArguments arguments, string text, string textPlaceholder) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static IntPtr TouchScreenKeyboard_InternalConstructorHelper_Injected(ref TouchScreenKeyboard_InternalConstructorHelperArguments arguments, ref ManagedSpanWrapper text, ref ManagedSpanWrapper textPlaceholder) { }

}

