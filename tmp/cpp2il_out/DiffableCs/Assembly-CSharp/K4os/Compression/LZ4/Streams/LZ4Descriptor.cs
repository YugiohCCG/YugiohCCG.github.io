namespace K4os.Compression.LZ4.Streams;

public class LZ4Descriptor : ILZ4Descriptor
{
	[CompilerGenerated]
	private readonly Nullable<Int64> <ContentLength>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private readonly bool <ContentChecksum>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private readonly bool <Chaining>k__BackingField; //Field offset: 0x21
	[CompilerGenerated]
	private readonly bool <BlockChecksum>k__BackingField; //Field offset: 0x22
	[CompilerGenerated]
	private readonly Nullable<UInt32> <Dictionary>k__BackingField; //Field offset: 0x24
	[CompilerGenerated]
	private readonly int <BlockSize>k__BackingField; //Field offset: 0x2C

	public override bool BlockChecksum
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public override int BlockSize
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 4
	}

	public override bool Chaining
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public override bool ContentChecksum
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public override Nullable<Int64> ContentLength
	{
		[CallerCount(Count = 17)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 11
	}

	public override Nullable<UInt32> Dictionary
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public LZ4Descriptor(Nullable<Int64> contentLength, bool contentChecksum, bool chaining, bool blockChecksum, Nullable<UInt32> dictionary, int blockSize) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public override bool get_BlockChecksum() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public override int get_BlockSize() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public override bool get_Chaining() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public override bool get_ContentChecksum() { }

	[CallerCount(Count = 17)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public override Nullable<Int64> get_ContentLength() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public override Nullable<UInt32> get_Dictionary() { }

}

