namespace ZXing.OneD.RSS.Expanded.Decoders;

internal abstract class AI01weightDecoder : AI01decoder
{

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AbstractExpandedDecoder), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitArray)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	internal AI01weightDecoder(BitArray information) { }

	protected abstract void addWeightCode(StringBuilder buf, int weight) { }

	protected abstract int checkWeight(int weight) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BitArray), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(StringBuilder))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	protected void encodeCompressedWeight(StringBuilder buf, int currentPos, int weightSize) { }

}

