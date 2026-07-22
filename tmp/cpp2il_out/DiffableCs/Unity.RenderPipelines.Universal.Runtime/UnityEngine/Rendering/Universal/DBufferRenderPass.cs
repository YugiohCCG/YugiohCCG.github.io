namespace UnityEngine.Rendering.Universal;

internal class DBufferRenderPass : ScriptableRenderPass
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static BaseRenderFunc<PassData, RasterGraphContext> <>9__36_0; //Field offset: 0x8

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		private static <>c() { }

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(DBufferRenderPass), Member = "SetKeywords", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RasterCommandBuffer), "UnityEngine.Rendering.Universal.DBufferRenderPass+PassData"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(RendererListHandle), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RendererListHandle)}, ReturnType = typeof(RendererList))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		internal void <RecordRenderGraph>b__36_0(PassData data, RasterGraphContext rgContext) { }

	}

	private class PassData
	{
		internal DecalDrawDBufferSystem drawSystem; //Field offset: 0x10
		internal DBufferSettings settings; //Field offset: 0x18
		internal Material dBufferClear; //Field offset: 0x20
		internal ProfilingSampler dBufferClearSampler; //Field offset: 0x28
		internal bool decalLayers; //Field offset: 0x30
		internal RTHandle dBufferDepth; //Field offset: 0x38
		internal RTHandle[] dBufferColorHandles; //Field offset: 0x40
		internal RendererListHandle rendererList; //Field offset: 0x48

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public PassData() { }

	}

	internal static String[] s_DBufferNames; //Field offset: 0x0
	internal static string s_DBufferDepthName; //Field offset: 0x8
	private static readonly int s_SSAOTextureID; //Field offset: 0x10
	private DecalDrawDBufferSystem m_DrawSystem; //Field offset: 0xB8
	private DBufferSettings m_Settings; //Field offset: 0xC0
	private Material m_DBufferClear; //Field offset: 0xC8
	private FilteringSettings m_FilteringSettings; //Field offset: 0xD0
	private List<ShaderTagId> m_ShaderTagIdList; //Field offset: 0xF0
	private ProfilingSampler m_DBufferClearSampler; //Field offset: 0xF8
	private bool m_DecalLayers; //Field offset: 0x100
	private RTHandle m_DBufferDepth; //Field offset: 0x108
	private PassData m_PassData; //Field offset: 0x110
	[CompilerGenerated]
	private RTHandle[] <dBufferColorHandles>k__BackingField; //Field offset: 0x118
	[CompilerGenerated]
	private RTHandle <depthHandle>k__BackingField; //Field offset: 0x120
	private TextureHandle[] dbufferHandles; //Field offset: 0x128

	internal RTHandle[] dBufferColorHandles
	{
		[CallerCount(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		internal get { } //Length: 8
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private set { } //Length: 19
	}

	internal RTHandle dBufferDepth
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		internal get { } //Length: 8
	}

	internal RTHandle depthHandle
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		internal get { } //Length: 8
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private set { } //Length: 19
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Shader), Member = "PropertyToID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 8)]
	private static DBufferRenderPass() { }

	[CalledBy(Type = typeof(DecalRendererFeature), Member = "RecreateSystemsIfNeeded", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderer), typeof(CameraData&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ScriptableRenderPass), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(ProfilingSampler), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ScriptableRenderPass), Member = "set_profilingSampler", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ProfilingSampler)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderQueueRange), Member = "get_opaque", ReturnType = typeof(RenderQueueRange))]
	[Calls(Type = typeof(System.Nullable`1<UnityEngine.Rendering.RenderQueueRange>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderQueueRange)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FilteringSettings), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Nullable`1<UnityEngine.Rendering.RenderQueueRange>), typeof(int), typeof(uint), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ShaderTagId), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 9)]
	public DBufferRenderPass(Material dBufferClear, DBufferSettings settings, DecalDrawDBufferSystem drawSystem, bool decalLayers) { }

	[CalledBy(Type = typeof(DBufferRenderPass), Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), typeof(RenderingData&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Blitter), Member = "BlitTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(RTHandle), typeof(Vector4), typeof(Material), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	private static void Clear(CommandBuffer cmd, PassData passData) { }

	[CalledBy(Type = typeof(DecalRendererFeature), Member = "Dispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(RTHandle), Member = "Release", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	public void Dispose() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DBufferRenderPass), Member = "InitPassData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PassData&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderingData), Member = "get_commandBuffer", ReturnType = typeof(CommandBuffer&))]
	[Calls(Type = typeof(ScriptableRenderPass), Member = "get_profilingSampler", ReturnType = typeof(ProfilingSampler))]
	[Calls(Type = typeof(ScriptableRenderContext), Member = "ExecuteCommandBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CommandBuffer), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(CommandBuffer), Member = "SetGlobalTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(RenderTargetIdentifier)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DBufferRenderPass), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(PassData)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ContextContainer), Member = "Get", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(DBufferRenderPass), Member = "InitRendererListParams", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UniversalRenderingData), typeof(UniversalCameraData), typeof(UniversalLightData)}, ReturnType = typeof(RendererListParams))]
	[Calls(Type = typeof(ScriptableRenderContext), Member = "CreateRendererList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RendererListParams&)}, ReturnType = typeof(RendererList))]
	[Calls(Type = typeof(DecalDrawSystem), Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RasterCommandBuffer)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 33)]
	[ContainsUnimplementedInstructions]
	[Obsolete("This rendering path is for compatibility mode only (when Render Graph is disabled). Use Render Graph API instead.", False)]
	public virtual void Execute(ScriptableRenderContext context, ref RenderingData renderingData) { }

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DecalDrawSystem), Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RasterCommandBuffer)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	private static void ExecutePass(RasterCommandBuffer cmd, PassData passData, RendererList rendererList, bool renderGraph) { }

	[CallerCount(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	internal RTHandle[] get_dBufferColorHandles() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	internal RTHandle get_dBufferDepth() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	internal RTHandle get_depthHandle() { }

	[CalledBy(Type = typeof(DBufferRenderPass), Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), typeof(RenderingData&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	private void InitPassData(ref PassData passData) { }

	[CalledBy(Type = typeof(DBufferRenderPass), Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), typeof(RenderingData&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DBufferRenderPass), Member = "RecordRenderGraph", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(ContextContainer)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(RenderingUtils), Member = "CreateDrawingSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.Rendering.ShaderTagId>), typeof(UniversalRenderingData), typeof(UniversalCameraData), typeof(UniversalLightData), typeof(SortingCriteria)}, ReturnType = typeof(DrawingSettings))]
	[Calls(Type = typeof(RendererListParams), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CullingResults), typeof(DrawingSettings), typeof(FilteringSettings)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	private RendererListParams InitRendererListParams(UniversalRenderingData renderingData, UniversalCameraData cameraData, UniversalLightData lightData) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CommandBuffer), Member = "SetKeyword", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GlobalKeyword&), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	public virtual void OnCameraCleanup(CommandBuffer cmd) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ScriptableRenderPass), Member = "ConfigureTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RTHandle[]), typeof(RTHandle)}, ReturnType = typeof(void))]
	[Obsolete("This rendering path is for compatibility mode only (when Render Graph is disabled). Use Render Graph API instead.", False)]
	public virtual void OnCameraSetup(CommandBuffer cmd, ref RenderingData renderingData) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UniversalResourceData), Member = "set_dBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextureHandle[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Shader), Member = "PropertyToID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(RenderGraph), Member = "CreateRendererList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RendererListParams&)}, ReturnType = typeof(RendererListHandle))]
	[Calls(Type = typeof(DBufferRenderPass), Member = "InitRendererListParams", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UniversalRenderingData), typeof(UniversalCameraData), typeof(UniversalLightData)}, ReturnType = typeof(RendererListParams))]
	[Calls(Type = typeof(UniversalResourceData), Member = "get_ssaoTexture", ReturnType = typeof(TextureHandle))]
	[Calls(Type = typeof(UniversalRenderer), Member = "CreateRenderGraphTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(RenderTextureDescriptor), typeof(string), typeof(bool), typeof(Color), typeof(FilterMode), typeof(TextureWrapMode), typeof(bool)}, ReturnType = typeof(TextureHandle))]
	[Calls(Type = typeof(RenderTextureDescriptor), Member = "set_graphicsFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GraphicsFormat)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(QualitySettings), Member = "get_activeColorSpace", ReturnType = typeof(ColorSpace))]
	[Calls(Type = typeof(ScriptableRenderPass), Member = "get_profilingSampler", ReturnType = typeof(ProfilingSampler))]
	[Calls(Type = typeof(UniversalResourceData), Member = "get_renderingLayersTexture", ReturnType = typeof(TextureHandle))]
	[Calls(Type = typeof(UniversalResourceData), Member = "get_activeDepthTexture", ReturnType = typeof(TextureHandle))]
	[Calls(Type = typeof(UniversalResourceData), Member = "get_dBufferDepth", ReturnType = typeof(TextureHandle))]
	[Calls(Type = typeof(UniversalResourceData), Member = "get_cameraNormalsTexture", ReturnType = typeof(TextureHandle))]
	[Calls(Type = typeof(UniversalResourceData), Member = "get_cameraDepthTexture", ReturnType = typeof(TextureHandle))]
	[Calls(Type = typeof(ContextContainer), Member = "Get", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(RenderGraph), Member = "AddRasterRenderPass", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"PassData"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "PassData&", typeof(ProfilingSampler), typeof(string), typeof(int)}, ReturnType = typeof(IRasterRenderGraphBuilder))]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallsUnknownMethods(Count = 82)]
	public virtual void RecordRenderGraph(RenderGraph renderGraph, ContextContainer frameData) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void set_dBufferColorHandles(RTHandle[] value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void set_depthHandle(RTHandle value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CommandBuffer), Member = "SetGlobalTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(RenderTargetIdentifier)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	private static void SetGlobalTextures(CommandBuffer cmd, PassData passData) { }

	[CalledBy(Type = typeof(<>c), Member = "<RecordRenderGraph>b__36_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PassData), typeof(RasterGraphContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private static void SetKeywords(RasterCommandBuffer cmd, PassData passData) { }

	[CalledBy(Type = typeof(DecalRendererFeature), Member = "SetupRenderPasses", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderer), typeof(RenderingData&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CameraData), Member = "get_cameraTargetDescriptor", ReturnType = typeof(RenderTextureDescriptor&))]
	[Calls(Type = typeof(RenderTextureDescriptor), Member = "set_graphicsFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GraphicsFormat)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderingUtils), Member = "ReAllocateHandleIfNeeded", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RTHandle&), typeof(RenderTextureDescriptor&), typeof(FilterMode), typeof(TextureWrapMode), typeof(int), typeof(float), typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DBufferRenderPass), Member = "Setup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CameraData&), typeof(RTHandle)}, ReturnType = typeof(void))]
	public void Setup(in CameraData cameraData) { }

	[CalledBy(Type = typeof(DBufferRenderPass), Member = "Setup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CameraData&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DecalRendererFeature), Member = "SetupRenderPasses", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderer), typeof(RenderingData&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CameraData), Member = "get_cameraTargetDescriptor", ReturnType = typeof(RenderTextureDescriptor&))]
	[Calls(Type = typeof(QualitySettings), Member = "get_activeColorSpace", ReturnType = typeof(ColorSpace))]
	[Calls(Type = typeof(RenderTextureDescriptor), Member = "set_graphicsFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GraphicsFormat)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderingUtils), Member = "ReAllocateHandleIfNeeded", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RTHandle&), typeof(RenderTextureDescriptor&), typeof(FilterMode), typeof(TextureWrapMode), typeof(int), typeof(float), typeof(string)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 3)]
	public void Setup(in CameraData cameraData, RTHandle depthTextureHandle) { }

}

