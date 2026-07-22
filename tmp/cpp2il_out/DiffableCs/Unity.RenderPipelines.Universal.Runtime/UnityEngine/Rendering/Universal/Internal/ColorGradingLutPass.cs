namespace UnityEngine.Rendering.Universal.Internal;

public class ColorGradingLutPass : ScriptableRenderPass
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static BaseRenderFunc<PassData, RasterGraphContext> <>9__14_0; //Field offset: 0x8

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
		[Calls(Type = typeof(ColorGradingLutPass), Member = "ExecutePass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RasterCommandBuffer), "UnityEngine.Rendering.Universal.Internal.ColorGradingLutPass+PassData", typeof(RTHandle)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		internal void <Render>b__14_0(PassData data, RasterGraphContext context) { }

	}

	private class PassData
	{
		internal UniversalCameraData cameraData; //Field offset: 0x10
		internal UniversalPostProcessingData postProcessingData; //Field offset: 0x18
		internal Material lutBuilderLdr; //Field offset: 0x20
		internal Material lutBuilderHdr; //Field offset: 0x28
		internal bool allowColorGradingACESHDR; //Field offset: 0x30
		internal TextureHandle internalLut; //Field offset: 0x34

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public PassData() { }

	}

	private static class ShaderConstants
	{
		public static readonly int _Lut_Params; //Field offset: 0x0
		public static readonly int _ColorBalance; //Field offset: 0x4
		public static readonly int _ColorFilter; //Field offset: 0x8
		public static readonly int _ChannelMixerRed; //Field offset: 0xC
		public static readonly int _ChannelMixerGreen; //Field offset: 0x10
		public static readonly int _ChannelMixerBlue; //Field offset: 0x14
		public static readonly int _HueSatCon; //Field offset: 0x18
		public static readonly int _Lift; //Field offset: 0x1C
		public static readonly int _Gamma; //Field offset: 0x20
		public static readonly int _Gain; //Field offset: 0x24
		public static readonly int _Shadows; //Field offset: 0x28
		public static readonly int _Midtones; //Field offset: 0x2C
		public static readonly int _Highlights; //Field offset: 0x30
		public static readonly int _ShaHiLimits; //Field offset: 0x34
		public static readonly int _SplitShadows; //Field offset: 0x38
		public static readonly int _SplitHighlights; //Field offset: 0x3C
		public static readonly int _CurveMaster; //Field offset: 0x40
		public static readonly int _CurveRed; //Field offset: 0x44
		public static readonly int _CurveGreen; //Field offset: 0x48
		public static readonly int _CurveBlue; //Field offset: 0x4C
		public static readonly int _CurveHueVsHue; //Field offset: 0x50
		public static readonly int _CurveHueVsSat; //Field offset: 0x54
		public static readonly int _CurveLumVsSat; //Field offset: 0x58
		public static readonly int _CurveSatVsSat; //Field offset: 0x5C

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Shader), Member = "PropertyToID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
		private static ShaderConstants() { }

	}

	private readonly Material m_LutBuilderLdr; //Field offset: 0xB8
	private readonly Material m_LutBuilderHdr; //Field offset: 0xC0
	internal readonly GraphicsFormat m_HdrLutFormat; //Field offset: 0xC8
	internal readonly GraphicsFormat m_LdrLutFormat; //Field offset: 0xCC
	private PassData m_PassData; //Field offset: 0xD0
	private RTHandle m_InternalLut; //Field offset: 0xD8
	private bool m_AllowColorGradingACESHDR; //Field offset: 0xE0

	[CalledBy(Type = typeof(PostProcessPasses), Member = "Recreate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PostProcessData), typeof(PostProcessParams&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ScriptableRenderPass), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(ProfilingSampler), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ScriptableRenderPass), Member = "set_profilingSampler", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ProfilingSampler)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ColorGradingLutPass), Member = "<.ctor>g__Load|7_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Shader)}, ReturnType = typeof(Material))]
	[Calls(Type = typeof(SystemInfo), Member = "IsFormatSupported", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GraphicsFormat), typeof(GraphicsFormatUsage)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Graphics), Member = "get_minOpenGLESVersion", ReturnType = typeof(OpenGLESVersion))]
	[Calls(Type = typeof(SystemInfo), Member = "get_graphicsDeviceName", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "StartsWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	public ColorGradingLutPass(RenderPassEvent evt, PostProcessData data) { }

	[CalledBy(Type = typeof(ColorGradingLutPass), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderPassEvent), typeof(PostProcessData)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CoreUtils), Member = "CreateEngineMaterial", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Shader)}, ReturnType = typeof(Material))]
	[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CompilerGenerated]
	internal static Material <.ctor>g__Load|7_0(Shader shader) { }

	[CalledBy(Type = typeof(PostProcessPasses), Member = "Recreate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PostProcessData), typeof(PostProcessParams&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PostProcessPasses), Member = "Dispose", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CoreUtils), Member = "Destroy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(void))]
	public void Cleanup() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PostProcessingData), Member = "get_universalPostProcessingData", ReturnType = typeof(UniversalPostProcessingData))]
	[Calls(Type = typeof(RenderTextureDescriptor), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(GraphicsFormat), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void ConfigureDescriptor(in PostProcessingData postProcessingData, out RenderTextureDescriptor descriptor, out FilterMode filterMode) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RenderTextureDescriptor), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(GraphicsFormat), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void ConfigureDescriptor(in UniversalPostProcessingData postProcessingData, out RenderTextureDescriptor descriptor, out FilterMode filterMode) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ContextContainer), Member = "Get", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(CameraData), Member = "get_xr", ReturnType = typeof(XRPass))]
	[Calls(Type = typeof(XRPass), Member = "get_supportsFoveatedRendering", ReturnType = typeof(bool))]
	[Calls(Type = typeof(RenderingData), Member = "get_commandBuffer", ReturnType = typeof(CommandBuffer&))]
	[Calls(Type = typeof(CommandBuffer), Member = "SetFoveatedRenderingMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FoveatedRenderingMode)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CoreUtils), Member = "SetRenderTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(RTHandle), typeof(RenderBufferLoadAction), typeof(RenderBufferStoreAction), typeof(ClearFlag), typeof(Color), typeof(int), typeof(CubemapFace), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ColorGradingLutPass), Member = "ExecutePass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RasterCommandBuffer), typeof(PassData), typeof(RTHandle)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 6)]
	[Obsolete("This rendering path is for compatibility mode only (when Render Graph is disabled). Use Render Graph API instead.", False)]
	public virtual void Execute(ScriptableRenderContext context, ref RenderingData renderingData) { }

	[CalledBy(Type = typeof(<>c), Member = "<Render>b__14_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PassData), typeof(RasterGraphContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ColorGradingLutPass), Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), typeof(RenderingData&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(XRPass), Member = "StartSinglePass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IRasterCommandBuffer)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Blitter), Member = "BlitTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RasterCommandBuffer), typeof(RTHandle), typeof(Vector4), typeof(Material), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XRPass), Member = "StopSinglePass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseCommandBuffer)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(HDROutputUtils), Member = "ConfigureHDROutput", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material), typeof(ColorGamut), typeof(Operation)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UniversalRenderPipeline), Member = "GetHDROutputGradingParameters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Tonemapping), typeof(Vector4&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UniversalRenderPipeline), Member = "GetHDROutputLuminanceParameters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HDRDisplayInformation), typeof(ColorGamut), typeof(Tonemapping), typeof(Vector4&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UniversalCameraData), Member = "get_hdrDisplayColorGamut", ReturnType = typeof(ColorGamut))]
	[Calls(Type = typeof(UniversalCameraData), Member = "get_hdrDisplayInformation", ReturnType = typeof(HDRDisplayInformation))]
	[Calls(Type = typeof(UniversalCameraData), Member = "get_isHDROutputActive", ReturnType = typeof(bool))]
	[Calls(Type = typeof(TextureCurve), Member = "GetTexture", ReturnType = typeof(Texture2D))]
	[Calls(Type = typeof(Mathf), Member = "GammaToLinearSpace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(Material), Member = "SetVector", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Vector4)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ColorUtils), Member = "PrepareSplitToning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector4&), typeof(Vector4&), typeof(float)}, ReturnType = typeof(System.ValueTuple`2<UnityEngine.Vector4, UnityEngine.Vector4>))]
	[Calls(Type = typeof(ColorUtils), Member = "PrepareLiftGammaGain", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector4&), typeof(Vector4&), typeof(Vector4&)}, ReturnType = typeof(System.ValueTuple`3<UnityEngine.Vector4, UnityEngine.Vector4, UnityEngine.Vector4>))]
	[Calls(Type = typeof(ColorUtils), Member = "PrepareShadowsMidtonesHighlights", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector4&), typeof(Vector4&), typeof(Vector4&)}, ReturnType = typeof(System.ValueTuple`3<UnityEngine.Vector4, UnityEngine.Vector4, UnityEngine.Vector4>))]
	[Calls(Type = typeof(ColorUtils), Member = "ColorBalanceToLMSCoeffs", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(VolumeStack), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(VolumeManager), Member = "get_instance", ReturnType = typeof(VolumeManager))]
	[Calls(Type = typeof(Material), Member = "EnableKeyword", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 50)]
	[CallsUnknownMethods(Count = 68)]
	private static void ExecutePass(RasterCommandBuffer cmd, PassData passData, RTHandle internalLutTarget) { }

	[CalledBy(Type = typeof(UniversalRenderer), Member = "OnBeforeRendering", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ContextContainer), Member = "Get", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(ScriptableRenderPass), Member = "get_profilingSampler", ReturnType = typeof(ProfilingSampler))]
	[Calls(Type = typeof(RenderGraph), Member = "AddRasterRenderPass", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"PassData"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "PassData&", typeof(ProfilingSampler), typeof(string), typeof(int)}, ReturnType = typeof(IRasterRenderGraphBuilder))]
	[Calls(Type = typeof(RenderTextureDescriptor), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(GraphicsFormat), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UniversalRenderer), Member = "CreateRenderGraphTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(RenderTextureDescriptor), typeof(string), typeof(bool), typeof(FilterMode), typeof(TextureWrapMode)}, ReturnType = typeof(TextureHandle))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 23)]
	internal void Render(RenderGraph renderGraph, ContextContainer frameData, out TextureHandle internalColorLut) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public void Setup(in RTHandle internalLut) { }

}

