namespace UnityEngine.Rendering.Universal;

internal class DebugHandler : IDebugDisplaySettingsQuery
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static BaseRenderFunc<DebugFinalValidationPassData, RasterGraphContext> <>9__101_0; //Field offset: 0x8
		public static BaseRenderFunc<DebugSetupPassData, RasterGraphContext> <>9__106_0; //Field offset: 0x10

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		private static <>c() { }

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c() { }

		[CallerCount(Count = 13327)]
		[DeduplicatedMethod]
		internal void <Setup>b__106_0(DebugSetupPassData data, RasterGraphContext context) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(DebugHandler), Member = "UpdateShaderGlobalPropertiesForFinalValidationPass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RasterCommandBuffer), "UnityEngine.Rendering.Universal.DebugHandler+DebugFinalValidationPassData"}, ReturnType = typeof(void))]
		internal void <UpdateShaderGlobalPropertiesForFinalValidationPass>b__101_0(DebugFinalValidationPassData data, RasterGraphContext context) { }

	}

	private class DebugFinalValidationPassData
	{
		public bool isFinalPass; //Field offset: 0x10
		public bool resolveFinalTarget; //Field offset: 0x11
		public bool isActiveForCamera; //Field offset: 0x12
		public bool hasDebugRenderTarget; //Field offset: 0x13
		public TextureHandle debugRenderTargetHandle; //Field offset: 0x14
		public int debugTexturePropertyId; //Field offset: 0x24
		public Vector4 debugRenderTargetPixelRect; //Field offset: 0x28
		public int debugRenderTargetSupportsStereo; //Field offset: 0x38
		public Vector4 debugRenderTargetRangeRemap; //Field offset: 0x3C
		public TextureHandle debugFontTextureHandle; //Field offset: 0x4C
		public DebugDisplaySettingsRendering renderingSettings; //Field offset: 0x60

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public DebugFinalValidationPassData() { }

	}

	private class DebugSetupPassData
	{
		public bool isActiveForCamera; //Field offset: 0x10
		public DebugDisplaySettingsMaterial materialSettings; //Field offset: 0x18
		public DebugDisplaySettingsRendering renderingSettings; //Field offset: 0x20
		public DebugDisplaySettingsLighting lightingSettings; //Field offset: 0x28

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public DebugSetupPassData() { }

	}

	private static readonly int k_DebugColorInvalidModePropertyId; //Field offset: 0x0
	private static readonly int k_DebugCurrentRealTimeId; //Field offset: 0x4
	private static readonly int k_DebugColorPropertyId; //Field offset: 0x8
	private static readonly int k_DebugTexturePropertyId; //Field offset: 0xC
	private static readonly int k_DebugFontId; //Field offset: 0x10
	private static readonly int k_DebugTextureNoStereoPropertyId; //Field offset: 0x14
	private static readonly int k_DebugTextureDisplayRect; //Field offset: 0x18
	private static readonly int k_DebugRenderTargetSupportsStereo; //Field offset: 0x1C
	private static readonly int k_DebugRenderTargetRangeRemap; //Field offset: 0x20
	private static readonly int k_DebugMaterialModeId; //Field offset: 0x24
	private static readonly int k_DebugVertexAttributeModeId; //Field offset: 0x28
	private static readonly int k_DebugMaterialValidationModeId; //Field offset: 0x2C
	private static readonly int k_DebugMipInfoModeId; //Field offset: 0x30
	private static readonly int k_DebugMipMapStatusModeId; //Field offset: 0x34
	private static readonly int k_DebugMipMapShowStatusCodeId; //Field offset: 0x38
	private static readonly int k_DebugMipMapOpacityId; //Field offset: 0x3C
	private static readonly int k_DebugMipMapRecentlyUpdatedCooldownId; //Field offset: 0x40
	private static readonly int k_DebugMipMapTerrainTextureModeId; //Field offset: 0x44
	private static readonly int k_DebugSceneOverrideModeId; //Field offset: 0x48
	private static readonly int k_DebugFullScreenModeId; //Field offset: 0x4C
	private static readonly int k_DebugValidationModeId; //Field offset: 0x50
	private static readonly int k_DebugValidateBelowMinThresholdColorPropertyId; //Field offset: 0x54
	private static readonly int k_DebugValidateAboveMaxThresholdColorPropertyId; //Field offset: 0x58
	private static readonly int k_DebugMaxPixelCost; //Field offset: 0x5C
	private static readonly int k_DebugLightingModeId; //Field offset: 0x60
	private static readonly int k_DebugLightingFeatureFlagsId; //Field offset: 0x64
	private static readonly int k_DebugValidateAlbedoMinLuminanceId; //Field offset: 0x68
	private static readonly int k_DebugValidateAlbedoMaxLuminanceId; //Field offset: 0x6C
	private static readonly int k_DebugValidateAlbedoSaturationToleranceId; //Field offset: 0x70
	private static readonly int k_DebugValidateAlbedoHueToleranceId; //Field offset: 0x74
	private static readonly int k_DebugValidateAlbedoCompareColorId; //Field offset: 0x78
	private static readonly int k_DebugValidateMetallicMinValueId; //Field offset: 0x7C
	private static readonly int k_DebugValidateMetallicMaxValueId; //Field offset: 0x80
	private static readonly int k_ValidationChannelsId; //Field offset: 0x84
	private static readonly int k_RangeMinimumId; //Field offset: 0x88
	private static readonly int k_RangeMaximumId; //Field offset: 0x8C
	private static readonly ProfilingSampler s_DebugSetupSampler; //Field offset: 0x90
	private static readonly ProfilingSampler s_DebugFinalValidationSampler; //Field offset: 0x98
	private DebugSetupPassData s_DebugSetupPassData; //Field offset: 0x10
	private DebugFinalValidationPassData s_DebugFinalValidationPassData; //Field offset: 0x18
	private readonly Material m_ReplacementMaterial; //Field offset: 0x20
	private readonly Material m_HDRDebugViewMaterial; //Field offset: 0x28
	private HDRDebugViewPass m_HDRDebugViewPass; //Field offset: 0x30
	private RTHandle m_DebugScreenColorHandle; //Field offset: 0x38
	private RTHandle m_DebugScreenDepthHandle; //Field offset: 0x40
	private readonly UniversalRenderPipelineRuntimeTextures m_RuntimeTextures; //Field offset: 0x48
	private bool m_HasDebugRenderTarget; //Field offset: 0x50
	private bool m_DebugRenderTargetSupportsStereo; //Field offset: 0x51
	private Vector4 m_DebugRenderTargetPixelRect; //Field offset: 0x54
	private Vector4 m_DebugRenderTargetRangeRemap; //Field offset: 0x64
	private RTHandle m_DebugRenderTarget; //Field offset: 0x78
	private RTHandle m_DebugFontTexture; //Field offset: 0x80
	private GraphicsBuffer m_debugDisplayConstant; //Field offset: 0x88
	private readonly UniversalRenderPipelineDebugDisplaySettings m_DebugDisplaySettings; //Field offset: 0x90

	public override bool AreAnySettingsActive
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 42
	}

	internal UniversalRenderPipelineDebugDisplaySettings DebugDisplaySettings
	{
		[CallerCount(Count = 57)]
		[DeduplicatedMethod]
		internal get { } //Length: 8
	}

	internal RTHandle DebugScreenColorHandle
	{
		[CallerCount(Count = 10)]
		[DeduplicatedMethod]
		internal get { } //Length: 5
	}

	internal RTHandle DebugScreenDepthHandle
	{
		[CallerCount(Count = 35)]
		[DeduplicatedMethod]
		internal get { } //Length: 5
	}

	internal HDRDebugViewPass hdrDebugViewPass
	{
		[CallerCount(Count = 62)]
		[DeduplicatedMethod]
		internal get { } //Length: 5
	}

	internal bool IsActiveModeUnsupportedForDeferred
	{
		[CalledBy(Type = typeof(UniversalRenderer), Member = "get_renderingModeActual", ReturnType = typeof(RenderingMode))]
		[CalledBy(Type = typeof(UniversalRenderer), Member = "Setup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), typeof(RenderingData&)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		internal get { } //Length: 118
	}

	public override bool IsLightingActive
	{
		[CalledBy(Type = typeof(UniversalRenderer), Member = "Setup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), typeof(RenderingData&)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 42
	}

	public override bool IsPostProcessingAllowed
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 42
	}

	internal bool IsRenderPassSupported
	{
		[CalledBy(Type = typeof(UniversalRenderer), Member = "Setup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), typeof(RenderingData&)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		internal get { } //Length: 66
	}

	internal bool IsScreenClearNeeded
	{
		[CalledBy(Type = typeof(ScriptableRenderer), Member = "GetCameraClearFlag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UniversalCameraData)}, ReturnType = typeof(ClearFlag))]
		[CalledBy(Type = typeof(DrawSkyboxPass), Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), typeof(RenderingData&)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DrawSkyboxPass), Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(ContextContainer), typeof(ScriptableRenderContext), typeof(TextureHandle), typeof(TextureHandle), typeof(Material)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UniversalRenderer), Member = "CreateRenderGraphCameraRenderTargets", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 4)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		internal get { } //Length: 60
	}

	private DebugDisplaySettingsLighting LightingSettings
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		private get { } //Length: 30
	}

	private DebugDisplaySettingsMaterial MaterialSettings
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		private get { } //Length: 30
	}

	private DebugDisplaySettingsRendering RenderingSettings
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		private get { } //Length: 30
	}

	internal Material ReplacementMaterial
	{
		[CallerCount(Count = 12)]
		[DeduplicatedMethod]
		internal get { } //Length: 5
	}

	internal int stpDebugViewIndex
	{
		[CalledBy(Type = typeof(StpUtils), Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(UniversalResourceData), typeof(UniversalCameraData), typeof(TextureHandle), typeof(TextureHandle), typeof(TextureHandle), typeof(TextureHandle), typeof(Texture2D)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		internal get { } //Length: 38
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Shader), Member = "PropertyToID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ProfilingSampler), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	private static DebugHandler() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GraphicsSettings), Member = "TryGetRenderPipelineSettings", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CoreUtils), Member = "CreateEngineMaterial", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Shader)}, ReturnType = typeof(Material))]
	[Calls(Type = typeof(HDRDebugViewPass), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GraphicsSettings), Member = "GetRenderPipelineSettings", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(RTHandles), Member = "Alloc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture)}, ReturnType = typeof(RTHandle))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(Marshal), Member = "SizeOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(GraphicsBuffer), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Target), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 10)]
	internal DebugHandler() { }

	[CalledBy(Type = typeof(HDRDebugViewPass), Member = "Setup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UniversalCameraData), typeof(HDRDebugMode)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(HDRDebugViewPass), Member = "RenderHDRDebug", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(UniversalCameraData), typeof(TextureHandle), typeof(TextureHandle), typeof(TextureHandle), typeof(HDRDebugMode)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalRenderer), Member = "Setup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), typeof(RenderingData&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalRenderer), Member = "OnAfterRendering", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(RenderTextureDescriptor), Member = "set_useMipMap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderTextureDescriptor), Member = "set_autoGenerateMips", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderTextureDescriptor), Member = "set_useDynamicScale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	internal static void ConfigureColorDescriptorForDebugScreen(ref RenderTextureDescriptor descriptor, int cameraWidth, int cameraHeight) { }

	[CalledBy(Type = typeof(UniversalRenderer), Member = "Setup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), typeof(RenderingData&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalRenderer), Member = "OnAfterRendering", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(RenderTextureDescriptor), Member = "set_useMipMap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderTextureDescriptor), Member = "set_autoGenerateMips", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderTextureDescriptor), Member = "set_useDynamicScale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderTextureDescriptor), Member = "set_graphicsFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GraphicsFormat)}, ReturnType = typeof(void))]
	internal static void ConfigureDepthDescriptorForDebugScreen(ref RenderTextureDescriptor descriptor, GraphicsFormat depthStencilFormat, int cameraWidth, int cameraHeight) { }

	[CalledBy(Type = typeof(RenderObjectsPass), Member = "InitRendererLists", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UniversalRenderingData), typeof(UniversalLightData), typeof(PassData&), typeof(ScriptableRenderContext), typeof(RenderGraph), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DrawObjectsPass), Member = "InitRendererLists", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UniversalRenderingData), typeof(UniversalCameraData), typeof(UniversalLightData), typeof(PassData&), typeof(ScriptableRenderContext), typeof(RenderGraph), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(DebugRendererLists), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DebugHandler), typeof(FilteringSettings)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DebugRendererLists), Member = "CreateRendererListsWithDebugRenderState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), typeof(CullingResults&), typeof(DrawingSettings&), typeof(FilteringSettings&), typeof(RenderStateBlock&)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	internal DebugRendererLists CreateRendererListsWithDebugRenderState(ScriptableRenderContext context, ref CullingResults cullResults, ref DrawingSettings drawingSettings, ref FilteringSettings filteringSettings, ref RenderStateBlock renderStateBlock) { }

	[CalledBy(Type = typeof(RenderObjectsPass), Member = "InitRendererLists", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UniversalRenderingData), typeof(UniversalLightData), typeof(PassData&), typeof(ScriptableRenderContext), typeof(RenderGraph), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DrawObjectsPass), Member = "InitRendererLists", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UniversalRenderingData), typeof(UniversalCameraData), typeof(UniversalLightData), typeof(PassData&), typeof(ScriptableRenderContext), typeof(RenderGraph), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(DebugRendererLists), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DebugHandler), typeof(FilteringSettings)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DebugRendererLists), Member = "CreateRendererListsWithDebugRenderState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(CullingResults&), typeof(DrawingSettings&), typeof(FilteringSettings&), typeof(RenderStateBlock&)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	internal DebugRendererLists CreateRendererListsWithDebugRenderState(RenderGraph renderGraph, ref CullingResults cullResults, ref DrawingSettings drawingSettings, ref FilteringSettings filteringSettings, ref RenderStateBlock renderStateBlock) { }

	[CalledBy(Type = typeof(ScriptableRenderer), Member = "Dispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(HDRDebugViewPass), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(RTHandle), Member = "Release", ReturnType = typeof(void))]
	[Calls(Type = typeof(CoreUtils), Member = "Destroy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void Dispose() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public override bool get_AreAnySettingsActive() { }

	[CallerCount(Count = 57)]
	[DeduplicatedMethod]
	internal UniversalRenderPipelineDebugDisplaySettings get_DebugDisplaySettings() { }

	[CallerCount(Count = 10)]
	[DeduplicatedMethod]
	internal RTHandle get_DebugScreenColorHandle() { }

	[CallerCount(Count = 35)]
	[DeduplicatedMethod]
	internal RTHandle get_DebugScreenDepthHandle() { }

	[CallerCount(Count = 62)]
	[DeduplicatedMethod]
	internal HDRDebugViewPass get_hdrDebugViewPass() { }

	[CalledBy(Type = typeof(UniversalRenderer), Member = "get_renderingModeActual", ReturnType = typeof(RenderingMode))]
	[CalledBy(Type = typeof(UniversalRenderer), Member = "Setup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), typeof(RenderingData&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	internal bool get_IsActiveModeUnsupportedForDeferred() { }

	[CalledBy(Type = typeof(UniversalRenderer), Member = "Setup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), typeof(RenderingData&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public override bool get_IsLightingActive() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public override bool get_IsPostProcessingAllowed() { }

	[CalledBy(Type = typeof(UniversalRenderer), Member = "Setup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), typeof(RenderingData&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	internal bool get_IsRenderPassSupported() { }

	[CalledBy(Type = typeof(ScriptableRenderer), Member = "GetCameraClearFlag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UniversalCameraData)}, ReturnType = typeof(ClearFlag))]
	[CalledBy(Type = typeof(DrawSkyboxPass), Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), typeof(RenderingData&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DrawSkyboxPass), Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(ContextContainer), typeof(ScriptableRenderContext), typeof(TextureHandle), typeof(TextureHandle), typeof(Material)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalRenderer), Member = "CreateRenderGraphCameraRenderTargets", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	internal bool get_IsScreenClearNeeded() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private DebugDisplaySettingsLighting get_LightingSettings() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private DebugDisplaySettingsMaterial get_MaterialSettings() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private DebugDisplaySettingsRendering get_RenderingSettings() { }

	[CallerCount(Count = 12)]
	[DeduplicatedMethod]
	internal Material get_ReplacementMaterial() { }

	[CalledBy(Type = typeof(StpUtils), Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(UniversalResourceData), typeof(UniversalCameraData), typeof(TextureHandle), typeof(TextureHandle), typeof(TextureHandle), typeof(TextureHandle), typeof(Texture2D)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	internal int get_stpDebugViewIndex() { }

	[CallerCount(Count = 13)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	internal bool HDRDebugViewIsActive(bool resolveFinalTarget) { }

	[CalledBy(Type = typeof(DebugHandler), Member = "UpdateShaderGlobalPropertiesForFinalValidationPass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(UniversalCameraData), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UniversalCameraData), Member = "get_isPreviewCamera", ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	private DebugFinalValidationPassData InitDebugFinalValidationPassData(DebugFinalValidationPassData passData, UniversalCameraData cameraData, bool isFinalPass) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	private DebugSetupPassData InitDebugSetupPassData(DebugSetupPassData passData, bool isPreviewCamera) { }

	[CalledBy(Type = typeof(ScriptableRenderPass), Member = "GetActiveDebugHandler", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UniversalCameraData)}, ReturnType = typeof(DebugHandler))]
	[CalledBy(Type = typeof(ScriptableRenderer), Member = "GetCameraClearFlag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UniversalCameraData)}, ReturnType = typeof(ClearFlag))]
	[CalledBy(Type = typeof(ScriptableRenderer), Member = "SetRenderPassAttachments", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(ScriptableRenderPass), typeof(UniversalCameraData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalRenderer), Member = "SetupFinalPassDebug", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UniversalCameraData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalRenderer), Member = "Setup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), typeof(RenderingData&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalRenderer), Member = "DebugHandlerRequireDepthPass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UniversalCameraData)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(UniversalRenderer), Member = "SetupRenderGraphFinalPassDebug", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(ContextContainer)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalRenderer), Member = "SetupAfterPostRenderGraphFinalPassDebug", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(ContextContainer)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalRenderer), Member = "RequiresIntermediateAttachments", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UniversalCameraData), typeof(RenderPassInputSummary&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(UniversalRenderer), Member = "CreateRenderGraphCameraRenderTargets", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalRenderer), Member = "CalculateTextureCopySchedules", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UniversalCameraData), "UnityEngine.Rendering.Universal.UniversalRenderer+RenderPassInputSummary", typeof(bool), typeof(bool), typeof(bool)}, ReturnType = "UnityEngine.Rendering.Universal.UniversalRenderer+TextureCopySchedules")]
	[CalledBy(Type = typeof(UniversalRenderer), Member = "RequireDepthTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UniversalCameraData), typeof(bool), typeof(RenderPassInputSummary&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 14)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	internal bool IsActiveForCamera(bool isPreviewCamera) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UniversalCameraData), Member = "get_isPreviewCamera", ReturnType = typeof(bool))]
	[Calls(Type = typeof(HDRDebugViewPass), Member = "RenderHDRDebug", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(UniversalCameraData), typeof(TextureHandle), typeof(TextureHandle), typeof(TextureHandle), typeof(HDRDebugMode)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Conditional("DEVELOPMENT_BUILD")]
	[Conditional("UNITY_EDITOR")]
	[ContainsUnimplementedInstructions]
	internal void Render(RenderGraph renderGraph, UniversalCameraData cameraData, TextureHandle srcColor, TextureHandle overlayTexture, TextureHandle dstColor) { }

	[CalledBy(Type = typeof(UniversalRenderer), Member = "SetupFinalPassDebug", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UniversalCameraData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalRenderer), Member = "SetupRenderGraphFinalPassDebug", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(ContextContainer)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	internal void ResetDebugRenderTarget() { }

	[CalledBy(Type = typeof(UniversalRenderer), Member = "SetupFinalPassDebug", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UniversalCameraData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalRenderer), Member = "SetupRenderGraphFinalPassDebug", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(ContextContainer)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalRenderer), Member = "SetupAfterPostRenderGraphFinalPassDebug", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(ContextContainer)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	internal void SetDebugRenderTarget(RTHandle renderTarget, Rect displayRect, bool supportsStereo, Vector4 dataRangeRemap) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RenderGraph), Member = "AddRasterRenderPass", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"PassData"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "PassData&", typeof(ProfilingSampler), typeof(string), typeof(int)}, ReturnType = typeof(IRasterRenderGraphBuilder))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 20)]
	[Conditional("DEVELOPMENT_BUILD")]
	[Conditional("UNITY_EDITOR")]
	internal void Setup(RenderGraph renderGraph, bool isPreviewCamera) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Time), Member = "get_realtimeSinceStartup", ReturnType = typeof(float))]
	[CallsDeduplicatedMethods(Count = 21)]
	[CallsUnknownMethods(Count = 1)]
	[Conditional("DEVELOPMENT_BUILD")]
	[Conditional("UNITY_EDITOR")]
	[ContainsUnimplementedInstructions]
	private static void Setup(RasterCommandBuffer cmd, DebugSetupPassData passData) { }

	[CallerCount(Count = 13327)]
	[Conditional("DEVELOPMENT_BUILD")]
	[Conditional("UNITY_EDITOR")]
	[DeduplicatedMethod]
	internal void Setup(CommandBuffer cmd, bool isPreviewCamera) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GraphicsBuffer), Member = "SetData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GraphicsBuffer), Member = "get_count", ReturnType = typeof(int))]
	[Calls(Type = typeof(GraphicsBuffer), Member = "get_stride", ReturnType = typeof(int))]
	[Calls(Type = typeof(Mathf), Member = "GammaToLinearSpace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(float))]
	[CallsDeduplicatedMethods(Count = 15)]
	[CallsUnknownMethods(Count = 1)]
	[Conditional("DEVELOPMENT_BUILD")]
	[Conditional("UNITY_EDITOR")]
	internal void SetupShaderProperties(RasterCommandBuffer cmd, int passIndex = 0) { }

	[CalledBy(Type = typeof(UniversalRenderer), Member = "SetupFinalPassDebug", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UniversalCameraData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalRenderer), Member = "SetupRenderGraphFinalPassDebug", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(ContextContainer)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalRenderer), Member = "SetupAfterPostRenderGraphFinalPassDebug", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(ContextContainer)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	internal bool TryGetFullscreenDebugMode(out DebugFullScreenMode debugFullScreenMode, out int textureHeightPercent) { }

	[CalledBy(Type = typeof(StpUtils), Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(UniversalResourceData), typeof(UniversalCameraData), typeof(TextureHandle), typeof(TextureHandle), typeof(TextureHandle), typeof(TextureHandle), typeof(Texture2D)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalRenderer), Member = "Setup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), typeof(RenderingData&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalRenderer), Member = "DebugHandlerRequireDepthPass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UniversalCameraData)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(UniversalRenderer), Member = "RequiresIntermediateAttachments", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UniversalCameraData), typeof(RenderPassInputSummary&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(UniversalRenderer), Member = "CalculateTextureCopySchedules", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UniversalCameraData), "UnityEngine.Rendering.Universal.UniversalRenderer+RenderPassInputSummary", typeof(bool), typeof(bool), typeof(bool)}, ReturnType = "UnityEngine.Rendering.Universal.UniversalRenderer+TextureCopySchedules")]
	[CalledBy(Type = typeof(UniversalRenderer), Member = "RequireDepthTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UniversalCameraData), typeof(bool), typeof(RenderPassInputSummary&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 6)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	internal bool TryGetFullscreenDebugMode(out DebugFullScreenMode debugFullScreenMode) { }

	[CalledBy(Type = typeof(ScriptableRenderer), Member = "SetRenderPassAttachments", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(ScriptableRenderPass), typeof(UniversalCameraData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalRenderer), Member = "CreateRenderGraphCameraRenderTargets", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public override bool TryGetScreenClearColor(ref Color color) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DebugHandler), Member = "InitDebugFinalValidationPassData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DebugFinalValidationPassData), typeof(UniversalCameraData), typeof(bool)}, ReturnType = typeof(DebugFinalValidationPassData))]
	[Calls(Type = typeof(DebugHandler), Member = "UpdateShaderGlobalPropertiesForFinalValidationPass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RasterCommandBuffer), typeof(DebugFinalValidationPassData)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RTHandle), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RTHandle)}, ReturnType = typeof(RenderTargetIdentifier))]
	[Calls(Type = typeof(CommandBuffer), Member = "SetGlobalTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(RenderTargetIdentifier)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture)}, ReturnType = typeof(RenderTargetIdentifier))]
	[CallsUnknownMethods(Count = 2)]
	[Conditional("DEVELOPMENT_BUILD")]
	[Conditional("UNITY_EDITOR")]
	internal void UpdateShaderGlobalPropertiesForFinalValidationPass(CommandBuffer cmd, UniversalCameraData cameraData, bool isFinalPass) { }

	[CalledBy(Type = typeof(<>c), Member = "<UpdateShaderGlobalPropertiesForFinalValidationPass>b__101_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DebugFinalValidationPassData), typeof(RasterGraphContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DebugHandler), Member = "UpdateShaderGlobalPropertiesForFinalValidationPass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(UniversalCameraData), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(RasterCommandBuffer), Member = "SetGlobalTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(TextureHandle)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 2)]
	private static void UpdateShaderGlobalPropertiesForFinalValidationPass(RasterCommandBuffer cmd, DebugFinalValidationPassData data) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RenderGraph), Member = "AddRasterRenderPass", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"PassData"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "PassData&", typeof(ProfilingSampler), typeof(string), typeof(int)}, ReturnType = typeof(IRasterRenderGraphBuilder))]
	[Calls(Type = typeof(UniversalCameraData), Member = "get_isPreviewCamera", ReturnType = typeof(bool))]
	[Calls(Type = typeof(RenderGraph), Member = "ImportTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RTHandle)}, ReturnType = typeof(TextureHandle))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 35)]
	[Conditional("DEVELOPMENT_BUILD")]
	[Conditional("UNITY_EDITOR")]
	[ContainsUnimplementedInstructions]
	internal void UpdateShaderGlobalPropertiesForFinalValidationPass(RenderGraph renderGraph, UniversalCameraData cameraData, bool isFinalPass) { }

	[CallerCount(Count = 13)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	internal bool WriteToDebugScreenTexture(bool resolveFinalTarget) { }

}

