namespace ZXing.Common;

public sealed class HybridBinarizer : GlobalHistogramBinarizer
{
	private const int BLOCK_SIZE_POWER = 3; //Field offset: 0x0
	private const int BLOCK_SIZE = 8; //Field offset: 0x0
	private const int BLOCK_SIZE_MASK = 7; //Field offset: 0x0
	private const int MINIMUM_DIMENSION = 40; //Field offset: 0x0
	private const int MIN_DYNAMIC_RANGE = 24; //Field offset: 0x0
	private BitMatrix matrix; //Field offset: 0x28

	public virtual BitMatrix BlackMatrix
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(HybridBinarizer), Member = "calculateBlackPoints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(Int32[][]))]
		[Calls(Type = typeof(BitMatrix), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(HybridBinarizer), Member = "calculateThresholdForBlock", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int), typeof(int), typeof(int), typeof(Int32[][]), typeof(BitMatrix)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(GlobalHistogramBinarizer), Member = "get_BlackMatrix", ReturnType = typeof(BitMatrix))]
		[CallsDeduplicatedMethods(Count = 4)]
		[CallsUnknownMethods(Count = 3)]
		 get { } //Length: 440
	}

	[CalledBy(Type = typeof(BarcodeReaderGeneric`1), Member = "<defaultCreateBinarizer>m__1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LuminanceSource)}, ReturnType = typeof(Binarizer))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GlobalHistogramBinarizer), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LuminanceSource)}, ReturnType = typeof(void))]
	public HybridBinarizer(LuminanceSource source) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(HybridBinarizer), Member = "calculateBlackPoints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(Int32[][]))]
	[Calls(Type = typeof(BitMatrix), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(HybridBinarizer), Member = "calculateThresholdForBlock", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int), typeof(int), typeof(int), typeof(Int32[][]), typeof(BitMatrix)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GlobalHistogramBinarizer), Member = "get_BlackMatrix", ReturnType = typeof(BitMatrix))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 3)]
	private void binarizeEntireImage() { }

	[CalledBy(Type = typeof(HybridBinarizer), Member = "get_BlackMatrix", ReturnType = typeof(BitMatrix))]
	[CalledBy(Type = typeof(HybridBinarizer), Member = "binarizeEntireImage", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private static Int32[][] calculateBlackPoints(Byte[] luminances, int subWidth, int subHeight, int width, int height) { }

	[CalledBy(Type = typeof(HybridBinarizer), Member = "get_BlackMatrix", ReturnType = typeof(BitMatrix))]
	[CalledBy(Type = typeof(HybridBinarizer), Member = "binarizeEntireImage", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	private static void calculateThresholdForBlock(Byte[] luminances, int subWidth, int subHeight, int width, int height, Int32[][] blackPoints, BitMatrix matrix) { }

	[CallerCount(Count = 0)]
	private static int cap(int value, int min, int max) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GlobalHistogramBinarizer), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LuminanceSource)}, ReturnType = typeof(void))]
	public virtual Binarizer createBinarizer(LuminanceSource source) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(HybridBinarizer), Member = "calculateBlackPoints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(Int32[][]))]
	[Calls(Type = typeof(BitMatrix), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(HybridBinarizer), Member = "calculateThresholdForBlock", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int), typeof(int), typeof(int), typeof(Int32[][]), typeof(BitMatrix)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GlobalHistogramBinarizer), Member = "get_BlackMatrix", ReturnType = typeof(BitMatrix))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 3)]
	public virtual BitMatrix get_BlackMatrix() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	private static void thresholdBlock(Byte[] luminances, int xoffset, int yoffset, int threshold, int stride, BitMatrix matrix) { }

}

