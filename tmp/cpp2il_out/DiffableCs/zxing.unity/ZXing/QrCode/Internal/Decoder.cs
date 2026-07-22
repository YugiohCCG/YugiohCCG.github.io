namespace ZXing.QrCode.Internal;

public sealed class Decoder
{
	private readonly ReedSolomonDecoder rsDecoder; //Field offset: 0x10

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public Decoder() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ReedSolomonDecoder), Member = "decode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[]), typeof(int)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 2)]
	private bool correctErrors(Byte[] codewordBytes, int numDataCodewords) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BitMatrix), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BitMatrix), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[ContainsInvalidInstructions]
	[ContainsUnimplementedInstructions]
	public DecoderResult decode(Boolean[][] image, IDictionary<DecodeHintType, Object> hints) { }

	[CalledBy(Type = typeof(QRCodeMultiReader), Member = "decodeMultiple", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryBitmap), typeof(System.Collections.Generic.IDictionary`2<ZXing.DecodeHintType, System.Object>)}, ReturnType = typeof(Result[]))]
	[CalledBy(Type = typeof(QRCodeReader), Member = "decode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryBitmap), typeof(System.Collections.Generic.IDictionary`2<ZXing.DecodeHintType, System.Object>)}, ReturnType = typeof(Result))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(BitMatrixParser), Member = "createBitMatrixParser", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitMatrix)}, ReturnType = typeof(BitMatrixParser))]
	[Calls(Type = typeof(Decoder), Member = "decode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitMatrixParser), typeof(System.Collections.Generic.IDictionary`2<ZXing.DecodeHintType, System.Object>)}, ReturnType = typeof(DecoderResult))]
	[Calls(Type = typeof(BitMatrixParser), Member = "remask", ReturnType = typeof(void))]
	[Calls(Type = typeof(BitMatrixParser), Member = "setMirror", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BitMatrixParser), Member = "readVersion", ReturnType = typeof(Version))]
	[Calls(Type = typeof(BitMatrixParser), Member = "readFormatInformation", ReturnType = typeof(FormatInformation))]
	[Calls(Type = typeof(BitMatrixParser), Member = "mirror", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public DecoderResult decode(BitMatrix bits, IDictionary<DecodeHintType, Object> hints) { }

	[CalledBy(Type = typeof(Decoder), Member = "decode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitMatrix), typeof(System.Collections.Generic.IDictionary`2<ZXing.DecodeHintType, System.Object>)}, ReturnType = typeof(DecoderResult))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(BitMatrixParser), Member = "readVersion", ReturnType = typeof(Version))]
	[Calls(Type = typeof(BitMatrixParser), Member = "readFormatInformation", ReturnType = typeof(FormatInformation))]
	[Calls(Type = typeof(BitMatrixParser), Member = "readCodewords", ReturnType = typeof(Byte[]))]
	[Calls(Type = typeof(DataBlock), Member = "getDataBlocks", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(Version), typeof(ErrorCorrectionLevel)}, ReturnType = typeof(DataBlock[]))]
	[Calls(Type = typeof(ReedSolomonDecoder), Member = "decode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[]), typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DecodedBitStreamParser), Member = "decode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(Version), typeof(ErrorCorrectionLevel), typeof(System.Collections.Generic.IDictionary`2<ZXing.DecodeHintType, System.Object>)}, ReturnType = typeof(DecoderResult))]
	[CallsUnknownMethods(Count = 2)]
	private DecoderResult decode(BitMatrixParser parser, IDictionary<DecodeHintType, Object> hints) { }

}

