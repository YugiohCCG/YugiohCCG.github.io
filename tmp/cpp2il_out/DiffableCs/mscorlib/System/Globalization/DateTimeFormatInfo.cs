namespace System.Globalization;

public sealed class DateTimeFormatInfo : IFormatProvider, ICloneable
{
	public class TokenHashValue
	{
		internal string tokenString; //Field offset: 0x10
		internal TokenType tokenType; //Field offset: 0x18
		internal int tokenValue; //Field offset: 0x1C

		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		internal TokenHashValue(string tokenString, TokenType tokenType, int tokenValue) { }

	}

	private static DateTimeFormatInfo s_invariantInfo; //Field offset: 0x0
	internal const string KoreanYearSuff = "년"; //Field offset: 0x0
	internal const string CJKDaySuff = "日"; //Field offset: 0x0
	internal const string CJKMonthSuff = "月"; //Field offset: 0x0
	internal const string CJKYearSuff = "年"; //Field offset: 0x0
	internal const string IgnorableComma = ","; //Field offset: 0x0
	internal const string IgnorablePeriod = "."; //Field offset: 0x0
	internal const string KoreanMonthSuff = "월"; //Field offset: 0x0
	private const string invariantTimeSeparator = ":"; //Field offset: 0x0
	private const string dateSeparatorOrTimeZoneOffset = "-"; //Field offset: 0x0
	private const int SECOND_PRIME = 197; //Field offset: 0x0
	private const int TOKEN_HASH_SIZE = 199; //Field offset: 0x0
	internal const DateTimeStyles InvalidDateTimeStyles = -256; //Field offset: 0x0
	internal const string RoundtripDateTimeUnfixed = "yyyy'-'MM'-'ddTHH':'mm':'ss zzz"; //Field offset: 0x0
	internal const string RoundtripFormat = "yyyy'-'MM'-'dd'T'HH':'mm':'ss.fffffffK"; //Field offset: 0x0
	private const string invariantDateSeparator = "/"; //Field offset: 0x0
	private const int DEFAULT_ALL_DATETIMES_SIZE = 132; //Field offset: 0x0
	internal const string KoreanDaySuff = "일"; //Field offset: 0x0
	private const string universalSortableDateTimePattern = "yyyy'-'MM'-'dd HH':'mm':'ss'Z'"; //Field offset: 0x0
	internal const string EnglishLangName = "en"; //Field offset: 0x0
	internal const string JapaneseLangName = "ja"; //Field offset: 0x0
	internal const string KoreanLangName = "ko"; //Field offset: 0x0
	internal const string ZuluName = "Z"; //Field offset: 0x0
	internal const string GMTName = "GMT"; //Field offset: 0x0
	internal const string LocalTimeMark = "T"; //Field offset: 0x0
	internal const string KoreanHourSuff = "시"; //Field offset: 0x0
	internal const string JapaneseEraStart = "元"; //Field offset: 0x0
	internal const string CJKMinuteSuff = "分"; //Field offset: 0x0
	internal const string ChineseHourSuff = "时"; //Field offset: 0x0
	internal const string CJKHourSuff = "時"; //Field offset: 0x0
	internal const string KoreanSecondSuff = "초"; //Field offset: 0x0
	internal const string KoreanMinuteSuff = "분"; //Field offset: 0x0
	private const string rfc1123Pattern = "ddd, dd MMM yyyy HH':'mm':'ss 'GMT'"; //Field offset: 0x0
	private const string sortableDateTimePattern = "yyyy'-'MM'-'dd'T'HH':'mm':'ss"; //Field offset: 0x0
	internal const string CJKSecondSuff = "秒"; //Field offset: 0x0
	private static readonly Char[] s_monthSpaces; //Field offset: 0x8
	private static DateTimeFormatInfo s_jajpDTFI; //Field offset: 0x10
	private static DateTimeFormatInfo s_zhtwDTFI; //Field offset: 0x18
	private CultureData _cultureData; //Field offset: 0x10
	private string _name; //Field offset: 0x18
	private string _langName; //Field offset: 0x20
	private CompareInfo _compareInfo; //Field offset: 0x28
	private CultureInfo _cultureInfo; //Field offset: 0x30
	private string amDesignator; //Field offset: 0x38
	private string pmDesignator; //Field offset: 0x40
	private string dateSeparator; //Field offset: 0x48
	private string generalShortTimePattern; //Field offset: 0x50
	private string generalLongTimePattern; //Field offset: 0x58
	private string timeSeparator; //Field offset: 0x60
	private string monthDayPattern; //Field offset: 0x68
	private string dateTimeOffsetPattern; //Field offset: 0x70
	private Calendar calendar; //Field offset: 0x78
	private int firstDayOfWeek; //Field offset: 0x80
	private int calendarWeekRule; //Field offset: 0x84
	private string fullDateTimePattern; //Field offset: 0x88
	private String[] abbreviatedDayNames; //Field offset: 0x90
	private String[] m_superShortDayNames; //Field offset: 0x98
	private String[] dayNames; //Field offset: 0xA0
	private String[] abbreviatedMonthNames; //Field offset: 0xA8
	private String[] monthNames; //Field offset: 0xB0
	private String[] genitiveMonthNames; //Field offset: 0xB8
	private String[] m_genitiveAbbreviatedMonthNames; //Field offset: 0xC0
	private String[] leapYearMonthNames; //Field offset: 0xC8
	private string longDatePattern; //Field offset: 0xD0
	private string shortDatePattern; //Field offset: 0xD8
	private string yearMonthPattern; //Field offset: 0xE0
	private string longTimePattern; //Field offset: 0xE8
	private string shortTimePattern; //Field offset: 0xF0
	private String[] allYearMonthPatterns; //Field offset: 0xF8
	private String[] allShortDatePatterns; //Field offset: 0x100
	private String[] allLongDatePatterns; //Field offset: 0x108
	private String[] allShortTimePatterns; //Field offset: 0x110
	private String[] allLongTimePatterns; //Field offset: 0x118
	private String[] m_eraNames; //Field offset: 0x120
	private String[] m_abbrevEraNames; //Field offset: 0x128
	private String[] m_abbrevEnglishEraNames; //Field offset: 0x130
	private CalendarId[] optionalCalendars; //Field offset: 0x138
	internal bool _isReadOnly; //Field offset: 0x140
	private DateTimeFormatFlags formatFlags; //Field offset: 0x144
	private string _fullTimeSpanPositivePattern; //Field offset: 0x148
	private string _fullTimeSpanNegativePattern; //Field offset: 0x150
	private TokenHashValue[] _dtfiTokenHash; //Field offset: 0x158

