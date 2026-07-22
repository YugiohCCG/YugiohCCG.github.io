namespace ZXing.Multi;

public sealed class ByQuadrantReader : Reader
{
	private readonly Reader delegate; //Field offset: 0x10

	[CallerCount(Count = 98)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public ByQuadrantReader(Reader delegate) { }

	[CallerCount(Count = 0)]
	[ContainsInvalidInstructions]
	public override Result decode(BinaryBitmap image) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BinaryBitmap), Member = "get_Width", ReturnType = typeof(int))]
	[Calls(Type = typeof(BinaryBitmap), Member = "get_Height", ReturnType = typeof(int))]
	[Calls(Type = typeof(BinaryBitmap), Member = "crop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(BinaryBitmap))]
	[CallsUnknownMethods(Count = 6)]
	public override Result decode(BinaryBitmap image, IDictionary<DecodeHintType, Object> hints) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public override void reset() { }

}

