namespace UI.Dates;

[ExecuteInEditMode]
public class ExampleController : MonoBehaviour
{
	public DatePicker InlineDatePicker; //Field offset: 0x20

	[CallerCount(Count = 36)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public ExampleController() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DatePicker), Member = "set_DateSelectionMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateSelectionMode)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DatePicker), Member = "UpdateDisplay", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void ToggleAllowMultipleDateSelection(bool on) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DatePicker), Member = "UpdateDisplay", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void ToggleNextPreviousMonthButtons(bool on) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DatePicker), Member = "UpdateDisplay", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void ToggleNextPreviousYearButtons(bool on) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DatePicker), Member = "UpdateDisplay", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void ToggleShowDatesInOtherMonths(bool on) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DatePicker), Member = "UpdateDisplay", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void ToggleWeekNumberDisplay(bool on) { }

}

