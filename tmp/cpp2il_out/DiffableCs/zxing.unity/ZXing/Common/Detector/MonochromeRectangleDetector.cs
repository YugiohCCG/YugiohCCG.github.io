namespace ZXing.Common.Detector;

public sealed class MonochromeRectangleDetector
{
	private const int MAX_MODULES = 32; //Field offset: 0x0
	private BitMatrix image; //Field offset: 0x10

	[CallerCount(Count = 98)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public MonochromeRectangleDetector(BitMatrix image) { }

	[CalledBy(Type = typeof(MonochromeRectangleDetector), Member = "findCornerFromCenter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(ResultPoint))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BitMatrix), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 2)]
	private Int32[] blackWhiteRange(int fixedDimension, int maxWhiteRun, int minDim, int maxDim, bool horizontal) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Math), Member = "Max", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(MonochromeRectangleDetector), Member = "findCornerFromCenter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(ResultPoint))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 18)]
	[ContainsUnimplementedInstructions]
	public ResultPoint[] detect() { }

	[CalledBy(Type = typeof(MonochromeRectangleDetector), Member = "detect", ReturnType = typeof(ResultPoint[]))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(MonochromeRectangleDetector), Member = "blackWhiteRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(int), typeof(bool)}, ReturnType = typeof(Int32[]))]
	[Calls(Type = typeof(ResultPoint), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private ResultPoint findCornerFromCenter(int centerX, int deltaX, int left, int right, int centerY, int deltaY, int top, int bottom, int maxWhiteRun) { }

}

