namespace ZXing.PDF417.Internal;

public sealed class DetectionResultRowIndicatorColumn : DetectionResultColumn
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private bool <IsLeft>k__BackingField; //Field offset: 0x20

	public bool IsLeft
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 3)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DetectionResultColumn), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BoundingBox)}, ReturnType = typeof(void))]
	public DetectionResultRowIndicatorColumn(BoundingBox box, bool isLeft) { }

	[CalledBy(Type = typeof(DetectionResult), Member = "getDetectionResultColumns", ReturnType = typeof(DetectionResultColumn[]))]
	[CalledBy(Type = typeof(DetectionResult), Member = "adjustIndicatorColumnRowNumbers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DetectionResultColumn)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(DetectionResultRowIndicatorColumn), Member = "removeIncorrectCodewords", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Codeword[]), typeof(BarcodeMetadata)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Math), Member = "Max", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	[ContainsUnimplementedInstructions]
	public int adjustCompleteIndicatorColumnRowNumbers(BarcodeMetadata metadata) { }

	[CalledBy(Type = typeof(DetectionResultRowIndicatorColumn), Member = "getRowHeights", ReturnType = typeof(Int32[]))]
	[CalledBy(Type = typeof(PDF417ScanningDecoder), Member = "adjustBoundingBox", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DetectionResultRowIndicatorColumn)}, ReturnType = typeof(BoundingBox))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Math), Member = "Max", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	public int adjustIncompleteIndicatorColumnRowNumbers(BarcodeMetadata metadata) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public bool get_IsLeft() { }

	[CalledBy(Type = typeof(DetectionResultRowIndicatorColumn), Member = "getRowHeights", ReturnType = typeof(Int32[]))]
	[CalledBy(Type = typeof(PDF417ScanningDecoder), Member = "merge", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DetectionResultRowIndicatorColumn), typeof(DetectionResultRowIndicatorColumn)}, ReturnType = typeof(DetectionResult))]
	[CalledBy(Type = typeof(PDF417ScanningDecoder), Member = "adjustBoundingBox", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DetectionResultRowIndicatorColumn)}, ReturnType = typeof(BoundingBox))]
	[CalledBy(Type = typeof(PDF417ScanningDecoder), Member = "getBarcodeMetadata", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DetectionResultRowIndicatorColumn), typeof(DetectionResultRowIndicatorColumn)}, ReturnType = typeof(BarcodeMetadata))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(BarcodeValue), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(BarcodeValue), Member = "setValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BarcodeValue), Member = "getValue", ReturnType = typeof(Int32[]))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	public BarcodeMetadata getBarcodeMetadata() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DetectionResultRowIndicatorColumn), Member = "getBarcodeMetadata", ReturnType = typeof(BarcodeMetadata))]
	[Calls(Type = typeof(DetectionResultRowIndicatorColumn), Member = "adjustIncompleteIndicatorColumnRowNumbers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BarcodeMetadata)}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 2)]
	public Int32[] getRowHeights() { }

	[CalledBy(Type = typeof(DetectionResultRowIndicatorColumn), Member = "adjustCompleteIndicatorColumnRowNumbers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BarcodeMetadata)}, ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	private void removeIncorrectCodewords(Codeword[] codewords, BarcodeMetadata metadata) { }

	[CallerCount(Count = 3)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_IsLeft(bool value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	public void setRowNumbers() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DetectionResultColumn), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[])}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 18)]
	public virtual string ToString() { }

}

