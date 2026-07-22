namespace UnityEngine.UIElements;

public abstract class TextInputBaseField : BaseField<TValueType>, IDelayedField
{
	private abstract class TextInputBase : VisualElement
	{
		public static readonly string verticalHorizontalVariantInnerTextElementUssClassName; //Field offset: 0x0
		public static readonly string innerComponentsModifierName; //Field offset: 0x0
		public static readonly string innerTextElementUssClassName; //Field offset: 0x0
		internal static readonly string innerTextElementWithScrollViewUssClassName; //Field offset: 0x0
		public static readonly string horizontalVariantInnerTextElementUssClassName; //Field offset: 0x0
		public static readonly string verticalVariantInnerTextElementUssClassName; //Field offset: 0x0
		public static readonly string innerScrollviewUssClassName; //Field offset: 0x0
		public static readonly string innerViewportUssClassName; //Field offset: 0x0
		public static readonly string innerContentContainerUssClassName; //Field offset: 0x0
		private bool m_ScrollViewWasClamped; //Field offset: 0x0
		internal Vector2 scrollOffset; //Field offset: 0x0
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
		private bool <isDragging>k__BackingField; //Field offset: 0x0
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
		private TextElement <textElement>k__BackingField; //Field offset: 0x0
		internal VisualElement multilineContainer; //Field offset: 0x0
		internal ScrollView scrollView; //Field offset: 0x0
		private Vector2 lastCursorPos; //Field offset: 0x0
		internal ScrollerVisibility verticalScrollerVisibility; //Field offset: 0x0

