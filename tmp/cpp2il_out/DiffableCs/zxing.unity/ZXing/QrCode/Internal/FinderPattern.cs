namespace ZXing.QrCode.Internal;

public sealed class FinderPattern : ResultPoint
{
	private readonly float estimatedModuleSize; //Field offset: 0x30
	private int count; //Field offset: 0x34

	internal int Count
	{
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		internal get { } //Length: 4
	}

	public float EstimatedModuleSize
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 6
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ResultPoint), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(void))]
	internal FinderPattern(float posX, float posY, float estimatedModuleSize) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ResultPoint), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(void))]
	internal FinderPattern(float posX, float posY, float estimatedModuleSize, int count) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	internal bool aboutEquals(float moduleSize, float i, float j) { }

	[CalledBy(Type = typeof(FinderPatternFinder), Member = "handlePossibleCenter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[]), typeof(int), typeof(int), typeof(bool)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ResultPoint), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	internal FinderPattern combineEstimate(float i, float j, float newModuleSize) { }

	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	internal int get_Count() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public float get_EstimatedModuleSize() { }

}

