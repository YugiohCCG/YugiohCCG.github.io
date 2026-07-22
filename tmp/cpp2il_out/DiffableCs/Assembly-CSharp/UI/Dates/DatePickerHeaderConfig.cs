namespace UI.Dates;

public class DatePickerHeaderConfig
{
	public bool ShowHeader; //Field offset: 0x10
	[Header("Background")]
	public Color BackgroundColor; //Field offset: 0x14
	[Header("Text")]
	public Color TextColor; //Field offset: 0x24
	[FormerlySerializedAs("Font")]
	[HideInInspector]
	[SerializeField]
	private Font oldFont; //Field offset: 0x38
	public TMP_FontAsset Font; //Field offset: 0x40
	public int FontSize; //Field offset: 0x48
	public bool FontAutoSize; //Field offset: 0x4C
	public int FontSizeMin; //Field offset: 0x50
	public int FontSizeMax; //Field offset: 0x54
	[Header("Height")]
	public float Height; //Field offset: 0x58
	[Header("Buttons")]
	public bool ShowNextAndPreviousMonthButtons; //Field offset: 0x5C
	public bool ShowNextAndPreviousYearButtons; //Field offset: 0x5D
	[Space]
	public float MonthButtonCellWidth; //Field offset: 0x60
	public RectOffset MonthButtonCellPadding; //Field offset: 0x68
	[Space]
	public float YearButtonCellWidth; //Field offset: 0x70
	public RectOffset YearButtonCellPadding; //Field offset: 0x78
	[Space]
	public DatePickerButtonConfig PreviousMonthButton; //Field offset: 0x80
	public DatePickerButtonConfig NextMonthButton; //Field offset: 0x88
	public DatePickerButtonConfig PreviousYearButton; //Field offset: 0x90
	public DatePickerButtonConfig NextYearButton; //Field offset: 0x98
	[HideInInspector]
	[SerializeField]
	private bool m_newPaddingValuesApplied; //Field offset: 0xA0

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public DatePickerHeaderConfig() { }

	[CalledBy(Type = typeof(DatePicker), Member = "UpdateHeader", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TMP_Text), Member = "set_fontSizeMax", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(LayoutGroup), Member = "set_padding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectOffset)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DatePicker_Button), Member = "get_Cell", ReturnType = typeof(TableCell))]
	[Calls(Type = typeof(RectOffset), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Single>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TableRow), Member = "NotifyTableRowPropertiesChanged", ReturnType = typeof(void))]
	[Calls(Type = typeof(DatePickerButtonConfig), Member = "ApplyConfig", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DatePicker_Button)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_Text), Member = "set_enableAutoSizing", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_Text), Member = "set_fontSizeMin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(LayoutRebuilder), Member = "MarkLayoutForRebuild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_Text), Member = "set_fontSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_Text), Member = "set_font", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TMP_FontAsset)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DatePicker_Header), Member = "get_HeaderText", ReturnType = typeof(TextMeshProUGUI))]
	[Calls(Type = typeof(GameObject), Member = "SetActive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TableLayout), Member = "UpdateLayout", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 11)]
	[ContainsUnimplementedInstructions]
	public void Apply(DatePicker_Header header) { }

}

