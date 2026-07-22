namespace UnityEngine.Rendering;

internal struct IndirectBufferContextStorage : IDisposable
{
	private const int kAllocatorCount = 2; //Field offset: 0x0
	internal const int kInstanceInfoGpuOffsetMultiplier = 2; //Field offset: 0x0
	private IndirectBufferLimits m_BufferLimits; //Field offset: 0x0
	private GraphicsBuffer m_InstanceBuffer; //Field offset: 0x8
	private GraphicsBuffer m_InstanceInfoBuffer; //Field offset: 0x10
	private NativeArray<IndirectInstanceInfo> m_InstanceInfoStaging; //Field offset: 0x18
	private GraphicsBuffer m_DispatchArgsBuffer; //Field offset: 0x28
	private GraphicsBuffer m_DrawArgsBuffer; //Field offset: 0x30
	private GraphicsBuffer m_DrawInfoBuffer; //Field offset: 0x38
	private NativeArray<IndirectDrawInfo> m_DrawInfoStaging; //Field offset: 0x40
	private int m_ContextAllocCounter; //Field offset: 0x50
	private NativeHashMap<Int32, Int32> m_ContextIndexFromViewID; //Field offset: 0x58
	private NativeList<IndirectBufferContext> m_Contexts; //Field offset: 0x60
	private NativeArray<IndirectBufferAllocInfo> m_ContextAllocInfo; //Field offset: 0x68
	private NativeArray<Int32> m_AllocationCounters; //Field offset: 0x78

