namespace UI.Dates;

public class DatePickerPermittedWeekDaysConfig
{
	public bool Monday; //Field offset: 0x10
	public bool Tuesday; //Field offset: 0x11
	public bool Wednesday; //Field offset: 0x12
	public bool Thursday; //Field offset: 0x13
	public bool Friday; //Field offset: 0x14
	public bool Saturday; //Field offset: 0x15
	public bool Sunday; //Field offset: 0x16

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public DatePickerPermittedWeekDaysConfig() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public DatePickerPermittedWeekDaysConfig Clone() { }

}

