namespace ZXing.PDF417.Internal;

public class DetectionResult
{
	private const int ADJUST_ROW_NUMBER_SKIP = 2; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private BarcodeMetadata <Metadata>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private DetectionResultColumn[] <DetectionResultColumns>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private BoundingBox <Box>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private int <ColumnCount>k__BackingField; //Field offset: 0x28

	public BoundingBox Box
	{
		[CallerCount(Count = 12)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 10)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 13
	}

	public private int ColumnCount
	{
		[CallerCount(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 4
		[CallerCount(Count = 5)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private set { } //Length: 4
	}

	public DetectionResultColumn[] DetectionResultColumns
	{
		[CallerCount(Count = 31)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 9)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 13
	}

	public int ErrorCorrectionLevel
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 26
	}

	public private BarcodeMetadata Metadata
	{
		[CallerCount(Count = 106)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private set { } //Length: 13
	}

	public int RowCount
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 26
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public DetectionResult(BarcodeMetadata metadata, BoundingBox box) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DetectionResultRowIndicatorColumn), Member = "adjustCompleteIndicatorColumnRowNumbers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BarcodeMetadata)}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 1)]
	private void adjustIndicatorColumnRowNumbers(DetectionResultColumn detectionResultColumn) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Codeword), Member = "IsValidRowNumber", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	private static bool adjustRowNumber(Codeword codeword, Codeword otherCodeword) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Codeword), Member = "IsValidRowNumber", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	private static int adjustRowNumberIfValid(int rowIndicatorRowNumber, int invalidRowCounts, Codeword codeword) { }

	[CalledBy(Type = typeof(DetectionResult), Member = "getDetectionResultColumns", ReturnType = typeof(DetectionResultColumn[]))]
	[CalledBy(Type = typeof(DetectionResult), Member = "adjustRowNumbers", ReturnType = typeof(int))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Codeword), Member = "IsValidRowNumber", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 16)]
	private void adjustRowNumbers(int barcodeColumn, int codewordsRow, Codeword[] codewords) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DetectionResult), Member = "adjustRowNumbersByRow", ReturnType = typeof(int))]
	[Calls(Type = typeof(Codeword), Member = "IsValidRowNumber", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DetectionResult), Member = "adjustRowNumbers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(Codeword[])}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	private int adjustRowNumbers() { }

	[CalledBy(Type = typeof(DetectionResult), Member = "getDetectionResultColumns", ReturnType = typeof(DetectionResultColumn[]))]
	[CalledBy(Type = typeof(DetectionResult), Member = "adjustRowNumbers", ReturnType = typeof(int))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(DetectionResult), Member = "adjustRowNumbersFromBothRI", ReturnType = typeof(void))]
	[Calls(Type = typeof(Codeword), Member = "IsValidRowNumber", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 2)]
	private int adjustRowNumbersByRow() { }

	[CalledBy(Type = typeof(DetectionResult), Member = "adjustRowNumbersByRow", ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Codeword), Member = "IsValidRowNumber", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 3)]
	private void adjustRowNumbersFromBothRI() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Codeword), Member = "IsValidRowNumber", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 2)]
	private int adjustRowNumbersFromLRI() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Codeword), Member = "IsValidRowNumber", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 2)]
	private int adjustRowNumbersFromRRI() { }

	[CallerCount(Count = 12)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public BoundingBox get_Box() { }

	[CallerCount(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public int get_ColumnCount() { }

	[CallerCount(Count = 31)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public DetectionResultColumn[] get_DetectionResultColumns() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public int get_ErrorCorrectionLevel() { }

	[CallerCount(Count = 106)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public BarcodeMetadata get_Metadata() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public int get_RowCount() { }

	[CalledBy(Type = typeof(PDF417ScanningDecoder), Member = "createBarcodeMatrix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DetectionResult)}, ReturnType = typeof(BarcodeValue[][]))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DetectionResultRowIndicatorColumn), Member = "adjustCompleteIndicatorColumnRowNumbers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BarcodeMetadata)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(DetectionResult), Member = "adjustRowNumbersByRow", ReturnType = typeof(int))]
	[Calls(Type = typeof(Codeword), Member = "IsValidRowNumber", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DetectionResult), Member = "adjustRowNumbers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(Codeword[])}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	public DetectionResultColumn[] getDetectionResultColumns() { }

	[CallerCount(Count = 10)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_Box(BoundingBox value) { }

	[CallerCount(Count = 5)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void set_ColumnCount(int value) { }

	[CallerCount(Count = 9)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_DetectionResultColumns(DetectionResultColumn[] value) { }

	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void set_Metadata(BarcodeMetadata value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(StringBuilder), Member = "AppendFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider), typeof(string), typeof(Object[])}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(StringBuilder))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 18)]
	public virtual string ToString() { }

}

