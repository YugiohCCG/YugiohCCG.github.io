namespace ZXing.OneD.RSS.Expanded.Decoders;

internal sealed class GeneralAppIdDecoder
{
	private BitArray information; //Field offset: 0x10
	private CurrentParsingState current; //Field offset: 0x18
	private StringBuilder buffer; //Field offset: 0x20

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	internal GeneralAppIdDecoder(BitArray information) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GeneralAppIdDecoder), Member = "decodeGeneralPurposeField", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string)}, ReturnType = typeof(DecodedInformation))]
	[Calls(Type = typeof(FieldParser), Member = "parseFieldsInGeneralPurpose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	internal string decodeAllCodes(StringBuilder buff, int initialPosition) { }

	[CalledBy(Type = typeof(GeneralAppIdDecoder), Member = "parseAlphaBlock", ReturnType = typeof(BlockParsedResult))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BitArray), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 5)]
	[ContainsUnimplementedInstructions]
	private DecodedChar decodeAlphanumeric(int pos) { }

	[CalledBy(Type = typeof(AI01392xDecoder), Member = "parseInformation", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(AI01393xDecoder), Member = "parseInformation", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(AI01AndOtherAIs), Member = "parseInformation", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(AnyAIDecoder), Member = "parseInformation", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(GeneralAppIdDecoder), Member = "decodeAllCodes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder), typeof(int)}, ReturnType = typeof(string))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(StringBuilder), Member = "set_Length", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(GeneralAppIdDecoder), Member = "parseNumericBlock", ReturnType = typeof(BlockParsedResult))]
	[Calls(Type = typeof(GeneralAppIdDecoder), Member = "parseIsoIec646Block", ReturnType = typeof(BlockParsedResult))]
	[Calls(Type = typeof(GeneralAppIdDecoder), Member = "parseAlphaBlock", ReturnType = typeof(BlockParsedResult))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 3)]
	internal DecodedInformation decodeGeneralPurposeField(int pos, string remaining) { }

	[CalledBy(Type = typeof(GeneralAppIdDecoder), Member = "parseIsoIec646Block", ReturnType = typeof(BlockParsedResult))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BitArray), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 3)]
	[ContainsInvalidInstructions]
	[ContainsUnimplementedInstructions]
	private DecodedChar decodeIsoIec646(int pos) { }

	[CalledBy(Type = typeof(GeneralAppIdDecoder), Member = "parseNumericBlock", ReturnType = typeof(BlockParsedResult))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BitArray), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DecodedNumeric), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	[ContainsUnimplementedInstructions]
	private DecodedNumeric decodeNumeric(int pos) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BitArray), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	internal int extractNumericValueFromBitArray(int pos, int bits) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BitArray), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	internal static int extractNumericValueFromBitArray(BitArray information, int pos, int bits) { }

	[CalledBy(Type = typeof(GeneralAppIdDecoder), Member = "parseIsoIec646Block", ReturnType = typeof(BlockParsedResult))]
	[CalledBy(Type = typeof(GeneralAppIdDecoder), Member = "parseAlphaBlock", ReturnType = typeof(BlockParsedResult))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(BitArray), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	private bool isAlphaOr646ToNumericLatch(int pos) { }

	[CalledBy(Type = typeof(GeneralAppIdDecoder), Member = "parseIsoIec646Block", ReturnType = typeof(BlockParsedResult))]
	[CalledBy(Type = typeof(GeneralAppIdDecoder), Member = "parseAlphaBlock", ReturnType = typeof(BlockParsedResult))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(BitArray), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	private bool isAlphaTo646ToAlphaLatch(int pos) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BitArray), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	private bool isNumericToAlphaNumericLatch(int pos) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BitArray), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private bool isStillAlpha(int pos) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BitArray), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private bool isStillIsoIec646(int pos) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BitArray), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private bool isStillNumeric(int pos) { }

	[CalledBy(Type = typeof(GeneralAppIdDecoder), Member = "decodeGeneralPurposeField", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string)}, ReturnType = typeof(DecodedInformation))]
	[CalledBy(Type = typeof(GeneralAppIdDecoder), Member = "parseBlocks", ReturnType = typeof(DecodedInformation))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(BitArray), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(GeneralAppIdDecoder), Member = "decodeAlphanumeric", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(DecodedChar))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(DecodedInformation), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GeneralAppIdDecoder), Member = "isAlphaOr646ToNumericLatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(GeneralAppIdDecoder), Member = "isAlphaTo646ToAlphaLatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	private BlockParsedResult parseAlphaBlock() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GeneralAppIdDecoder), Member = "parseNumericBlock", ReturnType = typeof(BlockParsedResult))]
	[Calls(Type = typeof(GeneralAppIdDecoder), Member = "parseIsoIec646Block", ReturnType = typeof(BlockParsedResult))]
	[Calls(Type = typeof(GeneralAppIdDecoder), Member = "parseAlphaBlock", ReturnType = typeof(BlockParsedResult))]
	[CallsUnknownMethods(Count = 1)]
	private DecodedInformation parseBlocks() { }

	[CalledBy(Type = typeof(GeneralAppIdDecoder), Member = "decodeGeneralPurposeField", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string)}, ReturnType = typeof(DecodedInformation))]
	[CalledBy(Type = typeof(GeneralAppIdDecoder), Member = "parseBlocks", ReturnType = typeof(DecodedInformation))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(BitArray), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(GeneralAppIdDecoder), Member = "decodeIsoIec646", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(DecodedChar))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(DecodedInformation), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GeneralAppIdDecoder), Member = "isAlphaOr646ToNumericLatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(GeneralAppIdDecoder), Member = "isAlphaTo646ToAlphaLatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	private BlockParsedResult parseIsoIec646Block() { }

	[CalledBy(Type = typeof(GeneralAppIdDecoder), Member = "decodeGeneralPurposeField", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string)}, ReturnType = typeof(DecodedInformation))]
	[CalledBy(Type = typeof(GeneralAppIdDecoder), Member = "parseBlocks", ReturnType = typeof(DecodedInformation))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(BitArray), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(GeneralAppIdDecoder), Member = "decodeNumeric", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(DecodedNumeric))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(DecodedNumeric), Member = "isSecondDigitFNC1", ReturnType = typeof(bool))]
	[Calls(Type = typeof(DecodedInformation), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	private BlockParsedResult parseNumericBlock() { }

}

