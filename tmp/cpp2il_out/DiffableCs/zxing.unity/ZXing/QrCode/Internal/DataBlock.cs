namespace ZXing.QrCode.Internal;

internal sealed class DataBlock
{
	private readonly int numDataCodewords; //Field offset: 0x10
	private readonly Byte[] codewords; //Field offset: 0x18

	internal Byte[] Codewords
	{
		[CallerCount(Count = 31)]
		[DeduplicatedMethod]
		internal get { } //Length: 5
	}

	internal int NumDataCodewords
	{
		[CallerCount(Count = 94)]
		[DeduplicatedMethod]
		internal get { } //Length: 4
	}

	[CallerCount(Count = 157)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	private DataBlock(int numDataCodewords, Byte[] codewords) { }

	[CallerCount(Count = 31)]
	[DeduplicatedMethod]
	internal Byte[] get_Codewords() { }

	[CallerCount(Count = 94)]
	[DeduplicatedMethod]
	internal int get_NumDataCodewords() { }

	[CalledBy(Type = typeof(Decoder), Member = "decode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitMatrixParser), typeof(System.Collections.Generic.IDictionary`2<ZXing.DecodeHintType, System.Object>)}, ReturnType = typeof(DecoderResult))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Version), Member = "getECBlocksForLevel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ErrorCorrectionLevel)}, ReturnType = typeof(ECBlocks))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	internal static DataBlock[] getDataBlocks(Byte[] rawCodewords, Version version, ErrorCorrectionLevel ecLevel) { }

}