	public String[] AbbreviatedDayNames
	{
		[CalledBy(Type = "UI.Dates.DatePicker", Member = "_UpdateDisplay", ReturnType = typeof(void))]
		[CalledBy(Type = "UI.Dates.DatePickerUtilities", Member = "GetAbbreviatedDayNames", ReturnType = "System.String[]")]
		[CalledBy(Type = typeof(DateTimeFormat), Member = ".cctor", ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(DateTimeFormatInfo), Member = "internalGetAbbreviatedDayOfWeekNamesCore", ReturnType = typeof(String[]))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 3)]
		 get { } //Length: 140
	}

	internal String[] AbbreviatedEnglishEraNames
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CultureData), Member = "AbbreviatedEnglishEraNames", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(String[]))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		internal get { } //Length: 115
	}

	internal String[] AbbreviatedEraNames
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CultureData), Member = "AbbrevEraNames", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(String[]))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		internal get { } //Length: 115
	}

	public String[] AbbreviatedMonthNames
	{
		[CalledBy(Type = typeof(DateTimeFormat), Member = ".cctor", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "InitializeFormatFlags", ReturnType = typeof(DateTimeFormatFlags))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(DateTimeFormatInfo), Member = "internalGetAbbreviatedMonthNamesCore", ReturnType = typeof(String[]))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 3)]
		 get { } //Length: 140
	}

	private String[] AllLongDatePatterns
	{
		[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "GetAllDateTimePatterns", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(String[]))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(DateTimeFormatInfo), Member = "get_UnclonedLongDatePatterns", ReturnType = typeof(String[]))]
		[Calls(Type = typeof(DateTimeFormatInfo), Member = "GetMergedPatterns", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[]), typeof(string)}, ReturnType = typeof(String[]))]
		[CallsUnknownMethods(Count = 3)]
		private get { } //Length: 171
	}

	private String[] AllLongTimePatterns
	{
		[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "GetAllDateTimePatterns", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(String[]))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(DateTimeFormatInfo), Member = "get_LongTimePattern", ReturnType = typeof(string))]
		[Calls(Type = typeof(DateTimeFormatInfo), Member = "GetMergedPatterns", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[]), typeof(string)}, ReturnType = typeof(String[]))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		private get { } //Length: 160
	}

	private String[] AllShortDatePatterns
	{
		[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "GetAllDateTimePatterns", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(String[]))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(DateTimeFormatInfo), Member = "get_UnclonedShortDatePatterns", ReturnType = typeof(String[]))]
		[Calls(Type = typeof(DateTimeFormatInfo), Member = "GetMergedPatterns", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[]), typeof(string)}, ReturnType = typeof(String[]))]
		[CallsUnknownMethods(Count = 3)]
		private get { } //Length: 171
	}

	private String[] AllShortTimePatterns
	{
		[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "GetAllDateTimePatterns", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(String[]))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(DateTimeFormatInfo), Member = "get_ShortTimePattern", ReturnType = typeof(string))]
		[Calls(Type = typeof(DateTimeFormatInfo), Member = "GetMergedPatterns", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[]), typeof(string)}, ReturnType = typeof(String[]))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		private get { } //Length: 160
	}

	private String[] AllYearMonthPatterns
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(DateTimeFormatInfo), Member = "get_UnclonedYearMonthPatterns", ReturnType = typeof(String[]))]
		[Calls(Type = typeof(DateTimeFormatInfo), Member = "GetMergedPatterns", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[]), typeof(string)}, ReturnType = typeof(String[]))]
		[CallsUnknownMethods(Count = 3)]
		private get { } //Length: 171
	}

	public string AMDesignator
	{
		[CalledBy(Type = typeof(DateTimeFormat), Member = "FormatCustomized", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(System.ReadOnlySpan`1<System.Char>), typeof(DateTimeFormatInfo), typeof(TimeSpan), typeof(StringBuilder)}, ReturnType = typeof(StringBuilder))]
		[CalledBy(Type = typeof(DateTimeParse), Member = "AdjustTimeMark", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeFormatInfo), typeof(DateTimeRawInfo&)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DateTimeParse), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(DateTimeFormatInfo), typeof(DateTimeStyles), typeof(DateTimeResult&)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(DateTimeParse), Member = "MatchTimeMark", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(__DTString&), typeof(DateTimeFormatInfo), typeof(TM&)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(DateTimeParse), Member = "MatchAbbreviatedTimeMark", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(__DTString&), typeof(DateTimeFormatInfo), typeof(TM&)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(DateTimeParse), Member = "ParseByFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(__DTString&), typeof(__DTString&), typeof(ParsingInfo&), typeof(DateTimeFormatInfo), typeof(DateTimeResult&)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 15)]
		[CallsUnknownMethods(Count = 2)]
		 get { } //Length: 57
	}

	public Calendar Calendar
	{
		[CallerCount(Count = 7)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CalledBy(Type = typeof(DateTimeFormat), Member = "ExpandPredefinedFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(DateTime&), typeof(DateTimeFormatInfo&), typeof(TimeSpan&)}, ReturnType = typeof(string))]
		[CalledBy(Type = typeof(DateTimeParse), Member = "ExpandPredefinedFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(DateTimeFormatInfo&), typeof(ParsingInfo&), typeof(DateTimeResult&)}, ReturnType = typeof(string))]
		[CalledBy(Type = typeof(DateTimeFormatInfo), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CultureData), typeof(Calendar)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "GetJapaneseCalendarDTFI", ReturnType = typeof(DateTimeFormatInfo))]
		[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "GetTaiwanCalendarDTFI", ReturnType = typeof(DateTimeFormatInfo))]
		[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "PopulateSpecialTokenHashTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TokenHashValue[]), typeof(Boolean&)}, ReturnType = typeof(void))]
		[CallerCount(Count = 7)]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(PlatformNotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CultureData), Member = "DateSeparator", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(CultureData), Member = "ShortDates", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(String[]))]
		[Calls(Type = typeof(CultureData), Member = "LongDates", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(String[]))]
		[Calls(Type = typeof(CultureData), Member = "GetCalendarIds", ReturnType = typeof(CalendarId[]))]
		[Calls(Type = typeof(CultureData), Member = "YearMonths", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(String[]))]
		[CallsDeduplicatedMethods(Count = 4)]
		[CallsUnknownMethods(Count = 54)]
		 set { } //Length: 1742
	}

	internal CompareInfo CompareInfo
	{
		[CalledBy(Type = typeof(__DTString), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(DateTimeFormatInfo), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(__DTString), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(DateTimeFormatInfo)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CultureData), Member = "get_SCOMPAREINFO", ReturnType = typeof(string))]
		[Calls(Type = typeof(CultureInfo), Member = "GetCultureInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(CultureInfo))]
		[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 6)]
		internal get { } //Length: 295
	}

	private CultureInfo Culture
	{
		[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "Tokenize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TokenType), typeof(TokenType&), typeof(Int32&), typeof(__DTString&)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "InsertAtCurrentHashNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TokenHashValue[]), typeof(string), typeof(char), typeof(TokenType), typeof(int), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "InsertHash", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TokenHashValue[]), typeof(string), typeof(TokenType), typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "CompareStringIgnoreCaseOptimized", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int), typeof(string), typeof(int), typeof(int)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 6)]
		[Calls(Type = typeof(CultureInfo), Member = "GetCultureInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(CultureInfo))]
		[CallsUnknownMethods(Count = 3)]
		private get { } //Length: 153
	}

	private string CultureName
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		private get { } //Length: 57
	}

	public static DateTimeFormatInfo CurrentInfo
	{
		[CalledBy(Type = "UI.Dates.DatePicker", Member = "_UpdateDisplay", ReturnType = typeof(void))]
		[CalledBy(Type = "UI.Dates.DatePicker", Member = "UpdateWeekNumbers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.List`1<DateTime>&"}, ReturnType = typeof(void))]
		[CalledBy(Type = "UI.Dates.DatePickerUtilities", Member = "GetAbbreviatedDayNames", ReturnType = "System.String[]")]
		[CalledBy(Type = "UI.Dates.DatePickerUtilities", Member = "GetDateRangeForDisplay", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime)}, ReturnType = "System.Collections.Generic.List`1<DateTime>")]
		[CalledBy(Type = typeof(DateTime), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(DateTime))]
		[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "GetInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(DateTimeFormatInfo))]
		[CallerCount(Count = 9)]
		[Calls(Type = typeof(CultureInfo), Member = "get_CurrentCulture", ReturnType = typeof(CultureInfo))]
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 3)]
		 get { } //Length: 254
	}

	public string DateSeparator
	{
		[CalledBy(Type = typeof(DateTimeFormat), Member = "FormatCustomized", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(System.ReadOnlySpan`1<System.Char>), typeof(DateTimeFormatInfo), typeof(TimeSpan), typeof(StringBuilder)}, ReturnType = typeof(StringBuilder))]
		[CalledBy(Type = typeof(DateTimeParse), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(DateTimeFormatInfo), typeof(DateTimeStyles), typeof(DateTimeResult&)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(DateTimeParse), Member = "ParseByFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(__DTString&), typeof(__DTString&), typeof(ParsingInfo&), typeof(DateTimeFormatInfo), typeof(DateTimeResult&)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "CreateTokenHashTable", ReturnType = typeof(TokenHashValue[]))]
		[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "PopulateSpecialTokenHashTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TokenHashValue[]), typeof(Boolean&)}, ReturnType = typeof(void))]
		[CallerCount(Count = 7)]
		[Calls(Type = typeof(CultureData), Member = "DateSeparator", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		 get { } //Length: 103
	}

	internal string DateTimeOffsetPattern
	{
		[CalledBy(Type = typeof(DateTimeFormat), Member = "FormatStringBuilder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(System.ReadOnlySpan`1<System.Char>), typeof(DateTimeFormatInfo), typeof(TimeSpan)}, ReturnType = typeof(StringBuilder))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(DateTimeFormatInfo), Member = "get_UnclonedShortDatePatterns", ReturnType = typeof(String[]))]
		[Calls(Type = typeof(DateTimeFormatInfo), Member = "get_LongTimePattern", ReturnType = typeof(string))]
		[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
		[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 6)]
		[ContainsUnimplementedInstructions]
		internal get { } //Length: 598
	}

	public String[] DayNames
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(DateTimeFormatInfo), Member = "internalGetDayOfWeekNamesCore", ReturnType = typeof(String[]))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 3)]
		 get { } //Length: 140
	}

	internal String[] EraNames
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CultureData), Member = "EraNames", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(String[]))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		internal get { } //Length: 115
	}

	public DayOfWeek FirstDayOfWeek
	{
		[CalledBy(Type = "UI.Dates.DatePicker", Member = "_UpdateDisplay", ReturnType = typeof(void))]
		[CalledBy(Type = "UI.Dates.DatePicker", Member = "UpdateWeekNumbers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.List`1<DateTime>&"}, ReturnType = typeof(void))]
		[CalledBy(Type = "UI.Dates.DatePickerUtilities", Member = "GetAbbreviatedDayNames", ReturnType = "System.String[]")]
		[CalledBy(Type = "UI.Dates.DatePickerUtilities", Member = "GetDateRangeForDisplay", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime)}, ReturnType = "System.Collections.Generic.List`1<DateTime>")]
		[CallerCount(Count = 5)]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 47
	}

	internal DateTimeFormatFlags FormatFlags
	{
		[CalledBy(Type = typeof(DateTimeFormat), Member = "FormatCustomized", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(System.ReadOnlySpan`1<System.Char>), typeof(DateTimeFormatInfo), typeof(TimeSpan), typeof(StringBuilder)}, ReturnType = typeof(StringBuilder))]
		[CalledBy(Type = typeof(DateTimeParse), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(DateTimeFormatInfo), typeof(DateTimeStyles), typeof(DateTimeResult&)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(DateTimeParse), Member = "MatchAbbreviatedMonthName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(__DTString&), typeof(DateTimeFormatInfo), typeof(Int32&)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(DateTimeParse), Member = "MatchMonthName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(__DTString&), typeof(DateTimeFormatInfo), typeof(Int32&)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(DateTimeParse), Member = "DoStrictParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(System.ReadOnlySpan`1<System.Char>), typeof(DateTimeStyles), typeof(DateTimeFormatInfo), typeof(DateTimeResult&)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(__DTString), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(DateTimeFormatInfo), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(__DTString), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(DateTimeFormatInfo)}, ReturnType = typeof(void))]
		[CallerCount(Count = 8)]
		[Calls(Type = typeof(DateTimeFormatInfo), Member = "InitializeFormatFlags", ReturnType = typeof(DateTimeFormatFlags))]
		internal get { } //Length: 23
	}

	public string FullDateTimePattern
	{
		[CalledBy(Type = typeof(DateTimeFormat), Member = "ExpandPredefinedFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(DateTime&), typeof(DateTimeFormatInfo&), typeof(TimeSpan&)}, ReturnType = typeof(string))]
		[CalledBy(Type = typeof(DateTimeParse), Member = "ExpandPredefinedFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(DateTimeFormatInfo&), typeof(ParsingInfo&), typeof(DateTimeResult&)}, ReturnType = typeof(string))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(DateTimeFormatInfo), Member = "get_UnclonedLongDatePatterns", ReturnType = typeof(String[]))]
		[Calls(Type = typeof(DateTimeFormatInfo), Member = "get_LongTimePattern", ReturnType = typeof(string))]
		[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
		[CallsUnknownMethods(Count = 4)]
		 get { } //Length: 195
	}

	internal string FullTimeSpanNegativePattern
	{
		[CalledBy(Type = typeof(TimeSpanFormat), Member = "FormatToBuilder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpan), typeof(System.ReadOnlySpan`1<System.Char>), typeof(IFormatProvider)}, ReturnType = typeof(StringBuilder))]
		[CalledBy(Type = "System.Globalization.TimeSpanParse+TimeSpanRawInfo", Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeFormatInfo)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TimeSpanParse), Member = "TryParseTimeSpan", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), "System.Globalization.TimeSpanParse+TimeSpanStandardStyles", typeof(IFormatProvider), typeof(TimeSpanResult&)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CultureData), Member = "GetCultureData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(CultureData))]
		[Calls(Type = typeof(NumberFormatInfo), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CultureData)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
		[CallsUnknownMethods(Count = 3)]
		internal get { } //Length: 320
	}

	internal string FullTimeSpanPositivePattern
	{
		[CalledBy(Type = typeof(TimeSpanFormat), Member = "FormatToBuilder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpan), typeof(System.ReadOnlySpan`1<System.Char>), typeof(IFormatProvider)}, ReturnType = typeof(StringBuilder))]
		[CalledBy(Type = "System.Globalization.TimeSpanParse+TimeSpanRawInfo", Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeFormatInfo)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TimeSpanParse), Member = "TryParseTimeSpan", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), "System.Globalization.TimeSpanParse+TimeSpanStandardStyles", typeof(IFormatProvider), typeof(TimeSpanResult&)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CultureData), Member = "GetCultureData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(CultureData))]
		[Calls(Type = typeof(NumberFormatInfo), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CultureData)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
		[CallsUnknownMethods(Count = 2)]
		internal get { } //Length: 234
	}

	internal string GeneralLongTimePattern
	{
		[CalledBy(Type = typeof(DateTimeFormat), Member = "ExpandPredefinedFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(DateTime&), typeof(DateTimeFormatInfo&), typeof(TimeSpan&)}, ReturnType = typeof(string))]
		[CalledBy(Type = typeof(DateTimeParse), Member = "ExpandPredefinedFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(DateTimeFormatInfo&), typeof(ParsingInfo&), typeof(DateTimeResult&)}, ReturnType = typeof(string))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(DateTimeFormatInfo), Member = "get_UnclonedShortDatePatterns", ReturnType = typeof(String[]))]
		[Calls(Type = typeof(DateTimeFormatInfo), Member = "get_LongTimePattern", ReturnType = typeof(string))]
		[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
		[CallsUnknownMethods(Count = 4)]
		internal get { } //Length: 183
	}

	internal string GeneralShortTimePattern
	{
		[CalledBy(Type = typeof(DateTimeFormat), Member = "ExpandPredefinedFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(DateTime&), typeof(DateTimeFormatInfo&), typeof(TimeSpan&)}, ReturnType = typeof(string))]
		[CalledBy(Type = typeof(DateTimeParse), Member = "ExpandPredefinedFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(DateTimeFormatInfo&), typeof(ParsingInfo&), typeof(DateTimeResult&)}, ReturnType = typeof(string))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(DateTimeFormatInfo), Member = "get_UnclonedShortDatePatterns", ReturnType = typeof(String[]))]
		[Calls(Type = typeof(DateTimeFormatInfo), Member = "get_ShortTimePattern", ReturnType = typeof(string))]
		[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
		[CallsUnknownMethods(Count = 4)]
		internal get { } //Length: 183
	}

	internal bool HasForceTwoDigitYears
	{
		[CalledBy(Type = typeof(DateTimeFormat), Member = "FormatCustomized", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(System.ReadOnlySpan`1<System.Char>), typeof(DateTimeFormatInfo), typeof(TimeSpan), typeof(StringBuilder)}, ReturnType = typeof(StringBuilder))]
		[CalledBy(Type = typeof(DateTimeParse), Member = "ParseByFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(__DTString&), typeof(__DTString&), typeof(ParsingInfo&), typeof(DateTimeFormatInfo), typeof(DateTimeResult&)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		internal get { } //Length: 51
	}

	internal bool HasSpacesInDayNames
	{
		[CalledBy(Type = typeof(DateTimeParse), Member = "MatchAbbreviatedDayName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(__DTString&), typeof(DateTimeFormatInfo), typeof(Int32&)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(DateTimeParse), Member = "MatchDayName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(__DTString&), typeof(DateTimeFormatInfo), typeof(Int32&)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(DateTimeParse), Member = "ParseByFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(__DTString&), typeof(__DTString&), typeof(ParsingInfo&), typeof(DateTimeFormatInfo), typeof(DateTimeResult&)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(DateTimeFormatInfo), Member = "InitializeFormatFlags", ReturnType = typeof(DateTimeFormatFlags))]
		[ContainsUnimplementedInstructions]
		internal get { } //Length: 46
	}

	internal bool HasSpacesInMonthNames
	{
		[CalledBy(Type = typeof(DateTimeParse), Member = "MatchAbbreviatedMonthName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(__DTString&), typeof(DateTimeFormatInfo), typeof(Int32&)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(DateTimeParse), Member = "MatchMonthName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(__DTString&), typeof(DateTimeFormatInfo), typeof(Int32&)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(DateTimeFormatInfo), Member = "InitializeFormatFlags", ReturnType = typeof(DateTimeFormatFlags))]
		[ContainsUnimplementedInstructions]
		internal get { } //Length: 46
	}

	internal bool HasYearMonthAdjustment
	{
		[CalledBy(Type = typeof(DateTimeParse), Member = "DoStrictParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(System.ReadOnlySpan`1<System.Char>), typeof(DateTimeStyles), typeof(DateTimeFormatInfo), typeof(DateTimeResult&)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(DateTimeFormatInfo), Member = "InitializeFormatFlags", ReturnType = typeof(DateTimeFormatFlags))]
		[ContainsUnimplementedInstructions]
		internal get { } //Length: 46
	}

	public static DateTimeFormatInfo InvariantInfo
	{
		[CalledBy(Type = typeof(DateTimeFormat), Member = "ExpandPredefinedFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(DateTime&), typeof(DateTimeFormatInfo&), typeof(TimeSpan&)}, ReturnType = typeof(string))]
		[CalledBy(Type = typeof(DateTimeFormat), Member = "FormatStringBuilder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(System.ReadOnlySpan`1<System.Char>), typeof(DateTimeFormatInfo), typeof(TimeSpan)}, ReturnType = typeof(StringBuilder))]
		[CalledBy(Type = typeof(DateTimeParse), Member = "ExpandPredefinedFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(DateTimeFormatInfo&), typeof(ParsingInfo&), typeof(DateTimeResult&)}, ReturnType = typeof(string))]
		[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "CreateTokenHashTable", ReturnType = typeof(TokenHashValue[]))]
		[CalledBy(Type = "System.Xml.XmlConvert", Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(string)}, ReturnType = typeof(string))]
		[CalledBy(Type = "System.Xml.XmlConvert", Member = "ToDateTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(DateTime))]
		[CalledBy(Type = "System.Xml.XmlConvert", Member = "ToDateTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "System.String[]"}, ReturnType = typeof(DateTime))]
		[CalledBy(Type = "System.Xml.Serialization.XmlCustomFormatter", Member = "FromXmlString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Xml.Serialization.TypeData", typeof(string)}, ReturnType = typeof(object))]
		[CallerCount(Count = 16)]
		[Calls(Type = typeof(DateTimeFormatInfo), Member = ".ctor", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 5)]
		 get { } //Length: 268
	}

	public bool IsReadOnly
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 141
	}

	private string LanguageName
	{
		[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "PopulateSpecialTokenHashTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TokenHashValue[]), typeof(Boolean&)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		private get { } //Length: 57
	}

	public string LongDatePattern
	{
		[CalledBy(Type = typeof(DateTimeFormat), Member = "ExpandPredefinedFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(DateTime&), typeof(DateTimeFormatInfo&), typeof(TimeSpan&)}, ReturnType = typeof(string))]
		[CalledBy(Type = typeof(DateTimeParse), Member = "ExpandPredefinedFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(DateTimeFormatInfo&), typeof(ParsingInfo&), typeof(DateTimeResult&)}, ReturnType = typeof(string))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(DateTimeFormatInfo), Member = "get_UnclonedLongDatePatterns", ReturnType = typeof(String[]))]
		[CallsUnknownMethods(Count = 3)]
		 get { } //Length: 84
	}

	public string LongTimePattern
	{
		[CalledBy(Type = typeof(DateTimeFormat), Member = "ExpandPredefinedFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(DateTime&), typeof(DateTimeFormatInfo&), typeof(TimeSpan&)}, ReturnType = typeof(string))]
		[CalledBy(Type = typeof(DateTimeParse), Member = "ExpandPredefinedFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(DateTimeFormatInfo&), typeof(ParsingInfo&), typeof(DateTimeResult&)}, ReturnType = typeof(string))]
		[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "get_FullDateTimePattern", ReturnType = typeof(string))]
		[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "get_GeneralLongTimePattern", ReturnType = typeof(string))]
		[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "get_DateTimeOffsetPattern", ReturnType = typeof(string))]
		[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "get_AllLongTimePatterns", ReturnType = typeof(String[]))]
		[CallerCount(Count = 7)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 4)]
		 get { } //Length: 132
	}

	public string MonthDayPattern
	{
		[CalledBy(Type = typeof(DateTimeFormat), Member = "ExpandPredefinedFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(DateTime&), typeof(DateTimeFormatInfo&), typeof(TimeSpan&)}, ReturnType = typeof(string))]
		[CalledBy(Type = typeof(DateTimeParse), Member = "GetDayOfNN", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeResult&), typeof(DateTimeStyles&), typeof(DateTimeRawInfo&), typeof(DateTimeFormatInfo)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(DateTimeParse), Member = "GetDayOfMN", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeResult&), typeof(DateTimeStyles&), typeof(DateTimeRawInfo&), typeof(DateTimeFormatInfo)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(DateTimeParse), Member = "GetHebrewDayOfNM", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeResult&), typeof(DateTimeRawInfo&), typeof(DateTimeFormatInfo)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(DateTimeParse), Member = "GetDayOfNM", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeResult&), typeof(DateTimeStyles&), typeof(DateTimeRawInfo&), typeof(DateTimeFormatInfo)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(DateTimeParse), Member = "ProcessTerminalState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DS), typeof(__DTString&), typeof(DateTimeResult&), typeof(DateTimeStyles&), typeof(DateTimeRawInfo&), typeof(DateTimeFormatInfo)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(DateTimeParse), Member = "ExpandPredefinedFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(DateTimeFormatInfo&), typeof(ParsingInfo&), typeof(DateTimeResult&)}, ReturnType = typeof(string))]
		[CalledBy(Type = typeof(DateTimeFormatInfoScanner), Member = "GetDateWordsOfDTFI", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeFormatInfo)}, ReturnType = typeof(String[]))]
		[CallerCount(Count = 13)]
		[Calls(Type = typeof(CultureData), Member = "MonthDay", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		 get { } //Length: 103
	}

	public String[] MonthGenitiveNames
	{
		[CalledBy(Type = typeof(DateTimeParse), Member = "MatchMonthName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(__DTString&), typeof(DateTimeFormatInfo), typeof(Int32&)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CultureData), Member = "GenitiveMonthNames", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(String[]))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 4)]
		 get { } //Length: 201
	}

	public String[] MonthNames
	{
		[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "InitializeFormatFlags", ReturnType = typeof(DateTimeFormatFlags))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(DateTimeFormatInfo), Member = "internalGetMonthNamesCore", ReturnType = typeof(String[]))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 3)]
		 get { } //Length: 140
	}

	private CalendarId[] OptionalCalendars
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CultureData), Member = "GetCalendarIds", ReturnType = typeof(CalendarId[]))]
		[CallsUnknownMethods(Count = 2)]
		private get { } //Length: 75
	}

	public string PMDesignator
	{
		[CalledBy(Type = typeof(DateTimeFormat), Member = "FormatCustomized", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(System.ReadOnlySpan`1<System.Char>), typeof(DateTimeFormatInfo), typeof(TimeSpan), typeof(StringBuilder)}, ReturnType = typeof(StringBuilder))]
		[CalledBy(Type = typeof(DateTimeParse), Member = "AdjustTimeMark", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeFormatInfo), typeof(DateTimeRawInfo&)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DateTimeParse), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(DateTimeFormatInfo), typeof(DateTimeStyles), typeof(DateTimeResult&)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(DateTimeParse), Member = "MatchTimeMark", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(__DTString&), typeof(DateTimeFormatInfo), typeof(TM&)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(DateTimeParse), Member = "MatchAbbreviatedTimeMark", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(__DTString&), typeof(DateTimeFormatInfo), typeof(TM&)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(DateTimeParse), Member = "ParseByFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(__DTString&), typeof(__DTString&), typeof(ParsingInfo&), typeof(DateTimeFormatInfo), typeof(DateTimeResult&)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 15)]
		[CallsUnknownMethods(Count = 2)]
		 get { } //Length: 57
	}

	public string RFC1123Pattern
	{
		[CalledBy(Type = typeof(DateTimeFormat), Member = "ExpandPredefinedFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(DateTime&), typeof(DateTimeFormatInfo&), typeof(TimeSpan&)}, ReturnType = typeof(string))]
		[CalledBy(Type = typeof(DateTimeParse), Member = "ExpandPredefinedFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(DateTimeFormatInfo&), typeof(ParsingInfo&), typeof(DateTimeResult&)}, ReturnType = typeof(string))]
		[CallerCount(Count = 2)]
		 get { } //Length: 44
	}

	public string ShortDatePattern
	{
		[CalledBy(Type = typeof(DateTimeFormat), Member = "ExpandPredefinedFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(DateTime&), typeof(DateTimeFormatInfo&), typeof(TimeSpan&)}, ReturnType = typeof(string))]
		[CalledBy(Type = typeof(DateTimeParse), Member = "GetDayOfNNN", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeResult&), typeof(DateTimeRawInfo&), typeof(DateTimeFormatInfo)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(DateTimeParse), Member = "GetDayOfMNN", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeResult&), typeof(DateTimeRawInfo&), typeof(DateTimeFormatInfo)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(DateTimeParse), Member = "GetDayOfYNN", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeResult&), typeof(DateTimeRawInfo&), typeof(DateTimeFormatInfo)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(DateTimeParse), Member = "GetDayOfNNY", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeResult&), typeof(DateTimeRawInfo&), typeof(DateTimeFormatInfo)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(DateTimeParse), Member = "GetDateOfNNDS", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeResult&), typeof(DateTimeRawInfo&), typeof(DateTimeFormatInfo)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(DateTimeParse), Member = "ProcessTerminalState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DS), typeof(__DTString&), typeof(DateTimeResult&), typeof(DateTimeStyles&), typeof(DateTimeRawInfo&), typeof(DateTimeFormatInfo)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(DateTimeParse), Member = "ExpandPredefinedFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(DateTimeFormatInfo&), typeof(ParsingInfo&), typeof(DateTimeResult&)}, ReturnType = typeof(string))]
		[CalledBy(Type = "System.ComponentModel.DateTimeConverter", Member = "ConvertTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.ComponentModel.ITypeDescriptorContext", typeof(CultureInfo), typeof(object), typeof(Type)}, ReturnType = typeof(object))]
		[CalledBy(Type = "System.ComponentModel.DateTimeOffsetConverter", Member = "ConvertTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.ComponentModel.ITypeDescriptorContext", typeof(CultureInfo), typeof(object), typeof(Type)}, ReturnType = typeof(object))]
		[CallerCount(Count = 16)]
		[Calls(Type = typeof(DateTimeFormatInfo), Member = "get_UnclonedShortDatePatterns", ReturnType = typeof(String[]))]
		[CallsUnknownMethods(Count = 3)]
		 get { } //Length: 84
	}

	public string ShortTimePattern
	{
		[CalledBy(Type = typeof(DateTimeFormat), Member = "ExpandPredefinedFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(DateTime&), typeof(DateTimeFormatInfo&), typeof(TimeSpan&)}, ReturnType = typeof(string))]
		[CalledBy(Type = typeof(DateTimeParse), Member = "ExpandPredefinedFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(DateTimeFormatInfo&), typeof(ParsingInfo&), typeof(DateTimeResult&)}, ReturnType = typeof(string))]
		[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "get_GeneralShortTimePattern", ReturnType = typeof(string))]
		[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "get_AllShortTimePatterns", ReturnType = typeof(String[]))]
		[CalledBy(Type = "System.ComponentModel.DateTimeConverter", Member = "ConvertTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.ComponentModel.ITypeDescriptorContext", typeof(CultureInfo), typeof(object), typeof(Type)}, ReturnType = typeof(object))]
		[CalledBy(Type = "System.ComponentModel.DateTimeOffsetConverter", Member = "ConvertTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.ComponentModel.ITypeDescriptorContext", typeof(CultureInfo), typeof(object), typeof(Type)}, ReturnType = typeof(object))]
		[CallerCount(Count = 8)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 4)]
		 get { } //Length: 132
	}

	public string SortableDateTimePattern
	{
		[CalledBy(Type = typeof(DateTimeFormat), Member = "ExpandPredefinedFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(DateTime&), typeof(DateTimeFormatInfo&), typeof(TimeSpan&)}, ReturnType = typeof(string))]
		[CalledBy(Type = typeof(DateTimeParse), Member = "ExpandPredefinedFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(DateTimeFormatInfo&), typeof(ParsingInfo&), typeof(DateTimeResult&)}, ReturnType = typeof(string))]
		[CallerCount(Count = 2)]
		 get { } //Length: 44
	}

	public string TimeSeparator
	{
		[CalledBy(Type = typeof(DateTimeFormat), Member = "FormatCustomized", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(System.ReadOnlySpan`1<System.Char>), typeof(DateTimeFormatInfo), typeof(TimeSpan), typeof(StringBuilder)}, ReturnType = typeof(StringBuilder))]
		[CalledBy(Type = typeof(DateTimeParse), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(DateTimeFormatInfo), typeof(DateTimeStyles), typeof(DateTimeResult&)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(DateTimeParse), Member = "ParseByFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(__DTString&), typeof(__DTString&), typeof(ParsingInfo&), typeof(DateTimeFormatInfo), typeof(DateTimeResult&)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "CreateTokenHashTable", ReturnType = typeof(TokenHashValue[]))]
		[CallerCount(Count = 6)]
		[CallsUnknownMethods(Count = 2)]
		 get { } //Length: 57
	}

	private String[] UnclonedLongDatePatterns
	{
		[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "get_FullDateTimePattern", ReturnType = typeof(string))]
		[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "get_LongDatePattern", ReturnType = typeof(string))]
		[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "get_AllLongDatePatterns", ReturnType = typeof(String[]))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(CultureData), Member = "LongDates", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(String[]))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		private get { } //Length: 115
	}

	private String[] UnclonedLongTimePatterns
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		private get { } //Length: 75
	}

	private String[] UnclonedShortDatePatterns
	{
		[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "get_ShortDatePattern", ReturnType = typeof(string))]
		[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "get_GeneralShortTimePattern", ReturnType = typeof(string))]
		[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "get_GeneralLongTimePattern", ReturnType = typeof(string))]
		[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "get_DateTimeOffsetPattern", ReturnType = typeof(string))]
		[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "get_AllShortDatePatterns", ReturnType = typeof(String[]))]
		[CallerCount(Count = 6)]
		[Calls(Type = typeof(CultureData), Member = "ShortDates", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(String[]))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		private get { } //Length: 115
	}

	private String[] UnclonedShortTimePatterns
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		private get { } //Length: 75
	}

	private String[] UnclonedYearMonthPatterns
	{
		[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "get_YearMonthPattern", ReturnType = typeof(string))]
		[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "GetAllDateTimePatterns", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(String[]))]
		[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "get_AllYearMonthPatterns", ReturnType = typeof(String[]))]
		[CallerCount(Count = 5)]
		[Calls(Type = typeof(CultureData), Member = "YearMonths", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(String[]))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		private get { } //Length: 115
	}

	public string UniversalSortableDateTimePattern
	{
		[CalledBy(Type = typeof(DateTimeFormat), Member = "ExpandPredefinedFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(DateTime&), typeof(DateTimeFormatInfo&), typeof(TimeSpan&)}, ReturnType = typeof(string))]
		[CalledBy(Type = typeof(DateTimeParse), Member = "ExpandPredefinedFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(DateTimeFormatInfo&), typeof(ParsingInfo&), typeof(DateTimeResult&)}, ReturnType = typeof(string))]
		[CallerCount(Count = 2)]
		 get { } //Length: 44
	}

	public string YearMonthPattern
	{
		[CalledBy(Type = typeof(DateTimeFormat), Member = "ExpandPredefinedFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(DateTime&), typeof(DateTimeFormatInfo&), typeof(TimeSpan&)}, ReturnType = typeof(string))]
		[CalledBy(Type = typeof(DateTimeParse), Member = "GetDayOfMN", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeResult&), typeof(DateTimeStyles&), typeof(DateTimeRawInfo&), typeof(DateTimeFormatInfo)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(DateTimeParse), Member = "GetDayOfNM", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeResult&), typeof(DateTimeStyles&), typeof(DateTimeRawInfo&), typeof(DateTimeFormatInfo)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(DateTimeParse), Member = "ExpandPredefinedFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(DateTimeFormatInfo&), typeof(ParsingInfo&), typeof(DateTimeResult&)}, ReturnType = typeof(string))]
		[CallerCount(Count = 6)]
		[Calls(Type = typeof(DateTimeFormatInfo), Member = "get_UnclonedYearMonthPatterns", ReturnType = typeof(String[]))]
		[CallsUnknownMethods(Count = 3)]
		 get { } //Length: 84
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 3)]
	private static DateTimeFormatInfo() { }

	[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "get_InvariantInfo", ReturnType = typeof(DateTimeFormatInfo))]
	[CalledBy(Type = typeof(CultureInfo), Member = "get_DateTimeFormat", ReturnType = typeof(DateTimeFormatInfo))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(GregorianCalendar), Member = "GetDefaultInstance", ReturnType = typeof(Calendar))]
	[Calls(Type = typeof(CultureData), Member = "DateSeparator", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CultureData), Member = "LongDates", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(String[]))]
	[Calls(Type = typeof(CultureData), Member = "ShortDates", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(String[]))]
	[Calls(Type = typeof(CultureData), Member = "YearMonths", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(String[]))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 12)]
	public DateTimeFormatInfo() { }

	[CalledBy(Type = typeof(CultureInfo), Member = "get_DateTimeFormat", ReturnType = typeof(DateTimeFormatInfo))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DateTimeFormatInfo), Member = "set_Calendar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Calendar)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	internal DateTimeFormatInfo(CultureData cultureData, Calendar cal) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DateTimeFormatInfo), Member = "GetMonthName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(DateTimeFormatInfo), Member = "InsertHash", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TokenHashValue[]), typeof(string), typeof(TokenType), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DateTimeFormatInfo), Member = "GetAbbreviatedMonthName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 1)]
	private void AddMonthNames(TokenHashValue[] temp, string monthPostfix) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private void ClearTokenHashTable() { }

	[CalledBy(Type = typeof(DateTimeFormat), Member = "ExpandPredefinedFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(DateTime&), typeof(DateTimeFormatInfo&), typeof(TimeSpan&)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(DateTimeParse), Member = "ExpandPredefinedFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(DateTimeFormatInfo&), typeof(ParsingInfo&), typeof(DateTimeResult&)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(CultureInfo), Member = "Clone", ReturnType = typeof(object))]
	[CalledBy(Type = "System.Security.Cryptography.DerSequenceReader+<>c", Member = "<ReadTime>b__51_0", ReturnType = typeof(DateTimeFormatInfo))]
	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	public override object Clone() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(DateTimeFormatInfo), Member = "get_Culture", ReturnType = typeof(CultureInfo))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private bool CompareStringIgnoreCaseOptimized(string string1, int offset1, int length1, string string2, int offset2, int length2) { }

	[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "Tokenize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TokenType), typeof(TokenType&), typeof(Int32&), typeof(__DTString&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CultureData), Member = "AbbreviatedEnglishEraNames", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(String[]))]
	[Calls(Type = typeof(DateTimeFormatInfo), Member = "get_InvariantInfo", ReturnType = typeof(DateTimeFormatInfo))]
	[Calls(Type = typeof(DateTimeFormatInfo), Member = "GetAbbreviatedEraName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(DateTimeFormatInfo), Member = "GetEraName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(DateTimeFormatInfo), Member = "GetAbbreviatedDayName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DayOfWeek)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(DateTimeFormatInfo), Member = "GetDayName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DayOfWeek)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(DateTimeFormatInfo), Member = "internalGetMonthName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(MonthNameStyles), typeof(bool)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(DateTimeFormatInfo), Member = "InitializeFormatFlags", ReturnType = typeof(DateTimeFormatFlags))]
	[Calls(Type = typeof(DateTimeFormatInfo), Member = "GetAbbreviatedMonthName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(DateTimeFormatInfo), Member = "GetMonthName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(DateTimeFormatInfo), Member = "get_DateSeparator", ReturnType = typeof(string))]
	[Calls(Type = typeof(DateTimeFormatInfo), Member = "PopulateSpecialTokenHashTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TokenHashValue[]), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DateTimeFormatInfo), Member = "get_TimeSeparator", ReturnType = typeof(string))]
	[Calls(Type = typeof(DateTimeFormatInfo), Member = "InsertHash", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TokenHashValue[]), typeof(string), typeof(TokenType), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "Trim", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 11)]
	internal TokenHashValue[] CreateTokenHashTable() { }

	[CalledBy(Type = "UI.Dates.DatePicker", Member = "_UpdateDisplay", ReturnType = typeof(void))]
	[CalledBy(Type = "UI.Dates.DatePickerUtilities", Member = "GetAbbreviatedDayNames", ReturnType = "System.String[]")]
	[CalledBy(Type = typeof(DateTimeFormat), Member = ".cctor", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(DateTimeFormatInfo), Member = "internalGetAbbreviatedDayOfWeekNamesCore", ReturnType = typeof(String[]))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public String[] get_AbbreviatedDayNames() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CultureData), Member = "AbbreviatedEnglishEraNames", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(String[]))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	internal String[] get_AbbreviatedEnglishEraNames() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CultureData), Member = "AbbrevEraNames", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(String[]))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	internal String[] get_AbbreviatedEraNames() { }

	[CalledBy(Type = typeof(DateTimeFormat), Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "InitializeFormatFlags", ReturnType = typeof(DateTimeFormatFlags))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(DateTimeFormatInfo), Member = "internalGetAbbreviatedMonthNamesCore", ReturnType = typeof(String[]))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public String[] get_AbbreviatedMonthNames() { }

	[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "GetAllDateTimePatterns", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(String[]))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(DateTimeFormatInfo), Member = "get_UnclonedLongDatePatterns", ReturnType = typeof(String[]))]
	[Calls(Type = typeof(DateTimeFormatInfo), Member = "GetMergedPatterns", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[]), typeof(string)}, ReturnType = typeof(String[]))]
	[CallsUnknownMethods(Count = 3)]
	private String[] get_AllLongDatePatterns() { }

	[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "GetAllDateTimePatterns", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(String[]))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(DateTimeFormatInfo), Member = "get_LongTimePattern", ReturnType = typeof(string))]
	[Calls(Type = typeof(DateTimeFormatInfo), Member = "GetMergedPatterns", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[]), typeof(string)}, ReturnType = typeof(String[]))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private String[] get_AllLongTimePatterns() { }

	[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "GetAllDateTimePatterns", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(String[]))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(DateTimeFormatInfo), Member = "get_UnclonedShortDatePatterns", ReturnType = typeof(String[]))]
	[Calls(Type = typeof(DateTimeFormatInfo), Member = "GetMergedPatterns", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[]), typeof(string)}, ReturnType = typeof(String[]))]
	[CallsUnknownMethods(Count = 3)]
	private String[] get_AllShortDatePatterns() { }

	[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "GetAllDateTimePatterns", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(String[]))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(DateTimeFormatInfo), Member = "get_ShortTimePattern", ReturnType = typeof(string))]
	[Calls(Type = typeof(DateTimeFormatInfo), Member = "GetMergedPatterns", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[]), typeof(string)}, ReturnType = typeof(String[]))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private String[] get_AllShortTimePatterns() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DateTimeFormatInfo), Member = "get_UnclonedYearMonthPatterns", ReturnType = typeof(String[]))]
	[Calls(Type = typeof(DateTimeFormatInfo), Member = "GetMergedPatterns", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[]), typeof(string)}, ReturnType = typeof(String[]))]
	[CallsUnknownMethods(Count = 3)]
	private String[] get_AllYearMonthPatterns() { }

	[CalledBy(Type = typeof(DateTimeFormat), Member = "FormatCustomized", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(System.ReadOnlySpan`1<System.Char>), typeof(DateTimeFormatInfo), typeof(TimeSpan), typeof(StringBuilder)}, ReturnType = typeof(StringBuilder))]
	[CalledBy(Type = typeof(DateTimeParse), Member = "AdjustTimeMark", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeFormatInfo), typeof(DateTimeRawInfo&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DateTimeParse), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(DateTimeFormatInfo), typeof(DateTimeStyles), typeof(DateTimeResult&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DateTimeParse), Member = "MatchTimeMark", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(__DTString&), typeof(DateTimeFormatInfo), typeof(TM&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DateTimeParse), Member = "MatchAbbreviatedTimeMark", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(__DTString&), typeof(DateTimeFormatInfo), typeof(TM&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DateTimeParse), Member = "ParseByFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(__DTString&), typeof(__DTString&), typeof(ParsingInfo&), typeof(DateTimeFormatInfo), typeof(DateTimeResult&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 15)]
	[CallsUnknownMethods(Count = 2)]
	public string get_AMDesignator() { }

	[CallerCount(Count = 7)]
	[DeduplicatedMethod]
	public Calendar get_Calendar() { }

	[CalledBy(Type = typeof(__DTString), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(DateTimeFormatInfo), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(__DTString), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(DateTimeFormatInfo)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CultureData), Member = "get_SCOMPAREINFO", ReturnType = typeof(string))]
	[Calls(Type = typeof(CultureInfo), Member = "GetCultureInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	internal CompareInfo get_CompareInfo() { }

	[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "Tokenize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TokenType), typeof(TokenType&), typeof(Int32&), typeof(__DTString&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "InsertAtCurrentHashNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TokenHashValue[]), typeof(string), typeof(char), typeof(TokenType), typeof(int), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "InsertHash", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TokenHashValue[]), typeof(string), typeof(TokenType), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "CompareStringIgnoreCaseOptimized", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int), typeof(string), typeof(int), typeof(int)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CultureInfo), Member = "GetCultureInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(CultureInfo))]
	[CallsUnknownMethods(Count = 3)]
	private CultureInfo get_Culture() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private string get_CultureName() { }

	[CalledBy(Type = "UI.Dates.DatePicker", Member = "_UpdateDisplay", ReturnType = typeof(void))]
	[CalledBy(Type = "UI.Dates.DatePicker", Member = "UpdateWeekNumbers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.List`1<DateTime>&"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UI.Dates.DatePickerUtilities", Member = "GetAbbreviatedDayNames", ReturnType = "System.String[]")]
	[CalledBy(Type = "UI.Dates.DatePickerUtilities", Member = "GetDateRangeForDisplay", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime)}, ReturnType = "System.Collections.Generic.List`1<DateTime>")]
	[CalledBy(Type = typeof(DateTime), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(DateTime))]
	[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "GetInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(DateTimeFormatInfo))]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(CultureInfo), Member = "get_CurrentCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public static DateTimeFormatInfo get_CurrentInfo() { }

	[CalledBy(Type = typeof(DateTimeFormat), Member = "FormatCustomized", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(System.ReadOnlySpan`1<System.Char>), typeof(DateTimeFormatInfo), typeof(TimeSpan), typeof(StringBuilder)}, ReturnType = typeof(StringBuilder))]
	[CalledBy(Type = typeof(DateTimeParse), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(DateTimeFormatInfo), typeof(DateTimeStyles), typeof(DateTimeResult&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DateTimeParse), Member = "ParseByFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(__DTString&), typeof(__DTString&), typeof(ParsingInfo&), typeof(DateTimeFormatInfo), typeof(DateTimeResult&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "CreateTokenHashTable", ReturnType = typeof(TokenHashValue[]))]
	[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "PopulateSpecialTokenHashTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TokenHashValue[]), typeof(Boolean&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(CultureData), Member = "DateSeparator", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public string get_DateSeparator() { }

	[CalledBy(Type = typeof(DateTimeFormat), Member = "FormatStringBuilder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(System.ReadOnlySpan`1<System.Char>), typeof(DateTimeFormatInfo), typeof(TimeSpan)}, ReturnType = typeof(StringBuilder))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DateTimeFormatInfo), Member = "get_UnclonedShortDatePatterns", ReturnType = typeof(String[]))]
	[Calls(Type = typeof(DateTimeFormatInfo), Member = "get_LongTimePattern", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	[ContainsUnimplementedInstructions]
	internal string get_DateTimeOffsetPattern() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DateTimeFormatInfo), Member = "internalGetDayOfWeekNamesCore", ReturnType = typeof(String[]))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public String[] get_DayNames() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CultureData), Member = "EraNames", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(String[]))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	internal String[] get_EraNames() { }

	[CalledBy(Type = "UI.Dates.DatePicker", Member = "_UpdateDisplay", ReturnType = typeof(void))]
	[CalledBy(Type = "UI.Dates.DatePicker", Member = "UpdateWeekNumbers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.List`1<DateTime>&"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UI.Dates.DatePickerUtilities", Member = "GetAbbreviatedDayNames", ReturnType = "System.String[]")]
	[CalledBy(Type = "UI.Dates.DatePickerUtilities", Member = "GetDateRangeForDisplay", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime)}, ReturnType = "System.Collections.Generic.List`1<DateTime>")]
	[CallerCount(Count = 5)]
	[CallsUnknownMethods(Count = 1)]
	public DayOfWeek get_FirstDayOfWeek() { }

	[CalledBy(Type = typeof(DateTimeFormat), Member = "FormatCustomized", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(System.ReadOnlySpan`1<System.Char>), typeof(DateTimeFormatInfo), typeof(TimeSpan), typeof(StringBuilder)}, ReturnType = typeof(StringBuilder))]
	[CalledBy(Type = typeof(DateTimeParse), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(DateTimeFormatInfo), typeof(DateTimeStyles), typeof(DateTimeResult&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DateTimeParse), Member = "MatchAbbreviatedMonthName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(__DTString&), typeof(DateTimeFormatInfo), typeof(Int32&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DateTimeParse), Member = "MatchMonthName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(__DTString&), typeof(DateTimeFormatInfo), typeof(Int32&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DateTimeParse), Member = "DoStrictParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(System.ReadOnlySpan`1<System.Char>), typeof(DateTimeStyles), typeof(DateTimeFormatInfo), typeof(DateTimeResult&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(__DTString), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(DateTimeFormatInfo), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(__DTString), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(DateTimeFormatInfo)}, ReturnType = typeof(void))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(DateTimeFormatInfo), Member = "InitializeFormatFlags", ReturnType = typeof(DateTimeFormatFlags))]
	internal DateTimeFormatFlags get_FormatFlags() { }

	[CalledBy(Type = typeof(DateTimeFormat), Member = "ExpandPredefinedFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(DateTime&), typeof(DateTimeFormatInfo&), typeof(TimeSpan&)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(DateTimeParse), Member = "ExpandPredefinedFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(DateTimeFormatInfo&), typeof(ParsingInfo&), typeof(DateTimeResult&)}, ReturnType = typeof(string))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(DateTimeFormatInfo), Member = "get_UnclonedLongDatePatterns", ReturnType = typeof(String[]))]
	[Calls(Type = typeof(DateTimeFormatInfo), Member = "get_LongTimePattern", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 4)]
	public string get_FullDateTimePattern() { }

	[CalledBy(Type = typeof(TimeSpanFormat), Member = "FormatToBuilder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpan), typeof(System.ReadOnlySpan`1<System.Char>), typeof(IFormatProvider)}, ReturnType = typeof(StringBuilder))]
	[CalledBy(Type = "System.Globalization.TimeSpanParse+TimeSpanRawInfo", Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeFormatInfo)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TimeSpanParse), Member = "TryParseTimeSpan", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), "System.Globalization.TimeSpanParse+TimeSpanStandardStyles", typeof(IFormatProvider), typeof(TimeSpanResult&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CultureData), Member = "GetCultureData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(CultureData))]
	[Calls(Type = typeof(NumberFormatInfo), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CultureData)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 3)]
	internal string get_FullTimeSpanNegativePattern() { }

	[CalledBy(Type = typeof(TimeSpanFormat), Member = "FormatToBuilder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpan), typeof(System.ReadOnlySpan`1<System.Char>), typeof(IFormatProvider)}, ReturnType = typeof(StringBuilder))]
	[CalledBy(Type = "System.Globalization.TimeSpanParse+TimeSpanRawInfo", Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeFormatInfo)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TimeSpanParse), Member = "TryParseTimeSpan", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), "System.Globalization.TimeSpanParse+TimeSpanStandardStyles", typeof(IFormatProvider), typeof(TimeSpanResult&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CultureData), Member = "GetCultureData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(CultureData))]
	[Calls(Type = typeof(NumberFormatInfo), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CultureData)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 2)]
	internal string get_FullTimeSpanPositivePattern() { }

	[CalledBy(Type = typeof(DateTimeFormat), Member = "ExpandPredefinedFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(DateTime&), typeof(DateTimeFormatInfo&), typeof(TimeSpan&)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(DateTimeParse), Member = "ExpandPredefinedFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(DateTimeFormatInfo&), typeof(ParsingInfo&), typeof(DateTimeResult&)}, ReturnType = typeof(string))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(DateTimeFormatInfo), Member = "get_UnclonedShortDatePatterns", ReturnType = typeof(String[]))]
	[Calls(Type = typeof(DateTimeFormatInfo), Member = "get_LongTimePattern", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 4)]
	internal string get_GeneralLongTimePattern() { }

	[CalledBy(Type = typeof(DateTimeFormat), Member = "ExpandPredefinedFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(DateTime&), typeof(DateTimeFormatInfo&), typeof(TimeSpan&)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(DateTimeParse), Member = "ExpandPredefinedFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(DateTimeFormatInfo&), typeof(ParsingInfo&), typeof(DateTimeResult&)}, ReturnType = typeof(string))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(DateTimeFormatInfo), Member = "get_UnclonedShortDatePatterns", ReturnType = typeof(String[]))]
	[Calls(Type = typeof(DateTimeFormatInfo), Member = "get_ShortTimePattern", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 4)]
	internal string get_GeneralShortTimePattern() { }

	[CalledBy(Type = typeof(DateTimeFormat), Member = "FormatCustomized", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(System.ReadOnlySpan`1<System.Char>), typeof(DateTimeFormatInfo), typeof(TimeSpan), typeof(StringBuilder)}, ReturnType = typeof(StringBuilder))]
	[CalledBy(Type = typeof(DateTimeParse), Member = "ParseByFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(__DTString&), typeof(__DTString&), typeof(ParsingInfo&), typeof(DateTimeFormatInfo), typeof(DateTimeResult&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	internal bool get_HasForceTwoDigitYears() { }

	[CalledBy(Type = typeof(DateTimeParse), Member = "MatchAbbreviatedDayName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(__DTString&), typeof(DateTimeFormatInfo), typeof(Int32&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DateTimeParse), Member = "MatchDayName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(__DTString&), typeof(DateTimeFormatInfo), typeof(Int32&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DateTimeParse), Member = "ParseByFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(__DTString&), typeof(__DTString&), typeof(ParsingInfo&), typeof(DateTimeFormatInfo), typeof(DateTimeResult&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(DateTimeFormatInfo), Member = "InitializeFormatFlags", ReturnType = typeof(DateTimeFormatFlags))]
	[ContainsUnimplementedInstructions]
	internal bool get_HasSpacesInDayNames() { }

	[CalledBy(Type = typeof(DateTimeParse), Member = "MatchAbbreviatedMonthName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(__DTString&), typeof(DateTimeFormatInfo), typeof(Int32&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DateTimeParse), Member = "MatchMonthName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(__DTString&), typeof(DateTimeFormatInfo), typeof(Int32&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(DateTimeFormatInfo), Member = "InitializeFormatFlags", ReturnType = typeof(DateTimeFormatFlags))]
	[ContainsUnimplementedInstructions]
	internal bool get_HasSpacesInMonthNames() { }

	[CalledBy(Type = typeof(DateTimeParse), Member = "DoStrictParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(System.ReadOnlySpan`1<System.Char>), typeof(DateTimeStyles), typeof(DateTimeFormatInfo), typeof(DateTimeResult&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DateTimeFormatInfo), Member = "InitializeFormatFlags", ReturnType = typeof(DateTimeFormatFlags))]
	[ContainsUnimplementedInstructions]
	internal bool get_HasYearMonthAdjustment() { }

	[CalledBy(Type = typeof(DateTimeFormat), Member = "ExpandPredefinedFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(DateTime&), typeof(DateTimeFormatInfo&), typeof(TimeSpan&)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(DateTimeFormat), Member = "FormatStringBuilder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(System.ReadOnlySpan`1<System.Char>), typeof(DateTimeFormatInfo), typeof(TimeSpan)}, ReturnType = typeof(StringBuilder))]
	[CalledBy(Type = typeof(DateTimeParse), Member = "ExpandPredefinedFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(DateTimeFormatInfo&), typeof(ParsingInfo&), typeof(DateTimeResult&)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "CreateTokenHashTable", ReturnType = typeof(TokenHashValue[]))]
	[CalledBy(Type = "System.Xml.XmlConvert", Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(string)}, ReturnType = typeof(string))]
	[CalledBy(Type = "System.Xml.XmlConvert", Member = "ToDateTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(DateTime))]
	[CalledBy(Type = "System.Xml.XmlConvert", Member = "ToDateTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "System.String[]"}, ReturnType = typeof(DateTime))]
	[CalledBy(Type = "System.Xml.Serialization.XmlCustomFormatter", Member = "FromXmlString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Xml.Serialization.TypeData", typeof(string)}, ReturnType = typeof(object))]
	[CallerCount(Count = 16)]
	[Calls(Type = typeof(DateTimeFormatInfo), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	public static DateTimeFormatInfo get_InvariantInfo() { }

	[CallerCount(Count = 0)]
	public bool get_IsReadOnly() { }

	[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "PopulateSpecialTokenHashTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TokenHashValue[]), typeof(Boolean&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private string get_LanguageName() { }

	[CalledBy(Type = typeof(DateTimeFormat), Member = "ExpandPredefinedFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(DateTime&), typeof(DateTimeFormatInfo&), typeof(TimeSpan&)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(DateTimeParse), Member = "ExpandPredefinedFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(DateTimeFormatInfo&), typeof(ParsingInfo&), typeof(DateTimeResult&)}, ReturnType = typeof(string))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(DateTimeFormatInfo), Member = "get_UnclonedLongDatePatterns", ReturnType = typeof(String[]))]
	[CallsUnknownMethods(Count = 3)]
	public string get_LongDatePattern() { }

	[CalledBy(Type = typeof(DateTimeFormat), Member = "ExpandPredefinedFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(DateTime&), typeof(DateTimeFormatInfo&), typeof(TimeSpan&)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(DateTimeParse), Member = "ExpandPredefinedFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(DateTimeFormatInfo&), typeof(ParsingInfo&), typeof(DateTimeResult&)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "get_FullDateTimePattern", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "get_GeneralLongTimePattern", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "get_DateTimeOffsetPattern", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "get_AllLongTimePatterns", ReturnType = typeof(String[]))]
	[CallerCount(Count = 7)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public string get_LongTimePattern() { }

	[CalledBy(Type = typeof(DateTimeFormat), Member = "ExpandPredefinedFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(DateTime&), typeof(DateTimeFormatInfo&), typeof(TimeSpan&)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(DateTimeParse), Member = "GetDayOfNN", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeResult&), typeof(DateTimeStyles&), typeof(DateTimeRawInfo&), typeof(DateTimeFormatInfo)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DateTimeParse), Member = "GetDayOfMN", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeResult&), typeof(DateTimeStyles&), typeof(DateTimeRawInfo&), typeof(DateTimeFormatInfo)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DateTimeParse), Member = "GetHebrewDayOfNM", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeResult&), typeof(DateTimeRawInfo&), typeof(DateTimeFormatInfo)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DateTimeParse), Member = "GetDayOfNM", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeResult&), typeof(DateTimeStyles&), typeof(DateTimeRawInfo&), typeof(DateTimeFormatInfo)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DateTimeParse), Member = "ProcessTerminalState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DS), typeof(__DTString&), typeof(DateTimeResult&), typeof(DateTimeStyles&), typeof(DateTimeRawInfo&), typeof(DateTimeFormatInfo)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DateTimeParse), Member = "ExpandPredefinedFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(DateTimeFormatInfo&), typeof(ParsingInfo&), typeof(DateTimeResult&)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(DateTimeFormatInfoScanner), Member = "GetDateWordsOfDTFI", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeFormatInfo)}, ReturnType = typeof(String[]))]
	[CallerCount(Count = 13)]
	[Calls(Type = typeof(CultureData), Member = "MonthDay", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public string get_MonthDayPattern() { }

	[CalledBy(Type = typeof(DateTimeParse), Member = "MatchMonthName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(__DTString&), typeof(DateTimeFormatInfo), typeof(Int32&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CultureData), Member = "GenitiveMonthNames", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(String[]))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	public String[] get_MonthGenitiveNames() { }

	[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "InitializeFormatFlags", ReturnType = typeof(DateTimeFormatFlags))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(DateTimeFormatInfo), Member = "internalGetMonthNamesCore", ReturnType = typeof(String[]))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public String[] get_MonthNames() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CultureData), Member = "GetCalendarIds", ReturnType = typeof(CalendarId[]))]
	[CallsUnknownMethods(Count = 2)]
	private CalendarId[] get_OptionalCalendars() { }

	[CalledBy(Type = typeof(DateTimeFormat), Member = "FormatCustomized", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(System.ReadOnlySpan`1<System.Char>), typeof(DateTimeFormatInfo), typeof(TimeSpan), typeof(StringBuilder)}, ReturnType = typeof(StringBuilder))]
	[CalledBy(Type = typeof(DateTimeParse), Member = "AdjustTimeMark", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeFormatInfo), typeof(DateTimeRawInfo&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DateTimeParse), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(DateTimeFormatInfo), typeof(DateTimeStyles), typeof(DateTimeResult&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DateTimeParse), Member = "MatchTimeMark", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(__DTString&), typeof(DateTimeFormatInfo), typeof(TM&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DateTimeParse), Member = "MatchAbbreviatedTimeMark", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(__DTString&), typeof(DateTimeFormatInfo), typeof(TM&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DateTimeParse), Member = "ParseByFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(__DTString&), typeof(__DTString&), typeof(ParsingInfo&), typeof(DateTimeFormatInfo), typeof(DateTimeResult&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 15)]
	[CallsUnknownMethods(Count = 2)]
	public string get_PMDesignator() { }

	[CalledBy(Type = typeof(DateTimeFormat), Member = "ExpandPredefinedFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(DateTime&), typeof(DateTimeFormatInfo&), typeof(TimeSpan&)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(DateTimeParse), Member = "ExpandPredefinedFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(DateTimeFormatInfo&), typeof(ParsingInfo&), typeof(DateTimeResult&)}, ReturnType = typeof(string))]
	[CallerCount(Count = 2)]
	public string get_RFC1123Pattern() { }

	[CalledBy(Type = typeof(DateTimeFormat), Member = "ExpandPredefinedFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(DateTime&), typeof(DateTimeFormatInfo&), typeof(TimeSpan&)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(DateTimeParse), Member = "GetDayOfNNN", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeResult&), typeof(DateTimeRawInfo&), typeof(DateTimeFormatInfo)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DateTimeParse), Member = "GetDayOfMNN", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeResult&), typeof(DateTimeRawInfo&), typeof(DateTimeFormatInfo)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DateTimeParse), Member = "GetDayOfYNN", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeResult&), typeof(DateTimeRawInfo&), typeof(DateTimeFormatInfo)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DateTimeParse), Member = "GetDayOfNNY", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeResult&), typeof(DateTimeRawInfo&), typeof(DateTimeFormatInfo)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DateTimeParse), Member = "GetDateOfNNDS", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeResult&), typeof(DateTimeRawInfo&), typeof(DateTimeFormatInfo)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DateTimeParse), Member = "ProcessTerminalState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DS), typeof(__DTString&), typeof(DateTimeResult&), typeof(DateTimeStyles&), typeof(DateTimeRawInfo&), typeof(DateTimeFormatInfo)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DateTimeParse), Member = "ExpandPredefinedFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(DateTimeFormatInfo&), typeof(ParsingInfo&), typeof(DateTimeResult&)}, ReturnType = typeof(string))]
	[CalledBy(Type = "System.ComponentModel.DateTimeConverter", Member = "ConvertTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.ComponentModel.ITypeDescriptorContext", typeof(CultureInfo), typeof(object), typeof(Type)}, ReturnType = typeof(object))]
	[CalledBy(Type = "System.ComponentModel.DateTimeOffsetConverter", Member = "ConvertTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.ComponentModel.ITypeDescriptorContext", typeof(CultureInfo), typeof(object), typeof(Type)}, ReturnType = typeof(object))]
	[CallerCount(Count = 16)]
	[Calls(Type = typeof(DateTimeFormatInfo), Member = "get_UnclonedShortDatePatterns", ReturnType = typeof(String[]))]
	[CallsUnknownMethods(Count = 3)]
	public string get_ShortDatePattern() { }

	[CalledBy(Type = typeof(DateTimeFormat), Member = "ExpandPredefinedFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(DateTime&), typeof(DateTimeFormatInfo&), typeof(TimeSpan&)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(DateTimeParse), Member = "ExpandPredefinedFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(DateTimeFormatInfo&), typeof(ParsingInfo&), typeof(DateTimeResult&)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "get_GeneralShortTimePattern", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "get_AllShortTimePatterns", ReturnType = typeof(String[]))]
	[CalledBy(Type = "System.ComponentModel.DateTimeConverter", Member = "ConvertTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.ComponentModel.ITypeDescriptorContext", typeof(CultureInfo), typeof(object), typeof(Type)}, ReturnType = typeof(object))]
	[CalledBy(Type = "System.ComponentModel.DateTimeOffsetConverter", Member = "ConvertTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.ComponentModel.ITypeDescriptorContext", typeof(CultureInfo), typeof(object), typeof(Type)}, ReturnType = typeof(object))]
	[CallerCount(Count = 8)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public string get_ShortTimePattern() { }

	[CalledBy(Type = typeof(DateTimeFormat), Member = "ExpandPredefinedFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(DateTime&), typeof(DateTimeFormatInfo&), typeof(TimeSpan&)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(DateTimeParse), Member = "ExpandPredefinedFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(DateTimeFormatInfo&), typeof(ParsingInfo&), typeof(DateTimeResult&)}, ReturnType = typeof(string))]
	[CallerCount(Count = 2)]
	public string get_SortableDateTimePattern() { }

	[CalledBy(Type = typeof(DateTimeFormat), Member = "FormatCustomized", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(System.ReadOnlySpan`1<System.Char>), typeof(DateTimeFormatInfo), typeof(TimeSpan), typeof(StringBuilder)}, ReturnType = typeof(StringBuilder))]
	[CalledBy(Type = typeof(DateTimeParse), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(DateTimeFormatInfo), typeof(DateTimeStyles), typeof(DateTimeResult&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DateTimeParse), Member = "ParseByFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(__DTString&), typeof(__DTString&), typeof(ParsingInfo&), typeof(DateTimeFormatInfo), typeof(DateTimeResult&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "CreateTokenHashTable", ReturnType = typeof(TokenHashValue[]))]
	[CallerCount(Count = 6)]
	[CallsUnknownMethods(Count = 2)]
	public string get_TimeSeparator() { }

	[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "get_FullDateTimePattern", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "get_LongDatePattern", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "get_AllLongDatePatterns", ReturnType = typeof(String[]))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CultureData), Member = "LongDates", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(String[]))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private String[] get_UnclonedLongDatePatterns() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private String[] get_UnclonedLongTimePatterns() { }

	[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "get_ShortDatePattern", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "get_GeneralShortTimePattern", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "get_GeneralLongTimePattern", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "get_DateTimeOffsetPattern", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "get_AllShortDatePatterns", ReturnType = typeof(String[]))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CultureData), Member = "ShortDates", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(String[]))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private String[] get_UnclonedShortDatePatterns() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private String[] get_UnclonedShortTimePatterns() { }

	[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "get_YearMonthPattern", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "GetAllDateTimePatterns", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(String[]))]
	[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "get_AllYearMonthPatterns", ReturnType = typeof(String[]))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CultureData), Member = "YearMonths", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(String[]))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private String[] get_UnclonedYearMonthPatterns() { }

	[CalledBy(Type = typeof(DateTimeFormat), Member = "ExpandPredefinedFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(DateTime&), typeof(DateTimeFormatInfo&), typeof(TimeSpan&)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(DateTimeParse), Member = "ExpandPredefinedFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(DateTimeFormatInfo&), typeof(ParsingInfo&), typeof(DateTimeResult&)}, ReturnType = typeof(string))]
	[CallerCount(Count = 2)]
	public string get_UniversalSortableDateTimePattern() { }

	[CalledBy(Type = typeof(DateTimeFormat), Member = "ExpandPredefinedFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(DateTime&), typeof(DateTimeFormatInfo&), typeof(TimeSpan&)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(DateTimeParse), Member = "GetDayOfMN", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeResult&), typeof(DateTimeStyles&), typeof(DateTimeRawInfo&), typeof(DateTimeFormatInfo)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DateTimeParse), Member = "GetDayOfNM", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeResult&), typeof(DateTimeStyles&), typeof(DateTimeRawInfo&), typeof(DateTimeFormatInfo)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DateTimeParse), Member = "ExpandPredefinedFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(DateTimeFormatInfo&), typeof(ParsingInfo&), typeof(DateTimeResult&)}, ReturnType = typeof(string))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(DateTimeFormatInfo), Member = "get_UnclonedYearMonthPatterns", ReturnType = typeof(String[]))]
	[CallsUnknownMethods(Count = 3)]
	public string get_YearMonthPattern() { }

	[CalledBy(Type = typeof(DateTimeFormat), Member = "FormatDayOfWeek", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(DateTimeFormatInfo)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(DateTimeFormat), Member = "FormatCustomized", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(System.ReadOnlySpan`1<System.Char>), typeof(DateTimeFormatInfo), typeof(TimeSpan), typeof(StringBuilder)}, ReturnType = typeof(StringBuilder))]
	[CalledBy(Type = typeof(DateTimeParse), Member = "MatchAbbreviatedDayName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(__DTString&), typeof(DateTimeFormatInfo), typeof(Int32&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DateTimeParse), Member = "ParseByFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(__DTString&), typeof(__DTString&), typeof(ParsingInfo&), typeof(DateTimeFormatInfo), typeof(DateTimeResult&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "CreateTokenHashTable", ReturnType = typeof(TokenHashValue[]))]
	[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "PopulateSpecialTokenHashTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TokenHashValue[]), typeof(Boolean&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(DateTimeFormatInfo), Member = "internalGetAbbreviatedDayOfWeekNamesCore", ReturnType = typeof(String[]))]
	[Calls(Type = typeof(SR), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 9)]
	public string GetAbbreviatedDayName(DayOfWeek dayofweek) { }

	[CalledBy(Type = typeof(DateTimeParse), Member = "MatchEraName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(__DTString&), typeof(DateTimeFormatInfo), typeof(Int32&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "CreateTokenHashTable", ReturnType = typeof(TokenHashValue[]))]
	[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "PopulateSpecialTokenHashTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TokenHashValue[]), typeof(Boolean&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CultureData), Member = "AbbrevEraNames", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(String[]))]
	[Calls(Type = typeof(DateTimeFormatInfo), Member = "GetEraName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 8)]
	public string GetAbbreviatedEraName(int era) { }

	[CalledBy(Type = typeof(DateTimeFormat), Member = "FormatMonth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(DateTimeFormatInfo)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(DateTimeFormat), Member = "FormatHebrewMonthName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(int), typeof(int), typeof(DateTimeFormatInfo)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(DateTimeFormat), Member = "FormatCustomized", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(System.ReadOnlySpan`1<System.Char>), typeof(DateTimeFormatInfo), typeof(TimeSpan), typeof(StringBuilder)}, ReturnType = typeof(StringBuilder))]
	[CalledBy(Type = typeof(DateTimeParse), Member = "MatchAbbreviatedMonthName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(__DTString&), typeof(DateTimeFormatInfo), typeof(Int32&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "CreateTokenHashTable", ReturnType = typeof(TokenHashValue[]))]
	[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "PopulateSpecialTokenHashTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TokenHashValue[]), typeof(Boolean&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "AddMonthNames", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TokenHashValue[]), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(DateTimeFormatInfo), Member = "internalGetAbbreviatedMonthNamesCore", ReturnType = typeof(String[]))]
	[Calls(Type = typeof(SR), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 7)]
	public string GetAbbreviatedMonthName(int month) { }

	[CalledBy(Type = typeof(DateTimeFormatInfoScanner), Member = "GetDateWordsOfDTFI", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeFormatInfo)}, ReturnType = typeof(String[]))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(DateTimeFormatInfo), Member = "get_AllShortTimePatterns", ReturnType = typeof(String[]))]
	[Calls(Type = typeof(DateTimeFormatInfo), Member = "get_AllShortDatePatterns", ReturnType = typeof(String[]))]
	[Calls(Type = typeof(DateTimeFormatInfo), Member = "GetCombinedPatterns", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[]), typeof(String[]), typeof(string)}, ReturnType = typeof(String[]))]
	[Calls(Type = typeof(DateTimeFormatInfo), Member = "get_AllLongDatePatterns", ReturnType = typeof(String[]))]
	[Calls(Type = typeof(DateTimeFormatInfo), Member = "get_UnclonedYearMonthPatterns", ReturnType = typeof(String[]))]
	[Calls(Type = typeof(DateTimeFormatInfo), Member = "GetMergedPatterns", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[]), typeof(string)}, ReturnType = typeof(String[]))]
	[Calls(Type = typeof(CultureData), Member = "MonthDay", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(DateTimeFormatInfo), Member = "get_AllLongTimePatterns", ReturnType = typeof(String[]))]
	[Calls(Type = typeof(SR), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 16)]
	public String[] GetAllDateTimePatterns(char format) { }

	[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "GetAllDateTimePatterns", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(String[]))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 3)]
	private static String[] GetCombinedPatterns(String[] patterns1, String[] patterns2, string connectString) { }

	[CalledBy(Type = typeof(DateTimeFormat), Member = "FormatDayOfWeek", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(DateTimeFormatInfo)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(DateTimeFormat), Member = "FormatCustomized", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(System.ReadOnlySpan`1<System.Char>), typeof(DateTimeFormatInfo), typeof(TimeSpan), typeof(StringBuilder)}, ReturnType = typeof(StringBuilder))]
	[CalledBy(Type = typeof(DateTimeParse), Member = "MatchDayName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(__DTString&), typeof(DateTimeFormatInfo), typeof(Int32&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DateTimeParse), Member = "ParseByFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(__DTString&), typeof(__DTString&), typeof(ParsingInfo&), typeof(DateTimeFormatInfo), typeof(DateTimeResult&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "CreateTokenHashTable", ReturnType = typeof(TokenHashValue[]))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(DateTimeFormatInfo), Member = "internalGetDayOfWeekNamesCore", ReturnType = typeof(String[]))]
	[Calls(Type = typeof(SR), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 9)]
	public string GetDayName(DayOfWeek dayofweek) { }

	[CalledBy(Type = typeof(DateTimeFormat), Member = "FormatCustomized", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(System.ReadOnlySpan`1<System.Char>), typeof(DateTimeFormatInfo), typeof(TimeSpan), typeof(StringBuilder)}, ReturnType = typeof(StringBuilder))]
	[CalledBy(Type = typeof(DateTimeParse), Member = "MatchEraName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(__DTString&), typeof(DateTimeFormatInfo), typeof(Int32&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "GetAbbreviatedEraName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "CreateTokenHashTable", ReturnType = typeof(TokenHashValue[]))]
	[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "PopulateSpecialTokenHashTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TokenHashValue[]), typeof(Boolean&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(CultureData), Member = "EraNames", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(String[]))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 8)]
	public string GetEraName(int era) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[CallsDeduplicatedMethods(Count = 1)]
	public override object GetFormat(Type formatType) { }

	[CalledBy(Type = typeof(DateTime), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(DateTime))]
	[CalledBy(Type = typeof(TimeSpanParse), Member = "TryParseTimeSpan", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), "System.Globalization.TimeSpanParse+TimeSpanStandardStyles", typeof(IFormatProvider), typeof(TimeSpanResult&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TimeSpanFormat), Member = "FormatToBuilder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpan), typeof(System.ReadOnlySpan`1<System.Char>), typeof(IFormatProvider)}, ReturnType = typeof(StringBuilder))]
	[CalledBy(Type = typeof(DateTimeFormat), Member = "TryFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(System.Span`1<System.Char>), typeof(Int32&), typeof(System.ReadOnlySpan`1<System.Char>), typeof(IFormatProvider), typeof(TimeSpan)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DateTimeFormat), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(string), typeof(IFormatProvider), typeof(TimeSpan)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(DateTimeOffset), Member = "TryParseExact", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(IFormatProvider), typeof(DateTimeStyles), typeof(DateTimeOffset&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DateTimeOffset), Member = "ParseExact", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(IFormatProvider), typeof(DateTimeStyles)}, ReturnType = typeof(DateTimeOffset))]
	[CalledBy(Type = typeof(DateTimeOffset), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider), typeof(DateTimeStyles), typeof(DateTimeOffset&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DateTime), Member = "TryParseExact", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(IFormatProvider), typeof(DateTimeStyles), typeof(DateTime&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DateTime), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider), typeof(DateTimeStyles), typeof(DateTime&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DateTime), Member = "ParseExact", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[]), typeof(IFormatProvider), typeof(DateTimeStyles)}, ReturnType = typeof(DateTime))]
	[CalledBy(Type = typeof(DateTime), Member = "ParseExact", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(IFormatProvider), typeof(DateTimeStyles)}, ReturnType = typeof(DateTime))]
	[CalledBy(Type = typeof(DateTime), Member = "ParseExact", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(DateTime))]
	[CalledBy(Type = typeof(DateTime), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider), typeof(DateTimeStyles)}, ReturnType = typeof(DateTime))]
	[CalledBy(Type = typeof(DateTimeOffset), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider), typeof(DateTimeStyles)}, ReturnType = typeof(DateTimeOffset))]
	[CallerCount(Count = 16)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(DateTimeFormatInfo), Member = "get_CurrentInfo", ReturnType = typeof(DateTimeFormatInfo))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public static DateTimeFormatInfo GetInstance(IFormatProvider provider) { }

	[CalledBy(Type = typeof(DateTimeParse), Member = "Lex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DS), typeof(__DTString&), typeof(DateTimeToken&), typeof(DateTimeRawInfo&), typeof(DateTimeResult&), typeof(DateTimeFormatInfo&), typeof(DateTimeStyles)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CultureInfo), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(JapaneseCalendar), Member = "GetDefaultInstance", ReturnType = typeof(Calendar))]
	[Calls(Type = typeof(DateTimeFormatInfo), Member = "set_Calendar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Calendar)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	internal static DateTimeFormatInfo GetJapaneseCalendarDTFI() { }

	[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "GetAllDateTimePatterns", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(String[]))]
	[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "get_AllYearMonthPatterns", ReturnType = typeof(String[]))]
	[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "get_AllShortDatePatterns", ReturnType = typeof(String[]))]
	[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "get_AllShortTimePatterns", ReturnType = typeof(String[]))]
	[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "get_AllLongDatePatterns", ReturnType = typeof(String[]))]
	[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "get_AllLongTimePatterns", ReturnType = typeof(String[]))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 8)]
	private static String[] GetMergedPatterns(String[] patterns, string defaultPattern) { }

	[CalledBy(Type = typeof(DateTimeFormat), Member = "FormatMonth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(DateTimeFormatInfo)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(DateTimeFormat), Member = "FormatHebrewMonthName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(int), typeof(int), typeof(DateTimeFormatInfo)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(DateTimeFormat), Member = "FormatCustomized", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(System.ReadOnlySpan`1<System.Char>), typeof(DateTimeFormatInfo), typeof(TimeSpan), typeof(StringBuilder)}, ReturnType = typeof(StringBuilder))]
	[CalledBy(Type = typeof(DateTimeParse), Member = "MatchAbbreviatedMonthName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(__DTString&), typeof(DateTimeFormatInfo), typeof(Int32&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DateTimeParse), Member = "MatchMonthName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(__DTString&), typeof(DateTimeFormatInfo), typeof(Int32&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "CreateTokenHashTable", ReturnType = typeof(TokenHashValue[]))]
	[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "PopulateSpecialTokenHashTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TokenHashValue[]), typeof(Boolean&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "AddMonthNames", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TokenHashValue[]), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(DateTimeFormatInfo), Member = "internalGetMonthNamesCore", ReturnType = typeof(String[]))]
	[Calls(Type = typeof(SR), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 7)]
	public string GetMonthName(int month) { }

	[CalledBy(Type = typeof(DateTimeParse), Member = "Lex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DS), typeof(__DTString&), typeof(DateTimeToken&), typeof(DateTimeRawInfo&), typeof(DateTimeResult&), typeof(DateTimeFormatInfo&), typeof(DateTimeStyles)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CultureInfo), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TaiwanCalendar), Member = "GetDefaultInstance", ReturnType = typeof(Calendar))]
	[Calls(Type = typeof(DateTimeFormatInfo), Member = "set_Calendar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Calendar)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	internal static DateTimeFormatInfo GetTaiwanCalendarDTFI() { }

	[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "get_HasSpacesInMonthNames", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "get_HasSpacesInDayNames", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "get_FormatFlags", ReturnType = typeof(DateTimeFormatFlags))]
	[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "get_HasYearMonthAdjustment", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "YearMonthAdjustment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&), typeof(Int32&), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "CreateTokenHashTable", ReturnType = typeof(TokenHashValue[]))]
	[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "PopulateSpecialTokenHashTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TokenHashValue[]), typeof(Boolean&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "Tokenize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TokenType), typeof(TokenType&), typeof(Int32&), typeof(__DTString&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(DateTimeFormatInfoScanner), Member = "GetFormatFlagUseHebrewCalendar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(FORMATFLAGS))]
	[Calls(Type = typeof(DateTimeFormatInfoScanner), Member = "GetFormatFlagUseSpaceInDayNames", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[]), typeof(String[])}, ReturnType = typeof(FORMATFLAGS))]
	[Calls(Type = typeof(DateTimeFormatInfo), Member = "internalGetAbbreviatedDayOfWeekNamesCore", ReturnType = typeof(String[]))]
	[Calls(Type = typeof(DateTimeFormatInfo), Member = "internalGetDayOfWeekNamesCore", ReturnType = typeof(String[]))]
	[Calls(Type = typeof(DateTimeFormatInfoScanner), Member = "GetFormatFlagUseSpaceInMonthNames", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[]), typeof(String[]), typeof(String[]), typeof(String[])}, ReturnType = typeof(FORMATFLAGS))]
	[Calls(Type = typeof(CultureData), Member = "GenitiveMonthNames", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(String[]))]
	[Calls(Type = typeof(CultureData), Member = "AbbreviatedGenitiveMonthNames", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(String[]))]
	[Calls(Type = typeof(DateTimeFormatInfo), Member = "get_AbbreviatedMonthNames", ReturnType = typeof(String[]))]
	[Calls(Type = typeof(DateTimeFormatInfo), Member = "get_MonthNames", ReturnType = typeof(String[]))]
	[Calls(Type = typeof(DateTimeFormatInfoScanner), Member = "GetFormatFlagGenitiveMonth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[]), typeof(String[]), typeof(String[]), typeof(String[])}, ReturnType = typeof(FORMATFLAGS))]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 9)]
	private DateTimeFormatFlags InitializeFormatFlags() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CultureData), Member = "DateSeparator", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CultureData), Member = "LongDates", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(String[]))]
	[Calls(Type = typeof(CultureData), Member = "ShortDates", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(String[]))]
	[Calls(Type = typeof(CultureData), Member = "YearMonths", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(String[]))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 10)]
	private void InitializeOverridableProperties(CultureData cultureData, int calendarId) { }

	[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "InsertHash", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TokenHashValue[]), typeof(string), typeof(TokenType), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DateTimeFormatInfo), Member = "get_Culture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 10)]
	private void InsertAtCurrentHashNode(TokenHashValue[] hashTable, string str, char ch, TokenType tokenType, int tokenValue, int pos, int hashcode, int hashProbe) { }

	[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "CreateTokenHashTable", ReturnType = typeof(TokenHashValue[]))]
	[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "PopulateSpecialTokenHashTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TokenHashValue[]), typeof(Boolean&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "AddMonthNames", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TokenHashValue[]), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 58)]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(char), Member = "IsWhiteSpace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "Trim", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(DateTimeFormatInfo), Member = "get_Culture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(DateTimeFormatInfo), Member = "InsertAtCurrentHashNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TokenHashValue[]), typeof(string), typeof(char), typeof(TokenType), typeof(int), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 6)]
	[ContainsUnimplementedInstructions]
	private void InsertHash(TokenHashValue[] hashTable, string str, TokenType tokenType, int tokenValue) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DateTimeFormatInfo), Member = "internalGetAbbreviatedDayOfWeekNamesCore", ReturnType = typeof(String[]))]
	private String[] internalGetAbbreviatedDayOfWeekNames() { }

	[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "internalGetAbbreviatedDayOfWeekNames", ReturnType = typeof(String[]))]
	[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "get_AbbreviatedDayNames", ReturnType = typeof(String[]))]
	[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "GetAbbreviatedDayName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DayOfWeek)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "InitializeFormatFlags", ReturnType = typeof(DateTimeFormatFlags))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CultureData), Member = "AbbreviatedDayNames", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(String[]))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private String[] internalGetAbbreviatedDayOfWeekNamesCore() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DateTimeFormatInfo), Member = "internalGetAbbreviatedMonthNamesCore", ReturnType = typeof(String[]))]
	private String[] internalGetAbbreviatedMonthNames() { }

	[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "internalGetAbbreviatedMonthNames", ReturnType = typeof(String[]))]
	[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "get_AbbreviatedMonthNames", ReturnType = typeof(String[]))]
	[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "internalGetMonthName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(MonthNameStyles), typeof(bool)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "GetAbbreviatedMonthName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CultureData), Member = "AbbreviatedMonthNames", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(String[]))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private String[] internalGetAbbreviatedMonthNamesCore() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DateTimeFormatInfo), Member = "internalGetDayOfWeekNamesCore", ReturnType = typeof(String[]))]
	private String[] internalGetDayOfWeekNames() { }

	[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "internalGetDayOfWeekNames", ReturnType = typeof(String[]))]
	[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "get_DayNames", ReturnType = typeof(String[]))]
	[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "GetDayName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DayOfWeek)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "InitializeFormatFlags", ReturnType = typeof(DateTimeFormatFlags))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CultureData), Member = "DayNames", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(String[]))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private String[] internalGetDayOfWeekNamesCore() { }

	[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "internalGetMonthName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(MonthNameStyles), typeof(bool)}, ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CultureData), Member = "GenitiveMonthNames", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(String[]))]
	[Calls(Type = typeof(CultureData), Member = "AbbreviatedGenitiveMonthNames", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(String[]))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private String[] internalGetGenitiveMonthNames(bool abbreviated) { }

	[CalledBy(Type = typeof(DateTimeParse), Member = "MatchAbbreviatedMonthName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(__DTString&), typeof(DateTimeFormatInfo), typeof(Int32&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DateTimeParse), Member = "MatchMonthName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(__DTString&), typeof(DateTimeFormatInfo), typeof(Int32&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CultureData), Member = "LeapYearMonthNames", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(String[]))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	internal String[] internalGetLeapYearMonthNames() { }

	[CalledBy(Type = typeof(DateTimeFormat), Member = "FormatHebrewMonthName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(int), typeof(int), typeof(DateTimeFormatInfo)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(DateTimeFormat), Member = "FormatCustomized", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(System.ReadOnlySpan`1<System.Char>), typeof(DateTimeFormatInfo), typeof(TimeSpan), typeof(StringBuilder)}, ReturnType = typeof(StringBuilder))]
	[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "CreateTokenHashTable", ReturnType = typeof(TokenHashValue[]))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(DateTimeFormatInfo), Member = "internalGetGenitiveMonthNames", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(String[]))]
	[Calls(Type = typeof(CultureData), Member = "LeapYearMonthNames", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(String[]))]
	[Calls(Type = typeof(DateTimeFormatInfo), Member = "internalGetAbbreviatedMonthNamesCore", ReturnType = typeof(String[]))]
	[Calls(Type = typeof(DateTimeFormatInfo), Member = "internalGetMonthNamesCore", ReturnType = typeof(String[]))]
	[Calls(Type = typeof(SR), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 9)]
	internal string internalGetMonthName(int month, MonthNameStyles style, bool abbreviated) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DateTimeFormatInfo), Member = "internalGetMonthNamesCore", ReturnType = typeof(String[]))]
	private String[] internalGetMonthNames() { }

	[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "internalGetMonthNames", ReturnType = typeof(String[]))]
	[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "get_MonthNames", ReturnType = typeof(String[]))]
	[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "internalGetMonthName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(MonthNameStyles), typeof(bool)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "GetMonthName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CultureData), Member = "MonthNames", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(String[]))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private String[] internalGetMonthNamesCore() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private bool IsAllowedJapaneseTokenFollowedByNonSpaceLetter(string tokenString, char nextCh) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	private static bool IsHebrewChar(char ch) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(PlatformNotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	private static bool IsJapaneseCalendar(Calendar calendar) { }

	[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "CreateTokenHashTable", ReturnType = typeof(TokenHashValue[]))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PlatformNotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CultureData), Member = "AbbreviatedEnglishEraNames", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(String[]))]
	[Calls(Type = typeof(DateTimeFormatInfo), Member = "GetAbbreviatedEraName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(JapaneseCalendar), Member = "GetDefaultInstance", ReturnType = typeof(Calendar))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(DateTimeFormatInfo), Member = "GetAbbreviatedDayName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DayOfWeek)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(DateTimeFormatInfo), Member = "GetEraName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(DateTimeFormatInfo), Member = "set_Calendar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Calendar)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TaiwanCalendar), Member = "GetDefaultInstance", ReturnType = typeof(Calendar))]
	[Calls(Type = typeof(CultureInfo), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DateTimeFormatInfo), Member = "get_LanguageName", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Trim", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(DateTimeFormatInfo), Member = "get_DateSeparator", ReturnType = typeof(string))]
	[Calls(Type = typeof(DateTimeFormatInfo), Member = "GetAbbreviatedMonthName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(DateTimeFormatInfo), Member = "GetMonthName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(DateTimeFormatInfo), Member = "InitializeFormatFlags", ReturnType = typeof(DateTimeFormatFlags))]
	[Calls(Type = typeof(DateTimeFormatInfoScanner), Member = "GetDateWordsOfDTFI", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeFormatInfo)}, ReturnType = typeof(String[]))]
	[Calls(Type = typeof(DateTimeFormatInfoScanner), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(DateTimeFormatInfo), Member = "InsertHash", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TokenHashValue[]), typeof(string), typeof(TokenType), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 18)]
	private void PopulateSpecialTokenHashTable(TokenHashValue[] temp, ref bool useDateSepAsIgnorableSymbol) { }

	[CalledBy(Type = typeof(DateTimeFormat), Member = "ExpandPredefinedFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(DateTime&), typeof(DateTimeFormatInfo&), typeof(TimeSpan&)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(DateTimeParse), Member = "ExpandPredefinedFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(DateTimeFormatInfo&), typeof(ParsingInfo&), typeof(DateTimeResult&)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(DateTimeFormatInfo), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CultureData), typeof(Calendar)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "GetJapaneseCalendarDTFI", ReturnType = typeof(DateTimeFormatInfo))]
	[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "GetTaiwanCalendarDTFI", ReturnType = typeof(DateTimeFormatInfo))]
	[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "PopulateSpecialTokenHashTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TokenHashValue[]), typeof(Boolean&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(CultureData), Member = "YearMonths", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(String[]))]
	[Calls(Type = typeof(CultureData), Member = "GetCalendarIds", ReturnType = typeof(CalendarId[]))]
	[Calls(Type = typeof(CultureData), Member = "LongDates", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(String[]))]
	[Calls(Type = typeof(CultureData), Member = "ShortDates", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(String[]))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(PlatformNotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CultureData), Member = "DateSeparator", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 54)]
	public void set_Calendar(Calendar value) { }

	[CalledBy(Type = typeof(__DTString), Member = "GetRegularToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TokenType&), typeof(Int32&), typeof(DateTimeFormatInfo)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(__DTString), Member = "GetSeparatorToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeFormatInfo), typeof(Int32&), typeof(Char&)}, ReturnType = typeof(TokenType))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(__DTString), Member = "Advance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CompareInfo), Member = "Compare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(string), typeof(CompareOptions)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(DateTimeFormatInfo), Member = "CreateTokenHashTable", ReturnType = typeof(TokenHashValue[]))]
	[Calls(Type = typeof(__DTString), Member = "get_Length", ReturnType = typeof(int))]
	[Calls(Type = typeof(HebrewNumber), Member = "ParseByChar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(HebrewNumberParsingContext&)}, ReturnType = typeof(HebrewNumberParsingState))]
	[Calls(Type = typeof(DateTimeFormatInfo), Member = "InitializeFormatFlags", ReturnType = typeof(DateTimeFormatFlags))]
	[Calls(Type = typeof(HebrewNumberParsingContext), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(HebrewNumber), Member = "IsDigit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DateTimeFormatInfo), Member = "get_Culture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(char), Member = "IsLetter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(__DTString), Member = "MatchSpecifiedWords", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool), typeof(Int32&)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 4)]
	[ContainsUnimplementedInstructions]
	internal bool Tokenize(TokenType TokenMask, out TokenType tokenType, out int tokenValue, ref __DTString str) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(HebrewNumber), Member = "IsDigit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(HebrewNumberParsingContext), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(HebrewNumber), Member = "ParseByChar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(HebrewNumberParsingContext&)}, ReturnType = typeof(HebrewNumberParsingState))]
	[Calls(Type = typeof(__DTString), Member = "Advance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	private static bool TryParseHebrewNumber(ref __DTString str, out bool badFormat, out int number) { }

	[CalledBy(Type = typeof(DateTime), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider), typeof(DateTimeStyles)}, ReturnType = typeof(DateTime))]
	[CalledBy(Type = typeof(DateTime), Member = "ParseExact", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(IFormatProvider), typeof(DateTimeStyles)}, ReturnType = typeof(DateTime))]
	[CalledBy(Type = typeof(DateTime), Member = "ParseExact", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[]), typeof(IFormatProvider), typeof(DateTimeStyles)}, ReturnType = typeof(DateTime))]
	[CalledBy(Type = typeof(DateTime), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider), typeof(DateTimeStyles), typeof(DateTime&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DateTime), Member = "TryParseExact", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(IFormatProvider), typeof(DateTimeStyles), typeof(DateTime&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 12)]
	[ContainsUnimplementedInstructions]
	internal static void ValidateStyles(DateTimeStyles style, string parameterName) { }

	[CalledBy(Type = typeof(DateTimeParse), Member = "DoStrictParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(System.ReadOnlySpan`1<System.Char>), typeof(DateTimeStyles), typeof(DateTimeFormatInfo), typeof(DateTimeResult&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DateTimeFormatInfo), Member = "InitializeFormatFlags", ReturnType = typeof(DateTimeFormatFlags))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 1)]
	internal bool YearMonthAdjustment(ref int year, ref int month, bool parsedMonthName) { }

}

