namespace System.Globalization;

internal class CalendarData
{
	internal const int MAX_CALENDARS = 23; //Field offset: 0x0
	internal static CalendarData Invariant; //Field offset: 0x0
	private static String[] HEBREW_MONTH_NAMES; //Field offset: 0x8
	private static String[] HEBREW_LEAP_MONTH_NAMES; //Field offset: 0x10
	internal string sNativeName; //Field offset: 0x10
	internal String[] saShortDates; //Field offset: 0x18
	internal String[] saYearMonths; //Field offset: 0x20
	internal String[] saLongDates; //Field offset: 0x28
	internal string sMonthDay; //Field offset: 0x30
	internal String[] saEraNames; //Field offset: 0x38
	internal String[] saAbbrevEraNames; //Field offset: 0x40
	internal String[] saAbbrevEnglishEraNames; //Field offset: 0x48
	internal String[] saDayNames; //Field offset: 0x50
	internal String[] saAbbrevDayNames; //Field offset: 0x58
	internal String[] saSuperShortDayNames; //Field offset: 0x60
	internal String[] saMonthNames; //Field offset: 0x68
	internal String[] saAbbrevMonthNames; //Field offset: 0x70
	internal String[] saMonthGenitiveNames; //Field offset: 0x78
	internal String[] saAbbrevMonthGenitiveNames; //Field offset: 0x80
	internal String[] saLeapYearMonthNames; //Field offset: 0x88
	internal int iTwoDigitYearMax; //Field offset: 0x90
	internal int iCurrentEra; //Field offset: 0x94
	internal bool bUseUserOverrides; //Field offset: 0x98

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 101)]
	private static CalendarData() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private CalendarData() { }

	[CalledBy(Type = typeof(CultureData), Member = "GetCalendar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(CalendarData))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "ToLowerInvariant", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CalendarData), Member = "InitializeEraNames", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CalendarData), Member = "InitializeAbbreviatedEraNames", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CalendarData), Member = "GetJapaneseEnglishEraNames", ReturnType = typeof(String[]))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 27)]
	internal CalendarData(string localeName, int calendarId, bool bUseUserOverrides) { }

	[CallerCount(Count = 0)]
	[ContainsInvalidInstructions]
	private static string CalendarIdToCultureName(int calendarId) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private bool fill_calendar_data(string localeName, int datetimeIndex) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CultureInfo), Member = "GetCultureInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(CultureData), Member = "GetCalendar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(CalendarData))]
	[CallsUnknownMethods(Count = 2)]
	internal static CalendarData GetCalendarData(int calendarId) { }

	[CalledBy(Type = typeof(CalendarData), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(JapaneseCalendar), Member = "GetEraInfo", ReturnType = typeof(EraInfo[]))]
	[Calls(Type = typeof(PlatformNotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 6)]
	private static String[] GetJapaneseEnglishEraNames() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JapaneseCalendar), Member = "GetEraInfo", ReturnType = typeof(EraInfo[]))]
	[Calls(Type = typeof(PlatformNotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 6)]
	private static String[] GetJapaneseEraNames() { }

	[CalledBy(Type = typeof(CalendarData), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(PlatformNotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 11)]
	private void InitializeAbbreviatedEraNames(string localeName, int calendarId) { }

	[CalledBy(Type = typeof(CalendarData), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[ContainsInvalidInstructions]
	private void InitializeEraNames(string localeName, int calendarId) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "ToLowerInvariant", ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 4)]
	private static bool nativeGetCalendarData(CalendarData data, string localeName, int calendarId) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public static int nativeGetTwoDigitYearMax(int calID) { }

}

