namespace ZXing.OneD.RSS.Expanded.Decoders;

internal sealed class AI01AndOtherAIs : AI01decoder
{
	private static int HEADER_SIZE; //Field offset: 0x0

	[CallerCount(Count = 0)]
	private static AI01AndOtherAIs() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AbstractExpandedDecoder), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitArray)}, ReturnType = typeof(void))]
	internal AI01AndOtherAIs(BitArray information) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(BitArray), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(AI01decoder), Member = "encodeCompressedGtinWithoutAI", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GeneralAppIdDecoder), Member = "decodeGeneralPurposeField", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string)}, ReturnType = typeof(DecodedInformation))]
	[Calls(Type = typeof(FieldParser), Member = "parseFieldsInGeneralPurpose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	public virtual string parseInformation() { }

}