		internal bool isDragging
		{
			[CallerCount(Count = 0)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			internal set { } //Length: 7
		}

		internal string originalText
		{
			[CalledBy(Type = typeof(DoubleField), Member = "StringToValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(double))]
			[CalledBy(Type = typeof(FloatField), Member = "StringToValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(float))]
			[CalledBy(Type = typeof(IntegerField), Member = "StringToValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
			[CalledBy(Type = typeof(LongField), Member = "StringToValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(long))]
			[CalledBy(Type = typeof(UnsignedIntegerField), Member = "StringToValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(uint))]
			[CalledBy(Type = typeof(UnsignedLongField), Member = "StringToValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(ulong))]
			[CallerCount(Count = 6)]
			[CallsUnknownMethods(Count = 1)]
			[DeduplicatedMethod]
			internal get { } //Length: 33
		}

		public string text
		{
			[CalledBy(Type = "UnityEngine.UIElements.DoubleField+DoubleInput", Member = "ApplyInputDeviceDelta", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(DeltaSpeed), typeof(double)}, ReturnType = typeof(void))]
			[CalledBy(Type = "UnityEngine.UIElements.FloatField+FloatInput", Member = "ApplyInputDeviceDelta", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(DeltaSpeed), typeof(float)}, ReturnType = typeof(void))]
			[CalledBy(Type = "UnityEngine.UIElements.TextField+TextInput", Member = "set_multiline", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
			[CalledBy(Type = typeof(TextInputBaseField`1), Member = "get_text", ReturnType = typeof(string))]
			[CalledBy(Type = typeof(TextInputBaseField`1), Member = "UpdateValueFromText", ReturnType = typeof(void))]
			[CalledBy(Type = "UnityEngine.UIElements.IntegerField+IntegerInput", Member = "ApplyInputDeviceDelta", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(DeltaSpeed), typeof(int)}, ReturnType = typeof(void))]
			[CalledBy(Type = "UnityEngine.UIElements.LongField+LongInput", Member = "ApplyInputDeviceDelta", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(DeltaSpeed), typeof(long)}, ReturnType = typeof(void))]
			[CalledBy(Type = "UnityEngine.UIElements.UnsignedIntegerField+UnsignedIntegerInput", Member = "ApplyInputDeviceDelta", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(DeltaSpeed), typeof(uint)}, ReturnType = typeof(void))]
			[CalledBy(Type = "UnityEngine.UIElements.UnsignedLongField+UnsignedLongInput", Member = "ApplyInputDeviceDelta", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(DeltaSpeed), typeof(ulong)}, ReturnType = typeof(void))]
			[CallerCount(Count = 11)]
			[CallsDeduplicatedMethods(Count = 1)]
			[CallsUnknownMethods(Count = 1)]
			[DeduplicatedMethod]
			 get { } //Length: 42
			[CalledBy(Type = "UnityEngine.UIElements.DoubleField+DoubleInput", Member = "ApplyInputDeviceDelta", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(DeltaSpeed), typeof(double)}, ReturnType = typeof(void))]
			[CalledBy(Type = "UnityEngine.UIElements.FloatField+FloatInput", Member = "ApplyInputDeviceDelta", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(DeltaSpeed), typeof(float)}, ReturnType = typeof(void))]
			[CalledBy(Type = "UnityEngine.UIElements.TextField+TextInput", Member = "set_multiline", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
			[CalledBy(Type = typeof(TextInputBaseField`1), Member = "set_text", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
			[CalledBy(Type = "UnityEngine.UIElements.IntegerField+IntegerInput", Member = "ApplyInputDeviceDelta", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(DeltaSpeed), typeof(int)}, ReturnType = typeof(void))]
			[CalledBy(Type = "UnityEngine.UIElements.LongField+LongInput", Member = "ApplyInputDeviceDelta", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(DeltaSpeed), typeof(long)}, ReturnType = typeof(void))]
			[CalledBy(Type = typeof(TextValueField`1), Member = "HandleEventBubbleUp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase)}, ReturnType = typeof(void))]
			[CalledBy(Type = "UnityEngine.UIElements.UnsignedIntegerField+UnsignedIntegerInput", Member = "ApplyInputDeviceDelta", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(DeltaSpeed), typeof(uint)}, ReturnType = typeof(void))]
			[CalledBy(Type = "UnityEngine.UIElements.UnsignedLongField+UnsignedLongInput", Member = "ApplyInputDeviceDelta", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(DeltaSpeed), typeof(ulong)}, ReturnType = typeof(void))]
			[CallerCount(Count = 10)]
			[CallsDeduplicatedMethods(Count = 3)]
			[CallsUnknownMethods(Count = 1)]
			[DeduplicatedMethod]
			 set { } //Length: 109
		}

		public ITextEdition textEdition
		{
			[CallerCount(Count = 16)]
			[CallsDeduplicatedMethods(Count = 1)]
			[CallsUnknownMethods(Count = 1)]
			[DeduplicatedMethod]
			 get { } //Length: 32
		}

		internal TextElement textElement
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

		public ITextSelection textSelection
		{
			[CallerCount(Count = 16)]
			[CallsDeduplicatedMethods(Count = 1)]
			[CallsUnknownMethods(Count = 1)]
			[DeduplicatedMethod]
			 get { } //Length: 32
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
		[CallsUnknownMethods(Count = 61)]
		[DeduplicatedMethod]
		private static TextInputBase() { }

		[CalledBy(Type = "UnityEngine.UIElements.TextValueField`1+TextValueInput", Member = ".ctor", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(VisualElement), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(Focusable), Member = "set_delegatesFocus", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(TextElement), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(TextElement), Member = "set_enableRichText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Focusable), Member = "set_tabIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(VisualElement), Member = "AddToClassList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(VisualElement), Member = "set_name", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(TextInputBase), Member = "SetSingleLine", ReturnType = typeof(void))]
		[Calls(Type = typeof(CallbackEventHandler), Member = "RegisterCallback", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TEventType"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.EventCallback`1<TEventType>", typeof(TrickleDown)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 18)]
		[CallsUnknownMethods(Count = 27)]
		[DeduplicatedMethod]
		internal TextInputBase() { }

		[CalledBy(Type = "UnityEngine.UIElements.TextValueField`1+TextValueInput", Member = "AcceptCharacter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(VisualElement), Member = "get_enabledInHierarchy", ReturnType = typeof(bool))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		internal override bool AcceptCharacter(char c) { }

		[CalledBy(Type = typeof(DoubleField), Member = "StringToValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(double))]
		[CalledBy(Type = typeof(FloatField), Member = "StringToValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(float))]
		[CalledBy(Type = typeof(IntegerField), Member = "StringToValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
		[CalledBy(Type = typeof(LongField), Member = "StringToValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(long))]
		[CalledBy(Type = typeof(UnsignedIntegerField), Member = "StringToValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(uint))]
		[CalledBy(Type = typeof(UnsignedLongField), Member = "StringToValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(ulong))]
		[CallerCount(Count = 6)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		internal string get_originalText() { }

		[CalledBy(Type = "UnityEngine.UIElements.DoubleField+DoubleInput", Member = "ApplyInputDeviceDelta", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(DeltaSpeed), typeof(double)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UIElements.FloatField+FloatInput", Member = "ApplyInputDeviceDelta", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(DeltaSpeed), typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UIElements.TextField+TextInput", Member = "set_multiline", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TextInputBaseField`1), Member = "get_text", ReturnType = typeof(string))]
		[CalledBy(Type = typeof(TextInputBaseField`1), Member = "UpdateValueFromText", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UIElements.IntegerField+IntegerInput", Member = "ApplyInputDeviceDelta", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(DeltaSpeed), typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UIElements.LongField+LongInput", Member = "ApplyInputDeviceDelta", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(DeltaSpeed), typeof(long)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UIElements.UnsignedIntegerField+UnsignedIntegerInput", Member = "ApplyInputDeviceDelta", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(DeltaSpeed), typeof(uint)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UIElements.UnsignedLongField+UnsignedLongInput", Member = "ApplyInputDeviceDelta", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(DeltaSpeed), typeof(ulong)}, ReturnType = typeof(void))]
		[CallerCount(Count = 11)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		public string get_text() { }

		[CallerCount(Count = 16)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		public ITextEdition get_textEdition() { }

		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		internal TextElement get_textElement() { }

		[CallerCount(Count = 16)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		public ITextSelection get_textSelection() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(double), Member = "ToString", ReturnType = typeof(string))]
		[DeduplicatedMethod]
		private string GetDefaultValueType() { }

		[CalledBy(Type = typeof(TextInputBase), Member = "UpdateScrollOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(TextElement), Member = "get_hasFocus", ReturnType = typeof(bool))]
		[Calls(Type = typeof(VisualElement), Member = "get_contentRect", ReturnType = typeof(Rect))]
		[Calls(Type = typeof(ScrollView), Member = "get_scrollOffset", ReturnType = typeof(Vector2))]
		[CallsDeduplicatedMethods(Count = 5)]
		[CallsUnknownMethods(Count = 7)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		private Vector2 GetScrollOffset(float xOffset, float yOffset, float contentViewportWidth, bool isBackspace, bool widthChanged) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(EventBase), Member = "StopPropagation", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		private void MakeSureScrollViewDoesNotLeakEvents(ChangeEvent<Single> evt) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(VisualElement), Member = "get_parent", ReturnType = typeof(VisualElement))]
		[Calls(Type = typeof(FocusController), Member = "SwitchFocus", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Focusable), typeof(bool), typeof(DispatchMode)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 5)]
		[DeduplicatedMethod]
		internal void MoveFocusToCompositeRoot() { }

		[CalledBy(Type = typeof(TextInputBaseField`1), Member = "OnFieldCustomStyleResolved", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CustomStyleResolvedEvent)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CustomStyleResolvedEvent), Member = "get_customStyle", ReturnType = typeof(ICustomStyle))]
		[Calls(Type = typeof(TextElement), Member = "set_selectionColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(TextElement), Member = "set_cursorColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(TextInputBase), Member = "SetScrollViewMode", ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 8)]
		[DeduplicatedMethod]
		internal void OnInputCustomStyleResolved(CustomStyleResolvedEvent e) { }

		[CalledBy(Type = typeof(TextInputBase), Member = "SetSingleLine", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TextInputBase), Member = "SetMultiline", ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(VisualElement), Member = "RemoveFromHierarchy", ReturnType = typeof(void))]
		[Calls(Type = typeof(INotifyValueChangedExtensions), Member = "UnregisterValueChangedCallback", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.INotifyValueChanged`1<T>", "UnityEngine.UIElements.EventCallback`1<ChangeEvent`1<T>>"}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(VisualElement), Member = "RemoveFromClassList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 9)]
		[CallsUnknownMethods(Count = 13)]
		[DeduplicatedMethod]
		private void RemoveMultilineComponents() { }

		[CalledBy(Type = typeof(TextInputBase), Member = "SetMultiline", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(VisualElement), Member = "RemoveFromClassList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(VisualElement), Member = "RemoveFromHierarchy", ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 5)]
		[DeduplicatedMethod]
		private void RemoveSingleLineComponents() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(TextInputBase), Member = "UpdateScrollOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		private void ScrollViewOnGeometryChangedEvent(GeometryChangedEvent e) { }

		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		internal void set_isDragging(bool value) { }

		[CalledBy(Type = "UnityEngine.UIElements.DoubleField+DoubleInput", Member = "ApplyInputDeviceDelta", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(DeltaSpeed), typeof(double)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UIElements.FloatField+FloatInput", Member = "ApplyInputDeviceDelta", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(DeltaSpeed), typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UIElements.TextField+TextInput", Member = "set_multiline", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TextInputBaseField`1), Member = "set_text", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UIElements.IntegerField+IntegerInput", Member = "ApplyInputDeviceDelta", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(DeltaSpeed), typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UIElements.LongField+LongInput", Member = "ApplyInputDeviceDelta", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(DeltaSpeed), typeof(long)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TextValueField`1), Member = "HandleEventBubbleUp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UIElements.UnsignedIntegerField+UnsignedIntegerInput", Member = "ApplyInputDeviceDelta", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(DeltaSpeed), typeof(uint)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UIElements.UnsignedLongField+UnsignedLongInput", Member = "ApplyInputDeviceDelta", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(DeltaSpeed), typeof(ulong)}, ReturnType = typeof(void))]
		[CallerCount(Count = 10)]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		public void set_text(string value) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private void set_textElement(TextElement value) { }

		[CalledBy(Type = typeof(TextInputBase), Member = "SetVerticalScrollerVisibility", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScrollerVisibility)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(ScrollView), Member = "set_horizontalScrollerVisibility", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScrollerVisibility)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(TextInputBase), Member = "RemoveSingleLineComponents", ReturnType = typeof(void))]
		[Calls(Type = typeof(TextInputBase), Member = "RemoveMultilineComponents", ReturnType = typeof(void))]
		[Calls(Type = typeof(ScrollView), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(VisualElement), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(TextInputBase), Member = "SetScrollViewMode", ReturnType = typeof(void))]
		[Calls(Type = typeof(ScrollView), Member = "set_verticalScrollerVisibility", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScrollerVisibility)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(VisualElement), Member = "AddToClassList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CallbackEventHandler), Member = "RegisterCallback", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TEventType"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.EventCallback`1<TEventType>", typeof(TrickleDown)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(INotifyValueChangedExtensions), Member = "RegisterValueChangedCallback", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.INotifyValueChanged`1<T>", "UnityEngine.UIElements.EventCallback`1<ChangeEvent`1<T>>"}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(VisualElement), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(VisualElement), Member = "get_classList", ReturnType = typeof(System.Collections.Generic.List`1<System.String>))]
		[Calls(Type = typeof(TextElement), Member = "get_hasFocus", ReturnType = typeof(bool))]
		[CallsDeduplicatedMethods(Count = 10)]
		[CallsUnknownMethods(Count = 18)]
		[DeduplicatedMethod]
		internal void SetMultiline() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(VisualElement), Member = "get_computedStyle", ReturnType = typeof(ComputedStyle&))]
		[Calls(Type = typeof(ComputedStyle), Member = "get_whiteSpace", ReturnType = typeof(WhiteSpace))]
		[Calls(Type = typeof(VisualElement), Member = "get_style", ReturnType = typeof(IStyle))]
		[Calls(Type = typeof(StyleEnum`1), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "UnityEngine.UIElements.StyleEnum`1<T>")]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		private void SetMultilineContainerStyle() { }

		[CalledBy(Type = typeof(TextInputBase), Member = "SetMultiline", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TextInputBase), Member = "OnInputCustomStyleResolved", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CustomStyleResolvedEvent)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(VisualElement), Member = "RemoveFromClassList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(VisualElement), Member = "get_computedStyle", ReturnType = typeof(ComputedStyle&))]
		[Calls(Type = typeof(ComputedStyle), Member = "get_whiteSpace", ReturnType = typeof(WhiteSpace))]
		[Calls(Type = typeof(VisualElement), Member = "AddToClassList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ScrollView), Member = "set_mode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScrollViewMode)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 13)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		internal void SetScrollViewMode() { }

		[CalledBy(Type = typeof(TextInputBase), Member = ".ctor", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Hierarchy), Member = "Clear", ReturnType = typeof(void))]
		[Calls(Type = typeof(TextInputBase), Member = "RemoveMultilineComponents", ReturnType = typeof(void))]
		[Calls(Type = typeof(VisualElement), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(VisualElement), Member = "AddToClassList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CallbackEventHandler), Member = "RegisterCallback", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TEventType"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.EventCallback`1<TEventType>", typeof(TrickleDown)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(TextInputBase), Member = "UpdateScrollOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(TextElement), Member = "get_hasFocus", ReturnType = typeof(bool))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 5)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		internal void SetSingleLine() { }

		[CalledBy(Type = typeof(TextInputBaseField`1), Member = "set_verticalScrollerVisibility", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScrollerVisibility)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(ScrollView), Member = "set_verticalScrollerVisibility", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScrollerVisibility)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(TextInputBase), Member = "SetMultiline", ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		internal bool SetVerticalScrollerVisibility(ScrollerVisibility sv) { }

		[CallerCount(Count = 1)]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		protected override TValueType StringToValue(string str) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(TextInputBase), Member = "UpdateScrollOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		private void TextElementOnGeometryChangedEvent(GeometryChangedEvent e) { }

		[CalledBy(Type = typeof(TextInputBaseField`1), Member = "HandleEventBubbleUp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(TextInputBase), Member = "UpdateScrollOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
		[DeduplicatedMethod]
		internal void UpdateScrollOffset(bool isBackspace = false) { }

		[CalledBy(Type = typeof(TextInputBase), Member = "SetSingleLine", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TextInputBase), Member = "ScrollViewOnGeometryChangedEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GeometryChangedEvent)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TextInputBase), Member = "TextElementOnGeometryChangedEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GeometryChangedEvent)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TextInputBase), Member = "UpdateScrollOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 4)]
		[Calls(Type = "UnityEngine.Rendering.MousePositionDebug", Member = "GetMouseClickPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(Vector2))]
		[Calls(Type = typeof(VisualElement), Member = "get_contentRect", ReturnType = typeof(Rect))]
		[Calls(Type = typeof(TextInputBase), Member = "GetScrollOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(float), typeof(bool), typeof(bool)}, ReturnType = typeof(Vector2))]
		[Calls(Type = typeof(ScrollView), Member = "get_scrollOffset", ReturnType = typeof(Vector2))]
		[Calls(Type = typeof(VisualElement), Member = "get_layout", ReturnType = typeof(Rect))]
		[Calls(Type = typeof(ScrollView), Member = "set_scrollOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 4)]
		[CallsUnknownMethods(Count = 7)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		internal void UpdateScrollOffset(bool isBackspace, bool widthChanged) { }

		[CalledBy(Type = typeof(Hash128Field), Member = "HandleEventBubbleUp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TextValueField`1), Member = "HandleEventBubbleUp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(VisualElement), Member = "get_parent", ReturnType = typeof(VisualElement))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 3)]
		[DeduplicatedMethod]
		internal void UpdateTextFromValue() { }

		[CalledBy(Type = typeof(Hash128Field), Member = "HandleEventBubbleUp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UIElements.TextValueField`1+TextValueInput", Member = "StopDragging", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TextValueField`1), Member = "StopDragging", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TextValueField`1), Member = "HandleEventBubbleUp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase)}, ReturnType = typeof(void))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(VisualElement), Member = "get_parent", ReturnType = typeof(VisualElement))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 3)]
		[DeduplicatedMethod]
		internal void UpdateValueFromText() { }

	}

	[Obsolete("UxmlTraits is deprecated and will be removed. Use UxmlElementAttribute instead.", False)]
	internal class UxmlTraits : BaseFieldTraits<String, UxmlStringAttributeDescription>
	{
		private UxmlIntAttributeDescription m_MaxLength; //Field offset: 0x0
		private UxmlBoolAttributeDescription m_Password; //Field offset: 0x0
		private UxmlStringAttributeDescription m_MaskCharacter; //Field offset: 0x0
		private UxmlStringAttributeDescription m_PlaceholderText; //Field offset: 0x0
		private UxmlBoolAttributeDescription m_HidePlaceholderOnFocus; //Field offset: 0x0
		private UxmlBoolAttributeDescription m_IsReadOnly; //Field offset: 0x0
		private UxmlBoolAttributeDescription m_IsDelayed; //Field offset: 0x0
		private UxmlEnumAttributeDescription<ScrollerVisibility> m_VerticalScrollerVisibility; //Field offset: 0x0
		private UxmlBoolAttributeDescription m_SelectAllOnMouseUp; //Field offset: 0x0
		private UxmlBoolAttributeDescription m_SelectAllOnFocus; //Field offset: 0x0
		private UxmlBoolAttributeDescription m_SelectWordByDoubleClick; //Field offset: 0x0
		private UxmlBoolAttributeDescription m_SelectLineByTripleClick; //Field offset: 0x0
		private UxmlBoolAttributeDescription m_EmojiFallbackSupport; //Field offset: 0x0
		private UxmlBoolAttributeDescription m_HideMobileInput; //Field offset: 0x0
		private UxmlEnumAttributeDescription<TouchScreenKeyboardType> m_KeyboardType; //Field offset: 0x0
		private UxmlBoolAttributeDescription m_AutoCorrection; //Field offset: 0x0

		[CalledBy(Type = typeof(UxmlTraits), Member = ".ctor", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(UxmlIntAttributeDescription), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(UxmlAttributeDescription), Member = "set_obsoleteNames", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.String>)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(UxmlBoolAttributeDescription), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(UxmlStringAttributeDescription), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(UxmlEnumAttributeDescription`1), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(UnityEngine.UIElements.BaseFieldTraits`2<System.Object, System.Object>), Member = ".ctor", ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 37)]
		[DeduplicatedMethod]
		public UxmlTraits() { }

		[CalledBy(Type = typeof(UxmlTraits), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(UxmlEnumAttributeDescription`1), Member = "TryGetValueFromBag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IUxmlAttributes), typeof(CreationContext), "T&"}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(UnityEngine.UIElements.TextInputBaseField`1<System.Object>), Member = "set_maskChar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
		[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(UnityEngine.UIElements.TextInputBaseField`1<System.Object>), Member = "set_autoCorrection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(UnityEngine.UIElements.TextInputBaseField`1<System.Object>), Member = "set_keyboardType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TouchScreenKeyboardType)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(UnityEngine.UIElements.TextInputBaseField`1<System.Object>), Member = "set_hideMobileInput", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(UnityEngine.UIElements.TextInputBaseField`1<System.Object>), Member = "set_verticalScrollerVisibility", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScrollerVisibility)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(TextInputBaseField`1), Member = "set_emojiFallbackSupport", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(UnityEngine.UIElements.TextInputBaseField`1<System.Object>), Member = "set_tripleClickSelectsLine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(UnityEngine.UIElements.TextInputBaseField`1<System.Object>), Member = "set_doubleClickSelectsWord", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(UnityEngine.UIElements.TextInputBaseField`1<System.Object>), Member = "set_isDelayed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(UnityEngine.UIElements.TextInputBaseField`1<System.Object>), Member = "set_readOnly", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(UnityEngine.UIElements.TextInputBaseField`1<System.Object>), Member = "set_password", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(UnityEngine.UIElements.TextInputBaseField`1<System.Object>), Member = "set_maxLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(BaseFieldTraits`2), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(UnityEngine.UIElements.TextInputBaseField`1<System.Object>), Member = "set_placeholderText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(UnityEngine.UIElements.TextInputBaseField`1<System.Object>), Member = "set_hidePlaceholderOnFocus", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 17)]
		[CallsUnknownMethods(Count = 5)]
		[DeduplicatedMethod]
		public virtual void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc) { }

	}

	internal static readonly BindingId autoCorrectionProperty; //Field offset: 0x0
	public static readonly string textInputUssName; //Field offset: 0x0
	internal static readonly string multilineInputWithScrollViewUssClassName; //Field offset: 0x0
	public static readonly string placeholderUssClassName; //Field offset: 0x0
	public static readonly string multilineInputUssClassName; //Field offset: 0x0
	public static readonly string singleLineInputUssClassName; //Field offset: 0x0
	internal static readonly string multilineContainerClassName; //Field offset: 0x0
	public static readonly string inputUssClassName; //Field offset: 0x0
	public static readonly string labelUssClassName; //Field offset: 0x0
	public static readonly string ussClassName; //Field offset: 0x0
	private static CustomStyleProperty<Color> s_CursorColorProperty; //Field offset: 0x0
	private static CustomStyleProperty<Color> s_SelectionColorProperty; //Field offset: 0x0
	internal static readonly BindingId verticalScrollerVisibilityProperty; //Field offset: 0x0
	internal static readonly BindingId maskCharProperty; //Field offset: 0x0
	internal static readonly BindingId isDelayedProperty; //Field offset: 0x0
	internal static readonly BindingId emojiFallbackSupportProperty; //Field offset: 0x0
	internal static readonly BindingId tripleClickSelectsLineProperty; //Field offset: 0x0
	internal static readonly BindingId textEditionProperty; //Field offset: 0x0
	internal static readonly BindingId maxLengthProperty; //Field offset: 0x0
	internal static readonly BindingId selectAllOnMouseUpProperty; //Field offset: 0x0
	internal static readonly BindingId selectAllOnFocusProperty; //Field offset: 0x0
	internal static readonly BindingId selectIndexProperty; //Field offset: 0x0
	internal static readonly BindingId cursorPositionProperty; //Field offset: 0x0
	internal static readonly BindingId cursorIndexProperty; //Field offset: 0x0
	internal static readonly BindingId placeholderTextProperty; //Field offset: 0x0
	internal static readonly BindingId doubleClickSelectsWordProperty; //Field offset: 0x0
	internal static readonly BindingId textSelectionProperty; //Field offset: 0x0
	internal static readonly BindingId isPasswordFieldProperty; //Field offset: 0x0
	internal static readonly BindingId isReadOnlyProperty; //Field offset: 0x0
	internal static readonly BindingId keyboardTypeProperty; //Field offset: 0x0
	internal static readonly BindingId hidePlaceholderOnFocusProperty; //Field offset: 0x0
	internal static readonly BindingId hideSoftKeyboardProperty; //Field offset: 0x0
	internal static readonly BindingId hideMobileInputProperty; //Field offset: 0x0
	private TextInputBase<TValueType> m_TextInputBase; //Field offset: 0x0
	internal bool m_UpdateTextFromValue; //Field offset: 0x0

	[CreateProperty]
	public bool autoCorrection
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		 get { } //Length: 103
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 5)]
		[DeduplicatedMethod]
		 set { } //Length: 321
	}

	virtual bool canSwitchToMixedValue
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(TextElement), Member = "get_hasFocus", ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 47
	}

	[CreateProperty]
	public int cursorIndex
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		 get { } //Length: 103
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 5)]
		[DeduplicatedMethod]
		 set { } //Length: 325
	}

	[CreateProperty(ReadOnly = True)]
	public Vector2 cursorPosition
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		 get { } //Length: 103
	}

	[CreateProperty]
	public bool doubleClickSelectsWord
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		 get { } //Length: 103
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 5)]
		[DeduplicatedMethod]
		 set { } //Length: 328
	}

	[CreateProperty]
	public bool emojiFallbackSupport
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 45
		[CalledBy(Type = typeof(UxmlTraits), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(TextElement), Member = "set_emojiFallbackSupport", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		[DeduplicatedMethod]
		 set { } //Length: 263
	}

	[CreateProperty]
	public bool hideMobileInput
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		 get { } //Length: 103
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 5)]
		[DeduplicatedMethod]
		 set { } //Length: 328
	}

	[CreateProperty]
	internal bool hidePlaceholderOnFocus
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		internal get { } //Length: 103
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 5)]
		[DeduplicatedMethod]
		internal set { } //Length: 328
	}

	[CreateProperty]
	public bool hideSoftKeyboard
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		 get { } //Length: 103
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 5)]
		[DeduplicatedMethod]
		 set { } //Length: 328
	}

	[CreateProperty]
	public override bool isDelayed
	{
		[CalledBy(Type = "UnityEngine.UIElements.DoubleField+DoubleInput", Member = "ApplyInputDeviceDelta", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(DeltaSpeed), typeof(double)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UIElements.TextValueField`1+TextValueInput", Member = "StopDragging", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TextValueField`1), Member = "StopDragging", ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		 get { } //Length: 103
		[CalledBy(Type = typeof(TextValueFieldTraits`2), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 5)]
		[DeduplicatedMethod]
		 set { } //Length: 328
	}

	[CreateProperty]
	public bool isPasswordField
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		 get { } //Length: 103
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 5)]
		[DeduplicatedMethod]
		 set { } //Length: 357
	}

	[CreateProperty]
	public bool isReadOnly
	{
		[CalledBy(Type = typeof(TextValueField`1), Member = "AddLabelDragger", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TDraggerType"}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		 get { } //Length: 103
		[CalledBy(Type = typeof(TextValueFieldTraits`2), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 5)]
		[DeduplicatedMethod]
		 set { } //Length: 328
	}

	[CreateProperty]
	public TouchScreenKeyboardType keyboardType
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		 get { } //Length: 103
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 5)]
		[DeduplicatedMethod]
		 set { } //Length: 325
	}

	[CreateProperty]
	public char maskChar
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		 get { } //Length: 103
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 5)]
		[DeduplicatedMethod]
		 set { } //Length: 328
	}

	[CreateProperty]
	public int maxLength
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		 get { } //Length: 103
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 5)]
		[CallsUnknownMethods(Count = 6)]
		[DeduplicatedMethod]
		 set { } //Length: 441
	}

	protected Action<Boolean> onIsReadOnlyChanged
	{
		[CalledBy(Type = typeof(TextValueField`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), "UnityEngine.UIElements.TextValueField`1<TValueType>+TextValueInput<TValueType>"}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 45
		[CalledBy(Type = typeof(TextValueField`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), "UnityEngine.UIElements.TextValueField`1<TValueType>+TextValueInput<TValueType>"}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		 set { } //Length: 56
	}

	internal bool password
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		internal set { } //Length: 119
	}

	[CreateProperty]
	internal string placeholderText
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		internal get { } //Length: 103
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 5)]
		[DeduplicatedMethod]
		[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
		internal set { } //Length: 340
	}

	internal bool readOnly
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 5)]
		[DeduplicatedMethod]
		internal set { } //Length: 340
	}

	[CreateProperty]
	public bool selectAllOnFocus
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		 get { } //Length: 103
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 5)]
		[DeduplicatedMethod]
		 set { } //Length: 328
	}

	[CreateProperty]
	public bool selectAllOnMouseUp
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		 get { } //Length: 103
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 5)]
		[DeduplicatedMethod]
		 set { } //Length: 328
	}

	[CreateProperty]
	public int selectIndex
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		 get { } //Length: 103
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 5)]
		[DeduplicatedMethod]
		 set { } //Length: 325
	}

	public private string text
	{
		[CalledBy(Type = "UnityEngine.UIElements.BaseCompositeField`3+<>c__DisplayClass18_0", Member = "<.ctor>b__1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.ChangeEvent`1<TFieldValue>"}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(FloatField), Member = "UpdateValueFromText", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TextField), Member = "HandleEventBubbleUp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TextValueField`1), Member = "UpdateValueFromText", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TextValueField`1), Member = "HandleEventBubbleUp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase)}, ReturnType = typeof(void))]
		[CallerCount(Count = 6)]
		[Calls(Type = typeof(TextInputBase), Member = "get_text", ReturnType = typeof(string))]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 48
		[CalledBy(Type = typeof(TextField), Member = "OnViewDataReady", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TextValueField`1), Member = "UpdateTextFromValue", ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(TextInputBase), Member = "set_text", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
		private set { } //Length: 48
	}

	[CreateProperty(ReadOnly = True)]
	public ITextEdition textEdition
	{
		[CallerCount(Count = 10)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 44
	}

	protected private TextInputBase<TValueType> textInputBase
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		private get { } //Length: 8
	}

	[CreateProperty(ReadOnly = True)]
	public ITextSelection textSelection
	{
		[CallerCount(Count = 10)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 44
	}

	[CreateProperty]
	public bool tripleClickSelectsLine
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		 get { } //Length: 103
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 5)]
		[DeduplicatedMethod]
		 set { } //Length: 328
	}

	[CreateProperty]
	public ScrollerVisibility verticalScrollerVisibility
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 32
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(TextInputBase), Member = "SetVerticalScrollerVisibility", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScrollerVisibility)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		[DeduplicatedMethod]
		 set { } //Length: 196
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BindingId), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(BindingId))]
	[Calls(Type = typeof(CustomStyleProperty`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 179)]
	[DeduplicatedMethod]
	private static TextInputBaseField`1() { }

	[CalledBy(Type = typeof(TextValueField`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), "UnityEngine.UIElements.TextValueField`1<TValueType>+TextValueInput<TValueType>"}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.UIElements.BaseField`1<System.Double>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(VisualElement)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Focusable), Member = "set_tabIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Focusable), Member = "set_delegatesFocus", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "AddToClassList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseField`1), Member = "get_visualInput", ReturnType = typeof(VisualElement))]
	[Calls(Type = typeof(CallbackEventHandler), Member = "RegisterCallback", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TEventType"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.EventCallback`1<TEventType>", typeof(TrickleDown)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 12)]
	[DeduplicatedMethod]
	protected TextInputBaseField`1(string label, int maxLength, char maskChar, TextInputBase<TValueType> textInputBase) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public bool get_autoCorrection() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TextElement), Member = "get_hasFocus", ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	virtual bool get_canSwitchToMixedValue() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public int get_cursorIndex() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public Vector2 get_cursorPosition() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public bool get_doubleClickSelectsWord() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public bool get_emojiFallbackSupport() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public bool get_hideMobileInput() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	internal bool get_hidePlaceholderOnFocus() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public bool get_hideSoftKeyboard() { }

	[CalledBy(Type = "UnityEngine.UIElements.DoubleField+DoubleInput", Member = "ApplyInputDeviceDelta", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(DeltaSpeed), typeof(double)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.TextValueField`1+TextValueInput", Member = "StopDragging", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextValueField`1), Member = "StopDragging", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public override bool get_isDelayed() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public bool get_isPasswordField() { }

	[CalledBy(Type = typeof(TextValueField`1), Member = "AddLabelDragger", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TDraggerType"}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public bool get_isReadOnly() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public TouchScreenKeyboardType get_keyboardType() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public char get_maskChar() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public int get_maxLength() { }

	[CalledBy(Type = typeof(TextValueField`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), "UnityEngine.UIElements.TextValueField`1<TValueType>+TextValueInput<TValueType>"}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	protected Action<Boolean> get_onIsReadOnlyChanged() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	internal string get_placeholderText() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public bool get_selectAllOnFocus() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public bool get_selectAllOnMouseUp() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public int get_selectIndex() { }

	[CalledBy(Type = "UnityEngine.UIElements.BaseCompositeField`3+<>c__DisplayClass18_0", Member = "<.ctor>b__1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.ChangeEvent`1<TFieldValue>"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FloatField), Member = "UpdateValueFromText", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextField), Member = "HandleEventBubbleUp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextValueField`1), Member = "UpdateValueFromText", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextValueField`1), Member = "HandleEventBubbleUp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(TextInputBase), Member = "get_text", ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public string get_text() { }

	[CallerCount(Count = 10)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public ITextEdition get_textEdition() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	protected private TextInputBase<TValueType> get_textInputBase() { }

	[CallerCount(Count = 10)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public ITextSelection get_textSelection() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public bool get_tripleClickSelectsLine() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public ScrollerVisibility get_verticalScrollerVisibility() { }

	[CalledBy(Type = typeof(TextValueField`1), Member = "HandleEventBubbleUp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.UIElements.BaseField`1<System.Double>), Member = "HandleEventBubbleUp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(EventBase`1), Member = "TypeId", ReturnType = typeof(long))]
	[Calls(Type = typeof(FocusController), Member = "SwitchFocusOnEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Focusable), typeof(EventBase)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TextInputBase), Member = "UpdateScrollOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 11)]
	[CallsUnknownMethods(Count = 5)]
	[DeduplicatedMethod]
	[EventInterest(new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(NavigationSubmitEvent), typeof(FocusInEvent), typeof(FocusEvent), typeof(FocusOutEvent), typeof(BlurEvent)})]
	protected virtual void HandleEventBubbleUp(EventBase evt) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TextInputBase), Member = "OnInputCustomStyleResolved", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CustomStyleResolvedEvent)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	private void OnFieldCustomStyleResolved(CustomStyleResolvedEvent e) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CallbackEventHandler), Member = "RegisterCallback", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TEventType"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.EventCallback`1<TEventType>", typeof(TrickleDown)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 5)]
	[DeduplicatedMethod]
	internal void OnPlaceholderChanged() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	[DeduplicatedMethod]
	public void set_autoCorrection(bool value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	[DeduplicatedMethod]
	public void set_cursorIndex(int value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	[DeduplicatedMethod]
	public void set_doubleClickSelectsWord(bool value) { }

	[CalledBy(Type = typeof(UxmlTraits), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TextElement), Member = "set_emojiFallbackSupport", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	public void set_emojiFallbackSupport(bool value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	[DeduplicatedMethod]
	public void set_hideMobileInput(bool value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	[DeduplicatedMethod]
	internal void set_hidePlaceholderOnFocus(bool value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	[DeduplicatedMethod]
	public void set_hideSoftKeyboard(bool value) { }

	[CalledBy(Type = typeof(TextValueFieldTraits`2), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	[DeduplicatedMethod]
	public void set_isDelayed(bool value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	[DeduplicatedMethod]
	public void set_isPasswordField(bool value) { }

	[CalledBy(Type = typeof(TextValueFieldTraits`2), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	[DeduplicatedMethod]
	public void set_isReadOnly(bool value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	[DeduplicatedMethod]
	public void set_keyboardType(TouchScreenKeyboardType value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	[DeduplicatedMethod]
	public void set_maskChar(char value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 6)]
	[DeduplicatedMethod]
	public void set_maxLength(int value) { }

	[CalledBy(Type = typeof(TextValueField`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), "UnityEngine.UIElements.TextValueField`1<TValueType>+TextValueInput<TValueType>"}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	protected void set_onIsReadOnlyChanged(Action<Boolean> value) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	internal void set_password(bool value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 5)]
	[DeduplicatedMethod]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal void set_placeholderText(string value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	[DeduplicatedMethod]
	internal void set_readOnly(bool value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	[DeduplicatedMethod]
	public void set_selectAllOnFocus(bool value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	[DeduplicatedMethod]
	public void set_selectAllOnMouseUp(bool value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	[DeduplicatedMethod]
	public void set_selectIndex(int value) { }

	[CalledBy(Type = typeof(TextField), Member = "OnViewDataReady", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextValueField`1), Member = "UpdateTextFromValue", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(TextInputBase), Member = "set_text", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	protected private void set_text(string value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	[DeduplicatedMethod]
	public void set_tripleClickSelectsLine(bool value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TextInputBase), Member = "SetVerticalScrollerVisibility", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScrollerVisibility)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	public void set_verticalScrollerVisibility(ScrollerVisibility value) { }

	[CalledBy(Type = typeof(TextValueField`1), Member = "SetValueWithoutNotify", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TValueType"}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.UIElements.BaseField`1<System.Double>), Member = "SetValueWithoutNotify", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TextElement), Member = "get_needsPlaceholderIfTextIsEmpty", ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BaseField`1), Member = "get_visualInput", ReturnType = typeof(VisualElement))]
	[Calls(Type = typeof(VisualElement), Member = "AddToClassList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	public virtual void SetValueWithoutNotify(TValueType newValue) { }

	protected abstract TValueType StringToValue(string str) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseField`1), Member = "get_visualInput", ReturnType = typeof(VisualElement))]
	[Calls(Type = typeof(VisualElement), Member = "RemoveFromClassList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "AddToClassList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 12)]
	[DeduplicatedMethod]
	protected virtual void UpdateMixedValueContent() { }

	[CalledBy(Type = typeof(TextValueField`1), Member = "UpdateValueFromText", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TextElement), Member = "get_showPlaceholderText", ReturnType = typeof(bool))]
	[Calls(Type = typeof(BaseField`1), Member = "get_visualInput", ReturnType = typeof(VisualElement))]
	[Calls(Type = typeof(VisualElement), Member = "RemoveFromClassList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "AddToClassList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	[DeduplicatedMethod]
	internal void UpdatePlaceholderClassList(ChangeEvent<TValueType> evt = null) { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	internal override void UpdateTextFromValue() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TextInputBase), Member = "get_text", ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	internal override void UpdateValueFromText() { }

	protected abstract string ValueToString(TValueType value) { }

}

