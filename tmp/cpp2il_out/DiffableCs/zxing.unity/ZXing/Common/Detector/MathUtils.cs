namespace ZXing.Common.Detector;

public static class MathUtils
{

	[CalledBy(Type = typeof(Detector), Member = "sampleLine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ResultPoint), typeof(ResultPoint), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(Detector), Member = "distance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ResultPoint), typeof(ResultPoint)}, ReturnType = typeof(float))]
	[CalledBy(Type = typeof(ResultPoint), Member = "orderBestPatterns", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ResultPoint[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ResultPoint), Member = "distance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ResultPoint), typeof(ResultPoint)}, ReturnType = typeof(float))]
	[CallerCount(Count = 6)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public static float distance(float aX, float aY, float bX, float bY) { }

	[CalledBy(Type = typeof(Detector), Member = "getBullsEyeCorners", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Point)}, ReturnType = typeof(ResultPoint[]))]
	[CalledBy(Type = typeof(Detector), Member = "getColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Point), typeof(Point)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(Detector), Member = "distance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Point), typeof(Point)}, ReturnType = typeof(float))]
	[CalledBy(Type = typeof(Detector), Member = "sizeOfBlackWhiteBlackRun", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(float))]
	[CallerCount(Count = 6)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public static float distance(int aX, int aY, int bX, int bY) { }

	[CalledBy(Type = typeof(Detector), Member = "extractParameters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ResultPoint[])}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Detector), Member = "getMatrixCenter", ReturnType = typeof(Point))]
	[CalledBy(Type = typeof(Detector), Member = "sampleLine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ResultPoint), typeof(ResultPoint), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(Detector), Member = "getColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Point), typeof(Point)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(Detector), Member = "isValid", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ResultPoint)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Detector), Member = "correctTopRightRectangular", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ResultPoint), typeof(ResultPoint), typeof(ResultPoint), typeof(ResultPoint), typeof(int), typeof(int)}, ReturnType = typeof(ResultPoint))]
	[CalledBy(Type = typeof(Detector), Member = "correctTopRight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ResultPoint), typeof(ResultPoint), typeof(ResultPoint), typeof(ResultPoint), typeof(int)}, ReturnType = typeof(ResultPoint))]
	[CalledBy(Type = typeof(Detector), Member = "distance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ResultPoint), typeof(ResultPoint)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(Detector), Member = "processFinderPatternInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FinderPatternInfo)}, ReturnType = typeof(DetectorResult))]
	[CalledBy(Type = typeof(Detector), Member = "computeDimension", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ResultPoint), typeof(ResultPoint), typeof(ResultPoint), typeof(float), typeof(Int32&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 27)]
	[ContainsUnimplementedInstructions]
	public static int round(float d) { }

}

