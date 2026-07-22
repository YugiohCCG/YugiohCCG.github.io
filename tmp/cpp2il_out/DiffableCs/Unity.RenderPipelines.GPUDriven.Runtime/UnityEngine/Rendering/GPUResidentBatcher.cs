namespace UnityEngine.Rendering;

internal class GPUResidentBatcher : IDisposable
{
	private ParallelBitArray m_ProcessedThisFrameTreeBits; //Field offset: 0x10
	private RenderersBatchersContext m_BatchersContext; //Field offset: 0x30
	private GPUDrivenProcessor m_GPUDrivenProcessor; //Field offset: 0x38
	private GPUDrivenRendererDataCallback m_UpdateRendererInstancesAndBatchesCallback; //Field offset: 0x40
	private GPUDrivenRendererDataCallback m_UpdateRendererBatchesCallback; //Field offset: 0x48
	private InstanceCullingBatcher m_InstanceCullingBatcher; //Field offset: 0x50

	internal RenderersBatchersContext batchersContext
	{
		[CallerCount(Count = 62)]
		[DeduplicatedMethod]
		internal get { } //Length: 5
	}

	internal InstanceCullingBatcher instanceCullingBatcher
	{
		[CallerCount(Count = 16)]
		[DeduplicatedMethod]
		internal get { } //Length: 5
	}

