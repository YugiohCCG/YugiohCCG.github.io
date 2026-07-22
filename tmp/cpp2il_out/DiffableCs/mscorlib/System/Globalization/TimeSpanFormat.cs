namespace System.Globalization;

internal static class TimeSpanFormat
{
	public struct FormatLiterals
	{
		internal string AppCompatLiteral; //Field offset: 0x0
		internal int dd; //Field offset: 0x8
		internal int hh; //Field offset: 0xC
		internal int mm; //Field offset: 0x10
		internal int ss; //Field offset: 0x14
		internal int ff; //Field offset: 0x18
		private String[] _literals; //Field offset: 0x20

		internal string DayHourSep
		{
			[CallerCount(Count = 3)]
			[CallsUnknownMethods(Count = 2)]
			[DeduplicatedMethod]
			internal get { } //Length: 39
		}

		internal string End
		{
			[CallerCount(Count = 1)]
			[CallsUnknownMethods(Count = 2)]
			[DeduplicatedMethod]
			internal get { } //Length: 39
		}

		internal string HourMinuteSep
		{
			[CallerCount(Count = 6)]
			[CallsUnknownMethods(Count = 2)]
			[DeduplicatedMethod]
			internal get { } //Length: 39
		}

		internal string MinuteSecondSep
		{
			[CallerCount(Count = 9)]
			[CallsUnknownMethods(Count = 2)]
			[DeduplicatedMethod]
			internal get { } //Length: 39
		}

		internal string SecondFractionSep
		{
			[CallerCount(Count = 8)]
			[CallsUnknownMethods(Count = 2)]
			[DeduplicatedMethod]
			internal get { } //Length: 39
		}

		internal string Start
		{
			[CallerCount(Count = 4)]
			[CallsUnknownMethods(Count = 2)]
			[DeduplicatedMethod]
			internal get { } //Length: 39
		}

		[CallerCount(Count = 3)]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		internal string get_DayHourSep() { }

		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		internal string get_End() { }

		[CallerCount(Count = 6)]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		internal string get_HourMinuteSep() { }

		[CallerCount(Count = 9)]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		internal string get_MinuteSecondSep() { }

		[CallerCount(Count = 8)]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		internal string get_SecondFractionSep() { }

		[CallerCount(Count = 4)]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		internal string get_Start() { }

		[CalledBy(Type = typeof(TimeSpanFormat), Member = "FormatStandard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpan), typeof(bool), typeof(System.ReadOnlySpan`1<System.Char>), typeof(Pattern)}, ReturnType = typeof(StringBuilder))]
		[CalledBy(Type = "System.Globalization.TimeSpanParse+TimeSpanRawInfo", Member = "get_PositiveLocalized", ReturnType = typeof(FormatLiterals))]
		[CalledBy(Type = "System.Globalization.TimeSpanParse+TimeSpanRawInfo", Member = "get_NegativeLocalized", ReturnType = typeof(FormatLiterals))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(StringBuilderCache), Member = "Acquire", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(StringBuilder))]
		[Calls(Type = typeof(StringBuilder), Member = "set_Length", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(StringBuilder))]
		[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(StringBuilderCache), Member = "Release", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 6)]
		internal void Init(ReadOnlySpan<Char> format, bool useInvariantFieldLengths) { }

