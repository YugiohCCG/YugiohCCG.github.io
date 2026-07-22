namespace ZXing.QrCode.Internal;

public sealed class ErrorCorrectionLevel
{
	public static readonly ErrorCorrectionLevel L; //Field offset: 0x0
	public static readonly ErrorCorrectionLevel M; //Field offset: 0x8
	public static readonly ErrorCorrectionLevel Q; //Field offset: 0x10
	public static readonly ErrorCorrectionLevel H; //Field offset: 0x18
	private static readonly ErrorCorrectionLevel[] FOR_BITS; //Field offset: 0x20
	private readonly int bits; //Field offset: 0x10
	private readonly int ordinal_Renamed_Field; //Field offset: 0x14
	private readonly string name; //Field offset: 0x18

	public int Bits
	{
		[CallerCount(Count = 94)]
		[DeduplicatedMethod]
		 get { } //Length: 4
	}

	public string Name
	{
		[CallerCount(Count = 31)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 15)]
	private static ErrorCorrectionLevel() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private ErrorCorrectionLevel(int ordinal, int bits, string name) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	public static ErrorCorrectionLevel forBits(int bits) { }

	[CallerCount(Count = 94)]
	[DeduplicatedMethod]
	public int get_Bits() { }

	[CallerCount(Count = 31)]
	[DeduplicatedMethod]
	public string get_Name() { }

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public int ordinal() { }

	[CallerCount(Count = 31)]
	[DeduplicatedMethod]
	public virtual string ToString() { }

}

