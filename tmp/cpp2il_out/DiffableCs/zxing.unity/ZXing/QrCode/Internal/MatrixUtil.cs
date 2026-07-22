namespace ZXing.QrCode.Internal;

public static class MatrixUtil
{
	private static readonly Int32[][] POSITION_DETECTION_PATTERN; //Field offset: 0x0
	private const int VERSION_INFO_POLY = 7973; //Field offset: 0x0
	private const int TYPE_INFO_POLY = 1335; //Field offset: 0x0
	private const int TYPE_INFO_MASK_PATTERN = 21522; //Field offset: 0x0
	private static readonly Int32[][] POSITION_ADJUSTMENT_PATTERN; //Field offset: 0x8
	private static readonly Int32[][] POSITION_ADJUSTMENT_PATTERN_COORDINATE_TABLE; //Field offset: 0x10
	private static readonly Int32[][] TYPE_INFO_COORDINATES; //Field offset: 0x18

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(RuntimeFieldHandle)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 73)]
	private static MatrixUtil() { }

	[CalledBy(Type = typeof(Encoder), Member = "encode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(ErrorCorrectionLevel), typeof(System.Collections.Generic.IDictionary`2<ZXing.EncodeHintType, System.Object>)}, ReturnType = typeof(QRCode))]
	[CalledBy(Type = typeof(Encoder), Member = "chooseMaskPattern", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitArray), typeof(ErrorCorrectionLevel), typeof(Version), typeof(ByteMatrix)}, ReturnType = typeof(int))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(MatrixUtil), Member = "embedBasicPatterns", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Version), typeof(ByteMatrix)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BitArray), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(MatrixUtil), Member = "makeTypeInfoBits", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ErrorCorrectionLevel), typeof(int), typeof(BitArray)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BitArray), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(MatrixUtil), Member = "maybeEmbedVersionInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Version), typeof(ByteMatrix)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MatrixUtil), Member = "embedDataBits", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitArray), typeof(int), typeof(ByteMatrix)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public static void buildMatrix(BitArray dataBits, ErrorCorrectionLevel ecLevel, Version version, int maskPattern, ByteMatrix matrix) { }

	[CalledBy(Type = typeof(MatrixUtil), Member = "maybeEmbedVersionInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Version), typeof(ByteMatrix)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MatrixUtil), Member = "makeTypeInfoBits", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ErrorCorrectionLevel), typeof(int), typeof(BitArray)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MatrixUtil), Member = "makeVersionInfoBits", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Version), typeof(BitArray)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	public static int calculateBCHCode(int value, int poly) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public static void clearMatrix(ByteMatrix matrix) { }

	[CalledBy(Type = typeof(MatrixUtil), Member = "buildMatrix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitArray), typeof(ErrorCorrectionLevel), typeof(Version), typeof(int), typeof(ByteMatrix)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(MatrixUtil), Member = "embedPositionDetectionPatternsAndSeparators", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ByteMatrix)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MatrixUtil), Member = "maybeEmbedPositionAdjustmentPatterns", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Version), typeof(ByteMatrix)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(WriterException), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	public static void embedBasicPatterns(Version version, ByteMatrix matrix) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(WriterException), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	private static void embedDarkDotAtLeftBottomCorner(ByteMatrix matrix) { }

	[CalledBy(Type = typeof(MatrixUtil), Member = "buildMatrix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitArray), typeof(ErrorCorrectionLevel), typeof(Version), typeof(int), typeof(ByteMatrix)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ByteMatrix), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(BitArray), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(MaskUtil), Member = "getDataMaskBit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(WriterException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 20)]
	public static void embedDataBits(BitArray dataBits, int maskPattern, ByteMatrix matrix) { }

	[CalledBy(Type = typeof(MatrixUtil), Member = "embedPositionDetectionPatternsAndSeparators", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ByteMatrix)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(WriterException), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	private static void embedHorizontalSeparationPattern(int xStart, int yStart, ByteMatrix matrix) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private static void embedPositionAdjustmentPattern(int xStart, int yStart, ByteMatrix matrix) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private static void embedPositionDetectionPattern(int xStart, int yStart, ByteMatrix matrix) { }

	[CalledBy(Type = typeof(MatrixUtil), Member = "embedBasicPatterns", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Version), typeof(ByteMatrix)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(MatrixUtil), Member = "embedHorizontalSeparationPattern", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(ByteMatrix)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MatrixUtil), Member = "embedVerticalSeparationPattern", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(ByteMatrix)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsInvalidInstructions]
	private static void embedPositionDetectionPatternsAndSeparators(ByteMatrix matrix) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void embedTimingPatterns(ByteMatrix matrix) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BitArray), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(MatrixUtil), Member = "makeTypeInfoBits", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ErrorCorrectionLevel), typeof(int), typeof(BitArray)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BitArray), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public static void embedTypeInfo(ErrorCorrectionLevel ecLevel, int maskPattern, ByteMatrix matrix) { }

	[CalledBy(Type = typeof(MatrixUtil), Member = "embedPositionDetectionPatternsAndSeparators", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ByteMatrix)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(WriterException), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	private static void embedVerticalSeparationPattern(int xStart, int yStart, ByteMatrix matrix) { }

	[CallerCount(Count = 0)]
	public static int findMSBSet(int value_Renamed) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	private static bool isEmpty(int value) { }

	[CalledBy(Type = typeof(MatrixUtil), Member = "buildMatrix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitArray), typeof(ErrorCorrectionLevel), typeof(Version), typeof(int), typeof(ByteMatrix)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MatrixUtil), Member = "embedTypeInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ErrorCorrectionLevel), typeof(int), typeof(ByteMatrix)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(BitArray), Member = "appendBits", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MatrixUtil), Member = "calculateBCHCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(BitArray), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(BitArray), Member = "xor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitArray)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(WriterException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 10)]
	public static void makeTypeInfoBits(ErrorCorrectionLevel ecLevel, int maskPattern, BitArray bits) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BitArray), Member = "appendBits", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MatrixUtil), Member = "calculateBCHCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(WriterException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	public static void makeVersionInfoBits(Version version, BitArray bits) { }

	[CalledBy(Type = typeof(MatrixUtil), Member = "embedBasicPatterns", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Version), typeof(ByteMatrix)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ByteMatrix), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private static void maybeEmbedPositionAdjustmentPatterns(Version version, ByteMatrix matrix) { }

	[CalledBy(Type = typeof(MatrixUtil), Member = "buildMatrix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitArray), typeof(ErrorCorrectionLevel), typeof(Version), typeof(int), typeof(ByteMatrix)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BitArray), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(BitArray), Member = "appendBits", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MatrixUtil), Member = "calculateBCHCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(BitArray), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(WriterException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 6)]
	public static void maybeEmbedVersionInfo(Version version, ByteMatrix matrix) { }

}

