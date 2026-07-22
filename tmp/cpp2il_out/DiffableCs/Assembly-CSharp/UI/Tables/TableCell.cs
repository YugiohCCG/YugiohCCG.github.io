namespace UI.Tables;

[RequireComponent(typeof(RectTransform))]
public class TableCell : HorizontalLayoutGroup
{
	[Tooltip("How many columns should this cell span?")]
	public int columnSpan; //Field offset: 0x70
	[Tooltip("If this property is set, then this cell will ignore the TableLayout CellBackgroundColor/CellBackgroundImage values - allowing you to set specific values for this cell.")]
	public bool dontUseTableCellBackground; //Field offset: 0x74
	[Tooltip("If this property is set, then this cell will ignore the TableLayout Global Cell Padding values - allowing you to set specific values for this cell.")]
	public bool overrideGlobalPadding; //Field offset: 0x75
	internal float actualWidth; //Field offset: 0x78
	internal float actualHeight; //Field offset: 0x7C
	internal float actualX; //Field offset: 0x80
	internal float actualY; //Field offset: 0x84
	protected Image _image; //Field offset: 0x88
	[SerializeField]
	private TableLayout m_tableLayout; //Field offset: 0x90
	[SerializeField]
	private TableRow m_tableRow; //Field offset: 0x98

	public Image image
	{
		[CalledBy(Type = typeof(TableLayout), Member = "UpdateLayout", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DatePicker), Member = "UpdateDaySection", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DatePickerWeekDaysConfig), Member = "ApplyConfig", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DatePicker_DayHeader)}, ReturnType = typeof(void))]
		[CallerCount(Count = 5)]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 153
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public TableCell() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MonoBehaviour), Member = "set_useGUILayout", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	protected virtual void Awake() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(HorizontalLayoutGroup), Member = "CalculateLayoutInputHorizontal", ReturnType = typeof(void))]
	public virtual void CalculateLayoutInputHorizontal() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(HorizontalLayoutGroup), Member = "CalculateLayoutInputVertical", ReturnType = typeof(void))]
	public virtual void CalculateLayoutInputVertical() { }

	[CalledBy(Type = typeof(TableLayout), Member = "UpdateLayout", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DatePicker), Member = "UpdateDaySection", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DatePickerWeekDaysConfig), Member = "ApplyConfig", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DatePicker_DayHeader)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[CallsUnknownMethods(Count = 1)]
	public Image get_image() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public TableRow GetRow() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(LayoutGroup), Member = "SetDirty", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	internal void Initialise(TableLayout tableLayout, TableRow row) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(GameObject), Member = "get_activeInHierarchy", ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void NotifyTableCellPropertiesChanged() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LayoutGroup), Member = "OnRectTransformDimensionsChange", ReturnType = typeof(void))]
	[DeduplicatedMethod]
	protected virtual void OnRectTransformDimensionsChange() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LayoutGroup), Member = "set_padding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectOffset)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void SetCellPaddingFromTableLayout() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(HorizontalLayoutGroup), Member = "SetLayoutHorizontal", ReturnType = typeof(void))]
	public virtual void SetLayoutHorizontal() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(HorizontalLayoutGroup), Member = "SetLayoutVertical", ReturnType = typeof(void))]
	public virtual void SetLayoutVertical() { }

}

