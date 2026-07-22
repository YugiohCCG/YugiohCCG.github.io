namespace UnityEngine.Rendering.Universal;

[ExcludeFromPreset]
public class UniversalRenderPipelineAsset : RenderPipelineAsset<UniversalRenderPipeline>, ISerializationCallbackReceiver, IProbeVolumeEnabledRenderPipeline, IGPUResidentRenderPipeline, IRenderGraphEnabledRenderPipeline, ISTPEnabledRenderPipeline
{
	private static class Strings
	{
		public static readonly string notURPRenderer; //Field offset: 0x0
		public static readonly string forwardPlusMissing; //Field offset: 0x8

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		private static Strings() { }

	}

	[Obsolete("Moved to UniversalRenderPipelineRuntimeTextures on GraphicsSettings. #from(2023.3)", False)]
	[ReloadGroup]
	internal sealed class TextureResources
	{
		[Reload("Textures/BlueNoise64/L/LDR_LLL1_0.png", Package::Root (1))]
		public Texture2D blueNoise64LTex; //Field offset: 0x10
		[Reload("Textures/BayerMatrix.png", Package::Root (1))]
		public Texture2D bayerMatrixTex; //Field offset: 0x18

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public TextureResources() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		public bool NeedsReload() { }

	}

	public const int k_MinLutSize = 16; //Field offset: 0x0
	internal const int k_ShadowCascadeMinCount = 1; //Field offset: 0x0
	private const int k_LastVersion = 12; //Field offset: 0x0
	internal const int k_ShadowCascadeMaxCount = 4; //Field offset: 0x0
	public static readonly int AdditionalLightsDefaultShadowResolutionTierLow; //Field offset: 0x0
	public const int k_MaxLutSize = 65; //Field offset: 0x0
	public static readonly int AdditionalLightsDefaultShadowResolutionTierMedium; //Field offset: 0x4
	public static readonly int AdditionalLightsDefaultShadowResolutionTierHigh; //Field offset: 0x8
	private static String[] s_Names; //Field offset: 0x10
	private static Int32[] s_Values; //Field offset: 0x18
	private static GraphicsFormat[][] s_LightCookieFormatList; //Field offset: 0x20
	private Shader m_DefaultShader; //Field offset: 0x20
	private ScriptableRenderer[] m_Renderers; //Field offset: 0x28
	[SerializeField]
	private int k_AssetVersion; //Field offset: 0x30
	[SerializeField]
	private int k_AssetPreviousVersion; //Field offset: 0x34
	[SerializeField]
	private RendererType m_RendererType; //Field offset: 0x38
	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Obsolete("Use m_RendererDataList instead.")]
	[SerializeField]
	internal ScriptableRendererData m_RendererData; //Field offset: 0x40
	[SerializeField]
	internal ScriptableRendererData[] m_RendererDataList; //Field offset: 0x48
	[SerializeField]
	internal int m_DefaultRendererIndex; //Field offset: 0x50
	[SerializeField]
	private bool m_RequireDepthTexture; //Field offset: 0x54
	[SerializeField]
	private bool m_RequireOpaqueTexture; //Field offset: 0x55
	[SerializeField]
	private Downsampling m_OpaqueDownsampling; //Field offset: 0x58
	[SerializeField]
	private bool m_SupportsTerrainHoles; //Field offset: 0x5C
	[SerializeField]
	private bool m_SupportsHDR; //Field offset: 0x5D
	[SerializeField]
	private HDRColorBufferPrecision m_HDRColorBufferPrecision; //Field offset: 0x60
	[SerializeField]
	private MsaaQuality m_MSAA; //Field offset: 0x64
	[SerializeField]
	private float m_RenderScale; //Field offset: 0x68
	[SerializeField]
	private UpscalingFilterSelection m_UpscalingFilter; //Field offset: 0x6C
	[SerializeField]
	private bool m_FsrOverrideSharpness; //Field offset: 0x70
	[SerializeField]
	private float m_FsrSharpness; //Field offset: 0x74
	[SerializeField]
	private bool m_EnableLODCrossFade; //Field offset: 0x78
	[SerializeField]
	private LODCrossFadeDitheringType m_LODCrossFadeDitheringType; //Field offset: 0x7C
	[SerializeField]
	private ShEvalMode m_ShEvalMode; //Field offset: 0x80
	[SerializeField]
	private LightProbeSystem m_LightProbeSystem; //Field offset: 0x84
	[SerializeField]
	private ProbeVolumeTextureMemoryBudget m_ProbeVolumeMemoryBudget; //Field offset: 0x88
	[SerializeField]
	private ProbeVolumeBlendingTextureMemoryBudget m_ProbeVolumeBlendingMemoryBudget; //Field offset: 0x8C
	[FormerlySerializedAs("m_SupportProbeVolumeStreaming")]
	[SerializeField]
	private bool m_SupportProbeVolumeGPUStreaming; //Field offset: 0x90
	[SerializeField]
	private bool m_SupportProbeVolumeDiskStreaming; //Field offset: 0x91
	[SerializeField]
	private bool m_SupportProbeVolumeScenarios; //Field offset: 0x92
	[SerializeField]
	private bool m_SupportProbeVolumeScenarioBlending; //Field offset: 0x93
	[SerializeField]
	private ProbeVolumeSHBands m_ProbeVolumeSHBands; //Field offset: 0x94
	[SerializeField]
	private LightRenderingMode m_MainLightRenderingMode; //Field offset: 0x98
	[SerializeField]
	private bool m_MainLightShadowsSupported; //Field offset: 0x9C
	[SerializeField]
	private ShadowResolution m_MainLightShadowmapResolution; //Field offset: 0xA0
	[SerializeField]
	private LightRenderingMode m_AdditionalLightsRenderingMode; //Field offset: 0xA4
	[SerializeField]
	private int m_AdditionalLightsPerObjectLimit; //Field offset: 0xA8
	[SerializeField]
	private bool m_AdditionalLightShadowsSupported; //Field offset: 0xAC
	[SerializeField]
	private ShadowResolution m_AdditionalLightsShadowmapResolution; //Field offset: 0xB0
	[SerializeField]
	private int m_AdditionalLightsShadowResolutionTierLow; //Field offset: 0xB4
	[SerializeField]
	private int m_AdditionalLightsShadowResolutionTierMedium; //Field offset: 0xB8
	[SerializeField]
	private int m_AdditionalLightsShadowResolutionTierHigh; //Field offset: 0xBC
	[SerializeField]
	private bool m_ReflectionProbeBlending; //Field offset: 0xC0
	[SerializeField]
	private bool m_ReflectionProbeBoxProjection; //Field offset: 0xC1
	[SerializeField]
	private float m_ShadowDistance; //Field offset: 0xC4
	[SerializeField]
	private int m_ShadowCascadeCount; //Field offset: 0xC8
	[SerializeField]
	private float m_Cascade2Split; //Field offset: 0xCC
	[SerializeField]
	private Vector2 m_Cascade3Split; //Field offset: 0xD0
	[SerializeField]
	private Vector3 m_Cascade4Split; //Field offset: 0xD8
	[SerializeField]
	private float m_CascadeBorder; //Field offset: 0xE4
	[SerializeField]
	private float m_ShadowDepthBias; //Field offset: 0xE8
	[SerializeField]
	private float m_ShadowNormalBias; //Field offset: 0xEC
	[SerializeField]
	private bool m_SoftShadowsSupported; //Field offset: 0xF0
	[SerializeField]
	private bool m_ConservativeEnclosingSphere; //Field offset: 0xF1
	[SerializeField]
	private int m_NumIterationsEnclosingSphere; //Field offset: 0xF4
	[SerializeField]
	private SoftShadowQuality m_SoftShadowQuality; //Field offset: 0xF8
	[SerializeField]
	private LightCookieResolution m_AdditionalLightsCookieResolution; //Field offset: 0xFC
	[SerializeField]
	private LightCookieFormat m_AdditionalLightsCookieFormat; //Field offset: 0x100
	[SerializeField]
	private bool m_UseSRPBatcher; //Field offset: 0x104
	[SerializeField]
	private bool m_SupportsDynamicBatching; //Field offset: 0x105
	[SerializeField]
	private bool m_MixedLightingSupported; //Field offset: 0x106
	[SerializeField]
	private bool m_SupportsLightCookies; //Field offset: 0x107
	[SerializeField]
	private bool m_SupportsLightLayers; //Field offset: 0x108
	[Obsolete(null, True)]
	[SerializeField]
	private PipelineDebugLevel m_DebugLevel; //Field offset: 0x10C
	[SerializeField]
	private StoreActionsOptimization m_StoreActionsOptimization; //Field offset: 0x110
	[SerializeField]
	private bool m_UseAdaptivePerformance; //Field offset: 0x114
	[SerializeField]
	private ColorGradingMode m_ColorGradingMode; //Field offset: 0x118
	[SerializeField]
	private int m_ColorGradingLutSize; //Field offset: 0x11C
	[SerializeField]
	private bool m_AllowPostProcessAlphaOutput; //Field offset: 0x120
	[SerializeField]
	private bool m_UseFastSRGBLinearConversion; //Field offset: 0x121
	[SerializeField]
	private bool m_SupportDataDrivenLensFlare; //Field offset: 0x122
	[SerializeField]
	private bool m_SupportScreenSpaceLensFlare; //Field offset: 0x123
	[FormerlySerializedAs("m_MacroBatcherMode")]
	[SerializeField]
	private GPUResidentDrawerMode m_GPUResidentDrawerMode; //Field offset: 0x124
	[SerializeField]
	private float m_SmallMeshScreenPercentage; //Field offset: 0x128
	[SerializeField]
	private bool m_GPUResidentDrawerEnableOcclusionCullingInCameras; //Field offset: 0x12C
	[SerializeField]
	private ShadowQuality m_ShadowType; //Field offset: 0x130
	[SerializeField]
	private bool m_LocalShadowsSupported; //Field offset: 0x134
	[SerializeField]
	private ShadowResolution m_LocalShadowsAtlasResolution; //Field offset: 0x138
	[SerializeField]
	private int m_MaxPixelLights; //Field offset: 0x13C
	[SerializeField]
	private ShadowResolution m_ShadowAtlasResolution; //Field offset: 0x140
	[SerializeField]
	private VolumeFrameworkUpdateMode m_VolumeFrameworkUpdateMode; //Field offset: 0x144
	[SerializeField]
	private VolumeProfile m_VolumeProfile; //Field offset: 0x148
	[Obsolete("Kept for migration. #from(2023.3")]
	[SerializeField]
	internal ProbeVolumeSceneData apvScenesData; //Field offset: 0x150
	[SerializeField]
	private int m_ShaderVariantLogLevel; //Field offset: 0x158
	[Obsolete("This is obsolete, please use shadowCascadeCount instead.", False)]
	[SerializeField]
	private ShadowCascadesOption m_ShadowCascades; //Field offset: 0x15C
	[Obsolete("Moved to UniversalRenderPipelineRuntimeTextures on GraphicsSettings. #from(2023.3)", False)]
	[SerializeField]
	private TextureResources m_Textures; //Field offset: 0x160

	internal GraphicsFormat additionalLightsCookieFormat
	{
		[CalledBy(Type = typeof(UniversalRenderer), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UniversalRendererData)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InitParams), Member = "Create", ReturnType = typeof(InitParams))]
		[CalledBy(Type = typeof(ForwardLights), Member = ".ctor", ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(SystemInfo), Member = "IsFormatSupported", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GraphicsFormat), typeof(GraphicsFormatUsage)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(QualitySettings), Member = "get_activeColorSpace", ReturnType = typeof(ColorSpace))]
		[Calls(Type = typeof(GraphicsFormatUtility), Member = "GetLinearFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GraphicsFormat)}, ReturnType = typeof(GraphicsFormat))]
		[Calls(Type = typeof(Enum), Member = "ToString", ReturnType = typeof(string))]
		[Calls(Type = typeof(GraphicsFormatUtility), Member = "GetBlockSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GraphicsFormat)}, ReturnType = typeof(uint))]
		[Calls(Type = typeof(GraphicsFormatUtility), Member = "GetFormatString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GraphicsFormat)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object), typeof(object)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(Debug), Member = "LogWarning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 2)]
		internal get { } //Length: 511
	}

	internal Vector2Int additionalLightsCookieResolution
	{
		[CalledBy(Type = typeof(UniversalRenderer), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UniversalRendererData)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InitParams), Member = "Create", ReturnType = typeof(InitParams))]
		[CalledBy(Type = typeof(ForwardLights), Member = ".ctor", ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		internal get { } //Length: 20
	}

	public internal LightRenderingMode additionalLightsRenderingMode
	{
		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		 get { } //Length: 7
		[CallerCount(Count = 0)]
		internal set { } //Length: 7
	}

	public int additionalLightsShadowmapResolution
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 7
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 set { } //Length: 7
	}

	public internal int additionalLightsShadowResolutionTierHigh
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 7
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		internal set { } //Length: 7
	}

	public internal int additionalLightsShadowResolutionTierLow
	{
		[CallerCount(Count = 4)]
		[DeduplicatedMethod]
		 get { } //Length: 7
		[CallerCount(Count = 3)]
		[DeduplicatedMethod]
		internal set { } //Length: 7
	}

	public internal int additionalLightsShadowResolutionTierMedium
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 7
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		internal set { } //Length: 7
	}

	public bool allowPostProcessAlphaOutput
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 8
	}

	public float cascade2Split
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 9
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 set { } //Length: 9
	}

	public Vector2 cascade3Split
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 25
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 set { } //Length: 8
	}

	public Vector3 cascade4Split
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 25
		[CallerCount(Count = 0)]
		 set { } //Length: 22
	}

	public float cascadeBorder
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 9
		[CallerCount(Count = 0)]
		 set { } //Length: 9
	}

	public int colorGradingLutSize
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 7
		[CallerCount(Count = 0)]
		 set { } //Length: 33
	}

	public ColorGradingMode colorGradingMode
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 7
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 set { } //Length: 7
	}

	public bool conservativeEnclosingSphere
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 8
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 set { } //Length: 7
	}

	[Obsolete("PipelineDebugLevel is deprecated and replaced to use the profiler. Calling debugLevel is not necessary.", True)]
	public PipelineDebugLevel debugLevel
	{
		[CallerCount(Count = 182)]
		[DeduplicatedMethod]
		 get { } //Length: 3
	}

	public Material decalMaterial
	{
		[CallerCount(Count = 182)]
		[DeduplicatedMethod]
		 get { } //Length: 3
	}

	public virtual Material default2DMaskMaterial
	{
		[CallerCount(Count = 182)]
		[DeduplicatedMethod]
		 get { } //Length: 3
	}

	public virtual Material default2DMaterial
	{
		[CallerCount(Count = 182)]
		[DeduplicatedMethod]
		 get { } //Length: 3
	}

	public virtual Material defaultLineMaterial
	{
		[CallerCount(Count = 182)]
		[DeduplicatedMethod]
		 get { } //Length: 3
	}

	public virtual Material defaultMaterial
	{
		[CallerCount(Count = 182)]
		[DeduplicatedMethod]
		 get { } //Length: 3
	}

	public virtual Material defaultParticleMaterial
	{
		[CallerCount(Count = 182)]
		[DeduplicatedMethod]
		 get { } //Length: 3
	}

	public virtual Shader defaultShader
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(ShaderUtils), Member = "GetShaderPath", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ShaderPathID)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(Shader), Member = "Find", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Shader))]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 166
	}

	public virtual Material defaultTerrainMaterial
	{
		[CallerCount(Count = 182)]
		[DeduplicatedMethod]
		 get { } //Length: 3
	}

	public bool enableLODCrossFade
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	[Obsolete("This has been deprecated, please use GraphicsSettings.GetRenderPipelineSettings<RenderGraphSettings>().enableRenderCompatibilityMode instead.")]
	public bool enableRenderGraph
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(GraphicsSettings), Member = "TryGetRenderPipelineSettings", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&"}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(RenderGraphSettings), Member = "get_enableRenderCompatibilityMode", ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 237
	}

	public bool fsrOverrideSharpness
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	public float fsrSharpness
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 6
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 set { } //Length: 6
	}

	public bool gpuResidentDrawerEnableOcclusionCullingInCameras
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 8
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		 set { } //Length: 32
	}

	public override GPUResidentDrawerMode gpuResidentDrawerMode
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 8
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		 set { } //Length: 32
	}

	public HDRColorBufferPrecision hdrColorBufferPrecision
	{
		[CallerCount(Count = 3)]
		[DeduplicatedMethod]
		 get { } //Length: 4
		[CallerCount(Count = 16)]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	public override bool isImmediateModeSupported
	{
		[CallerCount(Count = 271)]
		[DeduplicatedMethod]
		 get { } //Length: 3
	}

	public override bool isStpUsed
	{
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 8
	}

	[Obsolete("This is obsolete, please use renderingLayerMaskNames instead.", True)]
	public String[] lightLayerMaskNames
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 50
	}

	public internal LightProbeSystem lightProbeSystem
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 7
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		internal set { } //Length: 7
	}

	public LODCrossFadeDitheringType lodCrossFadeDitheringType
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 4
	}

	public internal LightRenderingMode mainLightRenderingMode
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 7
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		internal set { } //Length: 7
	}

	public int mainLightShadowmapResolution
	{
		[CallerCount(Count = 3)]
		[DeduplicatedMethod]
		 get { } //Length: 7
		[CallerCount(Count = 7)]
		[DeduplicatedMethod]
		 set { } //Length: 7
	}

	public int maxAdditionalLightsCount
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 7
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Math), Member = "Min", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(Math), Member = "Max", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
		[CallsDeduplicatedMethods(Count = 1)]
		 set { } //Length: 157
	}

	public override ProbeVolumeSHBands maxSHBands
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 21
	}

	public int msaaSampleCount
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 4
		[CallerCount(Count = 5)]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	public int numIterationsEnclosingSphere
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 7
		[CallerCount(Count = 0)]
		 set { } //Length: 7
	}

	public Downsampling opaqueDownsampling
	{
		[CallerCount(Count = 3)]
		[DeduplicatedMethod]
		 get { } //Length: 4
	}

	[Obsolete("This property is obsolete. Use RenderingLayerMask API and Tags & Layers project settings instead. #from(23.3)", False)]
	public virtual String[] prefixedRenderingLayerMaskNames
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 3)]
		 get { } //Length: 152
	}

	public internal ProbeVolumeBlendingTextureMemoryBudget probeVolumeBlendingMemoryBudget
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 7
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		internal set { } //Length: 7
	}

	public internal ProbeVolumeTextureMemoryBudget probeVolumeMemoryBudget
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 7
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		internal set { } //Length: 7
	}

	[Obsolete("This property is no longer necessary.")]
	public override ProbeVolumeSceneData probeVolumeSceneData
	{
		[CallerCount(Count = 182)]
		[DeduplicatedMethod]
		 get { } //Length: 3
	}

	public internal ProbeVolumeSHBands probeVolumeSHBands
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 7
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		internal set { } //Length: 7
	}

	public internal bool reflectionProbeBlending
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 8
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		internal set { } //Length: 7
	}

	public internal bool reflectionProbeBoxProjection
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 8
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		internal set { } //Length: 7
	}

	public ReadOnlySpan<ScriptableRendererData> rendererDataList
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		 get { } //Length: 87
	}

	internal Int32[] rendererIndexList
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		internal get { } //Length: 129
	}

	public ReadOnlySpan<ScriptableRenderer> renderers
	{
		[CalledBy(Type = typeof(UniversalAdditionalCameraData), Member = "OnDestroy", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UniversalAdditionalCameraData), Member = "GetRawRenderer", ReturnType = typeof(ScriptableRenderer))]
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		 get { } //Length: 87
	}

	[Obsolete("This property is obsolete. Use RenderingLayerMask API and Tags & Layers project settings instead. #from(23.3)", False)]
	public virtual String[] renderingLayerMaskNames
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(RenderingLayerMask), Member = "GetDefinedRenderingLayerNames", ReturnType = typeof(String[]))]
		 get { } //Length: 64
	}

	public virtual string renderPipelineShaderTag
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 44
	}

	public float renderScale
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 6
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UniversalRenderPipeline), Member = "get_maxRenderScale", ReturnType = typeof(float))]
		[CallsDeduplicatedMethods(Count = 1)]
		 set { } //Length: 117
	}

	protected virtual bool requiresCompatibleRenderPipelineGlobalSettings
	{
		[CallerCount(Count = 23)]
		[DeduplicatedMethod]
		 get { } //Length: 3
	}

	public ScriptableRenderer scriptableRenderer
	{
		[CalledBy(Type = typeof(UniversalRenderPipeline), Member = "RenderCameraStack", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), typeof(Camera), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UniversalRenderPipeline), Member = "GetRenderer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(UniversalAdditionalCameraData)}, ReturnType = typeof(ScriptableRenderer))]
		[CalledBy(Type = typeof(UniversalRenderPipeline), Member = "CreateCameraData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ContextContainer), typeof(Camera), typeof(UniversalAdditionalCameraData), typeof(bool)}, ReturnType = typeof(UniversalCameraData))]
		[CalledBy(Type = typeof(UniversalRenderPipeline), Member = "InitializeAdditionalCameraData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(UniversalAdditionalCameraData), typeof(bool), typeof(bool), typeof(UniversalCameraData)}, ReturnType = typeof(void))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(UniversalRenderPipelineAsset), Member = "get_scriptableRendererData", ReturnType = typeof(ScriptableRendererData))]
		[Calls(Type = typeof(ScriptableRenderer), Member = "Dispose", ReturnType = typeof(void))]
		[Calls(Type = typeof(ScriptableRendererData), Member = "InternalCreateRenderer", ReturnType = typeof(ScriptableRenderer))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 7)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 605
	}

	internal ScriptableRendererData scriptableRendererData
	{
		[CalledBy(Type = typeof(UniversalRenderPipelineAsset), Member = "get_scriptableRenderer", ReturnType = typeof(ScriptableRenderer))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		internal get { } //Length: 167
	}

	[Obsolete("Use GraphicsSettings.GetRenderPipelineSettings<ShaderStrippingSetting>().shaderVariantLogLevel instead.", True)]
	public ShaderVariantLogLevel shaderVariantLogLevel
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(GraphicsSettings), Member = "GetRenderPipelineSettings", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 95
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(GraphicsSettings), Member = "GetRenderPipelineSettings", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
		[Calls(Type = typeof(ShaderStrippingSetting), Member = "set_shaderVariantLogLevel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ShaderVariantLogLevel)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		 set { } //Length: 109
	}

	public int shadowCascadeCount
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 7
		[CalledBy(Type = typeof(UniversalRenderPipelineAsset), Member = "set_shadowCascadeOption", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ShadowCascadesOption)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object), typeof(object)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 4)]
		 set { } //Length: 234
	}

	[Obsolete("This is obsolete, please use shadowCascadeCount instead.", True)]
	public ShadowCascadesOption shadowCascadeOption
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 4)]
		 get { } //Length: 139
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UniversalRenderPipelineAsset), Member = "set_shadowCascadeCount", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 4)]
		 set { } //Length: 151
	}

	public float shadowDepthBias
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 9
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		 set { } //Length: 103
	}

	public float shadowDistance
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 9
		[CallerCount(Count = 0)]
		 set { } //Length: 18
	}

	public float shadowNormalBias
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 9
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		 set { } //Length: 103
	}

	public internal ShEvalMode shEvalMode
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 7
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		internal set { } //Length: 7
	}

	public float smallMeshScreenPercentage
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 9
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		 set { } //Length: 173
	}

	internal SoftShadowQuality softShadowQuality
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		internal get { } //Length: 7
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		internal set { } //Length: 7
	}

	public StoreActionsOptimization storeActionsOptimization
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 7
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 set { } //Length: 7
	}

	public bool supportDataDrivenLensFlare
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 8
	}

	public override bool supportProbeVolume
	{
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 11
	}

	public internal bool supportProbeVolumeDiskStreaming
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 8
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		internal set { } //Length: 7
	}

	public internal bool supportProbeVolumeGPUStreaming
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 8
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		internal set { } //Length: 7
	}

	public internal bool supportProbeVolumeScenarioBlending
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 8
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		internal set { } //Length: 7
	}

	public internal bool supportProbeVolumeScenarios
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 8
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		internal set { } //Length: 7
	}

	[Obsolete("This is obsolete, use supportProbeVolumeGPUStreaming instead.")]
	public internal bool supportProbeVolumeStreaming
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 8
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		internal set { } //Length: 7
	}

	public internal bool supportsAdditionalLightShadows
	{
		[CallerCount(Count = 5)]
		[DeduplicatedMethod]
		 get { } //Length: 8
		[CallerCount(Count = 0)]
		internal set { } //Length: 7
	}

	public bool supportsCameraDepthTexture
	{
		[CallerCount(Count = 7)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	public bool supportsCameraOpaqueTexture
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	public bool supportScreenSpaceLensFlare
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 8
	}

	public bool supportsDynamicBatching
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 8
		[CallerCount(Count = 0)]
		 set { } //Length: 7
	}

	public bool supportsHDR
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	public bool supportsLightCookies
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 8
	}

	[Obsolete("This is obsolete, use useRenderingLayers instead.", True)]
	public bool supportsLightLayers
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 8
	}

	public internal bool supportsMainLightShadows
	{
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 8
		[CallerCount(Count = 0)]
		internal set { } //Length: 7
	}

	public bool supportsMixedLighting
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 8
	}

	public internal bool supportsSoftShadows
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 8
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		internal set { } //Length: 7
	}

	public bool supportsTerrainHoles
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public virtual Shader terrainDetailGrassBillboardShader
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(GraphicsSettings), Member = "TryGetRenderPipelineSettings", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&"}, ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 126
	}

	public virtual Shader terrainDetailGrassShader
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(GraphicsSettings), Member = "TryGetRenderPipelineSettings", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&"}, ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 126
	}

	public virtual Shader terrainDetailLitShader
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(GraphicsSettings), Member = "TryGetRenderPipelineSettings", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&"}, ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 126
	}

	[Obsolete("Moved to UniversalRenderPipelineRuntimeTextures on GraphicsSettings. #from(2023.3)", False)]
	public TextureResources textures
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 117
	}

	private override GPUResidentDrawerSettings UnityEngine.Rendering.IGPUResidentRenderPipeline.gpuResidentDrawerSettings
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Shader), Member = "Find", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Shader))]
		[CallsUnknownMethods(Count = 2)]
		private get { } //Length: 181
	}

	public UpscalingFilterSelection upscalingFilter
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 4
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	public bool useAdaptivePerformance
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 8
		[CallerCount(Count = 0)]
		 set { } //Length: 7
	}

	public bool useFastSRGBLinearConversion
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 8
	}

	public bool useRenderingLayers
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 8
	}

	public bool useSRPBatcher
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 8
		[CallerCount(Count = 0)]
		 set { } //Length: 7
	}

	public VolumeFrameworkUpdateMode volumeFrameworkUpdateMode
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 7
	}

	public VolumeProfile volumeProfile
	{
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(SemaphoreSlim), Member = "Release", ReturnType = typeof(int))]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 96
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 set { } //Length: 19
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(RuntimeFieldHandle)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 8)]
	private static UniversalRenderPipelineAsset() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RenderPipelineAsset`1), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	public UniversalRenderPipelineAsset() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(UniversalRenderPipelineAsset), Member = "DestroyRenderers", ReturnType = typeof(void))]
	[Calls(Type = typeof(UniversalRenderPipeline), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UniversalRenderPipelineAsset)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UniversalRenderPipelineAsset), Member = "CreateRenderers", ReturnType = typeof(void))]
	[Calls(Type = typeof(UniversalRenderPipeline), Member = "get_asset", ReturnType = typeof(UniversalRenderPipelineAsset))]
	[Calls(Type = typeof(Object), Member = "get_name", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	protected virtual RenderPipeline CreatePipeline() { }

	[CalledBy(Type = typeof(UniversalRenderPipelineAsset), Member = "CreatePipeline", ReturnType = typeof(RenderPipeline))]
	[CalledBy(Type = typeof(UniversalRenderPipelineAsset), Member = "GetRenderer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(ScriptableRenderer))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ScriptableRendererData), Member = "InternalCreateRenderer", ReturnType = typeof(ScriptableRenderer))]
	[CallsUnknownMethods(Count = 7)]
	private void CreateRenderers() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ScriptableRenderer), Member = "Dispose", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private void DestroyRenderer(ref ScriptableRenderer renderer) { }

	[CalledBy(Type = typeof(UniversalRenderPipelineAsset), Member = "CreatePipeline", ReturnType = typeof(RenderPipeline))]
	[CalledBy(Type = typeof(UniversalRenderPipelineAsset), Member = "OnDisable", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalRenderPipelineAsset), Member = "GetRenderer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(ScriptableRenderer))]
	[CalledBy(Type = typeof(UniversalRenderPipeline), Member = "Dispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(ScriptableRenderer), Member = "Dispose", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	internal void DestroyRenderers() { }

	[CallerCount(Count = 2180)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	protected virtual void EnsureGlobalSettings() { }

	[CalledBy(Type = typeof(UniversalRenderer), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UniversalRendererData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InitParams), Member = "Create", ReturnType = typeof(InitParams))]
	[CalledBy(Type = typeof(ForwardLights), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(SystemInfo), Member = "IsFormatSupported", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GraphicsFormat), typeof(GraphicsFormatUsage)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(QualitySettings), Member = "get_activeColorSpace", ReturnType = typeof(ColorSpace))]
	[Calls(Type = typeof(GraphicsFormatUtility), Member = "GetLinearFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GraphicsFormat)}, ReturnType = typeof(GraphicsFormat))]
	[Calls(Type = typeof(Enum), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(GraphicsFormatUtility), Member = "GetBlockSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GraphicsFormat)}, ReturnType = typeof(uint))]
	[Calls(Type = typeof(GraphicsFormatUtility), Member = "GetFormatString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GraphicsFormat)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Debug), Member = "LogWarning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	internal GraphicsFormat get_additionalLightsCookieFormat() { }

	[CalledBy(Type = typeof(UniversalRenderer), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UniversalRendererData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InitParams), Member = "Create", ReturnType = typeof(InitParams))]
	[CalledBy(Type = typeof(ForwardLights), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	internal Vector2Int get_additionalLightsCookieResolution() { }

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public LightRenderingMode get_additionalLightsRenderingMode() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public int get_additionalLightsShadowmapResolution() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public int get_additionalLightsShadowResolutionTierHigh() { }

	[CallerCount(Count = 4)]
	[DeduplicatedMethod]
	public int get_additionalLightsShadowResolutionTierLow() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public int get_additionalLightsShadowResolutionTierMedium() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public bool get_allowPostProcessAlphaOutput() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public float get_cascade2Split() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public Vector2 get_cascade3Split() { }

	[CallerCount(Count = 0)]
	public Vector3 get_cascade4Split() { }

	[CallerCount(Count = 0)]
	public float get_cascadeBorder() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public int get_colorGradingLutSize() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public ColorGradingMode get_colorGradingMode() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public bool get_conservativeEnclosingSphere() { }

	[CallerCount(Count = 182)]
	[DeduplicatedMethod]
	public PipelineDebugLevel get_debugLevel() { }

	[CallerCount(Count = 182)]
	[DeduplicatedMethod]
	public Material get_decalMaterial() { }

	[CallerCount(Count = 182)]
	[DeduplicatedMethod]
	public virtual Material get_default2DMaskMaterial() { }

	[CallerCount(Count = 182)]
	[DeduplicatedMethod]
	public virtual Material get_default2DMaterial() { }

	[CallerCount(Count = 182)]
	[DeduplicatedMethod]
	public virtual Material get_defaultLineMaterial() { }

	[CallerCount(Count = 182)]
	[DeduplicatedMethod]
	public virtual Material get_defaultMaterial() { }

	[CallerCount(Count = 182)]
	[DeduplicatedMethod]
	public virtual Material get_defaultParticleMaterial() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ShaderUtils), Member = "GetShaderPath", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ShaderPathID)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Shader), Member = "Find", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Shader))]
	[CallsUnknownMethods(Count = 1)]
	public virtual Shader get_defaultShader() { }

	[CallerCount(Count = 182)]
	[DeduplicatedMethod]
	public virtual Material get_defaultTerrainMaterial() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public bool get_enableLODCrossFade() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GraphicsSettings), Member = "TryGetRenderPipelineSettings", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(RenderGraphSettings), Member = "get_enableRenderCompatibilityMode", ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	public bool get_enableRenderGraph() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public bool get_fsrOverrideSharpness() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public float get_fsrSharpness() { }

	[CallerCount(Count = 0)]
	public bool get_gpuResidentDrawerEnableOcclusionCullingInCameras() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public override GPUResidentDrawerMode get_gpuResidentDrawerMode() { }

	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	public HDRColorBufferPrecision get_hdrColorBufferPrecision() { }

	[CallerCount(Count = 271)]
	[DeduplicatedMethod]
	public override bool get_isImmediateModeSupported() { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public override bool get_isStpUsed() { }

	[CallerCount(Count = 0)]
	public String[] get_lightLayerMaskNames() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public LightProbeSystem get_lightProbeSystem() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public LODCrossFadeDitheringType get_lodCrossFadeDitheringType() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public LightRenderingMode get_mainLightRenderingMode() { }

	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	public int get_mainLightShadowmapResolution() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public int get_maxAdditionalLightsCount() { }

	[CallerCount(Count = 0)]
	public override ProbeVolumeSHBands get_maxSHBands() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public int get_msaaSampleCount() { }

	[CallerCount(Count = 0)]
	public int get_numIterationsEnclosingSphere() { }

	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	public Downsampling get_opaqueDownsampling() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 3)]
	public virtual String[] get_prefixedRenderingLayerMaskNames() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public ProbeVolumeBlendingTextureMemoryBudget get_probeVolumeBlendingMemoryBudget() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public ProbeVolumeTextureMemoryBudget get_probeVolumeMemoryBudget() { }

	[CallerCount(Count = 182)]
	[DeduplicatedMethod]
	public override ProbeVolumeSceneData get_probeVolumeSceneData() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public ProbeVolumeSHBands get_probeVolumeSHBands() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public bool get_reflectionProbeBlending() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public bool get_reflectionProbeBoxProjection() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public ReadOnlySpan<ScriptableRendererData> get_rendererDataList() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	internal Int32[] get_rendererIndexList() { }

	[CalledBy(Type = typeof(UniversalAdditionalCameraData), Member = "OnDestroy", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalAdditionalCameraData), Member = "GetRawRenderer", ReturnType = typeof(ScriptableRenderer))]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	public ReadOnlySpan<ScriptableRenderer> get_renderers() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RenderingLayerMask), Member = "GetDefinedRenderingLayerNames", ReturnType = typeof(String[]))]
	public virtual String[] get_renderingLayerMaskNames() { }

	[CallerCount(Count = 0)]
	public virtual string get_renderPipelineShaderTag() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public float get_renderScale() { }

	[CallerCount(Count = 23)]
	[DeduplicatedMethod]
	protected virtual bool get_requiresCompatibleRenderPipelineGlobalSettings() { }

	[CalledBy(Type = typeof(UniversalRenderPipeline), Member = "RenderCameraStack", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), typeof(Camera), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalRenderPipeline), Member = "GetRenderer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(UniversalAdditionalCameraData)}, ReturnType = typeof(ScriptableRenderer))]
	[CalledBy(Type = typeof(UniversalRenderPipeline), Member = "CreateCameraData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ContextContainer), typeof(Camera), typeof(UniversalAdditionalCameraData), typeof(bool)}, ReturnType = typeof(UniversalCameraData))]
	[CalledBy(Type = typeof(UniversalRenderPipeline), Member = "InitializeAdditionalCameraData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(UniversalAdditionalCameraData), typeof(bool), typeof(bool), typeof(UniversalCameraData)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UniversalRenderPipelineAsset), Member = "get_scriptableRendererData", ReturnType = typeof(ScriptableRendererData))]
	[Calls(Type = typeof(ScriptableRenderer), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(ScriptableRendererData), Member = "InternalCreateRenderer", ReturnType = typeof(ScriptableRenderer))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 7)]
	[ContainsUnimplementedInstructions]
	public ScriptableRenderer get_scriptableRenderer() { }

	[CalledBy(Type = typeof(UniversalRenderPipelineAsset), Member = "get_scriptableRenderer", ReturnType = typeof(ScriptableRenderer))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	internal ScriptableRendererData get_scriptableRendererData() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GraphicsSettings), Member = "GetRenderPipelineSettings", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[CallsUnknownMethods(Count = 1)]
	public ShaderVariantLogLevel get_shaderVariantLogLevel() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public int get_shadowCascadeCount() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	public ShadowCascadesOption get_shadowCascadeOption() { }

	[CallerCount(Count = 0)]
	public float get_shadowDepthBias() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public float get_shadowDistance() { }

	[CallerCount(Count = 0)]
	public float get_shadowNormalBias() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public ShEvalMode get_shEvalMode() { }

	[CallerCount(Count = 0)]
	public float get_smallMeshScreenPercentage() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	internal SoftShadowQuality get_softShadowQuality() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public StoreActionsOptimization get_storeActionsOptimization() { }

	[CallerCount(Count = 0)]
	public bool get_supportDataDrivenLensFlare() { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public override bool get_supportProbeVolume() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public bool get_supportProbeVolumeDiskStreaming() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public bool get_supportProbeVolumeGPUStreaming() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public bool get_supportProbeVolumeScenarioBlending() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public bool get_supportProbeVolumeScenarios() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public bool get_supportProbeVolumeStreaming() { }

	[CallerCount(Count = 5)]
	[DeduplicatedMethod]
	public bool get_supportsAdditionalLightShadows() { }

	[CallerCount(Count = 7)]
	[DeduplicatedMethod]
	public bool get_supportsCameraDepthTexture() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public bool get_supportsCameraOpaqueTexture() { }

	[CallerCount(Count = 0)]
	public bool get_supportScreenSpaceLensFlare() { }

	[CallerCount(Count = 0)]
	public bool get_supportsDynamicBatching() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public bool get_supportsHDR() { }

	[CallerCount(Count = 0)]
	public bool get_supportsLightCookies() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public bool get_supportsLightLayers() { }

	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	public bool get_supportsMainLightShadows() { }

	[CallerCount(Count = 0)]
	public bool get_supportsMixedLighting() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public bool get_supportsSoftShadows() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public bool get_supportsTerrainHoles() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GraphicsSettings), Member = "TryGetRenderPipelineSettings", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&"}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	public virtual Shader get_terrainDetailGrassBillboardShader() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GraphicsSettings), Member = "TryGetRenderPipelineSettings", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&"}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	public virtual Shader get_terrainDetailGrassShader() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GraphicsSettings), Member = "TryGetRenderPipelineSettings", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&"}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	public virtual Shader get_terrainDetailLitShader() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public TextureResources get_textures() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public UpscalingFilterSelection get_upscalingFilter() { }

	[CallerCount(Count = 0)]
	public bool get_useAdaptivePerformance() { }

	[CallerCount(Count = 0)]
	public bool get_useFastSRGBLinearConversion() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public bool get_useRenderingLayers() { }

	[CallerCount(Count = 0)]
	public bool get_useSRPBatcher() { }

	[CallerCount(Count = 0)]
	public VolumeFrameworkUpdateMode get_volumeFrameworkUpdateMode() { }

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SemaphoreSlim), Member = "Release", ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public VolumeProfile get_volumeProfile() { }

	[CalledBy(Type = typeof(UniversalRenderPipeline), Member = "CreateShadowData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ContextContainer), typeof(UniversalRenderPipelineAsset), typeof(bool)}, ReturnType = typeof(UniversalShadowData))]
	[CallerCount(Count = 2)]
	internal int GetAdditionalLightsShadowResolution(int additionalLightsShadowResolutionTier) { }

	[CallerCount(Count = 182)]
	[DeduplicatedMethod]
	private Material GetMaterial(DefaultMaterialType materialType) { }

	[CalledBy(Type = typeof(UniversalAdditionalCameraData), Member = "get_scriptableRenderer", ReturnType = typeof(ScriptableRenderer))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(Object), Member = "get_name", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Debug), Member = "LogWarning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UniversalRenderPipelineAsset), Member = "DestroyRenderers", ReturnType = typeof(void))]
	[Calls(Type = typeof(UniversalRenderPipelineAsset), Member = "CreateRenderers", ReturnType = typeof(void))]
	[Calls(Type = typeof(ScriptableRenderer), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(ScriptableRendererData), Member = "InternalCreateRenderer", ReturnType = typeof(ScriptableRenderer))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	public ScriptableRenderer GetRenderer(int index) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	internal bool IsAtLastVersion() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 4)]
	public override bool IsGPUResidentDrawerSupportedBySRP(out string message, out LogType severity) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 3)]
	public ScriptableRendererData LoadBuiltinRendererData(RendererType type = 1) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 6)]
	[ContainsUnimplementedInstructions]
	public override void OnAfterDeserialize() { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	public override void OnBeforeSerialize() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UniversalRenderPipelineAsset), Member = "DestroyRenderers", ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderPipelineAsset), Member = "OnDisable", ReturnType = typeof(void))]
	protected virtual void OnDisable() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	internal void OnEnableRenderGraphChanged() { }

	[CallerCount(Count = 0)]
	internal void set_additionalLightsRenderingMode(LightRenderingMode value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void set_additionalLightsShadowmapResolution(int value) { }

	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	internal void set_additionalLightsShadowResolutionTierHigh(int value) { }

	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	internal void set_additionalLightsShadowResolutionTierLow(int value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	internal void set_additionalLightsShadowResolutionTierMedium(int value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void set_cascade2Split(float value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void set_cascade3Split(Vector2 value) { }

	[CallerCount(Count = 0)]
	public void set_cascade4Split(Vector3 value) { }

	[CallerCount(Count = 0)]
	public void set_cascadeBorder(float value) { }

	[CallerCount(Count = 0)]
	public void set_colorGradingLutSize(int value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void set_colorGradingMode(ColorGradingMode value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void set_conservativeEnclosingSphere(bool value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void set_fsrOverrideSharpness(bool value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void set_fsrSharpness(float value) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void set_gpuResidentDrawerEnableOcclusionCullingInCameras(bool value) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public override void set_gpuResidentDrawerMode(GPUResidentDrawerMode value) { }

	[CallerCount(Count = 16)]
	[DeduplicatedMethod]
	public void set_hdrColorBufferPrecision(HDRColorBufferPrecision value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	internal void set_lightProbeSystem(LightProbeSystem value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	internal void set_mainLightRenderingMode(LightRenderingMode value) { }

	[CallerCount(Count = 7)]
	[DeduplicatedMethod]
	public void set_mainLightShadowmapResolution(int value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Math), Member = "Min", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Math), Member = "Max", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 1)]
	public void set_maxAdditionalLightsCount(int value) { }

	[CallerCount(Count = 5)]
	[DeduplicatedMethod]
	public void set_msaaSampleCount(int value) { }

	[CallerCount(Count = 0)]
	public void set_numIterationsEnclosingSphere(int value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	internal void set_probeVolumeBlendingMemoryBudget(ProbeVolumeBlendingTextureMemoryBudget value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	internal void set_probeVolumeMemoryBudget(ProbeVolumeTextureMemoryBudget value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	internal void set_probeVolumeSHBands(ProbeVolumeSHBands value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	internal void set_reflectionProbeBlending(bool value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	internal void set_reflectionProbeBoxProjection(bool value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UniversalRenderPipeline), Member = "get_maxRenderScale", ReturnType = typeof(float))]
	[CallsDeduplicatedMethods(Count = 1)]
	public void set_renderScale(float value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GraphicsSettings), Member = "GetRenderPipelineSettings", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(ShaderStrippingSetting), Member = "set_shaderVariantLogLevel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ShaderVariantLogLevel)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void set_shaderVariantLogLevel(ShaderVariantLogLevel value) { }

	[CalledBy(Type = typeof(UniversalRenderPipelineAsset), Member = "set_shadowCascadeOption", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ShadowCascadesOption)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	public void set_shadowCascadeCount(int value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UniversalRenderPipelineAsset), Member = "set_shadowCascadeCount", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	public void set_shadowCascadeOption(ShadowCascadesOption value) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void set_shadowDepthBias(float value) { }

	[CallerCount(Count = 0)]
	public void set_shadowDistance(float value) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void set_shadowNormalBias(float value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	internal void set_shEvalMode(ShEvalMode value) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void set_smallMeshScreenPercentage(float value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	internal void set_softShadowQuality(SoftShadowQuality value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void set_storeActionsOptimization(StoreActionsOptimization value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	internal void set_supportProbeVolumeDiskStreaming(bool value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	internal void set_supportProbeVolumeGPUStreaming(bool value) { }

	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	internal void set_supportProbeVolumeScenarioBlending(bool value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	internal void set_supportProbeVolumeScenarios(bool value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	internal void set_supportProbeVolumeStreaming(bool value) { }

	[CallerCount(Count = 0)]
	internal void set_supportsAdditionalLightShadows(bool value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void set_supportsCameraDepthTexture(bool value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void set_supportsCameraOpaqueTexture(bool value) { }

	[CallerCount(Count = 0)]
	public void set_supportsDynamicBatching(bool value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void set_supportsHDR(bool value) { }

	[CallerCount(Count = 0)]
	internal void set_supportsMainLightShadows(bool value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	internal void set_supportsSoftShadows(bool value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void set_upscalingFilter(UpscalingFilterSelection value) { }

	[CallerCount(Count = 0)]
	public void set_useAdaptivePerformance(bool value) { }

	[CallerCount(Count = 0)]
	public void set_useSRPBatcher(bool value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public void set_volumeProfile(VolumeProfile value) { }

	[CalledBy(Type = typeof(UniversalRenderPipeline), Member = "RenderSingleCamera", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), typeof(UniversalCameraData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalRenderPipeline), Member = "CreateRenderingData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ContextContainer), typeof(UniversalRenderPipelineAsset), typeof(CommandBuffer), typeof(bool), typeof(ScriptableRenderer)}, ReturnType = typeof(UniversalRenderingData))]
	[CalledBy(Type = typeof(UniversalRenderPipeline), Member = "CreateLightData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ContextContainer), typeof(UniversalRenderPipelineAsset), typeof(Unity.Collections.NativeArray`1<UnityEngine.Rendering.VisibleLight>)}, ReturnType = typeof(UniversalLightData))]
	[CalledBy(Type = typeof(UniversalRenderer), Member = "SetupCullingParameters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableCullingParameters&), typeof(CameraData&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	internal bool ShouldUseReflectionProbeBlending() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Shader), Member = "Find", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Shader))]
	[CallsUnknownMethods(Count = 2)]
	private override GPUResidentDrawerSettings UnityEngine.Rendering.IGPUResidentRenderPipeline.get_gpuResidentDrawerSettings() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Math), Member = "Min", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Math), Member = "Max", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 1)]
	private int ValidatePerObjectLights(int value) { }

	[CalledBy(Type = typeof(UniversalAdditionalCameraData), Member = "get_scriptableRenderer", ReturnType = typeof(ScriptableRenderer))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 2)]
	internal bool ValidateRendererData(int index) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	internal bool ValidateRendererDataList(bool partial = false) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UniversalRenderPipeline), Member = "get_maxRenderScale", ReturnType = typeof(float))]
	[CallsDeduplicatedMethods(Count = 1)]
	private float ValidateRenderScale(float value) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private float ValidateShadowBias(float value) { }

}

