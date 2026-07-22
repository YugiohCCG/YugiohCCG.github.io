namespace Unity.Jobs;

[Extension]
[Obsolete("'JobParallelIndexListExtensions' has been deprecated; Use 'IJobFilterExtensions' instead.", False)]
public static class JobParallelIndexListExtensions
{

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	[Extension]
	[Obsolete("The signature for 'ScheduleAppend' has changed. 'innerloopBatchCount' is no longer part of this API.", False)]
	public static JobHandle ScheduleAppend(T jobData, NativeList<Int32> indices, int arrayLength, int innerloopBatchCount, JobHandle dependsOn = null) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	[Extension]
	[Obsolete("The signature for 'ScheduleFilter' has changed. 'innerloopBatchCount' is no longer part of this API.")]
	public static JobHandle ScheduleFilter(T jobData, NativeList<Int32> indices, int innerloopBatchCount, JobHandle dependsOn = null) { }

}

