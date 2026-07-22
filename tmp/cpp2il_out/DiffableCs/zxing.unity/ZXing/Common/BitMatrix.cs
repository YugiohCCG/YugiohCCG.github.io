namespace ZXing.Common;

[DefaultMember("Item")]
public sealed class BitMatrix
{
	private readonly int width; //Field offset: 0x10
	private readonly int height; //Field offset: 0x14
	private readonly int rowSize; //Field offset: 0x18
	private readonly Int32[] bits; //Field offset: 0x20

	public int Dimension
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 4)]
		 get { } //Length: 102
	}

	public int Height
	{
		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		 get { } //Length: 4
	}

	public bool Item
	{
		[CallerCount(Count = 124)]
		[CallsUnknownMethods(Count = 2)]
		 get { } //Length: 66
		[CallerCount(Count = 90)]
		[CallsUnknownMethods(Count = 2)]
		[ContainsUnimplementedInstructions]
		 set { } //Length: 72
	}

	public int Width
	{
		[CallerCount(Count = 94)]
		[DeduplicatedMethod]
		 get { } //Length: 4
	}

	[CalledBy(Type = typeof(Encoder), Member = "encode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(AztecCode))]
	[CalledBy(Type = typeof(Decoder), Member = "decode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Boolean[][])}, ReturnType = typeof(DecoderResult))]
	[CalledBy(Type = typeof(Decoder), Member = "decode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Boolean[][]), typeof(System.Collections.Generic.IDictionary`2<ZXing.DecodeHintType, System.Object>)}, ReturnType = typeof(DecoderResult))]
	[CalledBy(Type = typeof(Version), Member = "buildFunctionPattern", ReturnType = typeof(BitMatrix))]
	[CallerCount(Count = 4)]
	[ContainsInvalidInstructions]
	public BitMatrix(int dimension) { }

	[CalledBy(Type = typeof(AztecWriter), Member = "renderResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AztecCode), typeof(int), typeof(int)}, ReturnType = typeof(BitMatrix))]
	[CalledBy(Type = typeof(SvgRenderer), Member = "AppendDarkCell", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SvgImage), typeof(BitMatrix), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(QRCodeWriter), Member = "renderResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(QRCode), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(BitMatrix))]
	[CalledBy(Type = typeof(QRCodeReader), Member = "extractPureBits", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitMatrix)}, ReturnType = typeof(BitMatrix))]
	[CalledBy(Type = typeof(PDF417Writer), Member = "bitMatrixFrombitArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SByte[][]), typeof(int)}, ReturnType = typeof(BitMatrix))]
	[CalledBy(Type = typeof(OneDimensionalCodeWriter), Member = "renderResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Boolean[]), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(BitMatrix))]
	[CalledBy(Type = typeof(OneDimensionalCodeWriter), Member = "encode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(BarcodeFormat), typeof(int), typeof(int), typeof(System.Collections.Generic.IDictionary`2<ZXing.EncodeHintType, System.Object>)}, ReturnType = typeof(BitMatrix))]
	[CalledBy(Type = typeof(MaxiCodeReader), Member = "extractPureBits", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitMatrix)}, ReturnType = typeof(BitMatrix))]
	[CalledBy(Type = typeof(BitMatrixParser), Member = "extractDataRegion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitMatrix)}, ReturnType = typeof(BitMatrix))]
	[CalledBy(Type = typeof(MaxiCodeReader), Member = "decode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryBitmap), typeof(System.Collections.Generic.IDictionary`2<ZXing.DecodeHintType, System.Object>)}, ReturnType = typeof(Result))]
	[CalledBy(Type = typeof(DataMatrixWriter), Member = "convertByteMatrixToBitMatrix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ByteMatrix)}, ReturnType = typeof(BitMatrix))]
	[CalledBy(Type = typeof(DataMatrixWriter), Member = "encodeLowLevel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DefaultPlacement), typeof(SymbolInfo)}, ReturnType = typeof(BitMatrix))]
	[CalledBy(Type = typeof(DataMatrixReader), Member = "extractPureBits", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitMatrix)}, ReturnType = typeof(BitMatrix))]
	[CalledBy(Type = typeof(HybridBinarizer), Member = "binarizeEntireImage", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(HybridBinarizer), Member = "get_BlackMatrix", ReturnType = typeof(BitMatrix))]
	[CalledBy(Type = typeof(GlobalHistogramBinarizer), Member = "get_BlackMatrix", ReturnType = typeof(BitMatrix))]
	[CalledBy(Type = typeof(DefaultGridSampler), Member = "sampleGrid", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitMatrix), typeof(int), typeof(int), typeof(PerspectiveTransform)}, ReturnType = typeof(BitMatrix))]
	[CalledBy(Type = typeof(BitMatrixParser), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitMatrix)}, ReturnType = typeof(void))]
	[CallerCount(Count = 18)]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	public BitMatrix(int width, int height) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	private BitMatrix(int width, int height, int rowSize, Int32[] bits) { }

	[CalledBy(Type = typeof(DataMatrixWriter), Member = "encodeLowLevel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DefaultPlacement), typeof(SymbolInfo)}, ReturnType = typeof(BitMatrix))]
	[CalledBy(Type = typeof(DataMatrixWriter), Member = "convertByteMatrixToBitMatrix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ByteMatrix)}, ReturnType = typeof(BitMatrix))]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public void clear() { }

	[CalledBy(Type = typeof(Detector), Member = "detect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryBitmap), typeof(System.Collections.Generic.IDictionary`2<ZXing.DecodeHintType, System.Object>), typeof(bool)}, ReturnType = typeof(PDF417DetectorResult))]
	[CalledBy(Type = typeof(PDF417Reader), Member = "decode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryBitmap), typeof(System.Collections.Generic.IDictionary`2<ZXing.DecodeHintType, System.Object>), typeof(bool)}, ReturnType = typeof(Result[]))]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	public object Clone() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 3)]
	public virtual bool Equals(object obj) { }

	[CalledBy(Type = typeof(BitMatrixParser), Member = "readCodewords", ReturnType = typeof(Byte[]))]
	[CalledBy(Type = typeof(BitMatrixParser), Member = "remask", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BitMatrixParser), Member = "mirror", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataMask), Member = "unmaskBitMatrix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitMatrix), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	public void flip(int x, int y) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	public int get_Dimension() { }

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public int get_Height() { }

	[CallerCount(Count = 124)]
	[CallsUnknownMethods(Count = 2)]
	public bool get_Item(int x, int y) { }

	[CallerCount(Count = 94)]
	[DeduplicatedMethod]
	public int get_Width() { }

	[CalledBy(Type = typeof(DataMatrixReader), Member = "extractPureBits", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitMatrix)}, ReturnType = typeof(BitMatrix))]
	[CalledBy(Type = typeof(QRCodeReader), Member = "extractPureBits", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitMatrix)}, ReturnType = typeof(BitMatrix))]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	public Int32[] getBottomRightOnBit() { }

	[CalledBy(Type = typeof(MaxiCodeReader), Member = "decode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryBitmap), typeof(System.Collections.Generic.IDictionary`2<ZXing.DecodeHintType, System.Object>)}, ReturnType = typeof(Result))]
	[CalledBy(Type = typeof(MaxiCodeReader), Member = "extractPureBits", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitMatrix)}, ReturnType = typeof(BitMatrix))]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public Int32[] getEnclosingRectangle() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public virtual int GetHashCode() { }

	[CalledBy(Type = typeof(BitMatrix), Member = "rotate180", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Color32Renderer), Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitMatrix), typeof(BarcodeFormat), typeof(string)}, ReturnType = typeof(Color32[]))]
	[CalledBy(Type = typeof(Color32Renderer), Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitMatrix), typeof(BarcodeFormat), typeof(string), typeof(EncodingOptions)}, ReturnType = typeof(Color32[]))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(BitArray), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	public BitArray getRow(int y, BitArray row) { }

	[CalledBy(Type = typeof(DataMatrixReader), Member = "extractPureBits", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitMatrix)}, ReturnType = typeof(BitMatrix))]
	[CalledBy(Type = typeof(QRCodeReader), Member = "extractPureBits", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitMatrix)}, ReturnType = typeof(BitMatrix))]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	public Int32[] getTopLeftOnBit() { }

	[CalledBy(Type = typeof(Detector), Member = "detect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryBitmap), typeof(System.Collections.Generic.IDictionary`2<ZXing.DecodeHintType, System.Object>), typeof(bool)}, ReturnType = typeof(PDF417DetectorResult))]
	[CalledBy(Type = typeof(PDF417Reader), Member = "decode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryBitmap), typeof(System.Collections.Generic.IDictionary`2<ZXing.DecodeHintType, System.Object>), typeof(bool)}, ReturnType = typeof(Result[]))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(BitArray), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BitMatrix), Member = "getRow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(BitArray)}, ReturnType = typeof(BitArray))]
	[Calls(Type = typeof(BitArray), Member = "reverse", ReturnType = typeof(void))]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void rotate180() { }

	[CallerCount(Count = 90)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	public void set_Item(int x, int y, bool value) { }

	[CalledBy(Type = typeof(AztecWriter), Member = "renderResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AztecCode), typeof(int), typeof(int)}, ReturnType = typeof(BitMatrix))]
	[CalledBy(Type = typeof(OneDimensionalCodeWriter), Member = "encode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(BarcodeFormat), typeof(int), typeof(int), typeof(System.Collections.Generic.IDictionary`2<ZXing.EncodeHintType, System.Object>)}, ReturnType = typeof(BitMatrix))]
	[CalledBy(Type = typeof(OneDimensionalCodeWriter), Member = "renderResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Boolean[]), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(BitMatrix))]
	[CalledBy(Type = typeof(Version), Member = "buildFunctionPattern", ReturnType = typeof(BitMatrix))]
	[CalledBy(Type = typeof(QRCodeWriter), Member = "renderResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(QRCode), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(BitMatrix))]
	[CallerCount(Count = 12)]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 14)]
	[ContainsUnimplementedInstructions]
	public void setRegion(int left, int top, int width, int height) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void setRow(int y, BitArray row) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(StringBuilder), Member = "AppendLine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(StringBuilder))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public virtual string ToString() { }

}

