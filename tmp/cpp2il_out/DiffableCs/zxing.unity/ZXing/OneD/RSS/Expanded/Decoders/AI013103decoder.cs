namespace ZXing.OneD.RSS.Expanded.Decoders;

internal sealed class AI013103decoder : AI013x0xDecoder
{

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AbstractExpandedDecoder), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitArray)}, ReturnType = typeof(void))]
	internal AI013103decoder(BitArray information) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(StringBuilder))]
	[CallsUnknownMethods(Count = 1)]
	protected virtual void addWeightCode(StringBuilder buf, int weight) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	protected virtual int checkWeight(int weight) { }

}

