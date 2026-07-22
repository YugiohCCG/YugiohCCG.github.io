namespace ZXing.Datamatrix.Encoder;

internal static class HighLevelEncoder
{
	public const char PAD = '\u81'; //Field offset: 0x0
	public const string MACRO_05_HEADER = "[)>05"; //Field offset: 0x0
	public const char X12_UNLATCH = '\uFE'; //Field offset: 0x0
	public const char C40_UNLATCH = '\uFE'; //Field offset: 0x0
	public const char ECI = '\uF1'; //Field offset: 0x0
	public const char LATCH_TO_EDIFACT = '\uF0'; //Field offset: 0x0
	public const char LATCH_TO_TEXT = '\uEF'; //Field offset: 0x0
	public const char LATCH_TO_ANSIX12 = '\uEE'; //Field offset: 0x0
	public const char MACRO_06 = '\uED'; //Field offset: 0x0
	public const char MACRO_05 = '\uEC'; //Field offset: 0x0
	public const char UPPER_SHIFT = '\uEB'; //Field offset: 0x0
	public const char READER_PROGRAMMING = '\uEA'; //Field offset: 0x0
	public const char STRUCTURED_APPEND = '\uE9'; //Field offset: 0x0
	public const char FNC1 = '\uE8'; //Field offset: 0x0
	public const char LATCH_TO_BASE256 = '\uE7'; //Field offset: 0x0
	public const char LATCH_TO_C40 = '\uE6'; //Field offset: 0x0
	public const string MACRO_06_HEADER = "[)>06"; //Field offset: 0x0
	public const string MACRO_TRAILER = ""; //Field offset: 0x0

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[CallsUnknownMethods(Count = 1)]
	public static int determineConsecutiveDigitCount(string msg, int startpos) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(HighLevelEncoder), Member = "encodeHighLevel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(SymbolShapeHint), typeof(Dimension), typeof(Dimension), typeof(int)}, ReturnType = typeof(string))]
	public static string encodeHighLevel(string msg) { }

	[CalledBy(Type = typeof(DataMatrixWriter), Member = "encode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(BarcodeFormat), typeof(int), typeof(int), typeof(System.Collections.Generic.IDictionary`2<ZXing.EncodeHintType, System.Object>)}, ReturnType = typeof(BitMatrix))]
	[CalledBy(Type = typeof(HighLevelEncoder), Member = "encodeHighLevel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(EncoderContext), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "StartsWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "EndsWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(EncoderContext), Member = "updateSymbolInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 13)]
	[CallsUnknownMethods(Count = 34)]
	[ContainsUnimplementedInstructions]
	public static string encodeHighLevel(string msg, SymbolShapeHint shape, Dimension minSize, Dimension maxSize, int defaultEncodation) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SupportClass), Member = "Fill", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]", "T"}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	private static int findMinimums(Single[] charCounts, Int32[] intCharCounts, int min, Byte[] mins) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static int getMinimumCount(Byte[] mins) { }

	[CalledBy(Type = typeof(EdifactEncoder), Member = "encode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EncoderContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(EdifactEncoder), Member = "encodeChar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(StringBuilder)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextEncoder), Member = "encodeChar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(StringBuilder)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(X12Encoder), Member = "encodeChar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(StringBuilder)}, ReturnType = typeof(int))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	internal static void illegalCharacter(char c) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	internal static bool isDigit(char ch) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	internal static bool isExtendedASCII(char ch) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	internal static bool isNativeC40(char ch) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	internal static bool isNativeEDIFACT(char ch) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	internal static bool isNativeText(char ch) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	internal static bool isNativeX12(char ch) { }

	[CallerCount(Count = 271)]
	[DeduplicatedMethod]
	internal static bool isSpecialB256(char ch) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	internal static bool isX12TermSep(char ch) { }

	[CalledBy(Type = typeof(ASCIIEncoder), Member = "encode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EncoderContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Base256Encoder), Member = "encode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EncoderContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(C40Encoder), Member = "encode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EncoderContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(EdifactEncoder), Member = "encode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EncoderContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(X12Encoder), Member = "encode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EncoderContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(RuntimeFieldHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(SupportClass), Member = "Fill", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]", "T"}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 6)]
	[ContainsUnimplementedInstructions]
	internal static int lookAheadTest(string msg, int startpos, int currentMode) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	private static char randomize253State(char ch, int codewordPosition) { }

}

