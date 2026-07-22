namespace ZXing.QrCode.Internal;

public sealed class QRCodeDecoderMetaData
{
	private readonly bool mirrored; //Field offset: 0x10

	public bool IsMirrored
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public QRCodeDecoderMetaData(bool mirrored) { }

	[CalledBy(Type = typeof(QRCodeMultiReader), Member = "decodeMultiple", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryBitmap), typeof(System.Collections.Generic.IDictionary`2<ZXing.DecodeHintType, System.Object>)}, ReturnType = typeof(Result[]))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 9)]
	public void applyMirroredCorrection(ResultPoint[] points) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public bool get_IsMirrored() { }

}

