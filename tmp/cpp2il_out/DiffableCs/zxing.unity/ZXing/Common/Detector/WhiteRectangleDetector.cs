namespace ZXing.Common.Detector;

public sealed class WhiteRectangleDetector
{
	private const int INIT_SIZE = 10; //Field offset: 0x0
	private const int CORR = 1; //Field offset: 0x0
	private readonly BitMatrix image; //Field offset: 0x10
	private readonly int height; //Field offset: 0x18
	private readonly int width; //Field offset: 0x1C
	private readonly int leftInit; //Field offset: 0x20
	private readonly int rightInit; //Field offset: 0x24
	private readonly int downInit; //Field offset: 0x28
	private readonly int upInit; //Field offset: 0x2C

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	internal WhiteRectangleDetector(BitMatrix image) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	internal WhiteRectangleDetector(BitMatrix image, int initSize, int x, int y) { }

	[CalledBy(Type = typeof(WhiteRectangleDetector), Member = "detect", ReturnType = typeof(ResultPoint[]))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ResultPoint), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 33)]
	private ResultPoint[] centerEdges(ResultPoint y, ResultPoint z, ResultPoint x, ResultPoint t) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private bool containsBlackPoint(int a, int b, int fixed, bool horizontal) { }

	[CalledBy(Type = typeof(Detector), Member = "getMatrixCenter", ReturnType = typeof(Point))]
	[CalledBy(Type = typeof(DataMatrixReader), Member = "decode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryBitmap), typeof(System.Collections.Generic.IDictionary`2<ZXing.DecodeHintType, System.Object>)}, ReturnType = typeof(Result))]
	[CalledBy(Type = typeof(Detector), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitMatrix)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static WhiteRectangleDetector Create(BitMatrix image) { }

	[CalledBy(Type = typeof(Detector), Member = "getMatrixCenter", ReturnType = typeof(Point))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static WhiteRectangleDetector Create(BitMatrix image, int initSize, int x, int y) { }

	[CalledBy(Type = typeof(Detector), Member = "getMatrixCenter", ReturnType = typeof(Point))]
	[CalledBy(Type = typeof(Detector), Member = "detect", ReturnType = typeof(DetectorResult))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(BitMatrix), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(WhiteRectangleDetector), Member = "getBlackPointOnSegment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(float), typeof(float)}, ReturnType = typeof(ResultPoint))]
	[Calls(Type = typeof(WhiteRectangleDetector), Member = "centerEdges", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ResultPoint), typeof(ResultPoint), typeof(ResultPoint), typeof(ResultPoint)}, ReturnType = typeof(ResultPoint[]))]
	[CallsUnknownMethods(Count = 1)]
	public ResultPoint[] detect() { }

	[CalledBy(Type = typeof(WhiteRectangleDetector), Member = "detect", ReturnType = typeof(ResultPoint[]))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(ResultPoint), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	private ResultPoint getBlackPointOnSegment(float aX, float aY, float bX, float bY) { }

}

