namespace UnityEngine.Rendering.Universal;

public abstract class ScriptableRenderPass : IRenderGraphRecorder
{
	[Obsolete("This rendering path is for compatibility mode only (when Render Graph is disabled). Use Render Graph API instead.", False)]
	public static RTHandle k_CameraTarget; //Field offset: 0x0
	[CompilerGenerated]
	private RenderPassEvent <renderPassEvent>k__BackingField; //Field offset: 0x10
	private RenderBufferStoreAction[] m_ColorStoreActions; //Field offset: 0x18
	private RenderBufferStoreAction m_DepthStoreAction; //Field offset: 0x20
	[CompilerGenerated]
	private bool <requiresIntermediateTexture>k__BackingField; //Field offset: 0x24
	private Boolean[] m_OverriddenColorStoreActions; //Field offset: 0x28
	private bool m_OverriddenDepthStoreAction; //Field offset: 0x30
	private ProfilingSampler m_ProfingSampler; //Field offset: 0x38
	private string m_PassName; //Field offset: 0x40
	private RenderGraphSettings m_RenderGraphSettings; //Field offset: 0x48
	[CompilerGenerated]
	private bool <overrideCameraTarget>k__BackingField; //Field offset: 0x50
	[CompilerGenerated]
	private bool <isBlitRenderPass>k__BackingField; //Field offset: 0x51
	[CompilerGenerated]
	private bool <useNativeRenderPass>k__BackingField; //Field offset: 0x52
	[CompilerGenerated]
	private bool <breakGBufferAndDeferredRenderPass>k__BackingField; //Field offset: 0x53
	[CompilerGenerated]
	private int <renderPassQueueIndex>k__BackingField; //Field offset: 0x54
	internal NativeArray<Int32> m_ColorAttachmentIndices; //Field offset: 0x58
	internal NativeArray<Int32> m_InputAttachmentIndices; //Field offset: 0x68
	[CompilerGenerated]
	private GraphicsFormat[] <renderTargetFormat>k__BackingField; //Field offset: 0x78
	private RTHandle[] m_ColorAttachments; //Field offset: 0x80
	internal RTHandle[] m_InputAttachments; //Field offset: 0x88
	internal Boolean[] m_InputAttachmentIsTransient; //Field offset: 0x90
	private RTHandle m_DepthAttachment; //Field offset: 0x98
	private ScriptableRenderPassInput m_Input; //Field offset: 0xA0
	private ClearFlag m_ClearFlag; //Field offset: 0xA4
	private Color m_ClearColor; //Field offset: 0xA8

