namespace ZXing.PDF417;

public sealed class PDF417Reader : Reader, MultipleBarcodeReader
{

	[CallerCount(Count = 2180)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public PDF417Reader() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PDF417Reader), Member = "decode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryBitmap), typeof(System.Collections.Generic.IDictionary`2<ZXing.DecodeHintType, System.Object>), typeof(bool)}, ReturnType = typeof(Result[]))]
	[CallsUnknownMethods(Count = 2)]
	public override Result decode(BinaryBitmap image) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PDF417Reader), Member = "decode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryBitmap), typeof(System.Collections.Generic.IDictionary`2<ZXing.DecodeHintType, System.Object>), typeof(bool)}, ReturnType = typeof(Result[]))]
	[CallsUnknownMethods(Count = 2)]
	public override Result decode(BinaryBitmap image, IDictionary<DecodeHintType, Object> hints) { }

	[CalledBy(Type = typeof(PDF417Reader), Member = "decode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryBitmap)}, ReturnType = typeof(Result))]
	[CalledBy(Type = typeof(PDF417Reader), Member = "decode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryBitmap), typeof(System.Collections.Generic.IDictionary`2<ZXing.DecodeHintType, System.Object>)}, ReturnType = typeof(Result))]
	[CalledBy(Type = typeof(PDF417Reader), Member = "decodeMultiple", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryBitmap)}, ReturnType = typeof(Result[]))]
	[CalledBy(Type = typeof(PDF417Reader), Member = "decodeMultiple", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryBitmap), typeof(System.Collections.Generic.IDictionary`2<ZXing.DecodeHintType, System.Object>)}, ReturnType = typeof(Result[]))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(List`1), Member = "ToArray", ReturnType = "T[]")]
	[Calls(Type = typeof(Result), Member = "putMetadata", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ResultMetadataType), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Result), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Byte[]), typeof(ResultPoint[]), typeof(BarcodeFormat)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(PDF417ScanningDecoder), Member = "decode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitMatrix), typeof(ResultPoint), typeof(ResultPoint), typeof(ResultPoint), typeof(ResultPoint), typeof(int), typeof(int)}, ReturnType = typeof(DecoderResult))]
	[Calls(Type = typeof(PDF417Reader), Member = "getMaxCodewordWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ResultPoint[])}, ReturnType = typeof(int))]
	[Calls(Type = typeof(PDF417Reader), Member = "getMinCodewordWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ResultPoint[])}, ReturnType = typeof(int))]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(BitMatrix), Member = "rotate180", ReturnType = typeof(void))]
	[Calls(Type = typeof(BitMatrix), Member = "Clone", ReturnType = typeof(object))]
	[Calls(Type = typeof(Detector), Member = "detect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(BitMatrix)}, ReturnType = typeof(System.Collections.Generic.List`1<ResultPoint[]>))]
	[Calls(Type = typeof(BinaryBitmap), Member = "get_BlackMatrix", ReturnType = typeof(BitMatrix))]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 14)]
	private static Result[] decode(BinaryBitmap image, IDictionary<DecodeHintType, Object> hints, bool multiple) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PDF417Reader), Member = "decode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryBitmap), typeof(System.Collections.Generic.IDictionary`2<ZXing.DecodeHintType, System.Object>), typeof(bool)}, ReturnType = typeof(Result[]))]
	public override Result[] decodeMultiple(BinaryBitmap image) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PDF417Reader), Member = "decode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryBitmap), typeof(System.Collections.Generic.IDictionary`2<ZXing.DecodeHintType, System.Object>), typeof(bool)}, ReturnType = typeof(Result[]))]
	public override Result[] decodeMultiple(BinaryBitmap image, IDictionary<DecodeHintType, Object> hints) { }

	[CalledBy(Type = typeof(PDF417Reader), Member = "decode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryBitmap), typeof(System.Collections.Generic.IDictionary`2<ZXing.DecodeHintType, System.Object>), typeof(bool)}, ReturnType = typeof(Result[]))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Math), Member = "Max", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	private static int getMaxCodewordWidth(ResultPoint[] p) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	private static int getMaxWidth(ResultPoint p1, ResultPoint p2) { }

	[CalledBy(Type = typeof(PDF417Reader), Member = "decode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryBitmap), typeof(System.Collections.Generic.IDictionary`2<ZXing.DecodeHintType, System.Object>), typeof(bool)}, ReturnType = typeof(Result[]))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Math), Member = "Min", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	private static int getMinCodewordWidth(ResultPoint[] p) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	private static int getMinWidth(ResultPoint p1, ResultPoint p2) { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	public override void reset() { }

}

