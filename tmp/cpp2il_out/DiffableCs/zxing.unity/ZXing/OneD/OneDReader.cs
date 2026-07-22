namespace ZXing.OneD;

public abstract class OneDReader : Reader
{
	protected static int INTEGER_MATH_SHIFT; //Field offset: 0x0
	protected static int PATTERN_MATCH_RESULT_SCALE_FACTOR; //Field offset: 0x4

	[CallerCount(Count = 0)]
	private static OneDReader() { }

	[CallerCount(Count = 2180)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	protected OneDReader() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public override Result decode(BinaryBitmap image) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(OneDReader), Member = "doDecode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryBitmap), typeof(System.Collections.Generic.IDictionary`2<ZXing.DecodeHintType, System.Object>)}, ReturnType = typeof(Result))]
	[Calls(Type = typeof(BinaryBitmap), Member = "get_RotateSupported", ReturnType = typeof(bool))]
	[Calls(Type = typeof(BinaryBitmap), Member = "rotateCounterClockwise", ReturnType = typeof(BinaryBitmap))]
	[Calls(Type = typeof(Result), Member = "putMetadata", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ResultMetadataType), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BinaryBitmap), Member = "get_Height", ReturnType = typeof(int))]
	[Calls(Type = typeof(ResultPoint), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 11)]
	[ContainsUnimplementedInstructions]
	public override Result decode(BinaryBitmap image, IDictionary<DecodeHintType, Object> hints) { }

	public abstract Result decodeRow(int rowNumber, BitArray row, IDictionary<DecodeHintType, Object> hints) { }

	[CalledBy(Type = typeof(OneDReader), Member = "decode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryBitmap), typeof(System.Collections.Generic.IDictionary`2<ZXing.DecodeHintType, System.Object>)}, ReturnType = typeof(Result))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(BinaryBitmap), Member = "get_Width", ReturnType = typeof(int))]
	[Calls(Type = typeof(BinaryBitmap), Member = "get_Height", ReturnType = typeof(int))]
	[Calls(Type = typeof(BitArray), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Math), Member = "Max", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(BitArray), Member = "reverse", ReturnType = typeof(void))]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(Result), Member = "putMetadata", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ResultMetadataType), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ResultPoint), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 23)]
	private Result doDecode(BinaryBitmap image, IDictionary<DecodeHintType, Object> hints) { }

	[CalledBy(Type = typeof(Code128Reader), Member = "findStartPattern", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitArray)}, ReturnType = typeof(Int32[]))]
	[CalledBy(Type = typeof(Code128Reader), Member = "decodeCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitArray), typeof(Int32[]), typeof(int), typeof(Int32&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Code128Reader), Member = "decodeRow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(BitArray), typeof(System.Collections.Generic.IDictionary`2<ZXing.DecodeHintType, System.Object>)}, ReturnType = typeof(Result))]
	[CalledBy(Type = typeof(ITFReader), Member = "findGuardPattern", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitArray), typeof(int), typeof(Int32[])}, ReturnType = typeof(Int32[]))]
	[CalledBy(Type = typeof(ITFReader), Member = "decodeDigit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[]), typeof(Int32&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(AbstractRSSReader), Member = "parseFinderValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[]), typeof(Int32[][]), typeof(Int32&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(RSSExpandedReader), Member = "parseFoundFinderPattern", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitArray), typeof(int), typeof(bool)}, ReturnType = typeof(FinderPattern))]
	[CalledBy(Type = typeof(RSS14Reader), Member = "parseFoundFinderPattern", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitArray), typeof(int), typeof(bool), typeof(Int32[])}, ReturnType = typeof(FinderPattern))]
	[CalledBy(Type = typeof(UPCEANReader), Member = "findStartGuardPattern", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitArray)}, ReturnType = typeof(Int32[]))]
	[CalledBy(Type = typeof(UPCEANReader), Member = "findGuardPattern", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitArray), typeof(int), typeof(bool), typeof(Int32[]), typeof(Int32[])}, ReturnType = typeof(Int32[]))]
	[CalledBy(Type = typeof(UPCEReader), Member = "decodeEnd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitArray), typeof(int)}, ReturnType = typeof(Int32[]))]
	[CallerCount(Count = 11)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	protected static int patternMatchVariance(Int32[] counters, Int32[] pattern, int maxIndividualVariance) { }

	[CalledBy(Type = typeof(Code128Reader), Member = "decodeCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitArray), typeof(Int32[]), typeof(int), typeof(Int32&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Code128Reader), Member = "decodeRow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(BitArray), typeof(System.Collections.Generic.IDictionary`2<ZXing.DecodeHintType, System.Object>)}, ReturnType = typeof(Result))]
	[CalledBy(Type = typeof(Code39Reader), Member = "decodeRow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(BitArray), typeof(System.Collections.Generic.IDictionary`2<ZXing.DecodeHintType, System.Object>)}, ReturnType = typeof(Result))]
	[CalledBy(Type = typeof(Code93Reader), Member = "decodeRow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(BitArray), typeof(System.Collections.Generic.IDictionary`2<ZXing.DecodeHintType, System.Object>)}, ReturnType = typeof(Result))]
	[CalledBy(Type = typeof(ITFReader), Member = "decodeMiddle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitArray), typeof(int), typeof(int), typeof(StringBuilder)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(OneDReader), Member = "recordPatternInReverse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitArray), typeof(int), typeof(Int32[])}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(RSSExpandedReader), Member = "decodeDataCharacter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitArray), typeof(FinderPattern), typeof(bool), typeof(bool)}, ReturnType = typeof(DataCharacter))]
	[CalledBy(Type = typeof(RSS14Reader), Member = "decodeDataCharacter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitArray), typeof(FinderPattern), typeof(bool)}, ReturnType = typeof(DataCharacter))]
	[CalledBy(Type = typeof(UPCEANReader), Member = "decodeDigit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitArray), typeof(Int32[]), typeof(int), typeof(Int32[][]), typeof(Int32&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(BitArray), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	protected static bool recordPattern(BitArray row, int start, Int32[] counters) { }

	[CalledBy(Type = typeof(MSIReader), Member = "decodeRow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(BitArray), typeof(System.Collections.Generic.IDictionary`2<ZXing.DecodeHintType, System.Object>)}, ReturnType = typeof(Result))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BitArray), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	protected static bool recordPattern(BitArray row, int start, Int32[] counters, int numCounters) { }

	[CalledBy(Type = typeof(RSSExpandedReader), Member = "decodeDataCharacter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitArray), typeof(FinderPattern), typeof(bool), typeof(bool)}, ReturnType = typeof(DataCharacter))]
	[CalledBy(Type = typeof(RSS14Reader), Member = "decodeDataCharacter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitArray), typeof(FinderPattern), typeof(bool)}, ReturnType = typeof(DataCharacter))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(BitArray), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(OneDReader), Member = "recordPattern", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitArray), typeof(int), typeof(Int32[])}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	protected static bool recordPatternInReverse(BitArray row, int start, Int32[] counters) { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	public override void reset() { }

}

