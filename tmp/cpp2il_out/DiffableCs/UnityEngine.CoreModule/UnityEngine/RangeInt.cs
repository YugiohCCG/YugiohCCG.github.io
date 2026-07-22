namespace UnityEngine;

public struct RangeInt
{
	public int start; //Field offset: 0x0
	public int length; //Field offset: 0x4

	public int end
	{
		[CallerCount(Count = 4)]
		[DeduplicatedMethod]
		 get { } //Length: 8
	}

	[CallerCount(Count = 104)]
	[DeduplicatedMethod]
	public RangeInt(int start, int length) { }

	[CallerCount(Count = 4)]
	[DeduplicatedMethod]
	public int get_end() { }

}

