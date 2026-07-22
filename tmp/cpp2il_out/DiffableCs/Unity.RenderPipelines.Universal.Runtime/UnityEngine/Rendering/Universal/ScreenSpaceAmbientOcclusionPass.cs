namespace UnityEngine.Rendering.Universal;

internal class ScreenSpaceAmbientOcclusionPass : ScriptableRenderPass
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static BaseRenderFunc<SSAOPassData, UnsafeGraphContext> <>9__52_0; //Field offset: 0x8

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
		[Calls(Type = typeof(PostProcessUtils), Member = "SetSourceSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RasterCommandBuffer), typeof(RTHandle)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(TextureHandle), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextureHandle)}, ReturnType = typeof(Texture))]
		[Calls(Type = typeof(Blitter), Member = "BlitCameraTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(RTHandle), typeof(RTHandle), typeof(RenderBufferLoadAction), typeof(RenderBufferStoreAction), typeof(Material), typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 7)]
		[ContainsUnimplementedInstructions]
		internal void <RecordRenderGraph>b__52_0(SSAOPassData data, UnsafeGraphContext rgContext) { }

	}

	private enum BlurTypes
	{
		Bilateral = 0,
		Gaussian = 1,
		Kawase = 2,
	}

	private enum ShaderPasses
	{
		AmbientOcclusion = 0,
		BilateralBlurHorizontal = 1,
		BilateralBlurVertical = 2,
		BilateralBlurFinal = 3,
		BilateralAfterOpaque = 4,
		GaussianBlurHorizontal = 5,
		GaussianBlurVertical = 6,
		GaussianAfterOpaque = 7,
		KawaseBlur = 8,
		KawaseAfterOpaque = 9,
	}

	private struct SSAOMaterialParams
	{
		internal bool orthographicCamera; //Field offset: 0x0
		internal bool aoBlueNoise; //Field offset: 0x1
		internal bool aoInterleavedGradient; //Field offset: 0x2
		internal bool sampleCountHigh; //Field offset: 0x3
		internal bool sampleCountMedium; //Field offset: 0x4
		internal bool sampleCountLow; //Field offset: 0x5
		internal bool sourceDepthNormals; //Field offset: 0x6
		internal bool sourceDepthHigh; //Field offset: 0x7
		internal bool sourceDepthMedium; //Field offset: 0x8
		internal bool sourceDepthLow; //Field offset: 0x9
		internal Vector4 ssaoParams; //Field offset: 0xC

		[CalledBy(Type = typeof(ScreenSpaceAmbientOcclusionPass), Member = "SetupKeywordsAndParameters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScreenSpaceAmbientOcclusionSettings&), typeof(UniversalCameraData&)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		internal SSAOMaterialParams(ref ScreenSpaceAmbientOcclusionSettings settings, bool isOrthographic) { }

		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		internal bool Equals(ref SSAOMaterialParams other) { }

	}

	private class SSAOPassData
	{
		internal bool afterOpaque; //Field offset: 0x10
		internal BlurQualityOptions BlurQuality; //Field offset: 0x14
		internal Material material; //Field offset: 0x18
		internal float directLightingStrength; //Field offset: 0x20
		internal TextureHandle cameraColor; //Field offset: 0x24
		internal TextureHandle AOTexture; //Field offset: 0x34
		internal TextureHandle finalTexture; //Field offset: 0x44
		internal TextureHandle blurTexture; //Field offset: 0x54
		internal TextureHandle cameraNormalsTexture; //Field offset: 0x64

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public SSAOPassData() { }

	}

	internal static readonly int s_AmbientOcclusionParamID; //Field offset: 0x0
	private const string k_AmbientOcclusionParamName = "_AmbientOcclusionParam"; //Field offset: 0x0
	private const string k_SSAOTextureName = "_ScreenSpaceOcclusionTexture"; //Field offset: 0x0
	private static readonly int s_SSAOParamsID; //Field offset: 0x4
	private static readonly int s_SSAOBlueNoiseParamsID; //Field offset: 0x8
	private static readonly int s_BlueNoiseTextureID; //Field offset: 0xC
	private static readonly int s_SSAOFinalTextureID; //Field offset: 0x10
	private static readonly int s_CameraViewXExtentID; //Field offset: 0x14
	private static readonly int s_CameraViewYExtentID; //Field offset: 0x18
	private static readonly int s_CameraViewZExtentID; //Field offset: 0x1C
	private static readonly int s_ProjectionParams2ID; //Field offset: 0x20
	private static readonly int s_CameraViewProjectionsID; //Field offset: 0x24
	private static readonly int s_CameraViewTopLeftCornerID; //Field offset: 0x28
	private static readonly int s_CameraDepthTextureID; //Field offset: 0x2C
	private static readonly int s_CameraNormalsTextureID; //Field offset: 0x30
	private static readonly Int32[] m_BilateralTexturesIndices; //Field offset: 0x38
	private static readonly ShaderPasses[] m_BilateralPasses; //Field offset: 0x40
	private static readonly ShaderPasses[] m_BilateralAfterOpaquePasses; //Field offset: 0x48
	private static readonly Int32[] m_GaussianTexturesIndices; //Field offset: 0x50
	private static readonly ShaderPasses[] m_GaussianPasses; //Field offset: 0x58
	private static readonly ShaderPasses[] m_GaussianAfterOpaquePasses; //Field offset: 0x60
	private static readonly Int32[] m_KawaseTexturesIndices; //Field offset: 0x68
	private static readonly ShaderPasses[] m_KawasePasses; //Field offset: 0x70
	private static readonly ShaderPasses[] m_KawaseAfterOpaquePasses; //Field offset: 0x78
	private readonly bool m_SupportsR8RenderTextureFormat; //Field offset: 0xB8
	private int m_BlueNoiseTextureIndex; //Field offset: 0xBC
	private Material m_Material; //Field offset: 0xC0
	private SSAOPassData m_PassData; //Field offset: 0xC8
	private Texture2D[] m_BlueNoiseTextures; //Field offset: 0xD0
	private Vector4[] m_CameraTopLeftCorner; //Field offset: 0xD8
	private Vector4[] m_CameraXExtent; //Field offset: 0xE0
	private Vector4[] m_CameraYExtent; //Field offset: 0xE8
	private Vector4[] m_CameraZExtent; //Field offset: 0xF0
	private RTHandle[] m_SSAOTextures; //Field offset: 0xF8
	private BlurTypes m_BlurType; //Field offset: 0x100
	private Matrix4x4[] m_CameraViewProjections; //Field offset: 0x108
	private ProfilingSampler m_ProfilingSampler; //Field offset: 0x110
	private ScriptableRenderer m_Renderer; //Field offset: 0x118
	private RenderTextureDescriptor m_AOPassDescriptor; //Field offset: 0x120
	private ScreenSpaceAmbientOcclusionSettings m_CurrentSettings; //Field offset: 0x158
	private SSAOMaterialParams m_SSAOParamsPrev; //Field offset: 0x160

	private bool isRendererDeferred
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UniversalRenderer), Member = "get_renderingModeActual", ReturnType = typeof(RenderingMode))]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		private get { } //Length: 139
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Shader), Member = "PropertyToID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(RuntimeFieldHandle)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 11)]
	private static ScreenSpaceAmbientOcclusionPass() { }

	[CalledBy(Type = typeof(ScreenSpaceAmbientOcclusion), Member = "Create", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SystemInfo), Member = "SupportsRenderTextureFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTextureFormat)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ScriptableRenderPass), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(ScreenSpaceAmbientOcclusionSettings), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 9)]
	internal ScreenSpaceAmbientOcclusionPass() { }

	[CalledBy(Type = typeof(ScreenSpaceAmbientOcclusionPass), Member = "RecordRenderGraph", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(ContextContainer)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(RenderTextureDescriptor), Member = "set_colorFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTextureFormat)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UniversalRenderer), Member = "CreateRenderGraphTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(RenderTextureDescriptor), typeof(string), typeof(bool), typeof(FilterMode), typeof(TextureWrapMode)}, ReturnType = typeof(TextureHandle))]
	[Calls(Type = typeof(UniversalResourceData), Member = "get_activeColorTexture", ReturnType = typeof(TextureHandle))]
	[Calls(Type = typeof(UniversalResourceData), Member = "set_ssaoTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextureHandle)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private void CreateRenderTextureHandles(RenderGraph renderGraph, UniversalResourceData resourceData, UniversalCameraData cameraData, out TextureHandle aoTexture, out TextureHandle blurTexture, out TextureHandle finalTexture) { }

	[CalledBy(Type = typeof(ScreenSpaceAmbientOcclusion), Member = "Dispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(RTHandle), Member = "Release", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	public void Dispose() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CommandBuffer), Member = "SetFoveatedRenderingMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FoveatedRenderingMode)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CommandBuffer), Member = "SetGlobalVector", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Vector4)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ScreenSpaceAmbientOcclusionPass), Member = "RenderAndSetBaseMap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer&), typeof(RenderingData&), typeof(ScriptableRenderer&), typeof(Material&), typeof(RTHandle&), typeof(RTHandle&), typeof(ShaderPasses)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ScriptableRenderer), Member = "get_cameraDepthTargetHandle", ReturnType = typeof(RTHandle))]
	[Calls(Type = typeof(CameraData), Member = "get_renderer", ReturnType = typeof(ScriptableRenderer&))]
	[Calls(Type = typeof(ScreenSpaceAmbientOcclusionPass), Member = "GetPassOrder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BlurTypes), typeof(bool), typeof(Int32[]&), typeof(ShaderPasses[]&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(XRPass), Member = "get_supportsFoveatedRendering", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CommandBuffer), Member = "SetGlobalTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(RenderTargetIdentifier)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RTHandle), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RTHandle)}, ReturnType = typeof(RenderTargetIdentifier))]
	[Calls(Type = typeof(CommandBuffer), Member = "SetKeyword", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GlobalKeyword&), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderingData), Member = "get_commandBuffer", ReturnType = typeof(CommandBuffer&))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CameraData), Member = "get_xr", ReturnType = typeof(XRPass))]
	[Calls(Type = typeof(Debug), Member = "LogErrorFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 34)]
	[Obsolete("This rendering path is for compatibility mode only (when Render Graph is disabled). Use Render Graph API instead.", False)]
	public virtual void Execute(ScriptableRenderContext context, ref RenderingData renderingData) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UniversalRenderer), Member = "get_renderingModeActual", ReturnType = typeof(RenderingMode))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private bool get_isRendererDeferred() { }

	[CalledBy(Type = typeof(ScreenSpaceAmbientOcclusionPass), Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), typeof(RenderingData&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 7)]
	private static void GetPassOrder(BlurTypes blurType, bool isAfterOpaque, out Int32[] textureIndices, out ShaderPasses[] shaderPasses) { }

	[CalledBy(Type = typeof(ScreenSpaceAmbientOcclusionPass), Member = "OnCameraSetup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(RenderingData&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void InitSSAOPassData(ref SSAOPassData data) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	private static bool IsAfterOpaquePass(ref ShaderPasses pass) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CommandBuffer), Member = "SetKeyword", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GlobalKeyword&), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	public virtual void OnCameraCleanup(CommandBuffer cmd) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ContextContainer), Member = "Get", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(ScreenSpaceAmbientOcclusionPass), Member = "InitSSAOPassData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SSAOPassData&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ScreenSpaceAmbientOcclusionPass), Member = "SetupKeywordsAndParameters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScreenSpaceAmbientOcclusionSettings&), typeof(UniversalCameraData&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CameraData), Member = "get_cameraTargetDescriptor", ReturnType = typeof(RenderTextureDescriptor&))]
	[Calls(Type = typeof(RenderTextureDescriptor), Member = "set_colorFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTextureFormat)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderingUtils), Member = "ReAllocateHandleIfNeeded", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RTHandle&), typeof(RenderTextureDescriptor&), typeof(FilterMode), typeof(TextureWrapMode), typeof(int), typeof(float), typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(PostProcessUtils), Member = "SetSourceSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RasterCommandBuffer), typeof(RTHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ScriptableRenderer), Member = "get_cameraColorTargetHandle", ReturnType = typeof(RTHandle))]
	[Calls(Type = typeof(ScriptableRenderPass), Member = "ConfigureTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RTHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ScriptableRenderPass), Member = "ConfigureClear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ClearFlag), typeof(Color)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	[Obsolete("This rendering path is for compatibility mode only (when Render Graph is disabled). Use Render Graph API instead.", False)]
	public virtual void OnCameraSetup(CommandBuffer cmd, ref RenderingData renderingData) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ContextContainer), Member = "Get", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(ScreenSpaceAmbientOcclusionPass), Member = "CreateRenderTextureHandles", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(UniversalResourceData), typeof(UniversalCameraData), typeof(TextureHandle&), typeof(TextureHandle&), typeof(TextureHandle&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UniversalResourceData), Member = "get_cameraDepthTexture", ReturnType = typeof(TextureHandle))]
	[Calls(Type = typeof(UniversalResourceData), Member = "get_cameraNormalsTexture", ReturnType = typeof(TextureHandle))]
	[Calls(Type = typeof(ScreenSpaceAmbientOcclusionPass), Member = "SetupKeywordsAndParameters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScreenSpaceAmbientOcclusionSettings&), typeof(UniversalCameraData&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderGraph), Member = "AddUnsafePass", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"PassData"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "PassData&", typeof(ProfilingSampler), typeof(string), typeof(int)}, ReturnType = typeof(IUnsafeRenderGraphBuilder))]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallsUnknownMethods(Count = 48)]
	public virtual void RecordRenderGraph(RenderGraph renderGraph, ContextContainer frameData) { }

	[CalledBy(Type = typeof(ScreenSpaceAmbientOcclusionPass), Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), typeof(RenderingData&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ScriptableRenderer), Member = "get_cameraColorTargetHandle", ReturnType = typeof(RTHandle))]
	[Calls(Type = typeof(Blitter), Member = "BlitCameraTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(RTHandle), typeof(RTHandle), typeof(RenderBufferLoadAction), typeof(RenderBufferStoreAction), typeof(Material), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Blitter), Member = "BlitCameraTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(RTHandle), typeof(RTHandle), typeof(Material), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RTHandle), Member = "get_rtHandleProperties", ReturnType = typeof(RTHandleProperties))]
	[Calls(Type = typeof(CoreUtils), Member = "SetRenderTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(RTHandle), typeof(ClearFlag), typeof(int), typeof(CubemapFace), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Blitter), Member = "BlitTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(RenderTargetIdentifier), typeof(Vector4), typeof(Material), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	private static void RenderAndSetBaseMap(ref CommandBuffer cmd, ref RenderingData renderingData, ref ScriptableRenderer renderer, ref Material mat, ref RTHandle baseMap, ref RTHandle target, ShaderPasses pass) { }

	[CalledBy(Type = typeof(ScreenSpaceAmbientOcclusion), Member = "AddRenderPasses", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderer), typeof(RenderingData&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UniversalRenderer), Member = "get_renderingModeActual", ReturnType = typeof(RenderingMode))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 12)]
	[ContainsUnimplementedInstructions]
	internal bool Setup(ref ScreenSpaceAmbientOcclusionSettings featureSettings, ref ScriptableRenderer renderer, ref Material material, ref Texture2D[] blueNoiseTextures) { }

	[CalledBy(Type = typeof(ScreenSpaceAmbientOcclusionPass), Member = "RecordRenderGraph", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(ContextContainer)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScreenSpaceAmbientOcclusionPass), Member = "OnCameraSetup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(RenderingData&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Matrix4x4), Member = "MultiplyPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(SSAOMaterialParams), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScreenSpaceAmbientOcclusionSettings&), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Camera), Member = "get_orthographic", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Random), Member = "get_value", ReturnType = typeof(float))]
	[Calls(Type = typeof(Material), Member = "SetVectorArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Vector4[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Material), Member = "SetMatrixArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Matrix4x4[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Material), Member = "SetVector", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Vector4)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Camera), Member = "get_nearClipPlane", ReturnType = typeof(float))]
	[Calls(Type = typeof(Matrix4x4), Member = "get_inverse", ReturnType = typeof(Matrix4x4))]
	[Calls(Type = typeof(Material), Member = "HasProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Matrix4x4), Member = "SetColumn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Vector4)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Matrix4x4), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Matrix4x4), typeof(Matrix4x4)}, ReturnType = typeof(Matrix4x4))]
	[Calls(Type = typeof(UniversalCameraData), Member = "GetProjectionMatrix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Matrix4x4))]
	[Calls(Type = typeof(UniversalCameraData), Member = "GetViewMatrix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Matrix4x4))]
	[Calls(Type = typeof(XRPass), Member = "get_singlePassEnabled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(XRPass), Member = "get_enabled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CoreUtils), Member = "SetKeyword", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material), typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	private void SetupKeywordsAndParameters(ref ScreenSpaceAmbientOcclusionSettings settings, ref UniversalCameraData cameraData) { }

}

