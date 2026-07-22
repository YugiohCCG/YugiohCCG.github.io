namespace UnityEngine.Rendering.Universal.Internal;

internal class DeferredLights
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static BaseRenderFunc<SetupLightPassData, UnsafeGraphContext> <>9__139_0; //Field offset: 0x8

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		private static <>c() { }

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(DeferredLights), Member = "SetupLights", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(UniversalCameraData), typeof(Vector2Int), typeof(UniversalLightData), typeof(bool)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		internal void <SetupRenderGraphLights>b__139_0(SetupLightPassData data, UnsafeGraphContext rgContext) { }

	}

	public struct InitParams
	{
		public Material stencilDeferredMaterial; //Field offset: 0x0
		public LightCookieManager lightCookieManager; //Field offset: 0x8

	}

	private class SetupLightPassData
	{
		internal UniversalCameraData cameraData; //Field offset: 0x10
		internal UniversalLightData lightData; //Field offset: 0x18
		internal DeferredLights deferredLights; //Field offset: 0x20
		internal Vector2Int cameraTargetSizeCopy; //Field offset: 0x28

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public SetupLightPassData() { }

	}

	public static class ShaderConstants
	{
		public static readonly int _LitStencilRef; //Field offset: 0x0
		public static readonly int _LitStencilReadMask; //Field offset: 0x4
		public static readonly int _LitStencilWriteMask; //Field offset: 0x8
		public static readonly int _SimpleLitStencilRef; //Field offset: 0xC
		public static readonly int _SimpleLitStencilReadMask; //Field offset: 0x10
		public static readonly int _SimpleLitStencilWriteMask; //Field offset: 0x14
		public static readonly int _StencilRef; //Field offset: 0x18
		public static readonly int _StencilReadMask; //Field offset: 0x1C
		public static readonly int _StencilWriteMask; //Field offset: 0x20
		public static readonly int _LitPunctualStencilRef; //Field offset: 0x24
		public static readonly int _LitPunctualStencilReadMask; //Field offset: 0x28
		public static readonly int _LitPunctualStencilWriteMask; //Field offset: 0x2C
		public static readonly int _SimpleLitPunctualStencilRef; //Field offset: 0x30
		public static readonly int _SimpleLitPunctualStencilReadMask; //Field offset: 0x34
		public static readonly int _SimpleLitPunctualStencilWriteMask; //Field offset: 0x38
		public static readonly int _LitDirStencilRef; //Field offset: 0x3C
		public static readonly int _LitDirStencilReadMask; //Field offset: 0x40
		public static readonly int _LitDirStencilWriteMask; //Field offset: 0x44
		public static readonly int _SimpleLitDirStencilRef; //Field offset: 0x48
		public static readonly int _SimpleLitDirStencilReadMask; //Field offset: 0x4C
		public static readonly int _SimpleLitDirStencilWriteMask; //Field offset: 0x50
		public static readonly int _ClearStencilRef; //Field offset: 0x54
		public static readonly int _ClearStencilReadMask; //Field offset: 0x58
		public static readonly int _ClearStencilWriteMask; //Field offset: 0x5C
		public static readonly int _ScreenToWorld; //Field offset: 0x60
		public static int _MainLightPosition; //Field offset: 0x64
		public static int _MainLightColor; //Field offset: 0x68
		public static int _MainLightLayerMask; //Field offset: 0x6C
		public static int _SpotLightScale; //Field offset: 0x70
		public static int _SpotLightBias; //Field offset: 0x74
		public static int _SpotLightGuard; //Field offset: 0x78
		public static int _LightPosWS; //Field offset: 0x7C
		public static int _LightColor; //Field offset: 0x80
		public static int _LightAttenuation; //Field offset: 0x84
		public static int _LightOcclusionProbInfo; //Field offset: 0x88
		public static int _LightDirection; //Field offset: 0x8C
		public static int _LightFlags; //Field offset: 0x90
		public static int _ShadowLightIndex; //Field offset: 0x94
		public static int _LightLayerMask; //Field offset: 0x98
		public static int _CookieLightIndex; //Field offset: 0x9C

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Shader), Member = "PropertyToID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
		private static ShaderConstants() { }

	}

	public enum StencilDeferredPasses
	{
		StencilVolume = 0,
		PunctualLit = 1,
		PunctualSimpleLit = 2,
		DirectionalLit = 3,
		DirectionalSimpleLit = 4,
		ClearStencilPartial = 5,
		Fog = 6,
		SSAOOnly = 7,
	}

	internal static readonly String[] k_GBufferNames; //Field offset: 0x0
	internal static readonly Int32[] k_GBufferShaderPropertyIDs; //Field offset: 0x8
	private static readonly String[] k_StencilDeferredPassNames; //Field offset: 0x10
	private static readonly ushort k_InvalidLightOffset; //Field offset: 0x18
	private static readonly string k_SetupLights; //Field offset: 0x20
	private static readonly string k_DeferredPass; //Field offset: 0x28
	private static readonly string k_DeferredStencilPass; //Field offset: 0x30
	private static readonly string k_DeferredFogPass; //Field offset: 0x38
	private static readonly string k_ClearStencilPartial; //Field offset: 0x40
	private static readonly string k_SetupLightConstants; //Field offset: 0x48
	private static readonly float kStencilShapeGuard; //Field offset: 0x50
	private static readonly ProfilingSampler m_ProfilingSetupLights; //Field offset: 0x58
	private static readonly ProfilingSampler m_ProfilingDeferredPass; //Field offset: 0x60
	private static readonly ProfilingSampler m_ProfilingSetupLightConstants; //Field offset: 0x68
	private static ProfilingSampler s_SetupDeferredLights; //Field offset: 0x70
	[CompilerGenerated]
	private MaskSize <RenderingLayerMaskSize>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private bool <UseDecalLayers>k__BackingField; //Field offset: 0x14
	[CompilerGenerated]
	private bool <UseFramebufferFetch>k__BackingField; //Field offset: 0x15
	[CompilerGenerated]
	private bool <HasDepthPrepass>k__BackingField; //Field offset: 0x16
	[CompilerGenerated]
	private bool <HasNormalPrepass>k__BackingField; //Field offset: 0x17
	[CompilerGenerated]
	private bool <HasRenderingLayerPrepass>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private bool <IsOverlay>k__BackingField; //Field offset: 0x19
	[CompilerGenerated]
	private bool <AccurateGbufferNormals>k__BackingField; //Field offset: 0x1A
	[CompilerGenerated]
	private MixedLightingSetup <MixedLightingSetup>k__BackingField; //Field offset: 0x1C
	[CompilerGenerated]
	private bool <UseJobSystem>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private int <RenderWidth>k__BackingField; //Field offset: 0x24
	[CompilerGenerated]
	private int <RenderHeight>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	private RTHandle[] <GbufferAttachments>k__BackingField; //Field offset: 0x30
	private RTHandle[] GbufferRTHandles; //Field offset: 0x38
	[CompilerGenerated]
	private TextureHandle[] <GbufferTextureHandles>k__BackingField; //Field offset: 0x40
	[CompilerGenerated]
	private RTHandle[] <DeferredInputAttachments>k__BackingField; //Field offset: 0x48
	[CompilerGenerated]
	private Boolean[] <DeferredInputIsTransient>k__BackingField; //Field offset: 0x50
	[CompilerGenerated]
	private RTHandle <DepthAttachment>k__BackingField; //Field offset: 0x58
	[CompilerGenerated]
	private RTHandle <DepthCopyTexture>k__BackingField; //Field offset: 0x60
	[CompilerGenerated]
	private GraphicsFormat[] <GbufferFormats>k__BackingField; //Field offset: 0x68
	[CompilerGenerated]
	private RTHandle <DepthAttachmentHandle>k__BackingField; //Field offset: 0x70
	private NativeArray<UInt16> m_stencilVisLights; //Field offset: 0x78
	private NativeArray<UInt16> m_stencilVisLightOffsets; //Field offset: 0x88
	private AdditionalLightsShadowCasterPass m_AdditionalLightsShadowCasterPass; //Field offset: 0x98
	private Mesh m_SphereMesh; //Field offset: 0xA0
	private Mesh m_HemisphereMesh; //Field offset: 0xA8
	private Mesh m_FullscreenMesh; //Field offset: 0xB0
	private Material m_StencilDeferredMaterial; //Field offset: 0xB8
	private Int32[] m_StencilDeferredPasses; //Field offset: 0xC0
	private Matrix4x4[] m_ScreenToWorld; //Field offset: 0xC8
	private ProfilingSampler m_ProfilingSamplerDeferredStencilPass; //Field offset: 0xD0
	private ProfilingSampler m_ProfilingSamplerDeferredFogPass; //Field offset: 0xD8
	private ProfilingSampler m_ProfilingSamplerClearStencilPartialPass; //Field offset: 0xE0
	private LightCookieManager m_LightCookieManager; //Field offset: 0xE8

	internal bool AccurateGbufferNormals
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

	internal RTHandle[] DeferredInputAttachments
	{
		[CallerCount(Count = 10)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		internal get { } //Length: 254
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		internal set { } //Length: 13
	}

	internal Boolean[] DeferredInputIsTransient
	{
		[CallerCount(Count = 16)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		internal get { } //Length: 5
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		internal set { } //Length: 13
	}

	internal RTHandle DepthAttachment
	{
		[CallerCount(Count = 10)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		internal get { } //Length: 5
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		internal set { } //Length: 13
	}

	internal RTHandle DepthAttachmentHandle
	{
		[CallerCount(Count = 9)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		internal get { } //Length: 5
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		internal set { } //Length: 13
	}

	internal RTHandle DepthCopyTexture
	{
		[CallerCount(Count = 84)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		internal get { } //Length: 5
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		internal set { } //Length: 13
	}

	internal int GBufferAlbedoIndex
	{
		[CallerCount(Count = 182)]
		[DeduplicatedMethod]
		internal get { } //Length: 3
	}

	internal RTHandle[] GbufferAttachments
	{
		[CallerCount(Count = 62)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		internal get { } //Length: 5
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		internal set { } //Length: 13
	}

	internal int GbufferDepthIndex
	{
		[CalledBy(Type = typeof(DecalGBufferRenderPass), Member = "Configure", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(RenderTextureDescriptor)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(GBufferPass), Member = "Configure", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(RenderTextureDescriptor)}, ReturnType = typeof(void))]
		[CallerCount(Count = 5)]
		internal get { } //Length: 18
	}

	internal GraphicsFormat[] GbufferFormats
	{
		[CallerCount(Count = 22)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		internal get { } //Length: 5
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		internal set { } //Length: 13
	}

	internal int GBufferInputAttachmentCount
	{
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		internal get { } //Length: 14
	}

	internal int GBufferLightingIndex
	{
		[CallerCount(Count = 6)]
		[DeduplicatedMethod]
		internal get { } //Length: 6
	}

	internal int GBufferNormalSmoothnessIndex
	{
		[CallerCount(Count = 8)]
		[DeduplicatedMethod]
		internal get { } //Length: 6
	}

	internal int GBufferRenderingLayers
	{
		[CalledBy(Type = typeof(DecalGBufferRenderPass), Member = "Configure", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(RenderTextureDescriptor)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UniversalRenderer), Member = "Setup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), typeof(RenderingData&)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UniversalRenderer), Member = "CreateRenderingLayersTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(RenderTextureDescriptor)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DeferredLights), Member = "GetGBufferFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(GraphicsFormat))]
		[CalledBy(Type = typeof(DeferredLights), Member = "UpdateDeferredInputAttachments", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(GBufferPass), Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(ContextContainer), typeof(TextureHandle), typeof(TextureHandle), typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 10)]
		[Calls(Type = typeof(UniversalRenderPipeline), Member = "get_asset", ReturnType = typeof(UniversalRenderPipelineAsset))]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		internal get { } //Length: 118
	}

	internal int GBufferShadowMask
	{
		[CalledBy(Type = typeof(DeferredLights), Member = "GetGBufferFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(GraphicsFormat))]
		[CalledBy(Type = typeof(DeferredLights), Member = "UpdateDeferredInputAttachments", ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(UniversalRenderPipeline), Member = "get_asset", ReturnType = typeof(UniversalRenderPipelineAsset))]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		internal get { } //Length: 147
	}

	internal int GBufferSliceCount
	{
		[CalledBy(Type = typeof(DeferredLights), Member = "IsRuntimeSupportedThisFrame", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(GBufferPass), Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(ContextContainer), typeof(TextureHandle), typeof(TextureHandle), typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(UniversalRenderPipeline), Member = "get_asset", ReturnType = typeof(UniversalRenderPipelineAsset))]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		internal get { } //Length: 149
	}

	internal int GBufferSpecularMetallicIndex
	{
		[CallerCount(Count = 9)]
		[DeduplicatedMethod]
		internal get { } //Length: 6
	}

	internal TextureHandle[] GbufferTextureHandles
	{
		[CallerCount(Count = 12)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		internal get { } //Length: 5
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		internal set { } //Length: 13
	}

	internal bool HasDepthPrepass
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		internal get { } //Length: 5
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		internal set { } //Length: 4
	}

	internal bool HasNormalPrepass
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		internal get { } //Length: 5
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		internal set { } //Length: 4
	}

	internal bool HasRenderingLayerPrepass
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

	internal bool IsOverlay
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

	internal MixedLightingSetup MixedLightingSetup
	{
		[CallerCount(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		internal get { } //Length: 4
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		internal set { } //Length: 4
	}

	internal int RenderHeight
	{
		[CallerCount(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		internal get { } //Length: 4
		[CallerCount(Count = 5)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		internal set { } //Length: 4
	}

	internal MaskSize RenderingLayerMaskSize
	{
		[CallerCount(Count = 94)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		internal get { } //Length: 4
		[CallerCount(Count = 7)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		internal set { } //Length: 4
	}

	internal int RenderWidth
	{
		[CallerCount(Count = 9)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		internal get { } //Length: 4
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		internal set { } //Length: 4
	}

	internal bool UseDecalLayers
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

	internal bool UseFramebufferFetch
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

	internal bool UseJobSystem
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		internal get { } //Length: 5
		[CallerCount(Count = 3)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		internal set { } //Length: 4
	}

	internal bool UseLightLayers
	{
		[CalledBy(Type = typeof(GBufferPass), Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(ContextContainer), typeof(TextureHandle), typeof(TextureHandle), typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(UniversalRenderPipeline), Member = "get_asset", ReturnType = typeof(UniversalRenderPipelineAsset))]
		[CallsUnknownMethods(Count = 1)]
		internal get { } //Length: 82
	}

	internal bool UseRenderingLayers
	{
		[CalledBy(Type = typeof(UniversalRenderer), Member = "Setup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), typeof(RenderingData&)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UniversalRenderer), Member = "CreateRenderingLayersTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(RenderTextureDescriptor)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DeferredLights), Member = "UpdateDeferredInputAttachments", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.Internal.GBufferPass+<>c", Member = "<Render>b__21_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.Internal.GBufferPass+PassData", typeof(RasterGraphContext)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(GBufferPass), Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), typeof(RenderingData&)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(GBufferPass), Member = "ExecutePass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RasterCommandBuffer), "UnityEngine.Rendering.Universal.Internal.GBufferPass+PassData", typeof(RendererList), typeof(RendererList)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(GBufferPass), Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(ContextContainer), typeof(TextureHandle), typeof(TextureHandle), typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 10)]
		[Calls(Type = typeof(UniversalRenderPipeline), Member = "get_asset", ReturnType = typeof(UniversalRenderPipelineAsset))]
		[CallsUnknownMethods(Count = 1)]
		internal get { } //Length: 102
	}

	internal bool UseShadowMask
	{
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		internal get { } //Length: 8
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Shader), Member = "PropertyToID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ProfilingSampler), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 30)]
	private static DeferredLights() { }

	[CalledBy(Type = typeof(UniversalRenderer), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UniversalRendererData)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ProfilingSampler), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DeferredLights), Member = "InitStencilDeferredMaterial", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 8)]
	[ContainsUnimplementedInstructions]
	internal DeferredLights(InitParams initParams, bool useNativeRenderPass = false) { }

	[CalledBy(Type = "UnityEngine.Rendering.Universal.Internal.GBufferPass+<>c", Member = "<Render>b__21_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.Internal.GBufferPass+PassData", typeof(RasterGraphContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GBufferPass), Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), typeof(RenderingData&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GBufferPass), Member = "ExecutePass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RasterCommandBuffer), "UnityEngine.Rendering.Universal.Internal.GBufferPass+PassData", typeof(RendererList), typeof(RendererList)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DeferredLights), Member = "CreateFullscreenMesh", ReturnType = typeof(Mesh))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 5)]
	internal void ClearStencilPartial(RasterCommandBuffer cmd) { }

	[CalledBy(Type = typeof(DeferredLights), Member = "ClearStencilPartial", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RasterCommandBuffer)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DeferredLights), Member = "ExecuteDeferredPass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RasterCommandBuffer), typeof(UniversalCameraData), typeof(UniversalLightData), typeof(UniversalShadowData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DeferredLights), Member = "RenderStencilDirectionalLights", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RasterCommandBuffer), typeof(bool), typeof(UniversalLightData), typeof(UniversalShadowData), typeof(Unity.Collections.NativeArray`1<UnityEngine.Rendering.VisibleLight>), typeof(bool), typeof(bool), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DeferredLights), Member = "RenderSSAOBeforeShading", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RasterCommandBuffer)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DeferredLights), Member = "RenderFog", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RasterCommandBuffer), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(Mesh), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(Mesh), Member = "set_indexFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IndexFormat)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Mesh), Member = "set_vertices", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Mesh), Member = "set_triangles", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[])}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	private static Mesh CreateFullscreenMesh() { }

	[CalledBy(Type = typeof(DeferredLights), Member = "ResolveMixedLightingMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UniversalLightData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DeferredLights), Member = "DisableFramebufferFetchInput", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UniversalRenderPipeline), Member = "get_asset", ReturnType = typeof(UniversalRenderPipelineAsset))]
	[Calls(Type = typeof(RTHandle), Member = "Release", ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(RenderTargetIdentifier))]
	[Calls(Type = typeof(RTHandles), Member = "Alloc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTargetIdentifier), typeof(string)}, ReturnType = typeof(RTHandle))]
	[Calls(Type = typeof(DeferredLights), Member = "GetGBufferFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(GraphicsFormat))]
	[CallsUnknownMethods(Count = 14)]
	[ContainsUnimplementedInstructions]
	internal void CreateGbufferResources() { }

	[CalledBy(Type = typeof(DeferredLights), Member = "RenderStencilSpotLights", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RasterCommandBuffer), typeof(bool), typeof(UniversalLightData), typeof(UniversalShadowData), typeof(Unity.Collections.NativeArray`1<UnityEngine.Rendering.VisibleLight>), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(RuntimeFieldHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Mesh), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(Mesh), Member = "set_indexFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IndexFormat)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Mesh), Member = "set_vertices", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Mesh), Member = "set_triangles", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[])}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	private static Mesh CreateHemisphereMesh() { }

	[CalledBy(Type = typeof(DeferredLights), Member = "RenderStencilPointLights", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RasterCommandBuffer), typeof(bool), typeof(UniversalLightData), typeof(UniversalShadowData), typeof(Unity.Collections.NativeArray`1<UnityEngine.Rendering.VisibleLight>), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(RuntimeFieldHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Mesh), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(Mesh), Member = "set_indexFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IndexFormat)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Mesh), Member = "set_vertices", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Mesh), Member = "set_triangles", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[])}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	private static Mesh CreateSphereMesh() { }

	[CalledBy(Type = typeof(UniversalRenderer), Member = "Setup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), typeof(RenderingData&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(DeferredLights), Member = "CreateGbufferResources", ReturnType = typeof(void))]
	internal void DisableFramebufferFetchInput() { }

	[CalledBy(Type = "UnityEngine.Rendering.Universal.Internal.DeferredPass+<>c", Member = "<Render>b__5_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.Internal.DeferredPass+PassData", typeof(RasterGraphContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DeferredPass), Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), typeof(RenderingData&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(DeferredLights), Member = "InitStencilDeferredMaterial", ReturnType = typeof(void))]
	[Calls(Type = typeof(TextureHandle), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextureHandle)}, ReturnType = typeof(Texture))]
	[Calls(Type = typeof(DeferredLights), Member = "GetScreenToWorldMatrix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UniversalCameraData)}, ReturnType = typeof(Matrix4x4[]))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DeferredLights), Member = "CreateFullscreenMesh", ReturnType = typeof(Mesh))]
	[Calls(Type = typeof(DeferredLights), Member = "RenderStencilLights", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RasterCommandBuffer), typeof(UniversalLightData), typeof(UniversalShadowData), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Camera), Member = "get_orthographic", ReturnType = typeof(bool))]
	[Calls(Type = typeof(DeferredLights), Member = "RenderFog", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RasterCommandBuffer), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ShadowUtils), Member = "SetSoftShadowQualityShaderKeywords", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RasterCommandBuffer), typeof(UniversalShadowData)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallsUnknownMethods(Count = 10)]
	[ContainsUnimplementedInstructions]
	internal void ExecuteDeferredPass(RasterCommandBuffer cmd, UniversalCameraData cameraData, UniversalLightData lightData, UniversalShadowData shadowData) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	internal bool get_AccurateGbufferNormals() { }

	[CallerCount(Count = 10)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	internal RTHandle[] get_DeferredInputAttachments() { }

	[CallerCount(Count = 16)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	internal Boolean[] get_DeferredInputIsTransient() { }

	[CallerCount(Count = 10)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	internal RTHandle get_DepthAttachment() { }

	[CallerCount(Count = 9)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	internal RTHandle get_DepthAttachmentHandle() { }

	[CallerCount(Count = 84)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	internal RTHandle get_DepthCopyTexture() { }

	[CallerCount(Count = 182)]
	[DeduplicatedMethod]
	internal int get_GBufferAlbedoIndex() { }

	[CallerCount(Count = 62)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	internal RTHandle[] get_GbufferAttachments() { }

	[CalledBy(Type = typeof(DecalGBufferRenderPass), Member = "Configure", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(RenderTextureDescriptor)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GBufferPass), Member = "Configure", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(RenderTextureDescriptor)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	internal int get_GbufferDepthIndex() { }

	[CallerCount(Count = 22)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	internal GraphicsFormat[] get_GbufferFormats() { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	internal int get_GBufferInputAttachmentCount() { }

	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	internal int get_GBufferLightingIndex() { }

	[CallerCount(Count = 8)]
	[DeduplicatedMethod]
	internal int get_GBufferNormalSmoothnessIndex() { }

	[CalledBy(Type = typeof(DecalGBufferRenderPass), Member = "Configure", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(RenderTextureDescriptor)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalRenderer), Member = "Setup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), typeof(RenderingData&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalRenderer), Member = "CreateRenderingLayersTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(RenderTextureDescriptor)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DeferredLights), Member = "GetGBufferFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(GraphicsFormat))]
	[CalledBy(Type = typeof(DeferredLights), Member = "UpdateDeferredInputAttachments", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GBufferPass), Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(ContextContainer), typeof(TextureHandle), typeof(TextureHandle), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(UniversalRenderPipeline), Member = "get_asset", ReturnType = typeof(UniversalRenderPipelineAsset))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	internal int get_GBufferRenderingLayers() { }

	[CalledBy(Type = typeof(DeferredLights), Member = "GetGBufferFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(GraphicsFormat))]
	[CalledBy(Type = typeof(DeferredLights), Member = "UpdateDeferredInputAttachments", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UniversalRenderPipeline), Member = "get_asset", ReturnType = typeof(UniversalRenderPipelineAsset))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	internal int get_GBufferShadowMask() { }

	[CalledBy(Type = typeof(DeferredLights), Member = "IsRuntimeSupportedThisFrame", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(GBufferPass), Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(ContextContainer), typeof(TextureHandle), typeof(TextureHandle), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UniversalRenderPipeline), Member = "get_asset", ReturnType = typeof(UniversalRenderPipelineAsset))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	internal int get_GBufferSliceCount() { }

	[CallerCount(Count = 9)]
	[DeduplicatedMethod]
	internal int get_GBufferSpecularMetallicIndex() { }

	[CallerCount(Count = 12)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	internal TextureHandle[] get_GbufferTextureHandles() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	internal bool get_HasDepthPrepass() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	internal bool get_HasNormalPrepass() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	internal bool get_HasRenderingLayerPrepass() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	internal bool get_IsOverlay() { }

	[CallerCount(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	internal MixedLightingSetup get_MixedLightingSetup() { }

	[CallerCount(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	internal int get_RenderHeight() { }

	[CallerCount(Count = 94)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	internal MaskSize get_RenderingLayerMaskSize() { }

	[CallerCount(Count = 9)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	internal int get_RenderWidth() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	internal bool get_UseDecalLayers() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	internal bool get_UseFramebufferFetch() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	internal bool get_UseJobSystem() { }

	[CalledBy(Type = typeof(GBufferPass), Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(ContextContainer), typeof(TextureHandle), typeof(TextureHandle), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UniversalRenderPipeline), Member = "get_asset", ReturnType = typeof(UniversalRenderPipelineAsset))]
	[CallsUnknownMethods(Count = 1)]
	internal bool get_UseLightLayers() { }

	[CalledBy(Type = typeof(UniversalRenderer), Member = "Setup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), typeof(RenderingData&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalRenderer), Member = "CreateRenderingLayersTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(RenderTextureDescriptor)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DeferredLights), Member = "UpdateDeferredInputAttachments", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.Internal.GBufferPass+<>c", Member = "<Render>b__21_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.Internal.GBufferPass+PassData", typeof(RasterGraphContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GBufferPass), Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), typeof(RenderingData&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GBufferPass), Member = "ExecutePass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RasterCommandBuffer), "UnityEngine.Rendering.Universal.Internal.GBufferPass+PassData", typeof(RendererList), typeof(RendererList)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GBufferPass), Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(ContextContainer), typeof(TextureHandle), typeof(TextureHandle), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(UniversalRenderPipeline), Member = "get_asset", ReturnType = typeof(UniversalRenderPipelineAsset))]
	[CallsUnknownMethods(Count = 1)]
	internal bool get_UseRenderingLayers() { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	internal bool get_UseShadowMask() { }

	[CalledBy(Type = typeof(UniversalRenderer), Member = "Setup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), typeof(RenderingData&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalRenderer), Member = "CreateCameraNormalsTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(RenderTextureDescriptor)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalRenderer), Member = "CreateRenderingLayersTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(RenderTextureDescriptor)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DeferredLights), Member = "ReAllocateGBufferIfNeeded", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTextureDescriptor), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DeferredLights), Member = "CreateGbufferResources", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GBufferPass), Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(ContextContainer), typeof(TextureHandle), typeof(TextureHandle), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(DeferredLights), Member = "get_GBufferShadowMask", ReturnType = typeof(int))]
	[Calls(Type = typeof(DeferredLights), Member = "get_GBufferRenderingLayers", ReturnType = typeof(int))]
	[Calls(Type = typeof(RenderingLayerUtils), Member = "GetFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MaskSize)}, ReturnType = typeof(GraphicsFormat))]
	[Calls(Type = typeof(DepthNormalOnlyPass), Member = "GetGraphicsFormat", ReturnType = typeof(GraphicsFormat))]
	[Calls(Type = typeof(QualitySettings), Member = "get_activeColorSpace", ReturnType = typeof(ColorSpace))]
	internal GraphicsFormat GetGBufferFormat(int index) { }

	[CalledBy(Type = typeof(DeferredLights), Member = "ExecuteDeferredPass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RasterCommandBuffer), typeof(UniversalCameraData), typeof(UniversalLightData), typeof(UniversalShadowData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DeferredLights), Member = "SetupMatrixConstants", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RasterCommandBuffer), typeof(UniversalCameraData)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(XRPass), Member = "get_enabled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(XRPass), Member = "get_singlePassEnabled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Matrix4x4), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector4), typeof(Vector4), typeof(Vector4), typeof(Vector4)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Matrix4x4), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Matrix4x4), typeof(Matrix4x4)}, ReturnType = typeof(Matrix4x4))]
	[Calls(Type = typeof(UniversalCameraData), Member = "GetViewMatrix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Matrix4x4))]
	[Calls(Type = typeof(UniversalCameraData), Member = "GetGPUProjectionMatrix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(int)}, ReturnType = typeof(Matrix4x4))]
	[Calls(Type = typeof(Matrix4x4), Member = "Inverse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Matrix4x4)}, ReturnType = typeof(Matrix4x4))]
	[CallsUnknownMethods(Count = 2)]
	internal Matrix4x4[] GetScreenToWorldMatrix(UniversalCameraData cameraData) { }

	[CalledBy(Type = typeof(DeferredLights), Member = "RenderStencilLights", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RasterCommandBuffer), typeof(UniversalLightData), typeof(UniversalShadowData), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[ContainsUnimplementedInstructions]
	private bool HasStencilLightsOfType(LightType type) { }

	[CalledBy(Type = typeof(DeferredLights), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InitParams), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DeferredLights), Member = "ExecuteDeferredPass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RasterCommandBuffer), typeof(UniversalCameraData), typeof(UniversalLightData), typeof(UniversalShadowData)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Material), Member = "FindPass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 18)]
	[CallsUnknownMethods(Count = 2)]
	private void InitStencilDeferredMaterial() { }

	[CalledBy(Type = typeof(UniversalRenderer), Member = "get_renderingModeActual", ReturnType = typeof(RenderingMode))]
	[CalledBy(Type = typeof(UniversalRenderer), Member = "Setup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), typeof(RenderingData&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(DeferredLights), Member = "get_GBufferSliceCount", ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	internal bool IsRuntimeSupportedThisFrame() { }

	[CalledBy(Type = typeof(DeferredPass), Member = "OnCameraCleanup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CommandBuffer), Member = "SetKeyword", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GlobalKeyword&), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NativeArray`1), Member = "Dispose", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void OnCameraCleanup(CommandBuffer cmd) { }

	[CalledBy(Type = typeof(GBufferPass), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderPassEvent), typeof(RenderQueueRange), typeof(LayerMask), typeof(StencilState), typeof(int), typeof(DeferredLights)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(StencilState), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(byte), typeof(byte), typeof(CompareFunction), typeof(StencilOp), typeof(StencilOp), typeof(StencilOp), typeof(CompareFunction), typeof(StencilOp), typeof(StencilOp), typeof(StencilOp)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StencilState), Member = "get_writeMask", ReturnType = typeof(byte))]
	[Calls(Type = typeof(StencilState), Member = "get_readMask", ReturnType = typeof(byte))]
	[Calls(Type = typeof(StencilState), Member = "get_zFailOperationBack", ReturnType = typeof(StencilOp))]
	[Calls(Type = typeof(StencilState), Member = "get_failOperationBack", ReturnType = typeof(StencilOp))]
	[Calls(Type = typeof(StencilState), Member = "get_passOperationBack", ReturnType = typeof(StencilOp))]
	[Calls(Type = typeof(StencilState), Member = "get_zFailOperationFront", ReturnType = typeof(StencilOp))]
	[Calls(Type = typeof(StencilState), Member = "get_failOperationFront", ReturnType = typeof(StencilOp))]
	[Calls(Type = typeof(StencilState), Member = "get_passOperationFront", ReturnType = typeof(StencilOp))]
	[Calls(Type = typeof(StencilState), Member = "get_compareFunctionBack", ReturnType = typeof(CompareFunction))]
	[Calls(Type = typeof(StencilState), Member = "get_compareFunctionFront", ReturnType = typeof(CompareFunction))]
	[Calls(Type = typeof(StencilState), Member = "get_enabled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(RenderStateBlock), Member = "get_stencilState", ReturnType = typeof(StencilState))]
	[Calls(Type = typeof(RenderStateBlock), Member = "set_stencilState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StencilState)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	internal static RenderStateBlock OverwriteStencil(RenderStateBlock block, int stencilWriteMask, int stencilRef) { }

	[CalledBy(Type = typeof(UniversalRenderer), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UniversalRendererData)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(StencilState), Member = "get_enabled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(StencilState), Member = "get_compareFunctionFront", ReturnType = typeof(CompareFunction))]
	[Calls(Type = typeof(StencilState), Member = "get_compareFunctionBack", ReturnType = typeof(CompareFunction))]
	[Calls(Type = typeof(StencilState), Member = "get_passOperationFront", ReturnType = typeof(StencilOp))]
	[Calls(Type = typeof(StencilState), Member = "get_failOperationFront", ReturnType = typeof(StencilOp))]
	[Calls(Type = typeof(StencilState), Member = "get_zFailOperationFront", ReturnType = typeof(StencilOp))]
	[Calls(Type = typeof(StencilState), Member = "get_passOperationBack", ReturnType = typeof(StencilOp))]
	[Calls(Type = typeof(StencilState), Member = "get_failOperationBack", ReturnType = typeof(StencilOp))]
	[Calls(Type = typeof(StencilState), Member = "get_zFailOperationBack", ReturnType = typeof(StencilOp))]
	[Calls(Type = typeof(StencilState), Member = "get_readMask", ReturnType = typeof(byte))]
	[Calls(Type = typeof(StencilState), Member = "get_writeMask", ReturnType = typeof(byte))]
	[Calls(Type = typeof(StencilState), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(byte), typeof(byte), typeof(CompareFunction), typeof(StencilOp), typeof(StencilOp), typeof(StencilOp), typeof(CompareFunction), typeof(StencilOp), typeof(StencilOp), typeof(StencilOp)}, ReturnType = typeof(void))]
	internal static StencilState OverwriteStencil(StencilState s, int stencilWriteMask) { }

	[CalledBy(Type = typeof(DeferredLights), Member = "SetupLights", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(UniversalCameraData), typeof(Vector2Int), typeof(UniversalLightData), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(NativeArray`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Allocator), typeof(NativeArrayOptions)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NativeArray`1), Member = "Dispose", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 8)]
	private void PrecomputeLights(out NativeArray<UInt16>& stencilVisLights, out NativeArray<UInt16>& stencilVisLightOffsets, ref NativeArray<VisibleLight>& visibleLights, bool hasAdditionalLights) { }

	[CalledBy(Type = typeof(UniversalRenderer), Member = "Setup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), typeof(RenderingData&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GBufferPass), Member = "Configure", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(RenderTextureDescriptor)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(RTHandle), Member = "GetInstanceID", ReturnType = typeof(int))]
	[Calls(Type = typeof(DeferredLights), Member = "GetGBufferFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(GraphicsFormat))]
	[Calls(Type = typeof(RenderTextureDescriptor), Member = "set_graphicsFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GraphicsFormat)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderingUtils), Member = "ReAllocateHandleIfNeeded", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RTHandle&), typeof(RenderTextureDescriptor&), typeof(FilterMode), typeof(TextureWrapMode), typeof(int), typeof(float), typeof(string)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 6)]
	internal void ReAllocateGBufferIfNeeded(RenderTextureDescriptor gbufferSlice, int gbufferIndex) { }

	[CalledBy(Type = typeof(GBufferPass), Member = "Dispose", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(RTHandle), Member = "Release", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	internal void ReleaseGbufferResources() { }

	[CalledBy(Type = typeof(DeferredLights), Member = "ExecuteDeferredPass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RasterCommandBuffer), typeof(UniversalCameraData), typeof(UniversalLightData), typeof(UniversalShadowData)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(RenderSettings), Member = "get_fog", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DeferredLights), Member = "CreateFullscreenMesh", ReturnType = typeof(Mesh))]
	[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 7)]
	private void RenderFog(RasterCommandBuffer cmd, bool isOrthographic) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DeferredLights), Member = "CreateFullscreenMesh", ReturnType = typeof(Mesh))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private void RenderSSAOBeforeShading(RasterCommandBuffer cmd) { }

	[CalledBy(Type = typeof(DeferredLights), Member = "RenderStencilLights", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RasterCommandBuffer), typeof(UniversalLightData), typeof(UniversalShadowData), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(LightExtensions), Member = "GetUniversalAdditionalLightData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Light)}, ReturnType = typeof(UniversalAdditionalLightData))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DeferredLights), Member = "CreateFullscreenMesh", ReturnType = typeof(Mesh))]
	[Calls(Type = typeof(VisibleLight), Member = "get_light", ReturnType = typeof(Light))]
	[Calls(Type = typeof(UniversalRenderPipeline), Member = "InitializeLightConstants_Common", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Unity.Collections.NativeArray`1<UnityEngine.Rendering.VisibleLight>), typeof(int), typeof(Vector4&), typeof(Vector4&), typeof(Vector4&), typeof(Vector4&), typeof(Vector4&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Light), Member = "get_bakingOutput", ReturnType = typeof(LightBakingOutput))]
	[Calls(Type = typeof(RenderingLayerUtils), Member = "ToValidRenderingLayers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(uint))]
	[Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Light), Member = "get_shadows", ReturnType = typeof(LightShadows))]
	[Calls(Type = typeof(AdditionalLightsShadowCasterPass), Member = "GetShadowLightIndexFromLightIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(LightCookieManager), Member = "GetLightCookieShaderDataIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ShadowUtils), Member = "SetPerLightSoftShadowKeyword", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RasterCommandBuffer), typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 16)]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	private void RenderStencilDirectionalLights(RasterCommandBuffer cmd, bool stripShadowsOffVariants, UniversalLightData lightData, UniversalShadowData shadowData, NativeArray<VisibleLight> visibleLights, bool hasAdditionalLightPass, bool hasLightCookieManager, int mainLightIndex) { }

	[CalledBy(Type = typeof(DeferredLights), Member = "ExecuteDeferredPass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RasterCommandBuffer), typeof(UniversalCameraData), typeof(UniversalLightData), typeof(UniversalShadowData)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DeferredLights), Member = "HasStencilLightsOfType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LightType)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DeferredLights), Member = "RenderStencilDirectionalLights", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RasterCommandBuffer), typeof(bool), typeof(UniversalLightData), typeof(UniversalShadowData), typeof(Unity.Collections.NativeArray`1<UnityEngine.Rendering.VisibleLight>), typeof(bool), typeof(bool), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DeferredLights), Member = "RenderStencilPointLights", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RasterCommandBuffer), typeof(bool), typeof(UniversalLightData), typeof(UniversalShadowData), typeof(Unity.Collections.NativeArray`1<UnityEngine.Rendering.VisibleLight>), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DeferredLights), Member = "RenderStencilSpotLights", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RasterCommandBuffer), typeof(bool), typeof(UniversalLightData), typeof(UniversalShadowData), typeof(Unity.Collections.NativeArray`1<UnityEngine.Rendering.VisibleLight>), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(Debug), Member = "LogErrorFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 12)]
	[ContainsUnimplementedInstructions]
	private void RenderStencilLights(RasterCommandBuffer cmd, UniversalLightData lightData, UniversalShadowData shadowData, bool stripShadowsOffVariants) { }

	[CalledBy(Type = typeof(DeferredLights), Member = "RenderStencilLights", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RasterCommandBuffer), typeof(UniversalLightData), typeof(UniversalShadowData), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UniversalRenderPipeline), Member = "InitializeLightConstants_Common", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Unity.Collections.NativeArray`1<UnityEngine.Rendering.VisibleLight>), typeof(int), typeof(Vector4&), typeof(Vector4&), typeof(Vector4&), typeof(Vector4&), typeof(Vector4&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Light), Member = "get_shadows", ReturnType = typeof(LightShadows))]
	[Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(AdditionalLightsShadowCasterPass), Member = "GetShadowLightIndexFromLightIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Light), Member = "get_bakingOutput", ReturnType = typeof(LightBakingOutput))]
	[Calls(Type = typeof(RenderingLayerUtils), Member = "ToValidRenderingLayers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(uint))]
	[Calls(Type = typeof(LightExtensions), Member = "GetUniversalAdditionalLightData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Light)}, ReturnType = typeof(UniversalAdditionalLightData))]
	[Calls(Type = typeof(Matrix4x4), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector4), typeof(Vector4), typeof(Vector4), typeof(Vector4)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisibleLight), Member = "get_range", ReturnType = typeof(float))]
	[Calls(Type = typeof(Matrix4x4), Member = "GetColumn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Vector4))]
	[Calls(Type = typeof(VisibleLight), Member = "get_localToWorldMatrix", ReturnType = typeof(Matrix4x4))]
	[Calls(Type = typeof(VisibleLight), Member = "get_light", ReturnType = typeof(Light))]
	[Calls(Type = typeof(DeferredLights), Member = "CreateSphereMesh", ReturnType = typeof(Mesh))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ShadowUtils), Member = "SetPerLightSoftShadowKeyword", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RasterCommandBuffer), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(LightCookieManager), Member = "GetLightCookieShaderDataIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 17)]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	private void RenderStencilPointLights(RasterCommandBuffer cmd, bool stripShadowsOffVariants, UniversalLightData lightData, UniversalShadowData shadowData, NativeArray<VisibleLight> visibleLights, bool hasAdditionalLightPass, bool hasLightCookieManager) { }

	[CalledBy(Type = typeof(DeferredLights), Member = "RenderStencilLights", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RasterCommandBuffer), typeof(UniversalLightData), typeof(UniversalShadowData), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(RenderingLayerUtils), Member = "ToValidRenderingLayers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(uint))]
	[Calls(Type = typeof(LightCookieManager), Member = "GetLightCookieShaderDataIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ShadowUtils), Member = "SetPerLightSoftShadowKeyword", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RasterCommandBuffer), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Light), Member = "get_shadows", ReturnType = typeof(LightShadows))]
	[Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(AdditionalLightsShadowCasterPass), Member = "GetShadowLightIndexFromLightIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Light), Member = "get_bakingOutput", ReturnType = typeof(LightBakingOutput))]
	[Calls(Type = typeof(LightExtensions), Member = "GetUniversalAdditionalLightData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Light)}, ReturnType = typeof(UniversalAdditionalLightData))]
	[Calls(Type = typeof(VisibleLight), Member = "get_range", ReturnType = typeof(float))]
	[Calls(Type = typeof(UniversalRenderPipeline), Member = "InitializeLightConstants_Common", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Unity.Collections.NativeArray`1<UnityEngine.Rendering.VisibleLight>), typeof(int), typeof(Vector4&), typeof(Vector4&), typeof(Vector4&), typeof(Vector4&), typeof(Vector4&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisibleLight), Member = "get_spotAngle", ReturnType = typeof(float))]
	[Calls(Type = typeof(VisibleLight), Member = "get_light", ReturnType = typeof(Light))]
	[Calls(Type = typeof(DeferredLights), Member = "CreateHemisphereMesh", ReturnType = typeof(Mesh))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisibleLight), Member = "get_localToWorldMatrix", ReturnType = typeof(Matrix4x4))]
	[CallsDeduplicatedMethods(Count = 21)]
	[CallsUnknownMethods(Count = 5)]
	[ContainsUnimplementedInstructions]
	private void RenderStencilSpotLights(RasterCommandBuffer cmd, bool stripShadowsOffVariants, UniversalLightData lightData, UniversalShadowData shadowData, NativeArray<VisibleLight> visibleLights, bool hasAdditionalLightPass, bool hasLightCookieManager) { }

	[CalledBy(Type = typeof(UniversalRenderer), Member = "Setup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), typeof(RenderingData&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalRenderer), Member = "OnMainRendering", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(ScriptableRenderContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(VisibleLight), Member = "get_light", ReturnType = typeof(Light))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Light), Member = "get_bakingOutput", ReturnType = typeof(LightBakingOutput))]
	[Calls(Type = typeof(Light), Member = "get_shadows", ReturnType = typeof(LightShadows))]
	[Calls(Type = typeof(DeferredLights), Member = "CreateGbufferResources", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	internal void ResolveMixedLightingMode(UniversalLightData lightData) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	internal void set_AccurateGbufferNormals(bool value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	internal void set_DeferredInputAttachments(RTHandle[] value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	internal void set_DeferredInputIsTransient(Boolean[] value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	internal void set_DepthAttachment(RTHandle value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	internal void set_DepthAttachmentHandle(RTHandle value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	internal void set_DepthCopyTexture(RTHandle value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	internal void set_GbufferAttachments(RTHandle[] value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	internal void set_GbufferFormats(GraphicsFormat[] value) { }

	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	internal void set_GbufferTextureHandles(TextureHandle[] value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	internal void set_HasDepthPrepass(bool value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	internal void set_HasNormalPrepass(bool value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	internal void set_HasRenderingLayerPrepass(bool value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	internal void set_IsOverlay(bool value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	internal void set_MixedLightingSetup(MixedLightingSetup value) { }

	[CallerCount(Count = 5)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	internal void set_RenderHeight(int value) { }

	[CallerCount(Count = 7)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	internal void set_RenderingLayerMaskSize(MaskSize value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	internal void set_RenderWidth(int value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	internal void set_UseDecalLayers(bool value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	internal void set_UseFramebufferFetch(bool value) { }

	[CallerCount(Count = 3)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	internal void set_UseJobSystem(bool value) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void SetAdditionalLightsShadowsKeyword(ref RasterCommandBuffer cmd, bool stripShadowsOffVariants, bool additionalLightShadowsEnabled, bool hasDeferredShadows, bool shouldOverride, ref bool lastShadowsKeyword) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LightCookieManager), Member = "GetLightCookieShaderDataIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	private void SetLightCookiesKeyword(RasterCommandBuffer cmd, int visLightIndex, bool hasLightCookieManager, bool shouldOverride, ref bool lastLightCookieState, ref int lastCookieLightIndex) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LightExtensions), Member = "GetUniversalAdditionalLightData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Light)}, ReturnType = typeof(UniversalAdditionalLightData))]
	[Calls(Type = typeof(RenderingLayerUtils), Member = "ToValidRenderingLayers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(uint))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void SetRenderingLayersMask(RasterCommandBuffer cmd, Light light, int shaderPropertyID) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Light), Member = "get_shadows", ReturnType = typeof(LightShadows))]
	[Calls(Type = typeof(ShadowUtils), Member = "SetPerLightSoftShadowKeyword", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RasterCommandBuffer), typeof(bool)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private void SetSoftShadowsKeyword(RasterCommandBuffer cmd, UniversalShadowData shadowData, Light light, bool hasDeferredShadows, bool shouldOverride, ref bool lastHasSoftShadow) { }

	[CalledBy(Type = typeof(UniversalRenderer), Member = "EnqueueDeferred", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTextureDescriptor), typeof(bool), typeof(bool), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UniversalRenderPipeline), Member = "get_asset", ReturnType = typeof(UniversalRenderPipelineAsset))]
	[CallsUnknownMethods(Count = 16)]
	[ContainsUnimplementedInstructions]
	public void Setup(AdditionalLightsShadowCasterPass additionalLightsShadowCasterPass, bool hasDepthPrepass, bool hasNormalPrepass, bool hasRenderingLayerPrepass, RTHandle depthCopyTexture, RTHandle depthAttachment, RTHandle colorAttachment) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	internal void Setup(AdditionalLightsShadowCasterPass additionalLightsShadowCasterPass) { }

	[CalledBy(Type = typeof(UniversalRenderer), Member = "SetupLights", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), typeof(RenderingData&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<>c), Member = "<SetupRenderGraphLights>b__139_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SetupLightPassData), typeof(UnsafeGraphContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Camera), Member = "get_allowDynamicResolution", ReturnType = typeof(bool))]
	[Calls(Type = typeof(ScalableBufferManager), Member = "get_widthScaleFactor", ReturnType = typeof(float))]
	[Calls(Type = typeof(ScalableBufferManager), Member = "get_heightScaleFactor", ReturnType = typeof(float))]
	[Calls(Type = typeof(DeferredLights), Member = "PrecomputeLights", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NativeArray`1<UInt16>&), typeof(NativeArray`1<UInt16>&), typeof(NativeArray`1<VisibleLight>&), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DeferredLights), Member = "SetupMainLightConstants", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(UniversalLightData)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CommandBuffer), Member = "SetKeyword", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GlobalKeyword&), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(QualitySettings), Member = "get_shadowmaskMode", ReturnType = typeof(ShadowmaskMode))]
	[Calls(Type = typeof(Camera), Member = "get_cameraType", ReturnType = typeof(CameraType))]
	[Calls(Type = typeof(UniversalRenderPipeline), Member = "get_asset", ReturnType = typeof(UniversalRenderPipelineAsset))]
	[Calls(Type = typeof(RenderingLayerUtils), Member = "SetupProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(MaskSize)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 6)]
	[ContainsUnimplementedInstructions]
	internal void SetupLights(CommandBuffer cmd, UniversalCameraData cameraData, Vector2Int cameraTargetSizeCopy, UniversalLightData lightData, bool isRenderGraph = false) { }

	[CalledBy(Type = typeof(DeferredLights), Member = "SetupLights", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(UniversalCameraData), typeof(Vector2Int), typeof(UniversalLightData), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DeferredLights), Member = "SetupShaderLightConstants", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(UniversalLightData)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UniversalRenderPipeline), Member = "InitializeLightConstants_Common", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Unity.Collections.NativeArray`1<UnityEngine.Rendering.VisibleLight>), typeof(int), typeof(Vector4&), typeof(Vector4&), typeof(Vector4&), typeof(Vector4&), typeof(Vector4&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisibleLight), Member = "get_light", ReturnType = typeof(Light))]
	[Calls(Type = typeof(LightExtensions), Member = "GetUniversalAdditionalLightData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Light)}, ReturnType = typeof(UniversalAdditionalLightData))]
	[Calls(Type = typeof(RenderingLayerUtils), Member = "ToValidRenderingLayers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(uint))]
	[Calls(Type = typeof(CommandBuffer), Member = "SetGlobalVector", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Vector4)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void SetupMainLightConstants(CommandBuffer cmd, UniversalLightData lightData) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DeferredLights), Member = "GetScreenToWorldMatrix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UniversalCameraData)}, ReturnType = typeof(Matrix4x4[]))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void SetupMatrixConstants(RasterCommandBuffer cmd, UniversalCameraData cameraData) { }

	[CalledBy(Type = typeof(UniversalRenderer), Member = "SetupRenderGraphLights", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(UniversalRenderingData), typeof(UniversalCameraData), typeof(UniversalLightData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalRenderer), Member = "OnRecordRenderGraph", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(ScriptableRenderContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(RenderGraph), Member = "AddUnsafePass", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"PassData"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "PassData&", typeof(ProfilingSampler), typeof(string), typeof(int)}, ReturnType = typeof(IUnsafeRenderGraphBuilder))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 18)]
	internal void SetupRenderGraphLights(RenderGraph renderGraph, UniversalCameraData cameraData, UniversalLightData lightData) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DeferredLights), Member = "SetupMainLightConstants", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(UniversalLightData)}, ReturnType = typeof(void))]
	private void SetupShaderLightConstants(CommandBuffer cmd, UniversalLightData lightData) { }

	[CalledBy(Type = typeof(GBufferPass), Member = "Configure", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(RenderTextureDescriptor)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UniversalRenderPipeline), Member = "get_asset", ReturnType = typeof(UniversalRenderPipelineAsset))]
	[Calls(Type = typeof(DeferredLights), Member = "get_GBufferShadowMask", ReturnType = typeof(int))]
	[Calls(Type = typeof(DeferredLights), Member = "get_GBufferRenderingLayers", ReturnType = typeof(int))]
	[Calls(Type = typeof(DeferredLights), Member = "get_UseRenderingLayers", ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 32)]
	internal void UpdateDeferredInputAttachments() { }

}

