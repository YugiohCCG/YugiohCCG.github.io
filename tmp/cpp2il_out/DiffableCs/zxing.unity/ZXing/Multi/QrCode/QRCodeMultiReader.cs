namespace ZXing.Multi.QrCode;

public sealed class QRCodeMultiReader : QRCodeReader, MultipleBarcodeReader
{
	private static readonly ResultPoint[] NO_POINTS; //Field offset: 0x0

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private static QRCodeMultiReader() { }

	[CalledBy(Type = typeof(BarcodeReaderGeneric`1), Member = "DecodeMultiple", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LuminanceSource)}, ReturnType = typeof(Result[]))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(QRCodeReader), Member = ".ctor", ReturnType = typeof(void))]
	public QRCodeMultiReader() { }

	[CallerCount(Count = 0)]
	[ContainsInvalidInstructions]
	public override Result[] decodeMultiple(BinaryBitmap image) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BinaryBitmap), Member = "get_BlackMatrix", ReturnType = typeof(BitMatrix))]
	[Calls(Type = typeof(MultiDetector), Member = "detectMulti", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IDictionary`2<ZXing.DecodeHintType, System.Object>)}, ReturnType = typeof(DetectorResult[]))]
	[Calls(Type = typeof(Decoder), Member = "decode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitMatrix), typeof(System.Collections.Generic.IDictionary`2<ZXing.DecodeHintType, System.Object>)}, ReturnType = typeof(DecoderResult))]
	[Calls(Type = typeof(QRCodeDecoderMetaData), Member = "applyMirroredCorrection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ResultPoint[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Result), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Byte[]), typeof(ResultPoint[]), typeof(BarcodeFormat)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Result), Member = "putMetadata", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ResultMetadataType), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DecoderResult), Member = "get_StructuredAppend", ReturnType = typeof(bool))]
	[Calls(Type = typeof(QRCodeMultiReader), Member = "ProcessStructuredAppend", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<ZXing.Result>)}, ReturnType = typeof(System.Collections.Generic.List`1<ZXing.Result>))]
	[Calls(Type = typeof(List`1), Member = "ToArray", ReturnType = "T[]")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	public override Result[] decodeMultiple(BinaryBitmap image, IDictionary<DecodeHintType, Object> hints) { }

	[CalledBy(Type = typeof(QRCodeMultiReader), Member = "decodeMultiple", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryBitmap), typeof(System.Collections.Generic.IDictionary`2<ZXing.DecodeHintType, System.Object>)}, ReturnType = typeof(Result[]))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Sort", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Comparison`1<System.Object>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Result), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Byte[]), typeof(ResultPoint[]), typeof(BarcodeFormat)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Result), Member = "putMetadata", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ResultMetadataType), typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 13)]
	[CallsUnknownMethods(Count = 61)]
	private List<Result> ProcessStructuredAppend(List<Result> results) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 5)]
	private int SaSequenceSort(Result a, Result b) { }

}

