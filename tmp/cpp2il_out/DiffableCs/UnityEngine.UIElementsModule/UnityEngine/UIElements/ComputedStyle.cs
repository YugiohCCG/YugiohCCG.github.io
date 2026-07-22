namespace UnityEngine.UIElements;

[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
internal struct ComputedStyle
{
	public StyleDataRef<InheritedData> inheritedData; //Field offset: 0x0
	public StyleDataRef<LayoutData> layoutData; //Field offset: 0x8
	public StyleDataRef<RareData> rareData; //Field offset: 0x10
	public StyleDataRef<TransformData> transformData; //Field offset: 0x18
	public StyleDataRef<TransitionData> transitionData; //Field offset: 0x20
	public StyleDataRef<VisualData> visualData; //Field offset: 0x28
	public Dictionary<String, StylePropertyValue> customProperties; //Field offset: 0x30
	public long matchingRulesHash; //Field offset: 0x38
	public float dpiScaling; //Field offset: 0x40
	public ComputedTransitionProperty[] computedTransitions; //Field offset: 0x48

	public Align alignContent
	{
		[CalledBy(Type = typeof(ComputedStyle), Member = "CompareChanges", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&), typeof(ComputedStyle&)}, ReturnType = typeof(VersionChangeType))]
		[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_alignContent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityEngine.UIElements.StyleEnum`1<UnityEngine.UIElements.Align>)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ResolvedStyleAccess), Member = "get_alignContent", ReturnType = typeof(Align))]
		[CalledBy(Type = typeof(LayoutNode), Member = "CopyFromComputedStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle)}, ReturnType = typeof(void))]
		[CallerCount(Count = 5)]
		[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
		 get { } //Length: 61
	}

	public Align alignItems
	{
		[CalledBy(Type = typeof(ComputedStyle), Member = "CompareChanges", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&), typeof(ComputedStyle&)}, ReturnType = typeof(VersionChangeType))]
		[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_alignItems", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityEngine.UIElements.StyleEnum`1<UnityEngine.UIElements.Align>)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ResolvedStyleAccess), Member = "get_alignItems", ReturnType = typeof(Align))]
		[CalledBy(Type = typeof(LayoutNode), Member = "CopyFromComputedStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle)}, ReturnType = typeof(void))]
		[CallerCount(Count = 5)]
		[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
		 get { } //Length: 62
	}

	public Align alignSelf
	{
		[CalledBy(Type = typeof(ComputedStyle), Member = "CompareChanges", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&), typeof(ComputedStyle&)}, ReturnType = typeof(VersionChangeType))]
		[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_alignSelf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityEngine.UIElements.StyleEnum`1<UnityEngine.UIElements.Align>)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ResolvedStyleAccess), Member = "get_alignSelf", ReturnType = typeof(Align))]
		[CalledBy(Type = typeof(LayoutNode), Member = "CopyFromComputedStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle)}, ReturnType = typeof(void))]
		[CallerCount(Count = 5)]
		[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
		 get { } //Length: 62
	}

	public Color backgroundColor
	{
		[CalledBy(Type = typeof(ResolvedStyleAccess), Member = "get_backgroundColor", ReturnType = typeof(Color))]
		[CalledBy(Type = typeof(DefaultElementBuilder), Member = "DrawVisualElementBackground", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshGenerationContext)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
		 get { } //Length: 80
	}

	public Background backgroundImage
	{
		[CalledBy(Type = typeof(UIRUtility), Member = "IsVectorImageBackground", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(ResolvedStyleAccess), Member = "get_backgroundImage", ReturnType = typeof(Background))]
		[CalledBy(Type = typeof(DefaultElementBuilder), Member = "DrawVisualElementBackground", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshGenerationContext)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
		 get { } //Length: 89
	}

	public BackgroundPosition backgroundPositionX
	{
		[CalledBy(Type = typeof(ResolvedStyleAccess), Member = "get_backgroundPositionX", ReturnType = typeof(BackgroundPosition))]
		[CalledBy(Type = typeof(DefaultElementBuilder), Member = "DrawVisualElementBackground", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshGenerationContext)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
		 get { } //Length: 89
	}

	public BackgroundPosition backgroundPositionY
	{
		[CalledBy(Type = typeof(ResolvedStyleAccess), Member = "get_backgroundPositionY", ReturnType = typeof(BackgroundPosition))]
		[CalledBy(Type = typeof(DefaultElementBuilder), Member = "DrawVisualElementBackground", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshGenerationContext)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
		 get { } //Length: 89
	}

	public BackgroundRepeat backgroundRepeat
	{
		[CalledBy(Type = typeof(ComputedStyle), Member = "CompareChanges", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&), typeof(ComputedStyle&)}, ReturnType = typeof(VersionChangeType))]
		[CalledBy(Type = typeof(ResolvedStyleAccess), Member = "get_backgroundRepeat", ReturnType = typeof(BackgroundRepeat))]
		[CalledBy(Type = typeof(DefaultElementBuilder), Member = "DrawVisualElementBackground", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshGenerationContext)}, ReturnType = typeof(void))]
		[CallerCount(Count = 5)]
		[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
		 get { } //Length: 63
	}

	public BackgroundSize backgroundSize
	{
		[CalledBy(Type = typeof(ResolvedStyleAccess), Member = "get_backgroundSize", ReturnType = typeof(BackgroundSize))]
		[CalledBy(Type = typeof(DefaultElementBuilder), Member = "DrawVisualElementBackground", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshGenerationContext)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
		 get { } //Length: 87
	}

	public Color borderBottomColor
	{
		[CalledBy(Type = typeof(ResolvedStyleAccess), Member = "get_borderBottomColor", ReturnType = typeof(Color))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
		 get { } //Length: 81
	}

	public Length borderBottomLeftRadius
	{
		[CalledBy(Type = typeof(ResolvedStyleAccess), Member = "get_borderBottomLeftRadius", ReturnType = typeof(float))]
		[CalledBy(Type = typeof(MeshGenerator), Member = "GetVisualElementRadii", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(Vector2&), typeof(Vector2&), typeof(Vector2&), typeof(Vector2&)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
		 get { } //Length: 63
	}

	public Length borderBottomRightRadius
	{
		[CalledBy(Type = typeof(ResolvedStyleAccess), Member = "get_borderBottomRightRadius", ReturnType = typeof(float))]
		[CalledBy(Type = typeof(MeshGenerator), Member = "GetVisualElementRadii", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(Vector2&), typeof(Vector2&), typeof(Vector2&), typeof(Vector2&)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
		 get { } //Length: 63
	}

	public float borderBottomWidth
	{
		[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_borderBottomWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleFloat)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(LayoutNode), Member = "CopyFromComputedStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
		 get { } //Length: 64
	}

	public Color borderLeftColor
	{
		[CalledBy(Type = typeof(ResolvedStyleAccess), Member = "get_borderLeftColor", ReturnType = typeof(Color))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
		 get { } //Length: 84
	}

	public float borderLeftWidth
	{
		[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_borderLeftWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleFloat)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(LayoutNode), Member = "CopyFromComputedStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
		 get { } //Length: 64
	}

	public Color borderRightColor
	{
		[CalledBy(Type = typeof(ResolvedStyleAccess), Member = "get_borderRightColor", ReturnType = typeof(Color))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
		 get { } //Length: 84
	}

	public float borderRightWidth
	{
		[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_borderRightWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleFloat)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(LayoutNode), Member = "CopyFromComputedStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
		 get { } //Length: 64
	}

	public Color borderTopColor
	{
		[CalledBy(Type = typeof(ResolvedStyleAccess), Member = "get_borderTopColor", ReturnType = typeof(Color))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
		 get { } //Length: 84
	}

	public Length borderTopLeftRadius
	{
		[CalledBy(Type = typeof(ResolvedStyleAccess), Member = "get_borderTopLeftRadius", ReturnType = typeof(float))]
		[CalledBy(Type = typeof(MeshGenerator), Member = "GetVisualElementRadii", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(Vector2&), typeof(Vector2&), typeof(Vector2&), typeof(Vector2&)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
		 get { } //Length: 66
	}

	public Length borderTopRightRadius
	{
		[CalledBy(Type = typeof(ComputedStyle), Member = "CompareChanges", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&), typeof(ComputedStyle&)}, ReturnType = typeof(VersionChangeType))]
		[CalledBy(Type = typeof(ResolvedStyleAccess), Member = "get_borderTopRightRadius", ReturnType = typeof(float))]
		[CalledBy(Type = typeof(MeshGenerator), Member = "GetVisualElementRadii", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(Vector2&), typeof(Vector2&), typeof(Vector2&), typeof(Vector2&)}, ReturnType = typeof(void))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
		 get { } //Length: 66
	}

	public float borderTopWidth
	{
		[CalledBy(Type = typeof(ComputedStyle), Member = "CompareChanges", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&), typeof(ComputedStyle&)}, ReturnType = typeof(VersionChangeType))]
		[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_borderTopWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleFloat)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(LayoutNode), Member = "CopyFromComputedStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle)}, ReturnType = typeof(void))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
		 get { } //Length: 64
	}

	public Length bottom
	{
		[CalledBy(Type = typeof(ComputedStyle), Member = "CompareChanges", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&), typeof(ComputedStyle&)}, ReturnType = typeof(VersionChangeType))]
		[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_bottom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleLength)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(LayoutNode), Member = "CopyFromComputedStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle)}, ReturnType = typeof(void))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
		 get { } //Length: 63
	}

	public Color color
	{
		[CalledBy(Type = typeof(ResolvedStyleAccess), Member = "get_color", ReturnType = typeof(Color))]
		[CalledBy(Type = typeof(UITKTextHandle), Member = "ConvertUssToNativeTextGenerationSettings", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(UITKTextHandle), Member = "ConvertUssToTextGenerationSettings", ReturnType = typeof(bool))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
		 get { } //Length: 79
	}

	public Cursor cursor
	{
		[CalledBy(Type = typeof(VisualElement), Member = "SetComputedStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(VisualElement), Member = "UpdateCursorStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ATGTextEventHandler), Member = "HyperlinkOnPointerMove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerMoveEvent)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TextEventHandler), Member = "ATagOnPointerMove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerMoveEvent)}, ReturnType = typeof(void))]
		[CallerCount(Count = 5)]
		[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
		 get { } //Length: 90
	}

	public int customPropertiesCount
	{
		[CalledBy(Type = typeof(VisualTreeStyleUpdaterTraversal), Member = "TraverseRecursive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(int)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Dictionary`2), Member = "get_Count", ReturnType = typeof(int))]
		 get { } //Length: 71
	}

	public DisplayStyle display
	{
		[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_display", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityEngine.UIElements.StyleEnum`1<UnityEngine.UIElements.DisplayStyle>)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ResolvedStyleAccess), Member = "get_display", ReturnType = typeof(DisplayStyle))]
		[CalledBy(Type = typeof(LayoutNode), Member = "CopyFromComputedStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
		 get { } //Length: 62
	}

	public Length flexBasis
	{
		[CalledBy(Type = typeof(ComputedStyle), Member = "CompareChanges", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&), typeof(ComputedStyle&)}, ReturnType = typeof(VersionChangeType))]
		[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_flexBasis", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleLength)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(LayoutNode), Member = "CopyFromComputedStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle)}, ReturnType = typeof(void))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
		 get { } //Length: 63
	}

	public FlexDirection flexDirection
	{
		[CalledBy(Type = typeof(ComputedStyle), Member = "CompareChanges", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&), typeof(ComputedStyle&)}, ReturnType = typeof(VersionChangeType))]
		[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_flexDirection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityEngine.UIElements.StyleEnum`1<UnityEngine.UIElements.FlexDirection>)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ResolvedStyleAccess), Member = "get_flexDirection", ReturnType = typeof(FlexDirection))]
		[CalledBy(Type = typeof(LayoutNode), Member = "CopyFromComputedStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle)}, ReturnType = typeof(void))]
		[CallerCount(Count = 5)]
		[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
		 get { } //Length: 62
	}

	public float flexGrow
	{
		[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_flexGrow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleFloat)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ResolvedStyleAccess), Member = "get_flexGrow", ReturnType = typeof(float))]
		[CalledBy(Type = typeof(LayoutNode), Member = "CopyFromComputedStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
		 get { } //Length: 64
	}

	public float flexShrink
	{
		[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_flexShrink", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleFloat)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ResolvedStyleAccess), Member = "get_flexShrink", ReturnType = typeof(float))]
		[CalledBy(Type = typeof(LayoutNode), Member = "CopyFromComputedStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
		 get { } //Length: 64
	}

	public Wrap flexWrap
	{
		[CalledBy(Type = typeof(ComputedStyle), Member = "CompareChanges", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&), typeof(ComputedStyle&)}, ReturnType = typeof(VersionChangeType))]
		[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_flexWrap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityEngine.UIElements.StyleEnum`1<UnityEngine.UIElements.Wrap>)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ResolvedStyleAccess), Member = "get_flexWrap", ReturnType = typeof(Wrap))]
		[CalledBy(Type = typeof(LayoutNode), Member = "CopyFromComputedStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle)}, ReturnType = typeof(void))]
		[CallerCount(Count = 5)]
		[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
		 get { } //Length: 62
	}

	public Length fontSize
	{
		[CalledBy(Type = typeof(GenericDropdownMenu), Member = "DropDown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), typeof(VisualElement), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ComputedStyle), Member = "ApplyUnsetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(ComputedStyle&)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ComputedStyle), Member = "CompareChanges", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&), typeof(ComputedStyle&)}, ReturnType = typeof(VersionChangeType))]
		[CalledBy(Type = typeof(ResolvedStyleAccess), Member = "get_fontSize", ReturnType = typeof(float))]
		[CalledBy(Type = typeof(UITKTextHandle), Member = "ConvertUssToNativeTextGenerationSettings", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(UITKTextHandle), Member = "ConvertUssToTextGenerationSettings", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(UITKTextHandle), Member = "GetVertexPadding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FontAsset)}, ReturnType = typeof(float))]
		[CalledBy(Type = typeof(TextUtilities), Member = "GetTextCoreSettingsForElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(bool)}, ReturnType = typeof(TextCoreSettings))]
		[CallerCount(Count = 9)]
		[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
		 get { } //Length: 62
	}

	public bool hasTransition
	{
		[CalledBy(Type = typeof(InlineStyleAccess), Member = "ApplyStyleTextShadow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleTextShadow)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InlineStyleAccess), Member = "ApplyStyleTransformOrigin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleTransformOrigin)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InlineStyleAccess), Member = "ApplyStyleTranslate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleTranslate)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InlineStyleAccess), Member = "ApplyStyleScale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleScale)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InlineStyleAccess), Member = "ApplyStyleRotate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleRotate)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InlineStyleAccess), Member = "ApplyStyleBackgroundSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleBackgroundSize)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InlineStyleAccess), Member = "ApplyStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleValue)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InlineStyleAccess), Member = "ApplyFromComputedStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(ComputedStyle&)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(VisualTreeStyleUpdaterTraversal), Member = "TraverseRecursive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(int)}, ReturnType = typeof(void))]
		[CallerCount(Count = 9)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 18
	}

	public Length height
	{
		[CalledBy(Type = typeof(ComputedStyle), Member = "CompareChanges", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&), typeof(ComputedStyle&)}, ReturnType = typeof(VersionChangeType))]
		[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_height", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleLength)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TextElement), Member = "UnityEngine.UIElements.INotifyValueChanged<System.String>.SetValueWithoutNotify", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(LayoutNode), Member = "CopyFromComputedStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle)}, ReturnType = typeof(void))]
		[CallerCount(Count = 6)]
		[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
		 get { } //Length: 63
	}

	public Justify justifyContent
	{
		[CalledBy(Type = typeof(ComputedStyle), Member = "CompareChanges", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&), typeof(ComputedStyle&)}, ReturnType = typeof(VersionChangeType))]
		[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_justifyContent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityEngine.UIElements.StyleEnum`1<UnityEngine.UIElements.Justify>)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ResolvedStyleAccess), Member = "get_justifyContent", ReturnType = typeof(Justify))]
		[CalledBy(Type = typeof(LayoutNode), Member = "CopyFromComputedStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle)}, ReturnType = typeof(void))]
		[CallerCount(Count = 5)]
		[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
		 get { } //Length: 62
	}

	public Length left
	{
		[CalledBy(Type = typeof(ComputedStyle), Member = "CompareChanges", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&), typeof(ComputedStyle&)}, ReturnType = typeof(VersionChangeType))]
		[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_left", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleLength)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(LayoutNode), Member = "CopyFromComputedStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle)}, ReturnType = typeof(void))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
		 get { } //Length: 63
	}

	public Length letterSpacing
	{
		[CalledBy(Type = typeof(ComputedStyle), Member = "ApplyUnsetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(ComputedStyle&)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ComputedStyle), Member = "CompareChanges", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&), typeof(ComputedStyle&)}, ReturnType = typeof(VersionChangeType))]
		[CalledBy(Type = typeof(ResolvedStyleAccess), Member = "get_letterSpacing", ReturnType = typeof(float))]
		[CalledBy(Type = typeof(UITKTextHandle), Member = "ConvertUssToNativeTextGenerationSettings", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(UITKTextHandle), Member = "ConvertUssToTextGenerationSettings", ReturnType = typeof(bool))]
		[CallerCount(Count = 6)]
		[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
		 get { } //Length: 62
	}

	public Length marginBottom
	{
		[CalledBy(Type = typeof(ComputedStyle), Member = "CompareChanges", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&), typeof(ComputedStyle&)}, ReturnType = typeof(VersionChangeType))]
		[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_marginBottom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleLength)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(LayoutNode), Member = "CopyFromComputedStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle)}, ReturnType = typeof(void))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
		 get { } //Length: 63
	}

	public Length marginLeft
	{
		[CalledBy(Type = typeof(ComputedStyle), Member = "CompareChanges", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&), typeof(ComputedStyle&)}, ReturnType = typeof(VersionChangeType))]
		[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_marginLeft", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleLength)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(LayoutNode), Member = "CopyFromComputedStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle)}, ReturnType = typeof(void))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
		 get { } //Length: 63
	}

	public Length marginRight
	{
		[CalledBy(Type = typeof(ComputedStyle), Member = "CompareChanges", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&), typeof(ComputedStyle&)}, ReturnType = typeof(VersionChangeType))]
		[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_marginRight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleLength)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(LayoutNode), Member = "CopyFromComputedStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle)}, ReturnType = typeof(void))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
		 get { } //Length: 63
	}

	public Length marginTop
	{
		[CalledBy(Type = typeof(ComputedStyle), Member = "CompareChanges", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&), typeof(ComputedStyle&)}, ReturnType = typeof(VersionChangeType))]
		[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_marginTop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleLength)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(LayoutNode), Member = "CopyFromComputedStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle)}, ReturnType = typeof(void))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
		 get { } //Length: 63
	}

	public Length maxHeight
	{
		[CalledBy(Type = typeof(ComputedStyle), Member = "CompareChanges", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&), typeof(ComputedStyle&)}, ReturnType = typeof(VersionChangeType))]
		[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_maxHeight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleLength)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ResolvedStyleAccess), Member = "get_maxHeight", ReturnType = typeof(StyleFloat))]
		[CalledBy(Type = typeof(LayoutNode), Member = "CopyFromComputedStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle)}, ReturnType = typeof(void))]
		[CallerCount(Count = 5)]
		[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
		 get { } //Length: 63
	}

	public Length maxWidth
	{
		[CalledBy(Type = typeof(ComputedStyle), Member = "CompareChanges", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&), typeof(ComputedStyle&)}, ReturnType = typeof(VersionChangeType))]
		[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_maxWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleLength)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ResolvedStyleAccess), Member = "get_maxWidth", ReturnType = typeof(StyleFloat))]
		[CalledBy(Type = typeof(LayoutNode), Member = "CopyFromComputedStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle)}, ReturnType = typeof(void))]
		[CallerCount(Count = 5)]
		[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
		 get { } //Length: 63
	}

	public Length minHeight
	{
		[CalledBy(Type = typeof(ComputedStyle), Member = "CompareChanges", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&), typeof(ComputedStyle&)}, ReturnType = typeof(VersionChangeType))]
		[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_minHeight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleLength)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ResolvedStyleAccess), Member = "get_minHeight", ReturnType = typeof(StyleFloat))]
		[CalledBy(Type = typeof(LayoutNode), Member = "CopyFromComputedStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle)}, ReturnType = typeof(void))]
		[CallerCount(Count = 5)]
		[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
		 get { } //Length: 66
	}

	public Length minWidth
	{
		[CalledBy(Type = typeof(ComputedStyle), Member = "CompareChanges", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&), typeof(ComputedStyle&)}, ReturnType = typeof(VersionChangeType))]
		[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_minWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleLength)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ResolvedStyleAccess), Member = "get_minWidth", ReturnType = typeof(StyleFloat))]
		[CalledBy(Type = typeof(LayoutNode), Member = "CopyFromComputedStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle)}, ReturnType = typeof(void))]
		[CallerCount(Count = 5)]
		[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
		 get { } //Length: 66
	}

	public float opacity
	{
		[CalledBy(Type = typeof(ResolvedStyleAccess), Member = "get_opacity", ReturnType = typeof(float))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
		 get { } //Length: 67
	}

	public OverflowInternal overflow
	{
		[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_overflow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityEngine.UIElements.StyleEnum`1<UnityEngine.UIElements.Overflow>)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(VisualElement), Member = "UpdateBoundingBox", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(VisualElement), Member = "UpdateLocalBoundsAndPickingBounds3D", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(VisualElement), Member = "UpdateWorldClip", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(VisualElement), Member = "ShouldClip", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(UITKTextHandle), Member = "ConvertUssToNativeTextGenerationSettings", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(UITKTextHandle), Member = "GetTextOverflowMode", ReturnType = "UnityEngine.TextCore.Text.TextOverflowMode")]
		[CalledBy(Type = typeof(UITKTextHandle), Member = "ConvertUssToTextGenerationSettings", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(TextElement), Member = "OnGenerateTextOver", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshGenerationContext)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TextElement), Member = "OnGenerateTextOverNative", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshGenerationContext)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TextElement), Member = "UpdateVisibleText", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TextElement), Member = "ShouldElide", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(LayoutNode), Member = "CopyFromComputedStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle)}, ReturnType = typeof(void))]
		[CallerCount(Count = 13)]
		[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
		 get { } //Length: 65
	}

	public Length paddingBottom
	{
		[CalledBy(Type = typeof(ComputedStyle), Member = "CompareChanges", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&), typeof(ComputedStyle&)}, ReturnType = typeof(VersionChangeType))]
		[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_paddingBottom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleLength)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(LayoutNode), Member = "CopyFromComputedStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle)}, ReturnType = typeof(void))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
		 get { } //Length: 66
	}

	public Length paddingLeft
	{
		[CalledBy(Type = typeof(ComputedStyle), Member = "CompareChanges", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&), typeof(ComputedStyle&)}, ReturnType = typeof(VersionChangeType))]
		[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_paddingLeft", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleLength)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(LayoutNode), Member = "CopyFromComputedStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle)}, ReturnType = typeof(void))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
		 get { } //Length: 66
	}

	public Length paddingRight
	{
		[CalledBy(Type = typeof(ComputedStyle), Member = "CompareChanges", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&), typeof(ComputedStyle&)}, ReturnType = typeof(VersionChangeType))]
		[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_paddingRight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleLength)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(LayoutNode), Member = "CopyFromComputedStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle)}, ReturnType = typeof(void))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
		 get { } //Length: 66
	}

	public Length paddingTop
	{
		[CalledBy(Type = typeof(ComputedStyle), Member = "CompareChanges", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&), typeof(ComputedStyle&)}, ReturnType = typeof(VersionChangeType))]
		[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_paddingTop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleLength)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(LayoutNode), Member = "CopyFromComputedStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle)}, ReturnType = typeof(void))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
		 get { } //Length: 66
	}

	public Position position
	{
		[CalledBy(Type = typeof(ComputedStyle), Member = "CompareChanges", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&), typeof(ComputedStyle&)}, ReturnType = typeof(VersionChangeType))]
		[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_position", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityEngine.UIElements.StyleEnum`1<UnityEngine.UIElements.Position>)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ResolvedStyleAccess), Member = "get_position", ReturnType = typeof(Position))]
		[CalledBy(Type = typeof(LayoutNode), Member = "CopyFromComputedStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle)}, ReturnType = typeof(void))]
		[CallerCount(Count = 5)]
		[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
		 get { } //Length: 65
	}

	public Length right
	{
		[CalledBy(Type = typeof(ComputedStyle), Member = "CompareChanges", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&), typeof(ComputedStyle&)}, ReturnType = typeof(VersionChangeType))]
		[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_right", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleLength)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(LayoutNode), Member = "CopyFromComputedStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle)}, ReturnType = typeof(void))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
		 get { } //Length: 66
	}

	public Rotate rotate
	{
		[CalledBy(Type = typeof(UIRLayoutUpdater), Member = "UpdateSubTree", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(System.Collections.Generic.List`1<System.ValueTuple`3<UnityEngine.Rect, UnityEngine.Rect, UnityEngine.UIElements.VisualElement>>)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ResolvedStyleAccess), Member = "get_rotate", ReturnType = typeof(Rotate))]
		[CalledBy(Type = typeof(VisualElement), Member = "GetPivotedMatrixWithLayout", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Matrix4x4&)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(VisualElement), Member = "get_hasDefaultRotationAndScale", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(VisualElement), Member = "get_has3DTransform", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(VisualElement), Member = "get_has3DRotation", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(VisualElement), Member = "ResolveRotation", ReturnType = typeof(Quaternion))]
		[CallerCount(Count = 7)]
		[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
		 get { } //Length: 90
	}

	public Scale scale
	{
		[CalledBy(Type = typeof(UIRLayoutUpdater), Member = "UpdateSubTree", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(System.Collections.Generic.List`1<System.ValueTuple`3<UnityEngine.Rect, UnityEngine.Rect, UnityEngine.UIElements.VisualElement>>)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ResolvedStyleAccess), Member = "get_scale", ReturnType = typeof(Scale))]
		[CalledBy(Type = typeof(VisualElement), Member = "GetPivotedMatrixWithLayout", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Matrix4x4&)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(VisualElement), Member = "get_hasDefaultRotationAndScale", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(VisualElement), Member = "ResolveScale", ReturnType = typeof(Vector3))]
		[CallerCount(Count = 5)]
		[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
		 get { } //Length: 81
	}

	public TextOverflow textOverflow
	{
		[CalledBy(Type = typeof(ResolvedStyleAccess), Member = "get_textOverflow", ReturnType = typeof(TextOverflow))]
		[CalledBy(Type = typeof(UITKTextHandle), Member = "ConvertUssToNativeTextGenerationSettings", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(UITKTextHandle), Member = "GetTextOverflowMode", ReturnType = "UnityEngine.TextCore.Text.TextOverflowMode")]
		[CalledBy(Type = typeof(UITKTextHandle), Member = "ConvertUssToTextGenerationSettings", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(TextElement), Member = "OnGenerateTextOver", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshGenerationContext)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TextElement), Member = "OnGenerateTextOverNative", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshGenerationContext)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TextElement), Member = "UpdateVisibleText", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TextElement), Member = "ShouldElide", ReturnType = typeof(bool))]
		[CallerCount(Count = 10)]
		[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
		 get { } //Length: 62
	}

	public TextShadow textShadow
	{
		[CalledBy(Type = typeof(UITKTextHandle), Member = "GetVertexPadding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FontAsset)}, ReturnType = typeof(float))]
		[CalledBy(Type = typeof(TextUtilities), Member = "GetTextCoreSettingsForElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(bool)}, ReturnType = typeof(TextCoreSettings))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
		 get { } //Length: 88
	}

	public Length top
	{
		[CalledBy(Type = typeof(ComputedStyle), Member = "CompareChanges", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&), typeof(ComputedStyle&)}, ReturnType = typeof(VersionChangeType))]
		[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_top", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleLength)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(LayoutNode), Member = "CopyFromComputedStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle)}, ReturnType = typeof(void))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
		 get { } //Length: 66
	}

	public TransformOrigin transformOrigin
	{
		[CalledBy(Type = typeof(VisualElement), Member = "ResolveTransformOrigin", ReturnType = typeof(Vector3))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
		 get { } //Length: 87
	}

	public List<TimeValue> transitionDelay
	{
		[CalledBy(Type = typeof(ComputedTransitionUtils), Member = "GetTransitionHashCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&)}, ReturnType = typeof(int))]
		[CalledBy(Type = typeof(ComputedTransitionUtils), Member = "SameTransitionProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&), typeof(ComputedStyle&)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(ComputedTransitionUtils), Member = "ComputeTransitionPropertyData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&), typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.ComputedTransitionProperty>)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ResolvedStyleAccess), Member = "get_transitionDelay", ReturnType = typeof(System.Collections.Generic.IEnumerable`1<UnityEngine.UIElements.TimeValue>))]
		[CallerCount(Count = 5)]
		[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
		 get { } //Length: 62
	}

	public List<TimeValue> transitionDuration
	{
		[CalledBy(Type = typeof(ComputedTransitionUtils), Member = "GetTransitionHashCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&)}, ReturnType = typeof(int))]
		[CalledBy(Type = typeof(ComputedTransitionUtils), Member = "SameTransitionProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&), typeof(ComputedStyle&)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(ComputedTransitionUtils), Member = "ComputeTransitionPropertyData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&), typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.ComputedTransitionProperty>)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ResolvedStyleAccess), Member = "get_transitionDuration", ReturnType = typeof(System.Collections.Generic.IEnumerable`1<UnityEngine.UIElements.TimeValue>))]
		[CallerCount(Count = 5)]
		[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
		 get { } //Length: 63
	}

	public List<StylePropertyName> transitionProperty
	{
		[CalledBy(Type = typeof(ComputedTransitionUtils), Member = "GetTransitionHashCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&)}, ReturnType = typeof(int))]
		[CalledBy(Type = typeof(ComputedTransitionUtils), Member = "SameTransitionProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&), typeof(ComputedStyle&)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(ComputedTransitionUtils), Member = "ComputeTransitionPropertyData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&), typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.ComputedTransitionProperty>)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ResolvedStyleAccess), Member = "get_transitionProperty", ReturnType = typeof(System.Collections.Generic.IEnumerable`1<UnityEngine.UIElements.StylePropertyName>))]
		[CallerCount(Count = 5)]
		[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
		 get { } //Length: 63
	}

	public List<EasingFunction> transitionTimingFunction
	{
		[CalledBy(Type = typeof(ComputedTransitionUtils), Member = "GetTransitionHashCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&)}, ReturnType = typeof(int))]
		[CalledBy(Type = typeof(ComputedTransitionUtils), Member = "ComputeTransitionPropertyData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&), typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.ComputedTransitionProperty>)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ResolvedStyleAccess), Member = "get_transitionTimingFunction", ReturnType = typeof(System.Collections.Generic.IEnumerable`1<UnityEngine.UIElements.EasingFunction>))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
		 get { } //Length: 63
	}

	public Translate translate
	{
		[CalledBy(Type = typeof(VisualElement), Member = "get_has3DTransform", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(VisualElement), Member = "get_has3DTranslation", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(VisualElement), Member = "ResolveTranslate", ReturnType = typeof(Vector3))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
		 get { } //Length: 91
	}

	public Color unityBackgroundImageTintColor
	{
		[CalledBy(Type = typeof(ResolvedStyleAccess), Member = "get_unityBackgroundImageTintColor", ReturnType = typeof(Color))]
		[CalledBy(Type = typeof(DefaultElementBuilder), Member = "DrawVisualElementBackground", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshGenerationContext)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
		 get { } //Length: 81
	}

	public EditorTextRenderingMode unityEditorTextRenderingMode
	{
		[CalledBy(Type = typeof(ComputedStyle), Member = "ApplyUnsetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(ComputedStyle&)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ComputedStyle), Member = "CompareChanges", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&), typeof(ComputedStyle&)}, ReturnType = typeof(VersionChangeType))]
		[CalledBy(Type = typeof(ResolvedStyleAccess), Member = "get_unityEditorTextRenderingMode", ReturnType = typeof(EditorTextRenderingMode))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
		 get { } //Length: 61
	}

	public Font unityFont
	{
		[CalledBy(Type = typeof(GenericDropdownMenu), Member = "DropDown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), typeof(VisualElement), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ComputedStyle), Member = "ApplyUnsetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(ComputedStyle&)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ResolvedStyleAccess), Member = "get_unityFont", ReturnType = typeof(Font))]
		[CalledBy(Type = typeof(TextUtilities), Member = "MeasureVisualElementTextSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextElement), typeof(RenderedText&), typeof(float), typeof(MeasureMode), typeof(float), typeof(MeasureMode)}, ReturnType = typeof(Vector2))]
		[CalledBy(Type = typeof(TextUtilities), Member = "GetFontAsset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(FontAsset))]
		[CalledBy(Type = typeof(TextUtilities), Member = "IsFontAssigned", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 7)]
		[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
		 get { } //Length: 62
	}

	public FontDefinition unityFontDefinition
	{
		[CalledBy(Type = typeof(GenericDropdownMenu), Member = "DropDown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), typeof(VisualElement), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ResolvedStyleAccess), Member = "get_unityFontDefinition", ReturnType = typeof(FontDefinition))]
		[CalledBy(Type = "UnityEngine.UIElements.ATGTextJobSystem+GenerateTextJobData", Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ATGTextJobSystem), Member = "GenerateTextJobified", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshGenerationContext), typeof(object)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TextUtilities), Member = "MeasureVisualElementTextSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextElement), typeof(RenderedText&), typeof(float), typeof(MeasureMode), typeof(float), typeof(MeasureMode)}, ReturnType = typeof(Vector2))]
		[CalledBy(Type = typeof(TextUtilities), Member = "GetFontAsset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(FontAsset))]
		[CalledBy(Type = typeof(TextUtilities), Member = "IsFontAssigned", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 10)]
		[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
		 get { } //Length: 80
	}

	public FontStyle unityFontStyleAndWeight
	{
		[CalledBy(Type = typeof(ComputedStyle), Member = "ApplyUnsetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(ComputedStyle&)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ComputedStyle), Member = "CompareChanges", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&), typeof(ComputedStyle&)}, ReturnType = typeof(VersionChangeType))]
		[CalledBy(Type = typeof(ResolvedStyleAccess), Member = "get_unityFontStyleAndWeight", ReturnType = typeof(FontStyle))]
		[CalledBy(Type = typeof(UITKTextHandle), Member = "ConvertUssToNativeTextGenerationSettings", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(UITKTextHandle), Member = "ConvertUssToTextGenerationSettings", ReturnType = typeof(bool))]
		[CallerCount(Count = 6)]
		[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
		 get { } //Length: 61
	}

	public OverflowClipBox unityOverflowClipBox
	{
		[CalledBy(Type = typeof(VisualElement), Member = "SubstractBorderPadding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect)}, ReturnType = typeof(Rect))]
		[CalledBy(Type = typeof(DefaultElementBuilder), Member = "GenerateStencilClipEntryForRoundedRectBackground", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshGenerationContext)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
		 get { } //Length: 62
	}

	public Length unityParagraphSpacing
	{
		[CalledBy(Type = typeof(ComputedStyle), Member = "ApplyUnsetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(ComputedStyle&)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ComputedStyle), Member = "CompareChanges", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&), typeof(ComputedStyle&)}, ReturnType = typeof(VersionChangeType))]
		[CalledBy(Type = typeof(ResolvedStyleAccess), Member = "get_unityParagraphSpacing", ReturnType = typeof(float))]
		[CalledBy(Type = typeof(UITKTextHandle), Member = "ConvertUssToNativeTextGenerationSettings", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(UITKTextHandle), Member = "ConvertUssToTextGenerationSettings", ReturnType = typeof(bool))]
		[CallerCount(Count = 6)]
		[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
		 get { } //Length: 62
	}

	public int unitySliceBottom
	{
		[CalledBy(Type = typeof(ResolvedStyleAccess), Member = "get_unitySliceBottom", ReturnType = typeof(int))]
		[CalledBy(Type = typeof(DefaultElementBuilder), Member = "DrawVisualElementBackground", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshGenerationContext)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
		 get { } //Length: 62
	}

	public int unitySliceLeft
	{
		[CalledBy(Type = typeof(ComputedStyle), Member = "CompareChanges", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&), typeof(ComputedStyle&)}, ReturnType = typeof(VersionChangeType))]
		[CalledBy(Type = typeof(ResolvedStyleAccess), Member = "get_unitySliceLeft", ReturnType = typeof(int))]
		[CalledBy(Type = typeof(DefaultElementBuilder), Member = "DrawVisualElementBackground", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshGenerationContext)}, ReturnType = typeof(void))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
		 get { } //Length: 62
	}

	public int unitySliceRight
	{
		[CalledBy(Type = typeof(ComputedStyle), Member = "CompareChanges", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&), typeof(ComputedStyle&)}, ReturnType = typeof(VersionChangeType))]
		[CalledBy(Type = typeof(ResolvedStyleAccess), Member = "get_unitySliceRight", ReturnType = typeof(int))]
		[CalledBy(Type = typeof(DefaultElementBuilder), Member = "DrawVisualElementBackground", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshGenerationContext)}, ReturnType = typeof(void))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
		 get { } //Length: 62
	}

	public float unitySliceScale
	{
		[CalledBy(Type = typeof(ComputedStyle), Member = "CompareChanges", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&), typeof(ComputedStyle&)}, ReturnType = typeof(VersionChangeType))]
		[CalledBy(Type = typeof(ResolvedStyleAccess), Member = "get_unitySliceScale", ReturnType = typeof(float))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
		 get { } //Length: 64
	}

	public int unitySliceTop
	{
		[CalledBy(Type = typeof(ComputedStyle), Member = "CompareChanges", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&), typeof(ComputedStyle&)}, ReturnType = typeof(VersionChangeType))]
		[CalledBy(Type = typeof(ResolvedStyleAccess), Member = "get_unitySliceTop", ReturnType = typeof(int))]
		[CalledBy(Type = typeof(DefaultElementBuilder), Member = "DrawVisualElementBackground", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshGenerationContext)}, ReturnType = typeof(void))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
		 get { } //Length: 62
	}

	public SliceType unitySliceType
	{
		[CalledBy(Type = typeof(ResolvedStyleAccess), Member = "get_unitySliceType", ReturnType = typeof(SliceType))]
		[CalledBy(Type = typeof(DefaultElementBuilder), Member = "DrawVisualElementBackground", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshGenerationContext)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
		 get { } //Length: 62
	}

	public TextAnchor unityTextAlign
	{
		[CalledBy(Type = typeof(ComputedStyle), Member = "ApplyUnsetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(ComputedStyle&)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ResolvedStyleAccess), Member = "get_unityTextAlign", ReturnType = typeof(TextAnchor))]
		[CalledBy(Type = typeof(UITKTextHandle), Member = "ConvertUssToNativeTextGenerationSettings", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(UITKTextHandle), Member = "ConvertUssToTextGenerationSettings", ReturnType = typeof(bool))]
		[CallerCount(Count = 5)]
		[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
		 get { } //Length: 61
	}

	public TextGeneratorType unityTextGenerator
	{
		[CalledBy(Type = typeof(ComputedStyle), Member = "ApplyUnsetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(ComputedStyle&)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ResolvedStyleAccess), Member = "get_unityTextGenerator", ReturnType = typeof(TextGeneratorType))]
		[CalledBy(Type = typeof(TextUtilities), Member = "IsAdvancedTextEnabledForElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
		 get { } //Length: 61
	}

	public Color unityTextOutlineColor
	{
		[CalledBy(Type = typeof(ResolvedStyleAccess), Member = "get_unityTextOutlineColor", ReturnType = typeof(Color))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
		 get { } //Length: 80
	}

	public float unityTextOutlineWidth
	{
		[CalledBy(Type = typeof(ComputedStyle), Member = "ApplyUnsetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(ComputedStyle&)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ComputedStyle), Member = "CompareChanges", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&), typeof(ComputedStyle&)}, ReturnType = typeof(VersionChangeType))]
		[CalledBy(Type = typeof(ResolvedStyleAccess), Member = "get_unityTextOutlineWidth", ReturnType = typeof(float))]
		[CalledBy(Type = typeof(UITKTextHandle), Member = "GetVertexPadding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FontAsset)}, ReturnType = typeof(float))]
		[CallerCount(Count = 5)]
		[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
		 get { } //Length: 63
	}

	public TextOverflowPosition unityTextOverflowPosition
	{
		[CalledBy(Type = typeof(ComputedStyle), Member = "CompareChanges", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&), typeof(ComputedStyle&)}, ReturnType = typeof(VersionChangeType))]
		[CalledBy(Type = typeof(ResolvedStyleAccess), Member = "get_unityTextOverflowPosition", ReturnType = typeof(TextOverflowPosition))]
		[CalledBy(Type = typeof(UITKTextHandle), Member = "ConvertUssToNativeTextGenerationSettings", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(UITKTextHandle), Member = "GetTextOverflowMode", ReturnType = "UnityEngine.TextCore.Text.TextOverflowMode")]
		[CalledBy(Type = typeof(UITKTextHandle), Member = "ConvertUssToTextGenerationSettings", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(UITKTextHandle), Member = "TextLibraryCanElide", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(TextElement), Member = "UpdateVisibleText", ReturnType = typeof(void))]
		[CallerCount(Count = 9)]
		[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
		 get { } //Length: 62
	}

	public Visibility visibility
	{
		[CalledBy(Type = typeof(ComputedStyle), Member = "ApplyUnsetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(ComputedStyle&)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ResolvedStyleAccess), Member = "get_visibility", ReturnType = typeof(Visibility))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
		 get { } //Length: 64
	}

	public WhiteSpace whiteSpace
	{
		[CalledBy(Type = typeof(TextInputBase), Member = "SetScrollViewMode", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TextInputBase), Member = "SetMultilineContainerStyle", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ComputedStyle), Member = "ApplyUnsetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(ComputedStyle&)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ComputedStyle), Member = "CompareChanges", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&), typeof(ComputedStyle&)}, ReturnType = typeof(VersionChangeType))]
		[CalledBy(Type = typeof(ResolvedStyleAccess), Member = "get_whiteSpace", ReturnType = typeof(WhiteSpace))]
		[CalledBy(Type = typeof(UITKTextHandle), Member = "ConvertUssToNativeTextGenerationSettings", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(UITKTextHandle), Member = "ConvertUssToTextGenerationSettings", ReturnType = typeof(bool))]
		[CallerCount(Count = 10)]
		[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
		 get { } //Length: 64
	}

	public Length width
	{
		[CalledBy(Type = typeof(GenericDropdownMenu), Member = "EnsureVisibilityInParent", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ComputedStyle), Member = "CompareChanges", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&), typeof(ComputedStyle&)}, ReturnType = typeof(VersionChangeType))]
		[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_width", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleLength)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TextElement), Member = "UnityEngine.UIElements.INotifyValueChanged<System.String>.SetValueWithoutNotify", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(LayoutNode), Member = "CopyFromComputedStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle)}, ReturnType = typeof(void))]
		[CallerCount(Count = 7)]
		[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
		 get { } //Length: 66
	}

	public Length wordSpacing
	{
		[CalledBy(Type = typeof(ComputedStyle), Member = "ApplyUnsetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(ComputedStyle&)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ComputedStyle), Member = "CompareChanges", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&), typeof(ComputedStyle&)}, ReturnType = typeof(VersionChangeType))]
		[CalledBy(Type = typeof(ResolvedStyleAccess), Member = "get_wordSpacing", ReturnType = typeof(float))]
		[CalledBy(Type = typeof(UITKTextHandle), Member = "ConvertUssToNativeTextGenerationSettings", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(UITKTextHandle), Member = "ConvertUssToTextGenerationSettings", ReturnType = typeof(bool))]
		[CallerCount(Count = 6)]
		[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object), typeof(object)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Collections.Generic.HashSet`1<System.Object>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
		[Calls(Type = typeof(TimerEventScheduler), Member = "PrivateUnSchedule", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScheduledItem)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(HashSet`1), Member = "Clear", ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Collections.Generic.HashSet`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
		[Calls(Type = typeof(System.Collections.Generic.HashSet`1<System.Object>), Member = "GetEnumerator", ReturnType = typeof(System.Collections.Generic.HashSet`1+Enumerator<System.Object>))]
		[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
		[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
		[CallsDeduplicatedMethods(Count = 4)]
		[CallsUnknownMethods(Count = 21)]
		 get { } //Length: 1207
	}

	[CalledBy(Type = typeof(VisualTreeStyleUpdaterTraversal), Member = "TraverseRecursive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InitialStyle), Member = "Acquire", ReturnType = typeof(ComputedStyle))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(StyleDataRef`1), Member = "Acquire", ReturnType = "UnityEngine.UIElements.StyleDataRef`1<T>")]
	public ComputedStyle Acquire() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InitialStyle), Member = "Get", ReturnType = typeof(ComputedStyle&))]
	[Calls(Type = typeof(ComputedStyle), Member = "CopyFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&)}, ReturnType = typeof(void))]
	private void ApplyAllPropertyInitial() { }

	[CalledBy(Type = typeof(ComputedStyle), Member = "ApplyProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyReader), typeof(ComputedStyle&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(StylePropertyReader), Member = "GetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(StylePropertyValue))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, UnityEngine.UIElements.StyleSheets.StylePropertyValue>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(StylePropertyValue)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void ApplyCustomStyleProperty(StylePropertyReader reader) { }

	[CalledBy(Type = typeof(InlineStyleAccess), Member = "ApplyFromComputedStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(ComputedStyle&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.UIElements.StyleDataRef`1<UnityEngine.UIElements.VisualData>), Member = "Write", ReturnType = typeof(VisualData&))]
	[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
	[Calls(Type = typeof(UnityEngine.UIElements.StyleDataRef`1<UnityEngine.UIElements.TransitionData>), Member = "Write", ReturnType = typeof(TransitionData&))]
	[Calls(Type = typeof(StyleValueExtensions), Member = "CopyFrom", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.List`1<T>", "System.Collections.Generic.List`1<T>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StyleValueExtensions), Member = "CopyFrom", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyName)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.StylePropertyName>), typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.StylePropertyName>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StyleValueExtensions), Member = "CopyFrom", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeValue)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.TimeValue>), typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.TimeValue>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UnityEngine.UIElements.StyleDataRef`1<UnityEngine.UIElements.TransformData>), Member = "Write", ReturnType = typeof(TransformData&))]
	[CallsUnknownMethods(Count = 6)]
	[ContainsInvalidInstructions]
	public void ApplyFromComputedStyle(StylePropertyId id, ref ComputedStyle other) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StylePropertyReader), Member = "GetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(StylePropertyValue))]
	[Calls(Type = typeof(ComputedStyle), Member = "ApplyInitialValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyReader)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ComputedStyle), Member = "ApplyUnsetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyReader), typeof(ComputedStyle&)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private bool ApplyGlobalKeyword(StylePropertyReader reader, ref ComputedStyle parentStyle) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ComputedStyle), Member = "ApplyInitialValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(void))]
	private bool ApplyGlobalKeyword(StylePropertyId id, StyleKeyword keyword, ref ComputedStyle parentStyle) { }

	[CalledBy(Type = typeof(ComputedStyle), Member = "ApplyGlobalKeyword", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyReader), typeof(ComputedStyle&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ComputedStyle), Member = "ApplyProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyReader), typeof(ComputedStyle&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Dictionary`2), Member = "ContainsKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Dictionary`2), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(InitialStyle), Member = "Get", ReturnType = typeof(ComputedStyle&))]
	[Calls(Type = typeof(ComputedStyle), Member = "CopyFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsInvalidInstructions]
	public void ApplyInitialValue(StylePropertyReader reader) { }

	[CalledBy(Type = typeof(ComputedStyle), Member = "ApplyGlobalKeyword", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(StyleKeyword), typeof(ComputedStyle&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ComputedStyle), Member = "ApplyStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleValue), typeof(ComputedStyle&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ComputedStyle), Member = "ApplyStyleValueManaged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleValueManaged), typeof(ComputedStyle&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ComputedStyle), Member = "ApplyUnsetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(ComputedStyle&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(InitialStyle), Member = "get_paddingBottom", ReturnType = typeof(Length))]
	[Calls(Type = typeof(InitialStyle), Member = "get_unityFontStyleAndWeight", ReturnType = typeof(FontStyle))]
	[Calls(Type = typeof(InitialStyle), Member = "get_unityFontDefinition", ReturnType = typeof(FontDefinition))]
	[Calls(Type = typeof(InitialStyle), Member = "get_unityFont", ReturnType = typeof(Font))]
	[Calls(Type = typeof(InitialStyle), Member = "get_unityEditorTextRenderingMode", ReturnType = typeof(EditorTextRenderingMode))]
	[Calls(Type = typeof(InitialStyle), Member = "get_textShadow", ReturnType = typeof(TextShadow))]
	[Calls(Type = typeof(InitialStyle), Member = "get_letterSpacing", ReturnType = typeof(Length))]
	[Calls(Type = typeof(InitialStyle), Member = "get_fontSize", ReturnType = typeof(Length))]
	[Calls(Type = typeof(InitialStyle), Member = "get_color", ReturnType = typeof(Color))]
	[Calls(Type = typeof(InitialStyle), Member = "get_transformOrigin", ReturnType = typeof(TransformOrigin))]
	[Calls(Type = typeof(InitialStyle), Member = "get_scale", ReturnType = typeof(Scale))]
	[Calls(Type = typeof(InitialStyle), Member = "get_unityParagraphSpacing", ReturnType = typeof(Length))]
	[Calls(Type = typeof(InitialStyle), Member = "get_translate", ReturnType = typeof(Translate))]
	[Calls(Type = typeof(UnityEngine.UIElements.StyleDataRef`1<UnityEngine.UIElements.TransformData>), Member = "Write", ReturnType = typeof(TransformData&))]
	[Calls(Type = typeof(InitialStyle), Member = "get_unityTextOutlineWidth", ReturnType = typeof(float))]
	[Calls(Type = typeof(InitialStyle), Member = "get_unityTextOutlineColor", ReturnType = typeof(Color))]
	[Calls(Type = typeof(StyleDataRef`1), Member = "Write", ReturnType = "T&")]
	[Calls(Type = typeof(InitialStyle), Member = "get_rotate", ReturnType = typeof(Rotate))]
	[Calls(Type = typeof(InitialStyle), Member = "get_unityTextAlign", ReturnType = typeof(TextAnchor))]
	[Calls(Type = typeof(InitialStyle), Member = "get_whiteSpace", ReturnType = typeof(WhiteSpace))]
	[Calls(Type = typeof(InitialStyle), Member = "get_visibility", ReturnType = typeof(Visibility))]
	[Calls(Type = typeof(InitialStyle), Member = "get_position", ReturnType = typeof(Position))]
	[Calls(Type = typeof(InitialStyle), Member = "get_minWidth", ReturnType = typeof(Length))]
	[Calls(Type = typeof(InitialStyle), Member = "get_minHeight", ReturnType = typeof(Length))]
	[Calls(Type = typeof(InitialStyle), Member = "get_maxWidth", ReturnType = typeof(Length))]
	[Calls(Type = typeof(InitialStyle), Member = "get_maxHeight", ReturnType = typeof(Length))]
	[Calls(Type = typeof(InitialStyle), Member = "get_left", ReturnType = typeof(Length))]
	[Calls(Type = typeof(InitialStyle), Member = "get_justifyContent", ReturnType = typeof(Justify))]
	[Calls(Type = typeof(InitialStyle), Member = "get_height", ReturnType = typeof(Length))]
	[Calls(Type = typeof(InitialStyle), Member = "get_flexWrap", ReturnType = typeof(Wrap))]
	[Calls(Type = typeof(InitialStyle), Member = "get_flexDirection", ReturnType = typeof(FlexDirection))]
	[Calls(Type = typeof(InitialStyle), Member = "get_display", ReturnType = typeof(DisplayStyle))]
	[Calls(Type = typeof(InitialStyle), Member = "get_bottom", ReturnType = typeof(Length))]
	[Calls(Type = typeof(InitialStyle), Member = "get_alignSelf", ReturnType = typeof(Align))]
	[Calls(Type = typeof(InitialStyle), Member = "get_alignItems", ReturnType = typeof(Align))]
	[Calls(Type = typeof(InitialStyle), Member = "get_alignContent", ReturnType = typeof(Align))]
	[Calls(Type = typeof(InitialStyle), Member = "get_wordSpacing", ReturnType = typeof(Length))]
	[Calls(Type = typeof(StyleValueExtensions), Member = "CopyFrom", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.List`1<T>", "System.Collections.Generic.List`1<T>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InitialStyle), Member = "get_unityTextGenerator", ReturnType = typeof(TextGeneratorType))]
	[Calls(Type = typeof(InitialStyle), Member = "get_transitionTimingFunction", ReturnType = typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.EasingFunction>))]
	[Calls(Type = typeof(InitialStyle), Member = "get_paddingRight", ReturnType = typeof(Length))]
	[Calls(Type = typeof(InitialStyle), Member = "get_width", ReturnType = typeof(Length))]
	[Calls(Type = typeof(UnityEngine.UIElements.StyleDataRef`1<UnityEngine.UIElements.TransitionData>), Member = "Write", ReturnType = typeof(TransitionData&))]
	[Calls(Type = typeof(InitialStyle), Member = "get_overflow", ReturnType = typeof(OverflowInternal))]
	[Calls(Type = typeof(InitialStyle), Member = "get_opacity", ReturnType = typeof(float))]
	[Calls(Type = typeof(InitialStyle), Member = "get_borderTopRightRadius", ReturnType = typeof(Length))]
	[Calls(Type = typeof(InitialStyle), Member = "get_borderTopLeftRadius", ReturnType = typeof(Length))]
	[Calls(Type = typeof(InitialStyle), Member = "get_borderTopColor", ReturnType = typeof(Color))]
	[Calls(Type = typeof(InitialStyle), Member = "get_borderRightColor", ReturnType = typeof(Color))]
	[Calls(Type = typeof(InitialStyle), Member = "get_transitionProperty", ReturnType = typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.StylePropertyName>))]
	[Calls(Type = typeof(InitialStyle), Member = "get_borderBottomRightRadius", ReturnType = typeof(Length))]
	[Calls(Type = typeof(InitialStyle), Member = "get_borderBottomColor", ReturnType = typeof(Color))]
	[Calls(Type = typeof(InitialStyle), Member = "get_backgroundSize", ReturnType = typeof(BackgroundSize))]
	[Calls(Type = typeof(InitialStyle), Member = "get_backgroundRepeat", ReturnType = typeof(BackgroundRepeat))]
	[Calls(Type = typeof(InitialStyle), Member = "get_backgroundPositionX", ReturnType = typeof(BackgroundPosition))]
	[Calls(Type = typeof(InitialStyle), Member = "get_backgroundImage", ReturnType = typeof(Background))]
	[Calls(Type = typeof(InitialStyle), Member = "get_backgroundColor", ReturnType = typeof(Color))]
	[Calls(Type = typeof(UnityEngine.UIElements.StyleDataRef`1<UnityEngine.UIElements.VisualData>), Member = "Write", ReturnType = typeof(VisualData&))]
	[Calls(Type = typeof(InitialStyle), Member = "get_borderBottomLeftRadius", ReturnType = typeof(Length))]
	[Calls(Type = typeof(StyleValueExtensions), Member = "CopyFrom", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyName)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.StylePropertyName>), typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.StylePropertyName>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InitialStyle), Member = "get_transitionDuration", ReturnType = typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.TimeValue>))]
	[Calls(Type = typeof(InitialStyle), Member = "get_transitionDelay", ReturnType = typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.TimeValue>))]
	[Calls(Type = typeof(InitialStyle), Member = "get_right", ReturnType = typeof(Length))]
	[Calls(Type = typeof(InitialStyle), Member = "get_paddingTop", ReturnType = typeof(Length))]
	[Calls(Type = typeof(InitialStyle), Member = "get_marginLeft", ReturnType = typeof(Length))]
	[Calls(Type = typeof(InitialStyle), Member = "get_marginBottom", ReturnType = typeof(Length))]
	[Calls(Type = typeof(InitialStyle), Member = "get_marginRight", ReturnType = typeof(Length))]
	[Calls(Type = typeof(InitialStyle), Member = "get_marginTop", ReturnType = typeof(Length))]
	[Calls(Type = typeof(InitialStyle), Member = "get_flexBasis", ReturnType = typeof(Length))]
	[Calls(Type = typeof(InitialStyle), Member = "get_flexShrink", ReturnType = typeof(float))]
	[Calls(Type = typeof(InitialStyle), Member = "get_flexGrow", ReturnType = typeof(float))]
	[Calls(Type = typeof(InitialStyle), Member = "get_borderLeftWidth", ReturnType = typeof(float))]
	[Calls(Type = typeof(InitialStyle), Member = "get_borderBottomWidth", ReturnType = typeof(float))]
	[Calls(Type = typeof(InitialStyle), Member = "get_borderRightWidth", ReturnType = typeof(float))]
	[Calls(Type = typeof(InitialStyle), Member = "get_borderTopWidth", ReturnType = typeof(float))]
	[Calls(Type = typeof(UnityEngine.UIElements.StyleDataRef`1<UnityEngine.UIElements.LayoutData>), Member = "Write", ReturnType = typeof(LayoutData&))]
	[Calls(Type = typeof(InitialStyle), Member = "get_borderLeftColor", ReturnType = typeof(Color))]
	[Calls(Type = typeof(InitialStyle), Member = "get_backgroundPositionY", ReturnType = typeof(BackgroundPosition))]
	[Calls(Type = typeof(StyleValueExtensions), Member = "CopyFrom", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeValue)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.TimeValue>), typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.TimeValue>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InitialStyle), Member = "get_paddingLeft", ReturnType = typeof(Length))]
	[Calls(Type = typeof(InitialStyle), Member = "get_top", ReturnType = typeof(Length))]
	[CallsUnknownMethods(Count = 7)]
	[ContainsInvalidInstructions]
	public void ApplyInitialValue(StylePropertyId id) { }

	[CalledBy(Type = typeof(InlineStyleAccess), Member = "ApplyInlineStyles", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VisualTreeStyleUpdaterTraversal), Member = "ProcessMatchedRules", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.SelectorMatchRecord>)}, ReturnType = typeof(ComputedStyle))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(StylePropertyReader), Member = "ReadCursor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Cursor))]
	[Calls(Type = typeof(StylePropertyReader), Member = "ReadInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ShorthandApplicator), Member = "ApplyBackgroundPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyReader), typeof(ComputedStyle&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ShorthandApplicator), Member = "ApplyBorderColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyReader), typeof(ComputedStyle&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ShorthandApplicator), Member = "ApplyBorderRadius", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyReader), typeof(ComputedStyle&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ShorthandApplicator), Member = "ApplyBorderWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyReader), typeof(ComputedStyle&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ShorthandApplicator), Member = "ApplyFlex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyReader), typeof(ComputedStyle&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ShorthandApplicator), Member = "ApplyMargin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyReader), typeof(ComputedStyle&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ShorthandApplicator), Member = "ApplyPadding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyReader), typeof(ComputedStyle&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ShorthandApplicator), Member = "ApplyTransition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyReader), typeof(ComputedStyle&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ShorthandApplicator), Member = "ApplyUnityBackgroundScaleMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyReader), typeof(ComputedStyle&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ShorthandApplicator), Member = "ApplyUnityTextOutline", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyReader), typeof(ComputedStyle&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StyleDataRef`1), Member = "Write", ReturnType = "T&")]
	[Calls(Type = typeof(StylePropertyReader), Member = "ReadTextShadow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(TextShadow))]
	[Calls(Type = typeof(StylePropertyReader), Member = "ReadFont", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Font))]
	[Calls(Type = typeof(StylePropertyReader), Member = "ReadFontDefinition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(FontDefinition))]
	[Calls(Type = typeof(UnityEngine.UIElements.StyleDataRef`1<UnityEngine.UIElements.LayoutData>), Member = "Write", ReturnType = typeof(LayoutData&))]
	[Calls(Type = typeof(ComputedStyle), Member = "ApplyCustomStyleProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyReader)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Debug), Member = "LogAssertion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UnityEngine.UIElements.StyleDataRef`1<UnityEngine.UIElements.RareData>), Member = "Write", ReturnType = typeof(RareData&))]
	[Calls(Type = typeof(StylePropertyReader), Member = "ReadRotate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Rotate))]
	[Calls(Type = typeof(StylePropertyReader), Member = "ReadScale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Scale))]
	[Calls(Type = typeof(StylePropertyReader), Member = "ReadTransformOrigin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(TransformOrigin))]
	[Calls(Type = typeof(StylePropertyReader), Member = "GetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(StylePropertyValue))]
	[Calls(Type = typeof(ComputedStyle), Member = "ApplyInitialValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyReader)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StylePropertyReader), Member = "MoveNextProperty", ReturnType = typeof(StylePropertyId))]
	[Calls(Type = typeof(ComputedStyle), Member = "ApplyUnsetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyReader), typeof(ComputedStyle&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UnityEngine.UIElements.StyleDataRef`1<UnityEngine.UIElements.VisualData>), Member = "Write", ReturnType = typeof(VisualData&))]
	[Calls(Type = typeof(StylePropertyReader), Member = "ReadColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Color))]
	[Calls(Type = typeof(StylePropertyReader), Member = "ReadBackground", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Background))]
	[Calls(Type = typeof(StylePropertyReader), Member = "ReadBackgroundPositionX", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(BackgroundPosition))]
	[Calls(Type = typeof(StylePropertyReader), Member = "ReadBackgroundPositionY", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(BackgroundPosition))]
	[Calls(Type = typeof(StylePropertyReader), Member = "ReadBackgroundRepeat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(BackgroundRepeat))]
	[Calls(Type = typeof(StylePropertyReader), Member = "ReadLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Length))]
	[Calls(Type = typeof(StylePropertyReader), Member = "ReadFloat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(StylePropertyReader), Member = "ReadEnum", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleEnumType), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(UnityEngine.UIElements.StyleDataRef`1<UnityEngine.UIElements.TransitionData>), Member = "Write", ReturnType = typeof(TransitionData&))]
	[Calls(Type = typeof(StylePropertyReader), Member = "ReadListEasingFunction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.EasingFunction>), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StylePropertyReader), Member = "ReadListStylePropertyName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.StylePropertyName>), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StylePropertyReader), Member = "ReadListTimeValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.TimeValue>), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UnityEngine.UIElements.StyleDataRef`1<UnityEngine.UIElements.TransformData>), Member = "Write", ReturnType = typeof(TransformData&))]
	[Calls(Type = typeof(StylePropertyReader), Member = "ReadTranslate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Translate))]
	[Calls(Type = typeof(StylePropertyReader), Member = "ReadBackgroundSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(BackgroundSize))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 9)]
	public void ApplyProperties(StylePropertyReader reader, ref ComputedStyle parentStyle) { }

	[CalledBy(Type = "UnityEngine.UIElements.StylePropertyAnimationSystem+ValuesFont", Member = "UpdateComputedStyle", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.StylePropertyAnimationSystem+ValuesFont", Member = "UpdateComputedStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(StyleDataRef`1), Member = "Write", ReturnType = "T&")]
	[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Enum), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 10)]
	public void ApplyPropertyAnimation(VisualElement ve, StylePropertyId id, Font newValue) { }

	[CalledBy(Type = "UnityEngine.UIElements.StylePropertyAnimationSystem+ValuesLength", Member = "UpdateComputedStyle", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.StylePropertyAnimationSystem+ValuesLength", Member = "UpdateComputedStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(LayoutNode), Member = "set_MarginLeft", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutValue)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(LayoutNode), Member = "set_PaddingTop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutValue)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(LayoutNode), Member = "set_PaddingRight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutValue)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(LayoutNode), Member = "set_PaddingLeft", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutValue)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(LayoutNode), Member = "set_PaddingBottom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutValue)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(LayoutNode), Member = "set_MinWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutValue)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(LayoutNode), Member = "set_MinHeight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutValue)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(LayoutNode), Member = "set_MaxWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutValue)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(LayoutNode), Member = "set_MaxHeight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutValue)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(LayoutNode), Member = "set_MarginTop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutValue)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(LayoutNode), Member = "set_MarginRight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutValue)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(LayoutNode), Member = "set_MarginBottom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutValue)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(LayoutNode), Member = "set_Right", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutValue)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(LayoutNode), Member = "set_Left", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutValue)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(LayoutNode), Member = "set_Height", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutValue)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(LayoutNode), Member = "set_FlexBasis", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutValue)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(LayoutNode), Member = "set_Bottom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutValue)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StyleValueExtensions), Member = "ToLayoutValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Length)}, ReturnType = typeof(LayoutValue))]
	[Calls(Type = typeof(VisualElement), Member = "get_layoutNode", ReturnType = typeof(LayoutNode&))]
	[Calls(Type = typeof(UnityEngine.UIElements.StyleDataRef`1<UnityEngine.UIElements.LayoutData>), Member = "Write", ReturnType = typeof(LayoutData&))]
	[Calls(Type = typeof(StyleDataRef`1), Member = "Write", ReturnType = "T&")]
	[Calls(Type = typeof(LayoutNode), Member = "set_Width", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutValue)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(LayoutNode), Member = "set_Top", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutValue)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[ContainsInvalidInstructions]
	public void ApplyPropertyAnimation(VisualElement ve, StylePropertyId id, Length newValue) { }

	[CalledBy(Type = "UnityEngine.UIElements.StylePropertyAnimationSystem+ValuesBackground", Member = "UpdateComputedStyle", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.StylePropertyAnimationSystem+ValuesBackground", Member = "UpdateComputedStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
	[Calls(Type = typeof(Background), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Background), typeof(Background)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(UnityEngine.UIElements.StyleDataRef`1<UnityEngine.UIElements.VisualData>), Member = "Write", ReturnType = typeof(VisualData&))]
	[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Enum), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 10)]
	public void ApplyPropertyAnimation(VisualElement ve, StylePropertyId id, Background newValue) { }

	[CalledBy(Type = "UnityEngine.UIElements.StylePropertyAnimationSystem+ValuesColor", Member = "UpdateComputedStyle", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.StylePropertyAnimationSystem+ValuesColor", Member = "UpdateComputedStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.UIElements.StyleDataRef`1<UnityEngine.UIElements.RareData>), Member = "Write", ReturnType = typeof(RareData&))]
	[Calls(Type = typeof(UnityEngine.UIElements.StyleDataRef`1<UnityEngine.UIElements.VisualData>), Member = "Write", ReturnType = typeof(VisualData&))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsInvalidInstructions]
	public void ApplyPropertyAnimation(VisualElement ve, StylePropertyId id, Color newValue) { }

	[CalledBy(Type = "UnityEngine.UIElements.StylePropertyAnimationSystem+ValuesBackgroundSize", Member = "UpdateComputedStyle", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.StylePropertyAnimationSystem+ValuesBackgroundSize", Member = "UpdateComputedStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.UIElements.StyleDataRef`1<UnityEngine.UIElements.VisualData>), Member = "Write", ReturnType = typeof(VisualData&))]
	[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Enum), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 9)]
	public void ApplyPropertyAnimation(VisualElement ve, StylePropertyId id, BackgroundSize newValue) { }

	[CalledBy(Type = "UnityEngine.UIElements.StylePropertyAnimationSystem+ValuesBackgroundRepeat", Member = "UpdateComputedStyle", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.StylePropertyAnimationSystem+ValuesBackgroundRepeat", Member = "UpdateComputedStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
	[Calls(Type = typeof(BackgroundRepeat), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BackgroundRepeat), typeof(BackgroundRepeat)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(UnityEngine.UIElements.StyleDataRef`1<UnityEngine.UIElements.VisualData>), Member = "Write", ReturnType = typeof(VisualData&))]
	[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Enum), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 9)]
	public void ApplyPropertyAnimation(VisualElement ve, StylePropertyId id, BackgroundRepeat newValue) { }

	[CalledBy(Type = "UnityEngine.UIElements.StylePropertyAnimationSystem+ValuesBackgroundPosition", Member = "UpdateComputedStyle", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.StylePropertyAnimationSystem+ValuesBackgroundPosition", Member = "UpdateComputedStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
	[Calls(Type = typeof(BackgroundPosition), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BackgroundPosition), typeof(BackgroundPosition)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(UnityEngine.UIElements.StyleDataRef`1<UnityEngine.UIElements.VisualData>), Member = "Write", ReturnType = typeof(VisualData&))]
	[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Enum), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 9)]
	public void ApplyPropertyAnimation(VisualElement ve, StylePropertyId id, BackgroundPosition newValue) { }

	[CalledBy(Type = "UnityEngine.UIElements.StylePropertyAnimationSystem+ValuesInt", Member = "UpdateComputedStyle", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.StylePropertyAnimationSystem+ValuesInt", Member = "UpdateComputedStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.StylePropertyAnimationSystem+ValuesEnum", Member = "UpdateComputedStyle", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.StylePropertyAnimationSystem+ValuesEnum", Member = "UpdateComputedStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Enum), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(LayoutNode), Member = "set_AlignContent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutAlign)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(LayoutNode), Member = "set_AlignItems", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutAlign)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(LayoutNode), Member = "set_AlignSelf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutAlign)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StyleDataRef`1), Member = "Write", ReturnType = "T&")]
	[Calls(Type = typeof(LayoutNode), Member = "set_JustifyContent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutJustify)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(LayoutNode), Member = "set_Overflow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutOverflow)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(LayoutNode), Member = "set_FlexDirection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutFlexDirection)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UnityEngine.UIElements.StyleDataRef`1<UnityEngine.UIElements.VisualData>), Member = "Write", ReturnType = typeof(VisualData&))]
	[Calls(Type = typeof(UnityEngine.UIElements.StyleDataRef`1<UnityEngine.UIElements.RareData>), Member = "Write", ReturnType = typeof(RareData&))]
	[Calls(Type = typeof(LayoutNode), Member = "set_PositionType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutPositionType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "get_layoutNode", ReturnType = typeof(LayoutNode&))]
	[Calls(Type = typeof(UnityEngine.UIElements.StyleDataRef`1<UnityEngine.UIElements.LayoutData>), Member = "Write", ReturnType = typeof(LayoutData&))]
	[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
	[Calls(Type = typeof(LayoutNode), Member = "set_Wrap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutWrap)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 10)]
	public void ApplyPropertyAnimation(VisualElement ve, StylePropertyId id, int newValue) { }

	[CalledBy(Type = "UnityEngine.UIElements.StylePropertyAnimationSystem+ValuesFloat", Member = "UpdateComputedStyle", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.StylePropertyAnimationSystem+ValuesFloat", Member = "UpdateComputedStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Enum), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(LayoutNode), Member = "set_FlexShrink", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(LayoutNode), Member = "set_FlexGrow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(LayoutNode), Member = "set_BorderTopWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(LayoutNode), Member = "set_BorderRightWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(LayoutNode), Member = "set_BorderLeftWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(LayoutNode), Member = "set_BorderBottomWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "get_layoutNode", ReturnType = typeof(LayoutNode&))]
	[Calls(Type = typeof(UnityEngine.UIElements.StyleDataRef`1<UnityEngine.UIElements.LayoutData>), Member = "Write", ReturnType = typeof(LayoutData&))]
	[Calls(Type = typeof(StyleDataRef`1), Member = "Write", ReturnType = "T&")]
	[Calls(Type = typeof(UnityEngine.UIElements.StyleDataRef`1<UnityEngine.UIElements.VisualData>), Member = "Write", ReturnType = typeof(VisualData&))]
	[Calls(Type = typeof(UnityEngine.UIElements.StyleDataRef`1<UnityEngine.UIElements.RareData>), Member = "Write", ReturnType = typeof(RareData&))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 10)]
	public void ApplyPropertyAnimation(VisualElement ve, StylePropertyId id, float newValue) { }

	[CalledBy(Type = "UnityEngine.UIElements.StylePropertyAnimationSystem+ValuesRotate", Member = "UpdateComputedStyle", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.StylePropertyAnimationSystem+ValuesRotate", Member = "UpdateComputedStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.UIElements.StyleDataRef`1<UnityEngine.UIElements.TransformData>), Member = "Write", ReturnType = typeof(TransformData&))]
	[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Enum), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 9)]
	public void ApplyPropertyAnimation(VisualElement ve, StylePropertyId id, Rotate newValue) { }

	[CalledBy(Type = "UnityEngine.UIElements.StylePropertyAnimationSystem+ValuesTransformOrigin", Member = "UpdateComputedStyle", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.StylePropertyAnimationSystem+ValuesTransformOrigin", Member = "UpdateComputedStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.UIElements.StyleDataRef`1<UnityEngine.UIElements.TransformData>), Member = "Write", ReturnType = typeof(TransformData&))]
	[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Enum), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 9)]
	public void ApplyPropertyAnimation(VisualElement ve, StylePropertyId id, TransformOrigin newValue) { }

	[CalledBy(Type = "UnityEngine.UIElements.StylePropertyAnimationSystem+ValuesFontDefinition", Member = "UpdateComputedStyle", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.StylePropertyAnimationSystem+ValuesFontDefinition", Member = "UpdateComputedStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
	[Calls(Type = typeof(FontDefinition), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FontDefinition), typeof(FontDefinition)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(StyleDataRef`1), Member = "Write", ReturnType = "T&")]
	[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Enum), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 10)]
	public void ApplyPropertyAnimation(VisualElement ve, StylePropertyId id, FontDefinition newValue) { }

	[CalledBy(Type = "UnityEngine.UIElements.StylePropertyAnimationSystem+ValuesScale", Member = "UpdateComputedStyle", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.StylePropertyAnimationSystem+ValuesScale", Member = "UpdateComputedStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.UIElements.StyleDataRef`1<UnityEngine.UIElements.TransformData>), Member = "Write", ReturnType = typeof(TransformData&))]
	[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Enum), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 9)]
	public void ApplyPropertyAnimation(VisualElement ve, StylePropertyId id, Scale newValue) { }

	[CalledBy(Type = "UnityEngine.UIElements.StylePropertyAnimationSystem+ValuesTranslate", Member = "UpdateComputedStyle", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.StylePropertyAnimationSystem+ValuesTranslate", Member = "UpdateComputedStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.UIElements.StyleDataRef`1<UnityEngine.UIElements.TransformData>), Member = "Write", ReturnType = typeof(TransformData&))]
	[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Enum), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 9)]
	public void ApplyPropertyAnimation(VisualElement ve, StylePropertyId id, Translate newValue) { }

	[CalledBy(Type = "UnityEngine.UIElements.StylePropertyAnimationSystem+ValuesTextShadow", Member = "UpdateComputedStyle", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.StylePropertyAnimationSystem+ValuesTextShadow", Member = "UpdateComputedStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(StyleDataRef`1), Member = "Write", ReturnType = "T&")]
	[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Enum), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 9)]
	public void ApplyPropertyAnimation(VisualElement ve, StylePropertyId id, TextShadow newValue) { }

	[CalledBy(Type = typeof(InlineStyleAccess), Member = "ApplyInlineStyles", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "ApplyStyleBackgroundSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleBackgroundSize)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.UIElements.StyleDataRef`1<UnityEngine.UIElements.VisualData>), Member = "Write", ReturnType = typeof(VisualData&))]
	public void ApplyStyleBackgroundSize(BackgroundSize backgroundSizeValue) { }

	[CalledBy(Type = typeof(InlineStyleAccess), Member = "ApplyInlineStyles", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "ApplyStyleCursor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleCursor)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.UIElements.StyleDataRef`1<UnityEngine.UIElements.RareData>), Member = "Write", ReturnType = typeof(RareData&))]
	[CallsUnknownMethods(Count = 1)]
	public void ApplyStyleCursor(Cursor cursor) { }

	[CalledBy(Type = typeof(InlineStyleAccess), Member = "ApplyInlineStyles", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "ApplyStyleRotate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleRotate)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.UIElements.StyleDataRef`1<UnityEngine.UIElements.TransformData>), Member = "Write", ReturnType = typeof(TransformData&))]
	public void ApplyStyleRotate(Rotate rotateValue) { }

	[CalledBy(Type = typeof(InlineStyleAccess), Member = "ApplyInlineStyles", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "ApplyStyleScale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleScale)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.UIElements.StyleDataRef`1<UnityEngine.UIElements.TransformData>), Member = "Write", ReturnType = typeof(TransformData&))]
	public void ApplyStyleScale(Scale scaleValue) { }

	[CalledBy(Type = typeof(InlineStyleAccess), Member = "ApplyInlineStyles", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "ApplyStyleTextShadow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleTextShadow)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(StyleDataRef`1), Member = "Write", ReturnType = "T&")]
	public void ApplyStyleTextShadow(TextShadow st) { }

	[CalledBy(Type = typeof(InlineStyleAccess), Member = "ApplyInlineStyles", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "ApplyStyleTransformOrigin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleTransformOrigin)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.UIElements.StyleDataRef`1<UnityEngine.UIElements.TransformData>), Member = "Write", ReturnType = typeof(TransformData&))]
	public void ApplyStyleTransformOrigin(TransformOrigin st) { }

	[CalledBy(Type = typeof(InlineStyleAccess), Member = "ApplyInlineStyles", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "ApplyStyleTranslate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleTranslate)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.UIElements.StyleDataRef`1<UnityEngine.UIElements.TransformData>), Member = "Write", ReturnType = typeof(TransformData&))]
	public void ApplyStyleTranslate(Translate translateValue) { }

	[CalledBy(Type = typeof(InlineStyleAccess), Member = "ApplyInlineStyles", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "ApplyStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleValue)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ComputedStyle), Member = "ApplyInitialValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(void))]
	[ContainsInvalidInstructions]
	public void ApplyStyleValue(StyleValue sv, ref ComputedStyle parentStyle) { }

	[CalledBy(Type = typeof(InlineStyleAccess), Member = "ApplyInlineStyles", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "ApplyStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleValueManaged)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ComputedStyle), Member = "ApplyInitialValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Debug), Member = "LogAssertion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UnityEngine.UIElements.StyleDataRef`1<UnityEngine.UIElements.TransitionData>), Member = "Write", ReturnType = typeof(TransitionData&))]
	[Calls(Type = typeof(InitialStyle), Member = "get_transitionTimingFunction", ReturnType = typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.EasingFunction>))]
	[Calls(Type = typeof(StyleValueExtensions), Member = "CopyFrom", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.List`1<T>", "System.Collections.Generic.List`1<T>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InitialStyle), Member = "get_transitionProperty", ReturnType = typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.StylePropertyName>))]
	[Calls(Type = typeof(StyleValueExtensions), Member = "CopyFrom", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyName)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.StylePropertyName>), typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.StylePropertyName>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InitialStyle), Member = "get_transitionDuration", ReturnType = typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.TimeValue>))]
	[Calls(Type = typeof(InitialStyle), Member = "get_transitionDelay", ReturnType = typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.TimeValue>))]
	[Calls(Type = typeof(StyleValueExtensions), Member = "CopyFrom", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeValue)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.TimeValue>), typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.TimeValue>)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 9)]
	public void ApplyStyleValueManaged(StyleValueManaged sv, ref ComputedStyle parentStyle) { }

	[CalledBy(Type = typeof(ComputedStyle), Member = "ApplyGlobalKeyword", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyReader), typeof(ComputedStyle&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ComputedStyle), Member = "ApplyProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyReader), typeof(ComputedStyle&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Dictionary`2), Member = "ContainsKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Dictionary`2), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsInvalidInstructions]
	public void ApplyUnsetValue(StylePropertyReader reader, ref ComputedStyle parentStyle) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ComputedStyle), Member = "get_wordSpacing", ReturnType = typeof(Length))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_whiteSpace", ReturnType = typeof(WhiteSpace))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_visibility", ReturnType = typeof(Visibility))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_unityTextOutlineWidth", ReturnType = typeof(float))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_unityTextGenerator", ReturnType = typeof(TextGeneratorType))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_unityTextAlign", ReturnType = typeof(TextAnchor))]
	[Calls(Type = typeof(ComputedStyle), Member = "ApplyInitialValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_unityParagraphSpacing", ReturnType = typeof(Length))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_unityFont", ReturnType = typeof(Font))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_unityEditorTextRenderingMode", ReturnType = typeof(EditorTextRenderingMode))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_letterSpacing", ReturnType = typeof(Length))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_fontSize", ReturnType = typeof(Length))]
	[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
	[Calls(Type = typeof(StyleDataRef`1), Member = "Write", ReturnType = "T&")]
	[Calls(Type = typeof(ComputedStyle), Member = "get_unityFontStyleAndWeight", ReturnType = typeof(FontStyle))]
	[CallsUnknownMethods(Count = 3)]
	public void ApplyUnsetValue(StylePropertyId id, ref ComputedStyle parentStyle) { }

	[CalledBy(Type = typeof(VisualElement), Member = "SetComputedStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ComputedStyle), Member = "get_minWidth", ReturnType = typeof(Length))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_fontSize", ReturnType = typeof(Length))]
	[Calls(Type = typeof(FontDefinition), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FontDefinition), typeof(FontDefinition)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_whiteSpace", ReturnType = typeof(WhiteSpace))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_unityFontStyleAndWeight", ReturnType = typeof(FontStyle))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_unityTextOutlineWidth", ReturnType = typeof(float))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_letterSpacing", ReturnType = typeof(Length))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_wordSpacing", ReturnType = typeof(Length))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_unityEditorTextRenderingMode", ReturnType = typeof(EditorTextRenderingMode))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_unityParagraphSpacing", ReturnType = typeof(Length))]
	[Calls(Type = typeof(TextShadow), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextShadow), typeof(TextShadow)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Scale), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Scale), typeof(Scale)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Rotate), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rotate), typeof(Rotate)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Translate), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Translate), typeof(Translate)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TransformOrigin), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TransformOrigin), typeof(TransformOrigin)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ComputedTransitionUtils), Member = "SameTransitionProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&), typeof(ComputedStyle&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Background), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Background), typeof(Background)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BackgroundPosition), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BackgroundPosition), typeof(BackgroundPosition)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_backgroundRepeat", ReturnType = typeof(BackgroundRepeat))]
	[Calls(Type = typeof(BackgroundRepeat), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BackgroundRepeat), typeof(BackgroundRepeat)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BackgroundSize), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BackgroundSize), typeof(BackgroundSize)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_borderTopRightRadius", ReturnType = typeof(Length))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_unitySliceScale", ReturnType = typeof(float))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_unitySliceLeft", ReturnType = typeof(int))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_borderTopWidth", ReturnType = typeof(float))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_unityTextOverflowPosition", ReturnType = typeof(TextOverflowPosition))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_minHeight", ReturnType = typeof(Length))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_maxWidth", ReturnType = typeof(Length))]
	[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
	[Calls(Type = typeof(ComputedStyle), Member = "get_flexWrap", ReturnType = typeof(Wrap))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_flexDirection", ReturnType = typeof(FlexDirection))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_justifyContent", ReturnType = typeof(Justify))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_bottom", ReturnType = typeof(Length))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_left", ReturnType = typeof(Length))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_right", ReturnType = typeof(Length))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_top", ReturnType = typeof(Length))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_height", ReturnType = typeof(Length))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_width", ReturnType = typeof(Length))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_paddingBottom", ReturnType = typeof(Length))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_unitySliceRight", ReturnType = typeof(int))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_paddingLeft", ReturnType = typeof(Length))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_paddingTop", ReturnType = typeof(Length))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_marginBottom", ReturnType = typeof(Length))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_marginLeft", ReturnType = typeof(Length))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_marginRight", ReturnType = typeof(Length))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_marginTop", ReturnType = typeof(Length))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_position", ReturnType = typeof(Position))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_alignContent", ReturnType = typeof(Align))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_alignItems", ReturnType = typeof(Align))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_alignSelf", ReturnType = typeof(Align))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_flexBasis", ReturnType = typeof(Length))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_maxHeight", ReturnType = typeof(Length))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_paddingRight", ReturnType = typeof(Length))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_unitySliceTop", ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 33)]
	[ContainsUnimplementedInstructions]
	public static VersionChangeType CompareChanges(ref ComputedStyle x, ref ComputedStyle y) { }

	[CalledBy(Type = typeof(ComputedStyle), Member = "ApplyAllPropertyInitial", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ComputedStyle), Member = "ApplyInitialValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyReader)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VisualElement), Member = "SetComputedStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(StyleDataRef`1), Member = "CopyFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.StyleDataRef`1<T>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UnityEngine.UIElements.StyleDataRef`1<UnityEngine.UIElements.LayoutData>), Member = "CopyFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityEngine.UIElements.StyleDataRef`1<UnityEngine.UIElements.LayoutData>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UnityEngine.UIElements.StyleDataRef`1<UnityEngine.UIElements.RareData>), Member = "CopyFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityEngine.UIElements.StyleDataRef`1<UnityEngine.UIElements.RareData>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UnityEngine.UIElements.StyleDataRef`1<UnityEngine.UIElements.TransformData>), Member = "CopyFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityEngine.UIElements.StyleDataRef`1<UnityEngine.UIElements.TransformData>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UnityEngine.UIElements.StyleDataRef`1<UnityEngine.UIElements.TransitionData>), Member = "CopyFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityEngine.UIElements.StyleDataRef`1<UnityEngine.UIElements.TransitionData>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UnityEngine.UIElements.StyleDataRef`1<UnityEngine.UIElements.VisualData>), Member = "CopyFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityEngine.UIElements.StyleDataRef`1<UnityEngine.UIElements.VisualData>)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	public void CopyFrom(ref ComputedStyle other) { }

	[CalledBy(Type = typeof(VisualTreeStyleUpdaterTraversal), Member = "ProcessMatchedRules", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.SelectorMatchRecord>)}, ReturnType = typeof(ComputedStyle))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InitialStyle), Member = "Get", ReturnType = typeof(ComputedStyle&))]
	[Calls(Type = typeof(StyleDataRef`1), Member = "Acquire", ReturnType = "UnityEngine.UIElements.StyleDataRef`1<T>")]
	[CallsUnknownMethods(Count = 6)]
	public static ComputedStyle Create(ref ComputedStyle parentStyle) { }

	[CalledBy(Type = typeof(InitialStyle), Member = ".cctor", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(StyleDataRef`1), Member = "Create", ReturnType = "UnityEngine.UIElements.StyleDataRef`1<T>")]
	[CallsUnknownMethods(Count = 6)]
	public static ComputedStyle CreateInitial() { }

	[CalledBy(Type = typeof(VisualTreeStyleUpdaterTraversal), Member = "ProcessMatchedRules", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.SelectorMatchRecord>)}, ReturnType = typeof(ComputedStyle))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
	[Calls(Type = typeof(StyleDataRef`1), Member = "Write", ReturnType = "T&")]
	[Calls(Type = typeof(Length), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	public void FinalizeApply(ref ComputedStyle parentStyle) { }

	[CalledBy(Type = typeof(ComputedStyle), Member = "CompareChanges", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&), typeof(ComputedStyle&)}, ReturnType = typeof(VersionChangeType))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_alignContent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityEngine.UIElements.StyleEnum`1<UnityEngine.UIElements.Align>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ResolvedStyleAccess), Member = "get_alignContent", ReturnType = typeof(Align))]
	[CalledBy(Type = typeof(LayoutNode), Member = "CopyFromComputedStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
	public Align get_alignContent() { }

	[CalledBy(Type = typeof(ComputedStyle), Member = "CompareChanges", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&), typeof(ComputedStyle&)}, ReturnType = typeof(VersionChangeType))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_alignItems", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityEngine.UIElements.StyleEnum`1<UnityEngine.UIElements.Align>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ResolvedStyleAccess), Member = "get_alignItems", ReturnType = typeof(Align))]
	[CalledBy(Type = typeof(LayoutNode), Member = "CopyFromComputedStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
	public Align get_alignItems() { }

	[CalledBy(Type = typeof(ComputedStyle), Member = "CompareChanges", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&), typeof(ComputedStyle&)}, ReturnType = typeof(VersionChangeType))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_alignSelf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityEngine.UIElements.StyleEnum`1<UnityEngine.UIElements.Align>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ResolvedStyleAccess), Member = "get_alignSelf", ReturnType = typeof(Align))]
	[CalledBy(Type = typeof(LayoutNode), Member = "CopyFromComputedStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
	public Align get_alignSelf() { }

	[CalledBy(Type = typeof(ResolvedStyleAccess), Member = "get_backgroundColor", ReturnType = typeof(Color))]
	[CalledBy(Type = typeof(DefaultElementBuilder), Member = "DrawVisualElementBackground", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshGenerationContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
	public Color get_backgroundColor() { }

	[CalledBy(Type = typeof(UIRUtility), Member = "IsVectorImageBackground", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ResolvedStyleAccess), Member = "get_backgroundImage", ReturnType = typeof(Background))]
	[CalledBy(Type = typeof(DefaultElementBuilder), Member = "DrawVisualElementBackground", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshGenerationContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
	public Background get_backgroundImage() { }

	[CalledBy(Type = typeof(ResolvedStyleAccess), Member = "get_backgroundPositionX", ReturnType = typeof(BackgroundPosition))]
	[CalledBy(Type = typeof(DefaultElementBuilder), Member = "DrawVisualElementBackground", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshGenerationContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
	public BackgroundPosition get_backgroundPositionX() { }

	[CalledBy(Type = typeof(ResolvedStyleAccess), Member = "get_backgroundPositionY", ReturnType = typeof(BackgroundPosition))]
	[CalledBy(Type = typeof(DefaultElementBuilder), Member = "DrawVisualElementBackground", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshGenerationContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
	public BackgroundPosition get_backgroundPositionY() { }

	[CalledBy(Type = typeof(ComputedStyle), Member = "CompareChanges", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&), typeof(ComputedStyle&)}, ReturnType = typeof(VersionChangeType))]
	[CalledBy(Type = typeof(ResolvedStyleAccess), Member = "get_backgroundRepeat", ReturnType = typeof(BackgroundRepeat))]
	[CalledBy(Type = typeof(DefaultElementBuilder), Member = "DrawVisualElementBackground", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshGenerationContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
	public BackgroundRepeat get_backgroundRepeat() { }

	[CalledBy(Type = typeof(ResolvedStyleAccess), Member = "get_backgroundSize", ReturnType = typeof(BackgroundSize))]
	[CalledBy(Type = typeof(DefaultElementBuilder), Member = "DrawVisualElementBackground", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshGenerationContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
	public BackgroundSize get_backgroundSize() { }

	[CalledBy(Type = typeof(ResolvedStyleAccess), Member = "get_borderBottomColor", ReturnType = typeof(Color))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
	public Color get_borderBottomColor() { }

	[CalledBy(Type = typeof(ResolvedStyleAccess), Member = "get_borderBottomLeftRadius", ReturnType = typeof(float))]
	[CalledBy(Type = typeof(MeshGenerator), Member = "GetVisualElementRadii", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(Vector2&), typeof(Vector2&), typeof(Vector2&), typeof(Vector2&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
	public Length get_borderBottomLeftRadius() { }

	[CalledBy(Type = typeof(ResolvedStyleAccess), Member = "get_borderBottomRightRadius", ReturnType = typeof(float))]
	[CalledBy(Type = typeof(MeshGenerator), Member = "GetVisualElementRadii", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(Vector2&), typeof(Vector2&), typeof(Vector2&), typeof(Vector2&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
	public Length get_borderBottomRightRadius() { }

	[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_borderBottomWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleFloat)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LayoutNode), Member = "CopyFromComputedStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
	public float get_borderBottomWidth() { }

	[CalledBy(Type = typeof(ResolvedStyleAccess), Member = "get_borderLeftColor", ReturnType = typeof(Color))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
	public Color get_borderLeftColor() { }

	[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_borderLeftWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleFloat)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LayoutNode), Member = "CopyFromComputedStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
	public float get_borderLeftWidth() { }

	[CalledBy(Type = typeof(ResolvedStyleAccess), Member = "get_borderRightColor", ReturnType = typeof(Color))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
	public Color get_borderRightColor() { }

	[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_borderRightWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleFloat)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LayoutNode), Member = "CopyFromComputedStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
	public float get_borderRightWidth() { }

	[CalledBy(Type = typeof(ResolvedStyleAccess), Member = "get_borderTopColor", ReturnType = typeof(Color))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
	public Color get_borderTopColor() { }

	[CalledBy(Type = typeof(ResolvedStyleAccess), Member = "get_borderTopLeftRadius", ReturnType = typeof(float))]
	[CalledBy(Type = typeof(MeshGenerator), Member = "GetVisualElementRadii", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(Vector2&), typeof(Vector2&), typeof(Vector2&), typeof(Vector2&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
	public Length get_borderTopLeftRadius() { }

	[CalledBy(Type = typeof(ComputedStyle), Member = "CompareChanges", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&), typeof(ComputedStyle&)}, ReturnType = typeof(VersionChangeType))]
	[CalledBy(Type = typeof(ResolvedStyleAccess), Member = "get_borderTopRightRadius", ReturnType = typeof(float))]
	[CalledBy(Type = typeof(MeshGenerator), Member = "GetVisualElementRadii", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(Vector2&), typeof(Vector2&), typeof(Vector2&), typeof(Vector2&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
	public Length get_borderTopRightRadius() { }

	[CalledBy(Type = typeof(ComputedStyle), Member = "CompareChanges", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&), typeof(ComputedStyle&)}, ReturnType = typeof(VersionChangeType))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_borderTopWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleFloat)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LayoutNode), Member = "CopyFromComputedStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
	public float get_borderTopWidth() { }

	[CalledBy(Type = typeof(ComputedStyle), Member = "CompareChanges", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&), typeof(ComputedStyle&)}, ReturnType = typeof(VersionChangeType))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_bottom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleLength)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LayoutNode), Member = "CopyFromComputedStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
	public Length get_bottom() { }

	[CalledBy(Type = typeof(ResolvedStyleAccess), Member = "get_color", ReturnType = typeof(Color))]
	[CalledBy(Type = typeof(UITKTextHandle), Member = "ConvertUssToNativeTextGenerationSettings", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(UITKTextHandle), Member = "ConvertUssToTextGenerationSettings", ReturnType = typeof(bool))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
	public Color get_color() { }

	[CalledBy(Type = typeof(VisualElement), Member = "SetComputedStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VisualElement), Member = "UpdateCursorStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ATGTextEventHandler), Member = "HyperlinkOnPointerMove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerMoveEvent)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextEventHandler), Member = "ATagOnPointerMove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerMoveEvent)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
	public Cursor get_cursor() { }

	[CalledBy(Type = typeof(VisualTreeStyleUpdaterTraversal), Member = "TraverseRecursive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Dictionary`2), Member = "get_Count", ReturnType = typeof(int))]
	public int get_customPropertiesCount() { }

	[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_display", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityEngine.UIElements.StyleEnum`1<UnityEngine.UIElements.DisplayStyle>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ResolvedStyleAccess), Member = "get_display", ReturnType = typeof(DisplayStyle))]
	[CalledBy(Type = typeof(LayoutNode), Member = "CopyFromComputedStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
	public DisplayStyle get_display() { }

	[CalledBy(Type = typeof(ComputedStyle), Member = "CompareChanges", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&), typeof(ComputedStyle&)}, ReturnType = typeof(VersionChangeType))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_flexBasis", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleLength)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LayoutNode), Member = "CopyFromComputedStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
	public Length get_flexBasis() { }

	[CalledBy(Type = typeof(ComputedStyle), Member = "CompareChanges", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&), typeof(ComputedStyle&)}, ReturnType = typeof(VersionChangeType))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_flexDirection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityEngine.UIElements.StyleEnum`1<UnityEngine.UIElements.FlexDirection>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ResolvedStyleAccess), Member = "get_flexDirection", ReturnType = typeof(FlexDirection))]
	[CalledBy(Type = typeof(LayoutNode), Member = "CopyFromComputedStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
	public FlexDirection get_flexDirection() { }

	[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_flexGrow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleFloat)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ResolvedStyleAccess), Member = "get_flexGrow", ReturnType = typeof(float))]
	[CalledBy(Type = typeof(LayoutNode), Member = "CopyFromComputedStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
	public float get_flexGrow() { }

	[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_flexShrink", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleFloat)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ResolvedStyleAccess), Member = "get_flexShrink", ReturnType = typeof(float))]
	[CalledBy(Type = typeof(LayoutNode), Member = "CopyFromComputedStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
	public float get_flexShrink() { }

	[CalledBy(Type = typeof(ComputedStyle), Member = "CompareChanges", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&), typeof(ComputedStyle&)}, ReturnType = typeof(VersionChangeType))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_flexWrap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityEngine.UIElements.StyleEnum`1<UnityEngine.UIElements.Wrap>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ResolvedStyleAccess), Member = "get_flexWrap", ReturnType = typeof(Wrap))]
	[CalledBy(Type = typeof(LayoutNode), Member = "CopyFromComputedStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
	public Wrap get_flexWrap() { }

	[CalledBy(Type = typeof(GenericDropdownMenu), Member = "DropDown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), typeof(VisualElement), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ComputedStyle), Member = "ApplyUnsetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(ComputedStyle&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ComputedStyle), Member = "CompareChanges", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&), typeof(ComputedStyle&)}, ReturnType = typeof(VersionChangeType))]
	[CalledBy(Type = typeof(ResolvedStyleAccess), Member = "get_fontSize", ReturnType = typeof(float))]
	[CalledBy(Type = typeof(UITKTextHandle), Member = "ConvertUssToNativeTextGenerationSettings", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(UITKTextHandle), Member = "ConvertUssToTextGenerationSettings", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(UITKTextHandle), Member = "GetVertexPadding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FontAsset)}, ReturnType = typeof(float))]
	[CalledBy(Type = typeof(TextUtilities), Member = "GetTextCoreSettingsForElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(bool)}, ReturnType = typeof(TextCoreSettings))]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
	public Length get_fontSize() { }

	[CalledBy(Type = typeof(InlineStyleAccess), Member = "ApplyStyleTextShadow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleTextShadow)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "ApplyStyleTransformOrigin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleTransformOrigin)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "ApplyStyleTranslate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleTranslate)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "ApplyStyleScale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleScale)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "ApplyStyleRotate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleRotate)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "ApplyStyleBackgroundSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleBackgroundSize)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "ApplyStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleValue)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "ApplyFromComputedStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(ComputedStyle&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VisualTreeStyleUpdaterTraversal), Member = "TraverseRecursive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 9)]
	[ContainsUnimplementedInstructions]
	public bool get_hasTransition() { }

	[CalledBy(Type = typeof(ComputedStyle), Member = "CompareChanges", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&), typeof(ComputedStyle&)}, ReturnType = typeof(VersionChangeType))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_height", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleLength)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextElement), Member = "UnityEngine.UIElements.INotifyValueChanged<System.String>.SetValueWithoutNotify", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LayoutNode), Member = "CopyFromComputedStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
	public Length get_height() { }

	[CalledBy(Type = typeof(ComputedStyle), Member = "CompareChanges", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&), typeof(ComputedStyle&)}, ReturnType = typeof(VersionChangeType))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_justifyContent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityEngine.UIElements.StyleEnum`1<UnityEngine.UIElements.Justify>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ResolvedStyleAccess), Member = "get_justifyContent", ReturnType = typeof(Justify))]
	[CalledBy(Type = typeof(LayoutNode), Member = "CopyFromComputedStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
	public Justify get_justifyContent() { }

	[CalledBy(Type = typeof(ComputedStyle), Member = "CompareChanges", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&), typeof(ComputedStyle&)}, ReturnType = typeof(VersionChangeType))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_left", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleLength)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LayoutNode), Member = "CopyFromComputedStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
	public Length get_left() { }

	[CalledBy(Type = typeof(ComputedStyle), Member = "ApplyUnsetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(ComputedStyle&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ComputedStyle), Member = "CompareChanges", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&), typeof(ComputedStyle&)}, ReturnType = typeof(VersionChangeType))]
	[CalledBy(Type = typeof(ResolvedStyleAccess), Member = "get_letterSpacing", ReturnType = typeof(float))]
	[CalledBy(Type = typeof(UITKTextHandle), Member = "ConvertUssToNativeTextGenerationSettings", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(UITKTextHandle), Member = "ConvertUssToTextGenerationSettings", ReturnType = typeof(bool))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
	public Length get_letterSpacing() { }

	[CalledBy(Type = typeof(ComputedStyle), Member = "CompareChanges", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&), typeof(ComputedStyle&)}, ReturnType = typeof(VersionChangeType))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_marginBottom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleLength)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LayoutNode), Member = "CopyFromComputedStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
	public Length get_marginBottom() { }

	[CalledBy(Type = typeof(ComputedStyle), Member = "CompareChanges", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&), typeof(ComputedStyle&)}, ReturnType = typeof(VersionChangeType))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_marginLeft", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleLength)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LayoutNode), Member = "CopyFromComputedStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
	public Length get_marginLeft() { }

	[CalledBy(Type = typeof(ComputedStyle), Member = "CompareChanges", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&), typeof(ComputedStyle&)}, ReturnType = typeof(VersionChangeType))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_marginRight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleLength)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LayoutNode), Member = "CopyFromComputedStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
	public Length get_marginRight() { }

	[CalledBy(Type = typeof(ComputedStyle), Member = "CompareChanges", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&), typeof(ComputedStyle&)}, ReturnType = typeof(VersionChangeType))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_marginTop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleLength)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LayoutNode), Member = "CopyFromComputedStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
	public Length get_marginTop() { }

	[CalledBy(Type = typeof(ComputedStyle), Member = "CompareChanges", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&), typeof(ComputedStyle&)}, ReturnType = typeof(VersionChangeType))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_maxHeight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleLength)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ResolvedStyleAccess), Member = "get_maxHeight", ReturnType = typeof(StyleFloat))]
	[CalledBy(Type = typeof(LayoutNode), Member = "CopyFromComputedStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
	public Length get_maxHeight() { }

	[CalledBy(Type = typeof(ComputedStyle), Member = "CompareChanges", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&), typeof(ComputedStyle&)}, ReturnType = typeof(VersionChangeType))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_maxWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleLength)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ResolvedStyleAccess), Member = "get_maxWidth", ReturnType = typeof(StyleFloat))]
	[CalledBy(Type = typeof(LayoutNode), Member = "CopyFromComputedStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
	public Length get_maxWidth() { }

	[CalledBy(Type = typeof(ComputedStyle), Member = "CompareChanges", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&), typeof(ComputedStyle&)}, ReturnType = typeof(VersionChangeType))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_minHeight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleLength)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ResolvedStyleAccess), Member = "get_minHeight", ReturnType = typeof(StyleFloat))]
	[CalledBy(Type = typeof(LayoutNode), Member = "CopyFromComputedStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
	public Length get_minHeight() { }

	[CalledBy(Type = typeof(ComputedStyle), Member = "CompareChanges", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&), typeof(ComputedStyle&)}, ReturnType = typeof(VersionChangeType))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_minWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleLength)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ResolvedStyleAccess), Member = "get_minWidth", ReturnType = typeof(StyleFloat))]
	[CalledBy(Type = typeof(LayoutNode), Member = "CopyFromComputedStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
	public Length get_minWidth() { }

	[CalledBy(Type = typeof(ResolvedStyleAccess), Member = "get_opacity", ReturnType = typeof(float))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
	public float get_opacity() { }

	[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_overflow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityEngine.UIElements.StyleEnum`1<UnityEngine.UIElements.Overflow>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VisualElement), Member = "UpdateBoundingBox", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VisualElement), Member = "UpdateLocalBoundsAndPickingBounds3D", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VisualElement), Member = "UpdateWorldClip", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VisualElement), Member = "ShouldClip", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(UITKTextHandle), Member = "ConvertUssToNativeTextGenerationSettings", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(UITKTextHandle), Member = "GetTextOverflowMode", ReturnType = "UnityEngine.TextCore.Text.TextOverflowMode")]
	[CalledBy(Type = typeof(UITKTextHandle), Member = "ConvertUssToTextGenerationSettings", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TextElement), Member = "OnGenerateTextOver", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshGenerationContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextElement), Member = "OnGenerateTextOverNative", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshGenerationContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextElement), Member = "UpdateVisibleText", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextElement), Member = "ShouldElide", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(LayoutNode), Member = "CopyFromComputedStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle)}, ReturnType = typeof(void))]
	[CallerCount(Count = 13)]
	[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
	public OverflowInternal get_overflow() { }

	[CalledBy(Type = typeof(ComputedStyle), Member = "CompareChanges", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&), typeof(ComputedStyle&)}, ReturnType = typeof(VersionChangeType))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_paddingBottom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleLength)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LayoutNode), Member = "CopyFromComputedStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
	public Length get_paddingBottom() { }

	[CalledBy(Type = typeof(ComputedStyle), Member = "CompareChanges", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&), typeof(ComputedStyle&)}, ReturnType = typeof(VersionChangeType))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_paddingLeft", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleLength)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LayoutNode), Member = "CopyFromComputedStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
	public Length get_paddingLeft() { }

	[CalledBy(Type = typeof(ComputedStyle), Member = "CompareChanges", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&), typeof(ComputedStyle&)}, ReturnType = typeof(VersionChangeType))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_paddingRight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleLength)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LayoutNode), Member = "CopyFromComputedStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
	public Length get_paddingRight() { }

	[CalledBy(Type = typeof(ComputedStyle), Member = "CompareChanges", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&), typeof(ComputedStyle&)}, ReturnType = typeof(VersionChangeType))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_paddingTop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleLength)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LayoutNode), Member = "CopyFromComputedStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
	public Length get_paddingTop() { }

	[CalledBy(Type = typeof(ComputedStyle), Member = "CompareChanges", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&), typeof(ComputedStyle&)}, ReturnType = typeof(VersionChangeType))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_position", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityEngine.UIElements.StyleEnum`1<UnityEngine.UIElements.Position>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ResolvedStyleAccess), Member = "get_position", ReturnType = typeof(Position))]
	[CalledBy(Type = typeof(LayoutNode), Member = "CopyFromComputedStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
	public Position get_position() { }

	[CalledBy(Type = typeof(ComputedStyle), Member = "CompareChanges", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&), typeof(ComputedStyle&)}, ReturnType = typeof(VersionChangeType))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_right", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleLength)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LayoutNode), Member = "CopyFromComputedStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
	public Length get_right() { }

	[CalledBy(Type = typeof(UIRLayoutUpdater), Member = "UpdateSubTree", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(System.Collections.Generic.List`1<System.ValueTuple`3<UnityEngine.Rect, UnityEngine.Rect, UnityEngine.UIElements.VisualElement>>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ResolvedStyleAccess), Member = "get_rotate", ReturnType = typeof(Rotate))]
	[CalledBy(Type = typeof(VisualElement), Member = "GetPivotedMatrixWithLayout", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Matrix4x4&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VisualElement), Member = "get_hasDefaultRotationAndScale", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(VisualElement), Member = "get_has3DTransform", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(VisualElement), Member = "get_has3DRotation", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(VisualElement), Member = "ResolveRotation", ReturnType = typeof(Quaternion))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
	public Rotate get_rotate() { }

	[CalledBy(Type = typeof(UIRLayoutUpdater), Member = "UpdateSubTree", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(System.Collections.Generic.List`1<System.ValueTuple`3<UnityEngine.Rect, UnityEngine.Rect, UnityEngine.UIElements.VisualElement>>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ResolvedStyleAccess), Member = "get_scale", ReturnType = typeof(Scale))]
	[CalledBy(Type = typeof(VisualElement), Member = "GetPivotedMatrixWithLayout", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Matrix4x4&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VisualElement), Member = "get_hasDefaultRotationAndScale", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(VisualElement), Member = "ResolveScale", ReturnType = typeof(Vector3))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
	public Scale get_scale() { }

	[CalledBy(Type = typeof(ResolvedStyleAccess), Member = "get_textOverflow", ReturnType = typeof(TextOverflow))]
	[CalledBy(Type = typeof(UITKTextHandle), Member = "ConvertUssToNativeTextGenerationSettings", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(UITKTextHandle), Member = "GetTextOverflowMode", ReturnType = "UnityEngine.TextCore.Text.TextOverflowMode")]
	[CalledBy(Type = typeof(UITKTextHandle), Member = "ConvertUssToTextGenerationSettings", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TextElement), Member = "OnGenerateTextOver", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshGenerationContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextElement), Member = "OnGenerateTextOverNative", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshGenerationContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextElement), Member = "UpdateVisibleText", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextElement), Member = "ShouldElide", ReturnType = typeof(bool))]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
	public TextOverflow get_textOverflow() { }

	[CalledBy(Type = typeof(UITKTextHandle), Member = "GetVertexPadding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FontAsset)}, ReturnType = typeof(float))]
	[CalledBy(Type = typeof(TextUtilities), Member = "GetTextCoreSettingsForElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(bool)}, ReturnType = typeof(TextCoreSettings))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
	public TextShadow get_textShadow() { }

	[CalledBy(Type = typeof(ComputedStyle), Member = "CompareChanges", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&), typeof(ComputedStyle&)}, ReturnType = typeof(VersionChangeType))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_top", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleLength)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LayoutNode), Member = "CopyFromComputedStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
	public Length get_top() { }

	[CalledBy(Type = typeof(VisualElement), Member = "ResolveTransformOrigin", ReturnType = typeof(Vector3))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
	public TransformOrigin get_transformOrigin() { }

	[CalledBy(Type = typeof(ComputedTransitionUtils), Member = "GetTransitionHashCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(ComputedTransitionUtils), Member = "SameTransitionProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&), typeof(ComputedStyle&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ComputedTransitionUtils), Member = "ComputeTransitionPropertyData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&), typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.ComputedTransitionProperty>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ResolvedStyleAccess), Member = "get_transitionDelay", ReturnType = typeof(System.Collections.Generic.IEnumerable`1<UnityEngine.UIElements.TimeValue>))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
	public List<TimeValue> get_transitionDelay() { }

	[CalledBy(Type = typeof(ComputedTransitionUtils), Member = "GetTransitionHashCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(ComputedTransitionUtils), Member = "SameTransitionProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&), typeof(ComputedStyle&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ComputedTransitionUtils), Member = "ComputeTransitionPropertyData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&), typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.ComputedTransitionProperty>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ResolvedStyleAccess), Member = "get_transitionDuration", ReturnType = typeof(System.Collections.Generic.IEnumerable`1<UnityEngine.UIElements.TimeValue>))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
	public List<TimeValue> get_transitionDuration() { }

	[CalledBy(Type = typeof(ComputedTransitionUtils), Member = "GetTransitionHashCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(ComputedTransitionUtils), Member = "SameTransitionProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&), typeof(ComputedStyle&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ComputedTransitionUtils), Member = "ComputeTransitionPropertyData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&), typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.ComputedTransitionProperty>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ResolvedStyleAccess), Member = "get_transitionProperty", ReturnType = typeof(System.Collections.Generic.IEnumerable`1<UnityEngine.UIElements.StylePropertyName>))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
	public List<StylePropertyName> get_transitionProperty() { }

	[CalledBy(Type = typeof(ComputedTransitionUtils), Member = "GetTransitionHashCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(ComputedTransitionUtils), Member = "ComputeTransitionPropertyData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&), typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.ComputedTransitionProperty>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ResolvedStyleAccess), Member = "get_transitionTimingFunction", ReturnType = typeof(System.Collections.Generic.IEnumerable`1<UnityEngine.UIElements.EasingFunction>))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
	public List<EasingFunction> get_transitionTimingFunction() { }

	[CalledBy(Type = typeof(VisualElement), Member = "get_has3DTransform", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(VisualElement), Member = "get_has3DTranslation", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(VisualElement), Member = "ResolveTranslate", ReturnType = typeof(Vector3))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
	public Translate get_translate() { }

	[CalledBy(Type = typeof(ResolvedStyleAccess), Member = "get_unityBackgroundImageTintColor", ReturnType = typeof(Color))]
	[CalledBy(Type = typeof(DefaultElementBuilder), Member = "DrawVisualElementBackground", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshGenerationContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
	public Color get_unityBackgroundImageTintColor() { }

	[CalledBy(Type = typeof(ComputedStyle), Member = "ApplyUnsetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(ComputedStyle&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ComputedStyle), Member = "CompareChanges", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&), typeof(ComputedStyle&)}, ReturnType = typeof(VersionChangeType))]
	[CalledBy(Type = typeof(ResolvedStyleAccess), Member = "get_unityEditorTextRenderingMode", ReturnType = typeof(EditorTextRenderingMode))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
	public EditorTextRenderingMode get_unityEditorTextRenderingMode() { }

	[CalledBy(Type = typeof(GenericDropdownMenu), Member = "DropDown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), typeof(VisualElement), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ComputedStyle), Member = "ApplyUnsetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(ComputedStyle&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ResolvedStyleAccess), Member = "get_unityFont", ReturnType = typeof(Font))]
	[CalledBy(Type = typeof(TextUtilities), Member = "MeasureVisualElementTextSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextElement), typeof(RenderedText&), typeof(float), typeof(MeasureMode), typeof(float), typeof(MeasureMode)}, ReturnType = typeof(Vector2))]
	[CalledBy(Type = typeof(TextUtilities), Member = "GetFontAsset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(FontAsset))]
	[CalledBy(Type = typeof(TextUtilities), Member = "IsFontAssigned", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
	public Font get_unityFont() { }

	[CalledBy(Type = typeof(GenericDropdownMenu), Member = "DropDown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), typeof(VisualElement), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ResolvedStyleAccess), Member = "get_unityFontDefinition", ReturnType = typeof(FontDefinition))]
	[CalledBy(Type = "UnityEngine.UIElements.ATGTextJobSystem+GenerateTextJobData", Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ATGTextJobSystem), Member = "GenerateTextJobified", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshGenerationContext), typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextUtilities), Member = "MeasureVisualElementTextSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextElement), typeof(RenderedText&), typeof(float), typeof(MeasureMode), typeof(float), typeof(MeasureMode)}, ReturnType = typeof(Vector2))]
	[CalledBy(Type = typeof(TextUtilities), Member = "GetFontAsset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(FontAsset))]
	[CalledBy(Type = typeof(TextUtilities), Member = "IsFontAssigned", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
	public FontDefinition get_unityFontDefinition() { }

	[CalledBy(Type = typeof(ComputedStyle), Member = "ApplyUnsetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(ComputedStyle&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ComputedStyle), Member = "CompareChanges", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&), typeof(ComputedStyle&)}, ReturnType = typeof(VersionChangeType))]
	[CalledBy(Type = typeof(ResolvedStyleAccess), Member = "get_unityFontStyleAndWeight", ReturnType = typeof(FontStyle))]
	[CalledBy(Type = typeof(UITKTextHandle), Member = "ConvertUssToNativeTextGenerationSettings", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(UITKTextHandle), Member = "ConvertUssToTextGenerationSettings", ReturnType = typeof(bool))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
	public FontStyle get_unityFontStyleAndWeight() { }

	[CalledBy(Type = typeof(VisualElement), Member = "SubstractBorderPadding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect)}, ReturnType = typeof(Rect))]
	[CalledBy(Type = typeof(DefaultElementBuilder), Member = "GenerateStencilClipEntryForRoundedRectBackground", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshGenerationContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
	public OverflowClipBox get_unityOverflowClipBox() { }

	[CalledBy(Type = typeof(ComputedStyle), Member = "ApplyUnsetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(ComputedStyle&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ComputedStyle), Member = "CompareChanges", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&), typeof(ComputedStyle&)}, ReturnType = typeof(VersionChangeType))]
	[CalledBy(Type = typeof(ResolvedStyleAccess), Member = "get_unityParagraphSpacing", ReturnType = typeof(float))]
	[CalledBy(Type = typeof(UITKTextHandle), Member = "ConvertUssToNativeTextGenerationSettings", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(UITKTextHandle), Member = "ConvertUssToTextGenerationSettings", ReturnType = typeof(bool))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
	public Length get_unityParagraphSpacing() { }

	[CalledBy(Type = typeof(ResolvedStyleAccess), Member = "get_unitySliceBottom", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(DefaultElementBuilder), Member = "DrawVisualElementBackground", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshGenerationContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
	public int get_unitySliceBottom() { }

	[CalledBy(Type = typeof(ComputedStyle), Member = "CompareChanges", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&), typeof(ComputedStyle&)}, ReturnType = typeof(VersionChangeType))]
	[CalledBy(Type = typeof(ResolvedStyleAccess), Member = "get_unitySliceLeft", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(DefaultElementBuilder), Member = "DrawVisualElementBackground", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshGenerationContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
	public int get_unitySliceLeft() { }

	[CalledBy(Type = typeof(ComputedStyle), Member = "CompareChanges", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&), typeof(ComputedStyle&)}, ReturnType = typeof(VersionChangeType))]
	[CalledBy(Type = typeof(ResolvedStyleAccess), Member = "get_unitySliceRight", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(DefaultElementBuilder), Member = "DrawVisualElementBackground", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshGenerationContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
	public int get_unitySliceRight() { }

	[CalledBy(Type = typeof(ComputedStyle), Member = "CompareChanges", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&), typeof(ComputedStyle&)}, ReturnType = typeof(VersionChangeType))]
	[CalledBy(Type = typeof(ResolvedStyleAccess), Member = "get_unitySliceScale", ReturnType = typeof(float))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
	public float get_unitySliceScale() { }

	[CalledBy(Type = typeof(ComputedStyle), Member = "CompareChanges", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&), typeof(ComputedStyle&)}, ReturnType = typeof(VersionChangeType))]
	[CalledBy(Type = typeof(ResolvedStyleAccess), Member = "get_unitySliceTop", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(DefaultElementBuilder), Member = "DrawVisualElementBackground", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshGenerationContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
	public int get_unitySliceTop() { }

	[CalledBy(Type = typeof(ResolvedStyleAccess), Member = "get_unitySliceType", ReturnType = typeof(SliceType))]
	[CalledBy(Type = typeof(DefaultElementBuilder), Member = "DrawVisualElementBackground", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshGenerationContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
	public SliceType get_unitySliceType() { }

	[CalledBy(Type = typeof(ComputedStyle), Member = "ApplyUnsetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(ComputedStyle&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ResolvedStyleAccess), Member = "get_unityTextAlign", ReturnType = typeof(TextAnchor))]
	[CalledBy(Type = typeof(UITKTextHandle), Member = "ConvertUssToNativeTextGenerationSettings", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(UITKTextHandle), Member = "ConvertUssToTextGenerationSettings", ReturnType = typeof(bool))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
	public TextAnchor get_unityTextAlign() { }

	[CalledBy(Type = typeof(ComputedStyle), Member = "ApplyUnsetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(ComputedStyle&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ResolvedStyleAccess), Member = "get_unityTextGenerator", ReturnType = typeof(TextGeneratorType))]
	[CalledBy(Type = typeof(TextUtilities), Member = "IsAdvancedTextEnabledForElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
	public TextGeneratorType get_unityTextGenerator() { }

	[CalledBy(Type = typeof(ResolvedStyleAccess), Member = "get_unityTextOutlineColor", ReturnType = typeof(Color))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
	public Color get_unityTextOutlineColor() { }

	[CalledBy(Type = typeof(ComputedStyle), Member = "ApplyUnsetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(ComputedStyle&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ComputedStyle), Member = "CompareChanges", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&), typeof(ComputedStyle&)}, ReturnType = typeof(VersionChangeType))]
	[CalledBy(Type = typeof(ResolvedStyleAccess), Member = "get_unityTextOutlineWidth", ReturnType = typeof(float))]
	[CalledBy(Type = typeof(UITKTextHandle), Member = "GetVertexPadding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FontAsset)}, ReturnType = typeof(float))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
	public float get_unityTextOutlineWidth() { }

	[CalledBy(Type = typeof(ComputedStyle), Member = "CompareChanges", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&), typeof(ComputedStyle&)}, ReturnType = typeof(VersionChangeType))]
	[CalledBy(Type = typeof(ResolvedStyleAccess), Member = "get_unityTextOverflowPosition", ReturnType = typeof(TextOverflowPosition))]
	[CalledBy(Type = typeof(UITKTextHandle), Member = "ConvertUssToNativeTextGenerationSettings", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(UITKTextHandle), Member = "GetTextOverflowMode", ReturnType = "UnityEngine.TextCore.Text.TextOverflowMode")]
	[CalledBy(Type = typeof(UITKTextHandle), Member = "ConvertUssToTextGenerationSettings", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(UITKTextHandle), Member = "TextLibraryCanElide", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TextElement), Member = "UpdateVisibleText", ReturnType = typeof(void))]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
	public TextOverflowPosition get_unityTextOverflowPosition() { }

	[CalledBy(Type = typeof(ComputedStyle), Member = "ApplyUnsetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(ComputedStyle&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ResolvedStyleAccess), Member = "get_visibility", ReturnType = typeof(Visibility))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
	public Visibility get_visibility() { }

	[CalledBy(Type = typeof(TextInputBase), Member = "SetScrollViewMode", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextInputBase), Member = "SetMultilineContainerStyle", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ComputedStyle), Member = "ApplyUnsetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(ComputedStyle&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ComputedStyle), Member = "CompareChanges", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&), typeof(ComputedStyle&)}, ReturnType = typeof(VersionChangeType))]
	[CalledBy(Type = typeof(ResolvedStyleAccess), Member = "get_whiteSpace", ReturnType = typeof(WhiteSpace))]
	[CalledBy(Type = typeof(UITKTextHandle), Member = "ConvertUssToNativeTextGenerationSettings", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(UITKTextHandle), Member = "ConvertUssToTextGenerationSettings", ReturnType = typeof(bool))]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
	public WhiteSpace get_whiteSpace() { }

	[CalledBy(Type = typeof(GenericDropdownMenu), Member = "EnsureVisibilityInParent", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ComputedStyle), Member = "CompareChanges", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&), typeof(ComputedStyle&)}, ReturnType = typeof(VersionChangeType))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_width", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleLength)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextElement), Member = "UnityEngine.UIElements.INotifyValueChanged<System.String>.SetValueWithoutNotify", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LayoutNode), Member = "CopyFromComputedStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle)}, ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
	public Length get_width() { }

	[CalledBy(Type = typeof(ComputedStyle), Member = "ApplyUnsetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(ComputedStyle&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ComputedStyle), Member = "CompareChanges", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&), typeof(ComputedStyle&)}, ReturnType = typeof(VersionChangeType))]
	[CalledBy(Type = typeof(ResolvedStyleAccess), Member = "get_wordSpacing", ReturnType = typeof(float))]
	[CalledBy(Type = typeof(UITKTextHandle), Member = "ConvertUssToNativeTextGenerationSettings", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(UITKTextHandle), Member = "ConvertUssToTextGenerationSettings", ReturnType = typeof(bool))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
	[Calls(Type = typeof(System.Collections.Generic.HashSet`1<System.Object>), Member = "GetEnumerator", ReturnType = typeof(System.Collections.Generic.HashSet`1+Enumerator<System.Object>))]
	[Calls(Type = typeof(System.Collections.Generic.HashSet`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(HashSet`1), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(TimerEventScheduler), Member = "PrivateUnSchedule", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScheduledItem)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.HashSet`1<System.Object>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 21)]
	public Length get_wordSpacing() { }

	[CalledBy(Type = typeof(VisualTreeStyleUpdaterTraversal), Member = "TraverseRecursive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(StyleDataRef`1), Member = "Release", ReturnType = typeof(void))]
	public void Release() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Dictionary`2), Member = "ContainsKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Dictionary`2), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void RemoveCustomStyleProperty(StylePropertyReader reader) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private void ResetComputedTransitions() { }

	[CalledBy(Type = typeof(InlineStyleAccess), Member = "ApplyFromComputedStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(ComputedStyle&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VisualTreeStyleUpdaterTraversal), Member = "TraverseRecursive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VisualTreeStyleUpdaterTraversal), Member = "ProcessTransitions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(ComputedStyle&), typeof(ComputedStyle&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[ContainsInvalidInstructions]
	public static bool StartAnimation(VisualElement element, StylePropertyId id, ref ComputedStyle oldStyle, ref ComputedStyle newStyle, int durationMs, int delayMs, Func<Single, Single> easingCurve) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Rotate), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rotate), typeof(Rotate)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BackgroundSize), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BackgroundSize), typeof(BackgroundSize)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BackgroundRepeat), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BackgroundRepeat), typeof(BackgroundRepeat)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BackgroundPosition), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BackgroundPosition), typeof(BackgroundPosition)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Background), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Background), typeof(Background)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(UnityEngine.UIElements.StyleDataRef`1<UnityEngine.UIElements.VisualData>), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityEngine.UIElements.StyleDataRef`1<UnityEngine.UIElements.VisualData>)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Translate), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Translate), typeof(Translate)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TransformOrigin), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TransformOrigin), typeof(TransformOrigin)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Scale), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Scale), typeof(Scale)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(UnityEngine.UIElements.StyleDataRef`1<UnityEngine.UIElements.TransformData>), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityEngine.UIElements.StyleDataRef`1<UnityEngine.UIElements.TransformData>)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(UnityEngine.UIElements.StyleDataRef`1<UnityEngine.UIElements.RareData>), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityEngine.UIElements.StyleDataRef`1<UnityEngine.UIElements.RareData>)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(UnityEngine.UIElements.StyleDataRef`1<UnityEngine.UIElements.LayoutData>), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityEngine.UIElements.StyleDataRef`1<UnityEngine.UIElements.LayoutData>)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(FontDefinition), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FontDefinition), typeof(FontDefinition)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TextShadow), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextShadow), typeof(TextShadow)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(StyleDataRef`1), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.StyleDataRef`1<T>"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
	[Calls(Type = typeof(VisualElement), Member = "get_hasRunningAnimations", ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElement), Member = "get_usageHints", ReturnType = typeof(UsageHints))]
	[Calls(Type = typeof(VisualElement), Member = "set_usageHints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UsageHints)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 108)]
	[CallsUnknownMethods(Count = 77)]
	[ContainsUnimplementedInstructions]
	public static bool StartAnimationAllProperty(VisualElement element, ref ComputedStyle oldStyle, ref ComputedStyle newStyle, int durationMs, int delayMs, Func<Single, Single> easingCurve) { }

	[CalledBy(Type = typeof(InlineStyleAccess), Member = "ApplyStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleValue)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[ContainsInvalidInstructions]
	public static bool StartAnimationInline(VisualElement element, StylePropertyId id, ref ComputedStyle computedStyle, StyleValue sv, int durationMs, int delayMs, Func<Single, Single> easingCurve) { }

	[CalledBy(Type = typeof(InlineStyleAccess), Member = "ApplyStyleBackgroundSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleBackgroundSize)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InitialStyle), Member = "get_backgroundSize", ReturnType = typeof(BackgroundSize))]
	[Calls(Type = typeof(StyleBackgroundSize), Member = "get_value", ReturnType = typeof(BackgroundSize))]
	[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	public static bool StartAnimationInlineBackgroundSize(VisualElement element, ref ComputedStyle computedStyle, StyleBackgroundSize backgroundSize, int durationMs, int delayMs, Func<Single, Single> easingCurve) { }

	[CalledBy(Type = typeof(InlineStyleAccess), Member = "ApplyStyleRotate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleRotate)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InitialStyle), Member = "get_rotate", ReturnType = typeof(Rotate))]
	[Calls(Type = typeof(StyleRotate), Member = "get_value", ReturnType = typeof(Rotate))]
	[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
	[Calls(Type = typeof(VisualElement), Member = "get_usageHints", ReturnType = typeof(UsageHints))]
	[Calls(Type = typeof(VisualElement), Member = "set_usageHints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UsageHints)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	public static bool StartAnimationInlineRotate(VisualElement element, ref ComputedStyle computedStyle, StyleRotate rotate, int durationMs, int delayMs, Func<Single, Single> easingCurve) { }

	[CalledBy(Type = typeof(InlineStyleAccess), Member = "ApplyStyleScale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleScale)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InitialStyle), Member = "get_scale", ReturnType = typeof(Scale))]
	[Calls(Type = typeof(StyleScale), Member = "get_value", ReturnType = typeof(Scale))]
	[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
	[Calls(Type = typeof(VisualElement), Member = "get_usageHints", ReturnType = typeof(UsageHints))]
	[Calls(Type = typeof(VisualElement), Member = "set_usageHints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UsageHints)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	public static bool StartAnimationInlineScale(VisualElement element, ref ComputedStyle computedStyle, StyleScale scale, int durationMs, int delayMs, Func<Single, Single> easingCurve) { }

	[CalledBy(Type = typeof(InlineStyleAccess), Member = "ApplyStyleTextShadow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleTextShadow)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InitialStyle), Member = "get_textShadow", ReturnType = typeof(TextShadow))]
	[Calls(Type = typeof(StyleTextShadow), Member = "get_value", ReturnType = typeof(TextShadow))]
	[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	public static bool StartAnimationInlineTextShadow(VisualElement element, ref ComputedStyle computedStyle, StyleTextShadow textShadow, int durationMs, int delayMs, Func<Single, Single> easingCurve) { }

	[CalledBy(Type = typeof(InlineStyleAccess), Member = "ApplyStyleTransformOrigin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleTransformOrigin)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InitialStyle), Member = "get_transformOrigin", ReturnType = typeof(TransformOrigin))]
	[Calls(Type = typeof(StyleTransformOrigin), Member = "get_value", ReturnType = typeof(TransformOrigin))]
	[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
	[Calls(Type = typeof(VisualElement), Member = "get_usageHints", ReturnType = typeof(UsageHints))]
	[Calls(Type = typeof(VisualElement), Member = "set_usageHints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UsageHints)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	public static bool StartAnimationInlineTransformOrigin(VisualElement element, ref ComputedStyle computedStyle, StyleTransformOrigin transformOrigin, int durationMs, int delayMs, Func<Single, Single> easingCurve) { }

	[CalledBy(Type = typeof(InlineStyleAccess), Member = "ApplyStyleTranslate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleTranslate)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InitialStyle), Member = "get_translate", ReturnType = typeof(Translate))]
	[Calls(Type = typeof(StyleTranslate), Member = "get_value", ReturnType = typeof(Translate))]
	[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
	[Calls(Type = typeof(VisualElement), Member = "get_usageHints", ReturnType = typeof(UsageHints))]
	[Calls(Type = typeof(VisualElement), Member = "set_usageHints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UsageHints)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	public static bool StartAnimationInlineTranslate(VisualElement element, ref ComputedStyle computedStyle, StyleTranslate translate, int durationMs, int delayMs, Func<Single, Single> easingCurve) { }

}

