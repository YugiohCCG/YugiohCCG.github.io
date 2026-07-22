namespace UI.Dates;

public class DatePickerWeekDaysConfig
{
	[Header("Week Numbers")]
	public bool ShowWeekNumbers; //Field offset: 0x10
	public WeekNumberMode WeekNumberMode; //Field offset: 0x14
	public CalendarWeekRule CalendarWeekRule; //Field offset: 0x18
	[Tooltip("0 == Auto")]
	public float WeekNumberColumnWidth; //Field offset: 0x1C
	[Header("Appearance")]
	[Tooltip("If this value is set, then the values provided here will override the values of the template. If you wish to modify the template directly, this value should be cleared.")]
	public bool OverrideTemplate; //Field offset: 0x20
	[Header("Text")]
	public Color TextColor; //Field offset: 0x24
	[FormerlySerializedAs("Font")]
	[HideInInspector]
	[SerializeField]
	private TMP_FontAsset oldFont; //Field offset: 0x38
	public TMP_FontAsset Font; //Field offset: 0x40
	public int FontSize; //Field offset: 0x48
	public bool FontAutoSize; //Field offset: 0x4C
	public int FontSizeMin; //Field offset: 0x50
	public int FontSizeMax; //Field offset: 0x54
	[Header("Background")]
	public Sprite BackgroundImage; //Field offset: 0x58
	public Color BackgroundColor; //Field offset: 0x60

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public DatePickerWeekDaysConfig() { }

	[CalledBy(Type = typeof(DatePicker), Member = "_UpdateDisplay", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DatePicker), Member = "UpdateWeekDayHeaders", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(DatePicker_DayHeader), Member = "get_HeaderText", ReturnType = typeof(TextMeshProUGUI))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TMP_Text), Member = "set_font", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TMP_FontAsset)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_Text), Member = "set_fontSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_Text), Member = "set_fontSizeMin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_Text), Member = "set_fontSizeMax", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_Text), Member = "set_enableAutoSizing", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TableCell), Member = "get_image", ReturnType = typeof(Image))]
	[Calls(Type = typeof(Image), Member = "set_sprite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sprite)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	public void ApplyConfig(DatePicker_DayHeader header) { }

}

