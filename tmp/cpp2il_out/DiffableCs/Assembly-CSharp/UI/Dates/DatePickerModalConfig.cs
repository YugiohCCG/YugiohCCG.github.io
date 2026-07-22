namespace UI.Dates;

public class DatePickerModalConfig
{
	[Tooltip("If this is set to true, then the DatePicker will be the only thing on the screen which can be interacted with when it is active.")]
	public bool IsModal; //Field offset: 0x10
	[Tooltip("If this is set to true, then the DatePicker will be closed when the screen overlay is clicked. Relevant to Modal DatePickers only.")]
	public bool CloseWhenModalOverlayClicked; //Field offset: 0x11
	public Color ScreenOverlayColor; //Field offset: 0x14

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public DatePickerModalConfig() { }

}

