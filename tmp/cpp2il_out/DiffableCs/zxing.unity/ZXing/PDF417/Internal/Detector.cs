namespace ZXing.PDF417.Internal;

public sealed class Detector
{
	private static readonly Int32[] INDEXES_START_PATTERN; //Field offset: 0x0
	private const int INTEGER_MATH_SHIFT = 8; //Field offset: 0x0
	private const int PATTERN_MATCH_RESULT_SCALE_FACTOR = 256; //Field offset: 0x0
	private const int MAX_AVG_VARIANCE = 107; //Field offset: 0x0
	private const int MAX_INDIVIDUAL_VARIANCE = 204; //Field offset: 0x0
	private const int MAX_PIXEL_DRIFT = 3; //Field offset: 0x0
	private const int MAX_PATTERN_DRIFT = 5; //Field offset: 0x0
	private const int SKIPPED_ROW_COUNT_MAX = 25; //Field offset: 0x0
	private const int ROW_STEP = 5; //Field offset: 0x0
	private const int BARCODE_MIN_HEIGHT = 10; //Field offset: 0x0
	private static readonly Int32[] INDEXES_STOP_PATTERN; //Field offset: 0x8
	private static readonly Int32[] START_PATTERN; //Field offset: 0x10
	private static readonly Int32[] STOP_PATTERN; //Field offset: 0x18

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(RuntimeFieldHandle)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	private static Detector() { }

	[CallerCount(Count = 2180)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public Detector() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 6)]
	private static void copyToResult(ResultPoint[] result, ResultPoint[] tmpResult, Int32[] destinationIndexes) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BinaryBitmap), Member = "get_BlackMatrix", ReturnType = typeof(BitMatrix))]
	[Calls(Type = typeof(Detector), Member = "detect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(BitMatrix)}, ReturnType = typeof(System.Collections.Generic.List`1<ResultPoint[]>))]
	[Calls(Type = typeof(BitMatrix), Member = "Clone", ReturnType = typeof(object))]
	[Calls(Type = typeof(BitMatrix), Member = "rotate180", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public static PDF417DetectorResult detect(BinaryBitmap image, IDictionary<DecodeHintType, Object> hints, bool multiple) { }

	[CalledBy(Type = typeof(Detector), Member = "detect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryBitmap), typeof(System.Collections.Generic.IDictionary`2<ZXing.DecodeHintType, System.Object>), typeof(bool)}, ReturnType = typeof(PDF417DetectorResult))]
	[CalledBy(Type = typeof(PDF417Reader), Member = "decode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryBitmap), typeof(System.Collections.Generic.IDictionary`2<ZXing.DecodeHintType, System.Object>), typeof(bool)}, ReturnType = typeof(Result[]))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Detector), Member = "findVertices", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitMatrix), typeof(int), typeof(int)}, ReturnType = typeof(ResultPoint[]))]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Math), Member = "Max", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(Math), Member = "Max", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 11)]
	[ContainsUnimplementedInstructions]
	private static List<ResultPoint[]> detect(bool multiple, BitMatrix bitMatrix) { }

	[CalledBy(Type = typeof(Detector), Member = "findRowsWithPattern", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitMatrix), typeof(int), typeof(int), typeof(int), typeof(int), typeof(Int32[])}, ReturnType = typeof(ResultPoint[]))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(SupportClass), Member = "Fill", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[]), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BitMatrix), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	private static Int32[] findGuardPattern(BitMatrix matrix, int column, int row, int width, bool whiteFirst, Int32[] pattern, Int32[] counters) { }

	[CalledBy(Type = typeof(Detector), Member = "findVertices", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitMatrix), typeof(int), typeof(int)}, ReturnType = typeof(ResultPoint[]))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Detector), Member = "findGuardPattern", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitMatrix), typeof(int), typeof(int), typeof(int), typeof(bool), typeof(Int32[]), typeof(Int32[])}, ReturnType = typeof(Int32[]))]
	[Calls(Type = typeof(ResultPoint), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 19)]
	[ContainsUnimplementedInstructions]
	private static ResultPoint[] findRowsWithPattern(BitMatrix matrix, int height, int width, int startRow, int startColumn, Int32[] pattern) { }

	[CalledBy(Type = typeof(Detector), Member = "detect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(BitMatrix)}, ReturnType = typeof(System.Collections.Generic.List`1<ResultPoint[]>))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Detector), Member = "findRowsWithPattern", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitMatrix), typeof(int), typeof(int), typeof(int), typeof(int), typeof(Int32[])}, ReturnType = typeof(ResultPoint[]))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 10)]
	[ContainsUnimplementedInstructions]
	private static ResultPoint[] findVertices(BitMatrix matrix, int startRow, int startColumn) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	private static int patternMatchVariance(Int32[] counters, Int32[] pattern, int maxIndividualVariance) { }

}

