namespace K4os.Compression.LZ4.Streams.Internal;

[IsReadOnly]
internal struct BlockInfo
{
	private readonly Byte[] _buffer; //Field offset: 0x0
	private readonly int _length; //Field offset: 0x8

	public Byte[] Buffer
	{
		[CallerCount(Count = 138)]
		[DeduplicatedMethod]
		 get { } //Length: 4
	}

	public bool Compressed
	{
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 8
	}

	public int Length
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 74
	}

	public int Offset
	{
		[CallerCount(Count = 182)]
		[DeduplicatedMethod]
		 get { } //Length: 3
	}

	public bool Ready
	{
		[CallerCount(Count = 22)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		 get { } //Length: 8
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public BlockInfo(Byte[] buffer, EncoderAction action, int length) { }

	[CallerCount(Count = 138)]
	[DeduplicatedMethod]
	public Byte[] get_Buffer() { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public bool get_Compressed() { }

	[CallerCount(Count = 0)]
	public int get_Length() { }

	[CallerCount(Count = 182)]
	[DeduplicatedMethod]
	public int get_Offset() { }

	[CallerCount(Count = 22)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public bool get_Ready() { }

}

