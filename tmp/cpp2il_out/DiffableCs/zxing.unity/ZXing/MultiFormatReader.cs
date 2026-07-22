namespace ZXing;

public sealed class MultiFormatReader : Reader
{
	private IDictionary<DecodeHintType, Object> hints; //Field offset: 0x10
	private IList<Reader> readers; //Field offset: 0x18

	public IDictionary<DecodeHintType, Object> Hints
	{
		[CalledBy(Type = typeof(MultiFormatReader), Member = "decode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryBitmap)}, ReturnType = typeof(Result))]
		[CalledBy(Type = typeof(MultiFormatReader), Member = "decode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryBitmap), typeof(System.Collections.Generic.IDictionary`2<ZXing.DecodeHintType, System.Object>)}, ReturnType = typeof(Result))]
		[CalledBy(Type = typeof(MultiFormatReader), Member = "decodeWithState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryBitmap)}, ReturnType = typeof(Result))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(MultiFormatOneDReader), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IDictionary`2<ZXing.DecodeHintType, System.Object>)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(QRCodeReader), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(DataMatrixReader), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(MaxiCodeReader), Member = ".ctor", ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 6)]
		[CallsUnknownMethods(Count = 41)]
		 set { } //Length: 1996
	}

	[CallerCount(Count = 2180)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public MultiFormatReader() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MultiFormatReader), Member = "set_Hints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IDictionary`2<ZXing.DecodeHintType, System.Object>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MultiFormatReader), Member = "decodeInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryBitmap)}, ReturnType = typeof(Result))]
	public override Result decode(BinaryBitmap image) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MultiFormatReader), Member = "set_Hints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IDictionary`2<ZXing.DecodeHintType, System.Object>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MultiFormatReader), Member = "decodeInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryBitmap)}, ReturnType = typeof(Result))]
	public override Result decode(BinaryBitmap image, IDictionary<DecodeHintType, Object> hints) { }

	[CalledBy(Type = typeof(MultiFormatReader), Member = "decode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryBitmap)}, ReturnType = typeof(Result))]
	[CalledBy(Type = typeof(MultiFormatReader), Member = "decode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryBitmap), typeof(System.Collections.Generic.IDictionary`2<ZXing.DecodeHintType, System.Object>)}, ReturnType = typeof(Result))]
	[CalledBy(Type = typeof(MultiFormatReader), Member = "decodeWithState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryBitmap)}, ReturnType = typeof(Result))]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 10)]
	private Result decodeInternal(BinaryBitmap image) { }

	[CalledBy(Type = typeof(BarcodeReaderGeneric`1), Member = "Decode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LuminanceSource)}, ReturnType = typeof(Result))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(MultiFormatReader), Member = "set_Hints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IDictionary`2<ZXing.DecodeHintType, System.Object>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MultiFormatReader), Member = "decodeInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryBitmap)}, ReturnType = typeof(Result))]
	public Result decodeWithState(BinaryBitmap image) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 10)]
	public override void reset() { }

	[CalledBy(Type = typeof(MultiFormatReader), Member = "decode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryBitmap)}, ReturnType = typeof(Result))]
	[CalledBy(Type = typeof(MultiFormatReader), Member = "decode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryBitmap), typeof(System.Collections.Generic.IDictionary`2<ZXing.DecodeHintType, System.Object>)}, ReturnType = typeof(Result))]
	[CalledBy(Type = typeof(MultiFormatReader), Member = "decodeWithState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryBitmap)}, ReturnType = typeof(Result))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(MultiFormatOneDReader), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IDictionary`2<ZXing.DecodeHintType, System.Object>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(QRCodeReader), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(DataMatrixReader), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(MaxiCodeReader), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 41)]
	public void set_Hints(IDictionary<DecodeHintType, Object> value) { }

}

