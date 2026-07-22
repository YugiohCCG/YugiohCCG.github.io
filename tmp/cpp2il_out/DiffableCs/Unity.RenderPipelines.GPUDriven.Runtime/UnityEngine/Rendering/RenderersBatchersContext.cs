namespace UnityEngine.Rendering;

internal class RenderersBatchersContext : IDisposable
{
	private InstanceDataSystem m_InstanceDataSystem; //Field offset: 0x10
	private GPUResidentDrawerResources m_Resources; //Field offset: 0x18
	private GPUDrivenProcessor m_GPUDrivenProcessor; //Field offset: 0x20
	private LODGroupDataPool m_LODGroupDataPool; //Field offset: 0x28
	internal GPUInstanceDataBuffer m_InstanceDataBuffer; //Field offset: 0x30
	private RenderersParameters m_RenderersParameters; //Field offset: 0x38
	private GPUResources m_UploadResources; //Field offset: 0xA0
	private GPUResources m_GrowerResources; //Field offset: 0xE0
	internal CommandBuffer m_CmdBuffer; //Field offset: 0xF0
	private SphericalHarmonicsL2 m_CachedAmbientProbe; //Field offset: 0xF8
	private float m_SmallMeshScreenPercentage; //Field offset: 0x164
	private GPUDrivenLODGroupDataCallback m_UpdateLODGroupCallback; //Field offset: 0x168
	private GPUDrivenLODGroupDataCallback m_TransformLODGroupCallback; //Field offset: 0x170
	private OcclusionCullingCommon m_OcclusionCullingCommon; //Field offset: 0x178
	private DebugRendererBatcherStats m_DebugStats; //Field offset: 0x180

