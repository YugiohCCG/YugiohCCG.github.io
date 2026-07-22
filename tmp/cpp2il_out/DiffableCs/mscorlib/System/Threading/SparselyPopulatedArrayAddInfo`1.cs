namespace System.Threading;

internal struct SparselyPopulatedArrayAddInfo
{
	private SparselyPopulatedArrayFragment<T> _source; //Field offset: 0x0
	private int _index; //Field offset: 0x0

	internal int Index
	{
		[CallerCount(Count = 28)]
		[DeduplicatedMethod]
		internal get { } //Length: 4
	}

	internal SparselyPopulatedArrayFragment<T> Source
	{
		[CallerCount(Count = 138)]
		[DeduplicatedMethod]
		internal get { } //Length: 4
	}

	[CallerCount(Count = 19)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	internal SparselyPopulatedArrayAddInfo`1(SparselyPopulatedArrayFragment<T> source, int index) { }

	[CallerCount(Count = 28)]
	[DeduplicatedMethod]
	internal int get_Index() { }

	[CallerCount(Count = 138)]
	[DeduplicatedMethod]
	internal SparselyPopulatedArrayFragment<T> get_Source() { }

}

