namespace ZXing.PDF417.Internal;

public class DetectionResultColumn
{
	private const int MAX_NEARBY_DISTANCE = 5; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private BoundingBox <Box>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private Codeword[] <Codewords>k__BackingField; //Field offset: 0x18

	public private BoundingBox Box
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

	public Codeword[] Codewords
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

	[CalledBy(Type = typeof(DetectionResultRowIndicatorColumn), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BoundingBox), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PDF417ScanningDecoder), Member = "decode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitMatrix), typeof(ResultPoint), typeof(ResultPoint), typeof(ResultPoint), typeof(ResultPoint), typeof(int), typeof(int)}, ReturnType = typeof(DecoderResult))]
	[CalledBy(Type = typeof(PDF417ScanningDecoder), Member = "getRowIndicatorColumn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitMatrix), typeof(BoundingBox), typeof(ResultPoint), typeof(bool), typeof(int), typeof(int)}, ReturnType = typeof(DetectionResultRowIndicatorColumn))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(BoundingBox), Member = "calculateMinMaxValues", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 8)]
	public DetectionResultColumn(BoundingBox box) { }

	[CallerCount(Count = 106)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public BoundingBox get_Box() { }

	[CallerCount(Count = 31)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public Codeword[] get_Codewords() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public Codeword getCodeword(int imageRow) { }

	[CalledBy(Type = typeof(PDF417ScanningDecoder), Member = "getStartColumn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DetectionResult), typeof(int), typeof(int), typeof(bool)}, ReturnType = typeof(int))]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public Codeword getCodewordNearby(int imageRow) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	internal int imageRowToCodewordIndex(int imageRow) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public int IndexForRow(int imageRow) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public int RowForIndex(int codewordIndex) { }

	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void set_Box(BoundingBox value) { }

	[CallerCount(Count = 9)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_Codewords(Codeword[] value) { }

	[CalledBy(Type = typeof(PDF417ScanningDecoder), Member = "decode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitMatrix), typeof(ResultPoint), typeof(ResultPoint), typeof(ResultPoint), typeof(ResultPoint), typeof(int), typeof(int)}, ReturnType = typeof(DecoderResult))]
	[CalledBy(Type = typeof(PDF417ScanningDecoder), Member = "getRowIndicatorColumn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitMatrix), typeof(BoundingBox), typeof(ResultPoint), typeof(bool), typeof(int), typeof(int)}, ReturnType = typeof(DetectionResultRowIndicatorColumn))]
	[CallerCount(Count = 4)]
	[CallsUnknownMethods(Count = 3)]
	public void setCodeword(int imageRow, Codeword codeword) { }

	[CalledBy(Type = typeof(DetectionResultRowIndicatorColumn), Member = "ToString", ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(StringBuilder), Member = "AppendFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider), typeof(string), typeof(Object[])}, ReturnType = typeof(StringBuilder))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 22)]
	public virtual string ToString() { }

}

