namespace ZXing.Aztec.Internal;

public sealed class Decoder
{
	private enum Table
	{
		UPPER = 0,
		LOWER = 1,
		MIXED = 2,
		DIGIT = 3,
		PUNCT = 4,
		BINARY = 5,
	}

	private static readonly String[] UPPER_TABLE; //Field offset: 0x0
	private static readonly String[] LOWER_TABLE; //Field offset: 0x8
	private static readonly String[] MIXED_TABLE; //Field offset: 0x10
	private static readonly String[] PUNCT_TABLE; //Field offset: 0x18
	private static readonly String[] DIGIT_TABLE; //Field offset: 0x20
	private static readonly IDictionary<Table, String[]> codeTables; //Field offset: 0x28
	private static readonly IDictionary<Char, Table> codeTableMap; //Field offset: 0x30
	private AztecDetectorResult ddata; //Field offset: 0x10

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32Enum, System.Object>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Int32Enum", typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Char, System.Int32Enum>), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Char, System.Int32Enum>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), "System.Int32Enum"}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 155)]
	private static Decoder() { }

	[CallerCount(Count = 2180)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public Decoder() { }

	[CalledBy(Type = typeof(Decoder), Member = "decode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AztecDetectorResult)}, ReturnType = typeof(DecoderResult))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ReedSolomonDecoder), Member = "decode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[]), typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(SupportClass), Member = "Fill", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]", typeof(int), typeof(int), "T"}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	private Boolean[] correctBits(Boolean[] rawbits) { }

	[CalledBy(Type = typeof(AztecReader), Member = "decode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryBitmap), typeof(System.Collections.Generic.IDictionary`2<ZXing.DecodeHintType, System.Object>)}, ReturnType = typeof(Result))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Decoder), Member = "extractBits", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitMatrix)}, ReturnType = typeof(Boolean[]))]
	[Calls(Type = typeof(Decoder), Member = "correctBits", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Boolean[])}, ReturnType = typeof(Boolean[]))]
	[Calls(Type = typeof(Decoder), Member = "getEncodedData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Boolean[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(DecoderResult), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(string), typeof(System.Collections.Generic.IList`1<Byte[]>), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	public DecoderResult decode(AztecDetectorResult detectorResult) { }

	[CalledBy(Type = typeof(Decoder), Member = "decode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AztecDetectorResult)}, ReturnType = typeof(DecoderResult))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BitMatrix), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	private Boolean[] extractBits(BitMatrix matrix) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	private static string getCharacter(String[] table, int code) { }

	[CalledBy(Type = typeof(Decoder), Member = "decode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AztecDetectorResult)}, ReturnType = typeof(DecoderResult))]
	[CalledBy(Type = typeof(Decoder), Member = "highLevelDecode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Boolean[])}, ReturnType = typeof(string))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "StartsWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(Decoder), Member = "getTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(Table))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(StringBuilder))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	[ContainsUnimplementedInstructions]
	private static string getEncodedData(Boolean[] correctedBits) { }

	[CalledBy(Type = typeof(Decoder), Member = "getEncodedData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Boolean[])}, ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private static Table getTable(char t) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Decoder), Member = "getEncodedData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Boolean[])}, ReturnType = typeof(string))]
	public static string highLevelDecode(Boolean[] correctedBits) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static int readCode(Boolean[] rawbits, int startIndex, int length) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	private static int totalBitsInLayer(int layers, bool compact) { }

}

