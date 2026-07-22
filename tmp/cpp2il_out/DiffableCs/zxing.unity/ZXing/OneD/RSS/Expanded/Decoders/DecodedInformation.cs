namespace ZXing.OneD.RSS.Expanded.Decoders;

internal sealed class DecodedInformation : DecodedObject
{
	private string newString; //Field offset: 0x18
	private int remainingValue; //Field offset: 0x20
	private bool remaining; //Field offset: 0x24

	[CalledBy(Type = typeof(GeneralAppIdDecoder), Member = "parseNumericBlock", ReturnType = typeof(BlockParsedResult))]
	[CalledBy(Type = typeof(GeneralAppIdDecoder), Member = "parseIsoIec646Block", ReturnType = typeof(BlockParsedResult))]
	[CalledBy(Type = typeof(GeneralAppIdDecoder), Member = "parseAlphaBlock", ReturnType = typeof(BlockParsedResult))]
	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	internal DecodedInformation(int newPosition, string newString) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	internal DecodedInformation(int newPosition, string newString, int remainingValue) { }

	[CallerCount(Count = 31)]
	[DeduplicatedMethod]
	internal string getNewString() { }

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	internal int getRemainingValue() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	internal bool isRemaining() { }

}

