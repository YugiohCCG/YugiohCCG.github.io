namespace ZXing.Maxicode;

public sealed class MaxiCodeReader : Reader
{
	private static readonly ResultPoint[] NO_POINTS; //Field offset: 0x0
	private const int MATRIX_WIDTH = 30; //Field offset: 0x0
	private const int MATRIX_HEIGHT = 33; //Field offset: 0x0
	private readonly Decoder decoder; //Field offset: 0x10

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private static MaxiCodeReader() { }

	[CalledBy(Type = typeof(MultiFormatReader), Member = "set_Hints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IDictionary`2<ZXing.DecodeHintType, System.Object>)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	public MaxiCodeReader() { }

	[CallerCount(Count = 0)]
	public override Result decode(BinaryBitmap image) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BinaryBitmap), Member = "get_BlackMatrix", ReturnType = typeof(BitMatrix))]
	[Calls(Type = typeof(BitMatrix), Member = "getEnclosingRectangle", ReturnType = typeof(Int32[]))]
	[Calls(Type = typeof(BitMatrix), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BitMatrix), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BitMatrix), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Decoder), Member = "decode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitMatrix), typeof(System.Collections.Generic.IDictionary`2<ZXing.DecodeHintType, System.Object>)}, ReturnType = typeof(DecoderResult))]
	[Calls(Type = typeof(Result), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Byte[]), typeof(ResultPoint[]), typeof(BarcodeFormat)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Result), Member = "putMetadata", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ResultMetadataType), typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	public override Result decode(BinaryBitmap image, IDictionary<DecodeHintType, Object> hints) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BitMatrix), Member = "getEnclosingRectangle", ReturnType = typeof(Int32[]))]
	[Calls(Type = typeof(BitMatrix), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BitMatrix), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BitMatrix), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	private static BitMatrix extractPureBits(BitMatrix image) { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	public override void reset() { }

}

