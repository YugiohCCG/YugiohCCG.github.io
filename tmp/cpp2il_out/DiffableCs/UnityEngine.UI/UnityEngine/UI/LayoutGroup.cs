namespace UnityEngine.UI;

[DisallowMultipleComponent]
[ExecuteAlways]
[RequireComponent(typeof(RectTransform))]
public abstract class LayoutGroup : UIBehaviour, ILayoutElement, ILayoutGroup, ILayoutController
{
	[CompilerGenerated]
	private sealed class <DelayedSetDirty>d__57 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public RectTransform rectTransform; //Field offset: 0x20

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
		public <DelayedSetDirty>d__57(int <>1__state) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(LayoutRebuilder), Member = "MarkLayoutForRebuild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
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

	[SerializeField]
	protected RectOffset m_Padding; //Field offset: 0x20
	[SerializeField]
	protected TextAnchor m_ChildAlignment; //Field offset: 0x28
	private RectTransform m_Rect; //Field offset: 0x30
	protected DrivenRectTransformTracker m_Tracker; //Field offset: 0x38
	private Vector2 m_TotalMinSize; //Field offset: 0x3C
	private Vector2 m_TotalPreferredSize; //Field offset: 0x44
	private Vector2 m_TotalFlexibleSize; //Field offset: 0x4C
	private List<RectTransform> m_RectChildren; //Field offset: 0x58

