namespace UnityEngine.Rendering.Universal.Internal;

public class DrawObjectsPass : ScriptableRenderPass
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static BaseRenderFunc<PassData, RasterGraphContext> <>9__17_0; //Field offset: 0x8

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		private static <>c() { }

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(TransparentSettingsPass), Member = "ExecutePass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RasterCommandBuffer)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(TextureHandle), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextureHandle)}, ReturnType = typeof(RTHandle))]
		[Calls(Type = typeof(UniversalCameraData), Member = "IsRenderTargetProjectionMatrixFlipped", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RTHandle), typeof(RTHandle)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(RendererListHandle), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RendererListHandle)}, ReturnType = typeof(RendererList))]
		[Calls(Type = typeof(DrawObjectsPass), Member = "ExecutePass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RasterCommandBuffer), typeof(PassData), typeof(RendererList), typeof(RendererList), typeof(bool)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		internal void <Render>b__17_0(PassData data, RasterGraphContext context) { }

	}

	public class PassData
	{
		internal TextureHandle albedoHdl; //Field offset: 0x10
		internal TextureHandle depthHdl; //Field offset: 0x20
		internal UniversalCameraData cameraData; //Field offset: 0x30
		internal bool isOpaque; //Field offset: 0x38
		internal bool shouldTransparentsReceiveShadows; //Field offset: 0x39
		internal uint batchLayerMask; //Field offset: 0x3C
		internal bool isActiveTargetBackBuffer; //Field offset: 0x40
		internal RendererListHandle rendererListHdl; //Field offset: 0x44
		internal RendererListHandle objectsWithErrorRendererListHdl; //Field offset: 0x50
		internal DebugRendererLists debugRendererLists; //Field offset: 0x60
		internal RendererList rendererList; //Field offset: 0x68
		internal RendererList objectsWithErrorRendererList; //Field offset: 0x80

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public PassData() { }

	}

	private static readonly int s_DrawObjectPassDataPropID; //Field offset: 0x0
	private FilteringSettings m_FilteringSettings; //Field offset: 0xB8
	private RenderStateBlock m_RenderStateBlock; //Field offset: 0xD8
	private List<ShaderTagId> m_ShaderTagIdList; //Field offset: 0x148
	private bool m_IsOpaque; //Field offset: 0x150
	public bool m_IsActiveTargetBackBuffer; //Field offset: 0x151
	public bool m_ShouldTransparentsReceiveShadows; //Field offset: 0x152
	private PassData m_PassData; //Field offset: 0x158

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Shader), Member = "PropertyToID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	private static DrawObjectsPass() { }

	[CalledBy(Type = typeof(UniversalRenderer), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UniversalRendererData)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ScriptableRenderPass), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(DrawObjectsPass), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(RenderPassEvent), typeof(RenderQueueRange), typeof(LayerMask), typeof(StencilState), typeof(int), typeof(ShaderTagId[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ProfilingSampler), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ScriptableRenderPass), Member = "set_profilingSampler", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ProfilingSampler)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public DrawObjectsPass(string profilerTag, ShaderTagId[] shaderTagIds, bool opaque, RenderPassEvent evt, RenderQueueRange renderQueueRange, LayerMask layerMask, StencilState stencilState, int stencilReference) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ScriptableRenderPass), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(DrawObjectsPass), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(RenderPassEvent), typeof(RenderQueueRange), typeof(LayerMask), typeof(StencilState), typeof(int), typeof(ShaderTagId[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ProfilingSampler), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ScriptableRenderPass), Member = "set_profilingSampler", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ProfilingSampler)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public DrawObjectsPass(string profilerTag, bool opaque, RenderPassEvent evt, RenderQueueRange renderQueueRange, LayerMask layerMask, StencilState stencilState, int stencilReference) { }

	[CalledBy(Type = typeof(UniversalRenderer), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UniversalRendererData)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ScriptableRenderPass), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(DrawObjectsPass), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(RenderPassEvent), typeof(RenderQueueRange), typeof(LayerMask), typeof(StencilState), typeof(int), typeof(ShaderTagId[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ScriptableRenderPass), Member = "set_profilingSampler", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ProfilingSampler)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	internal DrawObjectsPass(URPProfileId profileId, bool opaque, RenderPassEvent evt, RenderQueueRange renderQueueRange, LayerMask layerMask, StencilState stencilState, int stencilReference) { }

	[CalledBy(Type = typeof(DrawObjectsWithRenderingLayersPass), Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), typeof(RenderingData&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ContextContainer), Member = "Get", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(DrawObjectsPass), Member = "InitRendererLists", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UniversalRenderingData), typeof(UniversalCameraData), typeof(UniversalLightData), typeof(PassData&), typeof(ScriptableRenderContext), typeof(RenderGraph), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderingData), Member = "get_commandBuffer", ReturnType = typeof(CommandBuffer&))]
	[Calls(Type = typeof(ScriptableRenderPass), Member = "get_profilingSampler", ReturnType = typeof(ProfilingSampler))]
	[Calls(Type = typeof(UniversalCameraData), Member = "IsCameraProjectionMatrixFlipped", ReturnType = typeof(bool))]
	[Calls(Type = typeof(DrawObjectsPass), Member = "ExecutePass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RasterCommandBuffer), typeof(PassData), typeof(RendererList), typeof(RendererList), typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 6)]
	[Obsolete("This rendering path is for compatibility mode only (when Render Graph is disabled). Use Render Graph API instead.", False)]
	public virtual void Execute(ScriptableRenderContext context, ref RenderingData renderingData) { }

	[CalledBy(Type = typeof(<>c), Member = "<Render>b__17_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PassData), typeof(RasterGraphContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DrawObjectsPass), Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), typeof(RenderingData&)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.Internal.DrawObjectsWithRenderingLayersPass+<>c", Member = "<Render>b__7_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.Internal.DrawObjectsWithRenderingLayersPass+RenderingLayersPassData", typeof(RasterGraphContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(XRPass), Member = "get_enabled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(XRPass), Member = "GetViewport", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Rect))]
	[Calls(Type = typeof(ScriptableRenderPass), Member = "GetActiveDebugHandler", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UniversalCameraData)}, ReturnType = typeof(DebugHandler))]
	[Calls(Type = typeof(DebugRendererLists), Member = "DrawWithRendererList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RasterCommandBuffer)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 1)]
	internal static void ExecutePass(RasterCommandBuffer cmd, PassData data, RendererList rendererList, RendererList objectsWithErrorRendererList, bool yFlip) { }

	[CalledBy(Type = typeof(DrawObjectsPass), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(ShaderTagId[]), typeof(bool), typeof(RenderPassEvent), typeof(RenderQueueRange), typeof(LayerMask), typeof(StencilState), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DrawObjectsPass), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool), typeof(RenderPassEvent), typeof(RenderQueueRange), typeof(LayerMask), typeof(StencilState), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DrawObjectsPass), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(URPProfileId), typeof(bool), typeof(RenderPassEvent), typeof(RenderQueueRange), typeof(LayerMask), typeof(StencilState), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DrawObjectsWithRenderingLayersPass), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(URPProfileId), typeof(bool), typeof(RenderPassEvent), typeof(RenderQueueRange), typeof(LayerMask), typeof(StencilState), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(ShaderTagId), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Nullable`1<UnityEngine.Rendering.RenderQueueRange>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderQueueRange)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FilteringSettings), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Nullable`1<UnityEngine.Rendering.RenderQueueRange>), typeof(int), typeof(uint), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderStateBlock), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderStateMask)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StencilState), Member = "get_enabled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(RenderStateBlock), Member = "set_stencilState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StencilState)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 5)]
	internal void Init(bool opaque, RenderPassEvent evt, RenderQueueRange renderQueueRange, LayerMask layerMask, StencilState stencilState, int stencilReference, ShaderTagId[] shaderTagIds = null) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	internal void InitPassData(UniversalCameraData cameraData, ref PassData passData, uint batchLayerMask, bool isActiveTargetBackBuffer = false) { }

	[CalledBy(Type = typeof(DrawObjectsPass), Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), typeof(RenderingData&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DrawObjectsPass), Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(ContextContainer), typeof(TextureHandle), typeof(TextureHandle), typeof(TextureHandle), typeof(TextureHandle), typeof(uint)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DrawObjectsWithRenderingLayersPass), Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(ContextContainer), typeof(TextureHandle), typeof(TextureHandle), typeof(TextureHandle), typeof(TextureHandle), typeof(TextureHandle), typeof(MaskSize), typeof(uint)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(RenderingUtils), Member = "CreateDrawingSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.Rendering.ShaderTagId>), typeof(UniversalRenderingData), typeof(UniversalCameraData), typeof(UniversalLightData), typeof(SortingCriteria)}, ReturnType = typeof(DrawingSettings))]
	[Calls(Type = typeof(RenderStateBlock), Member = "get_depthState", ReturnType = typeof(DepthState))]
	[Calls(Type = typeof(DepthState), Member = "get_compareFunction", ReturnType = typeof(CompareFunction))]
	[Calls(Type = typeof(DepthState), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(CompareFunction)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ScriptableRenderPass), Member = "GetActiveDebugHandler", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UniversalCameraData)}, ReturnType = typeof(DebugHandler))]
	[Calls(Type = typeof(RenderingUtils), Member = "CreateRendererListWithRenderStateBlock", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), typeof(CullingResults&), typeof(DrawingSettings), typeof(FilteringSettings), typeof(RenderStateBlock), typeof(RendererList&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DebugHandler), Member = "CreateRendererListsWithDebugRenderState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), typeof(CullingResults&), typeof(DrawingSettings&), typeof(FilteringSettings&), typeof(RenderStateBlock&)}, ReturnType = typeof(DebugRendererLists))]
	[Calls(Type = typeof(RenderingUtils), Member = "CreateRendererListWithRenderStateBlock", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(CullingResults&), typeof(DrawingSettings), typeof(FilteringSettings), typeof(RenderStateBlock), typeof(RendererListHandle&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DebugHandler), Member = "CreateRendererListsWithDebugRenderState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(CullingResults&), typeof(DrawingSettings&), typeof(FilteringSettings&), typeof(RenderStateBlock&)}, ReturnType = typeof(DebugRendererLists))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 3)]
	internal void InitRendererLists(UniversalRenderingData renderingData, UniversalCameraData cameraData, UniversalLightData lightData, ref PassData passData, ScriptableRenderContext context, RenderGraph renderGraph, bool useRenderGraph) { }

	[CalledBy(Type = typeof(UniversalRenderer), Member = "OnOffscreenDepthTextureRendering", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(ScriptableRenderContext), typeof(UniversalResourceData), typeof(UniversalCameraData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalRenderer), Member = "OnMainRendering", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(ScriptableRenderContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(XRPass), Member = "get_supportsFoveatedRendering", ReturnType = typeof(bool))]
	[Calls(Type = typeof(UniversalCameraData), Member = "get_xrUniversal", ReturnType = typeof(XRPassUniversal))]
	[Calls(Type = typeof(XRPass), Member = "get_enabled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(DebugRendererLists), Member = "PrepareRendererListForRasterPass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IRasterRenderGraphBuilder)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ScriptableRenderPass), Member = "GetActiveDebugHandler", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UniversalCameraData)}, ReturnType = typeof(DebugHandler))]
	[Calls(Type = typeof(DrawObjectsPass), Member = "InitRendererLists", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UniversalRenderingData), typeof(UniversalCameraData), typeof(UniversalLightData), typeof(PassData&), typeof(ScriptableRenderContext), typeof(RenderGraph), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderGraphUtils), Member = "UseDBufferIfValid", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IRasterRenderGraphBuilder), typeof(UniversalResourceData)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UniversalResourceData), Member = "get_ssaoTexture", ReturnType = typeof(TextureHandle))]
	[Calls(Type = typeof(UniversalResourceData), Member = "get_isActiveTargetBackBuffer", ReturnType = typeof(bool))]
	[Calls(Type = typeof(RenderGraph), Member = "AddRasterRenderPass", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"PassData"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "PassData&", typeof(ProfilingSampler), typeof(string), typeof(int)}, ReturnType = typeof(IRasterRenderGraphBuilder))]
	[Calls(Type = typeof(ScriptableRenderPass), Member = "get_profilingSampler", ReturnType = typeof(ProfilingSampler))]
	[Calls(Type = typeof(ContextContainer), Member = "Get", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 52)]
	internal void Render(RenderGraph renderGraph, ContextContainer frameData, TextureHandle colorTarget, TextureHandle depthTarget, TextureHandle mainShadowsTexture, TextureHandle additionalShadowsTexture, uint batchLayerMask = 4294967295) { }

}

