namespace UI.Dates;

public struct SerializableDate
{
	[SerializeField]
	private string m_SerializedDate; //Field offset: 0x0

	public DateTime Date
	{
		[CallerCount(Count = 30)]
		[Calls(Type = typeof(DateTime), Member = "ParseExact", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(DateTime))]
		 get { } //Length: 145
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(DatePickerUtilities), Member = "ToDateString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime)}, ReturnType = typeof(string))]
		[CallsUnknownMethods(Count = 1)]
		 set { } //Length: 99
	}

	public bool HasValue
	{
		[CalledBy(Type = typeof(HostSettings), Member = "GetGameSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameSettings&), typeof(UInt32&)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UI.Dates.DatePicker+<>c", Member = "<UpdateInputFieldText>b__82_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializableDate)}, ReturnType = typeof(bool))]
		[CalledBy(Type = "UI.Dates.DatePicker+<>c", Member = "<UpdateInputFieldText>b__82_1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializableDate)}, ReturnType = typeof(bool))]
		[CalledBy(Type = "UI.Dates.DatePicker+<>c__DisplayClass70_1", Member = "<_UpdateDisplay>b__2", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializableDate)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(DatePicker), Member = "get_VisibleDate", ReturnType = typeof(SerializableDate))]
		[CalledBy(Type = typeof(DatePicker), Member = "Awake", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DatePicker), Member = "UpdateInputField", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DatePicker), Member = "GetDayTypeForDate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime)}, ReturnType = typeof(DatePickerDayButtonType))]
		[CalledBy(Type = typeof(DatePicker), Member = "UpdateInputFieldText", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DatePickerUtilities), Member = "ToDateString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializableDate)}, ReturnType = typeof(string))]
		[CalledBy(Type = typeof(DeckEdit), Member = "OnApplyButton", ReturnType = typeof(void))]
		[CallerCount(Count = 14)]
		[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
		 get { } //Length: 21
	}

	[CalledBy(Type = typeof(DatePicker), Member = "get_VisibleDate", ReturnType = typeof(SerializableDate))]
	[CalledBy(Type = typeof(DatePicker), Member = "OnTextFieldValueChange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(DatePickerUtilities), Member = "ToDateString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 2)]
	public SerializableDate(DateTime date) { }

	[CalledBy(Type = typeof(DatePickerDateRangeConfig), Member = "Clone", ReturnType = typeof(DatePickerDateRangeConfig))]
	[CalledBy(Type = typeof(DatePicker_DateRange), Member = "set_FromDate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializableDate)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DatePicker_DateRange), Member = "set_ToDate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializableDate)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DatePicker_DateRange), Member = "DateSelected", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime)}, ReturnType = typeof(void))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(SerializableDate), Member = "get_Date", ReturnType = typeof(DateTime))]
	[Calls(Type = typeof(DatePickerUtilities), Member = "ToDateString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 2)]
	public SerializableDate(SerializableDate date) { }

	[CallerCount(Count = 30)]
	[Calls(Type = typeof(DateTime), Member = "ParseExact", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(DateTime))]
	public DateTime get_Date() { }

	[CalledBy(Type = typeof(HostSettings), Member = "GetGameSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameSettings&), typeof(UInt32&)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UI.Dates.DatePicker+<>c", Member = "<UpdateInputFieldText>b__82_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializableDate)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UI.Dates.DatePicker+<>c", Member = "<UpdateInputFieldText>b__82_1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializableDate)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UI.Dates.DatePicker+<>c__DisplayClass70_1", Member = "<_UpdateDisplay>b__2", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializableDate)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DatePicker), Member = "get_VisibleDate", ReturnType = typeof(SerializableDate))]
	[CalledBy(Type = typeof(DatePicker), Member = "Awake", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DatePicker), Member = "UpdateInputField", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DatePicker), Member = "GetDayTypeForDate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime)}, ReturnType = typeof(DatePickerDayButtonType))]
	[CalledBy(Type = typeof(DatePicker), Member = "UpdateInputFieldText", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DatePickerUtilities), Member = "ToDateString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializableDate)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(DeckEdit), Member = "OnApplyButton", ReturnType = typeof(void))]
	[CallerCount(Count = 14)]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	public bool get_HasValue() { }

	[CalledBy(Type = typeof(DatePicker), Member = "Awake", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DatePicker), Member = "ShowPreviousMonth", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DatePicker), Member = "ShowNextMonth", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DatePicker), Member = "ShowPreviousYear", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DatePicker), Member = "ShowNextYear", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DatePicker), Member = "GetDayTypeForDate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime)}, ReturnType = typeof(DatePickerDayButtonType))]
	[CalledBy(Type = typeof(DatePicker), Member = "DayButtonClicked", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DatePicker_InputField), Member = "OnDaySelected", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DatePicker_Instantiation), Member = "InstantiatePrefab", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool), typeof(bool), typeof(Transform)}, ReturnType = typeof(GameObject))]
	[CalledBy(Type = typeof(DeckEdit), Member = "ResetFilters", ReturnType = typeof(void))]
	[CallerCount(Count = 13)]
	[Calls(Type = typeof(DatePickerUtilities), Member = "ToDateString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 2)]
	public static SerializableDate op_Implicit(DateTime date) { }

	[CalledBy(Type = "UI.Dates.DatePicker+<>c__DisplayClass81_0", Member = "<DayButtonClicked>b__0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializableDate)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DatePicker), Member = "_UpdateDisplay", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DatePicker), Member = "UpdateHeader", ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(SerializableDate), Member = "get_Date", ReturnType = typeof(DateTime))]
	public static DateTime op_Implicit(SerializableDate date) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DatePickerUtilities), Member = "ToDateString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 1)]
	public void set_Date(DateTime value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(SerializableDate), Member = "get_Date", ReturnType = typeof(DateTime))]
	[Calls(Type = typeof(DateTime), Member = "ToString", ReturnType = typeof(string))]
	public virtual string ToString() { }

}

