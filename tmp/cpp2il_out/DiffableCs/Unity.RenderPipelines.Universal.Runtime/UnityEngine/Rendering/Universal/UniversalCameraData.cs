namespace UnityEngine.Rendering.Universal;

public class UniversalCameraData : ContextItem
{
	private Matrix4x4 m_ViewMatrix; //Field offset: 0x10
	private Matrix4x4 m_ProjectionMatrix; //Field offset: 0x50
	private Matrix4x4 m_JitterMatrix; //Field offset: 0x90
	private bool m_CachedRenderIntoTextureXR; //Field offset: 0xD0
	private bool m_InitBuiltinXRConstants; //Field offset: 0xD1
	public Camera camera; //Field offset: 0xD8
	internal UniversalCameraHistory m_HistoryManager; //Field offset: 0xE0
	public CameraRenderType renderType; //Field offset: 0xE8
	public RenderTexture targetTexture; //Field offset: 0xF0
	public RenderTextureDescriptor cameraTargetDescriptor; //Field offset: 0xF8
	internal Rect pixelRect; //Field offset: 0x12C
	internal bool useScreenCoordOverride; //Field offset: 0x13C
	internal Vector4 screenSizeOverride; //Field offset: 0x140
	internal Vector4 screenCoordScaleBias; //Field offset: 0x150
	internal int pixelWidth; //Field offset: 0x160
	internal int pixelHeight; //Field offset: 0x164
	internal float aspectRatio; //Field offset: 0x168
	public float renderScale; //Field offset: 0x16C
	internal ImageScalingMode imageScalingMode; //Field offset: 0x170
	internal ImageUpscalingFilter upscalingFilter; //Field offset: 0x174
	internal bool fsrOverrideSharpness; //Field offset: 0x178
	internal float fsrSharpness; //Field offset: 0x17C
	internal HDRColorBufferPrecision hdrColorBufferPrecision; //Field offset: 0x180
	public bool clearDepth; //Field offset: 0x184
	public CameraType cameraType; //Field offset: 0x188
	public bool isDefaultViewport; //Field offset: 0x18C
	public bool isHdrEnabled; //Field offset: 0x18D
	public bool allowHDROutput; //Field offset: 0x18E
	public bool isAlphaOutputEnabled; //Field offset: 0x18F
	public bool requiresDepthTexture; //Field offset: 0x190
	public bool requiresOpaqueTexture; //Field offset: 0x191
	public bool postProcessingRequiresDepthTexture; //Field offset: 0x192
	public bool xrRendering; //Field offset: 0x193
	internal bool useGPUOcclusionCulling; //Field offset: 0x194
	internal bool stackLastCameraOutputToHDR; //Field offset: 0x195
	public SortingCriteria defaultOpaqueSortFlags; //Field offset: 0x198
	[CompilerGenerated]
	private XRPass <xr>k__BackingField; //Field offset: 0x1A0
	public float maxShadowDistance; //Field offset: 0x1A8
	public bool postProcessEnabled; //Field offset: 0x1AC
	internal bool stackAnyPostProcessingEnabled; //Field offset: 0x1AD
	public IEnumerator<Action`2<RenderTargetIdentifier, CommandBuffer>> captureActions; //Field offset: 0x1B0
	public LayerMask volumeLayerMask; //Field offset: 0x1B8
	public Transform volumeTrigger; //Field offset: 0x1C0
	public bool isStopNaNEnabled; //Field offset: 0x1C8
	public bool isDitheringEnabled; //Field offset: 0x1C9
	public AntialiasingMode antialiasing; //Field offset: 0x1CC
	public AntialiasingQuality antialiasingQuality; //Field offset: 0x1D0
	public ScriptableRenderer renderer; //Field offset: 0x1D8
	public bool resolveFinalTarget; //Field offset: 0x1E0
	public Vector3 worldSpaceCameraPos; //Field offset: 0x1E4
	public Color backgroundColor; //Field offset: 0x1F0
	internal TaaHistory taaHistory; //Field offset: 0x200
	internal StpHistory stpHistory; //Field offset: 0x208
	internal Settings taaSettings; //Field offset: 0x210
	public Camera baseCamera; //Field offset: 0x230
	internal bool isLastBaseCamera; //Field offset: 0x238

	public ColorGamut hdrDisplayColorGamut
	{
		[CalledBy(Type = typeof(HDRDebugViewPass), Member = "GetLuminanceParameters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UniversalCameraData)}, ReturnType = typeof(Vector4))]
		[CalledBy(Type = typeof(FinalBlitPass), Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(ContextContainer), typeof(UniversalCameraData), typeof(TextureHandle&), typeof(TextureHandle&), typeof(TextureHandle)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(FinalBlitPass), Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), typeof(RenderingData&)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.Internal.FinalBlitPass+<>c", Member = "<Render>b__17_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.Internal.FinalBlitPass+PassData", typeof(RasterGraphContext)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(CameraData), Member = "get_hdrDisplayColorGamut", ReturnType = typeof(ColorGamut))]
		[CalledBy(Type = typeof(PostProcessPass), Member = "RenderPostProcessingRenderGraph", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(ContextContainer), typeof(TextureHandle&), typeof(TextureHandle&), typeof(TextureHandle&), typeof(TextureHandle&), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ColorGradingLutPass), Member = "ExecutePass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RasterCommandBuffer), "UnityEngine.Rendering.Universal.Internal.ColorGradingLutPass+PassData", typeof(RTHandle)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(PostProcessPass), Member = "RenderFinalSetup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(UniversalCameraData), typeof(TextureHandle&), typeof(TextureHandle&), typeof(FinalBlitSettings&)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(PostProcessPass), Member = "RenderFinalPass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(RenderingData&)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(PostProcessPass), Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(RenderingData&)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(HDRDebugViewPass), Member = "ExecuteHDRDebugViewFinalPass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RasterCommandBuffer), "UnityEngine.Rendering.Universal.HDRDebugViewPass+PassDataDebugView", typeof(RTHandle), typeof(RTHandle), typeof(RTHandle)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(PostProcessPass), Member = "RenderFinalPassRenderGraph", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(ContextContainer), typeof(TextureHandle&), typeof(TextureHandle&), typeof(TextureHandle&), typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 15)]
		[Calls(Type = typeof(XRPass), Member = "get_hdrDisplayOutputColorGamut", ReturnType = typeof(ColorGamut))]
		[Calls(Type = typeof(XRPass), Member = "get_enabled", ReturnType = typeof(bool))]
		[Calls(Type = typeof(HDROutputSettings), Member = "get_main", ReturnType = typeof(HDROutputSettings))]
		[Calls(Type = typeof(HDROutputSettings), Member = "get_displayColorGamut", ReturnType = typeof(ColorGamut))]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 137
	}

	public HDRDisplayInformation hdrDisplayInformation
	{
		[CalledBy(Type = typeof(PostProcessPass), Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(RenderingData&)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(PostProcessPass), Member = "RenderFinalPass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(RenderingData&)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(PostProcessPass), Member = "RenderFinalSetup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(UniversalCameraData), typeof(TextureHandle&), typeof(TextureHandle&), typeof(FinalBlitSettings&)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(PostProcessPass), Member = "RenderFinalPassRenderGraph", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(ContextContainer), typeof(TextureHandle&), typeof(TextureHandle&), typeof(TextureHandle&), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(PostProcessPass), Member = "RenderPostProcessingRenderGraph", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(ContextContainer), typeof(TextureHandle&), typeof(TextureHandle&), typeof(TextureHandle&), typeof(TextureHandle&), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(CameraData), Member = "get_hdrDisplayInformation", ReturnType = typeof(HDRDisplayInformation))]
		[CalledBy(Type = typeof(ColorGradingLutPass), Member = "ExecutePass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RasterCommandBuffer), "UnityEngine.Rendering.Universal.Internal.ColorGradingLutPass+PassData", typeof(RTHandle)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(FinalBlitPass), Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), typeof(RenderingData&)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(FinalBlitPass), Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(ContextContainer), typeof(UniversalCameraData), typeof(TextureHandle&), typeof(TextureHandle&), typeof(TextureHandle)}, ReturnType = typeof(void))]
		[CallerCount(Count = 10)]
		[Calls(Type = typeof(XRPass), Member = "get_enabled", ReturnType = typeof(bool))]
		[Calls(Type = typeof(HDROutputSettings), Member = "get_main", ReturnType = typeof(HDROutputSettings))]
		[Calls(Type = typeof(HDROutputSettings), Member = "get_maxFullFrameToneMapLuminance", ReturnType = typeof(int))]
		[Calls(Type = typeof(HDROutputSettings), Member = "get_maxToneMapLuminance", ReturnType = typeof(int))]
		[Calls(Type = typeof(HDROutputSettings), Member = "get_minToneMapLuminance", ReturnType = typeof(int))]
		[Calls(Type = typeof(HDROutputSettings), Member = "get_paperWhiteNits", ReturnType = typeof(float))]
		[Calls(Type = typeof(HDRDisplayInformation), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(float)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(XRPass), Member = "get_hdrDisplayOutputInformation", ReturnType = typeof(HDRDisplayInformation))]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 299
	}

	public UniversalCameraHistory historyManager
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 8
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 set { } //Length: 19
	}

	public bool isGameCamera
	{
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 11
	}

	public bool isHDROutputActive
	{
		[CalledBy(Type = typeof(HDRDebugViewPass), Member = "GetLuminanceParameters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UniversalCameraData)}, ReturnType = typeof(Vector4))]
		[CalledBy(Type = typeof(FinalBlitPass), Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(ContextContainer), typeof(UniversalCameraData), typeof(TextureHandle&), typeof(TextureHandle&), typeof(TextureHandle)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ColorGradingLutPass), Member = "ExecutePass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RasterCommandBuffer), "UnityEngine.Rendering.Universal.Internal.ColorGradingLutPass+PassData", typeof(RTHandle)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UniversalRenderer), Member = "OnAfterRendering", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(CameraData), Member = "get_isHDROutputActive", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(UniversalRenderPipeline), Member = "InitializeAdditionalCameraData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(UniversalAdditionalCameraData), typeof(bool), typeof(bool), typeof(UniversalCameraData)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UniversalRenderer), Member = "OnMainRendering", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(ScriptableRenderContext)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(PostProcessPass), Member = "RenderFinalPassRenderGraph", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(ContextContainer), typeof(TextureHandle&), typeof(TextureHandle&), typeof(TextureHandle&), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(PostProcessPass), Member = "RenderFinalPass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(RenderingData&)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(PostProcessPass), Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(RenderingData&)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(PostProcessPass), Member = "RequireHDROutput", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UniversalCameraData)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(HDRDebugViewPass), Member = "ExecuteHDRDebugViewFinalPass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RasterCommandBuffer), "UnityEngine.Rendering.Universal.HDRDebugViewPass+PassDataDebugView", typeof(RTHandle), typeof(RTHandle), typeof(RTHandle)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(PostProcessPass), Member = "RenderPostProcessingRenderGraph", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(ContextContainer), typeof(TextureHandle&), typeof(TextureHandle&), typeof(TextureHandle&), typeof(TextureHandle&), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 14)]
		[Calls(Type = typeof(UniversalCameraData), Member = "get_resolveToScreen", ReturnType = typeof(bool))]
		[Calls(Type = typeof(UniversalRenderPipeline), Member = "HDROutputForMainDisplayIsActive", ReturnType = typeof(bool))]
		[Calls(Type = typeof(XRPass), Member = "get_enabled", ReturnType = typeof(bool))]
		[Calls(Type = typeof(XRPass), Member = "get_isHDRDisplayOutputActive", ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 169
	}

	public bool isPreviewCamera
	{
		[CalledBy(Type = typeof(UniversalRenderer), Member = "SetupFinalPassDebug", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UniversalCameraData)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UniversalRenderer), Member = "RequiresIntermediateAttachments", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UniversalCameraData), typeof(RenderPassInputSummary&)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(UniversalRenderer), Member = "SetupAfterPostRenderGraphFinalPassDebug", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(ContextContainer)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UniversalRenderer), Member = "SetupRenderGraphFinalPassDebug", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(ContextContainer)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UniversalRenderer), Member = "DebugHandlerRequireDepthPass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UniversalCameraData)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(UniversalRenderer), Member = "Setup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), typeof(RenderingData&)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UniversalRenderer), Member = "RequireDepthTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UniversalCameraData), typeof(bool), typeof(RenderPassInputSummary&)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(UniversalRenderer), Member = "CreateRenderGraphCameraRenderTargets", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(CameraData), Member = "get_isPreviewCamera", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(ScriptableRenderer), Member = "SetRenderPassAttachments", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(ScriptableRenderPass), typeof(UniversalCameraData)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ScriptableRenderer), Member = "GetCameraClearFlag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UniversalCameraData)}, ReturnType = typeof(ClearFlag))]
		[CalledBy(Type = typeof(ScriptableRenderPass), Member = "GetActiveDebugHandler", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UniversalCameraData)}, ReturnType = typeof(DebugHandler))]
		[CalledBy(Type = typeof(DebugHandler), Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(UniversalCameraData), typeof(TextureHandle), typeof(TextureHandle), typeof(TextureHandle)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DebugHandler), Member = "UpdateShaderGlobalPropertiesForFinalValidationPass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(UniversalCameraData), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DebugHandler), Member = "InitDebugFinalValidationPassData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.DebugHandler+DebugFinalValidationPassData", typeof(UniversalCameraData), typeof(bool)}, ReturnType = "UnityEngine.Rendering.Universal.DebugHandler+DebugFinalValidationPassData")]
		[CalledBy(Type = typeof(UniversalRenderPipeline), Member = "CheckAndApplyDebugSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderingData&)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UniversalRenderer), Member = "CalculateTextureCopySchedules", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UniversalCameraData), "UnityEngine.Rendering.Universal.UniversalRenderer+RenderPassInputSummary", typeof(bool), typeof(bool), typeof(bool)}, ReturnType = "UnityEngine.Rendering.Universal.UniversalRenderer+TextureCopySchedules")]
		[CallerCount(Count = 21)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 11
	}

	internal bool isRenderPassSupportedCamera
	{
		[CalledBy(Type = typeof(ScriptableRenderer), Member = "ExecuteRenderPass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), typeof(ScriptableRenderPass), typeof(UniversalCameraData), typeof(RenderingData&)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ScriptableRenderer), Member = "SetRenderPassAttachments", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(ScriptableRenderPass), typeof(UniversalCameraData)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(CameraData), Member = "get_isRenderPassSupportedCamera", ReturnType = typeof(bool))]
		[CallerCount(Count = 7)]
		[ContainsUnimplementedInstructions]
		internal get { } //Length: 23
	}

	public bool isSceneViewCamera
	{
		[CalledBy(Type = typeof(CameraData), Member = "get_isSceneViewCamera", ReturnType = typeof(bool))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.PostProcessPass+<>c", Member = "<RenderFinalBlit>b__160_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.PostProcessPass+PostProcessingFinalBlitPassData", typeof(RasterGraphContext)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(PostProcessPass), Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(RenderingData&)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(PostProcessPass), Member = "RenderPostProcessingRenderGraph", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(ContextContainer), typeof(TextureHandle&), typeof(TextureHandle&), typeof(TextureHandle&), typeof(TextureHandle&), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(RenderingUtils), Member = "FinalBlit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(UniversalCameraData), typeof(RTHandle), typeof(RTHandle), typeof(RenderBufferLoadAction), typeof(RenderBufferStoreAction), typeof(Material), typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UniversalRenderPipeline), Member = "RenderSingleCamera", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), typeof(UniversalCameraData)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UniversalRenderPipeline), Member = "InitializeStackedCameraData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(UniversalAdditionalCameraData), typeof(UniversalCameraData)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UniversalRenderPipeline), Member = "InitializeAdditionalCameraData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(UniversalAdditionalCameraData), typeof(bool), typeof(bool), typeof(UniversalCameraData)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(FinalBlitPass), Member = "ExecutePass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RasterCommandBuffer), "UnityEngine.Rendering.Universal.Internal.FinalBlitPass+PassData", typeof(RTHandle), typeof(RTHandle), typeof(UniversalCameraData)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UniversalRenderer), Member = "Setup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), typeof(RenderingData&)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UniversalRenderer), Member = "RequiresIntermediateColorTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UniversalCameraData), typeof(RenderPassInputSummary&)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(UniversalRenderer), Member = "CreateRenderGraphCameraRenderTargets", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UniversalRenderer), Member = "OnMainRendering", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(ScriptableRenderContext)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UniversalRenderer), Member = "OnAfterRendering", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(FinalBlitPass), Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), typeof(RenderingData&)}, ReturnType = typeof(void))]
		[CallerCount(Count = 18)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 11
	}

	public bool rendersOverlayUI
	{
		[CalledBy(Type = typeof(PostProcessPass), Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(RenderingData&)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(PostProcessPass), Member = "RenderFinalPass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(RenderingData&)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(PostProcessPass), Member = "RenderFinalSetup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(UniversalCameraData), typeof(TextureHandle&), typeof(TextureHandle&), typeof(FinalBlitSettings&)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(PostProcessPass), Member = "RenderFinalBlit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(UniversalCameraData), typeof(TextureHandle&), typeof(TextureHandle&), typeof(TextureHandle&), typeof(FinalBlitSettings&)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(PostProcessPass), Member = "RenderFinalPassRenderGraph", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(ContextContainer), typeof(TextureHandle&), typeof(TextureHandle&), typeof(TextureHandle&), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(PostProcessPass), Member = "RenderPostProcessingRenderGraph", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(ContextContainer), typeof(TextureHandle&), typeof(TextureHandle&), typeof(TextureHandle&), typeof(TextureHandle&), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(CameraData), Member = "get_rendersOverlayUI", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(UniversalRenderer), Member = "OnMainRendering", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(ScriptableRenderContext)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UniversalRenderer), Member = "OnAfterRendering", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.Internal.FinalBlitPass+<>c", Member = "<Render>b__17_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.Internal.FinalBlitPass+PassData", typeof(RasterGraphContext)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(FinalBlitPass), Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), typeof(RenderingData&)}, ReturnType = typeof(void))]
		[CallerCount(Count = 12)]
		[Calls(Type = typeof(SupportedRenderingFeatures), Member = "get_active", ReturnType = typeof(SupportedRenderingFeatures))]
		[Calls(Type = typeof(UniversalCameraData), Member = "get_resolveToScreen", ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 104
	}

	internal bool requireSrgbConversion
	{
		[CalledBy(Type = typeof(FinalBlitPass), Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(ContextContainer), typeof(UniversalCameraData), typeof(TextureHandle&), typeof(TextureHandle&), typeof(TextureHandle)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(PostProcessPass), Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(RenderingData&)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(PostProcessPass), Member = "RenderFinalPassRenderGraph", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(ContextContainer), typeof(TextureHandle&), typeof(TextureHandle&), typeof(TextureHandle&), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(PostProcessPass), Member = "RenderPostProcessingRenderGraph", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(ContextContainer), typeof(TextureHandle&), typeof(TextureHandle&), typeof(TextureHandle&), typeof(TextureHandle&), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(CameraData), Member = "get_requireSrgbConversion", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(UniversalRenderer), Member = "RequiresIntermediateColorTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UniversalCameraData), typeof(RenderPassInputSummary&)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(FinalBlitPass), Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), typeof(RenderingData&)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(FinalBlitPass), Member = "InitPassData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UniversalCameraData), typeof(PassData&), "UnityEngine.Rendering.Universal.Internal.FinalBlitPass+BlitType", typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 9)]
		[Calls(Type = typeof(XRPass), Member = "get_enabled", ReturnType = typeof(bool))]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Display), Member = "get_main", ReturnType = typeof(Display))]
		[Calls(Type = typeof(Display), Member = "get_requiresSrgbBlitToBackbuffer", ReturnType = typeof(bool))]
		[Calls(Type = typeof(RenderTextureDescriptor), Member = "get_sRGB", ReturnType = typeof(bool))]
		[Calls(Type = typeof(QualitySettings), Member = "get_activeColorSpace", ReturnType = typeof(ColorSpace))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		internal get { } //Length: 443
	}

	internal bool resetHistory
	{
		[CalledBy(Type = typeof(StpUtils), Member = "PopulateStpConfig", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UniversalCameraData), typeof(TextureHandle), typeof(TextureHandle), typeof(TextureHandle), typeof(int), typeof(TextureHandle), typeof(TextureHandle), typeof(Texture2D), typeof(Config&)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(CameraData), Member = "get_resetHistory", ReturnType = typeof(bool))]
		[CallerCount(Count = 2)]
		[ContainsUnimplementedInstructions]
		internal get { } //Length: 11
	}

	internal bool resolveToScreen
	{
		[CalledBy(Type = typeof(UniversalCameraData), Member = "get_isHDROutputActive", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(UniversalCameraData), Member = "get_rendersOverlayUI", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(HDRDebugViewPass), Member = "ExecuteHDRDebugViewFinalPass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RasterCommandBuffer), "UnityEngine.Rendering.Universal.HDRDebugViewPass+PassDataDebugView", typeof(RTHandle), typeof(RTHandle), typeof(RTHandle)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(CameraData), Member = "get_resolveToScreen", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(UniversalRenderer), Member = "CreateRenderGraphCameraRenderTargets", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 5)]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Camera), Member = "get_cameraType", ReturnType = typeof(CameraType))]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		internal get { } //Length: 171
	}

	public int scaledHeight
	{
		[CalledBy(Type = typeof(ScriptableRenderer), Member = "GetRenderTextureDescriptor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UniversalCameraData), typeof(ScriptableRenderPass), typeof(RenderTextureDescriptor&)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UniversalRenderPipeline), Member = "CreateRenderTextureDescriptor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(UniversalCameraData), typeof(bool), typeof(HDRColorBufferPrecision), typeof(int), typeof(bool), typeof(bool)}, ReturnType = typeof(RenderTextureDescriptor))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(Camera), Member = "get_pixelHeight", ReturnType = typeof(int))]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 68
	}

	public int scaledWidth
	{
		[CalledBy(Type = typeof(ScriptableRenderer), Member = "GetRenderTextureDescriptor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UniversalCameraData), typeof(ScriptableRenderPass), typeof(RenderTextureDescriptor&)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UniversalRenderPipeline), Member = "CreateRenderTextureDescriptor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(UniversalCameraData), typeof(bool), typeof(HDRColorBufferPrecision), typeof(int), typeof(bool), typeof(bool)}, ReturnType = typeof(RenderTextureDescriptor))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(Camera), Member = "get_pixelWidth", ReturnType = typeof(int))]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 68
	}

	public internal XRPass xr
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 8
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		internal set { } //Length: 19
	}

	internal XRPassUniversal xrUniversal
	{
		[CalledBy(Type = "UnityEngine.Rendering.Universal.ScriptableRenderer+<>c", Member = "<BeginRenderGraphXRRendering>b__149_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.ScriptableRenderer+BeginXRPassData", typeof(RasterGraphContext)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DrawObjectsPass), Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(ContextContainer), typeof(TextureHandle), typeof(TextureHandle), typeof(TextureHandle), typeof(TextureHandle), typeof(uint)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DepthOnlyPass), Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(ContextContainer), typeof(TextureHandle&), typeof(uint), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DepthNormalOnlyPass), Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(ContextContainer), typeof(TextureHandle), typeof(TextureHandle), typeof(TextureHandle), typeof(uint), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(CameraData), Member = "get_xrUniversal", ReturnType = typeof(XRPassUniversal))]
		[CalledBy(Type = typeof(XROcclusionMeshPass), Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(ContextContainer), typeof(TextureHandle&), typeof(TextureHandle&)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(RenderObjectsPass), Member = "RecordRenderGraph", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(ContextContainer)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DrawObjectsWithRenderingLayersPass), Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(ContextContainer), typeof(TextureHandle), typeof(TextureHandle), typeof(TextureHandle), typeof(TextureHandle), typeof(TextureHandle), typeof(MaskSize), typeof(uint)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(PostProcessPass), Member = "RenderUberPost", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(ContextContainer), typeof(UniversalCameraData), typeof(UniversalPostProcessingData), typeof(TextureHandle&), typeof(TextureHandle&), typeof(TextureHandle&), typeof(TextureHandle&), typeof(bool), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DrawSkyboxPass), Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(ContextContainer), typeof(ScriptableRenderContext), typeof(TextureHandle), typeof(TextureHandle), typeof(Material)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ScriptableRenderer), Member = "SetRenderPassAttachments", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(ScriptableRenderPass), typeof(UniversalCameraData)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ScriptableRenderer), Member = "ExecuteRenderPass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), typeof(ScriptableRenderPass), typeof(UniversalCameraData), typeof(RenderingData&)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ScriptableRenderer), Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), typeof(RenderingData&)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ScriptableRenderer), Member = "BeginRenderGraphXRRendering", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ScriptableRenderer), Member = "SetCameraMatrices", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RasterCommandBuffer), typeof(UniversalCameraData), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(MotionVectorRenderPass), Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(ContextContainer), typeof(TextureHandle), typeof(TextureHandle), typeof(TextureHandle)}, ReturnType = typeof(void))]
		[CallerCount(Count = 17)]
		internal get { } //Length: 117
	}

	[CallerCount(Count = 162)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public UniversalCameraData() { }

	[CalledBy(Type = typeof(HDRDebugViewPass), Member = "GetLuminanceParameters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UniversalCameraData)}, ReturnType = typeof(Vector4))]
	[CalledBy(Type = typeof(PostProcessPass), Member = "RenderFinalPassRenderGraph", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(ContextContainer), typeof(TextureHandle&), typeof(TextureHandle&), typeof(TextureHandle&), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(HDRDebugViewPass), Member = "ExecuteHDRDebugViewFinalPass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RasterCommandBuffer), "UnityEngine.Rendering.Universal.HDRDebugViewPass+PassDataDebugView", typeof(RTHandle), typeof(RTHandle), typeof(RTHandle)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PostProcessPass), Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(RenderingData&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PostProcessPass), Member = "RenderFinalSetup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(UniversalCameraData), typeof(TextureHandle&), typeof(TextureHandle&), typeof(FinalBlitSettings&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ColorGradingLutPass), Member = "ExecutePass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RasterCommandBuffer), "UnityEngine.Rendering.Universal.Internal.ColorGradingLutPass+PassData", typeof(RTHandle)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PostProcessPass), Member = "RenderFinalPass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(RenderingData&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CameraData), Member = "get_hdrDisplayColorGamut", ReturnType = typeof(ColorGamut))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.Internal.FinalBlitPass+<>c", Member = "<Render>b__17_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.Internal.FinalBlitPass+PassData", typeof(RasterGraphContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FinalBlitPass), Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), typeof(RenderingData&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FinalBlitPass), Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(ContextContainer), typeof(UniversalCameraData), typeof(TextureHandle&), typeof(TextureHandle&), typeof(TextureHandle)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PostProcessPass), Member = "RenderPostProcessingRenderGraph", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(ContextContainer), typeof(TextureHandle&), typeof(TextureHandle&), typeof(TextureHandle&), typeof(TextureHandle&), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 15)]
	[Calls(Type = typeof(HDROutputSettings), Member = "get_displayColorGamut", ReturnType = typeof(ColorGamut))]
	[Calls(Type = typeof(XRPass), Member = "get_hdrDisplayOutputColorGamut", ReturnType = typeof(ColorGamut))]
	[Calls(Type = typeof(XRPass), Member = "get_enabled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(HDROutputSettings), Member = "get_main", ReturnType = typeof(HDROutputSettings))]
	[CallsUnknownMethods(Count = 1)]
	public ColorGamut get_hdrDisplayColorGamut() { }

	[CalledBy(Type = typeof(PostProcessPass), Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(RenderingData&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PostProcessPass), Member = "RenderFinalPass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(RenderingData&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PostProcessPass), Member = "RenderFinalSetup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(UniversalCameraData), typeof(TextureHandle&), typeof(TextureHandle&), typeof(FinalBlitSettings&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PostProcessPass), Member = "RenderFinalPassRenderGraph", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(ContextContainer), typeof(TextureHandle&), typeof(TextureHandle&), typeof(TextureHandle&), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PostProcessPass), Member = "RenderPostProcessingRenderGraph", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(ContextContainer), typeof(TextureHandle&), typeof(TextureHandle&), typeof(TextureHandle&), typeof(TextureHandle&), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CameraData), Member = "get_hdrDisplayInformation", ReturnType = typeof(HDRDisplayInformation))]
	[CalledBy(Type = typeof(ColorGradingLutPass), Member = "ExecutePass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RasterCommandBuffer), "UnityEngine.Rendering.Universal.Internal.ColorGradingLutPass+PassData", typeof(RTHandle)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FinalBlitPass), Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), typeof(RenderingData&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FinalBlitPass), Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(ContextContainer), typeof(UniversalCameraData), typeof(TextureHandle&), typeof(TextureHandle&), typeof(TextureHandle)}, ReturnType = typeof(void))]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(XRPass), Member = "get_enabled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(HDROutputSettings), Member = "get_main", ReturnType = typeof(HDROutputSettings))]
	[Calls(Type = typeof(HDROutputSettings), Member = "get_maxFullFrameToneMapLuminance", ReturnType = typeof(int))]
	[Calls(Type = typeof(HDROutputSettings), Member = "get_maxToneMapLuminance", ReturnType = typeof(int))]
	[Calls(Type = typeof(HDROutputSettings), Member = "get_minToneMapLuminance", ReturnType = typeof(int))]
	[Calls(Type = typeof(HDROutputSettings), Member = "get_paperWhiteNits", ReturnType = typeof(float))]
	[Calls(Type = typeof(HDRDisplayInformation), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XRPass), Member = "get_hdrDisplayOutputInformation", ReturnType = typeof(HDRDisplayInformation))]
	[CallsUnknownMethods(Count = 1)]
	public HDRDisplayInformation get_hdrDisplayInformation() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public UniversalCameraHistory get_historyManager() { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public bool get_isGameCamera() { }

	[CalledBy(Type = typeof(HDRDebugViewPass), Member = "GetLuminanceParameters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UniversalCameraData)}, ReturnType = typeof(Vector4))]
	[CalledBy(Type = typeof(PostProcessPass), Member = "RenderPostProcessingRenderGraph", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(ContextContainer), typeof(TextureHandle&), typeof(TextureHandle&), typeof(TextureHandle&), typeof(TextureHandle&), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(HDRDebugViewPass), Member = "ExecuteHDRDebugViewFinalPass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RasterCommandBuffer), "UnityEngine.Rendering.Universal.HDRDebugViewPass+PassDataDebugView", typeof(RTHandle), typeof(RTHandle), typeof(RTHandle)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PostProcessPass), Member = "RequireHDROutput", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UniversalCameraData)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(PostProcessPass), Member = "RenderFinalPass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(RenderingData&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PostProcessPass), Member = "RenderFinalPassRenderGraph", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(ContextContainer), typeof(TextureHandle&), typeof(TextureHandle&), typeof(TextureHandle&), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PostProcessPass), Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(RenderingData&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalRenderPipeline), Member = "InitializeAdditionalCameraData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(UniversalAdditionalCameraData), typeof(bool), typeof(bool), typeof(UniversalCameraData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CameraData), Member = "get_isHDROutputActive", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(UniversalRenderer), Member = "OnAfterRendering", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ColorGradingLutPass), Member = "ExecutePass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RasterCommandBuffer), "UnityEngine.Rendering.Universal.Internal.ColorGradingLutPass+PassData", typeof(RTHandle)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FinalBlitPass), Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(ContextContainer), typeof(UniversalCameraData), typeof(TextureHandle&), typeof(TextureHandle&), typeof(TextureHandle)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalRenderer), Member = "OnMainRendering", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(ScriptableRenderContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 14)]
	[Calls(Type = typeof(XRPass), Member = "get_isHDRDisplayOutputActive", ReturnType = typeof(bool))]
	[Calls(Type = typeof(UniversalCameraData), Member = "get_resolveToScreen", ReturnType = typeof(bool))]
	[Calls(Type = typeof(UniversalRenderPipeline), Member = "HDROutputForMainDisplayIsActive", ReturnType = typeof(bool))]
	[Calls(Type = typeof(XRPass), Member = "get_enabled", ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	public bool get_isHDROutputActive() { }

	[CalledBy(Type = typeof(UniversalRenderer), Member = "SetupFinalPassDebug", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UniversalCameraData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalRenderer), Member = "CalculateTextureCopySchedules", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UniversalCameraData), "UnityEngine.Rendering.Universal.UniversalRenderer+RenderPassInputSummary", typeof(bool), typeof(bool), typeof(bool)}, ReturnType = "UnityEngine.Rendering.Universal.UniversalRenderer+TextureCopySchedules")]
	[CalledBy(Type = typeof(UniversalRenderPipeline), Member = "CheckAndApplyDebugSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderingData&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DebugHandler), Member = "InitDebugFinalValidationPassData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.DebugHandler+DebugFinalValidationPassData", typeof(UniversalCameraData), typeof(bool)}, ReturnType = "UnityEngine.Rendering.Universal.DebugHandler+DebugFinalValidationPassData")]
	[CalledBy(Type = typeof(DebugHandler), Member = "UpdateShaderGlobalPropertiesForFinalValidationPass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(UniversalCameraData), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DebugHandler), Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(UniversalCameraData), typeof(TextureHandle), typeof(TextureHandle), typeof(TextureHandle)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScriptableRenderPass), Member = "GetActiveDebugHandler", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UniversalCameraData)}, ReturnType = typeof(DebugHandler))]
	[CalledBy(Type = typeof(ScriptableRenderer), Member = "GetCameraClearFlag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UniversalCameraData)}, ReturnType = typeof(ClearFlag))]
	[CalledBy(Type = typeof(ScriptableRenderer), Member = "SetRenderPassAttachments", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(ScriptableRenderPass), typeof(UniversalCameraData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalRenderer), Member = "CreateRenderGraphCameraRenderTargets", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalRenderer), Member = "RequireDepthTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UniversalCameraData), typeof(bool), typeof(RenderPassInputSummary&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(UniversalRenderer), Member = "Setup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), typeof(RenderingData&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalRenderer), Member = "DebugHandlerRequireDepthPass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UniversalCameraData)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(UniversalRenderer), Member = "SetupRenderGraphFinalPassDebug", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(ContextContainer)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalRenderer), Member = "SetupAfterPostRenderGraphFinalPassDebug", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(ContextContainer)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalRenderer), Member = "RequiresIntermediateAttachments", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UniversalCameraData), typeof(RenderPassInputSummary&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(CameraData), Member = "get_isPreviewCamera", ReturnType = typeof(bool))]
	[CallerCount(Count = 21)]
	[ContainsUnimplementedInstructions]
	public bool get_isPreviewCamera() { }

	[CalledBy(Type = typeof(ScriptableRenderer), Member = "ExecuteRenderPass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), typeof(ScriptableRenderPass), typeof(UniversalCameraData), typeof(RenderingData&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScriptableRenderer), Member = "SetRenderPassAttachments", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(ScriptableRenderPass), typeof(UniversalCameraData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CameraData), Member = "get_isRenderPassSupportedCamera", ReturnType = typeof(bool))]
	[CallerCount(Count = 7)]
	[ContainsUnimplementedInstructions]
	internal bool get_isRenderPassSupportedCamera() { }

	[CalledBy(Type = typeof(CameraData), Member = "get_isSceneViewCamera", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(FinalBlitPass), Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), typeof(RenderingData&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalRenderer), Member = "OnAfterRendering", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalRenderer), Member = "OnMainRendering", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(ScriptableRenderContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalRenderer), Member = "CreateRenderGraphCameraRenderTargets", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalRenderer), Member = "RequiresIntermediateColorTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UniversalCameraData), typeof(RenderPassInputSummary&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(UniversalRenderer), Member = "Setup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), typeof(RenderingData&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FinalBlitPass), Member = "ExecutePass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RasterCommandBuffer), "UnityEngine.Rendering.Universal.Internal.FinalBlitPass+PassData", typeof(RTHandle), typeof(RTHandle), typeof(UniversalCameraData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalRenderPipeline), Member = "InitializeStackedCameraData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(UniversalAdditionalCameraData), typeof(UniversalCameraData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalRenderPipeline), Member = "RenderSingleCamera", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), typeof(UniversalCameraData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RenderingUtils), Member = "FinalBlit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(UniversalCameraData), typeof(RTHandle), typeof(RTHandle), typeof(RenderBufferLoadAction), typeof(RenderBufferStoreAction), typeof(Material), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PostProcessPass), Member = "RenderPostProcessingRenderGraph", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(ContextContainer), typeof(TextureHandle&), typeof(TextureHandle&), typeof(TextureHandle&), typeof(TextureHandle&), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PostProcessPass), Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(RenderingData&)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.PostProcessPass+<>c", Member = "<RenderFinalBlit>b__160_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.PostProcessPass+PostProcessingFinalBlitPassData", typeof(RasterGraphContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalRenderPipeline), Member = "InitializeAdditionalCameraData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(UniversalAdditionalCameraData), typeof(bool), typeof(bool), typeof(UniversalCameraData)}, ReturnType = typeof(void))]
	[CallerCount(Count = 18)]
	[ContainsUnimplementedInstructions]
	public bool get_isSceneViewCamera() { }

	[CalledBy(Type = typeof(PostProcessPass), Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(RenderingData&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PostProcessPass), Member = "RenderFinalPass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(RenderingData&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PostProcessPass), Member = "RenderFinalSetup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(UniversalCameraData), typeof(TextureHandle&), typeof(TextureHandle&), typeof(FinalBlitSettings&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PostProcessPass), Member = "RenderFinalBlit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(UniversalCameraData), typeof(TextureHandle&), typeof(TextureHandle&), typeof(TextureHandle&), typeof(FinalBlitSettings&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PostProcessPass), Member = "RenderFinalPassRenderGraph", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(ContextContainer), typeof(TextureHandle&), typeof(TextureHandle&), typeof(TextureHandle&), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PostProcessPass), Member = "RenderPostProcessingRenderGraph", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(ContextContainer), typeof(TextureHandle&), typeof(TextureHandle&), typeof(TextureHandle&), typeof(TextureHandle&), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CameraData), Member = "get_rendersOverlayUI", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(UniversalRenderer), Member = "OnMainRendering", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(ScriptableRenderContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalRenderer), Member = "OnAfterRendering", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.Internal.FinalBlitPass+<>c", Member = "<Render>b__17_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.Internal.FinalBlitPass+PassData", typeof(RasterGraphContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FinalBlitPass), Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), typeof(RenderingData&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 12)]
	[Calls(Type = typeof(SupportedRenderingFeatures), Member = "get_active", ReturnType = typeof(SupportedRenderingFeatures))]
	[Calls(Type = typeof(UniversalCameraData), Member = "get_resolveToScreen", ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	public bool get_rendersOverlayUI() { }

	[CalledBy(Type = typeof(FinalBlitPass), Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(ContextContainer), typeof(UniversalCameraData), typeof(TextureHandle&), typeof(TextureHandle&), typeof(TextureHandle)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PostProcessPass), Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(RenderingData&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PostProcessPass), Member = "RenderFinalPassRenderGraph", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(ContextContainer), typeof(TextureHandle&), typeof(TextureHandle&), typeof(TextureHandle&), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PostProcessPass), Member = "RenderPostProcessingRenderGraph", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(ContextContainer), typeof(TextureHandle&), typeof(TextureHandle&), typeof(TextureHandle&), typeof(TextureHandle&), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CameraData), Member = "get_requireSrgbConversion", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(UniversalRenderer), Member = "RequiresIntermediateColorTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UniversalCameraData), typeof(RenderPassInputSummary&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(FinalBlitPass), Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), typeof(RenderingData&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FinalBlitPass), Member = "InitPassData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UniversalCameraData), typeof(PassData&), "UnityEngine.Rendering.Universal.Internal.FinalBlitPass+BlitType", typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(XRPass), Member = "get_enabled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Display), Member = "get_main", ReturnType = typeof(Display))]
	[Calls(Type = typeof(Display), Member = "get_requiresSrgbBlitToBackbuffer", ReturnType = typeof(bool))]
	[Calls(Type = typeof(RenderTextureDescriptor), Member = "get_sRGB", ReturnType = typeof(bool))]
	[Calls(Type = typeof(QualitySettings), Member = "get_activeColorSpace", ReturnType = typeof(ColorSpace))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	internal bool get_requireSrgbConversion() { }

	[CalledBy(Type = typeof(StpUtils), Member = "PopulateStpConfig", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UniversalCameraData), typeof(TextureHandle), typeof(TextureHandle), typeof(TextureHandle), typeof(int), typeof(TextureHandle), typeof(TextureHandle), typeof(Texture2D), typeof(Config&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CameraData), Member = "get_resetHistory", ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[ContainsUnimplementedInstructions]
	internal bool get_resetHistory() { }

	[CalledBy(Type = typeof(UniversalCameraData), Member = "get_isHDROutputActive", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(UniversalCameraData), Member = "get_rendersOverlayUI", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(HDRDebugViewPass), Member = "ExecuteHDRDebugViewFinalPass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RasterCommandBuffer), "UnityEngine.Rendering.Universal.HDRDebugViewPass+PassDataDebugView", typeof(RTHandle), typeof(RTHandle), typeof(RTHandle)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CameraData), Member = "get_resolveToScreen", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(UniversalRenderer), Member = "CreateRenderGraphCameraRenderTargets", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Camera), Member = "get_cameraType", ReturnType = typeof(CameraType))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	internal bool get_resolveToScreen() { }

	[CalledBy(Type = typeof(ScriptableRenderer), Member = "GetRenderTextureDescriptor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UniversalCameraData), typeof(ScriptableRenderPass), typeof(RenderTextureDescriptor&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalRenderPipeline), Member = "CreateRenderTextureDescriptor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(UniversalCameraData), typeof(bool), typeof(HDRColorBufferPrecision), typeof(int), typeof(bool), typeof(bool)}, ReturnType = typeof(RenderTextureDescriptor))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Camera), Member = "get_pixelHeight", ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public int get_scaledHeight() { }

	[CalledBy(Type = typeof(ScriptableRenderer), Member = "GetRenderTextureDescriptor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UniversalCameraData), typeof(ScriptableRenderPass), typeof(RenderTextureDescriptor&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalRenderPipeline), Member = "CreateRenderTextureDescriptor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(UniversalCameraData), typeof(bool), typeof(HDRColorBufferPrecision), typeof(int), typeof(bool), typeof(bool)}, ReturnType = typeof(RenderTextureDescriptor))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Camera), Member = "get_pixelWidth", ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public int get_scaledWidth() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public XRPass get_xr() { }

	[CalledBy(Type = "UnityEngine.Rendering.Universal.ScriptableRenderer+<>c", Member = "<BeginRenderGraphXRRendering>b__149_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.ScriptableRenderer+BeginXRPassData", typeof(RasterGraphContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScriptableRenderer), Member = "SetCameraMatrices", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RasterCommandBuffer), typeof(UniversalCameraData), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScriptableRenderer), Member = "BeginRenderGraphXRRendering", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScriptableRenderer), Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), typeof(RenderingData&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScriptableRenderer), Member = "ExecuteRenderPass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), typeof(ScriptableRenderPass), typeof(UniversalCameraData), typeof(RenderingData&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScriptableRenderer), Member = "SetRenderPassAttachments", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(ScriptableRenderPass), typeof(UniversalCameraData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DrawSkyboxPass), Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(ContextContainer), typeof(ScriptableRenderContext), typeof(TextureHandle), typeof(TextureHandle), typeof(Material)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MotionVectorRenderPass), Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(ContextContainer), typeof(TextureHandle), typeof(TextureHandle), typeof(TextureHandle)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PostProcessPass), Member = "RenderUberPost", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(ContextContainer), typeof(UniversalCameraData), typeof(UniversalPostProcessingData), typeof(TextureHandle&), typeof(TextureHandle&), typeof(TextureHandle&), typeof(TextureHandle&), typeof(bool), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RenderObjectsPass), Member = "RecordRenderGraph", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(ContextContainer)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XROcclusionMeshPass), Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(ContextContainer), typeof(TextureHandle&), typeof(TextureHandle&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CameraData), Member = "get_xrUniversal", ReturnType = typeof(XRPassUniversal))]
	[CalledBy(Type = typeof(DepthNormalOnlyPass), Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(ContextContainer), typeof(TextureHandle), typeof(TextureHandle), typeof(TextureHandle), typeof(uint), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DepthOnlyPass), Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(ContextContainer), typeof(TextureHandle&), typeof(uint), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DrawObjectsPass), Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(ContextContainer), typeof(TextureHandle), typeof(TextureHandle), typeof(TextureHandle), typeof(TextureHandle), typeof(uint)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DrawObjectsWithRenderingLayersPass), Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(ContextContainer), typeof(TextureHandle), typeof(TextureHandle), typeof(TextureHandle), typeof(TextureHandle), typeof(TextureHandle), typeof(MaskSize), typeof(uint)}, ReturnType = typeof(void))]
	[CallerCount(Count = 17)]
	internal XRPassUniversal get_xrUniversal() { }

	[CalledBy(Type = typeof(ScriptableRenderer), Member = "SetCameraMatrices", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RasterCommandBuffer), typeof(UniversalCameraData), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScriptableRenderer), Member = "SetPerCameraClippingPlaneProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RasterCommandBuffer), typeof(UniversalCameraData&), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CameraData), Member = "GetGPUProjectionMatrix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(int)}, ReturnType = typeof(Matrix4x4))]
	[CalledBy(Type = typeof(DeferredLights), Member = "GetScreenToWorldMatrix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UniversalCameraData)}, ReturnType = typeof(Matrix4x4[]))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(UniversalCameraData), Member = "GetProjectionMatrix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Matrix4x4))]
	[Calls(Type = typeof(GL), Member = "GetGPUProjectionMatrix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Matrix4x4), typeof(bool)}, ReturnType = typeof(Matrix4x4))]
	internal Matrix4x4 GetGPUProjectionMatrix(bool renderIntoTexture, int viewIndex = 0) { }

	[CalledBy(Type = typeof(CameraData), Member = "GetGPUProjectionMatrix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Matrix4x4))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(XRPass), Member = "get_enabled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(XRPass), Member = "GetProjMatrix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Matrix4x4))]
	[Calls(Type = typeof(UniversalCameraData), Member = "IsCameraProjectionMatrixFlipped", ReturnType = typeof(bool))]
	[Calls(Type = typeof(GL), Member = "GetGPUProjectionMatrix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Matrix4x4), typeof(bool)}, ReturnType = typeof(Matrix4x4))]
	[Calls(Type = typeof(Matrix4x4), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Matrix4x4), typeof(Matrix4x4)}, ReturnType = typeof(Matrix4x4))]
	[CallsUnknownMethods(Count = 1)]
	public Matrix4x4 GetGPUProjectionMatrix(int viewIndex = 0) { }

	[CalledBy(Type = typeof(CameraData), Member = "GetGPUProjectionMatrixNoJitter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Matrix4x4))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(XRPass), Member = "get_enabled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(XRPass), Member = "GetProjMatrix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Matrix4x4))]
	[Calls(Type = typeof(UniversalCameraData), Member = "IsCameraProjectionMatrixFlipped", ReturnType = typeof(bool))]
	[Calls(Type = typeof(GL), Member = "GetGPUProjectionMatrix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Matrix4x4), typeof(bool)}, ReturnType = typeof(Matrix4x4))]
	[CallsUnknownMethods(Count = 1)]
	public Matrix4x4 GetGPUProjectionMatrixNoJitter(int viewIndex = 0) { }

	[CalledBy(Type = typeof(ScriptableRenderer), Member = "SetCameraMatrices", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RasterCommandBuffer), typeof(UniversalCameraData), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalCameraData), Member = "PushBuiltinShaderConstantsXR", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RasterCommandBuffer), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalCameraData), Member = "GetGPUProjectionMatrix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(int)}, ReturnType = typeof(Matrix4x4))]
	[CalledBy(Type = typeof(DrawSkyboxPass), Member = "CreateSkyboxRendererList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), typeof(UniversalCameraData)}, ReturnType = typeof(RendererList))]
	[CalledBy(Type = typeof(DrawSkyboxPass), Member = "CreateSkyBoxRendererList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(UniversalCameraData)}, ReturnType = typeof(RendererListHandle))]
	[CalledBy(Type = typeof(RenderObjectsPass), Member = "ExecutePass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.RenderObjectsPass+PassData", typeof(RasterCommandBuffer), typeof(RendererList), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScreenSpaceAmbientOcclusionPass), Member = "SetupKeywordsAndParameters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScreenSpaceAmbientOcclusionSettings&), typeof(UniversalCameraData&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CameraData), Member = "GetProjectionMatrix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Matrix4x4))]
	[CalledBy(Type = typeof(UniversalRenderer), Member = "UpdateInstanceOccluders", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(UniversalCameraData), typeof(TextureHandle)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ForwardLights), Member = "PreSetup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UniversalRenderingData), typeof(UniversalCameraData), typeof(UniversalLightData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NormalReconstruction), Member = "SetupProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RasterCommandBuffer), typeof(UniversalCameraData&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 18)]
	[Calls(Type = typeof(XRPass), Member = "get_enabled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Matrix4x4), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Matrix4x4), typeof(Matrix4x4)}, ReturnType = typeof(Matrix4x4))]
	[Calls(Type = typeof(XRPass), Member = "GetProjMatrix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Matrix4x4))]
	[CallsUnknownMethods(Count = 1)]
	public Matrix4x4 GetProjectionMatrix(int viewIndex = 0) { }

	[CalledBy(Type = "UnityEngine.Rendering.Universal.PostProcessPass+<>c", Member = "<LensFlareDataDrivenComputeOcclusion>b__149_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.PostProcessPass+LensFlarePassData", typeof(UnsafeGraphContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.PostProcessPass+<>c", Member = "<RenderLensFlareDataDriven>b__150_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.PostProcessPass+LensFlarePassData", typeof(UnsafeGraphContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PostProcessPass), Member = "LensFlareDataDrivenComputeOcclusion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UniversalCameraData&), typeof(CommandBuffer), typeof(RenderTargetIdentifier), typeof(bool), typeof(float), typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PostProcessPass), Member = "LensFlareDataDriven", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UniversalCameraData&), typeof(CommandBuffer), typeof(RenderTargetIdentifier), typeof(bool), typeof(float), typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XRDepthMotionPass), Member = "Update", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UniversalCameraData&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CameraData), Member = "GetProjectionMatrixNoJitter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Matrix4x4))]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(XRPass), Member = "get_enabled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(XRPass), Member = "GetProjMatrix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Matrix4x4))]
	[CallsUnknownMethods(Count = 1)]
	internal Matrix4x4 GetProjectionMatrixNoJitter(int viewIndex = 0) { }

	[CallerCount(Count = 28)]
	[Calls(Type = typeof(XRPass), Member = "get_enabled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(XRPass), Member = "GetViewMatrix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Matrix4x4))]
	[CallsUnknownMethods(Count = 1)]
	public Matrix4x4 GetViewMatrix(int viewIndex = 0) { }

	[CalledBy(Type = typeof(ScriptableRenderer), Member = "SetCameraMatrices", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(UniversalCameraData), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScriptableRenderer), Member = "SetPerCameraShaderVariables", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RasterCommandBuffer), typeof(UniversalCameraData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScriptableRenderer), Member = "SetPerCameraClippingPlaneProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RasterCommandBuffer), typeof(UniversalCameraData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScriptableRenderer), Member = "SetPerCameraProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), typeof(UniversalCameraData), typeof(Camera), typeof(CommandBuffer)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalCameraData), Member = "GetGPUProjectionMatrix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Matrix4x4))]
	[CalledBy(Type = typeof(UniversalCameraData), Member = "GetGPUProjectionMatrixNoJitter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Matrix4x4))]
	[CalledBy(Type = typeof(CameraData), Member = "IsCameraProjectionMatrixFlipped", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DrawObjectsPass), Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), typeof(RenderingData&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(ScriptableRenderer), Member = "get_cameraColorTargetHandle", ReturnType = typeof(RTHandle))]
	[Calls(Type = typeof(UniversalCameraData), Member = "IsHandleYFlipped", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RTHandle)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	public bool IsCameraProjectionMatrixFlipped() { }

	[CalledBy(Type = typeof(UniversalCameraData), Member = "IsCameraProjectionMatrixFlipped", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(UniversalCameraData), Member = "IsRenderTargetProjectionMatrixFlipped", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RTHandle), typeof(RTHandle)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(CameraData), Member = "IsHandleYFlipped", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RTHandle)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(CopyDepthPass), Member = "ExecutePass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RasterCommandBuffer), "UnityEngine.Rendering.Universal.Internal.CopyDepthPass+PassData", typeof(RTHandle)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTargetIdentifier), typeof(int), typeof(CubemapFace), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BuiltinRenderTextureType)}, ReturnType = typeof(RenderTargetIdentifier))]
	[Calls(Type = typeof(XRPass), Member = "get_enabled", ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	public bool IsHandleYFlipped(RTHandle handle) { }

	[CalledBy(Type = "UnityEngine.Rendering.Universal.RenderObjectsPass+<>c", Member = "<RecordRenderGraph>b__33_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.RenderObjectsPass+PassData", typeof(RasterGraphContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RenderingUtils), Member = "GetFinalBlitScaleBias", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RTHandle), typeof(RTHandle), typeof(UniversalCameraData)}, ReturnType = typeof(Vector4))]
	[CalledBy(Type = typeof(CameraData), Member = "IsRenderTargetProjectionMatrixFlipped", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RTHandle), typeof(RTHandle)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.Internal.DrawObjectsPass+<>c", Member = "<Render>b__17_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PassData), typeof(RasterGraphContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.Internal.DrawObjectsWithRenderingLayersPass+<>c", Member = "<Render>b__7_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.Internal.DrawObjectsWithRenderingLayersPass+RenderingLayersPassData", typeof(RasterGraphContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(UniversalCameraData), Member = "IsHandleYFlipped", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RTHandle)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	public bool IsRenderTargetProjectionMatrixFlipped(RTHandle color, RTHandle depth = null) { }

	[CalledBy(Type = typeof(PostProcessPass), Member = "RenderFinalPassRenderGraph", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(ContextContainer), typeof(TextureHandle&), typeof(TextureHandle&), typeof(TextureHandle&), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalRenderPipeline), Member = "InitializeAdditionalCameraData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(UniversalAdditionalCameraData), typeof(bool), typeof(bool), typeof(UniversalCameraData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalRenderPipeline), Member = "UpdateTemporalAAData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UniversalCameraData), typeof(UniversalAdditionalCameraData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalRenderer), Member = "OnAfterRendering", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(Component), Member = "TryGetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(UniversalAdditionalCameraData), Member = "get_cameraStack", ReturnType = typeof(System.Collections.Generic.List`1<UnityEngine.Camera>))]
	[Calls(Type = typeof(Camera), Member = "get_allowDynamicResolution", ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	internal bool IsSTPEnabled() { }

	[CalledBy(Type = typeof(PostProcessPass), Member = "RenderPostProcessingRenderGraph", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(ContextContainer), typeof(TextureHandle&), typeof(TextureHandle&), typeof(TextureHandle&), typeof(TextureHandle&), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalRenderPipeline), Member = "RenderSingleCamera", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), typeof(UniversalCameraData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalRenderPipeline), Member = "UpdateTemporalAATargets", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UniversalCameraData)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[ContainsUnimplementedInstructions]
	internal bool IsSTPRequested() { }

	[CalledBy(Type = typeof(PostProcessPass), Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(RenderingData&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ForwardLights), Member = "SetupLights", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnsafeCommandBuffer), typeof(UniversalRenderingData), typeof(UniversalCameraData), typeof(UniversalLightData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalRenderer), Member = "OnAfterRendering", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalRenderer), Member = "OnMainRendering", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(ScriptableRenderContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalRenderer), Member = "CreateRenderGraphCameraRenderTargets", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CameraData), Member = "IsTemporalAAEnabled", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(UniversalRenderPipeline), Member = "UpdateTemporalAATargets", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UniversalCameraData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalRenderer), Member = "Setup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), typeof(RenderingData&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalRenderPipeline), Member = "CheckPostProcessForDepth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UniversalCameraData)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(UniversalRenderPipeline), Member = "RenderSingleCamera", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), typeof(UniversalCameraData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TemporalAA), Member = "CalculateJitterMatrix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UniversalCameraData), typeof(JitterFunc)}, ReturnType = typeof(Matrix4x4))]
	[CalledBy(Type = typeof(PostProcessPass), Member = "RenderPostProcessingRenderGraph", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(ContextContainer), typeof(TextureHandle&), typeof(TextureHandle&), typeof(TextureHandle&), typeof(TextureHandle&), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PostProcessPass), Member = "RenderFinalPassRenderGraph", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(ContextContainer), typeof(TextureHandle&), typeof(TextureHandle&), typeof(TextureHandle&), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PostProcessPass), Member = "RenderFinalPass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(RenderingData&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalRenderPipeline), Member = "InitializeAdditionalCameraData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(UniversalAdditionalCameraData), typeof(bool), typeof(bool), typeof(UniversalCameraData)}, ReturnType = typeof(void))]
	[CallerCount(Count = 15)]
	[Calls(Type = typeof(Component), Member = "TryGetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(UniversalAdditionalCameraData), Member = "get_cameraStack", ReturnType = typeof(System.Collections.Generic.List`1<UnityEngine.Camera>))]
	[Calls(Type = typeof(Camera), Member = "get_allowDynamicResolution", ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	internal bool IsTemporalAAEnabled() { }

	[CalledBy(Type = typeof(PostProcessPass), Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(RenderingData&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PostProcessPass), Member = "RenderPostProcessingRenderGraph", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(ContextContainer), typeof(TextureHandle&), typeof(TextureHandle&), typeof(TextureHandle&), typeof(TextureHandle&), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[ContainsUnimplementedInstructions]
	internal bool IsTemporalAARequested() { }

	[CalledBy(Type = typeof(ScriptableRenderer), Member = "SetCameraMatrices", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RasterCommandBuffer), typeof(UniversalCameraData), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScriptableRenderer), Member = "SetRenderPassAttachments", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(ScriptableRenderPass), typeof(UniversalCameraData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CameraData), Member = "PushBuiltinShaderConstantsXR", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RasterCommandBuffer), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(XRBuiltinShaderConstants), Member = "SetBuiltinShaderConstants", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RasterCommandBuffer)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XRBuiltinShaderConstants), Member = "UpdateBuiltinShaderConstants", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Matrix4x4), typeof(Matrix4x4), typeof(bool), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Matrix4x4), Member = "get_inverse", ReturnType = typeof(Matrix4x4))]
	[Calls(Type = typeof(Matrix4x4), Member = "Scale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Matrix4x4))]
	[Calls(Type = typeof(Matrix4x4), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Matrix4x4), typeof(Matrix4x4)}, ReturnType = typeof(Matrix4x4))]
	[Calls(Type = typeof(GL), Member = "GetGPUProjectionMatrix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Matrix4x4), typeof(bool)}, ReturnType = typeof(Matrix4x4))]
	[Calls(Type = typeof(Matrix4x4), Member = "Inverse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Matrix4x4)}, ReturnType = typeof(Matrix4x4))]
	[Calls(Type = typeof(UniversalCameraData), Member = "GetViewMatrix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Matrix4x4))]
	[Calls(Type = typeof(XRPass), Member = "GetViewMatrix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Matrix4x4))]
	[Calls(Type = typeof(UniversalCameraData), Member = "GetProjectionMatrix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Matrix4x4))]
	[Calls(Type = typeof(XRPass), Member = "get_enabled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(XRPass), Member = "get_singlePassEnabled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Matrix4x4), Member = "GetColumn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Vector4))]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 1)]
	internal void PushBuiltinShaderConstantsXR(RasterCommandBuffer cmd, bool renderIntoTexture) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 9)]
	public virtual void Reset() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public void set_historyManager(UniversalCameraHistory value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	internal void set_xr(XRPass value) { }

	[CalledBy(Type = typeof(CameraData), Member = "SetViewAndProjectionMatrix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Matrix4x4), typeof(Matrix4x4)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	internal void SetViewAndProjectionMatrix(Matrix4x4 viewMatrix, Matrix4x4 projectionMatrix) { }

	[CalledBy(Type = typeof(UniversalRenderPipeline), Member = "InitializeAdditionalCameraData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(UniversalAdditionalCameraData), typeof(bool), typeof(bool), typeof(UniversalCameraData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CameraData), Member = "SetViewProjectionAndJitterMatrix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Matrix4x4), typeof(Matrix4x4), typeof(Matrix4x4)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	internal void SetViewProjectionAndJitterMatrix(Matrix4x4 viewMatrix, Matrix4x4 projectionMatrix, Matrix4x4 jitterMatrix) { }

}