	public NativeArray<Int32> allocationCounters
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 11
	}

	public GraphicsBuffer dispatchArgsBuffer
	{
		[CallerCount(Count = 15)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public GraphicsBuffer drawArgsBuffer
	{
		[CallerCount(Count = 62)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public GraphicsBuffer drawInfoBuffer
	{
		[CallerCount(Count = 38)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public NativeArray<IndirectDrawInfo> drawInfoGlobalArray
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 11
	}

	public GraphicsBufferHandle indirectDrawArgsBufferHandle
	{
		[CalledBy(Type = typeof(InstanceCuller), Member = "CreateCullJobTree", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BatchCullingContext&), typeof(BatchCullingOutput), typeof(ReadOnly&), typeof(ReadOnly&), typeof(ReadOnly&), typeof(Unity.Collections.NativeList`1<UnityEngine.Rendering.LODGroupCullingData>), typeof(CPUDrawInstanceData), typeof(Unity.Collections.NativeParallelHashMap`2<System.UInt32, UnityEngine.Rendering.BatchID>), typeof(int), typeof(float), typeof(OcclusionCullingCommon)}, ReturnType = typeof(JobHandle))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(GraphicsBuffer), Member = "get_bufferHandle", ReturnType = typeof(GraphicsBufferHandle))]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 29
	}

	public GraphicsBuffer instanceBuffer
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public GraphicsBuffer instanceInfoBuffer
	{
		[CallerCount(Count = 106)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public NativeArray<IndirectInstanceInfo> instanceInfoGlobalArray
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 11
	}

	public GraphicsBufferHandle visibleInstanceBufferHandle
	{
		[CalledBy(Type = typeof(InstanceCuller), Member = "CreateCullJobTree", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BatchCullingContext&), typeof(BatchCullingOutput), typeof(ReadOnly&), typeof(ReadOnly&), typeof(ReadOnly&), typeof(Unity.Collections.NativeList`1<UnityEngine.Rendering.LODGroupCullingData>), typeof(CPUDrawInstanceData), typeof(Unity.Collections.NativeParallelHashMap`2<System.UInt32, UnityEngine.Rendering.BatchID>), typeof(int), typeof(float), typeof(OcclusionCullingCommon)}, ReturnType = typeof(JobHandle))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(GraphicsBuffer), Member = "get_bufferHandle", ReturnType = typeof(GraphicsBufferHandle))]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 29
	}

	[CalledBy(Type = typeof(IndirectBufferContextStorage), Member = "Init", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(IndirectBufferContextStorage), Member = "GrowBuffers", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GraphicsBuffer), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Target), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Marshal), Member = "SizeOf", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(int))]
	[Calls(Type = typeof(NativeArray`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Allocator), typeof(NativeArrayOptions)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	private void AllocateDrawBuffers(int maxDrawCount) { }

	[CalledBy(Type = typeof(IndirectBufferContextStorage), Member = "Init", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(IndirectBufferContextStorage), Member = "GrowBuffers", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GraphicsBuffer), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Target), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Marshal), Member = "SizeOf", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(int))]
	[Calls(Type = typeof(NativeArray`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Allocator), typeof(NativeArrayOptions)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	private void AllocateInstanceBuffers(int maxInstanceCount) { }

	[CalledBy(Type = typeof(InstanceCuller), Member = "UpdateFrame", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(IndirectBufferContextStorage), Member = "SyncContexts", ReturnType = typeof(void))]
	[Calls(Type = typeof(IndirectBufferContextStorage), Member = "GrowBuffers", ReturnType = typeof(void))]
	[Calls(Type = typeof(IndirectBufferContextStorage), Member = "ResetAllocators", ReturnType = typeof(void))]
	public void ClearContextsAndGrowBuffers() { }

	[CalledBy(Type = typeof(InstanceCuller), Member = "EnsureValidOcclusionTestResults", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CommandBuffer), Member = "SetBufferData", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GraphicsBuffer), "Unity.Collections.NativeArray`1<T>", typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CommandBuffer), Member = "SetBufferData", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IndirectInstanceInfo)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GraphicsBuffer), typeof(Unity.Collections.NativeArray`1<UnityEngine.Rendering.IndirectInstanceInfo>), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void CopyFromStaging(CommandBuffer cmd, in IndirectBufferAllocInfo allocInfo) { }

	[CalledBy(Type = typeof(InstanceCuller), Member = "Dispose", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(IndirectBufferContextStorage), Member = "SyncContexts", ReturnType = typeof(void))]
	[Calls(Type = typeof(NativeArray`1), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(IndirectBufferContextStorage), Member = "FreeDrawBuffers", ReturnType = typeof(void))]
	[Calls(Type = typeof(NativeHashMap`2), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(Unity.Collections.NativeList`1<UnityEngine.Rendering.IndirectBufferContext>), Member = "Dispose", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public override void Dispose() { }

	[CalledBy(Type = typeof(IndirectBufferContextStorage), Member = "Dispose", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(IndirectBufferContextStorage), Member = "GrowBuffers", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(NativeArray`1), Member = "Dispose", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	private void FreeDrawBuffers() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NativeArray`1), Member = "Dispose", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	private void FreeInstanceBuffers() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public NativeArray<Int32> get_allocationCounters() { }

	[CallerCount(Count = 15)]
	[DeduplicatedMethod]
	public GraphicsBuffer get_dispatchArgsBuffer() { }

	[CallerCount(Count = 62)]
	[DeduplicatedMethod]
	public GraphicsBuffer get_drawArgsBuffer() { }

	[CallerCount(Count = 38)]
	[DeduplicatedMethod]
	public GraphicsBuffer get_drawInfoBuffer() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public NativeArray<IndirectDrawInfo> get_drawInfoGlobalArray() { }

	[CalledBy(Type = typeof(InstanceCuller), Member = "CreateCullJobTree", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BatchCullingContext&), typeof(BatchCullingOutput), typeof(ReadOnly&), typeof(ReadOnly&), typeof(ReadOnly&), typeof(Unity.Collections.NativeList`1<UnityEngine.Rendering.LODGroupCullingData>), typeof(CPUDrawInstanceData), typeof(Unity.Collections.NativeParallelHashMap`2<System.UInt32, UnityEngine.Rendering.BatchID>), typeof(int), typeof(float), typeof(OcclusionCullingCommon)}, ReturnType = typeof(JobHandle))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GraphicsBuffer), Member = "get_bufferHandle", ReturnType = typeof(GraphicsBufferHandle))]
	[CallsUnknownMethods(Count = 1)]
	public GraphicsBufferHandle get_indirectDrawArgsBufferHandle() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public GraphicsBuffer get_instanceBuffer() { }

	[CallerCount(Count = 106)]
	[DeduplicatedMethod]
	public GraphicsBuffer get_instanceInfoBuffer() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public NativeArray<IndirectInstanceInfo> get_instanceInfoGlobalArray() { }

	[CalledBy(Type = typeof(InstanceCuller), Member = "CreateCullJobTree", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BatchCullingContext&), typeof(BatchCullingOutput), typeof(ReadOnly&), typeof(ReadOnly&), typeof(ReadOnly&), typeof(Unity.Collections.NativeList`1<UnityEngine.Rendering.LODGroupCullingData>), typeof(CPUDrawInstanceData), typeof(Unity.Collections.NativeParallelHashMap`2<System.UInt32, UnityEngine.Rendering.BatchID>), typeof(int), typeof(float), typeof(OcclusionCullingCommon)}, ReturnType = typeof(JobHandle))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GraphicsBuffer), Member = "get_bufferHandle", ReturnType = typeof(GraphicsBufferHandle))]
	[CallsUnknownMethods(Count = 1)]
	public GraphicsBufferHandle get_visibleInstanceBufferHandle() { }

	[CalledBy(Type = typeof(InstanceCuller), Member = "EnsureValidOcclusionTestResults", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InstanceCuller), Member = "AddOcclusionCullingDispatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputeCommandBuffer), typeof(OcclusionCullingSettings&), typeof(InstanceOcclusionTestSubviewSettings&), typeof(IndirectBufferContextHandles&), typeof(OccluderHandles&), typeof(RenderersBatchersContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public IndirectBufferAllocInfo GetAllocInfo(int contextIndex) { }

	[CalledBy(Type = typeof(InstanceCuller), Member = "CreateCullJobTree", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BatchCullingContext&), typeof(BatchCullingOutput), typeof(ReadOnly&), typeof(ReadOnly&), typeof(ReadOnly&), typeof(Unity.Collections.NativeList`1<UnityEngine.Rendering.LODGroupCullingData>), typeof(CPUDrawInstanceData), typeof(Unity.Collections.NativeParallelHashMap`2<System.UInt32, UnityEngine.Rendering.BatchID>), typeof(int), typeof(float), typeof(OcclusionCullingCommon)}, ReturnType = typeof(JobHandle))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(NativeArray`1), Member = "GetSubArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = "Unity.Collections.NativeArray`1<T>")]
	public NativeArray<IndirectBufferAllocInfo> GetAllocInfoSubArray(int contextIndex) { }

	[CalledBy(Type = typeof(InstanceCuller), Member = "EnsureValidOcclusionTestResults", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InstanceCuller), Member = "AddOcclusionCullingDispatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputeCommandBuffer), typeof(OcclusionCullingSettings&), typeof(InstanceOcclusionTestSubviewSettings&), typeof(IndirectBufferContextHandles&), typeof(OccluderHandles&), typeof(RenderersBatchersContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public IndirectBufferContext GetBufferContext(int contextIndex) { }

	[CalledBy(Type = typeof(InstanceCuller), Member = "CreateCullJobTree", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BatchCullingContext&), typeof(BatchCullingOutput), typeof(ReadOnly&), typeof(ReadOnly&), typeof(ReadOnly&), typeof(Unity.Collections.NativeList`1<UnityEngine.Rendering.LODGroupCullingData>), typeof(CPUDrawInstanceData), typeof(Unity.Collections.NativeParallelHashMap`2<System.UInt32, UnityEngine.Rendering.BatchID>), typeof(int), typeof(float), typeof(OcclusionCullingCommon)}, ReturnType = typeof(JobHandle))]
	[CallerCount(Count = 1)]
	public IndirectBufferLimits GetLimits(int contextIndex) { }

	[CalledBy(Type = typeof(IndirectBufferContextStorage), Member = "ClearContextsAndGrowBuffers", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(NativeList`1), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(Unity.Collections.NativeList`1<UnityEngine.Rendering.IndirectBufferContext>), Member = "SetCapacity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NativeArray`1), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(NativeArray`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Allocator), typeof(NativeArrayOptions)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(IndirectBufferContextStorage), Member = "AllocateInstanceBuffers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(IndirectBufferContextStorage), Member = "FreeDrawBuffers", ReturnType = typeof(void))]
	[Calls(Type = typeof(IndirectBufferContextStorage), Member = "AllocateDrawBuffers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private void GrowBuffers() { }

	[CalledBy(Type = typeof(InstanceCuller), Member = "InstanceOcclusionTest", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(OcclusionCullingSettings&), typeof(System.ReadOnlySpan`1<UnityEngine.Rendering.SubviewOcclusionTest>), typeof(RenderersBatchersContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(RenderGraph), Member = "ImportBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GraphicsBuffer), typeof(bool)}, ReturnType = typeof(BufferHandle))]
	[CallsUnknownMethods(Count = 1)]
	public IndirectBufferContextHandles ImportBuffers(RenderGraph renderGraph) { }

	[CalledBy(Type = typeof(InstanceCuller), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GPUResidentDrawerResources), typeof(DebugRendererBatcherStats)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(IndirectBufferContextStorage), Member = "AllocateInstanceBuffers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(IndirectBufferContextStorage), Member = "AllocateDrawBuffers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AllocatorHandle), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Allocator)}, ReturnType = typeof(AllocatorHandle))]
	[Calls(Type = typeof(NativeHashMap`2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(AllocatorHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Unity.Collections.NativeList`1<UnityEngine.Rendering.IndirectBufferContext>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(AllocatorHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NativeArray`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Allocator), typeof(NativeArrayOptions)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(IndirectBufferContextStorage), Member = "ResetAllocators", ReturnType = typeof(void))]
	public void Init() { }

	[CalledBy(Type = typeof(IndirectBufferContextStorage), Member = "Init", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(IndirectBufferContextStorage), Member = "ClearContextsAndGrowBuffers", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(NativeHashMap`2), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(NativeList`1), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(ArrayExtensions), Member = "FillArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Collections.NativeArray`1<T>&", "T&", typeof(int), typeof(int)}, ReturnType = typeof(void))]
	private void ResetAllocators() { }

	[CalledBy(Type = typeof(InstanceCuller), Member = "CreateCullJobTree", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BatchCullingContext&), typeof(BatchCullingOutput), typeof(ReadOnly&), typeof(ReadOnly&), typeof(ReadOnly&), typeof(Unity.Collections.NativeList`1<UnityEngine.Rendering.LODGroupCullingData>), typeof(CPUDrawInstanceData), typeof(Unity.Collections.NativeParallelHashMap`2<System.UInt32, UnityEngine.Rendering.BatchID>), typeof(int), typeof(float), typeof(OcclusionCullingCommon)}, ReturnType = typeof(JobHandle))]
	[CalledBy(Type = typeof(InstanceCuller), Member = "AddOcclusionCullingDispatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputeCommandBuffer), typeof(OcclusionCullingSettings&), typeof(InstanceOcclusionTestSubviewSettings&), typeof(IndirectBufferContextHandles&), typeof(OccluderHandles&), typeof(RenderersBatchersContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public void SetBufferContext(int contextIndex, IndirectBufferContext ctx) { }

	[CalledBy(Type = typeof(IndirectBufferContextStorage), Member = "Dispose", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(IndirectBufferContextStorage), Member = "ClearContextsAndGrowBuffers", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(JobHandle), Member = "Complete", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	private void SyncContexts() { }

	[CalledBy(Type = typeof(InstanceCuller), Member = "CreateCullJobTree", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BatchCullingContext&), typeof(BatchCullingOutput), typeof(ReadOnly&), typeof(ReadOnly&), typeof(ReadOnly&), typeof(Unity.Collections.NativeList`1<UnityEngine.Rendering.LODGroupCullingData>), typeof(CPUDrawInstanceData), typeof(Unity.Collections.NativeParallelHashMap`2<System.UInt32, UnityEngine.Rendering.BatchID>), typeof(int), typeof(float), typeof(OcclusionCullingCommon)}, ReturnType = typeof(JobHandle))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(NativeHashMap`2), Member = "ContainsKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Unity.Collections.NativeList`1<UnityEngine.Rendering.IndirectBufferContext>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IndirectBufferContext&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NativeHashMap`2), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue"}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	public int TryAllocateContext(int viewID) { }

	[CalledBy(Type = typeof(InstanceCuller), Member = "EnsureValidOcclusionTestResults", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InstanceCuller), Member = "AddOcclusionCullingDispatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputeCommandBuffer), typeof(OcclusionCullingSettings&), typeof(InstanceOcclusionTestSubviewSettings&), typeof(IndirectBufferContextHandles&), typeof(OccluderHandles&), typeof(RenderersBatchersContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(NativeHashMap`2), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue&"}, ReturnType = typeof(bool))]
	public int TryGetContextIndex(int viewID) { }

}

