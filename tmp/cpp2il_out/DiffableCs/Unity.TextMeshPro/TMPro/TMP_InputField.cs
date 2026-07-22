namespace TMPro;

[AddComponentMenu("UI/TextMeshPro - Input Field", 11)]
[HelpURL("https://docs.unity3d.com/Packages/com.unity.ugui@2.0/manual/TextMeshPro/index.html")]
public class TMP_InputField : Selectable, IUpdateSelectedHandler, IEventSystemHandler, IBeginDragHandler, IDragHandler, IEndDragHandler, IPointerClickHandler, ISubmitHandler, ICancelHandler, ICanvasElement, ILayoutElement, IScrollHandler
{
	[CompilerGenerated]
	private sealed class <CaretBlink>d__293 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public TMP_InputField <>4__this; //Field offset: 0x20

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
		public <CaretBlink>d__293(int <>1__state) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Time), Member = "get_unscaledTime", ReturnType = typeof(float))]
		[Calls(Type = typeof(TMP_InputField), Member = "get_hasSelection", ReturnType = typeof(bool))]
		[Calls(Type = typeof(TMP_InputField), Member = "MarkGeometryAsDirty", ReturnType = typeof(void))]
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
	private sealed class <MouseDragOutsideRect>d__314 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public TMP_InputField <>4__this; //Field offset: 0x20
		public PointerEventData eventData; //Field offset: 0x28

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
		public <MouseDragOutsideRect>d__314(int <>1__state) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(PointerEventData), Member = "get_pressEventCamera", ReturnType = typeof(Camera))]
		[Calls(Type = typeof(RectTransformUtility), Member = "ScreenPointToLocalPointInRectangle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform), typeof(Vector2), typeof(Camera), typeof(Vector2&)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(RectTransform), Member = "get_rect", ReturnType = typeof(Rect))]
		[Calls(Type = typeof(TMP_InputField), Member = "get_multiLine", ReturnType = typeof(bool))]
		[Calls(Type = typeof(TMP_InputField), Member = "MoveRight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(TMP_InputField), Member = "MoveLeft", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(TMP_InputField), Member = "MoveDown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(TMP_InputField), Member = "MoveUp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(TMP_InputField), Member = "UpdateLabel", ReturnType = typeof(void))]
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
		Digit = 1,
		Integer = 2,
		Decimal = 3,
		Alphanumeric = 4,
		Name = 5,
		Regex = 6,
		EmailAddress = 7,
		CustomValidator = 8,
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

		[CalledBy(Type = typeof(TMP_InputField), Member = ".ctor", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
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

	internal class SelectionEvent : UnityEvent<String>
	{

		[CalledBy(Type = typeof(TMP_InputField), Member = ".ctor", ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		public SelectionEvent() { }

	}

	internal class SubmitEvent : UnityEvent<String>
	{

		[CalledBy(Type = typeof(TMP_InputField), Member = ".ctor", ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		public SubmitEvent() { }

	}

	internal class TextSelectionEvent : UnityEvent<String, Int32, Int32>
	{

		[CalledBy(Type = typeof(TMP_InputField), Member = ".ctor", ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		public TextSelectionEvent() { }

	}

	internal class TouchScreenKeyboardEvent : UnityEvent<Status>
	{

		[CalledBy(Type = typeof(TMP_InputField), Member = ".ctor", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		public TouchScreenKeyboardEvent() { }

	}

	private const float kHScrollSpeed = 0.05; //Field offset: 0x0
	private static readonly Char[] kSeparators; //Field offset: 0x0
	private const string kEmailSpecialCharacters = "!#$%&'*+-/=?^_`{|}~"; //Field offset: 0x0
	private const string kOculusQuestDeviceModel = "Oculus Quest"; //Field offset: 0x0
	private const float kVScrollSpeed = 0.1; //Field offset: 0x0
	private static bool s_IsQuestDevice; //Field offset: 0x8
	protected TouchScreenKeyboard m_SoftKeyboard; //Field offset: 0x100
	protected RectTransform m_RectTransform; //Field offset: 0x108
	[SerializeField]
	protected RectTransform m_TextViewport; //Field offset: 0x110
	protected RectMask2D m_TextComponentRectMask; //Field offset: 0x118
	protected RectMask2D m_TextViewportRectMask; //Field offset: 0x120
	[SerializeField]
	protected TMP_Text m_TextComponent; //Field offset: 0x128
	protected RectTransform m_TextComponentRectTransform; //Field offset: 0x130
	[SerializeField]
	protected Graphic m_Placeholder; //Field offset: 0x138
	[SerializeField]
	protected Scrollbar m_VerticalScrollbar; //Field offset: 0x140
	[SerializeField]
	protected TMP_ScrollbarEventHandler m_VerticalScrollbarEventHandler; //Field offset: 0x148
	private bool m_IsDrivenByLayoutComponents; //Field offset: 0x150
	[SerializeField]
	private LayoutGroup m_LayoutGroup; //Field offset: 0x158
	private IScrollHandler m_IScrollHandlerParent; //Field offset: 0x160
	private float m_ScrollPosition; //Field offset: 0x168
	[SerializeField]
	protected float m_ScrollSensitivity; //Field offset: 0x16C
	[SerializeField]
	private ContentType m_ContentType; //Field offset: 0x170
	[SerializeField]
	private InputType m_InputType; //Field offset: 0x174
	[SerializeField]
	private char m_AsteriskChar; //Field offset: 0x178
	[SerializeField]
	private TouchScreenKeyboardType m_KeyboardType; //Field offset: 0x17C
	[SerializeField]
	private LineType m_LineType; //Field offset: 0x180
	[SerializeField]
	private bool m_HideMobileInput; //Field offset: 0x184
	[SerializeField]
	private bool m_HideSoftKeyboard; //Field offset: 0x185
	[SerializeField]
	private CharacterValidation m_CharacterValidation; //Field offset: 0x188
	[SerializeField]
	private string m_RegexValue; //Field offset: 0x190
	[SerializeField]
	private float m_GlobalPointSize; //Field offset: 0x198
	[SerializeField]
	private int m_CharacterLimit; //Field offset: 0x19C
	[SerializeField]
	private SubmitEvent m_OnEndEdit; //Field offset: 0x1A0
	[SerializeField]
	private SubmitEvent m_OnSubmit; //Field offset: 0x1A8
	[SerializeField]
	private SelectionEvent m_OnSelect; //Field offset: 0x1B0
	[SerializeField]
	private SelectionEvent m_OnDeselect; //Field offset: 0x1B8
	[SerializeField]
	private TextSelectionEvent m_OnTextSelection; //Field offset: 0x1C0
	[SerializeField]
	private TextSelectionEvent m_OnEndTextSelection; //Field offset: 0x1C8
	[SerializeField]
	private OnChangeEvent m_OnValueChanged; //Field offset: 0x1D0
	[SerializeField]
	private TouchScreenKeyboardEvent m_OnTouchScreenKeyboardStatusChanged; //Field offset: 0x1D8
	[SerializeField]
	private OnValidateInput m_OnValidateInput; //Field offset: 0x1E0
	[SerializeField]
	private Color m_CaretColor; //Field offset: 0x1E8
	[SerializeField]
	private bool m_CustomCaretColor; //Field offset: 0x1F8
	[SerializeField]
	private Color m_SelectionColor; //Field offset: 0x1FC
	[SerializeField]
	[TextArea(5, 10)]
	protected string m_Text; //Field offset: 0x210
	[Range(0, 4)]
	[SerializeField]
	private float m_CaretBlinkRate; //Field offset: 0x218
	[Range(1, 5)]
	[SerializeField]
	private int m_CaretWidth; //Field offset: 0x21C
	[SerializeField]
	private bool m_ReadOnly; //Field offset: 0x220
	[SerializeField]
	private bool m_RichText; //Field offset: 0x221
	protected int m_StringPosition; //Field offset: 0x224
	protected int m_StringSelectPosition; //Field offset: 0x228
	protected int m_CaretPosition; //Field offset: 0x22C
	protected int m_CaretSelectPosition; //Field offset: 0x230
	private RectTransform caretRectTrans; //Field offset: 0x238
	protected UIVertex[] m_CursorVerts; //Field offset: 0x240
	private CanvasRenderer m_CachedInputRenderer; //Field offset: 0x248
	private Vector2 m_LastPosition; //Field offset: 0x250
	protected Mesh m_Mesh; //Field offset: 0x258
	private bool m_AllowInput; //Field offset: 0x260
	private bool m_ShouldActivateNextUpdate; //Field offset: 0x261
	private bool m_UpdateDrag; //Field offset: 0x262
	private bool m_DragPositionOutOfBounds; //Field offset: 0x263
	protected bool m_CaretVisible; //Field offset: 0x264
	private Coroutine m_BlinkCoroutine; //Field offset: 0x268
	private float m_BlinkStartTime; //Field offset: 0x270
	private Coroutine m_DragCoroutine; //Field offset: 0x278
	private string m_OriginalText; //Field offset: 0x280
	private bool m_WasCanceled; //Field offset: 0x288
	private bool m_HasDoneFocusTransition; //Field offset: 0x289
	private WaitForSecondsRealtime m_WaitForSecondsRealtime; //Field offset: 0x290
	private bool m_PreventCallback; //Field offset: 0x298
	private bool m_TouchKeyboardAllowsInPlaceEditing; //Field offset: 0x299
	private bool m_IsTextComponentUpdateRequired; //Field offset: 0x29A
	private bool m_HasTextBeenRemoved; //Field offset: 0x29B
	private float m_PointerDownClickStartTime; //Field offset: 0x29C
	private float m_KeyDownStartTime; //Field offset: 0x2A0
	private float m_DoubleClickDelay; //Field offset: 0x2A4
	private bool m_IsApplePlatform; //Field offset: 0x2A8
	private bool m_IsCompositionActive; //Field offset: 0x2A9
	private bool m_ShouldUpdateIMEWindowPosition; //Field offset: 0x2AA
	private int m_PreviousIMEInsertionLine; //Field offset: 0x2AC
	[SerializeField]
	protected TMP_FontAsset m_GlobalFontAsset; //Field offset: 0x2B0
	[SerializeField]
	protected bool m_OnFocusSelectAll; //Field offset: 0x2B8
	protected bool m_isSelectAll; //Field offset: 0x2B9
	[SerializeField]
	protected bool m_ResetOnDeActivation; //Field offset: 0x2BA
	private bool m_SelectionStillActive; //Field offset: 0x2BB
	private bool m_ReleaseSelection; //Field offset: 0x2BC
	private KeyCode m_LastKeyCode; //Field offset: 0x2C0
	private GameObject m_PreviouslySelectedObject; //Field offset: 0x2C8
	[SerializeField]
	private bool m_KeepTextSelectionVisible; //Field offset: 0x2D0
	[SerializeField]
	private bool m_RestoreOriginalTextOnEscape; //Field offset: 0x2D1
	[SerializeField]
	protected bool m_isRichTextEditingAllowed; //Field offset: 0x2D2
	[SerializeField]
	protected int m_LineLimit; //Field offset: 0x2D4
	public bool isAlert; //Field offset: 0x2D8
	[SerializeField]
	protected TMP_InputValidator m_InputValidator; //Field offset: 0x2E0
	[SerializeField]
	private bool m_ShouldActivateOnSelect; //Field offset: 0x2E8
	private bool m_isSelected; //Field offset: 0x2E9
	private bool m_IsStringPositionDirty; //Field offset: 0x2EA
	private bool m_IsCaretPositionDirty; //Field offset: 0x2EB
	private bool m_forceRectTransformAdjustment; //Field offset: 0x2EC
	private bool m_IsKeyboardBeingClosedInHoloLens; //Field offset: 0x2ED
	private Event m_ProcessingEvent; //Field offset: 0x2F0

	public char asteriskChar
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 8
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SetPropertyUtility), Member = "SetStruct", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char&), typeof(char)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(TMP_InputField), Member = "UpdateLabel", ReturnType = typeof(void))]
		 set { } //Length: 91
	}

	public float caretBlinkRate
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 9
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SetPropertyUtility), Member = "SetStruct", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Single&), typeof(float)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(TMP_InputField), Member = "SetCaretActive", ReturnType = typeof(void))]
		 set { } //Length: 101
	}

	public Color caretColor
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 90
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CanvasUpdateRegistry), Member = "RegisterCanvasElementForGraphicRebuild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ICanvasElement)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		 set { } //Length: 111
	}

	public int caretPosition
	{
		[CallerCount(Count = 6)]
		[Calls(Type = typeof(TMP_InputField), Member = "get_compositionString", ReturnType = typeof(string))]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 59
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(TMP_InputField), Member = "get_compositionString", ReturnType = typeof(string))]
		[Calls(Type = typeof(TMP_InputField), Member = "ClampCaretPos", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(TMP_InputField), Member = "UpdateStringIndexFromCaretPosition", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		 set { } //Length: 159
	}

	protected int caretPositionInternal
	{
		[CallerCount(Count = 15)]
		[Calls(Type = typeof(TMP_InputField), Member = "get_compositionString", ReturnType = typeof(string))]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 59
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(TMP_InputField), Member = "ClampCaretPos", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&)}, ReturnType = typeof(void))]
		 set { } //Length: 21
	}

	protected int caretSelectPositionInternal
	{
		[CallerCount(Count = 6)]
		[Calls(Type = typeof(TMP_InputField), Member = "get_compositionString", ReturnType = typeof(string))]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 59
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(TMP_InputField), Member = "ClampCaretPos", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&)}, ReturnType = typeof(void))]
		 set { } //Length: 21
	}

	public int caretWidth
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
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
		[CalledBy(Type = "Scenes.General.TextBox", Member = "Start", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Math), Member = "Max", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(SetPropertyUtility), Member = "SetStruct", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&), typeof(int)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(TMP_InputField), Member = "UpdateLabel", ReturnType = typeof(void))]
		[Calls(Type = typeof(TouchScreenKeyboard), Member = "set_characterLimit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		 set { } //Length: 161
	}

	public CharacterValidation characterValidation
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 7
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SetPropertyUtility), Member = "SetStruct", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"System.Int32Enum"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32Enum&), "System.Int32Enum"}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(TMP_InputField), Member = "set_contentType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ContentType)}, ReturnType = typeof(void))]
		 set { } //Length: 104
	}

	private static string clipboard
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(GUIUtility), Member = "get_systemCopyBuffer", ReturnType = typeof(string))]
		private get { } //Length: 64
		[CalledBy(Type = typeof(TMP_InputField), Member = "KeyPressed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event)}, ReturnType = typeof(EditState))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(GUIUtility), Member = "set_systemCopyBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		private set { } //Length: 73
	}

	private int compositionLength
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(TMP_InputField), Member = "get_compositionString", ReturnType = typeof(string))]
		[CallsUnknownMethods(Count = 1)]
		private get { } //Length: 45
	}

	private string compositionString
	{
		[CallerCount(Count = 146)]
		[Calls(Type = typeof(TMP_InputField), Member = "get_inputSystem", ReturnType = typeof(BaseInput))]
		[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Input), Member = "get_compositionString", ReturnType = typeof(string))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		private get { } //Length: 159
	}

	public ContentType contentType
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 7
		[CalledBy(Type = "Scenes.General.TextBox", Member = "Start", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TMP_InputField), Member = "set_lineType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LineType)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TMP_InputField), Member = "set_inputType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputType)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TMP_InputField), Member = "set_keyboardType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TouchScreenKeyboardType)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TMP_InputField), Member = "set_characterValidation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CharacterValidation)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TMP_InputField), Member = "set_inputValidator", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TMP_InputValidator)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TMP_InputField), Member = "SetToCustomIfContentTypeIsNot", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ContentType[])}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TMP_InputField), Member = "SetToCustom", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TMP_InputField), Member = "SetToCustom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CharacterValidation)}, ReturnType = typeof(void))]
		[CallerCount(Count = 9)]
		[Calls(Type = typeof(SetPropertyUtility), Member = "SetStruct", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"System.Int32Enum"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32Enum&), "System.Int32Enum"}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(TMP_Text), Member = "set_textWrappingMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextWrappingModes)}, ReturnType = typeof(void))]
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

	public TMP_FontAsset fontAsset
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 8
		[CalledBy(Type = typeof(TMP_DefaultControls), Member = "CreateInputField", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Resources)}, ReturnType = typeof(GameObject))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(TMP_Text), Member = "set_font", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TMP_FontAsset)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(TMP_InputField), Member = "UpdateLabel", ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		 set { } //Length: 308
	}

	private bool hasSelection
	{
		[CalledBy(Type = typeof(<CaretBlink>d__293), Member = "MoveNext", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(TMP_InputField), Member = "DeleteKey", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TMP_InputField), Member = "Backspace", ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(TMP_InputField), Member = "get_compositionString", ReturnType = typeof(string))]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		private get { } //Length: 107
	}

	private BaseInput inputSystem
	{
		[CalledBy(Type = typeof(TMP_InputField), Member = "get_compositionString", ReturnType = typeof(string))]
		[CalledBy(Type = typeof(TMP_InputField), Member = "GenerateCaret", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexHelper), typeof(Vector2)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TMP_InputField), Member = "ActivateInputFieldInternal", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TMP_InputField), Member = "DeactivateInputField", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
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
		 get { } //Length: 7
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SetPropertyUtility), Member = "SetStruct", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"System.Int32Enum"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32Enum&), "System.Int32Enum"}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(TMP_InputField), Member = "set_contentType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ContentType)}, ReturnType = typeof(void))]
		 set { } //Length: 104
	}

	public TMP_InputValidator inputValidator
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 8
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(TMP_InputField), Member = "set_contentType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ContentType)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		 set { } //Length: 106
	}

	public bool isFocused
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 8
	}

	public bool isRichTextEditingAllowed
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 8
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 set { } //Length: 7
	}

	public bool keepTextSelectionVisible
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 8
		[CallerCount(Count = 0)]
		 set { } //Length: 7
	}

	public TouchScreenKeyboardType keyboardType
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 7
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SetPropertyUtility), Member = "SetStruct", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"System.Int32Enum"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32Enum&), "System.Int32Enum"}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(TMP_InputField), Member = "set_contentType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ContentType)}, ReturnType = typeof(void))]
		 set { } //Length: 104
	}

	public override int layoutPriority
	{
		[CallerCount(Count = 9)]
		[DeduplicatedMethod]
		 get { } //Length: 6
	}

	public int lineLimit
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 7
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SetPropertyUtility), Member = "SetStruct", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&), typeof(int)}, ReturnType = typeof(bool))]
		 set { } //Length: 104
	}

	public LineType lineType
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 7
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SetPropertyUtility), Member = "SetStruct", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"System.Int32Enum"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32Enum&), "System.Int32Enum"}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(TMP_InputField), Member = "set_contentType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ContentType)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(TMP_InputField), Member = "SetTextComponentWrapMode", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 2)]
		 set { } //Length: 215
	}

	protected Mesh mesh
	{
		[CalledBy(Type = typeof(TMP_InputField), Member = "Rebuild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CanvasUpdate)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TMP_InputField), Member = "UpdateGeometry", ReturnType = typeof(void))]
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
		[DeduplicatedMethod]
		 get { } //Length: 4
	}

	public bool multiLine
	{
		[CalledBy(Type = typeof(<MouseDragOutsideRect>d__314), Member = "MoveNext", ReturnType = typeof(bool))]
		[CallerCount(Count = 2)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 23
	}

	public SelectionEvent onDeselect
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 8
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		 set { } //Length: 76
	}

	public SubmitEvent onEndEdit
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 8
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		 set { } //Length: 76
	}

	public TextSelectionEvent onEndTextSelection
	{
		[CallerCount(Count = 10)]
		[DeduplicatedMethod]
		 get { } //Length: 8
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		 set { } //Length: 76
	}

	public bool onFocusSelectAll
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 8
		[CallerCount(Count = 0)]
		 set { } //Length: 7
	}

	public SelectionEvent onSelect
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

	public TextSelectionEvent onTextSelection
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 8
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		 set { } //Length: 76
	}

	public TouchScreenKeyboardEvent onTouchScreenKeyboardStatusChanged
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
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		 set { } //Length: 76
	}

	public OnChangeEvent onValueChanged
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 8
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		 set { } //Length: 76
	}

	public Graphic placeholder
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 8
		[CalledBy(Type = "UI.Dates.DatePicker_TextMeshProUtilities", Member = "ReplaceInputFieldWithTextMeshPro", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputField)}, ReturnType = typeof(TMP_InputField))]
		[CalledBy(Type = typeof(TMP_DefaultControls), Member = "CreateInputField", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Resources)}, ReturnType = typeof(GameObject))]
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		 set { } //Length: 76
	}

	public float pointSize
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 9
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Math), Member = "Max", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(float))]
		[Calls(Type = typeof(SetPropertyUtility), Member = "SetStruct", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Single&), typeof(float)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(TMP_Text), Member = "set_fontSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(TMP_InputField), Member = "UpdateLabel", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		 set { } //Length: 357
	}

	public override float preferredHeight
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(RectOffset), Member = "get_vertical", ReturnType = typeof(int))]
		[Calls(Type = typeof(RectTransform), Member = "get_offsetMin", ReturnType = typeof(Vector2))]
		[Calls(Type = typeof(RectTransform), Member = "get_offsetMax", ReturnType = typeof(Vector2))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 362
	}

	public override float preferredWidth
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(RectOffset), Member = "get_horizontal", ReturnType = typeof(int))]
		[Calls(Type = typeof(RectTransform), Member = "get_offsetMin", ReturnType = typeof(Vector2))]
		[Calls(Type = typeof(RectTransform), Member = "get_offsetMax", ReturnType = typeof(Vector2))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 364
	}

	public bool readOnly
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 8
		[CallerCount(Count = 0)]
		 set { } //Length: 7
	}

	public bool resetOnDeActivation
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 8
		[CallerCount(Count = 0)]
		 set { } //Length: 7
	}

	public bool restoreOriginalTextOnEscape
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 8
		[CallerCount(Count = 0)]
		 set { } //Length: 7
	}

	public bool richText
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 8
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(TMP_Text), Member = "set_richText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		 set { } //Length: 135
	}

	public float scrollSensitivity
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 9
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SetPropertyUtility), Member = "SetStruct", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Single&), typeof(float)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CanvasUpdateRegistry), Member = "RegisterCanvasElementForGraphicRebuild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ICanvasElement)}, ReturnType = typeof(void))]
		 set { } //Length: 141
	}

	public int selectionAnchorPosition
	{
		[CallerCount(Count = 15)]
		[Calls(Type = typeof(TMP_InputField), Member = "get_compositionString", ReturnType = typeof(string))]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 59
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(TMP_InputField), Member = "get_compositionString", ReturnType = typeof(string))]
		[Calls(Type = typeof(TMP_InputField), Member = "ClampCaretPos", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		 set { } //Length: 89
	}

	public Color selectionColor
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 14
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CanvasUpdateRegistry), Member = "RegisterCanvasElementForGraphicRebuild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ICanvasElement)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		 set { } //Length: 111
	}

	public int selectionFocusPosition
	{
		[CallerCount(Count = 6)]
		[Calls(Type = typeof(TMP_InputField), Member = "get_compositionString", ReturnType = typeof(string))]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 59
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(TMP_InputField), Member = "get_compositionString", ReturnType = typeof(string))]
		[Calls(Type = typeof(TMP_InputField), Member = "ClampCaretPos", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		 set { } //Length: 89
	}

	public int selectionStringAnchorPosition
	{
		[CallerCount(Count = 14)]
		[Calls(Type = typeof(TMP_InputField), Member = "get_compositionString", ReturnType = typeof(string))]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 59
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(TMP_InputField), Member = "get_compositionString", ReturnType = typeof(string))]
		[CallsUnknownMethods(Count = 1)]
		 set { } //Length: 129
	}

	public int selectionStringFocusPosition
	{
		[CallerCount(Count = 10)]
		[Calls(Type = typeof(TMP_InputField), Member = "get_compositionString", ReturnType = typeof(string))]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 59
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(TMP_InputField), Member = "get_compositionString", ReturnType = typeof(string))]
		[CallsUnknownMethods(Count = 1)]
		 set { } //Length: 129
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
		[CalledBy(Type = typeof(TMP_InputField), Member = "InPlaceEditing", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(TMP_InputField), Member = "MayDrag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(TMP_InputField), Member = "ActivateInputFieldInternal", ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(Application), Member = "get_platform", ReturnType = typeof(RuntimePlatform))]
		 get { } //Length: 111
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Application), Member = "get_platform", ReturnType = typeof(RuntimePlatform))]
		[Calls(Type = typeof(SetPropertyUtility), Member = "SetStruct", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", "T"}, ReturnType = typeof(bool))]
		 set { } //Length: 160
	}

	public bool shouldHideSoftKeyboard
	{
		[CalledBy(Type = typeof(TMP_InputField), Member = "InPlaceEditing", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(TMP_InputField), Member = "MayDrag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(TMP_InputField), Member = "ActivateInputFieldInternal", ReturnType = typeof(void))]
		[CallerCount(Count = 5)]
		[Calls(Type = typeof(Application), Member = "get_platform", ReturnType = typeof(RuntimePlatform))]
		 get { } //Length: 143
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Application), Member = "get_platform", ReturnType = typeof(RuntimePlatform))]
		[Calls(Type = typeof(SetPropertyUtility), Member = "SetStruct", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", "T"}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(TouchScreenKeyboard), Member = "get_isSupported", ReturnType = typeof(bool))]
		[Calls(Type = typeof(TouchScreenKeyboard), Member = "get_active", ReturnType = typeof(bool))]
		[Calls(Type = typeof(TouchScreenKeyboard), Member = "set_active", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 2)]
		 set { } //Length: 324
	}

	public int stringPosition
	{
		[CallerCount(Count = 10)]
		[Calls(Type = typeof(TMP_InputField), Member = "get_compositionString", ReturnType = typeof(string))]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 59
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(TMP_InputField), Member = "get_compositionString", ReturnType = typeof(string))]
		[Calls(Type = typeof(TMP_InputField), Member = "UpdateCaretPositionFromStringIndex", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		 set { } //Length: 215
	}

	protected int stringPositionInternal
	{
		[CallerCount(Count = 14)]
		[Calls(Type = typeof(TMP_InputField), Member = "get_compositionString", ReturnType = typeof(string))]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 59
		[CalledBy(Type = typeof(TMP_InputField), Member = "OnPointerDown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TMP_InputField), Member = "Backspace", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TMP_InputField), Member = "Validate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(char)}, ReturnType = typeof(char))]
		[CallerCount(Count = 6)]
		[CallsUnknownMethods(Count = 1)]
		 set { } //Length: 69
	}

	protected int stringSelectPositionInternal
	{
		[CallerCount(Count = 10)]
		[Calls(Type = typeof(TMP_InputField), Member = "get_compositionString", ReturnType = typeof(string))]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 59
		[CalledBy(Type = typeof(TMP_InputField), Member = "OnPointerDown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TMP_InputField), Member = "Backspace", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TMP_InputField), Member = "Validate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(char)}, ReturnType = typeof(char))]
		[CallerCount(Count = 6)]
		[CallsUnknownMethods(Count = 1)]
		 set { } //Length: 69
	}

	public string text
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 8
		[CallerCount(Count = 55)]
		[Calls(Type = typeof(TMP_InputField), Member = "SetText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(void))]
		 set { } //Length: 11
	}

	public TMP_Text textComponent
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 8
		[CalledBy(Type = "UI.Dates.DatePicker_TextMeshProUtilities", Member = "ReplaceInputFieldWithTextMeshPro", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputField)}, ReturnType = typeof(TMP_InputField))]
		[CalledBy(Type = typeof(TMP_DefaultControls), Member = "CreateInputField", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Resources)}, ReturnType = typeof(GameObject))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(TMP_InputField), Member = "SetTextComponentWrapMode", ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		 set { } //Length: 91
	}

	public RectTransform textViewport
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 8
		[CalledBy(Type = "UI.Dates.DatePicker_TextMeshProUtilities", Member = "ReplaceInputFieldWithTextMeshPro", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputField)}, ReturnType = typeof(TMP_InputField))]
		[CalledBy(Type = typeof(TMP_DefaultControls), Member = "CreateInputField", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Resources)}, ReturnType = typeof(GameObject))]
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		 set { } //Length: 76
	}

	public TouchScreenKeyboard touchScreenKeyboard
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 8
	}

	public Scrollbar verticalScrollbar
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 8
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(UnityEvent`1), Member = "RemoveListener", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Events.UnityAction`1<T0>"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(UnityEvent`1), Member = "AddListener", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Events.UnityAction`1<T0>"}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 1)]
		 set { } //Length: 413
	}

	public bool wasCanceled
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 8
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(RuntimeFieldHandle)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private static TMP_InputField() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SubmitEvent), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(SelectionEvent), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(TextSelectionEvent), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(OnChangeEvent), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(TouchScreenKeyboardEvent), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(Event), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(Selectable), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_InputField), Member = "SetTextComponentWrapMode", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 12)]
	protected TMP_InputField() { }

	[CalledBy(Type = "Scenes.General.ChatWindow", Member = "SendChat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Scenes.General.ChatWindow", Member = "ActivateInputField", ReturnType = typeof(void))]
	[CalledBy(Type = "Manager.Hotkey", Member = "TapEnterInput", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TMP_InputField), Member = "OnSelect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_InputField), Member = "OnPointerClick", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TouchScreenKeyboard), Member = "get_active", ReturnType = typeof(bool))]
	[Calls(Type = typeof(TouchScreenKeyboard), Member = "set_active", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TouchScreenKeyboard), Member = "set_text", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public void ActivateInputField() { }

	[CalledBy(Type = typeof(TMP_InputField), Member = "LateUpdate", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TMP_InputField), Member = "get_shouldHideSoftKeyboard", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Time), Member = "get_unscaledTime", ReturnType = typeof(float))]
	[Calls(Type = typeof(TouchScreenKeyboard), Member = "set_selection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RangeInt)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_InputField), Member = "SelectAll", ReturnType = typeof(void))]
	[Calls(Type = typeof(TouchScreenKeyboard), Member = "Open", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(TouchScreenKeyboardType), typeof(bool), typeof(bool), typeof(bool), typeof(bool), typeof(string), typeof(int)}, ReturnType = typeof(TouchScreenKeyboard))]
	[Calls(Type = typeof(TouchScreenKeyboard), Member = "set_hideInput", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_InputField), Member = "get_shouldHideMobileInput", ReturnType = typeof(bool))]
	[Calls(Type = typeof(TMP_InputField), Member = "get_inputSystem", ReturnType = typeof(BaseInput))]
	[Calls(Type = typeof(TMP_InputField), Member = "TouchScreenKeyboardShouldBeUsed", ReturnType = typeof(bool))]
	[Calls(Type = typeof(TMP_InputField), Member = "SetCaretActive", ReturnType = typeof(void))]
	[Calls(Type = typeof(TouchScreenKeyboard), Member = "get_isInPlaceEditingAllowed", ReturnType = typeof(bool))]
	[Calls(Type = typeof(EventSystem), Member = "SetSelectedGameObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(EventSystem), Member = "get_current", ReturnType = typeof(EventSystem))]
	[Calls(Type = typeof(TMP_InputField), Member = "UpdateLabel", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 13)]
	[CallsUnknownMethods(Count = 4)]
	[ContainsUnimplementedInstructions]
	private void ActivateInputFieldInternal() { }

	[CalledBy(Type = typeof(TMP_InputField), Member = "GenerateCaret", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexHelper), typeof(Vector2)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_InputField), Member = "GenerateHighlight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexHelper), typeof(Vector2)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Transform), Member = "get_localPosition", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(TMP_Text), Member = "get_rectTransform", ReturnType = typeof(RectTransform))]
	[Calls(Type = typeof(RectTransform), Member = "get_rect", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(RectTransform), Member = "get_anchoredPosition", ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(RectTransform), Member = "set_anchoredPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_InputField), Member = "AssignPositioningIfNeeded", ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_Text), Member = "get_textInfo", ReturnType = typeof(TMP_TextInfo))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	private void AdjustRectTransformRelativeToViewport(Vector2 startPosition, float height, bool isCharVisible) { }

	[CalledBy(Type = typeof(TMP_InputField), Member = "OnScroll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_InputField), Member = "OnScrollbarValueChange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TMP_Text), Member = "get_textInfo", ReturnType = typeof(TMP_TextInfo))]
	[Calls(Type = typeof(TMP_Text), Member = "get_bounds", ReturnType = typeof(Bounds))]
	[Calls(Type = typeof(TMP_Text), Member = "get_rectTransform", ReturnType = typeof(RectTransform))]
	[Calls(Type = typeof(RectTransform), Member = "get_anchoredPosition", ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(RectTransform), Member = "get_rect", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(RectTransform), Member = "set_anchoredPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_InputField), Member = "AssignPositioningIfNeeded", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void AdjustTextPositionRelativeToViewport(float relativePosition) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TMP_InputField), Member = "InPlaceEditing", ReturnType = typeof(bool))]
	[Calls(Type = typeof(TMP_InputField), Member = "get_compositionString", ReturnType = typeof(string))]
	[Calls(Type = typeof(TMP_Text), Member = "get_textInfo", ReturnType = typeof(TMP_TextInfo))]
	[Calls(Type = typeof(string), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(TMP_InputField), Member = "Validate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(char)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(TMP_InputField), Member = "SendOnValueChanged", ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_InputField), Member = "UpdateLabel", ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_InputField), Member = "Delete", ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Insert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(TouchScreenKeyboard), Member = "set_text", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UnityEngine.Events.UnityEvent`1<System.Object>), Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 4)]
	protected override void Append(char input) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TMP_InputField), Member = "InPlaceEditing", ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	protected override void Append(string input) { }

	[CalledBy(Type = typeof(TMP_InputField), Member = "OnEnable", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_InputField), Member = "LateUpdate", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_InputField), Member = "MovePageUp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_InputField), Member = "MovePageDown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_InputField), Member = "AdjustTextPositionRelativeToViewport", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_InputField), Member = "AdjustRectTransformRelativeToViewport", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(float), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(RectTransform), Member = "get_anchorMin", ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(RectTransform), Member = "set_anchorMax", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RectTransform), Member = "set_anchorMin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Transform), Member = "set_localScale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Transform), Member = "set_localRotation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Transform), Member = "set_localPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RectTransform), Member = "get_pivot", ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(RectTransform), Member = "get_sizeDelta", ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(Transform), Member = "get_localScale", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(RectTransform), Member = "get_anchorMax", ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(RectTransform), Member = "set_pivot", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RectTransform), Member = "set_anchoredPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Transform), Member = "get_localRotation", ReturnType = typeof(Quaternion))]
	[Calls(Type = typeof(TMP_Text), Member = "get_rectTransform", ReturnType = typeof(RectTransform))]
	[Calls(Type = typeof(Transform), Member = "get_localPosition", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(RectTransform), Member = "get_anchoredPosition", ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(RectTransform), Member = "set_sizeDelta", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private void AssignPositioningIfNeeded() { }

	[CalledBy(Type = typeof(TMP_InputField), Member = "KeyPressed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event)}, ReturnType = typeof(EditState))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TouchScreenKeyboard), Member = "set_text", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_InputField), Member = "InPlaceEditing", ReturnType = typeof(bool))]
	[Calls(Type = typeof(TMP_InputField), Member = "Delete", ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_InputField), Member = "SendOnValueChangedAndUpdateLabel", ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_InputField), Member = "UpdateTouchKeyboardFromEditChanges", ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_InputField), Member = "ClampCaretPos", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(TMP_InputField), Member = "set_stringSelectPositionInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_InputField), Member = "set_stringPositionInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(TMP_Text), Member = "get_textInfo", ReturnType = typeof(TMP_TextInfo))]
	[Calls(Type = typeof(TMP_InputField), Member = "get_compositionString", ReturnType = typeof(string))]
	[Calls(Type = typeof(TMP_InputField), Member = "get_hasSelection", ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 4)]
	private void Backspace() { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	public override void CalculateLayoutInputHorizontal() { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	public override void CalculateLayoutInputVertical() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[IteratorStateMachine(typeof(<CaretBlink>d__293))]
	private IEnumerator CaretBlink() { }

	[CallerCount(Count = 0)]
	private int ClampArrayIndex(int index) { }

	[CallerCount(Count = 54)]
	[Calls(Type = typeof(TMP_Text), Member = "get_textInfo", ReturnType = typeof(TMP_TextInfo))]
	[CallsUnknownMethods(Count = 1)]
	protected void ClampCaretPos(ref int pos) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	protected void ClampStringPos(ref int pos) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 3)]
	private void CreateCursorVerts() { }

	[CalledBy(Type = "Scenes.General.ChatWindow", Member = "SendChat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Scenes.General.ChatWindow", Member = "DeactivateInputField", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_InputField), Member = "OnDisable", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_InputField), Member = "LateUpdate", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_InputField), Member = "OnUpdateSelected", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_InputField), Member = "OnDeselect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_InputField), Member = "OnSubmit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_InputField), Member = "OnCancel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseEventData)}, ReturnType = typeof(void))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(CanvasUpdateRegistry), Member = "RegisterCanvasElementForGraphicRebuild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ICanvasElement)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_InputField), Member = "get_inputSystem", ReturnType = typeof(BaseInput))]
	[Calls(Type = typeof(TMP_InputField), Member = "ReleaseSelection", ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TMP_InputField), Member = "SetText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Behaviour), Member = "set_enabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TouchScreenKeyboard), Member = "set_active", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public void DeactivateInputField(bool clearSelection = false) { }

	[CalledBy(Type = typeof(TMP_InputField), Member = "KeyPressed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event)}, ReturnType = typeof(EditState))]
	[CalledBy(Type = typeof(TMP_InputField), Member = "DeleteKey", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_InputField), Member = "Backspace", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_InputField), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_InputField), Member = "Insert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_InputField), Member = "UpdateLabel", ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(TMP_Text), Member = "get_textInfo", ReturnType = typeof(TMP_TextInfo))]
	[Calls(Type = typeof(string), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 6)]
	private void Delete() { }

	[CalledBy(Type = typeof(TMP_InputField), Member = "KeyPressed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event)}, ReturnType = typeof(EditState))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TMP_InputField), Member = "get_hasSelection", ReturnType = typeof(bool))]
	[Calls(Type = typeof(TMP_InputField), Member = "get_compositionString", ReturnType = typeof(string))]
	[Calls(Type = typeof(TMP_Text), Member = "get_textInfo", ReturnType = typeof(TMP_TextInfo))]
	[Calls(Type = typeof(string), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(TMP_InputField), Member = "SendOnValueChangedAndUpdateLabel", ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(TMP_InputField), Member = "UpdateTouchKeyboardFromEditChanges", ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_InputField), Member = "Delete", ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_InputField), Member = "InPlaceEditing", ReturnType = typeof(bool))]
	[Calls(Type = typeof(TouchScreenKeyboard), Member = "set_text", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallsUnknownMethods(Count = 4)]
	private void DeleteKey() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Selectable), Member = "DoStateTransition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SelectionState), typeof(bool)}, ReturnType = typeof(void))]
	protected virtual void DoStateTransition(SelectionState state, bool instant) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TMP_Text), Member = "set_textWrappingMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextWrappingModes)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	private void EnforceContentType() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TMP_InputField), Member = "get_compositionString", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "IndexOfAny", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int)}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 1)]
	private int FindNextWordBegin() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TMP_InputField), Member = "get_compositionString", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "LastIndexOfAny", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int)}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 1)]
	private int FindPrevWordBegin() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TMP_InputField), Member = "UpdateLabel", ReturnType = typeof(void))]
	public void ForceLabelUpdate() { }

	[CalledBy(Type = typeof(TMP_InputField), Member = "OnFillVBO", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mesh)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Color32), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(Color32))]
	[Calls(Type = typeof(Screen), Member = "get_height", ReturnType = typeof(int))]
	[Calls(Type = typeof(RectTransformUtility), Member = "WorldToScreenPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(Vector3)}, ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(Transform), Member = "TransformPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(GameObject), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(Canvas), Member = "get_worldCamera", ReturnType = typeof(Camera))]
	[Calls(Type = typeof(Canvas), Member = "get_renderMode", ReturnType = typeof(RenderMode))]
	[Calls(Type = typeof(VertexHelper), Member = "AddUIVertexQuad", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UIVertex[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_InputField), Member = "AdjustRectTransformRelativeToViewport", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(float), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_InputField), Member = "get_inputSystem", ReturnType = typeof(BaseInput))]
	[Calls(Type = typeof(TouchScreenKeyboard), Member = "set_selection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RangeInt)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TouchScreenKeyboard), Member = "get_text", ReturnType = typeof(string))]
	[Calls(Type = typeof(TMP_Text), Member = "get_textInfo", ReturnType = typeof(TMP_TextInfo))]
	[Calls(Type = typeof(TMP_InputField), Member = "get_compositionString", ReturnType = typeof(string))]
	[Calls(Type = "UnityEngine.Rendering.MousePositionDebug", Member = "GetMouseClickPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Graphic), Member = "get_canvas", ReturnType = typeof(Canvas))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 15)]
	[CallsUnknownMethods(Count = 6)]
	[ContainsUnimplementedInstructions]
	private void GenerateCaret(VertexHelper vbo, Vector2 roundingOffset) { }

	[CalledBy(Type = typeof(TMP_InputField), Member = "OnFillVBO", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mesh)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TMP_Text), Member = "get_textInfo", ReturnType = typeof(TMP_TextInfo))]
	[Calls(Type = typeof(TMP_InputField), Member = "get_compositionString", ReturnType = typeof(string))]
	[Calls(Type = typeof(TouchScreenKeyboard), Member = "set_selection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RangeInt)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_InputField), Member = "AdjustRectTransformRelativeToViewport", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(float), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Color32), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(Color32))]
	[Calls(Type = typeof(VertexHelper), Member = "get_currentVertCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(VertexHelper), Member = "AddVert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UIVertex)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VertexHelper), Member = "AddTriangle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 6)]
	private void GenerateHighlight(VertexHelper vbo, Vector2 roundingOffset) { }

	[CallerCount(Count = 0)]
	public char get_asteriskChar() { }

	[CallerCount(Count = 0)]
	public float get_caretBlinkRate() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public Color get_caretColor() { }

	[CallerCount(Count = 6)]
	[Calls(Type = typeof(TMP_InputField), Member = "get_compositionString", ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public int get_caretPosition() { }

	[CallerCount(Count = 15)]
	[Calls(Type = typeof(TMP_InputField), Member = "get_compositionString", ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	protected int get_caretPositionInternal() { }

	[CallerCount(Count = 6)]
	[Calls(Type = typeof(TMP_InputField), Member = "get_compositionString", ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	protected int get_caretSelectPositionInternal() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public int get_caretWidth() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public int get_characterLimit() { }

	[CallerCount(Count = 0)]
	public CharacterValidation get_characterValidation() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GUIUtility), Member = "get_systemCopyBuffer", ReturnType = typeof(string))]
	private static string get_clipboard() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TMP_InputField), Member = "get_compositionString", ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 1)]
	private int get_compositionLength() { }

	[CallerCount(Count = 146)]
	[Calls(Type = typeof(TMP_InputField), Member = "get_inputSystem", ReturnType = typeof(BaseInput))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Input), Member = "get_compositionString", ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private string get_compositionString() { }

	[CallerCount(Count = 0)]
	public ContentType get_contentType() { }

	[CallerCount(Count = 0)]
	public bool get_customCaretColor() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public override float get_flexibleHeight() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public override float get_flexibleWidth() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public TMP_FontAsset get_fontAsset() { }

	[CalledBy(Type = typeof(<CaretBlink>d__293), Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TMP_InputField), Member = "DeleteKey", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_InputField), Member = "Backspace", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(TMP_InputField), Member = "get_compositionString", ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private bool get_hasSelection() { }

	[CalledBy(Type = typeof(TMP_InputField), Member = "get_compositionString", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(TMP_InputField), Member = "GenerateCaret", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexHelper), typeof(Vector2)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_InputField), Member = "ActivateInputFieldInternal", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_InputField), Member = "DeactivateInputField", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(EventSystem), Member = "get_current", ReturnType = typeof(EventSystem))]
	[Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BaseInputModule), Member = "get_input", ReturnType = typeof(BaseInput))]
	[CallsUnknownMethods(Count = 1)]
	private BaseInput get_inputSystem() { }

	[CallerCount(Count = 0)]
	public InputType get_inputType() { }

	[CallerCount(Count = 0)]
	public TMP_InputValidator get_inputValidator() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public bool get_isFocused() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public bool get_isRichTextEditingAllowed() { }

	[CallerCount(Count = 0)]
	public bool get_keepTextSelectionVisible() { }

	[CallerCount(Count = 0)]
	public TouchScreenKeyboardType get_keyboardType() { }

	[CallerCount(Count = 9)]
	[DeduplicatedMethod]
	public override int get_layoutPriority() { }

	[CallerCount(Count = 0)]
	public int get_lineLimit() { }

	[CallerCount(Count = 0)]
	public LineType get_lineType() { }

	[CalledBy(Type = typeof(TMP_InputField), Member = "Rebuild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CanvasUpdate)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_InputField), Member = "UpdateGeometry", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Mesh), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	protected Mesh get_mesh() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public override float get_minHeight() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public override float get_minWidth() { }

	[CalledBy(Type = typeof(<MouseDragOutsideRect>d__314), Member = "MoveNext", ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[ContainsUnimplementedInstructions]
	public bool get_multiLine() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public SelectionEvent get_onDeselect() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public SubmitEvent get_onEndEdit() { }

	[CallerCount(Count = 10)]
	[DeduplicatedMethod]
	public TextSelectionEvent get_onEndTextSelection() { }

	[CallerCount(Count = 0)]
	public bool get_onFocusSelectAll() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public SelectionEvent get_onSelect() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public SubmitEvent get_onSubmit() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public TextSelectionEvent get_onTextSelection() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public TouchScreenKeyboardEvent get_onTouchScreenKeyboardStatusChanged() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public OnValidateInput get_onValidateInput() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public OnChangeEvent get_onValueChanged() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public Graphic get_placeholder() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public float get_pointSize() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(RectOffset), Member = "get_vertical", ReturnType = typeof(int))]
	[Calls(Type = typeof(RectTransform), Member = "get_offsetMin", ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(RectTransform), Member = "get_offsetMax", ReturnType = typeof(Vector2))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public override float get_preferredHeight() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(RectOffset), Member = "get_horizontal", ReturnType = typeof(int))]
	[Calls(Type = typeof(RectTransform), Member = "get_offsetMin", ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(RectTransform), Member = "get_offsetMax", ReturnType = typeof(Vector2))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public override float get_preferredWidth() { }

	[CallerCount(Count = 0)]
	public bool get_readOnly() { }

	[CallerCount(Count = 0)]
	public bool get_resetOnDeActivation() { }

	[CallerCount(Count = 0)]
	public bool get_restoreOriginalTextOnEscape() { }

	[CallerCount(Count = 0)]
	public bool get_richText() { }

	[CallerCount(Count = 0)]
	public float get_scrollSensitivity() { }

	[CallerCount(Count = 15)]
	[Calls(Type = typeof(TMP_InputField), Member = "get_compositionString", ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public int get_selectionAnchorPosition() { }

	[CallerCount(Count = 0)]
	public Color get_selectionColor() { }

	[CallerCount(Count = 6)]
	[Calls(Type = typeof(TMP_InputField), Member = "get_compositionString", ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public int get_selectionFocusPosition() { }

	[CallerCount(Count = 14)]
	[Calls(Type = typeof(TMP_InputField), Member = "get_compositionString", ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public int get_selectionStringAnchorPosition() { }

	[CallerCount(Count = 10)]
	[Calls(Type = typeof(TMP_InputField), Member = "get_compositionString", ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public int get_selectionStringFocusPosition() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Application), Member = "get_platform", ReturnType = typeof(RuntimePlatform))]
	[ContainsUnimplementedInstructions]
	public override bool get_shouldActivateOnSelect() { }

	[CalledBy(Type = typeof(TMP_InputField), Member = "InPlaceEditing", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TMP_InputField), Member = "MayDrag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TMP_InputField), Member = "ActivateInputFieldInternal", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Application), Member = "get_platform", ReturnType = typeof(RuntimePlatform))]
	public bool get_shouldHideMobileInput() { }

	[CalledBy(Type = typeof(TMP_InputField), Member = "InPlaceEditing", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TMP_InputField), Member = "MayDrag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TMP_InputField), Member = "ActivateInputFieldInternal", ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(Application), Member = "get_platform", ReturnType = typeof(RuntimePlatform))]
	public bool get_shouldHideSoftKeyboard() { }

	[CallerCount(Count = 10)]
	[Calls(Type = typeof(TMP_InputField), Member = "get_compositionString", ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public int get_stringPosition() { }

	[CallerCount(Count = 14)]
	[Calls(Type = typeof(TMP_InputField), Member = "get_compositionString", ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	protected int get_stringPositionInternal() { }

	[CallerCount(Count = 10)]
	[Calls(Type = typeof(TMP_InputField), Member = "get_compositionString", ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	protected int get_stringSelectPositionInternal() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public string get_text() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public TMP_Text get_textComponent() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public RectTransform get_textViewport() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public TouchScreenKeyboard get_touchScreenKeyboard() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public Scrollbar get_verticalScrollbar() { }

	[CallerCount(Count = 0)]
	public bool get_wasCanceled() { }

	[CallerCount(Count = 5)]
	[Calls(Type = typeof(TMP_Text), Member = "get_textInfo", ReturnType = typeof(TMP_TextInfo))]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	private int GetCaretPositionFromStringIndex(int stringIndex) { }

	[CallerCount(Count = 5)]
	[Calls(Type = typeof(TMP_Text), Member = "get_textInfo", ReturnType = typeof(TMP_TextInfo))]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	private int GetMaxCaretPositionFromStringIndex(int stringIndex) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TMP_Text), Member = "get_textInfo", ReturnType = typeof(TMP_TextInfo))]
	[CallsUnknownMethods(Count = 2)]
	private int GetMinCaretPositionFromStringIndex(int stringIndex) { }

	[CalledBy(Type = typeof(TMP_InputField), Member = "ON_TEXT_CHANGED", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_InputField), Member = "OnScroll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_InputField), Member = "UpdateScrollbar", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(RectTransform), Member = "get_rect", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(TMP_Text), Member = "get_textInfo", ReturnType = typeof(TMP_TextInfo))]
	[Calls(Type = typeof(TMP_Text), Member = "get_rectTransform", ReturnType = typeof(RectTransform))]
	[Calls(Type = typeof(RectTransform), Member = "get_anchoredPosition", ReturnType = typeof(Vector2))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	private float GetScrollPositionRelativeToViewport() { }

	[CalledBy(Type = typeof(TMP_InputField), Member = "KeyPressed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event)}, ReturnType = typeof(EditState))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(TMP_InputField), Member = "get_compositionString", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 1)]
	private string GetSelectedString() { }

	[CalledBy(Type = typeof(TMP_InputField), Member = "MoveTextEnd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_InputField), Member = "MoveTextStart", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_InputField), Member = "MoveDown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_InputField), Member = "MoveUp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_InputField), Member = "MovePageUp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_InputField), Member = "MovePageDown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_InputField), Member = "UpdateStringIndexFromCaretPosition", ReturnType = typeof(void))]
	[CallerCount(Count = 14)]
	[Calls(Type = typeof(TMP_Text), Member = "get_textInfo", ReturnType = typeof(TMP_TextInfo))]
	[CallsUnknownMethods(Count = 2)]
	private int GetStringIndexFromCaretPosition(int caretPosition) { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	public override void GraphicUpdateComplete() { }

	[CalledBy(Type = typeof(TMP_InputField), Member = "LateUpdate", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_InputField), Member = "OnPointerDown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_InputField), Member = "DeleteKey", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_InputField), Member = "Backspace", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_InputField), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_InputField), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_InputField), Member = "Insert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_InputField), Member = "UpdateTouchKeyboardFromEditChanges", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_InputField), Member = "Rebuild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CanvasUpdate)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_InputField), Member = "UpdateGeometry", ReturnType = typeof(void))]
	[CallerCount(Count = 12)]
	[Calls(Type = typeof(TMP_InputField), Member = "isUWP", ReturnType = typeof(bool))]
	[Calls(Type = typeof(TouchScreenKeyboard), Member = "get_isSupported", ReturnType = typeof(bool))]
	[Calls(Type = typeof(TMP_InputField), Member = "get_shouldHideSoftKeyboard", ReturnType = typeof(bool))]
	[Calls(Type = typeof(TMP_InputField), Member = "get_shouldHideMobileInput", ReturnType = typeof(bool))]
	private bool InPlaceEditing() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TouchScreenKeyboard), Member = "get_isInPlaceEditingAllowed", ReturnType = typeof(bool))]
	[ContainsUnimplementedInstructions]
	private bool InPlaceEditingChanged() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TMP_InputField), Member = "Delete", ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Insert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(TMP_InputField), Member = "InPlaceEditing", ReturnType = typeof(bool))]
	[Calls(Type = typeof(TouchScreenKeyboard), Member = "set_text", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UnityEngine.Events.UnityEvent`1<System.Object>), Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	private void Insert(char c) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Application), Member = "get_platform", ReturnType = typeof(RuntimePlatform))]
	[ContainsInvalidInstructions]
	private bool isKeyboardUsingEvents() { }

	[CalledBy(Type = typeof(TMP_InputField), Member = "InPlaceEditing", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TMP_InputField), Member = "LateUpdate", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_InputField), Member = "Rebuild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CanvasUpdate)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_InputField), Member = "UpdateGeometry", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Application), Member = "get_platform", ReturnType = typeof(RuntimePlatform))]
	[ContainsUnimplementedInstructions]
	private bool isUWP() { }

	[CallerCount(Count = 0)]
	protected override bool IsValidChar(char c) { }

	[CalledBy(Type = typeof(TMP_InputField), Member = "ProcessEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_InputField), Member = "OnUpdateSelected", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseEventData)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(TMP_InputField), Member = "MoveRight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Event), Member = "get_character", ReturnType = typeof(char))]
	[Calls(Type = typeof(TMP_Text), Member = "get_textInfo", ReturnType = typeof(TMP_TextInfo))]
	[Calls(Type = typeof(TMP_InputField), Member = "Backspace", ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_InputField), Member = "SelectAll", ReturnType = typeof(void))]
	[Calls(Type = typeof(GUIUtility), Member = "get_systemCopyBuffer", ReturnType = typeof(string))]
	[Calls(Type = typeof(TMP_InputField), Member = "MovePageDown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_InputField), Member = "MovePageUp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_InputField), Member = "MoveToEndOfLine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_InputField), Member = "MoveToStartOfLine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_InputField), Member = "MoveLeft", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_InputField), Member = "MoveDown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_InputField), Member = "get_compositionString", ReturnType = typeof(string))]
	[Calls(Type = typeof(TMP_InputField), Member = "MoveUp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_InputField), Member = "DeleteKey", ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_InputField), Member = "SendOnValueChangedAndUpdateLabel", ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_InputField), Member = "UpdateTouchKeyboardFromEditChanges", ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_InputField), Member = "Delete", ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_InputField), Member = "set_clipboard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_InputField), Member = "GetSelectedString", ReturnType = typeof(string))]
	[Calls(Type = typeof(Event), Member = "get_keyCode", ReturnType = typeof(KeyCode))]
	[Calls(Type = typeof(Event), Member = "get_modifiers", ReturnType = typeof(EventModifiers))]
	[Calls(Type = typeof(TMP_InputField), Member = "UpdateLabel", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	protected EditState KeyPressed(Event evt) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TouchScreenKeyboard), Member = "get_canSetSelection", ReturnType = typeof(bool))]
	[Calls(Type = typeof(TouchScreenKeyboard), Member = "set_selection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RangeInt)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_InputField), Member = "UpdateStringPositionFromKeyboard", ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(TMP_InputField), Member = "Validate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(char)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(TouchScreenKeyboard), Member = "get_text", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(TouchScreenKeyboard), Member = "set_text", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_InputField), Member = "SendOnValueChangedAndUpdateLabel", ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_InputField), Member = "SetText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_InputField), Member = "isUWP", ReturnType = typeof(bool))]
	[Calls(Type = typeof(TMP_InputField), Member = "SendTouchScreenKeyboardStatusChanged", ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_InputField), Member = "UpdateLabel", ReturnType = typeof(void))]
	[Calls(Type = typeof(TouchScreenKeyboard), Member = "get_status", ReturnType = typeof(Status))]
	[Calls(Type = typeof(TMP_InputField), Member = "AssignPositioningIfNeeded", ReturnType = typeof(void))]
	[Calls(Type = typeof(TouchScreenKeyboard), Member = "get_active", ReturnType = typeof(bool))]
	[Calls(Type = typeof(TouchScreenKeyboard), Member = "get_isInPlaceEditingAllowed", ReturnType = typeof(bool))]
	[Calls(Type = typeof(TMP_InputField), Member = "DeactivateInputField", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(EventSystem), Member = "get_current", ReturnType = typeof(EventSystem))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TMP_InputField), Member = "ActivateInputFieldInternal", ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(GameObject), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(Event), Member = "get_rawType", ReturnType = typeof(EventType))]
	[Calls(Type = typeof(Event), Member = "get_button", ReturnType = typeof(int))]
	[Calls(Type = typeof(Time), Member = "get_unscaledTime", ReturnType = typeof(float))]
	[Calls(Type = typeof(TMP_InputField), Member = "ReleaseSelection", ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_InputField), Member = "InPlaceEditing", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Application), Member = "get_platform", ReturnType = typeof(RuntimePlatform))]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallsUnknownMethods(Count = 8)]
	protected override void LateUpdate() { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	public override void LayoutComplete() { }

	[CalledBy(Type = typeof(TMP_InputField), Member = "MoveDown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TMP_Text), Member = "get_textInfo", ReturnType = typeof(TMP_TextInfo))]
	[CallsUnknownMethods(Count = 4)]
	private int LineDownCharacterPosition(int originalPos, bool goToLastChar) { }

	[CalledBy(Type = typeof(TMP_InputField), Member = "MoveUp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TMP_Text), Member = "get_textInfo", ReturnType = typeof(TMP_TextInfo))]
	[CallsUnknownMethods(Count = 4)]
	private int LineUpCharacterPosition(int originalPos, bool goToFirstChar) { }

	[CalledBy(Type = typeof(<CaretBlink>d__293), Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TMP_InputField), Member = "UpdateLabel", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CanvasUpdateRegistry), Member = "RegisterCanvasElementForGraphicRebuild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ICanvasElement)}, ReturnType = typeof(void))]
	private void MarkGeometryAsDirty() { }

	[CalledBy(Type = typeof(TMP_InputField), Member = "OnBeginDrag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_InputField), Member = "OnDrag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_InputField), Member = "OnEndDrag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_InputField), Member = "OnPointerDown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TMP_InputField), Member = "get_shouldHideSoftKeyboard", ReturnType = typeof(bool))]
	[Calls(Type = typeof(TMP_InputField), Member = "get_shouldHideMobileInput", ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	private bool MayDrag(PointerEventData eventData) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[IteratorStateMachine(typeof(<MouseDragOutsideRect>d__314))]
	private IEnumerator MouseDragOutsideRect(PointerEventData eventData) { }

	[CalledBy(Type = typeof(<MouseDragOutsideRect>d__314), Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TMP_InputField), Member = "KeyPressed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event)}, ReturnType = typeof(EditState))]
	[CalledBy(Type = typeof(TMP_InputField), Member = "MoveDown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(TMP_InputField), Member = "get_compositionString", ReturnType = typeof(string))]
	[Calls(Type = typeof(TMP_InputField), Member = "ClampCaretPos", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_Text), Member = "get_textInfo", ReturnType = typeof(TMP_TextInfo))]
	[Calls(Type = typeof(TMP_InputField), Member = "LineDownCharacterPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(TMP_InputField), Member = "GetStringIndexFromCaretPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 1)]
	private void MoveDown(bool shift, bool goToLastChar) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TMP_InputField), Member = "MoveDown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	private void MoveDown(bool shift) { }

	[CalledBy(Type = typeof(<MouseDragOutsideRect>d__314), Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TMP_InputField), Member = "KeyPressed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event)}, ReturnType = typeof(EditState))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(TMP_InputField), Member = "get_compositionString", ReturnType = typeof(string))]
	[Calls(Type = typeof(TMP_Text), Member = "get_textInfo", ReturnType = typeof(TMP_TextInfo))]
	[Calls(Type = typeof(TMP_InputField), Member = "ClampCaretPos", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(string), Member = "LastIndexOfAny", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int)}, ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 2)]
	private void MoveLeft(bool shift, bool ctrl) { }

	[CalledBy(Type = typeof(TMP_InputField), Member = "KeyPressed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event)}, ReturnType = typeof(EditState))]
	[CalledBy(Type = typeof(TMP_InputField), Member = "MovePageDown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(TMP_InputField), Member = "get_compositionString", ReturnType = typeof(string))]
	[Calls(Type = typeof(TMP_InputField), Member = "ClampCaretPos", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_Text), Member = "get_textInfo", ReturnType = typeof(TMP_TextInfo))]
	[Calls(Type = typeof(TMP_InputField), Member = "PageDownCharacterPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(TMP_InputField), Member = "GetStringIndexFromCaretPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(RectTransform), Member = "get_rect", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(TMP_Text), Member = "get_rectTransform", ReturnType = typeof(RectTransform))]
	[Calls(Type = typeof(Transform), Member = "get_position", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(TMP_Text), Member = "get_textBounds", ReturnType = typeof(Bounds))]
	[Calls(Type = typeof(RectTransform), Member = "get_anchoredPosition", ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(RectTransform), Member = "set_anchoredPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_InputField), Member = "AssignPositioningIfNeeded", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private void MovePageDown(bool shift, bool goToLastChar) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TMP_InputField), Member = "MovePageDown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	private void MovePageDown(bool shift) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TMP_InputField), Member = "MovePageUp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	private void MovePageUp(bool shift) { }

	[CalledBy(Type = typeof(TMP_InputField), Member = "KeyPressed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event)}, ReturnType = typeof(EditState))]
	[CalledBy(Type = typeof(TMP_InputField), Member = "MovePageUp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(TMP_InputField), Member = "get_compositionString", ReturnType = typeof(string))]
	[Calls(Type = typeof(TMP_InputField), Member = "ClampCaretPos", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_InputField), Member = "PageUpCharacterPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(TMP_InputField), Member = "GetStringIndexFromCaretPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(RectTransform), Member = "get_rect", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(TMP_Text), Member = "get_rectTransform", ReturnType = typeof(RectTransform))]
	[Calls(Type = typeof(Transform), Member = "get_position", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(TMP_Text), Member = "get_textBounds", ReturnType = typeof(Bounds))]
	[Calls(Type = typeof(RectTransform), Member = "get_anchoredPosition", ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(RectTransform), Member = "set_anchoredPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_InputField), Member = "AssignPositioningIfNeeded", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private void MovePageUp(bool shift, bool goToFirstChar) { }

	[CalledBy(Type = typeof(<MouseDragOutsideRect>d__314), Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TMP_InputField), Member = "KeyPressed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event)}, ReturnType = typeof(EditState))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(TMP_InputField), Member = "get_compositionString", ReturnType = typeof(string))]
	[Calls(Type = typeof(TMP_Text), Member = "get_textInfo", ReturnType = typeof(TMP_TextInfo))]
	[Calls(Type = typeof(TMP_InputField), Member = "ClampCaretPos", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(string), Member = "IndexOfAny", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int)}, ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 2)]
	private void MoveRight(bool shift, bool ctrl) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TMP_Text), Member = "get_textInfo", ReturnType = typeof(TMP_TextInfo))]
	[Calls(Type = typeof(TMP_InputField), Member = "ClampCaretPos", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_InputField), Member = "GetStringIndexFromCaretPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(TMP_InputField), Member = "get_compositionString", ReturnType = typeof(string))]
	[Calls(Type = typeof(TMP_InputField), Member = "UpdateLabel", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void MoveTextEnd(bool shift) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TMP_InputField), Member = "ClampCaretPos", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_InputField), Member = "GetStringIndexFromCaretPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(TMP_InputField), Member = "UpdateLabel", ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_InputField), Member = "get_compositionString", ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 1)]
	public void MoveTextStart(bool shift) { }

	[CalledBy(Type = typeof(TMP_InputField), Member = "KeyPressed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event)}, ReturnType = typeof(EditState))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TMP_Text), Member = "get_textInfo", ReturnType = typeof(TMP_TextInfo))]
	[Calls(Type = typeof(TMP_InputField), Member = "get_compositionString", ReturnType = typeof(string))]
	[Calls(Type = typeof(TMP_InputField), Member = "ClampCaretPos", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_InputField), Member = "UpdateLabel", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	public void MoveToEndOfLine(bool shift, bool ctrl) { }

	[CalledBy(Type = typeof(TMP_InputField), Member = "KeyPressed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event)}, ReturnType = typeof(EditState))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TMP_Text), Member = "get_textInfo", ReturnType = typeof(TMP_TextInfo))]
	[Calls(Type = typeof(TMP_InputField), Member = "get_compositionString", ReturnType = typeof(string))]
	[Calls(Type = typeof(TMP_InputField), Member = "ClampCaretPos", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_InputField), Member = "UpdateLabel", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	public void MoveToStartOfLine(bool shift, bool ctrl) { }

	[CalledBy(Type = typeof(<MouseDragOutsideRect>d__314), Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TMP_InputField), Member = "KeyPressed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event)}, ReturnType = typeof(EditState))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(TMP_InputField), Member = "get_compositionString", ReturnType = typeof(string))]
	[Calls(Type = typeof(TMP_InputField), Member = "ClampCaretPos", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_InputField), Member = "LineUpCharacterPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(TMP_InputField), Member = "GetStringIndexFromCaretPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 1)]
	private void MoveUp(bool shift, bool goToFirstChar) { }

	[CallerCount(Count = 0)]
	[ContainsInvalidInstructions]
	private void MoveUp(bool shift) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Application), Member = "get_isPlaying", ReturnType = typeof(bool))]
	[Calls(Type = typeof(TMP_InputField), Member = "get_compositionString", ReturnType = typeof(string))]
	[Calls(Type = typeof(TMP_InputField), Member = "UpdateCaretPositionFromStringIndex", ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(RectTransform), Member = "get_rect", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(Scrollbar), Member = "set_size", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_InputField), Member = "GetScrollPositionRelativeToViewport", ReturnType = typeof(float))]
	[Calls(Type = typeof(Scrollbar), Member = "set_value", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void ON_TEXT_CHANGED(object obj) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TMP_InputField), Member = "MayDrag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(bool))]
	public override void OnBeginDrag(PointerEventData eventData) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TMP_InputField), Member = "DeactivateInputField", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	public override void OnCancel(BaseEventData eventData) { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	public void OnControlClick() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TMP_InputField), Member = "get_compositionString", ReturnType = typeof(string))]
	[Calls(Type = typeof(TMP_InputField), Member = "DeactivateInputField", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Selectable), Member = "OnDeselect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseEventData)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UnityEngine.Events.UnityEvent`1<System.Object>), Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public virtual void OnDeselect(BaseEventData eventData) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TMP_InputField), Member = "DeactivateInputField", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Graphic), Member = "UnregisterDirtyVerticesCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityAction)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UnityEvent`1), Member = "RemoveListener", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Events.UnityAction`1<T0>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CanvasUpdateRegistry), Member = "UnRegisterCanvasElementForRebuild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ICanvasElement)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CanvasRenderer), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "DestroyImmediate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Selectable), Member = "OnDisable", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 3)]
	protected virtual void OnDisable() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TMP_InputField), Member = "MayDrag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(PointerEventData), Member = "get_pressEventCamera", ReturnType = typeof(Camera))]
	[Calls(Type = typeof(TMP_TextUtilities), Member = "GetCursorIndexFromPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TMP_Text), typeof(Vector3), typeof(Camera), typeof(CaretPosition&)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(TMP_Text), Member = "get_textInfo", ReturnType = typeof(TMP_TextInfo))]
	[Calls(Type = typeof(TMP_InputField), Member = "get_compositionString", ReturnType = typeof(string))]
	[Calls(Type = typeof(TMP_InputField), Member = "ClampCaretPos", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CanvasUpdateRegistry), Member = "RegisterCanvasElementForGraphicRebuild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ICanvasElement)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RectTransformUtility), Member = "RectangleContainsScreenPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform), typeof(Vector2), typeof(Camera)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TMP_InputField), Member = "UpdateKeyboardStringPosition", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 5)]
	public override void OnDrag(PointerEventData eventData) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TouchScreenKeyboard), Member = "get_isInPlaceEditingAllowed", ReturnType = typeof(bool))]
	[Calls(Type = typeof(TMP_InputField), Member = "UpdateLabel", ReturnType = typeof(void))]
	[Calls(Type = typeof(UnityEvent`1), Member = "AddListener", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Events.UnityAction`1<T0>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Graphic), Member = "RegisterDirtyVerticesCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityAction)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Component), Member = "GetComponentsInParent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T[]")]
	[Calls(Type = typeof(TMP_InputField), Member = "AssignPositioningIfNeeded", ReturnType = typeof(void))]
	[Calls(Type = typeof(GameObject), Member = "AddComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(CanvasRenderer), Member = "SetMaterial", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material), typeof(Texture)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Texture2D), Member = "get_whiteTexture", ReturnType = typeof(Texture2D))]
	[Calls(Type = typeof(Graphic), Member = "get_defaultGraphicMaterial", ReturnType = typeof(Material))]
	[Calls(Type = typeof(GameObject), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(GameObject), Member = "set_layer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GameObject), Member = "get_layer", ReturnType = typeof(int))]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(Transform), Member = "SetAsFirstSibling", ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_Text), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(GameObject), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Object), Member = "set_hideFlags", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HideFlags)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GameObject), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Type[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Application), Member = "get_isPlaying", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(string), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(SystemInfo), Member = "get_operatingSystem", ReturnType = typeof(string))]
	[Calls(Type = typeof(Selectable), Member = "OnEnable", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallsUnknownMethods(Count = 13)]
	protected virtual void OnEnable() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TMP_InputField), Member = "MayDrag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(bool))]
	public override void OnEndDrag(PointerEventData eventData) { }

	[CalledBy(Type = typeof(TMP_InputField), Member = "Rebuild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CanvasUpdate)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_InputField), Member = "UpdateGeometry", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(VertexHelper), Member = "FillMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mesh)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_InputField), Member = "UpdateStringIndexFromCaretPosition", ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_InputField), Member = "UpdateCaretPositionFromStringIndex", ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_InputField), Member = "get_compositionString", ReturnType = typeof(string))]
	[Calls(Type = typeof(TMP_InputField), Member = "GenerateHighlight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexHelper), typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UnityEvent`3), Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T0", "T1", "T2"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_InputField), Member = "GenerateCaret", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexHelper), typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_InputField), Member = "SendOnEndTextSelection", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 10)]
	private void OnFillVBO(Mesh vbo) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TMP_InputField), Member = "SelectAll", ReturnType = typeof(void))]
	protected void OnFocus() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Selectable), Member = "OnMove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AxisEventData)}, ReturnType = typeof(void))]
	public virtual void OnMove(AxisEventData eventData) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TMP_InputField), Member = "ActivateInputField", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public override void OnPointerClick(PointerEventData eventData) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TMP_TextUtilities), Member = "FindIntersectingWord", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TMP_Text), typeof(Vector3), typeof(Camera)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(TMP_InputField), Member = "ClampCaretPos", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_InputField), Member = "get_compositionString", ReturnType = typeof(string))]
	[Calls(Type = typeof(TMP_InputField), Member = "set_stringPositionInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_InputField), Member = "set_stringSelectPositionInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_Text), Member = "get_textInfo", ReturnType = typeof(TMP_TextInfo))]
	[Calls(Type = typeof(TMP_TextUtilities), Member = "GetCursorIndexFromPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TMP_Text), typeof(Vector3), typeof(Camera), typeof(CaretPosition&)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(PointerEventData), Member = "get_pressEventCamera", ReturnType = typeof(Camera))]
	[Calls(Type = typeof(TMP_InputField), Member = "UpdateKeyboardStringPosition", ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_InputField), Member = "UpdateLabel", ReturnType = typeof(void))]
	[Calls(Type = typeof(Event), Member = "get_modifiers", ReturnType = typeof(EventModifiers))]
	[Calls(Type = typeof(Event), Member = "PopEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TouchScreenKeyboard), Member = "get_active", ReturnType = typeof(bool))]
	[Calls(Type = typeof(TMP_InputField), Member = "InPlaceEditing", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Selectable), Member = "OnPointerDown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(EventSystem), Member = "SetSelectedGameObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(BaseEventData)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(EventSystem), Member = "get_current", ReturnType = typeof(EventSystem))]
	[Calls(Type = typeof(TMP_InputField), Member = "MayDrag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Time), Member = "get_unscaledTime", ReturnType = typeof(float))]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 2)]
	public virtual void OnPointerDown(PointerEventData eventData) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RectTransform), Member = "get_rect", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(TMP_InputField), Member = "GetScrollPositionRelativeToViewport", ReturnType = typeof(float))]
	[Calls(Type = typeof(TMP_Text), Member = "get_textInfo", ReturnType = typeof(TMP_TextInfo))]
	[Calls(Type = typeof(TMP_InputField), Member = "AdjustTextPositionRelativeToViewport", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Scrollbar), Member = "set_value", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public override void OnScroll(PointerEventData eventData) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TMP_InputField), Member = "AdjustTextPositionRelativeToViewport", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	private void OnScrollbarValueChange(float value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Selectable), Member = "OnSelect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseEventData)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UnityEngine.Events.UnityEvent`1<System.Object>), Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_InputField), Member = "ActivateInputField", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	public virtual void OnSelect(BaseEventData eventData) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Events.UnityEvent`1<System.Object>), Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_InputField), Member = "DeactivateInputField", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	public override void OnSubmit(BaseEventData eventData) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Event), Member = "PopEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Event), Member = "get_rawType", ReturnType = typeof(EventType))]
	[Calls(Type = typeof(Event), Member = "get_commandName", ReturnType = typeof(string))]
	[Calls(Type = typeof(TMP_InputField), Member = "SelectAll", ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_InputField), Member = "get_compositionString", ReturnType = typeof(string))]
	[Calls(Type = typeof(Event), Member = "get_character", ReturnType = typeof(char))]
	[Calls(Type = typeof(Event), Member = "get_modifiers", ReturnType = typeof(EventModifiers))]
	[Calls(Type = typeof(TMP_InputField), Member = "KeyPressed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event)}, ReturnType = typeof(EditState))]
	[Calls(Type = typeof(TMP_InputField), Member = "UpdateLabel", ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_InputField), Member = "SendOnSubmit", ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_InputField), Member = "DeactivateInputField", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public override void OnUpdateSelected(BaseEventData eventData) { }

	[CalledBy(Type = typeof(TMP_InputField), Member = "MovePageDown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TMP_Text), Member = "get_textInfo", ReturnType = typeof(TMP_TextInfo))]
	[Calls(Type = typeof(RectTransform), Member = "get_rect", ReturnType = typeof(Rect))]
	[CallsUnknownMethods(Count = 4)]
	private int PageDownCharacterPosition(int originalPos, bool goToLastChar) { }

	[CalledBy(Type = typeof(TMP_InputField), Member = "MovePageUp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TMP_Text), Member = "get_textInfo", ReturnType = typeof(TMP_TextInfo))]
	[Calls(Type = typeof(RectTransform), Member = "get_rect", ReturnType = typeof(Rect))]
	[CallsUnknownMethods(Count = 4)]
	private int PageUpCharacterPosition(int originalPos, bool goToFirstChar) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TMP_InputField), Member = "KeyPressed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event)}, ReturnType = typeof(EditState))]
	public void ProcessEvent(Event e) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TMP_InputField), Member = "InPlaceEditing", ReturnType = typeof(bool))]
	[Calls(Type = typeof(TMP_InputField), Member = "isUWP", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TMP_InputField), Member = "get_mesh", ReturnType = typeof(Mesh))]
	[Calls(Type = typeof(TMP_InputField), Member = "OnFillVBO", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mesh)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CanvasRenderer), Member = "SetMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mesh)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public override void Rebuild(CanvasUpdate update) { }

	[CalledBy(Type = typeof(TMP_InputField), Member = "LateUpdate", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_InputField), Member = "DeactivateInputField", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CanvasUpdateRegistry), Member = "RegisterCanvasElementForGraphicRebuild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ICanvasElement)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UnityEngine.Events.UnityEvent`1<System.Object>), Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_InputField), Member = "SendOnEndTextSelection", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void ReleaseSelection() { }

	[CalledBy(Type = typeof(TMP_InputField), Member = "OnFocus", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_InputField), Member = "KeyPressed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event)}, ReturnType = typeof(EditState))]
	[CalledBy(Type = typeof(TMP_InputField), Member = "OnUpdateSelected", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_InputField), Member = "ActivateInputFieldInternal", ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[CallsUnknownMethods(Count = 1)]
	protected void SelectAll() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Events.UnityEvent`1<System.Object>), Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	protected void SendOnEndEdit() { }

	[CalledBy(Type = typeof(TMP_InputField), Member = "OnFillVBO", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mesh)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_InputField), Member = "ReleaseSelection", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(TMP_InputField), Member = "get_compositionString", ReturnType = typeof(string))]
	[Calls(Type = typeof(UnityEvent`3), Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T0", "T1", "T2"}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	protected void SendOnEndTextSelection() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Events.UnityEvent`1<System.Object>), Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	protected void SendOnFocus() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Events.UnityEvent`1<System.Object>), Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	protected void SendOnFocusLost() { }

	[CalledBy(Type = typeof(TMP_InputField), Member = "OnUpdateSelected", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseEventData)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Events.UnityEvent`1<System.Object>), Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	protected void SendOnSubmit() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TMP_InputField), Member = "get_compositionString", ReturnType = typeof(string))]
	[Calls(Type = typeof(UnityEvent`3), Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T0", "T1", "T2"}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	protected void SendOnTextSelection() { }

	[CalledBy(Type = typeof(TMP_InputField), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Events.UnityEvent`1<System.Object>), Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	private void SendOnValueChanged() { }

	[CalledBy(Type = typeof(TMP_InputField), Member = "LateUpdate", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_InputField), Member = "KeyPressed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event)}, ReturnType = typeof(EditState))]
	[CalledBy(Type = typeof(TMP_InputField), Member = "DeleteKey", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_InputField), Member = "Backspace", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(TMP_InputField), Member = "UpdateLabel", ReturnType = typeof(void))]
	[Calls(Type = typeof(UnityEngine.Events.UnityEvent`1<System.Object>), Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	private void SendOnValueChangedAndUpdateLabel() { }

	[CalledBy(Type = typeof(TMP_InputField), Member = "LateUpdate", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(TouchScreenKeyboard), Member = "get_status", ReturnType = typeof(Status))]
	[Calls(Type = typeof(UnityEngine.Events.UnityEvent`1<System.Int32Enum>), Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Int32Enum"}, ReturnType = typeof(void))]
	protected void SendTouchScreenKeyboardStatusChanged() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SetPropertyUtility), Member = "SetStruct", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char&), typeof(char)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TMP_InputField), Member = "UpdateLabel", ReturnType = typeof(void))]
	public void set_asteriskChar(char value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SetPropertyUtility), Member = "SetStruct", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Single&), typeof(float)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TMP_InputField), Member = "SetCaretActive", ReturnType = typeof(void))]
	public void set_caretBlinkRate(float value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CanvasUpdateRegistry), Member = "RegisterCanvasElementForGraphicRebuild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ICanvasElement)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	public void set_caretColor(Color value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TMP_InputField), Member = "get_compositionString", ReturnType = typeof(string))]
	[Calls(Type = typeof(TMP_InputField), Member = "ClampCaretPos", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_InputField), Member = "UpdateStringIndexFromCaretPosition", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void set_caretPosition(int value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TMP_InputField), Member = "ClampCaretPos", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&)}, ReturnType = typeof(void))]
	protected void set_caretPositionInternal(int value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TMP_InputField), Member = "ClampCaretPos", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&)}, ReturnType = typeof(void))]
	protected void set_caretSelectPositionInternal(int value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SetPropertyUtility), Member = "SetStruct", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&), typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CanvasUpdateRegistry), Member = "RegisterCanvasElementForGraphicRebuild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ICanvasElement)}, ReturnType = typeof(void))]
	public void set_caretWidth(int value) { }

	[CalledBy(Type = "Scenes.General.TextBox", Member = "Start", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Math), Member = "Max", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(SetPropertyUtility), Member = "SetStruct", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&), typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TMP_InputField), Member = "UpdateLabel", ReturnType = typeof(void))]
	[Calls(Type = typeof(TouchScreenKeyboard), Member = "set_characterLimit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	public void set_characterLimit(int value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SetPropertyUtility), Member = "SetStruct", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"System.Int32Enum"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32Enum&), "System.Int32Enum"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TMP_InputField), Member = "set_contentType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ContentType)}, ReturnType = typeof(void))]
	public void set_characterValidation(CharacterValidation value) { }

	[CalledBy(Type = typeof(TMP_InputField), Member = "KeyPressed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event)}, ReturnType = typeof(EditState))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GUIUtility), Member = "set_systemCopyBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	private static void set_clipboard(string value) { }

	[CalledBy(Type = "Scenes.General.TextBox", Member = "Start", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_InputField), Member = "set_lineType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LineType)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_InputField), Member = "set_inputType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputType)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_InputField), Member = "set_keyboardType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TouchScreenKeyboardType)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_InputField), Member = "set_characterValidation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CharacterValidation)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_InputField), Member = "set_inputValidator", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TMP_InputValidator)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_InputField), Member = "SetToCustomIfContentTypeIsNot", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ContentType[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_InputField), Member = "SetToCustom", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_InputField), Member = "SetToCustom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CharacterValidation)}, ReturnType = typeof(void))]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(SetPropertyUtility), Member = "SetStruct", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"System.Int32Enum"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32Enum&), "System.Int32Enum"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TMP_Text), Member = "set_textWrappingMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextWrappingModes)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	public void set_contentType(ContentType value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CanvasUpdateRegistry), Member = "RegisterCanvasElementForGraphicRebuild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ICanvasElement)}, ReturnType = typeof(void))]
	public void set_customCaretColor(bool value) { }

	[CalledBy(Type = typeof(TMP_DefaultControls), Member = "CreateInputField", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Resources)}, ReturnType = typeof(GameObject))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TMP_Text), Member = "set_font", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TMP_FontAsset)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_InputField), Member = "UpdateLabel", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void set_fontAsset(TMP_FontAsset value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SetPropertyUtility), Member = "SetStruct", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"System.Int32Enum"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32Enum&), "System.Int32Enum"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TMP_InputField), Member = "set_contentType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ContentType)}, ReturnType = typeof(void))]
	public void set_inputType(InputType value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TMP_InputField), Member = "set_contentType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ContentType)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	public void set_inputValidator(TMP_InputValidator value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void set_isRichTextEditingAllowed(bool value) { }

	[CallerCount(Count = 0)]
	public void set_keepTextSelectionVisible(bool value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SetPropertyUtility), Member = "SetStruct", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"System.Int32Enum"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32Enum&), "System.Int32Enum"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TMP_InputField), Member = "set_contentType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ContentType)}, ReturnType = typeof(void))]
	public void set_keyboardType(TouchScreenKeyboardType value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SetPropertyUtility), Member = "SetStruct", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&), typeof(int)}, ReturnType = typeof(bool))]
	public void set_lineLimit(int value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SetPropertyUtility), Member = "SetStruct", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"System.Int32Enum"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32Enum&), "System.Int32Enum"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TMP_InputField), Member = "set_contentType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ContentType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_InputField), Member = "SetTextComponentWrapMode", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	public void set_lineType(LineType value) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void set_onDeselect(SelectionEvent value) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void set_onEndEdit(SubmitEvent value) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void set_onEndTextSelection(TextSelectionEvent value) { }

	[CallerCount(Count = 0)]
	public void set_onFocusSelectAll(bool value) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void set_onSelect(SelectionEvent value) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void set_onSubmit(SubmitEvent value) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void set_onTextSelection(TextSelectionEvent value) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void set_onTouchScreenKeyboardStatusChanged(TouchScreenKeyboardEvent value) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void set_onValidateInput(OnValidateInput value) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void set_onValueChanged(OnChangeEvent value) { }

	[CalledBy(Type = "UI.Dates.DatePicker_TextMeshProUtilities", Member = "ReplaceInputFieldWithTextMeshPro", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputField)}, ReturnType = typeof(TMP_InputField))]
	[CalledBy(Type = typeof(TMP_DefaultControls), Member = "CreateInputField", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Resources)}, ReturnType = typeof(GameObject))]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void set_placeholder(Graphic value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Math), Member = "Max", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(SetPropertyUtility), Member = "SetStruct", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Single&), typeof(float)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TMP_Text), Member = "set_fontSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_InputField), Member = "UpdateLabel", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void set_pointSize(float value) { }

	[CallerCount(Count = 0)]
	public void set_readOnly(bool value) { }

	[CallerCount(Count = 0)]
	public void set_resetOnDeActivation(bool value) { }

	[CallerCount(Count = 0)]
	public void set_restoreOriginalTextOnEscape(bool value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TMP_Text), Member = "set_richText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void set_richText(bool value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SetPropertyUtility), Member = "SetStruct", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Single&), typeof(float)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CanvasUpdateRegistry), Member = "RegisterCanvasElementForGraphicRebuild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ICanvasElement)}, ReturnType = typeof(void))]
	public void set_scrollSensitivity(float value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TMP_InputField), Member = "get_compositionString", ReturnType = typeof(string))]
	[Calls(Type = typeof(TMP_InputField), Member = "ClampCaretPos", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void set_selectionAnchorPosition(int value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CanvasUpdateRegistry), Member = "RegisterCanvasElementForGraphicRebuild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ICanvasElement)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	public void set_selectionColor(Color value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TMP_InputField), Member = "get_compositionString", ReturnType = typeof(string))]
	[Calls(Type = typeof(TMP_InputField), Member = "ClampCaretPos", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void set_selectionFocusPosition(int value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TMP_InputField), Member = "get_compositionString", ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 1)]
	public void set_selectionStringAnchorPosition(int value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TMP_InputField), Member = "get_compositionString", ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 1)]
	public void set_selectionStringFocusPosition(int value) { }

	[CallerCount(Count = 0)]
	public override void set_shouldActivateOnSelect(bool value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Application), Member = "get_platform", ReturnType = typeof(RuntimePlatform))]
	[Calls(Type = typeof(SetPropertyUtility), Member = "SetStruct", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", "T"}, ReturnType = typeof(bool))]
	public void set_shouldHideMobileInput(bool value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Application), Member = "get_platform", ReturnType = typeof(RuntimePlatform))]
	[Calls(Type = typeof(SetPropertyUtility), Member = "SetStruct", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", "T"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TouchScreenKeyboard), Member = "get_isSupported", ReturnType = typeof(bool))]
	[Calls(Type = typeof(TouchScreenKeyboard), Member = "get_active", ReturnType = typeof(bool))]
	[Calls(Type = typeof(TouchScreenKeyboard), Member = "set_active", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	public void set_shouldHideSoftKeyboard(bool value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TMP_InputField), Member = "get_compositionString", ReturnType = typeof(string))]
	[Calls(Type = typeof(TMP_InputField), Member = "UpdateCaretPositionFromStringIndex", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void set_stringPosition(int value) { }

	[CalledBy(Type = typeof(TMP_InputField), Member = "OnPointerDown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_InputField), Member = "Backspace", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_InputField), Member = "Validate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(char)}, ReturnType = typeof(char))]
	[CallerCount(Count = 6)]
	[CallsUnknownMethods(Count = 1)]
	protected void set_stringPositionInternal(int value) { }

	[CalledBy(Type = typeof(TMP_InputField), Member = "OnPointerDown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_InputField), Member = "Backspace", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_InputField), Member = "Validate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(char)}, ReturnType = typeof(char))]
	[CallerCount(Count = 6)]
	[CallsUnknownMethods(Count = 1)]
	protected void set_stringSelectPositionInternal(int value) { }

	[CallerCount(Count = 55)]
	[Calls(Type = typeof(TMP_InputField), Member = "SetText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	public void set_text(string value) { }

	[CalledBy(Type = "UI.Dates.DatePicker_TextMeshProUtilities", Member = "ReplaceInputFieldWithTextMeshPro", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputField)}, ReturnType = typeof(TMP_InputField))]
	[CalledBy(Type = typeof(TMP_DefaultControls), Member = "CreateInputField", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Resources)}, ReturnType = typeof(GameObject))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(TMP_InputField), Member = "SetTextComponentWrapMode", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	public void set_textComponent(TMP_Text value) { }

	[CalledBy(Type = "UI.Dates.DatePicker_TextMeshProUtilities", Member = "ReplaceInputFieldWithTextMeshPro", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputField)}, ReturnType = typeof(TMP_InputField))]
	[CalledBy(Type = typeof(TMP_DefaultControls), Member = "CreateInputField", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Resources)}, ReturnType = typeof(GameObject))]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void set_textViewport(RectTransform value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(UnityEvent`1), Member = "RemoveListener", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Events.UnityAction`1<T0>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(UnityEvent`1), Member = "AddListener", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Events.UnityAction`1<T0>"}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	public void set_verticalScrollbar(Scrollbar value) { }

	[CalledBy(Type = typeof(TMP_InputField), Member = "set_caretBlinkRate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_InputField), Member = "SetCaretVisible", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_InputField), Member = "ActivateInputFieldInternal", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private void SetCaretActive() { }

	[CalledBy(Type = typeof(TMP_InputField), Member = "UpdateLabel", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Time), Member = "get_unscaledTime", ReturnType = typeof(float))]
	[Calls(Type = typeof(TMP_InputField), Member = "SetCaretActive", ReturnType = typeof(void))]
	private void SetCaretVisible() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TMP_Text), Member = "set_font", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TMP_FontAsset)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void SetGlobalFontAsset(TMP_FontAsset fontAsset) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TMP_Text), Member = "set_fontSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void SetGlobalPointSize(float pointSize) { }

	[CalledBy(Type = typeof(TMP_InputField), Member = "set_text", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_InputField), Member = "LateUpdate", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_InputField), Member = "UpdateLabel", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_InputField), Member = "DeactivateInputField", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(string), Member = "Replace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(TouchScreenKeyboard), Member = "set_text", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_InputField), Member = "UpdateLabel", ReturnType = typeof(void))]
	[Calls(Type = typeof(UnityEngine.Events.UnityEvent`1<System.Object>), Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void SetText(string value, bool sendCallback = true) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TMP_Text), Member = "set_richText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private void SetTextComponentRichTextMode() { }

	[CalledBy(Type = typeof(TMP_InputField), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_InputField), Member = "set_textComponent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TMP_Text)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_InputField), Member = "set_lineType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LineType)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TMP_Text), Member = "set_textWrappingMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextWrappingModes)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private void SetTextComponentWrapMode() { }

	[CalledBy(Type = "Scenes.Deck.DeckEdit", Member = "<Awake>b__327_18", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Scenes.Deck.DeckEdit", Member = "<Awake>b__327_29", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Scenes.Deck.DeckEdit", Member = "<Awake>b__327_28", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Scenes.Deck.DeckEdit", Member = "<Awake>b__327_27", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Scenes.Deck.DeckEdit", Member = "<Awake>b__327_26", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Scenes.Deck.DeckEdit", Member = "<Awake>b__327_19", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Scenes.Deck.DeckSelection", Member = "OnClickDeck", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Extensions.BoxSlot", typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Scenes.Deck.DeckEdit", Member = "<Awake>b__327_33", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Scenes.Deck.DeckEdit", Member = "<Awake>b__327_17", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Scenes.Deck.DeckEdit", Member = "ResetFilters", ReturnType = typeof(void))]
	[CalledBy(Type = "Scenes.Deck.DeckEdit", Member = "LoadFilters", ReturnType = typeof(void))]
	[CalledBy(Type = "Scenes.Deck.DeckEdit", Member = "OnEqualizedValueChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Scenes.General.ValueSlider", Member = "OnSlideChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Scenes.General.ValueSlider", Member = "OnInputChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UI.Dates.DatePicker", Member = "OnTextFieldValueChange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Scenes.Deck.DeckEdit", Member = "<Awake>b__327_16", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Scenes.Deck.DeckSelection", Member = "ClearSelection", ReturnType = typeof(void))]
	[CallerCount(Count = 19)]
	[ContainsInvalidInstructions]
	public void SetTextWithoutNotify(string input) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TMP_InputField), Member = "set_contentType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ContentType)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	private void SetToCustom() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TMP_InputField), Member = "set_contentType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ContentType)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	private void SetToCustom(CharacterValidation characterValidation) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TMP_InputField), Member = "set_contentType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ContentType)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	private void SetToCustomIfContentTypeIsNot(ContentType[] allowedContentTypes) { }

	[CalledBy(Type = typeof(TMP_InputField), Member = "ActivateInputFieldInternal", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Application), Member = "get_platform", ReturnType = typeof(RuntimePlatform))]
	[Calls(Type = typeof(TouchScreenKeyboard), Member = "get_isInPlaceEditingAllowed", ReturnType = typeof(bool))]
	[Calls(Type = typeof(TouchScreenKeyboard), Member = "get_isSupported", ReturnType = typeof(bool))]
	private bool TouchScreenKeyboardShouldBeUsed() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[DeduplicatedMethod]
	private override Transform UnityEngine.UI.ICanvasElement.get_transform() { }

	[CalledBy(Type = typeof(TMP_InputField), Member = "set_stringPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_InputField), Member = "ON_TEXT_CHANGED", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_InputField), Member = "OnFillVBO", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mesh)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(TMP_InputField), Member = "get_compositionString", ReturnType = typeof(string))]
	[Calls(Type = typeof(TMP_Text), Member = "get_textInfo", ReturnType = typeof(TMP_TextInfo))]
	[Calls(Type = typeof(TMP_InputField), Member = "ClampCaretPos", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	private void UpdateCaretPositionFromStringIndex() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TMP_InputField), Member = "InPlaceEditing", ReturnType = typeof(bool))]
	[Calls(Type = typeof(TMP_InputField), Member = "isUWP", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TMP_InputField), Member = "get_mesh", ReturnType = typeof(Mesh))]
	[Calls(Type = typeof(TMP_InputField), Member = "OnFillVBO", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mesh)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CanvasRenderer), Member = "SetMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mesh)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private void UpdateGeometry() { }

	[CalledBy(Type = typeof(TMP_InputField), Member = "OnDrag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_InputField), Member = "OnPointerDown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(TouchScreenKeyboard), Member = "get_canSetSelection", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Application), Member = "get_platform", ReturnType = typeof(RuntimePlatform))]
	[Calls(Type = typeof(TMP_InputField), Member = "get_compositionString", ReturnType = typeof(string))]
	[Calls(Type = typeof(TouchScreenKeyboard), Member = "set_selection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RangeInt)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void UpdateKeyboardStringPosition() { }

	[CallerCount(Count = 22)]
	[Calls(Type = typeof(TMP_InputField), Member = "MarkGeometryAsDirty", ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TMP_InputField), Member = "SetText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(TMP_Text), Member = "get_textInfo", ReturnType = typeof(TMP_TextInfo))]
	[Calls(Type = typeof(LayoutRebuilder), Member = "MarkLayoutForRebuild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(TMP_InputField), Member = "SetCaretVisible", ReturnType = typeof(void))]
	[Calls(Type = typeof(Behaviour), Member = "set_enabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "CreateString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(TMP_InputField), Member = "Delete", ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_InputField), Member = "get_compositionString", ReturnType = typeof(string))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 7)]
	protected void UpdateLabel() { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	private void UpdateMaskRegions() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(RectTransform), Member = "get_rect", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(Scrollbar), Member = "set_size", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_InputField), Member = "GetScrollPositionRelativeToViewport", ReturnType = typeof(float))]
	[Calls(Type = typeof(Scrollbar), Member = "set_value", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void UpdateScrollbar() { }

	[CalledBy(Type = typeof(TMP_InputField), Member = "set_caretPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_InputField), Member = "OnFillVBO", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mesh)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(TMP_InputField), Member = "GetStringIndexFromCaretPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 1)]
	private void UpdateStringIndexFromCaretPosition() { }

	[CalledBy(Type = typeof(TMP_InputField), Member = "LateUpdate", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(TouchScreenKeyboard), Member = "get_selection", ReturnType = typeof(RangeInt))]
	[Calls(Type = typeof(TMP_InputField), Member = "get_compositionString", ReturnType = typeof(string))]
	[Calls(Type = typeof(TMP_Text), Member = "get_textInfo", ReturnType = typeof(TMP_TextInfo))]
	[Calls(Type = typeof(TMP_InputField), Member = "ClampCaretPos", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Time), Member = "get_unscaledTime", ReturnType = typeof(float))]
	[Calls(Type = typeof(TMP_InputField), Member = "UpdateLabel", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void UpdateStringPositionFromKeyboard() { }

	[CalledBy(Type = typeof(TMP_InputField), Member = "KeyPressed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event)}, ReturnType = typeof(EditState))]
	[CalledBy(Type = typeof(TMP_InputField), Member = "DeleteKey", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_InputField), Member = "Backspace", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(TMP_InputField), Member = "InPlaceEditing", ReturnType = typeof(bool))]
	[Calls(Type = typeof(TouchScreenKeyboard), Member = "set_text", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private void UpdateTouchKeyboardFromEditChanges() { }

	[CalledBy(Type = typeof(TMP_InputField), Member = "LateUpdate", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_InputField), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(char), Member = "IsLetter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Thread), Member = "get_CurrentThread", ReturnType = typeof(Thread))]
	[Calls(Type = typeof(string), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TMP_InputField), Member = "get_compositionString", ReturnType = typeof(string))]
	[Calls(Type = typeof(char), Member = "ToLower", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(char), Member = "IsUpper", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(char), Member = "ToUpper", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(char), Member = "IsLower", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(Thread), Member = "get_CurrentCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(string), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Regex), Member = "IsMatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TMP_InputField), Member = "set_stringSelectPositionInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_InputField), Member = "set_stringPositionInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Behaviour), Member = "get_enabled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Convert), Member = "ToChar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(char))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	protected char Validate(string text, int pos, char ch) { }

}

