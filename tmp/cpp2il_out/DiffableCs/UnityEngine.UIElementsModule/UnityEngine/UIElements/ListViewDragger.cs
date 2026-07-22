namespace UnityEngine.UIElements;

internal class ListViewDragger : DragEventsProcessor
{
	public struct DragPosition : IEquatable<DragPosition>
	{
		public int insertAtIndex; //Field offset: 0x0
		public int parentId; //Field offset: 0x4
		public int childIndex; //Field offset: 0x8
		public ReusableCollectionItem recycledItem; //Field offset: 0x10
		public DragAndDropPosition dropPosition; //Field offset: 0x18

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		public override bool Equals(DragPosition other) { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		public virtual bool Equals(object obj) { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		public virtual int GetHashCode() { }

	}

	private DragPosition m_LastDragPosition; //Field offset: 0x30
	private VisualElement m_DragHoverBar; //Field offset: 0x50
	private VisualElement m_DragHoverItemMarker; //Field offset: 0x58
	private VisualElement m_DragHoverSiblingMarker; //Field offset: 0x60
	private float m_LeftIndentation; //Field offset: 0x68
	private float m_SiblingBottom; //Field offset: 0x6C
	private bool m_Enabled; //Field offset: 0x70
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private ICollectionDragAndDropController <dragAndDropController>k__BackingField; //Field offset: 0x78

	public ICollectionDragAndDropController dragAndDropController
	{
		[CallerCount(Count = 7)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 13
	}

	internal bool enabled
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		internal get { } //Length: 5
		[CalledBy(Type = typeof(MultiColumnController), Member = "UpdateDragger", ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(ListViewDragger), Member = "get_targetView", ReturnType = typeof(BaseVerticalCollectionView))]
		[Calls(Type = typeof(BaseVerticalCollectionView), Member = "get_activeItems", ReturnType = typeof(System.Collections.Generic.IEnumerable`1<UnityEngine.UIElements.ReusableCollectionItem>))]
		[Calls(Type = typeof(ReusableListViewItem), Member = "SetDragHandleEnabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 11)]
		internal set { } //Length: 754
	}

	protected ScrollView targetScrollView
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ListViewDragger), Member = "get_targetView", ReturnType = typeof(BaseVerticalCollectionView))]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 33
	}

	protected BaseVerticalCollectionView targetView
	{
		[CallerCount(Count = 81)]
		 get { } //Length: 114
	}

	[CallerCount(Count = 3)]
	[Calls(Type = typeof(DragEventsProcessor), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	public ListViewDragger(BaseVerticalCollectionView listView) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VisualElement), Member = "get_style", ReturnType = typeof(IStyle))]
	[Calls(Type = typeof(ListViewDragger), Member = "get_targetView", ReturnType = typeof(BaseVerticalCollectionView))]
	[Calls(Type = typeof(VisualElement), Member = "get_localBound", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(StyleLength), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(StyleLength))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[CompilerGenerated]
	private void <ApplyDragAndDropUI>g__GeometryChangedCallback|31_0(GeometryChangedEvent e) { }

	[CalledBy(Type = typeof(ListViewDragger), Member = "UpdateDrag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ListViewDragger), Member = "PlaceHoverBarAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ListViewDragger), Member = "PlaceHoverBarAtElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ReusableCollectionItem)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ListViewDraggerExtension), Member = "GetRecycledItemFromIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseVerticalCollectionView), typeof(int)}, ReturnType = typeof(ReusableCollectionItem))]
	[Calls(Type = typeof(BaseVerticalCollectionView), Member = "get_itemsSource", ReturnType = typeof(IList))]
	[Calls(Type = typeof(VisualElement), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CallbackEventHandler), Member = "RegisterCallback", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TEventType"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.EventCallback`1<TEventType>", typeof(TrickleDown)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "set_pickingMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PickingMode)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StyleEnum`1), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "UnityEngine.UIElements.StyleEnum`1<T>")]
	[Calls(Type = typeof(StyleLength), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(StyleLength))]
	[Calls(Type = typeof(VisualElement), Member = "get_localBound", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(ListViewDragger), Member = "get_targetView", ReturnType = typeof(BaseVerticalCollectionView))]
	[Calls(Type = typeof(VisualElement), Member = "get_style", ReturnType = typeof(IStyle))]
	[Calls(Type = typeof(VisualElement), Member = "AddToClassList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(ListViewDragger), Member = "IsDraggingDisabled", ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 16)]
	private void ApplyDragAndDropUI(DragPosition dragPosition) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ListViewDragger), Member = "get_targetView", ReturnType = typeof(BaseVerticalCollectionView))]
	[Calls(Type = typeof(VisualElement), Member = "get_worldBound", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(ListViewDragger), Member = "GetRecycledItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(ReusableCollectionItem))]
	[Calls(Type = typeof(BaseVerticalCollectionView), Member = "HasCanStartDrag", ReturnType = typeof(bool))]
	[Calls(Type = typeof(BaseVerticalCollectionView), Member = "get_selectedIds", ReturnType = typeof(System.Collections.Generic.IEnumerable`1<System.Int32>))]
	[Calls(Type = typeof(Enumerable), Member = "Any", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BaseVerticalCollectionView), Member = "RaiseCanStartDrag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ReusableCollectionItem), typeof(System.Collections.Generic.IEnumerable`1<System.Int32>)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	[ContainsUnimplementedInstructions]
	protected virtual bool CanStartDrag(Vector3 pointerPosition) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ListViewDragger), Member = "get_targetView", ReturnType = typeof(BaseVerticalCollectionView))]
	[Calls(Type = typeof(BaseVerticalCollectionView), Member = "get_activeItems", ReturnType = typeof(System.Collections.Generic.IEnumerable`1<UnityEngine.UIElements.ReusableCollectionItem>))]
	[Calls(Type = typeof(VisualElement), Member = "RemoveFromClassList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "get_style", ReturnType = typeof(IStyle))]
	[Calls(Type = typeof(StyleEnum`1), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "UnityEngine.UIElements.StyleEnum`1<T>")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 16)]
	protected virtual void ClearDragAndDropUI(bool dragCancelled) { }

	[CallerCount(Count = 7)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public ICollectionDragAndDropController get_dragAndDropController() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	internal bool get_enabled() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ListViewDragger), Member = "get_targetView", ReturnType = typeof(BaseVerticalCollectionView))]
	[CallsUnknownMethods(Count = 1)]
	protected ScrollView get_targetScrollView() { }

	[CallerCount(Count = 81)]
	protected BaseVerticalCollectionView get_targetView() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ListViewDragger), Member = "get_targetView", ReturnType = typeof(BaseVerticalCollectionView))]
	[Calls(Type = typeof(VisualElement), Member = "get_worldBound", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(VisualElementExtensions), Member = "WorldToLocal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(Rect)}, ReturnType = typeof(Rect))]
	[Calls(Type = typeof(VisualElement), Member = "get_localBound", ReturnType = typeof(Rect))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private float GetHoverBarTopPosition(ReusableCollectionItem item) { }

	[CalledBy(Type = typeof(ListViewDragger), Member = "HandleSiblingInsertionAtAvailableDepthsAndChangeTargetIfNeeded", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DragPosition&), typeof(Vector2)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ListViewDragger), Member = "get_targetView", ReturnType = typeof(BaseVerticalCollectionView))]
	[Calls(Type = typeof(Enumerable), Member = "Contains", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Int32>), typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BaseVerticalCollectionView), Member = "get_itemsSource", ReturnType = typeof(IList))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	private void GetPreviousAndNextItemsIgnoringDraggedItems(int insertAtIndex, out int previousItemId, out int nextItemId) { }

	[CalledBy(Type = typeof(ListViewDragger), Member = "CanStartDrag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ListViewDragger), Member = "StartDrag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(StartDragArgs))]
	[CalledBy(Type = typeof(ListViewDragger), Member = "UpdateDrag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ListViewDragger), Member = "HandleAutoExpansion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ListViewDragger), Member = "TryGetDragPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(DragPosition&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ListViewDraggerAnimated), Member = "StartDrag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(StartDragArgs))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(ListViewDragger), Member = "get_targetView", ReturnType = typeof(BaseVerticalCollectionView))]
	[Calls(Type = typeof(BaseVerticalCollectionView), Member = "get_activeItems", ReturnType = typeof(System.Collections.Generic.IEnumerable`1<UnityEngine.UIElements.ReusableCollectionItem>))]
	[Calls(Type = typeof(VisualElement), Member = "get_worldBound", ReturnType = typeof(Rect))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 12)]
	[ContainsUnimplementedInstructions]
	protected ReusableCollectionItem GetRecycledItem(Vector3 pointerPosition) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ListViewDragger), Member = "MakeDragAndDropArgs", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DragPosition)}, ReturnType = typeof(DragAndDropArgs))]
	[Calls(Type = typeof(ListViewDragger), Member = "get_targetView", ReturnType = typeof(BaseVerticalCollectionView))]
	[Calls(Type = typeof(BaseVerticalCollectionView), Member = "RaiseHandleDragAndDrop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(DragAndDropArgs)}, ReturnType = typeof(DragVisualMode))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private DragVisualMode GetVisualMode(Vector3 pointerPosition, ref DragPosition dragPosition) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ListViewDragger), Member = "GetRecycledItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(ReusableCollectionItem))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void HandleAutoExpansion(Vector2 pointerPosition) { }

	[CalledBy(Type = typeof(ListViewDragger), Member = "UpdateDrag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ListViewDraggerAnimated), Member = "UpdateDrag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ListViewDragger), Member = "get_targetView", ReturnType = typeof(BaseVerticalCollectionView))]
	[Calls(Type = typeof(VisualElement), Member = "get_worldBound", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(ScrollView), Member = "get_scrollOffset", ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(ScrollView), Member = "set_scrollOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	internal void HandleDragAndScroll(Vector2 pointerPosition) { }

	[CalledBy(Type = typeof(ListViewDragger), Member = "HandleTreePosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(DragPosition&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BaseVerticalCollectionView), Member = "GetRootElementForId", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(VisualElement))]
	[Calls(Type = typeof(ListViewDragger), Member = "get_targetView", ReturnType = typeof(BaseVerticalCollectionView))]
	[Calls(Type = typeof(BaseTreeView), Member = "get_viewController", ReturnType = typeof(BaseTreeViewController))]
	[Calls(Type = typeof(ListViewDragger), Member = "GetPreviousAndNextItemsIgnoringDraggedItems", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Int32&), typeof(Int32&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseTreeView), Member = "IsExpanded", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BaseTreeViewController), Member = "GetIndentationDepth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(UQueryExtensions), Member = "Q", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(string), typeof(string)}, ReturnType = typeof(VisualElement))]
	[Calls(Type = typeof(VisualElement), Member = "get_layout", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(VisualElementExtensions), Member = "WorldToLocal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(Vector2)}, ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(VisualElement), Member = "get_worldBound", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(VisualElementExtensions), Member = "WorldToLocal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(Rect)}, ReturnType = typeof(Rect))]
	[Calls(Type = typeof(VisualElement), Member = "get_localBound", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(BaseTreeViewController), Member = "GetChildIndexForId", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	private void HandleSiblingInsertionAtAvailableDepthsAndChangeTargetIfNeeded(ref DragPosition dragPosition, Vector2 pointerPosition) { }

	[CalledBy(Type = typeof(ListViewDragger), Member = "TryGetDragPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(DragPosition&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ListViewDragger), Member = "get_targetView", ReturnType = typeof(BaseVerticalCollectionView))]
	[Calls(Type = typeof(BaseTreeView), Member = "get_viewController", ReturnType = typeof(BaseTreeViewController))]
	[Calls(Type = typeof(ListViewDragger), Member = "HandleSiblingInsertionAtAvailableDepthsAndChangeTargetIfNeeded", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DragPosition&), typeof(Vector2)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void HandleTreePosition(Vector2 pointerPosition, ref DragPosition dragPosition) { }

	[CalledBy(Type = typeof(ListViewDragger), Member = "OnDrop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ListViewDragger), Member = "ApplyDragAndDropUI", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DragPosition)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ListViewDragger), Member = "get_targetView", ReturnType = typeof(BaseVerticalCollectionView))]
	[Calls(Type = typeof(DragEventsProcessor), Member = "get_dragAndDrop", ReturnType = typeof(IDragAndDrop))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	private bool IsDraggingDisabled() { }

	[CalledBy(Type = typeof(ListViewDragger), Member = "UpdateDrag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ListViewDragger), Member = "GetVisualMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(DragPosition&)}, ReturnType = typeof(DragVisualMode))]
	[CalledBy(Type = typeof(ListViewDragger), Member = "OnDrop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ListViewDraggerAnimated), Member = "OnDrop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(ListViewDragger), Member = "get_targetView", ReturnType = typeof(BaseVerticalCollectionView))]
	[Calls(Type = typeof(VisualElement), Member = "get_panel", ReturnType = typeof(IPanel))]
	[Calls(Type = typeof(DragAndDropUtility), Member = "GetDragAndDrop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPanel)}, ReturnType = typeof(IDragAndDrop))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	protected DragAndDropArgs MakeDragAndDropArgs(DragPosition dragPosition) { }

	[CalledBy(Type = typeof(ListViewDraggerAnimated), Member = "OnDrop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ListViewDragger), Member = "MakeDragAndDropArgs", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DragPosition)}, ReturnType = typeof(DragAndDropArgs))]
	[Calls(Type = typeof(ListViewDragger), Member = "get_targetView", ReturnType = typeof(BaseVerticalCollectionView))]
	[Calls(Type = typeof(BaseVerticalCollectionView), Member = "RaiseDrop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(DragAndDropArgs)}, ReturnType = typeof(DragVisualMode))]
	[Calls(Type = typeof(ListViewDragger), Member = "IsDraggingDisabled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(DragEventsProcessor), Member = "get_dragAndDrop", ReturnType = typeof(IDragAndDrop))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	protected private virtual void OnDrop(Vector3 pointerPosition) { }

	[CalledBy(Type = typeof(ListViewDragger), Member = "ApplyDragAndDropUI", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DragPosition)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ListViewDragger), Member = "PlaceHoverBarAtElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ReusableCollectionItem)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(VisualElement), Member = "get_style", ReturnType = typeof(IStyle))]
	[Calls(Type = typeof(StyleLength), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(StyleLength))]
	[Calls(Type = typeof(StyleEnum`1), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "UnityEngine.UIElements.StyleEnum`1<T>")]
	[Calls(Type = typeof(ListViewDragger), Member = "get_targetView", ReturnType = typeof(BaseVerticalCollectionView))]
	[Calls(Type = typeof(VisualElement), Member = "get_localBound", ReturnType = typeof(Rect))]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 10)]
	[ContainsUnimplementedInstructions]
	private void PlaceHoverBarAt(float top, float indentationPadding = -1, float siblingBottom = -1) { }

	[CalledBy(Type = typeof(ListViewDragger), Member = "ApplyDragAndDropUI", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DragPosition)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ListViewDragger), Member = "get_targetView", ReturnType = typeof(BaseVerticalCollectionView))]
	[Calls(Type = typeof(VisualElement), Member = "get_worldBound", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(VisualElementExtensions), Member = "WorldToLocal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(Rect)}, ReturnType = typeof(Rect))]
	[Calls(Type = typeof(VisualElement), Member = "get_localBound", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(ListViewDragger), Member = "PlaceHoverBarAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(float)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void PlaceHoverBarAtElement(ReusableCollectionItem item) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_dragAndDropController(ICollectionDragAndDropController value) { }

	[CalledBy(Type = typeof(MultiColumnController), Member = "UpdateDragger", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ListViewDragger), Member = "get_targetView", ReturnType = typeof(BaseVerticalCollectionView))]
	[Calls(Type = typeof(BaseVerticalCollectionView), Member = "get_activeItems", ReturnType = typeof(System.Collections.Generic.IEnumerable`1<UnityEngine.UIElements.ReusableCollectionItem>))]
	[Calls(Type = typeof(ReusableListViewItem), Member = "SetDragHandleEnabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 11)]
	internal void set_enabled(bool value) { }

	[CalledBy(Type = typeof(ListViewDraggerAnimated), Member = "StartDrag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(StartDragArgs))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ListViewDragger), Member = "GetRecycledItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(ReusableCollectionItem))]
	[Calls(Type = typeof(ListViewDragger), Member = "get_targetView", ReturnType = typeof(BaseVerticalCollectionView))]
	[Calls(Type = typeof(BaseVerticalCollectionView), Member = "get_selectedIds", ReturnType = typeof(System.Collections.Generic.IEnumerable`1<System.Int32>))]
	[Calls(Type = typeof(Enumerable), Member = "Any", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BaseVerticalCollectionView), Member = "get_selectionType", ReturnType = typeof(SelectionType))]
	[Calls(Type = typeof(BaseVerticalCollectionView), Member = "get_selectedIndices", ReturnType = typeof(System.Collections.Generic.IEnumerable`1<System.Int32>))]
	[Calls(Type = typeof(Enumerable), Member = "Contains", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Int32>), typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BaseVerticalCollectionView), Member = "SetSelection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseVerticalCollectionView), Member = "RaiseSetupDragAndDrop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ReusableCollectionItem), typeof(System.Collections.Generic.IEnumerable`1<System.Int32>), typeof(StartDragArgs)}, ReturnType = typeof(StartDragArgs))]
	[Calls(Type = typeof(Hashtable), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 8)]
	protected private virtual StartDragArgs StartDrag(Vector3 pointerPosition) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ListViewDragger), Member = "GetRecycledItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(ReusableCollectionItem))]
	[Calls(Type = typeof(VisualElement), Member = "get_worldBound", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(ListViewDragger), Member = "get_targetView", ReturnType = typeof(BaseVerticalCollectionView))]
	[Calls(Type = typeof(ScrollView), Member = "get_scrollOffset", ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(BaseVerticalCollectionView), Member = "ScrollToItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseVerticalCollectionView), Member = "get_itemsSource", ReturnType = typeof(IList))]
	[Calls(Type = typeof(ListViewDragger), Member = "HandleTreePosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(DragPosition&)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 5)]
	[ContainsUnimplementedInstructions]
	protected override bool TryGetDragPosition(Vector2 pointerPosition, ref DragPosition dragPosition) { }

	[CalledBy(Type = typeof(ListViewDraggerAnimated), Member = "UpdateDrag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ListViewDragger), Member = "MakeDragAndDropArgs", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DragPosition)}, ReturnType = typeof(DragAndDropArgs))]
	[Calls(Type = typeof(ListViewDragger), Member = "get_targetView", ReturnType = typeof(BaseVerticalCollectionView))]
	[Calls(Type = typeof(BaseVerticalCollectionView), Member = "RaiseHandleDragAndDrop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(DragAndDropArgs)}, ReturnType = typeof(DragVisualMode))]
	[Calls(Type = typeof(ListViewDragger), Member = "HandleDragAndScroll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ListViewDragger), Member = "GetRecycledItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(ReusableCollectionItem))]
	[Calls(Type = typeof(ListViewDragger), Member = "ApplyDragAndDropUI", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DragPosition)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DragEventsProcessor), Member = "get_dragAndDrop", ReturnType = typeof(IDragAndDrop))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 6)]
	protected private virtual void UpdateDrag(Vector3 pointerPosition) { }

}

