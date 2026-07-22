namespace UnityEngine.Rendering.Universal;

[DisallowMultipleComponent]
[ExecuteAlways]
[RequireComponent(typeof(Camera))]
public class UniversalAdditionalCameraData : MonoBehaviour, ISerializationCallbackReceiver, IAdditionalData
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Predicate<Camera> <>9__53_0; //Field offset: 0x8

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		private static <>c() { }

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		internal bool <UpdateCameraStack>b__53_0(Camera cam) { }

	}

	private const string k_GizmoPath = "Packages/com.unity.render-pipelines.universal/Editor/Gizmos/"; //Field offset: 0x0
	private const string k_PostProcessingGizmoPath = "Packages/com.unity.render-pipelines.universal/Editor/Gizmos/Camera_PostProcessing.png"; //Field offset: 0x0
	private static UniversalAdditionalCameraData s_DefaultAdditionalCameraData; //Field offset: 0x0
	private const string k_BaseCameraGizmoPath = "Packages/com.unity.render-pipelines.universal/Editor/Gizmos/Camera_Base.png"; //Field offset: 0x0
	private const string k_OverlayCameraGizmoPath = "Packages/com.unity.render-pipelines.universal/Editor/Gizmos/Camera_Base.png"; //Field offset: 0x0
	private static List<VolumeStack> s_CachedVolumeStacks; //Field offset: 0x8
	[FormerlySerializedAs("renderShadows")]
	[SerializeField]
	private bool m_RenderShadows; //Field offset: 0x20
	[SerializeField]
	private CameraOverrideOption m_RequiresDepthTextureOption; //Field offset: 0x24
	[SerializeField]
	private CameraOverrideOption m_RequiresOpaqueTextureOption; //Field offset: 0x28
	[SerializeField]
	private CameraRenderType m_CameraType; //Field offset: 0x2C
	[SerializeField]
	private List<Camera> m_Cameras; //Field offset: 0x30
	[SerializeField]
	private int m_RendererIndex; //Field offset: 0x38
	[SerializeField]
	private LayerMask m_VolumeLayerMask; //Field offset: 0x3C
	[SerializeField]
	private Transform m_VolumeTrigger; //Field offset: 0x40
	[SerializeField]
	private VolumeFrameworkUpdateMode m_VolumeFrameworkUpdateModeOption; //Field offset: 0x48
	[SerializeField]
	private bool m_RenderPostProcessing; //Field offset: 0x4C
	[SerializeField]
	private AntialiasingMode m_Antialiasing; //Field offset: 0x50
	[SerializeField]
	private AntialiasingQuality m_AntialiasingQuality; //Field offset: 0x54
	[SerializeField]
	private bool m_StopNaN; //Field offset: 0x58
	[SerializeField]
	private bool m_Dithering; //Field offset: 0x59
	[SerializeField]
	private bool m_ClearDepth; //Field offset: 0x5A
	[SerializeField]
	private bool m_AllowXRRendering; //Field offset: 0x5B
	[SerializeField]
	private bool m_AllowHDROutput; //Field offset: 0x5C
	[SerializeField]
	private bool m_UseScreenCoordOverride; //Field offset: 0x5D
	[SerializeField]
	private Vector4 m_ScreenSizeOverride; //Field offset: 0x60
	[SerializeField]
	private Vector4 m_ScreenCoordScaleBias; //Field offset: 0x70
	private Camera m_Camera; //Field offset: 0x80
	[FormerlySerializedAs("requiresDepthTexture")]
	[SerializeField]
	private bool m_RequiresDepthTexture; //Field offset: 0x88
	[FormerlySerializedAs("requiresColorTexture")]
	[SerializeField]
	private bool m_RequiresColorTexture; //Field offset: 0x89
	[HideInInspector]
	[SerializeField]
	private float m_Version; //Field offset: 0x8C
	private MotionVectorsPersistentData m_MotionVectorsPersistentData; //Field offset: 0x90
	internal UniversalCameraHistory m_History; //Field offset: 0x98
	[SerializeField]
	internal Settings m_TaaSettings; //Field offset: 0xA0
	private VolumeStack m_VolumeStack; //Field offset: 0xC0

	public bool allowHDROutput
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		 set { } //Length: 4
	}

	public bool allowXRRendering
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		 set { } //Length: 4
	}

	public AntialiasingMode antialiasing
	{
		[CallerCount(Count = 7)]
		[DeduplicatedMethod]
		 get { } //Length: 4
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	public AntialiasingQuality antialiasingQuality
	{
		[CallerCount(Count = 14)]
		[DeduplicatedMethod]
		 get { } //Length: 4
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	internal Camera camera
	{
		[CalledBy(Type = typeof(UniversalAdditionalCameraData), Member = "Start", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UniversalAdditionalCameraData), Member = "get_scriptableRenderer", ReturnType = typeof(ScriptableRenderer))]
		[CalledBy(Type = typeof(UniversalAdditionalCameraData), Member = "OnDestroy", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UniversalRenderPipeline), Member = "RenderCameraStack", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), typeof(Camera), typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
		[Calls(Type = typeof(GameObject), Member = "TryGetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&"}, ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 1)]
		internal get { } //Length: 155
	}

	public List<Camera> cameraStack
	{
		[CalledBy(Type = "Scenes.Battle.DuelField", Member = "SetupCamera", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UniversalCameraData), Member = "IsTemporalAAEnabled", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(UniversalCameraData), Member = "IsSTPEnabled", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(TemporalAA), Member = "ValidateAndWarn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UniversalCameraData), typeof(bool)}, ReturnType = typeof(string))]
		[CallerCount(Count = 5)]
		[Calls(Type = typeof(UniversalAdditionalCameraData), Member = "get_scriptableRenderer", ReturnType = typeof(ScriptableRenderer))]
		[Calls(Type = typeof(ScriptableRenderer), Member = "SupportsCameraStackingType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CameraRenderType)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
		[Calls(Type = typeof(GameObject), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
		[Calls(Type = typeof(Object), Member = "get_name", ReturnType = typeof(string))]
		[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(Debug), Member = "LogWarning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 2)]
		 get { } //Length: 365
	}

	public bool clearDepth
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 5
	}

	internal static UniversalAdditionalCameraData defaultAdditionalCameraData
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(UniversalAdditionalCameraData), Member = ".ctor", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		internal get { } //Length: 188
	}

	public bool dithering
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	public ICameraHistoryReadAccess history
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 8
	}

	internal UniversalCameraHistory historyManager
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		internal get { } //Length: 8
	}

	internal MotionVectorsPersistentData motionVectorsPersistentData
	{
		[CallerCount(Count = 57)]
		[DeduplicatedMethod]
		internal get { } //Length: 8
	}

	public bool renderPostProcessing
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	public bool renderShadows
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 3)]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	public CameraRenderType renderType
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 4
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	public CameraOverrideOption requiresColorOption
	{
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 4
		[CallerCount(Count = 5)]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	public bool requiresColorTexture
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UniversalRenderPipeline), Member = "get_asset", ReturnType = typeof(UniversalRenderPipelineAsset))]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 104
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		 set { } //Length: 25
	}

	public CameraOverrideOption requiresDepthOption
	{
		[CallerCount(Count = 9)]
		[DeduplicatedMethod]
		 get { } //Length: 4
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	public bool requiresDepthTexture
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UniversalRenderPipeline), Member = "get_asset", ReturnType = typeof(UniversalRenderPipelineAsset))]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 104
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		 set { } //Length: 25
	}

	public bool requiresVolumeFrameworkUpdate
	{
		[CalledBy(Type = typeof(CameraExtensions), Member = "SetVolumeFrameworkUpdateMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(VolumeFrameworkUpdateMode)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(CameraExtensions), Member = "UpdateVolumeStack", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(UniversalAdditionalCameraData)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UniversalRenderPipeline), Member = "UpdateVolumeFramework", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(UniversalAdditionalCameraData)}, ReturnType = typeof(void))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(UniversalRenderPipeline), Member = "get_asset", ReturnType = typeof(UniversalRenderPipelineAsset))]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 110
	}

	public bool resetHistory
	{
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		 get { } //Length: 11
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(MotionVectorsPersistentData), Member = "Reset", ReturnType = typeof(void))]
		[Calls(Type = typeof(Time), Member = "get_frameCount", ReturnType = typeof(int))]
		[CallsUnknownMethods(Count = 1)]
		 set { } //Length: 63
	}

	public Vector4 screenCoordScaleBias
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 11
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 set { } //Length: 8
	}

	public Vector4 screenSizeOverride
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 11
		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		 set { } //Length: 8
	}

	public ScriptableRenderer scriptableRenderer
	{
		[CalledBy(Type = typeof(UniversalAdditionalCameraData), Member = "get_cameraStack", ReturnType = typeof(System.Collections.Generic.List`1<UnityEngine.Camera>))]
		[CalledBy(Type = typeof(UniversalRenderPipeline), Member = "RenderCameraStack", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), typeof(Camera), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UniversalRenderPipeline), Member = "GetRenderer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(UniversalAdditionalCameraData)}, ReturnType = typeof(ScriptableRenderer))]
		[CalledBy(Type = typeof(UniversalRenderPipeline), Member = "CreateCameraData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ContextContainer), typeof(Camera), typeof(UniversalAdditionalCameraData), typeof(bool)}, ReturnType = typeof(UniversalCameraData))]
		[CalledBy(Type = typeof(UniversalRenderPipeline), Member = "InitializeAdditionalCameraData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(UniversalAdditionalCameraData), typeof(bool), typeof(bool), typeof(UniversalCameraData)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UniversalRenderer), Member = "Setup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), typeof(RenderingData&)}, ReturnType = typeof(void))]
		[CallerCount(Count = 7)]
		[Calls(Type = typeof(UniversalRenderPipeline), Member = "get_asset", ReturnType = typeof(UniversalRenderPipelineAsset))]
		[Calls(Type = typeof(UniversalRenderPipelineAsset), Member = "ValidateRendererData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(UniversalRenderPipelineAsset), Member = "GetRenderer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(ScriptableRenderer))]
		[Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
		[Calls(Type = typeof(UniversalAdditionalCameraData), Member = "get_camera", ReturnType = typeof(Camera))]
		[Calls(Type = typeof(Object), Member = "get_name", ReturnType = typeof(string))]
		[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[])}, ReturnType = typeof(string))]
		[Calls(Type = typeof(Debug), Member = "LogWarning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 9)]
		 get { } //Length: 730
	}

	public bool stopNaN
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	public Settings taaSettings
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 8
	}

	public bool useScreenCoordOverride
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	public float version
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 9
	}

	internal VolumeFrameworkUpdateMode volumeFrameworkUpdateMode
	{
		[CallerCount(Count = 26)]
		[DeduplicatedMethod]
		internal get { } //Length: 4
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		internal set { } //Length: 4
	}

	public LayerMask volumeLayerMask
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 4
		[CallerCount(Count = 11)]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	public VolumeStack volumeStack
	{
		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		 get { } //Length: 8
		[CalledBy(Type = typeof(CameraExtensions), Member = "DestroyVolumeStack", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(CameraExtensions), Member = "DestroyVolumeStack", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(UniversalAdditionalCameraData)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UniversalAdditionalCameraData), Member = "OnDestroy", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UniversalRenderPipeline), Member = "UpdateVolumeFramework", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(UniversalAdditionalCameraData)}, ReturnType = typeof(void))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(List`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 5)]
		 set { } //Length: 383
	}

	public Transform volumeTrigger
	{
		[CallerCount(Count = 12)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 set { } //Length: 13
	}

	[CalledBy(Type = typeof(UniversalAdditionalCameraData), Member = "get_defaultAdditionalCameraData", ReturnType = typeof(UniversalAdditionalCameraData))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(MotionVectorsPersistentData), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(BufferedRTHandleSystem), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(Settings), Member = "Create", ReturnType = typeof(Settings))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 7)]
	public UniversalAdditionalCameraData() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public bool get_allowHDROutput() { }

	[CallerCount(Count = 0)]
	public bool get_allowXRRendering() { }

	[CallerCount(Count = 7)]
	[DeduplicatedMethod]
	public AntialiasingMode get_antialiasing() { }

	[CallerCount(Count = 14)]
	[DeduplicatedMethod]
	public AntialiasingQuality get_antialiasingQuality() { }

	[CalledBy(Type = typeof(UniversalAdditionalCameraData), Member = "Start", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalAdditionalCameraData), Member = "get_scriptableRenderer", ReturnType = typeof(ScriptableRenderer))]
	[CalledBy(Type = typeof(UniversalAdditionalCameraData), Member = "OnDestroy", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalRenderPipeline), Member = "RenderCameraStack", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), typeof(Camera), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(GameObject), Member = "TryGetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&"}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	internal Camera get_camera() { }

	[CalledBy(Type = "Scenes.Battle.DuelField", Member = "SetupCamera", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalCameraData), Member = "IsTemporalAAEnabled", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(UniversalCameraData), Member = "IsSTPEnabled", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TemporalAA), Member = "ValidateAndWarn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UniversalCameraData), typeof(bool)}, ReturnType = typeof(string))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(UniversalAdditionalCameraData), Member = "get_scriptableRenderer", ReturnType = typeof(ScriptableRenderer))]
	[Calls(Type = typeof(ScriptableRenderer), Member = "SupportsCameraStackingType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CameraRenderType)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(GameObject), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(Object), Member = "get_name", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Debug), Member = "LogWarning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	public List<Camera> get_cameraStack() { }

	[CallerCount(Count = 0)]
	public bool get_clearDepth() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(UniversalAdditionalCameraData), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	internal static UniversalAdditionalCameraData get_defaultAdditionalCameraData() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public bool get_dithering() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public ICameraHistoryReadAccess get_history() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	internal UniversalCameraHistory get_historyManager() { }

	[CallerCount(Count = 57)]
	[DeduplicatedMethod]
	internal MotionVectorsPersistentData get_motionVectorsPersistentData() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public bool get_renderPostProcessing() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public bool get_renderShadows() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public CameraRenderType get_renderType() { }

	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	public CameraOverrideOption get_requiresColorOption() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UniversalRenderPipeline), Member = "get_asset", ReturnType = typeof(UniversalRenderPipelineAsset))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public bool get_requiresColorTexture() { }

	[CallerCount(Count = 9)]
	[DeduplicatedMethod]
	public CameraOverrideOption get_requiresDepthOption() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UniversalRenderPipeline), Member = "get_asset", ReturnType = typeof(UniversalRenderPipelineAsset))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public bool get_requiresDepthTexture() { }

	[CalledBy(Type = typeof(CameraExtensions), Member = "SetVolumeFrameworkUpdateMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(VolumeFrameworkUpdateMode)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CameraExtensions), Member = "UpdateVolumeStack", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(UniversalAdditionalCameraData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalRenderPipeline), Member = "UpdateVolumeFramework", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(UniversalAdditionalCameraData)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(UniversalRenderPipeline), Member = "get_asset", ReturnType = typeof(UniversalRenderPipelineAsset))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public bool get_requiresVolumeFrameworkUpdate() { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public bool get_resetHistory() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public Vector4 get_screenCoordScaleBias() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public Vector4 get_screenSizeOverride() { }

	[CalledBy(Type = typeof(UniversalAdditionalCameraData), Member = "get_cameraStack", ReturnType = typeof(System.Collections.Generic.List`1<UnityEngine.Camera>))]
	[CalledBy(Type = typeof(UniversalRenderPipeline), Member = "RenderCameraStack", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), typeof(Camera), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalRenderPipeline), Member = "GetRenderer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(UniversalAdditionalCameraData)}, ReturnType = typeof(ScriptableRenderer))]
	[CalledBy(Type = typeof(UniversalRenderPipeline), Member = "CreateCameraData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ContextContainer), typeof(Camera), typeof(UniversalAdditionalCameraData), typeof(bool)}, ReturnType = typeof(UniversalCameraData))]
	[CalledBy(Type = typeof(UniversalRenderPipeline), Member = "InitializeAdditionalCameraData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(UniversalAdditionalCameraData), typeof(bool), typeof(bool), typeof(UniversalCameraData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalRenderer), Member = "Setup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), typeof(RenderingData&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(UniversalRenderPipeline), Member = "get_asset", ReturnType = typeof(UniversalRenderPipelineAsset))]
	[Calls(Type = typeof(UniversalRenderPipelineAsset), Member = "ValidateRendererData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(UniversalRenderPipelineAsset), Member = "GetRenderer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(ScriptableRenderer))]
	[Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(UniversalAdditionalCameraData), Member = "get_camera", ReturnType = typeof(Camera))]
	[Calls(Type = typeof(Object), Member = "get_name", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Debug), Member = "LogWarning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 9)]
	public ScriptableRenderer get_scriptableRenderer() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public bool get_stopNaN() { }

	[CallerCount(Count = 0)]
	public Settings get_taaSettings() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public bool get_useScreenCoordOverride() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public float get_version() { }

	[CallerCount(Count = 26)]
	[DeduplicatedMethod]
	internal VolumeFrameworkUpdateMode get_volumeFrameworkUpdateMode() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public LayerMask get_volumeLayerMask() { }

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public VolumeStack get_volumeStack() { }

	[CallerCount(Count = 12)]
	[DeduplicatedMethod]
	public Transform get_volumeTrigger() { }

	[CalledBy(Type = typeof(CameraExtensions), Member = "UpdateVolumeStack", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(UniversalAdditionalCameraData)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(List`1), Member = "RemoveAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VolumeManager), Member = "get_instance", ReturnType = typeof(VolumeManager))]
	[Calls(Type = typeof(VolumeManager), Member = "CreateStack", ReturnType = typeof(VolumeStack))]
	[Calls(Type = typeof(List`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	internal void GetOrCreateVolumeStack() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UniversalRenderPipeline), Member = "get_asset", ReturnType = typeof(UniversalRenderPipelineAsset))]
	[Calls(Type = typeof(UniversalRenderPipelineAsset), Member = "get_renderers", ReturnType = typeof(System.ReadOnlySpan`1<UnityEngine.Rendering.Universal.ScriptableRenderer>))]
	[Calls(Type = typeof(ReadOnlySpan`1), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.ReadOnlySpan`1<T>", "System.ReadOnlySpan`1<T>"}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	private ScriptableRenderer GetRawRenderer() { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public override void OnAfterDeserialize() { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	public override void OnBeforeSerialize() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(UniversalAdditionalCameraData), Member = "set_volumeStack", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VolumeStack)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UniversalAdditionalCameraData), Member = "get_camera", ReturnType = typeof(Camera))]
	[Calls(Type = typeof(Camera), Member = "get_cameraType", ReturnType = typeof(CameraType))]
	[Calls(Type = typeof(UniversalRenderPipeline), Member = "get_asset", ReturnType = typeof(UniversalRenderPipelineAsset))]
	[Calls(Type = typeof(UniversalRenderPipelineAsset), Member = "get_renderers", ReturnType = typeof(System.ReadOnlySpan`1<UnityEngine.Rendering.Universal.ScriptableRenderer>))]
	[Calls(Type = typeof(ReadOnlySpan`1), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.ReadOnlySpan`1<T>", "System.ReadOnlySpan`1<T>"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(UniversalCameraHistory), Member = "Dispose", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	public void OnDestroy() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Transform), Member = "get_position", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Gizmos), Member = "DrawIcon", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(string), typeof(bool), typeof(Color)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void OnDrawGizmos() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Camera), Member = "set_clearFlags", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CameraClearFlags)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void OnValidate() { }

	[CallerCount(Count = 0)]
	public void set_allowHDROutput(bool value) { }

	[CallerCount(Count = 0)]
	public void set_allowXRRendering(bool value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void set_antialiasing(AntialiasingMode value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void set_antialiasingQuality(AntialiasingQuality value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void set_dithering(bool value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void set_renderPostProcessing(bool value) { }

	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	public void set_renderShadows(bool value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void set_renderType(CameraRenderType value) { }

	[CallerCount(Count = 5)]
	[DeduplicatedMethod]
	public void set_requiresColorOption(CameraOverrideOption value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public void set_requiresColorTexture(bool value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void set_requiresDepthOption(CameraOverrideOption value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public void set_requiresDepthTexture(bool value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MotionVectorsPersistentData), Member = "Reset", ReturnType = typeof(void))]
	[Calls(Type = typeof(Time), Member = "get_frameCount", ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 1)]
	public void set_resetHistory(bool value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void set_screenCoordScaleBias(Vector4 value) { }

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public void set_screenSizeOverride(Vector4 value) { }

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public void set_stopNaN(bool value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void set_useScreenCoordOverride(bool value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	internal void set_volumeFrameworkUpdateMode(VolumeFrameworkUpdateMode value) { }

	[CallerCount(Count = 11)]
	[DeduplicatedMethod]
	public void set_volumeLayerMask(LayerMask value) { }

	[CalledBy(Type = typeof(CameraExtensions), Member = "DestroyVolumeStack", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CameraExtensions), Member = "DestroyVolumeStack", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(UniversalAdditionalCameraData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalAdditionalCameraData), Member = "OnDestroy", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalRenderPipeline), Member = "UpdateVolumeFramework", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(UniversalAdditionalCameraData)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(List`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	public void set_volumeStack(VolumeStack value) { }

	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public void set_volumeTrigger(Transform value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void SetRenderer(int index) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UniversalAdditionalCameraData), Member = "get_camera", ReturnType = typeof(Camera))]
	[Calls(Type = typeof(Camera), Member = "set_clearFlags", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CameraClearFlags)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private void Start() { }

	[CalledBy(Type = typeof(UniversalRenderPipeline), Member = "RenderCameraStack", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), typeof(Camera), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.Predicate`1<System.Object>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "RemoveAll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Predicate`1<System.Object>)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Object), Member = "get_name", ReturnType = typeof(string))]
	[Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Debug), Member = "LogWarning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 9)]
	internal void UpdateCameraStack() { }

}

