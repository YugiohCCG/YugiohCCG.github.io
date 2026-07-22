namespace UnityEngine.Jobs;

[Extension]
public static class IJobParallelForTransformExtensions
{
	public struct TransformParallelForLoopStruct
	{
		internal sealed class ExecuteJobFunction : MulticastDelegate
		{

			[CallerCount(Count = 4)]
			[CallsUnknownMethods(Count = 4)]
			[DeduplicatedMethod]
			public ExecuteJobFunction(object object, IntPtr method) { }

			[CallerCount(Count = 0)]
			[CallsDeduplicatedMethods(Count = 1)]
			[DeduplicatedMethod]
			public override void Invoke(ref T jobData, IntPtr additionalPtr, IntPtr bufferRangePatchData, ref JobRanges ranges, int jobIndex) { }

		}

		private struct TransformJobData
		{
			public IntPtr TransformAccessArray; //Field offset: 0x0
			public int IsReadOnly; //Field offset: 0x0

		}

		internal static readonly SharedStatic<IntPtr> jobReflectionData; //Field offset: 0x0

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 5)]
		[DeduplicatedMethod]
		private static TransformParallelForLoopStruct`1() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(TransformAccessArray), Member = "GetSortedToUserIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(IntPtr))]
		[Calls(Type = typeof(TransformAccessArray), Member = "GetSortedTransformAccess", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(IntPtr))]
		[Calls(Type = typeof(JobsUtility), Member = "GetJobRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JobRanges&), typeof(int), typeof(Int32&), typeof(Int32&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(JobsUtility), Member = "GetWorkStealingRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JobRanges&), typeof(int), typeof(Int32&), typeof(Int32&)}, ReturnType = typeof(bool))]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 17)]
		[DeduplicatedMethod]
		public static void Execute(ref T jobData, IntPtr jobData2, IntPtr bufferRangePatchData, ref JobRanges ranges, int jobIndex) { }

		[BurstDiscard]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
		[Calls(Type = typeof(JobsUtility), Member = "CreateJobReflectionData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(object), typeof(object), typeof(object)}, ReturnType = typeof(IntPtr))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 15)]
		[DeduplicatedMethod]
		internal static void Initialize() { }

	}


	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	private static IntPtr GetReflectionData() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JobScheduleParameters), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(IntPtr), typeof(JobHandle), typeof(ScheduleMode)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(JobsUtility), Member = "ScheduleParallelForTransform", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JobScheduleParameters&), typeof(IntPtr)}, ReturnType = typeof(JobHandle))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Extension]
	public static JobHandle Schedule(T jobData, TransformAccessArray transforms, JobHandle dependsOn = null) { }

}

