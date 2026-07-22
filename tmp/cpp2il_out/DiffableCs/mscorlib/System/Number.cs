namespace System;

internal static class Number
{
	[IsByRefLike]
	[Obsolete("Types with embedded references are not supported in this version of your compiler.", True)]
	public struct NumberBuffer
	{
		private struct DigitsAndNullTerminator
		{

		}

		public int precision; //Field offset: 0x0
		public int scale; //Field offset: 0x4
		private int _sign; //Field offset: 0x8
		private DigitsAndNullTerminator _digits; //Field offset: 0xC
		private Char* _allDigits; //Field offset: 0x72

		public Char* digits
		{
			[CallerCount(Count = 43)]
			[DeduplicatedMethod]
			 get { } //Length: 5
		}

		public bool sign
		{
			[CallerCount(Count = 22)]
			[ContainsUnimplementedInstructions]
			[DeduplicatedMethod]
			 get { } //Length: 8
			[CalledBy(Type = typeof(Guid), Member = "WriteByteHelper", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Span`1<System.Byte>)}, ReturnType = typeof(void))]
			[CalledBy(Type = typeof(Number), Member = "DecimalToNumber", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal), typeof(NumberBuffer&)}, ReturnType = typeof(void))]
			[CalledBy(Type = typeof(Number), Member = "Int32ToNumber", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(NumberBuffer&)}, ReturnType = typeof(void))]
			[CalledBy(Type = typeof(Number), Member = "UInt32ToNumber", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(NumberBuffer&)}, ReturnType = typeof(void))]
			[CalledBy(Type = typeof(Number), Member = "Int64ToNumber", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(NumberBuffer&)}, ReturnType = typeof(void))]
			[CalledBy(Type = typeof(Number), Member = "UInt64ToNumber", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ulong), typeof(NumberBuffer&)}, ReturnType = typeof(void))]
			[CalledBy(Type = typeof(Number), Member = "NumberToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ValueStringBuilder&), typeof(NumberBuffer&), typeof(char), typeof(int), typeof(NumberFormatInfo), typeof(bool)}, ReturnType = typeof(void))]
			[CalledBy(Type = typeof(Number), Member = "RoundNumber", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NumberBuffer&), typeof(int)}, ReturnType = typeof(void))]
			[CalledBy(Type = typeof(Number), Member = "ParseNumber", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*&), typeof(Char*), typeof(NumberStyles), typeof(NumberBuffer&), typeof(NumberFormatInfo), typeof(bool)}, ReturnType = typeof(bool))]
			[CalledBy(Type = typeof(Number), Member = "DoubleToNumber", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double), typeof(int), typeof(NumberBuffer&)}, ReturnType = typeof(void))]
			[CallerCount(Count = 16)]
			 set { } //Length: 9
		}

		[CallerCount(Count = 43)]
		[DeduplicatedMethod]
		public Char* get_digits() { }

		[CallerCount(Count = 22)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		public bool get_sign() { }

		[CalledBy(Type = typeof(Guid), Member = "WriteByteHelper", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Span`1<System.Byte>)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Number), Member = "DecimalToNumber", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal), typeof(NumberBuffer&)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Number), Member = "Int32ToNumber", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(NumberBuffer&)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Number), Member = "UInt32ToNumber", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(NumberBuffer&)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Number), Member = "Int64ToNumber", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(NumberBuffer&)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Number), Member = "UInt64ToNumber", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ulong), typeof(NumberBuffer&)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Number), Member = "NumberToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ValueStringBuilder&), typeof(NumberBuffer&), typeof(char), typeof(int), typeof(NumberFormatInfo), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Number), Member = "RoundNumber", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NumberBuffer&), typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Number), Member = "ParseNumber", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*&), typeof(Char*), typeof(NumberStyles), typeof(NumberBuffer&), typeof(NumberFormatInfo), typeof(bool)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(Number), Member = "DoubleToNumber", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double), typeof(int), typeof(NumberBuffer&)}, ReturnType = typeof(void))]
		[CallerCount(Count = 16)]
		public void set_sign(bool value) { }

	}

	private static readonly String[] s_posCurrencyFormats; //Field offset: 0x0
	private static readonly String[] s_negCurrencyFormats; //Field offset: 0x8
	private static readonly String[] s_posPercentFormats; //Field offset: 0x10
	private static readonly String[] s_negPercentFormats; //Field offset: 0x18
	private static readonly String[] s_negNumberFormats; //Field offset: 0x20
	private static readonly Int32[] s_charToHexLookup; //Field offset: 0x28
	private static readonly UInt64[] s_rgval64Power10; //Field offset: 0x30
	private static readonly SByte[] s_rgexp64Power10; //Field offset: 0x38
	private static readonly UInt64[] s_rgval64Power10By16; //Field offset: 0x40
	private static readonly Int16[] s_rgexp64Power10By16; //Field offset: 0x48

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(RuntimeFieldHandle)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 53)]
	private static Number() { }

	[CallerCount(Count = 0)]
	private static int abs(int value) { }

	[CalledBy(Type = typeof(Number), Member = "FormatDecimal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal), typeof(System.ReadOnlySpan`1<System.Char>), typeof(NumberFormatInfo)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(Number), Member = "TryFormatDecimal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal), typeof(System.ReadOnlySpan`1<System.Char>), typeof(NumberFormatInfo), typeof(System.Span`1<System.Char>), typeof(Int32&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(NumberBuffer), Member = "set_sign", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Decimal), Member = "DecDivMod1E9", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal&)}, ReturnType = typeof(uint))]
	[Calls(Type = typeof(Decimal), Member = "get_Scale", ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	private static void DecimalToNumber(decimal value, ref NumberBuffer number) { }

	[CallerCount(Count = 0)]
	private static uint DigitsToInt(Char* p, int count) { }

	[CalledBy(Type = typeof(Number), Member = "FormatDouble", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ValueStringBuilder&), typeof(double), typeof(System.ReadOnlySpan`1<System.Char>), typeof(NumberFormatInfo)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(Number), Member = "FormatSingle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ValueStringBuilder&), typeof(float), typeof(System.ReadOnlySpan`1<System.Char>), typeof(NumberFormatInfo)}, ReturnType = typeof(string))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(RuntimeImports), Member = "_ecvt_s", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(int), typeof(double), typeof(int), typeof(Int32*), typeof(Int32*)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NumberBuffer), Member = "set_sign", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private static void DoubleToNumber(double value, int precision, ref NumberBuffer number) { }

	[CalledBy(Type = typeof(Number), Member = "NumberToStringFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ValueStringBuilder&), typeof(NumberBuffer&), typeof(System.ReadOnlySpan`1<System.Char>), typeof(NumberFormatInfo)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	private static int FindSection(ReadOnlySpan<Char> format, int section) { }

	[CalledBy(Type = typeof(Number), Member = "NumberToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ValueStringBuilder&), typeof(NumberBuffer&), typeof(char), typeof(int), typeof(NumberFormatInfo), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(Number), Member = "FormatFixed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ValueStringBuilder&), typeof(NumberBuffer&), typeof(int), typeof(int), typeof(NumberFormatInfo), typeof(Int32[]), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	private static void FormatCurrency(ref ValueStringBuilder sb, ref NumberBuffer number, int nMinDigits, int nMaxDigits, NumberFormatInfo info) { }

	[CalledBy(Type = typeof(Decimal), Member = "ToString", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(Decimal), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(Decimal), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Number), Member = "ParseFormatSpecifier", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(Int32&)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(Number), Member = "DecimalToNumber", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal), typeof(NumberBuffer&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Number), Member = "NumberToStringFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ValueStringBuilder&), typeof(NumberBuffer&), typeof(System.ReadOnlySpan`1<System.Char>), typeof(NumberFormatInfo)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Number), Member = "NumberToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ValueStringBuilder&), typeof(NumberBuffer&), typeof(char), typeof(int), typeof(NumberFormatInfo), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ValueStringBuilder), Member = "ToString", ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 1)]
	public static string FormatDecimal(decimal value, ReadOnlySpan<Char> format, NumberFormatInfo info) { }

	[CalledBy(Type = typeof(double), Member = "ToString", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(double), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(double), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(double), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[Calls(Type = typeof(Number), Member = "FormatDouble", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ValueStringBuilder&), typeof(double), typeof(System.ReadOnlySpan`1<System.Char>), typeof(NumberFormatInfo)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ValueStringBuilder), Member = "ToString", ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 1)]
	public static string FormatDouble(double value, string format, NumberFormatInfo info) { }

	[CalledBy(Type = typeof(Number), Member = "FormatDouble", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double), typeof(string), typeof(NumberFormatInfo)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(Number), Member = "TryFormatDouble", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double), typeof(System.ReadOnlySpan`1<System.Char>), typeof(NumberFormatInfo), typeof(System.Span`1<System.Char>), typeof(Int32&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Number), Member = "ParseFormatSpecifier", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(Int32&)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(Number), Member = "DoubleToNumber", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double), typeof(int), typeof(NumberBuffer&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Number), Member = "NumberToStringFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ValueStringBuilder&), typeof(NumberBuffer&), typeof(System.ReadOnlySpan`1<System.Char>), typeof(NumberFormatInfo)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Number), Member = "NumberToDouble", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NumberBuffer&)}, ReturnType = typeof(double))]
	[Calls(Type = typeof(Number), Member = "NumberToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ValueStringBuilder&), typeof(NumberBuffer&), typeof(char), typeof(int), typeof(NumberFormatInfo), typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private static string FormatDouble(ref ValueStringBuilder sb, double value, ReadOnlySpan<Char> format, NumberFormatInfo info) { }

	[CalledBy(Type = typeof(Number), Member = "NumberToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ValueStringBuilder&), typeof(NumberBuffer&), typeof(char), typeof(int), typeof(NumberFormatInfo), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Number), Member = "FormatScientific", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ValueStringBuilder&), typeof(NumberBuffer&), typeof(int), typeof(int), typeof(NumberFormatInfo), typeof(char)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Number), Member = "FormatGeneral", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ValueStringBuilder&), typeof(NumberBuffer&), typeof(int), typeof(int), typeof(NumberFormatInfo), typeof(char), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(ValueStringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	[ContainsUnimplementedInstructions]
	private static void FormatExponent(ref ValueStringBuilder sb, NumberFormatInfo info, int value, char expChar, int minDigits, bool positiveSign) { }

	[CalledBy(Type = typeof(Number), Member = "NumberToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ValueStringBuilder&), typeof(NumberBuffer&), typeof(char), typeof(int), typeof(NumberFormatInfo), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Number), Member = "FormatCurrency", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ValueStringBuilder&), typeof(NumberBuffer&), typeof(int), typeof(int), typeof(NumberFormatInfo)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Number), Member = "FormatNumber", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ValueStringBuilder&), typeof(NumberBuffer&), typeof(int), typeof(int), typeof(NumberFormatInfo)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Number), Member = "FormatPercent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ValueStringBuilder&), typeof(NumberBuffer&), typeof(int), typeof(int), typeof(NumberFormatInfo)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(ValueStringBuilder), Member = "GrowAndAppend", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "wcslen", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ValueStringBuilder), Member = "Grow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(ValueStringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 9)]
	private static void FormatFixed(ref ValueStringBuilder sb, ref NumberBuffer number, int nMinDigits, int nMaxDigits, NumberFormatInfo info, Int32[] groupDigits, string sDecimal, string sGroup) { }

	[CalledBy(Type = typeof(Number), Member = "NumberToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ValueStringBuilder&), typeof(NumberBuffer&), typeof(char), typeof(int), typeof(NumberFormatInfo), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ValueStringBuilder), Member = "GrowAndAppend", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(ValueStringBuilder), Member = "AppendSlow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Number), Member = "FormatExponent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ValueStringBuilder&), typeof(NumberFormatInfo), typeof(int), typeof(char), typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private static void FormatGeneral(ref ValueStringBuilder sb, ref NumberBuffer number, int nMinDigits, int nMaxDigits, NumberFormatInfo info, char expChar, bool bSuppressScientific) { }

	[CalledBy(Type = typeof(sbyte), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(sbyte), Member = "ToString", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(int), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(int), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(int), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(short), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(sbyte), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(short), Member = "ToString", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(byte), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(byte), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(byte), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(byte), Member = "ToString", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(short), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[CallerCount(Count = 14)]
	[Calls(Type = typeof(string), Member = "FastAllocateString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(FormattingHelpers), Member = "CountDigits", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Number), Member = "Int32ToHexStr", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(char), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Number), Member = "NumberToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ValueStringBuilder&), typeof(NumberBuffer&), typeof(char), typeof(int), typeof(NumberFormatInfo), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ValueStringBuilder), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(Number), Member = "ParseFormatSpecifier", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(Int32&)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(NumberFormatInfo), Member = "GetInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(NumberFormatInfo))]
	[Calls(Type = typeof(Number), Member = "UInt32ToDecStr", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(RuntimeHelpers), Member = "get_OffsetToStringData", ReturnType = typeof(int))]
	[Calls(Type = typeof(Number), Member = "NumberToStringFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ValueStringBuilder&), typeof(NumberBuffer&), typeof(System.ReadOnlySpan`1<System.Char>), typeof(NumberFormatInfo)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	public static string FormatInt32(int value, ReadOnlySpan<Char> format, IFormatProvider provider) { }

	[CalledBy(Type = typeof(long), Member = "ToString", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(long), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(long), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(long), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Number), Member = "UInt64ToDecStr", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ulong), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Number), Member = "ParseFormatSpecifier", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(Int32&)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(NumberFormatInfo), Member = "GetInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(NumberFormatInfo))]
	[Calls(Type = typeof(Number), Member = "Int64ToNumber", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(NumberBuffer&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Number), Member = "NumberToStringFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ValueStringBuilder&), typeof(NumberBuffer&), typeof(System.ReadOnlySpan`1<System.Char>), typeof(NumberFormatInfo)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ValueStringBuilder), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(Number), Member = "NumberToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ValueStringBuilder&), typeof(NumberBuffer&), typeof(char), typeof(int), typeof(NumberFormatInfo), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Number), Member = "Int64ToHexStr", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(char), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Number), Member = "NegativeInt64ToDecStr", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(int), typeof(string)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static string FormatInt64(long value, ReadOnlySpan<Char> format, IFormatProvider provider) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(Number), Member = "FormatFixed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ValueStringBuilder&), typeof(NumberBuffer&), typeof(int), typeof(int), typeof(NumberFormatInfo), typeof(Int32[]), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	private static void FormatNumber(ref ValueStringBuilder sb, ref NumberBuffer number, int nMinDigits, int nMaxDigits, NumberFormatInfo info) { }

	[CalledBy(Type = typeof(Number), Member = "NumberToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ValueStringBuilder&), typeof(NumberBuffer&), typeof(char), typeof(int), typeof(NumberFormatInfo), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(Number), Member = "FormatFixed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ValueStringBuilder&), typeof(NumberBuffer&), typeof(int), typeof(int), typeof(NumberFormatInfo), typeof(Int32[]), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	private static void FormatPercent(ref ValueStringBuilder sb, ref NumberBuffer number, int nMinDigits, int nMaxDigits, NumberFormatInfo info) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Number), Member = "FormatExponent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ValueStringBuilder&), typeof(NumberFormatInfo), typeof(int), typeof(char), typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	private static void FormatScientific(ref ValueStringBuilder sb, ref NumberBuffer number, int nMinDigits, int nMaxDigits, NumberFormatInfo info, char expChar) { }

	[CalledBy(Type = typeof(float), Member = "ToString", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(float), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(float), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(float), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[Calls(Type = typeof(Number), Member = "FormatSingle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ValueStringBuilder&), typeof(float), typeof(System.ReadOnlySpan`1<System.Char>), typeof(NumberFormatInfo)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ValueStringBuilder), Member = "ToString", ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 1)]
	public static string FormatSingle(float value, string format, NumberFormatInfo info) { }

	[CalledBy(Type = typeof(Number), Member = "FormatSingle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(string), typeof(NumberFormatInfo)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(Number), Member = "TryFormatSingle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(System.ReadOnlySpan`1<System.Char>), typeof(NumberFormatInfo), typeof(System.Span`1<System.Char>), typeof(Int32&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Number), Member = "ParseFormatSpecifier", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(Int32&)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(Number), Member = "DoubleToNumber", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double), typeof(int), typeof(NumberBuffer&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Number), Member = "NumberToStringFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ValueStringBuilder&), typeof(NumberBuffer&), typeof(System.ReadOnlySpan`1<System.Char>), typeof(NumberFormatInfo)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Number), Member = "NumberToDouble", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NumberBuffer&)}, ReturnType = typeof(double))]
	[Calls(Type = typeof(Number), Member = "NumberToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ValueStringBuilder&), typeof(NumberBuffer&), typeof(char), typeof(int), typeof(NumberFormatInfo), typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private static string FormatSingle(ref ValueStringBuilder sb, float value, ReadOnlySpan<Char> format, NumberFormatInfo info) { }

	[CalledBy(Type = typeof(short), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(sbyte), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(ushort), Member = "ToString", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(ushort), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(ushort), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(uint), Member = "ToString", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(uint), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(uint), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(uint), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(Number), Member = "ParseFormatSpecifier", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(Int32&)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(NumberFormatInfo), Member = "GetInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(NumberFormatInfo))]
	[Calls(Type = typeof(Number), Member = "NumberToStringFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ValueStringBuilder&), typeof(NumberBuffer&), typeof(System.ReadOnlySpan`1<System.Char>), typeof(NumberFormatInfo)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ValueStringBuilder), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(Number), Member = "NumberToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ValueStringBuilder&), typeof(NumberBuffer&), typeof(char), typeof(int), typeof(NumberFormatInfo), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Number), Member = "Int32ToHexStr", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(char), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Number), Member = "UInt32ToDecStr", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(int)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static string FormatUInt32(uint value, ReadOnlySpan<Char> format, IFormatProvider provider) { }

	[CalledBy(Type = typeof(ulong), Member = "ToString", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(ulong), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(ulong), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(ulong), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Number), Member = "ParseFormatSpecifier", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(Int32&)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(NumberFormatInfo), Member = "GetInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(NumberFormatInfo))]
	[Calls(Type = typeof(Number), Member = "UInt64ToNumber", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ulong), typeof(NumberBuffer&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Number), Member = "NumberToStringFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ValueStringBuilder&), typeof(NumberBuffer&), typeof(System.ReadOnlySpan`1<System.Char>), typeof(NumberFormatInfo)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ValueStringBuilder), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(Number), Member = "NumberToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ValueStringBuilder&), typeof(NumberBuffer&), typeof(char), typeof(int), typeof(NumberFormatInfo), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Number), Member = "Int64ToHexStr", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(char), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Number), Member = "UInt64ToDecStr", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ulong), typeof(int)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 1)]
	public static string FormatUInt64(ulong value, ReadOnlySpan<Char> format, IFormatProvider provider) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	private static uint High32(ulong value) { }

	[CallerCount(Count = 0)]
	private static Char* Int32ToHexChars(Char* buffer, uint value, int hexBase, int digits) { }

	[CalledBy(Type = typeof(Number), Member = "FormatInt32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(System.ReadOnlySpan`1<System.Char>), typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(Number), Member = "FormatUInt32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(System.ReadOnlySpan`1<System.Char>), typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "FastAllocateString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(RuntimeHelpers), Member = "get_OffsetToStringData", ReturnType = typeof(int))]
	private static string Int32ToHexStr(int value, char hexBase, int digits) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NumberBuffer), Member = "set_sign", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	private static void Int32ToNumber(int value, ref NumberBuffer number) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	private static uint Int64DivMod1E9(ref ulong value) { }

	[CalledBy(Type = typeof(Number), Member = "FormatInt64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(System.ReadOnlySpan`1<System.Char>), typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(Number), Member = "FormatUInt64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ulong), typeof(System.ReadOnlySpan`1<System.Char>), typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "FastAllocateString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(RuntimeHelpers), Member = "get_OffsetToStringData", ReturnType = typeof(int))]
	private static string Int64ToHexStr(long value, char hexBase, int digits) { }

	[CalledBy(Type = typeof(Number), Member = "FormatInt64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(System.ReadOnlySpan`1<System.Char>), typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(Number), Member = "TryFormatInt64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(System.ReadOnlySpan`1<System.Char>), typeof(IFormatProvider), typeof(System.Span`1<System.Char>), typeof(Int32&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(NumberBuffer), Member = "set_sign", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	private static void Int64ToNumber(long input, ref NumberBuffer number) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	private static bool IsDigit(int ch) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	private static bool IsWhite(int ch) { }

	[CallerCount(Count = 19)]
	[DeduplicatedMethod]
	private static uint Low32(ulong value) { }

	[CalledBy(Type = typeof(Number), Member = "ParseNumber", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*&), typeof(Char*), typeof(NumberStyles), typeof(NumberBuffer&), typeof(NumberFormatInfo), typeof(bool)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(RuntimeHelpers), Member = "get_OffsetToStringData", ReturnType = typeof(int))]
	private static Char* MatchChars(Char* p, Char* pEnd, string value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	private static ulong Mul32x32To64(uint a, uint b) { }

	[CallerCount(Count = 0)]
	private static ulong Mul64Lossy(ulong a, ulong b, ref int pexp) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FormattingHelpers), Member = "CountDigits", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(string), Member = "FastAllocateString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(RuntimeHelpers), Member = "get_OffsetToStringData", ReturnType = typeof(int))]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private static string NegativeInt32ToDecStr(int value, int digits, string sNegative) { }

	[CalledBy(Type = typeof(Number), Member = "FormatInt64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(System.ReadOnlySpan`1<System.Char>), typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(FormattingHelpers), Member = "CountDigits", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ulong)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(string), Member = "FastAllocateString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(RuntimeHelpers), Member = "get_OffsetToStringData", ReturnType = typeof(int))]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private static string NegativeInt64ToDecStr(long input, int digits, string sNegative) { }

	[CalledBy(Type = typeof(Number), Member = "ParseDecimal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(NumberStyles), typeof(NumberFormatInfo)}, ReturnType = typeof(Decimal))]
	[CalledBy(Type = typeof(Number), Member = "TryParseDecimal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(NumberStyles), typeof(NumberFormatInfo), typeof(Decimal&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Decimal), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(bool), typeof(byte)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	private static bool NumberBufferToDecimal(ref NumberBuffer number, ref decimal value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Number), Member = "NumberToDouble", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NumberBuffer&)}, ReturnType = typeof(double))]
	[ContainsUnimplementedInstructions]
	private static bool NumberBufferToDouble(ref NumberBuffer number, ref double value) { }

	[CalledBy(Type = typeof(Number), Member = "FormatDouble", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ValueStringBuilder&), typeof(double), typeof(System.ReadOnlySpan`1<System.Char>), typeof(NumberFormatInfo)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(Number), Member = "FormatSingle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ValueStringBuilder&), typeof(float), typeof(System.ReadOnlySpan`1<System.Char>), typeof(NumberFormatInfo)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(Number), Member = "ParseDouble", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(NumberStyles), typeof(NumberFormatInfo)}, ReturnType = typeof(double))]
	[CalledBy(Type = typeof(Number), Member = "ParseSingle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(NumberStyles), typeof(NumberFormatInfo)}, ReturnType = typeof(float))]
	[CalledBy(Type = typeof(Number), Member = "TryParseDouble", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(NumberStyles), typeof(NumberFormatInfo), typeof(Double&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Number), Member = "TryParseSingle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(NumberStyles), typeof(NumberFormatInfo), typeof(Single&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Number), Member = "NumberBufferToDouble", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NumberBuffer&), typeof(Double&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(string), Member = "wcslen", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*)}, ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	private static double NumberToDouble(ref NumberBuffer number) { }

	[CalledBy(Type = typeof(Number), Member = "TryParseInt32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(NumberStyles), typeof(NumberFormatInfo), typeof(Int32&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	private static bool NumberToInt32(ref NumberBuffer number, ref int value) { }

	[CalledBy(Type = typeof(Number), Member = "TryParseInt64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(NumberStyles), typeof(NumberFormatInfo), typeof(Int64&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	private static bool NumberToInt64(ref NumberBuffer number, ref long value) { }

	[CalledBy(Type = typeof(Number), Member = "FormatDecimal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal), typeof(System.ReadOnlySpan`1<System.Char>), typeof(NumberFormatInfo)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(Number), Member = "FormatUInt64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ulong), typeof(System.ReadOnlySpan`1<System.Char>), typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(Number), Member = "TryFormatInt64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(System.ReadOnlySpan`1<System.Char>), typeof(IFormatProvider), typeof(System.Span`1<System.Char>), typeof(Int32&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Number), Member = "FormatInt64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(System.ReadOnlySpan`1<System.Char>), typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(Number), Member = "TryFormatUInt32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(System.ReadOnlySpan`1<System.Char>), typeof(IFormatProvider), typeof(System.Span`1<System.Char>), typeof(Int32&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Number), Member = "FormatUInt32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(System.ReadOnlySpan`1<System.Char>), typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(Number), Member = "TryFormatUInt64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ulong), typeof(System.ReadOnlySpan`1<System.Char>), typeof(IFormatProvider), typeof(System.Span`1<System.Char>), typeof(Int32&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Number), Member = "FormatInt32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(System.ReadOnlySpan`1<System.Char>), typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(Number), Member = "FormatSingle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ValueStringBuilder&), typeof(float), typeof(System.ReadOnlySpan`1<System.Char>), typeof(NumberFormatInfo)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(Number), Member = "FormatDouble", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ValueStringBuilder&), typeof(double), typeof(System.ReadOnlySpan`1<System.Char>), typeof(NumberFormatInfo)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(Number), Member = "TryFormatDecimal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal), typeof(System.ReadOnlySpan`1<System.Char>), typeof(NumberFormatInfo), typeof(System.Span`1<System.Char>), typeof(Int32&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Number), Member = "TryFormatInt32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(System.ReadOnlySpan`1<System.Char>), typeof(IFormatProvider), typeof(System.Span`1<System.Char>), typeof(Int32&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 12)]
	[Calls(Type = typeof(FormatException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Number), Member = "FormatCurrency", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ValueStringBuilder&), typeof(NumberBuffer&), typeof(int), typeof(int), typeof(NumberFormatInfo)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Number), Member = "FormatExponent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ValueStringBuilder&), typeof(NumberFormatInfo), typeof(int), typeof(char), typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Number), Member = "FormatGeneral", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ValueStringBuilder&), typeof(NumberBuffer&), typeof(int), typeof(int), typeof(NumberFormatInfo), typeof(char), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Number), Member = "FormatFixed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ValueStringBuilder&), typeof(NumberBuffer&), typeof(int), typeof(int), typeof(NumberFormatInfo), typeof(Int32[]), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Number), Member = "FormatPercent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ValueStringBuilder&), typeof(NumberBuffer&), typeof(int), typeof(int), typeof(NumberFormatInfo)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(Number), Member = "RoundNumber", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NumberBuffer&), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NumberBuffer), Member = "set_sign", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 14)]
	internal static void NumberToString(ref ValueStringBuilder sb, ref NumberBuffer number, char format, int nMaxDigits, NumberFormatInfo info, bool isDecimal) { }

	[CalledBy(Type = typeof(Number), Member = "FormatUInt32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(System.ReadOnlySpan`1<System.Char>), typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(Number), Member = "FormatDecimal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal), typeof(System.ReadOnlySpan`1<System.Char>), typeof(NumberFormatInfo)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(Number), Member = "TryFormatDecimal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal), typeof(System.ReadOnlySpan`1<System.Char>), typeof(NumberFormatInfo), typeof(System.Span`1<System.Char>), typeof(Int32&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Number), Member = "FormatDouble", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ValueStringBuilder&), typeof(double), typeof(System.ReadOnlySpan`1<System.Char>), typeof(NumberFormatInfo)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(Number), Member = "FormatSingle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ValueStringBuilder&), typeof(float), typeof(System.ReadOnlySpan`1<System.Char>), typeof(NumberFormatInfo)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(Number), Member = "FormatInt32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(System.ReadOnlySpan`1<System.Char>), typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(Number), Member = "TryFormatInt32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(System.ReadOnlySpan`1<System.Char>), typeof(IFormatProvider), typeof(System.Span`1<System.Char>), typeof(Int32&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Number), Member = "TryFormatUInt32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(System.ReadOnlySpan`1<System.Char>), typeof(IFormatProvider), typeof(System.Span`1<System.Char>), typeof(Int32&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Number), Member = "FormatInt64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(System.ReadOnlySpan`1<System.Char>), typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(Number), Member = "TryFormatInt64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(System.ReadOnlySpan`1<System.Char>), typeof(IFormatProvider), typeof(System.Span`1<System.Char>), typeof(Int32&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Number), Member = "FormatUInt64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ulong), typeof(System.ReadOnlySpan`1<System.Char>), typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(Number), Member = "TryFormatUInt64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ulong), typeof(System.ReadOnlySpan`1<System.Char>), typeof(IFormatProvider), typeof(System.Span`1<System.Char>), typeof(Int32&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 12)]
	[Calls(Type = typeof(Number), Member = "FindSection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(int)}, ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 3)]
	[ContainsInvalidInstructions]
	[ContainsUnimplementedInstructions]
	internal static void NumberToStringFormat(ref ValueStringBuilder sb, ref NumberBuffer number, ReadOnlySpan<Char> format, NumberFormatInfo info) { }

	[CalledBy(Type = typeof(Number), Member = "TryParseUInt32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(NumberStyles), typeof(NumberFormatInfo), typeof(UInt32&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	private static bool NumberToUInt32(ref NumberBuffer number, ref uint value) { }

	[CalledBy(Type = typeof(Number), Member = "TryParseUInt64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(NumberStyles), typeof(NumberFormatInfo), typeof(UInt64&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	private static bool NumberToUInt64(ref NumberBuffer number, ref ulong value) { }

	[CalledBy(Type = typeof(Decimal), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(Decimal))]
	[CalledBy(Type = typeof(Decimal), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(NumberStyles), typeof(IFormatProvider)}, ReturnType = typeof(Decimal))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Number), Member = "StringToNumber", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(NumberStyles), typeof(NumberBuffer&), typeof(NumberFormatInfo), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Number), Member = "NumberBufferToDecimal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NumberBuffer&), typeof(Decimal&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Number), Member = "ThrowOverflowOrFormatException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	internal static decimal ParseDecimal(ReadOnlySpan<Char> value, NumberStyles styles, NumberFormatInfo info) { }

	[CalledBy(Type = typeof(double), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(double))]
	[CalledBy(Type = typeof(double), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(double))]
	[CalledBy(Type = typeof(double), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(NumberStyles), typeof(IFormatProvider)}, ReturnType = typeof(double))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Number), Member = "TryStringToNumber", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(NumberStyles), typeof(NumberBuffer&), typeof(NumberFormatInfo), typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Number), Member = "NumberToDouble", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NumberBuffer&)}, ReturnType = typeof(double))]
	[Calls(Type = typeof(MemoryExtensions), Member = "Trim", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>)}, ReturnType = typeof(System.ReadOnlySpan`1<System.Char>))]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[Calls(Type = typeof(Number), Member = "ThrowOverflowOrFormatException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 6)]
	[ContainsUnimplementedInstructions]
	internal static double ParseDouble(ReadOnlySpan<Char> value, NumberStyles styles, NumberFormatInfo info) { }

	[CalledBy(Type = typeof(Number), Member = "FormatDecimal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal), typeof(System.ReadOnlySpan`1<System.Char>), typeof(NumberFormatInfo)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(Number), Member = "TryFormatDecimal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal), typeof(System.ReadOnlySpan`1<System.Char>), typeof(NumberFormatInfo), typeof(System.Span`1<System.Char>), typeof(Int32&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Number), Member = "FormatDouble", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ValueStringBuilder&), typeof(double), typeof(System.ReadOnlySpan`1<System.Char>), typeof(NumberFormatInfo)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(Number), Member = "FormatSingle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ValueStringBuilder&), typeof(float), typeof(System.ReadOnlySpan`1<System.Char>), typeof(NumberFormatInfo)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(Number), Member = "FormatInt32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(System.ReadOnlySpan`1<System.Char>), typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(Number), Member = "TryFormatInt32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(System.ReadOnlySpan`1<System.Char>), typeof(IFormatProvider), typeof(System.Span`1<System.Char>), typeof(Int32&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Number), Member = "FormatUInt32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(System.ReadOnlySpan`1<System.Char>), typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(Number), Member = "TryFormatUInt32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(System.ReadOnlySpan`1<System.Char>), typeof(IFormatProvider), typeof(System.Span`1<System.Char>), typeof(Int32&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Number), Member = "FormatInt64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(System.ReadOnlySpan`1<System.Char>), typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(Number), Member = "TryFormatInt64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(System.ReadOnlySpan`1<System.Char>), typeof(IFormatProvider), typeof(System.Span`1<System.Char>), typeof(Int32&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Number), Member = "FormatUInt64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ulong), typeof(System.ReadOnlySpan`1<System.Char>), typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(Number), Member = "TryFormatUInt64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ulong), typeof(System.ReadOnlySpan`1<System.Char>), typeof(IFormatProvider), typeof(System.Span`1<System.Char>), typeof(Int32&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 12)]
	[CallsUnknownMethods(Count = 1)]
	internal static char ParseFormatSpecifier(ReadOnlySpan<Char> format, out int digits) { }

	[CalledBy(Type = typeof(byte), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(NumberStyles), typeof(NumberFormatInfo)}, ReturnType = typeof(byte))]
	[CalledBy(Type = typeof(short), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(NumberStyles), typeof(NumberFormatInfo)}, ReturnType = typeof(short))]
	[CalledBy(Type = typeof(int), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(int), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(NumberStyles)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(int), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(int), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(NumberStyles), typeof(IFormatProvider)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(int), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(NumberStyles), typeof(IFormatProvider)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(sbyte), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(NumberStyles), typeof(NumberFormatInfo)}, ReturnType = typeof(sbyte))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(Number), Member = "StringToNumber", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(NumberStyles), typeof(NumberBuffer&), typeof(NumberFormatInfo), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Number), Member = "TryParseUInt32HexNumberStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(NumberStyles), typeof(NumberFormatInfo), typeof(UInt32&), typeof(Boolean&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Number), Member = "TryParseInt32IntegerStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(NumberStyles), typeof(NumberFormatInfo), typeof(Int32&), typeof(Boolean&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Number), Member = "ThrowOverflowOrFormatException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	internal static int ParseInt32(ReadOnlySpan<Char> value, NumberStyles styles, NumberFormatInfo info) { }

	[CalledBy(Type = typeof(long), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(long))]
	[CalledBy(Type = typeof(long), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(long))]
	[CalledBy(Type = typeof(long), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(NumberStyles), typeof(IFormatProvider)}, ReturnType = typeof(long))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Number), Member = "StringToNumber", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(NumberStyles), typeof(NumberBuffer&), typeof(NumberFormatInfo), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Number), Member = "TryParseUInt64HexNumberStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(NumberStyles), typeof(NumberFormatInfo), typeof(UInt64&), typeof(Boolean&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Number), Member = "TryParseInt64IntegerStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(NumberStyles), typeof(NumberFormatInfo), typeof(Int64&), typeof(Boolean&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Number), Member = "ThrowOverflowOrFormatException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	internal static long ParseInt64(ReadOnlySpan<Char> value, NumberStyles styles, NumberFormatInfo info) { }

	[CalledBy(Type = typeof(Number), Member = "StringToNumber", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(NumberStyles), typeof(NumberBuffer&), typeof(NumberFormatInfo), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Number), Member = "TryStringToNumber", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(NumberStyles), typeof(NumberBuffer&), typeof(NumberFormatInfo), typeof(bool)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(NumberBuffer), Member = "set_sign", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RuntimeHelpers), Member = "get_OffsetToStringData", ReturnType = typeof(int))]
	[Calls(Type = typeof(Number), Member = "MatchChars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(Char*), typeof(string)}, ReturnType = typeof(Char*))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private static bool ParseNumber(ref Char* str, Char* strEnd, NumberStyles styles, ref NumberBuffer number, NumberFormatInfo info, bool parseDecimal) { }

	[CalledBy(Type = typeof(float), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(float))]
	[CalledBy(Type = typeof(float), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(NumberStyles), typeof(IFormatProvider)}, ReturnType = typeof(float))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Number), Member = "TryStringToNumber", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(NumberStyles), typeof(NumberBuffer&), typeof(NumberFormatInfo), typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Number), Member = "NumberToDouble", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NumberBuffer&)}, ReturnType = typeof(double))]
	[Calls(Type = typeof(MemoryExtensions), Member = "Trim", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>)}, ReturnType = typeof(System.ReadOnlySpan`1<System.Char>))]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[Calls(Type = typeof(Number), Member = "ThrowOverflowOrFormatException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 7)]
	[ContainsUnimplementedInstructions]
	internal static float ParseSingle(ReadOnlySpan<Char> value, NumberStyles styles, NumberFormatInfo info) { }

	[CalledBy(Type = typeof(ushort), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(NumberStyles), typeof(NumberFormatInfo)}, ReturnType = typeof(ushort))]
	[CalledBy(Type = typeof(uint), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(uint))]
	[CalledBy(Type = typeof(uint), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(uint))]
	[CalledBy(Type = typeof(uint), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(NumberStyles), typeof(IFormatProvider)}, ReturnType = typeof(uint))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Number), Member = "StringToNumber", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(NumberStyles), typeof(NumberBuffer&), typeof(NumberFormatInfo), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Number), Member = "TryParseUInt32HexNumberStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(NumberStyles), typeof(NumberFormatInfo), typeof(UInt32&), typeof(Boolean&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Number), Member = "TryParseUInt32IntegerStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(NumberStyles), typeof(NumberFormatInfo), typeof(UInt32&), typeof(Boolean&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Number), Member = "ThrowOverflowOrFormatException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	internal static uint ParseUInt32(ReadOnlySpan<Char> value, NumberStyles styles, NumberFormatInfo info) { }

	[CalledBy(Type = typeof(ulong), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(ulong))]
	[CalledBy(Type = typeof(ulong), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(NumberStyles), typeof(IFormatProvider)}, ReturnType = typeof(ulong))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Number), Member = "StringToNumber", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(NumberStyles), typeof(NumberBuffer&), typeof(NumberFormatInfo), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Number), Member = "TryParseUInt64HexNumberStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(NumberStyles), typeof(NumberFormatInfo), typeof(UInt64&), typeof(Boolean&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Number), Member = "TryParseUInt64IntegerStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(NumberStyles), typeof(NumberFormatInfo), typeof(UInt64&), typeof(Boolean&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Number), Member = "ThrowOverflowOrFormatException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	internal static ulong ParseUInt64(ReadOnlySpan<Char> value, NumberStyles styles, NumberFormatInfo info) { }

	[CalledBy(Type = typeof(Number), Member = "NumberToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ValueStringBuilder&), typeof(NumberBuffer&), typeof(char), typeof(int), typeof(NumberFormatInfo), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(NumberBuffer), Member = "set_sign", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	private static void RoundNumber(ref NumberBuffer number, int pos) { }

	[CalledBy(Type = typeof(Number), Member = "ParseInt32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(NumberStyles), typeof(NumberFormatInfo)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(Number), Member = "ParseInt64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(NumberStyles), typeof(NumberFormatInfo)}, ReturnType = typeof(long))]
	[CalledBy(Type = typeof(Number), Member = "ParseUInt32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(NumberStyles), typeof(NumberFormatInfo)}, ReturnType = typeof(uint))]
	[CalledBy(Type = typeof(Number), Member = "ParseUInt64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(NumberStyles), typeof(NumberFormatInfo)}, ReturnType = typeof(ulong))]
	[CalledBy(Type = typeof(Number), Member = "ParseDecimal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(NumberStyles), typeof(NumberFormatInfo)}, ReturnType = typeof(Decimal))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(Number), Member = "ParseNumber", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*&), typeof(Char*), typeof(NumberStyles), typeof(NumberBuffer&), typeof(NumberFormatInfo), typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Number), Member = "ThrowOverflowOrFormatException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private static void StringToNumber(ReadOnlySpan<Char> value, NumberStyles styles, ref NumberBuffer number, NumberFormatInfo info, bool parseDecimal) { }

	[CalledBy(Type = typeof(Number), Member = "ParseInt32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(NumberStyles), typeof(NumberFormatInfo)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(Number), Member = "ParseInt64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(NumberStyles), typeof(NumberFormatInfo)}, ReturnType = typeof(long))]
	[CalledBy(Type = typeof(Number), Member = "ParseUInt32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(NumberStyles), typeof(NumberFormatInfo)}, ReturnType = typeof(uint))]
	[CalledBy(Type = typeof(Number), Member = "ParseUInt64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(NumberStyles), typeof(NumberFormatInfo)}, ReturnType = typeof(ulong))]
	[CalledBy(Type = typeof(Number), Member = "ParseDecimal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(NumberStyles), typeof(NumberFormatInfo)}, ReturnType = typeof(Decimal))]
	[CalledBy(Type = typeof(Number), Member = "ParseDouble", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(NumberStyles), typeof(NumberFormatInfo)}, ReturnType = typeof(double))]
	[CalledBy(Type = typeof(Number), Member = "ParseSingle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(NumberStyles), typeof(NumberFormatInfo)}, ReturnType = typeof(float))]
	[CalledBy(Type = typeof(Number), Member = "StringToNumber", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(NumberStyles), typeof(NumberBuffer&), typeof(NumberFormatInfo), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 19)]
	[Calls(Type = typeof(OverflowException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FormatException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	private static void ThrowOverflowOrFormatException(bool overflow, string overflowResourceKey) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private static bool TrailingZeros(ReadOnlySpan<Char> value, int index) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[Calls(Type = typeof(ReadOnlySpan`1), Member = "TryCopyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Span`1<T>"}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	private static bool TryCopyTo(string source, Span<Char> destination, out int charsWritten) { }

	[CalledBy(Type = typeof(Decimal), Member = "TryFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Span`1<System.Char>), typeof(Int32&), typeof(System.ReadOnlySpan`1<System.Char>), typeof(IFormatProvider)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Number), Member = "ParseFormatSpecifier", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(Int32&)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(Number), Member = "DecimalToNumber", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal), typeof(NumberBuffer&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Number), Member = "NumberToStringFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ValueStringBuilder&), typeof(NumberBuffer&), typeof(System.ReadOnlySpan`1<System.Char>), typeof(NumberFormatInfo)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Number), Member = "NumberToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ValueStringBuilder&), typeof(NumberBuffer&), typeof(char), typeof(int), typeof(NumberFormatInfo), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ValueStringBuilder), Member = "TryCopyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Span`1<System.Char>), typeof(Int32&)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	public static bool TryFormatDecimal(decimal value, ReadOnlySpan<Char> format, NumberFormatInfo info, Span<Char> destination, out int charsWritten) { }

	[CalledBy(Type = typeof(double), Member = "TryFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Span`1<System.Char>), typeof(Int32&), typeof(System.ReadOnlySpan`1<System.Char>), typeof(IFormatProvider)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Number), Member = "FormatDouble", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ValueStringBuilder&), typeof(double), typeof(System.ReadOnlySpan`1<System.Char>), typeof(NumberFormatInfo)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[Calls(Type = typeof(ReadOnlySpan`1), Member = "TryCopyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Span`1<T>"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ValueStringBuilder), Member = "TryCopyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Span`1<System.Char>), typeof(Int32&)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	public static bool TryFormatDouble(double value, ReadOnlySpan<Char> format, NumberFormatInfo info, Span<Char> destination, out int charsWritten) { }

	[CalledBy(Type = typeof(byte), Member = "TryFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Span`1<System.Char>), typeof(Int32&), typeof(System.ReadOnlySpan`1<System.Char>), typeof(IFormatProvider)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(short), Member = "TryFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Span`1<System.Char>), typeof(Int32&), typeof(System.ReadOnlySpan`1<System.Char>), typeof(IFormatProvider)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(int), Member = "TryFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Span`1<System.Char>), typeof(Int32&), typeof(System.ReadOnlySpan`1<System.Char>), typeof(IFormatProvider)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(sbyte), Member = "TryFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Span`1<System.Char>), typeof(Int32&), typeof(System.ReadOnlySpan`1<System.Char>), typeof(IFormatProvider)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(NumberFormatInfo), Member = "GetInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(NumberFormatInfo))]
	[Calls(Type = typeof(Number), Member = "TryUInt32ToDecStr", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(int), typeof(System.Span`1<System.Char>), typeof(Int32&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Number), Member = "ParseFormatSpecifier", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(Int32&)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(Number), Member = "NumberToStringFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ValueStringBuilder&), typeof(NumberBuffer&), typeof(System.ReadOnlySpan`1<System.Char>), typeof(NumberFormatInfo)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Number), Member = "NumberToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ValueStringBuilder&), typeof(NumberBuffer&), typeof(char), typeof(int), typeof(NumberFormatInfo), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ValueStringBuilder), Member = "TryCopyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Span`1<System.Char>), typeof(Int32&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Number), Member = "TryInt32ToHexStr", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(char), typeof(int), typeof(System.Span`1<System.Char>), typeof(Int32&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(FormattingHelpers), Member = "CountDigits", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	public static bool TryFormatInt32(int value, ReadOnlySpan<Char> format, IFormatProvider provider, Span<Char> destination, out int charsWritten) { }

	[CalledBy(Type = typeof(long), Member = "TryFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Span`1<System.Char>), typeof(Int32&), typeof(System.ReadOnlySpan`1<System.Char>), typeof(IFormatProvider)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Number), Member = "TryUInt64ToDecStr", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ulong), typeof(int), typeof(System.Span`1<System.Char>), typeof(Int32&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Number), Member = "ParseFormatSpecifier", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(Int32&)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(NumberFormatInfo), Member = "GetInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(NumberFormatInfo))]
	[Calls(Type = typeof(Number), Member = "Int64ToNumber", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(NumberBuffer&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Number), Member = "NumberToStringFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ValueStringBuilder&), typeof(NumberBuffer&), typeof(System.ReadOnlySpan`1<System.Char>), typeof(NumberFormatInfo)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Number), Member = "NumberToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ValueStringBuilder&), typeof(NumberBuffer&), typeof(char), typeof(int), typeof(NumberFormatInfo), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ValueStringBuilder), Member = "TryCopyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Span`1<System.Char>), typeof(Int32&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Number), Member = "TryInt64ToHexStr", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(char), typeof(int), typeof(System.Span`1<System.Char>), typeof(Int32&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Number), Member = "TryNegativeInt64ToDecStr", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(int), typeof(string), typeof(System.Span`1<System.Char>), typeof(Int32&)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static bool TryFormatInt64(long value, ReadOnlySpan<Char> format, IFormatProvider provider, Span<Char> destination, out int charsWritten) { }

	[CalledBy(Type = typeof(float), Member = "TryFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Span`1<System.Char>), typeof(Int32&), typeof(System.ReadOnlySpan`1<System.Char>), typeof(IFormatProvider)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Number), Member = "FormatSingle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ValueStringBuilder&), typeof(float), typeof(System.ReadOnlySpan`1<System.Char>), typeof(NumberFormatInfo)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[Calls(Type = typeof(ReadOnlySpan`1), Member = "TryCopyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Span`1<T>"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ValueStringBuilder), Member = "TryCopyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Span`1<System.Char>), typeof(Int32&)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	public static bool TryFormatSingle(float value, ReadOnlySpan<Char> format, NumberFormatInfo info, Span<Char> destination, out int charsWritten) { }

	[CalledBy(Type = typeof(short), Member = "TryFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Span`1<System.Char>), typeof(Int32&), typeof(System.ReadOnlySpan`1<System.Char>), typeof(IFormatProvider)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(sbyte), Member = "TryFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Span`1<System.Char>), typeof(Int32&), typeof(System.ReadOnlySpan`1<System.Char>), typeof(IFormatProvider)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ushort), Member = "TryFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Span`1<System.Char>), typeof(Int32&), typeof(System.ReadOnlySpan`1<System.Char>), typeof(IFormatProvider)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(uint), Member = "TryFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Span`1<System.Char>), typeof(Int32&), typeof(System.ReadOnlySpan`1<System.Char>), typeof(IFormatProvider)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Number), Member = "ParseFormatSpecifier", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(Int32&)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(NumberFormatInfo), Member = "GetInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(NumberFormatInfo))]
	[Calls(Type = typeof(FormattingHelpers), Member = "CountDigits", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Number), Member = "NumberToStringFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ValueStringBuilder&), typeof(NumberBuffer&), typeof(System.ReadOnlySpan`1<System.Char>), typeof(NumberFormatInfo)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Number), Member = "NumberToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ValueStringBuilder&), typeof(NumberBuffer&), typeof(char), typeof(int), typeof(NumberFormatInfo), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ValueStringBuilder), Member = "TryCopyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Span`1<System.Char>), typeof(Int32&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Number), Member = "TryInt32ToHexStr", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(char), typeof(int), typeof(System.Span`1<System.Char>), typeof(Int32&)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public static bool TryFormatUInt32(uint value, ReadOnlySpan<Char> format, IFormatProvider provider, Span<Char> destination, out int charsWritten) { }

	[CalledBy(Type = typeof(ulong), Member = "TryFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Span`1<System.Char>), typeof(Int32&), typeof(System.ReadOnlySpan`1<System.Char>), typeof(IFormatProvider)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Number), Member = "ParseFormatSpecifier", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(Int32&)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(NumberFormatInfo), Member = "GetInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(NumberFormatInfo))]
	[Calls(Type = typeof(Number), Member = "UInt64ToNumber", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ulong), typeof(NumberBuffer&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Number), Member = "NumberToStringFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ValueStringBuilder&), typeof(NumberBuffer&), typeof(System.ReadOnlySpan`1<System.Char>), typeof(NumberFormatInfo)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Number), Member = "NumberToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ValueStringBuilder&), typeof(NumberBuffer&), typeof(char), typeof(int), typeof(NumberFormatInfo), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ValueStringBuilder), Member = "TryCopyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Span`1<System.Char>), typeof(Int32&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Number), Member = "TryInt64ToHexStr", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(char), typeof(int), typeof(System.Span`1<System.Char>), typeof(Int32&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Number), Member = "TryUInt64ToDecStr", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ulong), typeof(int), typeof(System.Span`1<System.Char>), typeof(Int32&)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	public static bool TryFormatUInt64(ulong value, ReadOnlySpan<Char> format, IFormatProvider provider, Span<Char> destination, out int charsWritten) { }

	[CalledBy(Type = typeof(Number), Member = "TryFormatInt32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(System.ReadOnlySpan`1<System.Char>), typeof(IFormatProvider), typeof(System.Span`1<System.Char>), typeof(Int32&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Number), Member = "TryFormatUInt32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(System.ReadOnlySpan`1<System.Char>), typeof(IFormatProvider), typeof(System.Span`1<System.Char>), typeof(Int32&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	private static bool TryInt32ToHexStr(int value, char hexBase, int digits, Span<Char> destination, out int charsWritten) { }

	[CalledBy(Type = typeof(Number), Member = "TryFormatInt64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(System.ReadOnlySpan`1<System.Char>), typeof(IFormatProvider), typeof(System.Span`1<System.Char>), typeof(Int32&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Number), Member = "TryFormatUInt64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ulong), typeof(System.ReadOnlySpan`1<System.Char>), typeof(IFormatProvider), typeof(System.Span`1<System.Char>), typeof(Int32&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	private static bool TryInt64ToHexStr(long value, char hexBase, int digits, Span<Char> destination, out int charsWritten) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FormattingHelpers), Member = "CountDigits", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private static bool TryNegativeInt32ToDecStr(int value, int digits, string sNegative, Span<Char> destination, out int charsWritten) { }

	[CalledBy(Type = typeof(Number), Member = "TryFormatInt64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(System.ReadOnlySpan`1<System.Char>), typeof(IFormatProvider), typeof(System.Span`1<System.Char>), typeof(Int32&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(FormattingHelpers), Member = "CountDigits", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ulong)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private static bool TryNegativeInt64ToDecStr(long input, int digits, string sNegative, Span<Char> destination, out int charsWritten) { }

	[CalledBy(Type = typeof(Decimal), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(NumberStyles), typeof(IFormatProvider), typeof(Decimal&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Number), Member = "TryStringToNumber", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(NumberStyles), typeof(NumberBuffer&), typeof(NumberFormatInfo), typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Number), Member = "NumberBufferToDecimal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NumberBuffer&), typeof(Decimal&)}, ReturnType = typeof(bool))]
	internal static bool TryParseDecimal(ReadOnlySpan<Char> value, NumberStyles styles, NumberFormatInfo info, out decimal result) { }

	[CalledBy(Type = typeof(double), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(NumberStyles), typeof(NumberFormatInfo), typeof(Double&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Number), Member = "TryStringToNumber", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(NumberStyles), typeof(NumberBuffer&), typeof(NumberFormatInfo), typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Number), Member = "NumberToDouble", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NumberBuffer&)}, ReturnType = typeof(double))]
	[ContainsUnimplementedInstructions]
	internal static bool TryParseDouble(ReadOnlySpan<Char> value, NumberStyles styles, NumberFormatInfo info, out double result) { }

	[CalledBy(Type = typeof(byte), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Byte&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(byte), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(NumberStyles), typeof(IFormatProvider), typeof(Byte&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(byte), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(NumberStyles), typeof(NumberFormatInfo), typeof(Byte&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(short), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(NumberStyles), typeof(NumberFormatInfo), typeof(Int16&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(int), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(NumberStyles), typeof(IFormatProvider), typeof(Int32&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(int), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(NumberStyles), typeof(IFormatProvider), typeof(Int32&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(sbyte), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(SByte&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(sbyte), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(NumberStyles), typeof(NumberFormatInfo), typeof(SByte&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(Number), Member = "TryStringToNumber", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(NumberStyles), typeof(NumberBuffer&), typeof(NumberFormatInfo), typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Number), Member = "NumberToInt32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NumberBuffer&), typeof(Int32&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Number), Member = "TryParseUInt32HexNumberStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(NumberStyles), typeof(NumberFormatInfo), typeof(UInt32&), typeof(Boolean&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Number), Member = "TryParseInt32IntegerStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(NumberStyles), typeof(NumberFormatInfo), typeof(Int32&), typeof(Boolean&)}, ReturnType = typeof(bool))]
	[ContainsUnimplementedInstructions]
	internal static bool TryParseInt32(ReadOnlySpan<Char> value, NumberStyles styles, NumberFormatInfo info, out int result) { }

	[CalledBy(Type = typeof(short), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Int16&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(int), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Int32&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Number), Member = "ParseInt32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(NumberStyles), typeof(NumberFormatInfo)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(Number), Member = "TryParseInt32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(NumberStyles), typeof(NumberFormatInfo), typeof(Int32&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	[ContainsUnimplementedInstructions]
	private static bool TryParseInt32IntegerStyle(ReadOnlySpan<Char> value, NumberStyles styles, NumberFormatInfo info, out int result, ref bool failureIsOverflow) { }

	[CalledBy(Type = typeof(long), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(NumberStyles), typeof(IFormatProvider), typeof(Int64&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Number), Member = "TryStringToNumber", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(NumberStyles), typeof(NumberBuffer&), typeof(NumberFormatInfo), typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Number), Member = "NumberToInt64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NumberBuffer&), typeof(Int64&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Number), Member = "TryParseUInt64HexNumberStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(NumberStyles), typeof(NumberFormatInfo), typeof(UInt64&), typeof(Boolean&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Number), Member = "TryParseInt64IntegerStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(NumberStyles), typeof(NumberFormatInfo), typeof(Int64&), typeof(Boolean&)}, ReturnType = typeof(bool))]
	[ContainsUnimplementedInstructions]
	internal static bool TryParseInt64(ReadOnlySpan<Char> value, NumberStyles styles, NumberFormatInfo info, out long result) { }

	[CalledBy(Type = typeof(long), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Int64&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Number), Member = "ParseInt64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(NumberStyles), typeof(NumberFormatInfo)}, ReturnType = typeof(long))]
	[CalledBy(Type = typeof(Number), Member = "TryParseInt64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(NumberStyles), typeof(NumberFormatInfo), typeof(Int64&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	[ContainsUnimplementedInstructions]
	private static bool TryParseInt64IntegerStyle(ReadOnlySpan<Char> value, NumberStyles styles, NumberFormatInfo info, out long result, ref bool failureIsOverflow) { }

	[CalledBy(Type = typeof(float), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(NumberStyles), typeof(NumberFormatInfo), typeof(Single&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Number), Member = "TryStringToNumber", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(NumberStyles), typeof(NumberBuffer&), typeof(NumberFormatInfo), typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Number), Member = "NumberToDouble", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NumberBuffer&)}, ReturnType = typeof(double))]
	[ContainsUnimplementedInstructions]
	internal static bool TryParseSingle(ReadOnlySpan<Char> value, NumberStyles styles, NumberFormatInfo info, out float result) { }

	[CalledBy(Type = typeof(ushort), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(UInt16&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ushort), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(NumberStyles), typeof(IFormatProvider), typeof(UInt16&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ushort), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(NumberStyles), typeof(NumberFormatInfo), typeof(UInt16&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(uint), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(UInt32&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(uint), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(NumberStyles), typeof(IFormatProvider), typeof(UInt32&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(Number), Member = "TryStringToNumber", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(NumberStyles), typeof(NumberBuffer&), typeof(NumberFormatInfo), typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Number), Member = "NumberToUInt32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NumberBuffer&), typeof(UInt32&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Number), Member = "TryParseUInt32HexNumberStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(NumberStyles), typeof(NumberFormatInfo), typeof(UInt32&), typeof(Boolean&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Number), Member = "TryParseUInt32IntegerStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(NumberStyles), typeof(NumberFormatInfo), typeof(UInt32&), typeof(Boolean&)}, ReturnType = typeof(bool))]
	[ContainsUnimplementedInstructions]
	internal static bool TryParseUInt32(ReadOnlySpan<Char> value, NumberStyles styles, NumberFormatInfo info, out uint result) { }

	[CalledBy(Type = typeof(Number), Member = "ParseInt32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(NumberStyles), typeof(NumberFormatInfo)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(Number), Member = "ParseUInt32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(NumberStyles), typeof(NumberFormatInfo)}, ReturnType = typeof(uint))]
	[CalledBy(Type = typeof(Number), Member = "TryParseInt32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(NumberStyles), typeof(NumberFormatInfo), typeof(Int32&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Number), Member = "TryParseUInt32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(NumberStyles), typeof(NumberFormatInfo), typeof(UInt32&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 4)]
	[CallsUnknownMethods(Count = 2)]
	private static bool TryParseUInt32HexNumberStyle(ReadOnlySpan<Char> value, NumberStyles styles, NumberFormatInfo info, out uint result, ref bool failureIsOverflow) { }

	[CalledBy(Type = typeof(Number), Member = "ParseUInt32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(NumberStyles), typeof(NumberFormatInfo)}, ReturnType = typeof(uint))]
	[CalledBy(Type = typeof(Number), Member = "TryParseUInt32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(NumberStyles), typeof(NumberFormatInfo), typeof(UInt32&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	private static bool TryParseUInt32IntegerStyle(ReadOnlySpan<Char> value, NumberStyles styles, NumberFormatInfo info, out uint result, ref bool failureIsOverflow) { }

	[CalledBy(Type = typeof(ulong), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(UInt64&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ulong), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(NumberStyles), typeof(IFormatProvider), typeof(UInt64&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Number), Member = "TryStringToNumber", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(NumberStyles), typeof(NumberBuffer&), typeof(NumberFormatInfo), typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Number), Member = "NumberToUInt64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NumberBuffer&), typeof(UInt64&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Number), Member = "TryParseUInt64HexNumberStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(NumberStyles), typeof(NumberFormatInfo), typeof(UInt64&), typeof(Boolean&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Number), Member = "TryParseUInt64IntegerStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(NumberStyles), typeof(NumberFormatInfo), typeof(UInt64&), typeof(Boolean&)}, ReturnType = typeof(bool))]
	[ContainsUnimplementedInstructions]
	internal static bool TryParseUInt64(ReadOnlySpan<Char> value, NumberStyles styles, NumberFormatInfo info, out ulong result) { }

	[CalledBy(Type = typeof(Number), Member = "ParseInt64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(NumberStyles), typeof(NumberFormatInfo)}, ReturnType = typeof(long))]
	[CalledBy(Type = typeof(Number), Member = "ParseUInt64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(NumberStyles), typeof(NumberFormatInfo)}, ReturnType = typeof(ulong))]
	[CalledBy(Type = typeof(Number), Member = "TryParseInt64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(NumberStyles), typeof(NumberFormatInfo), typeof(Int64&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Number), Member = "TryParseUInt64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(NumberStyles), typeof(NumberFormatInfo), typeof(UInt64&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 4)]
	[CallsUnknownMethods(Count = 2)]
	private static bool TryParseUInt64HexNumberStyle(ReadOnlySpan<Char> value, NumberStyles styles, NumberFormatInfo info, out ulong result, ref bool failureIsOverflow) { }

	[CalledBy(Type = typeof(Number), Member = "ParseUInt64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(NumberStyles), typeof(NumberFormatInfo)}, ReturnType = typeof(ulong))]
	[CalledBy(Type = typeof(Number), Member = "TryParseUInt64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(NumberStyles), typeof(NumberFormatInfo), typeof(UInt64&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	private static bool TryParseUInt64IntegerStyle(ReadOnlySpan<Char> value, NumberStyles styles, NumberFormatInfo info, out ulong result, ref bool failureIsOverflow) { }

	[CalledBy(Type = typeof(Number), Member = "TryParseInt32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(NumberStyles), typeof(NumberFormatInfo), typeof(Int32&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Number), Member = "TryParseInt64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(NumberStyles), typeof(NumberFormatInfo), typeof(Int64&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Number), Member = "TryParseUInt32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(NumberStyles), typeof(NumberFormatInfo), typeof(UInt32&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Number), Member = "TryParseUInt64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(NumberStyles), typeof(NumberFormatInfo), typeof(UInt64&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Number), Member = "ParseDouble", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(NumberStyles), typeof(NumberFormatInfo)}, ReturnType = typeof(double))]
	[CalledBy(Type = typeof(Number), Member = "ParseSingle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(NumberStyles), typeof(NumberFormatInfo)}, ReturnType = typeof(float))]
	[CalledBy(Type = typeof(Number), Member = "TryParseDecimal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(NumberStyles), typeof(NumberFormatInfo), typeof(Decimal&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Number), Member = "TryParseDouble", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(NumberStyles), typeof(NumberFormatInfo), typeof(Double&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Number), Member = "TryParseSingle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(NumberStyles), typeof(NumberFormatInfo), typeof(Single&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(Number), Member = "ParseNumber", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*&), typeof(Char*), typeof(NumberStyles), typeof(NumberBuffer&), typeof(NumberFormatInfo), typeof(bool)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	internal static bool TryStringToNumber(ReadOnlySpan<Char> value, NumberStyles styles, ref NumberBuffer number, NumberFormatInfo info, bool parseDecimal) { }

	[CalledBy(Type = typeof(Number), Member = "TryFormatInt32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(System.ReadOnlySpan`1<System.Char>), typeof(IFormatProvider), typeof(System.Span`1<System.Char>), typeof(Int32&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(FormattingHelpers), Member = "CountDigits", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private static bool TryUInt32ToDecStr(uint value, int digits, Span<Char> destination, out int charsWritten) { }

	[CalledBy(Type = typeof(Number), Member = "TryFormatInt64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(System.ReadOnlySpan`1<System.Char>), typeof(IFormatProvider), typeof(System.Span`1<System.Char>), typeof(Int32&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Number), Member = "TryFormatUInt64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ulong), typeof(System.ReadOnlySpan`1<System.Char>), typeof(IFormatProvider), typeof(System.Span`1<System.Char>), typeof(Int32&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(FormattingHelpers), Member = "CountDigits", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ulong)}, ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private static bool TryUInt64ToDecStr(ulong value, int digits, Span<Char> destination, out int charsWritten) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	internal static Char* UInt32ToDecChars(Char* bufferEnd, uint value, int digits) { }

	[CalledBy(Type = typeof(Number), Member = "FormatInt32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(System.ReadOnlySpan`1<System.Char>), typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(Number), Member = "FormatUInt32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(System.ReadOnlySpan`1<System.Char>), typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(FormattingHelpers), Member = "CountDigits", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(string), Member = "FastAllocateString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(RuntimeHelpers), Member = "get_OffsetToStringData", ReturnType = typeof(int))]
	[ContainsUnimplementedInstructions]
	private static string UInt32ToDecStr(uint value, int digits) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NumberBuffer), Member = "set_sign", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	private static void UInt32ToNumber(uint value, ref NumberBuffer number) { }

	[CalledBy(Type = typeof(Number), Member = "FormatInt64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(System.ReadOnlySpan`1<System.Char>), typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(Number), Member = "FormatUInt64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ulong), typeof(System.ReadOnlySpan`1<System.Char>), typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(FormattingHelpers), Member = "CountDigits", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ulong)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(string), Member = "FastAllocateString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(RuntimeHelpers), Member = "get_OffsetToStringData", ReturnType = typeof(int))]
	[ContainsUnimplementedInstructions]
	private static string UInt64ToDecStr(ulong value, int digits) { }

	[CalledBy(Type = typeof(Number), Member = "FormatUInt64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ulong), typeof(System.ReadOnlySpan`1<System.Char>), typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(Number), Member = "TryFormatUInt64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ulong), typeof(System.ReadOnlySpan`1<System.Char>), typeof(IFormatProvider), typeof(System.Span`1<System.Char>), typeof(Int32&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(NumberBuffer), Member = "set_sign", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	private static void UInt64ToNumber(ulong value, ref NumberBuffer number) { }

}

