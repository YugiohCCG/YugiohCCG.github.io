namespace UnityEngine.Rendering;

internal struct InstanceCuller : IDisposable
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static BaseRenderFunc<InstanceOcclusionTestPassData, ComputeGraphContext> <>9__25_0; //Field offset: 0x8

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		private static <>c() { }

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InstanceCuller), Member = "AddOcclusionCullingDispatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputeCommandBuffer), typeof(OcclusionCullingSettings&), typeof(InstanceOcclusionTestSubviewSettings&), typeof(IndirectBufferContextHandles&), typeof(OccluderHandles&), typeof(RenderersBatchersContext)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		internal void <InstanceOcclusionTest>b__25_0(InstanceOcclusionTestPassData data, ComputeGraphContext context) { }

	}

	private class InstanceOcclusionTestPassData
	{
		public OcclusionCullingSettings settings; //Field offset: 0x10
		public InstanceOcclusionTestSubviewSettings subviewSettings; //Field offset: 0x1C
		public OccluderHandles occluderHandles; //Field offset: 0x30
		public IndirectBufferContextHandles bufferHandles; //Field offset: 0x4C

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public InstanceOcclusionTestPassData() { }

	}

	private static class ShaderIDs
	{
		public static readonly int InstanceOcclusionCullerShaderVariables; //Field offset: 0x0
		public static readonly int _DrawInfo; //Field offset: 0x4
		public static readonly int _InstanceInfo; //Field offset: 0x8
		public static readonly int _DispatchArgs; //Field offset: 0xC
		public static readonly int _DrawArgs; //Field offset: 0x10
		public static readonly int _InstanceIndices; //Field offset: 0x14
		public static readonly int _InstanceDataBuffer; //Field offset: 0x18
		public static readonly int _OccluderDepthPyramid; //Field offset: 0x1C
		public static readonly int _OcclusionDebugCounters; //Field offset: 0x20

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Shader), Member = "PropertyToID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
		private static ShaderIDs() { }

	}

	private ParallelBitArray m_CompactedVisibilityMasks; //Field offset: 0x0
	private JobHandle m_CompactedVisibilityMasksJobsHandle; //Field offset: 0x20
	private IndirectBufferContextStorage m_IndirectStorage; //Field offset: 0x30
	private OcclusionTestComputeShader m_OcclusionTestShader; //Field offset: 0xB8
	private int m_ResetDrawArgsKernel; //Field offset: 0xD8
	private int m_CopyInstancesKernel; //Field offset: 0xDC
	private int m_CullInstancesKernel; //Field offset: 0xE0
	private DebugRendererBatcherStats m_DebugStats; //Field offset: 0xE8
	private InstanceCullerSplitDebugArray m_SplitDebugArray; //Field offset: 0xF0
	private InstanceOcclusionEventDebugArray m_OcclusionEventDebugArray; //Field offset: 0x110
	private ProfilingSampler m_ProfilingSampleInstanceOcclusionTest; //Field offset: 0x168
	private NativeArray<InstanceOcclusionCullerShaderVariables> m_ShaderVariables; //Field offset: 0x170
	private ComputeBuffer m_ConstantBuffer; //Field offset: 0x180
	private CommandBuffer m_CommandBuffer; //Field offset: 0x188

	[CalledBy(Type = typeof(<>c), Member = "<InstanceOcclusionTest>b__25_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InstanceOcclusionTestPassData), typeof(ComputeGraphContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BufferHandle), Member = "IsValid", ReturnType = typeof(bool))]
	[Calls(Type = typeof(OcclusionCullingCommon), Member = "SetDepthPyramid", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputeCommandBuffer), typeof(OcclusionTestComputeShader&), typeof(int), typeof(OccluderHandles&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderersBatchersContext), Member = "get_gpuInstanceDataBuffer", ReturnType = typeof(GraphicsBuffer))]
	[Calls(Type = typeof(BufferHandle), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BufferHandle)}, ReturnType = typeof(GraphicsBuffer))]
	[Calls(Type = typeof(OcclusionCullingCommon), Member = "PrepareCulling", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputeCommandBuffer), typeof(OccluderContext&), typeof(OcclusionCullingSettings&), typeof(InstanceOcclusionTestSubviewSettings&), typeof(OcclusionTestComputeShader&), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ComputeBuffer), Member = "get_stride", ReturnType = typeof(int))]
	[Calls(Type = typeof(ComputeCommandBuffer), Member = "SetBufferData", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputeBuffer), "Unity.Collections.NativeArray`1<T>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(OccluderContext), Member = "SetKeyword", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputeCommandBuffer), typeof(ComputeShader), typeof(LocalKeyword&), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(LocalKeyword), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputeShader), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(OcclusionCullingCommon), Member = "UseOcclusionDebug", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(OccluderContext&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(InstanceOcclusionEventDebugArray), Member = "TryAdd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(InstanceOcclusionEventType), typeof(int), typeof(int), typeof(OcclusionTest)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(IndirectBufferContextStorage), Member = "GetAllocInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(IndirectBufferAllocInfo))]
	[Calls(Type = typeof(JobHandle), Member = "Complete", ReturnType = typeof(void))]
	[Calls(Type = typeof(IndirectBufferContext), Member = "Matches", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BufferState), typeof(int), typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(OcclusionCullingCommon), Member = "GetOccluderContext", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(OccluderContext&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(IndirectBufferContextStorage), Member = "GetBufferContext", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(IndirectBufferContext))]
	[Calls(Type = typeof(IndirectBufferContextStorage), Member = "TryGetContextIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(OcclusionCullingCommon), Member = "SetDebugPyramid", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputeCommandBuffer), typeof(OcclusionTestComputeShader&), typeof(int), typeof(OccluderHandles&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(IndirectBufferContextStorage), Member = "SetBufferContext", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(IndirectBufferContext)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 19)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private void AddOcclusionCullingDispatch(ComputeCommandBuffer cmd, in OcclusionCullingSettings settings, in InstanceOcclusionTestSubviewSettings subviewSettings, in IndirectBufferContextHandles bufferHandles, in OccluderHandles occluderHandles, RenderersBatchersContext batchersContext) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 3)]
	private int ComputeWorstCaseDrawCommandCount(in BatchCullingContext cc, BinningConfig binningConfig, CPUDrawInstanceData drawInstanceData, int crossFadedRendererCount) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ParallelBitArray), Member = "get_IsCreated", ReturnType = typeof(bool))]
	[Calls(Type = typeof(ReadOnly), Member = "get_handlesLength", ReturnType = typeof(int))]
	[Calls(Type = typeof(ParallelBitArray), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Allocator), typeof(NativeArrayOptions)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(IJobParallelForBatchExtensions), Member = "ScheduleBatch", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", typeof(int), typeof(int), typeof(JobHandle)}, ReturnType = typeof(JobHandle))]
	[Calls(Type = typeof(JobHandle), Member = "CombineDependencies", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JobHandle), typeof(JobHandle)}, ReturnType = typeof(JobHandle))]
	private JobHandle CreateCompactedVisibilityMaskJob(in ReadOnly instanceData, NativeArray<Byte> rendererVisibilityMasks, JobHandle cullingJobHandle) { }

	[CalledBy(Type = typeof(InstanceCullingBatcher), Member = "OnPerformCulling", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BatchRendererGroup), typeof(BatchCullingContext), typeof(BatchCullingOutput), typeof(IntPtr)}, ReturnType = typeof(JobHandle))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(IndirectBufferContextStorage), Member = "TryAllocateContext", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(IJobParallelForExtensions), Member = "Schedule", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DrawCommandOutputPerBatch)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DrawCommandOutputPerBatch), typeof(int), typeof(int), typeof(JobHandle)}, ReturnType = typeof(JobHandle))]
	[Calls(Type = typeof(IndirectBufferContextStorage), Member = "get_indirectDrawArgsBufferHandle", ReturnType = typeof(GraphicsBufferHandle))]
	[Calls(Type = typeof(IndirectBufferContextStorage), Member = "get_visibleInstanceBufferHandle", ReturnType = typeof(GraphicsBufferHandle))]
	[Calls(Type = typeof(IJobExtensions), Member = "Schedule", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PrefixSumDrawsAndInstances)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PrefixSumDrawsAndInstances), typeof(JobHandle)}, ReturnType = typeof(JobHandle))]
	[Calls(Type = typeof(CPUDrawInstanceData), Member = "get_drawBatchIndices", ReturnType = typeof(Unity.Collections.NativeArray`1<System.Int32>))]
	[Calls(Type = typeof(NativeQueue`1), Member = "Enqueue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(IJobParallelForExtensions), Member = "Schedule", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AllocateBinsPerBatch)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AllocateBinsPerBatch), typeof(int), typeof(int), typeof(JobHandle)}, ReturnType = typeof(JobHandle))]
	[Calls(Type = typeof(CPUDrawInstanceData), Member = "get_drawInstanceIndices", ReturnType = typeof(Unity.Collections.NativeArray`1<System.Int32>))]
	[Calls(Type = typeof(IndirectBufferContextStorage), Member = "GetAllocInfoSubArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Unity.Collections.NativeArray`1<UnityEngine.Rendering.IndirectBufferAllocInfo>))]
	[Calls(Type = typeof(IndirectBufferContextStorage), Member = "GetLimits", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(IndirectBufferLimits))]
	[Calls(Type = typeof(OcclusionCullingCommon), Member = "HasOccluderContext", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(IndirectBufferContextStorage), Member = "SetBufferContext", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(IndirectBufferContext)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InstanceCullerSplitDebugArray), Member = "TryAddSplits", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BatchCullingViewType), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(JobHandle), Member = "CombineDependencies", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JobHandle), typeof(JobHandle)}, ReturnType = typeof(JobHandle))]
	[Calls(Type = typeof(IJobParallelForBatchExtensions), Member = "ScheduleBatch", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", typeof(int), typeof(int), typeof(JobHandle)}, ReturnType = typeof(JobHandle))]
	[Calls(Type = typeof(ParallelBitArray), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Allocator), typeof(NativeArrayOptions)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ParallelBitArray), Member = "get_IsCreated", ReturnType = typeof(bool))]
	[Calls(Type = typeof(InstanceCuller), Member = "CreateFrustumCullingJob", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BatchCullingContext&), typeof(ReadOnly&), typeof(ReadOnly&), typeof(Unity.Collections.NativeList`1<UnityEngine.Rendering.LODGroupCullingData>), typeof(BinningConfig&), typeof(float), typeof(OcclusionCullingCommon), typeof(Unity.Collections.NativeArray`1<System.Byte>), typeof(Unity.Collections.NativeArray`1<System.Byte>)}, ReturnType = typeof(JobHandle))]
	[Calls(Type = typeof(NativeArray`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Allocator), typeof(NativeArrayOptions)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ReadOnly), Member = "get_handlesLength", ReturnType = typeof(int))]
	[Calls(Type = typeof(MemoryUtilities), Member = "Malloc", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BatchDrawRange)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Allocator)}, ReturnType = typeof(BatchDrawRange*))]
	[Calls(Type = typeof(Unity.Collections.NativeArray`1<System.Byte>), Member = "Dispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JobHandle)}, ReturnType = typeof(JobHandle))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 7)]
	[ContainsUnimplementedInstructions]
	public JobHandle CreateCullJobTree(in BatchCullingContext cc, BatchCullingOutput cullingOutput, in ReadOnly instanceData, in ReadOnly sharedInstanceData, in ReadOnly instanceDataBuffer, NativeList<LODGroupCullingData> lodGroupCullingData, CPUDrawInstanceData drawInstanceData, NativeParallelHashMap<UInt32, BatchID> batchIDs, int crossFadedRendererCount, float smallMeshScreenPercentage, OcclusionCullingCommon occlusionCullingCommon) { }

	[CalledBy(Type = typeof(InstanceCuller), Member = "CreateCullJobTree", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BatchCullingContext&), typeof(BatchCullingOutput), typeof(ReadOnly&), typeof(ReadOnly&), typeof(ReadOnly&), typeof(Unity.Collections.NativeList`1<UnityEngine.Rendering.LODGroupCullingData>), typeof(CPUDrawInstanceData), typeof(Unity.Collections.NativeParallelHashMap`2<System.UInt32, UnityEngine.Rendering.BatchID>), typeof(int), typeof(float), typeof(OcclusionCullingCommon)}, ReturnType = typeof(JobHandle))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(LODParameters), Member = "get_isOrthographic", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Unity.Collections.NativeList`1<UnityEngine.Rendering.FrustumPlaneCuller+PlanePacket4>), Member = "Dispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JobHandle)}, ReturnType = typeof(JobHandle))]
	[Calls(Type = typeof(Unity.Collections.NativeList`1<UnityEngine.Plane>), Member = "Dispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JobHandle)}, ReturnType = typeof(JobHandle))]
	[Calls(Type = typeof(IJobParallelForExtensions), Member = "Schedule", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CullingJob)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CullingJob), typeof(int), typeof(int), typeof(JobHandle)}, ReturnType = typeof(JobHandle))]
	[Calls(Type = typeof(ReadOnly), Member = "get_instancesLength", ReturnType = typeof(int))]
	[Calls(Type = typeof(QualitySettings), Member = "get_maximumLODLevel", ReturnType = typeof(int))]
	[Calls(Type = typeof(LODParameters), Member = "get_cameraPosition", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(OcclusionCullingCommon), Member = "UpdateSilhouettePlanes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Unity.Collections.NativeArray`1<UnityEngine.Plane>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NativeArray`1), Member = "GetSubArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = "Unity.Collections.NativeArray`1<T>")]
	[Calls(Type = typeof(NativeList`1), Member = "AsArray", ReturnType = "Unity.Collections.NativeArray`1<T>")]
	[Calls(Type = typeof(InstanceCullerBurst), Member = "SetupCullingJobInput", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(BatchCullingContext*), typeof(ReceiverPlanes*), typeof(ReceiverSphereCuller*), typeof(FrustumPlaneCuller*), typeof(Single*)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(QualitySettings), Member = "get_lodBias", ReturnType = typeof(float))]
	[Calls(Type = typeof(Unity.Collections.NativeList`1<UnityEngine.Rendering.FrustumPlaneCuller+SplitInfo>), Member = "Dispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JobHandle)}, ReturnType = typeof(JobHandle))]
	[Calls(Type = typeof(Unity.Collections.NativeList`1<UnityEngine.Rendering.ReceiverSphereCuller+SplitInfo>), Member = "Dispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JobHandle)}, ReturnType = typeof(JobHandle))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	private JobHandle CreateFrustumCullingJob(in BatchCullingContext cc, in ReadOnly instanceData, in ReadOnly sharedInstanceData, NativeList<LODGroupCullingData> lodGroupCullingData, in BinningConfig binningConfig, float smallMeshScreenPercentage, OcclusionCullingCommon occlusionCullingCommon, NativeArray<Byte> rendererVisibilityMasks, NativeArray<Byte> rendererCrossFadeValues) { }

	[CalledBy(Type = typeof(InstanceCullingBatcher), Member = "Dispose", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ParallelBitArray), Member = "get_IsCreated", ReturnType = typeof(bool))]
	[Calls(Type = typeof(ParallelBitArray), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(IndirectBufferContextStorage), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(InstanceOcclusionEventDebugArray), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(InstanceCullerSplitDebugArray), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(NativeArray`1), Member = "Dispose", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public override void Dispose() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ParallelBitArray), Member = "get_IsCreated", ReturnType = typeof(bool))]
	[Calls(Type = typeof(ParallelBitArray), Member = "Dispose", ReturnType = typeof(void))]
	private void DisposeCompactVisibilityMasks() { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	private void DisposeSceneViewHiddenBits() { }

	[CalledBy(Type = typeof(InstanceCullingBatcher), Member = "OnFinishedCulling", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(IndirectBufferContextStorage), Member = "TryGetContextIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(IndirectBufferContextStorage), Member = "GetBufferContext", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(IndirectBufferContext))]
	[Calls(Type = typeof(JobHandle), Member = "Complete", ReturnType = typeof(void))]
	[Calls(Type = typeof(IndirectBufferContextStorage), Member = "GetAllocInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(IndirectBufferAllocInfo))]
	[Calls(Type = typeof(CommandBuffer), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(IndirectBufferContextStorage), Member = "CopyFromStaging", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(IndirectBufferAllocInfo&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CommandBuffer), Member = "SetBufferData", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputeBuffer), "Unity.Collections.NativeArray`1<T>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ComputeBuffer), Member = "get_stride", ReturnType = typeof(int))]
	[Calls(Type = typeof(Graphics), Member = "ExecuteCommandBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 1)]
	internal void EnsureValidOcclusionTestResults(int viewInstanceID) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InstanceCullerSplitDebugArray), Member = "MoveToDebugStatsAndClear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DebugRendererBatcherStats)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InstanceOcclusionEventDebugArray), Member = "MoveToDebugStatsAndClear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DebugRendererBatcherStats)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DebugRendererBatcherStats), Member = "FinalizeInstanceCullerViewStats", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private void FlushDebugCounters() { }

	[CalledBy(Type = typeof(InstanceCullingBatcher), Member = "GetCompactedVisibilityMasks", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(ParallelBitArray))]
	[CalledBy(Type = typeof(InstanceCullingBatcher), Member = "OnEndContextRendering", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(JobHandle), Member = "Complete", ReturnType = typeof(void))]
	public ParallelBitArray GetCompactedVisibilityMasks(bool syncCullingJobs) { }

	[CalledBy(Type = typeof(InstanceCullingBatcher), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderersBatchersContext), typeof(InstanceCullingBatcherDesc), typeof(OnFinishedCulling)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(IndirectBufferContextStorage), Member = "Init", ReturnType = typeof(void))]
	[Calls(Type = typeof(OcclusionTestComputeShader), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputeShader)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ComputeShader), Member = "FindKernel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(InstanceCullerSplitDebugArray), Member = "Init", ReturnType = typeof(void))]
	[Calls(Type = typeof(InstanceOcclusionEventDebugArray), Member = "Init", ReturnType = typeof(void))]
	[Calls(Type = typeof(ProfilingSampler), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NativeArray`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Allocator), typeof(NativeArrayOptions)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ComputeBuffer), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(ComputeBufferType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CommandBuffer), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CommandBuffer), Member = "set_name", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	internal void Init(GPUResidentDrawerResources resources, DebugRendererBatcherStats debugStats = null) { }

	[CalledBy(Type = typeof(InstanceCullingBatcher), Member = "InstanceOccludersUpdated", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(OcclusionCullingCommon), Member = "GetOccluderContext", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(OccluderContext&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(InstanceOcclusionEventDebugArray), Member = "TryAdd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(InstanceOcclusionEventType), typeof(int), typeof(int), typeof(OcclusionTest)}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 1)]
	public void InstanceOccludersUpdated(int viewInstanceID, int subviewMask, RenderersBatchersContext batchersContext) { }

	[CalledBy(Type = typeof(GPUResidentBatcher), Member = "InstanceOcclusionTest", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(OcclusionCullingSettings&), typeof(System.ReadOnlySpan`1<UnityEngine.Rendering.SubviewOcclusionTest>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GPUResidentDrawer), Member = "InstanceOcclusionTest", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(OcclusionCullingSettings&), typeof(System.ReadOnlySpan`1<UnityEngine.Rendering.SubviewOcclusionTest>)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(OcclusionCullingCommon), Member = "GetOccluderContext", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(OccluderContext&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(OccluderContext), Member = "Import", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph)}, ReturnType = typeof(OccluderHandles))]
	[Calls(Type = typeof(OccluderHandles), Member = "IsValid", ReturnType = typeof(bool))]
	[Calls(Type = typeof(RenderGraph), Member = "AddComputePass", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"PassData"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "PassData&", typeof(ProfilingSampler), typeof(string), typeof(int)}, ReturnType = typeof(IComputeRenderGraphBuilder))]
	[Calls(Type = typeof(InstanceOcclusionTestSubviewSettings), Member = "FromSpan", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<UnityEngine.Rendering.SubviewOcclusionTest>)}, ReturnType = typeof(InstanceOcclusionTestSubviewSettings))]
	[Calls(Type = typeof(IndirectBufferContextStorage), Member = "ImportBuffers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph)}, ReturnType = typeof(IndirectBufferContextHandles))]
	[Calls(Type = typeof(IndirectBufferContextHandles), Member = "UseForOcclusionTest", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IBaseRenderGraphBuilder)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(OccluderHandles), Member = "UseForOcclusionTest", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IBaseRenderGraphBuilder)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 16)]
	public void InstanceOcclusionTest(RenderGraph renderGraph, in OcclusionCullingSettings settings, ReadOnlySpan<SubviewOcclusionTest> subviewOcclusionTests, RenderersBatchersContext batchersContext) { }

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Camera), Member = "get_cameraType", ReturnType = typeof(CameraType))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public void OnBeginCameraRendering(Camera camera) { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	private void OnBeginSceneViewCameraRendering() { }

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Camera), Member = "get_cameraType", ReturnType = typeof(CameraType))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public void OnEndCameraRendering(Camera camera) { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	private void OnEndSceneViewCameraRendering() { }

	[CalledBy(Type = typeof(InstanceCullingBatcher), Member = "UpdateFrame", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ParallelBitArray), Member = "get_IsCreated", ReturnType = typeof(bool))]
	[Calls(Type = typeof(ParallelBitArray), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(InstanceCullerSplitDebugArray), Member = "MoveToDebugStatsAndClear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DebugRendererBatcherStats)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InstanceOcclusionEventDebugArray), Member = "MoveToDebugStatsAndClear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DebugRendererBatcherStats)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DebugRendererBatcherStats), Member = "FinalizeInstanceCullerViewStats", ReturnType = typeof(void))]
	[Calls(Type = typeof(IndirectBufferContextStorage), Member = "ClearContextsAndGrowBuffers", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void UpdateFrame() { }

}

