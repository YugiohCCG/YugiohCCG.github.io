namespace ZXing.QrCode.Internal;

internal sealed class AlignmentPatternFinder
{
	private readonly BitMatrix image; //Field offset: 0x10
	private readonly IList<AlignmentPattern> possibleCenters; //Field offset: 0x18
	private readonly int startX; //Field offset: 0x20
	private readonly int startY; //Field offset: 0x24
	private readonly int width; //Field offset: 0x28
	private readonly int height; //Field offset: 0x2C
	private readonly float moduleSize; //Field offset: 0x30
	private readonly Int32[] crossCheckStateCount; //Field offset: 0x38
	private readonly ResultPointCallback resultPointCallback; //Field offset: 0x40

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	internal AlignmentPatternFinder(BitMatrix image, int startX, int startY, int width, int height, float moduleSize, ResultPointCallback resultPointCallback) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.Nullable`1<System.Single>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	private static Nullable<Single> centerFromEnd(Int32[] stateCount, int end) { }

	[CalledBy(Type = typeof(AlignmentPatternFinder), Member = "handlePossibleCenter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[]), typeof(int), typeof(int)}, ReturnType = typeof(AlignmentPattern))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BitMatrix), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(AlignmentPatternFinder), Member = "foundPatternCross", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[])}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Nullable`1<System.Single>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	private Nullable<Single> crossCheckVertical(int startI, int centerJ, int maxCount, int originalStateCountTotal) { }

	[CalledBy(Type = typeof(Detector), Member = "findAlignmentInRegion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(int), typeof(int), typeof(float)}, ReturnType = typeof(AlignmentPattern))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BitMatrix), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(AlignmentPatternFinder), Member = "foundPatternCross", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[])}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(AlignmentPatternFinder), Member = "handlePossibleCenter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[]), typeof(int), typeof(int)}, ReturnType = typeof(AlignmentPattern))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	internal AlignmentPattern find() { }

	[CalledBy(Type = typeof(AlignmentPatternFinder), Member = "find", ReturnType = typeof(AlignmentPattern))]
	[CalledBy(Type = typeof(AlignmentPatternFinder), Member = "crossCheckVertical", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(System.Nullable`1<System.Single>))]
	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	private bool foundPatternCross(Int32[] stateCount) { }

	[CalledBy(Type = typeof(AlignmentPatternFinder), Member = "find", ReturnType = typeof(AlignmentPattern))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(System.Nullable`1<System.Single>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Nullable`1<System.Single>), Member = "get_Value", ReturnType = typeof(float))]
	[Calls(Type = typeof(AlignmentPatternFinder), Member = "crossCheckVertical", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(System.Nullable`1<System.Single>))]
	[Calls(Type = typeof(AlignmentPattern), Member = "combineEstimate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(float)}, ReturnType = typeof(AlignmentPattern))]
	[Calls(Type = typeof(ResultPoint), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 13)]
	[ContainsUnimplementedInstructions]
	private AlignmentPattern handlePossibleCenter(Int32[] stateCount, int i, int j) { }

}

