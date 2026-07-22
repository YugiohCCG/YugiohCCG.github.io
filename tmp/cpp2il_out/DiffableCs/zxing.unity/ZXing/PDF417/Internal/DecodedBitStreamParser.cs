namespace ZXing.PDF417.Internal;

internal static class DecodedBitStreamParser
{
	private enum Mode
	{
		ALPHA = 0,
		LOWER = 1,
		MIXED = 2,
		PUNCT = 3,
		ALPHA_SHIFT = 4,
		PUNCT_SHIFT = 5,
	}

	private const int TEXT_COMPACTION_MODE_LATCH = 900; //Field offset: 0x0
	private static readonly Char[] PUNCT_CHARS; //Field offset: 0x0
	private const int PAL = 29; //Field offset: 0x0
	private const int PS = 29; //Field offset: 0x0
	private const int AL = 28; //Field offset: 0x0
	private const int ML = 28; //Field offset: 0x0
	private const int AS = 27; //Field offset: 0x0
	private const int LL = 27; //Field offset: 0x0
	private const int PL = 25; //Field offset: 0x0
	private const int MODE_SHIFT_TO_BYTE_COMPACTION_MODE = 913; //Field offset: 0x0
	private const int MACRO_PDF417_TERMINATOR = 922; //Field offset: 0x0
	private const int BEGIN_MACRO_PDF417_OPTIONAL_FIELD = 923; //Field offset: 0x0
	private const int BEGIN_MACRO_PDF417_CONTROL_BLOCK = 928; //Field offset: 0x0
	private const int BYTE_COMPACTION_MODE_LATCH_6 = 924; //Field offset: 0x0
	private const int NUMERIC_COMPACTION_MODE_LATCH = 902; //Field offset: 0x0
	private const int BYTE_COMPACTION_MODE_LATCH = 901; //Field offset: 0x0
	private const int MAX_NUMERIC_CODEWORDS = 15; //Field offset: 0x0
	private const int NUMBER_OF_SEQUENCE_CODEWORDS = 2; //Field offset: 0x0
	private static readonly Char[] MIXED_CHARS; //Field offset: 0x8
	private static readonly BigInteger[] EXP900; //Field offset: 0x10

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(RuntimeFieldHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BigInteger), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BigInteger), Member = "Multiplication", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger), typeof(BigInteger)}, ReturnType = typeof(BigInteger))]
	[CallsUnknownMethods(Count = 8)]
	private static DecodedBitStreamParser() { }

	[CalledBy(Type = typeof(DecodedBitStreamParser), Member = "decode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[]), typeof(string)}, ReturnType = typeof(DecoderResult))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[])}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(StringBuilder))]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	private static int byteCompaction(int mode, Int32[] codewords, int codeIndex, StringBuilder result) { }

	[CalledBy(Type = typeof(PDF417ScanningDecoder), Member = "decodeCodewords", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[]), typeof(int), typeof(Int32[])}, ReturnType = typeof(DecoderResult))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DecodedBitStreamParser), Member = "decodeMacroBlock", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[]), typeof(int), typeof(PDF417ResultMetadata)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(DecodedBitStreamParser), Member = "numericCompaction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[]), typeof(int), typeof(StringBuilder)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(DecodedBitStreamParser), Member = "byteCompaction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Int32[]), typeof(int), typeof(StringBuilder)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(DecodedBitStreamParser), Member = "textCompaction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[]), typeof(int), typeof(StringBuilder)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(DecoderResult), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(string), typeof(System.Collections.Generic.IList`1<Byte[]>), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	internal static DecoderResult decode(Int32[] codewords, string ecLevel) { }

	[CalledBy(Type = typeof(DecodedBitStreamParser), Member = "decodeMacroBlock", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[]), typeof(int), typeof(PDF417ResultMetadata)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(DecodedBitStreamParser), Member = "numericCompaction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[]), typeof(int), typeof(StringBuilder)}, ReturnType = typeof(int))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(BigInteger), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BigInteger), Member = "Multiplication", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger), typeof(BigInteger)}, ReturnType = typeof(BigInteger))]
	[Calls(Type = typeof(BigInteger), Member = "Addition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger), typeof(BigInteger)}, ReturnType = typeof(BigInteger))]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private static string decodeBase900toBase10(Int32[] codewords, int count) { }

	[CalledBy(Type = typeof(DecodedBitStreamParser), Member = "decode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[]), typeof(string)}, ReturnType = typeof(DecoderResult))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DecodedBitStreamParser), Member = "decodeBase900toBase10", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[]), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(int), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(DecodedBitStreamParser), Member = "textCompaction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[]), typeof(int), typeof(StringBuilder)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(Array), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	private static int decodeMacroBlock(Int32[] codewords, int codeIndex, PDF417ResultMetadata resultMetadata) { }

	[CalledBy(Type = typeof(DecodedBitStreamParser), Member = "textCompaction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[]), typeof(int), typeof(StringBuilder)}, ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(Nullable`1), Member = "get_Value", ReturnType = "T")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 9)]
	private static void decodeTextCompaction(Int32[] textCompactionData, Int32[] byteCompactionData, int length, StringBuilder result) { }

	[CalledBy(Type = typeof(DecodedBitStreamParser), Member = "decode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[]), typeof(string)}, ReturnType = typeof(DecoderResult))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DecodedBitStreamParser), Member = "decodeBase900toBase10", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[]), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(StringBuilder))]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	private static int numericCompaction(Int32[] codewords, int codeIndex, StringBuilder result) { }

	[CalledBy(Type = typeof(DecodedBitStreamParser), Member = "decode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[]), typeof(string)}, ReturnType = typeof(DecoderResult))]
	[CalledBy(Type = typeof(DecodedBitStreamParser), Member = "decodeMacroBlock", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[]), typeof(int), typeof(PDF417ResultMetadata)}, ReturnType = typeof(int))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(DecodedBitStreamParser), Member = "decodeTextCompaction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[]), typeof(Int32[]), typeof(int), typeof(StringBuilder)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	private static int textCompaction(Int32[] codewords, int codeIndex, StringBuilder result) { }

}

