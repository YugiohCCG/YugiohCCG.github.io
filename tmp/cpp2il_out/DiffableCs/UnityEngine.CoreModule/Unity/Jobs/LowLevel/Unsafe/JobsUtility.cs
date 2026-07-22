namespace Unity.Jobs.LowLevel.Unsafe;

[NativeHeader("Runtime/Jobs/JobSystem.h")]
[NativeType(Header = "Runtime/Jobs/ScriptBindings/JobsBindings.h")]
public static class JobsUtility
{
	internal struct JobScheduleParameters
	{
		public JobHandle Dependency; //Field offset: 0x0
		public int ScheduleMode; //Field offset: 0x10
		public IntPtr ReflectionData; //Field offset: 0x18
		public IntPtr JobDataPtr; //Field offset: 0x20

		[CalledBy(Type = typeof(IJobExtensions), Member = "Schedule", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", typeof(JobHandle)}, ReturnType = typeof(JobHandle))]
		[CalledBy(Type = "Unity.Jobs.IJobParallelForDeferExtensions", Member = "ScheduleInternal", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(int), "System.Void*", "System.Void*", typeof(JobHandle)}, ReturnType = typeof(JobHandle))]
		[CalledBy(Type = "Unity.Jobs.IJobParallelForBatchExtensions", Member = "RunByRef", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(int), typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = "Unity.Jobs.IJobParallelForBatchExtensions", Member = "Run", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", typeof(int), typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = "Unity.Jobs.IJobParallelForBatchExtensions", Member = "ScheduleBatch", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", typeof(int), typeof(int), typeof(JobHandle)}, ReturnType = typeof(JobHandle))]
		[CalledBy(Type = "Unity.Jobs.IJobParallelForBatchExtensions", Member = "ScheduleParallelByRef", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(int), typeof(int), typeof(JobHandle)}, ReturnType = typeof(JobHandle))]
		[CalledBy(Type = "Unity.Jobs.IJobParallelForBatchExtensions", Member = "ScheduleParallel", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", typeof(int), typeof(int), typeof(JobHandle)}, ReturnType = typeof(JobHandle))]
		[CalledBy(Type = "Unity.Jobs.IJobParallelForBatchExtensions", Member = "ScheduleByRef", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(int), typeof(int), typeof(JobHandle)}, ReturnType = typeof(JobHandle))]
		[CalledBy(Type = "Unity.Jobs.IJobParallelForBatchExtensions", Member = "Schedule", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", typeof(int), typeof(int), typeof(JobHandle)}, ReturnType = typeof(JobHandle))]
		[CalledBy(Type = "Unity.Jobs.IJobFilterExtensions", Member = "RunAppendByRef", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", "Unity.Collections.NativeList`1<Int32>", typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = "Unity.Jobs.IJobFilterExtensions", Member = "ScheduleFilterByRef", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", "Unity.Collections.NativeList`1<Int32>", typeof(JobHandle)}, ReturnType = typeof(JobHandle))]
		[CalledBy(Type = "Unity.Jobs.IJobFilterExtensions", Member = "ScheduleAppendByRef", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", "Unity.Collections.NativeList`1<Int32>", typeof(int), typeof(JobHandle)}, ReturnType = typeof(JobHandle))]
		[CalledBy(Type = typeof(IJobParallelForTransformExtensions), Member = "Schedule", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", typeof(TransformAccessArray), typeof(JobHandle)}, ReturnType = typeof(JobHandle))]
		[CalledBy(Type = typeof(IJobParallelForExtensions), Member = "Run", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(IJobParallelForExtensions), Member = "Schedule", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", typeof(int), typeof(int), typeof(JobHandle)}, ReturnType = typeof(JobHandle))]
		[CalledBy(Type = typeof(IJobForExtensions), Member = "ScheduleParallel", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", typeof(int), typeof(int), typeof(JobHandle)}, ReturnType = typeof(JobHandle))]
		[CalledBy(Type = "Unity.Jobs.IJobFilterExtensions", Member = "RunFilterByRef", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", "Unity.Collections.NativeList`1<Int32>"}, ReturnType = typeof(void))]
		[CallerCount(Count = 17)]
		[CallsDeduplicatedMethods(Count = 1)]
		public JobScheduleParameters(Void* i_jobData, IntPtr i_reflectionData, JobHandle i_dependency, ScheduleMode i_scheduleMode) { }

	}

	public sealed class PanicFunction_ : MulticastDelegate
	{

		[CallerCount(Count = 536)]
		[CallsUnknownMethods(Count = 4)]
		[DeduplicatedMethod]
		public PanicFunction_(object object, IntPtr method) { }

		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public override void Invoke() { }

	}

	internal static PanicFunction_ PanicFunction; //Field offset: 0x0

	public static bool IsExecutingJob
	{
		[CalledBy(Type = "UnityEngine.UIElements.UIR.TempMeshAllocatorImpl", Member = "AllocateTempMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), "Unity.Collections.NativeSlice`1<Vertex>&", "Unity.Collections.NativeSlice`1<UInt16>&"}, ReturnType = typeof(void))]
		[CalledBy(Type = "Unity.Collections.RewindableAllocator", Member = "Rewind", ReturnType = typeof(void))]
		[CalledBy(Type = "Unity.Collections.RewindableAllocator", Member = "Dispose", ReturnType = typeof(void))]
		[CalledBy(Type = "TMPro.TMP_FontAsset", Member = "ReadFontAssetDefinition", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.TextCore.Text.MaterialManager", Member = "GetFallbackMaterial", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material), typeof(Material)}, ReturnType = typeof(Material))]
		[CalledBy(Type = "UnityEngine.TextCore.Text.MaterialManager", Member = "GetFallbackMaterial", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.TextCore.Text.FontAsset", typeof(Material), typeof(int)}, ReturnType = typeof(Material))]
		[CalledBy(Type = "UnityEngine.TextCore.Text.FontAsset", Member = "ReadFontAssetDefinition", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.TextCore.Text.TextGenerator", Member = "SetArraySizes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.TextCore.Text.TextProcessingElement[]", "UnityEngine.TextCore.Text.TextGenerationSettings", "UnityEngine.TextCore.Text.TextInfo"}, ReturnType = typeof(int))]
		[CallerCount(Count = 8)]
		[CallsUnknownMethods(Count = 2)]
		[NativeMethod(IsFreeFunction = True, IsThreadSafe = True)]
		 get { } //Length: 42
	}

	public static bool JobCompilerEnabled
	{
		[CalledBy(Type = "Unity.Burst.BurstCompiler", Member = ".cctor", ReturnType = typeof(void))]
		[CalledBy(Type = "Unity.Burst.BurstCompilerOptions", Member = ".ctor", ReturnType = typeof(void))]
		[CalledBy(Type = "Unity.Burst.BurstCompilerOptions", Member = "set_EnableBurstCompilation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = "Unity.Burst.BurstCompilerOptions", Member = "Clone", ReturnType = "Unity.Burst.BurstCompilerOptions")]
		[CallerCount(Count = 5)]
		[CallsUnknownMethods(Count = 2)]
		[FreeFunction]
		 set { } //Length: 51
	}

	public static int JobWorkerCount
	{
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		 get { } //Length: 42
	}

	public static int ThreadIndex
	{
		[BurstAuthorizedExternalMethod]
		[CalledBy(Type = "UnityEngine.UIElements.UIRUtility", Member = "GetThreadIndex", ReturnType = typeof(int))]
		[CalledBy(Type = "UnityEngine.UIElements.UIR.EntryPool", Member = "Get", ReturnType = "UnityEngine.UIElements.UIR.Entry")]
		[CalledBy(Type = "UnityEngine.TextCore.Text.TextHandle", Member = "get_textInfoCommon", ReturnType = "UnityEngine.TextCore.Text.TextInfo")]
		[CalledBy(Type = "UnityEngine.TextCore.Text.TextHandle", Member = "get_generator", ReturnType = "UnityEngine.TextCore.Text.TextGenerator")]
		[CalledBy(Type = "UnityEngine.TextCore.Text.TextHandle", Member = "get_settings", ReturnType = "UnityEngine.TextCore.Text.TextGenerationSettings")]
		[CallerCount(Count = 5)]
		[CallsUnknownMethods(Count = 2)]
		[FreeFunction("GetJobWorkerIndex", IsThreadSafe = True)]
		 get { } //Length: 42
	}

	public static int ThreadIndexCount
	{
		[BurstAuthorizedExternalMethod]
		[CalledBy(Type = "Unity.Collections.LowLevel.Unsafe.UnsafeParallelHashMapData", Member = "AllocateHashMap", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(long), "Unity.Collections.AllocatorManager+AllocatorHandle", "Unity.Collections.LowLevel.Unsafe.UnsafeParallelHashMapData*&"}, ReturnType = typeof(void))]
		[CalledBy(Type = "Unity.Collections.LowLevel.Unsafe.UnsafeParallelHashMap`2", Member = "Clear", ReturnType = typeof(void))]
		[CalledBy(Type = "Unity.Collections.LowLevel.Unsafe.UnsafeParallelHashMapBase`2", Member = "TryAdd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Collections.LowLevel.Unsafe.UnsafeParallelHashMapData*", "TKey", "TValue", typeof(bool), "Unity.Collections.AllocatorManager+AllocatorHandle"}, ReturnType = typeof(bool))]
		[CalledBy(Type = "Unity.Collections.LowLevel.Unsafe.UnsafeParallelHashMapBase`2", Member = "AllocEntry", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Collections.LowLevel.Unsafe.UnsafeParallelHashMapData*", typeof(int)}, ReturnType = typeof(int))]
		[CalledBy(Type = "Unity.Collections.LowLevel.Unsafe.UnsafeParallelHashMapBase`2", Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Collections.LowLevel.Unsafe.UnsafeParallelHashMapData*"}, ReturnType = typeof(void))]
		[CalledBy(Type = "Unity.Collections.LowLevel.Unsafe.UnsafeParallelHashMapData", Member = "GetCount", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Collections.LowLevel.Unsafe.UnsafeParallelHashMapData*"}, ReturnType = typeof(int))]
		[CalledBy(Type = "Unity.Collections.LowLevel.Unsafe.UnsafeStream", Member = "AllocateBlock", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Collections.LowLevel.Unsafe.UnsafeStream&", "Unity.Collections.AllocatorManager+AllocatorHandle"}, ReturnType = typeof(void))]
		[CalledBy(Type = "Unity.Collections.UnsafeQueue`1", Member = "Clear", ReturnType = typeof(void))]
		[CalledBy(Type = "Unity.Collections.UnsafeQueueData", Member = "AllocateQueue", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Collections.AllocatorManager+AllocatorHandle", "Unity.Collections.UnsafeQueueData*&"}, ReturnType = typeof(void))]
		[CalledBy(Type = "Unity.Collections.SortJob`2", Member = "Schedule", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JobHandle)}, ReturnType = typeof(JobHandle))]
		[CalledBy(Type = "Unity.Collections.AllocatorManager", Member = ".cctor", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UIElements.UIR.TempMeshAllocatorImpl", Member = ".ctor", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UIElements.UIR.EntryPool", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = "Unity.Collections.UnsafeQueue`1", Member = "TryDequeue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&"}, ReturnType = typeof(bool))]
		[CalledBy(Type = "UnityEngine.TextCore.Text.TextHandle", Member = "InitArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]&", "System.Func`1<T>"}, ReturnType = typeof(void))]
		[CallerCount(Count = 21)]
		[CallsUnknownMethods(Count = 2)]
		[FreeFunction("GetJobWorkerIndexCount", IsThreadSafe = True)]
		 get { } //Length: 42
	}

	[CalledBy(Type = "Unity.Jobs.IJobFilterExtensions+JobFilterProducer`1", Member = "Initialize", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static IntPtr CreateJobReflectionData(Type wrapperJobType, Type userJobType, object managedJobFunction0) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[FreeFunction(ThrowsException = True, IsThreadSafe = True)]
	private static IntPtr CreateJobReflectionData(Type wrapperJobType, Type userJobType, object managedJobFunction0, object managedJobFunction1, object managedJobFunction2) { }

	[CalledBy(Type = typeof(JobStruct`1), Member = "Initialize", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ForJobStruct`1), Member = "Initialize", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ParallelForJobStruct`1), Member = "Initialize", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TransformParallelForLoopStruct`1), Member = "Initialize", ReturnType = typeof(void))]
	[CalledBy(Type = "Unity.Jobs.IJobParallelForBatchExtensions+JobParallelForBatchProducer`1", Member = "Initialize", ReturnType = typeof(void))]
	[CalledBy(Type = "Unity.Jobs.IJobParallelForDeferExtensions+JobParallelForDeferProducer`1", Member = "Initialize", ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[CallsUnknownMethods(Count = 2)]
	public static IntPtr CreateJobReflectionData(Type type, object managedJobFunction0, object managedJobFunction1 = null, object managedJobFunction2 = null) { }

	[CalledBy(Type = "UnityEngine.UIElements.UIR.TempMeshAllocatorImpl", Member = "AllocateTempMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), "Unity.Collections.NativeSlice`1<Vertex>&", "Unity.Collections.NativeSlice`1<UInt16>&"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Unity.Collections.RewindableAllocator", Member = "Rewind", ReturnType = typeof(void))]
	[CalledBy(Type = "Unity.Collections.RewindableAllocator", Member = "Dispose", ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TMP_FontAsset", Member = "ReadFontAssetDefinition", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.TextCore.Text.MaterialManager", Member = "GetFallbackMaterial", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material), typeof(Material)}, ReturnType = typeof(Material))]
	[CalledBy(Type = "UnityEngine.TextCore.Text.MaterialManager", Member = "GetFallbackMaterial", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.TextCore.Text.FontAsset", typeof(Material), typeof(int)}, ReturnType = typeof(Material))]
	[CalledBy(Type = "UnityEngine.TextCore.Text.FontAsset", Member = "ReadFontAssetDefinition", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.TextCore.Text.TextGenerator", Member = "SetArraySizes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.TextCore.Text.TextProcessingElement[]", "UnityEngine.TextCore.Text.TextGenerationSettings", "UnityEngine.TextCore.Text.TextInfo"}, ReturnType = typeof(int))]
	[CallerCount(Count = 8)]
	[CallsUnknownMethods(Count = 2)]
	[NativeMethod(IsFreeFunction = True, IsThreadSafe = True)]
	public static bool get_IsExecutingJob() { }

	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public static int get_JobWorkerCount() { }

	[BurstAuthorizedExternalMethod]
	[CalledBy(Type = "UnityEngine.UIElements.UIRUtility", Member = "GetThreadIndex", ReturnType = typeof(int))]
	[CalledBy(Type = "UnityEngine.UIElements.UIR.EntryPool", Member = "Get", ReturnType = "UnityEngine.UIElements.UIR.Entry")]
	[CalledBy(Type = "UnityEngine.TextCore.Text.TextHandle", Member = "get_textInfoCommon", ReturnType = "UnityEngine.TextCore.Text.TextInfo")]
	[CalledBy(Type = "UnityEngine.TextCore.Text.TextHandle", Member = "get_generator", ReturnType = "UnityEngine.TextCore.Text.TextGenerator")]
	[CalledBy(Type = "UnityEngine.TextCore.Text.TextHandle", Member = "get_settings", ReturnType = "UnityEngine.TextCore.Text.TextGenerationSettings")]
	[CallerCount(Count = 5)]
	[CallsUnknownMethods(Count = 2)]
	[FreeFunction("GetJobWorkerIndex", IsThreadSafe = True)]
	public static int get_ThreadIndex() { }

	[BurstAuthorizedExternalMethod]
	[CalledBy(Type = "UnityEngine.TextCore.Text.TextHandle", Member = "InitArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]&", "System.Func`1<T>"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Unity.Collections.UnsafeQueue`1", Member = "TryDequeue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&"}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.UIElements.UIR.EntryPool", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.UIR.TempMeshAllocatorImpl", Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = "Unity.Collections.AllocatorManager", Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = "Unity.Collections.SortJob`2", Member = "Schedule", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JobHandle)}, ReturnType = typeof(JobHandle))]
	[CalledBy(Type = "Unity.Collections.UnsafeQueue`1", Member = "Clear", ReturnType = typeof(void))]
	[CalledBy(Type = "Unity.Collections.UnsafeQueueData", Member = "AllocateQueue", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Collections.AllocatorManager+AllocatorHandle", "Unity.Collections.UnsafeQueueData*&"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Unity.Collections.LowLevel.Unsafe.UnsafeParallelHashMapData", Member = "GetCount", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Collections.LowLevel.Unsafe.UnsafeParallelHashMapData*"}, ReturnType = typeof(int))]
	[CalledBy(Type = "Unity.Collections.LowLevel.Unsafe.UnsafeParallelHashMapBase`2", Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Collections.LowLevel.Unsafe.UnsafeParallelHashMapData*"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Unity.Collections.LowLevel.Unsafe.UnsafeParallelHashMapBase`2", Member = "AllocEntry", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Collections.LowLevel.Unsafe.UnsafeParallelHashMapData*", typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = "Unity.Collections.LowLevel.Unsafe.UnsafeParallelHashMapBase`2", Member = "TryAdd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Collections.LowLevel.Unsafe.UnsafeParallelHashMapData*", "TKey", "TValue", typeof(bool), "Unity.Collections.AllocatorManager+AllocatorHandle"}, ReturnType = typeof(bool))]
	[CalledBy(Type = "Unity.Collections.LowLevel.Unsafe.UnsafeParallelHashMap`2", Member = "Clear", ReturnType = typeof(void))]
	[CalledBy(Type = "Unity.Collections.LowLevel.Unsafe.UnsafeParallelHashMapData", Member = "AllocateHashMap", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(long), "Unity.Collections.AllocatorManager+AllocatorHandle", "Unity.Collections.LowLevel.Unsafe.UnsafeParallelHashMapData*&"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Unity.Collections.LowLevel.Unsafe.UnsafeStream", Member = "AllocateBlock", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Collections.LowLevel.Unsafe.UnsafeStream&", "Unity.Collections.AllocatorManager+AllocatorHandle"}, ReturnType = typeof(void))]
	[CallerCount(Count = 21)]
	[CallsUnknownMethods(Count = 2)]
	[FreeFunction("GetJobWorkerIndexCount", IsThreadSafe = True)]
	public static int get_ThreadIndexCount() { }

	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	[FreeFunction("JobSystem::GetJobQueueWorkerThreadCount")]
	private static int GetJobQueueWorkerThreadCount() { }

	[CalledBy(Type = typeof(TransformParallelForLoopStruct`1), Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(IntPtr), typeof(IntPtr), typeof(JobRanges&), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static void GetJobRange(ref JobRanges ranges, int jobIndex, out int beginIndex, out int endIndex) { }

	[CalledBy(Type = typeof(ForJobStruct`1), Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(IntPtr), typeof(IntPtr), typeof(JobRanges&), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ParallelForJobStruct`1), Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(IntPtr), typeof(IntPtr), typeof(JobRanges&), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TransformParallelForLoopStruct`1), Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(IntPtr), typeof(IntPtr), typeof(JobRanges&), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Unity.Jobs.IJobParallelForBatchExtensions+JobParallelForBatchProducer`1", Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(IntPtr), typeof(IntPtr), typeof(JobRanges&), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Unity.Jobs.IJobParallelForDeferExtensions+JobParallelForDeferProducer`1", Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(IntPtr), typeof(IntPtr), typeof(JobRanges&), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 10)]
	[CallsUnknownMethods(Count = 2)]
	[NativeMethod(IsFreeFunction = True, IsThreadSafe = True)]
	public static bool GetWorkStealingRange(ref JobRanges ranges, int jobIndex, out int beginIndex, out int endIndex) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[RequiredByNativeCode]
	private static void InvokePanicFunction() { }

	[CalledBy(Type = typeof(IJobExtensions), Member = "Schedule", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", typeof(JobHandle)}, ReturnType = typeof(JobHandle))]
	[CalledBy(Type = "Unity.Jobs.IJobFilterExtensions", Member = "ScheduleAppendByRef", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", "Unity.Collections.NativeList`1<Int32>", typeof(int), typeof(JobHandle)}, ReturnType = typeof(JobHandle))]
	[CalledBy(Type = "Unity.Jobs.IJobFilterExtensions", Member = "ScheduleFilterByRef", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", "Unity.Collections.NativeList`1<Int32>", typeof(JobHandle)}, ReturnType = typeof(JobHandle))]
	[CalledBy(Type = "Unity.Jobs.IJobFilterExtensions", Member = "RunAppendByRef", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", "Unity.Collections.NativeList`1<Int32>", typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Unity.Jobs.IJobFilterExtensions", Member = "RunFilterByRef", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", "Unity.Collections.NativeList`1<Int32>"}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[CallsUnknownMethods(Count = 2)]
	[FreeFunction("ScheduleManagedJob", ThrowsException = True, IsThreadSafe = True)]
	public static JobHandle Schedule(ref JobScheduleParameters parameters) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void Schedule_Injected(ref JobScheduleParameters parameters, out JobHandle ret) { }

	[CalledBy(Type = typeof(IJobForExtensions), Member = "ScheduleParallel", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", typeof(int), typeof(int), typeof(JobHandle)}, ReturnType = typeof(JobHandle))]
	[CalledBy(Type = typeof(IJobParallelForExtensions), Member = "Schedule", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", typeof(int), typeof(int), typeof(JobHandle)}, ReturnType = typeof(JobHandle))]
	[CalledBy(Type = typeof(IJobParallelForExtensions), Member = "Run", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Unity.Jobs.IJobParallelForBatchExtensions", Member = "Schedule", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", typeof(int), typeof(int), typeof(JobHandle)}, ReturnType = typeof(JobHandle))]
	[CalledBy(Type = "Unity.Jobs.IJobParallelForBatchExtensions", Member = "ScheduleByRef", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(int), typeof(int), typeof(JobHandle)}, ReturnType = typeof(JobHandle))]
	[CalledBy(Type = "Unity.Jobs.IJobParallelForBatchExtensions", Member = "ScheduleParallel", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", typeof(int), typeof(int), typeof(JobHandle)}, ReturnType = typeof(JobHandle))]
	[CalledBy(Type = "Unity.Jobs.IJobParallelForBatchExtensions", Member = "ScheduleParallelByRef", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(int), typeof(int), typeof(JobHandle)}, ReturnType = typeof(JobHandle))]
	[CalledBy(Type = "Unity.Jobs.IJobParallelForBatchExtensions", Member = "ScheduleBatch", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", typeof(int), typeof(int), typeof(JobHandle)}, ReturnType = typeof(JobHandle))]
	[CalledBy(Type = "Unity.Jobs.IJobParallelForBatchExtensions", Member = "Run", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Unity.Jobs.IJobParallelForBatchExtensions", Member = "RunByRef", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 10)]
	[CallsUnknownMethods(Count = 2)]
	[FreeFunction("ScheduleManagedJobParallelFor", ThrowsException = True, IsThreadSafe = True)]
	public static JobHandle ScheduleParallelFor(ref JobScheduleParameters parameters, int arrayLength, int innerloopBatchCount) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void ScheduleParallelFor_Injected(ref JobScheduleParameters parameters, int arrayLength, int innerloopBatchCount, out JobHandle ret) { }

	[CalledBy(Type = "Unity.Jobs.IJobParallelForDeferExtensions", Member = "ScheduleInternal", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(int), "System.Void*", "System.Void*", typeof(JobHandle)}, ReturnType = typeof(JobHandle))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[FreeFunction("ScheduleManagedJobParallelForDeferArraySize", ThrowsException = True, IsThreadSafe = True)]
	public static JobHandle ScheduleParallelForDeferArraySize(ref JobScheduleParameters parameters, int innerloopBatchCount, Void* listData, Void* listDataAtomicSafetyHandle) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void ScheduleParallelForDeferArraySize_Injected(ref JobScheduleParameters parameters, int innerloopBatchCount, Void* listData, Void* listDataAtomicSafetyHandle, out JobHandle ret) { }

	[CalledBy(Type = typeof(IJobParallelForTransformExtensions), Member = "Schedule", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", typeof(TransformAccessArray), typeof(JobHandle)}, ReturnType = typeof(JobHandle))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[FreeFunction("ScheduleManagedJobParallelForTransform", ThrowsException = True)]
	public static JobHandle ScheduleParallelForTransform(ref JobScheduleParameters parameters, IntPtr transfromAccesssArray) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void ScheduleParallelForTransform_Injected(ref JobScheduleParameters parameters, IntPtr transfromAccesssArray, out JobHandle ret) { }

	[CalledBy(Type = "Unity.Burst.BurstCompiler", Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = "Unity.Burst.BurstCompilerOptions", Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = "Unity.Burst.BurstCompilerOptions", Member = "set_EnableBurstCompilation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Unity.Burst.BurstCompilerOptions", Member = "Clone", ReturnType = "Unity.Burst.BurstCompilerOptions")]
	[CallerCount(Count = 5)]
	[CallsUnknownMethods(Count = 2)]
	[FreeFunction]
	public static void set_JobCompilerEnabled(bool value) { }

}

