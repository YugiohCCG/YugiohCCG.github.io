namespace ZXing.Datamatrix;

public sealed class DataMatrixWriter : Writer
{

	[CallerCount(Count = 2180)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public DataMatrixWriter() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BitMatrix), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BitMatrix), Member = "clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(ByteMatrix), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(BitMatrix), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private static BitMatrix convertByteMatrixToBitMatrix(ByteMatrix matrix) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DataMatrixWriter), Member = "encode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(BarcodeFormat), typeof(int), typeof(int), typeof(System.Collections.Generic.IDictionary`2<ZXing.EncodeHintType, System.Object>)}, ReturnType = typeof(BitMatrix))]
	public override BitMatrix encode(string contents, BarcodeFormat format, int width, int height) { }

	[CalledBy(Type = typeof(DataMatrixWriter), Member = "encode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(BarcodeFormat), typeof(int), typeof(int)}, ReturnType = typeof(BitMatrix))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataMatrixWriter), Member = "encodeLowLevel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DefaultPlacement), typeof(SymbolInfo)}, ReturnType = typeof(BitMatrix))]
	[Calls(Type = typeof(DefaultPlacement), Member = "place", ReturnType = typeof(void))]
	[Calls(Type = typeof(SupportClass), Member = "Fill", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]", "T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SymbolInfo), Member = "getVerticalDataRegions", ReturnType = typeof(int))]
	[Calls(Type = typeof(SymbolInfo), Member = "getHorizontalDataRegions", ReturnType = typeof(int))]
	[Calls(Type = typeof(ErrorCorrection), Member = "encodeECC200", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(SymbolInfo)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(SymbolInfo), Member = "lookup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(SymbolShapeHint), typeof(Dimension), typeof(Dimension), typeof(bool)}, ReturnType = typeof(SymbolInfo))]
	[Calls(Type = typeof(HighLevelEncoder), Member = "encodeHighLevel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(SymbolShapeHint), typeof(Dimension), typeof(Dimension), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Nullable`1), Member = "get_Value", ReturnType = "T")]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 44)]
	public override BitMatrix encode(string contents, BarcodeFormat format, int width, int height, IDictionary<EncodeHintType, Object> hints) { }

	[CalledBy(Type = typeof(DataMatrixWriter), Member = "encode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(BarcodeFormat), typeof(int), typeof(int), typeof(System.Collections.Generic.IDictionary`2<ZXing.EncodeHintType, System.Object>)}, ReturnType = typeof(BitMatrix))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SymbolInfo), Member = "getHorizontalDataRegions", ReturnType = typeof(int))]
	[Calls(Type = typeof(SymbolInfo), Member = "getVerticalDataRegions", ReturnType = typeof(int))]
	[Calls(Type = typeof(ByteMatrix), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BitMatrix), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BitMatrix), Member = "clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(ByteMatrix), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(BitMatrix), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	private static BitMatrix encodeLowLevel(DefaultPlacement placement, SymbolInfo symbolInfo) { }

}

