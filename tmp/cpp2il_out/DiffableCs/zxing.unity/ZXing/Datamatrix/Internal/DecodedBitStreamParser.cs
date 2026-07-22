namespace ZXing.Datamatrix.Internal;

internal static class DecodedBitStreamParser
{
	private enum Mode
	{
		PAD_ENCODE = 0,
		ASCII_ENCODE = 1,
		C40_ENCODE = 2,
		TEXT_ENCODE = 3,
		ANSIX12_ENCODE = 4,
		EDIFACT_ENCODE = 5,
		BASE256_ENCODE = 6,
	}

	private static readonly Char[] C40_BASIC_SET_CHARS; //Field offset: 0x0
	private static readonly Char[] C40_SHIFT2_SET_CHARS; //Field offset: 0x8
	private static readonly Char[] TEXT_BASIC_SET_CHARS; //Field offset: 0x10
	private static readonly Char[] TEXT_SHIFT3_SET_CHARS; //Field offset: 0x18

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(RuntimeFieldHandle)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	private static DecodedBitStreamParser() { }

	[CalledBy(Type = typeof(Decoder), Member = "decode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitMatrix)}, ReturnType = typeof(DecoderResult))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DecodedBitStreamParser), Member = "decodeBase256Segment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitSource), typeof(StringBuilder), typeof(System.Collections.Generic.IList`1<Byte[]>)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BitSource), Member = "available", ReturnType = typeof(int))]
	[Calls(Type = typeof(BitSource), Member = "readBits", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(DecodedBitStreamParser), Member = "decodeTextSegment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitSource), typeof(StringBuilder)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(StringBuilder), Member = "Insert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(DecoderResult), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(string), typeof(System.Collections.Generic.IList`1<Byte[]>), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	internal static DecoderResult decode(Byte[] bytes) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BitSource), Member = "available", ReturnType = typeof(int))]
	[Calls(Type = typeof(BitSource), Member = "readBits", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(StringBuilder))]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	private static bool decodeAnsiX12Segment(BitSource bits, StringBuilder result) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BitSource), Member = "readBits", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(BitSource), Member = "available", ReturnType = typeof(int))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(StringBuilder), Member = "Insert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(StringBuilder))]
	[CallsUnknownMethods(Count = 1)]
	private static bool decodeAsciiSegment(BitSource bits, StringBuilder result, StringBuilder resultTrailer, out Mode mode) { }

	[CalledBy(Type = typeof(DecodedBitStreamParser), Member = "decode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(DecoderResult))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BitSource), Member = "readBits", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(BitSource), Member = "available", ReturnType = typeof(int))]
	[Calls(Type = typeof(Encoding), Member = "GetEncoding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Encoding))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 10)]
	[ContainsUnimplementedInstructions]
	private static bool decodeBase256Segment(BitSource bits, StringBuilder result, IList<Byte[]> byteSegments) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BitSource), Member = "available", ReturnType = typeof(int))]
	[Calls(Type = typeof(BitSource), Member = "readBits", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(StringBuilder))]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	private static bool decodeC40Segment(BitSource bits, StringBuilder result) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BitSource), Member = "available", ReturnType = typeof(int))]
	[Calls(Type = typeof(BitSource), Member = "readBits", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(StringBuilder))]
	[CallsUnknownMethods(Count = 1)]
	private static bool decodeEdifactSegment(BitSource bits, StringBuilder result) { }

	[CalledBy(Type = typeof(DecodedBitStreamParser), Member = "decode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(DecoderResult))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BitSource), Member = "available", ReturnType = typeof(int))]
	[Calls(Type = typeof(BitSource), Member = "readBits", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(StringBuilder))]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	private static bool decodeTextSegment(BitSource bits, StringBuilder result) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	private static void parseTwoBytes(int firstByte, int secondByte, Int32[] result) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	private static int unrandomize255State(int randomizedBase256Codeword, int base256CodewordPosition) { }

}

