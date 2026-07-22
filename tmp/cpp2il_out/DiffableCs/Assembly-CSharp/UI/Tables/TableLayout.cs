namespace UI.Tables;

[RequireComponent(typeof(RectTransform))]
public class TableLayout : LayoutGroup, ILayoutSelfController, ILayoutController
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<TableRow, Single> <>9__25_0; //Field offset: 0x8
		public static Func<TableRow, Boolean> <>9__25_1; //Field offset: 0x10
		public static Func<TableCell, Int32> <>9__25_4; //Field offset: 0x18
		public static Func<TableRow, Int32> <>9__25_2; //Field offset: 0x20
		public static Func<Single, Boolean> <>9__25_3; //Field offset: 0x28

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
		internal float <UpdateLayout>b__25_0(TableRow r) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		internal bool <UpdateLayout>b__25_1(TableRow r) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(TableRow), Member = "get_Cells", ReturnType = typeof(System.Collections.Generic.List`1<UI.Tables.TableCell>))]
		[Calls(Type = typeof(Enumerable), Member = "Sum", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, Int32>"}, ReturnType = typeof(int))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		internal int <UpdateLayout>b__25_2(TableRow r) { }

		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		internal bool <UpdateLayout>b__25_3(float c) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		internal int <UpdateLayout>b__25_4(TableCell c) { }

	}

	public Sprite RowBackgroundImage; //Field offset: 0x60
	public Color RowBackgroundColor; //Field offset: 0x68
	public bool UseAlternateRowBackgroundColors; //Field offset: 0x78
	public Color RowBackgroundColorAlternate; //Field offset: 0x7C
	public Sprite CellBackgroundImage; //Field offset: 0x90
	public Color CellBackgroundColor; //Field offset: 0x98
	public bool UseAlternateCellBackroundColors; //Field offset: 0xA8
	public Color CellBackgroundColorAlternate; //Field offset: 0xAC
	[Tooltip("If this is set, then this TableLayout will automatically add columns if there are more cells than columns on any row (this includes ColumnSpan checks)")]
	public bool AutomaticallyAddColumns; //Field offset: 0xBC
	[Tooltip("If this is set, then this TableLayout will automatically remove any columns with no cells in them in any row (at the END of the row)")]
	public bool AutomaticallyRemoveEmptyColumns; //Field offset: 0xBD
	public List<Single> ColumnWidths; //Field offset: 0xC0
	[Tooltip("If this is set, then the cellpadding set here will override any padding settings set on individual cells")]
	public bool UseGlobalCellPadding; //Field offset: 0xC8
	public RectOffset CellPadding; //Field offset: 0xD0
	public float CellSpacing; //Field offset: 0xD8
	public bool AutoCalculateHeight; //Field offset: 0xDC
	private DrivenRectTransformTracker _tracker; //Field offset: 0xDD
	private LayoutElement _layoutElement; //Field offset: 0xE0

	public List<TableRow> Rows
	{
		[CalledBy(Type = typeof(TableLayout), Member = "UpdateLayout", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TableLayout), Member = "ClearRows", ReturnType = typeof(void))]
		[CalledBy(Type = "UI.Dates.DatePicker+<>c__DisplayClass70_0", Member = "<_UpdateDisplay>b__0", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DatePicker), Member = "Awake", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DatePicker), Member = "_UpdateDisplay", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DatePicker), Member = "UpdateWeekNumbers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(List`1<DateTime>&)}, ReturnType = typeof(void))]
		[CallerCount(Count = 8)]
		[Calls(Type = typeof(Component), Member = "GetComponentsInChildren", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T[]")]
		[Calls(Type = typeof(Enumerable), Member = "Where", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, Boolean>"}, ReturnType = "System.Collections.Generic.IEnumerable`1<TSource>")]
		[Calls(Type = typeof(Enumerable), Member = "ToList", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(System.Collections.Generic.List`1<System.Object>))]
		[CallsDeduplicatedMethods(Count = 1)]
		 get { } //Length: 196
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RectOffset), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(LayoutGroup), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public TableLayout() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	private bool <get_Rows>b__16_0(TableRow tr) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TableLayout), Member = "AddRow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(TableRow))]
	[CallsUnknownMethods(Count = 1)]
	public TableRow AddRow() { }

	[CalledBy(Type = typeof(TableLayout), Member = "AddRow", ReturnType = typeof(TableRow))]
	[CalledBy(Type = "UI.Tables.Examples.DynamicRowsExampleController+<AddRowsWithoutTemplate>d__8", Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DatePicker), Member = "_UpdateDisplay", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(TableLayoutUtilities), Member = "InstantiatePrefab", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool), typeof(bool)}, ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(Object), Member = "set_name", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GameObject), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Transform), Member = "SetAsLastSibling", ReturnType = typeof(void))]
	[Calls(Type = typeof(GameObject), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(TableRow), Member = "AddCell", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform)}, ReturnType = typeof(TableCell))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public TableRow AddRow(int cells) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Transform), Member = "SetAsLastSibling", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public TableRow AddRow(TableRow row) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	protected virtual void Awake() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LayoutGroup), Member = "CalculateLayoutInputHorizontal", ReturnType = typeof(void))]
	[Calls(Type = typeof(TableLayout), Member = "UpdateLayout", ReturnType = typeof(void))]
	public virtual void CalculateLayoutInputHorizontal() { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	public virtual void CalculateLayoutInputVertical() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TableLayout), Member = "get_Rows", ReturnType = typeof(System.Collections.Generic.List`1<UI.Tables.TableRow>))]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Application), Member = "get_isPlaying", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(Object), Member = "DestroyImmediate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "Destroy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	public void ClearRows() { }

	[CalledBy(Type = typeof(TableLayout), Member = "UpdateLayout", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TableLayout), Member = "ClearRows", ReturnType = typeof(void))]
	[CalledBy(Type = "UI.Dates.DatePicker+<>c__DisplayClass70_0", Member = "<_UpdateDisplay>b__0", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DatePicker), Member = "Awake", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DatePicker), Member = "_UpdateDisplay", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DatePicker), Member = "UpdateWeekNumbers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(List`1<DateTime>&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(Component), Member = "GetComponentsInChildren", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T[]")]
	[Calls(Type = typeof(Enumerable), Member = "Where", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, Boolean>"}, ReturnType = "System.Collections.Generic.IEnumerable`1<TSource>")]
	[Calls(Type = typeof(Enumerable), Member = "ToList", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(System.Collections.Generic.List`1<System.Object>))]
	[CallsDeduplicatedMethods(Count = 1)]
	public List<TableRow> get_Rows() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LayoutGroup), Member = "OnRectTransformDimensionsChange", ReturnType = typeof(void))]
	[DeduplicatedMethod]
	protected virtual void OnRectTransformDimensionsChange() { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	public virtual void SetLayoutHorizontal() { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	public virtual void SetLayoutVertical() { }

	[CalledBy(Type = typeof(TableLayout), Member = "CalculateLayoutInputHorizontal", ReturnType = typeof(void))]
	[CalledBy(Type = "UI.Dates.DatePicker+<>c__DisplayClass70_0", Member = "<_UpdateDisplay>b__1", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DatePicker), Member = "_UpdateDisplay", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DatePicker), Member = "UpdateInputField", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DatePickerHeaderConfig), Member = "Apply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DatePicker_Header)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DatePicker_InputField), Member = "UpdateDisplay", ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(Enumerable), Member = "Count", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Single>), typeof(System.Func`2<System.Single, System.Boolean>)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(RectTransform), Member = "set_pivot", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RectTransform), Member = "set_anchorMin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RectTransform), Member = "set_anchorMax", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Transform), Member = "set_localScale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Transform), Member = "set_localRotation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RectTransform), Member = "set_sizeDelta", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RectTransform), Member = "set_anchoredPosition3D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TableRow), Member = "get_Cells", ReturnType = typeof(System.Collections.Generic.List`1<UI.Tables.TableCell>))]
	[Calls(Type = typeof(TableRow), Member = "UpdateLayout", ReturnType = typeof(void))]
	[Calls(Type = typeof(LayoutGroup), Member = "set_padding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectOffset)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TableCell), Member = "get_image", ReturnType = typeof(Image))]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(RectTransform), Member = "get_pivot", ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(RectTransform), Member = "get_sizeDelta", ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(RectTransform), Member = "get_anchorMin", ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(RectTransform), Member = "get_anchorMax", ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(RectTransform), Member = "get_anchoredPosition", ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(RectOffset), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Image), Member = "set_sprite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sprite)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Single>), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(LayoutGroup), Member = "get_rectTransform", ReturnType = typeof(RectTransform))]
	[Calls(Type = typeof(RectTransform), Member = "get_rect", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(TableLayout), Member = "get_Rows", ReturnType = typeof(System.Collections.Generic.List`1<UI.Tables.TableRow>))]
	[Calls(Type = typeof(Enumerable), Member = "ToList", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(System.Collections.Generic.List`1<System.Object>))]
	[Calls(Type = typeof(Enumerable), Member = "Any", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Func`2<System.Object, System.Single>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Enumerable), Member = "Sum", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, Single>"}, ReturnType = typeof(float))]
	[Calls(Type = typeof(RectOffset), Member = "get_top", ReturnType = typeof(int))]
	[Calls(Type = typeof(TableRow), Member = "get_image", ReturnType = typeof(Image))]
	[Calls(Type = typeof(RectOffset), Member = "get_bottom", ReturnType = typeof(int))]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Enumerable), Member = "Max", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, Int32>"}, ReturnType = typeof(int))]
	[Calls(Type = typeof(List`1), Member = "RemoveRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RectOffset), Member = "get_left", ReturnType = typeof(int))]
	[Calls(Type = typeof(RectOffset), Member = "get_right", ReturnType = typeof(int))]
	[Calls(Type = typeof(RectTransform), Member = "set_anchoredPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Enumerable), Member = "Count", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, Boolean>"}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 18)]
	[CallsUnknownMethods(Count = 22)]
	[ContainsUnimplementedInstructions]
	public void UpdateLayout() { }

}

