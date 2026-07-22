namespace ZXing.Common;

public static class StringUtils
{
	private static string PLATFORM_DEFAULT_ENCODING; //Field offset: 0x0
	private const string EUC_JP = "EUC-JP"; //Field offset: 0x0
	private const string UTF8 = "UTF-8"; //Field offset: 0x0
	private const string ISO88591 = "ISO-8859-1"; //Field offset: 0x0
	public static string SHIFT_JIS; //Field offset: 0x8
	public static string GB2312; //Field offset: 0x10
	private static readonly bool ASSUME_SHIFT_JIS; //Field offset: 0x18

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Encoding), Member = "get_Default", ReturnType = typeof(Encoding))]
	[Calls(Type = typeof(string), Member = "Compare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(StringComparison)}, ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	[ContainsUnimplementedInstructions]
	private static StringUtils() { }

	[CalledBy(Type = typeof(DecodedBitStreamParser), Member = "decodeByteSegment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitSource), typeof(StringBuilder), typeof(int), typeof(CharacterSetECI), typeof(System.Collections.Generic.IList`1<Byte[]>), typeof(System.Collections.Generic.IDictionary`2<ZXing.DecodeHintType, System.Object>)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	[ContainsUnimplementedInstructions]
	public static string guessEncoding(Byte[] bytes, IDictionary<DecodeHintType, Object> hints) { }

}

