namespace ZXing.OneD;

public sealed class CodaBarReader : OneDReader
{
	private static readonly int MAX_ACCEPTABLE; //Field offset: 0x0
	private const string ALPHABET_STRING = "0123456789-$:/.+ABCD"; //Field offset: 0x0
	private const int MIN_CHARACTER_LENGTH = 3; //Field offset: 0x0
	private static readonly int PADDING; //Field offset: 0x4
	internal static readonly Char[] ALPHABET; //Field offset: 0x8
	internal static Int32[] CHARACTER_ENCODINGS; //Field offset: 0x10
	private static readonly Char[] STARTEND_ENCODING; //Field offset: 0x18
	private readonly StringBuilder decodeRowResult; //Field offset: 0x10
	private Int32[] counters; //Field offset: 0x18
	private int counterLength; //Field offset: 0x20

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "ToCharArray", ReturnType = typeof(Char[]))]
	[Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(RuntimeFieldHandle)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	[ContainsUnimplementedInstructions]
	private static CodaBarReader() { }

	[CalledBy(Type = typeof(MultiFormatOneDReader), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IDictionary`2<ZXing.DecodeHintType, System.Object>)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public CodaBarReader() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	internal static bool arrayContains(Char[] array, char key) { }

	[CalledBy(Type = typeof(CodaBarReader), Member = "decodeRow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(BitArray), typeof(System.Collections.Generic.IDictionary`2<ZXing.DecodeHintType, System.Object>)}, ReturnType = typeof(Result))]
	[CalledBy(Type = typeof(CodaBarReader), Member = "setCounters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitArray)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	private void counterAppend(int e) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CodaBarReader), Member = "validatePattern", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(SupportClass), Member = "GetValue", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IDictionary`2<ZXing.DecodeHintType, System.Object>), typeof(DecodeHintType), typeof(object)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(StringBuilder), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(SupportClass), Member = "GetValue", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IDictionary`2<ZXing.DecodeHintType, System.Object>), typeof(DecodeHintType), "T"}, ReturnType = "T")]
	[Calls(Type = typeof(StringBuilder), Member = "set_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(char)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StringBuilder), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(ResultPoint), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(CodaBarReader), Member = "toNarrowWidePattern", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CodaBarReader), Member = "counterAppend", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BitArray), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BitArray), Member = "getNextUnset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(StringBuilder), Member = "set_Length", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Result), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Byte[]), typeof(ResultPoint[]), typeof(BarcodeFormat)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 11)]
	[ContainsUnimplementedInstructions]
	public virtual Result decodeRow(int rowNumber, BitArray row, IDictionary<DecodeHintType, Object> hints) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CodaBarReader), Member = "toNarrowWidePattern", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 2)]
	private int findStartPattern() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BitArray), Member = "getNextUnset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(BitArray), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CodaBarReader), Member = "counterAppend", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	private bool setCounters(BitArray row) { }

	[CalledBy(Type = typeof(CodaBarReader), Member = "decodeRow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(BitArray), typeof(System.Collections.Generic.IDictionary`2<ZXing.DecodeHintType, System.Object>)}, ReturnType = typeof(Result))]
	[CalledBy(Type = typeof(CodaBarReader), Member = "findStartPattern", ReturnType = typeof(int))]
	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	private int toNarrowWidePattern(int position) { }

	[CalledBy(Type = typeof(CodaBarReader), Member = "decodeRow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(BitArray), typeof(System.Collections.Generic.IDictionary`2<ZXing.DecodeHintType, System.Object>)}, ReturnType = typeof(Result))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(StringBuilder), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	private bool validatePattern(int start) { }

}

