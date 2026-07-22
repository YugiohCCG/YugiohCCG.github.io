namespace ZXing.PDF417.Internal;

internal static class PDF417HighLevelEncoder
{
	private const int TEXT_COMPACTION = 0; //Field offset: 0x0
	private static readonly SByte[] TEXT_MIXED_RAW; //Field offset: 0x0
	private const int ECI_CHARSET = 927; //Field offset: 0x0
	private const int ECI_GENERAL_PURPOSE = 926; //Field offset: 0x0
	private const int ECI_USER_DEFINED = 925; //Field offset: 0x0
	private const int LATCH_TO_BYTE = 924; //Field offset: 0x0
	private const int SHIFT_TO_BYTE = 913; //Field offset: 0x0
	private const int LATCH_TO_BYTE_PADDED = 901; //Field offset: 0x0
	private const int LATCH_TO_NUMERIC = 902; //Field offset: 0x0
	private const int SUBMODE_PUNCTUATION = 3; //Field offset: 0x0
	private const int SUBMODE_MIXED = 2; //Field offset: 0x0
	private const int SUBMODE_LOWER = 1; //Field offset: 0x0
	private const int SUBMODE_ALPHA = 0; //Field offset: 0x0
	private const int NUMERIC_COMPACTION = 2; //Field offset: 0x0
	private const int BYTE_COMPACTION = 1; //Field offset: 0x0
	private const int LATCH_TO_TEXT = 900; //Field offset: 0x0
	private static readonly SByte[] TEXT_PUNCTUATION_RAW; //Field offset: 0x8
	private static readonly SByte[] MIXED; //Field offset: 0x10
	private static readonly SByte[] PUNCTUATION; //Field offset: 0x18
	internal static Encoding DEFAULT_ENCODING; //Field offset: 0x20

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(RuntimeFieldHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Encoding), Member = "GetEncoding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Encoding))]
	[CallsUnknownMethods(Count = 7)]
	private static PDF417HighLevelEncoder() { }

	[CalledBy(Type = typeof(PDF417HighLevelEncoder), Member = "encodeHighLevel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Compaction), typeof(Encoding), typeof(bool)}, ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(WriterException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 25)]
	[ContainsUnimplementedInstructions]
	private static int determineConsecutiveBinaryCount(string msg, Byte[] bytes, int startpos) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[CallsUnknownMethods(Count = 1)]
	private static int determineConsecutiveDigitCount(string msg, int startpos) { }

	[CalledBy(Type = typeof(PDF417HighLevelEncoder), Member = "encodeHighLevel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Compaction), typeof(Encoding), typeof(bool)}, ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[CallsUnknownMethods(Count = 1)]
	private static int determineConsecutiveTextCount(string msg, int startpos) { }

	[CalledBy(Type = typeof(PDF417HighLevelEncoder), Member = "encodeHighLevel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Compaction), typeof(Encoding), typeof(bool)}, ReturnType = typeof(string))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(StringBuilder))]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	private static void encodeBinary(Byte[] bytes, int startpos, int count, int startmode, StringBuilder sb) { }

	[CalledBy(Type = typeof(PDF417), Member = "generateBarcodeLogic", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CharacterSetECI), Member = "getCharacterSetECIByName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(CharacterSetECI))]
	[Calls(Type = typeof(PDF417HighLevelEncoder), Member = "encodingECI", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(StringBuilder)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(PDF417HighLevelEncoder), Member = "encodeNumeric", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int), typeof(StringBuilder)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(PDF417HighLevelEncoder), Member = "determineConsecutiveTextCount", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(PDF417HighLevelEncoder), Member = "determineConsecutiveBinaryCount", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Byte[]), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(PDF417HighLevelEncoder), Member = "encodeBinary", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int), typeof(int), typeof(StringBuilder)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(PDF417HighLevelEncoder), Member = "encodeText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int), typeof(StringBuilder), typeof(int)}, ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 2)]
	internal static string encodeHighLevel(string msg, Compaction compaction, Encoding encoding, bool disableEci) { }

	[CalledBy(Type = typeof(PDF417HighLevelEncoder), Member = "encodeHighLevel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Compaction), typeof(Encoding), typeof(bool)}, ReturnType = typeof(string))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BigInteger), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StringBuilder), Member = "set_Length", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Math), Member = "Min", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(BigInteger), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(BigInteger))]
	[Calls(Type = typeof(BigInteger), Member = "Modulo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger), typeof(BigInteger)}, ReturnType = typeof(BigInteger))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(BigInteger), Member = "Division", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger), typeof(BigInteger)}, ReturnType = typeof(BigInteger))]
	[Calls(Type = typeof(BigInteger), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(StringBuilder), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	private static void encodeNumeric(string msg, int startpos, int count, StringBuilder sb) { }

	[CalledBy(Type = typeof(PDF417HighLevelEncoder), Member = "encodeHighLevel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Compaction), typeof(Encoding), typeof(bool)}, ReturnType = typeof(string))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(PDF417HighLevelEncoder), Member = "isPunctuation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(PDF417HighLevelEncoder), Member = "isMixed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(StringBuilder), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private static int encodeText(string msg, int startpos, int count, StringBuilder sb, int initialSubmode) { }

	[CalledBy(Type = typeof(PDF417HighLevelEncoder), Member = "encodeHighLevel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Compaction), typeof(Encoding), typeof(bool)}, ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(WriterException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	[ContainsUnimplementedInstructions]
	private static void encodingECI(int eci, StringBuilder sb) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	private static bool isAlphaLower(char ch) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	private static bool isAlphaUpper(char ch) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	private static bool isDigit(char ch) { }

	[CalledBy(Type = typeof(PDF417HighLevelEncoder), Member = "encodeText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int), typeof(StringBuilder), typeof(int)}, ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	private static bool isMixed(char ch) { }

	[CalledBy(Type = typeof(PDF417HighLevelEncoder), Member = "encodeText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int), typeof(StringBuilder), typeof(int)}, ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	private static bool isPunctuation(char ch) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	private static bool isText(char ch) { }

}

