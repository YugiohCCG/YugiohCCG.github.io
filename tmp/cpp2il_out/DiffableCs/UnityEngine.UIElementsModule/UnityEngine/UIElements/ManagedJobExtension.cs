namespace UnityEngine.UIElements;

[Extension]
internal static class ManagedJobExtension
{

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	[Extension]
	public static JobHandle ScheduleOrRunJob(T jobData, int arrayLength, int innerloopBatchCount, JobHandle dependsOn = null) { }

}

