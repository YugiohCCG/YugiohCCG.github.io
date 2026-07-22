namespace ZXing.Datamatrix.Encoder;

public sealed class Encodation
{
	public const int ASCII = 0; //Field offset: 0x0
	public const int C40 = 1; //Field offset: 0x0
	public const int TEXT = 2; //Field offset: 0x0
	public const int X12 = 3; //Field offset: 0x0
	public const int EDIFACT = 4; //Field offset: 0x0
	public const int BASE256 = 5; //Field offset: 0x0

	[CallerCount(Count = 2180)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public Encodation() { }

}

