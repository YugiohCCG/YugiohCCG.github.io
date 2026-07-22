namespace UI.Dates;

[Extension]
public static class DatePickerUtilities
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<String, Boolean> <>9__3_0; //Field offset: 0x8

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		private static <>c() { }

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
		internal bool <GetAbbreviatedDayNames>b__3_0(string d) { }

	}

	public static string DateFormat; //Field offset: 0x0

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private static DatePickerUtilities() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DatePickerUtilities), Member = "ToDateString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Dictionary`2), Member = "ContainsKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DateTime), Member = "get_Year", ReturnType = typeof(int))]
	[Calls(Type = typeof(DateTime), Member = "get_Month", ReturnType = typeof(int))]
	[Calls(Type = typeof(DateTime), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DateTime), Member = "DaysInMonth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(DateTime), Member = "AddDays", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double)}, ReturnType = typeof(DateTime))]
	[Calls(Type = typeof(DateTime), Member = "AddTicks", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(DateTime))]
	[Calls(Type = typeof(DateTime), Member = "CompareTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Boolean>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Dictionary`2), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = "TValue")]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public static bool DateFallsWithinMonth(DateTime date, DateTime month) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DateTimeFormatInfo), Member = "get_CurrentInfo", ReturnType = typeof(DateTimeFormatInfo))]
	[Calls(Type = typeof(DateTimeFormatInfo), Member = "get_AbbreviatedDayNames", ReturnType = typeof(String[]))]
	[Calls(Type = typeof(Enumerable), Member = "Where", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, Boolean>"}, ReturnType = "System.Collections.Generic.IEnumerable`1<TSource>")]
	[Calls(Type = typeof(Enumerable), Member = "ToArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(Object[]))]
	[Calls(Type = typeof(DateTimeFormatInfo), Member = "get_FirstDayOfWeek", ReturnType = typeof(DayOfWeek))]
	[Calls(Type = typeof(DatePickerUtilities), Member = "Shift", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]", typeof(int)}, ReturnType = "T[]")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static String[] GetAbbreviatedDayNames() { }

	[CalledBy(Type = typeof(DatePicker), Member = "_UpdateDisplay", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DateTime), Member = "get_Year", ReturnType = typeof(int))]
	[Calls(Type = typeof(DateTime), Member = "get_Month", ReturnType = typeof(int))]
	[Calls(Type = typeof(DateTime), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DateTimeFormatInfo), Member = "get_CurrentInfo", ReturnType = typeof(DateTimeFormatInfo))]
	[Calls(Type = typeof(DateTimeFormatInfo), Member = "get_FirstDayOfWeek", ReturnType = typeof(DayOfWeek))]
	[Calls(Type = typeof(DateTime), Member = "get_DayOfWeek", ReturnType = typeof(DayOfWeek))]
	[Calls(Type = typeof(DateTime), Member = "get_Date", ReturnType = typeof(DateTime))]
	[Calls(Type = typeof(DateTime), Member = "op_LessThanOrEqual", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(DateTime)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DateTime), Member = "AddDays", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double)}, ReturnType = typeof(DateTime))]
	[Calls(Type = typeof(List`1), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DateTime), Member = "op_GreaterThanOrEqual", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(DateTime)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public static List<DateTime> GetDateRangeForDisplay(DateTime date) { }

	[CalledBy(Type = typeof(DatePicker), Member = "_UpdateDisplay", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DatePickerUtilities), Member = "GetAbbreviatedDayNames", ReturnType = typeof(String[]))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	internal static T[] Shift(T[] array, int positions) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SerializableDate), Member = "get_HasValue", ReturnType = typeof(bool))]
	[Calls(Type = typeof(SerializableDate), Member = "get_Date", ReturnType = typeof(DateTime))]
	[Calls(Type = typeof(DatePickerUtilities), Member = "ToDateString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime)}, ReturnType = typeof(string))]
	[Extension]
	public static string ToDateString(SerializableDate date) { }

	[CalledBy(Type = typeof(DatePicker), Member = "_UpdateDisplay", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DatePicker), Member = "GetDayButton", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime)}, ReturnType = typeof(DatePicker_DayButton))]
	[CalledBy(Type = typeof(DatePickerUtilities), Member = "ToDateString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializableDate)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(DatePickerUtilities), Member = "DateFallsWithinMonth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(DateTime)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(SerializableDate), Member = "set_Date", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SerializableDate), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SerializableDate), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializableDate)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SerializableDate), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime)}, ReturnType = typeof(SerializableDate))]
	[CalledBy(Type = typeof(Card), Member = "get_DateString", ReturnType = typeof(string))]
	[CallerCount(Count = 12)]
	[Calls(Type = typeof(DateTime), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Extension]
	public static string ToDateString(DateTime date) { }

}

