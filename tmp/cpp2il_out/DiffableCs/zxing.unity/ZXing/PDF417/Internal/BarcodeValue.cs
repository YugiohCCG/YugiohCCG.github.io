namespace ZXing.PDF417.Internal;

public sealed class BarcodeValue
{
	private readonly IDictionary<Int32, Int32> values; //Field offset: 0x10

	[CalledBy(Type = typeof(DetectionResultRowIndicatorColumn), Member = "getBarcodeMetadata", ReturnType = typeof(BarcodeMetadata))]
	[CalledBy(Type = typeof(PDF417ScanningDecoder), Member = "createBarcodeMatrix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DetectionResult)}, ReturnType = typeof(BarcodeValue[][]))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public BarcodeValue() { }

	[CalledBy(Type = typeof(PDF417ScanningDecoder), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BarcodeValue[][])}, ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public int getConfidence(int barcodeValue) { }

	[CalledBy(Type = typeof(DetectionResultRowIndicatorColumn), Member = "getBarcodeMetadata", ReturnType = typeof(BarcodeMetadata))]
	[CalledBy(Type = typeof(PDF417ScanningDecoder), Member = "adjustCodewordCount", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DetectionResult), typeof(BarcodeValue[][])}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(PDF417ScanningDecoder), Member = "createDecoderResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DetectionResult)}, ReturnType = typeof(DecoderResult))]
	[CalledBy(Type = typeof(PDF417ScanningDecoder), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BarcodeValue[][])}, ReturnType = typeof(string))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(List`1), Member = "ToArray", ReturnType = "T[]")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 12)]
	public Int32[] getValue() { }

	[CalledBy(Type = typeof(DetectionResultRowIndicatorColumn), Member = "getBarcodeMetadata", ReturnType = typeof(BarcodeMetadata))]
	[CalledBy(Type = typeof(PDF417ScanningDecoder), Member = "adjustCodewordCount", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DetectionResult), typeof(BarcodeValue[][])}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(PDF417ScanningDecoder), Member = "createDecoderResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DetectionResult)}, ReturnType = typeof(DecoderResult))]
	[CalledBy(Type = typeof(PDF417ScanningDecoder), Member = "createBarcodeMatrix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DetectionResult)}, ReturnType = typeof(BarcodeValue[][]))]
	[CallerCount(Count = 7)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public void setValue(int value) { }

}

