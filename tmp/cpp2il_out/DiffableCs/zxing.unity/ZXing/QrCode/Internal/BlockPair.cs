namespace ZXing.QrCode.Internal;

internal sealed class BlockPair
{
	private readonly Byte[] dataBytes; //Field offset: 0x10
	private readonly Byte[] errorCorrectionBytes; //Field offset: 0x18

	public Byte[] DataBytes
	{
		[CallerCount(Count = 106)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public Byte[] ErrorCorrectionBytes
	{
		[CallerCount(Count = 31)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	[CallerCount(Count = 40)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public BlockPair(Byte[] data, Byte[] errorCorrection) { }

	[CallerCount(Count = 106)]
	[DeduplicatedMethod]
	public Byte[] get_DataBytes() { }

	[CallerCount(Count = 31)]
	[DeduplicatedMethod]
	public Byte[] get_ErrorCorrectionBytes() { }

}

