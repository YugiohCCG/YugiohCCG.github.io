namespace UnityEngine.Rendering;

public class GPUResidentDrawer
{
	[BurstCompile(DisableSafetyChecks = True, OptimizeFor = OptimizeFor::Performance (1))]
	private struct FindRenderersFromMaterialOrMeshJob : IJobParallelForBatch
	{
		public const int k_BatchSize = 128; //Field offset: 0x0
		[ReadOnly]
		public ReadOnly<Int32> materialIDs; //Field offset: 0x0
		[ReadOnly]
		public ReadOnly<SmallIntegerArray> materialIDArrays; //Field offset: 0x8
		[ReadOnly]
		public ReadOnly<Int32> meshIDs; //Field offset: 0x18
		[ReadOnly]
		public ReadOnly<Int32> meshIDArray; //Field offset: 0x28
		[ReadOnly]
		public ReadOnly<Int32> rendererGroupIDs; //Field offset: 0x38
		[ReadOnly]
		public ReadOnly<Int32> sortedExcludeRendererIDs; //Field offset: 0x48
		[WriteOnly]
		public ParallelWriter<Int32> selectedRenderGroupsForMaterials; //Field offset: 0x58
		[WriteOnly]
		public ParallelWriter<Int32> selectedRenderGroupsForMeshes; //Field offset: 0x60

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Unity.Collections.LowLevel.Unsafe.UnsafeList`1<System.Int32>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32*), typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(UnsafeList`1), Member = "set_Length", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(NativeArrayExtensions), Member = "Contains", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T", "U"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Collections.NativeArray`1<T>+ReadOnly<T>", "U"}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(SmallIntegerArray), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(ReadOnly), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(ParallelWriter), Member = "AddRangeNoResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(int)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 7)]
		[ContainsUnimplementedInstructions]
		public override void Execute(int startIndex, int count) { }

	}

	private static class Strings
	{
		public static readonly string drawerModeDisabled; //Field offset: 0x0
		public static readonly string allowInEditModeDisabled; //Field offset: 0x8
		public static readonly string notGPUResidentRenderPipeline; //Field offset: 0x10
		public static readonly string rawBufferNotSupportedByPlatform; //Field offset: 0x18
		public static readonly string kernelNotPresent; //Field offset: 0x20
		public static readonly string batchRendererGroupShaderStrippingModeInvalid; //Field offset: 0x28
		public static readonly string visionOSNotSupported; //Field offset: 0x30

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
		[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
		[CallsUnknownMethods(Count = 7)]
		private static Strings() { }

	}

	private static GPUResidentDrawer s_Instance; //Field offset: 0x0
	[CompilerGenerated]
	private static bool <MaintainContext>k__BackingField; //Field offset: 0x8
	[CompilerGenerated]
	private static bool <ForceOcclusion>k__BackingField; //Field offset: 0x9
	private IntPtr m_ContextIntPtr; //Field offset: 0x10
	private GPUResidentDrawerSettings m_Settings; //Field offset: 0x18
	private GPUDrivenProcessor m_GPUDrivenProcessor; //Field offset: 0x30
	private RenderersBatchersContext m_BatchersContext; //Field offset: 0x38
	private GPUResidentBatcher m_Batcher; //Field offset: 0x40
	private ObjectDispatcher m_Dispatcher; //Field offset: 0x48

	internal GPUResidentBatcher batcher
	{
		[CallerCount(Count = 12)]
		[DeduplicatedMethod]
		internal get { } //Length: 5
	}

	internal static bool ForceOcclusion
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		internal get { } //Length: 55
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		internal set { } //Length: 60
	}

	internal static GPUResidentDrawer instance
	{
		[CallerCount(Count = 0)]
		internal get { } //Length: 54
	}

	internal static bool MaintainContext
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		internal get { } //Length: 55
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		internal set { } //Length: 60
	}

	internal GPUResidentDrawerSettings settings
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		internal get { } //Length: 21
	}

	[CalledBy(Type = typeof(GPUResidentDrawer), Member = "Reinitialize", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GPUResidentDrawer), Member = "Recreate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GPUResidentDrawerSettings)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(IGPUResidentRenderPipeline), Member = "ReinitializeGPUResidentDrawer", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(GPUResidentDrawer), Member = "InsertIntoPlayerLoop", ReturnType = typeof(void))]
	[Calls(Type = typeof(Shader), Member = "EnableKeyword", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderPipelineManager), Member = "add_endCameraRendering", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`2<UnityEngine.Rendering.ScriptableRenderContext, UnityEngine.Camera>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderPipelineManager), Member = "add_beginCameraRendering", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`2<UnityEngine.Rendering.ScriptableRenderContext, UnityEngine.Camera>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderPipelineManager), Member = "add_endContextRendering", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`2<UnityEngine.Rendering.ScriptableRenderContext, System.Collections.Generic.List`1<UnityEngine.Camera>>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderPipelineManager), Member = "add_beginContextRendering", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`2<UnityEngine.Rendering.ScriptableRenderContext, System.Collections.Generic.List`1<UnityEngine.Camera>>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Action`2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SceneManager), Member = "add_sceneLoaded", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityEngine.Events.UnityAction`2<UnityEngine.SceneManagement.Scene, UnityEngine.SceneManagement.LoadSceneMode>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UnityAction`2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = "UnityEngine.ObjectDispatcher", Member = "EnableTransformTracking", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.ObjectDispatcher+TransformTrackingType"}, ReturnType = typeof(void))]
	[Calls(Type = "UnityEngine.ObjectDispatcher", Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(InstanceCullingBatcher), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderersBatchersContext), typeof(InstanceCullingBatcherDesc), typeof(OnFinishedCulling)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderersBatchersContext), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderersBatchersContextDesc&), "UnityEngine.Rendering.GPUDrivenProcessor", typeof(GPUResidentDrawerResources)}, ReturnType = typeof(void))]
	[Calls(Type = "UnityEngine.Rendering.GPUDrivenProcessor", Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(InstanceCullingBatcherDesc), Member = "NewDefault", ReturnType = typeof(InstanceCullingBatcherDesc))]
	[Calls(Type = typeof(InstanceNumInfo), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderersBatchersContextDesc), Member = "NewDefault", ReturnType = typeof(RenderersBatchersContextDesc))]
	[Calls(Type = typeof(GraphicsSettings), Member = "get_currentRenderPipeline", ReturnType = typeof(RenderPipelineAsset))]
	[Calls(Type = typeof(GraphicsSettings), Member = "GetRenderPipelineSettings", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = "UnityEngine.ObjectDispatcher", Member = "EnableTypeTracking", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.ObjectDispatcher+TypeTrackingFlags"}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 11)]
	private GPUResidentDrawer(GPUResidentDrawerSettings settings, int maxInstanceCount, int maxTreeInstanceCount) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NotImplementedException), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	private InstanceHandle AppendNewInstance(int rendererGroupID, in Matrix4x4 instanceTransform) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AllocatorHandle), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Allocator)}, ReturnType = typeof(AllocatorHandle))]
	[Calls(Type = typeof(NativeList`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(AllocatorHandle)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	private void ClassifyMaterials(NativeArray<Int32> materials, out NativeList<Int32>& unsupportedMaterials, out NativeList<Int32>& supportedMaterials, out NativeList<GPUDrivenPackedMaterialData>& supportedPackedMaterialDatas, Allocator allocator) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GPUResidentDrawer), Member = "Dispose", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private static void CleanUp() { }

	[CalledBy(Type = typeof(GPUResidentDrawer), Member = "Reinitialize", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GPUResidentDrawer), Member = "CleanUp", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GPUResidentDrawer), Member = "Recreate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GPUResidentDrawerSettings)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(IGPUResidentRenderPipeline), Member = "ReinitializeGPUResidentDrawer", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(RenderersBatchersContext), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(ParallelBitArray), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(ParallelBitArray), Member = "get_IsCreated", ReturnType = typeof(bool))]
	[Calls(Type = typeof(InstanceCullingBatcher), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = "UnityEngine.Rendering.GPUDrivenProcessor", Member = "ClearMaterialFilters", ReturnType = typeof(void))]
	[Calls(Type = "UnityEngine.ObjectDispatcher", Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(Shader), Member = "DisableKeyword", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderPipelineManager), Member = "remove_beginCameraRendering", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`2<UnityEngine.Rendering.ScriptableRenderContext, UnityEngine.Camera>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderPipelineManager), Member = "remove_endCameraRendering", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`2<UnityEngine.Rendering.ScriptableRenderContext, UnityEngine.Camera>)}, ReturnType = typeof(void))]
	[Calls(Type = "UnityEngine.Rendering.GPUDrivenProcessor", Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderPipelineManager), Member = "remove_endContextRendering", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`2<UnityEngine.Rendering.ScriptableRenderContext, System.Collections.Generic.List`1<UnityEngine.Camera>>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderPipelineManager), Member = "remove_beginContextRendering", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`2<UnityEngine.Rendering.ScriptableRenderContext, System.Collections.Generic.List`1<UnityEngine.Camera>>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Action`2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SceneManager), Member = "remove_sceneLoaded", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityEngine.Events.UnityAction`2<UnityEngine.SceneManagement.Scene, UnityEngine.SceneManagement.LoadSceneMode>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UnityAction`2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GPUResidentDrawer), Member = "RemoveFromPlayerLoop", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	private void Dispose() { }

	[CalledBy(Type = typeof(GPUResidentDrawer), Member = "ProcessRendererMaterialAndMeshChanges", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Unity.Collections.NativeArray`1<System.Int32>), typeof(Unity.Collections.NativeArray`1<System.Int32>), typeof(Unity.Collections.NativeArray`1<UnityEngine.Rendering.GPUDrivenPackedMaterialData>), typeof(Unity.Collections.NativeArray`1<System.Int32>)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(RenderersBatchersContext), Member = "get_sharedInstanceData", ReturnType = typeof(ReadOnly))]
	[Calls(Type = typeof(AllocatorHandle), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Allocator)}, ReturnType = typeof(AllocatorHandle))]
	[Calls(Type = typeof(NativeList`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(AllocatorHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NativeHashSet`1), Member = "AsReadOnly", ReturnType = "Unity.Collections.NativeHashSet`1<T>+ReadOnly<T>")]
	[Calls(Type = typeof(NativeArray`1), Member = "AsReadOnly", ReturnType = "Unity.Collections.NativeArray`1<T>+ReadOnly<T>")]
	[Calls(Type = typeof(IJobParallelForBatchExtensions), Member = "ScheduleBatch", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FindRenderersFromMaterialOrMeshJob)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FindRenderersFromMaterialOrMeshJob), typeof(int), typeof(int), typeof(JobHandle)}, ReturnType = typeof(JobHandle))]
	[Calls(Type = typeof(JobHandle), Member = "Complete", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private ValueTuple<NativeList`1<Int32>, NativeList`1<Int32>> FindRenderersFromMaterialsOrMeshes(NativeArray<Int32> sortedExcludeRenderers, NativeHashSet<Int32> materials, NativeArray<Int32> meshes, Allocator rendererListAllocator) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AllocatorHandle), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Allocator)}, ReturnType = typeof(AllocatorHandle))]
	[Calls(Type = typeof(NativeList`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AllocatorHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderersBatchersContext), Member = "get_sharedInstanceData", ReturnType = typeof(ReadOnly))]
	[Calls(Type = typeof(FindUnsupportedRenderers_000000EB$BurstDirectCall), Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NativeArray`1<Int32>&), typeof(ReadOnly<SmallIntegerArray>&), typeof(ReadOnly<Int32>&), typeof(NativeList`1<Int32>&)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	private NativeList<Int32> FindUnsupportedRenderers(NativeArray<Int32> unsupportedMaterials) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InstanceCullingBatcher), Member = "DestroyDrawInstances", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Unity.Collections.NativeArray`1<UnityEngine.Rendering.InstanceHandle>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderersBatchersContext), Member = "FreeInstances", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Unity.Collections.NativeArray`1<UnityEngine.Rendering.InstanceHandle>)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private void FreeInstances(NativeArray<InstanceHandle> instances) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GPUResidentBatcher), Member = "FreeRendererGroupInstances", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Unity.Collections.NativeArray`1<System.Int32>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NativeArray`1), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Collections.NativeArray`1<T>&"}, ReturnType = "System.ReadOnlySpan`1<T>")]
	[Calls(Type = "UnityEngine.Rendering.GPUDrivenProcessor", Member = "DisableGPUDrivenRendering", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Int32>)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private void FreeRendererGroupInstances(NativeArray<Int32> rendererGroupIDs, NativeArray<Int32> unsupportedRendererGroupIDs) { }

	[CallerCount(Count = 12)]
	[DeduplicatedMethod]
	internal GPUResidentBatcher get_batcher() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	internal static bool get_ForceOcclusion() { }

	[CallerCount(Count = 0)]
	internal static GPUResidentDrawer get_instance() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	internal static bool get_MaintainContext() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	internal GPUResidentDrawerSettings get_settings() { }

	[CalledBy(Type = typeof(OccluderContext), Member = "PrepareOccluders", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(OccluderParameters&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(OcclusionCullingCommon), Member = "PrepareCulling", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputeCommandBuffer), typeof(OccluderContext&), typeof(OcclusionCullingSettings&), typeof(InstanceOcclusionTestSubviewSettings&), typeof(OcclusionTestComputeShader&), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	internal static DebugRendererBatcherStats GetDebugStats() { }

	[CalledBy(Type = "UnityEngine.Rendering.DebugDisplayGPUResidentDrawer+SettingsPanel+<>c", Member = "<.ctor>b__4_0", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(GPUResidentDrawer), Member = "Reinitialize", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(IGPUResidentRenderPipeline), Member = "ReinitializeGPUResidentDrawer", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(GraphicsSettings), Member = "get_currentRenderPipeline", ReturnType = typeof(RenderPipelineAsset))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	internal static GPUResidentDrawerSettings GetGlobalSettingsFromRPAsset() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AllocatorHandle), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Allocator)}, ReturnType = typeof(AllocatorHandle))]
	[Calls(Type = typeof(NativeHashSet`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(AllocatorHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GetMaterialsWithChangedPackedMaterial_000000EC$BurstDirectCall), Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NativeArray`1<Int32>&), typeof(NativeArray`1<GPUDrivenPackedMaterialData>&), typeof(ReadOnly<Int32, GPUDrivenPackedMaterialData>&), typeof(NativeHashSet`1<Int32>&)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private NativeHashSet<Int32> GetMaterialsWithChangedPackedMaterial(NativeArray<Int32> materials, NativeArray<GPUDrivenPackedMaterialData> packedMaterialDatas, Allocator allocator) { }

	[CalledBy(Type = typeof(GPUResidentDrawer), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GPUResidentDrawerSettings), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PlayerLoop), Member = "GetCurrentPlayerLoop", ReturnType = typeof(PlayerLoopSystem))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(List`1), Member = "ToArray", ReturnType = "T[]")]
	[Calls(Type = typeof(PlayerLoop), Member = "SetPlayerLoop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PlayerLoopSystem)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 10)]
	private void InsertIntoPlayerLoop() { }

	[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderer", Member = "InstanceOcclusionTest", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), "UnityEngine.Rendering.Universal.UniversalCameraData", typeof(OcclusionTest)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(RenderersBatchersContext), Member = "get_hasBoundingSpheres", ReturnType = typeof(bool))]
	[Calls(Type = typeof(InstanceCuller), Member = "InstanceOcclusionTest", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(OcclusionCullingSettings&), typeof(System.ReadOnlySpan`1<UnityEngine.Rendering.SubviewOcclusionTest>), typeof(RenderersBatchersContext)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static void InstanceOcclusionTest(RenderGraph renderGraph, in OcclusionCullingSettings settings, ReadOnlySpan<SubviewOcclusionTest> subviewOcclusionTests) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	internal static bool IsEnabled() { }

	[CallerCount(Count = 271)]
	[DeduplicatedMethod]
	internal static bool IsForcedOnViaCommandLine() { }

	[CalledBy(Type = "UnityEngine.Rendering.DebugDisplayGPUResidentDrawer+SettingsPanel+<>c", Member = "<.ctor>b__4_0", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(GPUResidentDrawer), Member = "Reinitialize", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GPUResidentDrawer), Member = "Recreate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GPUResidentDrawerSettings)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(IGPUResidentRenderPipeline), Member = "ReinitializeGPUResidentDrawer", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(GraphicsSettings), Member = "get_currentRenderPipeline", ReturnType = typeof(RenderPipelineAsset))]
	[CallsUnknownMethods(Count = 5)]
	[ContainsInvalidInstructions]
	internal static bool IsGPUResidentDrawerSupportedBySRP(GPUResidentDrawerSettings settings, out string message, out LogType severity) { }

	[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderPipeline", Member = "InitializeAdditionalCameraData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), "UnityEngine.Rendering.Universal.UniversalAdditionalCameraData", typeof(bool), typeof(bool), "UnityEngine.Rendering.Universal.UniversalCameraData"}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[ContainsUnimplementedInstructions]
	public static bool IsInstanceOcclusionCullingEnabled() { }

	[CallerCount(Count = 271)]
	[DeduplicatedMethod]
	internal static bool IsOcclusionForcedOnViaCommandLine() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GPUResidentDrawer), Member = "IsProjectSupported", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String&), typeof(LogType&)}, ReturnType = typeof(bool))]
	internal static bool IsProjectSupported() { }

	[CalledBy(Type = typeof(GPUResidentDrawer), Member = "IsProjectSupported", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(IGPUResidentRenderPipeline), Member = "IsGPUResidentDrawerSupportedByProjectConfiguration", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Application), Member = "get_platform", ReturnType = typeof(RuntimePlatform))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	internal static bool IsProjectSupported(out string message, out LogType severity) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Debug), Member = "LogWarning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	internal static void LogMessage(string message, LogType severity) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	private void OnBeginCameraRendering(ScriptableRenderContext context, Camera camera) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ParallelBitArray), Member = "get_IsCreated", ReturnType = typeof(bool))]
	[Calls(Type = typeof(ParallelBitArray), Member = "Dispose", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void OnBeginContextRendering(ScriptableRenderContext context, List<Camera> cameras) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	private void OnEndCameraRendering(ScriptableRenderContext context, Camera camera) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InstanceCullingBatcher), Member = "OnEndContextRendering", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void OnEndContextRendering(ScriptableRenderContext context, List<Camera> cameras) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RenderersBatchersContext), Member = "UpdateAmbientProbeAndGpuBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private void OnSceneLoaded(Scene scene, LoadSceneMode mode) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RenderersBatchersContext), Member = "UpdateAmbientProbeAndGpuBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public static void OnSetupAmbientProbe() { }

	[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderPipeline", Member = "RenderSingleCamera", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), "UnityEngine.Rendering.Universal.UniversalCameraData"}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static void PostCullBeginCameraRendering(RenderRequestBatcherContext context) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RenderersBatchersContext), Member = "UpdateFrame", ReturnType = typeof(void))]
	[Calls(Type = typeof(InstanceCullingBatcher), Member = "UpdateFrame", ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderersBatchersContext), Member = "UpdateInstanceMotions", ReturnType = typeof(void))]
	[Calls(Type = typeof(Unity.Collections.NativeList`1<UnityEngine.Rendering.GPUDrivenPackedMaterialData>), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(Unity.Collections.NativeList`1<System.Int32>), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = "UnityEngine.TypeDispatchData", Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = "UnityEngine.TransformDispatchData", Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(GPUResidentDrawer), Member = "ProcessRendererMaterialAndMeshChanges", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Unity.Collections.NativeArray`1<System.Int32>), typeof(Unity.Collections.NativeArray`1<System.Int32>), typeof(Unity.Collections.NativeArray`1<UnityEngine.Rendering.GPUDrivenPackedMaterialData>), typeof(Unity.Collections.NativeArray`1<System.Int32>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GPUResidentDrawer), Member = "ProcessRenderers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.TypeDispatchData", typeof(Unity.Collections.NativeArray`1<System.Int32>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderersBatchersContext), Member = "TransformLODGroups", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Unity.Collections.NativeArray`1<System.Int32>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderersBatchersContext), Member = "UpdateLODGroups", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Unity.Collections.NativeArray`1<System.Int32>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderersBatchersContext), Member = "DestroyLODGroups", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Unity.Collections.NativeArray`1<System.Int32>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InstanceCullingBatcher), Member = "DestroyMeshes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Unity.Collections.NativeArray`1<System.Int32>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Unity.Collections.NativeList`1<UnityEngine.Rendering.InstanceHandle>), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(InstanceCullingBatcher), Member = "DestroyDrawInstances", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Unity.Collections.NativeArray`1<UnityEngine.Rendering.InstanceHandle>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(JobHandle), Member = "Complete", ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderersBatchersContext), Member = "ScheduleQueryMeshInstancesJob", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Unity.Collections.NativeArray`1<System.Int32>), typeof(Unity.Collections.NativeList`1<UnityEngine.Rendering.InstanceHandle>)}, ReturnType = typeof(JobHandle))]
	[Calls(Type = typeof(InstanceCullingBatcher), Member = "DestroyMaterials", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Unity.Collections.NativeArray`1<System.Int32>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FindUnsupportedRenderers_000000EB$BurstDirectCall), Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NativeArray`1<Int32>&), typeof(ReadOnly<SmallIntegerArray>&), typeof(ReadOnly<Int32>&), typeof(NativeList`1<Int32>&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderersBatchersContext), Member = "get_sharedInstanceData", ReturnType = typeof(ReadOnly))]
	[Calls(Type = typeof(NativeList`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AllocatorHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NativeList`1), Member = "AsArray", ReturnType = "Unity.Collections.NativeArray`1<T>")]
	[Calls(Type = typeof(NativeList`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(AllocatorHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AllocatorHandle), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Allocator)}, ReturnType = typeof(AllocatorHandle))]
	[Calls(Type = "UnityEngine.ObjectDispatcher", Member = "GetTypeChangesAndClear", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Allocator), typeof(bool), typeof(bool)}, ReturnType = "UnityEngine.TypeDispatchData")]
	[Calls(Type = "UnityEngine.ObjectDispatcher", Member = "GetTransformChangesAndClear", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.ObjectDispatcher+TransformTrackingType", typeof(Allocator)}, ReturnType = "UnityEngine.TransformDispatchData")]
	[Calls(Type = typeof(RenderersBatchersContext), Member = "UpdateAmbientProbeAndGpuBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 6)]
	private void PostPostLateUpdate() { }

	[CallerCount(Count = 0)]
	[ContainsInvalidInstructions]
	private static void PostPostLateUpdateStatic() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RenderersBatchersContext), Member = "DestroyLODGroups", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Unity.Collections.NativeArray`1<System.Int32>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderersBatchersContext), Member = "UpdateLODGroups", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Unity.Collections.NativeArray`1<System.Int32>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderersBatchersContext), Member = "TransformLODGroups", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Unity.Collections.NativeArray`1<System.Int32>)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private void ProcessLODGroups(NativeArray<Int32> changedID, NativeArray<Int32> destroyed, NativeArray<Int32> transformedID) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InstanceCullingBatcher), Member = "DestroyMaterials", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Unity.Collections.NativeArray`1<System.Int32>)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private void ProcessMaterials(NativeArray<Int32> destroyedID, NativeArray<Int32> unsupportedMaterials) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AllocatorHandle), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Allocator)}, ReturnType = typeof(AllocatorHandle))]
	[Calls(Type = typeof(NativeList`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AllocatorHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderersBatchersContext), Member = "ScheduleQueryMeshInstancesJob", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Unity.Collections.NativeArray`1<System.Int32>), typeof(Unity.Collections.NativeList`1<UnityEngine.Rendering.InstanceHandle>)}, ReturnType = typeof(JobHandle))]
	[Calls(Type = typeof(JobHandle), Member = "Complete", ReturnType = typeof(void))]
	[Calls(Type = typeof(NativeList`1), Member = "AsArray", ReturnType = "Unity.Collections.NativeArray`1<T>")]
	[Calls(Type = typeof(InstanceCullingBatcher), Member = "DestroyDrawInstances", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Unity.Collections.NativeArray`1<UnityEngine.Rendering.InstanceHandle>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Unity.Collections.NativeList`1<UnityEngine.Rendering.InstanceHandle>), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(InstanceCullingBatcher), Member = "DestroyMeshes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Unity.Collections.NativeArray`1<System.Int32>)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private void ProcessMeshes(NativeArray<Int32> destroyedID) { }

	[CalledBy(Type = typeof(GPUResidentDrawer), Member = "PostPostLateUpdate", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Unity.Collections.NativeList`1<System.Int32>), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(GPUResidentBatcher), Member = "UpdateRenderers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Unity.Collections.NativeArray`1<System.Int32>), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InstanceCullingBatcher), Member = "DestroyDrawInstances", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Unity.Collections.NativeArray`1<UnityEngine.Rendering.InstanceHandle>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderersBatchersContext), Member = "ScheduleQueryRendererGroupInstancesJob", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Unity.Collections.NativeArray`1<System.Int32>), typeof(Unity.Collections.NativeArray`1<UnityEngine.Rendering.InstanceHandle>)}, ReturnType = typeof(JobHandle))]
	[Calls(Type = typeof(NativeArray`1), Member = "GetSubArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = "Unity.Collections.NativeArray`1<T>")]
	[Calls(Type = typeof(NativeArray`1), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Collections.NativeArray`1<T>", "Unity.Collections.NativeArray`1<T>", typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NativeList`1), Member = "AsArray", ReturnType = "Unity.Collections.NativeArray`1<T>")]
	[Calls(Type = typeof(NativeArray`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Allocator), typeof(NativeArrayOptions)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NativeArray`1), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(GPUResidentDrawer), Member = "FindRenderersFromMaterialsOrMeshes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Unity.Collections.NativeArray`1<System.Int32>), typeof(Unity.Collections.NativeHashSet`1<System.Int32>), typeof(Unity.Collections.NativeArray`1<System.Int32>), typeof(Allocator)}, ReturnType = typeof(System.ValueTuple`2<Unity.Collections.NativeList`1<System.Int32>, Unity.Collections.NativeList`1<System.Int32>>))]
	[Calls(Type = typeof(ParallelSortExtensions), Member = "ParallelSort", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Unity.Collections.NativeArray`1<System.Int32>)}, ReturnType = typeof(JobHandle))]
	[Calls(Type = typeof(NativeArray`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Collections.NativeArray`1<T>", typeof(Allocator)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(JobHandle), Member = "Complete", ReturnType = typeof(void))]
	[Calls(Type = typeof(NativeHashSet`1), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(InstanceCullingBatcher), Member = "SchedulePackedMaterialCacheUpdate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Unity.Collections.NativeArray`1<System.Int32>), typeof(Unity.Collections.NativeArray`1<UnityEngine.Rendering.GPUDrivenPackedMaterialData>)}, ReturnType = typeof(JobHandle))]
	[Calls(Type = typeof(GetMaterialsWithChangedPackedMaterial_000000EC$BurstDirectCall), Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NativeArray`1<Int32>&), typeof(NativeArray`1<GPUDrivenPackedMaterialData>&), typeof(ReadOnly<Int32, GPUDrivenPackedMaterialData>&), typeof(NativeHashSet`1<Int32>&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NativeHashSet`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(AllocatorHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AllocatorHandle), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Allocator)}, ReturnType = typeof(AllocatorHandle))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 8)]
	private void ProcessRendererMaterialAndMeshChanges(NativeArray<Int32> excludedRenderers, NativeArray<Int32> changedMaterials, NativeArray<GPUDrivenPackedMaterialData> changedPackedMaterialDatas, NativeArray<Int32> changedMeshes) { }

	[CalledBy(Type = typeof(GPUResidentDrawer), Member = "PostPostLateUpdate", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(NativeArray`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Allocator), typeof(NativeArrayOptions)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderersBatchersContext), Member = "ScheduleQueryRendererGroupInstancesJob", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Unity.Collections.NativeArray`1<System.Int32>), typeof(Unity.Collections.NativeArray`1<UnityEngine.Rendering.InstanceHandle>)}, ReturnType = typeof(JobHandle))]
	[Calls(Type = typeof(JobHandle), Member = "Complete", ReturnType = typeof(void))]
	[Calls(Type = typeof(InstanceCullingBatcher), Member = "DestroyDrawInstances", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Unity.Collections.NativeArray`1<UnityEngine.Rendering.InstanceHandle>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NativeArray`1), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(GPUResidentBatcher), Member = "UpdateRenderers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Unity.Collections.NativeArray`1<System.Int32>), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GPUResidentBatcher), Member = "FreeRendererGroupInstances", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Unity.Collections.NativeArray`1<System.Int32>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NativeArray`1), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Collections.NativeArray`1<T>&"}, ReturnType = "System.ReadOnlySpan`1<T>")]
	[Calls(Type = "UnityEngine.Rendering.GPUDrivenProcessor", Member = "DisableGPUDrivenRendering", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Int32>)}, ReturnType = typeof(void))]
	[Calls(Type = "UnityEngine.ObjectDispatcher", Member = "GetTransformChangesAndClear", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.ObjectDispatcher+TransformTrackingType", typeof(Allocator)}, ReturnType = "UnityEngine.TransformDispatchData")]
	[Calls(Type = typeof(RenderersBatchersContext), Member = "UpdateInstanceTransforms", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Unity.Collections.NativeArray`1<UnityEngine.Rendering.InstanceHandle>), typeof(Unity.Collections.NativeArray`1<UnityEngine.Matrix4x4>)}, ReturnType = typeof(void))]
	[Calls(Type = "UnityEngine.TransformDispatchData", Member = "Dispose", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	private void ProcessRenderers(TypeDispatchData rendererChanges, NativeArray<Int32> unsupportedRenderers) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GPUResidentDrawer), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(GPUResidentDrawer), Member = "IsGPUResidentDrawerSupportedBySRP", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GPUResidentDrawerSettings), typeof(String&), typeof(LogType&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Debug), Member = "LogWarning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GPUResidentDrawer), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GPUResidentDrawerSettings), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	private static void Recreate(GPUResidentDrawerSettings settings) { }

	[CallerCount(Count = 3)]
	[Calls(Type = typeof(GPUResidentDrawer), Member = "GetGlobalSettingsFromRPAsset", ReturnType = typeof(GPUResidentDrawerSettings))]
	[Calls(Type = typeof(GPUResidentDrawer), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(GPUResidentDrawer), Member = "IsGPUResidentDrawerSupportedBySRP", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GPUResidentDrawerSettings), typeof(String&), typeof(LogType&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Debug), Member = "LogWarning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GPUResidentDrawer), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GPUResidentDrawerSettings), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	internal static void Reinitialize() { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	public static void ReinitializeIfNeeded() { }

	[CalledBy(Type = typeof(GPUResidentDrawer), Member = "Dispose", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PlayerLoop), Member = "GetCurrentPlayerLoop", ReturnType = typeof(PlayerLoopSystem))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(List`1), Member = "ToArray", ReturnType = "T[]")]
	[Calls(Type = typeof(PlayerLoop), Member = "SetPlayerLoop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PlayerLoopSystem)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 5)]
	private void RemoveFromPlayerLoop() { }

	[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderer", Member = "SetupRenderGraphFinalPassDebug", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(ContextContainer)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(OcclusionCullingCommon), Member = "RenderDebugOccluderOverlay", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(DebugDisplayGPUResidentDrawer), typeof(Vector2), typeof(float), typeof(TextureHandle)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public static void RenderDebugOccluderOverlay(RenderGraph renderGraph, DebugDisplayGPUResidentDrawer debugSettings, Vector2 screenPos, float maxHeight, TextureHandle colorBuffer) { }

	[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderer", Member = "SetupRenderGraphFinalPassDebug", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(ContextContainer)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(OcclusionCullingCommon), Member = "RenderDebugOcclusionTestOverlay", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(DebugDisplayGPUResidentDrawer), typeof(int), typeof(TextureHandle)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public static void RenderDebugOcclusionTestOverlay(RenderGraph renderGraph, DebugDisplayGPUResidentDrawer debugSettings, int viewInstanceID, TextureHandle colorBuffer) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RenderersBatchersContext), Member = "ScheduleQueryMeshInstancesJob", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Unity.Collections.NativeArray`1<System.Int32>), typeof(Unity.Collections.NativeList`1<UnityEngine.Rendering.InstanceHandle>)}, ReturnType = typeof(JobHandle))]
	[CallsUnknownMethods(Count = 1)]
	private JobHandle ScheduleQueryMeshInstancesJob(NativeArray<Int32> sortedMeshIDs, NativeList<InstanceHandle> instances) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RenderersBatchersContext), Member = "ScheduleQueryRendererGroupInstancesJob", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Unity.Collections.NativeArray`1<System.Int32>), typeof(Unity.Collections.NativeArray`1<UnityEngine.Rendering.InstanceHandle>)}, ReturnType = typeof(JobHandle))]
	[CallsUnknownMethods(Count = 1)]
	private JobHandle ScheduleQueryRendererGroupInstancesJob(NativeArray<Int32> rendererGroupIDs, NativeArray<InstanceHandle> instances) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RenderersBatchersContext), Member = "ScheduleQueryRendererGroupInstancesJob", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Unity.Collections.NativeArray`1<System.Int32>), typeof(Unity.Collections.NativeList`1<UnityEngine.Rendering.InstanceHandle>)}, ReturnType = typeof(JobHandle))]
	[CallsUnknownMethods(Count = 1)]
	private JobHandle ScheduleQueryRendererGroupInstancesJob(NativeArray<Int32> rendererGroupIDs, NativeList<InstanceHandle> instances) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RenderersBatchersContext), Member = "ScheduleQueryRendererGroupInstancesJob", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Unity.Collections.NativeArray`1<System.Int32>), typeof(Unity.Collections.NativeArray`1<System.Int32>), typeof(Unity.Collections.NativeArray`1<System.Int32>), typeof(Unity.Collections.NativeList`1<UnityEngine.Rendering.InstanceHandle>)}, ReturnType = typeof(JobHandle))]
	[CallsUnknownMethods(Count = 1)]
	private JobHandle ScheduleQueryRendererGroupInstancesJob(NativeArray<Int32> rendererGroupIDs, NativeArray<Int32> instancesOffset, NativeArray<Int32> instancesCount, NativeList<InstanceHandle> instances) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	internal static void set_ForceOcclusion(bool value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	internal static void set_MaintainContext(bool value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RenderersBatchersContext), Member = "UpdateInstanceTransforms", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Unity.Collections.NativeArray`1<UnityEngine.Rendering.InstanceHandle>), typeof(Unity.Collections.NativeArray`1<UnityEngine.Matrix4x4>)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private void TransformInstances(NativeArray<InstanceHandle> instances, NativeArray<Matrix4x4> localToWorldMatrices) { }

	[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderer", Member = "UpdateInstanceOccluders", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), "UnityEngine.Rendering.Universal.UniversalCameraData", typeof(TextureHandle)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(RenderersBatchersContext), Member = "get_hasBoundingSpheres", ReturnType = typeof(bool))]
	[Calls(Type = typeof(OcclusionCullingCommon), Member = "UpdateInstanceOccluders", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(OccluderParameters&), typeof(System.ReadOnlySpan`1<UnityEngine.Rendering.OccluderSubviewUpdate>)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	public static void UpdateInstanceOccluders(RenderGraph renderGraph, in OccluderParameters occluderParameters, ReadOnlySpan<OccluderSubviewUpdate> occluderSubviewUpdates) { }

}

