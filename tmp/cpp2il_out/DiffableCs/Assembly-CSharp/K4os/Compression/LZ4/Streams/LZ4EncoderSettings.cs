namespace K4os.Compression.LZ4.Streams;

public class LZ4EncoderSettings
{
	[CompilerGenerated]
	private static readonly LZ4EncoderSettings <Default>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	private Nullable<Int64> <ContentLength>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private bool <ChainBlocks>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private int <BlockSize>k__BackingField; //Field offset: 0x24
	[CompilerGenerated]
	private LZ4Level <CompressionLevel>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	private int <ExtraMemory>k__BackingField; //Field offset: 0x2C

	public bool BlockChecksum
	{
		[CallerCount(Count = 271)]
		[DeduplicatedMethod]
		 get { } //Length: 3
	}

	public int BlockSize
	{
		[CallerCount(Count = 9)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 4
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	public bool ChainBlocks
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

	public LZ4Level CompressionLevel
	{
		[CallerCount(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 4
		[CallerCount(Count = 5)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	public bool ContentChecksum
	{
		[CallerCount(Count = 271)]
		[DeduplicatedMethod]
		 get { } //Length: 3
	}

	public Nullable<Int64> ContentLength
	{
		[CallerCount(Count = 17)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 11
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 8
	}

	internal static LZ4EncoderSettings Default
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		internal get { } //Length: 78
	}

	public Nullable<UInt32> Dictionary
	{
		[CallerCount(Count = 182)]
		[DeduplicatedMethod]
		 get { } //Length: 3
	}

	public int ExtraMemory
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 4
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private static LZ4EncoderSettings() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public LZ4EncoderSettings() { }

	[CallerCount(Count = 271)]
	[DeduplicatedMethod]
	public bool get_BlockChecksum() { }

	[CallerCount(Count = 9)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public int get_BlockSize() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public bool get_ChainBlocks() { }

	[CallerCount(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public LZ4Level get_CompressionLevel() { }

	[CallerCount(Count = 271)]
	[DeduplicatedMethod]
	public bool get_ContentChecksum() { }

	[CallerCount(Count = 17)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public Nullable<Int64> get_ContentLength() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	internal static LZ4EncoderSettings get_Default() { }

	[CallerCount(Count = 182)]
	[DeduplicatedMethod]
	public Nullable<UInt32> get_Dictionary() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public int get_ExtraMemory() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_BlockSize(int value) { }

	[CallerCount(Count = 3)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_ChainBlocks(bool value) { }

	[CallerCount(Count = 5)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_CompressionLevel(LZ4Level value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_ContentLength(Nullable<Int64> value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_ExtraMemory(int value) { }

}

