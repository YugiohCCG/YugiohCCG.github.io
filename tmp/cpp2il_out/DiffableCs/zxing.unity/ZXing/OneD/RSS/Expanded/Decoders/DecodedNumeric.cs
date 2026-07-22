namespace ZXing.OneD.RSS.Expanded.Decoders;

internal sealed class DecodedNumeric : DecodedObject
{
	internal static int FNC1; //Field offset: 0x0
	private readonly int firstDigit; //Field offset: 0x18
	private readonly int secondDigit; //Field offset: 0x1C

	[CallerCount(Count = 0)]
	private static DecodedNumeric() { }

	[CalledBy(Type = typeof(GeneralAppIdDecoder), Member = "decodeNumeric", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(DecodedNumeric))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	internal DecodedNumeric(int newPosition, int firstDigit, int secondDigit) { }

	[CallerCount(Count = 7)]
	[DeduplicatedMethod]
	internal int getFirstDigit() { }

	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	internal int getSecondDigit() { }

	[CallerCount(Count = 0)]
	internal int getValue() { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	internal bool isAnyFNC1() { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	internal bool isFirstDigitFNC1() { }

	[CalledBy(Type = typeof(GeneralAppIdDecoder), Member = "parseNumericBlock", ReturnType = typeof(BlockParsedResult))]
	[CallerCount(Count = 2)]
	[ContainsUnimplementedInstructions]
	internal bool isSecondDigitFNC1() { }

}

