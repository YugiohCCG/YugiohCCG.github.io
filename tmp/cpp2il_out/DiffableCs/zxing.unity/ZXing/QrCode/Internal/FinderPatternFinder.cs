namespace ZXing.QrCode.Internal;

public class FinderPatternFinder
{
	private sealed class CenterComparator : IComparer<FinderPattern>
	{
		private readonly float average; //Field offset: 0x10

		[CallerCount(Count = 4)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public CenterComparator(float f) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		public override int Compare(FinderPattern x, FinderPattern y) { }

	}

	private sealed class FurthestFromAverageComparator : IComparer<FinderPattern>
	{
		private readonly float average; //Field offset: 0x10

		[CallerCount(Count = 4)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public FurthestFromAverageComparator(float f) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		public override int Compare(FinderPattern x, FinderPattern y) { }

	}

	private const int CENTER_QUORUM = 2; //Field offset: 0x0
	protected private const int MIN_SKIP = 3; //Field offset: 0x0
	protected private const int MAX_MODULES = 57; //Field offset: 0x0
	private const int INTEGER_MATH_SHIFT = 8; //Field offset: 0x0
	private readonly BitMatrix image; //Field offset: 0x10
	private List<FinderPattern> possibleCenters; //Field offset: 0x18
	private bool hasSkipped; //Field offset: 0x20
	private readonly Int32[] crossCheckStateCount; //Field offset: 0x28
	private readonly ResultPointCallback resultPointCallback; //Field offset: 0x30

