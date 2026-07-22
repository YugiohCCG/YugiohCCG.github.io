namespace ZXing.OneD.RSS.Expanded.Decoders;

internal sealed class CurrentParsingState
{
	private enum State
	{
		NUMERIC = 0,
		ALPHA = 1,
		ISO_IEC_646 = 2,
	}

	private int position; //Field offset: 0x10
	private State encoding; //Field offset: 0x14

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	internal CurrentParsingState() { }

	[CallerCount(Count = 94)]
	[DeduplicatedMethod]
	internal int getPosition() { }

	[CallerCount(Count = 0)]
	internal void incrementPosition(int delta) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	internal bool isAlpha() { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	internal bool isIsoIec646() { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	internal bool isNumeric() { }

	[CallerCount(Count = 0)]
	internal void setAlpha() { }

	[CallerCount(Count = 0)]
	internal void setIsoIec646() { }

	[CallerCount(Count = 0)]
	internal void setNumeric() { }

	[CallerCount(Count = 7)]
	[DeduplicatedMethod]
	internal void setPosition(int position) { }

}

