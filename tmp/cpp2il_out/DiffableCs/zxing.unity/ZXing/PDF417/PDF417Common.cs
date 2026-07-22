namespace ZXing.PDF417;

internal static class PDF417Common
{
	public static readonly int INVALID_CODEWORD; //Field offset: 0x0
	public static readonly int NUMBER_OF_CODEWORDS; //Field offset: 0x4
	public static readonly int MAX_CODEWORDS_IN_BARCODE; //Field offset: 0x8
	public static readonly int MIN_ROWS_IN_BARCODE; //Field offset: 0xC
	public static readonly int MAX_ROWS_IN_BARCODE; //Field offset: 0x10
	public static readonly int MODULES_IN_CODEWORD; //Field offset: 0x14
	public static readonly int MODULES_IN_STOP_PATTERN; //Field offset: 0x18
	public static readonly int BARS_IN_MODULE; //Field offset: 0x1C
	private static readonly Int32[] EMPTY_INT_ARRAY; //Field offset: 0x20
	public static readonly Int32[] SYMBOL_TABLE; //Field offset: 0x28
	private static readonly Int32[] CODEWORD_TABLE; //Field offset: 0x30

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(RuntimeFieldHandle)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	private static PDF417Common() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static int findCodewordIndex(long symbol) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public static int getBitCountSum(Int32[] moduleBitCount) { }

	[CalledBy(Type = typeof(PDF417CodewordDecoder), Member = "getDecodedValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[])}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(PDF417CodewordDecoder), Member = "getDecodedCodewordValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[])}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(PDF417ScanningDecoder), Member = "detectCodeword", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitMatrix), typeof(int), typeof(int), typeof(bool), typeof(int), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(Codeword))]
	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	public static int getCodeword(long symbol) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 12)]
	public static Int32[] toIntArray(ICollection<Int32> list) { }

}

