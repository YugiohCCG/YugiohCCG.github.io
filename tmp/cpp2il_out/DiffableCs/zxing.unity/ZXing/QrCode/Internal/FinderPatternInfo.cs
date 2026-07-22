namespace ZXing.QrCode.Internal;

public sealed class FinderPatternInfo
{
	private readonly FinderPattern bottomLeft; //Field offset: 0x10
	private readonly FinderPattern topLeft; //Field offset: 0x18
	private readonly FinderPattern topRight; //Field offset: 0x20

	public FinderPattern BottomLeft
	{
		[CallerCount(Count = 106)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public FinderPattern TopLeft
	{
		[CallerCount(Count = 31)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public FinderPattern TopRight
	{
		[CallerCount(Count = 12)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	[CalledBy(Type = typeof(MultiFinderPatternFinder), Member = "selectMutipleBestPatterns", ReturnType = typeof(FinderPattern[][]))]
	[CalledBy(Type = typeof(MultiFinderPatternFinder), Member = "findMulti", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IDictionary`2<ZXing.DecodeHintType, System.Object>)}, ReturnType = typeof(FinderPatternInfo[]))]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	public FinderPatternInfo(FinderPattern[] patternCenters) { }

	[CallerCount(Count = 106)]
	[DeduplicatedMethod]
	public FinderPattern get_BottomLeft() { }

	[CallerCount(Count = 31)]
	[DeduplicatedMethod]
	public FinderPattern get_TopLeft() { }

	[CallerCount(Count = 12)]
	[DeduplicatedMethod]
	public FinderPattern get_TopRight() { }

}

