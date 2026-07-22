namespace Unity.Jobs;

[Extension]
public static class IJobExtensions
{
	public struct JobStruct
	{
		public sealed class ExecuteJobFunction : MulticastDelegate
		{

			[CallerCount(Count = 4)]
			[CallsUnknownMethods(Count = 4)]
			[DeduplicatedMethod]
			public ExecuteJobFunction(object object, IntPtr method) { }

			[CallerCount(Count = 0)]
			[CallsDeduplicatedMethods(Count = 1)]
			[DeduplicatedMethod]
			public override void Invoke(ref T data, IntPtr additionalPtr, IntPtr bufferRangePatchData, ref JobRanges ranges, int jobIndex) { }

		}

		internal static readonly SharedStatic<IntPtr> jobReflectionData; //Field offset: 0x0

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SharedStatic`1), Member = "GetOrCreate", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TContext"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = "Unity.Collections.LowLevel.Unsafe.BurstLike+SharedStatic`1<T>")]
		[CallsUnknownMethods(Count = 3)]
		[DeduplicatedMethod]
		private static JobStruct`1() { }

		[CallerCount(Count = 0)]
		[Calls(Type = "Unity.Collections.SortJob`2+SegmentSortMerge", Member = "Execute", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		public static void Execute(ref T data, IntPtr additionalPtr, IntPtr bufferRangePatchData, ref JobRanges ranges, int jobIndex) { }

		[BurstDiscard]
		[CalledBy(Type = typeof(IJobExtensions), Member = "GetReflectionData", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(IntPtr))]
		[CalledBy(Type = typeof(IJobExtensions), Member = "Schedule", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", typeof(JobHandle)}, ReturnType = typeof(JobHandle))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
		[Calls(Type = typeof(JobsUtility), Member = "CreateJobReflectionData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(object), typeof(object), typeof(object)}, ReturnType = typeof(IntPtr))]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 13)]
		[DeduplicatedMethod]
		internal static void Initialize() { }

	}


	[CalledBy(Type = typeof(NativeArrayDisposeJob), Member = "RegisterNativeArrayDisposeJobReflectionData", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Unity.Jobs.IJobExtensions+JobStruct`1<Unity.Collections.NativeArrayDisposeJob>), Member = "Initialize", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public static void EarlyJobInit() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JobStruct`1), Member = "Initialize", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	private static IntPtr GetReflectionData() { }

	[CalledBy(Type = "Unity.Collections.SortJob`2", Member = "Schedule", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JobHandle)}, ReturnType = typeof(JobHandle))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(JobStruct`1), Member = "Initialize", ReturnType = typeof(void))]
	[Calls(Type = typeof(JobScheduleParameters), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(IntPtr), typeof(JobHandle), typeof(ScheduleMode)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(JobsUtility), Member = "Schedule", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JobScheduleParameters&)}, ReturnType = typeof(JobHandle))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	[DeduplicatedMethod]
	[Extension]
	public static JobHandle Schedule(T jobData, JobHandle dependsOn = null) { }

}

