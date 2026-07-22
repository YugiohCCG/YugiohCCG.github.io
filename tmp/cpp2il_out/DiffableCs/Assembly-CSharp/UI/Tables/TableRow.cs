namespace UI.Tables;

[RequireComponent(typeof(RectTransform))]
public class TableRow : MonoBehaviour
{
	public float preferredHeight; //Field offset: 0x20
	internal float actualHeight; //Field offset: 0x24
	public bool dontUseTableRowBackground; //Field offset: 0x28
	protected Image _image; //Field offset: 0x30
	private DrivenRectTransformTracker _tracker; //Field offset: 0x38
	[SerializeField]
	private TableLayout m_tableLayout; //Field offset: 0x40

	public int CellCount
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(TableRow), Member = "get_Cells", ReturnType = typeof(System.Collections.Generic.List`1<UI.Tables.TableCell>))]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 66
	}

	public List<TableCell> Cells
	{
		[CalledBy(Type = "UI.Tables.TableLayout+<>c", Member = "<UpdateLayout>b__25_2", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TableRow)}, ReturnType = typeof(int))]
		[CalledBy(Type = typeof(TableLayout), Member = "UpdateLayout", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TableRow), Member = "get_CellCount", ReturnType = typeof(int))]
		[CalledBy(Type = typeof(TableRow), Member = "UpdateLayout", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TableRow), Member = "ClearCells", ReturnType = typeof(void))]
		[CalledBy(Type = "UI.Tables.Examples.DynamicRowsExampleController+<AddRowsUsingTemplate>d__7", Member = "MoveNext", ReturnType = typeof(bool))]
		[CalledBy(Type = "UI.Dates.DatePicker+<>c__DisplayClass70_0", Member = "<_UpdateDisplay>b__0", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DatePicker), Member = "_UpdateDisplay", ReturnType = typeof(void))]
		[CallerCount(Count = 12)]
		[Calls(Type = typeof(Component), Member = "GetComponentsInChildren", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T[]")]
		[Calls(Type = typeof(Enumerable), Member = "Where", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, Boolean>"}, ReturnType = "System.Collections.Generic.IEnumerable`1<TSource>")]
		[Calls(Type = typeof(Enumerable), Member = "ToList", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(System.Collections.Generic.List`1<System.Object>))]
		[CallsDeduplicatedMethods(Count = 1)]
		 get { } //Length: 196
	}

	public Image image
	{
		[CalledBy(Type = typeof(TableLayout), Member = "UpdateLayout", ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 141
	}

	[CallerCount(Count = 36)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public TableRow() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	private bool <get_Cells>b__1_0(TableCell tc) { }

	[CalledBy(Type = typeof(TableLayout), Member = "AddRow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(TableRow))]
	[CalledBy(Type = "UI.Tables.Examples.DynamicRowsExampleController+<AddRowsWithoutTemplate>d__8", Member = "MoveNext", ReturnType = typeof(bool))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(TableLayoutUtilities), Member = "InstantiatePrefab", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool), typeof(bool)}, ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(GameObject), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Transform), Member = "SetAsLastSibling", ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "set_name", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Transform), Member = "set_localScale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Transform), Member = "set_localPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GameObject), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public TableCell AddCell(RectTransform cellContent = null) { }

	[CalledBy(Type = typeof(DatePicker), Member = "_UpdateDisplay", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DatePicker), Member = "UpdateWeekNumbers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(List`1<DateTime>&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Transform), Member = "SetAsLastSibling", ReturnType = typeof(void))]
	[Calls(Type = typeof(Transform), Member = "set_localScale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Transform), Member = "set_localRotation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public TableCell AddCell(TableCell cell) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TableRow), Member = "get_Cells", ReturnType = typeof(System.Collections.Generic.List`1<UI.Tables.TableCell>))]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(Object), Member = "DestroyImmediate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public void ClearCells() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TableRow), Member = "get_Cells", ReturnType = typeof(System.Collections.Generic.List`1<UI.Tables.TableCell>))]
	[CallsUnknownMethods(Count = 1)]
	public int get_CellCount() { }

	[CalledBy(Type = "UI.Tables.TableLayout+<>c", Member = "<UpdateLayout>b__25_2", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TableRow)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(TableLayout), Member = "UpdateLayout", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TableRow), Member = "get_CellCount", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(TableRow), Member = "UpdateLayout", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TableRow), Member = "ClearCells", ReturnType = typeof(void))]
	[CalledBy(Type = "UI.Tables.Examples.DynamicRowsExampleController+<AddRowsUsingTemplate>d__7", Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = "UI.Dates.DatePicker+<>c__DisplayClass70_0", Member = "<_UpdateDisplay>b__0", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DatePicker), Member = "_UpdateDisplay", ReturnType = typeof(void))]
	[CallerCount(Count = 12)]
	[Calls(Type = typeof(Component), Member = "GetComponentsInChildren", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T[]")]
	[Calls(Type = typeof(Enumerable), Member = "Where", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, Boolean>"}, ReturnType = "System.Collections.Generic.IEnumerable`1<TSource>")]
	[Calls(Type = typeof(Enumerable), Member = "ToList", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(System.Collections.Generic.List`1<System.Object>))]
	[CallsDeduplicatedMethods(Count = 1)]
	public List<TableCell> get_Cells() { }

	[CalledBy(Type = typeof(TableLayout), Member = "UpdateLayout", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[CallsUnknownMethods(Count = 1)]
	public Image get_image() { }

	[CallerCount(Count = 12)]
	[DeduplicatedMethod]
	public TableLayout GetTable() { }

	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	internal void Initialise(TableLayout tableLayout) { }

	[CalledBy(Type = typeof(DatePickerHeaderConfig), Member = "Apply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DatePicker_Header)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(GameObject), Member = "get_activeInHierarchy", ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void NotifyTableRowPropertiesChanged() { }

	[CalledBy(Type = typeof(TableLayout), Member = "UpdateLayout", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TableRow), Member = "get_Cells", ReturnType = typeof(System.Collections.Generic.List`1<UI.Tables.TableCell>))]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(RectTransform), Member = "set_pivot", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RectTransform), Member = "set_sizeDelta", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RectTransform), Member = "set_anchoredPosition3D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Transform), Member = "set_localScale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RectTransform), Member = "set_anchorMin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RectTransform), Member = "set_anchorMax", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(LayoutGroup), Member = "SetDirty", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 7)]
	public void UpdateLayout() { }

}

