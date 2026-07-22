namespace ZXing.OneD.RSS.Expanded;

public sealed class RSSExpandedReader : AbstractRSSReader
{
	private static readonly Int32[] SYMBOL_WIDEST; //Field offset: 0x0
	private const int MAX_PAIRS = 11; //Field offset: 0x0
	private const int FINDER_PAT_F = 5; //Field offset: 0x0
	private const int FINDER_PAT_E = 4; //Field offset: 0x0
	private const int FINDER_PAT_C = 2; //Field offset: 0x0
	private const int FINDER_PAT_B = 1; //Field offset: 0x0
	private const int FINDER_PAT_D = 3; //Field offset: 0x0
	private const int FINDER_PAT_A = 0; //Field offset: 0x0
	private static readonly Int32[] EVEN_TOTAL_SUBSET; //Field offset: 0x8
	private static readonly Int32[] GSUM; //Field offset: 0x10
	private static readonly Int32[][] FINDER_PATTERNS; //Field offset: 0x18
	private static readonly Int32[][] WEIGHTS; //Field offset: 0x20
	private static readonly Int32[][] FINDER_PATTERN_SEQUENCES; //Field offset: 0x28
	private readonly List<ExpandedPair> pairs; //Field offset: 0x40
	private readonly List<ExpandedRow> rows; //Field offset: 0x48
	private readonly Int32[] startEnd; //Field offset: 0x50
	private bool startFromEven; //Field offset: 0x58

	internal List<ExpandedPair> Pairs
	{
		[CallerCount(Count = 12)]
		[DeduplicatedMethod]
		internal get { } //Length: 5
	}

