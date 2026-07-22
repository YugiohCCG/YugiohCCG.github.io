namespace ZXing.Aztec.Internal;

public static class Encoder
{
	public const int DEFAULT_EC_PERCENT = 33; //Field offset: 0x0
	public const int DEFAULT_AZTEC_LAYERS = 0; //Field offset: 0x0
	private const int MAX_NB_BITS = 32; //Field offset: 0x0
	private const int MAX_NB_BITS_COMPACT = 4; //Field offset: 0x0
	private static readonly Int32[] WORD_SIZE; //Field offset: 0x0

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(RuntimeFieldHandle)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private static Encoder() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BitArray), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	private static Int32[] bitsToWords(BitArray stuffedBits, int wordSize, int totalWords) { }

	[CalledBy(Type = typeof(Encoder), Member = "encode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(AztecCode))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(BitMatrix), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private static void drawBullsEye(BitMatrix matrix, int center, int size) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BitArray), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BitMatrix), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private static void drawModeMessage(BitMatrix matrix, bool compact, int matrixSize, BitArray modeMessage) { }

	[CallerCount(Count = 0)]
	[ContainsInvalidInstructions]
	public static AztecCode encode(Byte[] data) { }

	[CalledBy(Type = typeof(AztecWriter), Member = "encode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(BarcodeFormat), typeof(int), typeof(int), typeof(System.Collections.Generic.IDictionary`2<ZXing.EncodeHintType, System.Object>)}, ReturnType = typeof(BitMatrix))]
	[CalledBy(Type = typeof(AztecWriter), Member = "encode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(BarcodeFormat), typeof(int), typeof(int), typeof(Encoding), typeof(int), typeof(int)}, ReturnType = typeof(BitMatrix))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(BitArray), Member = "appendBits", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(HighLevelEncoder), Member = "encode", ReturnType = typeof(BitArray))]
	[Calls(Type = typeof(Encoder), Member = "stuffBits", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitArray), typeof(int)}, ReturnType = typeof(BitArray))]
	[Calls(Type = typeof(Encoder), Member = "generateCheckWords", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitArray), typeof(int), typeof(int)}, ReturnType = typeof(BitArray))]
	[Calls(Type = typeof(BitArray), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(BitMatrix), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BitArray), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BitMatrix), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Encoder), Member = "drawBullsEye", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitMatrix), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 20)]
	[ContainsUnimplementedInstructions]
	public static AztecCode encode(Byte[] data, int minECCPercent, int userSpecifiedLayers) { }

	[CalledBy(Type = typeof(Encoder), Member = "encode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(AztecCode))]
	[CalledBy(Type = typeof(Encoder), Member = "generateModeMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(int), typeof(int)}, ReturnType = typeof(BitArray))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(ReedSolomonEncoder), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GenericGF)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BitArray), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ReedSolomonEncoder), Member = "encode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[]), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BitArray), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(BitArray), Member = "appendBits", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 7)]
	[ContainsUnimplementedInstructions]
	private static BitArray generateCheckWords(BitArray bitArray, int totalBits, int wordSize) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BitArray), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(BitArray), Member = "appendBits", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Encoder), Member = "generateCheckWords", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitArray), typeof(int), typeof(int)}, ReturnType = typeof(BitArray))]
	[CallsUnknownMethods(Count = 1)]
	internal static BitArray generateModeMessage(bool compact, int layers, int messageSizeInWords) { }

	[CallerCount(Count = 0)]
	[ContainsInvalidInstructions]
	private static GenericGF getGF(int wordSize) { }

	[CalledBy(Type = typeof(Encoder), Member = "encode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(AztecCode))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(BitArray), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(BitArray), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BitArray), Member = "appendBits", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	internal static BitArray stuffBits(BitArray bits, int wordSize) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	private static int TotalBitsInLayer(int layers, bool compact) { }

}