	internal OcclusionCullingCommon occlusionCullingCommon
	{
		[CalledBy(Type = "UnityEngine.Rendering.OcclusionCullingCommon+<>c", Member = "<RenderDebugOcclusionTestOverlay>b__29_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.OcclusionCullingCommon+OcclusionTestOverlaySetupPassData", typeof(ComputeGraphContext)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.OcclusionCullingCommon+<>c", Member = "<UpdateInstanceOccluders>b__37_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.OcclusionCullingCommon+UpdateOccludersPassData", typeof(ComputeGraphContext)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		internal get { } //Length: 30
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InstanceCullingBatcher), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderersBatchersContext), typeof(InstanceCullingBatcherDesc), typeof(OnFinishedCulling)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 5)]
	public GPUResidentBatcher(RenderersBatchersContext batcherContext, InstanceCullingBatcherDesc instanceCullerBatcherDesc, GPUDrivenProcessor gpuDrivenProcessor) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InstanceCullingBatcher), Member = "DestroyDrawInstances", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Unity.Collections.NativeArray`1<UnityEngine.Rendering.InstanceHandle>)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void DestroyDrawInstances(NativeArray<InstanceHandle> instances) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InstanceCullingBatcher), Member = "DestroyMaterials", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Unity.Collections.NativeArray`1<System.Int32>)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void DestroyMaterials(NativeArray<Int32> destroyedMaterials) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InstanceCullingBatcher), Member = "DestroyMeshes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Unity.Collections.NativeArray`1<System.Int32>)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void DestroyMeshes(NativeArray<Int32> destroyedMeshes) { }

	[CallerCount(Count = 0)]
	[Calls(Type = "UnityEngine.Rendering.GPUDrivenProcessor", Member = "ClearMaterialFilters", ReturnType = typeof(void))]
	[Calls(Type = typeof(InstanceCullingBatcher), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(ParallelBitArray), Member = "get_IsCreated", ReturnType = typeof(bool))]
	[Calls(Type = typeof(ParallelBitArray), Member = "Dispose", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public override void Dispose() { }

	[CalledBy(Type = typeof(GPUResidentBatcher), Member = "UpdateRendererInstancesAndBatches", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GPUDrivenRendererGroupData&), typeof(System.Collections.Generic.IList`1<UnityEngine.Mesh>), typeof(System.Collections.Generic.IList`1<UnityEngine.Material>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GPUResidentDrawer), Member = "ProcessRenderers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.TypeDispatchData", typeof(Unity.Collections.NativeArray`1<System.Int32>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GPUResidentDrawer), Member = "FreeRendererGroupInstances", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Unity.Collections.NativeArray`1<System.Int32>), typeof(Unity.Collections.NativeArray`1<System.Int32>)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(AllocatorHandle), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Allocator)}, ReturnType = typeof(AllocatorHandle))]
	[Calls(Type = typeof(NativeList`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(AllocatorHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderersBatchersContext), Member = "ScheduleQueryRendererGroupInstancesJob", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Unity.Collections.NativeArray`1<System.Int32>), typeof(Unity.Collections.NativeList`1<UnityEngine.Rendering.InstanceHandle>)}, ReturnType = typeof(JobHandle))]
	[Calls(Type = typeof(JobHandle), Member = "Complete", ReturnType = typeof(void))]
	[Calls(Type = typeof(NativeList`1), Member = "AsArray", ReturnType = "Unity.Collections.NativeArray`1<T>")]
	[Calls(Type = typeof(InstanceCullingBatcher), Member = "DestroyDrawInstances", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Unity.Collections.NativeArray`1<UnityEngine.Rendering.InstanceHandle>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Unity.Collections.NativeList`1<UnityEngine.Rendering.InstanceHandle>), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderersBatchersContext), Member = "FreeRendererGroupInstances", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Unity.Collections.NativeArray`1<System.Int32>)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	internal void FreeRendererGroupInstances(NativeArray<Int32> rendererGroupIDs) { }

	[CallerCount(Count = 62)]
	[DeduplicatedMethod]
	internal RenderersBatchersContext get_batchersContext() { }

	[CallerCount(Count = 16)]
	[DeduplicatedMethod]
	internal InstanceCullingBatcher get_instanceCullingBatcher() { }

	[CalledBy(Type = "UnityEngine.Rendering.OcclusionCullingCommon+<>c", Member = "<RenderDebugOcclusionTestOverlay>b__29_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.OcclusionCullingCommon+OcclusionTestOverlaySetupPassData", typeof(ComputeGraphContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.OcclusionCullingCommon+<>c", Member = "<UpdateInstanceOccluders>b__37_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.OcclusionCullingCommon+UpdateOccludersPassData", typeof(ComputeGraphContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	internal OcclusionCullingCommon get_occlusionCullingCommon() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RenderersBatchersContext), Member = "get_hasBoundingSpheres", ReturnType = typeof(bool))]
	[Calls(Type = typeof(InstanceCuller), Member = "InstanceOcclusionTest", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(OcclusionCullingSettings&), typeof(System.ReadOnlySpan`1<UnityEngine.Rendering.SubviewOcclusionTest>), typeof(RenderersBatchersContext)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void InstanceOcclusionTest(RenderGraph renderGraph, in OcclusionCullingSettings settings, ReadOnlySpan<SubviewOcclusionTest> subviewOcclusionTests) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public void OnBeginCameraRendering(Camera camera) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ParallelBitArray), Member = "get_IsCreated", ReturnType = typeof(bool))]
	[Calls(Type = typeof(ParallelBitArray), Member = "Dispose", ReturnType = typeof(void))]
	public void OnBeginContextRendering() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public void OnEndCameraRendering(Camera camera) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InstanceCullingBatcher), Member = "OnEndContextRendering", ReturnType = typeof(void))]
	public void OnEndContextRendering() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GPUResidentBatcher), Member = "ProcessTrees", ReturnType = typeof(void))]
	[Calls(Type = typeof(InstanceCullingBatcher), Member = "OnFinishedCulling", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private void OnFinishedCulling(IntPtr customCullingResult) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RenderersBatchersContext), Member = "UpdateAmbientProbeAndGpuBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void OnSetupAmbientProbe() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void PostCullBeginCameraRendering(RenderRequestBatcherContext context) { }

	[CalledBy(Type = typeof(GPUResidentBatcher), Member = "OnFinishedCulling", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Application), Member = "get_isPlaying", ReturnType = typeof(bool))]
	[Calls(Type = typeof(NativeArray`1), Member = "GetSubArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = "Unity.Collections.NativeArray`1<T>")]
	[Calls(Type = typeof(NativeList`1), Member = "AsArray", ReturnType = "Unity.Collections.NativeArray`1<T>")]
	[Calls(Type = typeof(RenderersBatchersContext), Member = "GetVisibleTreeInstances", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParallelBitArray&), typeof(ParallelBitArray&), typeof(Unity.Collections.NativeList`1<System.Int32>), typeof(Unity.Collections.NativeList`1<UnityEngine.Rendering.InstanceHandle>), typeof(bool), typeof(Int32&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NativeList`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AllocatorHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AllocatorHandle), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Allocator)}, ReturnType = typeof(AllocatorHandle))]
	[Calls(Type = typeof(Unity.Collections.NativeList`1<UnityEngine.Rendering.InstanceHandle>), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(ParallelBitArray), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Allocator), typeof(NativeArrayOptions)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ParallelBitArray), Member = "Resize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderersBatchersContext), Member = "get_aliveInstances", ReturnType = typeof(Unity.Collections.NativeArray`1<UnityEngine.Rendering.InstanceHandle>))]
	[Calls(Type = typeof(ParallelBitArray), Member = "get_IsCreated", ReturnType = typeof(bool))]
	[Calls(Type = typeof(InstanceCullingBatcher), Member = "GetCompactedVisibilityMasks", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(ParallelBitArray))]
	[Calls(Type = typeof(RenderersBatchersContext), Member = "GetAliveInstancesOfType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InstanceType)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(GPUResidentBatcher), Member = "UpdateSpeedTreeWindAndUploadWindParamsToGPU", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Unity.Collections.NativeArray`1<System.Int32>), typeof(Unity.Collections.NativeArray`1<UnityEngine.Rendering.InstanceHandle>), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Unity.Collections.NativeList`1<System.Int32>), Member = "Dispose", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	private void ProcessTrees() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InstanceCullingBatcher), Member = "SchedulePackedMaterialCacheUpdate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Unity.Collections.NativeArray`1<System.Int32>), typeof(Unity.Collections.NativeArray`1<UnityEngine.Rendering.GPUDrivenPackedMaterialData>)}, ReturnType = typeof(JobHandle))]
	[CallsUnknownMethods(Count = 1)]
	public JobHandle SchedulePackedMaterialCacheUpdate(NativeArray<Int32> materialIDs, NativeArray<GPUDrivenPackedMaterialData> packedMaterialDatas) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InstanceCullingBatcher), Member = "UpdateFrame", ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderersBatchersContext), Member = "UpdateFrame", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void UpdateFrame() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RenderersBatchersContext), Member = "get_hasBoundingSpheres", ReturnType = typeof(bool))]
	[Calls(Type = typeof(OcclusionCullingCommon), Member = "UpdateInstanceOccluders", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(OccluderParameters&), typeof(System.ReadOnlySpan`1<UnityEngine.Rendering.OccluderSubviewUpdate>)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	public void UpdateInstanceOccluders(RenderGraph renderGraph, in OccluderParameters occluderParams, ReadOnlySpan<OccluderSubviewUpdate> occluderSubviewUpdates) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AllocatorHandle), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Allocator)}, ReturnType = typeof(AllocatorHandle))]
	[Calls(Type = typeof(NativeList`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(AllocatorHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderersBatchersContext), Member = "ScheduleQueryRendererGroupInstancesJob", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Unity.Collections.NativeArray`1<System.Int32>), typeof(Unity.Collections.NativeList`1<UnityEngine.Rendering.InstanceHandle>)}, ReturnType = typeof(JobHandle))]
	[Calls(Type = typeof(JobHandle), Member = "Complete", ReturnType = typeof(void))]
	[Calls(Type = typeof(NativeList`1), Member = "AsArray", ReturnType = "Unity.Collections.NativeArray`1<T>")]
	[Calls(Type = typeof(InstanceCullingBatcher), Member = "BuildBatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Unity.Collections.NativeArray`1<UnityEngine.Rendering.InstanceHandle>), typeof(GPUDrivenRendererGroupData&), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Unity.Collections.NativeList`1<UnityEngine.Rendering.InstanceHandle>), Member = "Dispose", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private void UpdateRendererBatches(in GPUDrivenRendererGroupData rendererData, IList<Mesh> meshes, IList<Material> materials) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GPUResidentBatcher), Member = "FreeRendererGroupInstances", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Unity.Collections.NativeArray`1<System.Int32>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NativeArray`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Allocator), typeof(NativeArrayOptions)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderersBatchersContext), Member = "ReallocateAndGetInstances", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GPUDrivenRendererGroupData&), typeof(Unity.Collections.NativeArray`1<UnityEngine.Rendering.InstanceHandle>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderersBatchersContext), Member = "ScheduleUpdateInstanceDataJob", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Unity.Collections.NativeArray`1<UnityEngine.Rendering.InstanceHandle>), typeof(GPUDrivenRendererGroupData&)}, ReturnType = typeof(JobHandle))]
	[Calls(Type = typeof(RenderersBatchersContext), Member = "CreateDataBufferUploader", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(InstanceType)}, ReturnType = typeof(GPUInstanceDataBufferUploader))]
	[Calls(Type = typeof(GPUInstanceDataBufferUploader), Member = "WriteInstanceDataJob", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), "Unity.Collections.NativeArray`1<T>", typeof(Unity.Collections.NativeArray`1<System.Int32>)}, ReturnType = typeof(JobHandle))]
	[Calls(Type = typeof(JobHandle), Member = "Complete", ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderersBatchersContext), Member = "SubmitToGpu", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Unity.Collections.NativeArray`1<UnityEngine.Rendering.InstanceHandle>), typeof(GPUInstanceDataBufferUploader&), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderersBatchersContext), Member = "ChangeInstanceBufferVersion", ReturnType = typeof(void))]
	[Calls(Type = typeof(GPUInstanceDataBufferUploader), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderersBatchersContext), Member = "InitializeInstanceTransforms", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Unity.Collections.NativeArray`1<UnityEngine.Rendering.InstanceHandle>), typeof(Unity.Collections.NativeArray`1<UnityEngine.Matrix4x4>), typeof(Unity.Collections.NativeArray`1<UnityEngine.Matrix4x4>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InstanceCullingBatcher), Member = "BuildBatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Unity.Collections.NativeArray`1<UnityEngine.Rendering.InstanceHandle>), typeof(GPUDrivenRendererGroupData&), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NativeArray`1), Member = "Dispose", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private void UpdateRendererInstancesAndBatches(in GPUDrivenRendererGroupData rendererData, IList<Mesh> meshes, IList<Material> materials) { }

	[CalledBy(Type = typeof(GPUResidentDrawer), Member = "ProcessRendererMaterialAndMeshChanges", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Unity.Collections.NativeArray`1<System.Int32>), typeof(Unity.Collections.NativeArray`1<System.Int32>), typeof(Unity.Collections.NativeArray`1<UnityEngine.Rendering.GPUDrivenPackedMaterialData>), typeof(Unity.Collections.NativeArray`1<System.Int32>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GPUResidentDrawer), Member = "ProcessRenderers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.TypeDispatchData", typeof(Unity.Collections.NativeArray`1<System.Int32>)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = "UnityEngine.Rendering.GPUDrivenProcessor", Member = "set_enablePartialRendering", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NativeArray`1), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Collections.NativeArray`1<T>&"}, ReturnType = "System.ReadOnlySpan`1<T>")]
	[Calls(Type = "UnityEngine.Rendering.GPUDrivenProcessor", Member = "EnableGPUDrivenRenderingAndDispatchRendererData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Int32>), "UnityEngine.Rendering.GPUDrivenRendererDataCallback", typeof(bool)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void UpdateRenderers(NativeArray<Int32> renderersID, bool materialUpdateOnly = false) { }

	[CalledBy(Type = typeof(GPUResidentBatcher), Member = "ProcessTrees", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(NativeArray`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Allocator), typeof(NativeArrayOptions)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderersBatchersContext), Member = "get_instanceDataBuffer", ReturnType = typeof(ReadOnly))]
	[Calls(Type = typeof(ReadOnly), Member = "CPUInstanceArrayToGPUInstanceArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Unity.Collections.NativeArray`1<UnityEngine.Rendering.InstanceHandle>), typeof(Unity.Collections.NativeArray`1<UnityEngine.Rendering.GPUInstanceIndex>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderersBatchersContext), Member = "UpdateInstanceWindDataHistory", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Unity.Collections.NativeArray`1<UnityEngine.Rendering.GPUInstanceIndex>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderersBatchersContext), Member = "CreateDataBufferUploader", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(InstanceType)}, ReturnType = typeof(GPUInstanceDataBufferUploader))]
	[Calls(Type = typeof(GPUInstanceDataBufferUploader), Member = "GetUploadBufferPtr", ReturnType = typeof(IntPtr))]
	[Calls(Type = typeof(GPUInstanceDataBufferUploader), Member = "PrepareParamWrite", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(NativeArray`1), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Collections.NativeArray`1<T>&"}, ReturnType = "System.ReadOnlySpan`1<T>")]
	[Calls(Type = "UnityEngine.Rendering.SpeedTreeWindManager", Member = "UpdateWindAndWriteBufferWindParams", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Int32>), "UnityEngine.Rendering.SpeedTreeWindParamsBufferIterator", typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderersBatchersContext), Member = "SubmitToGpu", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Unity.Collections.NativeArray`1<UnityEngine.Rendering.GPUInstanceIndex>), typeof(GPUInstanceDataBufferUploader&), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NativeArray`1), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(GPUInstanceDataBufferUploader), Member = "Dispose", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	private void UpdateSpeedTreeWindAndUploadWindParamsToGPU(NativeArray<Int32> treeRendererIDs, NativeArray<InstanceHandle> treeInstances, bool history) { }

}

