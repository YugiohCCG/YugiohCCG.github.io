namespace ZXing.PDF417.Internal;

public sealed class Dimensions
{
	private readonly int minCols; //Field offset: 0x10
	private readonly int maxCols; //Field offset: 0x14
	private readonly int minRows; //Field offset: 0x18
	private readonly int maxRows; //Field offset: 0x1C

	public int MaxCols
	{
		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		 get { } //Length: 4
	}

	public int MaxRows
	{
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 4
	}

	public int MinCols
	{
		[CallerCount(Count = 94)]
		[DeduplicatedMethod]
		 get { } //Length: 4
	}

	public int MinRows
	{
		[CallerCount(Count = 7)]
		[DeduplicatedMethod]
		 get { } //Length: 4
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public Dimensions(int minCols, int maxCols, int minRows, int maxRows) { }

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public int get_MaxCols() { }

	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	public int get_MaxRows() { }

	[CallerCount(Count = 94)]
	[DeduplicatedMethod]
	public int get_MinCols() { }

	[CallerCount(Count = 7)]
	[DeduplicatedMethod]
	public int get_MinRows() { }

}

