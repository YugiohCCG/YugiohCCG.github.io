namespace UnityEngine.Rendering.Universal;

public sealed class UniversalRenderPipeline : RenderPipeline
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Comparison<Camera> <>9__47_0; //Field offset: 0x8

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		private static <>c() { }

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SupportedRenderingFeatures), Member = "get_active", ReturnType = typeof(SupportedRenderingFeatures))]
		[Calls(Type = typeof(Light), Member = "get_type", ReturnType = typeof(LightType))]
		[Calls(Type = typeof(Object), Member = "GetInstanceID", ReturnType = typeof(int))]
		[Calls(Type = typeof(LightDataGI), Member = "InitNoBake", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(LightmapperUtils), Member = "Extract", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Light), typeof(PointLight&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(LightDataGI), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointLight&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(LightmapperUtils), Member = "Extract", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Light), typeof(DirectionalLight&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(LightDataGI), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DirectionalLight&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(LightmapperUtils), Member = "Extract", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Light), typeof(SpotLight&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Light), Member = "get_innerSpotAngle", ReturnType = typeof(float))]
		[Calls(Type = typeof(LightDataGI), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SpotLight&)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 2)]
		internal void <.cctor>b__124_0(Light[] requests, NativeArray<LightDataGI> lightsOutput) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Camera), Member = "get_depth", ReturnType = typeof(float))]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		internal int <.ctor>b__47_0(Camera camera1, Camera camera2) { }

	}

	public static class CameraMetadataCache
	{
		internal class CameraMetadataCacheEntry
		{
			public string name; //Field offset: 0x10
			public ProfilingSampler sampler; //Field offset: 0x18

			[CallerCount(Count = 2180)]
			[CallsDeduplicatedMethods(Count = 1)]
			[DeduplicatedMethod]
			public CameraMetadataCacheEntry() { }

		}

		private static Dictionary<Int32, CameraMetadataCacheEntry> s_MetadataCache; //Field offset: 0x0
		private static readonly CameraMetadataCacheEntry k_NoAllocEntry; //Field offset: 0x8

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(ProfilingSampler), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 5)]
		private static CameraMetadataCache() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Object&)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Object), Member = "get_name", ReturnType = typeof(string))]
		[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(ProfilingSampler), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32, System.Object>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 3)]
		public static CameraMetadataCacheEntry GetCached(Camera camera) { }

	}

	[IsReadOnly]
	private struct CameraRenderingScope : IDisposable
	{
		private static readonly ProfilingSampler beginCameraRenderingSampler; //Field offset: 0x0
		private static readonly ProfilingSampler endCameraRenderingSampler; //Field offset: 0x8
		private readonly ScriptableRenderContext m_Context; //Field offset: 0x0
		private readonly Camera m_Camera; //Field offset: 0x8

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ProfilingSampler), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 2)]
		private static CameraRenderingScope() { }

		[CalledBy(Type = typeof(UniversalRenderPipeline), Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), typeof(System.Collections.Generic.List`1<UnityEngine.Camera>)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UniversalRenderPipeline), Member = "ProcessRenderRequests", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"RequestData"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), typeof(Camera), "RequestData"}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UniversalRenderPipeline), Member = "RenderCameraStack", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), typeof(Camera), typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(RenderPipeline), Member = "BeginCameraRendering", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), typeof(Camera)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 2)]
		public CameraRenderingScope(ScriptableRenderContext context, Camera camera) { }

		[CalledBy(Type = typeof(UniversalRenderPipeline), Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), typeof(System.Collections.Generic.List`1<UnityEngine.Camera>)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UniversalRenderPipeline), Member = "ProcessRenderRequests", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"RequestData"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), typeof(Camera), "RequestData"}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UniversalRenderPipeline), Member = "RenderCameraStack", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), typeof(Camera), typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 8)]
		[Calls(Type = typeof(RenderPipeline), Member = "EndCameraRendering", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), typeof(Camera)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 1)]
		public override void Dispose() { }

	}

	[IsReadOnly]
	private struct ContextRenderingScope : IDisposable
	{
		private static readonly ProfilingSampler beginContextRenderingSampler; //Field offset: 0x0
		private static readonly ProfilingSampler endContextRenderingSampler; //Field offset: 0x8
		private readonly ScriptableRenderContext m_Context; //Field offset: 0x0
		private readonly List<Camera> m_Cameras; //Field offset: 0x8

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ProfilingSampler), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 2)]
		private static ContextRenderingScope() { }

		[CalledBy(Type = typeof(UniversalRenderPipeline), Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), typeof(System.Collections.Generic.List`1<UnityEngine.Camera>)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UniversalRenderPipeline), Member = "ProcessRenderRequests", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"RequestData"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), typeof(Camera), "RequestData"}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(RenderPipeline), Member = "BeginContextRendering", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), typeof(System.Collections.Generic.List`1<UnityEngine.Camera>)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 2)]
		public ContextRenderingScope(ScriptableRenderContext context, List<Camera> cameras) { }

		[CalledBy(Type = typeof(UniversalRenderPipeline), Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), typeof(System.Collections.Generic.List`1<UnityEngine.Camera>)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UniversalRenderPipeline), Member = "ProcessRenderRequests", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"RequestData"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), typeof(Camera), "RequestData"}, ReturnType = typeof(void))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(RenderPipeline), Member = "EndContextRendering", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), typeof(System.Collections.Generic.List`1<UnityEngine.Camera>)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 1)]
		public override void Dispose() { }

	}

	public static class Profiling
	{
		internal static class Pipeline
		{
			internal static class Context
			{
				private const string k_Name = "ScriptableRenderContext"; //Field offset: 0x0
				public static readonly ProfilingSampler submit; //Field offset: 0x0

				[CallerCount(Count = 0)]
				[Calls(Type = typeof(ProfilingSampler), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
				[CallsUnknownMethods(Count = 1)]
				private static Context() { }

			}

			internal static class Renderer
			{
				private const string k_Name = "ScriptableRenderer"; //Field offset: 0x0
				public static readonly ProfilingSampler setupCullingParameters; //Field offset: 0x0
				public static readonly ProfilingSampler setup; //Field offset: 0x8

				[CallerCount(Count = 0)]
				[Calls(Type = typeof(ProfilingSampler), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
				[CallsUnknownMethods(Count = 2)]
				private static Renderer() { }

			}

			private const string k_Name = "UniversalRenderPipeline"; //Field offset: 0x0
			public static readonly ProfilingSampler initializeCameraData; //Field offset: 0x0
			public static readonly ProfilingSampler initializeStackedCameraData; //Field offset: 0x8
			public static readonly ProfilingSampler initializeAdditionalCameraData; //Field offset: 0x10
			public static readonly ProfilingSampler initializeRenderingData; //Field offset: 0x18
			public static readonly ProfilingSampler initializeShadowData; //Field offset: 0x20
			public static readonly ProfilingSampler initializeLightData; //Field offset: 0x28
			public static readonly ProfilingSampler buildAdditionalLightsShadowAtlasLayout; //Field offset: 0x30
			public static readonly ProfilingSampler getPerObjectLightFlags; //Field offset: 0x38
			public static readonly ProfilingSampler getMainLightIndex; //Field offset: 0x40
			public static readonly ProfilingSampler setupPerFrameShaderConstants; //Field offset: 0x48
			public static readonly ProfilingSampler setupPerCameraShaderConstants; //Field offset: 0x50

			[CallerCount(Count = 0)]
			[Calls(Type = typeof(ProfilingSampler), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
			[CallsUnknownMethods(Count = 11)]
			private static Pipeline() { }

		}


	}

	internal class SingleCameraRequest
	{
		public RenderTexture destination; //Field offset: 0x10
		public int mipLevel; //Field offset: 0x18
		public CubemapFace face; //Field offset: 0x1C
		public int slice; //Field offset: 0x20

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		public SingleCameraRequest() { }

	}

	public const string k_ShaderTagName = "UniversalPipeline"; //Field offset: 0x0
	internal const int k_DefaultRenderingLayerMask = 1; //Field offset: 0x0
	internal static bool cameraStackRequiresDepthForPostprocessing; //Field offset: 0x0
	internal static RenderGraph s_RenderGraph; //Field offset: 0x8
	internal static RTHandleResourcePool s_RTHandlePool; //Field offset: 0x10
	internal static bool useRenderGraph; //Field offset: 0x18
	[CompilerGenerated]
	private static bool <canOptimizeScreenMSAASamples>k__BackingField; //Field offset: 0x19
	[CompilerGenerated]
	private static int <startFrameScreenMSAASamples>k__BackingField; //Field offset: 0x1C
	private static Vector4 k_DefaultLightPosition; //Field offset: 0x20
	private static Vector4 k_DefaultLightColor; //Field offset: 0x30
	private static Vector4 k_DefaultLightAttenuation; //Field offset: 0x40
	private static Vector4 k_DefaultLightSpotDirection; //Field offset: 0x50
	private static Vector4 k_DefaultLightsProbeChannel; //Field offset: 0x60
	private static List<Vector4> m_ShadowBiasData; //Field offset: 0x70
	private static List<Int32> m_ShadowResolutionData; //Field offset: 0x78
	private static RequestLightsDelegate lightsDelegate; //Field offset: 0x80
	private readonly DebugDisplaySettingsUI m_DebugDisplaySettingsUI; //Field offset: 0x18
	private UniversalRenderPipelineGlobalSettings m_GlobalSettings; //Field offset: 0x20
	[CompilerGenerated]
	private UniversalRenderPipelineRuntimeTextures <runtimeTextures>k__BackingField; //Field offset: 0x28
	internal bool apvIsEnabled; //Field offset: 0x30
	private readonly UniversalRenderPipelineAsset pipelineAsset; //Field offset: 0x38
	internal bool enableHDROutputOnce; //Field offset: 0x40
	internal bool warnedRuntimeSwitchHDROutputToSDROutput; //Field offset: 0x41
	private Comparison<Camera> cameraComparison; //Field offset: 0x48

	public static UniversalRenderPipelineAsset asset
	{
		[CallerCount(Count = 72)]
		[Calls(Type = typeof(GraphicsSettings), Member = "get_currentRenderPipeline", ReturnType = typeof(RenderPipelineAsset))]
		 get { } //Length: 147
	}

	internal static bool canOptimizeScreenMSAASamples
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		internal get { } //Length: 79
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		private set { } //Length: 84
	}

	public virtual RenderPipelineGlobalSettings defaultSettings
	{
		[CallerCount(Count = 12)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	internal static int lightsPerTile
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UniversalRenderPipeline), Member = "get_maxVisibleAdditionalLights", ReturnType = typeof(int))]
		internal get { } //Length: 77
	}

	public static int maxNumIterationsEnclosingSphere
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 6
	}

	public static int maxPerObjectLights
	{
		[CallerCount(Count = 19)]
		[DeduplicatedMethod]
		 get { } //Length: 6
	}

	public static float maxRenderScale
	{
		[CalledBy(Type = typeof(UniversalRenderPipelineAsset), Member = "set_renderScale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UniversalRenderPipelineAsset), Member = "ValidateRenderScale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(float))]
		[CallerCount(Count = 2)]
		 get { } //Length: 9
	}

	public static float maxShadowBias
	{
		[CallerCount(Count = 3)]
		[DeduplicatedMethod]
		 get { } //Length: 9
	}

	internal static int maxTileWords
	{
		[CalledBy(Type = typeof(ForwardLights), Member = "CreateForwardPlusBuffers", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ForwardLights), Member = "PreSetup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UniversalRenderingData), typeof(UniversalCameraData), typeof(UniversalLightData)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ForwardLights), Member = "SetupLights", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnsafeCommandBuffer), typeof(UniversalRenderingData), typeof(UniversalCameraData), typeof(UniversalLightData)}, ReturnType = typeof(void))]
		[CallerCount(Count = 5)]
		[Calls(Type = typeof(UniversalRenderPipeline), Member = "get_maxVisibleAdditionalLights", ReturnType = typeof(int))]
		internal get { } //Length: 81
	}

	public static int maxVisibleAdditionalLights
	{
		[CalledBy(Type = typeof(Settings), Member = "Create", ReturnType = typeof(Settings))]
		[CalledBy(Type = typeof(ForwardLights), Member = "SetupPerObjectLightIndices", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CullingResults), typeof(UniversalLightData)}, ReturnType = typeof(int))]
		[CalledBy(Type = typeof(ForwardLights), Member = "SetupAdditionalLightConstants", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnsafeCommandBuffer), typeof(CullingResults&), typeof(UniversalLightData)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ForwardLights), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InitParams)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(AdditionalLightsShadowCasterPass), Member = "SetShadowParamsForEmptyShadowmap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RasterCommandBuffer)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(AdditionalLightsShadowCasterPass), Member = "SetupForEmptyRendering", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool), typeof(UniversalLightData), typeof(UniversalShadowData)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(AdditionalLightsShadowCasterPass), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderPassEvent)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(AdditionalLightsShadowCasterPass), Member = "Setup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UniversalRenderingData), typeof(UniversalCameraData), typeof(UniversalLightData), typeof(UniversalShadowData)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(UniversalRenderPipeline), Member = "CreateLightData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ContextContainer), typeof(UniversalRenderPipelineAsset), typeof(Unity.Collections.NativeArray`1<UnityEngine.Rendering.VisibleLight>)}, ReturnType = typeof(UniversalLightData))]
		[CalledBy(Type = typeof(UniversalRenderPipeline), Member = "get_maxVisibleReflectionProbes", ReturnType = typeof(int))]
		[CalledBy(Type = typeof(UniversalRenderPipeline), Member = "get_maxTileWords", ReturnType = typeof(int))]
		[CalledBy(Type = typeof(UniversalRenderPipeline), Member = "get_lightsPerTile", ReturnType = typeof(int))]
		[CalledBy(Type = typeof(AdditionalLightsShadowAtlasLayout), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UniversalLightData), typeof(UniversalShadowData), typeof(UniversalCameraData)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UniversalRenderer), Member = "SetupCullingParameters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableCullingParameters&), typeof(CameraData&)}, ReturnType = typeof(void))]
		[CallerCount(Count = 16)]
		[Calls(Type = typeof(Graphics), Member = "get_minOpenGLESVersion", ReturnType = typeof(OpenGLESVersion))]
		[Calls(Type = typeof(PlatformAutoDetect), Member = "get_isShaderAPIMobileDefined", ReturnType = typeof(bool))]
		[CallsDeduplicatedMethods(Count = 4)]
		 get { } //Length: 193
	}

	internal static int maxVisibleReflectionProbes
	{
		[CalledBy(Type = typeof(ReflectionProbeManager), Member = "Init", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ReflectionProbeManager), Member = "UpdateGpuData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(CullingResults&)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ForwardLights), Member = "PreSetup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UniversalRenderingData), typeof(UniversalCameraData), typeof(UniversalLightData)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(UniversalRenderPipeline), Member = "get_maxVisibleAdditionalLights", ReturnType = typeof(int))]
		[Calls(Type = typeof(Math), Member = "Min", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
		internal get { } //Length: 117
	}

	internal static int maxZBinWords
	{
		[CallerCount(Count = 5)]
		[DeduplicatedMethod]
		internal get { } //Length: 6
	}

	public static float minRenderScale
	{
		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		 get { } //Length: 9
	}

	internal UniversalRenderPipelineRuntimeTextures runtimeTextures
	{
		[CallerCount(Count = 15)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		internal get { } //Length: 5
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private set { } //Length: 13
	}

	internal static int startFrameScreenMSAASamples
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		internal get { } //Length: 78
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		private set { } //Length: 83
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RequestLightsDelegate), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private static UniversalRenderPipeline() { }

	[CalledBy(Type = typeof(UniversalRenderPipelineAsset), Member = "CreatePipeline", ReturnType = typeof(RenderPipeline))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(XRSystem), Member = "SetDisplayMSAASamples", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MSAASamples)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(QualitySettings), Member = "set_enableLODCrossFade", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DebugManager), Member = "get_instance", ReturnType = typeof(DebugManager))]
	[Calls(Type = typeof(RTHandleResourcePool), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(RenderGraphSettings), Member = "get_enableRenderCompatibilityMode", ReturnType = typeof(bool))]
	[Calls(Type = typeof(RenderGraph), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderingUtils), Member = "ClearSystemInfoCache", ReturnType = typeof(void))]
	[Calls(Type = typeof(Lightmapping), Member = "SetDelegate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RequestLightsDelegate)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XRSystem), Member = "SetRenderScale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VolumeManager), Member = "Initialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VolumeProfile), typeof(VolumeProfile)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VolumeManager), Member = "get_instance", ReturnType = typeof(VolumeManager))]
	[Calls(Type = typeof(QualitySettings), Member = "set_antiAliasing", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(QualitySettings), Member = "get_antiAliasing", ReturnType = typeof(int))]
	[Calls(Type = typeof(GraphicsSettings), Member = "set_useScriptableRenderPipelineBatching", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ShaderGlobalKeywords), Member = "InitializeShaderGlobalKeywords", ReturnType = typeof(void))]
	[Calls(Type = typeof(RTHandles), Member = "Initialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Screen), Member = "get_height", ReturnType = typeof(int))]
	[Calls(Type = typeof(Screen), Member = "get_width", ReturnType = typeof(int))]
	[Calls(Type = typeof(SupportedRenderingFeatures), Member = "get_active", ReturnType = typeof(SupportedRenderingFeatures))]
	[Calls(Type = typeof(Blitter), Member = "Initialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Shader), typeof(Shader)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GraphicsSettings), Member = "GetRenderPipelineSettings", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(UniversalRenderPipelineGlobalSettings), Member = "GetOrCreateAPVSceneData", ReturnType = typeof(ProbeVolumeSceneData))]
	[Calls(Type = typeof(ProbeReferenceVolume), Member = "Initialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ProbeVolumeSystemParameters&)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 11)]
	[ContainsUnimplementedInstructions]
	public UniversalRenderPipeline(UniversalRenderPipelineAsset asset) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XRSystem), Member = "get_displayActive", ReturnType = typeof(bool))]
	[Calls(Type = typeof(SupportedRenderingFeatures), Member = "get_active", ReturnType = typeof(SupportedRenderingFeatures))]
	[CallsUnknownMethods(Count = 1)]
	private static void AdjustUIOverlayOwnership(int cameraCount) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Settings), Member = "set_jitterScale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private static void ApplyTaaRenderingDebugOverrides(ref Settings taaSettings) { }

	[CalledBy(Type = typeof(UniversalRenderPipeline), Member = "RenderSingleCamera", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), typeof(UniversalCameraData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalRenderPipeline), Member = "CreateShadowAtlasAndCullShadowCasters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UniversalLightData), typeof(UniversalShadowData), typeof(UniversalCameraData), typeof(CullingResults&), typeof(ScriptableRenderContext&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(AdditionalLightsShadowAtlasLayout), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UniversalLightData), typeof(UniversalShadowData), typeof(UniversalCameraData)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	private static AdditionalLightsShadowAtlasLayout BuildAdditionalLightsShadowAtlasLayout(UniversalLightData lightData, UniversalShadowData shadowData, UniversalCameraData cameraData) { }

	[CalledBy(Type = typeof(UniversalRenderPipeline), Member = "RenderSingleCamera", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), typeof(UniversalCameraData)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ContextContainer), Member = "Get", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(UniversalCameraData), Member = "get_isPreviewCamera", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CameraData), Member = "get_isHdrEnabled", ReturnType = typeof(Boolean&))]
	[Calls(Type = typeof(CameraData), Member = "get_postProcessEnabled", ReturnType = typeof(Boolean&))]
	[Calls(Type = typeof(UniversalRenderPipeline), Member = "get_asset", ReturnType = typeof(UniversalRenderPipelineAsset))]
	[Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(SystemInfo), Member = "IsFormatSupported", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GraphicsFormat), typeof(GraphicsFormatUsage)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(SystemInfo), Member = "GetGraphicsFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DefaultFormat)}, ReturnType = typeof(GraphicsFormat))]
	[Calls(Type = typeof(RenderTextureDescriptor), Member = "set_graphicsFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GraphicsFormat)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	private static void CheckAndApplyDebugSettings(ref RenderingData renderingData) { }

	[CalledBy(Type = typeof(UniversalRenderPipeline), Member = "RenderCameraStack", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), typeof(Camera), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalRenderPipeline), Member = "InitializeAdditionalCameraData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(UniversalAdditionalCameraData), typeof(bool), typeof(bool), typeof(UniversalCameraData)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(VolumeManager), Member = "get_instance", ReturnType = typeof(VolumeManager))]
	[Calls(Type = typeof(VolumeStack), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(DepthOfField), Member = "IsActive", ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private static bool CheckPostProcessForDepth() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UniversalCameraData), Member = "IsTemporalAAEnabled", ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsInvalidInstructions]
	private static bool CheckPostProcessForDepth(UniversalCameraData cameraData) { }

	[CalledBy(Type = typeof(UniversalRenderPipeline), Member = "RenderSingleCameraInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), typeof(Camera), typeof(UniversalAdditionalCameraData&), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalRenderPipeline), Member = "RenderCameraStack", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), typeof(Camera), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UniversalRenderPipeline), Member = "InitializeStackedCameraData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(UniversalAdditionalCameraData), typeof(UniversalCameraData)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UniversalRenderPipeline), Member = "CreateRenderTextureDescriptor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(UniversalCameraData), typeof(bool), typeof(HDRColorBufferPrecision), typeof(int), typeof(bool), typeof(bool)}, ReturnType = typeof(RenderTextureDescriptor))]
	[Calls(Type = typeof(RenderTexture), Member = "get_antiAliasing", ReturnType = typeof(int))]
	[Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Graphics), Member = "get_preserveFramebufferAlpha", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Camera), Member = "get_targetTexture", ReturnType = typeof(RenderTexture))]
	[Calls(Type = typeof(Camera), Member = "get_allowMSAA", ReturnType = typeof(bool))]
	[Calls(Type = typeof(ContextContainer), Member = "Create", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(GraphicsFormatUtility), Member = "GetAlphaComponentCount", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GraphicsFormat)}, ReturnType = typeof(uint))]
	[Calls(Type = typeof(UniversalRenderPipelineAsset), Member = "get_scriptableRenderer", ReturnType = typeof(ScriptableRenderer))]
	[Calls(Type = typeof(UniversalRenderPipeline), Member = "get_asset", ReturnType = typeof(UniversalRenderPipelineAsset))]
	[Calls(Type = typeof(Camera), Member = "get_cameraType", ReturnType = typeof(CameraType))]
	[Calls(Type = typeof(UniversalAdditionalCameraData), Member = "get_scriptableRenderer", ReturnType = typeof(ScriptableRenderer))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(GraphicsFormatUtility), Member = "HasAlphaChannel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GraphicsFormat)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 15)]
	[ContainsUnimplementedInstructions]
	private static UniversalCameraData CreateCameraData(ContextContainer frameData, Camera camera, UniversalAdditionalCameraData additionalCameraData, bool resolveFinalTarget) { }

	[CalledBy(Type = typeof(UniversalRenderPipeline), Member = "RenderSingleCamera", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), typeof(UniversalCameraData)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ContextContainer), Member = "Create", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(UniversalRenderPipeline), Member = "GetMainLightIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UniversalRenderPipelineAsset), typeof(Unity.Collections.NativeArray`1<UnityEngine.Rendering.VisibleLight>)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(UniversalRenderPipeline), Member = "get_maxVisibleAdditionalLights", ReturnType = typeof(int))]
	[Calls(Type = typeof(Math), Member = "Min", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(UniversalRenderPipelineAsset), Member = "ShouldUseReflectionProbeBlending", ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 4)]
	[ContainsUnimplementedInstructions]
	private static UniversalLightData CreateLightData(ContextContainer frameData, UniversalRenderPipelineAsset settings, NativeArray<VisibleLight> visibleLights) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ContextContainer), Member = "Create", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(ContextContainer), Member = "Get", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[CallsUnknownMethods(Count = 1)]
	private static UniversalPostProcessingData CreatePostProcessingData(ContextContainer frameData, UniversalRenderPipelineAsset settings) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ContextContainer), Member = "Get", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(UniversalRenderPipelineAsset), Member = "ShouldUseReflectionProbeBlending", ReturnType = typeof(bool))]
	[Calls(Type = typeof(UniversalRenderPipeline), Member = "GetPerObjectLightFlags", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool), typeof(bool)}, ReturnType = typeof(PerObjectData))]
	[Calls(Type = typeof(UniversalRenderer), Member = "get_renderingModeActual", ReturnType = typeof(RenderingMode))]
	[CallsUnknownMethods(Count = 2)]
	private static UniversalRenderingData CreateRenderingData(ContextContainer frameData, UniversalRenderPipelineAsset settings, CommandBuffer cmd, bool isForwardPlus, ScriptableRenderer renderer) { }

	[CalledBy(Type = typeof(UniversalRenderPipeline), Member = "CreateCameraData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ContextContainer), typeof(Camera), typeof(UniversalAdditionalCameraData), typeof(bool)}, ReturnType = typeof(UniversalCameraData))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(RenderTextureDescriptor), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Camera), Member = "get_allowDynamicResolution", ReturnType = typeof(bool))]
	[Calls(Type = typeof(RenderTextureDescriptor), Member = "set_bindMS", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderTextureDescriptor), Member = "set_enableRandomWrite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderTextureDescriptor), Member = "set_sRGB", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(QualitySettings), Member = "get_activeColorSpace", ReturnType = typeof(ColorSpace))]
	[Calls(Type = typeof(RenderTextureDescriptor), Member = "set_depthBufferBits", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SystemInfo), Member = "IsFormatSupported", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GraphicsFormat), typeof(GraphicsFormatUsage)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(RenderTextureDescriptor), Member = "set_graphicsFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GraphicsFormat)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SystemInfo), Member = "GetGraphicsFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DefaultFormat)}, ReturnType = typeof(GraphicsFormat))]
	[Calls(Type = typeof(Camera), Member = "get_cameraType", ReturnType = typeof(CameraType))]
	[Calls(Type = typeof(UniversalCameraData), Member = "get_scaledHeight", ReturnType = typeof(int))]
	[Calls(Type = typeof(UniversalCameraData), Member = "get_scaledWidth", ReturnType = typeof(int))]
	[Calls(Type = typeof(RenderTexture), Member = "get_descriptor", ReturnType = typeof(RenderTextureDescriptor))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Camera), Member = "get_targetTexture", ReturnType = typeof(RenderTexture))]
	[Calls(Type = typeof(RenderTextureDescriptor), Member = "set_useDynamicScale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SystemInfo), Member = "GetRenderTextureSupportedMSAASampleCount", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTextureDescriptor)}, ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	internal static RenderTextureDescriptor CreateRenderTextureDescriptor(Camera camera, UniversalCameraData cameraData, bool isHdrEnabled, HDRColorBufferPrecision requestHDRColorBufferPrecision, int msaaSamples, bool needsAlpha, bool requiresOpaqueTexture) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ShadowUtils), Member = "GetMaxTileResolutionInAtlas", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(UniversalRenderPipeline), Member = "BuildAdditionalLightsShadowAtlasLayout", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UniversalLightData), typeof(UniversalShadowData), typeof(UniversalCameraData)}, ReturnType = typeof(AdditionalLightsShadowAtlasLayout))]
	[Calls(Type = typeof(ShadowCulling), Member = "CullShadowCasters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext&), typeof(UniversalShadowData), typeof(AdditionalLightsShadowAtlasLayout&), typeof(CullingResults&)}, ReturnType = typeof(Unity.Collections.NativeArray`1<UnityEngine.Rendering.Universal.URPLightShadowCullingInfos>))]
	[CallsUnknownMethods(Count = 1)]
	private static void CreateShadowAtlasAndCullShadowCasters(UniversalLightData lightData, UniversalShadowData shadowData, UniversalCameraData cameraData, ref CullingResults cullResults, ref ScriptableRenderContext context) { }

	[CalledBy(Type = typeof(UniversalRenderPipeline), Member = "RenderSingleCamera", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), typeof(UniversalCameraData)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.Collections.Generic.List`1<UnityEngine.Vector4>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector4)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Light), Member = "get_shadowNormalBias", ReturnType = typeof(float))]
	[Calls(Type = typeof(Light), Member = "get_shadowBias", ReturnType = typeof(float))]
	[Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(GameObject), Member = "TryGetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Light), Member = "get_shadows", ReturnType = typeof(LightShadows))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisibleLight), Member = "get_light", ReturnType = typeof(Light))]
	[Calls(Type = typeof(ContextContainer), Member = "Get", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(ContextContainer), Member = "Create", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(Light), Member = "get_shadowResolution", ReturnType = typeof(LightShadowResolution))]
	[Calls(Type = typeof(UniversalRenderPipelineAsset), Member = "GetAdditionalLightsShadowResolution", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 11)]
	[CallsUnknownMethods(Count = 42)]
	[ContainsUnimplementedInstructions]
	private static UniversalShadowData CreateShadowData(ContextContainer frameData, UniversalRenderPipelineAsset urpAsset, bool isForwardPlus) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ContextContainer), Member = "Create", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[CallsUnknownMethods(Count = 1)]
	private static UniversalResourceData CreateUniversalResourceData(ContextContainer frameData) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AdditionalLightsShadowAtlasLayout), Member = "ClearStaticCaches", ReturnType = typeof(void))]
	[Calls(Type = typeof(UniversalCameraHistory), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(Component), Member = "TryGetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Camera), Member = "get_allCameras", ReturnType = typeof(Camera[]))]
	[Calls(Type = typeof(VolumeManager), Member = "Deinitialize", ReturnType = typeof(void))]
	[Calls(Type = typeof(VolumeManager), Member = "get_instance", ReturnType = typeof(VolumeManager))]
	[Calls(Type = typeof(ConstantBuffer), Member = "ReleaseAll", ReturnType = typeof(void))]
	[Calls(Type = typeof(Lightmapping), Member = "ResetDelegate", ReturnType = typeof(void))]
	[Calls(Type = typeof(RTHandleResourcePool), Member = "Cleanup", ReturnType = typeof(void))]
	[Calls(Type = typeof(XRSystem), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(ShaderData), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(ShaderData), Member = "get_instance", ReturnType = typeof(ShaderData))]
	[Calls(Type = typeof(SupportedRenderingFeatures), Member = "set_active", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SupportedRenderingFeatures)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SupportedRenderingFeatures), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(UniversalRenderPipelineAsset), Member = "DestroyRenderers", ReturnType = typeof(void))]
	[Calls(Type = typeof(Blitter), Member = "Cleanup", ReturnType = typeof(void))]
	[Calls(Type = typeof(ProbeReferenceVolume), Member = "Cleanup", ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderGraph), Member = "Cleanup", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	protected virtual void Dispose(bool disposing) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Camera), Member = "get_allCameras", ReturnType = typeof(Camera[]))]
	[Calls(Type = typeof(Component), Member = "TryGetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(UniversalCameraHistory), Member = "Dispose", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	private void DisposeAdditionalCameraData() { }

	[CallerCount(Count = 72)]
	[Calls(Type = typeof(GraphicsSettings), Member = "get_currentRenderPipeline", ReturnType = typeof(RenderPipelineAsset))]
	public static UniversalRenderPipelineAsset get_asset() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	internal static bool get_canOptimizeScreenMSAASamples() { }

	[CallerCount(Count = 12)]
	[DeduplicatedMethod]
	public virtual RenderPipelineGlobalSettings get_defaultSettings() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UniversalRenderPipeline), Member = "get_maxVisibleAdditionalLights", ReturnType = typeof(int))]
	internal static int get_lightsPerTile() { }

	[CallerCount(Count = 0)]
	public static int get_maxNumIterationsEnclosingSphere() { }

	[CallerCount(Count = 19)]
	[DeduplicatedMethod]
	public static int get_maxPerObjectLights() { }

	[CalledBy(Type = typeof(UniversalRenderPipelineAsset), Member = "set_renderScale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalRenderPipelineAsset), Member = "ValidateRenderScale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(float))]
	[CallerCount(Count = 2)]
	public static float get_maxRenderScale() { }

	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	public static float get_maxShadowBias() { }

	[CalledBy(Type = typeof(ForwardLights), Member = "CreateForwardPlusBuffers", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ForwardLights), Member = "PreSetup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UniversalRenderingData), typeof(UniversalCameraData), typeof(UniversalLightData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ForwardLights), Member = "SetupLights", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnsafeCommandBuffer), typeof(UniversalRenderingData), typeof(UniversalCameraData), typeof(UniversalLightData)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(UniversalRenderPipeline), Member = "get_maxVisibleAdditionalLights", ReturnType = typeof(int))]
	internal static int get_maxTileWords() { }

	[CalledBy(Type = typeof(Settings), Member = "Create", ReturnType = typeof(Settings))]
	[CalledBy(Type = typeof(UniversalRenderer), Member = "SetupCullingParameters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableCullingParameters&), typeof(CameraData&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(AdditionalLightsShadowAtlasLayout), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UniversalLightData), typeof(UniversalShadowData), typeof(UniversalCameraData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalRenderPipeline), Member = "get_lightsPerTile", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(UniversalRenderPipeline), Member = "get_maxTileWords", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(UniversalRenderPipeline), Member = "get_maxVisibleReflectionProbes", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(AdditionalLightsShadowCasterPass), Member = "Setup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UniversalRenderingData), typeof(UniversalCameraData), typeof(UniversalLightData), typeof(UniversalShadowData)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(UniversalRenderPipeline), Member = "CreateLightData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ContextContainer), typeof(UniversalRenderPipelineAsset), typeof(Unity.Collections.NativeArray`1<UnityEngine.Rendering.VisibleLight>)}, ReturnType = typeof(UniversalLightData))]
	[CalledBy(Type = typeof(AdditionalLightsShadowCasterPass), Member = "SetupForEmptyRendering", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool), typeof(UniversalLightData), typeof(UniversalShadowData)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(AdditionalLightsShadowCasterPass), Member = "SetShadowParamsForEmptyShadowmap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RasterCommandBuffer)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ForwardLights), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InitParams)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ForwardLights), Member = "SetupAdditionalLightConstants", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnsafeCommandBuffer), typeof(CullingResults&), typeof(UniversalLightData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ForwardLights), Member = "SetupPerObjectLightIndices", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CullingResults), typeof(UniversalLightData)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(AdditionalLightsShadowCasterPass), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderPassEvent)}, ReturnType = typeof(void))]
	[CallerCount(Count = 16)]
	[Calls(Type = typeof(PlatformAutoDetect), Member = "get_isShaderAPIMobileDefined", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Graphics), Member = "get_minOpenGLESVersion", ReturnType = typeof(OpenGLESVersion))]
	[CallsDeduplicatedMethods(Count = 4)]
	public static int get_maxVisibleAdditionalLights() { }

	[CalledBy(Type = typeof(ReflectionProbeManager), Member = "Init", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ReflectionProbeManager), Member = "UpdateGpuData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(CullingResults&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ForwardLights), Member = "PreSetup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UniversalRenderingData), typeof(UniversalCameraData), typeof(UniversalLightData)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UniversalRenderPipeline), Member = "get_maxVisibleAdditionalLights", ReturnType = typeof(int))]
	[Calls(Type = typeof(Math), Member = "Min", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	internal static int get_maxVisibleReflectionProbes() { }

	[CallerCount(Count = 5)]
	[DeduplicatedMethod]
	internal static int get_maxZBinWords() { }

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public static float get_minRenderScale() { }

	[CallerCount(Count = 15)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	internal UniversalRenderPipelineRuntimeTextures get_runtimeTextures() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	internal static int get_startFrameScreenMSAASamples() { }

	[CalledBy(Type = typeof(ColorGradingLutPass), Member = "ExecutePass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RasterCommandBuffer), "UnityEngine.Rendering.Universal.Internal.ColorGradingLutPass+PassData", typeof(RTHandle)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	internal static void GetHDROutputGradingParameters(Tonemapping tonemapping, out Vector4 hdrOutputParameters) { }

	[CalledBy(Type = typeof(HDRDebugViewPass), Member = "GetLuminanceParameters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UniversalCameraData)}, ReturnType = typeof(Vector4))]
	[CalledBy(Type = typeof(PostProcessPass), Member = "SetupHDROutput", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HDRDisplayInformation), typeof(ColorGamut), typeof(Material), typeof(Operation), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ColorGradingLutPass), Member = "ExecutePass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RasterCommandBuffer), "UnityEngine.Rendering.Universal.Internal.ColorGradingLutPass+PassData", typeof(RTHandle)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FinalBlitPass), Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), typeof(RenderingData&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FinalBlitPass), Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(ContextContainer), typeof(UniversalCameraData), typeof(TextureHandle&), typeof(TextureHandle&), typeof(TextureHandle)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 1)]
	internal static void GetHDROutputLuminanceParameters(HDRDisplayInformation hdrDisplayInformation, ColorGamut hdrDisplayColorGamut, Tonemapping tonemapping, out Vector4 hdrOutputParameters) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = "TryGetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&"}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private int GetLastBaseCameraIndex(List<Camera> cameras) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Matrix4x4), Member = "GetColumn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Vector4))]
	[Calls(Type = typeof(UniversalRenderPipeline), Member = "GetSpotAngleAttenuation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(System.Nullable`1<System.Single>), typeof(Vector4&)}, ReturnType = typeof(void))]
	public static void GetLightAttenuationAndSpotDirection(LightType lightType, float lightRange, Matrix4x4 lightLocalToWorldMatrix, float spotAngle, Nullable<Single> innerSpotAngle, out Vector4 lightAttenuation, out Vector4 lightSpotDir) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private static Vector3 GetMainLightCascadeSplit(int mainLightShadowCascadesCount, UniversalRenderPipelineAsset urpAsset) { }

	[CalledBy(Type = typeof(UniversalRenderPipeline), Member = "CreateLightData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ContextContainer), typeof(UniversalRenderPipelineAsset), typeof(Unity.Collections.NativeArray`1<UnityEngine.Rendering.VisibleLight>)}, ReturnType = typeof(UniversalLightData))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(RenderSettings), Member = "get_sun", ReturnType = typeof(Light))]
	[Calls(Type = typeof(VisibleLight), Member = "get_light", ReturnType = typeof(Light))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Light), Member = "get_intensity", ReturnType = typeof(float))]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 3)]
	private static int GetMainLightIndex(UniversalRenderPipelineAsset settings, NativeArray<VisibleLight> visibleLights) { }

	[CalledBy(Type = typeof(UniversalRenderPipeline), Member = "RenderSingleCamera", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), typeof(UniversalCameraData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalRenderPipeline), Member = "CreateRenderingData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ContextContainer), typeof(UniversalRenderPipelineAsset), typeof(CommandBuffer), typeof(bool), typeof(ScriptableRenderer)}, ReturnType = typeof(UniversalRenderingData))]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	private static PerObjectData GetPerObjectLightFlags(int additionalLightsCount, bool isForwardPlus, bool reflectionProbeBlending) { }

	[CallerCount(Count = 0)]
	internal static void GetPunctualLightDistanceAttenuation(float lightRange, ref Vector4 lightAttenuation) { }

	[CalledBy(Type = typeof(UniversalRenderPipeline), Member = "RenderSingleCameraInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), typeof(Camera), typeof(UniversalAdditionalCameraData&), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalRenderPipeline), Member = "RenderCameraStack", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), typeof(Camera), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(UniversalAdditionalCameraData), Member = "get_scriptableRenderer", ReturnType = typeof(ScriptableRenderer))]
	[Calls(Type = typeof(Camera), Member = "get_cameraType", ReturnType = typeof(CameraType))]
	[Calls(Type = typeof(UniversalRenderPipeline), Member = "get_asset", ReturnType = typeof(UniversalRenderPipelineAsset))]
	[Calls(Type = typeof(UniversalRenderPipelineAsset), Member = "get_scriptableRenderer", ReturnType = typeof(ScriptableRenderer))]
	[CallsUnknownMethods(Count = 1)]
	private static ScriptableRenderer GetRenderer(Camera camera, UniversalAdditionalCameraData additionalCameraData) { }

	[CalledBy(Type = typeof(UniversalRenderPipeline), Member = "GetLightAttenuationAndSpotDirection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LightType), typeof(float), typeof(Matrix4x4), typeof(float), typeof(System.Nullable`1<System.Single>), typeof(Vector4&), typeof(Vector4&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalRenderPipeline), Member = "InitializeLightConstants_Common", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Unity.Collections.NativeArray`1<UnityEngine.Rendering.VisibleLight>), typeof(int), typeof(Vector4&), typeof(Vector4&), typeof(Vector4&), typeof(Vector4&), typeof(Vector4&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(System.Nullable`1<System.Single>), Member = "get_Value", ReturnType = typeof(float))]
	[CallsUnknownMethods(Count = 4)]
	internal static void GetSpotAngleAttenuation(float spotAngle, Nullable<Single> innerSpotAngle, ref Vector4 lightAttenuation) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Matrix4x4), Member = "GetColumn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Vector4))]
	internal static void GetSpotDirection(ref Matrix4x4 lightLocalToWorldMatrix, out Vector4 lightSpotDir) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UniversalRenderPipeline), Member = "HDROutputForMainDisplayIsActive", ReturnType = typeof(bool))]
	[Calls(Type = typeof(XRSystem), Member = "get_displayActive", ReturnType = typeof(bool))]
	[Calls(Type = typeof(XRSystem), Member = "get_isHDRDisplayOutputActive", ReturnType = typeof(bool))]
	internal static bool HDROutputForAnyDisplayIsActive() { }

	[CalledBy(Type = typeof(UniversalCameraData), Member = "get_isHDROutputActive", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(UniversalRenderPipeline), Member = "RenderCameraStack", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), typeof(Camera), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalRenderPipeline), Member = "HDROutputForAnyDisplayIsActive", ReturnType = typeof(bool))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UniversalRenderPipeline), Member = "get_asset", ReturnType = typeof(UniversalRenderPipelineAsset))]
	[Calls(Type = typeof(HDROutputSettings), Member = "get_main", ReturnType = typeof(HDROutputSettings))]
	[Calls(Type = typeof(HDROutputSettings), Member = "get_available", ReturnType = typeof(bool))]
	[Calls(Type = typeof(HDROutputSettings), Member = "get_active", ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	internal static bool HDROutputForMainDisplayIsActive() { }

	[CalledBy(Type = typeof(UniversalRenderPipeline), Member = "RenderSingleCameraInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), typeof(Camera), typeof(UniversalAdditionalCameraData&), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalRenderPipeline), Member = "RenderCameraStack", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), typeof(Camera), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(UniversalCameraHistory), Member = "GetHistoryForWrite", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"Type"}, ReturnType = "Type")]
	[Calls(Type = typeof(Camera), Member = "get_backgroundColor", ReturnType = typeof(Color))]
	[Calls(Type = typeof(Transform), Member = "get_position", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(UniversalCameraData), Member = "SetViewProjectionAndJitterMatrix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Matrix4x4), typeof(Matrix4x4), typeof(Matrix4x4)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Camera), Member = "get_worldToCameraMatrix", ReturnType = typeof(Matrix4x4))]
	[Calls(Type = typeof(TemporalAA), Member = "CalculateJitterMatrix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UniversalCameraData), typeof(JitterFunc)}, ReturnType = typeof(Matrix4x4))]
	[Calls(Type = typeof(Settings), Member = "set_jitterScale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Camera), Member = "get_aspect", ReturnType = typeof(float))]
	[Calls(Type = typeof(Camera), Member = "get_pixelRect", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(Camera), Member = "get_orthographic", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Camera), Member = "get_projectionMatrix", ReturnType = typeof(Matrix4x4))]
	[Calls(Type = typeof(UniversalCameraData), Member = "IsSTPEnabled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(UniversalCameraHistory), Member = "RequestAccess", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"Type"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CoreUtils), Member = "ConvertSRGBToActiveColorSpace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(Color))]
	[Calls(Type = typeof(GPUResidentDrawer), Member = "IsInstanceOcclusionCullingEnabled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(UniversalRenderPipeline), Member = "CheckPostProcessForDepth", ReturnType = typeof(bool))]
	[Calls(Type = typeof(UniversalCameraData), Member = "IsTemporalAAEnabled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(UniversalCameraData), Member = "get_isSceneViewCamera", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Camera), Member = "get_nearClipPlane", ReturnType = typeof(float))]
	[Calls(Type = typeof(Camera), Member = "get_farClipPlane", ReturnType = typeof(float))]
	[Calls(Type = typeof(UniversalRenderPipelineAsset), Member = "get_scriptableRenderer", ReturnType = typeof(ScriptableRenderer))]
	[Calls(Type = typeof(UniversalRenderPipeline), Member = "get_asset", ReturnType = typeof(UniversalRenderPipelineAsset))]
	[Calls(Type = typeof(Camera), Member = "get_cameraType", ReturnType = typeof(CameraType))]
	[Calls(Type = typeof(UniversalAdditionalCameraData), Member = "get_scriptableRenderer", ReturnType = typeof(ScriptableRenderer))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(UniversalCameraData), Member = "get_isHDROutputActive", ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 22)]
	[ContainsUnimplementedInstructions]
	private static void InitializeAdditionalCameraData(Camera camera, UniversalAdditionalCameraData additionalCameraData, bool resolveFinalTarget, bool isLastBaseCamera, UniversalCameraData cameraData) { }

	[CalledBy(Type = typeof(DeferredLights), Member = "SetupMainLightConstants", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(UniversalLightData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DeferredLights), Member = "RenderStencilDirectionalLights", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RasterCommandBuffer), typeof(bool), typeof(UniversalLightData), typeof(UniversalShadowData), typeof(Unity.Collections.NativeArray`1<UnityEngine.Rendering.VisibleLight>), typeof(bool), typeof(bool), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DeferredLights), Member = "RenderStencilPointLights", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RasterCommandBuffer), typeof(bool), typeof(UniversalLightData), typeof(UniversalShadowData), typeof(Unity.Collections.NativeArray`1<UnityEngine.Rendering.VisibleLight>), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DeferredLights), Member = "RenderStencilSpotLights", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RasterCommandBuffer), typeof(bool), typeof(UniversalLightData), typeof(UniversalShadowData), typeof(Unity.Collections.NativeArray`1<UnityEngine.Rendering.VisibleLight>), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ForwardLights), Member = "InitializeLightConstants", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Unity.Collections.NativeArray`1<UnityEngine.Rendering.VisibleLight>), typeof(int), typeof(bool), typeof(Vector4&), typeof(Vector4&), typeof(Vector4&), typeof(Vector4&), typeof(Vector4&), typeof(UInt32&), typeof(Boolean&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ForwardLights), Member = "SetupMainLightConstants", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnsafeCommandBuffer), typeof(UniversalLightData)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(IndexOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Light), Member = "get_bakingOutput", ReturnType = typeof(LightBakingOutput))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(UniversalRenderPipeline), Member = "GetSpotAngleAttenuation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(System.Nullable`1<System.Single>), typeof(Vector4&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Nullable`1<System.Single>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Matrix4x4), Member = "GetColumn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Vector4))]
	[Calls(Type = typeof(VisibleLight), Member = "get_spotAngle", ReturnType = typeof(float))]
	[Calls(Type = typeof(VisibleLight), Member = "get_range", ReturnType = typeof(float))]
	[Calls(Type = typeof(VisibleLight), Member = "get_localToWorldMatrix", ReturnType = typeof(Matrix4x4))]
	[Calls(Type = typeof(VisibleLight), Member = "get_light", ReturnType = typeof(Light))]
	[Calls(Type = typeof(Light), Member = "get_innerSpotAngle", ReturnType = typeof(float))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 5)]
	public static void InitializeLightConstants_Common(NativeArray<VisibleLight> lights, int lightIndex, out Vector4 lightPos, out Vector4 lightColor, out Vector4 lightAttenuation, out Vector4 lightSpotDir, out Vector4 lightOcclusionProbeChannel) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ShadowUtils), Member = "GetMaxTileResolutionInAtlas", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 1)]
	private static void InitializeMainLightShadowResolution(UniversalShadowData shadowData) { }

	[CalledBy(Type = typeof(UniversalRenderPipeline), Member = "CreateCameraData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ContextContainer), typeof(Camera), typeof(UniversalAdditionalCameraData), typeof(bool)}, ReturnType = typeof(UniversalCameraData))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Camera), Member = "get_allowHDR", ReturnType = typeof(bool))]
	[Calls(Type = typeof(XRSystem), Member = "SetRenderScale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UniversalRenderPipeline), Member = "ResolveUpscalingFilterSelection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(float), typeof(UpscalingFilterSelection), typeof(bool)}, ReturnType = typeof(ImageUpscalingFilter))]
	[Calls(Type = typeof(RenderGraphSettings), Member = "get_enableRenderCompatibilityMode", ReturnType = typeof(bool))]
	[Calls(Type = typeof(GraphicsSettings), Member = "TryGetRenderPipelineSettings", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Camera), Member = "get_pixelHeight", ReturnType = typeof(int))]
	[Calls(Type = typeof(Camera), Member = "get_pixelWidth", ReturnType = typeof(int))]
	[Calls(Type = typeof(Camera), Member = "get_pixelRect", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(Camera), Member = "get_rect", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Camera), Member = "get_opaqueSortMode", ReturnType = typeof(OpaqueSortMode))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(XRSystem), Member = "get_displayActive", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(UniversalCameraData), Member = "get_isSceneViewCamera", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Camera), Member = "get_cameraType", ReturnType = typeof(CameraType))]
	[Calls(Type = typeof(Camera), Member = "get_targetTexture", ReturnType = typeof(RenderTexture))]
	[Calls(Type = typeof(UniversalRenderPipeline), Member = "get_asset", ReturnType = typeof(UniversalRenderPipelineAsset))]
	[Calls(Type = "Unity.RenderPipelines.Core.Runtime.Shared.CameraCaptureBridge", Member = "GetCachedCaptureActionsEnumerator", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(System.Collections.Generic.IEnumerator`1<System.Action`2<UnityEngine.Rendering.RenderTargetIdentifier, UnityEngine.Rendering.CommandBuffer>>))]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 13)]
	[ContainsUnimplementedInstructions]
	private static void InitializeStackedCameraData(Camera baseCamera, UniversalAdditionalCameraData baseAdditionalCameraData, UniversalCameraData cameraData) { }

	[CalledBy(Type = typeof(UniversalRenderPipeline), Member = "RenderSingleCameraInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), typeof(Camera), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Camera), Member = "get_cameraType", ReturnType = typeof(CameraType))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	[ContainsUnimplementedInstructions]
	public static bool IsGameCamera(Camera camera) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 4)]
	[DeduplicatedMethod]
	protected virtual bool IsRenderRequestSupported(Camera camera, RequestData data) { }

	[CalledBy(Type = typeof(ScriptableRenderer), Member = "SetNativeRenderPassMRTAttachmentList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderPass), typeof(UniversalCameraData), typeof(bool), typeof(ClearFlag)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScriptableRenderer), Member = "SetNativeRenderPassAttachmentList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderPass), typeof(UniversalCameraData), typeof(RTHandle), typeof(RTHandle), typeof(ClearFlag), typeof(Color)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(SystemInfo), Member = "GetGraphicsFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DefaultFormat)}, ReturnType = typeof(GraphicsFormat))]
	[Calls(Type = typeof(SystemInfo), Member = "IsFormatSupported", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GraphicsFormat), typeof(GraphicsFormatUsage)}, ReturnType = typeof(bool))]
	internal static GraphicsFormat MakeRenderTextureGraphicsFormat(bool isHdrEnabled, HDRColorBufferPrecision requestHDRColorBufferPrecision, bool needsAlpha) { }

	[CalledBy(Type = typeof(PostProcessPass), Member = "RenderFinalPass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(RenderingData&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PostProcessPass), Member = "RenderFinalPassRenderGraph", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(ContextContainer), typeof(TextureHandle&), typeof(TextureHandle&), typeof(TextureHandle&), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(SystemInfo), Member = "IsFormatSupported", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GraphicsFormat), typeof(GraphicsFormatUsage)}, ReturnType = typeof(bool))]
	internal static GraphicsFormat MakeUnormRenderTextureGraphicsFormat() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameObject), Member = "TryGetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Graphics), Member = "SetRenderTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTexture)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Enum), Member = "GetName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(Graphics), Member = "CopyTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture), typeof(int), typeof(int), typeof(Texture), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(PooledObject), Member = "System.IDisposable.Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(ContextRenderingScope), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(CameraRenderingScope), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(UniversalRenderPipeline), Member = "RenderSingleCameraInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), typeof(Camera), typeof(UniversalAdditionalCameraData&), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(CameraRenderingScope), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), typeof(Camera)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ContextRenderingScope), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), typeof(System.Collections.Generic.List`1<UnityEngine.Camera>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Camera), Member = "set_targetTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTexture)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(RenderTexture), Member = "GetTemporary", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTextureDescriptor)}, ReturnType = typeof(RenderTexture))]
	[Calls(Type = typeof(Math), Member = "Pow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double), typeof(double)}, ReturnType = typeof(double))]
	[Calls(Type = typeof(RenderTextureDescriptor), Member = "set_colorFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTextureFormat)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderTexture), Member = "get_format", ReturnType = typeof(RenderTextureFormat))]
	[Calls(Type = typeof(RenderTexture), Member = "get_descriptor", ReturnType = typeof(RenderTextureDescriptor))]
	[Calls(Type = typeof(Camera), Member = "get_targetTexture", ReturnType = typeof(RenderTexture))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Debug), Member = "LogWarning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderTexture), Member = "ReleaseTemporary", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTexture)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 13)]
	[CallsUnknownMethods(Count = 10)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	protected virtual void ProcessRenderRequests(ScriptableRenderContext context, Camera camera, RequestData renderRequest) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Time), Member = "get_frameCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(RenderGraph), Member = "BeginRecording", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraphParameters&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ScriptableRenderer), Member = "RecordRenderGraph", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(ScriptableRenderContext)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderGraph), Member = "EndRecordingAndExecute", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	private static void RecordAndExecuteRenderGraph(RenderGraph renderGraph, ScriptableRenderContext context, ScriptableRenderer renderer, CommandBuffer cmd, Camera camera, string cameraName) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ScriptableRenderer), Member = "RecordRenderGraph", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(ScriptableRenderContext)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private static void RecordRenderGraph(RenderGraph renderGraph, ScriptableRenderContext context, ScriptableRenderer renderer) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = "TryGetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(RTHandleResourcePool), Member = "PurgeUnusedResources", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Time), Member = "get_frameCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(RenderGraph), Member = "EndFrame", ReturnType = typeof(void))]
	[Calls(Type = typeof(UniversalRenderPipeline), Member = "RenderCameraStack", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), typeof(Camera), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CameraRenderingScope), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(UniversalRenderPipeline), Member = "RenderSingleCameraInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), typeof(Camera), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UniversalRenderPipeline), Member = "UpdateVolumeFramework", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(UniversalAdditionalCameraData)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CameraRenderingScope), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), typeof(Camera)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Camera), Member = "get_cameraType", ReturnType = typeof(CameraType))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ContextRenderingScope), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Sort", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Comparison`1<System.Object>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XRSystem), Member = "SetDisplayMSAASamples", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MSAASamples)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UniversalRenderPipeline), Member = "get_asset", ReturnType = typeof(UniversalRenderPipelineAsset))]
	[Calls(Type = typeof(UniversalRenderPipeline), Member = "SetupPerFrameShaderConstants", ReturnType = typeof(void))]
	[Calls(Type = typeof(GraphicsSettings), Member = "set_lightsUseColorTemperature", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GraphicsSettings), Member = "set_lightsUseLinearIntensity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(QualitySettings), Member = "get_activeColorSpace", ReturnType = typeof(ColorSpace))]
	[Calls(Type = typeof(ContextRenderingScope), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), typeof(System.Collections.Generic.List`1<UnityEngine.Camera>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SupportedRenderingFeatures), Member = "get_active", ReturnType = typeof(SupportedRenderingFeatures))]
	[Calls(Type = typeof(XRSystem), Member = "get_displayActive", ReturnType = typeof(bool))]
	[Calls(Type = typeof(UniversalRenderPipeline), Member = "SetHDRState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.Camera>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RTHandles), Member = "SetHardwareDynamicResolutionState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 13)]
	[ContainsUnimplementedInstructions]
	protected virtual void Render(ScriptableRenderContext renderContext, List<Camera> cameras) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	protected virtual void Render(ScriptableRenderContext renderContext, Camera[] cameras) { }

	[CalledBy(Type = typeof(UniversalRenderPipeline), Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), typeof(System.Collections.Generic.List`1<UnityEngine.Camera>)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(XRLayout), Member = "AddCamera", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XRPass), Member = "get_enabled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(UniversalRenderPipeline), Member = "UpdateCameraStereoMatrices", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(XRPass)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XRSystem), Member = "GetRenderViewportScale", ReturnType = typeof(float))]
	[Calls(Type = typeof(ScalableBufferManager), Member = "ResizeBuffers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CameraRenderingScope), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), typeof(Camera)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UniversalRenderPipeline), Member = "UpdateVolumeFramework", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(UniversalAdditionalCameraData)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UniversalRenderPipeline), Member = "CreateCameraData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ContextContainer), typeof(Camera), typeof(UniversalAdditionalCameraData), typeof(bool)}, ReturnType = typeof(UniversalCameraData))]
	[Calls(Type = typeof(UniversalRenderPipeline), Member = "UpdateCameraData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UniversalCameraData), typeof(XRPass&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XRLayout), Member = "ReconfigurePass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XRPass), typeof(Camera)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XRSystemUniversal), Member = "BeginLateLatching", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(XRPassUniversal)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XRPass), Member = "get_isHDRDisplayOutputActive", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Camera), Member = "get_targetTexture", ReturnType = typeof(RenderTexture))]
	[Calls(Type = typeof(UniversalRenderPipeline), Member = "RenderSingleCamera", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), typeof(UniversalCameraData)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CameraRenderingScope), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(XRSystemUniversal), Member = "EndLateLatching", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(XRPassUniversal)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UniversalAdditionalCameraData), Member = "get_camera", ReturnType = typeof(Camera))]
	[Calls(Type = typeof(CommandBufferPool), Member = "Get", ReturnType = typeof(CommandBuffer))]
	[Calls(Type = typeof(XRSystem), Member = "RenderMirrorView", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(Camera)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ScriptableRenderContext), Member = "ExecuteCommandBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ScriptableRenderContext), Member = "Submit", ReturnType = typeof(void))]
	[Calls(Type = typeof(UniversalRenderPipeline), Member = "InitializeAdditionalCameraData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(UniversalAdditionalCameraData), typeof(bool), typeof(bool), typeof(UniversalCameraData)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(XRSystem), Member = "NewLayout", ReturnType = typeof(XRLayout))]
	[Calls(Type = typeof(CommandBufferPool), Member = "Release", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Component), Member = "TryGetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(UniversalAdditionalCameraData), Member = "get_scriptableRenderer", ReturnType = typeof(ScriptableRenderer))]
	[Calls(Type = typeof(Camera), Member = "get_cameraType", ReturnType = typeof(CameraType))]
	[Calls(Type = typeof(UniversalRenderPipeline), Member = "get_asset", ReturnType = typeof(UniversalRenderPipelineAsset))]
	[Calls(Type = typeof(UniversalRenderPipelineAsset), Member = "get_scriptableRenderer", ReturnType = typeof(ScriptableRenderer))]
	[Calls(Type = typeof(ScriptableRenderer), Member = "SupportsCameraStackingType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CameraRenderType)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(GameObject), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(Object), Member = "get_name", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(UniversalRenderPipeline), Member = "HDROutputForMainDisplayIsActive", ReturnType = typeof(bool))]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Behaviour), Member = "get_isActiveAndEnabled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(UniversalRenderPipeline), Member = "GetRenderer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(UniversalAdditionalCameraData)}, ReturnType = typeof(ScriptableRenderer))]
	[Calls(Type = typeof(UniversalRenderPipeline), Member = "CheckPostProcessForDepth", ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(UniversalAdditionalCameraData), Member = "UpdateCameraStack", ReturnType = typeof(void))]
	[Calls(Type = typeof(Debug), Member = "LogWarning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XRSystem), Member = "EndLayout", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 14)]
	[CallsUnknownMethods(Count = 78)]
	[ContainsUnimplementedInstructions]
	private static void RenderCameraStack(ScriptableRenderContext context, Camera baseCamera, bool isLastBaseCamera) { }

	[CalledBy(Type = typeof(UniversalRenderPipeline), Member = "RenderSingleCameraInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), typeof(Camera), typeof(UniversalAdditionalCameraData&), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalRenderPipeline), Member = "RenderCameraStack", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), typeof(Camera), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UniversalCameraData), Member = "IsSTPRequested", ReturnType = typeof(bool))]
	[Calls(Type = typeof(UniversalRenderPipeline), Member = "GetPerObjectLightFlags", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool), typeof(bool)}, ReturnType = typeof(PerObjectData))]
	[Calls(Type = typeof(UniversalRenderPipelineAsset), Member = "ShouldUseReflectionProbeBlending", ReturnType = typeof(bool))]
	[Calls(Type = typeof(ContextContainer), Member = "Get", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(UniversalRenderPipeline), Member = "CreateShadowData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ContextContainer), typeof(UniversalRenderPipelineAsset), typeof(bool)}, ReturnType = typeof(UniversalShadowData))]
	[Calls(Type = typeof(UniversalRenderPipeline), Member = "CreateLightData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ContextContainer), typeof(UniversalRenderPipelineAsset), typeof(Unity.Collections.NativeArray`1<UnityEngine.Rendering.VisibleLight>)}, ReturnType = typeof(UniversalLightData))]
	[Calls(Type = typeof(CullingResults), Member = "get_visibleLights", ReturnType = typeof(Unity.Collections.NativeArray`1<UnityEngine.Rendering.VisibleLight>))]
	[Calls(Type = typeof(TaaHistory), Member = "Update", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTextureDescriptor&), typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(RenderingData), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ContextContainer)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XRPass), Member = "get_singlePassEnabled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(UniversalRenderer), Member = "get_renderingModeActual", ReturnType = typeof(RenderingMode))]
	[Calls(Type = typeof(GPUResidentDrawer), Member = "PostCullBeginCameraRendering", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderRequestBatcherContext)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ScriptableRenderContext), Member = "Cull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableCullingParameters&)}, ReturnType = typeof(CullingResults))]
	[Calls(Type = typeof(StpHistory), Member = "Update", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UniversalCameraData)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(UniversalRenderPipeline), Member = "CheckAndApplyDebugSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderingData&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UniversalRenderPipeline), Member = "BuildAdditionalLightsShadowAtlasLayout", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UniversalLightData), typeof(UniversalShadowData), typeof(UniversalCameraData)}, ReturnType = typeof(AdditionalLightsShadowAtlasLayout))]
	[Calls(Type = typeof(ContextContainer), Member = "Create", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(ShadowCulling), Member = "CullShadowCasters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext&), typeof(UniversalShadowData), typeof(AdditionalLightsShadowAtlasLayout&), typeof(CullingResults&)}, ReturnType = typeof(Unity.Collections.NativeArray`1<UnityEngine.Rendering.Universal.URPLightShadowCullingInfos>))]
	[Calls(Type = typeof(ScriptableRenderer), Member = "AddRenderPasses", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderingData&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ScriptableRenderer), Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), typeof(RenderingData&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Time), Member = "get_frameCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(RenderGraph), Member = "BeginRecording", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraphParameters&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ScriptableRenderer), Member = "RecordRenderGraph", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(ScriptableRenderContext)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderGraph), Member = "EndRecordingAndExecute", ReturnType = typeof(void))]
	[Calls(Type = typeof(ScriptableRenderer), Member = "FinishRenderGraphRendering", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CommandBufferPool), Member = "Release", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ScriptableRenderContext), Member = "SubmitForRenderPassValidation", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CommandBuffer), Member = "SetKeyword", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GlobalKeyword&), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Debug), Member = "LogWarning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ShadowUtils), Member = "GetMaxTileResolutionInAtlas", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(RTHandles), Member = "SetReferenceSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UniversalCameraData), Member = "IsTemporalAAEnabled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(ScriptableRenderContext), Member = "Submit", ReturnType = typeof(void))]
	[Calls(Type = typeof(XRPass), Member = "get_enabled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Camera), Member = "TryGetCullingParameters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(ScriptableCullingParameters&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Camera), Member = "get_usePhysicalProperties", ReturnType = typeof(bool))]
	[Calls(Type = typeof(ScriptableCullingParameters), Member = "get_stereoProjectionMatrix", ReturnType = typeof(Matrix4x4))]
	[Calls(Type = typeof(Camera), Member = "set_fieldOfView", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UniversalCameraData), Member = "get_isSceneViewCamera", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CommandBufferPool), Member = "Get", ReturnType = typeof(CommandBuffer))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "get_name", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ProfilingSampler), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32, System.Object>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ScriptableRenderer), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CameraRenderType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ScriptableRenderer), Member = "OnPreCullRenderPasses", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CameraData&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ScriptableRenderContext), Member = "ExecuteCommandBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CommandBuffer), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(UniversalRenderPipeline), Member = "SetupPerCameraShaderConstants", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Component), Member = "TryGetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(VolumeStack), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(UniversalRenderPipeline), Member = "get_asset", ReturnType = typeof(UniversalRenderPipelineAsset))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ProbeReferenceVolume), Member = "PerformPendingOperations", ReturnType = typeof(void))]
	[Calls(Type = typeof(Camera), Member = "get_cameraType", ReturnType = typeof(CameraType))]
	[Calls(Type = typeof(ProbeReferenceVolume), Member = "UpdateCellStreaming", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(Camera), typeof(ProbeVolumesOptions)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ScriptableRenderContext), Member = "EmitGeometryForCamera", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ProbeReferenceVolume), Member = "BindAPVRuntimeResources", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Texture2D), Member = "get_whiteTexture", ReturnType = typeof(Texture2D))]
	[Calls(Type = typeof(ProbeReferenceVolume), Member = "RenderDebug", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(ProbeVolumesOptions), typeof(Texture)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MotionVectorsPersistentData), Member = "Update", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UniversalCameraData)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 24)]
	[CallsUnknownMethods(Count = 73)]
	[ContainsUnimplementedInstructions]
	private static void RenderSingleCamera(ScriptableRenderContext context, UniversalCameraData cameraData) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UniversalRenderPipeline), Member = "RenderSingleCameraInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), typeof(Camera), typeof(bool)}, ReturnType = typeof(void))]
	[Obsolete("RenderSingleCamera is obsolete, please use RenderPipeline.SubmitRenderRequest with UniversalRenderer.SingleCameraRequest as RequestData type")]
	public static void RenderSingleCamera(ScriptableRenderContext context, Camera camera) { }

	[CalledBy(Type = typeof(UniversalRenderPipeline), Member = "ProcessRenderRequests", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"RequestData"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), typeof(Camera), "RequestData"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalRenderPipeline), Member = "RenderSingleCameraInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), typeof(Camera), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Debug), Member = "LogWarning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Camera), Member = "get_targetTexture", ReturnType = typeof(RenderTexture))]
	[Calls(Type = typeof(Camera), Member = "get_pixelWidth", ReturnType = typeof(int))]
	[Calls(Type = typeof(Camera), Member = "get_pixelHeight", ReturnType = typeof(int))]
	[Calls(Type = typeof(UniversalRenderPipeline), Member = "GetRenderer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(UniversalAdditionalCameraData)}, ReturnType = typeof(ScriptableRenderer))]
	[Calls(Type = typeof(UniversalRenderPipeline), Member = "CreateCameraData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ContextContainer), typeof(Camera), typeof(UniversalAdditionalCameraData), typeof(bool)}, ReturnType = typeof(UniversalCameraData))]
	[Calls(Type = typeof(UniversalRenderPipeline), Member = "InitializeAdditionalCameraData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(UniversalAdditionalCameraData), typeof(bool), typeof(bool), typeof(UniversalCameraData)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UniversalRenderPipeline), Member = "RenderSingleCamera", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), typeof(UniversalCameraData)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "get_name", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 23)]
	internal static void RenderSingleCameraInternal(ScriptableRenderContext context, Camera camera, ref UniversalAdditionalCameraData additionalCameraData, bool isLastBaseCamera = true) { }

	[CalledBy(Type = typeof(UniversalRenderPipeline), Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), typeof(System.Collections.Generic.List`1<UnityEngine.Camera>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalRenderPipeline), Member = "RenderSingleCamera", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), typeof(Camera)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UniversalRenderPipeline), Member = "IsGameCamera", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(GameObject), Member = "TryGetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(UniversalRenderPipeline), Member = "RenderSingleCameraInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), typeof(Camera), typeof(UniversalAdditionalCameraData&), typeof(bool)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	internal static void RenderSingleCameraInternal(ScriptableRenderContext context, Camera camera, bool isLastBaseCamera = true) { }

	[CalledBy(Type = typeof(UniversalRenderPipeline), Member = "InitializeStackedCameraData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(UniversalAdditionalCameraData), typeof(UniversalCameraData)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(FSRUtils), Member = "IsSupported", ReturnType = typeof(bool))]
	[Calls(Type = typeof(STP), Member = "IsSupported", ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 5)]
	private static ImageUpscalingFilter ResolveUpscalingFilterSelection(Vector2 imageSize, float renderScale, UpscalingFilterSelection selection, bool enableRenderGraph) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	private static void set_canOptimizeScreenMSAASamples(bool value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void set_runtimeTextures(UniversalRenderPipelineRuntimeTextures value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	private static void set_startFrameScreenMSAASamples(int value) { }

	[CalledBy(Type = typeof(UniversalRenderPipeline), Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), typeof(System.Collections.Generic.List`1<UnityEngine.Camera>)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(HDROutputSettings), Member = "get_main", ReturnType = typeof(HDROutputSettings))]
	[Calls(Type = typeof(HDROutputSettings), Member = "get_available", ReturnType = typeof(bool))]
	[Calls(Type = typeof(HDROutputSettings), Member = "get_active", ReturnType = typeof(bool))]
	[Calls(Type = typeof(HDROutputSettings), Member = "get_displayColorGamut", ReturnType = typeof(ColorGamut))]
	[Calls(Type = typeof(UniversalRenderPipeline), Member = "get_asset", ReturnType = typeof(UniversalRenderPipelineAsset))]
	[Calls(Type = typeof(Debug), Member = "LogWarning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(HDROutputSettings), Member = "RequestHDRModeChange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(HDROutputSettings), Member = "set_automaticHDRTonemapping", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private void SetHDRState(List<Camera> cameras) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SupportedRenderingFeatures), Member = "get_active", ReturnType = typeof(SupportedRenderingFeatures))]
	[CallsUnknownMethods(Count = 1)]
	private static void SetSupportedRenderingFeatures(UniversalRenderPipelineAsset pipelineAsset) { }

	[CalledBy(Type = typeof(UniversalRenderPipeline), Member = "RenderSingleCamera", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), typeof(UniversalCameraData)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(RenderSettings), Member = "get_subtractiveShadowColor", ReturnType = typeof(Color))]
	[Calls(Type = typeof(RenderSettings), Member = "get_ambientGroundColor", ReturnType = typeof(Color))]
	[Calls(Type = typeof(RenderSettings), Member = "get_ambientEquatorColor", ReturnType = typeof(Color))]
	[Calls(Type = typeof(CoreUtils), Member = "ConvertSRGBToActiveColorSpace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(Color))]
	[Calls(Type = typeof(RenderSettings), Member = "get_ambientSkyColor", ReturnType = typeof(Color))]
	[Calls(Type = typeof(ReflectionProbe), Member = "get_defaultTextureHDRDecodeValues", ReturnType = typeof(Vector4))]
	[Calls(Type = typeof(CommandBuffer), Member = "SetGlobalTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(RenderTargetIdentifier)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture)}, ReturnType = typeof(RenderTargetIdentifier))]
	[Calls(Type = typeof(ReflectionProbe), Member = "get_defaultTexture", ReturnType = typeof(Texture))]
	[Calls(Type = typeof(CommandBuffer), Member = "SetGlobalVector", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Vector4)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CoreUtils), Member = "ConvertLinearToActiveColorSpace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(Color))]
	[Calls(Type = typeof(RenderSettings), Member = "get_reflectionIntensity", ReturnType = typeof(float))]
	[Calls(Type = typeof(SphericalHarmonicsL2), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(RenderSettings), Member = "get_ambientProbe", ReturnType = typeof(SphericalHarmonicsL2))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	private static void SetupPerCameraShaderConstants(CommandBuffer cmd) { }

	[CalledBy(Type = typeof(UniversalRenderPipeline), Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), typeof(System.Collections.Generic.List`1<UnityEngine.Camera>)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Shader), Member = "SetGlobalColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Color)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UniversalRenderPipeline), Member = "get_asset", ReturnType = typeof(UniversalRenderPipelineAsset))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Debug), Member = "LogWarning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 6)]
	private void SetupPerFrameShaderConstants() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private static void SetupScreenMSAASamplesState(int cameraCount) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Sort", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Comparison`1<System.Object>)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private void SortCameras(List<Camera> cameras) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public virtual string ToString() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XRPass), Member = "get_enabled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Camera), Member = "TryGetCullingParameters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(ScriptableCullingParameters&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Camera), Member = "get_usePhysicalProperties", ReturnType = typeof(bool))]
	[Calls(Type = typeof(ScriptableCullingParameters), Member = "get_stereoProjectionMatrix", ReturnType = typeof(Matrix4x4))]
	[Calls(Type = typeof(Camera), Member = "set_fieldOfView", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	private static bool TryGetCullingParameters(UniversalCameraData cameraData, out ScriptableCullingParameters cullingParams) { }

	[CalledBy(Type = typeof(UniversalRenderPipeline), Member = "RenderCameraStack", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), typeof(Camera), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Camera), Member = "get_rect", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(XRPass), Member = "GetViewport", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Rect))]
	[Calls(Type = typeof(RenderTextureDescriptor), Member = "set_graphicsFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GraphicsFormat)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderTextureDescriptor), Member = "set_useDynamicScale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	private static void UpdateCameraData(UniversalCameraData baseCameraData, in XRPass xr) { }

	[CalledBy(Type = typeof(UniversalRenderPipeline), Member = "RenderCameraStack", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), typeof(Camera), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(XRPass), Member = "get_enabled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(XRPass), Member = "get_singlePassEnabled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(XRPass), Member = "GetProjMatrix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Matrix4x4))]
	[Calls(Type = typeof(Camera), Member = "SetStereoProjectionMatrix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StereoscopicEye), typeof(Matrix4x4)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XRPass), Member = "GetViewMatrix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Matrix4x4))]
	[Calls(Type = typeof(Camera), Member = "SetStereoViewMatrix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StereoscopicEye), typeof(Matrix4x4)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XRPass), Member = "get_viewCount", ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 1)]
	private static void UpdateCameraStereoMatrices(Camera camera, XRPass xr) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UniversalCameraHistory), Member = "RequestAccess", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"Type"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UniversalCameraHistory), Member = "GetHistoryForWrite", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"Type"}, ReturnType = "Type")]
	[Calls(Type = typeof(UniversalCameraData), Member = "IsSTPEnabled", ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	private static void UpdateTemporalAAData(UniversalCameraData cameraData, UniversalAdditionalCameraData additionalCameraData) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UniversalCameraData), Member = "IsTemporalAAEnabled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(UniversalCameraData), Member = "IsSTPRequested", ReturnType = typeof(bool))]
	[Calls(Type = typeof(XRPass), Member = "get_enabled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(XRPass), Member = "get_singlePassEnabled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(TaaHistory), Member = "Update", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTextureDescriptor&), typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(StpHistory), Member = "Update", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UniversalCameraData)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	private static void UpdateTemporalAATargets(UniversalCameraData cameraData) { }

	[CalledBy(Type = typeof(UniversalRenderPipeline), Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), typeof(System.Collections.Generic.List`1<UnityEngine.Camera>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalRenderPipeline), Member = "RenderCameraStack", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), typeof(Camera), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(VolumeManager), Member = "Update", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Transform), typeof(LayerMask)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VolumeManager), Member = "ResetMainStack", ReturnType = typeof(void))]
	[Calls(Type = typeof(CameraExtensions), Member = "GetVolumeLayerMaskAndTrigger", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(UniversalAdditionalCameraData), typeof(LayerMask&), typeof(Transform&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UniversalAdditionalCameraData), Member = "set_volumeStack", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VolumeStack)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(VolumeManager), Member = "get_instance", ReturnType = typeof(VolumeManager))]
	[Calls(Type = typeof(CameraExtensions), Member = "UpdateVolumeStack", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(UniversalAdditionalCameraData)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CameraExtensions), Member = "DestroyVolumeStack", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(UniversalAdditionalCameraData)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(UniversalAdditionalCameraData), Member = "get_requiresVolumeFrameworkUpdate", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Camera), Member = "get_cameraType", ReturnType = typeof(CameraType))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 9)]
	private static void UpdateVolumeFramework(Camera camera, UniversalAdditionalCameraData additionalCameraData) { }

}

