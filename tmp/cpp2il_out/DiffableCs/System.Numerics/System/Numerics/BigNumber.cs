namespace System.Numerics;

internal static class BigNumber
{
	private struct BigNumberBuffer
	{
		public StringBuilder digits; //Field offset: 0x0
		public int precision; //Field offset: 0x8
		public int scale; //Field offset: 0xC
		public bool sign; //Field offset: 0x10

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(StringBuilder), Member = ".ctor", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		public static BigNumberBuffer Create() { }

	}


	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[Calls(Type = typeof(BigNumber), Member = "FormatBigInteger", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(BigInteger), typeof(string), typeof(System.ReadOnlySpan`1<System.Char>), typeof(NumberFormatInfo), typeof(System.Span`1<System.Char>), typeof(Int32&), typeof(Boolean&)}, ReturnType = typeof(string))]
	internal static string FormatBigInteger(BigInteger value, string format, NumberFormatInfo info) { }

	[CalledBy(Type = typeof(BigInteger), Member = "ToString", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(BigInteger), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(BigInteger), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(BigNumber), Member = "FormatBigInteger", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger), typeof(string), typeof(NumberFormatInfo)}, ReturnType = typeof(string))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(string), Member = "CreateString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ValueStringBuilder), Member = "TryCopyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Span`1<System.Char>), typeof(Int32&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ValueStringBuilder), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = "System.Globalization.FormatProvider+Number", Member = "NumberToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ValueStringBuilder&), typeof(NumberBuffer&), typeof(char), typeof(int), typeof(NumberFormatInfo), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = "System.Globalization.FormatProvider+Number", Member = "NumberToStringFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ValueStringBuilder&), typeof(NumberBuffer&), typeof(System.ReadOnlySpan`1<System.Char>), typeof(NumberFormatInfo)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ReadOnlySpan`1), Member = "TryCopyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Span`1<T>"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(FormatException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Exception)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(int), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[Calls(Type = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(BigNumber), Member = "FormatBigIntegerToHex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(BigInteger), typeof(char), typeof(int), typeof(NumberFormatInfo), typeof(System.Span`1<System.Char>), typeof(Int32&), typeof(Boolean&)}, ReturnType = typeof(string))]
	[Calls(Type = "System.Globalization.FormatProvider+Number", Member = "ParseFormatSpecifier", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(Int32&)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(int), Member = "TryFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Span`1<System.Char>), typeof(Int32&), typeof(System.ReadOnlySpan`1<System.Char>), typeof(IFormatProvider)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 33)]
	[ContainsUnimplementedInstructions]
	private static string FormatBigInteger(bool targetSpan, BigInteger value, string formatString, ReadOnlySpan<Char> formatSpan, NumberFormatInfo info, Span<Char> destination, out int charsWritten, out bool spanSuccess) { }

	[CalledBy(Type = typeof(BigNumber), Member = "FormatBigInteger", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(BigInteger), typeof(string), typeof(System.ReadOnlySpan`1<System.Char>), typeof(NumberFormatInfo), typeof(System.Span`1<System.Char>), typeof(Int32&), typeof(Boolean&)}, ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BigInteger), Member = "TryGetBytes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Numerics.BigInteger+GetBytesMode", typeof(System.Span`1<System.Byte>), typeof(bool), typeof(bool), typeof(Int32&)}, ReturnType = typeof(Byte[]))]
	[Calls(Type = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
	[Calls(Type = typeof(ValueStringBuilder), Member = "Grow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(ValueStringBuilder), Member = "Insert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(char), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Span`1), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Span`1<T>"}, ReturnType = "System.ReadOnlySpan`1<T>")]
	[Calls(Type = typeof(string), Member = "CreateString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Span`1), Member = "TryCopyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Span`1<T>"}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 14)]
	[ContainsUnimplementedInstructions]
	private static string FormatBigIntegerToHex(bool targetSpan, BigInteger value, char format, int digits, NumberFormatInfo info, Span<Char> destination, out int charsWritten, out bool spanSuccess) { }

	[CalledBy(Type = typeof(BigNumber), Member = "TryParseBigInteger", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(NumberStyles), typeof(NumberFormatInfo), typeof(BigInteger&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(StringBuilder), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(BigInteger), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Byte>), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 7)]
	[ContainsUnimplementedInstructions]
	private static bool HexNumberToBigInteger(ref BigNumberBuffer number, ref BigInteger value) { }

	[CalledBy(Type = typeof(BigNumber), Member = "TryParseBigInteger", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(NumberStyles), typeof(NumberFormatInfo), typeof(BigInteger&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BigInteger), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger), typeof(BigInteger)}, ReturnType = typeof(BigInteger))]
	[Calls(Type = typeof(StringBuilder), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(BigInteger), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BigInteger), Member = "op_Addition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger), typeof(BigInteger)}, ReturnType = typeof(BigInteger))]
	[CallsUnknownMethods(Count = 8)]
	[ContainsUnimplementedInstructions]
	private static bool NumberToBigInteger(ref BigNumberBuffer number, ref BigInteger value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[Calls(Type = typeof(BigNumber), Member = "TryValidateParseStyleInteger", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NumberStyles), typeof(ArgumentException&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BigNumber), Member = "TryParseBigInteger", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(NumberStyles), typeof(NumberFormatInfo), typeof(BigInteger&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FormatException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 10)]
	internal static BigInteger ParseBigInteger(string value, NumberStyles style, NumberFormatInfo info) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BigNumber), Member = "TryValidateParseStyleInteger", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NumberStyles), typeof(ArgumentException&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BigNumber), Member = "TryParseBigInteger", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(NumberStyles), typeof(NumberFormatInfo), typeof(BigInteger&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(FormatException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 6)]
	internal static BigInteger ParseBigInteger(ReadOnlySpan<Char> value, NumberStyles style, NumberFormatInfo info) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	internal static char ParseFormatSpecifier(ReadOnlySpan<Char> format, out int digits) { }

	[CalledBy(Type = typeof(BigInteger), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(NumberStyles), typeof(IFormatProvider)}, ReturnType = typeof(BigInteger))]
	[CalledBy(Type = typeof(BigNumber), Member = "ParseBigInteger", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(NumberStyles), typeof(NumberFormatInfo)}, ReturnType = typeof(BigInteger))]
	[CalledBy(Type = typeof(BigNumber), Member = "ParseBigInteger", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(NumberStyles), typeof(NumberFormatInfo)}, ReturnType = typeof(BigInteger))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(BigNumber), Member = "TryValidateParseStyleInteger", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NumberStyles), typeof(ArgumentException&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = "System.Globalization.FormatProvider+Number", Member = "ParseNumber", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*&), typeof(Char*), typeof(NumberStyles), typeof(NumberBuffer&), typeof(StringBuilder), typeof(NumberFormatInfo), typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BigNumber), Member = "NumberToBigInteger", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigNumberBuffer&), typeof(BigInteger&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BigNumber), Member = "HexNumberToBigInteger", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigNumberBuffer&), typeof(BigInteger&)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	[ContainsUnimplementedInstructions]
	internal static bool TryParseBigInteger(ReadOnlySpan<Char> value, NumberStyles style, NumberFormatInfo info, out BigInteger result) { }

	[CalledBy(Type = typeof(BigInteger), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(NumberStyles), typeof(IFormatProvider)}, ReturnType = typeof(BigInteger))]
	[CalledBy(Type = typeof(BigNumber), Member = "TryParseBigInteger", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(NumberStyles), typeof(NumberFormatInfo), typeof(BigInteger&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(BigNumber), Member = "ParseBigInteger", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(NumberStyles), typeof(NumberFormatInfo)}, ReturnType = typeof(BigInteger))]
	[CalledBy(Type = typeof(BigNumber), Member = "ParseBigInteger", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(NumberStyles), typeof(NumberFormatInfo)}, ReturnType = typeof(BigInteger))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider), typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	internal static bool TryValidateParseStyleInteger(NumberStyles style, out ArgumentException e) { }

}

