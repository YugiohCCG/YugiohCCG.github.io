namespace UI.Dates;

public class DatePicker_DayButton : DatePicker_Button
{
	public DateTime Date; //Field offset: 0x48
	public DatePickerDayButtonType Type; //Field offset: 0x50
	[HideInInspector]
	public DatePicker DatePicker; //Field offset: 0x58

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public DatePicker_DayButton() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DatePicker), Member = "DayButtonClicked", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void Clicked() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DatePicker), Member = "DayButtonMouseOver", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void MouseOver() { }

}

