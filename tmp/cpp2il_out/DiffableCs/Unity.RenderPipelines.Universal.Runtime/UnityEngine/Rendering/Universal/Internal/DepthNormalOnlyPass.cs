namespace UnityEngine.Rendering.Universal.Internal;

public class DepthNormalOnlyPass : ScriptableRenderPass
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static BaseRenderFunc<PassData, RasterGraphContext> <>9__42_0; //Field offset: 0x8

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		private static <>c() { }

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(RenderingLayerUtils), Member = "SetupProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RasterCommandBuffer), typeof(MaskSize)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(RendererListHandle), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RendererListHandle)}, ReturnType = typeof(RendererList))]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 1)]
		internal void <Render>b__42_0(PassData data, RasterGraphContext context) { }

	}

	private class PassData
	{
		internal TextureHandle cameraDepthTexture; //Field offset: 0x10
		internal TextureHandle cameraNormalsTexture; //Field offset: 0x20
		internal bool enableRenderingLayers; //Field offset: 0x30
		internal MaskSize maskSize; //Field offset: 0x34
		internal RendererListHandle rendererList; //Field offset: 0x38

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public PassData() { }

	}

	private static readonly List<ShaderTagId> k_DepthNormals; //Field offset: 0x0
	private static readonly RTHandle[] k_ColorAttachment1; //Field offset: 0x8
	private static readonly RTHandle[] k_ColorAttachment2; //Field offset: 0x10
	private static readonly int s_CameraDepthTextureID; //Field offset: 0x18
	private static readonly int s_CameraNormalsTextureID; //Field offset: 0x1C
	private static readonly int s_CameraRenderingLayersTextureID; //Field offset: 0x20
	[CompilerGenerated]
	private List<ShaderTagId> <shaderTagIds>k__BackingField; //Field offset: 0xB8
	[CompilerGenerated]
	private RTHandle <depthHandle>k__BackingField; //Field offset: 0xC0
	[CompilerGenerated]
	private RTHandle <normalHandle>k__BackingField; //Field offset: 0xC8
	[CompilerGenerated]
	private RTHandle <renderingLayersHandle>k__BackingField; //Field offset: 0xD0
	[CompilerGenerated]
	private bool <enableRenderingLayers>k__BackingField; //Field offset: 0xD8
	[CompilerGenerated]
	private MaskSize <renderingLayersMaskSize>k__BackingField; //Field offset: 0xDC
	private FilteringSettings m_FilteringSettings; //Field offset: 0xE0
	private PassData m_PassData; //Field offset: 0x100

	private RTHandle depthHandle
	{
		[CallerCount(Count = 2)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private get { } //Length: 8
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private set { } //Length: 19
	}

	internal bool enableRenderingLayers
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		internal get { } //Length: 8
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		internal set { } //Length: 7
	}

	private RTHandle normalHandle
	{
		[CallerCount(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private get { } //Length: 8
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private set { } //Length: 19
	}

	private RTHandle renderingLayersHandle
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private get { } //Length: 8
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private set { } //Length: 19
	}

	internal MaskSize renderingLayersMaskSize
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		internal get { } //Length: 7
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		internal set { } //Length: 7
	}

	internal List<ShaderTagId> shaderTagIds
	{
		[CallerCount(Count = 17)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		internal get { } //Length: 8
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		internal set { } //Length: 19
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ShaderTagId), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Shader), Member = "PropertyToID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	private static DepthNormalOnlyPass() { }

	[CalledBy(Type = typeof(UniversalRenderer), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UniversalRendererData)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ScriptableRenderPass), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(ScriptableRenderPass), Member = "set_profilingSampler", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ProfilingSampler)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Nullable`1<UnityEngine.Rendering.RenderQueueRange>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderQueueRange)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FilteringSettings), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Nullable`1<UnityEngine.Rendering.RenderQueueRange>), typeof(int), typeof(uint), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	public DepthNormalOnlyPass(RenderPassEvent evt, RenderQueueRange renderQueueRange, LayerMask layerMask) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ContextContainer), Member = "Get", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(DepthNormalOnlyPass), Member = "InitRendererListParams", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UniversalRenderingData), typeof(UniversalCameraData), typeof(UniversalLightData)}, ReturnType = typeof(RendererListParams))]
	[Calls(Type = typeof(ScriptableRenderContext), Member = "CreateRendererList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RendererListParams&)}, ReturnType = typeof(RendererList))]
	[Calls(Type = typeof(RenderingData), Member = "get_commandBuffer", ReturnType = typeof(CommandBuffer&))]
	[Calls(Type = typeof(ScriptableRenderPass), Member = "get_profilingSampler", ReturnType = typeof(ProfilingSampler))]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 7)]
	[Obsolete("This rendering path is for compatibility mode only (when Render Graph is disabled). Use Render Graph API instead.", False)]
	public virtual void Execute(ScriptableRenderContext context, ref RenderingData renderingData) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	private static void ExecutePass(RasterCommandBuffer cmd, PassData passData, RendererList rendererList) { }

	[CallerCount(Count = 2)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private RTHandle get_depthHandle() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	internal bool get_enableRenderingLayers() { }

	[CallerCount(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private RTHandle get_normalHandle() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private RTHandle get_renderingLayersHandle() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	internal MaskSize get_renderingLayersMaskSize() { }

	[CallerCount(Count = 17)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	internal List<ShaderTagId> get_shaderTagIds() { }

	[CalledBy(Type = typeof(UniversalRenderer), Member = "Setup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), typeof(RenderingData&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalRenderer), Member = "CreateCameraNormalsTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(RenderTextureDescriptor)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DeferredLights), Member = "GetGBufferFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(GraphicsFormat))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(SystemInfo), Member = "IsFormatSupported", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GraphicsFormat), typeof(GraphicsFormatUsage)}, ReturnType = typeof(bool))]
	public static GraphicsFormat GetGraphicsFormat() { }

	[CalledBy(Type = typeof(DepthNormalOnlyPass), Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), typeof(RenderingData&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DepthNormalOnlyPass), Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(ContextContainer), typeof(TextureHandle), typeof(TextureHandle), typeof(TextureHandle), typeof(uint), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(RenderingUtils), Member = "CreateDrawingSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.Rendering.ShaderTagId>), typeof(UniversalRenderingData), typeof(UniversalCameraData), typeof(UniversalLightData), typeof(SortingCriteria)}, ReturnType = typeof(DrawingSettings))]
	[Calls(Type = typeof(RendererListParams), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CullingResults), typeof(DrawingSettings), typeof(FilteringSettings)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private RendererListParams InitRendererListParams(UniversalRenderingData renderingData, UniversalCameraData cameraData, UniversalLightData lightData) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 8)]
	public virtual void OnCameraCleanup(CommandBuffer cmd) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CameraData), Member = "get_renderer", ReturnType = typeof(ScriptableRenderer&))]
	[Calls(Type = typeof(CameraData), Member = "get_renderType", ReturnType = typeof(CameraRenderType&))]
	[Calls(Type = typeof(CameraData), Member = "get_clearDepth", ReturnType = typeof(Boolean&))]
	[Calls(Type = typeof(ScriptableRenderer), Member = "get_cameraDepthTargetHandle", ReturnType = typeof(RTHandle))]
	[Calls(Type = typeof(ScriptableRenderPass), Member = "ConfigureTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RTHandle[]), typeof(RTHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ScriptableRenderPass), Member = "ConfigureClear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ClearFlag), typeof(Color)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 14)]
	[Obsolete("This rendering path is for compatibility mode only (when Render Graph is disabled). Use Render Graph API instead.", False)]
	public virtual void OnCameraSetup(CommandBuffer cmd, ref RenderingData renderingData) { }

	[CalledBy(Type = typeof(UniversalRenderer), Member = "DepthNormalPrepassRender", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), "UnityEngine.Rendering.Universal.UniversalRenderer+RenderPassInputSummary", typeof(TextureHandle), typeof(uint), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ContextContainer), Member = "Get", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(ScriptableRenderPass), Member = "get_profilingSampler", ReturnType = typeof(ProfilingSampler))]
	[Calls(Type = typeof(RenderGraph), Member = "AddRasterRenderPass", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"PassData"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "PassData&", typeof(ProfilingSampler), typeof(string), typeof(int)}, ReturnType = typeof(IRasterRenderGraphBuilder))]
	[Calls(Type = typeof(DepthNormalOnlyPass), Member = "InitRendererListParams", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UniversalRenderingData), typeof(UniversalCameraData), typeof(UniversalLightData)}, ReturnType = typeof(RendererListParams))]
	[Calls(Type = typeof(RenderGraph), Member = "CreateRendererList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RendererListParams&)}, ReturnType = typeof(RendererListHandle))]
	[Calls(Type = typeof(XRPass), Member = "get_enabled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(XRPass), Member = "get_supportsFoveatedRendering", ReturnType = typeof(bool))]
	[Calls(Type = typeof(UniversalCameraData), Member = "get_xrUniversal", ReturnType = typeof(XRPassUniversal))]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 41)]
	[ContainsUnimplementedInstructions]
	internal void Render(RenderGraph renderGraph, ContextContainer frameData, TextureHandle cameraNormalsTexture, TextureHandle cameraDepthTexture, TextureHandle renderingLayersTexture, uint batchLayerMask, bool setGlobalDepth, bool setGlobalTextures) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void set_depthHandle(RTHandle value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	internal void set_enableRenderingLayers(bool value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void set_normalHandle(RTHandle value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void set_renderingLayersHandle(RTHandle value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	internal void set_renderingLayersMaskSize(MaskSize value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	internal void set_shaderTagIds(List<ShaderTagId> value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public void Setup(RTHandle depthHandle, RTHandle normalHandle) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 3)]
	public void Setup(RTHandle depthHandle, RTHandle normalHandle, RTHandle decalLayerHandle) { }

}

