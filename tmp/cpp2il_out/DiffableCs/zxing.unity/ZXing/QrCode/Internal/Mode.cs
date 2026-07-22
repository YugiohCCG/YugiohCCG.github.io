namespace ZXing.QrCode.Internal;

public sealed class Mode
{
	public static readonly Mode TERMINATOR; //Field offset: 0x0
	public static readonly Mode NUMERIC; //Field offset: 0x8
	public static readonly Mode ALPHANUMERIC; //Field offset: 0x10
	public static readonly Mode STRUCTURED_APPEND; //Field offset: 0x18
	public static readonly Mode BYTE; //Field offset: 0x20
	public static readonly Mode ECI; //Field offset: 0x28
	public static readonly Mode KANJI; //Field offset: 0x30
	public static readonly Mode FNC1_FIRST_POSITION; //Field offset: 0x38
	public static readonly Mode FNC1_SECOND_POSITION; //Field offset: 0x40
	public static readonly Mode HANZI; //Field offset: 0x48
	private readonly Int32[] characterCountBitsForVersions; //Field offset: 0x10
	private readonly int bits; //Field offset: 0x18
	private readonly string name; //Field offset: 0x20

	public int Bits
	{
		[CallerCount(Count = 7)]
		[DeduplicatedMethod]
		 get { } //Length: 4
	}

	public string Name
	{
		[CallerCount(Count = 12)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(RuntimeFieldHandle)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallsUnknownMethods(Count = 30)]
	private static Mode() { }

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	private Mode(Int32[] characterCountBitsForVersions, int bits, string name) { }

	[CalledBy(Type = typeof(DecodedBitStreamParser), Member = "decode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(Version), typeof(ErrorCorrectionLevel), typeof(System.Collections.Generic.IDictionary`2<ZXing.DecodeHintType, System.Object>)}, ReturnType = typeof(DecoderResult))]
	[CallerCount(Count = 1)]
	[ContainsInvalidInstructions]
	public static Mode forBits(int bits) { }

	[CallerCount(Count = 7)]
	[DeduplicatedMethod]
	public int get_Bits() { }

	[CallerCount(Count = 12)]
	[DeduplicatedMethod]
	public string get_Name() { }

	[CalledBy(Type = typeof(DecodedBitStreamParser), Member = "decode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(Version), typeof(ErrorCorrectionLevel), typeof(System.Collections.Generic.IDictionary`2<ZXing.DecodeHintType, System.Object>)}, ReturnType = typeof(DecoderResult))]
	[CalledBy(Type = typeof(Encoder), Member = "encode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(ErrorCorrectionLevel), typeof(System.Collections.Generic.IDictionary`2<ZXing.EncodeHintType, System.Object>)}, ReturnType = typeof(QRCode))]
	[CalledBy(Type = typeof(Encoder), Member = "appendLengthInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Version), typeof(Mode), typeof(BitArray)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 6)]
	public int getCharacterCountBits(Version version) { }

	[CallerCount(Count = 12)]
	[DeduplicatedMethod]
	public virtual string ToString() { }

}

