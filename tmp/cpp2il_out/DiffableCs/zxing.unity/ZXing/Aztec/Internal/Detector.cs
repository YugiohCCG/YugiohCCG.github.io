namespace ZXing.Aztec.Internal;

public sealed class Detector
{
	public sealed class Point
	{
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
		private int <X>k__BackingField; //Field offset: 0x10
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
		private int <Y>k__BackingField; //Field offset: 0x14

		public private int X
		{
			[CallerCount(Count = 94)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			 get { } //Length: 4
			[CallerCount(Count = 7)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			private set { } //Length: 4
		}

		public private int Y
		{
			[CallerCount(Count = 2)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			 get { } //Length: 4
			[CallerCount(Count = 5)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			private set { } //Length: 4
		}

		[CallerCount(Count = 79)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		internal Point(int x, int y) { }

		[CallerCount(Count = 94)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		public int get_X() { }

		[CallerCount(Count = 2)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		public int get_Y() { }

		[CallerCount(Count = 7)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private void set_X(int value) { }

		[CallerCount(Count = 5)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private void set_Y(int value) { }

		[CalledBy(Type = typeof(Detector), Member = "getMatrixCenter", ReturnType = typeof(Point))]
		[CallerCount(Count = 8)]
		[Calls(Type = typeof(ResultPoint), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(void))]
		public ResultPoint toResultPoint() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[])}, ReturnType = typeof(string))]
		[CallsUnknownMethods(Count = 22)]
		public virtual string ToString() { }

	}

	private static readonly Int32[] EXPECTED_CORNER_BITS; //Field offset: 0x0
	private readonly BitMatrix image; //Field offset: 0x10
	private bool compact; //Field offset: 0x18
	private int nbLayers; //Field offset: 0x1C
	private int nbDataBlocks; //Field offset: 0x20
	private int nbCenterLayers; //Field offset: 0x24
	private int shift; //Field offset: 0x28

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(RuntimeFieldHandle)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private static Detector() { }

	[CallerCount(Count = 98)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public Detector(BitMatrix image) { }

	[CalledBy(Type = typeof(AztecReader), Member = "decode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryBitmap), typeof(System.Collections.Generic.IDictionary`2<ZXing.DecodeHintType, System.Object>)}, ReturnType = typeof(Result))]
	[CalledBy(Type = typeof(Detector), Member = "detect", ReturnType = typeof(AztecDetectorResult))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Detector), Member = "getMatrixCenter", ReturnType = typeof(Point))]
	[Calls(Type = typeof(Detector), Member = "getBullsEyeCorners", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Point)}, ReturnType = typeof(ResultPoint[]))]
	[Calls(Type = typeof(Detector), Member = "extractParameters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ResultPoint[])}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Detector), Member = "sampleGrid", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitMatrix), typeof(ResultPoint), typeof(ResultPoint), typeof(ResultPoint), typeof(ResultPoint)}, ReturnType = typeof(BitMatrix))]
	[Calls(Type = typeof(Detector), Member = "expandSquare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ResultPoint[]), typeof(float), typeof(float)}, ReturnType = typeof(ResultPoint[]))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 9)]
	public AztecDetectorResult detect(bool isMirror) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Detector), Member = "detect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(AztecDetectorResult))]
	public AztecDetectorResult detect() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MathUtils), Member = "distance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(float), typeof(float)}, ReturnType = typeof(float))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	private static float distance(ResultPoint a, ResultPoint b) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MathUtils), Member = "distance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(float))]
	[CallsUnknownMethods(Count = 1)]
	private static float distance(Point a, Point b) { }

	[CalledBy(Type = typeof(Detector), Member = "detect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(AztecDetectorResult))]
	[CalledBy(Type = typeof(Detector), Member = "getBullsEyeCorners", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Point)}, ReturnType = typeof(ResultPoint[]))]
	[CalledBy(Type = typeof(Detector), Member = "getMatrixCornerPoints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ResultPoint[])}, ReturnType = typeof(ResultPoint[]))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(ResultPoint), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 16)]
	[CallsUnknownMethods(Count = 18)]
	private static ResultPoint[] expandSquare(ResultPoint[] cornerPoints, float oldSide, float newSide) { }

	[CalledBy(Type = typeof(Detector), Member = "detect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(AztecDetectorResult))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(MathUtils), Member = "round", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Detector), Member = "isValid", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ResultPoint)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Detector), Member = "sampleLine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ResultPoint), typeof(ResultPoint), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(SupportClass), Member = "bitCount", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ReedSolomonDecoder), Member = "decode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[]), typeof(int)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	private bool extractParameters(ResultPoint[] bullsEyeCorners) { }

	[CalledBy(Type = typeof(Detector), Member = "detect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(AztecDetectorResult))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Detector), Member = "getFirstDifferent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Point), typeof(bool), typeof(int), typeof(int)}, ReturnType = typeof(Point))]
	[Calls(Type = typeof(MathUtils), Member = "distance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(Detector), Member = "isWhiteOrBlackRectangle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Point), typeof(Point), typeof(Point), typeof(Point)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ResultPoint), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Detector), Member = "expandSquare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ResultPoint[]), typeof(float), typeof(float)}, ReturnType = typeof(ResultPoint[]))]
	[CallsUnknownMethods(Count = 18)]
	[ContainsUnimplementedInstructions]
	private ResultPoint[] getBullsEyeCorners(Point pCenter) { }

	[CalledBy(Type = typeof(Detector), Member = "isWhiteOrBlackRectangle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Point), typeof(Point), typeof(Point), typeof(Point)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(MathUtils), Member = "distance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(BitMatrix), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(MathUtils), Member = "round", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private int getColor(Point p1, Point p2) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ReedSolomonDecoder), Member = "decode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[]), typeof(int)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private static int getCorrectedParameterData(long parameterData, bool compact) { }

	[CallerCount(Count = 0)]
	private int getDimension() { }

	[CalledBy(Type = typeof(Detector), Member = "getBullsEyeCorners", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Point)}, ReturnType = typeof(ResultPoint[]))]
	[CalledBy(Type = typeof(Detector), Member = "getMatrixCenter", ReturnType = typeof(Point))]
	[CallerCount(Count = 12)]
	[Calls(Type = typeof(BitMatrix), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private Point getFirstDifferent(Point init, bool color, int dx, int dy) { }

	[CalledBy(Type = typeof(Detector), Member = "detect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(AztecDetectorResult))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(WhiteRectangleDetector), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitMatrix)}, ReturnType = typeof(WhiteRectangleDetector))]
	[Calls(Type = typeof(WhiteRectangleDetector), Member = "detect", ReturnType = typeof(ResultPoint[]))]
	[Calls(Type = typeof(Detector), Member = "getFirstDifferent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Point), typeof(bool), typeof(int), typeof(int)}, ReturnType = typeof(Point))]
	[Calls(Type = typeof(Point), Member = "toResultPoint", ReturnType = typeof(ResultPoint))]
	[Calls(Type = typeof(MathUtils), Member = "round", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(WhiteRectangleDetector), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitMatrix), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(WhiteRectangleDetector))]
	[CallsDeduplicatedMethods(Count = 25)]
	[CallsUnknownMethods(Count = 2)]
	private Point getMatrixCenter() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Detector), Member = "expandSquare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ResultPoint[]), typeof(float), typeof(float)}, ReturnType = typeof(ResultPoint[]))]
	private ResultPoint[] getMatrixCornerPoints(ResultPoint[] bullsEyeCorners) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SupportClass), Member = "bitCount", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 2)]
	private static int getRotation(Int32[] sides, int length) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private bool isValid(int x, int y) { }

	[CalledBy(Type = typeof(Detector), Member = "extractParameters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ResultPoint[])}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(MathUtils), Member = "round", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private bool isValid(ResultPoint point) { }

	[CalledBy(Type = typeof(Detector), Member = "getBullsEyeCorners", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Point)}, ReturnType = typeof(ResultPoint[]))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Detector), Member = "getColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Point), typeof(Point)}, ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private bool isWhiteOrBlackRectangle(Point p1, Point p2, Point p3, Point p4) { }

	[CalledBy(Type = typeof(Detector), Member = "detect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(AztecDetectorResult))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private BitMatrix sampleGrid(BitMatrix image, ResultPoint topLeft, ResultPoint topRight, ResultPoint bottomRight, ResultPoint bottomLeft) { }

	[CalledBy(Type = typeof(Detector), Member = "extractParameters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ResultPoint[])}, ReturnType = typeof(bool))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(MathUtils), Member = "distance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(float), typeof(float)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(MathUtils), Member = "round", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(BitMatrix), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private int sampleLine(ResultPoint p1, ResultPoint p2, int size) { }

}

