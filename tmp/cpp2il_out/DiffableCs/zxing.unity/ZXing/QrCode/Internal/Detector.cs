namespace ZXing.QrCode.Internal;

public class Detector
{
	private readonly BitMatrix image; //Field offset: 0x10
	private ResultPointCallback resultPointCallback; //Field offset: 0x18

	protected private override BitMatrix Image
	{
		[CallerCount(Count = 106)]
		[DeduplicatedMethod]
		private get { } //Length: 5
	}

	protected private override ResultPointCallback ResultPointCallback
	{
		[CallerCount(Count = 31)]
		[DeduplicatedMethod]
		private get { } //Length: 5
	}

	[CallerCount(Count = 98)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public Detector(BitMatrix image) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Detector), Member = "calculateModuleSizeOneWay", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ResultPoint), typeof(ResultPoint)}, ReturnType = typeof(float))]
	protected private override float calculateModuleSize(ResultPoint topLeft, ResultPoint topRight, ResultPoint bottomLeft) { }

	[CalledBy(Type = typeof(Detector), Member = "calculateModuleSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ResultPoint), typeof(ResultPoint), typeof(ResultPoint)}, ReturnType = typeof(float))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Detector), Member = "sizeOfBlackWhiteBlackRunBothWays", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(float))]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private float calculateModuleSizeOneWay(ResultPoint pattern, ResultPoint otherPattern) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ResultPoint), Member = "distance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ResultPoint), typeof(ResultPoint)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(MathUtils), Member = "round", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(int))]
	private static bool computeDimension(ResultPoint topLeft, ResultPoint topRight, ResultPoint bottomLeft, float moduleSize, out int dimension) { }

	[CalledBy(Type = typeof(Detector), Member = "processFinderPatternInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FinderPatternInfo)}, ReturnType = typeof(DetectorResult))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PerspectiveTransform), Member = "quadrilateralToQuadrilateral", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float)}, ReturnType = typeof(PerspectiveTransform))]
	[CallsDeduplicatedMethods(Count = 14)]
	[CallsUnknownMethods(Count = 1)]
	private static PerspectiveTransform createTransform(ResultPoint topLeft, ResultPoint topRight, ResultPoint bottomLeft, ResultPoint alignmentPattern, int dimension) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public override DetectorResult detect() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FinderPatternFinder), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitMatrix), typeof(ResultPointCallback)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	public override DetectorResult detect(IDictionary<DecodeHintType, Object> hints) { }

	[CalledBy(Type = typeof(Detector), Member = "processFinderPatternInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FinderPatternInfo)}, ReturnType = typeof(DetectorResult))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Math), Member = "Max", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Math), Member = "Min", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(List`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AlignmentPatternFinder), Member = "find", ReturnType = typeof(AlignmentPattern))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	[ContainsUnimplementedInstructions]
	protected AlignmentPattern findAlignmentInRegion(float overallEstModuleSize, int estAlignmentX, int estAlignmentY, float allowanceFactor) { }

	[CallerCount(Count = 106)]
	[DeduplicatedMethod]
	protected private override BitMatrix get_Image() { }

	[CallerCount(Count = 31)]
	[DeduplicatedMethod]
	protected private override ResultPointCallback get_ResultPointCallback() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ResultPoint), Member = "distance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ResultPoint), typeof(ResultPoint)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(MathUtils), Member = "round", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Version), Member = "getProvisionalVersionForDimension", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Version))]
	[Calls(Type = typeof(Detector), Member = "findAlignmentInRegion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(int), typeof(int), typeof(float)}, ReturnType = typeof(AlignmentPattern))]
	[Calls(Type = typeof(Detector), Member = "createTransform", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ResultPoint), typeof(ResultPoint), typeof(ResultPoint), typeof(ResultPoint), typeof(int)}, ReturnType = typeof(PerspectiveTransform))]
	[CallsDeduplicatedMethods(Count = 13)]
	[CallsUnknownMethods(Count = 29)]
	[ContainsUnimplementedInstructions]
	protected private override DetectorResult processFinderPatternInfo(FinderPatternInfo info) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private static BitMatrix sampleGrid(BitMatrix image, PerspectiveTransform transform, int dimension) { }

	[CalledBy(Type = typeof(Detector), Member = "sizeOfBlackWhiteBlackRunBothWays", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(float))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(BitMatrix), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(MathUtils), Member = "distance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(float))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private float sizeOfBlackWhiteBlackRun(int fromX, int fromY, int toX, int toY) { }

	[CalledBy(Type = typeof(Detector), Member = "calculateModuleSizeOneWay", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ResultPoint), typeof(ResultPoint)}, ReturnType = typeof(float))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Detector), Member = "sizeOfBlackWhiteBlackRun", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(float))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private float sizeOfBlackWhiteBlackRunBothWays(int fromX, int fromY, int toX, int toY) { }

}

