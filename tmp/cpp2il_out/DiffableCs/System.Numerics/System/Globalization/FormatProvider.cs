namespace System.Globalization;

internal class FormatProvider
{
	private class Number
	{
		public struct NumberBuffer
		{
			public int precision; //Field offset: 0x0
			public int scale; //Field offset: 0x4
			public bool sign; //Field offset: 0x8
			public Char* overrideDigits; //Field offset: 0x10

			public Char* digits
			{
				[CallerCount(Count = 106)]
				[DeduplicatedMethod]
				 get { } //Length: 5
			}

			[CallerCount(Count = 106)]
			[DeduplicatedMethod]
			public Char* get_digits() { }

		}

		private static String[] s_posCurrencyFormats; //Field offset: 0x0
		private static String[] s_negCurrencyFormats; //Field offset: 0x8
		private static String[] s_posPercentFormats; //Field offset: 0x10
		private static String[] s_negPercentFormats; //Field offset: 0x18
		private static String[] s_negNumberFormats; //Field offset: 0x20
		private static string s_posNumberFormat; //Field offset: 0x28

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 49)]
		private static Number() { }

		[CalledBy(Type = typeof(Number), Member = "NumberToStringFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ValueStringBuilder&), typeof(NumberBuffer&), typeof(System.ReadOnlySpan`1<System.Char>), typeof(NumberFormatInfo)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		private static int FindSection(ReadOnlySpan<Char> format, int section) { }

		[CalledBy(Type = typeof(Number), Member = "NumberToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ValueStringBuilder&), typeof(NumberBuffer&), typeof(char), typeof(int), typeof(NumberFormatInfo), typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
		[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrencyGroupSizes", ReturnType = typeof(Int32[]))]
		[Calls(Type = typeof(Number), Member = "FormatFixed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ValueStringBuilder&), typeof(NumberBuffer&), typeof(int), typeof(int), typeof(NumberFormatInfo), typeof(Int32[]), typeof(string), typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 5)]
		private static void FormatCurrency(ref ValueStringBuilder sb, ref NumberBuffer number, int nMinDigits, int nMaxDigits, NumberFormatInfo info) { }

		[CalledBy(Type = typeof(Number), Member = "NumberToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ValueStringBuilder&), typeof(NumberBuffer&), typeof(char), typeof(int), typeof(NumberFormatInfo), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Number), Member = "FormatScientific", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ValueStringBuilder&), typeof(NumberBuffer&), typeof(int), typeof(int), typeof(NumberFormatInfo), typeof(char)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Number), Member = "FormatGeneral", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ValueStringBuilder&), typeof(NumberBuffer&), typeof(int), typeof(int), typeof(NumberFormatInfo), typeof(char), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Number), Member = "NumberToStringFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ValueStringBuilder&), typeof(NumberBuffer&), typeof(System.ReadOnlySpan`1<System.Char>), typeof(NumberFormatInfo)}, ReturnType = typeof(void))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(ValueStringBuilder), Member = "GrowAndAppend", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 5)]
		[ContainsUnimplementedInstructions]
		private static void FormatExponent(ref ValueStringBuilder sb, NumberFormatInfo info, int value, char expChar, int minDigits, bool positiveSign) { }

		[CalledBy(Type = typeof(Number), Member = "NumberToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ValueStringBuilder&), typeof(NumberBuffer&), typeof(char), typeof(int), typeof(NumberFormatInfo), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Number), Member = "FormatCurrency", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ValueStringBuilder&), typeof(NumberBuffer&), typeof(int), typeof(int), typeof(NumberFormatInfo)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Number), Member = "FormatNumber", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ValueStringBuilder&), typeof(NumberBuffer&), typeof(int), typeof(int), typeof(NumberFormatInfo)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Number), Member = "FormatPercent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ValueStringBuilder&), typeof(NumberBuffer&), typeof(int), typeof(int), typeof(NumberFormatInfo)}, ReturnType = typeof(void))]
		[CallerCount(Count = 5)]
		[Calls(Type = typeof(Math), Member = "Min", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(ValueStringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ValueStringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
		[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 10)]
		private static void FormatFixed(ref ValueStringBuilder sb, ref NumberBuffer number, int nMinDigits, int nMaxDigits, NumberFormatInfo info, Int32[] groupDigits, string sDecimal, string sGroup) { }

		[CalledBy(Type = typeof(Number), Member = "NumberToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ValueStringBuilder&), typeof(NumberBuffer&), typeof(char), typeof(int), typeof(NumberFormatInfo), typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(ValueStringBuilder), Member = "GrowAndAppend", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
		[Calls(Type = typeof(ValueStringBuilder), Member = "AppendSlow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Number), Member = "FormatExponent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ValueStringBuilder&), typeof(NumberFormatInfo), typeof(int), typeof(char), typeof(int), typeof(bool)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 2)]
		private static void FormatGeneral(ref ValueStringBuilder sb, ref NumberBuffer number, int nMinDigits, int nMaxDigits, NumberFormatInfo info, char expChar, bool bSuppressScientific) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
		[Calls(Type = typeof(NumberFormatInfo), Member = "get_NumberGroupSizes", ReturnType = typeof(Int32[]))]
		[Calls(Type = typeof(Number), Member = "FormatFixed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ValueStringBuilder&), typeof(NumberBuffer&), typeof(int), typeof(int), typeof(NumberFormatInfo), typeof(Int32[]), typeof(string), typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 4)]
		private static void FormatNumber(ref ValueStringBuilder sb, ref NumberBuffer number, int nMinDigits, int nMaxDigits, NumberFormatInfo info) { }

		[CalledBy(Type = typeof(Number), Member = "NumberToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ValueStringBuilder&), typeof(NumberBuffer&), typeof(char), typeof(int), typeof(NumberFormatInfo), typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
		[Calls(Type = typeof(NumberFormatInfo), Member = "get_PercentGroupSizes", ReturnType = typeof(Int32[]))]
		[Calls(Type = typeof(Number), Member = "FormatFixed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ValueStringBuilder&), typeof(NumberBuffer&), typeof(int), typeof(int), typeof(NumberFormatInfo), typeof(Int32[]), typeof(string), typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 5)]
		private static void FormatPercent(ref ValueStringBuilder sb, ref NumberBuffer number, int nMinDigits, int nMaxDigits, NumberFormatInfo info) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Number), Member = "FormatExponent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ValueStringBuilder&), typeof(NumberFormatInfo), typeof(int), typeof(char), typeof(int), typeof(bool)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 4)]
		private static void FormatScientific(ref ValueStringBuilder sb, ref NumberBuffer number, int nMinDigits, int nMaxDigits, NumberFormatInfo info, char expChar) { }

		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		internal static void Int32ToDecChars(Char* buffer, ref int index, uint value, int digits) { }

		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		private static bool IsWhite(char ch) { }

		[CallerCount(Count = 0)]
		private static Char* MatchChars(Char* p, Char* pEnd, Char* str) { }

		[CalledBy(Type = typeof(Number), Member = "ParseNumber", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*&), typeof(Char*), typeof(NumberStyles), typeof(NumberBuffer&), typeof(StringBuilder), typeof(NumberFormatInfo), typeof(bool)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(RuntimeHelpers), Member = "get_OffsetToStringData", ReturnType = typeof(int))]
		private static Char* MatchChars(Char* p, Char* pEnd, string str) { }

		[CalledBy(Type = typeof(BigNumber), Member = "FormatBigInteger", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(BigInteger), typeof(string), typeof(System.ReadOnlySpan`1<System.Char>), typeof(NumberFormatInfo), typeof(System.Span`1<System.Char>), typeof(Int32&), typeof(Boolean&)}, ReturnType = typeof(string))]
		[CalledBy(Type = typeof(FormatProvider), Member = "FormatBigInteger", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ValueStringBuilder&), typeof(int), typeof(int), typeof(bool), typeof(System.ReadOnlySpan`1<System.Char>), typeof(NumberFormatInfo), typeof(Char[]), typeof(int)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Number), Member = "RoundNumber", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NumberBuffer&), typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
		[Calls(Type = typeof(NumberFormatInfo), Member = "get_NumberGroupSizes", ReturnType = typeof(Int32[]))]
		[Calls(Type = typeof(Number), Member = "FormatFixed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ValueStringBuilder&), typeof(NumberBuffer&), typeof(int), typeof(int), typeof(NumberFormatInfo), typeof(Int32[]), typeof(string), typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Number), Member = "FormatPercent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ValueStringBuilder&), typeof(NumberBuffer&), typeof(int), typeof(int), typeof(NumberFormatInfo)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Number), Member = "FormatGeneral", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ValueStringBuilder&), typeof(NumberBuffer&), typeof(int), typeof(int), typeof(NumberFormatInfo), typeof(char), typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Number), Member = "FormatExponent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ValueStringBuilder&), typeof(NumberFormatInfo), typeof(int), typeof(char), typeof(int), typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Number), Member = "FormatCurrency", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ValueStringBuilder&), typeof(NumberBuffer&), typeof(int), typeof(int), typeof(NumberFormatInfo)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(FormatException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 14)]
		internal static void NumberToString(ref ValueStringBuilder sb, ref NumberBuffer number, char format, int nMaxDigits, NumberFormatInfo info, bool isDecimal) { }

		[CalledBy(Type = typeof(BigNumber), Member = "FormatBigInteger", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(BigInteger), typeof(string), typeof(System.ReadOnlySpan`1<System.Char>), typeof(NumberFormatInfo), typeof(System.Span`1<System.Char>), typeof(Int32&), typeof(Boolean&)}, ReturnType = typeof(string))]
		[CalledBy(Type = typeof(FormatProvider), Member = "FormatBigInteger", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ValueStringBuilder&), typeof(int), typeof(int), typeof(bool), typeof(System.ReadOnlySpan`1<System.Char>), typeof(NumberFormatInfo), typeof(Char[]), typeof(int)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Number), Member = "FindSection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(int)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(NumberFormatInfo), Member = "get_NumberGroupSizes", ReturnType = typeof(Int32[]))]
		[Calls(Type = typeof(Span`1), Member = "CopyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Span`1<T>"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
		[Calls(Type = typeof(ValueStringBuilder), Member = "AppendSlow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Number), Member = "FormatExponent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ValueStringBuilder&), typeof(NumberFormatInfo), typeof(int), typeof(char), typeof(int), typeof(bool)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 5)]
		[CallsUnknownMethods(Count = 17)]
		[ContainsUnimplementedInstructions]
		internal static void NumberToStringFormat(ref ValueStringBuilder sb, ref NumberBuffer number, ReadOnlySpan<Char> format, NumberFormatInfo info) { }

		[CalledBy(Type = typeof(BigNumber), Member = "FormatBigInteger", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(BigInteger), typeof(string), typeof(System.ReadOnlySpan`1<System.Char>), typeof(NumberFormatInfo), typeof(System.Span`1<System.Char>), typeof(Int32&), typeof(Boolean&)}, ReturnType = typeof(string))]
		[CalledBy(Type = typeof(FormatProvider), Member = "FormatBigInteger", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ValueStringBuilder&), typeof(int), typeof(int), typeof(bool), typeof(System.ReadOnlySpan`1<System.Char>), typeof(NumberFormatInfo), typeof(Char[]), typeof(int)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		internal static char ParseFormatSpecifier(ReadOnlySpan<Char> format, out int digits) { }

		[CalledBy(Type = typeof(BigNumber), Member = "TryParseBigInteger", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(NumberStyles), typeof(NumberFormatInfo), typeof(BigInteger&)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(Number), Member = "TryStringToNumber", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(NumberStyles), typeof(NumberBuffer&), typeof(StringBuilder), typeof(NumberFormatInfo), typeof(bool)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(FormatProvider), Member = "TryStringToBigInteger", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(NumberStyles), typeof(NumberFormatInfo), typeof(StringBuilder), typeof(Int32&), typeof(Int32&), typeof(Boolean&)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(RuntimeHelpers), Member = "get_OffsetToStringData", ReturnType = typeof(int))]
		[Calls(Type = typeof(Number), Member = "MatchChars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(Char*), typeof(string)}, ReturnType = typeof(Char*))]
		[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(StringBuilder))]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		private static bool ParseNumber(ref Char* str, Char* strEnd, NumberStyles options, ref NumberBuffer number, StringBuilder sb, NumberFormatInfo numfmt, bool parseDecimal) { }

		[CalledBy(Type = typeof(Number), Member = "NumberToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ValueStringBuilder&), typeof(NumberBuffer&), typeof(char), typeof(int), typeof(NumberFormatInfo), typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 6)]
		private static void RoundNumber(ref NumberBuffer number, int pos) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		private static bool TrailingZeros(ReadOnlySpan<Char> s, int index) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Number), Member = "ParseNumber", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*&), typeof(Char*), typeof(NumberStyles), typeof(NumberBuffer&), typeof(StringBuilder), typeof(NumberFormatInfo), typeof(bool)}, ReturnType = typeof(bool))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		internal static bool TryStringToNumber(ReadOnlySpan<Char> str, NumberStyles options, ref NumberBuffer number, StringBuilder sb, NumberFormatInfo numfmt, bool parseDecimal) { }

		[CallerCount(Count = 0)]
		private static int wcslen(Char* s) { }

	}


	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Number), Member = "ParseFormatSpecifier", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(Int32&)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(Number), Member = "NumberToStringFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ValueStringBuilder&), typeof(NumberBuffer&), typeof(System.ReadOnlySpan`1<System.Char>), typeof(NumberFormatInfo)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Number), Member = "NumberToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ValueStringBuilder&), typeof(NumberBuffer&), typeof(char), typeof(int), typeof(NumberFormatInfo), typeof(bool)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	internal static void FormatBigInteger(ref ValueStringBuilder sb, int precision, int scale, bool sign, ReadOnlySpan<Char> format, NumberFormatInfo numberFormatInfo, Char[] digits, int startIndex) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Number), Member = "ParseNumber", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*&), typeof(Char*), typeof(NumberStyles), typeof(NumberBuffer&), typeof(StringBuilder), typeof(NumberFormatInfo), typeof(bool)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	internal static bool TryStringToBigInteger(ReadOnlySpan<Char> s, NumberStyles styles, NumberFormatInfo numberFormatInfo, StringBuilder receiver, out int precision, out int scale, out bool sign) { }

}

