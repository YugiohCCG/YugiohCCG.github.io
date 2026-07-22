namespace ZXing.OneD.RSS.Expanded.Decoders;

internal sealed class BlockParsedResult
{
	private DecodedInformation decodedInformation; //Field offset: 0x10
	private bool finished; //Field offset: 0x18

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	internal BlockParsedResult(bool finished) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	internal BlockParsedResult(DecodedInformation information, bool finished) { }

	[CallerCount(Count = 106)]
	[DeduplicatedMethod]
	internal DecodedInformation getDecodedInformation() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	internal bool isFinished() { }

}

