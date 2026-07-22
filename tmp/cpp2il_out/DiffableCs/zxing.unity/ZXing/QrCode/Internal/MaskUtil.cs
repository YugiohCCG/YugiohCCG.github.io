namespace ZXing.QrCode.Internal;

public static class MaskUtil
{
	private const int N1 = 3; //Field offset: 0x0
	private const int N2 = 3; //Field offset: 0x0
	private const int N3 = 40; //Field offset: 0x0
	private const int N4 = 10; //Field offset: 0x0

	[CalledBy(Type = typeof(Encoder), Member = "calculateMaskPenalty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ByteMatrix)}, ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static int applyMaskPenaltyRule1(ByteMatrix matrix) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static int applyMaskPenaltyRule1Internal(ByteMatrix matrix, bool isHorizontal) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public static int applyMaskPenaltyRule2(ByteMatrix matrix) { }

	[CalledBy(Type = typeof(Encoder), Member = "calculateMaskPenalty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ByteMatrix)}, ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static int applyMaskPenaltyRule3(ByteMatrix matrix) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	public static int applyMaskPenaltyRule4(ByteMatrix matrix) { }

	[CalledBy(Type = typeof(MatrixUtil), Member = "embedDataBits", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitArray), typeof(int), typeof(ByteMatrix)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	[ContainsUnimplementedInstructions]
	public static bool getDataMaskBit(int maskPattern, int x, int y) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static bool isWhiteHorizontal(Byte[] rowArray, int from, int to) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static bool isWhiteVertical(Byte[][] array, int col, int from, int to) { }

}

