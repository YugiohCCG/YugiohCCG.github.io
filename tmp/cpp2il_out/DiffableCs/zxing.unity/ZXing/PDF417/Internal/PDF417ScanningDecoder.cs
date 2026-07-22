namespace ZXing.PDF417.Internal;

public static class PDF417ScanningDecoder
{
	private const int CODEWORD_SKEW_SIZE = 2; //Field offset: 0x0
	private const int MAX_ERRORS = 3; //Field offset: 0x0
	private const int MAX_EC_CODEWORDS = 512; //Field offset: 0x0
	private static readonly ErrorCorrection errorCorrection; //Field offset: 0x0

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private static PDF417ScanningDecoder() { }

	[CalledBy(Type = typeof(PDF417ScanningDecoder), Member = "merge", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DetectionResultRowIndicatorColumn), typeof(DetectionResultRowIndicatorColumn)}, ReturnType = typeof(DetectionResult))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(DetectionResultRowIndicatorColumn), Member = "getBarcodeMetadata", ReturnType = typeof(BarcodeMetadata))]
	[Calls(Type = typeof(DetectionResultRowIndicatorColumn), Member = "adjustIncompleteIndicatorColumnRowNumbers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BarcodeMetadata)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Math), Member = "Max", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(BoundingBox), Member = "addMissingRows", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(bool)}, ReturnType = typeof(BoundingBox))]
	[CallsUnknownMethods(Count = 2)]
	private static BoundingBox adjustBoundingBox(DetectionResultRowIndicatorColumn rowIndicatorColumn) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BarcodeValue), Member = "getValue", ReturnType = typeof(Int32[]))]
	[Calls(Type = typeof(BarcodeValue), Member = "setValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	private static bool adjustCodewordCount(DetectionResult detectionResult, BarcodeValue[][] barcodeMatrix) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BitMatrix), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	private static int adjustCodewordStartColumn(BitMatrix image, int minColumn, int maxColumn, bool leftToRight, int codewordStartColumn, int imageRow) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	private static bool checkCodewordSkew(int codewordSize, int minCodewordWidth, int maxCodewordWidth) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ErrorCorrection), Member = "decode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[]), typeof(int), typeof(Int32[]), typeof(Int32&)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	private static int correctErrors(Int32[] codewords, Int32[] erasures, int numECCodewords) { }

	[CalledBy(Type = typeof(PDF417ScanningDecoder), Member = "createDecoderResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DetectionResult)}, ReturnType = typeof(DecoderResult))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BarcodeValue), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(DetectionResult), Member = "getDetectionResultColumns", ReturnType = typeof(DetectionResultColumn[]))]
	[Calls(Type = typeof(BarcodeValue), Member = "setValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	private static BarcodeValue[][] createBarcodeMatrix(DetectionResult detectionResult) { }

	[CalledBy(Type = typeof(PDF417ScanningDecoder), Member = "decode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitMatrix), typeof(ResultPoint), typeof(ResultPoint), typeof(ResultPoint), typeof(ResultPoint), typeof(int), typeof(int)}, ReturnType = typeof(DecoderResult))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PDF417ScanningDecoder), Member = "createBarcodeMatrix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DetectionResult)}, ReturnType = typeof(BarcodeValue[][]))]
	[Calls(Type = typeof(BarcodeValue), Member = "getValue", ReturnType = typeof(Int32[]))]
	[Calls(Type = typeof(BarcodeValue), Member = "setValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "ToArray", ReturnType = "T[]")]
	[Calls(Type = typeof(PDF417ScanningDecoder), Member = "createDecoderResultFromAmbiguousValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Int32[]), typeof(Int32[]), typeof(Int32[]), typeof(Int32[][])}, ReturnType = typeof(DecoderResult))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 6)]
	private static DecoderResult createDecoderResult(DetectionResult detectionResult) { }

	[CalledBy(Type = typeof(PDF417ScanningDecoder), Member = "createDecoderResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DetectionResult)}, ReturnType = typeof(DecoderResult))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PDF417ScanningDecoder), Member = "decodeCodewords", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[]), typeof(int), typeof(Int32[])}, ReturnType = typeof(DecoderResult))]
	[CallsUnknownMethods(Count = 2)]
	private static DecoderResult createDecoderResultFromAmbiguousValues(int ecLevel, Int32[] codewords, Int32[] erasureArray, Int32[] ambiguousIndexes, Int32[][] ambiguousIndexValues) { }

	[CalledBy(Type = typeof(PDF417Reader), Member = "decode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryBitmap), typeof(System.Collections.Generic.IDictionary`2<ZXing.DecodeHintType, System.Object>), typeof(bool)}, ReturnType = typeof(Result[]))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BoundingBox), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitMatrix), typeof(ResultPoint), typeof(ResultPoint), typeof(ResultPoint), typeof(ResultPoint)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DetectionResultColumn), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BoundingBox)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(PDF417ScanningDecoder), Member = "detectCodeword", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitMatrix), typeof(int), typeof(int), typeof(bool), typeof(int), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(Codeword))]
	[Calls(Type = typeof(DetectionResultColumn), Member = "setCodeword", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Codeword)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(PDF417ScanningDecoder), Member = "merge", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DetectionResultRowIndicatorColumn), typeof(DetectionResultRowIndicatorColumn)}, ReturnType = typeof(DetectionResult))]
	[Calls(Type = typeof(PDF417ScanningDecoder), Member = "getStartColumn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DetectionResult), typeof(int), typeof(int), typeof(bool)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Math), Member = "Min", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Math), Member = "Max", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(PDF417ScanningDecoder), Member = "createDecoderResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DetectionResult)}, ReturnType = typeof(DecoderResult))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 15)]
	[ContainsUnimplementedInstructions]
	public static DecoderResult decode(BitMatrix image, ResultPoint imageTopLeft, ResultPoint imageBottomLeft, ResultPoint imageTopRight, ResultPoint imageBottomRight, int minCodewordWidth, int maxCodewordWidth) { }

	[CalledBy(Type = typeof(PDF417ScanningDecoder), Member = "createDecoderResultFromAmbiguousValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Int32[]), typeof(Int32[]), typeof(Int32[]), typeof(Int32[][])}, ReturnType = typeof(DecoderResult))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ErrorCorrection), Member = "decode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[]), typeof(int), typeof(Int32[]), typeof(Int32&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(DecodedBitStreamParser), Member = "decode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[]), typeof(string)}, ReturnType = typeof(DecoderResult))]
	[CallsUnknownMethods(Count = 2)]
	private static DecoderResult decodeCodewords(Int32[] codewords, int ecLevel, Int32[] erasures) { }

	[CalledBy(Type = typeof(PDF417ScanningDecoder), Member = "decode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitMatrix), typeof(ResultPoint), typeof(ResultPoint), typeof(ResultPoint), typeof(ResultPoint), typeof(int), typeof(int)}, ReturnType = typeof(DecoderResult))]
	[CalledBy(Type = typeof(PDF417ScanningDecoder), Member = "getRowIndicatorColumn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitMatrix), typeof(BoundingBox), typeof(ResultPoint), typeof(bool), typeof(int), typeof(int)}, ReturnType = typeof(DetectionResultRowIndicatorColumn))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(BitMatrix), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(PDF417CodewordDecoder), Member = "getDecodedValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[])}, ReturnType = typeof(int))]
	[Calls(Type = typeof(PDF417Common), Member = "getCodeword", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	private static Codeword detectCodeword(BitMatrix image, int minColumn, int maxColumn, bool leftToRight, int startColumn, int imageRow, int minCodewordWidth, int maxCodewordWidth) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DetectionResultRowIndicatorColumn), Member = "getBarcodeMetadata", ReturnType = typeof(BarcodeMetadata))]
	private static BarcodeMetadata getBarcodeMetadata(DetectionResultRowIndicatorColumn leftRowIndicatorColumn, DetectionResultRowIndicatorColumn rightRowIndicatorColumn) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static Int32[] getBitCountForCodeword(int codeword) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	private static int getCodewordBucketNumber(int codeword) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	private static int getCodewordBucketNumber(Int32[] moduleBitCount) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Math), Member = "Max", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 2)]
	private static int getMax(Int32[] values) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BitMatrix), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 2)]
	private static Int32[] getModuleBitCount(BitMatrix image, int minColumn, int maxColumn, bool leftToRight, int startColumn, int imageRow) { }

	[CallerCount(Count = 0)]
	private static int getNumberOfECCodeWords(int barcodeECLevel) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DetectionResultColumn), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BoundingBox)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(PDF417ScanningDecoder), Member = "detectCodeword", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitMatrix), typeof(int), typeof(int), typeof(bool), typeof(int), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(Codeword))]
	[Calls(Type = typeof(DetectionResultColumn), Member = "setCodeword", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Codeword)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private static DetectionResultRowIndicatorColumn getRowIndicatorColumn(BitMatrix image, BoundingBox boundingBox, ResultPoint startPoint, bool leftToRight, int minCodewordWidth, int maxCodewordWidth) { }

	[CalledBy(Type = typeof(PDF417ScanningDecoder), Member = "decode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitMatrix), typeof(ResultPoint), typeof(ResultPoint), typeof(ResultPoint), typeof(ResultPoint), typeof(int), typeof(int)}, ReturnType = typeof(DecoderResult))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DetectionResultColumn), Member = "getCodewordNearby", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Codeword))]
	[CallsUnknownMethods(Count = 2)]
	private static int getStartColumn(DetectionResult detectionResult, int barcodeColumn, int imageRow, bool leftToRight) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private static bool isValidBarcodeColumn(DetectionResult detectionResult, int barcodeColumn) { }

	[CalledBy(Type = typeof(PDF417ScanningDecoder), Member = "decode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitMatrix), typeof(ResultPoint), typeof(ResultPoint), typeof(ResultPoint), typeof(ResultPoint), typeof(int), typeof(int)}, ReturnType = typeof(DecoderResult))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DetectionResultRowIndicatorColumn), Member = "getBarcodeMetadata", ReturnType = typeof(BarcodeMetadata))]
	[Calls(Type = typeof(PDF417ScanningDecoder), Member = "adjustBoundingBox", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DetectionResultRowIndicatorColumn)}, ReturnType = typeof(BoundingBox))]
	[Calls(Type = typeof(BoundingBox), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitMatrix), typeof(ResultPoint), typeof(ResultPoint), typeof(ResultPoint), typeof(ResultPoint)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private static DetectionResult merge(DetectionResultRowIndicatorColumn leftRowIndicatorColumn, DetectionResultRowIndicatorColumn rightRowIndicatorColumn) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(StringBuilder), Member = "AppendFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider), typeof(string), typeof(Object[])}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(BarcodeValue), Member = "getValue", ReturnType = typeof(Int32[]))]
	[Calls(Type = typeof(BarcodeValue), Member = "getConfidence", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(StringBuilder))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 18)]
	public static string ToString(BarcodeValue[][] barcodeMatrix) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static bool verifyCodewordCount(Int32[] codewords, int numECCodewords) { }

}

