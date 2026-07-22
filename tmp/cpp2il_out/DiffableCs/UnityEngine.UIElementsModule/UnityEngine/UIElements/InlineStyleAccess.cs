namespace UnityEngine.UIElements;

internal class InlineStyleAccess : StyleValueCollection, IStyle
{
	public struct InlineRule
	{
		public StyleSheet sheet; //Field offset: 0x0
		public StyleRule rule; //Field offset: 0x8
		public StylePropertyId[] propertyIds; //Field offset: 0x10

	}

	private static StylePropertyReader s_StylePropertyReader; //Field offset: 0x0
	private List<StyleValueManaged> m_ValuesManaged; //Field offset: 0x18
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private VisualElement <ve>k__BackingField; //Field offset: 0x20
	private bool m_HasInlineCursor; //Field offset: 0x28
	private StyleCursor m_InlineCursor; //Field offset: 0x30
	private bool m_HasInlineTextShadow; //Field offset: 0x50
	private StyleTextShadow m_InlineTextShadow; //Field offset: 0x54
	private bool m_HasInlineTransformOrigin; //Field offset: 0x74
	private StyleTransformOrigin m_InlineTransformOrigin; //Field offset: 0x78
	private bool m_HasInlineTranslate; //Field offset: 0x90
	private StyleTranslate m_InlineTranslateOperation; //Field offset: 0x94
	private bool m_HasInlineRotate; //Field offset: 0xB0
	private StyleRotate m_InlineRotateOperation; //Field offset: 0xB4
	private bool m_HasInlineScale; //Field offset: 0xD0
	private StyleScale m_InlineScale; //Field offset: 0xD4
	private bool m_HasInlineBackgroundSize; //Field offset: 0xE8
	public StyleBackgroundSize m_InlineBackgroundSize; //Field offset: 0xEC
	private InlineRule m_InlineRule; //Field offset: 0x108

