namespace System.Xml;

internal abstract class BinXmlDateTime
{
	internal static Int32[] KatmaiTimeScaleMultiplicator; //Field offset: 0x0
	private static readonly double SQLTicksPerMillisecond; //Field offset: 0x8
	public static readonly int SQLTicksPerSecond; //Field offset: 0x10
	public static readonly int SQLTicksPerMinute; //Field offset: 0x14
	public static readonly int SQLTicksPerHour; //Field offset: 0x18
	private static readonly int SQLTicksPerDay; //Field offset: 0x1C

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(RuntimeFieldHandle)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private static BinXmlDateTime() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	[ContainsUnimplementedInstructions]
	private static void BreakDownXsdDate(long val, out int yr, out int mnth, out int day, out bool negTimeZone, out int hr, out int min) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	[ContainsUnimplementedInstructions]
	private static void BreakDownXsdDateTime(long val, out int yr, out int mnth, out int day, out int hr, out int min, out int sec, out int ms) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	[ContainsUnimplementedInstructions]
	private static void BreakDownXsdTime(long val, out int hr, out int min, out int sec, out int ms) { }

	[CalledBy(Type = typeof(BinXmlDateTime), Member = "XsdKatmaiDateTimeToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(BinXmlDateTime), Member = "XsdKatmaiTimeToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(XmlSqlBinaryReader), Member = "ValueAsDateTimeString", ReturnType = typeof(string))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(DateTime), Member = "get_Ticks", ReturnType = typeof(long))]
	[Calls(Type = typeof(DateTime), Member = "get_Year", ReturnType = typeof(int))]
	[Calls(Type = typeof(DateTime), Member = "get_Month", ReturnType = typeof(int))]
	[Calls(Type = typeof(DateTime), Member = "get_Day", ReturnType = typeof(int))]
	[Calls(Type = typeof(DateTime), Member = "get_Hour", ReturnType = typeof(int))]
	[Calls(Type = typeof(DateTime), Member = "get_Minute", ReturnType = typeof(int))]
	[Calls(Type = typeof(DateTime), Member = "get_Second", ReturnType = typeof(int))]
	[Calls(Type = typeof(DateTime), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	private static int GetFractions(DateTime dt) { }

	[CalledBy(Type = typeof(BinXmlDateTime), Member = "XsdKatmaiDateTimeOffsetToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(BinXmlDateTime), Member = "XsdKatmaiTimeOffsetToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(XmlSqlBinaryReader), Member = "ValueAsDateTimeString", ReturnType = typeof(string))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(DateTimeOffset), Member = "get_Ticks", ReturnType = typeof(long))]
	[Calls(Type = typeof(DateTimeOffset), Member = "get_Year", ReturnType = typeof(int))]
	[Calls(Type = typeof(DateTimeOffset), Member = "get_Month", ReturnType = typeof(int))]
	[Calls(Type = typeof(DateTimeOffset), Member = "get_Day", ReturnType = typeof(int))]
	[Calls(Type = typeof(DateTimeOffset), Member = "get_Hour", ReturnType = typeof(int))]
	[Calls(Type = typeof(DateTimeOffset), Member = "get_Minute", ReturnType = typeof(int))]
	[Calls(Type = typeof(DateTimeOffset), Member = "get_Second", ReturnType = typeof(int))]
	[Calls(Type = typeof(DateTime), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DateTime), Member = "get_Ticks", ReturnType = typeof(long))]
	private static int GetFractions(DateTimeOffset dt) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static long GetKatmaiDateTicks(Byte[] data, ref int pos) { }

	[CalledBy(Type = typeof(BinXmlDateTime), Member = "XsdKatmaiDateTimeToDateTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int)}, ReturnType = typeof(DateTime))]
	[CalledBy(Type = typeof(BinXmlDateTime), Member = "XsdKatmaiDateTimeOffsetToDateTimeOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int)}, ReturnType = typeof(DateTimeOffset))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(XmlException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 6)]
	private static long GetKatmaiTimeTicks(Byte[] data, ref int pos) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static long GetKatmaiTimeZoneTicks(Byte[] data, int pos) { }

	[CalledBy(Type = typeof(BinXmlDateTime), Member = "SqlDateTimeToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(uint)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(BinXmlDateTime), Member = "SqlSmallDateTimeToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(short), typeof(ushort)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(BinXmlDateTime), Member = "SqlSmallDateTimeToDateTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(short), typeof(ushort)}, ReturnType = typeof(DateTime))]
	[CalledBy(Type = typeof(XmlSqlBinaryReader), Member = "ValueAsDateTimeString", ReturnType = typeof(string))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(DateTime), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DateTime), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpan)}, ReturnType = typeof(DateTime))]
	[ContainsUnimplementedInstructions]
	public static DateTime SqlDateTimeToDateTime(int dateticks, uint timeticks) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BinXmlDateTime), Member = "SqlDateTimeToDateTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(uint)}, ReturnType = typeof(DateTime))]
	[Calls(Type = typeof(DateTime), Member = "get_Millisecond", ReturnType = typeof(int))]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(DateTime), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(string))]
	public static string SqlDateTimeToString(int dateticks, uint timeticks) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BinXmlDateTime), Member = "SqlDateTimeToDateTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(uint)}, ReturnType = typeof(DateTime))]
	public static DateTime SqlSmallDateTimeToDateTime(short dateticks, ushort timeticks) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BinXmlDateTime), Member = "SqlDateTimeToDateTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(uint)}, ReturnType = typeof(DateTime))]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(DateTime), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(string))]
	public static string SqlSmallDateTimeToString(short dateticks, ushort timeticks) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(StringBuilder))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	private static void Write2Dig(StringBuilder sb, int val) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(StringBuilder))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private static void Write3Dec(StringBuilder sb, int val) { }

	[CalledBy(Type = typeof(BinXmlDateTime), Member = "WriteDate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(StringBuilder))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private static void Write4DigNeg(StringBuilder sb, int val) { }

	[CalledBy(Type = typeof(BinXmlDateTime), Member = "XsdDateTimeToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(BinXmlDateTime), Member = "XsdDateToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(BinXmlDateTime), Member = "XsdKatmaiDateToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(BinXmlDateTime), Member = "XsdKatmaiDateTimeToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(BinXmlDateTime), Member = "XsdKatmaiDateOffsetToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(BinXmlDateTime), Member = "XsdKatmaiDateTimeOffsetToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(XmlSqlBinaryReader), Member = "ValueAsDateTimeString", ReturnType = typeof(string))]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(BinXmlDateTime), Member = "Write4DigNeg", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(StringBuilder))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private static void WriteDate(StringBuilder sb, int yr, int mnth, int day) { }

	[CalledBy(Type = typeof(BinXmlDateTime), Member = "XsdDateTimeToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(BinXmlDateTime), Member = "XsdTimeToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(string))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(StringBuilder))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private static void WriteTime(StringBuilder sb, int hr, int min, int sec, int ms) { }

	[CalledBy(Type = typeof(BinXmlDateTime), Member = "XsdKatmaiDateTimeToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(BinXmlDateTime), Member = "XsdKatmaiTimeToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(BinXmlDateTime), Member = "XsdKatmaiDateTimeOffsetToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(BinXmlDateTime), Member = "XsdKatmaiTimeOffsetToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(XmlSqlBinaryReader), Member = "ValueAsDateTimeString", ReturnType = typeof(string))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[])}, ReturnType = typeof(StringBuilder))]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	private static void WriteTimeFullPrecision(StringBuilder sb, int hr, int min, int sec, int fraction) { }

	[CalledBy(Type = typeof(BinXmlDateTime), Member = "WriteTimeZone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder), typeof(TimeSpan)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(StringBuilder))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private static void WriteTimeZone(StringBuilder sb, bool negTimeZone, int hr, int min) { }

	[CalledBy(Type = typeof(BinXmlDateTime), Member = "XsdKatmaiDateOffsetToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(BinXmlDateTime), Member = "XsdKatmaiDateTimeOffsetToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(BinXmlDateTime), Member = "XsdKatmaiTimeOffsetToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(XmlSqlBinaryReader), Member = "ValueAsDateTimeString", ReturnType = typeof(string))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(TimeSpan), Member = "Negate", ReturnType = typeof(TimeSpan))]
	[Calls(Type = typeof(TimeSpan), Member = "get_Hours", ReturnType = typeof(int))]
	[Calls(Type = typeof(TimeSpan), Member = "get_Minutes", ReturnType = typeof(int))]
	[Calls(Type = typeof(BinXmlDateTime), Member = "WriteTimeZone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder), typeof(bool), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	private static void WriteTimeZone(StringBuilder sb, TimeSpan zone) { }

	[CalledBy(Type = typeof(XmlSqlBinaryReader), Member = "ValueAsDateTimeString", ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BinXmlDateTime), Member = "WriteDate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(BinXmlDateTime), Member = "WriteTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder), typeof(int), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	[ContainsUnimplementedInstructions]
	public static string XsdDateTimeToString(long val) { }

	[CalledBy(Type = typeof(XmlSqlBinaryReader), Member = "ValueAsDateTimeString", ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BinXmlDateTime), Member = "WriteDate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(XmlException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	[ContainsUnimplementedInstructions]
	public static string XsdDateToString(long val) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BinXmlDateTime), Member = "XsdKatmaiDateTimeOffsetToDateTimeOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int)}, ReturnType = typeof(DateTimeOffset))]
	public static DateTimeOffset XsdKatmaiDateOffsetToDateTimeOffset(Byte[] data, int offset) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BinXmlDateTime), Member = "XsdKatmaiDateTimeOffsetToDateTimeOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int)}, ReturnType = typeof(DateTimeOffset))]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DateTimeOffset), Member = "get_Year", ReturnType = typeof(int))]
	[Calls(Type = typeof(DateTimeOffset), Member = "get_Month", ReturnType = typeof(int))]
	[Calls(Type = typeof(DateTimeOffset), Member = "get_Day", ReturnType = typeof(int))]
	[Calls(Type = typeof(BinXmlDateTime), Member = "WriteDate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DateTimeOffset), Member = "get_Offset", ReturnType = typeof(TimeSpan))]
	[Calls(Type = typeof(BinXmlDateTime), Member = "WriteTimeZone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder), typeof(TimeSpan)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static string XsdKatmaiDateOffsetToString(Byte[] data, int offset) { }

	[CalledBy(Type = typeof(BinXmlDateTime), Member = "XsdKatmaiDateOffsetToDateTimeOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int)}, ReturnType = typeof(DateTimeOffset))]
	[CalledBy(Type = typeof(BinXmlDateTime), Member = "XsdKatmaiTimeOffsetToDateTimeOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int)}, ReturnType = typeof(DateTimeOffset))]
	[CalledBy(Type = typeof(BinXmlDateTime), Member = "XsdKatmaiDateOffsetToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(BinXmlDateTime), Member = "XsdKatmaiDateTimeOffsetToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(BinXmlDateTime), Member = "XsdKatmaiTimeOffsetToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(XmlSqlBinaryReader), Member = "ValueAsDateTimeString", ReturnType = typeof(string))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(BinXmlDateTime), Member = "GetKatmaiTimeTicks", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(Int32&)}, ReturnType = typeof(long))]
	[Calls(Type = typeof(DateTimeOffset), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(TimeSpan)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	public static DateTimeOffset XsdKatmaiDateTimeOffsetToDateTimeOffset(Byte[] data, int offset) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BinXmlDateTime), Member = "WriteTimeZone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder), typeof(TimeSpan)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DateTimeOffset), Member = "get_Offset", ReturnType = typeof(TimeSpan))]
	[Calls(Type = typeof(BinXmlDateTime), Member = "WriteTimeFullPrecision", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder), typeof(int), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BinXmlDateTime), Member = "GetFractions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeOffset)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(DateTimeOffset), Member = "get_Second", ReturnType = typeof(int))]
	[Calls(Type = typeof(DateTimeOffset), Member = "get_Minute", ReturnType = typeof(int))]
	[Calls(Type = typeof(DateTimeOffset), Member = "get_Hour", ReturnType = typeof(int))]
	[Calls(Type = typeof(BinXmlDateTime), Member = "WriteDate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DateTimeOffset), Member = "get_Day", ReturnType = typeof(int))]
	[Calls(Type = typeof(DateTimeOffset), Member = "get_Month", ReturnType = typeof(int))]
	[Calls(Type = typeof(DateTimeOffset), Member = "get_Year", ReturnType = typeof(int))]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BinXmlDateTime), Member = "XsdKatmaiDateTimeOffsetToDateTimeOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int)}, ReturnType = typeof(DateTimeOffset))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(StringBuilder))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static string XsdKatmaiDateTimeOffsetToString(Byte[] data, int offset) { }

	[CalledBy(Type = typeof(BinXmlDateTime), Member = "XsdKatmaiTimeToDateTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int)}, ReturnType = typeof(DateTime))]
	[CalledBy(Type = typeof(BinXmlDateTime), Member = "XsdKatmaiDateTimeToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(BinXmlDateTime), Member = "XsdKatmaiTimeToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(XmlSqlBinaryReader), Member = "ValueAsDateTimeString", ReturnType = typeof(string))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(BinXmlDateTime), Member = "GetKatmaiTimeTicks", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(Int32&)}, ReturnType = typeof(long))]
	[Calls(Type = typeof(DateTime), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	public static DateTime XsdKatmaiDateTimeToDateTime(Byte[] data, int offset) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BinXmlDateTime), Member = "XsdKatmaiDateTimeToDateTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int)}, ReturnType = typeof(DateTime))]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DateTime), Member = "get_Year", ReturnType = typeof(int))]
	[Calls(Type = typeof(DateTime), Member = "get_Month", ReturnType = typeof(int))]
	[Calls(Type = typeof(DateTime), Member = "get_Day", ReturnType = typeof(int))]
	[Calls(Type = typeof(BinXmlDateTime), Member = "WriteDate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(DateTime), Member = "get_Hour", ReturnType = typeof(int))]
	[Calls(Type = typeof(DateTime), Member = "get_Minute", ReturnType = typeof(int))]
	[Calls(Type = typeof(DateTime), Member = "get_Second", ReturnType = typeof(int))]
	[Calls(Type = typeof(BinXmlDateTime), Member = "GetFractions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(BinXmlDateTime), Member = "WriteTimeFullPrecision", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder), typeof(int), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static string XsdKatmaiDateTimeToString(Byte[] data, int offset) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DateTime), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	public static DateTime XsdKatmaiDateToDateTime(Byte[] data, int offset) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DateTime), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DateTime), Member = "get_Year", ReturnType = typeof(int))]
	[Calls(Type = typeof(DateTime), Member = "get_Month", ReturnType = typeof(int))]
	[Calls(Type = typeof(DateTime), Member = "get_Day", ReturnType = typeof(int))]
	[Calls(Type = typeof(BinXmlDateTime), Member = "WriteDate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public static string XsdKatmaiDateToString(Byte[] data, int offset) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BinXmlDateTime), Member = "XsdKatmaiDateTimeOffsetToDateTimeOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int)}, ReturnType = typeof(DateTimeOffset))]
	public static DateTimeOffset XsdKatmaiTimeOffsetToDateTimeOffset(Byte[] data, int offset) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BinXmlDateTime), Member = "XsdKatmaiDateTimeOffsetToDateTimeOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int)}, ReturnType = typeof(DateTimeOffset))]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DateTimeOffset), Member = "get_Hour", ReturnType = typeof(int))]
	[Calls(Type = typeof(DateTimeOffset), Member = "get_Minute", ReturnType = typeof(int))]
	[Calls(Type = typeof(DateTimeOffset), Member = "get_Second", ReturnType = typeof(int))]
	[Calls(Type = typeof(BinXmlDateTime), Member = "GetFractions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeOffset)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(BinXmlDateTime), Member = "WriteTimeFullPrecision", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder), typeof(int), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DateTimeOffset), Member = "get_Offset", ReturnType = typeof(TimeSpan))]
	[Calls(Type = typeof(BinXmlDateTime), Member = "WriteTimeZone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder), typeof(TimeSpan)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static string XsdKatmaiTimeOffsetToString(Byte[] data, int offset) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BinXmlDateTime), Member = "XsdKatmaiDateTimeToDateTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int)}, ReturnType = typeof(DateTime))]
	public static DateTime XsdKatmaiTimeToDateTime(Byte[] data, int offset) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BinXmlDateTime), Member = "XsdKatmaiDateTimeToDateTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int)}, ReturnType = typeof(DateTime))]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DateTime), Member = "get_Hour", ReturnType = typeof(int))]
	[Calls(Type = typeof(DateTime), Member = "get_Minute", ReturnType = typeof(int))]
	[Calls(Type = typeof(DateTime), Member = "get_Second", ReturnType = typeof(int))]
	[Calls(Type = typeof(BinXmlDateTime), Member = "GetFractions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(BinXmlDateTime), Member = "WriteTimeFullPrecision", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder), typeof(int), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static string XsdKatmaiTimeToString(Byte[] data, int offset) { }

	[CalledBy(Type = typeof(XmlSqlBinaryReader), Member = "ValueAsDateTimeString", ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BinXmlDateTime), Member = "WriteTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder), typeof(int), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(XmlException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	[ContainsUnimplementedInstructions]
	public static string XsdTimeToString(long val) { }

}

