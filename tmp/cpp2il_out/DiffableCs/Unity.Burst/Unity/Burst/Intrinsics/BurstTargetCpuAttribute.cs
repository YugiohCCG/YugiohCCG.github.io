namespace Unity.Burst.Intrinsics;

[AttributeUsage(AttributeTargets::Method (64), Inherited = False)]
[Preserve]
internal sealed class BurstTargetCpuAttribute : Attribute
{
	public readonly BurstTargetCpu TargetCpu; //Field offset: 0x10

	[CallerCount(Count = 31)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public BurstTargetCpuAttribute(BurstTargetCpu TargetCpu) { }

}

