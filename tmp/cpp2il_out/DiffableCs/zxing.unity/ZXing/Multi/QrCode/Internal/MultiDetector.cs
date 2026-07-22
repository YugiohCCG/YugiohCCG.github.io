namespace ZXing.Multi.QrCode.Internal;

public sealed class MultiDetector : Detector
{
	private static readonly DetectorResult[] EMPTY_DETECTOR_RESULTS; //Field offset: 0x0

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private static MultiDetector() { }

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public MultiDetector(BitMatrix image) { }

	[CalledBy(Type = typeof(QRCodeMultiReader), Member = "decodeMultiple", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryBitmap), typeof(System.Collections.Generic.IDictionary`2<ZXing.DecodeHintType, System.Object>)}, ReturnType = typeof(Result[]))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(FinderPatternFinder), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitMatrix), typeof(ResultPointCallback)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MultiFinderPatternFinder), Member = "findMulti", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IDictionary`2<ZXing.DecodeHintType, System.Object>)}, ReturnType = typeof(FinderPatternInfo[]))]
	[Calls(Type = typeof(List`1), Member = "ToArray", ReturnType = "T[]")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 6)]
	public DetectorResult[] detectMulti(IDictionary<DecodeHintType, Object> hints) { }

}

