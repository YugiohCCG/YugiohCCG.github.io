namespace ZXing.QrCode.Internal;

public sealed class AlignmentPattern : ResultPoint
{
	private float estimatedModuleSize; //Field offset: 0x30

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ResultPoint), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(void))]
	internal AlignmentPattern(float posX, float posY, float estimatedModuleSize) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	internal bool aboutEquals(float moduleSize, float i, float j) { }

	[CalledBy(Type = typeof(AlignmentPatternFinder), Member = "handlePossibleCenter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[]), typeof(int), typeof(int)}, ReturnType = typeof(AlignmentPattern))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ResultPoint), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	internal AlignmentPattern combineEstimate(float i, float j, float newModuleSize) { }

}

