namespace ZXing.OneD.RSS.Expanded.Decoders;

internal sealed class DecodedChar : DecodedObject
{
	internal static char FNC1; //Field offset: 0x0
	private char value; //Field offset: 0x18

	[CallerCount(Count = 0)]
	private static DecodedChar() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	internal DecodedChar(int newPosition, char value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	internal char getValue() { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	internal bool isFNC1() { }

}

