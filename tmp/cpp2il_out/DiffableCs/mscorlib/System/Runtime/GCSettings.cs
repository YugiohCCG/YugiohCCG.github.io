namespace System.Runtime;

public static class GCSettings
{
	[CompilerGenerated]
	private static GCLargeObjectHeapCompactionMode <LargeObjectHeapCompactionMode>k__BackingField; //Field offset: 0x0

	public static GCLargeObjectHeapCompactionMode LargeObjectHeapCompactionMode
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::Success (2))]
		 set { } //Length: 58
	}

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::Success (2))]
	public static void set_LargeObjectHeapCompactionMode(GCLargeObjectHeapCompactionMode value) { }

}

