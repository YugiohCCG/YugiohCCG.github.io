namespace UI.Dates;

public class DatePickerInputFieldConfig
{
	public bool ToggleDisplayWhenInputFieldClicked; //Field offset: 0x10
	public bool ShowToggleButton; //Field offset: 0x11
	public float ToggleButtonWidth; //Field offset: 0x14
	public Alignment DatePickerAlignmentRelativeToInputField; //Field offset: 0x18

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public DatePickerInputFieldConfig() { }

}

