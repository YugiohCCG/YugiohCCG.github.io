namespace ZXing.Multi.QrCode.Internal;

internal sealed class MultiFinderPatternFinder : FinderPatternFinder
{
	private sealed class ModuleSizeComparator : IComparer<FinderPattern>
	{

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public ModuleSizeComparator() { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		public override int Compare(FinderPattern center1, FinderPattern center2) { }

	}

	private static FinderPatternInfo[] EMPTY_RESULT_ARRAY; //Field offset: 0x0
	private const float DIFF_MODSIZE_CUTOFF = 0.5; //Field offset: 0x0
	private static float MAX_MODULE_COUNT_PER_EDGE; //Field offset: 0x8
	private static float MIN_MODULE_COUNT_PER_EDGE; //Field offset: 0xC
	private static float DIFF_MODSIZE_CUTOFF_PERCENT; //Field offset: 0x10

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private static MultiFinderPatternFinder() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FinderPatternFinder), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitMatrix)}, ReturnType = typeof(void))]
	internal MultiFinderPatternFinder(BitMatrix image) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FinderPatternFinder), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitMatrix), typeof(ResultPointCallback)}, ReturnType = typeof(void))]
	internal MultiFinderPatternFinder(BitMatrix image, ResultPointCallback resultPointCallback) { }

	[CalledBy(Type = typeof(MultiDetector), Member = "detectMulti", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IDictionary`2<ZXing.DecodeHintType, System.Object>)}, ReturnType = typeof(DetectorResult[]))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BitMatrix), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(FinderPatternFinder), Member = "foundPatternCross", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[])}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(FinderPatternFinder), Member = "handlePossibleCenter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[]), typeof(int), typeof(int), typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(MultiFinderPatternFinder), Member = "selectMutipleBestPatterns", ReturnType = typeof(FinderPattern[][]))]
	[Calls(Type = typeof(ResultPoint), Member = "orderBestPatterns", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ResultPoint[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FinderPatternInfo), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FinderPattern[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "ToArray", ReturnType = "T[]")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	[ContainsUnimplementedInstructions]
	public FinderPatternInfo[] findMulti(IDictionary<DecodeHintType, Object> hints) { }

	[CalledBy(Type = typeof(MultiFinderPatternFinder), Member = "findMulti", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IDictionary`2<ZXing.DecodeHintType, System.Object>)}, ReturnType = typeof(FinderPatternInfo[]))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Sort", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IComparer`1<System.Object>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Math), Member = "Min", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(ResultPoint), Member = "orderBestPatterns", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ResultPoint[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FinderPatternInfo), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FinderPattern[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ResultPoint), Member = "distance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ResultPoint), typeof(ResultPoint)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(List`1), Member = "ToArray", ReturnType = "T[]")]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallsUnknownMethods(Count = 11)]
	[ContainsUnimplementedInstructions]
	private FinderPattern[][] selectMutipleBestPatterns() { }

}

