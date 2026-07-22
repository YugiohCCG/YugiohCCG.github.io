namespace UI.Dates;

public class DatePickerDayConfig
{
	public Color BackgroundColor; //Field offset: 0x10
	[FormerlySerializedAs("Font")]
	[HideInInspector]
	[SerializeField]
	private Font oldFont; //Field offset: 0x20
	public TMP_FontAsset Font; //Field offset: 0x28
	public int FontSize; //Field offset: 0x30
	public bool FontAutoSize; //Field offset: 0x34
	public int FontSizeMin; //Field offset: 0x38
	public int FontSizeMax; //Field offset: 0x3C
	public DatePickerDayButtonConfig CurrentMonth; //Field offset: 0x40
	public DatePickerDayButtonConfig OtherMonths; //Field offset: 0x48
	public DatePickerDayButtonConfig Today; //Field offset: 0x50
	public DatePickerDayButtonConfig SelectedDay; //Field offset: 0x58

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public DatePickerDayConfig() { }

	[CalledBy(Type = typeof(DatePicker), Member = "UpdateDaySection", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void Validate() { }

}

