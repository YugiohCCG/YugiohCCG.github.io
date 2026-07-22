namespace ZXing.PDF417.Internal;

public sealed class BoundingBox
{
	private readonly BitMatrix image; //Field offset: 0x10
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private ResultPoint <TopLeft>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private ResultPoint <TopRight>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private ResultPoint <BottomLeft>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private ResultPoint <BottomRight>k__BackingField; //Field offset: 0x30
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private int <MinX>k__BackingField; //Field offset: 0x38
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private int <MaxX>k__BackingField; //Field offset: 0x3C
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private int <MinY>k__BackingField; //Field offset: 0x40
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private int <MaxY>k__BackingField; //Field offset: 0x44

	public private ResultPoint BottomLeft
	{
		[CallerCount(Count = 15)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private set { } //Length: 13
	}

	public private ResultPoint BottomRight
	{
		[CallerCount(Count = 62)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private set { } //Length: 13
	}

	public private int MaxX
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 4
		[CallerCount(Count = 11)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private set { } //Length: 4
	}

	public private int MaxY
	{
		[CallerCount(Count = 10)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 4
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private set { } //Length: 4
	}

	public private int MinX
	{
		[CallerCount(Count = 7)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 4
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private set { } //Length: 4
	}

	public private int MinY
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

	public private ResultPoint TopLeft
	{
		[CallerCount(Count = 31)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 9)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private set { } //Length: 13
	}

	public private ResultPoint TopRight
	{
		[CallerCount(Count = 12)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 10)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private set { } //Length: 13
	}

	[CalledBy(Type = typeof(BoundingBox), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitMatrix), typeof(ResultPoint), typeof(ResultPoint), typeof(ResultPoint), typeof(ResultPoint)}, ReturnType = typeof(BoundingBox))]
	[CalledBy(Type = typeof(BoundingBox), Member = "merge", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BoundingBox), typeof(BoundingBox)}, ReturnType = typeof(BoundingBox))]
	[CalledBy(Type = typeof(PDF417ScanningDecoder), Member = "decode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitMatrix), typeof(ResultPoint), typeof(ResultPoint), typeof(ResultPoint), typeof(ResultPoint), typeof(int), typeof(int)}, ReturnType = typeof(DecoderResult))]
	[CalledBy(Type = typeof(PDF417ScanningDecoder), Member = "merge", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DetectionResultRowIndicatorColumn), typeof(DetectionResultRowIndicatorColumn)}, ReturnType = typeof(DetectionResult))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(BoundingBox), Member = "calculateMinMaxValues", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	private BoundingBox(BitMatrix image, ResultPoint topLeft, ResultPoint bottomLeft, ResultPoint topRight, ResultPoint bottomRight) { }

	[CalledBy(Type = typeof(PDF417ScanningDecoder), Member = "adjustBoundingBox", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DetectionResultRowIndicatorColumn)}, ReturnType = typeof(BoundingBox))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ResultPoint), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BoundingBox), Member = "calculateMinMaxValues", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 6)]
	[ContainsUnimplementedInstructions]
	public BoundingBox addMissingRows(int missingStartRows, int missingEndRows, bool isLeft) { }

	[CalledBy(Type = typeof(BoundingBox), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitMatrix), typeof(ResultPoint), typeof(ResultPoint), typeof(ResultPoint), typeof(ResultPoint)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BoundingBox), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BoundingBox)}, ReturnType = typeof(BoundingBox))]
	[CalledBy(Type = typeof(BoundingBox), Member = "addMissingRows", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(bool)}, ReturnType = typeof(BoundingBox))]
	[CalledBy(Type = typeof(BoundingBox), Member = "SetBottomRight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ResultPoint)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DetectionResultColumn), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BoundingBox)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(ResultPoint), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Math), Member = "Min", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(Math), Member = "Max", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(float))]
	[CallsDeduplicatedMethods(Count = 12)]
	[CallsUnknownMethods(Count = 4)]
	[ContainsUnimplementedInstructions]
	private void calculateMinMaxValues() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BoundingBox), Member = "calculateMinMaxValues", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	public static BoundingBox Create(BoundingBox box) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BoundingBox), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitMatrix), typeof(ResultPoint), typeof(ResultPoint), typeof(ResultPoint), typeof(ResultPoint)}, ReturnType = typeof(void))]
	public static BoundingBox Create(BitMatrix image, ResultPoint topLeft, ResultPoint bottomLeft, ResultPoint topRight, ResultPoint bottomRight) { }

	[CallerCount(Count = 15)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public ResultPoint get_BottomLeft() { }

	[CallerCount(Count = 62)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public ResultPoint get_BottomRight() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public int get_MaxX() { }

	[CallerCount(Count = 10)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public int get_MaxY() { }

	[CallerCount(Count = 7)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public int get_MinX() { }

	[CallerCount(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public int get_MinY() { }

	[CallerCount(Count = 31)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public ResultPoint get_TopLeft() { }

	[CallerCount(Count = 12)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public ResultPoint get_TopRight() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BoundingBox), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitMatrix), typeof(ResultPoint), typeof(ResultPoint), typeof(ResultPoint), typeof(ResultPoint)}, ReturnType = typeof(void))]
	internal static BoundingBox merge(BoundingBox leftBox, BoundingBox rightBox) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void set_BottomLeft(ResultPoint value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void set_BottomRight(ResultPoint value) { }

	[CallerCount(Count = 11)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void set_MaxX(int value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void set_MaxY(int value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void set_MinX(int value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void set_MinY(int value) { }

	[CallerCount(Count = 9)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void set_TopLeft(ResultPoint value) { }

	[CallerCount(Count = 10)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void set_TopRight(ResultPoint value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BoundingBox), Member = "calculateMinMaxValues", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	internal void SetBottomRight(ResultPoint bottomRight) { }

}

