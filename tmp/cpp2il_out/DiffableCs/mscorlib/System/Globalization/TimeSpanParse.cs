namespace System.Globalization;

internal static class TimeSpanParse
{
	private enum ParseFailureKind
	{
		None = 0,
		ArgumentNull = 1,
		Format = 2,
		FormatWithParameter = 3,
		Overflow = 4,
	}

	[IsByRefLike]
	[Obsolete("Types with embedded references are not supported in this version of your compiler.", True)]
	private struct StringParser
	{
		private ReadOnlySpan<Char> _str; //Field offset: 0x0
		private char _ch; //Field offset: 0x10
		private int _pos; //Field offset: 0x14
		private int _len; //Field offset: 0x18

		[CalledBy(Type = typeof(StringParser), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(TimeSpanResult&)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(StringParser), Member = "ParseInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Int32&), typeof(TimeSpanResult&)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(StringParser), Member = "ParseTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int64&), typeof(TimeSpanResult&)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 7)]
		[CallsUnknownMethods(Count = 1)]
		internal void NextChar() { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		internal char NextNonDigit() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(StringParser), Member = "NextChar", ReturnType = typeof(void))]
		[Calls(Type = "System.Globalization.TimeSpanParse+TimeSpanResult", Member = "SetFailure", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Globalization.TimeSpanParse+ParseFailureKind", typeof(string), typeof(object), typeof(string)}, ReturnType = typeof(bool))]
		internal bool ParseInt(int max, out int i, ref TimeSpanResult result) { }

		[CalledBy(Type = typeof(StringParser), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(TimeSpanResult&)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(StringParser), Member = "NextChar", ReturnType = typeof(void))]
		[Calls(Type = "System.Globalization.TimeSpanParse+TimeSpanResult", Member = "SetFailure", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Globalization.TimeSpanParse+ParseFailureKind", typeof(string), typeof(object), typeof(string)}, ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		internal bool ParseTime(out long time, ref TimeSpanResult result) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		internal void SkipBlanks() { }

		[CalledBy(Type = typeof(TimeSpanParse), Member = "TryParseExact", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(System.ReadOnlySpan`1<System.Char>), typeof(IFormatProvider), typeof(TimeSpanStyles), typeof(TimeSpan&)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(TimeSpanParse), Member = "TryParseExactTimeSpan", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(System.ReadOnlySpan`1<System.Char>), typeof(IFormatProvider), typeof(TimeSpanStyles), typeof(TimeSpanResult&)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(TimeSpanParse), Member = "TryParseTimeSpanConstant", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(TimeSpanResult&)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(StringParser), Member = "NextChar", ReturnType = typeof(void))]
		[Calls(Type = typeof(StringParser), Member = "ParseTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int64&), typeof(TimeSpanResult&)}, ReturnType = typeof(bool))]
		[Calls(Type = "System.Globalization.TimeSpanParse+TimeSpanResult", Member = "SetFailure", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Globalization.TimeSpanParse+ParseFailureKind", typeof(string), typeof(object), typeof(string)}, ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 1)]
		internal bool TryParse(ReadOnlySpan<Char> input, ref TimeSpanResult result) { }

	}

	[IsByRefLike]
	[Obsolete("Types with embedded references are not supported in this version of your compiler.", True)]
	private struct TimeSpanRawInfo
	{
		internal TTT _lastSeenTTT; //Field offset: 0x0
		internal int _tokenCount; //Field offset: 0x4
		internal int _sepCount; //Field offset: 0x8
		internal int _numCount; //Field offset: 0xC
		private FormatLiterals _posLoc; //Field offset: 0x10
		private FormatLiterals _negLoc; //Field offset: 0x38
		private bool _posLocInit; //Field offset: 0x60
		private bool _negLocInit; //Field offset: 0x61
		private string _fullPosPattern; //Field offset: 0x68
		private string _fullNegPattern; //Field offset: 0x70
		internal TimeSpanToken _numbers0; //Field offset: 0x78
		internal TimeSpanToken _numbers1; //Field offset: 0x98
		internal TimeSpanToken _numbers2; //Field offset: 0xB8
		internal TimeSpanToken _numbers3; //Field offset: 0xD8
		internal TimeSpanToken _numbers4; //Field offset: 0xF8
		internal ReadOnlySpan<Char> _literals0; //Field offset: 0x118
		internal ReadOnlySpan<Char> _literals1; //Field offset: 0x128
		internal ReadOnlySpan<Char> _literals2; //Field offset: 0x138
		internal ReadOnlySpan<Char> _literals3; //Field offset: 0x148
		internal ReadOnlySpan<Char> _literals4; //Field offset: 0x158
		internal ReadOnlySpan<Char> _literals5; //Field offset: 0x168

		internal FormatLiterals NegativeInvariant
		{
			[CallerCount(Count = 0)]
			internal get { } //Length: 109
		}

		internal FormatLiterals NegativeLocalized
		{
			[CalledBy(Type = typeof(TimeSpanParse), Member = "TryParseTimeSpan", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), "System.Globalization.TimeSpanParse+TimeSpanStandardStyles", typeof(IFormatProvider), typeof(TimeSpanResult&)}, ReturnType = typeof(bool))]
			[CalledBy(Type = typeof(TimeSpanParse), Member = "ProcessTerminal_DHMSF", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpanRawInfo&), "System.Globalization.TimeSpanParse+TimeSpanStandardStyles", typeof(TimeSpanResult&)}, ReturnType = typeof(bool))]
			[CalledBy(Type = typeof(TimeSpanParse), Member = "ProcessTerminal_HMS_F_D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpanRawInfo&), "System.Globalization.TimeSpanParse+TimeSpanStandardStyles", typeof(TimeSpanResult&)}, ReturnType = typeof(bool))]
			[CalledBy(Type = typeof(TimeSpanParse), Member = "ProcessTerminal_HM_S_D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpanRawInfo&), "System.Globalization.TimeSpanParse+TimeSpanStandardStyles", typeof(TimeSpanResult&)}, ReturnType = typeof(bool))]
			[CalledBy(Type = typeof(TimeSpanParse), Member = "ProcessTerminal_HM", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpanRawInfo&), "System.Globalization.TimeSpanParse+TimeSpanStandardStyles", typeof(TimeSpanResult&)}, ReturnType = typeof(bool))]
			[CalledBy(Type = typeof(TimeSpanParse), Member = "ProcessTerminal_D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpanRawInfo&), "System.Globalization.TimeSpanParse+TimeSpanStandardStyles", typeof(TimeSpanResult&)}, ReturnType = typeof(bool))]
			[CallerCount(Count = 11)]
			[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
			[Calls(Type = typeof(FormatLiterals), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(bool)}, ReturnType = typeof(void))]
			internal get { } //Length: 198
		}

		internal FormatLiterals PositiveInvariant
		{
			[CallerCount(Count = 0)]
			internal get { } //Length: 108
		}

		internal FormatLiterals PositiveLocalized
		{
			[CalledBy(Type = typeof(TimeSpanParse), Member = "TryParseTimeSpan", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), "System.Globalization.TimeSpanParse+TimeSpanStandardStyles", typeof(IFormatProvider), typeof(TimeSpanResult&)}, ReturnType = typeof(bool))]
			[CalledBy(Type = typeof(TimeSpanParse), Member = "ProcessTerminal_DHMSF", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpanRawInfo&), "System.Globalization.TimeSpanParse+TimeSpanStandardStyles", typeof(TimeSpanResult&)}, ReturnType = typeof(bool))]
			[CalledBy(Type = typeof(TimeSpanParse), Member = "ProcessTerminal_HMS_F_D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpanRawInfo&), "System.Globalization.TimeSpanParse+TimeSpanStandardStyles", typeof(TimeSpanResult&)}, ReturnType = typeof(bool))]
			[CalledBy(Type = typeof(TimeSpanParse), Member = "ProcessTerminal_HM_S_D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpanRawInfo&), "System.Globalization.TimeSpanParse+TimeSpanStandardStyles", typeof(TimeSpanResult&)}, ReturnType = typeof(bool))]
			[CalledBy(Type = typeof(TimeSpanParse), Member = "ProcessTerminal_HM", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpanRawInfo&), "System.Globalization.TimeSpanParse+TimeSpanStandardStyles", typeof(TimeSpanResult&)}, ReturnType = typeof(bool))]
			[CalledBy(Type = typeof(TimeSpanParse), Member = "ProcessTerminal_D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpanRawInfo&), "System.Globalization.TimeSpanParse+TimeSpanStandardStyles", typeof(TimeSpanResult&)}, ReturnType = typeof(bool))]
			[CallerCount(Count = 11)]
			[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
			[Calls(Type = typeof(FormatLiterals), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(bool)}, ReturnType = typeof(void))]
			internal get { } //Length: 198
		}

		[CallerCount(Count = 0)]
		[Calls(Type = "System.Globalization.TimeSpanParse+TimeSpanResult", Member = "SetFailure", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Globalization.TimeSpanParse+ParseFailureKind", typeof(string), typeof(object), typeof(string)}, ReturnType = typeof(bool))]
		private bool AddNum(TimeSpanToken num, ref TimeSpanResult result) { }

		[CalledBy(Type = typeof(TimeSpanRawInfo), Member = "ProcessToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpanToken&), typeof(TimeSpanResult&)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 2)]
		[Calls(Type = "System.Globalization.TimeSpanParse+TimeSpanResult", Member = "SetFailure", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Globalization.TimeSpanParse+ParseFailureKind", typeof(string), typeof(object), typeof(string)}, ReturnType = typeof(bool))]
		private bool AddSep(ReadOnlySpan<Char> sep, ref TimeSpanResult result) { }

		[CalledBy(Type = typeof(TimeSpanParse), Member = "ProcessTerminal_HMS_F_D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpanRawInfo&), "System.Globalization.TimeSpanParse+TimeSpanStandardStyles", typeof(TimeSpanResult&)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
		[CallsUnknownMethods(Count = 7)]
		internal bool FullAppCompatMatch(FormatLiterals pattern) { }

		[CalledBy(Type = typeof(TimeSpanParse), Member = "ProcessTerminal_HM_S_D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpanRawInfo&), "System.Globalization.TimeSpanParse+TimeSpanStandardStyles", typeof(TimeSpanResult&)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
		[CallsUnknownMethods(Count = 6)]
		internal bool FullDHMMatch(FormatLiterals pattern) { }

		[CalledBy(Type = typeof(TimeSpanParse), Member = "ProcessTerminal_HMS_F_D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpanRawInfo&), "System.Globalization.TimeSpanParse+TimeSpanStandardStyles", typeof(TimeSpanResult&)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
		[CallsUnknownMethods(Count = 7)]
		internal bool FullDHMSMatch(FormatLiterals pattern) { }

		[CalledBy(Type = typeof(TimeSpanParse), Member = "ProcessTerminal_D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpanRawInfo&), "System.Globalization.TimeSpanParse+TimeSpanStandardStyles", typeof(TimeSpanResult&)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
		[CallsUnknownMethods(Count = 4)]
		internal bool FullDMatch(FormatLiterals pattern) { }

		[CalledBy(Type = typeof(TimeSpanParse), Member = "ProcessTerminal_HM", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpanRawInfo&), "System.Globalization.TimeSpanParse+TimeSpanStandardStyles", typeof(TimeSpanResult&)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
		[CallsUnknownMethods(Count = 5)]
		internal bool FullHMMatch(FormatLiterals pattern) { }

		[CalledBy(Type = typeof(TimeSpanParse), Member = "ProcessTerminal_HMS_F_D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpanRawInfo&), "System.Globalization.TimeSpanParse+TimeSpanStandardStyles", typeof(TimeSpanResult&)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
		[CallsUnknownMethods(Count = 7)]
		internal bool FullHMSFMatch(FormatLiterals pattern) { }

		[CalledBy(Type = typeof(TimeSpanParse), Member = "ProcessTerminal_HM_S_D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpanRawInfo&), "System.Globalization.TimeSpanParse+TimeSpanStandardStyles", typeof(TimeSpanResult&)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
		[CallsUnknownMethods(Count = 6)]
		internal bool FullHMSMatch(FormatLiterals pattern) { }

		[CalledBy(Type = typeof(TimeSpanParse), Member = "ProcessTerminal_DHMSF", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpanRawInfo&), "System.Globalization.TimeSpanParse+TimeSpanStandardStyles", typeof(TimeSpanResult&)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
		[CallsUnknownMethods(Count = 8)]
		internal bool FullMatch(FormatLiterals pattern) { }

		[CallerCount(Count = 0)]
		internal FormatLiterals get_NegativeInvariant() { }

		[CalledBy(Type = typeof(TimeSpanParse), Member = "TryParseTimeSpan", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), "System.Globalization.TimeSpanParse+TimeSpanStandardStyles", typeof(IFormatProvider), typeof(TimeSpanResult&)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(TimeSpanParse), Member = "ProcessTerminal_DHMSF", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpanRawInfo&), "System.Globalization.TimeSpanParse+TimeSpanStandardStyles", typeof(TimeSpanResult&)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(TimeSpanParse), Member = "ProcessTerminal_HMS_F_D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpanRawInfo&), "System.Globalization.TimeSpanParse+TimeSpanStandardStyles", typeof(TimeSpanResult&)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(TimeSpanParse), Member = "ProcessTerminal_HM_S_D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpanRawInfo&), "System.Globalization.TimeSpanParse+TimeSpanStandardStyles", typeof(TimeSpanResult&)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(TimeSpanParse), Member = "ProcessTerminal_HM", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpanRawInfo&), "System.Globalization.TimeSpanParse+TimeSpanStandardStyles", typeof(TimeSpanResult&)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(TimeSpanParse), Member = "ProcessTerminal_D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpanRawInfo&), "System.Globalization.TimeSpanParse+TimeSpanStandardStyles", typeof(TimeSpanResult&)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 11)]
		[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
		[Calls(Type = typeof(FormatLiterals), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(bool)}, ReturnType = typeof(void))]
		internal FormatLiterals get_NegativeLocalized() { }

		[CallerCount(Count = 0)]
		internal FormatLiterals get_PositiveInvariant() { }

		[CalledBy(Type = typeof(TimeSpanParse), Member = "TryParseTimeSpan", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), "System.Globalization.TimeSpanParse+TimeSpanStandardStyles", typeof(IFormatProvider), typeof(TimeSpanResult&)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(TimeSpanParse), Member = "ProcessTerminal_DHMSF", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpanRawInfo&), "System.Globalization.TimeSpanParse+TimeSpanStandardStyles", typeof(TimeSpanResult&)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(TimeSpanParse), Member = "ProcessTerminal_HMS_F_D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpanRawInfo&), "System.Globalization.TimeSpanParse+TimeSpanStandardStyles", typeof(TimeSpanResult&)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(TimeSpanParse), Member = "ProcessTerminal_HM_S_D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpanRawInfo&), "System.Globalization.TimeSpanParse+TimeSpanStandardStyles", typeof(TimeSpanResult&)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(TimeSpanParse), Member = "ProcessTerminal_HM", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpanRawInfo&), "System.Globalization.TimeSpanParse+TimeSpanStandardStyles", typeof(TimeSpanResult&)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(TimeSpanParse), Member = "ProcessTerminal_D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpanRawInfo&), "System.Globalization.TimeSpanParse+TimeSpanStandardStyles", typeof(TimeSpanResult&)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 11)]
		[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
		[Calls(Type = typeof(FormatLiterals), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(bool)}, ReturnType = typeof(void))]
		internal FormatLiterals get_PositiveLocalized() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(DateTimeFormatInfo), Member = "get_FullTimeSpanPositivePattern", ReturnType = typeof(string))]
		[Calls(Type = typeof(DateTimeFormatInfo), Member = "get_FullTimeSpanNegativePattern", ReturnType = typeof(string))]
		[CallsUnknownMethods(Count = 1)]
		internal void Init(DateTimeFormatInfo dtfi) { }

		[CalledBy(Type = typeof(TimeSpanParse), Member = "ProcessTerminal_HM_S_D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpanRawInfo&), "System.Globalization.TimeSpanParse+TimeSpanStandardStyles", typeof(TimeSpanResult&)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
		[CallsUnknownMethods(Count = 6)]
		internal bool PartialAppCompatMatch(FormatLiterals pattern) { }

		[CalledBy(Type = typeof(TimeSpanParse), Member = "TryParseTimeSpan", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), "System.Globalization.TimeSpanParse+TimeSpanStandardStyles", typeof(IFormatProvider), typeof(TimeSpanResult&)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(TimeSpanParse), Member = "ProcessTerminalState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpanRawInfo&), "System.Globalization.TimeSpanParse+TimeSpanStandardStyles", typeof(TimeSpanResult&)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 3)]
		[Calls(Type = "System.Globalization.TimeSpanParse+TimeSpanResult", Member = "SetFailure", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Globalization.TimeSpanParse+ParseFailureKind", typeof(string), typeof(object), typeof(string)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(TimeSpanRawInfo), Member = "AddSep", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(TimeSpanResult&)}, ReturnType = typeof(bool))]
		internal bool ProcessToken(ref TimeSpanToken tok, ref TimeSpanResult result) { }

	}

	private struct TimeSpanResult
	{
		internal TimeSpan parsedTimeSpan; //Field offset: 0x0
		private readonly bool _throwOnFailure; //Field offset: 0x8

		[CallerCount(Count = 0)]
		internal TimeSpanResult(bool throwOnFailure) { }

		[CalledBy(Type = "System.Globalization.TimeSpanParse+TimeSpanRawInfo", Member = "ProcessToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpanToken&), typeof(TimeSpanResult&)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(TimeSpanParse), Member = "TryParseByFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(System.ReadOnlySpan`1<System.Char>), typeof(TimeSpanStyles), typeof(TimeSpanResult&)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(TimeSpanParse), Member = "TryParseExactTimeSpan", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(System.ReadOnlySpan`1<System.Char>), typeof(IFormatProvider), typeof(TimeSpanStyles), typeof(TimeSpanResult&)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(TimeSpanParse), Member = "ProcessTerminal_D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpanRawInfo&), "System.Globalization.TimeSpanParse+TimeSpanStandardStyles", typeof(TimeSpanResult&)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(TimeSpanParse), Member = "ProcessTerminal_HM", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpanRawInfo&), "System.Globalization.TimeSpanParse+TimeSpanStandardStyles", typeof(TimeSpanResult&)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(TimeSpanParse), Member = "ProcessTerminal_HMS_F_D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpanRawInfo&), "System.Globalization.TimeSpanParse+TimeSpanStandardStyles", typeof(TimeSpanResult&)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(TimeSpanParse), Member = "ProcessTerminal_DHMSF", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpanRawInfo&), "System.Globalization.TimeSpanParse+TimeSpanStandardStyles", typeof(TimeSpanResult&)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(TimeSpanParse), Member = "ProcessTerminal_HM_S_D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpanRawInfo&), "System.Globalization.TimeSpanParse+TimeSpanStandardStyles", typeof(TimeSpanResult&)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(TimeSpanParse), Member = "TryParseTimeSpan", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), "System.Globalization.TimeSpanParse+TimeSpanStandardStyles", typeof(IFormatProvider), typeof(TimeSpanResult&)}, ReturnType = typeof(bool))]
		[CalledBy(Type = "System.Globalization.TimeSpanParse+StringParser", Member = "ParseTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int64&), typeof(TimeSpanResult&)}, ReturnType = typeof(bool))]
		[CalledBy(Type = "System.Globalization.TimeSpanParse+StringParser", Member = "ParseInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Int32&), typeof(TimeSpanResult&)}, ReturnType = typeof(bool))]
		[CalledBy(Type = "System.Globalization.TimeSpanParse+StringParser", Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(TimeSpanResult&)}, ReturnType = typeof(bool))]
		[CalledBy(Type = "System.Globalization.TimeSpanParse+TimeSpanRawInfo", Member = "AddNum", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Globalization.TimeSpanParse+TimeSpanToken", typeof(TimeSpanResult&)}, ReturnType = typeof(bool))]
		[CalledBy(Type = "System.Globalization.TimeSpanParse+TimeSpanRawInfo", Member = "AddSep", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(TimeSpanResult&)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(TimeSpanParse), Member = "ProcessTerminalState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpanRawInfo&), "System.Globalization.TimeSpanParse+TimeSpanStandardStyles", typeof(TimeSpanResult&)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 27)]
		[Calls(Type = typeof(OverflowException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(SR), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(FormatException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 12)]
		internal bool SetFailure(ParseFailureKind kind, string resourceKey, object messageArgument = null, string argumentName = null) { }

	}

	[Flags]
	private enum TimeSpanStandardStyles
	{
		None = 0,
		Invariant = 1,
		Localized = 2,
		RequireFull = 4,
		Any = 3,
	}

	[IsByRefLike]
	[Obsolete("Types with embedded references are not supported in this version of your compiler.", True)]
	private struct TimeSpanToken
	{
		internal TTT _ttt; //Field offset: 0x0
		internal int _num; //Field offset: 0x4
		internal int _zeroes; //Field offset: 0x8
		internal ReadOnlySpan<Char> _sep; //Field offset: 0x10

		[CallerCount(Count = 0)]
		public TimeSpanToken(TTT type) { }

		[CallerCount(Count = 0)]
		public TimeSpanToken(int number) { }

		[CallerCount(Count = 0)]
		public TimeSpanToken(int number, int leadingZeroes) { }

		[CallerCount(Count = 0)]
		public TimeSpanToken(TTT type, int number, int leadingZeroes, ReadOnlySpan<Char> separator) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(TimeSpanParse), Member = "Pow10", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(long))]
		[ContainsUnimplementedInstructions]
		public bool IsInvalidFraction() { }

	}

	[IsByRefLike]
	[Obsolete("Types with embedded references are not supported in this version of your compiler.", True)]
	private struct TimeSpanTokenizer
	{
		private ReadOnlySpan<Char> _value; //Field offset: 0x0
		private int _pos; //Field offset: 0x10

		internal bool EOL
		{
			[CallerCount(Count = 0)]
			[ContainsUnimplementedInstructions]
			internal get { } //Length: 54
		}

		internal char NextChar
		{
			[CalledBy(Type = typeof(TimeSpanParse), Member = "TryParseByFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(System.ReadOnlySpan`1<System.Char>), typeof(TimeSpanStyles), typeof(TimeSpanResult&)}, ReturnType = typeof(bool))]
			[CallerCount(Count = 4)]
			internal get { } //Length: 74
		}

		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		internal TimeSpanTokenizer(ReadOnlySpan<Char> input) { }

		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		internal TimeSpanTokenizer(ReadOnlySpan<Char> input, int startPosition) { }

		[CallerCount(Count = 0)]
		internal void BackOne() { }

		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		internal bool get_EOL() { }

		[CalledBy(Type = typeof(TimeSpanParse), Member = "TryParseByFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(System.ReadOnlySpan`1<System.Char>), typeof(TimeSpanStyles), typeof(TimeSpanResult&)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 4)]
		internal char get_NextChar() { }

		[CalledBy(Type = typeof(TimeSpanParse), Member = "TryParseTimeSpan", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), "System.Globalization.TimeSpanParse+TimeSpanStandardStyles", typeof(IFormatProvider), typeof(TimeSpanResult&)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 2)]
		internal TimeSpanToken GetNextToken() { }

	}

	private enum TTT
	{
		None = 0,
		End = 1,
		Num = 2,
		Sep = 3,
		NumOverflow = 4,
	}


	[CalledBy(Type = typeof(TimeSpan), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(TimeSpan))]
	[CalledBy(Type = typeof(TimeSpan), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(TimeSpan))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(TimeSpanParse), Member = "TryParseTimeSpan", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(TimeSpanStandardStyles), typeof(IFormatProvider), typeof(TimeSpanResult&)}, ReturnType = typeof(bool))]
	internal static TimeSpan Parse(ReadOnlySpan<Char> input, IFormatProvider formatProvider) { }

	[CalledBy(Type = typeof(TimeSpanParse), Member = "TryParseByFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(System.ReadOnlySpan`1<System.Char>), typeof(TimeSpanStyles), typeof(TimeSpanResult&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 3)]
	[ContainsUnimplementedInstructions]
	private static bool ParseExactDigits(ref TimeSpanTokenizer tokenizer, int minDigitLength, int maxDigitLength, out int zeroes, out int result) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	private static bool ParseExactDigits(ref TimeSpanTokenizer tokenizer, int minDigitLength, out int result) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StringBuilder), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private static bool ParseExactLiteral(ref TimeSpanTokenizer tokenizer, StringBuilder enquotedString) { }

	[CalledBy(Type = typeof(DateTimeParse), Member = "ParseFractionExact", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(__DTString&), typeof(int), typeof(Double&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DateTimeParse), Member = "ParseByFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(__DTString&), typeof(__DTString&), typeof(ParsingInfo&), typeof(DateTimeFormatInfo), typeof(DateTimeResult&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TimeSpanFormat), Member = "FormatStandard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpan), typeof(bool), typeof(System.ReadOnlySpan`1<System.Char>), typeof(Pattern)}, ReturnType = typeof(StringBuilder))]
	[CalledBy(Type = typeof(TimeSpanFormat), Member = "FormatCustomized", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpan), typeof(System.ReadOnlySpan`1<System.Char>), typeof(DateTimeFormatInfo), typeof(StringBuilder)}, ReturnType = typeof(StringBuilder))]
	[CalledBy(Type = typeof(TimeSpanToken), Member = "IsInvalidFraction", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TimeSpanParse), Member = "TryTimeToTicks", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(TimeSpanToken), typeof(TimeSpanToken), typeof(TimeSpanToken), typeof(TimeSpanToken), typeof(TimeSpanToken), typeof(Int64&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TimeSpanParse), Member = "ProcessTerminal_DHMSF", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpanRawInfo&), typeof(TimeSpanStandardStyles), typeof(TimeSpanResult&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TimeSpanParse), Member = "ProcessTerminal_HMS_F_D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpanRawInfo&), typeof(TimeSpanStandardStyles), typeof(TimeSpanResult&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TimeSpanParse), Member = "ProcessTerminal_HM_S_D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpanRawInfo&), typeof(TimeSpanStandardStyles), typeof(TimeSpanResult&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TimeSpanParse), Member = "TryParseByFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(System.ReadOnlySpan`1<System.Char>), typeof(TimeSpanStyles), typeof(TimeSpanResult&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 36)]
	[ContainsInvalidInstructions]
	internal static long Pow10(int pow) { }

	[CalledBy(Type = typeof(TimeSpanParse), Member = "ProcessTerminalState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpanRawInfo&), typeof(TimeSpanStandardStyles), typeof(TimeSpanResult&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TimeSpanRawInfo), Member = "FullDMatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FormatLiterals)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TimeSpanRawInfo), Member = "get_PositiveLocalized", ReturnType = typeof(FormatLiterals))]
	[Calls(Type = typeof(TimeSpanRawInfo), Member = "get_NegativeLocalized", ReturnType = typeof(FormatLiterals))]
	[Calls(Type = typeof(TimeSpanResult), Member = "SetFailure", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParseFailureKind), typeof(string), typeof(object), typeof(string)}, ReturnType = typeof(bool))]
	private static bool ProcessTerminal_D(ref TimeSpanRawInfo raw, TimeSpanStandardStyles style, ref TimeSpanResult result) { }

	[CalledBy(Type = typeof(TimeSpanParse), Member = "TryParseTimeSpan", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(TimeSpanStandardStyles), typeof(IFormatProvider), typeof(TimeSpanResult&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TimeSpanRawInfo), Member = "FullMatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FormatLiterals)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TimeSpanRawInfo), Member = "get_PositiveLocalized", ReturnType = typeof(FormatLiterals))]
	[Calls(Type = typeof(TimeSpanRawInfo), Member = "get_NegativeLocalized", ReturnType = typeof(FormatLiterals))]
	[Calls(Type = typeof(TimeSpanParse), Member = "Pow10", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(long))]
	[Calls(Type = typeof(TimeSpanResult), Member = "SetFailure", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParseFailureKind), typeof(string), typeof(object), typeof(string)}, ReturnType = typeof(bool))]
	[ContainsUnimplementedInstructions]
	private static bool ProcessTerminal_DHMSF(ref TimeSpanRawInfo raw, TimeSpanStandardStyles style, ref TimeSpanResult result) { }

	[CalledBy(Type = typeof(TimeSpanParse), Member = "ProcessTerminalState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpanRawInfo&), typeof(TimeSpanStandardStyles), typeof(TimeSpanResult&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TimeSpanRawInfo), Member = "FullHMMatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FormatLiterals)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TimeSpanRawInfo), Member = "get_PositiveLocalized", ReturnType = typeof(FormatLiterals))]
	[Calls(Type = typeof(TimeSpanRawInfo), Member = "get_NegativeLocalized", ReturnType = typeof(FormatLiterals))]
	[Calls(Type = typeof(TimeSpanResult), Member = "SetFailure", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParseFailureKind), typeof(string), typeof(object), typeof(string)}, ReturnType = typeof(bool))]
	private static bool ProcessTerminal_HM(ref TimeSpanRawInfo raw, TimeSpanStandardStyles style, ref TimeSpanResult result) { }

	[CalledBy(Type = typeof(TimeSpanParse), Member = "TryParseTimeSpan", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(TimeSpanStandardStyles), typeof(IFormatProvider), typeof(TimeSpanResult&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TimeSpanParse), Member = "ProcessTerminalState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpanRawInfo&), typeof(TimeSpanStandardStyles), typeof(TimeSpanResult&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(TimeSpanRawInfo), Member = "FullHMSMatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FormatLiterals)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TimeSpanRawInfo), Member = "FullDHMMatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FormatLiterals)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TimeSpanRawInfo), Member = "PartialAppCompatMatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FormatLiterals)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TimeSpanParse), Member = "Pow10", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(long))]
	[Calls(Type = typeof(TimeSpanRawInfo), Member = "get_PositiveLocalized", ReturnType = typeof(FormatLiterals))]
	[Calls(Type = typeof(TimeSpanRawInfo), Member = "get_NegativeLocalized", ReturnType = typeof(FormatLiterals))]
	[Calls(Type = typeof(TimeSpanResult), Member = "SetFailure", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParseFailureKind), typeof(string), typeof(object), typeof(string)}, ReturnType = typeof(bool))]
	[ContainsUnimplementedInstructions]
	private static bool ProcessTerminal_HM_S_D(ref TimeSpanRawInfo raw, TimeSpanStandardStyles style, ref TimeSpanResult result) { }

	[CalledBy(Type = typeof(TimeSpanParse), Member = "TryParseTimeSpan", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(TimeSpanStandardStyles), typeof(IFormatProvider), typeof(TimeSpanResult&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TimeSpanParse), Member = "ProcessTerminalState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpanRawInfo&), typeof(TimeSpanStandardStyles), typeof(TimeSpanResult&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(TimeSpanRawInfo), Member = "FullHMSFMatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FormatLiterals)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TimeSpanParse), Member = "Pow10", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(long))]
	[Calls(Type = typeof(TimeSpanRawInfo), Member = "FullDHMSMatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FormatLiterals)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TimeSpanRawInfo), Member = "FullAppCompatMatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FormatLiterals)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TimeSpanRawInfo), Member = "get_PositiveLocalized", ReturnType = typeof(FormatLiterals))]
	[Calls(Type = typeof(TimeSpanRawInfo), Member = "get_NegativeLocalized", ReturnType = typeof(FormatLiterals))]
	[Calls(Type = typeof(TimeSpanResult), Member = "SetFailure", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParseFailureKind), typeof(string), typeof(object), typeof(string)}, ReturnType = typeof(bool))]
	[ContainsUnimplementedInstructions]
	private static bool ProcessTerminal_HMS_F_D(ref TimeSpanRawInfo raw, TimeSpanStandardStyles style, ref TimeSpanResult result) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TimeSpanRawInfo), Member = "ProcessToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpanToken&), typeof(TimeSpanResult&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TimeSpanResult), Member = "SetFailure", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParseFailureKind), typeof(string), typeof(object), typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TimeSpanParse), Member = "ProcessTerminal_HMS_F_D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpanRawInfo&), typeof(TimeSpanStandardStyles), typeof(TimeSpanResult&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TimeSpanParse), Member = "ProcessTerminal_HM_S_D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpanRawInfo&), typeof(TimeSpanStandardStyles), typeof(TimeSpanResult&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TimeSpanParse), Member = "ProcessTerminal_HM", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpanRawInfo&), typeof(TimeSpanStandardStyles), typeof(TimeSpanResult&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TimeSpanParse), Member = "ProcessTerminal_D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpanRawInfo&), typeof(TimeSpanStandardStyles), typeof(TimeSpanResult&)}, ReturnType = typeof(bool))]
	[ContainsInvalidInstructions]
	private static bool ProcessTerminalState(ref TimeSpanRawInfo raw, TimeSpanStandardStyles style, ref TimeSpanResult result) { }

	[CalledBy(Type = typeof(TimeSpanParse), Member = "TryParseExact", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(System.ReadOnlySpan`1<System.Char>), typeof(IFormatProvider), typeof(TimeSpanStyles), typeof(TimeSpan&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TimeSpanParse), Member = "TryParseExactTimeSpan", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(System.ReadOnlySpan`1<System.Char>), typeof(IFormatProvider), typeof(TimeSpanStyles), typeof(TimeSpanResult&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(DateTimeFormat), Member = "ParseRepeatPattern", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(int), typeof(char)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(TimeSpanParse), Member = "ParseExactDigits", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpanTokenizer&), typeof(int), typeof(int), typeof(Int32&), typeof(Int32&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DateTimeFormat), Member = "ParseNextChar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(TimeSpanTokenizer), Member = "get_NextChar", ReturnType = typeof(char))]
	[Calls(Type = typeof(StringBuilderCache), Member = "Acquire", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(DateTimeParse), Member = "TryParseQuoteString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(int), typeof(StringBuilder), typeof(Int32&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(StringBuilder), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(StringBuilderCache), Member = "Release", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TimeSpanParse), Member = "Pow10", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(long))]
	[Calls(Type = typeof(TimeSpanResult), Member = "SetFailure", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParseFailureKind), typeof(string), typeof(object), typeof(string)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	private static bool TryParseByFormat(ReadOnlySpan<Char> input, ReadOnlySpan<Char> format, TimeSpanStyles styles, ref TimeSpanResult result) { }

	[CalledBy(Type = typeof(TimeSpan), Member = "TryParseExact", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(IFormatProvider), typeof(TimeSpanStyles), typeof(TimeSpan&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TimeSpanParse), Member = "TryParseByFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(System.ReadOnlySpan`1<System.Char>), typeof(TimeSpanStyles), typeof(TimeSpanResult&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TimeSpanParse), Member = "TryParseTimeSpan", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(TimeSpanStandardStyles), typeof(IFormatProvider), typeof(TimeSpanResult&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(StringParser), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(TimeSpanResult&)}, ReturnType = typeof(bool))]
	internal static bool TryParseExact(ReadOnlySpan<Char> input, ReadOnlySpan<Char> format, IFormatProvider formatProvider, TimeSpanStyles styles, out TimeSpan result) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TimeSpanParse), Member = "TryParseByFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(System.ReadOnlySpan`1<System.Char>), typeof(TimeSpanStyles), typeof(TimeSpanResult&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TimeSpanParse), Member = "TryParseTimeSpan", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(TimeSpanStandardStyles), typeof(IFormatProvider), typeof(TimeSpanResult&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(StringParser), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(TimeSpanResult&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TimeSpanResult), Member = "SetFailure", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParseFailureKind), typeof(string), typeof(object), typeof(string)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	private static bool TryParseExactTimeSpan(ReadOnlySpan<Char> input, ReadOnlySpan<Char> format, IFormatProvider formatProvider, TimeSpanStyles styles, ref TimeSpanResult result) { }

	[CalledBy(Type = typeof(TimeSpanParse), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(IFormatProvider)}, ReturnType = typeof(TimeSpan))]
	[CalledBy(Type = typeof(TimeSpanParse), Member = "TryParseExact", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(System.ReadOnlySpan`1<System.Char>), typeof(IFormatProvider), typeof(TimeSpanStyles), typeof(TimeSpan&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TimeSpanParse), Member = "TryParseExactTimeSpan", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(System.ReadOnlySpan`1<System.Char>), typeof(IFormatProvider), typeof(TimeSpanStyles), typeof(TimeSpanResult&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(TimeSpanResult), Member = "SetFailure", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParseFailureKind), typeof(string), typeof(object), typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TimeSpanRawInfo), Member = "get_NegativeLocalized", ReturnType = typeof(FormatLiterals))]
	[Calls(Type = typeof(TimeSpanRawInfo), Member = "get_PositiveLocalized", ReturnType = typeof(FormatLiterals))]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[Calls(Type = typeof(TimeSpanParse), Member = "ProcessTerminal_HM_S_D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpanRawInfo&), typeof(TimeSpanStandardStyles), typeof(TimeSpanResult&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TimeSpanParse), Member = "ProcessTerminal_HMS_F_D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpanRawInfo&), typeof(TimeSpanStandardStyles), typeof(TimeSpanResult&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TimeSpanRawInfo), Member = "ProcessToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpanToken&), typeof(TimeSpanResult&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TimeSpanTokenizer), Member = "GetNextToken", ReturnType = typeof(TimeSpanToken))]
	[Calls(Type = typeof(DateTimeFormatInfo), Member = "get_FullTimeSpanNegativePattern", ReturnType = typeof(string))]
	[Calls(Type = typeof(DateTimeFormatInfo), Member = "get_FullTimeSpanPositivePattern", ReturnType = typeof(string))]
	[Calls(Type = typeof(DateTimeFormatInfo), Member = "GetInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(DateTimeFormatInfo))]
	[Calls(Type = typeof(MemoryExtensions), Member = "Trim", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>)}, ReturnType = typeof(System.ReadOnlySpan`1<System.Char>))]
	[Calls(Type = typeof(TimeSpanParse), Member = "ProcessTerminal_DHMSF", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpanRawInfo&), typeof(TimeSpanStandardStyles), typeof(TimeSpanResult&)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 24)]
	private static bool TryParseTimeSpan(ReadOnlySpan<Char> input, TimeSpanStandardStyles style, IFormatProvider formatProvider, ref TimeSpanResult result) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StringParser), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(TimeSpanResult&)}, ReturnType = typeof(bool))]
	private static bool TryParseTimeSpanConstant(ReadOnlySpan<Char> input, ref TimeSpanResult result) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TimeSpanParse), Member = "Pow10", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(long))]
	[ContainsUnimplementedInstructions]
	private static bool TryTimeToTicks(bool positive, TimeSpanToken days, TimeSpanToken hours, TimeSpanToken minutes, TimeSpanToken seconds, TimeSpanToken fraction, out long result) { }

}

