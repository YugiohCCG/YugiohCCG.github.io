namespace ZXing.QrCode.Internal;

internal static class DecodedBitStreamParser
{
	private static readonly Char[] ALPHANUMERIC_CHARS; //Field offset: 0x0
	private const int GB2312_SUBSET = 1; //Field offset: 0x0

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(RuntimeFieldHandle)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private static DecodedBitStreamParser() { }

	[CalledBy(Type = typeof(Decoder), Member = "decode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitMatrixParser), typeof(System.Collections.Generic.IDictionary`2<ZXing.DecodeHintType, System.Object>)}, ReturnType = typeof(DecoderResult))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(DecoderResult), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(string), typeof(System.Collections.Generic.IList`1<Byte[]>), typeof(string), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Environment), Member = "get_NewLine", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Replace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CharacterSetECI), Member = "getCharacterSetECIByValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(CharacterSetECI))]
	[Calls(Type = typeof(DecodedBitStreamParser), Member = "decodeHanziSegment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitSource), typeof(StringBuilder), typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DecodedBitStreamParser), Member = "decodeNumericSegment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitSource), typeof(StringBuilder), typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DecodedBitStreamParser), Member = "decodeAlphanumericSegment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitSource), typeof(StringBuilder), typeof(int), typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DecodedBitStreamParser), Member = "decodeByteSegment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitSource), typeof(StringBuilder), typeof(int), typeof(CharacterSetECI), typeof(System.Collections.Generic.IList`1<Byte[]>), typeof(System.Collections.Generic.IDictionary`2<ZXing.DecodeHintType, System.Object>)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DecodedBitStreamParser), Member = "decodeKanjiSegment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitSource), typeof(StringBuilder), typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Mode), Member = "getCharacterCountBits", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Version)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Mode), Member = "forBits", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Mode))]
	[Calls(Type = typeof(BitSource), Member = "readBits", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(BitSource), Member = "available", ReturnType = typeof(int))]
	[Calls(Type = typeof(List`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 8)]
	internal static DecoderResult decode(Byte[] bytes, Version version, ErrorCorrectionLevel ecLevel, IDictionary<DecodeHintType, Object> hints) { }

	[CalledBy(Type = typeof(DecodedBitStreamParser), Member = "decode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(Version), typeof(ErrorCorrectionLevel), typeof(System.Collections.Generic.IDictionary`2<ZXing.DecodeHintType, System.Object>)}, ReturnType = typeof(DecoderResult))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BitSource), Member = "available", ReturnType = typeof(int))]
	[Calls(Type = typeof(BitSource), Member = "readBits", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(DecodedBitStreamParser), Member = "toAlphaNumericChar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(StringBuilder), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(StringBuilder), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(StringBuilder), Member = "Insert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Char[])}, ReturnType = typeof(StringBuilder))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	private static bool decodeAlphanumericSegment(BitSource bits, StringBuilder result, int count, bool fc1InEffect) { }

	[CalledBy(Type = typeof(DecodedBitStreamParser), Member = "decode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(Version), typeof(ErrorCorrectionLevel), typeof(System.Collections.Generic.IDictionary`2<ZXing.DecodeHintType, System.Object>)}, ReturnType = typeof(DecoderResult))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BitSource), Member = "available", ReturnType = typeof(int))]
	[Calls(Type = typeof(BitSource), Member = "readBits", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(StringUtils), Member = "guessEncoding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(System.Collections.Generic.IDictionary`2<ZXing.DecodeHintType, System.Object>)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Encoding), Member = "GetEncoding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Encoding))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(StringBuilder))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 6)]
	private static bool decodeByteSegment(BitSource bits, StringBuilder result, int count, CharacterSetECI currentCharacterSetECI, IList<Byte[]> byteSegments, IDictionary<DecodeHintType, Object> hints) { }

	[CalledBy(Type = typeof(DecodedBitStreamParser), Member = "decode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(Version), typeof(ErrorCorrectionLevel), typeof(System.Collections.Generic.IDictionary`2<ZXing.DecodeHintType, System.Object>)}, ReturnType = typeof(DecoderResult))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BitSource), Member = "available", ReturnType = typeof(int))]
	[Calls(Type = typeof(BitSource), Member = "readBits", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Encoding), Member = "GetEncoding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Encoding))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(StringBuilder))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	[ContainsUnimplementedInstructions]
	private static bool decodeHanziSegment(BitSource bits, StringBuilder result, int count) { }

	[CalledBy(Type = typeof(DecodedBitStreamParser), Member = "decode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(Version), typeof(ErrorCorrectionLevel), typeof(System.Collections.Generic.IDictionary`2<ZXing.DecodeHintType, System.Object>)}, ReturnType = typeof(DecoderResult))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BitSource), Member = "available", ReturnType = typeof(int))]
	[Calls(Type = typeof(BitSource), Member = "readBits", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Encoding), Member = "GetEncoding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Encoding))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(StringBuilder))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	[ContainsUnimplementedInstructions]
	private static bool decodeKanjiSegment(BitSource bits, StringBuilder result, int count) { }

	[CalledBy(Type = typeof(DecodedBitStreamParser), Member = "decode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(Version), typeof(ErrorCorrectionLevel), typeof(System.Collections.Generic.IDictionary`2<ZXing.DecodeHintType, System.Object>)}, ReturnType = typeof(DecoderResult))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BitSource), Member = "available", ReturnType = typeof(int))]
	[Calls(Type = typeof(BitSource), Member = "readBits", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(DecodedBitStreamParser), Member = "toAlphaNumericChar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(StringBuilder))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private static bool decodeNumericSegment(BitSource bits, StringBuilder result, int count) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BitSource), Member = "readBits", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	private static int parseECIValue(BitSource bits) { }

	[CalledBy(Type = typeof(DecodedBitStreamParser), Member = "decodeAlphanumericSegment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitSource), typeof(StringBuilder), typeof(int), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DecodedBitStreamParser), Member = "decodeNumericSegment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitSource), typeof(StringBuilder), typeof(int)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 9)]
	[CallsUnknownMethods(Count = 7)]
	private static char toAlphaNumericChar(int value) { }

}

