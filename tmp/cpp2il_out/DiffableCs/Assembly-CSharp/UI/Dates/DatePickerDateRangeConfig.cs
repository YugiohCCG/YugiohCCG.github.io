namespace UI.Dates;

public class DatePickerDateRangeConfig
{
	public bool RestrictFromDate; //Field offset: 0x10
	public SerializableDate FromDate; //Field offset: 0x18
	public bool RestrictToDate; //Field offset: 0x20
	public SerializableDate ToDate; //Field offset: 0x28
	public List<SerializableDate> ProhibitedDates; //Field offset: 0x30
	public DatePickerPermittedWeekDaysConfig PermittedWeekDays; //Field offset: 0x38

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	public DatePickerDateRangeConfig() { }

	[CalledBy(Type = typeof(DatePicker_DateRange), Member = "ApplyConfig", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DatePicker)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SerializableDate), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializableDate)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Enumerable), Member = "ToList", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializableDate)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<UI.Dates.SerializableDate>)}, ReturnType = typeof(System.Collections.Generic.List`1<UI.Dates.SerializableDate>))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 7)]
	public DatePickerDateRangeConfig Clone() { }

	[CalledBy(Type = typeof(DatePicker), Member = "_UpdateDisplay", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DatePicker), Member = "UpdateHeader", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SerializableDate), Member = "get_Date", ReturnType = typeof(DateTime))]
	[Calls(Type = typeof(DateTime), Member = "CompareTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime)}, ReturnType = typeof(int))]
	public bool Validate(bool silent = false) { }

}