	public int activeLodGroupCount
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		 get { } //Length: 86
	}

	public NativeArray<InstanceHandle> aliveInstances
	{
		[CalledBy(Type = typeof(GPUResidentBatcher), Member = "ProcessTrees", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(InstanceDataSystem), Member = "get_aliveInstances", ReturnType = typeof(Unity.Collections.NativeArray`1<UnityEngine.Rendering.InstanceHandle>))]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 51
	}

	public SphericalHarmonicsL2 cachedAmbientProbe
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 80
	}

	public int crossfadedRendererCount
	{
		[CalledBy(Type = typeof(InstanceCullingBatcher), Member = "OnPerformCulling", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BatchRendererGroup), typeof(BatchCullingContext), typeof(BatchCullingOutput), typeof(IntPtr)}, ReturnType = typeof(JobHandle))]
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 26
	}

	internal DebugRendererBatcherStats debugStats
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		internal get { } //Length: 8
	}

	public ReadOnly<GPUInstanceComponentDesc> defaultDescriptions
	{
		[CalledBy(Type = typeof(InstanceCullingBatcher), Member = "GetBatchID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InstanceComponentGroup)}, ReturnType = typeof(BatchID))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(NativeArray`1), Member = "AsReadOnly", ReturnType = "Unity.Collections.NativeArray`1<T>+ReadOnly<T>")]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 101
	}

	public NativeArray<MetadataValue> defaultMetadata
	{
		[CalledBy(Type = typeof(InstanceCullingBatcher), Member = "GetBatchID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InstanceComponentGroup)}, ReturnType = typeof(BatchID))]
		[CallerCount(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 36
	}

	public GraphicsBuffer gpuInstanceDataBuffer
	{
		[CalledBy(Type = typeof(InstanceCuller), Member = "AddOcclusionCullingDispatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputeCommandBuffer), typeof(OcclusionCullingSettings&), typeof(InstanceOcclusionTestSubviewSettings&), typeof(IndirectBufferContextHandles&), typeof(OccluderHandles&), typeof(RenderersBatchersContext)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InstanceCullingBatcher), Member = "GetBatchID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InstanceComponentGroup)}, ReturnType = typeof(BatchID))]
		[CallerCount(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 27
	}

	public bool hasBoundingSpheres
	{
		[CalledBy(Type = typeof(GPUResidentBatcher), Member = "InstanceOcclusionTest", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(OcclusionCullingSettings&), typeof(System.ReadOnlySpan`1<UnityEngine.Rendering.SubviewOcclusionTest>)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(GPUResidentBatcher), Member = "UpdateInstanceOccluders", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(OccluderParameters&), typeof(System.ReadOnlySpan`1<UnityEngine.Rendering.OccluderSubviewUpdate>)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(GPUResidentDrawer), Member = "InstanceOcclusionTest", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(OcclusionCullingSettings&), typeof(System.ReadOnlySpan`1<UnityEngine.Rendering.SubviewOcclusionTest>)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(GPUResidentDrawer), Member = "UpdateInstanceOccluders", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(OccluderParameters&), typeof(System.ReadOnlySpan`1<UnityEngine.Rendering.OccluderSubviewUpdate>)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InstanceCullingBatcher), Member = "OnPerformCulling", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BatchRendererGroup), typeof(BatchCullingContext), typeof(BatchCullingOutput), typeof(IntPtr)}, ReturnType = typeof(JobHandle))]
		[CallerCount(Count = 5)]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 30
	}

	public ReadOnly instanceData
	{
		[CalledBy(Type = typeof(InstanceCullingBatcher), Member = "OnPerformCulling", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BatchRendererGroup), typeof(BatchCullingContext), typeof(BatchCullingOutput), typeof(IntPtr)}, ReturnType = typeof(JobHandle))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(InstanceDataSystem), Member = "get_instanceData", ReturnType = typeof(ReadOnly))]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 201
	}

	public ReadOnly instanceDataBuffer
	{
		[CalledBy(Type = typeof(GPUResidentBatcher), Member = "UpdateSpeedTreeWindAndUploadWindParamsToGPU", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Unity.Collections.NativeArray`1<System.Int32>), typeof(Unity.Collections.NativeArray`1<UnityEngine.Rendering.InstanceHandle>), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InstanceCullingBatcher), Member = "OnPerformCulling", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BatchRendererGroup), typeof(BatchCullingContext), typeof(BatchCullingOutput), typeof(IntPtr)}, ReturnType = typeof(JobHandle))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(GPUInstanceDataBuffer), Member = "AsReadOnly", ReturnType = typeof(ReadOnly))]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 51
	}

	public int instanceDataBufferLayoutVersion
	{
		[CalledBy(Type = typeof(InstanceCullingBatcher), Member = "GetBatchID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InstanceComponentGroup)}, ReturnType = typeof(BatchID))]
		[CalledBy(Type = typeof(InstanceCullingBatcher), Member = "UpdateInstanceDataBufferLayoutVersion", ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 26
	}

	public int instanceDataBufferVersion
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 26
	}

	public NativeList<LODGroupCullingData> lodGroupCullingData
	{
		[CallerCount(Count = 17)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 27
	}

	internal OcclusionCullingCommon occlusionCullingCommon
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		internal get { } //Length: 8
	}

	public RenderersParameters renderersParameters
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 67
	}

	public GPUResidentDrawerResources resources
	{
		[CallerCount(Count = 31)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public ReadOnly sharedInstanceData
	{
		[CalledBy(Type = typeof(GPUResidentDrawer), Member = "PostPostLateUpdate", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(GPUResidentDrawer), Member = "FindUnsupportedRenderers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Unity.Collections.NativeArray`1<System.Int32>)}, ReturnType = typeof(Unity.Collections.NativeList`1<System.Int32>))]
		[CalledBy(Type = typeof(GPUResidentDrawer), Member = "FindRenderersFromMaterialsOrMeshes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Unity.Collections.NativeArray`1<System.Int32>), typeof(Unity.Collections.NativeHashSet`1<System.Int32>), typeof(Unity.Collections.NativeArray`1<System.Int32>), typeof(Allocator)}, ReturnType = typeof(System.ValueTuple`2<Unity.Collections.NativeList`1<System.Int32>, Unity.Collections.NativeList`1<System.Int32>>))]
		[CalledBy(Type = typeof(InstanceCullingBatcher), Member = "OnPerformCulling", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BatchRendererGroup), typeof(BatchCullingContext), typeof(BatchCullingOutput), typeof(IntPtr)}, ReturnType = typeof(JobHandle))]
		[CallerCount(Count = 6)]
		[Calls(Type = typeof(InstanceDataSystem), Member = "get_sharedInstanceData", ReturnType = typeof(ReadOnly))]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 141
	}

	public float smallMeshScreenPercentage
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 9
	}

	[CalledBy(Type = typeof(GPUResidentDrawer), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GPUResidentDrawerSettings), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GPUResources), Member = "LoadShaders", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GPUResidentDrawerResources)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InstanceDataSystem), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool), typeof(GPUResidentDrawerResources)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderSettings), Member = "get_ambientProbe", ReturnType = typeof(SphericalHarmonicsL2))]
	[Calls(Type = typeof(CommandBuffer), Member = "set_name", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CommandBuffer), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(GPUResources), Member = "LoadShaders", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GPUResidentDrawerResources)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Unity.Collections.NativeList`1<UnityEngine.Rendering.LODGroupCullingData>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AllocatorHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NativeParallelHashMap`2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(AllocatorHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NativeList`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AllocatorHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AllocatorHandle), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Allocator)}, ReturnType = typeof(AllocatorHandle))]
	[Calls(Type = typeof(RenderersParameters), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GPUInstanceDataBuffer&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderersParameters), Member = "CreateInstanceDataBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Flags), typeof(InstanceNumInfo&)}, ReturnType = typeof(GPUInstanceDataBuffer))]
	[Calls(Type = typeof(OcclusionCullingCommon), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GPUResidentDrawerResources)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DebugRendererBatcherStats), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 12)]
	[ContainsUnimplementedInstructions]
	public RenderersBatchersContext(in RenderersBatchersContextDesc desc, GPUDrivenProcessor gpuDrivenProcessor, GPUResidentDrawerResources resources) { }

	[CalledBy(Type = typeof(GPUResidentBatcher), Member = "UpdateRendererInstancesAndBatches", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GPUDrivenRendererGroupData&), typeof(System.Collections.Generic.IList`1<UnityEngine.Mesh>), typeof(System.Collections.Generic.IList`1<UnityEngine.Material>)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void ChangeInstanceBufferVersion() { }

	[CalledBy(Type = typeof(GPUResidentBatcher), Member = "UpdateSpeedTreeWindAndUploadWindParamsToGPU", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Unity.Collections.NativeArray`1<System.Int32>), typeof(Unity.Collections.NativeArray`1<UnityEngine.Rendering.InstanceHandle>), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GPUResidentBatcher), Member = "UpdateRendererInstancesAndBatches", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GPUDrivenRendererGroupData&), typeof(System.Collections.Generic.IList`1<UnityEngine.Mesh>), typeof(System.Collections.Generic.IList`1<UnityEngine.Material>)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GPUInstanceDataBufferUploader), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NativeArray`1<GPUInstanceComponentDesc>&), typeof(int), typeof(InstanceType)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public GPUInstanceDataBufferUploader CreateDataBufferUploader(int capacity, InstanceType instanceType) { }

	[CalledBy(Type = typeof(GPUResidentDrawer), Member = "PostPostLateUpdate", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GPUResidentDrawer), Member = "ProcessLODGroups", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Unity.Collections.NativeArray`1<System.Int32>), typeof(Unity.Collections.NativeArray`1<System.Int32>), typeof(Unity.Collections.NativeArray`1<System.Int32>)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void DestroyLODGroups(NativeArray<Int32> destroyed) { }

	[CalledBy(Type = typeof(GPUResidentDrawer), Member = "Dispose", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Unity.Collections.NativeList`1<UnityEngine.Rendering.LODGroupData>), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(InstanceDataSystem), Member = "get_sharedInstanceData", ReturnType = typeof(ReadOnly))]
	[Calls(Type = typeof(ReadOnly), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"ReadOnly<T>&"}, ReturnType = "System.ReadOnlySpan`1<T>")]
	[Calls(Type = "UnityEngine.Rendering.GPUDrivenProcessor", Member = "DisableGPUDrivenRendering", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Int32>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InstanceDataSystem), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(GPUResources), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(NativeParallelHashMap`2), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(Unity.Collections.NativeList`1<UnityEngine.Rendering.LODGroupCullingData>), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(Unity.Collections.NativeList`1<UnityEngine.Rendering.GPUInstanceIndex>), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(GPUInstanceDataBuffer), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(DebugRendererBatcherStats), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(OcclusionCullingCommon), Member = "Dispose", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	[ContainsUnimplementedInstructions]
	public override void Dispose() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InstanceDataSystem), Member = "GetMaxInstancesOfType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InstanceType)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(RenderersBatchersContext), Member = "GrowInstanceBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InstanceNumInfo&)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private void EnsureInstanceBufferCapacity() { }

	[CalledBy(Type = typeof(GPUResidentDrawer), Member = "FreeInstances", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Unity.Collections.NativeArray`1<UnityEngine.Rendering.InstanceHandle>)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InstanceDataSystem), Member = "FreeInstances", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Unity.Collections.NativeArray`1<UnityEngine.Rendering.InstanceHandle>)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void FreeInstances(NativeArray<InstanceHandle> instances) { }

	[CalledBy(Type = typeof(GPUResidentBatcher), Member = "FreeRendererGroupInstances", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Unity.Collections.NativeArray`1<System.Int32>)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InstanceDataSystem), Member = "FreeRendererGroupInstances", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Unity.Collections.NativeArray`1<System.Int32>)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void FreeRendererGroupInstances(NativeArray<Int32> rendererGroupsID) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public int get_activeLodGroupCount() { }

	[CalledBy(Type = typeof(GPUResidentBatcher), Member = "ProcessTrees", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InstanceDataSystem), Member = "get_aliveInstances", ReturnType = typeof(Unity.Collections.NativeArray`1<UnityEngine.Rendering.InstanceHandle>))]
	[CallsUnknownMethods(Count = 1)]
	public NativeArray<InstanceHandle> get_aliveInstances() { }

	[CallerCount(Count = 0)]
	public SphericalHarmonicsL2 get_cachedAmbientProbe() { }

	[CalledBy(Type = typeof(InstanceCullingBatcher), Member = "OnPerformCulling", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BatchRendererGroup), typeof(BatchCullingContext), typeof(BatchCullingOutput), typeof(IntPtr)}, ReturnType = typeof(JobHandle))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public int get_crossfadedRendererCount() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	internal DebugRendererBatcherStats get_debugStats() { }

	[CalledBy(Type = typeof(InstanceCullingBatcher), Member = "GetBatchID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InstanceComponentGroup)}, ReturnType = typeof(BatchID))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(NativeArray`1), Member = "AsReadOnly", ReturnType = "Unity.Collections.NativeArray`1<T>+ReadOnly<T>")]
	[CallsUnknownMethods(Count = 1)]
	public ReadOnly<GPUInstanceComponentDesc> get_defaultDescriptions() { }

	[CalledBy(Type = typeof(InstanceCullingBatcher), Member = "GetBatchID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InstanceComponentGroup)}, ReturnType = typeof(BatchID))]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public NativeArray<MetadataValue> get_defaultMetadata() { }

	[CalledBy(Type = typeof(InstanceCuller), Member = "AddOcclusionCullingDispatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputeCommandBuffer), typeof(OcclusionCullingSettings&), typeof(InstanceOcclusionTestSubviewSettings&), typeof(IndirectBufferContextHandles&), typeof(OccluderHandles&), typeof(RenderersBatchersContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InstanceCullingBatcher), Member = "GetBatchID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InstanceComponentGroup)}, ReturnType = typeof(BatchID))]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public GraphicsBuffer get_gpuInstanceDataBuffer() { }

	[CalledBy(Type = typeof(GPUResidentBatcher), Member = "InstanceOcclusionTest", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(OcclusionCullingSettings&), typeof(System.ReadOnlySpan`1<UnityEngine.Rendering.SubviewOcclusionTest>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GPUResidentBatcher), Member = "UpdateInstanceOccluders", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(OccluderParameters&), typeof(System.ReadOnlySpan`1<UnityEngine.Rendering.OccluderSubviewUpdate>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GPUResidentDrawer), Member = "InstanceOcclusionTest", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(OcclusionCullingSettings&), typeof(System.ReadOnlySpan`1<UnityEngine.Rendering.SubviewOcclusionTest>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GPUResidentDrawer), Member = "UpdateInstanceOccluders", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(OccluderParameters&), typeof(System.ReadOnlySpan`1<UnityEngine.Rendering.OccluderSubviewUpdate>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InstanceCullingBatcher), Member = "OnPerformCulling", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BatchRendererGroup), typeof(BatchCullingContext), typeof(BatchCullingOutput), typeof(IntPtr)}, ReturnType = typeof(JobHandle))]
	[CallerCount(Count = 5)]
	[CallsUnknownMethods(Count = 1)]
	public bool get_hasBoundingSpheres() { }

	[CalledBy(Type = typeof(InstanceCullingBatcher), Member = "OnPerformCulling", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BatchRendererGroup), typeof(BatchCullingContext), typeof(BatchCullingOutput), typeof(IntPtr)}, ReturnType = typeof(JobHandle))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InstanceDataSystem), Member = "get_instanceData", ReturnType = typeof(ReadOnly))]
	[CallsUnknownMethods(Count = 1)]
	public ReadOnly get_instanceData() { }

	[CalledBy(Type = typeof(GPUResidentBatcher), Member = "UpdateSpeedTreeWindAndUploadWindParamsToGPU", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Unity.Collections.NativeArray`1<System.Int32>), typeof(Unity.Collections.NativeArray`1<UnityEngine.Rendering.InstanceHandle>), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InstanceCullingBatcher), Member = "OnPerformCulling", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BatchRendererGroup), typeof(BatchCullingContext), typeof(BatchCullingOutput), typeof(IntPtr)}, ReturnType = typeof(JobHandle))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GPUInstanceDataBuffer), Member = "AsReadOnly", ReturnType = typeof(ReadOnly))]
	[CallsUnknownMethods(Count = 1)]
	public ReadOnly get_instanceDataBuffer() { }

	[CalledBy(Type = typeof(InstanceCullingBatcher), Member = "GetBatchID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InstanceComponentGroup)}, ReturnType = typeof(BatchID))]
	[CalledBy(Type = typeof(InstanceCullingBatcher), Member = "UpdateInstanceDataBufferLayoutVersion", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	public int get_instanceDataBufferLayoutVersion() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public int get_instanceDataBufferVersion() { }

	[CallerCount(Count = 17)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public NativeList<LODGroupCullingData> get_lodGroupCullingData() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	internal OcclusionCullingCommon get_occlusionCullingCommon() { }

	[CallerCount(Count = 0)]
	public RenderersParameters get_renderersParameters() { }

	[CallerCount(Count = 31)]
	[DeduplicatedMethod]
	public GPUResidentDrawerResources get_resources() { }

	[CalledBy(Type = typeof(GPUResidentDrawer), Member = "PostPostLateUpdate", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GPUResidentDrawer), Member = "FindUnsupportedRenderers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Unity.Collections.NativeArray`1<System.Int32>)}, ReturnType = typeof(Unity.Collections.NativeList`1<System.Int32>))]
	[CalledBy(Type = typeof(GPUResidentDrawer), Member = "FindRenderersFromMaterialsOrMeshes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Unity.Collections.NativeArray`1<System.Int32>), typeof(Unity.Collections.NativeHashSet`1<System.Int32>), typeof(Unity.Collections.NativeArray`1<System.Int32>), typeof(Allocator)}, ReturnType = typeof(System.ValueTuple`2<Unity.Collections.NativeList`1<System.Int32>, Unity.Collections.NativeList`1<System.Int32>>))]
	[CalledBy(Type = typeof(InstanceCullingBatcher), Member = "OnPerformCulling", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BatchRendererGroup), typeof(BatchCullingContext), typeof(BatchCullingOutput), typeof(IntPtr)}, ReturnType = typeof(JobHandle))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(InstanceDataSystem), Member = "get_sharedInstanceData", ReturnType = typeof(ReadOnly))]
	[CallsUnknownMethods(Count = 1)]
	public ReadOnly get_sharedInstanceData() { }

	[CallerCount(Count = 0)]
	public float get_smallMeshScreenPercentage() { }

	[CalledBy(Type = typeof(GPUResidentBatcher), Member = "ProcessTrees", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InstanceDataSystem), Member = "GetAliveInstancesOfType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InstanceType)}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 1)]
	public int GetAliveInstancesOfType(InstanceType instanceType) { }

	[CallerCount(Count = 62)]
	[DeduplicatedMethod]
	public GPUInstanceDataBuffer GetInstanceDataBuffer() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InstanceDataSystem), Member = "GetMaxInstancesOfType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InstanceType)}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 1)]
	public int GetMaxInstancesOfType(InstanceType instanceType) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NativeArray`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Allocator), typeof(NativeArrayOptions)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InstanceDataSystem), Member = "ScheduleQueryRendererGroupInstancesJob", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Unity.Collections.NativeArray`1<System.Int32>), typeof(Unity.Collections.NativeArray`1<UnityEngine.Rendering.InstanceHandle>)}, ReturnType = typeof(JobHandle))]
	[Calls(Type = typeof(JobHandle), Member = "Complete", ReturnType = typeof(void))]
	[Calls(Type = typeof(NativeArray`1), Member = "Dispose", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public InstanceHandle GetRendererInstanceHandle(int rendererID) { }

	[CalledBy(Type = typeof(GPUResidentBatcher), Member = "ProcessTrees", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InstanceDataSystem), Member = "GetVisibleTreeInstances", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParallelBitArray&), typeof(ParallelBitArray&), typeof(Unity.Collections.NativeList`1<System.Int32>), typeof(Unity.Collections.NativeList`1<UnityEngine.Rendering.InstanceHandle>), typeof(bool), typeof(Int32&)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void GetVisibleTreeInstances(in ParallelBitArray compactedVisibilityMasks, in ParallelBitArray processedBits, NativeList<Int32> visibeTreeRendererIDs, NativeList<InstanceHandle> visibeTreeInstances, bool becomeVisibleOnly, out int becomeVisibeTreeInstancesCount) { }

	[CalledBy(Type = typeof(RenderersBatchersContext), Member = "EnsureInstanceBufferCapacity", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RenderersBatchersContext), Member = "ReallocateAndGetInstances", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GPUDrivenRendererGroupData&), typeof(Unity.Collections.NativeArray`1<UnityEngine.Rendering.InstanceHandle>)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GPUInstanceDataBufferGrower), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GPUInstanceDataBuffer), typeof(InstanceNumInfo&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GPUInstanceDataBufferGrower), Member = "SubmitToGpu", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GPUResources&)}, ReturnType = typeof(GPUInstanceDataBuffer))]
	[Calls(Type = typeof(GPUInstanceDataBuffer), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderersParameters), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GPUInstanceDataBuffer&)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public void GrowInstanceBuffer(in InstanceNumInfo instanceNumInfo) { }

	[CalledBy(Type = typeof(GPUResidentBatcher), Member = "UpdateRendererInstancesAndBatches", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GPUDrivenRendererGroupData&), typeof(System.Collections.Generic.IList`1<UnityEngine.Mesh>), typeof(System.Collections.Generic.IList`1<UnityEngine.Material>)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InstanceDataSystem), Member = "InitializeInstanceTransforms", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Unity.Collections.NativeArray`1<UnityEngine.Rendering.InstanceHandle>), typeof(Unity.Collections.NativeArray`1<UnityEngine.Matrix4x4>), typeof(Unity.Collections.NativeArray`1<UnityEngine.Matrix4x4>), typeof(RenderersParameters&), typeof(GPUInstanceDataBuffer)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void InitializeInstanceTransforms(NativeArray<InstanceHandle> instances, NativeArray<Matrix4x4> localToWorldMatrices, NativeArray<Matrix4x4> prevLocalToWorldMatrices) { }

	[CalledBy(Type = typeof(GPUResidentBatcher), Member = "UpdateRendererInstancesAndBatches", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GPUDrivenRendererGroupData&), typeof(System.Collections.Generic.IList`1<UnityEngine.Mesh>), typeof(System.Collections.Generic.IList`1<UnityEngine.Material>)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InstanceDataSystem), Member = "ReallocateAndGetInstances", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GPUDrivenRendererGroupData&), typeof(Unity.Collections.NativeArray`1<UnityEngine.Rendering.InstanceHandle>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InstanceDataSystem), Member = "GetMaxInstancesOfType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InstanceType)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(RenderersBatchersContext), Member = "GrowInstanceBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InstanceNumInfo&)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	public void ReallocateAndGetInstances(in GPUDrivenRendererGroupData rendererData, NativeArray<InstanceHandle> instances) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InstanceDataSystem), Member = "ScheduleCollectInstancesLODGroupAndMasksJob", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Unity.Collections.NativeArray`1<UnityEngine.Rendering.InstanceHandle>), typeof(Unity.Collections.NativeArray`1<System.UInt32>)}, ReturnType = typeof(JobHandle))]
	[CallsUnknownMethods(Count = 1)]
	public JobHandle ScheduleCollectInstancesLODGroupAndMasksJob(NativeArray<InstanceHandle> instances, NativeArray<UInt32> lodGroupAndMasks) { }

	[CalledBy(Type = typeof(GPUResidentDrawer), Member = "PostPostLateUpdate", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GPUResidentDrawer), Member = "ProcessMeshes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Unity.Collections.NativeArray`1<System.Int32>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GPUResidentDrawer), Member = "ScheduleQueryMeshInstancesJob", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Unity.Collections.NativeArray`1<System.Int32>), typeof(Unity.Collections.NativeList`1<UnityEngine.Rendering.InstanceHandle>)}, ReturnType = typeof(JobHandle))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(InstanceDataSystem), Member = "ScheduleQuerySortedMeshInstancesJob", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Unity.Collections.NativeArray`1<System.Int32>), typeof(Unity.Collections.NativeList`1<UnityEngine.Rendering.InstanceHandle>)}, ReturnType = typeof(JobHandle))]
	[CallsUnknownMethods(Count = 1)]
	public JobHandle ScheduleQueryMeshInstancesJob(NativeArray<Int32> sortedMeshIDs, NativeList<InstanceHandle> instances) { }

	[CalledBy(Type = typeof(GPUResidentDrawer), Member = "ProcessRendererMaterialAndMeshChanges", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Unity.Collections.NativeArray`1<System.Int32>), typeof(Unity.Collections.NativeArray`1<System.Int32>), typeof(Unity.Collections.NativeArray`1<UnityEngine.Rendering.GPUDrivenPackedMaterialData>), typeof(Unity.Collections.NativeArray`1<System.Int32>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GPUResidentDrawer), Member = "ProcessRenderers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.TypeDispatchData", typeof(Unity.Collections.NativeArray`1<System.Int32>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GPUResidentDrawer), Member = "ScheduleQueryRendererGroupInstancesJob", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Unity.Collections.NativeArray`1<System.Int32>), typeof(Unity.Collections.NativeArray`1<UnityEngine.Rendering.InstanceHandle>)}, ReturnType = typeof(JobHandle))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(InstanceDataSystem), Member = "ScheduleQueryRendererGroupInstancesJob", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Unity.Collections.NativeArray`1<System.Int32>), typeof(Unity.Collections.NativeArray`1<UnityEngine.Rendering.InstanceHandle>)}, ReturnType = typeof(JobHandle))]
	[CallsUnknownMethods(Count = 1)]
	public JobHandle ScheduleQueryRendererGroupInstancesJob(NativeArray<Int32> rendererGroupIDs, NativeArray<InstanceHandle> instances) { }

	[CalledBy(Type = typeof(GPUResidentBatcher), Member = "FreeRendererGroupInstances", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Unity.Collections.NativeArray`1<System.Int32>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GPUResidentBatcher), Member = "UpdateRendererBatches", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GPUDrivenRendererGroupData&), typeof(System.Collections.Generic.IList`1<UnityEngine.Mesh>), typeof(System.Collections.Generic.IList`1<UnityEngine.Material>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GPUResidentDrawer), Member = "ScheduleQueryRendererGroupInstancesJob", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Unity.Collections.NativeArray`1<System.Int32>), typeof(Unity.Collections.NativeList`1<UnityEngine.Rendering.InstanceHandle>)}, ReturnType = typeof(JobHandle))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(InstanceDataSystem), Member = "ScheduleQueryRendererGroupInstancesJob", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Unity.Collections.NativeArray`1<System.Int32>), typeof(Unity.Collections.NativeList`1<UnityEngine.Rendering.InstanceHandle>)}, ReturnType = typeof(JobHandle))]
	[CallsUnknownMethods(Count = 1)]
	public JobHandle ScheduleQueryRendererGroupInstancesJob(NativeArray<Int32> rendererGroupIDs, NativeList<InstanceHandle> instances) { }

	[CalledBy(Type = typeof(GPUResidentDrawer), Member = "ScheduleQueryRendererGroupInstancesJob", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Unity.Collections.NativeArray`1<System.Int32>), typeof(Unity.Collections.NativeArray`1<System.Int32>), typeof(Unity.Collections.NativeArray`1<System.Int32>), typeof(Unity.Collections.NativeList`1<UnityEngine.Rendering.InstanceHandle>)}, ReturnType = typeof(JobHandle))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InstanceDataSystem), Member = "ScheduleQueryRendererGroupInstancesJob", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Unity.Collections.NativeArray`1<System.Int32>), typeof(Unity.Collections.NativeArray`1<System.Int32>), typeof(Unity.Collections.NativeArray`1<System.Int32>), typeof(Unity.Collections.NativeList`1<UnityEngine.Rendering.InstanceHandle>)}, ReturnType = typeof(JobHandle))]
	[CallsUnknownMethods(Count = 1)]
	public JobHandle ScheduleQueryRendererGroupInstancesJob(NativeArray<Int32> rendererGroupIDs, NativeArray<Int32> instancesOffset, NativeArray<Int32> instancesCount, NativeList<InstanceHandle> instances) { }

	[CalledBy(Type = typeof(GPUResidentBatcher), Member = "UpdateRendererInstancesAndBatches", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GPUDrivenRendererGroupData&), typeof(System.Collections.Generic.IList`1<UnityEngine.Mesh>), typeof(System.Collections.Generic.IList`1<UnityEngine.Material>)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InstanceDataSystem), Member = "ScheduleUpdateInstanceDataJob", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Unity.Collections.NativeArray`1<UnityEngine.Rendering.InstanceHandle>), typeof(GPUDrivenRendererGroupData&), typeof(Unity.Collections.NativeParallelHashMap`2<System.Int32, UnityEngine.Rendering.GPUInstanceIndex>)}, ReturnType = typeof(JobHandle))]
	[CallsUnknownMethods(Count = 1)]
	public JobHandle ScheduleUpdateInstanceDataJob(NativeArray<InstanceHandle> instances, in GPUDrivenRendererGroupData rendererData) { }

	[CalledBy(Type = typeof(GPUResidentBatcher), Member = "UpdateRendererInstancesAndBatches", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GPUDrivenRendererGroupData&), typeof(System.Collections.Generic.IList`1<UnityEngine.Mesh>), typeof(System.Collections.Generic.IList`1<UnityEngine.Material>)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GPUInstanceDataBufferUploader), Member = "SubmitToGpu", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GPUInstanceDataBuffer), typeof(Unity.Collections.NativeArray`1<UnityEngine.Rendering.InstanceHandle>), typeof(GPUResources&), typeof(bool)}, ReturnType = typeof(void))]
	public void SubmitToGpu(NativeArray<InstanceHandle> instances, ref GPUInstanceDataBufferUploader uploader, bool submitOnlyWrittenParams) { }

	[CalledBy(Type = typeof(GPUResidentBatcher), Member = "UpdateSpeedTreeWindAndUploadWindParamsToGPU", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Unity.Collections.NativeArray`1<System.Int32>), typeof(Unity.Collections.NativeArray`1<UnityEngine.Rendering.InstanceHandle>), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GPUInstanceDataBufferUploader), Member = "SubmitToGpu", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GPUInstanceDataBuffer), typeof(Unity.Collections.NativeArray`1<UnityEngine.Rendering.GPUInstanceIndex>), typeof(GPUResources&), typeof(bool)}, ReturnType = typeof(void))]
	public void SubmitToGpu(NativeArray<GPUInstanceIndex> gpuInstanceIndices, ref GPUInstanceDataBufferUploader uploader, bool submitOnlyWrittenParams) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(IJobParallelForExtensions), Member = "Run", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UpdateLODGroupTransformJob)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UpdateLODGroupTransformJob), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(IJobParallelForExtensions), Member = "Schedule", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UpdateLODGroupTransformJob)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UpdateLODGroupTransformJob), typeof(int), typeof(int), typeof(JobHandle)}, ReturnType = typeof(JobHandle))]
	[Calls(Type = typeof(JobHandle), Member = "Complete", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private void TransformLODGroupData(in GPUDrivenLODGroupData lodGroupData) { }

	[CalledBy(Type = typeof(GPUResidentDrawer), Member = "PostPostLateUpdate", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GPUResidentDrawer), Member = "ProcessLODGroups", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Unity.Collections.NativeArray`1<System.Int32>), typeof(Unity.Collections.NativeArray`1<System.Int32>), typeof(Unity.Collections.NativeArray`1<System.Int32>)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(NativeArray`1), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Collections.NativeArray`1<T>&"}, ReturnType = "System.ReadOnlySpan`1<T>")]
	[Calls(Type = "UnityEngine.Rendering.GPUDrivenProcessor", Member = "DispatchLODGroupData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Int32>), "UnityEngine.Rendering.GPUDrivenLODGroupDataCallback"}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void TransformLODGroups(NativeArray<Int32> lodGroupsID) { }

	[CalledBy(Type = typeof(GPUResidentBatcher), Member = "OnSetupAmbientProbe", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GPUResidentDrawer), Member = "OnSetupAmbientProbe", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GPUResidentDrawer), Member = "OnSceneLoaded", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Scene), typeof(LoadSceneMode)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GPUResidentDrawer), Member = "PostPostLateUpdate", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(RenderSettings), Member = "get_ambientProbe", ReturnType = typeof(SphericalHarmonicsL2))]
	[Calls(Type = typeof(SphericalHarmonicsL2), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SphericalHarmonicsL2), typeof(SphericalHarmonicsL2)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(InstanceDataSystem), Member = "UpdateAllInstanceProbes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderersParameters&), typeof(GPUInstanceDataBuffer)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void UpdateAmbientProbeAndGpuBuffer(bool forceUpdate) { }

	[CalledBy(Type = typeof(GPUResidentBatcher), Member = "UpdateFrame", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GPUResidentDrawer), Member = "PostPostLateUpdate", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(OcclusionCullingCommon), Member = "UpdateFrame", ReturnType = typeof(void))]
	[Calls(Type = typeof(OcclusionCullingCommon), Member = "UpdateOccluderStats", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DebugRendererBatcherStats)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void UpdateFrame() { }

	[CalledBy(Type = typeof(GPUResidentDrawer), Member = "PostPostLateUpdate", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InstanceDataSystem), Member = "UpdateInstanceMotions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderersParameters&), typeof(GPUInstanceDataBuffer)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void UpdateInstanceMotions() { }

	[CalledBy(Type = typeof(GPUResidentDrawer), Member = "ProcessRenderers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.TypeDispatchData", typeof(Unity.Collections.NativeArray`1<System.Int32>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GPUResidentDrawer), Member = "TransformInstances", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Unity.Collections.NativeArray`1<UnityEngine.Rendering.InstanceHandle>), typeof(Unity.Collections.NativeArray`1<UnityEngine.Matrix4x4>)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(InstanceDataSystem), Member = "UpdateInstanceTransforms", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Unity.Collections.NativeArray`1<UnityEngine.Rendering.InstanceHandle>), typeof(Unity.Collections.NativeArray`1<UnityEngine.Matrix4x4>), typeof(RenderersParameters&), typeof(GPUInstanceDataBuffer)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void UpdateInstanceTransforms(NativeArray<InstanceHandle> instances, NativeArray<Matrix4x4> localToWorldMatrices) { }

	[CalledBy(Type = typeof(GPUResidentBatcher), Member = "UpdateSpeedTreeWindAndUploadWindParamsToGPU", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Unity.Collections.NativeArray`1<System.Int32>), typeof(Unity.Collections.NativeArray`1<UnityEngine.Rendering.InstanceHandle>), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InstanceDataSystem), Member = "UpdateInstanceWindDataHistory", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Unity.Collections.NativeArray`1<UnityEngine.Rendering.GPUInstanceIndex>), typeof(RenderersParameters), typeof(GPUInstanceDataBuffer)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void UpdateInstanceWindDataHistory(NativeArray<GPUInstanceIndex> gpuInstanceIndices) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LODGroupDataPool), Member = "UpdateLODGroupData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GPUDrivenLODGroupData&)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private void UpdateLODGroupData(in GPUDrivenLODGroupData lodGroupData) { }

	[CalledBy(Type = typeof(GPUResidentDrawer), Member = "PostPostLateUpdate", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GPUResidentDrawer), Member = "ProcessLODGroups", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Unity.Collections.NativeArray`1<System.Int32>), typeof(Unity.Collections.NativeArray`1<System.Int32>), typeof(Unity.Collections.NativeArray`1<System.Int32>)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(NativeArray`1), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Collections.NativeArray`1<T>&"}, ReturnType = "System.ReadOnlySpan`1<T>")]
	[Calls(Type = "UnityEngine.Rendering.GPUDrivenProcessor", Member = "DispatchLODGroupData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Int32>), "UnityEngine.Rendering.GPUDrivenLODGroupDataCallback"}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void UpdateLODGroups(NativeArray<Int32> changedID) { }

	[CalledBy(Type = typeof(InstanceCullingBatcher), Member = "OnEndContextRendering", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InstanceDataSystem), Member = "UpdatePerFrameInstanceVisibility", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParallelBitArray&)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void UpdatePerFrameInstanceVisibility(in ParallelBitArray compactedVisibilityMasks) { }

}

