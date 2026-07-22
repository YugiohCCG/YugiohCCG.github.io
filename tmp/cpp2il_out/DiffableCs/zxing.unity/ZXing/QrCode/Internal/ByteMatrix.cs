namespace ZXing.QrCode.Internal;

[DefaultMember("Item")]
public sealed class ByteMatrix
{
	private readonly Byte[][] bytes; //Field offset: 0x10
	private readonly int width; //Field offset: 0x18
	private readonly int height; //Field offset: 0x1C

	public Byte[][] Array
	{
		[CallerCount(Count = 106)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public int Height
	{
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 4
	}

	public int Item
	{
		[CalledBy(Type = typeof(DataMatrixWriter), Member = "encodeLowLevel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DefaultPlacement), typeof(SymbolInfo)}, ReturnType = typeof(BitMatrix))]
		[CalledBy(Type = typeof(DataMatrixWriter), Member = "convertByteMatrixToBitMatrix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ByteMatrix)}, ReturnType = typeof(BitMatrix))]
		[CalledBy(Type = typeof(MatrixUtil), Member = "embedDataBits", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitArray), typeof(int), typeof(ByteMatrix)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(MatrixUtil), Member = "maybeEmbedPositionAdjustmentPatterns", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Version), typeof(ByteMatrix)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(QRCodeWriter), Member = "renderResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(QRCode), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(BitMatrix))]
		[CallerCount(Count = 5)]
		[CallsUnknownMethods(Count = 2)]
		 get { } //Length: 61
		[CallerCount(Count = 18)]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		 set { } //Length: 61
	}

	public int Width
	{
		[CallerCount(Count = 7)]
		[DeduplicatedMethod]
		 get { } //Length: 4
	}

	[CalledBy(Type = typeof(DataMatrixWriter), Member = "encodeLowLevel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DefaultPlacement), typeof(SymbolInfo)}, ReturnType = typeof(BitMatrix))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public ByteMatrix(int width, int height) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public void clear(byte value) { }

	[CallerCount(Count = 106)]
	[DeduplicatedMethod]
	public Byte[][] get_Array() { }

	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	public int get_Height() { }

	[CalledBy(Type = typeof(DataMatrixWriter), Member = "encodeLowLevel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DefaultPlacement), typeof(SymbolInfo)}, ReturnType = typeof(BitMatrix))]
	[CalledBy(Type = typeof(DataMatrixWriter), Member = "convertByteMatrixToBitMatrix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ByteMatrix)}, ReturnType = typeof(BitMatrix))]
	[CalledBy(Type = typeof(MatrixUtil), Member = "embedDataBits", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitArray), typeof(int), typeof(ByteMatrix)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MatrixUtil), Member = "maybeEmbedPositionAdjustmentPatterns", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Version), typeof(ByteMatrix)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(QRCodeWriter), Member = "renderResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(QRCode), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(BitMatrix))]
	[CallerCount(Count = 5)]
	[CallsUnknownMethods(Count = 2)]
	public int get_Item(int x, int y) { }

	[CallerCount(Count = 7)]
	[DeduplicatedMethod]
	public int get_Width() { }

	[CallerCount(Count = 18)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public void set(int x, int y, byte value) { }

	[CallerCount(Count = 18)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public void set(int x, int y, bool value) { }

	[CallerCount(Count = 18)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public void set_Item(int x, int y, int value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(StringBuilder))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public virtual string ToString() { }

}