		[CalledBy(Type = typeof(TimeSpanFormat), Member = ".cctor", ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[CallsUnknownMethods(Count = 10)]
		internal static FormatLiterals InitInvariant(bool isNegative) { }

	}

	public enum Pattern
	{
		None = 0,
		Minimum = 1,
		Full = 2,
	}

	internal static readonly FormatLiterals PositiveInvariantFormatLiterals; //Field offset: 0x0
	internal static readonly FormatLiterals NegativeInvariantFormatLiterals; //Field offset: 0x28

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FormatLiterals), Member = "InitInvariant", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(FormatLiterals))]
	[CallsUnknownMethods(Count = 2)]
	private static TimeSpanFormat() { }

	[CalledBy(Type = typeof(TimeSpanFormat), Member = "FormatStandard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpan), typeof(bool), typeof(System.ReadOnlySpan`1<System.Char>), typeof(Pattern)}, ReturnType = typeof(StringBuilder))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(StringBuilder))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private static void AppendNonNegativeInt32(StringBuilder sb, int n, int digits) { }

	[CalledBy(Type = typeof(TimeSpan), Member = "ToString", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(TimeSpan), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[Calls(Type = typeof(TimeSpanFormat), Member = "FormatToBuilder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpan), typeof(System.ReadOnlySpan`1<System.Char>), typeof(IFormatProvider)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(StringBuilderCache), Member = "GetStringAndRelease", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder)}, ReturnType = typeof(string))]
	internal static string Format(TimeSpan value, string format, IFormatProvider formatProvider) { }

	[CalledBy(Type = typeof(TimeSpanFormat), Member = "FormatToBuilder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpan), typeof(System.ReadOnlySpan`1<System.Char>), typeof(IFormatProvider)}, ReturnType = typeof(StringBuilder))]
	[CalledBy(Type = typeof(TimeSpanFormat), Member = "FormatCustomized", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpan), typeof(System.ReadOnlySpan`1<System.Char>), typeof(DateTimeFormatInfo), typeof(StringBuilder)}, ReturnType = typeof(StringBuilder))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(TimeSpanParse), Member = "Pow10", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(long))]
	[Calls(Type = typeof(DateTimeFormat), Member = "ParseQuoteString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(int), typeof(StringBuilder)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(DateTimeFormat), Member = "FormatDigits", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder), typeof(int), typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(long), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(TimeSpanFormat), Member = "FormatCustomized", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpan), typeof(System.ReadOnlySpan`1<System.Char>), typeof(DateTimeFormatInfo), typeof(StringBuilder)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(DateTimeFormat), Member = "ParseNextChar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(DateTimeFormat), Member = "FormatDigits", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DateTimeFormat), Member = "ParseRepeatPattern", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(int), typeof(char)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(StringBuilderCache), Member = "Acquire", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(FormatException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StringBuilderCache), Member = "Release", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 6)]
	[ContainsUnimplementedInstructions]
	private static StringBuilder FormatCustomized(TimeSpan value, ReadOnlySpan<Char> format, DateTimeFormatInfo dtfi, StringBuilder result) { }

	[CalledBy(Type = typeof(TimeSpanFormat), Member = "FormatToBuilder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpan), typeof(System.ReadOnlySpan`1<System.Char>), typeof(IFormatProvider)}, ReturnType = typeof(StringBuilder))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(StringBuilderCache), Member = "Acquire", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(FormatLiterals), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TimeSpanParse), Member = "Pow10", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(long))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(TimeSpanFormat), Member = "AppendNonNegativeInt32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(int), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	private static StringBuilder FormatStandard(TimeSpan value, bool isInvariant, ReadOnlySpan<Char> format, Pattern pattern) { }

	[CalledBy(Type = typeof(TimeSpanFormat), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpan), typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(TimeSpanFormat), Member = "TryFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpan), typeof(System.Span`1<System.Char>), typeof(Int32&), typeof(System.ReadOnlySpan`1<System.Char>), typeof(IFormatProvider)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[Calls(Type = typeof(DateTimeFormatInfo), Member = "GetInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(DateTimeFormatInfo))]
	[Calls(Type = typeof(TimeSpanFormat), Member = "FormatCustomized", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpan), typeof(System.ReadOnlySpan`1<System.Char>), typeof(DateTimeFormatInfo), typeof(StringBuilder)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(DateTimeFormatInfo), Member = "get_FullTimeSpanNegativePattern", ReturnType = typeof(string))]
	[Calls(Type = typeof(DateTimeFormatInfo), Member = "get_FullTimeSpanPositivePattern", ReturnType = typeof(string))]
	[Calls(Type = typeof(TimeSpanFormat), Member = "FormatStandard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpan), typeof(bool), typeof(System.ReadOnlySpan`1<System.Char>), typeof(Pattern)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(FormatException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 6)]
	[ContainsUnimplementedInstructions]
	private static StringBuilder FormatToBuilder(TimeSpan value, ReadOnlySpan<Char> format, IFormatProvider formatProvider) { }

	[CalledBy(Type = typeof(TimeSpan), Member = "TryFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Span`1<System.Char>), typeof(Int32&), typeof(System.ReadOnlySpan`1<System.Char>), typeof(IFormatProvider)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TimeSpanFormat), Member = "FormatToBuilder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpan), typeof(System.ReadOnlySpan`1<System.Char>), typeof(IFormatProvider)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(StringBuilderCache), Member = "Release", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StringBuilder), Member = "CopyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(System.Span`1<System.Char>), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	internal static bool TryFormat(TimeSpan value, Span<Char> destination, out int charsWritten, ReadOnlySpan<Char> format, IFormatProvider formatProvider) { }

}

