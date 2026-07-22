namespace System.Globalization;

internal class CultureData
{
	public struct NumberFormatEntryManaged
	{
		internal int currency_decimal_digits; //Field offset: 0x0
		internal int currency_decimal_separator; //Field offset: 0x4
		internal int currency_group_separator; //Field offset: 0x8
		internal int currency_group_sizes0; //Field offset: 0xC
		internal int currency_group_sizes1; //Field offset: 0x10
		internal int currency_negative_pattern; //Field offset: 0x14
		internal int currency_positive_pattern; //Field offset: 0x18
		internal int currency_symbol; //Field offset: 0x1C
		internal int nan_symbol; //Field offset: 0x20
		internal int negative_infinity_symbol; //Field offset: 0x24
		internal int negative_sign; //Field offset: 0x28
		internal int number_decimal_digits; //Field offset: 0x2C
		internal int number_decimal_separator; //Field offset: 0x30
		internal int number_group_separator; //Field offset: 0x34
		internal int number_group_sizes0; //Field offset: 0x38
		internal int number_group_sizes1; //Field offset: 0x3C
		internal int number_negative_pattern; //Field offset: 0x40
		internal int per_mille_symbol; //Field offset: 0x44
		internal int percent_negative_pattern; //Field offset: 0x48
		internal int percent_positive_pattern; //Field offset: 0x4C
		internal int percent_symbol; //Field offset: 0x50
		internal int positive_infinity_symbol; //Field offset: 0x54
		internal int positive_sign; //Field offset: 0x58

	}

	private static CultureData s_Invariant; //Field offset: 0x0
	private string sAM1159; //Field offset: 0x10
	private string sPM2359; //Field offset: 0x18
	private string sTimeSeparator; //Field offset: 0x20
	private String[] saLongTimes; //Field offset: 0x28
	private String[] saShortTimes; //Field offset: 0x30
	private int iFirstDayOfWeek; //Field offset: 0x38
	private int iFirstWeekOfYear; //Field offset: 0x3C
	private Int32[] waCalendars; //Field offset: 0x40
	private CalendarData[] calendars; //Field offset: 0x48
	private string sISO639Language; //Field offset: 0x50
	private readonly string sRealName; //Field offset: 0x58
	private bool bUseOverrides; //Field offset: 0x60
	private int calendarId; //Field offset: 0x64
	private int numberIndex; //Field offset: 0x68
	private int iDefaultAnsiCodePage; //Field offset: 0x6C
	private int iDefaultOemCodePage; //Field offset: 0x70
	private int iDefaultMacCodePage; //Field offset: 0x74
	private int iDefaultEbcdicCodePage; //Field offset: 0x78
	private bool isRightToLeft; //Field offset: 0x7C
	private string sListSeparator; //Field offset: 0x80

