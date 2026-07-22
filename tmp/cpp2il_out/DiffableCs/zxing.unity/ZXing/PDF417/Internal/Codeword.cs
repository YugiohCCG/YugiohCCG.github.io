namespace ZXing.PDF417.Internal;

public sealed class Codeword
{
	private static readonly int BARCODE_ROW_UNKNOWN; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private int <StartX>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private int <EndX>k__BackingField; //Field offset: 0x14
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private int <Bucket>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private int <Value>k__BackingField; //Field offset: 0x1C
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private int <RowNumber>k__BackingField; //Field offset: 0x20

	public private int Bucket
	{
		[CallerCount(Count = 7)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 4
		[CallerCount(Count = 3)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private set { } //Length: 4
	}

	public private int EndX
	{
		[CallerCount(Count = 2)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 4
		[CallerCount(Count = 5)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private set { } //Length: 4
	}

	public bool HasValidRowNumber
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Codeword), Member = "IsValidRowNumber", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
		 get { } //Length: 11
	}

	public int RowNumber
	{
		[CallerCount(Count = 2)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 4
		[CallerCount(Count = 2)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	public private int StartX
	{
		[CallerCount(Count = 94)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 4
		[CallerCount(Count = 7)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private set { } //Length: 4
	}

	public private int Value
	{
		[CallerCount(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 4
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private set { } //Length: 4
	}

	public int Width
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 7
	}

	[CallerCount(Count = 0)]
	private static Codeword() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public Codeword(int startX, int endX, int bucket, int value) { }

	[CallerCount(Count = 7)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public int get_Bucket() { }

	[CallerCount(Count = 2)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public int get_EndX() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Codeword), Member = "IsValidRowNumber", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	public bool get_HasValidRowNumber() { }

	[CallerCount(Count = 2)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public int get_RowNumber() { }

	[CallerCount(Count = 94)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public int get_StartX() { }

	[CallerCount(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public int get_Value() { }

	[CallerCount(Count = 0)]
	public int get_Width() { }

	[CalledBy(Type = typeof(Codeword), Member = "get_HasValidRowNumber", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DetectionResult), Member = "getDetectionResultColumns", ReturnType = typeof(DetectionResultColumn[]))]
	[CalledBy(Type = typeof(DetectionResult), Member = "adjustRowNumbers", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(DetectionResult), Member = "adjustRowNumbersByRow", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(DetectionResult), Member = "adjustRowNumbersFromBothRI", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DetectionResult), Member = "adjustRowNumbersFromRRI", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(DetectionResult), Member = "adjustRowNumbersFromLRI", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(DetectionResult), Member = "adjustRowNumberIfValid", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(Codeword)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(DetectionResult), Member = "adjustRowNumbers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(Codeword[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DetectionResult), Member = "adjustRowNumber", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Codeword), typeof(Codeword)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 20)]
	[ContainsUnimplementedInstructions]
	public bool IsValidRowNumber(int rowNumber) { }

	[CallerCount(Count = 3)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void set_Bucket(int value) { }

	[CallerCount(Count = 5)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void set_EndX(int value) { }

	[CallerCount(Count = 2)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_RowNumber(int value) { }

	[CallerCount(Count = 7)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void set_StartX(int value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void set_Value(int value) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public void setRowNumberAsRowIndicatorColumn() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	public virtual string ToString() { }

}

