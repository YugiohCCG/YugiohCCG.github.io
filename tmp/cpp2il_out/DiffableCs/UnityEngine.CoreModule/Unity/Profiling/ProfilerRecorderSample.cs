namespace Unity.Profiling;

[DebuggerDisplay("Value = {Value}; Count = {Count}")]
[UsedByNativeCode]
public struct ProfilerRecorderSample
{
	private long value; //Field offset: 0x0
	private long count; //Field offset: 0x8
	private long refValue; //Field offset: 0x10

	public long Count
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public long get_Count() { }

}

