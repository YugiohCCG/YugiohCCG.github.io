namespace UnityEngine.Rendering.Universal;

[ExcludeFromPreset]
[ReloadGroup]
public class UniversalRendererData : ScriptableRendererData, ISerializationCallbackReceiver
{
	private const int k_LatestAssetVersion = 2; //Field offset: 0x0
	[Obsolete("Moved to UniversalRenderPipelineRuntimeXRResources on GraphicsSettings. #from(2023.3)", False)]
	public XRSystemData xrSystemData; //Field offset: 0x48
	public PostProcessData postProcessData; //Field offset: 0x50
	[SerializeField]
	private int m_AssetVersion; //Field offset: 0x58
	[SerializeField]
	private LayerMask m_OpaqueLayerMask; //Field offset: 0x5C
	[SerializeField]
	private LayerMask m_TransparentLayerMask; //Field offset: 0x60
	[SerializeField]
	private StencilStateData m_DefaultStencilState; //Field offset: 0x68
	[SerializeField]
	private bool m_ShadowTransparentReceive; //Field offset: 0x70
	[SerializeField]
	private RenderingMode m_RenderingMode; //Field offset: 0x74
	[SerializeField]
	private DepthPrimingMode m_DepthPrimingMode; //Field offset: 0x78
	[SerializeField]
	private CopyDepthMode m_CopyDepthMode; //Field offset: 0x7C
	[SerializeField]
	private DepthFormat m_DepthAttachmentFormat; //Field offset: 0x80
	[SerializeField]
	private DepthFormat m_DepthTextureFormat; //Field offset: 0x84
	[SerializeField]
	private bool m_AccurateGbufferNormals; //Field offset: 0x88
	[SerializeField]
	private IntermediateTextureMode m_IntermediateTextureMode; //Field offset: 0x8C
	private bool m_StripShadowsOffVariants; //Field offset: 0x90
	private bool m_StripAdditionalLightOffVariants; //Field offset: 0x91

	public bool accurateGbufferNormals
	{
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 8
		[CallerCount(Count = 0)]
		 set { } //Length: 11
	}

