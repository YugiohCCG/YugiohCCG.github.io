namespace System.Xml.Schema;

internal struct XsdDuration
{
	internal enum DurationType
	{
		Duration = 0,
		YearMonthDuration = 1,
		DayTimeDuration = 2,
	}

	private enum Parts
	{
		HasNone = 0,
		HasYears = 1,
		HasMonths = 2,
		HasDays = 4,
		HasHours = 8,
		HasMinutes = 16,
		HasSeconds = 32,
	}

	private int years; //Field offset: 0x0
	private int months; //Field offset: 0x4
	private int days; //Field offset: 0x8
	private int hours; //Field offset: 0xC
	private int minutes; //Field offset: 0x10
	private int seconds; //Field offset: 0x14
	private uint nanoseconds; //Field offset: 0x18

	public int Days
	{
		[CallerCount(Count = 28)]
		[DeduplicatedMethod]
		 get { } //Length: 4
	}

	public int Hours
	{
		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		 get { } //Length: 4
	}

	public bool IsNegative
	{
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 11
	}

	public int Minutes
	{
		[CallerCount(Count = 94)]
		[DeduplicatedMethod]
		 get { } //Length: 4
	}

	public int Months
	{
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 4
	}

	public int Nanoseconds
	{
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 8
	}

	public int Seconds
	{
		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		 get { } //Length: 4
	}

	public int Years
	{
		[CallerCount(Count = 173)]
		[DeduplicatedMethod]
		 get { } //Length: 3
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 28)]
	[ContainsUnimplementedInstructions]
	public XsdDuration(bool isNegative, int years, int months, int days, int hours, int minutes, int seconds, int nanoseconds) { }

	[CalledBy(Type = typeof(XmlConvert), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpan)}, ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[ContainsInvalidInstructions]
	public XsdDuration(TimeSpan timeSpan) { }

	[CalledBy(Type = typeof(XmlBaseConverter), Member = "DayTimeDurationToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpan)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(XmlBaseConverter), Member = "DurationToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpan)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(XmlBaseConverter), Member = "YearMonthDurationToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpan)}, ReturnType = typeof(string))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 8)]
	[ContainsUnimplementedInstructions]
	public XsdDuration(TimeSpan timeSpan, DurationType durationType) { }

	[CalledBy(Type = typeof(XmlConvert), Member = "ToTimeSpan", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(TimeSpan))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(XsdDuration), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(DurationType)}, ReturnType = typeof(void))]
	public XsdDuration(string s) { }

	[CalledBy(Type = typeof(XmlBaseConverter), Member = "StringToDayTimeDuration", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(TimeSpan))]
	[CalledBy(Type = typeof(XmlBaseConverter), Member = "StringToDuration", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(TimeSpan))]
	[CalledBy(Type = typeof(XmlBaseConverter), Member = "StringToYearMonthDuration", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(TimeSpan))]
	[CalledBy(Type = typeof(XsdDuration), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(XsdDuration), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(DurationType), typeof(XsdDuration&)}, ReturnType = typeof(Exception))]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	public XsdDuration(string s, DurationType durationType) { }

	[CallerCount(Count = 28)]
	[DeduplicatedMethod]
	public int get_Days() { }

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public int get_Hours() { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public bool get_IsNegative() { }

	[CallerCount(Count = 94)]
	[DeduplicatedMethod]
	public int get_Minutes() { }

	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	public int get_Months() { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public int get_Nanoseconds() { }

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public int get_Seconds() { }

	[CallerCount(Count = 173)]
	[DeduplicatedMethod]
	public int get_Years() { }

	[CalledBy(Type = typeof(XmlConvert), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpan)}, ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(XsdDuration), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DurationType)}, ReturnType = typeof(string))]
	public virtual string ToString() { }

	[CalledBy(Type = typeof(XmlBaseConverter), Member = "DayTimeDurationToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpan)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(XmlBaseConverter), Member = "DurationToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpan)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(XmlBaseConverter), Member = "YearMonthDurationToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpan)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(XsdDuration), Member = "ToString", ReturnType = typeof(string))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(XmlConvert), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(StringBuilder), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(StringBuilder), Member = "set_Length", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StringBuilder), Member = "set_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(char)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	internal string ToString(DurationType durationType) { }

	[CalledBy(Type = typeof(XmlConvert), Member = "ToTimeSpan", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(TimeSpan))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(XsdDuration), Member = "TryToTimeSpan", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DurationType), typeof(TimeSpan&)}, ReturnType = typeof(Exception))]
	[CallsUnknownMethods(Count = 2)]
	public TimeSpan ToTimeSpan() { }

	[CalledBy(Type = typeof(XmlBaseConverter), Member = "StringToDayTimeDuration", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(TimeSpan))]
	[CalledBy(Type = typeof(XmlBaseConverter), Member = "StringToDuration", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(TimeSpan))]
	[CalledBy(Type = typeof(XmlBaseConverter), Member = "StringToYearMonthDuration", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(TimeSpan))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(XsdDuration), Member = "TryToTimeSpan", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DurationType), typeof(TimeSpan&)}, ReturnType = typeof(Exception))]
	[CallsUnknownMethods(Count = 2)]
	public TimeSpan ToTimeSpan(DurationType durationType) { }

	[CalledBy(Type = typeof(Datatype_yearMonthDuration), Member = "TryParseValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(XmlNameTable), typeof(IXmlNamespaceResolver), typeof(Object&)}, ReturnType = typeof(Exception))]
	[CalledBy(Type = typeof(Datatype_dayTimeDuration), Member = "TryParseValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(XmlNameTable), typeof(IXmlNamespaceResolver), typeof(Object&)}, ReturnType = typeof(Exception))]
	[CalledBy(Type = typeof(XsdDuration), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(DurationType)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(string), Member = "Trim", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(Res), Member = "GetString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(OverflowException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FormatException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 21)]
	[ContainsUnimplementedInstructions]
	internal static Exception TryParse(string s, DurationType durationType, out XsdDuration result) { }

	[CalledBy(Type = typeof(XmlConvert), Member = "TryToTimeSpan", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(TimeSpan&)}, ReturnType = typeof(Exception))]
	[CallerCount(Count = 1)]
	[ContainsInvalidInstructions]
	internal static Exception TryParse(string s, out XsdDuration result) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private static string TryParseDigits(string s, ref int offset, bool eatDigits, out int result, out int numDigits) { }

	[CalledBy(Type = typeof(XmlConvert), Member = "TryToTimeSpan", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(TimeSpan&)}, ReturnType = typeof(Exception))]
	[CallerCount(Count = 1)]
	[ContainsInvalidInstructions]
	internal Exception TryToTimeSpan(out TimeSpan result) { }

	[CalledBy(Type = typeof(Datatype_yearMonthDuration), Member = "TryParseValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(XmlNameTable), typeof(IXmlNamespaceResolver), typeof(Object&)}, ReturnType = typeof(Exception))]
	[CalledBy(Type = typeof(Datatype_dayTimeDuration), Member = "TryParseValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(XmlNameTable), typeof(IXmlNamespaceResolver), typeof(Object&)}, ReturnType = typeof(Exception))]
	[CalledBy(Type = typeof(XsdDuration), Member = "ToTimeSpan", ReturnType = typeof(TimeSpan))]
	[CalledBy(Type = typeof(XsdDuration), Member = "ToTimeSpan", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DurationType)}, ReturnType = typeof(TimeSpan))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Res), Member = "GetString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(OverflowException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 52)]
	[ContainsUnimplementedInstructions]
	internal Exception TryToTimeSpan(DurationType durationType, out TimeSpan result) { }

}

