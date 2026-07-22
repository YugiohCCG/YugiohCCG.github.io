namespace UnityEngine.UIElements.Layout;

[DefaultMember("Item")]
internal struct LayoutNode : IEquatable<LayoutNode>
{
	private const int k_DefaultChildCapacity = 4; //Field offset: 0x0
	private readonly LayoutDataAccess m_Access; //Field offset: 0x0
	private readonly LayoutHandle m_Handle; //Field offset: 0x28

	public LayoutAlign AlignContent
	{
		[CalledBy(Type = typeof(ComputedStyle), Member = "ApplyPropertyAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StylePropertyId), typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_alignContent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityEngine.UIElements.StyleEnum`1<UnityEngine.UIElements.Align>)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(LayoutNode), Member = "CopyFromComputedStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(LayoutNode), Member = "get_Style", ReturnType = typeof(LayoutStyleData&))]
		[Calls(Type = typeof(LayoutNode), Member = "MarkDirty", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		 set { } //Length: 152
	}

	public LayoutAlign AlignItems
	{
		[CalledBy(Type = typeof(ComputedStyle), Member = "ApplyPropertyAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StylePropertyId), typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_alignItems", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityEngine.UIElements.StyleEnum`1<UnityEngine.UIElements.Align>)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(LayoutNode), Member = "CopyFromComputedStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(LayoutNode), Member = "get_Style", ReturnType = typeof(LayoutStyleData&))]
		[Calls(Type = typeof(LayoutNode), Member = "MarkDirty", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		 set { } //Length: 152
	}

	public LayoutAlign AlignSelf
	{
		[CalledBy(Type = typeof(ComputedStyle), Member = "ApplyPropertyAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StylePropertyId), typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_alignSelf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityEngine.UIElements.StyleEnum`1<UnityEngine.UIElements.Align>)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(LayoutNode), Member = "CopyFromComputedStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(LayoutNode), Member = "get_Style", ReturnType = typeof(LayoutStyleData&))]
		[Calls(Type = typeof(LayoutNode), Member = "MarkDirty", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		 set { } //Length: 152
	}

	public LayoutBaselineFunction Baseline
	{
		[CalledBy(Type = typeof(LayoutDelegates), Member = "InvokeBaselineFunction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutNode&), typeof(float), typeof(float)}, ReturnType = typeof(float))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(LayoutManager), Member = "GetManager", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(LayoutManager))]
		[Calls(Type = typeof(LayoutManager), Member = "GetBaselineFunction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutHandle)}, ReturnType = typeof(LayoutBaselineFunction))]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 111
	}

	public float BorderBottomWidth
	{
		[CalledBy(Type = typeof(ComputedStyle), Member = "ApplyPropertyAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StylePropertyId), typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_borderBottomWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleFloat)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(LayoutNode), Member = "CopyFromComputedStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(LayoutNode), Member = "StyleEdgeSetPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutValue&), typeof(float)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		 set { } //Length: 172
	}

	public float BorderLeftWidth
	{
		[CalledBy(Type = typeof(ComputedStyle), Member = "ApplyPropertyAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StylePropertyId), typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_borderLeftWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleFloat)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(LayoutNode), Member = "CopyFromComputedStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(LayoutNode), Member = "StyleEdgeSetPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutValue&), typeof(float)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		 set { } //Length: 172
	}

	public float BorderRightWidth
	{
		[CalledBy(Type = typeof(ComputedStyle), Member = "ApplyPropertyAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StylePropertyId), typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_borderRightWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleFloat)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(LayoutNode), Member = "CopyFromComputedStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(LayoutNode), Member = "StyleEdgeSetPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutValue&), typeof(float)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		 set { } //Length: 172
	}

	public float BorderTopWidth
	{
		[CalledBy(Type = typeof(ComputedStyle), Member = "ApplyPropertyAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StylePropertyId), typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_borderTopWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleFloat)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(LayoutNode), Member = "CopyFromComputedStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(LayoutNode), Member = "StyleEdgeSetPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutValue&), typeof(float)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		 set { } //Length: 172
	}

	public LayoutValue Bottom
	{
		[CalledBy(Type = typeof(ComputedStyle), Member = "ApplyPropertyAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StylePropertyId), typeof(Length)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_bottom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleLength)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(LayoutNode), Member = "SetStyleEdgePosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutEdge), typeof(LayoutValue)}, ReturnType = typeof(void))]
		 set { } //Length: 16
	}

	private LayoutList<LayoutHandle> Children
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		private get { } //Length: 135
	}

	public float ComputedFlexBasis
	{
		[CalledBy(Type = typeof(ResolvedStyleAccess), Member = "get_flexBasis", ReturnType = typeof(StyleFloat))]
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 117
	}

	public LayoutConfig Config
	{
		[CalledBy(Type = typeof(VisualElement), Member = "HasChangedPanel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseVisualElementPanel)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		 set { } //Length: 133
	}

	public int Count
	{
		[CalledBy(Type = typeof(Hierarchy), Member = "PutChildAtIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(int)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(LayoutList`1), Member = "get_Count", ReturnType = typeof(int))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 320
	}

	public LayoutDisplay Display
	{
		[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_display", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityEngine.UIElements.StyleEnum`1<UnityEngine.UIElements.DisplayStyle>)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(LayoutNode), Member = "CopyFromComputedStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(LayoutNode), Member = "get_Style", ReturnType = typeof(LayoutStyleData&))]
		[Calls(Type = typeof(LayoutNode), Member = "MarkDirty", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		 set { } //Length: 152
	}

	public LayoutValue FlexBasis
	{
		[CalledBy(Type = typeof(ComputedStyle), Member = "ApplyPropertyAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StylePropertyId), typeof(Length)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_flexBasis", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleLength)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(LayoutNode), Member = "CopyFromComputedStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(LayoutNode), Member = "SetStyleValueUnit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutValue&), typeof(LayoutValue)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		 set { } //Length: 144
	}

	public LayoutFlexDirection FlexDirection
	{
		[CalledBy(Type = typeof(ComputedStyle), Member = "ApplyPropertyAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StylePropertyId), typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_flexDirection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityEngine.UIElements.StyleEnum`1<UnityEngine.UIElements.FlexDirection>)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(LayoutNode), Member = "CopyFromComputedStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(LayoutNode), Member = "get_Style", ReturnType = typeof(LayoutStyleData&))]
		[Calls(Type = typeof(LayoutNode), Member = "MarkDirty", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		 set { } //Length: 152
	}

	public float FlexGrow
	{
		[CalledBy(Type = typeof(ComputedStyle), Member = "ApplyPropertyAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StylePropertyId), typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_flexGrow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleFloat)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(LayoutNode), Member = "CopyFromComputedStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(float), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(LayoutNode), Member = "MarkDirty", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		 set { } //Length: 158
	}

	public float FlexShrink
	{
		[CalledBy(Type = typeof(ComputedStyle), Member = "ApplyPropertyAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StylePropertyId), typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_flexShrink", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleFloat)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(LayoutNode), Member = "CopyFromComputedStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(float), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(LayoutNode), Member = "MarkDirty", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		 set { } //Length: 158
	}

	public LayoutHandle Handle
	{
		[CallerCount(Count = 15)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public bool HasNewLayout
	{
		[CalledBy(Type = typeof(UIRLayoutUpdater), Member = "UpdateSubTree", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(System.Collections.Generic.List`1<System.ValueTuple`3<UnityEngine.Rect, UnityEngine.Rect, UnityEngine.UIElements.VisualElement>>)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 120
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		 set { } //Length: 148
	}

	public LayoutValue Height
	{
		[CalledBy(Type = typeof(ComputedStyle), Member = "ApplyPropertyAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StylePropertyId), typeof(Length)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_height", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleLength)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(LayoutNode), Member = "CopyFromComputedStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(LayoutNode), Member = "SetStyleValueUnit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutValue&), typeof(LayoutValue)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		 set { } //Length: 175
	}

	public bool IsDirty
	{
		[CalledBy(Type = typeof(VerticalVirtualizationController`1), Member = "ShouldDeferScrollToItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(UIRLayoutUpdater), Member = "Update", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(LayoutNode), Member = "MarkDirty", ReturnType = typeof(void))]
		[CallerCount(Count = 5)]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 118
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		 set { } //Length: 148
	}

	public bool IsMeasureDefined
	{
		[CalledBy(Type = typeof(UIRLayoutUpdater), Member = "OnVersionChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(VersionChangeType)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Hierarchy), Member = "Insert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(VisualElement)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(VisualElement), Member = "set_requireMeasureFunction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 4)]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 119
	}

	public bool IsUndefined
	{
		[CalledBy(Type = typeof(VisualElement), Member = "get_layout", ReturnType = typeof(Rect))]
		[CallerCount(Count = 1)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 16
	}

	public LayoutJustify JustifyContent
	{
		[CalledBy(Type = typeof(ComputedStyle), Member = "ApplyPropertyAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StylePropertyId), typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_justifyContent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityEngine.UIElements.StyleEnum`1<UnityEngine.UIElements.Justify>)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(LayoutNode), Member = "CopyFromComputedStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(LayoutNode), Member = "get_Style", ReturnType = typeof(LayoutStyleData&))]
		[Calls(Type = typeof(LayoutNode), Member = "MarkDirty", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		 set { } //Length: 152
	}

	public LayoutComputedData Layout
	{
		[CalledBy(Type = typeof(LayoutNode), Member = "get_LayoutMarginLeft", ReturnType = typeof(float))]
		[CalledBy(Type = typeof(LayoutNode), Member = "get_LayoutMarginRight", ReturnType = typeof(float))]
		[CalledBy(Type = typeof(LayoutNode), Member = "get_LayoutPaddingLeft", ReturnType = typeof(float))]
		[CalledBy(Type = typeof(LayoutNode), Member = "get_LayoutPaddingRight", ReturnType = typeof(float))]
		[CalledBy(Type = typeof(LayoutNode), Member = "get_LayoutBorderLeft", ReturnType = typeof(float))]
		[CalledBy(Type = typeof(LayoutNode), Member = "get_LayoutBorderRight", ReturnType = typeof(float))]
		[CalledBy(Type = typeof(LayoutNode), Member = "GetLayoutValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Single*), typeof(LayoutEdge)}, ReturnType = typeof(float))]
		[CalledBy(Type = typeof(LayoutNode), Member = "MarkDirty", ReturnType = typeof(void))]
		[CallerCount(Count = 9)]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 109
	}

	public float LayoutBorderBottom
	{
		[CalledBy(Type = typeof(ResolvedStyleAccess), Member = "get_borderBottomWidth", ReturnType = typeof(float))]
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 117
	}

	public float LayoutBorderLeft
	{
		[CalledBy(Type = typeof(ResolvedStyleAccess), Member = "get_borderLeftWidth", ReturnType = typeof(float))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(LayoutNode), Member = "get_Layout", ReturnType = typeof(LayoutComputedData&))]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 143
	}

	public float LayoutBorderRight
	{
		[CalledBy(Type = typeof(ResolvedStyleAccess), Member = "get_borderRightWidth", ReturnType = typeof(float))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(LayoutNode), Member = "get_Layout", ReturnType = typeof(LayoutComputedData&))]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 143
	}

	public float LayoutBorderTop
	{
		[CalledBy(Type = typeof(ResolvedStyleAccess), Member = "get_borderTopWidth", ReturnType = typeof(float))]
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 117
	}

	public float LayoutBottom
	{
		[CalledBy(Type = typeof(ResolvedStyleAccess), Member = "get_bottom", ReturnType = typeof(float))]
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 117
	}

	public float LayoutHeight
	{
		[CalledBy(Type = typeof(UIRLayoutUpdater), Member = "UpdateSubTree", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(System.Collections.Generic.List`1<System.ValueTuple`3<UnityEngine.Rect, UnityEngine.Rect, UnityEngine.UIElements.VisualElement>>)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ResolvedStyleAccess), Member = "get_height", ReturnType = typeof(float))]
		[CalledBy(Type = typeof(VisualElement), Member = "get_layout", ReturnType = typeof(Rect))]
		[CallerCount(Count = 3)]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 117
	}

	public float LayoutMarginBottom
	{
		[CalledBy(Type = typeof(ResolvedStyleAccess), Member = "get_marginBottom", ReturnType = typeof(float))]
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 117
	}

	public float LayoutMarginLeft
	{
		[CalledBy(Type = typeof(ResolvedStyleAccess), Member = "get_marginLeft", ReturnType = typeof(float))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(LayoutNode), Member = "get_Layout", ReturnType = typeof(LayoutComputedData&))]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 143
	}

	public float LayoutMarginRight
	{
		[CalledBy(Type = typeof(ResolvedStyleAccess), Member = "get_marginRight", ReturnType = typeof(float))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(LayoutNode), Member = "get_Layout", ReturnType = typeof(LayoutComputedData&))]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 143
	}

	public float LayoutMarginTop
	{
		[CalledBy(Type = typeof(ResolvedStyleAccess), Member = "get_marginTop", ReturnType = typeof(float))]
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 117
	}

	public float LayoutPaddingBottom
	{
		[CalledBy(Type = typeof(UIRLayoutUpdater), Member = "UpdateSubTree", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(System.Collections.Generic.List`1<System.ValueTuple`3<UnityEngine.Rect, UnityEngine.Rect, UnityEngine.UIElements.VisualElement>>)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ResolvedStyleAccess), Member = "get_paddingBottom", ReturnType = typeof(float))]
		[CallerCount(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 117
	}

	public float LayoutPaddingLeft
	{
		[CalledBy(Type = typeof(UIRLayoutUpdater), Member = "UpdateSubTree", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(System.Collections.Generic.List`1<System.ValueTuple`3<UnityEngine.Rect, UnityEngine.Rect, UnityEngine.UIElements.VisualElement>>)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ResolvedStyleAccess), Member = "get_paddingLeft", ReturnType = typeof(float))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(LayoutNode), Member = "get_Layout", ReturnType = typeof(LayoutComputedData&))]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 143
	}

	public float LayoutPaddingRight
	{
		[CalledBy(Type = typeof(UIRLayoutUpdater), Member = "UpdateSubTree", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(System.Collections.Generic.List`1<System.ValueTuple`3<UnityEngine.Rect, UnityEngine.Rect, UnityEngine.UIElements.VisualElement>>)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ResolvedStyleAccess), Member = "get_paddingRight", ReturnType = typeof(float))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(LayoutNode), Member = "get_Layout", ReturnType = typeof(LayoutComputedData&))]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 143
	}

	public float LayoutPaddingTop
	{
		[CalledBy(Type = typeof(ResolvedStyleAccess), Member = "get_paddingTop", ReturnType = typeof(float))]
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 117
	}

	public float LayoutRight
	{
		[CalledBy(Type = typeof(ResolvedStyleAccess), Member = "get_right", ReturnType = typeof(float))]
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 117
	}

	public float LayoutWidth
	{
		[CalledBy(Type = typeof(UIRLayoutUpdater), Member = "UpdateSubTree", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(System.Collections.Generic.List`1<System.ValueTuple`3<UnityEngine.Rect, UnityEngine.Rect, UnityEngine.UIElements.VisualElement>>)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ResolvedStyleAccess), Member = "get_width", ReturnType = typeof(float))]
		[CalledBy(Type = typeof(VisualElement), Member = "get_layout", ReturnType = typeof(Rect))]
		[CallerCount(Count = 3)]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 117
	}

	public float LayoutX
	{
		[CalledBy(Type = typeof(UIRLayoutUpdater), Member = "UpdateSubTree", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(System.Collections.Generic.List`1<System.ValueTuple`3<UnityEngine.Rect, UnityEngine.Rect, UnityEngine.UIElements.VisualElement>>)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ResolvedStyleAccess), Member = "get_left", ReturnType = typeof(float))]
		[CalledBy(Type = typeof(VisualElement), Member = "get_layout", ReturnType = typeof(Rect))]
		[CallerCount(Count = 3)]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 116
	}

	public float LayoutY
	{
		[CalledBy(Type = typeof(UIRLayoutUpdater), Member = "UpdateSubTree", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(System.Collections.Generic.List`1<System.ValueTuple`3<UnityEngine.Rect, UnityEngine.Rect, UnityEngine.UIElements.VisualElement>>)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ResolvedStyleAccess), Member = "get_top", ReturnType = typeof(float))]
		[CalledBy(Type = typeof(VisualElement), Member = "get_layout", ReturnType = typeof(Rect))]
		[CallerCount(Count = 3)]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 117
	}

	public LayoutValue Left
	{
		[CalledBy(Type = typeof(ComputedStyle), Member = "ApplyPropertyAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StylePropertyId), typeof(Length)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_left", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleLength)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(LayoutNode), Member = "SetStyleEdgePosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutEdge), typeof(LayoutValue)}, ReturnType = typeof(void))]
		 set { } //Length: 13
	}

	public LayoutValue MarginBottom
	{
		[CalledBy(Type = typeof(ComputedStyle), Member = "ApplyPropertyAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StylePropertyId), typeof(Length)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_marginBottom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleLength)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(LayoutNode), Member = "SetStyleEdgeMargin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutEdge), typeof(LayoutValue)}, ReturnType = typeof(void))]
		 set { } //Length: 16
	}

	public LayoutValue MarginLeft
	{
		[CalledBy(Type = typeof(ComputedStyle), Member = "ApplyPropertyAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StylePropertyId), typeof(Length)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_marginLeft", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleLength)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(LayoutNode), Member = "SetStyleEdgeMargin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutEdge), typeof(LayoutValue)}, ReturnType = typeof(void))]
		 set { } //Length: 13
	}

	public LayoutValue MarginRight
	{
		[CalledBy(Type = typeof(ComputedStyle), Member = "ApplyPropertyAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StylePropertyId), typeof(Length)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_marginRight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleLength)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(LayoutNode), Member = "SetStyleEdgeMargin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutEdge), typeof(LayoutValue)}, ReturnType = typeof(void))]
		 set { } //Length: 16
	}

	public LayoutValue MarginTop
	{
		[CalledBy(Type = typeof(ComputedStyle), Member = "ApplyPropertyAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StylePropertyId), typeof(Length)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_marginTop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleLength)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(LayoutNode), Member = "SetStyleEdgeMargin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutEdge), typeof(LayoutValue)}, ReturnType = typeof(void))]
		 set { } //Length: 16
	}

	public LayoutValue MaxHeight
	{
		[CalledBy(Type = typeof(ComputedStyle), Member = "ApplyPropertyAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StylePropertyId), typeof(Length)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_maxHeight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleLength)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(LayoutNode), Member = "CopyFromComputedStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(LayoutNode), Member = "SetStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutValue&), typeof(LayoutValue)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		 set { } //Length: 175
	}

	public LayoutValue MaxWidth
	{
		[CalledBy(Type = typeof(ComputedStyle), Member = "ApplyPropertyAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StylePropertyId), typeof(Length)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_maxWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleLength)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(LayoutNode), Member = "CopyFromComputedStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(LayoutNode), Member = "SetStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutValue&), typeof(LayoutValue)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		 set { } //Length: 175
	}

	public LayoutMeasureFunction Measure
	{
		[CalledBy(Type = typeof(LayoutDelegates), Member = "InvokeMeasureFunction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutNode&), typeof(float), typeof(LayoutMeasureMode), typeof(float), typeof(LayoutMeasureMode), typeof(IntPtr&), typeof(LayoutSize&)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(LayoutManager), Member = "GetManager", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(LayoutManager))]
		[Calls(Type = typeof(LayoutManager), Member = "GetMeasureFunction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutHandle)}, ReturnType = typeof(LayoutMeasureFunction))]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 111
		[CalledBy(Type = typeof(VisualElement), Member = "set_requireMeasureFunction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(VisualElement), Member = "AssignMeasureFunction", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(VisualElement), Member = "RemoveMeasureFunction", ReturnType = typeof(void))]
		[CallerCount(Count = 4)]
		[CallsUnknownMethods(Count = 1)]
		 set { } //Length: 15
	}

	public LayoutValue MinHeight
	{
		[CalledBy(Type = typeof(ComputedStyle), Member = "ApplyPropertyAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StylePropertyId), typeof(Length)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_minHeight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleLength)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(LayoutNode), Member = "CopyFromComputedStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(LayoutNode), Member = "SetStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutValue&), typeof(LayoutValue)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		 set { } //Length: 175
	}

	public LayoutValue MinWidth
	{
		[CalledBy(Type = typeof(ComputedStyle), Member = "ApplyPropertyAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StylePropertyId), typeof(Length)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_minWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleLength)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(LayoutNode), Member = "CopyFromComputedStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(LayoutNode), Member = "SetStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutValue&), typeof(LayoutValue)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		 set { } //Length: 175
	}

	public LayoutOverflow Overflow
	{
		[CalledBy(Type = typeof(ComputedStyle), Member = "ApplyPropertyAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StylePropertyId), typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_overflow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityEngine.UIElements.StyleEnum`1<UnityEngine.UIElements.Overflow>)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(LayoutNode), Member = "CopyFromComputedStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(LayoutNode), Member = "get_Style", ReturnType = typeof(LayoutStyleData&))]
		[Calls(Type = typeof(LayoutNode), Member = "MarkDirty", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		 set { } //Length: 152
	}

	public LayoutValue PaddingBottom
	{
		[CalledBy(Type = typeof(ComputedStyle), Member = "ApplyPropertyAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StylePropertyId), typeof(Length)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_paddingBottom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleLength)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(LayoutNode), Member = "SetStyleEdgePadding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutEdge), typeof(LayoutValue)}, ReturnType = typeof(void))]
		 set { } //Length: 16
	}

	public LayoutValue PaddingLeft
	{
		[CalledBy(Type = typeof(ComputedStyle), Member = "ApplyPropertyAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StylePropertyId), typeof(Length)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_paddingLeft", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleLength)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(LayoutNode), Member = "SetStyleEdgePadding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutEdge), typeof(LayoutValue)}, ReturnType = typeof(void))]
		 set { } //Length: 13
	}

	public LayoutValue PaddingRight
	{
		[CalledBy(Type = typeof(ComputedStyle), Member = "ApplyPropertyAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StylePropertyId), typeof(Length)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_paddingRight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleLength)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(LayoutNode), Member = "SetStyleEdgePadding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutEdge), typeof(LayoutValue)}, ReturnType = typeof(void))]
		 set { } //Length: 16
	}

	public LayoutValue PaddingTop
	{
		[CalledBy(Type = typeof(ComputedStyle), Member = "ApplyPropertyAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StylePropertyId), typeof(Length)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_paddingTop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleLength)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(LayoutNode), Member = "SetStyleEdgePadding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutEdge), typeof(LayoutValue)}, ReturnType = typeof(void))]
		 set { } //Length: 16
	}

	public LayoutNode Parent
	{
		[CalledBy(Type = typeof(LayoutNode), Member = "MarkDirty", ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 194
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		 set { } //Length: 133
	}

	public LayoutPositionType PositionType
	{
		[CalledBy(Type = typeof(ComputedStyle), Member = "ApplyPropertyAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StylePropertyId), typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_position", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityEngine.UIElements.StyleEnum`1<UnityEngine.UIElements.Position>)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(LayoutNode), Member = "CopyFromComputedStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(LayoutNode), Member = "get_Style", ReturnType = typeof(LayoutStyleData&))]
		[Calls(Type = typeof(LayoutNode), Member = "MarkDirty", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		 set { } //Length: 152
	}

	public LayoutValue Right
	{
		[CalledBy(Type = typeof(ComputedStyle), Member = "ApplyPropertyAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StylePropertyId), typeof(Length)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_right", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleLength)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(LayoutNode), Member = "SetStyleEdgePosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutEdge), typeof(LayoutValue)}, ReturnType = typeof(void))]
		 set { } //Length: 16
	}

	public LayoutStyleData Style
	{
		[CalledBy(Type = typeof(LayoutNode), Member = "set_FlexDirection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutFlexDirection)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(LayoutNode), Member = "set_JustifyContent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutJustify)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(LayoutNode), Member = "set_Display", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutDisplay)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(LayoutNode), Member = "set_AlignItems", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutAlign)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(LayoutNode), Member = "set_AlignSelf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutAlign)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(LayoutNode), Member = "set_AlignContent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutAlign)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(LayoutNode), Member = "set_PositionType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutPositionType)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(LayoutNode), Member = "set_Wrap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutWrap)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(LayoutNode), Member = "set_Overflow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutOverflow)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(LayoutNode), Member = "SetStyleEdgePosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutEdge), typeof(LayoutValue)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(LayoutNode), Member = "SetStyleEdgeMargin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutEdge), typeof(LayoutValue)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(LayoutNode), Member = "SetStyleEdgePadding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutEdge), typeof(LayoutValue)}, ReturnType = typeof(void))]
		[CallerCount(Count = 14)]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 109
	}

	public LayoutValue Top
	{
		[CalledBy(Type = typeof(ComputedStyle), Member = "ApplyPropertyAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StylePropertyId), typeof(Length)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_top", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleLength)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(LayoutNode), Member = "SetStyleEdgePosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutEdge), typeof(LayoutValue)}, ReturnType = typeof(void))]
		 set { } //Length: 16
	}

	public static LayoutNode Undefined
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 24
	}

	public LayoutValue Width
	{
		[CalledBy(Type = typeof(ComputedStyle), Member = "ApplyPropertyAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StylePropertyId), typeof(Length)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_width", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleLength)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(LayoutNode), Member = "CopyFromComputedStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(LayoutNode), Member = "SetStyleValueUnit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutValue&), typeof(LayoutValue)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		 set { } //Length: 175
	}

	public LayoutWrap Wrap
	{
		[CalledBy(Type = typeof(ComputedStyle), Member = "ApplyPropertyAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StylePropertyId), typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_flexWrap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityEngine.UIElements.StyleEnum`1<UnityEngine.UIElements.Wrap>)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(LayoutNode), Member = "CopyFromComputedStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(LayoutNode), Member = "get_Style", ReturnType = typeof(LayoutStyleData&))]
		[Calls(Type = typeof(LayoutNode), Member = "MarkDirty", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		 set { } //Length: 152
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	internal LayoutNode(LayoutDataAccess access, LayoutHandle handle) { }

	[CalledBy(Type = typeof(UIRLayoutUpdater), Member = "Update", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	public void CalculateLayout(float width = NaN, float height = NaN) { }

	[CalledBy(Type = typeof(Hierarchy), Member = "Clear", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(LayoutList`1), Member = "get_Count", ReturnType = typeof(int))]
	[Calls(Type = typeof(LayoutNode), Member = "RemoveAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public void Clear() { }

	[CalledBy(Type = typeof(VisualElement), Member = "FinalizeLayout", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VisualElement), Member = "SetComputedStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(LayoutNode), Member = "set_Width", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutValue)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_height", ReturnType = typeof(Length))]
	[Calls(Type = typeof(LayoutNode), Member = "set_Height", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutValue)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_position", ReturnType = typeof(Position))]
	[Calls(Type = typeof(LayoutNode), Member = "set_PositionType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutPositionType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_overflow", ReturnType = typeof(OverflowInternal))]
	[Calls(Type = typeof(LayoutNode), Member = "set_Overflow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutOverflow)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_alignSelf", ReturnType = typeof(Align))]
	[Calls(Type = typeof(LayoutNode), Member = "set_AlignSelf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutAlign)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_maxWidth", ReturnType = typeof(Length))]
	[Calls(Type = typeof(LayoutNode), Member = "set_MaxWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutValue)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_maxHeight", ReturnType = typeof(Length))]
	[Calls(Type = typeof(LayoutNode), Member = "set_MaxHeight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutValue)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(LayoutNode), Member = "set_MinWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutValue)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_width", ReturnType = typeof(Length))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_minHeight", ReturnType = typeof(Length))]
	[Calls(Type = typeof(LayoutNode), Member = "set_MinHeight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutValue)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_flexDirection", ReturnType = typeof(FlexDirection))]
	[Calls(Type = typeof(LayoutNode), Member = "set_FlexDirection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutFlexDirection)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_alignContent", ReturnType = typeof(Align))]
	[Calls(Type = typeof(LayoutNode), Member = "set_AlignContent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutAlign)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_alignItems", ReturnType = typeof(Align))]
	[Calls(Type = typeof(LayoutNode), Member = "set_AlignItems", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutAlign)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_justifyContent", ReturnType = typeof(Justify))]
	[Calls(Type = typeof(LayoutNode), Member = "set_JustifyContent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutJustify)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_flexWrap", ReturnType = typeof(Wrap))]
	[Calls(Type = typeof(LayoutNode), Member = "set_Wrap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutWrap)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_minWidth", ReturnType = typeof(Length))]
	[Calls(Type = typeof(LayoutNode), Member = "set_BorderBottomWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_borderBottomWidth", ReturnType = typeof(float))]
	[Calls(Type = typeof(LayoutNode), Member = "set_BorderRightWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_flexGrow", ReturnType = typeof(float))]
	[Calls(Type = typeof(LayoutNode), Member = "set_FlexGrow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_flexShrink", ReturnType = typeof(float))]
	[Calls(Type = typeof(LayoutNode), Member = "set_FlexShrink", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_flexBasis", ReturnType = typeof(Length))]
	[Calls(Type = typeof(StyleValueExtensions), Member = "ToLayoutValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Length)}, ReturnType = typeof(LayoutValue))]
	[Calls(Type = typeof(LayoutNode), Member = "set_FlexBasis", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutValue)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_left", ReturnType = typeof(Length))]
	[Calls(Type = typeof(LayoutNode), Member = "SetStyleEdgePosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutEdge), typeof(LayoutValue)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_top", ReturnType = typeof(Length))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_right", ReturnType = typeof(Length))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_bottom", ReturnType = typeof(Length))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_marginLeft", ReturnType = typeof(Length))]
	[Calls(Type = typeof(LayoutNode), Member = "SetStyleEdgeMargin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutEdge), typeof(LayoutValue)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_marginTop", ReturnType = typeof(Length))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_marginRight", ReturnType = typeof(Length))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_marginBottom", ReturnType = typeof(Length))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_paddingLeft", ReturnType = typeof(Length))]
	[Calls(Type = typeof(LayoutNode), Member = "SetStyleEdgePadding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutEdge), typeof(LayoutValue)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_paddingTop", ReturnType = typeof(Length))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_paddingRight", ReturnType = typeof(Length))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_paddingBottom", ReturnType = typeof(Length))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_borderLeftWidth", ReturnType = typeof(float))]
	[Calls(Type = typeof(LayoutNode), Member = "set_BorderLeftWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_borderTopWidth", ReturnType = typeof(float))]
	[Calls(Type = typeof(LayoutNode), Member = "set_BorderTopWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_borderRightWidth", ReturnType = typeof(float))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_display", ReturnType = typeof(DisplayStyle))]
	[Calls(Type = typeof(LayoutNode), Member = "set_Display", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutDisplay)}, ReturnType = typeof(void))]
	public void CopyFromComputedStyle(ComputedStyle style) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public virtual bool Equals(object obj) { }

	[CalledBy(Type = typeof(VisualElement), Member = "Measure", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(LayoutNode&), typeof(float), typeof(LayoutMeasureMode), typeof(float), typeof(LayoutMeasureMode), typeof(LayoutSize&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[ContainsUnimplementedInstructions]
	public override bool Equals(LayoutNode other) { }

	[CalledBy(Type = typeof(LayoutDelegates), Member = "InvokeBaselineFunction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutNode&), typeof(float), typeof(float)}, ReturnType = typeof(float))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(LayoutManager), Member = "GetManager", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(LayoutManager))]
	[Calls(Type = typeof(LayoutManager), Member = "GetBaselineFunction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutHandle)}, ReturnType = typeof(LayoutBaselineFunction))]
	[CallsUnknownMethods(Count = 1)]
	public LayoutBaselineFunction get_Baseline() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private LayoutList<LayoutHandle> get_Children() { }

	[CalledBy(Type = typeof(ResolvedStyleAccess), Member = "get_flexBasis", ReturnType = typeof(StyleFloat))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public float get_ComputedFlexBasis() { }

	[CalledBy(Type = typeof(Hierarchy), Member = "PutChildAtIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(LayoutList`1), Member = "get_Count", ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public int get_Count() { }

	[CallerCount(Count = 15)]
	[DeduplicatedMethod]
	public LayoutHandle get_Handle() { }

	[CalledBy(Type = typeof(UIRLayoutUpdater), Member = "UpdateSubTree", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(System.Collections.Generic.List`1<System.ValueTuple`3<UnityEngine.Rect, UnityEngine.Rect, UnityEngine.UIElements.VisualElement>>)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public bool get_HasNewLayout() { }

	[CalledBy(Type = typeof(VerticalVirtualizationController`1), Member = "ShouldDeferScrollToItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(UIRLayoutUpdater), Member = "Update", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LayoutNode), Member = "MarkDirty", ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public bool get_IsDirty() { }

	[CalledBy(Type = typeof(UIRLayoutUpdater), Member = "OnVersionChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(VersionChangeType)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Hierarchy), Member = "Insert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(VisualElement)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VisualElement), Member = "set_requireMeasureFunction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public bool get_IsMeasureDefined() { }

	[CalledBy(Type = typeof(VisualElement), Member = "get_layout", ReturnType = typeof(Rect))]
	[CallerCount(Count = 1)]
	[ContainsUnimplementedInstructions]
	public bool get_IsUndefined() { }

	[CalledBy(Type = typeof(LayoutNode), Member = "get_LayoutMarginLeft", ReturnType = typeof(float))]
	[CalledBy(Type = typeof(LayoutNode), Member = "get_LayoutMarginRight", ReturnType = typeof(float))]
	[CalledBy(Type = typeof(LayoutNode), Member = "get_LayoutPaddingLeft", ReturnType = typeof(float))]
	[CalledBy(Type = typeof(LayoutNode), Member = "get_LayoutPaddingRight", ReturnType = typeof(float))]
	[CalledBy(Type = typeof(LayoutNode), Member = "get_LayoutBorderLeft", ReturnType = typeof(float))]
	[CalledBy(Type = typeof(LayoutNode), Member = "get_LayoutBorderRight", ReturnType = typeof(float))]
	[CalledBy(Type = typeof(LayoutNode), Member = "GetLayoutValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Single*), typeof(LayoutEdge)}, ReturnType = typeof(float))]
	[CalledBy(Type = typeof(LayoutNode), Member = "MarkDirty", ReturnType = typeof(void))]
	[CallerCount(Count = 9)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public LayoutComputedData get_Layout() { }

	[CalledBy(Type = typeof(ResolvedStyleAccess), Member = "get_borderBottomWidth", ReturnType = typeof(float))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public float get_LayoutBorderBottom() { }

	[CalledBy(Type = typeof(ResolvedStyleAccess), Member = "get_borderLeftWidth", ReturnType = typeof(float))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(LayoutNode), Member = "get_Layout", ReturnType = typeof(LayoutComputedData&))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public float get_LayoutBorderLeft() { }

	[CalledBy(Type = typeof(ResolvedStyleAccess), Member = "get_borderRightWidth", ReturnType = typeof(float))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(LayoutNode), Member = "get_Layout", ReturnType = typeof(LayoutComputedData&))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public float get_LayoutBorderRight() { }

	[CalledBy(Type = typeof(ResolvedStyleAccess), Member = "get_borderTopWidth", ReturnType = typeof(float))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public float get_LayoutBorderTop() { }

	[CalledBy(Type = typeof(ResolvedStyleAccess), Member = "get_bottom", ReturnType = typeof(float))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public float get_LayoutBottom() { }

	[CalledBy(Type = typeof(UIRLayoutUpdater), Member = "UpdateSubTree", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(System.Collections.Generic.List`1<System.ValueTuple`3<UnityEngine.Rect, UnityEngine.Rect, UnityEngine.UIElements.VisualElement>>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ResolvedStyleAccess), Member = "get_height", ReturnType = typeof(float))]
	[CalledBy(Type = typeof(VisualElement), Member = "get_layout", ReturnType = typeof(Rect))]
	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public float get_LayoutHeight() { }

	[CalledBy(Type = typeof(ResolvedStyleAccess), Member = "get_marginBottom", ReturnType = typeof(float))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public float get_LayoutMarginBottom() { }

	[CalledBy(Type = typeof(ResolvedStyleAccess), Member = "get_marginLeft", ReturnType = typeof(float))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(LayoutNode), Member = "get_Layout", ReturnType = typeof(LayoutComputedData&))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public float get_LayoutMarginLeft() { }

	[CalledBy(Type = typeof(ResolvedStyleAccess), Member = "get_marginRight", ReturnType = typeof(float))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(LayoutNode), Member = "get_Layout", ReturnType = typeof(LayoutComputedData&))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public float get_LayoutMarginRight() { }

	[CalledBy(Type = typeof(ResolvedStyleAccess), Member = "get_marginTop", ReturnType = typeof(float))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public float get_LayoutMarginTop() { }

	[CalledBy(Type = typeof(UIRLayoutUpdater), Member = "UpdateSubTree", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(System.Collections.Generic.List`1<System.ValueTuple`3<UnityEngine.Rect, UnityEngine.Rect, UnityEngine.UIElements.VisualElement>>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ResolvedStyleAccess), Member = "get_paddingBottom", ReturnType = typeof(float))]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public float get_LayoutPaddingBottom() { }

	[CalledBy(Type = typeof(UIRLayoutUpdater), Member = "UpdateSubTree", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(System.Collections.Generic.List`1<System.ValueTuple`3<UnityEngine.Rect, UnityEngine.Rect, UnityEngine.UIElements.VisualElement>>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ResolvedStyleAccess), Member = "get_paddingLeft", ReturnType = typeof(float))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(LayoutNode), Member = "get_Layout", ReturnType = typeof(LayoutComputedData&))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public float get_LayoutPaddingLeft() { }

	[CalledBy(Type = typeof(UIRLayoutUpdater), Member = "UpdateSubTree", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(System.Collections.Generic.List`1<System.ValueTuple`3<UnityEngine.Rect, UnityEngine.Rect, UnityEngine.UIElements.VisualElement>>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ResolvedStyleAccess), Member = "get_paddingRight", ReturnType = typeof(float))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(LayoutNode), Member = "get_Layout", ReturnType = typeof(LayoutComputedData&))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public float get_LayoutPaddingRight() { }

	[CalledBy(Type = typeof(ResolvedStyleAccess), Member = "get_paddingTop", ReturnType = typeof(float))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public float get_LayoutPaddingTop() { }

	[CalledBy(Type = typeof(ResolvedStyleAccess), Member = "get_right", ReturnType = typeof(float))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public float get_LayoutRight() { }

	[CalledBy(Type = typeof(UIRLayoutUpdater), Member = "UpdateSubTree", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(System.Collections.Generic.List`1<System.ValueTuple`3<UnityEngine.Rect, UnityEngine.Rect, UnityEngine.UIElements.VisualElement>>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ResolvedStyleAccess), Member = "get_width", ReturnType = typeof(float))]
	[CalledBy(Type = typeof(VisualElement), Member = "get_layout", ReturnType = typeof(Rect))]
	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public float get_LayoutWidth() { }

	[CalledBy(Type = typeof(UIRLayoutUpdater), Member = "UpdateSubTree", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(System.Collections.Generic.List`1<System.ValueTuple`3<UnityEngine.Rect, UnityEngine.Rect, UnityEngine.UIElements.VisualElement>>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ResolvedStyleAccess), Member = "get_left", ReturnType = typeof(float))]
	[CalledBy(Type = typeof(VisualElement), Member = "get_layout", ReturnType = typeof(Rect))]
	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public float get_LayoutX() { }

	[CalledBy(Type = typeof(UIRLayoutUpdater), Member = "UpdateSubTree", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(System.Collections.Generic.List`1<System.ValueTuple`3<UnityEngine.Rect, UnityEngine.Rect, UnityEngine.UIElements.VisualElement>>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ResolvedStyleAccess), Member = "get_top", ReturnType = typeof(float))]
	[CalledBy(Type = typeof(VisualElement), Member = "get_layout", ReturnType = typeof(Rect))]
	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public float get_LayoutY() { }

	[CalledBy(Type = typeof(LayoutDelegates), Member = "InvokeMeasureFunction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutNode&), typeof(float), typeof(LayoutMeasureMode), typeof(float), typeof(LayoutMeasureMode), typeof(IntPtr&), typeof(LayoutSize&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(LayoutManager), Member = "GetManager", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(LayoutManager))]
	[Calls(Type = typeof(LayoutManager), Member = "GetMeasureFunction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutHandle)}, ReturnType = typeof(LayoutMeasureFunction))]
	[CallsUnknownMethods(Count = 1)]
	public LayoutMeasureFunction get_Measure() { }

	[CalledBy(Type = typeof(LayoutNode), Member = "MarkDirty", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public LayoutNode get_Parent() { }

	[CalledBy(Type = typeof(LayoutNode), Member = "set_FlexDirection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutFlexDirection)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LayoutNode), Member = "set_JustifyContent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutJustify)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LayoutNode), Member = "set_Display", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutDisplay)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LayoutNode), Member = "set_AlignItems", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutAlign)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LayoutNode), Member = "set_AlignSelf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutAlign)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LayoutNode), Member = "set_AlignContent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutAlign)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LayoutNode), Member = "set_PositionType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutPositionType)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LayoutNode), Member = "set_Wrap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutWrap)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LayoutNode), Member = "set_Overflow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutOverflow)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LayoutNode), Member = "SetStyleEdgePosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutEdge), typeof(LayoutValue)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LayoutNode), Member = "SetStyleEdgeMargin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutEdge), typeof(LayoutValue)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LayoutNode), Member = "SetStyleEdgePadding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutEdge), typeof(LayoutValue)}, ReturnType = typeof(void))]
	[CallerCount(Count = 14)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public LayoutStyleData get_Style() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public static LayoutNode get_Undefined() { }

	[CallerCount(Count = 0)]
	public virtual int GetHashCode() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LayoutNode), Member = "get_Layout", ReturnType = typeof(LayoutComputedData&))]
	private float GetLayoutValue(Single* buffer, LayoutEdge edge) { }

	[CalledBy(Type = typeof(LayoutDelegates), Member = "InvokeMeasureFunction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutNode&), typeof(float), typeof(LayoutMeasureMode), typeof(float), typeof(LayoutMeasureMode), typeof(IntPtr&), typeof(LayoutSize&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(LayoutManager), Member = "GetManager", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(LayoutManager))]
	[Calls(Type = typeof(LayoutManager), Member = "GetOwner", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutHandle)}, ReturnType = typeof(VisualElement))]
	[CallsUnknownMethods(Count = 1)]
	public VisualElement GetOwner() { }

	[CalledBy(Type = typeof(Hierarchy), Member = "PutChildAtIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(LayoutList`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Allocator)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(LayoutList`1), Member = "Insert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), "T"}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsInvalidInstructions]
	[ContainsUnimplementedInstructions]
	public void Insert(int index, LayoutNode child) { }

	[CallerCount(Count = 33)]
	[Calls(Type = typeof(LayoutNode), Member = "get_IsDirty", ReturnType = typeof(bool))]
	[Calls(Type = typeof(LayoutNode), Member = "get_Layout", ReturnType = typeof(LayoutComputedData&))]
	[Calls(Type = typeof(LayoutNode), Member = "get_Parent", ReturnType = typeof(LayoutNode))]
	[Calls(Type = typeof(LayoutNode), Member = "MarkDirty", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public void MarkDirty() { }

	[CalledBy(Type = typeof(UIRLayoutUpdater), Member = "UpdateSubTree", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(System.Collections.Generic.List`1<System.ValueTuple`3<UnityEngine.Rect, UnityEngine.Rect, UnityEngine.UIElements.VisualElement>>)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public void MarkLayoutSeen() { }

	[CalledBy(Type = typeof(Hierarchy), Member = "RemoveChildAtIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LayoutNode), Member = "Clear", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Assert), Member = "IsTrue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(LayoutList`1), Member = "get_Count", ReturnType = typeof(int))]
	[Calls(Type = typeof(LayoutList`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T&")]
	[Calls(Type = typeof(LayoutList`1), Member = "RemoveAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(LayoutNode), Member = "MarkDirty", ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	[ContainsUnimplementedInstructions]
	public void RemoveAt(int index) { }

	[CalledBy(Type = typeof(ComputedStyle), Member = "ApplyPropertyAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StylePropertyId), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_alignContent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityEngine.UIElements.StyleEnum`1<UnityEngine.UIElements.Align>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LayoutNode), Member = "CopyFromComputedStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(LayoutNode), Member = "get_Style", ReturnType = typeof(LayoutStyleData&))]
	[Calls(Type = typeof(LayoutNode), Member = "MarkDirty", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public void set_AlignContent(LayoutAlign value) { }

	[CalledBy(Type = typeof(ComputedStyle), Member = "ApplyPropertyAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StylePropertyId), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_alignItems", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityEngine.UIElements.StyleEnum`1<UnityEngine.UIElements.Align>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LayoutNode), Member = "CopyFromComputedStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(LayoutNode), Member = "get_Style", ReturnType = typeof(LayoutStyleData&))]
	[Calls(Type = typeof(LayoutNode), Member = "MarkDirty", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public void set_AlignItems(LayoutAlign value) { }

	[CalledBy(Type = typeof(ComputedStyle), Member = "ApplyPropertyAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StylePropertyId), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_alignSelf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityEngine.UIElements.StyleEnum`1<UnityEngine.UIElements.Align>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LayoutNode), Member = "CopyFromComputedStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(LayoutNode), Member = "get_Style", ReturnType = typeof(LayoutStyleData&))]
	[Calls(Type = typeof(LayoutNode), Member = "MarkDirty", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public void set_AlignSelf(LayoutAlign value) { }

	[CalledBy(Type = typeof(ComputedStyle), Member = "ApplyPropertyAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StylePropertyId), typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_borderBottomWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleFloat)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LayoutNode), Member = "CopyFromComputedStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(LayoutNode), Member = "StyleEdgeSetPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutValue&), typeof(float)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public void set_BorderBottomWidth(float value) { }

	[CalledBy(Type = typeof(ComputedStyle), Member = "ApplyPropertyAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StylePropertyId), typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_borderLeftWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleFloat)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LayoutNode), Member = "CopyFromComputedStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(LayoutNode), Member = "StyleEdgeSetPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutValue&), typeof(float)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public void set_BorderLeftWidth(float value) { }

	[CalledBy(Type = typeof(ComputedStyle), Member = "ApplyPropertyAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StylePropertyId), typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_borderRightWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleFloat)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LayoutNode), Member = "CopyFromComputedStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(LayoutNode), Member = "StyleEdgeSetPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutValue&), typeof(float)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public void set_BorderRightWidth(float value) { }

	[CalledBy(Type = typeof(ComputedStyle), Member = "ApplyPropertyAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StylePropertyId), typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_borderTopWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleFloat)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LayoutNode), Member = "CopyFromComputedStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(LayoutNode), Member = "StyleEdgeSetPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutValue&), typeof(float)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public void set_BorderTopWidth(float value) { }

	[CalledBy(Type = typeof(ComputedStyle), Member = "ApplyPropertyAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StylePropertyId), typeof(Length)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_bottom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleLength)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(LayoutNode), Member = "SetStyleEdgePosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutEdge), typeof(LayoutValue)}, ReturnType = typeof(void))]
	public void set_Bottom(LayoutValue value) { }

	[CalledBy(Type = typeof(VisualElement), Member = "HasChangedPanel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseVisualElementPanel)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public void set_Config(LayoutConfig value) { }

	[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_display", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityEngine.UIElements.StyleEnum`1<UnityEngine.UIElements.DisplayStyle>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LayoutNode), Member = "CopyFromComputedStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(LayoutNode), Member = "get_Style", ReturnType = typeof(LayoutStyleData&))]
	[Calls(Type = typeof(LayoutNode), Member = "MarkDirty", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public void set_Display(LayoutDisplay value) { }

	[CalledBy(Type = typeof(ComputedStyle), Member = "ApplyPropertyAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StylePropertyId), typeof(Length)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_flexBasis", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleLength)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LayoutNode), Member = "CopyFromComputedStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(LayoutNode), Member = "SetStyleValueUnit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutValue&), typeof(LayoutValue)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public void set_FlexBasis(LayoutValue value) { }

	[CalledBy(Type = typeof(ComputedStyle), Member = "ApplyPropertyAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StylePropertyId), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_flexDirection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityEngine.UIElements.StyleEnum`1<UnityEngine.UIElements.FlexDirection>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LayoutNode), Member = "CopyFromComputedStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(LayoutNode), Member = "get_Style", ReturnType = typeof(LayoutStyleData&))]
	[Calls(Type = typeof(LayoutNode), Member = "MarkDirty", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public void set_FlexDirection(LayoutFlexDirection value) { }

	[CalledBy(Type = typeof(ComputedStyle), Member = "ApplyPropertyAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StylePropertyId), typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_flexGrow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleFloat)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LayoutNode), Member = "CopyFromComputedStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(float), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(LayoutNode), Member = "MarkDirty", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public void set_FlexGrow(float value) { }

	[CalledBy(Type = typeof(ComputedStyle), Member = "ApplyPropertyAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StylePropertyId), typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_flexShrink", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleFloat)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LayoutNode), Member = "CopyFromComputedStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(float), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(LayoutNode), Member = "MarkDirty", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public void set_FlexShrink(float value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public void set_HasNewLayout(bool value) { }

	[CalledBy(Type = typeof(ComputedStyle), Member = "ApplyPropertyAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StylePropertyId), typeof(Length)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_height", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleLength)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LayoutNode), Member = "CopyFromComputedStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(LayoutNode), Member = "SetStyleValueUnit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutValue&), typeof(LayoutValue)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public void set_Height(LayoutValue value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public void set_IsDirty(bool value) { }

	[CalledBy(Type = typeof(ComputedStyle), Member = "ApplyPropertyAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StylePropertyId), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_justifyContent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityEngine.UIElements.StyleEnum`1<UnityEngine.UIElements.Justify>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LayoutNode), Member = "CopyFromComputedStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(LayoutNode), Member = "get_Style", ReturnType = typeof(LayoutStyleData&))]
	[Calls(Type = typeof(LayoutNode), Member = "MarkDirty", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public void set_JustifyContent(LayoutJustify value) { }

	[CalledBy(Type = typeof(ComputedStyle), Member = "ApplyPropertyAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StylePropertyId), typeof(Length)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_left", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleLength)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(LayoutNode), Member = "SetStyleEdgePosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutEdge), typeof(LayoutValue)}, ReturnType = typeof(void))]
	public void set_Left(LayoutValue value) { }

	[CalledBy(Type = typeof(ComputedStyle), Member = "ApplyPropertyAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StylePropertyId), typeof(Length)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_marginBottom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleLength)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(LayoutNode), Member = "SetStyleEdgeMargin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutEdge), typeof(LayoutValue)}, ReturnType = typeof(void))]
	public void set_MarginBottom(LayoutValue value) { }

	[CalledBy(Type = typeof(ComputedStyle), Member = "ApplyPropertyAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StylePropertyId), typeof(Length)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_marginLeft", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleLength)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(LayoutNode), Member = "SetStyleEdgeMargin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutEdge), typeof(LayoutValue)}, ReturnType = typeof(void))]
	public void set_MarginLeft(LayoutValue value) { }

	[CalledBy(Type = typeof(ComputedStyle), Member = "ApplyPropertyAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StylePropertyId), typeof(Length)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_marginRight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleLength)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(LayoutNode), Member = "SetStyleEdgeMargin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutEdge), typeof(LayoutValue)}, ReturnType = typeof(void))]
	public void set_MarginRight(LayoutValue value) { }

	[CalledBy(Type = typeof(ComputedStyle), Member = "ApplyPropertyAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StylePropertyId), typeof(Length)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_marginTop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleLength)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(LayoutNode), Member = "SetStyleEdgeMargin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutEdge), typeof(LayoutValue)}, ReturnType = typeof(void))]
	public void set_MarginTop(LayoutValue value) { }

	[CalledBy(Type = typeof(ComputedStyle), Member = "ApplyPropertyAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StylePropertyId), typeof(Length)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_maxHeight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleLength)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LayoutNode), Member = "CopyFromComputedStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(LayoutNode), Member = "SetStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutValue&), typeof(LayoutValue)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public void set_MaxHeight(LayoutValue value) { }

	[CalledBy(Type = typeof(ComputedStyle), Member = "ApplyPropertyAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StylePropertyId), typeof(Length)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_maxWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleLength)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LayoutNode), Member = "CopyFromComputedStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(LayoutNode), Member = "SetStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutValue&), typeof(LayoutValue)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public void set_MaxWidth(LayoutValue value) { }

	[CalledBy(Type = typeof(VisualElement), Member = "set_requireMeasureFunction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VisualElement), Member = "AssignMeasureFunction", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VisualElement), Member = "RemoveMeasureFunction", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	public void set_Measure(LayoutMeasureFunction value) { }

	[CalledBy(Type = typeof(ComputedStyle), Member = "ApplyPropertyAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StylePropertyId), typeof(Length)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_minHeight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleLength)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LayoutNode), Member = "CopyFromComputedStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(LayoutNode), Member = "SetStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutValue&), typeof(LayoutValue)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public void set_MinHeight(LayoutValue value) { }

	[CalledBy(Type = typeof(ComputedStyle), Member = "ApplyPropertyAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StylePropertyId), typeof(Length)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_minWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleLength)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LayoutNode), Member = "CopyFromComputedStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(LayoutNode), Member = "SetStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutValue&), typeof(LayoutValue)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public void set_MinWidth(LayoutValue value) { }

	[CalledBy(Type = typeof(ComputedStyle), Member = "ApplyPropertyAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StylePropertyId), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_overflow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityEngine.UIElements.StyleEnum`1<UnityEngine.UIElements.Overflow>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LayoutNode), Member = "CopyFromComputedStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(LayoutNode), Member = "get_Style", ReturnType = typeof(LayoutStyleData&))]
	[Calls(Type = typeof(LayoutNode), Member = "MarkDirty", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public void set_Overflow(LayoutOverflow value) { }

	[CalledBy(Type = typeof(ComputedStyle), Member = "ApplyPropertyAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StylePropertyId), typeof(Length)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_paddingBottom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleLength)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(LayoutNode), Member = "SetStyleEdgePadding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutEdge), typeof(LayoutValue)}, ReturnType = typeof(void))]
	public void set_PaddingBottom(LayoutValue value) { }

	[CalledBy(Type = typeof(ComputedStyle), Member = "ApplyPropertyAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StylePropertyId), typeof(Length)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_paddingLeft", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleLength)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(LayoutNode), Member = "SetStyleEdgePadding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutEdge), typeof(LayoutValue)}, ReturnType = typeof(void))]
	public void set_PaddingLeft(LayoutValue value) { }

	[CalledBy(Type = typeof(ComputedStyle), Member = "ApplyPropertyAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StylePropertyId), typeof(Length)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_paddingRight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleLength)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(LayoutNode), Member = "SetStyleEdgePadding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutEdge), typeof(LayoutValue)}, ReturnType = typeof(void))]
	public void set_PaddingRight(LayoutValue value) { }

	[CalledBy(Type = typeof(ComputedStyle), Member = "ApplyPropertyAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StylePropertyId), typeof(Length)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_paddingTop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleLength)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(LayoutNode), Member = "SetStyleEdgePadding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutEdge), typeof(LayoutValue)}, ReturnType = typeof(void))]
	public void set_PaddingTop(LayoutValue value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public void set_Parent(LayoutNode value) { }

	[CalledBy(Type = typeof(ComputedStyle), Member = "ApplyPropertyAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StylePropertyId), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_position", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityEngine.UIElements.StyleEnum`1<UnityEngine.UIElements.Position>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LayoutNode), Member = "CopyFromComputedStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(LayoutNode), Member = "get_Style", ReturnType = typeof(LayoutStyleData&))]
	[Calls(Type = typeof(LayoutNode), Member = "MarkDirty", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public void set_PositionType(LayoutPositionType value) { }

	[CalledBy(Type = typeof(ComputedStyle), Member = "ApplyPropertyAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StylePropertyId), typeof(Length)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_right", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleLength)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(LayoutNode), Member = "SetStyleEdgePosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutEdge), typeof(LayoutValue)}, ReturnType = typeof(void))]
	public void set_Right(LayoutValue value) { }

	[CalledBy(Type = typeof(ComputedStyle), Member = "ApplyPropertyAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StylePropertyId), typeof(Length)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_top", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleLength)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(LayoutNode), Member = "SetStyleEdgePosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutEdge), typeof(LayoutValue)}, ReturnType = typeof(void))]
	public void set_Top(LayoutValue value) { }

	[CalledBy(Type = typeof(ComputedStyle), Member = "ApplyPropertyAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StylePropertyId), typeof(Length)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_width", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleLength)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LayoutNode), Member = "CopyFromComputedStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(LayoutNode), Member = "SetStyleValueUnit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutValue&), typeof(LayoutValue)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public void set_Width(LayoutValue value) { }

	[CalledBy(Type = typeof(ComputedStyle), Member = "ApplyPropertyAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StylePropertyId), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_flexWrap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityEngine.UIElements.StyleEnum`1<UnityEngine.UIElements.Wrap>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LayoutNode), Member = "CopyFromComputedStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(LayoutNode), Member = "get_Style", ReturnType = typeof(LayoutStyleData&))]
	[Calls(Type = typeof(LayoutNode), Member = "MarkDirty", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public void set_Wrap(LayoutWrap value) { }

	[CalledBy(Type = typeof(VisualElement), Member = "set_requireMeasureFunction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VisualElement), Member = "AssignMeasureFunction", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VisualElement), Member = "RemoveMeasureFunction", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	public void SetOwner(VisualElement func) { }

	[CalledBy(Type = typeof(LayoutNode), Member = "set_MarginLeft", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutValue)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LayoutNode), Member = "set_MarginTop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutValue)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LayoutNode), Member = "set_MarginRight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutValue)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LayoutNode), Member = "set_MarginBottom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutValue)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LayoutNode), Member = "CopyFromComputedStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle)}, ReturnType = typeof(void))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(LayoutNode), Member = "get_Style", ReturnType = typeof(LayoutStyleData&))]
	[Calls(Type = typeof(LayoutNode), Member = "MarkDirty", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	private void SetStyleEdgeMargin(LayoutEdge edge, LayoutValue value) { }

	[CalledBy(Type = typeof(LayoutNode), Member = "set_PaddingLeft", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutValue)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LayoutNode), Member = "set_PaddingTop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutValue)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LayoutNode), Member = "set_PaddingRight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutValue)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LayoutNode), Member = "set_PaddingBottom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutValue)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LayoutNode), Member = "CopyFromComputedStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle)}, ReturnType = typeof(void))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(LayoutNode), Member = "get_Style", ReturnType = typeof(LayoutStyleData&))]
	[Calls(Type = typeof(LayoutNode), Member = "MarkDirty", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private void SetStyleEdgePadding(LayoutEdge edge, LayoutValue value) { }

	[CalledBy(Type = typeof(LayoutNode), Member = "set_Left", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutValue)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LayoutNode), Member = "set_Top", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutValue)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LayoutNode), Member = "set_Right", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutValue)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LayoutNode), Member = "set_Bottom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutValue)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LayoutNode), Member = "CopyFromComputedStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle)}, ReturnType = typeof(void))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(LayoutNode), Member = "get_Style", ReturnType = typeof(LayoutStyleData&))]
	[Calls(Type = typeof(LayoutNode), Member = "MarkDirty", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private void SetStyleEdgePosition(LayoutEdge edge, LayoutValue value) { }

	[CalledBy(Type = typeof(LayoutNode), Member = "set_MaxWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutValue)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LayoutNode), Member = "set_MaxHeight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutValue)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LayoutNode), Member = "set_MinWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutValue)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LayoutNode), Member = "set_MinHeight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutValue)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(LayoutNode), Member = "MarkDirty", ReturnType = typeof(void))]
	[ContainsUnimplementedInstructions]
	private void SetStyleValue(ref LayoutValue currentValue, LayoutValue newValue) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LayoutNode), Member = "MarkDirty", ReturnType = typeof(void))]
	[DeduplicatedMethod]
	private void SetStyleValueAuto(ref LayoutValue currentValue) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LayoutNode), Member = "MarkDirty", ReturnType = typeof(void))]
	[ContainsUnimplementedInstructions]
	private void SetStyleValuePercent(ref LayoutValue currentValue, LayoutValue newValue) { }

	[CalledBy(Type = typeof(LayoutNode), Member = "SetStyleValueUnit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutValue&), typeof(LayoutValue)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(LayoutNode), Member = "MarkDirty", ReturnType = typeof(void))]
	[ContainsUnimplementedInstructions]
	private void SetStyleValuePoint(ref LayoutValue currentValue, LayoutValue newValue) { }

	[CalledBy(Type = typeof(LayoutNode), Member = "set_FlexBasis", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutValue)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LayoutNode), Member = "set_Width", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutValue)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LayoutNode), Member = "set_Height", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutValue)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(LayoutNode), Member = "SetStyleValuePoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutValue&), typeof(LayoutValue)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(LayoutNode), Member = "MarkDirty", ReturnType = typeof(void))]
	[ContainsUnimplementedInstructions]
	private void SetStyleValueUnit(ref LayoutValue currentValue, LayoutValue newValue) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(float), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(LayoutNode), Member = "MarkDirty", ReturnType = typeof(void))]
	private void SetValue(ref float currentValue, float newValue) { }

	[CalledBy(Type = typeof(VisualElement), Member = "HasChangedPanel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseVisualElementPanel)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public void SoftReset() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LayoutNode), Member = "MarkDirty", ReturnType = typeof(void))]
	[DeduplicatedMethod]
	private void StyleEdgeSetAuto(ref LayoutValue value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LayoutNode), Member = "MarkDirty", ReturnType = typeof(void))]
	[ContainsUnimplementedInstructions]
	private void StyleEdgeSetPercent(ref LayoutValue value, float newValue) { }

	[CalledBy(Type = typeof(LayoutNode), Member = "set_BorderLeftWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LayoutNode), Member = "set_BorderTopWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LayoutNode), Member = "set_BorderRightWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LayoutNode), Member = "set_BorderBottomWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(LayoutNode), Member = "MarkDirty", ReturnType = typeof(void))]
	[ContainsUnimplementedInstructions]
	private void StyleEdgeSetPoint(ref LayoutValue value, float newValue) { }

}

