namespace ZXing.Common;

public sealed class CharacterSetECI : ECI
{
	internal static readonly IDictionary<Int32, CharacterSetECI> VALUE_TO_ECI; //Field offset: 0x0
	internal static readonly IDictionary<String, CharacterSetECI> NAME_TO_ECI; //Field offset: 0x8
	private readonly string encodingName; //Field offset: 0x18

	public string EncodingName
	{
		[CallerCount(Count = 31)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CharacterSetECI), Member = "addCharacterSet", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CharacterSetECI), Member = "addCharacterSet", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(String[])}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 59)]
	[ContainsInvalidInstructions]
	private static CharacterSetECI() { }

	[CallerCount(Count = 157)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	private CharacterSetECI(int value, string encodingName) { }

	[CalledBy(Type = typeof(CharacterSetECI), Member = ".cctor", ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	private static void addCharacterSet(int value, string encodingName) { }

	[CalledBy(Type = typeof(CharacterSetECI), Member = ".cctor", ReturnType = typeof(void))]
	[CallerCount(Count = 24)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	private static void addCharacterSet(int value, String[] encodingNames) { }

	[CallerCount(Count = 31)]
	[DeduplicatedMethod]
	public string get_EncodingName() { }

	[CalledBy(Type = typeof(PDF417HighLevelEncoder), Member = "encodeHighLevel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Compaction), typeof(Encoding), typeof(bool)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(Encoder), Member = "encode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(ErrorCorrectionLevel), typeof(System.Collections.Generic.IDictionary`2<ZXing.EncodeHintType, System.Object>)}, ReturnType = typeof(QRCode))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "ToUpper", ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static CharacterSetECI getCharacterSetECIByName(string name) { }

	[CalledBy(Type = typeof(DecodedBitStreamParser), Member = "decode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(Version), typeof(ErrorCorrectionLevel), typeof(System.Collections.Generic.IDictionary`2<ZXing.DecodeHintType, System.Object>)}, ReturnType = typeof(DecoderResult))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static CharacterSetECI getCharacterSetECIByValue(int value) { }

}

