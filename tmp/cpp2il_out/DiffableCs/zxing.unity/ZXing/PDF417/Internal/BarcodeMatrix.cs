namespace ZXing.PDF417.Internal;

internal sealed class BarcodeMatrix
{
	private readonly BarcodeRow[] matrix; //Field offset: 0x10
	private int currentRow; //Field offset: 0x18
	private readonly int height; //Field offset: 0x1C
	private readonly int width; //Field offset: 0x20

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	internal BarcodeMatrix(int height, int width) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	internal BarcodeRow getCurrentRow() { }

	[CallerCount(Count = 0)]
	[ContainsInvalidInstructions]
	internal SByte[][] getMatrix() { }

	[CalledBy(Type = typeof(PDF417Writer), Member = "encode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(BarcodeFormat), typeof(int), typeof(int), typeof(System.Collections.Generic.IDictionary`2<ZXing.EncodeHintType, System.Object>)}, ReturnType = typeof(BitMatrix))]
	[CalledBy(Type = typeof(PDF417Writer), Member = "bitMatrixFromEncoder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PDF417), typeof(string), typeof(int), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(BitMatrix))]
	[CallerCount(Count = 4)]
	[CallsUnknownMethods(Count = 4)]
	[ContainsUnimplementedInstructions]
	internal SByte[][] getScaledMatrix(int xScale, int yScale) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	internal void set(int x, int y, sbyte value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	internal void startRow() { }

}

