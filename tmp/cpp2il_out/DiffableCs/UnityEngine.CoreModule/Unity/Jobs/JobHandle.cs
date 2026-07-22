namespace Unity.Jobs;

[NativeType(Header = "Runtime/Jobs/ScriptBindings/JobsBindings.h")]
public struct JobHandle : IEquatable<JobHandle>
{
	internal ulong jobGroup; //Field offset: 0x0
	internal int version; //Field offset: 0x8

	public bool IsCompleted
	{
		[CallerCount(Count = 2)]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		 get { } //Length: 51
	}

	[CalledBy(Type = "UnityEngine.Rendering.Universal.Internal.ForwardLights", Member = "PreSetup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.UniversalRenderingData", "UnityEngine.Rendering.Universal.UniversalCameraData", "UnityEngine.Rendering.Universal.UniversalLightData"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.InstanceCuller", Member = "CreateCullJobTree", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BatchCullingContext&), typeof(BatchCullingOutput), "ReadOnly&", "ReadOnly&", "ReadOnly&", "Unity.Collections.NativeList`1<LODGroupCullingData>", "UnityEngine.Rendering.CPUDrawInstanceData", "Unity.Collections.NativeParallelHashMap`2<UInt32, BatchID>", typeof(int), typeof(float), "UnityEngine.Rendering.OcclusionCullingCommon"}, ReturnType = typeof(JobHandle))]
	[CalledBy(Type = "UnityEngine.Rendering.InstanceCuller", Member = "CreateCompactedVisibilityMaskJob", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"ReadOnly&", "Unity.Collections.NativeArray`1<Byte>", typeof(JobHandle)}, ReturnType = typeof(JobHandle))]
	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	public static JobHandle CombineDependencies(JobHandle job0, JobHandle job1) { }

	[CalledBy(Type = "UnityEngine.UIElements.UIR.JobManager", Member = "CompleteNudgeJobs", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.UIR.JobManager", Member = "CompleteConvertMeshJobs", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.UIR.JobManager", Member = "CompleteCopyMeshJobs", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.UIR.JobMerger", Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JobHandle)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.UIR.OpacityIdAccelerator", Member = "CreateJob", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Collections.NativeSlice`1<Vertex>", "Unity.Collections.NativeSlice`1<Vertex>", typeof(Color32), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.UIR.RenderChain+VisualChangesProcessor", Member = "DoUpdateOpacityId", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.VisualElement", "UnityEngine.UIElements.UIR.RenderChain", "UnityEngine.UIElements.UIR.MeshHandle"}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static JobHandle CombineDependencies(NativeArray<JobHandle> jobs) { }

	[CalledBy(Type = "UnityEngine.UIElements.UIR.JobManager", Member = "CompleteNudgeJobs", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.UIR.JobManager", Member = "CompleteConvertMeshJobs", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.UIR.JobManager", Member = "CompleteCopyMeshJobs", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.UIR.JobMerger", Member = "MergeAndReset", ReturnType = typeof(JobHandle))]
	[CalledBy(Type = "UnityEngine.UIElements.UIR.OpacityIdAccelerator", Member = "CompleteJobs", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.UIR.RenderChain", Member = "ProcessChanges", ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public static JobHandle CombineDependencies(NativeSlice<JobHandle> jobs) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[NativeMethod(IsFreeFunction = True, IsThreadSafe = True, ThrowsException = True)]
	private static JobHandle CombineDependenciesInternal2(ref JobHandle job0, ref JobHandle job1) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void CombineDependenciesInternal2_Injected(ref JobHandle job0, ref JobHandle job1, out JobHandle ret) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[NativeMethod(IsFreeFunction = True, IsThreadSafe = True, ThrowsException = True)]
	internal static JobHandle CombineDependenciesInternalPtr(Void* jobs, int count) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void CombineDependenciesInternalPtr_Injected(Void* jobs, int count, out JobHandle ret) { }

	[CallerCount(Count = 102)]
	[CallsUnknownMethods(Count = 2)]
	public void Complete() { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public override bool Equals(JobHandle other) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public virtual bool Equals(object obj) { }

	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public bool get_IsCompleted() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ulong), Member = "GetHashCode", ReturnType = typeof(int))]
	[DeduplicatedMethod]
	public virtual int GetHashCode() { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public static bool op_Equality(JobHandle a, JobHandle b) { }

	[CalledBy(Type = "UnityEngine.UIElements.UIR.OpacityIdAccelerator", Member = "CreateJob", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Collections.NativeSlice`1<Vertex>", "Unity.Collections.NativeSlice`1<Vertex>", typeof(Color32), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.UIR.RenderChain+VisualChangesProcessor", Member = "DoUpdateOpacityId", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.VisualElement", "UnityEngine.UIElements.UIR.RenderChain", "UnityEngine.UIElements.UIR.MeshHandle"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.Internal.ForwardLights", Member = "PreSetup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.UniversalRenderingData", "UnityEngine.Rendering.Universal.UniversalCameraData", "UnityEngine.Rendering.Universal.UniversalLightData"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BatchRendererGroup), Member = "InvokeOnPerformCulling", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BatchRendererGroup), typeof(BatchRendererCullingOutput&), typeof(LODParameters&), typeof(IntPtr)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.ParallelSortExtensions", Member = "ParallelSort", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Collections.NativeArray`1<Int32>"}, ReturnType = typeof(JobHandle))]
	[CallerCount(Count = 6)]
	[CallsUnknownMethods(Count = 2)]
	[NativeMethod("ScheduleBatchedScriptingJobs", IsFreeFunction = True, IsThreadSafe = True)]
	public static void ScheduleBatchedJobs() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[NativeMethod("ScheduleBatchedScriptingJobsAndComplete", IsFreeFunction = True, IsThreadSafe = True, ThrowsException = True)]
	private static void ScheduleBatchedJobsAndComplete(ref JobHandle job) { }

	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	[NativeMethod("ScheduleBatchedScriptingJobsAndIsCompleted", IsFreeFunction = True, IsThreadSafe = True, ThrowsException = True)]
	private static bool ScheduleBatchedJobsAndIsCompleted(ref JobHandle job) { }

}