	internal Int32[] CalendarIds
	{
		[CalledBy(Type = typeof(CultureData), Member = "GetCalendarIds", ReturnType = typeof(CalendarId[]))]
		[CallerCount(Count = 4)]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 6)]
		internal get { } //Length: 428
	}

	internal string CultureName
	{
		[CallerCount(Count = 10)]
		[DeduplicatedMethod]
		internal get { } //Length: 5
	}

	internal int IFIRSTDAYOFWEEK
	{
		[CallerCount(Count = 7)]
		[DeduplicatedMethod]
		internal get { } //Length: 4
	}

	internal int IFIRSTWEEKOFYEAR
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		internal get { } //Length: 4
	}

	public static CultureData Invariant
	{
		[CalledBy(Type = typeof(TextInfo), Member = "get_Invariant", ReturnType = typeof(TextInfo))]
		[CalledBy(Type = typeof(CultureData), Member = "GetCultureData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool), typeof(int), typeof(int), typeof(int), typeof(string), typeof(int), typeof(int), typeof(int), typeof(int), typeof(bool), typeof(string)}, ReturnType = typeof(CultureData))]
		[CalledBy(Type = typeof(CultureInfo), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(CultureInfo), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(CultureInfo), Member = ".cctor", ReturnType = typeof(void))]
		[CallerCount(Count = 5)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 25)]
		 get { } //Length: 1019
	}

	internal bool IsInvariantCulture
	{
		[CalledBy(Type = typeof(NumberFormatInfo), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CultureData)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TextInfo), Member = "ToUpperInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(char))]
		[CalledBy(Type = typeof(TextInfo), Member = "ToLowerInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(char))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
		internal get { } //Length: 11
	}

	internal String[] LongTimes
	{
		[CallerCount(Count = 8)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		internal get { } //Length: 24
	}

	internal string SAM1159
	{
		[CallerCount(Count = 106)]
		[DeduplicatedMethod]
		internal get { } //Length: 5
	}

	internal string SCOMPAREINFO
	{
		[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "get_CompareInfo", ReturnType = typeof(CompareInfo))]
		[CallerCount(Count = 1)]
		internal get { } //Length: 44
	}

	internal String[] ShortTimes
	{
		[CallerCount(Count = 6)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		internal get { } //Length: 24
	}

	internal string SISO639LANGNAME
	{
		[CallerCount(Count = 16)]
		[DeduplicatedMethod]
		internal get { } //Length: 5
	}

	internal string SPM2359
	{
		[CallerCount(Count = 31)]
		[DeduplicatedMethod]
		internal get { } //Length: 5
	}

	internal string STEXTINFO
	{
		[CallerCount(Count = 10)]
		[DeduplicatedMethod]
		internal get { } //Length: 5
	}

	internal string TimeSeparator
	{
		[CallerCount(Count = 12)]
		[DeduplicatedMethod]
		internal get { } //Length: 5
	}

	internal bool UseUserOverride
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		internal get { } //Length: 5
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private CultureData(string name) { }

	[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "get_AbbreviatedEraNames", ReturnType = typeof(String[]))]
	[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "GetAbbreviatedEraName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CultureData), Member = "GetCalendar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(CalendarData))]
	[CallsUnknownMethods(Count = 1)]
	internal String[] AbbrevEraNames(int calendarId) { }

	[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "internalGetAbbreviatedDayOfWeekNamesCore", ReturnType = typeof(String[]))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CultureData), Member = "GetCalendar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(CalendarData))]
	[CallsUnknownMethods(Count = 1)]
	internal String[] AbbreviatedDayNames(int calendarId) { }

	[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "get_AbbreviatedEnglishEraNames", ReturnType = typeof(String[]))]
	[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "CreateTokenHashTable", ReturnType = typeof(TokenHashValue[]))]
	[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "PopulateSpecialTokenHashTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TokenHashValue[]), typeof(Boolean&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CultureData), Member = "GetCalendar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(CalendarData))]
	[CallsUnknownMethods(Count = 1)]
	internal String[] AbbreviatedEnglishEraNames(int calendarId) { }

	[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "internalGetGenitiveMonthNames", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(String[]))]
	[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "InitializeFormatFlags", ReturnType = typeof(DateTimeFormatFlags))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CultureData), Member = "GetCalendar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(CalendarData))]
	[CallsUnknownMethods(Count = 1)]
	internal String[] AbbreviatedGenitiveMonthNames(int calendarId) { }

	[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "internalGetAbbreviatedMonthNamesCore", ReturnType = typeof(String[]))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CultureData), Member = "GetCalendar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(CalendarData))]
	[CallsUnknownMethods(Count = 1)]
	internal String[] AbbreviatedMonthNames(int calendarId) { }

	[CalledBy(Type = typeof(CultureData), Member = "GetNFIValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NumberFormatInfo)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	private Int32[] create_group_sizes_array(int gs0, int gs1) { }

	[CalledBy(Type = typeof(DateTimeFormatInfo), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "InitializeOverridableProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CultureData), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "set_Calendar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Calendar)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "get_DateSeparator", ReturnType = typeof(string))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CultureData), Member = "GetCalendar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(CalendarData))]
	[Calls(Type = typeof(CultureData), Member = "GetSeparator", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 2)]
	internal string DateSeparator(int calendarId) { }

	[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "internalGetDayOfWeekNamesCore", ReturnType = typeof(String[]))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CultureData), Member = "GetCalendar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(CalendarData))]
	[CallsUnknownMethods(Count = 1)]
	internal String[] DayNames(int calendarId) { }

	[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "get_EraNames", ReturnType = typeof(String[]))]
	[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "GetEraName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CultureData), Member = "GetCalendar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(CalendarData))]
	[CallsUnknownMethods(Count = 1)]
	internal String[] EraNames(int calendarId) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private void fill_culture_data(int datetimeIndex) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private static Byte* fill_number_data(int index, ref NumberFormatEntryManaged nfe) { }

	[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "internalGetGenitiveMonthNames", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(String[]))]
	[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "get_MonthGenitiveNames", ReturnType = typeof(String[]))]
	[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "InitializeFormatFlags", ReturnType = typeof(DateTimeFormatFlags))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CultureData), Member = "GetCalendar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(CalendarData))]
	[CallsUnknownMethods(Count = 1)]
	internal String[] GenitiveMonthNames(int calendarId) { }

	[CalledBy(Type = typeof(CultureData), Member = "GetCalendarIds", ReturnType = typeof(CalendarId[]))]
	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 6)]
	internal Int32[] get_CalendarIds() { }

	[CallerCount(Count = 10)]
	[DeduplicatedMethod]
	internal string get_CultureName() { }

	[CallerCount(Count = 7)]
	[DeduplicatedMethod]
	internal int get_IFIRSTDAYOFWEEK() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	internal int get_IFIRSTWEEKOFYEAR() { }

	[CalledBy(Type = typeof(TextInfo), Member = "get_Invariant", ReturnType = typeof(TextInfo))]
	[CalledBy(Type = typeof(CultureData), Member = "GetCultureData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool), typeof(int), typeof(int), typeof(int), typeof(string), typeof(int), typeof(int), typeof(int), typeof(int), typeof(bool), typeof(string)}, ReturnType = typeof(CultureData))]
	[CalledBy(Type = typeof(CultureInfo), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CultureInfo), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CultureInfo), Member = ".cctor", ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 25)]
	public static CultureData get_Invariant() { }

	[CalledBy(Type = typeof(NumberFormatInfo), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CultureData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextInfo), Member = "ToUpperInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(char))]
	[CalledBy(Type = typeof(TextInfo), Member = "ToLowerInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(char))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	internal bool get_IsInvariantCulture() { }

	[CallerCount(Count = 8)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	internal String[] get_LongTimes() { }

	[CallerCount(Count = 106)]
	[DeduplicatedMethod]
	internal string get_SAM1159() { }

	[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "get_CompareInfo", ReturnType = typeof(CompareInfo))]
	[CallerCount(Count = 1)]
	internal string get_SCOMPAREINFO() { }

	[CallerCount(Count = 6)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	internal String[] get_ShortTimes() { }

	[CallerCount(Count = 16)]
	[DeduplicatedMethod]
	internal string get_SISO639LANGNAME() { }

	[CallerCount(Count = 31)]
	[DeduplicatedMethod]
	internal string get_SPM2359() { }

	[CallerCount(Count = 10)]
	[DeduplicatedMethod]
	internal string get_STEXTINFO() { }

	[CallerCount(Count = 12)]
	[DeduplicatedMethod]
	internal string get_TimeSeparator() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	internal bool get_UseUserOverride() { }

	[CalledBy(Type = typeof(CalendarData), Member = "GetCalendarData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(CalendarData))]
	[CalledBy(Type = typeof(CultureData), Member = "DateSeparator", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(CultureData), Member = "MonthDay", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(CultureData), Member = "LeapYearMonthNames", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(String[]))]
	[CalledBy(Type = typeof(CultureData), Member = "AbbreviatedGenitiveMonthNames", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(String[]))]
	[CalledBy(Type = typeof(CultureData), Member = "AbbreviatedMonthNames", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(String[]))]
	[CalledBy(Type = typeof(CultureData), Member = "GenitiveMonthNames", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(String[]))]
	[CalledBy(Type = typeof(CultureData), Member = "AbbreviatedDayNames", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(String[]))]
	[CalledBy(Type = typeof(CultureData), Member = "MonthNames", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(String[]))]
	[CalledBy(Type = typeof(CultureData), Member = "YearMonths", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(String[]))]
	[CalledBy(Type = typeof(CultureData), Member = "LongDates", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(String[]))]
	[CalledBy(Type = typeof(CultureData), Member = "ShortDates", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(String[]))]
	[CalledBy(Type = typeof(CultureData), Member = "AbbreviatedEnglishEraNames", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(String[]))]
	[CalledBy(Type = typeof(CultureData), Member = "AbbrevEraNames", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(String[]))]
	[CalledBy(Type = typeof(CultureData), Member = "EraNames", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(String[]))]
	[CalledBy(Type = typeof(CultureData), Member = "DayNames", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(String[]))]
	[CallerCount(Count = 16)]
	[Calls(Type = typeof(CalendarData), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 7)]
	public CalendarData GetCalendar(int calendarId) { }

	[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "set_Calendar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Calendar)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "get_OptionalCalendars", ReturnType = typeof(CalendarId[]))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CultureData), Member = "get_CalendarIds", ReturnType = typeof(Int32[]))]
	[CallsUnknownMethods(Count = 2)]
	internal CalendarId[] GetCalendarIds() { }

	[CalledBy(Type = typeof(CultureInfo), Member = "GetCultures", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CultureTypes)}, ReturnType = typeof(CultureInfo[]))]
	[CalledBy(Type = typeof(CultureInfo), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CultureInfo), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CultureInfo), Member = "CreateSpecificCulture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(CultureInfo))]
	[CalledBy(Type = typeof(CultureInfo), Member = ".cctor", ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CultureData), Member = "get_Invariant", ReturnType = typeof(CultureData))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public static CultureData GetCultureData(string cultureName, bool useUserOverride, int datetimeIndex, int calendarId, int numberIndex, string iso2lang, int ansiCodePage, int oemCodePage, int macCodePage, int ebcdicCodePage, bool rightToLeft, string listSeparator) { }

	[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "get_FullTimeSpanPositivePattern", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "get_FullTimeSpanNegativePattern", ReturnType = typeof(string))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CultureInfo), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public static CultureData GetCultureData(string cultureName, bool useUserOverride) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CultureData), Member = "GetSeparator", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	private static string GetDateSeparator(string format) { }

	[CalledBy(Type = typeof(NumberFormatInfo), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CultureData)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CultureData), Member = "create_group_sizes_array", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(Int32[]))]
	[Calls(Type = typeof(Encoding), Member = "get_UTF8", ReturnType = typeof(Encoding))]
	[Calls(Type = typeof(Encoding), Member = "GetString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(NumberFormatInfo), Member = "set_NaNSymbol", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 18)]
	[ContainsUnimplementedInstructions]
	internal void GetNFIValues(NumberFormatInfo nfi) { }

	[CalledBy(Type = typeof(CultureData), Member = "DateSeparator", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(CultureData), Member = "GetDateSeparator", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(string), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsInvalidInstructions]
	[ContainsUnimplementedInstructions]
	private static string GetSeparator(string format, string timeParts) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Encoding), Member = "get_UTF8", ReturnType = typeof(Encoding))]
	[Calls(Type = typeof(Encoding), Member = "GetString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(int)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 1)]
	private static string idx2string(Byte* data, int idx) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(string), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private static int IndexOfTimePart(string format, int startIndex, string timeParts) { }

	[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "internalGetMonthName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(MonthNameStyles), typeof(bool)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "internalGetLeapYearMonthNames", ReturnType = typeof(String[]))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CultureData), Member = "GetCalendar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(CalendarData))]
	[CallsUnknownMethods(Count = 1)]
	internal String[] LeapYearMonthNames(int calendarId) { }

	[CalledBy(Type = typeof(DateTimeFormatInfo), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "InitializeOverridableProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CultureData), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "set_Calendar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Calendar)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "get_UnclonedLongDatePatterns", ReturnType = typeof(String[]))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CultureData), Member = "GetCalendar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(CalendarData))]
	[CallsUnknownMethods(Count = 1)]
	internal String[] LongDates(int calendarId) { }

	[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "get_MonthDayPattern", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "GetAllDateTimePatterns", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(String[]))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CultureData), Member = "GetCalendar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(CalendarData))]
	[CallsUnknownMethods(Count = 1)]
	internal string MonthDay(int calendarId) { }

	[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "internalGetMonthNamesCore", ReturnType = typeof(String[]))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CultureData), Member = "GetCalendar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(CalendarData))]
	[CallsUnknownMethods(Count = 1)]
	internal String[] MonthNames(int calendarId) { }

	[CallerCount(Count = 2063)]
	[DeduplicatedMethod]
	internal static string ReescapeWin32String(string str) { }

	[CallerCount(Count = 2063)]
	[DeduplicatedMethod]
	internal static String[] ReescapeWin32Strings(String[] array) { }

	[CalledBy(Type = typeof(DateTimeFormatInfo), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "InitializeOverridableProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CultureData), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "set_Calendar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Calendar)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "get_UnclonedShortDatePatterns", ReturnType = typeof(String[]))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CultureData), Member = "GetCalendar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(CalendarData))]
	[CallsUnknownMethods(Count = 1)]
	internal String[] ShortDates(int calendarId) { }

	[CallerCount(Count = 0)]
	private static int strlen(Byte* s) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private static string UnescapeNlsString(string str, int start, int end) { }

	[CalledBy(Type = typeof(DateTimeFormatInfo), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "InitializeOverridableProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CultureData), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "set_Calendar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Calendar)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "get_UnclonedYearMonthPatterns", ReturnType = typeof(String[]))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CultureData), Member = "GetCalendar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(CalendarData))]
	[CallsUnknownMethods(Count = 1)]
	internal String[] YearMonths(int calendarId) { }

}