	public TextAnchor childAlignment
	{
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 4
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(LayoutGroup), Member = "SetProperty", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"System.Int32Enum"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32Enum&), "System.Int32Enum"}, ReturnType = typeof(void))]
		 set { } //Length: 75
	}

	public override float flexibleHeight
	{
		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		 get { } //Length: 8
	}

	public override float flexibleWidth
	{
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 8
	}

	private bool isRootLayoutGroup
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
		[Calls(Type = typeof(Component), Member = "GetComponent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(Component))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		private get { } //Length: 282
	}

	public override int layoutPriority
	{
		[CallerCount(Count = 182)]
		[DeduplicatedMethod]
		 get { } //Length: 3
	}

	public override float minHeight
	{
		[CallerCount(Count = 11)]
		[DeduplicatedMethod]
		 get { } //Length: 8
	}

	public override float minWidth
	{
		[CallerCount(Count = 5)]
		[DeduplicatedMethod]
		 get { } //Length: 8
	}

	public RectOffset padding
	{
		[CallerCount(Count = 12)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CalledBy(Type = "UI.Tables.TableCell", Member = "SetCellPaddingFromTableLayout", ReturnType = typeof(void))]
		[CalledBy(Type = "UI.Tables.TableLayout", Member = "UpdateLayout", ReturnType = typeof(void))]
		[CalledBy(Type = "UI.Dates.DatePickerHeaderConfig", Member = "Apply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UI.Dates.DatePicker_Header"}, ReturnType = typeof(void))]
		[CallerCount(Count = 6)]
		[Calls(Type = typeof(LayoutGroup), Member = "SetProperty", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object&), typeof(object)}, ReturnType = typeof(void))]
		 set { } //Length: 76
	}

	public override float preferredHeight
	{
		[CallerCount(Count = 8)]
		[DeduplicatedMethod]
		 get { } //Length: 8
	}

	public override float preferredWidth
	{
		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		 get { } //Length: 8
	}

	protected List<RectTransform> rectChildren
	{
		[CallerCount(Count = 10)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	protected RectTransform rectTransform
	{
		[CalledBy(Type = "UI.Tables.TableLayout", Member = "UpdateLayout", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(GridLayoutGroup), Member = "CalculateLayoutInputVertical", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(GridLayoutGroup), Member = "SetCellsAlongAxis", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(HorizontalOrVerticalLayoutGroup), Member = "SetChildrenAlongAxis", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(LayoutGroup), Member = "CalculateLayoutInputHorizontal", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(LayoutGroup), Member = "OnEnable", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(LayoutGroup), Member = "OnDisable", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(LayoutGroup), Member = "GetStartOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(float)}, ReturnType = typeof(float))]
		[CalledBy(Type = typeof(LayoutGroup), Member = "SetDirty", ReturnType = typeof(void))]
		[CallerCount(Count = 27)]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 141
	}

	[CalledBy(Type = "UI.Tables.TableLayout", Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GridLayoutGroup), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(HorizontalLayoutGroup), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(HorizontalOrVerticalLayoutGroup), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VerticalLayoutGroup), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(RectOffset), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	protected LayoutGroup() { }

	[CalledBy(Type = "UI.Tables.TableLayout", Member = "CalculateLayoutInputHorizontal", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GridLayoutGroup), Member = "CalculateLayoutInputHorizontal", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(HorizontalLayoutGroup), Member = "CalculateLayoutInputHorizontal", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VerticalLayoutGroup), Member = "CalculateLayoutInputHorizontal", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CollectionPool`2), Member = "Release", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TCollection"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(GameObject), Member = "get_activeInHierarchy", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Transform), Member = "get_childCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(LayoutGroup), Member = "get_rectTransform", ReturnType = typeof(RectTransform))]
	[Calls(Type = typeof(CollectionPool`2), Member = "Get", ReturnType = "TCollection")]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Transform), Member = "GetChild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Transform))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 7)]
	public override void CalculateLayoutInputHorizontal() { }

	public abstract void CalculateLayoutInputVertical() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[IteratorStateMachine(typeof(<DelayedSetDirty>d__57))]
	private IEnumerator DelayedSetDirty(RectTransform rectTransform) { }

	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	public TextAnchor get_childAlignment() { }

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public override float get_flexibleHeight() { }

	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	public override float get_flexibleWidth() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(Component), Member = "GetComponent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(Component))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	private bool get_isRootLayoutGroup() { }

	[CallerCount(Count = 182)]
	[DeduplicatedMethod]
	public override int get_layoutPriority() { }

	[CallerCount(Count = 11)]
	[DeduplicatedMethod]
	public override float get_minHeight() { }

	[CallerCount(Count = 5)]
	[DeduplicatedMethod]
	public override float get_minWidth() { }

	[CallerCount(Count = 12)]
	[DeduplicatedMethod]
	public RectOffset get_padding() { }

	[CallerCount(Count = 8)]
	[DeduplicatedMethod]
	public override float get_preferredHeight() { }

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public override float get_preferredWidth() { }

	[CallerCount(Count = 10)]
	[DeduplicatedMethod]
	protected List<RectTransform> get_rectChildren() { }

	[CalledBy(Type = "UI.Tables.TableLayout", Member = "UpdateLayout", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GridLayoutGroup), Member = "CalculateLayoutInputVertical", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GridLayoutGroup), Member = "SetCellsAlongAxis", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(HorizontalOrVerticalLayoutGroup), Member = "SetChildrenAlongAxis", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LayoutGroup), Member = "CalculateLayoutInputHorizontal", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LayoutGroup), Member = "OnEnable", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LayoutGroup), Member = "OnDisable", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LayoutGroup), Member = "GetStartOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(float)}, ReturnType = typeof(float))]
	[CalledBy(Type = typeof(LayoutGroup), Member = "SetDirty", ReturnType = typeof(void))]
	[CallerCount(Count = 27)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[CallsUnknownMethods(Count = 1)]
	protected RectTransform get_rectTransform() { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	protected float GetAlignmentOnAxis(int axis) { }

	[CalledBy(Type = typeof(HorizontalOrVerticalLayoutGroup), Member = "SetChildrenAlongAxis", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(RectOffset), Member = "get_horizontal", ReturnType = typeof(int))]
	[Calls(Type = typeof(RectOffset), Member = "get_vertical", ReturnType = typeof(int))]
	[Calls(Type = typeof(LayoutGroup), Member = "get_rectTransform", ReturnType = typeof(RectTransform))]
	[Calls(Type = typeof(RectTransform), Member = "get_rect", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(RectOffset), Member = "get_left", ReturnType = typeof(int))]
	[Calls(Type = typeof(RectOffset), Member = "get_top", ReturnType = typeof(int))]
	[Calls(Type = typeof(IndexOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	[ContainsUnimplementedInstructions]
	protected float GetStartOffset(int axis, float requiredSpaceWithoutPadding) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Vector2), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(float))]
	protected float GetTotalFlexibleSize(int axis) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Vector2), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(float))]
	protected float GetTotalMinSize(int axis) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Vector2), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(float))]
	protected float GetTotalPreferredSize(int axis) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CanvasUpdateRegistry), Member = "IsRebuildingLayout", ReturnType = typeof(bool))]
	[Calls(Type = typeof(LayoutGroup), Member = "SetDirty", ReturnType = typeof(void))]
	protected override void OnChildRectTransformDimensionsChange() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LayoutGroup), Member = "SetDirty", ReturnType = typeof(void))]
	[DeduplicatedMethod]
	protected virtual void OnDidApplyAnimationProperties() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LayoutGroup), Member = "get_rectTransform", ReturnType = typeof(RectTransform))]
	[Calls(Type = typeof(LayoutRebuilder), Member = "MarkLayoutForRebuild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RectTransform), Member = "set_sendChildDimensionsChange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	protected virtual void OnDisable() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LayoutGroup), Member = "get_rectTransform", ReturnType = typeof(RectTransform))]
	[Calls(Type = typeof(RectTransform), Member = "set_sendChildDimensionsChange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(LayoutGroup), Member = "SetDirty", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	protected virtual void OnEnable() { }

	[CalledBy(Type = "UI.Tables.TableCell", Member = "OnRectTransformDimensionsChange", ReturnType = typeof(void))]
	[CalledBy(Type = "UI.Tables.TableLayout", Member = "OnRectTransformDimensionsChange", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(Component), Member = "GetComponent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(Component))]
	[Calls(Type = typeof(LayoutGroup), Member = "SetDirty", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	protected virtual void OnRectTransformDimensionsChange() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LayoutGroup), Member = "SetDirty", ReturnType = typeof(void))]
	[DeduplicatedMethod]
	protected override void OnTransformChildrenChanged() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LayoutGroup), Member = "SetProperty", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"System.Int32Enum"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32Enum&), "System.Int32Enum"}, ReturnType = typeof(void))]
	public void set_childAlignment(TextAnchor value) { }

	[CalledBy(Type = "UI.Tables.TableCell", Member = "SetCellPaddingFromTableLayout", ReturnType = typeof(void))]
	[CalledBy(Type = "UI.Tables.TableLayout", Member = "UpdateLayout", ReturnType = typeof(void))]
	[CalledBy(Type = "UI.Dates.DatePickerHeaderConfig", Member = "Apply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UI.Dates.DatePicker_Header"}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(LayoutGroup), Member = "SetProperty", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object&), typeof(object)}, ReturnType = typeof(void))]
	public void set_padding(RectOffset value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(LayoutGroup), Member = "SetChildAlongAxisWithScale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform), typeof(int), typeof(float), typeof(float)}, ReturnType = typeof(void))]
	protected void SetChildAlongAxis(RectTransform rect, int axis, float pos) { }

	[CalledBy(Type = typeof(GridLayoutGroup), Member = "SetCellsAlongAxis", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(LayoutGroup), Member = "SetChildAlongAxisWithScale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform), typeof(int), typeof(float), typeof(float), typeof(float)}, ReturnType = typeof(void))]
	protected void SetChildAlongAxis(RectTransform rect, int axis, float pos, float size) { }

	[CalledBy(Type = typeof(HorizontalOrVerticalLayoutGroup), Member = "SetChildrenAlongAxis", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LayoutGroup), Member = "SetChildAlongAxis", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform), typeof(int), typeof(float), typeof(float)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(RectTransform), Member = "set_anchorMin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RectTransform), Member = "set_anchorMax", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RectTransform), Member = "get_sizeDelta", ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(RectTransform), Member = "set_sizeDelta", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RectTransform), Member = "get_anchoredPosition", ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(RectTransform), Member = "get_pivot", ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(Vector2), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RectTransform), Member = "set_anchoredPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(IndexOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 9)]
	protected void SetChildAlongAxisWithScale(RectTransform rect, int axis, float pos, float size, float scaleFactor) { }

	[CalledBy(Type = typeof(HorizontalOrVerticalLayoutGroup), Member = "SetChildrenAlongAxis", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LayoutGroup), Member = "SetChildAlongAxis", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform), typeof(int), typeof(float)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(RectTransform), Member = "set_anchorMin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RectTransform), Member = "set_anchorMax", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RectTransform), Member = "get_anchoredPosition", ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(RectTransform), Member = "get_sizeDelta", ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(RectTransform), Member = "get_pivot", ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(Vector2), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RectTransform), Member = "set_anchoredPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(IndexOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	protected void SetChildAlongAxisWithScale(RectTransform rect, int axis, float pos, float scaleFactor) { }

	[CalledBy(Type = "UI.Tables.TableCell", Member = "Initialise", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UI.Tables.TableLayout", "UI.Tables.TableRow"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UI.Tables.TableRow", Member = "UpdateLayout", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LayoutGroup), Member = "OnEnable", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LayoutGroup), Member = "OnDidApplyAnimationProperties", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LayoutGroup), Member = "OnRectTransformDimensionsChange", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LayoutGroup), Member = "OnTransformChildrenChanged", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LayoutGroup), Member = "OnChildRectTransformDimensionsChange", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LayoutGroup), Member = "SetProperty", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", "T"}, ReturnType = typeof(void))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(CanvasUpdateRegistry), Member = "IsRebuildingLayout", ReturnType = typeof(bool))]
	[Calls(Type = typeof(LayoutGroup), Member = "get_rectTransform", ReturnType = typeof(RectTransform))]
	[Calls(Type = typeof(LayoutRebuilder), Member = "MarkLayoutForRebuild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	protected void SetDirty() { }

	public abstract void SetLayoutHorizontal() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(IndexOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	protected void SetLayoutInputForAxis(float totalMin, float totalPreferred, float totalFlexible, int axis) { }

	public abstract void SetLayoutVertical() { }

	[CalledBy(Type = typeof(HorizontalOrVerticalLayoutGroup), Member = "set_childForceExpandWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(HorizontalOrVerticalLayoutGroup), Member = "set_childForceExpandHeight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(HorizontalOrVerticalLayoutGroup), Member = "set_childControlWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(HorizontalOrVerticalLayoutGroup), Member = "set_childControlHeight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(HorizontalOrVerticalLayoutGroup), Member = "set_childScaleWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(HorizontalOrVerticalLayoutGroup), Member = "set_childScaleHeight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(HorizontalOrVerticalLayoutGroup), Member = "set_reverseArrangement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(bool), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(LayoutGroup), Member = "SetDirty", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	protected void SetProperty(ref T currentValue, T newValue) { }

}

