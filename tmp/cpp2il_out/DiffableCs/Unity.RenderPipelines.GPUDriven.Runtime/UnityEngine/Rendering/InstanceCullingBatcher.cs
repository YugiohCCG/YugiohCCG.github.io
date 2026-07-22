namespace UnityEngine.Rendering;

internal class InstanceCullingBatcher : IDisposable
{
	private RenderersBatchersContext m_BatchersContext; //Field offset: 0x10
	private CPUDrawInstanceData m_DrawInstanceData; //Field offset: 0x18
	private BatchRendererGroup m_BRG; //Field offset: 0x20
	private NativeParallelHashMap<UInt32, BatchID> m_GlobalBatchIDs; //Field offset: 0x28
	private InstanceCuller m_Culler; //Field offset: 0x38
	private NativeParallelHashMap<Int32, BatchMaterialID> m_BatchMaterialHash; //Field offset: 0x1C8
	private NativeParallelHashMap<Int32, GPUDrivenPackedMaterialData> m_PackedMaterialHash; //Field offset: 0x1D8
	private NativeParallelHashMap<Int32, BatchMeshID> m_BatchMeshHash; //Field offset: 0x1E8
	private int m_CachedInstanceDataBufferLayoutVersion; //Field offset: 0x1F8
	private OnCullingCompleteCallback m_OnCompleteCallback; //Field offset: 0x200

