namespace ZXing.Client.Result;

public sealed class CalendarParsedResult : ParsedResult
{
	private static readonly Regex RFC2445_DURATION; //Field offset: 0x0
	private static readonly Int64[] RFC2445_DURATION_FIELD_UNITS; //Field offset: 0x8
	private static readonly Regex DATE_TIME; //Field offset: 0x10
	private readonly string summary; //Field offset: 0x20
	private readonly DateTime start; //Field offset: 0x28
	private readonly bool startAllDay; //Field offset: 0x30
	private readonly Nullable<DateTime> end; //Field offset: 0x38
	private readonly bool endAllDay; //Field offset: 0x48
	private readonly string location; //Field offset: 0x50
	private readonly string organizer; //Field offset: 0x58
	private readonly String[] attendees; //Field offset: 0x60
	private readonly string description; //Field offset: 0x68
	private readonly double latitude; //Field offset: 0x70
	private readonly double longitude; //Field offset: 0x78

	public String[] Attendees
	{
		[CallerCount(Count = 84)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public string Description
	{
		[CallerCount(Count = 22)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public Nullable<DateTime> End
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 11
	}

	public bool isEndAllDay
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public double Latitude
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 6
	}

	public string Location
	{
		[CallerCount(Count = 16)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public double Longitude
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 6
	}

	public string Organizer
	{
		[CallerCount(Count = 10)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public DateTime Start
	{
		[CallerCount(Count = 15)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public string Summary
	{
		[CallerCount(Count = 12)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Regex), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(RegexOptions)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(RuntimeFieldHandle)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	private static CalendarParsedResult() { }

	[CalledBy(Type = typeof(VEventResultParser), Member = "parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Result)}, ReturnType = typeof(ParsedResult))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TimeSpan), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CalendarParsedResult), Member = "parseDate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(DateTime))]
	[Calls(Type = typeof(Regex), Member = "Match", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Match))]
	[Calls(Type = typeof(Group), Member = "get_Success", ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(int), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(DateTime), Member = "op_Addition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(TimeSpan)}, ReturnType = typeof(DateTime))]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(CalendarParsedResult), Member = "format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(System.Nullable`1<System.DateTime>)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 16)]
	[CallsUnknownMethods(Count = 22)]
	[ContainsUnimplementedInstructions]
	public CalendarParsedResult(string summary, string startString, string endString, string durationString, string location, string organizer, String[] attendees, string description, double latitude, double longitude) { }

	[CallerCount(Count = 0)]
	private static string buildDateFormat() { }

	[CallerCount(Count = 0)]
	private static string buildDateTimeFormat() { }

	[CalledBy(Type = typeof(CalendarParsedResult), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(string), typeof(string), typeof(string), typeof(String[]), typeof(string), typeof(double), typeof(double)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Nullable`1), Member = "get_Value", ReturnType = "T")]
	[Calls(Type = typeof(CultureInfo), Member = "get_CurrentCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(DateTime), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(string))]
	private static string format(bool allDay, Nullable<DateTime> date) { }

	[CallerCount(Count = 84)]
	[DeduplicatedMethod]
	public String[] get_Attendees() { }

	[CallerCount(Count = 22)]
	[DeduplicatedMethod]
	public string get_Description() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public Nullable<DateTime> get_End() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public bool get_isEndAllDay() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public double get_Latitude() { }

	[CallerCount(Count = 16)]
	[DeduplicatedMethod]
	public string get_Location() { }

	[CallerCount(Count = 0)]
	public double get_Longitude() { }

	[CallerCount(Count = 10)]
	[DeduplicatedMethod]
	public string get_Organizer() { }

	[CallerCount(Count = 15)]
	[DeduplicatedMethod]
	public DateTime get_Start() { }

	[CallerCount(Count = 12)]
	[DeduplicatedMethod]
	public string get_Summary() { }

	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	public bool isStartAllDay() { }

	[CalledBy(Type = typeof(CalendarParsedResult), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(string), typeof(string), typeof(string), typeof(String[]), typeof(string), typeof(double), typeof(double)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Regex), Member = "Match", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Match))]
	[Calls(Type = typeof(Group), Member = "get_Success", ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(DateTime), Member = "ParseExact", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(DateTime))]
	[Calls(Type = typeof(TimeZoneInfo), Member = "get_Local", ReturnType = typeof(TimeZoneInfo))]
	[Calls(Type = typeof(TimeZoneInfo), Member = "ConvertTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(TimeZoneInfo)}, ReturnType = typeof(DateTime))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	private static DateTime parseDate(string when) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Regex), Member = "Match", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Match))]
	[Calls(Type = typeof(Group), Member = "get_Success", ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(int), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	private static long parseDurationMS(string durationString) { }

}

