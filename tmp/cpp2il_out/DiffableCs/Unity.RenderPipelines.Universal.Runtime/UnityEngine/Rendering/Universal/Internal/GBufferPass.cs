namespace UnityEngine.Rendering.Universal.Internal;

internal class GBufferPass : ScriptableRenderPass
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static BaseRenderFunc<PassData, RasterGraphContext> <>9__21_0; //Field offset: 0x8

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		private static <>c() { }

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(RendererListHandle), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RendererListHandle)}, ReturnType = typeof(RendererList))]
		[Calls(Type = typeof(DeferredLights), Member = "get_UseRenderingLayers", ReturnType = typeof(bool))]
		[Calls(Type = typeof(DeferredLights), Member = "ClearStencilPartial", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RasterCommandBuffer)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		internal void <Render>b__21_0(PassData data, RasterGraphContext context) { }

	}

	private class PassData
	{
		internal TextureHandle[] gbuffer; //Field offset: 0x10
		internal TextureHandle depth; //Field offset: 0x18
		internal DeferredLights deferredLights; //Field offset: 0x28
		internal RendererListHandle rendererListHdl; //Field offset: 0x30
		internal RendererListHandle objectsWithErrorRendererListHdl; //Field offset: 0x3C
		internal RendererList rendererList; //Field offset: 0x48
		internal RendererList objectsWithErrorRendererList; //Field offset: 0x60

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public PassData() { }

	}

	private static readonly int s_CameraNormalsTextureID; //Field offset: 0x0
	private static readonly int s_CameraRenderingLayersTextureID; //Field offset: 0x4
	private static readonly ShaderTagId s_ShaderTagLit; //Field offset: 0x8
	private static readonly ShaderTagId s_ShaderTagSimpleLit; //Field offset: 0xC
	private static readonly ShaderTagId s_ShaderTagUnlit; //Field offset: 0x10
	private static readonly ShaderTagId s_ShaderTagComplexLit; //Field offset: 0x14
	private static readonly ShaderTagId s_ShaderTagUniversalGBuffer; //Field offset: 0x18
	private static readonly ShaderTagId s_ShaderTagUniversalMaterialType; //Field offset: 0x1C
	private static ShaderTagId[] s_ShaderTagValues; //Field offset: 0x20
	private static RenderStateBlock[] s_RenderStateBlocks; //Field offset: 0x28
	private DeferredLights m_DeferredLights; //Field offset: 0xB8
	private FilteringSettings m_FilteringSettings; //Field offset: 0xC0
	private RenderStateBlock m_RenderStateBlock; //Field offset: 0xE0
	private PassData m_PassData; //Field offset: 0x150

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Shader), Member = "PropertyToID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ShaderTagId), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	private static GBufferPass() { }

	[CalledBy(Type = typeof(UniversalRenderer), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UniversalRendererData)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ScriptableRenderPass), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(ProfilingSampler), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ScriptableRenderPass), Member = "set_profilingSampler", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ProfilingSampler)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Nullable`1<UnityEngine.Rendering.RenderQueueRange>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderQueueRange)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FilteringSettings), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Nullable`1<UnityEngine.Rendering.RenderQueueRange>), typeof(int), typeof(uint), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderStateBlock), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderStateMask)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderStateBlock), Member = "set_stencilState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StencilState)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DeferredLights), Member = "OverwriteStencil", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderStateBlock), typeof(int), typeof(int)}, ReturnType = typeof(RenderStateBlock))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 6)]
	public GBufferPass(RenderPassEvent evt, RenderQueueRange renderQueueRange, LayerMask layerMask, StencilState stencilState, int stencilReference, DeferredLights deferredLights) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DeferredLights), Member = "get_GbufferDepthIndex", ReturnType = typeof(int))]
	[Calls(Type = typeof(DeferredLights), Member = "ReAllocateGBufferIfNeeded", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTextureDescriptor), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CommandBuffer), Member = "SetGlobalTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(RenderTargetIdentifier)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DeferredLights), Member = "UpdateDeferredInputAttachments", ReturnType = typeof(void))]
	[Calls(Type = typeof(ScriptableRenderPass), Member = "ConfigureTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RTHandle[]), typeof(RTHandle), typeof(GraphicsFormat[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ScriptableRenderPass), Member = "ConfigureClear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ClearFlag), typeof(Color)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 6)]
	[Obsolete("This rendering path is for compatibility mode only (when Render Graph is disabled). Use Render Graph API instead.", False)]
	public virtual void Configure(CommandBuffer cmd, RenderTextureDescriptor cameraTextureDescriptor) { }

	[CalledBy(Type = typeof(UniversalRenderer), Member = "Dispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalRenderer), Member = "ReleaseRenderTargets", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(DeferredLights), Member = "ReleaseGbufferResources", ReturnType = typeof(void))]
	public void Dispose() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ContextContainer), Member = "Get", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(GBufferPass), Member = "InitRendererLists", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PassData&), typeof(ScriptableRenderContext), typeof(RenderGraph), typeof(UniversalRenderingData), typeof(UniversalCameraData), typeof(UniversalLightData), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderingData), Member = "get_commandBuffer", ReturnType = typeof(CommandBuffer&))]
	[Calls(Type = typeof(ScriptableRenderPass), Member = "get_profilingSampler", ReturnType = typeof(ProfilingSampler))]
	[Calls(Type = typeof(DeferredLights), Member = "get_UseRenderingLayers", ReturnType = typeof(bool))]
	[Calls(Type = typeof(DeferredLights), Member = "ClearStencilPartial", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RasterCommandBuffer)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RTHandle), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RTHandle)}, ReturnType = typeof(RenderTargetIdentifier))]
	[Calls(Type = typeof(CommandBuffer), Member = "SetGlobalTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(RenderTargetIdentifier)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 15)]
	[ContainsUnimplementedInstructions]
	[Obsolete("This rendering path is for compatibility mode only (when Render Graph is disabled). Use Render Graph API instead.", False)]
	public virtual void Execute(ScriptableRenderContext context, ref RenderingData renderingData) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DeferredLights), Member = "get_UseRenderingLayers", ReturnType = typeof(bool))]
	[Calls(Type = typeof(DeferredLights), Member = "ClearStencilPartial", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RasterCommandBuffer)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private static void ExecutePass(RasterCommandBuffer cmd, PassData data, RendererList rendererList, RendererList errorRendererList) { }

	[CalledBy(Type = typeof(GBufferPass), Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), typeof(RenderingData&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GBufferPass), Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(ContextContainer), typeof(TextureHandle), typeof(TextureHandle), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ScriptableRenderPass), Member = "CreateDrawingSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ShaderTagId), typeof(UniversalRenderingData), typeof(UniversalCameraData), typeof(UniversalLightData), typeof(SortingCriteria)}, ReturnType = typeof(DrawingSettings))]
	[Calls(Type = typeof(NativeArray`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]", typeof(Allocator)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RendererListParams), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CullingResults), typeof(DrawingSettings), typeof(FilteringSettings)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Nullable`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ScriptableRenderContext), Member = "CreateRendererList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RendererListParams&)}, ReturnType = typeof(RendererList))]
	[Calls(Type = typeof(RenderGraph), Member = "CreateRendererList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RendererListParams&)}, ReturnType = typeof(RendererListHandle))]
	[Calls(Type = typeof(NativeArray`1), Member = "Dispose", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	private void InitRendererLists(ref PassData passData, ScriptableRenderContext context, RenderGraph renderGraph, UniversalRenderingData renderingData, UniversalCameraData cameraData, UniversalLightData lightData, bool useRenderGraph) { }

	[CalledBy(Type = typeof(UniversalRenderer), Member = "OnMainRendering", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(ScriptableRenderContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GBufferPass), Member = "InitRendererLists", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PassData&), typeof(ScriptableRenderContext), typeof(RenderGraph), typeof(UniversalRenderingData), typeof(UniversalCameraData), typeof(UniversalLightData), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UniversalResourceData), Member = "set_gBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextureHandle[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderGraphUtils), Member = "UseDBufferIfValid", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IRasterRenderGraphBuilder), typeof(UniversalResourceData)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UniversalResourceData), Member = "get_renderingLayersTexture", ReturnType = typeof(TextureHandle))]
	[Calls(Type = typeof(UniversalRenderer), Member = "CreateRenderGraphTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(RenderTextureDescriptor), typeof(string), typeof(bool), typeof(FilterMode), typeof(TextureWrapMode)}, ReturnType = typeof(TextureHandle))]
	[Calls(Type = typeof(RenderTextureDescriptor), Member = "set_graphicsFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GraphicsFormat)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DeferredLights), Member = "GetGBufferFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(GraphicsFormat))]
	[Calls(Type = typeof(DeferredLights), Member = "get_GBufferRenderingLayers", ReturnType = typeof(int))]
	[Calls(Type = typeof(UniversalResourceData), Member = "get_cameraNormalsTexture", ReturnType = typeof(TextureHandle))]
	[Calls(Type = typeof(DeferredLights), Member = "get_GBufferSliceCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(RenderGraph), Member = "AddRasterRenderPass", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"PassData"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "PassData&", typeof(ProfilingSampler), typeof(string), typeof(int)}, ReturnType = typeof(IRasterRenderGraphBuilder))]
	[Calls(Type = typeof(ScriptableRenderPass), Member = "get_profilingSampler", ReturnType = typeof(ProfilingSampler))]
	[Calls(Type = typeof(DeferredLights), Member = "get_UseLightLayers", ReturnType = typeof(bool))]
	[Calls(Type = typeof(DeferredLights), Member = "get_UseRenderingLayers", ReturnType = typeof(bool))]
	[Calls(Type = typeof(ContextContainer), Member = "Get", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 53)]
	internal void Render(RenderGraph renderGraph, ContextContainer frameData, TextureHandle cameraColor, TextureHandle cameraDepth, bool setGlobalTextures) { }

}

