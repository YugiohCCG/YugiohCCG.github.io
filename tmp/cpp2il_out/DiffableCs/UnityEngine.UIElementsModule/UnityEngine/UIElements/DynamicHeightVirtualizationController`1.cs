namespace UnityEngine.UIElements;

internal class DynamicHeightVirtualizationController : VerticalVirtualizationController<T>
{
	[CompilerGenerated]
	private struct <>c__DisplayClass67_0
	{
		public int draggedIndex; //Field offset: 0x0
		public DynamicHeightVirtualizationController<T> <>4__this; //Field offset: 0x0

	}

	[IsReadOnly]
	private struct ContentHeightCacheInfo
	{
		public readonly float sum; //Field offset: 0x0
		public readonly int count; //Field offset: 0x0

		[CallerCount(Count = 13)]
		[DeduplicatedMethod]
		public ContentHeightCacheInfo(float sum, int count) { }

	}

	private enum ScrollDirection
	{
		Idle = 0,
		Up = 1,
		Down = 2,
	}

	private enum VirtualizationChange
	{
		None = 0,
		Resize = 1,
		Scroll = 2,
		ForcedScroll = 3,
	}

	private int m_HighestCachedIndex; //Field offset: 0x0
	private Predicate<Int32> m_IndexOutOfBoundsPredicate; //Field offset: 0x0
	private IVisualElementScheduledItem m_RefreshScrollOffsetScheduledItem; //Field offset: 0x0
	private IVisualElementScheduledItem m_ScrollResetScheduledItem; //Field offset: 0x0
	private IVisualElementScheduledItem m_ScheduledItem; //Field offset: 0x0
	private Action<ReusableCollectionItem> m_GeometryChangedCallback; //Field offset: 0x0
	private Action m_ScrollResetCallback; //Field offset: 0x0
	private Action m_FillCallback; //Field offset: 0x0
	private float m_MinimumItemHeight; //Field offset: 0x0
	private float m_AccumulatedHeight; //Field offset: 0x0
	private Vector2 m_DelayedScrollOffset; //Field offset: 0x0
	private ScrollDirection<T> m_ScrollDirection; //Field offset: 0x0
	private VirtualizationChange<T> m_LastChange; //Field offset: 0x0
	private bool m_StickToBottom; //Field offset: 0x0
	private int m_ForcedLastVisibleItem; //Field offset: 0x0
	private int m_ForcedFirstVisibleItem; //Field offset: 0x0
	private Nullable<Int32> m_ScrolledToItemIndex; //Field offset: 0x0
	private readonly HashSet<Int32> m_WaitingCache; //Field offset: 0x0
	private readonly Dictionary<Int32, ContentHeightCacheInfo<T>> m_ContentHeightCache; //Field offset: 0x0
	private readonly Dictionary<Int32, Single> m_ItemHeightCache; //Field offset: 0x0
	private bool m_FillExecuted; //Field offset: 0x0
	private long m_TimeSinceFillScheduledMs; //Field offset: 0x0

	protected virtual bool alwaysRebindOnRefresh
	{
		[CallerCount(Count = 271)]
		[DeduplicatedMethod]
		 get { } //Length: 3
	}

	private int anchoredIndex
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(VerticalVirtualizationController`1), Member = "get_serializedData", ReturnType = typeof(SerializedVirtualizationData))]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		private get { } //Length: 47
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(VerticalVirtualizationController`1), Member = "get_serializedData", ReturnType = typeof(SerializedVirtualizationData))]
		[Calls(Type = typeof(VisualElement), Member = "SaveViewData", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		private set { } //Length: 79
	}

	private float anchorOffset
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(VerticalVirtualizationController`1), Member = "get_serializedData", ReturnType = typeof(SerializedVirtualizationData))]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		private get { } //Length: 49
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(VerticalVirtualizationController`1), Member = "get_serializedData", ReturnType = typeof(SerializedVirtualizationData))]
		[Calls(Type = typeof(VisualElement), Member = "SaveViewData", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		private set { } //Length: 83
	}

	private float contentHeight
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(VerticalVirtualizationController`1), Member = "get_serializedData", ReturnType = typeof(SerializedVirtualizationData))]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		private get { } //Length: 49
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(VisualElement), Member = "get_style", ReturnType = typeof(IStyle))]
		[Calls(Type = typeof(StyleLength), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(StyleLength))]
		[Calls(Type = typeof(VerticalVirtualizationController`1), Member = "get_serializedData", ReturnType = typeof(SerializedVirtualizationData))]
		[Calls(Type = typeof(VisualElement), Member = "SaveViewData", ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		private set { } //Length: 391
	}

	private float contentPadding
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(VerticalVirtualizationController`1), Member = "get_serializedData", ReturnType = typeof(SerializedVirtualizationData))]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		private get { } //Length: 49
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(VisualElement), Member = "get_style", ReturnType = typeof(IStyle))]
		[Calls(Type = typeof(StyleLength), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(StyleLength))]
		[Calls(Type = typeof(VerticalVirtualizationController`1), Member = "get_serializedData", ReturnType = typeof(SerializedVirtualizationData))]
		[Calls(Type = typeof(VisualElement), Member = "SaveViewData", ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		private set { } //Length: 391
	}

	private float defaultExpectedHeight
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		private get { } //Length: 81
	}

	private float viewportMaxOffset
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ScrollView), Member = "get_scrollOffset", ReturnType = typeof(Vector2))]
		[Calls(Type = typeof(VisualElement), Member = "get_layout", ReturnType = typeof(Rect))]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		private get { } //Length: 86
	}

	[CalledBy(Type = typeof(BaseVerticalCollectionView), Member = "CreateVirtualizationController", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32, System.Single>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32, UnityEngine.UIElements.DynamicHeightVirtualizationController`1+ContentHeightCacheInfo<System.Object>>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.HashSet`1<System.Int32>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VerticalVirtualizationController`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseVerticalCollectionView)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CallbackEventHandler), Member = "RegisterCallback", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TEventType"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.EventCallback`1<TEventType>", typeof(TrickleDown)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 9)]
	[DeduplicatedMethod]
	public DynamicHeightVirtualizationController`1(BaseVerticalCollectionView collectionView) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VisualElement), Member = "get_layout", ReturnType = typeof(Rect))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	private float <GetContentHeightForIndex>g__GetContentHeightFromCachedHeight|67_0(int index, in ContentHeightCacheInfo<T> heightInfo, ref <>c__DisplayClass67_0<T> unnamed_param_2) { }

	[CalledBy(Type = typeof(DynamicHeightVirtualizationController`1), Member = "Fill", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DynamicHeightVirtualizationController`1), Member = "OnRecycledItemGeometryChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ReusableCollectionItem)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(DynamicHeightVirtualizationController`1), Member = "NeedsFill", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "RemoveRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "BringToFront", ReturnType = typeof(void))]
	[Calls(Type = typeof(StyleEnum`1), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.StyleEnum`1<T>", "UnityEngine.UIElements.StyleEnum`1<T>"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(StyleEnum`1), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "UnityEngine.UIElements.StyleEnum`1<T>")]
	[Calls(Type = typeof(VisualElement), Member = "get_style", ReturnType = typeof(IStyle))]
	[Calls(Type = typeof(UnityEngine.UIElements.BaseSlider`1<System.Single>), Member = "SetHighValueWithoutNotify", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "SaveViewData", ReturnType = typeof(void))]
	[Calls(Type = typeof(AlignmentUtils), Member = "RoundToPanelPixelSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(float)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(VisualElement), Member = "get_layout", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(DynamicHeightVirtualizationController`1), Member = "CycleItems", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ScrollView), Member = "get_scrollOffset", ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(VerticalVirtualizationController`1), Member = "get_serializedData", ReturnType = typeof(SerializedVirtualizationData))]
	[Calls(Type = typeof(VerticalVirtualizationController`1), Member = "ScheduleDeferredScrollToItem", ReturnType = typeof(void))]
	[Calls(Type = typeof(DynamicHeightVirtualizationController`1), Member = "Fill", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 17)]
	[CallsUnknownMethods(Count = 16)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	private void ApplyScrollViewUpdate(bool dimensionsOnly = false) { }

	[CalledBy(Type = typeof(DynamicHeightVirtualizationController`1), Member = "Refresh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CollectionPool`2), Member = "Get", ReturnType = "TCollection")]
	[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(BaseVerticalCollectionView), Member = "get_itemsSource", ReturnType = typeof(IList))]
	[Calls(Type = typeof(VerticalVirtualizationController`1), Member = "get_itemsCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(DynamicHeightVirtualizationController`1), Member = "UnregisterItemHeight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CollectionPool`2), Member = "Release", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TCollection"}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 11)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	private void CleanItemHeightCache() { }

	[CalledBy(Type = typeof(DynamicHeightVirtualizationController`1), Member = "OnScrollUpdate", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DynamicHeightVirtualizationController`1), Member = "ApplyScrollViewUpdate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(VisualElement), Member = "SendToBack", ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseVerticalCollectionView), Member = "get_itemsSource", ReturnType = typeof(IList))]
	[Calls(Type = typeof(HashSet`1), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(StyleEnum`1), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.StyleEnum`1<T>", "UnityEngine.UIElements.StyleEnum`1<T>"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(StyleEnum`1), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "UnityEngine.UIElements.StyleEnum`1<T>")]
	[Calls(Type = typeof(VisualElement), Member = "get_style", ReturnType = typeof(IStyle))]
	[Calls(Type = typeof(VerticalVirtualizationController`1), Member = "get_serializedData", ReturnType = typeof(SerializedVirtualizationData))]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "InsertRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "RemoveAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VerticalVirtualizationController`1), Member = "get_itemsCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Insert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "RemoveRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "BringToFront", ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VerticalVirtualizationController`1), Member = "get_firstVisibleItem", ReturnType = "T")]
	[Calls(Type = typeof(VerticalVirtualizationController`1), Member = "Setup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 17)]
	[CallsUnknownMethods(Count = 12)]
	[DeduplicatedMethod]
	private void CycleItems(int firstIndex) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DynamicHeightVirtualizationController`1), Member = "RegisterItemHeight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ScrollView), Member = "get_scrollOffset", ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(ReusableCollectionItem), Member = "add_onGeometryChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<UnityEngine.UIElements.ReusableCollectionItem>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VerticalVirtualizationController`1), Member = "EndDrag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	internal virtual void EndDrag(int dropIndex) { }

	[CalledBy(Type = typeof(DynamicHeightVirtualizationController`1), Member = "Resize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DynamicHeightVirtualizationController`1), Member = "OnScrollUpdate", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DynamicHeightVirtualizationController`1), Member = "ApplyScrollViewUpdate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(StyleEnum`1), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "UnityEngine.UIElements.StyleEnum`1<T>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "InsertRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "SendToBack", ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "RemoveAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Insert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VerticalVirtualizationController`1), Member = "Setup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StyleEnum`1), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.StyleEnum`1<T>", "UnityEngine.UIElements.StyleEnum`1<T>"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElement), Member = "get_layout", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(VisualElement), Member = "get_style", ReturnType = typeof(IStyle))]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ScrollView), Member = "get_scrollOffset", ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(VerticalVirtualizationController`1), Member = "get_itemsCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(VerticalVirtualizationController`1), Member = "get_serializedData", ReturnType = typeof(SerializedVirtualizationData))]
	[Calls(Type = typeof(DynamicHeightVirtualizationController`1), Member = "ApplyScrollViewUpdate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ScrollView), Member = "set_scrollOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 15)]
	[CallsUnknownMethods(Count = 11)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	private void Fill() { }

	[CallerCount(Count = 271)]
	[DeduplicatedMethod]
	protected virtual bool get_alwaysRebindOnRefresh() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VerticalVirtualizationController`1), Member = "get_serializedData", ReturnType = typeof(SerializedVirtualizationData))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	private int get_anchoredIndex() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VerticalVirtualizationController`1), Member = "get_serializedData", ReturnType = typeof(SerializedVirtualizationData))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	private float get_anchorOffset() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VerticalVirtualizationController`1), Member = "get_serializedData", ReturnType = typeof(SerializedVirtualizationData))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	private float get_contentHeight() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VerticalVirtualizationController`1), Member = "get_serializedData", ReturnType = typeof(SerializedVirtualizationData))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	private float get_contentPadding() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	private float get_defaultExpectedHeight() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ScrollView), Member = "get_scrollOffset", ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(VisualElement), Member = "get_layout", ReturnType = typeof(Rect))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	private float get_viewportMaxOffset() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Dictionary`2), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue&"}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	private ContentHeightCacheInfo<T> GetCachedContentHeight(int index) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VerticalVirtualizationController`1), Member = "GetDraggedIndex", ReturnType = typeof(int))]
	[Calls(Type = typeof(Dictionary`2), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue&"}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 5)]
	[DeduplicatedMethod]
	private float GetContentHeightForIndex(int lastIndex) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VerticalVirtualizationController`1), Member = "get_itemsCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(Dictionary`2), Member = "get_Count", ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public virtual float GetExpectedContentHeight() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VerticalVirtualizationController`1), Member = "GetDraggedIndex", ReturnType = typeof(int))]
	[Calls(Type = typeof(Dictionary`2), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue&"}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public virtual float GetExpectedItemHeight(int index) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	private int GetFirstVisibleItem(float offset) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public virtual int GetIndexFromPosition(Vector2 position) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VerticalVirtualizationController`1), Member = "GetOrMakeItemAtIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = "T")]
	[Calls(Type = typeof(ReusableCollectionItem), Member = "add_onGeometryChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<UnityEngine.UIElements.ReusableCollectionItem>)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	internal virtual T GetOrMakeItemAtIndex(int activeItemIndex = -1, int scrollViewIndex = -1) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VisualElement), Member = "get_style", ReturnType = typeof(IStyle))]
	[Calls(Type = typeof(StyleEnum`1), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "UnityEngine.UIElements.StyleEnum`1<T>")]
	[Calls(Type = typeof(HashSet`1), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	private void HideItem(int activeItemsIndex) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseVerticalCollectionView), Member = "get_itemsSource", ReturnType = typeof(IList))]
	[Calls(Type = typeof(VerticalVirtualizationController`1), Member = "get_itemsCount", ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	private bool IsIndexOutOfBounds(int i) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VisualElement), Member = "MarkDirtyRepaint", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	private void MarkWaitingForLayout(T item) { }

	[CalledBy(Type = typeof(DynamicHeightVirtualizationController`1), Member = "ApplyScrollViewUpdate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(VerticalVirtualizationController`1), Member = "get_serializedData", ReturnType = typeof(SerializedVirtualizationData))]
	[Calls(Type = typeof(VerticalVirtualizationController`1), Member = "get_lastVisibleItem", ReturnType = "T")]
	[Calls(Type = typeof(ScrollView), Member = "get_scrollOffset", ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(VerticalVirtualizationController`1), Member = "get_itemsCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(VisualElement), Member = "get_layout", ReturnType = typeof(Rect))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	private bool NeedsFill() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 7)]
	[DeduplicatedMethod]
	private void OnDetachFromPanelEvent(DetachFromPanelEvent evt) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VerticalVirtualizationController`1), Member = "ShouldDeferScrollToItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(VerticalVirtualizationController`1), Member = "ScheduleDeferredScrollToItem", ReturnType = typeof(void))]
	[DeduplicatedMethod]
	private void OnGeometryChangedEvent(GeometryChangedEvent _) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VisualElement), Member = "get_layout", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(DynamicHeightVirtualizationController`1), Member = "UpdateRegisteredHeight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ReusableCollectionItem)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DynamicHeightVirtualizationController`1), Member = "ApplyScrollViewUpdate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	private void OnRecycledItemGeometryChanged(ReusableCollectionItem item) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VerticalVirtualizationController`1), Member = "ScheduleScroll", ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "get_layout", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(VerticalVirtualizationController`1), Member = "get_serializedData", ReturnType = typeof(SerializedVirtualizationData))]
	[Calls(Type = typeof(ScrollView), Member = "get_scrollOffset", ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(UnityEngine.UIElements.BaseSlider`1<System.Single>), Member = "SetHighValueWithoutNotify", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public virtual void OnScroll(Vector2 scrollOffset) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ScrollView), Member = "get_scrollOffset", ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(VisualElement), Member = "get_layout", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(VerticalVirtualizationController`1), Member = "get_serializedData", ReturnType = typeof(SerializedVirtualizationData))]
	[Calls(Type = typeof(Scroller), Member = "get_highValue", ReturnType = typeof(float))]
	[Calls(Type = typeof(ScrollView), Member = "SetScrollOffsetWithoutNotify", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "SaveViewData", ReturnType = typeof(void))]
	[Calls(Type = typeof(DynamicHeightVirtualizationController`1), Member = "Fill", ReturnType = typeof(void))]
	[Calls(Type = typeof(DynamicHeightVirtualizationController`1), Member = "CycleItems", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 5)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	protected virtual void OnScrollUpdate() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DynamicHeightVirtualizationController`1), Member = "CleanItemHeightCache", ReturnType = typeof(void))]
	[Calls(Type = typeof(HashSet`1), Member = "RemoveWhere", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Predicate`1<T>"}, ReturnType = typeof(int))]
	[Calls(Type = typeof(HashSet`1), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(VerticalVirtualizationController`1), Member = "Refresh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 6)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public virtual void Refresh(bool rebuild) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VerticalVirtualizationController`1), Member = "get_serializedData", ReturnType = typeof(SerializedVirtualizationData))]
	[Calls(Type = typeof(VisualElement), Member = "get_layout", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(UnityEngine.UIElements.BaseSlider`1<System.Single>), Member = "SetHighValueWithoutNotify", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ScrollView), Member = "set_scrollOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Scroller), Member = "get_value", ReturnType = typeof(float))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	private void RefreshScrollOffset() { }

	[CalledBy(Type = typeof(DynamicHeightVirtualizationController`1), Member = "UpdateRegisteredHeight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ReusableCollectionItem)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DynamicHeightVirtualizationController`1), Member = "EndDrag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(BaseVerticalCollectionView), Member = "ResolveItemHeight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(Dictionary`2), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue&"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32, System.Single>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32, UnityEngine.UIElements.DynamicHeightVirtualizationController`1+ContentHeightCacheInfo<System.Object>>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), "UnityEngine.UIElements.DynamicHeightVirtualizationController`1<Object>+ContentHeightCacheInfo<Object>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Dictionary`2), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.Dictionary`2<TKey, TValue>+Enumerator<TKey, TValue>")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2+Enumerator<System.Int32, System.Single>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Dictionary`2), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = "TValue")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 6)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	private void RegisterItemHeight(int index, float height) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ReusableCollectionItem), Member = "remove_onGeometryChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<UnityEngine.UIElements.ReusableCollectionItem>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DynamicHeightVirtualizationController`1), Member = "UnregisterItemHeight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VerticalVirtualizationController`1), Member = "ReleaseItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(HashSet`1), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	internal virtual void ReleaseItem(int activeItemsIndex) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ScrollView), Member = "UpdateContentViewTransform", ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "SaveViewData", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	private void ResetScroll() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VerticalVirtualizationController`1), Member = "get_itemsCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(VisualElement), Member = "SaveViewData", ReturnType = typeof(void))]
	[Calls(Type = typeof(VerticalVirtualizationController`1), Member = "get_serializedData", ReturnType = typeof(SerializedVirtualizationData))]
	[Calls(Type = typeof(VisualElement), Member = "get_layout", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(UnityEngine.UIElements.BaseSlider`1<System.Single>), Member = "SetHighValueWithoutNotify", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Scroller), Member = "get_value", ReturnType = typeof(float))]
	[Calls(Type = typeof(BaseVerticalCollectionView), Member = "ResolveItemHeight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(BaseVerticalCollectionView), Member = "get_itemsSource", ReturnType = typeof(IList))]
	[Calls(Type = typeof(VerticalVirtualizationController`1), Member = "Setup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DateTime), Member = "get_UtcNow", ReturnType = typeof(DateTime))]
	[Calls(Type = typeof(DateTime), Member = "get_Ticks", ReturnType = typeof(long))]
	[Calls(Type = typeof(DynamicHeightVirtualizationController`1), Member = "Fill", ReturnType = typeof(void))]
	[Calls(Type = typeof(ScrollView), Member = "UpdateContentViewTransform", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 8)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public virtual void Resize(Vector2 size) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	[DeduplicatedMethod]
	private void ScheduleFill() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	[DeduplicatedMethod]
	private void ScheduleScrollDirectionReset() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VerticalVirtualizationController`1), Member = "ShouldDeferScrollToItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElement), Member = "get_layout", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(ScrollView), Member = "get_scrollOffset", ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(VerticalVirtualizationController`1), Member = "get_serializedData", ReturnType = typeof(SerializedVirtualizationData))]
	[Calls(Type = typeof(VerticalVirtualizationController`1), Member = "get_itemsCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(ScrollView), Member = "set_scrollOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public virtual void ScrollToItem(int index) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VerticalVirtualizationController`1), Member = "get_serializedData", ReturnType = typeof(SerializedVirtualizationData))]
	[Calls(Type = typeof(VisualElement), Member = "SaveViewData", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	private void set_anchoredIndex(int value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VerticalVirtualizationController`1), Member = "get_serializedData", ReturnType = typeof(SerializedVirtualizationData))]
	[Calls(Type = typeof(VisualElement), Member = "SaveViewData", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	private void set_anchorOffset(float value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VisualElement), Member = "get_style", ReturnType = typeof(IStyle))]
	[Calls(Type = typeof(StyleLength), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(StyleLength))]
	[Calls(Type = typeof(VerticalVirtualizationController`1), Member = "get_serializedData", ReturnType = typeof(SerializedVirtualizationData))]
	[Calls(Type = typeof(VisualElement), Member = "SaveViewData", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	private void set_contentHeight(float value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VisualElement), Member = "get_style", ReturnType = typeof(IStyle))]
	[Calls(Type = typeof(StyleLength), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(StyleLength))]
	[Calls(Type = typeof(VerticalVirtualizationController`1), Member = "get_serializedData", ReturnType = typeof(SerializedVirtualizationData))]
	[Calls(Type = typeof(VisualElement), Member = "SaveViewData", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	private void set_contentPadding(float value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(HashSet`1), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(VerticalVirtualizationController`1), Member = "StartDragItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ReusableCollectionItem)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ReusableCollectionItem), Member = "remove_onGeometryChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<UnityEngine.UIElements.ReusableCollectionItem>)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	internal virtual void StartDragItem(ReusableCollectionItem item) { }

	[CalledBy(Type = typeof(DynamicHeightVirtualizationController`1), Member = "CleanItemHeightCache", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DynamicHeightVirtualizationController`1), Member = "ReleaseItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Dictionary`2), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue&"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Dictionary`2), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Dictionary`2), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.Dictionary`2<TKey, TValue>+Enumerator<TKey, TValue>")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2+Enumerator<System.Int32, System.Single>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Dictionary`2), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = "TValue")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32, UnityEngine.UIElements.DynamicHeightVirtualizationController`1+ContentHeightCacheInfo<System.Object>>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), "UnityEngine.UIElements.DynamicHeightVirtualizationController`1<Object>+ContentHeightCacheInfo<Object>"}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	[DeduplicatedMethod]
	private void UnregisterItemHeight(int index) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VerticalVirtualizationController`1), Member = "get_serializedData", ReturnType = typeof(SerializedVirtualizationData))]
	[Calls(Type = typeof(VisualElement), Member = "SaveViewData", ReturnType = typeof(void))]
	[Calls(Type = typeof(ScrollView), Member = "get_scrollOffset", ReturnType = typeof(Vector2))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	private void UpdateAnchor() { }

	[CalledBy(Type = typeof(DynamicHeightVirtualizationController`1), Member = "OnRecycledItemGeometryChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ReusableCollectionItem)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(VisualElement), Member = "get_layout", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
	[Calls(Type = typeof(Dictionary`2), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue&"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(VerticalVirtualizationController`1), Member = "get_serializedData", ReturnType = typeof(SerializedVirtualizationData))]
	[Calls(Type = typeof(ScrollView), Member = "get_scrollOffset", ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(Scroller), Member = "get_highValue", ReturnType = typeof(float))]
	[Calls(Type = typeof(DynamicHeightVirtualizationController`1), Member = "RegisterItemHeight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ScrollView), Member = "SetScrollOffsetWithoutNotify", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(HashSet`1), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallsUnknownMethods(Count = 4)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	private bool UpdateRegisteredHeight(ReusableCollectionItem item) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ScrollView), Member = "get_scrollOffset", ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(VisualElement), Member = "get_layout", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(ScrollView), Member = "SetScrollOffsetWithoutNotify", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	private void UpdateScrollViewContainer(float previousHeight, float newHeight) { }

}

