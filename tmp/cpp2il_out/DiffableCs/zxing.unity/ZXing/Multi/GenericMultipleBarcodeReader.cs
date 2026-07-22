namespace ZXing.Multi;

public sealed class GenericMultipleBarcodeReader : MultipleBarcodeReader, Reader
{
	private const int MIN_DIMENSION_TO_RECUR = 30; //Field offset: 0x0
	private const int MAX_DEPTH = 4; //Field offset: 0x0
	private readonly Reader _delegate; //Field offset: 0x10

	[CallerCount(Count = 98)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public GenericMultipleBarcodeReader(Reader delegate) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public override Result decode(BinaryBitmap image) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public override Result decode(BinaryBitmap image, IDictionary<DecodeHintType, Object> hints) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GenericMultipleBarcodeReader), Member = "doDecodeMultiple", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryBitmap), typeof(System.Collections.Generic.IDictionary`2<ZXing.DecodeHintType, System.Object>), typeof(System.Collections.Generic.IList`1<ZXing.Result>), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public override Result[] decodeMultiple(BinaryBitmap image) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GenericMultipleBarcodeReader), Member = "doDecodeMultiple", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryBitmap), typeof(System.Collections.Generic.IDictionary`2<ZXing.DecodeHintType, System.Object>), typeof(System.Collections.Generic.IList`1<ZXing.Result>), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public override Result[] decodeMultiple(BinaryBitmap image, IDictionary<DecodeHintType, Object> hints) { }

	[CalledBy(Type = typeof(GenericMultipleBarcodeReader), Member = "decodeMultiple", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryBitmap)}, ReturnType = typeof(Result[]))]
	[CalledBy(Type = typeof(GenericMultipleBarcodeReader), Member = "decodeMultiple", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryBitmap), typeof(System.Collections.Generic.IDictionary`2<ZXing.DecodeHintType, System.Object>)}, ReturnType = typeof(Result[]))]
	[CalledBy(Type = typeof(GenericMultipleBarcodeReader), Member = "doDecodeMultiple", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryBitmap), typeof(System.Collections.Generic.IDictionary`2<ZXing.DecodeHintType, System.Object>), typeof(System.Collections.Generic.IList`1<ZXing.Result>), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(string), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(GenericMultipleBarcodeReader), Member = "translateResultPoints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Result), typeof(int), typeof(int)}, ReturnType = typeof(Result))]
	[Calls(Type = typeof(BinaryBitmap), Member = "get_Width", ReturnType = typeof(int))]
	[Calls(Type = typeof(BinaryBitmap), Member = "get_Height", ReturnType = typeof(int))]
	[Calls(Type = typeof(BinaryBitmap), Member = "crop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(BinaryBitmap))]
	[Calls(Type = typeof(GenericMultipleBarcodeReader), Member = "doDecodeMultiple", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryBitmap), typeof(System.Collections.Generic.IDictionary`2<ZXing.DecodeHintType, System.Object>), typeof(System.Collections.Generic.IList`1<ZXing.Result>), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 6)]
	[ContainsUnimplementedInstructions]
	private void doDecodeMultiple(BinaryBitmap image, IDictionary<DecodeHintType, Object> hints, IList<Result> results, int xOffset, int yOffset, int currentDepth) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public override void reset() { }

	[CalledBy(Type = typeof(GenericMultipleBarcodeReader), Member = "doDecodeMultiple", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryBitmap), typeof(System.Collections.Generic.IDictionary`2<ZXing.DecodeHintType, System.Object>), typeof(System.Collections.Generic.IList`1<ZXing.Result>), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ResultPoint), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Result), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Byte[]), typeof(ResultPoint[]), typeof(BarcodeFormat)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Result), Member = "putAllMetadata", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IDictionary`2<ZXing.ResultMetadataType, System.Object>)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 6)]
	private static Result translateResultPoints(Result result, int xOffset, int yOffset) { }

}

