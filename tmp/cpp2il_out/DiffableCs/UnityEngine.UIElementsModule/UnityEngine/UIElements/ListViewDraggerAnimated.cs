namespace UnityEngine.UIElements;

internal class ListViewDraggerAnimated : ListViewDragger
{
	private int m_DragStartIndex; //Field offset: 0x80
	private int m_CurrentIndex; //Field offset: 0x84
	private float m_SelectionHeight; //Field offset: 0x88
	private float m_LocalOffsetOnStart; //Field offset: 0x8C
	private Vector3 m_CurrentPointerPosition; //Field offset: 0x90
	private ReusableCollectionItem m_Item; //Field offset: 0xA0
	private ReusableCollectionItem m_OffsetItem; //Field offset: 0xA8
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private bool <isDragging>k__BackingField; //Field offset: 0xB0

	public ReusableCollectionItem draggedItem
	{
		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		 get { } //Length: 8
	}

	public private bool isDragging
	{
		[CallerCount(Count = 11)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 8
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private set { } //Length: 7
	}

	protected virtual bool supportsDragEvents
	{
		[CallerCount(Count = 271)]
		[DeduplicatedMethod]
		 get { } //Length: 3
	}

	[CallerCount(Count = 3)]
	[Calls(Type = typeof(DragEventsProcessor), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	public ListViewDraggerAnimated(BaseVerticalCollectionView listView) { }

	[CalledBy(Type = typeof(ListViewDraggerAnimated), Member = "StartDrag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(StartDragArgs))]
	[CalledBy(Type = typeof(ListViewDraggerAnimated), Member = "UpdateDrag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(ValueAnimation`1), Member = "Stop", ReturnType = typeof(void))]
	[Calls(Type = typeof(StyleValues), Member = "get_paddingTop", ReturnType = typeof(float))]
	[Calls(Type = typeof(VisualElement), Member = "get_style", ReturnType = typeof(IStyle))]
	[Calls(Type = typeof(StyleLength), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(StyleLength))]
	[Calls(Type = typeof(StyleLength), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleLength), typeof(StyleLength)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ValueAnimation`1), Member = "Recycle", ReturnType = typeof(void))]
	[Calls(Type = typeof(ListViewDragger), Member = "get_targetView", ReturnType = typeof(BaseVerticalCollectionView))]
	[Calls(Type = typeof(StyleValues), Member = "set_paddingTop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseVerticalCollectionView), Member = "ResolveItemHeight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(StyleValues), Member = "set_height", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ValueAnimation`1), Member = "KeepAlive", ReturnType = "UnityEngine.UIElements.Experimental.ValueAnimation`1<T>")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 5)]
	[ContainsUnimplementedInstructions]
	private void Animate(ReusableCollectionItem element, float paddingTop) { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	protected virtual void ClearDragAndDropUI(bool dragCancelled) { }

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public ReusableCollectionItem get_draggedItem() { }

	[CallerCount(Count = 11)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public bool get_isDragging() { }

	[CallerCount(Count = 271)]
	[DeduplicatedMethod]
	protected virtual bool get_supportsDragEvents() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VisualElement), Member = "ClearManualLayout", ReturnType = typeof(void))]
	[Calls(Type = typeof(ListViewDragger), Member = "get_targetView", ReturnType = typeof(BaseVerticalCollectionView))]
	[Calls(Type = typeof(ValueAnimation`1), Member = "Stop", ReturnType = typeof(void))]
	[Calls(Type = typeof(ValueAnimation`1), Member = "Recycle", ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "get_style", ReturnType = typeof(IStyle))]
	[Calls(Type = typeof(StyleLength), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(StyleLength))]
	[Calls(Type = typeof(BaseVerticalCollectionView), Member = "ResolveItemHeight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(ListViewDragger), Member = "MakeDragAndDropArgs", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DragPosition)}, ReturnType = typeof(DragAndDropArgs))]
	[Calls(Type = typeof(DragEventsProcessor), Member = "get_dragAndDrop", ReturnType = typeof(IDragAndDrop))]
	[Calls(Type = typeof(ListViewDragger), Member = "OnDrop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 10)]
	protected private virtual void OnDrop(Vector3 pointerPosition) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void set_isDragging(bool value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ListViewDragger), Member = "get_targetView", ReturnType = typeof(BaseVerticalCollectionView))]
	[Calls(Type = typeof(BaseVerticalCollectionView), Member = "ClearSelection", ReturnType = typeof(void))]
	[Calls(Type = typeof(ListViewDragger), Member = "GetRecycledItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(ReusableCollectionItem))]
	[Calls(Type = typeof(BaseVerticalCollectionView), Member = "get_selectionType", ReturnType = typeof(SelectionType))]
	[Calls(Type = typeof(BaseVerticalCollectionView), Member = "SetSelection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "get_layout", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(VisualElement), Member = "get_style", ReturnType = typeof(IStyle))]
	[Calls(Type = typeof(StyleEnum`1), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "UnityEngine.UIElements.StyleEnum`1<T>")]
	[Calls(Type = typeof(StyleLength), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(StyleLength))]
	[Calls(Type = typeof(VisualElementExtensions), Member = "WorldToLocal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(Vector2)}, ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(ListViewDraggerExtension), Member = "GetRecycledItemFromIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseVerticalCollectionView), typeof(int)}, ReturnType = typeof(ReusableCollectionItem))]
	[Calls(Type = typeof(ListViewDraggerAnimated), Member = "Animate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ReusableCollectionItem), typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ListViewDragger), Member = "StartDrag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(StartDragArgs))]
	[CallsDeduplicatedMethods(Count = 17)]
	[CallsUnknownMethods(Count = 15)]
	protected private virtual StartDragArgs StartDrag(Vector3 pointerPosition) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	protected virtual bool TryGetDragPosition(Vector2 pointerPosition, ref DragPosition dragPosition) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VisualElement), Member = "get_style", ReturnType = typeof(IStyle))]
	[Calls(Type = typeof(ListViewDragger), Member = "HandleDragAndScroll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ListViewDragger), Member = "get_targetView", ReturnType = typeof(BaseVerticalCollectionView))]
	[Calls(Type = typeof(VisualElementExtensions), Member = "WorldToLocal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(Vector2)}, ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(VisualElement), Member = "get_layout", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
	[Calls(Type = typeof(BaseVerticalCollectionView), Member = "get_activeItems", ReturnType = typeof(System.Collections.Generic.IEnumerable`1<UnityEngine.UIElements.ReusableCollectionItem>))]
	[Calls(Type = typeof(StyleEnum`1), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "UnityEngine.UIElements.StyleEnum`1<T>")]
	[Calls(Type = typeof(StyleEnum`1), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.StyleEnum`1<T>", "UnityEngine.UIElements.StyleEnum`1<T>"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BaseVerticalCollectionView), Member = "get_itemsSource", ReturnType = typeof(IList))]
	[Calls(Type = typeof(ListViewDraggerAnimated), Member = "Animate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ReusableCollectionItem), typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "set_layout", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "BringToFront", ReturnType = typeof(void))]
	[Calls(Type = typeof(ListViewDragger), Member = "UpdateDrag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 12)]
	[CallsUnknownMethods(Count = 26)]
	[ContainsUnimplementedInstructions]
	protected private virtual void UpdateDrag(Vector3 pointerPosition) { }

}

