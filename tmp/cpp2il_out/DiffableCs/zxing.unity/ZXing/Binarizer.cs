namespace ZXing;

public abstract class Binarizer
{
	private readonly LuminanceSource source; //Field offset: 0x10

	public abstract BitMatrix BlackMatrix
	{
		 get { } //Length: 0
	}

	public int Height
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 39
	}

	public override LuminanceSource LuminanceSource
	{
		[CallerCount(Count = 106)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public int Width
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 39
	}

	[CalledBy(Type = typeof(GlobalHistogramBinarizer), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LuminanceSource)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	protected private Binarizer(LuminanceSource source) { }

	public abstract Binarizer createBinarizer(LuminanceSource source) { }

	public abstract BitMatrix get_BlackMatrix() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public int get_Height() { }

	[CallerCount(Count = 106)]
	[DeduplicatedMethod]
	public override LuminanceSource get_LuminanceSource() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public int get_Width() { }

	public abstract BitArray getBlackRow(int y, BitArray row) { }

}

