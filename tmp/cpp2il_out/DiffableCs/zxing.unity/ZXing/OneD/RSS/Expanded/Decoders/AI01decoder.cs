namespace ZXing.OneD.RSS.Expanded.Decoders;

internal abstract class AI01decoder : AbstractExpandedDecoder
{
	protected static int GTIN_SIZE; //Field offset: 0x0

	[CallerCount(Count = 0)]
	private static AI01decoder() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AbstractExpandedDecoder), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitArray)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	internal AI01decoder(BitArray information) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StringBuilder), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(StringBuilder))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private static void appendCheckDigit(StringBuilder buf, int currentPos) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(AI01decoder), Member = "encodeCompressedGtinWithoutAI", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	protected void encodeCompressedGtin(StringBuilder buf, int currentPos) { }

	[CalledBy(Type = typeof(AI01392xDecoder), Member = "parseInformation", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(AI01393xDecoder), Member = "parseInformation", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(AI013x0x1xDecoder), Member = "parseInformation", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(AI013x0xDecoder), Member = "parseInformation", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(AI01AndOtherAIs), Member = "parseInformation", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(AI01decoder), Member = "encodeCompressedGtin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(BitArray), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(StringBuilder), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	protected void encodeCompressedGtinWithoutAI(StringBuilder buf, int currentPos, int initialBufferPosition) { }

}