	public NativeParallelHashMap<Int32, BatchMaterialID> batchMaterialHash
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 14
	}

	internal InstanceCuller culler
	{
		[CallerCount(Count = 10)]
		[DeduplicatedMethod]
		internal get { } //Length: 5
	}

	public NativeParallelHashMap<Int32, GPUDrivenPackedMaterialData> packedMaterialHash
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 14
	}

	[CalledBy(Type = typeof(GPUResidentBatcher), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderersBatchersContext), typeof(InstanceCullingBatcherDesc), "UnityEngine.Rendering.GPUDrivenProcessor"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GPUResidentDrawer), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GPUResidentDrawerSettings), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(NativeParallelHashMap`2), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InstanceCullingBatcher), Member = "GetBatchID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InstanceComponentGroup)}, ReturnType = typeof(BatchID))]
	[Calls(Type = typeof(InstanceCuller), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GPUResidentDrawerResources), typeof(DebugRendererBatcherStats)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BatchRendererGroup), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BatchRendererGroupCreateInfo)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(OnPerformCulling), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NativeList`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(AllocatorHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Unity.Collections.NativeList`1<UnityEngine.Rendering.DrawInstance>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(AllocatorHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Unity.Collections.NativeList`1<UnityEngine.Rendering.DrawBatch>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AllocatorHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NativeParallelHashMap`2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(AllocatorHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NativeList`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AllocatorHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Unity.Collections.NativeParallelHashMap`2<UnityEngine.Rendering.RangeKey, System.Int32>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(AllocatorHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AllocatorHandle), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Allocator)}, ReturnType = typeof(AllocatorHandle))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 8)]
	public InstanceCullingBatcher(RenderersBatchersContext batcherContext, InstanceCullingBatcherDesc desc, OnFinishedCulling onFinishedCulling) { }

	[CalledBy(Type = typeof(GPUResidentBatcher), Member = "UpdateRendererInstancesAndBatches", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GPUDrivenRendererGroupData&), typeof(System.Collections.Generic.IList`1<UnityEngine.Mesh>), typeof(System.Collections.Generic.IList`1<UnityEngine.Material>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GPUResidentBatcher), Member = "UpdateRendererBatches", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GPUDrivenRendererGroupData&), typeof(System.Collections.Generic.IList`1<UnityEngine.Mesh>), typeof(System.Collections.Generic.IList`1<UnityEngine.Material>)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(InstanceCullingBatcher), Member = "RegisterBatchMaterials", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NativeArray`1<Int32>&), typeof(NativeArray`1<GPUDrivenPackedMaterialData>&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InstanceCullingBatcher), Member = "RegisterBatchMeshes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Unity.Collections.NativeArray`1<System.Int32>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CreateDrawBatches_00000188$BurstDirectCall), Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(NativeArray`1<InstanceHandle>&), typeof(GPUDrivenRendererGroupData&), typeof(NativeParallelHashMap`2<Int32, BatchMeshID>&), typeof(NativeParallelHashMap`2<Int32, BatchMaterialID>&), typeof(NativeParallelHashMap`2<Int32, GPUDrivenPackedMaterialData>&), typeof(NativeParallelHashMap`2<RangeKey, Int32>&), typeof(NativeList`1<DrawRange>&), typeof(NativeParallelHashMap`2<DrawKey, Int32>&), typeof(NativeList`1<DrawBatch>&), typeof(NativeList`1<DrawInstance>&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InstanceCullingBatcher), Member = "UpdateInstanceDataBufferLayoutVersion", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public void BuildBatch(NativeArray<InstanceHandle> instances, in GPUDrivenRendererGroupData rendererData, bool registerMaterialsAndMeshes) { }

	[CalledBy(Type = typeof(GPUResidentBatcher), Member = "DestroyDrawInstances", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Unity.Collections.NativeArray`1<UnityEngine.Rendering.InstanceHandle>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GPUResidentBatcher), Member = "FreeRendererGroupInstances", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Unity.Collections.NativeArray`1<System.Int32>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GPUResidentDrawer), Member = "PostPostLateUpdate", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GPUResidentDrawer), Member = "ProcessMeshes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Unity.Collections.NativeArray`1<System.Int32>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GPUResidentDrawer), Member = "ProcessRendererMaterialAndMeshChanges", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Unity.Collections.NativeArray`1<System.Int32>), typeof(Unity.Collections.NativeArray`1<System.Int32>), typeof(Unity.Collections.NativeArray`1<UnityEngine.Rendering.GPUDrivenPackedMaterialData>), typeof(Unity.Collections.NativeArray`1<System.Int32>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GPUResidentDrawer), Member = "ProcessRenderers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.TypeDispatchData", typeof(Unity.Collections.NativeArray`1<System.Int32>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GPUResidentDrawer), Member = "FreeInstances", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Unity.Collections.NativeArray`1<UnityEngine.Rendering.InstanceHandle>)}, ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(CPUDrawInstanceData), Member = "DestroyDrawInstances", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Unity.Collections.NativeArray`1<UnityEngine.Rendering.InstanceHandle>)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void DestroyDrawInstances(NativeArray<InstanceHandle> instances) { }

	[CalledBy(Type = typeof(GPUResidentBatcher), Member = "DestroyMaterials", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Unity.Collections.NativeArray`1<System.Int32>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GPUResidentDrawer), Member = "PostPostLateUpdate", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GPUResidentDrawer), Member = "ProcessMaterials", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Unity.Collections.NativeArray`1<System.Int32>), typeof(Unity.Collections.NativeArray`1<System.Int32>)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(AllocatorHandle), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Allocator)}, ReturnType = typeof(AllocatorHandle))]
	[Calls(Type = typeof(NativeList`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(AllocatorHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NativeArray`1), Member = "GetEnumerator", ReturnType = "Unity.Collections.NativeArray`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(NativeParallelHashMap`2), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue&"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(NativeList`1), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NativeParallelHashMap`2), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BatchRendererGroup), Member = "UnregisterMaterial", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BatchMaterialID)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NativeList`1), Member = "AsArray", ReturnType = "Unity.Collections.NativeArray`1<T>")]
	[Calls(Type = typeof(CPUDrawInstanceData), Member = "DestroyMaterialDrawInstances", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Unity.Collections.NativeArray`1<System.UInt32>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Unity.Collections.NativeList`1<System.UInt32>), Member = "Dispose", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	public void DestroyMaterials(NativeArray<Int32> destroyedMaterials) { }

	[CalledBy(Type = typeof(GPUResidentBatcher), Member = "DestroyMeshes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Unity.Collections.NativeArray`1<System.Int32>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GPUResidentDrawer), Member = "PostPostLateUpdate", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GPUResidentDrawer), Member = "ProcessMeshes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Unity.Collections.NativeArray`1<System.Int32>)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(NativeArray`1), Member = "GetEnumerator", ReturnType = "Unity.Collections.NativeArray`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(NativeParallelHashMap`2), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue&"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(NativeParallelHashMap`2), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BatchRendererGroup), Member = "UnregisterMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BatchMeshID)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public void DestroyMeshes(NativeArray<Int32> destroyedMeshes) { }

	[CalledBy(Type = typeof(GPUResidentBatcher), Member = "Dispose", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GPUResidentDrawer), Member = "Dispose", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(InstanceCuller), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = "Unity.Collections.LowLevel.Unsafe.UnsafeParallelHashMapData", Member = "MoveNextSearch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnsafeParallelHashMapData*), typeof(Int32&), typeof(Int32&), typeof(Int32&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BatchRendererGroup), Member = "RemoveBatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BatchID)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NativeParallelHashMap`2), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(BatchRendererGroup), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(Unity.Collections.NativeList`1<System.Int32>), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(Unity.Collections.NativeList`1<UnityEngine.Rendering.DrawInstance>), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(Unity.Collections.NativeList`1<UnityEngine.Rendering.DrawBatch>), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(Unity.Collections.NativeList`1<UnityEngine.Rendering.DrawRange>), Member = "Dispose", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 7)]
	public override void Dispose() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public NativeParallelHashMap<Int32, BatchMaterialID> get_batchMaterialHash() { }

	[CallerCount(Count = 10)]
	[DeduplicatedMethod]
	internal InstanceCuller get_culler() { }

	[CallerCount(Count = 0)]
	public NativeParallelHashMap<Int32, GPUDrivenPackedMaterialData> get_packedMaterialHash() { }

	[CalledBy(Type = typeof(InstanceCullingBatcher), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderersBatchersContext), typeof(InstanceCullingBatcherDesc), typeof(OnFinishedCulling)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InstanceCullingBatcher), Member = "UpdateInstanceDataBufferLayoutVersion", ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(RenderersBatchersContext), Member = "get_instanceDataBufferLayoutVersion", ReturnType = typeof(int))]
	[Calls(Type = typeof(RenderersBatchersContext), Member = "get_defaultMetadata", ReturnType = typeof(Unity.Collections.NativeArray`1<UnityEngine.Rendering.MetadataValue>))]
	[Calls(Type = typeof(AllocatorHandle), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Allocator)}, ReturnType = typeof(AllocatorHandle))]
	[Calls(Type = typeof(NativeList`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(AllocatorHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderersBatchersContext), Member = "get_defaultDescriptions", ReturnType = typeof(Unity.Collections.NativeArray`1+ReadOnly<UnityEngine.Rendering.GPUInstanceComponentDesc>))]
	[Calls(Type = typeof(NativeList`1), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NativeList`1), Member = "AsArray", ReturnType = "Unity.Collections.NativeArray`1<T>")]
	[Calls(Type = typeof(RenderersBatchersContext), Member = "get_gpuInstanceDataBuffer", ReturnType = typeof(GraphicsBuffer))]
	[Calls(Type = typeof(GraphicsBuffer), Member = "get_bufferHandle", ReturnType = typeof(GraphicsBufferHandle))]
	[Calls(Type = typeof(BatchRendererGroup), Member = "AddBatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Unity.Collections.NativeArray`1<UnityEngine.Rendering.MetadataValue>), typeof(GraphicsBufferHandle)}, ReturnType = typeof(BatchID))]
	[CallsUnknownMethods(Count = 2)]
	private BatchID GetBatchID(InstanceComponentGroup componentsOverriden) { }

	[CalledBy(Type = typeof(GPUResidentBatcher), Member = "ProcessTrees", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InstanceCuller), Member = "GetCompactedVisibilityMasks", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(ParallelBitArray))]
	public ParallelBitArray GetCompactedVisibilityMasks(bool syncCullingJobs) { }

	[CallerCount(Count = 31)]
	[DeduplicatedMethod]
	public CPUDrawInstanceData GetDrawInstanceData() { }

	[CalledBy(Type = "UnityEngine.Rendering.OcclusionCullingCommon+<>c", Member = "<UpdateInstanceOccluders>b__37_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.OcclusionCullingCommon+UpdateOccludersPassData", typeof(ComputeGraphContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InstanceCuller), Member = "InstanceOccludersUpdated", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(RenderersBatchersContext)}, ReturnType = typeof(void))]
	public void InstanceOccludersUpdated(int viewInstanceID, int subviewMask) { }

	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public void OnBeginCameraRendering(Camera camera) { }

	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public void OnEndCameraRendering(Camera camera) { }

	[CalledBy(Type = typeof(GPUResidentBatcher), Member = "OnEndContextRendering", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GPUResidentDrawer), Member = "OnEndContextRendering", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), typeof(System.Collections.Generic.List`1<UnityEngine.Camera>)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(InstanceCuller), Member = "GetCompactedVisibilityMasks", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(ParallelBitArray))]
	[Calls(Type = typeof(ParallelBitArray), Member = "get_IsCreated", ReturnType = typeof(bool))]
	[Calls(Type = typeof(RenderersBatchersContext), Member = "UpdatePerFrameInstanceVisibility", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParallelBitArray&)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void OnEndContextRendering() { }

	[CalledBy(Type = typeof(GPUResidentBatcher), Member = "OnFinishedCulling", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InstanceCuller), Member = "EnsureValidOcclusionTestResults", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	public void OnFinishedCulling(IntPtr customCullingResult) { }

	[CallerCount(Count = 0)]
	[Calls(Type = "Unity.Collections.LowLevel.Unsafe.UnsafeParallelHashMapData", Member = "MoveNextSearch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnsafeParallelHashMapData*), typeof(Int32&), typeof(Int32&), typeof(Int32&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CPUDrawInstanceData), Member = "RebuildDrawListsIfNeeded", ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderersBatchersContext), Member = "get_hasBoundingSpheres", ReturnType = typeof(bool))]
	[Calls(Type = typeof(RenderersBatchersContext), Member = "get_instanceData", ReturnType = typeof(ReadOnly))]
	[Calls(Type = typeof(RenderersBatchersContext), Member = "get_sharedInstanceData", ReturnType = typeof(ReadOnly))]
	[Calls(Type = typeof(RenderersBatchersContext), Member = "get_instanceDataBuffer", ReturnType = typeof(ReadOnly))]
	[Calls(Type = typeof(RenderersBatchersContext), Member = "get_crossfadedRendererCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(InstanceCuller), Member = "CreateCullJobTree", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BatchCullingContext&), typeof(BatchCullingOutput), typeof(ReadOnly&), typeof(ReadOnly&), typeof(ReadOnly&), typeof(Unity.Collections.NativeList`1<UnityEngine.Rendering.LODGroupCullingData>), typeof(CPUDrawInstanceData), typeof(Unity.Collections.NativeParallelHashMap`2<System.UInt32, UnityEngine.Rendering.BatchID>), typeof(int), typeof(float), typeof(OcclusionCullingCommon)}, ReturnType = typeof(JobHandle))]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 6)]
	public JobHandle OnPerformCulling(BatchRendererGroup rendererGroup, BatchCullingContext cc, BatchCullingOutput cullingOutput, IntPtr userContext) { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	public void PostCullBeginCameraRendering(RenderRequestBatcherContext context) { }

	[CalledBy(Type = typeof(InstanceCullingBatcher), Member = "BuildBatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Unity.Collections.NativeArray`1<UnityEngine.Rendering.InstanceHandle>), typeof(GPUDrivenRendererGroupData&), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(NativeArray`1), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(Unity.Collections.NativeList`1<UnityEngine.Rendering.GPUDrivenPackedMaterialData>), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(Unity.Collections.NativeList`1<System.Int32>), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(IJobParallelForExtensions), Member = "Schedule", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RegisterNewMaterialsJob)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RegisterNewMaterialsJob), typeof(int), typeof(int), typeof(JobHandle)}, ReturnType = typeof(JobHandle))]
	[Calls(Type = typeof(NativeParallelHashMap`2), Member = "AsParallelWriter", ReturnType = "Unity.Collections.NativeParallelHashMap`2<TKey, TValue>+ParallelWriter<TKey, TValue>")]
	[Calls(Type = typeof(Math), Member = "Max", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(BatchRendererGroup), Member = "RegisterMaterials", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Int32>), typeof(System.Span`1<UnityEngine.Rendering.BatchMaterialID>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NativeArray`1), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Collections.NativeArray`1<T>&"}, ReturnType = "System.Span`1<T>")]
	[Calls(Type = typeof(NativeArray`1), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Collections.NativeArray`1<T>&"}, ReturnType = "System.ReadOnlySpan`1<T>")]
	[Calls(Type = typeof(NativeList`1), Member = "AsArray", ReturnType = "Unity.Collections.NativeArray`1<T>")]
	[Calls(Type = typeof(NativeArray`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Allocator), typeof(NativeArrayOptions)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(JobHandle), Member = "Complete", ReturnType = typeof(void))]
	[Calls(Type = typeof(IJobParallelForBatchExtensions), Member = "ScheduleBatch", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FindNonRegisteredMaterialsJob)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FindNonRegisteredMaterialsJob), typeof(int), typeof(int), typeof(JobHandle)}, ReturnType = typeof(JobHandle))]
	[Calls(Type = typeof(NativeList`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(AllocatorHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AllocatorHandle), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Allocator)}, ReturnType = typeof(AllocatorHandle))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 7)]
	private void RegisterBatchMaterials(in NativeArray<Int32>& usedMaterialIDs, in NativeArray<GPUDrivenPackedMaterialData>& usedPackedMaterialDatas) { }

	[CalledBy(Type = typeof(InstanceCullingBatcher), Member = "BuildBatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Unity.Collections.NativeArray`1<UnityEngine.Rendering.InstanceHandle>), typeof(GPUDrivenRendererGroupData&), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(NativeArray`1), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(Unity.Collections.NativeList`1<System.Int32>), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(IJobParallelForExtensions), Member = "Schedule", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RegisterNewMeshesJob)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RegisterNewMeshesJob), typeof(int), typeof(int), typeof(JobHandle)}, ReturnType = typeof(JobHandle))]
	[Calls(Type = typeof(NativeParallelHashMap`2), Member = "AsParallelWriter", ReturnType = "Unity.Collections.NativeParallelHashMap`2<TKey, TValue>+ParallelWriter<TKey, TValue>")]
	[Calls(Type = typeof(Math), Member = "Max", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(BatchRendererGroup), Member = "RegisterMeshes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Int32>), typeof(System.Span`1<UnityEngine.Rendering.BatchMeshID>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NativeArray`1), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Collections.NativeArray`1<T>&"}, ReturnType = "System.Span`1<T>")]
	[Calls(Type = typeof(NativeArray`1), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Collections.NativeArray`1<T>&"}, ReturnType = "System.ReadOnlySpan`1<T>")]
	[Calls(Type = typeof(NativeList`1), Member = "AsArray", ReturnType = "Unity.Collections.NativeArray`1<T>")]
	[Calls(Type = typeof(NativeArray`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Allocator), typeof(NativeArrayOptions)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(JobHandle), Member = "Complete", ReturnType = typeof(void))]
	[Calls(Type = typeof(IJobParallelForBatchExtensions), Member = "ScheduleBatch", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FindNonRegisteredMeshesJob)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FindNonRegisteredMeshesJob), typeof(int), typeof(int), typeof(JobHandle)}, ReturnType = typeof(JobHandle))]
	[Calls(Type = typeof(NativeList`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(AllocatorHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AllocatorHandle), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Allocator)}, ReturnType = typeof(AllocatorHandle))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 5)]
	private void RegisterBatchMeshes(NativeArray<Int32> meshIDs) { }

	[CalledBy(Type = typeof(GPUResidentBatcher), Member = "SchedulePackedMaterialCacheUpdate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Unity.Collections.NativeArray`1<System.Int32>), typeof(Unity.Collections.NativeArray`1<UnityEngine.Rendering.GPUDrivenPackedMaterialData>)}, ReturnType = typeof(JobHandle))]
	[CalledBy(Type = typeof(GPUResidentDrawer), Member = "ProcessRendererMaterialAndMeshChanges", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Unity.Collections.NativeArray`1<System.Int32>), typeof(Unity.Collections.NativeArray`1<System.Int32>), typeof(Unity.Collections.NativeArray`1<UnityEngine.Rendering.GPUDrivenPackedMaterialData>), typeof(Unity.Collections.NativeArray`1<System.Int32>)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(NativeArray`1), Member = "AsReadOnly", ReturnType = "Unity.Collections.NativeArray`1<T>+ReadOnly<T>")]
	[Calls(Type = typeof(IJobExtensions), Member = "Schedule", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UpdatePackedMaterialDataCacheJob)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UpdatePackedMaterialDataCacheJob), typeof(JobHandle)}, ReturnType = typeof(JobHandle))]
	public JobHandle SchedulePackedMaterialCacheUpdate(NativeArray<Int32> materialIDs, NativeArray<GPUDrivenPackedMaterialData> packedMaterialDatas) { }

	[CalledBy(Type = typeof(GPUResidentBatcher), Member = "UpdateFrame", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GPUResidentDrawer), Member = "PostPostLateUpdate", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(InstanceCuller), Member = "UpdateFrame", ReturnType = typeof(void))]
	public void UpdateFrame() { }

	[CalledBy(Type = typeof(InstanceCullingBatcher), Member = "BuildBatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Unity.Collections.NativeArray`1<UnityEngine.Rendering.InstanceHandle>), typeof(GPUDrivenRendererGroupData&), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(RenderersBatchersContext), Member = "get_instanceDataBufferLayoutVersion", ReturnType = typeof(int))]
	[Calls(Type = "Unity.Collections.LowLevel.Unsafe.UnsafeParallelHashMapData", Member = "MoveNextSearch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnsafeParallelHashMapData*), typeof(Int32&), typeof(Int32&), typeof(Int32&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BatchRendererGroup), Member = "RemoveBatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BatchID)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(KeyValue`2), Member = "get_Key", ReturnType = "TKey")]
	[Calls(Type = typeof(InstanceCullingBatcher), Member = "GetBatchID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InstanceComponentGroup)}, ReturnType = typeof(BatchID))]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 5)]
	private void UpdateInstanceDataBufferLayoutVersion() { }

}

