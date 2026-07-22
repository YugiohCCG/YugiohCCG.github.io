namespace System.Xml.Schema;

internal struct XsdDateTime
{
	private enum DateTimeTypeCode
	{
		DateTime = 0,
		Time = 1,
		Date = 2,
		GYearMonth = 3,
		GYear = 4,
		GMonthDay = 5,
		GDay = 6,
		GMonth = 7,
		XdrDateTime = 8,
	}

	private struct Parser
	{
		private static Int32[] Power10; //Field offset: 0x0
		public DateTimeTypeCode typeCode; //Field offset: 0x0
		public int year; //Field offset: 0x4
		public int month; //Field offset: 0x8
		public int day; //Field offset: 0xC
		public int hour; //Field offset: 0x10
		public int minute; //Field offset: 0x14
		public int second; //Field offset: 0x18
		public int fraction; //Field offset: 0x1C
		public XsdDateTimeKind kind; //Field offset: 0x20
		public int zoneHour; //Field offset: 0x24
		public int zoneMinute; //Field offset: 0x28
		private string text; //Field offset: 0x30
		private int length; //Field offset: 0x38

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(RuntimeFieldHandle)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		private static Parser() { }

		[CalledBy(Type = typeof(XsdDateTime), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(XsdDateTimeFlags)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XsdDateTime), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(XsdDateTimeFlags), typeof(XsdDateTime&)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
		[Calls(Type = typeof(char), Member = "IsWhiteSpace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Parser), Member = "ParseDate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Parser), Member = "ParseTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Parser), Member = "ParseZoneAndWhitespace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Parser), Member = "ParseTimeAndZoneAndWhitespace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Parser), Member = "Parse4Dig", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Int32&)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(DateTime), Member = "DaysInMonth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
		[CallsUnknownMethods(Count = 2)]
		public bool Parse(string text, XsdDateTimeFlags kinds) { }

		[CalledBy(Type = typeof(Parser), Member = "ParseDate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(Parser), Member = "ParseTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(Parser), Member = "ParseZoneAndWhitespace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 5)]
		[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
		[CallsUnknownMethods(Count = 1)]
		private bool Parse2Dig(int start, ref int num) { }

		[CalledBy(Type = typeof(Parser), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(XsdDateTimeFlags)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(Parser), Member = "ParseDate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
		[CallsUnknownMethods(Count = 1)]
		private bool Parse4Dig(int start, ref int num) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		private bool ParseChar(int start, char ch) { }

		[CalledBy(Type = typeof(Parser), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(XsdDateTimeFlags)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Parser), Member = "Parse4Dig", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Int32&)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
		[Calls(Type = typeof(Parser), Member = "Parse2Dig", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Int32&)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(DateTime), Member = "DaysInMonth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		private bool ParseDate(int start) { }

		[CalledBy(Type = typeof(Parser), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(XsdDateTimeFlags)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(Parser), Member = "ParseTimeAndZoneAndWhitespace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(Parser), Member = "ParseTimeAndWhitespace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 6)]
		[Calls(Type = typeof(Parser), Member = "Parse2Dig", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Int32&)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
		[CallsUnknownMethods(Count = 2)]
		private bool ParseTime(ref int start) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Parser), Member = "ParseTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&)}, ReturnType = typeof(bool))]
		[ContainsUnimplementedInstructions]
		private bool ParseTimeAndWhitespace(int start) { }

		[CalledBy(Type = typeof(Parser), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(XsdDateTimeFlags)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Parser), Member = "ParseTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Parser), Member = "ParseZoneAndWhitespace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
		[ContainsUnimplementedInstructions]
		private bool ParseTimeAndZoneAndWhitespace(int start) { }

		[CalledBy(Type = typeof(Parser), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(XsdDateTimeFlags)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(Parser), Member = "ParseTimeAndZoneAndWhitespace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 11)]
		[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
		[Calls(Type = typeof(Parser), Member = "Parse2Dig", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Int32&)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(char), Member = "IsWhiteSpace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		private bool ParseZoneAndWhitespace(int start) { }

		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		private static bool Test(XsdDateTimeFlags left, XsdDateTimeFlags right) { }

	}

	private enum XsdDateTimeKind
	{
		Unspecified = 0,
		Zulu = 1,
		LocalWestOfZulu = 2,
		LocalEastOfZulu = 3,
	}

	private static readonly int Lzyyyy; //Field offset: 0x0
	private static readonly int Lzyyyy_; //Field offset: 0x4
	private static readonly int Lzyyyy_MM; //Field offset: 0x8
	private static readonly int Lzyyyy_MM_; //Field offset: 0xC
	private static readonly int Lzyyyy_MM_dd; //Field offset: 0x10
	private static readonly int Lzyyyy_MM_ddT; //Field offset: 0x14
	private static readonly int LzHH; //Field offset: 0x18
	private static readonly int LzHH_; //Field offset: 0x1C
	private static readonly int LzHH_mm; //Field offset: 0x20
	private static readonly int LzHH_mm_; //Field offset: 0x24
	private static readonly int LzHH_mm_ss; //Field offset: 0x28
	private static readonly int Lz_; //Field offset: 0x2C
	private static readonly int Lz_zz; //Field offset: 0x30
	private static readonly int Lz_zz_; //Field offset: 0x34
	private static readonly int Lz_zz_zz; //Field offset: 0x38
	private static readonly int Lz__; //Field offset: 0x3C
	private static readonly int Lz__mm; //Field offset: 0x40
	private static readonly int Lz__mm_; //Field offset: 0x44
	private static readonly int Lz__mm__; //Field offset: 0x48
	private static readonly int Lz__mm_dd; //Field offset: 0x4C
	private static readonly int Lz___; //Field offset: 0x50
	private static readonly int Lz___dd; //Field offset: 0x54
	private static readonly XmlTypeCode[] typeCodes; //Field offset: 0x58
	private DateTime dt; //Field offset: 0x0
	private uint extra; //Field offset: 0x8

	public int Day
	{
		[CalledBy(Type = typeof(XsdDateTime), Member = "ToString", ReturnType = typeof(string))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(DateTime), Member = "get_Day", ReturnType = typeof(int))]
		 get { } //Length: 73
	}

	public int Fraction
	{
		[CalledBy(Type = typeof(XsdDateTime), Member = "PrintTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(DateTime), Member = "get_Ticks", ReturnType = typeof(long))]
		[Calls(Type = typeof(DateTime), Member = "get_Year", ReturnType = typeof(int))]
		[Calls(Type = typeof(DateTime), Member = "get_Month", ReturnType = typeof(int))]
		[Calls(Type = typeof(DateTime), Member = "get_Day", ReturnType = typeof(int))]
		[Calls(Type = typeof(DateTime), Member = "get_Hour", ReturnType = typeof(int))]
		[Calls(Type = typeof(DateTime), Member = "get_Minute", ReturnType = typeof(int))]
		[Calls(Type = typeof(DateTime), Member = "get_Second", ReturnType = typeof(int))]
		[Calls(Type = typeof(DateTime), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
		 get { } //Length: 279
	}

	public int Hour
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(DateTime), Member = "get_Hour", ReturnType = typeof(int))]
		 get { } //Length: 73
	}

	private XsdDateTimeKind InternalKind
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		private get { } //Length: 5
	}

	private DateTimeTypeCode InternalTypeCode
	{
		[CallerCount(Count = 0)]
		private get { } //Length: 7
	}

	public int Minute
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(DateTime), Member = "get_Minute", ReturnType = typeof(int))]
		 get { } //Length: 73
	}

	public int Month
	{
		[CalledBy(Type = typeof(XsdDateTime), Member = "ToString", ReturnType = typeof(string))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(DateTime), Member = "get_Month", ReturnType = typeof(int))]
		 get { } //Length: 73
	}

	public int Second
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(DateTime), Member = "get_Second", ReturnType = typeof(int))]
		 get { } //Length: 73
	}

	public int Year
	{
		[CalledBy(Type = typeof(XsdDateTime), Member = "ToString", ReturnType = typeof(string))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(DateTime), Member = "get_Year", ReturnType = typeof(int))]
		 get { } //Length: 73
	}

	public int ZoneHour
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public int ZoneMinute
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(RuntimeFieldHandle)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	private static XsdDateTime() { }

	[CalledBy(Type = typeof(XmlBaseConverter), Member = "TimeOffsetToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeOffset)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(XmlBaseConverter), Member = "DateOffsetToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeOffset)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(XmlBaseConverter), Member = "DateTimeOffsetToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeOffset)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(XmlBaseConverter), Member = "GDayOffsetToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeOffset)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(XmlBaseConverter), Member = "GMonthOffsetToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeOffset)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(XmlBaseConverter), Member = "GMonthDayOffsetToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeOffset)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(XmlBaseConverter), Member = "GYearOffsetToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeOffset)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(XmlBaseConverter), Member = "GYearMonthOffsetToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeOffset)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(XsdDateTime), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeOffset)}, ReturnType = typeof(void))]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(TimeSpan), Member = "Negate", ReturnType = typeof(TimeSpan))]
	[Calls(Type = typeof(TimeSpan), Member = "get_TotalMinutes", ReturnType = typeof(double))]
	[Calls(Type = typeof(Bits), Member = "LeastPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(TimeSpan), Member = "get_Minutes", ReturnType = typeof(int))]
	[Calls(Type = typeof(DateTimeOffset), Member = "get_DateTime", ReturnType = typeof(DateTime))]
	[Calls(Type = typeof(TimeSpan), Member = "get_Hours", ReturnType = typeof(int))]
	[Calls(Type = typeof(DateTimeOffset), Member = "get_Offset", ReturnType = typeof(TimeSpan))]
	[ContainsUnimplementedInstructions]
	public XsdDateTime(DateTimeOffset dateTimeOffset, XsdDateTimeFlags kinds) { }

	[CalledBy(Type = typeof(XmlConvert), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeOffset)}, ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(XsdDateTime), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeOffset), typeof(XsdDateTimeFlags)}, ReturnType = typeof(void))]
	public XsdDateTime(DateTimeOffset dateTimeOffset) { }

	[CalledBy(Type = typeof(XmlConvert), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(XmlDateTimeSerializationMode)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(XmlBaseConverter), Member = "GYearMonthToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(XmlBaseConverter), Member = "GYearToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(XmlBaseConverter), Member = "GMonthDayToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(XmlBaseConverter), Member = "TimeToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(XmlBaseConverter), Member = "GDayToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(XmlBaseConverter), Member = "DateTimeToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(XmlBaseConverter), Member = "DateToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(XmlBaseConverter), Member = "GMonthToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime)}, ReturnType = typeof(string))]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(TimeSpan), Member = "get_Minutes", ReturnType = typeof(int))]
	[Calls(Type = typeof(Bits), Member = "LeastPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(DateTime), Member = "get_Kind", ReturnType = typeof(DateTimeKind))]
	[Calls(Type = typeof(TimeZoneInfo), Member = "get_Local", ReturnType = typeof(TimeZoneInfo))]
	[Calls(Type = typeof(TimeZoneInfo), Member = "GetUtcOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime)}, ReturnType = typeof(TimeSpan))]
	[Calls(Type = typeof(TimeSpan), Member = "get_Hours", ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 1)]
	public XsdDateTime(DateTime dateTime, XsdDateTimeFlags kinds) { }

	[CallerCount(Count = 20)]
	[Calls(Type = typeof(Parser), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(XsdDateTimeFlags)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(XsdDateTime), Member = "InitiateXsdDateTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Parser)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Res), Member = "GetString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(FormatException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 12)]
	public XsdDateTime(string text, XsdDateTimeFlags kinds) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XsdDateTime), Member = "InitiateXsdDateTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Parser)}, ReturnType = typeof(void))]
	private XsdDateTime(Parser parser) { }

	[CalledBy(Type = typeof(XsdDateTime), Member = "ToString", ReturnType = typeof(string))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(DateTime), Member = "get_Day", ReturnType = typeof(int))]
	public int get_Day() { }

	[CalledBy(Type = typeof(XsdDateTime), Member = "PrintTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DateTime), Member = "get_Ticks", ReturnType = typeof(long))]
	[Calls(Type = typeof(DateTime), Member = "get_Year", ReturnType = typeof(int))]
	[Calls(Type = typeof(DateTime), Member = "get_Month", ReturnType = typeof(int))]
	[Calls(Type = typeof(DateTime), Member = "get_Day", ReturnType = typeof(int))]
	[Calls(Type = typeof(DateTime), Member = "get_Hour", ReturnType = typeof(int))]
	[Calls(Type = typeof(DateTime), Member = "get_Minute", ReturnType = typeof(int))]
	[Calls(Type = typeof(DateTime), Member = "get_Second", ReturnType = typeof(int))]
	[Calls(Type = typeof(DateTime), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	public int get_Fraction() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DateTime), Member = "get_Hour", ReturnType = typeof(int))]
	public int get_Hour() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	private XsdDateTimeKind get_InternalKind() { }

	[CallerCount(Count = 0)]
	private DateTimeTypeCode get_InternalTypeCode() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DateTime), Member = "get_Minute", ReturnType = typeof(int))]
	public int get_Minute() { }

	[CalledBy(Type = typeof(XsdDateTime), Member = "ToString", ReturnType = typeof(string))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(DateTime), Member = "get_Month", ReturnType = typeof(int))]
	public int get_Month() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DateTime), Member = "get_Second", ReturnType = typeof(int))]
	public int get_Second() { }

	[CalledBy(Type = typeof(XsdDateTime), Member = "ToString", ReturnType = typeof(string))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(DateTime), Member = "get_Year", ReturnType = typeof(int))]
	public int get_Year() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public int get_ZoneHour() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public int get_ZoneMinute() { }

	[CalledBy(Type = typeof(XsdDateTime), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(XsdDateTimeFlags)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XsdDateTime), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Parser)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(DateTime), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DateTime), Member = "AddTicks", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(DateTime))]
	private void InitiateXsdDateTime(Parser parser) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	private void IntToCharArray(Char[] text, int start, int value, int digits) { }

	[CalledBy(Type = typeof(XmlConvert), Member = "ToDateTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(XmlDateTimeSerializationMode)}, ReturnType = typeof(DateTime))]
	[CalledBy(Type = typeof(XmlBaseConverter), Member = "UntypedAtomicToDateTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(DateTime))]
	[CalledBy(Type = typeof(XmlBaseConverter), Member = "StringToTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(DateTime))]
	[CalledBy(Type = typeof(XmlBaseConverter), Member = "StringToGYear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(DateTime))]
	[CalledBy(Type = typeof(XmlBaseConverter), Member = "StringToGMonthDay", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(DateTime))]
	[CalledBy(Type = typeof(XmlBaseConverter), Member = "StringToGYearMonth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(DateTime))]
	[CalledBy(Type = typeof(XmlBaseConverter), Member = "StringToGDay", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(DateTime))]
	[CalledBy(Type = typeof(XmlBaseConverter), Member = "StringToDateTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(DateTime))]
	[CalledBy(Type = typeof(XmlBaseConverter), Member = "StringToDate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(DateTime))]
	[CalledBy(Type = typeof(Datatype_dateTimeBase), Member = "TryParseValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(XmlNameTable), typeof(IXmlNamespaceResolver), typeof(Object&)}, ReturnType = typeof(Exception))]
	[CalledBy(Type = typeof(XmlBaseConverter), Member = "StringToGMonth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(DateTime))]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(DateTime), Member = "get_Ticks", ReturnType = typeof(long))]
	[Calls(Type = typeof(DateTime), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(DateTimeKind)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TimeZoneInfo), Member = "GetUtcOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime)}, ReturnType = typeof(TimeSpan))]
	[Calls(Type = typeof(TimeZoneInfo), Member = "get_Local", ReturnType = typeof(TimeZoneInfo))]
	[Calls(Type = typeof(TimeSpan), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DateTime), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpan)}, ReturnType = typeof(DateTime))]
	[Calls(Type = typeof(DateTime), Member = "get_Now", ReturnType = typeof(DateTime))]
	[Calls(Type = typeof(DateTime), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DateTime), Member = "get_Day", ReturnType = typeof(int))]
	[Calls(Type = typeof(DateTime), Member = "get_Month", ReturnType = typeof(int))]
	[Calls(Type = typeof(DateTime), Member = "get_Year", ReturnType = typeof(int))]
	[Calls(Type = typeof(DateTime), Member = "ToLocalTime", ReturnType = typeof(DateTime))]
	[Calls(Type = typeof(DateTime), Member = "op_Subtraction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(DateTime)}, ReturnType = typeof(TimeSpan))]
	[CallsUnknownMethods(Count = 1)]
	public static DateTime op_Implicit(XsdDateTime xdt) { }

	[CalledBy(Type = typeof(XmlConvert), Member = "ToDateTimeOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(DateTimeOffset))]
	[CalledBy(Type = typeof(XmlBaseConverter), Member = "StringToDateOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(DateTimeOffset))]
	[CalledBy(Type = typeof(XmlBaseConverter), Member = "StringToDateTimeOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(DateTimeOffset))]
	[CalledBy(Type = typeof(XmlBaseConverter), Member = "StringToGDayOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(DateTimeOffset))]
	[CalledBy(Type = typeof(XmlBaseConverter), Member = "StringToGMonthOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(DateTimeOffset))]
	[CalledBy(Type = typeof(XmlBaseConverter), Member = "StringToGMonthDayOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(DateTimeOffset))]
	[CalledBy(Type = typeof(XmlBaseConverter), Member = "StringToGYearOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(DateTimeOffset))]
	[CalledBy(Type = typeof(XmlBaseConverter), Member = "StringToGYearMonthOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(DateTimeOffset))]
	[CalledBy(Type = typeof(XmlBaseConverter), Member = "StringToTimeOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(DateTimeOffset))]
	[CalledBy(Type = typeof(XmlBaseConverter), Member = "UntypedAtomicToDateTimeOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(DateTimeOffset))]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(TimeZoneInfo), Member = "GetUtcOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime)}, ReturnType = typeof(TimeSpan))]
	[Calls(Type = typeof(TimeZoneInfo), Member = "get_Local", ReturnType = typeof(TimeZoneInfo))]
	[Calls(Type = typeof(TimeSpan), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DateTime), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpan)}, ReturnType = typeof(DateTime))]
	[Calls(Type = typeof(DateTime), Member = "op_Subtraction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(DateTime)}, ReturnType = typeof(TimeSpan))]
	[Calls(Type = typeof(DateTime), Member = "get_Now", ReturnType = typeof(DateTime))]
	[Calls(Type = typeof(DateTime), Member = "get_Day", ReturnType = typeof(int))]
	[Calls(Type = typeof(DateTime), Member = "get_Month", ReturnType = typeof(int))]
	[Calls(Type = typeof(DateTime), Member = "get_Year", ReturnType = typeof(int))]
	[Calls(Type = typeof(DateTimeOffset), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(TimeSpan)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DateTime), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public static DateTimeOffset op_Implicit(XsdDateTime xdt) { }

	[CalledBy(Type = typeof(XsdDateTime), Member = "ToString", ReturnType = typeof(string))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(DateTime), Member = "get_Year", ReturnType = typeof(int))]
	[Calls(Type = typeof(DateTime), Member = "get_Month", ReturnType = typeof(int))]
	[Calls(Type = typeof(DateTime), Member = "get_Day", ReturnType = typeof(int))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[])}, ReturnType = typeof(StringBuilder))]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	private void PrintDate(StringBuilder sb) { }

	[CalledBy(Type = typeof(XsdDateTime), Member = "ToString", ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DateTime), Member = "get_Hour", ReturnType = typeof(int))]
	[Calls(Type = typeof(DateTime), Member = "get_Minute", ReturnType = typeof(int))]
	[Calls(Type = typeof(DateTime), Member = "get_Second", ReturnType = typeof(int))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[])}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(XsdDateTime), Member = "get_Fraction", ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	private void PrintTime(StringBuilder sb) { }

	[CalledBy(Type = typeof(XsdDateTime), Member = "ToString", ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[])}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(StringBuilder))]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	private void PrintZone(StringBuilder sb) { }

	[CalledBy(Type = typeof(XsdDateTime), Member = "ToString", ReturnType = typeof(string))]
	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	private void ShortToCharArray(Char[] text, int start, int value) { }

	[CalledBy(Type = typeof(XmlBaseConverter), Member = "GYearOffsetToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeOffset)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(XmlBaseConverter), Member = "TimeOffsetToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeOffset)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(XmlBaseConverter), Member = "TimeToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(XmlBaseConverter), Member = "GYearMonthOffsetToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeOffset)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(XmlBaseConverter), Member = "GMonthOffsetToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeOffset)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(XmlBaseConverter), Member = "GDayOffsetToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeOffset)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(XmlBaseConverter), Member = "DateTimeOffsetToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeOffset)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(XmlBaseConverter), Member = "DateOffsetToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeOffset)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(XmlBaseConverter), Member = "GYearMonthToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(XmlBaseConverter), Member = "GMonthDayOffsetToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeOffset)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(XmlBaseConverter), Member = "GMonthDayToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(XmlBaseConverter), Member = "GMonthToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(XmlBaseConverter), Member = "GDayToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(XmlBaseConverter), Member = "DateTimeToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(XmlBaseConverter), Member = "GYearToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(XmlConvert), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(XmlDateTimeSerializationMode)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(XmlBaseConverter), Member = "DateToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(XmlConvert), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeOffset)}, ReturnType = typeof(string))]
	[CallerCount(Count = 18)]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[])}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XsdDateTime), Member = "PrintDate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(XsdDateTime), Member = "PrintTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XsdDateTime), Member = "PrintZone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XsdDateTime), Member = "get_Year", ReturnType = typeof(int))]
	[Calls(Type = typeof(XsdDateTime), Member = "get_Month", ReturnType = typeof(int))]
	[Calls(Type = typeof(XsdDateTime), Member = "ShortToCharArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XsdDateTime), Member = "get_Day", ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	public virtual string ToString() { }

	[CalledBy(Type = typeof(Datatype_dateTimeBase), Member = "TryParseValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(XmlNameTable), typeof(IXmlNamespaceResolver), typeof(Object&)}, ReturnType = typeof(Exception))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Parser), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(XsdDateTimeFlags)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DateTime), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DateTime), Member = "AddTicks", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(DateTime))]
	[ContainsUnimplementedInstructions]
	internal static bool TryParse(string text, XsdDateTimeFlags kinds, out XsdDateTime result) { }

}

