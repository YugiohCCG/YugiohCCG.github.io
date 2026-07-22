namespace UnityEngine.Rendering.Universal;

public sealed class UniversalRenderer : ScriptableRenderer
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Predicate<ScriptableRenderPass> <>9__115_0; //Field offset: 0x8
		public static Predicate<ScriptableRenderPass> <>9__115_1; //Field offset: 0x10
		public static BaseRenderFunc<CopyToDebugTexturePassData, RasterGraphContext> <>9__144_0; //Field offset: 0x18
		public static Predicate<ScriptableRenderPass> <>9__200_0; //Field offset: 0x20

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		private static <>c() { }

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(TextureHandle), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextureHandle)}, ReturnType = typeof(RTHandle))]
		[Calls(Type = typeof(Blitter), Member = "BlitTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RasterCommandBuffer), typeof(RTHandle), typeof(Vector4), typeof(float), typeof(bool)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		internal void <BlitEmptyTexture>b__144_0(CopyToDebugTexturePassData data, RasterGraphContext context) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		internal bool <OnAfterRendering>b__200_0(ScriptableRenderPass x) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		internal bool <Setup>b__115_0(ScriptableRenderPass x) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		internal bool <Setup>b__115_1(ScriptableRenderPass x) { }

	}

	private enum ColorCopySchedule
	{
		AfterSkybox = 0,
		None = 1,
	}

	private class CopyToDebugTexturePassData
	{
		internal TextureHandle src; //Field offset: 0x10
		internal TextureHandle dest; //Field offset: 0x20

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public CopyToDebugTexturePassData() { }

	}

	private enum DepthCopySchedule
	{
		DuringPrepass = 0,
		AfterPrepass = 1,
		AfterGBuffer = 2,
		AfterOpaques = 3,
		AfterSkybox = 4,
		AfterTransparents = 5,
		None = 6,
	}

	private static class Profiling
	{
		private const string k_Name = "UniversalRenderer"; //Field offset: 0x0
		public static readonly ProfilingSampler createCameraRenderTarget; //Field offset: 0x0

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ProfilingSampler), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		private static Profiling() { }

	}

	private struct RenderPassInputSummary
	{
		internal bool requiresDepthTexture; //Field offset: 0x0
		internal bool requiresDepthPrepass; //Field offset: 0x1
		internal bool requiresNormalsTexture; //Field offset: 0x2
		internal bool requiresColorTexture; //Field offset: 0x3
		internal bool requiresColorTextureCreated; //Field offset: 0x4
		internal bool requiresMotionVectors; //Field offset: 0x5
		internal RenderPassEvent requiresDepthNormalAtEvent; //Field offset: 0x8
		internal RenderPassEvent requiresDepthTextureEarliestEvent; //Field offset: 0xC

	}

	private struct TextureCopySchedules
	{
		internal DepthCopySchedule depth; //Field offset: 0x0
		internal ColorCopySchedule color; //Field offset: 0x4

	}

	private const int k_FinalBlitPassQueueOffset = 1; //Field offset: 0x0
	private const int k_AfterFinalBlitPassQueueOffset = 2; //Field offset: 0x0
	private static readonly List<ShaderTagId> k_DepthNormalsOnly; //Field offset: 0x0
	private const string _CameraColorAfterPostProcessingName = "_CameraColorAfterPostProcessing"; //Field offset: 0x0
	private const string _CameraColorUpscaled = "_CameraColorUpscaled"; //Field offset: 0x0
	private const string _CameraDepthAttachmentName = "_CameraDepthAttachment"; //Field offset: 0x0
	private const string _SingleCameraTargetAttachmentName = "_CameraTargetAttachment"; //Field offset: 0x0
	private const string _CameraTargetAttachmentBName = "_CameraTargetAttachmentB"; //Field offset: 0x0
	private const string _CameraTargetAttachmentAName = "_CameraTargetAttachmentA"; //Field offset: 0x0
	private static RTHandle[] m_RenderGraphCameraColorHandles; //Field offset: 0x8
	private static RTHandle m_RenderGraphCameraDepthHandle; //Field offset: 0x10
	private static int m_CurrentColorHandle; //Field offset: 0x18
	private static RTHandle m_RenderGraphDebugTextureHandle; //Field offset: 0x20
	private static bool m_RequiresIntermediateAttachments; //Field offset: 0x28
	private bool m_Clustering; //Field offset: 0x148
	private DepthOnlyPass m_DepthPrepass; //Field offset: 0x150
	private DepthNormalOnlyPass m_DepthNormalPrepass; //Field offset: 0x158
	private CopyDepthPass m_PrimedDepthCopyPass; //Field offset: 0x160
	private MotionVectorRenderPass m_MotionVectorPass; //Field offset: 0x168
	private MainLightShadowCasterPass m_MainLightShadowCasterPass; //Field offset: 0x170
	private AdditionalLightsShadowCasterPass m_AdditionalLightsShadowCasterPass; //Field offset: 0x178
	private GBufferPass m_GBufferPass; //Field offset: 0x180
	private CopyDepthPass m_GBufferCopyDepthPass; //Field offset: 0x188
	private DeferredPass m_DeferredPass; //Field offset: 0x190
	private DrawObjectsPass m_RenderOpaqueForwardOnlyPass; //Field offset: 0x198
	private DrawObjectsPass m_RenderOpaqueForwardPass; //Field offset: 0x1A0
	private DrawObjectsWithRenderingLayersPass m_RenderOpaqueForwardWithRenderingLayersPass; //Field offset: 0x1A8
	private DrawSkyboxPass m_DrawSkyboxPass; //Field offset: 0x1B0
	private CopyDepthPass m_CopyDepthPass; //Field offset: 0x1B8
	private CopyColorPass m_CopyColorPass; //Field offset: 0x1C0
	private TransparentSettingsPass m_TransparentSettingsPass; //Field offset: 0x1C8
	private DrawObjectsPass m_RenderTransparentForwardPass; //Field offset: 0x1D0
	private InvokeOnRenderObjectCallbackPass m_OnRenderObjectCallbackPass; //Field offset: 0x1D8
	private FinalBlitPass m_FinalBlitPass; //Field offset: 0x1E0
	private CapturePass m_CapturePass; //Field offset: 0x1E8
	private XROcclusionMeshPass m_XROcclusionMeshPass; //Field offset: 0x1F0
	private CopyDepthPass m_XRCopyDepthPass; //Field offset: 0x1F8
	private XRDepthMotionPass m_XRDepthMotionPass; //Field offset: 0x200
	private DrawScreenSpaceUIPass m_DrawOffscreenUIPass; //Field offset: 0x208
	private DrawScreenSpaceUIPass m_DrawOverlayUIPass; //Field offset: 0x210
	private CopyColorPass m_HistoryRawColorCopyPass; //Field offset: 0x218
	private CopyDepthPass m_HistoryRawDepthCopyPass; //Field offset: 0x220
	internal RenderTargetBufferSystem m_ColorBufferSystem; //Field offset: 0x228
	internal RTHandle m_ActiveCameraColorAttachment; //Field offset: 0x230
	private RTHandle m_ColorFrontBuffer; //Field offset: 0x238
	internal RTHandle m_ActiveCameraDepthAttachment; //Field offset: 0x240
	internal RTHandle m_CameraDepthAttachment; //Field offset: 0x248
	internal RTHandle m_CameraDepthAttachment_D3d_11; //Field offset: 0x250
	private RTHandle m_TargetColorHandle; //Field offset: 0x258
	private RTHandle m_TargetDepthHandle; //Field offset: 0x260
	internal RTHandle m_DepthTexture; //Field offset: 0x268
	private RTHandle m_NormalsTexture; //Field offset: 0x270
	private RTHandle m_DecalLayersTexture; //Field offset: 0x278
	private RTHandle m_OpaqueColor; //Field offset: 0x280
	private RTHandle m_MotionVectorColor; //Field offset: 0x288
	private RTHandle m_MotionVectorDepth; //Field offset: 0x290
	private ForwardLights m_ForwardLights; //Field offset: 0x298
	private DeferredLights m_DeferredLights; //Field offset: 0x2A0
	private RenderingMode m_RenderingMode; //Field offset: 0x2A8
	private DepthPrimingMode m_DepthPrimingMode; //Field offset: 0x2AC
	private CopyDepthMode m_CopyDepthMode; //Field offset: 0x2B0
	private DepthFormat m_CameraDepthAttachmentFormat; //Field offset: 0x2B4
	private DepthFormat m_CameraDepthTextureFormat; //Field offset: 0x2B8
	private bool m_DepthPrimingRecommended; //Field offset: 0x2BC
	private StencilState m_DefaultStencilState; //Field offset: 0x2BD
	private LightCookieManager m_LightCookieManager; //Field offset: 0x2D0
	private IntermediateTextureMode m_IntermediateTextureMode; //Field offset: 0x2D8
	private bool m_VulkanEnablePreTransform; //Field offset: 0x2DC
	private Material m_BlitMaterial; //Field offset: 0x2E0
	private Material m_BlitHDRMaterial; //Field offset: 0x2E8
	private Material m_SamplingMaterial; //Field offset: 0x2F0
	private Material m_StencilDeferredMaterial; //Field offset: 0x2F8
	private Material m_CameraMotionVecMaterial; //Field offset: 0x300
	private PostProcessPasses m_PostProcessPasses; //Field offset: 0x308
	[CompilerGenerated]
	private LayerMask <opaqueLayerMask>k__BackingField; //Field offset: 0x348
	[CompilerGenerated]
	private LayerMask <transparentLayerMask>k__BackingField; //Field offset: 0x34C
	[CompilerGenerated]
	private bool <shadowTransparentReceive>k__BackingField; //Field offset: 0x350
	private Material m_DebugBlitMaterial; //Field offset: 0x358
	private bool m_RequiresRenderingLayer; //Field offset: 0x360
	private Event m_RenderingLayersEvent; //Field offset: 0x364
	private MaskSize m_RenderingLayersMaskSize; //Field offset: 0x368
	private bool m_RenderingLayerProvidesRenderObjectPass; //Field offset: 0x36C
	private bool m_RenderingLayerProvidesByDepthNormalPass; //Field offset: 0x36D
	private string m_RenderingLayersTextureName; //Field offset: 0x370
	private bool m_IssuedGPUOcclusionUnsupportedMsg; //Field offset: 0x378

	internal bool accurateGbufferNormals
	{
		[CalledBy(Type = typeof(DecalRendererFeature), Member = "GetTechnique", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderer)}, ReturnType = typeof(DecalTechnique))]
		[CalledBy(Type = typeof(DecalRendererFeature), Member = "RecreateSystemsIfNeeded", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderer), typeof(CameraData&)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(RenderingLayerUtils), Member = "RequireRenderingLayers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UniversalRenderer), typeof(System.Collections.Generic.List`1<UnityEngine.Rendering.Universal.ScriptableRendererFeature>), typeof(int), typeof(Event&), typeof(MaskSize&)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 3)]
		internal get { } //Length: 25
	}

	internal GraphicsFormat cameraDepthAttachmentFormat
	{
		[CallerCount(Count = 0)]
		internal get { } //Length: 90
	}

	internal GraphicsFormat cameraDepthTextureFormat
	{
		[CalledBy(Type = typeof(UniversalRenderer), Member = "Setup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), typeof(RenderingData&)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		internal get { } //Length: 90
	}

	internal RTHandle colorGradingLut
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		internal get { } //Length: 8
	}

	internal ColorGradingLutPass colorGradingLutPass
	{
		[CallerCount(Count = 0)]
		internal get { } //Length: 8
	}

	private RTHandle currentRenderGraphCameraColorHandle
	{
		[CalledBy(Type = typeof(UniversalRenderer), Member = "CreateRenderGraphCameraRenderTargets", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		private get { } //Length: 147
	}

	internal DeferredLights deferredLights
	{
		[CallerCount(Count = 0)]
		internal get { } //Length: 8
	}

	public DepthPrimingMode depthPrimingMode
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 7
		[CallerCount(Count = 0)]
		 set { } //Length: 7
	}

	internal PostProcessPass finalPostProcessPass
	{
		[CallerCount(Count = 0)]
		internal get { } //Length: 8
	}

	private RTHandle nextRenderGraphCameraColorHandle
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		private get { } //Length: 271
	}

	internal LayerMask opaqueLayerMask
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		internal get { } //Length: 7
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		internal set { } //Length: 7
	}

	internal PostProcessPass postProcessPass
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		internal get { } //Length: 8
	}

	internal RenderingMode renderingModeActual
	{
		[CallerCount(Count = 46)]
		[Calls(Type = typeof(GL), Member = "get_wireframe", ReturnType = typeof(bool))]
		[Calls(Type = typeof(DebugHandler), Member = "get_IsActiveModeUnsupportedForDeferred", ReturnType = typeof(bool))]
		[Calls(Type = typeof(DeferredLights), Member = "IsRuntimeSupportedThisFrame", ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 1)]
		internal get { } //Length: 128
	}

	internal RenderingMode renderingModeRequested
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		internal get { } //Length: 7
	}

	internal bool shadowTransparentReceive
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		internal get { } //Length: 8
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		internal set { } //Length: 7
	}

	public virtual bool supportsGPUOcclusion
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Debug), Member = "LogWarning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 152
	}

	internal virtual bool supportsNativeRenderPassRendergraphCompiler
	{
		[CallerCount(Count = 23)]
		[DeduplicatedMethod]
		internal get { } //Length: 3
	}

	internal LayerMask transparentLayerMask
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		internal get { } //Length: 7
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		internal set { } //Length: 7
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ShaderTagId), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	private static UniversalRenderer() { }

	[CalledBy(Type = typeof(UniversalRendererData), Member = "Create", ReturnType = typeof(ScriptableRenderer))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CopyDepthPass), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderPassEvent), typeof(Shader), typeof(bool), typeof(bool), typeof(bool), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DepthNormalOnlyPass), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderPassEvent), typeof(RenderQueueRange), typeof(LayerMask)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DeferredLights), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InitParams), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GBufferPass), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderPassEvent), typeof(RenderQueueRange), typeof(LayerMask), typeof(StencilState), typeof(int), typeof(DeferredLights)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DeferredLights), Member = "OverwriteStencil", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StencilState), typeof(int)}, ReturnType = typeof(StencilState))]
	[Calls(Type = typeof(ShaderTagId), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DeferredPass), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderPassEvent), typeof(DeferredLights)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DrawObjectsPass), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(ShaderTagId[]), typeof(bool), typeof(RenderPassEvent), typeof(RenderQueueRange), typeof(LayerMask), typeof(StencilState), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DrawObjectsPass), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(URPProfileId), typeof(bool), typeof(RenderPassEvent), typeof(RenderQueueRange), typeof(LayerMask), typeof(StencilState), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DrawObjectsWithRenderingLayersPass), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(URPProfileId), typeof(bool), typeof(RenderPassEvent), typeof(RenderQueueRange), typeof(LayerMask), typeof(StencilState), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderingUtils), Member = "MultisampleDepthResolveSupported", ReturnType = typeof(bool))]
	[Calls(Type = typeof(MotionVectorRenderPass), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderPassEvent), typeof(Material), typeof(LayerMask)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DrawSkyboxPass), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderPassEvent)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CopyColorPass), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderPassEvent), typeof(Material), typeof(Material), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TransparentSettingsPass), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderPassEvent), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderQueueRange), Member = "get_transparent", ReturnType = typeof(RenderQueueRange))]
	[Calls(Type = typeof(InvokeOnRenderObjectCallbackPass), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderPassEvent)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DrawScreenSpaceUIPass), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderPassEvent), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(PostProcessParams), Member = "Create", ReturnType = typeof(PostProcessParams))]
	[Calls(Type = typeof(SystemInfo), Member = "IsFormatSupported", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GraphicsFormat), typeof(GraphicsFormatUsage)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(SystemInfo), Member = "GetGraphicsFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DefaultFormat)}, ReturnType = typeof(GraphicsFormat))]
	[Calls(Type = typeof(PostProcessPasses), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PostProcessData), typeof(PostProcessParams&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CapturePass), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderPassEvent)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FinalBlitPass), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderPassEvent), typeof(Material), typeof(Material)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderTargetBufferSystem), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DepthOnlyPass), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderPassEvent), typeof(RenderQueueRange), typeof(LayerMask)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderQueueRange), Member = "get_opaque", ReturnType = typeof(RenderQueueRange))]
	[Calls(Type = typeof(XROcclusionMeshPass), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderPassEvent)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StencilState), Member = "SetPassOperation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StencilOp)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TextureXR), Member = "get_dimension", ReturnType = typeof(TextureDimension))]
	[Calls(Type = typeof(Blitter), Member = "GetBlitMaterial", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextureDimension), typeof(bool)}, ReturnType = typeof(Material))]
	[Calls(Type = typeof(ScriptableRenderer), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRendererData)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Lazy`1<System.Object>), Member = "get_Value", ReturnType = typeof(object))]
	[Calls(Type = typeof(GraphicsSettings), Member = "TryGetRenderPipelineSettings", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Func`2<UnityEngine.Experimental.Rendering.XRPassCreateInfo, System.Object>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XRSystem), Member = "Initialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Func`2<UnityEngine.Experimental.Rendering.XRPassCreateInfo, UnityEngine.Experimental.Rendering.XRPass>), typeof(Shader), typeof(Shader)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XRDepthMotionPass), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderPassEvent), typeof(Shader)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CoreUtils), Member = "CreateEngineMaterial", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Shader)}, ReturnType = typeof(Material))]
	[Calls(Type = typeof(StencilState), Member = "get_defaultValue", ReturnType = typeof(StencilState))]
	[Calls(Type = typeof(StencilState), Member = "set_enabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StencilState), Member = "SetCompareFunction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CompareFunction)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(LensFlareCommonSRP), Member = "Initialize", ReturnType = typeof(void))]
	[Calls(Type = typeof(GraphicsSettings), Member = "HasShaderDefine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BuiltinShaderDefine)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(StencilState), Member = "SetZFailOperation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StencilOp)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UniversalRenderPipeline), Member = "get_asset", ReturnType = typeof(UniversalRenderPipelineAsset))]
	[Calls(Type = typeof(Settings), Member = "Create", ReturnType = typeof(Settings))]
	[Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(UniversalRenderPipelineAsset), Member = "get_additionalLightsCookieFormat", ReturnType = typeof(GraphicsFormat))]
	[Calls(Type = typeof(UniversalRenderPipelineAsset), Member = "get_additionalLightsCookieResolution", ReturnType = typeof(Vector2Int))]
	[Calls(Type = typeof(LightCookieManager), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Settings&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ForwardLights), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InitParams)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UniversalRendererData), Member = "get_depthAttachmentFormat", ReturnType = typeof(DepthFormat))]
	[Calls(Type = typeof(UniversalRendererData), Member = "get_depthTextureFormat", ReturnType = typeof(DepthFormat))]
	[Calls(Type = typeof(MainLightShadowCasterPass), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderPassEvent)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AdditionalLightsShadowCasterPass), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderPassEvent)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StencilState), Member = "SetFailOperation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StencilOp)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 46)]
	[ContainsUnimplementedInstructions]
	public UniversalRenderer(UniversalRendererData data) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	internal static void <OnAfterRendering>g__MakeCompatible|200_1(ref TextureDesc desc) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	private bool AllowPartialDepthNormalsPrepass(bool isDeferred, RenderPassEvent requiresDepthNormalEvent) { }

	[CalledBy(Type = typeof(UniversalRenderer), Member = "BlitToDebugTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(TextureHandle), typeof(TextureHandle), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(RenderGraph), Member = "AddRasterRenderPass", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"PassData"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "PassData&", typeof(string), typeof(int)}, ReturnType = typeof(IRasterRenderGraphBuilder))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 15)]
	private void BlitEmptyTexture(RenderGraph renderGraph, TextureHandle destination, string passName = "Copy To Debug Texture") { }

	[CalledBy(Type = typeof(UniversalRenderer), Member = "SetupRenderGraphFinalPassDebug", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(ContextContainer)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalRenderer), Member = "SetupAfterPostRenderGraphFinalPassDebug", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(ContextContainer)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(UniversalRenderer), Member = "BlitEmptyTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(TextureHandle), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BlitMaterialParameters), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextureHandle), typeof(TextureHandle), typeof(Material), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderGraphUtils), Member = "AddBlitPass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(BlitMaterialParameters), typeof(string), typeof(string), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderGraphUtils), Member = "AddCopyPass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(TextureHandle), typeof(TextureHandle), typeof(string), typeof(string), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private void BlitToDebugTexture(RenderGraph renderGraph, TextureHandle source, TextureHandle destination, bool isSourceTextureColor = false) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	private DepthCopySchedule CalculateDepthCopySchedule(RenderPassEvent earliestDepthReadEvent, bool hasFullPrepass) { }

	[CalledBy(Type = typeof(UniversalRenderer), Member = "OnMainRendering", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(ScriptableRenderContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PostProcessPasses), Member = "get_isCreated", ReturnType = typeof(bool))]
	[Calls(Type = typeof(ContextContainer), Member = "Get", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(UniversalCameraData), Member = "get_isPreviewCamera", ReturnType = typeof(bool))]
	[Calls(Type = typeof(DebugHandler), Member = "IsActiveForCamera", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DebugHandler), Member = "TryGetFullscreenDebugMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DebugFullScreenMode&)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 2)]
	[ContainsInvalidInstructions]
	[ContainsUnimplementedInstructions]
	private TextureCopySchedules CalculateTextureCopySchedules(UniversalCameraData cameraData, RenderPassInputSummary renderPassInputs, bool isDeferred, bool requiresDepthPrepass, bool hasFullPrepass) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private Rect CalculateUVRect(UniversalCameraData cameraData, float width, float height) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private Rect CalculateUVRect(UniversalCameraData cameraData, int textureHeightPercent) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PostProcessPasses), Member = "get_isCreated", ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	private bool CameraHasPostProcessingWithDepth(UniversalCameraData cameraData) { }

	[CalledBy(Type = typeof(UniversalRenderer), Member = "IsDepthPrimingEnabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UniversalCameraData)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(UniversalRenderer), Member = "Setup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), typeof(RenderingData&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalRenderer), Member = "CreateRenderGraphCameraRenderTargets", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalRenderer), Member = "OnMainRendering", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(ScriptableRenderContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalRenderer), Member = "RequireDepthPrepass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UniversalCameraData), typeof(RenderPassInputSummary&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(RenderingUtils), Member = "SupportsRenderTextureFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTextureFormat)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private bool CanCopyDepth(UniversalCameraData cameraData) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RTHandle), Member = "Release", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	private void CleanupRenderGraphResources() { }

	[CalledBy(Type = typeof(UniversalRenderer), Member = "RecordCustomPassesWithDepthCopyAndMotion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(UniversalResourceData), typeof(RenderPassEvent), typeof(RenderPassEvent), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalRenderer), Member = "ExecuteScheduledDepthCopyWithMotion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(UniversalResourceData), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalRenderer), Member = "OnMainRendering", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(ScriptableRenderContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(UniversalResourceData), Member = "get_cameraDepthTexture", ReturnType = typeof(TextureHandle))]
	[Calls(Type = typeof(UniversalResourceData), Member = "get_activeDepthTexture", ReturnType = typeof(TextureHandle))]
	[Calls(Type = typeof(CopyDepthPass), Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(ContextContainer), typeof(TextureHandle), typeof(TextureHandle), typeof(bool), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private void CopyDepthToDepthTexture(RenderGraph renderGraph, UniversalResourceData resourceData) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	private void CorrectForTextureAspectRatio(ref float width, ref float height, float sourceWidth, float sourceHeight) { }

	[CalledBy(Type = typeof(UniversalRenderer), Member = "CreateRenderGraphCameraRenderTargets", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ContextContainer), Member = "Get", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(PostProcessPass), Member = "GetCompatibleDescriptor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTextureDescriptor), typeof(int), typeof(int), typeof(GraphicsFormat), typeof(GraphicsFormat)}, ReturnType = typeof(RenderTextureDescriptor))]
	[Calls(Type = typeof(TextureDesc), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderTextureDescriptor), Member = "get_bindMS", ReturnType = typeof(bool))]
	[Calls(Type = typeof(RenderTextureDescriptor), Member = "get_enableRandomWrite", ReturnType = typeof(bool))]
	[Calls(Type = typeof(RenderTextureDescriptor), Member = "get_useDynamicScale", ReturnType = typeof(bool))]
	[Calls(Type = typeof(RenderTextureDescriptor), Member = "get_useDynamicScaleExplicit", ReturnType = typeof(bool))]
	[Calls(Type = typeof(RenderGraph), Member = "CreateTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextureDesc&)}, ReturnType = typeof(TextureHandle))]
	[Calls(Type = typeof(UniversalResourceData), Member = "set_afterPostProcessColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextureHandle)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	private void CreateAfterPostProcessTexture(RenderGraph renderGraph, RenderTextureDescriptor descriptor) { }

	[CalledBy(Type = typeof(UniversalRenderer), Member = "CreateRenderGraphCameraRenderTargets", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ContextContainer), Member = "Get", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(RenderTextureDescriptor), Member = "set_graphicsFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GraphicsFormat)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TextureDesc), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderTextureDescriptor), Member = "get_bindMS", ReturnType = typeof(bool))]
	[Calls(Type = typeof(RenderTextureDescriptor), Member = "get_enableRandomWrite", ReturnType = typeof(bool))]
	[Calls(Type = typeof(RenderTextureDescriptor), Member = "get_useDynamicScale", ReturnType = typeof(bool))]
	[Calls(Type = typeof(RenderTextureDescriptor), Member = "get_useDynamicScaleExplicit", ReturnType = typeof(bool))]
	[Calls(Type = typeof(RenderGraph), Member = "CreateTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextureDesc&)}, ReturnType = typeof(TextureHandle))]
	[Calls(Type = typeof(UniversalResourceData), Member = "set_cameraDepthTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextureHandle)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	private void CreateCameraDepthCopyTexture(RenderGraph renderGraph, RenderTextureDescriptor descriptor, bool isDepthTexture) { }

	[CalledBy(Type = typeof(UniversalRenderer), Member = "CreateRenderGraphCameraRenderTargets", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TextureDesc), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ContextContainer), Member = "Get", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(UniversalRenderer), Member = "get_renderingModeActual", ReturnType = typeof(RenderingMode))]
	[Calls(Type = typeof(DepthNormalOnlyPass), Member = "GetGraphicsFormat", ReturnType = typeof(GraphicsFormat))]
	[Calls(Type = typeof(DeferredLights), Member = "GetGBufferFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(GraphicsFormat))]
	[Calls(Type = typeof(RenderTextureDescriptor), Member = "set_graphicsFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GraphicsFormat)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderTextureDescriptor), Member = "get_bindMS", ReturnType = typeof(bool))]
	[Calls(Type = typeof(RenderTextureDescriptor), Member = "get_enableRandomWrite", ReturnType = typeof(bool))]
	[Calls(Type = typeof(RenderTextureDescriptor), Member = "get_useDynamicScale", ReturnType = typeof(bool))]
	[Calls(Type = typeof(RenderTextureDescriptor), Member = "get_useDynamicScaleExplicit", ReturnType = typeof(bool))]
	[Calls(Type = typeof(RenderGraph), Member = "CreateTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextureDesc&)}, ReturnType = typeof(TextureHandle))]
	[Calls(Type = typeof(UniversalResourceData), Member = "set_cameraNormalsTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextureHandle)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	[ContainsUnimplementedInstructions]
	private void CreateCameraNormalsTexture(RenderGraph renderGraph, RenderTextureDescriptor descriptor) { }

	[CalledBy(Type = typeof(UniversalRenderer), Member = "Setup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), typeof(RenderingData&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(RenderTextureDescriptor), Member = "set_autoGenerateMips", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderingUtils), Member = "ReAllocateHandleIfNeeded", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RTHandle&), typeof(RenderTextureDescriptor&), typeof(FilterMode), typeof(TextureWrapMode), typeof(int), typeof(float), typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(RenderTextureDescriptor), Member = "set_graphicsFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GraphicsFormat)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderingUtils), Member = "MultisampleDepthResolveSupported", ReturnType = typeof(bool))]
	[Calls(Type = typeof(UniversalRenderer), Member = "IsDepthPrimingEnabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UniversalCameraData)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(RenderTextureDescriptor), Member = "set_bindMS", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderTextureDescriptor), Member = "set_useMipMap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CommandBuffer), Member = "SetGlobalTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(RenderTargetIdentifier)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderTargetBufferSystem), Member = "GetBackBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer)}, ReturnType = typeof(RTHandle))]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTargetIdentifier), typeof(RenderTargetIdentifier)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BuiltinRenderTextureType)}, ReturnType = typeof(RenderTargetIdentifier))]
	[Calls(Type = typeof(RenderTargetBufferSystem), Member = "PeekBackBuffer", ReturnType = typeof(RTHandle))]
	[Calls(Type = typeof(ScriptableRenderContext), Member = "ExecuteCommandBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CommandBuffer), Member = "Clear", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 16)]
	[ContainsUnimplementedInstructions]
	private void CreateCameraRenderTarget(ScriptableRenderContext context, ref RenderTextureDescriptor descriptor, CommandBuffer cmd, UniversalCameraData cameraData) { }

	[CalledBy(Type = typeof(UniversalRenderer), Member = "SetupRenderGraphFinalPassDebug", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(ContextContainer)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalRenderer), Member = "SetupAfterPostRenderGraphFinalPassDebug", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(ContextContainer)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(RenderTextureDescriptor), Member = "set_useMipMap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderTextureDescriptor), Member = "set_autoGenerateMips", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderTextureDescriptor), Member = "set_bindMS", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderingUtils), Member = "ReAllocateHandleIfNeeded", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RTHandle&), typeof(RenderTextureDescriptor&), typeof(FilterMode), typeof(TextureWrapMode), typeof(int), typeof(float), typeof(string)}, ReturnType = typeof(bool))]
	private void CreateDebugTexture(RenderTextureDescriptor descriptor) { }

	[CalledBy(Type = typeof(UniversalRenderer), Member = "CreateRenderGraphCameraRenderTargets", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ContextContainer), Member = "Get", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(RenderTextureDescriptor), Member = "set_graphicsFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GraphicsFormat)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TextureDesc), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderTextureDescriptor), Member = "get_bindMS", ReturnType = typeof(bool))]
	[Calls(Type = typeof(RenderTextureDescriptor), Member = "get_enableRandomWrite", ReturnType = typeof(bool))]
	[Calls(Type = typeof(RenderTextureDescriptor), Member = "get_useDynamicScale", ReturnType = typeof(bool))]
	[Calls(Type = typeof(RenderTextureDescriptor), Member = "get_useDynamicScaleExplicit", ReturnType = typeof(bool))]
	[Calls(Type = typeof(RenderGraph), Member = "CreateTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextureDesc&)}, ReturnType = typeof(TextureHandle))]
	[Calls(Type = typeof(UniversalResourceData), Member = "set_motionVectorColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextureHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UniversalResourceData), Member = "set_motionVectorDepth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextureHandle)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	[ContainsUnimplementedInstructions]
	private void CreateMotionVectorTextures(RenderGraph renderGraph, RenderTextureDescriptor descriptor) { }

	[CalledBy(Type = typeof(UniversalRenderer), Member = "OnRecordRenderGraph", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(ScriptableRenderContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Debug), Member = "LogWarning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Screen), Member = "get_height", ReturnType = typeof(int))]
	[Calls(Type = typeof(RenderGraph), Member = "ImportTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RTHandle), typeof(RenderTargetInfo), typeof(ImportResourceParams)}, ReturnType = typeof(TextureHandle))]
	[Calls(Type = typeof(UniversalResourceData), Member = "set_backBufferColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextureHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UniversalResourceData), Member = "set_backBufferDepth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextureHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderTextureDescriptor), Member = "set_useMipMap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderTextureDescriptor), Member = "set_autoGenerateMips", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TextureDesc), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderTextureDescriptor), Member = "get_bindMS", ReturnType = typeof(bool))]
	[Calls(Type = typeof(RenderTextureDescriptor), Member = "get_enableRandomWrite", ReturnType = typeof(bool))]
	[Calls(Type = typeof(RenderTextureDescriptor), Member = "get_useDynamicScale", ReturnType = typeof(bool))]
	[Calls(Type = typeof(RenderTextureDescriptor), Member = "get_useDynamicScaleExplicit", ReturnType = typeof(bool))]
	[Calls(Type = typeof(RenderGraph), Member = "CreateTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextureDesc&)}, ReturnType = typeof(TextureHandle))]
	[Calls(Type = typeof(UniversalRenderer), Member = "get_currentRenderGraphCameraColorHandle", ReturnType = typeof(RTHandle))]
	[Calls(Type = typeof(Screen), Member = "get_width", ReturnType = typeof(int))]
	[Calls(Type = typeof(RenderGraph), Member = "ImportTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RTHandle), typeof(ImportResourceParams)}, ReturnType = typeof(TextureHandle))]
	[Calls(Type = typeof(PostProcessPasses), Member = "get_isCreated", ReturnType = typeof(bool))]
	[Calls(Type = typeof(UniversalRenderer), Member = "IsDepthPrimingEnabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UniversalCameraData)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(UniversalRenderer), Member = "CanCopyDepth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UniversalCameraData)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(UniversalRenderer), Member = "get_renderingModeActual", ReturnType = typeof(RenderingMode))]
	[Calls(Type = typeof(RenderingUtils), Member = "MultisampleDepthResolveSupported", ReturnType = typeof(bool))]
	[Calls(Type = typeof(RenderTextureDescriptor), Member = "set_bindMS", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderTextureDescriptor), Member = "set_graphicsFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GraphicsFormat)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UniversalRenderer), Member = "CreateCameraDepthCopyTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(RenderTextureDescriptor), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UniversalRenderer), Member = "CreateCameraNormalsTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(RenderTextureDescriptor)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UniversalRenderer), Member = "CreateMotionVectorTextures", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(RenderTextureDescriptor)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderingUtils), Member = "ReAllocateHandleIfNeeded", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RTHandle&), typeof(RenderTextureDescriptor&), typeof(FilterMode), typeof(TextureWrapMode), typeof(int), typeof(float), typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ScriptableRenderer), Member = "AdjustAndGetScreenMSAASamples", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(bool)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(SystemInfo), Member = "GetGraphicsFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DefaultFormat)}, ReturnType = typeof(GraphicsFormat))]
	[Calls(Type = typeof(RTHandles), Member = "Alloc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTargetIdentifier), typeof(string)}, ReturnType = typeof(RTHandle))]
	[Calls(Type = typeof(ContextContainer), Member = "Get", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BuiltinRenderTextureType)}, ReturnType = typeof(RenderTargetIdentifier))]
	[Calls(Type = typeof(Camera), Member = "get_clearFlags", ReturnType = typeof(CameraClearFlags))]
	[Calls(Type = typeof(UniversalCameraData), Member = "get_isPreviewCamera", ReturnType = typeof(bool))]
	[Calls(Type = typeof(DebugHandler), Member = "IsActiveForCamera", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DebugHandler), Member = "get_IsScreenClearNeeded", ReturnType = typeof(bool))]
	[Calls(Type = typeof(DebugHandler), Member = "TryGetScreenClearColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(XRPass), Member = "get_enabled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTargetIdentifier), typeof(RenderTargetIdentifier)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(RTHandleStaticHelpers), Member = "SetRTHandleUserManagedWrapper", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RTHandle&), typeof(RenderTargetIdentifier)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UniversalRenderer), Member = "CreateAfterPostProcessTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(RenderTextureDescriptor)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UniversalRenderer), Member = "UpdateCameraHistory", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UniversalCameraData)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UniversalCameraData), Member = "IsTemporalAAEnabled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(UniversalCameraData), Member = "get_isSceneViewCamera", ReturnType = typeof(bool))]
	[Calls(Type = typeof(UniversalRenderer), Member = "GetRenderPassInputs", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(RenderPassInputSummary))]
	[Calls(Type = typeof(UniversalRenderer), Member = "RequiresIntermediateAttachments", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UniversalCameraData), typeof(RenderPassInputSummary&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(SupportedRenderingFeatures), Member = "get_active", ReturnType = typeof(SupportedRenderingFeatures))]
	[Calls(Type = typeof(UniversalCameraData), Member = "get_resolveToScreen", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Watermark), Member = "IsVisible", ReturnType = typeof(bool))]
	[Calls(Type = typeof(RenderTexture), Member = "get_volumeDepth", ReturnType = typeof(int))]
	[Calls(Type = typeof(RenderTexture), Member = "get_antiAliasing", ReturnType = typeof(int))]
	[Calls(Type = typeof(RenderTexture), Member = "get_graphicsFormat", ReturnType = typeof(GraphicsFormat))]
	[Calls(Type = typeof(RenderTexture), Member = "get_depthStencilFormat", ReturnType = typeof(GraphicsFormat))]
	[Calls(Type = typeof(UniversalRenderer), Member = "PlatformRequiresExplicitMsaaResolve", ReturnType = typeof(bool))]
	[Calls(Type = typeof(UniversalRenderer), Member = "CreateRenderingLayersTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(RenderTextureDescriptor)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallsUnknownMethods(Count = 5)]
	[ContainsUnimplementedInstructions]
	private void CreateRenderGraphCameraRenderTargets(RenderGraph renderGraph, bool isCameraTargetOffscreenDepth) { }

	[CalledBy(Type = typeof(DBufferRenderPass), Member = "RecordRenderGraph", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(ContextContainer)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(TextureDesc), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderTextureDescriptor), Member = "get_bindMS", ReturnType = typeof(bool))]
	[Calls(Type = typeof(RenderTextureDescriptor), Member = "get_enableRandomWrite", ReturnType = typeof(bool))]
	[Calls(Type = typeof(RenderTextureDescriptor), Member = "get_useDynamicScale", ReturnType = typeof(bool))]
	[Calls(Type = typeof(RenderTextureDescriptor), Member = "get_useDynamicScaleExplicit", ReturnType = typeof(bool))]
	[Calls(Type = typeof(RenderGraph), Member = "CreateTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextureDesc&)}, ReturnType = typeof(TextureHandle))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	internal static TextureHandle CreateRenderGraphTexture(RenderGraph renderGraph, RenderTextureDescriptor desc, string name, bool clear, Color color, FilterMode filterMode = 0, TextureWrapMode wrapMode = 1, bool discardOnLastUse = false) { }

	[CallerCount(Count = 41)]
	[Calls(Type = typeof(TextureDesc), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderTextureDescriptor), Member = "get_bindMS", ReturnType = typeof(bool))]
	[Calls(Type = typeof(RenderTextureDescriptor), Member = "get_enableRandomWrite", ReturnType = typeof(bool))]
	[Calls(Type = typeof(RenderTextureDescriptor), Member = "get_useDynamicScale", ReturnType = typeof(bool))]
	[Calls(Type = typeof(RenderTextureDescriptor), Member = "get_useDynamicScaleExplicit", ReturnType = typeof(bool))]
	[Calls(Type = typeof(RenderGraph), Member = "CreateTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextureDesc&)}, ReturnType = typeof(TextureHandle))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	public static TextureHandle CreateRenderGraphTexture(RenderGraph renderGraph, RenderTextureDescriptor desc, string name, bool clear, FilterMode filterMode = 0, TextureWrapMode wrapMode = 1) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TextureDesc), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderTextureDescriptor), Member = "get_bindMS", ReturnType = typeof(bool))]
	[Calls(Type = typeof(RenderTextureDescriptor), Member = "get_enableRandomWrite", ReturnType = typeof(bool))]
	[Calls(Type = typeof(RenderTextureDescriptor), Member = "get_useDynamicScale", ReturnType = typeof(bool))]
	[Calls(Type = typeof(RenderTextureDescriptor), Member = "get_useDynamicScaleExplicit", ReturnType = typeof(bool))]
	[Calls(Type = typeof(RenderGraph), Member = "CreateTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextureDesc&)}, ReturnType = typeof(TextureHandle))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	internal static TextureHandle CreateRenderGraphTexture(RenderGraph renderGraph, RenderTextureDescriptor desc, string name, bool clear, Color color, int anisoLevel, FilterMode filterMode = 0, TextureWrapMode wrapMode = 1, bool discardOnLastUse = false) { }

	[CalledBy(Type = typeof(UniversalRenderer), Member = "CreateRenderGraphCameraRenderTargets", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(RenderTextureDescriptor), Member = "set_graphicsFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GraphicsFormat)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderTextureDescriptor), Member = "get_useDynamicScaleExplicit", ReturnType = typeof(bool))]
	[Calls(Type = typeof(RenderTextureDescriptor), Member = "get_useDynamicScale", ReturnType = typeof(bool))]
	[Calls(Type = typeof(RenderTextureDescriptor), Member = "get_enableRandomWrite", ReturnType = typeof(bool))]
	[Calls(Type = typeof(RenderTextureDescriptor), Member = "get_bindMS", ReturnType = typeof(bool))]
	[Calls(Type = typeof(TextureDesc), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderingLayerUtils), Member = "GetFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MaskSize)}, ReturnType = typeof(GraphicsFormat))]
	[Calls(Type = typeof(DeferredLights), Member = "GetGBufferFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(GraphicsFormat))]
	[Calls(Type = typeof(DeferredLights), Member = "get_GBufferRenderingLayers", ReturnType = typeof(int))]
	[Calls(Type = typeof(DeferredLights), Member = "get_UseRenderingLayers", ReturnType = typeof(bool))]
	[Calls(Type = typeof(UniversalRenderer), Member = "get_renderingModeActual", ReturnType = typeof(RenderingMode))]
	[Calls(Type = typeof(ContextContainer), Member = "Get", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(RenderGraph), Member = "CreateTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextureDesc&)}, ReturnType = typeof(TextureHandle))]
	[Calls(Type = typeof(UniversalResourceData), Member = "set_renderingLayersTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextureHandle)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	[ContainsUnimplementedInstructions]
	private void CreateRenderingLayersTexture(RenderGraph renderGraph, RenderTextureDescriptor descriptor) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UniversalCameraData), Member = "get_isPreviewCamera", ReturnType = typeof(bool))]
	[Calls(Type = typeof(DebugHandler), Member = "IsActiveForCamera", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DebugHandler), Member = "TryGetFullscreenDebugMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DebugFullScreenMode&)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private bool DebugHandlerRequireDepthPass(UniversalCameraData cameraData) { }

	[CalledBy(Type = typeof(UniversalRenderer), Member = "OnMainRendering", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(ScriptableRenderContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ContextContainer), Member = "Get", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(UniversalRenderer), Member = "get_renderingModeActual", ReturnType = typeof(RenderingMode))]
	[Calls(Type = typeof(UniversalResourceData), Member = "get_cameraNormalsTexture", ReturnType = typeof(TextureHandle))]
	[Calls(Type = typeof(UniversalResourceData), Member = "get_renderingLayersTexture", ReturnType = typeof(TextureHandle))]
	[Calls(Type = typeof(DepthNormalOnlyPass), Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(ContextContainer), typeof(TextureHandle), typeof(TextureHandle), typeof(TextureHandle), typeof(uint), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UniversalRenderer), Member = "SetRenderingLayersGlobalTextures", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	private void DepthNormalPrepassRender(RenderGraph renderGraph, RenderPassInputSummary renderPassInputs, TextureHandle depthTarget, uint batchLayerMask, bool setGlobalDepth, bool setGlobalTextures) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ForwardLights), Member = "Cleanup", ReturnType = typeof(void))]
	[Calls(Type = typeof(GBufferPass), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(PostProcessPasses), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(DrawScreenSpaceUIPass), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(CopyDepthPass), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(XRDepthMotionPass), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(RTHandle), Member = "Release", ReturnType = typeof(void))]
	[Calls(Type = typeof(ScriptableRenderer), Member = "Dispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CoreUtils), Member = "Destroy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(LensFlareCommonSRP), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(XRSystem), Member = "Dispose", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	protected virtual void Dispose(bool disposing) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RenderTargetBufferSystem), Member = "EnableMSAA", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	internal virtual void EnableSwapBufferMSAA(bool enable) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DeferredLights), Member = "Setup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AdditionalLightsShadowCasterPass), typeof(bool), typeof(bool), typeof(bool), typeof(RTHandle), typeof(RTHandle), typeof(RTHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ScriptableRenderer), Member = "EnqueuePass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderPass)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CopyDepthPass), Member = "Setup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RTHandle), typeof(RTHandle)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	private void EnqueueDeferred(RenderTextureDescriptor cameraTargetDescriptor, bool hasDepthPrepass, bool hasNormalPrepass, bool hasRenderingLayerPrepass, bool applyMainShadow, bool applyAdditionalShadow) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UniversalRenderer), Member = "CopyDepthToDepthTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(UniversalResourceData)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UniversalRenderer), Member = "RenderMotionVectors", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(UniversalResourceData)}, ReturnType = typeof(void))]
	private void ExecuteScheduledDepthCopyWithMotion(RenderGraph renderGraph, UniversalResourceData resourceData, bool renderMotionVectors) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RenderTargetBufferSystem), Member = "Clear", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public virtual void FinishRendering(CommandBuffer cmd) { }

	[CalledBy(Type = typeof(DecalRendererFeature), Member = "GetTechnique", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderer)}, ReturnType = typeof(DecalTechnique))]
	[CalledBy(Type = typeof(DecalRendererFeature), Member = "RecreateSystemsIfNeeded", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderer), typeof(CameraData&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(RenderingLayerUtils), Member = "RequireRenderingLayers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UniversalRenderer), typeof(System.Collections.Generic.List`1<UnityEngine.Rendering.Universal.ScriptableRendererFeature>), typeof(int), typeof(Event&), typeof(MaskSize&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 3)]
	internal bool get_accurateGbufferNormals() { }

	[CallerCount(Count = 0)]
	internal GraphicsFormat get_cameraDepthAttachmentFormat() { }

	[CalledBy(Type = typeof(UniversalRenderer), Member = "Setup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), typeof(RenderingData&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	internal GraphicsFormat get_cameraDepthTextureFormat() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	internal RTHandle get_colorGradingLut() { }

	[CallerCount(Count = 0)]
	internal ColorGradingLutPass get_colorGradingLutPass() { }

	[CalledBy(Type = typeof(UniversalRenderer), Member = "CreateRenderGraphCameraRenderTargets", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private RTHandle get_currentRenderGraphCameraColorHandle() { }

	[CallerCount(Count = 0)]
	internal DeferredLights get_deferredLights() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public DepthPrimingMode get_depthPrimingMode() { }

	[CallerCount(Count = 0)]
	internal PostProcessPass get_finalPostProcessPass() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private RTHandle get_nextRenderGraphCameraColorHandle() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	internal LayerMask get_opaqueLayerMask() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	internal PostProcessPass get_postProcessPass() { }

	[CallerCount(Count = 46)]
	[Calls(Type = typeof(GL), Member = "get_wireframe", ReturnType = typeof(bool))]
	[Calls(Type = typeof(DebugHandler), Member = "get_IsActiveModeUnsupportedForDeferred", ReturnType = typeof(bool))]
	[Calls(Type = typeof(DeferredLights), Member = "IsRuntimeSupportedThisFrame", ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	internal RenderingMode get_renderingModeActual() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	internal RenderingMode get_renderingModeRequested() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	internal bool get_shadowTransparentReceive() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Debug), Member = "LogWarning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public virtual bool get_supportsGPUOcclusion() { }

	[CallerCount(Count = 23)]
	[DeduplicatedMethod]
	internal virtual bool get_supportsNativeRenderPassRendergraphCompiler() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	internal LayerMask get_transparentLayerMask() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RenderTargetBufferSystem), Member = "GetBackBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer)}, ReturnType = typeof(RTHandle))]
	[CallsUnknownMethods(Count = 1)]
	[Obsolete("This rendering path is for compatibility mode only (when Render Graph is disabled). Use Render Graph API instead.", False)]
	internal virtual RTHandle GetCameraColorBackBuffer(CommandBuffer cmd) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RenderTargetBufferSystem), Member = "GetFrontBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer)}, ReturnType = typeof(RTHandle))]
	[CallsUnknownMethods(Count = 1)]
	[Obsolete("This rendering path is for compatibility mode only (when Render Graph is disabled). Use Render Graph API instead.", False)]
	internal virtual RTHandle GetCameraColorFrontBuffer(CommandBuffer cmd) { }

	[CalledBy(Type = typeof(UniversalRenderer), Member = "Setup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), typeof(RenderingData&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalRenderer), Member = "CreateRenderGraphCameraRenderTargets", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalRenderer), Member = "OnMainRendering", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(ScriptableRenderContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(VolumeManager), Member = "get_instance", ReturnType = typeof(VolumeManager))]
	[Calls(Type = typeof(VolumeStack), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private RenderPassInputSummary GetRenderPassInputs(bool isTemporalAAEnabled, bool postProcessingEnabled, bool isSceneViewCamera) { }

	[CalledBy(Type = typeof(UniversalRenderer), Member = "Setup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), typeof(RenderingData&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalRenderer), Member = "RequiresIntermediateAttachments", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UniversalCameraData), typeof(RenderPassInputSummary&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 3)]
	internal bool HasActiveRenderFeatures() { }

	[CalledBy(Type = typeof(UniversalRenderer), Member = "Setup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), typeof(RenderingData&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalRenderer), Member = "RequiresIntermediateAttachments", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UniversalCameraData), typeof(RenderPassInputSummary&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 3)]
	internal bool HasPassesRequiringIntermediateTexture() { }

	[CalledBy(Type = typeof(UniversalRenderer), Member = "OnMainRendering", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(ScriptableRenderContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(XRPass), Member = "get_enabled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(XRPass), Member = "get_singlePassEnabled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "GetInstanceID", ReturnType = typeof(int))]
	[Calls(Type = typeof(OcclusionCullingSettings), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(OcclusionTest)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Span`1), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Span`1<T>"}, ReturnType = "System.ReadOnlySpan`1<T>")]
	[Calls(Type = typeof(GPUResidentDrawer), Member = "InstanceOcclusionTest", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(OcclusionCullingSettings&), typeof(System.ReadOnlySpan`1<UnityEngine.Rendering.SubviewOcclusionTest>)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	private void InstanceOcclusionTest(RenderGraph renderGraph, UniversalCameraData cameraData, OcclusionTest occlusionTest) { }

	[CalledBy(Type = typeof(UniversalRenderer), Member = "Setup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), typeof(RenderingData&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalRenderer), Member = "CreateCameraRenderTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), typeof(RenderTextureDescriptor&), typeof(CommandBuffer), typeof(UniversalCameraData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalRenderer), Member = "RequiresIntermediateAttachments", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UniversalCameraData), typeof(RenderPassInputSummary&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(UniversalRenderer), Member = "CreateRenderGraphCameraRenderTargets", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalRenderer), Member = "OnMainRendering", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(ScriptableRenderContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalRenderer), Member = "RequireDepthPrepass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UniversalCameraData), typeof(RenderPassInputSummary&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(UniversalRenderer), Member = "RequireDepthTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UniversalCameraData), typeof(bool), typeof(RenderPassInputSummary&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(UniversalRenderer), Member = "CanCopyDepth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UniversalCameraData)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(RenderTexture), Member = "get_format", ReturnType = typeof(RenderTextureFormat))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private bool IsDepthPrimingEnabled(UniversalCameraData cameraData) { }

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	private bool IsGLDevice() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private bool IsGLESDevice() { }

	[CalledBy(Type = typeof(DecalRendererFeature), Member = "AddRenderPasses", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderer), typeof(RenderingData&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FullScreenPassRendererFeature), Member = "AddRenderPasses", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderer), typeof(RenderingData&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RenderObjects), Member = "AddRenderPasses", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderer), typeof(RenderingData&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScreenSpaceAmbientOcclusion), Member = "AddRenderPasses", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderer), typeof(RenderingData&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScreenSpaceShadows), Member = "AddRenderPasses", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderer), typeof(RenderingData&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(ContextContainer), Member = "Get", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(RenderTexture), Member = "get_format", ReturnType = typeof(RenderTextureFormat))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public static bool IsOffscreenDepthTexture(ref CameraData cameraData) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(RenderTexture), Member = "get_format", ReturnType = typeof(RenderTextureFormat))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public static bool IsOffscreenDepthTexture(UniversalCameraData cameraData) { }

	[CallerCount(Count = 271)]
	[DeduplicatedMethod]
	private bool IsWebGL() { }

	[CalledBy(Type = typeof(UniversalRenderer), Member = "OnRecordRenderGraph", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(ScriptableRenderContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(RenderGraph), Member = "CreateTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextureDesc&)}, ReturnType = typeof(TextureHandle))]
	[Calls(Type = typeof(UniversalResourceData), Member = "set_debugScreenDepth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextureHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UniversalCameraData), Member = "IsSTPEnabled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(RenderGraph), Member = "CreateTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextureHandle), typeof(string), typeof(bool)}, ReturnType = typeof(TextureHandle))]
	[Calls(Type = typeof(RenderGraph), Member = "ImportTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RTHandle), typeof(ImportResourceParams)}, ReturnType = typeof(TextureHandle))]
	[Calls(Type = typeof(TextureHandle), Member = "GetDescriptor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph)}, ReturnType = typeof(TextureDesc))]
	[Calls(Type = typeof(UniversalResourceData), Member = "get_debugScreenColor", ReturnType = typeof(TextureHandle))]
	[Calls(Type = typeof(PostProcessPass), Member = "RenderPostProcessingRenderGraph", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(ContextContainer), typeof(TextureHandle&), typeof(TextureHandle&), typeof(TextureHandle&), typeof(TextureHandle&), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UniversalRenderer), Member = "SetupAfterPostRenderGraphFinalPassDebug", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(ContextContainer)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UniversalResourceData), Member = "get_isActiveTargetBackBuffer", ReturnType = typeof(bool))]
	[Calls(Type = typeof(DebugHandler), Member = "ConfigureDepthDescriptorForDebugScreen", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTextureDescriptor&), typeof(GraphicsFormat), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FinalBlitPass), Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(ContextContainer), typeof(UniversalCameraData), typeof(TextureHandle&), typeof(TextureHandle&), typeof(TextureHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UniversalCameraData), Member = "get_rendersOverlayUI", ReturnType = typeof(bool))]
	[Calls(Type = typeof(UniversalCameraData), Member = "get_isHDROutputActive", ReturnType = typeof(bool))]
	[Calls(Type = typeof(UniversalResourceData), Member = "get_backBufferDepth", ReturnType = typeof(TextureHandle))]
	[Calls(Type = typeof(UniversalResourceData), Member = "get_debugScreenDepth", ReturnType = typeof(TextureHandle))]
	[Calls(Type = typeof(DrawScreenSpaceUIPass), Member = "RenderOverlay", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(ContextContainer), typeof(TextureHandle&), typeof(TextureHandle&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XRPass), Member = "get_enabled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(PostProcessPass), Member = "RenderFinalPassRenderGraph", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(ContextContainer), typeof(TextureHandle&), typeof(TextureHandle&), typeof(TextureHandle&), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UniversalResourceData), Member = "set_debugScreenColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextureHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderTextureDescriptor), Member = "get_useDynamicScaleExplicit", ReturnType = typeof(bool))]
	[Calls(Type = typeof(ScriptableRenderPass), Member = "GetActiveDebugHandler", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UniversalCameraData)}, ReturnType = typeof(DebugHandler))]
	[Calls(Type = typeof(ContextContainer), Member = "Get", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(UniversalRenderer), Member = "SetupRenderGraphFinalPassDebug", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(ContextContainer)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UniversalResourceData), Member = "get_activeColorTexture", ReturnType = typeof(TextureHandle))]
	[Calls(Type = typeof(UniversalResourceData), Member = "get_activeDepthTexture", ReturnType = typeof(TextureHandle))]
	[Calls(Type = typeof(ScriptableRenderer), Member = "RecordCustomRenderGraphPasses", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(RenderPassEvent)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(PostProcessPasses), Member = "get_isCreated", ReturnType = typeof(bool))]
	[Calls(Type = typeof(UniversalCameraData), Member = "IsTemporalAAEnabled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Predicate`1<System.Object>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "Find", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Predicate`1<T>"}, ReturnType = "T")]
	[Calls(Type = typeof(UniversalCameraData), Member = "get_isSceneViewCamera", ReturnType = typeof(bool))]
	[Calls(Type = typeof(UniversalResourceData), Member = "get_afterPostProcessColor", ReturnType = typeof(TextureHandle))]
	[Calls(Type = typeof(UniversalResourceData), Member = "get_backBufferColor", ReturnType = typeof(TextureHandle))]
	[Calls(Type = typeof(UniversalResourceData), Member = "get_internalColorLut", ReturnType = typeof(TextureHandle))]
	[Calls(Type = typeof(UniversalResourceData), Member = "get_overlayUITexture", ReturnType = typeof(TextureHandle))]
	[Calls(Type = typeof(DebugHandler), Member = "ConfigureColorDescriptorForDebugScreen", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTextureDescriptor&), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TextureDesc), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderTextureDescriptor), Member = "get_bindMS", ReturnType = typeof(bool))]
	[Calls(Type = typeof(RenderTextureDescriptor), Member = "get_enableRandomWrite", ReturnType = typeof(bool))]
	[Calls(Type = typeof(RenderTextureDescriptor), Member = "get_useDynamicScale", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CopyDepthPass), Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(ContextContainer), typeof(TextureHandle), typeof(TextureHandle), typeof(bool), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 15)]
	[CallsUnknownMethods(Count = 7)]
	[ContainsUnimplementedInstructions]
	private void OnAfterRendering(RenderGraph renderGraph) { }

	[CalledBy(Type = typeof(UniversalRenderer), Member = "OnRecordRenderGraph", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(ScriptableRenderContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UniversalResourceData), Member = "set_internalColorLut", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextureHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ColorGradingLutPass), Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(ContextContainer), typeof(TextureHandle&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(PostProcessPasses), Member = "get_isCreated", ReturnType = typeof(bool))]
	[Calls(Type = typeof(ScriptableRenderer), Member = "SetupRenderGraphCameraProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UniversalResourceData), Member = "get_isActiveTargetBackBuffer", ReturnType = typeof(bool))]
	[Calls(Type = typeof(UniversalResourceData), Member = "set_additionalShadowsTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextureHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AdditionalLightsShadowCasterPass), Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(ContextContainer)}, ReturnType = typeof(TextureHandle))]
	[Calls(Type = typeof(AdditionalLightsShadowCasterPass), Member = "Setup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UniversalRenderingData), typeof(UniversalCameraData), typeof(UniversalLightData), typeof(UniversalShadowData)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(MainLightShadowCasterPass), Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(ContextContainer)}, ReturnType = typeof(TextureHandle))]
	[Calls(Type = typeof(MainLightShadowCasterPass), Member = "Setup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UniversalRenderingData), typeof(UniversalCameraData), typeof(UniversalLightData), typeof(UniversalShadowData)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ScriptableRenderer), Member = "RecordCustomRenderGraphPasses", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(RenderPassEvent)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ForwardLights), Member = "PreSetup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UniversalRenderingData), typeof(UniversalCameraData), typeof(UniversalLightData)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ContextContainer), Member = "Get", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void OnBeforeRendering(RenderGraph renderGraph) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ContextContainer), Member = "Get", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public virtual void OnBeginRenderGraphFrame() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ContextContainer), Member = "Get", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public virtual void OnEndRenderGraphFrame() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UniversalRenderer), Member = "get_renderingModeActual", ReturnType = typeof(RenderingMode))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	internal virtual void OnFinishRenderGraphRendering(CommandBuffer cmd) { }

	[CalledBy(Type = typeof(UniversalRenderer), Member = "OnRecordRenderGraph", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(ScriptableRenderContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ScriptableRenderer), Member = "RecordCustomRenderGraphPasses", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(RenderPassEvent), typeof(RenderPassEvent)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UniversalResourceData), Member = "get_renderingLayersTexture", ReturnType = typeof(TextureHandle))]
	[Calls(Type = typeof(DrawObjectsWithRenderingLayersPass), Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(ContextContainer), typeof(TextureHandle), typeof(TextureHandle), typeof(TextureHandle), typeof(TextureHandle), typeof(TextureHandle), typeof(MaskSize), typeof(uint)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UniversalRenderer), Member = "SetRenderingLayersGlobalTextures", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DeferredLights), Member = "ResolveMixedLightingMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UniversalLightData)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GBufferPass), Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(ContextContainer), typeof(TextureHandle), typeof(TextureHandle), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UniversalResourceData), Member = "get_gBuffer", ReturnType = typeof(TextureHandle[]))]
	[Calls(Type = typeof(DeferredPass), Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(ContextContainer), typeof(TextureHandle), typeof(TextureHandle), typeof(TextureHandle[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ScriptableRenderer), Member = "CalculateSplitEventRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderPassEvent), typeof(RenderPassEvent), typeof(RenderPassEvent&), typeof(RenderPassEvent&), typeof(RenderPassEvent&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ScriptableRenderer), Member = "RecordCustomRenderGraphPassesInEventRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(RenderPassEvent), typeof(RenderPassEvent)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Camera), Member = "get_clearFlags", ReturnType = typeof(CameraClearFlags))]
	[Calls(Type = typeof(Component), Member = "TryGetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Skybox), Member = "get_material", ReturnType = typeof(Material))]
	[Calls(Type = typeof(RenderSettings), Member = "get_skybox", ReturnType = typeof(Material))]
	[Calls(Type = typeof(DrawSkyboxPass), Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(ContextContainer), typeof(ScriptableRenderContext), typeof(TextureHandle), typeof(TextureHandle), typeof(Material)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GraphicsSettings), Member = "get_currentRenderPipeline", ReturnType = typeof(RenderPipelineAsset))]
	[Calls(Type = typeof(CopyColorPass), Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(ContextContainer), typeof(TextureHandle&), typeof(TextureHandle&), typeof(Downsampling)}, ReturnType = typeof(TextureHandle))]
	[Calls(Type = typeof(UniversalResourceData), Member = "set_cameraOpaqueTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextureHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TransparentSettingsPass), Member = "Setup", ReturnType = typeof(bool))]
	[Calls(Type = typeof(ScriptableRenderContext), Member = "HasInvokeOnRenderObjectCallbacks", ReturnType = typeof(bool))]
	[Calls(Type = typeof(InvokeOnRenderObjectCallbackPass), Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(TextureHandle), typeof(TextureHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UniversalRenderer), Member = "RenderRawColorDepthHistory", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(UniversalCameraData), typeof(UniversalResourceData)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UniversalCameraData), Member = "get_rendersOverlayUI", ReturnType = typeof(bool))]
	[Calls(Type = typeof(UniversalCameraData), Member = "get_isHDROutputActive", ReturnType = typeof(bool))]
	[Calls(Type = typeof(DrawObjectsPass), Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(ContextContainer), typeof(TextureHandle), typeof(TextureHandle), typeof(TextureHandle), typeof(TextureHandle), typeof(uint)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UniversalResourceData), Member = "get_additionalShadowsTexture", ReturnType = typeof(TextureHandle))]
	[Calls(Type = typeof(XROcclusionMeshPass), Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(ContextContainer), typeof(TextureHandle&), typeof(TextureHandle&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UniversalRenderer), Member = "CanCopyDepth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UniversalCameraData)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ContextContainer), Member = "Get", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(ScriptableRenderer), Member = "GetCameraClearFlag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UniversalCameraData)}, ReturnType = typeof(ClearFlag))]
	[Calls(Type = typeof(UniversalResourceData), Member = "get_activeColorTexture", ReturnType = typeof(TextureHandle))]
	[Calls(Type = typeof(UniversalResourceData), Member = "get_activeDepthTexture", ReturnType = typeof(TextureHandle))]
	[Calls(Type = typeof(ClearTargetsPass), Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(TextureHandle), typeof(TextureHandle), typeof(RTClearFlags), typeof(Color)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ScriptableRenderer), Member = "RecordCustomRenderGraphPasses", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(RenderPassEvent)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UniversalCameraData), Member = "IsTemporalAAEnabled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(UniversalCameraData), Member = "get_isSceneViewCamera", ReturnType = typeof(bool))]
	[Calls(Type = typeof(UniversalRenderer), Member = "GetRenderPassInputs", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(RenderPassInputSummary))]
	[Calls(Type = typeof(UniversalRenderer), Member = "get_renderingModeActual", ReturnType = typeof(RenderingMode))]
	[Calls(Type = typeof(PostProcessPasses), Member = "get_isCreated", ReturnType = typeof(bool))]
	[Calls(Type = typeof(UniversalRenderer), Member = "IsDepthPrimingEnabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UniversalCameraData)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DrawScreenSpaceUIPass), Member = "RenderOffscreen", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(ContextContainer), typeof(GraphicsFormat), typeof(TextureHandle&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UniversalResourceData), Member = "set_overlayUITexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextureHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XRPass), Member = "get_enabled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(XRDepthMotionPass), Member = "Update", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UniversalCameraData&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XRDepthMotionPass), Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(ContextContainer)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UniversalResourceData), Member = "get_cameraDepthTexture", ReturnType = typeof(TextureHandle))]
	[Calls(Type = typeof(UniversalRenderer), Member = "InstanceOcclusionTest", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(UniversalCameraData), typeof(OcclusionTest)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(OcclusionTestMethods), Member = "GetBatchLayerMask", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(OcclusionTest)}, ReturnType = typeof(uint))]
	[Calls(Type = typeof(DepthOnlyPass), Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(ContextContainer), typeof(TextureHandle&), typeof(uint), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UniversalRenderer), Member = "DepthNormalPrepassRender", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(RenderPassInputSummary), typeof(TextureHandle), typeof(uint), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UniversalRenderer), Member = "UpdateInstanceOccluders", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(UniversalCameraData), typeof(TextureHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UniversalRenderer), Member = "CopyDepthToDepthTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(UniversalResourceData)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UniversalRenderer), Member = "RenderMotionVectors", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(UniversalResourceData)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XRPass), Member = "get_hasValidOcclusionMesh", ReturnType = typeof(bool))]
	[Calls(Type = typeof(UniversalRenderer), Member = "CalculateTextureCopySchedules", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UniversalCameraData), typeof(RenderPassInputSummary), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(TextureCopySchedules))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	private void OnMainRendering(RenderGraph renderGraph, ScriptableRenderContext context) { }

	[CalledBy(Type = typeof(UniversalRenderer), Member = "OnRecordRenderGraph", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(ScriptableRenderContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UniversalResourceData), Member = "get_activeColorTexture", ReturnType = typeof(TextureHandle))]
	[Calls(Type = typeof(UniversalResourceData), Member = "get_backBufferDepth", ReturnType = typeof(TextureHandle))]
	[Calls(Type = typeof(ClearTargetsPass), Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(TextureHandle), typeof(TextureHandle), typeof(RTClearFlags), typeof(Color)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ScriptableRenderer), Member = "RecordCustomRenderGraphPasses", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(RenderPassEvent), typeof(RenderPassEvent)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DrawObjectsPass), Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(ContextContainer), typeof(TextureHandle), typeof(TextureHandle), typeof(TextureHandle), typeof(TextureHandle), typeof(uint)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private void OnOffscreenDepthTextureRendering(RenderGraph renderGraph, ScriptableRenderContext context, UniversalResourceData resourceData, UniversalCameraData cameraData) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RenderTexture), Member = "get_format", ReturnType = typeof(RenderTextureFormat))]
	[Calls(Type = typeof(UniversalRenderer), Member = "OnMainRendering", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(ScriptableRenderContext)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ScriptableRenderer), Member = "BeginRenderGraphXRRendering", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UniversalRenderer), Member = "OnBeforeRendering", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ScriptableRenderer), Member = "SetupRenderGraphCameraProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UniversalResourceData), Member = "get_isActiveTargetBackBuffer", ReturnType = typeof(bool))]
	[Calls(Type = typeof(ScriptableRenderer), Member = "RecordCustomRenderGraphPasses", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(RenderPassEvent)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UniversalRenderer), Member = "CreateRenderGraphCameraRenderTargets", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UniversalRenderer), Member = "OnOffscreenDepthTextureRendering", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(ScriptableRenderContext), typeof(UniversalResourceData), typeof(UniversalCameraData)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Camera), Member = "get_targetTexture", ReturnType = typeof(RenderTexture))]
	[Calls(Type = typeof(RenderingLayerUtils), Member = "RequireRenderingLayers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UniversalRenderer), typeof(System.Collections.Generic.List`1<UnityEngine.Rendering.Universal.ScriptableRendererFeature>), typeof(int), typeof(Event&), typeof(MaskSize&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DeferredLights), Member = "SetupRenderGraphLights", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(UniversalCameraData), typeof(UniversalLightData)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UniversalRenderer), Member = "get_renderingModeActual", ReturnType = typeof(RenderingMode))]
	[Calls(Type = typeof(ForwardLights), Member = "SetupRenderGraphLights", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(UniversalRenderingData), typeof(UniversalCameraData), typeof(UniversalLightData)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MotionVectorRenderPass), Member = "SetRenderGraphMotionVectorGlobalMatrices", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(UniversalCameraData)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ContextContainer), Member = "Get", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(UniversalRenderer), Member = "OnAfterRendering", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ScriptableRenderer), Member = "EndRenderGraphXRRendering", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	internal virtual void OnRecordRenderGraph(RenderGraph renderGraph, ScriptableRenderContext context) { }

	[CalledBy(Type = typeof(UniversalRenderer), Member = "RequiresIntermediateColorTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UniversalCameraData), typeof(RenderPassInputSummary&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(UniversalRenderer), Member = "CreateRenderGraphCameraRenderTargets", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Application), Member = "get_isMobilePlatform", ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	internal static bool PlatformRequiresExplicitMsaaResolve() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ScriptableRenderer), Member = "CalculateSplitEventRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderPassEvent), typeof(RenderPassEvent), typeof(RenderPassEvent&), typeof(RenderPassEvent&), typeof(RenderPassEvent&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ScriptableRenderer), Member = "RecordCustomRenderGraphPassesInEventRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(RenderPassEvent), typeof(RenderPassEvent)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UniversalRenderer), Member = "CopyDepthToDepthTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(UniversalResourceData)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UniversalRenderer), Member = "RenderMotionVectors", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(UniversalResourceData)}, ReturnType = typeof(void))]
	private void RecordCustomPassesWithDepthCopyAndMotion(RenderGraph renderGraph, UniversalResourceData resourceData, RenderPassEvent earliestDepthReadEvent, RenderPassEvent currentEvent, bool renderMotionVectors) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RenderTargetBufferSystem), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(GBufferPass), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(PostProcessPasses), Member = "ReleaseRenderTargets", ReturnType = typeof(void))]
	[Calls(Type = typeof(RTHandle), Member = "Release", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	internal virtual void ReleaseRenderTargets() { }

	[CalledBy(Type = typeof(UniversalRenderer), Member = "RecordCustomPassesWithDepthCopyAndMotion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(UniversalResourceData), typeof(RenderPassEvent), typeof(RenderPassEvent), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalRenderer), Member = "ExecuteScheduledDepthCopyWithMotion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(UniversalResourceData), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalRenderer), Member = "OnMainRendering", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(ScriptableRenderContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(UniversalResourceData), Member = "get_cameraDepthTexture", ReturnType = typeof(TextureHandle))]
	[Calls(Type = typeof(UniversalResourceData), Member = "get_motionVectorColor", ReturnType = typeof(TextureHandle))]
	[Calls(Type = typeof(UniversalResourceData), Member = "get_motionVectorDepth", ReturnType = typeof(TextureHandle))]
	[Calls(Type = typeof(MotionVectorRenderPass), Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(ContextContainer), typeof(TextureHandle), typeof(TextureHandle), typeof(TextureHandle)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private void RenderMotionVectors(RenderGraph renderGraph, UniversalResourceData resourceData) { }

	[CalledBy(Type = typeof(UniversalRenderer), Member = "OnMainRendering", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(ScriptableRenderContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(XRPass), Member = "get_enabled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(XRPass), Member = "get_singlePassEnabled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(UniversalCameraHistory), Member = "IsAccessRequested", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"Type"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(UniversalCameraHistory), Member = "GetHistoryForWrite", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"Type"}, ReturnType = "Type")]
	[Calls(Type = typeof(RawColorHistory), Member = "Update", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTextureDescriptor&), typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(RenderGraph), Member = "ImportTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RTHandle)}, ReturnType = typeof(TextureHandle))]
	[Calls(Type = typeof(CopyColorPass), Member = "RenderToExistingTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(ContextContainer), typeof(TextureHandle&), typeof(TextureHandle&), typeof(Downsampling)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderTextureDescriptor), Member = "set_graphicsFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GraphicsFormat)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RawDepthHistory), Member = "Update", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTextureDescriptor&), typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CopyDepthPass), Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(ContextContainer), typeof(TextureHandle), typeof(TextureHandle), typeof(bool), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 3)]
	private void RenderRawColorDepthHistory(RenderGraph renderGraph, UniversalCameraData cameraData, UniversalResourceData resourceData) { }

	[CalledBy(Type = typeof(UniversalRenderer), Member = "RequiresIntermediateAttachments", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UniversalCameraData), typeof(RenderPassInputSummary&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PostProcessPasses), Member = "get_isCreated", ReturnType = typeof(bool))]
	[Calls(Type = typeof(UniversalRenderer), Member = "IsDepthPrimingEnabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UniversalCameraData)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(UniversalRenderer), Member = "CanCopyDepth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UniversalCameraData)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private bool RequireDepthPrepass(UniversalCameraData cameraData, ref RenderPassInputSummary renderPassInputs) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UniversalRenderer), Member = "IsDepthPrimingEnabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UniversalCameraData)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(PostProcessPasses), Member = "get_isCreated", ReturnType = typeof(bool))]
	[Calls(Type = typeof(UniversalRenderer), Member = "get_renderingModeActual", ReturnType = typeof(RenderingMode))]
	[Calls(Type = typeof(UniversalCameraData), Member = "get_isPreviewCamera", ReturnType = typeof(bool))]
	[Calls(Type = typeof(DebugHandler), Member = "IsActiveForCamera", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DebugHandler), Member = "TryGetFullscreenDebugMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DebugFullScreenMode&)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	private bool RequireDepthTexture(UniversalCameraData cameraData, bool requiresDepthPrepass, ref RenderPassInputSummary renderPassInputs) { }

	[CalledBy(Type = typeof(UniversalRenderer), Member = "CreateRenderGraphCameraRenderTargets", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UniversalRenderer), Member = "RequireDepthPrepass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UniversalCameraData), typeof(RenderPassInputSummary&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(UniversalRenderer), Member = "HasActiveRenderFeatures", ReturnType = typeof(bool))]
	[Calls(Type = typeof(UniversalRenderer), Member = "HasPassesRequiringIntermediateTexture", ReturnType = typeof(bool))]
	[Calls(Type = typeof(UniversalRenderer), Member = "RequiresIntermediateColorTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UniversalCameraData), typeof(RenderPassInputSummary&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(UniversalRenderer), Member = "IsDepthPrimingEnabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UniversalCameraData)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(PostProcessPasses), Member = "get_isCreated", ReturnType = typeof(bool))]
	[Calls(Type = typeof(UniversalRenderer), Member = "get_renderingModeActual", ReturnType = typeof(RenderingMode))]
	[Calls(Type = typeof(UniversalCameraData), Member = "get_isPreviewCamera", ReturnType = typeof(bool))]
	[Calls(Type = typeof(DebugHandler), Member = "IsActiveForCamera", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DebugHandler), Member = "TryGetFullscreenDebugMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DebugFullScreenMode&)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	private bool RequiresIntermediateAttachments(UniversalCameraData cameraData, ref RenderPassInputSummary renderPassInputs) { }

	[CalledBy(Type = typeof(UniversalRenderer), Member = "Setup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), typeof(RenderingData&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalRenderer), Member = "RequiresIntermediateAttachments", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UniversalCameraData), typeof(RenderPassInputSummary&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UniversalRenderer), Member = "get_renderingModeActual", ReturnType = typeof(RenderingMode))]
	[Calls(Type = typeof(UniversalCameraData), Member = "get_isSceneViewCamera", ReturnType = typeof(bool))]
	[Calls(Type = typeof(UniversalRenderer), Member = "PlatformRequiresExplicitMsaaResolve", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(XRPass), Member = "get_enabled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(PostProcessPasses), Member = "get_isCreated", ReturnType = typeof(bool))]
	[Calls(Type = typeof(UniversalCameraData), Member = "get_requireSrgbConversion", ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private bool RequiresIntermediateColorTexture(UniversalCameraData cameraData, ref RenderPassInputSummary renderPassInputs) { }

	[CallerCount(Count = 0)]
	public void set_depthPrimingMode(DepthPrimingMode value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	internal void set_opaqueLayerMask(LayerMask value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	internal void set_shadowTransparentReceive(bool value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	internal void set_transparentLayerMask(LayerMask value) { }

	[CalledBy(Type = typeof(UniversalRenderer), Member = "OnMainRendering", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(ScriptableRenderContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalRenderer), Member = "DepthNormalPrepassRender", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(RenderPassInputSummary), typeof(TextureHandle), typeof(uint), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ContextContainer), Member = "Get", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(UniversalResourceData), Member = "get_renderingLayersTexture", ReturnType = typeof(TextureHandle))]
	[Calls(Type = typeof(UniversalRenderer), Member = "get_renderingModeActual", ReturnType = typeof(RenderingMode))]
	[Calls(Type = typeof(Shader), Member = "PropertyToID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(RenderGraphUtils), Member = "SetGlobalTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(int), typeof(TextureHandle), typeof(string), typeof(string), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	internal void SetRenderingLayersGlobalTextures(RenderGraph renderGraph) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TransparentSettingsPass), Member = "Setup", ReturnType = typeof(bool))]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTargetIdentifier), typeof(RenderTargetIdentifier)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BuiltinRenderTextureType)}, ReturnType = typeof(RenderTargetIdentifier))]
	[Calls(Type = typeof(RenderTargetBufferSystem), Member = "PeekBackBuffer", ReturnType = typeof(RTHandle))]
	[Calls(Type = typeof(RenderTargetBufferSystem), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(UniversalAdditionalCameraData), Member = "get_scriptableRenderer", ReturnType = typeof(ScriptableRenderer))]
	[Calls(Type = typeof(Component), Member = "TryGetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(RenderTargetBufferSystem), Member = "SetCameraSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTextureDescriptor), typeof(FilterMode)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderTextureDescriptor), Member = "set_autoGenerateMips", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderTextureDescriptor), Member = "set_useMipMap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RTHandles), Member = "get_rtHandleProperties", ReturnType = typeof(RTHandleProperties))]
	[Calls(Type = typeof(XRPass), Member = "get_enabled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(UniversalRenderer), Member = "RequiresIntermediateColorTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UniversalCameraData), typeof(RenderPassInputSummary&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(UniversalRenderer), Member = "get_renderingModeActual", ReturnType = typeof(RenderingMode))]
	[Calls(Type = typeof(RTHandleStaticHelpers), Member = "SetRTHandleUserManagedWrapper", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RTHandle&), typeof(RenderTargetIdentifier)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RTHandles), Member = "Alloc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTargetIdentifier)}, ReturnType = typeof(RTHandle))]
	[Calls(Type = typeof(UniversalRenderer), Member = "CreateCameraRenderTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), typeof(RenderTextureDescriptor&), typeof(CommandBuffer), typeof(UniversalCameraData)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RTHandle), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RTHandle)}, ReturnType = typeof(RenderTargetIdentifier))]
	[Calls(Type = typeof(CommandBuffer), Member = "CopyTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTargetIdentifier), typeof(RenderTargetIdentifier)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Predicate`1<System.Object>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "Find", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Predicate`1<T>"}, ReturnType = "T")]
	[Calls(Type = typeof(DebugHandler), Member = "TryGetFullscreenDebugMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DebugFullScreenMode&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DebugHandler), Member = "get_IsLightingActive", ReturnType = typeof(bool))]
	[Calls(Type = typeof(DebugHandler), Member = "get_IsRenderPassSupported", ReturnType = typeof(bool))]
	[Calls(Type = typeof(RenderTextureDescriptor), Member = "set_graphicsFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GraphicsFormat)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CommandBuffer), Member = "SetGlobalTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(RenderTargetIdentifier)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ScriptableRenderContext), Member = "ExecuteCommandBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CommandBuffer), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(DeferredLights), Member = "get_UseRenderingLayers", ReturnType = typeof(bool))]
	[Calls(Type = typeof(DeferredLights), Member = "get_GBufferRenderingLayers", ReturnType = typeof(int))]
	[Calls(Type = typeof(DeferredLights), Member = "GetGBufferFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(GraphicsFormat))]
	[Calls(Type = typeof(UniversalRenderer), Member = "CanCopyDepth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UniversalCameraData)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(AdditionalLightsShadowCasterPass), Member = "Setup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UniversalRenderingData), typeof(UniversalCameraData), typeof(UniversalLightData), typeof(UniversalShadowData)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(MainLightShadowCasterPass), Member = "Setup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UniversalRenderingData), typeof(UniversalCameraData), typeof(UniversalLightData), typeof(UniversalShadowData)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(PostProcessPasses), Member = "get_isCreated", ReturnType = typeof(bool))]
	[Calls(Type = typeof(UniversalRenderer), Member = "IsDepthPrimingEnabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UniversalCameraData)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ScriptableRenderer), Member = "EnqueuePass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderPass)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(HDRDebugViewPass), Member = "Setup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UniversalCameraData), typeof(HDRDebugMode)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DebugHandler), Member = "ConfigureDepthDescriptorForDebugScreen", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTextureDescriptor&), typeof(GraphicsFormat), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UniversalRenderer), Member = "get_cameraDepthTextureFormat", ReturnType = typeof(GraphicsFormat))]
	[Calls(Type = typeof(RenderingUtils), Member = "ReAllocateHandleIfNeeded", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RTHandle&), typeof(RenderTextureDescriptor&), typeof(FilterMode), typeof(TextureWrapMode), typeof(int), typeof(float), typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DebugHandler), Member = "ConfigureColorDescriptorForDebugScreen", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTextureDescriptor&), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UniversalCameraData), Member = "get_isPreviewCamera", ReturnType = typeof(bool))]
	[Calls(Type = typeof(UniversalRenderingData), Member = "get_commandBuffer", ReturnType = typeof(CommandBuffer))]
	[Calls(Type = typeof(ForwardLights), Member = "PreSetup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UniversalRenderingData), typeof(UniversalCameraData), typeof(UniversalLightData)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ContextContainer), Member = "Get", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(RenderingLayerUtils), Member = "SetupProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RasterCommandBuffer), typeof(MaskSize)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DepthNormalOnlyPass), Member = "GetGraphicsFormat", ReturnType = typeof(GraphicsFormat))]
	[Calls(Type = typeof(DebugHandler), Member = "IsActiveForCamera", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(RenderingLayerUtils), Member = "GetFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MaskSize)}, ReturnType = typeof(GraphicsFormat))]
	[Calls(Type = typeof(RenderTexture), Member = "get_format", ReturnType = typeof(RenderTextureFormat))]
	[Calls(Type = typeof(UniversalRenderer), Member = "HasActiveRenderFeatures", ReturnType = typeof(bool))]
	[Calls(Type = typeof(DeferredLights), Member = "IsRuntimeSupportedThisFrame", ReturnType = typeof(bool))]
	[Calls(Type = typeof(DebugHandler), Member = "get_IsActiveModeUnsupportedForDeferred", ReturnType = typeof(bool))]
	[Calls(Type = typeof(GL), Member = "get_wireframe", ReturnType = typeof(bool))]
	[Calls(Type = typeof(DeferredLights), Member = "DisableFramebufferFetchInput", ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(ScriptableRenderer), Member = "ConfigureCameraTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RTHandle), typeof(RTHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(RenderingLayerUtils), Member = "RequireRenderingLayers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UniversalRenderer), typeof(System.Collections.Generic.List`1<UnityEngine.Rendering.Universal.ScriptableRendererFeature>), typeof(int), typeof(Event&), typeof(MaskSize&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(UniversalRenderer), Member = "GetRenderPassInputs", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(RenderPassInputSummary))]
	[Calls(Type = typeof(UniversalCameraData), Member = "get_isSceneViewCamera", ReturnType = typeof(bool))]
	[Calls(Type = typeof(UniversalCameraData), Member = "IsTemporalAAEnabled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(UniversalRenderer), Member = "UpdateCameraHistory", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UniversalCameraData)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UniversalRenderer), Member = "HasPassesRequiringIntermediateTexture", ReturnType = typeof(bool))]
	[Calls(Type = typeof(DeferredLights), Member = "ResolveMixedLightingMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UniversalLightData)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DeferredLights), Member = "ReAllocateGBufferIfNeeded", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTextureDescriptor), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 16)]
	[CallsUnknownMethods(Count = 11)]
	[ContainsInvalidInstructions]
	[ContainsUnimplementedInstructions]
	[Obsolete("This rendering path is for compatibility mode only (when Render Graph is disabled). Use Render Graph API instead.", False)]
	public virtual void Setup(ScriptableRenderContext context, ref RenderingData renderingData) { }

	[CalledBy(Type = typeof(UniversalRenderer), Member = "OnAfterRendering", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ContextContainer), Member = "Get", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(UniversalCameraData), Member = "get_isPreviewCamera", ReturnType = typeof(bool))]
	[Calls(Type = typeof(DebugHandler), Member = "IsActiveForCamera", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DebugHandler), Member = "TryGetFullscreenDebugMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DebugFullScreenMode&), typeof(Int32&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(UniversalRenderer), Member = "CreateDebugTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTextureDescriptor)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderGraph), Member = "ImportTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RTHandle), typeof(ImportResourceParams)}, ReturnType = typeof(TextureHandle))]
	[Calls(Type = typeof(UniversalResourceData), Member = "get_stpDebugView", ReturnType = typeof(TextureHandle))]
	[Calls(Type = typeof(UniversalRenderer), Member = "BlitToDebugTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(TextureHandle), typeof(TextureHandle), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DebugHandler), Member = "SetDebugRenderTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RTHandle), typeof(Rect), typeof(bool), typeof(Vector4)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private void SetupAfterPostRenderGraphFinalPassDebug(RenderGraph renderGraph, ContextContainer frameData) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UniversalRenderer), Member = "get_renderingModeActual", ReturnType = typeof(RenderingMode))]
	[Calls(Type = typeof(UniversalRenderPipeline), Member = "get_asset", ReturnType = typeof(UniversalRenderPipelineAsset))]
	[Calls(Type = typeof(UniversalRenderPipelineAsset), Member = "ShouldUseReflectionProbeBlending", ReturnType = typeof(bool))]
	[Calls(Type = typeof(ScriptableCullingParameters), Member = "get_cullingOptions", ReturnType = typeof(CullingOptions))]
	[Calls(Type = typeof(ScriptableCullingParameters), Member = "set_cullingOptions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CullingOptions)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ContextContainer), Member = "Get", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(UniversalRenderPipeline), Member = "get_maxVisibleAdditionalLights", ReturnType = typeof(int))]
	[Calls(Type = typeof(ScriptableCullingParameters), Member = "set_maximumVisibleLights", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ScriptableCullingParameters), Member = "set_reflectionProbeSortingCriteria", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ReflectionProbeSortingCriteria)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ScriptableCullingParameters), Member = "set_shadowDistance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ScriptableCullingParameters), Member = "set_conservativeEnclosingSphere", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ScriptableCullingParameters), Member = "set_numIterationsEnclosingSphere", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	public virtual void SetupCullingParameters(ref ScriptableCullingParameters cullingParameters, ref CameraData cameraData) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UniversalCameraData), Member = "get_isPreviewCamera", ReturnType = typeof(bool))]
	[Calls(Type = typeof(DebugHandler), Member = "IsActiveForCamera", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DebugHandler), Member = "TryGetFullscreenDebugMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DebugFullScreenMode&), typeof(Int32&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Camera), Member = "get_pixelWidth", ReturnType = typeof(int))]
	[Calls(Type = typeof(Camera), Member = "get_pixelHeight", ReturnType = typeof(int))]
	[Calls(Type = typeof(LightCookieManager), Member = "get_AdditionalLightsCookieAtlasTexture", ReturnType = typeof(RTHandle))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DebugHandler), Member = "SetDebugRenderTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RTHandle), typeof(Rect), typeof(bool), typeof(Vector4)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DebugHandler), Member = "ResetDebugRenderTarget", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	private void SetupFinalPassDebug(UniversalCameraData cameraData) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ContextContainer), Member = "Get", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(RenderingData), Member = "get_commandBuffer", ReturnType = typeof(CommandBuffer&))]
	[Calls(Type = typeof(ForwardLights), Member = "SetupLights", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnsafeCommandBuffer), typeof(UniversalRenderingData), typeof(UniversalCameraData), typeof(UniversalLightData)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UniversalRenderer), Member = "get_renderingModeActual", ReturnType = typeof(RenderingMode))]
	[Calls(Type = typeof(DeferredLights), Member = "SetupLights", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(UniversalCameraData), typeof(Vector2Int), typeof(UniversalLightData), typeof(bool)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[Obsolete("This rendering path is for compatibility mode only (when Render Graph is disabled). Use Render Graph API instead.", False)]
	public virtual void SetupLights(ScriptableRenderContext context, ref RenderingData renderingData) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XRPass), Member = "get_enabled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(XRPass), Member = "get_singlePassEnabled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(UniversalCameraHistory), Member = "IsAccessRequested", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"Type"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(UniversalCameraHistory), Member = "GetHistoryForWrite", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"Type"}, ReturnType = "Type")]
	[Calls(Type = typeof(RawColorHistory), Member = "Update", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTextureDescriptor&), typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CopyColorPass), Member = "Setup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RTHandle), typeof(RTHandle), typeof(Downsampling)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ScriptableRenderer), Member = "EnqueuePass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderPass)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderTextureDescriptor), Member = "set_graphicsFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GraphicsFormat)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderTextureDescriptor), Member = "set_colorFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTextureFormat)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RawDepthHistory), Member = "Update", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTextureDescriptor&), typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CopyDepthPass), Member = "Setup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RTHandle), typeof(RTHandle)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	private void SetupRawColorDepthHistory(UniversalCameraData cameraData, ref RenderTextureDescriptor cameraTargetDescriptor) { }

	[CalledBy(Type = typeof(UniversalRenderer), Member = "OnAfterRendering", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UniversalResourceData), Member = "get_motionVectorColor", ReturnType = typeof(TextureHandle))]
	[Calls(Type = typeof(UniversalResourceData), Member = "get_activeColorTexture", ReturnType = typeof(TextureHandle))]
	[Calls(Type = typeof(Object), Member = "GetInstanceID", ReturnType = typeof(int))]
	[Calls(Type = typeof(DebugHandler), Member = "ResetDebugRenderTarget", ReturnType = typeof(void))]
	[Calls(Type = typeof(DebugHandler), Member = "SetDebugRenderTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RTHandle), typeof(Rect), typeof(bool), typeof(Vector4)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RTHandles), Member = "Alloc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTexture), typeof(bool)}, ReturnType = typeof(RTHandle))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(RenderGraph), Member = "ImportTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RTHandle)}, ReturnType = typeof(TextureHandle))]
	[Calls(Type = typeof(LightCookieManager), Member = "get_AdditionalLightsCookieAtlasTexture", ReturnType = typeof(RTHandle))]
	[Calls(Type = typeof(UniversalResourceData), Member = "get_additionalShadowsTexture", ReturnType = typeof(TextureHandle))]
	[Calls(Type = typeof(UniversalRenderer), Member = "BlitToDebugTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(TextureHandle), typeof(TextureHandle), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UniversalResourceData), Member = "get_cameraDepthTexture", ReturnType = typeof(TextureHandle))]
	[Calls(Type = typeof(RenderGraph), Member = "ImportTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RTHandle), typeof(ImportResourceParams)}, ReturnType = typeof(TextureHandle))]
	[Calls(Type = typeof(UniversalRenderer), Member = "CreateDebugTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTextureDescriptor)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderTextureDescriptor), Member = "set_graphicsFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GraphicsFormat)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SystemInfo), Member = "IsFormatSupported", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GraphicsFormat), typeof(GraphicsFormatUsage)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DebugHandler), Member = "TryGetFullscreenDebugMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DebugFullScreenMode&), typeof(Int32&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DebugHandler), Member = "IsActiveForCamera", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(UniversalCameraData), Member = "get_isPreviewCamera", ReturnType = typeof(bool))]
	[Calls(Type = typeof(ContextContainer), Member = "Get", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(GPUResidentDrawer), Member = "RenderDebugOcclusionTestOverlay", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(DebugDisplayGPUResidentDrawer), typeof(int), typeof(TextureHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GPUResidentDrawer), Member = "RenderDebugOccluderOverlay", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(DebugDisplayGPUResidentDrawer), typeof(Vector2), typeof(float), typeof(TextureHandle)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	private void SetupRenderGraphFinalPassDebug(RenderGraph renderGraph, ContextContainer frameData) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ForwardLights), Member = "SetupRenderGraphLights", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(UniversalRenderingData), typeof(UniversalCameraData), typeof(UniversalLightData)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UniversalRenderer), Member = "get_renderingModeActual", ReturnType = typeof(RenderingMode))]
	[Calls(Type = typeof(DeferredLights), Member = "SetupRenderGraphLights", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(UniversalCameraData), typeof(UniversalLightData)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	internal void SetupRenderGraphLights(RenderGraph renderGraph, UniversalRenderingData renderingData, UniversalCameraData cameraData, UniversalLightData lightData) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RenderingLayerUtils), Member = "RequireRenderingLayers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UniversalRenderer), typeof(System.Collections.Generic.List`1<UnityEngine.Rendering.Universal.ScriptableRendererFeature>), typeof(int), typeof(Event&), typeof(MaskSize&)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private void SetupRenderingLayers(int msaaSamples) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VFXManager), Member = "IsCameraBufferNeeded", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(VFXCameraBufferTypes))]
	[Calls(Type = typeof(UniversalCameraHistory), Member = "RequestAccess", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"Type"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UniversalCameraHistory), Member = "GetHistoryForRead", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"Type"}, ReturnType = "Type")]
	[Calls(Type = typeof(RTHandle), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RTHandle)}, ReturnType = typeof(Texture))]
	[Calls(Type = typeof(VFXManager), Member = "SetCameraBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(VFXCameraBufferTypes), typeof(Texture), typeof(int), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private void SetupVFXCameraBuffer(UniversalCameraData cameraData) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PostProcessPasses), Member = "get_isCreated", ReturnType = typeof(bool))]
	private bool ShouldApplyPostProcessing(bool postProcessEnabled) { }

	[CallerCount(Count = 0)]
	public virtual int SupportedCameraStackingTypes() { }

	[CallerCount(Count = 23)]
	[DeduplicatedMethod]
	protected private virtual bool SupportsCameraNormals() { }

	[CallerCount(Count = 23)]
	[DeduplicatedMethod]
	protected private virtual bool SupportsCameraOpaque() { }

	[CallerCount(Count = 23)]
	[DeduplicatedMethod]
	protected private virtual bool SupportsMotionVectors() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RenderTargetBufferSystem), Member = "Swap", ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BuiltinRenderTextureType)}, ReturnType = typeof(RenderTargetIdentifier))]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTargetIdentifier), typeof(RenderTargetIdentifier)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(RenderTargetBufferSystem), Member = "GetBackBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer)}, ReturnType = typeof(RTHandle))]
	[Calls(Type = typeof(ScriptableRenderer), Member = "ConfigureCameraTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RTHandle), typeof(RTHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CommandBuffer), Member = "SetGlobalTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(RenderTargetIdentifier)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	internal virtual void SwapColorBuffer(CommandBuffer cmd) { }

	[CalledBy(Type = typeof(UniversalRenderer), Member = "Setup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), typeof(RenderingData&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalRenderer), Member = "CreateRenderGraphCameraRenderTargets", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(XRPass), Member = "get_enabled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(XRPass), Member = "get_singlePassEnabled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(BufferedRTHandleSystem), Member = "SwapAndSetReferenceSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	private void UpdateCameraHistory(UniversalCameraData cameraData) { }

	[CalledBy(Type = typeof(UniversalRenderer), Member = "OnMainRendering", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(ScriptableRenderContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(XRPass), Member = "get_enabled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(XRPass), Member = "get_singlePassEnabled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "GetInstanceID", ReturnType = typeof(int))]
	[Calls(Type = typeof(OccluderParameters), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
	[Calls(Type = typeof(UniversalCameraData), Member = "GetViewMatrix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Matrix4x4))]
	[Calls(Type = typeof(UniversalCameraData), Member = "GetProjectionMatrix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Matrix4x4))]
	[Calls(Type = typeof(OccluderSubviewUpdate), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Matrix4x4), Member = "get_inverse", ReturnType = typeof(Matrix4x4))]
	[Calls(Type = typeof(GL), Member = "GetGPUProjectionMatrix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Matrix4x4), typeof(bool)}, ReturnType = typeof(Matrix4x4))]
	[Calls(Type = typeof(Span`1), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Span`1<T>"}, ReturnType = "System.ReadOnlySpan`1<T>")]
	[Calls(Type = typeof(GPUResidentDrawer), Member = "UpdateInstanceOccluders", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(OccluderParameters&), typeof(System.ReadOnlySpan`1<UnityEngine.Rendering.OccluderSubviewUpdate>)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	[ContainsUnimplementedInstructions]
	private void UpdateInstanceOccluders(RenderGraph renderGraph, UniversalCameraData cameraData, TextureHandle depthTexture) { }

}

