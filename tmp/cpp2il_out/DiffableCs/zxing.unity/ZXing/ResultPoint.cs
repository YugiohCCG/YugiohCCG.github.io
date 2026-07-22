namespace ZXing;

public class ResultPoint
{
	private readonly float x; //Field offset: 0x10
	private readonly float y; //Field offset: 0x14
	private readonly Byte[] bytesX; //Field offset: 0x18
	private readonly Byte[] bytesY; //Field offset: 0x20
	private string toString; //Field offset: 0x28

	public override float X
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 6
	}

	public override float Y
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 6
	}

	[CallerCount(Count = 2180)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public ResultPoint() { }

	[CallerCount(Count = 81)]
	[Calls(Type = typeof(BitConverter), Member = "GetBytes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(Byte[]))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public ResultPoint(float x, float y) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private static float crossProductZ(ResultPoint pointA, ResultPoint pointB, ResultPoint pointC) { }

	[CalledBy(Type = typeof(Detector), Member = "correctTopRightRectangular", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ResultPoint), typeof(ResultPoint), typeof(ResultPoint), typeof(ResultPoint), typeof(int), typeof(int)}, ReturnType = typeof(ResultPoint))]
	[CalledBy(Type = typeof(Detector), Member = "correctTopRight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ResultPoint), typeof(ResultPoint), typeof(ResultPoint), typeof(ResultPoint), typeof(int)}, ReturnType = typeof(ResultPoint))]
	[CalledBy(Type = typeof(Detector), Member = "distance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ResultPoint), typeof(ResultPoint)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(MultiFinderPatternFinder), Member = "selectMutipleBestPatterns", ReturnType = typeof(FinderPattern[][]))]
	[CalledBy(Type = typeof(Detector), Member = "processFinderPatternInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FinderPatternInfo)}, ReturnType = typeof(DetectorResult))]
	[CalledBy(Type = typeof(Detector), Member = "computeDimension", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ResultPoint), typeof(ResultPoint), typeof(ResultPoint), typeof(float), typeof(Int32&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 16)]
	[Calls(Type = typeof(MathUtils), Member = "distance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(float), typeof(float)}, ReturnType = typeof(float))]
	[CallsUnknownMethods(Count = 1)]
	public static float distance(ResultPoint pattern1, ResultPoint pattern2) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public virtual bool Equals(object other) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public override float get_X() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public override float get_Y() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public virtual int GetHashCode() { }

	[CalledBy(Type = typeof(Detector), Member = "detect", ReturnType = typeof(DetectorResult))]
	[CalledBy(Type = typeof(MultiFinderPatternFinder), Member = "selectMutipleBestPatterns", ReturnType = typeof(FinderPattern[][]))]
	[CalledBy(Type = typeof(MultiFinderPatternFinder), Member = "findMulti", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IDictionary`2<ZXing.DecodeHintType, System.Object>)}, ReturnType = typeof(FinderPatternInfo[]))]
	[CalledBy(Type = typeof(FinderPatternFinder), Member = "find", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IDictionary`2<ZXing.DecodeHintType, System.Object>)}, ReturnType = typeof(FinderPatternInfo))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(MathUtils), Member = "distance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(float), typeof(float)}, ReturnType = typeof(float))]
	[CallsUnknownMethods(Count = 14)]
	public static void orderBestPatterns(ResultPoint[] patterns) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CultureInfo), Member = "get_CurrentUICulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(StringBuilder), Member = "AppendFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider), typeof(string), typeof(Object[])}, ReturnType = typeof(StringBuilder))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 11)]
	public virtual string ToString() { }

}

