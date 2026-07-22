namespace ZXing.OneD.RSS.Expanded.Decoders;

internal sealed class AnyAIDecoder : AbstractExpandedDecoder
{
	private static int HEADER_SIZE; //Field offset: 0x0

	[CallerCount(Count = 0)]
	private static AnyAIDecoder() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AbstractExpandedDecoder), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitArray)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	internal AnyAIDecoder(BitArray information) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(GeneralAppIdDecoder), Member = "decodeGeneralPurposeField", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string)}, ReturnType = typeof(DecodedInformation))]
	[Calls(Type = typeof(FieldParser), Member = "parseFieldsInGeneralPurpose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public virtual string parseInformation() { }

}