	public CopyDepthMode copyDepthMode
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 4
		[CallerCount(Count = 0)]
		 set { } //Length: 8
	}

	public StencilStateData defaultStencilState
	{
		[CallerCount(Count = 22)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		 set { } //Length: 17
	}

	public DepthFormat depthAttachmentFormat
	{
		[CalledBy(Type = typeof(UniversalRenderer), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UniversalRendererData)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(SystemInfo), Member = "IsFormatSupported", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GraphicsFormat), typeof(GraphicsFormatUsage)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Debug), Member = "LogWarning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		 get { } //Length: 136
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(GraphicsFormatUtility), Member = "IsStencilFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GraphicsFormat)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Debug), Member = "LogWarning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		 set { } //Length: 184
	}

	public DepthPrimingMode depthPrimingMode
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 4
		[CallerCount(Count = 0)]
		 set { } //Length: 8
	}

	public DepthFormat depthTextureFormat
	{
		[CalledBy(Type = typeof(UniversalRenderer), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UniversalRendererData)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(SystemInfo), Member = "IsFormatSupported", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GraphicsFormat), typeof(GraphicsFormatUsage)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Enum), Member = "ToString", ReturnType = typeof(string))]
		[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(Debug), Member = "LogWarning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		 get { } //Length: 231
		[CallerCount(Count = 0)]
		 set { } //Length: 11
	}

	public IntermediateTextureMode intermediateTextureMode
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 7
		[CallerCount(Count = 0)]
		 set { } //Length: 11
	}

	public LayerMask opaqueLayerMask
	{
		[CallerCount(Count = 26)]
		[DeduplicatedMethod]
		 get { } //Length: 4
		[CallerCount(Count = 0)]
		 set { } //Length: 8
	}

	public RenderingMode renderingMode
	{
		[CallerCount(Count = 3)]
		[DeduplicatedMethod]
		 get { } //Length: 4
		[CallerCount(Count = 0)]
		 set { } //Length: 8
	}

	public bool shadowTransparentReceive
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		 set { } //Length: 8
	}

	internal virtual bool stripAdditionalLightOffVariants
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		internal get { } //Length: 8
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		internal set { } //Length: 7
	}

	internal virtual bool stripShadowsOffVariants
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		internal get { } //Length: 8
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		internal set { } //Length: 7
	}

	public LayerMask transparentLayerMask
	{
		[CallerCount(Count = 3)]
		[DeduplicatedMethod]
		 get { } //Length: 4
		[CallerCount(Count = 0)]
		 set { } //Length: 8
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StencilStateData), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(ScriptableRendererData), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public UniversalRendererData() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Application), Member = "get_isPlaying", ReturnType = typeof(bool))]
	[Calls(Type = typeof(UniversalRenderer), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UniversalRendererData)}, ReturnType = typeof(void))]
	protected virtual ScriptableRenderer Create() { }

	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	public bool get_accurateGbufferNormals() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public CopyDepthMode get_copyDepthMode() { }

	[CallerCount(Count = 22)]
	[DeduplicatedMethod]
	public StencilStateData get_defaultStencilState() { }

	[CalledBy(Type = typeof(UniversalRenderer), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UniversalRendererData)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SystemInfo), Member = "IsFormatSupported", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GraphicsFormat), typeof(GraphicsFormatUsage)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Debug), Member = "LogWarning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	public DepthFormat get_depthAttachmentFormat() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public DepthPrimingMode get_depthPrimingMode() { }

	[CalledBy(Type = typeof(UniversalRenderer), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UniversalRendererData)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SystemInfo), Member = "IsFormatSupported", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GraphicsFormat), typeof(GraphicsFormatUsage)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Enum), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Debug), Member = "LogWarning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	public DepthFormat get_depthTextureFormat() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public IntermediateTextureMode get_intermediateTextureMode() { }

	[CallerCount(Count = 26)]
	[DeduplicatedMethod]
	public LayerMask get_opaqueLayerMask() { }

	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	public RenderingMode get_renderingMode() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public bool get_shadowTransparentReceive() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	internal virtual bool get_stripAdditionalLightOffVariants() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	internal virtual bool get_stripShadowsOffVariants() { }

	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	public LayerMask get_transparentLayerMask() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	protected virtual void OnEnable() { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	private void ReloadAllNullProperties() { }

	[CallerCount(Count = 0)]
	public void set_accurateGbufferNormals(bool value) { }

	[CallerCount(Count = 0)]
	public void set_copyDepthMode(CopyDepthMode value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public void set_defaultStencilState(StencilStateData value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GraphicsFormatUtility), Member = "IsStencilFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GraphicsFormat)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Debug), Member = "LogWarning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	public void set_depthAttachmentFormat(DepthFormat value) { }

	[CallerCount(Count = 0)]
	public void set_depthPrimingMode(DepthPrimingMode value) { }

	[CallerCount(Count = 0)]
	public void set_depthTextureFormat(DepthFormat value) { }

	[CallerCount(Count = 0)]
	public void set_intermediateTextureMode(IntermediateTextureMode value) { }

	[CallerCount(Count = 0)]
	public void set_opaqueLayerMask(LayerMask value) { }

	[CallerCount(Count = 0)]
	public void set_renderingMode(RenderingMode value) { }

	[CallerCount(Count = 0)]
	public void set_shadowTransparentReceive(bool value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	internal virtual void set_stripAdditionalLightOffVariants(bool value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	internal virtual void set_stripShadowsOffVariants(bool value) { }

	[CallerCount(Count = 0)]
	public void set_transparentLayerMask(LayerMask value) { }

	[CallerCount(Count = 0)]
	private override void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize() { }

	[CallerCount(Count = 0)]
	private override void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize() { }

}

