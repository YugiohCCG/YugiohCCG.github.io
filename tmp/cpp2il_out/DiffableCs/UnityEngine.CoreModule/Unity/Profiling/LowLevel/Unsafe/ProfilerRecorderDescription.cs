namespace Unity.Profiling.LowLevel.Unsafe;

[IsReadOnly]
[UsedByNativeCode]
public struct ProfilerRecorderDescription
{
	private readonly ProfilerCategory category; //Field offset: 0x0
	private readonly MarkerFlags flags; //Field offset: 0x2
	private readonly ProfilerMarkerDataType dataType; //Field offset: 0x4
	private readonly ProfilerMarkerDataUnit unitType; //Field offset: 0x5
	private readonly int reserved0; //Field offset: 0x8
	private readonly int nameUtf8Len; //Field offset: 0xC
	private readonly Byte* nameUtf8; //Field offset: 0x10

	public MarkerFlags Flags
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public MarkerFlags get_Flags() { }

}

