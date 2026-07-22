namespace UnityEngine.Rendering;

internal class OcclusionCullingCommon : IDisposable
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static BaseRenderFunc<OcclusionTestOverlaySetupPassData, ComputeGraphContext> <>9__29_0; //Field offset: 0x8
		public static BaseRenderFunc<OccluderOverlayPassData, RasterGraphContext> <>9__32_0; //Field offset: 0x10
		public static BaseRenderFunc<UpdateOccludersPassData, ComputeGraphContext> <>9__37_0; //Field offset: 0x18

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		private static <>c() { }

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(RenderGraphObjectPool), Member = "GetTempMaterialPropertyBlock", ReturnType = typeof(MaterialPropertyBlock))]
		[Calls(Type = typeof(RTHandle), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RTHandle)}, ReturnType = typeof(Texture))]
		[Calls(Type = typeof(MaterialPropertyBlock), Member = "SetTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Texture)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(MaterialPropertyBlock), Member = "SetVector", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Vector4)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 1)]
		internal void <RenderDebugOccluderOverlay>b__32_0(OccluderOverlayPassData data, RasterGraphContext ctx) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(GPUResidentBatcher), Member = "get_occlusionCullingCommon", ReturnType = typeof(OcclusionCullingCommon))]
		[Calls(Type = typeof(ComputeCommandBuffer), Member = "SetBufferData", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(OcclusionCullingDebugShaderVariables)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputeBuffer), typeof(Unity.Collections.NativeArray`1<UnityEngine.Rendering.OcclusionCullingDebugShaderVariables>)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ComputeBuffer), Member = "get_stride", ReturnType = typeof(int))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		internal void <RenderDebugOcclusionTestOverlay>b__29_0(OcclusionTestOverlaySetupPassData data, ComputeGraphContext ctx) { }

		[CallerCount(Count = 0)]
		[Calls(Type = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Collections.Generic.List`1<UnityEngine.Rendering.OccluderSubviewUpdate>), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(OccluderSubviewUpdate))]
		[Calls(Type = typeof(GPUResidentBatcher), Member = "get_occlusionCullingCommon", ReturnType = typeof(OcclusionCullingCommon))]
		[Calls(Type = typeof(Span`1), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Span`1<T>"}, ReturnType = "System.ReadOnlySpan`1<T>")]
		[Calls(Type = typeof(OcclusionCullingCommon), Member = "CreateFarDepthPyramid", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputeCommandBuffer), typeof(OccluderParameters&), typeof(System.ReadOnlySpan`1<UnityEngine.Rendering.OccluderSubviewUpdate>), typeof(OccluderHandles&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(InstanceCullingBatcher), Member = "InstanceOccludersUpdated", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 4)]
		[ContainsUnimplementedInstructions]
		internal void <UpdateInstanceOccluders>b__37_0(UpdateOccludersPassData data, ComputeGraphContext context) { }

	}

	private struct DebugOccluderViewData
	{
		public int passIndex; //Field offset: 0x0
		public Rect viewport; //Field offset: 0x4
		public bool valid; //Field offset: 0x14

	}

	private struct OccluderContextSlot
	{
		public bool valid; //Field offset: 0x0
		public int lastUsedFrameIndex; //Field offset: 0x4
		public int viewInstanceID; //Field offset: 0x8

	}

	private class OccluderOverlayPassData
	{
		public Material debugMaterial; //Field offset: 0x10
		public RTHandle occluderTexture; //Field offset: 0x18
		public Rect viewport; //Field offset: 0x20
		public int passIndex; //Field offset: 0x30
		public Vector2 validRange; //Field offset: 0x34

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public OccluderOverlayPassData() { }

	}

	private class OcclusionTestOverlayPassData
	{
		public BufferHandle debugPyramid; //Field offset: 0x10

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public OcclusionTestOverlayPassData() { }

	}

	private class OcclusionTestOverlaySetupPassData
	{
		public OcclusionCullingDebugShaderVariables cb; //Field offset: 0x10

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public OcclusionTestOverlaySetupPassData() { }

	}

	private static class ShaderIDs
	{
		public static readonly int OcclusionCullingCommonShaderVariables; //Field offset: 0x0
		public static readonly int _OccluderDepthPyramid; //Field offset: 0x4
		public static readonly int _OcclusionDebugOverlay; //Field offset: 0x8
		public static readonly int OcclusionCullingDebugShaderVariables; //Field offset: 0xC

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Shader), Member = "PropertyToID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
		private static ShaderIDs() { }

	}

	private class UpdateOccludersPassData
	{
		public OccluderParameters occluderParams; //Field offset: 0x10
		public List<OccluderSubviewUpdate> occluderSubviewUpdates; //Field offset: 0x38
		public OccluderHandles occluderHandles; //Field offset: 0x40

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public UpdateOccludersPassData() { }

	}

	private static readonly int s_MaxContextGCFrame; //Field offset: 0x0
	private Material m_DebugOcclusionTestMaterial; //Field offset: 0x10
	private Material m_OccluderDebugViewMaterial; //Field offset: 0x18
	private ComputeShader m_OcclusionDebugCS; //Field offset: 0x20
	private int m_ClearOcclusionDebugKernel; //Field offset: 0x28
	private ComputeShader m_OccluderDepthPyramidCS; //Field offset: 0x30
	private int m_OccluderDepthDownscaleKernel; //Field offset: 0x38
	private int m_FrameIndex; //Field offset: 0x3C
	private SilhouettePlaneCache m_SilhouettePlaneCache; //Field offset: 0x40
	private NativeParallelHashMap<Int32, Int32> m_ViewIDToIndexMap; //Field offset: 0x68
	private List<OccluderContext> m_OccluderContextData; //Field offset: 0x78
	private NativeList<OccluderContextSlot> m_OccluderContextSlots; //Field offset: 0x80
	private NativeList<Int32> m_FreeOccluderContexts; //Field offset: 0x88
	private NativeArray<OcclusionCullingCommonShaderVariables> m_CommonShaderVariables; //Field offset: 0x90
	private ComputeBuffer m_CommonConstantBuffer; //Field offset: 0xA0
	private NativeArray<OcclusionCullingDebugShaderVariables> m_DebugShaderVariables; //Field offset: 0xA8
	private ComputeBuffer m_DebugConstantBuffer; //Field offset: 0xB8
	private ProfilingSampler m_ProfilingSamplerUpdateOccluders; //Field offset: 0xC0
	private ProfilingSampler m_ProfilingSamplerOcclusionTestOverlay; //Field offset: 0xC8
	private ProfilingSampler m_ProfilingSamplerOccluderOverlay; //Field offset: 0xD0

	[CallerCount(Count = 0)]
	private static OcclusionCullingCommon() { }

	[CallerCount(Count = 2180)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public OcclusionCullingCommon() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BufferHandle), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BufferHandle)}, ReturnType = typeof(GraphicsBuffer))]
	[Calls(Type = typeof(CoreUtils), Member = "DrawFullScreen", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RasterCommandBuffer), typeof(Material), typeof(MaterialPropertyBlock), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	private void <RenderDebugOcclusionTestOverlay>b__29_1(OcclusionTestOverlayPassData data, RasterGraphContext ctx) { }

	[CalledBy(Type = typeof(<>c), Member = "<UpdateInstanceOccluders>b__37_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UpdateOccludersPassData), typeof(ComputeGraphContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(NativeParallelHashMap`2), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue&"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(SilhouettePlaneCache), Member = "GetSubArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Unity.Collections.NativeArray`1<UnityEngine.Plane>))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<UnityEngine.Rendering.OccluderContext>), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(OccluderContext))]
	[Calls(Type = typeof(OccluderContext), Member = "CreateFarDepthPyramid", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputeCommandBuffer), typeof(OccluderParameters&), typeof(System.ReadOnlySpan`1<UnityEngine.Rendering.OccluderSubviewUpdate>), typeof(OccluderHandles&), typeof(Unity.Collections.NativeArray`1<UnityEngine.Plane>), typeof(ComputeShader), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<UnityEngine.Rendering.OccluderContext>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(OccluderContext)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	private void CreateFarDepthPyramid(ComputeCommandBuffer cmd, in OccluderParameters occluderParams, ReadOnlySpan<OccluderSubviewUpdate> occluderSubviewUpdates, in OccluderHandles occluderHandles) { }

	[CalledBy(Type = typeof(OcclusionCullingCommon), Member = "PrepareOccluders", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(OccluderParameters&)}, ReturnType = typeof(OccluderHandles))]
	[CalledBy(Type = typeof(OcclusionCullingCommon), Member = "UpdateFrame", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(NativeParallelHashMap`2), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue&"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<UnityEngine.Rendering.OccluderContext>), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(OccluderContext))]
	[Calls(Type = typeof(OccluderContext), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(NativeList`1), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NativeParallelHashMap`2), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 3)]
	private void DeleteContext(int viewInstanceID) { }

	[CalledBy(Type = typeof(OcclusionCullingCommon), Member = "PrepareCulling", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputeCommandBuffer), typeof(OccluderContext&), typeof(OcclusionCullingSettings&), typeof(InstanceOcclusionTestSubviewSettings&), typeof(OcclusionTestComputeShader&), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(NativeParallelHashMap`2), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue&"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<UnityEngine.Rendering.OccluderContext>), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(OccluderContext))]
	[Calls(Type = typeof(ComputeBuffer), Member = "get_stride", ReturnType = typeof(int))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<UnityEngine.Rendering.OccluderContext>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(OccluderContext)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private void DispatchDebugClear(ComputeCommandBuffer cmd, int viewInstanceID) { }

	[CalledBy(Type = typeof(RenderersBatchersContext), Member = "Dispose", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CoreUtils), Member = "Destroy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<UnityEngine.Rendering.OccluderContext>), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(OccluderContext))]
	[Calls(Type = typeof(OccluderContext), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(NativeParallelHashMap`2), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(Unity.Collections.NativeList`1<System.Int32>), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(Unity.Collections.NativeList`1<UnityEngine.Rendering.SilhouettePlaneCache+Slot>), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(Unity.Collections.NativeList`1<UnityEngine.Plane>), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Unity.Collections.NativeList`1<UnityEngine.Rendering.OcclusionCullingCommon+OccluderContextSlot>), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(NativeArray`1), Member = "Dispose", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public override void Dispose() { }

	[CalledBy(Type = typeof(InstanceCuller), Member = "InstanceOccludersUpdated", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(RenderersBatchersContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InstanceCuller), Member = "InstanceOcclusionTest", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(OcclusionCullingSettings&), typeof(System.ReadOnlySpan`1<UnityEngine.Rendering.SubviewOcclusionTest>), typeof(RenderersBatchersContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InstanceCuller), Member = "AddOcclusionCullingDispatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputeCommandBuffer), typeof(OcclusionCullingSettings&), typeof(InstanceOcclusionTestSubviewSettings&), typeof(IndirectBufferContextHandles&), typeof(OccluderHandles&), typeof(RenderersBatchersContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(NativeParallelHashMap`2), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue&"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<UnityEngine.Rendering.OccluderContext>), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(OccluderContext))]
	[CallsUnknownMethods(Count = 3)]
	internal bool GetOccluderContext(int viewInstanceID, out OccluderContext occluderContext) { }

	[CalledBy(Type = typeof(OcclusionCullingCommon), Member = "RenderDebugOcclusionTestOverlay", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(DebugDisplayGPUResidentDrawer), typeof(int), typeof(TextureHandle)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(OcclusionCullingCommon), Member = "RenderDebugOccluderOverlay", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(DebugDisplayGPUResidentDrawer), typeof(Vector2), typeof(float), typeof(TextureHandle)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(NativeParallelHashMap`2), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue&"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<UnityEngine.Rendering.OccluderContext>), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(OccluderContext))]
	[Calls(Type = typeof(OccluderContext), Member = "GetDebugOutput", ReturnType = typeof(OcclusionCullingDebugOutput))]
	[CallsUnknownMethods(Count = 3)]
	internal OcclusionCullingDebugOutput GetOcclusionTestDebugOutput(int viewInstanceID) { }

	[CalledBy(Type = typeof(InstanceCuller), Member = "CreateCullJobTree", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BatchCullingContext&), typeof(BatchCullingOutput), typeof(ReadOnly&), typeof(ReadOnly&), typeof(ReadOnly&), typeof(Unity.Collections.NativeList`1<UnityEngine.Rendering.LODGroupCullingData>), typeof(CPUDrawInstanceData), typeof(Unity.Collections.NativeParallelHashMap`2<System.UInt32, UnityEngine.Rendering.BatchID>), typeof(int), typeof(float), typeof(OcclusionCullingCommon)}, ReturnType = typeof(JobHandle))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(NativeParallelHashMap`2), Member = "ContainsKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = typeof(bool))]
	internal bool HasOccluderContext(int viewInstanceID) { }

	[CalledBy(Type = typeof(RenderersBatchersContext), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderersBatchersContextDesc&), "UnityEngine.Rendering.GPUDrivenProcessor", typeof(GPUResidentDrawerResources)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CoreUtils), Member = "CreateEngineMaterial", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Shader)}, ReturnType = typeof(Material))]
	[Calls(Type = typeof(ComputeShader), Member = "FindKernel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(SilhouettePlaneCache), Member = "Init", ReturnType = typeof(void))]
	[Calls(Type = typeof(AllocatorHandle), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Allocator)}, ReturnType = typeof(AllocatorHandle))]
	[Calls(Type = typeof(NativeParallelHashMap`2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(AllocatorHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NativeList`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(AllocatorHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ProfilingSampler), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Unity.Collections.NativeArray`1<UnityEngine.Rendering.OcclusionCullingCommonShaderVariables>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Allocator), typeof(NativeArrayOptions)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ComputeBuffer), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(ComputeBufferType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Unity.Collections.NativeArray`1<UnityEngine.Rendering.OcclusionCullingDebugShaderVariables>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Allocator), typeof(NativeArrayOptions)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 11)]
	internal void Init(GPUResidentDrawerResources resources) { }

	[CalledBy(Type = typeof(OcclusionCullingCommon), Member = "PrepareOccluders", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(OccluderParameters&)}, ReturnType = typeof(OccluderHandles))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.Collections.Generic.List`1<UnityEngine.Rendering.OccluderContext>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(OccluderContext)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NativeList`1), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NativeList`1), Member = "RemoveAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<UnityEngine.Rendering.OccluderContext>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(OccluderContext)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Unity.Collections.NativeParallelHashMap`2<System.Int32, System.Int32>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 8)]
	private int NewContext(int viewInstanceID) { }

	[CalledBy(Type = typeof(InstanceCuller), Member = "AddOcclusionCullingDispatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputeCommandBuffer), typeof(OcclusionCullingSettings&), typeof(InstanceOcclusionTestSubviewSettings&), typeof(IndirectBufferContextHandles&), typeof(OccluderHandles&), typeof(RenderersBatchersContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GPUResidentDrawer), Member = "GetDebugStats", ReturnType = typeof(DebugRendererBatcherStats))]
	[Calls(Type = typeof(OcclusionCullingCommonShaderVariables), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(OccluderContext&), typeof(InstanceOcclusionTestSubviewSettings&), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ComputeCommandBuffer), Member = "SetBufferData", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(OcclusionCullingCommonShaderVariables)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputeBuffer), typeof(Unity.Collections.NativeArray`1<UnityEngine.Rendering.OcclusionCullingCommonShaderVariables>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ComputeBuffer), Member = "get_stride", ReturnType = typeof(int))]
	[Calls(Type = typeof(OcclusionCullingCommon), Member = "DispatchDebugClear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputeCommandBuffer), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	internal void PrepareCulling(ComputeCommandBuffer cmd, in OccluderContext occluderCtx, in OcclusionCullingSettings settings, in InstanceOcclusionTestSubviewSettings subviewSettings, in OcclusionTestComputeShader shader, bool useOcclusionDebug) { }

	[CalledBy(Type = typeof(OcclusionCullingCommon), Member = "UpdateInstanceOccluders", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(OccluderParameters&), typeof(System.ReadOnlySpan`1<UnityEngine.Rendering.OccluderSubviewUpdate>)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(OcclusionCullingCommon), Member = "DeleteContext", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NativeParallelHashMap`2), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue&"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(OcclusionCullingCommon), Member = "NewContext", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<UnityEngine.Rendering.OccluderContext>), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(OccluderContext))]
	[Calls(Type = typeof(OccluderContext), Member = "PrepareOccluders", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(OccluderParameters&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderGraph), Member = "ImportTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RTHandle), typeof(RenderTargetInfo), typeof(ImportResourceParams)}, ReturnType = typeof(TextureHandle))]
	[Calls(Type = typeof(RenderGraph), Member = "ImportBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GraphicsBuffer), typeof(bool)}, ReturnType = typeof(BufferHandle))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<UnityEngine.Rendering.OccluderContext>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(OccluderContext)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	private OccluderHandles PrepareOccluders(RenderGraph renderGraph, in OccluderParameters occluderParams) { }

	[CalledBy(Type = typeof(GPUResidentDrawer), Member = "RenderDebugOccluderOverlay", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(DebugDisplayGPUResidentDrawer), typeof(Vector2), typeof(float), typeof(TextureHandle)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DebugDisplayGPUResidentDrawer), Member = "GetOccluderViewInstanceID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(OcclusionCullingCommon), Member = "GetOcclusionTestDebugOutput", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(OcclusionCullingDebugOutput))]
	[Calls(Type = typeof(Material), Member = "FindPass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(RenderGraph), Member = "AddRasterRenderPass", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"PassData"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "PassData&", typeof(ProfilingSampler), typeof(string), typeof(int)}, ReturnType = typeof(IRasterRenderGraphBuilder))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 19)]
	public void RenderDebugOccluderOverlay(RenderGraph renderGraph, DebugDisplayGPUResidentDrawer debugSettings, Vector2 screenPos, float maxHeight, TextureHandle colorBuffer) { }

	[CalledBy(Type = typeof(GPUResidentDrawer), Member = "RenderDebugOcclusionTestOverlay", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(DebugDisplayGPUResidentDrawer), typeof(int), typeof(TextureHandle)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DebugDisplayGPUResidentDrawer), Member = "get_occlusionTestOverlayEnable", ReturnType = typeof(bool))]
	[Calls(Type = typeof(OcclusionCullingCommon), Member = "GetOcclusionTestDebugOutput", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(OcclusionCullingDebugOutput))]
	[Calls(Type = typeof(RenderGraph), Member = "AddComputePass", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"PassData"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "PassData&", typeof(ProfilingSampler), typeof(string), typeof(int)}, ReturnType = typeof(IComputeRenderGraphBuilder))]
	[Calls(Type = typeof(RenderGraph), Member = "AddRasterRenderPass", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"PassData"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "PassData&", typeof(ProfilingSampler), typeof(string), typeof(int)}, ReturnType = typeof(IRasterRenderGraphBuilder))]
	[Calls(Type = typeof(RenderGraph), Member = "ImportBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GraphicsBuffer), typeof(bool)}, ReturnType = typeof(BufferHandle))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 25)]
	public void RenderDebugOcclusionTestOverlay(RenderGraph renderGraph, DebugDisplayGPUResidentDrawer debugSettings, int viewInstanceID, TextureHandle colorBuffer) { }

	[CalledBy(Type = typeof(InstanceCuller), Member = "AddOcclusionCullingDispatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputeCommandBuffer), typeof(OcclusionCullingSettings&), typeof(InstanceOcclusionTestSubviewSettings&), typeof(IndirectBufferContextHandles&), typeof(OccluderHandles&), typeof(RenderersBatchersContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BufferHandle), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BufferHandle)}, ReturnType = typeof(GraphicsBuffer))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	internal static void SetDebugPyramid(ComputeCommandBuffer cmd, in OcclusionTestComputeShader shader, int kernel, in OccluderHandles occluderHandles) { }

	[CalledBy(Type = typeof(InstanceCuller), Member = "AddOcclusionCullingDispatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputeCommandBuffer), typeof(OcclusionCullingSettings&), typeof(InstanceOcclusionTestSubviewSettings&), typeof(IndirectBufferContextHandles&), typeof(OccluderHandles&), typeof(RenderersBatchersContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ComputeCommandBuffer), Member = "SetComputeTextureParam", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputeShader), typeof(int), typeof(int), typeof(TextureHandle)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	internal static void SetDepthPyramid(ComputeCommandBuffer cmd, in OcclusionTestComputeShader shader, int kernel, in OccluderHandles occluderHandles) { }

	[CalledBy(Type = typeof(RenderersBatchersContext), Member = "UpdateFrame", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.Collections.Generic.List`1<UnityEngine.Rendering.OccluderContext>), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(OccluderContext))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<UnityEngine.Rendering.OccluderContext>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(OccluderContext)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(OcclusionCullingCommon), Member = "DeleteContext", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SilhouettePlaneCache), Member = "FreeUnusedSlots", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	internal void UpdateFrame() { }

	[CalledBy(Type = typeof(GPUResidentBatcher), Member = "UpdateInstanceOccluders", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(OccluderParameters&), typeof(System.ReadOnlySpan`1<UnityEngine.Rendering.OccluderSubviewUpdate>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GPUResidentDrawer), Member = "UpdateInstanceOccluders", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(OccluderParameters&), typeof(System.ReadOnlySpan`1<UnityEngine.Rendering.OccluderSubviewUpdate>)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(OcclusionCullingCommon), Member = "PrepareOccluders", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(OccluderParameters&)}, ReturnType = typeof(OccluderHandles))]
	[Calls(Type = typeof(RenderGraph), Member = "AddComputePass", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"PassData"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "PassData&", typeof(ProfilingSampler), typeof(string), typeof(int)}, ReturnType = typeof(IComputeRenderGraphBuilder))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<UnityEngine.Rendering.OccluderSubviewUpdate>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(OccluderSubviewUpdate)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BufferHandle), Member = "IsValid", ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 28)]
	public bool UpdateInstanceOccluders(RenderGraph renderGraph, in OccluderParameters occluderParams, ReadOnlySpan<OccluderSubviewUpdate> occluderSubviewUpdates) { }

	[CalledBy(Type = typeof(RenderersBatchersContext), Member = "UpdateFrame", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(NativeList`1), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = "Unity.Collections.LowLevel.Unsafe.UnsafeParallelHashMapData", Member = "MoveNextSearch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnsafeParallelHashMapData*), typeof(Int32&), typeof(Int32&), typeof(Int32&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(KeyValue`2), Member = "get_Key", ReturnType = "TKey")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<UnityEngine.Rendering.OccluderContext>), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(OccluderContext))]
	[Calls(Type = typeof(NativeList`1), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&"}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 8)]
	public void UpdateOccluderStats(DebugRendererBatcherStats debugStats) { }

	[CalledBy(Type = typeof(InstanceCuller), Member = "CreateFrustumCullingJob", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BatchCullingContext&), typeof(ReadOnly&), typeof(ReadOnly&), typeof(Unity.Collections.NativeList`1<UnityEngine.Rendering.LODGroupCullingData>), typeof(BinningConfig&), typeof(float), typeof(OcclusionCullingCommon), typeof(Unity.Collections.NativeArray`1<System.Byte>), typeof(Unity.Collections.NativeArray`1<System.Byte>)}, ReturnType = typeof(JobHandle))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SilhouettePlaneCache), Member = "Update", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Unity.Collections.NativeArray`1<UnityEngine.Plane>), typeof(int)}, ReturnType = typeof(void))]
	internal void UpdateSilhouettePlanes(int viewInstanceID, NativeArray<Plane> planes) { }

	[CalledBy(Type = typeof(InstanceCuller), Member = "AddOcclusionCullingDispatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputeCommandBuffer), typeof(OcclusionCullingSettings&), typeof(InstanceOcclusionTestSubviewSettings&), typeof(IndirectBufferContextHandles&), typeof(OccluderHandles&), typeof(RenderersBatchersContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[ContainsUnimplementedInstructions]
	internal static bool UseOcclusionDebug(in OccluderContext occluderCtx) { }

}

