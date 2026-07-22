namespace ZXing.OneD;

public sealed class ITFReader : OneDReader
{
	private static readonly int MAX_AVG_VARIANCE; //Field offset: 0x0
	private const int W = 3; //Field offset: 0x0
	private const int N = 1; //Field offset: 0x0
	private const int LARGEST_DEFAULT_ALLOWED_LENGTH = 14; //Field offset: 0x0
	private static readonly int MAX_INDIVIDUAL_VARIANCE; //Field offset: 0x4
	private static readonly Int32[] DEFAULT_ALLOWED_LENGTHS; //Field offset: 0x8
	private static readonly Int32[] START_PATTERN; //Field offset: 0x10
	private static readonly Int32[] END_PATTERN_REVERSED; //Field offset: 0x18
	internal static Int32[][] PATTERNS; //Field offset: 0x20
	private int narrowLineWidth; //Field offset: 0x10

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(RuntimeFieldHandle)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 16)]
	[ContainsUnimplementedInstructions]
	private static ITFReader() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public ITFReader() { }

	[CalledBy(Type = typeof(ITFReader), Member = "decodeMiddle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitArray), typeof(int), typeof(int), typeof(StringBuilder)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(OneDReader), Member = "patternMatchVariance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[]), typeof(Int32[]), typeof(int)}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 2)]
	private static bool decodeDigit(Int32[] counters, out int bestMatch) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BitArray), Member = "reverse", ReturnType = typeof(void))]
	[Calls(Type = typeof(BitArray), Member = "getNextSet", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ITFReader), Member = "findGuardPattern", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitArray), typeof(int), typeof(Int32[])}, ReturnType = typeof(Int32[]))]
	[Calls(Type = typeof(BitArray), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 2)]
	private Int32[] decodeEnd(BitArray row) { }

	[CalledBy(Type = typeof(ITFReader), Member = "decodeRow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(BitArray), typeof(System.Collections.Generic.IDictionary`2<ZXing.DecodeHintType, System.Object>)}, ReturnType = typeof(Result))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(OneDReader), Member = "recordPattern", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitArray), typeof(int), typeof(Int32[])}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ITFReader), Member = "decodeDigit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[]), typeof(Int32&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(StringBuilder))]
	[CallsUnknownMethods(Count = 2)]
	private static bool decodeMiddle(BitArray row, int payloadStart, int payloadEnd, StringBuilder resultString) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BitArray), Member = "getNextSet", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ITFReader), Member = "findGuardPattern", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitArray), typeof(int), typeof(Int32[])}, ReturnType = typeof(Int32[]))]
	[Calls(Type = typeof(BitArray), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BitArray), Member = "reverse", ReturnType = typeof(void))]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ITFReader), Member = "decodeMiddle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitArray), typeof(int), typeof(int), typeof(StringBuilder)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ResultPoint), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Result), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Byte[]), typeof(ResultPoint[]), typeof(BarcodeFormat)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 17)]
	public virtual Result decodeRow(int rowNumber, BitArray row, IDictionary<DecodeHintType, Object> hints) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BitArray), Member = "getNextSet", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ITFReader), Member = "findGuardPattern", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitArray), typeof(int), typeof(Int32[])}, ReturnType = typeof(Int32[]))]
	[Calls(Type = typeof(BitArray), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 2)]
	private Int32[] decodeStart(BitArray row) { }

	[CalledBy(Type = typeof(ITFReader), Member = "decodeRow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(BitArray), typeof(System.Collections.Generic.IDictionary`2<ZXing.DecodeHintType, System.Object>)}, ReturnType = typeof(Result))]
	[CalledBy(Type = typeof(ITFReader), Member = "decodeStart", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitArray)}, ReturnType = typeof(Int32[]))]
	[CalledBy(Type = typeof(ITFReader), Member = "decodeEnd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitArray)}, ReturnType = typeof(Int32[]))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(BitArray), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(OneDReader), Member = "patternMatchVariance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[]), typeof(Int32[]), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	private static Int32[] findGuardPattern(BitArray row, int rowOffset, Int32[] pattern) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BitArray), Member = "getNextSet", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 1)]
	private static int skipWhiteSpace(BitArray row) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BitArray), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private bool validateQuietZone(BitArray row, int startPattern) { }

}

