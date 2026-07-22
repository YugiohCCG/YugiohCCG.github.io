namespace UnityEngine.UIElements;

public class ScrollView : VisualElement
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Predicate<VisualElement> <>9__196_0; //Field offset: 0x8

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		private static <>c() { }

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c() { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		internal bool <ReadSingleLineHeight>b__196_0(VisualElement x) { }

	}

	internal enum NestedInteractionKind
	{
		Default = 0,
		StopScrolling = 1,
		ForwardScrolling = 2,
	}

	internal enum TouchScrollBehavior
	{
		Unrestricted = 0,
		Elastic = 1,
		Clamped = 2,
	}

	public enum TouchScrollingResult
	{
		Apply = 0,
		Forward = 1,
		Block = 2,
	}

	[Obsolete("UxmlFactory is deprecated and will be removed. Use UxmlElementAttribute instead.", False)]
	internal class UxmlFactory : UxmlFactory<ScrollView, UxmlTraits>
	{

		[CalledBy(Type = typeof(VisualElementFactoryRegistry), Member = "RegisterEngineFactories", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(UxmlFactory`2), Member = ".ctor", ReturnType = typeof(void))]
		public UxmlFactory() { }

	}

	[Obsolete("UxmlTraits is deprecated and will be removed. Use UxmlElementAttribute instead.", False)]
	internal class UxmlTraits : UxmlTraits
	{
		private UxmlEnumAttributeDescription<ScrollViewMode> m_ScrollViewMode; //Field offset: 0x88
		private UxmlEnumAttributeDescription<NestedInteractionKind> m_NestedInteractionKind; //Field offset: 0x90
		private UxmlBoolAttributeDescription m_ShowHorizontal; //Field offset: 0x98
		private UxmlBoolAttributeDescription m_ShowVertical; //Field offset: 0xA0
		private UxmlEnumAttributeDescription<ScrollerVisibility> m_HorizontalScrollerVisibility; //Field offset: 0xA8
		private UxmlEnumAttributeDescription<ScrollerVisibility> m_VerticalScrollerVisibility; //Field offset: 0xB0
		private UxmlFloatAttributeDescription m_HorizontalPageSize; //Field offset: 0xB8
		private UxmlFloatAttributeDescription m_VerticalPageSize; //Field offset: 0xC0
		private UxmlFloatAttributeDescription m_MouseWheelScrollSize; //Field offset: 0xC8
		private UxmlEnumAttributeDescription<TouchScrollBehavior> m_TouchScrollBehavior; //Field offset: 0xD0
		private UxmlFloatAttributeDescription m_ScrollDecelerationRate; //Field offset: 0xD8
		private UxmlFloatAttributeDescription m_Elasticity; //Field offset: 0xE0

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UxmlEnumAttributeDescription`1), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(UxmlBoolAttributeDescription), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(UxmlFloatAttributeDescription), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(UxmlTraits), Member = ".ctor", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 25)]
		public UxmlTraits() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UxmlTraits), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ScrollView), Member = "SetScrollViewMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScrollViewMode)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(UxmlEnumAttributeDescription`1), Member = "TryGetValueFromBag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IUxmlAttributes), typeof(CreationContext), "T&"}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(ScrollView), Member = "get_scrollableWidth", ReturnType = typeof(float))]
		[Calls(Type = typeof(ScrollView), Member = "get_scrollableHeight", ReturnType = typeof(float))]
		[Calls(Type = typeof(ScrollView), Member = "UpdateScrollers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ScrollView), Member = "set_horizontalPageSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ScrollView), Member = "set_verticalPageSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ScrollView), Member = "set_touchScrollBehavior", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TouchScrollBehavior)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 10)]
		[CallsUnknownMethods(Count = 2)]
		[ContainsUnimplementedInstructions]
		public virtual void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc) { }

	}

	internal static readonly BindingId horizontalScrollerVisibilityProperty; //Field offset: 0x0
	internal static readonly BindingId verticalScrollerVisibilityProperty; //Field offset: 0x98
	internal static readonly BindingId scrollOffsetProperty; //Field offset: 0x130
	internal static readonly BindingId horizontalPageSizeProperty; //Field offset: 0x1C8
	internal static readonly BindingId verticalPageSizeProperty; //Field offset: 0x260
	internal static readonly BindingId mouseWheelScrollSizeProperty; //Field offset: 0x2F8
	internal static readonly BindingId scrollDecelerationRateProperty; //Field offset: 0x390
	internal static readonly BindingId elasticityProperty; //Field offset: 0x428
	internal static readonly BindingId touchScrollBehaviorProperty; //Field offset: 0x4C0
	internal static readonly BindingId nestedInteractionKindProperty; //Field offset: 0x558
	internal static readonly BindingId modeProperty; //Field offset: 0x5F0
	internal static readonly BindingId elasticAnimationIntervalMsProperty; //Field offset: 0x688
	private static readonly float k_DefaultScrollDecelerationRate; //Field offset: 0x720
	private static readonly float k_DefaultElasticity; //Field offset: 0x724
	public static readonly string ussClassName; //Field offset: 0x728
	public static readonly string viewportUssClassName; //Field offset: 0x730
	public static readonly string horizontalVariantViewportUssClassName; //Field offset: 0x738
	public static readonly string verticalVariantViewportUssClassName; //Field offset: 0x740
	public static readonly string verticalHorizontalVariantViewportUssClassName; //Field offset: 0x748
	public static readonly string contentAndVerticalScrollUssClassName; //Field offset: 0x750
	public static readonly string contentUssClassName; //Field offset: 0x758
	public static readonly string horizontalVariantContentUssClassName; //Field offset: 0x760
	public static readonly string verticalVariantContentUssClassName; //Field offset: 0x768
	public static readonly string verticalHorizontalVariantContentUssClassName; //Field offset: 0x770
	public static readonly string hScrollerUssClassName; //Field offset: 0x778
	public static readonly string vScrollerUssClassName; //Field offset: 0x780
	public static readonly string horizontalVariantUssClassName; //Field offset: 0x788
	public static readonly string verticalVariantUssClassName; //Field offset: 0x790
	public static readonly string verticalHorizontalVariantUssClassName; //Field offset: 0x798
	public static readonly string scrollVariantUssClassName; //Field offset: 0x7A0
	private int m_FirstLayoutPass; //Field offset: 0x4A8
	private ScrollerVisibility m_HorizontalScrollerVisibility; //Field offset: 0x4AC
	private ScrollerVisibility m_VerticalScrollerVisibility; //Field offset: 0x4B0
	private long m_ElasticAnimationIntervalMs; //Field offset: 0x4B8
	private VisualElement m_AttachedRootVisualContainer; //Field offset: 0x4C0
	private float m_SingleLineHeight; //Field offset: 0x4C8
	private bool m_SingleLineHeightDirtyFlag; //Field offset: 0x4CC
	internal bool m_MouseWheelScrollSizeIsInline; //Field offset: 0x4CD
	[DontCreateProperty]
	[SerializeField]
	private Vector2 m_ScrollOffset; //Field offset: 0x4D0
	private float m_HorizontalPageSize; //Field offset: 0x4D8
	private float m_VerticalPageSize; //Field offset: 0x4DC
	private float m_MouseWheelScrollSize; //Field offset: 0x4E0
	private float m_ScrollDecelerationRate; //Field offset: 0x4E4
	private float k_ScaledPixelsPerPointMultiplier; //Field offset: 0x4E8
	private float k_TouchScrollInertiaBaseTimeInterval; //Field offset: 0x4EC
	private float m_Elasticity; //Field offset: 0x4F0
	private TouchScrollBehavior m_TouchScrollBehavior; //Field offset: 0x4F4
	private NestedInteractionKind m_NestedInteractionKind; //Field offset: 0x4F8
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private readonly VisualElement <contentViewport>k__BackingField; //Field offset: 0x500
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private readonly Scroller <horizontalScroller>k__BackingField; //Field offset: 0x508
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private readonly Scroller <verticalScroller>k__BackingField; //Field offset: 0x510
	private VisualElement m_ContentContainer; //Field offset: 0x518
	private VisualElement m_ContentAndVerticalScrollContainer; //Field offset: 0x520
	private float previousVerticalTouchScrollTimeStamp; //Field offset: 0x528
	private float previousHorizontalTouchScrollTimeStamp; //Field offset: 0x52C
	private float elapsedTimeSinceLastVerticalTouchScroll; //Field offset: 0x530
	private float elapsedTimeSinceLastHorizontalTouchScroll; //Field offset: 0x534
	private ScrollViewMode m_Mode; //Field offset: 0x538
	private IVisualElementScheduledItem m_ScheduledLayoutPassResetItem; //Field offset: 0x540
	private Vector2 m_StartPosition; //Field offset: 0x548
	private Vector2 m_PointerStartPosition; //Field offset: 0x550
	private Vector2 m_Velocity; //Field offset: 0x558
	private Vector2 m_SpringBackVelocity; //Field offset: 0x560
	private Vector2 m_LowBounds; //Field offset: 0x568
	private Vector2 m_HighBounds; //Field offset: 0x570
	private float m_LastVelocityLerpTime; //Field offset: 0x578
	private bool m_StartedMoving; //Field offset: 0x57C
	private bool m_TouchPointerMoveAllowed; //Field offset: 0x57D
	private bool m_TouchStoppedVelocity; //Field offset: 0x57E
	private VisualElement m_CapturedTarget; //Field offset: 0x580
	private EventCallback<PointerMoveEvent> m_CapturedTargetPointerMoveCallback; //Field offset: 0x588
	private EventCallback<PointerUpEvent> m_CapturedTargetPointerUpCallback; //Field offset: 0x590
	internal IVisualElementScheduledItem m_PostPointerUpAnimation; //Field offset: 0x598

	public virtual VisualElement contentContainer
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 10
	}

	public VisualElement contentViewport
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 8
	}

	[CreateProperty]
	public long elasticAnimationIntervalMs
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 10
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 4)]
		 set { } //Length: 328
	}

	[CreateProperty]
	public float elasticity
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 11
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
		[ContainsUnimplementedInstructions]
		 set { } //Length: 264
	}

	private bool hasInertia
	{
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		private get { } //Length: 20
	}

	[CreateProperty]
	public float horizontalPageSize
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 11
		[CalledBy(Type = typeof(UxmlTraits), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ScrollView), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScrollViewMode)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(ScrollView), Member = "UpdateHorizontalSliderPageSize", ReturnType = typeof(void))]
		[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		 set { } //Length: 171
	}

	public Scroller horizontalScroller
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 8
	}

	[CreateProperty]
	public ScrollerVisibility horizontalScrollerVisibility
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 9
		[CalledBy(Type = typeof(UxmlTraits), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(BaseVerticalCollectionView), Member = "set_horizontalScrollingEnabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TextInputBase), Member = "SetMultiline", ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(ScrollView), Member = "get_scrollableWidth", ReturnType = typeof(float))]
		[Calls(Type = typeof(ScrollView), Member = "get_scrollableHeight", ReturnType = typeof(float))]
		[Calls(Type = typeof(ScrollView), Member = "UpdateScrollers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
		[ContainsUnimplementedInstructions]
		 set { } //Length: 240
	}

	internal bool isHorizontalScrollDisplayed
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
		[CallsUnknownMethods(Count = 2)]
		[ContainsUnimplementedInstructions]
		internal get { } //Length: 97
	}

	internal bool isVerticalScrollDisplayed
	{
		[CalledBy(Type = typeof(GenericDropdownMenu), Member = "EnsureVisibilityInParent", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
		[CallsUnknownMethods(Count = 2)]
		[ContainsUnimplementedInstructions]
		internal get { } //Length: 97
	}

	[CreateProperty]
	public ScrollViewMode mode
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 7
		[CalledBy(Type = typeof(UxmlTraits), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(BaseVerticalCollectionView), Member = "set_horizontalScrollingEnabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(GenericDropdownMenu), Member = ".ctor", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TextInputBase), Member = "SetScrollViewMode", ReturnType = typeof(void))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(ScrollView), Member = "SetScrollViewMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScrollViewMode)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
		 set { } //Length: 147
	}

	[CreateProperty]
	public float mouseWheelScrollSize
	{
		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		 get { } //Length: 11
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
		 set { } //Length: 198
	}

	internal bool needsHorizontal
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ScrollView), Member = "get_scrollableWidth", ReturnType = typeof(float))]
		[ContainsUnimplementedInstructions]
		internal get { } //Length: 70
	}

	internal bool needsVertical
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ScrollView), Member = "get_scrollableHeight", ReturnType = typeof(float))]
		[ContainsUnimplementedInstructions]
		[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
		internal get { } //Length: 70
	}

	[CreateProperty]
	public NestedInteractionKind nestedInteractionKind
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 7
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
		 set { } //Length: 126
	}

	internal float scrollableHeight
	{
		[CalledBy(Type = typeof(UxmlTraits), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ScrollView), Member = "OnScrollWheel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WheelEvent)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ScrollView), Member = "UpdateScrollers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ScrollView), Member = "OnVerticalSliderViewDataRestored", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ScrollView), Member = "GetYDeltaOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(float))]
		[CalledBy(Type = typeof(ScrollView), Member = "ScrollTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ScrollView), Member = "OnGeometryChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GeometryChangedEvent)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ScrollView), Member = "set_scrollOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ScrollView), Member = "get_needsVertical", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(ScrollView), Member = "set_verticalScrollerVisibility", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScrollerVisibility)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ScrollView), Member = "set_horizontalScrollerVisibility", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScrollerVisibility)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ScrollView), Member = "UpdateContentViewTransform", ReturnType = typeof(void))]
		[CallerCount(Count = 13)]
		[Calls(Type = typeof(VisualElement), Member = "get_boundingBox", ReturnType = typeof(Rect))]
		[Calls(Type = typeof(VisualElement), Member = "get_layout", ReturnType = typeof(Rect))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		internal get { } //Length: 105
	}

	internal float scrollableWidth
	{
		[CalledBy(Type = typeof(UxmlTraits), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ScrollView), Member = "OnScrollWheel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WheelEvent)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ScrollView), Member = "OnScrollersGeometryChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GeometryChangedEvent)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ScrollView), Member = "UpdateScrollers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ScrollView), Member = "OnGeometryChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GeometryChangedEvent)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ScrollView), Member = "GetXDeltaOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(float))]
		[CalledBy(Type = typeof(ScrollView), Member = "OnHorizontalSliderViewDataRestored", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ScrollView), Member = "set_scrollOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ScrollView), Member = "get_needsHorizontal", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(ScrollView), Member = "set_verticalScrollerVisibility", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScrollerVisibility)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ScrollView), Member = "set_horizontalScrollerVisibility", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScrollerVisibility)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ScrollView), Member = "ScrollTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
		[CallerCount(Count = 13)]
		[Calls(Type = typeof(VisualElement), Member = "get_boundingBox", ReturnType = typeof(Rect))]
		[Calls(Type = typeof(VisualElement), Member = "get_layout", ReturnType = typeof(Rect))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		internal get { } //Length: 105
	}

	[CreateProperty]
	public float scrollDecelerationRate
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 11
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
		[ContainsUnimplementedInstructions]
		 set { } //Length: 264
	}

	[CreateProperty]
	public Vector2 scrollOffset
	{
		[CalledBy(Type = typeof(DynamicHeightVirtualizationController`1), Member = "get_viewportMaxOffset", ReturnType = typeof(float))]
		[CalledBy(Type = typeof(ListViewDragger), Member = "HandleDragAndScroll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TextInputBase), Member = "GetScrollOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(float), typeof(bool), typeof(bool)}, ReturnType = typeof(Vector2))]
		[CalledBy(Type = typeof(TextInputBase), Member = "UpdateScrollOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(FixedHeightVirtualizationController`1), Member = "EndDrag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(FixedHeightVirtualizationController`1), Member = "OnScrollUpdate", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(FixedHeightVirtualizationController`1), Member = "Resize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(FixedHeightVirtualizationController`1), Member = "ScrollToItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DynamicHeightVirtualizationController`1), Member = "EndDrag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DynamicHeightVirtualizationController`1), Member = "UpdateRegisteredHeight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ReusableCollectionItem)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(DynamicHeightVirtualizationController`1), Member = "UpdateAnchor", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DynamicHeightVirtualizationController`1), Member = "ApplyScrollViewUpdate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DynamicHeightVirtualizationController`1), Member = "UpdateScrollViewContainer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DynamicHeightVirtualizationController`1), Member = "Fill", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DynamicHeightVirtualizationController`1), Member = "NeedsFill", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(DynamicHeightVirtualizationController`1), Member = "OnScrollUpdate", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DynamicHeightVirtualizationController`1), Member = "OnScroll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DynamicHeightVirtualizationController`1), Member = "ScrollToItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ListViewDragger), Member = "TryGetDragPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(DragPosition&)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 38)]
		 get { } //Length: 27
		[CalledBy(Type = typeof(ScrollView), Member = "<.ctor>b__140_1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ListViewDragger), Member = "HandleDragAndScroll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ScrollView), Member = "ApplyTouchScrolling", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(ScrollView), Member = "ApplyScrollInertia", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ScrollView), Member = "SpringBack", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ScrollView), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScrollViewMode)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ScrollView), Member = "<.ctor>b__140_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(FixedHeightVirtualizationController`1), Member = "ScrollToItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DynamicHeightVirtualizationController`1), Member = "RefreshScrollOffset", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DynamicHeightVirtualizationController`1), Member = "Fill", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DynamicHeightVirtualizationController`1), Member = "ScrollToItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TextInputBase), Member = "UpdateScrollOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 13)]
		[Calls(Type = typeof(ScrollView), Member = "UpdateContentViewTransform", ReturnType = typeof(void))]
		[Calls(Type = typeof(Scroller), Member = "set_value", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(VisualElement), Member = "SaveViewData", ReturnType = typeof(void))]
		[Calls(Type = typeof(VisualElement), Member = "get_panel", ReturnType = typeof(IPanel))]
		[Calls(Type = typeof(ScrollView), Member = "get_scrollableWidth", ReturnType = typeof(float))]
		[Calls(Type = typeof(ScrollView), Member = "get_scrollableHeight", ReturnType = typeof(float))]
		[Calls(Type = typeof(ScrollView), Member = "UpdateScrollers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		 set { } //Length: 546
	}

	[Obsolete("showHorizontal is obsolete. Use horizontalScrollerVisibility instead")]
	public bool showHorizontal
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		 set { } //Length: 28
	}

	[Obsolete("showVertical is obsolete. Use verticalScrollerVisibility instead")]
	public bool showVertical
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		 set { } //Length: 28
	}

	[CreateProperty]
	public TouchScrollBehavior touchScrollBehavior
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 9
		[CalledBy(Type = typeof(GenericDropdownMenu), Member = ".ctor", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UxmlTraits), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ScrollView), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScrollViewMode)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		 set { } //Length: 271
	}

	[CreateProperty]
	public float verticalPageSize
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 11
		[CalledBy(Type = typeof(UxmlTraits), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ScrollView), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScrollViewMode)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(ScrollView), Member = "UpdateVerticalSliderPageSize", ReturnType = typeof(void))]
		[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		 set { } //Length: 171
	}

	public Scroller verticalScroller
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 8
	}

	[CreateProperty]
	public ScrollerVisibility verticalScrollerVisibility
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 9
		[CalledBy(Type = typeof(TextInputBase), Member = "SetMultiline", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TextInputBase), Member = "SetVerticalScrollerVisibility", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScrollerVisibility)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(ScrollView), Member = "get_scrollableWidth", ReturnType = typeof(float))]
		[Calls(Type = typeof(ScrollView), Member = "get_scrollableHeight", ReturnType = typeof(float))]
		[Calls(Type = typeof(ScrollView), Member = "UpdateScrollers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
		[ContainsUnimplementedInstructions]
		 set { } //Length: 256
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BindingId), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(BindingId))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 28)]
	private static ScrollView() { }

	[CalledBy(Type = typeof(ScrollView), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(VisualElement), Member = "set_receivesHierarchyGeometryChangedEvents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ScrollView), Member = "set_scrollOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ScrollView), Member = "set_verticalPageSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ScrollView), Member = "set_horizontalPageSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CallbackEventHandler), Member = "RegisterCallback", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TEventType"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.EventCallback`1<TEventType>", typeof(InvokePolicy), typeof(TrickleDown)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ScrollView), Member = "set_touchScrollBehavior", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TouchScrollBehavior)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Clickable), Member = "add_clicked", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UnityEngine.UIElements.ClampedDragger`1<System.Single>), Member = "add_draggingEnded", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseSlider`1), Member = "add_onSetValueWithoutNotify", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Action`1<TValueType>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UnityEngine.UIElements.BaseField`1<System.Single>), Member = "add_viewDataRestored", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StyleEnum`1), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "UnityEngine.UIElements.StyleEnum`1<T>")]
	[Calls(Type = typeof(VisualElement), Member = "get_style", ReturnType = typeof(IStyle))]
	[Calls(Type = typeof(VisualElement), Member = "set_viewDataKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Scroller), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(System.Action`1<System.Single>), typeof(SliderDirection)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ScrollView), Member = "SetScrollViewMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScrollViewMode)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "set_usageHints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UsageHints)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "set_disableClipping", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "set_pickingMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PickingMode)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CallbackEventHandler), Member = "RegisterCallback", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TEventType"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.EventCallback`1<TEventType>", typeof(TrickleDown)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Hierarchy), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "set_name", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "AddToClassList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 23)]
	[CallsUnknownMethods(Count = 10)]
	public ScrollView(ScrollViewMode scrollViewMode) { }

	[CalledBy(Type = typeof(BaseVerticalCollectionView), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GenericDropdownMenu), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextInputBase), Member = "SetMultiline", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(ScrollView), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScrollViewMode)}, ReturnType = typeof(void))]
	public ScrollView() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ScrollView), Member = "set_scrollOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ScrollView), Member = "UpdateContentViewTransform", ReturnType = typeof(void))]
	[CompilerGenerated]
	private void <.ctor>b__140_0(float value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ScrollView), Member = "set_scrollOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[CompilerGenerated]
	[ContainsInvalidInstructions]
	private void <.ctor>b__140_1(float value) { }

	[CalledBy(Type = typeof(ScrollView), Member = "UpdateScrollers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScrollView), Member = "OnScrollersGeometryChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GeometryChangedEvent)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(VisualElement), Member = "get_boundingBox", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(VisualElement), Member = "get_layout", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(Scroller), Member = "Adjust", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	private void AdjustScrollers() { }

	[CalledBy(Type = typeof(ScrollView), Member = "PostPointerUpAnimation", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(VisualElement), Member = "get_scaledPixelsPerPoint", ReturnType = typeof(float))]
	[Calls(Type = typeof(ScrollView), Member = "set_scrollOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	internal void ApplyScrollInertia() { }

	[CalledBy(Type = typeof(ScrollView), Member = "ComputeTouchScrolling", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(TouchScrollingResult))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Time), Member = "get_unscaledTime", ReturnType = typeof(float))]
	[Calls(Type = "UnityEngine.Rendering.MousePositionDebug", Member = "GetMouseClickPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(ScrollView), Member = "set_scrollOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[ContainsUnimplementedInstructions]
	private bool ApplyTouchScrolling(Vector2 newScrollOffset) { }

	[CalledBy(Type = typeof(ScrollView), Member = "ComputeTouchScrolling", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(TouchScrollingResult))]
	[CallerCount(Count = 2)]
	[ContainsUnimplementedInstructions]
	private static float ComputeElasticOffset(float deltaPointer, float initialScrollOffset, float lowLimit, float hardLowLimit, float highLimit, float hardHighLimit) { }

	[CallerCount(Count = 0)]
	private void ComputeInitialSpringBackVelocity() { }

	[CalledBy(Type = typeof(ScrollView), Member = "OnPointerMove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerMoveEvent)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
	[Calls(Type = typeof(ScrollView), Member = "ComputeElasticOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(Time), Member = "get_unscaledTime", ReturnType = typeof(float))]
	[Calls(Type = typeof(ScrollView), Member = "ApplyTouchScrolling", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 5)]
	[ContainsUnimplementedInstructions]
	internal TouchScrollingResult ComputeTouchScrolling(Vector2 position) { }

	[CalledBy(Type = typeof(ScrollView), Member = "ReleaseScrolling", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(IEventHandler)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ScrollView), Member = "UpdateElasticBehaviour", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	private void ExecuteElasticSpringAnimation() { }

	[CallerCount(Count = 0)]
	public virtual VisualElement get_contentContainer() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public VisualElement get_contentViewport() { }

	[CallerCount(Count = 0)]
	public long get_elasticAnimationIntervalMs() { }

	[CallerCount(Count = 0)]
	public float get_elasticity() { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	private bool get_hasInertia() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public float get_horizontalPageSize() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public Scroller get_horizontalScroller() { }

	[CallerCount(Count = 0)]
	public ScrollerVisibility get_horizontalScrollerVisibility() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	internal bool get_isHorizontalScrollDisplayed() { }

	[CalledBy(Type = typeof(GenericDropdownMenu), Member = "EnsureVisibilityInParent", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	internal bool get_isVerticalScrollDisplayed() { }

	[CallerCount(Count = 0)]
	public ScrollViewMode get_mode() { }

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public float get_mouseWheelScrollSize() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ScrollView), Member = "get_scrollableWidth", ReturnType = typeof(float))]
	[ContainsUnimplementedInstructions]
	internal bool get_needsHorizontal() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ScrollView), Member = "get_scrollableHeight", ReturnType = typeof(float))]
	[ContainsUnimplementedInstructions]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal bool get_needsVertical() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public NestedInteractionKind get_nestedInteractionKind() { }

	[CalledBy(Type = typeof(UxmlTraits), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScrollView), Member = "UpdateContentViewTransform", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScrollView), Member = "set_horizontalScrollerVisibility", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScrollerVisibility)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScrollView), Member = "set_verticalScrollerVisibility", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScrollerVisibility)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScrollView), Member = "set_scrollOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScrollView), Member = "OnGeometryChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GeometryChangedEvent)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScrollView), Member = "get_needsVertical", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ScrollView), Member = "GetYDeltaOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(float))]
	[CalledBy(Type = typeof(ScrollView), Member = "OnVerticalSliderViewDataRestored", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScrollView), Member = "UpdateScrollers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScrollView), Member = "OnScrollWheel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WheelEvent)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScrollView), Member = "ScrollTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[CallerCount(Count = 13)]
	[Calls(Type = typeof(VisualElement), Member = "get_boundingBox", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(VisualElement), Member = "get_layout", ReturnType = typeof(Rect))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	internal float get_scrollableHeight() { }

	[CalledBy(Type = typeof(UxmlTraits), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScrollView), Member = "ScrollTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScrollView), Member = "set_horizontalScrollerVisibility", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScrollerVisibility)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScrollView), Member = "set_verticalScrollerVisibility", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScrollerVisibility)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScrollView), Member = "set_scrollOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScrollView), Member = "OnHorizontalSliderViewDataRestored", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScrollView), Member = "get_needsHorizontal", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ScrollView), Member = "OnGeometryChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GeometryChangedEvent)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScrollView), Member = "UpdateScrollers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScrollView), Member = "OnScrollersGeometryChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GeometryChangedEvent)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScrollView), Member = "OnScrollWheel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WheelEvent)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScrollView), Member = "GetXDeltaOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(float))]
	[CallerCount(Count = 13)]
	[Calls(Type = typeof(VisualElement), Member = "get_boundingBox", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(VisualElement), Member = "get_layout", ReturnType = typeof(Rect))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	internal float get_scrollableWidth() { }

	[CallerCount(Count = 0)]
	public float get_scrollDecelerationRate() { }

	[CalledBy(Type = typeof(DynamicHeightVirtualizationController`1), Member = "get_viewportMaxOffset", ReturnType = typeof(float))]
	[CalledBy(Type = typeof(DynamicHeightVirtualizationController`1), Member = "ScrollToItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DynamicHeightVirtualizationController`1), Member = "OnScroll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DynamicHeightVirtualizationController`1), Member = "OnScrollUpdate", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DynamicHeightVirtualizationController`1), Member = "NeedsFill", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DynamicHeightVirtualizationController`1), Member = "Fill", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DynamicHeightVirtualizationController`1), Member = "UpdateScrollViewContainer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DynamicHeightVirtualizationController`1), Member = "ApplyScrollViewUpdate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DynamicHeightVirtualizationController`1), Member = "UpdateAnchor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DynamicHeightVirtualizationController`1), Member = "UpdateRegisteredHeight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ReusableCollectionItem)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DynamicHeightVirtualizationController`1), Member = "EndDrag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FixedHeightVirtualizationController`1), Member = "ScrollToItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FixedHeightVirtualizationController`1), Member = "Resize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FixedHeightVirtualizationController`1), Member = "OnScrollUpdate", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FixedHeightVirtualizationController`1), Member = "EndDrag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextInputBase), Member = "UpdateScrollOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextInputBase), Member = "GetScrollOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(float), typeof(bool), typeof(bool)}, ReturnType = typeof(Vector2))]
	[CalledBy(Type = typeof(ListViewDragger), Member = "HandleDragAndScroll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ListViewDragger), Member = "TryGetDragPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(DragPosition&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 38)]
	public Vector2 get_scrollOffset() { }

	[CallerCount(Count = 0)]
	public TouchScrollBehavior get_touchScrollBehavior() { }

	[CallerCount(Count = 0)]
	public float get_verticalPageSize() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public Scroller get_verticalScroller() { }

	[CallerCount(Count = 0)]
	public ScrollerVisibility get_verticalScrollerVisibility() { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	private float GetDeltaDistance(float viewMin, float viewMax, float childBoundaryMin, float childBoundaryMax) { }

	[CalledBy(Type = typeof(ScrollView), Member = "ScrollTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(VisualElement), Member = "get_worldBound", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(UnityEngine.UIElements.BaseSlider`1<System.Single>), Member = "get_highValue", ReturnType = typeof(float))]
	[Calls(Type = typeof(ScrollView), Member = "get_scrollableWidth", ReturnType = typeof(float))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	private float GetXDeltaOffset(VisualElement child) { }

	[CalledBy(Type = typeof(ScrollView), Member = "ScrollTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(VisualElement), Member = "get_worldBound", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(UnityEngine.UIElements.BaseSlider`1<System.Single>), Member = "get_highValue", ReturnType = typeof(float))]
	[Calls(Type = typeof(ScrollView), Member = "get_scrollableHeight", ReturnType = typeof(float))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	private float GetYDeltaOffset(VisualElement child) { }

	[CalledBy(Type = typeof(ScrollView), Member = "OnPointerDown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerDownEvent)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.UIElements.BaseSlider`1<System.Single>), Member = "get_highValue", ReturnType = typeof(float))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	internal void InitTouchScrolling(Vector2 position) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	private void MarkSingleLineHeightDirty() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VisualElement), Member = "GetRootVisualContainer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(VisualElement))]
	[Calls(Type = typeof(CallbackEventHandler), Member = "RegisterCallback", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TEventType"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.EventCallback`1<TEventType>", typeof(TrickleDown)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 14)]
	[CallsUnknownMethods(Count = 5)]
	private void OnAttachToPanel(AttachToPanelEvent evt) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 23)]
	[CallsUnknownMethods(Count = 5)]
	private void OnDetachFromPanel(DetachFromPanelEvent evt) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ScrollView), Member = "get_scrollableHeight", ReturnType = typeof(float))]
	[Calls(Type = typeof(ScrollView), Member = "get_scrollableWidth", ReturnType = typeof(float))]
	[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
	[Calls(Type = typeof(ScrollView), Member = "UpdateScrollers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ScrollView), Member = "UpdateContentViewTransform", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 7)]
	[ContainsUnimplementedInstructions]
	private void OnGeometryChanged(GeometryChangedEvent evt) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ScrollView), Member = "UpdateHorizontalSliderPageSize", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private void OnHorizontalScrollDragElementChanged(GeometryChangedEvent evt) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VisualElement), Member = "SaveViewData", ReturnType = typeof(void))]
	private void OnHorizontalScrollerSetValueWithoutNotify(float value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VisualElement), Member = "get_boundingBox", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(VisualElement), Member = "get_layout", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(UnityEngine.UIElements.BaseSlider`1<System.Single>), Member = "get_highValue", ReturnType = typeof(float))]
	[Calls(Type = typeof(ScrollView), Member = "get_scrollableWidth", ReturnType = typeof(float))]
	[Calls(Type = typeof(Scroller), Member = "set_highValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ScrollView), Member = "UpdateContentViewTransform", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private void OnHorizontalSliderViewDataRestored() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ScrollView), Member = "ReleaseScrolling", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(IEventHandler)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void OnPointerCancel(PointerCancelEvent evt) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CallbackEventHandler), Member = "RegisterCallback", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TEventType"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.EventCallback`1<TEventType>", typeof(TrickleDown)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	private void OnPointerCapture(PointerCaptureEvent evt) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ScrollView), Member = "ReleaseScrolling", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(IEventHandler)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	private void OnPointerCaptureOut(PointerCaptureOutEvent evt) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ScrollView), Member = "ReleaseScrolling", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(IEventHandler)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ScrollView), Member = "InitTouchScrolling", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(PointerCaptureHelper), Member = "CapturePointer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IEventHandler), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "get_panel", ReturnType = typeof(IPanel))]
	[Calls(Type = typeof(PointerCaptureHelper), Member = "PreventCompatibilityMouseEvents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPanel), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(EventBase), Member = "StopPropagation", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	private void OnPointerDown(PointerDownEvent evt) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ScrollView), Member = "ComputeTouchScrolling", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(TouchScrollingResult))]
	[Calls(Type = "UnityEngine.Rendering.MousePositionDebug", Member = "GetMouseClickPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(EventBase), Member = "StopPropagation", ReturnType = typeof(void))]
	[Calls(Type = typeof(PointerCaptureHelper), Member = "HasPointerCapture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IEventHandler), typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(PointerCaptureHelper), Member = "CapturePointer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IEventHandler), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private void OnPointerMove(PointerMoveEvent evt) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ScrollView), Member = "ReleaseScrolling", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(IEventHandler)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElement), Member = "get_panel", ReturnType = typeof(IPanel))]
	[Calls(Type = typeof(PointerCaptureHelper), Member = "PreventCompatibilityMouseEvents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPanel), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(EventBase), Member = "StopPropagation", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	private void OnPointerUp(PointerUpEvent evt) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	private void OnRootCustomStyleResolved(CustomStyleResolvedEvent evt) { }

	[CallerCount(Count = 0)]
	private void OnRootPointerUp(PointerUpEvent evt) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ScrollView), Member = "get_scrollableWidth", ReturnType = typeof(float))]
	[Calls(Type = typeof(VisualElement), Member = "get_style", ReturnType = typeof(IStyle))]
	[Calls(Type = typeof(VisualElement), Member = "get_layout", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(StyleLength), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(StyleLength))]
	[Calls(Type = typeof(ScrollView), Member = "AdjustScrollers", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	private void OnScrollersGeometryChanged(GeometryChangedEvent evt) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Application), Member = "get_platform", ReturnType = typeof(RuntimePlatform))]
	[Calls(Type = typeof(ScrollView), Member = "get_scrollableHeight", ReturnType = typeof(float))]
	[Calls(Type = typeof(ScrollView), Member = "get_scrollableWidth", ReturnType = typeof(float))]
	[Calls(Type = typeof(VisualElement), Member = "get_parent", ReturnType = typeof(VisualElement))]
	[Calls(Type = typeof(ScrollView), Member = "ReadSingleLineHeight", ReturnType = typeof(void))]
	[Calls(Type = typeof(UnityEngine.UIElements.BaseSlider`1<System.Single>), Member = "get_highValue", ReturnType = typeof(float))]
	[Calls(Type = typeof(Scroller), Member = "set_value", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(EventBase), Member = "StopPropagation", ReturnType = typeof(void))]
	[Calls(Type = typeof(ScrollView), Member = "UpdateElasticBehaviour", ReturnType = typeof(void))]
	[Calls(Type = typeof(ScrollView), Member = "UpdateContentViewTransform", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	private void OnScrollWheel(WheelEvent evt) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ScrollView), Member = "UpdateVerticalSliderPageSize", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private void OnVerticalScrollDragElementChanged(GeometryChangedEvent evt) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VisualElement), Member = "SaveViewData", ReturnType = typeof(void))]
	private void OnVerticalScrollerSetValueWithoutNotify(float value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VisualElement), Member = "get_boundingBox", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(VisualElement), Member = "get_layout", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(UnityEngine.UIElements.BaseSlider`1<System.Single>), Member = "get_highValue", ReturnType = typeof(float))]
	[Calls(Type = typeof(ScrollView), Member = "get_scrollableHeight", ReturnType = typeof(float))]
	[Calls(Type = typeof(Scroller), Member = "set_highValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ScrollView), Member = "UpdateContentViewTransform", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private void OnVerticalSliderViewDataRestored() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElement), Member = "GetFullHierarchicalViewDataKey", ReturnType = typeof(string))]
	[Calls(Type = typeof(VisualElement), Member = "OverwriteFromViewData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ScrollView), Member = "UpdateContentViewTransform", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	internal virtual void OnViewDataReady() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Time), Member = "get_unscaledTime", ReturnType = typeof(float))]
	[Calls(Type = typeof(ScrollView), Member = "ApplyScrollInertia", ReturnType = typeof(void))]
	[Calls(Type = typeof(ScrollView), Member = "SpringBack", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	private void PostPointerUpAnimation() { }

	[CalledBy(Type = typeof(ScrollView), Member = "OnScrollWheel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WheelEvent)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(VisualElement), Member = "get_computedStyle", ReturnType = typeof(ComputedStyle&))]
	[Calls(Type = typeof(Dictionary`2), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue&"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(StyleSheet), Member = "TryReadDimension", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleValueHandle), typeof(Dimension&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Predicate`1<System.Object>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "GetFirstAncestorWhere", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Predicate`1<UnityEngine.UIElements.VisualElement>)}, ReturnType = typeof(VisualElement))]
	[Calls(Type = typeof(CallbackEventHandler), Member = "RegisterCallback", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TEventType"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.EventCallback`1<TEventType>", typeof(TrickleDown)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 3)]
	private void ReadSingleLineHeight() { }

	[CalledBy(Type = typeof(ScrollView), Member = "OnPointerCaptureOut", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerCaptureOutEvent)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScrollView), Member = "OnPointerDown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerDownEvent)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScrollView), Member = "OnPointerCancel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerCancelEvent)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScrollView), Member = "OnPointerUp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerUpEvent)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(PointerCaptureHelper), Member = "HasPointerCapture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IEventHandler), typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Time), Member = "get_unscaledTime", ReturnType = typeof(float))]
	[Calls(Type = typeof(ScrollView), Member = "ExecuteElasticSpringAnimation", ReturnType = typeof(void))]
	[Calls(Type = typeof(PointerCaptureHelper), Member = "ReleasePointer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IEventHandler), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	private bool ReleaseScrolling(int pointerId, IEventHandler target) { }

	[CallerCount(Count = 0)]
	private void ResetLayoutPass() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	private void ScheduleResetLayoutPass() { }

	[CalledBy(Type = typeof(GenericDropdownMenu), Member = "ChangeSelectedIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(VisualElement), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ScrollView), Member = "get_scrollableHeight", ReturnType = typeof(float))]
	[Calls(Type = typeof(ScrollView), Member = "GetYDeltaOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(Scroller), Member = "set_value", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ScrollView), Member = "get_scrollableWidth", ReturnType = typeof(float))]
	[Calls(Type = typeof(ScrollView), Member = "GetXDeltaOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(ScrollView), Member = "UpdateContentViewTransform", ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 9)]
	[ContainsUnimplementedInstructions]
	public void ScrollTo(VisualElement child) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	public void set_elasticAnimationIntervalMs(long value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
	[ContainsUnimplementedInstructions]
	public void set_elasticity(float value) { }

	[CalledBy(Type = typeof(UxmlTraits), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScrollView), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScrollViewMode)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ScrollView), Member = "UpdateHorizontalSliderPageSize", ReturnType = typeof(void))]
	[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void set_horizontalPageSize(float value) { }

	[CalledBy(Type = typeof(UxmlTraits), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BaseVerticalCollectionView), Member = "set_horizontalScrollingEnabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextInputBase), Member = "SetMultiline", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(ScrollView), Member = "get_scrollableWidth", ReturnType = typeof(float))]
	[Calls(Type = typeof(ScrollView), Member = "get_scrollableHeight", ReturnType = typeof(float))]
	[Calls(Type = typeof(ScrollView), Member = "UpdateScrollers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
	[ContainsUnimplementedInstructions]
	public void set_horizontalScrollerVisibility(ScrollerVisibility value) { }

	[CalledBy(Type = typeof(UxmlTraits), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BaseVerticalCollectionView), Member = "set_horizontalScrollingEnabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GenericDropdownMenu), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextInputBase), Member = "SetScrollViewMode", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(ScrollView), Member = "SetScrollViewMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScrollViewMode)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
	public void set_mode(ScrollViewMode value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
	public void set_mouseWheelScrollSize(float value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
	public void set_nestedInteractionKind(NestedInteractionKind value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
	[ContainsUnimplementedInstructions]
	public void set_scrollDecelerationRate(float value) { }

	[CalledBy(Type = typeof(ScrollView), Member = "<.ctor>b__140_1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DynamicHeightVirtualizationController`1), Member = "ScrollToItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DynamicHeightVirtualizationController`1), Member = "Fill", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DynamicHeightVirtualizationController`1), Member = "RefreshScrollOffset", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FixedHeightVirtualizationController`1), Member = "ScrollToItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScrollView), Member = "<.ctor>b__140_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextInputBase), Member = "UpdateScrollOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScrollView), Member = "SpringBack", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScrollView), Member = "ApplyScrollInertia", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScrollView), Member = "ApplyTouchScrolling", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ListViewDragger), Member = "HandleDragAndScroll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScrollView), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScrollViewMode)}, ReturnType = typeof(void))]
	[CallerCount(Count = 13)]
	[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ScrollView), Member = "UpdateScrollers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ScrollView), Member = "get_scrollableHeight", ReturnType = typeof(float))]
	[Calls(Type = typeof(ScrollView), Member = "get_scrollableWidth", ReturnType = typeof(float))]
	[Calls(Type = typeof(VisualElement), Member = "SaveViewData", ReturnType = typeof(void))]
	[Calls(Type = typeof(Scroller), Member = "set_value", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ScrollView), Member = "UpdateContentViewTransform", ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "get_panel", ReturnType = typeof(IPanel))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public void set_scrollOffset(Vector2 value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public void set_showHorizontal(bool value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public void set_showVertical(bool value) { }

	[CalledBy(Type = typeof(GenericDropdownMenu), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UxmlTraits), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScrollView), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScrollViewMode)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void set_touchScrollBehavior(TouchScrollBehavior value) { }

	[CalledBy(Type = typeof(UxmlTraits), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScrollView), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScrollViewMode)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ScrollView), Member = "UpdateVerticalSliderPageSize", ReturnType = typeof(void))]
	[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void set_verticalPageSize(float value) { }

	[CalledBy(Type = typeof(TextInputBase), Member = "SetMultiline", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextInputBase), Member = "SetVerticalScrollerVisibility", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScrollerVisibility)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ScrollView), Member = "get_scrollableWidth", ReturnType = typeof(float))]
	[Calls(Type = typeof(ScrollView), Member = "get_scrollableHeight", ReturnType = typeof(float))]
	[Calls(Type = typeof(ScrollView), Member = "UpdateScrollers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
	[ContainsUnimplementedInstructions]
	public void set_verticalScrollerVisibility(ScrollerVisibility value) { }

	[CalledBy(Type = typeof(DynamicHeightVirtualizationController`1), Member = "OnScrollUpdate", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DynamicHeightVirtualizationController`1), Member = "UpdateScrollViewContainer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DynamicHeightVirtualizationController`1), Member = "UpdateRegisteredHeight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ReusableCollectionItem)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(VisualElement), Member = "SaveViewData", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	internal void SetScrollOffsetWithoutNotify(Vector2 value) { }

	[CalledBy(Type = typeof(UxmlTraits), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScrollView), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScrollViewMode)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScrollView), Member = "set_mode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScrollViewMode)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(VisualElement), Member = "RemoveFromClassList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "AddToClassList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 1)]
	private void SetScrollViewMode(ScrollViewMode mode) { }

	[CalledBy(Type = typeof(ScrollView), Member = "PostPointerUpAnimation", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Mathf), Member = "SmoothDamp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(Single&), typeof(float), typeof(float), typeof(float)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(VisualElement), Member = "get_scaledPixelsPerPoint", ReturnType = typeof(float))]
	[Calls(Type = typeof(ScrollView), Member = "set_scrollOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	private void SpringBack() { }

	[CalledBy(Type = typeof(ScrollView), Member = "OnHorizontalSliderViewDataRestored", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScrollView), Member = "<.ctor>b__140_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScrollView), Member = "OnViewDataReady", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScrollView), Member = "OnScrollWheel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WheelEvent)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScrollView), Member = "OnGeometryChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GeometryChangedEvent)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScrollView), Member = "ScrollTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScrollView), Member = "OnVerticalSliderViewDataRestored", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BaseVerticalCollectionView), Member = "OnViewDataReady", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BaseTreeView), Member = "OnViewDataReady", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DynamicHeightVirtualizationController`1), Member = "ResetScroll", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DynamicHeightVirtualizationController`1), Member = "Resize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScrollView), Member = "set_scrollOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[CallerCount(Count = 12)]
	[Calls(Type = typeof(GUIUtility), Member = "RoundToPixelGrid", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(ScrollView), Member = "get_scrollableHeight", ReturnType = typeof(float))]
	[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
	[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 4)]
	[ContainsUnimplementedInstructions]
	internal void UpdateContentViewTransform() { }

	[CalledBy(Type = typeof(ScrollView), Member = "OnScrollWheel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WheelEvent)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.UIElements.BaseSlider`1<System.Single>), Member = "get_highValue", ReturnType = typeof(float))]
	[Calls(Type = typeof(ScrollView), Member = "ExecuteElasticSpringAnimation", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	private void UpdateElasticBehaviour() { }

	[CalledBy(Type = typeof(ScrollView), Member = "set_horizontalPageSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScrollView), Member = "OnHorizontalScrollDragElementChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GeometryChangedEvent)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	[ContainsUnimplementedInstructions]
	private void UpdateHorizontalSliderPageSize() { }

	[CalledBy(Type = typeof(UxmlTraits), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScrollView), Member = "set_horizontalScrollerVisibility", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScrollerVisibility)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScrollView), Member = "set_verticalScrollerVisibility", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScrollerVisibility)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScrollView), Member = "set_scrollOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScrollView), Member = "OnGeometryChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GeometryChangedEvent)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(VisualElement), Member = "SetEnabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ScrollView), Member = "get_scrollableHeight", ReturnType = typeof(float))]
	[Calls(Type = typeof(UnityEngine.UIElements.BaseSlider`1<System.Single>), Member = "get_highValue", ReturnType = typeof(float))]
	[Calls(Type = typeof(Scroller), Member = "set_lowValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StyleEnum`1), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.StyleEnum`1<T>", "UnityEngine.UIElements.StyleEnum`1<T>"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElement), Member = "get_style", ReturnType = typeof(IStyle))]
	[Calls(Type = typeof(VisualElement), Member = "get_layout", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(Clickable), Member = "set_acceptClicksIfDisabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Scroller), Member = "set_highValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "get_boundingBox", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(ScrollView), Member = "AdjustScrollers", ReturnType = typeof(void))]
	[Calls(Type = typeof(StyleEnum`1), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "UnityEngine.UIElements.StyleEnum`1<T>")]
	[Calls(Type = typeof(ScrollView), Member = "get_scrollableWidth", ReturnType = typeof(float))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 5)]
	[ContainsUnimplementedInstructions]
	internal void UpdateScrollers(bool displayHorizontal, bool displayVertical) { }

	[CalledBy(Type = typeof(ScrollView), Member = "set_verticalPageSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScrollView), Member = "OnVerticalScrollDragElementChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GeometryChangedEvent)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	[ContainsUnimplementedInstructions]
	private void UpdateVerticalSliderPageSize() { }

}

