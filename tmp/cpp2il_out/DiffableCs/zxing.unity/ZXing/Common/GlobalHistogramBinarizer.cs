namespace ZXing.Common;

public class GlobalHistogramBinarizer : Binarizer
{
	private const int LUMINANCE_BITS = 5; //Field offset: 0x0
	private const int LUMINANCE_SHIFT = 3; //Field offset: 0x0
	private const int LUMINANCE_BUCKETS = 32; //Field offset: 0x0
	private static readonly Byte[] EMPTY; //Field offset: 0x0
	private Byte[] luminances; //Field offset: 0x18
	private readonly Int32[] buckets; //Field offset: 0x20

	public virtual BitMatrix BlackMatrix
	{
		[CalledBy(Type = typeof(HybridBinarizer), Member = "get_BlackMatrix", ReturnType = typeof(BitMatrix))]
		[CalledBy(Type = typeof(HybridBinarizer), Member = "binarizeEntireImage", ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(BitMatrix), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(GlobalHistogramBinarizer), Member = "initArrays", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(GlobalHistogramBinarizer), Member = "estimateBlackPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[]), typeof(Int32&)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(BitMatrix), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(bool)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 5)]
		[CallsUnknownMethods(Count = 2)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 670
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private static GlobalHistogramBinarizer() { }

	[CalledBy(Type = typeof(GlobalHistogramBinarizer), Member = "createBinarizer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LuminanceSource)}, ReturnType = typeof(Binarizer))]
	[CalledBy(Type = typeof(HybridBinarizer), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LuminanceSource)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(HybridBinarizer), Member = "createBinarizer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LuminanceSource)}, ReturnType = typeof(Binarizer))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Binarizer), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LuminanceSource)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	public GlobalHistogramBinarizer(LuminanceSource source) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GlobalHistogramBinarizer), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LuminanceSource)}, ReturnType = typeof(void))]
	public virtual Binarizer createBinarizer(LuminanceSource source) { }

	[CalledBy(Type = typeof(GlobalHistogramBinarizer), Member = "getBlackRow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(BitArray)}, ReturnType = typeof(BitArray))]
	[CalledBy(Type = typeof(GlobalHistogramBinarizer), Member = "get_BlackMatrix", ReturnType = typeof(BitMatrix))]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	private static bool estimateBlackPoint(Int32[] buckets, out int blackPoint) { }

	[CalledBy(Type = typeof(HybridBinarizer), Member = "get_BlackMatrix", ReturnType = typeof(BitMatrix))]
	[CalledBy(Type = typeof(HybridBinarizer), Member = "binarizeEntireImage", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(BitMatrix), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GlobalHistogramBinarizer), Member = "initArrays", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GlobalHistogramBinarizer), Member = "estimateBlackPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[]), typeof(Int32&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BitMatrix), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	public virtual BitMatrix get_BlackMatrix() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BitArray), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GlobalHistogramBinarizer), Member = "initArrays", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GlobalHistogramBinarizer), Member = "estimateBlackPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[]), typeof(Int32&)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	public virtual BitArray getBlackRow(int y, BitArray row) { }

	[CalledBy(Type = typeof(GlobalHistogramBinarizer), Member = "getBlackRow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(BitArray)}, ReturnType = typeof(BitArray))]
	[CalledBy(Type = typeof(GlobalHistogramBinarizer), Member = "get_BlackMatrix", ReturnType = typeof(BitMatrix))]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private void initArrays(int luminanceSize) { }

}