	internal List<ExpandedRow> Rows
	{
		[CallerCount(Count = 10)]
		[DeduplicatedMethod]
		internal get { } //Length: 254
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(RuntimeFieldHandle)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 47)]
	private static RSSExpandedReader() { }

	[CalledBy(Type = typeof(MultiFormatOneDReader), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IDictionary`2<ZXing.DecodeHintType, System.Object>)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(List`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AbstractRSSReader), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public RSSExpandedReader() { }

	[CalledBy(Type = typeof(RSSExpandedReader), Member = "decodeDataCharacter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitArray), typeof(FinderPattern), typeof(bool), typeof(bool)}, ReturnType = typeof(DataCharacter))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private bool adjustOddEvenCounts(int numModules) { }

	[CalledBy(Type = typeof(RSSExpandedReader), Member = "decodeRow2pairs", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(BitArray)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(RSSExpandedReader), Member = "checkRows", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<ZXing.OneD.RSS.Expanded.ExpandedRow>), typeof(int)}, ReturnType = typeof(System.Collections.Generic.List`1<ZXing.OneD.RSS.Expanded.ExpandedPair>))]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private bool checkChecksum() { }

	[CalledBy(Type = typeof(RSSExpandedReader), Member = "decodeRow2pairs", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(BitArray)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Reverse", ReturnType = typeof(void))]
	[Calls(Type = typeof(RSSExpandedReader), Member = "checkRows", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<ZXing.OneD.RSS.Expanded.ExpandedRow>), typeof(int)}, ReturnType = typeof(System.Collections.Generic.List`1<ZXing.OneD.RSS.Expanded.ExpandedPair>))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private List<ExpandedPair> checkRows(bool reverse) { }

	[CalledBy(Type = typeof(RSSExpandedReader), Member = "checkRows", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(System.Collections.Generic.List`1<ZXing.OneD.RSS.Expanded.ExpandedPair>))]
	[CalledBy(Type = typeof(RSSExpandedReader), Member = "checkRows", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<ZXing.OneD.RSS.Expanded.ExpandedRow>), typeof(int)}, ReturnType = typeof(System.Collections.Generic.List`1<ZXing.OneD.RSS.Expanded.ExpandedPair>))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RSSExpandedReader), Member = "isValidSequence", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<ZXing.OneD.RSS.Expanded.ExpandedPair>)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(RSSExpandedReader), Member = "checkChecksum", ReturnType = typeof(bool))]
	[Calls(Type = typeof(RSSExpandedReader), Member = "checkRows", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<ZXing.OneD.RSS.Expanded.ExpandedRow>), typeof(int)}, ReturnType = typeof(System.Collections.Generic.List`1<ZXing.OneD.RSS.Expanded.ExpandedPair>))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	private List<ExpandedPair> checkRows(List<ExpandedRow> collectedRows, int currentRow) { }

	[CalledBy(Type = typeof(RSSExpandedReader), Member = "decodeRow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(BitArray), typeof(System.Collections.Generic.IDictionary`2<ZXing.DecodeHintType, System.Object>)}, ReturnType = typeof(Result))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BitArrayBuilder), Member = "buildBitArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<ZXing.OneD.RSS.Expanded.ExpandedPair>)}, ReturnType = typeof(BitArray))]
	[Calls(Type = typeof(AbstractExpandedDecoder), Member = "createDecoder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitArray)}, ReturnType = typeof(AbstractExpandedDecoder))]
	[Calls(Type = typeof(Result), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Byte[]), typeof(ResultPoint[]), typeof(BarcodeFormat)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 18)]
	internal static Result constructResult(List<ExpandedPair> pairs) { }

	[CalledBy(Type = typeof(RSSExpandedReader), Member = "retrieveNextPair", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitArray), typeof(System.Collections.Generic.List`1<ZXing.OneD.RSS.Expanded.ExpandedPair>), typeof(int)}, ReturnType = typeof(ExpandedPair))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(OneDReader), Member = "recordPattern", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitArray), typeof(int), typeof(Int32[])}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(OneDReader), Member = "recordPatternInReverse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitArray), typeof(int), typeof(Int32[])}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(RSSExpandedReader), Member = "adjustOddEvenCounts", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(RSSUtils), Member = "getRSSvalue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[]), typeof(int), typeof(bool)}, ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	internal DataCharacter decodeDataCharacter(BitArray row, FinderPattern pattern, bool isOddPattern, bool leftChar) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RSSExpandedReader), Member = "decodeRow2pairs", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(BitArray)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(RSSExpandedReader), Member = "constructResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<ZXing.OneD.RSS.Expanded.ExpandedPair>)}, ReturnType = typeof(Result))]
	[CallsUnknownMethods(Count = 1)]
	public virtual Result decodeRow(int rowNumber, BitArray row, IDictionary<DecodeHintType, Object> hints) { }

	[CalledBy(Type = typeof(RSSExpandedReader), Member = "decodeRow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(BitArray), typeof(System.Collections.Generic.IDictionary`2<ZXing.DecodeHintType, System.Object>)}, ReturnType = typeof(Result))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(RSSExpandedReader), Member = "retrieveNextPair", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitArray), typeof(System.Collections.Generic.List`1<ZXing.OneD.RSS.Expanded.ExpandedPair>), typeof(int)}, ReturnType = typeof(ExpandedPair))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RSSExpandedReader), Member = "checkChecksum", ReturnType = typeof(bool))]
	[Calls(Type = typeof(RSSExpandedReader), Member = "storeRow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RSSExpandedReader), Member = "checkRows", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(System.Collections.Generic.List`1<ZXing.OneD.RSS.Expanded.ExpandedPair>))]
	[CallsUnknownMethods(Count = 3)]
	internal bool decodeRow2pairs(int rowNumber, BitArray row) { }

	[CalledBy(Type = typeof(RSSExpandedReader), Member = "retrieveNextPair", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitArray), typeof(System.Collections.Generic.List`1<ZXing.OneD.RSS.Expanded.ExpandedPair>), typeof(int)}, ReturnType = typeof(ExpandedPair))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BitArray), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(RSSExpandedReader), Member = "reverseCounters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AbstractRSSReader), Member = "isFinderPattern", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[])}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	private bool findNextPair(BitArray row, List<ExpandedPair> previousPairs, int forcedOffset) { }

	[CallerCount(Count = 12)]
	[DeduplicatedMethod]
	internal List<ExpandedPair> get_Pairs() { }

	[CallerCount(Count = 10)]
	[DeduplicatedMethod]
	internal List<ExpandedRow> get_Rows() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BitArray), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BitArray), Member = "getNextSet", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(BitArray), Member = "getNextUnset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 1)]
	private static int getNextSecondBar(BitArray row, int initialPos) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private static bool isNotA1left(FinderPattern pattern, bool isOddPattern, bool leftChar) { }

	[CalledBy(Type = typeof(RSSExpandedReader), Member = "storeRow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 23)]
	private static bool isPartialRow(IEnumerable<ExpandedPair> pairs, IEnumerable<ExpandedRow> rows) { }

	[CalledBy(Type = typeof(RSSExpandedReader), Member = "checkRows", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<ZXing.OneD.RSS.Expanded.ExpandedRow>), typeof(int)}, ReturnType = typeof(System.Collections.Generic.List`1<ZXing.OneD.RSS.Expanded.ExpandedPair>))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private static bool isValidSequence(List<ExpandedPair> pairs) { }

	[CalledBy(Type = typeof(RSSExpandedReader), Member = "retrieveNextPair", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitArray), typeof(System.Collections.Generic.List`1<ZXing.OneD.RSS.Expanded.ExpandedPair>), typeof(int)}, ReturnType = typeof(ExpandedPair))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BitArray), Member = "getNextUnset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(BitArray), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(OneDReader), Member = "patternMatchVariance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[]), typeof(Int32[]), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(FinderPattern), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Int32[]), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	private FinderPattern parseFoundFinderPattern(BitArray row, int rowNumber, bool oddPattern) { }

	[CalledBy(Type = typeof(RSSExpandedReader), Member = "storeRow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(List`1), Member = "RemoveAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 4)]
	private static void removePartialRows(List<ExpandedPair> pairs, List<ExpandedRow> rows) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public virtual void reset() { }

	[CalledBy(Type = typeof(RSSExpandedReader), Member = "decodeRow2pairs", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(BitArray)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(RSSExpandedReader), Member = "findNextPair", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitArray), typeof(System.Collections.Generic.List`1<ZXing.OneD.RSS.Expanded.ExpandedPair>), typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(RSSExpandedReader), Member = "parseFoundFinderPattern", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitArray), typeof(int), typeof(bool)}, ReturnType = typeof(FinderPattern))]
	[Calls(Type = typeof(BitArray), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BitArray), Member = "getNextSet", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(BitArray), Member = "getNextUnset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(RSSExpandedReader), Member = "decodeDataCharacter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitArray), typeof(FinderPattern), typeof(bool), typeof(bool)}, ReturnType = typeof(DataCharacter))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	internal ExpandedPair retrieveNextPair(BitArray row, List<ExpandedPair> previousPairs, int rowNumber) { }

	[CalledBy(Type = typeof(RSSExpandedReader), Member = "findNextPair", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitArray), typeof(System.Collections.Generic.List`1<ZXing.OneD.RSS.Expanded.ExpandedPair>), typeof(int)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	private static void reverseCounters(Int32[] counters) { }

	[CalledBy(Type = typeof(RSSExpandedReader), Member = "decodeRow2pairs", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(BitArray)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(RSSExpandedReader), Member = "isPartialRow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<ZXing.OneD.RSS.Expanded.ExpandedPair>), typeof(System.Collections.Generic.IEnumerable`1<ZXing.OneD.RSS.Expanded.ExpandedRow>)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Insert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RSSExpandedReader), Member = "removePartialRows", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<ZXing.OneD.RSS.Expanded.ExpandedPair>), typeof(System.Collections.Generic.List`1<ZXing.OneD.RSS.Expanded.ExpandedRow>)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 2)]
	private void storeRow(int rowNumber, bool wasReversed) { }

}