	private override StyleEnum<Align> UnityEngine.UIElements.IStyle.alignContent
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(StyleValueCollection), Member = "GetStyleInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(StyleInt))]
		[CallsDeduplicatedMethods(Count = 3)]
		private get { } //Length: 135
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), "UnityEngine.UIElements.StyleEnum`1<T>"}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(VisualElement), Member = "get_layoutNode", ReturnType = typeof(LayoutNode&))]
		[Calls(Type = typeof(VisualElement), Member = "get_computedStyle", ReturnType = typeof(ComputedStyle&))]
		[Calls(Type = typeof(ComputedStyle), Member = "get_alignContent", ReturnType = typeof(Align))]
		[Calls(Type = typeof(LayoutNode), Member = "set_AlignContent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutAlign)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		private set { } //Length: 167
	}

	private override StyleEnum<Align> UnityEngine.UIElements.IStyle.alignItems
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(StyleValueCollection), Member = "GetStyleInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(StyleInt))]
		[CallsDeduplicatedMethods(Count = 3)]
		private get { } //Length: 135
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), "UnityEngine.UIElements.StyleEnum`1<T>"}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(VisualElement), Member = "get_layoutNode", ReturnType = typeof(LayoutNode&))]
		[Calls(Type = typeof(VisualElement), Member = "get_computedStyle", ReturnType = typeof(ComputedStyle&))]
		[Calls(Type = typeof(ComputedStyle), Member = "get_alignItems", ReturnType = typeof(Align))]
		[Calls(Type = typeof(LayoutNode), Member = "set_AlignItems", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutAlign)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		private set { } //Length: 167
	}

	private override StyleEnum<Align> UnityEngine.UIElements.IStyle.alignSelf
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(StyleValueCollection), Member = "GetStyleInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(StyleInt))]
		[CallsDeduplicatedMethods(Count = 3)]
		private get { } //Length: 135
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), "UnityEngine.UIElements.StyleEnum`1<T>"}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(VisualElement), Member = "get_layoutNode", ReturnType = typeof(LayoutNode&))]
		[Calls(Type = typeof(VisualElement), Member = "get_computedStyle", ReturnType = typeof(ComputedStyle&))]
		[Calls(Type = typeof(ComputedStyle), Member = "get_alignSelf", ReturnType = typeof(Align))]
		[Calls(Type = typeof(LayoutNode), Member = "set_AlignSelf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutAlign)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		private set { } //Length: 167
	}

	private override StyleColor UnityEngine.UIElements.IStyle.backgroundColor
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(StyleValueCollection), Member = "GetStyleColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(StyleColor))]
		private get { } //Length: 60
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(StyleColor)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		private set { } //Length: 84
	}

	private override StyleBackground UnityEngine.UIElements.IStyle.backgroundImage
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(StyleValueCollection), Member = "GetStyleBackground", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(StyleBackground))]
		private get { } //Length: 77
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(StyleBackground)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		private set { } //Length: 97
	}

	private override StyleBackgroundPosition UnityEngine.UIElements.IStyle.backgroundPositionX
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(StyleValueCollection), Member = "GetStyleBackgroundPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(StyleBackgroundPosition))]
		private get { } //Length: 49
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(StyleBackgroundPosition)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		private set { } //Length: 77
	}

	private override StyleBackgroundPosition UnityEngine.UIElements.IStyle.backgroundPositionY
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(StyleValueCollection), Member = "GetStyleBackgroundPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(StyleBackgroundPosition))]
		private get { } //Length: 49
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(StyleBackgroundPosition)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		private set { } //Length: 77
	}

	private override StyleBackgroundRepeat UnityEngine.UIElements.IStyle.backgroundRepeat
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(StyleValueCollection), Member = "GetStyleBackgroundRepeat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(StyleBackgroundRepeat))]
		private get { } //Length: 59
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(StyleValueCollection), Member = "TryGetStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(StyleValue&)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(BackgroundRepeat), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BackgroundRepeat), typeof(BackgroundRepeat)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(StyleValueCollection), Member = "SetStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleValue)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(InlineStyleAccess), Member = "ApplyStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleValue)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(InlineStyleAccess), Member = "RemoveInlineStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 6)]
		[CallsUnknownMethods(Count = 1)]
		private set { } //Length: 331
	}

	private override StyleBackgroundSize UnityEngine.UIElements.IStyle.backgroundSize
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		private get { } //Length: 104
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(StyleBackgroundSize), Member = "get_value", ReturnType = typeof(BackgroundSize))]
		[Calls(Type = typeof(BackgroundSize), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BackgroundSize), typeof(BackgroundSize)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(InlineStyleAccess), Member = "ApplyStyleBackgroundSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleBackgroundSize)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(InlineStyleAccess), Member = "RemoveInlineStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 4)]
		[CallsUnknownMethods(Count = 1)]
		private set { } //Length: 372
	}

	private override StyleColor UnityEngine.UIElements.IStyle.borderBottomColor
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(StyleValueCollection), Member = "GetStyleColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(StyleColor))]
		private get { } //Length: 60
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(StyleColor)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		private set { } //Length: 84
	}

	private override StyleLength UnityEngine.UIElements.IStyle.borderBottomLeftRadius
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(StyleValueCollection), Member = "GetStyleLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(StyleLength))]
		private get { } //Length: 59
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(StyleLength)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		private set { } //Length: 86
	}

	private override StyleLength UnityEngine.UIElements.IStyle.borderBottomRightRadius
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(StyleValueCollection), Member = "GetStyleLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(StyleLength))]
		private get { } //Length: 59
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(StyleLength)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		private set { } //Length: 86
	}

	private override StyleFloat UnityEngine.UIElements.IStyle.borderBottomWidth
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(StyleValueCollection), Member = "GetStyleFloat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(StyleFloat))]
		private get { } //Length: 15
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(StyleFloat)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(VisualElement), Member = "get_layoutNode", ReturnType = typeof(LayoutNode&))]
		[Calls(Type = typeof(VisualElement), Member = "get_computedStyle", ReturnType = typeof(ComputedStyle&))]
		[Calls(Type = typeof(ComputedStyle), Member = "get_borderBottomWidth", ReturnType = typeof(float))]
		[Calls(Type = typeof(LayoutNode), Member = "set_BorderBottomWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		private set { } //Length: 131
	}

	private override StyleColor UnityEngine.UIElements.IStyle.borderLeftColor
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(StyleValueCollection), Member = "GetStyleColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(StyleColor))]
		private get { } //Length: 60
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(StyleColor)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		private set { } //Length: 84
	}

	private override StyleFloat UnityEngine.UIElements.IStyle.borderLeftWidth
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(StyleValueCollection), Member = "GetStyleFloat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(StyleFloat))]
		private get { } //Length: 15
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(StyleFloat)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(VisualElement), Member = "get_layoutNode", ReturnType = typeof(LayoutNode&))]
		[Calls(Type = typeof(VisualElement), Member = "get_computedStyle", ReturnType = typeof(ComputedStyle&))]
		[Calls(Type = typeof(ComputedStyle), Member = "get_borderLeftWidth", ReturnType = typeof(float))]
		[Calls(Type = typeof(LayoutNode), Member = "set_BorderLeftWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		private set { } //Length: 131
	}

	private override StyleColor UnityEngine.UIElements.IStyle.borderRightColor
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(StyleValueCollection), Member = "GetStyleColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(StyleColor))]
		private get { } //Length: 60
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(StyleColor)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		private set { } //Length: 84
	}

	private override StyleFloat UnityEngine.UIElements.IStyle.borderRightWidth
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(StyleValueCollection), Member = "GetStyleFloat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(StyleFloat))]
		private get { } //Length: 15
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(StyleFloat)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(VisualElement), Member = "get_layoutNode", ReturnType = typeof(LayoutNode&))]
		[Calls(Type = typeof(VisualElement), Member = "get_computedStyle", ReturnType = typeof(ComputedStyle&))]
		[Calls(Type = typeof(ComputedStyle), Member = "get_borderRightWidth", ReturnType = typeof(float))]
		[Calls(Type = typeof(LayoutNode), Member = "set_BorderRightWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		private set { } //Length: 131
	}

	private override StyleColor UnityEngine.UIElements.IStyle.borderTopColor
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(StyleValueCollection), Member = "GetStyleColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(StyleColor))]
		private get { } //Length: 60
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(StyleColor)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		private set { } //Length: 84
	}

	private override StyleLength UnityEngine.UIElements.IStyle.borderTopLeftRadius
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(StyleValueCollection), Member = "GetStyleLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(StyleLength))]
		private get { } //Length: 59
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(StyleLength)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		private set { } //Length: 86
	}

	private override StyleLength UnityEngine.UIElements.IStyle.borderTopRightRadius
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(StyleValueCollection), Member = "GetStyleLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(StyleLength))]
		private get { } //Length: 59
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(StyleLength)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		private set { } //Length: 86
	}

	private override StyleFloat UnityEngine.UIElements.IStyle.borderTopWidth
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(StyleValueCollection), Member = "GetStyleFloat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(StyleFloat))]
		private get { } //Length: 15
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(StyleFloat)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(VisualElement), Member = "get_layoutNode", ReturnType = typeof(LayoutNode&))]
		[Calls(Type = typeof(VisualElement), Member = "get_computedStyle", ReturnType = typeof(ComputedStyle&))]
		[Calls(Type = typeof(ComputedStyle), Member = "get_borderTopWidth", ReturnType = typeof(float))]
		[Calls(Type = typeof(LayoutNode), Member = "set_BorderTopWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		private set { } //Length: 131
	}

	private override StyleLength UnityEngine.UIElements.IStyle.bottom
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(StyleValueCollection), Member = "GetStyleLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(StyleLength))]
		private get { } //Length: 59
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(StyleLength)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(VisualElement), Member = "get_layoutNode", ReturnType = typeof(LayoutNode&))]
		[Calls(Type = typeof(VisualElement), Member = "get_computedStyle", ReturnType = typeof(ComputedStyle&))]
		[Calls(Type = typeof(ComputedStyle), Member = "get_bottom", ReturnType = typeof(Length))]
		[Calls(Type = typeof(StyleValueExtensions), Member = "ToLayoutValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Length)}, ReturnType = typeof(LayoutValue))]
		[Calls(Type = typeof(LayoutNode), Member = "set_Bottom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutValue)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		private set { } //Length: 160
	}

	private override StyleColor UnityEngine.UIElements.IStyle.color
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(StyleValueCollection), Member = "GetStyleColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(StyleColor))]
		private get { } //Length: 60
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(StyleColor)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		private set { } //Length: 84
	}

	private override StyleCursor UnityEngine.UIElements.IStyle.cursor
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(StyleCursor), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleKeyword)}, ReturnType = typeof(StyleCursor))]
		[CallsUnknownMethods(Count = 1)]
		private get { } //Length: 132
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(StyleCursor), Member = "get_value", ReturnType = typeof(Cursor))]
		[Calls(Type = typeof(Cursor), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Cursor), typeof(Cursor)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(StyleCursor), Member = "set_value", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Cursor)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(InlineStyleAccess), Member = "ApplyStyleCursor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleCursor)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(InlineStyleAccess), Member = "RemoveInlineStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 6)]
		[CallsUnknownMethods(Count = 3)]
		private set { } //Length: 478
	}

	private override StyleEnum<DisplayStyle> UnityEngine.UIElements.IStyle.display
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(StyleValueCollection), Member = "GetStyleInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(StyleInt))]
		[CallsDeduplicatedMethods(Count = 3)]
		private get { } //Length: 135
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), "UnityEngine.UIElements.StyleEnum`1<T>"}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(VisualElement), Member = "get_layoutNode", ReturnType = typeof(LayoutNode&))]
		[Calls(Type = typeof(VisualElement), Member = "get_computedStyle", ReturnType = typeof(ComputedStyle&))]
		[Calls(Type = typeof(ComputedStyle), Member = "get_display", ReturnType = typeof(DisplayStyle))]
		[Calls(Type = typeof(LayoutNode), Member = "set_Display", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutDisplay)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		private set { } //Length: 167
	}

	private override StyleLength UnityEngine.UIElements.IStyle.flexBasis
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(StyleValueCollection), Member = "GetStyleLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(StyleLength))]
		private get { } //Length: 59
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(StyleLength)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(VisualElement), Member = "get_layoutNode", ReturnType = typeof(LayoutNode&))]
		[Calls(Type = typeof(VisualElement), Member = "get_computedStyle", ReturnType = typeof(ComputedStyle&))]
		[Calls(Type = typeof(ComputedStyle), Member = "get_flexBasis", ReturnType = typeof(Length))]
		[Calls(Type = typeof(StyleValueExtensions), Member = "ToLayoutValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Length)}, ReturnType = typeof(LayoutValue))]
		[Calls(Type = typeof(LayoutNode), Member = "set_FlexBasis", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutValue)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		private set { } //Length: 160
	}

	private override StyleEnum<FlexDirection> UnityEngine.UIElements.IStyle.flexDirection
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(StyleValueCollection), Member = "GetStyleInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(StyleInt))]
		[CallsDeduplicatedMethods(Count = 3)]
		private get { } //Length: 135
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), "UnityEngine.UIElements.StyleEnum`1<T>"}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(VisualElement), Member = "get_layoutNode", ReturnType = typeof(LayoutNode&))]
		[Calls(Type = typeof(VisualElement), Member = "get_computedStyle", ReturnType = typeof(ComputedStyle&))]
		[Calls(Type = typeof(ComputedStyle), Member = "get_flexDirection", ReturnType = typeof(FlexDirection))]
		[Calls(Type = typeof(LayoutNode), Member = "set_FlexDirection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutFlexDirection)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		private set { } //Length: 167
	}

	private override StyleFloat UnityEngine.UIElements.IStyle.flexGrow
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(StyleValueCollection), Member = "GetStyleFloat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(StyleFloat))]
		private get { } //Length: 15
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(StyleFloat)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(VisualElement), Member = "get_layoutNode", ReturnType = typeof(LayoutNode&))]
		[Calls(Type = typeof(VisualElement), Member = "get_computedStyle", ReturnType = typeof(ComputedStyle&))]
		[Calls(Type = typeof(ComputedStyle), Member = "get_flexGrow", ReturnType = typeof(float))]
		[Calls(Type = typeof(LayoutNode), Member = "set_FlexGrow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		private set { } //Length: 131
	}

	private override StyleFloat UnityEngine.UIElements.IStyle.flexShrink
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(StyleValueCollection), Member = "GetStyleFloat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(StyleFloat))]
		private get { } //Length: 15
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(StyleFloat)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(VisualElement), Member = "get_layoutNode", ReturnType = typeof(LayoutNode&))]
		[Calls(Type = typeof(VisualElement), Member = "get_computedStyle", ReturnType = typeof(ComputedStyle&))]
		[Calls(Type = typeof(ComputedStyle), Member = "get_flexShrink", ReturnType = typeof(float))]
		[Calls(Type = typeof(LayoutNode), Member = "set_FlexShrink", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		private set { } //Length: 131
	}

	private override StyleEnum<Wrap> UnityEngine.UIElements.IStyle.flexWrap
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(StyleValueCollection), Member = "GetStyleInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(StyleInt))]
		[CallsDeduplicatedMethods(Count = 3)]
		private get { } //Length: 135
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), "UnityEngine.UIElements.StyleEnum`1<T>"}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(VisualElement), Member = "get_layoutNode", ReturnType = typeof(LayoutNode&))]
		[Calls(Type = typeof(VisualElement), Member = "get_computedStyle", ReturnType = typeof(ComputedStyle&))]
		[Calls(Type = typeof(ComputedStyle), Member = "get_flexWrap", ReturnType = typeof(Wrap))]
		[Calls(Type = typeof(LayoutNode), Member = "set_Wrap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutWrap)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		private set { } //Length: 167
	}

	private override StyleLength UnityEngine.UIElements.IStyle.fontSize
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(StyleValueCollection), Member = "GetStyleLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(StyleLength))]
		private get { } //Length: 59
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(StyleLength)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		private set { } //Length: 86
	}

	private override StyleLength UnityEngine.UIElements.IStyle.height
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(StyleValueCollection), Member = "GetStyleLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(StyleLength))]
		private get { } //Length: 59
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(StyleLength)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(VisualElement), Member = "get_layoutNode", ReturnType = typeof(LayoutNode&))]
		[Calls(Type = typeof(VisualElement), Member = "get_computedStyle", ReturnType = typeof(ComputedStyle&))]
		[Calls(Type = typeof(ComputedStyle), Member = "get_height", ReturnType = typeof(Length))]
		[Calls(Type = typeof(StyleValueExtensions), Member = "ToLayoutValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Length)}, ReturnType = typeof(LayoutValue))]
		[Calls(Type = typeof(LayoutNode), Member = "set_Height", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutValue)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		private set { } //Length: 160
	}

	private override StyleEnum<Justify> UnityEngine.UIElements.IStyle.justifyContent
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(StyleValueCollection), Member = "GetStyleInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(StyleInt))]
		[CallsDeduplicatedMethods(Count = 3)]
		private get { } //Length: 135
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), "UnityEngine.UIElements.StyleEnum`1<T>"}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(VisualElement), Member = "get_layoutNode", ReturnType = typeof(LayoutNode&))]
		[Calls(Type = typeof(VisualElement), Member = "get_computedStyle", ReturnType = typeof(ComputedStyle&))]
		[Calls(Type = typeof(ComputedStyle), Member = "get_justifyContent", ReturnType = typeof(Justify))]
		[Calls(Type = typeof(LayoutNode), Member = "set_JustifyContent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutJustify)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		private set { } //Length: 167
	}

	private override StyleLength UnityEngine.UIElements.IStyle.left
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(StyleValueCollection), Member = "GetStyleLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(StyleLength))]
		private get { } //Length: 59
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(StyleLength)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(VisualElement), Member = "get_layoutNode", ReturnType = typeof(LayoutNode&))]
		[Calls(Type = typeof(VisualElement), Member = "get_computedStyle", ReturnType = typeof(ComputedStyle&))]
		[Calls(Type = typeof(ComputedStyle), Member = "get_left", ReturnType = typeof(Length))]
		[Calls(Type = typeof(StyleValueExtensions), Member = "ToLayoutValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Length)}, ReturnType = typeof(LayoutValue))]
		[Calls(Type = typeof(LayoutNode), Member = "set_Left", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutValue)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		private set { } //Length: 160
	}

	private override StyleLength UnityEngine.UIElements.IStyle.letterSpacing
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(StyleValueCollection), Member = "GetStyleLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(StyleLength))]
		private get { } //Length: 59
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(StyleLength)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		private set { } //Length: 86
	}

	private override StyleLength UnityEngine.UIElements.IStyle.marginBottom
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(StyleValueCollection), Member = "GetStyleLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(StyleLength))]
		private get { } //Length: 59
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(StyleLength)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(VisualElement), Member = "get_layoutNode", ReturnType = typeof(LayoutNode&))]
		[Calls(Type = typeof(VisualElement), Member = "get_computedStyle", ReturnType = typeof(ComputedStyle&))]
		[Calls(Type = typeof(ComputedStyle), Member = "get_marginBottom", ReturnType = typeof(Length))]
		[Calls(Type = typeof(StyleValueExtensions), Member = "ToLayoutValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Length)}, ReturnType = typeof(LayoutValue))]
		[Calls(Type = typeof(LayoutNode), Member = "set_MarginBottom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutValue)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		private set { } //Length: 160
	}

	private override StyleLength UnityEngine.UIElements.IStyle.marginLeft
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(StyleValueCollection), Member = "GetStyleLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(StyleLength))]
		private get { } //Length: 59
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(StyleLength)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(VisualElement), Member = "get_layoutNode", ReturnType = typeof(LayoutNode&))]
		[Calls(Type = typeof(VisualElement), Member = "get_computedStyle", ReturnType = typeof(ComputedStyle&))]
		[Calls(Type = typeof(ComputedStyle), Member = "get_marginLeft", ReturnType = typeof(Length))]
		[Calls(Type = typeof(StyleValueExtensions), Member = "ToLayoutValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Length)}, ReturnType = typeof(LayoutValue))]
		[Calls(Type = typeof(LayoutNode), Member = "set_MarginLeft", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutValue)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		private set { } //Length: 160
	}

	private override StyleLength UnityEngine.UIElements.IStyle.marginRight
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(StyleValueCollection), Member = "GetStyleLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(StyleLength))]
		private get { } //Length: 59
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(StyleLength)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(VisualElement), Member = "get_layoutNode", ReturnType = typeof(LayoutNode&))]
		[Calls(Type = typeof(VisualElement), Member = "get_computedStyle", ReturnType = typeof(ComputedStyle&))]
		[Calls(Type = typeof(ComputedStyle), Member = "get_marginRight", ReturnType = typeof(Length))]
		[Calls(Type = typeof(StyleValueExtensions), Member = "ToLayoutValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Length)}, ReturnType = typeof(LayoutValue))]
		[Calls(Type = typeof(LayoutNode), Member = "set_MarginRight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutValue)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		private set { } //Length: 160
	}

	private override StyleLength UnityEngine.UIElements.IStyle.marginTop
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(StyleValueCollection), Member = "GetStyleLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(StyleLength))]
		private get { } //Length: 59
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(StyleLength)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(VisualElement), Member = "get_layoutNode", ReturnType = typeof(LayoutNode&))]
		[Calls(Type = typeof(VisualElement), Member = "get_computedStyle", ReturnType = typeof(ComputedStyle&))]
		[Calls(Type = typeof(ComputedStyle), Member = "get_marginTop", ReturnType = typeof(Length))]
		[Calls(Type = typeof(StyleValueExtensions), Member = "ToLayoutValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Length)}, ReturnType = typeof(LayoutValue))]
		[Calls(Type = typeof(LayoutNode), Member = "set_MarginTop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutValue)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		private set { } //Length: 160
	}

	private override StyleLength UnityEngine.UIElements.IStyle.maxHeight
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(StyleValueCollection), Member = "GetStyleLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(StyleLength))]
		private get { } //Length: 59
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(StyleLength)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(VisualElement), Member = "get_layoutNode", ReturnType = typeof(LayoutNode&))]
		[Calls(Type = typeof(VisualElement), Member = "get_computedStyle", ReturnType = typeof(ComputedStyle&))]
		[Calls(Type = typeof(ComputedStyle), Member = "get_maxHeight", ReturnType = typeof(Length))]
		[Calls(Type = typeof(StyleValueExtensions), Member = "ToLayoutValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Length)}, ReturnType = typeof(LayoutValue))]
		[Calls(Type = typeof(LayoutNode), Member = "set_MaxHeight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutValue)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		private set { } //Length: 160
	}

	private override StyleLength UnityEngine.UIElements.IStyle.maxWidth
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(StyleValueCollection), Member = "GetStyleLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(StyleLength))]
		private get { } //Length: 59
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(StyleLength)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(VisualElement), Member = "get_layoutNode", ReturnType = typeof(LayoutNode&))]
		[Calls(Type = typeof(VisualElement), Member = "get_computedStyle", ReturnType = typeof(ComputedStyle&))]
		[Calls(Type = typeof(ComputedStyle), Member = "get_maxWidth", ReturnType = typeof(Length))]
		[Calls(Type = typeof(StyleValueExtensions), Member = "ToLayoutValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Length)}, ReturnType = typeof(LayoutValue))]
		[Calls(Type = typeof(LayoutNode), Member = "set_MaxWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutValue)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		private set { } //Length: 160
	}

	private override StyleLength UnityEngine.UIElements.IStyle.minHeight
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(StyleValueCollection), Member = "GetStyleLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(StyleLength))]
		private get { } //Length: 59
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(StyleLength)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(VisualElement), Member = "get_layoutNode", ReturnType = typeof(LayoutNode&))]
		[Calls(Type = typeof(VisualElement), Member = "get_computedStyle", ReturnType = typeof(ComputedStyle&))]
		[Calls(Type = typeof(ComputedStyle), Member = "get_minHeight", ReturnType = typeof(Length))]
		[Calls(Type = typeof(StyleValueExtensions), Member = "ToLayoutValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Length)}, ReturnType = typeof(LayoutValue))]
		[Calls(Type = typeof(LayoutNode), Member = "set_MinHeight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutValue)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		private set { } //Length: 160
	}

	private override StyleLength UnityEngine.UIElements.IStyle.minWidth
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(StyleValueCollection), Member = "GetStyleLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(StyleLength))]
		private get { } //Length: 59
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(StyleLength)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(VisualElement), Member = "get_layoutNode", ReturnType = typeof(LayoutNode&))]
		[Calls(Type = typeof(VisualElement), Member = "get_computedStyle", ReturnType = typeof(ComputedStyle&))]
		[Calls(Type = typeof(ComputedStyle), Member = "get_minWidth", ReturnType = typeof(Length))]
		[Calls(Type = typeof(StyleValueExtensions), Member = "ToLayoutValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Length)}, ReturnType = typeof(LayoutValue))]
		[Calls(Type = typeof(LayoutNode), Member = "set_MinWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutValue)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		private set { } //Length: 160
	}

	private override StyleFloat UnityEngine.UIElements.IStyle.opacity
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(StyleValueCollection), Member = "GetStyleFloat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(StyleFloat))]
		private get { } //Length: 15
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(StyleFloat)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		private set { } //Length: 67
	}

	private override StyleEnum<Overflow> UnityEngine.UIElements.IStyle.overflow
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(StyleValueCollection), Member = "GetStyleInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(StyleInt))]
		[CallsDeduplicatedMethods(Count = 3)]
		private get { } //Length: 135
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), "UnityEngine.UIElements.StyleEnum`1<T>"}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(VisualElement), Member = "get_layoutNode", ReturnType = typeof(LayoutNode&))]
		[Calls(Type = typeof(VisualElement), Member = "get_computedStyle", ReturnType = typeof(ComputedStyle&))]
		[Calls(Type = typeof(ComputedStyle), Member = "get_overflow", ReturnType = typeof(OverflowInternal))]
		[Calls(Type = typeof(LayoutNode), Member = "set_Overflow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutOverflow)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 1)]
		private set { } //Length: 274
	}

	private override StyleLength UnityEngine.UIElements.IStyle.paddingBottom
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(StyleValueCollection), Member = "GetStyleLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(StyleLength))]
		private get { } //Length: 59
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(StyleLength)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(VisualElement), Member = "get_layoutNode", ReturnType = typeof(LayoutNode&))]
		[Calls(Type = typeof(VisualElement), Member = "get_computedStyle", ReturnType = typeof(ComputedStyle&))]
		[Calls(Type = typeof(ComputedStyle), Member = "get_paddingBottom", ReturnType = typeof(Length))]
		[Calls(Type = typeof(StyleValueExtensions), Member = "ToLayoutValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Length)}, ReturnType = typeof(LayoutValue))]
		[Calls(Type = typeof(LayoutNode), Member = "set_PaddingBottom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutValue)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		private set { } //Length: 160
	}

	private override StyleLength UnityEngine.UIElements.IStyle.paddingLeft
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(StyleValueCollection), Member = "GetStyleLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(StyleLength))]
		private get { } //Length: 59
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(StyleLength)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(VisualElement), Member = "get_layoutNode", ReturnType = typeof(LayoutNode&))]
		[Calls(Type = typeof(VisualElement), Member = "get_computedStyle", ReturnType = typeof(ComputedStyle&))]
		[Calls(Type = typeof(ComputedStyle), Member = "get_paddingLeft", ReturnType = typeof(Length))]
		[Calls(Type = typeof(StyleValueExtensions), Member = "ToLayoutValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Length)}, ReturnType = typeof(LayoutValue))]
		[Calls(Type = typeof(LayoutNode), Member = "set_PaddingLeft", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutValue)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		private set { } //Length: 160
	}

	private override StyleLength UnityEngine.UIElements.IStyle.paddingRight
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(StyleValueCollection), Member = "GetStyleLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(StyleLength))]
		private get { } //Length: 59
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(StyleLength)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(VisualElement), Member = "get_layoutNode", ReturnType = typeof(LayoutNode&))]
		[Calls(Type = typeof(VisualElement), Member = "get_computedStyle", ReturnType = typeof(ComputedStyle&))]
		[Calls(Type = typeof(ComputedStyle), Member = "get_paddingRight", ReturnType = typeof(Length))]
		[Calls(Type = typeof(StyleValueExtensions), Member = "ToLayoutValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Length)}, ReturnType = typeof(LayoutValue))]
		[Calls(Type = typeof(LayoutNode), Member = "set_PaddingRight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutValue)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		private set { } //Length: 160
	}

	private override StyleLength UnityEngine.UIElements.IStyle.paddingTop
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(StyleValueCollection), Member = "GetStyleLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(StyleLength))]
		private get { } //Length: 59
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(StyleLength)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(VisualElement), Member = "get_layoutNode", ReturnType = typeof(LayoutNode&))]
		[Calls(Type = typeof(VisualElement), Member = "get_computedStyle", ReturnType = typeof(ComputedStyle&))]
		[Calls(Type = typeof(ComputedStyle), Member = "get_paddingTop", ReturnType = typeof(Length))]
		[Calls(Type = typeof(StyleValueExtensions), Member = "ToLayoutValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Length)}, ReturnType = typeof(LayoutValue))]
		[Calls(Type = typeof(LayoutNode), Member = "set_PaddingTop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutValue)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		private set { } //Length: 160
	}

	private override StyleEnum<Position> UnityEngine.UIElements.IStyle.position
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(StyleValueCollection), Member = "GetStyleInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(StyleInt))]
		[CallsDeduplicatedMethods(Count = 3)]
		private get { } //Length: 135
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), "UnityEngine.UIElements.StyleEnum`1<T>"}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(VisualElement), Member = "get_layoutNode", ReturnType = typeof(LayoutNode&))]
		[Calls(Type = typeof(VisualElement), Member = "get_computedStyle", ReturnType = typeof(ComputedStyle&))]
		[Calls(Type = typeof(ComputedStyle), Member = "get_position", ReturnType = typeof(Position))]
		[Calls(Type = typeof(LayoutNode), Member = "set_PositionType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutPositionType)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		private set { } //Length: 167
	}

	private override StyleLength UnityEngine.UIElements.IStyle.right
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(StyleValueCollection), Member = "GetStyleLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(StyleLength))]
		private get { } //Length: 59
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(StyleLength)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(VisualElement), Member = "get_layoutNode", ReturnType = typeof(LayoutNode&))]
		[Calls(Type = typeof(VisualElement), Member = "get_computedStyle", ReturnType = typeof(ComputedStyle&))]
		[Calls(Type = typeof(ComputedStyle), Member = "get_right", ReturnType = typeof(Length))]
		[Calls(Type = typeof(StyleValueExtensions), Member = "ToLayoutValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Length)}, ReturnType = typeof(LayoutValue))]
		[Calls(Type = typeof(LayoutNode), Member = "set_Right", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutValue)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		private set { } //Length: 160
	}

	private override StyleRotate UnityEngine.UIElements.IStyle.rotate
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		private get { } //Length: 100
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(StyleRotate), Member = "get_value", ReturnType = typeof(Rotate))]
		[Calls(Type = typeof(Rotate), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rotate), typeof(Rotate)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(InlineStyleAccess), Member = "ApplyStyleRotate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleRotate)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(InlineStyleAccess), Member = "RemoveInlineStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 4)]
		[CallsUnknownMethods(Count = 1)]
		private set { } //Length: 403
	}

	private override StyleScale UnityEngine.UIElements.IStyle.scale
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(StyleScale), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleKeyword)}, ReturnType = typeof(StyleScale))]
		private get { } //Length: 95
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(StyleScale), Member = "get_value", ReturnType = typeof(Scale))]
		[Calls(Type = typeof(InlineStyleAccess), Member = "ApplyStyleScale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleScale)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(InlineStyleAccess), Member = "RemoveInlineStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 5)]
		[CallsUnknownMethods(Count = 1)]
		private set { } //Length: 356
	}

	private override StyleEnum<TextOverflow> UnityEngine.UIElements.IStyle.textOverflow
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(StyleValueCollection), Member = "GetStyleInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(StyleInt))]
		[CallsDeduplicatedMethods(Count = 3)]
		private get { } //Length: 135
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), "UnityEngine.UIElements.StyleEnum`1<T>"}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		private set { } //Length: 109
	}

	private override StyleTextShadow UnityEngine.UIElements.IStyle.textShadow
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(StyleTextShadow), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleKeyword)}, ReturnType = typeof(StyleTextShadow))]
		private get { } //Length: 90
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(StyleTextShadow), Member = "get_value", ReturnType = typeof(TextShadow))]
		[Calls(Type = typeof(TextShadow), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextShadow), typeof(TextShadow)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(StyleTextShadow), Member = "set_value", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextShadow)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(InlineStyleAccess), Member = "ApplyStyleTextShadow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleTextShadow)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(InlineStyleAccess), Member = "RemoveInlineStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 6)]
		[CallsUnknownMethods(Count = 1)]
		private set { } //Length: 442
	}

	private override StyleLength UnityEngine.UIElements.IStyle.top
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(StyleValueCollection), Member = "GetStyleLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(StyleLength))]
		private get { } //Length: 59
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(StyleLength)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(VisualElement), Member = "get_layoutNode", ReturnType = typeof(LayoutNode&))]
		[Calls(Type = typeof(VisualElement), Member = "get_computedStyle", ReturnType = typeof(ComputedStyle&))]
		[Calls(Type = typeof(ComputedStyle), Member = "get_top", ReturnType = typeof(Length))]
		[Calls(Type = typeof(StyleValueExtensions), Member = "ToLayoutValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Length)}, ReturnType = typeof(LayoutValue))]
		[Calls(Type = typeof(LayoutNode), Member = "set_Top", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutValue)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		private set { } //Length: 160
	}

	private override StyleTransformOrigin UnityEngine.UIElements.IStyle.transformOrigin
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		private get { } //Length: 98
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(StyleTransformOrigin), Member = "get_value", ReturnType = typeof(TransformOrigin))]
		[Calls(Type = typeof(TransformOrigin), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TransformOrigin), typeof(TransformOrigin)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(InlineStyleAccess), Member = "ApplyStyleTransformOrigin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleTransformOrigin)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(InlineStyleAccess), Member = "RemoveInlineStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 4)]
		[CallsUnknownMethods(Count = 1)]
		private set { } //Length: 357
	}

	private override StyleList<TimeValue> UnityEngine.UIElements.IStyle.transitionDelay
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InlineStyleAccess), Member = "GetStyleList", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = "UnityEngine.UIElements.StyleList`1<T>")]
		private get { } //Length: 98
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeValue)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(UnityEngine.UIElements.StyleList`1<UnityEngine.UIElements.TimeValue>)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		private set { } //Length: 119
	}

	private override StyleList<TimeValue> UnityEngine.UIElements.IStyle.transitionDuration
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InlineStyleAccess), Member = "GetStyleList", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = "UnityEngine.UIElements.StyleList`1<T>")]
		private get { } //Length: 98
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeValue)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(UnityEngine.UIElements.StyleList`1<UnityEngine.UIElements.TimeValue>)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		private set { } //Length: 119
	}

	private override StyleList<StylePropertyName> UnityEngine.UIElements.IStyle.transitionProperty
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InlineStyleAccess), Member = "GetStyleList", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = "UnityEngine.UIElements.StyleList`1<T>")]
		private get { } //Length: 98
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyName)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(UnityEngine.UIElements.StyleList`1<UnityEngine.UIElements.StylePropertyName>)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		private set { } //Length: 119
	}

	private override StyleList<EasingFunction> UnityEngine.UIElements.IStyle.transitionTimingFunction
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InlineStyleAccess), Member = "GetStyleList", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = "UnityEngine.UIElements.StyleList`1<T>")]
		private get { } //Length: 98
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), "UnityEngine.UIElements.StyleList`1<T>"}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		private set { } //Length: 119
	}

	private override StyleTranslate UnityEngine.UIElements.IStyle.translate
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		private get { } //Length: 100
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(StyleTranslate), Member = "get_value", ReturnType = typeof(Translate))]
		[Calls(Type = typeof(Translate), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Translate), typeof(Translate)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(InlineStyleAccess), Member = "ApplyStyleTranslate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleTranslate)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(InlineStyleAccess), Member = "RemoveInlineStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 4)]
		[CallsUnknownMethods(Count = 1)]
		private set { } //Length: 403
	}

	private override StyleColor UnityEngine.UIElements.IStyle.unityBackgroundImageTintColor
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(StyleValueCollection), Member = "GetStyleColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(StyleColor))]
		private get { } //Length: 60
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(StyleColor)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		private set { } //Length: 84
	}

	private override StyleEnum<EditorTextRenderingMode> UnityEngine.UIElements.IStyle.unityEditorTextRenderingMode
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(StyleValueCollection), Member = "GetStyleInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(StyleInt))]
		[CallsDeduplicatedMethods(Count = 3)]
		private get { } //Length: 135
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), "UnityEngine.UIElements.StyleEnum`1<T>"}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		private set { } //Length: 109
	}

	private override StyleFont UnityEngine.UIElements.IStyle.unityFont
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(StyleValueCollection), Member = "GetStyleFont", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(StyleFont))]
		private get { } //Length: 49
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(StyleFont)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		private set { } //Length: 77
	}

	private override StyleFontDefinition UnityEngine.UIElements.IStyle.unityFontDefinition
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(StyleValueCollection), Member = "GetStyleFontDefinition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(StyleFontDefinition))]
		private get { } //Length: 65
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(StyleFontDefinition)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		private set { } //Length: 88
	}

	private override StyleEnum<FontStyle> UnityEngine.UIElements.IStyle.unityFontStyleAndWeight
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(StyleValueCollection), Member = "GetStyleInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(StyleInt))]
		[CallsDeduplicatedMethods(Count = 3)]
		private get { } //Length: 135
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), "UnityEngine.UIElements.StyleEnum`1<T>"}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		private set { } //Length: 109
	}

	private override StyleEnum<OverflowClipBox> UnityEngine.UIElements.IStyle.unityOverflowClipBox
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(StyleValueCollection), Member = "GetStyleInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(StyleInt))]
		[CallsDeduplicatedMethods(Count = 3)]
		private get { } //Length: 135
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), "UnityEngine.UIElements.StyleEnum`1<T>"}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		private set { } //Length: 109
	}

	private override StyleLength UnityEngine.UIElements.IStyle.unityParagraphSpacing
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(StyleValueCollection), Member = "GetStyleLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(StyleLength))]
		private get { } //Length: 59
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(StyleLength)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		private set { } //Length: 86
	}

	private override StyleInt UnityEngine.UIElements.IStyle.unitySliceBottom
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(StyleValueCollection), Member = "GetStyleInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(StyleInt))]
		private get { } //Length: 15
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(StyleInt)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		private set { } //Length: 67
	}

	private override StyleInt UnityEngine.UIElements.IStyle.unitySliceLeft
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(StyleValueCollection), Member = "GetStyleInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(StyleInt))]
		private get { } //Length: 15
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(StyleInt)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		private set { } //Length: 67
	}

	private override StyleInt UnityEngine.UIElements.IStyle.unitySliceRight
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(StyleValueCollection), Member = "GetStyleInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(StyleInt))]
		private get { } //Length: 15
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(StyleInt)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		private set { } //Length: 67
	}

	private override StyleFloat UnityEngine.UIElements.IStyle.unitySliceScale
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(StyleValueCollection), Member = "GetStyleFloat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(StyleFloat))]
		private get { } //Length: 15
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(StyleFloat)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		private set { } //Length: 67
	}

	private override StyleInt UnityEngine.UIElements.IStyle.unitySliceTop
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(StyleValueCollection), Member = "GetStyleInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(StyleInt))]
		private get { } //Length: 15
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(StyleInt)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		private set { } //Length: 67
	}

	private override StyleEnum<SliceType> UnityEngine.UIElements.IStyle.unitySliceType
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(StyleValueCollection), Member = "GetStyleInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(StyleInt))]
		[CallsDeduplicatedMethods(Count = 3)]
		private get { } //Length: 135
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), "UnityEngine.UIElements.StyleEnum`1<T>"}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		private set { } //Length: 109
	}

	private override StyleEnum<TextAnchor> UnityEngine.UIElements.IStyle.unityTextAlign
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(StyleValueCollection), Member = "GetStyleInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(StyleInt))]
		[CallsDeduplicatedMethods(Count = 3)]
		private get { } //Length: 135
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), "UnityEngine.UIElements.StyleEnum`1<T>"}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		private set { } //Length: 109
	}

	private override StyleEnum<TextGeneratorType> UnityEngine.UIElements.IStyle.unityTextGenerator
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(StyleValueCollection), Member = "GetStyleInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(StyleInt))]
		[CallsDeduplicatedMethods(Count = 3)]
		private get { } //Length: 135
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), "UnityEngine.UIElements.StyleEnum`1<T>"}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		private set { } //Length: 109
	}

	private override StyleColor UnityEngine.UIElements.IStyle.unityTextOutlineColor
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(StyleValueCollection), Member = "GetStyleColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(StyleColor))]
		private get { } //Length: 60
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(StyleColor)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		private set { } //Length: 84
	}

	private override StyleFloat UnityEngine.UIElements.IStyle.unityTextOutlineWidth
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(StyleValueCollection), Member = "GetStyleFloat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(StyleFloat))]
		private get { } //Length: 15
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(StyleFloat)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		private set { } //Length: 67
	}

	private override StyleEnum<TextOverflowPosition> UnityEngine.UIElements.IStyle.unityTextOverflowPosition
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(StyleValueCollection), Member = "GetStyleInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(StyleInt))]
		[CallsDeduplicatedMethods(Count = 3)]
		private get { } //Length: 135
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), "UnityEngine.UIElements.StyleEnum`1<T>"}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		private set { } //Length: 109
	}

	private override StyleEnum<Visibility> UnityEngine.UIElements.IStyle.visibility
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(StyleValueCollection), Member = "GetStyleInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(StyleInt))]
		[CallsDeduplicatedMethods(Count = 3)]
		private get { } //Length: 135
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), "UnityEngine.UIElements.StyleEnum`1<T>"}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		private set { } //Length: 109
	}

	private override StyleEnum<WhiteSpace> UnityEngine.UIElements.IStyle.whiteSpace
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(StyleValueCollection), Member = "GetStyleInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(StyleInt))]
		[CallsDeduplicatedMethods(Count = 3)]
		private get { } //Length: 135
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), "UnityEngine.UIElements.StyleEnum`1<T>"}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		private set { } //Length: 109
	}

	private override StyleLength UnityEngine.UIElements.IStyle.width
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(StyleValueCollection), Member = "GetStyleLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(StyleLength))]
		private get { } //Length: 59
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(StyleLength)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(VisualElement), Member = "get_layoutNode", ReturnType = typeof(LayoutNode&))]
		[Calls(Type = typeof(VisualElement), Member = "get_computedStyle", ReturnType = typeof(ComputedStyle&))]
		[Calls(Type = typeof(ComputedStyle), Member = "get_width", ReturnType = typeof(Length))]
		[Calls(Type = typeof(StyleValueExtensions), Member = "ToLayoutValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Length)}, ReturnType = typeof(LayoutValue))]
		[Calls(Type = typeof(LayoutNode), Member = "set_Width", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutValue)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		private set { } //Length: 160
	}

	private override StyleLength UnityEngine.UIElements.IStyle.wordSpacing
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(StyleValueCollection), Member = "GetStyleLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(StyleLength))]
		private get { } //Length: 59
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(StyleLength)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		private set { } //Length: 86
	}

	private VisualElement ve
	{
		[CallerCount(Count = 12)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private get { } //Length: 5
		[CallerCount(Count = 10)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private set { } //Length: 13
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StylePropertyReader), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private static InlineStyleAccess() { }

	[CalledBy(Type = typeof(VisualElement), Member = "SetInlineRule", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleSheet), typeof(StyleRule)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VisualElement), Member = "get_style", ReturnType = typeof(IStyle))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(StyleValueCollection), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public InlineStyleAccess(VisualElement ve) { }

	[CalledBy(Type = typeof(InlineStyleAccess), Member = "RemoveInlineStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(StylePropertyUtil), Member = "IsAnimatable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElement), Member = "get_computedStyle", ReturnType = typeof(ComputedStyle&))]
	[Calls(Type = typeof(ComputedTransitionUtils), Member = "UpdateComputedTransitions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_hasTransition", ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElement), Member = "get_styleInitialized", ReturnType = typeof(bool))]
	[Calls(Type = typeof(ComputedTransitionUtils), Member = "GetTransitionProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&), typeof(StylePropertyId), typeof(ComputedTransitionProperty&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ComputedStyle), Member = "StartAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StylePropertyId), typeof(ComputedStyle&), typeof(ComputedStyle&), typeof(int), typeof(int), typeof(System.Func`2<System.Single, System.Single>)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ComputedStyle), Member = "ApplyFromComputedStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(ComputedStyle&)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void ApplyFromComputedStyle(StylePropertyId id, ref ComputedStyle newStyle) { }

	[CalledBy(Type = typeof(InlineStyleAccess), Member = "SetInlineRule", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleSheet), typeof(StyleRule)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VisualTreeStyleUpdaterTraversal), Member = "TraverseRecursive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ComputedStyle), Member = "ApplyStyleBackgroundSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BackgroundSize)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StyleBackgroundSize), Member = "get_value", ReturnType = typeof(BackgroundSize))]
	[Calls(Type = typeof(ComputedStyle), Member = "ApplyStyleRotate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rotate)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StyleRotate), Member = "get_value", ReturnType = typeof(Rotate))]
	[Calls(Type = typeof(ComputedStyle), Member = "ApplyStyleScale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Scale)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StyleScale), Member = "get_value", ReturnType = typeof(Scale))]
	[Calls(Type = typeof(ComputedStyle), Member = "ApplyStyleTranslate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Translate)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StyleTranslate), Member = "get_value", ReturnType = typeof(Translate))]
	[Calls(Type = typeof(ComputedStyle), Member = "ApplyStyleTransformOrigin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TransformOrigin)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StyleTransformOrigin), Member = "get_value", ReturnType = typeof(TransformOrigin))]
	[Calls(Type = typeof(ComputedStyle), Member = "ApplyStyleTextShadow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextShadow)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StyleTextShadow), Member = "get_value", ReturnType = typeof(TextShadow))]
	[Calls(Type = typeof(StyleCursor), Member = "get_value", ReturnType = typeof(Cursor))]
	[Calls(Type = typeof(VisualElement), Member = "get_style", ReturnType = typeof(IStyle))]
	[Calls(Type = typeof(ComputedStyle), Member = "ApplyStyleValueManaged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleValueManaged), typeof(ComputedStyle&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ComputedStyle), Member = "ApplyStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleValue), typeof(ComputedStyle&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(ComputedStyle), Member = "ApplyProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyReader), typeof(ComputedStyle&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StylePropertyReader), Member = "SetInlineContext", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleSheet), typeof(StyleProperty[]), typeof(StylePropertyId[]), typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElement), Member = "get_computedStyle", ReturnType = typeof(ComputedStyle&))]
	[Calls(Type = typeof(InitialStyle), Member = "Get", ReturnType = typeof(ComputedStyle&))]
	[Calls(Type = typeof(Hierarchy), Member = "get_parent", ReturnType = typeof(VisualElement))]
	[Calls(Type = typeof(ComputedStyle), Member = "ApplyStyleCursor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Cursor)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 16)]
	[CallsUnknownMethods(Count = 12)]
	public void ApplyInlineStyles(ref ComputedStyle computedStyle) { }

	[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_backgroundSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleBackgroundSize)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "SetInlineBackgroundSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleBackgroundSize)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(VisualElement), Member = "get_computedStyle", ReturnType = typeof(ComputedStyle&))]
	[Calls(Type = typeof(ComputedTransitionUtils), Member = "UpdateComputedTransitions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_hasTransition", ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElement), Member = "get_styleInitialized", ReturnType = typeof(bool))]
	[Calls(Type = typeof(ComputedTransitionUtils), Member = "GetTransitionProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&), typeof(StylePropertyId), typeof(ComputedTransitionProperty&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ComputedStyle), Member = "StartAnimationInlineBackgroundSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(ComputedStyle&), typeof(StyleBackgroundSize), typeof(int), typeof(int), typeof(System.Func`2<System.Single, System.Single>)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(StyleBackgroundSize), Member = "get_value", ReturnType = typeof(BackgroundSize))]
	[Calls(Type = typeof(ComputedStyle), Member = "ApplyStyleBackgroundSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BackgroundSize)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void ApplyStyleBackgroundSize(StyleBackgroundSize backgroundSize) { }

	[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_cursor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleCursor)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "SetInlineCursor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleCursor)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(VisualElement), Member = "get_computedStyle", ReturnType = typeof(ComputedStyle&))]
	[Calls(Type = typeof(StyleCursor), Member = "get_value", ReturnType = typeof(Cursor))]
	[Calls(Type = typeof(ComputedStyle), Member = "ApplyStyleCursor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Cursor)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseVisualElementPanel), Member = "GetTopElementUnderPointer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(VisualElement))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	private void ApplyStyleCursor(StyleCursor cursor) { }

	[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_rotate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleRotate)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "SetInlineRotate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleRotate)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Hierarchy), Member = "get_parent", ReturnType = typeof(VisualElement))]
	[Calls(Type = typeof(InitialStyle), Member = "Get", ReturnType = typeof(ComputedStyle&))]
	[Calls(Type = typeof(VisualElement), Member = "get_computedStyle", ReturnType = typeof(ComputedStyle&))]
	[Calls(Type = typeof(ComputedTransitionUtils), Member = "UpdateComputedTransitions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_hasTransition", ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElement), Member = "get_styleInitialized", ReturnType = typeof(bool))]
	[Calls(Type = typeof(ComputedTransitionUtils), Member = "GetTransitionProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&), typeof(StylePropertyId), typeof(ComputedTransitionProperty&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ComputedStyle), Member = "StartAnimationInlineRotate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(ComputedStyle&), typeof(StyleRotate), typeof(int), typeof(int), typeof(System.Func`2<System.Single, System.Single>)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(StyleRotate), Member = "get_value", ReturnType = typeof(Rotate))]
	[Calls(Type = typeof(ComputedStyle), Member = "ApplyStyleRotate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rotate)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void ApplyStyleRotate(StyleRotate rotate) { }

	[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_scale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleScale)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "SetInlineScale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleScale)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(VisualElement), Member = "get_computedStyle", ReturnType = typeof(ComputedStyle&))]
	[Calls(Type = typeof(ComputedTransitionUtils), Member = "UpdateComputedTransitions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_hasTransition", ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElement), Member = "get_styleInitialized", ReturnType = typeof(bool))]
	[Calls(Type = typeof(ComputedTransitionUtils), Member = "GetTransitionProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&), typeof(StylePropertyId), typeof(ComputedTransitionProperty&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ComputedStyle), Member = "StartAnimationInlineScale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(ComputedStyle&), typeof(StyleScale), typeof(int), typeof(int), typeof(System.Func`2<System.Single, System.Single>)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(StyleScale), Member = "get_value", ReturnType = typeof(Scale))]
	[Calls(Type = typeof(ComputedStyle), Member = "ApplyStyleScale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Scale)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void ApplyStyleScale(StyleScale scale) { }

	[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_textShadow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleTextShadow)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "SetInlineTextShadow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleTextShadow)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(VisualElement), Member = "get_computedStyle", ReturnType = typeof(ComputedStyle&))]
	[Calls(Type = typeof(ComputedTransitionUtils), Member = "UpdateComputedTransitions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_hasTransition", ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElement), Member = "get_styleInitialized", ReturnType = typeof(bool))]
	[Calls(Type = typeof(ComputedTransitionUtils), Member = "GetTransitionProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&), typeof(StylePropertyId), typeof(ComputedTransitionProperty&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ComputedStyle), Member = "StartAnimationInlineTextShadow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(ComputedStyle&), typeof(StyleTextShadow), typeof(int), typeof(int), typeof(System.Func`2<System.Single, System.Single>)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(StyleTextShadow), Member = "get_value", ReturnType = typeof(TextShadow))]
	[Calls(Type = typeof(ComputedStyle), Member = "ApplyStyleTextShadow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextShadow)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void ApplyStyleTextShadow(StyleTextShadow textShadow) { }

	[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_transformOrigin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleTransformOrigin)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "SetInlineTransformOrigin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleTransformOrigin)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(VisualElement), Member = "get_computedStyle", ReturnType = typeof(ComputedStyle&))]
	[Calls(Type = typeof(ComputedTransitionUtils), Member = "UpdateComputedTransitions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_hasTransition", ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElement), Member = "get_styleInitialized", ReturnType = typeof(bool))]
	[Calls(Type = typeof(ComputedTransitionUtils), Member = "GetTransitionProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&), typeof(StylePropertyId), typeof(ComputedTransitionProperty&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ComputedStyle), Member = "StartAnimationInlineTransformOrigin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(ComputedStyle&), typeof(StyleTransformOrigin), typeof(int), typeof(int), typeof(System.Func`2<System.Single, System.Single>)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(StyleTransformOrigin), Member = "get_value", ReturnType = typeof(TransformOrigin))]
	[Calls(Type = typeof(ComputedStyle), Member = "ApplyStyleTransformOrigin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TransformOrigin)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void ApplyStyleTransformOrigin(StyleTransformOrigin transformOrigin) { }

	[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_translate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleTranslate)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "SetInlineTranslate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleTranslate)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(VisualElement), Member = "get_computedStyle", ReturnType = typeof(ComputedStyle&))]
	[Calls(Type = typeof(ComputedTransitionUtils), Member = "UpdateComputedTransitions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_hasTransition", ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElement), Member = "get_styleInitialized", ReturnType = typeof(bool))]
	[Calls(Type = typeof(ComputedTransitionUtils), Member = "GetTransitionProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&), typeof(StylePropertyId), typeof(ComputedTransitionProperty&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ComputedStyle), Member = "StartAnimationInlineTranslate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(ComputedStyle&), typeof(StyleTranslate), typeof(int), typeof(int), typeof(System.Func`2<System.Single, System.Single>)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(StyleTranslate), Member = "get_value", ReturnType = typeof(Translate))]
	[Calls(Type = typeof(ComputedStyle), Member = "ApplyStyleTranslate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Translate)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void ApplyStyleTranslate(StyleTranslate translate) { }

	[CalledBy(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), "UnityEngine.UIElements.StyleList`1<T>"}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Hierarchy), Member = "get_parent", ReturnType = typeof(VisualElement))]
	[Calls(Type = typeof(InitialStyle), Member = "Get", ReturnType = typeof(ComputedStyle&))]
	[Calls(Type = typeof(VisualElement), Member = "get_computedStyle", ReturnType = typeof(ComputedStyle&))]
	[Calls(Type = typeof(ComputedStyle), Member = "ApplyStyleValueManaged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleValueManaged), typeof(ComputedStyle&)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private void ApplyStyleValue(StyleValueManaged value) { }

	[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_backgroundRepeat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleBackgroundRepeat)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(StyleBackgroundPosition)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(StyleBackgroundRepeat)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(StyleLength)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(StyleFloat)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(StyleInt)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(StyleColor)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), "UnityEngine.UIElements.StyleEnum`1<T>"}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(StyleBackground)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(StyleFontDefinition)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(StyleFont)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(Hierarchy), Member = "get_parent", ReturnType = typeof(VisualElement))]
	[Calls(Type = typeof(InitialStyle), Member = "Get", ReturnType = typeof(ComputedStyle&))]
	[Calls(Type = typeof(VisualElement), Member = "get_computedStyle", ReturnType = typeof(ComputedStyle&))]
	[Calls(Type = typeof(StylePropertyUtil), Member = "IsAnimatable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ComputedTransitionUtils), Member = "UpdateComputedTransitions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_hasTransition", ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElement), Member = "get_styleInitialized", ReturnType = typeof(bool))]
	[Calls(Type = typeof(ComputedTransitionUtils), Member = "GetTransitionProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&), typeof(StylePropertyId), typeof(ComputedTransitionProperty&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ComputedStyle), Member = "StartAnimationInline", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StylePropertyId), typeof(ComputedStyle&), typeof(StyleValue), typeof(int), typeof(int), typeof(System.Func`2<System.Single, System.Single>)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ComputedStyle), Member = "ApplyStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleValue), typeof(ComputedStyle&)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void ApplyStyleValue(StyleValue value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StyleValueCollection), Member = "TryGetStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(StyleValue&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(GCHandle), Member = "Free", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	protected virtual void Finalize() { }

	[CallerCount(Count = 12)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private VisualElement get_ve() { }

	[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.get_transitionDelay", ReturnType = typeof(UnityEngine.UIElements.StyleList`1<UnityEngine.UIElements.TimeValue>))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.get_transitionDuration", ReturnType = typeof(UnityEngine.UIElements.StyleList`1<UnityEngine.UIElements.TimeValue>))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.get_transitionProperty", ReturnType = typeof(UnityEngine.UIElements.StyleList`1<UnityEngine.UIElements.StylePropertyName>))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.get_transitionTimingFunction", ReturnType = typeof(UnityEngine.UIElements.StyleList`1<UnityEngine.UIElements.EasingFunction>))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(InlineStyleAccess), Member = "TryGetStyleValueManaged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(StyleValueManaged&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(StyleList`1), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleKeyword)}, ReturnType = "UnityEngine.UIElements.StyleList`1<T>")]
	[Calls(Type = typeof(StyleList`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.List`1<T>", typeof(StyleKeyword)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	private StyleList<T> GetStyleList(StylePropertyId id) { }

	[CalledBy(Type = typeof(VisualTreeStyleUpdaterTraversal), Member = "TraverseRecursive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VisualTreeStyleUpdaterTraversal), Member = "ProcessTransitions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(ComputedStyle&), typeof(ComputedStyle&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 3)]
	public bool IsValueSet(StylePropertyId id) { }

	[CallerCount(Count = 26)]
	[Calls(Type = typeof(VisualElement), Member = "get_computedStyle", ReturnType = typeof(ComputedStyle&))]
	[Calls(Type = typeof(StyleCache), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(ComputedStyle&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(InitialStyle), Member = "Get", ReturnType = typeof(ComputedStyle&))]
	[Calls(Type = typeof(InlineStyleAccess), Member = "ApplyFromComputedStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(ComputedStyle&)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private bool RemoveInlineStyle(StylePropertyId id) { }

	[CallerCount(Count = 10)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void set_ve(VisualElement value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StyleBackgroundSize), Member = "get_value", ReturnType = typeof(BackgroundSize))]
	[Calls(Type = typeof(BackgroundSize), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BackgroundSize), typeof(BackgroundSize)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(InlineStyleAccess), Member = "ApplyStyleBackgroundSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleBackgroundSize)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InlineStyleAccess), Member = "RemoveInlineStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 4)]
	private bool SetInlineBackgroundSize(StyleBackgroundSize inlineValue) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StyleCursor), Member = "get_value", ReturnType = typeof(Cursor))]
	[Calls(Type = typeof(Cursor), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Cursor), typeof(Cursor)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(StyleCursor), Member = "set_value", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Cursor)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InlineStyleAccess), Member = "ApplyStyleCursor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleCursor)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InlineStyleAccess), Member = "RemoveInlineStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 2)]
	private bool SetInlineCursor(StyleCursor inlineValue) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StyleRotate), Member = "get_value", ReturnType = typeof(Rotate))]
	[Calls(Type = typeof(Rotate), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rotate), typeof(Rotate)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(InlineStyleAccess), Member = "ApplyStyleRotate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleRotate)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InlineStyleAccess), Member = "RemoveInlineStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 4)]
	private bool SetInlineRotate(StyleRotate inlineValue) { }

	[CalledBy(Type = typeof(VisualElement), Member = "SetInlineRule", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleSheet), typeof(StyleRule)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(StyleSheetCache), Member = "GetPropertyIds", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleRule)}, ReturnType = typeof(StylePropertyId[]))]
	[Calls(Type = typeof(VisualElement), Member = "get_computedStyle", ReturnType = typeof(ComputedStyle&))]
	[Calls(Type = typeof(InlineStyleAccess), Member = "ApplyInlineStyles", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	public void SetInlineRule(StyleSheet sheet, StyleRule rule) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StyleScale), Member = "get_value", ReturnType = typeof(Scale))]
	[Calls(Type = typeof(InlineStyleAccess), Member = "ApplyStyleScale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleScale)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InlineStyleAccess), Member = "RemoveInlineStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 5)]
	private bool SetInlineScale(StyleScale inlineValue) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StyleTextShadow), Member = "get_value", ReturnType = typeof(TextShadow))]
	[Calls(Type = typeof(TextShadow), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextShadow), typeof(TextShadow)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(StyleTextShadow), Member = "set_value", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextShadow)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InlineStyleAccess), Member = "ApplyStyleTextShadow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleTextShadow)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InlineStyleAccess), Member = "RemoveInlineStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 6)]
	private bool SetInlineTextShadow(StyleTextShadow inlineValue) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StyleTransformOrigin), Member = "get_value", ReturnType = typeof(TransformOrigin))]
	[Calls(Type = typeof(TransformOrigin), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TransformOrigin), typeof(TransformOrigin)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(InlineStyleAccess), Member = "ApplyStyleTransformOrigin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleTransformOrigin)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InlineStyleAccess), Member = "RemoveInlineStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 4)]
	private bool SetInlineTransformOrigin(StyleTransformOrigin inlineValue) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StyleTranslate), Member = "get_value", ReturnType = typeof(Translate))]
	[Calls(Type = typeof(Translate), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Translate), typeof(Translate)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(InlineStyleAccess), Member = "ApplyStyleTranslate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleTranslate)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InlineStyleAccess), Member = "RemoveInlineStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 4)]
	private bool SetInlineTranslate(StyleTranslate inlineValue) { }

	[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_transitionTimingFunction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityEngine.UIElements.StyleList`1<UnityEngine.UIElements.EasingFunction>)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InlineStyleAccess), Member = "TryGetStyleValueManaged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(StyleValueManaged&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(StyleList`1), Member = "get_value", ReturnType = "System.Collections.Generic.List`1<T>")]
	[Calls(Type = typeof(Enumerable), Member = "SequenceEqual", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EasingFunction)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<UnityEngine.UIElements.EasingFunction>), typeof(System.Collections.Generic.IEnumerable`1<UnityEngine.UIElements.EasingFunction>)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.EasingFunction>), Member = "AddRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<UnityEngine.UIElements.EasingFunction>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.EasingFunction>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<UnityEngine.UIElements.EasingFunction>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InlineStyleAccess), Member = "SetStyleValueManaged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleValueManaged)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InlineStyleAccess), Member = "ApplyStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleValueManaged)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InlineStyleAccess), Member = "RemoveInlineStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 8)]
	[DeduplicatedMethod]
	private bool SetStyleValue(StylePropertyId id, StyleList<T> inlineValue) { }

	[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_unityFontDefinition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleFontDefinition)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(StyleValueCollection), Member = "TryGetStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(StyleValue&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(StyleFontDefinition), Member = "get_value", ReturnType = typeof(FontDefinition))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(GCHandle), Member = "Free", ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(GCHandle), Member = "Alloc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(GCHandle))]
	[Calls(Type = typeof(StyleValueCollection), Member = "SetStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleValue)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InlineStyleAccess), Member = "ApplyStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleValue)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InlineStyleAccess), Member = "RemoveInlineStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 2)]
	private bool SetStyleValue(StylePropertyId id, StyleFontDefinition inlineValue) { }

	[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_backgroundImage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleBackground)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(StyleValueCollection), Member = "TryGetStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(StyleValue&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(GCHandle), Member = "GetTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(StyleBackground), Member = "get_value", ReturnType = typeof(Background))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(GCHandle), Member = "Free", ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(GCHandle), Member = "Alloc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(GCHandle))]
	[Calls(Type = typeof(StyleValueCollection), Member = "SetStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleValue)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InlineStyleAccess), Member = "ApplyStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleValue)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InlineStyleAccess), Member = "RemoveInlineStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 3)]
	private bool SetStyleValue(StylePropertyId id, StyleBackground inlineValue) { }

	[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_unityFontStyleAndWeight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityEngine.UIElements.StyleEnum`1<UnityEngine.FontStyle>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_whiteSpace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityEngine.UIElements.StyleEnum`1<UnityEngine.UIElements.WhiteSpace>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_visibility", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityEngine.UIElements.StyleEnum`1<UnityEngine.UIElements.Visibility>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_unityTextOverflowPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityEngine.UIElements.StyleEnum`1<UnityEngine.UIElements.TextOverflowPosition>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_unityTextGenerator", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityEngine.UIElements.StyleEnum`1<UnityEngine.TextGeneratorType>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_unityTextAlign", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityEngine.UIElements.StyleEnum`1<UnityEngine.TextAnchor>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_unitySliceType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityEngine.UIElements.StyleEnum`1<UnityEngine.UIElements.SliceType>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_unityOverflowClipBox", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityEngine.UIElements.StyleEnum`1<UnityEngine.UIElements.OverflowClipBox>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_textOverflow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityEngine.UIElements.StyleEnum`1<UnityEngine.UIElements.TextOverflow>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_position", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityEngine.UIElements.StyleEnum`1<UnityEngine.UIElements.Position>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_unityEditorTextRenderingMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityEngine.UIElements.StyleEnum`1<UnityEngine.UIElements.EditorTextRenderingMode>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_justifyContent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityEngine.UIElements.StyleEnum`1<UnityEngine.UIElements.Justify>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_flexWrap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityEngine.UIElements.StyleEnum`1<UnityEngine.UIElements.Wrap>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_flexDirection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityEngine.UIElements.StyleEnum`1<UnityEngine.UIElements.FlexDirection>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_display", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityEngine.UIElements.StyleEnum`1<UnityEngine.UIElements.DisplayStyle>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_alignSelf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityEngine.UIElements.StyleEnum`1<UnityEngine.UIElements.Align>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_alignItems", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityEngine.UIElements.StyleEnum`1<UnityEngine.UIElements.Align>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_alignContent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityEngine.UIElements.StyleEnum`1<UnityEngine.UIElements.Align>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_overflow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityEngine.UIElements.StyleEnum`1<UnityEngine.UIElements.Overflow>)}, ReturnType = typeof(void))]
	[CallerCount(Count = 19)]
	[Calls(Type = typeof(StyleValueCollection), Member = "SetStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleValue)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InlineStyleAccess), Member = "RemoveInlineStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(StyleValueCollection), Member = "TryGetStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(StyleValue&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(InlineStyleAccess), Member = "ApplyStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleValue)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	private bool SetStyleValue(StylePropertyId id, StyleEnum<T> inlineValue) { }

	[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_backgroundColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleColor)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_borderBottomColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleColor)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_borderLeftColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleColor)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_borderRightColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleColor)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_borderTopColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleColor)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_color", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleColor)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_unityBackgroundImageTintColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleColor)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_unityTextOutlineColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleColor)}, ReturnType = typeof(void))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(StyleValueCollection), Member = "TryGetStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(StyleValue&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(StyleColor), Member = "get_value", ReturnType = typeof(Color))]
	[Calls(Type = typeof(StyleValueCollection), Member = "SetStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleValue)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InlineStyleAccess), Member = "ApplyStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleValue)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InlineStyleAccess), Member = "RemoveInlineStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 4)]
	[ContainsUnimplementedInstructions]
	private bool SetStyleValue(StylePropertyId id, StyleColor inlineValue) { }

	[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_unitySliceBottom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleInt)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_unitySliceLeft", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleInt)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_unitySliceRight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleInt)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_unitySliceTop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleInt)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(StyleValueCollection), Member = "TryGetStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(StyleValue&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(StyleValueCollection), Member = "SetStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleValue)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InlineStyleAccess), Member = "ApplyStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleValue)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InlineStyleAccess), Member = "RemoveInlineStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 6)]
	[ContainsUnimplementedInstructions]
	private bool SetStyleValue(StylePropertyId id, StyleInt inlineValue) { }

	[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_unitySliceScale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleFloat)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_borderBottomWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleFloat)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_borderLeftWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleFloat)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_borderRightWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleFloat)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_borderTopWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleFloat)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_flexGrow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleFloat)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_flexShrink", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleFloat)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_opacity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleFloat)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_unityTextOutlineWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleFloat)}, ReturnType = typeof(void))]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(InlineStyleAccess), Member = "RemoveInlineStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(StyleValueCollection), Member = "TryGetStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(StyleValue&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(StyleFloat), Member = "get_value", ReturnType = typeof(float))]
	[Calls(Type = typeof(StyleValueCollection), Member = "SetStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleValue)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InlineStyleAccess), Member = "ApplyStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleValue)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[ContainsUnimplementedInstructions]
	private bool SetStyleValue(StylePropertyId id, StyleFloat inlineValue) { }

	[CallerCount(Count = 27)]
	[Calls(Type = typeof(StyleValueCollection), Member = "TryGetStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(StyleValue&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(StyleValueExtensions), Member = "ToLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleLength)}, ReturnType = typeof(Length))]
	[Calls(Type = typeof(StyleValueCollection), Member = "SetStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleValue)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InlineStyleAccess), Member = "ApplyStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleValue)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InlineStyleAccess), Member = "RemoveInlineStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 5)]
	private bool SetStyleValue(StylePropertyId id, StyleLength inlineValue) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StyleValueCollection), Member = "TryGetStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(StyleValue&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BackgroundRepeat), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BackgroundRepeat), typeof(BackgroundRepeat)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(StyleValueCollection), Member = "SetStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleValue)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InlineStyleAccess), Member = "ApplyStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleValue)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InlineStyleAccess), Member = "RemoveInlineStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 6)]
	private bool SetStyleValue(StylePropertyId id, StyleBackgroundRepeat inlineValue) { }

	[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_backgroundPositionX", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleBackgroundPosition)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_backgroundPositionY", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleBackgroundPosition)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(StyleValueCollection), Member = "TryGetStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(StyleValue&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(StyleBackgroundPosition), Member = "get_value", ReturnType = typeof(BackgroundPosition))]
	[Calls(Type = typeof(StyleValueCollection), Member = "SetStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleValue)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InlineStyleAccess), Member = "ApplyStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleValue)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InlineStyleAccess), Member = "RemoveInlineStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 5)]
	[ContainsUnimplementedInstructions]
	private bool SetStyleValue(StylePropertyId id, StyleBackgroundPosition inlineValue) { }

	[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_unityFont", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleFont)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(StyleValueCollection), Member = "TryGetStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(StyleValue&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(GCHandle), Member = "GetTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(GCHandle), Member = "Free", ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(GCHandle), Member = "Alloc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(GCHandle))]
	[Calls(Type = typeof(StyleValueCollection), Member = "SetStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleValue)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InlineStyleAccess), Member = "ApplyStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleValue)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InlineStyleAccess), Member = "RemoveInlineStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 8)]
	private bool SetStyleValue(StylePropertyId id, StyleFont inlineValue) { }

	[CalledBy(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), "UnityEngine.UIElements.StyleList`1<T>"}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(List`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[Calls(Type = typeof(List`1), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), "T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "RemoveAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	private void SetStyleValueManaged(StyleValueManaged value) { }

	[CallerCount(Count = 0)]
	public bool TryGetInlineBackgroundSize(ref StyleBackgroundSize value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public bool TryGetInlineCursor(ref StyleCursor value) { }

	[CallerCount(Count = 0)]
	public bool TryGetInlineRotate(ref StyleRotate value) { }

	[CallerCount(Count = 0)]
	public bool TryGetInlineScale(ref StyleScale value) { }

	[CallerCount(Count = 0)]
	public bool TryGetInlineTextShadow(ref StyleTextShadow value) { }

	[CallerCount(Count = 0)]
	public bool TryGetInlineTransformOrigin(ref StyleTransformOrigin value) { }

	[CallerCount(Count = 0)]
	public bool TryGetInlineTranslate(ref StyleTranslate value) { }

	[CalledBy(Type = typeof(InlineStyleAccess), Member = "GetStyleList", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = "UnityEngine.UIElements.StyleList`1<T>")]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), "UnityEngine.UIElements.StyleList`1<T>"}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	private bool TryGetStyleValueManaged(StylePropertyId id, ref StyleValueManaged value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StyleValueCollection), Member = "GetStyleInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(StyleInt))]
	[CallsDeduplicatedMethods(Count = 3)]
	private override StyleEnum<Align> UnityEngine.UIElements.IStyle.get_alignContent() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StyleValueCollection), Member = "GetStyleInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(StyleInt))]
	[CallsDeduplicatedMethods(Count = 3)]
	private override StyleEnum<Align> UnityEngine.UIElements.IStyle.get_alignItems() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StyleValueCollection), Member = "GetStyleInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(StyleInt))]
	[CallsDeduplicatedMethods(Count = 3)]
	private override StyleEnum<Align> UnityEngine.UIElements.IStyle.get_alignSelf() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StyleValueCollection), Member = "GetStyleColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(StyleColor))]
	private override StyleColor UnityEngine.UIElements.IStyle.get_backgroundColor() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StyleValueCollection), Member = "GetStyleBackground", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(StyleBackground))]
	private override StyleBackground UnityEngine.UIElements.IStyle.get_backgroundImage() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StyleValueCollection), Member = "GetStyleBackgroundPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(StyleBackgroundPosition))]
	private override StyleBackgroundPosition UnityEngine.UIElements.IStyle.get_backgroundPositionX() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StyleValueCollection), Member = "GetStyleBackgroundPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(StyleBackgroundPosition))]
	private override StyleBackgroundPosition UnityEngine.UIElements.IStyle.get_backgroundPositionY() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StyleValueCollection), Member = "GetStyleBackgroundRepeat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(StyleBackgroundRepeat))]
	private override StyleBackgroundRepeat UnityEngine.UIElements.IStyle.get_backgroundRepeat() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private override StyleBackgroundSize UnityEngine.UIElements.IStyle.get_backgroundSize() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StyleValueCollection), Member = "GetStyleColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(StyleColor))]
	private override StyleColor UnityEngine.UIElements.IStyle.get_borderBottomColor() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StyleValueCollection), Member = "GetStyleLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(StyleLength))]
	private override StyleLength UnityEngine.UIElements.IStyle.get_borderBottomLeftRadius() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StyleValueCollection), Member = "GetStyleLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(StyleLength))]
	private override StyleLength UnityEngine.UIElements.IStyle.get_borderBottomRightRadius() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StyleValueCollection), Member = "GetStyleFloat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(StyleFloat))]
	private override StyleFloat UnityEngine.UIElements.IStyle.get_borderBottomWidth() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StyleValueCollection), Member = "GetStyleColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(StyleColor))]
	private override StyleColor UnityEngine.UIElements.IStyle.get_borderLeftColor() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StyleValueCollection), Member = "GetStyleFloat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(StyleFloat))]
	private override StyleFloat UnityEngine.UIElements.IStyle.get_borderLeftWidth() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StyleValueCollection), Member = "GetStyleColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(StyleColor))]
	private override StyleColor UnityEngine.UIElements.IStyle.get_borderRightColor() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StyleValueCollection), Member = "GetStyleFloat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(StyleFloat))]
	private override StyleFloat UnityEngine.UIElements.IStyle.get_borderRightWidth() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StyleValueCollection), Member = "GetStyleColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(StyleColor))]
	private override StyleColor UnityEngine.UIElements.IStyle.get_borderTopColor() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StyleValueCollection), Member = "GetStyleLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(StyleLength))]
	private override StyleLength UnityEngine.UIElements.IStyle.get_borderTopLeftRadius() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StyleValueCollection), Member = "GetStyleLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(StyleLength))]
	private override StyleLength UnityEngine.UIElements.IStyle.get_borderTopRightRadius() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StyleValueCollection), Member = "GetStyleFloat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(StyleFloat))]
	private override StyleFloat UnityEngine.UIElements.IStyle.get_borderTopWidth() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StyleValueCollection), Member = "GetStyleLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(StyleLength))]
	private override StyleLength UnityEngine.UIElements.IStyle.get_bottom() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StyleValueCollection), Member = "GetStyleColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(StyleColor))]
	private override StyleColor UnityEngine.UIElements.IStyle.get_color() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StyleCursor), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleKeyword)}, ReturnType = typeof(StyleCursor))]
	[CallsUnknownMethods(Count = 1)]
	private override StyleCursor UnityEngine.UIElements.IStyle.get_cursor() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StyleValueCollection), Member = "GetStyleInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(StyleInt))]
	[CallsDeduplicatedMethods(Count = 3)]
	private override StyleEnum<DisplayStyle> UnityEngine.UIElements.IStyle.get_display() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StyleValueCollection), Member = "GetStyleLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(StyleLength))]
	private override StyleLength UnityEngine.UIElements.IStyle.get_flexBasis() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StyleValueCollection), Member = "GetStyleInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(StyleInt))]
	[CallsDeduplicatedMethods(Count = 3)]
	private override StyleEnum<FlexDirection> UnityEngine.UIElements.IStyle.get_flexDirection() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StyleValueCollection), Member = "GetStyleFloat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(StyleFloat))]
	private override StyleFloat UnityEngine.UIElements.IStyle.get_flexGrow() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StyleValueCollection), Member = "GetStyleFloat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(StyleFloat))]
	private override StyleFloat UnityEngine.UIElements.IStyle.get_flexShrink() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StyleValueCollection), Member = "GetStyleInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(StyleInt))]
	[CallsDeduplicatedMethods(Count = 3)]
	private override StyleEnum<Wrap> UnityEngine.UIElements.IStyle.get_flexWrap() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StyleValueCollection), Member = "GetStyleLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(StyleLength))]
	private override StyleLength UnityEngine.UIElements.IStyle.get_fontSize() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StyleValueCollection), Member = "GetStyleLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(StyleLength))]
	private override StyleLength UnityEngine.UIElements.IStyle.get_height() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StyleValueCollection), Member = "GetStyleInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(StyleInt))]
	[CallsDeduplicatedMethods(Count = 3)]
	private override StyleEnum<Justify> UnityEngine.UIElements.IStyle.get_justifyContent() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StyleValueCollection), Member = "GetStyleLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(StyleLength))]
	private override StyleLength UnityEngine.UIElements.IStyle.get_left() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StyleValueCollection), Member = "GetStyleLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(StyleLength))]
	private override StyleLength UnityEngine.UIElements.IStyle.get_letterSpacing() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StyleValueCollection), Member = "GetStyleLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(StyleLength))]
	private override StyleLength UnityEngine.UIElements.IStyle.get_marginBottom() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StyleValueCollection), Member = "GetStyleLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(StyleLength))]
	private override StyleLength UnityEngine.UIElements.IStyle.get_marginLeft() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StyleValueCollection), Member = "GetStyleLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(StyleLength))]
	private override StyleLength UnityEngine.UIElements.IStyle.get_marginRight() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StyleValueCollection), Member = "GetStyleLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(StyleLength))]
	private override StyleLength UnityEngine.UIElements.IStyle.get_marginTop() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StyleValueCollection), Member = "GetStyleLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(StyleLength))]
	private override StyleLength UnityEngine.UIElements.IStyle.get_maxHeight() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StyleValueCollection), Member = "GetStyleLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(StyleLength))]
	private override StyleLength UnityEngine.UIElements.IStyle.get_maxWidth() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StyleValueCollection), Member = "GetStyleLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(StyleLength))]
	private override StyleLength UnityEngine.UIElements.IStyle.get_minHeight() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StyleValueCollection), Member = "GetStyleLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(StyleLength))]
	private override StyleLength UnityEngine.UIElements.IStyle.get_minWidth() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StyleValueCollection), Member = "GetStyleFloat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(StyleFloat))]
	private override StyleFloat UnityEngine.UIElements.IStyle.get_opacity() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StyleValueCollection), Member = "GetStyleInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(StyleInt))]
	[CallsDeduplicatedMethods(Count = 3)]
	private override StyleEnum<Overflow> UnityEngine.UIElements.IStyle.get_overflow() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StyleValueCollection), Member = "GetStyleLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(StyleLength))]
	private override StyleLength UnityEngine.UIElements.IStyle.get_paddingBottom() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StyleValueCollection), Member = "GetStyleLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(StyleLength))]
	private override StyleLength UnityEngine.UIElements.IStyle.get_paddingLeft() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StyleValueCollection), Member = "GetStyleLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(StyleLength))]
	private override StyleLength UnityEngine.UIElements.IStyle.get_paddingRight() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StyleValueCollection), Member = "GetStyleLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(StyleLength))]
	private override StyleLength UnityEngine.UIElements.IStyle.get_paddingTop() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StyleValueCollection), Member = "GetStyleInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(StyleInt))]
	[CallsDeduplicatedMethods(Count = 3)]
	private override StyleEnum<Position> UnityEngine.UIElements.IStyle.get_position() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StyleValueCollection), Member = "GetStyleLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(StyleLength))]
	private override StyleLength UnityEngine.UIElements.IStyle.get_right() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private override StyleRotate UnityEngine.UIElements.IStyle.get_rotate() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StyleScale), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleKeyword)}, ReturnType = typeof(StyleScale))]
	private override StyleScale UnityEngine.UIElements.IStyle.get_scale() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StyleValueCollection), Member = "GetStyleInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(StyleInt))]
	[CallsDeduplicatedMethods(Count = 3)]
	private override StyleEnum<TextOverflow> UnityEngine.UIElements.IStyle.get_textOverflow() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StyleTextShadow), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleKeyword)}, ReturnType = typeof(StyleTextShadow))]
	private override StyleTextShadow UnityEngine.UIElements.IStyle.get_textShadow() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StyleValueCollection), Member = "GetStyleLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(StyleLength))]
	private override StyleLength UnityEngine.UIElements.IStyle.get_top() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private override StyleTransformOrigin UnityEngine.UIElements.IStyle.get_transformOrigin() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InlineStyleAccess), Member = "GetStyleList", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = "UnityEngine.UIElements.StyleList`1<T>")]
	private override StyleList<TimeValue> UnityEngine.UIElements.IStyle.get_transitionDelay() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InlineStyleAccess), Member = "GetStyleList", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = "UnityEngine.UIElements.StyleList`1<T>")]
	private override StyleList<TimeValue> UnityEngine.UIElements.IStyle.get_transitionDuration() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InlineStyleAccess), Member = "GetStyleList", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = "UnityEngine.UIElements.StyleList`1<T>")]
	private override StyleList<StylePropertyName> UnityEngine.UIElements.IStyle.get_transitionProperty() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InlineStyleAccess), Member = "GetStyleList", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = "UnityEngine.UIElements.StyleList`1<T>")]
	private override StyleList<EasingFunction> UnityEngine.UIElements.IStyle.get_transitionTimingFunction() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private override StyleTranslate UnityEngine.UIElements.IStyle.get_translate() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StyleValueCollection), Member = "GetStyleColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(StyleColor))]
	private override StyleColor UnityEngine.UIElements.IStyle.get_unityBackgroundImageTintColor() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StyleValueCollection), Member = "GetStyleInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(StyleInt))]
	[CallsDeduplicatedMethods(Count = 3)]
	private override StyleEnum<EditorTextRenderingMode> UnityEngine.UIElements.IStyle.get_unityEditorTextRenderingMode() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StyleValueCollection), Member = "GetStyleFont", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(StyleFont))]
	private override StyleFont UnityEngine.UIElements.IStyle.get_unityFont() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StyleValueCollection), Member = "GetStyleFontDefinition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(StyleFontDefinition))]
	private override StyleFontDefinition UnityEngine.UIElements.IStyle.get_unityFontDefinition() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StyleValueCollection), Member = "GetStyleInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(StyleInt))]
	[CallsDeduplicatedMethods(Count = 3)]
	private override StyleEnum<FontStyle> UnityEngine.UIElements.IStyle.get_unityFontStyleAndWeight() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StyleValueCollection), Member = "GetStyleInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(StyleInt))]
	[CallsDeduplicatedMethods(Count = 3)]
	private override StyleEnum<OverflowClipBox> UnityEngine.UIElements.IStyle.get_unityOverflowClipBox() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StyleValueCollection), Member = "GetStyleLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(StyleLength))]
	private override StyleLength UnityEngine.UIElements.IStyle.get_unityParagraphSpacing() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StyleValueCollection), Member = "GetStyleInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(StyleInt))]
	private override StyleInt UnityEngine.UIElements.IStyle.get_unitySliceBottom() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StyleValueCollection), Member = "GetStyleInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(StyleInt))]
	private override StyleInt UnityEngine.UIElements.IStyle.get_unitySliceLeft() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StyleValueCollection), Member = "GetStyleInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(StyleInt))]
	private override StyleInt UnityEngine.UIElements.IStyle.get_unitySliceRight() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StyleValueCollection), Member = "GetStyleFloat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(StyleFloat))]
	private override StyleFloat UnityEngine.UIElements.IStyle.get_unitySliceScale() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StyleValueCollection), Member = "GetStyleInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(StyleInt))]
	private override StyleInt UnityEngine.UIElements.IStyle.get_unitySliceTop() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StyleValueCollection), Member = "GetStyleInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(StyleInt))]
	[CallsDeduplicatedMethods(Count = 3)]
	private override StyleEnum<SliceType> UnityEngine.UIElements.IStyle.get_unitySliceType() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StyleValueCollection), Member = "GetStyleInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(StyleInt))]
	[CallsDeduplicatedMethods(Count = 3)]
	private override StyleEnum<TextAnchor> UnityEngine.UIElements.IStyle.get_unityTextAlign() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StyleValueCollection), Member = "GetStyleInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(StyleInt))]
	[CallsDeduplicatedMethods(Count = 3)]
	private override StyleEnum<TextGeneratorType> UnityEngine.UIElements.IStyle.get_unityTextGenerator() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StyleValueCollection), Member = "GetStyleColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(StyleColor))]
	private override StyleColor UnityEngine.UIElements.IStyle.get_unityTextOutlineColor() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StyleValueCollection), Member = "GetStyleFloat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(StyleFloat))]
	private override StyleFloat UnityEngine.UIElements.IStyle.get_unityTextOutlineWidth() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StyleValueCollection), Member = "GetStyleInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(StyleInt))]
	[CallsDeduplicatedMethods(Count = 3)]
	private override StyleEnum<TextOverflowPosition> UnityEngine.UIElements.IStyle.get_unityTextOverflowPosition() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StyleValueCollection), Member = "GetStyleInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(StyleInt))]
	[CallsDeduplicatedMethods(Count = 3)]
	private override StyleEnum<Visibility> UnityEngine.UIElements.IStyle.get_visibility() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StyleValueCollection), Member = "GetStyleInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(StyleInt))]
	[CallsDeduplicatedMethods(Count = 3)]
	private override StyleEnum<WhiteSpace> UnityEngine.UIElements.IStyle.get_whiteSpace() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StyleValueCollection), Member = "GetStyleLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(StyleLength))]
	private override StyleLength UnityEngine.UIElements.IStyle.get_width() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StyleValueCollection), Member = "GetStyleLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(StyleLength))]
	private override StyleLength UnityEngine.UIElements.IStyle.get_wordSpacing() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), "UnityEngine.UIElements.StyleEnum`1<T>"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "get_layoutNode", ReturnType = typeof(LayoutNode&))]
	[Calls(Type = typeof(VisualElement), Member = "get_computedStyle", ReturnType = typeof(ComputedStyle&))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_alignContent", ReturnType = typeof(Align))]
	[Calls(Type = typeof(LayoutNode), Member = "set_AlignContent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutAlign)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private override void UnityEngine.UIElements.IStyle.set_alignContent(StyleEnum<Align> value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), "UnityEngine.UIElements.StyleEnum`1<T>"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "get_layoutNode", ReturnType = typeof(LayoutNode&))]
	[Calls(Type = typeof(VisualElement), Member = "get_computedStyle", ReturnType = typeof(ComputedStyle&))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_alignItems", ReturnType = typeof(Align))]
	[Calls(Type = typeof(LayoutNode), Member = "set_AlignItems", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutAlign)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private override void UnityEngine.UIElements.IStyle.set_alignItems(StyleEnum<Align> value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), "UnityEngine.UIElements.StyleEnum`1<T>"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "get_layoutNode", ReturnType = typeof(LayoutNode&))]
	[Calls(Type = typeof(VisualElement), Member = "get_computedStyle", ReturnType = typeof(ComputedStyle&))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_alignSelf", ReturnType = typeof(Align))]
	[Calls(Type = typeof(LayoutNode), Member = "set_AlignSelf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutAlign)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private override void UnityEngine.UIElements.IStyle.set_alignSelf(StyleEnum<Align> value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(StyleColor)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private override void UnityEngine.UIElements.IStyle.set_backgroundColor(StyleColor value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(StyleBackground)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private override void UnityEngine.UIElements.IStyle.set_backgroundImage(StyleBackground value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(StyleBackgroundPosition)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private override void UnityEngine.UIElements.IStyle.set_backgroundPositionX(StyleBackgroundPosition value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(StyleBackgroundPosition)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private override void UnityEngine.UIElements.IStyle.set_backgroundPositionY(StyleBackgroundPosition value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StyleValueCollection), Member = "TryGetStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(StyleValue&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BackgroundRepeat), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BackgroundRepeat), typeof(BackgroundRepeat)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(StyleValueCollection), Member = "SetStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleValue)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InlineStyleAccess), Member = "ApplyStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleValue)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InlineStyleAccess), Member = "RemoveInlineStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 1)]
	private override void UnityEngine.UIElements.IStyle.set_backgroundRepeat(StyleBackgroundRepeat value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StyleBackgroundSize), Member = "get_value", ReturnType = typeof(BackgroundSize))]
	[Calls(Type = typeof(BackgroundSize), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BackgroundSize), typeof(BackgroundSize)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(InlineStyleAccess), Member = "ApplyStyleBackgroundSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleBackgroundSize)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InlineStyleAccess), Member = "RemoveInlineStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	private override void UnityEngine.UIElements.IStyle.set_backgroundSize(StyleBackgroundSize value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(StyleColor)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private override void UnityEngine.UIElements.IStyle.set_borderBottomColor(StyleColor value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(StyleLength)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private override void UnityEngine.UIElements.IStyle.set_borderBottomLeftRadius(StyleLength value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(StyleLength)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private override void UnityEngine.UIElements.IStyle.set_borderBottomRightRadius(StyleLength value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(StyleFloat)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "get_layoutNode", ReturnType = typeof(LayoutNode&))]
	[Calls(Type = typeof(VisualElement), Member = "get_computedStyle", ReturnType = typeof(ComputedStyle&))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_borderBottomWidth", ReturnType = typeof(float))]
	[Calls(Type = typeof(LayoutNode), Member = "set_BorderBottomWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private override void UnityEngine.UIElements.IStyle.set_borderBottomWidth(StyleFloat value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(StyleColor)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private override void UnityEngine.UIElements.IStyle.set_borderLeftColor(StyleColor value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(StyleFloat)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "get_layoutNode", ReturnType = typeof(LayoutNode&))]
	[Calls(Type = typeof(VisualElement), Member = "get_computedStyle", ReturnType = typeof(ComputedStyle&))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_borderLeftWidth", ReturnType = typeof(float))]
	[Calls(Type = typeof(LayoutNode), Member = "set_BorderLeftWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private override void UnityEngine.UIElements.IStyle.set_borderLeftWidth(StyleFloat value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(StyleColor)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private override void UnityEngine.UIElements.IStyle.set_borderRightColor(StyleColor value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(StyleFloat)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "get_layoutNode", ReturnType = typeof(LayoutNode&))]
	[Calls(Type = typeof(VisualElement), Member = "get_computedStyle", ReturnType = typeof(ComputedStyle&))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_borderRightWidth", ReturnType = typeof(float))]
	[Calls(Type = typeof(LayoutNode), Member = "set_BorderRightWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private override void UnityEngine.UIElements.IStyle.set_borderRightWidth(StyleFloat value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(StyleColor)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private override void UnityEngine.UIElements.IStyle.set_borderTopColor(StyleColor value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(StyleLength)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private override void UnityEngine.UIElements.IStyle.set_borderTopLeftRadius(StyleLength value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(StyleLength)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private override void UnityEngine.UIElements.IStyle.set_borderTopRightRadius(StyleLength value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(StyleFloat)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "get_layoutNode", ReturnType = typeof(LayoutNode&))]
	[Calls(Type = typeof(VisualElement), Member = "get_computedStyle", ReturnType = typeof(ComputedStyle&))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_borderTopWidth", ReturnType = typeof(float))]
	[Calls(Type = typeof(LayoutNode), Member = "set_BorderTopWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private override void UnityEngine.UIElements.IStyle.set_borderTopWidth(StyleFloat value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(StyleLength)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "get_layoutNode", ReturnType = typeof(LayoutNode&))]
	[Calls(Type = typeof(VisualElement), Member = "get_computedStyle", ReturnType = typeof(ComputedStyle&))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_bottom", ReturnType = typeof(Length))]
	[Calls(Type = typeof(StyleValueExtensions), Member = "ToLayoutValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Length)}, ReturnType = typeof(LayoutValue))]
	[Calls(Type = typeof(LayoutNode), Member = "set_Bottom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutValue)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private override void UnityEngine.UIElements.IStyle.set_bottom(StyleLength value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(StyleColor)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private override void UnityEngine.UIElements.IStyle.set_color(StyleColor value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StyleCursor), Member = "get_value", ReturnType = typeof(Cursor))]
	[Calls(Type = typeof(Cursor), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Cursor), typeof(Cursor)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(StyleCursor), Member = "set_value", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Cursor)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InlineStyleAccess), Member = "ApplyStyleCursor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleCursor)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InlineStyleAccess), Member = "RemoveInlineStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 3)]
	private override void UnityEngine.UIElements.IStyle.set_cursor(StyleCursor value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), "UnityEngine.UIElements.StyleEnum`1<T>"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "get_layoutNode", ReturnType = typeof(LayoutNode&))]
	[Calls(Type = typeof(VisualElement), Member = "get_computedStyle", ReturnType = typeof(ComputedStyle&))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_display", ReturnType = typeof(DisplayStyle))]
	[Calls(Type = typeof(LayoutNode), Member = "set_Display", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutDisplay)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private override void UnityEngine.UIElements.IStyle.set_display(StyleEnum<DisplayStyle> value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(StyleLength)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "get_layoutNode", ReturnType = typeof(LayoutNode&))]
	[Calls(Type = typeof(VisualElement), Member = "get_computedStyle", ReturnType = typeof(ComputedStyle&))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_flexBasis", ReturnType = typeof(Length))]
	[Calls(Type = typeof(StyleValueExtensions), Member = "ToLayoutValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Length)}, ReturnType = typeof(LayoutValue))]
	[Calls(Type = typeof(LayoutNode), Member = "set_FlexBasis", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutValue)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private override void UnityEngine.UIElements.IStyle.set_flexBasis(StyleLength value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), "UnityEngine.UIElements.StyleEnum`1<T>"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "get_layoutNode", ReturnType = typeof(LayoutNode&))]
	[Calls(Type = typeof(VisualElement), Member = "get_computedStyle", ReturnType = typeof(ComputedStyle&))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_flexDirection", ReturnType = typeof(FlexDirection))]
	[Calls(Type = typeof(LayoutNode), Member = "set_FlexDirection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutFlexDirection)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private override void UnityEngine.UIElements.IStyle.set_flexDirection(StyleEnum<FlexDirection> value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(StyleFloat)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "get_layoutNode", ReturnType = typeof(LayoutNode&))]
	[Calls(Type = typeof(VisualElement), Member = "get_computedStyle", ReturnType = typeof(ComputedStyle&))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_flexGrow", ReturnType = typeof(float))]
	[Calls(Type = typeof(LayoutNode), Member = "set_FlexGrow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private override void UnityEngine.UIElements.IStyle.set_flexGrow(StyleFloat value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(StyleFloat)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "get_layoutNode", ReturnType = typeof(LayoutNode&))]
	[Calls(Type = typeof(VisualElement), Member = "get_computedStyle", ReturnType = typeof(ComputedStyle&))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_flexShrink", ReturnType = typeof(float))]
	[Calls(Type = typeof(LayoutNode), Member = "set_FlexShrink", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private override void UnityEngine.UIElements.IStyle.set_flexShrink(StyleFloat value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), "UnityEngine.UIElements.StyleEnum`1<T>"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "get_layoutNode", ReturnType = typeof(LayoutNode&))]
	[Calls(Type = typeof(VisualElement), Member = "get_computedStyle", ReturnType = typeof(ComputedStyle&))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_flexWrap", ReturnType = typeof(Wrap))]
	[Calls(Type = typeof(LayoutNode), Member = "set_Wrap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutWrap)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private override void UnityEngine.UIElements.IStyle.set_flexWrap(StyleEnum<Wrap> value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(StyleLength)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private override void UnityEngine.UIElements.IStyle.set_fontSize(StyleLength value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(StyleLength)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "get_layoutNode", ReturnType = typeof(LayoutNode&))]
	[Calls(Type = typeof(VisualElement), Member = "get_computedStyle", ReturnType = typeof(ComputedStyle&))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_height", ReturnType = typeof(Length))]
	[Calls(Type = typeof(StyleValueExtensions), Member = "ToLayoutValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Length)}, ReturnType = typeof(LayoutValue))]
	[Calls(Type = typeof(LayoutNode), Member = "set_Height", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutValue)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private override void UnityEngine.UIElements.IStyle.set_height(StyleLength value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), "UnityEngine.UIElements.StyleEnum`1<T>"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "get_layoutNode", ReturnType = typeof(LayoutNode&))]
	[Calls(Type = typeof(VisualElement), Member = "get_computedStyle", ReturnType = typeof(ComputedStyle&))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_justifyContent", ReturnType = typeof(Justify))]
	[Calls(Type = typeof(LayoutNode), Member = "set_JustifyContent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutJustify)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private override void UnityEngine.UIElements.IStyle.set_justifyContent(StyleEnum<Justify> value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(StyleLength)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "get_layoutNode", ReturnType = typeof(LayoutNode&))]
	[Calls(Type = typeof(VisualElement), Member = "get_computedStyle", ReturnType = typeof(ComputedStyle&))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_left", ReturnType = typeof(Length))]
	[Calls(Type = typeof(StyleValueExtensions), Member = "ToLayoutValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Length)}, ReturnType = typeof(LayoutValue))]
	[Calls(Type = typeof(LayoutNode), Member = "set_Left", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutValue)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private override void UnityEngine.UIElements.IStyle.set_left(StyleLength value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(StyleLength)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private override void UnityEngine.UIElements.IStyle.set_letterSpacing(StyleLength value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(StyleLength)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "get_layoutNode", ReturnType = typeof(LayoutNode&))]
	[Calls(Type = typeof(VisualElement), Member = "get_computedStyle", ReturnType = typeof(ComputedStyle&))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_marginBottom", ReturnType = typeof(Length))]
	[Calls(Type = typeof(StyleValueExtensions), Member = "ToLayoutValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Length)}, ReturnType = typeof(LayoutValue))]
	[Calls(Type = typeof(LayoutNode), Member = "set_MarginBottom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutValue)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private override void UnityEngine.UIElements.IStyle.set_marginBottom(StyleLength value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(StyleLength)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "get_layoutNode", ReturnType = typeof(LayoutNode&))]
	[Calls(Type = typeof(VisualElement), Member = "get_computedStyle", ReturnType = typeof(ComputedStyle&))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_marginLeft", ReturnType = typeof(Length))]
	[Calls(Type = typeof(StyleValueExtensions), Member = "ToLayoutValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Length)}, ReturnType = typeof(LayoutValue))]
	[Calls(Type = typeof(LayoutNode), Member = "set_MarginLeft", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutValue)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private override void UnityEngine.UIElements.IStyle.set_marginLeft(StyleLength value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(StyleLength)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "get_layoutNode", ReturnType = typeof(LayoutNode&))]
	[Calls(Type = typeof(VisualElement), Member = "get_computedStyle", ReturnType = typeof(ComputedStyle&))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_marginRight", ReturnType = typeof(Length))]
	[Calls(Type = typeof(StyleValueExtensions), Member = "ToLayoutValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Length)}, ReturnType = typeof(LayoutValue))]
	[Calls(Type = typeof(LayoutNode), Member = "set_MarginRight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutValue)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private override void UnityEngine.UIElements.IStyle.set_marginRight(StyleLength value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(StyleLength)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "get_layoutNode", ReturnType = typeof(LayoutNode&))]
	[Calls(Type = typeof(VisualElement), Member = "get_computedStyle", ReturnType = typeof(ComputedStyle&))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_marginTop", ReturnType = typeof(Length))]
	[Calls(Type = typeof(StyleValueExtensions), Member = "ToLayoutValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Length)}, ReturnType = typeof(LayoutValue))]
	[Calls(Type = typeof(LayoutNode), Member = "set_MarginTop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutValue)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private override void UnityEngine.UIElements.IStyle.set_marginTop(StyleLength value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(StyleLength)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "get_layoutNode", ReturnType = typeof(LayoutNode&))]
	[Calls(Type = typeof(VisualElement), Member = "get_computedStyle", ReturnType = typeof(ComputedStyle&))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_maxHeight", ReturnType = typeof(Length))]
	[Calls(Type = typeof(StyleValueExtensions), Member = "ToLayoutValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Length)}, ReturnType = typeof(LayoutValue))]
	[Calls(Type = typeof(LayoutNode), Member = "set_MaxHeight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutValue)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private override void UnityEngine.UIElements.IStyle.set_maxHeight(StyleLength value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(StyleLength)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "get_layoutNode", ReturnType = typeof(LayoutNode&))]
	[Calls(Type = typeof(VisualElement), Member = "get_computedStyle", ReturnType = typeof(ComputedStyle&))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_maxWidth", ReturnType = typeof(Length))]
	[Calls(Type = typeof(StyleValueExtensions), Member = "ToLayoutValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Length)}, ReturnType = typeof(LayoutValue))]
	[Calls(Type = typeof(LayoutNode), Member = "set_MaxWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutValue)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private override void UnityEngine.UIElements.IStyle.set_maxWidth(StyleLength value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(StyleLength)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "get_layoutNode", ReturnType = typeof(LayoutNode&))]
	[Calls(Type = typeof(VisualElement), Member = "get_computedStyle", ReturnType = typeof(ComputedStyle&))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_minHeight", ReturnType = typeof(Length))]
	[Calls(Type = typeof(StyleValueExtensions), Member = "ToLayoutValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Length)}, ReturnType = typeof(LayoutValue))]
	[Calls(Type = typeof(LayoutNode), Member = "set_MinHeight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutValue)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private override void UnityEngine.UIElements.IStyle.set_minHeight(StyleLength value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(StyleLength)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "get_layoutNode", ReturnType = typeof(LayoutNode&))]
	[Calls(Type = typeof(VisualElement), Member = "get_computedStyle", ReturnType = typeof(ComputedStyle&))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_minWidth", ReturnType = typeof(Length))]
	[Calls(Type = typeof(StyleValueExtensions), Member = "ToLayoutValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Length)}, ReturnType = typeof(LayoutValue))]
	[Calls(Type = typeof(LayoutNode), Member = "set_MinWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutValue)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private override void UnityEngine.UIElements.IStyle.set_minWidth(StyleLength value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(StyleFloat)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private override void UnityEngine.UIElements.IStyle.set_opacity(StyleFloat value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), "UnityEngine.UIElements.StyleEnum`1<T>"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "get_layoutNode", ReturnType = typeof(LayoutNode&))]
	[Calls(Type = typeof(VisualElement), Member = "get_computedStyle", ReturnType = typeof(ComputedStyle&))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_overflow", ReturnType = typeof(OverflowInternal))]
	[Calls(Type = typeof(LayoutNode), Member = "set_Overflow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutOverflow)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	private override void UnityEngine.UIElements.IStyle.set_overflow(StyleEnum<Overflow> value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(StyleLength)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "get_layoutNode", ReturnType = typeof(LayoutNode&))]
	[Calls(Type = typeof(VisualElement), Member = "get_computedStyle", ReturnType = typeof(ComputedStyle&))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_paddingBottom", ReturnType = typeof(Length))]
	[Calls(Type = typeof(StyleValueExtensions), Member = "ToLayoutValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Length)}, ReturnType = typeof(LayoutValue))]
	[Calls(Type = typeof(LayoutNode), Member = "set_PaddingBottom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutValue)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private override void UnityEngine.UIElements.IStyle.set_paddingBottom(StyleLength value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(StyleLength)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "get_layoutNode", ReturnType = typeof(LayoutNode&))]
	[Calls(Type = typeof(VisualElement), Member = "get_computedStyle", ReturnType = typeof(ComputedStyle&))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_paddingLeft", ReturnType = typeof(Length))]
	[Calls(Type = typeof(StyleValueExtensions), Member = "ToLayoutValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Length)}, ReturnType = typeof(LayoutValue))]
	[Calls(Type = typeof(LayoutNode), Member = "set_PaddingLeft", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutValue)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private override void UnityEngine.UIElements.IStyle.set_paddingLeft(StyleLength value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(StyleLength)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "get_layoutNode", ReturnType = typeof(LayoutNode&))]
	[Calls(Type = typeof(VisualElement), Member = "get_computedStyle", ReturnType = typeof(ComputedStyle&))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_paddingRight", ReturnType = typeof(Length))]
	[Calls(Type = typeof(StyleValueExtensions), Member = "ToLayoutValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Length)}, ReturnType = typeof(LayoutValue))]
	[Calls(Type = typeof(LayoutNode), Member = "set_PaddingRight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutValue)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private override void UnityEngine.UIElements.IStyle.set_paddingRight(StyleLength value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(StyleLength)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "get_layoutNode", ReturnType = typeof(LayoutNode&))]
	[Calls(Type = typeof(VisualElement), Member = "get_computedStyle", ReturnType = typeof(ComputedStyle&))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_paddingTop", ReturnType = typeof(Length))]
	[Calls(Type = typeof(StyleValueExtensions), Member = "ToLayoutValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Length)}, ReturnType = typeof(LayoutValue))]
	[Calls(Type = typeof(LayoutNode), Member = "set_PaddingTop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutValue)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private override void UnityEngine.UIElements.IStyle.set_paddingTop(StyleLength value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), "UnityEngine.UIElements.StyleEnum`1<T>"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "get_layoutNode", ReturnType = typeof(LayoutNode&))]
	[Calls(Type = typeof(VisualElement), Member = "get_computedStyle", ReturnType = typeof(ComputedStyle&))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_position", ReturnType = typeof(Position))]
	[Calls(Type = typeof(LayoutNode), Member = "set_PositionType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutPositionType)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private override void UnityEngine.UIElements.IStyle.set_position(StyleEnum<Position> value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(StyleLength)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "get_layoutNode", ReturnType = typeof(LayoutNode&))]
	[Calls(Type = typeof(VisualElement), Member = "get_computedStyle", ReturnType = typeof(ComputedStyle&))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_right", ReturnType = typeof(Length))]
	[Calls(Type = typeof(StyleValueExtensions), Member = "ToLayoutValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Length)}, ReturnType = typeof(LayoutValue))]
	[Calls(Type = typeof(LayoutNode), Member = "set_Right", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutValue)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private override void UnityEngine.UIElements.IStyle.set_right(StyleLength value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StyleRotate), Member = "get_value", ReturnType = typeof(Rotate))]
	[Calls(Type = typeof(Rotate), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rotate), typeof(Rotate)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(InlineStyleAccess), Member = "ApplyStyleRotate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleRotate)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InlineStyleAccess), Member = "RemoveInlineStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	private override void UnityEngine.UIElements.IStyle.set_rotate(StyleRotate value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StyleScale), Member = "get_value", ReturnType = typeof(Scale))]
	[Calls(Type = typeof(InlineStyleAccess), Member = "ApplyStyleScale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleScale)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InlineStyleAccess), Member = "RemoveInlineStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 1)]
	private override void UnityEngine.UIElements.IStyle.set_scale(StyleScale value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), "UnityEngine.UIElements.StyleEnum`1<T>"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private override void UnityEngine.UIElements.IStyle.set_textOverflow(StyleEnum<TextOverflow> value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StyleTextShadow), Member = "get_value", ReturnType = typeof(TextShadow))]
	[Calls(Type = typeof(TextShadow), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextShadow), typeof(TextShadow)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(StyleTextShadow), Member = "set_value", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextShadow)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InlineStyleAccess), Member = "ApplyStyleTextShadow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleTextShadow)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InlineStyleAccess), Member = "RemoveInlineStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 1)]
	private override void UnityEngine.UIElements.IStyle.set_textShadow(StyleTextShadow value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(StyleLength)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "get_layoutNode", ReturnType = typeof(LayoutNode&))]
	[Calls(Type = typeof(VisualElement), Member = "get_computedStyle", ReturnType = typeof(ComputedStyle&))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_top", ReturnType = typeof(Length))]
	[Calls(Type = typeof(StyleValueExtensions), Member = "ToLayoutValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Length)}, ReturnType = typeof(LayoutValue))]
	[Calls(Type = typeof(LayoutNode), Member = "set_Top", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutValue)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private override void UnityEngine.UIElements.IStyle.set_top(StyleLength value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StyleTransformOrigin), Member = "get_value", ReturnType = typeof(TransformOrigin))]
	[Calls(Type = typeof(TransformOrigin), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TransformOrigin), typeof(TransformOrigin)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(InlineStyleAccess), Member = "ApplyStyleTransformOrigin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleTransformOrigin)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InlineStyleAccess), Member = "RemoveInlineStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	private override void UnityEngine.UIElements.IStyle.set_transformOrigin(StyleTransformOrigin value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeValue)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(UnityEngine.UIElements.StyleList`1<UnityEngine.UIElements.TimeValue>)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private override void UnityEngine.UIElements.IStyle.set_transitionDelay(StyleList<TimeValue> value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeValue)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(UnityEngine.UIElements.StyleList`1<UnityEngine.UIElements.TimeValue>)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private override void UnityEngine.UIElements.IStyle.set_transitionDuration(StyleList<TimeValue> value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyName)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(UnityEngine.UIElements.StyleList`1<UnityEngine.UIElements.StylePropertyName>)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private override void UnityEngine.UIElements.IStyle.set_transitionProperty(StyleList<StylePropertyName> value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), "UnityEngine.UIElements.StyleList`1<T>"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private override void UnityEngine.UIElements.IStyle.set_transitionTimingFunction(StyleList<EasingFunction> value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StyleTranslate), Member = "get_value", ReturnType = typeof(Translate))]
	[Calls(Type = typeof(Translate), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Translate), typeof(Translate)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(InlineStyleAccess), Member = "ApplyStyleTranslate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleTranslate)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InlineStyleAccess), Member = "RemoveInlineStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	private override void UnityEngine.UIElements.IStyle.set_translate(StyleTranslate value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(StyleColor)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private override void UnityEngine.UIElements.IStyle.set_unityBackgroundImageTintColor(StyleColor value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), "UnityEngine.UIElements.StyleEnum`1<T>"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private override void UnityEngine.UIElements.IStyle.set_unityEditorTextRenderingMode(StyleEnum<EditorTextRenderingMode> value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(StyleFont)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private override void UnityEngine.UIElements.IStyle.set_unityFont(StyleFont value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(StyleFontDefinition)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private override void UnityEngine.UIElements.IStyle.set_unityFontDefinition(StyleFontDefinition value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), "UnityEngine.UIElements.StyleEnum`1<T>"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private override void UnityEngine.UIElements.IStyle.set_unityFontStyleAndWeight(StyleEnum<FontStyle> value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), "UnityEngine.UIElements.StyleEnum`1<T>"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private override void UnityEngine.UIElements.IStyle.set_unityOverflowClipBox(StyleEnum<OverflowClipBox> value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(StyleLength)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private override void UnityEngine.UIElements.IStyle.set_unityParagraphSpacing(StyleLength value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(StyleInt)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private override void UnityEngine.UIElements.IStyle.set_unitySliceBottom(StyleInt value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(StyleInt)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private override void UnityEngine.UIElements.IStyle.set_unitySliceLeft(StyleInt value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(StyleInt)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private override void UnityEngine.UIElements.IStyle.set_unitySliceRight(StyleInt value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(StyleFloat)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private override void UnityEngine.UIElements.IStyle.set_unitySliceScale(StyleFloat value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(StyleInt)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private override void UnityEngine.UIElements.IStyle.set_unitySliceTop(StyleInt value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), "UnityEngine.UIElements.StyleEnum`1<T>"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private override void UnityEngine.UIElements.IStyle.set_unitySliceType(StyleEnum<SliceType> value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), "UnityEngine.UIElements.StyleEnum`1<T>"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private override void UnityEngine.UIElements.IStyle.set_unityTextAlign(StyleEnum<TextAnchor> value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), "UnityEngine.UIElements.StyleEnum`1<T>"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private override void UnityEngine.UIElements.IStyle.set_unityTextGenerator(StyleEnum<TextGeneratorType> value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(StyleColor)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private override void UnityEngine.UIElements.IStyle.set_unityTextOutlineColor(StyleColor value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(StyleFloat)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private override void UnityEngine.UIElements.IStyle.set_unityTextOutlineWidth(StyleFloat value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), "UnityEngine.UIElements.StyleEnum`1<T>"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private override void UnityEngine.UIElements.IStyle.set_unityTextOverflowPosition(StyleEnum<TextOverflowPosition> value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), "UnityEngine.UIElements.StyleEnum`1<T>"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private override void UnityEngine.UIElements.IStyle.set_visibility(StyleEnum<Visibility> value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), "UnityEngine.UIElements.StyleEnum`1<T>"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private override void UnityEngine.UIElements.IStyle.set_whiteSpace(StyleEnum<WhiteSpace> value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(StyleLength)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "get_layoutNode", ReturnType = typeof(LayoutNode&))]
	[Calls(Type = typeof(VisualElement), Member = "get_computedStyle", ReturnType = typeof(ComputedStyle&))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_width", ReturnType = typeof(Length))]
	[Calls(Type = typeof(StyleValueExtensions), Member = "ToLayoutValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Length)}, ReturnType = typeof(LayoutValue))]
	[Calls(Type = typeof(LayoutNode), Member = "set_Width", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutValue)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private override void UnityEngine.UIElements.IStyle.set_width(StyleLength value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(StyleLength)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private override void UnityEngine.UIElements.IStyle.set_wordSpacing(StyleLength value) { }

}

