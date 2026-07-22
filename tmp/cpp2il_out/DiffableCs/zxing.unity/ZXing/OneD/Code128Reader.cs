namespace ZXing.OneD;

public sealed class Code128Reader : OneDReader
{
	internal static Int32[][] CODE_PATTERNS; //Field offset: 0x0
	private const int CODE_SHIFT = 98; //Field offset: 0x0
	private const int CODE_CODE_C = 99; //Field offset: 0x0
	private const int CODE_CODE_B = 100; //Field offset: 0x0
	private const int CODE_CODE_A = 101; //Field offset: 0x0
	private const int CODE_FNC_1 = 102; //Field offset: 0x0
	private const int CODE_FNC_2 = 97; //Field offset: 0x0
	private const int CODE_FNC_3 = 96; //Field offset: 0x0
	private const int CODE_FNC_4_A = 101; //Field offset: 0x0
	private const int CODE_FNC_4_B = 100; //Field offset: 0x0
	private const int CODE_START_A = 103; //Field offset: 0x0
	private const int CODE_START_B = 104; //Field offset: 0x0
	private const int CODE_START_C = 105; //Field offset: 0x0
	private const int CODE_STOP = 106; //Field offset: 0x0
	private static readonly int MAX_AVG_VARIANCE; //Field offset: 0x8
	private static readonly int MAX_INDIVIDUAL_VARIANCE; //Field offset: 0xC

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(RuntimeFieldHandle)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 111)]
	[ContainsUnimplementedInstructions]
	private static Code128Reader() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public Code128Reader() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(OneDReader), Member = "recordPattern", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitArray), typeof(int), typeof(Int32[])}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(OneDReader), Member = "patternMatchVariance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[]), typeof(Int32[]), typeof(int)}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 2)]
	private static bool decodeCode(BitArray row, Int32[] counters, int rowOffset, out int code) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(ResultPoint), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StringBuilder), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(BitArray), Member = "isRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Math), Member = "Min", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(BitArray), Member = "getNextUnset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(OneDReader), Member = "patternMatchVariance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[]), typeof(Int32[]), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(OneDReader), Member = "recordPattern", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitArray), typeof(int), typeof(Int32[])}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Code128Reader), Member = "findStartPattern", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitArray)}, ReturnType = typeof(Int32[]))]
	[Calls(Type = typeof(List`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[Calls(Type = typeof(Result), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Byte[]), typeof(ResultPoint[]), typeof(BarcodeFormat)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 18)]
	[ContainsUnimplementedInstructions]
	public virtual Result decodeRow(int rowNumber, BitArray row, IDictionary<DecodeHintType, Object> hints) { }

	[CalledBy(Type = typeof(Code128Reader), Member = "decodeRow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(BitArray), typeof(System.Collections.Generic.IDictionary`2<ZXing.DecodeHintType, System.Object>)}, ReturnType = typeof(Result))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BitArray), Member = "getNextSet", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(BitArray), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(OneDReader), Member = "patternMatchVariance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[]), typeof(Int32[]), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Math), Member = "Max", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(BitArray), Member = "isRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	private static Int32[] findStartPattern(BitArray row) { }

}

