namespace UI.Dates;

public class DatePickerMiscConfig
{
	[Tooltip("If this is set, the DatePicker will always switch to the selected month when a new date is selected.")]
	public bool SwitchToSelectedMonthWhenDateSelected; //Field offset: 0x10
	public bool ShowDatesInOtherMonths; //Field offset: 0x11
	[Tooltip("If this is set, then the DatePicker will be closed when a date is selected. Useful for popup datepicker dialogs.")]
	public bool CloseWhenDateSelected; //Field offset: 0x12

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public DatePickerMiscConfig() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public DatePickerMiscConfig Clone() { }

}

