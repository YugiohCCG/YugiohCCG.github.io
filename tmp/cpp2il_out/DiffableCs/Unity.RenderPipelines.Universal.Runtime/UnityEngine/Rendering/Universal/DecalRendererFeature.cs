namespace UnityEngine.Rendering.Universal;

[DisallowMultipleRendererFeature("Decal")]
[SupportedOnRenderer(typeof(UniversalRendererData))]
[Tooltip("With this Renderer Feature, Unity can project specific Materials (decals) onto other objects in the Scene.")]
public class DecalRendererFeature : ScriptableRendererFeature
{
	[CompilerGenerated]
	private static readonly SharedDecalEntityManager <sharedDecalEntityManager>k__BackingField; //Field offset: 0x0
	[SerializeField]
	private DecalSettings m_Settings; //Field offset: 0x20
	private DecalTechnique m_Technique; //Field offset: 0x28
	private DBufferSettings m_DBufferSettings; //Field offset: 0x30
	private DecalScreenSpaceSettings m_ScreenSpaceSettings; //Field offset: 0x38
	private bool m_RecreateSystems; //Field offset: 0x40
	private DecalPreviewPass m_DecalPreviewPass; //Field offset: 0x48
	private DecalEntityManager m_DecalEntityManager; //Field offset: 0x50
	private DecalUpdateCachedSystem m_DecalUpdateCachedSystem; //Field offset: 0x58
	private DecalUpdateCullingGroupSystem m_DecalUpdateCullingGroupSystem; //Field offset: 0x60
	private DecalUpdateCulledSystem m_DecalUpdateCulledSystem; //Field offset: 0x68
	private DecalCreateDrawCallSystem m_DecalCreateDrawCallSystem; //Field offset: 0x70
	private DecalDrawErrorSystem m_DrawErrorSystem; //Field offset: 0x78
	private DBufferCopyDepthPass m_CopyDepthPass; //Field offset: 0x80
	private DBufferRenderPass m_DBufferRenderPass; //Field offset: 0x88
	private DecalForwardEmissivePass m_ForwardEmissivePass; //Field offset: 0x90
	private DecalDrawDBufferSystem m_DecalDrawDBufferSystem; //Field offset: 0x98
	private DecalDrawFowardEmissiveSystem m_DecalDrawForwardEmissiveSystem; //Field offset: 0xA0
	private Material m_DBufferClearMaterial; //Field offset: 0xA8
	private DecalScreenSpaceRenderPass m_ScreenSpaceDecalRenderPass; //Field offset: 0xB0
	private DecalDrawScreenSpaceSystem m_DecalDrawScreenSpaceSystem; //Field offset: 0xB8
	private DecalSkipCulledSystem m_DecalSkipCulledSystem; //Field offset: 0xC0
	private DecalGBufferRenderPass m_GBufferRenderPass; //Field offset: 0xC8
	private DecalDrawGBufferSystem m_DrawGBufferSystem; //Field offset: 0xD0
	private DeferredLights m_DeferredLights; //Field offset: 0xD8

	internal bool intermediateRendering
	{
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		internal get { } //Length: 8
	}

