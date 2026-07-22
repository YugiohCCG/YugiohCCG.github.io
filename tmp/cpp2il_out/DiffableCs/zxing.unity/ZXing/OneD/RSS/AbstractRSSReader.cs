namespace ZXing.OneD.RSS;

public abstract class AbstractRSSReader : OneDReader
{
	private static readonly int MAX_AVG_VARIANCE; //Field offset: 0x0
	private const float MIN_FINDER_PATTERN_RATIO = 0.7916667; //Field offset: 0x0
	private const float MAX_FINDER_PATTERN_RATIO = 0.89285713; //Field offset: 0x0
	private static readonly int MAX_INDIVIDUAL_VARIANCE; //Field offset: 0x4
	private readonly Int32[] decodeFinderCounters; //Field offset: 0x10
	private readonly Int32[] dataCharacterCounters; //Field offset: 0x18
	private readonly Single[] oddRoundingErrors; //Field offset: 0x20
	private readonly Single[] evenRoundingErrors; //Field offset: 0x28
	private readonly Int32[] oddCounts; //Field offset: 0x30
	private readonly Int32[] evenCounts; //Field offset: 0x38

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	private static AbstractRSSReader() { }

	[CalledBy(Type = typeof(RSSExpandedReader), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RSS14Reader), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	protected AbstractRSSReader() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	protected static int count(Int32[] array) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	protected static void decrement(Int32[] array, Single[] errors) { }

	[CallerCount(Count = 31)]
	[DeduplicatedMethod]
	protected Int32[] getDataCharacterCounters() { }

	[CallerCount(Count = 106)]
	[DeduplicatedMethod]
	protected Int32[] getDecodeFinderCounters() { }

	[CallerCount(Count = 38)]
	[DeduplicatedMethod]
	protected Int32[] getEvenCounts() { }

	[CallerCount(Count = 15)]
	[DeduplicatedMethod]
	protected Single[] getEvenRoundingErrors() { }

	[CallerCount(Count = 62)]
	[DeduplicatedMethod]
	protected Int32[] getOddCounts() { }

	[CallerCount(Count = 12)]
	[DeduplicatedMethod]
	protected Single[] getOddRoundingErrors() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	protected static void increment(Int32[] array, Single[] errors) { }

	[CalledBy(Type = typeof(RSSExpandedReader), Member = "findNextPair", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitArray), typeof(System.Collections.Generic.List`1<ZXing.OneD.RSS.Expanded.ExpandedPair>), typeof(int)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(RSS14Reader), Member = "findFinderPattern", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitArray), typeof(int), typeof(bool)}, ReturnType = typeof(Int32[]))]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	protected static bool isFinderPattern(Int32[] counters) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(OneDReader), Member = "patternMatchVariance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[]), typeof(Int32[]), typeof(int)}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 2)]
	protected static bool parseFinderValue(Int32[] counters, Int32[][] finderPatterns, out int value) { }

}

