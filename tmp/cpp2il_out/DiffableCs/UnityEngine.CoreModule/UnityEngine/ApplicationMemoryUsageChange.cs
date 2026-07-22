namespace UnityEngine;

public struct ApplicationMemoryUsageChange
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private ApplicationMemoryUsage <memoryUsage>k__BackingField; //Field offset: 0x0

	private ApplicationMemoryUsage memoryUsage
	{
		[CallerCount(Count = 11)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private set { } //Length: 3
	}

	[CallerCount(Count = 11)]
	[DeduplicatedMethod]
	public ApplicationMemoryUsageChange(ApplicationMemoryUsage usage) { }

	[CallerCount(Count = 11)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void set_memoryUsage(ApplicationMemoryUsage value) { }

}

