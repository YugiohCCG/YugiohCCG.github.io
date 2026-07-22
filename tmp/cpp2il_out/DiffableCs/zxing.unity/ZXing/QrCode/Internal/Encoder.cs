namespace ZXing.QrCode.Internal;

public static class Encoder
{
	private static readonly Int32[] ALPHANUMERIC_TABLE; //Field offset: 0x0
	internal static string DEFAULT_BYTE_MODE_ENCODING; //Field offset: 0x8

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(RuntimeFieldHandle)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	private static Encoder() { }

	[CalledBy(Type = typeof(Encoder), Member = "appendBytes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Mode), typeof(BitArray), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Encoding), Member = "GetEncoding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Encoding))]
	[Calls(Type = typeof(BitArray), Member = "appendBits", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(WriterException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Exception)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 9)]
	internal static void append8BitBytes(string content, BitArray bits, string encoding) { }

	[CalledBy(Type = typeof(Encoder), Member = "appendBytes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Mode), typeof(BitArray), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(Encoder), Member = "getAlphanumericCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(BitArray), Member = "appendBits", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(WriterException), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 7)]
	internal static void appendAlphanumericBytes(string content, BitArray bits) { }

	[CalledBy(Type = typeof(Encoder), Member = "encode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(ErrorCorrectionLevel), typeof(System.Collections.Generic.IDictionary`2<ZXing.EncodeHintType, System.Object>)}, ReturnType = typeof(QRCode))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Encoder), Member = "appendKanjiBytes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(BitArray)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Encoder), Member = "append8BitBytes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(BitArray), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Encoder), Member = "appendAlphanumericBytes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(BitArray)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(BitArray), Member = "appendBits", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(WriterException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 5)]
	internal static void appendBytes(string content, Mode mode, BitArray bits, string encoding) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BitArray), Member = "appendBits", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private static void appendECI(CharacterSetECI eci, BitArray bits) { }

	[CalledBy(Type = typeof(Encoder), Member = "appendBytes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Mode), typeof(BitArray), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Encoding), Member = "GetEncoding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Encoding))]
	[Calls(Type = typeof(BitArray), Member = "appendBits", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(WriterException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Exception)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(WriterException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 13)]
	internal static void appendKanjiBytes(string content, BitArray bits) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Mode), Member = "getCharacterCountBits", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Version)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(BitArray), Member = "appendBits", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(WriterException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 6)]
	internal static void appendLengthInfo(int numLetters, Version version, Mode mode, BitArray bits) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BitArray), Member = "appendBits", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	internal static void appendModeInfo(Mode mode, BitArray bits) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(BitArray), Member = "appendBits", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	internal static void appendNumericBytes(string content, BitArray bits) { }

	[CalledBy(Type = typeof(Encoder), Member = "encode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(ErrorCorrectionLevel), typeof(System.Collections.Generic.IDictionary`2<ZXing.EncodeHintType, System.Object>)}, ReturnType = typeof(QRCode))]
	[CalledBy(Type = typeof(Encoder), Member = "chooseMaskPattern", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitArray), typeof(ErrorCorrectionLevel), typeof(Version), typeof(ByteMatrix)}, ReturnType = typeof(int))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(MaskUtil), Member = "applyMaskPenaltyRule1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ByteMatrix)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(MaskUtil), Member = "applyMaskPenaltyRule3", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ByteMatrix)}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	private static int calculateMaskPenalty(ByteMatrix matrix) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MatrixUtil), Member = "buildMatrix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitArray), typeof(ErrorCorrectionLevel), typeof(Version), typeof(int), typeof(ByteMatrix)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Encoder), Member = "calculateMaskPenalty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ByteMatrix)}, ReturnType = typeof(int))]
	private static int chooseMaskPattern(BitArray bits, ErrorCorrectionLevel ecLevel, Version version, ByteMatrix matrix) { }

	[CalledBy(Type = typeof(Encoder), Member = "encode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(ErrorCorrectionLevel), typeof(System.Collections.Generic.IDictionary`2<ZXing.EncodeHintType, System.Object>)}, ReturnType = typeof(QRCode))]
	[CalledBy(Type = typeof(Encoder), Member = "chooseMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Mode))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(Encoder), Member = "getAlphanumericCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Encoder), Member = "isOnlyDoubleByteKanji", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	private static Mode chooseMode(string content, string encoding) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Encoder), Member = "chooseMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(Mode))]
	public static Mode chooseMode(string content) { }

	[CalledBy(Type = typeof(Encoder), Member = "encode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(ErrorCorrectionLevel), typeof(System.Collections.Generic.IDictionary`2<ZXing.EncodeHintType, System.Object>)}, ReturnType = typeof(QRCode))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Version), Member = "getVersionForNumber", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Version))]
	[Calls(Type = typeof(WriterException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 6)]
	private static Version chooseVersion(int numInputBits, ErrorCorrectionLevel ecLevel) { }

	[CalledBy(Type = typeof(QRCodeWriter), Member = "encode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(BarcodeFormat), typeof(int), typeof(int), typeof(System.Collections.Generic.IDictionary`2<ZXing.EncodeHintType, System.Object>)}, ReturnType = typeof(BitMatrix))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(WriterException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Encoder), Member = "calculateMaskPenalty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ByteMatrix)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(MatrixUtil), Member = "buildMatrix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitArray), typeof(ErrorCorrectionLevel), typeof(Version), typeof(int), typeof(ByteMatrix)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Encoder), Member = "interleaveWithECBytes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitArray), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(BitArray))]
	[Calls(Type = typeof(Encoder), Member = "terminateBits", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(BitArray)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BitArray), Member = "get_SizeInBytes", ReturnType = typeof(int))]
	[Calls(Type = typeof(BitArray), Member = "appendBitArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitArray)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Encoder), Member = "chooseVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(ErrorCorrectionLevel)}, ReturnType = typeof(Version))]
	[Calls(Type = typeof(Mode), Member = "getCharacterCountBits", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Version)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Version), Member = "getVersionForNumber", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Version))]
	[Calls(Type = typeof(Encoder), Member = "appendBytes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Mode), typeof(BitArray), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BitArray), Member = "appendBits", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CharacterSetECI), Member = "getCharacterSetECIByName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(CharacterSetECI))]
	[Calls(Type = typeof(BitArray), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(Encoder), Member = "chooseMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(Mode))]
	[Calls(Type = typeof(string), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 19)]
	public static QRCode encode(string content, ErrorCorrectionLevel ecLevel, IDictionary<EncodeHintType, Object> hints) { }

	[CallerCount(Count = 0)]
	[ContainsInvalidInstructions]
	public static QRCode encode(string content, ErrorCorrectionLevel ecLevel) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ReedSolomonEncoder), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GenericGF)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ReedSolomonEncoder), Member = "encode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[]), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	internal static Byte[] generateECBytes(Byte[] dataBytes, int numEcBytesInBlock) { }

	[CalledBy(Type = typeof(Encoder), Member = "chooseMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(Mode))]
	[CalledBy(Type = typeof(Encoder), Member = "appendAlphanumericBytes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(BitArray)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	internal static int getAlphanumericCode(int code) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(WriterException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 14)]
	[ContainsUnimplementedInstructions]
	internal static void getNumDataBytesAndNumECBytesForBlockID(int numTotalBytes, int numDataBytes, int numRSBlocks, int blockID, Int32[] numDataBytesInBlock, Int32[] numECBytesInBlock) { }

	[CalledBy(Type = typeof(Encoder), Member = "encode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(ErrorCorrectionLevel), typeof(System.Collections.Generic.IDictionary`2<ZXing.EncodeHintType, System.Object>)}, ReturnType = typeof(QRCode))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BitArray), Member = "get_SizeInBytes", ReturnType = typeof(int))]
	[Calls(Type = typeof(List`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BitArray), Member = "toBytes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ReedSolomonEncoder), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GenericGF)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ReedSolomonEncoder), Member = "encode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[]), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Math), Member = "Max", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(BitArray), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(BitArray), Member = "appendBits", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(WriterException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[])}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 53)]
	[ContainsUnimplementedInstructions]
	internal static BitArray interleaveWithECBytes(BitArray bits, int numTotalBytes, int numDataBytes, int numRSBlocks) { }

	[CalledBy(Type = typeof(Encoder), Member = "chooseMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(Mode))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Encoding), Member = "GetEncoding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Encoding))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private static bool isOnlyDoubleByteKanji(string content) { }

	[CalledBy(Type = typeof(Encoder), Member = "encode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(ErrorCorrectionLevel), typeof(System.Collections.Generic.IDictionary`2<ZXing.EncodeHintType, System.Object>)}, ReturnType = typeof(QRCode))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BitArray), Member = "appendBit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BitArray), Member = "get_SizeInBytes", ReturnType = typeof(int))]
	[Calls(Type = typeof(BitArray), Member = "appendBits", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(WriterException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[])}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 26)]
	internal static void terminateBits(int numDataBytes, BitArray bits) { }

}

