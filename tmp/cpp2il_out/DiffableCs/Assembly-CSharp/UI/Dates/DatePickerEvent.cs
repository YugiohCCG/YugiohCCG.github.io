namespace UI.Dates;

public class DatePickerEvent : UnityEvent<DateTime>
{

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public DatePickerEvent() { }

}

