namespace ZXing.OneD.RSS;

public sealed class RSS14Reader : AbstractRSSReader
{
	private static readonly Int32[] OUTSIDE_EVEN_TOTAL_SUBSET; //Field offset: 0x0
	private static readonly Int32[] INSIDE_ODD_TOTAL_SUBSET; //Field offset: 0x8
	private static readonly Int32[] OUTSIDE_GSUM; //Field offset: 0x10
	private static readonly Int32[] INSIDE_GSUM; //Field offset: 0x18
	private static readonly Int32[] OUTSIDE_ODD_WIDEST; //Field offset: 0x20
	private static readonly Int32[] INSIDE_ODD_WIDEST; //Field offset: 0x28
	private static readonly Int32[][] FINDER_PATTERNS; //Field offset: 0x30
	private readonly List<Pair> possibleLeftPairs; //Field offset: 0x40
	private readonly List<Pair> possibleRightPairs; //Field offset: 0x48

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(RuntimeFieldHandle)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 18)]
	private static RSS14Reader() { }

	[CalledBy(Type = typeof(MultiFormatOneDReader), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IDictionary`2<ZXing.DecodeHintType, System.Object>)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(AbstractRSSReader), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public RSS14Reader() { }

	[CalledBy(Type = typeof(RSS14Reader), Member = "decodeRow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(BitArray), typeof(System.Collections.Generic.IDictionary`2<ZXing.DecodeHintType, System.Object>)}, ReturnType = typeof(Result))]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 11)]
	private static void addOrTally(IList<Pair> possiblePairs, Pair pair) { }

	[CalledBy(Type = typeof(RSS14Reader), Member = "decodeDataCharacter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitArray), typeof(FinderPattern), typeof(bool)}, ReturnType = typeof(DataCharacter))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private bool adjustOddEvenCounts(bool outsideChar, int numModules) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private static bool checkChecksum(Pair leftPair, Pair rightPair) { }

	[CalledBy(Type = typeof(RSS14Reader), Member = "decodeRow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(BitArray), typeof(System.Collections.Generic.IDictionary`2<ZXing.DecodeHintType, System.Object>)}, ReturnType = typeof(Result))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(long), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(StringBuilder), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(Result), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Byte[]), typeof(ResultPoint[]), typeof(BarcodeFormat)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 18)]
	[ContainsUnimplementedInstructions]
	private static Result constructResult(Pair leftPair, Pair rightPair) { }

	[CalledBy(Type = typeof(RSS14Reader), Member = "decodePair", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitArray), typeof(bool), typeof(int), typeof(System.Collections.Generic.IDictionary`2<ZXing.DecodeHintType, System.Object>)}, ReturnType = typeof(Pair))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(OneDReader), Member = "recordPattern", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitArray), typeof(int), typeof(Int32[])}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(OneDReader), Member = "recordPatternInReverse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitArray), typeof(int), typeof(Int32[])}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(RSS14Reader), Member = "adjustOddEvenCounts", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(RSSUtils), Member = "getRSSvalue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[]), typeof(int), typeof(bool)}, ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	private DataCharacter decodeDataCharacter(BitArray row, FinderPattern pattern, bool outsideChar) { }

	[CalledBy(Type = typeof(RSS14Reader), Member = "decodeRow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(BitArray), typeof(System.Collections.Generic.IDictionary`2<ZXing.DecodeHintType, System.Object>)}, ReturnType = typeof(Result))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(RSS14Reader), Member = "findFinderPattern", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitArray), typeof(int), typeof(bool)}, ReturnType = typeof(Int32[]))]
	[Calls(Type = typeof(RSS14Reader), Member = "parseFoundFinderPattern", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitArray), typeof(int), typeof(bool), typeof(Int32[])}, ReturnType = typeof(FinderPattern))]
	[Calls(Type = typeof(ResultPoint), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RSS14Reader), Member = "decodeDataCharacter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitArray), typeof(FinderPattern), typeof(bool)}, ReturnType = typeof(DataCharacter))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 6)]
	private Pair decodePair(BitArray row, bool right, int rowNumber, IDictionary<DecodeHintType, Object> hints) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RSS14Reader), Member = "decodePair", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitArray), typeof(bool), typeof(int), typeof(System.Collections.Generic.IDictionary`2<ZXing.DecodeHintType, System.Object>)}, ReturnType = typeof(Pair))]
	[Calls(Type = typeof(RSS14Reader), Member = "addOrTally", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IList`1<ZXing.OneD.RSS.Pair>), typeof(Pair)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BitArray), Member = "reverse", ReturnType = typeof(void))]
	[Calls(Type = typeof(RSS14Reader), Member = "constructResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Pair), typeof(Pair)}, ReturnType = typeof(Result))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public virtual Result decodeRow(int rowNumber, BitArray row, IDictionary<DecodeHintType, Object> hints) { }

	[CalledBy(Type = typeof(RSS14Reader), Member = "decodePair", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitArray), typeof(bool), typeof(int), typeof(System.Collections.Generic.IDictionary`2<ZXing.DecodeHintType, System.Object>)}, ReturnType = typeof(Pair))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BitArray), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(AbstractRSSReader), Member = "isFinderPattern", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[])}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	private Int32[] findFinderPattern(BitArray row, int rowOffset, bool rightFinderPattern) { }

	[CalledBy(Type = typeof(RSS14Reader), Member = "decodePair", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitArray), typeof(bool), typeof(int), typeof(System.Collections.Generic.IDictionary`2<ZXing.DecodeHintType, System.Object>)}, ReturnType = typeof(Pair))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BitArray), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(OneDReader), Member = "patternMatchVariance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[]), typeof(Int32[]), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(FinderPattern), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Int32[]), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	private FinderPattern parseFoundFinderPattern(BitArray row, int rowNumber, bool right, Int32[] startEnd) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public virtual void reset() { }

}

