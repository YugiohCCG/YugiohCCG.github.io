namespace System.Globalization;

[ComVisible(True)]
public abstract class Calendar : ICloneable
{
	internal int m_currentEraValue; //Field offset: 0x10
	[OptionalField(VersionAdded = 2)]
	private bool m_isReadOnly; //Field offset: 0x14
	internal int twoDigitYearMax; //Field offset: 0x18

	internal override int BaseCalendarID
	{
		[CallerCount(Count = 82)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		internal get { } //Length: 17
	}

	internal override int CurrentEraValue
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[ContainsInvalidInstructions]
		internal get { } //Length: 320
	}

	protected override int DaysInYearBeforeMinSupportedYear
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 6
	}

	public abstract Int32[] Eras
	{
		 get { } //Length: 0
	}

	internal override int ID
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		internal get { } //Length: 6
	}

	[ComVisible(False)]
	public override DateTime MaxSupportedDateTime
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 79
	}

	[ComVisible(False)]
	public override DateTime MinSupportedDateTime
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 79
	}

	public override int TwoDigitYearMax
	{
		[CallerCount(Count = 7)]
		[DeduplicatedMethod]
		 get { } //Length: 4
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Calendar), Member = "VerifyWritable", ReturnType = typeof(void))]
		 set { } //Length: 36
	}

	[CalledBy(Type = typeof(ThaiBuddhistCalendar), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UmAlQuraCalendar), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	protected Calendar() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[ComVisible(False)]
	public override object Clone() { }

	[CallerCount(Count = 82)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	internal override int get_BaseCalendarID() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsInvalidInstructions]
	internal override int get_CurrentEraValue() { }

	[CallerCount(Count = 0)]
	protected override int get_DaysInYearBeforeMinSupportedYear() { }

	public abstract Int32[] get_Eras() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	internal override int get_ID() { }

	[CallerCount(Count = 0)]
	public override DateTime get_MaxSupportedDateTime() { }

	[CallerCount(Count = 0)]
	public override DateTime get_MinSupportedDateTime() { }

	[CallerCount(Count = 7)]
	[DeduplicatedMethod]
	public override int get_TwoDigitYearMax() { }

	public abstract int GetDayOfMonth(DateTime time) { }

	public abstract DayOfWeek GetDayOfWeek(DateTime time) { }

	public abstract int GetDayOfYear(DateTime time) { }

	public abstract int GetDaysInMonth(int year, int month, int era) { }

	public abstract int GetDaysInYear(int year, int era) { }

	public abstract int GetEra(DateTime time) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	internal int GetFirstDayWeekOfYear(DateTime time, int firstDayOfWeek) { }

	public abstract int GetMonth(DateTime time) { }

	public abstract int GetMonthsInYear(int year, int era) { }

	[CalledBy(Type = typeof(ThaiBuddhistCalendar), Member = "get_TwoDigitYearMax", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(UmAlQuraCalendar), Member = "get_TwoDigitYearMax", ReturnType = typeof(int))]
	[CallerCount(Count = 2)]
	internal static int GetSystemTwoDigitYearSetting(int CalID, int defaultYearValue) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Calendar), Member = "GetWeekOfYearFullDays", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Environment), Member = "GetResourceString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 28)]
	[ContainsUnimplementedInstructions]
	public override int GetWeekOfYear(DateTime time, CalendarWeekRule rule, DayOfWeek firstDayOfWeek) { }

	[CalledBy(Type = typeof(Calendar), Member = "GetWeekOfYearFullDays", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(Calendar), Member = "GetWeekOfYear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(CalendarWeekRule), typeof(DayOfWeek)}, ReturnType = typeof(int))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(DateTime), Member = "AddDays", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double)}, ReturnType = typeof(DateTime))]
	[Calls(Type = typeof(DateTime), Member = "op_LessThanOrEqual", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(DateTime)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Calendar), Member = "GetWeekOfYearFullDays", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 8)]
	[ContainsUnimplementedInstructions]
	private int GetWeekOfYearFullDays(DateTime time, int firstDayOfWeek, int fullDays) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 5)]
	[ContainsUnimplementedInstructions]
	private int GetWeekOfYearOfMinSupportedDateTime(int firstDayOfWeek, int minimumDaysInFirstWeek) { }

	public abstract int GetYear(DateTime time) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public override bool IsLeapYear(int year) { }

	public abstract bool IsLeapYear(int year, int era) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	internal override bool IsValidDay(int year, int month, int day, int era) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	internal override bool IsValidMonth(int year, int month, int era) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[ContainsUnimplementedInstructions]
	internal override bool IsValidYear(int year, int era) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Calendar), Member = "VerifyWritable", ReturnType = typeof(void))]
	public override void set_TwoDigitYearMax(int value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	internal void SetReadOnlyState(bool readOnly) { }

	[CalledBy(Type = typeof(UmAlQuraCalendar), Member = "ToDateTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(DateTime))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TimeSpan), Member = "TimeToTicks", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(long))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider), typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 11)]
	internal static long TimeToTicks(int hour, int minute, int second, int millisecond) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public override DateTime ToDateTime(int year, int month, int day, int hour, int minute, int second, int millisecond) { }

	public abstract DateTime ToDateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, int era) { }

	[CalledBy(Type = typeof(GregorianCalendar), Member = "ToFourDigitYear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(HijriCalendar), Member = "ToFourDigitYear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(UmAlQuraCalendar), Member = "ToFourDigitYear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 5)]
	[ContainsUnimplementedInstructions]
	public override int ToFourDigitYear(int year) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	internal override bool TryToDateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, int era, out DateTime result) { }

	[CalledBy(Type = typeof(Calendar), Member = "set_TwoDigitYearMax", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GregorianCalendar), Member = "set_TwoDigitYearMax", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(HijriCalendar), Member = "set_TwoDigitYearMax", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JapaneseCalendar), Member = "set_TwoDigitYearMax", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TaiwanCalendar), Member = "set_TwoDigitYearMax", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ThaiBuddhistCalendar), Member = "set_TwoDigitYearMax", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UmAlQuraCalendar), Member = "set_TwoDigitYearMax", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	internal void VerifyWritable() { }

}

