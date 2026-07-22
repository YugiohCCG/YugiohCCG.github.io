namespace ZXing.Datamatrix;

public sealed class DataMatrixReader : Reader
{
	private static readonly ResultPoint[] NO_POINTS; //Field offset: 0x0
	private readonly Decoder decoder; //Field offset: 0x10

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private static DataMatrixReader() { }

	[CalledBy(Type = typeof(MultiFormatReader), Member = "set_Hints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IDictionary`2<ZXing.DecodeHintType, System.Object>)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	public DataMatrixReader() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DataMatrixReader), Member = "decode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryBitmap), typeof(System.Collections.Generic.IDictionary`2<ZXing.DecodeHintType, System.Object>)}, ReturnType = typeof(Result))]
	public override Result decode(BinaryBitmap image) { }

	[CalledBy(Type = typeof(DataMatrixReader), Member = "decode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryBitmap)}, ReturnType = typeof(Result))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BinaryBitmap), Member = "get_BlackMatrix", ReturnType = typeof(BitMatrix))]
	[Calls(Type = typeof(DataMatrixReader), Member = "extractPureBits", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitMatrix)}, ReturnType = typeof(BitMatrix))]
	[Calls(Type = typeof(Decoder), Member = "decode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitMatrix)}, ReturnType = typeof(DecoderResult))]
	[Calls(Type = typeof(WhiteRectangleDetector), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitMatrix)}, ReturnType = typeof(WhiteRectangleDetector))]
	[Calls(Type = typeof(Detector), Member = "detect", ReturnType = typeof(DetectorResult))]
	[Calls(Type = typeof(Result), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Byte[]), typeof(ResultPoint[]), typeof(BarcodeFormat)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Result), Member = "putMetadata", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ResultMetadataType), typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public override Result decode(BinaryBitmap image, IDictionary<DecodeHintType, Object> hints) { }

	[CalledBy(Type = typeof(DataMatrixReader), Member = "decode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryBitmap), typeof(System.Collections.Generic.IDictionary`2<ZXing.DecodeHintType, System.Object>)}, ReturnType = typeof(Result))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BitMatrix), Member = "getTopLeftOnBit", ReturnType = typeof(Int32[]))]
	[Calls(Type = typeof(BitMatrix), Member = "getBottomRightOnBit", ReturnType = typeof(Int32[]))]
	[Calls(Type = typeof(BitMatrix), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BitMatrix), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BitMatrix), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	private static BitMatrix extractPureBits(BitMatrix image) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BitMatrix), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	private static bool moduleSize(Int32[] leftTopBlack, BitMatrix image, out int modulesize) { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	public override void reset() { }

}

