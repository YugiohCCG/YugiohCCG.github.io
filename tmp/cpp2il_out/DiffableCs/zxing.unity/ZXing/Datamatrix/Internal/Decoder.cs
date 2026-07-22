namespace ZXing.Datamatrix.Internal;

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
	public DecoderResult decode(Boolean[][] image) { }

	[CalledBy(Type = typeof(DataMatrixReader), Member = "decode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryBitmap), typeof(System.Collections.Generic.IDictionary`2<ZXing.DecodeHintType, System.Object>)}, ReturnType = typeof(Result))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(BitMatrixParser), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitMatrix)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BitMatrixParser), Member = "readCodewords", ReturnType = typeof(Byte[]))]
	[Calls(Type = typeof(DataBlock), Member = "getDataBlocks", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(Version)}, ReturnType = typeof(DataBlock[]))]
	[Calls(Type = typeof(ReedSolomonDecoder), Member = "decode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[]), typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DecodedBitStreamParser), Member = "decode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(DecoderResult))]
	[CallsUnknownMethods(Count = 2)]
	public DecoderResult decode(BitMatrix bits) { }

}