	private Int32[] CrossCheckStateCount
	{
		[CalledBy(Type = typeof(FinderPatternFinder), Member = "crossCheckDiagonal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(FinderPatternFinder), Member = "crossCheckVertical", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(System.Nullable`1<System.Single>))]
		[CalledBy(Type = typeof(FinderPatternFinder), Member = "crossCheckHorizontal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(System.Nullable`1<System.Single>))]
		[CallerCount(Count = 3)]
		[CallsUnknownMethods(Count = 2)]
		private get { } //Length: 116
	}

	protected private override BitMatrix Image
	{
		[CallerCount(Count = 106)]
		[DeduplicatedMethod]
		private get { } //Length: 5
	}

	protected private override List<FinderPattern> PossibleCenters
	{
		[CallerCount(Count = 31)]
		[DeduplicatedMethod]
		private get { } //Length: 5
	}

	[CalledBy(Type = typeof(MultiFinderPatternFinder), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitMatrix)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[ContainsInvalidInstructions]
	public FinderPatternFinder(BitMatrix image) { }

	[CalledBy(Type = typeof(MultiDetector), Member = "detectMulti", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IDictionary`2<ZXing.DecodeHintType, System.Object>)}, ReturnType = typeof(DetectorResult[]))]
	[CalledBy(Type = typeof(MultiFinderPatternFinder), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitMatrix), typeof(ResultPointCallback)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Detector), Member = "detect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IDictionary`2<ZXing.DecodeHintType, System.Object>)}, ReturnType = typeof(DetectorResult))]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	public FinderPatternFinder(BitMatrix image, ResultPointCallback resultPointCallback) { }

	[CalledBy(Type = typeof(FinderPatternFinder), Member = "handlePossibleCenter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[]), typeof(int), typeof(int), typeof(bool)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.Nullable`1<System.Single>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	private static Nullable<Single> centerFromEnd(Int32[] stateCount, int end) { }

	[CalledBy(Type = typeof(FinderPatternFinder), Member = "handlePossibleCenter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[]), typeof(int), typeof(int), typeof(bool)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(FinderPatternFinder), Member = "get_CrossCheckStateCount", ReturnType = typeof(Int32[]))]
	[Calls(Type = typeof(BitMatrix), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(FinderPatternFinder), Member = "foundPatternCross", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[])}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 2)]
	private bool crossCheckDiagonal(int startI, int centerJ, int maxCount, int originalStateCountTotal) { }

	[CalledBy(Type = typeof(FinderPatternFinder), Member = "handlePossibleCenter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[]), typeof(int), typeof(int), typeof(bool)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(FinderPatternFinder), Member = "get_CrossCheckStateCount", ReturnType = typeof(Int32[]))]
	[Calls(Type = typeof(BitMatrix), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(FinderPatternFinder), Member = "foundPatternCross", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[])}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Nullable`1<System.Single>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	private Nullable<Single> crossCheckHorizontal(int startJ, int centerI, int maxCount, int originalStateCountTotal) { }

	[CalledBy(Type = typeof(FinderPatternFinder), Member = "handlePossibleCenter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[]), typeof(int), typeof(int), typeof(bool)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(FinderPatternFinder), Member = "get_CrossCheckStateCount", ReturnType = typeof(Int32[]))]
	[Calls(Type = typeof(BitMatrix), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(FinderPatternFinder), Member = "foundPatternCross", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[])}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Nullable`1<System.Single>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	private Nullable<Single> crossCheckVertical(int startI, int centerJ, int maxCount, int originalStateCountTotal) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BitMatrix), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(FinderPatternFinder), Member = "foundPatternCross", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[])}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(FinderPatternFinder), Member = "handlePossibleCenter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[]), typeof(int), typeof(int), typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(FinderPatternFinder), Member = "findRowSkip", ReturnType = typeof(int))]
	[Calls(Type = typeof(FinderPatternFinder), Member = "haveMultiplyConfirmedCenters", ReturnType = typeof(bool))]
	[Calls(Type = typeof(FinderPatternFinder), Member = "selectBestPatterns", ReturnType = typeof(FinderPattern[]))]
	[Calls(Type = typeof(ResultPoint), Member = "orderBestPatterns", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ResultPoint[])}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	[ContainsUnimplementedInstructions]
	internal override FinderPatternInfo find(IDictionary<DecodeHintType, Object> hints) { }

	[CalledBy(Type = typeof(FinderPatternFinder), Member = "find", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IDictionary`2<ZXing.DecodeHintType, System.Object>)}, ReturnType = typeof(FinderPatternInfo))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	private int findRowSkip() { }

	[CalledBy(Type = typeof(MultiFinderPatternFinder), Member = "findMulti", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IDictionary`2<ZXing.DecodeHintType, System.Object>)}, ReturnType = typeof(FinderPatternInfo[]))]
	[CalledBy(Type = typeof(FinderPatternFinder), Member = "find", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IDictionary`2<ZXing.DecodeHintType, System.Object>)}, ReturnType = typeof(FinderPatternInfo))]
	[CalledBy(Type = typeof(FinderPatternFinder), Member = "crossCheckDiagonal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(FinderPatternFinder), Member = "crossCheckVertical", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(System.Nullable`1<System.Single>))]
	[CalledBy(Type = typeof(FinderPatternFinder), Member = "crossCheckHorizontal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(System.Nullable`1<System.Single>))]
	[CallerCount(Count = 7)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	protected private static bool foundPatternCross(Int32[] stateCount) { }

	[CalledBy(Type = typeof(FinderPatternFinder), Member = "crossCheckDiagonal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(FinderPatternFinder), Member = "crossCheckVertical", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(System.Nullable`1<System.Single>))]
	[CalledBy(Type = typeof(FinderPatternFinder), Member = "crossCheckHorizontal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(System.Nullable`1<System.Single>))]
	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	private Int32[] get_CrossCheckStateCount() { }

	[CallerCount(Count = 106)]
	[DeduplicatedMethod]
	protected private override BitMatrix get_Image() { }

	[CallerCount(Count = 31)]
	[DeduplicatedMethod]
	protected private override List<FinderPattern> get_PossibleCenters() { }

	[CalledBy(Type = typeof(MultiFinderPatternFinder), Member = "findMulti", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IDictionary`2<ZXing.DecodeHintType, System.Object>)}, ReturnType = typeof(FinderPatternInfo[]))]
	[CalledBy(Type = typeof(FinderPatternFinder), Member = "find", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IDictionary`2<ZXing.DecodeHintType, System.Object>)}, ReturnType = typeof(FinderPatternInfo))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(FinderPatternFinder), Member = "centerFromEnd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[]), typeof(int)}, ReturnType = typeof(System.Nullable`1<System.Single>))]
	[Calls(Type = typeof(System.Nullable`1<System.Single>), Member = "get_Value", ReturnType = typeof(float))]
	[Calls(Type = typeof(FinderPatternFinder), Member = "crossCheckVertical", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(System.Nullable`1<System.Single>))]
	[Calls(Type = typeof(FinderPatternFinder), Member = "crossCheckHorizontal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(System.Nullable`1<System.Single>))]
	[Calls(Type = typeof(FinderPatternFinder), Member = "crossCheckDiagonal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(List`1), Member = "RemoveAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FinderPattern), Member = "combineEstimate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(float)}, ReturnType = typeof(FinderPattern))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Insert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ResultPoint), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	protected bool handlePossibleCenter(Int32[] stateCount, int i, int j, bool pureBarcode) { }

	[CalledBy(Type = typeof(FinderPatternFinder), Member = "find", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IDictionary`2<ZXing.DecodeHintType, System.Object>)}, ReturnType = typeof(FinderPatternInfo))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	private bool haveMultiplyConfirmedCenters() { }

	[CalledBy(Type = typeof(FinderPatternFinder), Member = "find", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IDictionary`2<ZXing.DecodeHintType, System.Object>)}, ReturnType = typeof(FinderPatternInfo))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Sort", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IComparer`1<System.Object>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Math), Member = "Max", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(List`1), Member = "RemoveAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "GetRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = "System.Collections.Generic.List`1<T>")]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallsUnknownMethods(Count = 11)]
	[ContainsUnimplementedInstructions]
	private FinderPattern[] selectBestPatterns() { }

}

