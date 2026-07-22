namespace ZXing.OneD;

public sealed class PlesseyWriter : OneDimensionalCodeWriter
{
	private const string ALPHABET_STRING = "0123456789ABCDEF"; //Field offset: 0x0
	private static readonly Int32[] startWidths; //Field offset: 0x0
	private static readonly Int32[] terminationWidths; //Field offset: 0x8
	private static readonly Int32[] endWidths; //Field offset: 0x10
	private static readonly Int32[][] numberWidths; //Field offset: 0x18
	private static readonly Byte[] crcGrid; //Field offset: 0x20
	private static readonly Int32[] crc0Widths; //Field offset: 0x28
	private static readonly Int32[] crc1Widths; //Field offset: 0x30

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(RuntimeFieldHandle)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 25)]
	private static PlesseyWriter() { }

	[CallerCount(Count = 2180)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public PlesseyWriter() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(OneDimensionalCodeWriter), Member = "encode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(BarcodeFormat), typeof(int), typeof(int), typeof(System.Collections.Generic.IDictionary`2<ZXing.EncodeHintType, System.Object>)}, ReturnType = typeof(BitMatrix))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	public virtual BitMatrix encode(string contents, BarcodeFormat format, int width, int height, IDictionary<EncodeHintType, Object> hints) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(string), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 8)]
	public virtual Boolean[] encode(string contents) { }

}

