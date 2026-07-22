namespace UI.Dates;

[ExecuteInEditMode]
public class DatePicker_DateRange : MonoBehaviour
{
	[SerializeField]
	private SerializableDate m_FromDate; //Field offset: 0x20
	[SerializeField]
	private SerializableDate m_ToDate; //Field offset: 0x28
	public DatePickerConfig Config; //Field offset: 0x30
	public DatePicker Ref_DatePicker_From; //Field offset: 0x98
	public DatePicker Ref_DatePicker_To; //Field offset: 0xA0

	public SerializableDate FromDate
	{
		[CallerCount(Count = 12)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(DatePicker_DateRange), Member = "SetProperty", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", "T"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(SerializableDate), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializableDate)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(DatePicker), Member = "set_SelectedDate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializableDate)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		 set { } //Length: 135
	}

	public SerializableDate ToDate
	{
		[CallerCount(Count = 15)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(DatePicker_DateRange), Member = "SetProperty", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", "T"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(SerializableDate), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializableDate)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(DatePicker), Member = "set_SelectedDate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializableDate)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		 set { } //Length: 135
	}

	[CallerCount(Count = 36)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public DatePicker_DateRange() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DatePicker), Member = "Hide", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	private void <DateSelected>b__17_0() { }

	[CalledBy(Type = typeof(DatePicker_DateRange), Member = "UpdateDisplay", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(DatePickerDateRangeConfig), Member = "Clone", ReturnType = typeof(DatePickerDateRangeConfig))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	private void ApplyConfig(DatePicker datePicker) { }

	[CalledBy(Type = typeof(DatePicker), Member = "DayButtonClicked", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SerializableDate), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializableDate)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DatePicker_DateRange), Member = "SetProperty", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", "T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DatePicker), Member = "set_SelectedDate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializableDate)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DatePicker_DateRange), Member = "UpdateDisplay", ReturnType = typeof(void))]
	[Calls(Type = typeof(DatePickerTimer), Member = "DelayedCall", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(Action), typeof(MonoBehaviour), typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public void DateSelected(DateTime date) { }

	[CallerCount(Count = 12)]
	[DeduplicatedMethod]
	public SerializableDate get_FromDate() { }

	[CallerCount(Count = 15)]
	[DeduplicatedMethod]
	public SerializableDate get_ToDate() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DatePicker), Member = "Hide", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void Hide() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DatePicker), Member = "get_IsVisible", ReturnType = typeof(bool))]
	[Calls(Type = typeof(DatePicker), Member = "Show", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DatePicker), Member = "Hide", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void InputFieldClicked() { }

	[CalledBy(Type = typeof(DatePicker), Member = "ModalOverlayClicked", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DatePicker), Member = "Hide", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void ModalOverlayClicked() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DatePicker_DateRange), Member = "SetProperty", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", "T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SerializableDate), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializableDate)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DatePicker), Member = "set_SelectedDate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializableDate)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void set_FromDate(SerializableDate value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DatePicker_DateRange), Member = "SetProperty", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", "T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SerializableDate), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializableDate)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DatePicker), Member = "set_SelectedDate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializableDate)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void set_ToDate(SerializableDate value) { }

	[CalledBy(Type = typeof(DatePicker_DateRange), Member = "set_FromDate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializableDate)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DatePicker_DateRange), Member = "set_ToDate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializableDate)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DatePicker_DateRange), Member = "DateSelected", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(DatePicker_DateRange), Member = "UpdateDisplay", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	protected void SetProperty(ref T currentValue, T newValue) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DatePicker), Member = "Show", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void Show() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DatePicker), Member = "get_IsVisible", ReturnType = typeof(bool))]
	[Calls(Type = typeof(DatePicker), Member = "Show", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DatePicker), Member = "Hide", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void ToggleDisplay() { }

	[CalledBy(Type = typeof(DatePicker_DateRange), Member = "DateSelected", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DatePicker_DateRange), Member = "SetProperty", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", "T"}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(GameObject), Member = "get_activeInHierarchy", ReturnType = typeof(bool))]
	[Calls(Type = typeof(DatePicker_DateRange), Member = "ApplyConfig", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DatePicker)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DatePicker), Member = "UpdateDisplay", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	public void UpdateDisplay() { }

}