	internal static bool isGLDevice
	{
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 2)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		internal get { } //Length: 41
	}

	internal bool requiresDecalLayers
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		internal get { } //Length: 27
	}

	internal DecalSettings settings
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		internal get { } //Length: 5
	}

	private static SharedDecalEntityManager sharedDecalEntityManager
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		private get { } //Length: 78
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private static DecalRendererFeature() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ScriptableRendererFeature), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public DecalRendererFeature() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UniversalRenderer), Member = "IsOffscreenDepthTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CameraData&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CameraData), Member = "get_cameraType", ReturnType = typeof(CameraType&))]
	[Calls(Type = typeof(DecalRendererFeature), Member = "RecreateSystemsIfNeeded", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderer), typeof(CameraData&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DecalUpdateCulledSystem), Member = "Execute", ReturnType = typeof(void))]
	[Calls(Type = typeof(DecalCreateDrawCallSystem), Member = "Execute", ReturnType = typeof(void))]
	[Calls(Type = typeof(UniversalRenderer), Member = "get_renderingModeActual", ReturnType = typeof(RenderingMode))]
	[Calls(Type = typeof(ScriptableRenderer), Member = "EnqueuePass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderPass)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	public virtual void AddRenderPasses(ScriptableRenderer renderer, ref RenderingData renderingData) { }

	[CallerCount(Count = 13327)]
	[Conditional("ADAPTIVE_PERFORMANCE_4_0_0_OR_NEWER")]
	[DeduplicatedMethod]
	private void ChangeAdaptivePerformanceDrawDistances() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DecalPreviewPass), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public virtual void Create() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DBufferRenderPass), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(CopyDepthPass), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(CoreUtils), Member = "Destroy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DecalEntityManager), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(DecalProjector), Member = "remove_onDecalAdd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DecalProjectorAction)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DecalProjector), Member = "remove_onDecalRemove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DecalProjectorAction)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DecalProjector), Member = "remove_onDecalPropertyChange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DecalProjectorAction)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DecalProjector), Member = "remove_onDecalMaterialChange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DecalProjectorAction)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DecalProjector), Member = "remove_onAllDecalPropertyChange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 3)]
	protected virtual void Dispose(bool disposing) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	internal bool get_intermediateRendering() { }

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	internal static bool get_isGLDevice() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	internal bool get_requiresDecalLayers() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	internal DecalSettings get_settings() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	private static SharedDecalEntityManager get_sharedDecalEntityManager() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	internal DBufferSettings GetDBufferSettings() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	internal DecalScreenSpaceSettings GetScreenSpaceSettings() { }

	[CalledBy(Type = typeof(DecalRendererFeature), Member = "RequireRenderingLayers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool), typeof(Event&), typeof(MaskSize&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DecalRendererFeature), Member = "GetTechnique", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRendererData)}, ReturnType = typeof(DecalTechnique))]
	[CalledBy(Type = typeof(DecalRendererFeature), Member = "GetTechnique", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderer)}, ReturnType = typeof(DecalTechnique))]
	[CalledBy(Type = typeof(DecalRendererFeature), Member = "RecreateSystemsIfNeeded", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderer), typeof(CameraData&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Application), Member = "get_platform", ReturnType = typeof(RuntimePlatform))]
	[Calls(Type = typeof(PlatformAutoDetect), Member = "get_isShaderAPIMobileDefined", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	internal DecalTechnique GetTechnique(bool isDeferred, bool needsGBufferAccurateNormals, bool checkForInvalidTechniques = true) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DecalRendererFeature), Member = "GetTechnique", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(DecalTechnique))]
	[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	internal DecalTechnique GetTechnique(ScriptableRendererData renderer) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UniversalRenderer), Member = "get_renderingModeActual", ReturnType = typeof(RenderingMode))]
	[Calls(Type = typeof(UniversalRenderer), Member = "get_accurateGbufferNormals", ReturnType = typeof(bool))]
	[Calls(Type = typeof(DecalRendererFeature), Member = "GetTechnique", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(DecalTechnique))]
	[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[ContainsUnimplementedInstructions]
	internal DecalTechnique GetTechnique(ScriptableRenderer renderer) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Application), Member = "get_platform", ReturnType = typeof(RuntimePlatform))]
	[Calls(Type = typeof(PlatformAutoDetect), Member = "get_isShaderAPIMobileDefined", ReturnType = typeof(bool))]
	private bool IsAutomaticDBuffer() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CameraData), Member = "get_cameraType", ReturnType = typeof(CameraType&))]
	[Calls(Type = typeof(DecalRendererFeature), Member = "RecreateSystemsIfNeeded", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderer), typeof(CameraData&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DecalEntityManager), Member = "Update", ReturnType = typeof(void))]
	[Calls(Type = typeof(DecalUpdateCachedSystem), Member = "Execute", ReturnType = typeof(void))]
	[Calls(Type = typeof(CameraData), Member = "get_camera", ReturnType = typeof(Camera&))]
	[Calls(Type = typeof(DecalSkipCulledSystem), Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DecalCreateDrawCallSystem), Member = "Execute", ReturnType = typeof(void))]
	[Calls(Type = typeof(DecalDrawSystem), Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CameraData&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DecalUpdateCullingGroupSystem), Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public virtual void OnCameraPreCull(ScriptableRenderer renderer, in CameraData cameraData) { }

	[CalledBy(Type = typeof(DecalRendererFeature), Member = "OnCameraPreCull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderer), typeof(CameraData&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DecalRendererFeature), Member = "AddRenderPasses", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderer), typeof(RenderingData&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(DecalSkipCulledSystem), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DecalEntityManager)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DecalDrawFowardEmissiveSystem), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DecalEntityManager)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DBufferRenderPass), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material), typeof(DBufferSettings), typeof(DecalDrawDBufferSystem), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DecalDrawDBufferSystem), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DecalEntityManager)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DBufferCopyDepthPass), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderPassEvent), typeof(Shader), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DecalScreenSpaceRenderPass), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DecalScreenSpaceSettings), typeof(DecalDrawScreenSpaceSystem), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DecalDrawScreenSpaceSystem), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DecalEntityManager)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DecalGBufferRenderPass), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DecalScreenSpaceSettings), typeof(DecalDrawGBufferSystem), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DecalDrawGBufferSystem), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DecalEntityManager)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DecalDrawErrorSystem), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DecalEntityManager), typeof(DecalTechnique)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DecalUpdateCullingGroupSystem), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DecalEntityManager), typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DecalCreateDrawCallSystem), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DecalEntityManager), typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DecalForwardEmissivePass), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DecalDrawFowardEmissiveSystem)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DecalUpdateCulledSystem), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DecalEntityManager)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DecalUpdateCachedSystem), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DecalEntityManager)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SharedDecalEntityManager), Member = "Get", ReturnType = typeof(DecalEntityManager))]
	[Calls(Type = typeof(CoreUtils), Member = "CreateEngineMaterial", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Shader)}, ReturnType = typeof(Material))]
	[Calls(Type = typeof(GraphicsSettings), Member = "GetRenderPipelineSettings", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(DecalRendererFeature), Member = "GetTechnique", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(DecalTechnique))]
	[Calls(Type = typeof(UniversalRenderer), Member = "get_accurateGbufferNormals", ReturnType = typeof(bool))]
	[Calls(Type = typeof(UniversalRenderer), Member = "get_renderingModeActual", ReturnType = typeof(RenderingMode))]
	[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 19)]
	[ContainsUnimplementedInstructions]
	private bool RecreateSystemsIfNeeded(ScriptableRenderer renderer, in CameraData cameraData) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Application), Member = "get_isPlaying", ReturnType = typeof(bool))]
	[Calls(Type = typeof(DecalRendererFeature), Member = "GetTechnique", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(DecalTechnique))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	internal virtual bool RequireRenderingLayers(bool isDeferred, bool needsGBufferAccurateNormals, out Event atEvent, out MaskSize maskSize) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ScriptableRenderer), Member = "get_cameraColorTargetHandle", ReturnType = typeof(RTHandle))]
	[Calls(Type = typeof(CameraData), Member = "get_cameraTargetDescriptor", ReturnType = typeof(RenderTextureDescriptor&))]
	[Calls(Type = typeof(DBufferRenderPass), Member = "Setup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CameraData&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UniversalRenderer), Member = "get_renderingModeActual", ReturnType = typeof(RenderingMode))]
	[Calls(Type = typeof(CopyDepthPass), Member = "Setup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RTHandle), typeof(RTHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ScriptableRenderer), Member = "get_cameraDepthTargetHandle", ReturnType = typeof(RTHandle))]
	[Calls(Type = typeof(DBufferRenderPass), Member = "Setup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CameraData&), typeof(RTHandle)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public virtual void SetupRenderPasses(ScriptableRenderer renderer, in RenderingData renderingData) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	internal virtual bool SupportsNativeRenderPass() { }

}

