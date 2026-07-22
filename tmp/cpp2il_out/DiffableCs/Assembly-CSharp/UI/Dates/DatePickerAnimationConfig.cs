namespace UI.Dates;

public class DatePickerAnimationConfig
{
	public Animation ShowAnimation; //Field offset: 0x10
	public Animation HideAnimation; //Field offset: 0x14
	public Animation MonthChangedAnimation; //Field offset: 0x18

	[CallerCount(Count = 2180)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public DatePickerAnimationConfig() { }

}

