namespace UnityEngine.UIElements;

public class TextElement : BindableElement, INotifyValueChanged<String>, ITextEdition, IExperimentalFeatures, ITextSelection
{
	[Obsolete("UxmlFactory is deprecated and will be removed. Use UxmlElementAttribute instead.", False)]
	internal class UxmlFactory : UxmlFactory<TextElement, UxmlTraits>
	{

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UxmlFactory`2), Member = ".ctor", ReturnType = typeof(void))]
		public UxmlFactory() { }

	}

	[Obsolete("UxmlTraits is deprecated and will be removed. Use UxmlElementAttribute instead.", False)]
	internal class UxmlTraits : UxmlTraits
	{
		private UxmlStringAttributeDescription m_Text; //Field offset: 0x90
		private UxmlBoolAttributeDescription m_EnableRichText; //Field offset: 0x98
		private UxmlBoolAttributeDescription m_EmojiFallbackSupport; //Field offset: 0xA0
		private UxmlBoolAttributeDescription m_ParseEscapeSequences; //Field offset: 0xA8
		private UxmlBoolAttributeDescription m_Selectable; //Field offset: 0xB0
		private UxmlBoolAttributeDescription m_SelectWordByDoubleClick; //Field offset: 0xB8
		private UxmlBoolAttributeDescription m_SelectLineByTripleClick; //Field offset: 0xC0
		private UxmlBoolAttributeDescription m_DisplayTooltipWhenElided; //Field offset: 0xC8

		[CalledBy(Type = typeof(UxmlTraits), Member = ".ctor", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UxmlTraits), Member = ".ctor", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UxmlTraits), Member = ".ctor", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UxmlTraits), Member = ".ctor", ReturnType = typeof(void))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(UxmlStringAttributeDescription), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(UxmlBoolAttributeDescription), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(UxmlTraits), Member = ".ctor", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 17)]
		public UxmlTraits() { }

		[CalledBy(Type = typeof(UxmlTraits), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UxmlTraits), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(UxmlTraits), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(VisualElement), Member = "MarkDirtyRepaint", ReturnType = typeof(void))]
		[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(TextElement), Member = "UpdateVisibleText", ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 9)]
		[CallsUnknownMethods(Count = 5)]
		public virtual void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc) { }

	}

	internal static readonly BindingId displayTooltipWhenElidedProperty; //Field offset: 0x0
	private const string ZeroWidthSpace = "​"; //Field offset: 0x0
	internal static readonly BindingId emojiFallbackSupportProperty; //Field offset: 0x98
	internal static readonly BindingId enableRichTextProperty; //Field offset: 0x130
	internal static readonly BindingId isElidedProperty; //Field offset: 0x1C8
	internal static readonly BindingId parseEscapeSequencesProperty; //Field offset: 0x260
	internal static readonly BindingId textProperty; //Field offset: 0x2F8
	internal static readonly BindingId valueProperty; //Field offset: 0x390
	public static readonly string ussClassName; //Field offset: 0x428
	public static readonly string selectableUssClassName; //Field offset: 0x430
	internal static readonly string k_EllipsisText; //Field offset: 0x438
	internal static readonly BindingId autoCorrectionProperty; //Field offset: 0x440
	internal static readonly BindingId hideSoftKeyboardProperty; //Field offset: 0x4D8
	internal static readonly BindingId hideMobileInputProperty; //Field offset: 0x570
	internal static readonly BindingId keyboardTypeProperty; //Field offset: 0x608
	internal static readonly BindingId isReadOnlyProperty; //Field offset: 0x6A0
	internal static readonly BindingId isPasswordProperty; //Field offset: 0x738
	internal static readonly BindingId maxLengthProperty; //Field offset: 0x7D0
	internal static readonly BindingId maskCharProperty; //Field offset: 0x868
	internal static readonly BindingId isSelectableProperty; //Field offset: 0x900
	internal static readonly BindingId cursorIndexProperty; //Field offset: 0x998
	internal static readonly BindingId selectIndexProperty; //Field offset: 0xA30
	internal static readonly BindingId doubleClickSelectsWordProperty; //Field offset: 0xAC8
	internal static readonly BindingId tripleClickSelectsLineProperty; //Field offset: 0xB60
	internal static readonly BindingId cursorPositionProperty; //Field offset: 0xBF8
	internal static readonly BindingId selectAllOnFocusProperty; //Field offset: 0xC90
	internal static readonly BindingId selectAllOnMouseUpProperty; //Field offset: 0xD28
	internal static readonly BindingId selectionProperty; //Field offset: 0xDC0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private UITKTextHandle <uitkTextHandle>k__BackingField; //Field offset: 0x4B8
	private string m_Text; //Field offset: 0x4C0
	private bool m_EnableRichText; //Field offset: 0x4C8
	private bool m_EmojiFallbackSupport; //Field offset: 0x4C9
	private bool m_ParseEscapeSequences; //Field offset: 0x4CA
	private bool m_DisplayTooltipWhenElided; //Field offset: 0x4CB
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private bool <isElided>k__BackingField; //Field offset: 0x4CC
	internal string elidedText; //Field offset: 0x4D0
	private bool m_WasElided; //Field offset: 0x4D8
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private TextEditingManipulator <editingManipulator>k__BackingField; //Field offset: 0x4E0
	internal bool isInputField; //Field offset: 0x4E8
	private bool m_Multiline; //Field offset: 0x4E9
	internal TouchScreenKeyboard m_TouchScreenKeyboard; //Field offset: 0x4F0
	internal Action<Boolean> onIsReadOnlyChanged; //Field offset: 0x4F8
	internal TouchScreenKeyboardType m_KeyboardType; //Field offset: 0x500
	private bool m_HideSoftKeyboard; //Field offset: 0x504
	private bool m_HideMobileInput; //Field offset: 0x505
	private bool m_IsReadOnly; //Field offset: 0x506
	private int m_MaxLength; //Field offset: 0x508
	private string m_PlaceholderText; //Field offset: 0x510
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private bool <UnityEngine.UIElements.ITextEdition.isDelayed>k__BackingField; //Field offset: 0x518
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private Func<Char, Boolean> <UnityEngine.UIElements.ITextEdition.AcceptCharacter>k__BackingField; //Field offset: 0x520
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private Action<Boolean> <UnityEngine.UIElements.ITextEdition.UpdateScrollOffset>k__BackingField; //Field offset: 0x528
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private Action <UnityEngine.UIElements.ITextEdition.UpdateValueFromText>k__BackingField; //Field offset: 0x530
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private Action <UnityEngine.UIElements.ITextEdition.UpdateTextFromValue>k__BackingField; //Field offset: 0x538
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private Action <UnityEngine.UIElements.ITextEdition.MoveFocusToCompositeRoot>k__BackingField; //Field offset: 0x540
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private Action <OnPlaceholderChanged>k__BackingField; //Field offset: 0x548
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private Func<String> <UnityEngine.UIElements.ITextEdition.GetDefaultValueType>k__BackingField; //Field offset: 0x550
	private string m_RenderedText; //Field offset: 0x558
	private string m_OriginalText; //Field offset: 0x560
	private char m_MaskChar; //Field offset: 0x568
	private bool m_IsPassword; //Field offset: 0x56A
	private bool m_HidePlaceholderTextOnFocus; //Field offset: 0x56B
	private bool m_AutoCorrection; //Field offset: 0x56C
	private TextSelectingManipulator m_SelectingManipulator; //Field offset: 0x570
	private bool m_IsSelectable; //Field offset: 0x578
	private bool m_DoubleClickSelectsWord; //Field offset: 0x579
	private bool m_TripleClickSelectsLine; //Field offset: 0x57A
	private bool m_SelectAllOnFocus; //Field offset: 0x57B
	private bool m_SelectAllOnMouseUp; //Field offset: 0x57C
	private Color m_SelectionColor; //Field offset: 0x580
	private Color m_CursorColor; //Field offset: 0x590
	private float m_CursorWidth; //Field offset: 0x5A0

	[CreateProperty]
	private bool autoCorrection
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		private get { } //Length: 72
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		private set { } //Length: 88
	}

	internal Color cursorColor
	{
		[CallerCount(Count = 0)]
		internal get { } //Length: 14
		[CalledBy(Type = typeof(TextInputBase), Member = "OnInputCustomStyleResolved", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CustomStyleResolvedEvent)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(VisualElement), Member = "MarkDirtyRepaint", ReturnType = typeof(void))]
		internal set { } //Length: 112
	}

	[CreateProperty]
	private int cursorIndex
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		private get { } //Length: 72
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		private set { } //Length: 86
	}

	[CreateProperty(ReadOnly = True)]
	private Vector2 cursorPosition
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		private get { } //Length: 72
	}

	[CreateProperty]
	public bool displayTooltipWhenElided
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 8
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(TextElement), Member = "UpdateVisibleText", ReturnType = typeof(void))]
		[Calls(Type = typeof(VisualElement), Member = "MarkDirtyRepaint", ReturnType = typeof(void))]
		[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
		 set { } //Length: 140
	}

	[CreateProperty]
	internal bool doubleClickSelectsWord
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		internal get { } //Length: 72
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		internal set { } //Length: 88
	}

	internal TextEditingManipulator editingManipulator
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		internal get { } //Length: 8
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private set { } //Length: 19
	}

	internal ITextEdition edition
	{
		[CallerCount(Count = 2063)]
		[DeduplicatedMethod]
		internal get { } //Length: 4
	}

	private char effectiveMaskChar
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		private get { } //Length: 92
	}

	[CreateProperty]
	public bool emojiFallbackSupport
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 8
		[CalledBy(Type = typeof(TextInputBaseField`1), Member = "set_emojiFallbackSupport", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(VisualElement), Member = "MarkDirtyRepaint", ReturnType = typeof(void))]
		[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
		 set { } //Length: 137
	}

	[CreateProperty]
	public bool enableRichText
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 8
		[CalledBy(Type = typeof(TextInputBase), Member = ".ctor", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(VisualElement), Member = "MarkDirtyRepaint", ReturnType = typeof(void))]
		[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
		 set { } //Length: 137
	}

	internal bool hasFocus
	{
		[CalledBy(Type = typeof(TextInputBaseField`1), Member = "get_canSwitchToMixedValue", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(TextSelectingManipulator), Member = "OnValidateCommandEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ValidateCommandEvent)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TextSelectingManipulator), Member = "OnKeyDown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(KeyDownEvent)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TextSelectingManipulator), Member = "HandleEventBubbleUp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TextSelectingManipulator), Member = "HasFocus", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(TextValueField`1), Member = "HandleEventBubbleUp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TextSelectingManipulator), Member = "OnExecuteCommandEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExecuteCommandEvent)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TextInputBase), Member = "GetScrollOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(float), typeof(bool), typeof(bool)}, ReturnType = typeof(Vector2))]
		[CalledBy(Type = typeof(TextInputBase), Member = "SetSingleLine", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(KeyboardTextEditorEventHandler), Member = "OnExecuteCommandEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExecuteCommandEvent)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(KeyboardTextEditorEventHandler), Member = "OnValidateCommandEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ValidateCommandEvent)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(KeyboardTextEditorEventHandler), Member = "OnKeyDown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(KeyDownEvent)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(KeyboardTextEditorEventHandler), Member = "HandleEventBubbleUp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(BaseSlider`1), Member = "get_canSwitchToMixedValue", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(TextInputBase), Member = "SetMultiline", ReturnType = typeof(void))]
		[CallerCount(Count = 17)]
		[Calls(Type = typeof(FocusController), Member = "GetLeafFocusedElement", ReturnType = typeof(Focusable))]
		[CallsDeduplicatedMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		internal get { } //Length: 116
	}

	[CreateProperty]
	private bool hideMobileInput
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		private get { } //Length: 72
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		private set { } //Length: 88
	}

	[CreateProperty]
	private bool hideSoftKeyboard
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		private get { } //Length: 72
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		private set { } //Length: 88
	}

	[CreateProperty(ReadOnly = True)]
	public private bool isElided
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		 get { } //Length: 8
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		private set { } //Length: 7
	}

	[CreateProperty]
	private bool isPassword
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		private get { } //Length: 72
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		private set { } //Length: 88
	}

	[CreateProperty]
	private bool isReadOnly
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		private get { } //Length: 72
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		private set { } //Length: 88
	}

	[CreateProperty]
	internal bool isSelectable
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		internal get { } //Length: 69
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		internal set { } //Length: 88
	}

	[CreateProperty]
	private TouchScreenKeyboardType keyboardType
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		private get { } //Length: 72
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		private set { } //Length: 86
	}

	[CreateProperty]
	private char maskChar
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 2)]
		private get { } //Length: 181
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		private set { } //Length: 179
	}

	[CreateProperty]
	private int maxLength
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		private get { } //Length: 72
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		private set { } //Length: 86
	}

	internal bool needsPlaceholderIfTextIsEmpty
	{
		[CalledBy(Type = typeof(TextInputBaseField`1), Member = "SetValueWithoutNotify", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TValueType"}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(FocusController), Member = "GetLeafFocusedElement", ReturnType = typeof(Focusable))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		[ContainsUnimplementedInstructions]
		internal get { } //Length: 187
	}

	internal Action OnPlaceholderChanged
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		internal get { } //Length: 8
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		internal set { } //Length: 19
	}

	internal string originalText
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		internal get { } //Length: 8
	}

	[CreateProperty]
	public bool parseEscapeSequences
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 8
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(VisualElement), Member = "MarkDirtyRepaint", ReturnType = typeof(void))]
		[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
		 set { } //Length: 137
	}

	internal RenderedText renderedText
	{
		[CalledBy(Type = typeof(UITKTextHandle), Member = "ConvertUssToNativeTextGenerationSettings", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(UITKTextHandle), Member = "ConvertUssToTextGenerationSettings", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(TextElement), Member = "DoMeasure", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(MeasureMode), typeof(float), typeof(MeasureMode)}, ReturnType = typeof(Vector2))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(FocusController), Member = "GetLeafFocusedElement", ReturnType = typeof(Focusable))]
		[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(TextUtilities), Member = "IsAdvancedTextEnabledForElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(bool))]
		[Calls(Type = "UnityEngine.TextCore.Text.RenderedText", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = "UnityEngine.TextCore.Text.RenderedText", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(int), typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(VisualElement), Member = "get_pseudoStates", ReturnType = typeof(PseudoStates))]
		[Calls(Type = "UnityEngine.TextCore.Text.RenderedText", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 7)]
		[ContainsUnimplementedInstructions]
		internal get { } //Length: 871
	}

	[CreateProperty]
	private bool selectAllOnFocus
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		private get { } //Length: 72
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		private set { } //Length: 88
	}

	[CreateProperty]
	private bool selectAllOnMouseUp
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		private get { } //Length: 72
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		private set { } //Length: 88
	}

	[CreateProperty]
	private int selectIndex
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		private get { } //Length: 72
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		private set { } //Length: 86
	}

	internal TextSelectingManipulator selectingManipulator
	{
		[CalledBy(Type = typeof(TextEditingManipulator), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextElement)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TextEditingManipulator), Member = "HandleEventBubbleUp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TextElement), Member = "OnGenerateTextOver", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshGenerationContext)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TextElement), Member = "OnGenerateTextOverNative", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshGenerationContext)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TextElement), Member = "EditionHandleEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TextElement), Member = "UnityEngine.UIElements.ITextSelection.get_cursorIndex", ReturnType = typeof(int))]
		[CalledBy(Type = typeof(TextElement), Member = "UnityEngine.UIElements.ITextSelection.set_cursorIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TextElement), Member = "UnityEngine.UIElements.ITextSelection.get_selectIndex", ReturnType = typeof(int))]
		[CalledBy(Type = typeof(TextElement), Member = "UnityEngine.UIElements.ITextSelection.set_selectIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TextElement), Member = "UnityEngine.UIElements.ITextSelection.SelectAll", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TextElement), Member = "UnityEngine.UIElements.ITextSelection.SelectNone", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TextElement), Member = "UnityEngine.UIElements.ITextSelection.HasSelection", ReturnType = typeof(bool))]
		[CallerCount(Count = 14)]
		[Calls(Type = typeof(TextSelectingManipulator), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextElement)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
		internal get { } //Length: 119
	}

	[CreateProperty(ReadOnly = True)]
	public ITextSelection selection
	{
		[CallerCount(Count = 2063)]
		[DeduplicatedMethod]
		 get { } //Length: 4
	}

	internal Color selectionColor
	{
		[CallerCount(Count = 0)]
		internal get { } //Length: 14
		[CalledBy(Type = typeof(TextInputBase), Member = "OnInputCustomStyleResolved", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CustomStyleResolvedEvent)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(VisualElement), Member = "MarkDirtyRepaint", ReturnType = typeof(void))]
		internal set { } //Length: 112
	}

	internal bool showPlaceholderText
	{
		[CalledBy(Type = typeof(TextInputBaseField`1), Member = "UpdatePlaceholderClassList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.ChangeEvent`1<TValueType>"}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UITKTextHandle), Member = "ConvertUssToTextGenerationSettings", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(UITKTextHandle), Member = "get_IsPlaceholder", ReturnType = typeof(bool))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(FocusController), Member = "GetLeafFocusedElement", ReturnType = typeof(Focusable))]
		[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 2)]
		[ContainsUnimplementedInstructions]
		internal get { } //Length: 218
	}

	[CreateProperty]
	public override string text
	{
		[CalledBy(Type = typeof(Button), Member = "set_text", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 59
		[CalledBy(Type = typeof(Button), Member = "set_text", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Button), Member = "UpdateButtonHierarchy", ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[CallsUnknownMethods(Count = 1)]
		 set { } //Length: 77
	}

	[CreateProperty]
	internal bool tripleClickSelectsLine
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		internal get { } //Length: 72
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		internal set { } //Length: 88
	}

	internal UITKTextHandle uitkTextHandle
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		internal get { } //Length: 8
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		internal set { } //Length: 19
	}

	private override string UnityEngine.UIElements.INotifyValueChanged<System.String>.value
	{
		[CallerCount(Count = 0)]
		private get { } //Length: 36
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(VisualElement), Member = "get_panel", ReturnType = typeof(IPanel))]
		[Calls(Type = typeof(UnityEngine.UIElements.ChangeEvent`1<System.Object>), Member = "GetPooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(UnityEngine.UIElements.ChangeEvent`1<System.Object>))]
		[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 7)]
		private set { } //Length: 511
	}

	private override Func<Char, Boolean> UnityEngine.UIElements.ITextEdition.AcceptCharacter
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private get { } //Length: 8
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		private set { } //Length: 19
	}

	private override bool UnityEngine.UIElements.ITextEdition.autoCorrection
	{
		[CallerCount(Count = 0)]
		private get { } //Length: 8
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
		private set { } //Length: 127
	}

	private override Func<String> UnityEngine.UIElements.ITextEdition.GetDefaultValueType
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private get { } //Length: 8
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private set { } //Length: 19
	}

	private override bool UnityEngine.UIElements.ITextEdition.hideMobileInput
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(TouchScreenKeyboard), Member = "get_inputFieldAppearance", ReturnType = typeof(InputFieldAppearance))]
		private get { } //Length: 49
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(TouchScreenKeyboard), Member = "get_inputFieldAppearance", ReturnType = typeof(InputFieldAppearance))]
		[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
		private set { } //Length: 137
	}

	private override bool UnityEngine.UIElements.ITextEdition.hidePlaceholderOnFocus
	{
		[CallerCount(Count = 0)]
		private get { } //Length: 8
		[CallerCount(Count = 0)]
		private set { } //Length: 7
	}

	private override bool UnityEngine.UIElements.ITextEdition.hideSoftKeyboard
	{
		[CallerCount(Count = 0)]
		private get { } //Length: 8
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
		private set { } //Length: 127
	}

	private override bool UnityEngine.UIElements.ITextEdition.isDelayed
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		private get { } //Length: 8
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		private set { } //Length: 7
	}

	private override bool UnityEngine.UIElements.ITextEdition.isPassword
	{
		[CallerCount(Count = 0)]
		private get { } //Length: 8
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
		private set { } //Length: 143
	}

	private override bool UnityEngine.UIElements.ITextEdition.isReadOnly
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(VisualElement), Member = "get_enabledInHierarchy", ReturnType = typeof(bool))]
		private get { } //Length: 34
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(TextEditingManipulator), Member = "Reset", ReturnType = typeof(void))]
		[Calls(Type = typeof(TextEditingManipulator), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextElement)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		private set { } //Length: 259
	}

	private override TouchScreenKeyboardType UnityEngine.UIElements.ITextEdition.keyboardType
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		private get { } //Length: 7
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
		private set { } //Length: 124
	}

	private override char UnityEngine.UIElements.ITextEdition.maskChar
	{
		[CallerCount(Count = 0)]
		private get { } //Length: 8
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		private set { } //Length: 179
	}

	private override int UnityEngine.UIElements.ITextEdition.maxLength
	{
		[CallerCount(Count = 0)]
		private get { } //Length: 7
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		private set { } //Length: 201
	}

	private override Action UnityEngine.UIElements.ITextEdition.MoveFocusToCompositeRoot
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private get { } //Length: 8
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private set { } //Length: 19
	}

	private override bool UnityEngine.UIElements.ITextEdition.multiline
	{
		[CallerCount(Count = 0)]
		private get { } //Length: 8
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		private set { } //Length: 125
	}

	private override string UnityEngine.UIElements.ITextEdition.placeholder
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		private get { } //Length: 8
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(string), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(VisualElement), Member = "MarkDirtyRepaint", ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 7)]
		[CallsUnknownMethods(Count = 3)]
		private set { } //Length: 425
	}

	private override TouchScreenKeyboard UnityEngine.UIElements.ITextEdition.touchScreenKeyboard
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		private get { } //Length: 8
	}

	private override Action<Boolean> UnityEngine.UIElements.ITextEdition.UpdateScrollOffset
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private get { } //Length: 8
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		private set { } //Length: 19
	}

	private override Action UnityEngine.UIElements.ITextEdition.UpdateTextFromValue
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private get { } //Length: 8
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private set { } //Length: 19
	}

	private override Action UnityEngine.UIElements.ITextEdition.UpdateValueFromText
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private get { } //Length: 8
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		private set { } //Length: 19
	}

	private override int UnityEngine.UIElements.ITextSelection.cursorIndex
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(TextElement), Member = "get_selectingManipulator", ReturnType = typeof(TextSelectingManipulator))]
		[Calls(Type = typeof(TextSelectingManipulator), Member = "get_cursorIndex", ReturnType = typeof(int))]
		[CallsUnknownMethods(Count = 2)]
		private get { } //Length: 109
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(TextElement), Member = "get_selectingManipulator", ReturnType = typeof(TextSelectingManipulator))]
		[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 4)]
		private set { } //Length: 241
	}

	private override Vector2 UnityEngine.UIElements.ITextSelection.cursorPosition
	{
		[CallerCount(Count = 0)]
		[Calls(Type = "UnityEngine.TextCore.Text.TextHandle", Member = "GetCursorPositionFromStringIndexUsingLineHeight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool), typeof(bool)}, ReturnType = typeof(Vector2))]
		[Calls(Type = typeof(VisualElement), Member = "get_contentRect", ReturnType = typeof(Rect))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		private get { } //Length: 217
	}

	private override float UnityEngine.UIElements.ITextSelection.cursorWidth
	{
		[CallerCount(Count = 0)]
		private get { } //Length: 9
	}

	private override bool UnityEngine.UIElements.ITextSelection.doubleClickSelectsWord
	{
		[CallerCount(Count = 0)]
		private get { } //Length: 8
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
		private set { } //Length: 127
	}

	private override bool UnityEngine.UIElements.ITextSelection.isSelectable
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		private get { } //Length: 54
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(VisualElement), Member = "EnableInClassList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		private set { } //Length: 186
	}

	private override float UnityEngine.UIElements.ITextSelection.lineHeightAtCursorPosition
	{
		[CallerCount(Count = 0)]
		[Calls(Type = "UnityEngine.TextCore.Text.TextHandle", Member = "GetLineHeightFromCharacterIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(float))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		private get { } //Length: 130
	}

	private override bool UnityEngine.UIElements.ITextSelection.selectAllOnFocus
	{
		[CallerCount(Count = 0)]
		private get { } //Length: 8
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
		private set { } //Length: 127
	}

	private override bool UnityEngine.UIElements.ITextSelection.selectAllOnMouseUp
	{
		[CallerCount(Count = 0)]
		private get { } //Length: 8
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
		private set { } //Length: 127
	}

	private override int UnityEngine.UIElements.ITextSelection.selectIndex
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(TextElement), Member = "get_selectingManipulator", ReturnType = typeof(TextSelectingManipulator))]
		[Calls(Type = typeof(TextSelectingManipulator), Member = "get_selectIndex", ReturnType = typeof(int))]
		[CallsUnknownMethods(Count = 2)]
		private get { } //Length: 109
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(TextElement), Member = "get_selectingManipulator", ReturnType = typeof(TextSelectingManipulator))]
		[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 4)]
		private set { } //Length: 241
	}

	private override bool UnityEngine.UIElements.ITextSelection.tripleClickSelectsLine
	{
		[CallerCount(Count = 0)]
		private get { } //Length: 8
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
		private set { } //Length: 127
	}

	[CreateProperty]
	private string value
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		private get { } //Length: 59
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		private set { } //Length: 77
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BindingId), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(BindingId))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 27)]
	private static TextElement() { }

	[CalledBy(Type = "UnityEngine.UIElements.BasePopupField`2+PopupTextElement", Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RepeatButton), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action), typeof(long), typeof(long)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PopupWindow), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Label), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextInputBase), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RepeatButton), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Button), Member = "UpdateButtonHierarchy", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Button), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Button), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Background), typeof(Action)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Button), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(EnumField), Member = "Initialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Enum)}, ReturnType = typeof(void))]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(BindableElement), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "set_requireMeasureFunction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Focusable), Member = "set_tabIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UITKTextHandle), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextElement)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "AddToClassList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 7)]
	public TextElement() { }

	[CalledBy(Type = typeof(TextElement), Member = "EditionHandleEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DropdownMenu), Member = "AppendAction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(System.Action`1<UnityEngine.UIElements.DropdownMenuAction>), typeof(System.Func`2<UnityEngine.UIElements.DropdownMenuAction, UnityEngine.UIElements.DropdownMenuAction+Status>), typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallsUnknownMethods(Count = 2)]
	private void BuildContextualMenu(ContextualMenuPopulateEvent evt) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TextElement), Member = "ProcessMenuCommand", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	private void Copy(DropdownMenuAction a) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VisualElement), Member = "get_enabledInHierarchy", ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 3)]
	private Status CopyActionStatus(DropdownMenuAction a) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TextElement), Member = "ProcessMenuCommand", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	private void Cut(DropdownMenuAction a) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VisualElement), Member = "get_enabledInHierarchy", ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 3)]
	private Status CutActionStatus(DropdownMenuAction a) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TextElement), Member = "get_renderedText", ReturnType = "UnityEngine.TextCore.Text.RenderedText")]
	[Calls(Type = typeof(TextUtilities), Member = "MeasureVisualElementTextSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextElement), typeof(RenderedText&), typeof(float), typeof(MeasureMode), typeof(float), typeof(MeasureMode)}, ReturnType = typeof(Vector2))]
	protected private virtual Vector2 DoMeasure(float desiredWidth, MeasureMode widthMode, float desiredHeight, MeasureMode heightMode) { }

	[CalledBy(Type = typeof(TextElement), Member = "OnGenerateTextOver", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshGenerationContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextElement), Member = "OnGenerateTextOverNative", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshGenerationContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(VisualElement), Member = "get_playModeTintColor", ReturnType = typeof(Color))]
	[Calls(Type = "UnityEngine.TextCore.Text.TextHandle", Member = "GetCharacterHeightFromIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(VisualElement), Member = "get_scaledPixelsPerPoint", ReturnType = typeof(float))]
	[Calls(Type = typeof(AlignmentUtils), Member = "CeilToPixelGrid", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(float)}, ReturnType = typeof(float))]
	[CallsUnknownMethods(Count = 7)]
	internal void DrawCaret(MeshGenerationContext mgc) { }

	[CalledBy(Type = typeof(TextElement), Member = "OnGenerateTextOver", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshGenerationContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(VisualElement), Member = "get_playModeTintColor", ReturnType = typeof(Color))]
	[Calls(Type = typeof(Math), Member = "Min", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Math), Member = "Max", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = "UnityEngine.TextCore.Text.TextHandle", Member = "GetCursorPositionFromStringIndexUsingLineHeight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool), typeof(bool)}, ReturnType = typeof(Vector2))]
	[Calls(Type = "UnityEngine.TextCore.Text.TextHandle", Member = "GetLineNumber", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = "UnityEngine.TextCore.Text.TextHandle", Member = "GetLineHeight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(VisualElement), Member = "get_contentRect", ReturnType = typeof(Rect))]
	[Calls(Type = "UnityEngine.TextCore.Text.TextHandle", Member = "get_textInfo", ReturnType = "UnityEngine.TextCore.Text.TextInfo")]
	[Calls(Type = typeof(TouchScreenKeyboard), Member = "set_selection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RangeInt)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TextElement), Member = "GetLastCharacterAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 18)]
	private void DrawHighlighting(MeshGenerationContext mgc) { }

	[CalledBy(Type = typeof(TextElement), Member = "OnGenerateTextOverNative", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshGenerationContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(VisualElement), Member = "get_playModeTintColor", ReturnType = typeof(Color))]
	[Calls(Type = typeof(Math), Member = "Min", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Math), Member = "Max", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = "UnityEngine.TextCore.Text.TextHandle", Member = "GetHighlightRectangles", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(Rect[]))]
	[Calls(Type = typeof(VisualElement), Member = "get_contentRect", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(TouchScreenKeyboard), Member = "set_selection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RangeInt)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 10)]
	private void DrawNativeHighlighting(MeshGenerationContext mgc) { }

	[CalledBy(Type = typeof(TextElement), Member = "HandleEventBubbleUp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = "UnityEngine.TextEditingUtilities", Member = "TouchScreenKeyboardCanBeUsed", ReturnType = typeof(bool))]
	[Calls(Type = typeof(TextElement), Member = "get_selectingManipulator", ReturnType = typeof(TextSelectingManipulator))]
	[Calls(Type = typeof(TextSelectingManipulator), Member = "HandleEventBubbleUp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TextEditingManipulator), Member = "HandleEventBubbleUp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(EventBase`1), Member = "TypeId", ReturnType = typeof(long))]
	[Calls(Type = typeof(TextElement), Member = "BuildContextualMenu", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ContextualMenuPopulateEvent)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DropdownMenu), Member = "InsertSeparator", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 5)]
	[ContainsUnimplementedInstructions]
	private void EditionHandleEvent(EventBase evt) { }

	[CalledBy(Type = typeof(TextElement), Member = "UpdateVisibleText", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
	[Calls(Type = typeof(VisualElement), Member = "get_scaledPixelsPerPoint", ReturnType = typeof(float))]
	[Calls(Type = "UnityEngine.TextCore.Text.RenderedText", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TextUtilities), Member = "MeasureVisualElementTextSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextElement), typeof(RenderedText&), typeof(float), typeof(MeasureMode), typeof(float), typeof(MeasureMode)}, ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TextElement), Member = "MeasureTextSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(float), typeof(MeasureMode), typeof(float), typeof(MeasureMode)}, ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	internal string ElideText(string drawText, string ellipsisText, float width, TextOverflowPosition textOverflowPosition) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private bool get_autoCorrection() { }

	[CallerCount(Count = 0)]
	internal Color get_cursorColor() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private int get_cursorIndex() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private Vector2 get_cursorPosition() { }

	[CallerCount(Count = 0)]
	public bool get_displayTooltipWhenElided() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	internal bool get_doubleClickSelectsWord() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	internal TextEditingManipulator get_editingManipulator() { }

	[CallerCount(Count = 2063)]
	[DeduplicatedMethod]
	internal ITextEdition get_edition() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private char get_effectiveMaskChar() { }

	[CallerCount(Count = 0)]
	public bool get_emojiFallbackSupport() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public bool get_enableRichText() { }

	[CalledBy(Type = typeof(TextInputBaseField`1), Member = "get_canSwitchToMixedValue", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TextInputBase), Member = "SetMultiline", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BaseSlider`1), Member = "get_canSwitchToMixedValue", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(KeyboardTextEditorEventHandler), Member = "HandleEventBubbleUp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(KeyboardTextEditorEventHandler), Member = "OnKeyDown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(KeyDownEvent)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(KeyboardTextEditorEventHandler), Member = "OnValidateCommandEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ValidateCommandEvent)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextInputBase), Member = "SetSingleLine", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(KeyboardTextEditorEventHandler), Member = "OnExecuteCommandEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExecuteCommandEvent)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextSelectingManipulator), Member = "OnExecuteCommandEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExecuteCommandEvent)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextValueField`1), Member = "HandleEventBubbleUp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextSelectingManipulator), Member = "HasFocus", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TextSelectingManipulator), Member = "HandleEventBubbleUp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextSelectingManipulator), Member = "OnKeyDown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(KeyDownEvent)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextSelectingManipulator), Member = "OnValidateCommandEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ValidateCommandEvent)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextInputBase), Member = "GetScrollOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(float), typeof(bool), typeof(bool)}, ReturnType = typeof(Vector2))]
	[CallerCount(Count = 17)]
	[Calls(Type = typeof(FocusController), Member = "GetLeafFocusedElement", ReturnType = typeof(Focusable))]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	internal bool get_hasFocus() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private bool get_hideMobileInput() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private bool get_hideSoftKeyboard() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	public bool get_isElided() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private bool get_isPassword() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private bool get_isReadOnly() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	internal bool get_isSelectable() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private TouchScreenKeyboardType get_keyboardType() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	private char get_maskChar() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private int get_maxLength() { }

	[CalledBy(Type = typeof(TextInputBaseField`1), Member = "SetValueWithoutNotify", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TValueType"}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(FocusController), Member = "GetLeafFocusedElement", ReturnType = typeof(Focusable))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	internal bool get_needsPlaceholderIfTextIsEmpty() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	internal Action get_OnPlaceholderChanged() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	internal string get_originalText() { }

	[CallerCount(Count = 0)]
	public bool get_parseEscapeSequences() { }

	[CalledBy(Type = typeof(UITKTextHandle), Member = "ConvertUssToNativeTextGenerationSettings", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(UITKTextHandle), Member = "ConvertUssToTextGenerationSettings", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TextElement), Member = "DoMeasure", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(MeasureMode), typeof(float), typeof(MeasureMode)}, ReturnType = typeof(Vector2))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(FocusController), Member = "GetLeafFocusedElement", ReturnType = typeof(Focusable))]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TextUtilities), Member = "IsAdvancedTextEnabledForElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(bool))]
	[Calls(Type = "UnityEngine.TextCore.Text.RenderedText", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = "UnityEngine.TextCore.Text.RenderedText", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(int), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "get_pseudoStates", ReturnType = typeof(PseudoStates))]
	[Calls(Type = "UnityEngine.TextCore.Text.RenderedText", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 7)]
	[ContainsUnimplementedInstructions]
	internal RenderedText get_renderedText() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private bool get_selectAllOnFocus() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private bool get_selectAllOnMouseUp() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private int get_selectIndex() { }

	[CalledBy(Type = typeof(TextEditingManipulator), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextElement)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextEditingManipulator), Member = "HandleEventBubbleUp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextElement), Member = "OnGenerateTextOver", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshGenerationContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextElement), Member = "OnGenerateTextOverNative", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshGenerationContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextElement), Member = "EditionHandleEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextElement), Member = "UnityEngine.UIElements.ITextSelection.get_cursorIndex", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(TextElement), Member = "UnityEngine.UIElements.ITextSelection.set_cursorIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextElement), Member = "UnityEngine.UIElements.ITextSelection.get_selectIndex", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(TextElement), Member = "UnityEngine.UIElements.ITextSelection.set_selectIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextElement), Member = "UnityEngine.UIElements.ITextSelection.SelectAll", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextElement), Member = "UnityEngine.UIElements.ITextSelection.SelectNone", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextElement), Member = "UnityEngine.UIElements.ITextSelection.HasSelection", ReturnType = typeof(bool))]
	[CallerCount(Count = 14)]
	[Calls(Type = typeof(TextSelectingManipulator), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextElement)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal TextSelectingManipulator get_selectingManipulator() { }

	[CallerCount(Count = 2063)]
	[DeduplicatedMethod]
	public ITextSelection get_selection() { }

	[CallerCount(Count = 0)]
	internal Color get_selectionColor() { }

	[CalledBy(Type = typeof(TextInputBaseField`1), Member = "UpdatePlaceholderClassList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.ChangeEvent`1<TValueType>"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UITKTextHandle), Member = "ConvertUssToTextGenerationSettings", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(UITKTextHandle), Member = "get_IsPlaceholder", ReturnType = typeof(bool))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(FocusController), Member = "GetLeafFocusedElement", ReturnType = typeof(Focusable))]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	internal bool get_showPlaceholderText() { }

	[CalledBy(Type = typeof(Button), Member = "set_text", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public override string get_text() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	internal bool get_tripleClickSelectsLine() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	internal UITKTextHandle get_uitkTextHandle() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private string get_value() { }

	[CallerCount(Count = 0)]
	private string GetDefaultValueType() { }

	[CalledBy(Type = typeof(TextElement), Member = "DrawHighlighting", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshGenerationContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = "UnityEngine.TextCore.Text.TextHandle", Member = "get_textInfo", ReturnType = "UnityEngine.TextCore.Text.TextInfo")]
	[CallsUnknownMethods(Count = 3)]
	private int GetLastCharacterAt(int lineIndex) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TextElement), Member = "UpdateVisibleText", ReturnType = typeof(void))]
	[Calls(Type = "UnityEngine.TextCore.Text.TextHandle", Member = "RemoveTextInfoFromPermanentCache", ReturnType = typeof(void))]
	[Calls(Type = "UnityEngine.TextCore.Text.TextHandle", Member = "RemoveTextInfoFromTemporaryCache", ReturnType = typeof(void))]
	[Calls(Type = typeof(TextElement), Member = "EditionHandleEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[EventInterest(new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(ContextualMenuPopulateEvent), typeof(KeyDownEvent), typeof(KeyUpEvent), typeof(ValidateCommandEvent), typeof(ExecuteCommandEvent), typeof(FocusEvent), typeof(BlurEvent), typeof(FocusInEvent), typeof(FocusOutEvent), typeof(PointerDownEvent), typeof(PointerUpEvent), typeof(PointerMoveEvent), typeof(NavigationMoveEvent), typeof(NavigationSubmitEvent), typeof(NavigationCancelEvent), typeof(IMEEvent), typeof(GeometryChangedEvent), typeof(AttachToPanelEvent), typeof(DetachFromPanelEvent)})]
	protected virtual void HandleEventBubbleUp(EventBase evt) { }

	[CalledBy(Type = "UnityEngine.UIElements.BasePopupField`2+PopupTextElement", Member = "DoMeasure", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(MeasureMode), typeof(float), typeof(MeasureMode)}, ReturnType = typeof(Vector2))]
	[CalledBy(Type = typeof(Button), Member = "DoMeasure", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(MeasureMode), typeof(float), typeof(MeasureMode)}, ReturnType = typeof(Vector2))]
	[CalledBy(Type = typeof(TextElement), Member = "ElideText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(float), typeof(TextOverflowPosition)}, ReturnType = typeof(string))]
	[CallerCount(Count = 4)]
	[Calls(Type = "UnityEngine.TextCore.Text.RenderedText", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TextUtilities), Member = "MeasureVisualElementTextSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextElement), typeof(RenderedText&), typeof(float), typeof(MeasureMode), typeof(float), typeof(MeasureMode)}, ReturnType = typeof(Vector2))]
	public Vector2 MeasureTextSize(string textToMeasure, float width, MeasureMode widthMode, float height, MeasureMode heightMode) { }

	[CallerCount(Count = 0)]
	[Calls(Type = "UnityEngine.TextCore.Text.TextHandle", Member = "RemoveTextInfoFromPermanentCache", ReturnType = typeof(void))]
	[Calls(Type = "UnityEngine.TextCore.Text.TextHandle", Member = "RemoveTextInfoFromTemporaryCache", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private void OnDetachFromPanel(DetachFromPanelEvent detachEvent) { }

	[CalledBy(Type = typeof(UITKTextJobSystem), Member = "AddDrawEntries", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshGenerationContext), typeof(object)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TextElement), Member = "get_selectingManipulator", ReturnType = typeof(TextSelectingManipulator))]
	[Calls(Type = typeof(TextSelectingManipulator), Member = "HasFocus", ReturnType = typeof(bool))]
	[Calls(Type = typeof(TextElement), Member = "DrawHighlighting", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshGenerationContext)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TextSelectingManipulator), Member = "RevealCursor", ReturnType = typeof(bool))]
	[Calls(Type = typeof(TextElement), Member = "DrawCaret", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshGenerationContext)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "get_computedStyle", ReturnType = typeof(ComputedStyle&))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_textOverflow", ReturnType = typeof(TextOverflow))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_overflow", ReturnType = typeof(OverflowInternal))]
	[Calls(Type = typeof(UITKTextHandle), Member = "TextLibraryCanElide", ReturnType = typeof(bool))]
	[Calls(Type = typeof(UITKTextHandle), Member = "IsElided", ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElement), Member = "set_tooltip", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	internal void OnGenerateTextOver(MeshGenerationContext mgc) { }

	[CalledBy(Type = typeof(ATGTextJobSystem), Member = "AddDrawEntries", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshGenerationContext), typeof(object)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TextElement), Member = "get_selectingManipulator", ReturnType = typeof(TextSelectingManipulator))]
	[Calls(Type = typeof(TextSelectingManipulator), Member = "HasFocus", ReturnType = typeof(bool))]
	[Calls(Type = typeof(TextElement), Member = "DrawNativeHighlighting", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshGenerationContext)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TextSelectingManipulator), Member = "RevealCursor", ReturnType = typeof(bool))]
	[Calls(Type = typeof(TextElement), Member = "DrawCaret", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshGenerationContext)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "get_computedStyle", ReturnType = typeof(ComputedStyle&))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_textOverflow", ReturnType = typeof(TextOverflow))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_overflow", ReturnType = typeof(OverflowInternal))]
	[Calls(Type = typeof(UITKTextHandle), Member = "TextLibraryCanElide", ReturnType = typeof(bool))]
	[Calls(Type = typeof(UITKTextHandle), Member = "IsElided", ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 4)]
	internal void OnGenerateTextOverNative(MeshGenerationContext mgc) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TextElement), Member = "UpdateVisibleText", ReturnType = typeof(void))]
	[Calls(Type = typeof(TextUtilities), Member = "IsFontAssigned", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(UITKTextHandle), Member = "ReleaseResourcesIfPossible", ReturnType = typeof(void))]
	[Calls(Type = typeof(TextJobSystem), Member = "GenerateText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshGenerationContext), typeof(TextElement)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	internal static void OnGenerateVisualContent(MeshGenerationContext mgc) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TextElement), Member = "UpdateVisibleText", ReturnType = typeof(void))]
	private void OnGeometryChanged(GeometryChangedEvent e) { }

	[CallerCount(Count = 0)]
	[ContainsInvalidInstructions]
	private void Paste(DropdownMenuAction a) { }

	[CallerCount(Count = 0)]
	[Calls(Type = "UnityEngine.TextEditingUtilities", Member = "CanPaste", ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElement), Member = "get_enabledInHierarchy", ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private Status PasteActionStatus(DropdownMenuAction a) { }

	[CalledBy(Type = typeof(TextElement), Member = "Cut", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DropdownMenuAction)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextElement), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DropdownMenuAction)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CommandEventBase`1), Member = "GetPooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = "T")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	private void ProcessMenuCommand(string command) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private void set_autoCorrection(bool value) { }

	[CalledBy(Type = typeof(TextInputBase), Member = "OnInputCustomStyleResolved", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CustomStyleResolvedEvent)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(VisualElement), Member = "MarkDirtyRepaint", ReturnType = typeof(void))]
	internal void set_cursorColor(Color value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private void set_cursorIndex(int value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TextElement), Member = "UpdateVisibleText", ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "MarkDirtyRepaint", ReturnType = typeof(void))]
	[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
	public void set_displayTooltipWhenElided(bool value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	internal void set_doubleClickSelectsWord(bool value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void set_editingManipulator(TextEditingManipulator value) { }

	[CalledBy(Type = typeof(TextInputBaseField`1), Member = "set_emojiFallbackSupport", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(VisualElement), Member = "MarkDirtyRepaint", ReturnType = typeof(void))]
	[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
	public void set_emojiFallbackSupport(bool value) { }

	[CalledBy(Type = typeof(TextInputBase), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(VisualElement), Member = "MarkDirtyRepaint", ReturnType = typeof(void))]
	[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
	public void set_enableRichText(bool value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private void set_hideMobileInput(bool value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private void set_hideSoftKeyboard(bool value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	private void set_isElided(bool value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private void set_isPassword(bool value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private void set_isReadOnly(bool value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	internal void set_isSelectable(bool value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private void set_keyboardType(TouchScreenKeyboardType value) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void set_maskChar(char value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private void set_maxLength(int value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	internal void set_OnPlaceholderChanged(Action value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VisualElement), Member = "MarkDirtyRepaint", ReturnType = typeof(void))]
	[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
	public void set_parseEscapeSequences(bool value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private void set_selectAllOnFocus(bool value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private void set_selectAllOnMouseUp(bool value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private void set_selectIndex(int value) { }

	[CalledBy(Type = typeof(TextInputBase), Member = "OnInputCustomStyleResolved", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CustomStyleResolvedEvent)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(VisualElement), Member = "MarkDirtyRepaint", ReturnType = typeof(void))]
	internal void set_selectionColor(Color value) { }

	[CalledBy(Type = typeof(Button), Member = "set_text", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Button), Member = "UpdateButtonHierarchy", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	public override void set_text(string value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	internal void set_tripleClickSelectsLine(bool value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	internal void set_uitkTextHandle(UITKTextHandle value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private void set_value(string value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	private void SetRenderedText(string value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VisualElement), Member = "get_computedStyle", ReturnType = typeof(ComputedStyle&))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_textOverflow", ReturnType = typeof(TextOverflow))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_overflow", ReturnType = typeof(OverflowInternal))]
	[ContainsUnimplementedInstructions]
	private bool ShouldElide() { }

	[CallerCount(Count = 0)]
	private override string UnityEngine.UIElements.INotifyValueChanged<System.String>.get_value() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElement), Member = "get_panel", ReturnType = typeof(IPanel))]
	[Calls(Type = typeof(UnityEngine.UIElements.ChangeEvent`1<System.Object>), Member = "GetPooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(UnityEngine.UIElements.ChangeEvent`1<System.Object>))]
	[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 7)]
	private override void UnityEngine.UIElements.INotifyValueChanged<System.String>.set_value(string value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElement), Member = "get_computedStyle", ReturnType = typeof(ComputedStyle&))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_height", ReturnType = typeof(Length))]
	[Calls(Type = typeof(Length), Member = "IsAuto", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Length), Member = "IsNone", ReturnType = typeof(bool))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_width", ReturnType = typeof(Length))]
	[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElement), Member = "SaveViewData", ReturnType = typeof(void))]
	[Calls(Type = "UnityEngine.TextEditingUtilities", Member = "set_text", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	[ContainsUnimplementedInstructions]
	private override void UnityEngine.UIElements.INotifyValueChanged<System.String>.SetValueWithoutNotify(string newValue) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 2)]
	private override string UnityEngine.UIElements.ITextEdition.CullString(string s) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private override Func<Char, Boolean> UnityEngine.UIElements.ITextEdition.get_AcceptCharacter() { }

	[CallerCount(Count = 0)]
	private override bool UnityEngine.UIElements.ITextEdition.get_autoCorrection() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private override Func<String> UnityEngine.UIElements.ITextEdition.get_GetDefaultValueType() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TouchScreenKeyboard), Member = "get_inputFieldAppearance", ReturnType = typeof(InputFieldAppearance))]
	private override bool UnityEngine.UIElements.ITextEdition.get_hideMobileInput() { }

	[CallerCount(Count = 0)]
	private override bool UnityEngine.UIElements.ITextEdition.get_hidePlaceholderOnFocus() { }

	[CallerCount(Count = 0)]
	private override bool UnityEngine.UIElements.ITextEdition.get_hideSoftKeyboard() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	private override bool UnityEngine.UIElements.ITextEdition.get_isDelayed() { }

	[CallerCount(Count = 0)]
	private override bool UnityEngine.UIElements.ITextEdition.get_isPassword() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VisualElement), Member = "get_enabledInHierarchy", ReturnType = typeof(bool))]
	private override bool UnityEngine.UIElements.ITextEdition.get_isReadOnly() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	private override TouchScreenKeyboardType UnityEngine.UIElements.ITextEdition.get_keyboardType() { }

	[CallerCount(Count = 0)]
	private override char UnityEngine.UIElements.ITextEdition.get_maskChar() { }

	[CallerCount(Count = 0)]
	private override int UnityEngine.UIElements.ITextEdition.get_maxLength() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private override Action UnityEngine.UIElements.ITextEdition.get_MoveFocusToCompositeRoot() { }

	[CallerCount(Count = 0)]
	private override bool UnityEngine.UIElements.ITextEdition.get_multiline() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	private override string UnityEngine.UIElements.ITextEdition.get_placeholder() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	private override TouchScreenKeyboard UnityEngine.UIElements.ITextEdition.get_touchScreenKeyboard() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private override Action<Boolean> UnityEngine.UIElements.ITextEdition.get_UpdateScrollOffset() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private override Action UnityEngine.UIElements.ITextEdition.get_UpdateTextFromValue() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private override Action UnityEngine.UIElements.ITextEdition.get_UpdateValueFromText() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private override void UnityEngine.UIElements.ITextEdition.RestoreValueAndText() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private override void UnityEngine.UIElements.ITextEdition.SaveValueAndText() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	private override void UnityEngine.UIElements.ITextEdition.set_AcceptCharacter(Func<Char, Boolean> value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
	private override void UnityEngine.UIElements.ITextEdition.set_autoCorrection(bool value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private override void UnityEngine.UIElements.ITextEdition.set_GetDefaultValueType(Func<String> value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TouchScreenKeyboard), Member = "get_inputFieldAppearance", ReturnType = typeof(InputFieldAppearance))]
	[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
	private override void UnityEngine.UIElements.ITextEdition.set_hideMobileInput(bool value) { }

	[CallerCount(Count = 0)]
	private override void UnityEngine.UIElements.ITextEdition.set_hidePlaceholderOnFocus(bool value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
	private override void UnityEngine.UIElements.ITextEdition.set_hideSoftKeyboard(bool value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	private override void UnityEngine.UIElements.ITextEdition.set_isDelayed(bool value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
	private override void UnityEngine.UIElements.ITextEdition.set_isPassword(bool value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TextEditingManipulator), Member = "Reset", ReturnType = typeof(void))]
	[Calls(Type = typeof(TextEditingManipulator), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextElement)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private override void UnityEngine.UIElements.ITextEdition.set_isReadOnly(bool value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
	private override void UnityEngine.UIElements.ITextEdition.set_keyboardType(TouchScreenKeyboardType value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private override void UnityEngine.UIElements.ITextEdition.set_maskChar(char value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	private override void UnityEngine.UIElements.ITextEdition.set_maxLength(int value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private override void UnityEngine.UIElements.ITextEdition.set_MoveFocusToCompositeRoot(Action value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private override void UnityEngine.UIElements.ITextEdition.set_multiline(bool value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElement), Member = "MarkDirtyRepaint", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 3)]
	private override void UnityEngine.UIElements.ITextEdition.set_placeholder(string value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	private override void UnityEngine.UIElements.ITextEdition.set_UpdateScrollOffset(Action<Boolean> value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private override void UnityEngine.UIElements.ITextEdition.set_UpdateTextFromValue(Action value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	private override void UnityEngine.UIElements.ITextEdition.set_UpdateValueFromText(Action value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TouchScreenKeyboard), Member = "get_text", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TouchScreenKeyboard), Member = "set_text", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputEvent), Member = "GetPooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(InputEvent))]
	[Calls(Type = typeof(VisualElement), Member = "get_parent", ReturnType = typeof(VisualElement))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 7)]
	private override void UnityEngine.UIElements.ITextEdition.UpdateText(string value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TextElement), Member = "get_selectingManipulator", ReturnType = typeof(TextSelectingManipulator))]
	[Calls(Type = typeof(TextSelectingManipulator), Member = "get_cursorIndex", ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 2)]
	private override int UnityEngine.UIElements.ITextSelection.get_cursorIndex() { }

	[CallerCount(Count = 0)]
	[Calls(Type = "UnityEngine.TextCore.Text.TextHandle", Member = "GetCursorPositionFromStringIndexUsingLineHeight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool), typeof(bool)}, ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(VisualElement), Member = "get_contentRect", ReturnType = typeof(Rect))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private override Vector2 UnityEngine.UIElements.ITextSelection.get_cursorPosition() { }

	[CallerCount(Count = 0)]
	private override float UnityEngine.UIElements.ITextSelection.get_cursorWidth() { }

	[CallerCount(Count = 0)]
	private override bool UnityEngine.UIElements.ITextSelection.get_doubleClickSelectsWord() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private override bool UnityEngine.UIElements.ITextSelection.get_isSelectable() { }

	[CallerCount(Count = 0)]
	[Calls(Type = "UnityEngine.TextCore.Text.TextHandle", Member = "GetLineHeightFromCharacterIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(float))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private override float UnityEngine.UIElements.ITextSelection.get_lineHeightAtCursorPosition() { }

	[CallerCount(Count = 0)]
	private override bool UnityEngine.UIElements.ITextSelection.get_selectAllOnFocus() { }

	[CallerCount(Count = 0)]
	private override bool UnityEngine.UIElements.ITextSelection.get_selectAllOnMouseUp() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TextElement), Member = "get_selectingManipulator", ReturnType = typeof(TextSelectingManipulator))]
	[Calls(Type = typeof(TextSelectingManipulator), Member = "get_selectIndex", ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 2)]
	private override int UnityEngine.UIElements.ITextSelection.get_selectIndex() { }

	[CallerCount(Count = 0)]
	private override bool UnityEngine.UIElements.ITextSelection.get_tripleClickSelectsLine() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TextElement), Member = "get_selectingManipulator", ReturnType = typeof(TextSelectingManipulator))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private override bool UnityEngine.UIElements.ITextSelection.HasSelection() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TextElement), Member = "get_selectingManipulator", ReturnType = typeof(TextSelectingManipulator))]
	[Calls(Type = "UnityEngine.TextSelectingUtilities", Member = "SelectAll", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	private override void UnityEngine.UIElements.ITextSelection.SelectAll() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TextElement), Member = "get_selectingManipulator", ReturnType = typeof(TextSelectingManipulator))]
	[Calls(Type = "UnityEngine.TextSelectingUtilities", Member = "SelectNone", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	private override void UnityEngine.UIElements.ITextSelection.SelectNone() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TextElement), Member = "get_selectingManipulator", ReturnType = typeof(TextSelectingManipulator))]
	[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	private override void UnityEngine.UIElements.ITextSelection.set_cursorIndex(int value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
	private override void UnityEngine.UIElements.ITextSelection.set_doubleClickSelectsWord(bool value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VisualElement), Member = "EnableInClassList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	private override void UnityEngine.UIElements.ITextSelection.set_isSelectable(bool value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
	private override void UnityEngine.UIElements.ITextSelection.set_selectAllOnFocus(bool value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
	private override void UnityEngine.UIElements.ITextSelection.set_selectAllOnMouseUp(bool value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TextElement), Member = "get_selectingManipulator", ReturnType = typeof(TextSelectingManipulator))]
	[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	private override void UnityEngine.UIElements.ITextSelection.set_selectIndex(int value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
	private override void UnityEngine.UIElements.ITextSelection.set_tripleClickSelectsLine(bool value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VisualElement), Member = "set_tooltip", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	private void UpdateTooltip() { }

	[CalledBy(Type = typeof(UxmlTraits), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextElement), Member = "HandleEventBubbleUp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextElement), Member = "OnGeometryChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GeometryChangedEvent)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextElement), Member = "set_displayTooltipWhenElided", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextElement), Member = "OnGenerateVisualContent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshGenerationContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(ComputedStyle), Member = "get_textOverflow", ReturnType = typeof(TextOverflow))]
	[Calls(Type = typeof(VisualElement), Member = "get_computedStyle", ReturnType = typeof(ComputedStyle&))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_overflow", ReturnType = typeof(OverflowInternal))]
	[Calls(Type = typeof(UITKTextHandle), Member = "TextLibraryCanElide", ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElement), Member = "get_contentRect", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_unityTextOverflowPosition", ReturnType = typeof(TextOverflowPosition))]
	[Calls(Type = typeof(TextElement), Member = "ElideText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(float), typeof(TextOverflowPosition)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(StringComparison)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	private void UpdateVisibleText() { }

}

