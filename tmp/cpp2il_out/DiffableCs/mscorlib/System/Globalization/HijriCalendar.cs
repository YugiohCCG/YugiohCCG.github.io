namespace System.Globalization;

[ComVisible(True)]
public class HijriCalendar : Calendar
{
	public static readonly int HijriEra; //Field offset: 0x0
	internal static readonly Int32[] HijriMonthDays; //Field offset: 0x8
	internal static readonly DateTime calendarMinValue; //Field offset: 0x10
	internal static readonly DateTime calendarMaxValue; //Field offset: 0x18
	private int m_HijriAdvance; //Field offset: 0x20

	protected virtual int DaysInYearBeforeMinSupportedYear
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 6
	}

	public virtual Int32[] Eras
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		 get { } //Length: 140
	}

	public int HijriAdjustment
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 83
	}

	internal virtual int ID
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		internal get { } //Length: 6
	}

	[ComVisible(False)]
	public virtual DateTime MaxSupportedDateTime
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 79
	}

	[ComVisible(False)]
	public virtual DateTime MinSupportedDateTime
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 79
	}

	public virtual int TwoDigitYearMax
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		 get { } //Length: 105
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Calendar), Member = "VerifyWritable", ReturnType = typeof(void))]
		[Calls(Type = typeof(CultureInfo), Member = "get_CurrentCulture", ReturnType = typeof(CultureInfo))]
		[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider), typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 7)]
		 set { } //Length: 268
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(RuntimeFieldHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DateTime), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private static HijriCalendar() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public HijriCalendar() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	internal static void CheckEraRange(int era) { }

	[CalledBy(Type = typeof(HijriCalendar), Member = "GetDatePart", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(HijriCalendar), Member = "GetEra", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime)}, ReturnType = typeof(int))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(DateTime), Member = "get_Ticks", ReturnType = typeof(long))]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider), typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 13)]
	internal static void CheckTicksRange(long ticks) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(HijriCalendar), Member = "CheckYearRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CultureInfo), Member = "get_CurrentCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider), typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 12)]
	internal static void CheckYearMonthRange(int year, int month, int era) { }

	[CalledBy(Type = typeof(HijriCalendar), Member = "CheckYearMonthRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(HijriCalendar), Member = "GetDaysInMonth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(HijriCalendar), Member = "GetDaysInYear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(HijriCalendar), Member = "GetMonthsInYear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(HijriCalendar), Member = "IsLeapYear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CultureInfo), Member = "get_CurrentCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider), typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 12)]
	internal static void CheckYearRange(int year, int era) { }

	[CalledBy(Type = typeof(HijriCalendar), Member = "GetAbsoluteDateHijri", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(long))]
	[CalledBy(Type = typeof(HijriCalendar), Member = "GetDatePart", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(HijriCalendar), Member = "ToDateTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(DateTime))]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private long DaysUpToHijriYear(int HijriYear) { }

	[CallerCount(Count = 0)]
	protected virtual int get_DaysInYearBeforeMinSupportedYear() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public virtual Int32[] get_Eras() { }

	[CallerCount(Count = 0)]
	public int get_HijriAdjustment() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	internal virtual int get_ID() { }

	[CallerCount(Count = 0)]
	public virtual DateTime get_MaxSupportedDateTime() { }

	[CallerCount(Count = 0)]
	public virtual DateTime get_MinSupportedDateTime() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public virtual int get_TwoDigitYearMax() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(HijriCalendar), Member = "DaysUpToHijriYear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(long))]
	[CallsUnknownMethods(Count = 2)]
	private long GetAbsoluteDateHijri(int y, int m, int d) { }

	[CallerCount(Count = 182)]
	[DeduplicatedMethod]
	private static int GetAdvanceHijriDate() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(HijriCalendar), Member = "CheckTicksRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(HijriCalendar), Member = "DaysUpToHijriYear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(long))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 6)]
	[ContainsUnimplementedInstructions]
	internal override int GetDatePart(long ticks, int part) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DateTime), Member = "get_Ticks", ReturnType = typeof(long))]
	[CallsDeduplicatedMethods(Count = 1)]
	public virtual int GetDayOfMonth(DateTime time) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DateTime), Member = "get_Ticks", ReturnType = typeof(long))]
	[ContainsUnimplementedInstructions]
	public virtual DayOfWeek GetDayOfWeek(DateTime time) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DateTime), Member = "get_Ticks", ReturnType = typeof(long))]
	[CallsDeduplicatedMethods(Count = 1)]
	public virtual int GetDayOfYear(DateTime time) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(HijriCalendar), Member = "CheckYearRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CultureInfo), Member = "get_CurrentCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider), typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 12)]
	[ContainsUnimplementedInstructions]
	public virtual int GetDaysInMonth(int year, int month, int era) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(HijriCalendar), Member = "CheckYearRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public virtual int GetDaysInYear(int year, int era) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DateTime), Member = "get_Ticks", ReturnType = typeof(long))]
	[Calls(Type = typeof(HijriCalendar), Member = "CheckTicksRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(void))]
	public virtual int GetEra(DateTime time) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DateTime), Member = "get_Ticks", ReturnType = typeof(long))]
	[CallsDeduplicatedMethods(Count = 1)]
	public virtual int GetMonth(DateTime time) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(HijriCalendar), Member = "CheckYearRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	public virtual int GetMonthsInYear(int year, int era) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DateTime), Member = "get_Ticks", ReturnType = typeof(long))]
	[CallsDeduplicatedMethods(Count = 1)]
	public virtual int GetYear(DateTime time) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(HijriCalendar), Member = "CheckYearRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[ContainsUnimplementedInstructions]
	public virtual bool IsLeapYear(int year, int era) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Calendar), Member = "VerifyWritable", ReturnType = typeof(void))]
	[Calls(Type = typeof(CultureInfo), Member = "get_CurrentCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider), typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	public virtual void set_TwoDigitYearMax(int value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(HijriCalendar), Member = "DaysUpToHijriYear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(long))]
	[Calls(Type = typeof(TimeSpan), Member = "TimeToTicks", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(long))]
	[Calls(Type = typeof(DateTime), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CultureInfo), Member = "get_CurrentCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider), typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 24)]
	public virtual DateTime ToDateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, int era) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Calendar), Member = "ToFourDigitYear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CultureInfo), Member = "get_CurrentCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider), typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 12)]
	public virtual int ToFourDigitYear(int year) { }

}

