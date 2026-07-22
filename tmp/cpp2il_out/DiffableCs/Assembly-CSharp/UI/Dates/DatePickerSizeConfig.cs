namespace UI.Dates;

public class DatePickerSizeConfig
{
	public bool OverrideTransformHeight; //Field offset: 0x10
	public float PreferredHeight; //Field offset: 0x14
	public bool UsePreferredWidthInsteadOfInputFieldWidth; //Field offset: 0x18
	public float PreferredWidth; //Field offset: 0x1C

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public DatePickerSizeConfig() { }

}

