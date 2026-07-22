namespace ZXing.Datamatrix.Encoder;

public class SymbolInfo
{
	internal static readonly SymbolInfo[] PROD_SYMBOLS; //Field offset: 0x0
	private static SymbolInfo[] symbols; //Field offset: 0x8
	private readonly bool rectangular; //Field offset: 0x10
	internal readonly int dataCapacity; //Field offset: 0x14
	internal readonly int errorCodewords; //Field offset: 0x18
	public readonly int matrixWidth; //Field offset: 0x1C
	public readonly int matrixHeight; //Field offset: 0x20
	private readonly int dataRegions; //Field offset: 0x24
	private readonly int rsBlockData; //Field offset: 0x28
	private readonly int rsBlockError; //Field offset: 0x2C

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 30)]
	[CallsUnknownMethods(Count = 124)]
	private static SymbolInfo() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public SymbolInfo(bool rectangular, int dataCapacity, int errorCodewords, int matrixWidth, int matrixHeight, int dataRegions) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	internal SymbolInfo(bool rectangular, int dataCapacity, int errorCodewords, int matrixWidth, int matrixHeight, int dataRegions, int rsBlockData, int rsBlockError) { }

	[CallerCount(Count = 0)]
	public int getCodewordCount() { }

	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	public override int getDataLengthForInterleavedBlock(int index) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public int getErrorLengthForInterleavedBlock(int index) { }

	[CalledBy(Type = typeof(DataMatrixWriter), Member = "encode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(BarcodeFormat), typeof(int), typeof(int), typeof(System.Collections.Generic.IDictionary`2<ZXing.EncodeHintType, System.Object>)}, ReturnType = typeof(BitMatrix))]
	[CalledBy(Type = typeof(DataMatrixWriter), Member = "encodeLowLevel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DefaultPlacement), typeof(SymbolInfo)}, ReturnType = typeof(BitMatrix))]
	[CalledBy(Type = typeof(SymbolInfo), Member = "lookup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(SymbolShapeHint), typeof(Dimension), typeof(Dimension), typeof(bool)}, ReturnType = typeof(SymbolInfo))]
	[CalledBy(Type = typeof(SymbolInfo), Member = "getSymbolDataWidth", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(SymbolInfo), Member = "getSymbolWidth", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(SymbolInfo), Member = "ToString", ReturnType = typeof(string))]
	[CallerCount(Count = 20)]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	private int getHorizontalDataRegions() { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public override int getInterleavedBlockCount() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SymbolInfo), Member = "getVerticalDataRegions", ReturnType = typeof(int))]
	public int getSymbolDataHeight() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SymbolInfo), Member = "getHorizontalDataRegions", ReturnType = typeof(int))]
	public int getSymbolDataWidth() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SymbolInfo), Member = "getVerticalDataRegions", ReturnType = typeof(int))]
	public int getSymbolHeight() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SymbolInfo), Member = "getHorizontalDataRegions", ReturnType = typeof(int))]
	public int getSymbolWidth() { }

	[CalledBy(Type = typeof(DataMatrixWriter), Member = "encode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(BarcodeFormat), typeof(int), typeof(int), typeof(System.Collections.Generic.IDictionary`2<ZXing.EncodeHintType, System.Object>)}, ReturnType = typeof(BitMatrix))]
	[CalledBy(Type = typeof(DataMatrixWriter), Member = "encodeLowLevel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DefaultPlacement), typeof(SymbolInfo)}, ReturnType = typeof(BitMatrix))]
	[CalledBy(Type = typeof(SymbolInfo), Member = "lookup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(SymbolShapeHint), typeof(Dimension), typeof(Dimension), typeof(bool)}, ReturnType = typeof(SymbolInfo))]
	[CalledBy(Type = typeof(SymbolInfo), Member = "getSymbolDataHeight", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(SymbolInfo), Member = "getSymbolHeight", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(SymbolInfo), Member = "ToString", ReturnType = typeof(string))]
	[CallerCount(Count = 14)]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	private int getVerticalDataRegions() { }

	[CalledBy(Type = typeof(DataMatrixWriter), Member = "encode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(BarcodeFormat), typeof(int), typeof(int), typeof(System.Collections.Generic.IDictionary`2<ZXing.EncodeHintType, System.Object>)}, ReturnType = typeof(BitMatrix))]
	[CalledBy(Type = typeof(EncoderContext), Member = "updateSymbolInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SymbolInfo), Member = "lookup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool), typeof(bool)}, ReturnType = typeof(SymbolInfo))]
	[CalledBy(Type = typeof(SymbolInfo), Member = "lookup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(SymbolShapeHint), typeof(bool)}, ReturnType = typeof(SymbolInfo))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(SymbolInfo), Member = "getHorizontalDataRegions", ReturnType = typeof(int))]
	[Calls(Type = typeof(SymbolInfo), Member = "getVerticalDataRegions", ReturnType = typeof(int))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 6)]
	public static SymbolInfo lookup(int dataCodewords, SymbolShapeHint shape, Dimension minSize, Dimension maxSize, bool fail) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SymbolInfo), Member = "lookup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(SymbolShapeHint), typeof(Dimension), typeof(Dimension), typeof(bool)}, ReturnType = typeof(SymbolInfo))]
	private static SymbolInfo lookup(int dataCodewords, SymbolShapeHint shape, bool fail) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SymbolInfo), Member = "lookup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(SymbolShapeHint), typeof(Dimension), typeof(Dimension), typeof(bool)}, ReturnType = typeof(SymbolInfo))]
	public static SymbolInfo lookup(int dataCodewords, bool allowRectangular, bool fail) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 6)]
	public static SymbolInfo lookup(int dataCodewords, SymbolShapeHint shape) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 6)]
	public static SymbolInfo lookup(int dataCodewords) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public static void overrideSymbolSet(SymbolInfo[] override) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(SymbolInfo), Member = "getHorizontalDataRegions", ReturnType = typeof(int))]
	[Calls(Type = typeof(SymbolInfo), Member = "getVerticalDataRegions", ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public virtual string ToString() { }

}