	internal bool breakGBufferAndDeferredRenderPass
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		internal get { } //Length: 5
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		internal set { } //Length: 4
	}

	public Color clearColor
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 14
	}

	public ClearFlag clearFlag
	{
		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		 get { } //Length: 7
	}

	[Obsolete("Use colorAttachmentHandle", True)]
	public RenderTargetIdentifier[] colorAttachment
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 4)]
		 get { } //Length: 78
	}

	public RTHandle colorAttachmentHandle
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		 get { } //Length: 42
	}

	public RTHandle[] colorAttachmentHandles
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 8
	}

	[Obsolete("Use colorAttachmentHandles", True)]
	public RenderTargetIdentifier[] colorAttachments
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 4)]
		 get { } //Length: 78
	}

	public RenderBufferStoreAction[] colorStoreActions
	{
		[CallerCount(Count = 31)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	[Obsolete("Use depthAttachmentHandle", True)]
	public RenderTargetIdentifier depthAttachment
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 4)]
		 get { } //Length: 78
	}

	public RTHandle depthAttachmentHandle
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 8
	}

	public RenderBufferStoreAction depthStoreAction
	{
		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		 get { } //Length: 4
	}

	public ScriptableRenderPassInput input
	{
		[CallerCount(Count = 3)]
		[DeduplicatedMethod]
		 get { } //Length: 7
	}

	internal bool isBlitRenderPass
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		internal get { } //Length: 5
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		internal set { } //Length: 4
	}

	internal Boolean[] overriddenColorStoreActions
	{
		[CallerCount(Count = 15)]
		[DeduplicatedMethod]
		internal get { } //Length: 5
	}

	internal bool overriddenDepthStoreAction
	{
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		internal get { } //Length: 5
	}

	internal bool overrideCameraTarget
	{
		[CallerCount(Count = 8)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		internal get { } //Length: 5
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		internal set { } //Length: 4
	}

	protected private string passName
	{
		[CallerCount(Count = 12)]
		[DeduplicatedMethod]
		private get { } //Length: 5
	}

	protected private ProfilingSampler profilingSampler
	{
		[CallerCount(Count = 54)]
		[Calls(Type = typeof(GraphicsSettings), Member = "GetRenderPipelineSettings", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
		[Calls(Type = typeof(RenderGraphSettings), Member = "get_enableRenderCompatibilityMode", ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 2)]
		private get { } //Length: 148
		[CallerCount(Count = 35)]
		[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 3)]
		private set { } //Length: 105
	}

	public RenderPassEvent renderPassEvent
	{
		[CallerCount(Count = 94)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 4
		[CallerCount(Count = 7)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	internal int renderPassQueueIndex
	{
		[CallerCount(Count = 14)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		internal get { } //Length: 4
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		internal set { } //Length: 4
	}

	internal GraphicsFormat[] renderTargetFormat
	{
		[CallerCount(Count = 7)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		internal get { } //Length: 5
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		internal set { } //Length: 13
	}

	public bool requiresIntermediateTexture
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	internal bool useNativeRenderPass
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		internal get { } //Length: 5
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		internal set { } //Length: 4
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BuiltinRenderTextureType)}, ReturnType = typeof(RenderTargetIdentifier))]
	[Calls(Type = typeof(RTHandles), Member = "Alloc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTargetIdentifier)}, ReturnType = typeof(RTHandle))]
	[CallsUnknownMethods(Count = 1)]
	private static ScriptableRenderPass() { }

	[CallerCount(Count = 40)]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(ProfilingSampler), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 19)]
	public ScriptableRenderPass() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CameraData), Member = "get_renderer", ReturnType = typeof(ScriptableRenderer&))]
	[Calls(Type = typeof(ScriptableRenderer), Member = "get_cameraColorTargetHandle", ReturnType = typeof(RTHandle))]
	[Calls(Type = typeof(ScriptableRenderPass), Member = "Blit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(RTHandle), typeof(RTHandle), typeof(Material), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[Obsolete("This rendering path is for compatibility mode only (when Render Graph is disabled). Use Render Graph API instead.", False)]
	public void Blit(CommandBuffer cmd, ref RenderingData data, RTHandle source, Material material, int passIndex = 0) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CameraData), Member = "get_renderer", ReturnType = typeof(ScriptableRenderer&))]
	[Calls(Type = typeof(ScriptableRenderer), Member = "get_cameraColorTargetHandle", ReturnType = typeof(RTHandle))]
	[Calls(Type = typeof(ScriptableRenderPass), Member = "Blit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(RTHandle), typeof(RTHandle), typeof(Material), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[Obsolete("This rendering path is for compatibility mode only (when Render Graph is disabled). Use Render Graph API instead.", False)]
	public void Blit(CommandBuffer cmd, ref RenderingData data, Material material, int passIndex = 0) { }

	[CalledBy(Type = typeof(ScriptableRenderPass), Member = "Blit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(RenderingData&), typeof(Material), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScriptableRenderPass), Member = "Blit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(RenderingData&), typeof(RTHandle), typeof(Material), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Blitter), Member = "BlitCameraTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(RTHandle), typeof(RTHandle), typeof(Material), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Texture), Member = "get_filterMode", ReturnType = typeof(FilterMode))]
	[Calls(Type = typeof(Blitter), Member = "BlitCameraTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(RTHandle), typeof(RTHandle), typeof(float), typeof(bool)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Obsolete("This rendering path is for compatibility mode only (when Render Graph is disabled). Use Render Graph API instead.", False)]
	public void Blit(CommandBuffer cmd, RTHandle source, RTHandle destination, Material material = null, int passIndex = 0) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	[Obsolete("Use RTHandles for source and destination", True)]
	public void Blit(CommandBuffer cmd, RenderTargetIdentifier source, RenderTargetIdentifier destination, Material material = null, int passIndex = 0) { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	[Obsolete("This rendering path is for compatibility mode only (when Render Graph is disabled). Use Render Graph API instead.", False)]
	public override void Configure(CommandBuffer cmd, RenderTextureDescriptor cameraTextureDescriptor) { }

	[CalledBy(Type = typeof(DrawScreenSpaceUIPass), Member = "OnCameraSetup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(RenderingData&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MotionVectorRenderPass), Member = "Configure", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(RenderTextureDescriptor)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScreenSpaceAmbientOcclusionPass), Member = "OnCameraSetup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(RenderingData&)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.ScreenSpaceShadows+ScreenSpaceShadowsPass", Member = "OnCameraSetup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(RenderingData&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(AdditionalLightsShadowCasterPass), Member = "Configure", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(RenderTextureDescriptor)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CopyDepthPass), Member = "OnCameraSetup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(RenderingData&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DepthNormalOnlyPass), Member = "OnCameraSetup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(RenderingData&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DepthOnlyPass), Member = "OnCameraSetup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(RenderingData&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GBufferPass), Member = "Configure", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(RenderTextureDescriptor)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MainLightShadowCasterPass), Member = "Configure", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(RenderTextureDescriptor)}, ReturnType = typeof(void))]
	[CallerCount(Count = 11)]
	[Obsolete("This rendering path is for compatibility mode only (when Render Graph is disabled). Use Render Graph API instead.", False)]
	public void ConfigureClear(ClearFlag clearFlag, Color clearColor) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[Obsolete("This rendering path is for compatibility mode only (when Render Graph is disabled). Use Render Graph API instead.", False)]
	public void ConfigureColorStoreAction(RenderBufferStoreAction storeAction, uint attachmentIndex = 0) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Math), Member = "Min", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 2)]
	[Obsolete("This rendering path is for compatibility mode only (when Render Graph is disabled). Use Render Graph API instead.", False)]
	public void ConfigureColorStoreActions(RenderBufferStoreAction[] storeActions) { }

	[CalledBy(Type = typeof(MotionVectorRenderPass), Member = "Configure", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(RenderTextureDescriptor)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Obsolete("This rendering path is for compatibility mode only (when Render Graph is disabled). Use Render Graph API instead.", False)]
	public void ConfigureDepthStoreAction(RenderBufferStoreAction storeAction) { }

	[CallerCount(Count = 7)]
	[DeduplicatedMethod]
	public void ConfigureInput(ScriptableRenderPassInput passInput) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 6)]
	[Obsolete("This rendering path is for compatibility mode only (when Render Graph is disabled). Use Render Graph API instead.", False)]
	internal void ConfigureInputAttachments(RTHandle input, bool isTransient = false) { }

	[CalledBy(Type = typeof(DeferredPass), Member = "Configure", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(RenderTextureDescriptor)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[Obsolete("This rendering path is for compatibility mode only (when Render Graph is disabled). Use Render Graph API instead.", False)]
	internal void ConfigureInputAttachments(RTHandle[] inputs, Boolean[] isTransient) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Obsolete("This rendering path is for compatibility mode only (when Render Graph is disabled). Use Render Graph API instead.", False)]
	internal void ConfigureInputAttachments(RTHandle[] inputs) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ScriptableRenderPass), Member = "ConfigureTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RTHandle[]), typeof(RTHandle)}, ReturnType = typeof(void))]
	[Obsolete("This rendering path is for compatibility mode only (when Render Graph is disabled). Use Render Graph API instead.", False)]
	public void ConfigureTarget(RTHandle[] colorAttachments) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	[Obsolete("Use RTHandles for colorAttachments", True)]
	public void ConfigureTarget(RenderTargetIdentifier[] colorAttachments) { }

	[CalledBy(Type = typeof(DrawScreenSpaceUIPass), Member = "OnCameraSetup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(RenderingData&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScreenSpaceAmbientOcclusionPass), Member = "OnCameraSetup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(RenderingData&)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.ScreenSpaceShadows+ScreenSpaceShadowsPass", Member = "OnCameraSetup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(RenderingData&)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.ScreenSpaceShadows+ScreenSpaceShadowsPostPass", Member = "Configure", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(RenderTextureDescriptor)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(AdditionalLightsShadowCasterPass), Member = "Configure", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(RenderTextureDescriptor)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CopyDepthPass), Member = "OnCameraSetup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(RenderingData&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DepthOnlyPass), Member = "OnCameraSetup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(RenderingData&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MainLightShadowCasterPass), Member = "Configure", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(RenderTextureDescriptor)}, ReturnType = typeof(void))]
	[CallerCount(Count = 11)]
	[CallsUnknownMethods(Count = 8)]
	[Obsolete("This rendering path is for compatibility mode only (when Render Graph is disabled). Use Render Graph API instead.", False)]
	public void ConfigureTarget(RTHandle colorAttachment) { }

	[CalledBy(Type = typeof(GBufferPass), Member = "Configure", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(RenderTextureDescriptor)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ScriptableRenderPass), Member = "ConfigureTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RTHandle[]), typeof(RTHandle)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[Obsolete("This rendering path is for compatibility mode only (when Render Graph is disabled). Use Render Graph API instead.", False)]
	internal void ConfigureTarget(RTHandle[] colorAttachments, RTHandle depthAttachment, GraphicsFormat[] formats) { }

	[CalledBy(Type = typeof(DBufferRenderPass), Member = "OnCameraSetup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(RenderingData&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DecalGBufferRenderPass), Member = "Configure", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(RenderTextureDescriptor)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScriptableRenderPass), Member = "ConfigureTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RTHandle[]), typeof(RTHandle), typeof(GraphicsFormat[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScriptableRenderPass), Member = "ConfigureTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RTHandle[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DepthNormalOnlyPass), Member = "OnCameraSetup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(RenderingData&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DrawObjectsWithRenderingLayersPass), Member = "Configure", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(RenderTextureDescriptor)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(RenderingUtils), Member = "GetValidColorBufferCount", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RTHandle[])}, ReturnType = typeof(uint))]
	[Calls(Type = typeof(uint), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 8)]
	[Obsolete("This rendering path is for compatibility mode only (when Render Graph is disabled). Use Render Graph API instead.", False)]
	public void ConfigureTarget(RTHandle[] colorAttachments, RTHandle depthAttachment) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	[Obsolete("Use RTHandles for colorAttachments and depthAttachment", True)]
	public void ConfigureTarget(RenderTargetIdentifier[] colorAttachments, RenderTargetIdentifier depthAttachment) { }

	[CalledBy(Type = typeof(DrawScreenSpaceUIPass), Member = "OnCameraSetup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(RenderingData&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MotionVectorRenderPass), Member = "Configure", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(RenderTextureDescriptor)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DeferredPass), Member = "Configure", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(RenderTextureDescriptor)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FinalBlitPass), Member = "OnCameraSetup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(RenderingData&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[CallsUnknownMethods(Count = 8)]
	[Obsolete("This rendering path is for compatibility mode only (when Render Graph is disabled). Use Render Graph API instead.", False)]
	public void ConfigureTarget(RTHandle colorAttachment, RTHandle depthAttachment) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	[Obsolete("Use RTHandles for colorAttachment and depthAttachment", True)]
	public void ConfigureTarget(RenderTargetIdentifier colorAttachment, RenderTargetIdentifier depthAttachment) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	[Obsolete("Use RTHandle for colorAttachment", True)]
	public void ConfigureTarget(RenderTargetIdentifier colorAttachment) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ContextContainer), Member = "Get", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(RenderingUtils), Member = "CreateDrawingSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ShaderTagId), typeof(UniversalRenderingData), typeof(UniversalCameraData), typeof(UniversalLightData), typeof(SortingCriteria)}, ReturnType = typeof(DrawingSettings))]
	[CallsUnknownMethods(Count = 1)]
	public DrawingSettings CreateDrawingSettings(ShaderTagId shaderTagId, ref RenderingData renderingData, SortingCriteria sortingCriteria) { }

	[CalledBy(Type = typeof(GBufferPass), Member = "InitRendererLists", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PassData&), typeof(ScriptableRenderContext), typeof(RenderGraph), typeof(UniversalRenderingData), typeof(UniversalCameraData), typeof(UniversalLightData), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(RenderingUtils), Member = "CreateDrawingSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ShaderTagId), typeof(UniversalRenderingData), typeof(UniversalCameraData), typeof(UniversalLightData), typeof(SortingCriteria)}, ReturnType = typeof(DrawingSettings))]
	public DrawingSettings CreateDrawingSettings(ShaderTagId shaderTagId, UniversalRenderingData renderingData, UniversalCameraData cameraData, UniversalLightData lightData, SortingCriteria sortingCriteria) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ContextContainer), Member = "Get", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(RenderingUtils), Member = "CreateDrawingSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.Rendering.ShaderTagId>), typeof(UniversalRenderingData), typeof(UniversalCameraData), typeof(UniversalLightData), typeof(SortingCriteria)}, ReturnType = typeof(DrawingSettings))]
	[CallsUnknownMethods(Count = 1)]
	public DrawingSettings CreateDrawingSettings(List<ShaderTagId> shaderTagIdList, ref RenderingData renderingData, SortingCriteria sortingCriteria) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RenderingUtils), Member = "CreateDrawingSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.Rendering.ShaderTagId>), typeof(UniversalRenderingData), typeof(UniversalCameraData), typeof(UniversalLightData), typeof(SortingCriteria)}, ReturnType = typeof(DrawingSettings))]
	public DrawingSettings CreateDrawingSettings(List<ShaderTagId> shaderTagIdList, UniversalRenderingData renderingData, UniversalCameraData cameraData, UniversalLightData lightData, SortingCriteria sortingCriteria) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Debug), Member = "LogWarning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Obsolete("This rendering path is for compatibility mode only (when Render Graph is disabled). Use Render Graph API instead.", False)]
	public override void Execute(ScriptableRenderContext context, ref RenderingData renderingData) { }

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[EditorBrowsable(EditorBrowsableState::Never (1))]
	public override void FrameCleanup(CommandBuffer cmd) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	internal bool get_breakGBufferAndDeferredRenderPass() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public Color get_clearColor() { }

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public ClearFlag get_clearFlag() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	public RenderTargetIdentifier[] get_colorAttachment() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public RTHandle get_colorAttachmentHandle() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public RTHandle[] get_colorAttachmentHandles() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	public RenderTargetIdentifier[] get_colorAttachments() { }

	[CallerCount(Count = 31)]
	[DeduplicatedMethod]
	public RenderBufferStoreAction[] get_colorStoreActions() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	public RenderTargetIdentifier get_depthAttachment() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public RTHandle get_depthAttachmentHandle() { }

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public RenderBufferStoreAction get_depthStoreAction() { }

	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	public ScriptableRenderPassInput get_input() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	internal bool get_isBlitRenderPass() { }

	[CallerCount(Count = 15)]
	[DeduplicatedMethod]
	internal Boolean[] get_overriddenColorStoreActions() { }

	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	internal bool get_overriddenDepthStoreAction() { }

	[CallerCount(Count = 8)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	internal bool get_overrideCameraTarget() { }

	[CallerCount(Count = 12)]
	[DeduplicatedMethod]
	protected private string get_passName() { }

	[CallerCount(Count = 54)]
	[Calls(Type = typeof(GraphicsSettings), Member = "GetRenderPipelineSettings", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(RenderGraphSettings), Member = "get_enableRenderCompatibilityMode", ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 2)]
	protected private ProfilingSampler get_profilingSampler() { }

	[CallerCount(Count = 94)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public RenderPassEvent get_renderPassEvent() { }

	[CallerCount(Count = 14)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	internal int get_renderPassQueueIndex() { }

	[CallerCount(Count = 7)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	internal GraphicsFormat[] get_renderTargetFormat() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public bool get_requiresIntermediateTexture() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	internal bool get_useNativeRenderPass() { }

	[CalledBy(Type = typeof(DrawScreenSpaceUIPass), Member = "OnCameraSetup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(RenderingData&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FinalBlitPass), Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), typeof(RenderingData&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FinalBlitPass), Member = "OnCameraSetup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(RenderingData&)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.Internal.FinalBlitPass+<>c", Member = "<Render>b__17_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.Internal.FinalBlitPass+PassData", typeof(RasterGraphContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DrawObjectsWithRenderingLayersPass), Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(ContextContainer), typeof(TextureHandle), typeof(TextureHandle), typeof(TextureHandle), typeof(TextureHandle), typeof(TextureHandle), typeof(MaskSize), typeof(uint)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DrawObjectsPass), Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(ContextContainer), typeof(TextureHandle), typeof(TextureHandle), typeof(TextureHandle), typeof(TextureHandle), typeof(uint)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DrawObjectsPass), Member = "InitRendererLists", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UniversalRenderingData), typeof(UniversalCameraData), typeof(UniversalLightData), typeof(PassData&), typeof(ScriptableRenderContext), typeof(RenderGraph), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DrawObjectsPass), Member = "ExecutePass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RasterCommandBuffer), typeof(PassData), typeof(RendererList), typeof(RendererList), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(StpUtils), Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(UniversalResourceData), typeof(UniversalCameraData), typeof(TextureHandle), typeof(TextureHandle), typeof(TextureHandle), typeof(TextureHandle), typeof(Texture2D)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalRenderer), Member = "OnAfterRendering", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RenderObjectsPass), Member = "InitRendererLists", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UniversalRenderingData), typeof(UniversalLightData), typeof(PassData&), typeof(ScriptableRenderContext), typeof(RenderGraph), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RenderObjectsPass), Member = "ExecutePass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.RenderObjectsPass+PassData", typeof(RasterCommandBuffer), typeof(RendererList), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PostProcessPass), Member = "RenderPostProcessingRenderGraph", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(ContextContainer), typeof(TextureHandle&), typeof(TextureHandle&), typeof(TextureHandle&), typeof(TextureHandle&), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PostProcessPass), Member = "RenderFinalPassRenderGraph", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(ContextContainer), typeof(TextureHandle&), typeof(TextureHandle&), typeof(TextureHandle&), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PostProcessPass), Member = "RenderFinalPass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(RenderingData&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PostProcessPass), Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(RenderingData&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DrawSkyboxPass), Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(ContextContainer), typeof(ScriptableRenderContext), typeof(TextureHandle), typeof(TextureHandle), typeof(Material)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DrawSkyboxPass), Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), typeof(RenderingData&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RenderObjectsPass), Member = "RecordRenderGraph", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(ContextContainer)}, ReturnType = typeof(void))]
	[CallerCount(Count = 19)]
	[Calls(Type = typeof(DebugHandler), Member = "IsActiveForCamera", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(UniversalCameraData), Member = "get_isPreviewCamera", ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	internal static DebugHandler GetActiveDebugHandler(UniversalCameraData cameraData) { }

	[CalledBy(Type = typeof(ScriptableRenderer), Member = "CalculateSplitEventRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderPassEvent), typeof(RenderPassEvent), typeof(RenderPassEvent&), typeof(RenderPassEvent&), typeof(RenderPassEvent&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScriptableRenderer), Member = "RecordCustomRenderGraphPasses", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(RenderPassEvent), typeof(RenderPassEvent)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScriptableRenderer), Member = "RecordCustomRenderGraphPasses", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(RenderPassEvent)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScriptableRenderer), Member = "InterruptFramebufferFetch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FramebufferFetchEvent), typeof(RenderPassEvent), typeof(RenderPassEvent)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	internal static int GetRenderPassEventRange(RenderPassEvent renderPassEvent) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Obsolete("This rendering path is for compatibility mode only (when Render Graph is disabled). Use Render Graph API instead.", False)]
	internal bool IsInputAttachmentTransient(int idx) { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	public override void OnCameraCleanup(CommandBuffer cmd) { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	[Obsolete("This rendering path is for compatibility mode only (when Render Graph is disabled). Use Render Graph API instead.", False)]
	public override void OnCameraSetup(CommandBuffer cmd, ref RenderingData renderingData) { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	[Obsolete("This rendering path is for compatibility mode only (when Render Graph is disabled). Use Render Graph API instead.", False)]
	public override void OnFinishCameraStackRendering(CommandBuffer cmd) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public static bool op_GreaterThan(ScriptableRenderPass lhs, ScriptableRenderPass rhs) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public static bool op_LessThan(ScriptableRenderPass lhs, ScriptableRenderPass rhs) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Debug), Member = "LogWarning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	public override void RecordRenderGraph(RenderGraph renderGraph, ContextContainer frameData) { }

	[CalledBy(Type = typeof(FullScreenRenderPass), Member = "OnCameraSetup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(RenderingData&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	[Obsolete("This rendering path is for compatibility mode only (when Render Graph is disabled). Use Render Graph API instead.", False)]
	public void ResetTarget() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	internal void set_breakGBufferAndDeferredRenderPass(bool value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	internal void set_isBlitRenderPass(bool value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	internal void set_overrideCameraTarget(bool value) { }

	[CallerCount(Count = 35)]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	protected private void set_profilingSampler(ProfilingSampler value) { }

	[CallerCount(Count = 7)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_renderPassEvent(RenderPassEvent value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	internal void set_renderPassQueueIndex(int value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	internal void set_renderTargetFormat(GraphicsFormat[] value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_requiresIntermediateTexture(bool value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	internal void set_useNativeRenderPass(bool value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[Obsolete("This rendering path is for compatibility mode only (when Render Graph is disabled). Use Render Graph API instead.", False)]
	internal void SetInputAttachmentTransient(int idx, bool isTransient) { }

}

