namespace K4os.Compression.LZ4;

[IsReadOnly]
internal struct PickleHeader
{
	[CompilerGenerated]
	private readonly ushort <DataOffset>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	private readonly ushort <Flags>k__BackingField; //Field offset: 0x2
	[CompilerGenerated]
	private readonly int <ResultLength>k__BackingField; //Field offset: 0x4

	public ushort DataOffset
	{
		[CallerCount(Count = 10)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 4
	}

	public ushort Flags
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public bool IsCompressed
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 7
	}

	public int ResultLength
	{
		[CallerCount(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 4
	}

	[CallerCount(Count = 0)]
	public PickleHeader(ushort dataOffset, int resultLength, bool compressed) { }

	[CallerCount(Count = 10)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public ushort get_DataOffset() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public ushort get_Flags() { }

	[CallerCount(Count = 0)]
	public bool get_IsCompressed() { }

	[CallerCount(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public int get_ResultLength() { }

}

