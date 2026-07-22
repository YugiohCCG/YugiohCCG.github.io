namespace Unity.Jobs;

[Extension]
public static class IJobParallelForBatchExtensions
{
	public struct JobParallelForBatchProducer
	{
		public sealed class ExecuteJobFunction : MulticastDelegate
		{

			[CallerCount(Count = 4)]
			[CallsUnknownMethods(Count = 4)]
			[DeduplicatedMethod]
			public ExecuteJobFunction(object object, IntPtr method) { }

			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			[DeduplicatedMethod]
			public override IAsyncResult BeginInvoke(ref T jobData, IntPtr additionalPtr, IntPtr bufferRangePatchData, ref JobRanges ranges, int jobIndex, AsyncCallback callback, object object) { }

			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			[DeduplicatedMethod]
			public override void EndInvoke(ref T jobData, ref JobRanges ranges, IAsyncResult result) { }

			[CallerCount(Count = 0)]
			[CallsDeduplicatedMethods(Count = 1)]
			[DeduplicatedMethod]
			public override void Invoke(ref T jobData, IntPtr additionalPtr, IntPtr bufferRangePatchData, ref JobRanges ranges, int jobIndex) { }

		}

		internal static readonly SharedStatic<IntPtr> jobReflectionData; //Field offset: 0x0

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SharedStatic`1), Member = "GetOrCreate", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TContext"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = "Unity.Burst.SharedStatic`1<T>")]
		[CallsUnknownMethods(Count = 3)]
		[DeduplicatedMethod]
		private static JobParallelForBatchProducer`1() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(JobsUtility), Member = "GetWorkStealingRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JobRanges&), typeof(int), typeof(Int32&), typeof(Int32&)}, ReturnType = typeof(bool))]
		[Calls(Type = "UnityEngine.Rendering.CompactVisibilityMasksJob", Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		public static void Execute(ref T jobData, IntPtr additionalPtr, IntPtr bufferRangePatchData, ref JobRanges ranges, int jobIndex) { }

		[BurstDiscard]
		[CalledBy(Type = typeof(IJobParallelForBatchExtensions), Member = "EarlyJobInit", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(IJobParallelForBatchExtensions), Member = "GetReflectionData", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(IntPtr))]
		[CalledBy(Type = typeof(IJobParallelForBatchExtensions), Member = "ScheduleParallel", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", typeof(int), typeof(int), typeof(JobHandle)}, ReturnType = typeof(JobHandle))]
		[CalledBy(Type = typeof(IJobParallelForBatchExtensions), Member = "ScheduleBatch", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", typeof(int), typeof(int), typeof(JobHandle)}, ReturnType = typeof(JobHandle))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
		[Calls(Type = typeof(JobsUtility), Member = "CreateJobReflectionData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(object), typeof(object), typeof(object)}, ReturnType = typeof(IntPtr))]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 13)]
		[DeduplicatedMethod]
		internal static void Initialize() { }

	}


	[CalledBy(Type = "__JobReflectionRegistrationOutput__15867191014387474753", Member = "CreateJobReflectionData", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(JobParallelForBatchProducer`1), Member = "Initialize", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public static void EarlyJobInit() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JobParallelForBatchProducer`1), Member = "Initialize", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	private static IntPtr GetReflectionData() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JobScheduleParameters), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(IntPtr), typeof(JobHandle), typeof(ScheduleMode)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(JobsUtility), Member = "ScheduleParallelFor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JobScheduleParameters&), typeof(int), typeof(int)}, ReturnType = typeof(JobHandle))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Extension]
	public static void Run(T jobData, int arrayLength, int indicesPerJobCount) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	[Extension]
	public static void RunBatch(T jobData, int arrayLength) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Extension]
	public static void RunBatchByRef(ref T jobData, int arrayLength) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JobScheduleParameters), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(IntPtr), typeof(JobHandle), typeof(ScheduleMode)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(JobsUtility), Member = "ScheduleParallelFor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JobScheduleParameters&), typeof(int), typeof(int)}, ReturnType = typeof(JobHandle))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Extension]
	public static void RunByRef(ref T jobData, int arrayLength, int indicesPerJobCount) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JobScheduleParameters), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(IntPtr), typeof(JobHandle), typeof(ScheduleMode)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(JobsUtility), Member = "ScheduleParallelFor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JobScheduleParameters&), typeof(int), typeof(int)}, ReturnType = typeof(JobHandle))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Extension]
	public static JobHandle Schedule(T jobData, int arrayLength, int indicesPerJobCount, JobHandle dependsOn = null) { }

	[CalledBy(Type = "UnityEngine.Rendering.InstanceCuller", Member = "CreateCullJobTree", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BatchCullingContext&), typeof(BatchCullingOutput), "ReadOnly&", "ReadOnly&", "ReadOnly&", "Unity.Collections.NativeList`1<LODGroupCullingData>", "UnityEngine.Rendering.CPUDrawInstanceData", "Unity.Collections.NativeParallelHashMap`2<UInt32, BatchID>", typeof(int), typeof(float), "UnityEngine.Rendering.OcclusionCullingCommon"}, ReturnType = typeof(JobHandle))]
	[CalledBy(Type = "UnityEngine.Rendering.InstanceCuller", Member = "CreateCompactedVisibilityMaskJob", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"ReadOnly&", "Unity.Collections.NativeArray`1<Byte>", typeof(JobHandle)}, ReturnType = typeof(JobHandle))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(JobParallelForBatchProducer`1), Member = "Initialize", ReturnType = typeof(void))]
	[Calls(Type = typeof(JobScheduleParameters), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(IntPtr), typeof(JobHandle), typeof(ScheduleMode)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(JobsUtility), Member = "ScheduleParallelFor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JobScheduleParameters&), typeof(int), typeof(int)}, ReturnType = typeof(JobHandle))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	[DeduplicatedMethod]
	[Extension]
	public static JobHandle ScheduleBatch(T jobData, int arrayLength, int indicesPerJobCount, JobHandle dependsOn = null) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Extension]
	public static JobHandle ScheduleBatchByRef(ref T jobData, int arrayLength, int indicesPerJobCount, JobHandle dependsOn = null) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JobScheduleParameters), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(IntPtr), typeof(JobHandle), typeof(ScheduleMode)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(JobsUtility), Member = "ScheduleParallelFor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JobScheduleParameters&), typeof(int), typeof(int)}, ReturnType = typeof(JobHandle))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Extension]
	public static JobHandle ScheduleByRef(ref T jobData, int arrayLength, int indicesPerJobCount, JobHandle dependsOn = null) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JobParallelForBatchProducer`1), Member = "Initialize", ReturnType = typeof(void))]
	[Calls(Type = typeof(JobScheduleParameters), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(IntPtr), typeof(JobHandle), typeof(ScheduleMode)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(JobsUtility), Member = "ScheduleParallelFor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JobScheduleParameters&), typeof(int), typeof(int)}, ReturnType = typeof(JobHandle))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	[DeduplicatedMethod]
	[Extension]
	public static JobHandle ScheduleParallel(T jobData, int arrayLength, int indicesPerJobCount, JobHandle dependsOn = null) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JobScheduleParameters), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(IntPtr), typeof(JobHandle), typeof(ScheduleMode)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(JobsUtility), Member = "ScheduleParallelFor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JobScheduleParameters&), typeof(int), typeof(int)}, ReturnType = typeof(JobHandle))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Extension]
	public static JobHandle ScheduleParallelByRef(ref T jobData, int arrayLength, int indicesPerJobCount, JobHandle dependsOn = null) { }

}

