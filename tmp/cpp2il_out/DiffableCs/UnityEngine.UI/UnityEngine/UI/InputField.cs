namespace UnityEngine.UI;

[AddComponentMenu("UI/Legacy/Input Field", 103)]
public class InputField : Selectable, IUpdateSelectedHandler, IEventSystemHandler, IBeginDragHandler, IDragHandler, IEndDragHandler, IPointerClickHandler, ISubmitHandler, ICanvasElement, ILayoutElement
{
	[CompilerGenerated]
	private sealed class <CaretBlink>d__170 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public InputField <>4__this; //Field offset: 0x20

		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[CallerCount(Count = 31)]
			[DebuggerHidden]
			[DeduplicatedMethod]
			private get { } //Length: 5
		}

		private override object System.Collections.IEnumerator.Current
		{
			[CallerCount(Count = 31)]
			[DebuggerHidden]
			[DeduplicatedMethod]
			private get { } //Length: 5
		}

		[CallerCount(Count = 36)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		public <CaretBlink>d__170(int <>1__state) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Time), Member = "get_unscaledTime", ReturnType = typeof(float))]
		[Calls(Type = typeof(InputField), Member = "get_hasSelection", ReturnType = typeof(bool))]
		[Calls(Type = typeof(InputField), Member = "MarkGeometryAsDirty", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 5)]
		[ContainsUnimplementedInstructions]
		private override bool MoveNext() { }

		[CallerCount(Count = 31)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[CallerCount(Count = 31)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		private override object System.Collections.IEnumerator.get_Current() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[CallerCount(Count = 13327)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	private sealed class <MouseDragOutsideRect>d__194 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public PointerEventData eventData; //Field offset: 0x20
		public InputField <>4__this; //Field offset: 0x28

		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[CallerCount(Count = 31)]
			[DebuggerHidden]
			[DeduplicatedMethod]
			private get { } //Length: 5
		}

		private override object System.Collections.IEnumerator.Current
		{
			[CallerCount(Count = 31)]
			[DebuggerHidden]
			[DeduplicatedMethod]
			private get { } //Length: 5
		}

		[CallerCount(Count = 36)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		public <MouseDragOutsideRect>d__194(int <>1__state) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(MultipleDisplayUtilities), Member = "GetRelativeMousePositionForDrag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData), typeof(Vector2&)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Graphic), Member = "get_rectTransform", ReturnType = typeof(RectTransform))]
		[Calls(Type = typeof(PointerEventData), Member = "get_pressEventCamera", ReturnType = typeof(Camera))]
		[Calls(Type = typeof(RectTransformUtility), Member = "ScreenPointToLocalPointInRectangle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform), typeof(Vector2), typeof(Camera), typeof(Vector2&)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(RectTransform), Member = "get_rect", ReturnType = typeof(Rect))]
		[Calls(Type = typeof(InputField), Member = "get_compositionString", ReturnType = typeof(string))]
		[Calls(Type = typeof(InputField), Member = "MoveDown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(InputField), Member = "MoveUp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(InputField), Member = "UpdateLabel", ReturnType = typeof(void))]
		[Calls(Type = typeof(WaitForSecondsRealtime), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 4)]
		private override bool MoveNext() { }

		[CallerCount(Count = 31)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[CallerCount(Count = 31)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		private override object System.Collections.IEnumerator.get_Current() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[CallerCount(Count = 13327)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		private override void System.IDisposable.Dispose() { }

	}

	internal enum CharacterValidation
	{
		None = 0,
		Integer = 1,
		Decimal = 2,
		Alphanumeric = 3,
		Name = 4,
		EmailAddress = 5,
	}

	internal enum ContentType
	{
		Standard = 0,
		Autocorrected = 1,
		IntegerNumber = 2,
		DecimalNumber = 3,
		Alphanumeric = 4,
		Name = 5,
		EmailAddress = 6,
		Password = 7,
		Pin = 8,
		Custom = 9,
	}

	internal enum EditState
	{
		Continue = 0,
		Finish = 1,
	}

	internal class EndEditEvent : UnityEvent<String>
	{

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		public EndEditEvent() { }

	}

	internal enum InputType
	{
		Standard = 0,
		AutoCorrect = 1,
		Password = 2,
	}

	internal enum LineType
	{
		SingleLine = 0,
		MultiLineSubmit = 1,
		MultiLineNewline = 2,
	}

	internal class OnChangeEvent : UnityEvent<String>
	{

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		public OnChangeEvent() { }

	}

	internal sealed class OnValidateInput : MulticastDelegate
	{

		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 4)]
		[DeduplicatedMethod]
		public OnValidateInput(object object, IntPtr method) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		public override IAsyncResult BeginInvoke(string text, int charIndex, char addedChar, AsyncCallback callback, object object) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		public override char EndInvoke(IAsyncResult result) { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public override char Invoke(string text, int charIndex, char addedChar) { }

	}

	internal class SubmitEvent : UnityEvent<String>
	{

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		public SubmitEvent() { }

	}

	private const int k_MaxTextLength = 16382; //Field offset: 0x0
	private static readonly Char[] kSeparators; //Field offset: 0x0
	private const string kOculusQuestDeviceModel = "Oculus Quest"; //Field offset: 0x0
	private const string kEmailSpecialCharacters = "!#$%&'*+-/=?^_`{|}~"; //Field offset: 0x0
	private const float kVScrollSpeed = 0.1; //Field offset: 0x0
	private const float kHScrollSpeed = 0.05; //Field offset: 0x0
	private static bool s_IsQuestDevice; //Field offset: 0x8
	protected TouchScreenKeyboard m_Keyboard; //Field offset: 0x100
	[FormerlySerializedAs("text")]
	[SerializeField]
	protected Text m_TextComponent; //Field offset: 0x108
	[SerializeField]
	protected Graphic m_Placeholder; //Field offset: 0x110
	[SerializeField]
	private ContentType m_ContentType; //Field offset: 0x118
	[FormerlySerializedAs("inputType")]
	[SerializeField]
	private InputType m_InputType; //Field offset: 0x11C
	[FormerlySerializedAs("asteriskChar")]
	[SerializeField]
	private char m_AsteriskChar; //Field offset: 0x120
	[FormerlySerializedAs("keyboardType")]
	[SerializeField]
	private TouchScreenKeyboardType m_KeyboardType; //Field offset: 0x124
	[SerializeField]
	private LineType m_LineType; //Field offset: 0x128
	[FormerlySerializedAs("hideMobileInput")]
	[SerializeField]
	private bool m_HideMobileInput; //Field offset: 0x12C
	[FormerlySerializedAs("validation")]
	[SerializeField]
	private CharacterValidation m_CharacterValidation; //Field offset: 0x130
	[FormerlySerializedAs("characterLimit")]
	[SerializeField]
	private int m_CharacterLimit; //Field offset: 0x134
	[FormerlySerializedAs("onSubmit")]
	[FormerlySerializedAs("m_OnSubmit")]
	[FormerlySerializedAs("m_EndEdit")]
	[FormerlySerializedAs("m_OnEndEdit")]
	[SerializeField]
	private SubmitEvent m_OnSubmit; //Field offset: 0x138
	[SerializeField]
	private EndEditEvent m_OnDidEndEdit; //Field offset: 0x140
	[FormerlySerializedAs("onValueChange")]
	[FormerlySerializedAs("m_OnValueChange")]
	[SerializeField]
	private OnChangeEvent m_OnValueChanged; //Field offset: 0x148
	[FormerlySerializedAs("onValidateInput")]
	[SerializeField]
	private OnValidateInput m_OnValidateInput; //Field offset: 0x150
	[FormerlySerializedAs("selectionColor")]
	[SerializeField]
	private Color m_CaretColor; //Field offset: 0x158
	[SerializeField]
	private bool m_CustomCaretColor; //Field offset: 0x168
	[SerializeField]
	private Color m_SelectionColor; //Field offset: 0x16C
	[FormerlySerializedAs("mValue")]
	[Multiline]
	[SerializeField]
	protected string m_Text; //Field offset: 0x180
	[Range(0, 4)]
	[SerializeField]
	private float m_CaretBlinkRate; //Field offset: 0x188
	[Range(1, 5)]
	[SerializeField]
	private int m_CaretWidth; //Field offset: 0x18C
	[SerializeField]
	private bool m_ReadOnly; //Field offset: 0x190
	[SerializeField]
	private bool m_ShouldActivateOnSelect; //Field offset: 0x191
	protected int m_CaretPosition; //Field offset: 0x194
	protected int m_CaretSelectPosition; //Field offset: 0x198
	private RectTransform caretRectTrans; //Field offset: 0x1A0
	protected UIVertex[] m_CursorVerts; //Field offset: 0x1A8
	private TextGenerator m_InputTextCache; //Field offset: 0x1B0
	private CanvasRenderer m_CachedInputRenderer; //Field offset: 0x1B8
	private bool m_PreventFontCallback; //Field offset: 0x1C0
	protected Mesh m_Mesh; //Field offset: 0x1C8
	private bool m_AllowInput; //Field offset: 0x1D0
	private bool m_ShouldActivateNextUpdate; //Field offset: 0x1D1
	private bool m_UpdateDrag; //Field offset: 0x1D2
	private bool m_DragPositionOutOfBounds; //Field offset: 0x1D3
	protected bool m_CaretVisible; //Field offset: 0x1D4
	private Coroutine m_BlinkCoroutine; //Field offset: 0x1D8
	private float m_BlinkStartTime; //Field offset: 0x1E0
	protected int m_DrawStart; //Field offset: 0x1E4
	protected int m_DrawEnd; //Field offset: 0x1E8
	private Coroutine m_DragCoroutine; //Field offset: 0x1F0
	private string m_OriginalText; //Field offset: 0x1F8
	private bool m_WasCanceled; //Field offset: 0x200
	private bool m_HasDoneFocusTransition; //Field offset: 0x201
	private WaitForSecondsRealtime m_WaitForSecondsRealtime; //Field offset: 0x208
	private bool m_TouchKeyboardAllowsInPlaceEditing; //Field offset: 0x210
	private bool m_IsCompositionActive; //Field offset: 0x211
	private Event m_ProcessingEvent; //Field offset: 0x218

	public char asteriskChar
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 8
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SetPropertyUtility), Member = "SetStruct", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char&), typeof(char)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(InputField), Member = "UpdateLabel", ReturnType = typeof(void))]
		 set { } //Length: 91
	}

	protected TextGenerator cachedInputTextGenerator
	{
		[CalledBy(Type = typeof(InputField), Member = "LineUpCharacterPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(int))]
		[CalledBy(Type = typeof(InputField), Member = "LineDownCharacterPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(int))]
		[CalledBy(Type = typeof(InputField), Member = "UpdateLabel", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InputField), Member = "SetDrawRangeToContainCaretPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CallerCount(Count = 29)]
		[Calls(Type = typeof(TextGenerator), Member = ".ctor", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 117
	}

	public float caretBlinkRate
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 9
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SetPropertyUtility), Member = "SetStruct", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Single&), typeof(float)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(InputField), Member = "SetCaretActive", ReturnType = typeof(void))]
		 set { } //Length: 101
	}

	public Color caretColor
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 90
		[CalledBy(Type = "SimpleFileBrowser.UISkin", Member = "ApplyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputField)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CanvasUpdateRegistry), Member = "RegisterCanvasElementForGraphicRebuild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ICanvasElement)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		 set { } //Length: 111
	}

	public int caretPosition
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InputField), Member = "get_compositionString", ReturnType = typeof(string))]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 40
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InputField), Member = "get_compositionString", ReturnType = typeof(string))]
		[CallsUnknownMethods(Count = 1)]
		 set { } //Length: 179
	}

	protected int caretPositionInternal
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InputField), Member = "get_compositionString", ReturnType = typeof(string))]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 40
		[CalledBy(Type = typeof(InputField), Member = "LateUpdate", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InputField), Member = "Backspace", ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		 set { } //Length: 69
	}

	protected int caretSelectPositionInternal
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InputField), Member = "get_compositionString", ReturnType = typeof(string))]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 40
		[CalledBy(Type = typeof(InputField), Member = "LateUpdate", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InputField), Member = "Backspace", ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		 set { } //Length: 69
	}

	public int caretWidth
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 7
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SetPropertyUtility), Member = "SetStruct", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&), typeof(int)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CanvasUpdateRegistry), Member = "RegisterCanvasElementForGraphicRebuild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ICanvasElement)}, ReturnType = typeof(void))]
		 set { } //Length: 138
	}

	public int characterLimit
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 7
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Math), Member = "Max", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(SetPropertyUtility), Member = "SetStruct", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&), typeof(int)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(InputField), Member = "UpdateLabel", ReturnType = typeof(void))]
		[Calls(Type = typeof(TouchScreenKeyboard), Member = "set_characterLimit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		 set { } //Length: 161
	}

	public CharacterValidation characterValidation
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 7
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SetPropertyUtility), Member = "SetStruct", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"System.Int32Enum"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32Enum&), "System.Int32Enum"}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(InputField), Member = "set_contentType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ContentType)}, ReturnType = typeof(void))]
		 set { } //Length: 104
	}

	private static string clipboard
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(GUIUtility), Member = "get_systemCopyBuffer", ReturnType = typeof(string))]
		private get { } //Length: 64
		[CalledBy(Type = typeof(InputField), Member = "KeyPressed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event)}, ReturnType = typeof(EditState))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(GUIUtility), Member = "set_systemCopyBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		private set { } //Length: 73
	}

	private string compositionString
	{
		[CallerCount(Count = 118)]
		[Calls(Type = typeof(InputField), Member = "get_input", ReturnType = typeof(BaseInput))]
		[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Input), Member = "get_compositionString", ReturnType = typeof(string))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		private get { } //Length: 159
	}

	public ContentType contentType
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 7
		[CalledBy(Type = typeof(InputField), Member = "set_lineType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LineType)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InputField), Member = "set_inputType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputType)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InputField), Member = "set_keyboardType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TouchScreenKeyboardType)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InputField), Member = "set_characterValidation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CharacterValidation)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InputField), Member = "SetToCustomIfContentTypeIsNot", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ContentType[])}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InputField), Member = "SetToCustom", ReturnType = typeof(void))]
		[CallerCount(Count = 6)]
		[Calls(Type = typeof(SetPropertyUtility), Member = "SetStruct", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"System.Int32Enum"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32Enum&), "System.Int32Enum"}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Text), Member = "set_horizontalOverflow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HorizontalWrapMode)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 2)]
		 set { } //Length: 528
	}

	public bool customCaretColor
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 8
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CanvasUpdateRegistry), Member = "RegisterCanvasElementForGraphicRebuild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ICanvasElement)}, ReturnType = typeof(void))]
		 set { } //Length: 93
	}

	public override float flexibleHeight
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 9
	}

	public override float flexibleWidth
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 9
	}

	private bool hasSelection
	{
		[CalledBy(Type = typeof(<CaretBlink>d__170), Member = "MoveNext", ReturnType = typeof(bool))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(InputField), Member = "get_compositionString", ReturnType = typeof(string))]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		private get { } //Length: 81
	}

	private BaseInput input
	{
		[CalledBy(Type = typeof(InputField), Member = "get_compositionString", ReturnType = typeof(string))]
		[CalledBy(Type = typeof(InputField), Member = "GenerateCaret", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexHelper), typeof(Vector2)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InputField), Member = "ActivateInputFieldInternal", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InputField), Member = "DeactivateInputField", ReturnType = typeof(void))]
		[CallerCount(Count = 10)]
		[Calls(Type = typeof(EventSystem), Member = "get_current", ReturnType = typeof(EventSystem))]
		[Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(BaseInputModule), Member = "get_input", ReturnType = typeof(BaseInput))]
		[CallsUnknownMethods(Count = 1)]
		private get { } //Length: 251
	}

	public InputType inputType
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 7
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SetPropertyUtility), Member = "SetStruct", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"System.Int32Enum"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32Enum&), "System.Int32Enum"}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(InputField), Member = "set_contentType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ContentType)}, ReturnType = typeof(void))]
		 set { } //Length: 104
	}

	public bool isFocused
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 8
	}

	public TouchScreenKeyboardType keyboardType
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 7
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SetPropertyUtility), Member = "SetStruct", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"System.Int32Enum"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32Enum&), "System.Int32Enum"}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(InputField), Member = "set_contentType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ContentType)}, ReturnType = typeof(void))]
		 set { } //Length: 104
	}

	public override int layoutPriority
	{
		[CallerCount(Count = 9)]
		[DeduplicatedMethod]
		 get { } //Length: 6
	}

	public LineType lineType
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 7
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SetPropertyUtility), Member = "SetStruct", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"System.Int32Enum"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32Enum&), "System.Int32Enum"}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(InputField), Member = "set_contentType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ContentType)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(InputField), Member = "EnforceTextHOverflow", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 2)]
		 set { } //Length: 215
	}

	protected Mesh mesh
	{
		[CalledBy(Type = typeof(InputField), Member = "LateUpdate", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InputField), Member = "UpdateGeometry", ReturnType = typeof(void))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Mesh), Member = ".ctor", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 163
	}

	public override float minHeight
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 4
	}

	public override float minWidth
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 9
	}

	public bool multiLine
	{
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 23
	}

	public EndEditEvent onEndEdit
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 8
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		 set { } //Length: 76
	}

	public SubmitEvent onSubmit
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 8
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		 set { } //Length: 76
	}

	public OnValidateInput onValidateInput
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 8
		[CalledBy(Type = "SimpleFileBrowser.FileBrowser", Member = "Awake", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		 set { } //Length: 76
	}

	[Obsolete("onValueChange has been renamed to onValueChanged")]
	public OnChangeEvent onValueChange
	{
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(SemaphoreSlim), Member = "Release", ReturnType = typeof(int))]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 96
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		 set { } //Length: 76
	}

	public OnChangeEvent onValueChanged
	{
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(SemaphoreSlim), Member = "Release", ReturnType = typeof(int))]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 96
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		 set { } //Length: 76
	}

	public Graphic placeholder
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 8
		[CalledBy(Type = typeof(DefaultControls), Member = "CreateInputField", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Resources)}, ReturnType = typeof(GameObject))]
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		 set { } //Length: 76
	}

	public override float preferredHeight
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Graphic), Member = "get_rectTransform", ReturnType = typeof(RectTransform))]
		[Calls(Type = typeof(RectTransform), Member = "get_rect", ReturnType = typeof(Rect))]
		[Calls(Type = typeof(Text), Member = "GetGenerationSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(TextGenerationSettings))]
		[Calls(Type = typeof(Text), Member = "get_cachedTextGeneratorForLayout", ReturnType = typeof(TextGenerator))]
		[Calls(Type = typeof(TextGenerator), Member = "GetPreferredHeight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(TextGenerationSettings)}, ReturnType = typeof(float))]
		[Calls(Type = typeof(Text), Member = "get_pixelsPerUnit", ReturnType = typeof(float))]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 470
	}

	public override float preferredWidth
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Text), Member = "GetGenerationSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(TextGenerationSettings))]
		[Calls(Type = typeof(Text), Member = "get_cachedTextGeneratorForLayout", ReturnType = typeof(TextGenerator))]
		[Calls(Type = typeof(TextGenerator), Member = "GetPreferredWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(TextGenerationSettings)}, ReturnType = typeof(float))]
		[Calls(Type = typeof(Text), Member = "get_pixelsPerUnit", ReturnType = typeof(float))]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 460
	}

	public bool readOnly
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 8
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 set { } //Length: 7
	}

	public int selectionAnchorPosition
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InputField), Member = "get_compositionString", ReturnType = typeof(string))]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 40
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InputField), Member = "get_compositionString", ReturnType = typeof(string))]
		[CallsUnknownMethods(Count = 1)]
		 set { } //Length: 106
	}

	public Color selectionColor
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 14
		[CalledBy(Type = "SimpleFileBrowser.UISkin", Member = "ApplyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputField)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CanvasUpdateRegistry), Member = "RegisterCanvasElementForGraphicRebuild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ICanvasElement)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		 set { } //Length: 111
	}

	public int selectionFocusPosition
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InputField), Member = "get_compositionString", ReturnType = typeof(string))]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 40
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InputField), Member = "get_compositionString", ReturnType = typeof(string))]
		[CallsUnknownMethods(Count = 1)]
		 set { } //Length: 106
	}

	public override bool shouldActivateOnSelect
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Application), Member = "get_platform", ReturnType = typeof(RuntimePlatform))]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 94
		[CallerCount(Count = 0)]
		 set { } //Length: 7
	}

	public bool shouldHideMobileInput
	{
		[CalledBy(Type = typeof(InputField), Member = "ActivateInputFieldInternal", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Application), Member = "get_platform", ReturnType = typeof(RuntimePlatform))]
		 get { } //Length: 95
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SetPropertyUtility), Member = "SetStruct", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", "T"}, ReturnType = typeof(bool))]
		 set { } //Length: 76
	}

	public string text
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 8
		[CalledBy(Type = "SimpleFileBrowser.FileBrowser+<>c__DisplayClass227_0", Member = "<RenameSelectedFile>b__0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CalledBy(Type = "SimpleFileBrowser.FileBrowser+<CreateNewFolderCoroutine>d__226", Member = "MoveNext", ReturnType = typeof(bool))]
		[CalledBy(Type = "SimpleFileBrowser.FileBrowser", Member = "set_CurrentPath", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CalledBy(Type = "SimpleFileBrowser.FileBrowser", Member = "set_SearchString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CalledBy(Type = "SimpleFileBrowser.FileBrowser", Member = "OnSearchStringChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CalledBy(Type = "SimpleFileBrowser.FileBrowser", Member = "Show", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
		[CalledBy(Type = "SimpleFileBrowser.FileBrowser", Member = "RefreshFiles", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = "SimpleFileBrowser.FileBrowser", Member = "DeselectAllFiles", ReturnType = typeof(void))]
		[CalledBy(Type = "SimpleFileBrowser.FileBrowser", Member = "UpdateFilenameInputFieldWithSelection", ReturnType = typeof(void))]
		[CalledBy(Type = "SimpleFileBrowser.FileBrowser", Member = "<CreateNewFolderCoroutine>b__226_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CalledBy(Type = "SimpleFileBrowser.FileBrowserRenamedItem", Member = "Show", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Color), typeof(Sprite), "SimpleFileBrowser.FileBrowserRenamedItem+OnRenameCompleted"}, ReturnType = typeof(void))]
		[CallerCount(Count = 15)]
		[Calls(Type = typeof(InputField), Member = "SetText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(void))]
		 set { } //Length: 11
	}

	public Text textComponent
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 8
		[CalledBy(Type = typeof(DefaultControls), Member = "CreateInputField", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Resources)}, ReturnType = typeof(GameObject))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Graphic), Member = "UnregisterDirtyVerticesCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityAction)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Graphic), Member = "UnregisterDirtyMaterialCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityAction)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(InputField), Member = "EnforceTextHOverflow", ReturnType = typeof(void))]
		[Calls(Type = typeof(Graphic), Member = "RegisterDirtyVerticesCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityAction)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Graphic), Member = "RegisterDirtyMaterialCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityAction)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 7)]
		[CallsUnknownMethods(Count = 1)]
		 set { } //Length: 666
	}

	public TouchScreenKeyboard touchScreenKeyboard
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 8
	}

	public bool wasCanceled
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 8
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(RuntimeFieldHandle)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private static InputField() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Event), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(Selectable), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(InputField), Member = "EnforceTextHOverflow", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 6)]
	protected InputField() { }

	[CalledBy(Type = typeof(InputField), Member = "OnSelect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputField), Member = "OnPointerClick", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = "SimpleFileBrowser.FileBrowserRenamedItem", Member = "Show", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Color), typeof(Sprite), "SimpleFileBrowser.FileBrowserRenamedItem+OnRenameCompleted"}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Text), Member = "get_font", ReturnType = typeof(Font))]
	[Calls(Type = typeof(TouchScreenKeyboard), Member = "get_active", ReturnType = typeof(bool))]
	[Calls(Type = typeof(TouchScreenKeyboard), Member = "set_active", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TouchScreenKeyboard), Member = "set_text", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public void ActivateInputField() { }

	[CalledBy(Type = typeof(InputField), Member = "LateUpdate", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TouchScreenKeyboard), Member = "get_isSupported", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Time), Member = "get_unscaledTime", ReturnType = typeof(float))]
	[Calls(Type = typeof(InputField), Member = "SelectAll", ReturnType = typeof(void))]
	[Calls(Type = typeof(InputField), Member = "MoveTextEnd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TouchScreenKeyboard), Member = "Open", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(TouchScreenKeyboardType), typeof(bool), typeof(bool), typeof(bool), typeof(bool), typeof(string), typeof(int)}, ReturnType = typeof(TouchScreenKeyboard))]
	[Calls(Type = typeof(TouchScreenKeyboard), Member = "set_hideInput", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputField), Member = "get_shouldHideMobileInput", ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputField), Member = "get_input", ReturnType = typeof(BaseInput))]
	[Calls(Type = typeof(Application), Member = "get_platform", ReturnType = typeof(RuntimePlatform))]
	[Calls(Type = typeof(InputField), Member = "SetCaretActive", ReturnType = typeof(void))]
	[Calls(Type = typeof(TouchScreenKeyboard), Member = "get_isInPlaceEditingAllowed", ReturnType = typeof(bool))]
	[Calls(Type = typeof(EventSystem), Member = "SetSelectedGameObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(EventSystem), Member = "get_current", ReturnType = typeof(EventSystem))]
	[Calls(Type = typeof(InputField), Member = "UpdateLabel", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	private void ActivateInputFieldInternal() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TouchScreenKeyboard), Member = "get_isSupported", ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	protected override void Append(string input) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(char), Member = "IsSurrogate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TouchScreenKeyboard), Member = "get_isSupported", ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputField), Member = "get_compositionString", ReturnType = typeof(string))]
	[Calls(Type = typeof(Math), Member = "Min", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(InputField), Member = "Validate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(char)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(InputField), Member = "Delete", ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Insert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(TouchScreenKeyboard), Member = "set_text", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputField), Member = "SendOnValueChanged", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	protected override void Append(char input) { }

	[CalledBy(Type = typeof(InputField), Member = "LateUpdate", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputField), Member = "UpdateGeometry", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(RectTransform), Member = "get_anchoredPosition", ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(RectTransform), Member = "set_anchorMax", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RectTransform), Member = "set_anchorMin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Transform), Member = "set_localScale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Transform), Member = "set_localRotation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Transform), Member = "set_localPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RectTransform), Member = "get_pivot", ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(RectTransform), Member = "get_sizeDelta", ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(RectTransform), Member = "get_anchorMax", ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(RectTransform), Member = "set_anchoredPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RectTransform), Member = "get_anchorMin", ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(Transform), Member = "get_localScale", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Transform), Member = "get_localRotation", ReturnType = typeof(Quaternion))]
	[Calls(Type = typeof(Graphic), Member = "get_rectTransform", ReturnType = typeof(RectTransform))]
	[Calls(Type = typeof(Transform), Member = "get_localPosition", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(RectTransform), Member = "set_pivot", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RectTransform), Member = "set_sizeDelta", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private void AssignPositioningIfNeeded() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputField), Member = "get_compositionString", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(InputField), Member = "set_caretPositionInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputField), Member = "set_caretSelectPositionInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputField), Member = "UpdateTouchKeyboardFromEditChanges", ReturnType = typeof(void))]
	[Calls(Type = typeof(InputField), Member = "Delete", ReturnType = typeof(void))]
	[Calls(Type = typeof(TouchScreenKeyboard), Member = "get_isSupported", ReturnType = typeof(bool))]
	[Calls(Type = typeof(TouchScreenKeyboard), Member = "set_text", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputField), Member = "SendOnValueChanged", ReturnType = typeof(void))]
	[Calls(Type = typeof(InputField), Member = "UpdateLabel", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	private void Backspace() { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	public override void CalculateLayoutInputHorizontal() { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	public override void CalculateLayoutInputVertical() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[IteratorStateMachine(typeof(<CaretBlink>d__170))]
	private IEnumerator CaretBlink() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	protected void ClampPos(ref int pos) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 3)]
	private void CreateCursorVerts() { }

	[CalledBy(Type = typeof(InputField), Member = "OnDisable", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputField), Member = "LateUpdate", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputField), Member = "OnUpdateSelected", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputField), Member = "OnDeselect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = "SimpleFileBrowser.FileBrowserRenamedItem", Member = "LateUpdate", ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CanvasUpdateRegistry), Member = "RegisterCanvasElementForGraphicRebuild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ICanvasElement)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputField), Member = "get_input", ReturnType = typeof(BaseInput))]
	[Calls(Type = typeof(TouchScreenKeyboard), Member = "set_active", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UnityEngine.Events.UnityEvent`1<System.Object>), Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Behaviour), Member = "set_enabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputField), Member = "SetText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(UISystemProfilerApi), Member = "AddMarker", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public void DeactivateInputField() { }

	[CalledBy(Type = typeof(InputField), Member = "KeyPressed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event)}, ReturnType = typeof(EditState))]
	[CalledBy(Type = typeof(InputField), Member = "ForwardSpace", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputField), Member = "Backspace", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputField), Member = "Insert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputField), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(InputField), Member = "get_compositionString", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 3)]
	private void Delete() { }

	[CalledBy(Type = typeof(InputField), Member = "LineUpCharacterPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(InputField), Member = "LineDownCharacterPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(InputField), Member = "SetDrawRangeToContainCaretPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputField), Member = "GenerateCaret", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexHelper), typeof(Vector2)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputField), Member = "GenerateHighlight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexHelper), typeof(Vector2)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(TextGenerator), Member = "get_lineCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(TextGenerator), Member = "get_lines", ReturnType = typeof(System.Collections.Generic.IList`1<UnityEngine.UILineInfo>))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private int DetermineCharacterLine(int charPos, TextGenerator generator) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Selectable), Member = "DoStateTransition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SelectionState), typeof(bool)}, ReturnType = typeof(void))]
	protected virtual void DoStateTransition(SelectionState state, bool instant) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Text), Member = "set_horizontalOverflow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HorizontalWrapMode)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	private void EnforceContentType() { }

	[CalledBy(Type = typeof(InputField), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputField), Member = "set_textComponent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Text)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputField), Member = "set_lineType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LineType)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Text), Member = "set_horizontalOverflow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HorizontalWrapMode)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private void EnforceTextHOverflow() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputField), Member = "get_compositionString", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "IndexOfAny", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int)}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 1)]
	private int FindtNextWordBegin() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputField), Member = "get_compositionString", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "LastIndexOfAny", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int)}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 1)]
	private int FindtPrevWordBegin() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputField), Member = "UpdateLabel", ReturnType = typeof(void))]
	public void ForceLabelUpdate() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputField), Member = "get_compositionString", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(InputField), Member = "UpdateTouchKeyboardFromEditChanges", ReturnType = typeof(void))]
	[Calls(Type = typeof(InputField), Member = "Delete", ReturnType = typeof(void))]
	[Calls(Type = typeof(TouchScreenKeyboard), Member = "get_isSupported", ReturnType = typeof(bool))]
	[Calls(Type = typeof(TouchScreenKeyboard), Member = "set_text", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputField), Member = "SendOnValueChanged", ReturnType = typeof(void))]
	[Calls(Type = typeof(InputField), Member = "UpdateLabel", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	private void ForwardSpace() { }

	[CalledBy(Type = typeof(InputField), Member = "OnFillVBO", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mesh)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(VertexHelper), Member = "AddUIVertexQuad", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UIVertex[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RectTransformUtility), Member = "WorldToScreenPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(Vector3)}, ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(Transform), Member = "TransformPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(GameObject), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(Canvas), Member = "get_worldCamera", ReturnType = typeof(Camera))]
	[Calls(Type = typeof(Canvas), Member = "get_renderMode", ReturnType = typeof(RenderMode))]
	[Calls(Type = typeof(Display), Member = "get_renderingHeight", ReturnType = typeof(int))]
	[Calls(Type = typeof(Canvas), Member = "get_targetDisplay", ReturnType = typeof(int))]
	[Calls(Type = typeof(Graphic), Member = "get_canvas", ReturnType = typeof(Canvas))]
	[Calls(Type = typeof(Screen), Member = "get_height", ReturnType = typeof(int))]
	[Calls(Type = typeof(TextGenerator), Member = "get_lines", ReturnType = typeof(System.Collections.Generic.IList`1<UnityEngine.UILineInfo>))]
	[Calls(Type = typeof(InputField), Member = "get_input", ReturnType = typeof(BaseInput))]
	[Calls(Type = typeof(InputField), Member = "DetermineCharacterLine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(TextGenerator)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(RectTransform), Member = "get_rect", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(Graphic), Member = "get_rectTransform", ReturnType = typeof(RectTransform))]
	[Calls(Type = typeof(Text), Member = "get_pixelsPerUnit", ReturnType = typeof(float))]
	[Calls(Type = typeof(TextGenerator), Member = "get_characters", ReturnType = typeof(System.Collections.Generic.IList`1<UnityEngine.UICharInfo>))]
	[Calls(Type = "UnityEngine.Rendering.MousePositionDebug", Member = "GetMouseClickPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(TextGenerator), Member = "get_lineCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(Text), Member = "get_cachedTextGenerator", ReturnType = typeof(TextGenerator))]
	[Calls(Type = typeof(InputField), Member = "get_compositionString", ReturnType = typeof(string))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 11)]
	[ContainsUnimplementedInstructions]
	private void GenerateCaret(VertexHelper vbo, Vector2 roundingOffset) { }

	[CalledBy(Type = typeof(InputField), Member = "OnFillVBO", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mesh)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(VertexHelper), Member = "AddVert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UIVertex)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VertexHelper), Member = "get_currentVertCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(RectTransform), Member = "get_rect", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(Graphic), Member = "get_rectTransform", ReturnType = typeof(RectTransform))]
	[Calls(Type = typeof(TextGenerator), Member = "get_lines", ReturnType = typeof(System.Collections.Generic.IList`1<UnityEngine.UILineInfo>))]
	[Calls(Type = typeof(Text), Member = "get_pixelsPerUnit", ReturnType = typeof(float))]
	[Calls(Type = typeof(TextGenerator), Member = "get_characters", ReturnType = typeof(System.Collections.Generic.IList`1<UnityEngine.UICharInfo>))]
	[Calls(Type = typeof(TextGenerator), Member = "get_characterCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(Color32), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(Color32))]
	[Calls(Type = typeof(InputField), Member = "GetLineEndPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextGenerator), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(InputField), Member = "DetermineCharacterLine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(TextGenerator)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(TextGenerator), Member = "get_lineCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(Text), Member = "get_cachedTextGenerator", ReturnType = typeof(TextGenerator))]
	[Calls(Type = typeof(InputField), Member = "get_compositionString", ReturnType = typeof(string))]
	[Calls(Type = typeof(VertexHelper), Member = "AddTriangle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	private void GenerateHighlight(VertexHelper vbo, Vector2 roundingOffset) { }

	[CallerCount(Count = 0)]
	public char get_asteriskChar() { }

	[CalledBy(Type = typeof(InputField), Member = "LineUpCharacterPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(InputField), Member = "LineDownCharacterPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(InputField), Member = "UpdateLabel", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputField), Member = "SetDrawRangeToContainCaretPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 29)]
	[Calls(Type = typeof(TextGenerator), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	protected TextGenerator get_cachedInputTextGenerator() { }

	[CallerCount(Count = 0)]
	public float get_caretBlinkRate() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public Color get_caretColor() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputField), Member = "get_compositionString", ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public int get_caretPosition() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputField), Member = "get_compositionString", ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	protected int get_caretPositionInternal() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputField), Member = "get_compositionString", ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	protected int get_caretSelectPositionInternal() { }

	[CallerCount(Count = 0)]
	public int get_caretWidth() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public int get_characterLimit() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public CharacterValidation get_characterValidation() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GUIUtility), Member = "get_systemCopyBuffer", ReturnType = typeof(string))]
	private static string get_clipboard() { }

	[CallerCount(Count = 118)]
	[Calls(Type = typeof(InputField), Member = "get_input", ReturnType = typeof(BaseInput))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Input), Member = "get_compositionString", ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private string get_compositionString() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public ContentType get_contentType() { }

	[CallerCount(Count = 0)]
	public bool get_customCaretColor() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public override float get_flexibleHeight() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public override float get_flexibleWidth() { }

	[CalledBy(Type = typeof(<CaretBlink>d__170), Member = "MoveNext", ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InputField), Member = "get_compositionString", ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private bool get_hasSelection() { }

	[CalledBy(Type = typeof(InputField), Member = "get_compositionString", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(InputField), Member = "GenerateCaret", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexHelper), typeof(Vector2)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputField), Member = "ActivateInputFieldInternal", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputField), Member = "DeactivateInputField", ReturnType = typeof(void))]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(EventSystem), Member = "get_current", ReturnType = typeof(EventSystem))]
	[Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BaseInputModule), Member = "get_input", ReturnType = typeof(BaseInput))]
	[CallsUnknownMethods(Count = 1)]
	private BaseInput get_input() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public InputType get_inputType() { }

	[CallerCount(Count = 0)]
	public bool get_isFocused() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public TouchScreenKeyboardType get_keyboardType() { }

	[CallerCount(Count = 9)]
	[DeduplicatedMethod]
	public override int get_layoutPriority() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public LineType get_lineType() { }

	[CalledBy(Type = typeof(InputField), Member = "LateUpdate", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputField), Member = "UpdateGeometry", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Mesh), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	protected Mesh get_mesh() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public override float get_minHeight() { }

	[CallerCount(Count = 0)]
	public override float get_minWidth() { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public bool get_multiLine() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public EndEditEvent get_onEndEdit() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public SubmitEvent get_onSubmit() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public OnValidateInput get_onValidateInput() { }

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SemaphoreSlim), Member = "Release", ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public OnChangeEvent get_onValueChange() { }

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SemaphoreSlim), Member = "Release", ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public OnChangeEvent get_onValueChanged() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public Graphic get_placeholder() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Graphic), Member = "get_rectTransform", ReturnType = typeof(RectTransform))]
	[Calls(Type = typeof(RectTransform), Member = "get_rect", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(Text), Member = "GetGenerationSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(TextGenerationSettings))]
	[Calls(Type = typeof(Text), Member = "get_cachedTextGeneratorForLayout", ReturnType = typeof(TextGenerator))]
	[Calls(Type = typeof(TextGenerator), Member = "GetPreferredHeight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(TextGenerationSettings)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(Text), Member = "get_pixelsPerUnit", ReturnType = typeof(float))]
	[CallsUnknownMethods(Count = 1)]
	public override float get_preferredHeight() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Text), Member = "GetGenerationSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(TextGenerationSettings))]
	[Calls(Type = typeof(Text), Member = "get_cachedTextGeneratorForLayout", ReturnType = typeof(TextGenerator))]
	[Calls(Type = typeof(TextGenerator), Member = "GetPreferredWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(TextGenerationSettings)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(Text), Member = "get_pixelsPerUnit", ReturnType = typeof(float))]
	[CallsUnknownMethods(Count = 1)]
	public override float get_preferredWidth() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public bool get_readOnly() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputField), Member = "get_compositionString", ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public int get_selectionAnchorPosition() { }

	[CallerCount(Count = 0)]
	public Color get_selectionColor() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputField), Member = "get_compositionString", ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public int get_selectionFocusPosition() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Application), Member = "get_platform", ReturnType = typeof(RuntimePlatform))]
	[ContainsUnimplementedInstructions]
	public override bool get_shouldActivateOnSelect() { }

	[CalledBy(Type = typeof(InputField), Member = "ActivateInputFieldInternal", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Application), Member = "get_platform", ReturnType = typeof(RuntimePlatform))]
	public bool get_shouldHideMobileInput() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public string get_text() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public Text get_textComponent() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public TouchScreenKeyboard get_touchScreenKeyboard() { }

	[CallerCount(Count = 0)]
	public bool get_wasCanceled() { }

	[CalledBy(Type = typeof(InputField), Member = "OnDrag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputField), Member = "OnPointerDown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Text), Member = "get_cachedTextGenerator", ReturnType = typeof(TextGenerator))]
	[Calls(Type = typeof(TextGenerator), Member = "get_lineCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(InputField), Member = "GetUnclampedCharacterLineFromPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(TextGenerator)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(TextGenerator), Member = "get_lines", ReturnType = typeof(System.Collections.Generic.IList`1<UnityEngine.UILineInfo>))]
	[Calls(Type = typeof(InputField), Member = "GetLineEndPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextGenerator), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(TextGenerator), Member = "get_characterCountVisible", ReturnType = typeof(int))]
	[Calls(Type = typeof(TextGenerator), Member = "get_characters", ReturnType = typeof(System.Collections.Generic.IList`1<UnityEngine.UICharInfo>))]
	[Calls(Type = typeof(Text), Member = "get_pixelsPerUnit", ReturnType = typeof(float))]
	[CallsUnknownMethods(Count = 3)]
	protected int GetCharacterIndexFromPosition(Vector2 pos) { }

	[CalledBy(Type = typeof(InputField), Member = "UpdateKeyboardCaret", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputField), Member = "LateUpdate", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(InputField), Member = "get_compositionString", ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private RangeInt GetInternalSelection() { }

	[CalledBy(Type = typeof(InputField), Member = "GetCharacterIndexFromPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(InputField), Member = "LineDownCharacterPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(InputField), Member = "SetDrawRangeToContainCaretPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputField), Member = "GenerateHighlight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexHelper), typeof(Vector2)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(TextGenerator), Member = "get_lines", ReturnType = typeof(System.Collections.Generic.IList`1<UnityEngine.UILineInfo>))]
	[Calls(Type = typeof(TextGenerator), Member = "get_characterCountVisible", ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private static int GetLineEndPosition(TextGenerator gen, int line) { }

	[CalledBy(Type = typeof(InputField), Member = "SetDrawRangeToContainCaretPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(TextGenerator), Member = "get_lines", ReturnType = typeof(System.Collections.Generic.IList`1<UnityEngine.UILineInfo>))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private static int GetLineStartPosition(TextGenerator gen, int line) { }

	[CalledBy(Type = typeof(InputField), Member = "KeyPressed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event)}, ReturnType = typeof(EditState))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InputField), Member = "get_compositionString", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 1)]
	private string GetSelectedString() { }

	[CalledBy(Type = typeof(InputField), Member = "GetCharacterIndexFromPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Text), Member = "get_pixelsPerUnit", ReturnType = typeof(float))]
	[Calls(Type = typeof(TextGenerator), Member = "get_lineCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(TextGenerator), Member = "get_lines", ReturnType = typeof(System.Collections.Generic.IList`1<UnityEngine.UILineInfo>))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private int GetUnclampedCharacterLineFromPosition(Vector2 pos, TextGenerator generator) { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	public override void GraphicUpdateComplete() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TouchScreenKeyboard), Member = "get_isSupported", ReturnType = typeof(bool))]
	private bool InPlaceEditing() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TouchScreenKeyboard), Member = "get_isInPlaceEditingAllowed", ReturnType = typeof(bool))]
	[ContainsUnimplementedInstructions]
	private bool InPlaceEditingChanged() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputField), Member = "Delete", ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Insert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(InputField), Member = "get_compositionString", ReturnType = typeof(string))]
	[Calls(Type = typeof(TouchScreenKeyboard), Member = "get_isSupported", ReturnType = typeof(bool))]
	[Calls(Type = typeof(TouchScreenKeyboard), Member = "set_text", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputField), Member = "SendOnValueChanged", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void Insert(char c) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputField), Member = "get_compositionString", ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 1)]
	private bool IsSelectionVisible() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Text), Member = "get_font", ReturnType = typeof(Font))]
	[Calls(Type = typeof(Font), Member = "HasCharacter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	private bool IsValidChar(char c) { }

	[CalledBy(Type = typeof(InputField), Member = "ProcessEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputField), Member = "OnUpdateSelected", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseEventData)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(InputField), Member = "Delete", ReturnType = typeof(void))]
	[Calls(Type = typeof(TouchScreenKeyboard), Member = "set_text", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Event), Member = "get_modifiers", ReturnType = typeof(EventModifiers))]
	[Calls(Type = typeof(Event), Member = "get_keyCode", ReturnType = typeof(KeyCode))]
	[Calls(Type = typeof(InputField), Member = "GetSelectedString", ReturnType = typeof(string))]
	[Calls(Type = typeof(InputField), Member = "set_clipboard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputField), Member = "UpdateTouchKeyboardFromEditChanges", ReturnType = typeof(void))]
	[Calls(Type = typeof(InputField), Member = "SendOnValueChanged", ReturnType = typeof(void))]
	[Calls(Type = typeof(InputField), Member = "UpdateLabel", ReturnType = typeof(void))]
	[Calls(Type = typeof(InputField), Member = "get_compositionString", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(TouchScreenKeyboard), Member = "get_isSupported", ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsInvalidInstructions]
	[ContainsUnimplementedInstructions]
	protected EditState KeyPressed(Event evt) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputField), Member = "SetText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputField), Member = "SendOnValueChanged", ReturnType = typeof(void))]
	[Calls(Type = typeof(TouchScreenKeyboard), Member = "set_text", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputField), Member = "set_caretPositionInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputField), Member = "set_caretSelectPositionInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(InputField), Member = "SendOnSubmit", ReturnType = typeof(void))]
	[Calls(Type = typeof(InputField), Member = "UpdateLabel", ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(InputField), Member = "Validate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(char)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(InputField), Member = "UpdateCaretFromKeyboard", ReturnType = typeof(void))]
	[Calls(Type = typeof(TouchScreenKeyboard), Member = "get_canGetSelection", ReturnType = typeof(bool))]
	[Calls(Type = typeof(TouchScreenKeyboard), Member = "set_selection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RangeInt)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputField), Member = "GetInternalSelection", ReturnType = typeof(RangeInt))]
	[Calls(Type = typeof(Application), Member = "get_platform", ReturnType = typeof(RuntimePlatform))]
	[Calls(Type = typeof(TouchScreenKeyboard), Member = "get_canSetSelection", ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TouchScreenKeyboard), Member = "get_text", ReturnType = typeof(string))]
	[Calls(Type = typeof(TouchScreenKeyboard), Member = "get_status", ReturnType = typeof(Status))]
	[Calls(Type = typeof(TouchScreenKeyboard), Member = "get_isSupported", ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputField), Member = "DeactivateInputField", ReturnType = typeof(void))]
	[Calls(Type = typeof(CanvasRenderer), Member = "SetMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mesh)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputField), Member = "ActivateInputFieldInternal", ReturnType = typeof(void))]
	[Calls(Type = typeof(VertexHelper), Member = "FillMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mesh)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputField), Member = "get_mesh", ReturnType = typeof(Mesh))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TouchScreenKeyboard), Member = "get_isInPlaceEditingAllowed", ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputField), Member = "AssignPositioningIfNeeded", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 8)]
	protected override void LateUpdate() { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	public override void LayoutComplete() { }

	[CalledBy(Type = typeof(InputField), Member = "MoveDown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InputField), Member = "get_cachedInputTextGenerator", ReturnType = typeof(TextGenerator))]
	[Calls(Type = typeof(TextGenerator), Member = "get_characterCountVisible", ReturnType = typeof(int))]
	[Calls(Type = typeof(TextGenerator), Member = "get_characters", ReturnType = typeof(System.Collections.Generic.IList`1<UnityEngine.UICharInfo>))]
	[Calls(Type = typeof(InputField), Member = "DetermineCharacterLine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(TextGenerator)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(TextGenerator), Member = "get_lineCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(InputField), Member = "GetLineEndPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextGenerator), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(TextGenerator), Member = "get_lines", ReturnType = typeof(System.Collections.Generic.IList`1<UnityEngine.UILineInfo>))]
	[CallsUnknownMethods(Count = 4)]
	private int LineDownCharacterPosition(int originalPos, bool goToLastChar) { }

	[CalledBy(Type = typeof(InputField), Member = "MoveUp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InputField), Member = "get_cachedInputTextGenerator", ReturnType = typeof(TextGenerator))]
	[Calls(Type = typeof(TextGenerator), Member = "get_characters", ReturnType = typeof(System.Collections.Generic.IList`1<UnityEngine.UICharInfo>))]
	[Calls(Type = typeof(InputField), Member = "DetermineCharacterLine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(TextGenerator)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(TextGenerator), Member = "get_lines", ReturnType = typeof(System.Collections.Generic.IList`1<UnityEngine.UILineInfo>))]
	[CallsUnknownMethods(Count = 6)]
	private int LineUpCharacterPosition(int originalPos, bool goToFirstChar) { }

	[CalledBy(Type = typeof(<CaretBlink>d__170), Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(InputField), Member = "UpdateLabel", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CanvasUpdateRegistry), Member = "RegisterCanvasElementForGraphicRebuild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ICanvasElement)}, ReturnType = typeof(void))]
	private void MarkGeometryAsDirty() { }

	[CalledBy(Type = typeof(InputField), Member = "OnBeginDrag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputField), Member = "OnDrag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputField), Member = "OnEndDrag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputField), Member = "OnPointerDown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TouchScreenKeyboard), Member = "get_isSupported", ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	private bool MayDrag(PointerEventData eventData) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[IteratorStateMachine(typeof(<MouseDragOutsideRect>d__194))]
	private IEnumerator MouseDragOutsideRect(PointerEventData eventData) { }

	[CalledBy(Type = typeof(<MouseDragOutsideRect>d__194), Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(InputField), Member = "MoveDown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(InputField), Member = "get_compositionString", ReturnType = typeof(string))]
	[Calls(Type = typeof(InputField), Member = "LineDownCharacterPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 1)]
	private void MoveDown(bool shift, bool goToLastChar) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputField), Member = "MoveDown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	private void MoveDown(bool shift) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputField), Member = "get_compositionString", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "LastIndexOfAny", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int)}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 1)]
	private void MoveLeft(bool shift, bool ctrl) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputField), Member = "get_compositionString", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "IndexOfAny", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int)}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 1)]
	private void MoveRight(bool shift, bool ctrl) { }

	[CalledBy(Type = typeof(InputField), Member = "ActivateInputFieldInternal", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InputField), Member = "get_compositionString", ReturnType = typeof(string))]
	[Calls(Type = typeof(InputField), Member = "UpdateLabel", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void MoveTextEnd(bool shift) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputField), Member = "get_compositionString", ReturnType = typeof(string))]
	[Calls(Type = typeof(InputField), Member = "UpdateLabel", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void MoveTextStart(bool shift) { }

	[CallerCount(Count = 0)]
	[ContainsInvalidInstructions]
	private void MoveUp(bool shift) { }

	[CalledBy(Type = typeof(<MouseDragOutsideRect>d__194), Member = "MoveNext", ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InputField), Member = "get_compositionString", ReturnType = typeof(string))]
	[Calls(Type = typeof(InputField), Member = "LineUpCharacterPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 1)]
	private void MoveUp(bool shift, bool goToFirstChar) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputField), Member = "MayDrag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(bool))]
	public override void OnBeginDrag(PointerEventData eventData) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputField), Member = "get_compositionString", ReturnType = typeof(string))]
	[Calls(Type = typeof(InputField), Member = "DeactivateInputField", ReturnType = typeof(void))]
	[Calls(Type = typeof(Selectable), Member = "OnDeselect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseEventData)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public virtual void OnDeselect(BaseEventData eventData) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CanvasUpdateRegistry), Member = "UnRegisterCanvasElementForRebuild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ICanvasElement)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	protected virtual void OnDestroy() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputField), Member = "DeactivateInputField", ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Graphic), Member = "UnregisterDirtyVerticesCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityAction)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Graphic), Member = "UnregisterDirtyMaterialCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityAction)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CanvasUpdateRegistry), Member = "DisableCanvasElementForRebuild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ICanvasElement)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CanvasRenderer), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "DestroyImmediate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Selectable), Member = "OnDisable", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 3)]
	protected virtual void OnDisable() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputField), Member = "MayDrag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(MultipleDisplayUtilities), Member = "GetRelativeMousePositionForDrag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData), typeof(Vector2&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Graphic), Member = "get_rectTransform", ReturnType = typeof(RectTransform))]
	[Calls(Type = typeof(PointerEventData), Member = "get_pressEventCamera", ReturnType = typeof(Camera))]
	[Calls(Type = typeof(RectTransformUtility), Member = "ScreenPointToLocalPointInRectangle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform), typeof(Vector2), typeof(Camera), typeof(Vector2&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputField), Member = "GetCharacterIndexFromPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CanvasUpdateRegistry), Member = "RegisterCanvasElementForGraphicRebuild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ICanvasElement)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RectTransformUtility), Member = "RectangleContainsScreenPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform), typeof(Vector2), typeof(Camera)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputField), Member = "UpdateKeyboardCaret", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	public override void OnDrag(PointerEventData eventData) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Selectable), Member = "OnEnable", ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Graphic), Member = "get_defaultGraphicMaterial", ReturnType = typeof(Material))]
	[Calls(Type = typeof(Texture2D), Member = "get_whiteTexture", ReturnType = typeof(Texture2D))]
	[Calls(Type = typeof(CanvasRenderer), Member = "SetMaterial", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material), typeof(Texture)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Graphic), Member = "RegisterDirtyVerticesCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityAction)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Graphic), Member = "RegisterDirtyMaterialCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityAction)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputField), Member = "UpdateLabel", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 2)]
	protected virtual void OnEnable() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputField), Member = "MayDrag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(bool))]
	public override void OnEndDrag(PointerEventData eventData) { }

	[CalledBy(Type = typeof(InputField), Member = "UpdateGeometry", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Graphic), Member = "PixelAdjustPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(InputField), Member = "get_compositionString", ReturnType = typeof(string))]
	[Calls(Type = typeof(InputField), Member = "GenerateHighlight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexHelper), typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputField), Member = "GenerateCaret", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexHelper), typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VertexHelper), Member = "FillMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mesh)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 9)]
	private void OnFillVBO(Mesh vbo) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputField), Member = "SelectAll", ReturnType = typeof(void))]
	protected void OnFocus() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputField), Member = "ActivateInputField", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public override void OnPointerClick(PointerEventData eventData) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputField), Member = "MayDrag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(EventSystem), Member = "get_current", ReturnType = typeof(EventSystem))]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(EventSystem), Member = "SetSelectedGameObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(BaseEventData)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Selectable), Member = "OnPointerDown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TouchScreenKeyboard), Member = "get_isSupported", ReturnType = typeof(bool))]
	[Calls(Type = typeof(TouchScreenKeyboard), Member = "get_active", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Graphic), Member = "get_rectTransform", ReturnType = typeof(RectTransform))]
	[Calls(Type = typeof(PointerEventData), Member = "get_pressEventCamera", ReturnType = typeof(Camera))]
	[Calls(Type = typeof(RectTransformUtility), Member = "ScreenPointToLocalPointInRectangle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform), typeof(Vector2), typeof(Camera), typeof(Vector2&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputField), Member = "GetCharacterIndexFromPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(InputField), Member = "UpdateLabel", ReturnType = typeof(void))]
	[Calls(Type = typeof(InputField), Member = "UpdateKeyboardCaret", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public virtual void OnPointerDown(PointerEventData eventData) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Selectable), Member = "OnSelect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseEventData)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputField), Member = "ActivateInputField", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	public virtual void OnSelect(BaseEventData eventData) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public override void OnSubmit(BaseEventData eventData) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Event), Member = "PopEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Event), Member = "get_rawType", ReturnType = typeof(EventType))]
	[Calls(Type = typeof(InputField), Member = "get_compositionString", ReturnType = typeof(string))]
	[Calls(Type = typeof(Event), Member = "get_character", ReturnType = typeof(char))]
	[Calls(Type = typeof(Event), Member = "get_modifiers", ReturnType = typeof(EventModifiers))]
	[Calls(Type = typeof(InputField), Member = "KeyPressed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event)}, ReturnType = typeof(EditState))]
	[Calls(Type = typeof(InputField), Member = "UpdateLabel", ReturnType = typeof(void))]
	[Calls(Type = typeof(Event), Member = "get_type", ReturnType = typeof(EventType))]
	[Calls(Type = typeof(Event), Member = "get_commandName", ReturnType = typeof(string))]
	[Calls(Type = typeof(InputField), Member = "SelectAll", ReturnType = typeof(void))]
	[Calls(Type = typeof(InputField), Member = "SendOnSubmit", ReturnType = typeof(void))]
	[Calls(Type = typeof(InputField), Member = "DeactivateInputField", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public override void OnUpdateSelected(BaseEventData eventData) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputField), Member = "KeyPressed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event)}, ReturnType = typeof(EditState))]
	public void ProcessEvent(Event e) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputField), Member = "UpdateGeometry", ReturnType = typeof(void))]
	public override void Rebuild(CanvasUpdate update) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Graphic), Member = "get_canvas", ReturnType = typeof(Canvas))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Canvas), Member = "get_renderMode", ReturnType = typeof(RenderMode))]
	[Calls(Type = typeof(Canvas), Member = "get_worldCamera", ReturnType = typeof(Camera))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Camera), Member = "ScreenPointToRay", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Ray))]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Transform), Member = "get_forward", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Transform), Member = "get_position", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Ray), Member = "GetPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Transform), Member = "InverseTransformPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Obsolete("This function is no longer used. Please use RectTransformUtility.ScreenPointToLocalPointInRectangle() instead.")]
	public Vector2 ScreenToLocal(Vector2 screen) { }

	[CalledBy(Type = typeof(InputField), Member = "OnFocus", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputField), Member = "OnUpdateSelected", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputField), Member = "ActivateInputFieldInternal", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	protected void SelectAll() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UISystemProfilerApi), Member = "AddMarker", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UnityEngine.Events.UnityEvent`1<System.Object>), Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	protected void SendOnEndEdit() { }

	[CalledBy(Type = typeof(InputField), Member = "LateUpdate", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputField), Member = "OnUpdateSelected", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseEventData)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UISystemProfilerApi), Member = "AddMarker", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UnityEngine.Events.UnityEvent`1<System.Object>), Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	protected void SendOnSubmit() { }

	[CalledBy(Type = typeof(InputField), Member = "LateUpdate", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputField), Member = "KeyPressed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event)}, ReturnType = typeof(EditState))]
	[CalledBy(Type = typeof(InputField), Member = "ForwardSpace", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputField), Member = "Backspace", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputField), Member = "Insert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputField), Member = "SendOnValueChangedAndUpdateLabel", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputField), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(UISystemProfilerApi), Member = "AddMarker", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UnityEngine.Events.UnityEvent`1<System.Object>), Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	private void SendOnValueChanged() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputField), Member = "SendOnValueChanged", ReturnType = typeof(void))]
	[Calls(Type = typeof(InputField), Member = "UpdateLabel", ReturnType = typeof(void))]
	private void SendOnValueChangedAndUpdateLabel() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SetPropertyUtility), Member = "SetStruct", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char&), typeof(char)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputField), Member = "UpdateLabel", ReturnType = typeof(void))]
	public void set_asteriskChar(char value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SetPropertyUtility), Member = "SetStruct", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Single&), typeof(float)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputField), Member = "SetCaretActive", ReturnType = typeof(void))]
	public void set_caretBlinkRate(float value) { }

	[CalledBy(Type = "SimpleFileBrowser.UISkin", Member = "ApplyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputField)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CanvasUpdateRegistry), Member = "RegisterCanvasElementForGraphicRebuild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ICanvasElement)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	public void set_caretColor(Color value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputField), Member = "get_compositionString", ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 1)]
	public void set_caretPosition(int value) { }

	[CalledBy(Type = typeof(InputField), Member = "LateUpdate", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputField), Member = "Backspace", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	protected void set_caretPositionInternal(int value) { }

	[CalledBy(Type = typeof(InputField), Member = "LateUpdate", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputField), Member = "Backspace", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	protected void set_caretSelectPositionInternal(int value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SetPropertyUtility), Member = "SetStruct", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&), typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CanvasUpdateRegistry), Member = "RegisterCanvasElementForGraphicRebuild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ICanvasElement)}, ReturnType = typeof(void))]
	public void set_caretWidth(int value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Math), Member = "Max", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(SetPropertyUtility), Member = "SetStruct", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&), typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputField), Member = "UpdateLabel", ReturnType = typeof(void))]
	[Calls(Type = typeof(TouchScreenKeyboard), Member = "set_characterLimit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	public void set_characterLimit(int value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SetPropertyUtility), Member = "SetStruct", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"System.Int32Enum"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32Enum&), "System.Int32Enum"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputField), Member = "set_contentType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ContentType)}, ReturnType = typeof(void))]
	public void set_characterValidation(CharacterValidation value) { }

	[CalledBy(Type = typeof(InputField), Member = "KeyPressed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event)}, ReturnType = typeof(EditState))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GUIUtility), Member = "set_systemCopyBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	private static void set_clipboard(string value) { }

	[CalledBy(Type = typeof(InputField), Member = "set_lineType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LineType)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputField), Member = "set_inputType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputType)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputField), Member = "set_keyboardType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TouchScreenKeyboardType)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputField), Member = "set_characterValidation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CharacterValidation)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputField), Member = "SetToCustomIfContentTypeIsNot", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ContentType[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputField), Member = "SetToCustom", ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(SetPropertyUtility), Member = "SetStruct", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"System.Int32Enum"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32Enum&), "System.Int32Enum"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Text), Member = "set_horizontalOverflow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HorizontalWrapMode)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	public void set_contentType(ContentType value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CanvasUpdateRegistry), Member = "RegisterCanvasElementForGraphicRebuild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ICanvasElement)}, ReturnType = typeof(void))]
	public void set_customCaretColor(bool value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SetPropertyUtility), Member = "SetStruct", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"System.Int32Enum"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32Enum&), "System.Int32Enum"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputField), Member = "set_contentType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ContentType)}, ReturnType = typeof(void))]
	public void set_inputType(InputType value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SetPropertyUtility), Member = "SetStruct", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"System.Int32Enum"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32Enum&), "System.Int32Enum"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputField), Member = "set_contentType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ContentType)}, ReturnType = typeof(void))]
	public void set_keyboardType(TouchScreenKeyboardType value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SetPropertyUtility), Member = "SetStruct", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"System.Int32Enum"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32Enum&), "System.Int32Enum"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputField), Member = "set_contentType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ContentType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputField), Member = "EnforceTextHOverflow", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	public void set_lineType(LineType value) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void set_onEndEdit(EndEditEvent value) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void set_onSubmit(SubmitEvent value) { }

	[CalledBy(Type = "SimpleFileBrowser.FileBrowser", Member = "Awake", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void set_onValidateInput(OnValidateInput value) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public void set_onValueChange(OnChangeEvent value) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public void set_onValueChanged(OnChangeEvent value) { }

	[CalledBy(Type = typeof(DefaultControls), Member = "CreateInputField", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Resources)}, ReturnType = typeof(GameObject))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void set_placeholder(Graphic value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void set_readOnly(bool value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputField), Member = "get_compositionString", ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 1)]
	public void set_selectionAnchorPosition(int value) { }

	[CalledBy(Type = "SimpleFileBrowser.UISkin", Member = "ApplyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputField)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CanvasUpdateRegistry), Member = "RegisterCanvasElementForGraphicRebuild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ICanvasElement)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	public void set_selectionColor(Color value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputField), Member = "get_compositionString", ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 1)]
	public void set_selectionFocusPosition(int value) { }

	[CallerCount(Count = 0)]
	public override void set_shouldActivateOnSelect(bool value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SetPropertyUtility), Member = "SetStruct", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", "T"}, ReturnType = typeof(bool))]
	public void set_shouldHideMobileInput(bool value) { }

	[CalledBy(Type = "SimpleFileBrowser.FileBrowser+<>c__DisplayClass227_0", Member = "<RenameSelectedFile>b__0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = "SimpleFileBrowser.FileBrowser+<CreateNewFolderCoroutine>d__226", Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = "SimpleFileBrowser.FileBrowser", Member = "set_CurrentPath", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = "SimpleFileBrowser.FileBrowser", Member = "set_SearchString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = "SimpleFileBrowser.FileBrowser", Member = "OnSearchStringChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = "SimpleFileBrowser.FileBrowser", Member = "Show", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = "SimpleFileBrowser.FileBrowser", Member = "RefreshFiles", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "SimpleFileBrowser.FileBrowser", Member = "DeselectAllFiles", ReturnType = typeof(void))]
	[CalledBy(Type = "SimpleFileBrowser.FileBrowser", Member = "UpdateFilenameInputFieldWithSelection", ReturnType = typeof(void))]
	[CalledBy(Type = "SimpleFileBrowser.FileBrowser", Member = "<CreateNewFolderCoroutine>b__226_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = "SimpleFileBrowser.FileBrowserRenamedItem", Member = "Show", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Color), typeof(Sprite), "SimpleFileBrowser.FileBrowserRenamedItem+OnRenameCompleted"}, ReturnType = typeof(void))]
	[CallerCount(Count = 15)]
	[Calls(Type = typeof(InputField), Member = "SetText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	public void set_text(string value) { }

	[CalledBy(Type = typeof(DefaultControls), Member = "CreateInputField", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Resources)}, ReturnType = typeof(GameObject))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Graphic), Member = "UnregisterDirtyVerticesCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityAction)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Graphic), Member = "UnregisterDirtyMaterialCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityAction)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputField), Member = "EnforceTextHOverflow", ReturnType = typeof(void))]
	[Calls(Type = typeof(Graphic), Member = "RegisterDirtyVerticesCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityAction)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Graphic), Member = "RegisterDirtyMaterialCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityAction)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 1)]
	public void set_textComponent(Text value) { }

	[CalledBy(Type = typeof(InputField), Member = "set_caretBlinkRate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputField), Member = "SetCaretVisible", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputField), Member = "ActivateInputFieldInternal", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	private void SetCaretActive() { }

	[CalledBy(Type = typeof(InputField), Member = "UpdateLabel", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Time), Member = "get_unscaledTime", ReturnType = typeof(float))]
	[Calls(Type = typeof(InputField), Member = "SetCaretActive", ReturnType = typeof(void))]
	private void SetCaretVisible() { }

	[CalledBy(Type = typeof(InputField), Member = "UpdateLabel", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InputField), Member = "get_cachedInputTextGenerator", ReturnType = typeof(TextGenerator))]
	[Calls(Type = typeof(TextGenerator), Member = "get_lineCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(TextGenerator), Member = "get_rectExtents", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(TextGenerator), Member = "get_characters", ReturnType = typeof(System.Collections.Generic.IList`1<UnityEngine.UICharInfo>))]
	[Calls(Type = typeof(TextGenerator), Member = "get_characterCountVisible", ReturnType = typeof(int))]
	[Calls(Type = typeof(TextGenerator), Member = "get_lines", ReturnType = typeof(System.Collections.Generic.IList`1<UnityEngine.UILineInfo>))]
	[Calls(Type = typeof(InputField), Member = "DetermineCharacterLine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(TextGenerator)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(InputField), Member = "GetLineStartPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextGenerator), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(InputField), Member = "GetLineEndPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextGenerator), typeof(int)}, ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 20)]
	private void SetDrawRangeToContainCaretPosition(int caretPos) { }

	[CalledBy(Type = typeof(InputField), Member = "set_text", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputField), Member = "LateUpdate", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputField), Member = "DeactivateInputField", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(string), Member = "Replace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Math), Member = "Min", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(TouchScreenKeyboard), Member = "set_text", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UISystemProfilerApi), Member = "AddMarker", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UnityEngine.Events.UnityEvent`1<System.Object>), Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputField), Member = "UpdateLabel", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 6)]
	private void SetText(string value, bool sendCallback = true) { }

	[CallerCount(Count = 0)]
	[ContainsInvalidInstructions]
	public void SetTextWithoutNotify(string input) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputField), Member = "set_contentType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ContentType)}, ReturnType = typeof(void))]
	private void SetToCustom() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputField), Member = "set_contentType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ContentType)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	private void SetToCustomIfContentTypeIsNot(ContentType[] allowedContentTypes) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Application), Member = "get_platform", ReturnType = typeof(RuntimePlatform))]
	[Calls(Type = typeof(TouchScreenKeyboard), Member = "get_isInPlaceEditingAllowed", ReturnType = typeof(bool))]
	[Calls(Type = typeof(TouchScreenKeyboard), Member = "get_isSupported", ReturnType = typeof(bool))]
	private bool TouchScreenKeyboardShouldBeUsed() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[DeduplicatedMethod]
	private override Transform UnityEngine.UI.ICanvasElement.get_transform() { }

	[CalledBy(Type = typeof(InputField), Member = "LateUpdate", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(TouchScreenKeyboard), Member = "get_selection", ReturnType = typeof(RangeInt))]
	[Calls(Type = typeof(InputField), Member = "get_compositionString", ReturnType = typeof(string))]
	[Calls(Type = typeof(Time), Member = "get_unscaledTime", ReturnType = typeof(float))]
	[Calls(Type = typeof(InputField), Member = "UpdateLabel", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void UpdateCaretFromKeyboard() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Graphic), Member = "get_defaultGraphicMaterial", ReturnType = typeof(Material))]
	[Calls(Type = typeof(Texture2D), Member = "get_whiteTexture", ReturnType = typeof(Texture2D))]
	[Calls(Type = typeof(CanvasRenderer), Member = "SetMaterial", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material), typeof(Texture)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void UpdateCaretMaterial() { }

	[CalledBy(Type = typeof(InputField), Member = "Rebuild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CanvasUpdate)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CanvasRenderer), Member = "SetMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mesh)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputField), Member = "OnFillVBO", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mesh)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputField), Member = "get_mesh", ReturnType = typeof(Mesh))]
	[Calls(Type = typeof(InputField), Member = "AssignPositioningIfNeeded", ReturnType = typeof(void))]
	[Calls(Type = typeof(GameObject), Member = "AddComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(CanvasRenderer), Member = "SetMaterial", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material), typeof(Texture)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Texture2D), Member = "get_whiteTexture", ReturnType = typeof(Texture2D))]
	[Calls(Type = typeof(Graphic), Member = "get_defaultGraphicMaterial", ReturnType = typeof(Material))]
	[Calls(Type = typeof(GameObject), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(GameObject), Member = "set_layer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GameObject), Member = "get_layer", ReturnType = typeof(int))]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(Transform), Member = "SetAsFirstSibling", ReturnType = typeof(void))]
	[Calls(Type = typeof(GameObject), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Object), Member = "set_hideFlags", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HideFlags)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GameObject), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Type[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Object), Member = "get_name", ReturnType = typeof(string))]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Application), Member = "get_platform", ReturnType = typeof(RuntimePlatform))]
	[Calls(Type = typeof(TouchScreenKeyboard), Member = "get_isSupported", ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 12)]
	private void UpdateGeometry() { }

	[CalledBy(Type = typeof(InputField), Member = "OnDrag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputField), Member = "OnPointerDown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(TouchScreenKeyboard), Member = "get_canSetSelection", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Application), Member = "get_platform", ReturnType = typeof(RuntimePlatform))]
	[Calls(Type = typeof(InputField), Member = "GetInternalSelection", ReturnType = typeof(RangeInt))]
	[Calls(Type = typeof(TouchScreenKeyboard), Member = "set_selection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RangeInt)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private void UpdateKeyboardCaret() { }

	[CalledBy(Type = typeof(<MouseDragOutsideRect>d__194), Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(InputField), Member = "ActivateInputFieldInternal", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputField), Member = "ForceLabelUpdate", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputField), Member = "SendOnValueChangedAndUpdateLabel", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputField), Member = "ForwardSpace", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputField), Member = "OnUpdateSelected", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputField), Member = "KeyPressed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event)}, ReturnType = typeof(EditState))]
	[CalledBy(Type = typeof(InputField), Member = "OnPointerDown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputField), Member = "Backspace", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputField), Member = "UpdateCaretFromKeyboard", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputField), Member = "MoveTextStart", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputField), Member = "MoveTextEnd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputField), Member = "OnEnable", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputField), Member = "set_asteriskChar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputField), Member = "set_characterLimit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputField), Member = "SetText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputField), Member = "LateUpdate", ReturnType = typeof(void))]
	[CallerCount(Count = 20)]
	[Calls(Type = typeof(Graphic), Member = "get_rectTransform", ReturnType = typeof(RectTransform))]
	[Calls(Type = typeof(RectTransform), Member = "get_rect", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(Text), Member = "GetGenerationSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(TextGenerationSettings))]
	[Calls(Type = typeof(InputField), Member = "get_cachedInputTextGenerator", ReturnType = typeof(TextGenerator))]
	[Calls(Type = typeof(InputField), Member = "MarkGeometryAsDirty", ReturnType = typeof(void))]
	[Calls(Type = typeof(InputField), Member = "SetDrawRangeToContainCaretPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputField), Member = "SetCaretVisible", ReturnType = typeof(void))]
	[Calls(Type = typeof(Behaviour), Member = "set_enabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TextGenerator), Member = "PopulateWithErrors", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(TextGenerationSettings), typeof(GameObject)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Text), Member = "get_font", ReturnType = typeof(Font))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(InputField), Member = "get_compositionString", ReturnType = typeof(string))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(EventSystem), Member = "get_current", ReturnType = typeof(EventSystem))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "CreateString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(int)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	protected void UpdateLabel() { }

	[CalledBy(Type = typeof(InputField), Member = "KeyPressed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event)}, ReturnType = typeof(EditState))]
	[CalledBy(Type = typeof(InputField), Member = "ForwardSpace", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputField), Member = "Backspace", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(TouchScreenKeyboard), Member = "get_isSupported", ReturnType = typeof(bool))]
	[Calls(Type = typeof(TouchScreenKeyboard), Member = "set_text", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private void UpdateTouchKeyboardFromEditChanges() { }

	[CalledBy(Type = typeof(InputField), Member = "LateUpdate", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputField), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Behaviour), Member = "get_enabled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(char), Member = "IsLetter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "IndexOfAny", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[])}, ReturnType = typeof(int))]
	[Calls(Type = typeof(char), Member = "IsLower", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(char), Member = "ToUpper", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(char), Member = "IsUpper", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(char), Member = "ToLower", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(InputField), Member = "get_compositionString", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	protected char Validate(string text, int pos, char ch) { }

}

